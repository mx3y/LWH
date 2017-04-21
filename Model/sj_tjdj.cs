using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sj_tjdj:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sj_tjdj
	{
		public sj_tjdj()
		{}
		#region Model
		private decimal _tjid;
		private decimal? _je;
		private string _tcmc;
		private DateTime? _tjsj;
		private DateTime? _zjsj;
		private string _zjys;
		private decimal? _khid;
		private string _khlx;
		/// <summary>
		/// 
		/// </summary>
		public decimal tjid
		{
			set{ _tjid=value;}
			get{return _tjid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? je
		{
			set{ _je=value;}
			get{return _je;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tcmc
		{
			set{ _tcmc=value;}
			get{return _tcmc;}
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
		public DateTime? zjsj
		{
			set{ _zjsj=value;}
			get{return _zjsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zjys
		{
			set{ _zjys=value;}
			get{return _zjys;}
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
		public string khlx
		{
			set{ _khlx=value;}
			get{return _khlx;}
		}
		#endregion Model

	}
}

