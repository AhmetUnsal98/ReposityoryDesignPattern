using RepositoryDesignPattern.DataAccess.Concrete;
using RepositoryDesignPattern.Entity;
using System;
namespace RepositoryDesignPattern
{
    class Program
    {

            static void Main(string[] args)
        {

            var productDal = new EfProductDal();
            productDal.Create(new Product());
        }


    }




}