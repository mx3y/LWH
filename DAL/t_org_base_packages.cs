using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_org_base_packages
	/// </summary>
	public partial class t_org_base_packages
	{
		public t_org_base_packages()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_org_base_packages");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_org_base_packages model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_org_base_packages(");
			strSql.Append("itemid,orgid,orgname,packagename,packageprice,sexlimit,typeid,recindex,zzitemids,createtime)");
			strSql.Append(" values (");
			strSql.Append("@itemid,@orgid,@orgname,@packagename,@packageprice,@sexlimit,@typeid,@recindex,@zzitemids,@createtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@itemid", SqlDbType.VarChar,500),
					new SqlParameter("@orgid", SqlDbType.Decimal,9),
					new SqlParameter("@orgname", SqlDbType.VarChar,255),
					new SqlParameter("@packagename", SqlDbType.VarChar,255),
					new SqlParameter("@packageprice", SqlDbType.VarChar,255),
					new SqlParameter("@sexlimit", SqlDbType.VarChar,255),
					new SqlParameter("@typeid", SqlDbType.VarChar,500),
					new SqlParameter("@recindex", SqlDbType.VarChar,255),
					new SqlParameter("@zzitemids", SqlDbType.VarChar,255),
					new SqlParameter("@createtime", SqlDbType.DateTime)};
			parameters[0].Value = model.itemid;
			parameters[1].Value = model.orgid;
			parameters[2].Value = model.orgname;
			parameters[3].Value = model.packagename;
			parameters[4].Value = model.packageprice;
			parameters[5].Value = model.sexlimit;
			parameters[6].Value = model.typeid;
			parameters[7].Value = model.recindex;
			parameters[8].Value = model.zzitemids;
			parameters[9].Value = model.createtime;

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
		public bool Update(LW_AskOnline.Model.t_org_base_packages model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_org_base_packages set ");
			strSql.Append("itemid=@itemid,");
			strSql.Append("orgid=@orgid,");
			strSql.Append("orgname=@orgname,");
			strSql.Append("packagename=@packagename,");
			strSql.Append("packageprice=@packageprice,");
			strSql.Append("sexlimit=@sexlimit,");
			strSql.Append("typeid=@typeid,");
			strSql.Append("recindex=@recindex,");
			strSql.Append("zzitemids=@zzitemids,");
			strSql.Append("createtime=@createtime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@itemid", SqlDbType.VarChar,500),
					new SqlParameter("@orgid", SqlDbType.Decimal,9),
					new SqlParameter("@orgname", SqlDbType.VarChar,255),
					new SqlParameter("@packagename", SqlDbType.VarChar,255),
					new SqlParameter("@packageprice", SqlDbType.VarChar,255),
					new SqlParameter("@sexlimit", SqlDbType.VarChar,255),
					new SqlParameter("@typeid", SqlDbType.VarChar,500),
					new SqlParameter("@recindex", SqlDbType.VarChar,255),
					new SqlParameter("@zzitemids", SqlDbType.VarChar,255),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.itemid;
			parameters[1].Value = model.orgid;
			parameters[2].Value = model.orgname;
			parameters[3].Value = model.packagename;
			parameters[4].Value = model.packageprice;
			parameters[5].Value = model.sexlimit;
			parameters[6].Value = model.typeid;
			parameters[7].Value = model.recindex;
			parameters[8].Value = model.zzitemids;
			parameters[9].Value = model.createtime;
			parameters[10].Value = model.id;

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
		public bool Delete(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_org_base_packages ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
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
			strSql.Append("delete from t_org_base_packages ");
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
		public LW_AskOnline.Model.t_org_base_packages GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,itemid,orgid,orgname,packagename,packageprice,sexlimit,typeid,recindex,zzitemids,createtime from t_org_base_packages ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_org_base_packages model=new LW_AskOnline.Model.t_org_base_packages();
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
		public LW_AskOnline.Model.t_org_base_packages DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_org_base_packages model=new LW_AskOnline.Model.t_org_base_packages();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["itemid"]!=null)
				{
					model.itemid=row["itemid"].ToString();
				}
				if(row["orgid"]!=null && row["orgid"].ToString()!="")
				{
					model.orgid=decimal.Parse(row["orgid"].ToString());
				}
				if(row["orgname"]!=null)
				{
					model.orgname=row["orgname"].ToString();
				}
				if(row["packagename"]!=null)
				{
					model.packagename=row["packagename"].ToString();
				}
				if(row["packageprice"]!=null)
				{
					model.packageprice=row["packageprice"].ToString();
				}
				if(row["sexlimit"]!=null)
				{
					model.sexlimit=row["sexlimit"].ToString();
				}
				if(row["typeid"]!=null)
				{
					model.typeid=row["typeid"].ToString();
				}
				if(row["recindex"]!=null)
				{
					model.recindex=row["recindex"].ToString();
				}
				if(row["zzitemids"]!=null)
				{
					model.zzitemids=row["zzitemids"].ToString();
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
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
			strSql.Append("select id,itemid,orgid,orgname,packagename,packageprice,sexlimit,typeid,recindex,zzitemids,createtime ");
			strSql.Append(" FROM t_org_base_packages ");
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
			strSql.Append(" id,itemid,orgid,orgname,packagename,packageprice,sexlimit,typeid,recindex,zzitemids,createtime ");
			strSql.Append(" FROM t_org_base_packages ");
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
			strSql.Append("select count(1) FROM t_org_base_packages ");
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
			strSql.Append(")AS Row, T.*  from t_org_base_packages T ");
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
			parameters[0].Value = "t_org_base_packages";
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

