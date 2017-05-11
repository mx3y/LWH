using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace LW_AskOnline.Common
{
    public class Log : System.Web.UI.Page
    {
        //写入日志文件
        public void WriteLogFile(string handle,string ip,string user,DateTime time,string master)
        {
            //指定日志文件的目录
            string fname = Server.MapPath("upedFile") + "\\logfile.txt";
            //定义文件信息对象
            System.IO.FileInfo finfo = new System.IO.FileInfo(fname);
/*            //判断文件是否存在以及是否大于规定大小，超过则删除，暂定2K
            if (finfo.Exists && finfo.Length > 2048)
            {
                finfo.Delete();
            }
*/            //创建写文件流
            using (System.IO.FileStream fs = finfo.OpenWrite())
            {
                //根据上面创建的文件流创建写数据流
                System.IO.StreamWriter w = new System.IO.StreamWriter(fs);
                /*Common.Log log = new Common.Log();
                string ip = log.GetIP();
                DateTime time = log.GetTime();*/
                //设置写数据流的起始位置为文件流的末尾
                w.BaseStream.Seek(0, System.IO.SeekOrigin.End);
                w.Write(handle+" ");
                w.Write(ip + " ");
                w.Write(user + " ");
                w.Write(master + " ");
                //w.Write(master + " ");
                w.Write(time + " \r\n");
                /*w.Write("{0} {1} \r\n", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());*/
                w.Write("----------------------------------------------\r\n");
                //清空缓冲区内容，并把缓冲区内容写入基础流
                w.Flush();
                //关闭写数据流
                w.Close();
            }
        }
        

       //读取日志文件
        public string[] ReadLogFile()
        {
           string t = "";
           string fname = Server.MapPath("upedFile") + "\\logfile.txt";
           System.IO.FileInfo finfo = new System.IO.FileInfo(fname);
           using (System.IO.FileStream fs = finfo.OpenRead())
           {
               //根据上面创建的文件流创建读数据流
               System.IO.StreamReader r = new System.IO.StreamReader(fs);
               t = r.ReadToEnd();
           }
           //string t = System.IO.File.ReadAllText(text);
           string[] lines = Regex.Split(t, "----------------------------------------------\r\n", RegexOptions.IgnoreCase);
           return lines;
        }
       //获取IP
        public string GetIP()
        {
            string uip = "";
            if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                uip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                uip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return uip;
        }
       //获取时间
        public DateTime GetTime()
        {
            //获取时间戳
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            string timeStamp = Convert.ToInt64(ts.TotalSeconds).ToString();
            //时间戳转换为时间
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
            //时间转换为时间戳
            /*
             * System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
               return (int)(time - startTime).TotalSeconds;
             * */
        }   
    }
}
