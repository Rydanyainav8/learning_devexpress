using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace learning_devexpress.Data
{
    public class ProductDataService
    {
        List<Product> prodList = new List<Product>()
        {
            new Product() { ProductId = 1, ProductName = "Avocat", ProdQty = 8, Price=20000},
            new Product() { ProductId = 2, ProductName = "Anana", ProdQty = 9, Price=20000},
            new Product() { ProductId = 3, ProductName = "Banane", ProdQty = 8, Price=20000},
            new Product() { ProductId = 4, ProductName = "Corosolle", ProdQty = 2, Price=20000},
            new Product() { ProductId = 5, ProductName = "Dinosaure", ProdQty = 3, Price=20000},
            new Product() { ProductId = 6, ProductName = "Eiffel", ProdQty = 4, Price=20000},
            new Product() { ProductId = 7, ProductName = "France", ProdQty = 7, Price=20000},
            new Product() { ProductId = 8, ProductName = "Garage", ProdQty = 3, Price=20000},
            new Product() { ProductId = 9, ProductName = "Helicoptere", ProdQty = 1, Price=20000},
            new Product() { ProductId = 10, ProductName = "Illinois", ProdQty = 18, Price=20000},
            new Product() { ProductId = 11, ProductName = "Jamaic", ProdQty = 3, Price=20000},
            new Product() { ProductId = 12, ProductName = "Kayac", ProdQty = 8, Price=20000},
            new Product() { ProductId = 13, ProductName = "Lenon", ProdQty = 4, Price=20000},
            new Product() { ProductId = 14, ProductName = "Manioc", ProdQty = 2, Price=20000},
            new Product() { ProductId = 15, ProductName = "Naerobi", ProdQty = 1, Price=20000},
            new Product() { ProductId = 16, ProductName = "Nomenclature", ProdQty = 6, Price=20000},
            new Product() { ProductId = 17, ProductName = "Brazzers", ProdQty = 3, Price=20000},
            new Product() { ProductId = 18, ProductName = "Xenophobe", ProdQty = 9, Price=20000},
            new Product() { ProductId = 19, ProductName = "Yogoslavie", ProdQty = 12, Price=20000},
            new Product() { ProductId = 20, ProductName = "Urican", ProdQty = 25, Price=20000},
            new Product() { ProductId = 21, ProductName = "Oklahoma", ProdQty = 53, Price=20000},
            new Product() { ProductId = 22, ProductName = "Frein", ProdQty = 20, Price=20000},
            new Product() { ProductId = 23, ProductName = "Wagon", ProdQty = 35, Price=20000},

        };

        public async Task<IEnumerable<Product>> ProductList(CancellationToken ct=default)
        {
            return await Task.FromResult(prodList);
        }

        public Task<Product[]> Insert(IDictionary<string, object> newValue)
        {
            return Task.FromResult(InsertProduct(newValue));
        }

        Product[] InsertProduct(IDictionary<string, object> newValue)
        {
            var dataItem = new Product();
            Update(dataItem, newValue);
            prodList.Insert(0, dataItem);
            return prodList.ToArray();
        }

        public Task<Product[]> Update(Product dataItem, IDictionary<string, object> newValue)
        {
            return Task.FromResult(UpdateProduct(dataItem, newValue));
        }

        Product[] UpdateProduct(Product dataItem, IDictionary<string, object> newValue)
        {
            foreach(var field in newValue.Keys)
            {
                switch(field)
                {
                    case nameof(dataItem.ProductId):
                        dataItem.ProductId = Convert.ToInt32(newValue[field]); 
                        break;
                    case nameof(dataItem.ProductName):
                        dataItem.ProductName = (string)newValue[field];
                        break;
                    case nameof(dataItem.ProdQty):
                        dataItem.ProdQty = Convert.ToDouble(newValue[field]);
                        break;
                    case nameof(dataItem.Price):
                        dataItem.Price = Convert.ToDouble(newValue[field]); 
                        break;
                }
            }
            return prodList.ToArray();
        }

        public Task<Product[]> Remove(Product dataItem)
        {
            prodList.Remove(dataItem);
            var data = prodList.ToArray();
            return Task.FromResult(data);   
        }
    }
}
