using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_system_message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_system_message
	{
		public t_system_message()
		{}
		#region Model
		private decimal _id;
		private decimal? _ahead_of_time;
		private string _code;
		private DateTime? _lastupdatetime;
		private string _remark;
		private string _status;
		private string _time_point;
		private string _title;
		private decimal? _msg_id;
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
		public decimal? ahead_of_time
		{
			set{ _ahead_of_time=value;}
			get{return _ahead_of_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string code
		{
			set{ _code=value;}
			get{return _code;}
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
		/// <summary>
		/// 
		/// </summary>
		public string time_point
		{
			set{ _time_point=value;}
			get{return _time_point;}
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
		public decimal? msg_id
		{
			set{ _msg_id=value;}
			get{return _msg_id;}
		}
		#endregion Model

	}
}

