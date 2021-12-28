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
namespace MultiQueueSimulation
{
    public partial class Form2 : Form
    {
        public List <TimeDistribution> serverTimeDistributioLlist;
        public  void CalcServerTimeDistribution()
        {

            TimeDistribution timeDistro = new TimeDistribution();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                
                timeDistro.Time = Int32.Parse(row.Cells[0].Value.ToString());
                timeDistro.Probability = decimal.Parse(row.Cells[0].Value.ToString());
                /*if (serverTimeDistributioLlist.Count == 0)
                    timeDistro.CummProbability = timeDistro.Probability;
                else
                    timeDistro.CummProbability = serverTimeDistributioLlist[serverTimeDistributioLlist.Count - 1].Probability;

                if (serverTimeDistributioLlist.Count == 0)
                {
                    timeDistro.MinRange = 1;
                    timeDistro.MaxRange = (int)(timeDistro.CummProbability) * 100;
                }
                else
                {
                    timeDistro.MinRange = (int)serverTimeDistributioLlist[serverTimeDistributioLlist.Count - 1].MaxRange + 1;
                    timeDistro.MaxRange = (int)(timeDistro.CummProbability) * 100;
                }*/
                serverTimeDistributioLlist.Add(timeDistro);
            }

        }

        public Form2()
        {
            InitializeComponent();
        }

        public void setTitle(int x)
        {
            this.Text = "Add server " + x + " Data";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            string service = textBox1.Text;
            string prob = textBox2.Text;
            if (service.Length == 0 || prob.Length == 0)
            {
                MessageBox.Show("Please, Enter Data");
                return;
            }
            dataGridView1.Rows.Add(service, prob);
        }

        private void btnAddServerToList_Click(object sender, EventArgs e)
        {
           serverTimeDistributioLlist = new List<TimeDistribution>();

            CalcServerTimeDistribution();
            this.Hide();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
