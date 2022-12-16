using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface IProductService
    {
        List<Product> GetProductList(Expression<Func<Product, bool>> filter = null);
        List<Product> GetListByString(string name);
        Product GetOneProduct(int id);
        Product AddProduct(ProductDto productDto);
     
        
        Product UpdateProduct(Product product, int id);
        void DeleteProduct(int id);
        List<Product> GetLastProduct();
        List<Product> PopularProductList();
        Product GetOneProductWithDetail(int id);
        List<Product> ProductBrand(int id);

        List<Product> GetAllProductWithDetailList();
    }
}
