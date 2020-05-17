using System;

namespace DemoLibrary
{
    public class BusinessLogic
    {
        public void ProcessData()
        {
            IDataAccess dataAccess = new DataAccess();

            Console.WriteLine("Some code here");

            Console.WriteLine("Some more code here");

            PersonModel person = new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey"
            };

            Console.WriteLine("Even more code here");

            dataAccess.LoadData("test", "select *");

            dataAccess.LoadData("Test", "delete from Cities");
        }
    }
}
