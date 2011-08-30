using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMold.Tooling
{
	public class Form_ST_Purchase_Order : COM.MoldWinForm.Form_Top
	{

		#region Design creation

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_status;
		private System.Windows.Forms.Label lbl_purStatus;
		private System.Windows.Forms.Label lbl_purNo;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_purYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Panel pnl_main;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region User Define

		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.EventHandler   _cmbPurNoEventHandler   = null;
		private bool _practicable  = true, _doSearch = true;
		private bool _firstLoad    = true;
//		private int _purSeq = 0;
//		private int _startCol = 4;
		private Hashtable _cellCombo = null;
		private int _Rowfixed;
//		private string _title = null;		

		private string _sModel;
		private string _sSeason;
		private string _sYear;
		private string _sModel_Desc;
		private string _sLine_cd;
		private string _sPur_pose;

		//private C1.Win.C1List.C1Combo cmb_purNo;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_tree;
		private System.Windows.Forms.MenuItem mnu_style;
		private System.Windows.Forms.MenuItem mnu_item;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnu_Insert_Item;
		private System.Windows.Forms.MenuItem mnu_Insert_Model;
		private System.Windows.Forms.MenuItem mnu_Change_Model;
		private C1.Win.C1List.C1Combo cmb_purNo;
//		private const int _validate_context = 20;
//		private const int _maxPrice = 50;
//		private const string _CBDCurrency = "USD";
//		private double _rate ;
//		private int _controlLevel;
//		private ArrayList _level1 = new ArrayList(20);

//		private AxRDVIEWER40Lib.AxRdviewer40 myRD401;

		private int _colT_LEVEL			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxT_LEVEL;
		private int _colFACTORY			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxFACTORY;
		private int _colPUR_NO			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxPUR_NO;		
		private int _colPUR_SEQ			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxPUR_SEQ;		
		private int _colPUR_YMD			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxPUR_YMD;		
		private int _colMODEL_CD		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxMODEL_CD;	
		private int _colMODEL_NM		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxMODEL_NM;	
		private int _colSEASON			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxSEASON;		
		private int _colSEASON_YEAR		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxSEASON_YEAR;	
		private int _colCOMPONENT_M_NM	= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxCOMPONENT_M_NM;
		private int _colCOMPONENT_S_NM	= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxCOMPONENT_S_NM;
		private int _colITEM_NM			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxITEM_NM;	
		private int _colSIZE_DESC		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxSIZE_DESC;	
		private int _colSPEC			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxSPEC;		
		private int _colUNIT			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxUNIT;		
		private int _colRE_QTY			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxRE_QTY;		
		private int _colPUR_QTY			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxPUR_QTY;		
		private int _colCURRENCY		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxCURRENCY;	
		private int _colUNIT_PRICE		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxUNIT_PRICE;	
		private int _colAMOUNT			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxAMOUNT;	
		private int _colPUR_POSE		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxPUR_POSE;	
		private int _colETA				= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxETA;			
		private int _colCBD_YN			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxCBD_YN;		
		private int _colCBD_AMOUNT		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxCBD_AMOUNT;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtVendor;
		private C1.Win.C1List.C1Combo cmbVendor;
		private System.Windows.Forms.TextBox txtRate;			
		private System.Windows.Forms.DateTimePicker dpick_purYmd;
		private System.Windows.Forms.DateTimePicker dtpETA;
		private System.Windows.Forms.CheckBox chkETA;	
		private int _colMODEL_DESC		= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxMODEL_DESC;
		private int _colLINE_CD			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxLINE_CD;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1List.C1Combo cmbUser;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_Copy;
		private System.Windows.Forms.DateTimePicker dtpCopy;
		private int _colREMARKS			= (int)ClassLib.TBVM_SM_PURCHASE_ORDER.IxREMARKS;		



//
//		private string _sizeStartColumnLabel = "";
//		private string _sizeEndColumnLabel   = "";
//
//		private string _obsType = "";
//		private System.Windows.Forms.Label lbl_rate;
//		private System.Windows.Forms.Label lbl_remarks;
//		private System.Windows.Forms.TextBox txt_rate;
//
//		private Pop_BP_Purchase_Wait _waitPop;
//		
//		public C1FlexGrid grid { get { return fgrid_main; } }

		#endregion

		public Form_ST_Purchase_Order()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_ST_Purchase_Order));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.dtpCopy = new System.Windows.Forms.DateTimePicker();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbUser = new C1.Win.C1List.C1Combo();
			this.label6 = new System.Windows.Forms.Label();
			this.chkETA = new System.Windows.Forms.CheckBox();
			this.dtpETA = new System.Windows.Forms.DateTimePicker();
			this.dpick_purYmd = new System.Windows.Forms.DateTimePicker();
			this.cmbVendor = new C1.Win.C1List.C1Combo();
			this.txtVendor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb_purNo = new C1.Win.C1List.C1Combo();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.lbl_purStatus = new System.Windows.Forms.Label();
			this.lbl_purNo = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_purYmd = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.ctx_main = new System.Windows.Forms.ContextMenu();
			this.mnu_Insert_Model = new System.Windows.Forms.MenuItem();
			this.mnu_Change_Model = new System.Windows.Forms.MenuItem();
			this.mnu_Insert_Item = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnu_tree = new System.Windows.Forms.MenuItem();
			this.mnu_style = new System.Windows.Forms.MenuItem();
			this.mnu_item = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_main.SuspendLayout();
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
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.GridDefinition = "19.9652777777778:False:True;79.3402777777778:False:False;\t0.393700787401575:False" +
				":True;98.4251968503937:False:False;0.393700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 29;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.dtpCopy);
			this.pnl_head.Controls.Add(this.btn_Copy);
			this.pnl_head.Controls.Add(this.label7);
			this.pnl_head.Controls.Add(this.cmbUser);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.chkETA);
			this.pnl_head.Controls.Add(this.dtpETA);
			this.pnl_head.Controls.Add(this.dpick_purYmd);
			this.pnl_head.Controls.Add(this.cmbVendor);
			this.pnl_head.Controls.Add(this.txtVendor);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.cmb_purNo);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txtRate);
			this.pnl_head.Controls.Add(this.txt_status);
			this.pnl_head.Controls.Add(this.lbl_purStatus);
			this.pnl_head.Controls.Add(this.lbl_purNo);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_purYmd);
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
			this.pnl_head.Size = new System.Drawing.Size(1000, 115);
			this.pnl_head.TabIndex = 4;
			// 
			// dtpCopy
			// 
			this.dtpCopy.CustomFormat = "yyyy-MM-dd";
			this.dtpCopy.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtpCopy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCopy.Location = new System.Drawing.Point(808, 84);
			this.dtpCopy.Name = "dtpCopy";
			this.dtpCopy.Size = new System.Drawing.Size(104, 21);
			this.dtpCopy.TabIndex = 565;
			// 
			// btn_Copy
			// 
			this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.btn_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btn_Copy.ForeColor = System.Drawing.Color.Blue;
			this.btn_Copy.Location = new System.Drawing.Point(912, 84);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Copy.Size = new System.Drawing.Size(64, 21);
			this.btn_Copy.TabIndex = 564;
			this.btn_Copy.Text = "Copy";
			this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ImageIndex = 0;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(744, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 21);
			this.label7.TabIndex = 563;
			this.label7.Text = "Copy Date";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbUser
			// 
			this.cmbUser.AddItemCols = 0;
			this.cmbUser.AddItemSeparator = ';';
			this.cmbUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbUser.AutoSize = false;
			this.cmbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbUser.Caption = "";
			this.cmbUser.CaptionHeight = 17;
			this.cmbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbUser.ColumnCaptionHeight = 18;
			this.cmbUser.ColumnFooterHeight = 18;
			this.cmbUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbUser.ContentHeight = 17;
			this.cmbUser.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbUser.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbUser.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmbUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbUser.EditorHeight = 17;
			this.cmbUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbUser.GapHeight = 2;
			this.cmbUser.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmbUser.ItemHeight = 15;
			this.cmbUser.Location = new System.Drawing.Point(808, 62);
			this.cmbUser.MatchEntryTimeout = ((long)(2000));
			this.cmbUser.MaxDropDownItems = ((short)(5));
			this.cmbUser.MaxLength = 32767;
			this.cmbUser.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbUser.Name = "cmbUser";
			this.cmbUser.PartialRightColumn = false;
			this.cmbUser.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbUser.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbUser.Size = new System.Drawing.Size(168, 21);
			this.cmbUser.TabIndex = 562;
			this.cmbUser.TextChanged += new System.EventHandler(this.cmbUser_TextChanged);
			this.cmbUser.SelectedValueChanged += new System.EventHandler(this.cmbUser_SelectedValueChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(744, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 21);
			this.label6.TabIndex = 561;
			this.label6.Text = "User";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkETA
			// 
			this.chkETA.Location = new System.Drawing.Point(474, 65);
			this.chkETA.Name = "chkETA";
			this.chkETA.Size = new System.Drawing.Size(13, 13);
			this.chkETA.TabIndex = 560;
			this.chkETA.CheckedChanged += new System.EventHandler(this.chkETA_CheckedChanged);
			// 
			// dtpETA
			// 
			this.dtpETA.CustomFormat = "yyyy-MM-dd";
			this.dtpETA.Enabled = false;
			this.dtpETA.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpETA.Location = new System.Drawing.Point(493, 62);
			this.dtpETA.Name = "dtpETA";
			this.dtpETA.Size = new System.Drawing.Size(201, 21);
			this.dtpETA.TabIndex = 550;
			// 
			// dpick_purYmd
			// 
			this.dpick_purYmd.CustomFormat = "yyyy-MM-dd";
			this.dpick_purYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_purYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_purYmd.Location = new System.Drawing.Point(109, 62);
			this.dpick_purYmd.Name = "dpick_purYmd";
			this.dpick_purYmd.TabIndex = 549;
			this.dpick_purYmd.ValueChanged += new System.EventHandler(this.dpick_purYmd_ValueChanged);
			// 
			// cmbVendor
			// 
			this.cmbVendor.AddItemCols = 0;
			this.cmbVendor.AddItemSeparator = ';';
			this.cmbVendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmbVendor.AutoSize = false;
			this.cmbVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmbVendor.Caption = "";
			this.cmbVendor.CaptionHeight = 17;
			this.cmbVendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmbVendor.ColumnCaptionHeight = 18;
			this.cmbVendor.ColumnFooterHeight = 18;
			this.cmbVendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmbVendor.ContentHeight = 17;
			this.cmbVendor.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmbVendor.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmbVendor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmbVendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbVendor.EditorHeight = 17;
			this.cmbVendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmbVendor.GapHeight = 2;
			this.cmbVendor.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmbVendor.ItemHeight = 15;
			this.cmbVendor.Location = new System.Drawing.Point(569, 84);
			this.cmbVendor.MatchEntryTimeout = ((long)(2000));
			this.cmbVendor.MaxDropDownItems = ((short)(5));
			this.cmbVendor.MaxLength = 32767;
			this.cmbVendor.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmbVendor.Name = "cmbVendor";
			this.cmbVendor.PartialRightColumn = false;
			this.cmbVendor.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmbVendor.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmbVendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmbVendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmbVendor.Size = new System.Drawing.Size(125, 21);
			this.cmbVendor.TabIndex = 548;
			this.cmbVendor.SelChange += new System.ComponentModel.CancelEventHandler(this.cmbVendor_SelChange);
			this.cmbVendor.SelectedValueChanged += new System.EventHandler(this.cmbVendor_SelectedValueChanged);
			// 
			// txtVendor
			// 
			this.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtVendor.Location = new System.Drawing.Point(493, 84);
			this.txtVendor.MaxLength = 500;
			this.txtVendor.Name = "txtVendor";
			this.txtVendor.Size = new System.Drawing.Size(75, 21);
			this.txtVendor.TabIndex = 547;
			this.txtVendor.Text = "";
			this.txtVendor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyUp);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(392, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 546;
			this.label5.Text = "Vendor";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_purNo
			// 
			this.cmb_purNo.AddItemCols = 0;
			this.cmb_purNo.AddItemSeparator = ';';
			this.cmb_purNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_purNo.AutoSize = false;
			this.cmb_purNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_purNo.Caption = "";
			this.cmb_purNo.CaptionHeight = 17;
			this.cmb_purNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_purNo.ColumnCaptionHeight = 18;
			this.cmb_purNo.ColumnFooterHeight = 18;
			this.cmb_purNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_purNo.ContentHeight = 17;
			this.cmb_purNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_purNo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_purNo.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_purNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_purNo.EditorHeight = 17;
			this.cmb_purNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_purNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_purNo.GapHeight = 2;
			this.cmb_purNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_purNo.ItemHeight = 15;
			this.cmb_purNo.Location = new System.Drawing.Point(109, 84);
			this.cmb_purNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_purNo.MaxDropDownItems = ((short)(5));
			this.cmb_purNo.MaxLength = 32767;
			this.cmb_purNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_purNo.Name = "cmb_purNo";
			this.cmb_purNo.PartialRightColumn = false;
			this.cmb_purNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_purNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_purNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_purNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_purNo.Size = new System.Drawing.Size(200, 21);
			this.cmb_purNo.TabIndex = 545;
			this.cmb_purNo.SelectedValueChanged += new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(392, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 544;
			this.label4.Text = "ETA";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(392, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 543;
			this.label1.Text = "Exchange Rate";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRate
			// 
			this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txtRate.Location = new System.Drawing.Point(493, 40);
			this.txtRate.MaxLength = 500;
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(200, 21);
			this.txtRate.TabIndex = 542;
			this.txtRate.Text = "";
			this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_status
			// 
			this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_status.Location = new System.Drawing.Point(808, 40);
			this.txt_status.MaxLength = 500;
			this.txt_status.Name = "txt_status";
			this.txt_status.ReadOnly = true;
			this.txt_status.Size = new System.Drawing.Size(104, 21);
			this.txt_status.TabIndex = 538;
			this.txt_status.Text = "";
			this.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_purStatus
			// 
			this.lbl_purStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purStatus.ImageIndex = 0;
			this.lbl_purStatus.ImageList = this.img_Label;
			this.lbl_purStatus.Location = new System.Drawing.Point(744, 40);
			this.lbl_purStatus.Name = "lbl_purStatus";
			this.lbl_purStatus.Size = new System.Drawing.Size(64, 21);
			this.lbl_purStatus.TabIndex = 382;
			this.lbl_purStatus.Text = "Status";
			this.lbl_purStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_purNo
			// 
			this.lbl_purNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purNo.ImageIndex = 1;
			this.lbl_purNo.ImageList = this.img_Label;
			this.lbl_purNo.Location = new System.Drawing.Point(8, 84);
			this.lbl_purNo.Name = "lbl_purNo";
			this.lbl_purNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_purNo.TabIndex = 366;
			this.lbl_purNo.Text = "P.O #";
			this.lbl_purNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(984, 99);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_purYmd
			// 
			this.lbl_purYmd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purYmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purYmd.ImageIndex = 1;
			this.lbl_purYmd.ImageList = this.img_Label;
			this.lbl_purYmd.Location = new System.Drawing.Point(8, 62);
			this.lbl_purYmd.Name = "lbl_purYmd";
			this.lbl_purYmd.Size = new System.Drawing.Size(100, 21);
			this.lbl_purYmd.TabIndex = 50;
			this.lbl_purYmd.Text = "P.O Date";
			this.lbl_purYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 98);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(960, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.pic_head7.Size = new System.Drawing.Size(101, 74);
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
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 42;
			this.label2.Text = "       Search";
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
			this.pic_head5.Location = new System.Drawing.Point(0, 99);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 88);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pnl_main
			// 
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.fgrid_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 119);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1000, 457);
			this.pnl_main.TabIndex = 1;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ContextMenu = this.ctx_main;
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1000, 457);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 0;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgrid_main_KeyPress);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// ctx_main
			// 
			this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_Insert_Model,
																					 this.mnu_Change_Model,
																					 this.mnu_Insert_Item,
																					 this.menuItem1,
																					 this.mnu_tree,
																					 this.menuItem2});
			this.ctx_main.Popup += new System.EventHandler(this.ctx_main_Popup);
			// 
			// mnu_Insert_Model
			// 
			this.mnu_Insert_Model.Index = 0;
			this.mnu_Insert_Model.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.mnu_Insert_Model.Text = "Insert New Model";
			this.mnu_Insert_Model.Click += new System.EventHandler(this.mnu_Insert_Model_Click);
			// 
			// mnu_Change_Model
			// 
			this.mnu_Change_Model.Index = 1;
			this.mnu_Change_Model.Text = "Change Model";
			this.mnu_Change_Model.Click += new System.EventHandler(this.mnu_Change_Model_Click);
			// 
			// mnu_Insert_Item
			// 
			this.mnu_Insert_Item.Index = 2;
			this.mnu_Insert_Item.Text = "Insert New Item";
			this.mnu_Insert_Item.Click += new System.EventHandler(this.mnu_Insert_Item_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 3;
			this.menuItem1.Text = "-";
			// 
			// mnu_tree
			// 
			this.mnu_tree.Index = 4;
			this.mnu_tree.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnu_style,
																					 this.mnu_item});
			this.mnu_tree.Text = "View Option";
			// 
			// mnu_style
			// 
			this.mnu_style.Index = 0;
			this.mnu_style.Text = "Model";
			this.mnu_style.Click += new System.EventHandler(this.mnu_style_Click);
			// 
			// mnu_item
			// 
			this.mnu_item.Index = 1;
			this.mnu_item.Text = "Item";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 5;
			this.menuItem2.Text = "Delete";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			// 
			// Form_ST_Purchase_Order
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_ST_Purchase_Order";
			this.Load += new System.EventHandler(this.Form_ST_Purchase_Order_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		#endregion


		#region DB Connect

		/// <returns>DataTable</returns>
		public DataTable SELECT_SVM_ST_PURCHASE_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SVM_SM_PURCHASE_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_YMD";
			MyOraDB.Parameter_Name[2] = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = dpick_purYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmbUser, "");
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		public DataTable SELECT_SBC_RATE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SBC_RATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_PUR_YMD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = dpick_purYmd.Text.Replace("-", "");
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}




		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SVM_SM_PURCHASE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


		private void Form_ST_Purchase_Order_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.SetLangDic(this);

			this.Text		   = "Small Tooling";
			lbl_MainTitle.Text = "Purchasing Order";		

			// grid set
			fgrid_main.Set_Grid("SVM_SM_PURCHASING", "1", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Rows[3].Visible = false;
			fgrid_main.AllowDragging = AllowDraggingEnum.None;
			fgrid_main.Tree.Column = _colSEASON_YEAR;
			_Rowfixed = fgrid_main.Rows.Fixed;		

			//입력부 setup
			Init_Combo();
			
			_cmbPurNoEventHandler   = new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
			cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
			
			// grid set
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);

			for (int vCol = 1 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{
				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						_cellCombo.Add(vCol, fgrid_main.GetDataSourceWithCode(vCol));
					}
				}
			}

			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcrossOut; 
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			_firstLoad = false;

			this.Cmb_PurNoSettingProcess();
			this.txtRateSettingProcess();

			fgrid_main.Cols[14].Format = "###,###,##0.#";
			fgrid_main.Cols[16].Format = "###,###,##0.#";
			fgrid_main.Cols[17].Format = "###,###,##0.#";
			fgrid_main.Cols[19].Format = "###,###,##0.#";
		}


		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				DataTable vDt1;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;

				// cmb_purUser
				vDt1 = ClassLib.ComFunction.Select_User_Charge(ClassLib.ComVar.This_Factory);
				ClassLib.ComCtl.Set_ComboList(vDt1,cmbUser, 1, 1, true, 0, 210);
				//cmb_purUser.ValueMember = "Name";
				cmbUser.SelectedValue = COM.ComVar.This_User;
				
				vDt.Dispose();
				vDt1.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void dpick_purYmd_ValueChanged(object sender, System.EventArgs e)
		{
	
//			Init_Form();
			txtRate.Clear();
			dtpETA.Value = DateTime.Now;
			chkETA.Checked = false;
			txtVendor.Clear();
			cmbVendor.Text = "";
			

			this.Cmb_PurNoSettingProcess();
			this.txtRateSettingProcess();
		}

		private void txtRateSettingProcess()
		{
			try
			{
				DataTable vDt = SELECT_SBC_RATE();
				txtRate.Text = vDt.Rows[0].ItemArray[0].ToString();
				vDt.Dispose();
				
			}
			catch (Exception ex)
			{
				//
			}
		}

		private void Cmb_PurNoSettingProcess()
		{
			try
			{
				if (_practicable)
				{
					cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

					DataTable vDt = SELECT_SVM_ST_PURCHASE_NO_LIST();
					COM.ComCtl.Set_ComboList(vDt, cmb_purNo, 0, 0, false, false);
					vDt.Dispose();

					cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
				}
			}
			catch (Exception ex)
			{
				//
			}
		}


		private void cmb_purNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if( !_firstLoad )
			{
				this.Cmb_PurNoSelectedValueChangedProcess();
			}
		}


		private void Cmb_PurNoSelectedValueChangedProcess()
		{
			try
			{
				if (_doSearch)
				{
					if (cmb_purNo.SelectedIndex < 0)
						Tbtn_SearchProcess(false);
					else
						Tbtn_SearchProcess(true);
				}
			}
			catch (Exception ex)
			{
				//
			}
		}

		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (arg_bool)
				{
					_practicable = false;
					_doSearch = false;
				
					this.Search();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				//	
			}
			finally
			{
				_doSearch = true;
				_practicable = true;
				this.Cursor = Cursors.Default;
			}
		}


		private void Search()
		{ 
			// factory, pur_no
			DataTable vDt = SELECT_SBP_PURCHASE_LIST();
			
			if (vDt.Rows.Count > 0)
			{
				ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
			
				txtRate.Text = fgrid_main[_Rowfixed, _colREMARKS+1].ToString();

				if (fgrid_main[_Rowfixed, _colREMARKS+1].ToString().Length > 1)
					 txtRate.Text = fgrid_main[_Rowfixed, _colREMARKS+1].ToString();
				else txtRate.Text = "";

				if (fgrid_main[_Rowfixed, _colREMARKS+2].ToString().Length < 5)
				{
					chkETA.Checked = false;

					dtpETA.Value = DateTime.Now;
					dtpETA.Enabled = false;	
				}
				else
				{
					chkETA.Checked = true;
					dtpETA.Enabled = true;
					dtpETA.Value = ClassLib.ComFunction.StringToDateTime(fgrid_main[_Rowfixed, _colREMARKS+2].ToString());
				}
				
				fgrid_main.AutoSizeCols();

				if (fgrid_main[_Rowfixed, _colREMARKS+3].ToString().Length < 5)
					txtVendor.Text = "";
				else 
				{
					txtVendor.Text = fgrid_main[_Rowfixed, _colREMARKS+3].ToString();
					txtVendorKeyUpProcess();
					cmbVendor.SelectedIndex = 0;

					cmb_purNo.Select();
				}


				Grid_SetColor();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			else
			{
				fgrid_main.ClearAll();
			}

			vDt.Dispose();			
		}

		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				// design setting
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						//Grid_CheckPrice(fgrid_main.Rows[vRow].Node);
						break;
					case 2:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
						break;
				}
			}
		}



		private void mnu_Insert_Model_Click(object sender, System.EventArgs e)
		{
			Insert_New_Model();
		}

		private void Insert_New_Model()
		{
			try
			{
				Pop_DC_ModelSearch vPopup = new Pop_DC_ModelSearch();

				vPopup.ShowDialog(); 

				if (vPopup.DialogResult == DialogResult.Cancel)
					return;

				if(ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{

					string vKey = ClassLib.ComVar.Parameter_PopUp[0] + "\t" + 
						ClassLib.ComVar.Parameter_PopUp[1];

					int vRow = GetItemRow(vKey);
					int vEnd = fgrid_main.Rows.Count;

					if (vRow == fgrid_main.Rows.Count)
					{
						// Level 1
						C1.Win.C1FlexGrid.Node vNewRow					= fgrid_main.Rows.InsertNode(fgrid_main.Rows.Count, 1);
						fgrid_main[vNewRow.Row.Index, 0]                = "";
						fgrid_main[vNewRow.Row.Index, _colT_LEVEL]		= "1";
						fgrid_main[vNewRow.Row.Index, _colFACTORY]		= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
						fgrid_main[vNewRow.Row.Index, _colMODEL_CD]		= ClassLib.ComVar.Parameter_PopUp[0];
						fgrid_main[vNewRow.Row.Index, _colMODEL_NM]		= ClassLib.ComVar.Parameter_PopUp[1];

						if (vRow != _Rowfixed)
							fgrid_main[vNewRow.Row.Index, _colPUR_NO] 	= (fgrid_main[vNewRow.Row.Index-1, _colPUR_NO] == null) ? "" : fgrid_main[vNewRow.Row.Index-1, _colPUR_NO].ToString();

						fgrid_main.Rows[vNewRow.Row.Index].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_main.Rows[vNewRow.Row.Index].Node.EnsureVisible();
					}
					else	// 동일 스타일이 존재하는지 검사
					{
						Node vNode = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.NextSibling);
						vEnd = (vNode == null) ? fgrid_main.Rows.Count : vNode.Row.Index;

						for (int i = vRow + 1 ; i < vEnd ; i++)
						{
							if (fgrid_main[i, _colMODEL_CD].ToString().Equals("_________"))
							{
								fgrid_main.Select(vRow, 0, vRow, fgrid_main.Cols.Count - 1);
								ClassLib.ComFunction.User_Message("Exist Duplicate Model", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
						}
					}

					// Level 2
					C1.Win.C1FlexGrid.Node vNewRow2					= fgrid_main.Rows.InsertNode(++vRow, 2);
					fgrid_main[vNewRow2.Row.Index, 0]               = "I";
					fgrid_main[vNewRow2.Row.Index, _colT_LEVEL]		= "2";
					fgrid_main[vNewRow2.Row.Index, _colFACTORY]		= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
					fgrid_main[vNewRow2.Row.Index, _colMODEL_CD]	= fgrid_main[vNewRow2.Row.Index-1, _colMODEL_CD].ToString();
					fgrid_main[vNewRow2.Row.Index, _colPUR_NO] 	    = (fgrid_main[vNewRow2.Row.Index-1, _colPUR_NO] == null) ? "" : fgrid_main[vNewRow2.Row.Index-1, _colPUR_NO].ToString();

				}
			}
			catch(Exception ex)
			{
				//
			}
		}

		private void mnu_Change_Model_Click(object sender, System.EventArgs e)
		{
			Change_New_Model();
		}

		private void Change_New_Model()
		{
			try
			{
				int iRow = fgrid_main.Selection.r1;

				Pop_DC_ModelSearch vPopup = new Pop_DC_ModelSearch();

				vPopup.ShowDialog(); 

				if(ClassLib.ComVar.Parameter_PopUp[0].Trim() != "")
				{

					string vKey = ClassLib.ComVar.Parameter_PopUp[0] + "\t" + 
						ClassLib.ComVar.Parameter_PopUp[1];

					fgrid_main[iRow, _colMODEL_CD] = ClassLib.ComVar.Parameter_PopUp[0];
					fgrid_main[iRow, _colMODEL_NM] = ClassLib.ComVar.Parameter_PopUp[1];

					Grid_AfterEditProcess();

				}
			}
			catch(Exception ex)
			{
				//
			}
		}


		private int GetItemRow(string arg_key)
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				if (fgrid_main.Rows[vRow].Node.Level == 1)
				{
					string vKey = fgrid_main.GetCellRange(vRow, _colMODEL_CD).Clip;

					if (vKey.Equals(arg_key))
					{
						fgrid_main.Select(vRow, 0, vRow, fgrid_main.Cols.Count - 1);
						return vRow;
					}
				}
			}

			return fgrid_main.Rows.Count;
		}

		private void fgrid_main_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			int iRow = fgrid_main.Selection.r1;
			int iCol = fgrid_main.Selection.c1;

			if (fgrid_main.Cols[iCol].DataType.Equals(typeof(DateTime)))				
			{
				if (e.KeyChar == 8)
				{
					fgrid_main.Col = iCol+1;
					fgrid_main[iRow, iCol] = null;
				}
			}	
