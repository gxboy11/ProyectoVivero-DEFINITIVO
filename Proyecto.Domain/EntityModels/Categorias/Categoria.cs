using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Domain.EntityModels.Categorias
{
    public class Categoria : Entity
    {

        public Categoria(string nombreCategoria, string descripcionCategoria)
        {
            NombreCategoria = nombreCategoria;
            DescripcionCategoria = descripcionCategoria;

        }

        [Key]
        public int IdCategoria { get; private set; }

        public string NombreCategoria { get; private set; }

        public string DescripcionCategoria { get; private set; }

        public void Update(string nombreCategoria, string descripcionCategoria)
        {
            NombreCategoria = nombreCategoria;
            DescripcionCategoria = descripcionCategoria;
        }

    }
}
