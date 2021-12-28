
namespace MultiQueueSimulation
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumOfServers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radbtnSimEndTime = new System.Windows.Forms.RadioButton();
            this.radbtnNumCust = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radbtnLeastUti = new System.Windows.Forms.RadioButton();
            this.radbtnRandom = new System.Windows.Forms.RadioButton();
            this.radbtnHighPer = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.txtStoppingNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtNumOfServers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Servers";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumOfServers
            // 
            this.txtNumOfServers.Location = new System.Drawing.Point(161, 43);
            this.txtNumOfServers.Name = "txtNumOfServers";
            this.txtNumOfServers.Size = new System.Drawing.Size(100, 22);
            this.txtNumOfServers.TabIndex = 1;
            this.txtNumOfServers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumOfServers_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Servers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtStoppingNumber);
            this.groupBox3.Controls.Add(this.radbtnSimEndTime);
            this.groupBox3.Controls.Add(this.radbtnNumCust);
            this.groupBox3.Location = new System.Drawing.Point(12, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 155);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stopping ";
            // 
            // radbtnSimEndTime
            // 
            this.radbtnSimEndTime.AutoSize = true;
            this.radbtnSimEndTime.Location = new System.Drawing.Point(20, 83);
            this.radbtnSimEndTime.Name = "radbtnSimEndTime";
            this.radbtnSimEndTime.Size = new System.Drawing.Size(158, 21);
            this.radbtnSimEndTime.TabIndex = 1;
            this.radbtnSimEndTime.TabStop = true;
            this.radbtnSimEndTime.Text = "Simulation End Time";
            this.radbtnSimEndTime.UseVisualStyleBackColor = true;
            // 
            // radbtnNumCust
            // 
            this.radbtnNumCust.AutoSize = true;
            this.radbtnNumCust.Location = new System.Drawing.Point(20, 33);
            this.radbtnNumCust.Name = "radbtnNumCust";
            this.radbtnNumCust.Size = new System.Drawing.Size(164, 21);
            this.radbtnNumCust.TabIndex = 0;
            this.radbtnNumCust.TabStop = true;
            this.radbtnNumCust.Text = "Number of customers";
            this.radbtnNumCust.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radbtnLeastUti);
            this.groupBox2.Controls.Add(this.radbtnRandom);
            this.groupBox2.Controls.Add(this.radbtnHighPer);
            this.groupBox2.Location = new System.Drawing.Point(387, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection method";
            // 
            // radbtnLeastUti
            // 
            this.radbtnLeastUti.AutoSize = true;
            this.radbtnLeastUti.Location = new System.Drawing.Point(20, 112);
            this.radbtnLeastUti.Name = "radbtnLeastUti";
            this.radbtnLeastUti.Size = new System.Drawing.Size(129, 21);
            this.radbtnLeastUti.TabIndex = 2;
            this.radbtnLeastUti.TabStop = true;
            this.radbtnLeastUti.Text = "Least Utilization";
            this.radbtnLeastUti.UseVisualStyleBackColor = true;
            // 
            // radbtnRandom
            // 
            this.radbtnRandom.AutoSize = true;
            this.radbtnRandom.Location = new System.Drawing.Point(20, 74);
            this.radbtnRandom.Name = "radbtnRandom";
            this.radbtnRandom.Size = new System.Drawing.Size(82, 21);
            this.radbtnRandom.TabIndex = 1;
            this.radbtnRandom.TabStop = true;
            this.radbtnRandom.Text = "Random";
            this.radbtnRandom.UseVisualStyleBackColor = true;
            this.radbtnRandom.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radbtnHighPer
            // 
            this.radbtnHighPer.AutoSize = true;
            this.radbtnHighPer.Location = new System.Drawing.Point(20, 35);
            this.radbtnHighPer.Name = "radbtnHighPer";
            this.radbtnHighPer.Size = new System.Drawing.Size(125, 21);
            this.radbtnHighPer.TabIndex = 0;
            this.radbtnHighPer.TabStop = true;
            this.radbtnHighPer.Text = "Highest Priority";
            this.radbtnHighPer.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(244, 391);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(164, 50);
            this.btnReadData.TabIndex = 7;
            this.btnReadData.Text = "Read data from file";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // txtStoppingNumber
            // 
            this.txtStoppingNumber.Location = new System.Drawing.Point(163, 127);
            this.txtStoppingNumber.Name = "txtStoppingNumber";
            this.txtStoppingNumber.Size = new System.Drawing.Size(122, 22);
            this.txtStoppingNumber.TabIndex = 2;
            this.txtStoppingNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoppingNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stopping Number";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 613);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumOfServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbtnSimEndTime;
        private System.Windows.Forms.RadioButton radbtnNumCust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radbtnHighPer;
        private System.Windows.Forms.RadioButton radbtnRandom;
        private System.Windows.Forms.RadioButton radbtnLeastUti;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoppingNumber;
    }
}