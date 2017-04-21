using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_expert_doctor:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_expert_doctor
	{
		public t_expert_doctor()
		{}
		#region Model
		private decimal _doctor_id;
		private string _doctor_name;
		private int? _is_recommend;
		private string _job_title;
		private string _picture;
		private string _remark;
		private string _index_pic;
		private string _index_position;
		/// <summary>
		/// 
		/// </summary>
		public decimal doctor_id
		{
			set{ _doctor_id=value;}
			get{return _doctor_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string doctor_name
		{
			set{ _doctor_name=value;}
			get{return _doctor_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_recommend
		{
			set{ _is_recommend=value;}
			get{return _is_recommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string job_title
		{
			set{ _job_title=value;}
			get{return _job_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picture
		{
			set{ _picture=value;}
			get{return _picture;}
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
		public string index_pic
		{
			set{ _index_pic=value;}
			get{return _index_pic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string index_position
		{
			set{ _index_position=value;}
			get{return _index_position;}
		}
		#endregion Model

	}
}

