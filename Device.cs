using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Device
    {
        protected string name;

        public Device(string name)
        {
            this.name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Sound of {name}: *muted hum*");
        }

        public void Show()
        {
            Console.WriteLine($"Device name: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"This is a device named {name}");
        }
    }

    public class Kettle : Device
    {
        public Kettle(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *kettle whistling*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a kettle named {name}");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *microwave buzzing*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a microwave named {name}");
        }
    }

    public class Car : Device
    {
        public Car(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *engine revving*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a car named {name}");
        }
    }

    public class Steamboat : Device
    {
        public Steamboat(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *steam engine humming*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a steamboat named {name}");
        }
    }

}
