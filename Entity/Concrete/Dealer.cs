using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Dealer : ActionsBase, IEntity
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
