using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sj_tjhz:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sj_tjhz
	{
		public sj_tjhz()
		{}
		#region Model
		private decimal _id;
		private string _content;
		private int _sort;
		private string _title;
		private decimal? _tjid;
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
		public string content
		{
			set{ _content=value;}
			get{return _content;}
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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

