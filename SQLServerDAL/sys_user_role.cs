﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_user_role
	/// </summary>
	public partial class sys_user_role:Isys_user_role
	{
		public sys_user_role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal user_role_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_user_role");
			strSql.Append(" where user_role_id=@user_role_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_role_id", SqlDbType.Decimal)
			};
			parameters[0].Value = user_role_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.sys_user_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_user_role(");
			strSql.Append("role_id,user_id)");
			strSql.Append(" values (");
			strSql.Append("@role_id,@user_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Decimal,9),
					new SqlParameter("@user_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.role_id;
			parameters[1].Value = model.user_id;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.sys_user_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_user_role set ");
			strSql.Append("role_id=@role_id,");
			strSql.Append("user_id=@user_id");
			strSql.Append(" where user_role_id=@user_role_id");
			SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Decimal,9),
					new SqlParameter("@user_id", SqlDbType.Decimal,9),
					new SqlParameter("@user_role_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.role_id;
			parameters[1].Value = model.user_id;
			parameters[2].Value = model.user_role_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal user_role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user_role ");
			strSql.Append(" where user_role_id=@user_role_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_role_id", SqlDbType.Decimal)
			};
			parameters[0].Value = user_role_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string user_role_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_user_role ");
			strSql.Append(" where user_role_id in ("+user_role_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.sys_user_role GetModel(decimal user_role_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_role_id,role_id,user_id from sys_user_role ");
			strSql.Append(" where user_role_id=@user_role_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_role_id", SqlDbType.Decimal)
			};
			parameters[0].Value = user_role_id;

			LW_AskOnline.Model.sys_user_role model=new LW_AskOnline.Model.sys_user_role();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.sys_user_role DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_user_role model=new LW_AskOnline.Model.sys_user_role();
			if (row != null)
			{
				if(row["user_role_id"]!=null && row["user_role_id"].ToString()!="")
				{
					model.user_role_id=decimal.Parse(row["user_role_id"].ToString());
				}
				if(row["role_id"]!=null && row["role_id"].ToString()!="")
				{
					model.role_id=decimal.Parse(row["role_id"].ToString());
				}
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=decimal.Parse(row["user_id"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select user_role_id,role_id,user_id ");
			strSql.Append(" FROM sys_user_role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" user_role_id,role_id,user_id ");
			strSql.Append(" FROM sys_user_role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM sys_user_role ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.user_role_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_user_role T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "sys_user_role";
			parameters[1].Value = "user_role_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

