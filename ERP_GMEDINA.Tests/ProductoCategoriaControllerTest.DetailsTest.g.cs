using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework.Generated;
// <copyright file="ProductoCategoriaControllerTest.DetailsTest.g.cs">Copyright ©  2014</copyright>
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
    public partial class ProductoCategoriaControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ProductoCategoriaControllerTest))]
public void DetailsTest158()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      ProductoCategoriaController productoCategoriaController;
      ActionResult actionResult;
      productoCategoriaController = new ProductoCategoriaController();
      ((Controller)productoCategoriaController).Resolver = (IDependencyResolver)null;
      ((Controller)productoCategoriaController).ActionInvoker = (IActionInvoker)null;
      ((Controller)productoCategoriaController).TempDataProvider =
        (ITempDataProvider)null;
      ((Controller)productoCategoriaController).Url = (UrlHelper)null;
      ((Controller)productoCategoriaController).ViewEngineCollection =
        (ViewEngineCollection)null;
      ((ControllerBase)productoCategoriaController).ControllerContext =
        (ControllerContext)null;
      ((ControllerBase)productoCategoriaController).TempData =
        (TempDataDictionary)null;
      ((ControllerBase)productoCategoriaController).ValidateRequest = false;
      ((ControllerBase)productoCategoriaController).ValueProvider =
        (IValueProvider)null;
      ((ControllerBase)productoCategoriaController).ViewData =
        (ViewDataDictionary)null;
      disposables.Add((IDisposable)productoCategoriaController);
      actionResult = this.DetailsTest(productoCategoriaController, default(int?));
      disposables.Dispose();
      Assert.IsNotNull((object)productoCategoriaController);
      Assert.IsNotNull(((Controller)productoCategoriaController).AsyncManager);
      Assert.IsNotNull(((Controller)productoCategoriaController).AsyncManager
                         .OutstandingOperations);
      Assert.IsNotNull
          (((Controller)productoCategoriaController).AsyncManager.Parameters);
      Assert.AreEqual<int>
          (45000, ((Controller)productoCategoriaController).AsyncManager.Timeout);
      Assert.IsNull(((Controller)productoCategoriaController).Url);
      Assert.IsNull(((ControllerBase)productoCategoriaController).ControllerContext);
      Assert.AreEqual<bool>
          (false, ((ControllerBase)productoCategoriaController).ValidateRequest);
    }
}
    }
}
