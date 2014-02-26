namespace StopTheBunny
{
    using System;

    public class Score
    {
        private int scorePoints;

        public Score()
        {
        }

        public Score(int score)
        {
            this.ScorePoints = score;
        }

        public int ScorePoints
        {
            get
            {
                return this.scorePoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.scorePoints = value;
            }
        }

        public void AddPoints(int points)
        {
            this.ScorePoints += points;
        }
    }
}