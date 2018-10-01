using OKCSharpEf.Lib.DataAccess;
using OKCSharpEf.Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKCSharpEf.Lib.Service
{
    public class PersonAppService
    {

        private readonly IDataAccess _dataAccess;

        public PersonAppService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public int GetMaxAge()
        {
            return _dataAccess
                .Set<Person>()
                .Max(p => p.Age);
        }

        public Dictionary<int, int> GetAgeCounts()
        {
            return _dataAccess
                .Set<Person>()
                .GroupBy(p => p.Age)
                .Select(p => new Tuple<int, int>(p.Key, p.Count()))
                .ToList()
                .Aggregate(seed: new Dictionary<int, int>(), func: (dict, item) =>
                 {
                     dict.Add(item.Item1, item.Item2);
                     return dict;
                 });
        }

    }
}
