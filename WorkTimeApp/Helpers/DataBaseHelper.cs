using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkTimeApp.DataBase;

namespace WorkTimeApp.Helpers
{
    public static class DataBaseHelper
    {

        public static List<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>>? filter = null,
                                                     Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? includes = null)
            where TEntity : class, new()
        {
            using (Context context = new Context())
            {
                var data = context.Set<TEntity>().AsQueryable();

                if (includes != null) data = includes(data);

                return filter is null ? data.ToList()
                                      : data.Where(filter).ToList();
            }
        }

        public static TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter,
                                           Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? includes = null)
            where TEntity : class, new()
        {
            using (Context context = new Context())
            {
                var data = context.Set<TEntity>().AsQueryable();

                if (includes != null) data = includes(data);

                return data.FirstOrDefault(filter);
            }
        }

        public static void Add<TEntity>(TEntity entity)
            where TEntity : class, new()
        {
            using (Context context = new Context())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public static void Delete<TEntity>(TEntity entity)
            where TEntity : class, new()
        {
            using (Context context = new Context())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public static void Update<TEntity>(TEntity entity)
            where TEntity : class, new()
        {
            using (Context context = new Context())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}
