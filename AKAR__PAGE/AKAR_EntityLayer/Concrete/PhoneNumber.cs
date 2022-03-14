using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class PhoneNumber
    {
        [Key]

        public int ID { get; set; }
        public string Phone_number { get; set; }


    }
}
