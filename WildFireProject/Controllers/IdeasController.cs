using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// this will let us access the Idea class and create an object of type Idea
// the Idea class is inside a namespace called Tables which holds classes that
// represent records of different tables
using WildFireProject.Models.Tables;

namespace WildFireProject.Controllers
{
    public class IdeasController : Controller
    {
        public ActionResult Index()
        {
			// create an idea to store infoa
			Idea idea = new Idea();
			idea.Title = "Overthrow Donald Trump";
			idea.Description = "Idea to take Donald Trump out of the White House!";

			// in the future this would actually query the database and return the ideas there //

			// give the view the idea
            return View(idea);
        }

        public ActionResult Create(string title)
        {
            Idea idea = new Idea();
            idea.Title = title;

            return View(idea);
        }
    }
}
