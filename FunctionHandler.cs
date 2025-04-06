using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapimt_lab4
{
    class FunctionHandler
    {
        private Dictionary<Func<Decimal, Decimal>, string> functions = new Dictionary<Func<Decimal, Decimal>, string>();
        private ExpressionHandler ExpHandler;

        public FunctionHandler(ExpressionHandler parent)
        {
            ExpHandler = parent;
            functions.Add(Negate, "negate({0})");
            functions.Add(Sqrt, "sqrt({0})");
            functions.Add(Sqr, "sqr({0})");
            functions.Add(Rev, "reverse({0})");
            functions.Add(Cos, "cos({0})");
            functions.Add(Sin, "sin({0})");
            functions.Add(Tg, "tg({0})");
            functions.Add(Ctg, "ctg({0})");
            functions.Add(Ln, "ln({0})");
            functions.Add(Lg, "lg({0})");
            functions.Add(Exp, "exp({0})");
        }

        public Dictionary<Func<Decimal, Decimal>, string> GetFunctionMap()
        {
            return functions;
        }

        public string GetFormat(Func<Decimal, Decimal> f)
        {
            return functions[f];
        }

        public Decimal Negate(Decimal arg)
        {
            return -1 * arg;
        }

        public Decimal Exp(Decimal arg)
        {
            return (Decimal)Math.Exp((double)arg);
        }

        public Decimal Sqrt(Decimal arg)
        {
            return (Decimal)Math.Sqrt((double)arg);
        }

        public Decimal Sqr(Decimal arg)
        {
            return arg * arg;
        }

        public Decimal Rev(Decimal arg)
        {
            return 1 / arg;
        }

        public Decimal Cos(Decimal arg)
        {
            return (Decimal)Math.Cos((double)arg);
        }

        public Decimal Sin(Decimal arg)
        {
            return (Decimal)Math.Sin((double)arg);
        }

        public Decimal Tg(Decimal arg)
        {
            return (Decimal)Math.Tan((double)arg);
        }

        public Decimal Ctg(Decimal arg)
        {
            return (Decimal)(1.0 / Math.Tan((double)arg));
        }

        public Decimal Ln(Decimal arg)
        {
            return (Decimal)Math.Log((double)arg);
        }

        public Decimal Lg(Decimal arg)
        {
            return (Decimal)Math.Log10((double)arg);
        }
    }
}
