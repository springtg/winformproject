using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing; 
using System.IO;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

using C1.Win.C1List;

namespace FlexPurchase.Search
{
	public struct Proviso
	{
		public string where;
		public string[] param;
		public string val;
		public object control;
	}

	public class Form_BW_Query_Analysis : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_file;
		private System.Windows.Forms.Label btn_excel;
		private System.Windows.Forms.Label btn_dialog;
		private System.Windows.Forms.TextBox txt_fileName;
		private C1.Win.C1List.C1Combo cmb_fileName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_run;
		private System.Windows.Forms.TextBox txt_desc;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel3;
		private COM.SSP spd_main;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_descShow;
		private System.Windows.Forms.MenuItem mnu_descHide;
		private System.Windows.Forms.TextBox txt_prov;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.TextBox txt_query;

		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;

		private System.ComponentModel.IContainer components = null;

		#endregion
		
		#region 사용자가 추가한 변수
		
		private const string QUERY_DIR = @"\Query";
		private const string CMB_COL1 = "File Name";
		private const string CMB_COL2 = ":: select report ::";

		private const string QUERY_FILE = ".sql";
		private const string DESC_FILE = ".desc";
		private const string _startCol = "A", _endCol = "IV";
		private const int SEQ = 0, PARAM_NAME = 1, PARAM_TYPE = 2, COM_CD = 3;
		
		private Hashtable _ht;
		private string _query;

		private COM.OraDB MyOraDB	= new COM.OraDB();
		private Pop_BW_QE_Wait _waitPop	= new Pop_BW_QE_Wait();
		
		#endregion

		#region 생성자 / 소멸자

