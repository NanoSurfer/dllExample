using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentNamespace;
using ClassLibrary1;


namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        Student aStudent;

        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aStudent = new Student("1", "Bob", "Gooding", "Proggramming", 1001);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            aStudent.Age = 25;
            txtBoxName.Text = aStudent.ToString();
            txtBoxAge.Text = aStudent.Age.ToString();
            txtBoxStudentId.Text = System.Convert.ToString(aStudent.StudentId);
            txtBoxSleepAmnt.Text = System.Convert.ToString(aStudent.GetSleepAmt());
            txtBoxSleepForMost.Text = System.Convert.ToString(aStudent.CallOverriddenGetSleepAmt());
        }


    }
}
