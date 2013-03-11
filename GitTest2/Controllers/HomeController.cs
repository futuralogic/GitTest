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
			ViewData["Message"] = "Aaron's Beer List";

			List<Beer> beers = new List<Beer>();
			beers.Add( new Beer {
				AlcoholPercent = 6.2,
				Brewery = "Abbaye Notre-Dame d'Orval",
				Name = "Orval",
				Country = "Belgium",
				Rating = 10,
			});

			beers.Add( new Beer {
				AlcoholPercent = 9.0,
				Brewery = "Unibroue",
				Name = "Don de Dieu",
				Country = "Canada",
				Rating = 8
			});

			beers.Add (new Beer {
				AlcoholPercent = 12,
				Brewery = "Gulden Draak",
				Name = "Gulden Draak",
				Country = "Belgium",
				Rating = 10
			});

			return View( beers );
		}
	}
}

