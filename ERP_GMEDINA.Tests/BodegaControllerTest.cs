using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_GMEDINA.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para BodegaController</summary>
    [TestClass]
    [PexClass(typeof(BodegaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BodegaControllerTest
    {

        /// <summary>Código auxiliar de prueba para Create(tbBodega)</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]BodegaController target, tbBodega tbBodega)
        {
            ActionResult result = target.Create(tbBodega);
            return result;
            // TODO: agregar aserciones a método BodegaControllerTest.CreateTest(BodegaController, tbBodega)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;, tbBodega)</summary>
        [PexMethod]
        public ActionResult EditTest(
            [PexAssumeUnderTest]BodegaController target,
            int? id,
            tbBodega tbBodega
        )
        {
            ActionResult result = target.Edit(id, tbBodega);
            return result;
            // TODO: agregar aserciones a método BodegaControllerTest.EditTest(BodegaController, Nullable`1<Int32>, tbBodega)
        }

        /// <summary>Código auxiliar de prueba para EstadoInactivar(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EstadoInactivarTest([PexAssumeUnderTest]BodegaController target, int? id)
        {
            ActionResult result = target.EstadoInactivar(id);
            return result;
            // TODO: agregar aserciones a método BodegaControllerTest.EstadoInactivarTest(BodegaController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Estadoactivar(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EstadoactivarTest([PexAssumeUnderTest]BodegaController target, int? id)
        {
            ActionResult result = target.Estadoactivar(id);
            return result;
            // TODO: agregar aserciones a método BodegaControllerTest.EstadoactivarTest(BodegaController, Nullable`1<Int32>)
        }
    }
}
