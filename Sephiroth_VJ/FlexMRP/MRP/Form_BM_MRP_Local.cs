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
	public class Form_BM_MRP_Local : COM.PCHWinForm.Form_Top, IOperation
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_shipType;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label lbl_OBSType;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_ToDate;
		private System.Windows.Forms.DateTimePicker dpick_FromDate;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1; 
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuitem_SelectAll;
		private System.Windows.Forms.MenuItem menuitem_DeSelectAll;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_SelectCR;
		private System.Windows.Forms.MenuItem menuItem_DeselectCR;
		private System.Windows.Forms.Label btn_RunProcess; 

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_MRPCancel;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private System.Windows.Forms.Label lbl_DP_DPO;
		private System.Windows.Forms.Label label1;

		private Pop_BM_Shipping_Wait _pop;


		#endregion

		#region 생성자 / 소멸자

		public Form_BM_MRP_Local()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_MRP_Local));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_RunProcess = new System.Windows.Forms.Label();
			this.lblexcep_mark = new System.Windows.Forms.Label();
			this.dpick_ToDate = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_Date = new System.Windows.Forms.Label();
			this.cmb_OBSType = new C1.Win.C1List.C1Combo();
			this.lbl_OBSType = new System.Windows.Forms.Label();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_shipType = new C1.Win.C1List.C1Combo();
			this.lbl_shipType = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.spd_main = new COM.SSP();
			this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
			this.menuitem_SelectAll = new System.Windows.Forms.MenuItem();
			this.menuitem_DeSelectAll = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_SelectCR = new System.Windows.Forms.MenuItem();
			this.menuItem_DeselectCR = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem_MRPCancel = new System.Windows.Forms.MenuItem();
			this.sheetView1 = new FarPoint.Win.Spread.SheetView();
			this.cmb_To = new C1.Win.C1List.C1Combo();
			this.cmb_From = new C1.Win.C1List.C1Combo();
			this.lbl_DP_DPO = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
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
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
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
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;78.8194444444444:False:False;0:False:True;\t0.39370078" +
				"7401575:False:True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.cmb_To);
			this.pnl_head.Controls.Add(this.cmb_From);
			this.pnl_head.Controls.Add(this.lbl_DP_DPO);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.btn_RunProcess);
			this.pnl_head.Controls.Add(this.lblexcep_mark);
			this.pnl_head.Controls.Add(this.dpick_ToDate);
			this.pnl_head.Controls.Add(this.dpick_FromDate);
			this.pnl_head.Controls.Add(this.lbl_Date);
			this.pnl_head.Controls.Add(this.cmb_OBSType);
			this.pnl_head.Controls.Add(this.lbl_OBSType);
			this.pnl_head.Controls.Add(this.cmb_LineCd);
			this.pnl_head.Controls.Add(this.lbl_LineCd);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.cmb_shipType);
			this.pnl_head.Controls.Add(this.lbl_shipType);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1000, 114);
			this.pnl_head.TabIndex = 2;
			// 
			// btn_RunProcess
			// 
			this.btn_RunProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RunProcess.ImageIndex = 0;
			this.btn_RunProcess.ImageList = this.img_Button;
			this.btn_RunProcess.Location = new System.Drawing.Point(904, 84);
			this.btn_RunProcess.Name = "btn_RunProcess";
			this.btn_RunProcess.Size = new System.Drawing.Size(80, 23);
			this.btn_RunProcess.TabIndex = 412;
			this.btn_RunProcess.Text = "Run";
			this.btn_RunProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_RunProcess.Click += new System.EventHandler(this.btn_RunProcess_Click);
			this.btn_RunProcess.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_RunProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_RunProcess.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_RunProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lblexcep_mark
			// 
			this.lblexcep_mark.Location = new System.Drawing.Point(208, 64);
			this.lblexcep_mark.Name = "lblexcep_mark";
			this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
			this.lblexcep_mark.TabIndex = 411;
			this.lblexcep_mark.Text = "~";
			this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpick_ToDate
			// 
			this.dpick_ToDate.CustomFormat = "";
			this.dpick_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToDate.Location = new System.Drawing.Point(221, 62);
			this.dpick_ToDate.Name = "dpick_ToDate";
			this.dpick_ToDate.Size = new System.Drawing.Size(99, 21);
			this.dpick_ToDate.TabIndex = 410;
			this.dpick_ToDate.ValueChanged += new System.EventHandler(this.dpick_ToDate_ValueChanged);
			// 
			// dpick_FromDate
			// 
			this.dpick_FromDate.CustomFormat = "";
			this.dpick_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromDate.Location = new System.Drawing.Point(109, 62);
			this.dpick_FromDate.Name = "dpick_FromDate";
			this.dpick_FromDate.Size = new System.Drawing.Size(99, 21);
			this.dpick_FromDate.TabIndex = 409;
			this.dpick_FromDate.ValueChanged += new System.EventHandler(this.dpick_FromDate_ValueChanged);
			// 
			// lbl_Date
			// 
			this.lbl_Date.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Date.ImageIndex = 1;
			this.lbl_Date.ImageList = this.img_Label;
			this.lbl_Date.Location = new System.Drawing.Point(8, 62);
			this.lbl_Date.Name = "lbl_Date";
			this.lbl_Date.Size = new System.Drawing.Size(100, 21);
			this.lbl_Date.TabIndex = 408;
			this.lbl_Date.Text = "MPS Plan Date";
			this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBSType
			// 
			this.cmb_OBSType.AddItemCols = 0;
			this.cmb_OBSType.AddItemSeparator = ';';
			this.cmb_OBSType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBSType.AutoSize = false;
			this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBSType.Caption = "";
			this.cmb_OBSType.CaptionHeight = 17;
			this.cmb_OBSType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBSType.ColumnCaptionHeight = 18;
			this.cmb_OBSType.ColumnFooterHeight = 18;
			this.cmb_OBSType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBSType.ContentHeight = 17;
			this.cmb_OBSType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBSType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBSType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_OBSType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBSType.EditorHeight = 17;
			this.cmb_OBSType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBSType.GapHeight = 2;
			this.cmb_OBSType.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_OBSType.ItemHeight = 15;
			this.cmb_OBSType.Location = new System.Drawing.Point(445, 84);
			this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBSType.MaxDropDownItems = ((short)(5));
			this.cmb_OBSType.MaxLength = 32767;
			this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBSType.Name = "cmb_OBSType";
			this.cmb_OBSType.PartialRightColumn = false;
			this.cmb_OBSType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBSType.Size = new System.Drawing.Size(210, 21);
			this.cmb_OBSType.TabIndex = 406;
			this.cmb_OBSType.SelectedValueChanged += new System.EventHandler(this.cmb_OBSType_SelectedValueChanged);
			// 
			// lbl_OBSType
			// 
			this.lbl_OBSType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OBSType.ImageIndex = 0;
			this.lbl_OBSType.ImageList = this.img_Label;
			this.lbl_OBSType.Location = new System.Drawing.Point(344, 84);
			this.lbl_OBSType.Name = "lbl_OBSType";
			this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBSType.TabIndex = 407;
			this.lbl_OBSType.Text = "Order Type";
			this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LineCd
			// 
			this.cmb_LineCd.AddItemCols = 0;
			this.cmb_LineCd.AddItemSeparator = ';';
			this.cmb_LineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineCd.AutoSize = false;
			this.cmb_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineCd.Caption = "";
			this.cmb_LineCd.CaptionHeight = 17;
			this.cmb_LineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineCd.ColumnCaptionHeight = 18;
			this.cmb_LineCd.ColumnFooterHeight = 18;
			this.cmb_LineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineCd.ContentHeight = 17;
			this.cmb_LineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineCd.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_LineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineCd.EditorHeight = 17;
			this.cmb_LineCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_LineCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.GapHeight = 2;
			this.cmb_LineCd.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_LineCd.ItemHeight = 15;
			this.cmb_LineCd.Location = new System.Drawing.Point(445, 62);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(210, 21);
			this.cmb_LineCd.TabIndex = 404;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_LineCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(344, 62);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 405;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.label2.Text = "      MRP Info";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_shipType
			// 
			this.cmb_shipType.AddItemCols = 0;
			this.cmb_shipType.AddItemSeparator = ';';
			this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_shipType.AutoSize = false;
			this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_shipType.Caption = "";
			this.cmb_shipType.CaptionHeight = 17;
			this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_shipType.ColumnCaptionHeight = 18;
			this.cmb_shipType.ColumnFooterHeight = 18;
			this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_shipType.ContentHeight = 17;
			this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_shipType.EditorHeight = 17;
			this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_shipType.GapHeight = 2;
			this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_shipType.ItemHeight = 15;
			this.cmb_shipType.Location = new System.Drawing.Point(109, 84);
			this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
			this.cmb_shipType.MaxDropDownItems = ((short)(5));
			this.cmb_shipType.MaxLength = 32767;
			this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_shipType.Name = "cmb_shipType";
			this.cmb_shipType.PartialRightColumn = false;
			this.cmb_shipType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_shipType.Size = new System.Drawing.Size(210, 21);
			this.cmb_shipType.TabIndex = 5;
			this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
			// 
			// lbl_shipType
			// 
			this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipType.ImageIndex = 1;
			this.lbl_shipType.ImageList = this.img_Label;
			this.lbl_shipType.Location = new System.Drawing.Point(8, 84);
			this.lbl_shipType.Name = "lbl_shipType";
			this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipType.TabIndex = 50;
			this.lbl_shipType.Text = "Ship Type";
			this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 98);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 97);
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
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
			this.pic_head7.Size = new System.Drawing.Size(101, 73);
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
			this.pic_head5.Location = new System.Drawing.Point(0, 98);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 96);
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
			// spd_main
			// 
			this.spd_main.BackColor = System.Drawing.Color.Transparent;
			this.spd_main.ContextMenu = this.cmenu_Grid;
			this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.spd_main.Location = new System.Drawing.Point(8, 118);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.sheetView1);
			this.spd_main.Size = new System.Drawing.Size(1000, 454);
			this.spd_main.TabIndex = 174;
			this.spd_main.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_ButtonClicked);
			this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
			// 
			// cmenu_Grid
			// 
			this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuitem_SelectAll,
																					   this.menuitem_DeSelectAll,
																					   this.menuItem1,
																					   this.menuItem_SelectCR,
																					   this.menuItem_DeselectCR,
																					   this.menuItem2,
																					   this.menuItem_MRPCancel});
			// 
			// menuitem_SelectAll
			// 
			this.menuitem_SelectAll.Index = 0;
			this.menuitem_SelectAll.Text = "Select All";
			this.menuitem_SelectAll.Click += new System.EventHandler(this.menuitem_SelectAll_Click);
			// 
			// menuitem_DeSelectAll
			// 
			this.menuitem_DeSelectAll.Index = 1;
			this.menuitem_DeSelectAll.Text = "DeSelect All";
			this.menuitem_DeSelectAll.Click += new System.EventHandler(this.menuitem_DeSelectAll_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// menuItem_SelectCR
			// 
			this.menuItem_SelectCR.Index = 3;
			this.menuItem_SelectCR.Text = "Select Selection Range";
			this.menuItem_SelectCR.Click += new System.EventHandler(this.menuItem_SelectCR_Click);
			// 
			// menuItem_DeselectCR
			// 
			this.menuItem_DeselectCR.Index = 4;
			this.menuItem_DeselectCR.Text = "Deselect Selection Range";
			this.menuItem_DeselectCR.Click += new System.EventHandler(this.menuItem_DeselectCR_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 5;
			this.menuItem2.Text = "-";
			// 
			// menuItem_MRPCancel
			// 
			this.menuItem_MRPCancel.Index = 6;
			this.menuItem_MRPCancel.Text = "MRP Cancel";
			this.menuItem_MRPCancel.Click += new System.EventHandler(this.menuItem_MRPCancel_Click);
			// 
			// sheetView1
			// 
			this.sheetView1.SheetName = "Sheet1";
			// 
			// cmb_To
			// 
			this.cmb_To.AddItemCols = 0;
			this.cmb_To.AddItemSeparator = ';';
			this.cmb_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_To.AutoSize = false;
			this.cmb_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_To.Caption = "";
			this.cmb_To.CaptionHeight = 17;
			this.cmb_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_To.ColumnCaptionHeight = 18;
			this.cmb_To.ColumnFooterHeight = 18;
			this.cmb_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_To.ContentHeight = 17;
			this.cmb_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_To.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_To.EditorHeight = 17;
			this.cmb_To.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_To.GapHeight = 2;
			this.cmb_To.ItemHeight = 15;
			this.cmb_To.Location = new System.Drawing.Point(556, 40);
			this.cmb_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_To.MaxDropDownItems = ((short)(5));
			this.cmb_To.MaxLength = 32767;
			this.cmb_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_To.Name = "cmb_To";
			this.cmb_To.PartialRightColumn = false;
			this.cmb_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_To.Size = new System.Drawing.Size(99, 21);
			this.cmb_To.TabIndex = 420;
			// 
			// cmb_From
			// 
			this.cmb_From.AddItemCols = 0;
			this.cmb_From.AddItemSeparator = ';';
			this.cmb_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_From.AutoSize = false;
			this.cmb_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_From.Caption = "";
			this.cmb_From.CaptionHeight = 17;
			this.cmb_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_From.ColumnCaptionHeight = 18;
			this.cmb_From.ColumnFooterHeight = 18;
			this.cmb_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_From.ContentHeight = 17;
			this.cmb_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_From.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_From.EditorHeight = 17;
			this.cmb_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_From.GapHeight = 2;
			this.cmb_From.ItemHeight = 15;
			this.cmb_From.Location = new System.Drawing.Point(445, 40);
			this.cmb_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_From.MaxDropDownItems = ((short)(5));
			this.cmb_From.MaxLength = 32767;
			this.cmb_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_From.Name = "cmb_From";
			this.cmb_From.PartialRightColumn = false;
			this.cmb_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"entRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
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
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_From.Size = new System.Drawing.Size(99, 21);
			this.cmb_From.TabIndex = 419;
			this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
			// 
			// lbl_DP_DPO
			// 
			this.lbl_DP_DPO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DP_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DP_DPO.ImageIndex = 0;
			this.lbl_DP_DPO.ImageList = this.img_Label;
			this.lbl_DP_DPO.Location = new System.Drawing.Point(344, 40);
			this.lbl_DP_DPO.Name = "lbl_DP_DPO";
			this.lbl_DP_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DP_DPO.TabIndex = 418;
			this.lbl_DP_DPO.Text = "DP/ DPO";
			this.lbl_DP_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(544, 42);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(12, 16);
			this.label1.TabIndex = 417;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form_BM_MRP_Local
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_MRP_Local";
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
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		 

		#endregion

		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}
 

		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
//			int vChilds = this.MdiParent.MdiChildren.Length;
//
//			for (int vIdx = vChilds - 1 ; vIdx >= 0 ; vIdx--)
//			{
//				if (this.MdiParent.MdiChildren[vIdx] is Form_BM_MRP_Operation)
//					this.MdiParent.MdiChildren[vIdx].Close();
//			}
//
//			this.Dispose(true);
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
        
			try
			{
				
				if(cmb_factory.SelectedIndex == -1) return;

				DataTable dt_ret = FlexMRP.ClassLib.ComFunction.Select_Work_Line_List(cmb_factory.SelectedValue.ToString());
				COM.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
				dt_ret.Dispose();


				//cmb_shipType.SelectedIndex = -1;
				cmb_LineCd.SelectedIndex = -1;
				cmb_OBSType.SelectedIndex = -1;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);

				Change_SearchOption();

				spd_main.ClearAll();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	


		} 
  

		private void dpick_FromDate_ValueChanged(object sender, System.EventArgs e)
		{
		
			cmb_LineCd.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1;

			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd"); 
			dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);

			spd_main.ClearAll();


		}

		private void dpick_ToDate_ValueChanged(object sender, System.EventArgs e)
		{
		
			cmb_LineCd.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1; 

			spd_main.ClearAll();

		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
		

			cmb_LineCd.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1; 

			spd_main.ClearAll();


		}

		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		private void cmb_OBSType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
		}

		


		
		private void menuitem_SelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_SelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuitem_DeSelectAll_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Select_SelectionAll(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_DeSelectAll_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

 

		private void menuItem_SelectCR_Click(object sender, System.EventArgs e)
		{
			
			try
			{ 
				Select_SelectionRange(true);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void menuItem_DeselectCR_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Select_SelectionRange(false);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_SelectionRange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void menuItem_MRPCancel_Click(object sender, System.EventArgs e)
		{ 
			Cancel_MRP(); 
		}


		private void btn_RunProcess_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				RunProcess();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RunProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void cmb_From_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_From.SelectedIndex == -1) return;

				cmb_To.SelectedValue = cmb_From.SelectedValue.ToString();
				//spd_main.ClearAll(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_From_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			this.Text = "Local/LLT MRP";
			lbl_MainTitle.Text = "Local/LLT MRP";

			// grid set
			spd_main.Set_Spread_Comm("SBM_MRP_LOCAL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			
			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			

		}


		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
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

			// run 버튼 비활성화 처리
			if(! tbtn_Save.Enabled)
			{
				btn_RunProcess.Enabled = false;
			}

			tbtn_Save.Enabled = false;


 

			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
		 

			// ship type set
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_shipType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_shipType.SelectedIndex = 1;


			// obs type set
			dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxOBSType);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 

			// DPO  1.DP, 2.DPO
			dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_factory.SelectedValue.ToString(), "2" );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

			dt_ret.Dispose(); 


			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);  



		}





		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		private void Tbtn_NewProcess()
		{
			try
			{
				
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			    //cmb_shipType.SelectedIndex = -1;
				cmb_shipType.SelectedIndex = 1;
				cmb_LineCd.SelectedIndex = -1;
				cmb_OBSType.SelectedIndex = -1;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);

				spd_main.ClearAll();



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_shipType};   
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 
				if(! essential_check) return;


				string factory = cmb_factory.SelectedValue.ToString();
				string from_date = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string to_date = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text);
				string line_cd = ClassLib.ComFunction.Empty_Combo(cmb_LineCd, " ");
				string obs_type = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " ");
				string ship_type = cmb_shipType.SelectedValue.ToString();
				string obs_from = ClassLib.ComFunction.Empty_Combo(cmb_From, " ");
				string obs_to = ClassLib.ComFunction.Empty_Combo(cmb_To, " ");

				
				DataTable dt_ret = SELECT_MPS_LIST(factory, from_date, to_date, line_cd, obs_type, ship_type, obs_from, obs_to);
 

				if(dt_ret == null || dt_ret.Rows.Count == 0)
				{
					spd_main.ClearAll();
				}
				else
				{  

					spd_main.Display_Grid(dt_ret);
 

					for(int i = 0; i < spd_main.ActiveSheet.ColumnCount; i++)
					{
						if(i == (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG || i == (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY)
						{
							spd_main.ActiveSheet.Columns[i].Locked = false;
						}
						else
						{
							spd_main.ActiveSheet.Columns[i].Locked = true;
						}

					}



					// now_qty == 0 인 데이터 체크 불가 처리
					for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
					{


						if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY].Value.ToString() == "0")
						{
							spd_main.ActiveSheet.Rows[i].Locked = true;
							spd_main.ActiveSheet.Rows[i].ForeColor = ClassLib.ComVar.ClrImportant;
						} 
						else
						{
//							spd_main.ActiveSheet.Rows[i].Locked = false;
//							spd_main.ActiveSheet.Rows[i].ForeColor = Color.Black; 
						}
						
 
					} 
 


				}
 


				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		 
		 

		#endregion 

		#region 그리드 이벤트 처리 메서드

		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
		
			try
			{ 
				
				int sel_col = spd_main.ActiveSheet.ActiveColumnIndex;
				int sel_row = spd_main.ActiveSheet.ActiveRowIndex;

				if(sel_col != (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY) return;

				// 수정 가능한 컬럼은 double 로 타입 수정됨. 따라서, double 를 다시 decimal 로 타입 변환 
				decimal now_qty = Convert.ToDecimal( spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY].Value ); 
				decimal use_qty = Convert.ToDecimal( spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxUSE_QTY].Value ); 
				decimal total_qty = (decimal)spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxTOTAL_QTY].Value;

				if(use_qty + now_qty > total_qty)
				{
					string message = "(Use + Now) quantity more than Total quantity.";
					ClassLib.ComFunction.User_Message(message, "Edit now quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY].Value = total_qty - use_qty;
				}
				else
				{
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY].Value = now_qty;

					// 체크 되어 있지 않지만, now_qty 수정 할 경우 체크 표시
					if(! (bool)spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value)
					{ 
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value = true;
					}
				}


				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditModeOff", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void spd_main_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
		

			try
			{ 
				 
				int sel_row = spd_main.ActiveSheet.ActiveRowIndex; 

				decimal yield_count = (decimal)spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxYIELD_COUNT].Value;
				decimal import_count = (decimal)spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxIMPORT_COUNT].Value;

				if(yield_count == 0)
				{
					string message = "Not found yield data.";
					ClassLib.ComFunction.User_Message(message, "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value = false;
				}

				if(import_count == 0)
				{
					string message = "Not found import data.";
					ClassLib.ComFunction.User_Message(message, "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value = false;
				}

				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditModeOff", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		#endregion 
	 
		#region 이벤트 처리시 사용되는 기능 메서드
 

		private void Select_SelectionAll(bool arg_select)
		{ 
			for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
			{
				if(spd_main.ActiveSheet.Rows[i].Locked) continue;  

				decimal yield_count = (decimal)spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxYIELD_COUNT].Value;
				decimal import_count = (decimal)spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxIMPORT_COUNT].Value; 
				if(yield_count == 0 || import_count == 0) continue;

				spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value = arg_select;
			} 
		}


		private void Select_SelectionRange(bool arg_select)
		{

			CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

			for (int i = 0 ; i < vSelectionRange.Length; i++)
			{
				int start_row = vSelectionRange[i].Row;
				int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

				for (int j = start_row ; j < end_row; j++)
				{ 
					if(spd_main.ActiveSheet.Rows[j].Locked) continue; 

					decimal yield_count = (decimal)spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxYIELD_COUNT].Value;
					decimal import_count = (decimal)spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxIMPORT_COUNT].Value; 
					if(yield_count == 0 || import_count == 0) continue;

					spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value = arg_select;
				}
			}

		} 



		private void Cancel_MRP()
		{
 
			
			int save_fail_count = 0;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_shipType};   
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 
				if(! essential_check) return;

				if(spd_main.ActiveSheet.RowCount == 0) return;


				DialogResult result = ClassLib.ComFunction.Data_Message("Cancel MRP", ClassLib.ComVar.MgsChooseRun, this); 
				if(result == DialogResult.No) return;


				bool confirm_flag = false;
				bool confirm_lot_flag = false;
				string message = ""; 

				string factory = cmb_factory.SelectedValue.ToString();
				string ship_type = cmb_shipType.SelectedValue.ToString();
				string mrp_ship_no = "";
				string lot_no = "";
				string lot_seq = "";


				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				for (int i = 0 ; i < vSelectionRange.Length; i++)
				{
					int start_row = vSelectionRange[i].Row;
					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

					for (int j = start_row ; j < end_row; j++)
					{  
					
						mrp_ship_no = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxMRP_SHIP_NO].Text.ToString();
						lot_no = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_NO].Text.ToString();
						lot_seq = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_SEQ].Text.ToString();

						confirm_flag = CHECK_CONFIRM_MRP_LOT(factory, ship_type, mrp_ship_no, lot_no, lot_seq);
				
						// confirm_flag == true 이면 cancel 가능
						if(confirm_flag) continue;
				
						// confirm 상태일 때,
						confirm_lot_flag = true;
						message = "Already confirm data" + "\r\n\r\n" + "LOT : [" + lot_no + "-" + lot_seq + "]";
						ClassLib.ComFunction.User_Message(message, "MRP Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
						break;


					}
				}


 


				if(confirm_lot_flag) return;


				bool save_flag = false;

				// cancel 가능한 상태일 때,
				for (int i = 0 ; i < vSelectionRange.Length; i++)
				{
					int start_row = vSelectionRange[i].Row;
					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

					for (int j = start_row ; j < end_row; j++)
					{  
					
						mrp_ship_no = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxMRP_SHIP_NO].Text.ToString();
						lot_no = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_NO].Text.ToString();
						lot_seq = spd_main.ActiveSheet.Cells[j, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_SEQ].Text.ToString();

						save_flag = CANCEL_MRP_LOT(factory, ship_type, mrp_ship_no, lot_no, lot_seq);
				
						if(! save_flag)
						{
							save_fail_count++;
							message = "LOT : [" + lot_no + "-" + lot_seq + "]" + "\r\n\r\n" + "MRP Cancel";
							ClassLib.ComFunction.Data_Message(message, ClassLib.ComVar.MgsDoNotRun, this);
						}
