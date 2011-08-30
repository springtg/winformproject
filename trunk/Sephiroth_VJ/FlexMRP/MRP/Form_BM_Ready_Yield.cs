using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexMRP.MRP
{
	public class Form_BM_Ready_Yield : COM.PCHWinForm.Form_Top, IOperation
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_factory;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_useDivide;
		private System.Windows.Forms.MenuItem mnu_mrp;
		private System.Windows.Forms.MenuItem mnu_local;
		private System.Windows.Forms.MenuItem mnu_notUse;
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.Windows.Forms.Label lbl_ShipType;
		private System.Windows.Forms.Label lbl_MrpShipNo;
		private C1.Win.C1List.C1Combo cmb_MrpShipNo;


		#endregion

		#region 사용자 정의 변수

		private string _process		= (int)ClassLib.ComVar.MRPProcessNum.YieldCheck + "";
		private COM.OraDB MyOraDB = new COM.OraDB();
		private Hashtable _cellTypes = null;
		private ArrayList _columns = new ArrayList();
		private ArrayList _xRow = new ArrayList();
		private Color _headBack, _headFore;
		private C1.Win.C1List.C1Combo cmb_problem;
		private System.Windows.Forms.Label lbl_problem;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label btn_YieldInspection;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		
		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Ready_Yield()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Ready_Yield));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_YieldInspection = new System.Windows.Forms.Label();
			this.cmb_problem = new C1.Win.C1List.C1Combo();
			this.lbl_problem = new System.Windows.Forms.Label();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.lbl_status = new System.Windows.Forms.Label();
			this.cmb_MrpShipNo = new C1.Win.C1List.C1Combo();
			this.lbl_MrpShipNo = new System.Windows.Forms.Label();
			this.cmb_ShipType = new C1.Win.C1List.C1Combo();
			this.lbl_ShipType = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.spd_main = new COM.SSP();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.ctx_tail = new System.Windows.Forms.ContextMenu();
			this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
			this.mnu_Data = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_useDivide = new System.Windows.Forms.MenuItem();
			this.mnu_mrp = new System.Windows.Forms.MenuItem();
			this.mnu_local = new System.Windows.Forms.MenuItem();
			this.mnu_notUse = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_problem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MrpShipNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
			this.img_Button.ImageSize = new System.Drawing.Size(100, 23);
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
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// tbtn_Confirm
			// 
			this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.GridDefinition = "15.9722222222222:False:True;83.3333333333333:False:False;\t0.393700787401575:False" +
				":True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_YieldInspection);
			this.pnl_head.Controls.Add(this.cmb_problem);
			this.pnl_head.Controls.Add(this.lbl_problem);
			this.pnl_head.Controls.Add(this.txt_status);
			this.pnl_head.Controls.Add(this.lbl_status);
			this.pnl_head.Controls.Add(this.cmb_MrpShipNo);
			this.pnl_head.Controls.Add(this.lbl_MrpShipNo);
			this.pnl_head.Controls.Add(this.cmb_ShipType);
			this.pnl_head.Controls.Add(this.lbl_ShipType);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1000, 92);
			this.pnl_head.TabIndex = 0;
			// 
			// btn_YieldInspection
			// 
			this.btn_YieldInspection.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_YieldInspection.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_YieldInspection.ImageIndex = 0;
			this.btn_YieldInspection.ImageList = this.img_Button;
			this.btn_YieldInspection.Location = new System.Drawing.Point(666, 61);
			this.btn_YieldInspection.Name = "btn_YieldInspection";
			this.btn_YieldInspection.Size = new System.Drawing.Size(103, 23);
			this.btn_YieldInspection.TabIndex = 673;
			this.btn_YieldInspection.Text = "Yield Inspection";
			this.btn_YieldInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_YieldInspection.Click += new System.EventHandler(this.btn_YieldInspection_Click);
			this.btn_YieldInspection.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_YieldInspection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_YieldInspection.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_YieldInspection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// cmb_problem
			// 
			this.cmb_problem.AddItemCols = 0;
			this.cmb_problem.AddItemSeparator = ';';
			this.cmb_problem.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_problem.AutoSize = false;
			this.cmb_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_problem.Caption = "";
			this.cmb_problem.CaptionHeight = 17;
			this.cmb_problem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_problem.ColumnCaptionHeight = 18;
			this.cmb_problem.ColumnFooterHeight = 18;
			this.cmb_problem.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_problem.ContentHeight = 17;
			this.cmb_problem.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_problem.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_problem.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_problem.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_problem.EditorHeight = 17;
			this.cmb_problem.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_problem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_problem.GapHeight = 2;
			this.cmb_problem.ItemHeight = 15;
			this.cmb_problem.Location = new System.Drawing.Point(438, 62);
			this.cmb_problem.MatchEntryTimeout = ((long)(2000));
			this.cmb_problem.MaxDropDownItems = ((short)(5));
			this.cmb_problem.MaxLength = 32767;
			this.cmb_problem.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_problem.Name = "cmb_problem";
			this.cmb_problem.PartialRightColumn = false;
			this.cmb_problem.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_problem.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_problem.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_problem.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_problem.Size = new System.Drawing.Size(210, 21);
			this.cmb_problem.TabIndex = 412;
			// 
			// lbl_problem
			// 
			this.lbl_problem.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_problem.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_problem.ImageIndex = 0;
			this.lbl_problem.ImageList = this.img_Label;
			this.lbl_problem.Location = new System.Drawing.Point(337, 62);
			this.lbl_problem.Name = "lbl_problem";
			this.lbl_problem.Size = new System.Drawing.Size(100, 21);
			this.lbl_problem.TabIndex = 413;
			this.lbl_problem.Text = "Problem";
			this.lbl_problem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_status
			// 
			this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_status.Location = new System.Drawing.Point(767, 40);
			this.txt_status.Name = "txt_status";
			this.txt_status.ReadOnly = true;
			this.txt_status.Size = new System.Drawing.Size(210, 21);
			this.txt_status.TabIndex = 415;
			this.txt_status.Text = "";
			// 
			// lbl_status
			// 
			this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(666, 40);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 414;
			this.lbl_status.Text = "Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_MrpShipNo
			// 
			this.cmb_MrpShipNo.AddItemCols = 0;
			this.cmb_MrpShipNo.AddItemSeparator = ';';
			this.cmb_MrpShipNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MrpShipNo.AutoSize = false;
			this.cmb_MrpShipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MrpShipNo.Caption = "";
			this.cmb_MrpShipNo.CaptionHeight = 17;
			this.cmb_MrpShipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MrpShipNo.ColumnCaptionHeight = 18;
			this.cmb_MrpShipNo.ColumnFooterHeight = 18;
			this.cmb_MrpShipNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MrpShipNo.ContentHeight = 17;
			this.cmb_MrpShipNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MrpShipNo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MrpShipNo.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_MrpShipNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MrpShipNo.EditorHeight = 17;
			this.cmb_MrpShipNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_MrpShipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MrpShipNo.GapHeight = 2;
			this.cmb_MrpShipNo.ItemHeight = 15;
			this.cmb_MrpShipNo.Location = new System.Drawing.Point(109, 62);
			this.cmb_MrpShipNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_MrpShipNo.MaxDropDownItems = ((short)(5));
			this.cmb_MrpShipNo.MaxLength = 32767;
			this.cmb_MrpShipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MrpShipNo.Name = "cmb_MrpShipNo";
			this.cmb_MrpShipNo.PartialRightColumn = false;
			this.cmb_MrpShipNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_MrpShipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MrpShipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MrpShipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MrpShipNo.Size = new System.Drawing.Size(210, 21);
			this.cmb_MrpShipNo.TabIndex = 5;
			// 
			// lbl_MrpShipNo
			// 
			this.lbl_MrpShipNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MrpShipNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MrpShipNo.ImageIndex = 1;
			this.lbl_MrpShipNo.ImageList = this.img_Label;
			this.lbl_MrpShipNo.Location = new System.Drawing.Point(8, 62);
			this.lbl_MrpShipNo.Name = "lbl_MrpShipNo";
			this.lbl_MrpShipNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_MrpShipNo.TabIndex = 50;
			this.lbl_MrpShipNo.Text = "MRP Ship No";
			this.lbl_MrpShipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_ShipType
			// 
			this.cmb_ShipType.AddItemCols = 0;
			this.cmb_ShipType.AddItemSeparator = ';';
			this.cmb_ShipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ShipType.AutoSize = false;
			this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ShipType.Caption = "";
			this.cmb_ShipType.CaptionHeight = 17;
			this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ShipType.ColumnCaptionHeight = 18;
			this.cmb_ShipType.ColumnFooterHeight = 18;
			this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ShipType.ContentHeight = 17;
			this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ShipType.EditorHeight = 17;
			this.cmb_ShipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ShipType.GapHeight = 2;
			this.cmb_ShipType.ItemHeight = 15;
			this.cmb_ShipType.Location = new System.Drawing.Point(438, 40);
			this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
			this.cmb_ShipType.MaxDropDownItems = ((short)(5));
			this.cmb_ShipType.MaxLength = 32767;
			this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ShipType.Name = "cmb_ShipType";
			this.cmb_ShipType.PartialRightColumn = false;
			this.cmb_ShipType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ShipType.Size = new System.Drawing.Size(210, 21);
			this.cmb_ShipType.TabIndex = 5;
			this.cmb_ShipType.SelectedValueChanged += new System.EventHandler(this.cmb_ShipType_SelectedValueChanged);
			// 
			// lbl_ShipType
			// 
			this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ShipType.ImageIndex = 1;
			this.lbl_ShipType.ImageList = this.img_Label;
			this.lbl_ShipType.Location = new System.Drawing.Point(337, 40);
			this.lbl_ShipType.Name = "lbl_ShipType";
			this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_ShipType.TabIndex = 50;
			this.lbl_ShipType.Text = "Ship Type";
			this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 76);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 75);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(960, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_factory.TabIndex = 1;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(899, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 51);
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
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 42;
			this.label2.Text = "      Shipping Info";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(208, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(960, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 76);
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
			this.pic_head6.Location = new System.Drawing.Point(0, 16);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 65);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pnl_main
			// 
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.spd_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 96);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1000, 480);
			this.pnl_main.TabIndex = 1;
			// 
			// spd_main
			// 
			this.spd_main.BackColor = System.Drawing.Color.Transparent;
			this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spd_main.Location = new System.Drawing.Point(0, 0);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(1000, 480);
			this.spd_main.TabIndex = 0;
			this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// ctx_tail
			// 
			this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_AllSelect,
																					 this.mnu_Data,
																					 this.menuItem1,
																					 this.mnu_useDivide});
			// 
			// mnu_AllSelect
			// 
			this.mnu_AllSelect.Index = 0;
			this.mnu_AllSelect.Text = "All Select";
			// 
			// mnu_Data
			// 
			this.mnu_Data.Index = 1;
			this.mnu_Data.Text = "Value Change";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// mnu_useDivide
			// 
			this.mnu_useDivide.Index = 3;
			this.mnu_useDivide.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.mnu_mrp,
																						  this.mnu_local,
																						  this.mnu_notUse});
			this.mnu_useDivide.Text = "Use Divide";
			// 
			// mnu_mrp
			// 
			this.mnu_mrp.Index = 0;
			this.mnu_mrp.Text = "MRP";
			// 
			// mnu_local
			// 
			this.mnu_local.Index = 1;
			this.mnu_local.Text = "Local";
			// 
			// mnu_notUse
			// 
			this.mnu_notUse.Index = 2;
			this.mnu_notUse.Text = "Not Using";
			// 
			// Form_BM_Ready_Yield
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_Ready_Yield";
			this.Text = "Form_BM_Ready_Yield";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_problem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MrpShipNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (_mainSheet.RowCount > 0 && !e.ColumnHeader)
			{
				Display_ExistDataField(e.Row);
			}
		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Search))
				this.Tbtn_SearchProcess();
		}
	
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (MessageBox.Show(this, "Do you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					Confirm();
			}		
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Print))
				SetPrintYield();
		}
		
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			int vChilds = this.MdiParent.MdiChildren.Length;

			for (int vIdx = vChilds - 1 ; vIdx >= 0 ; vIdx--)
			{
				if (this.MdiParent.MdiChildren[vIdx] is Form_BM_MRP_Operation)
					this.MdiParent.MdiChildren[vIdx].Close();
			}

			this.Dispose(true);
		}

		private void Form_BM_Ready_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(_mainSheet.Rows.Count > 0)
			{
				for (int i = 0  ; i < _mainSheet.Rows.Count ; i++)
					if (_mainSheet.Cells[i, 0].Tag  != null)
					{
						if(MessageBox.Show(this, "Exist Modify Data, Do you want to close?","Close", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.No )
							e.Cancel = true;
						break;
					}
			}
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
			Cmb_MrpShipNoSetting();
			SELECT_SPB_CMP();
			CheckStatus();
		}

		private void cmb_ShipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
			Cmb_MrpShipNoSetting();
		}

		#region 컨텍스트 메뉴


		#endregion

		#region 입력이동

		#endregion

		#region 버튼효과

		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form initialize
			// ClassLib.ComFunction.Init_Form_Control(this);
			// ClassLib.ComFunction.SetLangDic(this);

			lbl_MainTitle.Text = "Yield Check";
			this.Text		   = "Yield Check";

			// grid set
			spd_main.Set_Spread_Comm("SBM_READY_YIELD", "3", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			// user define variable set
			_mainSheet	= spd_main.ActiveSheet;
			_cellTypes	= new Hashtable();
			_headBack = _mainSheet.ColumnHeader.Cells[0, 0].BackColor;
			_headFore = _mainSheet.ColumnHeader.Cells[0, 0].ForeColor;

			//입력부 setup
			Init_Combo();

			_mainSheet.ColumnHeader.Cells[1, 1].ColumnSpan = 2;
			_mainSheet.ColumnHeader.Cells[1, 3].ColumnSpan = 2;
			_mainSheet.ColumnHeader.Cells[1, 6].ColumnSpan = 2;

			_mainSheet.ColumnHeader.Cells[1, 0].RowSpan = 2;
			_mainSheet.ColumnHeader.Cells[1, 5].RowSpan = 2;
		}

		private void Init_Combo()
		{
			try
			{
				DataTable vDt;

				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40, 125);
				cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
				vDt.Dispose();

				// ship type set
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, false);
				cmb_ShipType.SelectedValue = (cmb_ShipType.Tag == null) ? "11" : cmb_ShipType.Tag;
				vDt.Dispose();

				// problem set
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxYesNo);
				COM.ComCtl.Set_ComboList(vDt, cmb_problem, 1, 2, true);
				cmb_problem.SelectedIndex = 0;
				vDt.Dispose();

