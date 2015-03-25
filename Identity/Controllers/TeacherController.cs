using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace finaldesign_template.Controllers
{
    public class TeacherController : Controller
    {
        //
        // GET: /Teacher/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Prepare_Purchase_requisition()
        {
            return View();
        }
        public ActionResult store()
        {
            return View();
        }
        public ActionResult MyProfile()
        {
            return View();
        }

	}
}