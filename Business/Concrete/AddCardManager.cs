using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AddCardManager : IAddCardService
    {
        
        ICardDal _dal;

        public AddCardManager(ICardDal dal)
        {
            _dal = dal;
        }

        public IResult Add(CartItems entity)
        {
            _dal.Add(entity);

            return new SuccessResult("Ürün eklendi");
        }
        [SecuredOperation("admin")]
        public IResult Delete(CartItems entity)
        {
            _dal.Delete(entity);

            return new SuccessResult("Ürün eklendi");
        }

        public IDataResult<List<OrderDetailListDto>> GetAlls(string  orderNumber)
        {
            var result = _dal.GetAlls();
            return new SuccessDataResult<List<OrderDetailListDto>>(result);
         }
        

        public IDataResult<OrderDetailDto> GetById(int orderId)
        {
            var result =_dal.Get(c=>c.OrderId== orderId);
            
            using (var context=new SaleContext())
            {
                var products = context.Products.Where(p => p.Id == result.ProductId).ToList();
                var order= context.OrderDetails.FirstOrDefault(o => o.OrderNumber == result.OrderNumber);
                var detail = new OrderDetailDto() { Total = order.Total, OrderNumber = result.OrderNumber,  Products = products };
                return new SuccessDataResult<OrderDetailDto>(detail);
            }
            
        }

        public IResult Update(CartItems entity)
        {
            _dal.Update(entity);

            return new SuccessResult("Ürün eklendi");
        }

  
    }
}
