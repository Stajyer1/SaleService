using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        public IDataResult<List<OrderDetail>> GetAlldetails();
        public IDataResult<OrderDetail> GetDetailById(int orderId);
        public IResult Update(OrderDetail entity);
        public IResult Add(OrderDetail entity);
        public IResult Delete(OrderDetail entity);
    }
}
