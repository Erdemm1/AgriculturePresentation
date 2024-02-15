using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
        [Key]
        public int AbaoutID { get; set; }
        public string AbaoutHistory { get; set; }
        public string AbaoutUs { get; set; }
    }
}
