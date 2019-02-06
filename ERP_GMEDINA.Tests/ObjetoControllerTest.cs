// <copyright file="ObjetoControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Models;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para ObjetoController</summary>
    [PexClass(typeof(ObjetoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ObjetoControllerTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public ObjetoController ConstructorTest()
        {
            ObjetoController target = new ObjetoController();
            return target;
            // TODO: agregar aserciones a método ObjetoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]ObjetoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.CreateTest(ObjetoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbObjeto)</summary>
        [PexMethod]
        public ActionResult CreateTest01([PexAssumeUnderTest]ObjetoController target, tbObjeto tbObjeto)
        {
            ActionResult result = target.Create(tbObjeto);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.CreateTest01(ObjetoController, tbObjeto)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int32)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]ObjetoController target, int id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.DeleteConfirmedTest(ObjetoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]ObjetoController target,
            int? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.DeleteTest(ObjetoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]ObjetoController target,
            int? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.DetailsTest(ObjetoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]ObjetoController target,
            int? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.EditTest(ObjetoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;, tbObjeto)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]ObjetoController target,
            int? id,
            tbObjeto tbObjeto
        )
        {
            ActionResult result = target.Edit(id, tbObjeto);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.EditTest01(ObjetoController, Nullable`1<Int32>, tbObjeto)
        }

        /// <summary>Código auxiliar de prueba para EstadoInactivar(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EstadoInactivarTest(
            [PexAssumeUnderTest]ObjetoController target,
            int? id
        )
        {
            ActionResult result = target.EstadoInactivar(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.EstadoInactivarTest(ObjetoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Estadoactivar(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EstadoactivarTest(
            [PexAssumeUnderTest]ObjetoController target,
            int? id
        )
        {
            ActionResult result = target.Estadoactivar(id);
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.EstadoactivarTest(ObjetoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]ObjetoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método ObjetoControllerTest.IndexTest(ObjetoController)
        }
    }
}