//						else
//						{ 
//							ClassLib.ComFunction.Data_Message("MRP Cancel", ClassLib.ComVar.MgsEndRun, this); 
//						}


					}
				}


				if(save_fail_count == 0)
				{
					ClassLib.ComFunction.Data_Message("MRP Cancel", ClassLib.ComVar.MgsEndRun, this); 
				}

			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_MRPCancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

				//System.Windows.Forms.Application.DoEvents();

//				if(save_fail_count == 0)
//				{
					Tbtn_SearchProcess();
//				}

			}



		}



		private string _ShipYmd = "";

		private void RunProcess()
		{


			C1.Win.C1List.C1Combo[] cmb_array = {cmb_factory, cmb_shipType};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null); 
			if(! essential_check) return;

			 
			COM.ComVar.Parameter_PopUp = new string[]{"Date", dpick_FromDate.Text};
			Pop_BM_Changer vPop_date = new Pop_BM_Changer();
			vPop_date.ShowDialog();

			if (COM.ComVar.Parameter_PopUp == null) return; 

			_ShipYmd = MyComFunction.ConvertDate2DbType(COM.ComVar.Parameter_PopUp[0]); 



			if (MessageBox.Show(this, "Do you want to run mrp process?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				COM.ComVar.Parameter_PopUp = new string[]{"Password"};
				Pop_BM_Changer vPop_password = new Pop_BM_Changer();
				vPop_password.ShowDialog();

				if (COM.ComVar.Parameter_PopUp == null) return;
				
				System.Threading.Thread thread_run = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
				thread_run.Start();

				_pop = new Pop_BM_Shipping_Wait();
				_pop.Processing();
				_pop.Start();
			}



		}


		private void Run()
		{

			bool save_flag = false;

			try
			{
				
				this.Cursor = Cursors.WaitCursor;  
 
				string factory = cmb_factory.SelectedValue.ToString();
				string ship_type = cmb_shipType.SelectedValue.ToString();

				string mrp_ship_no = SELECT_FN_GET_MRP_SHIP_NO(factory, ship_type, _ShipYmd, ClassLib.ComVar.This_User);

				if(mrp_ship_no == "")
				{ 
					throw new Exception("Get mrp shipping number failed!!");
				}
				else
				{  

					save_flag = CHECK_DUPLICATE_MRP_SHIP_NO(factory, ship_type, mrp_ship_no);

					if(! save_flag)
					{
						throw new Exception("Duplicate MRP Shipping No : [" + mrp_ship_no + "]!!");
					}
					else
					{
					
						save_flag = SAVE_LOCAL_MRP(mrp_ship_no);

						if(! save_flag)
						{
							throw new Exception("Selection LOT list save failed!!");
						}
						else
						{

							save_flag = RUN_LOCAL_SIZE(factory, ship_type, mrp_ship_no, ClassLib.ComVar.This_User);

							if(! save_flag)
							{
								throw new Exception("Size save failed!!");
							}
							else
							{

								save_flag = RUN_LOCAL_USAGE(factory, ship_type, mrp_ship_no, ClassLib.ComVar.This_User);

								if(! save_flag)
								{
									throw new Exception("Usage calculation failed!!");
								}
								else
								{

									DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

									if(ds_ret == null)
									{
										throw new Exception("Run process failed!!");
									}
									else
									{ 
										//Tbtn_SearchProcess();
										ClassLib.ComFunction.User_Message("Run process Complete!!", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
									} 


								}  // RUN_LOCAL_USAGE()

							} // RUN_LOCAL_SIZE()


						} // SAVE_LOCAL_MRP()

					} // MRP_NO 중복 체크

				} // SELECT_FN_GET_MRP_SHIP_NO


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				_pop.Close();
				this.Cursor = Cursors.Default; 

				//System.Windows.Forms.Application.DoEvents();

				if(save_flag)
				{
					Tbtn_SearchProcess();
				}

				


			}		
		}



		/// <summary>
		/// Change_SearchOption : 
		/// </summary>
		private void Change_SearchOption()
		{
			DataTable dt_ret;

			if(cmb_factory.SelectedIndex == -1) return;

			// DPO  1.DP, 2.DPO
			dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_factory.SelectedValue.ToString(), "2" );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

			dt_ret.Dispose(); 

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
		


		#endregion  

		
		#endregion

		#region DB Connect
	
		/// <summary>
		/// SELECT_MPS_LIST : 생산계획 가져오기 
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable SELECT_MPS_LIST(string arg_factory,
			string arg_from_date,
			string arg_to_date,
			string arg_line_cd,
			string arg_obs_type,
			string arg_ship_type,
			string obs_from,
			string obs_to)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(9); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SELECT_MPS_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM_DTAE";
			MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
			MyOraDB.Parameter_Name[3] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[5] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[6] = "ARG_OBS_FROM";
			MyOraDB.Parameter_Name[7] = "ARG_OBS_TO";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_from_date;
			MyOraDB.Parameter_Values[2] = arg_to_date;
			MyOraDB.Parameter_Values[3] = arg_line_cd;
			MyOraDB.Parameter_Values[4] = arg_obs_type;
			MyOraDB.Parameter_Values[5] = arg_ship_type;
			MyOraDB.Parameter_Values[6] = obs_from;
			MyOraDB.Parameter_Values[7] = obs_to;
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;

			return ds_ret.Tables[MyOraDB.Process_Name];
		}


		
		 

		/// <summary>
		/// SELECT_FN_GET_MRP_SHIP_NO : MRP SHIPPING NO 가져오기
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <param name="arg_ship_date"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns>DataTable</returns>
		private string SELECT_FN_GET_MRP_SHIP_NO(string arg_factory, string arg_ship_type, string arg_ship_date, string arg_upd_user)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SELECT_FN_GET_MRP_SHIP_NO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
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
				MyOraDB.Parameter_Values[2] = arg_ship_date;
				MyOraDB.Parameter_Values[3] = arg_upd_user;
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return "";
				return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_FN_GET_MRP_SHIP_NO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return "";
			}


		}



		/// <summary>
		/// CHECK_DUPLICATE_MRP_SHIP_NO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <param name="arg_mrp_ship_no"></param>
		/// <returns></returns>
		private bool CHECK_DUPLICATE_MRP_SHIP_NO(string arg_factory, string arg_ship_type, string arg_mrp_ship_no)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(4);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.CHECK_DUPLICATE_MRP_SHIP_NO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type; 
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no; 
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false;

				// duplicate count
				if(Convert.ToInt32(ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString() ) == 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CHECK_DUPLICATE_MRP_SHIP_NO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}


		}



		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private bool SAVE_LOCAL_MRP(string arg_mrp_ship_no)
		{

			try
			{
 
				int col_ct = 21;
				MyOraDB.ReDim_Parameter(col_ct);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SAVE_LOCAL_MRP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[7] = "ARG_LOT_QTY";
				MyOraDB.Parameter_Name[8] = "ARG_LOSS_QTY";
				MyOraDB.Parameter_Name[9] = "ARG_USE_QTY"; 
				MyOraDB.Parameter_Name[10] = "ARG_NOW_QTY";
				MyOraDB.Parameter_Name[11] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[12] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[13] = "ARG_PO_NO";
				MyOraDB.Parameter_Name[14] = "ARG_PLAN_STRYMD"; 
				MyOraDB.Parameter_Name[15] = "ARG_PLAN_ENDYMD";
				MyOraDB.Parameter_Name[16] = "ARG_TOT_DAY_SEQ";
				MyOraDB.Parameter_Name[17] = "ARG_STATUS";
				MyOraDB.Parameter_Name[18] = "ARG_RUN_FLAG";
				MyOraDB.Parameter_Name[19] = "ARG_REMARKS"; 
				MyOraDB.Parameter_Name[20] = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				} 

				//04.DATA 정의
				ArrayList vList = new ArrayList(); 

				for(int i = 0 ; i < spd_main.ActiveSheet.RowCount ; i++)
				{


					//if(Convert.ToBoolean(ClassLib.ComFunction.NullCheck(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value, "false")))

					if( (bool)spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxFLAG].Value )
					{
  
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxFACTORY].Value.ToString()); 
						vList.Add(cmb_shipType.SelectedValue.ToString());
						vList.Add(arg_mrp_ship_no);
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_NO].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_SEQ].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxSTYLE_CD].Value.ToString().Replace("-", ""));
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxLINE_CD].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOT_QTY].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxLOSS_QTY].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxUSE_QTY].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxNOW_QTY].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxOBS_ID].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxOBS_TYPE].Value).ToString();
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxPO_NO].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxPLAN_STRYMD].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxPLAN_ENDYMD].Value.ToString());
						vList.Add(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_LOCAL.IxTOT_DAY_SEQ].Value.ToString());
						vList.Add("S");  //"ARG_STATUS"
						vList.Add("R");  //"ARG_RUN_FLAG"
						vList.Add("");   //"ARG_REMARKS"
						vList.Add(ClassLib.ComVar.This_User);   

					}


				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_LOCAL_MRP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}


		}



		/// <summary>
		/// RUN_LOCAL_SIZE : 대상항목 사이즈 전개
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <returns></returns>
		private bool RUN_LOCAL_SIZE(string arg_factory, string arg_ship_type, string arg_mrp_ship_no, string arg_upd_user)
		{


			try
			{
  
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.RUN_LOCAL_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type;  
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no;  
				MyOraDB.Parameter_Values[3] = arg_upd_user;  

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_LOCAL_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}



		}

		/// <summary>
		/// RUN_LOCAL_USAGE : 소요량 계산
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <returns></returns>
		private bool RUN_LOCAL_USAGE(string arg_factory, string arg_ship_type, string arg_mrp_ship_no, string arg_upd_user)
		{


			try
			{
  
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.RUN_LOCAL_USAGE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type;  
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no;  
				MyOraDB.Parameter_Values[3] = arg_upd_user;  

				MyOraDB.Add_Modify_Parameter(false);
				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_LOCAL_USAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}



		}

		 

		/// <summary>
		/// CHECK_CONFIRM_MRP_LOT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <param name="arg_mrp_ship_no"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private bool CHECK_CONFIRM_MRP_LOT(string arg_factory, string arg_ship_type, string arg_mrp_ship_no, string arg_lot_no, string arg_lot_seq)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.CHECK_CONFIRM_MRP_LOT";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type; 
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no; 
				MyOraDB.Parameter_Values[3] = arg_lot_no; 
				MyOraDB.Parameter_Values[4] = arg_lot_seq; 
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false;

				// confirm count
				if(Convert.ToInt32(ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString() ) == 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CHECK_CONFIRM_MRP_LOT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}


		}



		/// <summary>
		/// CANCEL_MRP_LOT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_ship_type"></param>
		/// <param name="arg_mrp_ship_no"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private bool CANCEL_MRP_LOT(string arg_factory, string arg_ship_type, string arg_mrp_ship_no, string arg_lot_no, string arg_lot_seq)
		{

			try
			{
 
				DataSet ds_ret; 
 
				 
				MyOraDB.ReDim_Parameter(5);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.CANCEL_MRP_LOT";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_ship_type; 
				MyOraDB.Parameter_Values[2] = arg_mrp_ship_no; 
				MyOraDB.Parameter_Values[3] = arg_lot_no; 
				MyOraDB.Parameter_Values[4] = arg_lot_seq; 

 
				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}


			}
			catch
			{
				return false;
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
			return spd_main.ActiveSheet.RowCount;
		}

		#endregion


		

	
		

	

		 


	}
}

