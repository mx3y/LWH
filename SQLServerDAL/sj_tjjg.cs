using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sj_tjjg
	/// </summary>
	public partial class sj_tjjg:Isj_tjjg
	{
		public sj_tjjg()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal jgid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sj_tjjg");
			strSql.Append(" where jgid=@jgid ");
			SqlParameter[] parameters = {
					new SqlParameter("@jgid", SqlDbType.Decimal,9)			};
			parameters[0].Value = jgid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.sj_tjjg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sj_tjjg(");
			strSql.Append("jgid,enksmc,enwpmc,jl,ksmc,sort,tjsj,wpmc,ysmc,tjid)");
			strSql.Append(" values (");
			strSql.Append("@jgid,@enksmc,@enwpmc,@jl,@ksmc,@sort,@tjsj,@wpmc,@ysmc,@tjid)");
			SqlParameter[] parameters = {
					new SqlParameter("@jgid", SqlDbType.Decimal,9),
					new SqlParameter("@enksmc", SqlDbType.VarChar,200),
					new SqlParameter("@enwpmc", SqlDbType.VarChar,200),
					new SqlParameter("@jl", SqlDbType.Text),
					new SqlParameter("@ksmc", SqlDbType.VarChar,200),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@wpmc", SqlDbType.VarChar,200),
					new SqlParameter("@ysmc", SqlDbType.VarChar,200),
					new SqlParameter("@tjid", SqlDbType.Decimal,9)};
			parameters[0].Value = model.jgid;
			parameters[1].Value = model.enksmc;
			parameters[2].Value = model.enwpmc;
			parameters[3].Value = model.jl;
			parameters[4].Value = model.ksmc;
			parameters[5].Value = model.sort;
			parameters[6].Value = model.tjsj;
			parameters[7].Value = model.wpmc;
			parameters[8].Value = model.ysmc;
			parameters[9].Value = model.tjid;

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
		public bool Update(LW_AskOnline.Model.sj_tjjg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sj_tjjg set ");
			strSql.Append("enksmc=@enksmc,");
			strSql.Append("enwpmc=@enwpmc,");
			strSql.Append("jl=@jl,");
			strSql.Append("ksmc=@ksmc,");
			strSql.Append("sort=@sort,");
			strSql.Append("tjsj=@tjsj,");
			strSql.Append("wpmc=@wpmc,");
			strSql.Append("ysmc=@ysmc,");
			strSql.Append("tjid=@tjid");
			strSql.Append(" where jgid=@jgid ");
			SqlParameter[] parameters = {
					new SqlParameter("@enksmc", SqlDbType.VarChar,200),
					new SqlParameter("@enwpmc", SqlDbType.VarChar,200),
					new SqlParameter("@jl", SqlDbType.Text),
					new SqlParameter("@ksmc", SqlDbType.VarChar,200),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@wpmc", SqlDbType.VarChar,200),
					new SqlParameter("@ysmc", SqlDbType.VarChar,200),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@jgid", SqlDbType.Decimal,9)};
			parameters[0].Value = model.enksmc;
			parameters[1].Value = model.enwpmc;
			parameters[2].Value = model.jl;
			parameters[3].Value = model.ksmc;
			parameters[4].Value = model.sort;
			parameters[5].Value = model.tjsj;
			parameters[6].Value = model.wpmc;
			parameters[7].Value = model.ysmc;
			parameters[8].Value = model.tjid;
			parameters[9].Value = model.jgid;

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
		public bool Delete(decimal jgid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sj_tjjg ");
			strSql.Append(" where jgid=@jgid ");
			SqlParameter[] parameters = {
					new SqlParameter("@jgid", SqlDbType.Decimal,9)			};
			parameters[0].Value = jgid;

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
		public bool DeleteList(string jgidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sj_tjjg ");
			strSql.Append(" where jgid in ("+jgidlist + ")  ");
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
		public LW_AskOnline.Model.sj_tjjg GetModel(decimal jgid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 jgid,enksmc,enwpmc,jl,ksmc,sort,tjsj,wpmc,ysmc,tjid from sj_tjjg ");
			strSql.Append(" where jgid=@jgid ");
			SqlParameter[] parameters = {
					new SqlParameter("@jgid", SqlDbType.Decimal,9)			};
			parameters[0].Value = jgid;

			LW_AskOnline.Model.sj_tjjg model=new LW_AskOnline.Model.sj_tjjg();
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
		public LW_AskOnline.Model.sj_tjjg DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sj_tjjg model=new LW_AskOnline.Model.sj_tjjg();
			if (row != null)
			{
				if(row["jgid"]!=null && row["jgid"].ToString()!="")
				{
					model.jgid=decimal.Parse(row["jgid"].ToString());
				}
				if(row["enksmc"]!=null)
				{
					model.enksmc=row["enksmc"].ToString();
				}
				if(row["enwpmc"]!=null)
				{
					model.enwpmc=row["enwpmc"].ToString();
				}
				if(row["jl"]!=null)
				{
					model.jl=row["jl"].ToString();
				}
				if(row["ksmc"]!=null)
				{
					model.ksmc=row["ksmc"].ToString();
				}
				if(row["sort"]!=null && row["sort"].ToString()!="")
				{
					model.sort=int.Parse(row["sort"].ToString());
				}
				if(row["tjsj"]!=null && row["tjsj"].ToString()!="")
				{
					model.tjsj=DateTime.Parse(row["tjsj"].ToString());
				}
				if(row["wpmc"]!=null)
				{
					model.wpmc=row["wpmc"].ToString();
				}
				if(row["ysmc"]!=null)
				{
					model.ysmc=row["ysmc"].ToString();
				}
				if(row["tjid"]!=null && row["tjid"].ToString()!="")
				{
					model.tjid=decimal.Parse(row["tjid"].ToString());
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
			strSql.Append("select jgid,enksmc,enwpmc,jl,ksmc,sort,tjsj,wpmc,ysmc,tjid ");
			strSql.Append(" FROM sj_tjjg ");
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
			strSql.Append(" jgid,enksmc,enwpmc,jl,ksmc,sort,tjsj,wpmc,ysmc,tjid ");
			strSql.Append(" FROM sj_tjjg ");
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
			strSql.Append("select count(1) FROM sj_tjjg ");
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
				strSql.Append("order by T.jgid desc");
			}
			strSql.Append(")AS Row, T.*  from sj_tjjg T ");
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
			parameters[0].Value = "sj_tjjg";
			parameters[1].Value = "jgid";
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

