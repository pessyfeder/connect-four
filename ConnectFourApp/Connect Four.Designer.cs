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
            tblRow2 = new TableLayoutPanel();
            tblRow3 = new TableLayoutPanel();
            tblRow4 = new TableLayoutPanel();
            tblRow5 = new TableLayoutPanel();
            tblRow6 = new TableLayoutPanel();
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
            btnStart.TabIndex = 1;
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
            optPlayAgainstComp.TabIndex = 1;
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
            tblSlots.ColumnCount = 6;
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tblSlots.Controls.Add(tblRow1, 0, 0);
            tblSlots.Controls.Add(tblRow2, 1, 0);
            tblSlots.Controls.Add(tblRow3, 2, 0);
            tblSlots.Controls.Add(tblRow4, 3, 0);
            tblSlots.Controls.Add(tblRow5, 4, 0);
            tblSlots.Controls.Add(tblRow6, 5, 0);
            tblSlots.Dock = DockStyle.Fill;
            tblSlots.Location = new Point(3, 168);
            tblSlots.Name = "tblSlots";
            tblSlots.RowCount = 1;
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblSlots.Size = new Size(1149, 493);
            tblSlots.TabIndex = 1;
            // 
            // tblRow1
            // 
            tblRow1.ColumnCount = 1;
            tblRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            tblRow1.Size = new Size(185, 487);
            tblRow1.TabIndex = 0;
            // 
            // tblRow2
            // 
            tblRow2.ColumnCount = 1;
            tblRow2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow2.Dock = DockStyle.Fill;
            tblRow2.Location = new Point(194, 3);
            tblRow2.Name = "tblRow2";
            tblRow2.RowCount = 6;
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow2.Size = new Size(185, 487);
            tblRow2.TabIndex = 1;
            // 
            // tblRow3
            // 
            tblRow3.ColumnCount = 1;
            tblRow3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow3.Dock = DockStyle.Fill;
            tblRow3.Location = new Point(385, 3);
            tblRow3.Name = "tblRow3";
            tblRow3.RowCount = 6;
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow3.Size = new Size(185, 487);
            tblRow3.TabIndex = 2;
            // 
            // tblRow4
            // 
            tblRow4.ColumnCount = 1;
            tblRow4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow4.Dock = DockStyle.Fill;
            tblRow4.Location = new Point(576, 3);
            tblRow4.Name = "tblRow4";
            tblRow4.RowCount = 6;
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow4.Size = new Size(185, 487);
            tblRow4.TabIndex = 3;
            // 
            // tblRow5
            // 
            tblRow5.ColumnCount = 1;
            tblRow5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow5.Dock = DockStyle.Fill;
            tblRow5.Location = new Point(767, 3);
            tblRow5.Name = "tblRow5";
            tblRow5.RowCount = 6;
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow5.Size = new Size(185, 487);
            tblRow5.TabIndex = 4;
            // 
            // tblRow6
            // 
            tblRow6.ColumnCount = 1;
            tblRow6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRow6.Dock = DockStyle.Fill;
            tblRow6.Location = new Point(958, 3);
            tblRow6.Name = "tblRow6";
            tblRow6.RowCount = 6;
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblRow6.Size = new Size(188, 487);
            tblRow6.TabIndex = 5;
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
        private TableLayoutPanel tblRow1;
        private TableLayoutPanel tblRow2;
        private TableLayoutPanel tblRow3;
        private TableLayoutPanel tblRow4;
        private TableLayoutPanel tblRow5;
        private TableLayoutPanel tblRow6;
    }
}
