using System;



namespace Oops.Encapsulation{
    public class Vehicle

    {
        private string? brand;
        private string? name;
        private int maxSpeed;

        public Vehicle(string brand,string name, int maxSpeed)
        {
            this.brand=brand;
            this.name=name;
            this.maxSpeed=maxSpeed;
            
        }

        public Vehicle()
        {
            
        }

        public int MaxSpeed
        {
            set
            {
                if(value>0){
                    this.maxSpeed=value;
                }
                else
                {
                    Console.WriteLine("Cannon assign negative max speed");
                }
            }

            get
            {
                return this.maxSpeed;
            }
        }


        public string? Brand
        {
            set{this.brand=value; }
            get{ return this.brand; }
        }

        public string? Name
        {
            get{return this.name; }
            set{ this.name = value; }
        }

    }


    public class EncapsulationExample
    {
        public static void Main(String[] args)
        {
            Vehicle vehicle=new Vehicle();

            // Console.WriteLine(vehicle.maxSpeed);  // cannnot access "maxSpeed" field because it private but we can access "MaxSpeed" because it is property which is accessible 

            Console.WriteLine(vehicle.MaxSpeed);
            Console.WriteLine(vehicle.Brand);
            Console.WriteLine(vehicle.Name);

            vehicle.MaxSpeed=-3;
            Console.WriteLine(vehicle.MaxSpeed);

            vehicle.Brand="BMW";
            vehicle.Name="M4";
            Console.WriteLine(vehicle.Brand);
            Console.WriteLine(vehicle.Name);

            vehicle.MaxSpeed=180;
            Console.WriteLine(vehicle.MaxSpeed);

        }
    }
}
    


