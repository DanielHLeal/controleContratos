using GerenciarContratos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Domain.Interfaces
{
    public interface ILoginRepository
    {
        Task AddAsync(LoginModel entity);
        Task<LoginModel> FindEmail(string email);
        Task<LoginModel> FindbyId(int id);
        Task<LoginModel> FindLogin(string user, string senha);
    }
}
