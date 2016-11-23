using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WildFireProject.Models
{
	public class DbConnect//INSERT UPDATE DELETE DISPLAY
	{
		private MySqlConnection conn;
		private MySqlCommand command;


		public DbConnect()
		{

			string myConnectionString;

			myConnectionString = "server=" + Config.server + ";uid=" + Config.user + ";" +
				"pwd=" + Config.password + ";database=" + Config.db + ";";

			conn = new MySqlConnection();
			conn.ConnectionString = myConnectionString;
			command = conn.CreateCommand();
			conn.Close();


		}

		private bool OpenConnection()
		{

			try
			{
				conn.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				//When handling errors, you can your application's response based 
				//on the error number.
				//The two most common error numbers when connecting are as follows:
				//0: Cannot connect to server.
				//1045: Invalid user name and/or password.
				switch (ex.Number)
				{
					case 0:
					//	MessageBox.Show("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
					//	MessageBox.Show("Invalid username/password, please try again");
						break;
				}
				return false;
			}

		}

		private bool CloseConnection()
		{

			try
			{
				conn.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				//MessageBox.Show(ex.Message);
				return false;
			}

		}



		public long InsertUser(string username, string first, string last, string email, string password, string skills) 
		{
	
			try
			{
				if (this.OpenConnection() == true)
				{

					command.CommandText = "INSERT INTO users " + "(`username` , `first`, `last`, `email`, `password`, " +
						"`skills`)" + " VALUES (@username , @first, @last, @email, @password, @skills);";

					command.Parameters.AddWithValue("@username", username);
					command.Parameters.AddWithValue("@first", first);
					command.Parameters.AddWithValue("@last", last);
					command.Parameters.AddWithValue("@email", email);
					command.Parameters.AddWithValue("@password", password);
					command.Parameters.AddWithValue("@skills", skills);


					command.ExecuteNonQuery();
					long id = command.LastInsertedId;


					this.CloseConnection();
					return id;
				}

			
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);


			}
			return -1;

	
		}
		public void UpdateUser(string username, string first, string last, string email, string password, string skills)
		{


			try
			{
				if (this.OpenConnection() == true)
				{
					command.CommandText = "UPDATE users SET first = @first WHERE email= @email";

					command.Parameters.AddWithValue("@first", first);
					command.Parameters.AddWithValue("@email", email);

					command.ExecuteNonQuery();

					this.CloseConnection();
				}


			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
			}


		}

		public void DeleteUser(string username, string first, string last, string email, string password, string skills)
		{


			if (this.OpenConnection() == true)
			{
				command.CommandText = "DELETE FROM users WHERE first = @first";
				command.Parameters.AddWithValue("@first", first);

				command.ExecuteNonQuery();

				this.CloseConnection();
			}
		}



		public void InsertIdea(string title, string description, int userid, string expiration, int vouches,
						   double currentfund, double fundgoal, string labor)
		{


				if (this.OpenConnection() == true)
				{
					command.CommandText = "INSERT INTO ideas (`title` , `description`, `userid`, `expiration`, `vouches`, " +
						"`currentfund`, `fundgoal`, `labor`)" + " VALUES (@title , @description, @userid, @expiration," +
						"@vouches, @currentfund, @fundgoal, @labor);";

					command.Parameters.AddWithValue("@title", title);
					command.Parameters.AddWithValue("@description", description);
					command.Parameters.AddWithValue("@userid", userid);
					command.Parameters.AddWithValue("@expiration", expiration);
					command.Parameters.AddWithValue("@vouches", vouches);
					command.Parameters.AddWithValue("@currentfund", currentfund);
					command.Parameters.AddWithValue("@fundgoal", fundgoal);
					command.Parameters.AddWithValue("@labor", labor);
					command.ExecuteNonQuery();


					this.CloseConnection();
				}



		}
		public void UpdateIdea(string title, string description, int userid, string expiration, int vouches,
						   double currentfund, double fundgoal, string labor)
		{

			try
			{
				if (this.OpenConnection() == true)
				{
					command.CommandText = "UPDATE ideas SET first = @first WHERE userid= @userid";

					command.Parameters.AddWithValue("@title", title);
					command.Parameters.AddWithValue("@userid", userid);

					command.ExecuteNonQuery();

					this.CloseConnection();
				}


			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.Message);
			}


		}

		public void DeleteIdea(string title, string description, int userid, string expiration, int vouches,
		                       double currentfund, double fundgoal, string labor)
		{


			if (this.OpenConnection() == true)
			{
				command.CommandText = "DELETE FROM ideas WHERE userid = @userid, title = @title";
				command.Parameters.AddWithValue("@userid", userid);
				command.Parameters.AddWithValue("@title", title);

				command.ExecuteNonQuery();

				this.CloseConnection();
			}
		}





	

	}




}
