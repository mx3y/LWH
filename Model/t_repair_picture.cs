using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_repair_picture:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_repair_picture
	{
		public t_repair_picture()
		{}
		#region Model
		private decimal _picture_id;
		private string _picture;
		private decimal? _repairid;
		/// <summary>
		/// 
		/// </summary>
		public decimal picture_id
		{
			set{ _picture_id=value;}
			get{return _picture_id;}
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
		public decimal? repairId
		{
			set{ _repairid=value;}
			get{return _repairid;}
		}
		#endregion Model

	}
}

