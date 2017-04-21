using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LW_AskOnline.Web.control
{
    /// <summary>
    /// 从数据库获取数据，转为Jsonp格式传输测试类
    /// author:MZB
    /// date:2017-04-10
    /// </summary>
    public class test1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //start server format 声明服务端格式和编码
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;
            //end server format 
            
            // start get sqldata 获取数据库数据转换为json格式字符串
            BLL.ask_test_bill ask = new BLL.ask_test_bill();
            List<Model.ask_test_bill> list = ask.GetModelList("");
            string json = "";

            foreach (Model.ask_test_bill atb in list)
            {
                json += string.Format("{{\"id\": {0},\"method\": \"{1}\"}},", atb.tid, atb.tvalue);
            }
            json = json.Substring(0, json.Length - 1);
            json = string.Format("[{0}]",json);

           /* BLL.ask_test_bill adlBLL = new BLL.ask_test_bill();
            Model.ask_test_bill adlModel = new Model.ask_test_bill();
            adlModel.tvalue = "test";
            adlModel.tdate = "20170410";
            
            adlBLL.Add(adlModel);*/
            Common.Log log = new Common.Log();
            string [] lines = log.ReadLogFile();
            string json1 = "";
            foreach (string line in lines)
            {
                json1 += string.Format("{{\"handle\": {0},\"ip\": \"{1},\"user\": {2},\"datetime\": {3}\"}},", lines[0], lines[1], lines[2], lines[3]);
            }
            json = json.Substring(0, json.Length - 1);
            json = string.Format("[{0}]",json);
            // end get sqldata

            //start jsonp format声明Jsonp回调格式，把数据写入在回调函数中
            string mes = "";
            if (context.Request.QueryString["callback"] != null) //如果获取不到callback，说明请求是非Jsonp格式，直接回传json格式字符串
            {
                string jsonp = context.Request.QueryString["callback"].ToString();
                mes = jsonp + "(" + json + ")";//" + json + "
            }
            else
                mes = json;
            //end jsonp format

            //start return data 返回服务端的响应结果
            context.Response.Write(mes);
            context.Response.End();
            //end return data

          
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
