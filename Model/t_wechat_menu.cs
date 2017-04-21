using System;
namespace LW_AskOnline.Model
{
	/// <summary>
	/// t_wechat_menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_wechat_menu
	{
		public t_wechat_menu()
		{}
		#region Model
		private decimal _menu_id;
		private int? _menu_name;
		private int? _sort;
		private decimal? _parent_id;
		/// <summary>
		/// 
		/// </summary>
		public decimal menu_id
		{
			set{ _menu_id=value;}
			get{return _menu_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? menu_name
		{
			set{ _menu_name=value;}
			get{return _menu_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? parent_id
		{
			set{ _parent_id=value;}
			get{return _parent_id;}
		}
		#endregion Model

	}
}

