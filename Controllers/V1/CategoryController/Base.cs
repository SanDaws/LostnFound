using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LostnFound.Controllers.V1.CategoryController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class Base : ControllerBase
    {
        protected readonly IcategoryRepositorY _Services;

        public Base(IcategoryRepositorY categoryRepositor)
        {
            _Services=categoryRepositor;
        }
    }
}