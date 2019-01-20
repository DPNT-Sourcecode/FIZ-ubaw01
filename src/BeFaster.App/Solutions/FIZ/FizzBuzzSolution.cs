using BeFaster.Runner.Exceptions;

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
            
            if (result.Length == 0) result = number.ToString();

            return result;
        }
    }
}

