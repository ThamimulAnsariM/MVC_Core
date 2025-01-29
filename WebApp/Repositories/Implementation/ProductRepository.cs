using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementation
{

    public class ProductRepository : IProductRepository
    {
        private readonly DemoDbContext _context;
        public ProductRepository() 
        {
            _context = new DemoDbContext();
        }

        public bool Add(Product productToAdd)
        {
            try
            {
                _context.Database.BeginTransaction();
                _context.Products.Add(productToAdd);
                var rowsAffected = _context.SaveChanges();
                _context.Database.CommitTransaction();
                return (rowsAffected > 0);
            }
            catch
            {
                _context.Database.RollbackTransaction();
                return false;
            }
          
        }

        public bool Delete(int productID)
        {
            var rowsAffected=_context.Products.Where(d => d.ProductId == productID).ExecuteDelete();
            _context.SaveChanges();
            return (rowsAffected > 0);

        }

        public IEnumerable<Product> GetAll()
        {
            var products=(from prod in _context.Products where prod.ProductId>0 select prod).ToList();
            return products;
        }

        public Product GetProductById(int productID)
        {
            var product = _context.Products.Where(d => d.ProductId == productID).FirstOrDefault();
            return product;
        }

        public bool Update(Product productupdate)
        {
            //var product = _context.Products.Where(d => d.ProductId == productupdate.ProductId)
            //    .ExecuteUpdate(s => s.SetProperty(x => x.ProductCode, productupdate.ProductCode));

            _context.Entry<Product>(productupdate).State = EntityState.Modified;
            _context.SaveChanges();
            return true;

        }
    }
}
