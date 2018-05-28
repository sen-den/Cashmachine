using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cashmachine
{
    public class Card
    {
        [Required]
        [StringLength(16)]
        public string ID { get; set; }

        [Required]
        [StringLength(4)]
        public string pin { get; set; }

        public List<Operation> InOperations { get; set; }
        public List<Operation> OutOperations { get; set; }
    }
}