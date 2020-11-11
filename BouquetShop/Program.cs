using System;

namespace BouquetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BouquetStorage storage = new BouquetListStorage();
            storage.AddBouquet(new Bouquet("Wedding", 35.0, "Wedding bouquet"));
            storage.AddBouquet(new Bouquet("BirthDay", 25.0, "Birthday bouquet"));
            storage.AddBouquet(new Bouquet("Spring", 15.0, "Spring bouquet"));
            storage.AddBouquet(new Bouquet("Blooming", 18.0, "Blooming bouquet"));
            storage.AddBouquet(new Bouquet("Roses", 30.0, "Roses bouquet"));
            storage.AddBouquet(new Bouquet("Lady", 35.0, "Lady bouquet")); 


            Console.WriteLine("Welcome to our Flower Shop!!!");
            Console.WriteLine("-----------------------------");            
            ActionExecutor showBouquets = new ShowBoquestsAction(storage);
            showBouquets.execute();
        }
    }
}
