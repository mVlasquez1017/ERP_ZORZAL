using System.Web.Routing;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ObjetoControllerTest.EstadoactivarTest.g.cs">Copyright ©  2014</copyright>
// <auto-generated>
// Este archivo contiene pruebas generadas automáticamente.
// No modifique el archivo manualmente.
// 
// Si el contenido del archivo se queda obsoleto, puede eliminarlo.
// Por ejemplo, si ya no se compila.
// </auto-generated>
using System;

namespace ERP_ZORZAL.Controllers.Tests
{
    public partial class ObjetoControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ObjetoControllerTest))]
public void EstadoactivarTest29901()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ObjetoController objetoController;
      ActionResult actionResult;
      objetoController = ObjetoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              (ControllerContext)null, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)objetoController);
      actionResult = this.EstadoactivarTest(objetoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)objetoController);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)objetoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)objetoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)objetoController).Url);
      Assert.IsNull(((ControllerBase)objetoController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)objetoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ObjetoControllerTest))]
public void EstadoactivarTest80903()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ObjetoController objetoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = (RouteData)null;
      objetoController = ObjetoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              s0, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)objetoController);
      actionResult = this.EstadoactivarTest(objetoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)objetoController);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)objetoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)objetoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)objetoController).Url);
      Assert.IsNotNull(((ControllerBase)objetoController).ControllerContext);
      Assert.IsNull(((ControllerBase)objetoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)objetoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ObjetoControllerTest))]
public void EstadoactivarTest80904()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ObjetoController objetoController;
      ActionResult actionResult;
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      RequestContext s1 = new RequestContext();
      s1.HttpContext = (HttpContextBase)null;
      s1.RouteData = (RouteData)null;
      s0.RequestContext = s1;
      s0.RouteData = (RouteData)null;
      objetoController = ObjetoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              s0, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)objetoController);
      actionResult = this.EstadoactivarTest(objetoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)objetoController);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)objetoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)objetoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)objetoController).Url);
      Assert.IsNotNull(((ControllerBase)objetoController).ControllerContext);
      Assert.IsNull(((ControllerBase)objetoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)objetoController).ValidateRequest);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(ObjetoControllerTest))]
public void EstadoactivarTest80905()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      RouteData routeData;
      ObjetoController objetoController;
      ActionResult actionResult;
      routeData = RouteDataFactory.Create((RouteBase)null, (IRouteHandler)null);
      ControllerContext s0 = new ControllerContext();
      s0.Controller = (ControllerBase)null;
      s0.HttpContext = (HttpContextBase)null;
      s0.RequestContext = (RequestContext)null;
      s0.RouteData = routeData;
      objetoController = ObjetoControllerFactory.Create
                             ((IDependencyResolver)null, (IActionInvoker)null, 
                              (ITempDataProvider)null, (UrlHelper)null, (ViewEngineCollection)null, 
                              s0, (TempDataDictionary)null, 
                              false, (IValueProvider)null, (ViewDataDictionary)null);
      disposables.Add((IDisposable)objetoController);
      actionResult = this.EstadoactivarTest(objetoController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)objetoController);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager);
      Assert.IsNotNull
          (((Controller)objetoController).AsyncManager.OutstandingOperations);
      Assert.IsNotNull(((Controller)objetoController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)objetoController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)objetoController).Url);
      Assert.IsNotNull(((ControllerBase)objetoController).ControllerContext);
      Assert.IsNull(((ControllerBase)objetoController).ControllerContext.Controller);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)objetoController).ValidateRequest);
    }
}
    }
}
