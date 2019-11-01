using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GMidTermF2019.Models
{
    public partial class Election
    {
        public int ElectionId { get; set; }
        public int Year { get; set; }
        public int PartyId { get; set; }
        public bool? Majority { get; set; }

        [ForeignKey("PartyId")]
        [InverseProperty("Election")]
        public virtual Party Party { get; set; }
    }
}
