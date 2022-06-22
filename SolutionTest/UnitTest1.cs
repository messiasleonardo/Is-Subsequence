using Is_Subsequence;
using Xunit;

namespace SolutionTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abc","ahbgdc",true)]
        [InlineData("axc","ahbgdc",false)]
        [InlineData("abc","uiatydbkoic",true)]
        [InlineData("axc","cxa",false)]
        [InlineData("axc","ertazcx",false)]
        [InlineData("","ertazcx",true)]
        [InlineData("twn", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxtxxxxxxxxxxxxxxxxxxxxwxxxxxxxxxxxxxxxxxxxxxxxxxn", true)]
        [InlineData("aaaaaa", "bbaaaa", false)]
        [InlineData("b", "abc", true)]
        public void Test1(string s, string t, bool expected)
        {
            Solution solution = new Solution();

            bool actual = solution.IsSubsequence(s, t);

            Assert.Equal(expected, actual);
        }
    }
}
