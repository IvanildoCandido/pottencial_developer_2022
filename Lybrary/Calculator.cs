using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lybrary.Models
{
    public class Calculator
    {
        public void Operation(int x, int y, char op)
        {
            int result = 0;
            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;

            }
            Console.WriteLine($"{x} {op} {y} = {result}");
        }
    }
}