using GiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.Services
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Category>> GetAll();
        Category GetById(int id);
        void Add(Category category);
        Category Update(int id, Category newCategory);
        void Delete(int id);
    }
}
