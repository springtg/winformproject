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
using System.IO;


namespace FlexCDC.CDC_Bom
{
	public class Pop_Bom_Muti_Confirm : COM.PCHWinForm.Pop_Large_B
	{
		#region ,컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_Sampletypes;
		private System.Windows.Forms.Label lbl_Sampletypes;
		private System.Windows.Forms.TextBox txt_Srno;
		private System.Windows.Forms.Label lbl_Srno;
		private System.Windows.Forms.TextBox txt_Srfno;
		private System.Windows.Forms.Label lbl_Srfno;
		private System.Windows.Forms.TextBox txt_bomrev;
		private System.Windows.Forms.TextBox txt_bomid;
		private System.Windows.Forms.Label lbl_Bom;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_body;
        public COM.FSP fgrid_Confirm;
		private System.ComponentModel.IContainer components = null;

		public Pop_Bom_Muti_Confirm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Bom_Muti_Confirm));
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
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.lbl_Sampletypes = new System.Windows.Forms.Label();
            this.txt_Srno = new System.Windows.Forms.TextBox();
            this.lbl_Srno = new System.Windows.Forms.Label();
            this.txt_bomrev = new System.Windows.Forms.TextBox();
            this.txt_bomid = new System.Windows.Forms.TextBox();
            this.lbl_Bom = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_Sampletypes = new C1.Win.C1List.C1Combo();
            this.txt_Srfno = new System.Windows.Forms.TextBox();
            this.lbl_Srfno = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.fgrid_Confirm = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Confirm)).BeginInit();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(521, 4);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(744, 23);
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
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 64);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(820, 96);
            this.pnl_Search.TabIndex = 40;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.lbl_Sampletypes);
            this.pnl_SearchImage.Controls.Add(this.txt_Srno);
            this.pnl_SearchImage.Controls.Add(this.lbl_Srno);
            this.pnl_SearchImage.Controls.Add(this.txt_bomrev);
            this.pnl_SearchImage.Controls.Add(this.txt_bomid);
            this.pnl_SearchImage.Controls.Add(this.lbl_Bom);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.cmb_Sampletypes);
            this.pnl_SearchImage.Controls.Add(this.txt_Srfno);
            this.pnl_SearchImage.Controls.Add(this.lbl_Srfno);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(795, 80);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // lbl_Sampletypes
            // 
            this.lbl_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sampletypes.ImageIndex = 0;
            this.lbl_Sampletypes.ImageList = this.img_Label;
            this.lbl_Sampletypes.Location = new System.Drawing.Point(569, 31);
            this.lbl_Sampletypes.Name = "lbl_Sampletypes";
            this.lbl_Sampletypes.Size = new System.Drawing.Size(100, 21);
            this.lbl_Sampletypes.TabIndex = 357;
            this.lbl_Sampletypes.Tag = "21";
            this.lbl_Sampletypes.Text = "Round";
            this.lbl_Sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Srno
            // 
            this.txt_Srno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Srno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_Srno.ForeColor = System.Drawing.Color.Black;
            this.txt_Srno.Location = new System.Drawing.Point(389, 32);
            this.txt_Srno.MaxLength = 100;
            this.txt_Srno.Name = "txt_Srno";
            this.txt_Srno.ReadOnly = true;
            this.txt_Srno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Srno.Size = new System.Drawing.Size(120, 20);
            this.txt_Srno.TabIndex = 356;
            // 
            // lbl_Srno
            // 
            this.lbl_Srno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Srno.ImageIndex = 0;
            this.lbl_Srno.ImageList = this.img_Label;
            this.lbl_Srno.Location = new System.Drawing.Point(288, 32);
            this.lbl_Srno.Name = "lbl_Srno";
            this.lbl_Srno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Srno.TabIndex = 355;
            this.lbl_Srno.Tag = "21";
            this.lbl_Srno.Text = "Sample Req.#";
            this.lbl_Srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_bomrev
            // 
            this.txt_bomrev.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomrev.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomrev.ForeColor = System.Drawing.Color.Black;
            this.txt_bomrev.Location = new System.Drawing.Point(469, 55);
            this.txt_bomrev.MaxLength = 100;
            this.txt_bomrev.Name = "txt_bomrev";
            this.txt_bomrev.ReadOnly = true;
            this.txt_bomrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bomrev.Size = new System.Drawing.Size(39, 20);
            this.txt_bomrev.TabIndex = 352;
            // 
            // txt_bomid
            // 
            this.txt_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bomid.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_bomid.ForeColor = System.Drawing.Color.Black;
            this.txt_bomid.Location = new System.Drawing.Point(389, 55);
            this.txt_bomid.MaxLength = 100;
            this.txt_bomid.Name = "txt_bomid";
            this.txt_bomid.ReadOnly = true;
            this.txt_bomid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_bomid.Size = new System.Drawing.Size(79, 20);
            this.txt_bomid.TabIndex = 351;
            // 
            // lbl_Bom
            // 
            this.lbl_Bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bom.ImageIndex = 0;
            this.lbl_Bom.ImageList = this.img_Label;
            this.lbl_Bom.Location = new System.Drawing.Point(288, 55);
            this.lbl_Bom.Name = "lbl_Bom";
            this.lbl_Bom.Size = new System.Drawing.Size(100, 21);
            this.lbl_Bom.TabIndex = 350;
            this.lbl_Bom.Tag = "21";
            this.lbl_Bom.Text = "BOM Id/Rev";
            this.lbl_Bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style1;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(120, 21);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 359;
            // 
            // cmb_Sampletypes
            // 
            this.cmb_Sampletypes.AddItemCols = 0;
            this.cmb_Sampletypes.AddItemSeparator = ';';
            this.cmb_Sampletypes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Sampletypes.Caption = "";
            this.cmb_Sampletypes.CaptionHeight = 17;
            this.cmb_Sampletypes.CaptionStyle = style9;
            this.cmb_Sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Sampletypes.ColumnCaptionHeight = 18;
            this.cmb_Sampletypes.ColumnFooterHeight = 18;
            this.cmb_Sampletypes.ContentHeight = 16;
            this.cmb_Sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Sampletypes.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_Sampletypes.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Sampletypes.EditorHeight = 16;
            this.cmb_Sampletypes.Enabled = false;
            this.cmb_Sampletypes.EvenRowStyle = style10;
            this.cmb_Sampletypes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sampletypes.FooterStyle = style11;
            this.cmb_Sampletypes.GapHeight = 2;
            this.cmb_Sampletypes.HeadingStyle = style12;
            this.cmb_Sampletypes.HighLightRowStyle = style13;
            this.cmb_Sampletypes.ItemHeight = 15;
            this.cmb_Sampletypes.Location = new System.Drawing.Point(670, 32);
            this.cmb_Sampletypes.MatchEntryTimeout = ((long)(2000));
            this.cmb_Sampletypes.MaxDropDownItems = ((short)(5));
            this.cmb_Sampletypes.MaxLength = 32767;
            this.cmb_Sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Sampletypes.Name = "cmb_Sampletypes";
            this.cmb_Sampletypes.OddRowStyle = style14;
            this.cmb_Sampletypes.PartialRightColumn = false;
            this.cmb_Sampletypes.PropBag = resources.GetString("cmb_Sampletypes.PropBag");
            this.cmb_Sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Sampletypes.SelectedStyle = style15;
            this.cmb_Sampletypes.Size = new System.Drawing.Size(120, 20);
            this.cmb_Sampletypes.Style = style16;
            this.cmb_Sampletypes.TabIndex = 358;
            // 
            // txt_Srfno
            // 
            this.txt_Srfno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Srfno.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_Srfno.ForeColor = System.Drawing.Color.Black;
            this.txt_Srfno.Location = new System.Drawing.Point(117, 55);
            this.txt_Srfno.MaxLength = 100;
            this.txt_Srfno.Name = "txt_Srfno";
            this.txt_Srfno.ReadOnly = true;
            this.txt_Srfno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Srfno.Size = new System.Drawing.Size(120, 20);
            this.txt_Srfno.TabIndex = 354;
            // 
            // lbl_Srfno
            // 
            this.lbl_Srfno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Srfno.ImageIndex = 0;
            this.lbl_Srfno.ImageList = this.img_Label;
            this.lbl_Srfno.Location = new System.Drawing.Point(16, 55);
            this.lbl_Srfno.Name = "lbl_Srfno";
            this.lbl_Srfno.Size = new System.Drawing.Size(100, 21);
            this.lbl_Srfno.TabIndex = 353;
            this.lbl_Srfno.Tag = "21";
            this.lbl_Srfno.Text = "SRF No";
            this.lbl_Srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(16, 32);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 348;
            this.lbl_Factory.Tag = "0";
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(694, 25);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 40);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(779, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(571, 32);
            this.picb_TM.TabIndex = 0;
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
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "      Bom Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(779, 65);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 64);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(635, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 65);
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
            this.picb_ML.Size = new System.Drawing.Size(211, 47);
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
            this.picb_MM.Size = new System.Drawing.Size(627, 40);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.fgrid_Confirm);
            this.pnl_body.Location = new System.Drawing.Point(0, 160);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(809, 367);
            this.pnl_body.TabIndex = 41;
            // 
            // fgrid_Confirm
            // 
            this.fgrid_Confirm.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Confirm.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Confirm.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Confirm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Confirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Confirm.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Confirm.Name = "fgrid_Confirm";
            this.fgrid_Confirm.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Confirm.Size = new System.Drawing.Size(809, 367);
            this.fgrid_Confirm.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Confirm.Styles"));
            this.fgrid_Confirm.TabIndex = 108;
            // 
            // Pop_Bom_Muti_Confirm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(808, 528);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Pop_Bom_Muti_Confirm";
            this.Load += new System.EventHandler(this.Pop_Bom_Muti_Confirm_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Confirm)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		#region 사용자 정의 변수			
        private COM.OraDB MyOraDB = new COM.OraDB();
        public bool save_flg = false;
		#endregion 

		#region 공통 메쏘드

		private void Init_Form()
		{
			try
			{
                this.Cursor = Cursors.WaitCursor;

				this.Text = "Bom Muti Confirm";
                this.lbl_MainTitle.Text = "Bom Muti Confirm";
				ClassLib.ComFunction.SetLangDic(this); 

				#region Button & Control Setting
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Conform.Enabled = false;
				tbtn_Create.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_New.Enabled	 = false;
				tbtn_Print.Enabled   = false;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = false;

                cmb_Factory.Enabled = false;
                cmb_Sampletypes.Enabled = false;
                txt_bomid.Enabled = false;
                txt_bomrev.Enabled = false;
                txt_Srfno.Enabled = false;
                txt_Srno.Enabled = false;
				#endregion 
                				
                #region ComboBox Setting
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
				ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;

				dt_ret = Select_sdc_nf_desc();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Sampletypes, 0,2 , false, false);
                #endregion

                #region 속성정보 설정

                cmb_Factory.SelectedValue  = COM.ComVar.Parameter_PopUp[0];
				txt_Srno.Text			   = COM.ComVar.Parameter_PopUp[1];
				txt_Srfno.Text			   = COM.ComVar.Parameter_PopUp[2];
				txt_bomid.Text			   = COM.ComVar.Parameter_PopUp[3];
				txt_bomrev.Text			   = COM.ComVar.Parameter_PopUp[4];
				cmb_Sampletypes.SelectedValue  =  COM.ComVar.Parameter_PopUp[5];
				//_part_no  =  COM.ComVar.Parameter_PopUp[6];


				
				


				#endregion  

				#region 그리드
				//TBSXD_CONFIRM_SRF
				fgrid_Confirm.Set_Grid_CDC("SXD_SRF_CONFIRM", "1", 1,  COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_Confirm.Set_Action_Image(img_Action);
				fgrid_Confirm.Font = new Font("Verdana", 8);
				fgrid_Confirm.Rows.Count = fgrid_Confirm.Rows.Fixed;
				#endregion 	                               

				Set_Data();	
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message (ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor  = Cursors.Default;
			}

		}

		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

			if  (arg_dt.Rows.Count  == 0) return; 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count,0);
            } 
			
			arg_fgrid.Rows[arg_fgrid.Rows.Fixed ].AllowEditing = false;
			arg_fgrid[arg_fgrid.Rows.Fixed ,1] ="true";
			arg_fgrid.Rows[arg_fgrid.Rows.Fixed ].StyleNew.ForeColor = Color.Red;
		}
        
		private void Set_Data()
		{
			DataTable dt_list  =  Select_Sdd_Srf_Confirm();
			Display_Grid(dt_list, fgrid_Confirm);
		}

		#endregion 

		#region 공통이벤트 
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

				this.Cursor  = Cursors.WaitCursor;

				for (int i  = fgrid_Confirm.Rows.Fixed;  i<fgrid_Confirm.Rows.Count ; i++)
				{
					if ( fgrid_Confirm[i,(int)ClassLib.TBSXD_CONFIRM_SRF.lxCHECK].ToString() != "True") continue;

					Confirm_Srf_Muti(i);
					fgrid_Confirm.GetCellRange(i, 1,i,fgrid_Confirm.Cols.Count-1 ).StyleNew.BackColor  =  ClassLib.ComVar.ClrLightPink;

				}


                save_flg = true;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsEndRun, this);

			}
			catch
			{
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
				
			}
			finally
			{

				this.Cursor  = Cursors.Default;

			}



		}
        
        //private void btn_Close_Click(object sender, System.EventArgs e)
        //{
        //    this.Close();
        //}


		#endregion  

		#region DB컨넥트

		private void Confirm_Srf_Muti(int arg_row )
		{
			string Proc_Name = "PKG_SXD_SRF_03.SAVE_LOAD_CONFORM_SRF";

			MyOraDB.ReDim_Parameter(7);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
			MyOraDB.Parameter_Name[4] = "ARG_BOM_REV";
			MyOraDB.Parameter_Name[5] = "ARG_NF_CD";
			MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Values[0] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxFACTORY].ToString();
			MyOraDB.Parameter_Values[1] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxSR_NO].ToString();
			MyOraDB.Parameter_Values[2] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxSRF_NO].ToString();
			MyOraDB.Parameter_Values[3] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxBOM_ID].ToString();
			MyOraDB.Parameter_Values[4] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxBOM_REV].ToString();
			MyOraDB.Parameter_Values[5] = fgrid_Confirm[arg_row,(int)ClassLib.TBSXD_CONFIRM_SRF.lxNF_CD].ToString();
			MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Run_Parameter(true);
			MyOraDB.Exe_Run_Procedure();


		}



		private DataTable Select_sdc_nf_desc()
		{			

			MyOraDB.ReDim_Parameter(2);

			MyOraDB.Process_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC" ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}


		private DataTable Select_Sdd_Srf_Confirm()
		{
			int vCount  = 7, a =0, b=0, c=0;
			MyOraDB.ReDim_Parameter(vCount);

			MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_CONFIRM_MUTI" ;


			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_BOM_ID";			
			MyOraDB.Parameter_Name[a++] = "ARG_BOM_REV";	
			MyOraDB.Parameter_Name[a++] = "ARG_NF_CD";	
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[c++] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++] = txt_Srno.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_Srfno.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_bomid.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_bomrev.Text.ToString();
			MyOraDB.Parameter_Values[c++] = cmb_Sampletypes.SelectedValue.ToString();	
			MyOraDB.Parameter_Values[c++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}


		#endregion 

		private void Pop_Bom_Muti_Confirm_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}




	}
}

