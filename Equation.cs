using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGenerator
{
    internal class Equation
    {
        public int former;
        public int latter;
        public int answer;
        public IOperator? opt;

        public Equation(Random random, bool includeMultiply, bool includeDivide)
        {
            int range = includeMultiply || includeDivide ? 3 : 2;
            switch(random.Next(range))
            {
                case 0:
                    opt = new Plus();
                    former = random.Next(100);
                    latter = random.Next(100);
                    answer = former + latter;
                    break;
                case 1:
                    opt = new Subtract();
                    int op1 = random.Next(100);
                    int op2 = random.Next(100);
                    former = Math.Max(op1, op2);
                    latter = Math.Min(op1, op2);
                    answer = former - latter;
                    break;
                default:
                    if (includeMultiply && includeDivide)
                    {
                        switch (random.Next(2))
                        {
                            case 0:
                                opt = new Multiply();
                                former = random.Next(30);
                                latter = random.Next(10);
                                answer = former * latter;
                                break;
                            case 1:
                                opt = new Divide();
                                latter = random.Next(1, 10);
                                answer = random.Next(30);
                                former = latter * answer;
                                break;
                        }
                    }
                    else if (includeMultiply)
                    {
                        opt = new Multiply();
                        former = random.Next(30);
                        latter = random.Next(10);
                        answer = former * latter;
                    }
                    else
                    {
                        opt = new Divide();
                        latter = random.Next(1, 10);
                        answer = random.Next(30);
                        former = latter * answer;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return former + " " + opt.Symbol() + " " + latter + " = ";
        }
    }

    internal interface IOperator
    {
        public String Symbol();
    }

    internal class Plus : IOperator
    {
        public String Symbol()
        {
            return "+";
        }
    }

    internal class Subtract : IOperator
    {
        public String Symbol()
        {
            return "-";
        }
    }

    internal class Multiply : IOperator
    {
        public String Symbol()
        {
            return "×";
        }
    }

    internal class Divide : IOperator
    {
        public String Symbol()
        {
            return "÷";
        }
    }
}