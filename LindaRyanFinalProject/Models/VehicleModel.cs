using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LindaRyanFinalProject.Models
{
    public partial class VehicleModel
    {
        public VehicleModel()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        [Key]
        public int ModelId { get; set; }
        [Required]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Model")]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Engine Size")]
        public string EngineSize { get; set; }
        [System.ComponentModel.DisplayName("Number of Doors")]
        public int NumberOfDoors { get; set; }
        public int VehicleTypeId { get; set; }

        [ForeignKey("VehicleTypeId")]
        [InverseProperty("VehicleModel")]
        [System.ComponentModel.DisplayName("Vehicle Type")]
        public virtual VehicleType VehicleType { get; set; }
        [InverseProperty("Model")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
