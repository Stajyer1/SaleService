using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PaymentDetail: ActionsBase, IEntity
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public int? Amount { get; set; }
        public string provider { get; set; }
        public bool? Status { get; set; }
        
    }
}
