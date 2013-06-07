namespace PresentationGUI
{
    partial class PresentationGUI
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.lblSleep = new System.Windows.Forms.Label();
            this.txtBoxSleepAmnt = new System.Windows.Forms.TextBox();
            this.lblSleepForMost = new System.Windows.Forms.Label();
            this.txtBoxSleepForMost = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 41);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(16, 73);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 13);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "Student ID:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(79, 13);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(79, 41);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(41, 20);
            this.txtBoxAge.TabIndex = 4;
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Location = new System.Drawing.Point(79, 73);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStudentId.TabIndex = 5;
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Location = new System.Drawing.Point(147, 159);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(76, 13);
            this.lblSleep.TabIndex = 6;
            this.lblSleep.Text = "Sleep Amount:";
            // 
            // txtBoxSleepAmnt
            // 
            this.txtBoxSleepAmnt.Location = new System.Drawing.Point(229, 156);
            this.txtBoxSleepAmnt.Name = "txtBoxSleepAmnt";
            this.txtBoxSleepAmnt.Size = new System.Drawing.Size(32, 20);
            this.txtBoxSleepAmnt.TabIndex = 7;
            // 
            // lblSleepForMost
            // 
            this.lblSleepForMost.AutoSize = true;
            this.lblSleepForMost.Location = new System.Drawing.Point(73, 187);
            this.lblSleepForMost.Name = "lblSleepForMost";
            this.lblSleepForMost.Size = new System.Drawing.Size(150, 13);
            this.lblSleepForMost.TabIndex = 8;
            this.lblSleepForMost.Text = "Sleep amount for most people:";
            // 
            // txtBoxSleepForMost
            // 
            this.txtBoxSleepForMost.Location = new System.Drawing.Point(229, 184);
            this.txtBoxSleepForMost.Name = "txtBoxSleepForMost";
            this.txtBoxSleepForMost.Size = new System.Drawing.Size(32, 20);
            this.txtBoxSleepForMost.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(92, 216);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(101, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show Student";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // PresentationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtBoxSleepForMost);
            this.Controls.Add(this.lblSleepForMost);
            this.Controls.Add(this.txtBoxSleepAmnt);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.txtBoxStudentId);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "PresentationGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PresentationGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.TextBox txtBoxSleepAmnt;
        private System.Windows.Forms.Label lblSleepForMost;
        private System.Windows.Forms.TextBox txtBoxSleepForMost;
        private System.Windows.Forms.Button btnShow;
    }
}

