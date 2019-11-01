using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GMidTermF2019.Models
{
    public partial class Party
    {
        public Party()
        {
            Election = new HashSet<Election>();
        }

        public int PartyId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Logo { get; set; }

        [InverseProperty("Party")]
        public virtual ICollection<Election> Election { get; set; }
    }
}
