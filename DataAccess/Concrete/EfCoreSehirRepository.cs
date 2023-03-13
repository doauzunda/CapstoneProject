using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using EntityLayer.Entities;

namespace DataAccess.Concrete
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, BiletContext>, ISehirRepositoryDal
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
