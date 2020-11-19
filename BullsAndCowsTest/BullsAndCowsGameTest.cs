using BullsAndCows;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_create_BullsAndCowsGame()
        {
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);
            Assert.NotNull(game);
            Assert.True(game.CanContinue);
        }

        [Fact]
        public void ShouldReturn0A0BGivenAllDigitAndWrongPosition()
        {
            // given
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess("5 6 7 8");
            // then
            Assert.Equal("0A0B", answer);
        }

        [Fact]
        public void ShouldReturn4A0BGivenAllDigitAndRightPosition()
        {
            // given
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess("1 2 3 4");
            // then
            Assert.Equal("4A0B", answer);
        }

        [Fact]
        public void ShouldReturn0A4BGivenAllDigitCorrectAndAllPositionWrong()
        {
            // given
            // var secretGenerator = new SecretGenerator();
            var secretGenerator = new TestSecretGenerator();
            var game = new BullsAndCowsGame(secretGenerator);

            // when
            string answer = game.Guess("4 3 2 1");
            // then
            Assert.Equal("0A4B", answer);
        }
    }

    public class TestSecretGenerator : SecretGenerator
    {
        public override string GenerateSecret()
        {
            return "1234";
        }
    }
}
