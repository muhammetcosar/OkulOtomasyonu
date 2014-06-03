using Kadmyo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sakaryauni.Request
{
    public partial class DersOnay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            onay();
        }
        public void onay()
        {
            int? id = null;
            dgrListOnay.DataSource = Db.OnayListGet(id);
            dgrListOnay.DataBind();
        }



        protected void btnOnay_Click(object sender, EventArgs e)
        {
           Db.DersSecimUpdate(Convert.ToInt32(dgrListOnay.SelectedValue));
           onay();
        }

        protected void btnkal_Click(object sender, EventArgs e)
        {
            Db.DersSecimDelete(Convert.ToInt32(dgrListOnay.SelectedValue));
            onay();
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtName.Text = " ";
            this.txtSurname.Text = " ";
            this.txtDersadı.Text =" ";
        }
        public void RequestDetail()
        {
            var rid = this.dgrListOnay.SelectedValue as int?;
            if (rid.HasValue)
            {

                var rq = Db.OnayListGet(rid.Value)[0];

                this.txtName.Text = rq.NAME.ToString();
                this.txtSurname.Text = rq.SURNAME.ToString();
                this.txtDersadı.Text = rq.DERSADI.ToString();

            }
        }
        protected void dgrListOnay_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestDetail();
        }


    }
}