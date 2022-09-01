using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        public IDataResult<List<Product>> GetAll();
        public IDataResult<Product> GetById(int orderNumber);
        public IResult Update(Product entity);
        public IResult Add(Product entity);
        public IResult Delete(Product entity);
    }
}
