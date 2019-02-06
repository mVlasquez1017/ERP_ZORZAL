// <copyright file="ProductoCategoriaControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para ProductoCategoriaController</summary>
    [PexClass(typeof(ProductoCategoriaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductoCategoriaControllerTest
    {
        /// <summary>Código auxiliar de prueba para Create(tbProductoCategoria)</summary>
        [PexMethod]
        public ActionResult CreateTest(
            [PexAssumeUnderTest]ProductoCategoriaController target,
            tbProductoCategoria tbProductoCategoria
        )
        {
            ActionResult result = target.Create(tbProductoCategoria);
            return result;
            // TODO: agregar aserciones a método ProductoCategoriaControllerTest.CreateTest(ProductoCategoriaController, tbProductoCategoria)
        }
    }
}
