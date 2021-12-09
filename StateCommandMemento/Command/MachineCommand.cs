using StateCommandMemento.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento.Command
{
    public class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public string InputCommand { get; set; }

        public MachineCommand(IMachine machine, string inputCommand)
        {
            Machine = machine;
            InputCommand = inputCommand;
        }

        public void Execute()
        {
            Machine.Print(InputCommand);
        }
    }
}
