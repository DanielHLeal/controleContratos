using GerenciarContratos.Domain.DTO;
using GerenciarContratos.Domain.Interfaces;
using GerenciarContratos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciarContratos.Aplication.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<LoginDTO> Login(string user, string senha)
        {
            var exist = await _loginRepository.FindLogin(user,senha);

            

            if(exist == null)
            {
                return null;
            }
            else
            {
                LoginDTO login = new LoginDTO();
                login.nome = exist.nome;
                login.senha = exist.senha;
                login.email = exist.email;
                login.telefone = exist.telefone;

                return login;
            }

        }



        public async Task<bool> CreateLogin(LoginDTO login)
        {
            try
            {
                var exist = await _loginRepository.FindEmail(login.email);
                if (exist == null)
                {
                    if (login.nome != null && login.senha != null && login.email != null && login.telefone != null)
                    {
                        int letraMaiscula = Regex.Matches(login.senha, @"[a-zA-Z]").Count;
                        int letraMinuscula = Regex.Matches(login.senha, @"[a-zA-Z]").Count;
                        int isNumber = Regex.Matches(login.senha, @"[0-9]").Count;

                        if (letraMaiscula > 0 && letraMinuscula > 0 && isNumber > 0)
                        {
                            LoginModel loginModel = new LoginModel();
                            loginModel.nome = login.nome;
                            loginModel.senha = login.senha;
                            loginModel.email = login.email;
                            loginModel.telefone = login.telefone;
                            await _loginRepository.AddAsync(loginModel);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
