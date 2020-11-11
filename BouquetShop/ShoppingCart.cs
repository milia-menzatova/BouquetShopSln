using System.Collections.Generic;
using System;
namespace BouquetShop
{
    public class ShoppingCart
    {
        public Guid Id {get; set;}
        public List<ShoppingCartEntry> Entries { get; set;}
        
    }
}