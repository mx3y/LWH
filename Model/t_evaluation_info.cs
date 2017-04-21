using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_evaluation_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_evaluation_info
	{
		public t_evaluation_info()
		{}
		#region Model
		private decimal _evaluation_id;
		private string _content;
		private DateTime? _evaluation_time;
		private int? _level;
		private decimal? _member_id;
		private decimal? _goods_id;
		private decimal? _detail_id;
		private int _is_anonymous=0;
		private int? _grade;
		private int? _is_picture;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal evaluation_id
		{
			set{ _evaluation_id=value;}
			get{return _evaluation_id;}
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
		public DateTime? evaluation_time
		{
			set{ _evaluation_time=value;}
			get{return _evaluation_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? goods_id
		{
			set{ _goods_id=value;}
			get{return _goods_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? detail_id
		{
			set{ _detail_id=value;}
			get{return _detail_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_anonymous
		{
			set{ _is_anonymous=value;}
			get{return _is_anonymous;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? grade
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_picture
		{
			set{ _is_picture=value;}
			get{return _is_picture;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		#endregion Model

	}
}

