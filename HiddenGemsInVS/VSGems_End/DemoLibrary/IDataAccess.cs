namespace DemoLibrary
{
    public interface IDataAccess
    {
        bool LoadData(string cnn, string sql);

        bool SaveData(string cnn, string sql);
    }
}