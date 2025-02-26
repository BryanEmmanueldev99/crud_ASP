using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_ASP.Models.ViewsModels
{
    public class CategoriaViewModel
    {
        [Required]
        [DisplayName("NombreCategoria")]
        public string NombreCategoria { get; set; }
    }
}
