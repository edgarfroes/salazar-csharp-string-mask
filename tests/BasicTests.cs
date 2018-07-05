using csharp_string_mask;
using Xunit;

namespace tests
{
    public class BasicTests
    {
        [Fact]
        public void ExceededInputTest()
        {
            Assert.Equal("1,2345", "12345".ToMask("#,#"));
        }
    }
}