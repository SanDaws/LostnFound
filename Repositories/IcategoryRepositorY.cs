using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Dto.Request;
using LostnFound.Migrations;
using LostnFound.Models;

namespace LostnFound.Repositories
{
    public interface IcategoryRepositorY
    {
     public Task<IEnumerable<Category>> Getall();
     public Task<Category>GetById(uint Id);
     public Task Create(DtoCategoryRegister newCreate);   
     public Task Update(Category UpdatedCategory);
     public Task<Category> Delete(uint Id);
    }

}