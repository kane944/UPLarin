using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace УП______________________
{
    
    
        [Table(Name = "Service")]
        public class Service
    {
            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int id { get; set; }
            [Column]
            public string Title { get; set; }
            [Column]
            public decimal Cost { get; set; }
            [Column]
            public int DurationInSeconds { get; set; }
            [Column]
            public string Description { get; set; }
            [Column]
            public double Discount { get; set; }
            [Column]
            public string MainImagePath { get; set; }
            
        }
}

