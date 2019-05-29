using System;
using Company;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyTest
{
    [TestClass]
    public class UnitTestTeam
    {
        [TestMethod]
        public void TeamTest()
        {
            Team t = new Team("FirstTeam", "FirstProject");
            Assert.AreEqual(1, t.CountTeams);
        }

        [TestMethod]
        public void AddRemoveTest()
        {
            Team t = new Team("FirstTeam", "FirstProject");
            t.Add("Maria", "Sharapova", 33, "Apple");
            t.Add("Vladimir", "Klichko", 25, "Microsoft");
            t.Add("Max", "Korzh", 28, "Google");
            t.Remove(1);
            Assert.AreEqual(2, t.CountMembers);
        }
    }

    [TestClass]
    public class UnitTestProject
    {
        [TestMethod]
        public void SomeProjectTest()
        {
            Team t = new Team("FirstTeam", "FirstProject");
            string expected = "FirstProject";
            SomeProject sp = null;
            string actual = sp.NameOfProject;
            Assert.AreEqual(expected, actual);
        }
    }
}
