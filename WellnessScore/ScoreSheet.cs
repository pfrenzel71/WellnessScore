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
    public partial class ScoreSheet : Form
    {
        private Score _scores;
        public static Patient p;

        public ScoreSheet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _scores = new Score("");

            if (!string.IsNullOrEmpty(p.Name))
            {
                try
                {
                    lblPatientNameNumber.Text = lblPatientNameNumber.Text.Replace("[Patient Name]", p.Name)
                        .Replace("[Patient Number]", p.Number.ToString());

                    // TODO: Need to calc the patient's age from todays date
                    //lblPatientAge.Text = lblPatientAge.   

                    lblPatientGender.Text = lblPatientGender.Text.Replace("[Gender]", p.Gender);
                    lblExamNumber.Text = lblExamNumber.Text.Replace("[Exam Number]", p.ExamNumber.ToString());
                    lblExamDate.Text = lblExamDate.Text.Replace("[Exam Date]", p.ExamDate);
                    lblDrsName.Text = lblDrsName.Text.Replace("[Dr Name]", Score.DRsNAME);
                    lblLetterHead.Text = lblLetterHead.Text.Replace("[Dr Name]", Score.DRsNAME);
                }
                catch (Exception exception)
                {
                    //TODO : Catch Exception
                    Console.WriteLine(exception);
                    throw;
                }

            }
        }

        private void btnCalculateScore_Click(object sender, EventArgs e)
        {
            var stats = _scores.GetStatistics();
            txtScore.Text = stats.Letter.ToString() + "-" + stats.Average;
        }

        private void cboLine1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cboLine1.Text))
                {
                    var score = double.Parse(cboLine1.Text);
                    _scores.AddScore(score);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void cboLine2_SelectedIndexChanged(object sender, EventArgs e)

        
        {
            try
            {
                if (!string.IsNullOrEmpty(cboLine2.Text))
                {
                    var score = double.Parse(cboLine2.Text);
                    _scores.AddScore(score);
                }

                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void cboLine3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cboLine3.Text))
                {
                    var score = double.Parse(cboLine3.Text);
                    _scores.AddScore(score);
                }
                else
                {
                   
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void cboLine4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cboLine4.Text))
                {
                    var score = double.Parse(cboLine4.Text);
                    _scores.AddScore(score);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }

        private void cboLine5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cboLine5.Text))
                {
                    var score = double.Parse(cboLine5.Text);
                    _scores.AddScore(score);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }
    }
}
