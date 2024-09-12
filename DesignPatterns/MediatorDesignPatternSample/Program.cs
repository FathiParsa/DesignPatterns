namespace MediatorDesignPatternSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatRoomMediator chatRoom = new ChatRoom();

            User user1 = new User("ALice" , chatRoom);
            User user2 = new User("Bob", chatRoom);
            User user3 = new User("Charlie", chatRoom);

            chatRoom.RegisterUser(user1);
            chatRoom.RegisterUser(user2);
            chatRoom.RegisterUser(user3);

            user1.Send("Hello Everyone!");
            user2.Send("Hi Alice!");
            user3.Send("Hey Bob and Alice!!!");
        }
    }
}
