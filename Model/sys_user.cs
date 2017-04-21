using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_user
	{
		public sys_user()
		{}
		#region Model
		private long _user_id;
		private string _user_name;
		private string _tel;
		private string _email;
		private string _del_flag;
		private DateTime? _create_date;
		private string _create_man;
		private string _login_name;
		private string _login_pwd;
		private string _user_code;
		private string _is_admin;
		/// <summary>
		/// 
		/// </summary>
		public long user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string del_flag
		{
			set{ _del_flag=value;}
			get{return _del_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string create_man
		{
			set{ _create_man=value;}
			get{return _create_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login_name
		{
			set{ _login_name=value;}
			get{return _login_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string login_pwd
		{
			set{ _login_pwd=value;}
			get{return _login_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_code
		{
			set{ _user_code=value;}
			get{return _user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_admin
		{
			set{ _is_admin=value;}
			get{return _is_admin;}
		}
		#endregion Model

	}
}

