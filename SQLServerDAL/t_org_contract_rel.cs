using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_org_contract_rel
	/// </summary>
	public partial class t_org_contract_rel:It_org_contract_rel
	{
		public t_org_contract_rel()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_org_contract_rel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_org_contract_rel");
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
		public int Add(LW_AskOnline.Model.t_org_contract_rel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_org_contract_rel(");
			strSql.Append("orgid,orgname,contractid,contractname,disrate,orgPackageids,orgspecialtime)");
			strSql.Append(" values (");
			strSql.Append("@orgid,@orgname,@contractid,@contractname,@disrate,@orgPackageids,@orgspecialtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@orgid", SqlDbType.Int,4),
					new SqlParameter("@orgname", SqlDbType.VarChar,255),
					new SqlParameter("@contractid", SqlDbType.Int,4),
					new SqlParameter("@contractname", SqlDbType.VarChar,255),
					new SqlParameter("@disrate", SqlDbType.VarChar,255),
					new SqlParameter("@orgPackageids", SqlDbType.VarChar,255),
					new SqlParameter("@orgspecialtime", SqlDbType.VarChar,255)};
			parameters[0].Value = model.orgid;
			parameters[1].Value = model.orgname;
			parameters[2].Value = model.contractid;
			parameters[3].Value = model.contractname;
			parameters[4].Value = model.disrate;
			parameters[5].Value = model.orgPackageids;
			parameters[6].Value = model.orgspecialtime;

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
		public bool Update(LW_AskOnline.Model.t_org_contract_rel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_org_contract_rel set ");
			strSql.Append("orgid=@orgid,");
			strSql.Append("orgname=@orgname,");
			strSql.Append("contractid=@contractid,");
			strSql.Append("contractname=@contractname,");
			strSql.Append("disrate=@disrate,");
			strSql.Append("orgPackageids=@orgPackageids,");
			strSql.Append("orgspecialtime=@orgspecialtime");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@orgid", SqlDbType.Int,4),
					new SqlParameter("@orgname", SqlDbType.VarChar,255),
					new SqlParameter("@contractid", SqlDbType.Int,4),
					new SqlParameter("@contractname", SqlDbType.VarChar,255),
					new SqlParameter("@disrate", SqlDbType.VarChar,255),
					new SqlParameter("@orgPackageids", SqlDbType.VarChar,255),
					new SqlParameter("@orgspecialtime", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.orgid;
			parameters[1].Value = model.orgname;
			parameters[2].Value = model.contractid;
			parameters[3].Value = model.contractname;
			parameters[4].Value = model.disrate;
			parameters[5].Value = model.orgPackageids;
			parameters[6].Value = model.orgspecialtime;
			parameters[7].Value = model.id;

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
			strSql.Append("delete from t_org_contract_rel ");
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
			strSql.Append("delete from t_org_contract_rel ");
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
		public LW_AskOnline.Model.t_org_contract_rel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,orgid,orgname,contractid,contractname,disrate,orgPackageids,orgspecialtime from t_org_contract_rel ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_org_contract_rel model=new LW_AskOnline.Model.t_org_contract_rel();
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
		public LW_AskOnline.Model.t_org_contract_rel DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_org_contract_rel model=new LW_AskOnline.Model.t_org_contract_rel();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["orgid"]!=null && row["orgid"].ToString()!="")
				{
					model.orgid=int.Parse(row["orgid"].ToString());
				}
				if(row["orgname"]!=null)
				{
					model.orgname=row["orgname"].ToString();
				}
				if(row["contractid"]!=null && row["contractid"].ToString()!="")
				{
					model.contractid=int.Parse(row["contractid"].ToString());
				}
				if(row["contractname"]!=null)
				{
					model.contractname=row["contractname"].ToString();
				}
				if(row["disrate"]!=null)
				{
					model.disrate=row["disrate"].ToString();
				}
				if(row["orgPackageids"]!=null)
				{
					model.orgPackageids=row["orgPackageids"].ToString();
				}
				if(row["orgspecialtime"]!=null)
				{
					model.orgspecialtime=row["orgspecialtime"].ToString();
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
			strSql.Append("select id,orgid,orgname,contractid,contractname,disrate,orgPackageids,orgspecialtime ");
			strSql.Append(" FROM t_org_contract_rel ");
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
			strSql.Append(" id,orgid,orgname,contractid,contractname,disrate,orgPackageids,orgspecialtime ");
			strSql.Append(" FROM t_org_contract_rel ");
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
			strSql.Append("select count(1) FROM t_org_contract_rel ");
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
			strSql.Append(")AS Row, T.*  from t_org_contract_rel T ");
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
			parameters[0].Value = "t_org_contract_rel";
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

