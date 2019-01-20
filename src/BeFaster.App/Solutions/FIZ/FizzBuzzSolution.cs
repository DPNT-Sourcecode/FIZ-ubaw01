using BeFaster.Runner.Exceptions;
using System.Linq;
namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string result = "";
            if (number % 3 == 0 || number.ToString().Contains("3")) result = "fizz";

            if (number % 5 == 0 || number.ToString().Contains("5"))
            {
                if (result.Length >0)
                {
                    result += " ";
                }
                
                result = result + "buzz";
            }

           // string numberinString = number.ToString();
           // int count = numberinString.Count(x => x == numberinString.ToCharArray()[0]);

            if (result.Contains("buzz") && result.Contains("fizz"))
            {
                if (result.Length > 0)
                {
                    result += " ";
                }
                if (number % 2 == 1)
                {
                    result = result + "fake deluxe";
                }
                else
                {
                    result = result + "deluxe";
                }
            }

            if (result.Length == 0) result = number.ToString();

            return result;
        }
    }
}

