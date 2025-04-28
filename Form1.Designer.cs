namespace yapimt_lab4
{
    partial class Calculator
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            SolveButton = new Button();
            CommaButton = new Button();
            buttonNum0 = new Button();
            PosOrNegButton = new Button();
            LgButton = new Button();
            buttonNum1 = new Button();
            buttonNum2 = new Button();
            buttonNum3 = new Button();
            buttonNum4 = new Button();
            buttonNum5 = new Button();
            buttonNum6 = new Button();
            buttonNum7 = new Button();
            buttonNum8 = new Button();
            buttonNum9 = new Button();
            buttonAdd = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            LnButton = new Button();
            CtgButton = new Button();
            TgButton = new Button();
            buttonDivide = new Button();
            RadicalButton = new Button();
            SquareButton = new Button();
            ReverseButton = new Button();
            SinButton = new Button();
            CosButton = new Button();
            PercentButton = new Button();
            CancelEntryButton = new Button();
            ClearButton = new Button();
            DeleteButton = new Button();
            tabPage2 = new TabPage();
            pictureBox = new PictureBox();
            drawGraph = new Button();
            labelGraph = new Label();
            expGraph = new TextBox();
            CurrentNumberLabel = new TextBox();
            CurrentExpressionLabel = new TextBox();
            VariableButton = new Button();
            HistoryButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 208);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(529, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(521, 542);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Gainsboro;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(SolveButton, 4, 5);
            tableLayoutPanel1.Controls.Add(CommaButton, 3, 5);
            tableLayoutPanel1.Controls.Add(buttonNum0, 2, 5);
            tableLayoutPanel1.Controls.Add(PosOrNegButton, 1, 5);
            tableLayoutPanel1.Controls.Add(LgButton, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonNum1, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonNum2, 2, 4);
            tableLayoutPanel1.Controls.Add(buttonNum3, 3, 4);
            tableLayoutPanel1.Controls.Add(buttonNum4, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonNum5, 2, 3);
            tableLayoutPanel1.Controls.Add(buttonNum6, 3, 3);
            tableLayoutPanel1.Controls.Add(buttonNum7, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonNum8, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonNum9, 3, 2);
            tableLayoutPanel1.Controls.Add(buttonAdd, 4, 4);
            tableLayoutPanel1.Controls.Add(buttonMinus, 4, 3);
            tableLayoutPanel1.Controls.Add(buttonMultiply, 4, 2);
            tableLayoutPanel1.Controls.Add(LnButton, 0, 4);
            tableLayoutPanel1.Controls.Add(CtgButton, 0, 3);
            tableLayoutPanel1.Controls.Add(TgButton, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonDivide, 4, 1);
            tableLayoutPanel1.Controls.Add(RadicalButton, 3, 1);
            tableLayoutPanel1.Controls.Add(SquareButton, 2, 1);
            tableLayoutPanel1.Controls.Add(ReverseButton, 1, 1);
            tableLayoutPanel1.Controls.Add(SinButton, 0, 1);
            tableLayoutPanel1.Controls.Add(CosButton, 0, 0);
            tableLayoutPanel1.Controls.Add(PercentButton, 1, 0);
            tableLayoutPanel1.Controls.Add(CancelEntryButton, 2, 0);
            tableLayoutPanel1.Controls.Add(ClearButton, 3, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(515, 536);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // SolveButton
            // 
            SolveButton.BackColor = Color.Violet;
            SolveButton.Dock = DockStyle.Fill;
            SolveButton.FlatStyle = FlatStyle.Flat;
            SolveButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SolveButton.Location = new Point(415, 448);
            SolveButton.Name = "SolveButton";
            SolveButton.Size = new Size(97, 85);
            SolveButton.TabIndex = 0;
            SolveButton.Text = "=";
            SolveButton.UseVisualStyleBackColor = false;
            SolveButton.Click += SolveClicked;
            // 
            // CommaButton
            // 
            CommaButton.Dock = DockStyle.Fill;
            CommaButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CommaButton.Location = new Point(312, 448);
            CommaButton.Name = "CommaButton";
            CommaButton.Size = new Size(97, 85);
            CommaButton.TabIndex = 1;
            CommaButton.Text = ",";
            CommaButton.UseVisualStyleBackColor = true;
            CommaButton.Click += EditingButtonClicked;
            // 
            // buttonNum0
            // 
            buttonNum0.Dock = DockStyle.Fill;
            buttonNum0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum0.Location = new Point(209, 448);
            buttonNum0.Name = "buttonNum0";
            buttonNum0.Size = new Size(97, 85);
            buttonNum0.TabIndex = 2;
            buttonNum0.Text = "0";
            buttonNum0.UseVisualStyleBackColor = true;
            buttonNum0.Click += IntKeyClicked;
            // 
            // PosOrNegButton
            // 
            PosOrNegButton.Dock = DockStyle.Fill;
            PosOrNegButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            PosOrNegButton.Location = new Point(106, 448);
            PosOrNegButton.Name = "PosOrNegButton";
            PosOrNegButton.Size = new Size(97, 85);
            PosOrNegButton.TabIndex = 3;
            PosOrNegButton.Text = "+/-";
            PosOrNegButton.UseVisualStyleBackColor = true;
            PosOrNegButton.Click += EditingButtonClicked;
            // 
            // LgButton
            // 
            LgButton.Dock = DockStyle.Fill;
            LgButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LgButton.Location = new Point(3, 448);
            LgButton.Name = "LgButton";
            LgButton.Size = new Size(97, 85);
            LgButton.TabIndex = 4;
            LgButton.Text = "lg";
            LgButton.UseVisualStyleBackColor = true;
            LgButton.Click += SingleOperatorClicked;
            // 
            // buttonNum1
            // 
            buttonNum1.Dock = DockStyle.Fill;
            buttonNum1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum1.Location = new Point(106, 359);
            buttonNum1.Name = "buttonNum1";
            buttonNum1.Size = new Size(97, 83);
            buttonNum1.TabIndex = 5;
            buttonNum1.Text = "1";
            buttonNum1.UseVisualStyleBackColor = true;
            buttonNum1.Click += IntKeyClicked;
            // 
            // buttonNum2
            // 
            buttonNum2.Dock = DockStyle.Fill;
            buttonNum2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum2.Location = new Point(209, 359);
            buttonNum2.Name = "buttonNum2";
            buttonNum2.Size = new Size(97, 83);
            buttonNum2.TabIndex = 6;
            buttonNum2.Text = "2";
            buttonNum2.UseVisualStyleBackColor = true;
            buttonNum2.Click += IntKeyClicked;
            // 
            // buttonNum3
            // 
            buttonNum3.Dock = DockStyle.Fill;
            buttonNum3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum3.Location = new Point(312, 359);
            buttonNum3.Name = "buttonNum3";
            buttonNum3.Size = new Size(97, 83);
            buttonNum3.TabIndex = 7;
            buttonNum3.Text = "3";
            buttonNum3.UseVisualStyleBackColor = true;
            buttonNum3.Click += IntKeyClicked;
            // 
            // buttonNum4
            // 
            buttonNum4.Dock = DockStyle.Fill;
            buttonNum4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum4.Location = new Point(106, 270);
            buttonNum4.Name = "buttonNum4";
            buttonNum4.Size = new Size(97, 83);
            buttonNum4.TabIndex = 8;
            buttonNum4.Text = "4";
            buttonNum4.UseVisualStyleBackColor = true;
            buttonNum4.Click += IntKeyClicked;
            // 
            // buttonNum5
            // 
            buttonNum5.Dock = DockStyle.Fill;
            buttonNum5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum5.Location = new Point(209, 270);
            buttonNum5.Name = "buttonNum5";
            buttonNum5.Size = new Size(97, 83);
            buttonNum5.TabIndex = 9;
            buttonNum5.Text = "5";
            buttonNum5.UseVisualStyleBackColor = true;
            buttonNum5.Click += IntKeyClicked;
            // 
            // buttonNum6
            // 
            buttonNum6.Dock = DockStyle.Fill;
            buttonNum6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum6.Location = new Point(312, 270);
            buttonNum6.Name = "buttonNum6";
            buttonNum6.Size = new Size(97, 83);
            buttonNum6.TabIndex = 10;
            buttonNum6.Text = "6";
            buttonNum6.UseVisualStyleBackColor = true;
            buttonNum6.Click += IntKeyClicked;
            // 
            // buttonNum7
            // 
            buttonNum7.Dock = DockStyle.Fill;
            buttonNum7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum7.Location = new Point(106, 181);
            buttonNum7.Name = "buttonNum7";
            buttonNum7.Size = new Size(97, 83);
            buttonNum7.TabIndex = 11;
            buttonNum7.Text = "7";
            buttonNum7.UseVisualStyleBackColor = true;
            buttonNum7.Click += IntKeyClicked;
            // 
            // buttonNum8
            // 
            buttonNum8.Dock = DockStyle.Fill;
            buttonNum8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum8.Location = new Point(209, 181);
            buttonNum8.Name = "buttonNum8";
            buttonNum8.Size = new Size(97, 83);
            buttonNum8.TabIndex = 12;
            buttonNum8.Text = "8";
            buttonNum8.UseVisualStyleBackColor = true;
            buttonNum8.Click += IntKeyClicked;
            // 
            // buttonNum9
            // 
            buttonNum9.Dock = DockStyle.Fill;
            buttonNum9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonNum9.Location = new Point(312, 181);
            buttonNum9.Name = "buttonNum9";
            buttonNum9.Size = new Size(97, 83);
            buttonNum9.TabIndex = 13;
            buttonNum9.Text = "9";
            buttonNum9.UseVisualStyleBackColor = true;
            buttonNum9.Click += IntKeyClicked;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonAdd.Location = new Point(415, 359);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 83);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += DoubleOperatorClicked;
            // 
            // buttonMinus
            // 
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonMinus.Location = new Point(415, 270);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(97, 83);
            buttonMinus.TabIndex = 15;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += DoubleOperatorClicked;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonMultiply.Location = new Point(415, 181);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(97, 83);
            buttonMultiply.TabIndex = 16;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += DoubleOperatorClicked;
            // 
            // LnButton
            // 
            LnButton.Dock = DockStyle.Fill;
            LnButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LnButton.Location = new Point(3, 359);
            LnButton.Name = "LnButton";
            LnButton.Size = new Size(97, 83);
            LnButton.TabIndex = 17;
            LnButton.Text = "ln";
            LnButton.UseVisualStyleBackColor = true;
            LnButton.Click += SingleOperatorClicked;
            // 
            // CtgButton
            // 
            CtgButton.Dock = DockStyle.Fill;
            CtgButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CtgButton.Location = new Point(3, 270);
            CtgButton.Name = "CtgButton";
            CtgButton.Size = new Size(97, 83);
            CtgButton.TabIndex = 18;
            CtgButton.Text = "ctg";
            CtgButton.UseVisualStyleBackColor = true;
            CtgButton.Click += SingleOperatorClicked;
            // 
            // TgButton
            // 
            TgButton.Dock = DockStyle.Fill;
            TgButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TgButton.Location = new Point(3, 181);
            TgButton.Name = "TgButton";
            TgButton.Size = new Size(97, 83);
            TgButton.TabIndex = 19;
            TgButton.Text = "tg";
            TgButton.UseVisualStyleBackColor = true;
            TgButton.Click += SingleOperatorClicked;
            // 
            // buttonDivide
            // 
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonDivide.Location = new Point(415, 92);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(97, 83);
            buttonDivide.TabIndex = 20;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += DoubleOperatorClicked;
            // 
            // RadicalButton
            // 
            RadicalButton.Dock = DockStyle.Fill;
            RadicalButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            RadicalButton.Location = new Point(312, 92);
            RadicalButton.Name = "RadicalButton";
            RadicalButton.Size = new Size(97, 83);
            RadicalButton.TabIndex = 21;
            RadicalButton.Text = "√x";
            RadicalButton.UseVisualStyleBackColor = true;
            RadicalButton.Click += SingleOperatorClicked;
            // 
            // SquareButton
            // 
            SquareButton.Dock = DockStyle.Fill;
            SquareButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SquareButton.Location = new Point(209, 92);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(97, 83);
            SquareButton.TabIndex = 22;
            SquareButton.Text = "x²";
            SquareButton.UseVisualStyleBackColor = true;
            SquareButton.Click += SingleOperatorClicked;
            // 
            // ReverseButton
            // 
            ReverseButton.Dock = DockStyle.Fill;
            ReverseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ReverseButton.Location = new Point(106, 92);
            ReverseButton.Name = "ReverseButton";
            ReverseButton.Size = new Size(97, 83);
            ReverseButton.TabIndex = 23;
            ReverseButton.Text = "¹∕ₓ";
            ReverseButton.UseVisualStyleBackColor = true;
            ReverseButton.Click += SingleOperatorClicked;
            // 
            // SinButton
            // 
            SinButton.Dock = DockStyle.Fill;
            SinButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SinButton.Location = new Point(3, 92);
            SinButton.Name = "SinButton";
            SinButton.Size = new Size(97, 83);
            SinButton.TabIndex = 24;
            SinButton.Text = "sin";
            SinButton.UseVisualStyleBackColor = true;
            SinButton.Click += SingleOperatorClicked;
            // 
            // CosButton
            // 
            CosButton.Dock = DockStyle.Fill;
            CosButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CosButton.Location = new Point(3, 3);
            CosButton.Name = "CosButton";
            CosButton.Size = new Size(97, 83);
            CosButton.TabIndex = 25;
            CosButton.Text = "cos";
            CosButton.UseVisualStyleBackColor = true;
            CosButton.Click += SingleOperatorClicked;
            // 
            // PercentButton
            // 
            PercentButton.Dock = DockStyle.Fill;
            PercentButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            PercentButton.Location = new Point(106, 3);
            PercentButton.Name = "PercentButton";
            PercentButton.Size = new Size(97, 83);
            PercentButton.TabIndex = 26;
            PercentButton.Text = "%";
            PercentButton.UseVisualStyleBackColor = true;
            PercentButton.Click += DoubleOperatorClicked;
            // 
            // CancelEntryButton
            // 
            CancelEntryButton.Dock = DockStyle.Fill;
            CancelEntryButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            CancelEntryButton.Location = new Point(209, 3);
            CancelEntryButton.Name = "CancelEntryButton";
            CancelEntryButton.Size = new Size(97, 83);
            CancelEntryButton.TabIndex = 27;
            CancelEntryButton.Text = "CE";
            CancelEntryButton.UseVisualStyleBackColor = true;
            CancelEntryButton.Click += EditingButtonClicked;
            // 
            // ClearButton
            // 
            ClearButton.Dock = DockStyle.Fill;
            ClearButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ClearButton.Location = new Point(312, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(97, 83);
            ClearButton.TabIndex = 28;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += EditingButtonClicked;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            DeleteButton.Location = new Point(415, 3);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(97, 83);
            DeleteButton.TabIndex = 29;
            DeleteButton.Text = "←";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += EditingButtonClicked;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox);
            tabPage2.Controls.Add(drawGraph);
            tabPage2.Controls.Add(labelGraph);
            tabPage2.Controls.Add(expGraph);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(521, 542);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(8, 61);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(505, 473);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // drawGraph
            // 
            drawGraph.Location = new Point(371, 17);
            drawGraph.Name = "drawGraph";
            drawGraph.Size = new Size(142, 23);
            drawGraph.TabIndex = 2;
            drawGraph.Text = "Построить график";
            drawGraph.UseVisualStyleBackColor = true;
            drawGraph.Click += drawGraph_Click;
            // 
            // labelGraph
            // 
            labelGraph.AutoSize = true;
            labelGraph.Location = new Point(8, 21);
            labelGraph.Name = "labelGraph";
            labelGraph.Size = new Size(24, 15);
            labelGraph.TabIndex = 1;
            labelGraph.Text = "y =";
            // 
            // expGraph
            // 
            expGraph.Location = new Point(38, 18);
            expGraph.Name = "expGraph";
            expGraph.Size = new Size(310, 23);
            expGraph.TabIndex = 0;
            // 
            // CurrentNumberLabel
            // 
            CurrentNumberLabel.Dock = DockStyle.Bottom;
            CurrentNumberLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            CurrentNumberLabel.Location = new Point(0, 137);
            CurrentNumberLabel.Name = "CurrentNumberLabel";
            CurrentNumberLabel.Size = new Size(529, 71);
            CurrentNumberLabel.TabIndex = 1;
            CurrentNumberLabel.Text = "0";
            CurrentNumberLabel.TextAlign = HorizontalAlignment.Right;
            // 
            // CurrentExpressionLabel
            // 
            CurrentExpressionLabel.Dock = DockStyle.Bottom;
            CurrentExpressionLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            CurrentExpressionLabel.Location = new Point(0, 87);
            CurrentExpressionLabel.Name = "CurrentExpressionLabel";
            CurrentExpressionLabel.Size = new Size(529, 50);
            CurrentExpressionLabel.TabIndex = 2;
            // 
            // VariableButton
            // 
            VariableButton.Location = new Point(12, 12);
            VariableButton.Name = "VariableButton";
            VariableButton.Size = new Size(75, 23);
            VariableButton.TabIndex = 3;
            VariableButton.Text = "var";
            VariableButton.UseVisualStyleBackColor = true;
            VariableButton.Click += VariableButton_Click;
            // 
            // HistoryButton
            // 
            HistoryButton.Location = new Point(442, 12);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Size = new Size(75, 23);
            HistoryButton.TabIndex = 4;
            HistoryButton.Text = "history";
            HistoryButton.UseVisualStyleBackColor = true;
            HistoryButton.Click += HistoryButtonClicked;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 778);
            Controls.Add(HistoryButton);
            Controls.Add(VariableButton);
            Controls.Add(CurrentExpressionLabel);
            Controls.Add(CurrentNumberLabel);
            Controls.Add(tabControl1);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            KeyPress += Calculator_KeyPress;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SolveButton;
        private Button CommaButton;
        private Button buttonNum0;
        private Button PosOrNegButton;
        private Button LgButton;
        private Button buttonNum1;
        private Button buttonNum2;
        private Button buttonNum3;
        private Button buttonNum4;
        private Button buttonNum5;
        private Button buttonNum6;
        private Button buttonNum7;
        private Button buttonNum8;
        private Button buttonNum9;
        private Button buttonAdd;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button LnButton;
        private Button CtgButton;
        private Button TgButton;
        private Button buttonDivide;
        private Button RadicalButton;
        private Button SquareButton;
        private Button ReverseButton;
        private Button SinButton;
        private Button CosButton;
        private Button PercentButton;
        private Button CancelEntryButton;
        private Button ClearButton;
        private Button DeleteButton;
        private TextBox CurrentNumberLabel;
        private TextBox CurrentExpressionLabel;
        private Button VariableButton;
        private Button HistoryButton;
        private Button drawGraph;
        private Label labelGraph;
        private TextBox expGraph;
        private PictureBox pictureBox;
    }
}
