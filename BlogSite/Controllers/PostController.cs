using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogServices;
using BlogServices.Implementations;

namespace BlogSite.Controllers
{
    public class PostController : Controller
    {
        private IPostService _service;

        public PostController()
        {
            _service = new PostService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get(int id)
        {
            return Json(_service.Get(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult All()
        {
            return Json(_service.All(), JsonRequestBehavior.AllowGet);
        }
    }
}
