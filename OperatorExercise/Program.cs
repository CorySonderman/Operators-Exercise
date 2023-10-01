using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1.  I hope it was ok that I did not stay within the scope
            of the exercise.  I wanted to challenge my thought process.*/
            Console.WriteLine("Exercise 1");
            Console.WriteLine("Would you like to do some Math, yes or no?");
            string answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                Console.WriteLine("Sweet! Let's get smart together.");
            }
            else if (answer1 == "Yes")
            {
                Console.WriteLine("Sweet! Let's get smart together!");
            }
            else if (answer1 == "no")
            {
                Console.WriteLine("Come on... Don\'t be a stick in the mud.  Let\'s do " +
                    "some math.");
            }
            else if (answer1 == "No")
            {
                Console.WriteLine("Come on... Don\'t be a stick in the mud.  Let\'s do " +
                    "some math.");
            }
            else
            {
                Console.WriteLine("I\'m just a computer and the only answer I understand " +
                    "is yes or no so let\'s just do some Math anyway.");
            }

            Console.WriteLine ("Pick a number.");
            var input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Now pick a second number.");
            var input2 = double.Parse(Console.ReadLine());

            var sum = input1 + input2;
            Console.WriteLine($"{input1} + {input2} = {sum}");

            var dif = input1 - input2;
            Console.WriteLine($"{input1} - {input2} = {dif}");

            var prod = input1 * input2;
            Console.WriteLine($"{input1} x {input2} = {prod}");

            var quotient = input1 / input2;
            Console.WriteLine($"{input1} / {input2} = {quotient}");
            Console.WriteLine();

            Console.WriteLine("Now since I am just a baby computer and still " +
            "learning, this one only works if the first number is greater than " +
            "or equal to the second number.  If you cheat, then you will get a wrong " +
            "answer.  You don't want to fail your test. The % sign represents modulus " +
            "and it tells us the remainder of a quotient.");
            Console.WriteLine ("Pick your first number.");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Now give me numero two!");
            var b = int.Parse(Console.ReadLine());
            var quotient2 = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a} / {b} = {quotient2} with a remainder of" +
            $" {remainder}.");
            Console.WriteLine();    

            Console.WriteLine("Feeling big brained yet?  All this practice sure is" +
            " making me smarter. Thanks!");
          

            // Exercise 2
            Console.WriteLine ("Exercise 2");
            Console.WriteLine("Let\'s keep the party rolling.  Now let\'s figure " +
            "out the area of a circle using the radius. The equation to solve " +
            "the area of a circle is A = πr^2.");
            Console.WriteLine("What would you like the radius to be?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle with a readius " +
            $"of {radius} is {area}.");
            Console.WriteLine ();
              
            Console.WriteLine("I don\'t know about you but my brain is cashed " +
            "out for the day.  Let\'s play again tomorrow!");
            Console.WriteLine();
            //Exerice 3
            Console.WriteLine("Exercise 3");
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

        }
           // Exercie 2 Continued
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
