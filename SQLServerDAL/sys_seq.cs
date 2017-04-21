using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sys_seq
	/// </summary>
	public partial class sys_seq:Isys_seq
	{
		public sys_seq()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal seq_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_seq");
			strSql.Append(" where seq_id=@seq_id");
			SqlParameter[] parameters = {
					new SqlParameter("@seq_id", SqlDbType.Decimal)
			};
			parameters[0].Value = seq_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.sys_seq model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_seq(");
			strSql.Append("seq_code,seq_name,seq_value)");
			strSql.Append(" values (");
			strSql.Append("@seq_code,@seq_name,@seq_value)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@seq_code", SqlDbType.VarChar,20),
					new SqlParameter("@seq_name", SqlDbType.VarChar,50),
					new SqlParameter("@seq_value", SqlDbType.Decimal,9)};
			parameters[0].Value = model.seq_code;
			parameters[1].Value = model.seq_name;
			parameters[2].Value = model.seq_value;

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
		public bool Update(LW_AskOnline.Model.sys_seq model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_seq set ");
			strSql.Append("seq_code=@seq_code,");
			strSql.Append("seq_name=@seq_name,");
			strSql.Append("seq_value=@seq_value");
			strSql.Append(" where seq_id=@seq_id");
			SqlParameter[] parameters = {
					new SqlParameter("@seq_code", SqlDbType.VarChar,20),
					new SqlParameter("@seq_name", SqlDbType.VarChar,50),
					new SqlParameter("@seq_value", SqlDbType.Decimal,9),
					new SqlParameter("@seq_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.seq_code;
			parameters[1].Value = model.seq_name;
			parameters[2].Value = model.seq_value;
			parameters[3].Value = model.seq_id;

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
		public bool Delete(decimal seq_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_seq ");
			strSql.Append(" where seq_id=@seq_id");
			SqlParameter[] parameters = {
					new SqlParameter("@seq_id", SqlDbType.Decimal)
			};
			parameters[0].Value = seq_id;

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
		public bool DeleteList(string seq_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_seq ");
			strSql.Append(" where seq_id in ("+seq_idlist + ")  ");
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
		public LW_AskOnline.Model.sys_seq GetModel(decimal seq_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 seq_id,seq_code,seq_name,seq_value from sys_seq ");
			strSql.Append(" where seq_id=@seq_id");
			SqlParameter[] parameters = {
					new SqlParameter("@seq_id", SqlDbType.Decimal)
			};
			parameters[0].Value = seq_id;

			LW_AskOnline.Model.sys_seq model=new LW_AskOnline.Model.sys_seq();
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
		public LW_AskOnline.Model.sys_seq DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_seq model=new LW_AskOnline.Model.sys_seq();
			if (row != null)
			{
				if(row["seq_id"]!=null && row["seq_id"].ToString()!="")
				{
					model.seq_id=decimal.Parse(row["seq_id"].ToString());
				}
				if(row["seq_code"]!=null)
				{
					model.seq_code=row["seq_code"].ToString();
				}
				if(row["seq_name"]!=null)
				{
					model.seq_name=row["seq_name"].ToString();
				}
				if(row["seq_value"]!=null && row["seq_value"].ToString()!="")
				{
					model.seq_value=decimal.Parse(row["seq_value"].ToString());
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
			strSql.Append("select seq_id,seq_code,seq_name,seq_value ");
			strSql.Append(" FROM sys_seq ");
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
			strSql.Append(" seq_id,seq_code,seq_name,seq_value ");
			strSql.Append(" FROM sys_seq ");
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
			strSql.Append("select count(1) FROM sys_seq ");
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
				strSql.Append("order by T.seq_id desc");
			}
			strSql.Append(")AS Row, T.*  from sys_seq T ");
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
			parameters[0].Value = "sys_seq";
			parameters[1].Value = "seq_id";
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

