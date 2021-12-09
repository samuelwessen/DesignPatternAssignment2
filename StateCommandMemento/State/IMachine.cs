using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCommandMemento.State
{
    public interface IMachine
    {
        void Print(string commands);
    }
}
