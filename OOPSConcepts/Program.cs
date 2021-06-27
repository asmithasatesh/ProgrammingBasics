using System;
using System.Linq;

namespace OOPSConcepts
{
    class Program
    {

        // <summary>User is asked to enter their preferred Coffee Type , based on which cost is calculated and displayed</summary>
        static void Main(string[] args)
        {   
            string Coffeetype;
            string confirmorder = "Yes";
            do
            {
                // Prints menu to choose from
                Console.WriteLine("Choose from the menu.\n 1.Black Coffee \n 2.Milk Coffee \n 3.Iced Coffee");
                Coffeetype = Console.ReadLine();


                // This implements "Method overriding" using the concept of inheritance.
                //"OrderConfirmeddisplay" is a class that is inherited from "CoffeeRecipe"
                //It overrides the Display() function
                OrderConfirmedisplay poly = new OrderConfirmedisplay();
                poly.Display(Coffeetype);

                //Object creation for CoffeeRecipe
                CoffeeRecipe obj1 = new CoffeeRecipe();
                switch (Coffeetype)
                {
                    case "1":
                        
                        obj1.BlackCoffee(Coffeetype);
                        break;
                    case "2":

                        obj1.MilkCoffee(Coffeetype);
                        break;
                    case "3":
                        obj1.IcedCoffee(Coffeetype);
                        break;
                }

                //This provides option to order another coffee.
                Console.WriteLine("Would you like anything else? Yes/No");
                confirmorder = Console.ReadLine();

            } while (confirmorder == "Yes");

        }
    }
    //Abstract Class is used to hide certain details that are not needed by the user (or) showing only necessary details.
    //It cannot be used to create object, but can have both abstract and regular methods.

    abstract class CoffeeMaker
    {
        public abstract void MilkCoffee(string Coffeetype);
        public abstract void BlackCoffee(string Coffeetype);


    }
    
    
    //Inheritance: CoffeRecipe inherits from CoffeeMaker and overrides it's abstract methods, i.e to define its body.
    class CoffeeRecipe : CoffeeMaker
    { 
        // Array _items makes use of encapsulation to calculate cost of ingredients.
        // It contains cost in Array format as   [coffee powder , milk , ice , sugar]  ->   _items[ 0 , 1 ,2 ,3 ]
        private int[] _items ={100, 50, 50, 10};
        public int cost;

        public override void MilkCoffee(string Coffeetype)
        {
            cost = _items[0] + _items[1] + _items[3];
            Display(Coffeetype);
        }

        public override void BlackCoffee(string Coffeetype)
        {
            cost = _items[0] + _items[3];
            Display(Coffeetype);

        }

        public void IcedCoffee(string Coffeetype)
        {
            // Uses Linq class
            cost = _items.Sum();
            Display(Coffeetype);
        }

        //The virtual keyword is used to modify a method and allow for it to be overridden in a derived class.
        //Cannot use the virtual modifier with the static, abstract, private, or override modifiers. 
        //By default, methods are non-virtual. 
        public virtual void Display(string type)
        {
            string[] coffe= { "Black Coffee", "Milk Coffee", "Iced Coffee" };
            int num = Int32.Parse(type);
            string val = coffe[num - 1];
            Console.WriteLine($"You need to pay Rs \"{cost}\" for your \"{ val }\" \n");

        }
    }
    //Multilevel Inheritance.
    //Overrides the Display() function.
    class OrderConfirmedisplay : CoffeeRecipe
    {
        public override void Display(string type)
        {
            string[] coffe = { "Black Coffee", "Milk Coffee", "Iced Coffee" };
            int num = Int32.Parse(type);
            string val = coffe[num - 1];
            Console.WriteLine($"You have ordered \"{ val }\" \n");

        }
    }


}

