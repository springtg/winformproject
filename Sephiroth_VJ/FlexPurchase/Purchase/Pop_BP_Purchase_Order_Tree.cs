using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Purchase_Order_Tree : COM.PCHWinForm.Pop_Medium
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_style_cd;
		private System.Windows.Forms.TextBox txt_style_cd;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.GroupBox groupBox1;
		private COM.FSP fgrid_yield;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ContextMenu cmenu_yield;
		private System.Windows.Forms.MenuItem menu_component_add;
		private System.Windows.Forms.MenuItem menu_template_add;
		private System.Windows.Forms.MenuItem menu_yield_modify;
		private System.Windows.Forms.MenuItem menu_yield_delete;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 정의 변수

		private int _fixedRow = 0;
		private System.EventHandler _styleCdTextChangedEvent = null;
		private System.EventHandler _styleSelectedValueChangedEvent = null;
		private System.EventHandler _devisionSelectedValueChangedEvent = null;
		private C1.Win.C1FlexGrid.CellStyle _semiStyle, _compStyle, _defaultStyle;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_prevStep;
		//return 또는 cancel 이벤트 체크
		private bool _CancelFlag = false;
		private Hashtable _Imgmap = new Hashtable();

		private int _level1Col				= (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1;
		private int _key1Col				= (int)ClassLib.TBSBC_YIELD_REQ.IxKEY1;
		private int _typeDivisionCol		= (int)ClassLib.TBSBC_YIELD_REQ.IxTYPE_DIVISION;
		private int _chkApplyCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY;
		private int _treeCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxTREE;
		private int _factoryCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxFACTORY;
		private int _templateSeqCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ;
		private int _templateLevelCol		= (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_LEVEL;
		private int _templateTreeCdCol		= (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_TREE_CD;
		private int _templateTreeNameCol	= (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_TREE_NAME;
		private int _templateCdCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_CD;
		private int _itemCdCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_CD;
		private int _itemNameCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_NAME;
		private int _specCdCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD;
		private int _specNameCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_NAME;
		private int _colorCdCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_CD;
		private int _colorNameCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_NAME;
		private int _unitCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxUNIT;
		private int _prodYnCol				= (int)ClassLib.TBSBC_YIELD_REQ.IxPROD_YN;
		private int _semiGoodCdCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD;
		private System.Windows.Forms.ImageList img_Type;
		private int _componentCdCol			= (int)ClassLib.TBSBC_YIELD_REQ.IxCOMPONENT_CD;

		#endregion


		public Pop_BP_Purchase_Order_Tree()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Purchase_Order_Tree));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Label();
            this.btn_prevStep = new System.Windows.Forms.Label();
            this.fgrid_yield = new COM.FSP();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Comp = new System.Windows.Forms.RadioButton();
            this.rad_SG = new System.Windows.Forms.RadioButton();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.cmb_style_cd = new C1.Win.C1List.C1Combo();
            this.cmenu_yield = new System.Windows.Forms.ContextMenu();
            this.menu_component_add = new System.Windows.Forms.MenuItem();
            this.menu_template_add = new System.Windows.Forms.MenuItem();
            this.menu_yield_modify = new System.Windows.Forms.MenuItem();
            this.menu_yield_delete = new System.Windows.Forms.MenuItem();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_yield)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style_cd)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.fgrid_yield);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Controls.Add(this.btn_prevStep);
            this.panel2.Location = new System.Drawing.Point(8, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 35);
            this.panel2.TabIndex = 169;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(600, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(72, 24);
            this.btn_Cancel.TabIndex = 358;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_Button;
            this.btn_Return.Location = new System.Drawing.Point(527, 5);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(72, 24);
            this.btn_Return.TabIndex = 357;
            this.btn_Return.Text = "Apply";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Return.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_prevStep
            // 
            this.btn_prevStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prevStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_prevStep.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_prevStep.ImageIndex = 0;
            this.btn_prevStep.ImageList = this.img_Button;
            this.btn_prevStep.Location = new System.Drawing.Point(456, 5);
            this.btn_prevStep.Name = "btn_prevStep";
            this.btn_prevStep.Size = new System.Drawing.Size(70, 23);
            this.btn_prevStep.TabIndex = 536;
            this.btn_prevStep.Text = "Previous";
            this.btn_prevStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_prevStep.Click += new System.EventHandler(this.btn_prevStep_Click);
            this.btn_prevStep.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_prevStep.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // fgrid_yield
            // 
            this.fgrid_yield.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_yield.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_yield.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_yield.Location = new System.Drawing.Point(8, 70);
            this.fgrid_yield.Name = "fgrid_yield";
            this.fgrid_yield.Size = new System.Drawing.Size(678, 311);
            this.fgrid_yield.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_yield.Styles"));
            this.fgrid_yield.TabIndex = 168;
            this.fgrid_yield.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_yield_AfterEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 66);
            this.panel1.TabIndex = 167;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.lbl_gender);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lbl_factory);
            this.groupBox2.Controls.Add(this.cmb_factory);
            this.groupBox2.Controls.Add(this.txt_gender);
            this.groupBox2.Controls.Add(this.txt_style_cd);
            this.groupBox2.Controls.Add(this.lbl_style);
            this.groupBox2.Controls.Add(this.cmb_style_cd);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 67);
            this.groupBox2.TabIndex = 536;
            this.groupBox2.TabStop = false;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(288, 16);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 534;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_All);
            this.groupBox1.Controls.Add(this.rad_Comp);
            this.groupBox1.Controls.Add(this.rad_SG);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(488, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 56);
            this.groupBox1.TabIndex = 535;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree View Option";
            // 
            // rad_All
            // 
            this.rad_All.Checked = true;
            this.rad_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_All.Location = new System.Drawing.Point(131, 24);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(40, 16);
            this.rad_All.TabIndex = 39;
            this.rad_All.TabStop = true;
            this.rad_All.Tag = "50";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Comp
            // 
            this.rad_Comp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_Comp.Location = new System.Drawing.Point(67, 24);
            this.rad_Comp.Name = "rad_Comp";
            this.rad_Comp.Size = new System.Drawing.Size(64, 16);
            this.rad_Comp.TabIndex = 38;
            this.rad_Comp.Tag = "2";
            this.rad_Comp.Text = "Comp";
            this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_SG
            // 
            this.rad_SG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_SG.Location = new System.Drawing.Point(5, 24);
            this.rad_SG.Name = "rad_SG";
            this.rad_SG.Size = new System.Drawing.Size(64, 16);
            this.rad_SG.TabIndex = 37;
            this.rad_SG.Tag = "1";
            this.rad_SG.Text = "Semi";
            this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 533;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AccessibleDescription = "";
            this.cmb_factory.AccessibleName = "";
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style1;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 17;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 17;
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(170, 21);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 532;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.Color.White;
            this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_gender.Location = new System.Drawing.Point(389, 16);
            this.txt_gender.MaxLength = 100;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(96, 21);
            this.txt_gender.TabIndex = 531;
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.Color.White;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_style_cd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_style_cd.Location = new System.Drawing.Point(109, 38);
            this.txt_style_cd.MaxLength = 100;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.Size = new System.Drawing.Size(100, 21);
            this.txt_style_cd.TabIndex = 534;
            this.txt_style_cd.TextChanged += new System.EventHandler(this.txt_style_cd_TextChanged);
            this.txt_style_cd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_style_cd_KeyUp);
            // 
            // lbl_style
            // 
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(8, 38);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 533;
            this.lbl_style.Text = "Style Code";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_style_cd
            // 
            this.cmb_style_cd.AccessibleDescription = "";
            this.cmb_style_cd.AccessibleName = "";
            this.cmb_style_cd.AddItemCols = 0;
            this.cmb_style_cd.AddItemSeparator = ';';
            this.cmb_style_cd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style_cd.Caption = "";
            this.cmb_style_cd.CaptionHeight = 17;
            this.cmb_style_cd.CaptionStyle = style9;
            this.cmb_style_cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style_cd.ColumnCaptionHeight = 18;
            this.cmb_style_cd.ColumnFooterHeight = 18;
            this.cmb_style_cd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style_cd.ContentHeight = 17;
            this.cmb_style_cd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style_cd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style_cd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style_cd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style_cd.EditorHeight = 17;
            this.cmb_style_cd.EvenRowStyle = style10;
            this.cmb_style_cd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_style_cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style_cd.FooterStyle = style11;
            this.cmb_style_cd.GapHeight = 2;
            this.cmb_style_cd.HeadingStyle = style12;
            this.cmb_style_cd.HighLightRowStyle = style13;
            this.cmb_style_cd.ItemHeight = 15;
            this.cmb_style_cd.Location = new System.Drawing.Point(210, 38);
            this.cmb_style_cd.MatchEntryTimeout = ((long)(2000));
            this.cmb_style_cd.MaxDropDownItems = ((short)(5));
            this.cmb_style_cd.MaxLength = 32767;
            this.cmb_style_cd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style_cd.Name = "cmb_style_cd";
            this.cmb_style_cd.OddRowStyle = style14;
            this.cmb_style_cd.PartialRightColumn = false;
            this.cmb_style_cd.PropBag = resources.GetString("cmb_style_cd.PropBag");
            this.cmb_style_cd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style_cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style_cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style_cd.SelectedStyle = style15;
            this.cmb_style_cd.Size = new System.Drawing.Size(275, 21);
            this.cmb_style_cd.Style = style16;
            this.cmb_style_cd.TabIndex = 535;
            this.cmb_style_cd.SelectedValueChanged += new System.EventHandler(this.cmb_style_cd_SelectedValueChanged);
            // 
            // cmenu_yield
            // 
            this.cmenu_yield.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_component_add,
            this.menu_template_add,
            this.menu_yield_modify,
            this.menu_yield_delete});
            // 
            // menu_component_add
            // 
            this.menu_component_add.Index = 0;
            this.menu_component_add.Text = "Component Add";
            // 
            // menu_template_add
            // 
            this.menu_template_add.Index = 1;
            this.menu_template_add.Text = "Template Add";
            // 
            // menu_yield_modify
            // 
            this.menu_yield_modify.Index = 2;
            this.menu_yield_modify.Text = "Modify";
            // 
            // menu_yield_delete
            // 
            this.menu_yield_delete.Index = 3;
            this.menu_yield_delete.Text = "Delete";
            // 
            // img_Type
            // 
            this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
            this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Type.Images.SetKeyName(0, "");
            this.img_Type.Images.SetKeyName(1, "");
            this.img_Type.Images.SetKeyName(2, "");
            this.img_Type.Images.SetKeyName(3, "");
            this.img_Type.Images.SetKeyName(4, "");
            this.img_Type.Images.SetKeyName(5, "");
            // 
            // Pop_BP_Purchase_Order_Tree
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Purchase_Order_Tree";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Request_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_yield)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style_cd)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		public string arg_datamode;
		private int _Rowfixed = 3;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private int _drag_row; 
		private string _shp_yn;
		//private FTPClient m_FtpClient;



		private Hashtable Imgmap = new Hashtable();

		#endregion


		#region 멤버 메소드

		private void Init_Form()
		{
			DataTable dt_ret;

            //Title
			this.Text = "Yield Information";
            lbl_MainTitle.Text = "Yield Information";
            ClassLib.ComFunction.SetLangDic(this);


            // 그리드 설정
			fgrid_yield.Set_Grid("SBC_YIELD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_yield.Set_Action_Image(img_Action);
			fgrid_yield.Styles.Alternate.BackColor = Color.Empty;
			fgrid_yield.Styles.Frozen.BackColor = Color.Empty;
			//fgrid_yield.Font = new Font("Verdana", 8);
			

			fgrid_yield.DragMode = DragModeEnum.Manual;//Automatic;
			fgrid_yield.DropMode = DropModeEnum.Manual; 

			// 공장코드
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

	
			//테스트땜에 잠시...
//			txt_style_cd.Text = "309207151";

			// default search proviso
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			txt_style_cd.Text			= COM.ComVar.Parameter_PopUp[3];
							
			DataTable dt_list = Select_StyleList(ClassLib.ComFunction.Empty_TextBox(txt_style_cd, " ") );
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_style_cd, 0, 1, false, 70, 150);
			if(dt_list.Rows.Count == 1 )
				cmb_style_cd.SelectedIndex = 0;

			dt_list.Dispose();

			dt_ret.Dispose();
		}

		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			try
			{
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
  
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = ""; 
				} 
			}
			catch{}
		} 

		private void fgrid_yield_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_yield.Rows.Fixed > 0) && (fgrid_yield.Row >= fgrid_yield.Rows.Fixed))
			{
				fgrid_yield.Buffer_CellData = (fgrid_yield[fgrid_yield.Row, fgrid_yield.Col] == null) ? "" : fgrid_yield[fgrid_yield.Row, fgrid_yield.Col].ToString();
			}		
		}

		private void fgrid_yield_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess(e);	
		}

		/// <summary>
		/// SetCols : 그리드를 트리 형식으로 표시
		/// </summary>
		private void SetCols()
		{
			fgrid_yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_REQ.IxTREE;
		}

		#endregion


		private void txt_style_cd_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
