using challenges_and_data_structures;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseWords_InputIsProgrammingLanguage_ShouldReturnLanguageProgrammingIsCsharp()
        {
            // Arrange
            var input = "csharp is programming language";
            var expected = "language programming is csharp";

            // Act
            var result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseWords_ReverseTheWordsInThisSentence_ShouldReturnSentenceThisInWordsTheReverse()
        {
            // Arrange
            var input = "Reverse the words in this sentence";
            var expected = "sentence this in words the Reverse";

            // Act
            var result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseWords_ChallengesAndDataStructures_ShouldReturnStructuresDataAndChallenges()
        {
            // Arrange
            var input = "challenges and data structures";
            var expected = "structures data and challenges";

            // Act
            var result = Program.ReverseWords(input);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}