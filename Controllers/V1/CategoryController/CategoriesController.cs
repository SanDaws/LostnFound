using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using LostnFound.Migrations;
using LostnFound.Models;
using LostnFound.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LostnFound.Controllers.V1.CategoryController;

    [ApiController]
    [Tags("Category")]
    public class CategoriesController : Base
    {
        public CategoriesController(IcategoryRepositorY categoryRepositor) : base(categoryRepositor)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll(){
             IEnumerable<Category> categoryList= await _Services.Getall();
            return Ok(categoryList);
        }


    }
