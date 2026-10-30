using System;

namespace Generics
{
    public class Product<T>
    {
        private T? p;

        public T P
        {
            set 
            {
                this.p = value;
            }

            get
            {
                return p;
            }
        }
    }

    public class Order<T,D>
    {
        private T o;
        private D u;

        public Order()
        {
            
        }

        public Order(T o, D u)
        {
            this.o=o;
            this.u=u;
        }


        public T O
        {
            get
            {
                return this.o;

            }

            set
            {
                this.o=value;
            }
        }

        public D U
        {
            set
            {
                this.u=value;
            }
            get
            {
                return this.u;
            }
        }
    }


    public class GenericClassDemo
    {
        public static void Main(String[]args)
        {
            Product<int> p1=new Product<int>();
            p1.P=21;
            Console.WriteLine(p1.P);

            Product<string> p2=new Product<string>();
            p2.P="Hello";
            Console.WriteLine(p2.P);

            
            Order<string,int> o=new Order<string,int>();

            o.O="Shreyash";
            o.U=22;

            Console.WriteLine(o.O);
            Console.WriteLine(o.U);
            

        }
    }

}