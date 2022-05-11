using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;


namespace Base
{
	public class DataBase
	{
		string connetionString;
		SqlConnection cnn;
		public DataBase()
		{


		}
		public void initDbSettings()
		{

			Console.WriteLine("Connecting... ");
			connetionString = @"Data Source=(localdb)\MSSQLLocalDB;
                            Initial Catalog=productsdb;";

		}
		public void makeQuery(string sqlExpression = "")
		{
			using (cnn = new SqlConnection(connetionString))
			{
				cnn.Open();
				Console.WriteLine("Connection opened!");

				using (SqlCommand command = new SqlCommand())
				{
					command.Connection = cnn;
					command.CommandText = sqlExpression;


					using (SqlDataReader reader = command.ExecuteReader())
					{

						if (reader.HasRows)
							while (reader.Read())
							{

								Unit unit = new Unit();

								int prodName = reader.GetOrdinal("ProductName");
								string name = reader.GetString(prodName);
								unit.name = name;
								Console.WriteLine("Name:" + unit.name);
								Console.WriteLine("------------\n");
							}
					}
				}
			}
		}
		public struct Unit
		{
			public string name { set; get; }

			public int count { set; get; }
			public string company { set; get; }
			public int price { set; get; }
		}
	}
}