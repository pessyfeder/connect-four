using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ConnectFourApp
{
    public partial class frmConnectFour : Form
    {
        Random rnd = new();
        Button b = new();

        List<Button> lstBtnColumn1;
        List<Button> lstBtnColumn2;
        List<Button> lstBtnColumn3;
        List<Button> lstBtnColumn4;
        List<Button> lstBtnColumn5;
        List<Button> lstBtnColumn6;
        List<Button> lstBtnColumn7;

        List<List<Button>> lstBtnColumnLists;
        List<List<Button>> lstWinningSets;

        List<Button> lstHasThreeConsec;
        List<Button> lstHasTwoConsecAndOneNone;

        List<RadioButton> lstOpt;

        bool playAgainstComp = false;
        private enum TurnEnum { Red, Blue };
        TurnEnum currentTurn = TurnEnum.Red;

        enum GameStatusEnum { NotStarted, Playing, Tie, Winner };
        GameStatusEnum gameStatus = GameStatusEnum.NotStarted;

        public frmConnectFour()
        {
            InitializeComponent();

            lstBtnColumn1 = new() { button1, button2, button3, button4, button5, button6 };
            lstBtnColumn2 = new() { button7, button8, button9, button10, button11, button12 };
            lstBtnColumn3 = new() { button13, button14, button15, button16, button17, button18 };
            lstBtnColumn4 = new() { button19, button20, button21, button22, button23, button24 };
            lstBtnColumn5 = new() { button25, button26, button27, button28, button29, button30 };
            lstBtnColumn6 = new() { button31, button32, button33, button34, button35, button36 };
            lstBtnColumn7 = new() { button37, button38, button39, button40, button41, button42 };

            lstBtnColumnLists = new() { lstBtnColumn1, lstBtnColumn2, lstBtnColumn3, lstBtnColumn4, lstBtnColumn5, lstBtnColumn6, lstBtnColumn7 };

            lstWinningSets = new()
            {
                new() { button1, button2, button3, button4, button5, button6 },
                new() { button7, button8, button9, button10, button11, button12 },
                new() { button13, button14, button15, button16, button17, button18 },
                new() { button19, button20, button21, button22, button23, button24 },
                new() { button25, button26, button27, button28, button29, button30 },
                new() { button31, button32, button33, button34, button35, button36 },
                new() { button37, button38, button39, button40, button41, button42 },
                new() { button1, button7, button13, button19, button25, button31, button37 },
                new() { button2, button8, button14, button20, button26, button32, button38 },
                new() { button3, button9, button15, button21, button27, button33, button39 },
                new() { button4, button10, button16, button22, button28, button34, button40 },
                new() { button5, button11, button17, button23, button29, button35, button41 },
                new() { button6, button12, button18, button24, button30, button36, button42 },
                new() { button3, button10, button17, button24 },
                new() { button2, button9, button16, button23, button30 },
                new() { button1, button8, button15, button22, button29, button36 },
                new() { button7, button14, button21, button28, button35, button42 },
                new() { button13, button20, button27, button34, button41 },
                new() { button19, button26, button33, button40 },
                new() { button39, button34, button29, button24 },
                new() { button18, button23, button28, button33, button38 },
                new() { button12, button17, button22, button27, button32, button37 },
                new() { button6, button11, button16, button21, button26, button31 },
                new() { button5, button10, button15, button20, button25 },
                new() { button4, button9, button14, button19 }
            };

            lstOpt = new() { opt2Player, optPlayAgainstComp };

            lstOpt.ForEach(l => l.CheckedChanged += L_CheckedChanged);

            btnStart.Click += BtnStart_Click;

            foreach (Control c in tblSlots.Controls)
            {
                if (c is Button b)
                {
                    b.Click += B_Click;
                }
            }
        }

        private void StartGame()
        {
            foreach (Control c in tblSlots.Controls)
            {
                if (c is Button b)
                {
                    b.Enabled = true;
                    b.BackColor = Color.Transparent;
                }
            }

            playAgainstComp = optPlayAgainstComp.Checked;
            currentTurn = TurnEnum.Red;

            if (gameStatus == GameStatusEnum.NotStarted)
            {
                DisableControls();
            }
            else if (gameStatus == GameStatusEnum.Playing)
            {
                EnableControls();
            }

            gameStatus = GameStatusEnum.Playing;

            SetLblStatusForecolor();
            DisplayGameStatus();
        }

        private void SetLblStatusForecolor()
        {
            Color statusColor = currentTurn == TurnEnum.Blue ? Color.Blue : Color.Red;
            lblStatus.ForeColor = statusColor;
        }

        private void EnableControls()
        {
            opt2Player.Enabled = true;
            optPlayAgainstComp.Enabled = true;
        }

        private void DisableControls()
        {
            opt2Player.Enabled = false;
            optPlayAgainstComp.Enabled = false;
        }

        private void SetButtonBackColor(Button btn)
        {
            Color c = Color.Transparent;

            if (gameStatus == GameStatusEnum.Playing &&
                IsLastTransparentButtonInAnyList(btn, lstBtnColumnLists))
            {
                c = currentTurn == TurnEnum.Red ? Color.Red : Color.Blue;
            }
            else
            {
                MessageBox.Show("cannot add tile");
                return;
            }

            btn.BackColor = c;
        }

        private bool IsLastTransparentButtonInAnyList(Button targetButton, List<List<Button>> listOfButtonLists)
        {
            foreach (var buttonList in listOfButtonLists)
            {
                // Filter for transparent buttons in the current list
                var transparentButtons = buttonList.Where(b => b.BackColor == Color.Transparent).ToList();

                // Check if the target button is present and is the last transparent button
                if (transparentButtons.Any() && transparentButtons.Last() == targetButton)
                {
                    return true;
                }
            }
            return false;
        }

        private void DetectTie()
        {
            foreach (Control c in tblSlots.Controls)
            {
                if (c is Button b && b.BackColor == Color.Transparent)
                {
                    //exit method if any transparent button is found
                    return;
                }

                gameStatus = GameStatusEnum.Tie;
                DisplayGameStatus();
            }
        }

        private bool IsWinner(List<Button> lstbtn)
        {
            for (int i = 0; i <= lstbtn.Count - 4; i++)
            {
                if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                    &&
                    lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                    lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                    lstbtn[i].BackColor == lstbtn[i + 3].BackColor)
                {
                    return true;
                }
            }
            return false;
        }

        private void DetectWinnerorTie(List<Button> lstbtn)
        {
            if (IsWinner(lstbtn))
            {
                gameStatus = GameStatusEnum.Winner;
                EnableControls();
                DisplayGameStatus();
            }

            else
            {
                DetectTie();
            }
        }

        private void SwitchTurns()
        {
            currentTurn = currentTurn == TurnEnum.Red ? TurnEnum.Blue : TurnEnum.Red;
        }

        private bool HasAvailableButtons(List<Button> lstbtn)
        {
            return lstbtn.Any(btn => btn.BackColor == Color.Transparent);
        }

        private async Task DoTurn(List<Button> lstbtn)
        {
            if (gameStatus == GameStatusEnum.Playing)
            {
                DisableControls();

                if (HasAvailableButtons(lstbtn))
                {
                    b = lstbtn.Last(btn => btn.BackColor == Color.Transparent);
                    SetButtonBackColor(b);

                    lstWinningSets.ForEach(lstBtn => DetectWinnerorTie(lstBtn));

                    if (gameStatus == GameStatusEnum.Playing)
                    {
                        SwitchTurns();

                        if (IsComputerTurn())
                        {
                            DisplayGameStatus();

                            await Task.Delay(1000);
                            DoComputerTurnOffenseDefense();

                            if (IsComputerTurn())
                            {
                                DoComputerTurnRandom();
                            }

                            lstWinningSets.ForEach(lstBtn => DetectWinnerorTie(lstBtn));
                        }
                    }

                    DisplayGameStatus();
                }
                //in each event, SetButtonBackColor(b); the value of b just changes. How do I do that?
                else
                {
                    MessageBox.Show("Slot is unavailable. Please select another slot.");
                }
            }
        }

        private void DoComputerTurnOffenseDefense()
        {
            if (lstWinningSets.Any(lst => HasThreeConsecTiles(lst, out Button b)))
            {
                Debug.Print("Found Three Consec");
                //MessageBox.Show("Found Three Consec");
                SetButtonBackColor(b);
                SwitchTurns();
                return; // Exit after handling the case
            }
            else if (lstWinningSets.Any(lst => HasTwoConsecAndOneNone(lst, out Button b)))
            {
                Debug.Print("Found Two Consec and One Empty");
                //MessageBox.Show("");
                SetButtonBackColor(b); // Modify bTwo
                SwitchTurns();
                return; // Exit after handling the case
            }
            else
            {
                Debug.Print("DoComputerTurnOffenseDefense found nothing");
                return;
            }
        }

        private bool HasTwoConsecAndOneNone(List<Button> lstbtn, out Button b)
        {
            lstHasTwoConsecAndOneNone = new();
            b = null;

            if (lstbtn.Count >= 4)
            {
                for (int i = 0; i <= lstbtn.Count - 4; i++)
                {
                    if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                        &&
                        lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                        lstbtn[i + 2].BackColor == Color.Transparent &&
                        lstbtn[i].BackColor == lstbtn[i + 3].BackColor)
                    {
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i]);
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i + 1]);
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i + 3]);

                        b = lstbtn[i + 2];

                        return true;
                    }
                    else if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                        &&
                        lstbtn[i + 1].BackColor == Color.Transparent &&
                        lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                        lstbtn[i + 3].BackColor == lstbtn[i].BackColor)
                    {
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i]);
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i + 2]);
                        lstHasTwoConsecAndOneNone.Add(lstbtn[i + 3]);

                        b = lstbtn[i + 1];

                        return true;
                    }
                }
            }
            return false;
        }

        private bool HasThreeConsecTiles(List<Button> lstbtn, out Button b)
        {
            lstHasThreeConsec = new();
            b = null;

            if (lstbtn.Count >= 4)
            {
                for (int i = 0; i <= lstbtn.Count - 4; i++)
                {
                    //which list is lstbtn?
                    if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                        &&
                        lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                        lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                        // Check if the button before or after this list is transparent
                        ((i - 1 >= 0 && lstbtn[i - 1].BackColor == Color.Transparent) ||
                        (i + 3 <= (lstbtn.Count - 1) && lstbtn[i + 3].BackColor == Color.Transparent)))
                    {
                        //add the three buttons to the list
                        lstHasThreeConsec.Add(lstbtn[i]);
                        lstHasThreeConsec.Add(lstbtn[i + 1]);
                        lstHasThreeConsec.Add(lstbtn[i + 2]);

                        b = (i - 1 >= 0 && lstbtn[i - 1].BackColor == Color.Transparent) ? lstbtn[i - 1] : lstbtn[i + 3];
                        Debug.Print("HasThreeConsecTiles true");
                        return true;
                    }
                }
            }
            Debug.Print("HasThreeConsecTiles false");
            return false;
        }

        private void DoComputerTurnRandom()
        {
            // picks a random list with available transparent button(s)
            // and then calls DoTurn(), which sets "b" as the lowest transparent button in the list.
            var randomList = lstBtnColumnLists[rnd.Next(0, lstBtnColumnLists.Count())].Where(b => b.BackColor == Color.Transparent).ToList();
            DoTurn(randomList);
        }

        private bool IsComputerTurn()
        {
            return currentTurn == TurnEnum.Blue && gameStatus == GameStatusEnum.Playing && playAgainstComp == true;
        }

        private void DisplayGameStatus()
        {
            string msg = "";
            string restartText = "Click me to restart game";
            Font newfont = new("Comic Sans MS", 14, FontStyle.Bold);

            switch (gameStatus)
            {
                case GameStatusEnum.Playing:
                    msg = "Current turn: " + currentTurn.ToString();
                    btnStart.Text = restartText;
                    btnStart.Font = newfont;
                    break;
                case GameStatusEnum.Tie:
                    msg = "Tie!";
                    btnStart.Text = restartText;
                    break;
                case GameStatusEnum.Winner:
                    msg = "Winner is: " + currentTurn.ToString();
                    btnStart.Text = restartText;
                    break;
            }

            msg = playAgainstComp ? optPlayAgainstComp.Text + " - " + msg : opt2Player.Text + " - " + msg;

            lblStatus.Text = msg;

            SetLblStatusForecolor();
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
        private void L_CheckedChanged(object? sender, EventArgs e)
        {
            if (gameStatus == GameStatusEnum.Playing)
            {
                StartGame();
            }
        }
        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                foreach (var columnButtons in lstBtnColumnLists)
                {
                    if (columnButtons.Contains(clickedButton))
                    {
                        DoTurn(columnButtons);
                        break;
                    }
                }
            }
        }
    }
}