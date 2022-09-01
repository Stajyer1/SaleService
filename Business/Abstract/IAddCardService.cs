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
    public interface IAddCardService
    {
        public IDataResult<List<OrderDetailListDto>> GetAlls(string orderNumber);
        public IDataResult<OrderDetailDto> GetById(int orderId);
        public IResult Update(CartItems entity);
        public IResult Add(CartItems entity);
        public IResult Delete(CartItems entity);
    }
}
