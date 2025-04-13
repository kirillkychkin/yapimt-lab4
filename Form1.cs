using System.Windows.Forms;

namespace yapimt_lab4
{
    public partial class Calculator : Form
    {

        private const SByte DefaultInputLength = 16;
        private SByte MaxInputLength;

        private ExpressionHandler resolver;

        private Font defaultFont = new("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        private Font middleFont = new("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        private Font smallFont = new("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

        private HistoryWindow historyWindow;
        private VariableWindow variableWindow;

        public Calculator()
        {
            InitializeComponent();
            KeyPreview = true;
            AdditionalDisplay(true);
            resolver = new ExpressionHandler();
            MaxInputLength = DefaultInputLength;
            SetExpression(resolver.GetExpression());
        }

        public void SetExpression(string s)
        {
            CurrentExpressionLabel.Text = s;
        }

        public void SetNumber(string s)
        {
            CurrentNumberLabel.Text = s;
        }

        private void DecreaseFontSize()
        {
            // ��������� ������ ������ � ����������� �� ����� ������

            string currentValue = CurrentNumberLabel.Text;

            if (currentValue.Length == 13)
            {
                CurrentNumberLabel.Font = middleFont;
            }
            else if (currentValue.Length == 17)
            {
                CurrentNumberLabel.Font = smallFont;
            }
        }

        private void IncreaseFontSize()
        {
            // ����������� ������ ������ � ����������� �� ����� ������

            string currentValue = CurrentNumberLabel.Text;

            if (currentValue.Length >= 17)
            {
                return;
            }
            else if (currentValue.Length >= 13)
            {
                CurrentNumberLabel.Font = middleFont;
            }
            else
            {
                CurrentNumberLabel.Font = defaultFont;
            }
        }

        private void UpdateInputSettings(SByte AddMaxLen, Action f)
        {
            /*
             * AddMaxLen - ��������� ����� ��������� ��� ��������� MaxInputLength
             * f - �������, ������� ����� ������� � �����. ��������������� DecreaseFontSize ��� IncreaseFontSize
             */

            MaxInputLength += AddMaxLen;
            f();
        }

        private void SetInputSettings(SByte NewMaxLen, Action f)
        {
            /*
             * NewMaxLen - ����� ����� �������� ������ MaxInputLength
             * f - �������, ������� ����� ������� � �����. ��������������� DecreaseFontSize ��� IncreaseFontSize
             */

            MaxInputLength = NewMaxLen;
            f();
        }

        public void Solve()
        {
            /*
             * ������� �� CurrentNumberLabel ��������� ����������
             */

            if (resolver.Solve()) // ���������
            {
                SetNumber(resolver.GetResult().ToString()); // �������
                SetExpression(resolver.GetExpression());
                resolver.LastOperand.SetWaiting(true);
            }
            else
            {
                MessageBox.Show(String.Format("������: {0}", resolver.GetError()), "������", MessageBoxButtons.OK);
            }
        }

        private void SolveClicked(object sender, EventArgs e)
        {
            Solve();
        }

        private void IntKeyClicked(object sender, EventArgs e)
        {
            // ������������ ������� �� ������� � ������

            string number = ((Button)sender).Text;
            Operand activeOperand = resolver.LastOperand;

            if (activeOperand.GetFunction() != null)
            {
                // ���� ������� ������� �������� ��������, �� ��� ����� �����
                // �������� ���� ������� � ���������� �� ��� ����� �������� �����

                resolver.SetOperandToDefault();
                SetExpression(resolver.GetExpression());
            }

            if (activeOperand.WaitForInput() && activeOperand.GetText() != "0")
            {
                // �� ������, ����� � �������� ������ �� ��������� ��������� ����������� ��������
                // ��������, ����� ������ 2+sqrt(1), �� � ���� ��� ����� ��������� ��������� ����������
                // ������� sqrt(1). ����� ���� ����� ����� �� ������ �� �����-���� �����, �� ���� ���������
                // ������ ��������� � ������ ���� �� ������� �������� �����

                resolver.SetOperandToDefault();
                SetNumber(activeOperand.GetText());
            }

            if (CurrentNumberLabel.Text.Length + 1 >= MaxInputLength)
            {
                return;
            }

            resolver.PutNum(number);

            SetNumber(activeOperand.GetValue());
            DecreaseFontSize();
        }

        private void DoubleOperatorClicked(object sender, EventArgs e)
        {
            // ������ ������ +,-,*,/
            Button b = (Button)sender;
            string operation = b.Name;
            Decimal lastValue = resolver.LastOperand.GetNumber();

            switch (operation)
            {
                case "PlusButton":
                    resolver.PutOperator("+");
                    break;
                case "MinusButton":
                    resolver.PutOperator("-");
                    break;
                case "MuliplyButton":
                    resolver.PutOperator("*");
                    break;
                case "DivisionButton":
                    resolver.PutOperator("/");
                    break;
                case "PercentButton":
                    resolver.PutOperator("%");
                    break;
            }

            SetExpression(resolver.GetExpression());
            resolver.LastOperand.SetByNum(lastValue);
            SetNumber(resolver.LastOperand.GetValue());
        }

        private void SingleOperatorClicked(object sender, EventArgs e)
        {
            // ���� ������� ��������, ��� ������� ��������� ���� �������
            // ��������, ���������� � �������, ������ ����������� �����, ���. �������� � ��

            string operation = ((Button)sender).Name;
            string currentStrValue = CurrentNumberLabel.Text;

            switch (operation)
            {
                case "SquareButton": resolver.PutFunction(resolver.FunctionManager.Sqr); break;
                case "RadicalButton": resolver.PutFunction(resolver.FunctionManager.Sqrt); break;
                case "CosButton": resolver.PutFunction(resolver.FunctionManager.Cos); break;
                case "SinButton": resolver.PutFunction(resolver.FunctionManager.Sin); break;
                case "TgButton": resolver.PutFunction(resolver.FunctionManager.Tg); break;
                case "CtgButton": resolver.PutFunction(resolver.FunctionManager.Ctg); break;
                case "LnButton": resolver.PutFunction(resolver.FunctionManager.Ln); break;
                case "LgButton": resolver.PutFunction(resolver.FunctionManager.Lg); break;
                case "ReverseButton": resolver.PutFunction(resolver.FunctionManager.Rev); break;
            }

            SetNumber(resolver.LastOperand.GetValue());
            SetExpression(resolver.GetExpression() + resolver.LastOperand.GetText());
            SetInputSettings(DefaultInputLength, IncreaseFontSize);
        }

        private void EditingButtonClicked(object sender, EventArgs e)
        {
            /*
             * ���� ������ ������� +/- | , | del | CE | C
             */

            string operation = ((Button)sender).Name;
            string currentValue = resolver.LastOperand.GetText();

            switch (operation)
            {
                case "PosOrNegButton":
                    if (resolver.PutNegative())
                        UpdateInputSettings(1, DecreaseFontSize);
                    else
                        UpdateInputSettings(-1, DecreaseFontSize);
                    if (resolver.LastOperand.GetFunction() != null)
                        SetExpression(resolver.GetExpression());
                    break;
                case "CommaButton":
                    resolver.PutComma();
                    UpdateInputSettings(1, DecreaseFontSize);
                    break;
                case "DeleteButton":
                    Operand activeOperand = resolver.LastOperand;

                    if (activeOperand.WaitForInput() || activeOperand.GetText() == "0" || activeOperand.GetFunction() != null)
                        return;

                    if (activeOperand.GetText().Length == 1 ||
                        CurrentNumberLabel.Text.Length == 2 && CurrentNumberLabel.Text.First() == '-')
                    {
                        activeOperand.SetByStr("0");
                        SetNumber(activeOperand.GetValue());

                        if (CurrentNumberLabel.Text.First() == '-')
                            UpdateInputSettings(-1, delegate () { });

                        return;
                    }

                    if (CurrentNumberLabel.Text.Contains(','))
                    {
                        UpdateInputSettings(-1, delegate () { });
                    }

                    activeOperand.SetByStr(CurrentNumberLabel.Text.Remove(CurrentNumberLabel.Text.Length - 1));
                    SetNumber(activeOperand.GetValue());
                    IncreaseFontSize();
                    break;
                case "CancelEntryButton":
                    resolver.LastOperand.SetDefault();
                    SetNumber(resolver.LastOperand.GetValue());
                    SetExpression(resolver.GetExpression());
                    SetInputSettings(DefaultInputLength, IncreaseFontSize);
                    break;
                case "ClearButton":
                    Clear();
                    break;
            }
            SetNumber(resolver.LastOperand.GetText());
        }

        public void Clear()
        {
            resolver.SetToDefault();
            SetNumber(resolver.LastOperand.GetValue());
            SetExpression(resolver.GetExpression());
        }

        private void HistoryButtonClicked(object sender, EventArgs e)
        {
            // ������� ���� � �������� ��������

            if (historyWindow != null && historyWindow.Visible)
                return;

            historyWindow = new HistoryWindow(this, resolver);
            historyWindow.Show();
        }

        private void AdditionalButtonClicked(object sender, EventArgs e)
        {
            AdditionalDisplay(additionalLayout.Visible);
        }

        private void AdditionalDisplay(bool hide)
        {
            int W = additionalLayout.Width;
            //PercentButton.Enabled = hide;

            if (hide)
            {
                VariableButton.Location = new System.Drawing.Point(VariableButton.Location.X - W, 12);
                HistoryButton.Location = new System.Drawing.Point(HistoryButton.Location.X - W, 12);
                mainLayout.Location = new System.Drawing.Point(mainLayout.Location.X - W, 41);
                ClientSize = new System.Drawing.Size(ClientSize.Width - W, 388);
                additionalLayout.Hide();
            }
            else
            {
                VariableButton.Location = new System.Drawing.Point(VariableButton.Location.X + W, 12);
                HistoryButton.Location = new System.Drawing.Point(HistoryButton.Location.X + W, 12);
                mainLayout.Location = new System.Drawing.Point(mainLayout.Location.X + W, 41);
                ClientSize = new System.Drawing.Size(ClientSize.Width + W, 388);
                additionalLayout.Show();
            }
        }

        public void SetVariable(char var)
        {
            // ������������� ������� ��������� � ��� '<���_����������> = '

            resolver.SetVariable(var.ToString());
            SetNumber(resolver.LastOperand.GetValue());
            SetExpression(resolver.GetExpression());
        }

        private void VariableButton_Click(object sender, EventArgs e)
        {
            // �������� ���� ����������

            if (variableWindow != null && variableWindow.Visible)
                return;

            variableWindow = new VariableWindow(this);
            variableWindow.Show();
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ��������� ���������� � ���������

            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                Console.WriteLine("putting variable {0}", e.KeyChar);
                resolver.PutVariable(e.KeyChar.ToString());
                SetNumber(resolver.LastOperand.GetValue());
                SetExpression(resolver.GetExpression());
            }
        }
    }
}
