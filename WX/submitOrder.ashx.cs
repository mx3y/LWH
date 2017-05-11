using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace WX
{
    /// <summary>
    /// submitOrder 的摘要说明
    /// </summary>
    public class submitOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string did = context.Request.QueryString["did"].ToString();
            string uid = context.Request.QueryString["uid"].ToString();
            string info = context.Request.QueryString["info"].ToString();
            string type = context.Request.QueryString["type"].ToString();
            string code = "0";
            code = InsertOrder(uid, did, "1.jpg,2.jpg", info, type);

            string mes = callback + "(\"" + code + "\")";
            context.Response.Write(mes);
        }

        public string InsertOrder(string uid,string did,string imgurl,string message,string type)
        {
            string date = DateTime.Now.ToString();
            string sql = string.Format("insert into ask_order select {0},{1},{7},1,0,'{2}','{3}',0,0,0,0,'',0,'{4}',0,'{5}','{6}' select @@identity", uid, did, date, date, date, imgurl, message,type);
            return SqlHelper.GetSingle(sql).ToString();
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