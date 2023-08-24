using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace learning_devexpress.Data
{
    public class ProductDataService
    {
        List<Product> prodList = new List<Product>()
        {
            new Product() { ProductId = 1, ProductName = "Produit1", ProdQty = 8, Price=20000},
            new Product() { ProductId = 2, ProductName = "Produit12", ProdQty = 9, Price=20000},
            new Product() { ProductId = 3, ProductName = "Produit13", ProdQty = 8, Price=20000},
            new Product() { ProductId = 4, ProductName = "Produit14", ProdQty = 2, Price=20000},
            new Product() { ProductId = 5, ProductName = "Produit15", ProdQty = 3, Price=20000},
            new Product() { ProductId = 6, ProductName = "Produit16", ProdQty = 4, Price=20000},
            new Product() { ProductId = 7, ProductName = "Produit17", ProdQty = 7, Price=20000},
            new Product() { ProductId = 8, ProductName = "Produit18", ProdQty = 3, Price=20000},
            new Product() { ProductId = 9, ProductName = "Produit19", ProdQty = 1, Price=20000},
        };

        public async Task<IEnumerable<Product>> ProductList(CancellationToken ct=default)
        {
            return await Task.FromResult(prodList);
        }
    }
}
