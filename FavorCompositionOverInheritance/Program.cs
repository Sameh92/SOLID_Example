using System;
using System.Collections.Generic;

namespace FavorCompositionOverInheritance
{
    internal class Program
    {

        // Inheritance Pure IS A , Composition Has A
        static void Main(string[] args)
        {
            var choice = 0;
            var pizza = new Pizza();
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 6)
                {
                    ITopping topping= GetTopping(choice);
                    pizza.AddTopping(topping);
                    Console.WriteLine("Press any key to continue");
                }


                Console.ReadKey();
                

            } while (choice != 0);
            Console.WriteLine(pizza);
            Console.ReadKey();
        }
        private static int ReadChoice(int choice)
        {
            Console.WriteLine("Available Topping");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Tomoato");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Cheece");
            Console.WriteLine("4. BlackOlives");
            Console.WriteLine("5. Green Paper");
            Console.WriteLine("6. Paporoni");
            Console.WriteLine("Select Topping");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }
            return choice;
        }

        private static ITopping GetTopping(int choice)
        {
            ITopping topping = null;
            topping = choice switch
            {
                1 => topping = new Tomato(),
                2 => topping = new Chicken(),
                3 => topping = new Cheese(),
                4 => topping = new BlackOlives(),
                5 => topping = new GreenPaper(),
                6 => topping = new Paporoni(),
                _ => null
            };
            return topping;
        }
    }
    public class Pizza
    {
        public virtual decimal Price => 10m;
        public List<ITopping> Toppings { get; private set; } = new List<ITopping>();//private set any modify for this proparity should be from inside the class

        //below method it is responsable to modify Toppings proparity and this method will call from the Client
        public void AddTopping(ITopping topping)=>Toppings.Add(topping);//Expression Body Method

        private decimal Calculate()
        {
            var total = Price;
            foreach (var item in Toppings)
            {
                total += item.Price;
            }
            return total;
        }
        public override string ToString()
        {
         var output =$"\n{nameof(Pizza)}";
            output+=$"\n\tBase Price ({Price.ToString("C") })";
            foreach(var topping in Toppings)
            {
                output += $"\n\t {topping.Title} ({topping.Price.ToString("C")}";
            }
            output += "\n------------------";
            output += $"\nTotal:{Calculate().ToString("C")}";
            return output;
        }

    }

    public interface ITopping
    {
        string Title { get; }
        decimal Price { get; }
    }
    public class Tomato : ITopping
    {
        public string Title => nameof(Tomato);

        public decimal Price =>3m;
    }
    public class Chicken : ITopping
    {
        public string Title => nameof(Chicken);

        public decimal Price => 7m;
    }
    public class Cheese : ITopping
    {
        public string Title => nameof(Cheese);

        public decimal Price => 6m;
    }
    public class BlackOlives : ITopping
    {
        public string Title => nameof(BlackOlives);

        public decimal Price => 1m;
    }
    public class GreenPaper : ITopping
    {
        public string Title => nameof(GreenPaper);

        public decimal Price => 2.5m;
    }
    public class Paporoni : ITopping
    {
        public string Title => nameof(Paporoni);

        public decimal Price =>7.5m;
    }

}
