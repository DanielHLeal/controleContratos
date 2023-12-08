using GerenciarContratos.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Domain.Interfaces
{
    public interface ILoginService
    {
        Task<bool> CreateLogin(LoginDTO login);
        Task<LoginDTO> Login(string user, string senha);
    }
}
