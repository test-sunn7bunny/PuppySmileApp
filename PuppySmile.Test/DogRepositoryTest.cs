using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuppySmile.Infrastructure;

namespace PuppySmile.Test
{
    [TestClass]
    public class DogRepositoryTest
    {
        DogRepository Repo;

        [TestInitialize]

        public void TestSetup()
        {
            DogInitializeDb db = new DogInitializeDb();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new DogRepository();
        }

        [TestMethod]
        public void IsRepositoryInitializeWithValidNumberofData()
        {
            var result = Repo.GetDogs();
            Assert.IsNotNull(result);
            var NumberOfRecords = result.ToList().Count;
            Assert.AreEqual(11, NumberOfRecords);
        }

    }
}
