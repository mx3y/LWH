using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_role
	{
		public sys_role()
		{}
		#region Model
		private long _role_id;
		private string _role_name= "null";
		private string _acgi_name= "null";
		private string _remark;
		private long? _platfom_id;
		private DateTime? _createtime;
		/// <summary>
		/// 
		/// </summary>
		public long ROLE_ID
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ROLE_NAME
		{
			set{ _role_name=value;}
			get{return _role_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ACGI_NAME
		{
			set{ _acgi_name=value;}
			get{return _acgi_name;}
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
		public long? platfom_id
		{
			set{ _platfom_id=value;}
			get{return _platfom_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

