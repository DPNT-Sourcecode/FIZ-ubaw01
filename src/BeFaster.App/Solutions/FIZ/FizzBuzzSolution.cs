using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string returnValue = "";
            for(int i=0;i<number;i++)
            {
                string result = "";
                if (i % 3 == 0 ) result = "fizz";

                if (i % 5 == 0) result = result + "buzz";

                if (result.Length ==0) result = i.ToString();

                returnValue += result;
            }
            return returnValue;
        }
    }
}

