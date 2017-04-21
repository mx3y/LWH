using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_case_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_case_info
	{
		public t_case_info()
		{}
		#region Model
		private decimal _case_id;
		private string _attending_doctor;
		private string _case_details;
		private string _date_of_visit;
		private decimal? _member_id;
		private string _booking_dept_name;
		private DateTime? _uploaddate;
		private string _visitdate;
		private DateTime? _upload_date;
		private DateTime? _visit_date;
		private string _member_type;
		/// <summary>
		/// 
		/// </summary>
		public decimal case_id
		{
			set{ _case_id=value;}
			get{return _case_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string attending_doctor
		{
			set{ _attending_doctor=value;}
			get{return _attending_doctor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string case_details
		{
			set{ _case_details=value;}
			get{return _case_details;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string date_of_visit
		{
			set{ _date_of_visit=value;}
			get{return _date_of_visit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? member_id
		{
			set{ _member_id=value;}
			get{return _member_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string booking_dept_name
		{
			set{ _booking_dept_name=value;}
			get{return _booking_dept_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? uploadDate
		{
			set{ _uploaddate=value;}
			get{return _uploaddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string visitDate
		{
			set{ _visitdate=value;}
			get{return _visitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? upload_date
		{
			set{ _upload_date=value;}
			get{return _upload_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? visit_date
		{
			set{ _visit_date=value;}
			get{return _visit_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string member_type
		{
			set{ _member_type=value;}
			get{return _member_type;}
		}
		#endregion Model

	}
}

