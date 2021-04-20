using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tutor_Workshop_App
{
    class Students
    {
        //Variable declaration
        string Full_Name, student_Number, Qualification, module_Code;
        bool attendedClass;

        //Constructor for student class
        public Students(string full_Name, string student_Number, string qualification, string module_Code, bool attendedClass)
        {
            Full_Name = full_Name;
            this.student_Number = student_Number;
            Qualification = qualification;
            this.module_Code = module_Code;
            this.attendedClass = attendedClass;
        }
        //Method to to add the student details to the textfile
        public void addToTextfile() {
            //try catch is used to check if the file exists
            DateTime now = DateTime.Today;
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor using append
                StreamWriter sw = File.AppendText("Student_Details.txt");
                //adding to the textfile
                sw.WriteLine(Full_Name + "," + student_Number + "," + Qualification + "," + module_Code+"," +attendedClass+","+ now.ToString("dd/MM/yyyy"));
                //Close the file
                sw.Close();
            }
            catch (Exception we)
            {
                Console.WriteLine("Exception: " + we.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
     
        }
    }
}
