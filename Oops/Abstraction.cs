using System;

namespace Oops.Abstraction
{
    
    public interface IAtm
    {
        int Withdraw();
        void ShowBalance();
        void GetReciept();
    }
 
    public class SBIAtm : IAtm
    {
        public int Withdraw()
        {
            Console.WriteLine("Withdrawing Money...");
            return 100;
        }   

        public void ShowBalance()
        {
            Console.WriteLine("Showing Balance...");
        }

        public void GetReciept()
        {
            Console.WriteLine("Printing Reciept...");
        }
    }

    public abstract class Car
    {
        public abstract void Start();
        public abstract void Stop();

        public abstract void Speed();
        public abstract void Break();
    }


    public class Bmw : Car
    {
        public override void Start()
        {
            Console.WriteLine("Starting BMW...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stoping BMW...");
        }

        public override void Speed()
        {
            Console.WriteLine("Speeding BMW...");
        }

        public override void Break()
        {
            Console.WriteLine("Breaking BMW...");
        }
    }

    public class AbstractionExample
    {
        public static void Main(String[] args)
        {
            
            IAtm atm=new SBIAtm();
            atm.ShowBalance();
            atm.Withdraw();
            atm.GetReciept();

            Car bmw=new Bmw();
            bmw.Start();
            bmw.Speed();
            bmw.Break();
            bmw.Speed();
            bmw.Break();
            bmw.Stop();
        }
    }
}