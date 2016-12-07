using FluentAssertions;
using Xunit;

namespace WordWrap_Kata
{
    public class WordWrapTest
    {
        [Fact]
        public void testCreateLines()
        {
            var worte = new[] { "1", "22", "333", "55555" };
            var lineLength = 5;
            string[] result = WordWrap.CreateLines(worte, lineLength);
            result.Should().BeEquivalentTo("1 22", "333", "55555");
        }

        [Fact]
        public void testCreateLines_WordTooLong()
        {
            var worte = new[] { "1", "22", "666666", "55555" };
            var lineLength = 5;
            string[] result = WordWrap.CreateLines(worte, lineLength);
            result.Should().BeEquivalentTo("1 22", "66666", "6", "55555");
        }
    }
}