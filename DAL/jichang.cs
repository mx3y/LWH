using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:jichang
	/// </summary>
	public partial class jichang
	{
		public jichang()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("jichang_id", "jichang"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int jichang_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from jichang");
			strSql.Append(" where jichang_id=@jichang_id");
			SqlParameter[] parameters = {
					new SqlParameter("@jichang_id", SqlDbType.Int,4)
			};
			parameters[0].Value = jichang_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.jichang model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into jichang(");
			strSql.Append("jichang_name,jichang_sex,jichang_age,jichang_org,jichang_order_date,jichang_edu,jichang_monery,jichang_company,jigou_monery,jigou_order_date,jigou,monery,dept,company)");
			strSql.Append(" values (");
			strSql.Append("@jichang_name,@jichang_sex,@jichang_age,@jichang_org,@jichang_order_date,@jichang_edu,@jichang_monery,@jichang_company,@jigou_monery,@jigou_order_date,@jigou,@monery,@dept,@company)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@jichang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_sex", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_age", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_org", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_order_date", SqlDbType.DateTime),
					new SqlParameter("@jichang_edu", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_monery", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_company", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou_monery", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou_order_date", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou", SqlDbType.NVarChar,50),
					new SqlParameter("@monery", SqlDbType.NVarChar,50),
					new SqlParameter("@dept", SqlDbType.NVarChar,50),
					new SqlParameter("@company", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.jichang_name;
			parameters[1].Value = model.jichang_sex;
			parameters[2].Value = model.jichang_age;
			parameters[3].Value = model.jichang_org;
			parameters[4].Value = model.jichang_order_date;
			parameters[5].Value = model.jichang_edu;
			parameters[6].Value = model.jichang_monery;
			parameters[7].Value = model.jichang_company;
			parameters[8].Value = model.jigou_monery;
			parameters[9].Value = model.jigou_order_date;
			parameters[10].Value = model.jigou;
			parameters[11].Value = model.monery;
			parameters[12].Value = model.dept;
			parameters[13].Value = model.company;

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
		public bool Update(LW_AskOnline.Model.jichang model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update jichang set ");
			strSql.Append("jichang_name=@jichang_name,");
			strSql.Append("jichang_sex=@jichang_sex,");
			strSql.Append("jichang_age=@jichang_age,");
			strSql.Append("jichang_org=@jichang_org,");
			strSql.Append("jichang_order_date=@jichang_order_date,");
			strSql.Append("jichang_edu=@jichang_edu,");
			strSql.Append("jichang_monery=@jichang_monery,");
			strSql.Append("jichang_company=@jichang_company,");
			strSql.Append("jigou_monery=@jigou_monery,");
			strSql.Append("jigou_order_date=@jigou_order_date,");
			strSql.Append("jigou=@jigou,");
			strSql.Append("monery=@monery,");
			strSql.Append("dept=@dept,");
			strSql.Append("company=@company");
			strSql.Append(" where jichang_id=@jichang_id");
			SqlParameter[] parameters = {
					new SqlParameter("@jichang_name", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_sex", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_age", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_org", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_order_date", SqlDbType.DateTime),
					new SqlParameter("@jichang_edu", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_monery", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_company", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou_monery", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou_order_date", SqlDbType.NVarChar,50),
					new SqlParameter("@jigou", SqlDbType.NVarChar,50),
					new SqlParameter("@monery", SqlDbType.NVarChar,50),
					new SqlParameter("@dept", SqlDbType.NVarChar,50),
					new SqlParameter("@company", SqlDbType.NVarChar,50),
					new SqlParameter("@jichang_id", SqlDbType.Int,4)};
			parameters[0].Value = model.jichang_name;
			parameters[1].Value = model.jichang_sex;
			parameters[2].Value = model.jichang_age;
			parameters[3].Value = model.jichang_org;
			parameters[4].Value = model.jichang_order_date;
			parameters[5].Value = model.jichang_edu;
			parameters[6].Value = model.jichang_monery;
			parameters[7].Value = model.jichang_company;
			parameters[8].Value = model.jigou_monery;
			parameters[9].Value = model.jigou_order_date;
			parameters[10].Value = model.jigou;
			parameters[11].Value = model.monery;
			parameters[12].Value = model.dept;
			parameters[13].Value = model.company;
			parameters[14].Value = model.jichang_id;

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
		public bool Delete(int jichang_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from jichang ");
			strSql.Append(" where jichang_id=@jichang_id");
			SqlParameter[] parameters = {
					new SqlParameter("@jichang_id", SqlDbType.Int,4)
			};
			parameters[0].Value = jichang_id;

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
		public bool DeleteList(string jichang_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from jichang ");
			strSql.Append(" where jichang_id in ("+jichang_idlist + ")  ");
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
		public LW_AskOnline.Model.jichang GetModel(int jichang_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 jichang_id,jichang_name,jichang_sex,jichang_age,jichang_org,jichang_order_date,jichang_edu,jichang_monery,jichang_company,jigou_monery,jigou_order_date,jigou,monery,dept,company from jichang ");
			strSql.Append(" where jichang_id=@jichang_id");
			SqlParameter[] parameters = {
					new SqlParameter("@jichang_id", SqlDbType.Int,4)
			};
			parameters[0].Value = jichang_id;

			LW_AskOnline.Model.jichang model=new LW_AskOnline.Model.jichang();
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
		public LW_AskOnline.Model.jichang DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.jichang model=new LW_AskOnline.Model.jichang();
			if (row != null)
			{
				if(row["jichang_id"]!=null && row["jichang_id"].ToString()!="")
				{
					model.jichang_id=int.Parse(row["jichang_id"].ToString());
				}
				if(row["jichang_name"]!=null)
				{
					model.jichang_name=row["jichang_name"].ToString();
				}
				if(row["jichang_sex"]!=null)
				{
					model.jichang_sex=row["jichang_sex"].ToString();
				}
				if(row["jichang_age"]!=null)
				{
					model.jichang_age=row["jichang_age"].ToString();
				}
				if(row["jichang_org"]!=null)
				{
					model.jichang_org=row["jichang_org"].ToString();
				}
				if(row["jichang_order_date"]!=null && row["jichang_order_date"].ToString()!="")
				{
					model.jichang_order_date=DateTime.Parse(row["jichang_order_date"].ToString());
				}
				if(row["jichang_edu"]!=null)
				{
					model.jichang_edu=row["jichang_edu"].ToString();
				}
				if(row["jichang_monery"]!=null)
				{
					model.jichang_monery=row["jichang_monery"].ToString();
				}
				if(row["jichang_company"]!=null)
				{
					model.jichang_company=row["jichang_company"].ToString();
				}
				if(row["jigou_monery"]!=null)
				{
					model.jigou_monery=row["jigou_monery"].ToString();
				}
				if(row["jigou_order_date"]!=null)
				{
					model.jigou_order_date=row["jigou_order_date"].ToString();
				}
				if(row["jigou"]!=null)
				{
					model.jigou=row["jigou"].ToString();
				}
				if(row["monery"]!=null)
				{
					model.monery=row["monery"].ToString();
				}
				if(row["dept"]!=null)
				{
					model.dept=row["dept"].ToString();
				}
				if(row["company"]!=null)
				{
					model.company=row["company"].ToString();
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
			strSql.Append("select jichang_id,jichang_name,jichang_sex,jichang_age,jichang_org,jichang_order_date,jichang_edu,jichang_monery,jichang_company,jigou_monery,jigou_order_date,jigou,monery,dept,company ");
			strSql.Append(" FROM jichang ");
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
			strSql.Append(" jichang_id,jichang_name,jichang_sex,jichang_age,jichang_org,jichang_order_date,jichang_edu,jichang_monery,jichang_company,jigou_monery,jigou_order_date,jigou,monery,dept,company ");
			strSql.Append(" FROM jichang ");
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
			strSql.Append("select count(1) FROM jichang ");
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
			strSql.Append(")AS Row, T.*  from jichang T ");
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
			parameters[0].Value = "jichang";
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

