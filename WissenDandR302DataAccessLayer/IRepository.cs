using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302DataAccessLayer
{
    public interface IRepository<T, Id> where T : class, new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter=null,string includeEntities=null);
        T GetById(Id id);
        //özellikle istenileni getir ÖRN--> Dostoyevsk'nin 300 sayfadan az romanı
        T GetByConditions(Expression<Func<T,bool>> filter, string includeEntities = null);
    }
}
