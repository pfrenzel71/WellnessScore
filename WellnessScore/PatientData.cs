using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WellnessScore.BusinessLogic;

namespace WellnessScore
{
    public partial class PatientData : Form
    {
        public PatientData()
        {
            InitializeComponent();
        }

        private void PatientData_Load(object sender, EventArgs e)
        {
            mtxtExamDate.Text = DateTime.Today.ToString("d");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var p = new Patient
            {
                Name = txtPatientName.Text.Trim(),
                ExamDate = mtxtExamDate.Text,
                ExamNumber = !string.IsNullOrEmpty(mtxtExamNumber.Text) ? int.Parse(mtxtExamNumber.Text.Trim()) : 0, // TODO : Warn the user of invalid entry
                Gender = rdoMale.Checked ? "Male" : "Female",
                Number = !string.IsNullOrEmpty(mtxtPatientNumber.Text.Trim()) ? int.Parse(mtxtPatientNumber.Text.Trim()) : 0 // TODO : Warn the user of invalid entry
            };

            ScoreSheet.p = p;
            this.Hide();

            var scoresheetform = new ScoreSheet();
            scoresheetform.Show();

            
        }
    }
}
