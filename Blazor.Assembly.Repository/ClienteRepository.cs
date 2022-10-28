using Blazor.Assembly.Helkin.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Assembly.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public Task<bool> DeleteData()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
