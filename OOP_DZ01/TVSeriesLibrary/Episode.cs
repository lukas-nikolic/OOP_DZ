using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TVSeriesLibrary
{
    public class Episode
    {
        private int viewerCount;
        private double totalScore;
        private double maxScore;

        public Episode()
        {
            viewerCount = 0;
            totalScore = 0.0;
            maxScore = 0.0;
        }
        public Episode(int viewerCount, double totalScore, double maxScore)
        {
            this.viewerCount = viewerCount;
            this.totalScore = totalScore;
            this.maxScore = maxScore;
        }

        public void AddView(double score)
        {
            viewerCount++;
            totalScore += score;
            if (score > maxScore)
            {
                maxScore = score;
            }
        }

        public int GetViewerCount()
        {
            return viewerCount;
        }

        public double GetAverageScore()
        {
            return viewerCount > 0 ? totalScore / viewerCount : 0.0;
        }

        public double GetMaxScore()
        {
            return maxScore;
        }
    }
}
