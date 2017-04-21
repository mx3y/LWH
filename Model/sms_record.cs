using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sms_record:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sms_record
	{
		public sms_record()
		{}
		#region Model
		private int _id;
		private string _mid;
		private int _isordersms;
		private int _ismedicalsms;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mid
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int isordersms
		{
			set{ _isordersms=value;}
			get{return _isordersms;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ismedicalsms
		{
			set{ _ismedicalsms=value;}
			get{return _ismedicalsms;}
		}
		#endregion Model

	}
}

