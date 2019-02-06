using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
// <copyright file="EntradaControllerFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.EntradaController instances</summary>
    public static partial class EntradaControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.EntradaController instances</summary>
        [PexFactoryMethod(typeof(EntradaController))]
        public static EntradaController Create(
            IDependencyResolver value_iDependencyResolver,
            IActionInvoker value_iActionInvoker,
            ITempDataProvider value_iTempDataProvider,
            UrlHelper value_urlHelper,
            ViewEngineCollection value_viewEngineCollection,
            ControllerContext value_controllerContext,
            TempDataDictionary value_tempDataDictionary,
            bool value_b,
            IValueProvider value_iValueProvider,
            ViewDataDictionary value_viewDataDictionary
        )
        {
            EntradaController entradaController = new EntradaController();
            ((Controller)entradaController).Resolver = value_iDependencyResolver;
            ((Controller)entradaController).ActionInvoker = value_iActionInvoker;
            ((Controller)entradaController).TempDataProvider = value_iTempDataProvider;
            ((Controller)entradaController).Url = value_urlHelper;
            ((Controller)entradaController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)entradaController).ControllerContext = value_controllerContext;
            ((ControllerBase)entradaController).TempData = value_tempDataDictionary;
            ((ControllerBase)entradaController).ValidateRequest = value_b;
            ((ControllerBase)entradaController).ValueProvider = value_iValueProvider;
            ((ControllerBase)entradaController).ViewData = value_viewDataDictionary;
            return entradaController;

            // TODO: Edit factory method of EntradaController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
