using GiftShop.Data.Base;
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
        /*
        Task<IEnumerable<Item>> GetAll();
        Task<IEnumerable<Item>> Filter(int id);
        Task<Item> GetById(int id);
        void Add(Item item);
        Item Update(int id, Item newItem);
        Task Delete(int id);

        */
    }
}
