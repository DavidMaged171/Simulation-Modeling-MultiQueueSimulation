using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using System.IO;
namespace MultiQueueSimulation
{
    public partial class Form4 : Form
    {
        List<Server> Servers;
        int numOfServers;
        public static SimulationSystem system;
        public Form4()
        {
            InitializeComponent();
            system = new SimulationSystem();
        }
        public SimulationSystem GetSystem()
        {
            return system;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            numOfServers = Convert.ToInt32(this.txtNumOfServers.Text);
            Servers = new List<Server>();
            for (int i = 0; i < numOfServers; i++)
            {
                Server server = new Server();
                server.ID = i + 1;
                server.FinishTime = 0;
                server.TotalWorkingTime = 0;

                Form2 form2 = new Form2();
                form2.setTitle(i + 1);
                form2.ShowDialog();
                form2.Close();

                server.TimeDistribution = form2.serverTimeDistributioLlist;
                server.GetTimeDestribiotions(server.TimeDistribution);
                Servers.Add(server);

            }
            system.Servers = Servers;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            //Selection Method
            if (radbtnHighPer.Checked)
                system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (radbtnLeastUti.Checked)
                system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            else
                system.SelectionMethod = Enums.SelectionMethod.Random;

            //Stopping Criteria

            if (radbtnNumCust.Checked)
                system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;

            system.StoppingNumber = int.Parse(txtStoppingNumber.Text.ToString());
            //Num Of servers
            system.NumberOfServers = int.Parse(txtNumOfServers.Text.ToString());
            this.Close();
        }

        private void txtNumOfServers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtStoppingNumber_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
                    {
                        e.Handled = true;
                    }
                }
        private void btnReadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            string path = OFD.FileName;
            system.Servers.Clear();
            system.InterarrivalDistribution.Clear();
            system.SimulationTable.Clear();

            string[] data = File.ReadAllLines(path);

            txtNumOfServers.Text = data[1];

            txtStoppingNumber.Text = data[4];
            //Stopping Creteria
            if (data[7] == "1")
                radbtnNumCust.Checked = true;
            else radbtnSimEndTime.Checked = true;

            //Selection Method
            if (data[10][0] == '1') radbtnHighPer.Checked = true;
            else if (data[10][0] == '2') radbtnRandom.Checked = true;
            else radbtnLeastUti.Checked = true;


            //Data Entry

            int i = 13;//index at the testcase file;
            system.InterarrivalDistribution.Clear();
            while (true)
            {
                if (data[i] == "")
                    break;
                else
                {
                    string[] details = data[i].Split(',',(char)StringSplitOptions.RemoveEmptyEntries);
                    TimeDistribution TD= new TimeDistribution
                    {
                        Time = int.Parse(details[0]),
                        Probability=decimal.Parse(details[1])
                        
                    };
                    system.InterarrivalDistribution.Add(TD);
                    
                }
                i++;
            }
            i += 2;

            int NoOfServers = 1;
            system.Servers.Clear();
            Server server = new Server();
            //Service Time for each server
            for(int j=i;j<data.Length ;j++)
            {
                if(data[j]=="")
                {
                    server.ID = NoOfServers;
                    system.Servers.Add(server);
                    j++;NoOfServers++;
                    server = new Server();

                }
                else
                {
                    string[] details = data[j].Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
                    TimeDistribution TD = new TimeDistribution
                    {
                        Time = int.Parse(details[0]),
                        Probability = decimal.Parse(details[1])

                    };
                    server.TimeDistribution.Add(TD);
                }
                if (j==data.Length-1)
                {
                    server.ID = NoOfServers;
                    system.Servers.Add(server);
                }
            }

        }

        
    }
}
