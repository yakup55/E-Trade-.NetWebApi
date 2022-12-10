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
    public class HeadPhonDetailManager : IHeadPhoneDetailService
    {
        private readonly IHeadPhoneDetailRepository repository;
        private readonly IMapper mapper;

        public HeadPhonDetailManager(IHeadPhoneDetailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<ProductDetailHeadPhone> GetHeadPhoneList(Expression<Func<ProductDetailHeadPhone, bool>> filter = null)
        {
            return repository.GetList(filter);
        }

        public ProductDetailHeadPhone GetOneHeadPhone(int id)
        {
            var one = repository.GetOne(x => x.HeadPhoneId == id);
            if (one is null)
            {
                throw new HeadPhoneDetailNotFoundException(id);
            }
            return one;
        }

        public ProductDetailHeadPhone HeadPhoneAdd(HeadPhoneDetailDto headPhone)
        {
            if (headPhone is null)
            {
                throw new ArgumentNullException();
            }
            var add = mapper.Map<ProductDetailHeadPhone>(headPhone);
            repository.Add(add);
            return add;
        }

        public void HeadPhoneDelete(int id)
        {
            var one = GetOneHeadPhone(id);
            if (one is null)
            {
                throw new HeadPhoneDetailNotFoundException(id);
            }
            repository.Delete(one);
        }

        public ProductDetailHeadPhone HeadPhoneUpdate(int id, ProductDetailHeadPhone headPhone)
        {
            if (headPhone is  null)
            {
                throw new HeadPhoneDetailNotFoundException(id);
            }
            var update = GetOneHeadPhone(id);
            update.GurultuOnleme = headPhone.GurultuOnleme;
            update.BluetoothVersiyon = headPhone.BluetoothVersiyon;
            update.CiftTelefonDestegi = headPhone.CiftTelefonDestegi;
            update.KullanimTipi = headPhone.KullanimTipi;
            update.SuyaTereDayanikli = headPhone.SuyaTereDayanikli;
            repository.Update(update);
            return update;
        }
    }
}
