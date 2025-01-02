using CartasianPlane;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point p = new Point(0, 0);
            Point p1 = new Point(3, 4);
            float d = p.DistanceTo(p1);
            Assert.AreEqual(d,5);
        }
    }
}