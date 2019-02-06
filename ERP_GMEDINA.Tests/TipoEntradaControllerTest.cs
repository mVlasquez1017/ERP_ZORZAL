// <copyright file="TipoEntradaControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para TipoEntradaController</summary>
    [PexClass(typeof(TipoEntradaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TipoEntradaControllerTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public TipoEntradaController ConstructorTest()
        {
            TipoEntradaController target = new TipoEntradaController();
            return target;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]TipoEntradaController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.CreateTest(TipoEntradaController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbTipoEntrada)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]TipoEntradaController target,
            tbTipoEntrada tbTipoEntrada
        )
        {
            ActionResult result = target.Create(tbTipoEntrada);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.CreateTest01(TipoEntradaController, tbTipoEntrada)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Byte)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]TipoEntradaController target, byte id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.DeleteConfirmedTest(TipoEntradaController, Byte)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]TipoEntradaController target,
            byte? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.DeleteTest(TipoEntradaController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]TipoEntradaController target,
            byte? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.DetailsTest(TipoEntradaController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Byte&gt;)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(NotImplementedException))]
        public ActionResult EditTest(
            [PexAssumeUnderTest]TipoEntradaController target,
            byte? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.EditTest(TipoEntradaController, Nullable`1<Byte>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Byte&gt;, tbTipoEntrada)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]TipoEntradaController target,
            byte? id,
            tbTipoEntrada tbTipoEntrada
        )
        {
            ActionResult result = target.Edit(id, tbTipoEntrada);
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.EditTest01(TipoEntradaController, Nullable`1<Byte>, tbTipoEntrada)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public ActionResult IndexTest([PexAssumeUnderTest]TipoEntradaController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método TipoEntradaControllerTest.IndexTest(TipoEntradaController)
        }
    }
}
