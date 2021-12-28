
namespace MultiQueueSimulation
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randDigits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNo,
            this.randDigits,
            this.interarrivalTime,
            this.arrivalTime,
            this.randService,
            this.serviceTime,
            this.AssignedServer,
            this.startTime,
            this.endTime,
            this.timeInQ});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1565, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // custNo
            // 
            this.custNo.HeaderText = "Customer Number";
            this.custNo.MinimumWidth = 6;
            this.custNo.Name = "custNo";
            this.custNo.Width = 125;
            // 
            // randDigits
            // 
            this.randDigits.HeaderText = "Random digits for arrival";
            this.randDigits.MinimumWidth = 6;
            this.randDigits.Name = "randDigits";
            this.randDigits.Width = 125;
            // 
            // interarrivalTime
            // 
            this.interarrivalTime.HeaderText = "Interarrival Time";
            this.interarrivalTime.MinimumWidth = 6;
            this.interarrivalTime.Name = "interarrivalTime";
            this.interarrivalTime.Width = 125;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.MinimumWidth = 6;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Width = 125;
            // 
            // randService
            // 
            this.randService.HeaderText = "Random service";
            this.randService.MinimumWidth = 6;
            this.randService.Name = "randService";
            this.randService.Width = 125;
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "Service time";
            this.serviceTime.MinimumWidth = 6;
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.Width = 125;
            // 
            // AssignedServer
            // 
            this.AssignedServer.HeaderText = "Assigned server";
            this.AssignedServer.MinimumWidth = 6;
            this.AssignedServer.Name = "AssignedServer";
            this.AssignedServer.Width = 125;
            // 
            // startTime
            // 
            this.startTime.HeaderText = "Start time";
            this.startTime.MinimumWidth = 6;
            this.startTime.Name = "startTime";
            this.startTime.Width = 125;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End Time";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.Width = 125;
            // 
            // timeInQ
            // 
            this.timeInQ.HeaderText = "Time in queue";
            this.timeInQ.MinimumWidth = 6;
            this.timeInQ.Name = "timeInQ";
            this.timeInQ.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn randDigits;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn randService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInQ;
        private System.Windows.Forms.Button button1;
    }
}