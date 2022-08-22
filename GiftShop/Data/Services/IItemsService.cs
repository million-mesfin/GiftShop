using GiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.Services
{
    public interface IItemsService
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> GetById(int id);
        void Add(Item item);
        Item Update(int id, Item newItem);
        Task Delete(int id);
    }
}
