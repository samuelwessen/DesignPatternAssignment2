using Strategy.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.MessageHandler
{
    public interface ISendMessage
    {
        IMessage Message { get; set; }
        void Send(string message);
    }
}
