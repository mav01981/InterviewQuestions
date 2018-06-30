using Xunit;

namespace InterviewQuestions.SortedSearch
{
    public static class SortSearch
    {
        public static int CountNumbers(int[] array, int max)
        {
            int counter = 0;

            foreach (var number in array)
            {
                counter = number < max ? (counter + 1) : counter + 0;
            }

            return counter;
        }
    }
    /// <summary>
    /// Implement function CountNumbers that accepts a sorted array of integers 
    /// and counts the number of array elements that are less than the parameter lessThan.
    /// </summary>
    public class SortedSearchTest
    {
        [Fact]
        public void Number_Of_Items_LessThan()
        {
            var array = new int[] { 1, 3, 5, 8 };

            Assert.Equal(2, SortSearch.CountNumbers(array, 4));
        }
    }
}
