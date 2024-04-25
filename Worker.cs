using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Worker
    {
        protected string name;

        public Worker(string name)
        {
            this.name = name;
        }

        public abstract void Print();
    }

    public class President : Worker
    {
        public President(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"President: {name}");
        }
    }

    public class Security : Worker
    {
        public Security(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Security guard: {name}");
        }
    }

    public class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Manager: {name}");
        }
    }

    public class Engineer : Worker
    {
        public Engineer(string name) : base(name)
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Engineer: {name}");
        }
    }

}
