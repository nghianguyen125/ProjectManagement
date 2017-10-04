using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagement.Astract;
using ProjectManagement.Entities;

namespace ProjectManagement.Controllers
{
    public class ThesisController : Controller
    {
        // GET: Thesis
        private IThesisRepository thesisRepository { get; set; }

        public ThesisController(IThesisRepository thesisRepoPara)
        {
            thesisRepository = thesisRepoPara;
        }

        public ActionResult Index()
        {
            return View();
        }

        // Hiển thị đề tài theo ID
        public ViewResult DeTai(string deTaiId)
        {
            DeTai deTai = thesisRepository
                .DeTai
                .FirstOrDefault(x => x.DeTaiId == deTaiId);
            return View(deTai);
        }
    }
}