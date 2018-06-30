using Xunit;

namespace IntervieweQuestions
{
    public class OperatorOverloadTests
    {
        [Fact]
        public void Add_Two_Objects()
        {
            var boxA = new Box()
            {
                Height = 10,
                Width = 10
            };
            var boxB = new Box()
            {
                Height = 10,
                Width = 10
            };

            var result = boxA + boxB;

            Assert.Equal(200, result.Area);
        }
    }
}
