using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebBanking.Rest.Services
{
    public class Repository<myEntity> : IRepository<myEntity> where myEntity : class
    {
       protected readonly DbContext context;

        public Repository(DbContext Context)
        {
            this.context = Context;
        }
        public async Task<myEntity> AddEntity(myEntity entity)
        {
            var result = await context.Set<myEntity>().AddAsync(entity);
            return result.Entity;
        }

        public async Task<IEnumerable<myEntity>> FindAllByCondition(Expression<Func<myEntity, bool>> condition)
        {
            var result = await context.Set<myEntity>().Where(condition).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<myEntity>> GetALL()
        {
            var result = await context.Set<myEntity>().ToListAsync();
            return result;
        }

        public async Task<myEntity> GetbyId(int Id)
        {
            var result = await context.Set<myEntity>().FindAsync(Id);
            return result;
        }

        public async Task<myEntity> Remove(int Id)
        {
            var result = await context.Set<myEntity>().FindAsync(Id);
            context.Set<myEntity>().Remove(result);
            return result;
        }
    }
}
