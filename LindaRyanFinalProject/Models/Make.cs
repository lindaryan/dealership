using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LindaRyanFinalProject.Models
{
    public partial class Make
    {
        public Make()
        {
            Vehicle = new HashSet<Vehicle>();
        }

        public int MakeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("Make")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
