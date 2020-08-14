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
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cost { get; set; }
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        [Required]
        [StringLength(20)]
        public string SoldStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SoldDate { get; set; }

        [ForeignKey("MakeId")]
        [InverseProperty("Vehicle")]
        public virtual Make Make { get; set; }
        [ForeignKey("ModelId")]
        [InverseProperty("Vehicle")]
        public virtual VehicleModel Model { get; set; }
    }
}
