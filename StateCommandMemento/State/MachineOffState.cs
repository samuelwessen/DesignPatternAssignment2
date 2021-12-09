using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento.State
{
    public class MachineOffState : IMachineState
    {
        public void PowerSwith()
        {
            Console.WriteLine("Turning Machine On");
        }
    }
}
