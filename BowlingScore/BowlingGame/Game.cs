namespace BowlingGame
{
    public class Game
    {
        private readonly int[] rolls = new int[21];
        private int currentRoll = 0;
        public Game()
        {
            rolls[currentRoll] = 0;
        }
        public void RollBall(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score 
        {
            get 
            {
                int score = 0;
                int frameIndex = 0;
                for (int frame = 0; frame < 10; frame++)
                {
                    if (rolls[frameIndex] == 10) // Strike case
                    {
                        score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                        frameIndex++;
                    }
                    else if (rolls[frameIndex] + rolls[frameIndex + 1] == 10) // Spare case
                    {
                        score = score + 10 + rolls[frameIndex + 2];
                        frameIndex += 2;
                    }
                    else
                    {
                        score += rolls[frameIndex] + rolls[frameIndex + 1];
                        frameIndex += 2;
                    }
                }
                return score;
            }
        }
    }
}