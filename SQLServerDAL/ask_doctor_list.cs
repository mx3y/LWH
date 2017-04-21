using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LW_AskOnline.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace LW_AskOnline.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:ask_doctor_list
	/// </summary>
	public partial class ask_doctor_list:Iask_doctor_list
	{
		public ask_doctor_list()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("did", "ask_doctor_list"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int did)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ask_doctor_list");
			strSql.Append(" where did=@did");
			SqlParameter[] parameters = {
					new SqlParameter("@did", SqlDbType.Int,4)
			};
			parameters[0].Value = did;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LW_AskOnline.Model.ask_doctor_list model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ask_doctor_list(");
			strSql.Append("dname,dimage,ddept,ddeptid,dtype,dhospital,dcityid,dcity,dhospitalid,dprofessor,dcontent,dmonery,dtell,ddiscount,dshowregister,dsrealregister,dshowtell,dsrealtell,dshowvideo,dsrealvideo,dbankaccount,dbankaname,dbanktype,dqq,daccount,dpassword,dcreadate,dlastlogin,dsort,dishot,dstate)");
			strSql.Append(" values (");
			strSql.Append("@dname,@dimage,@ddept,@ddeptid,@dtype,@dhospital,@dcityid,@dcity,@dhospitalid,@dprofessor,@dcontent,@dmonery,@dtell,@ddiscount,@dshowregister,@dsrealregister,@dshowtell,@dsrealtell,@dshowvideo,@dsrealvideo,@dbankaccount,@dbankaname,@dbanktype,@dqq,@daccount,@dpassword,@dcreadate,@dlastlogin,@dsort,@dishot,@dstate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dname", SqlDbType.NVarChar,50),
					new SqlParameter("@dimage", SqlDbType.NVarChar,200),
					new SqlParameter("@ddept", SqlDbType.NVarChar,50),
					new SqlParameter("@ddeptid", SqlDbType.NVarChar,50),
					new SqlParameter("@dtype", SqlDbType.NVarChar,50),
					new SqlParameter("@dhospital", SqlDbType.NVarChar,50),
					new SqlParameter("@dcityid", SqlDbType.NVarChar,50),
					new SqlParameter("@dcity", SqlDbType.NVarChar,50),
					new SqlParameter("@dhospitalid", SqlDbType.Int,4),
					new SqlParameter("@dprofessor", SqlDbType.NVarChar,50),
					new SqlParameter("@dcontent", SqlDbType.NVarChar,1999),
					new SqlParameter("@dmonery", SqlDbType.Decimal,9),
					new SqlParameter("@dtell", SqlDbType.NVarChar,50),
					new SqlParameter("@ddiscount", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowregister", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealregister", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowtell", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealtell", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowvideo", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealvideo", SqlDbType.NVarChar,50),
					new SqlParameter("@dbankaccount", SqlDbType.NVarChar,50),
					new SqlParameter("@dbankaname", SqlDbType.NVarChar,50),
					new SqlParameter("@dbanktype", SqlDbType.NVarChar,50),
					new SqlParameter("@dqq", SqlDbType.NVarChar,50),
					new SqlParameter("@daccount", SqlDbType.NVarChar,50),
					new SqlParameter("@dpassword", SqlDbType.NVarChar,50),
					new SqlParameter("@dcreadate", SqlDbType.DateTime),
					new SqlParameter("@dlastlogin", SqlDbType.DateTime),
					new SqlParameter("@dsort", SqlDbType.Int,4),
					new SqlParameter("@dishot", SqlDbType.TinyInt,1),
					new SqlParameter("@dstate", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.dname;
			parameters[1].Value = model.dimage;
			parameters[2].Value = model.ddept;
			parameters[3].Value = model.ddeptid;
			parameters[4].Value = model.dtype;
			parameters[5].Value = model.dhospital;
			parameters[6].Value = model.dcityid;
			parameters[7].Value = model.dcity;
			parameters[8].Value = model.dhospitalid;
			parameters[9].Value = model.dprofessor;
			parameters[10].Value = model.dcontent;
			parameters[11].Value = model.dmonery;
			parameters[12].Value = model.dtell;
			parameters[13].Value = model.ddiscount;
			parameters[14].Value = model.dshowregister;
			parameters[15].Value = model.dsrealregister;
			parameters[16].Value = model.dshowtell;
			parameters[17].Value = model.dsrealtell;
			parameters[18].Value = model.dshowvideo;
			parameters[19].Value = model.dsrealvideo;
			parameters[20].Value = model.dbankaccount;
			parameters[21].Value = model.dbankaname;
			parameters[22].Value = model.dbanktype;
			parameters[23].Value = model.dqq;
			parameters[24].Value = model.daccount;
			parameters[25].Value = model.dpassword;
			parameters[26].Value = model.dcreadate;
			parameters[27].Value = model.dlastlogin;
			parameters[28].Value = model.dsort;
			parameters[29].Value = model.dishot;
			parameters[30].Value = model.dstate;

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
		public bool Update(LW_AskOnline.Model.ask_doctor_list model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ask_doctor_list set ");
			strSql.Append("dname=@dname,");
			strSql.Append("dimage=@dimage,");
			strSql.Append("ddept=@ddept,");
			strSql.Append("ddeptid=@ddeptid,");
			strSql.Append("dtype=@dtype,");
			strSql.Append("dhospital=@dhospital,");
			strSql.Append("dcityid=@dcityid,");
			strSql.Append("dcity=@dcity,");
			strSql.Append("dhospitalid=@dhospitalid,");
			strSql.Append("dprofessor=@dprofessor,");
			strSql.Append("dcontent=@dcontent,");
			strSql.Append("dmonery=@dmonery,");
			strSql.Append("dtell=@dtell,");
			strSql.Append("ddiscount=@ddiscount,");
			strSql.Append("dshowregister=@dshowregister,");
			strSql.Append("dsrealregister=@dsrealregister,");
			strSql.Append("dshowtell=@dshowtell,");
			strSql.Append("dsrealtell=@dsrealtell,");
			strSql.Append("dshowvideo=@dshowvideo,");
			strSql.Append("dsrealvideo=@dsrealvideo,");
			strSql.Append("dbankaccount=@dbankaccount,");
			strSql.Append("dbankaname=@dbankaname,");
			strSql.Append("dbanktype=@dbanktype,");
			strSql.Append("dqq=@dqq,");
			strSql.Append("daccount=@daccount,");
			strSql.Append("dpassword=@dpassword,");
			strSql.Append("dcreadate=@dcreadate,");
			strSql.Append("dlastlogin=@dlastlogin,");
			strSql.Append("dsort=@dsort,");
			strSql.Append("dishot=@dishot,");
			strSql.Append("dstate=@dstate");
			strSql.Append(" where did=@did");
			SqlParameter[] parameters = {
					new SqlParameter("@dname", SqlDbType.NVarChar,50),
					new SqlParameter("@dimage", SqlDbType.NVarChar,200),
					new SqlParameter("@ddept", SqlDbType.NVarChar,50),
					new SqlParameter("@ddeptid", SqlDbType.NVarChar,50),
					new SqlParameter("@dtype", SqlDbType.NVarChar,50),
					new SqlParameter("@dhospital", SqlDbType.NVarChar,50),
					new SqlParameter("@dcityid", SqlDbType.NVarChar,50),
					new SqlParameter("@dcity", SqlDbType.NVarChar,50),
					new SqlParameter("@dhospitalid", SqlDbType.Int,4),
					new SqlParameter("@dprofessor", SqlDbType.NVarChar,50),
					new SqlParameter("@dcontent", SqlDbType.NVarChar,1999),
					new SqlParameter("@dmonery", SqlDbType.Decimal,9),
					new SqlParameter("@dtell", SqlDbType.NVarChar,50),
					new SqlParameter("@ddiscount", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowregister", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealregister", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowtell", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealtell", SqlDbType.NVarChar,50),
					new SqlParameter("@dshowvideo", SqlDbType.NVarChar,50),
					new SqlParameter("@dsrealvideo", SqlDbType.NVarChar,50),
					new SqlParameter("@dbankaccount", SqlDbType.NVarChar,50),
					new SqlParameter("@dbankaname", SqlDbType.NVarChar,50),
					new SqlParameter("@dbanktype", SqlDbType.NVarChar,50),
					new SqlParameter("@dqq", SqlDbType.NVarChar,50),
					new SqlParameter("@daccount", SqlDbType.NVarChar,50),
					new SqlParameter("@dpassword", SqlDbType.NVarChar,50),
					new SqlParameter("@dcreadate", SqlDbType.DateTime),
					new SqlParameter("@dlastlogin", SqlDbType.DateTime),
					new SqlParameter("@dsort", SqlDbType.Int,4),
					new SqlParameter("@dishot", SqlDbType.TinyInt,1),
					new SqlParameter("@dstate", SqlDbType.TinyInt,1),
					new SqlParameter("@did", SqlDbType.Int,4)};
			parameters[0].Value = model.dname;
			parameters[1].Value = model.dimage;
			parameters[2].Value = model.ddept;
			parameters[3].Value = model.ddeptid;
			parameters[4].Value = model.dtype;
			parameters[5].Value = model.dhospital;
			parameters[6].Value = model.dcityid;
			parameters[7].Value = model.dcity;
			parameters[8].Value = model.dhospitalid;
			parameters[9].Value = model.dprofessor;
			parameters[10].Value = model.dcontent;
			parameters[11].Value = model.dmonery;
			parameters[12].Value = model.dtell;
			parameters[13].Value = model.ddiscount;
			parameters[14].Value = model.dshowregister;
			parameters[15].Value = model.dsrealregister;
			parameters[16].Value = model.dshowtell;
			parameters[17].Value = model.dsrealtell;
			parameters[18].Value = model.dshowvideo;
			parameters[19].Value = model.dsrealvideo;
			parameters[20].Value = model.dbankaccount;
			parameters[21].Value = model.dbankaname;
			parameters[22].Value = model.dbanktype;
			parameters[23].Value = model.dqq;
			parameters[24].Value = model.daccount;
			parameters[25].Value = model.dpassword;
			parameters[26].Value = model.dcreadate;
			parameters[27].Value = model.dlastlogin;
			parameters[28].Value = model.dsort;
			parameters[29].Value = model.dishot;
			parameters[30].Value = model.dstate;
			parameters[31].Value = model.did;

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
		public bool Delete(int did)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_doctor_list ");
			strSql.Append(" where did=@did");
			SqlParameter[] parameters = {
					new SqlParameter("@did", SqlDbType.Int,4)
			};
			parameters[0].Value = did;

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
		public bool DeleteList(string didlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ask_doctor_list ");
			strSql.Append(" where did in ("+didlist + ")  ");
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
		public LW_AskOnline.Model.ask_doctor_list GetModel(int did)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 did,dname,dimage,ddept,ddeptid,dtype,dhospital,dcityid,dcity,dhospitalid,dprofessor,dcontent,dmonery,dtell,ddiscount,dshowregister,dsrealregister,dshowtell,dsrealtell,dshowvideo,dsrealvideo,dbankaccount,dbankaname,dbanktype,dqq,daccount,dpassword,dcreadate,dlastlogin,dsort,dishot,dstate from ask_doctor_list ");
			strSql.Append(" where did=@did");
			SqlParameter[] parameters = {
					new SqlParameter("@did", SqlDbType.Int,4)
			};
			parameters[0].Value = did;

			LW_AskOnline.Model.ask_doctor_list model=new LW_AskOnline.Model.ask_doctor_list();
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
		public LW_AskOnline.Model.ask_doctor_list DataRowToModel(DataRow row)
		{
			LW_AskOnline.Model.ask_doctor_list model=new LW_AskOnline.Model.ask_doctor_list();
			if (row != null)
			{
				if(row["did"]!=null && row["did"].ToString()!="")
				{
					model.did=int.Parse(row["did"].ToString());
				}
				if(row["dname"]!=null)
				{
					model.dname=row["dname"].ToString();
				}
				if(row["dimage"]!=null)
				{
					model.dimage=row["dimage"].ToString();
				}
				if(row["ddept"]!=null)
				{
					model.ddept=row["ddept"].ToString();
				}
				if(row["ddeptid"]!=null)
				{
					model.ddeptid=row["ddeptid"].ToString();
				}
				if(row["dtype"]!=null)
				{
					model.dtype=row["dtype"].ToString();
				}
				if(row["dhospital"]!=null)
				{
					model.dhospital=row["dhospital"].ToString();
				}
				if(row["dcityid"]!=null)
				{
					model.dcityid=row["dcityid"].ToString();
				}
				if(row["dcity"]!=null)
				{
					model.dcity=row["dcity"].ToString();
				}
				if(row["dhospitalid"]!=null && row["dhospitalid"].ToString()!="")
				{
					model.dhospitalid=int.Parse(row["dhospitalid"].ToString());
				}
				if(row["dprofessor"]!=null)
				{
					model.dprofessor=row["dprofessor"].ToString();
				}
				if(row["dcontent"]!=null)
				{
					model.dcontent=row["dcontent"].ToString();
				}
				if(row["dmonery"]!=null && row["dmonery"].ToString()!="")
				{
					model.dmonery=decimal.Parse(row["dmonery"].ToString());
				}
				if(row["dtell"]!=null)
				{
					model.dtell=row["dtell"].ToString();
				}
				if(row["ddiscount"]!=null)
				{
					model.ddiscount=row["ddiscount"].ToString();
				}
				if(row["dshowregister"]!=null)
				{
					model.dshowregister=row["dshowregister"].ToString();
				}
				if(row["dsrealregister"]!=null)
				{
					model.dsrealregister=row["dsrealregister"].ToString();
				}
				if(row["dshowtell"]!=null)
				{
					model.dshowtell=row["dshowtell"].ToString();
				}
				if(row["dsrealtell"]!=null)
				{
					model.dsrealtell=row["dsrealtell"].ToString();
				}
				if(row["dshowvideo"]!=null)
				{
					model.dshowvideo=row["dshowvideo"].ToString();
				}
				if(row["dsrealvideo"]!=null)
				{
					model.dsrealvideo=row["dsrealvideo"].ToString();
				}
				if(row["dbankaccount"]!=null)
				{
					model.dbankaccount=row["dbankaccount"].ToString();
				}
				if(row["dbankaname"]!=null)
				{
					model.dbankaname=row["dbankaname"].ToString();
				}
				if(row["dbanktype"]!=null)
				{
					model.dbanktype=row["dbanktype"].ToString();
				}
				if(row["dqq"]!=null)
				{
					model.dqq=row["dqq"].ToString();
				}
				if(row["daccount"]!=null)
				{
					model.daccount=row["daccount"].ToString();
				}
				if(row["dpassword"]!=null)
				{
					model.dpassword=row["dpassword"].ToString();
				}
				if(row["dcreadate"]!=null && row["dcreadate"].ToString()!="")
				{
					model.dcreadate=DateTime.Parse(row["dcreadate"].ToString());
				}
				if(row["dlastlogin"]!=null && row["dlastlogin"].ToString()!="")
				{
					model.dlastlogin=DateTime.Parse(row["dlastlogin"].ToString());
				}
				if(row["dsort"]!=null && row["dsort"].ToString()!="")
				{
					model.dsort=int.Parse(row["dsort"].ToString());
				}
				if(row["dishot"]!=null && row["dishot"].ToString()!="")
				{
					model.dishot=int.Parse(row["dishot"].ToString());
				}
				if(row["dstate"]!=null && row["dstate"].ToString()!="")
				{
					model.dstate=int.Parse(row["dstate"].ToString());
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
			strSql.Append("select did,dname,dimage,ddept,ddeptid,dtype,dhospital,dcityid,dcity,dhospitalid,dprofessor,dcontent,dmonery,dtell,ddiscount,dshowregister,dsrealregister,dshowtell,dsrealtell,dshowvideo,dsrealvideo,dbankaccount,dbankaname,dbanktype,dqq,daccount,dpassword,dcreadate,dlastlogin,dsort,dishot,dstate ");
			strSql.Append(" FROM ask_doctor_list ");
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
			strSql.Append(" did,dname,dimage,ddept,ddeptid,dtype,dhospital,dcityid,dcity,dhospitalid,dprofessor,dcontent,dmonery,dtell,ddiscount,dshowregister,dsrealregister,dshowtell,dsrealtell,dshowvideo,dsrealvideo,dbankaccount,dbankaname,dbanktype,dqq,daccount,dpassword,dcreadate,dlastlogin,dsort,dishot,dstate ");
			strSql.Append(" FROM ask_doctor_list ");
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
			strSql.Append("select count(1) FROM ask_doctor_list ");
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
				strSql.Append("order by T.did desc");
			}
			strSql.Append(")AS Row, T.*  from ask_doctor_list T ");
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
			parameters[0].Value = "ask_doctor_list";
			parameters[1].Value = "did";
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

