using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// orderList 的摘要说明
    /// </summary>
    public class orderList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            if (context.Request.Cookies["mid"] != null)
            {
                string callback = context.Request.QueryString["callback"].ToString();
                BLL.ask_order adlBLL = new BLL.ask_order();
                BLL.ask_doctor_list docbll = new BLL.ask_doctor_list();
                Model.ask_order adlModel = new Model.ask_order();
                Model.ask_doctor_list docModel = new Model.ask_doctor_list();
                List<Model.ask_order> list = adlBLL.GetModelList("");
                int count = list.Count;
                string json = "";
                foreach (Model.ask_order model in list)
                {
                    json += string.Format("{{\"dname\": \"{0}\",\"ouid\": \"{1}\",\"odid\": \"{2}\",\"otype\": \"{3}\",\"oresult\": \"{4}\",\"ostate\": \"{5}\",\"ocreatetime\": \"{6}\",\"ocommittime\": \"{7}\",\"opublicmonery\": \"{8}\",\"oprivatemonery\": \"{9}\",\"ototalmonery\": \"{10}\",\"otransid\": \"{11}\",\"ocallresult\": \"{12}\",\"ocallid\": \"{13}\",\"ocalldate\": \"{14}\",\"oillid\": \"{15}\",\"oillimg\": \"{16}\",\"oillcontent\": \"{17}\"}},",
                                      docbll.GetModel(model.odid).dname, model.ouid, model.odid, model.otype, model.oresult, model.ostate, model.ocreatetime, model.ocommittime, model.opublicmonery, model.oprivatemonery, model.ototalmonery, model.otransid, model.ocallresult, model.ocallid, model.ocalldate, model.oillid, model.oillimg, model.oillcontent);
                }
                json = json.Substring(0, json.Length - 1);
                json = string.Format("[{0}]", json);
                string lastJson = string.Format("{{\"draw\":\"{0}\",\"recordsTotal\":\"{1}\",\"recordsFiltered\":\"{2}\",\"data\":{3}}}",1,count,count,json);
                //string json = Newtonsoft.Json.JsonConvert.SerializeObject(set, Newtonsoft.Json.Formatting.Indented);
                //string zz = "draw\":1,\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data";
                //int index = json.IndexOf("d");
                //string json1 = json.Remove(index, 2).Insert(index, zz);
                context.Response.Write(callback + "(" + lastJson + ")");
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