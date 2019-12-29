using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiBiblioteca.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(20, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Libro")]
        public string Title { get; set; }

        //public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Autor")]
        public string Author { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(50, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(40, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Editorial")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(20, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Idioma")]
        public string Language { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(6, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Paginas")]
        public int Pages { get; set; }

        [Required(ErrorMessage = "El Campo {0} es Obligatorio.")]
        [MaxLength(100, ErrorMessage = "El Campo {0} no puede tener mas de {1} Caracteres.")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
