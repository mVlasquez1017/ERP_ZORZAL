using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
// <copyright file="ObjetoControllerFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace ERP_ZORZAL.Controllers
{
    /// <summary>A factory for ERP_ZORZAL.Controllers.ObjetoController instances</summary>
    public static partial class ObjetoControllerFactory
    {
        /// <summary>A factory for ERP_ZORZAL.Controllers.ObjetoController instances</summary>
        [PexFactoryMethod(typeof(ObjetoController))]
        public static ObjetoController Create(
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
            ObjetoController objetoController = new ObjetoController();
            ((Controller)objetoController).Resolver = value_iDependencyResolver;
            ((Controller)objetoController).ActionInvoker = value_iActionInvoker;
            ((Controller)objetoController).TempDataProvider = value_iTempDataProvider;
            ((Controller)objetoController).Url = value_urlHelper;
            ((Controller)objetoController).ViewEngineCollection = value_viewEngineCollection;
            ((ControllerBase)objetoController).ControllerContext = value_controllerContext;
            ((ControllerBase)objetoController).TempData = value_tempDataDictionary;
            ((ControllerBase)objetoController).ValidateRequest = value_b;
            ((ControllerBase)objetoController).ValueProvider = value_iValueProvider;
            ((ControllerBase)objetoController).ViewData = value_viewDataDictionary;
            return objetoController;

            // TODO: Edit factory method of ObjetoController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
