using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;


namespace FlexBase.Yield
{
	public class Pop_BC_Yield_History : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		public COM.FSP fgrid_Yield;
		public System.Windows.Forms.Panel pnl_BT;
        public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.Label lbl_YieldType;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Style;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_ML;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		private System.Windows.Forms.Label btn_HistoryClear;
        private C1.Win.C1List.C1Combo cmb_YieldType;
		private System.ComponentModel.IContainer components = null;

		public Pop_BC_Yield_History()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory, _StyleCd, _YieldType;

		public Pop_BC_Yield_History(string arg_factory, string arg_style_cd, string arg_yield_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_StyleCd = arg_style_cd;
			_YieldType = arg_yield_type;

			Init_Form();


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BC_Yield_History));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_Yield = new COM.FSP();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_HistoryClear = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Comp = new System.Windows.Forms.RadioButton();
            this.rad_SG = new System.Windows.Forms.RadioButton();
            this.txt_Presto = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_YieldType = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            this.cmb_YieldType = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldType)).BeginInit();
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
            this.img_Button.Images.SetKeyName(2, "");
            this.img_Button.Images.SetKeyName(3, "");
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.fgrid_Yield);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Location = new System.Drawing.Point(0, 56);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(1016, 585);
            this.pnl_B.TabIndex = 29;
            // 
            // fgrid_Yield
            // 
            this.fgrid_Yield.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Yield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Yield.Location = new System.Drawing.Point(5, 90);
            this.fgrid_Yield.Name = "fgrid_Yield";
            this.fgrid_Yield.Rows.DefaultSize = 19;
            this.fgrid_Yield.Size = new System.Drawing.Size(1006, 490);
            this.fgrid_Yield.StyleInfo = resources.GetString("fgrid_Yield.StyleInfo");
            this.fgrid_Yield.TabIndex = 663;
            this.fgrid_Yield.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_AfterResizeColumn);
            this.fgrid_Yield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseMove);
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(5, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(1006, 90);
            this.pnl_BT.TabIndex = 44;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_YieldType);
            this.pnl_SearchImage.Controls.Add(this.btn_HistoryClear);
            this.pnl_SearchImage.Controls.Add(this.groupBox1);
            this.pnl_SearchImage.Controls.Add(this.txt_Presto);
            this.pnl_SearchImage.Controls.Add(this.txt_Gender);
            this.pnl_SearchImage.Controls.Add(this.cmb_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.lbl_Gender);
            this.pnl_SearchImage.Controls.Add(this.lbl_YieldType);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Style);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1006, 85);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // btn_HistoryClear
            // 
            this.btn_HistoryClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HistoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_HistoryClear.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_HistoryClear.ImageIndex = 2;
            this.btn_HistoryClear.ImageList = this.img_Button;
            this.btn_HistoryClear.Location = new System.Drawing.Point(744, 53);
            this.btn_HistoryClear.Name = "btn_HistoryClear";
            this.btn_HistoryClear.Size = new System.Drawing.Size(100, 23);
            this.btn_HistoryClear.TabIndex = 667;
            this.btn_HistoryClear.Text = "Clear History";
            this.btn_HistoryClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_HistoryClear.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_HistoryClear.Click += new System.EventHandler(this.btn_HistoryClear_Click);
            this.btn_HistoryClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_HistoryClear.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_HistoryClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rad_All);
            this.groupBox1.Controls.Add(this.rad_Comp);
            this.groupBox1.Controls.Add(this.rad_SG);
            this.groupBox1.Location = new System.Drawing.Point(848, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 48);
            this.groupBox1.TabIndex = 538;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree View Option";
            // 
            // rad_All
            // 
            this.rad_All.Checked = true;
            this.rad_All.Location = new System.Drawing.Point(109, 24);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(40, 16);
            this.rad_All.TabIndex = 36;
            this.rad_All.TabStop = true;
            this.rad_All.Tag = "-1";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Comp
            // 
            this.rad_Comp.Location = new System.Drawing.Point(56, 24);
            this.rad_Comp.Name = "rad_Comp";
            this.rad_Comp.Size = new System.Drawing.Size(57, 16);
            this.rad_Comp.TabIndex = 35;
            this.rad_Comp.Tag = "2";
            this.rad_Comp.Text = "Comp";
            this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_SG
            // 
            this.rad_SG.Location = new System.Drawing.Point(4, 24);
            this.rad_SG.Name = "rad_SG";
            this.rad_SG.Size = new System.Drawing.Size(52, 16);
            this.rad_SG.TabIndex = 34;
            this.rad_SG.Tag = "1";
            this.rad_SG.Text = "Semi";
            this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // txt_Presto
            // 
            this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Presto.Location = new System.Drawing.Point(570, 54);
            this.txt_Presto.MaxLength = 100;
            this.txt_Presto.Name = "txt_Presto";
            this.txt_Presto.ReadOnly = true;
            this.txt_Presto.Size = new System.Drawing.Size(125, 21);
            this.txt_Presto.TabIndex = 537;
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Gender.Location = new System.Drawing.Point(445, 54);
            this.txt_Gender.MaxLength = 100;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.Size = new System.Drawing.Size(124, 21);
            this.txt_Gender.TabIndex = 536;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AccessibleDescription = "";
            this.cmb_StyleCd.AccessibleName = "";
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style9;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style10;
            this.cmb_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.FooterStyle = style11;
            this.cmb_StyleCd.HeadingStyle = style12;
            this.cmb_StyleCd.HighLightRowStyle = style13;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(520, 32);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style14;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style15;
            this.cmb_StyleCd.Size = new System.Drawing.Size(175, 21);
            this.cmb_StyleCd.Style = style16;
            this.cmb_StyleCd.TabIndex = 532;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AccessibleDescription = "";
            this.cmb_Factory.AccessibleName = "";
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(220, 21);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 31;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_StyleCd.Location = new System.Drawing.Point(445, 32);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(74, 21);
            this.txt_StyleCd.TabIndex = 531;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(344, 54);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 530;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_YieldType
            // 
            this.lbl_YieldType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_YieldType.ImageIndex = 1;
            this.lbl_YieldType.ImageList = this.img_Label;
            this.lbl_YieldType.Location = new System.Drawing.Point(8, 54);
            this.lbl_YieldType.Name = "lbl_YieldType";
            this.lbl_YieldType.Size = new System.Drawing.Size(100, 21);
            this.lbl_YieldType.TabIndex = 529;
            this.lbl_YieldType.Text = "Yield Value Type";
            this.lbl_YieldType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 528;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Style.ImageIndex = 1;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(344, 32);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 527;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(905, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 45);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(990, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
            this.picb_TM.Size = new System.Drawing.Size(782, 40);
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
            this.lbl_SubTitle1.Text = "      Yield Infomation";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(990, 70);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 69);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(846, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 70);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(144, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(838, 53);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 52);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // img_Type
            // 
            this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
            this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Type.Images.SetKeyName(0, "");
            this.img_Type.Images.SetKeyName(1, "");
            this.img_Type.Images.SetKeyName(2, "");
            this.img_Type.Images.SetKeyName(3, "");
            this.img_Type.Images.SetKeyName(4, "");
            this.img_Type.Images.SetKeyName(5, "");
            this.img_Type.Images.SetKeyName(6, "");
            // 
            // cmb_YieldType
            // 
            this.cmb_YieldType.AccessibleDescription = "";
            this.cmb_YieldType.AccessibleName = "";
            this.cmb_YieldType.AddItemSeparator = ';';
            this.cmb_YieldType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_YieldType.Caption = "";
            this.cmb_YieldType.CaptionHeight = 17;
            this.cmb_YieldType.CaptionStyle = style1;
            this.cmb_YieldType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_YieldType.ColumnCaptionHeight = 18;
            this.cmb_YieldType.ColumnFooterHeight = 18;
            this.cmb_YieldType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_YieldType.ContentHeight = 17;
            this.cmb_YieldType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_YieldType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_YieldType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_YieldType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_YieldType.EditorHeight = 17;
            this.cmb_YieldType.EvenRowStyle = style2;
            this.cmb_YieldType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_YieldType.FooterStyle = style3;
            this.cmb_YieldType.HeadingStyle = style4;
            this.cmb_YieldType.HighLightRowStyle = style5;
            this.cmb_YieldType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_YieldType.Images"))));
            this.cmb_YieldType.ItemHeight = 15;
            this.cmb_YieldType.Location = new System.Drawing.Point(109, 54);
            this.cmb_YieldType.MatchEntryTimeout = ((long)(2000));
            this.cmb_YieldType.MaxDropDownItems = ((short)(5));
            this.cmb_YieldType.MaxLength = 32767;
            this.cmb_YieldType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_YieldType.Name = "cmb_YieldType";
            this.cmb_YieldType.OddRowStyle = style6;
            this.cmb_YieldType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_YieldType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_YieldType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_YieldType.SelectedStyle = style7;
            this.cmb_YieldType.Size = new System.Drawing.Size(220, 21);
            this.cmb_YieldType.Style = style8;
            this.cmb_YieldType.TabIndex = 668;
            this.cmb_YieldType.PropBag = resources.GetString("cmb_YieldType.PropBag");
            // 
            // Pop_BC_Yield_History
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_B);
            this.Name = "Pop_BC_Yield_History";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_B, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		// 행 이미지 저장
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();
 
		
		// type division
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J", _TypeVersion = "V";

		// 행 이미지 번호
		private int _IxImage_SG = 0, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4, _IxImage_Version = 6; 
 

		// 사이즈 자재인 경우 Specification 처리
		private string _SizeSpecName = "Size";

		// 사이즈 자재인 경우 Specification Code 별 색깔 구분 
		private Color _Color_SizeSpecOdd = ClassLib.ComVar.ClrSel_Green;
		private Color _Color_SizeSpecEven = ClassLib.ComVar.ClrSel_Yellow; 
		private Color _Color_SizeSpecCurrent;

		// component cd level
		private const int _CmpLevel = 2;


		#endregion

		#region 멤버 메소드
 

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
			 
				//Title
				this.Text = "Yield History";
				lbl_MainTitle.Text = "Yield History";

				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정
				fgrid_Yield.Set_Grid("SBC_YIELD_HISTORY", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
 
				
				//fgrid_Yield.Styles.Alternate.BackColor = Color.Empty;
				fgrid_Yield.Styles.Frozen.BackColor = Color.Empty; 

				//fgrid_Yield.SelectionMode = SelectionModeEnum.Cell; 
				fgrid_Yield.AllowDragging = AllowDraggingEnum.None;
  

				//combobox setting
				Init_Control(); 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			// toolbar button disable setting
			tbtn_Save.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Print.Enabled = false;
			tbtn_Confirm.Enabled = false;
 

			// 공장코드
			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = _Factory;
 


			// Value Type ComboBox Add Items 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldType);
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_YieldType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_YieldType.SelectedValue = _YieldType; 
	    
				
			// Style Code
			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_String(_StyleCd, " ") );  
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200);  
			cmb_StyleCd.SelectedValue = _StyleCd;
			txt_StyleCd.Text = _StyleCd; 


			dt_ret.Dispose();

		}

		 
		
		/// <summary>
		/// Clear_Control : 컨트롤 초기화
		/// </summary>
		private void Clear_Control()
		{
			cmb_Factory.SelectedIndex = -1; 
			cmb_YieldType.SelectedIndex = -1; 
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1;
			txt_Gender.Text = "";
			txt_Presto.Text = "";


			fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
			fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START;

		}


		/// <summary>
		/// Search_Yield : 채산값 조회
		/// </summary>
		private void Search_Yield()
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldType.SelectedIndex == -1) return;

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;


				//-----------------------------------------------------------------------------------------------
				//데이터 리스트 추출
				DataTable dt_ret;
				dt_ret = Select_Yield(cmb_Factory.SelectedValue.ToString(), 
								      cmb_StyleCd.SelectedValue.ToString().Replace("-", ""),
									  cmb_YieldType.SelectedValue.ToString() );
				//-----------------------------------------------------------------------------------------------
				
				//-----------------------------------------------------------------------------------------------
				//데이터 그리드로 표시
				fgrid_Yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_HISTORY.IxTREE;

				fgrid_Yield.Display_CrossTab(dt_ret, 
											(int)ClassLib.TBSBC_YIELD_HISTORY.IxKEY1 - 1, 
											(int)ClassLib.TBSBC_YIELD_HISTORY.IxKEY2 - 1, 
											(int)ClassLib.TBSBC_YIELD_HISTORY.IxCOL_NUM, 
											(int)ClassLib.TBSBC_YIELD_HISTORY.IxYIELD_VALUE, 
											(int)ClassLib.TBSBC_YIELD_HISTORY.IxSPEC_NAME - 1,
					                        true) ;

				//-----------------------------------------------------------------------------------------------

				//-----------------------------------------------------------------------------------------------
				//그리드 행 이미지, 사이즈 자재 색깔 표시
				_Imgmap.Clear();


				for(int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
				{

					// 사이즈 자재 표시
					Display_Size_Material(i); 

					// 이미지 표시
					Display_Type_Image(i);

				} // end for i
  
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_HISTORY.IxTREE].ImageAndText = true; 
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_HISTORY.IxTREE].ImageMap = _Imgmap;  
				//-----------------------------------------------------------------------------------------------
				
				rad_Comp.Checked = true;
				fgrid_Yield.Tree.Show(_CmpLevel);


				dt_ret.Dispose();

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Yield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		} 

		 
		/// <summary>
		/// Display_Size_Material : 사이즈 자재 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Size_Material(int arg_row)
		{
			string before_spec = "", now_spec = "";
			int size_f = -1, size_t = -1;


			_Color_SizeSpecCurrent = _Color_SizeSpecEven;

			if(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_HISTORY.IxSIZE_YN] != null
				&& fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_HISTORY.IxSIZE_YN].ToString() == "Y")
			{

				// spec 세팅 
				fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_HISTORY.IxSPEC_NAME] = _SizeSpecName; 
				 
				
				for(int i = 1; i < (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START; i++)
				{
					fgrid_Yield.GetCellRange(arg_row, i).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
				}
				
				 


				size_f = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START;

				CellRange cr = fgrid_Yield.GetCellRange(arg_row, size_f); 
				if(fgrid_Yield[arg_row, size_f] == null || cr.UserData == null) return;

				while(true)
				{
					CellRange cr_b = fgrid_Yield.GetCellRange(arg_row, size_f);  
					before_spec = (cr_b.UserData == null ) ? "" : cr_b.UserData.ToString(); 

					for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
					{  
						CellRange cr_n = fgrid_Yield.GetCellRange(arg_row, k);  
						now_spec = (cr_n.UserData == null ) ? "" : cr_n.UserData.ToString(); 

						if(before_spec == now_spec)
						{
							size_t = k;
						}
						else
						{
							break;
						}

					}
 


					//SPEC CODE 별 색깔 표시
					if(_Color_SizeSpecCurrent.Equals(_Color_SizeSpecOdd) )
					{
						_Color_SizeSpecCurrent = _Color_SizeSpecEven;
					}
					else
					{
						_Color_SizeSpecCurrent = _Color_SizeSpecOdd;
					}


					for(int i = size_f; i <= size_t; i++)
					{
						fgrid_Yield.GetCellRange(arg_row, i).StyleNew.BackColor = _Color_SizeSpecCurrent;
					}
 


					size_f = size_t + 1;

					if(size_f == fgrid_Yield.Cols.Count) break;

				} // end while

				 



			}

 

		}


		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{


			string tree_desc = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_HISTORY.IxTREE].ToString();
			string type = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_HISTORY.IxTYPE_DIVISION].ToString();
			 


			switch(type)
			{ 		
				case _TypeSG:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					break; 

				case _TypeCmp:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					break;

				case _TypeMat:
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
					break;
				
				case _TypeJoint:
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
					break; 

 
			} // end switch


 



			


			if(_Imgmap.ContainsKey(tree_desc) ) return;
			 

			switch(type)
			{ 		
				case _TypeSG:  
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Joint]);
					break;

				case _TypeVersion:
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Version]);
					break; 

			} // end switch





		}



		/// <summary>
		/// Clear_History : 채산 히스토리 version 일괄 삭제
		/// </summary>
		private void Clear_History()
		{
			Pop_Yield_History_Clear pop_form = new Pop_Yield_History_Clear(cmb_Factory.SelectedValue.ToString(),
				                                                           cmb_StyleCd.SelectedValue.ToString() );

			pop_form.ShowDialog();

		}



		#endregion

		#region 이벤트 처리

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Clear_Control();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Search_Yield();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = "";
				txt_Presto.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START;
				//-------------------------------------------------------------------------

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 
 

				string stylecd = "";
				int exist_index = -1;

				stylecd = txt_StyleCd.Text.Trim();

				exist_index = txt_StyleCd.Text.IndexOf("-", 0);

				if(exist_index == -1 && stylecd.Length == 9)
				{
					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
				}
 
				cmb_StyleCd.SelectedValue = stylecd;

				dt_ret.Dispose();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				txt_Gender.Text = "";
				txt_Presto.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START;
				//-------------------------------------------------------------------------


				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
				txt_Gender.Text = cmb_StyleCd.Columns[2].Text;
				txt_Presto.Text = cmb_StyleCd.Columns[3].Text; 

				//size 세팅
				fgrid_Yield.Display_Size_ColHead(cmb_Factory.SelectedValue.ToString(), 
													cmb_StyleCd.SelectedValue.ToString().Replace("-", ""), 
													60,
													(int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START);


				// number 형 셀타입 설정 (예 : 1,234,567.001)
				for(int i = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count - 1; i++)
				{
					fgrid_Yield.Set_CellStyle_Number(i);
				}

				fgrid_Yield.AllowEditing = false; 
 
//				// 데이터 조회
//				Search_Yield();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_YieldType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_YieldType.SelectedIndex == -1) return;
  
				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_YieldType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// tree view depth 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				//라디오 버튼 태그값에 레벨값 세팅
				//rad_semi.tag = '1'
				//rad_cmp.tag = '2'
				//rad_all.tag = '-1'

				fgrid_Yield.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


 
		private void btn_HistoryClear_Click(object sender, System.EventArgs e)
		{
			try
			{
				Clear_History();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_HistoryClear_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#region show tooltip if the text is too long to fit the cell 


		// show tooltip if the text is too long to fit the cell (1)
		System.Windows.Forms.ToolTip _ttip;
		int _lastRow = 0, _lastCol = 0;

		private void _flex_MouseMoveTooltip(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			string text = null;
			if (e.Button == MouseButtons.None)
			{
				// get mouse coordinates
				int row = fgrid_Yield.MouseRow;
				int col = fgrid_Yield.MouseCol;

				// save work if we can
				if (row == _lastRow && col == _lastCol)
					return;

				// save info for next time
				_lastRow = row;
				_lastCol = col;

				// get text for tooltip
				if (row > -1 && col > -1)
				{
					// get display text
					text = fgrid_Yield.GetDataDisplay(row, col);

					// get display rectangle
					Rectangle rc = fgrid_Yield.GetCellRect(row, col, false);
					rc.Intersect(fgrid_Yield.ClientRectangle);

					// measure text
					using (Graphics g = fgrid_Yield.CreateGraphics())
					{
						CellStyle s = fgrid_Yield.GetCellStyleDisplay(row, col);
						float wid = g.MeasureString(text, s.Font).Width;

						if(col == (int)ClassLib.TBSBC_YIELD_HISTORY.IxTREE)
						{
							wid += s.Margins.Left + s.Margins.Right + s.Border.Width + 70;  // 70 : tree 표시 앞 공백 계산
						}
						else
						{
							wid += s.Margins.Left + s.Margins.Right + s.Border.Width;
						}

						if (wid < rc.Width) text = null;
					}
				}


			}

			// create tooltip if we need it
			if (text != null && _ttip == null)
			{
				_ttip = new ToolTip();
			}

			// set tooltip text
			if (_ttip != null && _ttip.GetToolTip(fgrid_Yield) != text)
				_ttip.SetToolTip(fgrid_Yield, text);


		}


		#endregion



		private void fgrid_Yield_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			//if(! chk_CheckInOut.Checked) return;


			try
			{

				//---------------------------------------------------------------------------
				// show tooltip
				//---------------------------------------------------------------------------
				_flex_MouseMoveTooltip(sender, e); 
				//--------------------------------------------------------------------------- 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_MouseMove", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void fgrid_Yield_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if(e.Col < (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START) return;

			for(int i = (int)ClassLib.TBSBC_YIELD_HISTORY.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
			{
				fgrid_Yield.Cols[i].Width = fgrid_Yield.Cols[e.Col].Width;
			}


		}


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  

		#endregion

		#region DB Connect


		/// <summary>
		/// Select_Yield : 채산 리스트 조회
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_yieldtype"></param>
		/// <returns></returns>
		private DataTable Select_Yield(string arg_factory, string arg_stylecd, string arg_yieldtype)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_HISTORY";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_YIELD_TYPE";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = arg_yieldtype; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		#endregion 

	 




	}
}

