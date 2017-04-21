using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_pay_transaction_record
	/// </summary>
	public partial class t_pay_transaction_record:It_pay_transaction_record
	{
		public t_pay_transaction_record()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(LW_AskOnline.Model.t_pay_transaction_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_pay_transaction_record(");
			strSql.Append("out_trade_no,transaction_id,memberId,transaction_price,status,create_date,update_date,member_id,openid)");
			strSql.Append(" values (");
			strSql.Append("@out_trade_no,@transaction_id,@memberId,@transaction_price,@status,@create_date,@update_date,@member_id,@openid)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@out_trade_no", SqlDbType.VarChar,32),
					new SqlParameter("@transaction_id", SqlDbType.VarChar,50),
					new SqlParameter("@memberId", SqlDbType.BigInt,8),
					new SqlParameter("@transaction_price", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.Char,10),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@update_date", SqlDbType.DateTime),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@openid", SqlDbType.VarChar,255)};
			parameters[0].Value = model.out_trade_no;
			parameters[1].Value = model.transaction_id;
			parameters[2].Value = model.memberId;
			parameters[3].Value = model.transaction_price;
			parameters[4].Value = model.status;
			parameters[5].Value = model.create_date;
			parameters[6].Value = model.update_date;
			parameters[7].Value = model.member_id;
			parameters[8].Value = model.openid;

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
		public bool Update(LW_AskOnline.Model.t_pay_transaction_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_pay_transaction_record set ");
			strSql.Append("out_trade_no=@out_trade_no,");
			strSql.Append("transaction_id=@transaction_id,");
			strSql.Append("memberId=@memberId,");
			strSql.Append("transaction_price=@transaction_price,");
			strSql.Append("status=@status,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("update_date=@update_date,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("openid=@openid");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@out_trade_no", SqlDbType.VarChar,32),
					new SqlParameter("@transaction_id", SqlDbType.VarChar,50),
					new SqlParameter("@memberId", SqlDbType.BigInt,8),
					new SqlParameter("@transaction_price", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.Char,10),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@update_date", SqlDbType.DateTime),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@openid", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = model.out_trade_no;
			parameters[1].Value = model.transaction_id;
			parameters[2].Value = model.memberId;
			parameters[3].Value = model.transaction_price;
			parameters[4].Value = model.status;
			parameters[5].Value = model.create_date;
			parameters[6].Value = model.update_date;
			parameters[7].Value = model.member_id;
			parameters[8].Value = model.openid;
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
		public bool Delete(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_pay_transaction_record ");
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
			strSql.Append("delete from t_pay_transaction_record ");
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
		public LW_AskOnline.Model.t_pay_transaction_record GetModel(long id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,out_trade_no,transaction_id,memberId,transaction_price,status,create_date,update_date,member_id,openid from t_pay_transaction_record ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_pay_transaction_record model=new LW_AskOnline.Model.t_pay_transaction_record();
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
		public LW_AskOnline.Model.t_pay_transaction_record DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_pay_transaction_record model=new LW_AskOnline.Model.t_pay_transaction_record();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=long.Parse(row["id"].ToString());
				}
				if(row["out_trade_no"]!=null)
				{
					model.out_trade_no=row["out_trade_no"].ToString();
				}
				if(row["transaction_id"]!=null)
				{
					model.transaction_id=row["transaction_id"].ToString();
				}
				if(row["memberId"]!=null && row["memberId"].ToString()!="")
				{
					model.memberId=long.Parse(row["memberId"].ToString());
				}
				if(row["transaction_price"]!=null && row["transaction_price"].ToString()!="")
				{
					model.transaction_price=decimal.Parse(row["transaction_price"].ToString());
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["update_date"]!=null && row["update_date"].ToString()!="")
				{
					model.update_date=DateTime.Parse(row["update_date"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["openid"]!=null)
				{
					model.openid=row["openid"].ToString();
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
			strSql.Append("select id,out_trade_no,transaction_id,memberId,transaction_price,status,create_date,update_date,member_id,openid ");
			strSql.Append(" FROM t_pay_transaction_record ");
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
			strSql.Append(" id,out_trade_no,transaction_id,memberId,transaction_price,status,create_date,update_date,member_id,openid ");
			strSql.Append(" FROM t_pay_transaction_record ");
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
			strSql.Append("select count(1) FROM t_pay_transaction_record ");
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
			strSql.Append(")AS Row, T.*  from t_pay_transaction_record T ");
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
			parameters[0].Value = "t_pay_transaction_record";
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

