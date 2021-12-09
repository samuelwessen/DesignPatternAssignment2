using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento.State
{
    public class MachineOnState : IMachineState
    {
        public void PowerSwith()
        {
            Console.WriteLine("Turning Machine Off");
        }
    }
}
