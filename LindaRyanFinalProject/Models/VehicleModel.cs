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

        public int ModelId { get; set; }
        [Required]
        [StringLength(100)]
        public string EngineSize { get; set; }
        public int NumberOfDoors { get; set; }
        [Required]
        [StringLength(100)]
        public string Colour { get; set; }
        public int VehicleTypeId { get; set; }

        [ForeignKey("VehicleTypeId")]
        [InverseProperty("VehicleModel")]
        public virtual VehicleType VehicleType { get; set; }
        [InverseProperty("Model")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
