using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_order_pay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_order_pay
	{
		public ask_order_pay()
		{}
		#region Model
		private int _pid;
		private int _oid;
		private int _uuid;
		private string _porder;
		private string _pwxorder;
		private decimal _pmonery;
		private DateTime _pcreatetime;
		private DateTime _povertime;
		private string _popenid;
		private int _pstatus;
		/// <summary>
		/// 
		/// </summary>
		public int pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int oid
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uuid
		{
			set{ _uuid=value;}
			get{return _uuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string porder
		{
			set{ _porder=value;}
			get{return _porder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pwxorder
		{
			set{ _pwxorder=value;}
			get{return _pwxorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal pmonery
		{
			set{ _pmonery=value;}
			get{return _pmonery;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime pcreatetime
		{
			set{ _pcreatetime=value;}
			get{return _pcreatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime povertime
		{
			set{ _povertime=value;}
			get{return _povertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string popenid
		{
			set{ _popenid=value;}
			get{return _popenid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pstatus
		{
			set{ _pstatus=value;}
			get{return _pstatus;}
		}
		#endregion Model

	}
}

