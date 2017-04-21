using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// queryDoctor 的摘要说明
    /// </summary>
    public class queryDoctor : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            BLL.ask_doctor_list adlBLL = new BLL.ask_doctor_list();
            Model.ask_doctor_list adlModel = new Model.ask_doctor_list();
            DataSet set = adlBLL.GetList("");
            DataSet sendSet = set.Copy();
            sendSet.Clear();
            //dstate为1的加入sendSet
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                if (set.Tables[0].Rows[i]["dstate"].ToString().Equals("1"))
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}