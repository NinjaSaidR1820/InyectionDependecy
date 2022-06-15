using InyectionDependecy.Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace InyectionDependecy.Models
{
    public class RepositoryGeneric<TContext, T> : IRepositoryGeneric<T> where TContext : DbContext, new() where T : class
    {


        private TContext context = new TContext();

        public TContext Context {get;set;}


        public bool Create(T t)
        {
            try
            {
                this.context.Set<T>().Add(t);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T t)
        {
            try
            {
                this.context.Set<T>().Remove(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual void Guardar(T t)
        {
             this.context.SaveChanges();
        }

        public bool Update(T t)
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<T> GetAll()
        {
            return this.context.Set<T>();
        }

        public virtual IEnumerable<T> Getfor(Expression<Func<T, bool>> predicado)
        {
           return this.context.Set<T>().Where(predicado);
        }
    }
}