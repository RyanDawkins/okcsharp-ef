using OKCSharpEf.Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKCSharpEf.Lib.DataAccess
{
    public interface IDataAccess
    {
        IQueryable<T> Set<T>() where T : class;
        
        void SaveChanges();

        void Update(object entity);
    }
}
