using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_suggestion_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_suggestion_record
	{
		public t_suggestion_record()
		{}
		#region Model
		private decimal _suggestion_id;
		private string _content;
		private string _title;
		private decimal? _member_id;
		private DateTime? _suggestion_time;
		private string _member_name;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal suggestion_id
		{
			set{ _suggestion_id=value;}
			get{return _suggestion_id;}
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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
		public DateTime? suggestion_time
		{
			set{ _suggestion_time=value;}
			get{return _suggestion_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_name
		{
			set{ _member_name=value;}
			get{return _member_name;}
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

