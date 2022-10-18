using LibForLab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string String = "Работа. ARBAITEN работа РАБОТА Arbaiten";
            string word = "работа";

            int trueCount = 3;
            int count = WordFinder.FindWrd(String, word);

            StringBuilder stringBuilder = new StringBuilder();

            string trueStr = "Работа. работа РАБОТА ";
            stringBuilder = GetRusText.FindRusText(String, stringBuilder);

            byte[] trueBytes = Encoding.GetEncoding(1251).GetBytes(trueStr.ToString());
            byte[] bytes = Encoding.GetEncoding(1251).GetBytes(stringBuilder.ToString());

            Assert.AreEqual(count, trueCount);
            for (int i = 0; i < bytes.Length; i++)
            {
                Assert.AreEqual(bytes[i], trueBytes[i]);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            string String = "This is string. Это строка. String is good. Строка это хорошо.";
            string word = "string";

            int trueCount = 2;
            int count = WordFinder.FindWrd(String, word);

            StringBuilder stringBuilder = new StringBuilder();

            string trueStr = "Это строка. Строка это хорошо.";
            stringBuilder = GetRusText.FindRusText(String, stringBuilder);

            byte[] trueBytes = Encoding.GetEncoding(1251).GetBytes(trueStr.ToString());
            byte[] bytes = Encoding.GetEncoding(1251).GetBytes(stringBuilder.ToString());

            Assert.AreEqual(count, trueCount);
            for (int i = 0; i < bytes.Length - 1; i++)
            {
                Assert.AreEqual(bytes[i], trueBytes[i]);
            }
        }
        [TestMethod]
        public void TestMethod3()
        {
            string String = "Тест";
            string word = "слово";

            int trueCount = 0;
            int count = WordFinder.FindWrd(String, word);

            StringBuilder stringBuilder = new StringBuilder();

            string trueStr = "Тест";
            stringBuilder = GetRusText.FindRusText(String, stringBuilder);

            byte[] trueBytes = Encoding.GetEncoding(1251).GetBytes(trueStr.ToString());
            byte[] bytes = Encoding.GetEncoding(1251).GetBytes(stringBuilder.ToString());

            Assert.AreEqual(count, trueCount);
            for (int i = 0; i < bytes.Length - 1; i++)
            {
                Assert.AreEqual(bytes[i], trueBytes[i]);
            }
        }
    }
}
