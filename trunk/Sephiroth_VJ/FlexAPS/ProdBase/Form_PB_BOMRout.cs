using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using Lassalle.Flow;

namespace FlexAPS.ProdBase
{
	public class Form_PB_BOMRout : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.ContextMenu cmenu_Bom;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_Top;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label btn_Clear;
		private System.Windows.Forms.Label btn_Search;
		public C1.Win.C1List.C1Combo cmb_BomCd;
		private System.Windows.Forms.Label lbl_BomCd;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox16;
		public COM.FSP fgrid_BomNode;
		public COM.FSP fgrid_BOM;
		public COM.FSP fgrid_BomLink;
		private Lassalle.Flow.AddFlow addflow_BOM;
		public COM.FSP fgrid_LinkRout;
		public COM.FSP fgrid_NodeRout;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.MenuItem menuItem_DelRout;
		private System.Windows.Forms.MenuItem menuItem_UpdateRout;
		public C1.Win.C1List.C1Combo cmb_RoutType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuItem menuItem_SetRout;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_Print;
		private System.Windows.Forms.MenuItem menuItem_PCard;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_BOMRout()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_BOMRout));
			this.cmenu_Bom = new System.Windows.Forms.ContextMenu();
			this.menuItem_SetRout = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_UpdateRout = new System.Windows.Forms.MenuItem();
			this.menuItem_DelRout = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem_Print = new System.Windows.Forms.MenuItem();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_LinkRout = new COM.FSP();
			this.fgrid_NodeRout = new COM.FSP();
			this.fgrid_BomNode = new COM.FSP();
			this.fgrid_BOM = new COM.FSP();
			this.fgrid_BomLink = new COM.FSP();
			this.addflow_BOM = new Lassalle.Flow.AddFlow();
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmb_RoutType = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_Clear = new System.Windows.Forms.Label();
			this.cmb_BomCd = new C1.Win.C1List.C1Combo();
			this.lbl_BomCd = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.menuItem_PCard = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).BeginInit();
			this.pnl_Top.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_BomCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 623);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// cmenu_Bom
			// 
			this.cmenu_Bom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem_SetRout,
																					  this.menuItem1,
																					  this.menuItem_UpdateRout,
																					  this.menuItem_DelRout,
																					  this.menuItem2,
																					  this.menuItem_PCard,
																					  this.menuItem_Print});
			// 
			// menuItem_SetRout
			// 
			this.menuItem_SetRout.Index = 0;
			this.menuItem_SetRout.Text = "Set Routing";
			this.menuItem_SetRout.Click += new System.EventHandler(this.menuItem_SetRout_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// menuItem_UpdateRout
			// 
			this.menuItem_UpdateRout.Index = 2;
			this.menuItem_UpdateRout.Text = "Update Routing";
			this.menuItem_UpdateRout.Click += new System.EventHandler(this.menuItem_UpdateRout_Click);
			// 
			// menuItem_DelRout
			// 
			this.menuItem_DelRout.Index = 3;
			this.menuItem_DelRout.Text = "Delete Rotuing";
			this.menuItem_DelRout.Click += new System.EventHandler(this.menuItem_DelRout_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 4;
			this.menuItem2.Text = "-";
			// 
			// menuItem_Print
			// 
			this.menuItem_Print.Index = 6;
			this.menuItem_Print.Text = "Print Routing";
			this.menuItem_Print.Click += new System.EventHandler(this.menuItem_Print_Click);
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_LinkRout);
			this.pnl_Body.Controls.Add(this.fgrid_NodeRout);
			this.pnl_Body.Controls.Add(this.fgrid_BomNode);
			this.pnl_Body.Controls.Add(this.fgrid_BOM);
			this.pnl_Body.Controls.Add(this.fgrid_BomLink);
			this.pnl_Body.Controls.Add(this.addflow_BOM);
			this.pnl_Body.Controls.Add(this.pnl_Top);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 64);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 556);
			this.pnl_Body.TabIndex = 28;
			// 
			// fgrid_LinkRout
			// 
			this.fgrid_LinkRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LinkRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LinkRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link rout\";}\t";
			this.fgrid_LinkRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LinkRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LinkRout.Location = new System.Drawing.Point(504, 416);
			this.fgrid_LinkRout.Name = "fgrid_LinkRout";
			this.fgrid_LinkRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LinkRout.Size = new System.Drawing.Size(224, 56);
			this.fgrid_LinkRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LinkRout.TabIndex = 43;
			this.fgrid_LinkRout.Visible = false;
			// 
			// fgrid_NodeRout
			// 
			this.fgrid_NodeRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_NodeRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_NodeRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node rout\";}\t";
			this.fgrid_NodeRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_NodeRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_NodeRout.Location = new System.Drawing.Point(272, 416);
			this.fgrid_NodeRout.Name = "fgrid_NodeRout";
			this.fgrid_NodeRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_NodeRout.Size = new System.Drawing.Size(224, 56);
			this.fgrid_NodeRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_NodeRout.TabIndex = 42;
			this.fgrid_NodeRout.Visible = false;
			// 
			// fgrid_BomNode
			// 
			this.fgrid_BomNode.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_BomNode.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_BomNode.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node bom\";}\t";
			this.fgrid_BomNode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_BomNode.Location = new System.Drawing.Point(272, 480);
			this.fgrid_BomNode.Name = "fgrid_BomNode";
			this.fgrid_BomNode.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_BomNode.Size = new System.Drawing.Size(224, 56);
			this.fgrid_BomNode.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_BomNode.TabIndex = 34;
			this.fgrid_BomNode.Visible = false;
			// 
			// fgrid_BOM
			// 
			this.fgrid_BOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_BOM.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_BOM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_BOM.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"bom tree\";}\t";
			this.fgrid_BOM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_BOM.Location = new System.Drawing.Point(736, 360);
			this.fgrid_BOM.Name = "fgrid_BOM";
			this.fgrid_BOM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_BOM.Size = new System.Drawing.Size(244, 176);
			this.fgrid_BOM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_BOM.TabIndex = 33;
			this.fgrid_BOM.Visible = false;
			// 
			// fgrid_BomLink
			// 
			this.fgrid_BomLink.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_BomLink.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_BomLink.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link bom\";}\t";
			this.fgrid_BomLink.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_BomLink.Location = new System.Drawing.Point(504, 480);
			this.fgrid_BomLink.Name = "fgrid_BomLink";
			this.fgrid_BomLink.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_BomLink.Size = new System.Drawing.Size(224, 56);
			this.fgrid_BomLink.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_BomLink.TabIndex = 35;
			this.fgrid_BomLink.Visible = false;
			// 
			// addflow_BOM
			// 
			this.addflow_BOM.AutoScroll = true;
			this.addflow_BOM.AutoScrollMinSize = new System.Drawing.Size(1157, 572);
			this.addflow_BOM.CanDrawLink = false;
			this.addflow_BOM.CanDrawNode = false;
			this.addflow_BOM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addflow_BOM.Location = new System.Drawing.Point(8, 115);
			this.addflow_BOM.Name = "addflow_BOM";
			this.addflow_BOM.Size = new System.Drawing.Size(1000, 441);
			this.addflow_BOM.TabIndex = 32;
			this.addflow_BOM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addflow_BOM_MouseDown);
			// 
			// pnl_Top
			// 
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.panel2);
			this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.Location = new System.Drawing.Point(8, 0);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1000, 115);
			this.pnl_Top.TabIndex = 29;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 107);
			this.panel2.TabIndex = 20;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.cmb_RoutType);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.btn_Search);
			this.panel3.Controls.Add(this.btn_Clear);
			this.panel3.Controls.Add(this.cmb_BomCd);
			this.panel3.Controls.Add(this.lbl_BomCd);
			this.panel3.Controls.Add(this.pictureBox9);
			this.panel3.Controls.Add(this.pictureBox10);
			this.panel3.Controls.Add(this.cmb_Factory);
			this.panel3.Controls.Add(this.lbl_Factory);
			this.panel3.Controls.Add(this.pictureBox11);
			this.panel3.Controls.Add(this.pictureBox12);
			this.panel3.Controls.Add(this.pictureBox13);
			this.panel3.Controls.Add(this.pictureBox14);
			this.panel3.Controls.Add(this.pictureBox15);
			this.panel3.Controls.Add(this.lbl_SubTitle1);
			this.panel3.Controls.Add(this.pictureBox16);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1000, 107);
			this.panel3.TabIndex = 19;
			// 
			// cmb_RoutType
			// 
			this.cmb_RoutType.AddItemCols = 0;
			this.cmb_RoutType.AddItemSeparator = ';';
			this.cmb_RoutType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_RoutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_RoutType.Caption = "";
			this.cmb_RoutType.CaptionHeight = 17;
			this.cmb_RoutType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_RoutType.ColumnCaptionHeight = 18;
			this.cmb_RoutType.ColumnFooterHeight = 18;
			this.cmb_RoutType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_RoutType.ContentHeight = 17;
			this.cmb_RoutType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_RoutType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_RoutType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_RoutType.EditorHeight = 17;
			this.cmb_RoutType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_RoutType.GapHeight = 2;
			this.cmb_RoutType.ItemHeight = 15;
			this.cmb_RoutType.Location = new System.Drawing.Point(111, 80);
			this.cmb_RoutType.MatchEntryTimeout = ((long)(2000));
			this.cmb_RoutType.MaxDropDownItems = ((short)(5));
			this.cmb_RoutType.MaxLength = 32767;
			this.cmb_RoutType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_RoutType.Name = "cmb_RoutType";
			this.cmb_RoutType.PartialRightColumn = false;
			this.cmb_RoutType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_RoutType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_RoutType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_RoutType.Size = new System.Drawing.Size(180, 21);
			this.cmb_RoutType.TabIndex = 107;
			this.cmb_RoutType.SelectedValueChanged += new System.EventHandler(this.cmb_RoutType_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(10, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 106;
			this.label1.Text = "Routing Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Search
			// 
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(292, 80);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 102;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Clear
			// 
			this.btn_Clear.ImageIndex = 2;
			this.btn_Clear.ImageList = this.img_MiniButton;
			this.btn_Clear.Location = new System.Drawing.Point(314, 80);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(21, 21);
			this.btn_Clear.TabIndex = 103;
			this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			this.btn_Clear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Clear_MouseUp);
			this.btn_Clear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Clear_MouseDown);
			// 
			// cmb_BomCd
			// 
			this.cmb_BomCd.AddItemCols = 0;
			this.cmb_BomCd.AddItemSeparator = ';';
			this.cmb_BomCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_BomCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_BomCd.Caption = "";
			this.cmb_BomCd.CaptionHeight = 17;
			this.cmb_BomCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_BomCd.ColumnCaptionHeight = 18;
			this.cmb_BomCd.ColumnFooterHeight = 18;
			this.cmb_BomCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_BomCd.ContentHeight = 17;
			this.cmb_BomCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_BomCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_BomCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_BomCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_BomCd.EditorHeight = 17;
			this.cmb_BomCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_BomCd.GapHeight = 2;
			this.cmb_BomCd.ItemHeight = 15;
			this.cmb_BomCd.Location = new System.Drawing.Point(111, 58);
			this.cmb_BomCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_BomCd.MaxDropDownItems = ((short)(5));
			this.cmb_BomCd.MaxLength = 32767;
			this.cmb_BomCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_BomCd.Name = "cmb_BomCd";
			this.cmb_BomCd.PartialRightColumn = false;
			this.cmb_BomCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_BomCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_BomCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_BomCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_BomCd.Size = new System.Drawing.Size(180, 21);
			this.cmb_BomCd.TabIndex = 31;
			this.cmb_BomCd.SelectedValueChanged += new System.EventHandler(this.cmb_BomCd_SelectedValueChanged);
			// 
			// lbl_BomCd
			// 
			this.lbl_BomCd.ImageIndex = 0;
			this.lbl_BomCd.ImageList = this.img_Label;
			this.lbl_BomCd.Location = new System.Drawing.Point(10, 58);
			this.lbl_BomCd.Name = "lbl_BomCd";
			this.lbl_BomCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_BomCd.TabIndex = 30;
			this.lbl_BomCd.Text = "BOM Code";
			this.lbl_BomCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(0, 87);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(168, 20);
			this.pictureBox9.TabIndex = 22;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(984, 91);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 16);
			this.pictureBox10.TabIndex = 23;
			this.pictureBox10.TabStop = false;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(180, 21);
			this.cmb_Factory.TabIndex = 18;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 17;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(131, 89);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(853, 18);
			this.pictureBox11.TabIndex = 28;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(985, 24);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(15, 107);
			this.pictureBox12.TabIndex = 26;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(984, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(16, 32);
			this.pictureBox13.TabIndex = 21;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(224, 0);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(800, 32);
			this.pictureBox14.TabIndex = 0;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(160, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(832, 107);
			this.pictureBox15.TabIndex = 27;
			this.pictureBox15.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 20;
			this.lbl_SubTitle1.Text = "      Standard BOM Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(0, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(168, 107);
			this.pictureBox16.TabIndex = 25;
			this.pictureBox16.TabStop = false;
			// 
			// menuItem_PCard
			// 
			this.menuItem_PCard.Index = 5;
			this.menuItem_PCard.Text = "Pass Card Y/N";
			this.menuItem_PCard.Click += new System.EventHandler(this.menuItem_PCard_Click);
			// 
			// Form_PB_BOMRout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 645);
			this.Controls.Add(this.pnl_Body);
			this.Name = "Form_PB_BOMRout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BOM Routing Information";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PB_BOMRout_Closing);
			this.Load += new System.EventHandler(this.Form_PB_BOMRout_Load);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BomNode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BOM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_BomLink)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_RoutType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_BomCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 


		#region 변수 정의 


		private COM.OraDB MyOraDB = new COM.OraDB();

		private int _Rowfixed;

		//노드 수 -> 공정에 링크 그릴때 필요
		private int _Node_Count = 0;

		//새로 그려지는 공정 노드 수
		private int _Op_Count = 0;

		//새로 생기는 링크 순번, 중복 없애기 위함 
		//		private int _Link_Index = 0; 



		#endregion 

		#region 멤버 메서드


		public void Set_Factory(string arg_factory)
		{
			if(this.Visible == true)
			{
				cmb_Factory.SelectedValue = arg_factory; 
			}
		}
 
		public void Set_BomCd(string arg_bomcd)
		{
			if(this.Visible == true)
			{
				cmb_BomCd.SelectedValue = arg_bomcd;
			}
		}

		public void Set_RoutType(string arg_routtype)
		{
			if(this.Visible == true)
			{
				cmb_RoutType.SelectedValue = arg_routtype;
			}
		}

		/// <summary>
		/// Search_Bom_Rout_List : BOM, Routing 데이터(노드, 링크 표시)
		/// </summary>
		public void Search_Bom_Rout_List()
		{

			int i;
			DataTable dt_ret; 
			Lassalle.Flow.Node node;


			_Rowfixed = fgrid_BomNode.Rows.Fixed;

			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
			
			dt_ret = Select_StdBom_List(); 
   
			if(dt_ret.Rows.Count > 0)
			{
				Set_Tree(dt_ret); 
				
				Select_StdBom_Node_List();
				Select_StdBom_Link_List();

//				//Routing 있는것 표시
//				Set_Rout_Yet(); 

				for(i = _Rowfixed; i < fgrid_BOM.Rows.Count; i++)
				{
					foreach(Item item in addflow_BOM.Items)
					{
						if(item is Lassalle.Flow.Node)
						{
							node = (Lassalle.Flow.Node)item; 

							if(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString() == node.Tag.ToString())
							{
								Select_StdRout_Node(node.Tag.ToString(), node); 
								break;
							}
						} 
					}//end foreach 
					
					Select_StdRout_Link(fgrid_BOM[i, (int)ClassLib.TBSPB_BOM.IxCMP_CD].ToString()); 
					

				}
 
			}
			else
			{
				fgrid_BOM.Tree.Column = 1; 
				fgrid_BOM.Rows.Count = _Rowfixed; 
			}

		}



		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			DataTable dt_ret;

			//Title
			this.Text = "Routing of BOM";
			this.lbl_MainTitle.Text = "Routing of BOM";
			

			this.c1ToolBar1.Visible = false;

			if(ClassLib.ComVar.MenuClick_Flag == false)
			{
				this.WindowState = System.Windows.Forms.FormWindowState.Normal; 
				this.Size = new Size((this.MdiParent.Width - 30) / 2, (this.MdiParent.Height - 60));
				this.Location = new Point(this.Width, 0);
				
			}

		
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


			//cmb_Factory.Enabled = false;


			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM); 

			fgrid_BOM.Set_Grid("STANDARD_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			_Rowfixed = fgrid_BOM.Rows.Fixed;
			fgrid_BOM.Set_Action_Image(img_Action); 

			
			//숨겨진 그리드 세팅 
			fgrid_BomNode.Set_Grid("NODE_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_BomLink.Set_Grid("LINK_BOM", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_NodeRout.Set_Grid("NODE_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_LinkRout.Set_Grid("LINK_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);

 
			fgrid_BOM.ExtendLastCol = true;
			fgrid_BOM.Tree.Column = 1;  

			dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 

			if(ClassLib.ComVar.MenuClick_Flag == true)
			{
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			}
 


		}

 
		/// <summary>
		/// Select_StdBom_Node_List : Standard BOM Node 리스트 찾기  
		/// </summary>
		private void Select_StdBom_Node_List()
		{
			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Node node;

			try
			{ 
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_NODELIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomNode.Rows.Count = _Rowfixed; 
				fgrid_BomNode.Cols.Count = dt_ret.Columns.Count + 1; 
				_Node_Count = dt_ret.Rows.Count;

 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomNode.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomNode.Rows.Count, 1); 
				} 


			 
				for(int i = _Rowfixed; i < fgrid_BomNode.Rows.Count; i++)
				{ 
					node = new Lassalle.Flow.Node();

					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxLEFT].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTOP].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxWIDTH].ToString()), 
						Convert.ToSingle(fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxHEIGHT].ToString()), "");

					//node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTEXT].ToString();
					node.Text =  fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();

					node.Tooltip = node.Text;
					node.Tag = fgrid_BomNode[i, (int)ClassLib.TBSPB_NODE_BOM.IxTAG].ToString();  
				
					ClassLib.ComFunction.Set_NodeProp(fgrid_BomNode, node, i); 

					//node.DrawColor = Color.LightGray;
					//node.TextColor = Color.Gray;
					node.Alignment = Alignment.CenterTOP; 
  
				} //end for 
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}  


		}



		/// <summary>
		/// Select_StdBom_Link_List : Standard BOM Link 리스트 찾기 
		/// </summary>
		private void Select_StdBom_Link_List()
		{

			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Link link; 
			int org_index, dst_index;

			try
			{ 
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_LINKLIST";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_BomLink.Rows.Count = _Rowfixed; 
				//			fgrid_BomLink.Cols.Count = dt_ret.Columns.Count + 1; 
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BomLink.AddItem(dt_ret.Rows[i].ItemArray, fgrid_BomLink.Rows.Count, 1); 
				} 


				////////////////////////////////////////////////////////////////
				for(int i = _Rowfixed; i < fgrid_BomLink.Rows.Count; i++)
				{ 
					link = new Lassalle.Flow.Link(); 
	  
					org_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);
					dst_index = ClassLib.ComFunction.Get_Index(fgrid_BomNode, fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_BOM.IxNODE_CD, _Rowfixed);

					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
				
					link.Tag = fgrid_BomLink[i, (int)ClassLib.TBSPB_LINK_BOM.IxTAG].ToString();  

					ClassLib.ComFunction.Set_LinkProp(fgrid_BomLink, link, i);

					//link.DrawColor =  Color.LightGray;

 
				} // end for

				//			_Link_Index = max_index + 1;
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}   
		}
  
	 
 
		/// <summary>
		/// Set_Tree : 그리드에 트리 형태로 데이터 구현
		/// </summary>
		/// <param name="arg_dt">트리로 적용될 데이터테이블</param>
		private void Set_Tree(DataTable arg_dt)
		{
			int i, j;
 
			fgrid_BOM.Tree.Column = 1; 
			fgrid_BOM.Rows.Count = _Rowfixed;
  
			for(i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_BOM.Rows.InsertNode(i + _Rowfixed, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_BOM.IxCMP_LEVEL - 1].ToString()) - 1);

				fgrid_BOM[i + _Rowfixed, 0] = "";

				for(j = 1; j < fgrid_BOM.Cols.Count; j++)
				{
					fgrid_BOM[i + _Rowfixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
				}

				fgrid_BOM.AutoSizeCols();
 
			}
	   

			fgrid_BOM.Tree.Style = TreeStyleFlags.Complete;
			 
		}

	  


		/// <summary>
		/// Select_BomCd_CmbList : BOM Code Combo List 찾기
		/// </summary>
		private DataTable Select_BomCd_CmbList()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_BOM.SELECT_SPB_BOM_CD";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			} 

		}


		/// <summary>
		/// Select_StdBom_List : 표준 BOM 리스트 찾기
		/// </summary>
		private DataTable Select_StdBom_List()
		{ 
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_BOM.SELECT_STDBOM_ROUT";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ROUT";  //"ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_RoutType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			}  

		}


		/// <summary>
		///  Select_StdRout_Node : Standard Routing Node 리스트 찾기  
		/// </summary>
		private void  Select_StdRout_Node(string arg_cmpcd, Lassalle.Flow.Node arg_node)
		{
			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Node node;
			int location_x = 0, location_y = 0;
			int pre_level, my_level;  
			 

			try
			{ 
				string process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_NODE";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
				MyOraDB.Parameter_Values[3] = cmb_RoutType.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_NodeRout.Rows.Count = _Rowfixed;  
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_NodeRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_NodeRout.Rows.Count, 1);
				}  

				///////////////////////////////////////////////////////////
			
				location_x = (int)(arg_node.Location.X + 5);
				location_y = (int)(arg_node.Location.Y + 10); 
				
				for(int i = _Rowfixed; i < fgrid_NodeRout.Rows.Count; i++)
				{ 
					node = new Lassalle.Flow.Node();

					node = addflow_BOM.Nodes.Add(Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxLEFT].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOP].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH].ToString()), 
						Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxHEIGHT].ToString()), "");
				
					node.Text =  fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTEXT].ToString(); 
					node.Tooltip = node.Text;

					//tag = pcardyn (1) + routseq (3) + tag
					//node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString();  
					//node.Tag = arg_node.Tag;

					node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTAG].ToString() 
						+ fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString() 
						+ arg_cmpcd;

					if(node.Tag.ToString().Substring(0, 1) == "Y") node.Text = "*" + node.Text; 
 
				
					if(_Op_Count != 0)
					{
				 
						//					pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));
						//					my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 1));


						pre_level = Convert.ToInt32(fgrid_NodeRout[i - 1, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));
						my_level = Convert.ToInt32(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString().Substring(0, 2));
 
						if(pre_level == my_level)    //같은 레벨이 뒤따라 올때 X 좌표값 증가해서 옆에 표시
						{
							location_x = location_x + (int)node.Size.Width + 5;
						}
						else                         //다른 레벨이 뒤따라 올때 Y 좌표값 증가해서 아래에 표시
						{
							location_y = location_y + (int)node.Size.Height + 30; 
						}
 

					}

					node.Location = new Point(location_x, location_y); 

					ClassLib.ComFunction.Set_NodeProp(fgrid_NodeRout, node, i); 

					//				arg_node.Hidden = true;

					_Op_Count++;
  
				} //end for  
				//--------------------------------------------------------------------------------
 
			}
			catch 
			{  
			}    

		}



		/// <summary>
		/// Select_StdRout_Link : Standard Routing  Link 리스트 찾기 
		/// </summary>
		private void Select_StdRout_Link(string arg_cmpcd)
		{

			DataSet ds_ret; 
			DataTable dt_ret;
			Lassalle.Flow.Link link; 
			int org_index, dst_index; 

			try
			{ 
				string process_name =  "PKG_SPB_ROUT.SELECT_BOMROUT_LINK";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";  
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
				MyOraDB.Parameter_Values[3] = cmb_RoutType.SelectedValue.ToString();  
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return; 
				dt_ret = ds_ret.Tables[process_name];


				//-------------------------------------------------------------------------------- 
				fgrid_LinkRout.Rows.Count = _Rowfixed;  
 
				// Set List
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_LinkRout.AddItem(dt_ret.Rows[i].ItemArray, fgrid_LinkRout.Rows.Count, 1); 
				} 


				////////////////////////////////////////////////////////////////
				for(int i = _Rowfixed; i < fgrid_LinkRout.Rows.Count; i++)
				{ 
					link = new Lassalle.Flow.Link(); 
	  
					org_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
					dst_index = ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed) + _Node_Count;
				
					link = addflow_BOM.Nodes[org_index].OutLinks.Add(addflow_BOM.Nodes[dst_index]);
				
					link.Tag = fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxTAG].ToString(); 
 
					ClassLib.ComFunction.Set_LinkProp(fgrid_LinkRout, link, i);


					//				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 
				
				
				} // end for

				//			_Link_Index = max_index + 1;

			 
				_Node_Count = _Node_Count + _Op_Count;
				_Op_Count = 0;
			
				//--------------------------------------------------------------------------------
 
			}
			catch
			{  
			}    
		  

		}


		/// <summary>
		/// Delete_Cmp_BomRout : 특정 품목내 리스트 삭제 (SPB_ROUT_BOM, SPB_NODE_ROUTBOM, SPB_LINK_ROUTBOM) 
		/// </summary>
		private void Delete_Cmp_BomRout(string arg_cmpcd)
		{  
      
			DataSet ds_ret;

			try
			{
				int col_ct = 4;

				MyOraDB.ReDim_Parameter(col_ct); 
 
				MyOraDB.Process_Name = "PKG_SPB_ROUT.DELETE_SPB_ROUT_BOM";

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";  
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";     
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";   
			    
				for(int i = 0; i < col_ct; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString();   
				MyOraDB.Parameter_Values[2] = arg_cmpcd;   
				MyOraDB.Parameter_Values[3] = cmb_RoutType.SelectedValue.ToString();    


				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
				//Error 처리
				if(ds_ret == null) 
				{
					MessageBox.Show("Error") ;
				
				}
			}
			catch
			{
			}

		}


		#endregion  

		#region 이벤트 처리

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
  			DataTable dt_ret;

			cmb_BomCd.SelectedIndex = -1; 
			cmb_RoutType.SelectedIndex = -1;

			if(cmb_Factory.SelectedIndex == -1) return;

			fgrid_BOM.Rows.Count = _Rowfixed;
			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM); 
 
   			dt_ret = Select_BomCd_CmbList();
   			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BomCd, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code);

			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxRoutType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_RoutType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  

  
		}
		 
  

		private void cmb_BomCd_SelectedValueChanged(object sender, System.EventArgs e)
		{  
			if(cmb_Factory.SelectedIndex == -1 || cmb_BomCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;  

			//BOM, Routing 데이터(노드, 링크 표시)
			Search_Bom_Rout_List();
		}

		private void cmb_RoutType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_BomCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;  

				//BOM, Routing 데이터(노드, 링크 표시)
				Search_Bom_Rout_List();
			}
			catch
			{
			}
		}

		

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_BomCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;  
				//BOM, Routing 데이터(노드, 링크 표시)
				Search_Bom_Rout_List();
			}
			catch
			{
			}
		}

		private void btn_Search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 1;
		}

		private void btn_Search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 0;
		}

		private void btn_Clear_Click(object sender, System.EventArgs e)
		{
//			cmb_Factory.SelectedIndex = -1;
//			cmb_BomCd.SelectedIndex = -1;
//			cmb_RoutType.SelectedIndex = -1;

			fgrid_BOM.Rows.Count = _Rowfixed;
			fgrid_BomNode.Rows.Count = _Rowfixed;
			fgrid_BomLink.Rows.Count = _Rowfixed;
			fgrid_NodeRout.Rows.Count = _Rowfixed;
			fgrid_LinkRout.Rows.Count = _Rowfixed;

			ClassLib.ComFunction.Clear_AddFlow(addflow_BOM);
		}

		private void btn_Clear_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Clear.ImageIndex = 3;
		}

		private void btn_Clear_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Clear.ImageIndex = 2;
		}



		private void menuItem_UpdateRout_Click(object sender, System.EventArgs e)
		{
			string factory, bom_cd, cmp_cd, rout_type;

			try
			{
				factory = cmb_Factory.SelectedValue.ToString();
				bom_cd = cmb_BomCd.SelectedValue.ToString();
				//cmp_cd = addflow_BOM.SelectedItem.Tag.ToString().Substring(4);

				//pcard_yn 필드 가지고 있는 노드는 공정
				if(addflow_BOM.SelectedItem.Tag.ToString().Substring(0, 1) == "Y" 
					|| addflow_BOM.SelectedItem.Tag.ToString().Substring(0, 1) == "N" )
				{
					cmp_cd = addflow_BOM.SelectedItem.Tag.ToString().Substring(4);
				}
				else
				{
					cmp_cd = addflow_BOM.SelectedItem.Tag.ToString();
				}

				rout_type = cmb_RoutType.SelectedValue.ToString();

				ProdBase.Pop_SetBomRoutInfo pop_form = new ProdBase.Pop_SetBomRoutInfo();
 
				//공장, BOM 코드, 품목코드
				ClassLib.ComVar.Parameter_PopUp = new string[] {factory, bom_cd, cmp_cd, rout_type}; 
				pop_form.ShowDialog();

				Search_Bom_Rout_List();
			}
			catch
			{
			}

		}


		private void menuItem_DelRout_Click(object sender, System.EventArgs e)
		{
			DialogResult message_result;
			string cmp_cd = "";

			try
			{
				message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);

				if(message_result == DialogResult.No) return; 

				//pcard_yn 필드 가지고 있는 노드는 공정
				if(addflow_BOM.SelectedItem.Tag.ToString().Substring(0, 1) == "Y" 
					|| addflow_BOM.SelectedItem.Tag.ToString().Substring(0, 1) == "N" )
				{
					cmp_cd = addflow_BOM.SelectedItem.Tag.ToString().Substring(4);
				}
				else
				{
					cmp_cd = addflow_BOM.SelectedItem.Tag.ToString();
				}

				Delete_Cmp_BomRout(cmp_cd);

				Search_Bom_Rout_List(); 
			
			}
			catch
			{
			}
		}
 
		

		private void addflow_BOM_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Item item = addflow_BOM.PointedItem;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();

			//노드일때만 컨텍스트메뉴 실행

			if (item is Lassalle.Flow.Node)
			{
				node = (Lassalle.Flow.Node)item;

				addflow_BOM.ContextMenu = cmenu_Bom; 

				//pcard_yn 필드 가지고 있는 노드는 공정
				if(node.Tag.ToString().Substring(0, 1) == "Y" || node.Tag.ToString().Substring(0, 1) == "N" )
				{
					menuItem_PCard.Visible = true; 
				}
				else
				{
					menuItem_PCard.Visible = false;
				}
			}

			if (item is Lassalle.Flow.Link)
			{
				addflow_BOM.ContextMenu = null; 
			}

		}

		private void menuItem_SetRout_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_BomCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;  
				 
				string factory = cmb_Factory.SelectedValue.ToString();
				string bom_cd = cmb_BomCd.SelectedValue.ToString();
				string cmp_cd = addflow_BOM.SelectedItem.Tag.ToString();
				string rout_type = cmb_RoutType.SelectedValue.ToString();
				Lassalle.Flow.Node node = new Lassalle.Flow.Node();   
	
				int findrow = fgrid_BOM.FindRow(cmp_cd, fgrid_BOM.Rows.Fixed, (int)ClassLib.TBSPB_BOM.IxCMP_CD, false, true, false);
				if(findrow == -1) return; 
				
				if(fgrid_BOM[findrow, (int)ClassLib.TBSPB_BOM.IxROUT_YN].ToString() == "Y")
				{ 
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}
				else
				{ 
					ClassLib.ComVar.FormClick_Flag = true; 

					ProdBase.Pop_PB_Rout pop_form = new ProdBase.Pop_PB_Rout(); 
					ClassLib.ComVar.Parameter_PopUp = new string[] {factory, bom_cd, cmp_cd, rout_type}; 
					pop_form.ShowDialog();

					fgrid_BOM[findrow, (int)ClassLib.TBSPB_BOM.IxROUT_YN] = "Y";
					ClassLib.ComVar.FormClick_Flag = false; 
 
					Search_Bom_Rout_List();

				}
			}
			catch
			{
			}
		}

		private Lassalle.PrnFlow.PrnFlow prnflow = new Lassalle.PrnFlow.PrnFlow();

		private void menuItem_Print_Click(object sender, System.EventArgs e)
		{
			//prnflow.Print(addflow_BOM);

			prnflow.Preview(addflow_BOM);
		}



		#region PassCard Y/N setting

		private void menuItem_PCard_Click(object sender, System.EventArgs e)
		{
			DialogResult message_result;
			bool save_flag = false;

			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_BomCd.SelectedIndex == -1 || cmb_RoutType.SelectedIndex == -1) return;  
				 
				string factory = cmb_Factory.SelectedValue.ToString();
				string bom_cd = cmb_BomCd.SelectedValue.ToString();
				string pcardyn = addflow_BOM.SelectedItem.Tag.ToString().Substring(0,1);
				string rout_seq = addflow_BOM.SelectedItem.Tag.ToString().Substring(1,3);
				string cmp_cd = addflow_BOM.SelectedItem.Tag.ToString().Substring(4);
				string rout_type = cmb_RoutType.SelectedValue.ToString();
				Lassalle.Flow.Node node = new Lassalle.Flow.Node();   
	 
				message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this);

				if(message_result == DialogResult.No) return; 

				if(pcardyn == "Y")
				{ 
					save_flag = Update_PCard_YN(cmp_cd, rout_seq, "N");
				}
				else
				{ 
					save_flag = Update_PCard_YN(cmp_cd, rout_seq, "Y");  
				}

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					Search_Bom_Rout_List();
				}

			}
			catch
			{
			}
		}

	
 
		/// <summary>
		/// Update_PCard_YN : 
		/// </summary>
		/// <param name="arg_cmpcd"></param>
		/// <param name="arg_routtype"></param>
		/// <param name="arg_pcardyn"></param>
		/// <returns></returns>
		private bool Update_PCard_YN(string arg_cmpcd, string arg_routseq, string arg_pcardyn)
		{ 
			try
			{  

				string process_name = "PKG_SPB_ROUT.UPDATE_PCARD_YN";

				MyOraDB.ReDim_Parameter(7); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD"; 
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE"; 
				MyOraDB.Parameter_Name[4] = "ARG_ROUT_SEQ"; 
				MyOraDB.Parameter_Name[5] = "ARG_PCARD_YN"; 
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
			  
				MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_BomCd.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = arg_cmpcd; 
				MyOraDB.Parameter_Values[3] = cmb_RoutType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[4] = arg_routseq; 
				MyOraDB.Parameter_Values[5] = arg_pcardyn; 
				MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;  

				MyOraDB.Add_Modify_Parameter(true); 
				MyOraDB.Exe_Modify_Procedure(); 

				return true;

			}
			catch
			{ 
				return false; 
			} 
		}

		#endregion


		#endregion


		private void Form_PB_BOMRout_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		private void Form_PB_BOMRout_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//종속되어서 열려졌을경우
			if(ClassLib.ComVar.MenuClick_Flag == false)
			{
				e.Cancel = true;
			}
		}






		

	}
}

