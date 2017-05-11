drop table ask_doctor_list
create table ask_doctor_list
(
	did int primary key identity(1,1) not null, --ҽ���б��ʶ��
	dname nvarchar(50) not null,                --ҽ������
	dimage nvarchar(200) not null,				--ҽ��ͷ��
	ddept nvarchar(50) not null,				--ҽ������
	ddeptid nvarchar(50) not null,				--ҽ�����ұ�� 
	dtype nvarchar(50) not null,				--ҽ������ 0��ά 1������ҽ
	dhospital nvarchar(50) not null,			--ҽ������ҽԺ ����
	dcityid nvarchar(50) not null,				--ҽ���������б��
	dcity nvarchar(50) not null,				--ҽ����������
	dhospitalid int not null,					--ҽ������ҽԺ���
	dprofessor nvarchar(50) not null,			--ְ��
	dcontent nvarchar(1999) not null,			--����
	dmonery decimal not null,					--���
	dtell nvarchar(50) not null,				--ҽ���ֻ�����
	ddiscount nvarchar(50) not null,			--ҽ�������ۿۣ�0��ʾ���ۿ�
	
	dshowregister nvarchar(50) not null,		--ҽ�����Һ���ʾ�۸�
	dsrealregister nvarchar(50) not null,		--ҽ�����Һ���ʵ�۸�
	
	dshowtell nvarchar(50) not null,			--ҽ���绰��ѯ��ʾ�۸�
	dsrealtell nvarchar(50) not null,			--ҽ���绰��ѯ��ʵ�۸�
	
	dshowvideo nvarchar(50) not null,			--ҽ����Ƶ��ѯ��ʾ�۸�
	dsrealvideo nvarchar(50) not null,			--ҽ����Ƶ��ѯ��ʵ�۸�
	
	dbankaccount nvarchar(50) not null,			--ҽ�������ʺ�
	dbankaname   nvarchar(50) not null,			--ҽ����������
	dbanktype	 nvarchar(50) not null,			--ҽ��������
	dqq			 nvarchar(50) not null,			--ҽ��QQ��������Ƶ��ѯ
	
	
	daccount nvarchar(50) not null,				--ҽ����¼�ʺ�
	dpassword nvarchar(50) not null,			--ҽ����¼����
	
	dcreadate datetime not null,
	dlastlogin datetime not null,
	dsort int not null,							--ҽ������
	dishot tinyint not null,					--�Ƿ��ö� 0���ö� ,1�ö�
	dstate tinyint not null	,					--0���� 1����
	
	--add
	d_onlinedate nvarchar(50) not null,			--ҽ���ϰ�ʱ�䣬������һ���ܶ�����������д1,2,3�����ֶ���������άҽ��
	d_message    nvarchar(500) null,			--ҽ������������ʾ��ҽ��������Ϣҳ
	d_count		 int null,						--ҽ���������
	d_score      nvarchar(50) null,				--ҽ��������
	d_professionscore nvarchar(50) null,		--ҽ��רҵˮƽ����
	d_professioncount nvarchar(50) null,		--ҽ��רҵˮƽ���ִ���
	d_servicesscore nvarchar(50) null,			--ҽ������̬������
	d_servicescount nvarchar(50) null,			--ҽ������̬�����ִ���
	d_replyscore nvarchar(50) null,				--ҽ���ظ��ٶ�����
	d_replycount nvarchar(50) null			--ҽ���ظ��ٶ����ִ���
	
)


