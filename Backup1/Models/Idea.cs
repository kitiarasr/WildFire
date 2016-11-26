using System;

namespace WildFireProject.Models.Tables
{
	// an instance of this class will represent one record of the ideas table
	public class Idea
	{
		// idea fields
		public int Id { get; set; } // primary key
		public string Title { get; set; }
		public string Description { get; set; }
		public int UserId { get; set; }
		public DateTime Expiration { get; set; }
		public int Vouches { get; set; }
		public double CurrentFund { get; set; }
		public double FundGoal { get; set; }
		public string Labor { get; set; }
		public int IssueId { get; set; }

		// this contructor take the information to create an Idea object
		public Idea(int id, string title, string description, int userId, string expiration, int vouches,
		           double currentFund, double fundGoal, string labor, int issueId)
		{
			// initialize object fields
			Id = id;
			Title = title;
			Description = description;
			UserId = userId;

			// MySQL database gives timestamp datatype as string to C#
			// expiration must be parsed and turned into DateTime object
			Expiration = DateTime.Parse(expiration);

			Vouches = vouches;
			CurrentFund = currentFund;
			FundGoal = fundGoal;
			Labor = labor;
			IssueId = issueId;
		}

		// this constructor takes no information and creates an empty Idea object
		public Idea() { }
	}
}
