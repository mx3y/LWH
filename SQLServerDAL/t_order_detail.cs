using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_order_detail
	/// </summary>
	public partial class t_order_detail:It_order_detail
	{
		public t_order_detail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal detail_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_order_detail");
			strSql.Append(" where detail_id=@detail_id");
			SqlParameter[] parameters = {
					new SqlParameter("@detail_id", SqlDbType.Decimal)
			};
			parameters[0].Value = detail_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_order_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_order_detail(");
			strSql.Append("number,price,total_amount,order_id,goods_id,is_valuation,is_repair,repair_num)");
			strSql.Append(" values (");
			strSql.Append("@number,@price,@total_amount,@order_id,@goods_id,@is_valuation,@is_repair,@repair_num)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@total_amount", SqlDbType.Float,8),
					new SqlParameter("@order_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@is_valuation", SqlDbType.Int,4),
					new SqlParameter("@is_repair", SqlDbType.Int,4),
					new SqlParameter("@repair_num", SqlDbType.Int,4)};
			parameters[0].Value = model.number;
			parameters[1].Value = model.price;
			parameters[2].Value = model.total_amount;
			parameters[3].Value = model.order_id;
			parameters[4].Value = model.goods_id;
			parameters[5].Value = model.is_valuation;
			parameters[6].Value = model.is_repair;
			parameters[7].Value = model.repair_num;

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
		public bool Update(LW_AskOnline.Model.t_order_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_order_detail set ");
			strSql.Append("number=@number,");
			strSql.Append("price=@price,");
			strSql.Append("total_amount=@total_amount,");
			strSql.Append("order_id=@order_id,");
			strSql.Append("goods_id=@goods_id,");
			strSql.Append("is_valuation=@is_valuation,");
			strSql.Append("is_repair=@is_repair,");
			strSql.Append("repair_num=@repair_num");
			strSql.Append(" where detail_id=@detail_id");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Float,8),
					new SqlParameter("@total_amount", SqlDbType.Float,8),
					new SqlParameter("@order_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@is_valuation", SqlDbType.Int,4),
					new SqlParameter("@is_repair", SqlDbType.Int,4),
					new SqlParameter("@repair_num", SqlDbType.Int,4),
					new SqlParameter("@detail_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.number;
			parameters[1].Value = model.price;
			parameters[2].Value = model.total_amount;
			parameters[3].Value = model.order_id;
			parameters[4].Value = model.goods_id;
			parameters[5].Value = model.is_valuation;
			parameters[6].Value = model.is_repair;
			parameters[7].Value = model.repair_num;
			parameters[8].Value = model.detail_id;

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
		public bool Delete(decimal detail_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_order_detail ");
			strSql.Append(" where detail_id=@detail_id");
			SqlParameter[] parameters = {
					new SqlParameter("@detail_id", SqlDbType.Decimal)
			};
			parameters[0].Value = detail_id;

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
		public bool DeleteList(string detail_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_order_detail ");
			strSql.Append(" where detail_id in ("+detail_idlist + ")  ");
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
		public LW_AskOnline.Model.t_order_detail GetModel(decimal detail_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 detail_id,number,price,total_amount,order_id,goods_id,is_valuation,is_repair,repair_num from t_order_detail ");
			strSql.Append(" where detail_id=@detail_id");
			SqlParameter[] parameters = {
					new SqlParameter("@detail_id", SqlDbType.Decimal)
			};
			parameters[0].Value = detail_id;

			LW_AskOnline.Model.t_order_detail model=new LW_AskOnline.Model.t_order_detail();
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
		public LW_AskOnline.Model.t_order_detail DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_order_detail model=new LW_AskOnline.Model.t_order_detail();
			if (row != null)
			{
				if(row["detail_id"]!=null && row["detail_id"].ToString()!="")
				{
					model.detail_id=decimal.Parse(row["detail_id"].ToString());
				}
				if(row["number"]!=null && row["number"].ToString()!="")
				{
					model.number=int.Parse(row["number"].ToString());
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["total_amount"]!=null && row["total_amount"].ToString()!="")
				{
					model.total_amount=decimal.Parse(row["total_amount"].ToString());
				}
				if(row["order_id"]!=null && row["order_id"].ToString()!="")
				{
					model.order_id=decimal.Parse(row["order_id"].ToString());
				}
				if(row["goods_id"]!=null && row["goods_id"].ToString()!="")
				{
					model.goods_id=decimal.Parse(row["goods_id"].ToString());
				}
				if(row["is_valuation"]!=null && row["is_valuation"].ToString()!="")
				{
					model.is_valuation=int.Parse(row["is_valuation"].ToString());
				}
				if(row["is_repair"]!=null && row["is_repair"].ToString()!="")
				{
					model.is_repair=int.Parse(row["is_repair"].ToString());
				}
				if(row["repair_num"]!=null && row["repair_num"].ToString()!="")
				{
					model.repair_num=int.Parse(row["repair_num"].ToString());
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
			strSql.Append("select detail_id,number,price,total_amount,order_id,goods_id,is_valuation,is_repair,repair_num ");
			strSql.Append(" FROM t_order_detail ");
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
			strSql.Append(" detail_id,number,price,total_amount,order_id,goods_id,is_valuation,is_repair,repair_num ");
			strSql.Append(" FROM t_order_detail ");
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
			strSql.Append("select count(1) FROM t_order_detail ");
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
				strSql.Append("order by T.detail_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_order_detail T ");
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
			parameters[0].Value = "t_order_detail";
			parameters[1].Value = "detail_id";
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

