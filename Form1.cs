using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutor_Workshop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbQualification.SelectedIndex = 0;
            chbxAttendance.Checked = false;
            chbxAttendance.Visible = false;
        }

        private void cmbQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch statement to change the radio buttons from the options of the combobox
            switch (cmbQualification.SelectedIndex)
            {
                case 0:
                    rbtnCode1.Text = "COAR";
                    rbtnCode2.Text = "IQTT";
                    rbtnCode3.Text = "";
                    rbtnCode3.Visible = false;
                    chbxAttendance.Visible = true;
                    break;
                case 1:
                    rbtnCode1.Text = "PROG5121";
                    rbtnCode2.Text = "PRLD5121";
                    rbtnCode3.Text = "MAPC5111";
                    rbtnCode3.Visible = true;
                    chbxAttendance.Visible = true;
                    break;
                case 2:
                    rbtnCode1.Text = "DBAS6211";
                    rbtnCode2.Text = "PROG6211";
                    rbtnCode3.Text = "CLDV6211";
                    rbtnCode3.Visible = true;
                    chbxAttendance.Visible = true;
                    break;
            }
            


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Variable declaration
            string Full_Name,student_Number,Qualification,module_Code="";
            bool attendedClass;

            //getting data from edit boxes and combobox
            Full_Name = edtFullName.Text;
            student_Number = edtStudentNumber.Text;
            Qualification = cmbQualification.SelectedItem.ToString();


            //If statement used to determine which radio button was clicked 
            if (rbtnCode1.Checked == true)
            {
                module_Code = rbtnCode1.Text;
            }
            else if (rbtnCode2.Checked == true)
            {
                module_Code = rbtnCode2.Text;
            }
            else if (rbtnCode3.Checked == true)
            {
                module_Code = rbtnCode3.Text;
            }
            if (chbxAttendance.Checked == true)
            {
                attendedClass = true;
            }
            else 
            {
                attendedClass = false;
            }
            //Constructor 
            Students newStudent = new Students(Full_Name, student_Number, Qualification, module_Code,attendedClass);

            newStudent.addToTextfile();

            //Successful message output
            MessageBox.Show("Submission Received");

            //reset the components
            edtFullName.Text = "";
            edtStudentNumber.Text = "";
            cmbQualification.SelectedIndex = 0;
            chbxAttendance.Checked = false;

        }
    }
}
