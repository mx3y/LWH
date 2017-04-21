using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_office_status_record
	/// </summary>
	public partial class t_office_status_record
	{
		public t_office_status_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal record_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_office_status_record");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_office_status_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_office_status_record(");
			strSql.Append("datetime,status,office_Id,period)");
			strSql.Append(" values (");
			strSql.Append("@datetime,@status,@office_Id,@period)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@datetime", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@office_Id", SqlDbType.Decimal,9),
					new SqlParameter("@period", SqlDbType.VarChar,10)};
			parameters[0].Value = model.datetime;
			parameters[1].Value = model.status;
			parameters[2].Value = model.office_Id;
			parameters[3].Value = model.period;

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
		public bool Update(LW_AskOnline.Model.t_office_status_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_office_status_record set ");
			strSql.Append("datetime=@datetime,");
			strSql.Append("status=@status,");
			strSql.Append("office_Id=@office_Id,");
			strSql.Append("period=@period");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@datetime", SqlDbType.VarChar,20),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@office_Id", SqlDbType.Decimal,9),
					new SqlParameter("@period", SqlDbType.VarChar,10),
					new SqlParameter("@record_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.datetime;
			parameters[1].Value = model.status;
			parameters[2].Value = model.office_Id;
			parameters[3].Value = model.period;
			parameters[4].Value = model.record_id;

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
		public bool Delete(decimal record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_office_status_record ");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

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
		public bool DeleteList(string record_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_office_status_record ");
			strSql.Append(" where record_id in ("+record_idlist + ")  ");
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
		public LW_AskOnline.Model.t_office_status_record GetModel(decimal record_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 record_id,datetime,status,office_Id,period from t_office_status_record ");
			strSql.Append(" where record_id=@record_id");
			SqlParameter[] parameters = {
					new SqlParameter("@record_id", SqlDbType.Decimal)
			};
			parameters[0].Value = record_id;

			LW_AskOnline.Model.t_office_status_record model=new LW_AskOnline.Model.t_office_status_record();
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
		public LW_AskOnline.Model.t_office_status_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_office_status_record model=new LW_AskOnline.Model.t_office_status_record();
			if (row != null)
			{
				if(row["record_id"]!=null && row["record_id"].ToString()!="")
				{
					model.record_id=decimal.Parse(row["record_id"].ToString());
				}
				if(row["datetime"]!=null)
				{
					model.datetime=row["datetime"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["office_Id"]!=null && row["office_Id"].ToString()!="")
				{
					model.office_Id=decimal.Parse(row["office_Id"].ToString());
				}
				if(row["period"]!=null)
				{
					model.period=row["period"].ToString();
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
			strSql.Append("select record_id,datetime,status,office_Id,period ");
			strSql.Append(" FROM t_office_status_record ");
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
			strSql.Append(" record_id,datetime,status,office_Id,period ");
			strSql.Append(" FROM t_office_status_record ");
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
			strSql.Append("select count(1) FROM t_office_status_record ");
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
				strSql.Append("order by T.record_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_office_status_record T ");
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
			parameters[0].Value = "t_office_status_record";
			parameters[1].Value = "record_id";
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

