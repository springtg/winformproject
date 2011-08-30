//using System;
//using System.Collections;
//using System.ComponentModel;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Data;
//using C1.Win.C1FlexGrid;
//using System.Data.OracleClient;
//using System.IO;


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
using System.Xml;
using System.IO;


namespace FlexCDC.MRP
{
	public class Form_MRP_Manager : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_MRP_No;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label lbl_Close;
		private System.Windows.Forms.CheckBox chk_Close;
		private System.Windows.Forms.Panel pnl_grid;
  
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_MRP;
		private System.Windows.Forms.Label lbl_Dash;
		private System.Windows.Forms.DateTimePicker dtp_From_Date;
		private System.Windows.Forms.DateTimePicker dtp_To_Date;
		private System.Windows.Forms.Label lbl_Prod_Ymd;
		private System.Windows.Forms.DateTimePicker dtp_Mrp_date;
		private System.Windows.Forms.Button btn_Next;
		private System.Windows.Forms.ContextMenu ctm_Menu;
		private System.Windows.Forms.MenuItem mnt_IncludingMrp;
		private System.Windows.Forms.MenuItem mnt_NotIncludingMrp;
		private System.Windows.Forms.MenuItem mnt_Bar1;
		private System.Windows.Forms.MenuItem mnt_Ready;
		private System.Windows.Forms.MenuItem mnt_Editing;
		private System.Windows.Forms.MenuItem mnt_Confirmed;
		private System.Windows.Forms.MenuItem mnt_Canceled;
		private System.Windows.Forms.MenuItem mnt_Closed;
		private System.Windows.Forms.MenuItem mnt_Bar2;
		private System.Windows.Forms.MenuItem mnt_Mrp;
		private System.Windows.Forms.MenuItem mnt_Bom;



		#region 사전정의 변수
		private string _loadingfromtype ="";
		#endregion 



