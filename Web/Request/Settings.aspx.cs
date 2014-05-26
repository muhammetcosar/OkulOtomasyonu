using Kadmyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sakaryauni.Request
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getir();
        }
        public void getir()
        {
          var uid = SessionManager.Login.USERID.Value;
          dgrList.DataSource = Db.UserListGet2(uid);
          dgrList.DataBind();
        }

        public void RequestDetail()
        {
            var rid = this.dgrList.SelectedValue as int?;
            if (rid.HasValue)
            {
                var rq = Db.UserListGet2(rid.Value)[0];
                this.txtName.Text = rq.NAME.ToString();
                this.txtSurname.Text = rq.SURNAME.ToString();
                this.tc.Text = rq.TC.ToString();
                this.txtmail.Text = rq.MAIL.ToString();
                this.txtsifre.Text = rq.PASSWORD.ToString();
                this.txtkullan.Text = rq.USERNAME.ToString();

            }
        }

        protected void dgrList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestDetail();
        }
        public void guncelle()
        {
            var uid = SessionManager.Login.USERID.Value;

            Db.UserGuncelle(uid, txtName.Text, txtSurname.Text, tc.Text,txtmail.Text,txtkullan.Text,txtsifre.Text);
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            guncelle();
        }
    }
}