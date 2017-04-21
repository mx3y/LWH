using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_role
	/// </summary>
	public partial class sys_role:Isys_role
	{
		public sys_role()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ROLE_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_role");
			strSql.Append(" where ROLE_ID=@ROLE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLE_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ROLE_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.sys_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_role(");
			strSql.Append("ROLE_NAME,ACGI_NAME,remark,platfom_id,createtime)");
			strSql.Append(" values (");
			strSql.Append("@ROLE_NAME,@ACGI_NAME,@remark,@platfom_id,@createtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ACGI_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@platfom_id", SqlDbType.BigInt,8),
					new SqlParameter("@createtime", SqlDbType.DateTime)};
			parameters[0].Value = model.ROLE_NAME;
			parameters[1].Value = model.ACGI_NAME;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.platfom_id;
			parameters[4].Value = model.createtime;

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
		public bool Update(LW_AskOnline.Model.sys_role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_role set ");
			strSql.Append("ROLE_NAME=@ROLE_NAME,");
			strSql.Append("ACGI_NAME=@ACGI_NAME,");
			strSql.Append("remark=@remark,");
			strSql.Append("platfom_id=@platfom_id,");
			strSql.Append("createtime=@createtime");
			strSql.Append(" where ROLE_ID=@ROLE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ACGI_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@remark", SqlDbType.VarChar,50),
					new SqlParameter("@platfom_id", SqlDbType.BigInt,8),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@ROLE_ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.ROLE_NAME;
			parameters[1].Value = model.ACGI_NAME;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.platfom_id;
			parameters[4].Value = model.createtime;
			parameters[5].Value = model.ROLE_ID;

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
		public bool Delete(long ROLE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role ");
			strSql.Append(" where ROLE_ID=@ROLE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLE_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ROLE_ID;

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
		public bool DeleteList(string ROLE_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role ");
			strSql.Append(" where ROLE_ID in ("+ROLE_IDlist + ")  ");
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
		public LW_AskOnline.Model.sys_role GetModel(long ROLE_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ROLE_ID,ROLE_NAME,ACGI_NAME,remark,platfom_id,createtime from sys_role ");
			strSql.Append(" where ROLE_ID=@ROLE_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ROLE_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ROLE_ID;

			LW_AskOnline.Model.sys_role model=new LW_AskOnline.Model.sys_role();
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
		public LW_AskOnline.Model.sys_role DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_role model=new LW_AskOnline.Model.sys_role();
			if (row != null)
			{
				if(row["ROLE_ID"]!=null && row["ROLE_ID"].ToString()!="")
				{
					model.ROLE_ID=long.Parse(row["ROLE_ID"].ToString());
				}
				if(row["ROLE_NAME"]!=null)
				{
					model.ROLE_NAME=row["ROLE_NAME"].ToString();
				}
				if(row["ACGI_NAME"]!=null)
				{
					model.ACGI_NAME=row["ACGI_NAME"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["platfom_id"]!=null && row["platfom_id"].ToString()!="")
				{
					model.platfom_id=long.Parse(row["platfom_id"].ToString());
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
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
			strSql.Append("select ROLE_ID,ROLE_NAME,ACGI_NAME,remark,platfom_id,createtime ");
			strSql.Append(" FROM sys_role ");
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
			strSql.Append(" ROLE_ID,ROLE_NAME,ACGI_NAME,remark,platfom_id,createtime ");
			strSql.Append(" FROM sys_role ");
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
			strSql.Append("select count(1) FROM sys_role ");
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
				strSql.Append("order by T.ROLE_ID desc");
			}
			strSql.Append(")AS Row, T.*  from sys_role T ");
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
			parameters[0].Value = "sys_role";
			parameters[1].Value = "ROLE_ID";
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