		public Form_MRP_Manager()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			 _loadingfromtype = ClassLib.ComVar.ConsCDC_LoadingFrom_Type;

		}


			
		public Form_MRP_Manager(Form_MRP_Check arg_frm , string arg_job_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();


			_loadingfromtype  = arg_job_type;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_MRP_Manager));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_Next = new System.Windows.Forms.Button();
			this.dtp_Mrp_date = new System.Windows.Forms.DateTimePicker();
			this.lbl_Dash = new System.Windows.Forms.Label();
			this.lbl_Prod_Ymd = new System.Windows.Forms.Label();
			this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
			this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
			this.chk_Close = new System.Windows.Forms.CheckBox();
			this.lbl_Close = new System.Windows.Forms.Label();
			this.lbl_MRP_No = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_grid = new System.Windows.Forms.Panel();
			this.fgrid_MRP = new COM.FSP();
			this.ctm_Menu = new System.Windows.Forms.ContextMenu();
			this.mnt_IncludingMrp = new System.Windows.Forms.MenuItem();
			this.mnt_NotIncludingMrp = new System.Windows.Forms.MenuItem();
			this.mnt_Bar1 = new System.Windows.Forms.MenuItem();
			this.mnt_Ready = new System.Windows.Forms.MenuItem();
			this.mnt_Editing = new System.Windows.Forms.MenuItem();
			this.mnt_Confirmed = new System.Windows.Forms.MenuItem();
			this.mnt_Canceled = new System.Windows.Forms.MenuItem();
			this.mnt_Closed = new System.Windows.Forms.MenuItem();
			this.mnt_Bar2 = new System.Windows.Forms.MenuItem();
			this.mnt_Mrp = new System.Windows.Forms.MenuItem();
			this.mnt_Bom = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_grid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MRP)).BeginInit();
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
			this.lbl_MainTitle.Text = "Pcc MRP Plan Manager";
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 80);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 112);
			this.pnl_Search.TabIndex = 34;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_Next);
			this.pnl_SearchImage.Controls.Add(this.dtp_Mrp_date);
			this.pnl_SearchImage.Controls.Add(this.lbl_Dash);
			this.pnl_SearchImage.Controls.Add(this.lbl_Prod_Ymd);
			this.pnl_SearchImage.Controls.Add(this.dtp_From_Date);
			this.pnl_SearchImage.Controls.Add(this.dtp_To_Date);
			this.pnl_SearchImage.Controls.Add(this.chk_Close);
			this.pnl_SearchImage.Controls.Add(this.lbl_Close);
			this.pnl_SearchImage.Controls.Add(this.lbl_MRP_No);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 96);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_Next
			// 
			this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.btn_Next.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Next.Location = new System.Drawing.Point(891, 62);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(100, 23);
			this.btn_Next.TabIndex = 494;
			this.btn_Next.Text = "Next";
			this.btn_Next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// dtp_Mrp_date
			// 
			this.dtp_Mrp_date.CustomFormat = "yyyyMMdd";
			this.dtp_Mrp_date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtp_Mrp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Mrp_date.Location = new System.Drawing.Point(445, 41);
			this.dtp_Mrp_date.Name = "dtp_Mrp_date";
			this.dtp_Mrp_date.Size = new System.Drawing.Size(211, 21);
			this.dtp_Mrp_date.TabIndex = 491;
			this.dtp_Mrp_date.ValueChanged += new System.EventHandler(this.dtp_Mrp_date_ValueChanged);
			// 
			// lbl_Dash
			// 
			this.lbl_Dash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Dash.Location = new System.Drawing.Point(880, 40);
			this.lbl_Dash.Name = "lbl_Dash";
			this.lbl_Dash.Size = new System.Drawing.Size(14, 20);
			this.lbl_Dash.TabIndex = 487;
			this.lbl_Dash.Text = "~";
			// 
			// lbl_Prod_Ymd
			// 
			this.lbl_Prod_Ymd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Prod_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Prod_Ymd.ImageIndex = 0;
			this.lbl_Prod_Ymd.ImageList = this.img_Label;
			this.lbl_Prod_Ymd.Location = new System.Drawing.Point(680, 40);
			this.lbl_Prod_Ymd.Name = "lbl_Prod_Ymd";
			this.lbl_Prod_Ymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_Prod_Ymd.TabIndex = 486;
			this.lbl_Prod_Ymd.Text = "Prod Date";
			this.lbl_Prod_Ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_From_Date
			// 
			this.dtp_From_Date.CustomFormat = "yyyyMMdd";
			this.dtp_From_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtp_From_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_From_Date.Location = new System.Drawing.Point(784, 40);
			this.dtp_From_Date.Name = "dtp_From_Date";
			this.dtp_From_Date.Size = new System.Drawing.Size(95, 21);
			this.dtp_From_Date.TabIndex = 485;
			// 
			// dtp_To_Date
			// 
			this.dtp_To_Date.CustomFormat = "yyyyMMdd";
			this.dtp_To_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtp_To_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_To_Date.Location = new System.Drawing.Point(896, 40);
			this.dtp_To_Date.Name = "dtp_To_Date";
			this.dtp_To_Date.Size = new System.Drawing.Size(95, 21);
			this.dtp_To_Date.TabIndex = 484;
			// 
			// chk_Close
			// 
			this.chk_Close.Location = new System.Drawing.Point(640, 64);
			this.chk_Close.Name = "chk_Close";
			this.chk_Close.Size = new System.Drawing.Size(16, 24);
			this.chk_Close.TabIndex = 42;
			this.chk_Close.Visible = false;
			// 
			// lbl_Close
			// 
			this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Close.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Close.ImageIndex = 0;
			this.lbl_Close.ImageList = this.img_Label;
			this.lbl_Close.Location = new System.Drawing.Point(536, 64);
			this.lbl_Close.Name = "lbl_Close";
			this.lbl_Close.Size = new System.Drawing.Size(100, 21);
			this.lbl_Close.TabIndex = 41;
			this.lbl_Close.Text = "Close";
			this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_Close.Visible = false;
			// 
			// lbl_MRP_No
			// 
			this.lbl_MRP_No.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MRP_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MRP_No.ImageIndex = 0;
			this.lbl_MRP_No.ImageList = this.img_Label;
			this.lbl_MRP_No.Location = new System.Drawing.Point(344, 39);
			this.lbl_MRP_No.Name = "lbl_MRP_No";
			this.lbl_MRP_No.Size = new System.Drawing.Size(100, 21);
			this.lbl_MRP_No.TabIndex = 40;
			this.lbl_MRP_No.Text = "Mrp No";
			this.lbl_MRP_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.ContentHeight = 16;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 16;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(112, 40);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:C" +
				"enter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits>" +
				"<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
				"umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
				"ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
				"dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
				"t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
				"le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
				"ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
				" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
				"t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
				"0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
				"tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
				"Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
				"/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
				"p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
				"odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(211, 20);
			this.cmb_Factory.TabIndex = 35;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(11, 39);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 36;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(899, 25);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 56);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
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
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "     Pcc MRP Plan Manager";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 81);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 80);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 81);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 63);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 56);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_grid
			// 
			this.pnl_grid.Controls.Add(this.fgrid_MRP);
			this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_grid.Location = new System.Drawing.Point(0, 192);
			this.pnl_grid.Name = "pnl_grid";
			this.pnl_grid.Size = new System.Drawing.Size(1016, 452);
			this.pnl_grid.TabIndex = 106;
			// 
			// fgrid_MRP
			// 
			this.fgrid_MRP.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MRP.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_MRP.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_MRP.ContextMenu = this.ctm_Menu;
			this.fgrid_MRP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MRP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_MRP.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MRP.Location = new System.Drawing.Point(0, 0);
			this.fgrid_MRP.Name = "fgrid_MRP";
			this.fgrid_MRP.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MRP.Size = new System.Drawing.Size(1016, 452);
			this.fgrid_MRP.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MRP.TabIndex = 104;
			this.fgrid_MRP.EnterCell += new System.EventHandler(this.fgrid_MRP_EnterCell);
			this.fgrid_MRP.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MRP_BeforeEdit);
			this.fgrid_MRP.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MRP_AfterEdit);
			// 
			// ctm_Menu
			// 
			this.ctm_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnt_IncludingMrp,
																					 this.mnt_NotIncludingMrp,
																					 this.mnt_Bar1,
																					 this.mnt_Ready,
																					 this.mnt_Editing,
																					 this.mnt_Confirmed,
																					 this.mnt_Canceled,
																					 this.mnt_Closed,
																					 this.mnt_Bar2,
																					 this.mnt_Mrp,
																					 this.mnt_Bom});
			// 
			// mnt_IncludingMrp
			// 
			this.mnt_IncludingMrp.Index = 0;
			this.mnt_IncludingMrp.Text = "Including";
			// 
			// mnt_NotIncludingMrp
			// 
			this.mnt_NotIncludingMrp.Index = 1;
			this.mnt_NotIncludingMrp.Text = "Not Including";
			// 
			// mnt_Bar1
			// 
			this.mnt_Bar1.Index = 2;
			this.mnt_Bar1.Text = "-";
			// 
			// mnt_Ready
			// 
			this.mnt_Ready.Index = 3;
			this.mnt_Ready.Text = "Ready";
			this.mnt_Ready.Click += new System.EventHandler(this.mnt_Ready_Click);
			// 
			// mnt_Editing
			// 
			this.mnt_Editing.Index = 4;
			this.mnt_Editing.Text = "Editing";
			this.mnt_Editing.Click += new System.EventHandler(this.mnt_Editing_Click);
			// 
			// mnt_Confirmed
			// 
			this.mnt_Confirmed.Index = 5;
			this.mnt_Confirmed.Text = "Confirmed";
			this.mnt_Confirmed.Click += new System.EventHandler(this.mnt_Confirmed_Click);
			// 
			// mnt_Canceled
			// 
			this.mnt_Canceled.Index = 6;
			this.mnt_Canceled.Text = "Canceled";
			// 
			// mnt_Closed
			// 
			this.mnt_Closed.Index = 7;
			this.mnt_Closed.Text = "Closed";
			this.mnt_Closed.Click += new System.EventHandler(this.mnt_Closed_Click);
			// 
			// mnt_Bar2
			// 
			this.mnt_Bar2.Index = 8;
			this.mnt_Bar2.Text = "-";
			// 
			// mnt_Mrp
			// 
			this.mnt_Mrp.Index = 9;
			this.mnt_Mrp.Text = "Mrp Division";
			// 
			// mnt_Bom
			// 
			this.mnt_Bom.Index = 10;
			this.mnt_Bom.Text = "Bom";
			// 
			// Form_MRP_Manager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_grid);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_MRP_Manager";
			this.Text = "Pcc MRP Plan Manager";
			this.Load += new System.EventHandler(this.Form_MRP_Manager_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_grid, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_grid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MRP)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction  MyComFunction= new COM.ComFunction();


		private string  _Create  = ClassLib.ComVar.ConsCDC_Y;
		private string _Level1 = "1", _Level2="2", _Level3="3", _Level4="4", _Level5="5";

			 
		#endregion 

		#region  공통메쏘드

		private void  Init_Form()
		{

			try
			{
				this.Text = "Pcc MRP Plan Manager";
				this.lbl_MainTitle.Text =  "Pcc MRP Plan Manager";
				ClassLib.ComFunction.SetLangDic(this); 

				#region 버튼 권한

				tbtn_New.Enabled     = true;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = true;
				tbtn_Create.Enabled  = true;
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Confirm.Enabled = false;		
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;			
				tbtn_Print.Enabled   = false;



				#endregion  

				#region 속성 설정
				if (_loadingfromtype == ClassLib.ComVar.ConsCDC_LoadingFrom_Type_B)  //Check에서 넘어 왔을 경우 
				{
					// Factory Combobox Add Items
					DataTable dt_list;
					dt_list = COM.ComFunction.Select_Factory_List_CDC();
					COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
					cmb_Factory.SelectedValue = ClassLib.ComVar.ConsCDC_MRP_Factory ;

				
					//mrp date
					dt_list =ClassLib.ComFunction.Select_MRP_Date(cmb_Factory.SelectedValue.ToString());
					dtp_Mrp_date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(ClassLib.ComVar.ConsCDC_MRP_No));
					dtp_Mrp_date.Enabled = false;

				

					//prod date 
					dt_list =ClassLib.ComFunction.Select_MRP_Prod_Date(cmb_Factory.SelectedValue.ToString(),
						       MyComFunction.ConvertDate2DbType( dtp_From_Date.Value.ToString().Substring(0,8)));
					dtp_From_Date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(ClassLib.ComVar.ConsCDC_MRP_ProdFrom));
					dtp_To_Date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(ClassLib.ComVar.ConsCDC_MRP_ProdTo));



				}
				else
				{
					// Factory Combobox Add Items
					DataTable dt_list;
					dt_list = COM.ComFunction.Select_Factory_List_CDC();
					COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
					cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

				
					
					//mrp date
					dt_list =ClassLib.ComFunction.Select_MRP_Date(cmb_Factory.SelectedValue.ToString());
					dtp_Mrp_date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[0].ToString()));
				    dtp_Mrp_date.Enabled = false;


					dt_list =ClassLib.ComFunction.Select_MRP_Prod_Date(cmb_Factory.SelectedValue.ToString(),
						MyComFunction.ConvertDate2DbType( dtp_From_Date.Value.ToString().Substring(0,8)));
					dtp_From_Date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[0].ToString()));
					dtp_To_Date.Value =    Convert.ToDateTime( MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[1].ToString()));

				


				}


				//TBSXD_MRP_MANAGER
				fgrid_MRP.Set_Grid_CDC("SXD_MRP_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_MRP.Set_Action_Image(img_Action);
				fgrid_MRP.Font = new Font("Verdana", 8);
				//rid_MRP.Styles.Alternate.BackColor = Color.White;

				#endregion


				tbtn_Create_Click(null,null);
	
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message (ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
				

		}


		
		private void Set_Flag_Clear (COM.FSP arg_fgrid)
		{

			for (int i = arg_fgrid.Rows.Fixed ;i< arg_fgrid.Rows.Count ; i++)
				arg_fgrid[i,0] ="";


		}





		private void Set_Flag(string arg_value,string arg_desc)
		{

			int  vRow1 = fgrid_MRP.Selection.r1, vRow2  = fgrid_MRP.Selection.r2;
			int  vCol1 = fgrid_MRP.Selection.c1;

			for (int i = vRow1;  i<= vRow2 ; i++ )
			{

				if ((fgrid_MRP[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS] ==null) ||  (fgrid_MRP[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() =="")) continue;
				fgrid_MRP[i,vCol1] =  arg_value ;
				fgrid_MRP[i,vCol1-1] = arg_desc;
				fgrid_MRP[i,0]="U";

			}


		}


		private void 	Set_Mrp_key()
		{
			
			ClassLib.ComVar.ConsCDC_MRP_Factory =cmb_Factory.SelectedValue.ToString();
			ClassLib.ComVar.ConsCDC_MRP_MatDiv = "";
			ClassLib.ComVar.ConsCDC_MRP_No =MyComFunction.ConvertDate2DbType(  dtp_Mrp_date.Value.ToString()).Substring(0,8);
			ClassLib.ComVar.ConsCDC_MRP_ProdFrom= MyComFunction.ConvertDate2DbType(  dtp_From_Date.Value.ToString()).Substring(0,8);
			ClassLib.ComVar.ConsCDC_MRP_ProdTo =MyComFunction.ConvertDate2DbType(  dtp_To_Date.Value.ToString()).Substring(0,8);

		}

		private bool Save_Mrp_Close_Change()
		{


			
			

			DataSet ds_ret;

			bool vSaveFlag = false;

			vSaveFlag =  Save_Mrp_Close();

			if(!vSaveFlag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return false;
			}
			else
			{
				vSaveFlag = Save_Mrp_Change(); 

				if(!vSaveFlag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return false;
				}
				else
				{

					ds_ret = MyOraDB.Exe_Modify_Procedure();
	
					if(ds_ret == null)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return false;
					}
					else
					{
						
						return true;


					} 


				}

			}




		}



		private void DisPlay_Grid(DataTable arg_dt)
		{


				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{

					fgrid_MRP.Rows.Count  = fgrid_MRP.Rows.Count  +1;


					for  ( int  j = 0; j <arg_dt.Columns.Count ; j++)
					{

						
						
						

						if (fgrid_MRP.Cols[j+1].DataType.Equals(typeof(bool)))
						{

							if (arg_dt.Rows[i].ItemArray[j].ToString() =="") continue;
							
							CellStyle cs = fgrid_MRP.Styles.Add("bool");
							cs.DataType = typeof(bool);
							cs.ImageAlign = ImageAlignEnum.CenterCenter;


							CellRange rg = fgrid_MRP.GetCellRange(fgrid_MRP.Rows.Fixed + i,j+1);
							rg.Style = fgrid_MRP.Styles["bool"];

							fgrid_MRP[fgrid_MRP.Rows.Fixed + i,j+1] = ( arg_dt.Rows[i].ItemArray[j].ToString() == ClassLib.ComVar.ConsCDC_Y)?"True":"False";

						}
						else	
						{			   
							fgrid_MRP[fgrid_MRP.Rows.Count -1,j+1]  = arg_dt.Rows[i].ItemArray[j].ToString();
						}


						fgrid_MRP[fgrid_MRP.Rows.Fixed + i,0]    = "";


					}

				
 
				}
				 



	}





		#endregion  

		#region  버튼이벤트






		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_MRP.Rows.Count  = fgrid_MRP.Rows.Fixed;
			chk_Close.Checked  = false;

		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{


//				if  (DateTime.Compare(dtp_From_Date.Value,dtp_To_Date.Value) >0) 
//				{  ClassLib.ComFunction.User_Message("Prod Date Check", "dtp_To_Date_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
//					return;
//				}


				this.Cursor  = Cursors.WaitCursor;

				DataTable dt_list  = Select_MRP_Plan_Lot( );
				_Create  =ClassLib.ComVar.ConsCDC_N;

				fgrid_MRP.Rows.Count  = fgrid_MRP.Rows.Fixed;

				DisPlay_Grid(dt_list);

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);


			}
			catch(Exception ex)
			{

				this.Cursor  = Cursors.Default; 
				ClassLib.ComFunction.User_Message(ex.ToString(), "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);


			}
			finally
			{

				this.Cursor  = Cursors.Default; 
			}
			
		}




		
		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{

				this.Cursor  = Cursors.WaitCursor;

				fgrid_MRP.Rows.Count  = fgrid_MRP.Rows.Fixed;

				Save_MRP_Plan_Lot(cmb_Factory.SelectedValue.ToString(),
					               ClassLib.ComFunction.Empty_String(dtp_From_Date.Text.Replace("-","")," "),
								   ClassLib.ComFunction.Empty_String(dtp_From_Date.Text.Replace("-","")," "));


				tbtn_Search_Click(null,null);


			}
			catch(Exception ex)
			{

				this.Cursor  = Cursors.Default; 
				ClassLib.ComFunction.User_Message(ex.ToString(), "Save_MRP_Plan_Lot", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{

				this.Cursor  = Cursors.Default; 

			}


			

		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

				this.Cursor  = Cursors.WaitCursor;

				DialogResult dr = MessageBox.Show("Do you want to save? ", "Save" , MessageBoxButtons.YesNo);

				if(DialogResult.Yes != dr) return;

				fgrid_MRP.Select(fgrid_MRP.Selection.r1,fgrid_MRP.Selection.c1);

				if (Save_Mrp_Close_Change()!= true)
				{

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave,this);

				}
				else
				{
					Set_Flag_Clear(fgrid_MRP);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave,this);
				}

				

			}
			catch(Exception ex)
			{

				this.Cursor  = Cursors.Default; 
				ClassLib.ComFunction.User_Message(ex.ToString(), "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				this.Cursor  = Cursors.Default; 



			} 
		
		}





		private void btn_next_Click(object sender, System.EventArgs e)
		{
			
//			frm.MdiParent = _Parent_Form; 
//			frm.Show();  
//
//			

			Set_Mrp_key();   //전역변수 Setting (mrp key)


            COM.MyItem item = new COM.MyItem("MRP", "FlexCDC.MRP", "Form_MRP_Check");
            ClassMenu menu = new ClassMenu();

            menu.OpenFormByName(this.MdiParent, item, "FlexCDC.MRP.Form_MRP_Check", "MRP");
            this.Close();

            //Form_MRP_Check vForm = new Form_MRP_Check(this, COM.ComVar.ConsCDC_MoveSheet_0);
            //vForm.MdiParent = COM.ComVar.MDI_Parent;
            //vForm.Show();

			
            //this.Close();

			 
		}


	




		private void cmb_MatDiv_TextChanged(object sender, System.EventArgs e)
		{
			
//			if (cmb_MatDiv.SelectedIndex == -1) return;
//	
//			//mat Div
//			DataTable dt_list = Select_pur_div(cmb_Factory.SelectedValue.ToString());
//			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_MatDiv, 1, 2,true, 0, 140);
//			cmb_MatDiv.SelectedIndex = 0;

			

		}



