namespace ConnectFourApp
{
    public partial class frmConnectFour : Form
    {
        Random rnd = new();

        List<Button> lstBtnRow1;
        List<Button> lstBtnRow2;
        List<Button> lstBtnRow3;
        List<Button> lstBtnRow4;
        List<Button> lstBtnRow5;
        List<Button> lstBtnRow6;

        List<List<Button>> lstBtnRowLists;

        List<List<Button>> lstWinningSets;

        bool playAgainstComp = false;
        private enum TurnEnum { red, white };
        TurnEnum currentTurn = TurnEnum.white;

        enum GameStatusEnum { NotStarted, Playing, Tie, Winner };
        GameStatusEnum gameStatus = GameStatusEnum.NotStarted;

        public frmConnectFour()
        {
            InitializeComponent();

            lstBtnRow1 = new() { button1, button2, button3, button4, button5, button6 };
            lstBtnRow2 = new() { button7, button8, button9, button10, button11, button12 };
            lstBtnRow3 = new() { button13, button14, button15, button16, button17, button18 };
            lstBtnRow4 = new() { button19, button20, button21, button22, button23, button24 };
            lstBtnRow5 = new() { button25, button26, button27, button28, button29, button30 };
            lstBtnRow6 = new() { button31, button32, button33, button34, button35, button36 };

            lstBtnRowLists = new() { lstBtnRow1, lstBtnRow2, lstBtnRow3, lstBtnRow4, lstBtnRow5, lstBtnRow6 };

            lstWinningSets = new()
            {
                new() { button1, button2, button3, button4 },
                new() { button2, button3, button4, button5 },
                new() { button6, button3, button4, button5 },
                new() { button7, button8, button9, button10 },
                new() { button11, button8, button9, button10 },
                new() { button11, button12, button9, button10 },
                new() { button13, button14, button15, button16 },
                new() { button17, button14, button15, button16 },
                new() { button17, button18, button15, button16 },

            };


            btnStart.Click += BtnStart_Click;
        }
        
        //Procedures

        private void StopGame()
        {
            foreach (Control c in tblSlots.Controls)
            {
                c.Enabled = false;
            }

            btnStart.Enabled = true;
            opt2Player.Enabled = true;
            optPlayAgainstComp.Enabled = true;
        }
        private void StartGame()
        {
            foreach(Control c in tblSlots.Controls)
            {
                c.Enabled = true;
            }

            btnStart.Enabled = false;
            opt2Player.Enabled = false;
            optPlayAgainstComp.Enabled = false;
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
