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

        List<Button> lstBtnColumn1;
        List<Button> lstBtnColumn2;
        List<Button> lstBtnColumn3;
        List<Button> lstBtnColumn4;
        List<Button> lstBtnColumn5;
        List<Button> lstBtnColumn6;
        List<Button> lstBtnColumn7;

        List<List<Button>> lstBtnColumnLists;
        List<List<Button>> lstWinningSets;
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
            if (gameStatus == GameStatusEnum.Playing)
            {
                c = currentTurn == TurnEnum.Red ? Color.Red : Color.Blue;

                btn.BackColor = c;
            }
        }

        private bool IsLastTransparentButtonInAnyList(Button targetButton, List<List<Button>> listOfButtonLists)
        {
            int n = 0;
            foreach (var buttonList in listOfButtonLists)
            {
                n++;
                bool b = buttonList.Contains(targetButton);
                // Filter for transparent buttons in the current list
                if (b)
                {
                    var transparentButtons = buttonList.Where(b => b.BackColor == Color.Transparent).ToList();
                    // Check if the target button is present and is the last transparent button

                    if (transparentButtons.Any() && transparentButtons.Last() == targetButton)
                    {
                        return true;

                    }
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

        private void DetectWinnerorTie()
        {
            foreach (var winningSet in lstWinningSets)
            {
                if (IsWinner(winningSet))
                {
                    gameStatus = GameStatusEnum.Winner;
                    EnableControls();
                    DisplayGameStatus();
                    return;
                }
                else
                {
                    DetectTie();
                }
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
                    Button b = lstbtn.Last(btn => btn.BackColor == Color.Transparent);
                    SetButtonBackColor(b);

                    DetectWinnerorTie();

                    if (gameStatus == GameStatusEnum.Playing)
                    {
                        SwitchTurns();

                        if (IsComputerTurn())
                        {
                            DisplayGameStatus();
                            //DoComputerTurn()
                            //this method calls: 
                            //DoCompDefense - finds TWO-THREE consec RED tiles and blocks on either side
                            //Do first
                            //If yes, switch turns.
                            //If still comp turn
                            //DoCompOffense - finds blue tiles on board 
                            //if there's three in row - complete
                            //if there's two in row - add before / after 
                            //if there's one - add before or after 
                            //if any of the conditions are satisfied - switch turns
                            //DoCompRandom 
                            //If no other conditions are met; Initial move
                            //switch turns


                            await Task.Delay(1000);
                            DoComputerTurnOffenseDefense();

                            if (IsComputerTurn())
                            {
                                DoComputerTurnRandom();
                            }

                            DetectWinnerorTie();
                        }
                    }

                    DisplayGameStatus();
                }

                else
                {
                    if (IsComputerTurn())
                    {
                        //eventually change to DoCompTurn()? 
                        //Do I want it to go through the whole algorithm again?
                        DoComputerTurnRandom();
                    }

                    MessageBox.Show("Slot is unavailable. Please select another slot.");
                }
            }
        }

        private void DoComputerTurnOffenseDefense()
        {
            for (int index = 0; index < lstWinningSets.Count; index++)
            {
                var lst = lstWinningSets[index];
                if (HasThreeColoredTiles(lst, out Button b3, index)) // Pass the index to the function
                {
                    Debug.Print("Found Three Colored true in WinningSet " + index);

                    bool b = IsLastTransparentButtonInAnyList(b3, lstBtnColumnLists);
                    if (b == true)
                    {
                        SetButtonBackColor(b3);
                    }
                    else
                    {
                        MessageBox.Show("cannot add tile");
                        return;
                    }

                    DetectWinnerorTie();

                    foreach (var lstBtn in lstWinningSets)
                    {
                        if (!IsWinner(lstBtn))
                        {
                            SwitchTurns();
                        }
                    }
                    return;
                }
                else
                {
                    Debug.Print("DoComputerTurnOffenseDefense found nothing");
                }
            }
        }

        private void PrintList(List<Button> lst)
        {
            foreach (var b in lst)
            {
                Debug.Print(b.Name + " " + b.BackColor.ToString());
            }
        }
        private bool HasThreeColoredTiles(List<Button> lstbtn, out Button b3, int listIndex)
        {
            PrintList(lstbtn);

            if (lstbtn.Count >= 4)
            {
                for (int i = 0; i <= lstbtn.Count - 4; i++)
                {
                    List<Button> lstinloop = new() { lstbtn[i], lstbtn[i + 1], lstbtn[i + 2], lstbtn[i + 3] };

                    int numt = lstinloop.Count(b => b.BackColor == Color.Transparent);
                    int numr = lstinloop.Count(b => b.BackColor == Color.Red);
                    int numb = lstinloop.Count(b => b.BackColor == Color.Blue);

                    Debug.Print($"t {numt}, red {numr}, blue {numb} in WinningList {listIndex} at index {i}");

                    bool hasThreeColoredAndOneTrans = (numr == 3 || numb == 3) && numt == 1;

                    if (hasThreeColoredAndOneTrans)
                    {
                        b3 = lstinloop.FirstOrDefault(b => b.BackColor == Color.Transparent);

                        Debug.Print($"HasThreeConsecTiles in WinningList {listIndex} at index {i} true");
                        return true;
                    }                    
                } 
            }

            Debug.Print("HasThreeColoredTiles false in WinningList " + listIndex); // Include list index
            b3 = null;
            return false;
        }
        
        private void DoComputerTurnRandom()
        {
            // picks a random list with available transparent button(s)
            // and then calls DoTurn(), which sets "b" as the lowest transparent button in the list.
            Debug.Print("DoComputerTurnRandom");
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