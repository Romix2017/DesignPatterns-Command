using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
