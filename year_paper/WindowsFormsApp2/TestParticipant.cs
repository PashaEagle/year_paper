using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class TestParticipant
    {
        public string name;
        public string group;
        public double result;
        public string date;

        public TestParticipant(string name, string group, double result, string date)
        {
            this.name = name;
            this.group = group;
            this.result = result;
            this.date = date;
        }
    }
}
