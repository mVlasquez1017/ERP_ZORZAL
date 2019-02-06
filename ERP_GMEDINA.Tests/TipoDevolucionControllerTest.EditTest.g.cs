using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_GMEDINA.Controllers.Tests
{
    public partial class TipoDevolucionControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TipoDevolucionControllerTest))]
public void EditTest407()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoDevolucionController tipoDevolucionController;
      ActionResult actionResult;
      tipoDevolucionController = new TipoDevolucionController();
      ((Controller)tipoDevolucionController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoDevolucionController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoDevolucionController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)tipoDevolucionController).Url = (UrlHelper)null;
      ((Controller)tipoDevolucionController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoDevolucionController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)tipoDevolucionController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoDevolucionController).ValidateRequest = false;
      ((ControllerBase)tipoDevolucionController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)tipoDevolucionController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoDevolucionController);
      actionResult = this.EditTest(tipoDevolucionController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)tipoDevolucionController);
      Assert.IsNotNull(((Controller)tipoDevolucionController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoDevolucionController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoDevolucionController).Url);
      Assert.IsNull(((ControllerBase)tipoDevolucionController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoDevolucionController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoDevolucionControllerTest))]
public void EditTest258()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoDevolucionController tipoDevolucionController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      tipoDevolucionController = new TipoDevolucionController();
      ((Controller)tipoDevolucionController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoDevolucionController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoDevolucionController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)tipoDevolucionController).Url = (UrlHelper)null;
      ((Controller)tipoDevolucionController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoDevolucionController).ControllerContext = s0;
      ((ControllerBase)tipoDevolucionController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoDevolucionController).ValidateRequest = false;
      ((ControllerBase)tipoDevolucionController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)tipoDevolucionController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoDevolucionController);
      actionResult = this.EditTest(tipoDevolucionController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)tipoDevolucionController);
      Assert.IsNotNull(((Controller)tipoDevolucionController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoDevolucionController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoDevolucionController).Url);
      Assert.IsNotNull(((ControllerBase)tipoDevolucionController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoDevolucionController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoDevolucionController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoDevolucionControllerTest))]
public void EditTest25801()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      TipoDevolucionController tipoDevolucionController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      tipoDevolucionController = new TipoDevolucionController();
      ((Controller)tipoDevolucionController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoDevolucionController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoDevolucionController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)tipoDevolucionController).Url = (UrlHelper)null;
      ((Controller)tipoDevolucionController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoDevolucionController).ControllerContext = s0;
      ((ControllerBase)tipoDevolucionController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoDevolucionController).ValidateRequest = false;
      ((ControllerBase)tipoDevolucionController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)tipoDevolucionController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoDevolucionController);
      actionResult = this.EditTest(tipoDevolucionController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)tipoDevolucionController);
      Assert.IsNotNull(((Controller)tipoDevolucionController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoDevolucionController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoDevolucionController).Url);
      Assert.IsNotNull(((ControllerBase)tipoDevolucionController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoDevolucionController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoDevolucionController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TipoDevolucionControllerTest))]
public void EditTest25802()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      TipoDevolucionController tipoDevolucionController;
      ActionResult actionResult;
      routeData = new RouteData((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      tipoDevolucionController = new TipoDevolucionController();
      ((Controller)tipoDevolucionController).Resolver = (IDependencyResolver)null;
      ((Controller)tipoDevolucionController).ActionInvoker = (IActionInvoker)null;
      ((Controller)tipoDevolucionController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)tipoDevolucionController).Url = (UrlHelper)null;
      ((Controller)tipoDevolucionController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)tipoDevolucionController).ControllerContext = s0;
      ((ControllerBase)tipoDevolucionController).TempData = (TempDataDictionary)null;
      ((ControllerBase)tipoDevolucionController).ValidateRequest = false;
      ((ControllerBase)tipoDevolucionController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)tipoDevolucionController).ViewData = (ViewDataDictionary)null;
      disposables.Add((IDisposable)tipoDevolucionController);
      actionResult = this.EditTest(tipoDevolucionController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)tipoDevolucionController);
      Assert.IsNotNull(((Controller)tipoDevolucionController).AsyncManager);
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.OutstandingOperations
          );
      Assert.IsNotNull
          (((Controller)tipoDevolucionController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)tipoDevolucionController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)tipoDevolucionController).Url);
      Assert.IsNotNull(((ControllerBase)tipoDevolucionController).ControllerContext);
      Assert.IsNull
          (((ControllerBase)tipoDevolucionController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)tipoDevolucionController).ValidateRequest);
    }
}
    }
}
