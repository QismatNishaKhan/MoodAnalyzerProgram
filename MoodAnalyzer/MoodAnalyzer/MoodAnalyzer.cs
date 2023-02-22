using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerP
{
    public class MoodAnalyzer
    {
        public string message;
        
        public MoodAnalyzer()
        {
        }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.ToUpper().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
