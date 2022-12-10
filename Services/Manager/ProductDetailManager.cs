using AutoMapper;
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

namespace Services.Manager
{
    public class ProductDetailManager:IProductDetailService
    {
        private readonly IProductDetailRepository repository;
        private readonly IProductService service;
        private readonly IMapper mapper;


        public ProductDetailManager()
        {

        }
        public ProductDetailManager(IProductDetailRepository repository, IProductService service, IMapper mapper)
        {
            this.repository = repository;
            this.service = service;
            this.mapper = mapper;
        }

        public ProductDetails DetailAdd(ProductDetailDto product)
        {
         if (product is null)
            {
                throw new ArgumentNullException();
            }
           service.GetOneProduct(product.ProductId);
           
            var dto=mapper.Map<ProductDetails>(product);
            repository.Add(dto);
            return dto;
        }

        public ProductDetails GetOneProductDetails(int productId)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetails> GetProductDetailsList(Expression<Func<ProductDetails, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
