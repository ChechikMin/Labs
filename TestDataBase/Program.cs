
using Base;


namespace TestDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            dataBase.initDbSettings();
            dataBase.makeQuery("use productsdb;" +
                                        "SELECT * FROM Products");
        }
    }
}
