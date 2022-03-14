using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class Skills
    {
        [Key]

        public int ID { get; set; }
        public string SkillName { get; set; }
        public int Value { get; set; }
        public string Color { get; set; }



    }
}
