using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessScore.BusinessLogic
{
    class Score
    {
        List<double> scores;
        private string Name { get; set; }
        public const string DRsNAME = "Dr. John Smith";

        public Score(string name)
        {
            scores = new List<double>();
            Name = name;
        }

        public void AddScore(double score)
        {
            // Per requirements the grade must be higher than 0 and lower than 100
            if (score >= 0 && score <= 100)
            {
                scores.Add(score);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(Name)}");
            }
        }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            for (var i = 0; i < scores.Count; i++)
            {
                result.High = Math.Max(scores[i], result.High);
                result.Low = Math.Min(scores[i], result.Low);
                result.Average += scores[i];
            }

            result.Average /= scores.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;

        }
    }
}
