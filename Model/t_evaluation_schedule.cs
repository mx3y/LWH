using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_evaluation_schedule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_evaluation_schedule
	{
		public t_evaluation_schedule()
		{}
		#region Model
		private decimal _schedule_id;
		private string _picture;
		private decimal? _evaluation_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal schedule_id
		{
			set{ _schedule_id=value;}
			get{return _schedule_id;}
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
		public decimal? evaluation_id
		{
			set{ _evaluation_id=value;}
			get{return _evaluation_id;}
		}
		#endregion Model

	}
}

