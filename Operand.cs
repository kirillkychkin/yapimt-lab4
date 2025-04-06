using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapimt_lab4
{
    class Operand
    {
        private string Variable = "";
        private string Format = "{0}"; // вывод операнда
        private Func<Decimal, Decimal> Function = null; // последняя функция, в которую был обернут операнд
        private string Text = "0"; // текстовое представление операнда
        private Decimal Number = 0; // числовое представление операнда
        /**
         * начат ли уже ввод цифр в оператор
         * становится true при модификации через Add/AddFunction
         */
        private bool waitForInputStart = true;
        private readonly CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();

        public Operand(bool waitForInputStart = false)
        {
            ci.NumberFormat.NumberDecimalSeparator = ",";
            this.waitForInputStart = waitForInputStart;
        }

        public void SetDefault()
        {
            /*
             * возвращает значения всех свойств к изначальным
             */

            DeleteFunctions();
            Text = "0";
            Number = 0;
            waitForInputStart = true;
        }

        public void DeleteFunctions()
        {
            Format = "{0}";
            Function = null;
        }

        public void SetWaiting(bool waitForInputStart)
        {
            this.waitForInputStart = waitForInputStart;
        }

        public bool WaitForInput()
        {
            return waitForInputStart;
        }

        public void SetVariable(string V)
        {
            Variable = V;
            SetWaiting(false);
        }

        public string GetVariable()
        {
            return Variable;
        }

        public string GetFormat()
        {
            return Format;
        }

        public Func<Decimal, Decimal> GetFunction()
        {
            return Function;
        }

        public void AddFunction(FunctionHandler FManager, Func<Decimal, Decimal> f)
        {
            /*
             * оборачивает операнд в указанную функцию
             */

            waitForInputStart = false;

            if (Function != null && Variable != "")
            {
                Number = Function(Number);
            }

            Function = f;
            AddFormat(FManager.GetFormat(f));
        }

        public void AddFormat(string f)
        {
            Format = String.Format(f, Format);
        }

        public void SetFormat(string f)
        {
            Format = f;
        }

        public string GetText()
        {
            if (Variable == "")
            {
                return string.Format(Format, Text);
            }
            else
            {
                return string.Format(Format, Variable);
            }
        }

        public Decimal GetNumber()
        {
            if (Variable != "")
            {
                return 0;
            }

            if (Function != null)
            {
                return Function(Number);
            }
            return Number;
        }

        public string GetValue()
        {
            if (Variable != "")
            {
                return Variable;
            }

            if (Function != null)
            {
                return Function(Number).ToString();
            }
            return Number.ToString();
        }

        public void SetByStr(string s)
        {
            /*
             * Устанавливает числовое и строковое значение операнда по строке. 
             * Автоматически удаляет функции, в которые обернут операнд
             */

            Variable = "";
            DeleteFunctions();
            Text = s;
            Number = Decimal.Parse(s);
        }

        public void SetByNum(Decimal num)
        {
            /*
             * Устанавливает числовое и строковое значение операнда по числу. 
             * Автоматически удаляет функции, в которые обернут операнд
             */

            Variable = "";
            DeleteFunctions();
            Number = num;
            Text = num.ToString();
        }

        public void Add(string d)
        {
            /*
             * Добавляет новый символ к операнду
             */

            Variable = "";
            waitForInputStart = false;

            if (Text == "0" && d != ",")
            {
                Text = "";
            }
            Text += d;
            Number = Decimal.Parse(Text, ci);
        }
    }
}
