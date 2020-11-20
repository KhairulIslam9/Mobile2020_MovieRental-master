using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRental.DAL.Services
{
    public abstract class ServiceBase<TKey, TEntity> : IService<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        protected Connection connection;

        public ServiceBase()
        {
            connection = new Connection(@"Data Source=DESKTOP-4U66RG8;Initial Catalog=MovieRental.Database;Integrated Security=True");
        }

        public abstract TEntity Get(TKey key);
        public abstract IEnumerable<TEntity> GetAll();
        public abstract TKey Insert(TEntity entity);
        public abstract bool Update(TEntity entity);
        public abstract bool Delete(TKey key);

        public ServiceBase(Connection connection) {

            Connection = new Connection(@'');
        }
    }
}
