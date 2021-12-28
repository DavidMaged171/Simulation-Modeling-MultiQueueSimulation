namespace MultiQueueSimulation
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InterarrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.txtInterarrival = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddData);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtProbability);
            this.groupBox2.Controls.Add(this.txtInterarrival);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interarrival Time Destribution";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(29, 212);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(107, 72);
            this.btnAddData.TabIndex = 5;
            this.btnAddData.Text = "Add Data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTime,
            this.probability});
            this.dataGridView1.Location = new System.Drawing.Point(161, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 355);
            this.dataGridView1.TabIndex = 4;
            // 
            // InterarrivalTime
            // 
            this.InterarrivalTime.HeaderText = "Interarrival Time";
            this.InterarrivalTime.MinimumWidth = 6;
            this.InterarrivalTime.Name = "InterarrivalTime";
            this.InterarrivalTime.Width = 125;
            // 
            // probability
            // 
            this.probability.HeaderText = "Probability";
            this.probability.MinimumWidth = 6;
            this.probability.Name = "probability";
            this.probability.Width = 125;
            // 
            // txtProbability
            // 
            this.txtProbability.Location = new System.Drawing.Point(29, 145);
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(107, 22);
            this.txtProbability.TabIndex = 3;
            this.txtProbability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProbability_KeyPress);
            // 
            // txtInterarrival
            // 
            this.txtInterarrival.Location = new System.Drawing.Point(29, 81);
            this.txtInterarrival.Name = "txtInterarrival";
            this.txtInterarrival.Size = new System.Drawing.Size(107, 22);
            this.txtInterarrival.TabIndex = 2;
            this.txtInterarrival.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterarrival_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Interarrival Time";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(747, 111);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(187, 68);
            this.btnSetup.TabIndex = 2;
            this.btnSetup.Text = "Setup Configuration";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(747, 283);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 68);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start System";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 454);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.TextBox txtProbability;
        private System.Windows.Forms.TextBox txtInterarrival;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnStart;
    }
}