drop table ask_msg_check
create table ask_msg_check
(
	mid int primary key identity(1,1) not null,		--��ʶ��
	mmobile int not null,							--��֤���ֻ�����
	mcheckcode int not null,						--��֤��
	mip nvarchar(50) not null,						--������֤�������IP
	mcreatedate datetime not null,					--������֤���ʱ��
	mexpirat int  default(90) not null,		--��֤����Ч�� ��λΪ��
	misuse tinyint not null,						--�Ƿ�ʹ�� 0δʹ�� 1ʹ��
	musingat datetime not null,						--ʹ����֤���ʱ��
	mtype	nvarchar(200)							--��֤������
)
drop table  ask_city
create table ask_city
(
	cid nvarchar(50) primary key  not null,		--��ʶ��
	cparent_id nvarchar(50) not null,						--������ţ�����Ƕ�����Ϊ0
	cregion_grade nvarchar(50) not null,						--ʡ������������һ�� 1ʡ2��3�ػ���
	cregion_name nvarchar(50) not null,				--��������
	cdistrict_code  nvarchar(50)  null,			--��������
	carea_code  nvarchar(50)  null,				--����
	cstatus tinyint  null						--״̬��Ĭ��Ϊ1��Ч��0Ϊ��Ч
)
drop table  ask_hospital
create table ask_hospital
(
	hid int primary key identity(1,1) not null,		--��ʶ��
	hcityid int not null,							--�������б��
	hcity nvarchar(50) not null,					--��������
	hname nvarchar(50) not null,					--ҽԺ����
	himage nvarchar(200) not null,					--ҽԺͼ��
	hlevel nvarchar(50) not null,					--ҽԺ����
	haddress  nvarchar(50) not null,				--ҽԺ��ַ
	hcontent  nvarchar(50) not null,				--ҽԺ����
	hstatus tinyint not null						--״̬��Ĭ��Ϊ1��Ч��0Ϊ��Ч
)
drop table  ask_user
create table ask_user
(
	uuid int primary key identity(1,1) not null,		--��ʶ��
	utijtid int not null,								--�Ƿ������ͨ�û���0���ǣ���������Զ���Ӧ���ͨ��UID���
	ucompanymonery decimal not null,					--����л�ȡ������������ͨ�û�������ֶ�ֵΪ0
	umonery decimal not null,							--�û���ֵ�Ľ��
	uaccount nvarchar(50) not null,						--�û��ʺţ�Ĭ���ֻ�����
	upassword nvarchar(200) not null,					--�û�����
	ucardnumber nvarchar(50) not null,					--�û����֤����
	uopenid		nvarchar(200) not null,					--�û�΢�ű�ʶ
	umail		nvarchar(200) not null,					--�û�����
	ubrithday	datetime      not null,					--�û���������
	usex		nvarchar(20) not null,					--�Ա�
	ucompanyid	int not null,							--�û���˾���
	uregisterdatetime datetime	not null,				--�û�ע��ʱ��
	uregisterip			nvarchar(20) not null,			--�û�ע��IP
	ulastdatetime	datetime	not null,				--�û�����¼ʱ��
	ulastip				nvarchar(20) not null,			--�û�����¼IP
	ustate	tinyint			not null,					--�û�ʹ��״̬ 0���� 1����
	--add
	uname		 nvarchar(50) not null,					--�û�����
)
drop table  ask_order
create table ask_order
(
	oid  int primary key identity(1,1) not null,		--��ʶ��
	ouid int not null,									--�û����
	odid int not null,									--����ҽ��
	otype int not null,									--�������� 0ԤԼ�Һ����� 1�绰��Ƶ���� 2��Ƶ����
	oresult tinyint not null,							--����ԤԼ״̬��Ĭ��Ϊ0������ͷ�û�ֶ���Ϊ1����24Сʱ���Զ��˷�
	ostate tinyint not null,							--����������״̬��Ĭ��Ϊ0�����״̬һֱΪ0����ͷ��ֶ��˷�
	ocreatetime datetime not null,						--������������
	ocommittime	datetime not null,						--����ִ������
	opublicmonery decimal not null,						--��˾��ȸ���Ĳ��֣���������û����ֶ�Ϊ0
	oprivatemonery decimal not null,					--�����ԷѲ��ָ���Ĳ���
	ototalmonery decimal not null,						--�����ܶ�
	otransid int not null,								--΢��֧����ţ�����û�΢��֧����ñ��Ϊ0
	ocallresult nvarchar(50) not null,					--��֮Ѷͨ�Ž��
	ocallid		nvarchar(50) not null,					--��֮Ѷͨ��ID
	ocalldate	nvarchar(50) not null,					--��֮Ѷͨ�Ŵ�������
	--add
	oillid	int null,									--�����˱�� ����Ǵ���Һţ���Ϊ0
	oillimg nvarchar(500) null,							--�绰��ѯʱ������ͼƬ����ͼ��,���ָ�
	oillcontent nvarchar(500) null						--�绰��ѯʱ����������
	
)


drop table  ask_order_pay
create table ask_order_pay
(
	pid	  int primary key identity(1,1) not null,		--��ʶ��
	oid	int not null,									--�������
	uuid int not null,									--�û����
	porder nvarchar(50) not null,						--�̻�����
	pwxorder  nvarchar(50) not null,					--΢�ŵ���
	pmonery		decimal		not null,					--���׽��
	pcreatetime datetime not null,						--����֧����������
	povertime datetime not null,						--���֧����������
	popenid	nvarchar(200) not null,						--֧��΢���ʺ�ID
	pstatus	int			not null,						--֧�����״̬ 0δ��� 1�����
)




