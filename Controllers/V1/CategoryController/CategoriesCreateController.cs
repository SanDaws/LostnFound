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
    public class CategoriesCreateController : Base
    {
        public CategoriesCreateController(IcategoryRepositorY categoryRepositor) : base(categoryRepositor)
        {
        }
        [HttpPost]
        public async Task<ActionResult> Create(DtoCategoryRegister newCreate){
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }
            await _Services.Create(newCreate);
            return Ok("categoria Creada exitosamente");


        }
    }
}