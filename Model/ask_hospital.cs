using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_hospital:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_hospital
	{
		public ask_hospital()
		{}
		#region Model
		private int _hid;
		private int _hcityid;
		private string _hcity;
		private string _hname;
		private string _himage;
		private string _hlevel;
		private string _haddress;
		private string _hcontent;
		private int _hstatus;
		/// <summary>
		/// 
		/// </summary>
		public int hid
		{
			set{ _hid=value;}
			get{return _hid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int hcityid
		{
			set{ _hcityid=value;}
			get{return _hcityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hcity
		{
			set{ _hcity=value;}
			get{return _hcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hname
		{
			set{ _hname=value;}
			get{return _hname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string himage
		{
			set{ _himage=value;}
			get{return _himage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hlevel
		{
			set{ _hlevel=value;}
			get{return _hlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string haddress
		{
			set{ _haddress=value;}
			get{return _haddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hcontent
		{
			set{ _hcontent=value;}
			get{return _hcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int hstatus
		{
			set{ _hstatus=value;}
			get{return _hstatus;}
		}
		#endregion Model

	}
}

