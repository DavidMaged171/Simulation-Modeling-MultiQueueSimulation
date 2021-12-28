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
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public Form4 form4;
        public static SimulationSystem system;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            string service = txtInterarrival.Text;
            string prob = txtProbability.Text;
            if(service.Length==0||prob.Length==0)
            {
                MessageBox.Show("Please, Enter Data");
                return;
            }
            
            dataGridView1.Rows.Add(service, prob);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.ShowDialog();
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            system = Form4.system;

            system.GetTimeDestribiotions(system.InterarrivalDistribution);
            

            for(int i=0;i<system.NumberOfServers;i++)
            {
                system.GetTimeDestribiotions(system.Servers[i].TimeDistribution);
            }
            
            system.StartSystem();
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void txtInterarrival_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void txtProbability_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {

        }
        /*List<SimulationCase>buildSimuCaseTable()
   {
   List<SimulationCase> res = new List<SimulationCase>();
   int numOfCustomers = 0;
   while(true)
   {
   SimulationCase Sim = new SimulationCase();
   //check Stopping Criteria
   if (system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers && numOfCustomers > system.StoppingNumber)
     break;
   //else if(system.StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers && numOfCustomers > system.StoppingNumber)

   Sim.CustomerNumber = ++numOfCustomers;
   }
}*/
    }
}
