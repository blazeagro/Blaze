using System;
using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using Blaze.Services.User.WebApi.Handlers;
using Blaze.Services.User.WebApi.Results;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blaze.Services.User.WebApi.Test.Handlers
{
    [TestClass]
    public class GlobalExceptionHandlerTest
    {
        [TestMethod]
        public void GlobalExceptionHandler_Handle()
        {
            var handler = new GlobalExceptionHandler();
            var context = new ExceptionHandlerContext(new ExceptionContext(new Exception(), new ExceptionContextCatchBlock("Test", true, true), new HttpRequestMessage()));

            handler.Handle(context);

            ((TextPlainErrorResult)context.Result).Content.Should().NotBeEmpty();
        }

        [TestMethod]
        public void GlobalExceptionHandler_ShouldHandle()
        {
            var handler = new GlobalExceptionHandler();
            handler.ShouldHandle(null).Should().Be(true);
        }
    }
}
