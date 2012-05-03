using System.Web.Mvc;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Infrastructure.Bus;

namespace NerdSupport.Presentation.Web.Controllers
{
    public class BaseController : Controller
    {
        #region privateFields

        private readonly Nord _currentNord;
        private readonly IMessageBus _messageBus;
        private readonly IRepository<Nord> _nordRepo;

        #endregion

        public BaseController(IMessageBus messageBus, IRepository<Nord> nordRepo)
        {
            _messageBus = messageBus;
            _nordRepo = nordRepo;

            _currentNord = _nordRepo.GetById(1);
        }

        public void Publish<T>(T command)
        {
            _messageBus.Publish(command);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.Planboken = _currentNord.Plånbok;
            base.OnActionExecuted(filterContext);
        }
    }
}