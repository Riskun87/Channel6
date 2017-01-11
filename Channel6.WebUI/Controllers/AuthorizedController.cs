using System;
using Microsoft.Practices.ServiceLocation;
using System.Web.Mvc;

namespace Channel6.WebUI.Controllers
{
    public class AuthorizedController : Controller
    {
        private readonly IServiceLocator serviceLocator;

        public AuthorizedController(IServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator;
        }

        protected T Using<T>() where T : class
        {
            var handler = serviceLocator.GetInstance<T>();
            if (handler == null)
            {
                throw new NullReferenceException("Unable to resolve type with service locator; type " + typeof(T).Name);
            }
            return handler;
        }
    }
}