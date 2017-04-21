using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_msg_check
	/// </summary>
	public partial class ask_msg_check:Iask_msg_check
	{
		public ask_msg_check()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("mid", "ask_msg_check"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_msg_check");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_msg_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_msg_check(");
			strSql.Append("mmobile,mcheckcode,mip,mcreatedate,mexpirat,misuse,musingat,mtype)");
			strSql.Append(" values (");
			strSql.Append("@mmobile,@mcheckcode,@mip,@mcreatedate,@mexpirat,@misuse,@musingat,@mtype)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@mmobile", SqlDbType.Int,4),
					new SqlParameter("@mcheckcode", SqlDbType.Int,4),
					new SqlParameter("@mip", SqlDbType.NVarChar,50),
					new SqlParameter("@mcreatedate", SqlDbType.DateTime),
					new SqlParameter("@mexpirat", SqlDbType.Int,4),
					new SqlParameter("@misuse", SqlDbType.TinyInt,1),
					new SqlParameter("@musingat", SqlDbType.DateTime),
					new SqlParameter("@mtype", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.mmobile;
			parameters[1].Value = model.mcheckcode;
			parameters[2].Value = model.mip;
			parameters[3].Value = model.mcreatedate;
			parameters[4].Value = model.mexpirat;
			parameters[5].Value = model.misuse;
			parameters[6].Value = model.musingat;
			parameters[7].Value = model.mtype;

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
		public bool Update(LW_AskOnline.Model.ask_msg_check model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_msg_check set ");
			strSql.Append("mmobile=@mmobile,");
			strSql.Append("mcheckcode=@mcheckcode,");
			strSql.Append("mip=@mip,");
			strSql.Append("mcreatedate=@mcreatedate,");
			strSql.Append("mexpirat=@mexpirat,");
			strSql.Append("misuse=@misuse,");
			strSql.Append("musingat=@musingat,");
			strSql.Append("mtype=@mtype");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mmobile", SqlDbType.Int,4),
					new SqlParameter("@mcheckcode", SqlDbType.Int,4),
					new SqlParameter("@mip", SqlDbType.NVarChar,50),
					new SqlParameter("@mcreatedate", SqlDbType.DateTime),
					new SqlParameter("@mexpirat", SqlDbType.Int,4),
					new SqlParameter("@misuse", SqlDbType.TinyInt,1),
					new SqlParameter("@musingat", SqlDbType.DateTime),
					new SqlParameter("@mtype", SqlDbType.NVarChar,200),
					new SqlParameter("@mid", SqlDbType.Int,4)};
			parameters[0].Value = model.mmobile;
			parameters[1].Value = model.mcheckcode;
			parameters[2].Value = model.mip;
			parameters[3].Value = model.mcreatedate;
			parameters[4].Value = model.mexpirat;
			parameters[5].Value = model.misuse;
			parameters[6].Value = model.musingat;
			parameters[7].Value = model.mtype;
			parameters[8].Value = model.mid;

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
		public bool Delete(int mid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_msg_check ");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

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
		public bool DeleteList(string midlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_msg_check ");
			strSql.Append(" where mid in ("+midlist + ")  ");
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
		public LW_AskOnline.Model.ask_msg_check GetModel(int mid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 mid,mmobile,mcheckcode,mip,mcreatedate,mexpirat,misuse,musingat,mtype from ask_msg_check ");
			strSql.Append(" where mid=@mid");
			SqlParameter[] parameters = {
					new SqlParameter("@mid", SqlDbType.Int,4)
			};
			parameters[0].Value = mid;

			LW_AskOnline.Model.ask_msg_check model=new LW_AskOnline.Model.ask_msg_check();
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
		public LW_AskOnline.Model.ask_msg_check DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_msg_check model=new LW_AskOnline.Model.ask_msg_check();
			if (row != null)
			{
				if(row["mid"]!=null && row["mid"].ToString()!="")
				{
					model.mid=int.Parse(row["mid"].ToString());
				}
				if(row["mmobile"]!=null && row["mmobile"].ToString()!="")
				{
					model.mmobile=int.Parse(row["mmobile"].ToString());
				}
				if(row["mcheckcode"]!=null && row["mcheckcode"].ToString()!="")
				{
					model.mcheckcode=int.Parse(row["mcheckcode"].ToString());
				}
				if(row["mip"]!=null)
				{
					model.mip=row["mip"].ToString();
				}
				if(row["mcreatedate"]!=null && row["mcreatedate"].ToString()!="")
				{
					model.mcreatedate=DateTime.Parse(row["mcreatedate"].ToString());
				}
				if(row["mexpirat"]!=null && row["mexpirat"].ToString()!="")
				{
					model.mexpirat=int.Parse(row["mexpirat"].ToString());
				}
				if(row["misuse"]!=null && row["misuse"].ToString()!="")
				{
					model.misuse=int.Parse(row["misuse"].ToString());
				}
				if(row["musingat"]!=null && row["musingat"].ToString()!="")
				{
					model.musingat=DateTime.Parse(row["musingat"].ToString());
				}
				if(row["mtype"]!=null)
				{
					model.mtype=row["mtype"].ToString();
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
			strSql.Append("select mid,mmobile,mcheckcode,mip,mcreatedate,mexpirat,misuse,musingat,mtype ");
			strSql.Append(" FROM ask_msg_check ");
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
			strSql.Append(" mid,mmobile,mcheckcode,mip,mcreatedate,mexpirat,misuse,musingat,mtype ");
			strSql.Append(" FROM ask_msg_check ");
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
			strSql.Append("select count(1) FROM ask_msg_check ");
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
				strSql.Append("order by T.mid desc");
			}
			strSql.Append(")AS Row, T.*  from ask_msg_check T ");
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
			parameters[0].Value = "ask_msg_check";
			parameters[1].Value = "mid";
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

