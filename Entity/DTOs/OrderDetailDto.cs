using Core.Entities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class OrderDetailDto : ActionsBase,IDto
    {
        public int? OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? PaymentId { get; set; }
        public int? Total { get; set; }
        public List<Product> Products{ get; set ; }
        public int? ProductId { get; set; }
        public int? MyProperty { get; set; }
        // liste şeklinde response verilecek
    }   
}
