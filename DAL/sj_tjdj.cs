using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sj_tjdj
	/// </summary>
	public partial class sj_tjdj
	{
		public sj_tjdj()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal tjid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sj_tjdj");
			strSql.Append(" where tjid=@tjid ");
			SqlParameter[] parameters = {
					new SqlParameter("@tjid", SqlDbType.Decimal,9)			};
			parameters[0].Value = tjid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.sj_tjdj model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sj_tjdj(");
			strSql.Append("tjid,je,tcmc,tjsj,zjsj,zjys,khid,khlx)");
			strSql.Append(" values (");
			strSql.Append("@tjid,@je,@tcmc,@tjsj,@zjsj,@zjys,@khid,@khlx)");
			SqlParameter[] parameters = {
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@je", SqlDbType.Float,8),
					new SqlParameter("@tcmc", SqlDbType.VarChar,2000),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@zjsj", SqlDbType.DateTime),
					new SqlParameter("@zjys", SqlDbType.VarChar,20),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@khlx", SqlDbType.VarChar,10)};
			parameters[0].Value = model.tjid;
			parameters[1].Value = model.je;
			parameters[2].Value = model.tcmc;
			parameters[3].Value = model.tjsj;
			parameters[4].Value = model.zjsj;
			parameters[5].Value = model.zjys;
			parameters[6].Value = model.khid;
			parameters[7].Value = model.khlx;

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
		public bool Update(LW_AskOnline.Model.sj_tjdj model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sj_tjdj set ");
			strSql.Append("je=@je,");
			strSql.Append("tcmc=@tcmc,");
			strSql.Append("tjsj=@tjsj,");
			strSql.Append("zjsj=@zjsj,");
			strSql.Append("zjys=@zjys,");
			strSql.Append("khid=@khid,");
			strSql.Append("khlx=@khlx");
			strSql.Append(" where tjid=@tjid ");
			SqlParameter[] parameters = {
					new SqlParameter("@je", SqlDbType.Float,8),
					new SqlParameter("@tcmc", SqlDbType.VarChar,2000),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@zjsj", SqlDbType.DateTime),
					new SqlParameter("@zjys", SqlDbType.VarChar,20),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@khlx", SqlDbType.VarChar,10),
					new SqlParameter("@tjid", SqlDbType.Decimal,9)};
			parameters[0].Value = model.je;
			parameters[1].Value = model.tcmc;
			parameters[2].Value = model.tjsj;
			parameters[3].Value = model.zjsj;
			parameters[4].Value = model.zjys;
			parameters[5].Value = model.khid;
			parameters[6].Value = model.khlx;
			parameters[7].Value = model.tjid;

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
		public bool Delete(decimal tjid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sj_tjdj ");
			strSql.Append(" where tjid=@tjid ");
			SqlParameter[] parameters = {
					new SqlParameter("@tjid", SqlDbType.Decimal,9)			};
			parameters[0].Value = tjid;

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
		public bool DeleteList(string tjidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sj_tjdj ");
			strSql.Append(" where tjid in ("+tjidlist + ")  ");
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
		public LW_AskOnline.Model.sj_tjdj GetModel(decimal tjid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 tjid,je,tcmc,tjsj,zjsj,zjys,khid,khlx from sj_tjdj ");
			strSql.Append(" where tjid=@tjid ");
			SqlParameter[] parameters = {
					new SqlParameter("@tjid", SqlDbType.Decimal,9)			};
			parameters[0].Value = tjid;

			LW_AskOnline.Model.sj_tjdj model=new LW_AskOnline.Model.sj_tjdj();
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
		public LW_AskOnline.Model.sj_tjdj DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sj_tjdj model=new LW_AskOnline.Model.sj_tjdj();
			if (row != null)
			{
				if(row["tjid"]!=null && row["tjid"].ToString()!="")
				{
					model.tjid=decimal.Parse(row["tjid"].ToString());
				}
				if(row["je"]!=null && row["je"].ToString()!="")
				{
					model.je=decimal.Parse(row["je"].ToString());
				}
				if(row["tcmc"]!=null)
				{
					model.tcmc=row["tcmc"].ToString();
				}
				if(row["tjsj"]!=null && row["tjsj"].ToString()!="")
				{
					model.tjsj=DateTime.Parse(row["tjsj"].ToString());
				}
				if(row["zjsj"]!=null && row["zjsj"].ToString()!="")
				{
					model.zjsj=DateTime.Parse(row["zjsj"].ToString());
				}
				if(row["zjys"]!=null)
				{
					model.zjys=row["zjys"].ToString();
				}
				if(row["khid"]!=null && row["khid"].ToString()!="")
				{
					model.khid=decimal.Parse(row["khid"].ToString());
				}
				if(row["khlx"]!=null)
				{
					model.khlx=row["khlx"].ToString();
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
			strSql.Append("select tjid,je,tcmc,tjsj,zjsj,zjys,khid,khlx ");
			strSql.Append(" FROM sj_tjdj ");
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
			strSql.Append(" tjid,je,tcmc,tjsj,zjsj,zjys,khid,khlx ");
			strSql.Append(" FROM sj_tjdj ");
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
			strSql.Append("select count(1) FROM sj_tjdj ");
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
				strSql.Append("order by T.tjid desc");
			}
			strSql.Append(")AS Row, T.*  from sj_tjdj T ");
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
			parameters[0].Value = "sj_tjdj";
			parameters[1].Value = "tjid";
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

