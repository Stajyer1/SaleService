using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _dal;

        public OrderManager(IOrderDal dal)
        {
            _dal = dal;
        }

        public IResult Add(OrderDetail entity)
        {
            _dal.Add(entity);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(OrderDetail entity)
        {
            _dal.Delete(entity);
            return new SuccessResult("silindi");

        }

        public IDataResult<List<OrderDetail>> GetAlldetails()
        {
            return new SuccessDataResult<List<OrderDetail>>(_dal.GetList().ToList(), "eklendi");
        }

        public IDataResult<OrderDetail> GetDetailById(int orderId)
        {
            return new SuccessDataResult<OrderDetail>(_dal.Get(o => o.Id  == orderId));
        }

        public IResult Update(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
