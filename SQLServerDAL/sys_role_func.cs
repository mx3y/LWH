using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_role_func
	/// </summary>
	public partial class sys_role_func:Isys_role_func
	{
		public sys_role_func()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal role_func_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_role_func");
			strSql.Append(" where role_func_id=@role_func_id");
			SqlParameter[] parameters = {
					new SqlParameter("@role_func_id", SqlDbType.Decimal)
			};
			parameters[0].Value = role_func_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.sys_role_func model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_role_func(");
			strSql.Append("func_code,role_id)");
			strSql.Append(" values (");
			strSql.Append("@func_code,@role_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@func_code", SqlDbType.Decimal,9),
					new SqlParameter("@role_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.func_code;
			parameters[1].Value = model.role_id;

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
		public bool Update(LW_AskOnline.Model.sys_role_func model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_role_func set ");
			strSql.Append("func_code=@func_code,");
			strSql.Append("role_id=@role_id");
			strSql.Append(" where role_func_id=@role_func_id");
			SqlParameter[] parameters = {
					new SqlParameter("@func_code", SqlDbType.Decimal,9),
					new SqlParameter("@role_id", SqlDbType.Decimal,9),
					new SqlParameter("@role_func_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.func_code;
			parameters[1].Value = model.role_id;
			parameters[2].Value = model.role_func_id;

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
		public bool Delete(decimal role_func_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role_func ");
			strSql.Append(" where role_func_id=@role_func_id");
			SqlParameter[] parameters = {
					new SqlParameter("@role_func_id", SqlDbType.Decimal)
			};
			parameters[0].Value = role_func_id;

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
		public bool DeleteList(string role_func_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_role_func ");
			strSql.Append(" where role_func_id in ("+role_func_idlist + ")  ");
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
		public LW_AskOnline.Model.sys_role_func GetModel(decimal role_func_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 role_func_id,func_code,role_id from sys_role_func ");
			strSql.Append(" where role_func_id=@role_func_id");
			SqlParameter[] parameters = {
					new SqlParameter("@role_func_id", SqlDbType.Decimal)
			};
			parameters[0].Value = role_func_id;

			LW_AskOnline.Model.sys_role_func model=new LW_AskOnline.Model.sys_role_func();
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
		public LW_AskOnline.Model.sys_role_func DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_role_func model=new LW_AskOnline.Model.sys_role_func();
			if (row != null)
			{
				if(row["role_func_id"]!=null && row["role_func_id"].ToString()!="")
				{
					model.role_func_id=decimal.Parse(row["role_func_id"].ToString());
				}
				if(row["func_code"]!=null && row["func_code"].ToString()!="")
				{
					model.func_code=decimal.Parse(row["func_code"].ToString());
				}
				if(row["role_id"]!=null && row["role_id"].ToString()!="")
				{
					model.role_id=decimal.Parse(row["role_id"].ToString());
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
			strSql.Append("select role_func_id,func_code,role_id ");
			strSql.Append(" FROM sys_role_func ");
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
			strSql.Append(" role_func_id,func_code,role_id ");
			strSql.Append(" FROM sys_role_func ");
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
			strSql.Append("select count(1) FROM sys_role_func ");
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
				strSql.Append("order by T.role_func_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_role_func T ");
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
			parameters[0].Value = "sys_role_func";
			parameters[1].Value = "role_func_id";
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

