using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Reflection;
using C1.Win.C1FlexGrid;
using RecursiveFileExplorer;
 

namespace FlexBase.Yield
{
	public class Pop_Yield_Check_Status : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		public System.Windows.Forms.ImageList img_Button;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.ImageList img_SmallButton;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_StyleCd;
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
		private C1.Win.C1List.C1Combo cmb_YieldStatus;
		private System.Windows.Forms.Label lbl_YieldStatus;
		private System.Windows.Forms.Label lbl_JobDate;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label1;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_Yield_Check_Status()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Check_Status));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Main = new COM.FSP();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_JobDate = new System.Windows.Forms.Label();
            this.cmb_YieldStatus = new C1.Win.C1List.C1Combo();
            this.lbl_YieldStatus = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
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
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).BeginInit();
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
            this.SuspendLayout();
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
            // c1ToolBar1
            // 
            this.c1ToolBar1.Location = new System.Drawing.Point(605, 4);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(828, 23);
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 653);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(892, 20);
            this.stbar.TabIndex = 45;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.Controls.Add(this.fgrid_Main);
            this.c1Sizer1.Controls.Add(this.pnl_BT);
            this.c1Sizer1.GridDefinition = "5.79216354344123:False:True;8.68824531516184:False:True;76.6609880749574:False:Fa" +
                "lse;5.45144804088586:False:True;\t0:False:False;98.2062780269058:False:False;0:Fa" +
                "lse:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(892, 587);
            this.c1Sizer1.TabIndex = 46;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.Location = new System.Drawing.Point(8, 97);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Size = new System.Drawing.Size(880, 486);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 666;
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(8, 4);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(880, 89);
            this.pnl_BT.TabIndex = 47;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
            this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_JobDate);
            this.pnl_SearchImage.Controls.Add(this.cmb_YieldStatus);
            this.pnl_SearchImage.Controls.Add(this.lbl_YieldStatus);
            this.pnl_SearchImage.Controls.Add(this.cmb_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(880, 84);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
            this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(226, 54);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_ToYMD.TabIndex = 668;
            this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
            this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(109, 54);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(102, 22);
            this.dpick_FromYMD.TabIndex = 667;
            this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 666;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_JobDate
            // 
            this.lbl_JobDate.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_JobDate.ImageIndex = 0;
            this.lbl_JobDate.ImageList = this.img_Label;
            this.lbl_JobDate.Location = new System.Drawing.Point(8, 54);
            this.lbl_JobDate.Name = "lbl_JobDate";
            this.lbl_JobDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_JobDate.TabIndex = 665;
            this.lbl_JobDate.Text = "Job Date";
            this.lbl_JobDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_YieldStatus
            // 
            this.cmb_YieldStatus.AddItemCols = 0;
            this.cmb_YieldStatus.AddItemSeparator = ';';
            this.cmb_YieldStatus.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_YieldStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_YieldStatus.Caption = "";
            this.cmb_YieldStatus.CaptionHeight = 17;
            this.cmb_YieldStatus.CaptionStyle = style25;
            this.cmb_YieldStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_YieldStatus.ColumnCaptionHeight = 18;
            this.cmb_YieldStatus.ColumnFooterHeight = 18;
            this.cmb_YieldStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_YieldStatus.ContentHeight = 17;
            this.cmb_YieldStatus.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_YieldStatus.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_YieldStatus.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_YieldStatus.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_YieldStatus.EditorHeight = 17;
            this.cmb_YieldStatus.EvenRowStyle = style26;
            this.cmb_YieldStatus.FooterStyle = style27;
            this.cmb_YieldStatus.GapHeight = 2;
            this.cmb_YieldStatus.HeadingStyle = style28;
            this.cmb_YieldStatus.HighLightRowStyle = style29;
            this.cmb_YieldStatus.ItemHeight = 15;
            this.cmb_YieldStatus.Location = new System.Drawing.Point(445, 32);
            this.cmb_YieldStatus.MatchEntryTimeout = ((long)(2000));
            this.cmb_YieldStatus.MaxDropDownItems = ((short)(5));
            this.cmb_YieldStatus.MaxLength = 32767;
            this.cmb_YieldStatus.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_YieldStatus.Name = "cmb_YieldStatus";
            this.cmb_YieldStatus.OddRowStyle = style30;
            this.cmb_YieldStatus.PartialRightColumn = false;
            this.cmb_YieldStatus.PropBag = resources.GetString("cmb_YieldStatus.PropBag");
            this.cmb_YieldStatus.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_YieldStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_YieldStatus.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_YieldStatus.SelectedStyle = style31;
            this.cmb_YieldStatus.Size = new System.Drawing.Size(217, 21);
            this.cmb_YieldStatus.Style = style32;
            this.cmb_YieldStatus.TabIndex = 664;
            this.cmb_YieldStatus.SelectedValueChanged += new System.EventHandler(this.cmb_YieldStatus_SelectedValueChanged);
            // 
            // lbl_YieldStatus
            // 
            this.lbl_YieldStatus.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_YieldStatus.ImageIndex = 0;
            this.lbl_YieldStatus.ImageList = this.img_Label;
            this.lbl_YieldStatus.Location = new System.Drawing.Point(344, 32);
            this.lbl_YieldStatus.Name = "lbl_YieldStatus";
            this.lbl_YieldStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_YieldStatus.TabIndex = 531;
            this.lbl_YieldStatus.Text = "Yield Status";
            this.lbl_YieldStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style33;
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
            this.cmb_StyleCd.EvenRowStyle = style34;
            this.cmb_StyleCd.FooterStyle = style35;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style36;
            this.cmb_StyleCd.HighLightRowStyle = style37;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(516, 54);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style38;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style39;
            this.cmb_StyleCd.Size = new System.Drawing.Size(146, 21);
            this.cmb_StyleCd.Style = style40;
            this.cmb_StyleCd.TabIndex = 55;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style41;
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
            this.cmb_Factory.EvenRowStyle = style42;
            this.cmb_Factory.FooterStyle = style43;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style44;
            this.cmb_Factory.HighLightRowStyle = style45;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style46;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style47;
            this.cmb_Factory.Size = new System.Drawing.Size(217, 21);
            this.cmb_Factory.Style = style48;
            this.cmb_Factory.TabIndex = 54;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(445, 54);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(70, 21);
            this.txt_StyleCd.TabIndex = 531;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Factory.ImageIndex = 0;
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
            this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(344, 54);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 527;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(779, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 44);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(864, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(656, 40);
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
            this.lbl_SubTitle1.Text = "      Search Condition";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(864, 69);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 68);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(720, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 69);
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
            this.picb_MM.Size = new System.Drawing.Size(712, 52);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 51);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            // 
            // Pop_Yield_Check_Status
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(892, 673);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.stbar);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.MaximizeBox = true;
            this.Name = "Pop_Yield_Check_Status";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).EndInit();
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
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		#endregion	  

		#region 멤버 메서드

		public void Init_Form()
		{
			try
			{ 
				
				//Title
				this.Text = "Check Yield Status";
				lbl_MainTitle.Text = "Check Yield Status";

                ClassLib.ComFunction.SetLangDic(this);


				// control setting
				Init_Control();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}



		/// <summary>
		/// Init_Control : textbox, combobox setting
		/// </summary>
		private void Init_Control()
		{


			// 그리드 설정
			fgrid_Main.Set_Grid("SBC_YIELD_CHECK_STATUS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.ExtendLastCol = false;


			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			//dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 
			//dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 



			// 공장코드
			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			dt_ret.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
  



		}



		#region 그리드 관련 메서드





		#endregion 

		#region 버튼 이벤트 관련 메서드

 
		/// <summary>
		/// Event_cmb_Factory_SelectedValueChanged : 
		/// </summary>
		private void Event_cmb_Factory_SelectedValueChanged()
		{

			if(cmb_Factory.SelectedIndex == -1) return;


			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			
			// Value Status ComboBox Add Items 
			string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, ClassLib.ComVar.This_Factory);
			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxYieldStatus);
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_YieldStatus, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name);

		}


		/// <summary>
		/// Event_dpick_FromYMD_ValueChanged : 
		/// </summary>
		private void Event_dpick_FromYMD_ValueChanged()
		{

			dpick_ToYMD.Value = dpick_FromYMD.Value;

		}


		/// <summary>
		/// Event_dpick_ToYMD_ValueChanged : 
		/// </summary>
		private void Event_dpick_ToYMD_ValueChanged()
		{

			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

		}


		/// <summary>
		/// Event_cmb_YieldStatus_SelectedValueChanged : 
		/// </summary>
		private void Event_cmb_YieldStatus_SelectedValueChanged()
		{
			
			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

		}


		/// <summary>
		/// Event_txt_StyleCd_KeyUp : 
		/// </summary>
		private void Event_txt_StyleCd_KeyUp()
		{

			cmb_StyleCd.SelectedIndex = -1;
			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;



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



		/// <summary>
		/// Event_cmb_StyleCd_SelectedValueChanged : 
		/// </summary>
		private void Event_cmb_StyleCd_SelectedValueChanged()
		{

			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();

		}




		/// <summary>
		/// Event_tbtn_New_Click : 
		/// </summary>
		private void Event_tbtn_New_Click()
		{

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			
			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(System.DateTime.Now.ToString("yyyyMMdd")); 

			cmb_YieldStatus.SelectedIndex = -1;
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1;


			//fgrid_Main.ClearAll();
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
			

		}



		/// <summary>
		/// Event_tbtn_Search_Click : 
		/// </summary>
		private void Event_tbtn_Search_Click()
		{

			string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, " ");
			string job_date_from = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string job_date_to = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string yield_status = ClassLib.ComFunction.Empty_Combo(cmb_YieldStatus, " ");
			//string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
			string style_cd = txt_StyleCd.Text.Replace("-", "");


			DataTable dt_ret = Select_SBC_YIELD_STATUS_CHECK(factory, job_date_from, job_date_to, yield_status, style_cd);
			fgrid_Main.Display_Grid(dt_ret, false);


			fgrid_Main.AllowMerging = AllowMergingEnum.Free;
			for(int i = 0; i < fgrid_Main.Cols.Count; i++) fgrid_Main.Cols[i].AllowMerging = false;
			for(int i = 0; i < (int)ClassLib.TBSBC_YIELD_STATUS_CHECK.IxSAVE_DATE + 1; i++) fgrid_Main.Cols[i].AllowMerging = true;
			 


		}



		#endregion

		

		#endregion 
		
		#region 이벤트 처리



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

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;

				Event_tbtn_New_Click(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;

				Event_tbtn_Search_Click(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;


				Event_cmb_Factory_SelectedValueChanged(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		
		} 

		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Event_dpick_FromYMD_ValueChanged(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_dpick_FromYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Event_dpick_ToYMD_ValueChanged(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_dpick_ToYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void cmb_YieldStatus_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Event_cmb_YieldStatus_SelectedValueChanged(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_YieldStatus_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				if(e.KeyCode != Keys.Enter) return;

				Event_txt_StyleCd_KeyUp(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Event_cmb_StyleCd_SelectedValueChanged(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}



		#endregion

		#region DB Connect


		/// <summary>
		/// Select_SBC_YIELD_STATUS_CHECK : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_job_date_from"></param>
		/// <param name="arg_job_date_to"></param>
		/// <param name="arg_yield_status"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_STATUS_CHECK(string arg_factory, 
			string arg_job_date_from, 
			string arg_job_date_to, 
			string arg_yield_status, 
			string arg_style_cd)
		{

			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(6); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_STATUS_CHECK";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_JOB_DATE_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_JOB_DATE_TO";
			MyOraDB.Parameter_Name[3] = "ARG_YIELD_STATUS";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_job_date_from;
			MyOraDB.Parameter_Values[2] = arg_job_date_to; 
			MyOraDB.Parameter_Values[3] = arg_yield_status; 
			MyOraDB.Parameter_Values[4] = arg_style_cd; 
			MyOraDB.Parameter_Values[5] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}


		#endregion   

	



	}
}

