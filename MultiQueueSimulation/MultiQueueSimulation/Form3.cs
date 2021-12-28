using MultiQueueModels;
using MultiQueueTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Form3 : Form
    {
        SimulationSystem system = Form1.system;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            
            List<SimulationCase> SC = system.SimulationTable;
            for (int i = 0; i < SC.Count; i++)
            {
                dataGridView1.Rows.Add(
                    SC[i].CustomerNumber, SC[i].RandomInterArrival, SC[i].InterArrival,
                    SC[i].ArrivalTime, SC[i].RandomService, SC[i].ServiceTime, SC[i].AssignedServer,
                    SC[i].StartTime, SC[i].EndTime, SC[i].TimeInQueue
                    );
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string testingResult = TestingManager.Test(system, Constants.FileNames.TestCase3);
            MessageBox.Show(testingResult);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
