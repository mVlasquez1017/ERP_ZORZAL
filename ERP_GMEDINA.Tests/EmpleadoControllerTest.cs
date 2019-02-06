// <copyright file="EmpleadoControllerTest.cs">Copyright ©  2014</copyright>
using System;
using System.Web.Mvc;
using ERP_GMEDINA.Controllers;
using ERP_GMEDINA.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Controllers.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para EmpleadoController</summary>
    [PexClass(typeof(EmpleadoController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class EmpleadoControllerTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod(MaxBranches = 320000)]
        public EmpleadoController ConstructorTest()
        {
            EmpleadoController target = new EmpleadoController();
            return target;
            // TODO: agregar aserciones a método EmpleadoControllerTest.ConstructorTest()
        }

        /// <summary>Código auxiliar de prueba para Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]EmpleadoController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.CreateTest(EmpleadoController)
        }

        /// <summary>Código auxiliar de prueba para Create(tbEmpleado)</summary>
        [PexMethod]
        public ActionResult CreateTest01(
            [PexAssumeUnderTest]EmpleadoController target,
            tbEmpleado tbEmpleado
        )
        {
            ActionResult result = target.Create(tbEmpleado);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.CreateTest01(EmpleadoController, tbEmpleado)
        }

        /// <summary>Código auxiliar de prueba para DeleteConfirmed(Int16)</summary>
        [PexMethod]
        public ActionResult DeleteConfirmedTest([PexAssumeUnderTest]EmpleadoController target, short id)
        {
            ActionResult result = target.DeleteConfirmed(id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.DeleteConfirmedTest(EmpleadoController, Int16)
        }

        /// <summary>Código auxiliar de prueba para Delete(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DeleteTest(
            [PexAssumeUnderTest]EmpleadoController target,
            short? id
        )
        {
            ActionResult result = target.Delete(id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.DeleteTest(EmpleadoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Details(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        public ActionResult DetailsTest(
            [PexAssumeUnderTest]EmpleadoController target,
            short? id
        )
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.DetailsTest(EmpleadoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(Nullable`1&lt;Int16&gt;)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(NotImplementedException))]
        public ActionResult EditTest(
            [PexAssumeUnderTest]EmpleadoController target,
            short? id
        )
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.EditTest(EmpleadoController, Nullable`1<Int16>)
        }

        /// <summary>Código auxiliar de prueba para Edit(tbEmpleado)</summary>
        [PexMethod]
        public ActionResult EditTest01(
            [PexAssumeUnderTest]EmpleadoController target,
            tbEmpleado tbEmpleado
        )
        {
            ActionResult result = target.Edit(tbEmpleado);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.EditTest01(EmpleadoController, tbEmpleado)
        }

        /// <summary>Código auxiliar de prueba para EstadoActivar(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public ActionResult EstadoActivarTest(
            [PexAssumeUnderTest]EmpleadoController target,
            int? id
        )
        {
            ActionResult result = target.EstadoActivar(id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.EstadoActivarTest(EmpleadoController, Nullable`1<Int32>)
        }

        /// <summary>Código auxiliar de prueba para EstadoEmpleadoRazon(tbEmpleado)</summary>
        [PexMethod]
        public JsonResult EstadoEmpleadoRazonTest(
            [PexAssumeUnderTest]EmpleadoController target,
            tbEmpleado tbEmpleado
        )
        {
            JsonResult result = target.EstadoEmpleadoRazon(tbEmpleado);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.EstadoEmpleadoRazonTest(EmpleadoController, tbEmpleado)
        }

        /// <summary>Código auxiliar de prueba para GetEmpleadoRazon(Int32)</summary>
        [PexMethod]
        public JsonResult GetEmpleadoRazonTest([PexAssumeUnderTest]EmpleadoController target, int emp_Id)
        {
            JsonResult result = target.GetEmpleadoRazon(emp_Id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.GetEmpleadoRazonTest(EmpleadoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para GetEmpleado(Int32)</summary>
        [PexMethod]
        public JsonResult GetEmpleadoTest([PexAssumeUnderTest]EmpleadoController target, int emp_Id)
        {
            JsonResult result = target.GetEmpleado(emp_Id);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.GetEmpleadoTest(EmpleadoController, Int32)
        }

        /// <summary>Código auxiliar de prueba para Index()</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        [PexAllowedException(typeof(NotImplementedException))]
        public ActionResult IndexTest([PexAssumeUnderTest]EmpleadoController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.IndexTest(EmpleadoController)
        }

        /// <summary>Código auxiliar de prueba para RazonSalida(tbEmpleado)</summary>
        [PexMethod]
        public JsonResult RazonSalidaTest(
            [PexAssumeUnderTest]EmpleadoController target,
            tbEmpleado tbEmpleado
        )
        {
            JsonResult result = target.RazonSalida(tbEmpleado);
            return result;
            // TODO: agregar aserciones a método EmpleadoControllerTest.RazonSalidaTest(EmpleadoController, tbEmpleado)
        }
    }
}
