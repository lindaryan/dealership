using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LindaRyanFinalProject.Models
{
    public partial class VehicleType
    {
        public VehicleType()
        {
            Model = new HashSet<Model>();
        }

        public int VehicleTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("VehicleType")]
        public virtual ICollection<Model> Model { get; set; }
    }
}
