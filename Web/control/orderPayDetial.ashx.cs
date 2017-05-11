using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// orderPayDetial 的摘要说明
    /// </summary>
    public class orderPayDetial : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string opid = context.Request["id"].ToString();
            BLL.ask_order_pay opBll = new BLL.ask_order_pay();
            Model.ask_order_pay opModel = opBll.GetModel(int.Parse(opid));
            string json = string.Format("{{\"oid\":\"{0}\",\"uuid\":\"{1}\",\"porder\":\"{2}\",\"pwxorder\":\"{3}\",\"pmonery\":\"{4}\",\"pcreatetime\":\"{5}\",\"povertime\":\"{6}\",\"popenid\":\"{7}\",\"pstatus\":\"{8}\"}}",
                                           opModel.oid, opModel.uuid, opModel.porder, opModel.pwxorder, opModel.pmonery, opModel.pcreatetime, opModel.povertime, opModel.popenid, opModel.pstatus);
            context.Response.Write(callback+"("+json+")");
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