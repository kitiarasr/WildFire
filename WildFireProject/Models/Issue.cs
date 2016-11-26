using System;

namespace WildFireProject.Models.Tables
{
	// an instance of this class will represent one record of the ideas table
	public class Issue
	{
		// idea fields
		public int Id { get; set; } // primary key
		public string Title { get; set; }
		public string Description { get; set; }
        public string WhatHap { get; set; }
        public string Skimm { get; set; }
		public string Category { get; set; }
		public DateTime Date { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }
		
		// this contructor take the information to create an Idea object
		public Issue(int id, string title, string description, string whatHap, string skimm, string category, string date, string location, int userId)
		{
			// initialize object fields
			Id = id;
			Title = title;
			Description = description;
            WhatHap = whatHap;
            Skimm = skimm;
			UserId = userId;
            Category = category;
			// MySQL database gives timestamp datatype as string to C#
			// expiration must be parsed and turned into DateTime object
			Date = DateTime.Parse(date);
            UserId = userId;
            Location = location;

			
			
		}

		// this constructor takes no information and creates an empty Idea object
		public Issue() { }
	}
}
