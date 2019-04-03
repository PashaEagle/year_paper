using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using static WindowsFormsApp2.Enums;

namespace WindowsFormsApp2
{
    [DataContract]
    class Experiment
    {
        [DataMember]
        public ExperimentType experimentType { get; set; }
        [DataMember]
        public string result { get; set; }
        [DataMember]
        public string date { get; set; }

        public Experiment(ExperimentType experimentType, string result, string date)
        {
            this.experimentType = experimentType;
            this.result = result;
            this.date = date;
        }
    }
}
