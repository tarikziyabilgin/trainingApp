using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class TrainingProgram
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusEnum Status { get; set; }
        public List<SubTraining> SubTrainingList { get; set; }
    }
}
