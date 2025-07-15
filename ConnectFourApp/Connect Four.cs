using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ConnectFourApp
{
    public partial class frmConnectFour : Form
    {
        Random rnd = new();
        System.Windows.Forms.Timer tmr = new();
        int tickCount = 0;

        List<Button> lstBtnColumn1;
        List<Button> lstBtnColumn2;
        List<Button> lstBtnColumn3;
        List<Button> lstBtnColumn4;
        List<Button> lstBtnColumn5;
        List<Button> lstBtnColumn6;

        List<List<Button>> lstBtnColumnLists;
        List<List<Button>> lstWinningSets;

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

            lstBtnColumnLists = new() { lstBtnColumn1, lstBtnColumn2, lstBtnColumn3, lstBtnColumn4, lstBtnColumn5, lstBtnColumn6 };

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
                new() { button5, button10, button15, button20, button20, button25 },
                new() { button4, button9, button14, button19 }
            };

            btnStart.Click += BtnStart_Click;

            foreach (Control c in tblSlots.Controls)
            {
                if (c is Button b)
                {
                    b.Click += B_Click;
                }
            }
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
            foreach (List<Button> lstbtn in lstBtnColumnLists)
                if (lstbtn.Where(b => b.BackColor == Color.Transparent).Count() == 0)
                {
                    gameStatus = GameStatusEnum.Tie;
                    lstbtn.ForEach(b => SetButtonBackColor(b));

                    DisplayGameStatus();

                    return;
                }
        }
        private void DetectWinnerorTie(List<Button> lstbtn)
        {
            bool hasFourConsecutiveSameColor = false;

            for (int i = 0; i <= lstbtn.Count - 4; i++)
            {
                if (lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                    lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                    lstbtn[i].BackColor == lstbtn[i + 3].BackColor)
                {
                    hasFourConsecutiveSameColor = true;
                    break;
                }
            }

            if (hasFourConsecutiveSameColor == true)
            {
                gameStatus = GameStatusEnum.Winner;
                tmr.Interval = 500;
                tmr.Tick += Tmr_Tick;
                tickCount = 0;
                tmr.Start();

                DisplayGameStatus();

                return;
            }

            DetectTie();
        }

        private void Tmr_Tick(object? sender, EventArgs e)
        {
            tickCount++;
            if (tickCount == 3)
            {
                tmr.Stop();
            }
            else
            {
                //set the value of lstbtn to the lists within lstWinningSets
                for (int i = 0; i <= lstbtn.Count - 4; i++)
                {
                    // Check if the current button and the next three have the same BackColor
                    if (lstbtn[i].BackColor == lstbtn[i + 1].BackColor &&
                        lstbtn[i].BackColor == lstbtn[i + 2].BackColor &&
                        lstbtn[i].BackColor == lstbtn[i + 3].BackColor)
                    {
                        // Toggle visibility of the four consecutive buttons
                        lstbtn[i].Visible = !lstbtn[i].Visible;
                        lstbtn[i + 1].Visible = !lstbtn[i + 1].Visible;
                        lstbtn[i + 2].Visible = !lstbtn[i + 2].Visible;
                        lstbtn[i + 3].Visible = !lstbtn[i + 3].Visible;
                    }
                }
        }

        private void SwitchTurns()
        {
            currentTurn = currentTurn == TurnEnum.Red ? TurnEnum.Blue : TurnEnum.Red;
        }

        private void DoTurn(List<Button> lstbtn)
        {
            //first switch turns
            if (gameStatus == GameStatusEnum.Playing)
            {
                if (lstbtn.Any(btn => btn.BackColor == Color.Transparent))
                {
                    //put that color onto the lowest available button in the column
                    Button b = lstbtn.Last(btn => btn.BackColor == Color.Transparent);
                    SetButtonBackColor(b);
                    lstWinningSets.ForEach(lstBtn => DetectWinnerorTie(lstBtn));
                    SwitchTurns();
                }
                else
                {
                    MessageBox.Show("Slot is unavailable. Please select another slot.");
                }
            }

            DisplayGameStatus();
        }

        //Display game status on start button
        private void DisplayGameStatus()
        {
            string msg = "Click 'Start' to start game";

            switch (gameStatus)
            {
                case GameStatusEnum.Playing:
                    msg = "Current turn: " + currentTurn.ToString();
                    break;
                case GameStatusEnum.Tie:
                    msg = "Tie!";
                    break;
                case GameStatusEnum.Winner:
                    msg = "Winner is: " + currentTurn.ToString();
                    break;
            }

            msg = playAgainstComp ? optPlayAgainstComp.Text + " - " + msg : opt2Player.Text + " - " + msg;

            btnStart.Text = msg;
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

            opt2Player.Enabled = false;
            optPlayAgainstComp.Enabled = false;

            gameStatus = GameStatusEnum.Playing;

            DisplayGameStatus();
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button clickedButton = (Button)sender;

                if (lstBtnColumn1.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn1);
                }
                else if (lstBtnColumn2.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn2);
                }
                else if (lstBtnColumn3.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn3);
                }
                else if (lstBtnColumn4.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn4);
                }
                else if (lstBtnColumn5.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn5);
                }
                else if (lstBtnColumn6.Contains(clickedButton))
                {
                    DoTurn(lstBtnColumn6);
                }
            }
        }


    }
}
