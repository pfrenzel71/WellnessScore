using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellnessScore.BusinessLogic
{
    class Exams
    {
        List<Patient> exams;
        
        public Exams()
        {
            exams = new List<Patient>();
        }

        public void AddExam(Patient patient)
        {
            if (!String.IsNullOrEmpty(patient.Name))
            {
                exams.Add(patient);
            }
        }

        public List<Patient> GetExamData()
        {
            return exams;
        }
    }
}
