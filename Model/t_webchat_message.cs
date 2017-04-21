using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_webchat_message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_webchat_message
	{
		public t_webchat_message()
		{}
		#region Model
		private decimal _message_id;
		private string _content;
		private DateTime? _create_time;
		private int? _title;
		private string _type;
		/// <summary>
		/// 
		/// </summary>
		public decimal message_id
		{
			set{ _message_id=value;}
			get{return _message_id;}
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
		public DateTime? create_time
		{
			set{ _create_time=value;}
			get{return _create_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

