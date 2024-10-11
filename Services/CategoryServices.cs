using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostnFound.Data;
using LostnFound.Dto.Request;
using LostnFound.Models;
using LostnFound.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LostnFound.Services
{
    public class CategoryServices : IcategoryRepositorY
    {
        private readonly ClassDbContext _Context;

        public CategoryServices(ClassDbContext _context)
        {
            _Context = _context;
        }
        public async Task Create(DtoCategoryRegister newCreate)
        {
            Category NewCategory = new Category
            {
                Name = newCreate.Name,
                Description = newCreate.Description
            };

            try
            {
                _Context.Categories.Add(NewCategory);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException DbuEx)
            {
                throw new Exception("Error al agregar la categoria a la base de datos.", DbuEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar la categoria.", ex);
            }
        }

        public async Task<Category> Delete(uint Id)
        {
            var CategoryToelete = await GetById(Id);
            if (CategoryToelete != null)
            {
                _Context.Categories.Remove(CategoryToelete);
                await _Context.SaveChangesAsync();
                return CategoryToelete;
            }
            return null;

        }

        public async Task<IEnumerable<Category>> Getall()
        {
            return await _Context.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Category> GetById(uint Id)
        {
            Category CategoryById = null;
            if (Id > _Context.Categories.Count())
            {
                return null;
            }


            CategoryById = await _Context.Categories.FindAsync(Id);


            if (CategoryById == null)
            {
                return null;
            }
            return CategoryById;
        }

        public async Task Update(Category UpdatedCategory)
        {
            var ProductFound = await _Context.Categories.FindAsync(UpdatedCategory.Id) ?? throw new KeyNotFoundException("Movement not found");

            ProductFound.Name = UpdatedCategory.Name;
            ProductFound.Description = UpdatedCategory.Description;


            try
            {
                _Context.Categories.Update(ProductFound);
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar  el cliente en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el cliente.", ex);
            }
        }
    }
}