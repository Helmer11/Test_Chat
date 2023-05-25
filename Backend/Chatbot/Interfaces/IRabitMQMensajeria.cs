using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.Interfaces
{
    internal interface IRabitMQMensajeria
    {
        void  SendProductMessage<T>(T message);
    }
}