drop table  ask_ucpaas
create table ask_ucpaas
(
	ucid int primary key identity(1,1) not null,
	oid				int not null,		--����ǵ绰ԤԼ��Ϊ0
	ucevent			nvarchar(2000),		--�ص����ͣ�ֵΪ��callhangup
	uccallid			nvarchar(2000),		--���е�Ψһ��ʶ������ԭ�����ƣ���sdk������ɣ�
	ucaccountid		nvarchar(2000),		--�������˺�id
	ucappid			nvarchar(2000),		--Ӧ��id
	uccalltype		nvarchar(2000),		--��������1���2�շ�
	uclengthA			nvarchar(2000),		--����ʱ��
	uccallerdisnum	nvarchar(2000),		--������ʾ����
	uccalleedisnum	nvarchar(2000),		--������ʾ����
	uccallertype		nvarchar(2000),		--���к������ͣ�0��Client�˺ţ�1����ͨ�绰��2��userid
	uccallernum		nvarchar(2000),		--���а󶨵��ֻ�����
	uccaller			nvarchar(2000),		--���к��� ��ͨ�绰��18612345678 Client���룺60000000000017
	uccalledtype		nvarchar(2000),		--���к������ͣ�0��Client�˺ţ�1����ͨ�绰��2��userid
	uccalled			nvarchar(2000),		----���к��� ��ͨ�绰��18612345678 Client���룺60000000000017
	uclength			nvarchar(2000),		--ͨ��ʱ��������ͨ��ʱ��
	uccalltime		nvarchar(2000),		--������е�ʱ��
	ucstarttime		nvarchar(2000),		--��ʼͨ��ʱ�䡣ʱ���ʽ�磺2014-06-16 16:47:28
	ucstoptime		nvarchar(2000),		--����ͨ��ʱ�䡣ʱ���ʽ�磺2014-06-16 17:31:14
	ucreason			nvarchar(2000),		--�һ�ԭ��������0�������Ҷϣ�1�����㣻2��ý�峬ʱ��3���޷���ͨ��4���ܽӣ� 5����ʱδ�ӣ�6���ܽӻ�ʱδ�ӣ�7��ƽ̨�������������8���û�����ȡ��ͨ����9����������Ȩ����255������ԭ��
	ucsubreason		nvarchar(2000),		--�һ�ԭ�򲹳�������1�����йҶϣ�2�����йҶϣ�Ŀǰ��reason=0ʱ��Ч
)

drop table ask_test_bill
create table ask_test_bill
(
	tid  int primary key identity(1,1) not null,
	tvalue nvarchar(2000) not null,
	tdate nvarchar(2000) not null,
)


--������
EXECUTE sp_addextendedproperty N'MS_Description', N'������',N'SCHEMA', N'dbo', N'table', N'ask_doctor_list'

--������
EXECUTE sp_addextendedproperty N'MS_Description', N'������',N'SCHEMA', N'dbo', N'table', N'doctor_list',N'COLUMN',N'did'



--���ұ�
CREATE TABLE ask_dept
(
	did [int] primary key  IDENTITY(1,1) NOT NULL,	--��ʶ��
	dname [nvarchar](50) NULL,						--��������
	dhid	int not null,							--��������ҽԺid 
	dparentid int not null,							--������ұ�ţ������ڿ���1�������ڿƵĸ�������Ϊ1
	dcontent nvarchar(500) null,					--�������� �����ֶ�
	dstate   tinyint not null						--��������״̬ 0δ���� 1����
)

--�ͷ��ʺű�
CREATE TABLE ask_master
(
	mid [int] primary key  IDENTITY(1,1) NOT NULL,	--��ʶ��
	mnumber [nvarchar](50) NULL,					--�ʺ�
	mpassword [nvarchar](50) NULL,					--����
	mPurview [nvarchar](500) NULL,					--Ȩ�� ����0,1,2,3
	memail [nvarchar](50) NULL,						--����
	mtell [nvarchar](50) NULL,						--�ֻ�����
	mregdate [datetime] NULL,						--ע������
	mname	nvarchar(20) null,						--����
	msex	nvarchar(10) null,						--�Ա�
	maddress nvarchar(200) null,					--�����ŵ� �������ں����塢�����������ס����ڱ���
	mlastlogintime [datetime] NULL,					--����¼����
	mlastip [nvarchar](200) NULL,					--����¼IP
	mstate [tinyint] NULL,							--����¼״̬
	mlogincount [int] NULL,							--��¼����
	mremark [nvarchar](200) NULL					--��ע��Ϣ
)
--���������ϱ�
create table ask_illpersion
(
	iid [int] primary key  IDENTITY(1,1) NOT NULL,	--��ʶ��
	uid	int not null,								--�����������ʺ�
	iname [nvarchar](200) NULL	,					--����������
	iphone [nvarchar](200) NULL	,					--�������ֻ�����
	icardtype [nvarchar](200) NULL	,				--������֤������
	icard [nvarchar](200) NULL	,					--������֤������
	isex [nvarchar](200) NULL	,					--�������Ա�
	ibirthday datetime NULL		,					--����������
	iaddress [nvarchar](200) NULL					--�����˵�ַ
)

--�������۱�
create table ask_order_reply
(
	orid [int] primary key  IDENTITY(1,1) NOT NULL,	--��ʶ��
	oid int not null,								--�������
	did int not null,								--ҽ�����
	uuid int not null,								--�û����
	orcontent  [nvarchar](200) NULL,				--��������
	ordate  datetime NULL,							--��������
	orstate tinyint null							--�Ƿ���ʾ���� 0����ʾ 1��ʾ
)
--���ļ�¼��

--����ask_master�ͷ���
--����ask_dept���ұ�
--����ask_illpersion���������ϱ�
--����ask_order_reply�������۱�
--ask_user�û��������ֶ�
--ask_doctor_listҽ���������ֶ�
--ask_order�����������ֶ�
--ask_city���б�����ֶ�����



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





