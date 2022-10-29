using Entities.Models;
using Repositories.Contracts;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Entities.Exceptions.NotFoundException;

namespace Services.Manager
{
    public class ProductDetailManager : IProductDetailService
    {
        private readonly IProductDetailRepository repository;

        public ProductDetails GetOneProductDetails(int productId)
        {
            var detail = repository.GetOne(x => x.ProductId == productId);
            if (detail is null)
            {
                throw new ProductDetailsNotFoundException(productId);
            }
            return detail;

        }




        public List<ProductDetails> GetProductDetailsList(Expression<Func<ProductDetails, bool>> filter = null)
        {
            return repository.GetList(filter).ToList();
        }
    }
}
