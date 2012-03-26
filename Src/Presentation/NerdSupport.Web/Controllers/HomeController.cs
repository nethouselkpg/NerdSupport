using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Domain.Factories;
using Nerdsupport.Presentation.ViewModels;

namespace NerdSupport.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly FrageKo _frageKo;
 
        public HomeController(IFactory<FrageKo> frageKoFactory)
        {
            _frageKo = frageKoFactory.Skapa();
        }

        [AutoMapFilter(typeof(Fraga), typeof(ShowFraga))]
        public ActionResult Index()
        {
            return View(_frageKo.HamtaNastaFraga());
        }



    }
}
