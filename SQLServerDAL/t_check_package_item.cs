using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_check_package_item
	/// </summary>
	public partial class t_check_package_item:It_check_package_item
	{
		public t_check_package_item()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_check_package_item"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_check_package_item");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.t_check_package_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_check_package_item(");
			strSql.Append("itemid,standardprice,guideprice,packagename,status,packageid,typeid,contractid,contractname)");
			strSql.Append(" values (");
			strSql.Append("@itemid,@standardprice,@guideprice,@packagename,@status,@packageid,@typeid,@contractid,@contractname)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@itemid", SqlDbType.VarChar,100),
					new SqlParameter("@standardprice", SqlDbType.Float,8),
					new SqlParameter("@guideprice", SqlDbType.Float,8),
					new SqlParameter("@packagename", SqlDbType.VarChar,100),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@packageid", SqlDbType.Int,4),
					new SqlParameter("@typeid", SqlDbType.Int,4),
					new SqlParameter("@contractid", SqlDbType.Decimal,9),
					new SqlParameter("@contractname", SqlDbType.VarChar,255)};
			parameters[0].Value = model.itemid;
			parameters[1].Value = model.standardprice;
			parameters[2].Value = model.guideprice;
			parameters[3].Value = model.packagename;
			parameters[4].Value = model.status;
			parameters[5].Value = model.packageid;
			parameters[6].Value = model.typeid;
			parameters[7].Value = model.contractid;
			parameters[8].Value = model.contractname;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_check_package_item model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_check_package_item set ");
			strSql.Append("itemid=@itemid,");
			strSql.Append("standardprice=@standardprice,");
			strSql.Append("guideprice=@guideprice,");
			strSql.Append("packagename=@packagename,");
			strSql.Append("status=@status,");
			strSql.Append("packageid=@packageid,");
			strSql.Append("typeid=@typeid,");
			strSql.Append("contractid=@contractid,");
			strSql.Append("contractname=@contractname");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@itemid", SqlDbType.VarChar,100),
					new SqlParameter("@standardprice", SqlDbType.Float,8),
					new SqlParameter("@guideprice", SqlDbType.Float,8),
					new SqlParameter("@packagename", SqlDbType.VarChar,100),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@packageid", SqlDbType.Int,4),
					new SqlParameter("@typeid", SqlDbType.Int,4),
					new SqlParameter("@contractid", SqlDbType.Decimal,9),
					new SqlParameter("@contractname", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.itemid;
			parameters[1].Value = model.standardprice;
			parameters[2].Value = model.guideprice;
			parameters[3].Value = model.packagename;
			parameters[4].Value = model.status;
			parameters[5].Value = model.packageid;
			parameters[6].Value = model.typeid;
			parameters[7].Value = model.contractid;
			parameters[8].Value = model.contractname;
			parameters[9].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_check_package_item ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_check_package_item ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public LW_AskOnline.Model.t_check_package_item GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,itemid,standardprice,guideprice,packagename,status,packageid,typeid,contractid,contractname from t_check_package_item ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_check_package_item model=new LW_AskOnline.Model.t_check_package_item();
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
		public LW_AskOnline.Model.t_check_package_item DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_check_package_item model=new LW_AskOnline.Model.t_check_package_item();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["itemid"]!=null)
				{
					model.itemid=row["itemid"].ToString();
				}
				if(row["standardprice"]!=null && row["standardprice"].ToString()!="")
				{
					model.standardprice=decimal.Parse(row["standardprice"].ToString());
				}
				if(row["guideprice"]!=null && row["guideprice"].ToString()!="")
				{
					model.guideprice=decimal.Parse(row["guideprice"].ToString());
				}
				if(row["packagename"]!=null)
				{
					model.packagename=row["packagename"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["packageid"]!=null && row["packageid"].ToString()!="")
				{
					model.packageid=int.Parse(row["packageid"].ToString());
				}
				if(row["typeid"]!=null && row["typeid"].ToString()!="")
				{
					model.typeid=int.Parse(row["typeid"].ToString());
				}
				if(row["contractid"]!=null && row["contractid"].ToString()!="")
				{
					model.contractid=decimal.Parse(row["contractid"].ToString());
				}
				if(row["contractname"]!=null)
				{
					model.contractname=row["contractname"].ToString();
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
			strSql.Append("select id,itemid,standardprice,guideprice,packagename,status,packageid,typeid,contractid,contractname ");
			strSql.Append(" FROM t_check_package_item ");
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
			strSql.Append(" id,itemid,standardprice,guideprice,packagename,status,packageid,typeid,contractid,contractname ");
			strSql.Append(" FROM t_check_package_item ");
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
			strSql.Append("select count(1) FROM t_check_package_item ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from t_check_package_item T ");
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
			parameters[0].Value = "t_check_package_item";
			parameters[1].Value = "id";
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

