using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WX
{
    public partial class Metting : System.Web.UI.Page
    {
        string serverIp = "api.ucpaas.com";
        string serverPort = "443";
        string account = "32b1b5b8c71d79cf6ac0b51c8918b9b3";    //用户sid
        string token = "66bebf599956fbbcda56c024e107cdf3";      //用户sid对应的token
        string appId = "62f6200a7800421da428b56f5bc283d9";      //对应的应用id，非测试应用需上线使用
        string clientNum = "13410040404";
        string clientpwd = "";
        string friendName = "lw_test_400";
        string clientType = "0";
        string charge = "0";
        string phone = "4008088166";
        string date = "day";
        uint start = 0;
        uint limit = 100;
        string toPhone = "15307385200";                                    //发送短信手机号码，群发逗号区分
        string templatedId = "1";                               //短信模板id，需通过审核
        string param = "a,b,c";                                     //短信参数
        string verifyCode = "1234";
        string fromSerNum = "073189581395";
        string toSerNum = "073189581395";
        string maxallowtime = "600";
        UCSRestRequest.UCSRestRequest api = new UCSRestRequest.UCSRestRequest();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
             
               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            api.init(serverIp, serverPort);
            api.setAccount(account, token);
            api.enabeLog(true);
            api.setAppId(appId);
            api.enabeLog(true);
            string json = api.CreateConference(clientNum, toPhone, fromSerNum, toSerNum, maxallowtime);

          
      
            JObject o = JObject.Parse(json);
            IEnumerable<JProperty> properties = o.Properties();
            string confId = string.Empty;
            foreach (JProperty item in properties)
            {
                //{"resp":{"respCode":"0","desc":"OK","confId":"30008306","hostCode":"566757","guestCode":"811916"}}
                if (item.Name.ToLower().Trim() == "resp")
                {
                    JObject o1 = JObject.Parse(item.Value.ToString());
                    IEnumerable<JProperty> properties1 = o1.Properties();
                    foreach (JProperty item1 in properties1)
                    {
                        if (item1.Name.ToLower().Trim() == "confId")
                        {
                            confId = item1.Value.ToString();
                            break;
                        }
                    }
                }

            }
            if (confId.Length != 0)
            {
                txtMeeting.Text = confId;
                
            }
            else
                txtMeeting.Text = json;
        }

        //客服
        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        //邀请患者
        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        //邀请医生
        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}