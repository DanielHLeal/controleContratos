using GerenciarContratos.Data.DBContext;
using GerenciarContratos.Domain.Interfaces;
using GerenciarContratos.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Data.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        private readonly Context _context;

        public LoginRepository(Context context) : base(context)
        {
            _context = context;
        }

        public async Task AddAsync(LoginModel entity)
        {
            try
            {
                _context.usuarios.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<LoginModel> FindbyId(int id)
        {
            try
            {
                LoginModel getbyid = _context.usuarios.Include(x => x.id_user).FirstOrDefault(x => x.id_user == id);

                return getbyid;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<LoginModel> FindEmail(string email)
        {
            try
            {
                LoginModel getbyEmail = _context.usuarios.Where(x => x.email == email).FirstOrDefault();

                return getbyEmail;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<LoginModel> FindLogin(string user,string senha)
        {
            try
            {
                LoginModel getbyEmail = _context.usuarios.Where(x => x.nome == user && x.senha == senha).FirstOrDefault();
                
                return getbyEmail;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}

