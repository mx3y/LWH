using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sj_fuchas:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sj_fuchas
	{
		public sj_fuchas()
		{}
		#region Model
		private decimal _id;
		private string _mc;
		private string _memo;
		private DateTime? _sj;
		private DateTime? _tjsj;
		private decimal? _tjid;
		private decimal? _khid;
		private decimal? _plan_id;
		private string _khlx;
		/// <summary>
		/// 
		/// </summary>
		public decimal id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mc
		{
			set{ _mc=value;}
			get{return _mc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sj
		{
			set{ _sj=value;}
			get{return _sj;}
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
		public decimal? tjid
		{
			set{ _tjid=value;}
			get{return _tjid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? khid
		{
			set{ _khid=value;}
			get{return _khid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? plan_id
		{
			set{ _plan_id=value;}
			get{return _plan_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string khlx
		{
			set{ _khlx=value;}
			get{return _khlx;}
		}
		#endregion Model

	}
}

