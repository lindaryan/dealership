using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LindaRyanFinalProject.Models
{
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Year { get; set; }
        [Required]
        [StringLength(100)]
        public string Colour { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        // display as currency
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        // display as currency
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Cost { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        [StringLength(20)]
        // change display name for headings
        [System.ComponentModel.DisplayName("Status")]
        public string SoldStatus { get; set; }
        [Column(TypeName = "datetime")]
        // change display name for headings
        [System.ComponentModel.DisplayName("Date Sold")]
        public DateTime? SoldDate { get; set; }

        [ForeignKey("MakeId")]
        [InverseProperty("Vehicle")]
        public virtual VehicleMake Make { get; set; }
        [ForeignKey("ModelId")]
        [InverseProperty("Vehicle")]
        public virtual VehicleModel Model { get; set; }
    }
}
