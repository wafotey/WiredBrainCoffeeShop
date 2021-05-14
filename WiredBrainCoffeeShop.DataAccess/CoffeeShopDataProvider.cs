using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffeeShop.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShop()
        {
            yield return new CoffeeShop { Location = "Accra", BeansInStockInKg = "400kg" };
            yield return new CoffeeShop { Location = "Nungua", BeansInStockInKg = "450kg" };
            yield return new CoffeeShop { Location = "Tema", BeansInStockInKg = "450kg" };
        }
    }
}
