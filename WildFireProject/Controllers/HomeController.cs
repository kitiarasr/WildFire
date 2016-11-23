using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using WildFireProject.Models;

namespace WildFireProject.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			DbConnect user = new DbConnect(); //object to connect to database

			//I CANT RUN TWO METHODS CONSEQUTIVELY WITHOUT AN ERROR STATING CONNECTION IS ALREADY OPEN.
			//CAN ONLY RUN ONE METHOD AT A TIME FOR NOW.

			long userId = user.InsertUser("kit12321","kiti", "rivera", "example@gmail.com", "blablablapassword", "I can draw horses");
		//	user.UpdateUser("kit12321", "foo", "rivera", "example@gmail.com", "blablablapassword", "I can draw horses");
			//user id collects most recently inserted id. Use for new idea.
			//DbConnect idea = new DbConnect(); //object to connect to database
			//idea.InsertIdea("myidea", "will change everything", (int)userId, "expiration?", 3, 500.00 , 1000.00, "labor horrayy");

			//user.DeleteUser("kit12321","kiti", "rivera", "example@gmail.com", "blablablapassword", "I can draw horses");


		


			return View();
		}
	}
}
