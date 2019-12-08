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
    public partial class Form1 : Form
    {
        private Score _scores;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _scores = new Score("");
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
