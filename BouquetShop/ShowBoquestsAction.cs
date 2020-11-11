using System;
using System.Collections.Generic;
namespace BouquetShop
{
    public class ShowBoquestsAction : ActionExecutor
    {

        private BouquetStorage storage;

        public ShowBoquestsAction(BouquetStorage storage) 
        {
            this.storage = storage;
        }

        public void execute() 
        {
            ICollection<Bouquet> boquets = this.storage.GetAll();
            foreach (var bouquet in boquets)
            {
                Console.WriteLine($"{bouquet.name} - {bouquet.price} dollars");
            }
        }
    }
}