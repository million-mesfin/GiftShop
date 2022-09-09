using GiftShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftShop.Data.ViewModels
{
    public class NewItemDropdownVM
    {
        public NewItemDropdownVM()
        {
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }
    }
}
