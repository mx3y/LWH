using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sj_fuchas_main
	/// </summary>
	public partial class sj_fuchas_main:Isj_fuchas_main
	{
		public sj_fuchas_main()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sj_fuchas_main");
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
		public decimal Add(LW_AskOnline.Model.sj_fuchas_main model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sj_fuchas_main(");
			strSql.Append("sj,tjsj,tjid,khid,khlx)");
			strSql.Append(" values (");
			strSql.Append("@sj,@tjsj,@tjid,@khid,@khlx)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@sj", SqlDbType.DateTime),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@khlx", SqlDbType.VarChar,10)};
			parameters[0].Value = model.sj;
			parameters[1].Value = model.tjsj;
			parameters[2].Value = model.tjid;
			parameters[3].Value = model.khid;
			parameters[4].Value = model.khlx;

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
		public bool Update(LW_AskOnline.Model.sj_fuchas_main model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sj_fuchas_main set ");
			strSql.Append("sj=@sj,");
			strSql.Append("tjsj=@tjsj,");
			strSql.Append("tjid=@tjid,");
			strSql.Append("khid=@khid,");
			strSql.Append("khlx=@khlx");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@sj", SqlDbType.DateTime),
					new SqlParameter("@tjsj", SqlDbType.DateTime),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@khlx", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.sj;
			parameters[1].Value = model.tjsj;
			parameters[2].Value = model.tjid;
			parameters[3].Value = model.khid;
			parameters[4].Value = model.khlx;
			parameters[5].Value = model.id;

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
			strSql.Append("delete from sj_fuchas_main ");
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
			strSql.Append("delete from sj_fuchas_main ");
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
		public LW_AskOnline.Model.sj_fuchas_main GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,sj,tjsj,tjid,khid,khlx from sj_fuchas_main ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.sj_fuchas_main model=new LW_AskOnline.Model.sj_fuchas_main();
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
		public LW_AskOnline.Model.sj_fuchas_main DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sj_fuchas_main model=new LW_AskOnline.Model.sj_fuchas_main();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["sj"]!=null && row["sj"].ToString()!="")
				{
					model.sj=DateTime.Parse(row["sj"].ToString());
				}
				if(row["tjsj"]!=null && row["tjsj"].ToString()!="")
				{
					model.tjsj=DateTime.Parse(row["tjsj"].ToString());
				}
				if(row["tjid"]!=null && row["tjid"].ToString()!="")
				{
					model.tjid=decimal.Parse(row["tjid"].ToString());
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
			strSql.Append("select id,sj,tjsj,tjid,khid,khlx ");
			strSql.Append(" FROM sj_fuchas_main ");
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
			strSql.Append(" id,sj,tjsj,tjid,khid,khlx ");
			strSql.Append(" FROM sj_fuchas_main ");
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
			strSql.Append("select count(1) FROM sj_fuchas_main ");
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
			strSql.Append(")AS Row, T.*  from sj_fuchas_main T ");
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
			parameters[0].Value = "sj_fuchas_main";
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

