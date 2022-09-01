using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CountDTO:IDto
    {
        public int Count { get; set; }
        public bool Success { get; set; } 
    }
}
