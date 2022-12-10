using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Repositories.EntityFramework
{
    public class EFProductRepository : EFBaseRepository<Product>, IProductRepository
    {
        public EFProductRepository(AppDbContext context) : base(context)
        {

        }

        public List<Product> GetLastProduct()
        {
            return context.Products.OrderByDescending(x => x.ProductId).Take(8).ToList();
        }
        public List<Product> GetAllProductWithDetailList()
        {
            return context.Products.Include(x => x.ProductDetails).Include(x => x.Category).ToList();
        }
        public Product GetOneProductWithDetail(int id)
        {
            return context.Products
                .Include(x => x.ProductDetails.ProductDetailPc)
                .Include(x => x.ProductDetails.ProductDetailHeadPhone)
                .Include(x => x.ProductDetails.ProductDetailPhone)
                .Include(x => x.ProductDetails.ProductDetailTv)
                .Include(x => x.ProductDetails.ProductDetailWatch)
                .Include(x => x.ProductDetails.ProductDetailManWomen)
                .Include(x => x.Category).ToList().Where(x => x.ProductId == id).SingleOrDefault();
        }


      
        public List<Product> PopularProductList()
        {
            return context.Products.Where(x => x.ProductId == 41 || x.ProductId == 35 || x.ProductId == 33 || x.ProductId == 27 || x.ProductId == 15 || x.ProductId == 5 && x.ProductStatus == true).ToList();
        }
    }
}
