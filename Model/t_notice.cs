using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_notice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_notice
	{
		public t_notice()
		{}
		#region Model
		private decimal _msg_id;
		private string _message;
		private DateTime? _send_time;
		private string _title;
		private string _type;
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
		public string title
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

