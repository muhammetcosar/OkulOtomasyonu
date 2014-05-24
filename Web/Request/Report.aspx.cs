using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kadmyo
{
    public partial class Rapor : System.Web.UI.Page
    {
        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection("Data Source=MUHAMMET;Initial Catalog=destek;Integrated Security=True");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadReport()
        {
           
        }

     
 
        
    }
}