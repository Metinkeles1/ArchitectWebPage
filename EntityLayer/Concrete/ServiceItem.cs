using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServiceItem
    {
        [Key]
        public int ServiceItemId { get; set; }
        public string Item { get; set; }
        public Service Service { get; set; }
    }
}