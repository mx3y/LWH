using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_test_bill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_test_bill
	{
		public ask_test_bill()
		{}
		#region Model
		private int _tid;
		private string _tvalue;
		private string _tdate;
		/// <summary>
		/// 
		/// </summary>
		public int tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tvalue
		{
			set{ _tvalue=value;}
			get{return _tvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tdate
		{
			set{ _tdate=value;}
			get{return _tdate;}
		}
		#endregion Model

	}
}

