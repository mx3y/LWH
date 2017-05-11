using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// CREATE 2017-4-21
    /// AUTHOR:SU
    /// </summary>
    public class hospitalList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_hospital adlBLL = new BLL.ask_hospital();
                Model.ask_hospital adlModel = new Model.ask_hospital();
                DataSet set = adlBLL.GetList("");
                DataSet sendSet = set.Copy();
                sendSet.Clear();
                //dstate为1的加入sendSet
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    if (set.Tables[0].Rows[i]["hstatus"].ToString().Equals("1"))
                    {
                        sendSet.Tables[0].Rows.Add(set.Tables[0].Rows[i].ItemArray);
                    }
                }
                int count = sendSet.Tables[0].Rows.Count;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(sendSet, Newtonsoft.Json.Formatting.Indented);
                string zz = "draw\":1,\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data";
                int index = json.IndexOf("d");
                string json1 = json.Remove(index, 2).Insert(index, zz);
                context.Response.Write(callback + "(" + json1 + ")");
            }
            else
            {
                context.Response.Write("请先登录");
            }
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