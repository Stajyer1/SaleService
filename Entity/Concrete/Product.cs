using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product: ActionsBase, IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string SKU { get; set; }
        public int? Price { get; set; }
        public string Category { get; set; }
        public int? Quantity { get; set; }


    }
}
