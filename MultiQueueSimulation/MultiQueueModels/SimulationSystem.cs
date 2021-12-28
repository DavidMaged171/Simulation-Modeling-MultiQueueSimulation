using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {

        int Min = 1;
        int Max = 101;
        public int simulationTime;
        Queue<int> Q;
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
            this.Q = new Queue<int>();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        public void GetTimeDestribiotions(List<TimeDistribution>TD)
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

        private int GetInterrivalTime(int randDigit)
        {
            int T = 0;
            for (int i = 0; i < InterarrivalDistribution.Count; i++)
            {
                if (randDigit >= InterarrivalDistribution[i].MinRange && randDigit <= InterarrivalDistribution[i].MaxRange)
                {
                    T = InterarrivalDistribution[i].Time;
                    break;
                }
            }
            return T;
        }

        private int AvailableServer(int custArrivalTime)
        {
            int availableServer = -1;
            //High Periority

            if(SelectionMethod==Enums.SelectionMethod.HighestPriority)
            {
                int ID = -1;
                List<Server> sortedServers = Servers.OrderBy(server => server.ID).ToList<Server>();
                for(int i=0;i<sortedServers.Count;i++)
                {
                    if(sortedServers[i].FinishTime<=custArrivalTime)
                    {
                        ID = sortedServers[i].ID;
                        break;
                    }
                }
                for(int i=0;i<Servers.Count;i++)
                {
                    if(Servers[i].ID==ID)
                    {
                        availableServer = i;
                    }
                }
            }
            //Random

            else if(SelectionMethod==Enums.SelectionMethod.Random)
            {
                for (int i = 0; i < Servers.Count; i++)
                {
                    if (Servers[i].FinishTime <= custArrivalTime)
                    {
                        availableServer = Servers[i].ID;
                    }
                }
            }
            return availableServer;
        }

        private int NearestServer(int custArrivalTime)
        {
            int minTime = Servers[0].FinishTime - custArrivalTime,availableServer=0;
            for(int i=1;i<Servers.Count;i++)
            {
                if(Servers[i].FinishTime-custArrivalTime<minTime)
                {
                    minTime = Servers[i].FinishTime - custArrivalTime;
                    availableServer = i;
                }
            }
            return availableServer;
        }

        private int GetServiceTime(int randService,int serverIndex)
        {
            int Time = 0;
            for(int i=0;i<Servers[serverIndex].TimeDistribution.Count;i++)
            {
                if(randService>= Servers[serverIndex].TimeDistribution[i].MinRange&&
                   randService <= Servers[serverIndex].TimeDistribution[i].MaxRange)
                {
                    Time = Servers[serverIndex].TimeDistribution[i].Time;
                    break;
                }
            }
            return Time;
        }

        private void SystemPerformance(int custNo)
        {
            decimal waitedCustomers = 0, WaitedTime = 0;
            for (int i = 0; i < SimulationTable.Count; i++)
            {
                if (SimulationTable[i].TimeInQueue > 0)
                {
                    ++waitedCustomers;
                    WaitedTime += SimulationTable[i].TimeInQueue;
                }
            }
            
            PerformanceMeasures.AverageWaitingTime = WaitedTime / custNo;
            PerformanceMeasures.WaitingProbability = waitedCustomers / custNo;

        }

        private void ServerPerformance(int custNo,decimal SimTime)
        {
            for(int i=0;i<Servers.Count;i++)
            {
                Servers[i].IdleProbability= (decimal)(SimTime - Servers[i].TotalWorkingTime) / (decimal)(SimTime);
                try
                {
                    Servers[i].AverageServiceTime = (decimal)(Servers[i].TotalWorkingTime) / (decimal)(Servers[i].custNO);
                }
                catch
                {
                    Servers[i].AverageServiceTime = 0;
                }
                    
                Servers[i].Utilization = (decimal)(Servers[i].TotalWorkingTime) / (decimal)(SimTime);


                Console.Write("Server ID: ");Console.WriteLine(i.ToString());
                Console.Write("Idel Prop: "); Console.WriteLine(Servers[i].IdleProbability.ToString());
                Console.Write("Average Serv : "); Console.WriteLine(Servers[i].AverageServiceTime.ToString());
                Console.Write("Utilization: "); Console.WriteLine(Servers[i].Utilization.ToString());
                Console.WriteLine("----------------------------------");

            }
            /*
             * foreach(Server server in Servers)
            {
                try
                {
                    server.IdleProbability = (decimal)(SimTime - server.TotalWorkingTime) / (decimal)(SimTime);
                }
                catch
                {
                    server.AverageServiceTime = 0;
                }
                server.Utilization = (decimal)(server.TotalWorkingTime) / (decimal)(SimTime);
            }
            */
        }
        public void StartSystem()
        {
            
            GetTimeDestribiotions(InterarrivalDistribution);
            
            int i;
            for(i=0;i<NumberOfServers;i++)
            {
                GetTimeDestribiotions(Servers[i].TimeDistribution);
                List<TimeDistribution> TD = Servers[i].TimeDistribution;
                
            }
            Random rand = new Random();
             i = 0;
            simulationTime = 0;
            int maxQlength = 0;
            
            while (true)
            {
                
                int custNo = i+1,maxQLength=0;

                //if(custNo==0)=>time=0
                int RandInterArrival = rand.Next(Min, Max);
                int interarrival = GetInterrivalTime(RandInterArrival);
                int arrivalTime;
                if (i > 0)
                    arrivalTime = SimulationTable[i - 1].ArrivalTime + interarrival;
                else arrivalTime = 0;

                int randService = rand.Next(Min, Max);

                //assign server to a cust

                int availableServer = AvailableServer(arrivalTime);
                if(availableServer==-1)
                {
                    availableServer = NearestServer(arrivalTime);
                }
                Servers[availableServer].custNO++;
                int QTime = Math.Max(0, Servers[availableServer].FinishTime - arrivalTime),
                    ServiceBeginTime = arrivalTime + QTime,
                    serviceTime = GetServiceTime(randService, availableServer),
                    endTime = ServiceBeginTime + serviceTime;
                //Set The end time for available server

                Servers[availableServer].FinishTime = endTime;
                Servers[availableServer].TotalWorkingTime += serviceTime;

                if (StoppingCriteria == Enums.StoppingCriteria.SimulationEndTime && endTime > StoppingNumber)
                    break;


                simulationTime = endTime;

                if (Q.Count > 0 && Q.Peek() <= arrivalTime)
                    Q.Dequeue();
                if (QTime > 0)
                {
                    Q.Enqueue(ServiceBeginTime);
                }
                maxQlength = Math.Max(maxQlength, Q.Count);
                //Fill Simulation Case
                SimulationCase SC = new SimulationCase();

                SC.CustomerNumber = custNo;SC.RandomInterArrival = RandInterArrival;
                SC.InterArrival = interarrival;SC.ArrivalTime = arrivalTime;
                SC.RandomService = randService;SC.StartTime = ServiceBeginTime;
                SC.EndTime = endTime;SC.ServiceTime = serviceTime;
                SC.AssignedServer = Servers[availableServer];SC.TimeInQueue =QTime;

                SimulationTable.Add(SC);
                //End filling Simulation Case

                i++;
                if (StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers && StoppingNumber == i)
                    break;
            }
            PerformanceMeasures.MaxQueueLength = maxQlength;
            ServerPerformance(i, simulationTime);
            SystemPerformance(i);

        }

        
    }
}
