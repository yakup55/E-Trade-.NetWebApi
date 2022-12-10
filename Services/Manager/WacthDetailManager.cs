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
    public class WacthDetailManager:IWatchDetailService
    {
        private readonly IWacthDetailRepository repository;
        private readonly IMapper mapper;

        public WacthDetailManager(IWacthDetailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public ProductDetailWatch GetOneWacth(int id)
        {
            var one =repository.GetOne(x=>x.ProductDetailWatchId== id); 
            if (one is null)
            {
                throw new WacthDetailNotFoundException(id);
            }
            return one;
        }

        public List<ProductDetailWatch> GetWacthList(Expression<Func<ProductDetailWatch, bool>> filter = null)
        {
           return repository.GetList(filter);
        }

        public ProductDetailWatch WatchAdd(WacthDetailDto detailWatch)
        {
            if (detailWatch is null)
            {
                throw new ArgumentNullException();
            }
            var add=mapper.Map<ProductDetailWatch>(detailWatch);
            repository.Add(add);
            return add;
        }

        public void WatchDelete(int id)
        {
          var one=GetOneWacth(id);
            if (one is null)
            {
                throw new WacthDetailNotFoundException(id);
            }
            repository.Delete(one);
        }

        public ProductDetailWatch WatchUpdate(int id, ProductDetailWatch detailWatch)
        {
            var update = GetOneWacth(id);
            update.AdımSayar = detailWatch.AdımSayar;
            update.GPS = detailWatch.GPS;
            update.KalpRitmiOlcme = detailWatch.KalpRitmiOlcme;
            update.Kamera = detailWatch.Kamera;
            update.SesliGorusme = detailWatch.SesliGorusme;
            update.SuGecirme = detailWatch.SuGecirme;
            update.UykuTakibi = detailWatch.UykuTakibi;
            update.UyumluMarka = detailWatch.UyumluMarka;
            repository.Update(update);
            return update;
        }
    }
}
