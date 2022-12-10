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
    public class TvDetailManager : ITvDetailService
    {
        private readonly ITvDetailRepository repository;
        private readonly IMapper mapper;

        public TvDetailManager(ITvDetailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public ProductDetailTv GetOneTv(int id)
        {
            var one = repository.GetOne(x=>x.ProductDetailTvId== id);
            if (one is null)
            {
                throw new TvDetailNotFoundException(id);
            }
            return one;
        }

        public List<ProductDetailTv> GetTvList(Expression<Func<ProductDetailTv, bool>> filter = null)
        {
          return repository.GetList(filter);
        }

        public ProductDetailTv TvAdd(TvDetailDto detailTv)
        {
            if (detailTv is null)
            {
                throw new ArgumentNullException();
            }
            var add=mapper.Map<ProductDetailTv>(detailTv);
            repository.Add(add);
            return add;
        }

        public void TvDelete(int id)
        {
            var one = GetOneTv(id);
            if (one is null)
            {
                throw new TvDetailNotFoundException(id);
            }
            repository.Delete(one);
        }

        public ProductDetailTv TvUpdate(int id, ProductDetailTv detailTv)
        {
            var update = GetOneTv(id);
            update.DahiliUyduAlici = detailTv.DahiliUyduAlici;
            update.EkranEbati = detailTv.EkranEbati;
            update.EkranFormati = detailTv.EkranFormati;
            update.Wifi = detailTv.Wifi;
            update.Kurulum = detailTv.Kurulum;
            update.PcBaglantisi = detailTv.PcBaglantisi;
            update.HdmiGirisleri = detailTv.HdmiGirisleri;
            repository.Update(update);
            return update;
        }
    }
}
