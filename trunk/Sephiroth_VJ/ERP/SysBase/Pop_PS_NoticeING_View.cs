using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeING_View : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_jobcd;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.TextBox txt_body;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_send;
		private C1.Win.C1Command.C1Command tbtn_clear;
		private C1.Win.C1Command.C1Command tbtn_close;
		private System.ComponentModel.IContainer components = null;



		#region 사용자 변수

		private COM.OraDB oraDB = new COM.OraDB();
		private string factory = "";
		private System.Windows.Forms.Label lbl_jobname;
		private System.Windows.Forms.Label lbl_title1;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_cencal;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.GroupBox groupBox1;
		private string seq	   = "";

		#endregion

		public Pop_PS_NoticeING_View(string arg_factory, string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			factory = arg_factory;
			seq		= arg_seq;
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeING_View));
			this.lbl_jobcd = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
			this.txt_body = new System.Windows.Forms.TextBox();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_send = new C1.Win.C1Command.C1Command();
			this.tbtn_clear = new C1.Win.C1Command.C1Command();
			this.tbtn_close = new C1.Win.C1Command.C1Command();
			this.lbl_jobname = new System.Windows.Forms.Label();
			this.lbl_title1 = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_cencal = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// lbl_jobcd
			// 
			this.lbl_jobcd.ImageIndex = 0;
			this.lbl_jobcd.ImageList = this.img_Label;
			this.lbl_jobcd.Location = new System.Drawing.Point(5, 17);
			this.lbl_jobcd.Name = "lbl_jobcd";
			this.lbl_jobcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_jobcd.TabIndex = 226;
			this.lbl_jobcd.Text = "업무";
			this.lbl_jobcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(5, 39);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 228;
			this.lbl_title.Text = "제목";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_body
			// 
			this.txt_body.BackColor = System.Drawing.Color.White;
			this.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_body.Location = new System.Drawing.Point(5, 112);
			this.txt_body.Multiline = true;
			this.txt_body.Name = "txt_body";
			this.txt_body.ReadOnly = true;
			this.txt_body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_body.Size = new System.Drawing.Size(685, 264);
			this.txt_body.TabIndex = 231;
			this.txt_body.Text = "";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_send);
			this.c1CommandHolder1.Commands.Add(this.tbtn_clear);
			this.c1CommandHolder1.Commands.Add(this.tbtn_close);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_send
			// 
			this.tbtn_send.ImageIndex = 16;
			this.tbtn_send.Name = "tbtn_send";
			this.tbtn_send.Text = "Send";
			// 
			// tbtn_clear
			// 
			this.tbtn_clear.ImageIndex = 12;
			this.tbtn_clear.Name = "tbtn_clear";
			this.tbtn_clear.Text = "Clear";
			// 
			// tbtn_close
			// 
			this.tbtn_close.ImageIndex = 18;
			this.tbtn_close.Name = "tbtn_close";
			this.tbtn_close.Text = "Close";
			// 
			// lbl_jobname
			// 
			this.lbl_jobname.BackColor = System.Drawing.Color.Transparent;
			this.lbl_jobname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_jobname.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_jobname.Location = new System.Drawing.Point(106, 17);
			this.lbl_jobname.Name = "lbl_jobname";
			this.lbl_jobname.Size = new System.Drawing.Size(569, 21);
			this.lbl_jobname.TabIndex = 246;
			this.lbl_jobname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title1
			// 
			this.lbl_title1.BackColor = System.Drawing.Color.Transparent;
			this.lbl_title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_title1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title1.Location = new System.Drawing.Point(106, 39);
			this.lbl_title1.Name = "lbl_title1";
			this.lbl_title1.Size = new System.Drawing.Size(569, 21);
			this.lbl_title1.TabIndex = 247;
			this.lbl_title1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_cencal
			// 
			this.btn_cencal.ImageIndex = 10;
			this.btn_cencal.ImageList = this.imgs_new_btn;
			this.btn_cencal.Location = new System.Drawing.Point(610, 384);
			this.btn_cencal.Name = "btn_cencal";
			this.btn_cencal.Size = new System.Drawing.Size(80, 23);
			this.btn_cencal.TabIndex = 248;
			this.btn_cencal.Click += new System.EventHandler(this.btn_cencal_Click);
			// 
			// panel6
			// 
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_title);
			this.groupBox1.Controls.Add(this.lbl_jobcd);
			this.groupBox1.Controls.Add(this.lbl_title1);
			this.groupBox1.Controls.Add(this.lbl_jobname);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 67);
			this.groupBox1.TabIndex = 251;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeING_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 416);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_cencal);
			this.Controls.Add(this.txt_body);
			this.Name = "Pop_PS_NoticeING_View";
			this.Text = "Work List";
			this.Load += new System.EventHandler(this.Form_PC_NoticeING_View_Load);
			this.Controls.SetChildIndex(this.txt_body, 0);
			this.Controls.SetChildIndex(this.btn_cencal, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PC_NoticeING_View_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.Text = "View Job Message";
			this.lbl_MainTitle.Text = "View Job Message";

			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();
			Show_Message();
		}


		private void Show_Message()
		{
			DataTable dt = Select_Notice_IngWork_detail();

			string sender_id	= dt.Rows[0].ItemArray[3].ToString();
			string sender_name	= dt.Rows[0].ItemArray[4].ToString();
			string jobcd		= Get_JobCD_Name(dt.Rows[0].ItemArray[2].ToString());
			string title		= dt.Rows[0].ItemArray[5].ToString();
			string contents		= dt.Rows[0].ItemArray[6].ToString();

			lbl_jobname.Text = jobcd;
			lbl_title1.Text  = title;
			txt_body.Text	 = contents;
		}

	

		#region 이벤트

		private void btn_cencal_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		
		#endregion

		#region DB 접속

		/// <summary>
		/// SEQECT_NOTICE_INGWORK_DETAIL : 진행중인 업무 상제 정보 가져오기 
		/// </summary>
		/// <returns>정상:DataTable, 오류:null</returns>
		private DataTable Select_Notice_IngWork_detail()
		{
			string Proc_Name = "PKG_SPS_HOME.SEQECT_NOTICE_INGWORK_DETAIL";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_SEQ";
			oraDB.Parameter_Name[2]  = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = factory;
			oraDB.Parameter_Values[1] = seq;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true); 
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Get_Name : 사용자 이름,메일 주소 가져오기 가져오기
		/// </summary>
		/// <param name="arg_user_id">사용자 아이디</param>
		/// <returns>정상:DataTable ,오류:null</returns>
		private DataTable Get_Name(string arg_user_id)
		{

			string Proc_Name = "PKG_SPS_HOME.GET_USER_NAME";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0]  = "ARG_FACTORY";
			oraDB.Parameter_Name[1]  = "ARG_USER_ID";
			oraDB.Parameter_Name[2]  = "OUT_CURSOR";

			oraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2]  = (int)OracleType.Cursor;


			oraDB.Parameter_Values[0]  = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1]  = arg_user_id;
			oraDB.Parameter_Values[2]  = "";

			oraDB.Add_Select_Parameter(true); 
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Get_JobCD_Name : 업무 코드로 업무 이름 가져오기
		/// </summary>
		/// <param name="arg_com_value1">업무코드</param>
		/// <returns>정상:업무이름 , 오류:null</returns>
		private string Get_JobCD_Name(string arg_com_value1)
		{
			string Proc_Name = "PKG_SPS_HOME.GET_JOBCD_NAME";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "ARG_COM_VALUE1";
			oraDB.Parameter_Name[3] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "CM01";
			oraDB.Parameter_Values[2] = arg_com_value1;
			oraDB.Parameter_Values[3] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[3].ToString();
		}



		#endregion
	}
}

