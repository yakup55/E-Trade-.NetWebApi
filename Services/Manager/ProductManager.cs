﻿using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Entities.Exceptions.NotFoundException;

namespace Services.Manager
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public ProductManager(IProductRepository productRepository, ICategoryService categoryService, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.categoryService = categoryService;
            this.mapper = mapper;
        }

        public Product AddProduct(ProductDto productDto)
        {
            if (productDto is null)
            {
                throw new ArgumentNullException();
            }

            categoryService.GetCategoryById(productDto.CategoryId);
            var product = mapper.Map<Product>(productDto);
            productRepository.Add(product);
            return product;

        }

        public void DeleteProduct(int id)
        {
            var delete = GetOneProduct(id);
            productRepository.Delete(delete);
        }
        public List<Product> GetAllProductWithDetailList()
        {
            return productRepository.GetAllProductWithDetailList();
        }

        public List<Product> GetLastProduct()
        {
            return productRepository.GetLastProduct();
        }

        public List<Product> GetListByString(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException();
            }
            return productRepository.GetList(x => x.ProductName.Contains(name)
            || x.Category.CategoryName.Contains(name)
            || x.ProductDetails.ProductExplanation.Contains(name)
            || x.ProductDetails.Pc.Color.ColorName.Contains(name)
            || x.ProductDetails.Phone.Color.ColorName.Contains(name)
            || x.ProductDetails.HeadPhone.Color.ColorName.Contains(name)
            || x.ProductDetails.ManWomen.Color.ColorName.Contains(name)
            || x.ProductDetails.Watch.Color.ColorName.Contains(name)
            || x.ProductDetails.Watch.Brand.BrandName.Contains(name)
            || x.ProductDetails.Tv.Brand.BrandName.Contains(name)
            || x.ProductDetails.Phone.Brand.BrandName.Contains(name)
            || x.ProductDetails.HeadPhone.Brand.BrandName.Contains(name)
            || x.ProductDetails.ManWomen.Brand.BrandName.Contains(name)
            || x.ProductDetails.Pc.Brand.BrandName.Contains(name)
            );
        }

        public Product GetOneProduct(int id)
        {
            var product = productRepository.GetOne(x => x.ProductId == id);
            if (product is null)
            {
                throw new ProductNotFoundException(id);
            }
            return product;
        }
        public Product GetOneProductWithDetail(int id)
        {
            var one = productRepository.GetOneProductWithDetail(id);
            if (one is null)
            {
                throw new ProductDetailsNotFoundException(id);
            }
            return one;
        }

        public List<Product> GetProductList(Expression<Func<Product, bool>> filter = null)
        {
            return productRepository.GetList(filter).OrderByDescending(x => x.ProductId).ToList();
        }

        public List<Product> PopularProductList()
        {
            return productRepository.PopularProductList();
        }

        public List<Product> ProductBrand(int id)
        {
            return productRepository.ProductBrandList(id);
        }

        public Product UpdateProduct(Product product, int id)
        {
            var update = GetOneProduct(id);
            update.ProductName = product.ProductName;
            update.ProductDate = product.ProductDate;
            update.ProductDetails = product.ProductDetails;
            update.ProductPrice = product.ProductPrice;
            update.ProductStatus = product.ProductStatus;
            update.ProductImage = product.ProductImage;
            update.CategoryId = product.CategoryId;
            productRepository.Update(update);
            return update;
        }
    }
}
