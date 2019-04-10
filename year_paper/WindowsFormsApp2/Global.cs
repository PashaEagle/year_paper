using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class Global
    {
        public static string pathToDefaultStatsFile = "stats.json";
        public static string pathToDefaultParticipantFile = "participants.json";
        public static List<Experiment> experiments = new List<Experiment>();
        public static List<TestParticipant> participants = new List<TestParticipant>();
    }
}
