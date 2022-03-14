using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class TypeWritterText
    {
        [Key]

        public int TypeWritterTextId { get; set; }
        public string TypeWritterTextName { get; set; }

    }
}
