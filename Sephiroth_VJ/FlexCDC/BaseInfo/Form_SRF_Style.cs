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
	public class Form_SRF_Style : COM.CDCWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정의 

		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_type;
		private System.Windows.Forms.Label btn_open_file;
		private System.Windows.Forms.Label lbl_filepath;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.ComponentModel.IContainer components = null;
		public C1.Win.C1List.C1Combo cmb_Type;
		private System.Windows.Forms.TextBox txt_Path;
		private C1.Win.C1List.C1Combo cmb_Factory;		
		public System.Windows.Forms.PictureBox picb_TM;
		public C1.Win.C1List.C1Combo cmb_LoadDate;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_Grid;
		private System.Windows.Forms.Panel pnl_Err;
		public COM.FSP fgrid_Style;
		private System.Windows.Forms.TextBox txt_Err;
		private System.Windows.Forms.Label lbl_LoadDate;
	
		
		public Form_SRF_Style()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SRF_Style));
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
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_LoadDate = new C1.Win.C1List.C1Combo();
            this.lbl_LoadDate = new System.Windows.Forms.Label();
            this.btn_open_file = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.lbl_filepath = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.cmb_Type = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.pnl_Err = new System.Windows.Forms.Panel();
            this.txt_Err = new System.Windows.Forms.TextBox();
            this.pnl_Grid = new System.Windows.Forms.Panel();
            this.fgrid_Style = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LoadDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            this.pnl_Body.SuspendLayout();
            this.pnl_Err.SuspendLayout();
            this.pnl_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
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
            this.c1CommandLink1.ToolTipText = "Clear";
            // 
            // tbtn_New
            // 
            this.tbtn_New.Text = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ToolTipText = "Search";
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Text = "";
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 651);
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Text = "";
            this.tbtn_Color.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Color_Click);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            this.img_MiniButton.Images.SetKeyName(2, "");
            this.img_MiniButton.Images.SetKeyName(3, "");
            this.img_MiniButton.Images.SetKeyName(4, "");
            this.img_MiniButton.Images.SetKeyName(5, "");
            this.img_MiniButton.Images.SetKeyName(6, "");
            this.img_MiniButton.Images.SetKeyName(7, "");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_LoadDate);
            this.pnl_Top.Controls.Add(this.lbl_LoadDate);
            this.pnl_Top.Controls.Add(this.btn_open_file);
            this.pnl_Top.Controls.Add(this.txt_Path);
            this.pnl_Top.Controls.Add(this.lbl_filepath);
            this.pnl_Top.Controls.Add(this.lbl_type);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.cmb_Type);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 56);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
            this.pnl_Top.TabIndex = 134;
            // 
            // cmb_LoadDate
            // 
            this.cmb_LoadDate.AddItemCols = 0;
            this.cmb_LoadDate.AddItemSeparator = ';';
            this.cmb_LoadDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_LoadDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LoadDate.Caption = "";
            this.cmb_LoadDate.CaptionHeight = 17;
            this.cmb_LoadDate.CaptionStyle = style1;
            this.cmb_LoadDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LoadDate.ColumnCaptionHeight = 18;
            this.cmb_LoadDate.ColumnFooterHeight = 18;
            this.cmb_LoadDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LoadDate.ContentHeight = 16;
            this.cmb_LoadDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LoadDate.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LoadDate.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LoadDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LoadDate.EditorHeight = 16;
            this.cmb_LoadDate.EvenRowStyle = style2;
            this.cmb_LoadDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LoadDate.FooterStyle = style3;
            this.cmb_LoadDate.GapHeight = 2;
            this.cmb_LoadDate.HeadingStyle = style4;
            this.cmb_LoadDate.HighLightRowStyle = style5;
            this.cmb_LoadDate.ItemHeight = 15;
            this.cmb_LoadDate.Location = new System.Drawing.Point(789, 36);
            this.cmb_LoadDate.MatchCol = C1.Win.C1List.MatchColEnum.CurrentMousePos;
            this.cmb_LoadDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_LoadDate.MaxDropDownItems = ((short)(5));
            this.cmb_LoadDate.MaxLength = 32767;
            this.cmb_LoadDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LoadDate.Name = "cmb_LoadDate";
            this.cmb_LoadDate.OddRowStyle = style6;
            this.cmb_LoadDate.PartialRightColumn = false;
            this.cmb_LoadDate.PropBag = resources.GetString("cmb_LoadDate.PropBag");
            this.cmb_LoadDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LoadDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LoadDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LoadDate.SelectedStyle = style7;
            this.cmb_LoadDate.Size = new System.Drawing.Size(200, 20);
            this.cmb_LoadDate.Style = style8;
            this.cmb_LoadDate.TabIndex = 314;
            // 
            // lbl_LoadDate
            // 
            this.lbl_LoadDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadDate.ImageIndex = 0;
            this.lbl_LoadDate.ImageList = this.img_Label;
            this.lbl_LoadDate.Location = new System.Drawing.Point(688, 36);
            this.lbl_LoadDate.Name = "lbl_LoadDate";
            this.lbl_LoadDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_LoadDate.TabIndex = 313;
            this.lbl_LoadDate.Text = "Load Date";
            this.lbl_LoadDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_open_file
            // 
            this.btn_open_file.BackColor = System.Drawing.SystemColors.Window;
            this.btn_open_file.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_file.ImageIndex = 0;
            this.btn_open_file.ImageList = this.img_MiniButton;
            this.btn_open_file.Location = new System.Drawing.Point(296, 58);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(21, 21);
            this.btn_open_file.TabIndex = 308;
            this.btn_open_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Path.ForeColor = System.Drawing.Color.Black;
            this.txt_Path.Location = new System.Drawing.Point(117, 59);
            this.txt_Path.MaxLength = 100;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Path.Size = new System.Drawing.Size(178, 21);
            this.txt_Path.TabIndex = 307;
            this.txt_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_filepath
            // 
            this.lbl_filepath.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filepath.ImageIndex = 0;
            this.lbl_filepath.ImageList = this.img_Label;
            this.lbl_filepath.Location = new System.Drawing.Point(16, 59);
            this.lbl_filepath.Name = "lbl_filepath";
            this.lbl_filepath.Size = new System.Drawing.Size(100, 21);
            this.lbl_filepath.TabIndex = 303;
            this.lbl_filepath.Text = "Path";
            this.lbl_filepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_type
            // 
            this.lbl_type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ImageIndex = 0;
            this.lbl_type.ImageList = this.img_Label;
            this.lbl_type.Location = new System.Drawing.Point(352, 36);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(100, 21);
            this.lbl_type.TabIndex = 309;
            this.lbl_type.Text = "Type";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Type
            // 
            this.cmb_Type.AddItemCols = 0;
            this.cmb_Type.AddItemSeparator = ';';
            this.cmb_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Type.Caption = "";
            this.cmb_Type.CaptionHeight = 17;
            this.cmb_Type.CaptionStyle = style9;
            this.cmb_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Type.ColumnCaptionHeight = 18;
            this.cmb_Type.ColumnFooterHeight = 18;
            this.cmb_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Type.ContentHeight = 16;
            this.cmb_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Type.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Type.EditorHeight = 16;
            this.cmb_Type.EvenRowStyle = style10;
            this.cmb_Type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FooterStyle = style11;
            this.cmb_Type.GapHeight = 2;
            this.cmb_Type.HeadingStyle = style12;
            this.cmb_Type.HighLightRowStyle = style13;
            this.cmb_Type.ItemHeight = 15;
            this.cmb_Type.Location = new System.Drawing.Point(453, 36);
            this.cmb_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Type.MaxLength = 32767;
            this.cmb_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.OddRowStyle = style14;
            this.cmb_Type.PartialRightColumn = false;
            this.cmb_Type.PropBag = resources.GetString("cmb_Type.PropBag");
            this.cmb_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Type.SelectedStyle = style15;
            this.cmb_Type.Size = new System.Drawing.Size(200, 20);
            this.cmb_Type.Style = style16;
            this.cmb_Type.TabIndex = 310;
            this.cmb_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Type_SelectedValueChanged);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.White;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 272;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
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
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
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
            this.lbl_title.Text = "      Load Information";
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
            this.picb_MR.Size = new System.Drawing.Size(24, 45);
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
            this.pictureBox4.Location = new System.Drawing.Point(984, 73);
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
            this.pictureBox5.Location = new System.Drawing.Point(144, 72);
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
            this.pictureBox6.Location = new System.Drawing.Point(0, 73);
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
            this.pictureBox7.Size = new System.Drawing.Size(168, 55);
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
            this.pictureBox8.Size = new System.Drawing.Size(1000, 48);
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
            this.pictureBox9.Size = new System.Drawing.Size(1000, 48);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.pnl_Err);
            this.pnl_Body.Controls.Add(this.pnl_Grid);
            this.pnl_Body.Location = new System.Drawing.Point(0, 152);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 499);
            this.pnl_Body.TabIndex = 135;
            // 
            // pnl_Err
            // 
            this.pnl_Err.Controls.Add(this.txt_Err);
            this.pnl_Err.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Err.Location = new System.Drawing.Point(512, 0);
            this.pnl_Err.Name = "pnl_Err";
            this.pnl_Err.Size = new System.Drawing.Size(504, 499);
            this.pnl_Err.TabIndex = 1;
            // 
            // txt_Err
            // 
            this.txt_Err.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Err.Enabled = false;
            this.txt_Err.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Err.Location = new System.Drawing.Point(0, 0);
            this.txt_Err.Multiline = true;
            this.txt_Err.Name = "txt_Err";
            this.txt_Err.Size = new System.Drawing.Size(504, 499);
            this.txt_Err.TabIndex = 0;
            // 
            // pnl_Grid
            // 
            this.pnl_Grid.Controls.Add(this.fgrid_Style);
            this.pnl_Grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_Grid.Name = "pnl_Grid";
            this.pnl_Grid.Size = new System.Drawing.Size(512, 499);
            this.pnl_Grid.TabIndex = 0;
            // 
            // fgrid_Style
            // 
            this.fgrid_Style.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Style.AutoResize = false;
            this.fgrid_Style.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Style.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Style.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Style.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Style.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Style.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Style.Name = "fgrid_Style";
            this.fgrid_Style.Rows.Fixed = 0;
            this.fgrid_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Style.Size = new System.Drawing.Size(512, 499);
            this.fgrid_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Style.Styles"));
            this.fgrid_Style.TabIndex = 319;
            // 
            // Form_SRF_Style
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 673);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_Body);
            this.Name = "Form_SRF_Style";
            this.Load += new System.EventHandler(this.Form_SRF_Style_Load);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LoadDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
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
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Err.ResumeLayout(false);
            this.pnl_Err.PerformLayout();
            this.pnl_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		DataTable  _dt_list;
		private Pop_BS_Shipping_List_Wait _pop = null;
		
		#endregion

		#region 공통메서드 

		private void Init_Form()
		{

			
			try
			{

				this.Text = "PCC_Nike Master Upload";
				this.lbl_MainTitle.Text = "PCC_Nike Master Upload";
				this.lbl_title.Text = "      Master Information";

				ClassLib.ComFunction.SetLangDic(this);

				#region Button Setting
				tbtn_Append.Enabled = false;
				tbtn_Insert.Enabled = false;
				tbtn_Print.Enabled  = false;
				tbtn_Delete.Enabled = false;
				tbtn_Save.Enabled   = false;
				tbtn_Color.Enabled  = false;
				#endregion			

				#region TextBox Setting
				txt_Err.ForeColor = Color.Black;
				txt_Err.BackColor = Color.White;			
				#endregion
			
				#region ComboBox Setting
				//Type Setting
				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, COM.ComVar.CxCDC_LoadingType);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Type, 1, 2, false, 0, 200);
				cmb_Type.SelectedIndex = 1;

						
				//dt_ret.Dispose();
				#endregion		

                this.WindowState = FormWindowState.Maximized;
	
			}
			catch
			{
				

			}

				

		}		
	
		private void Display_Excel_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{

			switch(cmb_Type.SelectedValue.ToString())
			{

				case COM.ComVar.ConsCDC_Loading_S :

					for(int i=0; i<arg_list.Rows.Count; i++)
					{                   
						arg_fgrid.Rows.Add();

						int vSrfNO =0 , vBomId=1 , vBomRevel  =2, vStyleCd =3,  vXdmDimCd =4, vStatus=5;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxFACTORY   ]  = ClassLib.ComVar.This_Factory;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxLOAD_YMD  ]  = DateTime.Now.Date.ToString().Replace("-","").Substring(0,8);			
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO    ]  = arg_list.Rows[i].ItemArray[ vSrfNO ].ToString().Replace("-","");
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID    ]  = arg_list.Rows[i].ItemArray[ vBomId ].ToString();
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxBOM_REV   ]  = (arg_list.Rows[i].ItemArray[ vBomRevel ].ToString() == "") 
																											? "0" : arg_list.Rows[i].ItemArray[ vBomRevel  ].ToString();				
						string  vStyle_cd = Convert.ToString(arg_list.Rows[i].ItemArray[vStyleCd ]);
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD  ]  = vStyle_cd.Replace("-","");
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxXDM_DIM_CD]  = ( arg_list.Rows[i].ItemArray[ vXdmDimCd ].ToString() == "")  
																											? "00": arg_list.Rows[i].ItemArray[ vXdmDimCd ].ToString();						
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxSTATUS    ]  = ( arg_list.Rows[i].ItemArray[ vStatus ].ToString() == "") 
																											? "N" : arg_list.Rows[i].ItemArray[ vStatus ].ToString();				
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxUPD_USER  ]  = ClassLib.ComVar.This_User;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxUPD_YMD   ]  = DateTime.Now.Date.ToString().Replace("-","").Substring(0,8);
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_STYLE.IxCHECK     ]  = "";	
					}	

					break;



				case COM.ComVar.ConsCDC_Loading_C :

					for(int i=0; i<arg_list.Rows.Count; i++)
					{ 	                 
						arg_fgrid.Rows.Add();						
						
						int vColorCd =0 , vColorDesc=1 , vColorStatus  =2;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxFACTORY   ]  = ClassLib.ComVar.This_Factory;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxLOAD_YMD  ]  = DateTime.Now.Date.ToString().Replace("-","").Substring(0,8);			
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD  ]  = arg_list.Rows[i].ItemArray[ vColorCd ].ToString();						
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_DESC]  = arg_list.Rows[i].ItemArray[ vColorDesc ].ToString();
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxSTATUS    ]  = arg_list.Rows[i].ItemArray[ vColorStatus ].ToString();																										  				
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxUPD_USER  ]  = ClassLib.ComVar.This_User;
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxUPD_YMD   ]  = DateTime.Now.Date.ToString().Replace("-","").Substring(0,8);
						arg_fgrid[i+arg_fgrid.Rows.Fixed, (int)ClassLib.TBSXB_SRF_COLOR.IxCHECK     ]  = "";	
					}	

					break;




				default :					
					break;

			}
		}	

		private void Display_Grid()
		{

			txt_Err.Clear();
				
			fgrid_Style.Rows.Count  = fgrid_Style.Rows.Fixed;
			//fgrid_Style.ClearAll();

			DataTable dt_Search = null;

			switch(cmb_Type.SelectedValue.ToString())
			{

				case COM.ComVar.ConsCDC_Loading_S :
					
					dt_Search = Search_Style_Load(cmb_Factory.SelectedValue.ToString(), cmb_LoadDate.SelectedValue.ToString());					
					break;

			
				case COM.ComVar.ConsCDC_Loading_C :							
					
					dt_Search = Search_Color_Load(cmb_Factory.SelectedValue.ToString(), cmb_LoadDate.SelectedValue.ToString());					
					break;
			
			}

			for(int i=0; i< dt_Search.Rows.Count  ; i++)
			{				
				fgrid_Style.AddItem(dt_Search.Rows[i].ItemArray, fgrid_Style.Rows.Count, 1);
			}
				
		}
		
		private bool Check_Save_Style()
		{			
			
			try
			{				
				txt_Err.Text  ="[Check Error]"+ "\r\n";

				#region 데이터 비교				

				//string vExcelData = "";					
				int vErrorCNT = 1;


				for(int i = fgrid_Style.Rows.Fixed ; i< fgrid_Style.Rows.Count; i++)
				{			

					fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxCHECK] = "T";
					fgrid_Style[i,0] = COM.ComVar.ConsCDC_U;


					for(int j= (int)ClassLib.TBSXB_SRF_STYLE.IxFACTORY; j < fgrid_Style.Cols.Count ; j++)
					{							
						string vSRFNo 
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO].ToString() == "" )
							  ? "None" :fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO].ToString();
						string vBomId
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID].ToString() == "")
							  ?"None":fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID].ToString();
						string vStyleCd 
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD].ToString() == "")
							  ?"None":fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD].ToString();
						

						//필수항목
						if( fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO] == null   || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSRF_NO].ToString() == "" ||
							fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID] == null   || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxBOM_ID].ToString() == "" ||
							fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD].ToString() == "" )
						{								
							
							fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxCHECK] = "F";
							fgrid_Style[i,0] = "";
							fgrid_Style.GetCellRange(i,(int)ClassLib.TBSXB_SRF_STYLE.IxFACTORY,i,fgrid_Style.Cols.Count-1).StyleNew.ForeColor 
								= ClassLib.ComVar.Clr_Head_Red;	
							txt_Err.Text +=Convert.ToString(vErrorCNT++) + ". "+  vSRFNo + " + " + vBomId+" + "+vStyleCd +" is empty"+ "\r\n";


							break;							
						}					   		
					}


				}				

				#endregion 			

				return true;
			}
			catch
			{				
				return false;
			}

		}

		private bool Check_Save_Color()
		{
			try
			{
				
				txt_Err.Text  ="[Check Error]"+ "\r\n";

				#region 데이터  비교								
				int vErrorCNT = 1;

				for(int i = fgrid_Style.Rows.Fixed ; i< fgrid_Style.Rows.Count; i++)
				{				

					fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCHECK] = "T";
					fgrid_Style[i,0] = COM.ComVar.ConsCDC_U;

					for(int j= (int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD; j < fgrid_Style.Cols.Count-3 ; j++)
					{					
						
						string vColorCd 
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD].ToString() == "" )
							? "None" :fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD].ToString();
						string vColorDesc
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_DESC] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_DESC].ToString() == "")
							?"None":fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_DESC].ToString();
						string vStatus 
							= (fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxSTATUS] == null || fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxSTATUS].ToString() == "")
							?"None":fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxSTATUS].ToString();
					

						//Null Check
						if( fgrid_Style[i,j] == null || fgrid_Style[i,j].ToString() == "")
						{								
							fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCHECK] = "F";
							fgrid_Style[i,0] = "";
							fgrid_Style.GetCellRange(i,(int)ClassLib.TBSXB_SRF_COLOR.IxFACTORY,i,fgrid_Style.Cols.Count-1).StyleNew.ForeColor 
								= ClassLib.ComVar.Clr_Head_Red;	
							txt_Err.Text +=Convert.ToString(vErrorCNT++) + ". "+  vColorCd + " + " + vColorDesc+" + "+vStatus +" is empty"+ "\r\n";


							break;							
						}
				
					}
					

				}				
				#endregion				


				return true;
			}
			catch
			{
				return false;
			}
			
		}
		
		private void Confirm_Threading()
		{

			try
			{
				
				this.Cursor = Cursors.WaitCursor;		

				if (!Update_Data( cmb_Factory.SelectedValue.ToString(),  COM.ComVar.This_User ))
				{
					ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun,this);
					return;
				}

			}
			catch (Exception ex)
			{
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
				this.Cursor = Cursors.Default;
			}
			finally
			{								
				this.Cursor = Cursors.Default;
				_pop.Close();
                COM.ComFunction.Status_Bar_Message(COM.ComVar.MgsEndRun, this);			
			}

		}
		
		
		#endregion

		#region 이벤트처리 
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
					return;

				COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

				Init_Form();
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
 		
		private void btn_open_file_Click(object sender, System.EventArgs e)
		{
			try
			{	

				txt_Err.Clear();

		
				fgrid_Style.Rows.Count  = fgrid_Style.Rows.Fixed;
				fgrid_Style.ClearAll();


				openFileDialog1.InitialDirectory = "";	
				if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				{
					txt_Path.Text = null;
					return;
				}
				txt_Path.Text = openFileDialog1.FileName;	
			

				this.Cursor  = Cursors.WaitCursor;

				
				_dt_list = Read_Style_Excel(cmb_Type.Text.Trim() , txt_Path.Text );					
				Display_Excel_Grid(_dt_list, fgrid_Style);  

				tbtn_Save.Enabled = true;              
				
			}
			catch
			{
				#region Error Message - txt_err
				switch( cmb_Type.SelectedValue.ToString() )
				{

				
					case ClassLib.ComVar.ConsCDC_Loading_S :
					{
						txt_Err.Text =  "[ Excel Sheet ]"               + "\r\n";
						txt_Err.Text += " 1. Sheet Name  : STYLE "      + "\r\n"
							          + " 2. Column Name : "            + "\r\n"
									  + "  SRF_NO "					    + "\r\n" 
									  + "  BOM_ID "						+ "\r\n"
									  + "  BOM_REV "					+ "\r\n"
									  + "  STYLE_CD "					+ "\r\n"
									  + "  XDM_DIM_CD "					+ "\r\n"
									  + "  STATUS "						+ "\r\n"							         
									  +									  "\r\n"
									  +									  "\r\n"
									  + "[ Security ]"					+ "\r\n"									 
									  + " Release Security ( Excel File ) " ;
						break;
					}
					
					case ClassLib.ComVar.ConsCDC_Loading_C :
					{
						txt_Err.Text =  "[ Excel Sheet ]"				+ "\r\n";
						txt_Err.Text += " 1. Sheet Name  : COLOR "      + "\r\n"
									  + " 2. Column Name : "            + "\r\n"
									  + "  COLOR_CD "					+ "\r\n"
									  + "  COLOR_DESC "					+ "\r\n"
									  + "  STATUS "						+ "\r\n" 									
									  +									  "\r\n"
									  +									  "\r\n"
									  + "[ Security ]"					+ "\r\n"									 
									  + " Release Security ( Excel File ) " ;
						break; 
					}
					

				}
				#endregion

				this.Cursor  = Cursors.Default;
				ClassLib.ComFunction.User_Message("File Format Error", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor  = Cursors.Default;
			}

		}
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			#region Button Setting
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Print.Enabled  = false;
			tbtn_Delete.Enabled = false;
			tbtn_Save.Enabled   = false;
			tbtn_Color.Enabled  = false;
			#endregion			

			#region TextBox Setting
			txt_Err.Clear();					
			#endregion

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;			
			fgrid_Style.Rows.Count = fgrid_Style.Rows.Fixed;		
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{

				if ((cmb_LoadDate ==  null) || (cmb_LoadDate.Text == "")) return;

				this.Cursor  = Cursors.WaitCursor;				
				txt_Path.Clear();

				Display_Grid();
				
				tbtn_Save.Enabled  = true;
				tbtn_Color.Enabled = true;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

			}
			catch
			{

				this.Cursor  = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);

			}
			finally
			{				
				this.Cursor  = Cursors.Default;
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{

				this.Cursor  = Cursors.WaitCursor;


				if(cmb_Type.SelectedValue.ToString() == COM.ComVar.ConsCDC_Loading_S) 
					Check_Save_Style();
				if(cmb_Type.SelectedValue.ToString() == COM.ComVar.ConsCDC_Loading_C)
					Check_Save_Color();


				int vErrorCnt  = 0;
				for( int i = fgrid_Style.Rows.Fixed ; i < fgrid_Style.Rows.Count ; i++)
				{


					switch(cmb_Type.SelectedValue.ToString())
					{

						case COM.ComVar.ConsCDC_Loading_S :

							if( fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxCHECK].ToString() == "T")
							{		
				
								fgrid_Style.Top = i;
								fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxCHECK] = "S";
								fgrid_Style[i,0] = "";


								if (Save_Data_Style("I", fgrid_Style.Rows[i]) == false )
								{
									fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxCHECK] = "E";
									txt_Err.Text  +=  Convert.ToString(vErrorCnt++)  + fgrid_Style[i,(int)ClassLib.TBSXB_SRF_STYLE.IxSTYLE_CD].ToString()+ ":" + "Save Fail...."+ "\r\n";
								}


							}

							break;

						
						case COM.ComVar.ConsCDC_Loading_C :

							if( fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCHECK].ToString() == "T")
							{	
					
								fgrid_Style.Top = i;
								fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCHECK] = "S";
								fgrid_Style[i,0] = "";


								if (Save_Data_Color("I", fgrid_Style.Rows[i]) == false )
								{
									fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCHECK] = "E";
									txt_Err.Text  +=  Convert.ToString(vErrorCnt++)  + fgrid_Style[i,(int)ClassLib.TBSXB_SRF_COLOR.IxCOLOR_CD].ToString()+ ":" + "Save Fail...."+ "\r\n";
								}


							}

							break;
					}				
					
					
					fgrid_Style.Top = fgrid_Style.Rows.Fixed;					
				}

			}
			catch
			{
				this.Cursor  = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			finally
			{
				this.Cursor  = Cursors.Default;
				
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}		

		}

		private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			// Threading //
			_pop = new Pop_BS_Shipping_List_Wait();

			Thread vCreate = new Thread(new ThreadStart(Confirm_Threading));
			vCreate.Start();
			_pop.Start();	
			

			Display_Grid();		
		}

		private void cmb_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{

			if (cmb_Type.SelectedIndex ==  -1) return;
		
			switch(cmb_Type.SelectedValue.ToString())
			{

				case COM.ComVar.ConsCDC_Loading_S : 

					#region Grid Setting
					fgrid_Style.Set_Grid_CDC("SXB_SRF_STYLE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					fgrid_Style.Set_Action_Image(img_Action);
					fgrid_Style.Font =new Font("Verdana", 8);
					fgrid_Style.ExtendLastCol = true; 
					pnl_Grid.Width = 555;
					#endregion

					#region Load Date Setting		
					DataTable dt_ret  = Select_Load_Date( COM.ComVar.ConsCDC_Loading_S, cmb_Factory.SelectedValue.ToString() );

					//if   (dt_ret.Rows.Count  ==0) return; 

					COM.ComCtl.Set_ComboList(dt_ret, cmb_LoadDate, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
					cmb_LoadDate.SelectedIndex = 0;
					#endregion					

					#region TextBox Setting
					txt_Path.Clear();
					txt_Err.Clear();
					#endregion				
					
					break;
				
				case COM.ComVar.ConsCDC_Loading_C : 

					#region Grid Setting
					fgrid_Style.Set_Grid_CDC("SXB_SRF_COLOR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					fgrid_Style.Set_Action_Image(img_Action);
					fgrid_Style.Font =new Font("Verdana", 8);
					fgrid_Style.ExtendLastCol = true; 	
					pnl_Grid.Width = 335;
					#endregion

					#region Load Date Setting		
					dt_ret  = Select_Load_Date( COM.ComVar.ConsCDC_Loading_C, cmb_Factory.SelectedValue.ToString() );
					//if   (dt_ret.Rows.Count  ==0) return; 

					COM.ComCtl.Set_ComboList(dt_ret, cmb_LoadDate, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
					cmb_LoadDate.SelectedIndex = 0;
					#endregion				

					#region TextBox Setting
					txt_Path.Clear();
					txt_Err.Clear();
					#endregion					

					break;
				
				default : 
					break;
			}		
	

			
		}
		
		
		#endregion

		#region DB Connect		

		private DataTable Select_Load_Date(string arg_division, string arg_factory)
		{ 			

			DataSet ds_ret; 		
			
			MyOraDB.ReDim_Parameter(3); 

			MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_LOAD_DATE";

			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = arg_division;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return  ds_ret.Tables[0];

		}

		private DataTable Read_Style_Excel(string arg_sheet_name, string arg_path )
		{
			DataSet  ds_ret = null;

			switch(cmb_Type.SelectedValue.ToString())
			{

				case COM.ComVar.ConsCDC_Loading_S :
				{
								
					string strSql = "SELECT SRF_NO,	BOM_ID,	BOM_REV,	STYLE_CD,	XDM_DIM_CD,	STATUS " + "  FROM [" + arg_sheet_name + "$] ";             ;
					ds_ret = ClassLib.ComFunction.Read_Excel(arg_path, strSql);

					
					break;


				}
				case COM.ComVar.ConsCDC_Loading_C :
				{
								
					string strSql = "SELECT COLOR_CD,	COLOR_DESC	,STATUS " + "  FROM [" + arg_sheet_name + "$] ";             
					ds_ret = ClassLib.ComFunction.Read_Excel(arg_path, strSql);

					
					break;

				}

			}

			return ds_ret.Tables[0];


		}		

		private bool Save_Data_Style(string arg_division, C1.Win.C1FlexGrid.Row arg_fgrid_style)
		{		


				MyOraDB.ReDim_Parameter(10);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SXB_BASE_01.SAVE_SXB_SRF_STYLE_LOAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_LOAD_YMD";
				MyOraDB.Parameter_Name[3]  = "ARG_SRF_NO";
				MyOraDB.Parameter_Name[4]  = "ARG_BOM_ID";
				MyOraDB.Parameter_Name[5]  = "ARG_BOM_REV";			
				MyOraDB.Parameter_Name[6]  = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[7]  = "ARG_XDM_DIM_CD";
				MyOraDB.Parameter_Name[8]  = "ARG_STATUS";
				MyOraDB.Parameter_Name[9]  = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			

				//04.DATA 정의
				MyOraDB.Parameter_Values[0]  = arg_division;
				MyOraDB.Parameter_Values[1]  = arg_fgrid_style[1].ToString();
				MyOraDB.Parameter_Values[2]  = arg_fgrid_style[2].ToString();
				MyOraDB.Parameter_Values[3]  = arg_fgrid_style[3].ToString();
				MyOraDB.Parameter_Values[4]  = arg_fgrid_style[4].ToString();
				MyOraDB.Parameter_Values[5]  = arg_fgrid_style[5].ToString();			
				MyOraDB.Parameter_Values[6]  = arg_fgrid_style[6].ToString();
				MyOraDB.Parameter_Values[7]  = arg_fgrid_style[7].ToString();
				MyOraDB.Parameter_Values[8]  = arg_fgrid_style[8].ToString();
				MyOraDB.Parameter_Values[9]  = arg_fgrid_style[9].ToString();

				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_Set  = MyOraDB.Exe_Modify_Procedure();	
	
				
				if (ds_Set == null) return false;
				else return true;

		}

		private bool Save_Data_Color(string arg_division, C1.Win.C1FlexGrid.Row arg_fgrid_style)
		{		


			MyOraDB.ReDim_Parameter(7);

	
			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_01.SAVE_SXB_SRF_COLOR_LOAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_LOAD_YMD";
			MyOraDB.Parameter_Name[3]  = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[4]  = "ARG_COLOR_DESC";
			MyOraDB.Parameter_Name[5]  = "ARG_STATUS";			
			MyOraDB.Parameter_Name[6]  = "ARG_UPD_USER";
			

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = arg_division;
			MyOraDB.Parameter_Values[1]  = arg_fgrid_style[1].ToString();
			MyOraDB.Parameter_Values[2]  = arg_fgrid_style[2].ToString();
			MyOraDB.Parameter_Values[3]  = arg_fgrid_style[3].ToString();
			MyOraDB.Parameter_Values[4]  = arg_fgrid_style[4].ToString();
			MyOraDB.Parameter_Values[5]  = arg_fgrid_style[5].ToString();			
			MyOraDB.Parameter_Values[6]  = arg_fgrid_style[6].ToString();
		

			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_Set  = MyOraDB.Exe_Modify_Procedure();	
	
				
			if (ds_Set == null) return false;
			else return true;

		}

		private DataTable Search_Style_Load(string arg_factory,string arg_load_ymd)
		{

			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_STYLE_LOAD" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOAD_YMD";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar ; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar ; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor ; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_load_ymd;
			MyOraDB.Parameter_Values[2] = "";




			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];

		}

		private DataTable Search_Color_Load(string arg_factory,string arg_load_ymd)
		{

			DataSet ds_Search ; 

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_COLOR_LOAD" ; 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOAD_YMD";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03. DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar ; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar ; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor ; 

			//04. DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_load_ymd;
			MyOraDB.Parameter_Values[2] = "";


			MyOraDB.Add_Select_Parameter(true);
			ds_Search = MyOraDB.Exe_Select_Procedure();	

			return ds_Search.Tables[MyOraDB.Process_Name];

		}

		private bool Update_Data(string arg_factory, string arg_upd_user)
		{		


			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			if( cmb_Type.SelectedValue.ToString() == COM.ComVar.ConsCDC_Loading_S )
			MyOraDB.Process_Name = "PKG_SXB_BASE_01.UPDATE_SXB_SRF_STYLE_LOAD";

			if( cmb_Type.SelectedValue.ToString() == COM.ComVar.ConsCDC_Loading_C )
			MyOraDB.Process_Name = "PKG_SXB_BASE_01.UPDATE_SXB_SRF_COLOR_LOAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_UPD_USER";
			

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
						

			//04.DATA 정의
			MyOraDB.Parameter_Values[0]  = arg_factory;
			MyOraDB.Parameter_Values[1]  = arg_upd_user;
			
			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_Set  = MyOraDB.Exe_Modify_Procedure();	
					

			if(ds_Set == null)
				return false;
			else
				return true;
			
		}

		
		#endregion
		
		private void Form_SRF_Style_Load(object sender, System.EventArgs e)
		{
			try
			{
				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;			
			}
			catch
			{

			}
		}
	}
}

