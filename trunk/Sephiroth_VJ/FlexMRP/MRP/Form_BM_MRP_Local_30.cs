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
	public class Form_BM_MRP_Local_30 : COM.PCHWinForm.Form_Top
	{
		
		#region 디자이너에서 생성한 멤버
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.ComponentModel.IContainer components = null;
		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
 

		// search option value
		private const string _Search_DP  = "1";
		private const string _Search_DPO = "2"; 
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label lbl_DP;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_RunProcess;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_Data;
		private Hashtable _cellTypes = null;
		private Pop_BM_Shipping_Wait _pop;
		private const int _validate_process = 40, _validate_redeploy = 50, _validate_recalculation = 60;
		

		#endregion
		private System.Windows.Forms.Label lbl_DPdate;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_Purchase;
		private System.Windows.Forms.MenuItem mnu_DPO;
		private System.Windows.Forms.MenuItem mnu_InForecast;
		private System.Windows.Forms.MenuItem mnu_MPS;
		private System.Windows.Forms.MenuItem mnu_Incoming;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem mnu_LoadDPO;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Error;
		private System.Windows.Forms.Label btn_ErrorCheck;
		private System.Windows.Forms.TextBox txt_DPdate;


		#region 생성자 / 소멸자
		public Form_BM_MRP_Local_30()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BM_MRP_Local_30));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.spd_main = new COM.SSP();
			this.ctx_tail = new System.Windows.Forms.ContextMenu();
			this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
			this.mnu_Data = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_LoadDPO = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.mnu_Purchase = new System.Windows.Forms.MenuItem();
			this.mnu_DPO = new System.Windows.Forms.MenuItem();
			this.mnu_InForecast = new System.Windows.Forms.MenuItem();
			this.mnu_MPS = new System.Windows.Forms.MenuItem();
			this.mnu_Incoming = new System.Windows.Forms.MenuItem();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_RunProcess = new System.Windows.Forms.Label();
			this.btn_ErrorCheck = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Error = new System.Windows.Forms.TextBox();
			this.lbl_DPdate = new System.Windows.Forms.Label();
			this.txt_DPdate = new System.Windows.Forms.TextBox();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.cmb_To = new C1.Win.C1List.C1Combo();
			this.cmb_From = new C1.Win.C1List.C1Combo();
			this.lbl_DP = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.spd_main);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.GridDefinition = "20.6597222222222:False:True;71.3541666666667:False:False;6.59722222222222:False:T" +
				"rue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575" +
				":False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(8, 538);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 38);
			this.panel2.TabIndex = 4;
			// 
			// spd_main
			// 
			this.spd_main.ContextMenu = this.ctx_tail;
			this.spd_main.Location = new System.Drawing.Point(8, 123);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(1000, 411);
			this.spd_main.TabIndex = 3;
			this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
			this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
			// 
			// ctx_tail
			// 
			this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_AllSelect,
																					 this.mnu_Data,
																					 this.menuItem1,
																					 this.mnu_LoadDPO,
																					 this.menuItem2,
																					 this.mnu_Purchase,
																					 this.mnu_DPO,
																					 this.mnu_InForecast,
																					 this.mnu_MPS,
																					 this.mnu_Incoming});
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
			this.mnu_Data.Click += new System.EventHandler(this.mnu_Data_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// mnu_LoadDPO
			// 
			this.mnu_LoadDPO.Index = 3;
			this.mnu_LoadDPO.Text = "Loading DPO";
			this.mnu_LoadDPO.Click += new System.EventHandler(this.mnu_LoadDPO_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 4;
			this.menuItem2.Text = "-";
			// 
			// mnu_Purchase
			// 
			this.mnu_Purchase.Index = 5;
			this.mnu_Purchase.Text = "Purchase";
			this.mnu_Purchase.Click += new System.EventHandler(this.mnu_Purchase_Click);
			// 
			// mnu_DPO
			// 
			this.mnu_DPO.Index = 6;
			this.mnu_DPO.Text = "DPO";
			this.mnu_DPO.Click += new System.EventHandler(this.mnu_DPO_Click);
			// 
			// mnu_InForecast
			// 
			this.mnu_InForecast.Index = 7;
			this.mnu_InForecast.Text = "In Forecast";
			this.mnu_InForecast.Click += new System.EventHandler(this.mnu_InForecast_Click);
			// 
			// mnu_MPS
			// 
			this.mnu_MPS.Index = 8;
			this.mnu_MPS.Text = "MPS";
			this.mnu_MPS.Click += new System.EventHandler(this.mnu_MPS_Click);
			// 
			// mnu_Incoming
			// 
			this.mnu_Incoming.Index = 9;
			this.mnu_Incoming.Text = "Incoming";
			this.mnu_Incoming.Click += new System.EventHandler(this.mnu_Incoming_Click);
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_RunProcess);
			this.pnl_head.Controls.Add(this.btn_ErrorCheck);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_Error);
			this.pnl_head.Controls.Add(this.lbl_DPdate);
			this.pnl_head.Controls.Add(this.txt_DPdate);
			this.pnl_head.Controls.Add(this.cmb_StyleCd);
			this.pnl_head.Controls.Add(this.txt_StyleCd);
			this.pnl_head.Controls.Add(this.cmb_To);
			this.pnl_head.Controls.Add(this.cmb_From);
			this.pnl_head.Controls.Add(this.lbl_DP);
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
			this.pnl_head.Size = new System.Drawing.Size(1000, 119);
			this.pnl_head.TabIndex = 2;
			// 
			// btn_RunProcess
			// 
			this.btn_RunProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RunProcess.ImageIndex = 0;
			this.btn_RunProcess.ImageList = this.img_Button;
			this.btn_RunProcess.Location = new System.Drawing.Point(822, 84);
			this.btn_RunProcess.Name = "btn_RunProcess";
			this.btn_RunProcess.Size = new System.Drawing.Size(80, 23);
			this.btn_RunProcess.TabIndex = 537;
			this.btn_RunProcess.Text = "Run";
			this.btn_RunProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_RunProcess.Click += new System.EventHandler(this.btn_RunProcess_Click);
			this.btn_RunProcess.MouseHover += new System.EventHandler(this.btn_RunProcess_MouseHover);
			this.btn_RunProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseUp);
			this.btn_RunProcess.MouseLeave += new System.EventHandler(this.btn_RunProcess_MouseLeave);
			this.btn_RunProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseDown);
			// 
			// btn_ErrorCheck
			// 
			this.btn_ErrorCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ErrorCheck.ImageIndex = 0;
			this.btn_ErrorCheck.ImageList = this.img_Button;
			this.btn_ErrorCheck.Location = new System.Drawing.Point(903, 84);
			this.btn_ErrorCheck.Name = "btn_ErrorCheck";
			this.btn_ErrorCheck.Size = new System.Drawing.Size(80, 23);
			this.btn_ErrorCheck.TabIndex = 537;
			this.btn_ErrorCheck.Text = "Checking";
			this.btn_ErrorCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_ErrorCheck.Click += new System.EventHandler(this.btn_ErrorCheck_Click);
			this.btn_ErrorCheck.MouseHover += new System.EventHandler(this.btn_RunProcess_MouseHover);
			this.btn_ErrorCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseUp);
			this.btn_ErrorCheck.MouseLeave += new System.EventHandler(this.btn_RunProcess_MouseLeave);
			this.btn_ErrorCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_RunProcess_MouseDown);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 405;
			this.label1.Text = "Error";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Error
			// 
			this.txt_Error.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Error.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Error.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Error.Location = new System.Drawing.Point(109, 84);
			this.txt_Error.MaxLength = 10;
			this.txt_Error.Name = "txt_Error";
			this.txt_Error.Size = new System.Drawing.Size(211, 21);
			this.txt_Error.TabIndex = 536;
			this.txt_Error.Text = "50";
			// 
			// lbl_DPdate
			// 
			this.lbl_DPdate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DPdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DPdate.ImageIndex = 0;
			this.lbl_DPdate.ImageList = this.img_Label;
			this.lbl_DPdate.Location = new System.Drawing.Point(344, 62);
			this.lbl_DPdate.Name = "lbl_DPdate";
			this.lbl_DPdate.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPdate.TabIndex = 405;
			this.lbl_DPdate.Text = "Last Update";
			this.lbl_DPdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_DPdate
			// 
			this.txt_DPdate.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DPdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DPdate.Enabled = false;
			this.txt_DPdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_DPdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_DPdate.Location = new System.Drawing.Point(445, 62);
			this.txt_DPdate.MaxLength = 10;
			this.txt_DPdate.Name = "txt_DPdate";
			this.txt_DPdate.Size = new System.Drawing.Size(211, 21);
			this.txt_DPdate.TabIndex = 536;
			this.txt_DPdate.Text = "";
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
			this.cmb_StyleCd.Location = new System.Drawing.Point(521, 40);
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
				"yout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(134, 21);
			this.cmb_StyleCd.TabIndex = 535;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(445, 40);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
			this.txt_StyleCd.TabIndex = 536;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
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
			this.cmb_To.Location = new System.Drawing.Point(220, 62);
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
			this.cmb_To.TabIndex = 416;
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
			this.cmb_From.Location = new System.Drawing.Point(109, 62);
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
			this.cmb_From.TabIndex = 415;
			this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
			// 
			// lbl_DP
			// 
			this.lbl_DP.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DP.ImageIndex = 1;
			this.lbl_DP.ImageList = this.img_Label;
			this.lbl_DP.Location = new System.Drawing.Point(8, 62);
			this.lbl_DP.Name = "lbl_DP";
			this.lbl_DP.Size = new System.Drawing.Size(100, 21);
			this.lbl_DP.TabIndex = 414;
			this.lbl_DP.Text = "DP";
			this.lbl_DP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(344, 40);
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
			this.pic_head3.Location = new System.Drawing.Point(984, 103);
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
			this.pic_head4.Location = new System.Drawing.Point(136, 102);
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
			this.pic_head7.Size = new System.Drawing.Size(101, 78);
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
			this.pic_head5.Location = new System.Drawing.Point(0, 103);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 101);
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
			// Form_BM_MRP_Local_30
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_BM_MRP_Local_30";
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "LLT Tracking (40+)";
			lbl_MainTitle.Text = "LLT Tracking (40+)";

			// grid set
			spd_main.Set_Spread_Comm("SBM_LLT_TRACKING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			

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
			tbtn_Print.Enabled = false; 

			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_ret.Dispose(); 

			init_DP_Change();


		}

		private void init_DP_Change()
		{
			DataTable dt_ret;

			dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), _Search_DP);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
 
			dt_ret.Dispose();

		}


		#endregion

		
		#region DB Connect

		 

		/// <summary>
		/// SELECT_SBM_DP_LIST : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_SBM_DP_LIST(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, import};

				MyOraDB.ReDim_Parameter(5);  

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBM_LLT_TRACKING.SELECT_DP_LIST"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DP_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_DP_TO";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBM_DP_LIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		
		 

		/// <summary>
		/// RUN_DP_USAGE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private bool RUN_DP_USAGE(string[] arg_parameter)
		{

			try 
			{
				MyOraDB.ReDim_Parameter(4);  

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBM_LLT_TRACKING.RUN_DP_USAGE"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DP_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_DP_TO";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";  
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3]; 
				
				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_DP_USAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}


		}




		/// <summary>
		/// SELECT_SBM_DP_LASTUPDATE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_SBM_DP_LASTUPDATE(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, import};

				MyOraDB.ReDim_Parameter(2);  

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBM_LLT_TRACKING.SELECT_DP_LASTUPDATE"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_DP_LASTUPDATE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		
		 

		/// <summary>
		/// SELECT_DPO_USAGE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_DPO_USAGE(string[] arg_parameter)
		{

			try 
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(7);  

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBM_LLT_TRACKING.SELECT_DPO_USAGE"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DEL_MONTH";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
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
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3]; 
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = arg_parameter[5]; 
				MyOraDB.Parameter_Values[6] = "";
				
				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_DPO_USAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			} 
		}




		#endregion	

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			init_DP_Change();
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


		#endregion


		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_Factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_Factory.Focus();
				return false;
			}  
			return true;
		}

		#endregion

		
		#region 사용자 이벤트

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



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_From, cmb_To};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;

			string factory = cmb_Factory.SelectedValue.ToString(); 
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

			//spd_main.ActiveSheet.ColumnCount = _Default_ColumnCount;

			string[] parameter = new string[] {factory, from, to, style_cd};

			DataTable dt_ret = SELECT_SBM_DP_LIST(parameter); 
			 
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll();   
			}
 
			spd_main.ClearAll();   
			spd_main.Display_Grid(dt_ret); 

			ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxFACTORY, 
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDEL_MONTH,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxOBS_TYPE,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxNEW,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSTYLE_CD,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSTYLE_NAME,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxPST_YN,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSEASON,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSEASON_YEAR,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxYIELD_STATUS,
																  (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxORDER_QTY  } );



		}


		private void btn_RunProcess_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_RunProcess_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_RunProcess_MouseLeave(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		private void btn_RunProcess_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			try
			{
				spd_main.Update_Row(img_Action);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Color_EditChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = spd_main.Sheets[0].ActiveRowIndex ;
				int ic = spd_main.Sheets[0].ActiveColumnIndex ;

				spd_main.Buffer_CellData = (spd_main.Sheets[0].Cells[ir,ic].Value == null) ? "" : spd_main.Sheets[0].Cells[ir,ic].Value.ToString() ;
				
				string s = spd_main.Sheets[0].Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					spd_main.Buffer_CellData = "000";
					spd_main.Update_Row(img_Action);
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_SaveProcess();
			}
		}
 

		private void Tbtn_SaveProcess()
		{
			try
			{ 
				bool save_flag = false;

				save_flag = MyOraDB.Save_Spread("PKG_SBM_LLT_TRACKING.SAVE_SBM_MRP_LLT_TRACKING", spd_main); 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{ 
					MessageBox.Show(this, "Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Item", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}

		private void mnu_Data_Click(object sender, System.EventArgs e)
		{
			this.Grid_CellClickProcess();
		}


		private void btn_RunProcess_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to run Run process?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_process))
				{
					RunProcess();
				}
			}
		}

		private void cmb_From_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_From.SelectedIndex == -1) return; 
				cmb_To.SelectedValue = cmb_From.SelectedValue.ToString();
				Search_DP_Update();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_From_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Search_DP_Update()
		{
			string factory = cmb_Factory.SelectedValue.ToString(); 
			string[] parameter = new string[] {factory};

			DataTable dt_ret = SELECT_SBM_DP_LASTUPDATE(parameter);

			txt_DPdate.Text = dt_ret.Rows[0].ItemArray[0].ToString();

		}

		#endregion
		
		#region 그리드 이벤트

		private void Grid_CellClickProcess()//FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{ 
				try
				{
					int vRow = spd_main.Sheets[0].ActiveRowIndex ;
					int vCol = spd_main.Sheets[0].ActiveColumnIndex;

					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= "Date";
					ClassLib.ComVar.Parameter_PopUp_Object = new object[]{spd_main.Sheets[0].Columns[vCol].CellType};
					Pop_BM_Changer _pop = new Pop_BM_Changer();
					_pop.ShowDialog();

					CellRange[] vSelectionRange = spd_main.Sheets[0].GetSelections(); 

					
					if (ClassLib.ComVar.Parameter_PopUp != null)
					{
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								if ( spd_main.Sheets[0].GetCellType(vRow, vCol).ToString() == "DateTimeCellType")
									spd_main.Sheets[0].Cells[j, vCol].Value = DateTime.Parse(COM.ComVar.Parameter_PopUp[0]);
								else
									spd_main.Sheets[0].Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[0];

								spd_main.Update_Row(j, img_Action);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBM_MRP_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		
		#region 툴바 메뉴 이벤트 메서드

		private void RunProcess()
		{
			System.Threading.Thread tRun = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
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

				string factory = cmb_Factory.SelectedValue.ToString(); 
				string from = cmb_From.SelectedValue.ToString();
				string to = cmb_To.SelectedValue.ToString();
				string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
				string[] parameter = new string[] {factory, from, to, style_cd};

				if (RUN_DP_USAGE(parameter))
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
				_pop.Close();
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		private void mnu_Purchase_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxPURCHASE_1ST_QTY, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void mnu_DPO_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDPO_ORDER, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void mnu_InForecast_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxPURCHASE_RTA, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void mnu_MPS_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxMPS_PLAN_DATE, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void mnu_Incoming_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxINCONING_DATE, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void mnu_LoadDPO_Click(object sender, System.EventArgs e)
		{
			Load_DPO();
		}


		private void Load_DPO()
		{
			try
			{
				int vRow = spd_main.Sheets[0].ActiveRowIndex ;
				int vCol = spd_main.Sheets[0].ActiveColumnIndex;

				CellRange[] vSelectionRange = spd_main.Sheets[0].GetSelections(); 

				for (int i = 0 ; i < vSelectionRange.Length; i++)
				{
					int start_row = vSelectionRange[i].Row;
					int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

					for (int j = start_row ; j < end_row; j++)
					{
						string factory  = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxFACTORY  ].Value.ToString();
						string DP       = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDEL_MONTH].Value.ToString();
						string style_cd = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSTYLE_CD ].Value.ToString();
						string item_cd  = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxITEM_CD  ].Value.ToString();
						string spec_cd  = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxSPEC_CD  ].Value.ToString();
						string color_cd = spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxCOLOR_CD ].Value.ToString();

						string[] parameter = new string[] {factory, DP, style_cd, item_cd, spec_cd, color_cd};

						DataTable dt_ret = SELECT_DPO_USAGE(parameter);

						spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDPO_ORDER ].Value = dt_ret.Rows[0].ItemArray[0].ToString();
						spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDPO_USAGE ].Value = dt_ret.Rows[0].ItemArray[1].ToString();
						
						spd_main.Update_Row(j, img_Action);

						dt_ret.Dispose();
					}
				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Load_DPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} 
		}

		private void btn_ErrorCheck_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to Error Check?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_process))
				{
					ErrorCheck();
				}
			}
		}

		
		private void ErrorCheck()
		{
			if (txt_Error.Text.Trim()  == "" )
			{
				ClassLib.ComFunction.User_Message("Data Not Found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_Factory.Focus();
				return;
			}   

			try
			{ 
				int vRow = spd_main.Sheets[0].RowCount;
				for (int j = 0 ; j < vRow; j++)
				{
					try
					{ 
						int _order_qty = Convert.ToInt32( spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxORDER_QTY ].Value.ToString() );
						int _dpo_qty   = Convert.ToInt32( spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDPO_ORDER ].Value.ToString() );
					
						int _order_usage = (int)Convert.ToDouble( spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxPURCHASE_1ST_QTY ].Value.ToString() ); 
						int _dpo_usage   = (int)Convert.ToDouble( spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxDPO_USAGE ].Value.ToString() );
						int _Error       = _order_usage - _dpo_usage;

						spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxBALANCE_DPO_ORDER].Value = _order_qty   - _dpo_qty;
						spd_main.Sheets[0].Cells[j, (int)ClassLib.TBSBM_MRP_LLT_TRACKING.IxBALANCE_DPO_USAGE].Value = _Error;

						spd_main.Update_Row(j, img_Action);


						if ( _order_usage > _dpo_usage * ( 1 + ( Convert.ToInt32(txt_Error.Text) / 100) ) )
						{
							spd_main.Sheets[0].Rows[j].ForeColor  = System.Drawing.Color.Red;
						}
						else if ( _order_usage  < _dpo_usage * ( 1 + ( Convert.ToInt32(txt_Error.Text) / 100) ) )
						{
							spd_main.Sheets[0].Rows[j].ForeColor  = System.Drawing.Color.Purple;
						}
						else
						{
							spd_main.Sheets[0].Rows[j].ForeColor = System.Drawing.Color.Black;
						}
					}
					catch (Exception ex)
					{
						
					} 
				} 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ErrorCheck", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} 
		}


	}
}

