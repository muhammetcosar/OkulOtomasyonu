using Kadmyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sakaryauni.Request
{
    public partial class DersEkleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
             
             int sayi = Convert.ToInt32(sec.SelectedValue);
             if (sayi == 1)
             {
                 Db.DersSave(txtDersadı.Text);
             }
             else
             {
                 Db.BolumSave(txtBolumAdı.Text);
             }
        }

        protected void sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(sec.SelectedValue);
            if (sayi == 2)
            {
                bolum.Visible = true;
                ders.Visible = false;
            }
            else if (sayi==1)
            {
                bolum.Visible = false;
                ders.Visible = true;
            }
            
        }
    }
}