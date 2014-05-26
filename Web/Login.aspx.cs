using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //login("muhammet", "cosar");
            list();
        }

        public void list()
        {
            bolum.DataSource = Db.BolumList();
            bolum.DataBind();
        }
        public void login(string uname, string upass)
        {
            var login = Db.Login(uname, upass);
            if (login.SUCCESS)
            {
                SessionManager.Login = login;
                if (login.ISADMIN)
                    Response.Redirect("~/Request/Manage");

                else
                    Response.Redirect("~/Request/List");
            }
            else
                Response.Redirect("~/Login");
        }
        protected void giris_Click(object sender, EventArgs e)
        {
            login(kadi.Text, sifre.Text);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            txtgiris.Visible = false;
            txtkayit.Visible = true;
        }

        protected void Giris_Click1(object sender, EventArgs e)
        {
            txtgiris.Visible = true;
            txtkayit.Visible = false;
        }

        public void kaydet()
        {
            var ISADMIN = admin.SelectedValue;
            string numara, tc, isim, soyad, sifre, eMail, bolumler;
            numara = Numara.Text;
            tc = txttc.Text;
            isim = Name.Text;
            soyad = Surname.Text;
            sifre = Password.Text;
            eMail = (Mail.Text);
            bolumler = bolum.SelectedValue;

            if (ISADMIN == "")
            {
                lbadmin.Text = "yönetici bölümünü  seciniz ?";
            }
            else if (numara != "" && tc != "" && isim != "" && soyad != "" && sifre != "" && eMail != "" && bolumler != "")
            {
                if (tc.Length != 11)
                {
                    lbadmin.Text = " Tc 11 karekter olmaz zorunda ..";
                }
                else
                {
                    Db.OgrenciSave(Numara.Text, txttc.Text, Name.Text, Surname.Text, Username.Text, Password.Text, Mail.Text, bolum.Text, ISADMIN);
                    lbadmin.Text = "Kayıt Başarılı";
                }
            }

            else
            {
                lbadmin.Text = "alanları boş  geçemezsiniz ?";
            }

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        protected void Numara_TextChanged(object sender, EventArgs e)
        {

        }


    }
}