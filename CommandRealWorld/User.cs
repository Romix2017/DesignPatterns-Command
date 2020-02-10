using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealWorld
{
    public class User
    {
        private Calculator calculator = new Calculator();
        private List<Command> commands = new List<Command>();
        private int current = 0;
        public void Redo(int levels)
        {
            Console.WriteLine("\n----Redo {0} levels", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    command.UnExecute();
                }
            }
        }
        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            commands.Add(command);
            current++;
        }
    }
}
