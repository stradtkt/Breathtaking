using System.Threading.Tasks;
using Breath_API.Models;

namespace Breath_API.Data
{
    public interface IBreathRepository
    {
         void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<User> GetUser(int id);
        Task<bool> SaveAll();
    }
}