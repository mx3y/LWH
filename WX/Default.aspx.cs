using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WX
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"D:\list.txt"))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        //Response.Write(str+"<br/>");
                        SqlHelper.ExecuteSql("insert into t_temp_1 select '" + str + "'");
                    }
                }
                //Console.Read();
            }
        }
    }
}