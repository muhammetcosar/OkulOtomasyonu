using Kadmyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sakaryauni.Request
{
    public partial class DersSecimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Rbders.DataSource = Db.DerslerListGet();
                Rbders.DataBind();
            }
        }
        public void Save()
        {
            var uid = SessionManager.Login.USERID.Value;
            var dersad = Rbders.SelectedValue;
            Db.DersSecimSave(dersad, uid);
        }
        protected void btngonder_Click(object sender, EventArgs e)
        {
            Save();
        }

        protected void Rbders_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}