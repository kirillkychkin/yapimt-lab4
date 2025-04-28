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
        string expression = "x * x + 2"; // любое алгебраическое выражение
        float scaleX = 20f; // масштаб по X
        float scaleY = 20f; // масштаб по Y

        private HistoryWindow historyWindow;
        private VariableWindow variableWindow;
        private InsertVariableWindow insertVariableWindow;

        public Decimal?[] GetVars()
        {
            return resolver.GetVars();
        }

        public Calculator()
        {
            InitializeComponent();
            KeyPreview = true;
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
            // уменьшаем размер шрифта в зависимости от длины строки

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
            // увеличиваем размер шрифта в зависимости от длины строки

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
             * AddMaxLen - насколько нужно увеличить или уменьшить MaxInputLength
             * f - функция, которая будет вызвана в итоге. Подразумевается DecreaseFontSize или IncreaseFontSize
             */

            MaxInputLength += AddMaxLen;
            f();
        }

        private void SetInputSettings(SByte NewMaxLen, Action f)
        {
            /*
             * NewMaxLen - какое новое значение примет MaxInputLength
             * f - функция, которая будет вызвана в итоге. Подразумевается DecreaseFontSize или IncreaseFontSize
             */

            MaxInputLength = NewMaxLen;
            f();
        }

        public void Solve()
        {
            /*
             * Выводит на CurrentNumberLabel результат вычисления
             */

            if (resolver.Solve()) // вычисляем
            {
                SetNumber(resolver.GetResult().ToString()); // выводим
                SetExpression(resolver.GetExpression());
                resolver.LastOperand.SetWaiting(true);
            }
            else
            {
                MessageBox.Show(String.Format("Ошибка: {0}", resolver.GetError()), "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void SolveClicked(object sender, EventArgs e)
        {
            Solve();
        }

        private void IntKeyClicked(object sender, EventArgs e)
        {
            // обрабатываем нажатие на клавишу с цифрой

            string number = ((Button)sender).Text;
            Operand activeOperand = resolver.LastOperand;

            if (activeOperand.GetFunction() != null)
            {
                // если текущий операнд является функцией, то при вводе числа
                // зануляем этот операнд и записываем на его место вводимое число

                resolver.SetOperandToDefault();
                SetExpression(resolver.GetExpression());
            }

            if (activeOperand.WaitForInput() && activeOperand.GetText() != "0")
            {
                // на случай, когда в качестве одного из операндов выступает вычисленное значение
                // например, когда введем 2+sqrt(1), то в поле для ввода вставится результат вычисление
                // функции sqrt(1). Тогда если после этого мы нажмем на какую-либо цифру, то этот результат
                // должен стереться и вместо него мы вставим вводимое число

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
            // нажата кнопка +,-,*,/
            Button b = (Button)sender;
            string operation = b.Name;
            Decimal lastValue = resolver.LastOperand.GetNumber();

            switch (operation)
            {
                case "buttonAdd":
                    resolver.PutOperator("+");
                    break;
                case "buttonMinus":
                    resolver.PutOperator("-");
                    break;
                case "buttonMultiply":
                    resolver.PutOperator("*");
                    break;
                case "buttonDivide":
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
            // была выбрана операция, для которой требуется один операнд
            // например, возведение в квадрат, взятие квадратного корня, нат. логарифм и тд

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
             * была нажата клавиша +/- | , | del | CE | C
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
            // создает окно с историей операций

            if (historyWindow != null && historyWindow.Visible)
                return;

            historyWindow = new HistoryWindow(this, resolver);
            historyWindow.Show();
        }

        public void SetVariable(char var)
        {
            // устанавливает текущее выражение в вид '<имя_переменной> = '

            resolver.SetVariable(var.ToString());
            SetNumber(resolver.LastOperand.GetValue());
            SetExpression(resolver.GetExpression());
        }

        private void VariableButton_Click(object sender, EventArgs e)
        {
            // вызывает окно переменных

            if (variableWindow != null && variableWindow.Visible)
                return;

            variableWindow = new VariableWindow(this);
            variableWindow.Show();
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // вставляем переменную в выражение

            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                Console.WriteLine("putting variable {0}", e.KeyChar);
                resolver.PutVariable(e.KeyChar.ToString());
                SetNumber(resolver.LastOperand.GetValue());
                SetExpression(resolver.GetExpression());
            }
        }

        private void insertVarBtn_Click(object sender, EventArgs e)
        {
            // вызывает окно переменных

            if (insertVariableWindow != null && insertVariableWindow.Visible)
                return;

            insertVariableWindow = new InsertVariableWindow(this);
            insertVariableWindow.Show();
        }
        private float EvaluateExpression(float x)
        {
            resolver.SetXVar(x);
            var result = resolver.SolveForGraph(expression);
            return Convert.ToSingle(result);
        }

        private void drawGraph_Click(object sender, EventArgs e)
        {
            this.expression = expGraph.Text;

            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);

            // Рисуем оси
            Pen axisPen = new Pen(Color.Black, 1);
            g.DrawLine(axisPen, 0, this.Height / 2, this.Width, this.Height / 2); // ось X
            g.DrawLine(axisPen, this.Width / 2, 0, this.Width / 2, this.Height);  // ось Y

            // Рисуем график
            Pen graphPen = new Pen(Color.Blue, 2);
            float prevX = -this.Width / 2 / scaleX;
            float prevY = EvaluateExpression(prevX);

            for (int pixelX = 0; pixelX < this.Width; pixelX++)
            {
                float x = (pixelX - this.Width / 2) / scaleX;
                float y = EvaluateExpression(x);

                float screenX1 = this.Width / 2 + prevX * scaleX;
                float screenY1 = this.Height / 2 - prevY * scaleY;
                float screenX2 = this.Width / 2 + x * scaleX;
                float screenY2 = this.Height / 2 - y * scaleY;

                g.DrawLine(graphPen, screenX1, screenY1, screenX2, screenY2);

                prevX = x;
                prevY = y;
            }
        }
    }
}
