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
	public class Pop_Yield_Backup_Restore : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		public System.Windows.Forms.ImageList img_Button;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Style;
		private COM.FSP fgrid_Head;
		private System.Windows.Forms.TextBox txt_StyleName;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Panel pnl_BB1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_XML;
		private AxSHDocVw.AxWebBrowser ax_xml_viewer;
		private System.Windows.Forms.TabPage tabPage_Grid;
		private C1.Win.C1List.C1Combo cmb_TableName;
		private System.Windows.Forms.Label lbl_TableName;
		private C1.Win.C1FlexGrid.C1FlexGrid fgrid_Detail;
		public System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.TextBox txt_SelectFileName;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_Yield_Backup_Restore()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}




		private string _Factory;
		private string _StyleCd;
		private string _StyleName;


		public Pop_Yield_Backup_Restore(string arg_factory, string arg_style_cd, string arg_style_name)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_StyleCd = arg_style_cd;
			_StyleName = arg_style_name;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Backup_Restore));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Grid = new System.Windows.Forms.TabPage();
            this.txt_SelectFileName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.fgrid_Detail = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cmb_TableName = new C1.Win.C1List.C1Combo();
            this.tabPage_XML = new System.Windows.Forms.TabPage();
            this.ax_xml_viewer = new AxSHDocVw.AxWebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.pnl_BB1 = new System.Windows.Forms.Panel();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.txt_StyleName = new System.Windows.Forms.TextBox();
            this.txt_Factory = new System.Windows.Forms.TextBox();
            this.fgrid_Head = new COM.FSP();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TableName)).BeginInit();
            this.tabPage_XML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ax_xml_viewer)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_BB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.tabControl);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.pnl_BB1);
            this.c1Sizer1.Controls.Add(this.fgrid_Head);
            this.c1Sizer1.GridDefinition = "5.79216354344123:False:True;17.8875638841567:False:True;67.4616695059625:False:Fa" +
                "lse;5.45144804088586:False:True;\t0:False:False;98.2062780269058:False:False;0:Fa" +
                "lse:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(892, 587);
            this.c1Sizer1.TabIndex = 46;
            this.c1Sizer1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Grid);
            this.tabControl.Controls.Add(this.tabPage_XML);
            this.tabControl.Location = new System.Drawing.Point(8, 151);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(876, 396);
            this.tabControl.TabIndex = 666;
            // 
            // tabPage_Grid
            // 
            this.tabPage_Grid.Controls.Add(this.txt_SelectFileName);
            this.tabPage_Grid.Controls.Add(this.btn_Search);
            this.tabPage_Grid.Controls.Add(this.lbl_TableName);
            this.tabPage_Grid.Controls.Add(this.fgrid_Detail);
            this.tabPage_Grid.Controls.Add(this.cmb_TableName);
            this.tabPage_Grid.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Grid.Name = "tabPage_Grid";
            this.tabPage_Grid.Size = new System.Drawing.Size(868, 369);
            this.tabPage_Grid.TabIndex = 1;
            this.tabPage_Grid.Text = "Grid";
            this.tabPage_Grid.Visible = false;
            // 
            // txt_SelectFileName
            // 
            this.txt_SelectFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SelectFileName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SelectFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SelectFileName.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_SelectFileName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_SelectFileName.Location = new System.Drawing.Point(487, 7);
            this.txt_SelectFileName.MaxLength = 100;
            this.txt_SelectFileName.Name = "txt_SelectFileName";
            this.txt_SelectFileName.ReadOnly = true;
            this.txt_SelectFileName.Size = new System.Drawing.Size(376, 22);
            this.txt_SelectFileName.TabIndex = 636;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.ImageList = this.img_Button;
            this.btn_Search.Location = new System.Drawing.Point(330, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 23);
            this.btn_Search.TabIndex = 635;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Search.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_TableName.ImageIndex = 0;
            this.lbl_TableName.ImageList = this.img_Label;
            this.lbl_TableName.Location = new System.Drawing.Point(8, 8);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(100, 21);
            this.lbl_TableName.TabIndex = 539;
            this.lbl_TableName.Text = "Table Name";
            this.lbl_TableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgrid_Detail
            // 
            this.fgrid_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_Detail.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Detail.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Detail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Detail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Detail.Location = new System.Drawing.Point(8, 40);
            this.fgrid_Detail.Name = "fgrid_Detail";
            this.fgrid_Detail.Size = new System.Drawing.Size(855, 315);
            this.fgrid_Detail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Detail.Styles"));
            this.fgrid_Detail.TabIndex = 56;
            // 
            // cmb_TableName
            // 
            this.cmb_TableName.AddItemCols = 0;
            this.cmb_TableName.AddItemSeparator = ';';
            this.cmb_TableName.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_TableName.Caption = "";
            this.cmb_TableName.CaptionHeight = 17;
            this.cmb_TableName.CaptionStyle = style9;
            this.cmb_TableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_TableName.ColumnCaptionHeight = 18;
            this.cmb_TableName.ColumnFooterHeight = 18;
            this.cmb_TableName.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_TableName.ContentHeight = 17;
            this.cmb_TableName.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_TableName.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_TableName.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_TableName.EditorFont = new System.Drawing.Font("Verdana", 9F);
            this.cmb_TableName.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_TableName.EditorHeight = 17;
            this.cmb_TableName.EvenRowStyle = style10;
            this.cmb_TableName.FooterStyle = style11;
            this.cmb_TableName.GapHeight = 2;
            this.cmb_TableName.HeadingStyle = style12;
            this.cmb_TableName.HighLightRowStyle = style13;
            this.cmb_TableName.ItemHeight = 15;
            this.cmb_TableName.Location = new System.Drawing.Point(109, 8);
            this.cmb_TableName.MatchEntryTimeout = ((long)(2000));
            this.cmb_TableName.MaxDropDownItems = ((short)(5));
            this.cmb_TableName.MaxLength = 32767;
            this.cmb_TableName.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_TableName.Name = "cmb_TableName";
            this.cmb_TableName.OddRowStyle = style14;
            this.cmb_TableName.PartialRightColumn = false;
            this.cmb_TableName.PropBag = resources.GetString("cmb_TableName.PropBag");
            this.cmb_TableName.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_TableName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_TableName.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_TableName.SelectedStyle = style15;
            this.cmb_TableName.Size = new System.Drawing.Size(220, 21);
            this.cmb_TableName.Style = style16;
            this.cmb_TableName.TabIndex = 55;
            this.cmb_TableName.SelectedValueChanged += new System.EventHandler(this.cmb_TableName_SelectedValueChanged);
            // 
            // tabPage_XML
            // 
            this.tabPage_XML.Controls.Add(this.ax_xml_viewer);
            this.tabPage_XML.Location = new System.Drawing.Point(4, 21);
            this.tabPage_XML.Name = "tabPage_XML";
            this.tabPage_XML.Size = new System.Drawing.Size(868, 371);
            this.tabPage_XML.TabIndex = 0;
            this.tabPage_XML.Text = "XML";
            // 
            // ax_xml_viewer
            // 
            this.ax_xml_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ax_xml_viewer.Enabled = true;
            this.ax_xml_viewer.Location = new System.Drawing.Point(0, 0);
            this.ax_xml_viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ax_xml_viewer.OcxState")));
            this.ax_xml_viewer.Size = new System.Drawing.Size(868, 371);
            this.ax_xml_viewer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Apply);
            this.panel1.Location = new System.Drawing.Point(8, 551);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(876, 32);
            this.panel1.TabIndex = 665;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(792, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 635;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(711, 5);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(80, 23);
            this.btn_Apply.TabIndex = 634;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // pnl_BB1
            // 
            this.pnl_BB1.Controls.Add(this.lbl_Factory);
            this.pnl_BB1.Controls.Add(this.txt_StyleCd);
            this.pnl_BB1.Controls.Add(this.lbl_Style);
            this.pnl_BB1.Controls.Add(this.txt_StyleName);
            this.pnl_BB1.Controls.Add(this.txt_Factory);
            this.pnl_BB1.Location = new System.Drawing.Point(8, 4);
            this.pnl_BB1.Name = "pnl_BB1";
            this.pnl_BB1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB1.Size = new System.Drawing.Size(880, 34);
            this.pnl_BB1.TabIndex = 664;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(0, 8);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 538;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_StyleCd.Location = new System.Drawing.Point(317, 8);
            this.txt_StyleCd.MaxLength = 100;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.ReadOnly = true;
            this.txt_StyleCd.Size = new System.Drawing.Size(96, 22);
            this.txt_StyleCd.TabIndex = 541;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(216, 8);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 537;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StyleName
            // 
            this.txt_StyleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleName.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_StyleName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_StyleName.Location = new System.Drawing.Point(414, 8);
            this.txt_StyleName.MaxLength = 100;
            this.txt_StyleName.Name = "txt_StyleName";
            this.txt_StyleName.ReadOnly = true;
            this.txt_StyleName.Size = new System.Drawing.Size(218, 22);
            this.txt_StyleName.TabIndex = 540;
            // 
            // txt_Factory
            // 
            this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Factory.Font = new System.Drawing.Font("Verdana", 9F);
            this.txt_Factory.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Factory.Location = new System.Drawing.Point(101, 8);
            this.txt_Factory.MaxLength = 100;
            this.txt_Factory.Name = "txt_Factory";
            this.txt_Factory.ReadOnly = true;
            this.txt_Factory.Size = new System.Drawing.Size(96, 22);
            this.txt_Factory.TabIndex = 536;
            // 
            // fgrid_Head
            // 
            this.fgrid_Head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_Head.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Head.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Head.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Head.Location = new System.Drawing.Point(8, 42);
            this.fgrid_Head.Name = "fgrid_Head";
            this.fgrid_Head.Size = new System.Drawing.Size(876, 105);
            this.fgrid_Head.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Head.Styles"));
            this.fgrid_Head.TabIndex = 663;
            this.fgrid_Head.DoubleClick += new System.EventHandler(this.fgrid_Head_DoubleClick);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            // 
            // Pop_Yield_Backup_Restore
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(892, 673);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.stbar);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.MaximizeBox = true;
            this.Name = "Pop_Yield_Backup_Restore";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Yield_Backup_Restore_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Grid.ResumeLayout(false);
            this.tabPage_Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TableName)).EndInit();
            this.tabPage_XML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ax_xml_viewer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_BB1.ResumeLayout(false);
            this.pnl_BB1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 
		public bool _Cancel_Flag = true;
		 

		#endregion	  

		#region 멤버 메서드

		public void Init_Form()
		{
			try
			{ 
				
				//Title
				this.Text = "Restore to Yield Data";
				lbl_MainTitle.Text = "Restore to Yield Data";


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
			

			c1ToolBar1.Visible = false; 


			txt_Factory.Text = _Factory;
			txt_StyleCd.Text = _StyleCd;
			txt_StyleName.Text = _StyleName;


			Display_Head();



		}



		/// <summary>
		/// Display_Head : 
		/// </summary>
		private void Display_Head()
		{

			// 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
			string start_path = Application.StartupPath.ToString() +  "\\" + "Yield_Backup" + "\\";
			string directory_name = _Factory + "_" + _StyleCd.Replace("-", "");
			string directory_full_name = start_path + directory_name;

				 
			if( ! System.IO.Directory.Exists(directory_full_name) ) return;


			ArrayList extensions_array = new ArrayList();
			extensions_array.Add(".ZIP");
			RecursiveFileExplorer.FileExplorer file_explorer = new FileExplorer(directory_full_name, extensions_array, true );
			


			//fgrid_Head.DataSource = file_explorer.FileList;

			//--------------------------------------------------------------------------------------------------------------------
			// file list 표시
			fgrid_Head.ExtendLastCol = true;
			fgrid_Head.AllowEditing = false;
			fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
			fgrid_Head.Cols.Count = 3;
			fgrid_Head.Cols[0].Width = 20;
			fgrid_Head.Cols[2].Visible = false;
			fgrid_Head[fgrid_Head.Rows.Fixed - 1, 1] = "File Name";

			// 최신 수정된 파일부터 표시
			for(int i = file_explorer.FileList.Count - 1; i >= 0 ; i--)
			{

				fgrid_Head.Rows.Add();
				fgrid_Head[fgrid_Head.Rows.Count - 1, 1] = ((FileData)file_explorer.FileList[i]).Name.ToString();
				fgrid_Head[fgrid_Head.Rows.Count - 1, 2] = ((FileData)file_explorer.FileList[i]).FullName.ToString();

			} // end for i
			//--------------------------------------------------------------------------------------------------------------------


			


		}




		#region 그리드 관련 메서드



		private void Display_Detail()
		{


			if(fgrid_Head.Rows.Count <= fgrid_Head.Rows.Fixed) return;


			txt_SelectFileName.Text =  fgrid_Head[fgrid_Head.Row, 1].ToString().Trim();
			txt_SelectFileName.Tag =  fgrid_Head[fgrid_Head.Row, 2].ToString().Trim();  // file full name


			// .ZIP 해제
			C1.C1Zip.C1ZipFile zipFile  = new C1.C1Zip.C1ZipFile();	// the zip file   
			string file_name = fgrid_Head[fgrid_Head.Row, 2].ToString().Trim(); // file full name
			zipFile.Open(file_name);
			zipFile.Entries.Extract(zipFile.Entries[0].FileName); 



			Display_XML(file_name.Replace(".ZIP", ".XML").Replace(".zip", ".XML"));
		    Display_Grid(file_name.Replace(".ZIP", ".XML").Replace(".zip", ".XML"));


		}



		/// <summary>
		/// Display_XML : 
		/// </summary>
		/// <param name="arg_file_name"></param>
		private void Display_XML(string arg_file_name)
		{

			this.Cursor = Cursors.WaitCursor;

			object temp = null;
			ax_xml_viewer.Navigate(arg_file_name, ref temp, ref temp, ref temp, ref temp);

			this.Cursor = Cursors.Default;

		}

		
        private DataSet _DSXML;


		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_file_name"></param>
		private void Display_Grid(string arg_file_name)
		{


			this.Cursor = Cursors.WaitCursor;


			fgrid_Detail.Cols[0].Width = 20;

			_DSXML = new DataSet();

			_DSXML.ReadXml(arg_file_name, XmlReadMode.Auto); 

			cmb_TableName.AddItemTitles("Table");


			for ( int i = 0 ; i < _DSXML.Tables.Count ; i++ )
			{
				cmb_TableName.AddItem(_DSXML.Tables[i].TableName);
			}

			cmb_TableName.ValueMember = "Table";
			cmb_TableName.Splits[0].DisplayColumns[0].Width = 220;
			cmb_TableName.SelectedIndex = -1;
			cmb_TableName.SelectedIndex = 0;
			//Search();
			

		



			this.Cursor = Cursors.Default;

		}


		private void Search()
		{

			try
			{

				string table_name = cmb_TableName.SelectedValue.ToString();
				DataTable vDt = _DSXML.Tables[table_name];
				fgrid_Detail.DataSource = vDt;

				ClassLib.ComFunction.User_Message("Search Complete.", "Run Restore Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch
			{
				ClassLib.ComFunction.User_Message("Search Failed.", "Run Restore Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


		}




		#endregion 

		#region 버튼 이벤트 관련 메서드

 


		/// <summary>
		/// Run_Restore : 
		/// </summary>
		private void Run_Restore()
		{


			_Cancel_Flag = false;


			string message = "Do you continue restore ?"; 
			DialogResult result = ClassLib.ComFunction.User_Message(message, "Run Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if(result == DialogResult.Yes)
			{
				Apply_DataBase();
			}
			else
			{
				return;
			}



		}




		/// <summary>
		/// Apply_DataBase : 
		/// </summary>
		private void Apply_DataBase()
		{


			DataSet ds_ret = new DataSet();
			DataSet ds_xml = new DataSet();
			string[] update_query = null;  
			ArrayList query_array = new ArrayList();
			string  col_list   = null;
			string  value_list = null;


			string strFullName = txt_SelectFileName.Tag.ToString().Trim().Replace(".ZIP", ".XML").Replace(".zip", ".XML");

			ds_xml.ReadXml(strFullName, XmlReadMode.Auto); 



			for(int h = 0 ; h < ds_xml.Tables.Count ; h++)
			{
							 
							 
				int col = ds_xml.Tables[h].Columns.Count;
				int row = ds_xml.Tables[h].Rows.Count;
				string where = "";
				string table = "";


				for(int i = 0 ; i < row ; i++)
				{
					
					
					if ( !(ds_xml.Tables[h].Rows[i]["WHERE"] is System.DBNull) )
					{
						where = ds_xml.Tables[h].Rows[i]["WHERE"].ToString();
						table = ds_xml.Tables[h].TableName.ToString();

						// 기존 데이타는 Delete
						string delete_sql = " DELETE "
												+ "    FROM "+ table
												+ "  WHERE "+ where;
 
 
						query_array.Add(delete_sql);

						continue;
					}

					col_list   = "";
					value_list = "";

								
					// 마지막 인덱스 찾기
					int start_col = 0;
					int end_col = ds_xml.Tables[h].Columns.Count - 3;
					if (ds_xml.Tables[h].Columns["WHERE"].Ordinal == 0)
					{
						start_col++;
						end_col++;
					}

 
					for(int j = start_col ; j < end_col ; j++)
					{


						if (ds_xml.Tables[h].Columns[j].ColumnName.ToString().Equals("WHERE")) continue;

						string col_name = ds_xml.Tables[h].Columns[j].ColumnName.ToString() + ", " ;
						string col_type = ds_xml.Tables[h].Columns[j].Namespace.ToString();
						string data_value = "";

 


						if(col_type.ToString() == "System.DateTime")
						{
							if(ds_xml.Tables[h].Rows[i].ItemArray[j].ToString().Trim().Equals("") )
							{
								data_value = "'" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString() + "', " ; 
							}
							else
							{
								data_value = @"to_date('" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString() + @"', 'yyyy-mm-dd am hh:mi:ss'), ";
							}
									
						}
						else
						{
							data_value = "'" + ds_xml.Tables[h].Rows[i].ItemArray[j].ToString().Replace("'", "''") + "', " ; 
						}


						col_list   = col_list   + col_name;
						value_list = value_list + data_value;

					}

					col_list   = col_list.Substring(0, col_list.Length-2);
					value_list = value_list.Substring(0, value_list.Length-2); 

					string sql = " INSERT INTO "+ table +" "	
									+ " (" + col_list +")  "
									+ " VALUES (" + value_list + ")";
 

					query_array.Add(sql);


				} // end for(int j = start_col ; j < end_col ; j++)
  


			} // end for table count for(int i = 0 ; i < row ; i++)




			// 트랜잭션 처리 한 쿼리 실행
			update_query = (string[])query_array.ToArray(typeof(string) ); 

			string db_result = Execute_Query(update_query);


			// ret 결과 값이 숫자이면 정상
			// 숫자가 아니면 오류 메세지 이므로 실패
			double temp = 0; 


			try      // 성공
			{

				temp = Convert.ToDouble(db_result);  

				ClassLib.ComFunction.User_Message("Restore Complete.", "Run Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}
			catch  // 실패
			{ 

				ds_xml.Dispose();
				ds_ret.Dispose();
						 

				ClassLib.ComFunction.User_Message("Restore Failed.", "Run Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);

			} 

	





		}


		/// <summary>
		/// Execute_Query : 
		/// </summary>
		/// <param name="arg_query"></param>
		/// <returns></returns>
		private string Execute_Query(string[] arg_query)
		{

		

			try
			{

				string[] RunUser = COM.ComFunction.Set_UserInfo(COM.ComVar.Log_Type.Write_File_DB); 

				string ret = Convert.ToString(ClassLib.ComVar._WebSvc.Ora_MultiModify(RunUser, arg_query)); 
				
				return ret.ToString(); 
 
				
			}
			catch
			{  
				return "";
			}



		}





		#endregion

		

		#endregion 
		
		#region 이벤트 처리


		private void fgrid_Head_DoubleClick(object sender, System.EventArgs e)
		{
		
			
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Display_Detail(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		private void cmb_TableName_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;

				if(cmb_TableName.SelectedIndex == -1) return;

				Search(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_TableName_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;


				Search(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

	
		private void btn_Apply_Click(object sender, System.EventArgs e)
		{


			try
			{


				this.Cursor = Cursors.WaitCursor;


				Run_Restore();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}
 


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{ 

			_Cancel_Flag = true; 

			this.Close();

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

		private void Pop_Yield_Backup_Restore_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
		

			try
			{

			
//				// 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
//				string start_path = Application.StartupPath.ToString() +  "\\" + "Yield_Backup" + "\\";
//				string directory_name = _Factory + "_" + _StyleCd.Replace("-", "");
//				string directory_full_name = start_path + directory_name;
//
//
//				if( ! System.IO.Directory.Exists(directory_full_name) )
//				{
//					System.IO.Directory.CreateDirectory(directory_full_name); 
//				}
//
// 
//
//				//--------------------------------------------------------------------------
//				// 복구 완료 후 xml 파일은 모두 삭제 처리
//				//--------------------------------------------------------------------------
//				if( Directory.Exists(directory_full_name) )
//				{
//
//					ArrayList extensions_array = new ArrayList(); 
//					extensions_array.Add(".XML");
//					RecursiveFileExplorer.FileExplorer file_explorer = new RecursiveFileExplorer.FileExplorer(directory_full_name, extensions_array, true); 
//					
//					if(file_explorer.FileList.Count > 0)
//					{
//
//						DirectoryInfo dir = new DirectoryInfo(directory_full_name);   
//
//						foreach ( FileSystemInfo entry in dir.GetFileSystemInfos() )
//						{
//
//							if(entry.Extension == "" || entry.Extension != ".XML") continue;
//
//							if (File.Exists(entry.FullName))
//							{
//								File.Delete(entry.FullName);
//							}
//
//							
//
//						} // end foreach
// 
//					} // end if(file_explorer.FileList.Count > 0) 
//
//				} // if( Directory.Exists(  ) )
//
//
//				//--------------------------------------------------------------------------


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}






		}

		

		#endregion

		#region DB Connect




		#endregion   

	



	}
}

