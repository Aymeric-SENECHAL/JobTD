using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercicesTDD;

namespace ExercicesTDDTests
{
    [TestClass]
    public class BonjourTests
    {
        [TestMethod]
        public void TestSaluer_shouldReturnBonjourName()
        {
            //ARRANGE
            string nameChoisi = "Cloud";
            Bonjour bonjour = new Bonjour();
            string expected = "Bonjour, Cloud";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSaluer_nameIsNullOrEmpty_ShouldReturnBonjourAmi()
        {
            //ARRANGE
            string nameChoisi = null;
            Bonjour bonjour = new Bonjour();
            string expected = "Bonjour, l'ami";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSaluer_nameIsNullOrEmpty_ShouldReturnBonjourNAME()
        {
            //ARRANGE
            string nameChoisi = "BARRET";
            Bonjour bonjour = new Bonjour();
            string expected = "BONJOUR, BARRET";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSaluer_thereIsTwoNames_ShouldReturnBonjourTwoNames()
        {
            //ARRANGE
            string nameChoisi = "Tifa, Aerith";
            Bonjour bonjour = new Bonjour();
            string expected = "Bonjour, Tifa et Aerith";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSaluer_thereIsInfiniteNames_ShouldReturnBonjourInfiniteNames()
        {
            //ARRANGE
            string nameChoisi = "Cloud, Tifa, Aerith";
            //string nameChoisi = "Cloud, Tifa, Aerith, Theo, Leo, Rachel";
            Bonjour bonjour = new Bonjour();
            string expected = "Bonjour, Cloud, Tifa et Aerith";
            //string expected = "Bonjour, Cloud, Tifa, Aerith, Theo, Leo et Rachel";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSaluer_thereIsNamesCries_ShouldReturnBonjourNamesCries()
        {
            //ARRANGE
            string nameChoisi = "Tifa, BARRET, Aerith";
            Bonjour bonjour = new Bonjour();
            string expected = "Bonjour, Tifa et Aerith. ET BONJOUR BARRET";
            string result;

            //ACT
            result = bonjour.saluer(nameChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

    }
}
