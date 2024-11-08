using RepositoryDesignPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        void Update(TEntity entity);

        void Create(TEntity entity);

        void Delete(TEntity entity);
    }
}
