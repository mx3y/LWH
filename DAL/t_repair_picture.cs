using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_repair_picture
	/// </summary>
	public partial class t_repair_picture
	{
		public t_repair_picture()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal picture_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_repair_picture");
			strSql.Append(" where picture_id=@picture_id");
			SqlParameter[] parameters = {
					new SqlParameter("@picture_id", SqlDbType.Decimal)
			};
			parameters[0].Value = picture_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_repair_picture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_repair_picture(");
			strSql.Append("picture,repairId)");
			strSql.Append(" values (");
			strSql.Append("@picture,@repairId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@repairId", SqlDbType.Decimal,9)};
			parameters[0].Value = model.picture;
			parameters[1].Value = model.repairId;

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
		public bool Update(LW_AskOnline.Model.t_repair_picture model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_repair_picture set ");
			strSql.Append("picture=@picture,");
			strSql.Append("repairId=@repairId");
			strSql.Append(" where picture_id=@picture_id");
			SqlParameter[] parameters = {
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@repairId", SqlDbType.Decimal,9),
					new SqlParameter("@picture_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.picture;
			parameters[1].Value = model.repairId;
			parameters[2].Value = model.picture_id;

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
		public bool Delete(decimal picture_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_repair_picture ");
			strSql.Append(" where picture_id=@picture_id");
			SqlParameter[] parameters = {
					new SqlParameter("@picture_id", SqlDbType.Decimal)
			};
			parameters[0].Value = picture_id;

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
		public bool DeleteList(string picture_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_repair_picture ");
			strSql.Append(" where picture_id in ("+picture_idlist + ")  ");
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
		public LW_AskOnline.Model.t_repair_picture GetModel(decimal picture_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 picture_id,picture,repairId from t_repair_picture ");
			strSql.Append(" where picture_id=@picture_id");
			SqlParameter[] parameters = {
					new SqlParameter("@picture_id", SqlDbType.Decimal)
			};
			parameters[0].Value = picture_id;

			LW_AskOnline.Model.t_repair_picture model=new LW_AskOnline.Model.t_repair_picture();
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
		public LW_AskOnline.Model.t_repair_picture DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_repair_picture model=new LW_AskOnline.Model.t_repair_picture();
			if (row != null)
			{
				if(row["picture_id"]!=null && row["picture_id"].ToString()!="")
				{
					model.picture_id=decimal.Parse(row["picture_id"].ToString());
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
				}
				if(row["repairId"]!=null && row["repairId"].ToString()!="")
				{
					model.repairId=decimal.Parse(row["repairId"].ToString());
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
			strSql.Append("select picture_id,picture,repairId ");
			strSql.Append(" FROM t_repair_picture ");
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
			strSql.Append(" picture_id,picture,repairId ");
			strSql.Append(" FROM t_repair_picture ");
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
			strSql.Append("select count(1) FROM t_repair_picture ");
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
				strSql.Append("order by T.picture_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_repair_picture T ");
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
			parameters[0].Value = "t_repair_picture";
			parameters[1].Value = "picture_id";
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

