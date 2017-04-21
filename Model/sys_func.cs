using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_func:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_func
	{
		public sys_func()
		{}
		#region Model
		private long _func_code;
		private long? _parent_func_code=null;
		private string _func_name= "null";
		private string _url= "null";
		private int? _order_no=null;
		private string _isshow;
		/// <summary>
		/// 
		/// </summary>
		public long FUNC_CODE
		{
			set{ _func_code=value;}
			get{return _func_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? PARENT_FUNC_CODE
		{
			set{ _parent_func_code=value;}
			get{return _parent_func_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FUNC_NAME
		{
			set{ _func_name=value;}
			get{return _func_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORDER_NO
		{
			set{ _order_no=value;}
			get{return _order_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		#endregion Model

	}
}

