using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace yapimt_lab4
{
    class ExpressionHandler
    {

        private List<string> history = new();

        private Decimal Result; // результат операции
        private string Error = ""; // последняя ошибка
        private string[] Operands = { "+", "-", "/", "*", "%" };

        /**
         * вызов после выполнения математической операции
         * используется History для отображения в истории
         */
        public Action EventListener = () => { };

        private Evaluator parser;
        private string Expression;
        public Operand LastOperand;
        public FunctionHandler FunctionManager;

        private readonly CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();

        public ExpressionHandler()
        {
            ci.NumberFormat.NumberDecimalSeparator = ",";

            LastOperand = new Operand();
            FunctionManager = new FunctionHandler(this);
            parser = new Evaluator(this);
            SetExpressionToDefault();
        }

        public List<string> GetHistory()
        {
            return history;
        }

        public Decimal GetResult()
        {
            return Result;
        }

        public string GetError()
        {
            return Error;
        }

        public void PutNum(string textNum)
        {
            /*
             * добавление цифры к активному операнду
             */

            LastOperand.Add(textNum);
        }

        public void PutComma()
        {
            /*
             * добавление запятой к активному операнду, если возможно
             */

            if (LastOperand.GetFunction() == null && !LastOperand.GetText().Contains(","))
            {
                LastOperand.Add(",");
            }
        }

        public bool PutNegative()
        {
            /*
             * преобразование активного операнда в отрицательное число, либо,
             * если это функция, обертывание ее в функцию negate
             * возвращает true, если было преобразовано в отрицательное
             * и false, если из отрицательного преобразовалось в положительное,
             * либо был ноль
             */

            if (LastOperand.GetText() == "0")
            {
                return false;
            }
            if (LastOperand.GetFunction() != null)
            {
                LastOperand.AddFunction(FunctionManager, FunctionManager.Negate);
                return false;
            }
            Decimal CurrentNum = LastOperand.GetNumber();
            LastOperand.SetByNum(-1 * CurrentNum);

            return CurrentNum > 0;
        }

        public bool PutOperator(string op)
        {
            /*
             * вставка оператора в выражение
             */

            if (!Operands.Contains(op))
            {
                return false;
            }

            string space = " ", expr = Expression;

            if (op == "%")
            {
                space = "";
            }

            if (!LastOperand.WaitForInput() || (LastOperand.WaitForInput() && op != "%"))
            {
                Expression = Expression + LastOperand.GetText();
            }

            Expression += space + op + space;

            SetOperandToDefault();
            return true;
        }

        public void PutFunction(Func<Decimal, Decimal> f)
        {
            /*
             * Обертывание текущего активного операнда в функцию
             * Для обертывания в negate есть отельная функция PutNegative
             */

            if (f == FunctionManager.Negate)
            {
                PutNegative();
                return;
            }
            LastOperand.AddFunction(FunctionManager, f);
        }

        public bool Solve()
        {
            if (!LastOperand.WaitForInput())
            {
                Expression = Expression + LastOperand.GetText();
            }

            // результат и ошибка
            KeyValuePair<Decimal, string> result = parser.Evaluate(Expression);
            Result = result.Key;

            if (result.Value.Length == 0)
            {
                ExpressionDone();
                LastOperand.SetByNum(Result);
                SetExpressionToDefault();
                return true;
            }
            else
            {
                Error = result.Value;
            }

            return false;
        }

        public void ExpressionDone(string exp = null)
        {
            // запись в историю

            if (exp != null)
            {
                history.Add(exp);
            }
            else
            {
                history.Add(Expression);
            }
            EventListener();
        }
        public void SetVariable(string var)
        {
            // устанавливает текущее выражение в вид '<имя_переменной> = '

            Expression = String.Format("{0} = ", var);
            LastOperand.SetDefault();
        }

        public void PutVariable(string var)
        {
            // вставляет переменную в качестве операнда

            if (LastOperand.GetVariable() != "")
            {
                return;
            }

            LastOperand.SetDefault();
            LastOperand.SetVariable(var);
        }

        public void SetToDefault()
        {
            SetOperandToDefault();
            SetExpressionToDefault();
        }

        public void SetOperandToDefault()
        {
            LastOperand.SetDefault();
        }

        public void SetExpressionToDefault()
        {
            Expression = "";
        }

        public string GetExpression()
        {
            return Expression;
        }
    }
}
