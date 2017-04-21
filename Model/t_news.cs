using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_news
	{
		public t_news()
		{}
		#region Model
		private long _new_id;
		private long? _user_id;
		private string _title;
		private string _author;
		private string _release_date;
		private string _content;
		private DateTime? _create_date;
		private int? _news_type;
		private string _release_flag;
		private decimal? _column_id;
		private string _brief;
		private string _keyword;
		private string _subtitle;
		private string _source;
		private string _file_path;
		private string _video_file_path;
		private int _is_app=0;
		private int _is_pc=1;
		private int _is_wx=0;
		/// <summary>
		/// 
		/// </summary>
		public long new_id
		{
			set{ _new_id=value;}
			get{return _new_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
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
		public string author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string release_date
		{
			set{ _release_date=value;}
			get{return _release_date;}
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
		public DateTime? create_date
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_type
		{
			set{ _news_type=value;}
			get{return _news_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string release_flag
		{
			set{ _release_flag=value;}
			get{return _release_flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? column_id
		{
			set{ _column_id=value;}
			get{return _column_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string brief
		{
			set{ _brief=value;}
			get{return _brief;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string keyword
		{
			set{ _keyword=value;}
			get{return _keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subtitle
		{
			set{ _subtitle=value;}
			get{return _subtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_path
		{
			set{ _file_path=value;}
			get{return _file_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string video_file_path
		{
			set{ _video_file_path=value;}
			get{return _video_file_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_app
		{
			set{ _is_app=value;}
			get{return _is_app;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_pc
		{
			set{ _is_pc=value;}
			get{return _is_pc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_wx
		{
			set{ _is_wx=value;}
			get{return _is_wx;}
		}
		#endregion Model

	}
}

