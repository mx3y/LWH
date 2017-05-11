using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// illpersionDetial 的摘要说明
    /// </summary>
    public class illpersionDetial : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string iid = context.Request["id"].ToString();
            BLL.ask_illpersion illBll = new BLL.ask_illpersion();
            BLL.ask_user userBll = new BLL.ask_user();
            Model.ask_illpersion illModel = illBll.GetModel(int.Parse(iid));
            Model.ask_user userModel = userBll.GetModel(illModel.uid);
            string json = string.Format("{{\"uid\":\"{0}\",\"iname\":\"{1}\",\"iphone\":\"{2}\",\"icardtype\":\"{3}\",\"icard\":\"{4}\",\"isex\":\"{5}\",\"ibirthday\":\"{6}\",\"iaddress\":\"{7}\",\"uaccount\":\"{8}\"}}",
                                        illModel.uid, illModel.iname, illModel.iphone, illModel.icardtype, illModel.icard, illModel.isex, illModel.ibirthday, illModel.iaddress,userModel.uaccount);
            context.Response.Write(callback + "("+json+")");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}