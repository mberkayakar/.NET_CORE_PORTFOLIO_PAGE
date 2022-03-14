using AKAR_DataAccessLayer.Abstract;
using AKAR_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_DataAccessLayer.Concrete.SQL_SERVER
{
    public class TypeWritterRepository : GenericRepository<TypeWritterText, SQLCONTEXT> ,  ITypeWritterRepository
    {



    }
}
