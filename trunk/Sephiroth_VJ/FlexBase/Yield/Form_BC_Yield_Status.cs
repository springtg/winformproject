using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;  

namespace FlexBase.Yield
{
	public class Form_BC_Yield_Status : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리


		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.Label lbl_Gender;
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
		public COM.FSP fgrid_Yield;
		public System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.Label btn_Neomics;
		public System.Windows.Forms.ImageList img_Button;
		private System.ComponentModel.IContainer components = null;

		public Form_BC_Yield_Status()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Yield_Status));
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.fgrid_Yield = new COM.FSP();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_Neomics = new System.Windows.Forms.Label();
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.txt_Presto = new System.Windows.Forms.TextBox();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
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
            this.stbar = new System.Windows.Forms.StatusBar();
            this.info_bar = new System.Windows.Forms.StatusBarPanel();
            this.formname_bar = new System.Windows.Forms.StatusBarPanel();
            this.img_Action = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).BeginInit();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.Controls.Add(this.fgrid_Yield);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Font = new System.Drawing.Font("Verdana", 9F);
            this.pnl_B.Location = new System.Drawing.Point(0, 56);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(792, 488);
            this.pnl_B.TabIndex = 26;
            // 
            // fgrid_Yield
            // 
            this.fgrid_Yield.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Yield.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Yield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Yield.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Yield.Location = new System.Drawing.Point(5, 88);
            this.fgrid_Yield.Name = "fgrid_Yield";
            this.fgrid_Yield.Size = new System.Drawing.Size(782, 395);
            this.fgrid_Yield.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Yield.Styles"));
            this.fgrid_Yield.TabIndex = 666;
            this.fgrid_Yield.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_AfterEdit);
            this.fgrid_Yield.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_BeforeEdit);
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(5, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(782, 88);
            this.pnl_BT.TabIndex = 47;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_Neomics);
            this.pnl_SearchImage.Controls.Add(this.cmb_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.txt_Presto);
            this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.txt_Gender);
            this.pnl_SearchImage.Controls.Add(this.lbl_Gender);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(782, 83);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // btn_Neomics
            // 
            this.btn_Neomics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Neomics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Neomics.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Neomics.ImageIndex = 0;
            this.btn_Neomics.ImageList = this.img_Button;
            this.btn_Neomics.Location = new System.Drawing.Point(696, 53);
            this.btn_Neomics.Name = "btn_Neomics";
            this.btn_Neomics.Size = new System.Drawing.Size(80, 23);
            this.btn_Neomics.TabIndex = 669;
            this.btn_Neomics.Text = "Neomics";
            this.btn_Neomics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Neomics.Visible = false;
            this.btn_Neomics.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Neomics.Click += new System.EventHandler(this.btn_Neomics_Click);
            this.btn_Neomics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Neomics.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Neomics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style17;
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
            this.cmb_StyleCd.EvenRowStyle = style18;
            this.cmb_StyleCd.FooterStyle = style19;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style20;
            this.cmb_StyleCd.HighLightRowStyle = style21;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(206, 54);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style22;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style23;
            this.cmb_StyleCd.Size = new System.Drawing.Size(150, 21);
            this.cmb_StyleCd.Style = style24;
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
            this.cmb_Factory.CaptionStyle = style25;
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
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(247, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 54;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // txt_Presto
            // 
            this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Presto.Location = new System.Drawing.Point(574, 54);
            this.txt_Presto.MaxLength = 100;
            this.txt_Presto.Name = "txt_Presto";
            this.txt_Presto.ReadOnly = true;
            this.txt_Presto.Size = new System.Drawing.Size(96, 21);
            this.txt_Presto.TabIndex = 535;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(109, 54);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(96, 21);
            this.txt_StyleCd.TabIndex = 531;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Gender.Location = new System.Drawing.Point(477, 54);
            this.txt_Gender.MaxLength = 100;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.Size = new System.Drawing.Size(96, 21);
            this.txt_Gender.TabIndex = 31;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(376, 54);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 530;
            this.lbl_Gender.Text = "Gender/ Presto";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_Style.Location = new System.Drawing.Point(8, 54);
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
            this.picb_MR.Location = new System.Drawing.Point(681, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 43);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(766, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(558, 40);
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
            this.picb_BR.Location = new System.Drawing.Point(766, 68);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 67);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(622, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 68);
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
            this.picb_MM.Size = new System.Drawing.Size(614, 51);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 50);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.info_bar,
            this.formname_bar});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 22);
            this.stbar.TabIndex = 27;
            // 
            // info_bar
            // 
            this.info_bar.Name = "info_bar";
            this.info_bar.Width = 150;
            // 
            // formname_bar
            // 
            this.formname_bar.Name = "formname_bar";
            this.formname_bar.Width = 300;
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // Form_BC_Yield_Status
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.Name = "Form_BC_Yield_Status";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).EndInit();
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		 
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
				this.Text = "Yield Status Master";
                lbl_MainTitle.Text = "Yield Status Master";

				ClassLib.ComFunction.SetLangDic(this); 
 

				// 그리드 설정
				fgrid_Yield.Set_Grid("SBC_YIELD_STATUS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Yield.Set_Action_Image(img_Action);
 
 

				DataTable dt_ret; 

				// 공장코드
				dt_ret = COM.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
  
 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		
		/// <summary>
		/// Search_SBC_YIELD_STATUS : 데이터 조회
		/// </summary>
		private void Search_SBC_YIELD_STATUS()
		{
			
			try
			{

			
				this.Cursor = Cursors.WaitCursor;


				DataTable dt_ret;

				string factory = cmb_Factory.SelectedValue.ToString();
				//string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");

				string style_cd = "";

				if(cmb_StyleCd.SelectedIndex == -1)
				{
					style_cd = txt_StyleCd.Text.Trim().Replace("-", "");
				}
				else
				{
					style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				}

				string yield_status = " ";

				dt_ret = Select_SBC_YIELD_STATUS(factory, style_cd, yield_status);
				fgrid_Yield.Display_Grid(dt_ret, false); 
				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_SBC_YIELD_STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			finally
			{

				this.Cursor = Cursors.Default;

			}

		}




		/// <summary>
		/// Save_SBC_YIELD_STATUS : 데이터 저장
		/// </summary>
		private void Save_SBC_YIELD_STATUS()
		{


			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


				// yield main form close check -> check in -> check out
				foreach(Form f in ClassLib.ComVar.MDI_Parent.MdiChildren)
				{ 
				
					if(f.Name.ToString() == "Form_BC_Yield_withExcel" )
					{ 
					 
						f.Activate();
						ClassLib.ComFunction.User_Message("Need Close [Yield Register].", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information); 
						return;
					 
					 
					}


				} // end foreach


				#region Check in
 
	 
				bool checkin_cancel = false;

				string division = "I";
			
				string factory = cmb_Factory.SelectedValue.ToString(); 

				string style_cd = "";

				//			if(cmb_StyleCd.SelectedIndex == -1)
				//			{
				//				style_cd = txt_StyleCd.Text.Trim().Replace("-", "");
				//			}
				//			else
				//			{
				//				style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				//			}
			
				style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				string checkuser = ClassLib.ComVar.This_User; 
				string  remarks = "yield status";


				// check in/out cancel 
				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxYieldCheckinCancel);

				if(dt_ret != null && dt_ret.Rows.Count > 0)
				{
					checkin_cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
				}
				else
				{
					checkin_cancel = false;
				}

			


				bool checkin_ok = false;
			
				// 초기화
				Pop_Yield_Replace_Item._CheckInSeq = "1";


				if(checkin_cancel)   // local 만 체크
				{ 
					checkin_ok = Pop_Yield_Replace_Item.Run_Check_In_Local(division, factory, style_cd, checkuser, remarks);
				}
				else  // remote, local 모두 체크
				{
					checkin_ok = Pop_Yield_Replace_Item.Run_Check_In_RemoteLocal(division, factory, style_cd, checkuser,  remarks);
				}


				if(! checkin_ok) 
				{ 
					ClassLib.ComFunction.User_Message("Check In Fail", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					return;
				}

				#endregion


				//bool save_flag = MyOraDB.Save_FlexGird("PKG_SBC_YIELD.SAVE_SBC_YIELD_STATUS_INFO", fgrid_Yield);

				bool save_flag = Save_SBC_YIELD_STATUS_INFO();

				if(! save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);

					// checkout
					Run_Check_Out();

					return;

				}
				else
				{

					Search_SBC_YIELD_STATUS();

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 

					//fgrid_Yield.Refresh_Division(); 
				}

			}
			catch
			{

				// checkout
				Run_Check_Out();

			}



		}



		/// <summary>
		/// Run_Check_Out : 
		/// </summary>
		private void Run_Check_Out()
		{
			 
			string division = "O"; // Out
			string factory = cmb_Factory.SelectedValue.ToString();
			string stylecd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string  remarks = "check out";
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Form_BC_Yield_withExcel. Save_Check_InOut(division, factory, stylecd, Pop_Yield_Replace_Item._CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{ 
				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{ 
				//ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}



		}



 
		#endregion 

		#region 이벤트 처리

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		

			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;

				 
				txt_StyleCd.Text = "";
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = ""; 
				txt_Presto.Text = "";
				 

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed; 
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



				// 데이터 조회 
				Search_SBC_YIELD_STATUS(); 




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

				//---------------------------------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				txt_Gender.Text = ""; 
				txt_Presto.Text = ""; 

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed; 
				//---------------------------------------------------------------------------------------------------

				

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
				txt_Gender.Text = cmb_StyleCd.Columns[2].Text; 
				txt_Presto.Text = cmb_StyleCd.Columns[3].Text;
 

				// 데이터 조회 
				Search_SBC_YIELD_STATUS(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		private void fgrid_Yield_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if ((fgrid_Yield.Rows.Fixed > 0) && (fgrid_Yield.Row >= fgrid_Yield.Rows.Fixed))
			{
				fgrid_Yield.Buffer_CellData = (fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col] == null) ? "" : fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col].ToString();
			}

		}



		private void fgrid_Yield_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			fgrid_Yield.Update_Row(); 

		}



		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
 
				cmb_Factory.SelectedIndex = -1;  
				txt_StyleCd.Text = "";
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = "";  
				txt_Presto.Text = ""; 

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;


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
 
				// 데이터 조회 
				Search_SBC_YIELD_STATUS(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		

			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Save_SBC_YIELD_STATUS(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{  
				fgrid_Yield.Delete_Row();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


		private void btn_Neomics_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				// 데이터 조회 
				Search_SBC_YIELD_STATUS_NEOMICS();  


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		/// <summary>
		/// Search_SBC_YIELD_STATUS_NEOMICS : 
		/// </summary>
		private void Search_SBC_YIELD_STATUS_NEOMICS()
		{

			try
			{

			
				this.Cursor = Cursors.WaitCursor;


				DataTable dt_ret;

				string factory = cmb_Factory.SelectedValue.ToString();
				//string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");

				string style_cd = "";

				if(cmb_StyleCd.SelectedIndex == -1)
				{
					style_cd = txt_StyleCd.Text.Trim().Replace("-", "");
				}
				else
				{
					style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				}

				dt_ret = Select_SBC_YIELD_STATUS_NEOMICS(factory, style_cd);
				fgrid_Yield.Display_Grid(dt_ret, false); 
				dt_ret.Dispose();


			}
			catch
			{
			}
			finally
			{

				this.Cursor = Cursors.Default;

			}


		}

        #endregion 
		
		#region DB Connect



		/// <summary>
		/// Select_SBC_YIELD_STATUS : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		public static DataTable Select_SBC_YIELD_STATUS(string arg_factory, string arg_stylecd, string arg_yield_status)
		{

			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_STATUS";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_YIELD_STATUS";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;  
			MyOraDB.Parameter_Values[2] = arg_yield_status; 
			MyOraDB.Parameter_Values[3] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
 


		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_STATUS_NEOMICS(string arg_factory, string arg_stylecd)
		{

			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_STATUS_NEO";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;  
			MyOraDB.Parameter_Values[2] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}



		/// <summary>
		/// Save_SBC_YIELD_STATUS_INFO : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SBC_YIELD_STATUS_INFO()
		{

			try
			{ 

				
				int col_ct = 12;   

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.SAVE_SBC_YIELD_STATUS_INFO";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[4] = "ARG_YIELD_STATUS";
				MyOraDB.Parameter_Name[5] = "ARG_HIDDEN_KEY";
				MyOraDB.Parameter_Name[6] = "ARG_YIELD_SEASON";
				MyOraDB.Parameter_Name[7] = "ARG_CONFIRM_YMD";
				MyOraDB.Parameter_Name[8] = "ARG_JOB_DATE"; 
				MyOraDB.Parameter_Name[9] = "ARG_REMARKS"; 
				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER"; 
				MyOraDB.Parameter_Name[11] = "ARG_STYLE_CD_CHECKINSEQ";  
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList();  

				for(int row = fgrid_Yield.Rows.Fixed; row < fgrid_Yield.Rows.Count; row++)
				{

					if(fgrid_Yield[row, 0] == null || fgrid_Yield[row, 0].ToString().Trim().Equals("") ) continue;  

					for(int col = 0; col < fgrid_Yield.Cols.Count - 2; col++)  // upd_user 앞까지
					{
						//vList.Add( (fgrid_Yield[row, col] == null) ? "" : fgrid_Yield[row, col].ToString() ); 

						// 데이터값 설정 
						if(fgrid_Yield.Cols[col].Style.DataType != null && fgrid_Yield.Cols[col].DataType.Equals(typeof(bool)) )
						{ 
							fgrid_Yield[row, col] = (fgrid_Yield[row, col] == null) ? "False" : fgrid_Yield[row, col].ToString();
							vList.Add( (fgrid_Yield[row,col].ToString() == "True") ? "Y" : "N" );
						}
						//콤보리스트 처리 추가 
						else if(fgrid_Yield.Cols[col].ComboList.Length != 0)
						{
							char[] delimiter = ":".ToCharArray();
							string[] token = null; 

							token = fgrid_Yield[row,col].ToString().Split(delimiter); 
							vList.Add( (token[0] == null) ? "" : token[0].Trim() ); 
						} 
						else
						{ 
							vList.Add( (fgrid_Yield[row, col] == null) ? "" : fgrid_Yield[row,col].ToString() ); 
						}			


					}

					vList.Add(ClassLib.ComVar.This_User); 
					vList.Add(Pop_Yield_Replace_Item._CheckInSeq); 
    


				} // end for i
  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch
			{  
				return false;
			} 


		}


		#endregion 

		

		

 

	}
}

