using NUnit.Framework;
using Assignment01;

namespace Assignment01
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle rect = new Rectangle();
        [Test]
        public void Perimeter_of_Integer()
        {
            int a = 5, b = 10;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetPerimeter();
            Assert.AreEqual(res, 30);

        }
        [Test]
        public void Perimeter_of_Positive()
        {
            int a = 50, b = 6;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetPerimeter();
            Assert.AreEqual(res, 112);


        }
        [Test]
        public void Perimeter_of_Negative()
        {
            int a = -5, b = -10;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetPerimeter();
            Assert.AreEqual(res, -30);

        }

        [Test]
        public void Area_of_Integer()
        {
            int a = 55, b = 2;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetArea();
            Assert.AreEqual(res, 110);

        }
        [Test]
        public void Area_of_Positive()
        {
            int a = 20, b = 6;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetArea();
            Assert.AreEqual(res, 120);

        }
        [Test]
        public void Area_of_Negative()
        {
            int a = -6, b = -6;
            rect.SetLength(a);
            rect.SetWidth(b);
            int res = rect.GetArea();
            Assert.AreEqual(res, 36);

        }
    }
}