		public Form_BW_Query_Analysis()
		{
			InitializeComponent();
			initForm();
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BW_Query_Analysis));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.txt_prov = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_dialog = new System.Windows.Forms.Label();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.btn_excel = new System.Windows.Forms.Label();
            this.cmb_fileName = new C1.Win.C1List.C1Combo();
            this.lbl_file = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnu_descShow = new System.Windows.Forms.MenuItem();
            this.mnu_descHide = new System.Windows.Forms.MenuItem();
            this.splitter2 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_fileName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.spd_main);
            this.panel3.Location = new System.Drawing.Point(8, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 386);
            this.panel3.TabIndex = 5;
            // 
            // spd_main
            // 
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 386);
            this.spd_main.TabIndex = 0;
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_query);
            this.panel2.Controls.Add(this.splitter3);
            this.panel2.Controls.Add(this.txt_prov);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.txt_desc);
            this.panel2.Location = new System.Drawing.Point(8, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 100);
            this.panel2.TabIndex = 4;
            // 
            // txt_query
            // 
            this.txt_query.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_query.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_query.Location = new System.Drawing.Point(779, 0);
            this.txt_query.Multiline = true;
            this.txt_query.Name = "txt_query";
            this.txt_query.ReadOnly = true;
            this.txt_query.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_query.Size = new System.Drawing.Size(221, 100);
            this.txt_query.TabIndex = 5;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(776, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 100);
            this.splitter3.TabIndex = 4;
            this.splitter3.TabStop = false;
            // 
            // txt_prov
            // 
            this.txt_prov.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_prov.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_prov.Location = new System.Drawing.Point(475, 0);
            this.txt_prov.Multiline = true;
            this.txt_prov.Name = "txt_prov";
            this.txt_prov.ReadOnly = true;
            this.txt_prov.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_prov.Size = new System.Drawing.Size(301, 100);
            this.txt_prov.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(472, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 100);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_desc.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_desc.Location = new System.Drawing.Point(0, 0);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_desc.Size = new System.Drawing.Size(472, 100);
            this.txt_desc.TabIndex = 1;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_dialog);
            this.pnl_head.Controls.Add(this.txt_fileName);
            this.pnl_head.Controls.Add(this.btn_excel);
            this.pnl_head.Controls.Add(this.cmb_fileName);
            this.pnl_head.Controls.Add(this.lbl_file);
            this.pnl_head.Controls.Add(this.btn_run);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 74);
            this.pnl_head.TabIndex = 2;
            // 
            // btn_dialog
            // 
            this.btn_dialog.BackColor = System.Drawing.SystemColors.Window;
            this.btn_dialog.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dialog.ImageIndex = 27;
            this.btn_dialog.ImageList = this.img_SmallButton;
            this.btn_dialog.Location = new System.Drawing.Point(720, 40);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(24, 21);
            this.btn_dialog.TabIndex = 542;
            this.btn_dialog.Tag = "Search";
            this.btn_dialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // txt_fileName
            // 
            this.txt_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fileName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_fileName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_fileName.Location = new System.Drawing.Point(109, 40);
            this.txt_fileName.MaxLength = 10;
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(210, 21);
            this.txt_fileName.TabIndex = 541;
            this.txt_fileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_fileName_KeyUp);
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_excel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ImageIndex = 0;
            this.btn_excel.ImageList = this.img_Button;
            this.btn_excel.Location = new System.Drawing.Point(912, 40);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(80, 24);
            this.btn_excel.TabIndex = 540;
            this.btn_excel.Text = "Excel";
            this.btn_excel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            this.btn_excel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_excel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // cmb_fileName
            // 
            this.cmb_fileName.AddItemSeparator = ';';
            this.cmb_fileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_fileName.Caption = "";
            this.cmb_fileName.CaptionHeight = 17;
            this.cmb_fileName.CaptionStyle = style1;
            this.cmb_fileName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_fileName.ColumnCaptionHeight = 18;
            this.cmb_fileName.ColumnFooterHeight = 18;
            this.cmb_fileName.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_fileName.ContentHeight = 17;
            this.cmb_fileName.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_fileName.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_fileName.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_fileName.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_fileName.EditorHeight = 17;
            this.cmb_fileName.EvenRowStyle = style2;
            this.cmb_fileName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fileName.FooterStyle = style3;
            this.cmb_fileName.HeadingStyle = style4;
            this.cmb_fileName.HighLightRowStyle = style5;
            this.cmb_fileName.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_fileName.Images"))));
            this.cmb_fileName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_fileName.ItemHeight = 15;
            this.cmb_fileName.Location = new System.Drawing.Point(320, 40);
            this.cmb_fileName.MatchEntryTimeout = ((long)(2000));
            this.cmb_fileName.MaxDropDownItems = ((short)(5));
            this.cmb_fileName.MaxLength = 32767;
            this.cmb_fileName.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_fileName.Name = "cmb_fileName";
            this.cmb_fileName.OddRowStyle = style6;
            this.cmb_fileName.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_fileName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_fileName.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_fileName.SelectedStyle = style7;
            this.cmb_fileName.Size = new System.Drawing.Size(400, 21);
            this.cmb_fileName.Style = style8;
            this.cmb_fileName.TabIndex = 539;
            this.cmb_fileName.Close += new C1.Win.C1List.CloseEventHandler(this.cmb_fileName_Close);
            this.cmb_fileName.PropBag = resources.GetString("cmb_fileName.PropBag");
            // 
            // lbl_file
            // 
            this.lbl_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_file.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file.ImageIndex = 1;
            this.lbl_file.ImageList = this.img_Label;
            this.lbl_file.Location = new System.Drawing.Point(8, 40);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(100, 21);
            this.lbl_file.TabIndex = 538;
            this.lbl_file.Text = "File Name";
            this.lbl_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_run.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.ImageIndex = 0;
            this.btn_run.ImageList = this.img_Button;
            this.btn_run.Location = new System.Drawing.Point(832, 40);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(80, 24);
            this.btn_run.TabIndex = 537;
            this.btn_run.Text = "Run";
            this.btn_run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            this.btn_run.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_run.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 393;
            this.label2.Text = "      Query Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 58);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 57);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 33);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 58);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 56);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(920, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_descShow,
            this.mnu_descHide});
            this.menuItem1.Text = "Description";
            // 
            // mnu_descShow
            // 
            this.mnu_descShow.Index = 0;
            this.mnu_descShow.Text = "Shot";
            this.mnu_descShow.Click += new System.EventHandler(this.mnu_descShow_Click);
            // 
            // mnu_descHide
            // 
            this.mnu_descHide.Index = 1;
            this.mnu_descHide.Text = "Hide";
            this.mnu_descHide.Click += new System.EventHandler(this.mnu_descHide_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(731, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 100);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // Form_BW_Query_Analysis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.ContextMenu = this.ctx_main;
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BW_Query_Analysis";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_fileName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 핸들러

		private void btn_run_Click(object sender, System.EventArgs e)
		{
			if (!txt_query.Text.Equals(""))
			{
				run();
			}
		}

		private void txt_fileName_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				directSearch();
		}

		private void cmb_fileName_Close(object sender, System.EventArgs e)
		{
			if (cmb_fileName.SelectedValue != null)
			{
				if (!cmb_fileName.SelectedValue.ToString().Equals(""))
				{
					loadFile(cmb_fileName.SelectedValue.ToString());
					showProv();
					loadDesc(cmb_fileName.GetItemText(cmb_fileName.SelectedIndex, 1));
				}
				else
				{
					txt_query.Text = "";
					txt_desc.Text = "";
					initGrid();
				}
			}
		}

		private void btn_excel_Click(object sender, System.EventArgs e)
		{
			if (spd_main.ActiveSheet.RowCount > 0)
			{
				showProv();
				makeExcel();
			}
		}

		private void btn_dialog_Click(object sender, System.EventArgs e)
		{
			dialogSearch();
		}

		private void mnu_descShow_Click(object sender, System.EventArgs e)
		{
			this.c1Sizer1.Grid.Rows[1].Size = 100;
		}

		private void mnu_descHide_Click(object sender, System.EventArgs e)
		{
			this.c1Sizer1.Grid.Rows[1].Size = 0;
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		#region 컨트롤 이벤트 처리

		private void initForm()
		{

            //Title
            this.Text = "Query Analysis";
            this.lbl_MainTitle.Text = "Query Analysis";
            ClassLib.ComFunction.SetLangDic(this);


			initCombo();
			initGrid();
		}

		private void initCombo()
		{
			cmb_fileName.DataMode = DataModeEnum.AddItem;
			cmb_fileName.AddItemTitles(CMB_COL1 + ";" + CMB_COL2);
			cmb_fileName.ValueMember = CMB_COL1;
			cmb_fileName.DisplayMember = CMB_COL2;
			directSearch();
		}

		private void initGrid()
		{
			spd_main.Set_Spread_Comm("SBW_QUERY_ANALYSIS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			spd_main.ActiveSheet.ColumnHeader.Columns[0].Width = spd_main.Width;
		}

		private void directSearch()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				cmb_fileName.ClearItems();
				cmb_fileName.DataMode = DataModeEnum.AddItem;

				DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + QUERY_DIR);
				FileInfo[] files = dir.GetFiles();

				for (int i = 0 ; i < files.Length ; i++)
				{
					if (files[i].Name.IndexOf(txt_fileName.Text) > -1 && files[i].Extension.ToLower().Equals(QUERY_FILE))
						cmb_fileName.AddItem(files[i].FullName + ";" + files[i].Name.ToLower().Replace(QUERY_FILE, ""));
				}

				cmb_fileName.Splits[0].DisplayColumns[0].Width = 0;
				cmb_fileName.Splits[0].DisplayColumns[1].Width = 400;
				cmb_fileName.SelectedIndex = -1;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void dialogSearch()
		{
			try
			{
				OpenFileDialog ofd = new OpenFileDialog();
				ofd.Filter = "sql(*.sql)|*.sql";
				ofd.Multiselect = false;
				ofd.InitialDirectory = Application.StartupPath + QUERY_DIR;

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					cmb_fileName.SelectedIndex = -1;
					loadFile(ofd.FileName);
					showProv();
					loadDesc(ofd.FileName);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void makeExcel()
		{
			this.Cursor = Cursors.WaitCursor;

			Excel.Application oXL;
			Excel._Workbook oWB;
			Excel._Worksheet oSheet;

			try
			{
				Thread thread = new Thread(new ThreadStart(_waitPop.Start));
				thread.Start();
				
				this.Cursor = Cursors.WaitCursor;

				//Start Excel and get Application object.
				oXL = new Excel.Application();
				
				oXL.Visible = false;
				oXL.UserControl = false;

				//Get a new workbook.
				oWB = (Excel._Workbook)(oXL.Workbooks.Add(true));
				oSheet = (Excel._Worksheet)oWB.ActiveSheet;

				object[,] values = new object[spd_main.ActiveSheet.Rows.Count + 2, spd_main.ActiveSheet.Columns.Count];

				// parameter
				string[] provs = txt_prov.Text.Split('\n');
				values[0, 0] = "검색조건";
				for (int vCol = 0, cIdx = 2 ; vCol < provs.Length ; vCol++)
				{
					values[0, cIdx] = provs[vCol].Replace("\r", "");
					cIdx++;
				}

				// data
				for (int vRow = 0, rIdx = 1 ; vRow < spd_main.ActiveSheet.ColumnHeader.Rows.Count ; vRow++)
				{
					for (int vCol = 0, cIdx = 0 ; vCol < spd_main.ActiveSheet.Columns.Count ; vCol++)
					{
						values[rIdx, cIdx] = spd_main.ActiveSheet.ColumnHeader.Cells[vRow, vCol];
						cIdx++;
					}
					
					rIdx++;
				}

				// data
				for (int vRow = 0, rIdx = 2 ; vRow < spd_main.ActiveSheet.Rows.Count ; vRow++)
				{
					for (int vCol = 0, cIdx = 0 ; vCol < spd_main.ActiveSheet.Columns.Count ; vCol++)
					{
						values[rIdx, cIdx] = spd_main.ActiveSheet.Cells[vRow, vCol];
						cIdx++;
					}
					
					rIdx++;
				}

				oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[spd_main.ActiveSheet.Rows.Count + 2, spd_main.ActiveSheet.Columns.Count]).NumberFormat = "@";
				oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[spd_main.ActiveSheet.Rows.Count + 2, spd_main.ActiveSheet.Columns.Count]).Value2 = values;

				//oSheet.get_Range(_startCol + 1, _endCol + spd_main.ActiveSheet.Rows.Count + 2).NumberFormat = "@";
				//oSheet.get_Range(_startCol + 1, _endCol + spd_main.ActiveSheet.Rows.Count + 2).Value2 = values;

				oXL.Visible = true;
				oXL.UserControl = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				oSheet = null;
				oWB = null;
				oXL = null;
				GC.Collect();
				_waitPop.Hide();
			}
		}

		private void run()
		{
			try
			{
				txt_query.Text = _query;
				Pop_BW_QE_Parameter pop = new Pop_BW_QE_Parameter(this);

				if (pop.ShowDialog() == DialogResult.OK)
				{
                    //Thread thread = new Thread(new ThreadStart(_waitPop.Start));
                    //thread.Start();
				
					string query = txt_query.Text;
					IEnumerator ienum = _ht.Values.GetEnumerator();

					while (ienum.MoveNext())
					{
						Proviso prov = (Proviso)ienum.Current;
						query = query.Replace(prov.where, "'" + prov.val + "'");
					}

					txt_query.Text = query;

					DataTable vDt = EXECUTE_QUERY(txt_query.Text);
					if (vDt.Rows.Count > 0) 
					{
						gridSetValue(vDt);
						showProv();
					}
					else
					{
						initGrid();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
            //finally
            //{
            //    _waitPop.Hide();
            //}
		}

		#endregion 

		#region Utility

		private void loadFile(string arg_file)
		{
			Hashtable ht = new Hashtable();

			string query = "";

			FileStream file = null;
			TextReader tr = null;

			try
			{
				file = new FileStream(arg_file, FileMode.Open);
				tr = new System.IO.StreamReader(file, System.Text.Encoding.Default);
				query = tr.ReadToEnd();

				string[] line = query.Split('\n');

				for (int i = 0 ; i < line.Length ; i++)
				{
					while (line[i].IndexOf("[") > -1)
					{
						int si = line[i].IndexOf("[");
						int ei = line[i].IndexOf("]");

						string where = line[i].Substring((si + 1), (ei - si - 1));
						string[] param = where.Split(';');

						Proviso prov = new Proviso();
						prov.where = "[" + where + "]";
						prov.param = param;	

						ht.Add(where, prov);
						line[i] = line[i].Replace(prov.where, "");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (tr != null) tr.Close();
				if (file != null) file.Close();

				txt_query.Text = query;

				_ht = ht;
				_query = query;
			}
		}

		private void loadDesc(string arg_file)
		{
			string query = txt_query.Text;
			int sp = query.IndexOf("/*"); 
			int ep = query.IndexOf("*/");

			txt_desc.Text = "Report :: " + arg_file + "\r\n\r\n";
			
			if (sp > -1 && ep > -1)
				txt_desc.Text += query.Substring(sp + 3, ep - sp - 3);
		}

		private void showProv()
		{
			try
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();

				foreach (Proviso p in _ht.Values)
				{
					sb.Append(p.param[PARAM_NAME] + " : " + p.val + "\r\n");
				}

				txt_prov.Text = sb.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void gridSetValue(DataTable arg_dt)
		{
			try
			{
				spd_main.ActiveSheet.Columns.Count = 0;
				spd_main.ActiveSheet.Columns.Count = arg_dt.Rows[0].ItemArray.Length;

				// header set
				for (int vCol = 0 ; vCol < arg_dt.Columns.Count ; vCol++)
				{
					spd_main.ActiveSheet.ColumnHeader.Cells[0, vCol].Value = arg_dt.Columns[vCol].Caption;
				}

				// data set
				spd_main.ActiveSheet.DataSource = arg_dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public Hashtable ParamList
		{
			set
			{
				_ht = value;
			}
			get
			{
				return _ht;
			}
		}

		#endregion

		#region DB Connect
	
		/// <summary>
		/// EXECUTE_QUERY
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable EXECUTE_QUERY(string arg_query) 
		{
			DataSet vds_ret;
			vds_ret = MyOraDB.Exe_Select_Query(arg_query);
			if(vds_ret.Tables.Count <= 0) return null ;
			return vds_ret.Tables[0];
		}

		#endregion



	}
}

