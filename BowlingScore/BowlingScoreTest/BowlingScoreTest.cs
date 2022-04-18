using NUnit.Framework;
using BowlingGame;

namespace BowlingScoreTest
{
    [TestFixture]
    public class BowlingScoreTest
    {
        Game game = new Game();

        [Test]
        public void Test_NoPinDownScenario()
        {
            rollBallMultipleTimes(20, 0);
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void Test_FivePinDownScenario()
        {
            game.RollBall(5);
            rollBallMultipleTimes(19, 0);
            Assert.AreEqual(5, game.Score);
        }

        [Test]
        public void Test_OneSpare()
        {
            game.RollBall(5);
            game.RollBall(5);
            game.RollBall(3);

            rollBallMultipleTimes(17, 0);
            Assert.AreEqual(16, game.Score);
        }

        [Test]
        public void Test_Strike()
        {
            game.RollBall(10);
            rollBallMultipleTimes(19, 0);
        }


        private void rollBallMultipleTimes(int numberOfRolls, int pinsDown)
        {
            for (int i = 0; i <= numberOfRolls; i++)
            {
                game.RollBall(pinsDown);
            }
        }
    }
}