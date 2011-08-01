using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexAPS.ProdBase
{
	public class Form_PB_Mold_Last : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.MenuItem menuItem_CreateLine;
		private System.Windows.Forms.ContextMenu cmenu_createline;
		private System.Windows.Forms.MenuItem menuItem_Group;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_LastMaster;
		private C1.Win.C1Command.C1OutPage obarpg_LastInventory;
		public System.Windows.Forms.Panel pnl_LSearchSplitLeft;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LML;
		public System.Windows.Forms.PictureBox picb_LBL;
		public System.Windows.Forms.Panel pnl_DisplayImage;
		public System.Windows.Forms.PictureBox picb_DBM;
		public System.Windows.Forms.PictureBox picb_DMM;
		public System.Windows.Forms.PictureBox picb_DBR;
		public System.Windows.Forms.PictureBox picb_DMR;
		public System.Windows.Forms.PictureBox picb_DTR;
		public System.Windows.Forms.PictureBox picb_DTM;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_DBL;
		public System.Windows.Forms.PictureBox picb_DML;
		private System.Windows.Forms.Panel pnl_B_Master;
		private System.Windows.Forms.Label lbl_Factory_M;
		private System.Windows.Forms.Label lbl_Last_M;
		private System.Windows.Forms.Label lbl_Line_M;
		private System.Windows.Forms.Label lbl_Model_M;
		private C1.Win.C1List.C1Combo cmb_Line_M;
		private System.Windows.Forms.TextBox txt_LastCd_M;
		public C1.Win.C1List.C1Combo cmb_Factory_M;
		private System.Windows.Forms.TextBox txt_ModelCd_M;
		private C1.Win.C1List.C1Combo cmb_Last_M;
		private C1.Win.C1List.C1Combo cmb_Model_M;
		private System.Windows.Forms.Panel pnl_BR_Master;
		private System.Windows.Forms.Label lbl_Factory_MD;
		private System.Windows.Forms.Label lbl_LastCd_MD;
		private System.Windows.Forms.Label lbl_LastName_MD;
		private System.Windows.Forms.Label lbl_Line_MD;
		private System.Windows.Forms.Label lbl_Model_MD;
		private System.Windows.Forms.Label lbl_Gender_MD;
		private System.Windows.Forms.Label lbl_Unit_MD;
		private System.Windows.Forms.Label lbl_Currency_MD;
		private System.Windows.Forms.Label lbl_Cost_MD;
		private System.Windows.Forms.Label lbl_UsCost_MD;
		private System.Windows.Forms.Label lbl_Remarks_MD;
		private System.Windows.Forms.Label lbl_Use_MD;
		private System.Windows.Forms.TextBox txt_Factory_MD;
		private System.Windows.Forms.TextBox txt_LastCd_MD;
		private System.Windows.Forms.TextBox txt_LastName_MD;
		private C1.Win.C1List.C1Combo cmb_Line_MD;
		private System.Windows.Forms.TextBox txt_Model_MD;
		private System.Windows.Forms.TextBox txt_Cost_MD;
		private System.Windows.Forms.TextBox txt_UsCost_MD;
		private System.Windows.Forms.TextBox txt_Remarks_MD;
		private C1.Win.C1List.C1Combo cmb_Gender_MD;
		private C1.Win.C1List.C1Combo cmb_Model_MD;
		private C1.Win.C1List.C1Combo cmb_Unit_MD;
		private C1.Win.C1List.C1Combo cmb_Currency_MD;
		private System.Windows.Forms.CheckBox chk_Use_MD;
		private System.Windows.Forms.Label btn_Apply_MD;
		private System.Windows.Forms.Label btn_Cancel_MD;
		private COM.FSP fgrid_LastMaster;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Form_PB_Mold_Last()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Last));
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.cmenu_createline = new System.Windows.Forms.ContextMenu();
			this.menuItem_CreateLine = new System.Windows.Forms.MenuItem();
			this.menuItem_Group = new System.Windows.Forms.MenuItem();
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.obar_Main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_LastMaster = new C1.Win.C1Command.C1OutPage();
			this.pnl_B_Master = new System.Windows.Forms.Panel();
			this.pnl_LSearchSplitLeft = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.cmb_Model_M = new C1.Win.C1List.C1Combo();
			this.cmb_Last_M = new C1.Win.C1List.C1Combo();
			this.txt_ModelCd_M = new System.Windows.Forms.TextBox();
			this.txt_LastCd_M = new System.Windows.Forms.TextBox();
			this.cmb_Line_M = new C1.Win.C1List.C1Combo();
			this.cmb_Factory_M = new C1.Win.C1List.C1Combo();
			this.lbl_Model_M = new System.Windows.Forms.Label();
			this.lbl_Line_M = new System.Windows.Forms.Label();
			this.lbl_Last_M = new System.Windows.Forms.Label();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.lbl_Factory_M = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			this.pnl_BR_Master = new System.Windows.Forms.Panel();
			this.pnl_DisplayImage = new System.Windows.Forms.Panel();
			this.chk_Use_MD = new System.Windows.Forms.CheckBox();
			this.cmb_Currency_MD = new C1.Win.C1List.C1Combo();
			this.cmb_Unit_MD = new C1.Win.C1List.C1Combo();
			this.cmb_Model_MD = new C1.Win.C1List.C1Combo();
			this.cmb_Gender_MD = new C1.Win.C1List.C1Combo();
			this.cmb_Line_MD = new C1.Win.C1List.C1Combo();
			this.txt_Remarks_MD = new System.Windows.Forms.TextBox();
			this.txt_UsCost_MD = new System.Windows.Forms.TextBox();
			this.txt_Cost_MD = new System.Windows.Forms.TextBox();
			this.txt_Model_MD = new System.Windows.Forms.TextBox();
			this.txt_LastName_MD = new System.Windows.Forms.TextBox();
			this.txt_LastCd_MD = new System.Windows.Forms.TextBox();
			this.txt_Factory_MD = new System.Windows.Forms.TextBox();
			this.lbl_Use_MD = new System.Windows.Forms.Label();
			this.lbl_Remarks_MD = new System.Windows.Forms.Label();
			this.lbl_UsCost_MD = new System.Windows.Forms.Label();
			this.lbl_Cost_MD = new System.Windows.Forms.Label();
			this.lbl_Currency_MD = new System.Windows.Forms.Label();
			this.lbl_Unit_MD = new System.Windows.Forms.Label();
			this.lbl_Gender_MD = new System.Windows.Forms.Label();
			this.lbl_Model_MD = new System.Windows.Forms.Label();
			this.lbl_Line_MD = new System.Windows.Forms.Label();
			this.lbl_LastName_MD = new System.Windows.Forms.Label();
			this.lbl_LastCd_MD = new System.Windows.Forms.Label();
			this.btn_Cancel_MD = new System.Windows.Forms.Label();
			this.btn_Apply_MD = new System.Windows.Forms.Label();
			this.picb_DBM = new System.Windows.Forms.PictureBox();
			this.lbl_Factory_MD = new System.Windows.Forms.Label();
			this.picb_DMM = new System.Windows.Forms.PictureBox();
			this.picb_DBR = new System.Windows.Forms.PictureBox();
			this.picb_DMR = new System.Windows.Forms.PictureBox();
			this.picb_DTR = new System.Windows.Forms.PictureBox();
			this.picb_DTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_DBL = new System.Windows.Forms.PictureBox();
			this.picb_DML = new System.Windows.Forms.PictureBox();
			this.obarpg_LastInventory = new C1.Win.C1Command.C1OutPage();
			this.fgrid_LastMaster = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
			this.obar_Main.SuspendLayout();
			this.obarpg_LastMaster.SuspendLayout();
			this.pnl_B_Master.SuspendLayout();
			this.pnl_LSearchSplitLeft.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model_M)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Last_M)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line_M)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_M)).BeginInit();
			this.pnl_BR_Master.SuspendLayout();
			this.pnl_DisplayImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Currency_MD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Unit_MD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model_MD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gender_MD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line_MD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LastMaster)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// cmenu_createline
			// 
			this.cmenu_createline.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.menuItem_CreateLine,
																							 this.menuItem_Group});
			// 
			// menuItem_CreateLine
			// 
			this.menuItem_CreateLine.Index = 0;
			this.menuItem_CreateLine.Text = "Create MiniLine";
			// 
			// menuItem_Group
			// 
			this.menuItem_Group.Index = 1;
			this.menuItem_Group.Text = "Grouping";
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
			this.c1Sizer1.Controls.Add(this.obar_Main);
			this.c1Sizer1.GridDefinition = "32.4652777777778:False:False;64.7569444444444:False:False;0:False:False;\t0:False:" +
				"False;98.422090729783:False:False;0:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1014, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// obar_Main
			// 
			this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_Main.Controls.Add(this.obarpg_LastMaster);
			this.obar_Main.Controls.Add(this.obarpg_LastInventory);
			this.obar_Main.Location = new System.Drawing.Point(8, 4);
			this.obar_Main.Name = "obar_Main";
			this.obar_Main.Pages.Add(this.obarpg_LastMaster);
			this.obar_Main.Pages.Add(this.obarpg_LastInventory);
			this.obar_Main.Size = new System.Drawing.Size(998, 564);
			this.obar_Main.Text = "c1OutBar1";
			// 
			// obarpg_LastMaster
			// 
			this.obarpg_LastMaster.Controls.Add(this.pnl_B_Master);
			this.obarpg_LastMaster.Location = new System.Drawing.Point(0, 20);
			this.obarpg_LastMaster.Name = "obarpg_LastMaster";
			this.obarpg_LastMaster.Size = new System.Drawing.Size(998, 524);
			this.obarpg_LastMaster.TabIndex = 0;
			this.obarpg_LastMaster.Text = "Last Master";
			// 
			// pnl_B_Master
			// 
			this.pnl_B_Master.Controls.Add(this.fgrid_LastMaster);
			this.pnl_B_Master.Controls.Add(this.pnl_LSearchSplitLeft);
			this.pnl_B_Master.Controls.Add(this.pnl_BR_Master);
			this.pnl_B_Master.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_B_Master.DockPadding.All = 8;
			this.pnl_B_Master.Location = new System.Drawing.Point(0, 0);
			this.pnl_B_Master.Name = "pnl_B_Master";
			this.pnl_B_Master.Size = new System.Drawing.Size(998, 524);
			this.pnl_B_Master.TabIndex = 28;
			// 
			// pnl_LSearchSplitLeft
			// 
			this.pnl_LSearchSplitLeft.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_LSearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_LSearchSplitLeft.DockPadding.Bottom = 5;
			this.pnl_LSearchSplitLeft.Location = new System.Drawing.Point(8, 8);
			this.pnl_LSearchSplitLeft.Name = "pnl_LSearchSplitLeft";
			this.pnl_LSearchSplitLeft.Size = new System.Drawing.Size(645, 90);
			this.pnl_LSearchSplitLeft.TabIndex = 26;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_Model_M);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_Last_M);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ModelCd_M);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LastCd_M);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_Line_M);
			this.pnl_SearchLeftImage.Controls.Add(this.cmb_Factory_M);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Model_M);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Line_M);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Last_M);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Factory_M);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(645, 85);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// cmb_Model_M
			// 
			this.cmb_Model_M.AddItemCols = 0;
			this.cmb_Model_M.AddItemSeparator = ';';
			this.cmb_Model_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Model_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Model_M.Caption = "";
			this.cmb_Model_M.CaptionHeight = 17;
			this.cmb_Model_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Model_M.ColumnCaptionHeight = 18;
			this.cmb_Model_M.ColumnFooterHeight = 18;
			this.cmb_Model_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Model_M.ContentHeight = 17;
			this.cmb_Model_M.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Model_M.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Model_M.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Model_M.EditorHeight = 17;
			this.cmb_Model_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model_M.GapHeight = 2;
			this.cmb_Model_M.ItemHeight = 15;
			this.cmb_Model_M.Location = new System.Drawing.Point(420, 58);
			this.cmb_Model_M.MatchEntryTimeout = ((long)(2000));
			this.cmb_Model_M.MaxDropDownItems = ((short)(5));
			this.cmb_Model_M.MaxLength = 32767;
			this.cmb_Model_M.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Model_M.Name = "cmb_Model_M";
			this.cmb_Model_M.PartialRightColumn = false;
			this.cmb_Model_M.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Model_M.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Model_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Model_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Model_M.Size = new System.Drawing.Size(220, 21);
			this.cmb_Model_M.TabIndex = 208;
			this.cmb_Model_M.SelectedValueChanged += new System.EventHandler(this.cmb_Model_M_SelectedValueChanged);
			// 
			// cmb_Last_M
			// 
			this.cmb_Last_M.AddItemCols = 0;
			this.cmb_Last_M.AddItemSeparator = ';';
			this.cmb_Last_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Last_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Last_M.Caption = "";
			this.cmb_Last_M.CaptionHeight = 17;
			this.cmb_Last_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Last_M.ColumnCaptionHeight = 18;
			this.cmb_Last_M.ColumnFooterHeight = 18;
			this.cmb_Last_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Last_M.ContentHeight = 17;
			this.cmb_Last_M.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Last_M.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Last_M.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Last_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Last_M.EditorHeight = 17;
			this.cmb_Last_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Last_M.GapHeight = 2;
			this.cmb_Last_M.ItemHeight = 15;
			this.cmb_Last_M.Location = new System.Drawing.Point(420, 36);
			this.cmb_Last_M.MatchEntryTimeout = ((long)(2000));
			this.cmb_Last_M.MaxDropDownItems = ((short)(5));
			this.cmb_Last_M.MaxLength = 32767;
			this.cmb_Last_M.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Last_M.Name = "cmb_Last_M";
			this.cmb_Last_M.PartialRightColumn = false;
			this.cmb_Last_M.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Last_M.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Last_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Last_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Last_M.Size = new System.Drawing.Size(220, 21);
			this.cmb_Last_M.TabIndex = 207;
			this.cmb_Last_M.SelectedValueChanged += new System.EventHandler(this.cmb_Last_M_SelectedValueChanged);
			// 
			// txt_ModelCd_M
			// 
			this.txt_ModelCd_M.BackColor = System.Drawing.SystemColors.Window;
			this.txt_ModelCd_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCd_M.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ModelCd_M.Location = new System.Drawing.Point(349, 58);
			this.txt_ModelCd_M.MaxLength = 10;
			this.txt_ModelCd_M.Name = "txt_ModelCd_M";
			this.txt_ModelCd_M.Size = new System.Drawing.Size(70, 21);
			this.txt_ModelCd_M.TabIndex = 206;
			this.txt_ModelCd_M.Text = "";
			this.txt_ModelCd_M.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ModelCd_M_KeyUp);
			// 
			// txt_LastCd_M
			// 
			this.txt_LastCd_M.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LastCd_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastCd_M.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastCd_M.Location = new System.Drawing.Point(349, 36);
			this.txt_LastCd_M.MaxLength = 10;
			this.txt_LastCd_M.Name = "txt_LastCd_M";
			this.txt_LastCd_M.Size = new System.Drawing.Size(70, 21);
			this.txt_LastCd_M.TabIndex = 204;
			this.txt_LastCd_M.Text = "";
			this.txt_LastCd_M.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LastCd_M_KeyUp);
			// 
			// cmb_Line_M
			// 
			this.cmb_Line_M.AddItemCols = 0;
			this.cmb_Line_M.AddItemSeparator = ';';
			this.cmb_Line_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line_M.Caption = "";
			this.cmb_Line_M.CaptionHeight = 17;
			this.cmb_Line_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line_M.ColumnCaptionHeight = 18;
			this.cmb_Line_M.ColumnFooterHeight = 18;
			this.cmb_Line_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line_M.ContentHeight = 17;
			this.cmb_Line_M.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line_M.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line_M.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line_M.EditorHeight = 17;
			this.cmb_Line_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line_M.GapHeight = 2;
			this.cmb_Line_M.ItemHeight = 15;
			this.cmb_Line_M.Location = new System.Drawing.Point(111, 58);
			this.cmb_Line_M.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line_M.MaxDropDownItems = ((short)(5));
			this.cmb_Line_M.MaxLength = 32767;
			this.cmb_Line_M.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line_M.Name = "cmb_Line_M";
			this.cmb_Line_M.PartialRightColumn = false;
			this.cmb_Line_M.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Line_M.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line_M.Size = new System.Drawing.Size(120, 21);
			this.cmb_Line_M.TabIndex = 205;
			this.cmb_Line_M.SelectedValueChanged += new System.EventHandler(this.cmb_Line_M_SelectedValueChanged);
			// 
			// cmb_Factory_M
			// 
			this.cmb_Factory_M.AddItemCols = 0;
			this.cmb_Factory_M.AddItemSeparator = ';';
			this.cmb_Factory_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_M.Caption = "";
			this.cmb_Factory_M.CaptionHeight = 17;
			this.cmb_Factory_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_M.ColumnCaptionHeight = 18;
			this.cmb_Factory_M.ColumnFooterHeight = 18;
			this.cmb_Factory_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_M.ContentHeight = 17;
			this.cmb_Factory_M.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_M.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory_M.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_M.EditorHeight = 17;
			this.cmb_Factory_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_M.GapHeight = 2;
			this.cmb_Factory_M.ItemHeight = 15;
			this.cmb_Factory_M.Location = new System.Drawing.Point(111, 36);
			this.cmb_Factory_M.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_M.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_M.MaxLength = 32767;
			this.cmb_Factory_M.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_M.Name = "cmb_Factory_M";
			this.cmb_Factory_M.PartialRightColumn = false;
			this.cmb_Factory_M.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory_M.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_M.Size = new System.Drawing.Size(120, 21);
			this.cmb_Factory_M.TabIndex = 203;
			this.cmb_Factory_M.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_M_SelectedValueChanged);
			// 
			// lbl_Model_M
			// 
			this.lbl_Model_M.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Model_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model_M.ImageIndex = 0;
			this.lbl_Model_M.ImageList = this.img_Label;
			this.lbl_Model_M.Location = new System.Drawing.Point(248, 58);
			this.lbl_Model_M.Name = "lbl_Model_M";
			this.lbl_Model_M.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model_M.TabIndex = 31;
			this.lbl_Model_M.Text = "Model";
			this.lbl_Model_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line_M
			// 
			this.lbl_Line_M.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line_M.ImageIndex = 0;
			this.lbl_Line_M.ImageList = this.img_Label;
			this.lbl_Line_M.Location = new System.Drawing.Point(10, 58);
			this.lbl_Line_M.Name = "lbl_Line_M";
			this.lbl_Line_M.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line_M.TabIndex = 30;
			this.lbl_Line_M.Text = "Line";
			this.lbl_Line_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Last_M
			// 
			this.lbl_Last_M.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Last_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Last_M.ImageIndex = 0;
			this.lbl_Last_M.ImageList = this.img_Label;
			this.lbl_Last_M.Location = new System.Drawing.Point(248, 36);
			this.lbl_Last_M.Name = "lbl_Last_M";
			this.lbl_Last_M.Size = new System.Drawing.Size(100, 21);
			this.lbl_Last_M.TabIndex = 29;
			this.lbl_Last_M.Text = "Last";
			this.lbl_Last_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(630, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(23, 45);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(629, 69);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(24, 16);
			this.picb_LBR.TabIndex = 23;
			this.picb_LBR.TabStop = false;
			// 
			// lbl_Factory_M
			// 
			this.lbl_Factory_M.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory_M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory_M.ImageIndex = 1;
			this.lbl_Factory_M.ImageList = this.img_Label;
			this.lbl_Factory_M.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory_M.Name = "lbl_Factory_M";
			this.lbl_Factory_M.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_M.TabIndex = 13;
			this.lbl_Factory_M.Text = "Factory";
			this.lbl_Factory_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 67);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(645, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(629, 0);
			this.picb_LTR.Name = "picb_LTR";
			this.picb_LTR.Size = new System.Drawing.Size(24, 32);
			this.picb_LTR.TabIndex = 21;
			this.picb_LTR.TabStop = false;
			// 
			// picb_LTM
			// 
			this.picb_LTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTM.Image")));
			this.picb_LTM.Location = new System.Drawing.Point(224, 0);
			this.picb_LTM.Name = "picb_LTM";
			this.picb_LTM.Size = new System.Drawing.Size(645, 32);
			this.picb_LTM.TabIndex = 0;
			this.picb_LTM.TabStop = false;
			// 
			// picb_LMM
			// 
			this.picb_LMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMM.Image")));
			this.picb_LMM.Location = new System.Drawing.Point(160, 24);
			this.picb_LMM.Name = "picb_LMM";
			this.picb_LMM.Size = new System.Drawing.Size(645, 45);
			this.picb_LMM.TabIndex = 27;
			this.picb_LMM.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Last Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LML
			// 
			this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
			this.picb_LML.Location = new System.Drawing.Point(0, 24);
			this.picb_LML.Name = "picb_LML";
			this.picb_LML.Size = new System.Drawing.Size(168, 45);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 65);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// pnl_BR_Master
			// 
			this.pnl_BR_Master.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BR_Master.Controls.Add(this.pnl_DisplayImage);
			this.pnl_BR_Master.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnl_BR_Master.DockPadding.Left = 3;
			this.pnl_BR_Master.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_BR_Master.Location = new System.Drawing.Point(653, 8);
			this.pnl_BR_Master.Name = "pnl_BR_Master";
			this.pnl_BR_Master.Size = new System.Drawing.Size(337, 508);
			this.pnl_BR_Master.TabIndex = 24;
			// 
			// pnl_DisplayImage
			// 
			this.pnl_DisplayImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_DisplayImage.Controls.Add(this.chk_Use_MD);
			this.pnl_DisplayImage.Controls.Add(this.cmb_Currency_MD);
			this.pnl_DisplayImage.Controls.Add(this.cmb_Unit_MD);
			this.pnl_DisplayImage.Controls.Add(this.cmb_Model_MD);
			this.pnl_DisplayImage.Controls.Add(this.cmb_Gender_MD);
			this.pnl_DisplayImage.Controls.Add(this.cmb_Line_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_Remarks_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_UsCost_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_Cost_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_Model_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_LastName_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_LastCd_MD);
			this.pnl_DisplayImage.Controls.Add(this.txt_Factory_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Use_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Remarks_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_UsCost_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Cost_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Currency_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Unit_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Gender_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Model_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Line_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_LastName_MD);
			this.pnl_DisplayImage.Controls.Add(this.lbl_LastCd_MD);
			this.pnl_DisplayImage.Controls.Add(this.btn_Cancel_MD);
			this.pnl_DisplayImage.Controls.Add(this.btn_Apply_MD);
			this.pnl_DisplayImage.Controls.Add(this.picb_DBM);
			this.pnl_DisplayImage.Controls.Add(this.lbl_Factory_MD);
			this.pnl_DisplayImage.Controls.Add(this.picb_DMM);
			this.pnl_DisplayImage.Controls.Add(this.picb_DBR);
			this.pnl_DisplayImage.Controls.Add(this.picb_DMR);
			this.pnl_DisplayImage.Controls.Add(this.picb_DTR);
			this.pnl_DisplayImage.Controls.Add(this.picb_DTM);
			this.pnl_DisplayImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_DisplayImage.Controls.Add(this.picb_DBL);
			this.pnl_DisplayImage.Controls.Add(this.picb_DML);
			this.pnl_DisplayImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_DisplayImage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_DisplayImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_DisplayImage.Location = new System.Drawing.Point(3, 0);
			this.pnl_DisplayImage.Name = "pnl_DisplayImage";
			this.pnl_DisplayImage.Size = new System.Drawing.Size(334, 508);
			this.pnl_DisplayImage.TabIndex = 24;
			// 
			// chk_Use_MD
			// 
			this.chk_Use_MD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_Use_MD.Location = new System.Drawing.Point(111, 300);
			this.chk_Use_MD.Name = "chk_Use_MD";
			this.chk_Use_MD.Size = new System.Drawing.Size(16, 21);
			this.chk_Use_MD.TabIndex = 223;
			// 
			// cmb_Currency_MD
			// 
			this.cmb_Currency_MD.AddItemCols = 0;
			this.cmb_Currency_MD.AddItemSeparator = ';';
			this.cmb_Currency_MD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Currency_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Currency_MD.Caption = "";
			this.cmb_Currency_MD.CaptionHeight = 17;
			this.cmb_Currency_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Currency_MD.ColumnCaptionHeight = 18;
			this.cmb_Currency_MD.ColumnFooterHeight = 18;
			this.cmb_Currency_MD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Currency_MD.ContentHeight = 17;
			this.cmb_Currency_MD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Currency_MD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Currency_MD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Currency_MD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Currency_MD.EditorHeight = 17;
			this.cmb_Currency_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Currency_MD.GapHeight = 2;
			this.cmb_Currency_MD.ItemHeight = 15;
			this.cmb_Currency_MD.Location = new System.Drawing.Point(111, 212);
			this.cmb_Currency_MD.MatchEntryTimeout = ((long)(2000));
			this.cmb_Currency_MD.MaxDropDownItems = ((short)(5));
			this.cmb_Currency_MD.MaxLength = 32767;
			this.cmb_Currency_MD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Currency_MD.Name = "cmb_Currency_MD";
			this.cmb_Currency_MD.PartialRightColumn = false;
			this.cmb_Currency_MD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Currency_MD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Currency_MD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Currency_MD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Currency_MD.Size = new System.Drawing.Size(217, 21);
			this.cmb_Currency_MD.TabIndex = 222;
			// 
			// cmb_Unit_MD
			// 
			this.cmb_Unit_MD.AddItemCols = 0;
			this.cmb_Unit_MD.AddItemSeparator = ';';
			this.cmb_Unit_MD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Unit_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Unit_MD.Caption = "";
			this.cmb_Unit_MD.CaptionHeight = 17;
			this.cmb_Unit_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Unit_MD.ColumnCaptionHeight = 18;
			this.cmb_Unit_MD.ColumnFooterHeight = 18;
			this.cmb_Unit_MD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Unit_MD.ContentHeight = 17;
			this.cmb_Unit_MD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Unit_MD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Unit_MD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Unit_MD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Unit_MD.EditorHeight = 17;
			this.cmb_Unit_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Unit_MD.GapHeight = 2;
			this.cmb_Unit_MD.ItemHeight = 15;
			this.cmb_Unit_MD.Location = new System.Drawing.Point(111, 190);
			this.cmb_Unit_MD.MatchEntryTimeout = ((long)(2000));
			this.cmb_Unit_MD.MaxDropDownItems = ((short)(5));
			this.cmb_Unit_MD.MaxLength = 32767;
			this.cmb_Unit_MD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Unit_MD.Name = "cmb_Unit_MD";
			this.cmb_Unit_MD.PartialRightColumn = false;
			this.cmb_Unit_MD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Unit_MD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Unit_MD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Unit_MD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Unit_MD.Size = new System.Drawing.Size(217, 21);
			this.cmb_Unit_MD.TabIndex = 221;
			// 
			// cmb_Model_MD
			// 
			this.cmb_Model_MD.AddItemCols = 0;
			this.cmb_Model_MD.AddItemSeparator = ';';
			this.cmb_Model_MD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Model_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Model_MD.Caption = "";
			this.cmb_Model_MD.CaptionHeight = 17;
			this.cmb_Model_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Model_MD.ColumnCaptionHeight = 18;
			this.cmb_Model_MD.ColumnFooterHeight = 18;
			this.cmb_Model_MD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Model_MD.ContentHeight = 17;
			this.cmb_Model_MD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Model_MD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Model_MD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model_MD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Model_MD.EditorHeight = 17;
			this.cmb_Model_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Model_MD.GapHeight = 2;
			this.cmb_Model_MD.ItemHeight = 15;
			this.cmb_Model_MD.Location = new System.Drawing.Point(182, 124);
			this.cmb_Model_MD.MatchEntryTimeout = ((long)(2000));
			this.cmb_Model_MD.MaxDropDownItems = ((short)(5));
			this.cmb_Model_MD.MaxLength = 32767;
			this.cmb_Model_MD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Model_MD.Name = "cmb_Model_MD";
			this.cmb_Model_MD.PartialRightColumn = false;
			this.cmb_Model_MD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Model_MD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Model_MD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Model_MD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Model_MD.Size = new System.Drawing.Size(146, 21);
			this.cmb_Model_MD.TabIndex = 220;
			this.cmb_Model_MD.SelectedValueChanged += new System.EventHandler(this.cmb_Model_MD_SelectedValueChanged);
			// 
			// cmb_Gender_MD
			// 
			this.cmb_Gender_MD.AddItemCols = 0;
			this.cmb_Gender_MD.AddItemSeparator = ';';
			this.cmb_Gender_MD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Gender_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Gender_MD.Caption = "";
			this.cmb_Gender_MD.CaptionHeight = 17;
			this.cmb_Gender_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Gender_MD.ColumnCaptionHeight = 18;
			this.cmb_Gender_MD.ColumnFooterHeight = 18;
			this.cmb_Gender_MD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Gender_MD.ContentHeight = 17;
			this.cmb_Gender_MD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Gender_MD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Gender_MD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Gender_MD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Gender_MD.EditorHeight = 17;
			this.cmb_Gender_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Gender_MD.GapHeight = 2;
			this.cmb_Gender_MD.ItemHeight = 15;
			this.cmb_Gender_MD.Location = new System.Drawing.Point(111, 168);
			this.cmb_Gender_MD.MatchEntryTimeout = ((long)(2000));
			this.cmb_Gender_MD.MaxDropDownItems = ((short)(5));
			this.cmb_Gender_MD.MaxLength = 32767;
			this.cmb_Gender_MD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Gender_MD.Name = "cmb_Gender_MD";
			this.cmb_Gender_MD.PartialRightColumn = false;
			this.cmb_Gender_MD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Gender_MD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Gender_MD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Gender_MD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Gender_MD.Size = new System.Drawing.Size(217, 21);
			this.cmb_Gender_MD.TabIndex = 219;
			// 
			// cmb_Line_MD
			// 
			this.cmb_Line_MD.AddItemCols = 0;
			this.cmb_Line_MD.AddItemSeparator = ';';
			this.cmb_Line_MD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line_MD.Caption = "";
			this.cmb_Line_MD.CaptionHeight = 17;
			this.cmb_Line_MD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line_MD.ColumnCaptionHeight = 18;
			this.cmb_Line_MD.ColumnFooterHeight = 18;
			this.cmb_Line_MD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line_MD.ContentHeight = 17;
			this.cmb_Line_MD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line_MD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line_MD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line_MD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line_MD.EditorHeight = 17;
			this.cmb_Line_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line_MD.GapHeight = 2;
			this.cmb_Line_MD.ItemHeight = 15;
			this.cmb_Line_MD.Location = new System.Drawing.Point(111, 102);
			this.cmb_Line_MD.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line_MD.MaxDropDownItems = ((short)(5));
			this.cmb_Line_MD.MaxLength = 32767;
			this.cmb_Line_MD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line_MD.Name = "cmb_Line_MD";
			this.cmb_Line_MD.PartialRightColumn = false;
			this.cmb_Line_MD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Line_MD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line_MD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line_MD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line_MD.Size = new System.Drawing.Size(217, 21);
			this.cmb_Line_MD.TabIndex = 218;
			// 
			// txt_Remarks_MD
			// 
			this.txt_Remarks_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Remarks_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks_MD.Location = new System.Drawing.Point(111, 278);
			this.txt_Remarks_MD.MaxLength = 10;
			this.txt_Remarks_MD.Name = "txt_Remarks_MD";
			this.txt_Remarks_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_Remarks_MD.TabIndex = 217;
			this.txt_Remarks_MD.Text = "";
			// 
			// txt_UsCost_MD
			// 
			this.txt_UsCost_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_UsCost_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_UsCost_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_UsCost_MD.Location = new System.Drawing.Point(111, 256);
			this.txt_UsCost_MD.MaxLength = 10;
			this.txt_UsCost_MD.Name = "txt_UsCost_MD";
			this.txt_UsCost_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_UsCost_MD.TabIndex = 216;
			this.txt_UsCost_MD.Text = "";
			// 
			// txt_Cost_MD
			// 
			this.txt_Cost_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Cost_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Cost_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Cost_MD.Location = new System.Drawing.Point(111, 234);
			this.txt_Cost_MD.MaxLength = 10;
			this.txt_Cost_MD.Name = "txt_Cost_MD";
			this.txt_Cost_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_Cost_MD.TabIndex = 215;
			this.txt_Cost_MD.Text = "";
			// 
			// txt_Model_MD
			// 
			this.txt_Model_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Model_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model_MD.Location = new System.Drawing.Point(111, 124);
			this.txt_Model_MD.MaxLength = 10;
			this.txt_Model_MD.Name = "txt_Model_MD";
			this.txt_Model_MD.Size = new System.Drawing.Size(70, 21);
			this.txt_Model_MD.TabIndex = 214;
			this.txt_Model_MD.Text = "";
			this.txt_Model_MD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Model_MD_KeyUp);
			// 
			// txt_LastName_MD
			// 
			this.txt_LastName_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LastName_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastName_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastName_MD.Location = new System.Drawing.Point(111, 80);
			this.txt_LastName_MD.MaxLength = 10;
			this.txt_LastName_MD.Name = "txt_LastName_MD";
			this.txt_LastName_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_LastName_MD.TabIndex = 213;
			this.txt_LastName_MD.Text = "";
			// 
			// txt_LastCd_MD
			// 
			this.txt_LastCd_MD.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LastCd_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastCd_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastCd_MD.Location = new System.Drawing.Point(111, 58);
			this.txt_LastCd_MD.MaxLength = 10;
			this.txt_LastCd_MD.Name = "txt_LastCd_MD";
			this.txt_LastCd_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_LastCd_MD.TabIndex = 212;
			this.txt_LastCd_MD.Text = "";
			// 
			// txt_Factory_MD
			// 
			this.txt_Factory_MD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory_MD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory_MD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory_MD.Location = new System.Drawing.Point(111, 36);
			this.txt_Factory_MD.MaxLength = 10;
			this.txt_Factory_MD.Name = "txt_Factory_MD";
			this.txt_Factory_MD.ReadOnly = true;
			this.txt_Factory_MD.Size = new System.Drawing.Size(217, 21);
			this.txt_Factory_MD.TabIndex = 211;
			this.txt_Factory_MD.Text = "";
			// 
			// lbl_Use_MD
			// 
			this.lbl_Use_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Use_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Use_MD.ImageIndex = 0;
			this.lbl_Use_MD.ImageList = this.img_Label;
			this.lbl_Use_MD.Location = new System.Drawing.Point(10, 300);
			this.lbl_Use_MD.Name = "lbl_Use_MD";
			this.lbl_Use_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Use_MD.TabIndex = 210;
			this.lbl_Use_MD.Text = "Use";
			this.lbl_Use_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Remarks_MD
			// 
			this.lbl_Remarks_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Remarks_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Remarks_MD.ImageIndex = 0;
			this.lbl_Remarks_MD.ImageList = this.img_Label;
			this.lbl_Remarks_MD.Location = new System.Drawing.Point(10, 278);
			this.lbl_Remarks_MD.Name = "lbl_Remarks_MD";
			this.lbl_Remarks_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Remarks_MD.TabIndex = 209;
			this.lbl_Remarks_MD.Text = "Remarks";
			this.lbl_Remarks_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_UsCost_MD
			// 
			this.lbl_UsCost_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_UsCost_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_UsCost_MD.ImageIndex = 0;
			this.lbl_UsCost_MD.ImageList = this.img_Label;
			this.lbl_UsCost_MD.Location = new System.Drawing.Point(10, 256);
			this.lbl_UsCost_MD.Name = "lbl_UsCost_MD";
			this.lbl_UsCost_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_UsCost_MD.TabIndex = 208;
			this.lbl_UsCost_MD.Text = "Cost (Dollor)";
			this.lbl_UsCost_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Cost_MD
			// 
			this.lbl_Cost_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Cost_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Cost_MD.ImageIndex = 0;
			this.lbl_Cost_MD.ImageList = this.img_Label;
			this.lbl_Cost_MD.Location = new System.Drawing.Point(10, 234);
			this.lbl_Cost_MD.Name = "lbl_Cost_MD";
			this.lbl_Cost_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Cost_MD.TabIndex = 207;
			this.lbl_Cost_MD.Text = "Cost";
			this.lbl_Cost_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Currency_MD
			// 
			this.lbl_Currency_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Currency_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Currency_MD.ImageIndex = 0;
			this.lbl_Currency_MD.ImageList = this.img_Label;
			this.lbl_Currency_MD.Location = new System.Drawing.Point(10, 212);
			this.lbl_Currency_MD.Name = "lbl_Currency_MD";
			this.lbl_Currency_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Currency_MD.TabIndex = 206;
			this.lbl_Currency_MD.Text = "Currency";
			this.lbl_Currency_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Unit_MD
			// 
			this.lbl_Unit_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Unit_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Unit_MD.ImageIndex = 0;
			this.lbl_Unit_MD.ImageList = this.img_Label;
			this.lbl_Unit_MD.Location = new System.Drawing.Point(10, 190);
			this.lbl_Unit_MD.Name = "lbl_Unit_MD";
			this.lbl_Unit_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Unit_MD.TabIndex = 205;
			this.lbl_Unit_MD.Text = "Unit";
			this.lbl_Unit_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Gender_MD
			// 
			this.lbl_Gender_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Gender_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Gender_MD.ImageIndex = 0;
			this.lbl_Gender_MD.ImageList = this.img_Label;
			this.lbl_Gender_MD.Location = new System.Drawing.Point(10, 168);
			this.lbl_Gender_MD.Name = "lbl_Gender_MD";
			this.lbl_Gender_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender_MD.TabIndex = 204;
			this.lbl_Gender_MD.Text = "Gender";
			this.lbl_Gender_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Model_MD
			// 
			this.lbl_Model_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Model_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Model_MD.ImageIndex = 1;
			this.lbl_Model_MD.ImageList = this.img_Label;
			this.lbl_Model_MD.Location = new System.Drawing.Point(10, 124);
			this.lbl_Model_MD.Name = "lbl_Model_MD";
			this.lbl_Model_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model_MD.TabIndex = 203;
			this.lbl_Model_MD.Text = "Model";
			this.lbl_Model_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Line_MD
			// 
			this.lbl_Line_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Line_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Line_MD.ImageIndex = 1;
			this.lbl_Line_MD.ImageList = this.img_Label;
			this.lbl_Line_MD.Location = new System.Drawing.Point(10, 102);
			this.lbl_Line_MD.Name = "lbl_Line_MD";
			this.lbl_Line_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line_MD.TabIndex = 202;
			this.lbl_Line_MD.Text = "Line";
			this.lbl_Line_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LastName_MD
			// 
			this.lbl_LastName_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_LastName_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LastName_MD.ImageIndex = 1;
			this.lbl_LastName_MD.ImageList = this.img_Label;
			this.lbl_LastName_MD.Location = new System.Drawing.Point(10, 80);
			this.lbl_LastName_MD.Name = "lbl_LastName_MD";
			this.lbl_LastName_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_LastName_MD.TabIndex = 201;
			this.lbl_LastName_MD.Text = "Last Name";
			this.lbl_LastName_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LastCd_MD
			// 
			this.lbl_LastCd_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_LastCd_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LastCd_MD.ImageIndex = 1;
			this.lbl_LastCd_MD.ImageList = this.img_Label;
			this.lbl_LastCd_MD.Location = new System.Drawing.Point(10, 58);
			this.lbl_LastCd_MD.Name = "lbl_LastCd_MD";
			this.lbl_LastCd_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_LastCd_MD.TabIndex = 200;
			this.lbl_LastCd_MD.Text = "Last Code";
			this.lbl_LastCd_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Cancel_MD
			// 
			this.btn_Cancel_MD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel_MD.ImageIndex = 0;
			this.btn_Cancel_MD.ImageList = this.img_Button;
			this.btn_Cancel_MD.Location = new System.Drawing.Point(247, 476);
			this.btn_Cancel_MD.Name = "btn_Cancel_MD";
			this.btn_Cancel_MD.Size = new System.Drawing.Size(80, 24);
			this.btn_Cancel_MD.TabIndex = 199;
			this.btn_Cancel_MD.Text = "Cancel";
			this.btn_Cancel_MD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel_MD.Click += new System.EventHandler(this.btn_Cancel_MD_Click);
			this.btn_Cancel_MD.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel_MD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel_MD.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel_MD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Apply_MD
			// 
			this.btn_Apply_MD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply_MD.ImageIndex = 0;
			this.btn_Apply_MD.ImageList = this.img_Button;
			this.btn_Apply_MD.Location = new System.Drawing.Point(166, 476);
			this.btn_Apply_MD.Name = "btn_Apply_MD";
			this.btn_Apply_MD.Size = new System.Drawing.Size(80, 24);
			this.btn_Apply_MD.TabIndex = 198;
			this.btn_Apply_MD.Text = "Apply";
			this.btn_Apply_MD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply_MD.Click += new System.EventHandler(this.btn_Apply_MD_Click);
			this.btn_Apply_MD.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply_MD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply_MD.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply_MD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// picb_DBM
			// 
			this.picb_DBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBM.Image")));
			this.picb_DBM.Location = new System.Drawing.Point(144, 489);
			this.picb_DBM.Name = "picb_DBM";
			this.picb_DBM.Size = new System.Drawing.Size(182, 27);
			this.picb_DBM.TabIndex = 24;
			this.picb_DBM.TabStop = false;
			// 
			// lbl_Factory_MD
			// 
			this.lbl_Factory_MD.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory_MD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory_MD.ImageIndex = 1;
			this.lbl_Factory_MD.ImageList = this.img_Label;
			this.lbl_Factory_MD.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory_MD.Name = "lbl_Factory_MD";
			this.lbl_Factory_MD.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_MD.TabIndex = 14;
			this.lbl_Factory_MD.Text = "Factory";
			this.lbl_Factory_MD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DMM
			// 
			this.picb_DMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMM.Image")));
			this.picb_DMM.Location = new System.Drawing.Point(152, 32);
			this.picb_DMM.Name = "picb_DMM";
			this.picb_DMM.Size = new System.Drawing.Size(174, 508);
			this.picb_DMM.TabIndex = 27;
			this.picb_DMM.TabStop = false;
			// 
			// picb_DBR
			// 
			this.picb_DBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBR.Image")));
			this.picb_DBR.Location = new System.Drawing.Point(318, 491);
			this.picb_DBR.Name = "picb_DBR";
			this.picb_DBR.Size = new System.Drawing.Size(16, 25);
			this.picb_DBR.TabIndex = 23;
			this.picb_DBR.TabStop = false;
			// 
			// picb_DMR
			// 
			this.picb_DMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMR.Image")));
			this.picb_DMR.Location = new System.Drawing.Point(319, 25);
			this.picb_DMR.Name = "picb_DMR";
			this.picb_DMR.Size = new System.Drawing.Size(15, 508);
			this.picb_DMR.TabIndex = 26;
			this.picb_DMR.TabStop = false;
			// 
			// picb_DTR
			// 
			this.picb_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTR.Image")));
			this.picb_DTR.Location = new System.Drawing.Point(318, 0);
			this.picb_DTR.Name = "picb_DTR";
			this.picb_DTR.Size = new System.Drawing.Size(16, 32);
			this.picb_DTR.TabIndex = 21;
			this.picb_DTR.TabStop = false;
			// 
			// picb_DTM
			// 
			this.picb_DTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTM.Image")));
			this.picb_DTM.Location = new System.Drawing.Point(224, 0);
			this.picb_DTM.Name = "picb_DTM";
			this.picb_DTM.Size = new System.Drawing.Size(104, 39);
			this.picb_DTM.TabIndex = 0;
			this.picb_DTM.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Display Last Information";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DBL
			// 
			this.picb_DBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBL.Image")));
			this.picb_DBL.Location = new System.Drawing.Point(0, 487);
			this.picb_DBL.Name = "picb_DBL";
			this.picb_DBL.Size = new System.Drawing.Size(168, 29);
			this.picb_DBL.TabIndex = 22;
			this.picb_DBL.TabStop = false;
			// 
			// picb_DML
			// 
			this.picb_DML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DML.Image = ((System.Drawing.Image)(resources.GetObject("picb_DML.Image")));
			this.picb_DML.Location = new System.Drawing.Point(0, 24);
			this.picb_DML.Name = "picb_DML";
			this.picb_DML.Size = new System.Drawing.Size(168, 508);
			this.picb_DML.TabIndex = 25;
			this.picb_DML.TabStop = false;
			// 
			// obarpg_LastInventory
			// 
			this.obarpg_LastInventory.Location = new System.Drawing.Point(0, 0);
			this.obarpg_LastInventory.Name = "obarpg_LastInventory";
			this.obarpg_LastInventory.Size = new System.Drawing.Size(0, 0);
			this.obarpg_LastInventory.TabIndex = 1;
			this.obarpg_LastInventory.Text = "Last Inventory";
			this.obarpg_LastInventory.Visible = false;
			// 
			// fgrid_LastMaster
			// 
			this.fgrid_LastMaster.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LastMaster.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_LastMaster.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_LastMaster.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LastMaster.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LastMaster.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_LastMaster.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_LastMaster.Location = new System.Drawing.Point(8, 98);
			this.fgrid_LastMaster.Name = "fgrid_LastMaster";
			this.fgrid_LastMaster.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LastMaster.Size = new System.Drawing.Size(645, 418);
			this.fgrid_LastMaster.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LastMaster.TabIndex = 44;
			this.fgrid_LastMaster.Click += new System.EventHandler(this.fgrid_LastMaster_Click);
			this.fgrid_LastMaster.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LastMaster_BeforeEdit);
			this.fgrid_LastMaster.DoubleClick += new System.EventHandler(this.fgrid_LastMaster_DoubleClick);
			this.fgrid_LastMaster.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LastMaster_AfterEdit);
			// 
			// Form_PB_Mold_Last
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_PB_Mold_Last";
			this.Text = "Last Register";
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
			this.obar_Main.ResumeLayout(false);
			this.obarpg_LastMaster.ResumeLayout(false);
			this.pnl_B_Master.ResumeLayout(false);
			this.pnl_LSearchSplitLeft.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model_M)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Last_M)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line_M)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_M)).EndInit();
			this.pnl_BR_Master.ResumeLayout(false);
			this.pnl_DisplayImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Currency_MD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Unit_MD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Model_MD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gender_MD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line_MD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LastMaster)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의


		private COM.OraDB MyOraDB = new COM.OraDB(); 


		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			try
			{
 			
				// Title 
				this.Text = "Last Register";
				this.lbl_MainTitle.Text = "Last Register"; 
  
				
				fgrid_LastMaster.Set_Grid("SPB_MOLD_LAST", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
				fgrid_LastMaster.Set_Action_Image(img_Action); 
			
 

				//Set Combo List
				Init_Control(); 
				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			 
		}



		/// <summary>
		/// 
		/// </summary>
		private void Init_Control()
		{

		 
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false;

			obar_Main.SelectedPage = obarpg_LastMaster;


			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_M, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			cmb_Factory_M.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_ret.Dispose();
			


		} 
		
 


		#endregion 

		#region 조회


	 

		#endregion 

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_LastMaster":

					cmb_Factory_M.SelectedValue = ClassLib.ComVar.This_Factory;
					txt_LastCd_M.Text = "";
					cmb_Last_M.SelectedIndex = -1;
					cmb_Line_M.Text = "";
					txt_ModelCd_M.Text = "";
					cmb_Model_M.SelectedIndex = -1;

					txt_Factory_MD.Text = cmb_Factory_M.SelectedValue.ToString();
					txt_LastCd_MD.Text = "";
					txt_LastName_MD.Text = "";
					cmb_Line_MD.SelectedIndex = -1;
					txt_Model_MD.Text = "";
					cmb_Model_MD.SelectedIndex = -1;
				
					cmb_Gender_MD.SelectedIndex = -1;
					cmb_Unit_MD.SelectedIndex = -1;
					cmb_Currency_MD.SelectedIndex = -1;
					txt_Cost_MD.Text = "";
					txt_UsCost_MD.Text = "";
					txt_Remarks_MD.Text = "";
					chk_Use_MD.Checked = true;

					fgrid_LastMaster.Rows.Count = fgrid_LastMaster.Rows.Fixed;

					break;


				case "obarpg_LastInventory":

					break;


			}



		} 


		private void Event_Tbtn_Search()
		{

			Event_Click_btn_Cancel();


			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_LastMaster":
 

					if(cmb_Factory_M.SelectedIndex == -1) return;


					string factory_m = cmb_Factory_M.SelectedValue.ToString();
					string last_cd_m = ClassLib.ComFunction.Empty_Combo(cmb_Last_M, " ");
					string line_cd_m = ClassLib.ComFunction.Empty_Combo(cmb_Line_M, " ");
					string model_cd_m = ClassLib.ComFunction.Empty_Combo(cmb_Model_M, " ");


					DataTable dt_ret = Select_SPB_MOLD_LAST(factory_m, last_cd_m, line_cd_m, model_cd_m);
					fgrid_LastMaster.Display_Grid(dt_ret, true);
					

					break;


				case "obarpg_LastInventory":

					break; 

			}

		}


		private void Event_Tbtn_Save()
		{

			bool save_flag = false;


			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_LastMaster":
 
					//행 수정 상태 해제
					fgrid_LastMaster.Select(fgrid_LastMaster.Selection.r1, 0, fgrid_LastMaster.Selection.r1, fgrid_LastMaster.Cols.Count-1, false);
 
					save_flag = MyOraDB.Save_FlexGird("PKG_SPB_MOLD_LAST_BSC.SAVE_SPB_MOLD_LAST", fgrid_LastMaster); 

					if(! save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 
						Event_Tbtn_Search();
					}


					break;


				case "obarpg_LastInventory":

					break; 

			}

		}


		private void Event_Tbtn_Delete()
		{

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_LastMaster":
 
					fgrid_LastMaster.Delete_Row();

					break;


				case "obarpg_LastInventory":

					break; 

			}

		}

 

		#endregion

		#region 그리드 이벤트 메서드

 

		#endregion

		#region 버튼 및 기타 이벤트 메서드
 

		/// <summary>
		/// Event_Click_btn_Cancel : 
		/// </summary>
		private void Event_Click_btn_Cancel()
		{

			txt_Factory_MD.Text = cmb_Factory_M.SelectedValue.ToString();
			txt_LastCd_MD.Text = "";
			txt_LastName_MD.Text = "";
			cmb_Line_MD.SelectedIndex = -1;
			txt_Model_MD.Text = "";
			cmb_Model_MD.SelectedIndex = -1;
				
			cmb_Gender_MD.SelectedIndex = -1;
			cmb_Unit_MD.SelectedIndex = -1;
			cmb_Currency_MD.SelectedIndex = -1;
			txt_Cost_MD.Text = "";
			txt_UsCost_MD.Text = "";
			txt_Remarks_MD.Text = "";
			chk_Use_MD.Checked = true;

		}


		/// <summary>
		/// Event_Click_btn_Apply : 
		/// </summary>
		private void Event_Click_btn_Apply()
		{

			// 1. essential check
			if(txt_Factory_MD.Text.Trim().Equals("") )
			{
				ClassLib.ComFunction.User_Message("You must input factory.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if(txt_LastCd_MD.Text.Trim().Equals("") )
			{
				ClassLib.ComFunction.User_Message("You must input last code.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if(txt_LastName_MD.Text.Trim().Equals("") )
			{
				ClassLib.ComFunction.User_Message("You must input last name.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if(cmb_Line_MD.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("You must input line.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if(cmb_Model_MD.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("You must input model.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}


			if(! ClassLib.ComFunction.Set_NumberTextBox(txt_Cost_MD, 18, "return_type") )
			{
				return;
			}
			
			if(! ClassLib.ComFunction.Set_NumberTextBox(txt_UsCost_MD, 18, "return_type") )
			{
				return;
			}

			// 2. 중복 체크
			// 2.1) DB 체크
			// 2.2) 그리드 I 상태 데이터 체크
			string factory = txt_Factory_MD.Text.Trim();
			string last_cd = txt_LastCd_MD.Text.Trim();
			string line_cd = cmb_Line_MD.SelectedValue.ToString();
			string model_cd = cmb_Model_MD.SelectedValue.ToString();

			bool exist_flag = Check_DUPLICATE_LAST(factory, last_cd, line_cd, model_cd);

			if(exist_flag)  // DB 중복일 경우
			{
				ClassLib.ComFunction.User_Message("Duplicate last data.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else // DB 중복 아닐 경우
			{

				int first_insert_row = fgrid_LastMaster.FindRow("I", fgrid_LastMaster.Rows.Fixed, 0, false, true, false);

				if(first_insert_row != -1) 
				{
				
					string now_item = "";
					string new_item = "";

					new_item = txt_Factory_MD.Text.Trim()
						+ txt_LastCd_MD.Text.Trim()
						+ cmb_Line_MD.SelectedValue.ToString()
						+ cmb_Model_MD.SelectedValue.ToString();


					for(int i = fgrid_LastMaster.Rows.Count - 1; i >= first_insert_row; i--)
					{
						now_item = fgrid_LastMaster[i, (int)ClassLib.TBSPB_MOLD_LAST.IxFACTORY].ToString()
							+ fgrid_LastMaster[i, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_CD].ToString()
							+ fgrid_LastMaster[i, (int)ClassLib.TBSPB_MOLD_LAST.IxLINE_CD].ToString()
							+ fgrid_LastMaster[i, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_CD].ToString();


						if(new_item == now_item)
						{
							ClassLib.ComFunction.User_Message("Duplicate last data.", "Apply Grid", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
						}

					} // end for i

				} // end if(first_insert_row != -1) 

			} // end if(exist_flag)



			// 3. 그리드 컬럼 데이터 적용, I 표시
			fgrid_LastMaster.Add_Row(fgrid_LastMaster.Rows.Count - 1);
			
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxFACTORY] = txt_Factory_MD.Text.Trim();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_CD] = txt_LastCd_MD.Text.Trim();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_NAME] = txt_LastName_MD.Text.Trim();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxLINE_CD] = cmb_Line_MD.SelectedValue.ToString();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_CD] = cmb_Model_MD.SelectedValue.ToString();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_NAME] = cmb_Model_MD.Columns[1].Text;
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxGEN] = ClassLib.ComFunction.Empty_Combo(cmb_Gender_MD, "");
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxUNIT] = ClassLib.ComFunction.Empty_Combo(cmb_Unit_MD, "");
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxCOINAGE] = ClassLib.ComFunction.Empty_Combo(cmb_Currency_MD, "");
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxCOST] = ClassLib.ComFunction.Empty_Number(txt_Cost_MD.Text.Trim(), "0");
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxUS_COST] = ClassLib.ComFunction.Empty_Number(txt_UsCost_MD.Text.Trim(), "0");
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxREMARKS] = txt_Remarks_MD.Text.Trim();
			fgrid_LastMaster[fgrid_LastMaster.Rows.Count - 1, (int)ClassLib.TBSPB_MOLD_LAST.IxUSE_YN] = (chk_Use_MD.Checked) ? "TRUE" : "FALSE"; 

			fgrid_LastMaster.AutoSizeCols();



		}


		#endregion
 
		#region 컨텍스트 메뉴 이벤트

 

		#endregion

		#endregion 

		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Event_Tbtn_Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		} 

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				Event_Tbtn_Delete(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  

		}

 

		#endregion

		#region 그리드 이벤트
		 
		
		private void fgrid_LastMaster_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			try
			{

				if ((fgrid_LastMaster.Rows.Fixed > 0) && (fgrid_LastMaster.Row >= fgrid_LastMaster.Rows.Fixed))
				{
					if(fgrid_LastMaster.Cols[fgrid_LastMaster.Col].DataType == typeof(bool))
					{
						fgrid_LastMaster.Buffer_CellData = "";
					}
					else
					{
						fgrid_LastMaster.Buffer_CellData = (fgrid_LastMaster[fgrid_LastMaster.Row, fgrid_LastMaster.Col] == null) ? "" : fgrid_LastMaster[fgrid_LastMaster.Row, fgrid_LastMaster.Col].ToString();
					}
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_LastMaster_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		
		}

		private void fgrid_LastMaster_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{ 
				fgrid_LastMaster.Update_Row(fgrid_LastMaster.Selection.r1);	
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_LastMaster_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		
		private void fgrid_LastMaster_Click(object sender, System.EventArgs e)
		{

			try
			{

		
				// clear
				Event_Click_btn_Cancel();

				if(fgrid_LastMaster.Rows.Count <= fgrid_LastMaster.Rows.Fixed) return;

				txt_Factory_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxFACTORY].ToString();
				txt_LastCd_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_CD].ToString();
				txt_LastName_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_NAME].ToString();
				cmb_Line_MD.SelectedValue = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLINE_CD].ToString(); 

			
				//cmb_Model_MD.SelectedValue = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_CD].ToString();
				txt_Model_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_CD].ToString();
				string model_cd = txt_Model_MD.Text.Trim();

				DataTable dt_ret = Select_SDC_MODEL_COMBO(model_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model_MD, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);  
				
				cmb_Model_MD.SelectedValue = txt_Model_MD.Text.Trim(); 



			
				cmb_Gender_MD.SelectedValue = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxGEN].ToString();
				cmb_Unit_MD.SelectedValue = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxUNIT].ToString();
				cmb_Currency_MD.SelectedValue = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxCOINAGE].ToString();

				txt_Cost_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxCOST].ToString();
				txt_UsCost_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxUS_COST].ToString();
				txt_Remarks_MD.Text = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxREMARKS].ToString();

				chk_Use_MD.Checked = Convert.ToBoolean( fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxUSE_YN].ToString() );


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_LastMaster_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}
 

		private void fgrid_LastMaster_DoubleClick(object sender, System.EventArgs e)
		{ 
 
			try
			{
				
				if(fgrid_LastMaster.Rows.Count <= fgrid_LastMaster.Rows.Fixed) return;

				string factory = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxFACTORY].ToString();
				string last_cd = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_CD].ToString();
				string last_name = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLAST_NAME].ToString();
				string gender = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxGEN].ToString(); 
				string line_cd = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxLINE_CD].ToString(); 
				string line_name = "";
				string model_cd = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_CD].ToString(); 
				string model_name = fgrid_LastMaster[fgrid_LastMaster.Selection.r1, (int)ClassLib.TBSPB_MOLD_LAST.IxMODEL_NAME].ToString();


				string[] pop_parameter = new string[] { factory, last_cd, last_name, gender, line_cd, line_name, model_cd, model_name };


				FlexAPS.ProdBase.Pop_MoldLast_Inventory pop_form = new FlexAPS.ProdBase.Pop_MoldLast_Inventory(pop_parameter);
				pop_form.ShowDialog();


				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_LastMaster_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

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

		private void cmb_Factory_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory_M.SelectedIndex == -1) return;

				// 초기화
				Event_Click_btn_Cancel(); 
 


				// line
				string factory = cmb_Factory_M.SelectedValue.ToString();
				DataTable dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE(factory);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line_M, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line_MD, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 

				// gender
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGen);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Gender_MD, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 

				// unit
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxPurUnit);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Unit_MD, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name); 

				// currency
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Currency_MD, 1, 2, false, COM.ComVar.ComboList_Visible.Name); 



				dt_ret.Dispose(); 


				//Event_Tbtn_Search();
				 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_LastCd_M_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			try
			{
 
 
				if(e.KeyCode != Keys.Enter) return;

				string factory = cmb_Factory_M.SelectedValue.ToString();
				string last_cd = txt_LastCd_M.Text.Trim();

				DataTable dt_ret = Select_SPB_MOLD_LAST_COMBO(factory, last_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Last_M, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);  
				
				cmb_Last_M.SelectedValue = txt_LastCd_M.Text.Trim(); 


				dt_ret.Dispose(); 
				 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_LastCd_M_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_Last_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{

				if(cmb_Last_M.SelectedIndex == -1) return;

				txt_LastCd_M.Text = cmb_Last_M.SelectedValue.ToString(); 


				Event_Tbtn_Search();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Last_M_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
			
		}

		private void cmb_Line_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
		 
			Event_Tbtn_Search(); 

		}

		private void txt_ModelCd_M_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			try
			{
  
				if(e.KeyCode != Keys.Enter) return;

				string model_cd = txt_ModelCd_M.Text.Trim();

				DataTable dt_ret = Select_SDC_MODEL_COMBO(model_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model_M, 0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);  
				
				cmb_Model_M.SelectedValue = txt_ModelCd_M.Text.Trim(); 


				dt_ret.Dispose(); 
				 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_ModelCd_M_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}

		private void cmb_Model_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Model_M.SelectedIndex == -1) return;

				txt_ModelCd_M.Text = cmb_Model_M.SelectedValue.ToString(); 

				Event_Tbtn_Search();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Model_M_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			

		}

		private void txt_Model_MD_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			try
			{
  
				if(e.KeyCode != Keys.Enter) return;

				string model_cd = txt_Model_MD.Text.Trim();

				DataTable dt_ret = Select_SDC_MODEL_COMBO(model_cd);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Model_MD, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);  
				
				cmb_Model_MD.SelectedValue = txt_Model_MD.Text.Trim(); 


				dt_ret.Dispose(); 
				 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Model_MD_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void cmb_Model_MD_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{

				if(cmb_Model_MD.SelectedIndex == -1) return;

				txt_Model_MD.Text = cmb_Model_MD.SelectedValue.ToString(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Model_MD_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
		}
		
		private void btn_Apply_MD_Click(object sender, System.EventArgs e)
		{
		
			try
			{
  
				Event_Click_btn_Apply();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_MD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Cancel_MD_Click(object sender, System.EventArgs e)
		{


			try
			{

				Event_Click_btn_Cancel();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_MD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		
		}
 


		#endregion  

		#region 컨텍스트 메뉴 이벤트


		 

		#endregion 

		#endregion 

		#region 디비 연결


		#region 콤보


		/// <summary>
		/// Select_SPB_MOLD_LAST_COMBO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_last_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_MOLD_LAST_COMBO(string arg_factory, string arg_last_cd)
		{

			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPB_MOLD_LAST_BSC.SELECT_SPB_MOLD_LAST_COMBO";

				MyOraDB.ReDim_Parameter(3); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LAST_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_last_cd; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}

  
		/// <summary>
		/// Select_SDC_MODEL_COMBO : 
		/// </summary>
		/// <param name="arg_model_cd"></param>
		/// <returns></returns>
		private DataTable Select_SDC_MODEL_COMBO(string arg_model_cd)
		{

			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPB_MOLD_LAST_BSC.SELECT_SDC_MODEL_COMBO";

				MyOraDB.ReDim_Parameter(2); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_model_cd;  
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}



		#endregion

		#region 조회

		 
		/// <summary>
		/// Select_SPB_MOLD_LAST : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_last_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_model_cd"></param>
		/// <returns></returns>
		private DataTable Select_SPB_MOLD_LAST(string arg_factory, string arg_last_cd, string arg_line_cd, string arg_model_cd)
		{

			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPB_MOLD_LAST_BSC.SELECT_SPB_MOLD_LAST";

				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LAST_CD";  
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_MODEL_CD";  
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_last_cd; 
				MyOraDB.Parameter_Values[2] = arg_line_cd; 
				MyOraDB.Parameter_Values[3] = arg_model_cd; 
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}


		}

		#endregion 

		#region 저장
 

		/// <summary>
		/// Check_DUPLICATE_LAST : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_last_cd"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_model_cd"></param>
		/// <returns></returns>
		private bool Check_DUPLICATE_LAST(string arg_factory, string arg_last_cd, string arg_line_cd, string arg_model_cd)
		{

			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPB_MOLD_LAST_BSC.CHECK_DUPLICATE_LAST";

				MyOraDB.ReDim_Parameter(5); 
  
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_LAST_CD";  
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_MODEL_CD";  
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory;  
				MyOraDB.Parameter_Values[1] = arg_last_cd; 
				MyOraDB.Parameter_Values[2] = arg_line_cd; 
				MyOraDB.Parameter_Values[3] = arg_model_cd; 
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null)
				{
					return true;  // 중복 데이터로 처리
				}
				else
				{
					return (ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString().Trim() == "Y") ? true : false; 
				}

				
			}
			catch
			{
				return true; // 중복 데이터로 처리
			}


		}



		#endregion


		#endregion
 

 
		 
	}
}

