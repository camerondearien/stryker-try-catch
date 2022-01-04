using System;

namespace ConsoleApp1
{
    public static class Sample
    {
        public static int TestMe(int number)
        {
            try
            {
                if(number == 0)
                {
                    throw new Exception("Throwing exception.");
                }

                return number;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}");
                return -1;
            }
        }
    }
}
