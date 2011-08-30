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
	public class Form_BM_Shipping_Local_Search_ByStyle : COM.PCHWinForm.Form_Top, IOperation
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
		private System.Windows.Forms.Label lblexcep_mark;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1;  
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Option;
		private System.Windows.Forms.Label lbl_DP_DPO;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Division;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private C1.Win.C1List.C1Combo cmb_SearchOption;
		private C1.Win.C1List.C1Combo cmb_LocalDivision;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
 

		// search option value
		private const int _Search_DP = 1;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_Purchase;
		private System.Windows.Forms.Label btn_Incoming;
		private System.Windows.Forms.Label btn_Out;
		private System.Windows.Forms.Label btn_MRP;
		private System.Windows.Forms.ContextMenu cmenu_Grid;
		private System.Windows.Forms.MenuItem menuItem_DisplayStyleInfo;
		private const int _Search_DPO = 2;


		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Local_Search_ByStyle()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_Shipping_Local_Search_ByStyle));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_low = new System.Windows.Forms.Panel();
			this.btn_MRP = new System.Windows.Forms.Label();
			this.btn_Purchase = new System.Windows.Forms.Label();
			this.btn_Incoming = new System.Windows.Forms.Label();
			this.btn_Out = new System.Windows.Forms.Label();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.cmb_LocalDivision = new C1.Win.C1List.C1Combo();
			this.lbl_Division = new System.Windows.Forms.Label();
			this.cmb_To = new C1.Win.C1List.C1Combo();
			this.cmb_From = new C1.Win.C1List.C1Combo();
			this.lbl_DP_DPO = new System.Windows.Forms.Label();
			this.cmb_SearchOption = new C1.Win.C1List.C1Combo();
			this.lbl_Option = new System.Windows.Forms.Label();
			this.lblexcep_mark = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.spd_main = new COM.SSP();
			this.cmenu_Grid = new System.Windows.Forms.ContextMenu();
			this.menuItem_DisplayStyleInfo = new System.Windows.Forms.MenuItem();
			this.sheetView1 = new FarPoint.Win.Spread.SheetView();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_low.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LocalDivision)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
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
			this.lbl_MainTitle.Text = "Local/LLT Monitoring By Style";
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.pnl_low);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;73.4375:False:False;5.38194444444444:False:True;\t0.39" +
				"3700787401575:False:True;98.4251968503937:False:False;0.393700787401575:False:Tr" +
				"ue;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_low
			// 
			this.pnl_low.BackColor = System.Drawing.Color.Transparent;
			this.pnl_low.Controls.Add(this.btn_MRP);
			this.pnl_low.Controls.Add(this.btn_Purchase);
			this.pnl_low.Controls.Add(this.btn_Incoming);
			this.pnl_low.Controls.Add(this.btn_Out);
			this.pnl_low.Location = new System.Drawing.Point(8, 545);
			this.pnl_low.Name = "pnl_low";
			this.pnl_low.Size = new System.Drawing.Size(1008, 31);
			this.pnl_low.TabIndex = 175;
			// 
			// btn_MRP
			// 
			this.btn_MRP.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_MRP.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_MRP.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_MRP.ImageIndex = 0;
			this.btn_MRP.ImageList = this.img_Button;
			this.btn_MRP.Location = new System.Drawing.Point(677, 6);
			this.btn_MRP.Name = "btn_MRP";
			this.btn_MRP.Size = new System.Drawing.Size(80, 23);
			this.btn_MRP.TabIndex = 673;
			this.btn_MRP.Text = "MRP";
			this.btn_MRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Purchase
			// 
			this.btn_Purchase.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Purchase.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Purchase.ImageIndex = 0;
			this.btn_Purchase.ImageList = this.img_Button;
			this.btn_Purchase.Location = new System.Drawing.Point(758, 6);
			this.btn_Purchase.Name = "btn_Purchase";
			this.btn_Purchase.Size = new System.Drawing.Size(80, 23);
			this.btn_Purchase.TabIndex = 670;
			this.btn_Purchase.Text = "Purchase";
			this.btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Incoming
			// 
			this.btn_Incoming.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Incoming.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Incoming.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Incoming.ImageIndex = 0;
			this.btn_Incoming.ImageList = this.img_Button;
			this.btn_Incoming.Location = new System.Drawing.Point(839, 6);
			this.btn_Incoming.Name = "btn_Incoming";
			this.btn_Incoming.Size = new System.Drawing.Size(80, 23);
			this.btn_Incoming.TabIndex = 669;
			this.btn_Incoming.Text = "Incoming";
			this.btn_Incoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_Out
			// 
			this.btn_Out.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Out.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Out.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Out.ImageIndex = 0;
			this.btn_Out.ImageList = this.img_Button;
			this.btn_Out.Location = new System.Drawing.Point(920, 6);
			this.btn_Out.Name = "btn_Out";
			this.btn_Out.Size = new System.Drawing.Size(80, 23);
			this.btn_Out.TabIndex = 668;
			this.btn_Out.Text = "Outgoing";
			this.btn_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.cmb_StyleCd);
			this.pnl_head.Controls.Add(this.txt_StyleCd);
			this.pnl_head.Controls.Add(this.cmb_LocalDivision);
			this.pnl_head.Controls.Add(this.lbl_Division);
			this.pnl_head.Controls.Add(this.cmb_To);
			this.pnl_head.Controls.Add(this.cmb_From);
			this.pnl_head.Controls.Add(this.lbl_DP_DPO);
			this.pnl_head.Controls.Add(this.cmb_SearchOption);
			this.pnl_head.Controls.Add(this.lbl_Option);
			this.pnl_head.Controls.Add(this.lblexcep_mark);
			this.pnl_head.Controls.Add(this.lbl_Style);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_Factory);
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
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 17;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 17;
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(521, 62);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" ColumnCaptionH" +
				"eight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup" +
				"=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScro" +
				"llBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" " +
				"me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"" +
				"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pa" +
				"rent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6" +
				"\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" " +
				"me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selec" +
				"tedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></" +
				"C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><" +
				"Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Styl" +
				"e parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style" +
				" parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Sty" +
				"le parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pa" +
				"rent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Name" +
				"dStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</La" +
				"yout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(134, 21);
			this.cmb_StyleCd.TabIndex = 535;
			this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(445, 62);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
			this.txt_StyleCd.TabIndex = 536;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// cmb_LocalDivision
			// 
			this.cmb_LocalDivision.AddItemCols = 0;
			this.cmb_LocalDivision.AddItemSeparator = ';';
			this.cmb_LocalDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LocalDivision.AutoSize = false;
			this.cmb_LocalDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LocalDivision.Caption = "";
			this.cmb_LocalDivision.CaptionHeight = 17;
			this.cmb_LocalDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LocalDivision.ColumnCaptionHeight = 18;
			this.cmb_LocalDivision.ColumnFooterHeight = 18;
			this.cmb_LocalDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LocalDivision.ContentHeight = 17;
			this.cmb_LocalDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LocalDivision.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LocalDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_LocalDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LocalDivision.EditorHeight = 17;
			this.cmb_LocalDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_LocalDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LocalDivision.GapHeight = 2;
			this.cmb_LocalDivision.ItemHeight = 15;
			this.cmb_LocalDivision.Location = new System.Drawing.Point(445, 40);
			this.cmb_LocalDivision.MatchEntryTimeout = ((long)(2000));
			this.cmb_LocalDivision.MaxDropDownItems = ((short)(5));
			this.cmb_LocalDivision.MaxLength = 32767;
			this.cmb_LocalDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LocalDivision.Name = "cmb_LocalDivision";
			this.cmb_LocalDivision.PartialRightColumn = false;
			this.cmb_LocalDivision.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LocalDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LocalDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LocalDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LocalDivision.Size = new System.Drawing.Size(210, 21);
			this.cmb_LocalDivision.TabIndex = 418;
			// 
			// lbl_Division
			// 
			this.lbl_Division.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Division.ImageIndex = 1;
			this.lbl_Division.ImageList = this.img_Label;
			this.lbl_Division.Location = new System.Drawing.Point(344, 40);
			this.lbl_Division.Name = "lbl_Division";
			this.lbl_Division.Size = new System.Drawing.Size(100, 21);
			this.lbl_Division.TabIndex = 417;
			this.lbl_Division.Text = "Division";
			this.lbl_Division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_To.Location = new System.Drawing.Point(220, 84);
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
			this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_To.Size = new System.Drawing.Size(99, 21);
			this.cmb_To.TabIndex = 416;
			this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
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
			this.cmb_From.Location = new System.Drawing.Point(109, 84);
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
			this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_From.Size = new System.Drawing.Size(99, 21);
			this.cmb_From.TabIndex = 415;
			this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
			// 
			// lbl_DP_DPO
			// 
			this.lbl_DP_DPO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DP_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DP_DPO.ImageIndex = 1;
			this.lbl_DP_DPO.ImageList = this.img_Label;
			this.lbl_DP_DPO.Location = new System.Drawing.Point(8, 84);
			this.lbl_DP_DPO.Name = "lbl_DP_DPO";
			this.lbl_DP_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DP_DPO.TabIndex = 414;
			this.lbl_DP_DPO.Text = "DP/ DPO";
			this.lbl_DP_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_SearchOption
			// 
			this.cmb_SearchOption.AddItemCols = 0;
			this.cmb_SearchOption.AddItemSeparator = ';';
			this.cmb_SearchOption.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_SearchOption.AutoSize = false;
			this.cmb_SearchOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_SearchOption.Caption = "";
			this.cmb_SearchOption.CaptionHeight = 17;
			this.cmb_SearchOption.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_SearchOption.ColumnCaptionHeight = 18;
			this.cmb_SearchOption.ColumnFooterHeight = 18;
			this.cmb_SearchOption.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_SearchOption.ContentHeight = 17;
			this.cmb_SearchOption.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_SearchOption.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_SearchOption.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_SearchOption.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_SearchOption.EditorHeight = 17;
			this.cmb_SearchOption.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_SearchOption.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SearchOption.GapHeight = 2;
			this.cmb_SearchOption.ItemHeight = 15;
			this.cmb_SearchOption.Location = new System.Drawing.Point(109, 62);
			this.cmb_SearchOption.MatchEntryTimeout = ((long)(2000));
			this.cmb_SearchOption.MaxDropDownItems = ((short)(5));
			this.cmb_SearchOption.MaxLength = 32767;
			this.cmb_SearchOption.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_SearchOption.Name = "cmb_SearchOption";
			this.cmb_SearchOption.PartialRightColumn = false;
			this.cmb_SearchOption.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_SearchOption.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_SearchOption.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_SearchOption.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_SearchOption.Size = new System.Drawing.Size(210, 21);
			this.cmb_SearchOption.TabIndex = 413;
			this.cmb_SearchOption.SelectedValueChanged += new System.EventHandler(this.cmb_SearchOption_SelectedValueChanged);
			// 
			// lbl_Option
			// 
			this.lbl_Option.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Option.ImageIndex = 1;
			this.lbl_Option.ImageList = this.img_Label;
			this.lbl_Option.Location = new System.Drawing.Point(8, 62);
			this.lbl_Option.Name = "lbl_Option";
			this.lbl_Option.Size = new System.Drawing.Size(100, 21);
			this.lbl_Option.TabIndex = 412;
			this.lbl_Option.Text = "Search Option";
			this.lbl_Option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblexcep_mark
			// 
			this.lblexcep_mark.Location = new System.Drawing.Point(208, 86);
			this.lblexcep_mark.Name = "lblexcep_mark";
			this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
			this.lblexcep_mark.TabIndex = 411;
			this.lblexcep_mark.Text = "~";
			this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(344, 62);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 405;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.label2.Text = "      MRP Shipping Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_Factory.TabIndex = 1;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
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
			this.spd_main.Size = new System.Drawing.Size(1000, 423);
			this.spd_main.TabIndex = 174;
			// 
			// cmenu_Grid
			// 
			this.cmenu_Grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem_DisplayStyleInfo});
			// 
			// menuItem_DisplayStyleInfo
			// 
			this.menuItem_DisplayStyleInfo.Index = 0;
			this.menuItem_DisplayStyleInfo.Text = "Display Style Information";
			// 
			// sheetView1
			// 
			this.sheetView1.SheetName = "Sheet1";
			// 
			// Form_BM_Shipping_Local_Search_ByStyle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_Shipping_Local_Search_ByStyle";
			this.Text = "Local/LLT Monitoring By Style";
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_low.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LocalDivision)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		 

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
		

			if(cmb_Factory.SelectedIndex == -1) return;

			DataTable dt_ret;

			// Search Option
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalSearchOption); //"SBM18"
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_SearchOption, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 


			// Local/ LLT Division
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalLLTDivision); //"SBP13"
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_LocalDivision, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 


			dt_ret.Dispose(); 


		}

	 
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				Set_StyleCode(e); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_SearchOption_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Change_SearchOption(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SearchOption_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void cmb_To_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				spd_main.ClearAll(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			this.Text = "Local/LLT Monitoring By Style";
			lbl_MainTitle.Text = "Local/LLT Monitoring By Style";

			// grid set
			spd_main.Set_Spread_Comm("SBM_SHIP_LOCAL_DP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			
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
						
						for ( int j = vCol ; j <= spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if(j == spd_main.ActiveSheet.ColumnCount)
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								vCol = j + 1;
								break;
							}
							else
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
							} // end if(j == spd_main.ActiveSheet.ColumnCount - 1)

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
			tbtn_Save.Enabled = false; 


			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
		  

			dt_ret.Dispose(); 
 



		}



		/// <summary>
		/// Set_StyleCode : 스타일 콤보 세팅
		/// </summary>
		private void Set_StyleCode(System.Windows.Forms.KeyEventArgs e)
		{

			if(e.KeyCode != Keys.Enter) return; 

			//-------------------------------------------------------------------------
			// 기타 콘트롤 초기화 
			cmb_StyleCd.SelectedIndex = -1;  

			//-------------------------------------------------------------------------

			DataTable dt_ret;
			
			if(txt_StyleCd.Text.Trim().Equals("") ) 
			{
				cmb_StyleCd.SelectedIndex = -1;
				cmb_StyleCd.DataSource = null;
				return;
			}

			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 

			string stylecd = "";
			int exist_index = -1;

			stylecd = txt_StyleCd.Text.Trim();

			exist_index = txt_StyleCd.Text.IndexOf("-", 0);

			if(exist_index == -1 && stylecd.Length == 9)
			{
				stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
			}
 
			cmb_StyleCd.SelectedValue = stylecd;

			dt_ret.Dispose();

		}



		private int _Default_ColumnCount = 0;


		/// <summary>
		/// Change_SearchOption : 
		/// </summary>
		private void Change_SearchOption()
		{
			
			if(cmb_Factory.SelectedIndex == -1 || cmb_SearchOption.SelectedIndex == -1) return;

			 
 
			// 그리드 헤더, from~to 세팅
			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					// grid set
					spd_main.Set_Spread_Comm("SBM_SHIP_LOCAL_DP", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					
					lbl_DP_DPO.Text = "DP"; 

					break;

				case _Search_DPO :

					// grid set
					spd_main.Set_Spread_Comm("SBM_SHIP_LOCAL_DPO", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			
					lbl_DP_DPO.Text = "DPO";

					break;
			}


			_Default_ColumnCount = spd_main.ActiveSheet.ColumnCount;

			
			DataTable dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), cmb_SearchOption.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
 


		}



		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_SearchOption.SelectedIndex = -1;
			lbl_DP_DPO.Text = "DP/ DPO";
			cmb_From.SelectedIndex = -1; 
			cmb_To.SelectedIndex = -1;
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1;
			cmb_LocalDivision.SelectedIndex = -1;
			 

			spd_main.ClearAll();  

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;


			string factory = cmb_Factory.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();
			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, "A"); 
			 


			spd_main.ActiveSheet.ColumnCount = _Default_ColumnCount;

			string[] parameter = new string[] {factory, style_cd, from, to, import};

			DataTable dt_ret = SELECT_SBM_DP_DPO_LIST(parameter); 
			 
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll();   
			}
 

			spd_main.Display_Grid(dt_ret); 



			// 컬럼 추가. 
			//SBM_SHIP_LOCAL, 51
			spd_main.Set_Spread_Comm("SBM_SHIP_LOCAL", "51", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false, false); 


			// Farpoint Spread Header Merge
			Mearge_GridHead();



			// column merge 
			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxDEL_MONTH,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxOBS_TYPE,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxSTYLE_CD,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxSTYLE_NAME,
																	    (int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxGEN,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxDEV_CD,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxSEASON,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxSEASON_YEAR,
																		(int)ClassLib.TBM_SHIPPING_LOCAL_DP.IxYIELD_COUNT} );



					break;

				case _Search_DPO :

					ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxOBS_ID,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxOBS_TYPE,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxSTYLE_CD,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxSTYLE_NAME,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxGEN,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxPST_YN,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxSEASON,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxSEASON_YEAR,
																		  (int)ClassLib.TBM_SHIPPING_LOCAL_DPO.IxYIELD_COUNT} ); 

					break;
			}
   

		}



		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{


			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return; 

			string factory = cmb_Factory.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();
			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, " ");  



			Pop_BM_Print_Type vPop = new Pop_BM_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);

			string sPara = "";
			string sDir = "";
			string report_text = ""; 

			if (vPop.ShowDialog() != DialogResult.OK) return;

			 
			string vPrintType = COM.ComVar.Parameter_PopUp[0];
			
			sPara  = " /rp ";
			sPara += "'" + factory  + "' ";
			sPara += "'" + style_cd + "' ";
			sPara += "'" + from     + "' ";
			sPara += "'" + to		+ "' ";
			sPara += "'" + import   + "' ";  

					

			

			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					switch (vPrintType)
					{
						case "10" : // DB   
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Search_ByStyle_DP.mrd"; 
							break;

						case "20" : // Text 
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Search_ByStyle_DP_2.mrd";
							break;

						default:
							break;
					}


					report_text = "Local/LLT Monitoring By Style (DP)"; 

					break;

				case _Search_DPO :

					
					switch (vPrintType)
					{
						case "10" : // DB   
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Search_ByStyle_DPO.mrd";
							break;

						case "20" : // Text 
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Search_ByStyle_DPO_2.mrd";
							break;

						default:
							break;
					}
					report_text = "Local/LLT Monitoring By Style (DPO)";

					break;
			}


			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
			MyReport.Text = report_text;
			MyReport.Show();

			 

		}



		#endregion 

		#region 그리드 이벤트 처리 메서드

		 

		#endregion 
	 
		#region 이벤트 처리시 사용되는 기능 메서드


		#endregion  

		
		#endregion

		#region DB Connect

		 

		/// <summary>
		/// SELECT_SBM_DP_DPO_LIST : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_SBM_DP_DPO_LIST(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, import};

				MyOraDB.ReDim_Parameter(6);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "";

				switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
				{
					case _Search_DP :

						MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SELECT_DP_LIST"; 

						break;

					case _Search_DPO :

						MyOraDB.Process_Name = "PKG_SBM_SHIPPING_LOCAL.SELECT_DPO_LIST"; 

						break;
				}


				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[4] = "ARG_IMPORT"; 
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4];
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBM_DP_DPO_LIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			return spd_main.ActiveSheet.RowCount;
		}

		#endregion

		 
		
 


	}
}

