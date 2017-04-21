using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_base_item_type_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_base_item_type_info
	{
		public t_base_item_type_info()
		{}
		#region Model
		private long _id;
		private string _type_code;
		private string _type_name;
		private decimal? _paixu;
		/// <summary>
		/// 
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_code
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type_name
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? paixu
		{
			set{ _paixu=value;}
			get{return _paixu;}
		}
		#endregion Model

	}
}

