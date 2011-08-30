using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;

namespace FlexCDC.BaseInfo
{
	public class Pop_Vendor_Web : COM.CDCWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TextBox txt_code;
		private System.Windows.Forms.Label btn_apply;
        private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label lbl_item;
		public System.Windows.Forms.PictureBox picb_MR;
		private System.ComponentModel.IContainer components = null;
        private TextBox txt_Name;
        private TextBox txt_Web_Password;
        private TextBox txt_Web_ID;
        private Label lbl_Web;
        private Label lbl_Web_Password;
		public BaseInfo.Form_SRF_Vendor arg_request = null;

		public Pop_Vendor_Web()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}
		public Pop_Vendor_Web(BaseInfo.Form_SRF_Vendor arg_request1)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			arg_request = arg_request1;
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
		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Vendor_Web));
this.pnl_Search = new System.Windows.Forms.Panel();
this.pnl_SearchImage = new System.Windows.Forms.Panel();
this.txt_Name = new System.Windows.Forms.TextBox();
this.txt_code = new System.Windows.Forms.TextBox();
this.lbl_item = new System.Windows.Forms.Label();
this.picb_BR = new System.Windows.Forms.PictureBox();
this.picb_BM = new System.Windows.Forms.PictureBox();
this.picb_BL = new System.Windows.Forms.PictureBox();
this.picb_ML = new System.Windows.Forms.PictureBox();
this.picb_MM = new System.Windows.Forms.PictureBox();
this.picb_MR = new System.Windows.Forms.PictureBox();
this.picb_TR = new System.Windows.Forms.PictureBox();
this.picb_TM = new System.Windows.Forms.PictureBox();
this.lbl_SubTitle1 = new System.Windows.Forms.Label();
this.btn_apply = new System.Windows.Forms.Label();
this.btn_cancel = new System.Windows.Forms.Label();
this.txt_Web_Password = new System.Windows.Forms.TextBox();
this.txt_Web_ID = new System.Windows.Forms.TextBox();
this.lbl_Web = new System.Windows.Forms.Label();
this.lbl_Web_Password = new System.Windows.Forms.Label();
this.pnl_Search.SuspendLayout();
this.pnl_SearchImage.SuspendLayout();
((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
this.SuspendLayout();
// 
// img_Label
// 
this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
this.img_Label.Images.SetKeyName(0, "");
this.img_Label.Images.SetKeyName(1, "");
this.img_Label.Images.SetKeyName(2, "");
// 
// img_Button
// 
this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
this.img_Button.Images.SetKeyName(0, "");
this.img_Button.Images.SetKeyName(1, "");
// 
// lbl_MainTitle
// 
this.lbl_MainTitle.Text = "Web Information";
// 
// pnl_Search
// 
this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
this.pnl_Search.Controls.Add(this.pnl_SearchImage);
this.pnl_Search.Location = new System.Drawing.Point(0, 32);
this.pnl_Search.Name = "pnl_Search";
this.pnl_Search.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
this.pnl_Search.Size = new System.Drawing.Size(392, 70);
this.pnl_Search.TabIndex = 78;
// 
// pnl_SearchImage
// 
this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
this.pnl_SearchImage.Controls.Add(this.txt_Name);
this.pnl_SearchImage.Controls.Add(this.txt_code);
this.pnl_SearchImage.Controls.Add(this.lbl_item);
this.pnl_SearchImage.Controls.Add(this.picb_BR);
this.pnl_SearchImage.Controls.Add(this.picb_BM);
this.pnl_SearchImage.Controls.Add(this.picb_BL);
this.pnl_SearchImage.Controls.Add(this.picb_ML);
this.pnl_SearchImage.Controls.Add(this.picb_MM);
this.pnl_SearchImage.Controls.Add(this.picb_MR);
this.pnl_SearchImage.Controls.Add(this.picb_TR);
this.pnl_SearchImage.Controls.Add(this.picb_TM);
this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
this.pnl_SearchImage.Location = new System.Drawing.Point(1, 0);
this.pnl_SearchImage.Name = "pnl_SearchImage";
this.pnl_SearchImage.Size = new System.Drawing.Size(390, 70);
this.pnl_SearchImage.TabIndex = 18;
// 
// txt_Name
// 
this.txt_Name.BackColor = System.Drawing.SystemColors.Window;
this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
this.txt_Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txt_Name.Location = new System.Drawing.Point(191, 36);
this.txt_Name.MaxLength = 9999999;
this.txt_Name.Name = "txt_Name";
this.txt_Name.Size = new System.Drawing.Size(191, 21);
this.txt_Name.TabIndex = 254;
// 
// txt_code
// 
this.txt_code.BackColor = System.Drawing.SystemColors.Window;
this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
this.txt_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txt_code.Location = new System.Drawing.Point(90, 36);
this.txt_code.MaxLength = 9999999;
this.txt_code.Name = "txt_code";
this.txt_code.Size = new System.Drawing.Size(100, 21);
this.txt_code.TabIndex = 252;
// 
// lbl_item
// 
this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
this.lbl_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbl_item.Location = new System.Drawing.Point(8, 36);
this.lbl_item.Name = "lbl_item";
this.lbl_item.Size = new System.Drawing.Size(80, 21);
this.lbl_item.TabIndex = 251;
this.lbl_item.Text = "Vendor";
this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
// 
// picb_BR
// 
this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
this.picb_BR.Location = new System.Drawing.Point(374, 55);
this.picb_BR.Name = "picb_BR";
this.picb_BR.Size = new System.Drawing.Size(16, 16);
this.picb_BR.TabIndex = 23;
this.picb_BR.TabStop = false;
// 
// picb_BM
// 
this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
this.picb_BM.Location = new System.Drawing.Point(144, 54);
this.picb_BM.Name = "picb_BM";
this.picb_BM.Size = new System.Drawing.Size(230, 18);
this.picb_BM.TabIndex = 24;
this.picb_BM.TabStop = false;
// 
// picb_BL
// 
this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
this.picb_BL.Location = new System.Drawing.Point(0, 55);
this.picb_BL.Name = "picb_BL";
this.picb_BL.Size = new System.Drawing.Size(168, 20);
this.picb_BL.TabIndex = 22;
this.picb_BL.TabStop = false;
// 
// picb_ML
// 
this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
this.picb_ML.Location = new System.Drawing.Point(0, 24);
this.picb_ML.Name = "picb_ML";
this.picb_ML.Size = new System.Drawing.Size(168, 37);
this.picb_ML.TabIndex = 25;
this.picb_ML.TabStop = false;
// 
// picb_MM
// 
this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
this.picb_MM.Location = new System.Drawing.Point(160, 24);
this.picb_MM.Name = "picb_MM";
this.picb_MM.Size = new System.Drawing.Size(222, 30);
this.picb_MM.TabIndex = 27;
this.picb_MM.TabStop = false;
// 
// picb_MR
// 
this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
this.picb_MR.Location = new System.Drawing.Point(373, 28);
this.picb_MR.Name = "picb_MR";
this.picb_MR.Size = new System.Drawing.Size(24, 28);
this.picb_MR.TabIndex = 253;
this.picb_MR.TabStop = false;
// 
// picb_TR
// 
this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
this.picb_TR.Location = new System.Drawing.Point(374, 0);
this.picb_TR.Name = "picb_TR";
this.picb_TR.Size = new System.Drawing.Size(16, 32);
this.picb_TR.TabIndex = 21;
this.picb_TR.TabStop = false;
// 
// picb_TM
// 
this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
this.picb_TM.Location = new System.Drawing.Point(224, 0);
this.picb_TM.Name = "picb_TM";
this.picb_TM.Size = new System.Drawing.Size(166, 32);
this.picb_TM.TabIndex = 0;
this.picb_TM.TabStop = false;
// 
// lbl_SubTitle1
// 
this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
this.lbl_SubTitle1.Name = "lbl_SubTitle1";
this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
this.lbl_SubTitle1.TabIndex = 28;
this.lbl_SubTitle1.Text = "         Web Information";
this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
// 
// btn_apply
// 
this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
this.btn_apply.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btn_apply.ImageIndex = 1;
this.btn_apply.ImageList = this.img_Button;
this.btn_apply.Location = new System.Drawing.Point(8, 139);
this.btn_apply.Name = "btn_apply";
this.btn_apply.Size = new System.Drawing.Size(70, 24);
this.btn_apply.TabIndex = 249;
this.btn_apply.Text = "Apply";
this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
// 
// btn_cancel
// 
this.btn_cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btn_cancel.ImageIndex = 1;
this.btn_cancel.ImageList = this.img_Button;
this.btn_cancel.Location = new System.Drawing.Point(313, 138);
this.btn_cancel.Name = "btn_cancel";
this.btn_cancel.Size = new System.Drawing.Size(70, 23);
this.btn_cancel.TabIndex = 250;
this.btn_cancel.Text = "Cancel";
this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
// 
// txt_Web_Password
// 
this.txt_Web_Password.BackColor = System.Drawing.SystemColors.Window;
this.txt_Web_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
this.txt_Web_Password.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txt_Web_Password.Location = new System.Drawing.Point(91, 114);
this.txt_Web_Password.MaxLength = 9999999;
this.txt_Web_Password.Name = "txt_Web_Password";
this.txt_Web_Password.Size = new System.Drawing.Size(292, 21);
this.txt_Web_Password.TabIndex = 257;
// 
// txt_Web_ID
// 
this.txt_Web_ID.BackColor = System.Drawing.SystemColors.Window;
this.txt_Web_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
this.txt_Web_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txt_Web_ID.Location = new System.Drawing.Point(91, 91);
this.txt_Web_ID.MaxLength = 9999999;
this.txt_Web_ID.Name = "txt_Web_ID";
this.txt_Web_ID.Size = new System.Drawing.Size(292, 21);
this.txt_Web_ID.TabIndex = 256;
// 
// lbl_Web
// 
this.lbl_Web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
this.lbl_Web.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbl_Web.Location = new System.Drawing.Point(8, 91);
this.lbl_Web.Name = "lbl_Web";
this.lbl_Web.Size = new System.Drawing.Size(80, 21);
this.lbl_Web.TabIndex = 255;
this.lbl_Web.Text = "Web ID";
this.lbl_Web.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
// 
// lbl_Web_Password
// 
this.lbl_Web_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
this.lbl_Web_Password.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.lbl_Web_Password.Location = new System.Drawing.Point(8, 114);
this.lbl_Web_Password.Name = "lbl_Web_Password";
this.lbl_Web_Password.Size = new System.Drawing.Size(80, 21);
this.lbl_Web_Password.TabIndex = 258;
this.lbl_Web_Password.Text = "Web Pass";
this.lbl_Web_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
// 
// Pop_Vendor_Web
// 
this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
this.ClientSize = new System.Drawing.Size(392, 166);
this.Controls.Add(this.lbl_Web_Password);
this.Controls.Add(this.txt_Web_Password);
this.Controls.Add(this.txt_Web_ID);
this.Controls.Add(this.lbl_Web);
this.Controls.Add(this.pnl_Search);
this.Controls.Add(this.btn_apply);
this.Controls.Add(this.btn_cancel);
this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.Name = "Pop_Vendor_Web";
this.Text = "SHC Vendor";
this.Load += new System.EventHandler(this.Pop_Vendor_Web_Load);
this.Controls.SetChildIndex(this.btn_cancel, 0);
this.Controls.SetChildIndex(this.btn_apply, 0);
this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
this.Controls.SetChildIndex(this.pnl_Search, 0);
this.Controls.SetChildIndex(this.lbl_Web, 0);
this.Controls.SetChildIndex(this.txt_Web_ID, 0);
this.Controls.SetChildIndex(this.txt_Web_Password, 0);
this.Controls.SetChildIndex(this.lbl_Web_Password, 0);
this.pnl_Search.ResumeLayout(false);
this.pnl_SearchImage.ResumeLayout(false);
this.pnl_SearchImage.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
this.ResumeLayout(false);
this.PerformLayout();

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();
        private string _factory = "";
        public bool _save_flg = false;
		#endregion

		#region 공통메서드

		private void Init_Form()
		{

			this.Text          = "Web Information";
            lbl_MainTitle.Text = "Web Information";
			
			#region TextBox Setting			
			txt_Web_ID.CharacterCasing = CharacterCasing.Upper;
            txt_Web_Password.CharacterCasing = CharacterCasing.Upper;
			txt_Web_ID.Focus();


            txt_code.Enabled = false;
            txt_Name.Enabled = false;


            _factory = COM.ComVar.Parameter_PopUp[0]; 
            txt_code.Text  = COM.ComVar.Parameter_PopUp[1]; 
			txt_Name.Text = COM.ComVar.Parameter_PopUp[2];
			txt_Web_ID.Text= COM.ComVar.Parameter_PopUp[3];
			txt_Web_Password.Text = COM.ComVar.Parameter_PopUp[4];

			#endregion

			

		}		
		
		
		#endregion

		#region 이벤트 처리 


		private void btn_apply_Click(object sender, System.EventArgs e)
		{
            if (!Check_WebCD_Duplicate())
            {
                ClassLib.ComFunction.User_Message("Duplicate Web ID", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

			Update_Cust_Web();
            _save_flg = true;
            this.Close();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();					
		}	
		#endregion




		#region DB Connect

        private bool Check_WebCD_Duplicate()
        {



            DataSet ds_list;

            MyOraDB.ReDim_Parameter(4);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXB_BASE_02.CHECK_SCM_CUST_WEB";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_WEB_CUST_CD";
            MyOraDB.Parameter_Name[2] = "ARG_CUST_CD";
            MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = txt_Web_ID.Text;
            MyOraDB.Parameter_Values[2] = txt_code.Text;   
            MyOraDB.Parameter_Values[3] = "";



            MyOraDB.Add_Select_Parameter(true);
            ds_list = MyOraDB.Exe_Select_Procedure();

            if (ds_list.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString() == "TRUE") return true;
            else return false;


        }
         

        private void Update_Cust_Web()
        {
            
            

            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXB_BASE_02.UPDATE_SCM_CUST_WEB";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
            MyOraDB.Parameter_Name[2] = "ARG_WEB_CUST_CD";
            MyOraDB.Parameter_Name[3] = "ARG_WEB_PASS";
            MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";


            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;


            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = _factory;
            MyOraDB.Parameter_Values[1] = txt_code.Text;
            MyOraDB.Parameter_Values[2] = txt_Web_ID.Text;
            MyOraDB.Parameter_Values[3] = txt_Web_Password.Text;
            MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;
            

            MyOraDB.Add_Modify_Parameter(true);
            DataSet ds_list = MyOraDB.Exe_Modify_Procedure();



        }		

	
		#endregion

		private void Pop_Vendor_Web_Load(object sender, System.EventArgs e)
		{		
			Init_Form();
		}	

	}
}

