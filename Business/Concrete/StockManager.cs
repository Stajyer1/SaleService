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
    public class StockManager : IStockService
    {
        IStockdal _dal;

        public StockManager(IStockdal dal)
        {
            _dal = dal;
        }

        public IResult Add(Stock entity)
        {
            _dal.Add(entity);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(Stock entity)
        {
            _dal.Delete(entity);
            return new SuccessResult("silindi");

        }

        public IDataResult<List<Stock>> GetAll()
        {
            return new SuccessDataResult<List<Stock>>(_dal.GetList().ToList(), "getirildi");
        }

        public IDataResult<Stock> GetById(int productId)
        {
            return new SuccessDataResult<Stock>(_dal.Get(p => p.ProductId == productId),"getirildi"); 
        }

        public IResult Update(Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
