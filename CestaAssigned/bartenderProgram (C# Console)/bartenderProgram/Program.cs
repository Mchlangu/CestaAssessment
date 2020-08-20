using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bartenderProgram
{
    class Program
    {
        static bool shouldServeDrinks(int customerAge, bool isBreakSession)
        {
            bool shouldServe = false;

            if (!isBreakSession && customerAge >= 18)
            {
                shouldServe = true;
            }
            return shouldServe;
        }

        static bool isBreakNow()
        {
            bool isBreakSession = true;

            TimeSpan breakStart = new TimeSpan(03, 0, 0);  //Break set the start of break of time
            TimeSpan endBreak = new TimeSpan(03, 50, 0);   //Break set the end of break time
            TimeSpan now = new TimeSpan( Int32.Parse(DateTime.Now.ToString("HH")), Int32.Parse(DateTime.Now.ToString("mm")), 0); //get current time
         
            if ((now < breakStart) || (now > endBreak))
            {
                isBreakSession = false;
            }

            return isBreakSession;
        }

        static void Main(string[] args)
        {

            bool isBreakSession;
            bool isServing;
            int customerAge;
            string customerName;

            Console.WriteLine("Hello! What's your name?");
            customerName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            customerAge = Convert.ToInt32(Console.ReadLine());

            isBreakSession = isBreakNow();
            isServing = shouldServeDrinks(customerAge, isBreakSession);

            if (isServing)
            {
                Console.WriteLine("Hello! Your drinks are on the way.");
            }
            else
            {
                Console.WriteLine("Hello. Can't serve you at the moment.");
            }

            Console.ReadKey();
        }
    }
}
