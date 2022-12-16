using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProductRepository : IEntityRepository<Product>
    {
        List<Product> GetLastProduct();
        List<Product> GetAllProductWithDetailList();
        Product GetOneProductWithDetail(int id);
        List<Product> PopularProductList();
        List<Product> ProductBrandList(int id);
    }
}
