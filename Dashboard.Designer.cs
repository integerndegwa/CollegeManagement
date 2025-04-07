namespace CollegeManagement
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.lblCount3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.lblCount1);
            this.panel1.Location = new System.Drawing.Point(234, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.lblCount2);
            this.panel2.Location = new System.Drawing.Point(234, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.lblCount3);
            this.panel3.Location = new System.Drawing.Point(234, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount1.Location = new System.Drawing.Point(64, 23);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(27, 29);
            this.lblCount1.TabIndex = 0;
            this.lblCount1.Text = "0";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount2.Location = new System.Drawing.Point(64, 41);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(27, 29);
            this.lblCount2.TabIndex = 1;
            this.lblCount2.Text = "0";
            // 
            // lblCount3
            // 
            this.lblCount3.AutoSize = true;
            this.lblCount3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount3.Location = new System.Drawing.Point(64, 40);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(27, 29);
            this.lblCount3.TabIndex = 1;
            this.lblCount3.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.Label lblCount3;
    }
}