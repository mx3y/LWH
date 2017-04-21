using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_office_status_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_office_status_record
	{
		public t_office_status_record()
		{}
		#region Model
		private decimal _record_id;
		private string _datetime;
		private string _status;
		private decimal _office_id;
		private string _period;
		/// <summary>
		/// 
		/// </summary>
		public decimal record_id
		{
			set{ _record_id=value;}
			get{return _record_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string datetime
		{
			set{ _datetime=value;}
			get{return _datetime;}
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
		public decimal office_Id
		{
			set{ _office_id=value;}
			get{return _office_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string period
		{
			set{ _period=value;}
			get{return _period;}
		}
		#endregion Model

	}
}

