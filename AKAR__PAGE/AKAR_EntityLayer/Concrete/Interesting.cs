using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class Interesting
    {
        [Key]

        public int ID { get; set; }
        public string Name { get; set; }
        public string Image_Or_Logo { get; set; }

    }
}
