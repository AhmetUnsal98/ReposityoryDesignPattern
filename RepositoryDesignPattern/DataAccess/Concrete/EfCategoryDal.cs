using RepositoryDesignPattern.DataAccess.Abstract;
using RepositoryDesignPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {

        public void Create(Category entity)
        {
            Console.WriteLine("Category create edildi .");
        }

        public void Delete(Category entity)
        {
            Console.WriteLine("Category delete edildi.");
        }

        public Category GetById(int id)
        {
            return new Category();
        }
        public void Update(Category entity)
        {
            Console.WriteLine("Category update edildi.");
        }
    }
}
