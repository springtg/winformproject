using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Outgoing
{
	public class Form_BO_Outgoing_Outside : COM.PCHWinForm.Form_Top
	{
		#region 디자이너 생성 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_ToDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_Detail;
		private System.Windows.Forms.RadioButton rad_Header;
		private C1.Win.C1List.C1Combo cmb_OutDiv;
		private System.Windows.Forms.Label lbl_ProcessDiv;
		private System.Windows.Forms.DateTimePicker dpick_FromDate;
		private System.Windows.Forms.Label lbl_workYmd;
		private System.Windows.Forms.Label lbl_workProcess;
		private C1.Win.C1List.C1Combo cmb_Process;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label btn_Outside;
		private System.Windows.Forms.Label btn_DPOPrint;
		private System.Windows.Forms.ContextMenu cmenu_Outgoing;
		private System.Windows.Forms.MenuItem menuitem_CopyByStyle;
		private System.ComponentModel.IContainer components = null;

		public Form_BO_Outgoing_Outside()
		{
			InitializeComponent();
			initForm();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BO_Outgoing_Outside));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_DPOPrint = new System.Windows.Forms.Label();
			this.btn_Outside = new System.Windows.Forms.Label();
			this.lbl_between = new System.Windows.Forms.Label();
			this.dpick_ToDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_Detail = new System.Windows.Forms.RadioButton();
			this.rad_Header = new System.Windows.Forms.RadioButton();
			this.cmb_OutDiv = new C1.Win.C1List.C1Combo();
			this.lbl_ProcessDiv = new System.Windows.Forms.Label();
			this.dpick_FromDate = new System.Windows.Forms.DateTimePicker();
			this.lbl_workYmd = new System.Windows.Forms.Label();
			this.lbl_workProcess = new System.Windows.Forms.Label();
			this.cmb_Process = new C1.Win.C1List.C1Combo();
			this.cmb_Line = new C1.Win.C1List.C1Combo();
			this.lbl_workLine = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.fgrid_main = new COM.FSP();
			this.cmenu_Outgoing = new System.Windows.Forms.ContextMenu();
			this.menuitem_CopyByStyle = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.GridDefinition = "17.9310344827586:False:True;81.3793103448276:False:False;\t0.393700787401575:False" +
				":True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_DPOPrint);
			this.pnl_head.Controls.Add(this.btn_Outside);
			this.pnl_head.Controls.Add(this.lbl_between);
			this.pnl_head.Controls.Add(this.dpick_ToDate);
			this.pnl_head.Controls.Add(this.groupBox1);
			this.pnl_head.Controls.Add(this.cmb_OutDiv);
			this.pnl_head.Controls.Add(this.lbl_ProcessDiv);
			this.pnl_head.Controls.Add(this.dpick_FromDate);
			this.pnl_head.Controls.Add(this.lbl_workYmd);
			this.pnl_head.Controls.Add(this.lbl_workProcess);
			this.pnl_head.Controls.Add(this.cmb_Process);
			this.pnl_head.Controls.Add(this.cmb_Line);
			this.pnl_head.Controls.Add(this.lbl_workLine);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1000, 104);
			this.pnl_head.TabIndex = 1;
			// 
			// btn_DPOPrint
			// 
			this.btn_DPOPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DPOPrint.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_DPOPrint.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_DPOPrint.ImageIndex = 0;
			this.btn_DPOPrint.ImageList = this.img_Button;
			this.btn_DPOPrint.Location = new System.Drawing.Point(913, 72);
			this.btn_DPOPrint.Name = "btn_DPOPrint";
			this.btn_DPOPrint.Size = new System.Drawing.Size(80, 23);
			this.btn_DPOPrint.TabIndex = 409;
			this.btn_DPOPrint.Text = "DPO Search";
			this.btn_DPOPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_DPOPrint.Click += new System.EventHandler(this.btn_DPOPrint_Click);
			// 
			// btn_Outside
			// 
			this.btn_Outside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Outside.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Outside.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_Outside.ImageIndex = 0;
			this.btn_Outside.ImageList = this.img_Button;
			this.btn_Outside.Location = new System.Drawing.Point(832, 72);
			this.btn_Outside.Name = "btn_Outside";
			this.btn_Outside.Size = new System.Drawing.Size(80, 23);
			this.btn_Outside.TabIndex = 408;
			this.btn_Outside.Text = "Outside";
			this.btn_Outside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Outside.Click += new System.EventHandler(this.btn_Outside_Click);
			// 
			// lbl_between
			// 
			this.lbl_between.Location = new System.Drawing.Point(211, 78);
			this.lbl_between.Name = "lbl_between";
			this.lbl_between.Size = new System.Drawing.Size(16, 16);
			this.lbl_between.TabIndex = 405;
			this.lbl_between.Text = "~";
			// 
			// dpick_ToDate
			// 
			this.dpick_ToDate.CustomFormat = "";
			this.dpick_ToDate.Enabled = false;
			this.dpick_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToDate.Location = new System.Drawing.Point(231, 78);
			this.dpick_ToDate.Name = "dpick_ToDate";
			this.dpick_ToDate.Size = new System.Drawing.Size(99, 21);
			this.dpick_ToDate.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_Detail);
			this.groupBox1.Controls.Add(this.rad_Header);
			this.groupBox1.Location = new System.Drawing.Point(832, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(162, 38);
			this.groupBox1.TabIndex = 401;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_Detail
			// 
			this.rad_Detail.Location = new System.Drawing.Point(87, 16);
			this.rad_Detail.Name = "rad_Detail";
			this.rad_Detail.Size = new System.Drawing.Size(72, 16);
			this.rad_Detail.TabIndex = 396;
			this.rad_Detail.Tag = "2";
			this.rad_Detail.Text = "Detaile";
			this.rad_Detail.CheckedChanged += new System.EventHandler(this.rad_Detail_CheckedChanged);
			// 
			// rad_Header
			// 
			this.rad_Header.Checked = true;
			this.rad_Header.Location = new System.Drawing.Point(8, 16);
			this.rad_Header.Name = "rad_Header";
			this.rad_Header.Size = new System.Drawing.Size(72, 16);
			this.rad_Header.TabIndex = 395;
			this.rad_Header.TabStop = true;
			this.rad_Header.Tag = "1";
			this.rad_Header.Text = "Header";
			this.rad_Header.CheckedChanged += new System.EventHandler(this.rad_Header_CheckedChanged);
			// 
			// cmb_OutDiv
			// 
			this.cmb_OutDiv.AddItemCols = 0;
			this.cmb_OutDiv.AddItemSeparator = ';';
			this.cmb_OutDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OutDiv.AutoSize = false;
			this.cmb_OutDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OutDiv.Caption = "";
			this.cmb_OutDiv.CaptionHeight = 17;
			this.cmb_OutDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OutDiv.ColumnCaptionHeight = 18;
			this.cmb_OutDiv.ColumnFooterHeight = 18;
			this.cmb_OutDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OutDiv.ContentHeight = 17;
			this.cmb_OutDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OutDiv.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_OutDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_OutDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OutDiv.EditorHeight = 17;
			this.cmb_OutDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_OutDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OutDiv.GapHeight = 2;
			this.cmb_OutDiv.ItemHeight = 15;
			this.cmb_OutDiv.Location = new System.Drawing.Point(109, 56);
			this.cmb_OutDiv.MatchEntryTimeout = ((long)(2000));
			this.cmb_OutDiv.MaxDropDownItems = ((short)(5));
			this.cmb_OutDiv.MaxLength = 32767;
			this.cmb_OutDiv.MouseCursor = System.Windows.Forms.Cursors.IBeam;
			this.cmb_OutDiv.Name = "cmb_OutDiv";
			this.cmb_OutDiv.PartialRightColumn = false;
			this.cmb_OutDiv.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OutDiv.ReadOnly = true;
			this.cmb_OutDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OutDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OutDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OutDiv.Size = new System.Drawing.Size(220, 21);
			this.cmb_OutDiv.TabIndex = 397;
			// 
			// lbl_ProcessDiv
			// 
			this.lbl_ProcessDiv.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ProcessDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ProcessDiv.ImageIndex = 0;
			this.lbl_ProcessDiv.ImageList = this.img_Label;
			this.lbl_ProcessDiv.Location = new System.Drawing.Point(8, 56);
			this.lbl_ProcessDiv.Name = "lbl_ProcessDiv";
			this.lbl_ProcessDiv.Size = new System.Drawing.Size(100, 21);
			this.lbl_ProcessDiv.TabIndex = 398;
			this.lbl_ProcessDiv.Text = "Out Division";
			this.lbl_ProcessDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_FromDate
			// 
			this.dpick_FromDate.CustomFormat = "";
			this.dpick_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromDate.Location = new System.Drawing.Point(109, 78);
			this.dpick_FromDate.Name = "dpick_FromDate";
			this.dpick_FromDate.Size = new System.Drawing.Size(99, 21);
			this.dpick_FromDate.TabIndex = 5;
			this.dpick_FromDate.ValueChanged += new System.EventHandler(this.dpick_FromDate_ValueChanged);
			// 
			// lbl_workYmd
			// 
			this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_workYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_workYmd.ImageIndex = 0;
			this.lbl_workYmd.ImageList = this.img_Label;
			this.lbl_workYmd.Location = new System.Drawing.Point(8, 78);
			this.lbl_workYmd.Name = "lbl_workYmd";
			this.lbl_workYmd.Size = new System.Drawing.Size(100, 21);
			this.lbl_workYmd.TabIndex = 50;
			this.lbl_workYmd.Text = "Work Date";
			this.lbl_workYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_workProcess
			// 
			this.lbl_workProcess.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_workProcess.ImageIndex = 0;
			this.lbl_workProcess.ImageList = this.img_Label;
			this.lbl_workProcess.Location = new System.Drawing.Point(344, 34);
			this.lbl_workProcess.Name = "lbl_workProcess";
			this.lbl_workProcess.Size = new System.Drawing.Size(100, 21);
			this.lbl_workProcess.TabIndex = 379;
			this.lbl_workProcess.Text = "Process";
			this.lbl_workProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Process
			// 
			this.cmb_Process.AddItemCols = 0;
			this.cmb_Process.AddItemSeparator = ';';
			this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Process.AutoSize = false;
			this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Process.Caption = "";
			this.cmb_Process.CaptionHeight = 17;
			this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Process.ColumnCaptionHeight = 18;
			this.cmb_Process.ColumnFooterHeight = 18;
			this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Process.ContentHeight = 17;
			this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Process.EditorHeight = 17;
			this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Process.GapHeight = 2;
			this.cmb_Process.ItemHeight = 15;
			this.cmb_Process.Location = new System.Drawing.Point(445, 34);
			this.cmb_Process.MatchEntryTimeout = ((long)(2000));
			this.cmb_Process.MaxDropDownItems = ((short)(5));
			this.cmb_Process.MaxLength = 32767;
			this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Process.Name = "cmb_Process";
			this.cmb_Process.PartialRightColumn = false;
			this.cmb_Process.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Process.Size = new System.Drawing.Size(220, 21);
			this.cmb_Process.TabIndex = 0;
			// 
			// cmb_Line
			// 
			this.cmb_Line.AddItemCols = 0;
			this.cmb_Line.AddItemSeparator = ';';
			this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Line.AutoSize = false;
			this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Line.Caption = "";
			this.cmb_Line.CaptionHeight = 17;
			this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Line.ColumnCaptionHeight = 18;
			this.cmb_Line.ColumnFooterHeight = 18;
			this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Line.ContentHeight = 17;
			this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Line.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Line.EditorHeight = 17;
			this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Line.GapHeight = 2;
			this.cmb_Line.ItemHeight = 15;
			this.cmb_Line.Location = new System.Drawing.Point(445, 56);
			this.cmb_Line.MatchEntryTimeout = ((long)(2000));
			this.cmb_Line.MaxDropDownItems = ((short)(5));
			this.cmb_Line.MaxLength = 32767;
			this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Line.Name = "cmb_Line";
			this.cmb_Line.PartialRightColumn = false;
			this.cmb_Line.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Line.Size = new System.Drawing.Size(220, 21);
			this.cmb_Line.TabIndex = 8;
			// 
			// lbl_workLine
			// 
			this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_workLine.ImageIndex = 0;
			this.lbl_workLine.ImageList = this.img_Label;
			this.lbl_workLine.Location = new System.Drawing.Point(344, 56);
			this.lbl_workLine.Name = "lbl_workLine";
			this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
			this.lbl_workLine.TabIndex = 375;
			this.lbl_workLine.Text = "Line";
			this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(109, 34);
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_Factory.TabIndex = 1;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 88);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 87);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(960, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 34);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 63);
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
			this.label2.Text = "      Outgoing Production Info";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 77);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ContextMenu = this.cmenu_Outgoing;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 108);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 13;
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// cmenu_Outgoing
			// 
			this.cmenu_Outgoing.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuitem_CopyByStyle});
			this.cmenu_Outgoing.Popup += new System.EventHandler(this.cmenu_Outgoing_Popup);
			// 
			// menuitem_CopyByStyle
			// 
			this.menuitem_CopyByStyle.Index = 0;
			this.menuitem_CopyByStyle.Text = "Copy by Style";
			this.menuitem_CopyByStyle.Click += new System.EventHandler(this.menuitem_CopyByStyle_Click);
			// 
			// Form_BO_Outgoing_Outside
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BO_Outgoing_Outside";
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private const string FLAG_SAVE = "S", FLAG_CONFIRM = "C", VALUE_SAVE = "Save", VALUE_CONFIRM = "Confirm";

		private string _dateFormat = "yyyyMMdd";
		private int _Level_Total = 1;
		private string _curStatus = FLAG_SAVE;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _popWait = null;


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언    




		#endregion

		#region 이벤트 핸들러

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			gridBeforeEdit();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_main.Update_Row();
			gridAfterEdit();
		}

		/******************************************************************************/
		/******************************************************************************/
		/******************************************************************************/

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			bindData();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			saveData();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			print();
		}

		
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            confirm();
		}

		/******************************************************************************/
		/******************************************************************************/
		/******************************************************************************/

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{	 
				if(cmb_Factory.SelectedIndex == -1) return;  
			
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;

				DataTable dt_ret;

				//process setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Process, 1, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 

				//line setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  
  
				dt_ret.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void rad_Header_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(1);
		}

		private void rad_Detail_CheckedChanged(object sender, System.EventArgs e)
		{
			fgrid_main.Tree.Show(2);
		}

		private void dpick_FromDate_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_ToDate.Value = dpick_FromDate.Value;
		}

		private void btn_Outside_Click(object sender, System.EventArgs e)
		{
			Btn_OutsideProcess();
		}

		private void btn_DPOPrint_Click(object sender, System.EventArgs e)
		{
			Btn_DPOSearch();
		}

		#endregion


		#region 이벤트 처리

		private void initForm()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				// Form Setting
				lbl_MainTitle.Text = "Outgoing Outside Production - Outside";
				this.Text		   = "Outgoing Outside Production - Outside";

				ClassLib.ComFunction.SetLangDic(this); 

				// Grid Setting
				fgrid_main.Set_Grid("SBO_OUT_EXPEND", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

				fgrid_main.Rows[0].AllowMerging = true;
				fgrid_main.Rows[1].AllowMerging = true;
				fgrid_main.Set_Action_Image(img_Action);
 

				// Factory Combobox Setting
				DataTable vDt = null;
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false);
				vDt.Dispose();
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

				// Process Outgoing division set    cmb_outDiv
				vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
				COM.ComCtl.Set_ComboList(vDt, cmb_OutDiv, 1, 2, false, 56, 0);
                cmb_OutDiv.SelectedIndex = 0;
				vDt.Dispose();

				// 초기 버튼 권한 설정 : 조회만을 위함
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "init", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void gridBeforeEdit()
		{
			try
			{
				if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed) )
					fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_BeforeEditProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void gridAfterEdit()
		{
			try
			{
				int dirQtyCol = (int)ClassLib.TBSBO_OUT_EXPEND.IxDIR_QTY;
				int outQtyCol = (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_QTY;
				int vCurRow = fgrid_main.Row, vCurCol = fgrid_main.Col;

				if (vCurCol != outQtyCol)
				{
					fgrid_main.Update_Row();
					return;
				}
				
				if (fgrid_main.Rows[vCurRow].Node.Level == 1)
				{
					Node vParNode = fgrid_main.Rows[vCurRow].Node;

					int fc = vParNode.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int lc = vParNode.GetNode(NodeTypeEnum.LastChild).Row.Index;

					CellRange cr = fgrid_main.GetCellRange(fc, dirQtyCol, lc, dirQtyCol);
					double vOrgQty = fgrid_main.Aggregate(AggregateEnum.Sum, cr);
					double vCurQty = nullToDouble(fgrid_main[vCurRow, vCurCol]);
					double vTempQty = 0;
					int vSumQty = 0, vMaxRow = fc;

					if ( vOrgQty == 0 )
					{
						fgrid_main[fc, vCurCol] = (int)Math.Round(vCurQty);
						fgrid_main.Update_Row(fc);
					}
					else
					{
						for (int row = fc ; row <= lc ; row++)
						{
							vTempQty = nullToDouble(fgrid_main[row, dirQtyCol]) * vCurQty / vOrgQty;
							vSumQty += (int)Math.Round(vTempQty);
							fgrid_main[row, vCurCol] = (int)Math.Round(vTempQty);
							fgrid_main.Update_Row(row);

							if (nullToDouble(fgrid_main[row, vCurCol]) < vTempQty)
								vMaxRow = row;
						}

						// 합계 보정
						fgrid_main[vMaxRow, vCurCol] = (int)nullToDouble(fgrid_main[vMaxRow, vCurCol]) + ( vCurQty - vSumQty );
					}

				}
				else
				{
					Node vParNode = fgrid_main.Rows[vCurRow].Node.GetNode(NodeTypeEnum.Parent);

					int fc = vParNode.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int lc = vParNode.GetNode(NodeTypeEnum.LastChild).Row.Index;

					CellRange cr = fgrid_main.GetCellRange(fc, outQtyCol, lc, outQtyCol);
					vParNode.Row[outQtyCol] = fgrid_main.Aggregate(AggregateEnum.Sum, cr);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_BeforeEditProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void bindData()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory			= ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				string vOutDivision		= ClassLib.ComFunction.Empty_Combo(cmb_OutDiv, "");
				string vOutYmdFrom		= dpick_FromDate.Value.ToString(_dateFormat);
				string vOutYmdTo		= dpick_ToDate.Value.ToString(_dateFormat);
				string vProcess			= ClassLib.ComFunction.Empty_Combo(cmb_Process, "");
				string vLine			= ClassLib.ComFunction.Empty_Combo(cmb_Line, "");

				DataTable vDt = this.SELECT_SBO_OUT_EXPEND_LIST(vFactory, vOutDivision, vOutYmdFrom, vOutYmdTo, vProcess, vLine);

				if ( vDt != null )
				{
					displayData(vDt);
					gridAllowEditing();
					
					fgrid_main.Tree.Column = (int)ClassLib.TBSBO_OUT_EXPEND.IxITEM_NAME;;
					rad_Header.Checked = true;
					fgrid_main.Tree.Show(1);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				ClassLib.ComFunction.User_Message(ex.Message, "bindData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		private void saveData()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				SAVE_SBO_OUT_EXPEND ();
				fgrid_main.ClearFlags();
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave , this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave , this);
				ClassLib.ComFunction.User_Message(ex.Message, "saveData", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void print()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				ClassLib.ComVar.Parameter_PopUp_Object = new object[6];
								
				ClassLib.ComVar.Parameter_PopUp_Object[0] = cmb_Factory.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[1] = cmb_OutDiv.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[2] = dpick_FromDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[3] = dpick_ToDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[4] = cmb_Process.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[5] = cmb_Line.SelectedValue;

				Form_BO_Outside_Normal_Print pop_print = new Form_BO_Outside_Normal_Print();
				pop_print.ShowDialog();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.WaitCursor;
			}
		}

		private void confirm()
		{
			// 입력 조건 검사
			if (fgrid_main.Rows.Fixed >= fgrid_main.Rows.Count)
			{
				ClassLib.ComFunction.Data_Message("Confirm", ClassLib.ComVar.MgsNotHaveData, this);
				return;
			}

			DialogResult result = ClassLib.ComFunction.Data_Message("Confirm", ClassLib.ComVar.MgsChooseOK, this);
			if (result == DialogResult.No)
				return;

			Pop_BO_Outgoing_RealYmd pop_ymd = new Pop_BO_Outgoing_RealYmd();

			try
			{
				ClassLib.ComVar.Parameter_PopUp_Object = new object[2]; 
				ClassLib.ComVar.Parameter_PopUp_Object[0] = "Select Real Outgoing Date";
				ClassLib.ComVar.Parameter_PopUp_Object[1] = dpick_FromDate.Value;

				if (_curStatus.Equals(FLAG_SAVE))
					result = pop_ymd.ShowDialog();
				else
					result = DialogResult.OK;

				if (result == DialogResult.OK)
				{
					string factory = cmb_Factory.SelectedValue.ToString(); 
					string out_division = cmb_OutDiv.SelectedValue.ToString(); 
					string out_ymd_from = dpick_FromDate.Text.Replace("-", "");
					string out_ymd_to = dpick_ToDate.Text.Replace("-", ""); 
					string process = cmb_Process.SelectedValue.ToString();  
					string line = cmb_Line.SelectedValue.ToString(); 
					string real_out_ymd = ClassLib.ComVar.Parameter_PopUp == null ? "" : ClassLib.ComVar.Parameter_PopUp[0];
					
					if (_curStatus.Equals(FLAG_SAVE))
						this.saveData();

					if (CONFIRM_SBO_OUT_EXPEND(factory, out_division, out_ymd_from, out_ymd_to, process, line, real_out_ymd))
					{
						for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
						{
							string status = ClassLib.ComFunction.NullToBlank(fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS]);
							if (status.Equals(FLAG_SAVE))
							{
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxREAL_OUT_YMD] = real_out_ymd;
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS] = FLAG_CONFIRM;
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS_VALUE] = VALUE_CONFIRM;
							}
							else
							{
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxREAL_OUT_YMD] = "";
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS] = FLAG_SAVE;
								fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS_VALUE] = VALUE_SAVE;
							}
						}

						this.gridAllowEditing();
						ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsEndRun, this);
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				pop_ymd.Dispose();
			}
		}

		private void Btn_OutsideProcess()
		{
			try
			{
				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				DialogResult result = ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsChooseRun, this);
				if(result == DialogResult.No) return;

				


                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunOutside));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_UsageProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 
		}


        public void RunOutside()
        {
            Invoke(new DelegateSetn(Run_Outside)); // 폼 스레드에 작업 넘김

        }



		private void Btn_DPOSearch()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				ClassLib.ComVar.Parameter_PopUp_Object = new object[6];
								
				ClassLib.ComVar.Parameter_PopUp_Object[0] = cmb_Factory.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[1] = cmb_OutDiv.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[2] = dpick_FromDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[3] = dpick_ToDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[4] = cmb_Process.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[5] = cmb_Line.SelectedValue;

				Form_BO_Outside_Normal_Print_DPO pop_print = new Form_BO_Outside_Normal_Print_DPO();
				pop_print.ShowDialog();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.WaitCursor;
			}
		}


		private void Run_Outside()
		{

			try
			{
				COM.ComFunction MyComFunction = new COM.ComFunction();

				this.Cursor = Cursors.WaitCursor;

				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString();  
				string upd_user = ClassLib.ComVar.This_User;

				bool run_flag = Run_OUT_USAGE_Outside(factory, out_division, out_ymd_from, out_ymd_to, process, upd_user);
 
				if(run_flag)
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsEndRun, this);
					bindData();
				}
				else
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsDoNotRun, this);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Usage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun , this);

				if(_popWait != null) _popWait.Close();
			} 
		}


		#endregion


		#region 기타

		private void displayData(DataTable arg_dt)
		{
			try
			{
				fgrid_main.ClearAll();
				int level = 0; 
				int row_fixed = fgrid_main.Rows.Fixed;

				for (int i = 0 ; i < arg_dt.Rows.Count ; i++)
				{
					level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[0]);
					C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(row_fixed + i, level);

					// data setting
					fgrid_main[newRow.Row.Index, 0] = "";
					for (int j = 1 ; j < arg_dt.Columns.Count ; j++)
					{
						fgrid_main[newRow.Row.Index, j] = arg_dt.Rows[i].ItemArray[j];
					}

					// design setting
					if (level == _Level_Total)  // SubTotal 
					{
						newRow.Row.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						newRow.Row.AllowEditing = true;
					}
					else
					{
						newRow.Row.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						newRow.Row.AllowEditing = true;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private double nullToDouble(object arg_obj)
		{
			if (arg_obj != null)
			{
				if (!arg_obj.ToString().Equals(""))
				{
					return Convert.ToDouble(arg_obj);
				}
			}

			return 0;
		}

		private void gridAllowEditing()
		{
			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				string status = ClassLib.ComFunction.NullToBlank(fgrid_main[row, (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_STATUS]);
				_curStatus = status;

				if (status.Equals(FLAG_SAVE))
				{
					fgrid_main.Rows[row].AllowEditing = true;
				}
				else
				{
					fgrid_main.Rows[row].AllowEditing = false;
				}
			}
		}

		#endregion


		#region 데이터베이스

		/// <summary>
		/// SELECT_SBO_OUT_EXPEND_LIST
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private DataTable SELECT_SBO_OUT_EXPEND_LIST (
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line)
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SELECT_SBO_OUT_EXPEND_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_division;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_process;
			MyOraDB.Parameter_Values[5] = arg_line;
			MyOraDB.Parameter_Values[6] = "";  

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 
			if(ds_ret.Tables.Count == 0) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// CONFIRM_SBO_OUT_EXPEND_LIST
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private bool CONFIRM_SBO_OUT_EXPEND (
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line, 
			string arg_real_out_ymd)
		{
			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.CONFIRM_SBO_OUT_EXPEND";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[6] = "ARG_REAL_OUT_YMD";  
			MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_division;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_process;
			MyOraDB.Parameter_Values[5] = arg_line;
			MyOraDB.Parameter_Values[6] = arg_real_out_ymd;
			MyOraDB.Parameter_Values[7] = COM.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			DataSet vDs = MyOraDB.Exe_Modify_Procedure();

			if (vDs == null)
				return false;
			else
				return true;
		}


		/// <summary>
		/// SAVE_SBO_OUT_EXPEND
		/// </summary>
		private void SAVE_SBO_OUT_EXPEND ()
		{
			try
			{
				int startCol = (int)ClassLib.TBSBO_OUT_EXPEND.IxOUT_QTY;
				int userCol = (int)ClassLib.TBSBO_OUT_EXPEND.IxUPD_USER;

				MyOraDB.ReDim_Parameter(16);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SAVE_SBO_OUT_EXPEND";

				/*
				ARG_OUT_QTY          IN VARCHAR2,        ARG_REMARKS         IN VARCHAR2,
				ARG_FACTORY          IN VARCHAR2,        ARG_OUT_YMD         IN VARCHAR2, 
				ARG_OUT_PROCESS      IN VARCHAR2,        ARG_OUT_LINE        IN VARCHAR2, 
				ARG_STYLE_CD         IN VARCHAR2,        ARG_COMPONENT_CD    IN VARCHAR2, 
				ARG_LOT_NO           IN VARCHAR2,        ARG_LOT_SEQ         IN VARCHAR2, 
				ARG_ITEM_CD          IN VARCHAR2,        ARG_SPEC_CD         IN VARCHAR2, 
				ARG_COLOR_CD         IN VARCHAR2,        ARG_UPD_USER        IN VARCHAR2 )
				*/

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_OUT_QTY";
				MyOraDB.Parameter_Name[1] = "ARG_REAL_OUT_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_STATUS";
				MyOraDB.Parameter_Name[3] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[4] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[5] = "ARG_OUT_YMD";
				MyOraDB.Parameter_Name[6] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[7] = "ARG_OUT_LINE";
				MyOraDB.Parameter_Name[8] = "ARG_STYLE_CD";  
				MyOraDB.Parameter_Name[9] = "ARG_COMPONENT_CD";  
				MyOraDB.Parameter_Name[10] = "ARG_LOT_NO";  
				MyOraDB.Parameter_Name[11] = "ARG_LOT_SEQ";  
				MyOraDB.Parameter_Name[12] = "ARG_ITEM_CD";  
				MyOraDB.Parameter_Name[13] = "ARG_SPEC_CD";  
				MyOraDB.Parameter_Name[14] = "ARG_COLOR_CD";  
				MyOraDB.Parameter_Name[15] = "ARG_UPD_USER";


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
				MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;


				ArrayList vList = new ArrayList();
				
				//04.DATA 정의
				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, 0]).Equals(ClassLib.ComVar.Update))
					{
						for (int vCol = startCol ; vCol <= (int)ClassLib.TBSBO_OUT_EXPEND.IxUPD_USER ; vCol++)
						{
							fgrid_main[vRow, userCol] = ClassLib.ComVar.This_User;
							vList.Add(ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, vCol]));
						}
					}
				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				//05.실행
				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Run_OUT_USAGE_Outside : 공정 불출 소요량 계산
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns></returns>
		private bool Run_OUT_USAGE_Outside(
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_upd_user)
		{
			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.RUN_OUT_USAGE_EXPEND";

				string _Factory = ClassLib.ComVar.This_Factory;

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_division;
				MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
				MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
				MyOraDB.Parameter_Values[4] = arg_process;
				MyOraDB.Parameter_Values[5] = arg_upd_user;

				MyOraDB.Add_Modify_Parameter(true);
				ds_ret = MyOraDB.Exe_Modify_Procedure(); 

				if(ds_ret == null)
					return false;
				else
					return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion

		private void menuitem_CopyByStyle_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				ClassLib.ComVar.Parameter_PopUp_Object = new object[9];
								
				ClassLib.ComVar.Parameter_PopUp_Object[0] = cmb_Factory.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[1] = cmb_OutDiv.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[2] = dpick_FromDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[3] = dpick_ToDate.Value;
				ClassLib.ComVar.Parameter_PopUp_Object[4] = cmb_Process.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[5] = cmb_Line.SelectedValue;
				ClassLib.ComVar.Parameter_PopUp_Object[6] = fgrid_main[fgrid_main.Selection.r1, 1].ToString().Replace("-", "");
				ClassLib.ComVar.Parameter_PopUp_Object[7] = fgrid_main[fgrid_main.Selection.r1, 4].ToString().Substring(0, 9);
				ClassLib.ComVar.Parameter_PopUp_Object[8] = fgrid_main[fgrid_main.Selection.r1, 4].ToString().Substring(10, 2);

				POP_BO_Outgoing_Outside_Copy pop_copy = new POP_BO_Outgoing_Outside_Copy();
				pop_copy.ShowDialog();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.WaitCursor;
			}
		}

		private void cmenu_Outgoing_Popup(object sender, System.EventArgs e)
		{

			
			try
			{

				if(fgrid_main.Rows.Count < fgrid_main.Rows.Fixed) 
				{
					//menuitem_CopyByStyle.Visible = false;
					menuitem_CopyByStyle.Enabled = false;
				}
				else
				{
					if(fgrid_main.Rows[fgrid_main.Selection.r1].StyleNew.BackColor == ClassLib.ComVar.ClrLevel_3rd)
					{
						//menuitem_CopyByStyle.Visible = true;
						menuitem_CopyByStyle.Enabled = true;
					}
					else
					{
						//menuitem_CopyByStyle.Visible = false;
						menuitem_CopyByStyle.Enabled = false;
					}
				}



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Outgoing_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
				 
		}

	}
}

