using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor ingresa una descripción.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Por favor ingrese una fecha de vencimiento.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Por favor seleccione una categoría.")]
        public string CategoryId { get; set; }

        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Por favor seleccione un estado.")]
        public string StatusId { get; set; }

        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
