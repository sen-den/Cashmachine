using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace cashmachine
{
    public class Operation
    {
        public int ID { get; set; }
        
        [ForeignKey("InOperations")]
        public string InCard { get; set; }
        
        
        [ForeignKey("OutOperations")]
        public string OutCard { get; set; }

        [Required]
        public float amount { get; set; }

        [Required]
        public DateTime Time { get; set; }
    }
}