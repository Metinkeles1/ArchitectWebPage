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
    public class EfServiceItemDal : GenericRepository<ServiceItem>, IServiceItemDal
    {
        public List<ServiceItem> GetItemsWithService()
        {
            using (var c = new Context())
            {
                return c.ServiceItems.Include(x => x.Service).ToList();
            }
        }
    }
}