using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InyectionDependecy.Contratos
{
    public interface IRepositoryGeneric <T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> Getfor(Expression<Func<T , bool>> predicado);

        bool Create(T t);
        bool Update(T t);
        bool Delete(T t);
        void Guardar(T t);
    }
}
