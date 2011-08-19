using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace ERP.ErpCom
{
	public class Form_CM_Table : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_MiniButton;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Label lbl_PgId;
		private System.Windows.Forms.Label btn_PopPgId;
		private C1.Win.C1List.C1Combo cmb_PgId;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_Create;
		private System.Windows.Forms.TextBox txt_PgId;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
		private System.ComponentModel.IContainer components = null;

		public Form_CM_Table()
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


		#endregion 

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CM_Table));
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_PgId = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_PopPgId = new System.Windows.Forms.Label();
            this.cmb_PgId = new C1.Win.C1List.C1Combo();
            this.lbl_PgId = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PgId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink8,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Color_Click);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            // 
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 80);
            this.pnl_Search.TabIndex = 32;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.button3);
            this.pnl_SearchImage.Controls.Add(this.button2);
            this.pnl_SearchImage.Controls.Add(this.button1);
            this.pnl_SearchImage.Controls.Add(this.txt_PgId);
            this.pnl_SearchImage.Controls.Add(this.textBox3);
            this.pnl_SearchImage.Controls.Add(this.textBox2);
            this.pnl_SearchImage.Controls.Add(this.textBox1);
            this.pnl_SearchImage.Controls.Add(this.btn_Create);
            this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
            this.pnl_SearchImage.Controls.Add(this.cmb_PgId);
            this.pnl_SearchImage.Controls.Add(this.lbl_PgId);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 64);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_PgId
            // 
            this.txt_PgId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PgId.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_PgId.Location = new System.Drawing.Point(111, 36);
            this.txt_PgId.MaxLength = 40;
            this.txt_PgId.Name = "txt_PgId";
            this.txt_PgId.Size = new System.Drawing.Size(250, 21);
            this.txt_PgId.TabIndex = 58;
            this.txt_PgId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PgId_KeyPress);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Create.ImageIndex = 0;
            this.btn_Create.ImageList = this.img_LongButton;
            this.btn_Create.Location = new System.Drawing.Point(888, 34);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(100, 23);
            this.btn_Create.TabIndex = 118;
            this.btn_Create.Text = "Set Default List";
            this.btn_Create.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            this.btn_Create.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Create_MouseDown);
            this.btn_Create.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Create_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // btn_PopPgId
            // 
            this.btn_PopPgId.ImageIndex = 0;
            this.btn_PopPgId.ImageList = this.img_MiniButton;
            this.btn_PopPgId.Location = new System.Drawing.Point(613, 36);
            this.btn_PopPgId.Name = "btn_PopPgId";
            this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
            this.btn_PopPgId.TabIndex = 34;
            this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PopPgId.Click += new System.EventHandler(this.btn_PopPgId_Click);
            this.btn_PopPgId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PopPgId_MouseDown);
            this.btn_PopPgId.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PopPgId_MouseUp);
            // 
            // cmb_PgId
            // 
            this.cmb_PgId.AddItemSeparator = ';';
            this.cmb_PgId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PgId.Caption = "";
            this.cmb_PgId.CaptionHeight = 17;
            this.cmb_PgId.CaptionStyle = style57;
            this.cmb_PgId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PgId.ColumnCaptionHeight = 18;
            this.cmb_PgId.ColumnFooterHeight = 18;
            this.cmb_PgId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PgId.ContentHeight = 17;
            this.cmb_PgId.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PgId.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PgId.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PgId.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PgId.EditorHeight = 17;
            this.cmb_PgId.EvenRowStyle = style58;
            this.cmb_PgId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PgId.FooterStyle = style59;
            this.cmb_PgId.HeadingStyle = style60;
            this.cmb_PgId.HighLightRowStyle = style61;
            this.cmb_PgId.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_PgId.Images"))));
            this.cmb_PgId.ItemHeight = 15;
            this.cmb_PgId.Location = new System.Drawing.Point(362, 36);
            this.cmb_PgId.MatchEntryTimeout = ((long)(2000));
            this.cmb_PgId.MaxDropDownItems = ((short)(5));
            this.cmb_PgId.MaxLength = 32767;
            this.cmb_PgId.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PgId.Name = "cmb_PgId";
            this.cmb_PgId.OddRowStyle = style62;
            this.cmb_PgId.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PgId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PgId.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PgId.SelectedStyle = style63;
            this.cmb_PgId.Size = new System.Drawing.Size(250, 21);
            this.cmb_PgId.Style = style64;
            this.cmb_PgId.TabIndex = 33;
            this.cmb_PgId.TextChanged += new System.EventHandler(this.cmb_PgId_TextChanged);
            this.cmb_PgId.PropBag = resources.GetString("cmb_PgId.PropBag");
            // 
            // lbl_PgId
            // 
            this.lbl_PgId.ImageIndex = 0;
            this.lbl_PgId.ImageList = this.img_Label;
            this.lbl_PgId.Location = new System.Drawing.Point(10, 36);
            this.lbl_PgId.Name = "lbl_PgId";
            this.lbl_PgId.Size = new System.Drawing.Size(100, 21);
            this.lbl_PgId.TabIndex = 32;
            this.lbl_PgId.Text = "프로그램아이디";
            this.lbl_PgId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(899, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(104, 25);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
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
            this.lbl_SubTitle1.Text = "      Program ID Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(984, 49);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 48);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(840, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 49);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 27);
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
            this.picb_MM.Size = new System.Drawing.Size(832, 24);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Location = new System.Drawing.Point(0, 144);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 500);
            this.pnl_Body.TabIndex = 33;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 19;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1000, 500);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 35;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 119;
            this.textBox1.Text = "G";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(400, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 120;
            this.button1.Text = "Get Alias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(481, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 120;
            this.button2.Text = "Copy Row";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(835, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 120;
            this.button3.Text = "Copy Grid";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(603, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 119;
            this.textBox2.Text = "G";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(734, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 22);
            this.textBox3.TabIndex = 119;
            this.textBox3.Text = "1";
            // 
            // Form_CM_Table
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_CM_Table";
            this.Text = "Grid Header Manager";
            this.Load += new System.EventHandler(this.Form_CM_Table_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PgId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의
   
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			//Title
			this.Text = "Grid Header Manager";
			lbl_MainTitle.Text = "Grid Header Manager";
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion


			DataTable dt_ret;

			


			// 그리드 설정
			fgrid_Main.Set_Grid_Comm("TABLE_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
 
			// 그리드 상에서 Insert, Delete, Update 이미지로 표시해주기 위한 작업
			fgrid_Main.Set_Action_Image(img_Action); 


			// 프로그램 리스트 항목 SELECT
			dt_ret = Select_PgList(txt_PgId.Text.Trim() );

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PgId, 1, 0, false);
		

		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

			} 

			arg_fgrid.AutoSizeCols();
		}



		/// <summary>
		/// Set_Color : 배경색, 글자색 지정
		/// </summary>
		private void Set_Color()
		{
			ColorDialog clrdig = new ColorDialog();
			int r1, r2, sel_col;
			int from_row, to_row;
			int i; 

			r1 = fgrid_Main.Selection.r1;
			r2 = fgrid_Main.Selection.r2;

			sel_col = fgrid_Main.Selection.c1;

			from_row = (r1 < r2) ? r1 : r2;
			to_row = (r1 < r2) ? r2 : r1;

			if(clrdig.ShowDialog() == DialogResult.OK)
			{
				for(i = from_row; i <= to_row; i++)
				{
					fgrid_Main[i, sel_col] = clrdig.Color.ToArgb().ToString();

					if(fgrid_Main[i, 0].ToString() == "") fgrid_Main[i, 0] = "U";

					fgrid_Main.GetCellRange(i, sel_col).StyleNew.ForeColor = clrdig.Color;
				} //end for
			} // end if


		}


		#endregion  

		#region 이벤트 처리 

 

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			txt_PgId.Text = "";
			cmb_PgId.SelectedIndex = -1;
			cmb_PgId.SelectedText = "";

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			if(cmb_PgId.SelectedIndex == -1) return;

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, fgrid_Main);

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DataTable dt_ret;

			//행 수정 상태 해제
			fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
  
			MyOraDB.Save_FlexGird("PKG_SCM_TABLE.SAVE_SCM_TABLE", fgrid_Main);

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, fgrid_Main);

		}

		 

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int i;

			fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
			
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_TABLE.IxPG_ID] = cmb_PgId.Columns[1].Text;
			fgrid_Main[fgrid_Main.Rows.Count - 1, (int)ClassLib.TBSCM_TABLE.IxPG_SEQ] = cmb_PgId.Columns[0].Text;
 

			if(fgrid_Main.Rows.Count - 1 > fgrid_Main.Rows.Fixed)
			{
				for(i = (int)ClassLib.TBSCM_TABLE.IxWIDTH; i <= (int)ClassLib.TBSCM_TABLE.IxUPD_USER; i++)
				{
					fgrid_Main[fgrid_Main.Rows.Count - 1, i] = fgrid_Main[fgrid_Main.Rows.Count - 2, i];
				}
			} 

		 

		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		 
			try
			{
				fgrid_Main.Add_Row(fgrid_Main.Selection.r1);

				fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSCM_TABLE.IxPG_ID] = cmb_PgId.Columns[1].Text;
				fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSCM_TABLE.IxPG_SEQ] = cmb_PgId.Columns[0].Text; 
 
				if(fgrid_Main.Rows.Count - 1 > fgrid_Main.Rows.Fixed)
				{
					for(int i = (int)ClassLib.TBSCM_TABLE.IxWIDTH; i <= (int)ClassLib.TBSCM_TABLE.IxUPD_USER; i++)
					{
						fgrid_Main[fgrid_Main.Selection.r1, i] = fgrid_Main[fgrid_Main.Selection.r1 - 1, i];
					}
				}
			}
			catch
			{
			}


		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Delete_Row();
		}

		private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			int sel_col = fgrid_Main.Selection.c1;

			if(sel_col != (int)ClassLib.TBSCM_TABLE.IxBACKCOLOR && sel_col != (int)ClassLib.TBSCM_TABLE.IxFORECOLOR) return;
 
			Set_Color();
			 
		}
 

		private void btn_PopPgId_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;
			Pop_SetPgId pop_form = new Pop_SetPgId();

			if(cmb_PgId.SelectedIndex == -1)
			{
				COM.ComVar.Parameter_PopUp = new string[] {"", ""};
			}
			else
			{
				COM.ComVar.Parameter_PopUp = new string[] {cmb_PgId.Columns[1].Text, cmb_PgId.Columns[0].Text };
			}

			pop_form.ShowDialog();


			// 프로그램 리스트 항목 SELECT
			//dt_ret = Select_PgList(txt_PgId.Text.Trim() );
			dt_ret = Select_PgList(COM.ComVar.Parameter_PopUp[0] );

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PgId, 1, 0, false);

 			//cmb_PgId.SelectedValue = COM.ComVar.Parameter_PopUp[1];
			//cmb_PgId.SelectedText = COM.ComVar.Parameter_PopUp[0];
 
			if(dt_ret.Rows.Count == 0) 
			{
				txt_PgId.Text = "";
			}
			else
			{
				txt_PgId.Text = COM.ComVar.Parameter_PopUp[0];
			}

			Event_KeyPress_txt_PgId(true);
   

		}
 

		private void btn_PopPgId_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopPgId.ImageIndex = 1;
		}

		private void btn_PopPgId_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopPgId.ImageIndex = 0;
		}

		
		private void btn_Create_Click(object sender, System.EventArgs e)
		{
			
			DataTable dt_ret; 
			Pop_SetCols pop_form = new Pop_SetCols();

			if(cmb_PgId.SelectedIndex == -1)
			{
				MessageBox.Show("프로그램 아이디 먼저 생성");
			}
			else
			{
				COM.ComVar.Parameter_PopUp = new string[] {cmb_PgId.Columns[1].Text, cmb_PgId.Columns[0].Text };
				pop_form.ShowDialog();
 
				dt_ret = Select_Data_List();
				Display_Grid(dt_ret, fgrid_Main);

			}
		}



		private void btn_Create_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Create.ImageIndex = 1;
		}

		private void btn_Create_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Create.ImageIndex = 0;
		}

		
	

		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			}
		}

	


		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
            int[] sct_rows = fgrid_Main.Selections;
            int sct_row = fgrid_Main.Selection.r1;
            int sct_col = fgrid_Main.Selection.c1;

            for (int i = 0; i < sct_rows.Length; i++)
            {
                fgrid_Main[sct_rows[i], sct_col] = fgrid_Main[sct_row, sct_col];
                fgrid_Main.Update_Row(sct_rows[i]);                
            }

            fgrid_Main.AutoSizeCols();
		}

 

		private void cmb_PgId_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_PgId.SelectedIndex == -1) return;
			 
			txt_PgId.Text = cmb_PgId.Columns[1].Text;

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, fgrid_Main);
			 
		}




		private void txt_PgId_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Event_KeyPress_txt_PgId(true); 
		}


		private void Event_KeyPress_txt_PgId(bool arg_enter)
		{

			if(! arg_enter) return;

			// 프로그램 리스트 항목 SELECT
			DataTable dt_ret = Select_PgList(txt_PgId.Text.Trim() );

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PgId, 1, 0, false);

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;


		}


		#endregion 

		#region DB Connect

 
		/// <summary>
		/// Select_PgId : 프로그램 아이디, 순번 리스트 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_PgList()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_PG_LIST";

			MyOraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}
  



		/// <summary>
		/// Select_PgId : 프로그램 아이디, 순번 리스트 조회
		/// </summary>
		/// <param name="arg_pg_id"></param>
		/// <returns></returns>
		private DataTable Select_PgList(string arg_pg_id)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_PG_LIST";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = arg_pg_id; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}



		/// <summary>
		/// Select_Data_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private DataTable Select_Data_List()
		{
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_COL_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_PgId.Columns[1].Text;
			MyOraDB.Parameter_Values[1] = cmb_PgId.Columns[0].Text;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
   

		}

 

		#endregion



		

		private void Form_CM_Table_Load(object sender, System.EventArgs e)
		{
			Init_Form();  
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
            {
                if (textBox1.Text.Equals(string.Empty))
                {
                    COM.ComFunction.User_Message("Pls Input enum name", "Msg");
                    textBox1.Focus();
                }
                string rs = string.Empty;
                int j = 1;
                rs += "\tIxDIVISION\t\t= 0,\n";
                for (int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
                {
                    if (i == fgrid_Main.Rows.Count - 1)
                    {
                        rs += string.Format("\tIx{0}\t\t={1}", fgrid_Main[i, 3], j);
                    }
                    else
                    {
                        rs += string.Format("\tIx{0}\t\t={1},\n", fgrid_Main[i, 3], j);
                    }
                    j++;
                }
                rs = string.Format("{0}\n{1}\n{2}", "{", rs, "}");
                rs = string.Format("public enum {0} : int\n", textBox1.Text) + rs;
                System.Windows.Forms.Clipboard.SetDataObject(rs, true);
                COM.ComFunction.User_Message(rs, "rs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fgrid_Main.Rows.Count > fgrid_Main.Rows.Fixed)
            {
                int _rowSel = fgrid_Main.RowSel;
                fgrid_Main.Add_Row(fgrid_Main.Rows.Count - 1);
                for (int i = 1; i < fgrid_Main.Cols.Count; i++)
                {
                    fgrid_Main[fgrid_Main.Rows.Count - 1, i] = fgrid_Main[_rowSel, i];
                }
                fgrid_Main[fgrid_Main.Rows.Count - 1, 4] = (fgrid_Main.Rows.Count - 2)*10;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fgrid_Main.Rows.Count; i++)
            {
                fgrid_Main[i, 0] = "I";// textBox2.Text.ToUpper();
                fgrid_Main[i, 1] = textBox2.Text.ToUpper();
                fgrid_Main[i, 2] = textBox3.Text;
            }
        }

		

		


	}
}

