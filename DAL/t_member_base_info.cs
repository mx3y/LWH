using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:t_member_base_info
	/// </summary>
	public partial class t_member_base_info
	{
		public t_member_base_info()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal base_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_member_base_info");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Decimal)
			};
			parameters[0].Value = base_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_member_base_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member_base_info(");
			strSql.Append("degree,income,industry,marital_status,position,scale,school,member_id,birthday,picture,member_type)");
			strSql.Append(" values (");
			strSql.Append("@degree,@income,@industry,@marital_status,@position,@scale,@school,@member_id,@birthday,@picture,@member_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@degree", SqlDbType.VarChar,20),
					new SqlParameter("@income", SqlDbType.VarChar,65),
					new SqlParameter("@industry", SqlDbType.VarChar,100),
					new SqlParameter("@marital_status", SqlDbType.VarChar,15),
					new SqlParameter("@position", SqlDbType.VarChar,65),
					new SqlParameter("@scale", SqlDbType.VarChar,80),
					new SqlParameter("@school", SqlDbType.VarChar,80),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@birthday", SqlDbType.VarChar,20),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@member_type", SqlDbType.VarChar,10)};
			parameters[0].Value = model.degree;
			parameters[1].Value = model.income;
			parameters[2].Value = model.industry;
			parameters[3].Value = model.marital_status;
			parameters[4].Value = model.position;
			parameters[5].Value = model.scale;
			parameters[6].Value = model.school;
			parameters[7].Value = model.member_id;
			parameters[8].Value = model.birthday;
			parameters[9].Value = model.picture;
			parameters[10].Value = model.member_type;

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
		public bool Update(LW_AskOnline.Model.t_member_base_info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member_base_info set ");
			strSql.Append("degree=@degree,");
			strSql.Append("income=@income,");
			strSql.Append("industry=@industry,");
			strSql.Append("marital_status=@marital_status,");
			strSql.Append("position=@position,");
			strSql.Append("scale=@scale,");
			strSql.Append("school=@school,");
			strSql.Append("member_id=@member_id,");
			strSql.Append("birthday=@birthday,");
			strSql.Append("picture=@picture,");
			strSql.Append("member_type=@member_type");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@degree", SqlDbType.VarChar,20),
					new SqlParameter("@income", SqlDbType.VarChar,65),
					new SqlParameter("@industry", SqlDbType.VarChar,100),
					new SqlParameter("@marital_status", SqlDbType.VarChar,15),
					new SqlParameter("@position", SqlDbType.VarChar,65),
					new SqlParameter("@scale", SqlDbType.VarChar,80),
					new SqlParameter("@school", SqlDbType.VarChar,80),
					new SqlParameter("@member_id", SqlDbType.Decimal,9),
					new SqlParameter("@birthday", SqlDbType.VarChar,20),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@base_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.degree;
			parameters[1].Value = model.income;
			parameters[2].Value = model.industry;
			parameters[3].Value = model.marital_status;
			parameters[4].Value = model.position;
			parameters[5].Value = model.scale;
			parameters[6].Value = model.school;
			parameters[7].Value = model.member_id;
			parameters[8].Value = model.birthday;
			parameters[9].Value = model.picture;
			parameters[10].Value = model.member_type;
			parameters[11].Value = model.base_id;

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
		public bool Delete(decimal base_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_base_info ");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Decimal)
			};
			parameters[0].Value = base_id;

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
		public bool DeleteList(string base_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member_base_info ");
			strSql.Append(" where base_id in ("+base_idlist + ")  ");
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
		public LW_AskOnline.Model.t_member_base_info GetModel(decimal base_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 base_id,degree,income,industry,marital_status,position,scale,school,member_id,birthday,picture,member_type from t_member_base_info ");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Decimal)
			};
			parameters[0].Value = base_id;

			LW_AskOnline.Model.t_member_base_info model=new LW_AskOnline.Model.t_member_base_info();
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
		public LW_AskOnline.Model.t_member_base_info DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member_base_info model=new LW_AskOnline.Model.t_member_base_info();
			if (row != null)
			{
				if(row["base_id"]!=null && row["base_id"].ToString()!="")
				{
					model.base_id=decimal.Parse(row["base_id"].ToString());
				}
				if(row["degree"]!=null)
				{
					model.degree=row["degree"].ToString();
				}
				if(row["income"]!=null)
				{
					model.income=row["income"].ToString();
				}
				if(row["industry"]!=null)
				{
					model.industry=row["industry"].ToString();
				}
				if(row["marital_status"]!=null)
				{
					model.marital_status=row["marital_status"].ToString();
				}
				if(row["position"]!=null)
				{
					model.position=row["position"].ToString();
				}
				if(row["scale"]!=null)
				{
					model.scale=row["scale"].ToString();
				}
				if(row["school"]!=null)
				{
					model.school=row["school"].ToString();
				}
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["birthday"]!=null)
				{
					model.birthday=row["birthday"].ToString();
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
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
			strSql.Append("select base_id,degree,income,industry,marital_status,position,scale,school,member_id,birthday,picture,member_type ");
			strSql.Append(" FROM t_member_base_info ");
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
			strSql.Append(" base_id,degree,income,industry,marital_status,position,scale,school,member_id,birthday,picture,member_type ");
			strSql.Append(" FROM t_member_base_info ");
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
			strSql.Append("select count(1) FROM t_member_base_info ");
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
				strSql.Append("order by T.base_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_member_base_info T ");
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
			parameters[0].Value = "t_member_base_info";
			parameters[1].Value = "base_id";
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

