using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// addTest 的摘要说明
    /// </summary>
    public class addTest : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            string callback = context.Request.QueryString["callback"].ToString();
            string addParameter = context.Request.QueryString["json"].ToString();
           /* //获取上传文件
            HttpPostedFile img = context.Request.Files["btnfile"];
            // string parameter = context.Request.QueryString["aa"].ToString();
            string s = img.FileName;
            string path = "~/upload/" + s.Substring(s.LastIndexOf("//") + 1);
            img.SaveAs(context.Server.MapPath(path));
            string data = HttpRuntime.AppDomainAppVirtualPath + path.Substring(1);*/
            //读json
            Object ja = JsonConvert.DeserializeObject(addParameter);
            JObject o = (JObject)ja;
            //Common.Log log = new Common.Log();
           // BLL.ask_city adlBll = new BLL.ask_city();
            /*int cparent_id = Convert.ToInt32(o["cparent_id"].ToString());
            int cregion_grade = Convert.ToInt32(o["cregion_grade"].ToString());
            int cstatus = Convert.ToInt32(o["cstatus"].ToString());*/
            //将数据放到model
           /* Model.ask_city adlModel = new Model.ask_city()
            {
                cparent_id = 1,
                cregion_name = o["name"].ToString(),
                cregion_grade = 1,
                cstatus = 1,
                cdistrict_code = "ok",
                carea_code = "ok"
            };
            adlBll.Add(adlModel);
            string handle= "ADD";
            string ip = log.GetIP();
            string user = "USER";
            DateTime time = log.GetTime();
            log.WriteLogFile(handle, ip, user, time);  */
            //读取日志
           /* Common.Log log1 = new Common.Log();
            string[] lines = log1.ReadLogFile();
            string json1 = "";
            foreach (string line in lines)
            {
                json1 += string.Format("{{\"handle\": {0},\"ip\": \"{1},\"user\": {2},\"datetime\": {3}\"}},", lines[0], lines[1], lines[2], lines[3]);
            }
            json1 = json1.Substring(0, json1.Length - 1);
            json1 = string.Format("[{0}]", json1);*/
           /* string [] lines = log.ReadLogFile();
            List<string[]> list = new List<string[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = Regex.Split(lines[i], " ", RegexOptions.IgnoreCase);
                list.Add(line);
            }
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);*/
            /*HttpCookie cookie = new HttpCookie();
            cookie.Value = "Tom";
            cookie.Expires = DateTime.Now.AddDays(1);
            context.Response.Cookies.Add(cookie);*/
            //HttpCookie co = new HttpCookie();
            context.Response.Cookies["name"].Value = "aa";
            context.Response.Cookies["name"].Expires = DateTime.Now.AddHours(1);
                context.Response.Write(context.Request.Cookies["name"]);
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