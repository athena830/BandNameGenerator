using System;
using System.ComponentModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandNameGenerator
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        [TestMethod]
        public void Input_athena_Shouldbe_Athenathena()
        {
            AssertShouldEqualBandNameGenerator("athena", "Athenathena");
        }

        [TestMethod]
        public void Input_irene_Shouldbe_The_Irene()
        {
            AssertShouldEqualBandNameGenerator("irene", "The Irene");
        }

        [TestMethod]
        public void Input_empty_Shouldbe_empty()
        {
            AssertShouldEqualBandNameGenerator("", string.Empty);
        }

        [TestMethod]
        public void Input_null_Shouldbe_empty()
        {
            AssertShouldEqualBandNameGenerator(null, string.Empty);
        }

        private void AssertShouldEqualBandNameGenerator(string input, string expect)
        {
            var kata = new Kata();
            Assert.AreEqual(expect, kata.GenerateBandName(input));
        }
    }

    public class Kata
    {
        public string GenerateBandName(string name)
        {
            if (string.IsNullOrEmpty(name)) return "";

            return name.First() == name.Last() ? DuplicateLastName(name) : AddTheForBandName(name);
        }

        private string UpperFirstChar(string name)
        {
            return name.First().ToString().ToUpper() + name.Substring(1);
        }

        private string DuplicateLastName(string name)
        {
            return UpperFirstChar(name) + name.Substring(1); ;
        }

        private string AddTheForBandName(string name)
        {
            return "The " + UpperFirstChar(name);
        }
    }
}
