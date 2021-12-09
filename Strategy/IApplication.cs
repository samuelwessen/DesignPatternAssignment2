using Strategy.Message;
using Strategy.MessageHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IApplication
    {
        ISendMessage SendMessage { get; set; }
        IEmail Email { get; set; }
        ISMS SMS { get; set; }
        IFacebook Facebook { get; set; }

        void Run();
    }
}
