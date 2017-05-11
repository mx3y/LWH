drop table ask_doctor_list
create table ask_doctor_list
(
	did int primary key identity(1,1) not null, --医生列表标识列
	dname nvarchar(50) not null,                --医生名称
	dimage nvarchar(200) not null,				--医生头像
	ddept nvarchar(50) not null,				--医生科室
	ddeptid nvarchar(50) not null,				--医生科室编号 
	dtype nvarchar(50) not null,				--医生类型 0六维 1三甲名医
	dhospital nvarchar(50) not null,			--医生所属医院 留空
	dcityid nvarchar(50) not null,				--医生所属城市编号
	dcity nvarchar(50) not null,				--医生所属城市
	dhospitalid int not null,					--医生所属医院编号
	dprofessor nvarchar(50) not null,			--职称
	dcontent nvarchar(1999) not null,			--描述
	dmonery decimal not null,					--余额
	dtell nvarchar(50) not null,				--医生手机号码
	ddiscount nvarchar(50) not null,			--医生对账折扣，0表示无折扣
	
	dshowregister nvarchar(50) not null,		--医生代挂号显示价格
	dsrealregister nvarchar(50) not null,		--医生代挂号真实价格
	
	dshowtell nvarchar(50) not null,			--医生电话咨询显示价格
	dsrealtell nvarchar(50) not null,			--医生电话咨询真实价格
	
	dshowvideo nvarchar(50) not null,			--医生视频咨询显示价格
	dsrealvideo nvarchar(50) not null,			--医生视频咨询真实价格
	
	dbankaccount nvarchar(50) not null,			--医生银行帐号
	dbankaname   nvarchar(50) not null,			--医生银行姓名
	dbanktype	 nvarchar(50) not null,			--医生开户行
	dqq			 nvarchar(50) not null,			--医生QQ，用于视频咨询
	
	
	daccount nvarchar(50) not null,				--医生登录帐号
	dpassword nvarchar(50) not null,			--医生登录密码
	
	dcreadate datetime not null,
	dlastlogin datetime not null,
	dsort int not null,							--医生排序
	dishot tinyint not null,					--是否置顶 0不置顶 ,1置顶
	dstate tinyint not null	,					--0禁用 1启动
	
	--add
	d_onlinedate nvarchar(50) not null,			--医生上班时间，例如周一、周二、周三，则写1,2,3。该字段适用于六维医生
	d_message    nvarchar(500) null,			--医生长描述，显示在医生个人信息页
	d_count		 int null,						--医生接诊次数
	d_score      nvarchar(50) null,				--医生评分总
	d_professionscore nvarchar(50) null,		--医生专业水平评分
	d_professioncount nvarchar(50) null,		--医生专业水平评分次数
	d_servicesscore nvarchar(50) null,			--医生服务态度评分
	d_servicescount nvarchar(50) null,			--医生服务态度评分次数
	d_replyscore nvarchar(50) null,				--医生回复速度评分
	d_replycount nvarchar(50) null			--医生回复速度评分次数
	
)


