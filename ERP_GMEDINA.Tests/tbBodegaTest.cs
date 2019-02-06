// <copyright file="tbBodegaTest.cs">Copyright ©  2014</copyright>
using System;
using ERP_GMEDINA.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP_GMEDINA.Models.Tests
{
    /// <summary>Esta clase contiene pruebas unitarias parametrizadas para tbBodega</summary>
    [PexClass(typeof(tbBodega))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class tbBodegaTest
    {
        /// <summary>Código auxiliar de prueba para .ctor()</summary>
        [PexMethod]
        public tbBodega ConstructorTest()
        {
            tbBodega target = new tbBodega();
            return target;
            // TODO: agregar aserciones a método tbBodegaTest.ConstructorTest()
        }
    }
}