//				CheckStatus();
//
//				// grid header set
//				SELECT_SPB_CMP();

				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Create.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		/// <summary>
		/// Select_SPB_CMP : 그리드 헤더에 Component 리스트 표시
		/// </summary>
		private void SELECT_SPB_CMP() 
		{
			int vStartIndex = _mainSheet.FrozenColumnCount;

			DataTable dt_ret = SELECT_SPB_CMP(cmb_factory.SelectedValue.ToString());

			_columns.Clear();
			_mainSheet.Columns.Count = vStartIndex + dt_ret.Rows.Count;

			for(int i = 0 ; i < dt_ret.Rows.Count ; i++)
			{
				_mainSheet.ColumnHeader.Cells[2, i + vStartIndex].Text = dt_ret.Rows[i].ItemArray[0].ToString().Trim();
				_mainSheet.Columns[i + vStartIndex].Width = 90;
				_mainSheet.Columns[i + vStartIndex].VerticalAlignment = CellVerticalAlignment.Center;
				_mainSheet.Columns[i + vStartIndex].HorizontalAlignment = CellHorizontalAlignment.Center;
				_mainSheet.Columns[i + vStartIndex].Locked = true;
				_columns.Add(dt_ret.Rows[i].ItemArray[0].ToString().Trim());
			}

			if (dt_ret.Rows.Count > 0)
			{
				_mainSheet.ColumnHeader.Cells[1, vStartIndex].ColumnSpan = dt_ret.Rows.Count;
			}

			dt_ret.Dispose();
		}

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "New_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_SBM_YIELD();
				Display_Grid(vDt);

				if (vDt.Rows.Count > 0)
					Grid_SetColor();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Display_Grid(DataTable arg_dt)
		{
			int vStartIndex = _mainSheet.FrozenColumnCount;
			int vCol = _mainSheet.FrozenColumnCount;
			string vCurKey = "";

			spd_main.ClearAll();
			_xRow.Clear();

			for (int vIdx = 0, vRow = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
			{
				if (!vCurKey.Equals(arg_dt.Rows[vIdx][0].ToString()))
				{					
					_mainSheet.Rows.Add(vRow, 1);

					int vValueCol = 1;
					vCurKey = arg_dt.Rows[vIdx][0].ToString();
					vRow++;

					while (vValueCol < 8)
					{
						_mainSheet.Cells[vRow - 1, vValueCol].Text = arg_dt.Rows[vIdx][vValueCol - 1].ToString();
						vValueCol++;
					}
				}

				vCol = vStartIndex + _columns.IndexOf(arg_dt.Rows[vIdx][7].ToString());
				if (vCol != vStartIndex - 1)
				{
					string vData = arg_dt.Rows[vIdx][8].ToString();
					vData = vData.Equals("0") ? "X" : "O (" + vData + " / " + arg_dt.Rows[vIdx][9].ToString() + ")";
					_mainSheet.Cells[vRow - 1, vCol].Text = vData;
					
					if (vData.Equals("X") && !_xRow.Contains(vRow - 1))
						_xRow.Add(vRow - 1);
				}
			}
		}

		private void Grid_SetColor()
		{
			int vStartIndex = _mainSheet.FrozenColumnCount;

			_mainSheet.Cells[0, 1, _mainSheet.RowCount - 1, vStartIndex - 1].BackColor = Color.FromArgb(245, 245, 220);
			_mainSheet.Cells[0, vStartIndex, _mainSheet.RowCount - 1, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightBlue;

			foreach (int vRow in _xRow)
			{
				_mainSheet.Cells[vRow, vStartIndex, vRow, _mainSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.RightPink2;
			}
		}

		private void Cmb_MrpShipNoSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_ShipType, "");

				DataTable vDt = ClassLib.ComFunction.SELECT_MRP_SHIP_NO_LIST(vFactory, vShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_MrpShipNo, 0, 0, false, false);
				cmb_MrpShipNo.SelectedValue = (cmb_MrpShipNo.Tag == null) ? "" : cmb_MrpShipNo.Tag;				
			}
			catch {}
		}

		private void  SetPrintYield()
		{
			try
			{   
						 
				string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_MRP_Ready_yield.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 4;
				string [] aHead =  new string[iCnt];	

				aHead[0]    = COM.ComFunction.Empty_Combo(cmb_factory, "");
				aHead[1]    = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
				aHead[2]    = COM.ComFunction.Empty_Combo(cmb_MrpShipNo, "");
				aHead[3]    = COM.ComFunction.Empty_Combo(cmb_problem, "");
				
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:					

					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:
//					if (_xRow.Count > 0)
//					{
//						ClassLib.ComFunction.User_Message("Exise empty yield data", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//						_mainSheet.ClearSelection();
//						_mainSheet.AddSelection((int)_xRow[0], 1, 1, 1);
//						return false;
//					}
					if (cmb_ShipType.SelectedIndex == -1)
					{
						ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						cmb_ShipType.Focus();
						return false;
					}
					if (ClassLib.ComFunction.DoConfirm(cmb_factory.SelectedValue.ToString(), cmb_ShipType.SelectedValue.ToString(), "40", Convert.ToInt32(_process)) != 1)
						return false;
					break;
			}

			return true;
		}

		#endregion

		#region 그리드 이벤트

		private void Display_ExistDataField(int arg_row)
		{
			for (int vCol = _mainSheet.FrozenColumnCount ; vCol < _mainSheet.ColumnCount ; vCol++)
			{
				if (!ClassLib.ComFunction.NullToBlank(_mainSheet.Cells[arg_row, vCol].Text).Equals(""))
				{
					_mainSheet.ColumnHeader.Cells[2, vCol].BackColor = ClassLib.ComVar.RightYellow;
					_mainSheet.ColumnHeader.Cells[2, vCol].ForeColor = Color.Black;
				}
				else
				{
					_mainSheet.ColumnHeader.Cells[2, vCol].BackColor = _headBack;
					_mainSheet.ColumnHeader.Cells[2, vCol].ForeColor = _headFore;
				}
			}
		}

		#endregion

		#region 버튼 이벤트


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


		
		private void btn_YieldInspection_Click(object sender, System.EventArgs e)
		{
			
			try
			{

				this.Cursor = Cursors.WaitCursor; 

				Event_Click_btn_YieldInspection();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_YieldInspection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
			}

		}


		/// <summary>
		/// Event_Click_btn_YieldInspection : 선적일자의 스타일에 대한 채산 정합성 체크
		/// </summary>
		private void Event_Click_btn_YieldInspection()
		{

			// DS, 각 스타일의 Factory 간의 채산 정합성 체크 (sbc_yield_info 의 ship_yn 체크)
 

			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_ShipType, cmb_MrpShipNo};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 
			if(! essential_check) return; 


			string factory = cmb_factory.SelectedValue.ToString();
			string ship_type = cmb_ShipType.SelectedValue.ToString();
			string mrp_ship_no = cmb_MrpShipNo.SelectedValue.ToString(); 
			string this_factory = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = Run_Yield_Inspection(factory, ship_type, mrp_ship_no, this_factory);

			string message = "";

			// 오류
			if(dt_ret == null) 
			{
			}


			// 채산, shipping material 완료
			if(dt_ret.Rows.Count == 0)
			{
				message = "Completed verification." + "\r\n\r\n" + "Data agrees.";
			}
			else  // 채산, shipping material 완료 안됨
			{
				message = "Completed verification." + "\r\n\r\n" + "Data does not agree." + "\r\n\r\n";

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					message += dt_ret.Rows[i].ItemArray[0].ToString() + "\r\n";

				} // end for i

			} // end if


			ClassLib.ComFunction.User_Message(message, "Yield Inspection", MessageBoxButtons.OK, MessageBoxIcon.Information);


			// 체크 후 처리




			 

		}



		/// <summary>
		/// Run_Yield_Inspection : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <param name="arg_mrp_ship_no"></param> 
		/// <param name="arg_this_factory"></param>
		/// <returns></returns>
		private DataTable Run_Yield_Inspection(string arg_factory, string arg_ship_type, string arg_mrp_ship_no, string arg_this_factory)
		{

			try
			{

				MyOraDB.ReDim_Parameter(5);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_READY.RUN_YIELD_INSPECTION"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_THIS_FACTORY";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type;
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no; 
				MyOraDB.Parameter_Values[3] = arg_this_factory;
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null ;

				return ds_ret.Tables[MyOraDB.Process_Name];


			}
			catch
			{
				return null;
			}

		}


		#endregion 

		#region DB Connect

		/// <summary>
		/// Select_SPB_CMP : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable SELECT_SPB_CMP(string arg_factory)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SPB_CMP";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
 

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		/// <summary>
		/// PKG_SBM_READY : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBM_YIELD()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_READY.SELECT_SBM_YIELD_DATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_PROBLEM";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_ShipType, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_MrpShipNo, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_problem, "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		#region IOperation 멤버

		public void CheckStatus()
		{
			// status set
			txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(), null);

			// button enable set
			DataTable vDt = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			tbtn_Confirm.Enabled = ClassLib.ComFunction.ButtonAccessable(vDt, (int)ClassLib.ComVar.MRPButtonEnum.Tbtn_Confirm, txt_status.Text);
		}

		public bool Confirm()
		{
			if (ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_factory, cmb_ShipType}, null))
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_ShipType, "");

				if (ClassLib.ComFunction.SAVE_CHECK_LIST_CONFIRM(_process, vFactory, vShipType, COM.ComVar.This_User, true))
				{
					ClassLib.ComFunction.User_Message("Confirm complete", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txt_status.Text = "Confirm";
					tbtn_Confirm.Enabled = false;
					return true;
				}			
			}

			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{
			cmb_factory.Tag = arg_factory;
			cmb_ShipType.Tag = arg_ShipType;
			cmb_MrpShipNo.Tag = arg_mrpNo;
		}

		public int GetSearchRows()
		{
			return spd_main.ActiveSheet.RowCount;
		}
		
		#endregion


	}
}

