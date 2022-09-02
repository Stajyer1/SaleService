using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardItemsDal : EfEntityRepositoryBase<CartItems, SaleContext>, ICardDal
    {
        public List<OrderDetailListDto> GetAlls()
        {
            using (var context = new SaleContext())
            {

                var query = (from carditems in context.CartItems
                            join product in context.Products
                            on carditems.ProductId equals product.Id 
                            join order in context.OrderDetails
                            on carditems.OrderNumber equals order.OrderNumber
                            
                             select   new OrderDetailListDto()
                            {
                                 OrderId=order.Id,
                                Total = order.Total,                               
                                
                                ProductCategory = product.Category,
                                ProductSKU = product.SKU,
                                ProductName = product.Name,
                                ProductDesc = product.Desc,
                                CreatedBy=order.CreatedBy,
                                DeletedBy=order.DeletedBy,
                                Deleted=order.Deleted,
                                PaymentId=order.PaymentId,
                                
                            });
                return query.ToList();





            }
        }


    }
}
