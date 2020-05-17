using System;

namespace DemoLibrary
{
    public class DataAccess : IDataAccess
    {
        public bool LoadData(string cnn, string sql)
        {

            if (sql.Length < 1)
            {
                return false;
            }

            if (cnn.Length < 1)
            {
                return false;
            }

            GetDataFromSQL();

            return true;
        }

        public bool SaveData(string cnn, string sql)
        {
            if (sql.Length < 1)
            {
                return false;
            }

            if (cnn.Length < 1)
            {
                return false;
            }

            return true;
        }

        private void GetDataFromSQL()
        {
            Console.WriteLine("Simulates getting data from sql");
        }
    }
}
