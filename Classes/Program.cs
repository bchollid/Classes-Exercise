namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x5 = new Car();

            x5.Make = "BMW";
            x5.Model = "X5 Plug-In Hybrid";

            Console.WriteLine($"The new car is a {x5.Make} {x5.Model}");
        }
    }
}

//        In the Car class:
//Create a Make property of type string that is public
//Create a Model property of type string that is public
//Create a Year property of type int that is public
//In the Main method:
//Create a new instance of the Car class
//Set values in the properties for the object
//Print the values of each property to the Console