//			if ((iCol == 16) ||( iCol == 19))
//			{
//				 
//			}
		}

		private void mnu_Insert_Item_Click(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_main.Selection.r1;
			add_row(sel_row);
		}

		private void add_row(int arg_sel_row)
		{
			try
			{
				C1.Win.C1FlexGrid.Node node = fgrid_main.Rows[arg_sel_row].Node;
	
				node.AddNode(NodeTypeEnum.LastChild, "");

				int current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 

				// Set Default Value //
				fgrid_main[current_row, 0]              = "I";
				fgrid_main[current_row, _colT_LEVEL]	= "2";
				fgrid_main[current_row, _colFACTORY]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
				fgrid_main[current_row, _colPUR_NO]  	= (fgrid_main[current_row-1, _colPUR_NO] == null) ? "" : fgrid_main[current_row-1, _colPUR_NO].ToString();
				fgrid_main[current_row, _colMODEL_CD]	= fgrid_main[current_row-1, _colMODEL_CD].ToString();

				fgrid_main[current_row, _colCOMPONENT_M_NM]	= fgrid_main[current_row-1, _colCOMPONENT_M_NM].ToString();
				fgrid_main[current_row, _colCOMPONENT_S_NM]	= (fgrid_main[current_row-1, _colCOMPONENT_S_NM] == null) ? "" : fgrid_main[current_row-1, _colCOMPONENT_S_NM].ToString();
//				fgrid_main[current_row, _colRE_QTY]    = fgrid_main[current_row-1, _colRE_QTY].ToString();    				
				fgrid_main[current_row, _colSIZE_DESC] = (fgrid_main[current_row-1, _colSIZE_DESC] == null) ? "" : fgrid_main[current_row-1, _colSIZE_DESC].ToString();
				fgrid_main[current_row, _colCURRENCY]  = fgrid_main[current_row-1, _colCURRENCY].ToString();
			}
			catch(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void ctx_main_Popup(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_main.Selection.r1;

				if (fgrid_main[sel_row, _colT_LEVEL].ToString()	!= "1")
				{
					mnu_Insert_Item.Enabled  = false;
					mnu_Change_Model.Enabled = false;
				}
				else
				{
					mnu_Insert_Item.Enabled  = true;
					mnu_Change_Model.Enabled = true;
				}

			}
			catch(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			try
			{
				string sLevel = fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString();
				int    iCol   = fgrid_main.Selection.c1;

				if (sLevel.Equals("1"))
				{
					if ((iCol == _colSEASON)||
						(iCol == _colSEASON_YEAR)||
						(iCol == _colMODEL_DESC)||
						(iCol == _colPUR_POSE)||
						(iCol == _colLINE_CD))
					{
						fgrid_main.Cols[iCol].AllowEditing = true;
					}
					else fgrid_main.Cols[iCol].AllowEditing = false;

				}
				else if (sLevel.Equals("2"))
				{
					if ((iCol == _colSEASON)||
						(iCol == _colSEASON_YEAR)||
						(iCol == _colMODEL_NM)||
						(iCol == _colMODEL_DESC)||
						(iCol == _colLINE_CD))
					{
						fgrid_main.Cols[iCol].AllowEditing = false;
					}			
					else fgrid_main.Cols[iCol].AllowEditing = true;
				}
			}
			catch (Exception ex)
			{
				//
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save",						   MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();
					this.Cmb_PurNoSettingProcess();
			
					if (cmb_purNo.SelectedIndex == -1)
						cmb_purNo.SelectedIndex = cmb_purNo.ListCount-1;

					//this.Tbtn_SearchProcess(true);

				}
			}
			else
			{
				//
			}		
		}

		private bool Validate_Check()
		{
//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//			{
//
//
//			}
			if (txtRate.Text.Equals("")) 
			{
				MessageBox.Show("Please input Exchange Rate.");	
				return false;
			}
			else
				return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_SM_PURCHASE(true))
				{
					fgrid_main.Refresh_Division();					
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				//
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_SM_PURCHASE(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 30;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SAVE_SVM_SM_PURCHASE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_HEAD_YN";
				MyOraDB.Parameter_Name[ 2] = "ARG_REC_DIV";
				MyOraDB.Parameter_Name[ 3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 4] = "ARG_PUR_YMD";
				MyOraDB.Parameter_Name[ 5] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[ 6] = "ARG_PUR_SEQ";
				MyOraDB.Parameter_Name[ 7] = "ARG_CUST_CD";
				MyOraDB.Parameter_Name[ 8] = "ARG_EXCHANGE_RATE";
				MyOraDB.Parameter_Name[ 9] = "ARG_ETA";
				MyOraDB.Parameter_Name[10] = "ARG_COMP_CD_M";
				MyOraDB.Parameter_Name[11] = "ARG_COMP_CD_S";
				MyOraDB.Parameter_Name[12] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[13] = "ARG_PURPOSE";
				MyOraDB.Parameter_Name[14] = "ARG_CURRENCY";
				MyOraDB.Parameter_Name[15] = "ARG_UNIT_PRICE";
				MyOraDB.Parameter_Name[16] = "ARG_SPEC";
				MyOraDB.Parameter_Name[17] = "ARG_UNIT";
				MyOraDB.Parameter_Name[18] = "ARG_RE_QTY";
				MyOraDB.Parameter_Name[19] = "ARG_PUR_QTY";
				MyOraDB.Parameter_Name[20] = "ARG_AMOUNT";
				MyOraDB.Parameter_Name[21] = "ARG_CBD_YN";
				MyOraDB.Parameter_Name[22] = "ARG_CBD_AMOUNT";
				MyOraDB.Parameter_Name[23] = "ARG_SIZE_DESC";
				MyOraDB.Parameter_Name[24] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[25] = "ARG_SEASON";
				MyOraDB.Parameter_Name[26] = "ARG_SEASON_YEAR";
				MyOraDB.Parameter_Name[27] = "ARG_MODEL_DESC";
				MyOraDB.Parameter_Name[28] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[29] = "ARG_UPD_USER";


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;

				save_ct += 1; // HEAD RECORD

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{

					if (fgrid_main[iRow, _colT_LEVEL].ToString().Equals("1"))
					{
						_sModel      = (fgrid_main[iRow, _colMODEL_CD]    == null) ? ""  : fgrid_main[iRow, _colMODEL_CD].ToString();
						_sSeason     = (fgrid_main[iRow, _colSEASON]      == null) ? ""  : fgrid_main[iRow, _colSEASON].ToString();
						_sYear       = (fgrid_main[iRow, _colSEASON_YEAR] == null) ? ""  : fgrid_main[iRow, _colSEASON_YEAR].ToString();
						_sModel_Desc = (fgrid_main[iRow, _colMODEL_DESC]  == null) ? ""  : fgrid_main[iRow, _colMODEL_DESC].ToString();
						_sLine_cd    = (fgrid_main[iRow, _colLINE_CD]     == null) ? ""  : fgrid_main[iRow, _colLINE_CD].ToString();
						_sPur_pose   = (fgrid_main[iRow, _colPUR_POSE]    == null) ? ""  : fgrid_main[iRow, _colPUR_POSE].ToString();
					}
					else if (fgrid_main[iRow, 0] == null)
						continue;
					else
					{			
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = "N";

						if (iRow == _Rowfixed+1)
							MyOraDB.Parameter_Values[para_ct+ 2] = "T";
						else if (fgrid_main.Rows.Count-1 == iRow)
							MyOraDB.Parameter_Values[para_ct+ 2] = "E";
						else
							MyOraDB.Parameter_Values[para_ct+ 2] = "F";

						MyOraDB.Parameter_Values[para_ct+ 3] = cmb_factory.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = dpick_purYmd.Text.Replace("-", "");
						MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_main[iRow, _colPUR_NO]  == null) ? ""  : fgrid_main[iRow, _colPUR_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = (fgrid_main[iRow, _colPUR_SEQ] == null) ? "0"  : fgrid_main[iRow, _colPUR_SEQ].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.Empty_TextBox(txtVendor, "");
						MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.Empty_TextBox(txtRate, "0");
						MyOraDB.Parameter_Values[para_ct+ 9] = (chkETA.Checked) ? dtpETA.Text.Replace("-", "") : "";
						MyOraDB.Parameter_Values[para_ct+10] = (fgrid_main[iRow, _colCOMPONENT_M_NM] == null) ? ""  : fgrid_main[iRow, _colCOMPONENT_M_NM].ToString();
						MyOraDB.Parameter_Values[para_ct+11] = (fgrid_main[iRow, _colCOMPONENT_S_NM] == null) ? ""  : fgrid_main[iRow, _colCOMPONENT_S_NM].ToString();
						MyOraDB.Parameter_Values[para_ct+12] = (fgrid_main[iRow, _colITEM_NM] == null)        ? "__"  : fgrid_main[iRow, _colITEM_NM].ToString();
//						MyOraDB.Parameter_Values[para_ct+13] = (fgrid_main[iRow, _colPUR_POSE] == null)       ? ""  : fgrid_main[iRow, _colPUR_POSE].ToString();
						MyOraDB.Parameter_Values[para_ct+13] = _sPur_pose.ToString();
						MyOraDB.Parameter_Values[para_ct+14] = (fgrid_main[iRow, _colCURRENCY] == null)       ? ""  : fgrid_main[iRow, _colCURRENCY].ToString();
						MyOraDB.Parameter_Values[para_ct+15] = (fgrid_main[iRow, _colUNIT_PRICE] == null)     ? "0" : fgrid_main[iRow, _colUNIT_PRICE].ToString();
						MyOraDB.Parameter_Values[para_ct+16] = (fgrid_main[iRow, _colSPEC] == null)           ? ""  : fgrid_main[iRow, _colSPEC].ToString();
						MyOraDB.Parameter_Values[para_ct+17] = (fgrid_main[iRow, _colUNIT] == null)           ? ""  : fgrid_main[iRow, _colUNIT].ToString();
						MyOraDB.Parameter_Values[para_ct+18] = (fgrid_main[iRow, _colRE_QTY] == null)         ? "0" : fgrid_main[iRow, _colRE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+19] = (fgrid_main[iRow, _colPUR_QTY] == null)        ? "0" : fgrid_main[iRow, _colPUR_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+20] = (fgrid_main[iRow, _colAMOUNT] == null)         ? "0" : fgrid_main[iRow, _colAMOUNT].ToString();
						MyOraDB.Parameter_Values[para_ct+21] = (fgrid_main[iRow, _colCBD_YN] == null)         ? ""  : fgrid_main[iRow, _colCBD_YN].ToString();
						MyOraDB.Parameter_Values[para_ct+22] = (fgrid_main[iRow, _colCBD_AMOUNT] == null)     ? "0" : fgrid_main[iRow, _colCBD_AMOUNT].ToString();
						MyOraDB.Parameter_Values[para_ct+23] = (fgrid_main[iRow, _colSIZE_DESC] == null)      ? ""  : fgrid_main[iRow, _colSIZE_DESC].ToString();
						MyOraDB.Parameter_Values[para_ct+24] = _sModel.ToString();
						MyOraDB.Parameter_Values[para_ct+25] = _sSeason.ToString();
						MyOraDB.Parameter_Values[para_ct+26] = _sYear.ToString();
						MyOraDB.Parameter_Values[para_ct+27] = _sModel_Desc.ToString();
						MyOraDB.Parameter_Values[para_ct+28] = _sLine_cd.ToString();					
						MyOraDB.Parameter_Values[para_ct+29] = COM.ComVar.This_User;
						
						para_ct += iCount;
					}
				}

				// HEAD RECORD
				MyOraDB.Parameter_Values[para_ct+ 0] = "";
				MyOraDB.Parameter_Values[para_ct+ 1] = "Y";
				MyOraDB.Parameter_Values[para_ct+ 2] = "";
				MyOraDB.Parameter_Values[para_ct+ 3] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct+ 4] = dpick_purYmd.Text.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct+ 5] = ClassLib.ComFunction.Empty_Combo(cmb_purNo, "");
				MyOraDB.Parameter_Values[para_ct+ 6] = "99";
				MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.Empty_TextBox(txtVendor, "");
				MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.Empty_TextBox(txtRate, "0");
				MyOraDB.Parameter_Values[para_ct+ 9] = (chkETA.Checked) ? dtpETA.Text.Replace("-", "") : "";
				MyOraDB.Parameter_Values[para_ct+10] = "";
				MyOraDB.Parameter_Values[para_ct+11] = "";
				MyOraDB.Parameter_Values[para_ct+12] = "";
				MyOraDB.Parameter_Values[para_ct+13] = "";
				MyOraDB.Parameter_Values[para_ct+14] = "";
				MyOraDB.Parameter_Values[para_ct+15] = "";
				MyOraDB.Parameter_Values[para_ct+16] = "";
				MyOraDB.Parameter_Values[para_ct+17] = "";
				MyOraDB.Parameter_Values[para_ct+18] = "";
				MyOraDB.Parameter_Values[para_ct+19] = "";
				MyOraDB.Parameter_Values[para_ct+20] = "";
				MyOraDB.Parameter_Values[para_ct+21] = "";
				MyOraDB.Parameter_Values[para_ct+22] = "";
				MyOraDB.Parameter_Values[para_ct+23] = "";
				MyOraDB.Parameter_Values[para_ct+24] = "";
				MyOraDB.Parameter_Values[para_ct+25] = "";
				MyOraDB.Parameter_Values[para_ct+26] = "";
				MyOraDB.Parameter_Values[para_ct+27] = "";
				MyOraDB.Parameter_Values[para_ct+28] = "";
				MyOraDB.Parameter_Values[para_ct+29] = COM.ComVar.This_User;
						
				para_ct += iCount;


				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}

		private void txtVendor_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				txtVendorKeyUpProcess();		
		}


		private void txtVendorKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				if (txtVendor.Text.Trim().Length > 0)
				{
					vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txtVendor.Text);
					
					cmbVendor.SelectedValue = txtVendor.Text;

					if (vDt.Rows.Count > 0)
					{
							ClassLib.ComCtl.Set_ComboList(vDt, cmbVendor, 0, 1, false, 80, 140);
					}
					else
					{
						ClassLib.ComFunction.User_Message("Data Not Found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtVendor.Text = "";
						cmbVendor.ClearItems();
					}

					txtVendor.Focus();
				}
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}


		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
			
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" :						fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}


		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
			this.tinh(); 

		}

		private void Grid_AfterEditProcess()
		{

			try
			{
				int iCol = fgrid_main.Selection.c1;
				int iRow = fgrid_main.Selection.r1;
			
				if ((iCol == _colSEASON_YEAR))
				{
					string sYear = fgrid_main[iRow, iCol].ToString();

					if (sYear.Length != 2)
						fgrid_main[iRow, iCol] = "__";
				}


//				if (iCol == _colITEM_NM)
//					fgrid_main[iRow, _colCBD_YN] = fgrid_main.GetCellRange(iRow, iCol).Clip.Substring(4,1);

				int iPos;
				iPos = fgrid_main.GetCellRange(iRow, iCol).Clip.ToString().Length-1;

				if (iCol == _colITEM_NM)
				fgrid_main[iRow, _colCBD_YN] = fgrid_main.GetCellRange(iRow, iCol).Clip.Substring(iPos,1);


				if (fgrid_main[iRow, _colT_LEVEL].ToString().Equals("1"))
				{
					int iEnd = fgrid_main.Rows.Count;

					for (int i = iRow+1; i < iEnd ; i++)
					{
						if (fgrid_main[i, 0] == null)
					 		fgrid_main[i, 0] = "";

						if ((fgrid_main[i, _colT_LEVEL].ToString().Equals("1"))||
							(fgrid_main[i,           0].ToString().Equals("I")))
							return;

						else fgrid_main.Update_Row(i);
						
					}
				
				}
				else fgrid_main.Update_Row();

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void tinh()
		{
			double DSpec ;
			double DReqty;
			double DpurQty ;
			double DpurPri;

			int iR = fgrid_main.Selection.r1 ;
			int iC = fgrid_main.Selection.c1 ; 
			
			string Spec =  (fgrid_main[iR, 14] == null)       ? ""  : fgrid_main[iR, 14].ToString();
			if (iC == 16 )
			{
//				if (Char.IsNumber(Convert.ToChar(fgrid_main[iRow,14].ToString())) == false)
				if (!Spec.ToString().Equals(""))
					
					DSpec = Convert.ToDouble(fgrid_main[iR,14].ToString());
				else if (Spec.ToString().Length > 3)
				{
					DSpec = 1;
				}
				else
				{
					DSpec = 1;
				}
				DReqty = Convert.ToDouble(fgrid_main[iR,16].ToString());

				fgrid_main[iR, 17] = Convert.ToString(DSpec*DReqty);
			}
			else if (iC == 19)
			{
				DpurQty = Convert.ToDouble(fgrid_main[iR,17].ToString());
				DpurPri = Convert.ToDouble(fgrid_main[iR,19].ToString());

				fgrid_main[iR, 20] = Convert.ToString(DpurQty*DpurPri);
				
			}
		}		

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Cmb_PurNoSelectedValueChangedProcess();
		}

		private void cmbVendor_SelChange(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		private void cmbVendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ValueSelectedValueChangedProcess();
		}

		private void Cmb_ValueSelectedValueChangedProcess()
		{
			try
			{
				txtVendor.Text = cmbVendor.SelectedValue.ToString();
			}
			catch // (Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}


		private void chkETA_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkETA.Checked)
				 dtpETA.Enabled = true;
			else dtpETA.Enabled = false;		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();			
		}

		private void Tbtn_NewProcess()
		{
				ClearInfo();
				fgrid_main.ClearAll();
		}

		private void ClearInfo()
		{
			this.cmb_purNo.SelectedValueChanged -= _cmbPurNoEventHandler;

			cmb_factory.SelectedValue		= COM.ComVar.This_Factory;
			dtpETA.Value				    = DateTime.Now;
			chkETA.Checked                  = false;
//			dpick_purYmd.Value              = DateTime.Now;
			txt_status.Clear();
			txtRate.Clear();
			txtVendor.Clear();
			cmbVendor.SelectedIndex         = -1;
			cmb_purNo.SelectedIndex			= -1;

			this.cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
			this.txtRateSettingProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_ST_PURCHASE_ORDER();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void PRINT_ST_PURCHASE_ORDER()
		{
			string sDir;
			
			sDir = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Purchase Order Sheet");

			string sPara;

			

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = cmb_purNo.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[ 2]   = cmb_season.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +	"' ";			            //Parm1: Factory
			sPara += "'" + cmb_purNo.SelectedValue.ToString() +	"' ";						                //Parm2: Out Date
//			sPara += "'" + cmb_season.SelectedValue.ToString() +	"' ";						      	//Parm3: Out Line
//			sPara += "'" + txt_season_year.Text +	"' ";						                    	//Parm4: Item

			FlexMold.Report.Form_RdViewer MyReport = new FlexMold.Report.Form_RdViewer(sDir, sPara);

			//			FlexMold.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			// Delete all 
			this.Tbtn_DeleteProcess();
			
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
//			int iRow = fgrid_main.Selection.r1;			
//			fgrid_main.Delete_Row(iRow);
			Grid_AfterEditDelete();

		}
		private void Grid_AfterEditDelete()
		{

			try
			{
				int iCol = fgrid_main.Selection.c1;
				int iRow = fgrid_main.Selection.r1;
			
				if ((iCol == _colSEASON_YEAR))
				{
					string sYear = fgrid_main[iRow, iCol].ToString();

					if (sYear.Length != 2)
						fgrid_main[iRow, iCol] = "__";
				}


//				if (iCol == _colITEM_NM)
//					fgrid_main[iRow, _colCBD_YN] = fgrid_main.GetCellRange(iRow, iCol).Clip.Substring(4,1);

				int iPos;
				iPos = fgrid_main.GetCellRange(iRow, iCol).Clip.ToString().Length-1;

				if (iCol == _colITEM_NM)
					fgrid_main[iRow, _colCBD_YN] = fgrid_main.GetCellRange(iRow, iCol).Clip.Substring(iPos,1);											
				if (fgrid_main[iRow, _colT_LEVEL].ToString().Equals("1"))
				{
					int iEnd = fgrid_main.Rows.Count;

					for (int i = iRow+1; i < iEnd ; i++)
					{
						if (fgrid_main[i, 0] == null)
							fgrid_main[i, 0] = "";

						if ((fgrid_main[i, _colT_LEVEL].ToString().Equals("1"))||
							(fgrid_main[i,           0].ToString().Equals("I")))
							return;

						else fgrid_main.Delete_Row(i);
						
					}
				
				}
				else fgrid_main.Delete_Row();

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}
		
		private void Tbtn_DeleteProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (DELETE_SVM_SM_PURCHASE(true))
				{
					fgrid_main.Refresh_Division();					
					MessageBox.Show("delete Complete","Delete", MessageBoxButtons.OK ,MessageBoxIcon.Information);
					this.Tbtn_SearchProcess(true); 
				}
			}
			catch (Exception ex)
			{
				//
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool DELETE_SVM_SM_PURCHASE(bool doExecute)
		{
			try
			{
				MyOraDB.ReDim_Parameter(2);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.DELETE_SVM_SM_PURCHASE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";				
				MyOraDB.Parameter_Name[1] = "ARG_PUR_NO";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values  = new string[2];

				MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();

				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}

		}

		private void mnu_style_Click(object sender, System.EventArgs e)
		{
		
		}

		private void cmbUser_SelectedValueChanged(object sender, System.EventArgs e)
		{
			txtRate.Clear();
			dtpETA.Value = DateTime.Now;
			chkETA.Checked = false;
			txtVendor.Clear();
			cmbVendor.Text = "";
			

			this.Cmb_PurNoSettingProcess();
			this.txtRateSettingProcess();
		}

		private void cmbUser_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btn_Copy_Click(object sender, System.EventArgs e)
		{
//			if (Validate_Check())
			if ((cmb_purNo.Text.ToString() != "")&& (fgrid_main.Rows.Count > 3))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to Copy?","Copy",						   MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_CopyProcess();
					this.Cmb_PurNoSettingProcess();
			
					if (cmb_purNo.SelectedIndex == -1)
						cmb_purNo.SelectedIndex = cmb_purNo.ListCount-1;

					//this.Tbtn_SearchProcess(true);

				}
			}
			else
			{
				MessageBox.Show("Please Choose P.O # ");	
//				return false;
				//
			}		
		
		}

		private void Tbtn_CopyProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (COPY_SVM_SM_PURCHASE(true))
				{
					fgrid_main.Refresh_Division();					
					MessageBox.Show("Copy Complete","Copy", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				//
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool COPY_SVM_SM_PURCHASE(bool doExecute)
		{
			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.COPY_SVM_SM_PURCHASE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 1] = "ARG_PUR_YMD";
				MyOraDB.Parameter_Name[ 2] = "ARG_PUR_NO";
				MyOraDB.Parameter_Name[ 3] = "ARG_UPD_USER";

				MyOraDB.Parameter_Type[ 0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[ 3] = (int)OracleType.VarChar;

				MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = dtpCopy.Text.Replace("-", "");
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_purNo, "");
				MyOraDB.Parameter_Values[3] = COM.ComVar.This_User;
				
				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}



	}
}

