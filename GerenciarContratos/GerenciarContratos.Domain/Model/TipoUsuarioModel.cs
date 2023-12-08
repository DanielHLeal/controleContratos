using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarContratos.Domain.Model
{
    [Table("tipo_usuario")]
    public class TipoUsuarioModel
    {
        [Key]
        public int id_tipo { get; set; }
        public string descricao { get; set; }
    }
}
