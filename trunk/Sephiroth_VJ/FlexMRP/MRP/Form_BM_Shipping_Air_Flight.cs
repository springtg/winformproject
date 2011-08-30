using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{


	public class Form_BM_Shipping_Air_Flight : COM.PCHWinForm.Form_Top, IOperation
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
		private System.Windows.Forms.Label lbl_ymd;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label label1;
		private COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo cmb_ObsType;
		private System.Windows.Forms.Label lbl_ObsType;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_status;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버

		private COM.OraDB MyOraDB = new COM.OraDB();
		private Pop_BM_Shipping_Wait _pop;

		private ArrayList _columnIndex	= new ArrayList();
		private ArrayList _changeData	= new ArrayList();
		private Pop_Finder finder;

		private string _process = (int)ClassLib.ComVar.MRPProcessNum.ShippingAdjust + "";
		private string _process2 = ClassLib.ComVar.MRPProcessNum.ShippingAdjust.ToString();

		private int _thisTimeShipCol	= 0;
		private int _mrpShipNoRow		= 4;
		private int _lotNoCol			= (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_NO;
		private int _lotSeqCol			= (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_SEQ;
		private int _styleCodeCol		= (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_CD;
		private int _totalQtyCol		= (int)ClassLib.TBSBM_SHIP_ADJUST.IxTOTAL_QTY;

		private string _lotNo = "", _lotSeq = "";

		private const int _validate_newstyle = 10, _validate_silhouette = 20, _validate_remarks = 30;
		private const int _validate_process = 40, _validate_redeploy = 50, _validate_recalculation = 60;
		private Color vAirColor =  Color.FromArgb(255, 0, 0);
		#endregion

		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_findData;

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Air_Flight()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Shipping_Air_Flight));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.dpick_from = new System.Windows.Forms.DateTimePicker();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.lbl_status = new System.Windows.Forms.Label();
			this.cmb_ObsType = new C1.Win.C1List.C1Combo();
			this.lbl_ObsType = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dpick_to = new System.Windows.Forms.DateTimePicker();
			this.cmb_shipType = new C1.Win.C1List.C1Combo();
			this.lbl_shipType = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_ymd = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.ctx_main = new System.Windows.Forms.ContextMenu();
			this.mnu_findData = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "16.3194444444444:False:True;81.5972222222222:False:False;0.694444444444444:False:" +
				"True;\t0.393700787401575:False:True;98.4251968503937:False:False;0.39370078740157" +
				"5:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Automatic;
			this.fgrid_main.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 98);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_main.Size = new System.Drawing.Size(1000, 470);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 3;
			this.fgrid_main.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_main_DragOver);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
			this.fgrid_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.fgrid_main_DragDrop);
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.dpick_from);
			this.pnl_head.Controls.Add(this.txt_status);
			this.pnl_head.Controls.Add(this.lbl_status);
			this.pnl_head.Controls.Add(this.cmb_ObsType);
			this.pnl_head.Controls.Add(this.lbl_ObsType);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.dpick_to);
			this.pnl_head.Controls.Add(this.cmb_shipType);
			this.pnl_head.Controls.Add(this.lbl_shipType);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_ymd);
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
			this.pnl_head.Size = new System.Drawing.Size(1000, 94);
			this.pnl_head.TabIndex = 2;
			// 
			// dpick_from
			// 
			this.dpick_from.CustomFormat = "";
			this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_from.Location = new System.Drawing.Point(109, 62);
			this.dpick_from.Name = "dpick_from";
			this.dpick_from.Size = new System.Drawing.Size(95, 21);
			this.dpick_from.TabIndex = 394;
			// 
			// txt_status
			// 
			this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_status.Location = new System.Drawing.Point(754, 40);
			this.txt_status.Name = "txt_status";
			this.txt_status.ReadOnly = true;
			this.txt_status.Size = new System.Drawing.Size(210, 21);
			this.txt_status.TabIndex = 417;
			this.txt_status.Text = "";
			// 
			// lbl_status
			// 
			this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(653, 40);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 416;
			this.lbl_status.Text = "Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_ObsType
			// 
			this.cmb_ObsType.AddItemCols = 0;
			this.cmb_ObsType.AddItemSeparator = ';';
			this.cmb_ObsType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ObsType.AutoSize = false;
			this.cmb_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ObsType.Caption = "";
			this.cmb_ObsType.CaptionHeight = 17;
			this.cmb_ObsType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ObsType.ColumnCaptionHeight = 18;
			this.cmb_ObsType.ColumnFooterHeight = 18;
			this.cmb_ObsType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ObsType.ContentHeight = 17;
			this.cmb_ObsType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ObsType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_ObsType.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_ObsType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ObsType.EditorHeight = 17;
			this.cmb_ObsType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ObsType.GapHeight = 2;
			this.cmb_ObsType.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_ObsType.ItemHeight = 15;
			this.cmb_ObsType.Location = new System.Drawing.Point(431, 62);
			this.cmb_ObsType.MatchEntryTimeout = ((long)(2000));
			this.cmb_ObsType.MaxDropDownItems = ((short)(5));
			this.cmb_ObsType.MaxLength = 32767;
			this.cmb_ObsType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ObsType.Name = "cmb_ObsType";
			this.cmb_ObsType.PartialRightColumn = false;
			this.cmb_ObsType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_ObsType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ObsType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ObsType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ObsType.Size = new System.Drawing.Size(210, 21);
			this.cmb_ObsType.TabIndex = 400;
			// 
			// lbl_ObsType
			// 
			this.lbl_ObsType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ObsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ObsType.ImageIndex = 0;
			this.lbl_ObsType.ImageList = this.img_Label;
			this.lbl_ObsType.Location = new System.Drawing.Point(330, 62);
			this.lbl_ObsType.Name = "lbl_ObsType";
			this.lbl_ObsType.Size = new System.Drawing.Size(100, 21);
			this.lbl_ObsType.TabIndex = 401;
			this.lbl_ObsType.Text = "Obs Type";
			this.lbl_ObsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(206, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 15);
			this.label1.TabIndex = 396;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.label2.Text = "      Shipping Info";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_to
			// 
			this.dpick_to.CustomFormat = "";
			this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_to.Location = new System.Drawing.Point(225, 62);
			this.dpick_to.Name = "dpick_to";
			this.dpick_to.Size = new System.Drawing.Size(95, 21);
			this.dpick_to.TabIndex = 395;
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
			this.cmb_shipType.Location = new System.Drawing.Point(431, 40);
			this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
			this.cmb_shipType.MaxDropDownItems = ((short)(5));
			this.cmb_shipType.MaxLength = 32767;
			this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_shipType.Name = "cmb_shipType";
			this.cmb_shipType.PartialRightColumn = false;
			this.cmb_shipType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_shipType.Size = new System.Drawing.Size(210, 21);
			this.cmb_shipType.TabIndex = 5;
			this.cmb_shipType.TextChanged += new System.EventHandler(this.cmb_shipType_TextChanged);
			// 
			// lbl_shipType
			// 
			this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipType.ImageIndex = 1;
			this.lbl_shipType.ImageList = this.img_Label;
			this.lbl_shipType.Location = new System.Drawing.Point(330, 40);
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
			this.pic_head3.Location = new System.Drawing.Point(984, 78);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_ymd
			// 
			this.lbl_ymd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ymd.ImageIndex = 1;
			this.lbl_ymd.ImageList = this.img_Label;
			this.lbl_ymd.Location = new System.Drawing.Point(8, 62);
			this.lbl_ymd.Name = "lbl_ymd";
			this.lbl_ymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_ymd.TabIndex = 50;
			this.lbl_ymd.Text = "Date";
			this.lbl_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 77);
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_factory.TabIndex = 1;
			this.cmb_factory.TextChanged += new System.EventHandler(this.cmb_factory_TextChanged);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 53);
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
			this.pic_head5.Location = new System.Drawing.Point(0, 78);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 76);
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
																					 this.mnu_findData});
			// 
			// mnu_findData
			// 
			this.mnu_findData.Index = 0;
			this.mnu_findData.Text = "Find Data";
			this.mnu_findData.Click += new System.EventHandler(this.mnu_findData_Click_1);
			// 
			// Form_BM_Shipping_Air_Flight
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_Shipping_Air_Flight";
			this.Load += new System.EventHandler(this.Form_Load);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ObsType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
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

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				this.Tbtn_SaveProcess();
		}	

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Confirm))
			{
				if (MessageBox.Show(this, "Do you want to confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Tbtn_ConfirmProcess();
			}
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Air_Flight.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 8;

			string [] aHead =  new string[iCnt];	
			aHead[0]    = ClassLib.ComFunction.Empty_Combo(cmb_factory, " ");
			aHead[1]    = ClassLib.ComFunction.Empty_Combo(cmb_shipType, " ");
			aHead[2]    = ClassLib.ComFunction.Empty_String(dpick_from.Text.ToString().Replace("-",""), " ");
			aHead[3]    = ClassLib.ComFunction.Empty_String(dpick_to.Text.ToString().Replace("-",""), " ");
			aHead[4]    = "";
			aHead[5]    = ClassLib.ComFunction.Empty_Combo(cmb_ObsType, " ");
			aHead[6]    = "";
			aHead[7]    = "";
			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();		
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

		#region 컨텍스트 메뉴

		private void mnu_size_Click(object sender, System.EventArgs e)
		{
			try
			{
				int vRow = fgrid_main.Row;

				if (fgrid_main.Rows[vRow].Node.Level == 1)
					return;

				if (fgrid_main.Rows[vRow].Node.Level == 3)
					vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),
															  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
															  cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_NO].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_SEQ].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_NAME].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLINE_CD].ToString(),
															  dpick_from.Value.ToString("yyyyMMdd"),
															  dpick_to.Value.ToString("yyyyMMdd"),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxGENDER].ToString(),
															  "Pkg_SBM_SHIPPING_ADJUST.SELECT_SHIPPING_SCHEDULE_SIZE"
														  };

				Pop_BM_Shipping_Schedule_Size vPop = new Pop_BM_Shipping_Schedule_Size();
				vPop.ShowDialog();
			}
			catch
			{

			}
		}



		private void mnu_adviceRecLot_Click(object sender, System.EventArgs e)
		{
			if (ClassLib.ComFunction.User_Message("Do you want current advice recalculation?", "Redeploy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_recalculation))
				{
					int vRow = fgrid_main.Row;

					if (fgrid_main.Rows[vRow].Node.Level == 3)
						vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

					_lotNo = fgrid_main[vRow, _lotNoCol].ToString();
					_lotSeq = fgrid_main[vRow, _lotSeqCol].ToString();

					if (_lotNo.Length != 9 || _lotSeq.Length != 2)
						return;

					RecalculationPorcess();
				}
			}	
		}

		private void mnu_adviceRecAll_Click(object sender, System.EventArgs e)
		{
			if (ClassLib.ComFunction.User_Message("Do you want all advice recalculation?", "Redeploy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_process))
				{
					_lotNo = "";
					_lotSeq = "";

					RecalculationPorcess();
				}
			}	
		}
		
		private void mnu_mrpRedeploy_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_redeploy))
			{
				if (ClassLib.ComFunction.User_Message("Do you want mrp size redeploy?", "Redeploy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;
			}
		}

		private void mnu_redeploy_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(_validate_redeploy))
			{
				if (ClassLib.ComFunction.User_Message("Do you want production daily size redeploy?", "Redeploy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					return;

				System.Threading.Thread tSize = new System.Threading.Thread(new System.Threading.ThreadStart(Size_RedeployProcess));
				tSize.Start();

				_pop = new Pop_BM_Shipping_Wait();
				_pop.Processing();
				_pop.Start();
			}
		}

		private void mnu_findData_Click(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Frozen - 1);
			finder.Location = new Point(MousePosition.X, MousePosition.Y);
			finder.Show();
		}

		private void mnu_all_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(3);		
		}

		private void mnu_line_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);		
		}

		private void mnu_lot_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		private void mnu_NewStyle_Click(object sender, System.EventArgs e)
		{
			if (!Etc_ProvisoValidateCheck(_validate_newstyle))
				return;

			int vRow = fgrid_main.Row;

			if (fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.Violet.ToArgb())
			{
				Grid_SetColorByTotalQty();
			}
			else
			{
				fgrid_main.Rows[vRow].StyleNew.ForeColor = Color.Violet;
			}

			fgrid_main.Update_Row(vRow);
		}

		private void mnu_silhouette_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!Etc_ProvisoValidateCheck(_validate_silhouette))
					return;

				int vRow = fgrid_main.Row;
				int vCol = fgrid_main.Col;
				string[] vData;

				CellRange vRange = fgrid_main.Selection;

				if (vRange.UserData == null)
					vRange.UserData = new string[2];

				vData = (string[])vRange.UserData;
				if (!ClassLib.ComFunction.NullToBlank(vData[0]).Equals("S"))
				{
					if (MessageBox.Show(this, "Select The Silhouette Material?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						vData[0] = "S";
						vData[1] = "Silhouette";
					}
				}
				else
				{
					if (MessageBox.Show(this, "Deselect The Silhouette Material?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						vData[0] = "";
						vData[1] = "";
					}
				}

				Grid_SetColorByTotalQty();
			}
			catch
			{
			}		
		}

		private void mnu_Remarks_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!Etc_ProvisoValidateCheck(_validate_remarks))
					return;

				int vRow = fgrid_main.Row;
				int vCol = fgrid_main.Col;
				string[] vData;
				CellRange vRange = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);

				if (vRange.UserData == null)
					vRange.UserData = new string[2];

				vData = (string[])vRange.UserData;

				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),
															  COM.ComFunction.Empty_Combo(cmb_shipType, ""),
															  cmb_shipType.GetItemText(cmb_shipType.SelectedIndex, 1),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_NO].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLOT_SEQ].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxSTYLE_NAME].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxLINE_CD].ToString(),
															  fgrid_main[vRow, (int)ClassLib.TBSBM_SHIP_ADJUST.IxGENDER].ToString(),
															  fgrid_main[_mrpShipNoRow, vCol].ToString(),
															  vData[1]
														  };

				Pop_BM_Shipping_Schedule_Remarks vPop = new Pop_BM_Shipping_Schedule_Remarks();

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					vData[1] = ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main.Update_Row(vRow);
				}

				vPop.Dispose();
			}
			catch
			{
			}		
		}

		#endregion

		#region 버튼 클릭


		private void btn_RunProcess_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
	
		}

		#endregion

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Shipping OA";
			lbl_MainTitle.Text = "Shipping OA";

			// grid set
			fgrid_main.Set_Grid("SBM_SHIP_SEARCH_MPS", "2", 4, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Rows[4].Visible = false;
			fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;
			for(int i = 0 ; i < fgrid_main.Cols.Frozen ; i++)
			{
				fgrid_main.Cols[i].AllowMerging = true;
			}

			for(int i = 0 ; i < fgrid_main.Rows.Fixed ; i++)
			{
				fgrid_main.Rows[i].AllowMerging = true;
			}

			fgrid_main.Set_Action_Image(img_Action);

			// factory set
			DataTable vDt;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = (cmb_factory.Tag == null) ? ClassLib.ComVar.This_Factory : cmb_factory.Tag;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, false);
			cmb_shipType.SelectedValue = (cmb_shipType.Tag == null) ? "11" : cmb_shipType.Tag;
			vDt.Dispose();



			// obs type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxOBSType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ObsType, 1, 2, true);
			cmb_ObsType.SelectedIndex = 0;
			vDt.Dispose();




			CheckStatus();

			fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;

			this.tbtn_Delete.Enabled = false;
			this.tbtn_Create.Enabled = false;
			 vDt = SELECT_SHIPPING_PLAN_DATE();
			if(vDt.Rows[0].ItemArray[0 ].ToString() !="")
			{
				dpick_from.Text = vDt.Rows[0].ItemArray[0].ToString();
				dpick_to.Text   = vDt.Rows[0].ItemArray[1].ToString();
			}
		}

		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		private void Tbtn_NewProcess()
		{
			try
			{
				fgrid_main.ClearAll();
				_changeData.Clear();
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

				fgrid_main.Set_Grid("SBM_SHIP_SEARCH_MPS", "1", 4, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Rows[4].Visible = false;
				fgrid_main.AllowMerging = AllowMergingEnum.FixedOnly;

				for(int i = 0 ; i < fgrid_main.Cols.Frozen ; i++)
				{
					fgrid_main.Cols[i].AllowMerging = true;
				}

				for(int i = 0 ; i < fgrid_main.Rows.Fixed ; i++)
				{
					fgrid_main.Rows[i].AllowMerging = true;
				}

				fgrid_main.Set_Action_Image(img_Action);

				this.Cursor = Cursors.WaitCursor;

				// header info set
				Grid_DisplayHeader();

				// tainl info set
				Grid_DisplayTail();

				_changeData.Clear();

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

		private void Tbtn_SaveProcess()
		{
//			try
//			{
//				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
//				{
//					if (fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.Red.ToArgb() || fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.DeepPink.ToArgb())
//					{
//						MessageBox.Show(this, "The account doesn't balance. [" + (vRow - fgrid_main.Rows.Fixed) + "]", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//						fgrid_main.Select(vRow, 1);
//						return;
//					}
//				}
//
//				this.Cursor = Cursors.WaitCursor;
//
//				SAVE_CURRENT_ADVICE();
//				_changeData.Clear();
//                
//				ClassLib.ComFunction.User_Message("Save Complete.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
//				fgrid_main.ClearFlags();
//				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//			}
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
		}

		private void Tbtn_ConfirmProcess()
		{
//			try
//			{
//				this.Cursor = Cursors.WaitCursor;
//
//				if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
//				{
//					string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");
//
//					if (vTemp.Length > 0)
//					{
//						MessageBox.Show(this, "Exist modify data", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
//						return;
//					}
//
//					if (SAVE_SHIPPING_CONFIRM())
//						Confirm();
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//				}
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_ConfirmProcess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//			}			
//			finally
//			{
//				this.Cursor = Cursors.Default;
//			}
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void rad_line_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void rad_advice_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		private void rad_all_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(3);
		}

		private void Size_RedeployProcess()
		{
			this.Cursor = Cursors.WaitCursor;

			int vRow = fgrid_main.Row;

			if (fgrid_main.Rows[vRow].Node.Level == 3)
				vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
         	
			string vFactory	= cmb_factory.SelectedValue.ToString();
			string vLotNo	= fgrid_main[vRow, _lotNoCol].ToString();
			string vLotSeq	= fgrid_main[vRow, _lotSeqCol].ToString();
		
			RUN_DAILY_SIZE_CREATE(vFactory, vLotNo, vLotSeq);

			_pop.Close();
			this.Cursor = Cursors.Default;
		}

		private bool PasswordCheck()
		{
			COM.ComVar.Parameter_PopUp = new string[]{"Password"};
			Pop_BM_Changer vPop = new Pop_BM_Changer();
			vPop.ShowDialog();

			if (COM.ComVar.Parameter_PopUp == null)
				return false;
			else
				return true;
		}




		private void RecalculationPorcess()
		{
			System.Threading.Thread tRun = new System.Threading.Thread(new System.Threading.ThreadStart(Recalculation));
			tRun.Start();

			_pop = new Pop_BM_Shipping_Wait();
			_pop.Processing();
			_pop.Start();
		}

		private void Run()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (RUN_SHIPPING_PROCESS())
				{
					ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_lotNo = "";
				_lotSeq = "";
				_pop.Close();
				this.Cursor = Cursors.Default;
			}
		}

		private void Recalculation()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (this.RUN_CURRENT_ADVICE_CREATE())
				{
					ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Advice Recalculation", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_lotNo = "";
				_lotSeq = "";
				_pop.Close();
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 그리드 이벤트 처리 메서드



		private void Grid_SetColorByTotalQty()
		{
			int vRow = fgrid_main.Row;
			int vCol = fgrid_main.Col;
			
			CellRange vCell = fgrid_main.GetCellRange(vRow, vCol, vRow, vCol);
			if (vCell.UserData == null)
				vCell.UserData = new string[2];

			int vTotal = SumData(fgrid_main.Row);//(int)fgrid_main.Aggregate(AggregateEnum.Sum, fgrid_main.Row, fgrid_main.Cols.Frozen, fgrid_main.Row, fgrid_main.Cols.Count - 1);

			if (fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.Violet.ToArgb() || fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.DeepPink.ToArgb())
			{
				if (vTotal != Convert.ToInt32(fgrid_main[vRow, _totalQtyCol]))
					fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor = Color.DeepPink;
				else
					fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor = Color.Violet;
			}
			else
			{
				if (vTotal != Convert.ToInt32(fgrid_main[fgrid_main.Row, _totalQtyCol]))
					fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor = Color.Red;
				else
					fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor = Color.Black;
			}
		}

		private int SumData(int arg_row)
		{
			int vSumData = 0;

			for (int vCol = fgrid_main.Cols.Frozen ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				string[] vInfo = (string[])fgrid_main.GetCellRange(arg_row, vCol, arg_row, vCol).UserData;
				if (vInfo != null && !ClassLib.ComFunction.NullToBlank(vInfo[0]).Equals("S"))
					vSumData += Convert.ToInt32(fgrid_main[arg_row, vCol]);
			}

			return vSumData;
		}


		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
//			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
//				return;
//
//			int vRow = fgrid_main.Row;
//
//			if ( e.Button == MouseButtons.Right && vRow >= fgrid_main.Rows.Fixed )
//				ctx_main.Show(fgrid_main, new Point(e.X, e.Y));
//			else
//			{
//				if (fgrid_main.Col < fgrid_main.Cols.Frozen)
//				{
//					if (fgrid_main.Rows[vRow].Node.Level == 3)
//						vRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
//
//					int vCol = fgrid_main.Cols.Frozen;
//
//					while (vCol < fgrid_main.Cols.Count)
//					{
//						if ( fgrid_main[vRow, vCol] != null || fgrid_main[vRow + 1, vCol] != null || fgrid_main[vRow + 2, vCol] != null )
//						{
//							fgrid_main.LeftCol = vCol;
//							break;
//						}
//
//						vCol++;
//					}
//				}
//				else
//				{
//					CellRange vRange = fgrid_main.Selection;
//					int vTemp = 0;
//
//					for (int i = vRange.c1 ; i <= vRange.c2 ; i++)
//						vTemp += Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_main[vRow, i], "0"));
//
//					stbar.Panels[1].Text = vTemp.ToString();
//				}
//			}		
		}

		/// <summary>
		/// fgrid_main_DragOver : + 표시
		/// </summary>
		private void fgrid_main_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// 선택된 구간에 수정중인 데이터가 포함되었는지 판단
			CellRange vSel = fgrid_main.Selection;

			// 조건 : Advice 블럭이 아니면 이동 불가, 다수의 Row 선택시 이동 불가, 
			// 선적 구간과 계획 구간이 아니면 이동 불가, 선택된 영역중 수정중인 데이터가 있는경우 이동불가
			if (fgrid_main.Rows[fgrid_main.Row].Node.Level != 2 || 
				fgrid_main.Selection.r1 != fgrid_main.Selection.r2 || 
				!fgrid_main.Cols[fgrid_main.Col].AllowEditing)
				e.Effect = DragDropEffects.None;
			else
				e.Effect = DragDropEffects.Copy;
		}

		/// <summary>
		/// fgrid_main_DragDrop : 마우스를 드랍했을때
		/// </summary>
		private void fgrid_main_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				if (!fgrid_main.Cols[fgrid_main.MouseCol].AllowEditing)
				{
					ClassLib.ComFunction.User_Message("Can not move to destination area", "Move Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				CellRange vSel = fgrid_main.Selection;
			
				int vRow	 = vSel.r1;
				int vDestCol = fgrid_main.MouseCol;

				int vDestData = Convert.ToInt32(fgrid_main[vRow, vDestCol]);

				for (int vCol = vSel.c1 ; vCol <= vSel.c2 ; vCol++)
				{
					if (vDestCol != vCol)
					{
						vDestData += Convert.ToInt32(fgrid_main[vRow, vCol]);
						fgrid_main[vRow, vCol] = null;
					}

					fgrid_main[vRow, vDestCol] = (vDestData == 0) ? null : vDestData.ToString();			
				}

				fgrid_main.Update_Row(vRow);
			}
			catch
			{

			}
		}

		#endregion

		#region 이벤트 처리시 사용되는 기능 메서드

		private int Grid_DisplayHeader()
		{
			_columnIndex.Clear();

			DataTable vDt = SELECT_SHIPPING_HEADER_INFO();

			if ( vDt.Rows.Count > 0 )
			{
				int vStartCol	= fgrid_main.Cols.Frozen+1;
				int vEndCol		= fgrid_main.Cols.Count = vStartCol + vDt.Rows.Count;

				for (int vIdx = 0, vCol = vStartCol ; vIdx < vDt.Rows.Count ; vIdx++, vCol++)
				{
					_columnIndex.Add(vDt.Rows[vIdx].ItemArray[3]);
					fgrid_main.Cols[vCol].Width				= 60;
				//	fgrid_main.Cols[vCol].DataType			= typeof(string);
				//	fgrid_main.Cols[vCol].Format			= "#,##0";

					fgrid_main[1, vCol] = vDt.Rows[vIdx].ItemArray[0];
					fgrid_main[2, vCol] = vDt.Rows[vIdx].ItemArray[1];
					fgrid_main[3, vCol] = vDt.Rows[vIdx].ItemArray[2];
					fgrid_main[4, vCol] = vDt.Rows[vIdx].ItemArray[3];

					// 구간에 따른 색상 지정
					if (!vDt.Rows[vIdx].ItemArray[4].ToString().Equals(""))
						fgrid_main.Cols[vCol].StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(vDt.Rows[vIdx].ItemArray[5]));
					else
						fgrid_main.Cols[vCol].StyleNew.ForeColor = Color.Blue;

					if (!vDt.Rows[vIdx].ItemArray[5].ToString().Equals(""))
						fgrid_main.Cols[vCol].StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(vDt.Rows[vIdx].ItemArray[5]));
					else
						fgrid_main.Cols[vCol].StyleNew.BackColor = Color.White;

					// 금번 선적 이후에 수정 가능
					if (vDt.Rows[vIdx].ItemArray[6].ToString().Equals("40"))
					{
						fgrid_main.Cols[vCol].AllowEditing = true;
						_thisTimeShipCol = vCol;
					}
					else if (vDt.Rows[vIdx].ItemArray[6].ToString().Equals("50"))
						fgrid_main.Cols[vCol].AllowEditing = true;
					else
						fgrid_main.Cols[vCol].AllowEditing = false;
				}

				if (_thisTimeShipCol == 0)
					_thisTimeShipCol = fgrid_main.Cols.Frozen;

				CellRange vRange = fgrid_main.GetCellRange(3, vStartCol, 3, fgrid_main.Cols.Count - 1);

				vRange.StyleNew.TextAlign	= C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
				vRange.StyleNew.Format		= "#,##0";
			}

			return vDt.Rows.Count;
		}

		// display grid
		private int Grid_DisplayTail()
		{
			DataTable vDt = SELECT_SHIPPING_SCHEDULE();

			if ( vDt.Rows.Count > 0 )
			{
				Display_FlexGrid(vDt);
				//Display_FlexGrid_Tree(fgrid_main, vDt, 0);
				fgrid_main.Tree.Column = 1;
				fgrid_main.Tree.Show(3);
				Grid_SetColor();
			}
			else
			{
				fgrid_main.ClearAll();
			}

			return vDt.Rows.Count;

		}

		// display grid
		private void Display_FlexGrid_Tree(COM.FSP arg_grid, DataTable arg_dt, int arg_tree)
		{
			try
			{
				ArrayList vRowIndex = new ArrayList();
				int vStartCol	= fgrid_main.Cols.Frozen;
				int vMrpShipNo	= fgrid_main.Cols.Frozen - 2;
				int vQty		= fgrid_main.Cols.Frozen;
				int vKey		= fgrid_main.Cols.Frozen + 1;
				int vNewStyle	= fgrid_main.Cols.Frozen + 1;
				int vRemarks	= fgrid_main.Cols.Frozen + 2;

				arg_grid.ClearAll();
				int vFixed = arg_grid.Rows.Fixed;
				int vRow = 0;
				int vCol = 0;
				int vCount = 1;

				for (int vIdx = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
				{
					// row, column index 구하기
					vCol = _columnIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]);
					vRow = vRowIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vKey - 1]);

					if (vRow != -1)
					{
						if (vCol != -1)
						{
							fgrid_main[vRow + vFixed, vCol + vStartCol] = arg_dt.Rows[vIdx].ItemArray[vQty - 1];
							// 실루엣 표시
							CellRange vRange = fgrid_main.GetCellRange(vRow + vFixed, vCol + vStartCol, vRow + vFixed, vCol + vStartCol);
							vRange.UserData = new string[]{arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString(), arg_dt.Rows[vIdx].ItemArray[vRemarks].ToString()};
						}
					}
					else
					{
						C1.Win.C1FlexGrid.Row vNewRow = arg_grid.Rows.Add();
						while (vCount < vStartCol - 1)
						{
							vNewRow[vCount++] = arg_dt.Rows[vIdx].ItemArray[vCount - 2];
						}
						
						if (vCol != -1)
						{
							vNewRow[vCol + vStartCol] = arg_dt.Rows[vIdx].ItemArray[vQty - 1];
							// 실루엣 표시
							CellRange vRange = fgrid_main.GetCellRange(vNewRow.Index, vCol + vStartCol, vNewRow.Index, vCol + vStartCol);
							vRange.UserData = new string[]{arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString(), arg_dt.Rows[vIdx].ItemArray[vRemarks].ToString()};
						}

						if (arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString().Equals("Y") || arg_dt.Rows[vIdx].ItemArray[vNewStyle].ToString().Equals("S"))
						{
							fgrid_main.Rows[vNewRow.Index].StyleNew.ForeColor = Color.Violet;
							//fgrid_main[]
						}

						vCount = 1;

						vNewRow.IsNode = true;
						vNewRow.Node.Level = int.Parse(arg_dt.Rows[vIdx].ItemArray[arg_tree].ToString());
						
						vRowIndex.Add(arg_dt.Rows[vIdx].ItemArray[vKey - 1]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		// display grid
		private void Display_FlexGrid(DataTable arg_dt)
		{
			try
			{
				ArrayList vRowIndex = new ArrayList();
				int vStartCol	= fgrid_main.Cols.Frozen;
				int vDataStart	= fgrid_main.Cols.Frozen - 2;
				int vMrpShipNo	= vDataStart;
				int vAdviceQty	= vDataStart + 1;
				int vMpsQty		= vDataStart + 2;
				int vShipQty	= vDataStart + 3;
				int vKey		= vDataStart + 4;
				int vRemarks	= vDataStart + 5;

				fgrid_main.ClearAll();
				int vFixed = fgrid_main.Rows.Fixed;
				int vCol = 0;
				int vCount = 2;
				int vMps_fRow = vFixed, vMps_tRow = vFixed + 1, vShipRow = vFixed + 2,vAdviceRow = vFixed+3;
				
				// 반복 처리 관련 변수
				string lot_no, lot_seq,style_no,style_nm,obs_id,date1;
				string slot_no="", slot_seq="",sstyle_no="",sstyle_nm="",sobs_id="",sdate1="";
				string vfl="T";
				int vForstart = 1;

				int vLot_no   = vForstart;
				int vLot_seq  = vForstart + 1;
				int vStyle_no = vForstart + 2;
				int vStyle_nm = vForstart + 3;
				int vGender   = vForstart + 4;
				int vObs_id   = vForstart + 5;
				int vObs_type = vForstart + 6;
				int vDate     = vForstart + 17;

				C1.Win.C1FlexGrid.Row vNewRow1=null;
				C1.Win.C1FlexGrid.Row vNewRow2=null;
				C1.Win.C1FlexGrid.Row vNewRow_A=null;
				C1.Win.C1FlexGrid.Row vNewRow_B=null;
				int array_count=0;
				int total_count=0;
				string array_mrp_ship_no=null;
				int [] vShipRow_A={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
				int [] vShipRow_B={0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
				
				
				

				for (int vIdx = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
				{
					if (!_columnIndex.Contains(arg_dt.Rows[vIdx].ItemArray[vMrpShipNo]))
						continue;

					vCol = _columnIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[13]) + vStartCol+1;

					lot_no   = arg_dt.Rows[vIdx].ItemArray[vLot_no ].ToString();
					lot_seq  = arg_dt.Rows[vIdx].ItemArray[vLot_seq ].ToString();
					style_no = arg_dt.Rows[vIdx].ItemArray[vStyle_no].ToString();
					style_nm = arg_dt.Rows[vIdx].ItemArray[vStyle_nm ].ToString();
					obs_id   = arg_dt.Rows[vIdx].ItemArray[vObs_id ].ToString();
					date1    = arg_dt.Rows[vIdx].ItemArray[vDate].ToString();				
					
					vfl="T";
					if(lot_no == slot_no)
					{
						if(lot_seq == slot_seq)
						{
							if(style_no == sstyle_no)
							{
								if(style_nm == sstyle_nm)
								{
									if(obs_id == sobs_id)
									{

											vfl="F";

									}
								}
							}
						}
					}
					if(vfl=="T")
					{
						vNewRow1 =  fgrid_main.Rows.Add();
						vNewRow1.IsNode = true;
						vNewRow1[1] = "MPS";
						vMps_fRow = vNewRow1.Node.Row.Index;

						vNewRow2 =  fgrid_main.Rows.Add();
						vNewRow2.IsNode = true;
						vNewRow2[1] = "A/F";
						vMps_tRow = vNewRow2.Node.Row.Index;
						
						array_count=0;
						total_count=0;


						slot_no   = arg_dt.Rows[vIdx].ItemArray[vLot_no ].ToString();
						slot_seq  = arg_dt.Rows[vIdx].ItemArray[vLot_seq ].ToString();
						sstyle_no = arg_dt.Rows[vIdx].ItemArray[vStyle_no].ToString();
						sstyle_nm = arg_dt.Rows[vIdx].ItemArray[vStyle_nm ].ToString();
						sobs_id   = arg_dt.Rows[vIdx].ItemArray[vObs_id ].ToString();
						sdate1    = arg_dt.Rows[vIdx].ItemArray[vDate].ToString();	
						vNewRow1[14] = "SHIP";
						vNewRow2[14] = "S-MARK";

						
					//	fgrid_main.Cols[vCol].Width				= 60;
						fgrid_main.Rows[vMps_fRow].DataType			= typeof(int);
						fgrid_main.Rows[vMps_fRow].Format			= "#,##0";

						while (vCount < 11)
						{
							vNewRow1[vCount++] = arg_dt.Rows[vIdx].ItemArray[vCount - 3];
						}
						vNewRow2[10] = arg_dt.Rows[vIdx].ItemArray[10];
						vNewRow1[11] = arg_dt.Rows[vIdx].ItemArray[15];
						vNewRow1[12] = arg_dt.Rows[vIdx].ItemArray[16];
						vNewRow1[15] = arg_dt.Rows[vIdx].ItemArray[14];
						vNewRow1[13] = arg_dt.Rows[vIdx].ItemArray[17];
					}

				

					vCount   = 2;	
					if(vCol != vStartCol)
					{
						if( arg_dt.Rows[vIdx].ItemArray[12].ToString().ToUpper() == "A")
						{
							if(array_mrp_ship_no != arg_dt.Rows[vIdx].ItemArray[13].ToString())
							{
								
								array_count=0;
								array_mrp_ship_no = arg_dt.Rows[vIdx].ItemArray[13].ToString();
						//	MessageBox.Show(array_count.ToString());
							}
							//MessageBox.Show(array_count.ToString());
							if(total_count <= array_count)
							{

								vNewRow_A =  fgrid_main.Rows.Add();
								vNewRow_A.IsNode = true;
								vNewRow_A[1] = "A/F";

								vNewRow_B =  fgrid_main.Rows.Add();
								vNewRow_B.IsNode = true;
								vNewRow_B[1] = "A-MARK";

								vNewRow_A[14] = "A/F";
								vNewRow_B[14] = "A-MARK";
								vShipRow_A[array_count] = vNewRow_A.Node.Row.Index;
								vShipRow_B[array_count] = vNewRow_B.Node.Row.Index;
							
								fgrid_main.Rows[vShipRow_A[array_count]].DataType		= typeof(int);
								fgrid_main.Rows[vShipRow_A[array_count]].Format			= "#,##0";			

								fgrid_main[vShipRow_A[array_count], vCol] = arg_dt.Rows[vIdx].ItemArray[18].ToString();
								fgrid_main.GetCellRange(vShipRow_A[array_count], vCol, vShipRow_A[array_count], vCol).StyleNew.ForeColor = vAirColor;
								fgrid_main[vShipRow_B[array_count], vCol] = arg_dt.Rows[vIdx].ItemArray[10].ToString();
								total_count++;
								array_count++;
							}
							else
							{
								fgrid_main[vShipRow_A[array_count], vCol] = arg_dt.Rows[vIdx].ItemArray[18].ToString();
								fgrid_main.GetCellRange(vShipRow_A[array_count], vCol, vShipRow_A[array_count], vCol).StyleNew.ForeColor = vAirColor;
								fgrid_main[vShipRow_B[array_count], vCol] = arg_dt.Rows[vIdx].ItemArray[10].ToString();
								array_count++;
							}
							
						}
						else 
						{
							fgrid_main[vMps_fRow, vCol] = arg_dt.Rows[vIdx].ItemArray[18].ToString();
							fgrid_main[vMps_tRow, vCol] = arg_dt.Rows[vIdx].ItemArray[10].ToString();
						}
					}

					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		// grid color set
		private void Grid_SetColor()
		{
			int vStartCol	= fgrid_main.Cols.Frozen;
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				CellRange vRange = fgrid_main.GetCellRange(vRow, 1, vRow, fgrid_main.Cols.Count - 1);

				if(fgrid_main.Rows[vRow][vStartCol-1].ToString()=="SHIP")
				{

					vRange.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					fgrid_main.Rows[vRow].AllowEditing = false;
				}
				else
				{
					fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
					fgrid_main.Rows[vRow].AllowEditing = false;

				}
		
				


			}
		}



		#endregion

		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_factory.Focus();
				return false;
			}

			if (cmb_shipType.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Ship Type", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_shipType.Focus();
				return false;
			}

			if (fgrid_main.Rows.Count < fgrid_main.Rows.Fixed)
			{
				ClassLib.ComFunction.User_Message("Data Not Found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
					if (cmb_shipType.SelectedIndex == -1)
					{
						ClassLib.ComFunction.User_Message("Select ShipType", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					string vFactory = cmb_factory.SelectedValue.ToString();
					string vShipType = cmb_shipType.SelectedValue.ToString();
					if (ClassLib.ComFunction.DoConfirm(vFactory, vShipType, "40", Convert.ToInt32(_process)) != 1)
						return false;

					break;
				case _validate_newstyle:
					if (fgrid_main.Rows[fgrid_main.Row].Node.Level != 2)
					{
						return false;
					}

					break;
				case _validate_silhouette:
					if (fgrid_main.Rows[fgrid_main.Row].Node.Level != 2 || fgrid_main.Col < _thisTimeShipCol)
					{
						return false;
					}
					if (fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor.ToArgb() == Color.Violet.ToArgb() || 
						fgrid_main.Rows[fgrid_main.Row].StyleNew.ForeColor.ToArgb() == Color.DeepPink.ToArgb())
					{
						return true;
					}

					break;
				case _validate_remarks:
					if (fgrid_main.Rows[fgrid_main.Row].Node.Level != 2 || fgrid_main.Col < _thisTimeShipCol)
						return false;
					break;
				case _validate_process:
					return PasswordCheck();
					break;
				case _validate_redeploy:
					if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						return false;

					if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 1)
						return false;

					return PasswordCheck();

                    break;
				case _validate_recalculation:
					if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)
						return false;

					if (fgrid_main.Rows[fgrid_main.Row].Node.Level == 1)
						return false;

					return PasswordCheck();

					break;
			}

			return true;
		}

		#endregion

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBM_SHIPPING_MASTER : 헤더 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_PLAN_DATE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "Pkg_Sbm_Shipping_Adjust.SELECT_SHIPPING_PLAN_DATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}
	

		/// <summary>
		/// PKG_SBM_SHIPPING_MASTER : 헤더 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_HEADER_INFO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "Pkg_Sbm_Shipping_Adjust.SELECT_SHIPPING_HEADER_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// PKG_SBM_SHIPPING_ADVICE : Shipping schedule 데이터 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_SCHEDULE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_ADJUST.SELECT_SHIPPING_AIR_FLIGHT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";


			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;


			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
			MyOraDB.Parameter_Values[5] = "";
			

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_ADVICE : 변경 수량 저장
		/// </summary>
		public bool SAVE_CURRENT_ADVICE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(13);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "Pkg_Sbm_Shipping_Adjust.SAVE_CURRENT_ADVICE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[6] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[7] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_SHIP_QTY";
				MyOraDB.Parameter_Name[9] = "ARG_NEW_STYLE";
				MyOraDB.Parameter_Name[10] = "ARG_SILHOUETTE";
				MyOraDB.Parameter_Name[11] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[12] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;

				ArrayList vList = new ArrayList();
				string[] vData;

				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(""))
					{
						int vLineRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;
						int vLineCol = 2;

						// 기존 데이터 삭제
						vList.Add(ClassLib.ComVar.Delete);
						vList.Add(cmb_factory.SelectedValue.ToString());
						vList.Add(cmb_shipType.SelectedValue.ToString());
						vList.Add(fgrid_main[vRow, _lotNoCol].ToString());
						vList.Add(fgrid_main[vRow, _lotSeqCol].ToString());
						vList.Add(fgrid_main[vRow, _styleCodeCol].ToString().Replace("-", ""));
						vList.Add(fgrid_main[_mrpShipNoRow, _thisTimeShipCol].ToString());
						vList.Add(fgrid_main[vLineRow, vLineCol].ToString());
						vList.Add("0");
						vList.Add("N");
						vList.Add("");
						vList.Add("");
						vList.Add(COM.ComVar.This_User);

						// 데이터 재입력
						for (int vCol = _thisTimeShipCol ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]).Equals("") &&
								!ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]).Equals("0"))
							{
								vList.Add(ClassLib.ComVar.Insert);
								vList.Add(cmb_factory.SelectedValue.ToString());
								vList.Add(cmb_shipType.SelectedValue.ToString());
								vList.Add(fgrid_main[vRow, _lotNoCol].ToString());
								vList.Add(fgrid_main[vRow, _lotSeqCol].ToString());
								vList.Add(fgrid_main[vRow, _styleCodeCol].ToString().Replace("-", ""));
								vList.Add(fgrid_main[_mrpShipNoRow, vCol].ToString());
								vList.Add(fgrid_main[vLineRow, vLineCol].ToString());
								vList.Add(fgrid_main[vRow, vCol].ToString());
								vList.Add("N");

								if (fgrid_main.GetCellRange(vRow, vCol, vRow, vCol).UserData != null)
								{
									vData = (string[])fgrid_main.GetCellRange(vRow, vCol, vRow, vCol).UserData;
									vList.Add(vData[0]);
									vList.Add(vData[1]);
								}
								else
								{
									vList.Add("");
									vList.Add("");
								}
									vList.Add(COM.ComVar.This_User);
							}
						}

						// 신규 스타일 여부 처리
						vList.Add(ClassLib.ComVar.Update);
						vList.Add(cmb_factory.SelectedValue.ToString());
						vList.Add(cmb_shipType.SelectedValue.ToString());
						vList.Add(fgrid_main[vRow, _lotNoCol].ToString());
						vList.Add(fgrid_main[vRow, _lotSeqCol].ToString());
						vList.Add(fgrid_main[vRow, _styleCodeCol].ToString().Replace("-", ""));
						vList.Add(fgrid_main[_mrpShipNoRow, _thisTimeShipCol].ToString());
						vList.Add(fgrid_main[vLineRow, vLineCol].ToString());
						vList.Add("0");

						if (fgrid_main.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.Violet.ToArgb())
						{
							vList.Add("Y");
						}
						else
						{
							vList.Add("N");
						}

						vList.Add("");
						vList.Add("");
						vList.Add(COM.ComVar.This_User);
					}
				}
	
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));
			
				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch
			{
				return false;
			}
		}

			/// <summary>
			/// PKG_SBM_SHIPPING_CONFIRM : 
			/// </summary>
		public bool SAVE_SHIPPING_CONFIRM()
		{
			try
			{
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "Pkg_Sbm_Shipping_Adjust.SAVE_CURRENT_ADJUST_CONFIRM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_SHIP_YMD_TO";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values = new string[12];

				MyOraDB.Parameter_Values[0] = ClassLib.ComVar.Delete;
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[3] = "";
				MyOraDB.Parameter_Values[4] = "";
				MyOraDB.Parameter_Values[5] = COM.ComVar.This_User;
				
				MyOraDB.Parameter_Values[6] = ClassLib.ComVar.Insert;
				MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[9] = "";
				MyOraDB.Parameter_Values[10] = "";
				MyOraDB.Parameter_Values[11] = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();
				return true;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_SHIPPING : DAILY 사이즈 재전개
		/// </summary>
		public void RUN_DAILY_SIZE_CREATE(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			try
			{
				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING.RUN_DAILY_SIZE_CREATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_lot_seq;

				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();
			}
			catch ( Exception ex )
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_DAILY_SIZE_CREATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// PKG_SBM_SHIPPING : run process
		/// </summary>
		public bool RUN_SHIPPING_PROCESS()
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING.RUN_SHIPPING_PROCESS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = _lotNo;
				MyOraDB.Parameter_Values[3] = _lotSeq;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_SHIPPING_PROCESS", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// PKG_SBM_SHIPPING : Advice Recalculation
		/// </summary>
		public bool RUN_CURRENT_ADVICE_CREATE()
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_SHIPPING.RUN_CURRENT_ADVICE_CREATE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
				MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
				MyOraDB.Parameter_Values[2] = _lotNo;
				MyOraDB.Parameter_Values[3] = _lotSeq;

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_CURRENT_ADVICE_CREATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}


		#endregion	

		#region IOperation 멤버

		public void CheckStatus()
		{
			// status set
			txt_status.Text = ClassLib.ComFunction.ProcessStatus(_process, cmb_factory.SelectedValue.ToString(), cmb_shipType.SelectedValue.ToString());

			// button enable set
			DataTable vDt = ClassLib.ComFunction.SELECT_PROCESS_CHARGE(cmb_factory.SelectedValue.ToString(), _process);
			tbtn_Save.Enabled			= false;
			tbtn_Confirm.Enabled		= false;
		}

		public bool Confirm()
		{


			return false;
		}

		public void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd)
		{

		}

		public int GetSearchRows()
		{
			return fgrid_main.Rows.Count - fgrid_main.Rows.Fixed;
		}
		
		#endregion

		#region Run 버튼 처리



		private void Run_DisplayTail()
		{
//			DataTable vDt = Run_SHIPPING_SCHEDULE();
			Run_SHIPPING_SCHEDULE();

//			if ( vDt.Rows.Count > 0 )
//			{
//				Display_FlexGrid(vDt);
//				//Display_FlexGrid_Tree(fgrid_main, vDt, 0);
//				fgrid_main.Tree.Column = 1;
//				fgrid_main.Tree.Show(3);
//				Grid_SetColor();
//			}
//			else
//			{
//				fgrid_main.ClearAll();
//			}
//
//			return vDt.Rows.Count;

		}

		public DataTable Run_SHIPPING_SCHEDULE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "Pkg_Sbm_Shipping_Adjust.SELECT_MPS_SHIPPING_SCHEDULE";



			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_LINE";
			MyOraDB.Parameter_Name[5] = "ARG_OBS_TYPE";
//			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = dpick_from.Text.Replace("-", "");
			MyOraDB.Parameter_Values[3] = dpick_to.Text.Replace("-", "");
			MyOraDB.Parameter_Values[4] = "";
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_ObsType, "");
//			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			return null ;
		}
		#endregion

		private void cmb_factory_TextChanged(object sender, System.EventArgs e)
		{
			DataTable vDt = SELECT_SHIPPING_PLAN_DATE();
			if(vDt.Rows[0].ItemArray[0 ].ToString()!="")
			{
				dpick_from.Text = vDt.Rows[0].ItemArray[0].ToString();
				dpick_to.Text   = vDt.Rows[0].ItemArray[1].ToString();
			}
		}

		private void cmb_shipType_TextChanged(object sender, System.EventArgs e)
		{
			DataTable vDt = SELECT_SHIPPING_PLAN_DATE();
			if(vDt.Rows[0].ItemArray[0 ].ToString()!="")
			{
				dpick_from.Text = vDt.Rows[0].ItemArray[0].ToString();
				dpick_to.Text   = vDt.Rows[0].ItemArray[1].ToString();
			}
		}

		private void mnu_findData_Click_1(object sender, System.EventArgs e)
		{
			finder = new Pop_Finder(fgrid_main, 1, fgrid_main.Cols.Count - 1);
			finder.Location = new Point(MousePosition.X, MousePosition.Y);
			finder.Show();
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{

				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
				if(fgrid_main.Buffer_CellData.ToString() !="" && (fgrid_main[fgrid_main.Row, 14].ToString()=="A-MARK" ||  fgrid_main[fgrid_main.Row, 14].ToString()=="S-MARK") && fgrid_main.Col > 14)
				{
					MessageBox.Show(fgrid_main.Buffer_CellData.ToString());
				}
		
			
		}

	}
}

