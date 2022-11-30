﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
            return context.Products.Include(x => x.ProductDetails).Include(x => x.Category).ToList().Where(x => x.ProductId == id).SingleOrDefault();
        }


        public List<Product> PopularsProduct(Expression<Func<Product, bool>> filter = null)
        {
            return context.Products.Where(filter).ToList();
        }
    }
}
