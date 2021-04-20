
namespace Tutor_Workshop_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.edtFullName = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.edtStudentNumber = new System.Windows.Forms.TextBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.rbtnCode1 = new System.Windows.Forms.RadioButton();
            this.rbtnCode2 = new System.Windows.Forms.RadioButton();
            this.rbtnCode3 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chbxAttendance = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 32);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(238, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "1. Enter your Name and Surname";
            // 
            // edtFullName
            // 
            this.edtFullName.Location = new System.Drawing.Point(35, 62);
            this.edtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtFullName.Name = "edtFullName";
            this.edtFullName.Size = new System.Drawing.Size(406, 26);
            this.edtFullName.TabIndex = 1;
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(15, 109);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(211, 18);
            this.lblStudentNumber.TabIndex = 2;
            this.lblStudentNumber.Text = "2. Enter your Student Number";
            // 
            // edtStudentNumber
            // 
            this.edtStudentNumber.Location = new System.Drawing.Point(35, 141);
            this.edtStudentNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtStudentNumber.Name = "edtStudentNumber";
            this.edtStudentNumber.Size = new System.Drawing.Size(406, 26);
            this.edtStudentNumber.TabIndex = 2;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Location = new System.Drawing.Point(15, 190);
            this.lblQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(111, 18);
            this.lblQualification.TabIndex = 0;
            this.lblQualification.Text = "3. Qualification";
            // 
            // cmbQualification
            // 
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Items.AddRange(new object[] {
            "HIS",
            "BCAD1",
            "BCAD2"});
            this.cmbQualification.Location = new System.Drawing.Point(35, 224);
            this.cmbQualification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(154, 26);
            this.cmbQualification.TabIndex = 3;
            this.cmbQualification.SelectedIndexChanged += new System.EventHandler(this.cmbQualification_SelectedIndexChanged);
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(15, 271);
            this.lblModuleCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(119, 18);
            this.lblModuleCode.TabIndex = 0;
            this.lblModuleCode.Text = "4. Module Code";
            // 
            // rbtnCode1
            // 
            this.rbtnCode1.AutoSize = true;
            this.rbtnCode1.Location = new System.Drawing.Point(35, 305);
            this.rbtnCode1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCode1.Name = "rbtnCode1";
            this.rbtnCode1.Size = new System.Drawing.Size(14, 13);
            this.rbtnCode1.TabIndex = 4;
            this.rbtnCode1.TabStop = true;
            this.rbtnCode1.UseVisualStyleBackColor = true;
            // 
            // rbtnCode2
            // 
            this.rbtnCode2.AutoSize = true;
            this.rbtnCode2.Location = new System.Drawing.Point(35, 344);
            this.rbtnCode2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCode2.Name = "rbtnCode2";
            this.rbtnCode2.Size = new System.Drawing.Size(115, 22);
            this.rbtnCode2.TabIndex = 5;
            this.rbtnCode2.TabStop = true;
            this.rbtnCode2.Text = "radioButton2";
            this.rbtnCode2.UseVisualStyleBackColor = true;
            // 
            // rbtnCode3
            // 
            this.rbtnCode3.AutoSize = true;
            this.rbtnCode3.Location = new System.Drawing.Point(35, 385);
            this.rbtnCode3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCode3.Name = "rbtnCode3";
            this.rbtnCode3.Size = new System.Drawing.Size(115, 22);
            this.rbtnCode3.TabIndex = 6;
            this.rbtnCode3.TabStop = true;
            this.rbtnCode3.Text = "radioButton3";
            this.rbtnCode3.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 495);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 32);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chbxAttendance
            // 
            this.chbxAttendance.AutoSize = true;
            this.chbxAttendance.Location = new System.Drawing.Point(15, 431);
            this.chbxAttendance.Name = "chbxAttendance";
            this.chbxAttendance.Size = new System.Drawing.Size(298, 22);
            this.chbxAttendance.TabIndex = 9;
            this.chbxAttendance.Text = "I confirm that I attended todays session.";
            this.chbxAttendance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(456, 584);
            this.Controls.Add(this.chbxAttendance);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnCode3);
            this.Controls.Add(this.rbtnCode2);
            this.Controls.Add(this.rbtnCode1);
            this.Controls.Add(this.lblModuleCode);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.edtStudentNumber);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.edtFullName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Tutor Workshop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox edtFullName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox edtStudentNumber;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.RadioButton rbtnCode1;
        private System.Windows.Forms.RadioButton rbtnCode2;
        private System.Windows.Forms.RadioButton rbtnCode3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chbxAttendance;
    }
}

