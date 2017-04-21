using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_member_card
	/// </summary>
	public partial class t_member_card:It_member_card
	{
		public t_member_card()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal card_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_member_card");
			strSql.Append(" where card_id=@card_id");
			SqlParameter[] parameters = {
					new SqlParameter("@card_id", SqlDbType.Decimal)
			};
			parameters[0].Value = card_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_member_card model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member_card(");
			strSql.Append("card_no,face_price,market_price,member_id,residual_amount,member_type)");
			strSql.Append(" values (");
			strSql.Append("@card_no,@face_price,@market_price,@member_id,@residual_amount,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@card_no", SqlDbType.VarChar,255),
					new SqlParameter("@face_price", SqlDbType.Float,8),
					new SqlParameter("@market_price", SqlDbType.Float,8),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@residual_amount", SqlDbType.Float,8),
					new SqlParameter("@member_type", SqlDbType.VarChar,255)};
			parameters[0].Value = model.card_no;
			parameters[1].Value = model.face_price;
			parameters[2].Value = model.market_price;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.residual_amount;
			parameters[5].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_member_card model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member_card set ");
			strSql.Append("card_no=@card_no,");
			strSql.Append("face_price=@face_price,");
			strSql.Append("market_price=@market_price,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("residual_amount=@residual_amount,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where card_id=@card_id");
			SqlParameter[] parameters = {
					new SqlParameter("@card_no", SqlDbType.VarChar,255),
					new SqlParameter("@face_price", SqlDbType.Float,8),
					new SqlParameter("@market_price", SqlDbType.Float,8),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@residual_amount", SqlDbType.Float,8),
					new SqlParameter("@member_type", SqlDbType.VarChar,255),
					new SqlParameter("@card_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.card_no;
			parameters[1].Value = model.face_price;
			parameters[2].Value = model.market_price;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.residual_amount;
			parameters[5].Value = model.member_type;
			parameters[6].Value = model.card_id;

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
		public bool Delete(decimal card_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_card ");
			strSql.Append(" where card_id=@card_id");
			SqlParameter[] parameters = {
					new SqlParameter("@card_id", SqlDbType.Decimal)
			};
			parameters[0].Value = card_id;

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
		public bool DeleteList(string card_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_card ");
			strSql.Append(" where card_id in ("+card_idlist + ")  ");
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
		public LW_AskOnline.Model.t_member_card GetModel(decimal card_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 card_id,card_no,face_price,market_price,member_id,residual_amount,member_type from t_member_card ");
			strSql.Append(" where card_id=@card_id");
			SqlParameter[] parameters = {
					new SqlParameter("@card_id", SqlDbType.Decimal)
			};
			parameters[0].Value = card_id;

			LW_AskOnline.Model.t_member_card model=new LW_AskOnline.Model.t_member_card();
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
		public LW_AskOnline.Model.t_member_card DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member_card model=new LW_AskOnline.Model.t_member_card();
			if (row != null)
			{
				if(row["card_id"]!=null && row["card_id"].ToString()!="")
				{
					model.card_id=decimal.Parse(row["card_id"].ToString());
				}
				if(row["card_no"]!=null)
				{
					model.card_no=row["card_no"].ToString();
				}
				if(row["face_price"]!=null && row["face_price"].ToString()!="")
				{
					model.face_price=decimal.Parse(row["face_price"].ToString());
				}
				if(row["market_price"]!=null && row["market_price"].ToString()!="")
				{
					model.market_price=decimal.Parse(row["market_price"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["residual_amount"]!=null && row["residual_amount"].ToString()!="")
				{
					model.residual_amount=decimal.Parse(row["residual_amount"].ToString());
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
			strSql.Append("select card_id,card_no,face_price,market_price,member_id,residual_amount,member_type ");
			strSql.Append(" FROM t_member_card ");
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
			strSql.Append(" card_id,card_no,face_price,market_price,member_id,residual_amount,member_type ");
			strSql.Append(" FROM t_member_card ");
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
			strSql.Append("select count(1) FROM t_member_card ");
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
				strSql.Append("order by T.card_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_member_card T ");
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
			parameters[0].Value = "t_member_card";
			parameters[1].Value = "card_id";
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

