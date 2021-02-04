using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Xunit;

using Nyanpasu.Controllers;
using Nyanpasu.Models;

namespace Nyanpasu.Tests
{
    public class NyanControllerTests
    {
        private readonly NyanController _nyanController;
        public NyanControllerTests()
        {
            this._nyanController = new NyanController();
        }

        [Fact]
        public void GetAllNyans_ReturnsOkResult()
        {
            var response = this._nyanController.GetAllNyans();
            Assert.IsType<OkObjectResult>(response.Result);            
        }

        [Fact]
        public void GetAllNyans_ReturnsAllItems()
        {
            var result = this._nyanController.GetAllNyans().Result as OkObjectResult;

            var items = Assert.IsType<List<Nyan>>(result.Value);
            Assert.NotEmpty(items);
        }
    }
}
