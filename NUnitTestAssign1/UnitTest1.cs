using NUnit.Framework;
using Assign1;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TriangleAnalyze_11_11_11_Returns_Equilateral()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(11, 11, 11), "Equilateral");
        }

        [Test]
        public void TriangleAnalyze_50_50_70_Returns_Isoceles()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(50, 50, 70), "Isoceles");
        }

        [Test]
        public void TriangleAnalyze_10_70_50_Returns_Invalid()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(10, 70, 50), "Invalid");
        }

        [Test]
        public void TriangleAnalyze_1_2_100_Returns_Scalene()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(100, 70, 120), "Scalene");
        }


        [Test]
        public void TriangleAnalyze_Minus1_2_100_Returns_Scalene()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(-1, 2, 100), "Invalid");
        }

        [Test]
        public void TriangleAnalyze_Minus1_Minus2_Minus100_Returns_Scalene()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(-1, -2, -100), "Invalid");
        }

        [Test]
        public void TriangleAnalyze_Minus1_2_3_Returns_Scalene()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(-1, 2, 3), "Invalid");
        }

        [Test]
        public void TriangleAnalyze_20_20_30_Returns_Isoceles()
        {
            Assert.AreEqual(TriangleSolver.TriangleAnalyze(20, 20, 30), "Isoceles");
        }

    }
}