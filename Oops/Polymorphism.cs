using System;

namespace Oops.Polymorphism
{
    public interface IPayment
    {
        void Pay();
    }

    public class UpiPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Upi Payment");
        }
    }

    public class NetBankingPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Net Banking Payment");
        }
    }

    public class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Card Payment");
        }
    }


    public class MathOps
    {
        public static int Max(int a,int b)
        {
            return a>b?a:b;
        }

        public static int Max(int a,int b,int c)
        {
            return (a>b && a>c) ? a : (b>a && b>c) ? b : c;
        }

        public static double Max(double a, double b)
        {
            return a>b ? a : b;
        }
        
    }

    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehilce started...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle Stopped...");
        }
    }
 
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car Started...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car Stopped...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving Car...");
        }
    }

    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike Started...");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike Stopped...");
        }

        public void Ride()
        {
            Console.WriteLine("Riding Bike...");
        }
    }

    public class PolymorphismExample{
        public static void Main(String[]args)
        {
            IPayment upiPayment=new UpiPayment();
            upiPayment.Pay();

            IPayment netBankingPayment=new NetBankingPayment();
            netBankingPayment.Pay();

            IPayment cardPayment=new CardPayment();
            cardPayment.Pay();


            Console.WriteLine(MathOps.Max(12,23));
            Console.WriteLine(MathOps.Max(12,23,0));
            Console.WriteLine(MathOps.Max(52.23,34));
            
            
            Vehicle car=new Car();
            car.Start();
            car.Stop();

            Vehicle bike =new Bike();
            bike.Start();
            bike.Stop();
        }
    }
}