using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class Resume
    {
        [Key]

        public int ID { get; set; }
        public string Position { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinisDate { get; set; }
        public string OrganisationLogo { get; set; }

        public string Description { get; set; }



    }
}
