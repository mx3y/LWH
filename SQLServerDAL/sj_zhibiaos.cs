using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:sj_zhibiaos
	/// </summary>
	public partial class sj_zhibiaos:Isj_zhibiaos
	{
		public sj_zhibiaos()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sj_zhibiaos");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.sj_zhibiaos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sj_zhibiaos(");
			strSql.Append("id,ckfw,d1,d2,d3,d4,dw,mc,memo,r,r1,r2,r3,r4,sort,v,v1,v2,v3,tjid,khid,v4,khlx)");
			strSql.Append(" values (");
			strSql.Append("@id,@ckfw,@d1,@d2,@d3,@d4,@dw,@mc,@memo,@r,@r1,@r2,@r3,@r4,@sort,@v,@v1,@v2,@v3,@tjid,@khid,@v4,@khlx)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9),
					new SqlParameter("@ckfw", SqlDbType.VarChar,200),
					new SqlParameter("@d1", SqlDbType.DateTime),
					new SqlParameter("@d2", SqlDbType.DateTime),
					new SqlParameter("@d3", SqlDbType.DateTime),
					new SqlParameter("@d4", SqlDbType.DateTime),
					new SqlParameter("@dw", SqlDbType.VarChar,200),
					new SqlParameter("@mc", SqlDbType.VarChar,200),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@r", SqlDbType.VarChar,20),
					new SqlParameter("@r1", SqlDbType.VarChar,20),
					new SqlParameter("@r2", SqlDbType.VarChar,20),
					new SqlParameter("@r3", SqlDbType.VarChar,20),
					new SqlParameter("@r4", SqlDbType.VarChar,20),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@v", SqlDbType.VarChar,2000),
					new SqlParameter("@v1", SqlDbType.VarChar,2000),
					new SqlParameter("@v2", SqlDbType.VarChar,2000),
					new SqlParameter("@v3", SqlDbType.VarChar,2000),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@v4", SqlDbType.VarChar,2000),
					new SqlParameter("@khlx", SqlDbType.VarChar,10)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.ckfw;
			parameters[2].Value = model.d1;
			parameters[3].Value = model.d2;
			parameters[4].Value = model.d3;
			parameters[5].Value = model.d4;
			parameters[6].Value = model.dw;
			parameters[7].Value = model.mc;
			parameters[8].Value = model.memo;
			parameters[9].Value = model.r;
			parameters[10].Value = model.r1;
			parameters[11].Value = model.r2;
			parameters[12].Value = model.r3;
			parameters[13].Value = model.r4;
			parameters[14].Value = model.sort;
			parameters[15].Value = model.v;
			parameters[16].Value = model.v1;
			parameters[17].Value = model.v2;
			parameters[18].Value = model.v3;
			parameters[19].Value = model.tjid;
			parameters[20].Value = model.khid;
			parameters[21].Value = model.v4;
			parameters[22].Value = model.khlx;

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
		public bool Update(LW_AskOnline.Model.sj_zhibiaos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sj_zhibiaos set ");
			strSql.Append("ckfw=@ckfw,");
			strSql.Append("d1=@d1,");
			strSql.Append("d2=@d2,");
			strSql.Append("d3=@d3,");
			strSql.Append("d4=@d4,");
			strSql.Append("dw=@dw,");
			strSql.Append("mc=@mc,");
			strSql.Append("memo=@memo,");
			strSql.Append("r=@r,");
			strSql.Append("r1=@r1,");
			strSql.Append("r2=@r2,");
			strSql.Append("r3=@r3,");
			strSql.Append("r4=@r4,");
			strSql.Append("sort=@sort,");
			strSql.Append("v=@v,");
			strSql.Append("v1=@v1,");
			strSql.Append("v2=@v2,");
			strSql.Append("v3=@v3,");
			strSql.Append("tjid=@tjid,");
			strSql.Append("khid=@khid,");
			strSql.Append("v4=@v4,");
			strSql.Append("khlx=@khlx");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ckfw", SqlDbType.VarChar,200),
					new SqlParameter("@d1", SqlDbType.DateTime),
					new SqlParameter("@d2", SqlDbType.DateTime),
					new SqlParameter("@d3", SqlDbType.DateTime),
					new SqlParameter("@d4", SqlDbType.DateTime),
					new SqlParameter("@dw", SqlDbType.VarChar,200),
					new SqlParameter("@mc", SqlDbType.VarChar,200),
					new SqlParameter("@memo", SqlDbType.Text),
					new SqlParameter("@r", SqlDbType.VarChar,20),
					new SqlParameter("@r1", SqlDbType.VarChar,20),
					new SqlParameter("@r2", SqlDbType.VarChar,20),
					new SqlParameter("@r3", SqlDbType.VarChar,20),
					new SqlParameter("@r4", SqlDbType.VarChar,20),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@v", SqlDbType.VarChar,2000),
					new SqlParameter("@v1", SqlDbType.VarChar,2000),
					new SqlParameter("@v2", SqlDbType.VarChar,2000),
					new SqlParameter("@v3", SqlDbType.VarChar,2000),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@khid", SqlDbType.Decimal,9),
					new SqlParameter("@v4", SqlDbType.VarChar,2000),
					new SqlParameter("@khlx", SqlDbType.VarChar,10),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ckfw;
			parameters[1].Value = model.d1;
			parameters[2].Value = model.d2;
			parameters[3].Value = model.d3;
			parameters[4].Value = model.d4;
			parameters[5].Value = model.dw;
			parameters[6].Value = model.mc;
			parameters[7].Value = model.memo;
			parameters[8].Value = model.r;
			parameters[9].Value = model.r1;
			parameters[10].Value = model.r2;
			parameters[11].Value = model.r3;
			parameters[12].Value = model.r4;
			parameters[13].Value = model.sort;
			parameters[14].Value = model.v;
			parameters[15].Value = model.v1;
			parameters[16].Value = model.v2;
			parameters[17].Value = model.v3;
			parameters[18].Value = model.tjid;
			parameters[19].Value = model.khid;
			parameters[20].Value = model.v4;
			parameters[21].Value = model.khlx;
			parameters[22].Value = model.id;

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
			strSql.Append("delete from sj_zhibiaos ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9)			};
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
			strSql.Append("delete from sj_zhibiaos ");
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
		public LW_AskOnline.Model.sj_zhibiaos GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ckfw,d1,d2,d3,d4,dw,mc,memo,r,r1,r2,r3,r4,sort,v,v1,v2,v3,tjid,khid,v4,khlx from sj_zhibiaos ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9)			};
			parameters[0].Value = id;

			LW_AskOnline.Model.sj_zhibiaos model=new LW_AskOnline.Model.sj_zhibiaos();
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
		public LW_AskOnline.Model.sj_zhibiaos DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sj_zhibiaos model=new LW_AskOnline.Model.sj_zhibiaos();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["ckfw"]!=null)
				{
					model.ckfw=row["ckfw"].ToString();
				}
				if(row["d1"]!=null && row["d1"].ToString()!="")
				{
					model.d1=DateTime.Parse(row["d1"].ToString());
				}
				if(row["d2"]!=null && row["d2"].ToString()!="")
				{
					model.d2=DateTime.Parse(row["d2"].ToString());
				}
				if(row["d3"]!=null && row["d3"].ToString()!="")
				{
					model.d3=DateTime.Parse(row["d3"].ToString());
				}
				if(row["d4"]!=null && row["d4"].ToString()!="")
				{
					model.d4=DateTime.Parse(row["d4"].ToString());
				}
				if(row["dw"]!=null)
				{
					model.dw=row["dw"].ToString();
				}
				if(row["mc"]!=null)
				{
					model.mc=row["mc"].ToString();
				}
				if(row["memo"]!=null)
				{
					model.memo=row["memo"].ToString();
				}
				if(row["r"]!=null)
				{
					model.r=row["r"].ToString();
				}
				if(row["r1"]!=null)
				{
					model.r1=row["r1"].ToString();
				}
				if(row["r2"]!=null)
				{
					model.r2=row["r2"].ToString();
				}
				if(row["r3"]!=null)
				{
					model.r3=row["r3"].ToString();
				}
				if(row["r4"]!=null)
				{
					model.r4=row["r4"].ToString();
				}
				if(row["sort"]!=null && row["sort"].ToString()!="")
				{
					model.sort=int.Parse(row["sort"].ToString());
				}
				if(row["v"]!=null)
				{
					model.v=row["v"].ToString();
				}
				if(row["v1"]!=null)
				{
					model.v1=row["v1"].ToString();
				}
				if(row["v2"]!=null)
				{
					model.v2=row["v2"].ToString();
				}
				if(row["v3"]!=null)
				{
					model.v3=row["v3"].ToString();
				}
				if(row["tjid"]!=null && row["tjid"].ToString()!="")
				{
					model.tjid=decimal.Parse(row["tjid"].ToString());
				}
				if(row["khid"]!=null && row["khid"].ToString()!="")
				{
					model.khid=decimal.Parse(row["khid"].ToString());
				}
				if(row["v4"]!=null)
				{
					model.v4=row["v4"].ToString();
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
			strSql.Append("select id,ckfw,d1,d2,d3,d4,dw,mc,memo,r,r1,r2,r3,r4,sort,v,v1,v2,v3,tjid,khid,v4,khlx ");
			strSql.Append(" FROM sj_zhibiaos ");
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
			strSql.Append(" id,ckfw,d1,d2,d3,d4,dw,mc,memo,r,r1,r2,r3,r4,sort,v,v1,v2,v3,tjid,khid,v4,khlx ");
			strSql.Append(" FROM sj_zhibiaos ");
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
			strSql.Append("select count(1) FROM sj_zhibiaos ");
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
			strSql.Append(")AS Row, T.*  from sj_zhibiaos T ");
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
			parameters[0].Value = "sj_zhibiaos";
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

