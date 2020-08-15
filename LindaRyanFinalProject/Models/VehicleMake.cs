using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LindaRyanFinalProject.Models
{
    public partial class VehicleMake
    {
        public VehicleMake()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        [Key]
        public int MakeId { get; set; }
        [Required]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Make")]
        public string Name { get; set; }

        [InverseProperty("Make")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
