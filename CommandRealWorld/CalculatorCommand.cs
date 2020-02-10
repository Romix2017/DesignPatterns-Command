using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealWorld
{
    class CalculatorCommand : Command
    {
        private char _operator;
        private int operand;
        private Calculator calculator;
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this._operator = @operator;
            this.operand = operand;
        }
        public char Operator
        {
            set { _operator = value; }
        }
        public int Operand
        {
            set { operand = value; }
        }
        public override void Execute()
        {
            calculator.Operation(_operator, operand);
        }
        public override void UnExecute()
        {
            calculator.Operation(Undo(_operator), operand);
        }
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operator");
            }
        }
    }
}
