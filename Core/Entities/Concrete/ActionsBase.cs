using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ActionsBase : IEntity
    {
        public int? DeletedBy { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? Modified_At { get; set; }
        public int? CreatedBy { get; set; }

        public ActionsBase()
        {
            Modified_At = DateTime.Now;
        }
    }
}
