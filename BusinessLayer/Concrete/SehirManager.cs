using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Entities;
using DataAccess.Abstract;
using HizliBilet.BusinessLayer.Abstract;

namespace HizliBilet.BusinessLayer.Concrete
{
    public class SehirManager : ISehirService
    {
        private ISehirRepositoryDal _sehirRepository;
        public SehirManager(ISehirRepositoryDal sehirRepository)
        {
            _sehirRepository = sehirRepository;
        }
        public void Create(Sehir entity)
        {
            _sehirRepository.Create(entity);
        }

        public void Delete(Sehir entity)
        {
            _sehirRepository.Delete(entity);
        }

        public List<Sehir> GetAll()
        {
            return _sehirRepository.GetAll();
        }

        public Sehir GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string sehirad()
        {
            throw new NotImplementedException();
        }

        public void Update(Sehir entity)
        {
            _sehirRepository.Update(entity);
        }

        public void Update(Sehir entity, int[] sehirIds)
        {
            throw new NotImplementedException();
        }
    }
}
