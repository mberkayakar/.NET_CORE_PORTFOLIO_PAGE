using AKAR_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_EntityLayer.Abstract
{
    public interface IFeature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
