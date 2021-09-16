using Xunit;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
     public class RegExprTests
    {
        [Fact]
        public void Split_Line_Returns_True_If_Testlist_Get_Split()
        {
            // Arrange
            List<string> expected = new List<string>();
            expected.Add("She");
            expected.Add("was");
            expected.Add("amazed");
            expected.Add("by");
            expected.Add("ice");
            // Act
            List<string> list = new List<string>();
            list.Add("She was amazed by ice");
            var actual = RegExpr.SplitLine(list);
            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Given_Resolution_Return_Tuples()
        {
            // Arrange
            List<(int, int)> expected = new List<(int, int)> { (1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960) };
            // Act
            string input = "1920x1080 1024x768, 800x600, 640x480 320x200, 320x240, 800x600 1280x960";
            var act = RegExpr.Resolution(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    [Fact]
        public void InnerText_Tag_A()
        {
            // Arrange
            var html = "<div> <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p> </div>";

            var expected = new[] {"theoretical computer science","formal language","characters","pattern","string searching algorithms","strings"};
            // Act
            var actual = RegExpr.InnerText(html,"a");

            // Assert
            Assert.Equal(expected,actual);
        }
         [Fact]
        public void InnerText_Tag_P()
        {
            // Arrange
            var html = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";

            var expected = new[] {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};
            // Act
            var actual = RegExpr.InnerText(html,"p");

            // Assert
            Assert.Equal(expected,actual);
        }
    }
}
