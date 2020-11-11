

using System.Collections.Generic;
namespace BouquetShop
{
    public interface BouquetStorage
    {
        void AddBouquet(Bouquet bouquet);

        void AddBouquets(ICollection<Bouquet> bouquets);

        Bouquet FindByName(string bouquetName);

        void RemoveBouquet(Bouquet bouquet);

        ICollection<Bouquet> GetAll(int fromIndex, int limit);

        ICollection<Bouquet> GetAll();
    }
}