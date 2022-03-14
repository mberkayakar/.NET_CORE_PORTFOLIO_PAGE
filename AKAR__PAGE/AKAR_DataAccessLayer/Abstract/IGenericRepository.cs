using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAR_DataAccessLayer.Abstract
{
    public interface IGenericRepository <T>  
    {
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();




    }
}

