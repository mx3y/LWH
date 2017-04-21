using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_repair_record
	/// </summary>
	public partial class t_repair_record:It_repair_record
	{
		public t_repair_record()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal repair_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_repair_record");
			strSql.Append(" where repair_id=@repair_id");
			SqlParameter[] parameters = {
					new SqlParameter("@repair_id", SqlDbType.Decimal)
			};
			parameters[0].Value = repair_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_repair_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_repair_record(");
			strSql.Append("audit_remark,audit_status,remark,type,member_id,goods_id,repair_time,amount,order_detail_id,member_type)");
			strSql.Append(" values (");
			strSql.Append("@audit_remark,@audit_status,@remark,@type,@member_id,@goods_id,@repair_time,@amount,@order_detail_id,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@audit_remark", SqlDbType.VarChar,2000),
					new SqlParameter("@audit_status", SqlDbType.VarChar,2),
					new SqlParameter("@remark", SqlDbType.VarChar,2000),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@repair_time", SqlDbType.DateTime),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@order_detail_id", SqlDbType.Decimal,9),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.audit_remark;
			parameters[1].Value = model.audit_status;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.type;
			parameters[4].Value = model.member_id;
			parameters[5].Value = model.goods_id;
			parameters[6].Value = model.repair_time;
			parameters[7].Value = model.amount;
			parameters[8].Value = model.order_detail_id;
			parameters[9].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_repair_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_repair_record set ");
			strSql.Append("audit_remark=@audit_remark,");
			strSql.Append("audit_status=@audit_status,");
			strSql.Append("remark=@remark,");
			strSql.Append("type=@type,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("goods_id=@goods_id,");
			strSql.Append("repair_time=@repair_time,");
			strSql.Append("amount=@amount,");
			strSql.Append("order_detail_id=@order_detail_id,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where repair_id=@repair_id");
			SqlParameter[] parameters = {
					new SqlParameter("@audit_remark", SqlDbType.VarChar,2000),
					new SqlParameter("@audit_status", SqlDbType.VarChar,2),
					new SqlParameter("@remark", SqlDbType.VarChar,2000),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@repair_time", SqlDbType.DateTime),
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@order_detail_id", SqlDbType.Decimal,9),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@repair_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.audit_remark;
			parameters[1].Value = model.audit_status;
			parameters[2].Value = model.remark;
			parameters[3].Value = model.type;
			parameters[4].Value = model.member_id;
			parameters[5].Value = model.goods_id;
			parameters[6].Value = model.repair_time;
			parameters[7].Value = model.amount;
			parameters[8].Value = model.order_detail_id;
			parameters[9].Value = model.member_type;
			parameters[10].Value = model.repair_id;

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
		public bool Delete(decimal repair_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_repair_record ");
			strSql.Append(" where repair_id=@repair_id");
			SqlParameter[] parameters = {
					new SqlParameter("@repair_id", SqlDbType.Decimal)
			};
			parameters[0].Value = repair_id;

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
		public bool DeleteList(string repair_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_repair_record ");
			strSql.Append(" where repair_id in ("+repair_idlist + ")  ");
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
		public LW_AskOnline.Model.t_repair_record GetModel(decimal repair_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 repair_id,audit_remark,audit_status,remark,type,member_id,goods_id,repair_time,amount,order_detail_id,member_type from t_repair_record ");
			strSql.Append(" where repair_id=@repair_id");
			SqlParameter[] parameters = {
					new SqlParameter("@repair_id", SqlDbType.Decimal)
			};
			parameters[0].Value = repair_id;

			LW_AskOnline.Model.t_repair_record model=new LW_AskOnline.Model.t_repair_record();
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
		public LW_AskOnline.Model.t_repair_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_repair_record model=new LW_AskOnline.Model.t_repair_record();
			if (row != null)
			{
				if(row["repair_id"]!=null && row["repair_id"].ToString()!="")
				{
					model.repair_id=decimal.Parse(row["repair_id"].ToString());
				}
				if(row["audit_remark"]!=null)
				{
					model.audit_remark=row["audit_remark"].ToString();
				}
				if(row["audit_status"]!=null)
				{
					model.audit_status=row["audit_status"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["type"]!=null && row["type"].ToString()!="")
				{
					model.type=int.Parse(row["type"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["goods_id"]!=null && row["goods_id"].ToString()!="")
				{
					model.goods_id=decimal.Parse(row["goods_id"].ToString());
				}
				if(row["repair_time"]!=null && row["repair_time"].ToString()!="")
				{
					model.repair_time=DateTime.Parse(row["repair_time"].ToString());
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["order_detail_id"]!=null && row["order_detail_id"].ToString()!="")
				{
					model.order_detail_id=decimal.Parse(row["order_detail_id"].ToString());
				}
				if(row["member_type"]!=null)
				{
					model.member_type=row["member_type"].ToString();
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
			strSql.Append("select repair_id,audit_remark,audit_status,remark,type,member_id,goods_id,repair_time,amount,order_detail_id,member_type ");
			strSql.Append(" FROM t_repair_record ");
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
			strSql.Append(" repair_id,audit_remark,audit_status,remark,type,member_id,goods_id,repair_time,amount,order_detail_id,member_type ");
			strSql.Append(" FROM t_repair_record ");
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
			strSql.Append("select count(1) FROM t_repair_record ");
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
				strSql.Append("order by T.repair_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_repair_record T ");
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
			parameters[0].Value = "t_repair_record";
			parameters[1].Value = "repair_id";
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

