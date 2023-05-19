using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceItemManager : IServiceItemService
    {
        IServiceItemDal _serviceItemDal;

        public ServiceItemManager(IServiceItemDal serviceItemDal)
        {
            _serviceItemDal = serviceItemDal;
        }

        public List<ServiceItem> GetItemWithService()
        {
            return _serviceItemDal.GetItemsWithService();
        }

        public void TAdd(ServiceItem t)
        {
            _serviceItemDal.Insert(t);
        }

        public void TDelete(ServiceItem t)
        {
            _serviceItemDal.Delete(t);
        }

        public ServiceItem TGetByID(int id)
        {
            return _serviceItemDal.GetByID(id);
        }

        public List<ServiceItem> TGetList()
        {
            return _serviceItemDal.GetAll();
        }

        public void TUpdate(ServiceItem t)
        {
            _serviceItemDal.Update(t);
        }
    }
}