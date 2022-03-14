using AKAR_EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Concrete
{
    public class Feature 
    {

        [Key]
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Short_Description { get; set; }
        public DateTime Birthdate { get; set; }
        public string website { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string job_status { get; set; }




    }
}
