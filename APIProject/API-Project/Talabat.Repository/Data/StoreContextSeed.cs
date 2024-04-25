using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entites;

namespace Talabat.Repository.Data
{
    public static class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext storeContext)
        {

            if (!storeContext.ProductBrands.Any())
            {
                var BrandsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/brands.json");
                var Brands = JsonSerializer.Deserialize<List<ProductBrand>>(BrandsData);

                if (Brands is null)
                    return;

                foreach (var Brand in Brands)
                    await storeContext.Set<ProductBrand>().AddAsync(Brand);
                await storeContext.SaveChangesAsync();
            }

            //========================================

            if (!storeContext.ProductTypes.Any())
            {
                var TypesData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/types.json");
                var Types = JsonSerializer.Deserialize<List<ProductType>>(TypesData);

                if (Types is null)
                    return;

                foreach (var Type in Types)
                    await storeContext.Set<ProductType>().AddAsync(Type);
                await storeContext.SaveChangesAsync();
            }

            //==========================================


            if (!storeContext.Products.Any())
            {
                var ProductsData = File.ReadAllText("../Talabat.Repository/Data/DataSeed/products.json");
                var Products = JsonSerializer.Deserialize<List<Product>>(ProductsData);

                if (Products is null)
                    return;

                foreach (var Product in Products)
                    await storeContext.Set<Product>().AddAsync(Product);
                await storeContext.SaveChangesAsync();

            }
        }
    }
}
