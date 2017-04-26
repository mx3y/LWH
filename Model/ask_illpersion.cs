using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_illpersion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_illpersion
	{
		public ask_illpersion()
		{}
		#region Model
		private int _iid;
		private int _uid;
		private string _iname;
		private string _iphone;
		private string _icardtype;
		private string _icard;
		private string _isex;
		private DateTime? _ibirthday;
		private string _iaddress;
		/// <summary>
		/// 
		/// </summary>
		public int iid
		{
			set{ _iid=value;}
			get{return _iid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string iname
		{
			set{ _iname=value;}
			get{return _iname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string iphone
		{
			set{ _iphone=value;}
			get{return _iphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string icardtype
		{
			set{ _icardtype=value;}
			get{return _icardtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string icard
		{
			set{ _icard=value;}
			get{return _icard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isex
		{
			set{ _isex=value;}
			get{return _isex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ibirthday
		{
			set{ _ibirthday=value;}
			get{return _ibirthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string iaddress
		{
			set{ _iaddress=value;}
			get{return _iaddress;}
		}
		#endregion Model

	}
}

