using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstraction
{
    public interface IProductRepository
    {
        bool add(Product productadd);

        bool update(Product productupdate);

        bool delete(int productID);

        IEnumerable<Product> GetAll();

        Product GetProductById(int productID);
    }
}
