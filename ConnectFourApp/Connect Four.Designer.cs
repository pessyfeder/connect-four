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
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button7 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            button34 = new Button();
            button35 = new Button();
            button36 = new Button();
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
            tblSlots.BackColor = Color.Transparent;
            tblSlots.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tblSlots.ColumnCount = 7;
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853079F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2853041F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881622F));
            tblSlots.Controls.Add(button8, 1, 1);
            tblSlots.Controls.Add(button1, 0, 0);
            tblSlots.Controls.Add(button2, 0, 1);
            tblSlots.Controls.Add(button3, 0, 2);
            tblSlots.Controls.Add(button4, 0, 3);
            tblSlots.Controls.Add(button5, 0, 4);
            tblSlots.Controls.Add(button6, 0, 5);
            tblSlots.Controls.Add(button9, 1, 2);
            tblSlots.Controls.Add(button10, 1, 3);
            tblSlots.Controls.Add(button11, 1, 4);
            tblSlots.Controls.Add(button12, 1, 5);
            tblSlots.Controls.Add(button7, 1, 0);
            tblSlots.Controls.Add(button13, 2, 0);
            tblSlots.Controls.Add(button14, 2, 1);
            tblSlots.Controls.Add(button15, 2, 2);
            tblSlots.Controls.Add(button16, 2, 3);
            tblSlots.Controls.Add(button17, 2, 4);
            tblSlots.Controls.Add(button18, 2, 5);
            tblSlots.Controls.Add(button19, 3, 0);
            tblSlots.Controls.Add(button20, 3, 1);
            tblSlots.Controls.Add(button21, 3, 2);
            tblSlots.Controls.Add(button22, 3, 3);
            tblSlots.Controls.Add(button23, 3, 4);
            tblSlots.Controls.Add(button24, 3, 5);
            tblSlots.Controls.Add(button25, 4, 0);
            tblSlots.Controls.Add(button26, 4, 1);
            tblSlots.Controls.Add(button27, 4, 2);
            tblSlots.Controls.Add(button28, 4, 3);
            tblSlots.Controls.Add(button29, 4, 4);
            tblSlots.Controls.Add(button30, 4, 5);
            tblSlots.Controls.Add(button31, 5, 0);
            tblSlots.Controls.Add(button32, 5, 1);
            tblSlots.Controls.Add(button33, 5, 2);
            tblSlots.Controls.Add(button34, 5, 3);
            tblSlots.Controls.Add(button35, 5, 4);
            tblSlots.Controls.Add(button36, 5, 5);
            tblSlots.Controls.Add(button37, 6, 0);
            tblSlots.Controls.Add(button38, 6, 1);
            tblSlots.Controls.Add(button39, 6, 2);
            tblSlots.Controls.Add(button40, 6, 3);
            tblSlots.Controls.Add(button41, 6, 4);
            tblSlots.Controls.Add(button42, 6, 5);
            tblSlots.Dock = DockStyle.Fill;
            tblSlots.Location = new Point(3, 168);
            tblSlots.Name = "tblSlots";
            tblSlots.RowCount = 6;
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.Size = new Size(1149, 493);
            tblSlots.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(169, 87);
            button8.Name = "button8";
            button8.Size = new Size(154, 72);
            button8.TabIndex = 13;
            button8.TabStop = false;
            button8.UseVisualStyleBackColor = false;
            button8.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(154, 72);
            button1.TabIndex = 7;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(6, 87);
            button2.Name = "button2";
            button2.Size = new Size(154, 72);
            button2.TabIndex = 8;
            button2.TabStop = false;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(6, 168);
            button3.Name = "button3";
            button3.Size = new Size(154, 72);
            button3.TabIndex = 9;
            button3.TabStop = false;
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(6, 249);
            button4.Name = "button4";
            button4.Size = new Size(154, 72);
            button4.TabIndex = 10;
            button4.TabStop = false;
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(6, 330);
            button5.Name = "button5";
            button5.Size = new Size(154, 72);
            button5.TabIndex = 11;
            button5.TabStop = false;
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(6, 411);
            button6.Name = "button6";
            button6.Size = new Size(154, 76);
            button6.TabIndex = 12;
            button6.TabStop = false;
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(169, 168);
            button9.Name = "button9";
            button9.Size = new Size(154, 72);
            button9.TabIndex = 14;
            button9.TabStop = false;
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(169, 249);
            button10.Name = "button10";
            button10.Size = new Size(154, 72);
            button10.TabIndex = 15;
            button10.TabStop = false;
            button10.UseVisualStyleBackColor = false;
            button10.Visible = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(169, 330);
            button11.Name = "button11";
            button11.Size = new Size(154, 72);
            button11.TabIndex = 16;
            button11.TabStop = false;
            button11.UseVisualStyleBackColor = false;
            button11.Visible = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Transparent;
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(169, 411);
            button12.Name = "button12";
            button12.Size = new Size(154, 76);
            button12.TabIndex = 18;
            button12.TabStop = false;
            button12.UseVisualStyleBackColor = false;
            button12.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(169, 6);
            button7.Name = "button7";
            button7.Size = new Size(154, 72);
            button7.TabIndex = 19;
            button7.TabStop = false;
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Transparent;
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(332, 6);
            button13.Name = "button13";
            button13.Size = new Size(154, 72);
            button13.TabIndex = 0;
            button13.TabStop = false;
            button13.UseVisualStyleBackColor = false;
            button13.Visible = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Transparent;
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(332, 87);
            button14.Name = "button14";
            button14.Size = new Size(154, 72);
            button14.TabIndex = 1;
            button14.TabStop = false;
            button14.UseVisualStyleBackColor = false;
            button14.Visible = false;
            // 
            // button15
            // 
            button15.BackColor = Color.Transparent;
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(332, 168);
            button15.Name = "button15";
            button15.Size = new Size(154, 72);
            button15.TabIndex = 2;
            button15.TabStop = false;
            button15.UseVisualStyleBackColor = false;
            button15.Visible = false;
            // 
            // button16
            // 
            button16.BackColor = Color.Transparent;
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(332, 249);
            button16.Name = "button16";
            button16.Size = new Size(154, 72);
            button16.TabIndex = 3;
            button16.TabStop = false;
            button16.UseVisualStyleBackColor = false;
            button16.Visible = false;
            // 
            // button17
            // 
            button17.BackColor = Color.Transparent;
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(332, 330);
            button17.Name = "button17";
            button17.Size = new Size(154, 72);
            button17.TabIndex = 4;
            button17.TabStop = false;
            button17.UseVisualStyleBackColor = false;
            button17.Visible = false;
            // 
            // button18
            // 
            button18.BackColor = Color.Transparent;
            button18.Dock = DockStyle.Fill;
            button18.Location = new Point(332, 411);
            button18.Name = "button18";
            button18.Size = new Size(154, 76);
            button18.TabIndex = 5;
            button18.TabStop = false;
            button18.UseVisualStyleBackColor = false;
            button18.Visible = false;
            // 
            // button19
            // 
            button19.BackColor = Color.Transparent;
            button19.Dock = DockStyle.Fill;
            button19.Location = new Point(495, 6);
            button19.Name = "button19";
            button19.Size = new Size(154, 72);
            button19.TabIndex = 0;
            button19.TabStop = false;
            button19.UseVisualStyleBackColor = false;
            button19.Visible = false;
            // 
            // button20
            // 
            button20.BackColor = Color.Transparent;
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(495, 87);
            button20.Name = "button20";
            button20.Size = new Size(154, 72);
            button20.TabIndex = 1;
            button20.TabStop = false;
            button20.UseVisualStyleBackColor = false;
            button20.Visible = false;
            // 
            // button21
            // 
            button21.BackColor = Color.Transparent;
            button21.Dock = DockStyle.Fill;
            button21.Location = new Point(495, 168);
            button21.Name = "button21";
            button21.Size = new Size(154, 72);
            button21.TabIndex = 2;
            button21.TabStop = false;
            button21.UseVisualStyleBackColor = false;
            button21.Visible = false;
            // 
            // button22
            // 
            button22.BackColor = Color.Transparent;
            button22.Dock = DockStyle.Fill;
            button22.Location = new Point(495, 249);
            button22.Name = "button22";
            button22.Size = new Size(154, 72);
            button22.TabIndex = 3;
            button22.TabStop = false;
            button22.UseVisualStyleBackColor = false;
            button22.Visible = false;
            // 
            // button23
            // 
            button23.BackColor = Color.Transparent;
            button23.Dock = DockStyle.Fill;
            button23.Location = new Point(495, 330);
            button23.Name = "button23";
            button23.Size = new Size(154, 72);
            button23.TabIndex = 4;
            button23.TabStop = false;
            button23.UseVisualStyleBackColor = false;
            button23.Visible = false;
            // 
            // button24
            // 
            button24.BackColor = Color.Transparent;
            button24.Dock = DockStyle.Fill;
            button24.Location = new Point(495, 411);
            button24.Name = "button24";
            button24.Size = new Size(154, 76);
            button24.TabIndex = 5;
            button24.TabStop = false;
            button24.UseVisualStyleBackColor = false;
            button24.Visible = false;
            // 
            // button25
            // 
            button25.BackColor = Color.Transparent;
            button25.Dock = DockStyle.Fill;
            button25.Location = new Point(658, 6);
            button25.Name = "button25";
            button25.Size = new Size(154, 72);
            button25.TabIndex = 0;
            button25.TabStop = false;
            button25.UseVisualStyleBackColor = false;
            button25.Visible = false;
            // 
            // button26
            // 
            button26.BackColor = Color.Transparent;
            button26.Dock = DockStyle.Fill;
            button26.Location = new Point(658, 87);
            button26.Name = "button26";
            button26.Size = new Size(154, 72);
            button26.TabIndex = 1;
            button26.TabStop = false;
            button26.UseVisualStyleBackColor = false;
            button26.Visible = false;
            // 
            // button27
            // 
            button27.BackColor = Color.Transparent;
            button27.Dock = DockStyle.Fill;
            button27.Location = new Point(658, 168);
            button27.Name = "button27";
            button27.Size = new Size(154, 72);
            button27.TabIndex = 2;
            button27.TabStop = false;
            button27.UseVisualStyleBackColor = false;
            button27.Visible = false;
            // 
            // button28
            // 
            button28.BackColor = Color.Transparent;
            button28.Dock = DockStyle.Fill;
            button28.Location = new Point(658, 249);
            button28.Name = "button28";
            button28.Size = new Size(154, 72);
            button28.TabIndex = 3;
            button28.TabStop = false;
            button28.UseVisualStyleBackColor = false;
            button28.Visible = false;
            // 
            // button29
            // 
            button29.BackColor = Color.Transparent;
            button29.Dock = DockStyle.Fill;
            button29.Location = new Point(658, 330);
            button29.Name = "button29";
            button29.Size = new Size(154, 72);
            button29.TabIndex = 4;
            button29.TabStop = false;
            button29.UseVisualStyleBackColor = false;
            button29.Visible = false;
            // 
            // button30
            // 
            button30.BackColor = Color.Transparent;
            button30.Dock = DockStyle.Fill;
            button30.Location = new Point(658, 411);
            button30.Name = "button30";
            button30.Size = new Size(154, 76);
            button30.TabIndex = 5;
            button30.TabStop = false;
            button30.UseVisualStyleBackColor = false;
            button30.Visible = false;
            // 
            // button31
            // 
            button31.BackColor = Color.Transparent;
            button31.Dock = DockStyle.Fill;
            button31.Location = new Point(821, 6);
            button31.Name = "button31";
            button31.Size = new Size(154, 72);
            button31.TabIndex = 0;
            button31.TabStop = false;
            button31.UseVisualStyleBackColor = false;
            button31.Visible = false;
            // 
            // button32
            // 
            button32.BackColor = Color.Transparent;
            button32.Dock = DockStyle.Fill;
            button32.Location = new Point(821, 87);
            button32.Name = "button32";
            button32.Size = new Size(154, 72);
            button32.TabIndex = 1;
            button32.TabStop = false;
            button32.UseVisualStyleBackColor = false;
            button32.Visible = false;
            // 
            // button33
            // 
            button33.BackColor = Color.Transparent;
            button33.Dock = DockStyle.Fill;
            button33.Location = new Point(821, 168);
            button33.Name = "button33";
            button33.Size = new Size(154, 72);
            button33.TabIndex = 2;
            button33.TabStop = false;
            button33.UseVisualStyleBackColor = false;
            button33.Visible = false;
            // 
            // button34
            // 
            button34.BackColor = Color.Transparent;
            button34.Dock = DockStyle.Fill;
            button34.Location = new Point(821, 249);
            button34.Name = "button34";
            button34.Size = new Size(154, 72);
            button34.TabIndex = 3;
            button34.TabStop = false;
            button34.UseVisualStyleBackColor = false;
            button34.Visible = false;
            // 
            // button35
            // 
            button35.BackColor = Color.Transparent;
            button35.Dock = DockStyle.Fill;
            button35.Location = new Point(821, 330);
            button35.Name = "button35";
            button35.Size = new Size(154, 72);
            button35.TabIndex = 4;
            button35.TabStop = false;
            button35.UseVisualStyleBackColor = false;
            button35.Visible = false;
            // 
            // button36
            // 
            button36.BackColor = Color.Transparent;
            button36.Dock = DockStyle.Fill;
            button36.Location = new Point(821, 411);
            button36.Name = "button36";
            button36.Size = new Size(154, 76);
            button36.TabIndex = 5;
            button36.TabStop = false;
            button36.UseVisualStyleBackColor = false;
            button36.Visible = false;
            // 
            // button37
            // 
            button37.BackColor = Color.Transparent;
            button37.Dock = DockStyle.Fill;
            button37.Location = new Point(984, 6);
            button37.Name = "button37";
            button37.Size = new Size(159, 72);
            button37.TabIndex = 20;
            button37.TabStop = false;
            button37.UseVisualStyleBackColor = false;
            button37.Visible = false;
            // 
            // button38
            // 
            button38.BackColor = Color.Transparent;
            button38.Dock = DockStyle.Fill;
            button38.ForeColor = SystemColors.ControlDarkDark;
            button38.Location = new Point(984, 87);
            button38.Name = "button38";
            button38.Size = new Size(159, 72);
            button38.TabIndex = 21;
            button38.TabStop = false;
            button38.UseVisualStyleBackColor = false;
            button38.Visible = false;
            // 
            // button39
            // 
            button39.BackColor = Color.Transparent;
            button39.Dock = DockStyle.Fill;
            button39.Location = new Point(984, 168);
            button39.Name = "button39";
            button39.Size = new Size(159, 72);
            button39.TabIndex = 22;
            button39.TabStop = false;
            button39.UseVisualStyleBackColor = false;
            button39.Visible = false;
            // 
            // button40
            // 
            button40.BackColor = Color.Transparent;
            button40.Dock = DockStyle.Fill;
            button40.Location = new Point(984, 249);
            button40.Name = "button40";
            button40.Size = new Size(159, 72);
            button40.TabIndex = 23;
            button40.TabStop = false;
            button40.UseVisualStyleBackColor = false;
            button40.Visible = false;
            // 
            // button41
            // 
            button41.BackColor = Color.Transparent;
            button41.Dock = DockStyle.Fill;
            button41.Location = new Point(984, 330);
            button41.Name = "button41";
            button41.Size = new Size(159, 72);
            button41.TabIndex = 24;
            button41.TabStop = false;
            button41.UseVisualStyleBackColor = false;
            button41.Visible = false;
            // 
            // button42
            // 
            button42.BackColor = Color.Transparent;
            button42.Dock = DockStyle.Fill;
            button42.Location = new Point(984, 411);
            button42.Name = "button42";
            button42.Size = new Size(159, 76);
            button42.TabIndex = 25;
            button42.TabStop = false;
            button42.UseVisualStyleBackColor = false;
            button42.Visible = false;
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
        private Button button9;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button11;
        private Button button10;
        private Button button12;
        private Button button7;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
        private Button button41;
        private Button button42;
    }
}
