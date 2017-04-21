using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_environment
	/// </summary>
	public partial class t_environment:It_environment
	{
		public t_environment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal environment_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_environment");
			strSql.Append(" where environment_id=@environment_id");
			SqlParameter[] parameters = {
					new SqlParameter("@environment_id", SqlDbType.Decimal)
			};
			parameters[0].Value = environment_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_environment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_environment(");
			strSql.Append("environment_name,picture,remark,type)");
			strSql.Append(" values (");
			strSql.Append("@environment_name,@picture,@remark,@type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@environment_name", SqlDbType.VarChar,200),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar,2000),
					new SqlParameter("@type", SqlDbType.VarChar,20)};
			parameters[0].Value = model.environment_name;
			parameters[1].Value = model.picture;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.type;

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
		public bool Update(LW_AskOnline.Model.t_environment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_environment set ");
			strSql.Append("environment_name=@environment_name,");
			strSql.Append("picture=@picture,");
			strSql.Append("remark=@remark,");
			strSql.Append("type=@type");
			strSql.Append(" where environment_id=@environment_id");
			SqlParameter[] parameters = {
					new SqlParameter("@environment_name", SqlDbType.VarChar,200),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar,2000),
					new SqlParameter("@type", SqlDbType.VarChar,20),
					new SqlParameter("@environment_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.environment_name;
			parameters[1].Value = model.picture;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.type;
			parameters[4].Value = model.environment_id;

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
		public bool Delete(decimal environment_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_environment ");
			strSql.Append(" where environment_id=@environment_id");
			SqlParameter[] parameters = {
					new SqlParameter("@environment_id", SqlDbType.Decimal)
			};
			parameters[0].Value = environment_id;

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
		public bool DeleteList(string environment_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_environment ");
			strSql.Append(" where environment_id in ("+environment_idlist + ")  ");
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
		public LW_AskOnline.Model.t_environment GetModel(decimal environment_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 environment_id,environment_name,picture,remark,type from t_environment ");
			strSql.Append(" where environment_id=@environment_id");
			SqlParameter[] parameters = {
					new SqlParameter("@environment_id", SqlDbType.Decimal)
			};
			parameters[0].Value = environment_id;

			LW_AskOnline.Model.t_environment model=new LW_AskOnline.Model.t_environment();
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
		public LW_AskOnline.Model.t_environment DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_environment model=new LW_AskOnline.Model.t_environment();
			if (row != null)
			{
				if(row["environment_id"]!=null && row["environment_id"].ToString()!="")
				{
					model.environment_id=decimal.Parse(row["environment_id"].ToString());
				}
				if(row["environment_name"]!=null)
				{
					model.environment_name=row["environment_name"].ToString();
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
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
			strSql.Append("select environment_id,environment_name,picture,remark,type ");
			strSql.Append(" FROM t_environment ");
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
			strSql.Append(" environment_id,environment_name,picture,remark,type ");
			strSql.Append(" FROM t_environment ");
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
			strSql.Append("select count(1) FROM t_environment ");
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
				strSql.Append("order by T.environment_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_environment T ");
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
			parameters[0].Value = "t_environment";
			parameters[1].Value = "environment_id";
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

