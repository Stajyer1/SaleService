using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class OrderDetailListDto :  IDto
    {
        public int? OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int? PaymentId { get; set; }
        public int? Total { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public string ProductSKU { get; set; }
        //pascal case
        //SOLID
        public int? ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public int? ProductQuantity { get; set; }
        public int? ProductId { get; set; }
    }
}
