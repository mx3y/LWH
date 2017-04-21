using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// sys_seq:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_seq
	{
		public sys_seq()
		{}
		#region Model
		private decimal _seq_id;
		private string _seq_code;
		private string _seq_name;
		private decimal? _seq_value;
		/// <summary>
		/// 
		/// </summary>
		public decimal seq_id
		{
			set{ _seq_id=value;}
			get{return _seq_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seq_code
		{
			set{ _seq_code=value;}
			get{return _seq_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seq_name
		{
			set{ _seq_name=value;}
			get{return _seq_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? seq_value
		{
			set{ _seq_value=value;}
			get{return _seq_value;}
		}
		#endregion Model

	}
}

