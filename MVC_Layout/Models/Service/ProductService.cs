using MVC_Layout.Models.Data;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Layout.Models.Service
{
    public class ProductService : IProduct
    {
        DatabaseContext db = new DatabaseContext();

        public string CreateProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return "Success!";
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
