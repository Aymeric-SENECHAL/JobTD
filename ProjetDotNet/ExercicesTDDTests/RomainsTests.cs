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
    public class RomainsTests
    {
        [TestMethod]
        public void TestConvertir_isZero_shouldReturnZero()
        {
            //ARRANGE
            int nbChoisi = 0;
            Romains romains = new Romains();
            string expected = "0";
            string result;

            //ACT
            result = romains.convertir(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestConvertir_isNegative_shouldReturnError()
        {
            //ARRANGE
            int nbChoisi = -1;
            Romains romains = new Romains();
            string expected = "Vous devez obligatoirement entrer un nombre suppérieur à 0 différent de null !";
            string result;

            //ACT
            result = romains.convertir(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestConvertir_shouldReturnI()
        {
            //ARRANGE
            int nbChoisi = 1;
            Romains romains = new Romains();
            string expected = "I";
            string result;

            //ACT
            result = romains.convertir(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        [DataRow(10, "X")]
        [DataRow(50, "L")]
        [DataRow(100, "C")]
        [DataRow(500, "D")]
        [DataRow(1000, "M")]
        public void TestConvertir_shouldReturnIToIX(int nbChoisi, string nbRom)
        {
            Romains romains = new Romains();
            Assert.AreEqual(nbRom, romains.convertir(nbChoisi));

        }

        [TestMethod]
        [DataRow(99, "XCIX")]
        [DataRow(502, "DII")]
        public void TestConvertir_shouldReturnValue(int nbChoisi, string nbRom)
        {
            Romains romains = new Romains();
            Assert.AreEqual(nbRom, romains.convertir(nbChoisi));

        }
    }
}
