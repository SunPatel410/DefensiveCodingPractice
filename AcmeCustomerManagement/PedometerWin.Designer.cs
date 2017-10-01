namespace AcmeCustomerManagement
{
    partial class PedometerWin
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtGoalToday = new System.Windows.Forms.TextBox();
            this.txtStepToday = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(397, 24);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(13, 27);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(105, 13);
            this.lblStep.TabIndex = 1;
            this.lblStep.Text = "Step Goal for Today:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(16, 63);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(122, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number of Steps Today:";
            // 
            // txtGoalToday
            // 
            this.txtGoalToday.Location = new System.Drawing.Point(125, 27);
            this.txtGoalToday.Name = "txtGoalToday";
            this.txtGoalToday.Size = new System.Drawing.Size(253, 20);
            this.txtGoalToday.TabIndex = 3;
            // 
            // txtStepToday
            // 
            this.txtStepToday.Location = new System.Drawing.Point(144, 60);
            this.txtStepToday.Name = "txtStepToday";
            this.txtStepToday.Size = new System.Drawing.Size(253, 20);
            this.txtStepToday.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(16, 103);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Result";
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 175);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.txtStepToday);
            this.Controls.Add(this.txtGoalToday);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtGoalToday;
        private System.Windows.Forms.TextBox txtStepToday;
        private System.Windows.Forms.Label ResultLabel;
    }
}