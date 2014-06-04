
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo.Layout
{
    public partial class Sidebar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionManager.Login.ISADMIN == false)
            {
                dersOnay.Visible = false;
               
                Notlar.Visible = false;
                devam.Visible = false;
            }
            else if (SessionManager.Login.ISADMIN == true)
            {
                dersSecim.Visible = false;
                
            }
        }
    }
}