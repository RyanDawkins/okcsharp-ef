using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OKCSharpEf.Lib.DataAccess;
using OKCSharpEf.Lib.Domain;
using OKCSharpEf.Lib.Service;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod0()
        {
            List<Person> persons = new List<Person>()
            {
                new Person()
                {
                    Name = "Daenerys Tagaryen",
                    Age = 14
                },
                new Person()
                {
                    Name = "John Snow",
                    Age = 14
                },
                new Person()
                {
                    Name = "Rickon Stark",
                    Age = 4
                }
            };

            Mock<IDataAccess> dataAccess = new Mock<IDataAccess>();
            dataAccess.Setup(s => s.Set<Person>()).Returns(persons.AsQueryable());

            PersonAppService service = new PersonAppService(dataAccess.Object);
            int result = service.GetMaxAge();

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void TestMethod1()
        {
            List<Person> persons = new List<Person>()
            {
                new Person()
                {
                    Name = "Daenerys Tagaryen",
                    Age = 14
                },
                new Person()
                {
                    Name = "John Snow",
                    Age = 14
                },
                new Person()
                {
                    Name = "Rickon Stark",
                    Age = 4
                }
            };

            Mock<IDataAccess> dataAccess = new Mock<IDataAccess>();
            dataAccess.Setup(s => s.Set<Person>()).Returns(persons.AsQueryable());

            PersonAppService service = new PersonAppService(dataAccess.Object);
            Dictionary<int, int> result = service.GetAgeCounts();

            Assert.AreEqual(2, result[14]);
            Assert.AreEqual(1, result[4]);
        }

    }
}
