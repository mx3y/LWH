using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sj_tjjg1
	/// </summary>
	public partial class sj_tjjg1
	{
		public sj_tjjg1()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sj_tjjg1");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LW_AskOnline.Model.sj_tjjg1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sj_tjjg1(");
			strSql.Append("id,cankao,enxmmc,jl,pic,result,value,xmmc,jgid,tjid)");
			strSql.Append(" values (");
			strSql.Append("@id,@cankao,@enxmmc,@jl,@pic,@result,@value,@xmmc,@jgid,@tjid)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9),
					new SqlParameter("@cankao", SqlDbType.Text),
					new SqlParameter("@enxmmc", SqlDbType.VarChar,240),
					new SqlParameter("@jl", SqlDbType.Text),
					new SqlParameter("@pic", SqlDbType.Text),
					new SqlParameter("@result", SqlDbType.VarChar,20),
					new SqlParameter("@value", SqlDbType.Text),
					new SqlParameter("@xmmc", SqlDbType.VarChar,200),
					new SqlParameter("@jgid", SqlDbType.Decimal,9),
					new SqlParameter("@tjid", SqlDbType.Decimal,9)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.cankao;
			parameters[2].Value = model.enxmmc;
			parameters[3].Value = model.jl;
			parameters[4].Value = model.pic;
			parameters[5].Value = model.result;
			parameters[6].Value = model.value;
			parameters[7].Value = model.xmmc;
			parameters[8].Value = model.jgid;
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
		public bool Update(LW_AskOnline.Model.sj_tjjg1 model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sj_tjjg1 set ");
			strSql.Append("cankao=@cankao,");
			strSql.Append("enxmmc=@enxmmc,");
			strSql.Append("jl=@jl,");
			strSql.Append("pic=@pic,");
			strSql.Append("result=@result,");
			strSql.Append("value=@value,");
			strSql.Append("xmmc=@xmmc,");
			strSql.Append("jgid=@jgid,");
			strSql.Append("tjid=@tjid");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@cankao", SqlDbType.Text),
					new SqlParameter("@enxmmc", SqlDbType.VarChar,240),
					new SqlParameter("@jl", SqlDbType.Text),
					new SqlParameter("@pic", SqlDbType.Text),
					new SqlParameter("@result", SqlDbType.VarChar,20),
					new SqlParameter("@value", SqlDbType.Text),
					new SqlParameter("@xmmc", SqlDbType.VarChar,200),
					new SqlParameter("@jgid", SqlDbType.Decimal,9),
					new SqlParameter("@tjid", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.cankao;
			parameters[1].Value = model.enxmmc;
			parameters[2].Value = model.jl;
			parameters[3].Value = model.pic;
			parameters[4].Value = model.result;
			parameters[5].Value = model.value;
			parameters[6].Value = model.xmmc;
			parameters[7].Value = model.jgid;
			parameters[8].Value = model.tjid;
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
		public bool Delete(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sj_tjjg1 ");
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
			strSql.Append("delete from sj_tjjg1 ");
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
		public LW_AskOnline.Model.sj_tjjg1 GetModel(decimal id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,cankao,enxmmc,jl,pic,result,value,xmmc,jgid,tjid from sj_tjjg1 ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Decimal,9)			};
			parameters[0].Value = id;

			LW_AskOnline.Model.sj_tjjg1 model=new LW_AskOnline.Model.sj_tjjg1();
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
		public LW_AskOnline.Model.sj_tjjg1 DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sj_tjjg1 model=new LW_AskOnline.Model.sj_tjjg1();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=decimal.Parse(row["id"].ToString());
				}
				if(row["cankao"]!=null)
				{
					model.cankao=row["cankao"].ToString();
				}
				if(row["enxmmc"]!=null)
				{
					model.enxmmc=row["enxmmc"].ToString();
				}
				if(row["jl"]!=null)
				{
					model.jl=row["jl"].ToString();
				}
				if(row["pic"]!=null)
				{
					model.pic=row["pic"].ToString();
				}
				if(row["result"]!=null)
				{
					model.result=row["result"].ToString();
				}
				if(row["value"]!=null)
				{
					model.value=row["value"].ToString();
				}
				if(row["xmmc"]!=null)
				{
					model.xmmc=row["xmmc"].ToString();
				}
				if(row["jgid"]!=null && row["jgid"].ToString()!="")
				{
					model.jgid=decimal.Parse(row["jgid"].ToString());
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
			strSql.Append("select id,cankao,enxmmc,jl,pic,result,value,xmmc,jgid,tjid ");
			strSql.Append(" FROM sj_tjjg1 ");
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
			strSql.Append(" id,cankao,enxmmc,jl,pic,result,value,xmmc,jgid,tjid ");
			strSql.Append(" FROM sj_tjjg1 ");
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
			strSql.Append("select count(1) FROM sj_tjjg1 ");
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
			strSql.Append(")AS Row, T.*  from sj_tjjg1 T ");
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
			parameters[0].Value = "sj_tjjg1";
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

