using CSharpAssignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Employee();
            Assert.IsNull(sut.EMPNAME);
        }
    }
}