//
//		private void cmb_MRP_No_TextChanged(object sender, System.EventArgs e)
//		{
//		
//			
//			//mrp no
//			DataTable dt_list = ClassLib.ComFunction.Select_MRP_No(cmb_Factory.SelectedValue.ToString(), cmb_MatDiv.SelectedValue.ToString());
//
//			dtp_From_Date.Value =  Convert.ToDateTime( MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[4].ToString()));
//			dtp_To_Date.Value   = Convert.ToDateTime( MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[5].ToString()));
//
//		}



	

		private void fgrid_MRP_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			
			if ((fgrid_MRP.Rows.Fixed > 0) && (fgrid_MRP.Row >= fgrid_MRP.Rows.Fixed))
			{
				if(fgrid_MRP.Cols[fgrid_MRP.Col].DataType == typeof(bool))
				{
					fgrid_MRP.Buffer_CellData = "";
				}
				else
				{
					fgrid_MRP.Buffer_CellData = (fgrid_MRP[fgrid_MRP.Row, fgrid_MRP.Col] == null) ? "" : fgrid_MRP[fgrid_MRP.Row, fgrid_MRP.Col].ToString();
				}
			}

		}

			
	



		private void fgrid_MRP_EnterCell(object sender, System.EventArgs e)
		{
			//if (e.Button != MouseButtons.Right) return;

			mnt_IncludingMrp.Visible  = false;
			mnt_NotIncludingMrp.Visible =false;


			mnt_Bar1.Visible = false;


			mnt_Canceled.Visible =false;
			mnt_Closed.Visible  = false;
			mnt_Confirmed.Visible = false;
			mnt_Editing.Visible  = false;
			mnt_Ready.Visible  = false;


			mnt_Mrp.Visible  = false;
			mnt_Bom.Visible  = false;

			mnt_Bar1.Visible  = false;
			mnt_Bar2.Visible  = false;

		



			if (fgrid_MRP.Selection.c1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS_DESC)
			{

				mnt_Canceled.Visible =false;
				mnt_Closed.Visible  = true;
				mnt_Confirmed.Visible = false;
				mnt_Editing.Visible  = false;
				mnt_Ready.Visible  = true;

			}


//
//
//
//			if (fgrid_MRP.Selection.c1  == (int)ClassLib.TBSXD_MRP_MANAGER.lxITEM_01)
//			{
//				mnt_Mrp.Visible  = true;
//				mnt_Bom.Visible  = true;
//			}
//



			
		}


		private void fgrid_MRP_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
				
			if ((fgrid_MRP[fgrid_MRP.Selection.r1,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS ]==null) ||
				(fgrid_MRP[fgrid_MRP.Selection.r1,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS ].ToString()=="" )) return;


			int vRow1 =fgrid_MRP.Selection.r1   ,  vRow2  = fgrid_MRP.Selection.r2,  vCol1  = fgrid_MRP.Selection.c1;
			for (int i=vRow1; i<= vRow2; i++)
			{


				//U Setting
				if ((fgrid_MRP[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS] ==null) ||  (fgrid_MRP[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() =="")) continue;

				fgrid_MRP.Update_Row(i);		
				fgrid_MRP[i,vCol1] =  fgrid_MRP[vRow1, vCol1].ToString();



				//음수 check
				if  ((vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR) &&
					(Convert.ToSingle(fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR].ToString()) <= 0))
				{
					fgrid_MRP[i,vCol1]  = fgrid_MRP.Buffer_CellData;
					fgrid_MRP[i,0]      ="";
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput,this);
					return;

				}

				//수량변경시 mrp자동 check

				if (vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR)  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG] ="True";

					
			}

			


		}





		private void mnt_IncludingMrp_Click(object sender, System.EventArgs e)
		{
			string vDesc =  ClassLib.ComVar.ConsCDC_Including;
			string vValue =  ClassLib.ComVar.ConsCDC_Y;

			Set_Flag(vDesc,vValue);
		}



		private void mnt_NotIncludingMrp_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_NotIncluding;
			string vValue =  ClassLib.ComVar.ConsCDC_N;

			Set_Flag(vDesc,vValue);
		}

	
		private void mnt_Ready_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_Ready;
			string vValue =  ClassLib.ComVar.ConsCDC_N;

			Set_Flag(vDesc,vValue);
		}

		private void mnt_Editing_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_Editing;
			string vValue =  ClassLib.ComVar.ConsCDC_Y;

			Set_Flag(vDesc,vValue);
		}

		private void mnt_Confirmed_Click(object sender, System.EventArgs e)
		{
			string vDesc =  ClassLib.ComVar.ConsCDC_Comfirmed;
			string vValue =  ClassLib.ComVar.ConsCDC_C;

			Set_Flag(vDesc,vValue);
		}

		private void mnt_Canceled_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_Canceled;
			string vValue =  ClassLib.ComVar.ConsCDC_D;
			Set_Flag(vDesc,vValue);
		}

		private void mnt_Closed_Click(object sender, System.EventArgs e)
		{
		
			string vDesc =  ClassLib.ComVar.ConsCDC_Closed;
			string vValue =  ClassLib.ComVar.ConsCDC_X;

			Set_Flag(vDesc,vValue);
		}



		private void dtp_Mrp_date_ValueChanged(object sender, System.EventArgs e)
		{
		
		
				dtp_From_Date.Enabled = true ;dtp_To_Date.Enabled = true;

				if (_Create == ClassLib.ComVar.ConsCDC_Y)   return;

				DataTable  dt_list = ClassLib.ComFunction.Select_MRP_Prod_Date(cmb_Factory.SelectedValue.ToString(),
					MyComFunction.ConvertDate2DbType(  dtp_Mrp_date.Value.ToString().Substring(0,8)));

				if (dt_list.Rows[0].ItemArray[0].ToString() =="") 
				{
					dtp_From_Date.Enabled = false;
					dtp_To_Date.Enabled   = false;
				}
	


		}



		#region 콘텍스트 메뉴


		private void mnt_Mrp_Click(object sender, System.EventArgs e)
		{
			
			fgrid_MRP.Tree.Show(1);
		}

		private void mnt_Bom_Click(object sender, System.EventArgs e)
		{
			fgrid_MRP.Tree.Show(2);
		}



		#endregion 


		#endregion

		#region  DB컨넥트



		

	





		public static DataTable  Select_Mrp_Date(string arg_factory, string arg_pur_div )
		{

			COM.OraDB MyOraDB    = new COM.OraDB();


			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_MAST_MRP_DATE";

			int vCount = 3;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_pur_div";	
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[0] = arg_factory;	
			MyOraDB.Parameter_Values[1] = arg_pur_div;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}



	private  DataTable Count_MRP_Err( )
	{

		string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_REQ_LOT";

		int vCount = 5, a=0, b=0;
		MyOraDB.ReDim_Parameter(vCount);
		MyOraDB.Process_Name = Proc_Name ;

		MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";	
		MyOraDB.Parameter_Name[a++] = "ARG_pur_div";	
		MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";	
		MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";	
		MyOraDB.Parameter_Name[a++] = "ARG_STATUS";		
		MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


		for (int i =0 ; i< vCount-1 ; i++)
			MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

		MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		


		MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
		MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_From_Date.Value.ToString().Substring(0,8)): " ";
		MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_To_Date.Value.ToString().Substring(0,8)): " ";
		string  vStatus  =  (chk_Close.Checked  == true)?ClassLib.ComVar.ConsCDC_X:" ";
		MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)?vStatus :" ";
		MyOraDB.Parameter_Values[b++] = "";

		MyOraDB.Add_Select_Parameter(true);
		DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

		if(DS_Ret == null) return null ;
		
		return DS_Ret.Tables[Proc_Name];
			

	}




	
		private  DataTable Select_MRP_Plan_Lot( )
		{

			string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_REQ_LOT";

			int vCount = 5, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";	
			MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";	
			MyOraDB.Parameter_Name[a++] = "ARG_STATUS";		
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
		
		


			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_From_Date.Value.ToString().Substring(0,8)): " ";
			MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_To_Date.Value.ToString().Substring(0,8)): " ";
			string  vStatus  =  (chk_Close.Checked  == true)?ClassLib.ComVar.ConsCDC_X:" ";
			MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)?vStatus :" ";
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
		
			return DS_Ret.Tables[Proc_Name];


			

		}




		private  bool Save_MRP_Plan_Lot (string arg_factory, string arg_from, string arg_to )
		{

			string Proc_Name = "PKG_SXM_MRP_01.SAVE_SXM_MRP_REQ_LOT";

			int vCount = 4, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";			
			MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";		
			MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";


			for (int i =0 ; i< vCount ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

	
			
			

			MyOraDB.Parameter_Values[b++] =  arg_factory;
			MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_From_Date.Value.ToString().Substring(0,8)): " ";
			MyOraDB.Parameter_Values[b++] =  (_Create ==ClassLib.ComVar.ConsCDC_N)? MyComFunction.ConvertDate2DbType(  dtp_To_Date.Value.ToString().Substring(0,8)): " ";
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();		


			return true;

		


		}




				
		private bool Save_Mrp_Close()
		{

			string Proc_Name = "PKG_SXM_MRP_01.SAVE_SXE_LOT_CLOSE";


			int  vSaveCount =0,  vCount = 5, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";		
			MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";			
			MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";		
			MyOraDB.Parameter_Name[a++] = "ARG_STATUS";
			MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";		



			for (int i =0 ; i< vCount ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

	
			//save할 count
			for (int i =fgrid_MRP.Rows.Fixed ; i< fgrid_MRP.Rows.Count; i++)
				if (fgrid_MRP[i,0].ToString() =="U") vSaveCount++;


			MyOraDB.Parameter_Values = new string[vCount * vSaveCount ];
			for (int i =fgrid_MRP.Rows.Fixed ; i< fgrid_MRP.Rows.Count; i++)
			{
				if (fgrid_MRP[i,0].ToString() !="U") continue;
				
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxFACTORY].ToString();
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_NO].ToString();	
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_SEQ].ToString();	
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS].ToString();	
				MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;
		
			}

			
			MyOraDB.Add_Modify_Parameter(true); 
			return true;
         

		}


		private bool Save_Mrp_Change()
		{

			string Proc_Name = "PKG_SXM_MRP_01.UPDATE_SXM_MRP_REQ_LOT_SIZE";


			int  vSaveCount =0,  vCount = 7, a=0, b=0;
			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;

	
			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";				
			MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";		
			MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[a++] = "ARG_SIZE_CD";	
			MyOraDB.Parameter_Name[a++] = "ARG_MRP_FLG";
			MyOraDB.Parameter_Name[a++] = "ARG_QTY_CURR_PUR";
			MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";


			for (int i =0 ; i< vCount ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

	
			//save할 count
			for (int i =fgrid_MRP.Rows.Fixed ; i< fgrid_MRP.Rows.Count; i++)
				if (fgrid_MRP[i,0].ToString() =="U") vSaveCount++;


			MyOraDB.Parameter_Values = new string[vCount * vSaveCount ];
			for (int i =fgrid_MRP.Rows.Fixed ; i< fgrid_MRP.Rows.Count; i++)
			{
				if (fgrid_MRP[i,0].ToString() !="U") continue;

				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxFACTORY].ToString();				
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_NO].ToString();	
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_SEQ].ToString();
				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxCS_SIZE].ToString();	
				
				MyOraDB.Parameter_Values[b++] =  ((fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG] == null)  || ( fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG].ToString() =="False"))?"N" : "Y";

				MyOraDB.Parameter_Values[b++] =  fgrid_MRP[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR].ToString();
				MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;

				
			}

			
			MyOraDB.Add_Modify_Parameter(false); 
			return true;

         

		}






		#endregion


		private void Form_MRP_Manager_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}





	}
}

