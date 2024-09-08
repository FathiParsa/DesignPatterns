namespace BridgeDesignPatternSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            RemoteControl remoteControl = new AdvanceRemoteControl(tv);
            remoteControl.TurnOn();
            ((AdvanceRemoteControl)remoteControl).SetChannel(5);
            remoteControl.TurnOff();

            IDevice radio = new Radio();
            remoteControl = new AdvanceRemoteControl(radio);
            remoteControl.TurnOn();
            ((AdvanceRemoteControl)remoteControl).SetChannel(101);
            remoteControl.TurnOff();
        }
    }
}
