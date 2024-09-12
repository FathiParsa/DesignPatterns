namespace CommandDesignPatternSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            Television livingRoomTelevision = new Television();

            ICommand lightOn = new LightOnCommand(livingRoomLight);
            ICommand lightOff = new LightOffCommand(livingRoomLight);
            ICommand televisionOn = new TelevisionOnCommand(livingRoomTelevision);
            ICommand televisionOff = new TelevisionOffCommand(livingRoomTelevision);

            RemoteControl remote = new RemoteControl();

            remote.Submit(lightOn);
            remote.Submit(televisionOn);
            remote.Undo();
            remote.Submit(lightOff);
            remote.Undo();
        }
    }
}
