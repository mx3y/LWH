using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_evaluation_info
	/// </summary>
	public partial class t_evaluation_info
	{
		public t_evaluation_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal evaluation_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_evaluation_info");
			strSql.Append(" where evaluation_id=@evaluation_id");
			SqlParameter[] parameters = {
					new SqlParameter("@evaluation_id", SqlDbType.Decimal)
			};
			parameters[0].Value = evaluation_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_evaluation_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_evaluation_info(");
			strSql.Append("content,evaluation_time,level,member_id,goods_id,detail_id,is_anonymous,grade,is_picture,member_type)");
			strSql.Append(" values (");
			strSql.Append("@content,@evaluation_time,@level,@member_id,@goods_id,@detail_id,@is_anonymous,@grade,@is_picture,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@content", SqlDbType.VarChar,2000),
					new SqlParameter("@evaluation_time", SqlDbType.DateTime),
					new SqlParameter("@level", SqlDbType.Int,4),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@detail_id", SqlDbType.Decimal,9),
					new SqlParameter("@is_anonymous", SqlDbType.Int,4),
					new SqlParameter("@grade", SqlDbType.Int,4),
					new SqlParameter("@is_picture", SqlDbType.Int,4),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.content;
			parameters[1].Value = model.evaluation_time;
			parameters[2].Value = model.level;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.goods_id;
			parameters[5].Value = model.detail_id;
			parameters[6].Value = model.is_anonymous;
			parameters[7].Value = model.grade;
			parameters[8].Value = model.is_picture;
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
		public bool Update(LW_AskOnline.Model.t_evaluation_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_evaluation_info set ");
			strSql.Append("content=@content,");
			strSql.Append("evaluation_time=@evaluation_time,");
			strSql.Append("level=@level,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("goods_id=@goods_id,");
			strSql.Append("detail_id=@detail_id,");
			strSql.Append("is_anonymous=@is_anonymous,");
			strSql.Append("grade=@grade,");
			strSql.Append("is_picture=@is_picture,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where evaluation_id=@evaluation_id");
			SqlParameter[] parameters = {
					new SqlParameter("@content", SqlDbType.VarChar,2000),
					new SqlParameter("@evaluation_time", SqlDbType.DateTime),
					new SqlParameter("@level", SqlDbType.Int,4),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@goods_id", SqlDbType.Decimal,9),
					new SqlParameter("@detail_id", SqlDbType.Decimal,9),
					new SqlParameter("@is_anonymous", SqlDbType.Int,4),
					new SqlParameter("@grade", SqlDbType.Int,4),
					new SqlParameter("@is_picture", SqlDbType.Int,4),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@evaluation_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.content;
			parameters[1].Value = model.evaluation_time;
			parameters[2].Value = model.level;
			parameters[3].Value = model.member_id;
			parameters[4].Value = model.goods_id;
			parameters[5].Value = model.detail_id;
			parameters[6].Value = model.is_anonymous;
			parameters[7].Value = model.grade;
			parameters[8].Value = model.is_picture;
			parameters[9].Value = model.member_type;
			parameters[10].Value = model.evaluation_id;

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
		public bool Delete(decimal evaluation_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_evaluation_info ");
			strSql.Append(" where evaluation_id=@evaluation_id");
			SqlParameter[] parameters = {
					new SqlParameter("@evaluation_id", SqlDbType.Decimal)
			};
			parameters[0].Value = evaluation_id;

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
		public bool DeleteList(string evaluation_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_evaluation_info ");
			strSql.Append(" where evaluation_id in ("+evaluation_idlist + ")  ");
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
		public LW_AskOnline.Model.t_evaluation_info GetModel(decimal evaluation_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 evaluation_id,content,evaluation_time,level,member_id,goods_id,detail_id,is_anonymous,grade,is_picture,member_type from t_evaluation_info ");
			strSql.Append(" where evaluation_id=@evaluation_id");
			SqlParameter[] parameters = {
					new SqlParameter("@evaluation_id", SqlDbType.Decimal)
			};
			parameters[0].Value = evaluation_id;

			LW_AskOnline.Model.t_evaluation_info model=new LW_AskOnline.Model.t_evaluation_info();
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
		public LW_AskOnline.Model.t_evaluation_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_evaluation_info model=new LW_AskOnline.Model.t_evaluation_info();
			if (row != null)
			{
				if(row["evaluation_id"]!=null && row["evaluation_id"].ToString()!="")
				{
					model.evaluation_id=decimal.Parse(row["evaluation_id"].ToString());
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["evaluation_time"]!=null && row["evaluation_time"].ToString()!="")
				{
					model.evaluation_time=DateTime.Parse(row["evaluation_time"].ToString());
				}
				if(row["level"]!=null && row["level"].ToString()!="")
				{
					model.level=int.Parse(row["level"].ToString());
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["goods_id"]!=null && row["goods_id"].ToString()!="")
				{
					model.goods_id=decimal.Parse(row["goods_id"].ToString());
				}
				if(row["detail_id"]!=null && row["detail_id"].ToString()!="")
				{
					model.detail_id=decimal.Parse(row["detail_id"].ToString());
				}
				if(row["is_anonymous"]!=null && row["is_anonymous"].ToString()!="")
				{
					model.is_anonymous=int.Parse(row["is_anonymous"].ToString());
				}
				if(row["grade"]!=null && row["grade"].ToString()!="")
				{
					model.grade=int.Parse(row["grade"].ToString());
				}
				if(row["is_picture"]!=null && row["is_picture"].ToString()!="")
				{
					model.is_picture=int.Parse(row["is_picture"].ToString());
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
			strSql.Append("select evaluation_id,content,evaluation_time,level,member_id,goods_id,detail_id,is_anonymous,grade,is_picture,member_type ");
			strSql.Append(" FROM t_evaluation_info ");
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
			strSql.Append(" evaluation_id,content,evaluation_time,level,member_id,goods_id,detail_id,is_anonymous,grade,is_picture,member_type ");
			strSql.Append(" FROM t_evaluation_info ");
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
			strSql.Append("select count(1) FROM t_evaluation_info ");
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
				strSql.Append("order by T.evaluation_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_evaluation_info T ");
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
			parameters[0].Value = "t_evaluation_info";
			parameters[1].Value = "evaluation_id";
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

