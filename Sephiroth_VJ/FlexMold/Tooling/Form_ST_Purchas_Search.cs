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
	public class Form_ST_Purchas_Search : COM.MoldWinForm.Form_Top
	{


		#region Design creation

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_purStatus;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label btn_Tree;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Panel pnl_main;
		private COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo c1Combo2;
		private C1.Win.C1List.C1Combo c1Combo3;
		private C1.Win.C1List.C1Combo c1Combo5;
		private System.Windows.Forms.TextBox txt_model_name;
		private System.Windows.Forms.TextBox txt_model_code;
		private System.Windows.Forms.TextBox txt_season_year;
		private System.ComponentModel.IContainer components = null;

		#endregion


		#region User Define

		private COM.OraDB MyOraDB = new COM.OraDB();
		private int _Rowfixed;
//		private System.EventHandler   _cmbPurNoEventHandler   = null;
//		private bool _practicable  = true, _doSearch = true;
		private bool _firstLoad    = true;
//		private int _purSeq = 0;
//		private int _startCol = 4;
		private Hashtable _cellCombo = null;
		//private C1.Win.C1List.C1Combo cmb_purNo;

		private C1.Win.C1List.C1Combo cmb_season;
		private C1.Win.C1List.C1Combo cmb_model;
		//		private const int _validate_context = 20;
		//		private const int _maxPrice = 50;
		//		private const string _CBDCurrency = "USD";
		//		private double _rate ;
		//		private int _controlLevel;
		//		private ArrayList _level1 = new ArrayList(20);

		//private AxRDVIEWER40Lib.AxRdviewer40 myRD401;

		private int _colT_LEVEL			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxT_LEVEL;
		private int _colCHK				= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCHK;		
		private int _colFACTORY			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxFACTORY;
		private int _colMODEL_CD		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxMODEL_CD;		
		private int _colMODEL_NM		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxMODEL_NM;	
		private int _colSEASON			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxSEASON;	
		private int _colSEASON_YEAR		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxSEASON_YEAR;
		private int _colCOMPONENT_M_NM	= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCOMPONENT_M_NM;
		private int _colCOMPONENT_S_NM	= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCOMPONENT_S_NM;
		private int _colITEM_NM			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxITEM_NM;
		private int _colSIZE_DESC		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxSIZE_DESC;
		private int _colSPEC			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxSPEC;	
		private int _colUNIT			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxUNIT;
		private int _colRE_QTY			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxRE_QTY;
		private int _colPUR_QTY			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxPUR_QTY;
		private int _colCURRENCY		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCURRENCY;
		private int _colUNIT_PRICE		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxUNIT_PRICE;
		private int _colAMOUNT			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxAMOUNT;	
		private int _colCBD_YN			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCBD_YN;
		private int _colCBD_AMOUNT		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxCBD_AMOUNT;
		private int _colPUR_POSE		= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxPUR_POSE;	
		private int _colREMARKS			= (int)ClassLib.TBVM_SM_PURCHASE_SEARCH.IxREMARKS;
				
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

		public Form_ST_Purchas_Search()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_ST_Purchas_Search));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.cmb_season = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_season_year = new System.Windows.Forms.TextBox();
			this.txt_model_name = new System.Windows.Forms.TextBox();
			this.lbl_purStatus = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.txt_model_code = new System.Windows.Forms.TextBox();
			this.cmb_model = new C1.Win.C1List.C1Combo();
			this.pnl_low = new System.Windows.Forms.Panel();
			this.btn_Tree = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.c1Combo5 = new C1.Win.C1List.C1Combo();
			this.c1Combo2 = new C1.Win.C1List.C1Combo();
			this.c1Combo3 = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_model)).BeginInit();
			this.pnl_low.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
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
			this.c1Sizer1.Controls.Add(this.pnl_low);
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.GridDefinition = "19.9652777777778:False:True;0.173611111111111:False:True;77.7777777777778:False:F" +
				"alse;0:False:True;\t0.393700787401575:False:True;98.4251968503937:False:False;0.3" +
				"93700787401575:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.txt_model_name);
			this.pnl_head.Controls.Add(this.cmb_season);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_season_year);
			this.pnl_head.Controls.Add(this.lbl_purStatus);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.txt_model_code);
			this.pnl_head.Controls.Add(this.cmb_model);
			this.pnl_head.Location = new System.Drawing.Point(8, 0);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(1000, 115);
			this.pnl_head.TabIndex = 4;
			// 
			// cmb_season
			// 
			this.cmb_season.AddItemCols = 0;
			this.cmb_season.AddItemSeparator = ';';
			this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_season.AutoSize = false;
			this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_season.Caption = "";
			this.cmb_season.CaptionHeight = 17;
			this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_season.ColumnCaptionHeight = 18;
			this.cmb_season.ColumnFooterHeight = 18;
			this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_season.ContentHeight = 17;
			this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_season.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_season.EditorHeight = 17;
			this.cmb_season.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_season.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_season.GapHeight = 2;
			this.cmb_season.ItemHeight = 15;
			this.cmb_season.Location = new System.Drawing.Point(109, 84);
			this.cmb_season.MatchEntryTimeout = ((long)(2000));
			this.cmb_season.MaxDropDownItems = ((short)(5));
			this.cmb_season.MaxLength = 32767;
			this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_season.Name = "cmb_season";
			this.cmb_season.PartialRightColumn = false;
			this.cmb_season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_season.Size = new System.Drawing.Size(99, 21);
			this.cmb_season.TabIndex = 547;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 543;
			this.label1.Text = "Season";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_season_year
			// 
			this.txt_season_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_season_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_season_year.Location = new System.Drawing.Point(209, 84);
			this.txt_season_year.MaxLength = 2;
			this.txt_season_year.Name = "txt_season_year";
			this.txt_season_year.TabIndex = 542;
			this.txt_season_year.Text = "";
			// 
			// txt_model_name
			// 
			this.txt_model_name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_model_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_model_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_model_name.Location = new System.Drawing.Point(109, 62);
			this.txt_model_name.MaxLength = 500;
			this.txt_model_name.Name = "txt_model_name";
			this.txt_model_name.Size = new System.Drawing.Size(181, 21);
			this.txt_model_name.TabIndex = 538;
			this.txt_model_name.Text = "";
			this.txt_model_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_model_name_KeyPress);
			// 
			// lbl_purStatus
			// 
			this.lbl_purStatus.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purStatus.ImageIndex = 1;
			this.lbl_purStatus.ImageList = this.img_Label;
			this.lbl_purStatus.Location = new System.Drawing.Point(8, 62);
			this.lbl_purStatus.Name = "lbl_purStatus";
			this.lbl_purStatus.Size = new System.Drawing.Size(100, 21);
			this.lbl_purStatus.TabIndex = 382;
			this.lbl_purStatus.Text = "Model";
			this.lbl_purStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// txt_model_code
			// 
			this.txt_model_code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_model_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_model_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.txt_model_code.Location = new System.Drawing.Point(108, 62);
			this.txt_model_code.MaxLength = 500;
			this.txt_model_code.Name = "txt_model_code";
			this.txt_model_code.Size = new System.Drawing.Size(56, 21);
			this.txt_model_code.TabIndex = 549;
			this.txt_model_code.Text = "";
			this.txt_model_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmb_model
			// 
			this.cmb_model.AddItemCols = 0;
			this.cmb_model.AddItemSeparator = ';';
			this.cmb_model.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_model.AutoSize = false;
			this.cmb_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_model.Caption = "";
			this.cmb_model.CaptionHeight = 17;
			this.cmb_model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_model.ColumnCaptionHeight = 18;
			this.cmb_model.ColumnFooterHeight = 18;
			this.cmb_model.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_model.ContentHeight = 17;
			this.cmb_model.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_model.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
			this.cmb_model.DropDownWidth = 400;
			this.cmb_model.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_model.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_model.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_model.EditorHeight = 17;
			this.cmb_model.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_model.GapHeight = 2;
			this.cmb_model.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_model.ItemHeight = 15;
			this.cmb_model.Location = new System.Drawing.Point(109, 62);
			this.cmb_model.MatchEntryTimeout = ((long)(2000));
			this.cmb_model.MaxDropDownItems = ((short)(5));
			this.cmb_model.MaxLength = 32767;
			this.cmb_model.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_model.Name = "cmb_model";
			this.cmb_model.PartialRightColumn = false;
			this.cmb_model.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_model.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_model.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_model.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_model.Size = new System.Drawing.Size(200, 21);
			this.cmb_model.TabIndex = 550;
			this.cmb_model.SelectedValueChanged += new System.EventHandler(this.cmb_model_SelectedValueChanged);
			// 
			// pnl_low
			// 
			this.pnl_low.BackColor = System.Drawing.Color.Transparent;
			this.pnl_low.Controls.Add(this.btn_Tree);
			this.pnl_low.Controls.Add(this.btn_delete);
			this.pnl_low.Controls.Add(this.btn_recover);
			this.pnl_low.Controls.Add(this.btn_Insert);
			this.pnl_low.Location = new System.Drawing.Point(8, 576);
			this.pnl_low.Name = "pnl_low";
			this.pnl_low.Size = new System.Drawing.Size(1000, 0);
			this.pnl_low.TabIndex = 3;
			// 
			// btn_Tree
			// 
			this.btn_Tree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Tree.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Tree.ImageIndex = 13;
			this.btn_Tree.ImageList = this.image_List;
			this.btn_Tree.Location = new System.Drawing.Point(674, 2);
			this.btn_Tree.Name = "btn_Tree";
			this.btn_Tree.Size = new System.Drawing.Size(80, 24);
			this.btn_Tree.TabIndex = 364;
			this.btn_Tree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_delete.ImageIndex = 5;
			this.btn_delete.ImageList = this.image_List;
			this.btn_delete.Location = new System.Drawing.Point(838, 2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 24);
			this.btn_delete.TabIndex = 363;
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(920, 2);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 24);
			this.btn_recover.TabIndex = 353;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(756, 2);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 24);
			this.btn_Insert.TabIndex = 352;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnl_main
			// 
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.fgrid_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 124);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(1000, 448);
			this.pnl_main.TabIndex = 1;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(1000, 448);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 0;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// c1Combo5
			// 
			this.c1Combo5.AddItemCols = 0;
			this.c1Combo5.AddItemSeparator = ';';
			this.c1Combo5.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo5.Caption = "";
			this.c1Combo5.CaptionHeight = 17;
			this.c1Combo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo5.ColumnCaptionHeight = 17;
			this.c1Combo5.ColumnFooterHeight = 17;
			this.c1Combo5.ContentHeight = 15;
			this.c1Combo5.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo5.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo5.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo5.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo5.EditorHeight = 15;
			this.c1Combo5.GapHeight = 2;
			this.c1Combo5.ItemHeight = 15;
			this.c1Combo5.Location = new System.Drawing.Point(0, 0);
			this.c1Combo5.MatchEntryTimeout = ((long)(2000));
			this.c1Combo5.MaxDropDownItems = ((short)(5));
			this.c1Combo5.MaxLength = 32767;
			this.c1Combo5.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo5.Name = "c1Combo5";
			this.c1Combo5.PartialRightColumn = false;
			this.c1Combo5.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.c1Combo5.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo5.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo5.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo5.TabIndex = 0;
			// 
			// c1Combo2
			// 
			this.c1Combo2.AddItemCols = 0;
			this.c1Combo2.AddItemSeparator = ';';
			this.c1Combo2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo2.Caption = "";
			this.c1Combo2.CaptionHeight = 17;
			this.c1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo2.ColumnCaptionHeight = 17;
			this.c1Combo2.ColumnFooterHeight = 17;
			this.c1Combo2.ContentHeight = 15;
			this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo2.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 15;
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(0, 0);
			this.c1Combo2.MatchEntryTimeout = ((long)(2000));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.PartialRightColumn = false;
			this.c1Combo2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.TabIndex = 0;
			// 
			// c1Combo3
			// 
			this.c1Combo3.AddItemCols = 0;
			this.c1Combo3.AddItemSeparator = ';';
			this.c1Combo3.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo3.Caption = "";
			this.c1Combo3.CaptionHeight = 17;
			this.c1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo3.ColumnCaptionHeight = 17;
			this.c1Combo3.ColumnFooterHeight = 17;
			this.c1Combo3.ContentHeight = 15;
			this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo3.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo3.EditorHeight = 15;
			this.c1Combo3.GapHeight = 2;
			this.c1Combo3.ItemHeight = 15;
			this.c1Combo3.Location = new System.Drawing.Point(0, 0);
			this.c1Combo3.MatchEntryTimeout = ((long)(2000));
			this.c1Combo3.MaxDropDownItems = ((short)(5));
			this.c1Combo3.MaxLength = 32767;
			this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo3.Name = "c1Combo3";
			this.c1Combo3.PartialRightColumn = false;
			this.c1Combo3.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFoote" +
				"rHeight=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" +
				"ght>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
				"Style parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" me=\"Style3\" />" +
				"<GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Heading\" me=\"Sty" +
				"le2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><InactiveStyle par" +
				"ent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style8\" /><RecordS" +
				"electorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle parent=\"Selec" +
				"ted\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1List.ListBoxV" +
				"iew></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style parent=\"Normal\" " +
				"me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=\"Heading\" me=" +
				"\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"Normal\" me=\"S" +
				"elected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent=\"Normal\" me=" +
				"\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Heading\" me=\"Rec" +
				"ordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><vertSplits>1<" +
				"/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" +
				"th>17</DefaultRecSelWidth></Blob>";
			this.c1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo3.TabIndex = 0;
			// 
			// Form_ST_Purchas_Search
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_ST_Purchas_Search";
			this.Load += new System.EventHandler(this.Form_ST_Purchas_Search_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_model)).EndInit();
			this.pnl_low.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region DB Connect

		/// <returns>DataTable</returns>
		public DataTable SELECT_SVM_SM_PURCHASE_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SVM_SM_PURCHASE_TOTAL";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEASON";
			MyOraDB.Parameter_Name[3] = "ARG_SEASON_YEAR";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = (ClassLib.ComFunction.Empty_TextBox(txt_model_name, "") == "") ? "" : ClassLib.ComFunction.Empty_TextBox(txt_model_code, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_season, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_season_year, "");
			MyOraDB.Parameter_Values[4]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		private void Form_ST_Purchas_Search_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.SetLangDic(this);

			this.Text		   = "Small Tooling";
			lbl_MainTitle.Text = "Purchasing Order Search";			

			// grid set
			fgrid_main.Set_Grid("SVM_SM_PURCHASING", "2", 3, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Rows[3].Visible = false;
			fgrid_main.AllowDragging = AllowDraggingEnum.None;
			fgrid_main.Tree.Column = _colSEASON;
			_Rowfixed = fgrid_main.Rows.Fixed;			

			//입력부 setup
			Init_Combo();
			
			//_cmbPurNoEventHandler   = new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
			//cmb_purNo.SelectedValueChanged += _cmbPurNoEventHandler;
			
			// grid set
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);


			// user define varible set
			//			fgrid_main.Cols[_rtaYmdCol].Format  = "yyyy-MM-dd";
			//			fgrid_main.Cols[_etsYmd1Col].Format = "yyyy-MM-dd";
			//			fgrid_main.Cols[_etsYmd2Col].Format = "yyyy-MM-dd";
			//			fgrid_main.Cols[_etsYmd3Col].Format = "yyyy-MM-dd";

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

			_firstLoad = false;
		}


		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;

				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM15");
				COM.ComCtl.Set_ComboList(vDt, cmb_season, 1, 1, true, 100, 0);
				cmb_season.SelectedIndex = 0;

				
				// cmb_purUser
				//				vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				//				ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 1, true, 0, 210);
				//				//cmb_purUser.ValueMember = "Name";
				//				cmb_purUser.SelectedValue = COM.ComVar.This_User;

				// cmb_purDiv SBM07
				//				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM07");
				//				COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 1, 2, true, 56,0);
				//				cmb_purDiv.SelectedIndex = 1;

				vDt.Dispose();

				//				tbtn_Create.Enabled = false;
				//				btn_sizeItem.Enabled = false;
				//				btn_CtItem.Enabled = false;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void dpick_purYmd_ValueChanged(object sender, System.EventArgs e)
		{
			//this.Cmb_PurNoSettingProcess();
		}

		private void dpick_purYmd_from_ValueChanged(object sender, System.EventArgs e)
		{
			//this.Cmb_PurNoSettingProcess();
		}

		private void dpick_purYmd_to_ValueChanged(object sender, System.EventArgs e)
		{
			//this.Cmb_PurNoSettingProcess();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;
								
				this.Tbtn_SearchProcess();
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

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
			
				DataTable vDt = SELECT_SVM_SM_PURCHASE_LIST();
				ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
				vDt.Dispose();

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void btn_search_model_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txt_model_name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar != 13) return;

			Event_KeyPress_txt_model(); 		
		}

		private void Event_KeyPress_txt_model()
		{

			DataTable dt_ret = Select_Model_List();

			// 프로그램 리스트 추가
			COM.ComCtl.Set_ComboList_3(dt_ret, cmb_model, 0, 1, 2);
			
			cmb_model.Splits[0].DisplayColumns[0].Width = 150;
			cmb_model.Splits[0].DisplayColumns[1].Width = 150;
			cmb_model.Splits[0].DisplayColumns[2].Width = 50;
				
		}

		private DataTable Select_Model_List()
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SDC_MODEL";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_MODEL_NM";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_TextBox(txt_model_name , "");
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void cmb_model_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_model.SelectedIndex == -1) return;
			 
			txt_model_code.Text = cmb_model.Columns[2].Text;
			txt_model_name.Text = cmb_model.Columns[1].Text;
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			string sLevel = fgrid_main[fgrid_main.Selection.r1, _colT_LEVEL].ToString();
			int    iCol   = fgrid_main.Selection.c1;

			if (sLevel.Equals("1"))
			{
				if ((iCol == _colCOMPONENT_M_NM)||
					(iCol == _colCOMPONENT_S_NM)||
					(iCol == _colITEM_NM       )||
					(iCol == _colSIZE_DESC     ))
				{
					fgrid_main.Cols[iCol].AllowEditing = true;
				}
				else fgrid_main.Cols[iCol].AllowEditing = false;

			}
			else if (sLevel.Equals("2"))
			{
					fgrid_main.Cols[iCol].AllowEditing = false;
			}
		
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void Grid_AfterEditProcess()
		{
			fgrid_main.Update_Row();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}
			else
			{
				//dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave);
			}			
		}

		private bool Validate_Check()
		{
			//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			//			{
			//
			//				if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
			//					continue;
			//
			//				if (fgrid_main[iRow, _colSTYLE_NM].ToString().Replace(" ", "").Trim().Length == 0)
			//					return false;
			//
			//			}

			return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_SM_MODEL_INFO(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_SM_MODEL_INFO(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 10;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SAVE_SVM_SM_MODEL_INFO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[ 3] = "ARG_SEASON";
				MyOraDB.Parameter_Name[ 4] = "ARG_SEASON_YEAR";
				MyOraDB.Parameter_Name[ 5] = "ARG_SIZE_RUN";
				MyOraDB.Parameter_Name[ 6] = "ARG_FORECAST";
				MyOraDB.Parameter_Name[ 7] = "ARG_FGCT";
				MyOraDB.Parameter_Name[ 8] = "ARG_PRODUCTION";
				MyOraDB.Parameter_Name[ 9] = "ARG_UPD_USER";

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
					if (ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals(""))
						continue;

					MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();						
					MyOraDB.Parameter_Values[para_ct+ 1] = cmb_factory.SelectedValue.ToString();
					MyOraDB.Parameter_Values[para_ct+ 2] = (fgrid_main[iRow, _colMODEL_CD] == null)       ? ""  : fgrid_main[iRow, _colMODEL_CD].ToString();
					MyOraDB.Parameter_Values[para_ct+ 3] = (fgrid_main[iRow, _colSEASON] == null)         ? ""  : fgrid_main[iRow, _colSEASON].ToString();
					MyOraDB.Parameter_Values[para_ct+ 4] = (fgrid_main[iRow, _colSEASON_YEAR] == null)    ? ""  : fgrid_main[iRow, _colSEASON_YEAR].ToString();
					MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_main[iRow, _colCOMPONENT_M_NM] == null) ? ""  : fgrid_main[iRow, _colCOMPONENT_M_NM].ToString();
					MyOraDB.Parameter_Values[para_ct+ 6] = (fgrid_main[iRow, _colCOMPONENT_S_NM] == null) ? ""  : fgrid_main[iRow, _colCOMPONENT_S_NM].ToString();
					MyOraDB.Parameter_Values[para_ct+ 7] = (fgrid_main[iRow, _colITEM_NM] == null)        ? ""  : fgrid_main[iRow, _colITEM_NM].ToString();
					MyOraDB.Parameter_Values[para_ct+ 8] = (fgrid_main[iRow, _colSIZE_DESC] == null)      ? ""  : fgrid_main[iRow, _colSIZE_DESC].ToString();
					MyOraDB.Parameter_Values[para_ct+ 9] = COM.ComVar.This_User;
						
					para_ct += iCount;
				}

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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_PrintProcess();
		}
		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_ST_PURCHASE_SEARCH();
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

		private void PRINT_ST_PURCHASE_SEARCH()
		{
			string sDir;
			
			sDir = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Tooling Status Report");

			string sPara;

			

			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[ 1]   = txt_model_code.Text;
			MyOraDB.Parameter_Values[ 2]   = cmb_season.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");
		
			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_factory, "") +	"' ";			            //Parm1: Factory
			sPara += "'" + txt_model_code.Text +	"' ";						                //Parm2: Out Date
			sPara += "'" + cmb_season.SelectedValue.ToString() +	"' ";						      	//Parm3: Out Line
			sPara += "'" + txt_season_year.Text +	"' ";						                    	//Parm4: Item
		
			FlexMold.Report.Form_RdViewer MyReport = new FlexMold.Report.Form_RdViewer(sDir, sPara);

//			FlexMold.Text = "VOC Material Tracking";
			MyReport.Show();
				
		}


	}
}

