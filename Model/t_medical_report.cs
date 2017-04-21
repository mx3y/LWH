using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_medical_report:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_medical_report
	{
		public t_medical_report()
		{}
		#region Model
		private decimal _report_id;
		private string _check_date;
		private string _check_man;
		private string _inspection_date;
		private string _inspection_man;
		private string _project_type;
		private decimal? _medical_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal report_id
		{
			set{ _report_id=value;}
			get{return _report_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_date
		{
			set{ _check_date=value;}
			get{return _check_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_man
		{
			set{ _check_man=value;}
			get{return _check_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inspection_date
		{
			set{ _inspection_date=value;}
			get{return _inspection_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string inspection_man
		{
			set{ _inspection_man=value;}
			get{return _inspection_man;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project_type
		{
			set{ _project_type=value;}
			get{return _project_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? medical_id
		{
			set{ _medical_id=value;}
			get{return _medical_id;}
		}
		#endregion Model

	}
}

