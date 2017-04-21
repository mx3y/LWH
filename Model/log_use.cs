using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// log_use:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class log_use
	{
		public log_use()
		{}
		#region Model
		private string _logid;
		private string _deptid= "null";
		private string _userid= "null";
		private DateTime? _use_time= Convert.ToDateTime(null);
		private string _use_module= "null";
		private string _use_operation= "null";
		private string _use_describle= "null";
		private string _use_ip= "null";
		/// <summary>
		/// 
		/// </summary>
		public string LOGID
		{
			set{ _logid=value;}
			get{return _logid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPTID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USERID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? USE_TIME
		{
			set{ _use_time=value;}
			get{return _use_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_MODULE
		{
			set{ _use_module=value;}
			get{return _use_module;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_OPERATION
		{
			set{ _use_operation=value;}
			get{return _use_operation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USE_DESCRIBLE
		{
			set{ _use_describle=value;}
			get{return _use_describle;}
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

