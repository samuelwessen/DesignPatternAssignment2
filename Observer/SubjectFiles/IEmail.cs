using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.SubjectFiles
{
    public interface IEmail : ISubject
    {
        string Message { get; set; }
    }
}