drop table ask_msg_check
create table ask_msg_check
(
	mid int primary key identity(1,1) not null,		--标识列
	mmobile int not null,							--验证码手机号码
	mcheckcode int not null,						--验证码
	mip nvarchar(50) not null,						--发送验证码请求的IP
	mcreatedate datetime not null,					--发送验证码的时间
	mexpirat int  default(90) not null,		--验证码有效期 单位为秒
	misuse tinyint not null,						--是否使用 0未使用 1使用
	musingat datetime not null,						--使用验证码的时间
	mtype	nvarchar(200)							--验证码类型
)
drop table  ask_city
create table ask_city
(
	cid nvarchar(50) primary key  not null,		--标识列
	cparent_id nvarchar(50) not null,						--父级编号，如果是顶层则为0
	cregion_grade nvarchar(50) not null,						--省市区县属于哪一级 1省2市3县或区
	cregion_name nvarchar(50) not null,				--城市名称
	cdistrict_code  nvarchar(50)  null,			--邮政编码
	carea_code  nvarchar(50)  null,				--区号
	cstatus tinyint  null						--状态，默认为1有效，0为无效
)
drop table  ask_hospital
create table ask_hospital
(
	hid int primary key identity(1,1) not null,		--标识列
	hcityid int not null,							--所属城市编号
	hcity nvarchar(50) not null,					--所属城市
	hname nvarchar(50) not null,					--医院名称
	himage nvarchar(200) not null,					--医院图像
	hlevel nvarchar(50) not null,					--医院级别
	haddress  nvarchar(50) not null,				--医院地址
	hcontent  nvarchar(50) not null,				--医院介绍
	hstatus tinyint not null						--状态，默认为1有效，0为无效
)
drop table  ask_user
create table ask_user
(
	uuid int primary key identity(1,1) not null,		--标识列
	utijtid int not null,								--是否是体检通用户，0不是，如果是则自动对应体检通的UID编号
	ucompanymonery decimal not null,					--额度中获取，如果不是体检通用户，则该字段值为0
	umonery decimal not null,							--用户充值的金额
	uaccount nvarchar(50) not null,						--用户帐号，默认手机号码
	upassword nvarchar(200) not null,					--用户密码
	ucardnumber nvarchar(50) not null,					--用户身份证号码
	uopenid		nvarchar(200) not null,					--用户微信标识
	umail		nvarchar(200) not null,					--用户邮箱
	ubrithday	datetime      not null,					--用户出生日期
	usex		nvarchar(20) not null,					--性别
	ucompanyid	int not null,							--用户公司编号
	uregisterdatetime datetime	not null,				--用户注册时间
	uregisterip			nvarchar(20) not null,			--用户注册IP
	ulastdatetime	datetime	not null,				--用户最后登录时间
	ulastip				nvarchar(20) not null,			--用户最后登录IP
	ustate	tinyint			not null,					--用户使用状态 0禁用 1启用
	--add
	uname		 nvarchar(50) not null,					--用户姓名
)
drop table  ask_order
create table ask_order
(
	oid  int primary key identity(1,1) not null,		--标识列
	ouid int not null,									--用户编号
	odid int not null,									--请求医生
	otype int not null,									--请求类型 0预约挂号请求 1电话视频请求 2视频请求
	oresult tinyint not null,							--订单预约状态，默认为0，如果客服没手动改为1，则24小时后自动退费
	ostate tinyint not null,							--订单交易于状态，默认为0，如果状态一直为0，则客服手动退费
	ocreatetime datetime not null,						--订单创建日期
	ocommittime	datetime not null,						--订单执行日期
	opublicmonery decimal not null,						--公司额度付款的部分，如果个人用户该字段为0
	oprivatemonery decimal not null,					--个人自费部分付款的部分
	ototalmonery decimal not null,						--订单总额
	otransid int not null,								--微信支付编号，如果用户微信支付则该编号为0
	ocallresult nvarchar(50) not null,					--云之讯通信结果
	ocallid		nvarchar(50) not null,					--云之讯通信ID
	ocalldate	nvarchar(50) not null,					--云之讯通信创建日期
	--add
	oillid	int null,									--就诊人编号 如果非代理挂号，则为0
	oillimg nvarchar(500) null,							--电话咨询时附带的图片，多图用,来分割
	oillcontent nvarchar(500) null						--电话咨询时附带的描述
	
)


drop table  ask_order_pay
create table ask_order_pay
(
	pid	  int primary key identity(1,1) not null,		--标识列
	oid	int not null,									--订单编号
	uuid int not null,									--用户编号
	porder nvarchar(50) not null,						--商户单号
	pwxorder  nvarchar(50) not null,					--微信单号
	pmonery		decimal		not null,					--交易金额
	pcreatetime datetime not null,						--创建支付订单日期
	povertime datetime not null,						--完成支付订单日期
	popenid	nvarchar(200) not null,						--支付微信帐号ID
	pstatus	int			not null,						--支付完成状态 0未完成 1已完成
)




drop table  ask_ucpaas
create table ask_ucpaas
(
	ucid int primary key identity(1,1) not null,
	oid				int not null,		--如果是电话预约则为0
	ucevent			nvarchar(2000),		--回调类型，值为：callhangup
	uccallid			nvarchar(2000),		--呼叫的唯一标识（沿用原来机制，由sdk组件生成）
	ucaccountid		nvarchar(2000),		--开发者账号id
	ucappid			nvarchar(2000),		--应用id
	uccalltype		nvarchar(2000),		--呼叫类型1免费2收费
	uclengthA			nvarchar(2000),		--主叫时长
	uccallerdisnum	nvarchar(2000),		--主叫显示号码
	uccalleedisnum	nvarchar(2000),		--被叫显示号码
	uccallertype		nvarchar(2000),		--主叫号码类型，0：Client账号，1：普通电话，2：userid
	uccallernum		nvarchar(2000),		--主叫绑定的手机号码
	uccaller			nvarchar(2000),		--主叫号码 普通电话：18612345678 Client号码：60000000000017
	uccalledtype		nvarchar(2000),		--被叫号码类型，0：Client账号，1：普通电话，2：userid
	uccalled			nvarchar(2000),		----被叫号码 普通电话：18612345678 Client号码：60000000000017
	uclength			nvarchar(2000),		--通话时长，被叫通话时长
	uccalltime		nvarchar(2000),		--发起呼叫的时间
	ucstarttime		nvarchar(2000),		--开始通话时间。时间格式如：2014-06-16 16:47:28
	ucstoptime		nvarchar(2000),		--结束通话时间。时间格式如：2014-06-16 17:31:14
	ucreason			nvarchar(2000),		--挂机原因描述，0：正常挂断；1：余额不足；2：媒体超时；3：无法接通；4：拒接； 5：超时未接；6：拒接或超时未接；7：平台服务器网络错误；8：用户请求取消通话；9：第三方鉴权错误；255：其他原因。
	ucsubreason		nvarchar(2000),		--挂机原因补充描述，1：主叫挂断；2：被叫挂断；目前当reason=0时有效
)

