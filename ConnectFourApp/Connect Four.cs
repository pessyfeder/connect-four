using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ConnectFourApp
{
    public partial class frmConnectFour : Form
    {
        Random rnd = new();

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
            if (currentTurn == TurnEnum.Blue)
            {
                lblStatus.ForeColor = Color.Blue;
            }

            else
            {
                lblStatus.ForeColor = Color.Red;
            }
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
            if (gameStatus == GameStatusEnum.Playing)
            {
                c = currentTurn == TurnEnum.Red ? Color.Red : Color.Blue;
            }
            btn.BackColor = c;
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
            SetLblStatusForecolor();
        }
        private void DoTurn(List<Button> lstbtn)
        {
            if (gameStatus == GameStatusEnum.Playing)
            {
                DisableControls();

                if (lstbtn.Any(btn => btn.BackColor == Color.Transparent))
                {
                    Button b = new();
                    if (IsComputerTurn())
                    {
                        if (lstHasThreeConsec.Any(b => b.BackColor == Color.Transparent))
                        {
                            // Get the first (lowest index) transparent button in the lstHasThreeConsec
                            b = lstHasThreeConsec.First(btn => btn.BackColor == Color.Transparent);
                            //b = SHOULD BE the first (lowest index) CONSECUTIVE transparent button in that list
                            //maybe copy logic from HasTwoConecAndOneNone() method
                        }
                    }
                    else if (lstHasTwoConsecAndOneNone.Any(b => b.BackColor == Color.Transparent))
                    {
                        //b = SHOULD BE the transparent button identified
                        b = lstHasTwoConsecAndOneNone.First(b => b.BackColor == Color.Transparent);
                    }
                    else
                    {
                        //button is the lowest available button in the column
                        b = lstbtn.Last(btn => btn.BackColor == Color.Transparent);
                    }
                    //put the current turn's color on that button
                    SetButtonBackColor(b);

                    lstWinningSets.ForEach(lstBtn => DetectWinnerorTie(lstBtn));

                    lstWinningSets.ForEach(lstBtn =>
                    {
                        // Only switch turns if there's no winner
                        if (!IsWinner(lstBtn))
                        {
                            SwitchTurns();
                        }
                    });

                    if (IsComputerTurn())
                    {
                        DoComputerTurnOffenseDefense();

                        if (IsComputerTurn())
                        {
                            DoComputerTurnRandom();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Slot is unavailable. Please select another slot.");
                }
            }

            DisplayGameStatus();
        }

        private void DoComputerTurnOffenseDefense()
        {
            // Clear previous lists to ensure fresh search
            lstHasThreeConsec = new List<Button>();
            lstHasTwoConsecAndOneNone = new List<Button>();

            // Search for all sets of three consecutive buttons
            foreach (var winningSet in lstWinningSets)
            {
                if (HasThreeConsecTiles(winningSet))
                {
                    lstHasThreeConsec.AddRange(winningSet); // Add all buttons in this set
                }
                else if (HasTwoConsecAndOneNone(winningSet))
                {
                    lstHasTwoConsecAndOneNone.AddRange(winningSet); // Add all buttons in this set
                }
            }

            if (lstHasThreeConsec.Any())
            {
                MessageBox.Show("Computer will block/complete with three consecutive tiles.");
                DoTurn(lstHasThreeConsec);
            }
            else if (lstHasTwoConsecAndOneNone.Any())
            {
                MessageBox.Show("Computer will block with two consecutive tiles and one empty.");
                DoTurn(lstHasTwoConsecAndOneNone);
            }
            else
            {
                MessageBox.Show("No offensive/defensive move available, return.");
                return;
            }
        }
        private bool HasTwoConsecAndOneNone(List<Button> lstbtn)
        {
            for (int i = 0; i <= lstbtn.Count - 4; i++)
            {
                if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                    &&
                    lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                    lstbtn[i].BackColor == Color.Transparent &&
                    lstbtn[i].BackColor == lstbtn[i + 3].BackColor)
                {
                    return true;
                }
            }
            return false;
        }

        //returns true if there are three consecutive tiles and one transparent
        private bool HasThreeConsecTiles(List<Button> lstbtn)
        {
            for (int i = 0; i <= lstbtn.Count - 4; i++)
            {
                if ((lstbtn[i].BackColor == Color.Red || lstbtn[i].BackColor == Color.Blue)
                    &&
                    lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                    lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                    // Check if the button before or after this list is transparent
                    ((i - 1 >= 0 && lstbtn[i - 1].BackColor == Color.Transparent) ||
                    (i + 3 <= (lstbtn.Count - 1) && lstbtn[i + 3].BackColor == Color.Transparent)))
                {
                    return true;
                }
            }
            return false;
        }

        private void DoComputerTurnRandom()
        {
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
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
        private void L_CheckedChanged(object? sender, EventArgs e)
        {
            StartGame();
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