using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WX
{
    /// <summary>
    /// updateOrder 的摘要说明
    /// </summary>
    public class updateOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string oid = context.Request.QueryString["oid"].ToString();
            string monery = context.Request.QueryString["publicMonery"].ToString();
 
          string   code = UpdateOrder(oid,monery) ? "success" : "error";

            string mes = callback + "(\"" + code + "\")";
            context.Response.Write(mes);
        }

        public bool UpdateOrder(string oid, string monery)
        {
            bool result = false;
            string sql = string.Format("update ask_order set opublicmonery={0},ototalmonery={1},ocreatetime='{2}' where oid={3}",monery,monery,DateTime.Now.ToString(),oid);
            SqlHelper.ExecuteSql(sql);
            result = true;
            return result;
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