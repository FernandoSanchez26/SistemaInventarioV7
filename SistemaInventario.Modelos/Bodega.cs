using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es requerido")]
        [MaxLength(60, ErrorMessage ="Nombre deber Maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(100, ErrorMessage = "Descripcion deber Maximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido")]
        public bool Ëstado { get; set; }
    }
}
