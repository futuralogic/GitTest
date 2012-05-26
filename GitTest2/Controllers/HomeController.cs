using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using GitTest2;

namespace Controllers {
	[HandleError]
	public class HomeController : Controller {
		public ActionResult Index()
		{
			ViewData["Message"] = "Hello, world.";

			List<Beer> beers = new List<Beer>();
			beers.Add( new Beer {
				AlcoholPercent = 10.6,
				Brewery = "Whatever",
				Name = "Something Interesting"
			});

			return View( beers );
		}
	}
}

