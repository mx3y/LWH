using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_case_annex:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_case_annex
	{
		public t_case_annex()
		{}
		#region Model
		private decimal _annex_id;
		private string _file_name;
		private string _file_path;
		private string _file_type;
		private decimal? _case_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal annex_id
		{
			set{ _annex_id=value;}
			get{return _annex_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_path
		{
			set{ _file_path=value;}
			get{return _file_path;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_type
		{
			set{ _file_type=value;}
			get{return _file_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? case_id
		{
			set{ _case_id=value;}
			get{return _case_id;}
		}
		#endregion Model

	}
}

