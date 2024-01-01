using MagicVilla_Villa_API.Models;
using System.Linq.Expressions;

namespace MagicVilla_Villa_API.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
