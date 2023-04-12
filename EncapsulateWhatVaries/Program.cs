using System;
using System.Threading;

namespace EncapsulateWhatVaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstansts.CheesePizza);
            Console.WriteLine(pizza);
            Console.WriteLine("Hello World!");
        }
    }
    public class Pizza
    {
        public virtual string Title=>$"{nameof(Pizza)}";
        public virtual decimal Price => 10m;
        public static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals(PizzaConstansts.CheesePizza))
            {
                pizza = new Cheese();
            }
            if (type.Equals(PizzaConstansts.VegeterianPizza))// the chagnes happen in create method (vegeterian new type )
            {
                pizza = new Vegeterian();
            }

            else
                pizza = new Chicken();

            return pizza;

        }
        public static Pizza Order(string type)
        { 
            //What stays the same is isolated from what changes often (the logic that Keeps Changing)

            //Pizza pizza;
            //if (type.Equals("cheese"))
            //{
            //    pizza = new Cheese();
            //}

            //else
            //    pizza = new Chicken();

            Pizza pizza=Create(type);
            Prepare();
            Cook();
            Cut();
            return pizza;

        }
        private static void Prepare()
        {
            Console.Write("Preparing...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cook()
        {
            Console.Write("Cooking...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        private static void Cut()
        {
            Console.Write("Cutting and boxing ...");
            Thread.Sleep(500);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"\n{Title}" + $"\n\t{Price.ToString("C")}";
        }
    } 
    public class Cheese:Pizza
    {
        public override string Title => $"{base.Title}{nameof(Cheese)}";
        public override decimal Price => base.Price+3m;
    }
    public class Chicken : Pizza
    {
        public override string Title => $"{base.Title}{nameof(Chicken)}";
        public override decimal Price => base.Price + 6m;
    }
    //
    public class Vegeterian : Pizza
    {
        public override string Title => $"{base.Title}{nameof(Vegeterian)}";
        public override decimal Price => base.Price + 4m;
    }
}

