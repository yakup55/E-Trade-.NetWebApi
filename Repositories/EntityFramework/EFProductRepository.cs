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
                .Include(x => x.ProductDetails.Pc)
                .Include(x => x.ProductDetails.HeadPhone)
                .Include(x => x.ProductDetails.Phone)
                .Include(x => x.ProductDetails.Tv)
                .Include(x => x.ProductDetails.Watch)
                .Include(x => x.ProductDetails.ManWomen)
                .Include(x => x.Category).ToList().Where(x => x.ProductId == id).SingleOrDefault();
        }


      
        public List<Product> PopularProductList()
        {
            return context.Products.Where(x => x.ProductId == 1086 || x.ProductId == 1082 || x.ProductId == 33 || x.ProductId == 1025 || x.ProductId == 1077 || x.ProductId == 5 ||x.ProductId == 1051 || x.ProductId == 1042 || x.ProductId == 1041 || x.ProductId == 1064 || x.ProductId == 1067 || x.ProductId == 1079 || x.ProductId == 1094 || x.ProductId == 1066 || x.ProductId == 1095 && x.ProductStatus == true).ToList();
        }

        public List<Product> ProductBrandList(int id)
        {
           return context.Products.Where(x => x.ProductDetails.Pc.BrandId == id || x.ProductDetails.Watch.BrandId == id || x.ProductDetails.Tv.BrandId == id || x.ProductDetails.ManWomen.BrandId == id || x.ProductDetails.Phone.BrandId == id || x.ProductDetails.HeadPhone.BrandId == id && x.ProductStatus==true).ToList();
        }

        public List<Product> ProductPriceSinking()
        {
            return context.Products.OrderBy(x=>x.ProductPrice).ToList();
        }

        public List<Product> ProductPriceGrowing()
        {
           return context.Products.OrderByDescending(x=>x.ProductPrice).ToList();
        }
    }
}
