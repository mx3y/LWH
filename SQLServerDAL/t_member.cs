using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_member
	/// </summary>
	public partial class t_member:It_member
	{
		public t_member()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal member_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_member");
			strSql.Append(" where member_id=@member_id");
			SqlParameter[] parameters = {
					new SqlParameter("@member_id", SqlDbType.Decimal)
			};
			parameters[0].Value = member_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(LW_AskOnline.Model.t_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_member(");
			strSql.Append("address,auth_flag,auth_remark,auth_time,card_image1,card_image2,cash_pwd,city,company,county,create_date,email,id_number,last_check_date,last_check_id,last_review_date,login_name,login_pwd,member_name,member_no,member_type,mobile,open_id,province,sex)");
			strSql.Append(" values (");
			strSql.Append("@address,@auth_flag,@auth_remark,@auth_time,@card_image1,@card_image2,@cash_pwd,@city,@company,@county,@create_date,@email,@id_number,@last_check_date,@last_check_id,@last_review_date,@login_name,@login_pwd,@member_name,@member_no,@member_type,@mobile,@open_id,@province,@sex)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@address", SqlDbType.VarChar,165),
					new SqlParameter("@auth_flag", SqlDbType.VarChar,10),
					new SqlParameter("@auth_remark", SqlDbType.VarChar,1000),
					new SqlParameter("@auth_time", SqlDbType.DateTime),
					new SqlParameter("@card_image1", SqlDbType.VarChar,300),
					new SqlParameter("@card_image2", SqlDbType.VarChar,300),
					new SqlParameter("@cash_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,165),
					new SqlParameter("@company", SqlDbType.VarChar,100),
					new SqlParameter("@county", SqlDbType.VarChar,165),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@id_number", SqlDbType.VarChar,30),
					new SqlParameter("@last_check_date", SqlDbType.DateTime),
					new SqlParameter("@last_check_id", SqlDbType.Decimal,9),
					new SqlParameter("@last_review_date", SqlDbType.DateTime),
					new SqlParameter("@login_name", SqlDbType.VarChar,50),
					new SqlParameter("@login_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@member_name", SqlDbType.VarChar,50),
					new SqlParameter("@member_no", SqlDbType.VarChar,20),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@mobile", SqlDbType.VarChar,15),
					new SqlParameter("@open_id", SqlDbType.VarChar,1000),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@sex", SqlDbType.VarChar,2)};
			parameters[0].Value = model.address;
			parameters[1].Value = model.auth_flag;
			parameters[2].Value = model.auth_remark;
			parameters[3].Value = model.auth_time;
			parameters[4].Value = model.card_image1;
			parameters[5].Value = model.card_image2;
			parameters[6].Value = model.cash_pwd;
			parameters[7].Value = model.city;
			parameters[8].Value = model.company;
			parameters[9].Value = model.county;
			parameters[10].Value = model.create_date;
			parameters[11].Value = model.email;
			parameters[12].Value = model.id_number;
			parameters[13].Value = model.last_check_date;
			parameters[14].Value = model.last_check_id;
			parameters[15].Value = model.last_review_date;
			parameters[16].Value = model.login_name;
			parameters[17].Value = model.login_pwd;
			parameters[18].Value = model.member_name;
			parameters[19].Value = model.member_no;
			parameters[20].Value = model.member_type;
			parameters[21].Value = model.mobile;
			parameters[22].Value = model.open_id;
			parameters[23].Value = model.province;
			parameters[24].Value = model.sex;

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
		public bool Update(LW_AskOnline.Model.t_member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_member set ");
			strSql.Append("address=@address,");
			strSql.Append("auth_flag=@auth_flag,");
			strSql.Append("auth_remark=@auth_remark,");
			strSql.Append("auth_time=@auth_time,");
			strSql.Append("card_image1=@card_image1,");
			strSql.Append("card_image2=@card_image2,");
			strSql.Append("cash_pwd=@cash_pwd,");
			strSql.Append("city=@city,");
			strSql.Append("company=@company,");
			strSql.Append("county=@county,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("email=@email,");
			strSql.Append("id_number=@id_number,");
			strSql.Append("last_check_date=@last_check_date,");
			strSql.Append("last_check_id=@last_check_id,");
			strSql.Append("last_review_date=@last_review_date,");
			strSql.Append("login_name=@login_name,");
			strSql.Append("login_pwd=@login_pwd,");
			strSql.Append("member_name=@member_name,");
			strSql.Append("member_no=@member_no,");
			strSql.Append("member_type=@member_type,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("open_id=@open_id,");
			strSql.Append("province=@province,");
			strSql.Append("sex=@sex");
			strSql.Append(" where member_id=@member_id");
			SqlParameter[] parameters = {
					new SqlParameter("@address", SqlDbType.VarChar,165),
					new SqlParameter("@auth_flag", SqlDbType.VarChar,10),
					new SqlParameter("@auth_remark", SqlDbType.VarChar,1000),
					new SqlParameter("@auth_time", SqlDbType.DateTime),
					new SqlParameter("@card_image1", SqlDbType.VarChar,300),
					new SqlParameter("@card_image2", SqlDbType.VarChar,300),
					new SqlParameter("@cash_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@city", SqlDbType.VarChar,165),
					new SqlParameter("@company", SqlDbType.VarChar,100),
					new SqlParameter("@county", SqlDbType.VarChar,165),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@email", SqlDbType.VarChar,100),
					new SqlParameter("@id_number", SqlDbType.VarChar,30),
					new SqlParameter("@last_check_date", SqlDbType.DateTime),
					new SqlParameter("@last_check_id", SqlDbType.Decimal,9),
					new SqlParameter("@last_review_date", SqlDbType.DateTime),
					new SqlParameter("@login_name", SqlDbType.VarChar,50),
					new SqlParameter("@login_pwd", SqlDbType.VarChar,50),
					new SqlParameter("@member_name", SqlDbType.VarChar,50),
					new SqlParameter("@member_no", SqlDbType.VarChar,20),
					new SqlParameter("@member_type", SqlDbType.VarChar,10),
					new SqlParameter("@mobile", SqlDbType.VarChar,15),
					new SqlParameter("@open_id", SqlDbType.VarChar,1000),
					new SqlParameter("@province", SqlDbType.VarChar,80),
					new SqlParameter("@sex", SqlDbType.VarChar,2),
					new SqlParameter("@member_id", SqlDbType.Decimal,9)};
			parameters[0].Value = model.address;
			parameters[1].Value = model.auth_flag;
			parameters[2].Value = model.auth_remark;
			parameters[3].Value = model.auth_time;
			parameters[4].Value = model.card_image1;
			parameters[5].Value = model.card_image2;
			parameters[6].Value = model.cash_pwd;
			parameters[7].Value = model.city;
			parameters[8].Value = model.company;
			parameters[9].Value = model.county;
			parameters[10].Value = model.create_date;
			parameters[11].Value = model.email;
			parameters[12].Value = model.id_number;
			parameters[13].Value = model.last_check_date;
			parameters[14].Value = model.last_check_id;
			parameters[15].Value = model.last_review_date;
			parameters[16].Value = model.login_name;
			parameters[17].Value = model.login_pwd;
			parameters[18].Value = model.member_name;
			parameters[19].Value = model.member_no;
			parameters[20].Value = model.member_type;
			parameters[21].Value = model.mobile;
			parameters[22].Value = model.open_id;
			parameters[23].Value = model.province;
			parameters[24].Value = model.sex;
			parameters[25].Value = model.member_id;

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
		public bool Delete(decimal member_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member ");
			strSql.Append(" where member_id=@member_id");
			SqlParameter[] parameters = {
					new SqlParameter("@member_id", SqlDbType.Decimal)
			};
			parameters[0].Value = member_id;

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
		public bool DeleteList(string member_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_member ");
			strSql.Append(" where member_id in ("+member_idlist + ")  ");
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
		public LW_AskOnline.Model.t_member GetModel(decimal member_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 member_id,address,auth_flag,auth_remark,auth_time,card_image1,card_image2,cash_pwd,city,company,county,create_date,email,id_number,last_check_date,last_check_id,last_review_date,login_name,login_pwd,member_name,member_no,member_type,mobile,open_id,province,sex from t_member ");
			strSql.Append(" where member_id=@member_id");
			SqlParameter[] parameters = {
					new SqlParameter("@member_id", SqlDbType.Decimal)
			};
			parameters[0].Value = member_id;

			LW_AskOnline.Model.t_member model=new LW_AskOnline.Model.t_member();
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
		public LW_AskOnline.Model.t_member DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_member model=new LW_AskOnline.Model.t_member();
			if (row != null)
			{
				if(row["member_id"]!=null && row["member_id"].ToString()!="")
				{
					model.member_id=decimal.Parse(row["member_id"].ToString());
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["auth_flag"]!=null)
				{
					model.auth_flag=row["auth_flag"].ToString();
				}
				if(row["auth_remark"]!=null)
				{
					model.auth_remark=row["auth_remark"].ToString();
				}
				if(row["auth_time"]!=null && row["auth_time"].ToString()!="")
				{
					model.auth_time=DateTime.Parse(row["auth_time"].ToString());
				}
				if(row["card_image1"]!=null)
				{
					model.card_image1=row["card_image1"].ToString();
				}
				if(row["card_image2"]!=null)
				{
					model.card_image2=row["card_image2"].ToString();
				}
				if(row["cash_pwd"]!=null)
				{
					model.cash_pwd=row["cash_pwd"].ToString();
				}
				if(row["city"]!=null)
				{
					model.city=row["city"].ToString();
				}
				if(row["company"]!=null)
				{
					model.company=row["company"].ToString();
				}
				if(row["county"]!=null)
				{
					model.county=row["county"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["id_number"]!=null)
				{
					model.id_number=row["id_number"].ToString();
				}
				if(row["last_check_date"]!=null && row["last_check_date"].ToString()!="")
				{
					model.last_check_date=DateTime.Parse(row["last_check_date"].ToString());
				}
				if(row["last_check_id"]!=null && row["last_check_id"].ToString()!="")
				{
					model.last_check_id=decimal.Parse(row["last_check_id"].ToString());
				}
				if(row["last_review_date"]!=null && row["last_review_date"].ToString()!="")
				{
					model.last_review_date=DateTime.Parse(row["last_review_date"].ToString());
				}
				if(row["login_name"]!=null)
				{
					model.login_name=row["login_name"].ToString();
				}
				if(row["login_pwd"]!=null)
				{
					model.login_pwd=row["login_pwd"].ToString();
				}
				if(row["member_name"]!=null)
				{
					model.member_name=row["member_name"].ToString();
				}
				if(row["member_no"]!=null)
				{
					model.member_no=row["member_no"].ToString();
				}
				if(row["member_type"]!=null)
				{
					model.member_type=row["member_type"].ToString();
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["open_id"]!=null)
				{
					model.open_id=row["open_id"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
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
			strSql.Append("select member_id,address,auth_flag,auth_remark,auth_time,card_image1,card_image2,cash_pwd,city,company,county,create_date,email,id_number,last_check_date,last_check_id,last_review_date,login_name,login_pwd,member_name,member_no,member_type,mobile,open_id,province,sex ");
			strSql.Append(" FROM t_member ");
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
			strSql.Append(" member_id,address,auth_flag,auth_remark,auth_time,card_image1,card_image2,cash_pwd,city,company,county,create_date,email,id_number,last_check_date,last_check_id,last_review_date,login_name,login_pwd,member_name,member_no,member_type,mobile,open_id,province,sex ");
			strSql.Append(" FROM t_member ");
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
			strSql.Append("select count(1) FROM t_member ");
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
				strSql.Append("order by T.member_id desc");
			}
			strSql.Append(")AS Row, T.*  from t_member T ");
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
			parameters[0].Value = "t_member";
			parameters[1].Value = "member_id";
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

