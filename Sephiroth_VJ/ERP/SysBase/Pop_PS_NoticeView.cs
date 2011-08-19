using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeView : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.TextBox txt_message;
		private System.ComponentModel.IContainer components = null;



		#region 사용자 변수
		private string arg_factory;
		private string arg_seq;
		private System.Windows.Forms.Label lbl_user_name_w;
		private System.Windows.Forms.Label lbl_user_name;
		private System.Windows.Forms.Label lbl_title_w;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_sdate_w;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_cencal; 
		private System.Windows.Forms.Label lbl_modify;
		private Form_Home frm_home = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private COM.OraDB oraDB = null;
		#endregion

		public Pop_PS_NoticeView(string arg_factory, string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			this.arg_factory = arg_factory;
			this.arg_seq     = arg_seq;

		}

		public Pop_PS_NoticeView(Form_Home home,  string arg_factory, string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			this.frm_home    = home;
			this.arg_factory = arg_factory;
			this.arg_seq     = arg_seq;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeView));
			this.txt_message = new System.Windows.Forms.TextBox();
			this.lbl_user_name_w = new System.Windows.Forms.Label();
			this.lbl_user_name = new System.Windows.Forms.Label();
			this.lbl_title_w = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
			this.lbl_sdate_w = new System.Windows.Forms.Label();
			this.lbl_date = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_cencal = new System.Windows.Forms.Label(); 
			this.lbl_modify = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			// txt_message
			// 
			this.txt_message.BackColor = System.Drawing.Color.White;
			this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_message.ForeColor = System.Drawing.Color.Black;
			this.txt_message.Location = new System.Drawing.Point(5, 136);
			this.txt_message.Multiline = true;
			this.txt_message.Name = "txt_message";
			this.txt_message.ReadOnly = true;
			this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_message.Size = new System.Drawing.Size(685, 272);
			this.txt_message.TabIndex = 87;
			this.txt_message.Text = "";
			// 
			// lbl_user_name_w
			// 
			this.lbl_user_name_w.BackColor = System.Drawing.Color.Transparent;
			this.lbl_user_name_w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_user_name_w.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_user_name_w.Location = new System.Drawing.Point(108, 15);
			this.lbl_user_name_w.Name = "lbl_user_name_w";
			this.lbl_user_name_w.Size = new System.Drawing.Size(564, 21);
			this.lbl_user_name_w.TabIndex = 83;
			this.lbl_user_name_w.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_user_name
			// 
			this.lbl_user_name.ImageIndex = 0;
			this.lbl_user_name.ImageList = this.img_Label;
			this.lbl_user_name.Location = new System.Drawing.Point(7, 15);
			this.lbl_user_name.Name = "lbl_user_name";
			this.lbl_user_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_user_name.TabIndex = 82;
			this.lbl_user_name.Text = "Name";
			this.lbl_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title_w
			// 
			this.lbl_title_w.BackColor = System.Drawing.Color.Transparent;
			this.lbl_title_w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_title_w.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title_w.Location = new System.Drawing.Point(108, 37);
			this.lbl_title_w.Name = "lbl_title_w";
			this.lbl_title_w.Size = new System.Drawing.Size(564, 21);
			this.lbl_title_w.TabIndex = 85;
			this.lbl_title_w.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(7, 37);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 84;
			this.lbl_title.Text = "Title";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_sdate_w
			// 
			this.lbl_sdate_w.BackColor = System.Drawing.Color.Transparent;
			this.lbl_sdate_w.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_sdate_w.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_sdate_w.Location = new System.Drawing.Point(108, 59);
			this.lbl_sdate_w.Name = "lbl_sdate_w";
			this.lbl_sdate_w.Size = new System.Drawing.Size(564, 21);
			this.lbl_sdate_w.TabIndex = 87;
			this.lbl_sdate_w.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_date
			// 
			this.lbl_date.ImageIndex = 0;
			this.lbl_date.ImageList = this.img_Label;
			this.lbl_date.Location = new System.Drawing.Point(7, 59);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_date.TabIndex = 86;
			this.lbl_date.Text = "Display Period";
			this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_cencal
			// 
			this.btn_cencal.ImageIndex = 12;
			this.btn_cencal.ImageList = this.imgs_new_btn;
			this.btn_cencal.Location = new System.Drawing.Point(610, 416);
			this.btn_cencal.Name = "btn_cencal";
			this.btn_cencal.Size = new System.Drawing.Size(80, 23);
			this.btn_cencal.TabIndex = 109;
			this.btn_cencal.Click += new System.EventHandler(this.btn_cencal_Click); 
			// 
			// lbl_modify
			// 
			this.lbl_modify.ImageIndex = 11;
			this.lbl_modify.ImageList = this.imgs_new_btn;
			this.lbl_modify.Location = new System.Drawing.Point(529, 416);
			this.lbl_modify.Name = "lbl_modify";
			this.lbl_modify.Size = new System.Drawing.Size(80, 23);
			this.lbl_modify.TabIndex = 253;
			this.lbl_modify.Click += new System.EventHandler(this.lbl_modify_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_title);
			this.groupBox1.Controls.Add(this.lbl_date);
			this.groupBox1.Controls.Add(this.lbl_user_name_w);
			this.groupBox1.Controls.Add(this.lbl_sdate_w);
			this.groupBox1.Controls.Add(this.lbl_user_name);
			this.groupBox1.Controls.Add(this.lbl_title_w);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 89);
			this.groupBox1.TabIndex = 254;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lbl_modify);
			this.Controls.Add(this.btn_cencal);
			this.Controls.Add(this.txt_message);
			this.Name = "Pop_PS_NoticeView";
			this.Text = "Notice";
			this.Load += new System.EventHandler(this.Form_PS_NoticeView_Load);
			this.Closed += new System.EventHandler(this.Form_PS_NoticeView_Closed);
			this.Controls.SetChildIndex(this.txt_message, 0);
			this.Controls.SetChildIndex(this.btn_cencal, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_modify, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_NoticeView_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			this.Text = "Notice View";
			this.lbl_MainTitle.Text = "Notice View";
			ClassLib.ComFunction.SetLangDic(this);
			
			oraDB = new COM.OraDB();

			View_Notice();
		}

		public void View_Notice()
		{
			DataTable dt = Select_SPS_Notice_info(arg_factory, arg_seq);
		
			string arg_user_id   = dt.Rows[0].ItemArray[3].ToString();
			string arg_user_name = dt.Rows[0].ItemArray[3].ToString();
			string arg_title     = dt.Rows[0].ItemArray[4].ToString();

			COM.ComFunction comfunc = new COM.ComFunction();
			string arg_sdate     = comfunc.ConvertDate2Type(dt.Rows[0].ItemArray[5].ToString());
			string arg_edate     = comfunc.ConvertDate2Type(dt.Rows[0].ItemArray[6].ToString());
			string arg_message   = dt.Rows[0].ItemArray[7].ToString();

			//lbl_user_id_w.Text = arg_user_id;
			lbl_user_name_w.Text = arg_user_name;
			lbl_sdate_w.Text = arg_sdate + " ~ " + arg_edate;
			//lbl_edate_w.Text = arg_edate;
			lbl_title_w.Text = arg_title;
			txt_message.Text = arg_message;

		}


		/// <summary>
		/// Select_SPS_Notice_info : 공지사항 상세정보
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_seq">SEQ</param>
		/// <returns>정상:DATETABLE 오류:NULL</returns>
		private DataTable Select_SPS_Notice_info(string arg_factory, string arg_seq)
		{

			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_INFO";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";
			oraDB.Parameter_Name[2] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_seq;
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void btn_cencal_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void lbl_modify_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeModify psNoticeModify = new Pop_PS_NoticeModify(this, arg_factory, arg_seq);
			psNoticeModify.ShowDialog();
		}

		private void Form_PS_NoticeView_Closed(object sender, System.EventArgs e)
		{
			if(frm_home != null)
			{
				frm_home.Get_Notice();
			}
		}

		 
	}
}

