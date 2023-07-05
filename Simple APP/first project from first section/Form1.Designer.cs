namespace first_project_from_first_section
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.chk1courses = new System.Windows.Forms.CheckedListBox();
            this.lblcourse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.chk1courses);
            this.groupBox1.Controls.Add(this.lblcourse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbcity);
            this.groupBox1.Controls.Add(this.rdfemale);
            this.groupBox1.Controls.Add(this.rdmale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Group";
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(349, 310);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chk1courses
            // 
            this.chk1courses.CheckOnClick = true;
            this.chk1courses.FormattingEnabled = true;
            this.chk1courses.Items.AddRange(new object[] {
            "AI",
            "ML",
            "OS",
            "C# windows application",
            "Micro Soft Programs ",
            "python",
            "C#",
            "Java",
            "C++"});
            this.chk1courses.Location = new System.Drawing.Point(83, 199);
            this.chk1courses.Name = "chk1courses";
            this.chk1courses.Size = new System.Drawing.Size(154, 139);
            this.chk1courses.TabIndex = 10;
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(17, 214);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(51, 13);
            this.lblcourse.TabIndex = 9;
            this.lblcourse.Text = "Courses :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbcity
            // 
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
            "Mansora",
            "Giza",
            "Cairo",
            "Alex",
            "Other"});
            this.cmbcity.Location = new System.Drawing.Point(83, 163);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(137, 21);
            this.cmbcity.TabIndex = 7;
            this.cmbcity.Text = "Select City";
            this.cmbcity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(83, 118);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(59, 17);
            this.rdfemale.TabIndex = 6;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(83, 95);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(48, 17);
            this.rdmale.TabIndex = 5;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(83, 51);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(137, 20);
            this.txtage.TabIndex = 3;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(17, 54);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(32, 13);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age :";
            this.lblage.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(83, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(137, 20);
            this.txtname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(17, 16);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "User Name :";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(797, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbcity;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chk1courses;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Button btnsubmit;
    }
}

