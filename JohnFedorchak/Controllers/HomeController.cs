using System.Web.Mvc;

namespace JohnFedorchak.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			return View();
		}

		public ActionResult Resume() {
			return View();
		}

		public ActionResult Contact() {
			return View();
		}
	}
}