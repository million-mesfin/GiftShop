using GiftShop.Data.Base;
using GiftShop.Data.ViewModels;
using GiftShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.Services
{
    public class ItemsService : EntityBaseRepository<Item>, IItemsService
    {

        private readonly AppDbContext _context;
        public ItemsService(AppDbContext context) : base (context)
        {
            _context = context;
        }

        public async Task<NewItemDropdownVM> GetDropDownValues()
        {
            var response = new NewItemDropdownVM();
            response.Categories = await _context.Categories.OrderBy(n => n.CategoryName).ToListAsync();
            return response;
        }

        public async Task<Item> GetItemById(int id)
        {
            var itemDetail = await _context.Items.Include(c => c.Category).FirstOrDefaultAsync(n => n.Id == id);
            return itemDetail;
        }
    }
}
