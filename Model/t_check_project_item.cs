using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_check_project_item:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_check_project_item
	{
		public t_check_project_item()
		{}
		#region Model
		private decimal _item_id;
		private string _itme_name;
		private string _reference_value;
		private string _result;
		private decimal? _report_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal item_id
		{
			set{ _item_id=value;}
			get{return _item_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itme_name
		{
			set{ _itme_name=value;}
			get{return _itme_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string reference_value
		{
			set{ _reference_value=value;}
			get{return _reference_value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? report_id
		{
			set{ _report_id=value;}
			get{return _report_id;}
		}
		#endregion Model

	}
}

