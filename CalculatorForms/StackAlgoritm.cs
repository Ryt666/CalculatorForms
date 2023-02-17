using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForms
{
    internal class StackAlgorithm : IArithmetic_Interface
    {
      
        Stack<double> stack1 = new Stack<double>();
        Stack<char> stack2 = new Stack<char>();
        /*public string Res = "";
        private string str;

        public StackAlgorithm(string str)
        {
            this.str = str;
            Res =Algo(FormatString(this.str)).ToString();
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
                            str = str.Insert(i, Algo(newStr).ToString());
                            FormatString(str);
                            newStr = "";
                        }
                    }
                }
            }
            return str;
        }
        */

        public double Algo(string str)
        {
            string numbers="";      // -4+5     4+-6
            bool flag ;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '^' || str[i] == '√')
                {
                    flag = true;
                    if (numbers != "")
                    {
                        stack1.Push(double.Parse(numbers));
                        numbers = "";
                    }
                    if ((str[i]=='-' && i==0) || (str[i] != 0 && (str[i - 1] == '+' || str[i - 1] == '-' || str[i - 1] == '*' || str[i - 1] == '/' || str[i - 1] == '^' || str[i - 1] == '√')))
                    {
                        numbers += "-";
                        flag = false;
                    }
                    if (flag)
                        Stack(str[i]);
                }
                else
                {
                    numbers += str[i];
                }
            }
            stack1.Push(double.Parse(numbers));
            DecideStack1();
            return Result();
        }
        public void Stack(char symbol)
        {
            if (stack2.Count == 0)
            {
                stack2.Push(symbol);
            }
            else if ((Apriority(stack2.Peek()) >= Apriority(symbol)) && stack1.Count != 1)
            {
                if (stack2.Peek() == '+')
                {
                    Sum();
                    stack2.Push(symbol);
                }
                else if (stack2.Peek() == '-')
                {
                    Difference();
                    stack2.Push(symbol);
                }
                else if (stack2.Peek() == '*')
                {
                    Multiplication();
                    stack2.Push(symbol);
                }
                else if (stack2.Peek() == '/')
                {
                    Divide();
                    stack2.Push(symbol);
                }
                else if(stack2.Peek() == '^')
                {
                    Degree();
                    stack2.Push(symbol);
                }
                else if (stack2.Peek() == '√')
                {
                    Sqrt();
                    stack2.Push(symbol);
                }
            }
            else
                stack2.Push(symbol);
        }


        public int Apriority(char a)
        {
            if (a == '+')
            {
                return 1;
            }
            else if (a == '-')
            {
                return 1;
            }
            else if (a == '*')
            {
                return 2;
            }
            else if (a == '/')
            {
                return 2;
            }
            else if(a=='^')
            {
                return 3;
            }
            else if(a== '√')
            {
                return 3;
            }
            return 0;
        }


        public void DecideStack1()
        {
            while (stack2.Count != 0)
            {
                if (stack2.Peek() == '+')
                {
                    Sum();
                }
                else if (stack2.Peek() == '-')
                {
                    Difference();
                }
                else if (stack2.Peek() == '*')
                {
                    Multiplication();
                }
                else if (stack2.Peek() == '/')
                {
                    Divide();
                }
                else if(stack2.Peek() == '^')
                {
                    Degree();
                }
                else if (stack2.Peek() == '√')
                {
                    Sqrt();
                }
            }
        }

        public double Result()
        {
            return stack1.Pop();
        }

        public void Sum()
        {
            double a = stack1.Pop();
            double b = stack1.Pop();
            stack1.Push(a + b);
            stack2.Pop();
        }

        public void Difference()
        {
                double a = stack1.Pop();
                double b = stack1.Pop();
                stack1.Push(b - a);
                stack2.Pop();
        }

        public void Multiplication()
        {
            double a = stack1.Pop();
            double b = stack1.Pop();
            stack1.Push(a * b);
            stack2.Pop();
        }

        public void Divide()
        {
            double a = stack1.Pop();
            double b = stack1.Pop();
            stack1.Push(b / a);
            stack2.Pop();
        }

        public void Degree()
        {
            double a = stack1.Pop();
            double b = stack1.Pop();
            stack1.Push(Math.Pow(b,a));
            stack2.Pop();
        }

        public void Sqrt()
        {
            double a = stack1.Pop();
            double b = stack1.Pop();
            stack1.Push(Math.Pow(b, 1/a));
            stack2.Pop();
        }
    }
}
