using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:log_login
	/// </summary>
	public partial class log_login
	{
		public log_login()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long LOG_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from log_login");
			strSql.Append(" where LOG_ID=@LOG_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@LOG_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = LOG_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.log_login model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into log_login(");
			strSql.Append("USER_ID,LOGIN_NAME,LOGIN_TIME,LOGIN_IP,LOGIN_MESSAGE)");
			strSql.Append(" values (");
			strSql.Append("@USER_ID,@LOGIN_NAME,@LOGIN_TIME,@LOGIN_IP,@LOGIN_MESSAGE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.BigInt,8),
					new SqlParameter("@LOGIN_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@LOGIN_IP", SqlDbType.VarChar,100),
					new SqlParameter("@LOGIN_MESSAGE", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.USER_ID;
			parameters[1].Value = model.LOGIN_NAME;
			parameters[2].Value = model.LOGIN_TIME;
			parameters[3].Value = model.LOGIN_IP;
			parameters[4].Value = model.LOGIN_MESSAGE;

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
		public bool Update(LW_AskOnline.Model.log_login model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update log_login set ");
			strSql.Append("USER_ID=@USER_ID,");
			strSql.Append("LOGIN_NAME=@LOGIN_NAME,");
			strSql.Append("LOGIN_TIME=@LOGIN_TIME,");
			strSql.Append("LOGIN_IP=@LOGIN_IP,");
			strSql.Append("LOGIN_MESSAGE=@LOGIN_MESSAGE");
			strSql.Append(" where LOG_ID=@LOG_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.BigInt,8),
					new SqlParameter("@LOGIN_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@LOGIN_IP", SqlDbType.VarChar,100),
					new SqlParameter("@LOGIN_MESSAGE", SqlDbType.VarChar,1000),
					new SqlParameter("@LOG_ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.USER_ID;
			parameters[1].Value = model.LOGIN_NAME;
			parameters[2].Value = model.LOGIN_TIME;
			parameters[3].Value = model.LOGIN_IP;
			parameters[4].Value = model.LOGIN_MESSAGE;
			parameters[5].Value = model.LOG_ID;

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
		public bool Delete(long LOG_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from log_login ");
			strSql.Append(" where LOG_ID=@LOG_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@LOG_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = LOG_ID;

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
		public bool DeleteList(string LOG_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from log_login ");
			strSql.Append(" where LOG_ID in ("+LOG_IDlist + ")  ");
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
		public LW_AskOnline.Model.log_login GetModel(long LOG_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LOG_ID,USER_ID,LOGIN_NAME,LOGIN_TIME,LOGIN_IP,LOGIN_MESSAGE from log_login ");
			strSql.Append(" where LOG_ID=@LOG_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@LOG_ID", SqlDbType.BigInt)
			};
			parameters[0].Value = LOG_ID;

			LW_AskOnline.Model.log_login model=new LW_AskOnline.Model.log_login();
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
		public LW_AskOnline.Model.log_login DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.log_login model=new LW_AskOnline.Model.log_login();
			if (row != null)
			{
				if(row["LOG_ID"]!=null && row["LOG_ID"].ToString()!="")
				{
					model.LOG_ID=long.Parse(row["LOG_ID"].ToString());
				}
				if(row["USER_ID"]!=null && row["USER_ID"].ToString()!="")
				{
					model.USER_ID=long.Parse(row["USER_ID"].ToString());
				}
				if(row["LOGIN_NAME"]!=null)
				{
					model.LOGIN_NAME=row["LOGIN_NAME"].ToString();
				}
				if(row["LOGIN_TIME"]!=null && row["LOGIN_TIME"].ToString()!="")
				{
					model.LOGIN_TIME=DateTime.Parse(row["LOGIN_TIME"].ToString());
				}
				if(row["LOGIN_IP"]!=null)
				{
					model.LOGIN_IP=row["LOGIN_IP"].ToString();
				}
				if(row["LOGIN_MESSAGE"]!=null)
				{
					model.LOGIN_MESSAGE=row["LOGIN_MESSAGE"].ToString();
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
			strSql.Append("select LOG_ID,USER_ID,LOGIN_NAME,LOGIN_TIME,LOGIN_IP,LOGIN_MESSAGE ");
			strSql.Append(" FROM log_login ");
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
			strSql.Append(" LOG_ID,USER_ID,LOGIN_NAME,LOGIN_TIME,LOGIN_IP,LOGIN_MESSAGE ");
			strSql.Append(" FROM log_login ");
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
			strSql.Append("select count(1) FROM log_login ");
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
				strSql.Append("order by T.LOG_ID desc");
			}
			strSql.Append(")AS Row, T.*  from log_login T ");
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
			parameters[0].Value = "log_login";
			parameters[1].Value = "LOG_ID";
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

