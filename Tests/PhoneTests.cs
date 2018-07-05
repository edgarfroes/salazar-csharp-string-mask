using Salazar.CSharp.String;
using Xunit;

namespace tests
{
    public class PhoneTests
    {
        [Fact]
        public void BrazilianNineAndEightDigitsMaskTest()
        {
            var maskedEightDigts = "1199998888".ToMask("(##) ####-####");

            Assert.Equal("(11) 9999-8888", maskedEightDigts);

            var maskedNineDigits = "11999998888".ToMask("(##) #####-####");

            Assert.Equal("(11) 99999-8888", maskedNineDigits);

            var maskedBothRules = "11999998888".ToMask("(##) #####-####", "(##) ####-####");

            Assert.Equal("(11) 99999-8888", maskedBothRules);
        }
    }
}