using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_news_column:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_news_column
	{
		public t_news_column()
		{}
		#region Model
		private decimal _column_id;
		private string _column_code;
		private string _column_name;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public decimal column_id
		{
			set{ _column_id=value;}
			get{return _column_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string column_code
		{
			set{ _column_code=value;}
			get{return _column_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string column_name
		{
			set{ _column_name=value;}
			get{return _column_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

