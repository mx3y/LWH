using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:log_use
	/// </summary>
	public partial class log_use:Ilog_use
	{
		public log_use()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.log_use model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into log_use(");
			strSql.Append("LOGID,DEPTID,USERID,USE_TIME,USE_MODULE,USE_OPERATION,USE_DESCRIBLE,USE_IP)");
			strSql.Append(" values (");
			strSql.Append("@LOGID,@DEPTID,@USERID,@USE_TIME,@USE_MODULE,@USE_OPERATION,@USE_DESCRIBLE,@USE_IP)");
			SqlParameter[] parameters = {
					new SqlParameter("@LOGID", SqlDbType.VarChar,42),
					new SqlParameter("@DEPTID", SqlDbType.VarChar,20),
					new SqlParameter("@USERID", SqlDbType.VarChar,42),
					new SqlParameter("@USE_TIME", SqlDbType.DateTime),
					new SqlParameter("@USE_MODULE", SqlDbType.VarChar,200),
					new SqlParameter("@USE_OPERATION", SqlDbType.VarChar,200),
					new SqlParameter("@USE_DESCRIBLE", SqlDbType.VarChar,1000),
					new SqlParameter("@USE_IP", SqlDbType.VarChar,20)};
			parameters[0].Value = model.LOGID;
			parameters[1].Value = model.DEPTID;
			parameters[2].Value = model.USERID;
			parameters[3].Value = model.USE_TIME;
			parameters[4].Value = model.USE_MODULE;
			parameters[5].Value = model.USE_OPERATION;
			parameters[6].Value = model.USE_DESCRIBLE;
			parameters[7].Value = model.USE_IP;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.log_use model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update log_use set ");
			strSql.Append("LOGID=@LOGID,");
			strSql.Append("DEPTID=@DEPTID,");
			strSql.Append("USERID=@USERID,");
			strSql.Append("USE_TIME=@USE_TIME,");
			strSql.Append("USE_MODULE=@USE_MODULE,");
			strSql.Append("USE_OPERATION=@USE_OPERATION,");
			strSql.Append("USE_DESCRIBLE=@USE_DESCRIBLE,");
			strSql.Append("USE_IP=@USE_IP");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@LOGID", SqlDbType.VarChar,42),
					new SqlParameter("@DEPTID", SqlDbType.VarChar,20),
					new SqlParameter("@USERID", SqlDbType.VarChar,42),
					new SqlParameter("@USE_TIME", SqlDbType.DateTime),
					new SqlParameter("@USE_MODULE", SqlDbType.VarChar,200),
					new SqlParameter("@USE_OPERATION", SqlDbType.VarChar,200),
					new SqlParameter("@USE_DESCRIBLE", SqlDbType.VarChar,1000),
					new SqlParameter("@USE_IP", SqlDbType.VarChar,20)};
			parameters[0].Value = model.LOGID;
			parameters[1].Value = model.DEPTID;
			parameters[2].Value = model.USERID;
			parameters[3].Value = model.USE_TIME;
			parameters[4].Value = model.USE_MODULE;
			parameters[5].Value = model.USE_OPERATION;
			parameters[6].Value = model.USE_DESCRIBLE;
			parameters[7].Value = model.USE_IP;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from log_use ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public LW_AskOnline.Model.log_use GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LOGID,DEPTID,USERID,USE_TIME,USE_MODULE,USE_OPERATION,USE_DESCRIBLE,USE_IP from log_use ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			LW_AskOnline.Model.log_use model=new LW_AskOnline.Model.log_use();
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
		public LW_AskOnline.Model.log_use DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.log_use model=new LW_AskOnline.Model.log_use();
			if (row != null)
			{
				if(row["LOGID"]!=null)
				{
					model.LOGID=row["LOGID"].ToString();
				}
				if(row["DEPTID"]!=null)
				{
					model.DEPTID=row["DEPTID"].ToString();
				}
				if(row["USERID"]!=null)
				{
					model.USERID=row["USERID"].ToString();
				}
				if(row["USE_TIME"]!=null && row["USE_TIME"].ToString()!="")
				{
					model.USE_TIME=DateTime.Parse(row["USE_TIME"].ToString());
				}
				if(row["USE_MODULE"]!=null)
				{
					model.USE_MODULE=row["USE_MODULE"].ToString();
				}
				if(row["USE_OPERATION"]!=null)
				{
					model.USE_OPERATION=row["USE_OPERATION"].ToString();
				}
				if(row["USE_DESCRIBLE"]!=null)
				{
					model.USE_DESCRIBLE=row["USE_DESCRIBLE"].ToString();
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
			strSql.Append("select LOGID,DEPTID,USERID,USE_TIME,USE_MODULE,USE_OPERATION,USE_DESCRIBLE,USE_IP ");
			strSql.Append(" FROM log_use ");
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
			strSql.Append(" LOGID,DEPTID,USERID,USE_TIME,USE_MODULE,USE_OPERATION,USE_DESCRIBLE,USE_IP ");
			strSql.Append(" FROM log_use ");
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
			strSql.Append("select count(1) FROM log_use ");
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
			strSql.Append(")AS Row, T.*  from log_use T ");
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
			parameters[0].Value = "log_use";
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

