using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealWorld
{
    public class Calculator
    {
        private int curr = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': this.curr += operand; break;
                case '-': this.curr -= operand; break;
                case '*': this.curr *= operand; break;
                case '/': this.curr /= operand; break;
            }
            Console.WriteLine("Current value = {0} (following {1} {2})", curr, @operator, operand);
        }
    }
}
