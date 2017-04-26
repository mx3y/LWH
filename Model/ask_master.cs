using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_master:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_master
	{
		public ask_master()
		{}
		#region Model
		private int _mid;
		private string _mnumber;
		private string _mpassword;
		private string _mpurview;
		private string _memail;
		private string _mtell;
		private DateTime? _mregdate;
		private string _mname;
		private string _msex;
		private string _maddress;
		private DateTime? _mlastlogintime;
		private string _mlastip;
		private int? _mstate;
		private int? _mlogincount;
		private string _mremark;
		/// <summary>
		/// 
		/// </summary>
		public int mid
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mnumber
		{
			set{ _mnumber=value;}
			get{return _mnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mpassword
		{
			set{ _mpassword=value;}
			get{return _mpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mPurview
		{
			set{ _mpurview=value;}
			get{return _mpurview;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memail
		{
			set{ _memail=value;}
			get{return _memail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mtell
		{
			set{ _mtell=value;}
			get{return _mtell;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? mregdate
		{
			set{ _mregdate=value;}
			get{return _mregdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mname
		{
			set{ _mname=value;}
			get{return _mname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msex
		{
			set{ _msex=value;}
			get{return _msex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string maddress
		{
			set{ _maddress=value;}
			get{return _maddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? mlastlogintime
		{
			set{ _mlastlogintime=value;}
			get{return _mlastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mlastip
		{
			set{ _mlastip=value;}
			get{return _mlastip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? mstate
		{
			set{ _mstate=value;}
			get{return _mstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? mlogincount
		{
			set{ _mlogincount=value;}
			get{return _mlogincount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mremark
		{
			set{ _mremark=value;}
			get{return _mremark;}
		}
		#endregion Model

	}
}

