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
using static Entities.Exceptions.NotFoundException;

namespace Services.Manager
{
    public class ManWomenDetailManager : IManWomenDetailService
    {
        private readonly IManWomenDetailRepository repository;
        private readonly IMapper mapper;

        public ManWomenDetailManager(IManWomenDetailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<ProductDetailManWomen> GetManWomenList(Expression<Func<ProductDetailManWomen, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public ProductDetailManWomen GetOneManWomen(int id)
        {
           var one=repository.GetOne(x=>x.ProductDetailManWomenId== id);
            if (one is null)
            {
                throw new ManWomenDetailNotFoundException(id);
            }
            return one;
        }

        public ProductDetailManWomen ManWomenAdd(ManWomenDetailDto detailManWomen)
        {
          if(detailManWomen is null)
            {
                throw new ArgumentNullException();
            }
          var add =mapper.Map<ProductDetailManWomen>(detailManWomen);
            repository.Add(add);
            return add;
        }

        public void ManWomenDelete(int id)
        {
            var one = GetOneManWomen(id);
            if(one is null)
            {
                throw new ManWomenDetailNotFoundException(id);
            }
            repository.Delete(one);
        }

        public ProductDetailManWomen ManWomenUpdate(int id, ProductDetailManWomen detailManWomen)
        {
           
            var update = GetOneManWomen(id);
            update.AyakkabiTipi=detailManWomen.AyakkabiTipi;
            update.Malzeme=detailManWomen.Malzeme;
            update.Cinsiyet=detailManWomen.Cinsiyet;
            update.YakaStili=detailManWomen.YakaStili;
            update.Tipi=detailManWomen.Tipi;
            repository.Update(update);
            return update;
        }
    }
}
