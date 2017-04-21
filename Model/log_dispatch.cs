using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// log_dispatch:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class log_dispatch
	{
		public log_dispatch()
		{}
		#region Model
		private string _logid;
		private string _name= "null";
		private DateTime? _use_time= Convert.ToDateTime(null);
		private string _use_module= "null";
		private string _content= "null";
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
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
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
		public string CONTENT
		{
			set{ _content=value;}
			get{return _content;}
		}
		#endregion Model

	}
}

