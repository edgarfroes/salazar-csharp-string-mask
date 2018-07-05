using Salazar.CSharp.String.Mask;
using Xunit;

namespace Tests
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