using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:log_dispatch
	/// </summary>
	public partial class log_dispatch:Ilog_dispatch
	{
		public log_dispatch()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.log_dispatch model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into log_dispatch(");
			strSql.Append("LOGID,NAME,USE_TIME,USE_MODULE,CONTENT)");
			strSql.Append(" values (");
			strSql.Append("@LOGID,@NAME,@USE_TIME,@USE_MODULE,@CONTENT)");
			SqlParameter[] parameters = {
					new SqlParameter("@LOGID", SqlDbType.VarChar,20),
					new SqlParameter("@NAME", SqlDbType.VarChar,128),
					new SqlParameter("@USE_TIME", SqlDbType.DateTime),
					new SqlParameter("@USE_MODULE", SqlDbType.VarChar,256),
					new SqlParameter("@CONTENT", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.LOGID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.USE_TIME;
			parameters[3].Value = model.USE_MODULE;
			parameters[4].Value = model.CONTENT;

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
		public bool Update(LW_AskOnline.Model.log_dispatch model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update log_dispatch set ");
			strSql.Append("LOGID=@LOGID,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("USE_TIME=@USE_TIME,");
			strSql.Append("USE_MODULE=@USE_MODULE,");
			strSql.Append("CONTENT=@CONTENT");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@LOGID", SqlDbType.VarChar,20),
					new SqlParameter("@NAME", SqlDbType.VarChar,128),
					new SqlParameter("@USE_TIME", SqlDbType.DateTime),
					new SqlParameter("@USE_MODULE", SqlDbType.VarChar,256),
					new SqlParameter("@CONTENT", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.LOGID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.USE_TIME;
			parameters[3].Value = model.USE_MODULE;
			parameters[4].Value = model.CONTENT;

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
			strSql.Append("delete from log_dispatch ");
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
		public LW_AskOnline.Model.log_dispatch GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LOGID,NAME,USE_TIME,USE_MODULE,CONTENT from log_dispatch ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			LW_AskOnline.Model.log_dispatch model=new LW_AskOnline.Model.log_dispatch();
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
		public LW_AskOnline.Model.log_dispatch DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.log_dispatch model=new LW_AskOnline.Model.log_dispatch();
			if (row != null)
			{
				if(row["LOGID"]!=null)
				{
					model.LOGID=row["LOGID"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["USE_TIME"]!=null && row["USE_TIME"].ToString()!="")
				{
					model.USE_TIME=DateTime.Parse(row["USE_TIME"].ToString());
				}
				if(row["USE_MODULE"]!=null)
				{
					model.USE_MODULE=row["USE_MODULE"].ToString();
				}
				if(row["CONTENT"]!=null)
				{
					model.CONTENT=row["CONTENT"].ToString();
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
			strSql.Append("select LOGID,NAME,USE_TIME,USE_MODULE,CONTENT ");
			strSql.Append(" FROM log_dispatch ");
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
			strSql.Append(" LOGID,NAME,USE_TIME,USE_MODULE,CONTENT ");
			strSql.Append(" FROM log_dispatch ");
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
			strSql.Append("select count(1) FROM log_dispatch ");
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
				strSql.Append("order by T.jichang_id desc");
			}
			strSql.Append(")AS Row, T.*  from log_dispatch T ");
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
			parameters[0].Value = "log_dispatch";
			parameters[1].Value = "jichang_id";
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

