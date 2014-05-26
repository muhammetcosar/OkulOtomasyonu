using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) // Listeyi sadece sayfa ilk kez yükleniyorsa yükleriz, tıklamalarda yüklenmemesi lazım ki, seçtiğimiz değer uçup gitmesin
            {
                if (SessionManager.Login.ISADMIN)
                    Response.Redirect("~/Request/Manage");

            }
            List();
        }

        public void List()
        {
            var uid = SessionManager.Login.USERID.Value;
            dgrList.DataSource = Db.NotListGet(uid);
            dgrList.DataBind();
            dgrListD.DataSource = Db.StudentListGet(uid);
            dgrListD.DataBind();
        }

        protected void dgrList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void rblCevap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {


        }


    }
}