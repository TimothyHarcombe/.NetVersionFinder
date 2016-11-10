namespace DotNetVersionFinder
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
            this.oldVersion = new System.Windows.Forms.Button();
            this.newVersion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxVersion = new System.Windows.Forms.RichTextBox();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSP = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // oldVersion
            // 
            this.oldVersion.Location = new System.Drawing.Point(6, 19);
            this.oldVersion.Name = "oldVersion";
            this.oldVersion.Size = new System.Drawing.Size(75, 23);
            this.oldVersion.TabIndex = 0;
            this.oldVersion.Text = "Old Version";
            this.oldVersion.UseVisualStyleBackColor = true;
            this.oldVersion.Click += new System.EventHandler(this.oldVersion_Click);
            // 
            // newVersion
            // 
            this.newVersion.Location = new System.Drawing.Point(164, 19);
            this.newVersion.Name = "newVersion";
            this.newVersion.Size = new System.Drawing.Size(75, 23);
            this.newVersion.TabIndex = 1;
            this.newVersion.Text = "New Version";
            this.newVersion.UseVisualStyleBackColor = true;
            this.newVersion.Click += new System.EventHandler(this.newVersion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oldVersion);
            this.groupBox1.Controls.Add(this.newVersion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the .Net Framework on your workstation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Version = v2, v3 and v3.5\r\n                     or\r\nNew Version = v4 and Newe" +
    "r\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SP";
            // 
            // richTextBoxVersion
            // 
            this.richTextBoxVersion.Location = new System.Drawing.Point(12, 121);
            this.richTextBoxVersion.Name = "richTextBoxVersion";
            this.richTextBoxVersion.ReadOnly = true;
            this.richTextBoxVersion.Size = new System.Drawing.Size(68, 128);
            this.richTextBoxVersion.TabIndex = 6;
            this.richTextBoxVersion.Text = "";
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(86, 121);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.ReadOnly = true;
            this.richTextBoxName.Size = new System.Drawing.Size(125, 128);
            this.richTextBoxName.TabIndex = 7;
            this.richTextBoxName.Text = "";
            // 
            // richTextBoxSP
            // 
            this.richTextBoxSP.Location = new System.Drawing.Point(220, 121);
            this.richTextBoxSP.Name = "richTextBoxSP";
            this.richTextBoxSP.ReadOnly = true;
            this.richTextBoxSP.Size = new System.Drawing.Size(31, 128);
            this.richTextBoxSP.TabIndex = 8;
            this.richTextBoxSP.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 261);
            this.Controls.Add(this.richTextBoxSP);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.richTextBoxVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = ".Net Version Finder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oldVersion;
        private System.Windows.Forms.Button newVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxVersion;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxSP;
    }
}

