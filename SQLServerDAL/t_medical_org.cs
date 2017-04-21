using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:t_medical_org
	/// </summary>
	public partial class t_medical_org:It_medical_org
	{
		public t_medical_org()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "t_medical_org"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_medical_org");
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
		public int Add(LW_AskOnline.Model.t_medical_org model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_medical_org(");
			strSql.Append("org_name,province,city,area,adress,org_intro,evaluate,del_flag,level,daily_check,create_date,orgIntro,org_picture_list,org_home_img,jgzs,mianji,alias,paixu,dwdztc,zztc,discription,fullydate,org_code,playday)");
			strSql.Append(" values (");
			strSql.Append("@org_name,@province,@city,@area,@adress,@org_intro,@evaluate,@del_flag,@level,@daily_check,@create_date,@orgIntro,@org_picture_list,@org_home_img,@jgzs,@mianji,@alias,@paixu,@dwdztc,@zztc,@discription,@fullydate,@org_code,@playday)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@org_name", SqlDbType.VarChar,100),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,100),
					new SqlParameter("@area", SqlDbType.VarChar,100),
					new SqlParameter("@adress", SqlDbType.VarChar,500),
					new SqlParameter("@org_intro", SqlDbType.Text),
					new SqlParameter("@evaluate", SqlDbType.Text),
					new SqlParameter("@del_flag", SqlDbType.VarChar,2),
					new SqlParameter("@level", SqlDbType.NVarChar,5),
					new SqlParameter("@daily_check", SqlDbType.NVarChar,50),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@orgIntro", SqlDbType.VarChar,255),
					new SqlParameter("@org_picture_list", SqlDbType.VarChar,600),
					new SqlParameter("@org_home_img", SqlDbType.VarChar,600),
					new SqlParameter("@jgzs", SqlDbType.VarChar,255),
					new SqlParameter("@mianji", SqlDbType.VarChar,255),
					new SqlParameter("@alias", SqlDbType.VarChar,255),
					new SqlParameter("@paixu", SqlDbType.Int,4),
					new SqlParameter("@dwdztc", SqlDbType.VarChar,255),
					new SqlParameter("@zztc", SqlDbType.VarChar,255),
					new SqlParameter("@discription", SqlDbType.VarChar,255),
					new SqlParameter("@fullydate", SqlDbType.VarChar,255),
					new SqlParameter("@org_code", SqlDbType.VarChar,100),
					new SqlParameter("@playday", SqlDbType.VarChar,255)};
			parameters[0].Value = model.org_name;
			parameters[1].Value = model.province;
			parameters[2].Value = model.city;
			parameters[3].Value = model.area;
			parameters[4].Value = model.adress;
			parameters[5].Value = model.org_intro;
			parameters[6].Value = model.evaluate;
			parameters[7].Value = model.del_flag;
			parameters[8].Value = model.level;
			parameters[9].Value = model.daily_check;
			parameters[10].Value = model.create_date;
			parameters[11].Value = model.orgIntro;
			parameters[12].Value = model.org_picture_list;
			parameters[13].Value = model.org_home_img;
			parameters[14].Value = model.jgzs;
			parameters[15].Value = model.mianji;
			parameters[16].Value = model.alias;
			parameters[17].Value = model.paixu;
			parameters[18].Value = model.dwdztc;
			parameters[19].Value = model.zztc;
			parameters[20].Value = model.discription;
			parameters[21].Value = model.fullydate;
			parameters[22].Value = model.org_code;
			parameters[23].Value = model.playday;

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
		public bool Update(LW_AskOnline.Model.t_medical_org model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_medical_org set ");
			strSql.Append("org_name=@org_name,");
			strSql.Append("province=@province,");
			strSql.Append("city=@city,");
			strSql.Append("area=@area,");
			strSql.Append("adress=@adress,");
			strSql.Append("org_intro=@org_intro,");
			strSql.Append("evaluate=@evaluate,");
			strSql.Append("del_flag=@del_flag,");
			strSql.Append("level=@level,");
			strSql.Append("daily_check=@daily_check,");
			strSql.Append("create_date=@create_date,");
			strSql.Append("orgIntro=@orgIntro,");
			strSql.Append("org_picture_list=@org_picture_list,");
			strSql.Append("org_home_img=@org_home_img,");
			strSql.Append("jgzs=@jgzs,");
			strSql.Append("mianji=@mianji,");
			strSql.Append("alias=@alias,");
			strSql.Append("paixu=@paixu,");
			strSql.Append("dwdztc=@dwdztc,");
			strSql.Append("zztc=@zztc,");
			strSql.Append("discription=@discription,");
			strSql.Append("fullydate=@fullydate,");
			strSql.Append("org_code=@org_code,");
			strSql.Append("playday=@playday");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@org_name", SqlDbType.VarChar,100),
					new SqlParameter("@province", SqlDbType.VarChar,100),
					new SqlParameter("@city", SqlDbType.VarChar,100),
					new SqlParameter("@area", SqlDbType.VarChar,100),
					new SqlParameter("@adress", SqlDbType.VarChar,500),
					new SqlParameter("@org_intro", SqlDbType.Text),
					new SqlParameter("@evaluate", SqlDbType.Text),
					new SqlParameter("@del_flag", SqlDbType.VarChar,2),
					new SqlParameter("@level", SqlDbType.NVarChar,5),
					new SqlParameter("@daily_check", SqlDbType.NVarChar,50),
					new SqlParameter("@create_date", SqlDbType.DateTime),
					new SqlParameter("@orgIntro", SqlDbType.VarChar,255),
					new SqlParameter("@org_picture_list", SqlDbType.VarChar,600),
					new SqlParameter("@org_home_img", SqlDbType.VarChar,600),
					new SqlParameter("@jgzs", SqlDbType.VarChar,255),
					new SqlParameter("@mianji", SqlDbType.VarChar,255),
					new SqlParameter("@alias", SqlDbType.VarChar,255),
					new SqlParameter("@paixu", SqlDbType.Int,4),
					new SqlParameter("@dwdztc", SqlDbType.VarChar,255),
					new SqlParameter("@zztc", SqlDbType.VarChar,255),
					new SqlParameter("@discription", SqlDbType.VarChar,255),
					new SqlParameter("@fullydate", SqlDbType.VarChar,255),
					new SqlParameter("@org_code", SqlDbType.VarChar,100),
					new SqlParameter("@playday", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.org_name;
			parameters[1].Value = model.province;
			parameters[2].Value = model.city;
			parameters[3].Value = model.area;
			parameters[4].Value = model.adress;
			parameters[5].Value = model.org_intro;
			parameters[6].Value = model.evaluate;
			parameters[7].Value = model.del_flag;
			parameters[8].Value = model.level;
			parameters[9].Value = model.daily_check;
			parameters[10].Value = model.create_date;
			parameters[11].Value = model.orgIntro;
			parameters[12].Value = model.org_picture_list;
			parameters[13].Value = model.org_home_img;
			parameters[14].Value = model.jgzs;
			parameters[15].Value = model.mianji;
			parameters[16].Value = model.alias;
			parameters[17].Value = model.paixu;
			parameters[18].Value = model.dwdztc;
			parameters[19].Value = model.zztc;
			parameters[20].Value = model.discription;
			parameters[21].Value = model.fullydate;
			parameters[22].Value = model.org_code;
			parameters[23].Value = model.playday;
			parameters[24].Value = model.id;

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
			strSql.Append("delete from t_medical_org ");
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
			strSql.Append("delete from t_medical_org ");
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
		public LW_AskOnline.Model.t_medical_org GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,org_name,province,city,area,adress,org_intro,evaluate,del_flag,level,daily_check,create_date,orgIntro,org_picture_list,org_home_img,jgzs,mianji,alias,paixu,dwdztc,zztc,discription,fullydate,org_code,playday from t_medical_org ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			LW_AskOnline.Model.t_medical_org model=new LW_AskOnline.Model.t_medical_org();
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
		public LW_AskOnline.Model.t_medical_org DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.t_medical_org model=new LW_AskOnline.Model.t_medical_org();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["org_name"]!=null)
				{
					model.org_name=row["org_name"].ToString();
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
				if(row["adress"]!=null)
				{
					model.adress=row["adress"].ToString();
				}
				if(row["org_intro"]!=null)
				{
					model.org_intro=row["org_intro"].ToString();
				}
				if(row["evaluate"]!=null)
				{
					model.evaluate=row["evaluate"].ToString();
				}
				if(row["del_flag"]!=null)
				{
					model.del_flag=row["del_flag"].ToString();
				}
				if(row["level"]!=null)
				{
					model.level=row["level"].ToString();
				}
				if(row["daily_check"]!=null)
				{
					model.daily_check=row["daily_check"].ToString();
				}
				if(row["create_date"]!=null && row["create_date"].ToString()!="")
				{
					model.create_date=DateTime.Parse(row["create_date"].ToString());
				}
				if(row["orgIntro"]!=null)
				{
					model.orgIntro=row["orgIntro"].ToString();
				}
				if(row["org_picture_list"]!=null)
				{
					model.org_picture_list=row["org_picture_list"].ToString();
				}
				if(row["org_home_img"]!=null)
				{
					model.org_home_img=row["org_home_img"].ToString();
				}
				if(row["jgzs"]!=null)
				{
					model.jgzs=row["jgzs"].ToString();
				}
				if(row["mianji"]!=null)
				{
					model.mianji=row["mianji"].ToString();
				}
				if(row["alias"]!=null)
				{
					model.alias=row["alias"].ToString();
				}
				if(row["paixu"]!=null && row["paixu"].ToString()!="")
				{
					model.paixu=int.Parse(row["paixu"].ToString());
				}
				if(row["dwdztc"]!=null)
				{
					model.dwdztc=row["dwdztc"].ToString();
				}
				if(row["zztc"]!=null)
				{
					model.zztc=row["zztc"].ToString();
				}
				if(row["discription"]!=null)
				{
					model.discription=row["discription"].ToString();
				}
				if(row["fullydate"]!=null)
				{
					model.fullydate=row["fullydate"].ToString();
				}
				if(row["org_code"]!=null)
				{
					model.org_code=row["org_code"].ToString();
				}
				if(row["playday"]!=null)
				{
					model.playday=row["playday"].ToString();
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
			strSql.Append("select id,org_name,province,city,area,adress,org_intro,evaluate,del_flag,level,daily_check,create_date,orgIntro,org_picture_list,org_home_img,jgzs,mianji,alias,paixu,dwdztc,zztc,discription,fullydate,org_code,playday ");
			strSql.Append(" FROM t_medical_org ");
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
			strSql.Append(" id,org_name,province,city,area,adress,org_intro,evaluate,del_flag,level,daily_check,create_date,orgIntro,org_picture_list,org_home_img,jgzs,mianji,alias,paixu,dwdztc,zztc,discription,fullydate,org_code,playday ");
			strSql.Append(" FROM t_medical_org ");
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
			strSql.Append("select count(1) FROM t_medical_org ");
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
			strSql.Append(")AS Row, T.*  from t_medical_org T ");
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
			parameters[0].Value = "t_medical_org";
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

