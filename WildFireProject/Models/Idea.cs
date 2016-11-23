using System;
namespace WildFireProject
{
	public class ideas
	{

		private string title {get; set;}

		private string description {get; set;}

		private int userid {get; set;}

		private string expiration {get; set;}

		private int vouches {get; set;}

		private int currentfund {get; set;}

		private int fundgoal {get; set;}

		private string labor {get; set;}


		public ideas()
		{
			
			title = "";
			description = "";
			userid = 0;
			expiration = "";
			vouches = 0;
			currentfund = 0;
			fundgoal = 0;
			labor = "";

		}
	}
}
