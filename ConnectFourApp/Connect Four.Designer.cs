namespace ConnectFourApp
{
    partial class frmConnectFour
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            tblControls = new TableLayoutPanel();
            btnStart = new Button();
            flwPlayerOptions = new FlowLayoutPanel();
            optPlayAgainstComp = new RadioButton();
            opt2Player = new RadioButton();
            tblSlots = new TableLayoutPanel();
            tblRow1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tblRow2 = new TableLayoutPanel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            tblRow3 = new TableLayoutPanel();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            tblRow4 = new TableLayoutPanel();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            tblRow5 = new TableLayoutPanel();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            tblRow6 = new TableLayoutPanel();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button35 = new Button();
            button36 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button37 = new Button();
            button38 = new Button();
            button39 = new Button();
            button40 = new Button();
            button41 = new Button();
            button42 = new Button();
            tblMain.SuspendLayout();
            tblControls.SuspendLayout();
            flwPlayerOptions.SuspendLayout();
            tblSlots.SuspendLayout();
            tblRow1.SuspendLayout();
            tblRow2.SuspendLayout();
            tblRow3.SuspendLayout();
            tblRow4.SuspendLayout();
            tblRow5.SuspendLayout();
            tblRow6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tblControls, 0, 0);
            tblMain.Controls.Add(tblSlots, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tblMain.Size = new Size(1155, 664);
            tblMain.TabIndex = 0;
            // 
            // tblControls
            // 
            tblControls.Anchor = AnchorStyles.None;
            tblControls.ColumnCount = 2;
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblControls.Controls.Add(btnStart, 0, 0);
            tblControls.Controls.Add(flwPlayerOptions, 1, 0);
            tblControls.Location = new Point(3, 3);
            tblControls.Name = "tblControls";
            tblControls.RowCount = 1;
            tblControls.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblControls.Size = new Size(1149, 93);
            tblControls.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = SystemColors.HotTrack;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(568, 87);
            btnStart.TabIndex = 0;
            btnStart.Text = "Click Me to Start Game";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // flwPlayerOptions
            // 
            flwPlayerOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flwPlayerOptions.AutoSize = true;
            flwPlayerOptions.Controls.Add(optPlayAgainstComp);
            flwPlayerOptions.Controls.Add(opt2Player);
            flwPlayerOptions.Location = new Point(577, 26);
            flwPlayerOptions.Name = "flwPlayerOptions";
            flwPlayerOptions.Size = new Size(569, 41);
            flwPlayerOptions.TabIndex = 0;
            // 
            // optPlayAgainstComp
            // 
            optPlayAgainstComp.AllowDrop = true;
            optPlayAgainstComp.AutoSize = true;
            optPlayAgainstComp.Dock = DockStyle.Fill;
            optPlayAgainstComp.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optPlayAgainstComp.Location = new Point(3, 3);
            optPlayAgainstComp.Name = "optPlayAgainstComp";
            optPlayAgainstComp.Size = new Size(316, 35);
            optPlayAgainstComp.TabIndex = 0;
            optPlayAgainstComp.Text = "Play Against the Computer";
            optPlayAgainstComp.UseVisualStyleBackColor = true;
            // 
            // opt2Player
            // 
            opt2Player.AllowDrop = true;
            opt2Player.AutoSize = true;
            opt2Player.Checked = true;
            opt2Player.Dock = DockStyle.Fill;
            opt2Player.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            opt2Player.Location = new Point(325, 3);
            opt2Player.Name = "opt2Player";
            opt2Player.Size = new Size(133, 35);
            opt2Player.TabIndex = 0;
            opt2Player.TabStop = true;
            opt2Player.Text = "2 Players";
            opt2Player.UseVisualStyleBackColor = true;
            // 
            // tblSlots
            // 
            tblSlots.ColumnCount = 7;
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28531F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853069F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881641F));
            tblSlots.Controls.Add(tblRow1, 0, 0);
            tblSlots.Controls.Add(tblRow2, 1, 0);
            tblSlots.Controls.Add(tblRow3, 2, 0);
            tblSlots.Controls.Add(tblRow4, 3, 0);
            tblSlots.Controls.Add(tblRow5, 4, 0);
            tblSlots.Controls.Add(tblRow6, 5, 0);
            tblSlots.Controls.Add(tableLayoutPanel1, 6, 0);
            tblSlots.Dock = DockStyle.Fill;
            tblSlots.Location = new Point(3, 168);
            tblSlots.Name = "tblSlots";
            tblSlots.RowCount = 1;
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSlots.Size = new Size(1149, 493);
            tblSlots.TabIndex = 1;
            // 
            // tblRow1
            // 
            tblRow1.ColumnCount = 1;
            tblRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow1.Controls.Add(button1, 0, 0);
            tblRow1.Controls.Add(button2, 0, 1);
            tblRow1.Controls.Add(button3, 0, 2);
            tblRow1.Controls.Add(button4, 0, 3);
            tblRow1.Controls.Add(button5, 0, 4);
            tblRow1.Controls.Add(button6, 0, 5);
            tblRow1.Dock = DockStyle.Fill;
            tblRow1.Location = new Point(3, 3);
            tblRow1.Name = "tblRow1";
            tblRow1.RowCount = 6;
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow1.Size = new Size(158, 487);
            tblRow1.TabIndex = 0;
            tblRow1.TabStop = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(152, 75);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Location = new Point(3, 84);
            button2.Name = "button2";
            button2.Size = new Size(152, 75);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Enabled = false;
            button3.Location = new Point(3, 165);
            button3.Name = "button3";
            button3.Size = new Size(152, 75);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Enabled = false;
            button4.Location = new Point(3, 246);
            button4.Name = "button4";
            button4.Size = new Size(152, 75);
            button4.TabIndex = 3;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Enabled = false;
            button5.Location = new Point(3, 327);
            button5.Name = "button5";
            button5.Size = new Size(152, 75);
            button5.TabIndex = 4;
            button5.TabStop = false;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Enabled = false;
            button6.Location = new Point(3, 408);
            button6.Name = "button6";
            button6.Size = new Size(152, 76);
            button6.TabIndex = 5;
            button6.TabStop = false;
            button6.UseVisualStyleBackColor = true;
            // 
            // tblRow2
            // 
            tblRow2.ColumnCount = 1;
            tblRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow2.Controls.Add(button7, 0, 0);
            tblRow2.Controls.Add(button8, 0, 1);
            tblRow2.Controls.Add(button9, 0, 2);
            tblRow2.Controls.Add(button10, 0, 3);
            tblRow2.Controls.Add(button11, 0, 4);
            tblRow2.Controls.Add(button12, 0, 5);
            tblRow2.Dock = DockStyle.Fill;
            tblRow2.Location = new Point(167, 3);
            tblRow2.Name = "tblRow2";
            tblRow2.RowCount = 6;
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.Size = new Size(158, 487);
            tblRow2.TabIndex = 1;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Enabled = false;
            button7.Location = new Point(3, 3);
            button7.Name = "button7";
            button7.Size = new Size(152, 75);
            button7.TabIndex = 0;
            button7.TabStop = false;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Enabled = false;
            button8.Location = new Point(3, 84);
            button8.Name = "button8";
            button8.Size = new Size(152, 75);
            button8.TabIndex = 1;
            button8.TabStop = false;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Enabled = false;
            button9.Location = new Point(3, 165);
            button9.Name = "button9";
            button9.Size = new Size(152, 75);
            button9.TabIndex = 2;
            button9.TabStop = false;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Enabled = false;
            button10.Location = new Point(3, 246);
            button10.Name = "button10";
            button10.Size = new Size(152, 75);
            button10.TabIndex = 3;
            button10.TabStop = false;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Enabled = false;
            button11.Location = new Point(3, 327);
            button11.Name = "button11";
            button11.Size = new Size(152, 75);
            button11.TabIndex = 4;
            button11.TabStop = false;
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Enabled = false;
            button12.Location = new Point(3, 408);
            button12.Name = "button12";
            button12.Size = new Size(152, 76);
            button12.TabIndex = 5;
            button12.TabStop = false;
            button12.UseVisualStyleBackColor = true;
            // 
            // tblRow3
            // 
            tblRow3.ColumnCount = 1;
            tblRow3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow3.Controls.Add(button13, 0, 0);
            tblRow3.Controls.Add(button14, 0, 1);
            tblRow3.Controls.Add(button15, 0, 2);
            tblRow3.Controls.Add(button16, 0, 3);
            tblRow3.Controls.Add(button17, 0, 4);
            tblRow3.Controls.Add(button18, 0, 5);
            tblRow3.Dock = DockStyle.Fill;
            tblRow3.Location = new Point(331, 3);
            tblRow3.Name = "tblRow3";
            tblRow3.RowCount = 6;
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.Size = new Size(158, 487);
            tblRow3.TabIndex = 2;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Enabled = false;
            button13.Location = new Point(3, 3);
            button13.Name = "button13";
            button13.Size = new Size(152, 75);
            button13.TabIndex = 0;
            button13.TabStop = false;
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Enabled = false;
            button14.Location = new Point(3, 84);
            button14.Name = "button14";
            button14.Size = new Size(152, 75);
            button14.TabIndex = 1;
            button14.TabStop = false;
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Enabled = false;
            button15.Location = new Point(3, 165);
            button15.Name = "button15";
            button15.Size = new Size(152, 75);
            button15.TabIndex = 2;
            button15.TabStop = false;
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Enabled = false;
            button16.Location = new Point(3, 246);
            button16.Name = "button16";
            button16.Size = new Size(152, 75);
            button16.TabIndex = 3;
            button16.TabStop = false;
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Enabled = false;
            button17.Location = new Point(3, 327);
            button17.Name = "button17";
            button17.Size = new Size(152, 75);
            button17.TabIndex = 4;
            button17.TabStop = false;
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Fill;
            button18.Enabled = false;
            button18.Location = new Point(3, 408);
            button18.Name = "button18";
            button18.Size = new Size(152, 76);
            button18.TabIndex = 5;
            button18.TabStop = false;
            button18.UseVisualStyleBackColor = true;
            // 
            // tblRow4
            // 
            tblRow4.ColumnCount = 1;
            tblRow4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow4.Controls.Add(button19, 0, 0);
            tblRow4.Controls.Add(button20, 0, 1);
            tblRow4.Controls.Add(button21, 0, 2);
            tblRow4.Controls.Add(button22, 0, 3);
            tblRow4.Controls.Add(button23, 0, 4);
            tblRow4.Controls.Add(button24, 0, 5);
            tblRow4.Dock = DockStyle.Fill;
            tblRow4.Location = new Point(495, 3);
            tblRow4.Name = "tblRow4";
            tblRow4.RowCount = 6;
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.Size = new Size(158, 487);
            tblRow4.TabIndex = 3;
            // 
            // button19
            // 
            button19.Dock = DockStyle.Fill;
            button19.Enabled = false;
            button19.Location = new Point(3, 3);
            button19.Name = "button19";
            button19.Size = new Size(152, 75);
            button19.TabIndex = 0;
            button19.TabStop = false;
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Fill;
            button20.Enabled = false;
            button20.Location = new Point(3, 84);
            button20.Name = "button20";
            button20.Size = new Size(152, 75);
            button20.TabIndex = 1;
            button20.TabStop = false;
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Dock = DockStyle.Fill;
            button21.Enabled = false;
            button21.Location = new Point(3, 165);
            button21.Name = "button21";
            button21.Size = new Size(152, 75);
            button21.TabIndex = 2;
            button21.TabStop = false;
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Dock = DockStyle.Fill;
            button22.Enabled = false;
            button22.Location = new Point(3, 246);
            button22.Name = "button22";
            button22.Size = new Size(152, 75);
            button22.TabIndex = 3;
            button22.TabStop = false;
            button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            button23.Dock = DockStyle.Fill;
            button23.Enabled = false;
            button23.Location = new Point(3, 327);
            button23.Name = "button23";
            button23.Size = new Size(152, 75);
            button23.TabIndex = 4;
            button23.TabStop = false;
            button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            button24.Dock = DockStyle.Fill;
            button24.Enabled = false;
            button24.Location = new Point(3, 408);
            button24.Name = "button24";
            button24.Size = new Size(152, 76);
            button24.TabIndex = 5;
            button24.TabStop = false;
            button24.UseVisualStyleBackColor = true;
            // 
            // tblRow5
            // 
            tblRow5.ColumnCount = 1;
            tblRow5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow5.Controls.Add(button25, 0, 0);
            tblRow5.Controls.Add(button26, 0, 1);
            tblRow5.Controls.Add(button27, 0, 2);
            tblRow5.Controls.Add(button28, 0, 3);
            tblRow5.Controls.Add(button29, 0, 4);
            tblRow5.Controls.Add(button30, 0, 5);
            tblRow5.Dock = DockStyle.Fill;
            tblRow5.Location = new Point(659, 3);
            tblRow5.Name = "tblRow5";
            tblRow5.RowCount = 6;
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.Size = new Size(158, 487);
            tblRow5.TabIndex = 4;
            // 
            // button25
            // 
            button25.Dock = DockStyle.Fill;
            button25.Enabled = false;
            button25.Location = new Point(3, 3);
            button25.Name = "button25";
            button25.Size = new Size(152, 75);
            button25.TabIndex = 0;
            button25.TabStop = false;
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Dock = DockStyle.Fill;
            button26.Enabled = false;
            button26.Location = new Point(3, 84);
            button26.Name = "button26";
            button26.Size = new Size(152, 75);
            button26.TabIndex = 1;
            button26.TabStop = false;
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Dock = DockStyle.Fill;
            button27.Enabled = false;
            button27.Location = new Point(3, 165);
            button27.Name = "button27";
            button27.Size = new Size(152, 75);
            button27.TabIndex = 2;
            button27.TabStop = false;
            button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            button28.Dock = DockStyle.Fill;
            button28.Enabled = false;
            button28.Location = new Point(3, 246);
            button28.Name = "button28";
            button28.Size = new Size(152, 75);
            button28.TabIndex = 3;
            button28.TabStop = false;
            button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            button29.Dock = DockStyle.Fill;
            button29.Enabled = false;
            button29.Location = new Point(3, 327);
            button29.Name = "button29";
            button29.Size = new Size(152, 75);
            button29.TabIndex = 4;
            button29.TabStop = false;
            button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            button30.Dock = DockStyle.Fill;
            button30.Enabled = false;
            button30.Location = new Point(3, 408);
            button30.Name = "button30";
            button30.Size = new Size(152, 76);
            button30.TabIndex = 5;
            button30.TabStop = false;
            button30.UseVisualStyleBackColor = true;
            // 
            // tblRow6
            // 
            tblRow6.ColumnCount = 1;
            tblRow6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow6.Controls.Add(button31, 0, 0);
            tblRow6.Controls.Add(button32, 0, 1);
            tblRow6.Controls.Add(button33, 0, 2);
            tblRow6.Controls.Add(button34, 0, 3);
            tblRow6.Controls.Add(button35, 0, 4);
            tblRow6.Controls.Add(button36, 0, 5);
            tblRow6.Dock = DockStyle.Fill;
            tblRow6.Location = new Point(823, 3);
            tblRow6.Name = "tblRow6";
            tblRow6.RowCount = 6;
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.Size = new Size(158, 487);
            tblRow6.TabIndex = 5;
            // 
            // button31
            // 
            button31.Dock = DockStyle.Fill;
            button31.Enabled = false;
            button31.Location = new Point(3, 3);
            button31.Name = "button31";
            button31.Size = new Size(152, 75);
            button31.TabIndex = 0;
            button31.TabStop = false;
            button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            button32.Dock = DockStyle.Fill;
            button32.Enabled = false;
            button32.Location = new Point(3, 84);
            button32.Name = "button32";
            button32.Size = new Size(152, 75);
            button32.TabIndex = 1;
            button32.TabStop = false;
            button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            button33.Dock = DockStyle.Fill;
            button33.Enabled = false;
            button33.Location = new Point(3, 165);
            button33.Name = "button33";
            button33.Size = new Size(152, 75);
            button33.TabIndex = 2;
            button33.TabStop = false;
            button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            button34.Dock = DockStyle.Fill;
            button34.Enabled = false;
            button34.Location = new Point(3, 246);
            button34.Name = "button34";
            button34.Size = new Size(152, 75);
            button34.TabIndex = 3;
            button34.TabStop = false;
            button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            button35.Dock = DockStyle.Fill;
            button35.Enabled = false;
            button35.Location = new Point(3, 327);
            button35.Name = "button35";
            button35.Size = new Size(152, 75);
            button35.TabIndex = 4;
            button35.TabStop = false;
            button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            button36.Dock = DockStyle.Fill;
            button36.Enabled = false;
            button36.Location = new Point(3, 408);
            button36.Name = "button36";
            button36.Size = new Size(152, 76);
            button36.TabIndex = 5;
            button36.TabStop = false;
            button36.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button37, 0, 0);
            tableLayoutPanel1.Controls.Add(button38, 0, 1);
            tableLayoutPanel1.Controls.Add(button39, 0, 2);
            tableLayoutPanel1.Controls.Add(button40, 0, 3);
            tableLayoutPanel1.Controls.Add(button41, 0, 4);
            tableLayoutPanel1.Controls.Add(button42, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(987, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(159, 487);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // button37
            // 
            button37.Dock = DockStyle.Fill;
            button37.Location = new Point(3, 3);
            button37.Name = "button37";
            button37.Size = new Size(153, 75);
            button37.TabIndex = 0;
            button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            button38.Dock = DockStyle.Fill;
            button38.Location = new Point(3, 84);
            button38.Name = "button38";
            button38.Size = new Size(153, 75);
            button38.TabIndex = 1;
            button38.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            button39.Dock = DockStyle.Fill;
            button39.Location = new Point(3, 165);
            button39.Name = "button39";
            button39.Size = new Size(153, 75);
            button39.TabIndex = 2;
            button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            button40.Dock = DockStyle.Fill;
            button40.Location = new Point(3, 246);
            button40.Name = "button40";
            button40.Size = new Size(153, 75);
            button40.TabIndex = 3;
            button40.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            button41.Dock = DockStyle.Fill;
            button41.Location = new Point(3, 327);
            button41.Name = "button41";
            button41.Size = new Size(153, 75);
            button41.TabIndex = 4;
            button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            button42.Dock = DockStyle.Fill;
            button42.Location = new Point(3, 408);
            button42.Name = "button42";
            button42.Size = new Size(153, 76);
            button42.TabIndex = 5;
            button42.UseVisualStyleBackColor = true;
            // 
            // frmConnectFour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 664);
            Controls.Add(tblMain);
            Name = "frmConnectFour";
            Text = "Connect Four";
            tblMain.ResumeLayout(false);
            tblControls.ResumeLayout(false);
            tblControls.PerformLayout();
            flwPlayerOptions.ResumeLayout(false);
            flwPlayerOptions.PerformLayout();
            tblSlots.ResumeLayout(false);
            tblRow1.ResumeLayout(false);
            tblRow2.ResumeLayout(false);
            tblRow3.ResumeLayout(false);
            tblRow4.ResumeLayout(false);
            tblRow5.ResumeLayout(false);
            tblRow6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblControls;
        private Button btnStart;
        private FlowLayoutPanel flwPlayerOptions;
        private RadioButton optPlayAgainstComp;
        private RadioButton opt2Player;
        private TableLayoutPanel tblSlots;
        private TableLayoutPanel tblRow1;
        private TableLayoutPanel tblRow2;
        private TableLayoutPanel tblRow3;
        private TableLayoutPanel tblRow4;
        private TableLayoutPanel tblRow5;
        private TableLayoutPanel tblRow6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private Button button42;
    }
}
