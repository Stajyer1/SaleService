using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Product entity)
        {
            _dal.Add(entity);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(Product entity)
        {
            _dal.Delete(entity);
            return new SuccessResult("silindi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            var result=_dal.GetList().ToList();
            return new SuccessDataResult<List<Product>>(result);
        }

        public IDataResult<Product> GetById(int prodId)
        {
            var result=_dal.Get(p => p.Id == prodId);
            return new SuccessDataResult<Product>(result);

        }

        public IResult Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
