using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo.Request
{
    public partial class devam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                if (!SessionManager.Login.ISADMIN)
                    Response.Redirect("~/Request/List");

                List();
            }
        }
        public void List()
        {
            int? numara = null;
            string name = null;
            string tc = null;
            string soyad = null;
            if (this.txtSearch.Text.Length > 0)
                numara = Convert.ToInt32(this.txtSearch.Text);

            if (this.txtSearch2.Text.Length > 0)
                name = this.txtSearch2.Text;
            if (this.txttc.Text.Length > 0)
                tc = this.txttc.Text;
            if (this.txtsoyad.Text.Length > 0)
                soyad = this.txtsoyad.Text;
            var bolum = SessionManager.Login.BOLUM;
            dgrList.DataSource = Db.SearchList(numara, name, tc, soyad,bolum);
            dgrList.DataBind();

            DERS.DataSource = Db.DerslerListGet();
            DERS.DataBind();
        }
        public void Select()
        {
            var rid = dgrList.SelectedValue as int?;
            if (rid.HasValue)
            {
                var request = Db.UserListGet(rid.Value)[0];

                this.txtUser.Text = request.NUMARA.ToString();
                this.txtName.Text = request.NAME.ToString();
                this.txtSurname.Text = request.SURNAME.ToString();
                this.tc.Text = request.TC.ToString();
            }


        }
        public void Dkaydet()
        {
            for (int i = 0; i < dgrList.Rows.Count; i++)
            {
                var hdID = (HiddenField)dgrList.Rows[i].Cells[0].FindControl("hdID");
                var cbH1 = (CheckBox)dgrList.Rows[i].Cells[0].FindControl("cbH1");
                var cbH2 = (CheckBox)dgrList.Rows[i].Cells[0].FindControl("cbH2");
                if (hdID != null && cbH1 != null && cbH2 != null)
                {
                    int uid = Convert.ToInt32(hdID.Value);
                    var h1 = cbH1.Checked;
                    var h2 = cbH2.Checked;
                    var d1 = DERS.SelectedValue;
                    Db.DsSave(uid, h1, h2,d1);
                }
            }
        }
        public void RequestDetail()
        {
            var rid = this.dgrList.SelectedValue as int?;
            if (rid.HasValue)
            {
                var rq = Db.UserListGet(rid.Value)[0];
                this.txtUser.Text = rq.NUMARA.ToString();
                this.txtName.Text = rq.NAME.ToString();
                this.txtSurname.Text = rq.SURNAME.ToString();

            }
           

        }
        protected void Search_Click(object sender, EventArgs e)
        {
            List();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.dgrList.SelectedIndex = -1;
        }
        protected void dgrList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select();
            RequestDetail();
        }
        protected void gonder_Click(object sender, EventArgs e)
        {
            Dkaydet();
        }


    }
}