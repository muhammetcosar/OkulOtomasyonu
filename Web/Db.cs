using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Kadmyo
{
    public class Db
    {

        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection("Data Source=UZEM-BILGISAYAR;Initial Catalog=okul;Integrated Security=True");
            }
        }



        //DERS İSİMLERİNİ CEKMEK İÇİN :D
        public static DataTable DerslerTableGet()
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_DERSLER_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;



            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Dersler DerslerParseGet(DataRow row)
        {
            Dersler d = new Dersler();
            d.DERSID = Convert.ToInt32(row["DERSID"].ToString());
            d.DERSADI = row["DERSADI"].ToString();

            return d;
        }
        public static List<Dersler> DerslerListGet()
        {
            var table = DerslerTableGet();
            List<Dersler> list = new List<Dersler>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(DerslerParseGet(row));
            }
            return list;
        }



        public static void DsSave(int uid, bool h1, bool h2, string d1)
        {
            var tarih = DateTime.Now.ToShortDateString();
            int toplam = 0;
            if (h1 == false && h2 == true)
            {
                toplam = toplam + 1 + 0;
            }
            else if (h1 == true && h2 == false)
            {
                toplam = toplam + 0 + 1;
            }
            else if (h1 == false && h2 == false)
            {
                toplam = toplam + 2;
            }

            var con = Connection;
            con.Open();
            var cmd = new SqlCommand("ST_SP_DEVAMSIZ_SAVE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERID", uid);
            cmd.Parameters.AddWithValue("@DERS1", h1);
            cmd.Parameters.AddWithValue("@DERS2", h2);
            cmd.Parameters.AddWithValue("@EDATE", tarih);
            cmd.Parameters.AddWithValue("@TOPLAM", toplam);
            cmd.Parameters.AddWithValue("@DERSADI", d1);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable UserTableGet(int? id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_USER_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@USERID", id);


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static User UserParseGet(DataRow row)
        {
            User m = new User();
            m.USERID = Convert.ToInt32(row["USERID"].ToString());
            m.USERNAME = row["USERNAME"].ToString();
            m.NAME = row["NAME"].ToString();
            m.TC = row["TC"].ToString();
            m.SURNAME = row["SURNAME"].ToString();
            m.NUMARA = row["NUMARA"].ToString();
            return m;
        }
        public static List<User> UserListGet(int? id)
        {
            var table = UserTableGet(id);
            List<User> list = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(UserParseGet(row));
            }
            return list;
        }


        public static DataTable UserBolumTableGet(int? id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_USERBOLUM_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@USERID", id);


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static User UserBolumParseGet(DataRow row)
        {
            User m = new User();
            m.USERID = Convert.ToInt32(row["USERID"].ToString());
            m.USERNAME = row["USERNAME"].ToString();
            m.NAME = row["NAME"].ToString();
            m.TC = row["TC"].ToString();
            m.SURNAME = row["SURNAME"].ToString();
            m.NUMARA = row["NUMARA"].ToString();
            return m;
        }
        public static List<User> UserBolumListGet(int? id)
        {
            var table = UserBolumTableGet(id);
            List<User> list = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(UserBolumParseGet(row));
            }
            return list;
        }


        public static DataTable UserTableGet2(int? id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_USER_SELECT2 ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@USERID", id);


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static User UserParseGet2(DataRow row)
        {
            User m = new User();
            m.USERID = Convert.ToInt32(row["USERID"].ToString());
            m.USERNAME = row["USERNAME"].ToString();
            m.NAME = row["NAME"].ToString();
            m.TC = row["TC"].ToString();
            m.SURNAME = row["SURNAME"].ToString();
            m.MAIL = row["MAIL"].ToString();
            m.PASSWORD = row["PASSWORD"].ToString();
            return m;
        }
        public static List<User> UserListGet2(int? id)
        {
            var table = UserTableGet2(id);
            List<User> list = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(UserParseGet2(row));
            }
            return list;
        }


        public static DataTable NotTableGet(int? id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_NOT_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@USERID", id);


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Not NotParseGet(DataRow row)
        {
            Not o = new Not();
            o.USERID = Convert.ToInt32(row["USERID"].ToString());
            o.NOTEID = Convert.ToInt32(row["NOTEID"].ToString());
            o.VIZE1 = Convert.ToInt32(row["VIZE1"].ToString());
            o.VIZE2 = Convert.ToInt32(row["VIZE2"].ToString());
            o.FINAL = Convert.ToInt32(row["FINAL"].ToString());
            o.DERSADI = row["DERSADI"].ToString();
            return o;
        }
        public static List<Not> NotListGet(int? id)
        {
            var table = NotTableGet(id);
            List<Not> list = new List<Not>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(NotParseGet(row));
            }
            return list;
        }



        public static void OgrenciSave(string numara, string tc, string name, string surname, string username, string sifre, string mail, string bolum, string ISADMIN)
        {

            var con = Connection;
            con.Open();
            var cmd = new SqlCommand("ST_SP_OGRENCI_SAVE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@SURNAME", surname);
            cmd.Parameters.AddWithValue("@USERNAME", username);
            cmd.Parameters.AddWithValue("@PASSWORD", sifre);
            cmd.Parameters.AddWithValue("@MAIL", mail);
            cmd.Parameters.AddWithValue("@NUMARA", numara);
            cmd.Parameters.AddWithValue("@BOLUM", bolum);
            cmd.Parameters.AddWithValue("@ISADMIN", ISADMIN);
            cmd.Parameters.AddWithValue("@TC", tc);


            cmd.ExecuteNonQuery();
            con.Close();

        }



        public static DataTable SearchTable(int? id, string username, string tc, string soyad, string bolum)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_USERBOLUM_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@NUMARA", id);
            adapter.SelectCommand.Parameters.AddWithValue("@NAME", username);
            adapter.SelectCommand.Parameters.AddWithValue("@TC", tc);
            adapter.SelectCommand.Parameters.AddWithValue("@SURNAME", soyad);
            adapter.SelectCommand.Parameters.AddWithValue("@BOLUM", bolum);

            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static User SearchParse(DataRow row)
        {
            User m = new User();
            m.USERID = Convert.ToInt32(row["USERID"].ToString());
            m.USERNAME = row["USERNAME"].ToString();
            m.NAME = row["NAME"].ToString();
            m.SURNAME = row["SURNAME"].ToString();
            m.TC = row["TC"].ToString();
            m.BOLUM = row["BOLUM"].ToString();


            return m;
        }
        public static List<User> SearchList(int? id, string username, string tc, string soyad, string bolum)
        {
            var table = SearchTable(id, username, tc, soyad, bolum);
            List<User> list = new List<User>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(SearchParse(row));
            }
            return list;
        }


        public static LoginResult Login(string uname, string pass)
        {
            LoginResult result = new LoginResult() { SUCCESS = false };

            try
            {
                SqlConnection con = Connection;
                SqlCommand cmd = new SqlCommand("ST_SP_USER_LOGIN", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERNAME", uname);
                cmd.Parameters.AddWithValue("@PASSWORD", pass);

                con.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.Read())
                {
                    result.SUCCESS = true;
                    result.USERID = Convert.ToInt32(dr["USERID"]);
                    result.USERNAME = dr["USERNAME"].ToString();
                    result.PASSWORD = dr["PASSWORD"].ToString();
                    result.MAIL = dr["MAIL"].ToString();
                    result.ISADMIN = Convert.ToBoolean(dr["ISADMIN"]);
                    result.BOLUM = dr["BOLUM"].ToString();


                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                result.MESSAGE = "Hata Oluştu.";
            }

            return result;
        }




        public static DataTable BolumTable()
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_BOLUM_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Episode BolumParse(DataRow row)
        {
            Episode e = new Episode();
            e.EPISODEID = Convert.ToInt32(row["EPISODEID"].ToString());
            e.EPISODENAME = row["EPISODENAME"].ToString();



            return e;
        }
        public static List<Episode> BolumList()
        {
            var table = BolumTable();
            List<Episode> list = new List<Episode>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(BolumParse(row));
            }
            return list;
        }




        public static DataTable StudentTableGet(int? id)
        {

            SqlConnection baglanti = Connection;
            SqlDataAdapter adapter = new SqlDataAdapter("ST_SP_OGRENCI_SELECT ", baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@USERID", id);


            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            return tablo;
        }
        public static Student StudentParseGet(DataRow row)
        {
            Student o = new Student();
            o.USERID = Convert.ToInt32(row["USERID"].ToString());
            o.DERS1 = Convert.ToInt32(row["DERS1"].ToString());
            o.DERS2 = Convert.ToInt32(row["DERS2"].ToString());
            o.DERSADI = row["DERSADI"].ToString();
            o.EDATE = Convert.ToDateTime(row["EDATE"].ToString());

            return o;
        }
        public static List<Student> StudentListGet(int? id)
        {
            var table = StudentTableGet(id);
            List<Student> list = new List<Student>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(StudentParseGet(row));
            }
            return list;
        }



        public static void NotSave(int uid, int v1, int v2, int f1, string d1)
        {
            var tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var con = Connection;
            con.Open();

            var cmd = new SqlCommand("ST_SP_NOT_SAVE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERID", uid);
            cmd.Parameters.AddWithValue("@VIZE1", v1);
            cmd.Parameters.AddWithValue("@VIZE2", v2);
            cmd.Parameters.AddWithValue("@FINAL", f1);
            cmd.Parameters.AddWithValue("@EDATE", tarih);
            cmd.Parameters.AddWithValue("@DERSADI", d1);

            cmd.ExecuteNonQuery();
            con.Close();

        }


        public static void UserGuncelle(int id, string ad, string soyad, string tc, string mail, string kullanıcı, string sifre)
        {

            var con = Connection;
            con.Open();
            var cmd = new SqlCommand("ST_SP_USER_UPDATE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERID", id);
            cmd.Parameters.AddWithValue("@NAME", ad);
            cmd.Parameters.AddWithValue("@SURNAME", soyad);
            cmd.Parameters.AddWithValue("@TC", tc);
            cmd.Parameters.AddWithValue("@MAIL", mail);
            cmd.Parameters.AddWithValue("@USERNAME", kullanıcı);
            cmd.Parameters.AddWithValue("@PASSWORD", sifre);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }

}
