using System;

namespace DemoLibrary
{
    public class BetterLogic
    {
        public static void TechnicallyOK()
        {
            DateTime time = DateTime.Now;
            if (time.Hour >= 12)
            {
                Console.WriteLine("It is after noon");
            }
            else
            {
                Console.WriteLine("It is before noon");
            }
        }
    }
}
