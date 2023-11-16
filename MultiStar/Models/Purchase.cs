using System;
using System.ComponentModel.DataAnnotations;

namespace appDash.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "La Cantidad debe ser mayor que cero.")]
        public int Quantity { get; set; }


        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}