using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic
    {
        public void ProcessData()
        {
            PersonModel person = new PersonModel();
            IDataAccess dataAccess = new DataAccess();

            Console.WriteLine("Some code here");

            Console.WriteLine("Some more code here");

            person.FirstName = "Tim";
            person.LastName = "Corey";

            Console.WriteLine("Even more code here");

            dataAccess.LoadData("test", "select *");

            dataAccess.SaveData("Test", "delete from Cities");
        }
    }

    public class MoreLogic
    {
        public void SayHi()
        {
            Console.WriteLine("Hello World");
        }
    }
}
