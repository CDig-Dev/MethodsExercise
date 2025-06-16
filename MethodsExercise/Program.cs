using System.Xml;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"My name is {name}. My favorite a {color} {animal}. I also enjoy listening to  {band}");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        static void Main(string[] args)
        { 
            //Madlib();
            //Console.WriteLine(Add(numOne:2, numTwo:2));
            //int addedNums = Add(numOne: 2, numTwo: 2);
            //Console.WriteLine(addedNums);
           //Console.WriteLine(Subtract(numOne:2, numTwo:2));
           //Console.WriteLine(Multiply(numOne:2, numTwo:2));
           //Console.WriteLine(Divide(numOne:2, numTwo:2));
        }
    }
}


    
    

    
