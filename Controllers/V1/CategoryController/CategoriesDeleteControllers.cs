using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Models;
using LostnFound.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LostnFound.Controllers.V1.CategoryController
{
    [ApiController]
    
    public class CategoriesDeleteController : Base
    {
        public CategoriesDeleteController(IcategoryRepositorY categoryRepositor) : base(categoryRepositor)
        {
        }
        [HttpDelete]
        [Tags("Category")]
        public async Task<ActionResult> Delete(uint id)
        {

            var CategoryToelete = await _Services.GetById(id);
            if (CategoryToelete == null)
            {
                return NotFound("categoria no encontrado");
            }
            await _Services.Delete(id);
            return NoContent();

        }

    }

}