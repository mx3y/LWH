using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_func
	/// </summary>
	public partial class sys_func:Isys_func
	{
		public sys_func()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long FUNC_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_func");
			strSql.Append(" where FUNC_CODE=@FUNC_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@FUNC_CODE", SqlDbType.BigInt)
			};
			parameters[0].Value = FUNC_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.sys_func model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_func(");
			strSql.Append("PARENT_FUNC_CODE,FUNC_NAME,URL,ORDER_NO,isShow)");
			strSql.Append(" values (");
			strSql.Append("@PARENT_FUNC_CODE,@FUNC_NAME,@URL,@ORDER_NO,@isShow)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PARENT_FUNC_CODE", SqlDbType.BigInt,8),
					new SqlParameter("@FUNC_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@URL", SqlDbType.VarChar,100),
					new SqlParameter("@ORDER_NO", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.VarChar,10)};
			parameters[0].Value = model.PARENT_FUNC_CODE;
			parameters[1].Value = model.FUNC_NAME;
			parameters[2].Value = model.URL;
			parameters[3].Value = model.ORDER_NO;
			parameters[4].Value = model.isShow;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.sys_func model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_func set ");
			strSql.Append("PARENT_FUNC_CODE=@PARENT_FUNC_CODE,");
			strSql.Append("FUNC_NAME=@FUNC_NAME,");
			strSql.Append("URL=@URL,");
			strSql.Append("ORDER_NO=@ORDER_NO,");
			strSql.Append("isShow=@isShow");
			strSql.Append(" where FUNC_CODE=@FUNC_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@PARENT_FUNC_CODE", SqlDbType.BigInt,8),
					new SqlParameter("@FUNC_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@URL", SqlDbType.VarChar,100),
					new SqlParameter("@ORDER_NO", SqlDbType.Int,4),
					new SqlParameter("@isShow", SqlDbType.VarChar,10),
					new SqlParameter("@FUNC_CODE", SqlDbType.BigInt,8)};
			parameters[0].Value = model.PARENT_FUNC_CODE;
			parameters[1].Value = model.FUNC_NAME;
			parameters[2].Value = model.URL;
			parameters[3].Value = model.ORDER_NO;
			parameters[4].Value = model.isShow;
			parameters[5].Value = model.FUNC_CODE;

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
		public bool Delete(long FUNC_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_func ");
			strSql.Append(" where FUNC_CODE=@FUNC_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@FUNC_CODE", SqlDbType.BigInt)
			};
			parameters[0].Value = FUNC_CODE;

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
		public bool DeleteList(string FUNC_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_func ");
			strSql.Append(" where FUNC_CODE in ("+FUNC_CODElist + ")  ");
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
		public LW_AskOnline.Model.sys_func GetModel(long FUNC_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FUNC_CODE,PARENT_FUNC_CODE,FUNC_NAME,URL,ORDER_NO,isShow from sys_func ");
			strSql.Append(" where FUNC_CODE=@FUNC_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@FUNC_CODE", SqlDbType.BigInt)
			};
			parameters[0].Value = FUNC_CODE;

			LW_AskOnline.Model.sys_func model=new LW_AskOnline.Model.sys_func();
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
		public LW_AskOnline.Model.sys_func DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_func model=new LW_AskOnline.Model.sys_func();
			if (row != null)
			{
				if(row["FUNC_CODE"]!=null && row["FUNC_CODE"].ToString()!="")
				{
					model.FUNC_CODE=long.Parse(row["FUNC_CODE"].ToString());
				}
				if(row["PARENT_FUNC_CODE"]!=null && row["PARENT_FUNC_CODE"].ToString()!="")
				{
					model.PARENT_FUNC_CODE=long.Parse(row["PARENT_FUNC_CODE"].ToString());
				}
				if(row["FUNC_NAME"]!=null)
				{
					model.FUNC_NAME=row["FUNC_NAME"].ToString();
				}
				if(row["URL"]!=null)
				{
					model.URL=row["URL"].ToString();
				}
				if(row["ORDER_NO"]!=null && row["ORDER_NO"].ToString()!="")
				{
					model.ORDER_NO=int.Parse(row["ORDER_NO"].ToString());
				}
				if(row["isShow"]!=null)
				{
					model.isShow=row["isShow"].ToString();
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
			strSql.Append("select FUNC_CODE,PARENT_FUNC_CODE,FUNC_NAME,URL,ORDER_NO,isShow ");
			strSql.Append(" FROM sys_func ");
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
			strSql.Append(" FUNC_CODE,PARENT_FUNC_CODE,FUNC_NAME,URL,ORDER_NO,isShow ");
			strSql.Append(" FROM sys_func ");
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
			strSql.Append("select count(1) FROM sys_func ");
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
				strSql.Append("order by T.FUNC_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from sys_func T ");
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
			parameters[0].Value = "sys_func";
			parameters[1].Value = "FUNC_CODE";
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

