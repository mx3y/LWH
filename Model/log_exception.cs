using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// log_exception:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class log_exception
	{
		public log_exception()
		{}
		#region Model
		private long _exception_id;
		private DateTime? _exception_time= Convert.ToDateTime(null);
		private string _exception_content= "null";
		private string _use_ip;
		/// <summary>
		/// 
		/// </summary>
		public long EXCEPTION_ID
		{
			set{ _exception_id=value;}
			get{return _exception_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EXCEPTION_TIME
		{
			set{ _exception_time=value;}
			get{return _exception_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EXCEPTION_CONTENT
		{
			set{ _exception_content=value;}
			get{return _exception_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_IP
		{
			set{ _use_ip=value;}
			get{return _use_ip;}
		}
		#endregion Model

	}
}

