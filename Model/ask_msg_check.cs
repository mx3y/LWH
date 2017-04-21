using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_msg_check:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_msg_check
	{
		public ask_msg_check()
		{}
		#region Model
		private int _mid;
		private int _mmobile;
		private int _mcheckcode;
		private string _mip;
		private DateTime _mcreatedate;
		private int _mexpirat=90;
		private int _misuse;
		private DateTime _musingat;
		private string _mtype;
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
		public int mmobile
		{
			set{ _mmobile=value;}
			get{return _mmobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mcheckcode
		{
			set{ _mcheckcode=value;}
			get{return _mcheckcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mip
		{
			set{ _mip=value;}
			get{return _mip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime mcreatedate
		{
			set{ _mcreatedate=value;}
			get{return _mcreatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mexpirat
		{
			set{ _mexpirat=value;}
			get{return _mexpirat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int misuse
		{
			set{ _misuse=value;}
			get{return _misuse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime musingat
		{
			set{ _musingat=value;}
			get{return _musingat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mtype
		{
			set{ _mtype=value;}
			get{return _mtype;}
		}
		#endregion Model

	}
}

