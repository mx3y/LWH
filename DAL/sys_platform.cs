using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.DAL
{
	/// <summary>
	/// 数据访问类:sys_platform
	/// </summary>
	public partial class sys_platform
	{
		public sys_platform()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "sys_platform"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sys_platform");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.sys_platform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sys_platform(");
			strSql.Append("platfrom,province,city,area,address,phone,parent_id,status,mark,aboutus,createtime,homepageimage,logo,payment,paymentkey,platformdescription,shortplatform,using_this,weurl)");
			strSql.Append(" values (");
			strSql.Append("@platfrom,@province,@city,@area,@address,@phone,@parent_id,@status,@mark,@aboutus,@createtime,@homepageimage,@logo,@payment,@paymentkey,@platformdescription,@shortplatform,@using_this,@weurl)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@platfrom", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@area", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@mark", SqlDbType.Int,4),
					new SqlParameter("@aboutus", SqlDbType.VarChar,255),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@homepageimage", SqlDbType.VarChar,255),
					new SqlParameter("@logo", SqlDbType.VarChar,255),
					new SqlParameter("@payment", SqlDbType.VarChar,255),
					new SqlParameter("@paymentkey", SqlDbType.VarChar,255),
					new SqlParameter("@platformdescription", SqlDbType.VarChar,255),
					new SqlParameter("@shortplatform", SqlDbType.VarChar,255),
					new SqlParameter("@using_this", SqlDbType.VarChar,255),
					new SqlParameter("@weurl", SqlDbType.VarChar,255)};
			parameters[0].Value = model.platfrom;
			parameters[1].Value = model.province;
			parameters[2].Value = model.city;
			parameters[3].Value = model.area;
			parameters[4].Value = model.address;
			parameters[5].Value = model.phone;
			parameters[6].Value = model.parent_id;
			parameters[7].Value = model.status;
			parameters[8].Value = model.mark;
			parameters[9].Value = model.aboutus;
			parameters[10].Value = model.createtime;
			parameters[11].Value = model.homepageimage;
			parameters[12].Value = model.logo;
			parameters[13].Value = model.payment;
			parameters[14].Value = model.paymentkey;
			parameters[15].Value = model.platformdescription;
			parameters[16].Value = model.shortplatform;
			parameters[17].Value = model.using_this;
			parameters[18].Value = model.weurl;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(LW_AskOnline.Model.sys_platform model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sys_platform set ");
			strSql.Append("platfrom=@platfrom,");
			strSql.Append("province=@province,");
			strSql.Append("city=@city,");
			strSql.Append("area=@area,");
			strSql.Append("address=@address,");
			strSql.Append("phone=@phone,");
			strSql.Append("parent_id=@parent_id,");
			strSql.Append("status=@status,");
			strSql.Append("mark=@mark,");
			strSql.Append("aboutus=@aboutus,");
			strSql.Append("createtime=@createtime,");
			strSql.Append("homepageimage=@homepageimage,");
			strSql.Append("logo=@logo,");
			strSql.Append("payment=@payment,");
			strSql.Append("paymentkey=@paymentkey,");
			strSql.Append("platformdescription=@platformdescription,");
			strSql.Append("shortplatform=@shortplatform,");
			strSql.Append("using_this=@using_this,");
			strSql.Append("weurl=@weurl");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@platfrom", SqlDbType.VarChar,50),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,50),
					new SqlParameter("@area", SqlDbType.VarChar,50),
					new SqlParameter("@address", SqlDbType.VarChar,200),
					new SqlParameter("@phone", SqlDbType.VarChar,20),
					new SqlParameter("@parent_id", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.VarChar,2),
					new SqlParameter("@mark", SqlDbType.Int,4),
					new SqlParameter("@aboutus", SqlDbType.VarChar,255),
					new SqlParameter("@createtime", SqlDbType.DateTime),
					new SqlParameter("@homepageimage", SqlDbType.VarChar,255),
					new SqlParameter("@logo", SqlDbType.VarChar,255),
					new SqlParameter("@payment", SqlDbType.VarChar,255),
					new SqlParameter("@paymentkey", SqlDbType.VarChar,255),
					new SqlParameter("@platformdescription", SqlDbType.VarChar,255),
					new SqlParameter("@shortplatform", SqlDbType.VarChar,255),
					new SqlParameter("@using_this", SqlDbType.VarChar,255),
					new SqlParameter("@weurl", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.platfrom;
			parameters[1].Value = model.province;
			parameters[2].Value = model.city;
			parameters[3].Value = model.area;
			parameters[4].Value = model.address;
			parameters[5].Value = model.phone;
			parameters[6].Value = model.parent_id;
			parameters[7].Value = model.status;
			parameters[8].Value = model.mark;
			parameters[9].Value = model.aboutus;
			parameters[10].Value = model.createtime;
			parameters[11].Value = model.homepageimage;
			parameters[12].Value = model.logo;
			parameters[13].Value = model.payment;
			parameters[14].Value = model.paymentkey;
			parameters[15].Value = model.platformdescription;
			parameters[16].Value = model.shortplatform;
			parameters[17].Value = model.using_this;
			parameters[18].Value = model.weurl;
			parameters[19].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sys_platform ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
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
			strSql.Append("delete from sys_platform ");
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
		public LW_AskOnline.Model.sys_platform GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,platfrom,province,city,area,address,phone,parent_id,status,mark,aboutus,createtime,homepageimage,logo,payment,paymentkey,platformdescription,shortplatform,using_this,weurl from sys_platform ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.sys_platform model=new LW_AskOnline.Model.sys_platform();
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
		public LW_AskOnline.Model.sys_platform DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.sys_platform model=new LW_AskOnline.Model.sys_platform();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["platfrom"]!=null)
				{
					model.platfrom=row["platfrom"].ToString();
				}
				if(row["province"]!=null)
				{
					model.province=row["province"].ToString();
				}
				if(row["city"]!=null)
				{
					model.city=row["city"].ToString();
				}
				if(row["area"]!=null)
				{
					model.area=row["area"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["parent_id"]!=null && row["parent_id"].ToString()!="")
				{
					model.parent_id=int.Parse(row["parent_id"].ToString());
				}
				if(row["status"]!=null)
				{
					model.status=row["status"].ToString();
				}
				if(row["mark"]!=null && row["mark"].ToString()!="")
				{
					model.mark=int.Parse(row["mark"].ToString());
				}
				if(row["aboutus"]!=null)
				{
					model.aboutus=row["aboutus"].ToString();
				}
				if(row["createtime"]!=null && row["createtime"].ToString()!="")
				{
					model.createtime=DateTime.Parse(row["createtime"].ToString());
				}
				if(row["homepageimage"]!=null)
				{
					model.homepageimage=row["homepageimage"].ToString();
				}
				if(row["logo"]!=null)
				{
					model.logo=row["logo"].ToString();
				}
				if(row["payment"]!=null)
				{
					model.payment=row["payment"].ToString();
				}
				if(row["paymentkey"]!=null)
				{
					model.paymentkey=row["paymentkey"].ToString();
				}
				if(row["platformdescription"]!=null)
				{
					model.platformdescription=row["platformdescription"].ToString();
				}
				if(row["shortplatform"]!=null)
				{
					model.shortplatform=row["shortplatform"].ToString();
				}
				if(row["using_this"]!=null)
				{
					model.using_this=row["using_this"].ToString();
				}
				if(row["weurl"]!=null)
				{
					model.weurl=row["weurl"].ToString();
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
			strSql.Append("select id,platfrom,province,city,area,address,phone,parent_id,status,mark,aboutus,createtime,homepageimage,logo,payment,paymentkey,platformdescription,shortplatform,using_this,weurl ");
			strSql.Append(" FROM sys_platform ");
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
			strSql.Append(" id,platfrom,province,city,area,address,phone,parent_id,status,mark,aboutus,createtime,homepageimage,logo,payment,paymentkey,platformdescription,shortplatform,using_this,weurl ");
			strSql.Append(" FROM sys_platform ");
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
			strSql.Append("select count(1) FROM sys_platform ");
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
			strSql.Append(")AS Row, T.*  from sys_platform T ");
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
			parameters[0].Value = "sys_platform";
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

