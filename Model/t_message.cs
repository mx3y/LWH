using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_message
	{
		public t_message()
		{}
		#region Model
		private decimal _msg_id;
		private string _message;
		private DateTime? _send_time;
		private string _status;
		private string _type;
		private decimal? _member_id;
		private string _title;
		private string _membertype;
		/// <summary>
		/// 
		/// </summary>
		public decimal msg_id
		{
			set{ _msg_id=value;}
			get{return _msg_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? send_time
		{
			set{ _send_time=value;}
			get{return _send_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string memberType
		{
			set{ _membertype=value;}
			get{return _membertype;}
		}
		#endregion Model

	}
}

