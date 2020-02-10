using System;
using System.Collections.Generic;
using System.Text;

namespace CommandRealWorld
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
