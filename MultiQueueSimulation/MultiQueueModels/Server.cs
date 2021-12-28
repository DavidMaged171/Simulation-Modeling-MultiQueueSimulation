using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }

        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }

        public List<TimeDistribution> TimeDistribution;

        
        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }

        public int custNO;
        public void GetTimeDestribiotions(List<TimeDistribution> TD)
        {
            TD[0].CummProbability = TD[0].Probability;
            TD[0].MinRange = 1;
            TD[0].MaxRange = (int)(TD[0].CummProbability * 100);
            for (int i = 1; i < TD.Count; i++)
            {
                TD[i].CummProbability = TD[i - 1].CummProbability + TD[i].Probability;
                TD[i].MinRange = TD[i - 1].MaxRange + 1;
                TD[i].MaxRange = (int)(TD[i].CummProbability * 100);

            }
        }
    }
}
