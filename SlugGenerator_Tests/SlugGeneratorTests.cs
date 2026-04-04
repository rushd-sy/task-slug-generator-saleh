using static SlugGenerator.SlugGenerator;

namespace SlugGenerator_Tests
{
    public class SlugGeneratorTests
    {
        [Fact]
        public void Generate_StanderedInputes_SlugText()
        {
            string input = " Hello, World! ";
            string expected = "hello-world";
            string actual = Generate(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Generate_TextIsNull_ThrowArgumentNullException()
        {

            Assert.Throws<ArgumentNullException>(() => Generate(null!));

        }

        [Fact]
        public void Generate_TextIsEmpty_ReturnEmptyString()
        {
            Assert.Equal(string.Empty, Generate(string.Empty));

        }

        [Fact]
        public void Generate_TextIsJustSymbols_ReturnEmptyString()
        {
            Assert.Equal(string.Empty, Generate("#$%&^@"));
        }

        [Fact]
        public void Generate_TextIsArabicCharacters_SlugTextInArabicCharacters()
        {
            string input = "شقة للبيع";
            string expected = "شقة-للبيع";
            string actual = Generate(input);            Assert.Equal(expected, actual);
        }
    }
}
