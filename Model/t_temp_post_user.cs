using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_temp_post_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_temp_post_user
	{
		public t_temp_post_user()
		{}
		#region Model
		private int? _uid;
		private string _uname;
		private string _udate;
		private string _uorg;
		private string _ulvl;
		private decimal? _umonery;
		/// <summary>
		/// 
		/// </summary>
		public int? uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uname
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string udate
		{
			set{ _udate=value;}
			get{return _udate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uorg
		{
			set{ _uorg=value;}
			get{return _uorg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ulvl
		{
			set{ _ulvl=value;}
			get{return _ulvl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? umonery
		{
			set{ _umonery=value;}
			get{return _umonery;}
		}
		#endregion Model

	}
}

