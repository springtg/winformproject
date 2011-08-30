using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow;

namespace FlexCDC.BaseInfo
{
	public class Form_PB_OpCd : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

        private System.Windows.Forms.ContextMenu cmenu_Node;
		private System.Windows.Forms.MenuItem menuItem_NodeProp;
        private System.Windows.Forms.MenuItem menuItem_NodeDel;
        private System.Windows.Forms.ImageList img_MiniButton;
        private System.Windows.Forms.ImageList img_LongButton;
        private Panel panel6;
        public COM.FSP fgrid_OpCd;
        public Panel pnl_SBodyTop;
        public Panel panel3;
        private Label btn_OAppendRow;
        private TextBox txt_ODetailQty;
        private Label lbl_ODetailQty;
        private Label btn_SetDetailOpCd;
        private C1.Win.C1List.C1Combo cmb_OCFactory;
        private Label lbl_OCFactory;
        public PictureBox pictureBox18;
        public PictureBox pictureBox24;
        public PictureBox pictureBox17;
        public PictureBox pictureBox19;
        public PictureBox pictureBox20;
        public PictureBox pictureBox21;
        public Label lbl_SubTitle3;
        public PictureBox pictureBox22;
        public PictureBox pictureBox23;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_OpCd()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_OpCd));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.cmenu_Node = new System.Windows.Forms.ContextMenu();
            this.menuItem_NodeProp = new System.Windows.Forms.MenuItem();
            this.menuItem_NodeDel = new System.Windows.Forms.MenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fgrid_OpCd = new COM.FSP();
            this.pnl_SBodyTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_OAppendRow = new System.Windows.Forms.Label();
            this.txt_ODetailQty = new System.Windows.Forms.TextBox();
            this.lbl_ODetailQty = new System.Windows.Forms.Label();
            this.btn_SetDetailOpCd = new System.Windows.Forms.Label();
            this.cmb_OCFactory = new C1.Win.C1List.C1Combo();
            this.lbl_OCFactory = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCd)).BeginInit();
            this.pnl_SBodyTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OCFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
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
            // tbtn_Insert
            // 
            this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // cmenu_Node
            // 
            this.cmenu_Node.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_NodeProp,
            this.menuItem_NodeDel});
            // 
            // menuItem_NodeProp
            // 
            this.menuItem_NodeProp.Index = 0;
            this.menuItem_NodeProp.Text = "Node Property";
            // 
            // menuItem_NodeDel
            // 
            this.menuItem_NodeDel.Index = 1;
            this.menuItem_NodeDel.Text = "Delete Node";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.fgrid_OpCd);
            this.panel6.Controls.Add(this.pnl_SBodyTop);
            this.panel6.Location = new System.Drawing.Point(0, 65);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel6.Size = new System.Drawing.Size(1014, 576);
            this.panel6.TabIndex = 29;
            // 
            // fgrid_OpCd
            // 
            this.fgrid_OpCd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_OpCd.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_OpCd.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OpCd.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_OpCd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_OpCd.Location = new System.Drawing.Point(8, 76);
            this.fgrid_OpCd.Name = "fgrid_OpCd";
            this.fgrid_OpCd.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OpCd.Size = new System.Drawing.Size(998, 498);
            this.fgrid_OpCd.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_OpCd.Styles"));
            this.fgrid_OpCd.TabIndex = 35;
            this.fgrid_OpCd.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OpCd_AfterEdit);
            // 
            // pnl_SBodyTop
            // 
            this.pnl_SBodyTop.Controls.Add(this.panel3);
            this.pnl_SBodyTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SBodyTop.Location = new System.Drawing.Point(8, 0);
            this.pnl_SBodyTop.Name = "pnl_SBodyTop";
            this.pnl_SBodyTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_SBodyTop.Size = new System.Drawing.Size(998, 73);
            this.pnl_SBodyTop.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btn_OAppendRow);
            this.panel3.Controls.Add(this.txt_ODetailQty);
            this.panel3.Controls.Add(this.lbl_ODetailQty);
            this.panel3.Controls.Add(this.btn_SetDetailOpCd);
            this.panel3.Controls.Add(this.cmb_OCFactory);
            this.panel3.Controls.Add(this.lbl_OCFactory);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.pictureBox24);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.lbl_SubTitle3);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 65);
            this.panel3.TabIndex = 19;
            // 
            // btn_OAppendRow
            // 
            this.btn_OAppendRow.ImageIndex = 0;
            this.btn_OAppendRow.ImageList = this.img_MiniButton;
            this.btn_OAppendRow.Location = new System.Drawing.Point(589, 36);
            this.btn_OAppendRow.Name = "btn_OAppendRow";
            this.btn_OAppendRow.Size = new System.Drawing.Size(21, 21);
            this.btn_OAppendRow.TabIndex = 199;
            this.btn_OAppendRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ODetailQty
            // 
            this.txt_ODetailQty.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ODetailQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ODetailQty.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_ODetailQty.Location = new System.Drawing.Point(533, 36);
            this.txt_ODetailQty.MaxLength = 60;
            this.txt_ODetailQty.Name = "txt_ODetailQty";
            this.txt_ODetailQty.Size = new System.Drawing.Size(55, 21);
            this.txt_ODetailQty.TabIndex = 198;
            // 
            // lbl_ODetailQty
            // 
            this.lbl_ODetailQty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ODetailQty.ImageIndex = 0;
            this.lbl_ODetailQty.ImageList = this.img_Label;
            this.lbl_ODetailQty.Location = new System.Drawing.Point(432, 36);
            this.lbl_ODetailQty.Name = "lbl_ODetailQty";
            this.lbl_ODetailQty.Size = new System.Drawing.Size(100, 21);
            this.lbl_ODetailQty.TabIndex = 197;
            this.lbl_ODetailQty.Text = "Detail Qty";
            this.lbl_ODetailQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SetDetailOpCd
            // 
            this.btn_SetDetailOpCd.ImageIndex = 0;
            this.btn_SetDetailOpCd.ImageList = this.img_LongButton;
            this.btn_SetDetailOpCd.Location = new System.Drawing.Point(328, 35);
            this.btn_SetDetailOpCd.Name = "btn_SetDetailOpCd";
            this.btn_SetDetailOpCd.Size = new System.Drawing.Size(100, 23);
            this.btn_SetDetailOpCd.TabIndex = 122;
            this.btn_SetDetailOpCd.Text = "Set Detail Proc";
            this.btn_SetDetailOpCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_OCFactory
            // 
            this.cmb_OCFactory.AddItemCols = 0;
            this.cmb_OCFactory.AddItemSeparator = ';';
            this.cmb_OCFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OCFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OCFactory.Caption = "";
            this.cmb_OCFactory.CaptionHeight = 17;
            this.cmb_OCFactory.CaptionStyle = style1;
            this.cmb_OCFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OCFactory.ColumnCaptionHeight = 18;
            this.cmb_OCFactory.ColumnFooterHeight = 18;
            this.cmb_OCFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OCFactory.ContentHeight = 17;
            this.cmb_OCFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OCFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OCFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OCFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OCFactory.EditorHeight = 17;
            this.cmb_OCFactory.EvenRowStyle = style2;
            this.cmb_OCFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OCFactory.FooterStyle = style3;
            this.cmb_OCFactory.GapHeight = 2;
            this.cmb_OCFactory.HeadingStyle = style4;
            this.cmb_OCFactory.HighLightRowStyle = style5;
            this.cmb_OCFactory.ItemHeight = 15;
            this.cmb_OCFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_OCFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_OCFactory.MaxDropDownItems = ((short)(5));
            this.cmb_OCFactory.MaxLength = 32767;
            this.cmb_OCFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OCFactory.Name = "cmb_OCFactory";
            this.cmb_OCFactory.OddRowStyle = style6;
            this.cmb_OCFactory.PartialRightColumn = false;
            this.cmb_OCFactory.PropBag = resources.GetString("cmb_OCFactory.PropBag");
            this.cmb_OCFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OCFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OCFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OCFactory.SelectedStyle = style7;
            this.cmb_OCFactory.Size = new System.Drawing.Size(180, 21);
            this.cmb_OCFactory.Style = style8;
            this.cmb_OCFactory.TabIndex = 38;
            // 
            // lbl_OCFactory
            // 
            this.lbl_OCFactory.ImageIndex = 0;
            this.lbl_OCFactory.ImageList = this.img_Label;
            this.lbl_OCFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_OCFactory.Name = "lbl_OCFactory";
            this.lbl_OCFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_OCFactory.TabIndex = 37;
            this.lbl_OCFactory.Text = "Factory";
            this.lbl_OCFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(981, 24);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(17, 30);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(982, 50);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(16, 16);
            this.pictureBox24.TabIndex = 23;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(131, 49);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(998, 18);
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(982, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 32);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(224, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(998, 32);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(160, 24);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(998, 25);
            this.pictureBox21.TabIndex = 27;
            this.pictureBox21.TabStop = false;
            // 
            // lbl_SubTitle3
            // 
            this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
            this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle3.Name = "lbl_SubTitle3";
            this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle3.TabIndex = 20;
            this.lbl_SubTitle3.Text = "      Production Operation";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(0, 24);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(168, 32);
            this.pictureBox22.TabIndex = 25;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 50);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(168, 20);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            // 
            // Form_PB_OpCd
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel6);
            this.Name = "Form_PB_OpCd";
            this.Text = "Production Operation";
            this.Load += new System.EventHandler(this.Form_PB_OpCd_Load);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OpCd)).EndInit();
            this.pnl_SBodyTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OCFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB();

		private int _Rowfixed;
		
		private Hashtable _Imgmap = new Hashtable();

		//삽입때마다 새로 그려지는 노드 정보
		private Lassalle.Flow.Node _AddNode;



		private int _OpCd_SelRow;
		private int _Line_SelRow;

		// opcd header 정보
		private DataTable _OpCdHeadDT = new DataTable("OpCdHeadTitle");


  
		#endregion 

		#region 멤버 메서드 
 

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{  

			DataTable dt_list;
			CellStyle cellst;
			 
			//Title
			this.Text = "Production Operation";
			this.lbl_MainTitle.Text = "Production Operation";  
 

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

			tbtn_Print.Enabled = false; 


//			cmb_OCFactory.Enabled = false;
//			cmb_OLFactory.Enabled = false;



            //fgrid_OpType.Set_Grid("NODE_OP_DEF", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
            //_Rowfixed = fgrid_OpType.Rows.Fixed;
            //fgrid_OpType.Set_Action_Image(img_Action);

			//공정 코드
			fgrid_OpCd.Set_Grid("SXB_OP_CODE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			_Rowfixed = fgrid_OpCd.Rows.Fixed;
			fgrid_OpCd.Set_Action_Image(img_Action); 
			fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD.IxMOLD_TYPE].ComboList = "..."; 

			btn_SetDetailOpCd.Enabled = false;
			lbl_ODetailQty.Visible = false;
			txt_ODetailQty.Visible = false;
			btn_OAppendRow.Visible = false;

			

			//-------------------------------------------------------
			//첫번째 행 헤더 정보 저장 (실제 디비 필드명)
  
			DataRow datarow;

			for(int i = 0; i < fgrid_OpCd.Cols.Count; i++)
			{
				_OpCdHeadDT.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			} 

			//opcd
			datarow = _OpCdHeadDT.NewRow();
				 
			datarow[0] = "ARG_DIVISION";

			for(int i = 1; i < fgrid_OpCd.Cols.Count; i++)
			{ 
				datarow[i] = "ARG_" + fgrid_OpCd[0, i].ToString(); 
			} 
			 
			_OpCdHeadDT.Rows.Add(datarow); 




			//공장 리스트 
			dt_list = ClassLib.ComFunction.Select_Factory_List_CDC();
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OCFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
 

			
			cmb_OCFactory.SelectedValue = ClassLib.ComVar.This_Factory;


		}

		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxOP_NAME;
			int grid_remarks = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxREMARKS;
			int grid_count = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxCOUNT;
			int grid_div = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxDIV;
			int grid_parentopcd = (int)ClassLib.TBSPB_OPCD_LINE_HEAD.IxPARENT_OPCD;


			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			if(arg_fgrid.Equals(fgrid_OpCd))
			{ 
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";
				
					if(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR].ToString() == "") continue;

					arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD).StyleNew.BackColor 
						= Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR].ToString()) );
				 
				}
			} 

			 arg_fgrid.AutoSizeCols();
 
		}


		/// <summary>
		/// Display_TreeGrid : 트리 형태로 표시 
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_TreeGrid(DataTable arg_dt, COM.FSP arg_fgrid)
		{  
			int level = (int)ClassLib.TBSPB_OPCD.IxOP_LEVEL;
 
			int grid_factory = (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY; 
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD;
			int grid_upcd = (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_GRID.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_NAME;
			int grid_optype = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_TYPE;
			int grid_deptcd = (int)ClassLib.TBSPB_OPCD_GRID.IxDEPT_CD;
			int grid_opcolor = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR;

			int grid_real = (int)ClassLib.TBSPB_OPCD_GRID.IxREAL_YN;
			int grid_capa = (int)ClassLib.TBSPB_OPCD_GRID.IxCAPA_YN;
			int grid_mold = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;
			int grid_out = (int)ClassLib.TBSPB_OPCD_GRID.IxOUT_YN;
			int grid_job = (int)ClassLib.TBSPB_OPCD_GRID.IxJOB_YN;
			int grid_pcard = (int)ClassLib.TBSPB_OPCD_GRID.IxPCARD_YN;
			int grid_rst = (int)ClassLib.TBSPB_OPCD_GRID.IxRST_YN;
			int grid_jit = (int)ClassLib.TBSPB_OPCD_GRID.IxMAT_AREA_YN;
			int grid_indetail = (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN;

			int grid_moldtype = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE;
			int grid_dirmargin = (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN;

            int grid_display = (int)ClassLib.TBSPB_OPCD_GRID.IxDISPLAY_YN;
            int grid_use = (int)ClassLib.TBSPB_OPCD_GRID.IxUSE_YN;

			int grid_remarks = (int)ClassLib.TBSPB_OPCD_GRID.IxREMARKS;
			int grid_upduser = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER; 
			int grid_updymd = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD; 
			int grid_level = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL; 
			int grid_hopcd = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD; 
			 
			try
			{
				arg_fgrid.Tree.Column = grid_opcd;
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.Rows.InsertNode(i + arg_fgrid.Rows.Fixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_NAME].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxFACTORY].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_upcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxSG_CMP_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxAREA_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_optype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_TYPE].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_deptcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxDEPT_CD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_opcolor] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_real] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxREAL_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_capa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxCAPA_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_mold] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMOLD_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_out] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOUT_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_job] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxJOB_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_pcard] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxPCARD_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_rst] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxRST_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_jit] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMAT_AREA_YN].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_indetail] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxIN_DETAIL_YN].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxMOLD_TYPE].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_dirmargin] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxDIR_MARGIN].ToString();

                    arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_display] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxDISPLAY_YN].ToString();
                    arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_use] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxUSE_YN].ToString();

					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxREMARKS].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_upduser] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxUPD_USER].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_updymd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxUPD_YMD].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_LEVEL].ToString();
					arg_fgrid[i + arg_fgrid.Rows.Fixed, grid_hopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxH_OP_CD].ToString();


				

					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString() == "") continue; 
					arg_fgrid.GetCellRange(i + arg_fgrid.Rows.Fixed, grid_opcd).StyleNew.BackColor 
						= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_COLOR].ToString()) ); 
					
