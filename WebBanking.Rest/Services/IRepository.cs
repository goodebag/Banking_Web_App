using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebBanking.Rest.Services
{
     public interface IRepository<MyEntity> where MyEntity:class
    {
        Task<MyEntity> GetbyId(int Id);
        Task<IEnumerable<MyEntity>> GetALL(); 
        Task<IEnumerable<MyEntity>> FindAllByCondition(Expression<Func<MyEntity,bool>> condition );
        Task<MyEntity> AddEntity(MyEntity entity);
        Task<MyEntity> Remove(int Id);
    }
}
