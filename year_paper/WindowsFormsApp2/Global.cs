using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    class Global
    {
        public static string pathToDefaultStatisticFile = "statist.json";
        public static string pathToDefaultStatsFile = "stats.json";
        public static string pathToDefaultParticipantFile = "participants.json";
        public static List<Experiment> experiments = new List<Experiment>();
        public static List<TestParticipant> participants = new List<TestParticipant>();

        //### Active Test Properties ###
        public static List<TestQuestion> random10Questions;
        public static int currentQuestionIndex;
        public static int finalResult;
        public static double finalPoints;
        public static string activeParticipantName;
        public static string activeParticipantGroup;
        public static bool[] correctAnswers = new bool[10];

        //### Open Test Properties ###
        public static int maxQuestionsLimit = 30;
        public static string currentTestFilePath = "null";
        public static List<TestQuestion> currentTestQuestions;

        ///### For experiment ###
        public static int[,] coordX = new int[10, 10];
        public static int[,] coordY = new int[10, 10];
        public static int[,] height = new int[10, 10];
        public static int[,] width = new int[10, 10];

        public static Image[] coinPictures = new Image[2];
        public static Image[] dicePictures = new Image[6];

        ///### Password for teacher ###
        public static string password = "test";
    }
}
