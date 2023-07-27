using Microsoft.VisualStudio.TestPlatform.TestHost;
using stack_queue_brackets;


namespace stack_queue_brackets
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidBrackets()
        {
            string input = "({})";
            bool result = Program.ValidateBrackets(input);
            Assert.True(result);
        }

        
        [Fact]
        public void TestInvalidBrackets_1()
        {
            string input = "{[()]}}";
            bool result = Program.ValidateBrackets(input);
            Assert.False(result);
        }

        [Fact]
        public void TestInvalidBrackets_2()
        {
            string input = "})]";
            bool result = Program.ValidateBrackets(input);
            Assert.False(result);
        }

        [Fact]
        public void TestInvalidBrackets_3()
        {
            string input = "";
            bool result = Program.ValidateBrackets(input);
            Assert.False(result);
        }
    }
}