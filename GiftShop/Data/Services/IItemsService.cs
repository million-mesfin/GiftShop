using GiftShop.Data.Base;
using GiftShop.Data.ViewModels;
using GiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.Services
{
    public interface IItemsService : IEntityBaseRepository<Item>
    {
        Task<Item> GetItemById(int id);
        Task<NewItemDropdownVM> GetDropDownValues();
    }
}