//					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD.IxOP_LEVEL].ToString() == "2") continue;
//					arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed].AllowEditing = true;

					

 
				} // end for i 

				arg_fgrid.AutoSizeCols();
				arg_fgrid.Tree.Style = TreeStyleFlags.Complete; 

			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.ToString());
			}

		}

		

		/// <summary>
		/// Display_TreeGrid_InDetail : 세부 공정을 상위공정아래 행에 삽입
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_TreeGrid_InDetail(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			int level = (int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_LEVEL;
 
			int grid_factory = (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY; 
			int grid_opcd = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD;
			int grid_upcd = (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD;
			int grid_areacd = (int)ClassLib.TBSPB_OPCD_GRID.IxAREA_CD;
			int grid_opname = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_NAME;
			int grid_optype = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_TYPE;
			int grid_deptcd = (int)ClassLib.TBSPB_OPCD_GRID.IxDEPT_CD;
			int grid_opcolor = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR;

			int grid_real = (int)ClassLib.TBSPB_OPCD_GRID.IxREAL_YN;
			int grid_capa = (int)ClassLib.TBSPB_OPCD_GRID.IxCAPA_YN;
			int grid_mold = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;
			int grid_out = (int)ClassLib.TBSPB_OPCD_GRID.IxOUT_YN;
			int grid_job = (int)ClassLib.TBSPB_OPCD_GRID.IxJOB_YN;
			int grid_pcard = (int)ClassLib.TBSPB_OPCD_GRID.IxPCARD_YN;
			int grid_rst = (int)ClassLib.TBSPB_OPCD_GRID.IxRST_YN;
			int grid_jit = (int)ClassLib.TBSPB_OPCD_GRID.IxMAT_AREA_YN;
			int grid_indetail = (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN;

			int grid_moldtype = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE;
			int grid_dirmargin = (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN;
			int grid_remarks = (int)ClassLib.TBSPB_OPCD_GRID.IxREMARKS;
			int grid_upduser = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER; 
			int grid_updymd = (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD; 
			int grid_level = (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL; 
			int grid_hopcd = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD; 

			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					for(int j = arg_fgrid.Rows.Count - 1; j >= arg_fgrid.Rows.Fixed; j--)
					{
						//spb_opcd_indetail : parent_cmp == spb_opcd : cmp_cd
						//spb_opcd_indetail : parent_opcd == spb_opcd : op_cd

//						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD - 1].ToString()
//							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString())

						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_CMP].ToString()
							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD].ToString()
							&& arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_OPCD].ToString()
							== arg_fgrid[j, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString() )
						{
							arg_fgrid.Rows.InsertNode(j + 1, Convert.ToInt32(arg_dt.Rows[i].ItemArray[level].ToString()) - 1);

							arg_fgrid[j + 1, 0] = ""; 
							arg_fgrid[j + 1, grid_opcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_CD].ToString();
							arg_fgrid[j + 1, grid_opname] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_NAME].ToString();

							arg_fgrid[j + 1, grid_factory] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxFACTORY].ToString();
							arg_fgrid[j + 1, grid_upcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPARENT_CMP].ToString();
							arg_fgrid[j + 1, grid_areacd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxAREA_CD].ToString();
							arg_fgrid[j + 1, grid_optype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_TYPE].ToString();
							arg_fgrid[j + 1, grid_deptcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxDEPT_CD].ToString();
							arg_fgrid[j + 1, grid_opcolor] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString();

							arg_fgrid[j + 1, grid_real] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxREAL_YN].ToString();
							arg_fgrid[j + 1, grid_capa] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxCAPA_YN].ToString();
							arg_fgrid[j + 1, grid_mold] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxMOLD_YN].ToString();
							arg_fgrid[j + 1, grid_out] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOUT_YN].ToString();
							arg_fgrid[j + 1, grid_job] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxJOB_YN].ToString();
							arg_fgrid[j + 1, grid_pcard] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxPCARD_YN].ToString();
							arg_fgrid[j + 1, grid_rst] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxRST_YN].ToString();
							arg_fgrid[j + 1, grid_jit] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxJIT_YN].ToString();
							arg_fgrid[j + 1, grid_indetail] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxIN_DETAIL_YN].ToString();

							arg_fgrid[j + 1, grid_moldtype] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxMOLD_TYPE].ToString();
							arg_fgrid[j + 1, grid_dirmargin] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxDIR_MARGIN].ToString();
							arg_fgrid[j + 1, grid_remarks] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxREMARKS].ToString();
							arg_fgrid[j + 1, grid_upduser] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxUPD_USER].ToString();
							arg_fgrid[j + 1, grid_updymd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxUPD_YMD].ToString();
							arg_fgrid[j + 1, grid_level] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_LEVEL].ToString();
							arg_fgrid[j + 1, grid_hopcd] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxH_OP_CD].ToString();
 

							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString() == "") continue; 
							arg_fgrid.GetCellRange(j + 1, grid_opcd).StyleNew.BackColor 
								= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_OPCD_INDETAIL.IxOP_COLOR].ToString()) ); 
					
						} 

					} // end for j 
				} // end for i

				arg_fgrid.AutoSizeCols();

			}
			catch
			{
			}
		}




		/// <summary>
		/// 노드 정보 가져오기
		/// </summary>
		private void Set_NodeProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Node arg_node, int arg_index)
		{ 
			   
		
			//Alignment
			foreach (Alignment v in Enum.GetValues(typeof(Alignment)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxALIGNMENT].ToString() == v.GetHashCode().ToString())
				{
					arg_node.Alignment = v; 
					break;
				}
			}

			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_node.DashStyle = v;
					break;
				}
			}

			arg_node.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWCOLOR].ToString()));
			arg_node.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxDRAWWIDTH].ToString());
			arg_node.FillColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxFILLCOLOR].ToString()));

			//Font 속성
			arg_node.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxFONT].ToString());

			//Gradient 속성
			arg_node.Gradient = (arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADI_YN].ToString() == "Y" ? true : false);

			if (arg_node.Gradient)
			{
				arg_node.GradientColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADICOLOR].ToString()));
				
				foreach (System.Drawing.Drawing2D.LinearGradientMode v in Enum.GetValues(typeof(System.Drawing.Drawing2D.LinearGradientMode)))
				{
					if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxGRADIMODE].ToString() == v.GetHashCode().ToString())
					{
						arg_node.GradientMode = v;
						break;
					}
				}
			}   //end if
    
			//Shaow 
			if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHADOW].ToString().Split(delimiter); 

				/////shadow -> style
				foreach (ShadowStyle v in Enum.GetValues(typeof(ShadowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shadow.Style = v;
						break;
					}
				}
              
				/////shadow -> color, width, height
				arg_node.Shadow.Color = Color.FromArgb(Convert.ToInt32(token[1]));
				arg_node.Shadow.Size = new Size(Convert.ToInt32(token[2]), Convert.ToInt32(token[3]));

			}

			//Shape
			if(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxSHAPE].ToString().Split(delimiter); 

				////shape -> style
				foreach (ShapeStyle v in Enum.GetValues(typeof(ShapeStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Style = v;
						break;
					}
				}  
		 
				////shape -> orientation
				foreach (ShapeOrientation v in Enum.GetValues(typeof(ShapeOrientation)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Orientation = v;
						break;
					}
				}  
			}
 
			//TextColor
			arg_node.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.TBSPB_NODE_OPDEF.IxTEXTCOLOR].ToString()));
 
		}

 
 
		/// <summary>
		/// Set_Color : 배경색, 글자색 지정
		/// </summary>
		private void Set_Color()
		{
			ColorDialog clrdig = new ColorDialog();
			int r1, r2;
			int from_row, to_row;
			int i; 

			r1 = fgrid_OpCd.Selection.r1;
			r2 = fgrid_OpCd.Selection.r2;
 

			from_row = (r1 < r2) ? r1 : r2;
			to_row = (r1 < r2) ? r2 : r1;

			if(clrdig.ShowDialog() == DialogResult.OK)
			{
				for(i = from_row; i <= to_row; i++)
				{
					fgrid_OpCd[i, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_COLOR] = clrdig.Color.ToArgb().ToString(); 
					if(fgrid_OpCd[i, 0].ToString() == "") fgrid_OpCd[i, 0] = "U"; 
					fgrid_OpCd.GetCellRange(i, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD).StyleNew.BackColor = clrdig.Color;
				} //end for
			} // end if


		}

		/// <summary>
		/// Delete_SPB_OPCD : 삭제
		/// </summary>
		private void Delete_SPB_OPCD()
		{
			try
			{
				int sel_row = fgrid_OpCd.Selection.r1;
				string sel_level = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString();

				int torow = 0;

				//신규로 삽입 상태
				if(fgrid_OpCd[sel_row, 0].ToString() == "I")
				{
					switch(sel_level)
					{
							//하위까지 삭제
						case "1":   
 
							torow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
							if(torow == -1) torow = fgrid_OpCd.Rows.Count;

							for(int i = torow - 1; i >= sel_row; i--) fgrid_OpCd.Rows.Remove(i);

							break;
					
							//현재행만 삭제
						case "2":

							fgrid_OpCd.Rows.Remove(sel_row);

							break;
					}
				
				}
					//수정, 삭제 상태
				else
				{
					switch(sel_level)
					{
							//하위까지 삭제
						case "1":   
 
//							torow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
//							if(torow == -1) torow = fgrid_OpCd.Rows.Count;
//							
//							for(int i = torow - 1; i >= sel_row; i--) fgrid_OpCd[i, 0] = "D"; 
 							 
							int sel_r1 = fgrid_OpCd.Selection.r1;
							int sel_r2 = fgrid_OpCd.Selection.r2; 
							int start_row, end_row;
 
							start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
							end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

							for(int i = start_row; i <= end_row; i++)
							{
								torow = fgrid_OpCd.FindRow(sel_level.ToString(), i + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);
								if(torow == -1) torow = fgrid_OpCd.Rows.Count;
								
								for(int j = torow - 1; j >= i; j--) fgrid_OpCd[j, 0] = "D";
							}

							break;
					
							//현재행만 삭제
						case "2":

							//fgrid_OpCd[sel_row, 0] = "D";
							fgrid_OpCd.Delete_Row();

							break;
					}

				} // end if
			}
			catch
			{
			}

		}

		#endregion 

		#region 이벤트 처리


		#region 공통 이벤트

        private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
        {
            _Rowfixed = fgrid_OpCd.Rows.Fixed;

            tbtn_Append.Enabled = true;
            tbtn_Insert.Enabled = true;
            tbtn_Color.Enabled = true;
        }



        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            fgrid_OpCd.Rows.Count = _Rowfixed;

        }



        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            DataSet ds_ret;
            DataTable dt_opcd, dt_detail_opcd;

            if (cmb_OCFactory.SelectedIndex == -1) return;

            ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
            dt_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_H"];
            //dt_detail_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];


            //MessageBox.Show(dt_opcd.Rows.Count.ToString() + "    :    " + dt_detail_opcd.Rows.Count.ToString());


            Display_TreeGrid(dt_opcd, fgrid_OpCd);
            //Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);


        }



        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            fgrid_OpCd.Select(fgrid_OpCd.Selection.r1, 0, fgrid_OpCd.Selection.r1, fgrid_OpCd.Cols.Count - 1, false);

            //MyOraDB.Save_FlexGird("PKG_SPB_OPCD.SAVE_OPCD_LIST", fgrid_OpCd);

            Save_SPB_OPCD();

            DataSet ds_ret;
            DataTable dt_opcd, dt_detail_opcd;

            if (cmb_OCFactory.SelectedIndex == -1) return;

            ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
            dt_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_H"];
            dt_detail_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];
            Display_TreeGrid(dt_opcd, fgrid_OpCd);
            Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);
        }




        private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            fgrid_OpCd.Add_Row(fgrid_OpCd.Selection.r1);
            fgrid_OpCd[fgrid_OpCd.Selection.r1, (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY] = cmb_OCFactory.SelectedValue.ToString();
            fgrid_OpCd[fgrid_OpCd.Selection.r1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL] = "1";
        }



        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Delete_SPB_OPCD();
        }

        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Set_Color();

        }

		 

		#endregion 

		#region 공정 타입


		#endregion

		#region 공정 코드
 

		private void cmb_OCFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataSet ds_ret;
			DataTable dt_opcd, dt_detail_opcd;

			if(cmb_OCFactory.SelectedIndex == -1) return;
			  
			ds_ret = Select_Display_SPB_OPCD(cmb_OCFactory.SelectedValue.ToString());
			dt_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_H"];
            dt_detail_opcd = ds_ret.Tables["PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_INDETAIL_D"];
			Display_TreeGrid(dt_opcd, fgrid_OpCd);
			Display_TreeGrid_InDetail(dt_detail_opcd, fgrid_OpCd);
			 
		}
 

		private void fgrid_OpCd_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag;
  	
			try
			{
				if(e.Col == (int)ClassLib.TBSPB_OPCD_GRID.IxDIR_MARGIN)
				{
					digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_OpCd[e.Row, e.Col].ToString());

					if(digit_flag == false) 
					{
						fgrid_OpCd[e.Row, e.Col] = "";
						return;
					}
				}
  

				//------------------------------------------------------------
				fgrid_OpCd.AutoSizeCols();

				if(fgrid_OpCd[e.Row, 0].ToString() == "I") return;
				fgrid_OpCd.Update_Row(); 



				//------------------------------------------------------------
				int sel_row = fgrid_OpCd.Selection.r1;
  
				if(sel_row >= _Rowfixed)
				{ 
					if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxIN_DETAIL_YN].ToString()) ) 
						btn_SetDetailOpCd.Enabled = true;  
					else
					{
						btn_SetDetailOpCd.Enabled = false;
						lbl_ODetailQty.Visible = false;
						txt_ODetailQty.Visible = false;
						btn_OAppendRow.Visible = false;
					}



					//------------------------------------------ 
					if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN].ToString()) ) 
						fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = "...";
					else
						fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = ""; 

				} 

				
			}
			catch
			{
			}
		}
 

		private void fgrid_OpCd_Click(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_OpCd.Selection.r1;
 
			try
			{
				if(sel_row >= _Rowfixed)
				{ 
 
					if(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD] != null)
					{
						if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD].ToString()) ) 
							btn_SetDetailOpCd.Enabled = true;  
						else
						{
							btn_SetDetailOpCd.Enabled = false;
							lbl_ODetailQty.Visible = false;
							txt_ODetailQty.Visible = false;
							btn_OAppendRow.Visible = false;
						}
					}


					//------------------------------------------
					if(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN] != null)
					{
					 
						if(Convert.ToBoolean(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN].ToString()) ) 
							fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = "...";
						else
							fgrid_OpCd.Cols[(int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE].ComboList = ""; 
					}

				}




			}
			catch 
			{ 
			}

		}
  

		private void fgrid_OpCd_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		 
            //int sel_row = fgrid_OpCd.Selection.r1;
            //int sel_col = fgrid_OpCd.Selection.c1;
            //int moldyn = (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_YN;

            //fgrid_OpCd[sel_row, moldyn] = (fgrid_OpCd[sel_row, moldyn] == null) ? "FALSE" : fgrid_OpCd[sel_row, moldyn].ToString();

            //if(!Convert.ToBoolean(fgrid_OpCd[sel_row, moldyn].ToString())) return; 
			
            ////몰드타입 입력하는 팝업
            ////Pop_SetMoldType pop_form = new Pop_SetMoldType();

            //Pop_CreateOPMoldTypes pop_form = new Pop_CreateOPMoldTypes();

            //fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1] 
            //    = (fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1] == null) ? "" : fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1].ToString();

            //ClassLib.ComVar.Parameter_PopUp = new string[] {cmb_OCFactory.SelectedValue.ToString(),
            //                                                   fgrid_OpCd[sel_row, fgrid_OpCd.Selection.c1].ToString()};

            //pop_form.ShowDialog();

            //if(pop_form._CloseSave)
            //{
            //    fgrid_OpCd[sel_row, sel_col] = ClassLib.ComVar.Parameter_PopUp[0];
            //    fgrid_OpCd.Update_Row();
            //}


		}	 
 
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_SetDetailOpCd_Click(object sender, System.EventArgs e)
		{
			try
			{
				txt_ODetailQty.Text = "";

				lbl_ODetailQty.Visible = true;
				txt_ODetailQty.Visible = true;
				btn_OAppendRow.Visible = true;
			}
			catch
			{
			}
		}
 
	
		private void txt_ODetailQty_Leave(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_NumberTextBox(txt_ODetailQty, 3);
		} 

		private void btn_OAppendRow_Click(object sender, System.EventArgs e)
		{
			try
			{  
				int sel_row = fgrid_OpCd.Selection.r1; 
				int sel_level = Convert.ToInt32(fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString() );
				string sel_opcd = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString();
				string sel_cmpcd = fgrid_OpCd[sel_row, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD].ToString();

				int findrow = 0, insert_row = 0;

				findrow = fgrid_OpCd.FindRow(sel_level.ToString(), sel_row + 1, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL, false, true, false);

				if(findrow == -1) findrow = fgrid_OpCd.Rows.Count;

				insert_row = findrow;

				for(int i = 0; i < Convert.ToInt32(txt_ODetailQty.Text); i++)
				{
					//fgrid_OpCd.Rows.InsertNode(insert_row, sel_level);  
 
					fgrid_OpCd.Rows.Insert(insert_row);

					fgrid_OpCd[insert_row, 0] = "I";
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxFACTORY] = cmb_OCFactory.SelectedValue.ToString();
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD] = sel_opcd + "_";
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxSG_CMP_CD] = sel_cmpcd;
					fgrid_OpCd[insert_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL] = Convert.ToString((sel_level + 1));
 
					insert_row++; 
 
				}

				

			}
			catch
			{
			}

 
		}

		

		#endregion


		#region 공정 라인 (공정의 미니라인 정의)
 

  





		#region Copy

		




		#endregion


	
		#endregion


		#endregion 

		#region DB Connect

 

		/// <summary>
		/// Select_OpCd_List_ForOpLine : 공정코드 리스트 
		/// (공정라인 입력 화면에서 공정코드 리스트 표시)
		/// </summary>
		public static DataTable Select_OpCd_List_ForOpLine(string arg_factory)
		{
 
			 
			COM.OraDB LMyOraDB = new COM.OraDB();

			DataSet ds_ret; 
 
			LMyOraDB.ReDim_Parameter(2); 
 
			LMyOraDB.Process_Name = "PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD";
  
			LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			LMyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			LMyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			LMyOraDB.Parameter_Values[0] = arg_factory; 
			LMyOraDB.Parameter_Values[1] = "";

			LMyOraDB.Add_Select_Parameter(true); 
			ds_ret = LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 
			return ds_ret.Tables[LMyOraDB.Process_Name]; 

		}


		/// <summary>
		/// Select_OpCode_List : 공정코드 리스트 
		/// </summary>
		public static DataTable Select_OpCd_List(string arg_factory)
		{
			 
			COM.OraDB LMyOraDB = new COM.OraDB();

			DataSet ds_ret; 
 
			LMyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			LMyOraDB.Process_Name = "PKG_SXB_PJ_OPCD.SELECT_OPCD_LIST";
 
			//02.ARGURMENT명
			LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			LMyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			LMyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			LMyOraDB.Parameter_Values[0] = arg_factory;
			LMyOraDB.Parameter_Values[1] = "";

			LMyOraDB.Add_Select_Parameter(true);
 
			ds_ret = LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[LMyOraDB.Process_Name]; 
		}




		


	



		/// <summary>
		/// Save_SPB_OPCD : SPB_OPCD, SPB_OPCD_INDETAIL 저장
		/// </summary>
		private bool Save_SPB_OPCD()
		{
			int col_ct = (int)ClassLib.TBSPB_OPCD_GRID.IxH_OP_CD + 1;	    // 칼럼의 수
			int row_fixed = fgrid_OpCd.Rows.Fixed;						// 그리드 고정행 값
			int count = 0, save_ct =0 ;											// 저장 행 수
 
			int para_ct =0;												// 파라미터 값의 저장 배열의 수
			int row,col;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct - 1);
				MyOraDB.Process_Name = "PKG_SXB_PJ_OPCD.SAVE_SPB_OPCD";

				// 파라미터 이름 설정 
				for(int i = 0; i <= col_ct - 1; i++)
				{
					if(i == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD) continue;
					if(i == (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD) continue;

					MyOraDB.Parameter_Name[count] = _OpCdHeadDT.Rows[0].ItemArray[i].ToString(); 
					count++;
				}
                MyOraDB.Parameter_Name[col_ct - 2] = "ARG_PARENT_OPCD"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 	 
	
				}
	
				// 저장 행 수 구하기
				for(int i = row_fixed ; i < fgrid_OpCd.Rows.Count; i++)
				{
					if(fgrid_OpCd[i, 0].ToString() != "") save_ct += 1; 
				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[(col_ct - 1) * save_ct];


				// 각 행의 변경값 Setting
				for(row = row_fixed; row < fgrid_OpCd.Rows.Count ; row++)
				{
					if(fgrid_OpCd[row, 0].ToString() != "")
					{ 
						for(col = 0; col <= col_ct - 1 ; col++)	// 각 열의 값 Setting
						{
							if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_YMD) continue;
							if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxDETAIL_OPCD) continue;

							// 데이터값 설정 
							if(fgrid_OpCd.Cols[col].Style.DataType != null
								&& fgrid_OpCd.Cols[col].DataType.Equals(typeof(bool)) )
							{
								fgrid_OpCd[row, col] = (fgrid_OpCd[row, col] == null) ? "False" : fgrid_OpCd[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}
								//콤보리스트 처리 추가 
							else if(fgrid_OpCd.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE)
								{
									MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row,col].ToString();
								}
								else
								{
									fgrid_OpCd[row, col] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row, col].ToString();
  
									token = fgrid_OpCd[row,col].ToString().Split(delimiter);  
									MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
  
								}

								para_ct ++;

							}
							else
							{
								//if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxMOLD_TYPE) continue;

								if(col == (int)ClassLib.TBSPB_OPCD_GRID.IxUPD_USER) 
									MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User; 
								else 
									MyOraDB.Parameter_Values[para_ct] = (fgrid_OpCd[row, col] == null) ? "" : fgrid_OpCd[row,col].ToString();
								 
								para_ct ++;

							} // end if( 데이터값 설정 )	
		
						} // end for col 

 

						//------------------------------------------------------------------------------------------------------------
						// 세부 공정 저장 시 상위 공정 코드 설정
						int up_opcd_row = -1;

						for(int a = row - 1; a >= fgrid_OpCd.Rows.Fixed; a--)
						{
							if(fgrid_OpCd[a, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_LEVEL].ToString() == "1")
							{
								up_opcd_row = a;
								break;
							} 
						}

						if(up_opcd_row == -1)
						{
							MyOraDB.Parameter_Values[para_ct] = "";
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct] = fgrid_OpCd[up_opcd_row, (int)ClassLib.TBSPB_OPCD_GRID.IxOP_CD].ToString();
						}
						para_ct ++;
						//------------------------------------------------------------------------------------------------------------





					} // end if
				} // end for row

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_OPCD",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}

			

		/// <summary>
		/// Select_Display_SPB_OPCD : 공정코드 리스트 (트리로 표현하기 위한 데이터 테이블 추출) 
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataSet Select_Display_SPB_OPCD(string arg_factory)
		{
			DataSet ds_ret; 
 
			try
			{
				// spb_opcd
				MyOraDB.ReDim_Parameter(2);

                MyOraDB.Process_Name = "PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_H";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true);
 
				// spb_opcd_indetail
                //MyOraDB.ReDim_Parameter(2); 

                //MyOraDB.Process_Name = "PKG_SXB_PJ_OPCD.SELECT_SPB_OPCD_INDETAIL_D";
 
                //MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                //MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                //MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                //MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
                //MyOraDB.Parameter_Values[0] = arg_factory; 
                //MyOraDB.Parameter_Values[1] = "";

                //MyOraDB.Add_Select_Parameter(false);
 
				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ;
				return ds_ret; 
			}
			catch
			{
				return null;
			}

		}


		#endregion
 

		private void Form_PB_OpCd_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
		}

		




	}
}


