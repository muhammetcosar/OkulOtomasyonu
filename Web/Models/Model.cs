using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kadmyo
{
        public class User
        {
            public int? USERID { get; set; }
            public string USERNAME { get; set; }
            public string PASSWORD { get; set; }
            public string NAME { get; set; }
            public string SURNAME { get; set; }
            public string TC { get; set; }
            public string NUMARA { get; set; }
            public string VIZE1 { get; set; } 
            public string VIZE2 { get; set; }
            public string FINAL { get; set; }
            public string BOLUM { get; set; }
            public string MAIL { get; set; }
            public bool ISADMIN { get; set; }
        }

        public class Episode
        {
            public int? EPISODEID { get; set; }
            public string EPISODENAME { get; set; }
           


        }
        public class Not
        {
            public int? NOTEID { get; set; }
            public int? USERID { get; set; }
            public int VIZE1 { get; set; }
            public int VIZE2 { get; set; }
            public int FINAL { get; set; }
            public string DERSADI { get; set; }

           
        }
        public class LoginResult
        {

            public int? REQCOUNT { get; set; }
            public int? USERID { get; set; }
            public string USERNAME { get; set; }
            public string PASSWORD { get; set; }
            public string MAIL { get; set; }
            public bool ISADMIN { get; set; }
            public bool SUCCESS { get; set; }
            public string MESSAGE { get; set; }
            public string BOLUM { get; set; }
           
        }

        public class Student
        {
            public int? STUDENTID { get; set; }
            public int? USERID { get; set; }
            public int DERS1 { get; set; }
            public int DERS2 { get; set; }
            public int TOPLAM { get; set; }
            public string DERSADI { get; set; }
            public DateTime EDATE { get; set; }


        }

        public class Dersler
        {
            public int? DERSID { get; set; }
            public string DERSADI { get; set; }
            public int? USERID { get; set; }
            public int? DERSTYPE { get; set; }
            public string NAME { get; set; }
            public string SURNAME { get; set; }

        }

       
      
}