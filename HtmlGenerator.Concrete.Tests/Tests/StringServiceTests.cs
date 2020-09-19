using System.Linq;
using FluentAssertions;
using HtmlGenerator.Presets.HtmlCodePresets;
using NUnit.Framework;

namespace HtmlGenerator.Concrete.Tests.Tests
{
    [TestFixture]
    public class StringServiceTests
    {
        [Test]
        public void String_Split_By_Capitals_Test()
        {
            var str = "ThisIsTestString/";
            var split = Body.SplitOnCapitals(str.Remove(str.Length - 1)).ToList();
            split[0].Should().Be("This");
            split[1].Should().Be("Is");
            split[2].Should().Be("Test");
            split[3].Should().Be("String");
        }

        [Test]
        public void String_Split_By_Capitals_Join_Test2()
        {
            var str = "ThisIsTestString/";
            var formatted = Body.FormatFolderName(str);
            formatted.Should().Be("This Is Test String");
        }
    }
}