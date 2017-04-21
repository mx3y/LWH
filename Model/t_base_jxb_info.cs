using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_base_jxb_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_base_jxb_info
	{
		public t_base_jxb_info()
		{}
		#region Model
		private decimal _id;
		private DateTime? _createtime;
		private string _itemids;
		private string _name;
		private string _remark;
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
		public DateTime? createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemids
		{
			set{ _itemids=value;}
			get{return _itemids;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

