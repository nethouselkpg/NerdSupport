using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdSupport.Infrastructure.Repositories;
using NerdSupport.Domain.Model;

namespace NerdSupport.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Arende> _arendeRepository;
        public HomeController(IRepository<Arende> arendeRepository)
        {
            _arendeRepository = arendeRepository;
        }

        public ActionResult Index()
        {
            var arende = _arendeRepository.GetAll();
            return View(arende); 
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }


    }
}
