using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			using (var contect = new Context())
			{
				var user = new User() {Name = DateTime.UtcNow.ToString()};
				contect.Users.Add(user);
				contect.SaveChanges();
				ViewBag.User = user;
			}

			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}