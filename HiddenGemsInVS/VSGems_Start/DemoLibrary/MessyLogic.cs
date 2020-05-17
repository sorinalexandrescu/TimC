using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
public class MessyLogic
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
