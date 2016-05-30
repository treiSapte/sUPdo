using System;

namespace sUPdo
{
    class important
    {
        public static string nume;
        public static Int32 id;
        public static Int32 id_teacher = 0;
        public static string name_teacher = "";
        public static string clas = "";
        public static string path = ""; // in setari pun sa aleaga path'ul intr'o tabela separa si'l retin
        public static int lungime = 0;
        public static int varPoz = 0;
        public static int teacherORstudent=0;
        public static int trimis = 0;

        public struct banane
        {
            public Int32 id;
            public string nameS;
            public string classS;
            public DateTime datime;
            public string extension;
            public string namefile;
            public string message;
        }

        public static banane[] files = new banane[100];
        public static banane[] filesS = new banane[100];
    }
}
