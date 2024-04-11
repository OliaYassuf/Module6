using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //--------------------------------------------------------------------------------------------1
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }

        public Human(string name, int age, string nationality)
        {
            Name = name;
            Age = age;
            Nationality = nationality;
        }

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}, I am {Age} years old, and I am {Nationality}.");
        }
    }
    class Builder : Human
    {
        public string Specialization { get; set; }
        public int YearsOfExperience { get; set; }

        public Builder(string name, int age, string nationality, string specialization, int yearsOfExperience) : base(name, age, nationality)
        {
            Specialization = specialization;
            YearsOfExperience = yearsOfExperience;
        }

        public void Build()
        {
            Console.WriteLine($"{Name} is a builder specialized in {Specialization} with {YearsOfExperience} years of experience.");
        }

        public void Hammer()
        {
            Console.WriteLine($"{Name} is hammering nails.");
        }
    }
    class Sailor : Human
    {
        public string VesselType { get; set; }
        public string Route { get; set; }

        public Sailor(string name, int age, string nationality, string vesselType, string route) : base(name, age, nationality)
        {
            VesselType = vesselType;
            Route = route;
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} is a sailor working on a {VesselType} sailing {Route}.");
        }

        public void SwabDeck()
        {
            Console.WriteLine($"{Name} is swabbing the deck.");
        }
    }
    class Pilot : Human
    {
        public string AircraftType { get; set; }
        public string LicenseType { get; set; }

        public Pilot(string name, int age, string nationality, string aircraftType, string licenseType) : base(name, age, nationality)
        {
            AircraftType = aircraftType;
            LicenseType = licenseType;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is a {LicenseType} pilot flying a {AircraftType}.");
        }

        public void CheckInstruments()
        {
            Console.WriteLine($"{Name} is checking the aircraft instruments.");
        }
    }

    //--------------------------------------------------------------------------------------------2
    class Passport
    {
        public string FullName { get; set; }
        public string PassportNumber { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Passport(string fullName, string passportNumber, string nationality, DateTime dateOfBirth)
        {
            FullName = fullName;
            PassportNumber = passportNumber;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
            Console.WriteLine($"Nationality: {Nationality}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }

    class ForeignPassport : Passport
    {
        public string VisaInformation { get; set; }
        public string PassportCountry { get; set; }

        public ForeignPassport(string fullName, string passportNumber, string nationality, DateTime dateOfBirth, string visaInformation, string passportCountry)
            : base(fullName, passportNumber, nationality, dateOfBirth)
        {
            VisaInformation = visaInformation;
            PassportCountry = passportCountry;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Visa Information: {VisaInformation}");
            Console.WriteLine($"Passport Country: {PassportCountry}");
        }
    }
    //--------------------------------------------------------------------------------------------3
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age}-year-old animal.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }
    }
    class Mammal : Animal
    {
        public string Color { get; set; }

        public Mammal(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I am {Color}.");
        }
    }
    class Tiger : Mammal
    {
        public string StripePattern { get; set; }

        public Tiger(string name, int age, string stripePattern) : base(name, age, "orange")
        {
            StripePattern = stripePattern;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I have {StripePattern} stripes.");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting.");
        }
    }
    class Kangaroo : Mammal
    {
        public double JumpHeight { get; set; }

        public Kangaroo(string name, int age, double jumpHeight) : base(name, age, "brown")
        {
            JumpHeight = jumpHeight;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I can jump up to {JumpHeight} meters high.");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} is jumping.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is hopping.");
        }
    }

    class Crocodile : Animal
    {
        public string Habitat { get; set; }

        public Crocodile(string name, int age, string habitat) : base(name, age)
        {
            Habitat = habitat;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I live in {Habitat}.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming in the {Habitat}.");
        }
    }
    //--------------------------------------------------------------------------------------------4
    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing {Name}...");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with width {Width} and height {Height}...");
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with radius {Radius}...");
        }
    }

    class RightTriangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(string name, double @base, double height) : base(name)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with base {Base} and height {Height}...");
        }
    }

    class Trapezoid : Shape
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(string name, double base1, double base2, double height) : base(name)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Name} with bases {Base1} and {Base2} and height {Height}...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Builder bob = new Builder("John", 35, "American", "skyscraper construction", 10);
            bob.Introduce();
            bob.Build();
            bob.Hammer();
            Console.WriteLine();

            Sailor jack = new Sailor("Jack", 40, "British", "container ship", "across the Pacific");
            jack.Introduce();
            jack.Sail();
            jack.SwabDeck();
            Console.WriteLine();

            Pilot luke = new Pilot("James", 30, "Canadian", "fighter jet", "commercial");
            luke.Introduce();
            luke.Fly();
            luke.CheckInstruments();
            Console.WriteLine();

            //2
            Passport passport = new Passport("Darion Jobs", "AB123456", "DEU", new DateTime(2000, 12, 16));
            Console.WriteLine("Passport Details:");
            passport.PrintDetails();

            ForeignPassport foreignPassport = new ForeignPassport("Olia Yassuf", "XYZ789", "UA", new DateTime(2005, 4, 16), "Valid visa for Europe", "Ukraine");
            Console.WriteLine("\nForeign Passport Details:");
            foreignPassport.PrintDetails();
            Console.WriteLine();
            //3
            Tiger tigger = new Tiger("Tigger", 5, "black stripes");
            tigger.Introduce();
            tigger.Hunt();
            tigger.Move();

            Kangaroo joey = new Kangaroo("Joey", 3, 2.5);
            joey.Introduce();
            joey.Jump();
            joey.Move();

            Crocodile crocky = new Crocodile("Crocky", 10, "swamp");
            crocky.Introduce();
            crocky.Swim();
            crocky.Move();

            //4
            Shape[] shapes = new Shape[]
        {
            new Rectangle("Rectangle", 5, 4),
            new Circle("Circle", 3),
            new RightTriangle("Right Triangle", 6, 3),
            new Trapezoid("Trapezoid", 5, 3, 4)
        };

            foreach (var shape in shapes)
            {
                shape.Draw();
                shape.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}
