using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPatternSample
{
    public class ChatRoom : IChatRoomMediator
    {
        private readonly List<User> _users = new List<User>();

        void IChatRoomMediator.RegisterUser(User user)
        {
            _users.Add(user);
        }

        void IChatRoomMediator.SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
