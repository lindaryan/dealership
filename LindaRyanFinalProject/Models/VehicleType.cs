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
            VehicleModel = new HashSet<VehicleModel>();
        }

        // change display name for headings
        [System.ComponentModel.DisplayName("Type")]
        public int VehicleTypeId { get; set; }
        [Required]
        [StringLength(100)]
        // change display name for headings
        [System.ComponentModel.DisplayName("Type")]
        public string Name { get; set; }

        [InverseProperty("VehicleType")]
        public virtual ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