//				DataTable dt_ret;
//				dt_ret = Select_StyleList(COM.ComFunction.Empty_TextBox(txt_style_cd, " "));   //txt_style_cd.Text == "" ? " " : txt_style_cd.Text);
//				COM.ComCtl.Set_ComboList(dt_ret, cmb_style_cd, 0,1, false);
//				cmb_style_cd.Splits[0].DisplayColumns["Code"].Width = 70;
//				cmb_style_cd.Splits[0].DisplayColumns["Name"].Width = 150;
//				dt_ret.Dispose();
			}
			catch{}
			

		}

		private void cmb_style_cd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				//스타일 선택시 바로 조회
				txt_style_cd.Text = cmb_style_cd.SelectedValue.ToString();
				Yield_Search();
			}
			catch{}
		}


		#region DB Connect

		/// <summary>
		/// Select_StyleList : 스타일 조회
		/// </summary>
		/// <returns></returns>
		public DataTable Select_StyleList(string sCode)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_STYLE_LIST";
  
			MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
			MyOraDB.Parameter_Values[0] = sCode;
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		/// <summary>
		///  Yield_Tree 조회
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_stylecode">스타일코드</param>
		/// <returns></returns>
		public DataTable Select_YieldList(string arg_factory, string arg_stylecode, string arg_gendercode)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_YIELD_INFO.SELECT_SBC_YIELD_INFO_REQ";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_GENDER";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecode;
			MyOraDB.Parameter_Values[2] = arg_gendercode;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : 헤더 정보 찾기
		/// </summary>
		/// <param name="vItemCd">item_cd</param>
		/// <param name="vSpecCd">spec_cd</param>
		/// <param name="vColorCd">color_cd</param>
		/// <param name="vFactory">factory</param>
		/// <param name="vStyle">style</param>
		/// SELECT_SBC_REQUEST_QTY(vItemCd, vSpecCd, vColorCd,vFactory,vStyle);
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_SPEC_LIST(string arg_factory, string arg_style_cd,  string arg_semi_good_cd, string arg_component_cd, string arg_template_seq, string arg_template_level)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_YIELD_VALUE.SELECT_SBC_SPEC_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
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
			MyOraDB.Parameter_Values[1] = arg_style_cd;
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd;
			MyOraDB.Parameter_Values[4] = arg_template_seq;
			MyOraDB.Parameter_Values[5] = arg_template_level;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Pop_Request_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void Grid_AfterEditProcess(C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_yield[e.Row, 0] = "";
			int vChkApplyCol = (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY;
			
			if (e.Col == vChkApplyCol) 
				GridCheckBoxCorrection();
		}


		private void GridCheckBoxCorrection()
		{
			int vRow = fgrid_yield.Selection.r1;
			int vCol = fgrid_yield.Selection.c1;
			int vSCol = (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY;

			Node vNode = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
			if (vNode != null)
			{
//				int vChildStartRow = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
//				int vChildEndRow   = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
//			
//				for (int i = vChildStartRow ; i <= vChildEndRow ; i++)
//				{
//					fgrid_yield[i, vSCol] = false;
//				}


//				int vLevel    = Int32.Parse(fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString());

				int vLevel    = Int32.Parse(fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString());
				
				int vStartRow = vRow+1;
				while(true)
				{
					if(Int32.Parse(fgrid_yield[vStartRow, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString()) <= vLevel)
						break;

					fgrid_yield[vStartRow, vSCol] = false;
					vStartRow++;
				}
					
//				if(fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent) != null)
//					this.GridGetFirstParentIndex(vRow, "3", true, vSCol);

			}
			else
			{
				vNode = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
				int vParentRow = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				fgrid_yield[vParentRow, vSCol] = false;

				this.GridGetFirstParentIndex(vRow, "3", true, vSCol);

			}
		}

		private int GridGetFirstParentIndex(int arg_row, string arg_level, bool arg_clear, int arg_clearRow1)
		{
			int vStartRow = arg_row;

			Node vStartNode = fgrid_yield.Rows[arg_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);

			if (vStartNode != null)
				while (true)
				{
					vStartNode = fgrid_yield.Rows[vStartRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
					if (vStartNode != null && fgrid_yield[vStartRow, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString().Equals(arg_level))
						break;
						
					vStartRow = vStartNode.Row.Index;
					fgrid_yield[vStartNode.Row.Index, arg_clearRow1]	= !arg_clear;
				}

			return vStartRow;
		}


		private void cmb_weight_TextChanged(object sender, System.EventArgs e)
		{
			//Search_Weight();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Yield_Search();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//Check만 저장....
			try
			{
				//행 수정 상태 해제
				fgrid_yield.Select(fgrid_yield.Selection.r1, 0, fgrid_yield.Selection.r1, fgrid_yield.Cols.Count-1, false);

				//저장
				//MyOraDB.Save_FlexGird_CrossTab("PKG_SBC_YIELD_INFO.SAVE_SBC_YIELD_INFO", fgrid_yield, ");

				//수정후 조회
				Yield_Search();

				//메세지처리
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Yield_Searc : 조회
		/// </summary>
		public void Yield_Search()
		{
			//조회조건 공백체크......
			if(cmb_factory.SelectedValue.ToString() == null || txt_style_cd.Text == null ) return;

			fgrid_yield.Display_Size_ColHead(cmb_factory.SelectedValue.ToString(), cmb_style_cd.SelectedValue.ToString(),50,26); 										
			Select_Yield_List();
		}

		/// <summary>
		/// Select_Yield_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private void Select_Yield_List()
		{
			try
			{
				_fixedRow = fgrid_yield.Rows.Fixed;
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				DataTable dt_ret;	
	
				fgrid_yield.Set_Grid("SBC_YIELD_REQ", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_yield.Set_Action_Image(img_Action,true);

				dt_ret = Select_YieldList(cmb_factory.SelectedValue.ToString(), cmb_style_cd.SelectedValue.ToString().Replace("-",""), txt_gender.Text);

				if (dt_ret.Rows.Count > 0)
				{
					fgrid_yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_REQ.IxTREE;
					fgrid_yield.Cols[(int)ClassLib.TBSBC_YIELD_REQ.IxTREE].ImageAndText = true; 
					fgrid_yield.Cols[(int)ClassLib.TBSBC_YIELD_REQ.IxTREE].ImageMap = _Imgmap; 
					//					fgrid_yield.Tree.Show(3);

					for(int i = 0, idx = 0 ; i < dt_ret.Rows.Count ; i++)
					{
						int vRow = idx + _fixedRow;
						
						if (i != 0)
						{
							string vKey = fgrid_yield[vRow - 1, (int)ClassLib.TBSBC_YIELD_REQ.IxKEY1].ToString();
							if (vKey.Equals(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_REQ.IxKEY1 - 1].ToString()))
								continue;
						}

						fgrid_yield.Rows.InsertNode(idx + _fixedRow , Convert.ToInt32(dt_ret.Rows[i].ItemArray[0]));

						if(dt_ret.Rows[i].ItemArray[ _prodYnCol - 1].ToString()== "FALSE")
						{
							fgrid_yield.Rows[idx + _fixedRow].AllowEditing = false;
						}
						else
						{
							fgrid_yield.Rows[idx + _fixedRow].AllowEditing = true;
						}

						GridInsertData(idx, dt_ret.Rows[i].ItemArray);

						
						////////////////////////////////////////////////////
						
						switch(fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() )
						{
							
							case "1":   //semi_good_cd
                                
								fgrid_yield.GetCellRange(i, 1, i, fgrid_yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
								if(_Imgmap.ContainsKey(fgrid_yield[i, _treeCol].ToString() ) ) break;
								_Imgmap.Add(fgrid_yield[i, _treeCol].ToString(), img_Type.Images[0]);								
							
								break;

							case "2":  //component_cd
 
								fgrid_yield.GetCellRange(i, 1, i, fgrid_yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
								if(_Imgmap.ContainsKey(fgrid_yield[i, _treeCol].ToString() ) ) break;
								_Imgmap.Add(fgrid_yield[i, _treeCol].ToString(), img_Type.Images[2]); 
							
								break;
								
							default:   //raw_material, joint

								fgrid_yield.GetCellRange(i, 1, i, fgrid_yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
								if(_Imgmap.ContainsKey(fgrid_yield[i, _treeCol].ToString() ) ) break;
								

							switch(fgrid_yield[i, _typeDivisionCol].ToString() )
							{ 
								case "J":
									_Imgmap.Add(fgrid_yield[i, _treeCol].ToString(), img_Type.Images[4]);									
									break;

								case "M":
									_Imgmap.Add(fgrid_yield[i, _treeCol].ToString(), img_Type.Images[3]);
									break;
							}
								break;
						}

						idx++;
					}
				}
 
				SetCols();
				
				//				Imgmap.Clear();
				//
				//				fgrid_yield.Cols[_treeCol].ImageAndText = true; 
				//				fgrid_yield.Cols[_treeCol].ImageMap = Imgmap;  
			
				dt_ret.Dispose();

				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		
		/// <summary>
		/// Yield_Delete : 삭제
		/// </summary>
		public void Yield_Delete()
		{

		}

		#region 그리드 ContextMenu


//		/// <summary>
//		/// Yield Add
//		/// </summary>
//		/// <param name="sender"></param>
//		/// <param name="e"></param>
//		private void menu_add_Click(object sender, System.EventArgs e)
//		{
//			try
//			{
//				//행 수정 상태 해제
//				fgrid_yield.Select(fgrid_yield.Selection.r1, 0, fgrid_yield.Selection.r1, fgrid_yield.Cols.Count-1, false);
//				int sel_row = fgrid_yield.Selection.r1;
//
//				if(sel_row >= fgrid_yield.Rows.Fixed)
//				{
//					Pop_Yield_Modify pop_Yield_add = new Pop_Yield_Modify();
//
//					COM.ComVar.Parameter_PopUp = new string[]
//					{
//						arg_datamode = "C_I",
//						cmb_factory.SelectedValue.ToString(), 
//						cmb_style_cd.SelectedValue.ToString(),
//						fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD].ToString(),
//						" ", " ", " "
//						//fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxCOMPONENT_CD].ToString(),
//						//fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ].ToString(),
//						//fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_TREE_CD].ToString()
//					};
//					pop_Yield_add.ShowDialog();
//
//					//재조회..
//					Yield_Search();
//
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//
//					pop_Yield_add.Dispose();
//				}
//			}
//
//			catch(Exception ex)
//			{
//				MessageBox.Show( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
//			}		
//		}

//		private void menu_modify_Click(object sender, System.EventArgs e)
//		{
//			try
//			{
//				//행 수정 상태 해제
//				fgrid_yield.Select(fgrid_yield.Selection.r1, 0, fgrid_yield.Selection.r1, fgrid_yield.Cols.Count-1, false);
//				int sel_row = fgrid_yield.Selection.r1;
//
//				if(sel_row >= fgrid_yield.Rows.Fixed)
//				{
//					Pop_Yield_Modify pop_Yield_mod = new Pop_Yield_Modify();
//
//					COM.ComVar.Parameter_PopUp = new string[]
//					{
//						arg_datamode = "U",
//						cmb_factory.SelectedValue.ToString(), 
//						cmb_style_cd.SelectedValue.ToString(),
//						fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD].ToString(),
//						fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxCOMPONENT_CD].ToString(),
//						fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ].ToString(),
//						fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_TREE_CD].ToString()
//					};
//					pop_Yield_mod.ShowDialog();
//
//					//재조회
//					Yield_Search();
//
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//
//					pop_Yield_mod.Dispose();
//				}
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show( ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error); 
//			}		
//		}

		#endregion


		#region 그리드 관련 이벤트

			

		#endregion


		#region  수정중

		private void cmb_weight_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//			fgrid_yield.Display_CrossTab(dt_ret,2,2,8,9,false) ;
			//			fgrid_yield.Add_Row(fgrid_Sub.Rows.Count - 1);
			//			fgrid_yield[fgrid_yield.Rows.Count - 1,0] = "";
			//			fgrid_yield[fgrid_yield.Rows.Count - 1,(int)ClassLib.TBSBC_YIELD_REQ.IxFACTORY]	= fgrid_yield[selectrow,(int)ClassLib.TBSBC_YIELD_REQ.IxFACTORY].ToString();
			//			fgrid_yield[fgrid_yield.Rows.Count - 1,(int)ClassLib.TBSBC_YIELD_REQ.IxSTYLE_CD]	= fgrid_yield[selectrow,(int)ClassLib.TBSBC_YIELD_REQ.IxSTYLE_CD].ToString();
			//			fgrid_yield[fgrid_yield.Rows.Count - 1,(int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD]		= fgrid_yield[selectrow,(int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD].ToString();
			//			//fgrid_yield[fgrid_yield.Rows.Count - 1,(int)ClassLib.TBSBC_YIELD_REQ.IxType]	= cmb_Weight.SelectedValue.ToString();
		}

		#endregion


//		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
//		{
//			txt_style_cd.Text = "";
//			cmb_style_cd.SelectedIndex = -1;
//			txt_gender.Text = "";
//			cmb_presto_yn.SelectedIndex = -1;
//		}

		private void cmenu_yield_Popup(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_yield.Selection.r1;
			//if(sel_row >= fgrid_yield.Rows.Fixed 
			if(fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() == "1")
			{
				menu_component_add.Visible = true;
				menu_template_add.Visible  = false;

				menu_component_add.Enabled = true;
				menu_yield_modify.Enabled  = false;
				menu_yield_delete.Enabled  = false;
			}
			else if(fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() == "2")
			{
				menu_component_add.Visible = false;
				menu_template_add.Visible  = true;

				menu_template_add.Enabled = true;
				menu_yield_modify.Enabled = false;
				menu_yield_delete.Enabled = false;
			}
			else if(fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() == "3")
			{
				menu_component_add.Visible = false;
				menu_template_add.Visible  = false;

				menu_template_add.Enabled  = false;
				menu_yield_modify.Enabled  = true;
				menu_yield_delete.Enabled  = true;
			}
			else
			{
				menu_component_add.Visible = false;
				menu_template_add.Visible  = false;

				menu_yield_modify.Enabled  = false;
				menu_yield_delete.Enabled  = false;
			}
		}

		private void fgrid_yield_Click(object sender, System.EventArgs e)
		{
			//			int sel_row = fgrid_yield.Selection.r1;
			//			//if(sel_row >= fgrid_yield.Rows.Fixed 
			//			if(fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() == "1")
			//			{
			//				menu_yield_modify.Enabled = false;
			//			}
			//			else if(fgrid_yield[sel_row, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1].ToString() == "2")
			//			{
			//				menu_yield_add.Enabled = false;
			//			}
			//			else
			//			{
			//				menu_yield_modify.Enabled = false;
			//				menu_yield_add.Enabled = false;
			//				menu_yield_delete.Enabled = false;
			//			}
		}





		#region 드래그앤드롭

		C1FlexGrid _src = null;
		private void fgrid_yield_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			// start dragging when the user clicks the row headers
			C1FlexGrid flex = sender as C1FlexGrid;
			HitTestInfo hti = flex.HitTest(e.X, e.Y);
			if (hti.Type == HitTestTypeEnum.RowHeader)
			{
				// select the row
				int index = hti.Row;
				flex.Select(index, 0, index, flex.Cols.Count-1, false);

				// save info for target
				_src = flex;

				// do drag drop
				DragDropEffects dd = flex.DoDragDrop(flex.Clip, DragDropEffects.Move);

				// if it worked, delete row from source (it's a move)
				if (dd == DragDropEffects.Move)
					flex.Rows.Remove(index);

				// done, reset info
				_src = null;
			}
		}

		#endregion

		private void txt_style_cd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_style_cd, " "));
				
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style_cd, 0, 1, 2, 3, 4, false, 100, 221); 
				 
				if(dt_ret.Rows.Count == 1)
					cmb_style_cd.SelectedIndex = 0;
				else if( dt_ret.Rows.Count == 0)
				{
					fgrid_yield.Set_Grid("SBC_YIELD_REQ", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					fgrid_yield.Set_Action_Image(img_Action,true);
				}
				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_style_cd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton;

				if(src.Name == "rad_All")
				{
					//int max_level = fgrid_yield.Rows[fgrid_yield.Rows.Fixed].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					//fgrid_yield.Tree.Show(max_level);
					fgrid_yield.Tree.Show(fgrid_yield.Tree.Indent);

				}
				else
				{
					fgrid_yield.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) );
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			_CancelFlag = false;
			Return_Item_Data();
			this.Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CancelFlag = true;
			ClassLib.ComVar.Parameter_PopUpTable2.Reset();
			this.Close();	
		}

		private void btn_prevStep_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUpTable2.Reset();
			this.Close();
		}

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

		

		/// <summary>
		/// Return_Item_Data : Return Data
		/// </summary>
		private void Return_Item_Data()
		{
			try
			{
				if(_CancelFlag)
				{
					COM.ComVar.Parameter_PopUp = new string[] { "", "", "", "", "",  "", "", "False" };
				}
				else
				{
					if(fgrid_yield.Rows.Count <= 3 ) return;

					int vRow  = 0;
					//int vRow2 = 0;

					for(int i = _fixedRow         ; i < this.fgrid_yield.Rows.Count ; i++)
					{
						string ss = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY].ToString();
						if( fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY].ToString() == "True")
							vRow++;
					}

					ClassLib.ComVar.Parameter_PopUpTable.Reset();
					ClassLib.ComVar.Parameter_PopUpTable.Columns.Clear();

					DataColumn[] dc= new DataColumn[10];

					dc[0] = new DataColumn("item_cd",Type.GetType("System.String"));
					dc[1] = new DataColumn("item_nm",Type.GetType("System.String"));
					dc[2] = new DataColumn("spec_cd",Type.GetType("System.String"));
					dc[3] = new DataColumn("spec_nm",Type.GetType("System.String"));
					dc[4] = new DataColumn("color_cd",Type.GetType("System.String"));
					dc[5] = new DataColumn("color_nm",Type.GetType("System.String"));
					dc[6] = new DataColumn("unit",Type.GetType("System.String"));
					dc[7] = new DataColumn("factory",Type.GetType("System.String"));
					dc[8] = new DataColumn("style_cd",Type.GetType("System.String"));
					dc[9] = new DataColumn("component_cd",Type.GetType("System.String"));
				
					ClassLib.ComVar.Parameter_PopUpTable.Columns.AddRange(dc);

					for(int i = 0 ; i<  this.fgrid_yield.Rows.Count ; i++)
					{
						if(fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY].ToString() == "True")
						{
							if(fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD].ToString() == "" || fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD].ToString() == null)
							{
								// spec_cd를 가져오는 프로시져 호출
								string v_factory       = COM.ComFunction.Empty_Combo(cmb_factory, "");
								string v_style_cd      = COM.ComFunction.Empty_TextBox(this.txt_style_cd, "");
								string v_semi_good_cd  = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxSEMI_GOOD_CD].ToString();
								string v_component_cd  = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOMPONENT_CD].ToString();
								string v_template_seq  = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ].ToString();
								string v_template_level= fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_LEVEL].ToString(); 

								DataTable vDt = this.SELECT_SBC_SPEC_LIST(v_factory, v_style_cd, v_semi_good_cd, v_component_cd, v_template_seq, v_template_level );

								if (vDt.Rows.Count > 0)
								{
									for( int j = 0 ; j < vDt.Rows.Count ; j ++)
									{
										DataRow newRow =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();

										newRow[0] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_CD].ToString();    // item_cd
										newRow[1] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_NAME].ToString();  // item_nm
										newRow[2] = vDt.Rows[j][0].ToString();    // spec_cd
										newRow[3] = vDt.Rows[j][1].ToString();    // spec_nm
										newRow[4] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_CD].ToString();   // color_cd
										newRow[5] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_NAME].ToString(); // color_nm
										newRow[6] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxUNIT].ToString();       // unit
										newRow[7] = COM.ComFunction.Empty_Combo(cmb_factory, "");  // factory
										newRow[8] = COM.ComFunction.Empty_TextBox(this.txt_style_cd, "");// style_cd
										newRow[9] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOMPONENT_CD].ToString(); //component

										ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
									}
								}
								vDt.Dispose();
							}
							else
							{
								DataRow newRow =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();
								newRow[0] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_CD].ToString();    // item_cd
								newRow[1] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_NAME].ToString();  // item_nm
								newRow[2] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD].ToString();    // spec_cd
								newRow[3] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_NAME].ToString();  // spec_nm
								newRow[4] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_CD].ToString();   // color_cd
								newRow[5] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_NAME].ToString(); // color_nm
								newRow[6] = fgrid_yield[i, (int)ClassLib.TBSBC_YIELD_REQ.IxUNIT].ToString();       // unit
								newRow[7] = COM.ComFunction.Empty_Combo(cmb_factory, "");  // factory
								newRow[8] = COM.ComFunction.Empty_TextBox(this.txt_style_cd, "");// style_cd
								newRow[9] = "";// component_cd

								ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
							}
						}
					}
				} // end if
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Request_Tree_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
			
		}

		#region 공통 메서드

		private void GridInsertData(int arg_row, object[] arg_items)
		{
			int vRow = arg_row + _fixedRow;

			fgrid_yield[vRow, 0]												 = "";
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1]			 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1 - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxKEY1]				 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxKEY1 - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY]		 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxCHK_APPLY - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxTREE]				 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxTREE - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxTYPE_DIVISION]	 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxTYPE_DIVISION - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_CD]			 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxITEM_CD - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxITEM_NAME]		 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxITEM_NAME - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD]			 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_CD - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_NAME]		 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxSPEC_NAME - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_CD]			 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_CD - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_NAME]		 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxCOLOR_NAME - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxUNIT]				 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxUNIT - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ]		 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_SEQ - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_LEVEL]	 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxTEMPLATE_LEVEL - 1];
			fgrid_yield[vRow, (int)ClassLib.TBSBC_YIELD_REQ.IxPROD_YN]			 = arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxPROD_YN - 1];

			switch (arg_items[(int)ClassLib.TBSBC_YIELD_REQ.IxLEVEL1 - 1].ToString())
			{
				case "1" :
					fgrid_yield.Rows[vRow].AllowEditing = false;
					fgrid_yield.Rows[vRow].Style = _semiStyle;
					break;
				case "2" :
					fgrid_yield.Rows[vRow].AllowEditing = false;
					fgrid_yield.Rows[vRow].Style = _compStyle;
					break;
				default :
					fgrid_yield.Rows[vRow].Style = _defaultStyle;
					break;
			}

			

		}

		#endregion

		

	}
}



