using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternSample
{
    public interface IChatRoomMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
