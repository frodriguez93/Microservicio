using Lil.Search.Models;
using System.Threading.Tasks;

namespace Lil.Search.Interfaces
{
    public interface ICustomersService
    {
        Task<Customer> GetAsync(string id);
    }
}
