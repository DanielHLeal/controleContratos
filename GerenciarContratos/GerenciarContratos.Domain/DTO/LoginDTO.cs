using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Domain.DTO
{
    public class LoginDTO
    {
        public string nome { get; set; }
        public string senha { get; set; }

        public string email { get; set; }
        public string telefone { get; set; }
    }
}
