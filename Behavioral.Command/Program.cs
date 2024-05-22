using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Command
{
    // Command Interface
    public interface ICommand
    {
        void Execute();
    }

    // Concrete Command
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }

    // Receiver
    public class Light
    {
        public void On()
        {
            Console.WriteLine("The light is on");
        }

        public void Off()
        {
            Console.WriteLine("The light is off");
        }
    }

    // Invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    // Client
    public class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            ICommand lightOn = new LightOnCommand(livingRoomLight);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(lightOn);
            remote.PressButton();
        }
    }
}
