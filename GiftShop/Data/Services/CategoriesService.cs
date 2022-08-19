using GiftShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly AppDbContext _context;
        public CategoriesService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var result = await _context.Categories.ToListAsync();
            return result;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(int id, Category newCategory)
        {
            throw new NotImplementedException();
        }
    }
}
