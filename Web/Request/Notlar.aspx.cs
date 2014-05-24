﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo.Request
{
    public partial class Notlar : System.Web.UI.Page
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
            dgrList.DataSource = Db.SearchList(numara, name, tc, soyad, bolum);
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
        public void RResponse()
        {
            var uid = SessionManager.Login.USERID.Value;
            var rid = dgrList.SelectedValue as int?;
            if (rid.HasValue)
            {
                string umail = SessionManager.Login.MAIL;
                List();
            }
        }
        public void Nkaydet()
        {
            for (int i = 0; i < dgrList.Rows.Count; i++)
            {
                var hdID = (HiddenField)dgrList.Rows[i].Cells[0].FindControl("hdID");
                var vize1 = (TextBox)dgrList.Rows[i].Cells[0].FindControl("vize1");
                var vize2 = (TextBox)dgrList.Rows[i].Cells[0].FindControl("vize2");
                var final = (TextBox)dgrList.Rows[i].Cells[0].FindControl("final");
                if (hdID != null)
                {
                    int uid = Convert.ToInt32(hdID.Value);
                    var v1 = Convert.ToInt32(vize1.Text);
                    var v2 = Convert.ToInt32(vize2.Text);
                    var f1 = Convert.ToInt32(final.Text);
                    var d1 = DERS.SelectedValue;
                    if (v1 < 100 && v1 < 100 && f1 < 100)
                    {
                        Db.NotSave(uid, v1, v2, f1, d1);
                    }
                    else
                    {
                        mesaj.Text = "Notları kontrol ediniz 100 üzerinde not veremezsınız.";
                    }

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
            //var not = Db.NotListGet(rid.Value)[0];
            //if (not.ID.HasValue!=null)
            //{
            //    this.txtvize.Text = not.VİZE.ToString();
            //    this.txtfinal.Text = not.FİNAL.ToString();
            //}

        }
        protected void Search_Click(object sender, EventArgs e)
        {
            List();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            RResponse();
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
            Nkaydet();
        }

    }
}