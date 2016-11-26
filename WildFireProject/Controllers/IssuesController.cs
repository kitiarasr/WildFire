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
    public class IssuesController : Controller
    {
        public ActionResult Index()
        {
			// create an idea to store infoa
			Issue issue = new Issue();
			issue.Title = "Donald Trump is President";
			issue.Description = "Unqualified applicant gets job";
            issue.WhatHap = "Hilary Fucked Up";
            issue.Skimm = "More people dislike Hilary than Trump";

			// in the future this would actually query the database and return the ideas there //

			// give the view the idea
            return View(issue);
        }
    }
}
