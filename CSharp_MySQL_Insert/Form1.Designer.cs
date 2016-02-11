namespace CSharp_MySQL_Insert
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMobile = new System.Windows.Forms.TextBox();
            this.txtBoxGender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to MySQL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxGender);
            this.groupBox1.Controls.Add(this.txtBoxMobile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.txtBoxLName);
            this.groupBox1.Controls.Add(this.txtBoxFName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Record into Database";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(267, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(348, 331);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(94, 107);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(329, 20);
            this.txtBoxEmail.TabIndex = 5;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(94, 55);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(329, 20);
            this.txtBoxLName.TabIndex = 4;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(94, 29);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(329, 20);
            this.txtBoxFName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mobile No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course:";
            // 
            // txtBoxMobile
            // 
            this.txtBoxMobile.Location = new System.Drawing.Point(94, 81);
            this.txtBoxMobile.Name = "txtBoxMobile";
            this.txtBoxMobile.Size = new System.Drawing.Size(329, 20);
            this.txtBoxMobile.TabIndex = 8;
            // 
            // txtBoxGender
            // 
            this.txtBoxGender.Location = new System.Drawing.Point(94, 133);
            this.txtBoxGender.Name = "txtBoxGender";
            this.txtBoxGender.Size = new System.Drawing.Size(329, 20);
            this.txtBoxGender.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Location = new System.Drawing.Point(94, 159);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(329, 20);
            this.txtBoxCourse.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "MySQL Insert";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxGender;
        private System.Windows.Forms.TextBox txtBoxMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

