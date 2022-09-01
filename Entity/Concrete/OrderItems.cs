using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderItems: ActionsBase, IEntity
    {
        public int? Id { get; set; }
        public string OrderNumber { get; set; }
        public int? OrderId { get; set; }
        public int? ProductItems { get; set; }
       

    }
}
