using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace WildFireProject
{
	public class DbConnect
	{
		public DbConnect()
		{
			MySqlConnection conn;
			MySqlCommand command;
			string myConnectionString;

			myConnectionString = "server=" + Config.server + ";uid=" + Config.user + ";" +
				"pwd=" + Config.password + ";database=" + Config.db + ";";

			try
			{
				conn = new MySqlConnection();
				conn.ConnectionString = myConnectionString;
				conn.Open();

				command = conn.CreateCommand();
				command.CommandText = "INSERT INTO `test` (`name`, `location`) VALUES ('kiti', 'yay');";


				command.ExecuteScalar();
				//	Console.WriteLine(version);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
			}


		}
	}
}
