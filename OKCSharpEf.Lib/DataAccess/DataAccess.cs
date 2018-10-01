using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKCSharpEf.Lib.Domain;

namespace OKCSharpEf.Lib.DataAccess
{
    public class DataAccess : IDataAccess
    {

        private readonly ExampleContext _context;

        public DataAccess(ExampleContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IQueryable<T> Set<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Update(object entity)
        {
            _context.Update(entity);
        }
    }
}
