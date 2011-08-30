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

namespace FlexCDC.Purchase
{
	public class Form_Pur_request_master : COM.PCHWinForm.Form_Top
	{		

		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Error;
		private System.Windows.Forms.TextBox txt_Err;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_Grid;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Label lbl_req_date;
		private System.Windows.Forms.DateTimePicker dpk_req_to;
		private System.Windows.Forms.Label lbl_hp;
		private System.Windows.Forms.Label lbl_req_no;
		public C1.Win.C1List.C1Combo cmb_req_dept;
		public C1.Win.C1List.C1Combo cmb_req_user;
		private System.Windows.Forms.Label lbl_req_user;
		private System.Windows.Forms.Label lbl_req_dept;
		private System.Windows.Forms.Label lbl_req_status;
		private System.Windows.Forms.DateTimePicker dpk_req_from;
		private System.Windows.Forms.Label lbl_req_reason;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_req_status;
		private C1.Win.C1List.C1Combo cmb_req_no;
		private C1.Win.C1List.C1Combo cmb_req_reason;
		private System.Windows.Forms.ContextMenu contextMenu1;
		public COM.FSP flg_request1;
		private System.Windows.Forms.MenuItem cmt_ADD_Item;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem cmt_Value_Change;
		private System.Windows.Forms.MenuItem cmt_Season;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem cmt_Delete_Item;
		private C1.Win.C1List.C1Combo com_req_division;
		


