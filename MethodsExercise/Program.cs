namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //User Input
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            
            //String interpolation
            Console.WriteLine ($"My name is {name}. My favorite a {color} {animal}. I also enjoy listening to  {band}");
            
        }
    }
}
