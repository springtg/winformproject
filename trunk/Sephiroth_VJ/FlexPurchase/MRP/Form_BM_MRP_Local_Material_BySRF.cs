using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexMRP.MRP
{
	public class Form_BM_MRP_Local_Material_BySRF : COM.PCHWinForm.Form_Top, IOperation
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
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private COM.FSP fgrid_SRF;
		private COM.FSP fgrid_Yield;
		private System.Windows.Forms.MenuItem menuItem_Search;
		private System.Windows.Forms.ContextMenu cmenu_SRF; 
		private System.Windows.Forms.Label lbl_Season;
		private C1.Win.C1List.C1Combo cmb_Season;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_TreeView;
		private System.Windows.Forms.MenuItem menuItem_TreeView_Style;
		private System.Windows.Forms.MenuItem menuItem_TreeView_Item;
		

		private System.ComponentModel.IContainer components = null;

		#endregion
		
		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();  

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Local_Material_BySRF()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_MRP_Local_Material_BySRF));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_Yield = new COM.FSP();
            this.fgrid_SRF = new COM.FSP();
            this.cmenu_SRF = new System.Windows.Forms.ContextMenu();
            this.menuItem_Search = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeView = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeView_Style = new System.Windows.Forms.MenuItem();
            this.menuItem_TreeView_Item = new System.Windows.Forms.MenuItem();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_Season = new C1.Win.C1List.C1Combo();
            this.lbl_Season = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_SRF)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
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
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
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
            this.c1Sizer1.Controls.Add(this.fgrid_Yield);
            this.c1Sizer1.Controls.Add(this.fgrid_SRF);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "11.9791666666667:False:True;43.0555555555556:True:False;43.5763888888889:False:Tr" +
                "ue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575:" +
                "False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_Yield
            // 
            this.fgrid_Yield.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Yield.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Yield.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Yield.Location = new System.Drawing.Point(8, 325);
            this.fgrid_Yield.Name = "fgrid_Yield";
            this.fgrid_Yield.Size = new System.Drawing.Size(1000, 251);
            this.fgrid_Yield.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Yield.Styles"));
            this.fgrid_Yield.TabIndex = 4;
            // 
            // fgrid_SRF
            // 
            this.fgrid_SRF.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_SRF.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_SRF.ContextMenu = this.cmenu_SRF;
            this.fgrid_SRF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_SRF.Location = new System.Drawing.Point(8, 73);
            this.fgrid_SRF.Name = "fgrid_SRF";
            this.fgrid_SRF.Size = new System.Drawing.Size(1000, 248);
            this.fgrid_SRF.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_SRF.Styles"));
            this.fgrid_SRF.TabIndex = 3;
            this.fgrid_SRF.DoubleClick += new System.EventHandler(this.fgrid_SRF_DoubleClick);
            // 
            // cmenu_SRF
            // 
            this.cmenu_SRF.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Search,
            this.menuItem2,
            this.menuItem_TreeView});
            // 
            // menuItem_Search
            // 
            this.menuItem_Search.Index = 0;
            this.menuItem_Search.Text = "Search";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem_TreeView
            // 
            this.menuItem_TreeView.Index = 2;
            this.menuItem_TreeView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_TreeView_Style,
            this.menuItem_TreeView_Item});
            this.menuItem_TreeView.Text = "Tree View Option";
            // 
            // menuItem_TreeView_Style
            // 
            this.menuItem_TreeView_Style.Index = 0;
            this.menuItem_TreeView_Style.Text = "Style";
            this.menuItem_TreeView_Style.Click += new System.EventHandler(this.menuItem_TreeView_Style_Click);
            // 
            // menuItem_TreeView_Item
            // 
            this.menuItem_TreeView_Item.Index = 1;
            this.menuItem_TreeView_Item.Text = "Item";
            this.menuItem_TreeView_Item.Click += new System.EventHandler(this.menuItem_TreeView_Item_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.cmb_Season);
            this.pnl_head.Controls.Add(this.lbl_Season);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_Factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 69);
            this.pnl_head.TabIndex = 2;
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
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
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
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // cmb_Season
            // 
            this.cmb_Season.AddItemCols = 0;
            this.cmb_Season.AddItemSeparator = ';';
            this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Season.Caption = "";
            this.cmb_Season.CaptionHeight = 17;
            this.cmb_Season.CaptionStyle = style25;
            this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Season.ColumnCaptionHeight = 18;
            this.cmb_Season.ColumnFooterHeight = 18;
            this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Season.ContentHeight = 16;
            this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Season.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Season.EditorHeight = 16;
            this.cmb_Season.EvenRowStyle = style26;
            this.cmb_Season.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.FooterStyle = style27;
            this.cmb_Season.GapHeight = 2;
            this.cmb_Season.HeadingStyle = style28;
            this.cmb_Season.HighLightRowStyle = style29;
            this.cmb_Season.ItemHeight = 15;
            this.cmb_Season.Location = new System.Drawing.Point(437, 40);
            this.cmb_Season.MatchEntryTimeout = ((long)(2000));
            this.cmb_Season.MaxDropDownItems = ((short)(5));
            this.cmb_Season.MaxLength = 32767;
            this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.OddRowStyle = style30;
            this.cmb_Season.PartialRightColumn = false;
            this.cmb_Season.PropBag = resources.GetString("cmb_Season.PropBag");
            this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Season.SelectedStyle = style31;
            this.cmb_Season.Size = new System.Drawing.Size(210, 20);
            this.cmb_Season.Style = style32;
            this.cmb_Season.TabIndex = 413;
            this.cmb_Season.SelectedValueChanged += new System.EventHandler(this.cmb_Season_SelectedValueChanged);
            // 
            // lbl_Season
            // 
            this.lbl_Season.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Season.ImageIndex = 0;
            this.lbl_Season.ImageList = this.img_Label;
            this.lbl_Season.Location = new System.Drawing.Point(336, 40);
            this.lbl_Season.Name = "lbl_Season";
            this.lbl_Season.Size = new System.Drawing.Size(100, 21);
            this.lbl_Season.TabIndex = 412;
            this.lbl_Season.Text = "Season";
            this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      SRF Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 53);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 52);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 50;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 28);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 53);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 51);
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
            // Form_BM_MRP_Local_Material_BySRF
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_MRP_Local_Material_BySRF";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_SRF)).EndInit();
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
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

		#region 그리드 이벤트 처리

		 

		private void fgrid_SRF_DoubleClick(object sender, System.EventArgs e)
		{
			
			try
			{ 
				// default : LLT (T)
				Search_Yield("T");
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_SRF_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		#endregion

		#region 툴바 메뉴 이벤트 처리
		
		 
 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{ 
				Clear(); 
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
				this.Cursor = Cursors.WaitCursor;

				Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		

			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;

				DataTable dt_ret;
 
				// season ---------------------------------------------------------------------------------------------------------
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxSeason);  // SEM15 
				// FA, HO, SP, SU
 

				// season : season + substr(year, 2)
				DataTable temp_datatable= new DataTable("Season"); 
				DataRow newrow;  
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String"))); 
  

				int first_year = Convert.ToInt32(System.DateTime.Now.AddYears(-1).Year);
				int last_year = Convert.ToInt32(System.DateTime.Now.AddYears(5).Year);

		 
				for(int i = first_year; i <= last_year; i++)
				{

					for(int j = 0 ; j < dt_ret.Rows.Count; j++)
					{ 
						newrow = temp_datatable.NewRow();
						newrow["Code"] = dt_ret.Rows[j].ItemArray[1].ToString() + i.ToString().Substring(2); 
						temp_datatable.Rows.Add(newrow);  
					}

				}

				COM.ComCtl.Set_ComboList(temp_datatable, cmb_Season, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code);
				temp_datatable.Dispose();
				// season ---------------------------------------------------------------------------------------------------------

				// srf grid contextmenu -------------------------------------------------------------------------------------------
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalLLTDivision);  // SBP13


				MenuItem new_menu = new MenuItem();  
				new_menu.Text = "ALL" + " ()";   
				menuItem_Search.MenuItems.Add(0, new_menu);
				new_menu.Click += new EventHandler(MenuItem_SRF_Click);

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					new_menu = new MenuItem(); 
					// Local : L, LLT : T, No : N, DS Shipping : S
					new_menu.Text = dt_ret.Rows[i].ItemArray[2].ToString() + " (" + dt_ret.Rows[i].ItemArray[1].ToString() + ")";  

					menuItem_Search.MenuItems.Add(i + 1, new_menu);
					new_menu.Click += new EventHandler(MenuItem_SRF_Click);
 
				}

				// srf grid contextmenu -------------------------------------------------------------------------------------------
			


				dt_ret.Dispose(); 
			


				fgrid_SRF.ClearAll();
				fgrid_Yield.ClearAll();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 

		private void cmb_Season_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				fgrid_SRF.ClearAll();
				fgrid_Yield.ClearAll();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Season_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 

 
		private void MenuItem_SRF_Click(object sender, EventArgs e)
		{  


			try
			{ 
				MenuItem menuitem = (MenuItem)sender;
			
				string[] token = menuitem.Text.Split('(');
				string import_div = token[1].Trim().Replace(")", "");


				Search_Yield(import_div);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MenuItem_SRF_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 

		}



		private void menuItem_TreeView_Style_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				fgrid_SRF.Tree.Show(1);
				fgrid_Yield.Tree.Show(1); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_TreeView_Style_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void menuItem_TreeView_Item_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				fgrid_SRF.Tree.Show(2);
				fgrid_Yield.Tree.Show(2);  
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_TreeView_Item_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
            this.Text = "Local/ LLT Material By SRF";
            lbl_MainTitle.Text = "Local/ LLT Material By SRF";


            ClassLib.ComFunction.SetLangDic(this);


			// grid set  
			fgrid_SRF.Set_Grid("SBM_LOCAL_MAT_BY_SRF", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Yield.Set_Grid("SBM_LOCAL_MAT_BY_SRF", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			//combobox setting
			Init_Control(); 

			

		} 

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			// toolbar button disable setting
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 


			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
		  

			dt_ret.Dispose(); 
 



		}
 


		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			
			cmb_Factory.SelectedIndex = -1;
			cmb_Season.SelectedIndex = -1;

			fgrid_SRF.Rows.Count = fgrid_SRF.Rows.Fixed;
			fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed; 

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_Season};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;


			string factory = cmb_Factory.SelectedValue.ToString();
			string season = cmb_Season.SelectedValue.ToString();  
		 
			DataTable dt_ret = SELECT_SDD_SRF_MATERIAL(factory, season); 
			 
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				fgrid_SRF.ClearAll(); 
			}
			else
			{
				Display_Tree(fgrid_SRF, dt_ret);
			}
  
			dt_ret.Dispose();

		}


		/// <summary>
		/// Search_Yield : 
		/// </summary>
		/// <param name="arg_import_div"></param>
		private void Search_Yield(string arg_import_div)
		{

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_Season};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;

			if(fgrid_SRF.Rows.Count <= fgrid_SRF.Rows.Fixed) return;

			string style_cd = fgrid_SRF[fgrid_SRF.Selection.r1, (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxSTYLE_CD].ToString();

			DataTable dt_ret = SELECT_SBC_YIELD_MATERIAL(style_cd, arg_import_div);

			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				fgrid_Yield.ClearAll(); 
			}
			else
			{
				Display_Tree(fgrid_Yield, dt_ret);
			}

			dt_ret.Dispose();


			// 선택된 행 표시
			int parent_row = fgrid_SRF.Selection.r1;

			C1.Win.C1FlexGrid.Node node = fgrid_SRF.Rows[fgrid_SRF.Selection.r1].Node;
			if(node.Level == 2)
			{
				parent_row = node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index;
			}

			
			fgrid_SRF.Rows[parent_row].Node.Collapsed = false;
			fgrid_SRF.TopRow = parent_row;

			// 모두 표시
			fgrid_Yield.Tree.Show(2);


		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		/// <param name="arg_dt"></param>
		private void Display_Tree(COM.FSP arg_fgrid, DataTable arg_dt)
		{

			int parent_row = 0;
			int count_item = 0; 


			arg_fgrid.ClearAll();  


			if(arg_fgrid.Name == "fgrid_SRF")
			{
				fgrid_SRF.Tree.Column = (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxTREE_DESC;
			}
			else if(arg_fgrid.Name == "fgrid_Yield")
			{
				fgrid_Yield.Tree.Column = (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_YIELD.IxTREE_DESC;
			}

			 
						
			for(int i = 0, idx = 0 ; i < arg_dt.Rows.Count ; i++)
			{
				int vRow = idx + arg_fgrid.Rows.Fixed;
						
				if (i != 0)
				{
					string vKey = "";
					
					if(arg_fgrid.Name == "fgrid_SRF")
					{
						vKey = arg_fgrid[vRow - 1, (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxTREE_KEY].ToString();

						if (vKey.Equals(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxTREE_KEY - 1].ToString()))
						{
							continue;
						}

					}
					else if(arg_fgrid.Name == "fgrid_Yield")
					{
						vKey = arg_fgrid[vRow - 1, (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_YIELD.IxTREE_KEY].ToString();

						if (vKey.Equals(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_YIELD.IxTREE_KEY - 1].ToString()))
						{
							continue;
						}


					} // end if
					
					
				}


				string level = "";

				if(arg_fgrid.Name == "fgrid_SRF")
				{
					level = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxTREE_LEVEL - 1].ToString();
				}
				else if(arg_fgrid.Name == "fgrid_Yield")
				{
					level = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_YIELD.IxTREE_LEVEL - 1].ToString();
				} 
				

				arg_fgrid.Rows.InsertNode(vRow , Convert.ToInt32(level) );

				for (int vCol = 1 ; vCol < arg_fgrid.Cols.Count ; vCol++)
				{  
					arg_fgrid[vRow, vCol] = arg_dt.Rows[i].ItemArray[vCol - 1].ToString();
				} 


				idx++;


				// 레벨별 그리드 행 색 표시 ----------------------------------------------------------------------------------------
				if(Convert.ToInt32(level) == 1)
				{
					arg_fgrid.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
				}
				else  // if(Convert.ToInt32(level) == 2)
				{
					arg_fgrid.Rows[vRow].StyleNew.BackColor = Color.White;  // ClassLib.ComVar.ClrLevel_2nd;
				}
				// 레벨별 그리드 행 색 표시 ----------------------------------------------------------------------------------------
 

				// 레벨 1 스타일 : 레벨 2 아이템 수 표시 --------------------------------------------------------------------------- 
				if(Convert.ToInt32(level) == 1)
				{
					parent_row = vRow;
					count_item = 0;
				}
				else if(Convert.ToInt32(level) == 2)
				{

					count_item++;

					if(arg_fgrid.Name == "fgrid_SRF")
					{
						arg_fgrid[parent_row, (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_SRF.IxMAT_CD] = Convert.ToString(count_item);
					}
					else if(arg_fgrid.Name == "fgrid_Yield")
					{
						arg_fgrid[parent_row, (int)ClassLib.TBM_MRP_LOCAL_MAT_BY_SRF_YIELD.IxITEM_CD] = Convert.ToString(count_item);
					} 

					
				}
				// 레벨 1 스타일 : 레벨 2 아이템 수 표시 ---------------------------------------------------------------------------

				

			} // end for i



			arg_fgrid.Tree.Show(1);


		}



		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{


			 
			  

		}



		#endregion  
		 
		
		#endregion

		#region DB Connect

		/// <summary>
		/// SELECT_SDD_SRF_MATERIAL : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_season"></param>
		/// <returns></returns>
		private DataTable SELECT_SDD_SRF_MATERIAL(string arg_factory, string arg_season)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(3);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL_MAT.SELECT_SDD_SRF_MATERIAL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SEASON";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_season;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SDD_SRF_MATERIAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		/// <summary>
		/// SELECT_SBC_YIELD_MATERIAL : 
		/// </summary>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_import_div"></param>
		/// <returns></returns>
		private DataTable SELECT_SBC_YIELD_MATERIAL(string arg_style_cd, string arg_import_div)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(3);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL_MAT.SELECT_SBC_YIELD_MATERIAL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[1] = "ARG_IMPORT_DIV";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_style_cd;
				MyOraDB.Parameter_Values[1] = arg_import_div;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBC_YIELD_MATERIAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}

		 


		
		#endregion	

		#region IOperation 멤버

		public void CheckStatus()
		{
			//			// status set
			//			txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, COM.ComFunction.Empty_Combo(cmb_factory, ""), COM.ComFunction.Empty_Combo(cmb_shipType, ""));
			//
			//			//			if (!txt_status.Text.ToUpper().Equals(ClassLib.ComVar.Status_SAVE))
			//			//				fgrid_main.AllowEditing = false;
			//			//			else
			//			//				fgrid_main.AllowEditing = true;
			//
			//			// button enable set
			//			DataTable vDt			 = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			//			//tbtn_Save.Enabled		 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Save, txt_status.Text);
			//			tbtn_Confirm.Enabled	 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
			//			btn_RunProcess.Enabled	 = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
		}

		public bool Confirm()
		{
			//			if (ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_shipType, cmb_mrpno}, null))
			//			{
			//				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
			//				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			//
			//				if (ClassLib.ComFunction.SAVE_CHECK_LIST_CONFIRM(_process, vFactory, vShipType, COM.ComVar.This_User, true))
			//				{
			//					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//					txt_status.Text = "Confirm";
			//					tbtn_Save.Enabled = false;
			//					tbtn_Confirm.Enabled = false;
			//					btn_RunProcess.Enabled = false;
			//					fgrid_main.AllowEditing = false;
			//					return true;
			//				}
			//			}

			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{
			//			cmb_factory.Tag = arg_factory;
			//			cmb_shipType.Tag = arg_ShipType;
			//			cmb_mrpno.Tag = arg_mrpNo;
		}

		public int GetSearchRows()
		{
			return fgrid_SRF.Rows.Count;
		}

		#endregion

		
		 
		
 


	}
}

