using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForms
{
    class FormatLine
    {
        // 2^2*(5-(2,5*2))
        private string str;
        public string Res = "";
        StackAlgorithm stackAlgorithm;
        public FormatLine(string str)
        {
            this.str = str;
            stackAlgorithm = new StackAlgorithm();
            Res = stackAlgorithm.Algo(FormatString(this.str)).ToString();
            Console.WriteLine(Res);
        }


        public string FormatString(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '(')
                {
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] != ')')
                        {
                            newStr += str[j];
                        }
                        else
                        {
                            str = str.Remove(i, newStr.Length + 2);
                            str = str.Insert(i,stackAlgorithm.Algo(newStr).ToString());
                            FormatString(str);
                            newStr = "";
                        }
                    }
                }
            }
            return str;
        }



    }
}
