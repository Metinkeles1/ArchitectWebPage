﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        //public List<Service> GetItemsWithService()
        //{
        //    using (var c = new Context())
        //    {
        //        return c.Services.Include(x => x.ServiceItem).ToList();
        //    }
        //}
    }
}