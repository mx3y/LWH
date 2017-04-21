using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_check_project_item
	/// </summary>
	public partial class t_check_project_item
	{
		public t_check_project_item()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal item_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_check_project_item");
			strSql.Append(" where item_id=@item_id");
			SqlParameter[] parameters = {
					new SqlParameter("@item_id", SqlDbType.Decimal)
			};
			parameters[0].Value = item_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_check_project_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_check_project_item(");
			strSql.Append("itme_name,reference_value,result,report_id)");
			strSql.Append(" values (");
			strSql.Append("@itme_name,@reference_value,@result,@report_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@itme_name", SqlDbType.VarChar,100),
					new SqlParameter("@reference_value", SqlDbType.VarChar,10),
					new SqlParameter("@result", SqlDbType.VarChar,50),
					new SqlParameter("@report_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.itme_name;
			parameters[1].Value = model.reference_value;
			parameters[2].Value = model.result;
			parameters[3].Value = model.report_id;

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
		public bool Update(LW_AskOnline.Model.t_check_project_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_check_project_item set ");
			strSql.Append("itme_name=@itme_name,");
			strSql.Append("reference_value=@reference_value,");
			strSql.Append("result=@result,");
			strSql.Append("report_id=@report_id");
			strSql.Append(" where item_id=@item_id");
			SqlParameter[] parameters = {
					new SqlParameter("@itme_name", SqlDbType.VarChar,100),
					new SqlParameter("@reference_value", SqlDbType.VarChar,10),
					new SqlParameter("@result", SqlDbType.VarChar,50),
					new SqlParameter("@report_id", SqlDbType.Decimal,9),
					new SqlParameter("@item_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.itme_name;
			parameters[1].Value = model.reference_value;
			parameters[2].Value = model.result;
			parameters[3].Value = model.report_id;
			parameters[4].Value = model.item_id;

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
		public bool Delete(decimal item_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_check_project_item ");
			strSql.Append(" where item_id=@item_id");
			SqlParameter[] parameters = {
					new SqlParameter("@item_id", SqlDbType.Decimal)
			};
			parameters[0].Value = item_id;

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
		public bool DeleteList(string item_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_check_project_item ");
			strSql.Append(" where item_id in ("+item_idlist + ")  ");
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
		public LW_AskOnline.Model.t_check_project_item GetModel(decimal item_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 item_id,itme_name,reference_value,result,report_id from t_check_project_item ");
			strSql.Append(" where item_id=@item_id");
			SqlParameter[] parameters = {
					new SqlParameter("@item_id", SqlDbType.Decimal)
			};
			parameters[0].Value = item_id;

			LW_AskOnline.Model.t_check_project_item model=new LW_AskOnline.Model.t_check_project_item();
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
		public LW_AskOnline.Model.t_check_project_item DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_check_project_item model=new LW_AskOnline.Model.t_check_project_item();
			if (row != null)
			{
				if(row["item_id"]!=null && row["item_id"].ToString()!="")
				{
					model.item_id=decimal.Parse(row["item_id"].ToString());
				}
				if(row["itme_name"]!=null)
				{
					model.itme_name=row["itme_name"].ToString();
				}
				if(row["reference_value"]!=null)
				{
					model.reference_value=row["reference_value"].ToString();
				}
				if(row["result"]!=null)
				{
					model.result=row["result"].ToString();
				}
				if(row["report_id"]!=null && row["report_id"].ToString()!="")
				{
					model.report_id=decimal.Parse(row["report_id"].ToString());
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
			strSql.Append("select item_id,itme_name,reference_value,result,report_id ");
			strSql.Append(" FROM t_check_project_item ");
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
			strSql.Append(" item_id,itme_name,reference_value,result,report_id ");
			strSql.Append(" FROM t_check_project_item ");
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
			strSql.Append("select count(1) FROM t_check_project_item ");
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
				strSql.Append("order by T.item_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_check_project_item T ");
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
			parameters[0].Value = "t_check_project_item";
			parameters[1].Value = "item_id";
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