drop table ask_test_bill
create table ask_test_bill
(
	tid  int primary key identity(1,1) not null,
	tvalue nvarchar(2000) not null,
	tdate nvarchar(2000) not null,
)


--表描述
EXECUTE sp_addextendedproperty N'MS_Description', N'表描述',N'SCHEMA', N'dbo', N'table', N'ask_doctor_list'

--列描述
EXECUTE sp_addextendedproperty N'MS_Description', N'列描述',N'SCHEMA', N'dbo', N'table', N'doctor_list',N'COLUMN',N'did'



--科室表
CREATE TABLE ask_dept
(
	did [int] primary key  IDENTITY(1,1) NOT NULL,	--标识列
	dname [nvarchar](50) NULL,						--科室名称
	dhid	int not null,							--科室所属医院id 
	dparentid int not null,							--父类科室编号，例如内科是1，呼吸内科的父类编号则为1
	dcontent nvarchar(500) null,					--科室描述 备用字段
	dstate   tinyint not null						--科室启用状态 0未启用 1启用
)

--客服帐号表
CREATE TABLE ask_master
(
	mid [int] primary key  IDENTITY(1,1) NOT NULL,	--标识列
	mnumber [nvarchar](50) NULL,					--帐号
	mpassword [nvarchar](50) NULL,					--密码
	mPurview [nvarchar](500) NULL,					--权限 例如0,1,2,3
	memail [nvarchar](50) NULL,						--邮箱
	mtell [nvarchar](50) NULL,						--手机号码
	mregdate [datetime] NULL,						--注册日期
	mname	nvarchar(20) null,						--姓名
	msex	nvarchar(10) null,						--性别
	maddress nvarchar(200) null,					--所属门店 例如深圳红树湾、深圳招商美伦、深圳本部
	mlastlogintime [datetime] NULL,					--最后登录日期
	mlastip [nvarchar](200) NULL,					--最后登录IP
	mstate [tinyint] NULL,							--最后登录状态
	mlogincount [int] NULL,							--登录次数
	mremark [nvarchar](200) NULL					--备注信息
)
--就诊人资料表
create table ask_illpersion
(
	iid [int] primary key  IDENTITY(1,1) NOT NULL,	--标识列
	uid	int not null,								--就诊人所属帐号
	iname [nvarchar](200) NULL	,					--就诊人姓名
	iphone [nvarchar](200) NULL	,					--就诊人手机号码
	icardtype [nvarchar](200) NULL	,				--就诊人证件类型
	icard [nvarchar](200) NULL	,					--就诊人证件号码
	isex [nvarchar](200) NULL	,					--就诊人性别
	ibirthday datetime NULL		,					--就诊人生日
	iaddress [nvarchar](200) NULL					--就诊人地址
)

--订单评价表
create table ask_order_reply
(
	orid [int] primary key  IDENTITY(1,1) NOT NULL,	--标识列
	oid int not null,								--订单编号
	did int not null,								--医生编号
	uuid int not null,								--用户编号
	orcontent  [nvarchar](200) NULL,				--评论内容
	ordate  datetime NULL,							--评论日期
	orstate tinyint null							--是否显示评论 0不显示 1显示
)
--更改记录：

--新增ask_master客服表
--新增ask_dept科室表
--新增ask_illpersion就诊人资料表
--新增ask_order_reply订单评价表
--ask_user用户表增加字段
--ask_doctor_list医生表增加字段
--ask_order订单表新增字段
--ask_city城市表更改字段类型



select * from ask_doctor_list
select * from ask_order
select * from t_company where id=

ask_doctor_list did

ask_doctor_date
DATEID did date time_tag
1       1   2015-5-5 001,002,004,005,006
2        1   2015-5-6 001,002,004,005,006
3        1   2015-5-7 001,002,004,005,006
4       1    2015-5-7 001,002,004,005,006

insert
update set time_tag where dateid=





