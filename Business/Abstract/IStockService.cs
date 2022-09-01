using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStockService
    {
        public IDataResult<List<Stock>> GetAll();
        public IDataResult<Stock> GetById(int productId);
        public IResult Update(Stock entity);
        public IResult Add(Stock entity);
        public IResult Delete(Stock entity);
    }
}
