﻿using System;
using System.Data;
namespace LW_AskOnline.IDAL
{
	/// <summary>
	/// 接口层log_exception
	/// </summary>
	public interface Ilog_exception
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(long EXCEPTION_ID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		long Add(LW_AskOnline.Model.log_exception model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(LW_AskOnline.Model.log_exception model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(long EXCEPTION_ID);
		bool DeleteList(string EXCEPTION_IDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		LW_AskOnline.Model.log_exception GetModel(long EXCEPTION_ID);
		LW_AskOnline.Model.log_exception DataRowToModel(DataRow row);
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