		public Form_Pur_request_master()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pur_request_master));
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
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_req_reason = new C1.Win.C1List.C1Combo();
            this.cmb_req_no = new C1.Win.C1List.C1Combo();
            this.cmb_req_status = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_req_reason = new System.Windows.Forms.Label();
            this.dpk_req_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_req_status = new System.Windows.Forms.Label();
            this.lbl_req_dept = new System.Windows.Forms.Label();
            this.cmb_req_user = new C1.Win.C1List.C1Combo();
            this.lbl_req_user = new System.Windows.Forms.Label();
            this.cmb_req_dept = new C1.Win.C1List.C1Combo();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.dpk_req_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_req_date = new System.Windows.Forms.Label();
            this.lbl_req_no = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.com_req_division = new C1.Win.C1List.C1Combo();
            this.pnl_Error = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.txt_Err = new System.Windows.Forms.TextBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.flg_request1 = new COM.FSP();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.cmt_ADD_Item = new System.Windows.Forms.MenuItem();
            this.cmt_Delete_Item = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.cmt_Value_Change = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.cmt_Season = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_dept)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_req_division)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flg_request1)).BeginInit();
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
            // c1CommandLink1
            // 
            this.c1CommandLink1.Text = "Create Request";
            this.c1CommandLink1.ToolTipText = "Create Request";
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_req_reason);
            this.pnl_Top.Controls.Add(this.cmb_req_no);
            this.pnl_Top.Controls.Add(this.cmb_req_status);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_req_reason);
            this.pnl_Top.Controls.Add(this.dpk_req_from);
            this.pnl_Top.Controls.Add(this.lbl_req_status);
            this.pnl_Top.Controls.Add(this.lbl_req_dept);
            this.pnl_Top.Controls.Add(this.cmb_req_user);
            this.pnl_Top.Controls.Add(this.lbl_req_user);
            this.pnl_Top.Controls.Add(this.cmb_req_dept);
            this.pnl_Top.Controls.Add(this.lbl_hp);
            this.pnl_Top.Controls.Add(this.dpk_req_to);
            this.pnl_Top.Controls.Add(this.lbl_req_date);
            this.pnl_Top.Controls.Add(this.lbl_req_no);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 56);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 120);
            this.pnl_Top.TabIndex = 135;
            // 
            // cmb_req_reason
            // 
            this.cmb_req_reason.AddItemCols = 0;
            this.cmb_req_reason.AddItemSeparator = ';';
            this.cmb_req_reason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_reason.Caption = "";
            this.cmb_req_reason.CaptionHeight = 17;
            this.cmb_req_reason.CaptionStyle = style1;
            this.cmb_req_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_reason.ColumnCaptionHeight = 18;
            this.cmb_req_reason.ColumnFooterHeight = 18;
            this.cmb_req_reason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_reason.ContentHeight = 17;
            this.cmb_req_reason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_reason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_reason.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_reason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_reason.EditorHeight = 17;
            this.cmb_req_reason.EvenRowStyle = style2;
            this.cmb_req_reason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_reason.FooterStyle = style3;
            this.cmb_req_reason.GapHeight = 2;
            this.cmb_req_reason.HeadingStyle = style4;
            this.cmb_req_reason.HighLightRowStyle = style5;
            this.cmb_req_reason.ItemHeight = 15;
            this.cmb_req_reason.Location = new System.Drawing.Point(117, 80);
            this.cmb_req_reason.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_reason.MaxDropDownItems = ((short)(5));
            this.cmb_req_reason.MaxLength = 32767;
            this.cmb_req_reason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_reason.Name = "cmb_req_reason";
            this.cmb_req_reason.OddRowStyle = style6;
            this.cmb_req_reason.PartialRightColumn = false;
            this.cmb_req_reason.PropBag = resources.GetString("cmb_req_reason.PropBag");
            this.cmb_req_reason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_reason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_reason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_reason.SelectedStyle = style7;
            this.cmb_req_reason.Size = new System.Drawing.Size(211, 21);
            this.cmb_req_reason.Style = style8;
            this.cmb_req_reason.TabIndex = 353;
            // 
            // cmb_req_no
            // 
            this.cmb_req_no.AddItemCols = 0;
            this.cmb_req_no.AddItemSeparator = ';';
            this.cmb_req_no.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_no.Caption = "";
            this.cmb_req_no.CaptionHeight = 17;
            this.cmb_req_no.CaptionStyle = style9;
            this.cmb_req_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_no.ColumnCaptionHeight = 18;
            this.cmb_req_no.ColumnFooterHeight = 18;
            this.cmb_req_no.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_no.ContentHeight = 17;
            this.cmb_req_no.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_no.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_no.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_no.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_no.EditorHeight = 17;
            this.cmb_req_no.EvenRowStyle = style10;
            this.cmb_req_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_no.FooterStyle = style11;
            this.cmb_req_no.GapHeight = 2;
            this.cmb_req_no.HeadingStyle = style12;
            this.cmb_req_no.HighLightRowStyle = style13;
            this.cmb_req_no.ItemHeight = 15;
            this.cmb_req_no.Location = new System.Drawing.Point(773, 58);
            this.cmb_req_no.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_no.MaxDropDownItems = ((short)(5));
            this.cmb_req_no.MaxLength = 32767;
            this.cmb_req_no.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_no.Name = "cmb_req_no";
            this.cmb_req_no.OddRowStyle = style14;
            this.cmb_req_no.PartialRightColumn = false;
            this.cmb_req_no.PropBag = resources.GetString("cmb_req_no.PropBag");
            this.cmb_req_no.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_no.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_no.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_no.SelectedStyle = style15;
            this.cmb_req_no.Size = new System.Drawing.Size(211, 21);
            this.cmb_req_no.Style = style16;
            this.cmb_req_no.TabIndex = 352;
            this.cmb_req_no.SelectedValueChanged += new System.EventHandler(this.cmb_req_no_SelectedValueChanged);
            // 
            // cmb_req_status
            // 
            this.cmb_req_status.AddItemCols = 0;
            this.cmb_req_status.AddItemSeparator = ';';
            this.cmb_req_status.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_status.Caption = "";
            this.cmb_req_status.CaptionHeight = 17;
            this.cmb_req_status.CaptionStyle = style17;
            this.cmb_req_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_status.ColumnCaptionHeight = 18;
            this.cmb_req_status.ColumnFooterHeight = 18;
            this.cmb_req_status.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_status.ContentHeight = 17;
            this.cmb_req_status.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_status.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_status.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_status.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_status.EditorHeight = 17;
            this.cmb_req_status.EvenRowStyle = style18;
            this.cmb_req_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_status.FooterStyle = style19;
            this.cmb_req_status.GapHeight = 2;
            this.cmb_req_status.HeadingStyle = style20;
            this.cmb_req_status.HighLightRowStyle = style21;
            this.cmb_req_status.ItemHeight = 15;
            this.cmb_req_status.Location = new System.Drawing.Point(117, 58);
            this.cmb_req_status.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_status.MaxDropDownItems = ((short)(5));
            this.cmb_req_status.MaxLength = 32767;
            this.cmb_req_status.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_status.Name = "cmb_req_status";
            this.cmb_req_status.OddRowStyle = style22;
            this.cmb_req_status.PartialRightColumn = false;
            this.cmb_req_status.PropBag = resources.GetString("cmb_req_status.PropBag");
            this.cmb_req_status.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_status.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_status.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_status.SelectedStyle = style23;
            this.cmb_req_status.Size = new System.Drawing.Size(211, 21);
            this.cmb_req_status.Style = style24;
            this.cmb_req_status.TabIndex = 351;
            this.cmb_req_status.SelectedValueChanged += new System.EventHandler(this.cmb_req_status_SelectedValueChanged);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
            this.cmb_Factory.Size = new System.Drawing.Size(211, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 350;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_req_reason
            // 
            this.lbl_req_reason.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_reason.ImageIndex = 0;
            this.lbl_req_reason.ImageList = this.img_Label;
            this.lbl_req_reason.Location = new System.Drawing.Point(16, 80);
            this.lbl_req_reason.Name = "lbl_req_reason";
            this.lbl_req_reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_reason.TabIndex = 327;
            this.lbl_req_reason.Text = "Req. Reason";
            this.lbl_req_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpk_req_from
            // 
            this.dpk_req_from.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_from.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_req_from.Location = new System.Drawing.Point(445, 58);
            this.dpk_req_from.Name = "dpk_req_from";
            this.dpk_req_from.Size = new System.Drawing.Size(100, 22);
            this.dpk_req_from.TabIndex = 324;
            this.dpk_req_from.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            this.dpk_req_from.CloseUp += new System.EventHandler(this.dpk_req_from_CloseUp);
            // 
            // lbl_req_status
            // 
            this.lbl_req_status.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_status.ImageIndex = 0;
            this.lbl_req_status.ImageList = this.img_Label;
            this.lbl_req_status.Location = new System.Drawing.Point(16, 58);
            this.lbl_req_status.Name = "lbl_req_status";
            this.lbl_req_status.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_status.TabIndex = 322;
            this.lbl_req_status.Text = "Req. Status";
            this.lbl_req_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_req_dept
            // 
            this.lbl_req_dept.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_dept.ImageIndex = 0;
            this.lbl_req_dept.ImageList = this.img_Label;
            this.lbl_req_dept.Location = new System.Drawing.Point(344, 36);
            this.lbl_req_dept.Name = "lbl_req_dept";
            this.lbl_req_dept.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_dept.TabIndex = 321;
            this.lbl_req_dept.Text = "Req. Dept.";
            this.lbl_req_dept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_req_user
            // 
            this.cmb_req_user.AddItemCols = 0;
            this.cmb_req_user.AddItemSeparator = ';';
            this.cmb_req_user.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_user.Caption = "";
            this.cmb_req_user.CaptionHeight = 17;
            this.cmb_req_user.CaptionStyle = style33;
            this.cmb_req_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_user.ColumnCaptionHeight = 18;
            this.cmb_req_user.ColumnFooterHeight = 18;
            this.cmb_req_user.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_user.ContentHeight = 16;
            this.cmb_req_user.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_user.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_user.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_user.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_user.EditorHeight = 16;
            this.cmb_req_user.EvenRowStyle = style34;
            this.cmb_req_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_user.FooterStyle = style35;
            this.cmb_req_user.GapHeight = 2;
            this.cmb_req_user.HeadingStyle = style36;
            this.cmb_req_user.HighLightRowStyle = style37;
            this.cmb_req_user.ItemHeight = 15;
            this.cmb_req_user.Location = new System.Drawing.Point(773, 36);
            this.cmb_req_user.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_user.MaxDropDownItems = ((short)(5));
            this.cmb_req_user.MaxLength = 32767;
            this.cmb_req_user.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_user.Name = "cmb_req_user";
            this.cmb_req_user.OddRowStyle = style38;
            this.cmb_req_user.PartialRightColumn = false;
            this.cmb_req_user.PropBag = resources.GetString("cmb_req_user.PropBag");
            this.cmb_req_user.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_user.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_user.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_user.SelectedStyle = style39;
            this.cmb_req_user.Size = new System.Drawing.Size(210, 20);
            this.cmb_req_user.Style = style40;
            this.cmb_req_user.TabIndex = 320;
            // 
            // lbl_req_user
            // 
            this.lbl_req_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_user.ImageIndex = 0;
            this.lbl_req_user.ImageList = this.img_Label;
            this.lbl_req_user.Location = new System.Drawing.Point(672, 36);
            this.lbl_req_user.Name = "lbl_req_user";
            this.lbl_req_user.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_user.TabIndex = 319;
            this.lbl_req_user.Text = "Req. User";
            this.lbl_req_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_req_dept
            // 
            this.cmb_req_dept.AddItemCols = 0;
            this.cmb_req_dept.AddItemSeparator = ';';
            this.cmb_req_dept.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_req_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_req_dept.Caption = "";
            this.cmb_req_dept.CaptionHeight = 17;
            this.cmb_req_dept.CaptionStyle = style41;
            this.cmb_req_dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_req_dept.ColumnCaptionHeight = 18;
            this.cmb_req_dept.ColumnFooterHeight = 18;
            this.cmb_req_dept.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_req_dept.ContentHeight = 16;
            this.cmb_req_dept.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_req_dept.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_req_dept.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_dept.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_req_dept.EditorHeight = 16;
            this.cmb_req_dept.EvenRowStyle = style42;
            this.cmb_req_dept.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_req_dept.FooterStyle = style43;
            this.cmb_req_dept.GapHeight = 2;
            this.cmb_req_dept.HeadingStyle = style44;
            this.cmb_req_dept.HighLightRowStyle = style45;
            this.cmb_req_dept.ItemHeight = 15;
            this.cmb_req_dept.Location = new System.Drawing.Point(445, 36);
            this.cmb_req_dept.MatchEntryTimeout = ((long)(2000));
            this.cmb_req_dept.MaxDropDownItems = ((short)(5));
            this.cmb_req_dept.MaxLength = 32767;
            this.cmb_req_dept.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_req_dept.Name = "cmb_req_dept";
            this.cmb_req_dept.OddRowStyle = style46;
            this.cmb_req_dept.PartialRightColumn = false;
            this.cmb_req_dept.PropBag = resources.GetString("cmb_req_dept.PropBag");
            this.cmb_req_dept.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_req_dept.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_req_dept.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_req_dept.SelectedStyle = style47;
            this.cmb_req_dept.Size = new System.Drawing.Size(210, 20);
            this.cmb_req_dept.Style = style48;
            this.cmb_req_dept.TabIndex = 318;
            this.cmb_req_dept.SelectedValueChanged += new System.EventHandler(this.cmb_req_dept_SelectedValueChanged);
            // 
            // lbl_hp
            // 
            this.lbl_hp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hp.Location = new System.Drawing.Point(545, 56);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(10, 21);
            this.lbl_hp.TabIndex = 315;
            this.lbl_hp.Text = "~";
            this.lbl_hp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpk_req_to
            // 
            this.dpk_req_to.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_to.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_req_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_req_to.Location = new System.Drawing.Point(557, 58);
            this.dpk_req_to.Name = "dpk_req_to";
            this.dpk_req_to.Size = new System.Drawing.Size(100, 22);
            this.dpk_req_to.TabIndex = 314;
            this.dpk_req_to.CloseUp += new System.EventHandler(this.dpk_req_from_CloseUp);
            // 
            // lbl_req_date
            // 
            this.lbl_req_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_date.ImageIndex = 0;
            this.lbl_req_date.ImageList = this.img_Label;
            this.lbl_req_date.Location = new System.Drawing.Point(344, 58);
            this.lbl_req_date.Name = "lbl_req_date";
            this.lbl_req_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_date.TabIndex = 313;
            this.lbl_req_date.Text = "Req. Date";
            this.lbl_req_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_req_no
            // 
            this.lbl_req_no.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_req_no.ImageIndex = 0;
            this.lbl_req_no.ImageList = this.img_Label;
            this.lbl_req_no.Location = new System.Drawing.Point(672, 58);
            this.lbl_req_no.Name = "lbl_req_no";
            this.lbl_req_no.Size = new System.Drawing.Size(100, 21);
            this.lbl_req_no.TabIndex = 309;
            this.lbl_req_no.Text = "Req. No.";
            this.lbl_req_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 112);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(219, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
            this.picb_TM.TabIndex = 113;
            this.picb_TM.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "      Request Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_openfile
            // 
            this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
            this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfile.Location = new System.Drawing.Point(426, 36);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(21, 21);
            this.btn_openfile.TabIndex = 112;
            this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 69);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(144, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 79);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(150, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // com_req_division
            // 
            this.com_req_division.AddItemCols = 0;
            this.com_req_division.AddItemSeparator = ';';
            this.com_req_division.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.com_req_division.Caption = "";
            this.com_req_division.CaptionHeight = 17;
            this.com_req_division.CaptionStyle = style49;
            this.com_req_division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.com_req_division.ColumnCaptionHeight = 18;
            this.com_req_division.ColumnFooterHeight = 18;
            this.com_req_division.ContentHeight = 16;
            this.com_req_division.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.com_req_division.EditorBackColor = System.Drawing.SystemColors.Window;
            this.com_req_division.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.com_req_division.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.com_req_division.EditorHeight = 16;
            this.com_req_division.EvenRowStyle = style50;
            this.com_req_division.FooterStyle = style51;
            this.com_req_division.GapHeight = 2;
            this.com_req_division.HeadingStyle = style52;
            this.com_req_division.HighLightRowStyle = style53;
            this.com_req_division.ItemHeight = 15;
            this.com_req_division.Location = new System.Drawing.Point(0, 0);
            this.com_req_division.MatchEntryTimeout = ((long)(2000));
            this.com_req_division.MaxDropDownItems = ((short)(5));
            this.com_req_division.MaxLength = 32767;
            this.com_req_division.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.com_req_division.Name = "com_req_division";
            this.com_req_division.OddRowStyle = style54;
            this.com_req_division.PartialRightColumn = false;
            this.com_req_division.PropBag = resources.GetString("com_req_division.PropBag");
            this.com_req_division.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.com_req_division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.com_req_division.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.com_req_division.SelectedStyle = style55;
            this.com_req_division.Size = new System.Drawing.Size(121, 22);
            this.com_req_division.Style = style56;
            this.com_req_division.TabIndex = 0;
            // 
            // pnl_Error
            // 
            this.pnl_Error.Location = new System.Drawing.Point(0, 0);
            this.pnl_Error.Name = "pnl_Error";
            this.pnl_Error.Size = new System.Drawing.Size(200, 100);
            this.pnl_Error.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(200, 100);
            this.pnl_Grid.TabIndex = 0;
            // 
            // txt_Err
            // 
            this.txt_Err.Location = new System.Drawing.Point(0, 0);
            this.txt_Err.Name = "txt_Err";
            this.txt_Err.Size = new System.Drawing.Size(100, 21);
            this.txt_Err.TabIndex = 0;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.flg_request1);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 176);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_Body.Size = new System.Drawing.Size(1016, 466);
            this.pnl_Body.TabIndex = 136;
            // 
            // flg_request1
            // 
            this.flg_request1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.flg_request1.AutoResize = false;
            this.flg_request1.BackColor = System.Drawing.SystemColors.Window;
            this.flg_request1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flg_request1.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.flg_request1.ContextMenu = this.contextMenu1;
            this.flg_request1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flg_request1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flg_request1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.flg_request1.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.flg_request1.Location = new System.Drawing.Point(4, 0);
            this.flg_request1.Name = "flg_request1";
            this.flg_request1.Rows.Fixed = 0;
            this.flg_request1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.flg_request1.Size = new System.Drawing.Size(1008, 466);
            this.flg_request1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flg_request1.Styles"));
            this.flg_request1.TabIndex = 319;
            this.flg_request1.DoubleClick += new System.EventHandler(this.flg_request1_DoubleClick);
            this.flg_request1.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flg_request1_AfterEdit);
            this.flg_request1.Click += new System.EventHandler(this.flg_request1_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmt_ADD_Item,
            this.cmt_Delete_Item,
            this.menuItem2,
            this.cmt_Value_Change,
            this.menuItem1,
            this.cmt_Season});
            // 
            // cmt_ADD_Item
            // 
            this.cmt_ADD_Item.Index = 0;
            this.cmt_ADD_Item.Text = "Insert Record";
            this.cmt_ADD_Item.Click += new System.EventHandler(this.cmt_ADD_Item_Click);
            // 
            // cmt_Delete_Item
            // 
            this.cmt_Delete_Item.Index = 1;
            this.cmt_Delete_Item.Text = "Delete Record";
            this.cmt_Delete_Item.Click += new System.EventHandler(this.cmt_Delete_Item_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // cmt_Value_Change
            // 
            this.cmt_Value_Change.Index = 3;
            this.cmt_Value_Change.Text = "Change Value";
            this.cmt_Value_Change.Click += new System.EventHandler(this.cmt_Value_Change_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.Text = "-";
            // 
            // cmt_Season
            // 
            this.cmt_Season.Index = 5;
            this.cmt_Season.Text = "Change Season";
            this.cmt_Season.Click += new System.EventHandler(this.cmt_Season_Click);
            // 
            // Form_Pur_request_master
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_Pur_request_master";
            this.Load += new System.EventHandler(this.Form_Pur_request_master_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_req_dept)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_req_division)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flg_request1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
                
		#region 사용자 정의 변수
		private COM.OraDB MyOraDB = new COM.OraDB();
		DataTable  _dt_list;
        private bool _createMode = false;
        private bool check = false;


        private int _RowFixed;
        private string tmp_lot_no  = "____________________";
        private string tmp_lot_seq = "__";
        private string tmp_srf_seq = "___";
        private string tmp_part_no = "_____";

		private string req_dept   = "";
		private string req_user   = "";
		private string req_div    = "";
		private string req_res    = "";
		private string _edit_type ="";

		#endregion

        #region Form Loading
        private void Form_Pur_request_master_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
                ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;

            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (cmb_Factory.SelectedIndex == -1) return;
            COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();
            Init_Form();
        }
        
        private void Init_Form()
		{
			this.Text               = "PCC_Request for Purchasing";
			this.lbl_MainTitle.Text = "PCC_Request for Purchasing";
			ClassLib.ComFunction.SetLangDic(this);            

            #region Dept 설정
            DataTable dt_ret = select_request_dept();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_dept, 0, 1, true, COM.ComVar.ComboList_Visible.Name);	
			
			if(ClassLib.ComVar.This_CDCPower_Level.Equals("P02") || ClassLib.ComVar.This_CDCPower_Level.Equals("P01"))
			{
				cmb_req_dept.Enabled = true;
				cmb_req_dept.SelectedIndex = 0;
			}
			else
			{
                try
				{
                    cmb_req_dept.Enabled = false;
                    cmb_req_dept.SelectedValue = ClassLib.ComVar.This_Dept;					
				}
				catch
				{
					cmb_req_dept.SelectedIndex = 0;
				}
			}
			#endregion  	
			
			dpk_req_from.Value = DateTime.Now.AddDays(-7);
			dpk_req_to.Value = DateTime.Now;

			//Status
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Request_Status_nomal);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_status, 1, 2, true, false);
			cmb_req_status.SelectedIndex = 0;

            #region Reason 설정
            dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_Request_Reason);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_reason, 1, 2, true, false);
			
			
			if(ClassLib.ComVar.This_CDCPower_Level.Equals("P02") || ClassLib.ComVar.This_CDCPower_Level.Equals("P01"))
			{
				cmb_req_reason.SelectedIndex = 0;//item "Order"	
			}
			else
			{
				cmb_req_reason.SelectedValue = 90;//item "Order"	
			}

			#endregion  

            #region User설정
           
           DataTable dt_list = Select_sxp_pur_user();

            cmb_req_user.Enabled = false;

            if (ClassLib.ComVar.This_CDCPower_Level.ToString() == "S00" || ClassLib.ComVar.This_CDCPower_Level.Substring(0, 1) == "P")
            {
                cmb_req_user.Enabled = true;
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_req_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_req_user.SelectedIndex = 0;

                if (ClassLib.ComVar.This_CDCPower_Level.ToString() == "P02")
                {
                    cmb_req_user.Enabled = false;

                    DataTable user_datatable = new DataTable("UserList");
                    DataRow newrow;

                    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                    newrow = user_datatable.NewRow();
                    newrow["Code"] = ClassLib.ComVar.This_User;
                    newrow["Name"] = ClassLib.ComVar.This_User;

                    user_datatable.Rows.Add(newrow);

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_req_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_req_user.SelectedValue = ClassLib.ComVar.This_User;
                }
            }
            #endregion 
            
            flg_request1.Set_Grid_CDC("SXP_REQ", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			flg_request1.Set_Action_Image(img_Action);
			_RowFixed = flg_request1.Rows.Count;
			flg_request1.ExtendLastCol = false;
            
			tbtn_Print.Enabled = false;

			btn_control();
            
		}
        private void btn_control()
        {
            if (cmb_req_status.SelectedIndex.Equals(0)) //status : "ALL"
            {
                tbtn_Save.Enabled = true;
                tbtn_Confirm.Enabled = false;
                contextMenu1.MenuItems[0].Enabled = true;
                flg_request1.AllowEditing = false;
            }
            else if (cmb_req_status.SelectedIndex.Equals(1)) //status : "Save"
            {
                if (cmb_req_no.SelectedIndex == 0) // Req No : "ALL"
                {
                    tbtn_Save.Enabled = true;
                    tbtn_Confirm.Enabled = false;
                    contextMenu1.MenuItems[0].Enabled = true;
                    flg_request1.AllowEditing = true;

                }
                else if (cmb_req_no.SelectedIndex > 0 || cmb_req_no.SelectedIndex == -1) // Req No : "생성할때" "특정 Req No선택"
                {
                    tbtn_Save.Enabled = true;
                    tbtn_Confirm.Enabled = true;
                    contextMenu1.MenuItems[0].Enabled = true;
                    flg_request1.AllowEditing = true;


                }
            }
            else if (cmb_req_status.SelectedIndex.Equals(2)) //status : "Sub Comfirm"
            {
                if (ClassLib.ComVar.This_CDCPower_Level.Equals("S00") || ClassLib.ComVar.This_CDCPower_Level.Equals("P00") || ClassLib.ComVar.This_CDCPower_Level.Equals("P01")) // 관리자
                {                   
                    tbtn_Save.Enabled = true;
                    tbtn_Confirm.Enabled = true;
                    contextMenu1.MenuItems[0].Enabled = false;
                    flg_request1.AllowEditing = true;
                }
                else
                {
                    tbtn_Save.Enabled = true;
                    tbtn_Confirm.Enabled = true;
                    contextMenu1.MenuItems[0].Enabled = false;
                    flg_request1.AllowEditing = true;
                }
            }
            else if (cmb_req_status.SelectedIndex.Equals(3)) // status : "Comfirm"
            {
                tbtn_Save.Enabled = false;
                tbtn_Confirm.Enabled = false;
                contextMenu1.MenuItems[0].Enabled = false;
                flg_request1.AllowEditing = false;
            }
        }

        private DataTable select_request_dept()
		{
			string Proc_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQUEST_DEPT";

			MyOraDB.ReDim_Parameter(2);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "arg_factory";
			MyOraDB.Parameter_Name[1] = "out_cursor";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
        private DataTable Select_sxp_pur_user()
        {
            string Proc_Name = "PKG_SXP_PUR_01_SELECT.SELECT_SXP_PURUSER";

            MyOraDB.ReDim_Parameter(1);
            MyOraDB.Process_Name = Proc_Name;
                        
            MyOraDB.Parameter_Name[0] = "out_cursor";
                        
            MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                        
            MyOraDB.Parameter_Values[0] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region Create Data
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            _createMode = true;
            cmb_req_status.SelectedIndex = 1;
            dpk_req_from.Value = DateTime.Now;
            dpk_req_to.Value = DateTime.Now;
            cmb_req_no.SelectedIndex = -1;

            CDC_Bom.Form_Bom_Selecter bomSelect = new FlexCDC.CDC_Bom.Form_Bom_Selecter(this, cmb_req_reason.SelectedValue.ToString());
            bomSelect.ShowDialog();
        }
        private void cmt_ADD_Item_Click(object sender, System.EventArgs e)
        {
            try
            {
                int sct_row = flg_request1.Rows.Count - 1;

                flg_request1.Add_Row(sct_row);

                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "I";
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY] = cmb_Factory.SelectedValue.ToString();
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO] = cmb_req_no.SelectedValue.ToString();
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_USER] = COM.ComVar.This_User;
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_DEPT] = cmb_req_dept.SelectedValue.ToString();
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxUPD_USER] = COM.ComVar.This_User;
                flg_request1[sct_row + 1, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_REASON] = cmb_req_reason.SelectedValue.ToString();

                //edit_code(sct_row+1 , "I");



                sct_row = sct_row + 1;



                #region 코드 팝업
                int vCount = 17;
                COM.ComVar.Parameter_PopUp = new string[vCount];

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY].ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = "";

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD].ToString();

                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME].ToString();





                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC].ToString();


                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD].ToString();
                COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD].ToString();


                #endregion

                //TBSXO_PUR_REQ

                BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master();
                codeMaster.ShowDialog();


                if (!flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString().Equals("I"))
                {

                    flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "U";
                }

                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1];

                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1];


                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1];

                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1];

                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1];
                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1];

                flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxTRANSPORT_TYPE] = "00";
            }
            catch
            {



            }

        }
        private void edit_code(int arg_sct_row, string arg_change_r_flg)
        {
            BaseInfo.Pop_Code_Editer codeEditer = new FlexCDC.BaseInfo.Pop_Code_Editer(this, "S", arg_sct_row, arg_change_r_flg);
            codeEditer.ShowDialog();
        }
        #endregion

        #region Search Data
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				txt_Err.Text = "";
				this.Cursor  = Cursors.WaitCursor;

				flg_request1.Rows.Count  = flg_request1.Rows.Fixed;
				flg_request1.ClearAll();

				string req_from = dpk_req_from.Value.ToString("yyyyMMdd");
				string req_to = dpk_req_to.Value.ToString("yyyyMMdd");

				if(cmb_req_no.SelectedIndex == -1) cmb_req_no.SelectedIndex = 0;

				DataTable dt_Search = Search_Request_list(cmb_Factory.SelectedValue.ToString(), req_dept, cmb_req_user.SelectedValue.ToString(), cmb_req_status.SelectedValue.ToString(), req_from, req_to, cmb_req_no.SelectedValue.ToString(), req_div, cmb_req_reason.SelectedValue.ToString());
				Display_Grid(dt_Search, flg_request1);
			}
			catch
			{
				this.Cursor  = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
            }
			finally
			{				
				this.Cursor  = Cursors.Default;
			}
		}
        private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
        {
            check = false;

            for (int i = 0; i < arg_list.Rows.Count; i++)
            {
                arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 0);

                int mat_cd     = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD].ToString().Trim().Length;
                int spec       = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD].ToString().Trim().Length;
                int color      = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD].ToString().Trim().Length;
                int category   = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxCATEGORY].ToString().Trim().Length;
                int season     = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxCATEGORY].ToString().Trim().Length;
                int style_name = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_NAME].ToString().Trim().Length;
                int nf_cd      = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxNF_CD].ToString().Trim().Length;
                int size       = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE].ToString().Trim().Length;
                int mat_div    = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxPUR_DIV].ToString().Trim().Length;
                int transport  = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxTRANSPORT_TYPE].ToString().Trim().Length;
                int reason     = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxREQ_REASON].ToString().Trim().Length;
                string qty     = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ].ToString(); ;
                int rta        = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD].ToString().Length;
                string status  = arg_list.Rows[i].ItemArray[(int)ClassLib.TBSXO_PUR_REQ.IxSTATUS].ToString();

                if (status == "Save")
                {
                    arg_fgrid.Rows[i].AllowEditing = true;
                }
                else
                {
                    arg_fgrid.Rows[i].AllowEditing = false;
                }
                if (mat_cd.Equals(0) || spec.Equals(0) || color.Equals(0) || category.Equals(0) || season.Equals(0) || style_name.Equals(0) ||
                   nf_cd.Equals(0) || size.Equals(0) || mat_div.Equals(0) || reason.Equals(0) || qty.Equals(0) || rta.Equals(0))
                {
                    arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = Color.Bisque;
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 12, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Red;

                    check = true;
                }

            }
        }

        private DataTable Search_Request_list(string arg_factory, string arg_req_dept, string arg_req_user, string arg_status, string arg_req_from, string arg_req_to, string arg_req_no, string arg_req_div, string arg_req_reason)
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(10);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_PUR";

            //02.ARGURMENT명	
            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_req_dept";
            MyOraDB.Parameter_Name[2] = "arg_req_user";
            MyOraDB.Parameter_Name[3] = "arg_status";
            MyOraDB.Parameter_Name[4] = "arg_req_from";
            MyOraDB.Parameter_Name[5] = "arg_req_to";
            MyOraDB.Parameter_Name[6] = "arg_req_no";
            MyOraDB.Parameter_Name[7] = "arg_req_div";
            MyOraDB.Parameter_Name[8] = "arg_req_reason";
            MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_dept;
            MyOraDB.Parameter_Values[2] = arg_req_user;
            MyOraDB.Parameter_Values[3] = arg_status;
            MyOraDB.Parameter_Values[4] = arg_req_from;
            MyOraDB.Parameter_Values[5] = arg_req_to;
            MyOraDB.Parameter_Values[6] = arg_req_no;
            MyOraDB.Parameter_Values[7] = arg_req_div;
            MyOraDB.Parameter_Values[8] = arg_req_reason;
            MyOraDB.Parameter_Values[9] = "";




            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Save Data
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                flg_request1.Select(flg_request1.Selection.r1, 0, flg_request1.Selection.r1, flg_request1.Cols.Count - 1, false);

                string req_no = null;

                if ((cmb_req_no.SelectedIndex == -1) || (cmb_req_no.SelectedIndex == 0))
                {

                    req_no = get_req_No(cmb_Factory.SelectedValue.ToString()).Rows[0].ItemArray[0].ToString();

                    for (int i = _RowFixed; i < flg_request1.Rows.Count; i++)
                    {

                        if (flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString() != "")
                        {
                            if (flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxETC_YMD].ToString().Trim().Length != 0
                                && flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxETC_YMD].ToString().Trim().Length != 8)
                            {
                                ClassLib.ComFunction.User_Message("Input Error : RTA", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                flg_request1.Rows[i].Selected = true;
                                return;
                            }
                        }

                        if (flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString() == "D")
                        {
                            string arg_factory = flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY].ToString();
                            string arg_req_no  = flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO].ToString();
                            string arg_req_seq = flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_SEQ].ToString();


                            delete_sxp_req(arg_factory, arg_req_no, arg_req_seq);

                            flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "";
                        }

                        flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO] = req_no;
                    }
                }
                else
                {
                    req_no = cmb_req_no.SelectedValue.ToString();
                }



                if (SAVE_SXP_REQ())
                {
                    Set_Request_No();
                    cmb_req_no.SelectedValue = req_no;
                    tbtn_Search_Click(null, null);
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void Set_Request_No()
        {
            try
            {
                string req_from = dpk_req_from.Value.ToString("yyyyMMdd");
                string req_to = dpk_req_to.Value.ToString("yyyyMMdd");

                DataTable dt_ret = Search_Request_No(cmb_Factory.SelectedValue.ToString(), req_dept, req_user, cmb_req_status.SelectedValue.ToString(), req_from, req_to);
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_no, 0, 0, true, false);
                cmb_req_no.SelectedIndex = 0;
            }
            catch
            {
            }
        }
        private DataTable get_req_No(string arg_factory)
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.GET_SXP_REQ_NO";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = "";




            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        private bool SAVE_SXP_REQ()
        {
            try
            {
                int vcnt = 38;
                MyOraDB.ReDim_Parameter(vcnt);
                MyOraDB.Process_Name = "PKG_SXP_REQ_01.SAVE_SXP_REQ_HEAD";

                MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
                MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
                MyOraDB.Parameter_Name[2]  = "ARG_REQ_NO";
                MyOraDB.Parameter_Name[3]  = "ARG_REQ_SEQ";
                MyOraDB.Parameter_Name[4]  = "ARG_REQ_USER";
                MyOraDB.Parameter_Name[5]  = "ARG_REQ_DEPT";
                MyOraDB.Parameter_Name[6]  = "ARG_RTA_YMD";
                MyOraDB.Parameter_Name[7]  = "ARG_ETC_YMD";
                MyOraDB.Parameter_Name[8]  = "ARG_PUR_DIV";
                MyOraDB.Parameter_Name[9]  = "ARG_LOT_NO";
                MyOraDB.Parameter_Name[10] = "ARG_LOT_SEQ";
                MyOraDB.Parameter_Name[11] = "ARG_SRF_SEQ";
                MyOraDB.Parameter_Name[12] = "ARG_PART_NO";
                MyOraDB.Parameter_Name[13] = "ARG_MAT_CD";
                MyOraDB.Parameter_Name[14] = "ARG_PCC_SPEC_CD";
                MyOraDB.Parameter_Name[15] = "ARG_COLOR_CD";
                MyOraDB.Parameter_Name[16] = "ARG_PCC_UNIT_CD";
                MyOraDB.Parameter_Name[17] = "ARG_MCS_CD";
                MyOraDB.Parameter_Name[18] = "ARG_SIZE_CD";
                MyOraDB.Parameter_Name[19] = "ARG_SORT_NO";
                MyOraDB.Parameter_Name[20] = "ARG_PART_SEQ";
                MyOraDB.Parameter_Name[21] = "ARG_COMMON_YN";
                MyOraDB.Parameter_Name[22] = "ARG_CBD_CURRENCY";
                MyOraDB.Parameter_Name[23] = "ARG_CBD_PRICE";
                MyOraDB.Parameter_Name[24] = "ARG_PRICE_YN";
                MyOraDB.Parameter_Name[25] = "ARG_MAT_COMMENT";
                MyOraDB.Parameter_Name[26] = "ARG_COLOR_COMMENT";
                MyOraDB.Parameter_Name[27] = "ARG_REQ_REASON";
                MyOraDB.Parameter_Name[28] = "ARG_USE_DEPT";
                MyOraDB.Parameter_Name[29] = "ARG_QTY_REQ";
                MyOraDB.Parameter_Name[30] = "ARG_VALUE_REQ";
                MyOraDB.Parameter_Name[31] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[32] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[33] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[34] = "ARG_STYLE_NAME";
                MyOraDB.Parameter_Name[35] = "ARG_NF_CD";
                MyOraDB.Parameter_Name[36] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[37] = "ARG_UPD_USER";

                for (int i = 0; i < vcnt; i++)
                {
                    MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
                }


                int vRow = 0;
                for (int i = flg_request1.Rows.Fixed; i < flg_request1.Rows.Count; i++)
                {
                    string _div = flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString().Trim();
                    if (!_div.Equals(""))
                    {
                        vRow++;                        
                    }
                }              

                
                vcnt = vcnt * vRow;
                MyOraDB.Parameter_Values = new string[vcnt];


                vcnt = 0;
                int sort = 0;
                for (int row = flg_request1.Rows.Fixed; row < flg_request1.Rows.Count; row++)
                {
                    string _div = flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString().Trim();

                    if (_div.Equals(""))
                        continue;

                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString().Trim();       //"arg_division"                    
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY].ToString().Trim();        //"arg_factory";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_NO].ToString().Trim();         //"arg_req_no";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_SEQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_SEQ].ToString().Trim();        //"arg_req_seq";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_USER] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_USER].ToString().Trim();       //"arg_req_user";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_DEPT] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_DEPT].ToString().Trim();       //"arg_req_dept";                    
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD].ToString().Trim();        //"arg_rta_ymd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxETC_YMD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxETC_YMD].ToString().Trim();        //"arg_etc_ymd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPUR_DIV] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPUR_DIV].ToString().Trim();        //"arg_pur_div";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_NO] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_NO].ToString().Trim();         //"arg_lot_no";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_SEQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxLOT_SEQ].ToString().Trim();        //"arg_lot_seq";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSRF_SEQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSRF_SEQ].ToString().Trim();        //"arg_srf_seq";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_NO] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_NO].ToString().Trim();        //"arg_part_no";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD].ToString().Trim();         //"arg_mat_cd";                    
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD].ToString().Trim();    //"arg_pcc_spec_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD].ToString().Trim();       //"arg_color_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD].ToString().Trim();    //"arg_pcc_unit_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD].ToString().Trim();         //"arg_mcs_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE].ToString().Trim();        //"arg_cs_size";
                    MyOraDB.Parameter_Values[vcnt++] = Convert.ToString(sort++); //sort no
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ].ToString().Trim();       //"arg_paet_seq";

                    string _common = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOMMON_YN] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOMMON_YN].ToString().ToUpper().Trim();      //"arg_common_yn";
                    if (_common.Equals("TRUE"))
                        _common = "Y";
                    else
                        _common = "N";

                    MyOraDB.Parameter_Values[vcnt++] = _common;
                    MyOraDB.Parameter_Values[vcnt++] = "";//cbd_currency
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCBD_PRICE] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCBD_PRICE].ToString().Trim();      //"arg_cbd_price";

                    string _price = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPRICE_YN] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxPRICE_YN].ToString().ToUpper().Trim();       //"arg_price_yn";
                    if (_price.Equals("TRUE"))
                        _price = "Y";
                    else
                        _price = "N";
                    MyOraDB.Parameter_Values[vcnt++] = _price;
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT].ToString().Trim();    //"arg_mat_comment";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT].ToString().Trim();  //"arg_color_comment";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_REASON] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREQ_REASON].ToString().Trim();     //"arg_req_reason";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT].ToString().Trim();     //"arg_use_dept";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ].ToString().Trim();        //"arg_qty_req";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ].ToString().Trim();      //"arg_value_req";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCATEGORY] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxCATEGORY].ToString().Trim();       //"arg_category";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSEASON_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSEASON_CD].ToString().Trim();      //"arg_season_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_CD].ToString().Trim();     //"arg_style_name";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_NAME] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_NAME].ToString().Trim();     //"arg_style_name";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxNF_CD] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxNF_CD].ToString().Trim();          //"arg_nf_cd";
                    MyOraDB.Parameter_Values[vcnt++] = (flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREMARKS] == null) ? "" : flg_request1[row, (int)ClassLib.TBSXO_PUR_REQ.IxREMARKS].ToString().Trim();        //"arg_remarks";
                    MyOraDB.Parameter_Values[vcnt++] = COM.ComVar.This_User;
                }

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void delete_sxp_req(string arg_factory, string arg_req_no, string arg_req_seq)
        {

            string Proc_Name = "PKG_SXP_REQ_01.DELETE_SXP_REQ_HEAD";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_req_no";
            MyOraDB.Parameter_Name[2] = "arg_req_seq";
            MyOraDB.Parameter_Name[3] = "arg_upd_user";


            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;


            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_no;
            MyOraDB.Parameter_Values[2] = arg_req_seq;
            MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private DataTable Search_Request_No(string arg_factory, string arg_req_dept, string arg_req_user, string arg_status, string arg_from, string arg_to)
        {

            DataSet ds_Search;

            MyOraDB.ReDim_Parameter(7);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXP_REQ_01_SELECT.SELECT_SXP_REQ_NO";

            //02.ARGURMENT명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_REQ_DEPT";
            MyOraDB.Parameter_Name[2] = "ARG_REQ_USER";
            MyOraDB.Parameter_Name[3] = "ARG_STATUS";
            MyOraDB.Parameter_Name[4] = "ARG_FROM";
            MyOraDB.Parameter_Name[5] = "ARG_TO";
            MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

            //03. DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            //04. DATA 정의
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_req_dept;
            MyOraDB.Parameter_Values[2] = arg_req_user;
            MyOraDB.Parameter_Values[3] = arg_status;
            MyOraDB.Parameter_Values[4] = arg_from;
            MyOraDB.Parameter_Values[5] = arg_to;
            MyOraDB.Parameter_Values[6] = "";




            MyOraDB.Add_Select_Parameter(true);
            ds_Search = MyOraDB.Exe_Select_Procedure();

            return ds_Search.Tables[MyOraDB.Process_Name];

        }
        #endregion

        #region Delete Data
        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if ((cmb_req_status.SelectedValue.ToString() == ClassLib.ComVar.ConsCDC_N) ||      //Save
                    (cmb_req_status.SelectedValue.ToString() == ClassLib.ComVar.ConsCDC_Y))     //Subconfirm
                {

                    for (int i = flg_request1.Rows.Fixed; i < flg_request1.Rows.Count; i++)
                    {

                        flg_request1[i, 0] = "D";


                    }

                    if (MyOraDB.Save_FlexGird("PKG_SXP_REQ_01.SAVE_SXP_REQ", flg_request1))
                    {

                        Set_Request_No();
                        cmb_req_no.SelectedIndex = 0;
                        tbtn_Search_Click(null, null);
                    }


                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Confirm Data
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                tbtn_Save_Click(null, null);

                if (!check)
                {
                    string comf_req_no = cmb_req_no.SelectedValue.ToString();

                    if (cmb_req_status.SelectedIndex.Equals(1))
                    {
                        //status : "Save" => "Sub Comfirm"
                        sub_conform();
                        cmb_req_status.SelectedIndex = 2;
                    }
                    else if (cmb_req_status.SelectedIndex.Equals(2))
                    {
                        //status : "Sub Comfirm" => "Comfirm"
                        conform();
                        cmb_req_status.SelectedIndex = 3;
                    }

                    cmb_req_no.SelectedValue = comf_req_no;

                    tbtn_Search_Click(null, null);
                }
                else
                {
                    ClassLib.ComFunction.User_Message("Input Error : Material/Color/Purchase Quantity/Trnasport Type/RTA/Size", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void sub_conform()
        {

            string Proc_Name = "PKG_SXP_REQ_01.SUB_CONF_SXP_REQ_HEAD";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_req_no";
            MyOraDB.Parameter_Name[2] = "arg_upd_user";


            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_req_no.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        private void conform()
        {

            string Proc_Name = "PKG_SXP_REQ_01.INSERT_SXM_MRP_REQ_MAST";

            MyOraDB.ReDim_Parameter(4);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";            
            MyOraDB.Parameter_Name[1] = "arg_req_ymd_f";
            MyOraDB.Parameter_Name[2] = "arg_req_ymd_t";
            MyOraDB.Parameter_Name[3] = "arg_upd_user";


            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;            
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();            
            MyOraDB.Parameter_Values[1] = dpk_req_from.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[2] = dpk_req_to.Value.ToString("yyyyMMdd");
            MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();
        }
        #endregion
                     
		#region Control Event
		private void dpk_req_from_CloseUp(object sender, System.EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Set_Request_No();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
		private void cmb_req_status_SelectedValueChanged(object sender, System.EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_req_status.SelectedIndex == -1)
                {
                    return;
                }

                btn_control();

                Set_Request_No();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}					
		private void cmb_req_dept_SelectedValueChanged(object sender, System.EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (cmb_req_dept.SelectedIndex.Equals(-1)) return;

                //			for(int i=_RowFixed; i<flg_request1.Rows.Count; i++)
                //			{
                //				flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "U";
                //				flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT] = cmb_req_dept.SelectedValue.ToString();
                //				flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxUSE_DEPT_DESC] = cmb_req_dept.GetItemText(cmb_req_dept.SelectedIndex, 1);
                //			}


                DataTable dt_ret = Select_req_dept_user();

                #region User설정
                if (ClassLib.ComVar.This_CDCPower_Level.Equals("P02"))
                {
                    cmb_req_user.Enabled = true;
                    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_req_user, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                    cmb_req_user.SelectedIndex = 0;
                }
                else
                {
                    cmb_req_user.Enabled = false;

                    DataTable user_datatable = new DataTable("UserList");
                    DataRow newrow;

                    user_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
                    user_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

                    newrow = user_datatable.NewRow();
                    newrow["Code"] = ClassLib.ComVar.This_User;
                    newrow["Name"] = ClassLib.ComVar.This_User;

                    user_datatable.Rows.Add(newrow);

                    ClassLib.ComCtl.Set_ComboList(user_datatable, cmb_req_user, 0, 0, false, COM.ComVar.ComboList_Visible.Name);
                    cmb_req_user.SelectedValue = ClassLib.ComVar.This_User;

                }

                #endregion
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}
		private void cmb_req_no_SelectedValueChanged(object sender, System.EventArgs e)
		{
		  if (cmb_req_no.SelectedIndex  == -1) return;

		   btn_control();
		}

        private DataTable Select_req_dept_user()
        {
            string Proc_Name = "PKG_SXP_REQ_01_SELECT.SELECT_REQUEST_DEPT_USER";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "ARG_DEPT_CD";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = cmb_req_dept.SelectedValue.ToString();
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
		#endregion 

		#region Context Menu	
		private void cmt_Delete_Item_Click(object sender, System.EventArgs e)
		{
			for (int i = flg_request1.Selection.r1; i<=flg_request1.Selection.r2; i++)
			{  
				flg_request1[i,0]  = "D";				
			}		
		}
		private void cmt_Value_Change_Click(object sender, System.EventArgs e)
		{
			try
			{
				int  sct_col = flg_request1.Selection.c1;
		
				if((sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxSTYLE_NAME) || (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxCS_SIZE)||
				   (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ) ||(sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ)||
				   (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD) || (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxREMARKS))
				{

					FlexCDC.BaseInfo.Pop_Common_Text vEditor = new FlexCDC.BaseInfo.Pop_Common_Text( " ");
					vEditor.ShowDialog();			

					for (int i = flg_request1.Rows.Fixed; i< flg_request1.Rows.Count; i++)
					{
                        if (flg_request1.Rows[i].Selected)
                        {

                            flg_request1[i, sct_col] = COM.ComVar.This_Return;
                            flg_request1.Update_Row(i);
                        }
					}

				}
			}
			catch
			{

			}


		}		
		private void cmt_Season_Click(object sender, System.EventArgs e)
		{			
			try
			{		   
				int  sct_col  = flg_request1.Selection.c1;

				COM.ComVar.Parameter_PopUp		= new string[2]; 
				COM.ComVar.Parameter_PopUp[0] = ClassLib.ComVar.ConsCDC_Season;
				COM.ComVar.Parameter_PopUp[1] = flg_request1[flg_request1.Selection.r1, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY].ToString();

				FlexCDC.BaseInfo.Pop_Common_Combo vEditor = new FlexCDC.BaseInfo.Pop_Common_Combo();
				vEditor.ShowDialog();



				for (int i = flg_request1.Rows.Fixed; i< flg_request1.Rows.Count; i++)
				{   //0 - factory, 1- code,, 2-name

                    if (flg_request1.Rows[i].Selected)
                    {
                        flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY] = COM.ComVar.Parameter_PopUp[0];
                        flg_request1[i, sct_col - 1] = COM.ComVar.Parameter_PopUp[1];
                        flg_request1[i, sct_col] = COM.ComVar.Parameter_PopUp[2];
                        flg_request1.Update_Row(i);
                    }

				}
			}
			catch
			{

			}
	    }        
		#endregion  

		#region Grid Event
		private void flg_request1_Click(object sender, System.EventArgs e)
		{
            try
            {
                int sct_row = flg_request1.Selection.r1;
                int sct_col = flg_request1.Selection.c1;

                if (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxSEASON_NAME)
                {
                    cmt_Season.Enabled = true;
                    cmt_Value_Change.Enabled = false;
                }
                else
                {
                    cmt_Season.Enabled = false;
                    cmt_Value_Change.Enabled = true;
                }



            }
            catch
            {
 
            }
		}
		private void flg_request1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

            try
            {
                this.Cursor = Cursors.WaitCursor;

                int sct_row1 = flg_request1.Selection.r1;
                int sct_row2 = flg_request1.Selection.r2;
                int sct_col = flg_request1.Selection.c1;

                if (flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD].ToString().Trim() != "")
                {
                    string RtaYmd = flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD].ToString();
                    int year = 0;
                    int month = 0;
                    int day = 0;
                    try
                    {
                        year = int.Parse(RtaYmd.Trim().Substring(0, 4));
                        month = int.Parse(RtaYmd.Trim().Substring(4, 2));
                        day = int.Parse(RtaYmd.Trim().Substring(6, 2));
                    }
                    catch
                    {
                        ClassLib.ComFunction.User_Message("Input Error : RTA", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD] = "";
                        return;
                    }
                    if (month == 0 || month > 12)
                    {
                        ClassLib.ComFunction.User_Message("Input Error : RTA", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD] = "";
                        return;
                    }
                    if (day == 0 || day > int.Parse(DateTime.DaysInMonth(year, month).ToString()))
                    {
                        ClassLib.ComFunction.User_Message("Input Error : RTA", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxRTA_YMD] = "";
                        return;
                    }
                }


                for (int i = flg_request1.Rows.Fixed; i < flg_request1.Rows.Count; i++)
                {

                    if (flg_request1.Rows[i].Selected)
                    {

                        if (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ)
                        {
                            double Y_Value = double.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ].ToString());

                            double Y_PRS = double.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ].ToString());
                            string VALUE_REQ = Math.Ceiling(Y_Value * Y_PRS).ToString();
                            flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ] = VALUE_REQ;
                        }
                        else if (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ)
                        {
                            double Y_Value = double.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ].ToString());
                            double Y_QTY = double.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ].ToString());
                            string VALUE_REQ = "0";
                            try
                            {
                                VALUE_REQ = Math.Ceiling(Y_QTY / Y_Value).ToString();
                                flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ] = VALUE_REQ;
                            }
                            catch
                            {
                                ClassLib.ComFunction.User_Message("Input Error : Yeild Value", "Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                        else if (sct_col == (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ)
                        {
                            double Y_Value = double.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ].ToString());

                            double Y_PRS = int.Parse(flg_request1[sct_row1, (int)ClassLib.TBSXO_PUR_REQ.IxQTY_REQ].ToString());
                            string VALUE_REQ = Math.Ceiling(Y_Value * Y_PRS).ToString();
                            flg_request1[i, (int)ClassLib.TBSXO_PUR_REQ.IxVALUE_REQ] = VALUE_REQ;
                        }


                        flg_request1[i, sct_col] = flg_request1[sct_row1, sct_col];
                        flg_request1.Update_Row(i);


                    }

                }                
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
		}
		private void flg_request1_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = flg_request1.Selection.r1;
			int sct_col = flg_request1.Selection.c1;		

			_edit_type = null;

			if(sct_col >= (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ && sct_col <= (int)ClassLib.TBSXO_PUR_REQ.IxPART_COMMENT)
			{
				
				_edit_type = "P";
			}
			else if(sct_col >= (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD && sct_col <= (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT)
			{
				
				_edit_type = "M";
			}
			else if(sct_col >= (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD && sct_col <= (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT)
			{
				
				_edit_type = "C";
			}
			else if(sct_col.Equals((int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD))
			{
				
				_edit_type = "MC";
			}
			else if(sct_col >= (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD && sct_col <= (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC)
			{
				
				_edit_type = "U";
			}


			if(_edit_type == null) return;



			#region 공통 코드 팝업
			int vCount = 17;
			COM.ComVar.Parameter_PopUp = new string[vCount];

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxFACTORY].ToString();

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = "";

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD].ToString();

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME].ToString();
					
					
					


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT].ToString();


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC].ToString();


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1] = flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD].ToString();

			#endregion

			BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(_edit_type);
			codeMaster.ShowDialog();


			#region 공통 팝업 다운
			if(!flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].ToString().Equals("I"))
			{

				flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "U";
			}

			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_SEQ] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_TYPE] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPART_DESC]= COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC -1];
					
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMAT_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1];
					
					
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxCOLOR_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT -1];
					
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1];
					
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxMCS_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD -1];
			flg_request1[sct_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_UNIT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD -1];

			#endregion 



		}
		#endregion

	}    
}

