using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WildFireProject
{
	public class DbConnect  //INSERT UPDATE DELETE
	{
		//ATTEMPT AT SETTING UP POINTERS AND STRING CONNECTOR TO USE IN AL METHODS. THIS BELOW MUST BE IN A
		//METHOD FOR SOME REASON
	/*	MySqlConnection conn;
		MySqlCommand command;
		string myConnectionString;

		myConnectionString = "server=" + Config.server + ";uid=" + Config.user + ";" +
				"pwd=" + Config.password + ";database=" + Config.db + ";";

			conn = new MySqlConnection();
		conn.ConnectionString = myConnectionString;
			command = conn.CreateCommand();*/

		public void Insert(string name, string location) 
		{
			MySqlConnection conn;
			MySqlCommand command;
			string myConnectionString;

			myConnectionString = "server=" + Config.server + ";uid=" + Config.user + ";" +
				"pwd=" + Config.password + ";database=" + Config.db + ";";

			conn = new MySqlConnection();
			conn.ConnectionString = myConnectionString;
			command = conn.CreateCommand();

			try
			{

				conn.Open();
				command.CommandText = "INSERT INTO `test` (`name` , `location`) VALUES (@name , @location);";
					//"INSERT INTO `test` (`name`, `location`) VALUES ('kiti', 'yay');";

				command.Parameters.AddWithValue("@name", name);
				command.Parameters.AddWithValue("@location", location);
				command.ExecuteScalar(); //INSERT.. SHOULDNT IT BE executeNonQuery??

				conn.Close();


			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
			}

	
		}



		public void Update(string sql) 
		{
			MySqlConnection conn;
			MySqlCommand command;
			string myConnectionString;

			myConnectionString = "server=" + Config.server + ";uid=" + Config.user + ";" +
					"pwd=" + Config.password + ";database=" + Config.db + ";";

			conn = new MySqlConnection();
			conn.ConnectionString = myConnectionString;
			command = conn.CreateCommand();


			try
			{

				conn.Open();

				command.CommandText = sql;
				command.CommandText = "UPDATE `test` set (`name` , `location`) VALUES (@name , @location);";

				command.ExecuteScalar(); //UPDATE.. SHOULDNT IT BE executeNonQuery??

				conn.Close();


			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
			}





		}
	}



	}
