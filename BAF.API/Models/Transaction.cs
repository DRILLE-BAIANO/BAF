using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAF.API.Models;
 public class Transaction
 {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName =)]
 }
