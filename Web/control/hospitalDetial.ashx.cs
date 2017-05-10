using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// hospitalDetial 的摘要说明
    /// </summary>
    public class hospitalDetial : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string hid = context.Request["hid"].ToString();
            BLL.ask_hospital hosAdlBll = new BLL.ask_hospital();
            BLL.ask_dept deptAdlBll = new BLL.ask_dept();
            List<Model.ask_dept> list = deptAdlBll.GetModelList("dhid = " + int.Parse(hid) + "");
            Model.ask_hospital hosAdlModel = hosAdlBll.GetModel(int.Parse(hid));
            string arjson = "";
            foreach (Model.ask_dept atb in list)
            {
                arjson += string.Format("{{\"dname\":\"{0}\",\"dcontent\":\"{1}\"}},", atb.dname, atb.dcontent);
            }
            arjson = arjson.Substring(0, arjson.Length - 1);
            arjson = string.Format("[{0}]", arjson);
            string json = string.Format("{{\"hcity\":\"{0}\",\"hname\":\"{1}\",\"hlevel\":\"{2}\",\"haddress\":\"{3}\",\"hcontent\":\"{4}\",\"deptinfo\":{5}}},",
                   hosAdlModel.hcity,hosAdlModel.hname,hosAdlModel.hlevel,hosAdlModel.haddress,hosAdlModel.hcontent,arjson);
            json = json.Substring(0, json.Length - 1);
            /*List<Object> li = new List<Object>();
            li.Add(list);
            li.Add(hosAdlModel);
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(li,Newtonsoft.Json.Formatting.Indented);*/
            context.Response.Write(callback+"("+json+")");
        }
       // li = [[Object,Object],Object]

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}