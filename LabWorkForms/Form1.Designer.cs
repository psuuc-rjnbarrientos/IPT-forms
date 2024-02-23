namespace LabWorkForms
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOpenF1 = new System.Windows.Forms.Button();
            this.btnOpenF2 = new System.Windows.Forms.Button();
            this.btnOpenF4 = new System.Windows.Forms.Button();
            this.btnOpenF5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 39);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(543, 37);
            this.txtName.TabIndex = 1;
            // 
            // btnOpenF1
            // 
            this.btnOpenF1.Location = new System.Drawing.Point(71, 109);
            this.btnOpenF1.Name = "btnOpenF1";
            this.btnOpenF1.Size = new System.Drawing.Size(105, 38);
            this.btnOpenF1.TabIndex = 2;
            this.btnOpenF1.Text = "OPEN FORM 2";
            this.btnOpenF1.UseVisualStyleBackColor = true;
            this.btnOpenF1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenF2
            // 
            this.btnOpenF2.Location = new System.Drawing.Point(182, 109);
            this.btnOpenF2.Name = "btnOpenF2";
            this.btnOpenF2.Size = new System.Drawing.Size(105, 38);
            this.btnOpenF2.TabIndex = 2;
            this.btnOpenF2.Text = "OPEN FORM 3";
            this.btnOpenF2.UseVisualStyleBackColor = true;
            this.btnOpenF2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenF4
            // 
            this.btnOpenF4.Location = new System.Drawing.Point(293, 109);
            this.btnOpenF4.Name = "btnOpenF4";
            this.btnOpenF4.Size = new System.Drawing.Size(105, 38);
            this.btnOpenF4.TabIndex = 2;
            this.btnOpenF4.Text = "OPEN FORM 4";
            this.btnOpenF4.UseVisualStyleBackColor = true;
            this.btnOpenF4.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpenF5
            // 
            this.btnOpenF5.Location = new System.Drawing.Point(404, 109);
            this.btnOpenF5.Name = "btnOpenF5";
            this.btnOpenF5.Size = new System.Drawing.Size(105, 38);
            this.btnOpenF5.TabIndex = 2;
            this.btnOpenF5.Text = "OPEN FORM 5";
            this.btnOpenF5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnOpenF5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnOpenF4);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnOpenF2);
            this.panel1.Controls.Add(this.btnOpenF1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 187);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 214);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOpenF1;
        private System.Windows.Forms.Button btnOpenF2;
        private System.Windows.Forms.Button btnOpenF4;
        private System.Windows.Forms.Button btnOpenF5;
        private System.Windows.Forms.Panel panel1;
    }
}

