namespace Xteniox.Tests
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void ShouldConvertDecimalToInt()
        {
            decimal value = 123.45M;
            var cents = value.ToCents();

            Assert.AreEqual(expected: 12345, actual: cents);
        }
    }
}
