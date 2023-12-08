using GerenciarContratos.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Data.DBContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<LoginModel> usuarios { get; set; }
        public DbSet<TipoUsuarioModel> tipo_usuario { get; set; }

    }
}
