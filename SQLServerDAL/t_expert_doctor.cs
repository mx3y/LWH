﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_expert_doctor
	/// </summary>
	public partial class t_expert_doctor:It_expert_doctor
	{
		public t_expert_doctor()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal doctor_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_expert_doctor");
			strSql.Append(" where doctor_id=@doctor_id");
			SqlParameter[] parameters = {
					new SqlParameter("@doctor_id", SqlDbType.Decimal)
			};
			parameters[0].Value = doctor_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_expert_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_expert_doctor(");
			strSql.Append("doctor_name,is_recommend,job_title,picture,remark,index_pic,index_position)");
			strSql.Append(" values (");
			strSql.Append("@doctor_name,@is_recommend,@job_title,@picture,@remark,@index_pic,@index_position)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@doctor_name", SqlDbType.VarChar,255),
					new SqlParameter("@is_recommend", SqlDbType.Int,4),
					new SqlParameter("@job_title", SqlDbType.VarChar,255),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar,800),
					new SqlParameter("@index_pic", SqlDbType.VarChar,200),
					new SqlParameter("@index_position", SqlDbType.VarChar,2)};
			parameters[0].Value = model.doctor_name;
			parameters[1].Value = model.is_recommend;
			parameters[2].Value = model.job_title;
			parameters[3].Value = model.picture;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.index_pic;
			parameters[6].Value = model.index_position;

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
		public bool Update(LW_AskOnline.Model.t_expert_doctor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_expert_doctor set ");
			strSql.Append("doctor_name=@doctor_name,");
			strSql.Append("is_recommend=@is_recommend,");
			strSql.Append("job_title=@job_title,");
			strSql.Append("picture=@picture,");
			strSql.Append("remark=@remark,");
			strSql.Append("index_pic=@index_pic,");
			strSql.Append("index_position=@index_position");
			strSql.Append(" where doctor_id=@doctor_id");
			SqlParameter[] parameters = {
					new SqlParameter("@doctor_name", SqlDbType.VarChar,255),
					new SqlParameter("@is_recommend", SqlDbType.Int,4),
					new SqlParameter("@job_title", SqlDbType.VarChar,255),
					new SqlParameter("@picture", SqlDbType.VarChar,200),
					new SqlParameter("@remark", SqlDbType.VarChar,800),
					new SqlParameter("@index_pic", SqlDbType.VarChar,200),
					new SqlParameter("@index_position", SqlDbType.VarChar,2),
					new SqlParameter("@doctor_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.doctor_name;
			parameters[1].Value = model.is_recommend;
			parameters[2].Value = model.job_title;
			parameters[3].Value = model.picture;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.index_pic;
			parameters[6].Value = model.index_position;
			parameters[7].Value = model.doctor_id;

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
		public bool Delete(decimal doctor_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_expert_doctor ");
			strSql.Append(" where doctor_id=@doctor_id");
			SqlParameter[] parameters = {
					new SqlParameter("@doctor_id", SqlDbType.Decimal)
			};
			parameters[0].Value = doctor_id;

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
		public bool DeleteList(string doctor_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_expert_doctor ");
			strSql.Append(" where doctor_id in ("+doctor_idlist + ")  ");
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
		public LW_AskOnline.Model.t_expert_doctor GetModel(decimal doctor_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 doctor_id,doctor_name,is_recommend,job_title,picture,remark,index_pic,index_position from t_expert_doctor ");
			strSql.Append(" where doctor_id=@doctor_id");
			SqlParameter[] parameters = {
					new SqlParameter("@doctor_id", SqlDbType.Decimal)
			};
			parameters[0].Value = doctor_id;

			LW_AskOnline.Model.t_expert_doctor model=new LW_AskOnline.Model.t_expert_doctor();
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
		public LW_AskOnline.Model.t_expert_doctor DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_expert_doctor model=new LW_AskOnline.Model.t_expert_doctor();
			if (row != null)
			{
				if(row["doctor_id"]!=null && row["doctor_id"].ToString()!="")
				{
					model.doctor_id=decimal.Parse(row["doctor_id"].ToString());
				}
				if(row["doctor_name"]!=null)
				{
					model.doctor_name=row["doctor_name"].ToString();
				}
				if(row["is_recommend"]!=null && row["is_recommend"].ToString()!="")
				{
					model.is_recommend=int.Parse(row["is_recommend"].ToString());
				}
				if(row["job_title"]!=null)
				{
					model.job_title=row["job_title"].ToString();
				}
				if(row["picture"]!=null)
				{
					model.picture=row["picture"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["index_pic"]!=null)
				{
					model.index_pic=row["index_pic"].ToString();
				}
				if(row["index_position"]!=null)
				{
					model.index_position=row["index_position"].ToString();
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
			strSql.Append("select doctor_id,doctor_name,is_recommend,job_title,picture,remark,index_pic,index_position ");
			strSql.Append(" FROM t_expert_doctor ");
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
			strSql.Append(" doctor_id,doctor_name,is_recommend,job_title,picture,remark,index_pic,index_position ");
			strSql.Append(" FROM t_expert_doctor ");
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
			strSql.Append("select count(1) FROM t_expert_doctor ");
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
				strSql.Append("order by T.doctor_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_expert_doctor T ");
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
			parameters[0].Value = "t_expert_doctor";
			parameters[1].Value = "doctor_id";
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

