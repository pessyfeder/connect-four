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

        List<List<Button>> lstBtnColumnLists;

        List<List<Button>> lstVerticalWinningSets;
        List<List<Button>> lstHorizontalWinningSets;
        List<List<Button>> lstDiagonalLeftRightWinningSets;
        List<List<Button>> lstDiagonalRightLeftWinningSets;

        bool playAgainstComp = false;
        private enum TurnEnum { red, white };
        TurnEnum currentTurn = TurnEnum.white;

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

            lstVerticalWinningSets = new()
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
                new() { button19, button20, button21, button22 },
                new() { button20, button21, button22, button23 },
                new() { button24, button21, button22, button23 },
                new() { button25, button26, button27, button28 },
                new() { button29, button26, button27, button28 },
                new() { button29, button30, button27, button28 },
                new() { button33, button34, button31, button32 },
                new() { button33, button34, button35, button32 },
                new() { button33, button34, button35, button36 },
                new() { button37, button38, button39, button40 },
                new() { button41, button38, button39, button40 },
                new() { button41, button42, button39, button40 },
            };

            lstHorizontalWinningSets = new()
            {
                new() { button1, button7, button13, button19 },
                new() { button25, button7, button13, button19 },
                new() { button25, button31, button13, button19 },
                new() { button25, button31, button37, button19 },
                new() { button2, button8, button14, button20 },
                new() { button26, button8, button14, button20 },
                new() { button14, button20, button26, button32 },
                new() { button20, button26, button32, button38 },
                new() { button3, button9, button15, button21 },
                new() { button9, button15, button21, button27 },
                new() { button15, button21, button27, button33 },
                new() { button21, button27, button33, button39 },
                new() { button4, button10, button16, button22 },
                new() { button10, button16, button22, button28 },
                new() { button16, button22, button28, button34 },
                new() { button22, button28, button34, button40 },
                new() { button5, button11, button17, button23 },
                new() { button11, button17, button23, button29 },
                new() { button17, button23, button29, button35 },
                new() { button23, button29, button35, button41 },
                new() { button6, button12, button18, button24 },
                new() { button12, button18, button24, button30 },
                new() { button18, button24, button30, button36 },
                new() { button24, button30, button36, button42 },
            };

            lstDiagonalLeftRightWinningSets = new()
            {
                new() { button3, button10, button17, button24 },
                new() { button2, button9, button16, button23 },
                new() { button9, button16, button23, button30 },
                new() { button1, button8, button15, button22 },
                new() { button8, button15, button22, button29 },
                new() { button15, button22, button29, button36 },
                new() { button7, button14, button21, button28 },
                new() { button14, button21, button28, button35 },
                new() { button21, button28, button35, button42 },
                new() { button13, button20, button27, button34 },
                new() { button20, button27, button34, button41 },
                new() { button19, button26, button33, button40 }
            };

            lstDiagonalRightLeftWinningSets = new()
            {
                new() { button39, button34, button29, button24 },
                new() { button18, button23, button28, button33 },
                new() { button23, button28, button33, button38 },
                new() { button12, button17, button22, button27 },
                new() { button17, button22, button27, button32 },
                new() { button22, button27, button32, button37 },
                new() { button6, button11, button16, button21 },
                new() { button11, button16, button21, button26 },
                new() { button16, button21, button26, button31 },
                new() { button5, button10, button15, button20 },
                new() { button10, button15, button20, button25 },
                new() { button4, button9, button14, button19 }
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
            foreach (Control c in tblSlots.Controls)
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
