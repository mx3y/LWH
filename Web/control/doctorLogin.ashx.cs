using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// doctorLogin 的摘要说明
    /// </summary>
    public class doctorLogin : IHttpHandler
    {
        public class Acount
        {
            public int status { get; set; }
            public string dname { get; set; }
            public int did { get; set; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string parameter = context.Request.QueryString["json"].ToString();
            string callback = context.Request.QueryString["callback"].ToString();
            //读json
            Object ja = JsonConvert.DeserializeObject(parameter);
            JObject o = (JObject)ja;
            string dname = o["account"].ToString();
            string pwd = o["password"].ToString();
            Acount acount = new Acount();
            BLL.ask_doctor_list adlBll = new BLL.ask_doctor_list();
            BLL.ask_order odb = new BLL.ask_order();
            List<Model.ask_doctor_list> dlist = adlBll.GetModelList("");
            List<Model.ask_order> olist = new List<Model.ask_order>();
            int check = 0;
            int index = 0;
            string json = "";
            string listJson ="";
            for (int i = 0; i < dlist.Count; i++)
            {
                if (dlist[i].daccount.Equals(dname)&&dlist[i].dpassword.Equals(pwd))
                {
                    index = i;
                    check = 1;
                    break;
                }
            }
            if (check==0)
            {
                acount.dname = null;
                acount.did = 0;
                acount.status = 0;
            }
            else
            {
                olist = odb.GetModelList("odid = " + dlist[index].did + "");
                int count = olist.Count;
                acount.dname = dlist[index].dname;
                acount.did = dlist[index].did;
                acount.status = 1; 
                json = Newtonsoft.Json.JsonConvert.SerializeObject(olist, Newtonsoft.Json.Formatting.Indented);
                listJson = string.Format("{{\"draw\": \"{0}\", \"recordsTotal\": \"{1}\",\"recordsFiltered\": \"{2}\",\"acount\": \"{3}\",\"data\":{4}}}", 1, count, count,acount,json);
            }
            context.Response.Write(callback + "(" + listJson + ")");
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