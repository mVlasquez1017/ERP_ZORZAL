using System.Threading.Tasks;
using ERP_GMEDINA.Models;
using System.Web.Mvc;
using System;
using ERP_ZORZAL.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_ZORZAL.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para EntradaController</summary>
    [TestClass]
    [PexClass(typeof(EntradaController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EntradaControllerTest
    {

        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public EntradaController ConstructorTest()
        {
            EntradaController target = new EntradaController();
            return target;

            // TODO: agregar aserciones a método EntradaControllerTest.ConstructorTest()
        }

      

 

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public Task<ActionResult> DetailsTest([PexAssumeUnderTest]EntradaController target, int? id)
        {
            Task<ActionResult> result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método EntradaControllerTest.DetailsTest(EntradaController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]EntradaController target, int? id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método EntradaControllerTest.EditTest(EntradaController, Nullable`1<Int32>)
        }
    }
}
