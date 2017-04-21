using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_medical_examination:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_medical_examination
	{
		public t_medical_examination()
		{}
		#region Model
		private decimal _medical_id;
		private DateTime? _booking_date;
		private string _booking_dept_name;
		private string _booking_doctor;
		private string _check_mark;
		private string _check_result;
		private string _check_subject;
		private string _medical_package;
		private string _status;
		private decimal? _member_id;
		private decimal? _order_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal medical_id
		{
			set{ _medical_id=value;}
			get{return _medical_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? booking_date
		{
			set{ _booking_date=value;}
			get{return _booking_date;}
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
		public string booking_doctor
		{
			set{ _booking_doctor=value;}
			get{return _booking_doctor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_mark
		{
			set{ _check_mark=value;}
			get{return _check_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_result
		{
			set{ _check_result=value;}
			get{return _check_result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string check_subject
		{
			set{ _check_subject=value;}
			get{return _check_subject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string medical_package
		{
			set{ _medical_package=value;}
			get{return _medical_package;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
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
		public decimal? order_id
		{
			set{ _order_id=value;}
			get{return _order_id;}
		}
		#endregion Model

	}
}

