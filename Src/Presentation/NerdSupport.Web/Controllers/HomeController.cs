using System.Web.Mvc;
using NerdSupport.Domain.Factories;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Infrastructure.Bus;
using Nerdsupport.Presentation.ViewModels;

namespace NerdSupport.Presentation.Web.Controllers
{
    public class HomeController : BaseController
    {
        #region ctor
        private readonly FrageKo _frageKo;

        public HomeController(IFactory<FrageKo> frageKoFactory, IRepository<Nord> nordRepo, IMessageBus messageBus)
            : base(messageBus, nordRepo)
        {
            _frageKo = frageKoFactory.Skapa();
        }

        #endregion

        [AutoMapFilter(typeof(Fraga), typeof(ShowFraga))]
        public ActionResult Index()
        {
            return View(_frageKo.HamtaNastaFraga());
        }

        public ActionResult Svara(int fragaId, string svar, long nordId)
        {
            Publish(new SvaraPaFragaCommand
                        {
                            FragaId = fragaId,
                            Svar = svar,
                            NordId = nordId
                        });

            return RedirectToAction("Index"); 
        }
    }
}