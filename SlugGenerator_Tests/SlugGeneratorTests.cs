using SlugGenerator;
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
            string actual = Generate(input); Assert.Equal(expected, actual);
        }

        [Fact]
        public void GenerateUnique_SameInput_ReturnUniqueSlug()
        {
            string input = "Hello World";
            string slug1 = GenerateUnique(input);
            string slug2 = GenerateUnique(input);
            Assert.NotEqual(slug1, slug2);
        }

        [Fact]
        public void ToSlug_InputWithOutSeparator_ReturnSlugSeparatedWithDefaultSeparator()
        {
            string input = "Hello World";
            string slug = SlugExtension.ToSlug(input);

            Assert.Equal("hello-world", slug);
        }

        [Fact]
        public void ToSlug_InputWithSeparator_ReturnSlugSeparatedWithSpecificSeparator()
        {
            string input = "Hello World";
            string slug = SlugExtension.ToSlug(input, '_');

            Assert.Equal("hello_world", slug);

        }

    }
}
