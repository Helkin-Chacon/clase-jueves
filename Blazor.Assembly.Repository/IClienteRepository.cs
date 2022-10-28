using Blazor.Assembly.Helkin.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Assembly.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> GetDetails(int id);
        public Task<IEnumerable<Cliente>> GetAll();
        public Task<bool> Save();
        public Task<bool> UpdateData();
        public Task<bool> DeleteData();
    }
}
