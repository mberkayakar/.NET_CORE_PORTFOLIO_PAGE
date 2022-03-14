using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]

        public int ID { get; set; }
        public string Name { get; set; }
        public string ProjectUrl { get; set; }

        public string Description { get; set; }

    }
}
