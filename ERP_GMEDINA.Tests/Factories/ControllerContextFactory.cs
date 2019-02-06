using System.Web.Mvc;
using System;
using Microsoft.Pex.Framework;

namespace System.Web.Mvc
{
    /// <summary>A factory for System.Web.Mvc.ControllerContext+EmptyHttpContext instances</summary>
    public static partial class ControllerContextFactory
    {
        /// <summary>A factory for System.Web.Mvc.ControllerContext+EmptyHttpContext instances</summary>
        [PexFactoryMethod(typeof(IView), "System.Web.Mvc.ControllerContext+EmptyHttpContext")]
        public static object CreateEmptyHttpContext()
        {
            throw new NotImplementedException();

            // TODO: Edit factory method of EmptyHttpContext
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
