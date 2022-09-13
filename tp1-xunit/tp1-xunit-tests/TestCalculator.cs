using tp1_xunit;

namespace tp1_xunit_tests
{
    public class TestCalculator
    {
        [Fact]
        public void AddTest()
        {
            Assert.Equal(11, Calculator.Add(5, 6));
            Assert.Equal(31.3, Calculator.Add(15.1, 16.2));
        }

        [Fact]
        public void SubTest()
        {
            Assert.Equal(6, Calculator.Sub(11, 5));
            Assert.Equal(-3, Calculator.Sub(5, 8));
            Assert.Equal(13.1, Calculator.Sub(20.1, 7));
        }

        [Fact]
        public void MulTest()
        {
            Assert.Equal(12, Calculator.Mul(3, 4));
            Assert.Equal(6.6, Calculator.Mul(3.3, 2));
        }

        [Fact]
        public void DivTest()
        {
            Assert.Equal(7, Calculator.Div(21, 3));
            Assert.Equal(2.5, Calculator.Div(5, 2));
        }

        [Fact]
        public void DivByZeroTest()
        {
            static void act() => Calculator.Div(5, 0);

            var ex = Assert.Throws<DivideByZeroException>(act);

            Assert.Equal("Attempted to divide by zero.", ex.Message);
        }
    }
}
