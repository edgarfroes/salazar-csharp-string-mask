using Salazar.CSharp;
using Xunit;

namespace tests
{
    public class BasicTests
    {
        [Fact]
        public void CantExceedMaskLengthTest()
        {
            Assert.Equal("1,2", "12345".ToMask("#,#"));
        }
    }
}