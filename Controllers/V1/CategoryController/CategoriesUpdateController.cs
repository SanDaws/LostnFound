using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Dto.Request;
using LostnFound.Models;
using LostnFound.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LostnFound.Controllers.V1.CategoryController
{
    [ApiController]
    [Tags("Category")]
    public class CategoriesUpdateController : Base
    {
        public CategoriesUpdateController(IcategoryRepositorY categoryRepositor) : base(categoryRepositor)
        {
        }
        [HttpPut]
        public async Task<ActionResult> Update(Category cat){
            await _Services.Update(cat);
            return Ok("producto actualizado");
        }
    }
}