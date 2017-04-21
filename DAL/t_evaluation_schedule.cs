using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_evaluation_schedule
	/// </summary>
	public partial class t_evaluation_schedule
	{
		public t_evaluation_schedule()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal schedule_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_evaluation_schedule");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_evaluation_schedule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_evaluation_schedule(");
			strSql.Append("picture,evaluation_id)");
			strSql.Append(" values (");
			strSql.Append("@picture,@evaluation_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@picture", SqlDbType.VarChar,255),
					new SqlParameter("@evaluation_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.picture;
			parameters[1].Value = model.evaluation_id;

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
		public bool Update(LW_AskOnline.Model.t_evaluation_schedule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_evaluation_schedule set ");
			strSql.Append("picture=@picture,");
			strSql.Append("evaluation_id=@evaluation_id");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@picture", SqlDbType.VarChar,255),
					new SqlParameter("@evaluation_id", SqlDbType.Decimal,9),
					new SqlParameter("@schedule_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.picture;
			parameters[1].Value = model.evaluation_id;
			parameters[2].Value = model.schedule_id;

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
		public bool Delete(decimal schedule_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_evaluation_schedule ");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

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
		public bool DeleteList(string schedule_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_evaluation_schedule ");
			strSql.Append(" where schedule_id in ("+schedule_idlist + ")  ");
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
		public LW_AskOnline.Model.t_evaluation_schedule GetModel(decimal schedule_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 schedule_id,picture,evaluation_id from t_evaluation_schedule ");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

			LW_AskOnline.Model.t_evaluation_schedule model=new LW_AskOnline.Model.t_evaluation_schedule();
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
		public LW_AskOnline.Model.t_evaluation_schedule DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_evaluation_schedule model=new LW_AskOnline.Model.t_evaluation_schedule();
			if (row != null)
			{
				if(row["schedule_id"]!=null && row["schedule_id"].ToString()!="")
				{
					model.schedule_id=decimal.Parse(row["schedule_id"].ToString());
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
				}
				if(row["evaluation_id"]!=null && row["evaluation_id"].ToString()!="")
				{
					model.evaluation_id=decimal.Parse(row["evaluation_id"].ToString());
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
			strSql.Append("select schedule_id,picture,evaluation_id ");
			strSql.Append(" FROM t_evaluation_schedule ");
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
			strSql.Append(" schedule_id,picture,evaluation_id ");
			strSql.Append(" FROM t_evaluation_schedule ");
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
			strSql.Append("select count(1) FROM t_evaluation_schedule ");
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
				strSql.Append("order by T.schedule_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_evaluation_schedule T ");
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
			parameters[0].Value = "t_evaluation_schedule";
			parameters[1].Value = "schedule_id";
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

