using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_GMEDINA.Controllers
{
    /// <summary>A factory for ERP_GMEDINA.Controllers.BodegaController instances</summary>
    public static partial class BodegaControllerFactory
    {
        /// <summary>A factory for ERP_GMEDINA.Controllers.BodegaController instances</summary>
        [PexFactoryMethod(typeof(BodegaController))]
        public static BodegaController Create(
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
            BodegaController bodegaController = new BodegaController();
            ((Controller)bodegaController).Resolver = value_iDependencyResolver;
            ((Controller)bodegaController).ActionInvoker = value_iActionInvoker;
            ((Controller)bodegaController).TempDataProvider = value_iTempDataProvider;
            ((Controller)bodegaController).Url = value_urlHelper;
            ((Controller)bodegaController).ViewEngineCollection = value_viewEngineCollection;
            ((ControllerBase)bodegaController).ControllerContext = value_controllerContext;
            ((ControllerBase)bodegaController).TempData = value_tempDataDictionary;
            ((ControllerBase)bodegaController).ValidateRequest = value_b;
            ((ControllerBase)bodegaController).ValueProvider = value_iValueProvider;
            ((ControllerBase)bodegaController).ViewData = value_viewDataDictionary;
            return bodegaController;

            // TODO: Edit factory method of BodegaController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
