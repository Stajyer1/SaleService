using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderDetail : ActionsBase, IEntity
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public int? Total { get; set; }
        public int? PaymentId { get; set; }
        public string OrderNumber { get; set; }
    }
}
