using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.TipoEntradaController instances</summary>
    public static partial class TipoEntradaControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.TipoEntradaController instances</summary>
        [PexFactoryMethod(typeof(TipoEntradaController))]
        public static TipoEntradaController Create(
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
            TipoEntradaController tipoEntradaController = new TipoEntradaController();
            ((Controller)tipoEntradaController).Resolver = value_iDependencyResolver;
            ((Controller)tipoEntradaController).ActionInvoker = value_iActionInvoker;
            ((Controller)tipoEntradaController).TempDataProvider = value_iTempDataProvider;
            ((Controller)tipoEntradaController).Url = value_urlHelper;
            ((Controller)tipoEntradaController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)tipoEntradaController).ControllerContext =
              value_controllerContext;
            ((ControllerBase)tipoEntradaController).TempData = value_tempDataDictionary;
            ((ControllerBase)tipoEntradaController).ValidateRequest = value_b;
            ((ControllerBase)tipoEntradaController).ValueProvider = value_iValueProvider;
            ((ControllerBase)tipoEntradaController).ViewData = value_viewDataDictionary;
            return tipoEntradaController;

            // TODO: Edit factory method of TipoEntradaController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
