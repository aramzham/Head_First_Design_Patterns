using HomeAutomationRemoteControl.Lib;
using HomeAutomationRemoteControl.Lib.Commands;
using HomeAutomationRemoteControl.Lib.Receivers;

namespace HomeAutomationRemoteControl.RemoteLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living room");
            //var kitchenLight = new Light("Kithen");
            //var ceilingFan = new CeilingFan("Living room");
            //var garageDoor = new GarageDoor("");
            //var stereo = new Stereo("Living room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //var kitchenLightOn = new LightOnCommand(kitchenLight);
            //var kitchenLightOff = new LightOffCommand(kitchenLight);

            //var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            //var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            //var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            //var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            //var stereoOff = new StereoOffCommand(stereo);

            // we are going to fill all these commands into remote control
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            //remoteControl.SetCommand(3, garageDoorUp, garageDoorDown);

            // print our remote control
            System.Console.WriteLine(remoteControl);

            // pushing the buttons!!!
            remoteControl.OnButtonPressed(0);
            remoteControl.OffButtonPressed(0);
            System.Console.WriteLine(remoteControl);
            remoteControl.UndoButtonPressed();
            remoteControl.OffButtonPressed(0);
            remoteControl.OnButtonPressed(0);
            System.Console.WriteLine(remoteControl);
            remoteControl.UndoButtonPressed();

            System.Console.ReadKey();
        }
    }
}
