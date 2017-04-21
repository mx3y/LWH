using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sj_tjjg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sj_tjjg
	{
		public sj_tjjg()
		{}
		#region Model
		private decimal _jgid;
		private string _enksmc;
		private string _enwpmc;
		private string _jl;
		private string _ksmc;
		private int _sort;
		private DateTime? _tjsj;
		private string _wpmc;
		private string _ysmc;
		private decimal? _tjid;
		/// <summary>
		/// 
		/// </summary>
		public decimal jgid
		{
			set{ _jgid=value;}
			get{return _jgid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string enksmc
		{
			set{ _enksmc=value;}
			get{return _enksmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string enwpmc
		{
			set{ _enwpmc=value;}
			get{return _enwpmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jl
		{
			set{ _jl=value;}
			get{return _jl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ksmc
		{
			set{ _ksmc=value;}
			get{return _ksmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? tjsj
		{
			set{ _tjsj=value;}
			get{return _tjsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wpmc
		{
			set{ _wpmc=value;}
			get{return _wpmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ysmc
		{
			set{ _ysmc=value;}
			get{return _ysmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tjid
		{
			set{ _tjid=value;}
			get{return _tjid;}
		}
		#endregion Model

	}
}

