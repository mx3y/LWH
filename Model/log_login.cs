using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// log_login:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class log_login
	{
		public log_login()
		{}
		#region Model
		private long _log_id;
		private long? _user_id=null;
		private string _login_name= "null";
		private DateTime? _login_time= Convert.ToDateTime(null);
		private string _login_ip= "null";
		private string _login_message= "null";
		/// <summary>
		/// 
		/// </summary>
		public long LOG_ID
		{
			set{ _log_id=value;}
			get{return _log_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOGIN_NAME
		{
			set{ _login_name=value;}
			get{return _login_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LOGIN_TIME
		{
			set{ _login_time=value;}
			get{return _login_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOGIN_IP
		{
			set{ _login_ip=value;}
			get{return _login_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LOGIN_MESSAGE
		{
			set{ _login_message=value;}
			get{return _login_message;}
		}
		#endregion Model

	}
}

