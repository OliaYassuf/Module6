using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MusicalInstrument
    {
        protected string name;

        public MusicalInstrument(string name)
        {
            this.name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Sound of {name}: *plays a melody*");
        }

        public void Show()
        {
            Console.WriteLine($"Musical instrument name: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"This is a musical instrument named {name}");
        }

        public virtual void History()
        {
            Console.WriteLine($"The history of {name}: *history details*");
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *plays violin melody*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a violin named {name}");
        }

        public override void History()
        {
            Console.WriteLine($"The history of {name}: *violin history details*");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *plays trombone melody*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a trombone named {name}");
        }

        public override void History()
        {
            Console.WriteLine($"The history of {name}: *trombone history details*");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *plays ukulele melody*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is an ukulele named {name}");
        }

        public override void History()
        {
            Console.WriteLine($"The history of {name}: *ukulele history details*");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {name}: *plays cello melody*");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a cello named {name}");
        }

        public override void History()
        {
            Console.WriteLine($"The history of {name}: *cello history details*");
        }
    }

}
