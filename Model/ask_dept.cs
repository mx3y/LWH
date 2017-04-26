using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// ask_dept:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ask_dept
	{
		public ask_dept()
		{}
		#region Model
		private int _did;
		private string _dname;
		private int _dhid;
		private int _dparentid;
		private string _dcontent;
		private int _dstate;
		/// <summary>
		/// 
		/// </summary>
		public int did
		{
			set{ _did=value;}
			get{return _did;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dname
		{
			set{ _dname=value;}
			get{return _dname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dhid
		{
			set{ _dhid=value;}
			get{return _dhid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dparentid
		{
			set{ _dparentid=value;}
			get{return _dparentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dcontent
		{
			set{ _dcontent=value;}
			get{return _dcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dstate
		{
			set{ _dstate=value;}
			get{return _dstate;}
		}
		#endregion Model

	}
}

