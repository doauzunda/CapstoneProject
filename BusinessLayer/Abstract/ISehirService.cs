
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HizliBilet.BusinessLayer.Abstract
{
    public interface ISehirService
    {
        Sehir GetById(int id);
        string sehirad();
        void Create(Sehir entity);
        void Update(Sehir entity);
        void Delete(Sehir entity);
        void Update(Sehir entity, int[] sehirIds);
        List<Sehir> GetAll();
    }
}
