using RepositoryDesignPattern.DataAccess.Abstract;
using RepositoryDesignPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccess.Concrete
{
    public class EfProductDal:IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("Product create edildi yeni branchte.");
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
