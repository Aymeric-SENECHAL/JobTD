using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExercicesTDD;

namespace ExercicesTDDTests
{
    [TestClass]
    public class TataYoyoTests
    {
        [TestMethod]
        public void TestAfficherTataYoyo_IsDivisibleBy3_ShouldReturnTata()
        {
            //ARRANGE
            int nbChoisi = 9;
            TataYoyo tataYoyo = new TataYoyo();
            string expected = "Tata";
            string result;

            //ACT
            result = tataYoyo.afficherTataYoyo(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAfficherTataYoyo_IsDivisibleBy5_ShouldReturnYoyo()
        {
            //ARRANGE
            int nbChoisi = 50;
            TataYoyo tataYoyo = new TataYoyo();
            string expected = "Yoyo";
            string result;

            //ACT
            result = tataYoyo.afficherTataYoyo(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAfficherTataYoyo_IsDivisibleBy5And3_ShouldReturnTataYoyo()
        {
            //ARRANGE
            int nbChoisi = 45;
            TataYoyo tataYoyo = new TataYoyo();
            string expected = "Tata Yoyo";
            string result;

            //ACT
            result = tataYoyo.afficherTataYoyo(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAfficherTataYoyo_IsNotDivisibleBy5And3_ShouldReturnNumber()
        {
            //ARRANGE
            int nbChoisi = 47;
            TataYoyo tataYoyo = new TataYoyo();
            string expected = "47";
            string result;

            //ACT
            result = tataYoyo.afficherTataYoyo(nbChoisi);

            //ASSERT
            Assert.AreEqual(expected, result);
        }
    }
}
