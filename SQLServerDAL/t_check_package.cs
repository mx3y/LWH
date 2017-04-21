using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_check_package
	/// </summary>
	public partial class t_check_package:It_check_package
	{
		public t_check_package()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_check_package"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_check_package");
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
		public int Add(LW_AskOnline.Model.t_check_package model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_check_package(");
			strSql.Append("contractid,packages,price,avouredprice,usesex,contractname,avoured_price,org_id,package,jcitemids,kxitemids)");
			strSql.Append(" values (");
			strSql.Append("@contractid,@packages,@price,@avouredprice,@usesex,@contractname,@avoured_price,@org_id,@package,@jcitemids,@kxitemids)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@contractid", SqlDbType.Int,4),
					new SqlParameter("@packages", SqlDbType.VarChar,100),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@avouredprice", SqlDbType.Float,8),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@contractname", SqlDbType.VarChar,255),
					new SqlParameter("@avoured_price", SqlDbType.Float,8),
					new SqlParameter("@org_id", SqlDbType.Decimal,9),
					new SqlParameter("@package", SqlDbType.VarChar,100),
					new SqlParameter("@jcitemids", SqlDbType.VarChar,4000),
					new SqlParameter("@kxitemids", SqlDbType.VarChar,4000)};
			parameters[0].Value = model.contractid;
			parameters[1].Value = model.packages;
			parameters[2].Value = model.price;
			parameters[3].Value = model.avouredprice;
			parameters[4].Value = model.usesex;
			parameters[5].Value = model.contractname;
			parameters[6].Value = model.avoured_price;
			parameters[7].Value = model.org_id;
			parameters[8].Value = model.package;
			parameters[9].Value = model.jcitemids;
			parameters[10].Value = model.kxitemids;

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
		public bool Update(LW_AskOnline.Model.t_check_package model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_check_package set ");
			strSql.Append("contractid=@contractid,");
			strSql.Append("packages=@packages,");
			strSql.Append("price=@price,");
			strSql.Append("avouredprice=@avouredprice,");
			strSql.Append("usesex=@usesex,");
			strSql.Append("contractname=@contractname,");
			strSql.Append("avoured_price=@avoured_price,");
			strSql.Append("org_id=@org_id,");
			strSql.Append("package=@package,");
			strSql.Append("jcitemids=@jcitemids,");
			strSql.Append("kxitemids=@kxitemids");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@contractid", SqlDbType.Int,4),
					new SqlParameter("@packages", SqlDbType.VarChar,100),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@avouredprice", SqlDbType.Float,8),
					new SqlParameter("@usesex", SqlDbType.VarChar,255),
					new SqlParameter("@contractname", SqlDbType.VarChar,255),
					new SqlParameter("@avoured_price", SqlDbType.Float,8),
					new SqlParameter("@org_id", SqlDbType.Decimal,9),
					new SqlParameter("@package", SqlDbType.VarChar,100),
					new SqlParameter("@jcitemids", SqlDbType.VarChar,4000),
					new SqlParameter("@kxitemids", SqlDbType.VarChar,4000),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.contractid;
			parameters[1].Value = model.packages;
			parameters[2].Value = model.price;
			parameters[3].Value = model.avouredprice;
			parameters[4].Value = model.usesex;
			parameters[5].Value = model.contractname;
			parameters[6].Value = model.avoured_price;
			parameters[7].Value = model.org_id;
			parameters[8].Value = model.package;
			parameters[9].Value = model.jcitemids;
			parameters[10].Value = model.kxitemids;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from t_check_package ");
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
			strSql.Append("delete from t_check_package ");
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
		public LW_AskOnline.Model.t_check_package GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,contractid,packages,price,avouredprice,usesex,contractname,avoured_price,org_id,package,jcitemids,kxitemids from t_check_package ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_check_package model=new LW_AskOnline.Model.t_check_package();
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
		public LW_AskOnline.Model.t_check_package DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_check_package model=new LW_AskOnline.Model.t_check_package();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["contractid"]!=null && row["contractid"].ToString()!="")
				{
					model.contractid=int.Parse(row["contractid"].ToString());
				}
				if(row["packages"]!=null)
				{
					model.packages=row["packages"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["avouredprice"]!=null && row["avouredprice"].ToString()!="")
				{
					model.avouredprice=decimal.Parse(row["avouredprice"].ToString());
				}
				if(row["usesex"]!=null)
				{
					model.usesex=row["usesex"].ToString();
				}
				if(row["contractname"]!=null)
				{
					model.contractname=row["contractname"].ToString();
				}
				if(row["avoured_price"]!=null && row["avoured_price"].ToString()!="")
				{
					model.avoured_price=decimal.Parse(row["avoured_price"].ToString());
				}
				if(row["org_id"]!=null && row["org_id"].ToString()!="")
				{
					model.org_id=decimal.Parse(row["org_id"].ToString());
				}
				if(row["package"]!=null)
				{
					model.package=row["package"].ToString();
				}
				if(row["jcitemids"]!=null)
				{
					model.jcitemids=row["jcitemids"].ToString();
				}
				if(row["kxitemids"]!=null)
				{
					model.kxitemids=row["kxitemids"].ToString();
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
			strSql.Append("select id,contractid,packages,price,avouredprice,usesex,contractname,avoured_price,org_id,package,jcitemids,kxitemids ");
			strSql.Append(" FROM t_check_package ");
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
			strSql.Append(" id,contractid,packages,price,avouredprice,usesex,contractname,avoured_price,org_id,package,jcitemids,kxitemids ");
			strSql.Append(" FROM t_check_package ");
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
			strSql.Append("select count(1) FROM t_check_package ");
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
			strSql.Append(")AS Row, T.*  from t_check_package T ");
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
			parameters[0].Value = "t_check_package";
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

