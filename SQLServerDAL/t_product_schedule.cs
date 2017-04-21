using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_product_schedule
	/// </summary>
	public partial class t_product_schedule:It_product_schedule
	{
		public t_product_schedule()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal schedule_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_product_schedule");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_product_schedule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_product_schedule(");
			strSql.Append("eval_count,sell_count,stock,goods_id,bad_eval,comment_eval,high_eval,turn_num)");
			strSql.Append(" values (");
			strSql.Append("@eval_count,@sell_count,@stock,@goods_id,@bad_eval,@comment_eval,@high_eval,@turn_num)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@eval_count", SqlDbType.Int,4),
					new SqlParameter("@sell_count", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@bad_eval", SqlDbType.Int,4),
					new SqlParameter("@comment_eval", SqlDbType.Int,4),
					new SqlParameter("@high_eval", SqlDbType.Int,4),
					new SqlParameter("@turn_num", SqlDbType.Int,4)};
			parameters[0].Value = model.eval_count;
			parameters[1].Value = model.sell_count;
			parameters[2].Value = model.stock;
			parameters[3].Value = model.goods_id;
			parameters[4].Value = model.bad_eval;
			parameters[5].Value = model.comment_eval;
			parameters[6].Value = model.high_eval;
			parameters[7].Value = model.turn_num;

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
		public bool Update(LW_AskOnline.Model.t_product_schedule model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_product_schedule set ");
			strSql.Append("eval_count=@eval_count,");
			strSql.Append("sell_count=@sell_count,");
			strSql.Append("stock=@stock,");
			strSql.Append("goods_id=@goods_id,");
			strSql.Append("bad_eval=@bad_eval,");
			strSql.Append("comment_eval=@comment_eval,");
			strSql.Append("high_eval=@high_eval,");
			strSql.Append("turn_num=@turn_num");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@eval_count", SqlDbType.Int,4),
					new SqlParameter("@sell_count", SqlDbType.Int,4),
					new SqlParameter("@stock", SqlDbType.Int,4),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@bad_eval", SqlDbType.Int,4),
					new SqlParameter("@comment_eval", SqlDbType.Int,4),
					new SqlParameter("@high_eval", SqlDbType.Int,4),
					new SqlParameter("@turn_num", SqlDbType.Int,4),
					new SqlParameter("@schedule_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.eval_count;
			parameters[1].Value = model.sell_count;
			parameters[2].Value = model.stock;
			parameters[3].Value = model.goods_id;
			parameters[4].Value = model.bad_eval;
			parameters[5].Value = model.comment_eval;
			parameters[6].Value = model.high_eval;
			parameters[7].Value = model.turn_num;
			parameters[8].Value = model.schedule_id;

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
		public bool Delete(decimal schedule_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_product_schedule ");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

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
		public bool DeleteList(string schedule_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_product_schedule ");
			strSql.Append(" where schedule_id in ("+schedule_idlist + ")  ");
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
		public LW_AskOnline.Model.t_product_schedule GetModel(decimal schedule_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 schedule_id,eval_count,sell_count,stock,goods_id,bad_eval,comment_eval,high_eval,turn_num from t_product_schedule ");
			strSql.Append(" where schedule_id=@schedule_id");
			SqlParameter[] parameters = {
					new SqlParameter("@schedule_id", SqlDbType.Decimal)
			};
			parameters[0].Value = schedule_id;

			LW_AskOnline.Model.t_product_schedule model=new LW_AskOnline.Model.t_product_schedule();
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
		public LW_AskOnline.Model.t_product_schedule DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_product_schedule model=new LW_AskOnline.Model.t_product_schedule();
			if (row != null)
			{
				if(row["schedule_id"]!=null && row["schedule_id"].ToString()!="")
				{
					model.schedule_id=decimal.Parse(row["schedule_id"].ToString());
				}
				if(row["eval_count"]!=null && row["eval_count"].ToString()!="")
				{
					model.eval_count=int.Parse(row["eval_count"].ToString());
				}
				if(row["sell_count"]!=null && row["sell_count"].ToString()!="")
				{
					model.sell_count=int.Parse(row["sell_count"].ToString());
				}
				if(row["stock"]!=null && row["stock"].ToString()!="")
				{
					model.stock=int.Parse(row["stock"].ToString());
				}
				if(row["goods_id"]!=null && row["goods_id"].ToString()!="")
				{
					model.goods_id=decimal.Parse(row["goods_id"].ToString());
				}
				if(row["bad_eval"]!=null && row["bad_eval"].ToString()!="")
				{
					model.bad_eval=int.Parse(row["bad_eval"].ToString());
				}
				if(row["comment_eval"]!=null && row["comment_eval"].ToString()!="")
				{
					model.comment_eval=int.Parse(row["comment_eval"].ToString());
				}
				if(row["high_eval"]!=null && row["high_eval"].ToString()!="")
				{
					model.high_eval=int.Parse(row["high_eval"].ToString());
				}
				if(row["turn_num"]!=null && row["turn_num"].ToString()!="")
				{
					model.turn_num=int.Parse(row["turn_num"].ToString());
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
			strSql.Append("select schedule_id,eval_count,sell_count,stock,goods_id,bad_eval,comment_eval,high_eval,turn_num ");
			strSql.Append(" FROM t_product_schedule ");
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
			strSql.Append(" schedule_id,eval_count,sell_count,stock,goods_id,bad_eval,comment_eval,high_eval,turn_num ");
			strSql.Append(" FROM t_product_schedule ");
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
			strSql.Append("select count(1) FROM t_product_schedule ");
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
				strSql.Append("order by T.schedule_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_product_schedule T ");
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
			parameters[0].Value = "t_product_schedule";
			parameters[1].Value = "schedule_id";
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

