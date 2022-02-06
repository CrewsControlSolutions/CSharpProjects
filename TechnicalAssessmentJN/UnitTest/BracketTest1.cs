using System;
using TechnicalAssessmentJN;
using Xunit;

// This class contains a series of unit tests for the MatchingSquiglyBrackets method. The tests should be run
// using the xUnit.Net testing framework based on the .NET framework. All tests should pass successfully for
// the method to be considered working.

namespace BracketTests
{
    public class BracketTest1
    {
        // Test a string containing only a single valid (inward facing) squigly bracket pair. Expected result 
        // is True.
        [Fact]
        public void MatchingSquiglyBrackets_ValidSinglePair_ReturnTrue()
        {
            // Arrange
            string input = "{}";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a string containing only a single invalid (outward facing) squigly bracket pair. Expected result 
        // is False.
        [Fact]
        public void MatchingSquiglyBrackets_InvalidSinglePair_ReturnFalse()
        {
            // Arrange
            string input = "}{";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.False(result);
        }

        // Test a string containing a single left-side squigly bracket next to a valid (inward facing) squigly
        // bracket pair. Expected result is False.
        [Fact]
        public void MatchingSquiglyBrackets_SingleLeftBracketWithValidPair_ReturnFalse()
        {
            // Arrange
            string input = "{{}";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.False(result);
        }

        // Test an empty string. Expected result is True.
        [Fact]
        public void MatchingSquiglyBrackets_EmptyString_ReturnTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a string containing a single valid (inward facing) squigly bracket pair. This pair contains
        // letters and special characters (but no squigly brackets) on the inside. Expected result is True.
        [Fact]
        public void MatchingSquiglyBrackets_ValidPairCharactersNotSquiglyBracketsInside_ReturnTrue()
        {
            // Arrange
            string input = "{abc...xyz}";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a string containing double pairs of valid (inward facing) squigly brackets, each pair adjacent
        // to each other. Expected result is True.
        [Fact]
        public void MatchingSquiglyBrackets_ValidPairsAdjacent_ReturnTrue()
        {
            // Arrange
            string input = "{}{}";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a string containing double pairs of valid (inward facing) squigly brackets, one pair nested
        // inside the other. Expected result is True.
        [Fact]
        public void MatchingSquiglyBrackets_ValidPairNestedInsideValidPair_ReturnTrue()
        {
            // Arrange
            string input = "{{}}";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a string containing only special characters, but not including squigly brackets. Expected
        // result is True.
        [Fact]
        public void MatchingSquiglyBrackets_SpecialCharactersNotSquiglyBrackets_ReturnTrue()
        {
            // Arrange
            string input = "~`!@#$%^&*()-_=+[]\\|;:'\",<.>/?";

            // Act
            bool result = BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            Assert.True(result);
        }

        // Test a null value as having been passed into the method. Expected result is a thrown
        // NullReferenceException error.
        [Fact]
        public void MatchingSquiglyBrackets_Null_ReturnException()
        {
            // Arrange
            string input = null;

            // Act
            Action act = () => BracketChecker.MatchingSquiglyBrackets(input);

            // Assert
            NullReferenceException exception = Assert.Throws<NullReferenceException>(act);
        }
    }
}
