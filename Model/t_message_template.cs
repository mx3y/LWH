using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_message_template:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_message_template
	{
		public t_message_template()
		{}
		#region Model
		private decimal _id;
		private DateTime? _lastupdatetime;
		private string _msg_content;
		private string _msg_name;
		private string _msg_start_using;
		private string _msg_type;
		private string _remark;
		private string _status;
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
		public DateTime? lastupdatetime
		{
			set{ _lastupdatetime=value;}
			get{return _lastupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg_content
		{
			set{ _msg_content=value;}
			get{return _msg_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg_name
		{
			set{ _msg_name=value;}
			get{return _msg_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg_start_using
		{
			set{ _msg_start_using=value;}
			get{return _msg_start_using;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string msg_type
		{
			set{ _msg_type=value;}
			get{return _msg_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

