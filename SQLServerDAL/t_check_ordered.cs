using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_check_ordered
	/// </summary>
	public partial class t_check_ordered:It_check_ordered
	{
		public t_check_ordered()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_check_ordered");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.t_check_ordered model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_check_ordered(");
			strSql.Append("member_id,package_id,amount,actual_amount,ordered_date,org_id,period,status,name,item_ids,createtime,baseprice,optionalprice,contractid,orderNo,jxbids,reportstatus)");
			strSql.Append(" values (");
			strSql.Append("@member_id,@package_id,@amount,@actual_amount,@ordered_date,@org_id,@period,@status,@name,@item_ids,@createtime,@baseprice,@optionalprice,@contractid,@orderNo,@jxbids,@reportstatus)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@member_id", SqlDbType.BigInt,8),
					new SqlParameter("@package_id", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@actual_amount", SqlDbType.Float,8),
					new SqlParameter("@ordered_date", SqlDbType.DateTime),
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@period", SqlDbType.VarChar,10),
					new SqlParameter("@status", SqlDbType.VarChar,10),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@item_ids", SqlDbType.Text),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@baseprice", SqlDbType.Float,8),
					new SqlParameter("@optionalprice", SqlDbType.Float,8),
					new SqlParameter("@contractid", SqlDbType.Decimal,9),
					new SqlParameter("@orderNo", SqlDbType.VarChar,32),
					new SqlParameter("@jxbids", SqlDbType.VarChar,255),
					new SqlParameter("@reportstatus", SqlDbType.VarChar,255)};
			parameters[0].Value = model.member_id;
			parameters[1].Value = model.package_id;
			parameters[2].Value = model.amount;
			parameters[3].Value = model.actual_amount;
			parameters[4].Value = model.ordered_date;
			parameters[5].Value = model.org_id;
			parameters[6].Value = model.period;
			parameters[7].Value = model.status;
			parameters[8].Value = model.name;
			parameters[9].Value = model.item_ids;
			parameters[10].Value = model.createtime;
			parameters[11].Value = model.baseprice;
			parameters[12].Value = model.optionalprice;
			parameters[13].Value = model.contractid;
			parameters[14].Value = model.orderNo;
			parameters[15].Value = model.jxbids;
			parameters[16].Value = model.reportstatus;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.t_check_ordered model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_check_ordered set ");
			strSql.Append("member_id=@member_id,");
			strSql.Append("package_id=@package_id,");
			strSql.Append("amount=@amount,");
			strSql.Append("actual_amount=@actual_amount,");
			strSql.Append("ordered_date=@ordered_date,");
			strSql.Append("org_id=@org_id,");
			strSql.Append("period=@period,");
			strSql.Append("status=@status,");
			strSql.Append("name=@name,");
			strSql.Append("item_ids=@item_ids,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("baseprice=@baseprice,");
			strSql.Append("optionalprice=@optionalprice,");
			strSql.Append("contractid=@contractid,");
			strSql.Append("orderNo=@orderNo,");
			strSql.Append("jxbids=@jxbids,");
			strSql.Append("reportstatus=@reportstatus");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@member_id", SqlDbType.BigInt,8),
					new SqlParameter("@package_id", SqlDbType.Int,4),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@actual_amount", SqlDbType.Float,8),
					new SqlParameter("@ordered_date", SqlDbType.DateTime),
					new SqlParameter("@org_id", SqlDbType.Int,4),
					new SqlParameter("@period", SqlDbType.VarChar,10),
					new SqlParameter("@status", SqlDbType.VarChar,10),
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@item_ids", SqlDbType.Text),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@baseprice", SqlDbType.Float,8),
					new SqlParameter("@optionalprice", SqlDbType.Float,8),
					new SqlParameter("@contractid", SqlDbType.Decimal,9),
					new SqlParameter("@orderNo", SqlDbType.VarChar,32),
					new SqlParameter("@jxbids", SqlDbType.VarChar,255),
					new SqlParameter("@reportstatus", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.member_id;
			parameters[1].Value = model.package_id;
			parameters[2].Value = model.amount;
			parameters[3].Value = model.actual_amount;
			parameters[4].Value = model.ordered_date;
			parameters[5].Value = model.org_id;
			parameters[6].Value = model.period;
			parameters[7].Value = model.status;
			parameters[8].Value = model.name;
			parameters[9].Value = model.item_ids;
			parameters[10].Value = model.createtime;
			parameters[11].Value = model.baseprice;
			parameters[12].Value = model.optionalprice;
			parameters[13].Value = model.contractid;
			parameters[14].Value = model.orderNo;
			parameters[15].Value = model.jxbids;
			parameters[16].Value = model.reportstatus;
			parameters[17].Value = model.id;

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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_check_ordered ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
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
			strSql.Append("delete from t_check_ordered ");
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
		public LW_AskOnline.Model.t_check_ordered GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,member_id,package_id,amount,actual_amount,ordered_date,org_id,period,status,name,item_ids,createtime,baseprice,optionalprice,contractid,orderNo,jxbids,reportstatus from t_check_ordered ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_check_ordered model=new LW_AskOnline.Model.t_check_ordered();
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
		public LW_AskOnline.Model.t_check_ordered DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_check_ordered model=new LW_AskOnline.Model.t_check_ordered();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=long.Parse(row["member_id"].ToString());
				}
				if(row["package_id"]!=null && row["package_id"].ToString()!="")
				{
					model.package_id=int.Parse(row["package_id"].ToString());
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["actual_amount"]!=null && row["actual_amount"].ToString()!="")
				{
					model.actual_amount=decimal.Parse(row["actual_amount"].ToString());
				}
				if(row["ordered_date"]!=null && row["ordered_date"].ToString()!="")
				{
					model.ordered_date=DateTime.Parse(row["ordered_date"].ToString());
				}
				if(row["org_id"]!=null && row["org_id"].ToString()!="")
				{
					model.org_id=int.Parse(row["org_id"].ToString());
				}
				if(row["period"]!=null)
				{
					model.period=row["period"].ToString();
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["item_ids"]!=null)
				{
					model.item_ids=row["item_ids"].ToString();
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
				}
				if(row["baseprice"]!=null && row["baseprice"].ToString()!="")
				{
					model.baseprice=decimal.Parse(row["baseprice"].ToString());
				}
				if(row["optionalprice"]!=null && row["optionalprice"].ToString()!="")
				{
					model.optionalprice=decimal.Parse(row["optionalprice"].ToString());
				}
				if(row["contractid"]!=null && row["contractid"].ToString()!="")
				{
					model.contractid=decimal.Parse(row["contractid"].ToString());
				}
				if(row["orderNo"]!=null)
				{
					model.orderNo=row["orderNo"].ToString();
				}
				if(row["jxbids"]!=null)
				{
					model.jxbids=row["jxbids"].ToString();
				}
				if(row["reportstatus"]!=null)
				{
					model.reportstatus=row["reportstatus"].ToString();
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
			strSql.Append("select id,member_id,package_id,amount,actual_amount,ordered_date,org_id,period,status,name,item_ids,createtime,baseprice,optionalprice,contractid,orderNo,jxbids,reportstatus ");
			strSql.Append(" FROM t_check_ordered ");
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
			strSql.Append(" id,member_id,package_id,amount,actual_amount,ordered_date,org_id,period,status,name,item_ids,createtime,baseprice,optionalprice,contractid,orderNo,jxbids,reportstatus ");
			strSql.Append(" FROM t_check_ordered ");
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
			strSql.Append("select count(1) FROM t_check_ordered ");
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
			strSql.Append(")AS Row, T.*  from t_check_ordered T ");
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
			parameters[0].Value = "t_check_ordered";
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

