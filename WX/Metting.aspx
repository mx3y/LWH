<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Metting.aspx.cs" Inherits="WX.Metting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    会议编号：<asp:TextBox ID="txtMeeting" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="创建会议" onclick="Button1_Click" />
    <br />
    <br />
    客服手机号码：<asp:TextBox ID="txtCustomPhone" ReadOnly="true" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server"  Text="邀请客服" onclick="Button2_Click" />
    <br />
    患者手机号码：
    <asp:TextBox ID="txtUserPhone" runat="server" ReadOnly="true" ></asp:TextBox>
    <asp:Button ID="Button3" runat="server" Text="邀请患者" ReadOnly="true"  onclick="Button3_Click" />
       <br />
       医生手机号码：
    <asp:TextBox ID="txtDoctorPhone" ReadOnly="true"  runat="server"></asp:TextBox>
    <asp:Button ID="Button4" runat="server" ReadOnly="true"  Text="邀请医生" onclick="Button4_Click" />
    </form>
</body>
</html>
