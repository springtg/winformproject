using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

using C1.C1Excel;


namespace FlexCDC.FlexAPS.ProdSheet
{
	public class Form_PD_MPSByOP : COM.APSWinForm.Form_Top
	{ 
		
		#region 컨트롤 정의 및 리소스 정리

        public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_LineType;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
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
        private C1.Win.C1List.C1Combo cmb_LineGroup;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.TextBox txt_StyleCd;
        private COM.FSP fgrid_MPS;
        private GroupBox groupBox1;
        private Label lbl_VirtualLOT;
        private Label lbl_DirLOT;
        private Label lbl_RealLOT;
        private SaveFileDialog saveFileDialog1;
		private System.ComponentModel.IContainer components = null;

		public Form_PD_MPSByOP()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PD_MPSByOP));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_VirtualLOT = new System.Windows.Forms.Label();
            this.lbl_DirLOT = new System.Windows.Forms.Label();
            this.lbl_RealLOT = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_LineGroup = new C1.Win.C1List.C1Combo();
            this.lbl_LineType = new System.Windows.Forms.Label();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_MPS = new COM.FSP();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MPS)).BeginInit();
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // btn_Manual
            // 
            //this.btn_Manual.Location = new System.Drawing.Point(665, 18);
            //// 
            //// img_Manual
            //// 
            //this.img_Manual.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Manual.ImageStream")));
            //this.img_Manual.Images.SetKeyName(0, "Btn_manual_n.bmp");
            //this.img_Manual.Images.SetKeyName(1, "Btn_manual_c.bmp");
            //// 
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.groupBox1);
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 80);
            this.pnl_Search.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_VirtualLOT);
            this.groupBox1.Controls.Add(this.lbl_DirLOT);
            this.groupBox1.Controls.Add(this.lbl_RealLOT);
            this.groupBox1.Location = new System.Drawing.Point(800, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 32);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // lbl_VirtualLOT
            // 
            this.lbl_VirtualLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(166)))));
            this.lbl_VirtualLOT.Location = new System.Drawing.Point(70, 11);
            this.lbl_VirtualLOT.Name = "lbl_VirtualLOT";
            this.lbl_VirtualLOT.Size = new System.Drawing.Size(65, 15);
            this.lbl_VirtualLOT.TabIndex = 76;
            this.lbl_VirtualLOT.Text = "Finished";
            this.lbl_VirtualLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DirLOT
            // 
            this.lbl_DirLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbl_DirLOT.Location = new System.Drawing.Point(5, 11);
            this.lbl_DirLOT.Name = "lbl_DirLOT";
            this.lbl_DirLOT.Size = new System.Drawing.Size(65, 15);
            this.lbl_DirLOT.TabIndex = 75;
            this.lbl_DirLOT.Text = "Released";
            this.lbl_DirLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RealLOT
            // 
            this.lbl_RealLOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lbl_RealLOT.Location = new System.Drawing.Point(135, 11);
            this.lbl_RealLOT.Name = "lbl_RealLOT";
            this.lbl_RealLOT.Size = new System.Drawing.Size(65, 15);
            this.lbl_RealLOT.TabIndex = 73;
            this.lbl_RealLOT.Text = "Planning";
            this.lbl_RealLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.lbl_Style);
            this.pnl_SearchImage.Controls.Add(this.cmb_LineGroup);
            this.pnl_SearchImage.Controls.Add(this.lbl_LineType);
            this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
            this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
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
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_StyleCd.Location = new System.Drawing.Point(890, 36);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(100, 21);
            this.txt_StyleCd.TabIndex = 198;
            this.txt_StyleCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StyleCd_KeyPress);
            // 
            // lbl_Style
            // 
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(789, 36);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 197;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_LineGroup
            // 
            this.cmb_LineGroup.AddItemSeparator = ';';
            this.cmb_LineGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LineGroup.Caption = "";
            this.cmb_LineGroup.CaptionHeight = 17;
            this.cmb_LineGroup.CaptionStyle = style1;
            this.cmb_LineGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LineGroup.ColumnCaptionHeight = 18;
            this.cmb_LineGroup.ColumnFooterHeight = 18;
            this.cmb_LineGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LineGroup.ContentHeight = 17;
            this.cmb_LineGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LineGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LineGroup.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LineGroup.EditorHeight = 17;
            this.cmb_LineGroup.EvenRowStyle = style2;
            this.cmb_LineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LineGroup.FooterStyle = style3;
            this.cmb_LineGroup.HeadingStyle = style4;
            this.cmb_LineGroup.HighLightRowStyle = style5;
            this.cmb_LineGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_LineGroup.Images"))));
            this.cmb_LineGroup.ItemHeight = 15;
            this.cmb_LineGroup.Location = new System.Drawing.Point(669, 36);
            this.cmb_LineGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_LineGroup.MaxDropDownItems = ((short)(5));
            this.cmb_LineGroup.MaxLength = 32767;
            this.cmb_LineGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LineGroup.Name = "cmb_LineGroup";
            this.cmb_LineGroup.OddRowStyle = style6;
            this.cmb_LineGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LineGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LineGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LineGroup.SelectedStyle = style7;
            this.cmb_LineGroup.Size = new System.Drawing.Size(100, 21);
            this.cmb_LineGroup.Style = style8;
            this.cmb_LineGroup.TabIndex = 194;
            this.cmb_LineGroup.SelectedValueChanged += new System.EventHandler(this.cmb_LineGroup_SelectedValueChanged);
            this.cmb_LineGroup.PropBag = resources.GetString("cmb_LineGroup.PropBag");
            // 
            // lbl_LineType
            // 
            this.lbl_LineType.ImageIndex = 0;
            this.lbl_LineType.ImageList = this.img_Label;
            this.lbl_LineType.Location = new System.Drawing.Point(568, 36);
            this.lbl_LineType.Name = "lbl_LineType";
            this.lbl_LineType.Size = new System.Drawing.Size(100, 21);
            this.lbl_LineType.TabIndex = 193;
            this.lbl_LineType.Text = "Line";
            this.lbl_LineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
            this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(449, 36);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_ToYMD.TabIndex = 192;
            this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
            this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(332, 36);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_FromYMD.TabIndex = 191;
            this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(434, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 0;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(231, 36);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_PlanYMD.TabIndex = 72;
            this.lbl_PlanYMD.Text = "Plan Date";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style9;
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
            this.cmb_Factory.EvenRowStyle = style10;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style11;
            this.cmb_Factory.HeadingStyle = style12;
            this.cmb_Factory.HighLightRowStyle = style13;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style14;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style15;
            this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
            this.cmb_Factory.Style = style16;
            this.cmb_Factory.TabIndex = 34;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 32;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 32);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 16);
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
            this.lbl_SubTitle1.Text = "      Selected Information";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(984, 48);
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
            // img_SmallLabel
            // 
            this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
            this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallLabel.Images.SetKeyName(0, "");
            this.img_SmallLabel.Images.SetKeyName(1, "");
            this.img_SmallLabel.Images.SetKeyName(2, "");
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_MPS);
            this.pnl_Body.Location = new System.Drawing.Point(0, 144);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 496);
            this.pnl_Body.TabIndex = 38;
            // 
            // fgrid_MPS
            // 
            this.fgrid_MPS.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_MPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MPS.Location = new System.Drawing.Point(8, 0);
            this.fgrid_MPS.Name = "fgrid_MPS";
            this.fgrid_MPS.Rows.DefaultSize = 19;
            this.fgrid_MPS.Size = new System.Drawing.Size(1000, 496);
            this.fgrid_MPS.StyleInfo = resources.GetString("fgrid_MPS.StyleInfo");
            this.fgrid_MPS.TabIndex = 0;
            this.fgrid_MPS.Click += new System.EventHandler(this.fgrid_MPS_Click);
            // 
            // Form_PD_MPSByOP
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_PD_MPSByOP";
            this.Text = "MPS (Master Plan Schedule) ";
            this.Load += new System.EventHandler(this.Form_PD_MPSByOP_Load);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            //this.Controls.SetChildIndex(this.btn_Manual, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MPS)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		private int _TBDay_Row = 0;
		private int _Month_Row = 1;
		private int _Day_Row = 2;



        //----------------------------------------------
        // 선적 구간 표시
        //---------------------------------------------- 
        private string _ShipDateF_20 = "";  // 선적중
        private string _ShipDateT_20 = "";
        private string _ShipDateF_30 = "";  // 선적준비중
        private string _ShipDateT_30 = "";
        private string _ShipDateF_40 = "";  // 다음 선적 진행중
        private string _ShipDateT_40 = "";
        private string _ShipDateF_50 = "";  // Free 구간
        private string _ShipDateT_50 = "";

        Color _ClrShipDate_20;
        Color _ClrShipDate_30;
        Color _ClrShipDate_40;

        private string _WarningShippingDateF = "";  // 다음 선적 진행 구간 + n일 처리
        private string _WarningShippingDateT = "";

        private int _WarningShippingDateF_Col = -1;
        private int _WarningShippingDateT_Col = -1;

        private int _Display_Next_Shipping_Area_Count = 3;
        private int _WarningLineCapa = 2000;
        //----------------------------------------------




		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
			
				//Title
				this.Text = "MPS (Master Plan Schedule)";
				lbl_MainTitle.Text = "MPS (Master Plan Schedule)"; 

				fgrid_MPS.Set_Grid("SPD_WORKSHEET_MPS_BSC", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_MPS.ExtendLastCol = false;
				fgrid_MPS.AllowEditing = false;
				fgrid_MPS.AllowSorting = AllowSortingEnum.None;
				fgrid_MPS.AllowDragging = AllowDraggingEnum.None;
				fgrid_MPS.Font = new Font("Verdana", 7); 
				fgrid_MPS.Styles.Alternate.BackColor = Color.White;
				fgrid_MPS.SelectionMode = SelectionModeEnum.Default;
 

				Init_Control();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  
			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false; 

			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			 

			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            dt_ret.Dispose();
            cmb_Factory.SelectedValue = ClassLib.ComFunction.Set_Default_Factory();


		}  



		#endregion
		  
		#region 조회

 
		/// <summary>
		/// Set_Grid_Date : 조회 일자에 걸리는 날짜 세팅
		/// </summary>
		private void Set_Grid_Date()
		{
			

			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;


				// shipping area 이후 3일 표시하기 위함
				int next_shipping_count = 0;


				string factory = cmb_Factory.SelectedValue.ToString();
				string from_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string to_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
				DataTable dt_ret = Select_OPSIZE_MPS_YMD(factory, from_ymd, to_ymd);
 
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
				fgrid_MPS.Cols.Count = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START + 1;
				fgrid_MPS.Cols.Count = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START + dt_ret.Rows.Count;

				
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Width = 40;
					fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].TextAlign = TextAlignEnum.RightCenter;
 
					//실제 날짜 표시
					fgrid_MPS[_TBDay_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString();
 
				 
					fgrid_MPS[_Month_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(0, 4)
						+ ClassLib.ComVar.This_SetedDateSign
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(4, 2);


					fgrid_MPS[_Day_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(6, 2);


					//fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Style.Clear();

					//휴일 색깔 처리
					if(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_HOLI_YN].ToString() == "Y")
					{
						fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
						fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Width = 20;

						CellRange cr = fgrid_MPS.GetCellRange(0, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START);
						cr.UserData = "Y";

					}
					else
					{


						//-----------------------------------------------------------------------------
						// 1. 30 : shipping area
						// 2. 40 : next shipping area
						// 3. 마지막 shipping area 일자 + 3일 (휴일제외)
						//-----------------------------------------------------------------------------
						int now_ymd = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString() );

						// 1. 30 : shipping area
						if(_ShipDateF_30 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_30) && now_ymd < Convert.ToInt32(_ShipDateF_40) )
						{
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = _ClrShipDate_30;
						}
							// 2. 40 : next shipping area
						else if(_ShipDateF_40 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_40) && now_ymd < Convert.ToInt32(_ShipDateF_50) )
						{
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = _ClrShipDate_40; 
						} 
							// 3. 마지막 shipping area 일자 + 3일 (휴일제외) 
						else if(_ShipDateF_40 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_50) && next_shipping_count < _Display_Next_Shipping_Area_Count)
						{
 
							// 선적 warning 표시 구간 from
							if(next_shipping_count == 0) 
							{
								_WarningShippingDateF_Col = i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
								_WarningShippingDateF = now_ymd.ToString();
							}
							
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = ClassLib.ComVar.ClrOA;
							next_shipping_count++;

							// 선적 warning 표시 구간 to
							if(next_shipping_count == _Display_Next_Shipping_Area_Count)
							{
								_WarningShippingDateT_Col = i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
								_WarningShippingDateT = now_ymd.ToString();
							}

						}  
						else
						{  
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Style.Clear();
						}
						//-----------------------------------------------------------------------------

					}


				}

				fgrid_MPS.AllowMerging = AllowMergingEnum.FixedOnly;
				fgrid_MPS.Rows[_Month_Row].AllowMerging = true;
				fgrid_MPS.Cols.Frozen = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Grid_Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		/// <summary>
		/// Display_Head : 
		/// </summary>
		/// <param name="dt_ret"></param>
		private void Display_Head(DataTable arg_dt)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
				fgrid_MPS.Rows.InsertRange(fgrid_MPS.Rows.Fixed, arg_dt.Rows.Count);
				
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					for(int j = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_CD; j < (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; j++)
					{
						fgrid_MPS[i + fgrid_MPS.Rows.Fixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
					}
				} 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Display_Detail : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Detail(DataTable arg_dt)
		{
			int findrow = 0;
			int findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
			string beforelot = "", findlot = ""; 
			//int sum = 0;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					findlot = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_LOT].ToString();
					findrow = fgrid_MPS.FindRow(findlot, fgrid_MPS.Rows.Fixed, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT, false, true, false);
					if(findrow == -1) continue;
 
					if(beforelot != findlot)
					{ 
						findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
						//sum = 0;
						beforelot = findlot;
					}

					
					for(int j = findcol; j < fgrid_MPS.Cols.Count; j++)
					{
						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_OP_STR_YMD].ToString() == fgrid_MPS[_TBDay_Row, j].ToString())
						{
							fgrid_MPS[findrow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_SIZE_QTY].ToString();
							//sum += Convert.ToInt32(fgrid_MPS[findrow, j].ToString());
							findcol = j;

							// 작업지시 나가지 않은 일자에 대해서 색깔 표시 (Real, Virtual LOT)
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_PLAN_STATUS].ToString() == "L")
							{


								//rgac deadline date 에 걸린 일자 색깔 표시
								if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_DEADLINE_YN].ToString().ToString() == "Y")
								{
									////fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrWarning;
									//fgrid_MPS.GetCellRange(findrow, j).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;	
									fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRealLOT;	
								}
								else
								{
									// Real LOT
									if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_REAL_LOTYN].ToString() == "Y")
									{
										fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRealLOT;
									}
										// Virtual LOT
									else
									{
										fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
									}
								}
 

								// finished 표시
								if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_TS_FINISH_YN].ToString() == "Y")
								{
									fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;	
								}


							}
								// 작업지시 이후의 상태
							else
							{ 
								fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							} 

							break;
						}
					} // end for j


					//fgrid_MPS[findrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY] = sum.ToString();

				} // end for i
 

				//--------------------------------------------------------------
				//Merge 속성
				fgrid_MPS.AllowMerging = AllowMergingEnum.Free; 

				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxORD_QTY].AllowMerging = false;
				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOSS_QTY].AllowMerging = false;
				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY].AllowMerging = false;

				for(int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++)
					fgrid_MPS.Cols[i].AllowMerging = false;
    
				//-------------------------------------------------------------- 
				// 총합 계산  
				fgrid_MPS.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
				fgrid_MPS.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
				//fgrid_MPS.Styles[CellStyleEnum.Subtotal0].Font = new Font(fgrid_MPS.Styles[CellStyleEnum.Subtotal0].Font, FontStyle.Bold);
				fgrid_MPS.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
				fgrid_MPS.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
				//fgrid_MPS.Styles[CellStyleEnum.Subtotal1].Font = new Font(fgrid_MPS.Styles[CellStyleEnum.Subtotal1].Font, FontStyle.Bold);

				fgrid_MPS.Tree.Column = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME;
				fgrid_MPS.SubtotalPosition = SubtotalPositionEnum.BelowData; 
				fgrid_MPS.Subtotal(AggregateEnum.Clear); 
 
				for (int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++) 
					fgrid_MPS.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_CD, i, "Summary");

				for (int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++) 
					fgrid_MPS.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");
	 


				this.Cursor = Cursors.Default;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
			fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
  

			DataSet ds_ret;
			DataTable dt_h, dt_d;

			 
			if(cmb_Factory.SelectedIndex == -1 || dpick_FromYMD.CustomFormat == " " || dpick_ToYMD.CustomFormat == " ") return;


			//조회 일자에 걸리는 날짜 세팅
			Set_Grid_Date();

			string factory = cmb_Factory.SelectedValue.ToString();
			string from_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string to_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Trim().Replace("-", ""), " ");


            ds_ret = Select_OPSIZE_MPS_FGA(factory, from_ymd, to_ymd, line_group, style_cd);

			dt_h = ds_ret.Tables[0];
			dt_d = ds_ret.Tables[1];
			Display_Head(dt_h);
			Display_Detail(dt_d); 


		}


        // 256 컬럼 이상 엑셀 저장 할 때, 
        //private C1XLBook _book = new C1XLBook();



		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{



            #region 256 컬럼 이상 엑셀 저장 할 때, 



            //saveFileDialog1.Filter = "Excel 파일|*.xls";

            //if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            ////XLSheet sheet = _book.Sheets.Add(fgrid_MPS.Name);
            ////SaveSheet(fgrid_MPS, sheet, false);
            //SaveSheet(fgrid_MPS, 200);

          
            //// save the book
            //_book.Save(saveFileDialog1.FileName);



            #endregion




            saveFileDialog1.Filter = "Excel 파일|*.xls";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;


            if (saveFileDialog1.FileName != "")
            {

                fgrid_MPS.SaveExcel(saveFileDialog1.FileName, FileFlags.IncludeFixedCells);

                ClassLib.ComFunction.User_Message("Complete Save to Excel file.", "MPS (Master Plan Schedule)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


           

  

		}



        #region ** Save a C1FlexGrid into an XLSheet


        //Hashtable _styles;



        //private void SaveSheet(C1FlexGrid flex, XLSheet sheet, bool fixedCells)
        //{
        //    // account for fixed cells
        //    int frows = flex.Rows.Fixed;
        //    int fcols = flex.Cols.Fixed;
        //    if (fixedCells) frows = fcols = 0;

        //    // copy dimensions
        //    int lastRow = flex.Rows.Count - frows - 1;
        //    int lastCol = flex.Cols.Count - fcols - 1;
        //    if (lastRow < 0 || lastCol < 0) return;
        //    XLCell cell = sheet[lastRow, lastCol];

        //    // set default properties
        //    sheet.Book.DefaultFont = flex.Font;
        //    sheet.DefaultRowHeight = C1XLBook.PixelsToTwips(flex.Rows.DefaultSize);
        //    sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(flex.Cols.DefaultSize);

        //    // prepare to convert styles
        //    _styles = new Hashtable();

        //    // set row/column properties
        //    for (int r = frows; r < flex.Rows.Count; r++)
        //    {
        //        // size/visibility
        //        Row fr = flex.Rows[r];
        //        XLRow xr = sheet.Rows[r - frows];
        //        if (fr.Height >= 0)
        //            xr.Height = C1XLBook.PixelsToTwips(fr.Height);
        //        xr.Visible = fr.Visible;

        //        // style
        //        XLStyle xs = StyleFromFlex(fr.Style);
        //        if (xs != null)
        //            xr.Style = xs;
        //    }
        //    for (int c = fcols; c < flex.Cols.Count; c++)
        //    {
        //        // size/visibility
        //        Column fc = flex.Cols[c];
        //        XLColumn xc = sheet.Columns[c - fcols];
        //        if (fc.Width >= 0)
        //            xc.Width = C1XLBook.PixelsToTwips(fc.Width);
        //        xc.Visible = fc.Visible;

        //        // style
        //        XLStyle xs = StyleFromFlex(fc.Style);
        //        if (xs != null)
        //            xc.Style = xs;
        //    }

        //    // load cells
        //    for (int r = frows; r < flex.Rows.Count; r++)
        //    {
        //        for (int c = fcols; c < flex.Cols.Count; c++)
        //        {
        //            // get cell
        //            cell = sheet[r - frows, c - fcols];

        //            // apply content
        //            cell.Value = flex[r, c];

        //            // apply style
        //            XLStyle xs = StyleFromFlex(flex.GetCellStyle(r, c));
        //            if (xs != null)
        //                cell.Style = xs;
        //        }
        //    }


        //}




        //private void SaveSheet(C1FlexGrid flex, int save_range)
        //{
        //    // account for fixed cells
        //    int frows = flex.Rows.Fixed;
        //    int fcols = flex.Cols.Fixed;
        //    frows = fcols = 0;

        //    // copy dimensions
        //    int lastRow = flex.Rows.Count - frows - 1;

        //    int firstCol = fcols;
        //    int lastCol = flex.Cols.Count - fcols - 1;
        //    int save_count = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(lastCol) / Convert.ToDouble(save_range)));

        //    if (lastRow < 0 || lastCol < 0) return;



        //    // clear book
        //    _book.Clear();
        //    _book.Sheets.Clear();
             


        //    for (int x = 0; x < save_count; x++)
        //    {

        //        lastCol = save_range * (x + 1);

        //        if (lastCol > flex.Cols.Count - fcols - 1)
        //        {
        //            lastCol = flex.Cols.Count - fcols - 1;
        //        }


        //        XLSheet sheet = _book.Sheets.Add("MPS_" + x.ToString());
        //        XLCell cell = sheet[lastRow, (lastCol - firstCol + 1)];

        //        // set default properties
        //        sheet.Book.DefaultFont = flex.Font;
        //        sheet.DefaultRowHeight = C1XLBook.PixelsToTwips(flex.Rows.DefaultSize);
        //        sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(flex.Cols.DefaultSize);

        //        // prepare to convert styles
        //        _styles = new Hashtable();

        //        // set row/column properties
        //        for (int r = frows; r < flex.Rows.Count; r++)
        //        {
        //            // size/visibility
        //            Row fr = flex.Rows[r];
        //            XLRow xr = sheet.Rows[r - frows];
        //            if (fr.Height >= 0)
        //                xr.Height = C1XLBook.PixelsToTwips(fr.Height);
        //            xr.Visible = fr.Visible;

        //            // style
        //            XLStyle xs = StyleFromFlex(fr.Style);
        //            if (xs != null)
        //                xr.Style = xs;
        //        }
        //        for (int c = firstCol; c < lastCol; c++)
        //        {
        //            // size/visibility
        //            Column fc = flex.Cols[c];
        //            XLColumn xc = sheet.Columns[c - firstCol];
        //            if (fc.Width >= 0)
        //                xc.Width = C1XLBook.PixelsToTwips(fc.Width);
        //            xc.Visible = fc.Visible;

        //            // style
        //            XLStyle xs = StyleFromFlex(fc.Style);
        //            if (xs != null)
        //                xc.Style = xs;
        //        }

        //        // load cells
        //        for (int r = frows; r < flex.Rows.Count; r++)
        //        {
        //            for (int c = firstCol; c < lastCol; c++)
        //            {
        //                // get cell
        //                cell = sheet[r - frows, c - firstCol];

        //                // apply content
        //                cell.Value = flex[r, c];

        //                // apply style
        //                XLStyle xs = StyleFromFlex(flex.GetCellStyle(r, c));
        //                if (xs != null)
        //                    cell.Style = xs;
        //            }
        //        }


        //        firstCol = lastCol;


        //    } // end for save_count


            


        //}





        //// convert FlexGrid style into Excel style
        //private XLStyle StyleFromFlex(CellStyle style)
        //{
        //    // sanity
        //    if (style == null)
        //        return null;

        //    // look it up on list
        //    if (_styles.Contains(style))
        //        return _styles[style] as XLStyle;

        //    // create new Excel style
        //    XLStyle xs = new XLStyle(_book);

        //    // set up new style
        //    xs.Font = style.Font;
        //    if (style.BackColor.ToArgb() != SystemColors.Window.ToArgb())
        //    {
        //        xs.BackColor = style.BackColor;
        //    }
        //    xs.WordWrap = style.WordWrap;
        //    xs.Format = XLStyle.FormatDotNetToXL(style.Format);
        //    switch (style.TextDirection)
        //    {
        //        case TextDirectionEnum.Up:
        //            xs.Rotation = 90;
        //            break;
        //        case TextDirectionEnum.Down:
        //            xs.Rotation = 180;
        //            break;
        //    }
        //    switch (style.TextAlign)
        //    {
        //        case TextAlignEnum.CenterBottom:
        //            xs.AlignHorz = XLAlignHorzEnum.Center;
        //            xs.AlignVert = XLAlignVertEnum.Bottom;
        //            break;
        //        case TextAlignEnum.CenterCenter:
        //            xs.AlignHorz = XLAlignHorzEnum.Center;
        //            xs.AlignVert = XLAlignVertEnum.Center;
        //            break;
        //        case TextAlignEnum.CenterTop:
        //            xs.AlignHorz = XLAlignHorzEnum.Center;
        //            xs.AlignVert = XLAlignVertEnum.Top;
        //            break;
        //        case TextAlignEnum.GeneralBottom:
        //            xs.AlignHorz = XLAlignHorzEnum.General;
        //            xs.AlignVert = XLAlignVertEnum.Bottom;
        //            break;
        //        case TextAlignEnum.GeneralCenter:
        //            xs.AlignHorz = XLAlignHorzEnum.General;
        //            xs.AlignVert = XLAlignVertEnum.Center;
        //            break;
        //        case TextAlignEnum.GeneralTop:
        //            xs.AlignHorz = XLAlignHorzEnum.General;
        //            xs.AlignVert = XLAlignVertEnum.Top;
        //            break;
        //        case TextAlignEnum.LeftBottom:
        //            xs.AlignHorz = XLAlignHorzEnum.Left;
        //            xs.AlignVert = XLAlignVertEnum.Bottom;
        //            break;
        //        case TextAlignEnum.LeftCenter:
        //            xs.AlignHorz = XLAlignHorzEnum.Left;
        //            xs.AlignVert = XLAlignVertEnum.Center;
        //            break;
        //        case TextAlignEnum.LeftTop:
        //            xs.AlignHorz = XLAlignHorzEnum.Left;
        //            xs.AlignVert = XLAlignVertEnum.Top;
        //            break;
        //        case TextAlignEnum.RightBottom:
        //            xs.AlignHorz = XLAlignHorzEnum.Right;
        //            xs.AlignVert = XLAlignVertEnum.Bottom;
        //            break;
        //        case TextAlignEnum.RightCenter:
        //            xs.AlignHorz = XLAlignHorzEnum.Right;
        //            xs.AlignVert = XLAlignVertEnum.Center;
        //            break;
        //        case TextAlignEnum.RightTop:
        //            xs.AlignHorz = XLAlignHorzEnum.Right;
        //            xs.AlignVert = XLAlignVertEnum.Top;
        //            break;
        //        default:
        //            break;
        //    }

        //    // save it
        //    _styles.Add(style, xs);

        //    // return it
        //    return xs;
        //}



        #endregion



        #endregion

        #region 그리드 이벤트 메서드


        /// <summary>
        /// Event_Click_fgrid_MPS : 
        /// </summary>
        private void Event_Click_fgrid_MPS()
		{

			if(fgrid_MPS.Rows.Count <= fgrid_MPS.Rows.Fixed) return;


			int findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
			int selrow = fgrid_MPS.Selection.r1;
			int selcol = fgrid_MPS.Selection.c1;


			if(selcol > (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START) return;
			
			if(fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT] == null
				|| fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT].ToString() == "") return;

			
			for(int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++)
			{
				if(fgrid_MPS[selrow, i] == null || fgrid_MPS[selrow, i].ToString() == "") continue;
				if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(Color.Empty)) continue;

				//모두 작업지시 나간 경우 표시하기 위함
				findcol = i;

				if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrRelease)) continue;

				if(fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxREAL_LOTYN].ToString() == "Y") 
					if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrRealLOT)) findcol = i; 
					else 
						if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrReadOnly)) findcol = i; 


				break;

			}

			fgrid_MPS.LeftCol = findcol - 2;
			 


		}


		#endregion

		#region 버튼 및 기타 이벤트 메서드

 
		/// <summary>
		/// Event_SelectedValueChanged_cmb_Factory : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_Factory()
		{

			DataTable dt_ret;

			string year = "", frommonth = "", fromday = "", fromymd = "";
			string toyear = "", tomonth = "", today = "", toymd = "";


            year = System.DateTime.Now.Year.ToString();
            frommonth = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
            fromday = "01";
            fromymd = year + frommonth + fromday;

            toyear = System.DateTime.Now.AddMonths(2).Year.ToString();
            tomonth = System.DateTime.Now.AddMonths(2).Month.ToString().PadLeft(2, '0');
            today = System.DateTime.DaysInMonth(Convert.ToInt32(toyear), Convert.ToInt32(tomonth)).ToString().PadLeft(2, '0');
            toymd = toyear + tomonth + today; 

			
			
			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(fromymd);
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(toymd); 
		
			if(ClassLib.ComVar.This_FormDate == "") 
			{
				ClassLib.ComVar.This_FormDate = fromymd;
				ClassLib.ComVar.This_ToDate = toymd;
			} 


			/////////////////////////////////////////////////////////////////////////////////
			//조회 일자에 걸리는 날짜 세팅
			Set_Grid_Date();

			/////////////////////////////////////////////////////////////////////////////////
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLineType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 1, 2, true, COM.ComVar.ComboList_Visible.Name);  
			cmb_LineGroup.SelectedIndex = 0;


			

		}

		



		/// <summary>
		/// Event_KeyPress_txt_StyleCd : 
		/// </summary>
		private void Event_KeyPress_txt_StyleCd(System.Windows.Forms.KeyPressEventArgs e)
		{

			//13 : enter
			if(e.KeyChar != (char)13) return; 

			Event_Tbtn_Search();


		}




		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드

  

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 
		 
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		#endregion

		#region 그리드 이벤트


		
		private void fgrid_MPS_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_fgrid_MPS();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_MPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

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



		private void Form_PD_MPSByOP_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_SelectedValueChanged_cmb_Factory();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_LineGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		
		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ToYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_StyleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		
			try
			{
				Event_KeyPress_txt_StyleCd(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_KeyPress_txt_StyleCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		


		#endregion   

		#region 컨텍스트 메뉴 이벤트


	 

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 콤보


		/// <summary>
		/// Select_SPB_LINE : 라인 리스트 가져오기
		/// </summary>
		public static DataTable Select_SPB_LINE(string arg_factory, string arg_line_group)
		{
			
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;

                string process_name = "PKG_EPM_MPS.SELECT_SPB_LINE_GROUP";

				LMyOraDB.ReDim_Parameter(3); 
 
				LMyOraDB.Process_Name = process_name;
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				LMyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP"; 
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_line_group; 
				LMyOraDB.Parameter_Values[2] = ""; 

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
		}



		#endregion

		#region 조회

		
		/// <summary>
		/// Select_OPSIZE_MPS_YMD : 조회일자 + 월력 적용 리스트 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_ymd"></param>
		/// <param name="arg_to_ymd"></param>
		/// <returns></returns>
		private DataTable Select_OPSIZE_MPS_YMD(string arg_factory, string arg_from_ymd, string arg_to_ymd)
		{
			DataSet ds_ret; 
 
			try
			{  
				MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = "PKG_EPM_MPS.SELECT_OPSIZE_MPS_YMD";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}
		}


		/// <summary>
		/// Select_OPSIZE_MPS_FGA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_ymd"></param>
		/// <param name="arg_to_ymd"></param>
		/// <param name="arg_line_group"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataSet Select_OPSIZE_MPS_FGA(string arg_factory, 
			string arg_from_ymd, 
			string arg_to_ymd, 
			string arg_line_group, 
			string arg_style_cd)
		{
			DataSet ds_ret; 
 
			try
			{  
				MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_EPM_MPS.SELECT_OPSIZE_MPS_HEAD_FGA";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP"; 
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_style_cd;
				MyOraDB.Parameter_Values[5] = "";

				MyOraDB.Add_Select_Parameter(true);  
 

				//////////////////////////////////////////////////////////////////////////////
				 
				MyOraDB.ReDim_Parameter(6);
                MyOraDB.Process_Name = "PKG_EPM_MPS.SELECT_OPSIZE_MPS_DETAIL_FGA";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP"; 
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_style_cd;
				MyOraDB.Parameter_Values[5] = "";


				MyOraDB.Add_Select_Parameter(false); 

				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null;
				return ds_ret; 
			}
			catch
			{
				return null;
			}
		}

	

	
		#endregion


        #endregion





    }
}

