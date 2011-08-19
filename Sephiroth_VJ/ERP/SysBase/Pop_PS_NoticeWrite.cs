using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeWrite : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.TextBox txt_message;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private System.Windows.Forms.TextBox txt_user_name;
		private System.Windows.Forms.Label lbl_user_name;
		private System.Windows.Forms.TextBox txt_user_id;
		private System.Windows.Forms.Label lbl_user_id;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_show;
		private System.Windows.Forms.DateTimePicker dpick_end;
		private System.Windows.Forms.DateTimePicker dpick_Start;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.CheckBox chk_show;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private Pop_PS_NoticeAdmin frm;

		#endregion

		public Pop_PS_NoticeWrite(Pop_PS_NoticeAdmin arg_frm)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			this.frm = arg_frm;

		}

		public Pop_PS_NoticeWrite()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeWrite));
			this.txt_message = new System.Windows.Forms.TextBox();
			this.txt_user_name = new System.Windows.Forms.TextBox();
			this.lbl_user_name = new System.Windows.Forms.Label();
			this.txt_user_id = new System.Windows.Forms.TextBox();
			this.lbl_user_id = new System.Windows.Forms.Label();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.lbl_show = new System.Windows.Forms.Label();
			this.dpick_end = new System.Windows.Forms.DateTimePicker();
			this.dpick_Start = new System.Windows.Forms.DateTimePicker();
			this.lbl_date = new System.Windows.Forms.Label();
			this.chk_show = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
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
			this.txt_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_message.Location = new System.Drawing.Point(5, 134);
			this.txt_message.Multiline = true;
			this.txt_message.Name = "txt_message";
			this.txt_message.Size = new System.Drawing.Size(685, 274);
			this.txt_message.TabIndex = 76;
			this.txt_message.Text = "";
			// 
			// txt_user_name
			// 
			this.txt_user_name.BackColor = System.Drawing.Color.White;
			this.txt_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_user_name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_user_name.Location = new System.Drawing.Point(432, 17);
			this.txt_user_name.Name = "txt_user_name";
			this.txt_user_name.ReadOnly = true;
			this.txt_user_name.Size = new System.Drawing.Size(243, 21);
			this.txt_user_name.TabIndex = 82;
			this.txt_user_name.Text = "";
			// 
			// lbl_user_name
			// 
			this.lbl_user_name.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_user_name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_user_name.ImageIndex = 0;
			this.lbl_user_name.ImageList = this.img_Label;
			this.lbl_user_name.Location = new System.Drawing.Point(331, 16);
			this.lbl_user_name.Name = "lbl_user_name";
			this.lbl_user_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_user_name.TabIndex = 81;
			this.lbl_user_name.Text = "이름";
			this.lbl_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_user_id
			// 
			this.txt_user_id.BackColor = System.Drawing.Color.White;
			this.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_user_id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_user_id.Location = new System.Drawing.Point(106, 17);
			this.txt_user_id.Name = "txt_user_id";
			this.txt_user_id.ReadOnly = true;
			this.txt_user_id.Size = new System.Drawing.Size(210, 21);
			this.txt_user_id.TabIndex = 80;
			this.txt_user_id.Text = "";
			// 
			// lbl_user_id
			// 
			this.lbl_user_id.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_user_id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_user_id.ImageIndex = 0;
			this.lbl_user_id.ImageList = this.img_Label;
			this.lbl_user_id.Location = new System.Drawing.Point(5, 17);
			this.lbl_user_id.Name = "lbl_user_id";
			this.lbl_user_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_user_id.TabIndex = 79;
			this.lbl_user_id.Text = "아이디";
			this.lbl_user_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_title
			// 
			this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_title.Location = new System.Drawing.Point(106, 39);
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(569, 21);
			this.txt_title.TabIndex = 84;
			this.txt_title.Text = "";
			// 
			// lbl_title
			// 
			this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(5, 39);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 83;
			this.lbl_title.Text = "제목";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_show
			// 
			this.lbl_show.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_show.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_show.ImageIndex = 0;
			this.lbl_show.ImageList = this.img_Label;
			this.lbl_show.Location = new System.Drawing.Point(331, 61);
			this.lbl_show.Name = "lbl_show";
			this.lbl_show.Size = new System.Drawing.Size(100, 21);
			this.lbl_show.TabIndex = 89;
			this.lbl_show.Text = "보이기";
			this.lbl_show.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_end
			// 
			this.dpick_end.CalendarFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_end.CustomFormat = "";
			this.dpick_end.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_end.Location = new System.Drawing.Point(222, 61);
			this.dpick_end.Name = "dpick_end";
			this.dpick_end.Size = new System.Drawing.Size(96, 21);
			this.dpick_end.TabIndex = 88;
			this.dpick_end.Value = new System.DateTime(2005, 9, 24, 10, 50, 28, 783);
			this.dpick_end.ValueChanged += new System.EventHandler(this.dpick_end_ValueChanged);
			// 
			// dpick_Start
			// 
			this.dpick_Start.CalendarFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_Start.CustomFormat = "";
			this.dpick_Start.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Start.Location = new System.Drawing.Point(106, 61);
			this.dpick_Start.Name = "dpick_Start";
			this.dpick_Start.Size = new System.Drawing.Size(96, 21);
			this.dpick_Start.TabIndex = 87;
			this.dpick_Start.Value = new System.DateTime(2005, 9, 24, 10, 50, 28, 833);
			this.dpick_Start.ValueChanged += new System.EventHandler(this.dpick_Start_ValueChanged);
			// 
			// lbl_date
			// 
			this.lbl_date.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_date.ImageIndex = 0;
			this.lbl_date.ImageList = this.img_Label;
			this.lbl_date.Location = new System.Drawing.Point(5, 61);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_date.TabIndex = 86;
			this.lbl_date.Text = "기간 설정";
			this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_show
			// 
			this.chk_show.BackColor = System.Drawing.SystemColors.Window;
			this.chk_show.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_show.Checked = true;
			this.chk_show.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_show.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chk_show.Location = new System.Drawing.Point(431, 61);
			this.chk_show.Name = "chk_show";
			this.chk_show.Size = new System.Drawing.Size(15, 21);
			this.chk_show.TabIndex = 85;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(202, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 21);
			this.label1.TabIndex = 90;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(527, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 105;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ImageIndex = 10;
			this.btn_cancel.ImageList = this.imgs_new_btn;
			this.btn_cancel.Location = new System.Drawing.Point(608, 416);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_cancel.TabIndex = 106;
			this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_user_name);
			this.groupBox1.Controls.Add(this.lbl_user_name);
			this.groupBox1.Controls.Add(this.txt_user_id);
			this.groupBox1.Controls.Add(this.lbl_user_id);
			this.groupBox1.Controls.Add(this.txt_title);
			this.groupBox1.Controls.Add(this.lbl_title);
			this.groupBox1.Controls.Add(this.lbl_show);
			this.groupBox1.Controls.Add(this.dpick_end);
			this.groupBox1.Controls.Add(this.dpick_Start);
			this.groupBox1.Controls.Add(this.lbl_date);
			this.groupBox1.Controls.Add(this.chk_show);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 90);
			this.groupBox1.TabIndex = 110;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeWrite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.txt_message);
			this.Name = "Pop_PS_NoticeWrite";
			this.Text = "Notice";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PS_NoticeWrite_Closing);
			this.Load += new System.EventHandler(this.Form_PS_NoticeWrite_Load);
			this.Controls.SetChildIndex(this.txt_message, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.btn_cancel, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	
		#region 메소드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			this.Text = "Notice Write";
			this.lbl_MainTitle.Text = "Notice Write";
			ClassLib.ComFunction.SetLangDic(this);

			
			oraDB = new COM.OraDB();

			dpick_Start.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_end.CustomFormat = ClassLib.ComVar.This_SetedDateType;


			dpick_Start.Value = DateTime.Now;
			dpick_end.Value = DateTime.Now.AddDays(14);
 

			txt_user_id.Text   = ClassLib.ComVar.This_User;
			txt_user_name.Text = ClassLib.ComVar.This_Name;
 
		}

		/// <summary>
		/// Return_YN : bool 형을 Y,N 형으로
		/// </summary>
		/// <param name="arg_trueFalse">bool형 데이터</param>
		/// <returns>true : Y, flase : N</returns>
		private string Return_YN(bool arg_trueFalse)
		{
			string YN = null;

			if(arg_trueFalse)
				YN = "Y";
			else
				YN = "N";

			return YN;
		}

		#endregion

		#region 이벤트 처리 

		private void Form_PS_NoticeWrite_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_PS_NoticeWrite_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			frm.Get_Notice_List("U","");
		}


		private void btn_save_Click(object sender, System.EventArgs e)
		{
			Insert_Notice();


			ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave);
			Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void dpick_Start_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Start.Name, dpick_end.Name);
		}

		private void dpick_end_ValueChanged(object sender, System.EventArgs e)
		{
			//ClassLib.ComFunction.Set_Values(this, dpick_Start.Name, dpick_end.Name);
		}

		#endregion

		#region DB 접속

		/// <summary>
		/// GetUserName : 사용자 이름 가져오기
		/// </summary>
		/// <param name="arg_user_id">사용자 아이디</param>
		/// <returns>정상 : 이름 , 오류 : null </returns>
		private DataTable GetUserName(string arg_user_id)
		{

			string Proc_Name = "PKG_SPS_HOME.SELECT_USER_NAME";

			////// DB에서 사용자 이름 추줄 
			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_USER_ID";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_user_id;
			oraDB.Parameter_Values[1] = "";


			oraDB.Add_Select_Parameter(false); 
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void Insert_Notice()
		{

			string Proc_Name = "PKG_SPS_HOME.SAVE_SPS_NOTICE";

		
			oraDB.ReDim_Parameter(9);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_NAME";
			oraDB.Parameter_Name[3] = "ARG_TITLE";
			oraDB.Parameter_Name[4] = "ARG_STDATE";
			oraDB.Parameter_Name[5] = "ARG_ENDATE";
			oraDB.Parameter_Name[6] = "ARG_SHOW_YN";
			oraDB.Parameter_Name[7] = "ARG_MESSAGE";
			oraDB.Parameter_Name[8] = "ARG_UPD_USER";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[8] = (int)OracleType.VarChar;


			COM.ComFunction comfunc= new COM.ComFunction();

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = txt_user_id.Text;
			oraDB.Parameter_Values[2] = txt_user_name.Text;
			oraDB.Parameter_Values[3] = txt_title.Text;
			oraDB.Parameter_Values[4] = comfunc.ConvertDate2DbType(dpick_Start.Text);
			oraDB.Parameter_Values[5] = comfunc.ConvertDate2DbType(dpick_end.Text);
			oraDB.Parameter_Values[6] = Return_YN(chk_show.Checked);
			oraDB.Parameter_Values[7] = txt_message.Text;
			oraDB.Parameter_Values[8] = txt_user_id.Text;

			oraDB.Add_Modify_Parameter(false);
			oraDB.Exe_Modify_Procedure();
		}



		public void Insert_Notice_ref(string arg_user_id, string arg_name, string arg_title, string arg_stdate, string arg_edate, string arg_message)
		{

			COM.OraDB oraDB = new COM.OraDB();
			string Proc_Name = "PKG_SPS_HOME.SAVE_SPS_NOTICE";

		
			oraDB.ReDim_Parameter(9);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_NAME";
			oraDB.Parameter_Name[3] = "ARG_TITLE";
			oraDB.Parameter_Name[4] = "ARG_STDATE";
			oraDB.Parameter_Name[5] = "ARG_ENDATE";
			oraDB.Parameter_Name[6] = "ARG_SHOW_YN";
			oraDB.Parameter_Name[7] = "ARG_MESSAGE";
			oraDB.Parameter_Name[8] = "ARG_UPD_USER";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[8] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = arg_name;
			oraDB.Parameter_Values[3] = arg_title;
			oraDB.Parameter_Values[4] = arg_stdate;
			oraDB.Parameter_Values[5] = arg_edate;;
			oraDB.Parameter_Values[6] = Return_YN(chk_show.Checked);
			oraDB.Parameter_Values[7] = arg_message;
			oraDB.Parameter_Values[8] = arg_user_id;

			oraDB.Add_Modify_Parameter(false);
			oraDB.Exe_Modify_Procedure();
		}

		



		#endregion

		
	}
}

