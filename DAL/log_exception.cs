using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:log_exception
	/// </summary>
	public partial class log_exception
	{
		public log_exception()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long EXCEPTION_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from log_exception");
			strSql.Append(" where EXCEPTION_ID=@EXCEPTION_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EXCEPTION_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = EXCEPTION_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.log_exception model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into log_exception(");
			strSql.Append("EXCEPTION_TIME,EXCEPTION_CONTENT,USE_IP)");
			strSql.Append(" values (");
			strSql.Append("@EXCEPTION_TIME,@EXCEPTION_CONTENT,@USE_IP)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EXCEPTION_TIME", SqlDbType.DateTime),
					new SqlParameter("@EXCEPTION_CONTENT", SqlDbType.VarChar,2000),
					new SqlParameter("@USE_IP", SqlDbType.VarChar,20)};
			parameters[0].Value = model.EXCEPTION_TIME;
			parameters[1].Value = model.EXCEPTION_CONTENT;
			parameters[2].Value = model.USE_IP;

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
		public bool Update(LW_AskOnline.Model.log_exception model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update log_exception set ");
			strSql.Append("EXCEPTION_TIME=@EXCEPTION_TIME,");
			strSql.Append("EXCEPTION_CONTENT=@EXCEPTION_CONTENT,");
			strSql.Append("USE_IP=@USE_IP");
			strSql.Append(" where EXCEPTION_ID=@EXCEPTION_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EXCEPTION_TIME", SqlDbType.DateTime),
					new SqlParameter("@EXCEPTION_CONTENT", SqlDbType.VarChar,2000),
					new SqlParameter("@USE_IP", SqlDbType.VarChar,20),
					new SqlParameter("@EXCEPTION_ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.EXCEPTION_TIME;
			parameters[1].Value = model.EXCEPTION_CONTENT;
			parameters[2].Value = model.USE_IP;
			parameters[3].Value = model.EXCEPTION_ID;

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
		public bool Delete(long EXCEPTION_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from log_exception ");
			strSql.Append(" where EXCEPTION_ID=@EXCEPTION_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EXCEPTION_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = EXCEPTION_ID;

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
		public bool DeleteList(string EXCEPTION_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from log_exception ");
			strSql.Append(" where EXCEPTION_ID in ("+EXCEPTION_IDlist + ")  ");
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
		public LW_AskOnline.Model.log_exception GetModel(long EXCEPTION_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EXCEPTION_ID,EXCEPTION_TIME,EXCEPTION_CONTENT,USE_IP from log_exception ");
			strSql.Append(" where EXCEPTION_ID=@EXCEPTION_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EXCEPTION_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = EXCEPTION_ID;

			LW_AskOnline.Model.log_exception model=new LW_AskOnline.Model.log_exception();
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
		public LW_AskOnline.Model.log_exception DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.log_exception model=new LW_AskOnline.Model.log_exception();
			if (row != null)
			{
				if(row["EXCEPTION_ID"]!=null && row["EXCEPTION_ID"].ToString()!="")
				{
					model.EXCEPTION_ID=long.Parse(row["EXCEPTION_ID"].ToString());
				}
				if(row["EXCEPTION_TIME"]!=null && row["EXCEPTION_TIME"].ToString()!="")
				{
					model.EXCEPTION_TIME=DateTime.Parse(row["EXCEPTION_TIME"].ToString());
				}
				if(row["EXCEPTION_CONTENT"]!=null)
				{
					model.EXCEPTION_CONTENT=row["EXCEPTION_CONTENT"].ToString();
				}
				if(row["USE_IP"]!=null)
				{
					model.USE_IP=row["USE_IP"].ToString();
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
			strSql.Append("select EXCEPTION_ID,EXCEPTION_TIME,EXCEPTION_CONTENT,USE_IP ");
			strSql.Append(" FROM log_exception ");
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
			strSql.Append(" EXCEPTION_ID,EXCEPTION_TIME,EXCEPTION_CONTENT,USE_IP ");
			strSql.Append(" FROM log_exception ");
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
			strSql.Append("select count(1) FROM log_exception ");
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
				strSql.Append("order by T.EXCEPTION_ID desc");
			}
			strSql.Append(")AS Row, T.*  from log_exception T ");
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
			parameters[0].Value = "log_exception";
			parameters[1].Value = "EXCEPTION_ID";
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

