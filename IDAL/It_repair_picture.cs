﻿using System;
using System.Data;
namespace LW_AskOnline.IDAL
{
	/// <summary>
	/// 接口层t_repair_picture
	/// </summary>
	public interface It_repair_picture
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(decimal picture_id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		decimal Add(LW_AskOnline.Model.t_repair_picture model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(LW_AskOnline.Model.t_repair_picture model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(decimal picture_id);
		bool DeleteList(string picture_idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		LW_AskOnline.Model.t_repair_picture GetModel(decimal picture_id);
		LW_AskOnline.Model.t_repair_picture DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
