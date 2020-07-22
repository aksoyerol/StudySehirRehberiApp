﻿using Study.SehirRehberi.Business.Interfaces;
using Study.SehirRehberi.DataAccess.Concrete.EntityFrameworkCore.UnitOfWork;
using Study.SehirRehberi.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Study.SehirRehberi.Business.Concrete
{
    public class CityManager : GenericManager<City>, ICityService
    {
        private readonly IUnitOfWork _uow;
        public CityManager(IUnitOfWork uow) : base(uow)
        {
            _uow = uow;
        }

        public async Task<City> GetCityWithPhotosById(int id)
        {
            return await _uow.CityDal.GetCityWithPhotosById(id);
        }

        public async Task<List<City>> GetListCityWithPhotos()
        {
            return await _uow.CityDal.GetListCityWithPhotos();
        }
    }
}
