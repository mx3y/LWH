using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_member_account
	/// </summary>
	public partial class t_member_account:It_member_account
	{
		public t_member_account()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal account_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_member_account");
			strSql.Append(" where account_id=@account_id");
			SqlParameter[] parameters = {
					new SqlParameter("@account_id", SqlDbType.Decimal)
			};
			parameters[0].Value = account_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_member_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member_account(");
			strSql.Append("amount,status,member_id,card_amount,member_type)");
			strSql.Append(" values (");
			strSql.Append("@amount,@status,@member_id,@card_amount,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@card_amount", SqlDbType.Float,8),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.amount;
			parameters[1].Value = model.status;
			parameters[2].Value = model.member_id;
			parameters[3].Value = model.card_amount;
			parameters[4].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_member_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member_account set ");
			strSql.Append("amount=@amount,");
			strSql.Append("status=@status,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("card_amount=@card_amount,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where account_id=@account_id");
			SqlParameter[] parameters = {
					new SqlParameter("@amount", SqlDbType.Float,8),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@card_amount", SqlDbType.Float,8),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@account_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.amount;
			parameters[1].Value = model.status;
			parameters[2].Value = model.member_id;
			parameters[3].Value = model.card_amount;
			parameters[4].Value = model.member_type;
			parameters[5].Value = model.account_id;

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
		public bool Delete(decimal account_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_account ");
			strSql.Append(" where account_id=@account_id");
			SqlParameter[] parameters = {
					new SqlParameter("@account_id", SqlDbType.Decimal)
			};
			parameters[0].Value = account_id;

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
		public bool DeleteList(string account_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_account ");
			strSql.Append(" where account_id in ("+account_idlist + ")  ");
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
		public LW_AskOnline.Model.t_member_account GetModel(decimal account_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 account_id,amount,status,member_id,card_amount,member_type from t_member_account ");
			strSql.Append(" where account_id=@account_id");
			SqlParameter[] parameters = {
					new SqlParameter("@account_id", SqlDbType.Decimal)
			};
			parameters[0].Value = account_id;

			LW_AskOnline.Model.t_member_account model=new LW_AskOnline.Model.t_member_account();
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
		public LW_AskOnline.Model.t_member_account DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member_account model=new LW_AskOnline.Model.t_member_account();
			if (row != null)
			{
				if(row["account_id"]!=null && row["account_id"].ToString()!="")
				{
					model.account_id=decimal.Parse(row["account_id"].ToString());
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["card_amount"]!=null && row["card_amount"].ToString()!="")
				{
					model.card_amount=decimal.Parse(row["card_amount"].ToString());
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
			strSql.Append("select account_id,amount,status,member_id,card_amount,member_type ");
			strSql.Append(" FROM t_member_account ");
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
			strSql.Append(" account_id,amount,status,member_id,card_amount,member_type ");
			strSql.Append(" FROM t_member_account ");
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
			strSql.Append("select count(1) FROM t_member_account ");
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
				strSql.Append("order by T.account_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_member_account T ");
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
			parameters[0].Value = "t_member_account";
			parameters[1].Value = "account_id";
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

