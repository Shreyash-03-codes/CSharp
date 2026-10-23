using System;

namespace Oops.Inheritance
{
    public class Human
    {
        private string? name;
        private string? gender;
        private int age;

        public Human()
        {
            
        }


        public Human(string name, string gender, int age)
        {
            this.name=name;
            this.gender=gender;
            if (age > 0)
            {
             this.age=age;               
            }
            else
            {
                Console.WriteLine("Cannot assign the negative age");
            }
        }

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    this.age=value;
                }
                else
                {
                    Console.WriteLine("negative age cannot assign");
                }
            }
            get
            {
                return this.age;
            }
        }

        public string? Name
        {
            set
            {
                this.name=value;
            }
            get
            {
                return this.name;
            }
        }

        public string? Gender
        {
            set
            {
                this.gender=value;
            }

            get
            {
                return this.gender;
            }
        }


        public void Talk()
        {
            Console.WriteLine(this.name+" is Talking....");
        }

        public void Walk()
        {
            Console.WriteLine(this.name+" is Walking..");
        }

        public void Eat()
        {
            Console.WriteLine(this.name+" is Eating");
        }

       
    }

    public class Developer : Human
    {
        private int applicationDeveloped;
        private string? role;

        public Developer()
        {
            
        }

        public Developer(string name, string gender, int age,int applicationDeveloped, string role) : base(name,gender, age)
        {
            this.role=role;
            this.applicationDeveloped=applicationDeveloped;
        }

        public int ApplicationDeveloped
        {
            set
            {
                if (value >= 0)
                {
                    this.applicationDeveloped=value;
                }
                else
                {
                    Console.WriteLine("You cannot assign negative count");
                }
            }

            get
            {
                return this.applicationDeveloped;
            }
        }

        public string? Role
        {
            set
            {
                this.role=value;
            }

            get
            {
                return this.role;
            }
        }

        public void Code()
        {
            Console.WriteLine(base.Name+" is Coding...");
        }

        public void Present()
        {
            Console.WriteLine(base.Name+" is presenting...");
            base.Talk();
        }
    }

    public class Cricketer : Human
    {
        private int matchesPlayed;

        public Cricketer()
        {
            
        }

        public Cricketer(string name, string gender, int age, int matcherPlayed) : base(name, gender, age)
        {
            this.matchesPlayed=matcherPlayed;
        }

        public int MatchesPlayed
        {
            set
            {
                if (value >= 0)
                {
                    this.matchesPlayed=value;
                }
                else
                {
                    Console.WriteLine("Cannot assigne the negative count");
                }

            
            }
            get{
                return this.matchesPlayed;
            }
        }

        public void Play()
        {
            Console.WriteLine(base.Name+" is playing...");
        }
    }
    public class InheritanceExample
    {
        public static void Main(String[] args)
        {
            Developer shreyash=new Developer("Shreyash","Male",-3,3,"Fullstack Developer");
            shreyash.Code();
            shreyash.Present();
            shreyash.Walk();
            shreyash.Age=21;
            Console.WriteLine(shreyash.Age);

            Console.WriteLine();


            Developer bat=new Developer();
            bat.Age=-2;
            bat.Name="Bruce Wayne";
            bat.Gender="Male";
            bat.Role="Team Lead";
            bat.ApplicationDeveloped=14;
            bat.Age=32;

            bat.Eat();
            Console.WriteLine(bat.Name);
            Console.WriteLine(bat.Gender);
            Console.WriteLine(bat.Age);
            Console.WriteLine(bat.Role);
            Console.WriteLine(bat.ApplicationDeveloped);
            bat.Talk();

            Console.WriteLine();
            Cricketer cricketer=new Cricketer("Virat Kohali","Male",38,400);
            cricketer.Play();
            
        }
    }
}