// <copyright file="TipoDevolucionControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para TipoDevolucionController</summary>
    [PexClass(typeof(TipoDevolucionController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TipoDevolucionControllerTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public TipoDevolucionController ConstructorTest()
        {
            TipoDevolucionController target = new TipoDevolucionController();
            return target;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]TipoDevolucionController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.CreateTest(TipoDevolucionController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbTipoDevolucion)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]TipoDevolucionController target,
            tbTipoDevolucion tbTipoDevolucion
        )
        {
            ActionResult result = target.Create(tbTipoDevolucion);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.CreateTest01(TipoDevolucionController, tbTipoDevolucion)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]TipoDevolucionController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.DeleteConfirmedTest(TipoDevolucionController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]TipoDevolucionController target,
            int? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.DeleteTest(TipoDevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]TipoDevolucionController target,
            int? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.DetailsTest(TipoDevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]TipoDevolucionController target,
            int? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.EditTest(TipoDevolucionController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;, tbTipoDevolucion)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]TipoDevolucionController target,
            int? id,
            tbTipoDevolucion tbTipoDevolucion
        )
        {
            ActionResult result = target.Edit(id, tbTipoDevolucion);
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.EditTest01(TipoDevolucionController, Nullable`1<Int32>, tbTipoDevolucion)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]TipoDevolucionController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método TipoDevolucionControllerTest.IndexTest(TipoDevolucionController)
        }
    }
}
