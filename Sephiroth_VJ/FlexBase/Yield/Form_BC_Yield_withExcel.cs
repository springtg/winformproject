using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Xml;
using System.Reflection;
using C1.Win.C1FlexGrid;  
using System.Data.OleDb;
using Microsoft.Office.Core;
using RecursiveFileExplorer;


namespace FlexBase.Yield
{
	public class Form_BC_Yield_withExcel : COM.PCHWinForm.Form_Top_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.ContextMenu cmenu_Yield;
		private System.Windows.Forms.MenuItem menuitem_AddCmp;
		private System.Windows.Forms.MenuItem menuitem_AddTemplate;
		private System.Windows.Forms.MenuItem menuitem_Modify;
		private System.Windows.Forms.MenuItem menuitem_Delete;
		private System.Windows.Forms.MenuItem menuItem_Separator1;
		private System.Windows.Forms.MenuItem menuItem_Separator2;
		private System.Windows.Forms.MenuItem menuItem_Copy;
		private System.Windows.Forms.MenuItem menuItem_StyleCopy;
		private C1.Win.C1Command.C1Command c1Command1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ContextMenu cmenu_Upload;
		private System.Windows.Forms.MenuItem menuItem_SetYield_Comparison;
		private System.Windows.Forms.MenuItem menuItem_SetYield_Size;
		private System.Windows.Forms.MenuItem menuItem_AutoReplace;
		private System.Windows.Forms.MenuItem menuItem_Separator3;
		private System.Windows.Forms.MenuItem menuItem_CancelFlag;
		private System.Windows.Forms.MenuItem menuItem_AllInsert;
		private System.Windows.Forms.MenuItem menuItem_AllDelete;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_SetJoint;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.MenuItem menuItem_Separator4;
		private System.Windows.Forms.MenuItem menuItem_ModifyItem;
		private System.Windows.Forms.MenuItem menuItem_ModifySpec;
		private System.Windows.Forms.MenuItem menuItem_ModifyColor;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.Label lbl_YieldType;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Style;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_ML;
		private System.Windows.Forms.Panel pnl_BTR;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		private System.Windows.Forms.Label lbl_YieldStatus;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel pnl_BB2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_BB1;
		public COM.FSP fgrid_Yield;
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.TabPage tabPage_MLU;
		public COM.FSP fgrid_Upload;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label btn_OpenFile;
		private System.Windows.Forms.TextBox txt_UploadFile;
		private System.Windows.Forms.Label lbl_UploadFile;
		public System.Windows.Forms.CheckBox chk_CheckInOut;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_YieldType;
		private C1.Win.C1List.C1Combo cmb_YieldStatus;
		public System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label btn_Confirm;
		private System.Windows.Forms.Label btn_Upload;
		private System.Windows.Forms.Label btn_Neomics;
		private System.Windows.Forms.Label btn_CompSeqBatch;
		private System.Windows.Forms.Label btn_YieldCopy;
		private System.Windows.Forms.Label btn_ViewHistory;
		public System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.MenuItem menuItem_CompDelete;
		private System.Windows.Forms.MenuItem menuItem_AddRawMat;
		private System.Windows.Forms.MenuItem menuItem_Separator5;
		private System.Windows.Forms.MenuItem menuItem_AddJointMat;
		private System.Windows.Forms.ContextMenu cmenu_ReadOnly;
		private System.Windows.Forms.MenuItem menuItem_DisplaySize;
		private System.Windows.Forms.Label btn_YieldInspection;
		private System.Windows.Forms.Label btn_YieldCheck;
		private System.Windows.Forms.Label btn_Restore;
		private System.Windows.Forms.Label btn_Backup;
		private System.Windows.Forms.Label btn_StatusCheck;
		private System.Windows.Forms.Label btn_UploadCondition;
		private System.ComponentModel.IContainer components = null;



		// to handle node dragging
		internal struct DRAG_INFO
		{
			public bool		dragging;	// currently dragging
			public bool		checkDrag;	// currently checking mouse to start dragging
			public int		row;		// index of row being dragged
			public Point	mouseDown;	// mouse down position
		}
 

		public Form_BC_Yield_withExcel()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BC_Yield_withExcel));
			this.cmenu_Yield = new System.Windows.Forms.ContextMenu();
			this.menuitem_AddCmp = new System.Windows.Forms.MenuItem();
			this.menuitem_AddTemplate = new System.Windows.Forms.MenuItem();
			this.menuItem_Separator1 = new System.Windows.Forms.MenuItem();
			this.menuitem_Modify = new System.Windows.Forms.MenuItem();
			this.menuItem_ModifyItem = new System.Windows.Forms.MenuItem();
			this.menuItem_ModifySpec = new System.Windows.Forms.MenuItem();
			this.menuItem_ModifyColor = new System.Windows.Forms.MenuItem();
			this.menuItem_Separator4 = new System.Windows.Forms.MenuItem();
			this.menuItem_CompDelete = new System.Windows.Forms.MenuItem();
			this.menuitem_Delete = new System.Windows.Forms.MenuItem();
			this.menuItem_CancelFlag = new System.Windows.Forms.MenuItem();
			this.menuItem_Separator2 = new System.Windows.Forms.MenuItem();
			this.menuItem_StyleCopy = new System.Windows.Forms.MenuItem();
			this.menuItem_Copy = new System.Windows.Forms.MenuItem();
			this.menuItem_Separator3 = new System.Windows.Forms.MenuItem();
			this.menuItem_AutoReplace = new System.Windows.Forms.MenuItem();
			this.menuItem_AllInsert = new System.Windows.Forms.MenuItem();
			this.menuItem_AllDelete = new System.Windows.Forms.MenuItem();
			this.menuItem_Separator5 = new System.Windows.Forms.MenuItem();
			this.menuItem_AddRawMat = new System.Windows.Forms.MenuItem();
			this.menuItem_AddJointMat = new System.Windows.Forms.MenuItem();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.pnl_B = new System.Windows.Forms.Panel();
			this.pnl_BB1 = new System.Windows.Forms.Panel();
			this.fgrid_Yield = new COM.FSP();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_BB2 = new System.Windows.Forms.Panel();
			this.tab_Main = new System.Windows.Forms.TabControl();
			this.tabPage_MLU = new System.Windows.Forms.TabPage();
			this.fgrid_Upload = new COM.FSP();
			this.cmenu_Upload = new System.Windows.Forms.ContextMenu();
			this.menuItem_SetYield_Comparison = new System.Windows.Forms.MenuItem();
			this.menuItem_SetYield_Size = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_SetJoint = new System.Windows.Forms.MenuItem();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btn_OpenFile = new System.Windows.Forms.Label();
			this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_UploadFile = new System.Windows.Forms.TextBox();
			this.lbl_UploadFile = new System.Windows.Forms.Label();
			this.btn_Upload = new System.Windows.Forms.Label();
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_Neomics = new System.Windows.Forms.Label();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_YieldType = new C1.Win.C1List.C1Combo();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.txt_Presto = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_Gender = new System.Windows.Forms.TextBox();
			this.lbl_Gender = new System.Windows.Forms.Label();
			this.lbl_YieldType = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pnl_BTR = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Confirm = new System.Windows.Forms.Label();
			this.cmb_YieldStatus = new C1.Win.C1List.C1Combo();
			this.chk_CheckInOut = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_All = new System.Windows.Forms.RadioButton();
			this.rad_Comp = new System.Windows.Forms.RadioButton();
			this.rad_SG = new System.Windows.Forms.RadioButton();
			this.lbl_YieldStatus = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btn_CompSeqBatch = new System.Windows.Forms.Label();
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_YieldCopy = new System.Windows.Forms.Label();
			this.btn_ViewHistory = new System.Windows.Forms.Label();
			this.cmenu_ReadOnly = new System.Windows.Forms.ContextMenu();
			this.menuItem_DisplaySize = new System.Windows.Forms.MenuItem();
			this.btn_YieldInspection = new System.Windows.Forms.Label();
			this.btn_YieldCheck = new System.Windows.Forms.Label();
			this.btn_Restore = new System.Windows.Forms.Label();
			this.btn_Backup = new System.Windows.Forms.Label();
			this.btn_StatusCheck = new System.Windows.Forms.Label();
			this.btn_UploadCondition = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.pnl_BB1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).BeginInit();
			this.pnl_BB2.SuspendLayout();
			this.tab_Main.SuspendLayout();
			this.tabPage_MLU.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upload)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_YieldType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_BTR.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
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
			// cmenu_Yield
			// 
			this.cmenu_Yield.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuitem_AddCmp,
																						this.menuitem_AddTemplate,
																						this.menuItem_Separator1,
																						this.menuitem_Modify,
																						this.menuItem_ModifyItem,
																						this.menuItem_ModifySpec,
																						this.menuItem_ModifyColor,
																						this.menuItem_Separator4,
																						this.menuItem_CompDelete,
																						this.menuitem_Delete,
																						this.menuItem_CancelFlag,
																						this.menuItem_Separator2,
																						this.menuItem_StyleCopy,
																						this.menuItem_Copy,
																						this.menuItem_Separator3,
																						this.menuItem_AutoReplace,
																						this.menuItem_AllInsert,
																						this.menuItem_AllDelete,
																						this.menuItem_Separator5,
																						this.menuItem_AddRawMat,
																						this.menuItem_AddJointMat});
			this.cmenu_Yield.Popup += new System.EventHandler(this.cmenu_Yield_Popup);
			// 
			// menuitem_AddCmp
			// 
			this.menuitem_AddCmp.Index = 0;
			this.menuitem_AddCmp.Text = "Add Component";
			this.menuitem_AddCmp.Click += new System.EventHandler(this.menuitem_AddCmp_Click);
			// 
			// menuitem_AddTemplate
			// 
			this.menuitem_AddTemplate.Index = 1;
			this.menuitem_AddTemplate.Text = "Add Template";
			this.menuitem_AddTemplate.Click += new System.EventHandler(this.menuitem_AddTemplate_Click);
			// 
			// menuItem_Separator1
			// 
			this.menuItem_Separator1.Index = 2;
			this.menuItem_Separator1.Text = "-";
			// 
			// menuitem_Modify
			// 
			this.menuitem_Modify.Index = 3;
			this.menuitem_Modify.Text = "Modify Yield Value";
			this.menuitem_Modify.Click += new System.EventHandler(this.menuitem_Modify_Click);
			// 
			// menuItem_ModifyItem
			// 
			this.menuItem_ModifyItem.Index = 4;
			this.menuItem_ModifyItem.Text = "Modify Item";
			this.menuItem_ModifyItem.Click += new System.EventHandler(this.menuItem_ModifyItem_Click);
			// 
			// menuItem_ModifySpec
			// 
			this.menuItem_ModifySpec.Index = 5;
			this.menuItem_ModifySpec.Text = "Modify Specification";
			this.menuItem_ModifySpec.Click += new System.EventHandler(this.menuItem_ModifySpec_Click);
			// 
			// menuItem_ModifyColor
			// 
			this.menuItem_ModifyColor.Index = 6;
			this.menuItem_ModifyColor.Text = "Modify Color";
			this.menuItem_ModifyColor.Click += new System.EventHandler(this.menuItem_ModifyColor_Click);
			// 
			// menuItem_Separator4
			// 
			this.menuItem_Separator4.Index = 7;
			this.menuItem_Separator4.Text = "-";
			// 
			// menuItem_CompDelete
			// 
			this.menuItem_CompDelete.Index = 8;
			this.menuItem_CompDelete.Text = "Component Delete";
			this.menuItem_CompDelete.Click += new System.EventHandler(this.menuItem_CompDelete_Click);
			// 
			// menuitem_Delete
			// 
			this.menuitem_Delete.Index = 9;
			this.menuitem_Delete.Text = "Delete";
			this.menuitem_Delete.Click += new System.EventHandler(this.menuitem_Delete_Click);
			// 
			// menuItem_CancelFlag
			// 
			this.menuItem_CancelFlag.Index = 10;
			this.menuItem_CancelFlag.Text = "Delete Cancel";
			this.menuItem_CancelFlag.Click += new System.EventHandler(this.menuItem_CancelFlag_Click);
			// 
			// menuItem_Separator2
			// 
			this.menuItem_Separator2.Index = 11;
			this.menuItem_Separator2.Text = "-";
			// 
			// menuItem_StyleCopy
			// 
			this.menuItem_StyleCopy.Index = 12;
			this.menuItem_StyleCopy.Text = "Style Copy";
			this.menuItem_StyleCopy.Click += new System.EventHandler(this.menuItem_StyleCopy_Click);
			// 
			// menuItem_Copy
			// 
			this.menuItem_Copy.Index = 13;
			this.menuItem_Copy.Text = "Copy";
			this.menuItem_Copy.Click += new System.EventHandler(this.menuItem_Copy_Click);
			// 
			// menuItem_Separator3
			// 
			this.menuItem_Separator3.Index = 14;
			this.menuItem_Separator3.Text = "-";
			// 
			// menuItem_AutoReplace
			// 
			this.menuItem_AutoReplace.Index = 15;
			this.menuItem_AutoReplace.Text = "Material All Replace";
			this.menuItem_AutoReplace.Click += new System.EventHandler(this.menuItem_AutoReplace_Click);
			// 
			// menuItem_AllInsert
			// 
			this.menuItem_AllInsert.Index = 16;
			this.menuItem_AllInsert.Text = "Material All Insert";
			this.menuItem_AllInsert.Click += new System.EventHandler(this.menuItem_AllInsert_Click);
			// 
			// menuItem_AllDelete
			// 
			this.menuItem_AllDelete.Index = 17;
			this.menuItem_AllDelete.Text = "Material All Delete";
			this.menuItem_AllDelete.Click += new System.EventHandler(this.menuItem_AllDelete_Click);
			// 
			// menuItem_Separator5
			// 
			this.menuItem_Separator5.Index = 18;
			this.menuItem_Separator5.Text = "-";
			// 
			// menuItem_AddRawMat
			// 
			this.menuItem_AddRawMat.Index = 19;
			this.menuItem_AddRawMat.Text = "Add Raw Material";
			this.menuItem_AddRawMat.Click += new System.EventHandler(this.menuItem_AddRawMat_Click);
			// 
			// menuItem_AddJointMat
			// 
			this.menuItem_AddJointMat.Index = 20;
			this.menuItem_AddJointMat.Text = "Add Joint Material";
			this.menuItem_AddJointMat.Click += new System.EventHandler(this.menuItem_AddJointMat_Click);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.pnl_BB1);
			this.pnl_B.Controls.Add(this.splitter1);
			this.pnl_B.Controls.Add(this.pnl_BB2);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.Bottom = 5;
			this.pnl_B.DockPadding.Left = 5;
			this.pnl_B.DockPadding.Right = 5;
			this.pnl_B.Location = new System.Drawing.Point(0, 56);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 555);
			this.pnl_B.TabIndex = 28;
			// 
			// pnl_BB1
			// 
			this.pnl_BB1.Controls.Add(this.fgrid_Yield);
			this.pnl_BB1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_BB1.DockPadding.Bottom = 3;
			this.pnl_BB1.Location = new System.Drawing.Point(5, 104);
			this.pnl_BB1.Name = "pnl_BB1";
			this.pnl_BB1.Size = new System.Drawing.Size(1006, 299);
			this.pnl_BB1.TabIndex = 49;
			// 
			// fgrid_Yield
			// 
			this.fgrid_Yield.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Yield.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Yield.ContextMenu = this.cmenu_Yield;
			this.fgrid_Yield.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Yield.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Yield.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Yield.Name = "fgrid_Yield";
			this.fgrid_Yield.Size = new System.Drawing.Size(1006, 296);
			this.fgrid_Yield.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Yield.TabIndex = 665;
			this.fgrid_Yield.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_Yield_DragOver);
			this.fgrid_Yield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseMove);
			this.fgrid_Yield.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_AfterResizeColumn);
			this.fgrid_Yield.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_BeforeEdit);
			this.fgrid_Yield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseDown);
			this.fgrid_Yield.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Yield_MouseUp);
			this.fgrid_Yield.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Yield_AfterEdit);
			this.fgrid_Yield.DragDrop += new System.Windows.Forms.DragEventHandler(this.fgrid_Yield_DragDrop);
			this.fgrid_Yield.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_Yield_KeyDown);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(5, 403);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1006, 3);
			this.splitter1.TabIndex = 48;
			this.splitter1.TabStop = false;
			// 
			// pnl_BB2
			// 
			this.pnl_BB2.Controls.Add(this.tab_Main);
			this.pnl_BB2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB2.DockPadding.Top = 2;
			this.pnl_BB2.Location = new System.Drawing.Point(5, 406);
			this.pnl_BB2.Name = "pnl_BB2";
			this.pnl_BB2.Size = new System.Drawing.Size(1006, 144);
			this.pnl_BB2.TabIndex = 47;
			// 
			// tab_Main
			// 
			this.tab_Main.Controls.Add(this.tabPage_MLU);
			this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tab_Main.ItemSize = new System.Drawing.Size(73, 19);
			this.tab_Main.Location = new System.Drawing.Point(0, 2);
			this.tab_Main.Multiline = true;
			this.tab_Main.Name = "tab_Main";
			this.tab_Main.SelectedIndex = 0;
			this.tab_Main.Size = new System.Drawing.Size(1006, 142);
			this.tab_Main.TabIndex = 3;
			this.tab_Main.Click += new System.EventHandler(this.tab_Main_Click);
			// 
			// tabPage_MLU
			// 
			this.tabPage_MLU.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage_MLU.Controls.Add(this.btn_Neomics);
			this.tabPage_MLU.Controls.Add(this.fgrid_Upload);
			this.tabPage_MLU.Controls.Add(this.groupBox4);
			this.tabPage_MLU.DockPadding.Top = -6;
			this.tabPage_MLU.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage_MLU.Location = new System.Drawing.Point(4, 23);
			this.tabPage_MLU.Name = "tabPage_MLU";
			this.tabPage_MLU.Size = new System.Drawing.Size(998, 115);
			this.tabPage_MLU.TabIndex = 0;
			this.tabPage_MLU.Text = "Material Usage List";
			// 
			// fgrid_Upload
			// 
			this.fgrid_Upload.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Upload.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Upload.ContextMenu = this.cmenu_Upload;
			this.fgrid_Upload.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Upload.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Upload.Location = new System.Drawing.Point(0, 32);
			this.fgrid_Upload.Name = "fgrid_Upload";
			this.fgrid_Upload.Size = new System.Drawing.Size(998, 83);
			this.fgrid_Upload.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Upload.TabIndex = 665;
			this.fgrid_Upload.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_Upload_DragOver);
			this.fgrid_Upload.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Upload_AfterResizeColumn);
			this.fgrid_Upload.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.fgrid_Upload_BeforeMouseDown);
			this.fgrid_Upload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_Upload_KeyDown);
			// 
			// cmenu_Upload
			// 
			this.cmenu_Upload.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem_SetYield_Comparison,
																						 this.menuItem_SetYield_Size,
																						 this.menuItem1,
																						 this.menuItem_SetJoint});
			this.cmenu_Upload.Popup += new System.EventHandler(this.cmenu_Upload_Popup);
			// 
			// menuItem_SetYield_Comparison
			// 
			this.menuItem_SetYield_Comparison.Index = 0;
			this.menuItem_SetYield_Comparison.Text = "Set Yield (Comparison)";
			this.menuItem_SetYield_Comparison.Click += new System.EventHandler(this.menuItem_SetYield_Click);
			// 
			// menuItem_SetYield_Size
			// 
			this.menuItem_SetYield_Size.Index = 1;
			this.menuItem_SetYield_Size.Text = "Set Yield (Size Yield Value)";
			this.menuItem_SetYield_Size.Click += new System.EventHandler(this.menuItem_SetYield_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// menuItem_SetJoint
			// 
			this.menuItem_SetJoint.Index = 3;
			this.menuItem_SetJoint.Text = "Set Joint Material Symbol";
			this.menuItem_SetJoint.Click += new System.EventHandler(this.menuItem_SetJoint_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.btn_UploadCondition);
			this.groupBox4.Controls.Add(this.btn_OpenFile);
			this.groupBox4.Controls.Add(this.txt_UploadFile);
			this.groupBox4.Controls.Add(this.lbl_UploadFile);
			this.groupBox4.Controls.Add(this.btn_Upload);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, -6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(998, 38);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			// 
			// btn_OpenFile
			// 
			this.btn_OpenFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_OpenFile.ImageIndex = 0;
			this.btn_OpenFile.ImageList = this.img_SmallButton;
			this.btn_OpenFile.Location = new System.Drawing.Point(761, 11);
			this.btn_OpenFile.Name = "btn_OpenFile";
			this.btn_OpenFile.Size = new System.Drawing.Size(21, 21);
			this.btn_OpenFile.TabIndex = 662;
			this.btn_OpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
			this.btn_OpenFile.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_OpenFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_OpenFile.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_OpenFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_UploadFile
			// 
			this.txt_UploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_UploadFile.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_UploadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_UploadFile.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_UploadFile.Location = new System.Drawing.Point(104, 11);
			this.txt_UploadFile.MaxLength = 100;
			this.txt_UploadFile.Name = "txt_UploadFile";
			this.txt_UploadFile.ReadOnly = true;
			this.txt_UploadFile.Size = new System.Drawing.Size(656, 21);
			this.txt_UploadFile.TabIndex = 661;
			this.txt_UploadFile.Text = "";
			// 
			// lbl_UploadFile
			// 
			this.lbl_UploadFile.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_UploadFile.ImageIndex = 0;
			this.lbl_UploadFile.ImageList = this.img_Label;
			this.lbl_UploadFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_UploadFile.Location = new System.Drawing.Point(3, 11);
			this.lbl_UploadFile.Name = "lbl_UploadFile";
			this.lbl_UploadFile.Size = new System.Drawing.Size(100, 21);
			this.lbl_UploadFile.TabIndex = 660;
			this.lbl_UploadFile.Text = "Upload File";
			this.lbl_UploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Upload
			// 
			this.btn_Upload.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Upload.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Upload.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Upload.ImageIndex = 0;
			this.btn_Upload.ImageList = this.img_Button;
			this.btn_Upload.Location = new System.Drawing.Point(789, 10);
			this.btn_Upload.Name = "btn_Upload";
			this.btn_Upload.TabIndex = 667;
			this.btn_Upload.Text = "Upload";
			this.btn_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
			this.btn_Upload.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Upload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Upload.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Upload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(100, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Neomics
			// 
			this.btn_Neomics.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Neomics.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Neomics.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Neomics.ImageIndex = 0;
			this.btn_Neomics.ImageList = this.img_Button;
			this.btn_Neomics.Location = new System.Drawing.Point(792, 40);
			this.btn_Neomics.Name = "btn_Neomics";
			this.btn_Neomics.TabIndex = 668;
			this.btn_Neomics.Text = "Neomics";
			this.btn_Neomics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Neomics.Visible = false;
			this.btn_Neomics.Click += new System.EventHandler(this.btn_Neomics_Click);
			this.btn_Neomics.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Neomics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Neomics.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Neomics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Controls.Add(this.pnl_BTR);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(5, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1006, 104);
			this.pnl_BT.TabIndex = 46;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_YieldType);
			this.pnl_SearchImage.Controls.Add(this.cmb_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.txt_Presto);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.txt_Gender);
			this.pnl_SearchImage.Controls.Add(this.lbl_Gender);
			this.pnl_SearchImage.Controls.Add(this.lbl_YieldType);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(656, 99);
			this.pnl_SearchImage.TabIndex = 19;
			// 
			// cmb_YieldType
			// 
			this.cmb_YieldType.AddItemCols = 0;
			this.cmb_YieldType.AddItemSeparator = ';';
			this.cmb_YieldType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_YieldType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_YieldType.Caption = "";
			this.cmb_YieldType.CaptionHeight = 17;
			this.cmb_YieldType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_YieldType.ColumnCaptionHeight = 18;
			this.cmb_YieldType.ColumnFooterHeight = 18;
			this.cmb_YieldType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_YieldType.ContentHeight = 17;
			this.cmb_YieldType.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_YieldType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_YieldType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_YieldType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_YieldType.EditorHeight = 17;
			this.cmb_YieldType.Enabled = false;
			this.cmb_YieldType.GapHeight = 2;
			this.cmb_YieldType.ItemHeight = 15;
			this.cmb_YieldType.Location = new System.Drawing.Point(109, 54);
			this.cmb_YieldType.MatchEntryTimeout = ((long)(2000));
			this.cmb_YieldType.MaxDropDownItems = ((short)(5));
			this.cmb_YieldType.MaxLength = 32767;
			this.cmb_YieldType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_YieldType.Name = "cmb_YieldType";
			this.cmb_YieldType.PartialRightColumn = false;
			this.cmb_YieldType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cmb_YieldType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_YieldType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_YieldType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_YieldType.Size = new System.Drawing.Size(150, 21);
			this.cmb_YieldType.TabIndex = 536;
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
			this.cmb_StyleCd.Location = new System.Drawing.Point(478, 32);
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
			this.cmb_StyleCd.Size = new System.Drawing.Size(150, 21);
			this.cmb_StyleCd.TabIndex = 55;
			this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 54;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// txt_Presto
			// 
			this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Presto.Location = new System.Drawing.Point(478, 54);
			this.txt_Presto.MaxLength = 100;
			this.txt_Presto.Name = "txt_Presto";
			this.txt_Presto.ReadOnly = true;
			this.txt_Presto.Size = new System.Drawing.Size(150, 21);
			this.txt_Presto.TabIndex = 535;
			this.txt_Presto.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(381, 32);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(96, 21);
			this.txt_StyleCd.TabIndex = 531;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// txt_Gender
			// 
			this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Gender.Location = new System.Drawing.Point(381, 54);
			this.txt_Gender.MaxLength = 100;
			this.txt_Gender.Name = "txt_Gender";
			this.txt_Gender.ReadOnly = true;
			this.txt_Gender.Size = new System.Drawing.Size(96, 21);
			this.txt_Gender.TabIndex = 31;
			this.txt_Gender.Text = "";
			// 
			// lbl_Gender
			// 
			this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Gender.ImageIndex = 0;
			this.lbl_Gender.ImageList = this.img_Label;
			this.lbl_Gender.Location = new System.Drawing.Point(280, 54);
			this.lbl_Gender.Name = "lbl_Gender";
			this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender.TabIndex = 530;
			this.lbl_Gender.Text = "Gender/ Presto";
			this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_YieldType
			// 
			this.lbl_YieldType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_YieldType.ImageIndex = 1;
			this.lbl_YieldType.ImageList = this.img_Label;
			this.lbl_YieldType.Location = new System.Drawing.Point(8, 54);
			this.lbl_YieldType.Name = "lbl_YieldType";
			this.lbl_YieldType.Size = new System.Drawing.Size(100, 21);
			this.lbl_YieldType.TabIndex = 529;
			this.lbl_YieldType.Text = "Yield Value Type";
			this.lbl_YieldType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 528;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Style.ImageIndex = 1;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(280, 32);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 527;
			this.lbl_Style.Text = "Style Code";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(555, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 59);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(640, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
			this.picb_TM.Size = new System.Drawing.Size(432, 40);
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
			this.lbl_SubTitle1.Text = "      Yield Infomation";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(640, 84);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 83);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(496, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 84);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(144, 32);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(488, 67);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 66);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pnl_BTR
			// 
			this.pnl_BTR.Controls.Add(this.panel1);
			this.pnl_BTR.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnl_BTR.DockPadding.Left = 3;
			this.pnl_BTR.Location = new System.Drawing.Point(656, 0);
			this.pnl_BTR.Name = "pnl_BTR";
			this.pnl_BTR.Size = new System.Drawing.Size(350, 99);
			this.pnl_BTR.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.btn_Confirm);
			this.panel1.Controls.Add(this.cmb_YieldStatus);
			this.panel1.Controls.Add(this.chk_CheckInOut);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.lbl_YieldStatus);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.lbl_SubTitle2);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(347, 99);
			this.panel1.TabIndex = 20;
			// 
			// btn_Confirm
			// 
			this.btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Confirm.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Confirm.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Confirm.ImageIndex = 0;
			this.btn_Confirm.ImageList = this.img_Button;
			this.btn_Confirm.Location = new System.Drawing.Point(240, 31);
			this.btn_Confirm.Name = "btn_Confirm";
			this.btn_Confirm.TabIndex = 666;
			this.btn_Confirm.Text = "Confirm";
			this.btn_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
			this.btn_Confirm.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Confirm.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// cmb_YieldStatus
			// 
			this.cmb_YieldStatus.AddItemCols = 0;
			this.cmb_YieldStatus.AddItemSeparator = ';';
			this.cmb_YieldStatus.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_YieldStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_YieldStatus.Caption = "";
			this.cmb_YieldStatus.CaptionHeight = 17;
			this.cmb_YieldStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_YieldStatus.ColumnCaptionHeight = 18;
			this.cmb_YieldStatus.ColumnFooterHeight = 18;
			this.cmb_YieldStatus.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_YieldStatus.ContentHeight = 17;
			this.cmb_YieldStatus.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_YieldStatus.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_YieldStatus.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_YieldStatus.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_YieldStatus.EditorHeight = 17;
			this.cmb_YieldStatus.GapHeight = 2;
			this.cmb_YieldStatus.ItemHeight = 15;
			this.cmb_YieldStatus.Location = new System.Drawing.Point(109, 32);
			this.cmb_YieldStatus.MatchEntryTimeout = ((long)(2000));
			this.cmb_YieldStatus.MaxDropDownItems = ((short)(5));
			this.cmb_YieldStatus.MaxLength = 32767;
			this.cmb_YieldStatus.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_YieldStatus.Name = "cmb_YieldStatus";
			this.cmb_YieldStatus.PartialRightColumn = false;
			this.cmb_YieldStatus.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cmb_YieldStatus.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_YieldStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_YieldStatus.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_YieldStatus.Size = new System.Drawing.Size(129, 21);
			this.cmb_YieldStatus.TabIndex = 664;
			// 
			// chk_CheckInOut
			// 
			this.chk_CheckInOut.BackColor = System.Drawing.SystemColors.Window;
			this.chk_CheckInOut.Font = new System.Drawing.Font("Verdana", 9F);
			this.chk_CheckInOut.Location = new System.Drawing.Point(8, 55);
			this.chk_CheckInOut.Name = "chk_CheckInOut";
			this.chk_CheckInOut.Size = new System.Drawing.Size(120, 20);
			this.chk_CheckInOut.TabIndex = 663;
			this.chk_CheckInOut.Text = "Check In/Out";
			this.chk_CheckInOut.CheckedChanged += new System.EventHandler(this.chk_CheckInOut_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_All);
			this.groupBox1.Controls.Add(this.rad_Comp);
			this.groupBox1.Controls.Add(this.rad_SG);
			this.groupBox1.Location = new System.Drawing.Point(160, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 39);
			this.groupBox1.TabIndex = 534;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tree View Option";
			// 
			// rad_All
			// 
			this.rad_All.Checked = true;
			this.rad_All.Location = new System.Drawing.Point(131, 19);
			this.rad_All.Name = "rad_All";
			this.rad_All.Size = new System.Drawing.Size(40, 16);
			this.rad_All.TabIndex = 36;
			this.rad_All.TabStop = true;
			this.rad_All.Tag = "-1";
			this.rad_All.Text = "All";
			this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Comp
			// 
			this.rad_Comp.Location = new System.Drawing.Point(67, 19);
			this.rad_Comp.Name = "rad_Comp";
			this.rad_Comp.Size = new System.Drawing.Size(64, 16);
			this.rad_Comp.TabIndex = 35;
			this.rad_Comp.Tag = "2";
			this.rad_Comp.Text = "Comp";
			this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_SG
			// 
			this.rad_SG.Location = new System.Drawing.Point(7, 19);
			this.rad_SG.Name = "rad_SG";
			this.rad_SG.Size = new System.Drawing.Size(60, 16);
			this.rad_SG.TabIndex = 34;
			this.rad_SG.Tag = "1";
			this.rad_SG.Text = "Semi";
			this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// lbl_YieldStatus
			// 
			this.lbl_YieldStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_YieldStatus.ImageIndex = 0;
			this.lbl_YieldStatus.ImageList = this.img_Label;
			this.lbl_YieldStatus.Location = new System.Drawing.Point(8, 32);
			this.lbl_YieldStatus.Name = "lbl_YieldStatus";
			this.lbl_YieldStatus.Size = new System.Drawing.Size(100, 21);
			this.lbl_YieldStatus.TabIndex = 531;
			this.lbl_YieldStatus.Text = "Yield Status";
			this.lbl_YieldStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(246, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 59);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(331, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 40);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(123, 40);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Yield Status";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(331, 84);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 83);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(187, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 84);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(144, 32);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(179, 67);
			this.pictureBox7.TabIndex = 27;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 66);
			this.pictureBox8.TabIndex = 25;
			this.pictureBox8.TabStop = false;
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "567";
			// 
			// btn_CompSeqBatch
			// 
			this.btn_CompSeqBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CompSeqBatch.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_CompSeqBatch.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_CompSeqBatch.ImageIndex = 0;
			this.btn_CompSeqBatch.ImageList = this.img_LongButton;
			this.btn_CompSeqBatch.Location = new System.Drawing.Point(437, 616);
			this.btn_CompSeqBatch.Name = "btn_CompSeqBatch";
			this.btn_CompSeqBatch.Size = new System.Drawing.Size(168, 23);
			this.btn_CompSeqBatch.TabIndex = 669;
			this.btn_CompSeqBatch.Text = "Keep the Component Seq.";
			this.btn_CompSeqBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CompSeqBatch.Click += new System.EventHandler(this.btn_CompSeqBatch_Click);
			this.btn_CompSeqBatch.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_CompSeqBatch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CompSeqBatch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_CompSeqBatch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(168, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_YieldCopy
			// 
			this.btn_YieldCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_YieldCopy.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_YieldCopy.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_YieldCopy.ImageIndex = 0;
			this.btn_YieldCopy.ImageList = this.img_Button;
			this.btn_YieldCopy.Location = new System.Drawing.Point(606, 616);
			this.btn_YieldCopy.Name = "btn_YieldCopy";
			this.btn_YieldCopy.TabIndex = 670;
			this.btn_YieldCopy.Text = "Yield Copy";
			this.btn_YieldCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_YieldCopy.Click += new System.EventHandler(this.btn_YieldCopy_Click);
			this.btn_YieldCopy.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_YieldCopy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_YieldCopy.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_YieldCopy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_ViewHistory
			// 
			this.btn_ViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ViewHistory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_ViewHistory.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_ViewHistory.ImageIndex = 0;
			this.btn_ViewHistory.ImageList = this.img_Button;
			this.btn_ViewHistory.Location = new System.Drawing.Point(910, 616);
			this.btn_ViewHistory.Name = "btn_ViewHistory";
			this.btn_ViewHistory.TabIndex = 671;
			this.btn_ViewHistory.Text = "View History";
			this.btn_ViewHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_ViewHistory.Click += new System.EventHandler(this.btn_ViewHistory_Click);
			this.btn_ViewHistory.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_ViewHistory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_ViewHistory.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_ViewHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// cmenu_ReadOnly
			// 
			this.cmenu_ReadOnly.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItem_DisplaySize});
			this.cmenu_ReadOnly.Popup += new System.EventHandler(this.cmenu_ReadOnly_Popup);
			// 
			// menuItem_DisplaySize
			// 
			this.menuItem_DisplaySize.Index = 0;
			this.menuItem_DisplaySize.Text = "Display Size Info";
			this.menuItem_DisplaySize.Click += new System.EventHandler(this.menuItem_DisplaySize_Click);
			// 
			// btn_YieldInspection
			// 
			this.btn_YieldInspection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_YieldInspection.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_YieldInspection.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_YieldInspection.ImageIndex = 0;
			this.btn_YieldInspection.ImageList = this.img_Button;
			this.btn_YieldInspection.Location = new System.Drawing.Point(807, 616);
			this.btn_YieldInspection.Name = "btn_YieldInspection";
			this.btn_YieldInspection.Size = new System.Drawing.Size(103, 23);
			this.btn_YieldInspection.TabIndex = 672;
			this.btn_YieldInspection.Text = "Yield Inspection";
			this.btn_YieldInspection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_YieldInspection.Click += new System.EventHandler(this.btn_YieldInspection_Click);
			this.btn_YieldInspection.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_YieldInspection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_YieldInspection.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_YieldInspection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_YieldCheck
			// 
			this.btn_YieldCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_YieldCheck.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_YieldCheck.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_YieldCheck.ImageIndex = 0;
			this.btn_YieldCheck.ImageList = this.img_Button;
			this.btn_YieldCheck.Location = new System.Drawing.Point(707, 616);
			this.btn_YieldCheck.Name = "btn_YieldCheck";
			this.btn_YieldCheck.TabIndex = 673;
			this.btn_YieldCheck.Text = "Yield Check";
			this.btn_YieldCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_YieldCheck.Click += new System.EventHandler(this.btn_YieldCheck_Click);
			this.btn_YieldCheck.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_YieldCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_YieldCheck.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_YieldCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Restore
			// 
			this.btn_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Restore.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Restore.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Restore.ForeColor = System.Drawing.Color.Tomato;
			this.btn_Restore.ImageIndex = 0;
			this.btn_Restore.ImageList = this.img_Button;
			this.btn_Restore.Location = new System.Drawing.Point(109, 616);
			this.btn_Restore.Name = "btn_Restore";
			this.btn_Restore.TabIndex = 674;
			this.btn_Restore.Text = "Restore";
			this.btn_Restore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
			this.btn_Restore.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Restore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Restore.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Restore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Backup
			// 
			this.btn_Backup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Backup.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Backup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Backup.ForeColor = System.Drawing.Color.Tomato;
			this.btn_Backup.ImageIndex = 0;
			this.btn_Backup.ImageList = this.img_Button;
			this.btn_Backup.Location = new System.Drawing.Point(8, 616);
			this.btn_Backup.Name = "btn_Backup";
			this.btn_Backup.TabIndex = 675;
			this.btn_Backup.Text = "Backup";
			this.btn_Backup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
			this.btn_Backup.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Backup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Backup.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Backup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_StatusCheck
			// 
			this.btn_StatusCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_StatusCheck.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_StatusCheck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_StatusCheck.ForeColor = System.Drawing.Color.Tomato;
			this.btn_StatusCheck.ImageIndex = 0;
			this.btn_StatusCheck.ImageList = this.img_Button;
			this.btn_StatusCheck.Location = new System.Drawing.Point(210, 616);
			this.btn_StatusCheck.Name = "btn_StatusCheck";
			this.btn_StatusCheck.TabIndex = 676;
			this.btn_StatusCheck.Text = "Status Check";
			this.btn_StatusCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_StatusCheck.Click += new System.EventHandler(this.btn_StatusCheck_Click);
			this.btn_StatusCheck.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_StatusCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_StatusCheck.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_StatusCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_UploadCondition
			// 
			this.btn_UploadCondition.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_UploadCondition.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_UploadCondition.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_UploadCondition.ImageIndex = 0;
			this.btn_UploadCondition.ImageList = this.img_Button;
			this.btn_UploadCondition.Location = new System.Drawing.Point(890, 10);
			this.btn_UploadCondition.Name = "btn_UploadCondition";
			this.btn_UploadCondition.TabIndex = 668;
			this.btn_UploadCondition.Text = ">> Condition";
			this.btn_UploadCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_UploadCondition.Click += new System.EventHandler(this.btn_UploadCondition_Click);
			this.btn_UploadCondition.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_UploadCondition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_UploadCondition.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_UploadCondition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Form_BC_Yield_withExcel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.btn_StatusCheck);
			this.Controls.Add(this.btn_Backup);
			this.Controls.Add(this.btn_Restore);
			this.Controls.Add(this.btn_YieldCheck);
			this.Controls.Add(this.btn_YieldInspection);
			this.Controls.Add(this.pnl_B);
			this.Controls.Add(this.btn_CompSeqBatch);
			this.Controls.Add(this.btn_YieldCopy);
			this.Controls.Add(this.btn_ViewHistory);
			this.Name = "Form_BC_Yield_withExcel";
			this.Text = "Yield";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BC_Yield_withExcel_Closing);
			this.Load += new System.EventHandler(this.Form_BC_Yield_withExcel_Load);
			this.Activated += new System.EventHandler(this.Form_BC_Yield_withExcel_Activated);
			this.Controls.SetChildIndex(this.btn_ViewHistory, 0);
			this.Controls.SetChildIndex(this.btn_YieldCopy, 0);
			this.Controls.SetChildIndex(this.btn_CompSeqBatch, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.btn_YieldInspection, 0);
			this.Controls.SetChildIndex(this.btn_YieldCheck, 0);
			this.Controls.SetChildIndex(this.btn_Restore, 0);
			this.Controls.SetChildIndex(this.btn_Backup, 0);
			this.Controls.SetChildIndex(this.btn_StatusCheck, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.pnl_BB1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Yield)).EndInit();
			this.pnl_BB2.ResumeLayout(false);
			this.tab_Main.ResumeLayout(false);
			this.tabPage_MLU.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Upload)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_YieldType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_BTR.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_YieldStatus)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		// 행 이미지 저장
		private Hashtable _Imgmap = new Hashtable(); 
		private Hashtable _ImgmapAction = new Hashtable();

		// semigood cd, component cd level
		private const int _SGLevel = 1, _CmpLevel = 2;

		// Raw Material 만 있는 BOM Template 구조 선택했을 경우 레벨
		private string _OnlyRawMat_TemplateLevel = "1";

		//BOM template 중 raw material 만 있는 구조 코드
		private string _OnlyRawMat_TemplateCd = "00005";

		// 기준 채산 타입  
		private string _DefaultYieldType = "M"; 
		
		// type division
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		// 행 이미지 번호
		private int _IxImage_SG = 0, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
		private int _IxImage_Move = 5; 
 

		// 사이즈 자재인 경우 Specification 처리
		//private string _SizeSpecCd = "00000", _SizeSpecName = "NOTHING"; //= "Size";

		// 사이즈 자재인 경우 Specification Code 별 색깔 구분 
		private Color _Color_SizeSpecOdd = ClassLib.ComVar.ClrSel_Green;
		private Color _Color_SizeSpecEven = ClassLib.ComVar.ClrSel_Yellow; 
		private Color _Color_SizeSpecCurrent;




		// MLU Upload display level
		private const int _LevelComponent = 1, _LevelMaterial = 2;
		private const int _LevelMaterial_Neomics = 3;





		// drag and drop
		private DRAG_INFO _DragInfo; 
		private const int _DragTol = 5;	// mouse movement before dragging starts



		private bool _Checkin_Cancel = false;


		#endregion

		#region 멤버 메소드

		#region Initialize


		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{


				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion


			 
				//Title
				this.Text = "Yield Register";
				lbl_MainTitle.Text = "Yield Register";

				ClassLib.ComFunction.SetLangDic(this); 
 

				// 그리드 설정
				fgrid_Yield.Set_Grid("SBC_YIELD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				// i, d, u 이외에 drag 데이터(m)에 대한 기타 flag 값 추가
				_ImgmapAction = fgrid_Yield.Set_Action_Image(img_Action, true); 
				_ImgmapAction.Add("M", img_Type.Images[_IxImage_Move]); 




				if(chk_CheckInOut.Checked)
				{
					Control_Enable(true);
				}
				else
				{
					Control_Enable(false);
				}





				fgrid_Upload.Set_Grid("SBC_YIELD_UPLOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Upload.AllowDragging = AllowDraggingEnum.None;  

				 
				fgrid_Yield.Styles.Frozen.BackColor = Color.Empty;  
				fgrid_Yield.SelectionMode = SelectionModeEnum.Row;   
				
				fgrid_Yield.AllowDragging = AllowDraggingEnum.None; 
				fgrid_Yield.DropMode = DropModeEnum.Manual;  

				fgrid_Yield.KeyActionEnter = KeyActionEnum.MoveAcross;
				fgrid_Yield.KeyActionTab = KeyActionEnum.MoveAcross;  
				
				


				pnl_BB2.Size = new Size(1006, 24); 

				if(ClassLib.ComVar.This_Factory != ClassLib.ComVar.DSFactory)
				{
					pnl_BB2.Enabled = false;
					btn_CompSeqBatch.Enabled = false;

					cmb_YieldStatus.Enabled = false;
					btn_Confirm.Enabled = false;

				}


				//combobox setting
				Init_Control(); 
 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}





		/// <summary>
		/// Control_Enable : Check In/Out 에 대한 콘트롤 권한 부여
		/// </summary>
		/// <param name="arg_enable"></param>
		private void Control_Enable(bool arg_enable)
		{

			fgrid_Yield.AllowEditing = arg_enable; 
			
			
			btn_YieldCopy.Enabled = arg_enable; 
			cmb_Factory.Enabled = ! arg_enable;
			txt_StyleCd.Enabled = ! arg_enable;
			cmb_StyleCd.Enabled = ! arg_enable;



			



			
			if(arg_enable)
			{ 
				fgrid_Yield.ContextMenu = cmenu_Yield; 

				cmb_Factory.EditorBackColor = Color.FromKnownColor(KnownColor.Control);
				cmb_StyleCd.EditorBackColor = Color.FromKnownColor(KnownColor.Control); 
			}
			else
			{  
				//fgrid_Yield.ContextMenu = null;  
				fgrid_Yield.ContextMenu = cmenu_ReadOnly;

				cmb_Factory.EditorBackColor = Color.FromKnownColor(KnownColor.Window);
				cmb_StyleCd.EditorBackColor = Color.FromKnownColor(KnownColor.Window); 
			}



			if(ClassLib.ComVar.This_Factory != ClassLib.ComVar.DSFactory)
			{
				pnl_BB2.Enabled = false;
				btn_CompSeqBatch.Enabled = false;

				cmb_YieldStatus.Enabled = false;
				btn_Confirm.Enabled = false;



				btn_Backup.Visible = false;
				btn_Restore.Visible = false;
				btn_StatusCheck.Visible = false;



			}
			else
			{
				pnl_BB2.Enabled = arg_enable;
				btn_CompSeqBatch.Enabled = arg_enable;

				cmb_YieldStatus.Enabled = arg_enable;
				btn_Confirm.Enabled = arg_enable;


				btn_Backup.Visible = true;
				btn_Restore.Visible = true;
				btn_StatusCheck.Visible = true;
				btn_Backup.Enabled = arg_enable;
				btn_Restore.Enabled = arg_enable;
				//btn_StatusCheck.Enabled = arg_enable;



			} 
 
			




			if(tbtn_Save.Enabled)
			{
				chk_CheckInOut.Visible = true;
			}
			else
			{
				chk_CheckInOut.Visible = false;
			}


			cmb_Factory.Focus();
			cmb_StyleCd.Focus();


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
 

			// 공장코드
			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
  

			// Value Type ComboBox Add Items 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldType);
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_YieldType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_YieldType.SelectedValue = _DefaultYieldType; 
	   

			// Value Status ComboBox Add Items 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldStatus);
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_YieldStatus, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name);
			//cmb_YieldStatus.SelectedValue = main 데이터 출력시 세팅
	    


			dt_ret.Dispose();

			


		}


		#endregion

		#region 툴바 관련

		
		/// <summary>
		/// Clear_Control : 컨트롤 초기화
		/// </summary>
		private void Clear_Control()
		{
			cmb_Factory.SelectedIndex = -1; 
			//cmb_YieldType.SelectedIndex = -1; 
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1;
			txt_Gender.Text = "";  
			txt_Presto.Text = ""; 

			fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
			fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;

			txt_UploadFile.Text = "";
			fgrid_Upload.Rows.Count = fgrid_Yield.Rows.Fixed;
			fgrid_Upload.Cols.Count = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START;
			_Excel_StyleCd = "";


		}


		/// <summary>
		/// Search_Yield : 채산값 조회
		/// </summary>
		private void Search_Yield()
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldType.SelectedIndex == -1) return;

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;



				//-----------------------------------------------------------------------------------------------
				//저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
				bool exist_modify = Check_NotSave_Data("Search");
				if(exist_modify) return;
				//-----------------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------------
				//데이터 리스트 추출
				DataTable dt_ret;
				dt_ret = Select_Yield(cmb_Factory.SelectedValue.ToString(), 
					cmb_StyleCd.SelectedValue.ToString().Replace("-", ""),
					cmb_YieldType.SelectedValue.ToString() );
				//-----------------------------------------------------------------------------------------------
				
				

				//-----------------------------------------------------------------------------------------------
				//데이터 그리드로 표시
				fgrid_Yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_INFO.IxTREE;

				//그리드 행 이미지, 사이즈 자재 색깔 표시
				_Imgmap.Clear();

			 
				Display_CrossTab(dt_ret, 
					(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1 - 1, 
					(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1 - 1, 
					(int)ClassLib.TBSBC_YIELD_INFO.IxCOL_NUM, 
					(int)ClassLib.TBSBC_YIELD_INFO.IxYIELD_VALUE,
					(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD - 1,
					true) ;



  
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ImageAndText = true; 
				fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ImageMap = _Imgmap;  
				//-----------------------------------------------------------------------------------------------
				

				//-----------------------------------------------------------------------------------------------
				// yield status 표시
				//-----------------------------------------------------------------------------------------------
				dt_ret = Select_Yield_Status(cmb_Factory.SelectedValue.ToString(), cmb_StyleCd.SelectedValue.ToString().Replace("-", ""), " ");

 
//		 SELECT FACTORY, 
//			         PKG_SBC_COMMON.FN_GET_FORMAT_STYLECD(STYLE_CD) AS STYLE_CD,
//					 PKG_SBC_COMMON.FN_GET_STYLE_NAME(STYLE_CD)     AS STYLE_NAME,  
//					 YIELD_STATUS                                   AS YIELD_STATUS,                 
//					 YIELD_STATUS  								    AS HIDDEN_KEY, 
//					 YIELD_SEASON                                   AS YIELD_SEASON,  
//					 CONFIRM_YMD                                    AS CONFIRM_YMD, 
//					 UPD_YMD 	                                    AS JOB_DATE, 
//					 REMARKS                                        AS REMARKS,
//					 UPD_USER,
//					 UPD_YMD
//			    FROM SBC_YIELD_STATUS
//			   WHERE FACTORY         = ARG_FACTORY 
//				 AND STYLE_CD     LIKE TRIM(ARG_STYLE_CD) || '%'
//				 AND YIELD_STATUS LIKE TRIM(ARG_YIELD_STATUS) || '%'
//			   ORDER BY STYLE_CD, CONFIRM_YMD, UPD_YMD;



				if(dt_ret != null && dt_ret.Rows.Count > 0)
				{
					// 마지막 행이 가장 최신의 상태값
					_YieldStatus = dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[3].ToString();
					cmb_YieldStatus.SelectedValue = _YieldStatus;
				}



				//-----------------------------------------------------------------------------------------------


				//rad_All.Checked = true;

				rad_Comp.Checked = true;
				fgrid_Yield.Tree.Show(_CmpLevel);

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Yield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}
 

		/// <summary>
		/// Check_NotSave_Data : 저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
		/// </summary>
		private bool Check_NotSave_Data(string arg_part_message)
		{
			
			bool exist_modify = false;

			if (fgrid_Yield.Rows.Fixed < fgrid_Yield.Rows.Count)
			{
				
				string vTemp = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Fixed, 0, fgrid_Yield.Rows.Count - 1, 0).Clip.Replace("\r", "");
	
				if (vTemp.Length > 0)
				{
					if (MessageBox.Show(this, "Exist modify data. Do you want " + arg_part_message + "?", arg_part_message, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						exist_modify = true;
					}
				}// end if (vTemp.Length > 0)
			}
			 

			return exist_modify;
		} 
		 
		
 

		public string _SRFNo = "";
		public string _BOMID = "";
		public string _YieldStatus = "";


		/// <summary>
		/// Display_CrossTab : CrossTab조회
		/// </summary>
		/// <param name="arg_dt">data table</param>
		/// <param name="arg_key_fr">key field from 칼럼번호</param>		
		/// <param name="arg_key_to">key field to 칼럼번호</param>
		/// <param name="arg_colhead">column head 칼럼번호</param>		
		/// <param name="arg_display">display 칼럼번호</param>		
		/// <param name="arg_userdata">cell tag value 칼럼번호</param>					
		/// <param name="arg_tree"></param>
		private void Display_CrossTab(DataTable arg_dt, int arg_key_fr,  int arg_key_to,
			int arg_colhead,  int arg_display, int arg_userdata, 
			bool arg_tree)
		{
 									
			string str_newkey = "" ;
			string str_oldkey = "" ;
			
			CellRange cr; 

			_YieldStatus = "";

			try 
			{					
				//ROW 초기화
				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed ;  				

				//loop - DATA row
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{		
					str_newkey = "" ;
					
					//key field 생성
					for(int k = arg_key_fr; k <= arg_key_to; k++)
					{
						str_newkey = str_newkey + arg_dt.Rows[i].ItemArray[k].ToString() ;
					}					
															
					//loop -DATA column(마지막ROW는 제외)
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{							
						if(j <= arg_colhead)
						{
							//key field가 변경시 새로운 row 생성
							if(str_newkey != str_oldkey && j == 0)
							{
								if(arg_tree)
								{	
									fgrid_Yield.Rows.InsertNode(fgrid_Yield.Rows.Count, int.Parse(arg_dt.Rows[i].ItemArray[j].ToString()));
								}
								else
								{
									fgrid_Yield.AddItem("", fgrid_Yield.Rows.Count);								
								}



								//---------------------------------------------------------------------------------------------------------
								// 임의로 component_name 컬럼에 yield_status 조회
								if(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1 - 1].ToString() ) == _CmpLevel)
								{
									if(_YieldStatus.Trim().Equals("") )
									{
										_YieldStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_NAME - 1].ToString();
										cmb_YieldStatus.SelectedValue = _YieldStatus;
									}
								}


								if(_SRFNo.Trim().Equals("") )
								{
									_SRFNo = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO - 1].ToString();
								}

								if(_BOMID.Trim().Equals("") )
								{
									_BOMID = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID - 1].ToString();
								}

								//---------------------------------------------------------------------------------------------------------
 
							}
							
							// set division column
							fgrid_Yield[fgrid_Yield.Rows.Count-1, 0] = "";

							//칼럼이 크로스탭 항목일때:사이즈
							if(j == arg_colhead)
							{
								 
								//칼럼헤드의 위치를 조회하여 데이타 디스플레이
								try
								{
									if(int.Parse(arg_dt.Rows[i].ItemArray[arg_colhead].ToString()) > 0)
									{
										fgrid_Yield[fgrid_Yield.Rows.Count-1, arg_colhead + int.Parse(arg_dt.Rows[i].ItemArray[j].ToString())] = arg_dt.Rows[i].ItemArray[arg_display] ;

										cr = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count-1, arg_colhead + int.Parse(arg_dt.Rows[i].ItemArray[j].ToString()) );
										cr.UserData = arg_dt.Rows[i].ItemArray[arg_userdata].ToString();

										//--------------------------------------------------------------------------------------------------
										// 사이즈 자재 표시
										if(arg_colhead + int.Parse(arg_dt.Rows[i].ItemArray[j].ToString() ) == fgrid_Yield.Cols.Count - 1)
										{
											Display_Size_Material(fgrid_Yield.Rows.Count-1); 
										}  
										//--------------------------------------------------------------------------------------------------

 
									}
								}
								catch
								{
								}
									
							}
							else
							{

								fgrid_Yield[fgrid_Yield.Rows.Count-1,j+1] = arg_dt.Rows[i].ItemArray[j] ; 

								cr = fgrid_Yield.GetCellRange(fgrid_Yield.Rows.Count-1, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ);
								cr.UserData = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ - 1].ToString();
								 


								// INFO SPEC 표시
								fgrid_Yield[fgrid_Yield.Rows.Count-1, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD]
									= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO - 1].ToString();

								fgrid_Yield[fgrid_Yield.Rows.Count-1, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME]
									= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO - 1].ToString();
 

								 
							}
							//return ;	 

						}
					} // end for j



					//key field 변경시 display size, image setting
					if(str_newkey != str_oldkey)
					{ 


						// 이미지 표시
						Display_Type_Image(fgrid_Yield.Rows.Count-1);

						// 데이터 타입(M, J) 이 아니면 수정 불가 처리
						if(fgrid_Yield[fgrid_Yield.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeSG
							|| fgrid_Yield[fgrid_Yield.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
						{
							fgrid_Yield.Rows[fgrid_Yield.Rows.Count - 1].AllowEditing = false;
						} 

 

								 
					}

					str_oldkey = str_newkey;										
				} // end for i		 

					
			} // end try	
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Display_CrossTab", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
 
		}
 




		/// <summary>
		/// Save_Yield : 채산값 저장
		/// </summary>
		/// <param name="arg_show_message"></param>
		private void Save_Yield(bool arg_show_message)
		{ 
			
			
			bool make_flag = false;


			//1. get next template_seq , sbc_yield_value 
			//2. sbc_yield_info 


			if(arg_show_message)
			{
				DialogResult dr; 
				dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);  
				if(dr == DialogResult.No) return;   
			}


			// 1. component move 에 따른 반제별 component seq 재정리
			// 2. sbc_yield_value 
			// 3. sbc_yield_info

			make_flag = Make_SBC_YIELD_INFO_COMPONENT_SEQ(true);


			if(!make_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}
			else
			{
				make_flag = Make_SBC_YIELD_VALUE(false); 

				if(!make_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					make_flag = Make_SBC_YIELD_INFO(false);

					if(!make_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						return;
					}
					else
					{
						DataSet ds_ret;

						ds_ret = MyOraDB.Exe_Modify_Procedure();

						if(ds_ret == null)  // error
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
							return;
						}
						else
						{
							ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
 

							// 전체 재 조회 하지 않고, division "" 로 세팅
							// insert, update = "" 로 처리
							// delete = row 삭제로 처리  

							//fgrid_Yield.Refresh_Division();

							for(int i = fgrid_Yield.Rows.Count - 1; i >= fgrid_Yield.Rows.Fixed; i--)
							{
								if(fgrid_Yield[i, 0].ToString() == "") continue; 
							

								if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() != _TypeSG 
									&& fgrid_Yield[i, 0].ToString() == "D")
								{ 
									fgrid_Yield.Rows.Remove(i);
								}
								else
								{
									fgrid_Yield[i, 0] = "";
								}
							} 

						} // end if MyOraDB.Exe_Modify_Procedure()


					} // end if Make_SBC_YIELD_INFO(false)


				}  // end if Make_SBC_YIELD_VALUE(true)
			

			} // end if Make_SBC_YIELD_INFO_COMPONENT_SEQ()



		}




		
		/// <summary>
		/// Make_SBC_YIELD_INFO_COMPONENT_SEQ : component move 에 따른 반제별 component seq 재정리
		/// </summary>
		/// <param name="arg_clear"></param>
		/// <returns></returns>
		private bool Make_SBC_YIELD_INFO_COMPONENT_SEQ(bool arg_clear)
		{

			// ui : 반제 아래 옮겨진 component가 하나라도 있을 경우, component seq 반제별 재 정리
			// db : action_flag = "" 인 경우에 component_seq update 처리 

			try
			{
				C1.Win.C1FlexGrid.Node node;
				

				for(int i = fgrid_Yield.Rows.Fixed; i < fgrid_Yield.Rows.Count; i++)
				{

					
					node = fgrid_Yield.Rows[i].Node;

					if(node.Level != _SGLevel) continue;

					if(node.Children == 0) continue;


					int first_child_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int last_child_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					int move_count = 0;
					int now_level = 0;
					int now_component_seq = 0;

					for(int j = first_child_row; j <= last_child_row; j++)
					{

						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );
 
						if(now_level != _CmpLevel) continue;

						if(fgrid_Yield[j, 0].ToString() == "M") move_count++;

					}


					if(move_count == 0) continue; 


					
					

					for(int j = first_child_row; j <= last_child_row; j++)
					{
						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );
 
						if(now_level != _CmpLevel) continue;

						now_component_seq += _Component_Seq_Range;
 
						fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = Convert.ToString(now_component_seq); 

					} 


				} // end for i





				//행 수정 상태 해제
				fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);

				int col_ct = 7; 
				int save_row_ct = 0;    
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.UPDATE_SBC_YIELD_INFO_COMP_SEQ";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_FACTORY";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";   


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}


				// 저장 행 수 구하기
				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{ 
 
					node = fgrid_Yield.Rows[i].Node;

					if(node.Level != _SGLevel) continue;

					if(node.Children == 0) continue;


					int first_child_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int last_child_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					int move_count = 0;
					int now_level = 0; 


					for(int j = first_child_row; j <= last_child_row; j++)
					{

						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );
 
						if(now_level != _CmpLevel) continue;

						if(fgrid_Yield[j, 0].ToString() == "M") move_count++;

					}


					if(move_count == 0) continue;

 

					for(int j = first_child_row; j <= last_child_row; j++)
					{
						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );
 
						if(now_level != _CmpLevel) continue;

						if(fgrid_Yield[j, 0].ToString() != "") continue;
						
						save_row_ct++;  
					} 


				} // end for i
		


				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct *  save_row_ct ];  
				

 

				// 각 행의 변경값 Setting 
				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{   			 

					node = fgrid_Yield.Rows[i].Node;

					if(node.Level != _SGLevel) continue;

					if(node.Children == 0) continue;


					int first_child_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int last_child_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					int move_count = 0;
					int now_level = 0; 

					for(int j = first_child_row; j <= last_child_row; j++)
					{

						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );

						if(now_level != _CmpLevel) continue;

						if(fgrid_Yield[j, 0].ToString() == "M") move_count++;

					}


					if(move_count == 0) continue;
 

					for(int j = first_child_row; j <= last_child_row; j++)
					{
						now_level = Convert.ToInt32(fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );

						if(now_level != _CmpLevel) continue;

						
						if(fgrid_Yield[j, 0].ToString() != "") continue;

						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString(); 
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[j, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString(); 
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;


					} 


				} // end for i
	

 
				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_INFO_COMPONENT_SEQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}



		/// <summary>
		/// Make_SBC_YIELD_VALUE : 
		/// </summary>
		/// <param name="arg_clear_flag"></param>
		/// <returns></returns>
		private bool Make_SBC_YIELD_VALUE(bool arg_clear)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);

				int col_ct = 20; 
				int save_move_ct = 0, save_row_ct = 0, save_delete_ct = 0;  
				int save_history_ct = 0;
				int para_ct = 0; 
 
				
				// from, to cs_size 선택하기 위한 비교 변수
				string before_yield = "", now_yield = "";
				int size_f = -1, size_t = -1;
 
				
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.SAVE_SBC_YIELD_VALUE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_YIELD_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[5] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_SEQ";
				MyOraDB.Parameter_Name[7] = "ARG_TEMPLATE_LEVEL";
				MyOraDB.Parameter_Name[8] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[9] = "ARG_COLOR_CD"; 
				MyOraDB.Parameter_Name[10] = "ARG_CS_SIZE_FROM";
				MyOraDB.Parameter_Name[11] = "ARG_CS_SIZE_TO"; 
				MyOraDB.Parameter_Name[12] = "ARG_SPEC_CD"; 
				MyOraDB.Parameter_Name[13] = "ARG_YIELD_VALUE";
				MyOraDB.Parameter_Name[14] = "ARG_GENDER";
				MyOraDB.Parameter_Name[15] = "ARG_PRESTO_YN";
				MyOraDB.Parameter_Name[16] = "ARG_UPD_FACTORY";
				MyOraDB.Parameter_Name[17] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[18] = "ARG_ACTION_FLAG";
				MyOraDB.Parameter_Name[19] = "ARG_HISTORY_REMARKS";
  

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}

				
				#region 저장 행 수 구하기

				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{ 


					// component semi_good_cd 이동일때,
					// 이전 component semi_good_cd 에 대해서 delete 문 처리하기 위함
					if(fgrid_Yield[i, 0].ToString() == "M"
						&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp ) 
					{
						save_move_ct++;
					}
						
				 
					if(fgrid_Yield[i, 0].ToString() != "" 
						&& ( fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat
						|| fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint ) )
					{ 	 

						
						if(fgrid_Yield[i, 0].ToString() == "D") 
						{
							save_delete_ct++;  
						}
						else
						{

							save_delete_ct++; 


							before_yield = "";
							now_yield = "";

							size_f = -1;
							size_t = -1;


							string size_yn = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString();

							size_f = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;


							// 사이즈 자재일 경우에는 스펙으로 From, To 나눔
							// 사이즈 자재가 아닐 경우에는 채산값으로 From, To 나눔
						  
							if(size_yn == "Y")
							{ 
								while(true)
								{
									CellRange cr_b = fgrid_Yield.GetCellRange(i, size_f);  
									before_yield = cr_b.UserData.ToString(); 

									for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
									{  
										CellRange cr_n = fgrid_Yield.GetCellRange(i, k);  
										now_yield = cr_n.UserData.ToString();

										if(before_yield == now_yield)
										{
											size_t = k;
										}
										else
										{
											break;
										}

									} 

									save_row_ct++; 

									size_f = size_t + 1;

									if(size_f == fgrid_Yield.Cols.Count) break;

								} // end while

							 
							}
							else
							{
							
								while(true)
								{  
									before_yield = fgrid_Yield[i, size_f].ToString();

									for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
									{   
										now_yield = fgrid_Yield[i, k].ToString();

										if(before_yield == now_yield)
										{
											size_t = k;
										}
										else
										{
											break;
										}

									}
 
									save_row_ct++; 

									size_f = size_t + 1;

									if(size_f == fgrid_Yield.Cols.Count) break;

								} // end while
							 

							} 

						} // end ifif(size_yn == "Y")


					} // end if(fgrid_Yield[i, 0].ToString() != "D") 

					


					// 채산 변경값에 따른 히스토리 테이블 저장
					// 변경된 모든 행에 적용
					// 단, 삭제 되는 경우는 히스토리 먼저 저장 후 삭제 처리 되어야 하므로 삭제 부분에 히스토리 자동 추가
					if(fgrid_Yield[i, 0].ToString() != "" && fgrid_Yield[i, 0].ToString() != "D")
					{
						save_history_ct++;
					}



				} // end for i
		

				#endregion


				// 파라미터 값에 저장할 배열 
				// + 1 : Delete 쿼리 추가
				MyOraDB.Parameter_Values  = new string[col_ct * (save_move_ct + save_row_ct + save_delete_ct + save_history_ct)]; 
				 
 
				

				// 각 행의 변경값 Setting 
				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{   			 

					#region ARG_DIVISION = "M"

					// component semi_good_cd 이동일때,
					// 이전 component semi_good_cd 에 대해서 delete 문 처리하기 위함
					if(fgrid_Yield[i, 0].ToString() == "M"
						&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp ) 
					{
						MyOraDB.Parameter_Values[para_ct++] = "M";
						MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();

						// 이전 component semi_good_cd
						CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD); 
						MyOraDB.Parameter_Values[para_ct++] = cr.UserData.ToString();

						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
					}

					#endregion

					#region ARG_DIVISION = "D", "I"

					if(fgrid_Yield[i, 0].ToString() != "" 
						&& ( fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat
						|| fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint ) )
					{ 	 


						if(fgrid_Yield[i, 0].ToString() == "D") 
						{

							MyOraDB.Parameter_Values[para_ct++] = "D";
							MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
							MyOraDB.Parameter_Values[para_ct++] = "D";
							MyOraDB.Parameter_Values[para_ct++] = ""; 


							//if(fgrid_Yield[i, 0].ToString() == "D") continue;

						}
						else //if(fgrid_Yield[i, 0].ToString() != "D") 
						{


							MyOraDB.Parameter_Values[para_ct++] = "D";
							MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = ""; 





							before_yield = "";
							now_yield = "";
						
							size_f = -1;
							size_t = -1;

							// 사이즈 자재일 경우에는 스펙으로 From, To 나눔
							// 사이즈 자재가 아닐 경우에는 채산값으로 From, To 나눔
						  
							size_f = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;

							
							string size_yn = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString();

							if(size_yn == "Y")
							{  
								while(true)
								{
									CellRange cr_b = fgrid_Yield.GetCellRange(i, size_f);  
									before_yield = cr_b.UserData.ToString(); 

									for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
									{  
										CellRange cr_n = fgrid_Yield.GetCellRange(i, k);  
										now_yield = cr_n.UserData.ToString();

										if(before_yield == now_yield)
										{
											size_t = k;
										}
										else
										{
											break;
										}

									}

									MyOraDB.Parameter_Values[para_ct++] = "I";
									MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString(); 

									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[1, size_f].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[1, size_t].ToString();
									MyOraDB.Parameter_Values[para_ct++] = cr_b.UserData.ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, size_f].ToString(); 
								
									MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text;
									MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text;  

									MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
									MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
									MyOraDB.Parameter_Values[para_ct++] = "";
									MyOraDB.Parameter_Values[para_ct++] = "";


									size_f = size_t + 1;

									if(size_f == fgrid_Yield.Cols.Count) break;

								} // end while

  
							}
							else
							{

								while(true)
								{   
									before_yield = fgrid_Yield[i, size_f].ToString();  

									for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
									{   
										now_yield = fgrid_Yield[i, k].ToString();

										if(before_yield == now_yield)
										{
											size_t = k;
										}
										else
										{
											break;
										}

									}

									MyOraDB.Parameter_Values[para_ct++] = "I";
									MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString(); 

									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[1, size_f].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[1, size_t].ToString();
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString(); 
									MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, size_f].ToString(); 
								
									MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text;
									MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text;  
									MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
									MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
									MyOraDB.Parameter_Values[para_ct++] = "";
									MyOraDB.Parameter_Values[para_ct++] = "";


									size_f = size_t + 1;

									if(size_f == fgrid_Yield.Cols.Count) break;

								} // end while 
							}  

						} // end ifif(size_yn == "Y")


					} // end if(fgrid_Yield[i, 0].ToString() != "D") 
 
					#endregion

				}

				#region ARG_DIVISION = "H"

				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{ 
					

					// 채산 변경값에 따른 히스토리 테이블 저장
					// 변경된 모든 행에 적용
					// 단, 삭제 되는 경우는 히스토리 먼저 저장 후 삭제 처리 되어야 하므로 삭제 부분에 히스토리 자동 추가
					if(fgrid_Yield[i, 0].ToString() != "" && fgrid_Yield[i, 0].ToString() != "D")
					{
						MyOraDB.Parameter_Values[para_ct++] = "H";
						MyOraDB.Parameter_Values[para_ct++] = cmb_YieldType.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_ITEM_CD";
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_COLOR_CD"; 
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_FROM";
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_TO"; 
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_SPEC_CD"; 
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_YIELD_VALUE";
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_GENDER";
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_PRESTO_YN";
						MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_UPD_FACTORY";
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; // "ARG_UPD_USER";
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, 0].ToString(); // "ARG_ACTION_FLAG";

						//"ARG_HISTORY_REMARKS"; -> before data
						// semigood + component + template_seq + template_level 
						if(fgrid_Yield[i, 0].ToString() == "M")
						{
							// 이전 component semi_good_cd
							CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD);  

							MyOraDB.Parameter_Values[para_ct++] = cr.UserData.ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString()
								+ fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();

						} 

					}
 

				} // end for i

				#endregion


				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_VALUE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}



		/// <summary>
		/// Make_SBC_YIELD_INFO : 
		/// </summary>
		/// <param name="arg_clear"></param>
		/// <returns></returns>
		private bool Make_SBC_YIELD_INFO(bool arg_clear)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);

				int col_ct = 34; 
				int save_move_ct = 0, save_row_ct = 0;    
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.SAVE_SBC_YIELD_INFO";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[4] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_SEQ";
				MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_LEVEL";
				MyOraDB.Parameter_Name[7] = "ARG_TEMPLATE_TREE_CD";
				MyOraDB.Parameter_Name[8] = "ARG_TEMPLATE_CD";
				MyOraDB.Parameter_Name[9] = "ARG_TEMPLATE_NAME"; 
				MyOraDB.Parameter_Name[10]= "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[11] = "ARG_SPEC_CD"; 
				MyOraDB.Parameter_Name[12] = "ARG_COLOR_CD"; 
				MyOraDB.Parameter_Name[13] = "ARG_COMPONENT_SEQ"; 

				MyOraDB.Parameter_Name[14] = "ARG_STYLE_ITEM_DIV";
				MyOraDB.Parameter_Name[15] = "ARG_COMMON_YN";
				MyOraDB.Parameter_Name[16] = "ARG_SHIP_YN";
				MyOraDB.Parameter_Name[17] = "ARG_PUR_SHIP_YN";
				MyOraDB.Parameter_Name[18] = "ARG_PUR_IMPORT_YN";
				MyOraDB.Parameter_Name[19] = "ARG_PUR_LOCAL_YN";
				MyOraDB.Parameter_Name[20] = "ARG_PROD_YN";
				MyOraDB.Parameter_Name[21] = "ARG_PROD_OP_CD";
				MyOraDB.Parameter_Name[22] = "ARG_PROD_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[23] = "ARG_OUISIDE_IN_YN";
				MyOraDB.Parameter_Name[24] = "ARG_OUTSIDE_OUT_YN";
				MyOraDB.Parameter_Name[25] = "ARG_SHIP_LOSS_RATE";
				MyOraDB.Parameter_Name[26] = "ARG_PUR_LOSS_RATE";
				MyOraDB.Parameter_Name[27] = "ARG_PROD_LOSS_RATE"; 

				MyOraDB.Parameter_Name[28] = "ARG_SRF_NO";
				MyOraDB.Parameter_Name[29] = "ARG_BOM_ID";
				MyOraDB.Parameter_Name[30] = "ARG_SRF_SEQ_MAX";
				MyOraDB.Parameter_Name[31] = "ARG_SRF_CDC_DEV";
				MyOraDB.Parameter_Name[32] = "ARG_UPD_FACTORY";
				MyOraDB.Parameter_Name[33] = "ARG_UPD_USER";  

 
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}

				// 저장 행 수 구하기
				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{ 
 
					// component semi_good_cd 이동일때,
					// 이전 component semi_good_cd 에 대해서 delete 문 처리하기 위함
					if(fgrid_Yield[i, 0].ToString() == "M"
						&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp ) 
					{
						save_move_ct++;
					}


					if(fgrid_Yield[i, 0].ToString() != "" 
						&& ( fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat
						|| fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint ) )
					{ 	 
						save_row_ct++;  
					}

				} // end for i
		


				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct * (save_move_ct + save_row_ct)];  
				


				CellRange cr;


				// 각 행의 변경값 Setting 
				for(int i = fgrid_Yield.Rows.Fixed ; i < fgrid_Yield.Rows.Count; i++)
				{   			 

					#region ARG_DIVISION = "M"

					// component semi_good_cd 이동일때,
					// 이전 component semi_good_cd 에 대해서 delete 문 처리하기 위함
					if(fgrid_Yield[i, 0].ToString() == "M"
						&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp ) 
					{
						MyOraDB.Parameter_Values[para_ct++] = "M"; 
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();

						// 이전 component semi_good_cd
						cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD); 
						MyOraDB.Parameter_Values[para_ct++] = cr.UserData.ToString();

						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
 


					}

					#endregion


					if(fgrid_Yield[i, 0].ToString() != "" 
						&& ( fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat
						|| fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint ) )
					{  
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, 0].ToString().Replace("M", "I");
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";  //template_name 
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString();  



						int component_row = 0;

						for(int a = i; a >= fgrid_Yield.Rows.Fixed; a--)
						{
							if(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
							{
								component_row = a;
								break;
							}
						}

						//cr = fgrid_Yield.GetCellRange(component_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ);    // component_seq
						//MyOraDB.Parameter_Values[para_ct++] = cr.UserData.ToString();

						MyOraDB.Parameter_Values[para_ct++] = fgrid_Yield[component_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();


						// shipping material 정보
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_ITEM_DIV), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMMON_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSHIP_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPUR_SHIP_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPUR_IMPORT_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPUR_LOCAL_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPROD_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPROD_OP_CD), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPROD_SEMI_GOOD_CD), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxOUISIDE_IN_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxOUTSIDE_OUT_YN), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSHIP_LOSS_RATE), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPUR_LOSS_RATE), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxPROD_LOSS_RATE), " " );
		  

						// srf 정보
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX), " " );
						MyOraDB.Parameter_Values[para_ct++] = Empty_Cell(fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV), " " );



						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
 

					}

				} // end for i



				MyOraDB.Add_Modify_Parameter(arg_clear); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}



			

		/// <summary>
		/// Empty_Cell : 
		/// </summary>
		/// <param name="arg_cr"></param>
		/// <param name="arg_ret"></param>
		/// <returns></returns>
		private string Empty_Cell(C1.Win.C1FlexGrid.CellRange arg_cr, string arg_ret)
		{

			
			if ( (arg_cr.Data == null)  || (arg_cr.Data.ToString().Trim() == "") )
			{
				return arg_ret;
			}
			else
			{
				return arg_cr.Data.ToString().Trim();
			}


		}

		
		/// <summary>
		/// SetPrintYield: SetPrintYield
		/// </summary>
		private void  SetPrintYield()
		{
			try
			{   
				//if (CheckFormulaCopy()!= true)  return;

				if (cmb_StyleCd.SelectedIndex  ==- -1) return;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							cmb_Factory.SelectedValue.ToString(),
							cmb_StyleCd.SelectedValue.ToString().Replace("-", ""),
							cmb_StyleCd.Columns[1].Text,
							txt_Presto.Text,
							txt_Gender.Text
						};
						 
				FlexBase.Yield.Pop_Yield_Print  pop_Form = new Yield.Pop_Yield_Print();
				pop_Form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		
		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		
		/// <summary>
		/// Set_MenuItem_Visible : 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
		/// </summary>
		private void Set_MenuItem_Visible()
		{
			if(fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

			int sel_row = fgrid_Yield.Selection.r1; 
			int sel_col = fgrid_Yield.Selection.c1;

			


			switch(Convert.ToInt32(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) )
			{
				case _SGLevel:

					menuitem_AddCmp.Visible = true;
					menuitem_AddTemplate.Visible = false;  
					menuItem_Separator1.Visible = false;
					menuitem_Modify.Visible = false; 
					menuItem_CompDelete.Visible = false;
					menuItem_Copy.Visible = true; 
					//menuItem_Separator3.Visible = false;
					menuItem_AutoReplace.Visible = false;
					menuItem_AllDelete.Visible = false; 

					menuItem_ModifyItem.Visible = false;
					menuItem_ModifySpec.Visible = false;
					menuItem_ModifyColor.Visible = false; 

					menuItem_Separator5.Visible = false;
					menuItem_AddRawMat.Visible = false;
					
					
					break;

				case _CmpLevel:

					menuitem_AddCmp.Visible = false;
					menuitem_AddTemplate.Visible = true;  
					menuItem_Separator1.Visible = false;
					menuitem_Modify.Visible = false;  
					menuItem_CompDelete.Visible = true;
					menuItem_Copy.Visible = true; 
					//menuItem_Separator3.Visible = false;
					menuItem_AutoReplace.Visible = false;
					menuItem_AllDelete.Visible = false; 

					menuItem_ModifyItem.Visible = false;
					menuItem_ModifySpec.Visible = false;
					menuItem_ModifyColor.Visible = false;

					menuItem_Separator5.Visible = false;
					menuItem_AddRawMat.Visible = false;


					break;

				default: 

					menuitem_AddCmp.Visible = false;
					menuitem_AddTemplate.Visible = false;  
					menuItem_Separator1.Visible = false;
					menuitem_Modify.Visible = true;   
					menuItem_CompDelete.Visible = false;
					menuItem_Copy.Visible = false; 


				switch(sel_col)
				{

					case (int)ClassLib.TBSBC_YIELD_INFO.IxTREE:

						menuItem_ModifyItem.Visible = true;
						menuItem_ModifySpec.Visible = false;
						menuItem_ModifyColor.Visible = false;

						break;

					case (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME:

						menuItem_ModifyItem.Visible = false;
						menuItem_ModifySpec.Visible = true;
						menuItem_ModifyColor.Visible = false;

						break;

					case (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME:

						menuItem_ModifyItem.Visible = false;
						menuItem_ModifySpec.Visible = false;
						menuItem_ModifyColor.Visible = true;

						break;

				}
						


					if(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat
						&& fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() == _OnlyRawMat_TemplateLevel )
					{
						//menuItem_Separator3.Visible = true;
						menuItem_AutoReplace.Visible = true;
						menuItem_AllDelete.Visible = true;

						menuItem_Separator5.Visible = true;
						menuItem_AddRawMat.Visible = true;

					}
					else
					{
						//menuItem_Separator3.Visible = false;
						menuItem_AutoReplace.Visible = false;
						menuItem_AllDelete.Visible = false;

						menuItem_ModifyItem.Visible = false;
						menuItem_ModifySpec.Visible = false;
						//menuItem_ModifyColor.Visible = false;

						//menuItem_Separator5.Visible = false;
						menuItem_AddRawMat.Visible = false;

					}
 


					break;

			} // end switch 

		}

  
 
		Pop_Yield_Modify_withSRF pop_form = null;


		/// <summary>
		/// Add_Component : 컴포넌트 및 템플릿 구조 추가
		/// </summary>
		private void Add_Component()
		{
			//행 수정 상태 해제
			fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);
			int sel_row = fgrid_Yield.Selection.r1;

			if(sel_row < fgrid_Yield.Rows.Fixed) return; 

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성
			ClassLib.ComVar.Yield_CurrentDIV division = ClassLib.ComVar.Yield_CurrentDIV.AddCmp;
			string factory = cmb_Factory.SelectedValue.ToString();

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string gender = cmb_StyleCd.Columns[2].Text;
			string model_name = cmb_StyleCd.Columns[4].Text;

			
			string sg_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = "";
			string template_seq = "";
			string template_tree_cd = ""; 
			string yield_type = cmb_YieldType.SelectedValue.ToString();


			string[] pop_parameter = new string[] { factory, style_cd, gender, model_name, sg_cd, component_cd, template_seq, template_tree_cd, yield_type };

  
			//--------------------------------------------------------------------------------------------------
			  
			//Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter);
			//pop_form.ShowDialog(); 

			

			if(pop_form == null)
			{

				pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter); 

				
			}
			else
			{

				pop_form._Parent_Form = this;
				pop_form._Division = division;

				pop_form._Factory = pop_parameter[0];
				pop_form._StyleCd = pop_parameter[1];
				pop_form._Gen = pop_parameter[2];
				pop_form._ModelName = pop_parameter[3]; 
				pop_form._SGCd = pop_parameter[4];
				pop_form._ComponentCd = pop_parameter[5];
				pop_form._TemplateSeq = pop_parameter[6];
				pop_form._TemplateTreeCd = pop_parameter[7];
				pop_form._YieldType = pop_parameter[8];  

				pop_form.Init_Form();
 

			}
			
			pop_form.Show();

			

			

			//------------------------------------------------------------------------- 


//			if(pop_form._Cancel_Flag) return;

//			DataTable dt_yield = pop_form._DT_Return;
//			if(dt_yield == null || dt_yield.Rows.Count == 0) return;
//
//			//pop_form.Dispose(); 
//			
//			
			#region 메모리 정리

			ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
			ClassLib.MemoryManagement.FlushMemory();

			#endregion


//			// 그리드에 추가된 행 표시
//			Apply_Grid(dt_yield, sel_row); 
//


		}



		/// <summary>
		/// Add_Template : 템플릿 구조 추가
		/// </summary>
		private void Add_Template()
		{
			//행 수정 상태 해제
			fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);
			int sel_row = fgrid_Yield.Selection.r1;

			if(sel_row < fgrid_Yield.Rows.Fixed) return; 

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성
			ClassLib.ComVar.Yield_CurrentDIV division = ClassLib.ComVar.Yield_CurrentDIV.AddTemplate; 
			string factory = cmb_Factory.SelectedValue.ToString();

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string gender = cmb_StyleCd.Columns[2].Text;
			string model_name = cmb_StyleCd.Columns[4].Text;

			
			string sg_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
			string template_seq = "";
			string template_tree_cd = ""; 
			string yield_type = cmb_YieldType.SelectedValue.ToString();


			string[] pop_parameter = new string[] { factory, style_cd, gender, model_name, sg_cd, component_cd, template_seq, template_tree_cd, yield_type };

  
			//--------------------------------------------------------------------------------------------------
			  
//			Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter);
//			pop_form.ShowDialog();  


			if(pop_form == null)
			{

				pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter); 
				
			}
			else
			{

				pop_form._Parent_Form = this;
				pop_form._Division = division;

				pop_form._Factory = pop_parameter[0];
				pop_form._StyleCd = pop_parameter[1];
				pop_form._Gen = pop_parameter[2];
				pop_form._ModelName = pop_parameter[3]; 
				pop_form._SGCd = pop_parameter[4];
				pop_form._ComponentCd = pop_parameter[5];
				pop_form._TemplateSeq = pop_parameter[6];
				pop_form._TemplateTreeCd = pop_parameter[7];
				pop_form._YieldType = pop_parameter[8];  

				pop_form.Init_Form();
 

			}
			
			pop_form.Show();



			//------------------------------------------------------------------------- 


//			if(pop_form._Cancel_Flag) return;
//
//			DataTable dt_yield = pop_form._DT_Return;
//			if(dt_yield == null || dt_yield.Rows.Count == 0) return;
//
//			pop_form.Dispose(); 
//
//			
			#region 메모리 정리

			ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
			ClassLib.MemoryManagement.FlushMemory();

			#endregion
//
//
//			// 그리드에 추가된 행 표시
//			Apply_Grid(dt_yield, sel_row); 


		}



		/// <summary>
		/// Modify_Template : 템플릿 구조 채산값 수정
		/// </summary>
		private void Modify_Template()
		{ 

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성
			int sel_row = fgrid_Yield.Selection.r1;

			ClassLib.ComVar.Yield_CurrentDIV division = ClassLib.ComVar.Yield_CurrentDIV.Modify; 
			string factory = cmb_Factory.SelectedValue.ToString();

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string gender = cmb_StyleCd.Columns[2].Text;
			string model_name = cmb_StyleCd.Columns[4].Text;

			
			string sg_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
			string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
			string template_tree_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD].ToString();
			string yield_type = cmb_YieldType.SelectedValue.ToString();


			string[] pop_parameter = new string[] { factory, style_cd, gender, model_name, sg_cd, component_cd, template_seq, template_tree_cd, yield_type };
			//--------------------------------------------------------------------------------------------------
			  
//			FlexBase.Yield.Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter); 
//			pop_form.ShowDialog();  
//  
//
//			if(pop_form._Cancel_Flag) return;
//
//
//			DataTable dt_yield = pop_form._DT_Return;
//			if(dt_yield == null || dt_yield.Rows.Count == 0) return;
//
//			pop_form.Dispose();


			if(pop_form == null)
			{

				pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter); 
				
			}
			else
			{

				pop_form._Parent_Form = this;
				pop_form._Division = division;

				pop_form._Factory = pop_parameter[0];
				pop_form._StyleCd = pop_parameter[1];
				pop_form._Gen = pop_parameter[2];
				pop_form._ModelName = pop_parameter[3]; 
				pop_form._SGCd = pop_parameter[4];
				pop_form._ComponentCd = pop_parameter[5];
				pop_form._TemplateSeq = pop_parameter[6];
				pop_form._TemplateTreeCd = pop_parameter[7];
				pop_form._YieldType = pop_parameter[8];  

				pop_form.Init_Form();
 

			}
			
			pop_form.Show();


			#region 메모리 정리

			ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
			ClassLib.MemoryManagement.FlushMemory();

			#endregion


//			// 그리드에 추가된 행 표시
//			Modify_Grid(dt_yield, sel_row); 




		}

 

		/// <summary>
		/// Delete_Component : 
		/// </summary>
		private void Delete_Component()
		{

			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this); 

			if(message_result == DialogResult.No) return; 
 

			// delete flag 표시
			Delete_Item();


			string factory = cmb_Factory.SelectedValue.ToString(); 
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 
			string semi_good_cd = fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = fgrid_Yield[fgrid_Yield.Selection.r1, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
			
			bool save_flag = Delete_Component(factory, style_cd, semi_good_cd, component_cd);

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete, this); 
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);

			}


			// delete 표시된 행 삭제 처리
			Remove_Delete_Row();


		}



		



		/// <summary>
		/// Remove_Delete_Row : delete 표시된 행 삭제 처리
		/// </summary>
		private void Remove_Delete_Row()
		{

			
			int sel_row = fgrid_Yield.Selection.r1;
			int start_row = -1, end_row = -1; 




			string type_division = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString();


			if(type_division == _TypeCmp)
			{

				C1.Win.C1FlexGrid.Node node = null;

				start_row = sel_row;

				node = fgrid_Yield.Rows[sel_row].Node;

				if(node.Children == 0)
				{ 
					end_row = sel_row;
				}
				else
				{  
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

					while(true)
					{
						node = fgrid_Yield.Rows[end_row].Node;
					
						if(node.Children == 0) break;

						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					} // end while 

				} // end if 


			}
			else
			{

				string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
				string now_template_seq = "";

				for(int i = sel_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						start_row = i + 1;
						break;
					}
				}
 
				for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						end_row = i - 1;
						break;
					}
				}


				start_row = (start_row == -1) ? sel_row : start_row;
				end_row = (end_row == -1) ? sel_row : end_row;


			} 



			for(int i = end_row; i >= start_row; i--)
			{
				fgrid_Yield.Rows.Remove(i); 
			} // end for i


		}



		/// <summary> 
		/// Delete_Item : 컴포넌트 및 템플릿 구조 삭제 - 하위 레벨까지 삭제 표시
		/// </summary>
		private void Delete_Item()
		{ 
			int sel_row = fgrid_Yield.Selection.r1;
			int start_row = -1, end_row = -1; 

 
 
			string type_division = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString();


			if(type_division == _TypeSG || type_division == _TypeCmp)
			{

				C1.Win.C1FlexGrid.Node node = null;

				start_row = sel_row;

				node = fgrid_Yield.Rows[sel_row].Node;

				if(node.Children == 0)
				{ 
					end_row = sel_row;
				}
				else
				{  
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

					while(true)
					{
						node = fgrid_Yield.Rows[end_row].Node;
					
						if(node.Children == 0) break;

						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					} // end while 

				} // end if 


			}
			else
			{

				string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
				string now_template_seq = "";

				for(int i = sel_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						start_row = i + 1;
						break;
					}
				}
 
				for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						end_row = i - 1;
						break;
					}
				}


				start_row = (start_row == -1) ? sel_row : start_row;
				end_row = (end_row == -1) ? sel_row : end_row;


			}




			for(int i = end_row; i >= start_row; i--)
			{
				switch(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION].ToString() )
				{
					case "I":
	
						fgrid_Yield.Rows.Remove(i);

						break;

					default :

						fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "D"; 

						break;

				} // end switch
			} // end for i

					


		}



		/// <summary>
		/// Cancel_Flag : I/D/U division cancel 
		/// </summary>
		private void Cancel_Flag()
		{


			int sel_row = fgrid_Yield.Selection.r1;
			int start_row = -1, end_row = -1; 




			string type_division = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString();


			if(type_division == _TypeSG || type_division == _TypeCmp)
			{

				C1.Win.C1FlexGrid.Node node = null;

				start_row = sel_row;

				node = fgrid_Yield.Rows[sel_row].Node;

				if(node.Children == 0)
				{ 
					end_row = sel_row;
				}
				else
				{  
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

					while(true)
					{
						node = fgrid_Yield.Rows[end_row].Node;
					
						if(node.Children == 0) break;

						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					} // end while 

				} // end if 


			}
			else
			{

				string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
				string now_template_seq = "";

				for(int i = sel_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						start_row = i + 1;
						break;
					}
				}
 
				for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
				{

					now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

					if(template_seq != now_template_seq)
					{
						end_row = i - 1;
						break;
					}
				}


				start_row = (start_row == -1) ? sel_row : start_row;
				end_row = (end_row == -1) ? sel_row : end_row;


			}

			




			for(int i = end_row; i >= start_row; i--)
			{
				switch(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION].ToString() )
				{
					case "I":
	
						fgrid_Yield.Rows.Remove(i);

						break;

					case "D":

						fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = ""; 

						break;

				} // end switch
			} // end for i




		}




		private int _Component_Seq_Range = 100000;


 
		/// <summary>
		/// Apply_Grid : 그리드에 추가된 행 표시, 채산값 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_row"></param>
		public void Apply_Grid(DataTable arg_dt, int arg_row)
		{
 


			int component_ct = 0;



			C1.Win.C1FlexGrid.Node node = fgrid_Yield.Rows[arg_row].Node; 

			


			node.AddNode(NodeTypeEnum.LastChild, ""); 



			int component_row = 0;

			for(int a = node.GetNode(NodeTypeEnum.LastChild).Row.Index - 1; a >= fgrid_Yield.Rows.Fixed; a--)
			{
				if(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
				{
					component_row = a;

					//if(fgrid_Yield[a, 0].ToString() == "I")  component_ct++;
					break;
				}
			}



			string up_component_seq = "";
			string new_component_seq = "";

			if(component_row == 0)
			{ 
				new_component_seq = _Component_Seq_Range.ToString();

			}
			else
			{
				up_component_seq = fgrid_Yield[component_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString(); 
				new_component_seq = Convert.ToString(Convert.ToInt64( up_component_seq ) + _Component_Seq_Range); 
			}

			






			int node_count = 0;

			if(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat  
				|| arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint )
			{
				node_count = node.Children;
			} 
			

			int current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 



			string before_item = "", now_item = "";
			int add_row_count = 0;




			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString();

				if(before_item == now_item) continue;

				//-----------------------------------------------------------------------------
				// 추가 데이터 세팅
				// first row : AddNode (because find current(insert) row)
				// another row : InsertNode
				if(i != 0)
				{
					add_row_count++;

					fgrid_Yield.Rows.InsertNode(current_row + add_row_count, Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) );
 




					//-----------------------------------------------------------------------------
					// srf 에서 batch 처리 했을 경우,
					// component 리스트가 행 사이에 계속 추가되므로 component seq 증가 작업해야함
					for(int a = current_row + add_row_count - 1; a >= fgrid_Yield.Rows.Fixed; a--)
					{
						if(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
						{
							component_row = a;
							
							break;
						}
					}
 
 
					up_component_seq = fgrid_Yield[component_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString(); 
					new_component_seq = Convert.ToString(Convert.ToInt64( up_component_seq ) + _Component_Seq_Range ); 
 
					//-----------------------------------------------------------------------------





					// 임가공 구조이지만, component 처음 추가시
					if( arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeJoint 
						&& node_count == 0)
					{
						node_count++;
					}

					// Raw Material 만 있는 구조일때 
					if( arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeMat 
						&& arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() == _OnlyRawMat_TemplateLevel)
					{
						node_count++;
					} 
 
				}

  
				fgrid_Yield[current_row + add_row_count, 0] = "I";

				for(int j = 1; j < arg_dt.Columns.Count; j++)
				{
					fgrid_Yield[current_row + add_row_count, j] = arg_dt.Rows[i].ItemArray[j].ToString();
				}


				CellRange cr;
				cr = fgrid_Yield.GetCellRange(current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ);


				if(fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
				{
					fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = new_component_seq.ToString();
				}
				else
				{
					//fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = node_count.ToString();  
				}

				cr.UserData = new_component_seq.ToString();
				


				//----------------------------------------------------------------------------- 
				// 이미지 표시  
				Display_Type_Image(current_row + add_row_count); 

				// 채산값 표시
				Display_YieldValue(arg_dt, current_row + add_row_count); 

				// 사이즈 자재 표시
				Display_Size_Material(current_row + add_row_count);

				
				//-----------------------------------------------------------------------------

 

				if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
				{
					component_ct++;
				} 



				


				if(_SRFNo.Trim().Equals("") )
				{
					_SRFNo = fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO].ToString().Trim();
				}

				if(_BOMID.Trim().Equals("") )
				{
					_BOMID = fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID].ToString().Trim();
				}





				before_item = now_item;


 
			} // end for i
 



			fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ImageAndText = true;
			//fgrid_Yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ImageMap = _Imgmap; 

			//fgrid_Yield.TopRow = arg_row;



			//-----------------------------------------------------------------------------
			int start_row = current_row + add_row_count; 
			int cal_row = 0;
			int max_template_seq = 0;  
			int run_ct = 0;

			component_ct = (component_ct == 0) ? 1 : component_ct;
 
			while(true)
			{

				if(run_ct == component_ct) break;


				for(int i = start_row; i >= fgrid_Yield.Rows.Fixed; i--)
				{
					if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
					{
						cal_row = i;
						max_template_seq = 0;
						break;
					}

					//if(fgrid_Yield[i, 0].ToString() != "I")




					if(Convert.ToInt32(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) > _CmpLevel)
					{

						if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] != null 
							&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString().Trim() != "")
						{

							cal_row = i;
							max_template_seq = Convert.ToInt32(fgrid_Yield[cal_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() );
							break;
						}


					} // end if



				}



				for(int i = cal_row + 1; i < fgrid_Yield.Rows.Count; i++)
				{
					if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp) break;
					if(fgrid_Yield[i, 0].ToString() != "I") break;

					// first new material
					if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] != null 
						&& fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString().Trim() != "") continue;

					if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() == _OnlyRawMat_TemplateLevel)
					{
						max_template_seq++; 
					}

					fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = Convert.ToString(max_template_seq);


				}
 


				start_row = cal_row - 1; 
				run_ct++; 
				max_template_seq = 0;



			} // end while



			//			for(int i = current_row + add_row_count; i >= fgrid_Yield.Rows.Fixed; i--)
			//			{
			//				if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
			//				{
			//					cal_row = i;
			//					max_template_seq = 0;
			//					break;
			//				}
			//
			//				if(fgrid_Yield[i, 0].ToString() != "I")
			//				{
			//					cal_row = i;
			//					max_template_seq = Convert.ToInt32(fgrid_Yield[cal_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() );
			//					break;
			//				}
			//			}
			//
			//		    
			//
			//			for(int i = cal_row + 1; i < fgrid_Yield.Rows.Count; i++)
			//			{
			//				if(fgrid_Yield[i, 0].ToString() != "I") break;
			//
			//				if(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() == _OnlyRawMat_TemplateLevel)
			//				{
			//					max_template_seq++; 
			//				}
			//
			//				fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = Convert.ToString(max_template_seq);
			//
			//
			//			}

 

			//----------------------------------------------------------------------------- 



			fgrid_Yield.Tree.Show(_SGLevel);
			fgrid_Yield.Tree.Show(_CmpLevel);



			fgrid_Yield.Rows[component_row].Node.Collapsed = false;
			fgrid_Yield.TopRow = component_row;




		}
 


		
		/// <summary>
		/// Modify_Grid : 그리드에 수정된 채산값 표시
		/// </summary>
		/// <param name="arg_dt_yieldtail"></param>
		/// <param name="arg_row"></param>
		public void Modify_Grid(DataTable arg_dt, int arg_row)
		{
			int start_row = arg_row;
			int end_row = arg_row;
  
			//------------------------------------------------------------------------------------------------------
			// get start_row, end_row
			string template_seq = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
			string now_template_seq = ""; 


			for(int i = arg_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
			{
				now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();

				if(template_seq == now_template_seq)
				{
					start_row = i;
				}
				else
				{
					break;
				}

			} // end for i
 


			for(int i = arg_row + 1; i < fgrid_Yield.Rows.Count; i++)
			{
				now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();

				if(template_seq == now_template_seq)
				{
					end_row = i;
				}
				else
				{
					break;
				}

			} // end for i


			//------------------------------------------------------------------------------------------------------
			// display modify yield value data 

			int component_row = 0;

			for(int a = start_row; a >= fgrid_Yield.Rows.Fixed; a--)
			{
				if(fgrid_Yield[a, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString() == _TypeCmp)
				{
					component_row = a;
					break;
				}
			}

			string up_component_seq = fgrid_Yield[component_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString(); 



			for(int i = start_row; i <= end_row; i++)
			{  
				fgrid_Yield[i, 0] = "U";

				Display_YieldValue(arg_dt, i); 
 
			} // end for i 


			//fgrid_Yield.TopRow = arg_row;

			 

		}




		/// <summary>
		/// 채산값 표시
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_dt"></param>
		private void Display_YieldValue(DataTable arg_dt, int arg_row)
		{ 
			string templatelevel = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString(); 
			string itemcd = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString(); 
			string speccd = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString(); 
			string colorcd = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString(); 

			string condition = "";

			if(fgrid_Yield[arg_row, 0].ToString() == "I")
			{ 
				condition =             "TEMPLATE_LEVEL = '" + templatelevel + "'"  
					+ " AND " + "ITEM_CD        = '" + itemcd + "'"
					+ " AND " + "SPEC_CD	    = '" + speccd + "'"
					+ " AND " + "COLOR_CD       = '" + colorcd + "'" ;

			}
			else if(fgrid_Yield[arg_row, 0].ToString() == "U")
			{
				condition = "TEMPLATE_LEVEL = '" + templatelevel + "'" ;
			}

			

			DataRow[] findrow = arg_dt.Select(condition); 

			// no exist row || only component row
			if(findrow.Length == 0 || findrow.Length == 1) return;



			DataRow datarow_yieldvalue = findrow[0];
			DataRow datarow_speccd = findrow[1];
			DataRow datarow_specname = findrow[2]; 

			int add_col = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; 


			//-------------------------------------------------------------------------------------
			// change item code, item name, tree description
			//-------------------------------------------------------------------------------------
			if(templatelevel != "0")
			{
				fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE] 
					= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME].ToString(); 

				Display_Type_Image(arg_row); 

			} 
			


			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ToString(); 




			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString();

			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME].ToString(); 
			//-------------------------------------------------------------------------------------

 
			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString();

			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME].ToString();



			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO].ToString();

			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO].ToString();





			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString();

			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME].ToString();


			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxUNIT].ToString();


			fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN] 
				= datarow_yieldvalue[(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString();




			for(int i = add_col; i < arg_dt.Columns.Count; i++) 
			{
				fgrid_Yield[arg_row, i] = datarow_yieldvalue[i].ToString();
 
				// user data -> spec code 값
				CellRange cr = fgrid_Yield.GetCellRange(arg_row, i); 
				cr.UserData = datarow_speccd[i].ToString(); 
							
			}  


			// 사이즈 자재, spec code 별 색깔 표시
			Display_Size_Material(arg_row);

			 
		}


 
		/// <summary>
		/// Display_Size_Material : 사이즈 자재 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Size_Material(int arg_row)
		{
			string before_spec = "", now_spec = "";
			int size_f = -1, size_t = -1;


			_Color_SizeSpecCurrent = _Color_SizeSpecEven;

			if(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN] != null
				&& fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString() == "Y")
			{

				//				// spec 세팅
				//				fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = _SizeSpecCd;
				//				fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = _SizeSpecName; 
				 
				
				for(int i = 1; i < (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i++)
				{
					fgrid_Yield.GetCellRange(arg_row, i).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
				}
				
				 


				size_f = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;

				CellRange cr = fgrid_Yield.GetCellRange(arg_row, size_f); 
				if(fgrid_Yield[arg_row, size_f] == null || cr.UserData == null) return;

				while(true)
				{
					CellRange cr_b = fgrid_Yield.GetCellRange(arg_row, size_f);  
					before_spec = (cr_b.UserData == null ) ? "" : cr_b.UserData.ToString(); 

					for(int k = size_f; k < fgrid_Yield.Cols.Count; k++)
					{  
						CellRange cr_n = fgrid_Yield.GetCellRange(arg_row, k);  
						now_spec = (cr_n.UserData == null ) ? "" : cr_n.UserData.ToString(); 

						if(before_spec == now_spec)
						{
							size_t = k;
						}
						else
						{
							break;
						}

					}
 


					//SPEC CODE 별 색깔 표시
					if(_Color_SizeSpecCurrent.Equals(_Color_SizeSpecOdd) )
					{
						_Color_SizeSpecCurrent = _Color_SizeSpecEven;
					}
					else
					{
						_Color_SizeSpecCurrent = _Color_SizeSpecOdd;
					}


					for(int i = size_f; i <= size_t; i++)
					{
						fgrid_Yield.GetCellRange(arg_row, i).StyleNew.BackColor = _Color_SizeSpecCurrent;
					}
 


					size_f = size_t + 1;

					if(size_f == fgrid_Yield.Cols.Count) break;

				} // end while

				 



			}

 

		}


		/// <summary>
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{
 
			 
			string tree_desc = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ToString();
			string type = fgrid_Yield[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString();
			
			 

			if(_Imgmap.ContainsKey(tree_desc) ) return;
			


			switch(type)
			{ 		
				case _TypeSG:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_SG]);  
					break;

				case _TypeCmp:  
					fgrid_Yield.GetCellRange(arg_row, 1, arg_row, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:

					_Imgmap.Add(tree_desc, img_Type.Images[_IxImage_Joint]); 
					break;
 
			} // end switch

			 


		}




		/// <summary>
		/// Copy_Yield : 채산 복사 기능
		/// </summary>
		private void Copy_Yield()
		{
			//행 수정 상태 해제
			fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);
			int sel_row = fgrid_Yield.Selection.r1;

			if(sel_row < fgrid_Yield.Rows.Fixed) return; 

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성 
			string factory = cmb_Factory.SelectedValue.ToString();
			string factory_name = cmb_Factory.Columns[1].Text;

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString();
			string style_name = cmb_StyleCd.Columns[1].Text;
			string gender = cmb_StyleCd.Columns[2].Text;
			string presto = cmb_StyleCd.Columns[3].Text; 
			
			string sg_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();  


			string[] pop_parameter = new string[] { factory, factory_name, style_cd, style_name, gender, presto, sg_cd, component_cd };

  
			//-------------------------------------------------------------------------------------------------- 
			Pop_Yield_Copy pop_form = new Pop_Yield_Copy(pop_parameter);
			pop_form.ShowDialog();  

			pop_form.Dispose();

 
		}


		/// <summary>
		/// Copy_Yield_Style : 스타일별 채산 복사
		/// </summary>
		private void Copy_Yield_Style()
		{
			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성 
			string factory = cmb_Factory.SelectedValue.ToString();
			string factory_name = cmb_Factory.Columns[1].Text;

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString();
			string style_name = cmb_StyleCd.Columns[1].Text;
			string gender = cmb_StyleCd.Columns[2].Text;
			string presto = cmb_StyleCd.Columns[3].Text; 
			
			string sg_cd = "";
			string component_cd = "";  


			string[] pop_parameter = new string[] { factory, factory_name, style_cd, style_name, gender, presto, sg_cd, component_cd };

  
			//-------------------------------------------------------------------------------------------------- 
			Pop_Yield_Copy pop_form = new Pop_Yield_Copy(pop_parameter);
			pop_form.ShowDialog();  

			pop_form.Dispose();

 
		}



		/// <summary>
		/// View_Yield_History : History 조회
		/// </summary>
		private void View_Yield_History()
		{
			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
 
			//popup 창 파라미터 구성 
			string factory = cmb_Factory.SelectedValue.ToString(); 
			string style_cd = cmb_StyleCd.SelectedValue.ToString(); 
			string yield_type = cmb_YieldType.SelectedValue.ToString();
			   
			Pop_BC_Yield_History pop_form = new Pop_BC_Yield_History(factory, style_cd, yield_type);
			pop_form.MdiParent = ClassLib.ComVar.MDI_Parent;
			pop_form.Show();  
		}


		/// <summary>
		/// item/spec/color 리스트로 채산 검증
		/// </summary>
		private void Yield_Item_Check()
		{
			
			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldType.SelectedIndex == -1) return;

			string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Yield_Item_Check");
				
			string sPara  = " /rp ";


			sPara += "'" + cmb_Factory.SelectedValue.ToString() + "' ";
			sPara += "'" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + "' ";
			sPara += "'" + cmb_YieldType.SelectedValue.ToString() + "' "; 

			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
			MyReport.Text = "Yield Item Check";
			MyReport.Show();


		}



		/// <summary>
		/// Yield_Inspection : 채산 검증
		/// </summary>
		private void Yield_Inspection()
		{

			string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, ""); 
			string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, "");

			Pop_Yield_Inspection pop_form = new Pop_Yield_Inspection(factory, style_cd);
			pop_form.Show();  

		}


		/// <summary>
		/// Confirm_Yield_Status : Yield Status 수정
		/// </summary>
		private void Confirm_Yield_Status()
		{
			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldStatus.SelectedIndex == -1) return;
 
			
			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 

			if(message_result == DialogResult.No) return; 
 



			string factory = cmb_Factory.SelectedValue.ToString(); 
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 
			string yield_status = cmb_YieldStatus.SelectedValue.ToString();
			
			bool save_flag = Save_Yield_Status(factory, style_cd, yield_status);

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
			}


		}




		/// <summary>
		/// Keep_ComponentSeq : Component Sequence 일괄 정리
		/// </summary>
		private void Keep_ComponentSeq()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
 

			string factory = cmb_Factory.SelectedValue.ToString(); 
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 


			bool run_flag = Run_Keep_ComponentSeq(factory, style_cd);

			if(!run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
			}

		}




		#region 원자재 일괄 수정, 삽입, 삭제 처리

		/// <summary>
		/// Replace_AutoMaterial : 원자재 일괄 수정 처리
		/// factory, model_cd, gender, semi_good_cd, component_cd, item_cd 일치하는 스타일 리스트 추출해서 일괄 수정 처리
		/// </summary>
		private void Replace_AutoMaterial()
		{ 
			Change_Material("U");
		}


		/// <summary>
		/// All_Insert_Material : 원자재 일괄 삽입 처리
		/// </summary>
		private void All_Insert_Material()
		{
			Change_Material("I");
		}


		/// <summary>
		/// All_Delete_Material : 원자재 일괄 삭제 처리
		/// </summary>
		private void All_Delete_Material()
		{
			Change_Material("D");
		}


		/// <summary>
		/// Change_Material : 
		/// </summary>
		/// <param name="arg_division"></param>
		private void Change_Material(string arg_division)
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldType.SelectedIndex == -1) return;




			//행 수정 상태 해제
			fgrid_Yield.Select(fgrid_Yield.Selection.r1, 0, fgrid_Yield.Selection.r1, fgrid_Yield.Cols.Count - 1, false);
			int sel_row = fgrid_Yield.Selection.r1;

			if(sel_row < fgrid_Yield.Rows.Fixed) return; 

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성 
			string factory = cmb_Factory.SelectedValue.ToString(); 

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 
			string style_name = cmb_StyleCd.Columns[1].Text;
			string model_name = cmb_StyleCd.Columns[4].Text; 
			
			string sg_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
			string component_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();  
			string item_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString();  
			string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();  
			string sizeyn = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString(); 
			string spec_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString();
			string color_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString();
			string unit = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxUNIT].ToString(); 
			string item_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ToString();
			string spec_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME].ToString();
			string color_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME].ToString();

			string yield_type = cmb_YieldType.SelectedValue.ToString();  

			string[] pop_parameter = new string[] { arg_division, 
													  factory, 
													  style_cd, 
													  style_name, 
													  model_name, 
													  sg_cd, 
													  component_cd, 
													  item_cd, 
													  template_seq, 
													  yield_type, 
													  unit, 
													  sizeyn, 
													  spec_cd, 
													  color_cd,
													  item_name,
													  spec_name, 
													  color_name };
 
			//-------------------------------------------------------------------------------------------------- 
			Pop_Yield_Replace_Item pop_form = new Pop_Yield_Replace_Item(pop_parameter);
			pop_form.ShowDialog();  

			pop_form.Dispose();
		}


		#endregion


		Pop_Item_List pop_item_form = null;


		private void Show_Item_Popup(string arg_select)
		{


			if(fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

			
			int sel_row = fgrid_Yield.Selection.r1;

			int level = Convert.ToInt32(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() );
			string template_tree_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD].ToString(); 
			string size_yn = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString();

			if(level <= _CmpLevel) return;
			
			//if(template_tree_cd != _OnlyRawMat_TemplateCd) return;

			if(arg_select == "Spec")
			{
				if(size_yn == "Y") 
				{
					ClassLib.ComFunction.User_Message("Size item not change specification.", "Modify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}


			string item_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString(); 
			string item_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE].ToString();
			string spec_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString();
			string spec_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME].ToString();
			string color_cd = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString();
			string color_name = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME].ToString();
			string unit = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxUNIT].ToString();  

			COM.ComVar.Parameter_PopUp = new string[] { arg_select };

//			FlexBase.MaterialBase.Pop_Item_List pop_form 
//				= new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);
//			pop_form.ShowDialog(); 
//			 
//
//
//			Apply_Modify_Grid(arg_select, size_yn_new);



			if(pop_item_form == null)
			{

				pop_item_form = new Pop_Item_List(this, item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);
				 
			}
			else
			{
  
				pop_item_form._Parent_Form_WithExcel = this;
				pop_item_form._ItemCd = item_cd;
				pop_item_form._ItemName = item_name;
				pop_item_form._SpecCd = spec_cd;
				pop_item_form._SpecName = spec_name; 
				pop_item_form._ColorCd = color_cd;
				pop_item_form._ColorName = color_name;
				pop_item_form._Unit = unit;
				pop_item_form._SizeYN = size_yn;  

				pop_item_form.Init_Form();
 
 

			}
			
			pop_item_form.Show();



		}


		public void Apply_Modify_Grid(string arg_select, string arg_size_yn)
		{

			int sel_row = fgrid_Yield.Selection.r1;

 
			string size_yn = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString();
			string size_yn_new = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7]) ? "Y" : "N";

			//if(item_cd != COM.ComVar.Parameter_PopUp[0] && size_yn_new == "Y")
			if( (size_yn == "Y" || size_yn_new == "Y") && arg_select == "Item")
			{
				ClassLib.ComFunction.User_Message("Not Changed size item.", "Modify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}



			// item
			if(arg_select == "Item")
			{
				if(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString() != COM.ComVar.Parameter_PopUp[0])
				{

					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] = COM.ComVar.Parameter_PopUp[0];
					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] = COM.ComVar.Parameter_PopUp[1];
					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE] = COM.ComVar.Parameter_PopUp[1];
					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] = COM.ComVar.Parameter_PopUp[6];
				}
			}
 

			// spec
			if(arg_select == "Item" || arg_select == "Spec")
			{
				//if(arg_size_yn == "N")
				if(! Convert.ToBoolean(arg_size_yn) )
				{

					if(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ToString() != COM.ComVar.Parameter_PopUp[2]) 
					{

						fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = COM.ComVar.Parameter_PopUp[2];
						fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = COM.ComVar.Parameter_PopUp[3];

						CellRange cr = fgrid_Yield.GetCellRange(sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START, sel_row, fgrid_Yield.Cols.Count - 1);
						cr.UserData = COM.ComVar.Parameter_PopUp[2];
					}

				}	
			}
 

			// color
			if(arg_select == "Item" || arg_select == "Color")
			{
				if(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ToString() != COM.ComVar.Parameter_PopUp[4])
				{

					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] = COM.ComVar.Parameter_PopUp[4];
					fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] = COM.ComVar.Parameter_PopUp[5];
				}
			}


			fgrid_Yield.Update_Row();

			Display_Type_Image(sel_row);

		}





		/// <summary>
		/// Add_Raw_Material : Add RawMaterial 
		/// </summary>
		private void Add_Raw_Material()
		{

			int sel_row = fgrid_Yield.Selection.r1;

			//C1.Win.C1FlexGrid.Node node_component = fgrid_Yield.Rows[sel_row].Node.GetNode(NodeTypeEnum.Parent);

			string sel_component = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();
			string now_component = "";

			int insert_row = -1;

			for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
			{
				now_component = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();

				if(sel_component != now_component)
				{
					insert_row = i - 1;
					break;
				}
			}


			insert_row = (insert_row == -1) ? fgrid_Yield.Rows.Count - 1 : insert_row;

			int new_template_seq = Convert.ToInt32(fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString().Trim()) + 1; 
			int new_level = Convert.ToInt32(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString().Trim());

            

			fgrid_Yield.Rows.InsertNode(insert_row + 1, new_level);



			string copy_clip = fgrid_Yield.GetCellRange(sel_row, 0, sel_row, fgrid_Yield.Cols.Count - 1).Clip; 
	 
			 
			fgrid_Yield.Select(insert_row + 1, 0, insert_row + 1, fgrid_Yield.Cols.Count - 1, false);
			fgrid_Yield.Clip = copy_clip;
			fgrid_Yield.Select(insert_row + 1, 0, false);
			


			fgrid_Yield[insert_row + 1, 0] = "I";
			fgrid_Yield[insert_row + 1, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = new_template_seq.ToString();


			string source_spec;
			CellRange target_cr;

			for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
			{
				source_spec = fgrid_Yield.GetCellRange(sel_row, i).UserData.ToString();

				target_cr = fgrid_Yield.GetCellRange(insert_row + 1, i);
				target_cr.UserData = source_spec; 

			}
 

			// 사이즈 자재 표시
			Display_Size_Material(insert_row + 1);
 

		}


		private void Add_Joint_Material()
		{

			int sel_row = fgrid_Yield.Selection.r1;

			//C1.Win.C1FlexGrid.Node node_component = fgrid_Yield.Rows[sel_row].Node.GetNode(NodeTypeEnum.Parent);

			string sel_component = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();
			string now_component = "";


			int insert_row = -1;

			for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
			{
				now_component = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();

				if(sel_component != now_component)
				{
					insert_row = i - 1;
					break;
				}
			}


			insert_row = (insert_row == -1) ? fgrid_Yield.Rows.Count - 1 : insert_row;

			
			int new_template_seq = Convert.ToInt32(fgrid_Yield[insert_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString().Trim()) + 1; 


			//--------------------------------------------------------------------------------------------------------
			// 복사 할 임가공 구조 시작 ~ 끝 계산
			//--------------------------------------------------------------------------------------------------------
			string template_seq = fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();  
			string now_template_seq = "";
			int start_row = -1;
			int end_row = -1;
											

			for(int i = sel_row - 1; i >= fgrid_Yield.Rows.Fixed; i--)
			{

				now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

				if(template_seq != now_template_seq)
				{
					start_row = i + 1;
					break;
				}
			}
 
			for(int i = sel_row + 1; i < fgrid_Yield.Rows.Count; i++)
			{

				now_template_seq = fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();	

				if(template_seq != now_template_seq)
				{
					end_row = i - 1;
					break;
				}
			}


			start_row = (start_row == -1) ? sel_row : start_row;
			end_row = (end_row == -1) ? sel_row : end_row;
			//--------------------------------------------------------------------------------------------------------

			int new_row = insert_row + 1;
			int new_count = end_row - start_row + 1;

			fgrid_Yield.Rows.InsertRange(new_row, new_count); 



			int now_level = 0;
//			string copy_clip = "";
			string source_spec;
			CellRange target_cr;

			for(int i = start_row; i <= end_row; i++)
			{

				now_level = Convert.ToInt32(fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString().Trim() ); 


//				copy_clip = fgrid_Yield.GetCellRange(i, 1, i, fgrid_Yield.Cols.Count - 1).Clip; 
//				fgrid_Yield.Clip = copy_clip;
//				fgrid_Yield.Select(new_row, 1, false);
				
 
				for(int j = 1; j < fgrid_Yield.Cols.Count; j++)
				{
					fgrid_Yield[new_row, j] = fgrid_Yield[i, j];
				}

				fgrid_Yield[new_row, 0] = "I";
				fgrid_Yield[new_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = new_template_seq.ToString();
				fgrid_Yield.Rows[new_row].IsNode = true;
				fgrid_Yield.Rows[new_row].Node.Level = now_level;
 


				for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < fgrid_Yield.Cols.Count; j++)
				{
					source_spec = fgrid_Yield.GetCellRange(i, j).UserData.ToString();

					target_cr = fgrid_Yield.GetCellRange(new_row, j);
					target_cr.UserData = source_spec; 
 
				}


				// 사이즈 자재 표시
				Display_Size_Material(new_row);


				new_row++; 
 

			} // end for i 
			


		}





		private void Display_Size_Info()
		{

			Modify_Template();

			pop_form.btn_CreateProcCd.Enabled = false;
			pop_form.btn_Apply.Enabled = false;

			pop_form.fgrid_BOMTemp.AllowEditing = false;
			pop_form.fgrid_BOMTemp.ContextMenu = null; 



		}



		#endregion

		#endregion  

		#region 이벤트 처리

		#region Form 

		private void Form_BC_Yield_withExcel_Activated(object sender, System.EventArgs e)
		{ 
			txt_StyleCd.Focus();
		}


		private void Form_BC_Yield_withExcel_Load(object sender, System.EventArgs e)
		{
			if(chk_CheckInOut.Checked)
			{
				Control_Enable(true);
			}
			else
			{
				Control_Enable(false);
			}
		}

		private void Form_BC_Yield_withExcel_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{

				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion


				bool exist_modify = Check_NotSave_Data("Close"); 
				if(exist_modify) e.Cancel = true;


				if(chk_CheckInOut.Checked) 
				{
					ClassLib.ComFunction.User_Message("Need Check Out.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
					e.Cancel = true;
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Form_BC_Yield_withExcel_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion 

		#region 툴바 이벤트

		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 

				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion


				Clear_Control();
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

				Search_Yield();

				
				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

				Save_Yield(true);


				#region 메모리 정리

				ClassLib.MemoryManagement.SetProcessWorkingSetSize(this.Handle, 0, 0);
				ClassLib.MemoryManagement.FlushMemory();

				#endregion


				//ClassLib.ComFunction.AutoWorkInfo("TEST");



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				SetPrintYield();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
  


		

		#endregion

		#region 콘트롤 이벤트 (텍스트박스, 콤보박스, 라디오버튼..)
 

		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

 

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = ""; 
				txt_Presto.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;
				//-------------------------------------------------------------------------

				DataTable dt_ret;
				
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
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		
		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;
 


				txt_StyleCd.Text = "";
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = ""; 
				txt_Presto.Text = "";
				
				txt_UploadFile.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;


				// check in/out cancel 
				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxYieldCheckinCancel);

				if(dt_ret != null && dt_ret.Rows.Count > 0)
				{
					_Checkin_Cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
				}
				else
				{
					_Checkin_Cancel = false;
				}

				dt_ret.Dispose();

				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 


		}


		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
 


				//---------------------------------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				txt_Gender.Text = ""; 
				txt_Presto.Text = "";

				txt_UploadFile.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;
 
				//---------------------------------------------------------------------------------------------------

				

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
				txt_Gender.Text = cmb_StyleCd.Columns[2].Text; 
				txt_Presto.Text = cmb_StyleCd.Columns[3].Text;


				//				//---------------------------------------------------------------------------------------------------
				//				// 선택한 스타일과, 엑셀 업로드된 스타일 정합성 체크
				//				// ok : 틀려도 계속 진행
				//				// cancel : 다른 엑셀 시트 또는 콤보 스타일 선택 작업
				//				//---------------------------------------------------------------------------------------------------
				//				if(_Excel_StyleCd.Trim() != "" && _Excel_StyleCd != cmb_StyleCd.SelectedValue.ToString().Replace("-", "") )
				//				{ 	 
				//					
				//					DialogResult message_result = ClassLib.ComFunction.User_Message("Non equal style", 
				//																					"Excel Upload", 
				//																					MessageBoxButtons.OKCancel, 
				//																					MessageBoxIcon.Warning);
				//
				//					if(message_result == DialogResult.Cancel) return;  
				//				}
				//				//---------------------------------------------------------------------------------------------------


				//size 세팅
				fgrid_Yield.Display_Size_ColHead(cmb_Factory.SelectedValue.ToString(), 
					cmb_StyleCd.SelectedValue.ToString().Replace("-", ""), 
					60,
					(int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START);



				 
				// number 형 셀타입 설정 (예 : 1,234,567.001)
				for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
				{
					fgrid_Yield.Set_CellStyle_Number(i);
				}
 

 
				// 데이터 조회
				Search_Yield();


 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void cmb_YieldType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_YieldType.SelectedIndex == -1) return;
  
				txt_UploadFile.Text = "";

				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_YieldType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// tree view depth 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				//라디오 버튼 태그값에 레벨값 세팅
				//rad_semi.tag = '1'
				//rad_cmp.tag = '2'
				//rad_all.tag = '-1'

				fgrid_Yield.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 

				if(_NeomicsYN)
				{
					fgrid_Upload.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 
				}
				else  // 엑셀 업로드
				{

					if(src.Equals(rad_Comp) )
					{
						fgrid_Upload.Tree.Show(1);  
					}
					else if(src.Equals(rad_All) )
					{
						fgrid_Upload.Tree.Show(-1);  
					}

				}

				

				


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		#endregion 

		#region 그리드 이벤트

		private void fgrid_Yield_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if ((fgrid_Yield.Rows.Fixed > 0) && (fgrid_Yield.Row >= fgrid_Yield.Rows.Fixed))
				{
					if(fgrid_Yield.Cols[fgrid_Yield.Col].DataType == typeof(bool))
					{
						fgrid_Yield.Buffer_CellData = "";
					}
					else
					{
						fgrid_Yield.Buffer_CellData = (fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col] == null) ? "" : fgrid_Yield[fgrid_Yield.Row, fgrid_Yield.Col].ToString();
					}
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_BeforeEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void fgrid_Yield_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				fgrid_Yield.Update_Row();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		
		private void fgrid_Yield_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if(e.Col < (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START) return;

			for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
			{
				fgrid_Yield.Cols[i].Width = fgrid_Yield.Cols[e.Col].Width;
			}


		}

		private void fgrid_Yield_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.Insert:
					case Keys.C: // ** copy
						Clipboard.SetDataObject(fgrid_Yield.Clip);
						break;
					case Keys.X: // ** cut
						Clipboard.SetDataObject(fgrid_Yield.Clip);
						CellRange rg = fgrid_Yield.Selection;
						rg.Data = null;
						break;
					case Keys.V: // ** paste
						IDataObject data = Clipboard.GetDataObject();
						if (data.GetDataPresent(typeof(string)))
						{
							fgrid_Yield.Select(fgrid_Yield.Row, fgrid_Yield.Col, fgrid_Yield.Rows.Count-1, fgrid_Yield.Cols.Count-1, false);
							fgrid_Yield.Clip = (string)data.GetData(typeof(string));
							fgrid_Yield.Select(fgrid_Yield.Row, fgrid_Yield.Col, false);
							
							fgrid_Yield.Update_Row(fgrid_Yield.Row);

						}
						break;

					case Keys.F: // ** find

						FlexBase.Yield.Pop_Finder pop_form = new Pop_Finder(fgrid_Yield, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE);
						pop_form.Location = new Point(MousePosition.X, MousePosition.Y);
						pop_form.Show();

						break;


				}
			}
		}
		
	

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트

		private void cmenu_ReadOnly_Popup(object sender, System.EventArgs e)
		{

			if(fgrid_Yield.Rows.Count <= fgrid_Yield.Rows.Fixed) return;

			int sel_row = fgrid_Yield.Selection.r1; 
			int sel_col = fgrid_Yield.Selection.c1;
 


			switch(Convert.ToInt32(fgrid_Yield[sel_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) )
			{
				case _SGLevel:  
					menuItem_DisplaySize.Visible = false; 
					break;

				case _CmpLevel: 
					menuItem_DisplaySize.Visible = false;  
					break;

				default:  
				    menuItem_DisplaySize.Visible = true; 
					break;

			} // end switch 
		
		}


		private void cmenu_Yield_Popup(object sender, System.EventArgs e)
		{
			try
			{
				// 선택 행의 레벨에 따른 팝업 메뉴 표시 설정
				Set_MenuItem_Visible();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Yield_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
  
	 

		private void menuitem_AddCmp_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Add_Component();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_AddCmp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
 

		}



		private void menuitem_AddTemplate_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Add_Template();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_AddTemplate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

			//Add_Template();


		}


		private void menuitem_Modify_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Modify_Template();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Modify_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

			//Modify_Template();


		}


		private void menuItem_CompDelete_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Delete_Component();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void menuitem_Delete_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Delete_Item();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuItem_CancelFlag_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Cancel_Flag();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_CancelFlag_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuItem_StyleCopy_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Copy_Yield_Style();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_StyleCopy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}


		private void menuItem_Copy_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Copy_Yield();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuItem_AutoReplace_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Replace_AutoMaterial();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AutoReplace_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void menuItem_AllInsert_Click(object sender, System.EventArgs e)
		{

			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				All_Insert_Material();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AllInsert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		


		private void menuItem_AllDelete_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				All_Delete_Material();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AllDelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		
		private void menuItem_ModifyItem_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Show_Item_Popup("Item"); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_ModifyItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuItem_ModifySpec_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Show_Item_Popup("Spec"); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_ModifySpec_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void menuItem_ModifyColor_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Show_Item_Popup("Color"); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_ModifyColor_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void menuItem_AddRawMat_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Add_Raw_Material();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AddRawMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		 
		private void menuItem_AddJointMat_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Add_Joint_Material();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AddJointMat_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}





		private void menuItem_DisplaySize_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Display_Size_Info();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Size_Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region drag and drop 이벤트 (Move component)

 

		private void fgrid_Yield_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{

				if(! chk_CheckInOut.Checked) return;

 

				_DragInfo.checkDrag = false;

				// left button, no shift: start tracking mouse to drag
				if (e.Button != MouseButtons.Left) return;

				if(fgrid_Yield.MouseRow <= fgrid_Yield.Rows.Fixed) return;

				if(fgrid_Yield.MouseCol != (int)ClassLib.TBSBC_YIELD_INFO.IxTREE) return;

				// component 만 이동 가능
				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.MouseRow, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _CmpLevel) return;
			
				if (_DragInfo.dragging) return;
				if (fgrid_Yield.MouseRow < fgrid_Yield.Rows.Fixed) return;
			
				// save current row and mouse position
				_DragInfo.row = fgrid_Yield.Row;
				_DragInfo.mouseDown = new Point(e.X, e.Y);
            
				// start checking
				_DragInfo.checkDrag = true; 

 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_MouseDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		


		#region show tooltip if the text is too long to fit the cell 


		// show tooltip if the text is too long to fit the cell (1)
		System.Windows.Forms.ToolTip _ttip;
		int _lastRow = 0, _lastCol = 0;

		private void _flex_MouseMoveTooltip(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			string text = null;
			if (e.Button == MouseButtons.None)
			{
				// get mouse coordinates
				int row = fgrid_Yield.MouseRow;
				int col = fgrid_Yield.MouseCol;

				// save work if we can
				if (row == _lastRow && col == _lastCol)
					return;

				// save info for next time
				_lastRow = row;
				_lastCol = col;

				// get text for tooltip
				if (row > -1 && col > -1)
				{
					// get display text
					text = fgrid_Yield.GetDataDisplay(row, col);

					// get display rectangle
					Rectangle rc = fgrid_Yield.GetCellRect(row, col, false);
					rc.Intersect(fgrid_Yield.ClientRectangle);

					// measure text
					using (Graphics g = fgrid_Yield.CreateGraphics())
					{
						CellStyle s = fgrid_Yield.GetCellStyleDisplay(row, col);
						float wid = g.MeasureString(text, s.Font).Width;

						if(col == (int)ClassLib.TBSBC_YIELD_INFO.IxTREE)
						{
							wid += s.Margins.Left + s.Margins.Right + s.Border.Width + 70;  // 70 : tree 표시 앞 공백 계산
						}
						else
						{
							wid += s.Margins.Left + s.Margins.Right + s.Border.Width;
						}

						if (wid < rc.Width) text = null;
					}
				}


			}

			// create tooltip if we need it
			if (text != null && _ttip == null)
			{
				_ttip = new ToolTip();
			}

			// set tooltip text
			if (_ttip != null && _ttip.GetToolTip(fgrid_Yield) != text)
				_ttip.SetToolTip(fgrid_Yield, text);


		}


		#endregion



		private void fgrid_Yield_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{

			if(! chk_CheckInOut.Checked) return;


			try
			{

				//---------------------------------------------------------------------------
				// show tooltip
				//---------------------------------------------------------------------------
				_flex_MouseMoveTooltip(sender, e); 
				//---------------------------------------------------------------------------





				// if checking and the user moved past our tolerance, start dragging
				if (!_DragInfo.checkDrag || e.Button != MouseButtons.Left) return; 
				if (Math.Abs(e.X - _DragInfo.mouseDown.X) + Math.Abs(e.Y - _DragInfo.mouseDown.Y) <= _DragTol) return;

				// update flags
				_DragInfo.dragging = true;
            
				// set cursor and highlight node
				// styles 
			 
				CellStyle cs = fgrid_Yield.Styles.Add("SourceNode");
				cs.BackColor = Color.Yellow;
				cs.Font = new Font(fgrid_Yield.Font, FontStyle.Bold); 
				fgrid_Yield.Cursor = Cursors.NoMove2D;
				fgrid_Yield.SetCellStyle(_DragInfo.row, fgrid_Yield.Selection.c1, cs);

				// check whether we can drop here
				Cursor c = (NoDropHere() ) ? Cursors.No : Cursors.NoMove2D;
				if (c != fgrid_Yield.Cursor) fgrid_Yield.Cursor = c;

 




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_MouseMove", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private bool NoDropHere()
		{
			if (fgrid_Yield.MouseRow < fgrid_Yield.Rows.Fixed) return true;
			if (fgrid_Yield.MouseCol < fgrid_Yield.Cols.Fixed) return true; 
			return false;
		} 

		private void fgrid_Yield_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{

				if(! chk_CheckInOut.Checked) return;


				// we're not checking until the mouse goes down again
				_DragInfo.checkDrag = false;

				// not dragging? we're done
				if (!_DragInfo.dragging) return; 

				// stop dragging
				_DragInfo.dragging = false;
				fgrid_Yield.SetCellStyle(_DragInfo.row, fgrid_Yield.Selection.c1, "");
				
				
				fgrid_Yield.Cursor = Cursors.Default;
		        
				// test whether the drop is allowed
				if (NoDropHere()) return;



				#region semigood 이동

				//				// semi good 일때만 가능
				//				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _SGLevel ) return;
				//
				//
				//
				//				// move node into new parent node
				//				Node ndSrc = fgrid_Yield.Rows[_DragInfo.row].Node;
				//				Node ndDst = fgrid_Yield.Rows[fgrid_Yield.Row].Node;
				//
				//				string old_semi_good_cd = fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
				//				string new_semi_good_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
				//
				//				if(fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString() != new_semi_good_cd)
				//				{
				//					ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
				//					ndSrc.Select();
				//			
				//
				//
				//
				//					Node node = null;
				//					int end_row = -1;
				//
				//					if(ndSrc.Children == 0)
				//					{ 
				//						end_row = ndSrc.Row.Index;
				//					}
				//					else
				//					{  
				//						end_row = ndSrc.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;
				//
				//						while(true)
				//						{
				//							node = fgrid_Yield.Rows[end_row].Node;
				//					
				//							if(node.Children == 0) break;
				//
				//							end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
				//
				//						} // end while 
				//
				//					} // end if
				//
				//
				// 
				//					for(int i = ndSrc.Row.Index; i <= end_row; i++)
				//					{
				//						fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "M"; 
				//						fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = new_semi_good_cd;
				// 
				//						// userdata 값으로 옮기기 전 semi good cd 저장
				//						// 전체 save 할 때, Flag = 'M' 인 경우,
				//						// 이전 semi good cd 에 대한 데이터 Delete 문 구성하기 위함 
				//						CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD);
				//						cr.UserData = old_semi_good_cd;
				//
				//
				//					}  // end for i
				//
				//
				//				}  // end if (!= new_semi_good_cd)



				#endregion 

				#region semigood, component 이동


				//				// semi good, component 일때만 가능
				//				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _SGLevel 
				//					&& Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _CmpLevel ) return;
				//
				//
				//
				//
				//				// move node into new parent node
				//				Node ndSrc = fgrid_Yield.Rows[_DragInfo.row].Node;
				//				Node ndDst = fgrid_Yield.Rows[fgrid_Yield.Row].Node;
				//
				//				string old_semi_good_cd = fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
				//				string new_semi_good_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();





				//				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
				//				{
				// 
				//					
				//					
				//
				//					if(fgrid_Yield[ndSrc.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString() != new_semi_good_cd)
				//					{
				//						ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
				//						ndSrc.Select();
				//			
				//
				//
				//
				//						Node node = null;
				//						int end_row = -1;
				//
				//						if(ndSrc.Children == 0)
				//						{ 
				//							end_row = ndSrc.Row.Index;
				//						}
				//						else
				//						{  
				//							end_row = ndSrc.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;
				//
				//							while(true)
				//							{
				//								node = fgrid_Yield.Rows[end_row].Node;
				//					
				//								if(node.Children == 0) break;
				//
				//								end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
				//
				//							} // end while 
				//
				//						} // end if
				//
				//
				// 
				//						for(int i = ndSrc.Row.Index; i <= end_row; i++)
				//						{
				//							fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "M"; 
				//							fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = new_semi_good_cd;
				// 
				//							// userdata 값으로 옮기기 전 semi good cd 저장
				//							// 전체 save 할 때, Flag = 'M' 인 경우,
				//							// 이전 semi good cd 에 대한 데이터 Delete 문 구성하기 위함 
				//							CellRange cr = fgrid_Yield.GetCellRange(i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD);
				//							cr.UserData = old_semi_good_cd;
				//
				//
				//						}  // end for i
				//
				//
				//					}  // end if (!= new_semi_good_cd)
				//
				//				}  // end if(== _SGLevel)
				//				else if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
				//				{


				//					ndSrc.Move(NodeMoveEnum.Down);  
				//					ndSrc.Select();
			
 



				//				} // end if(== _CmpLevel)


				#endregion

				#region datatable 이용


				// semi good, component 일때만 가능
				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _SGLevel 
					&& Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _CmpLevel ) return;

 
				if(_DragInfo.row == fgrid_Yield.Row) 
				{

					if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
					{  
						fgrid_Yield.Rows[_DragInfo.row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					}
					else if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
					{ 
						fgrid_Yield.Rows[_DragInfo.row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					}
					
					return;
				}


				// move node into new parent node
				Node ndSrc = fgrid_Yield.Rows[_DragInfo.row].Node;
				Node ndDst = fgrid_Yield.Rows[fgrid_Yield.Row].Node;

				string old_semi_good_cd = fgrid_Yield[_DragInfo.row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
				string new_semi_good_cd = fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();



				//-----------------------------------------------------------------------------------
				// 0. update component seq 
				//-----------------------------------------------------------------------------------
				int component_seq = 0;
				int pre_component_seq = 0;
				int next_component_seq = 0;


				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
				{ 
					// semi good 선택해서 옮겨서 처음 component일 경우 
					if(ndDst.Children == 0)
					{
						component_seq = _Component_Seq_Range;
					}
						// component 있을 경우, 맨 처음 위치로 새로운 component 아래로 이동시키기 위함
					else
					{
						pre_component_seq = Convert.ToInt32(fgrid_Yield[ndDst.GetNode(NodeTypeEnum.FirstChild).Row.Index, 
							(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() );

						component_seq = Convert.ToInt32( Math.Ceiling( Convert.ToDouble (pre_component_seq / 2 ) ) );
					}

				}
				else if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
				{

					pre_component_seq = Convert.ToInt32(fgrid_Yield[ndDst.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() );


 


					C1.Win.C1FlexGrid.Node parent_node = ndDst.GetNode(NodeTypeEnum.Parent);


					
					
					if(parent_node.GetNode(NodeTypeEnum.LastChild).Row.Index == ndDst.Row.Index)
					{
						next_component_seq = Convert.ToInt32(fgrid_Yield[ndDst.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() ) + _Component_Seq_Range;
					}
					else
					{
						C1.Win.C1FlexGrid.Node next_sibling = ndDst.GetNode(NodeTypeEnum.NextSibling);

						next_component_seq = Convert.ToInt32(fgrid_Yield[next_sibling.Row.Index, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString() ); 
						
					}


					component_seq = pre_component_seq + Convert.ToInt32( Math.Ceiling( Convert.ToDouble ( (next_component_seq - pre_component_seq) / 2 ) ) ); 
 
					component_seq = (component_seq < 0) ? 0 : component_seq;

				} 




				//-----------------------------------------------------------------------------------
				// 1. source datatable 구조 구성
				//-----------------------------------------------------------------------------------
				DataTable source_dt = new DataTable();

				for(int i = 0; i < fgrid_Yield.Cols.Count; i++)
				{
					source_dt.Columns.Add(new DataColumn(i.ToString(), typeof(string)) );
				}




				//-----------------------------------------------------------------------------------
				// 2. source datatable 데이터 구성
				//----------------------------------------------------------------------------------- 
				int start_row = -1, end_row = -1; 

				C1.Win.C1FlexGrid.Node node = null;

				start_row = _DragInfo.row;

				node = fgrid_Yield.Rows[_DragInfo.row].Node;

				if(node.Children == 0)
				{ 
					end_row = start_row;
				}
				else
				{  
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

					while(true)
					{
						node = fgrid_Yield.Rows[end_row].Node;
					
						if(node.Children == 0) break;

						end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

					} // end while 

				} // end if


				DataRow dr;
				CellRange cr;
				

				for(int i = start_row; i <= end_row; i++)
				{
					

					//-----------------------------------------------------------------------------------
					// 1. 채산 데이터
					//----------------------------------------------------------------------------------- 
					dr = source_dt.NewRow();

					for(int j = 0; j < fgrid_Yield.Cols.Count; j++)
					{
						dr[j] = (fgrid_Yield[i, j] == null) ? "" : fgrid_Yield[i, j].ToString();
					}

					source_dt.Rows.Add(dr);



					//-----------------------------------------------------------------------------------
					// 2. 스펙 데이터
					//----------------------------------------------------------------------------------- 
					dr = source_dt.NewRow();

					for(int j = 0; j < fgrid_Yield.Cols.Count; j++)
					{
						cr = fgrid_Yield.GetCellRange(i, j, i, j);

						dr[j] = (cr.UserData == null) ? "" : cr.UserData.ToString();
					}

					source_dt.Rows.Add(dr);




				} // end for i




				//-----------------------------------------------------------------------------------
				// 5. source 삭제
				//-----------------------------------------------------------------------------------
				
				fgrid_Yield.Rows.RemoveRange(start_row, (end_row - start_row + 1) );



				//-----------------------------------------------------------------------------------
				// 3. destination 에 추가
				//-----------------------------------------------------------------------------------
				string type_division = "";
				int current_row = 0;
				int add_row_count = 0;
				//int level = 0; 

				


				for( int i = 0; i < source_dt.Rows.Count; i+=2)
				{
					type_division = source_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString();


					if(type_division == _TypeCmp)
					{ 

						if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
						{ 

							ndDst.AddNode(NodeTypeEnum.FirstChild, ""); 
							current_row = ndDst.GetNode(NodeTypeEnum.FirstChild).Row.Index;

							
 
						}
						else if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
						{

							ndDst.AddNode(NodeTypeEnum.NextSibling, ""); 
							current_row = ndDst.GetNode(NodeTypeEnum.NextSibling).Row.Index;

						}  



						fgrid_Yield.Rows[current_row].IsNode = true;
						fgrid_Yield.Rows[current_row].Node.Level = Convert.ToInt32( source_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString());


					}
					else
					{

//						add_row_count++; 
//						level = Convert.ToInt32(source_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ); 
//						fgrid_Yield.Rows.InsertNode(current_row + add_row_count, level); 
 
						C1.Win.C1FlexGrid.Node current_node = fgrid_Yield.Rows[current_row].Node.AddNode(NodeTypeEnum.LastChild, "");

						add_row_count = current_node.Row.Index - current_row;


						fgrid_Yield.Rows[current_node.Row.Index].IsNode = true;
						fgrid_Yield.Rows[current_node.Row.Index].Node.Level = Convert.ToInt32( source_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString());




					}



 

					for(int j = 0; j < source_dt.Columns.Count; j++)
					{
						fgrid_Yield[current_row + add_row_count, j] = source_dt.Rows[i].ItemArray[j].ToString();

						cr = fgrid_Yield.GetCellRange(current_row + add_row_count, j, current_row + add_row_count, j);
						cr.UserData = source_dt.Rows[i + 1].ItemArray[j].ToString();

					}
 

					//-----------------------------------------------------------------------------------
					// 4. destination 에 추가 + update move semigood + update component sequence
					//-----------------------------------------------------------------------------------

					fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "M"; 
					fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = new_semi_good_cd;

					// userdata 값으로 옮기기 전 semi good cd 저장
					// 전체 save 할 때, Flag = 'M' 인 경우,
					// 이전 semi good cd 에 대한 데이터 Delete 문 구성하기 위함 - 여러 semi good 옮길 때, 최초 semi good 으로 설정
					cr = fgrid_Yield.GetCellRange(current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD);
//					if(cr.UserData == null || cr.UserData.ToString().Equals("") )
//					{
//						cr.UserData = old_semi_good_cd; 
//					}
					
					cr.UserData = old_semi_good_cd; 




					if(type_division == _TypeCmp)
					{
						fgrid_Yield[current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = component_seq.ToString(); 
						fgrid_Yield.GetCellRange(current_row + add_row_count, 1,
							current_row + add_row_count, fgrid_Yield.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					}

					cr = fgrid_Yield.GetCellRange(current_row + add_row_count, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ);
					cr.UserData = component_seq.ToString(); 


 
					// 이미지 표시 
					Display_Type_Image(current_row + add_row_count); 
  
					// 사이즈 자재 표시
					Display_Size_Material(current_row + add_row_count);
 

 

				} // end for(int i = 0; i < source_dt.Rows.Count; i++)  


				//-----------------------------------------------------------------------------------
				// 6. top row 처리
				//-----------------------------------------------------------------------------------
 
//				fgrid_Yield.Tree.Show(_SGLevel);
//				fgrid_Yield.Tree.Show(_CmpLevel); 
//  
//				int top_row = -1;
//
//				if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
//				{ 
//					top_row = fgrid_Yield.Row - 1; 
//
//				}
//				else if(Convert.ToInt32(fgrid_Yield[fgrid_Yield.Row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
//				{
//					C1.Win.C1FlexGrid.Node toprow_node = fgrid_Yield.Rows[fgrid_Yield.Row].Node; 
//					top_row = toprow_node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent).Row.Index - 1; 
//				} 
// 
// 				top_row = (top_row < fgrid_Yield.Rows.Fixed) ? fgrid_Yield.Rows.Fixed : top_row; 
//				fgrid_Yield.TopRow = top_row; 
				

				fgrid_Yield.Tree.Show(_SGLevel); 

				RadioButton current_rad = null;

				if(rad_SG.Checked)
				{
					current_rad = rad_SG;
				}
				else if(rad_Comp.Checked)
				{
					current_rad = rad_Comp;
				}
				else
				{
					current_rad = rad_All;
				}


				rad_CheckedChanged(current_rad, null);

//				fgrid_Yield.Rows[current_row].Node.Collapsed = false;
//			    fgrid_Yield.TopRow = current_row;
				


				fgrid_Yield.TopRow = fgrid_Yield.Row;






				#endregion






			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Yield_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

			
		}

		#endregion
	
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

		#region 버튼 이벤트

		private void btn_Confirm_Click(object sender, System.EventArgs e)
		{
			try
			{ 

				//Confirm_Yield_Status();


				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_YieldStatus.SelectedIndex == -1) return;


				string factory = cmb_Factory.SelectedValue.ToString();
				string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				string yield_status = cmb_YieldStatus.SelectedValue.ToString();
				string yield_status_desc = cmb_YieldStatus.Columns[1].Text;



				DataTable dt_ret = FlexBase.Yield.Form_BC_Yield_Status.Select_SBC_YIELD_STATUS(factory, style_cd, yield_status);

				if(dt_ret.Rows.Count == 0)
				{

					FlexBase.Yield.Pop_Yield_Status pop_form = new FlexBase.Yield.Pop_Yield_Status(factory, style_cd, yield_status, yield_status_desc);
					pop_form.ShowDialog();

					if(pop_form._Close_Apply)
					{ 
						_YieldStatus = cmb_YieldStatus.SelectedValue.ToString(); 
					}

					cmb_YieldStatus.SelectedValue = _YieldStatus; 

				}
				else
				{

					string user = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_STATUS.IxUPD_USER - 1].ToString();

					COM.ComFunction MyComFunction = new COM.ComFunction();
					string confirm_date = MyComFunction.ConvertDate2Type(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_STATUS.IxCONFIRM_YMD - 1].ToString() );

					string message = "Already Confirm [ " + yield_status_desc + " ] " 
						+ "\r\n\r\n" + "User : " + user
						+ "\r\n\r\n" + "Confirm Date : " + confirm_date;

					ClassLib.ComFunction.User_Message(message, "Yield Status Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;

				}

 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Confirm_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

 

		private void btn_YieldCopy_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Copy_Yield_Style();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_YieldCopy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		 
		}

		
		private void btn_ViewHistory_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				View_Yield_History();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_ViewHistory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void btn_YieldCheck_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Yield_Item_Check();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_ViewHistory_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void btn_YieldInspection_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				Yield_Inspection();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_YieldInspection_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 


		private void btn_CompSeqBatch_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Keep_ComponentSeq();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_CompSeqBatch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		#endregion

		#endregion 

		#region DB Connect


		/// <summary>
		/// Select_Yield : 채산 리스트 조회
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_yieldtype"></param>
		/// <returns></returns>
		private DataTable Select_Yield(string arg_factory, string arg_stylecd, string arg_yieldtype)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_MAIN";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_YIELD_TYPE";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = arg_yieldtype; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		/// <summary>
		/// Select_Yield_Status : yield status 조회
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private DataTable Select_Yield_Status(string arg_factory, string arg_stylecd, string arg_yield_status)
		{

			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_STATUS";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_YIELD_STATUS";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = arg_yield_status; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}

 
		/// <summary>
		/// Save_Yield_Status : 채산 Status 수정
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_yieldstatus"></param>
		/// <returns></returns>
		public static bool Save_Yield_Status(string arg_factory, string arg_stylecd, string arg_yieldstatus)
		{
			try
			{
				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;
 
				int col_ct = 4;   
				 
				LMyOraDB.ReDim_Parameter(col_ct);
				LMyOraDB.Process_Name = "PKG_SBC_YIELD.SAVE_SBC_YIELD_INFO_STATUS";

				// 파라미터 이름 설정
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				LMyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
				LMyOraDB.Parameter_Name[2] = "ARG_YIELD_STATUS";  
				LMyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
 
				  
				LMyOraDB.Parameter_Values[0] = arg_factory;
				LMyOraDB.Parameter_Values[1] = arg_stylecd;
				LMyOraDB.Parameter_Values[2] = arg_yieldstatus; 
				LMyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User; 



				LMyOraDB.Add_Modify_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Yield_Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}



		/// <summary>
		/// Run_Keep_ComponentSeq : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private bool Run_Keep_ComponentSeq(string arg_factory, string arg_stylecd)
		{
			try
			{
				DataSet ds_ret;
 
				int col_ct = 3;   
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.RUN_KEEP_THE_COMPONENT_SEQ";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";    
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER";  
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
 
				  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_stylecd; 
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.This_User; 



				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Yield_Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}




		/// <summary>
		/// Delete_Component : Component 삭제 DB 반영
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_semi_good_cd"></param>
		/// <param name="arg_component_cd"></param>
		/// <returns></returns>
		private bool Delete_Component(string arg_factory, string arg_style_cd, string arg_semi_good_cd, string arg_component_cd)
		{

			try
			{ 
				DataSet ds_ret;
 
				int col_ct = 5;   
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.DELETE_SBC_YIELD_COMPONENT"; 


				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";  
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";  
				MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";  
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
 
				  
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_style_cd;
				MyOraDB.Parameter_Values[2] = arg_semi_good_cd; 
				MyOraDB.Parameter_Values[3] = arg_component_cd; 
				MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User; 



				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Delete_Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


		}




		#endregion    

		#region Material Usage List Upload


		#region Upload - Event

		  

		private bool _Upload_ON_Flag = false;

		private void tab_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Upload_ON_Flag = !_Upload_ON_Flag;

				if(_Upload_ON_Flag)
				{
					pnl_BB2.Size = new Size(1006, 222); 
				}
				else
				{
					pnl_BB2.Size = new Size(1006, 24);
				}

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tab_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		private void btn_OpenFile_Click(object sender, System.EventArgs e)
		{
			try
			{

				//openFileDialog1.InitialDirectory = @"C:\";

				openFileDialog1.DefaultExt = "xls";
				openFileDialog1.Filter = "Excel File (*.xls)|*.xls";
				//openFileDialog1.RestoreDirectory = true;


				if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
				 
				txt_UploadFile.Text = openFileDialog1.FileName; 

				fgrid_Upload.Rows.Count = fgrid_Upload.Rows.Fixed;
				 
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		

		private int _Ix_Component = 0;          //F1
		private int _Ix_ExcelSizeStart = 1;     //F2
		private int _Ix_Material = 5;			//F6
		private int _Ix_Material_1 = 6;			//F7
		private int _Ix_SpecUnit = 15;			//F16
		private int _Ix_Color = 17;				//F18
		private int _Ix_CommonYieldValue = 23;	//F24

		private string _Excel_StyleCd = "";



		private void btn_UploadCondition_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 


				int[] pop_parameter = new int[] { _Ix_Component, _Ix_ExcelSizeStart, _Ix_Material, _Ix_Material_1, _Ix_SpecUnit, _Ix_Color, _Ix_CommonYieldValue };

				FlexBase.Yield.Pop_Yield_Upload_Condition pop_form = new FlexBase.Yield.Pop_Yield_Upload_Condition(pop_parameter);
				pop_form.ShowDialog();

				
				if(pop_form._Close_Apply)
				{

					_Ix_Component = pop_form._Ix_Component;          
					_Ix_ExcelSizeStart = pop_form._Ix_ExcelSizeStart;     
					_Ix_Material = pop_form._Ix_Material;			
					_Ix_Material_1 = pop_form._Ix_Material_1;			
					_Ix_SpecUnit = pop_form._Ix_SpecUnit;			
					_Ix_Color = pop_form._Ix_Color;				
					_Ix_CommonYieldValue = pop_form._Ix_CommonYieldValue;	


					_NeomicsYN = false;

					Excel_Upload();


				}


				




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_UploadCondition_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

			}


		}



		private void btn_Upload_Click(object sender, System.EventArgs e)
		{  
			try
			{ 

				_NeomicsYN = false;

				Excel_Upload();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Excel_Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;

			}

		}



		/// <summary>
		/// Excel_Upload : 
		/// </summary>
		private void Excel_Upload()
		{

			this.Cursor = Cursors.WaitCursor; 


 


			#region 1. Excel Upload -> DataTable


			DataTable step_1_dt = ExcelUpload_Step_1();

			if(step_1_dt == null) return;

			#endregion  

			#region 2. 데이터 시작 부분 추출

			
			int first_data_row = ExcelUpload_Step_2(step_1_dt); 
  

			#endregion 

			#region 3. 채산값 사이즈 시작, 끝 컬럼 추출

			
			int[] size_col = ExcelUpload_Step_3(step_1_dt, first_data_row);

			int size_start_col = size_col[0];
			int size_end_col = size_col[1];  


			#endregion 

			#region 4. 주석행 등 필요없는 행 정리 후 데이터 부분 재추출


			//DataTable step_4_dt = ExcelUpload_Step_4(step_1_dt, first_data_row);

			DataTable step_4_dt = ExcelUpload_Step_4(step_1_dt, first_data_row, size_start_col, size_end_col);


			
			#endregion

			#region 5. 윗실, 아랫실 같은 경우 Material 부분으로 재 설정


			DataTable step_5_dt = ExcelUpload_Step_5(step_4_dt);


			#endregion

			#region 6. 필요없는 컬럼 정리 후 데이터 부분 재추출

			
			DataTable result_dt = ExcelUpload_Step_6(step_5_dt, size_start_col, size_end_col);


			#endregion 

			#region 7. 트리로 표현 


			ExcelUpload_Step_7(step_1_dt, result_dt, size_start_col, size_end_col, first_data_row + 1); 


			#endregion 
 

			result_dt.Dispose();
			step_5_dt.Dispose();
			step_4_dt.Dispose();
			step_1_dt.Dispose();




		}



		
		#region Excel Upload Step

		/// <summary>
		/// ExcelUpload_Step_1 : 1. Excel Upload -> DataTable
		/// </summary>
		/// <returns></returns>
		private DataTable ExcelUpload_Step_1()
		{

			string path = txt_UploadFile.Text.Trim(); 

			DataSet ds_ret = ClassLib.ComFunction.Read_Excel(path);

			if(ds_ret == null) return null; 


			//---------------------------------------------------------------------------------------------------
			// 선택한 스타일과, 엑셀 업로드된 스타일 정합성 체크
			// ok : 틀려도 계속 진행
			// cancel : 다른 엑셀 시트 또는 콤보 스타일 선택 작업
			//---------------------------------------------------------------------------------------------------
			// excel sheet name = '000000-000$'  형식이므로 replace 처리
			string excel_style_cd = ds_ret.Namespace.Trim().ToString().Replace("$", "");
			excel_style_cd = excel_style_cd.Replace("'", "");
			excel_style_cd = excel_style_cd.Replace("-", ""); 

			_Excel_StyleCd = excel_style_cd;



			//			if(cmb_StyleCd.SelectedIndex != -1)
			//			{
			//				 
			//				
			//				string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 
			//			
			//
			//				if(excel_style_cd != style_cd)
			//				{
			//					DialogResult message_result = ClassLib.ComFunction.User_Message("Non equal style", 
			//						"Excel Upload", 
			//						MessageBoxButtons.OKCancel, 
			//						MessageBoxIcon.Warning);
			//  
			//					if(message_result == DialogResult.Cancel) 
			//					{
			//						fgrid_Upload.Rows.Count = fgrid_Upload.Rows.Fixed; 
			//						fgrid_Upload.Cols.Count = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START;
			//
			//						return null;   
			//					}
			//
			//				} 
			// 
			//			}
			//---------------------------------------------------------------------------------------------------

			DataTable dt_ret = ds_ret.Tables[0];
  

			DataTable dt_new = new DataTable();


			for(int i = 0; i < dt_ret.Columns.Count; i++)
			{  
				dt_new.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

			} // end for i


			DataRow dr;

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				dr = dt_new.NewRow();

				for(int j = 0; j < dt_ret.Columns.Count; j++)
				{
					dr[j] = dt_ret.Rows[i].ItemArray[j].ToString();
				}

				dt_new.Rows.Add(dr);
			}


			//return dt_ret;

			return dt_new;


		}


		/// <summary>
		/// ExcelUpload_Step1 : 2. 데이터 시작 부분 추출
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <returns></returns>
		private int ExcelUpload_Step_2(DataTable arg_dt)
		{

			string first_desc = "COMPONENT";
			string now_desc = "";
			int first_row = 0;


			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				
				now_desc = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString();

				if(now_desc == first_desc) 
				{
					first_row = i;
					break;
				}


			} // end for i

			return first_row;

		}


		/// <summary>
		/// ExcelUpload_Step_3 : 3. 채산값 사이즈 시작, 끝 컬럼 추출
		/// </summary>
		/// <param name="arg_first_data_row"></param>
		/// <param name="arg_dt"></param>
		/// <returns></returns>
		private int[] ExcelUpload_Step_3(DataTable arg_dt, int arg_first_data_row)
		{

			int allsize_row = arg_first_data_row + 1; 

			
			int size_start_col = 0;
			int size_end_col = 0;  



			//			string size_desc = "ALL SIZE";
			//
			//			if(arg_dt.Rows[allsize_row].ItemArray[0].ToString().Trim().Equals(size_desc))
			//			{
			//				
			//				// 0 : "ALL SIZE" description 은 제외
			//				// 1 컬럼부터 비교 시작
			//
			//				_Ix_Component = 0;          //F1
			//				_Ix_ExcelSizeStart = 1;     //F2
			//				_Ix_Material = 5;			//F6
			//				_Ix_Material_1 = 6;			//F7
			//				_Ix_SpecUnit = 15;			//F16
			//				_Ix_Color = 17;				//F18
			//				_Ix_CommonYieldValue = 23;	//F24
			//
			//			}
			//			else
			//			{
			//
			//				_Ix_Component = 0;          //F1
			//				_Ix_ExcelSizeStart = 0;     //F1
			//				_Ix_Material = 5;			//F6
			//				_Ix_Material_1 = 6;			//F7
			//				_Ix_SpecUnit = 16;			//F17
			//				_Ix_Color = 18;				//F19
			//				_Ix_CommonYieldValue = 24;	//F25
			//
			//			}

		

			for(int i = _Ix_ExcelSizeStart; i < arg_dt.Columns.Count; i++)
			{
				
				if(arg_dt.Rows[allsize_row].ItemArray[i].ToString().Trim().Equals("") ) continue;

				size_start_col = i;
				break;

			} // end for i

 

			for(int i = size_start_col; i < arg_dt.Columns.Count; i++)
			{
				
				//				if(i == _Ix_CommonYieldValue && size_end_col == 0)
				//				{
				//					//size_end_col = _Ix_CommonYieldValue - 1;
				//
				//					if(_Ix_ExcelSizeStart == 1)
				//					{
				//						size_end_col = _Ix_CommonYieldValue - 1;
				//					}
				//					else
				//					{
				//						size_end_col = _Ix_CommonYieldValue + 1;
				//					}
				//
				//				}


				if(i == arg_dt.Columns.Count - 1 && size_end_col == 0)
				{ 

					size_end_col = arg_dt.Columns.Count - 1;

				}



				if(! arg_dt.Rows[allsize_row].ItemArray[i].ToString().Trim().Equals("") ) continue;

				size_end_col = i - 1;
				 

				break;

			} // end for i





			int[] return_col = new int[2];

			return_col[0] = size_start_col;
			return_col[1] = size_end_col;

			return return_col;


		}



		/// <summary>
		/// ExcelUpload_Step_4 : 4. 주석행 등 필요없는 행 정리 후 데이터 부분 재추출
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_first_data_row"></param> 
		/// <returns></returns>
		private DataTable ExcelUpload_Step_4(DataTable arg_dt, int arg_first_data_row, int arg_size_start_col, int arg_size_end_col)
		{

			string component = ""; 
			string spec_unit = "";
			string material = ""; 
			string material_1 = "";
			string common_yield_value = "";

			double temp = 0; 
			bool exist_yield = false;
			string first_yield = "";
			


			DataTable dt_ret = arg_dt.Clone();

			DataRow dr;



			for(int i = arg_first_data_row; i < arg_dt.Rows.Count; i++)
			{

				component = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim();
				spec_unit = arg_dt.Rows[i].ItemArray[_Ix_SpecUnit].ToString().Trim();
				material = arg_dt.Rows[i].ItemArray[_Ix_Material].ToString().Trim(); 
				material_1 = arg_dt.Rows[i].ItemArray[_Ix_Material_1].ToString().Trim(); 

				common_yield_value = arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString().Trim(); 
 

				//				if(common_yield_value.Equals("") && (material.Equals("") || material.Substring(0, 1).Equals("*") ) ) continue; 

 

				// 자재는 없고, 숫자값이 하나라도 있으면 구성.
				
				temp = 0; 
				exist_yield = false;


				for(int j = arg_size_start_col; j <= arg_size_end_col; j++)
				{  
					
					try // 숫자형 : 채산값 행으로 간주 
					{
						temp = Convert.ToDouble(arg_dt.Rows[i].ItemArray[j].ToString().Trim()); 
						exist_yield = true;
						first_yield = temp.ToString();
						break;
					}
					catch
					{
					} 
				}

 


				if(common_yield_value.Equals("") && (material.Equals("") || material.Substring(0, 1).Equals("*") ) && (! exist_yield) ) continue; 


 

				dr = dt_ret.NewRow();

				for(int j = 0; j < arg_dt.Columns.Count; j++)
				{

					dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

					if(j >= arg_size_start_col && j <= arg_size_end_col)
					{
						if(material.Equals("") && material_1.Equals("") && arg_dt.Rows[i].ItemArray[arg_size_start_col].ToString().Trim().Equals("") && exist_yield)
						{
							dr[j] = first_yield;
						}

					} 

				} // end for j
 

				
				dt_ret.Rows.Add(dr); 
				

			} // end for i


			return dt_ret;


		}



		/// <summary>
		/// ExcelUpload_Step_5 : 5. 윗실, 아랫실 같은 경우 Material 부분으로 재 설정
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <returns></returns>
		private DataTable ExcelUpload_Step_5(DataTable arg_dt)
		{

			DataTable dt_ret = arg_dt.Clone(); 
			DataRow dr;
			
			
			string material_1 = "";

			string material = "";
			string spec_unit = "";
			string common_yield_value = "";

			
			double temp = 0;
			bool numeric = true;
			bool joint_material = false;
 


			// title 추가
			for(int i = 0; i < 2; i++)
			{
				
				dr = dt_ret.NewRow();

				for(int j = 0; j < arg_dt.Columns.Count; j++)
				{

					dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

				} // end for j

				dt_ret.Rows.Add(dr);
			}

 


			bool duplicate = false;

			string color = "";

			string component = "";
			string before_component = "";

			string before_material = "";
			string before_color = "";


			// title 제외
			for(int i = 2; i < arg_dt.Rows.Count; i++)
			{
				


				component = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim(); 
				material = arg_dt.Rows[i].ItemArray[_Ix_Material].ToString().Trim(); 
				material_1 = arg_dt.Rows[i].ItemArray[_Ix_Material_1].ToString().Trim(); 
				spec_unit = arg_dt.Rows[i].ItemArray[_Ix_SpecUnit].ToString().Trim(); 
				color = arg_dt.Rows[i].ItemArray[_Ix_Color].ToString().Trim(); 
				common_yield_value = arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString().Trim(); 

				
				if(! material_1.Equals("") ) 
				{
					// 숫자형 아니면
					// material_col 으로 데이터 이동
					try
					{
						temp = Convert.ToDouble(material_1);

						numeric = true;
						duplicate = false;
					}
					catch
					{

						numeric = false;


						// 윗실, 밑실인 경우
						// 중복 체크해서 채산값 합계 처리 작업 해 주기 위해서 중복 체크
						// 나머지 경우는 모두 중복 아님으로 처리 

						before_material = dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Ix_Material].ToString().Trim();
						before_color = dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Ix_Color].ToString().Trim();

						if(component.Equals(""))
						{
							component = before_component;
						}

						if(before_component + before_material + before_color == component + material_1 + color)
						{
							duplicate = true;
						}
						else
						{
							duplicate = false;
						}


					} 
				}




 
				if(material.Equals("") && (! spec_unit.Equals("")) && (! common_yield_value.Equals("")) )
				{
					joint_material = true;
				}
				else
				{
					joint_material = false;
				}


 

				if(duplicate)
				{


					DataRow dr_temp;

					double sum_common_yield_value = 0;
					double before_yield_value = 0;
					double now_yield_value = 0;
					string one_common_yield_value = "";

					one_common_yield_value = (dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Ix_CommonYieldValue].ToString() == "") ? "0" : dt_ret.Rows[dt_ret.Rows.Count - 1].ItemArray[_Ix_CommonYieldValue].ToString();
					
					try
					{
						before_yield_value = Convert.ToSingle(one_common_yield_value); 
					}
					catch
					{
						before_yield_value = 0;
					}

					
					common_yield_value = (common_yield_value.Trim() == "") ? "0" : common_yield_value; 

					try
					{
						now_yield_value = Convert.ToSingle(common_yield_value); 
					}
					catch
					{
						now_yield_value = 0;
					}


					//sum_common_yield_value = before_yield_value + Convert.ToSingle( common_yield_value );

					sum_common_yield_value = before_yield_value + now_yield_value;

					dr_temp = dt_ret.Rows[dt_ret.Rows.Count - 1]; 
					dr_temp[_Ix_CommonYieldValue] = Convert.ToSingle(sum_common_yield_value).ToString(); 


				}
				else
				{


					dr = dt_ret.NewRow();



				
					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{

						dr[j] = arg_dt.Rows[i].ItemArray[j].ToString();

					} // end for j 


					if(numeric == false)
					{
						dr[_Ix_Material] = material_1;
					}


					if(joint_material == true)
					{
						dr[_Ix_Material] = spec_unit;

						//						if(numeric == false)
						//						{
						//							dr[_Ix_Component] = component;
						//						}


					}
 


					dt_ret.Rows.Add(dr); 


				}
 

				numeric = true;
				duplicate = false;





				// Material 에 대한 컴포넌트
				if(! component.Equals("") )
				{
					before_component = component;
				}





			} // end for i 


			return dt_ret;


		}



		/// <summary>
		/// ExcelUpload_Step_6 : 6. 필요없는 컬럼 정리 후 데이터 부분 재추출
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_size_start_col"></param>
		/// <param name="arg_size_end_col"></param>
		/// <returns></returns>
		private DataTable ExcelUpload_Step_6(DataTable arg_dt, int arg_size_start_col, int arg_size_end_col)
		{

			
 
			string first_yield_value = "";
			double temp = 0; 
			bool before_numeric = false;

			DataRow dr = null;


			//--------------------------------------------------------------------------------------------
			// create return table
			//--------------------------------------------------------------------------------------------
			DataTable result_ret = new DataTable();

			result_ret.Columns.Add(new DataColumn("COMPONENT", typeof(string) ) );
			result_ret.Columns.Add(new DataColumn("MATERIAL", typeof(string) ) );
			result_ret.Columns.Add(new DataColumn("SPEC_UNIT", typeof(string) ) );
			result_ret.Columns.Add(new DataColumn("COLOR", typeof(string) ) );
			result_ret.Columns.Add(new DataColumn("COMMON_YIELD_VALUE", typeof(string) ) );


			for(int i = arg_size_start_col; i <= arg_size_end_col; i++)
			{
				result_ret.Columns.Add(new DataColumn("SIZE_YIELD_VALUE" + i.ToString(), typeof(string) ) );

			} // end for i
			//--------------------------------------------------------------------------------------------
 

			string before_component = "";
			string before_material = "";
			string before_spec_unit = "";
			string before_color = "";
			string before_common_yield_value = "";

			//int component_start_row = 0;

			DataRow dr_temp; 
			int insert_row = -1;
			int start_row = -1;



			for(int i = 2; i < arg_dt.Rows.Count; i++)
			{
				
				first_yield_value = arg_dt.Rows[i].ItemArray[arg_size_start_col].ToString();  
 

				// 숫자형 : 채산값 행으로 간주 
				try
				{
					temp = Convert.ToDouble(first_yield_value);
					
 
					#region (한 콤포넌트 아래 모든 자재에 일괄 적용)


					if(before_numeric)
					{



						// component row
						for(int a = result_ret.Rows.Count - 1; a >= 0; a--)
						{

							if(before_component == result_ret.Rows[a].ItemArray[_Ix_Component].ToString() )
							{
								start_row = a;
								break;
							}

						} // end for a





						//for(int a = start_row; a < result_ret.Rows.Count; a++)

						for(int a = result_ret.Rows.Count - 1; a >= start_row; a--)
						{


							if(result_ret.Rows[a].ItemArray[_Ix_Material].ToString().Trim().Equals("") ) continue;



							dr = result_ret.NewRow();

							dr["COMPONENT"] = "";   
							dr["MATERIAL"] = "";  //result_ret.Rows[start_row].ItemArray[_Ix_Material].ToString();
							dr["SPEC_UNIT"] = ""; //result_ret.Rows[start_row].ItemArray[_Ix_SpecUnit].ToString();
							dr["COLOR"] = "";     //result_ret.Rows[start_row].ItemArray[_Ix_Color].ToString();
							dr["COMMON_YIELD_VALUE"] = "";  //result_ret.Rows[start_row].ItemArray[_Ix_CommonYieldValue].ToString();

							


							for(int j = arg_size_start_col; j <= arg_size_end_col; j++)
							{ 
								dr["SIZE_YIELD_VALUE" + j.ToString()] = "";   

							} // end for j


							//result_ret.Rows.Add(dr);
							result_ret.Rows.InsertAt(dr, a + 1);  

							dr_temp = result_ret.Rows[a + 1];


							// datarow 로 구성 후 업데이트 가능

							// 4 : "COMMON_YIELD_VALUE"
							dr_temp[4] = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString(); 

							for(int j = arg_size_start_col; j <= arg_size_end_col; j++)
							{ 
								
								dr_temp[5 + (j - arg_size_start_col)] = arg_dt.Rows[i].ItemArray[j].ToString();


							} // end for j   

 
 
						} // end for a (한 콤포넌트 아래 모든 자재에 일괄 적용)




					} 
					 
 
 

					before_numeric = true; 


					#endregion



				}
				catch
				{
				 

					// component row

					dr = result_ret.NewRow();

					dr["COMPONENT"] = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString();
					dr["MATERIAL"] = arg_dt.Rows[i].ItemArray[_Ix_Material].ToString();
					dr["SPEC_UNIT"] = arg_dt.Rows[i].ItemArray[_Ix_SpecUnit].ToString();
					dr["COLOR"] = arg_dt.Rows[i].ItemArray[_Ix_Color].ToString();
					dr["COMMON_YIELD_VALUE"] = arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString();

					
					


					for(int j = arg_size_start_col; j <= arg_size_end_col; j++)
					{ 
						dr["SIZE_YIELD_VALUE" + j.ToString()] = "";   

					} // end for j


					result_ret.Rows.Add(dr);

 


					//-------------------------------------------------------------------------------------------------------------------------------
					// yield value setting
					//-------------------------------------------------------------------------------------------------------------------------------
					double temp_1 = 0;
					int value_row = -1;
					string now_component = "";

					insert_row = -1;

					for(int j = i + 1; j < arg_dt.Rows.Count; j++)
					{

						try
						{
							temp_1 = Convert.ToDouble(arg_dt.Rows[j].ItemArray[arg_size_start_col].ToString()); 
							value_row = j;
							break;
						}
						catch
						{ 
						}
 
					}



					if(value_row != -1) 
					{


						for(int j = value_row - 1; j >= 0; j--)
						{

							if(! arg_dt.Rows[j].ItemArray[_Ix_Component].ToString().Trim().Equals("") )
							{
								insert_row = j;
								break;
							} 

						}

						insert_row = (insert_row == -1) ? i : insert_row;


						if(arg_dt.Rows[i].ItemArray[_Ix_Component].ToString().Equals("") )
						{
							now_component = before_component;
						}
						else
						{
							now_component = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString();
						}

						if(now_component == arg_dt.Rows[insert_row].ItemArray[_Ix_Component].ToString() )
						{


							// datarow 로 구성 후 업데이트 가능
							dr_temp = result_ret.Rows[result_ret.Rows.Count - 1];


							// 4 : "COMMON_YIELD_VALUE"
							//							if(! arg_dt.Rows[value_row].ItemArray[_Ix_Component].ToString().Equals("") )
							//							{ 
							//								dr_temp[4] = arg_dt.Rows[value_row].ItemArray[_Ix_Component].ToString(); 
							//							}

							dr_temp[4] = arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString();




							for(int j = arg_size_start_col; j <= arg_size_end_col; j++)
							{ 
		 
								dr_temp[5 + (j - arg_size_start_col)] = arg_dt.Rows[value_row].ItemArray[j].ToString();

							} // end for j  

						} // end if (equal component)


					} // end if(value_row != -1)
					//-------------------------------------------------------------------------------------------------------------------------------

 


					//------------------------------------------------------------------------------------------------------------------------------- 
					// before head data
					//-------------------------------------------------------------------------------------------------------------------------------
					if(! arg_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim().Equals("") )
					{
						before_component = arg_dt.Rows[i].ItemArray[_Ix_Component].ToString();
					} 

					if(! arg_dt.Rows[i].ItemArray[_Ix_Material].ToString().Trim().Equals("") )
					{
						before_material = arg_dt.Rows[i].ItemArray[_Ix_Material].ToString();
					} 

					if(! arg_dt.Rows[i].ItemArray[_Ix_SpecUnit].ToString().Trim().Equals("") )
					{
						before_spec_unit = arg_dt.Rows[i].ItemArray[_Ix_SpecUnit].ToString();
					} 

					if(! arg_dt.Rows[i].ItemArray[_Ix_Color].ToString().Trim().Equals("") )
					{
						before_color = arg_dt.Rows[i].ItemArray[_Ix_Color].ToString();
					} 

					if(! arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString().Trim().Equals("") )
					{
						before_common_yield_value = arg_dt.Rows[i].ItemArray[_Ix_CommonYieldValue].ToString();
					} 
					//-------------------------------------------------------------------------------------------------------------------------------
					

					before_numeric = false; 



				} // end try~catch
 
				

			} // end for i

			 

			return result_ret;


		}



		/// <summary>
		/// ExcelUpload_Step_7 : 7. 트리로 표현
		/// </summary>
		/// <param name="arg_step_1_dt"></param>
		/// <param name="arg_result_dt"></param>
		/// <param name="arg_size_start_col"></param>
		/// <param name="arg_size_end_col"></param>
		/// <param name="arg_allsize_row"></param>
		private void ExcelUpload_Step_7(DataTable arg_step_1_dt, 
			DataTable arg_result_dt, 
			int arg_size_start_col, 
			int arg_size_end_col, 
			int arg_allsize_row)
		{

			string parent_component = "";
			string component = "";

			int new_row_count = 0;


			  
			fgrid_Upload.Set_Grid("SBC_YIELD_UPLOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fgrid_Upload.Styles.Alternate.BackColor = Color.Empty;
			fgrid_Upload.AllowDragging = AllowDraggingEnum.None; 
			fgrid_Upload.DragMode = DragModeEnum.Manual;
			fgrid_Upload.DropMode = DropModeEnum.Manual;
			fgrid_Upload.Cols.Frozen = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START;


			//fgrid_Upload.Rows.Count = fgrid_Upload.Rows.Fixed;
			fgrid_Upload.Cols.Count = arg_result_dt.Columns.Count + 1;

 
			fgrid_Upload.Cols[(int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START - 1].Format = "#,##0.0000";

			for(int i = arg_size_start_col; i <= arg_size_end_col; i++)
			{
				fgrid_Upload[1, (i - arg_size_start_col) + (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START] 
					= arg_step_1_dt.Rows[arg_allsize_row].ItemArray[i].ToString();

				fgrid_Upload.Cols[(i - arg_size_start_col) + (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START].Width = 60;

				fgrid_Upload.Cols[(i - arg_size_start_col) + (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START].Format = "#,##0.0000";

			}

			for(int i = 0; i < arg_result_dt.Rows.Count; i++)
			{
				
				component = arg_result_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim();
  

				if(! component.Equals("") )
				{

					parent_component = component;

					fgrid_Upload.Rows.InsertNode(new_row_count + fgrid_Upload.Rows.Fixed, _LevelComponent);


					fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMPONENT] 
						= arg_result_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim();

					fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL] 
						= arg_result_dt.Rows[i].ItemArray[_Ix_Component].ToString().Trim();


					for(int j = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxEX_SPEC_UNIT; j < arg_result_dt.Columns.Count; j++)
					{
						fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, j + 1] = "";

					} // end for j



					fgrid_Upload.Rows[new_row_count + fgrid_Upload.Rows.Fixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;



					new_row_count++;


					 

				}





				fgrid_Upload.Rows.InsertNode(new_row_count + fgrid_Upload.Rows.Fixed, _LevelMaterial);

				fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMPONENT] = parent_component;  

				for(int j = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxEX_MATERIAL; j < arg_result_dt.Columns.Count; j++)
				{ 
				 
					

					if(j >= (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMMON_YIELD_VALUE)
					{

						double temp = 0;


						// 숫자형 아니면 
						try
						{
							temp = Convert.ToDouble(arg_result_dt.Rows[i].ItemArray[j].ToString().Trim());

							fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, j + 1] 
								= Convert.ToString( Math.Round( Convert.ToDouble(arg_result_dt.Rows[i].ItemArray[j].ToString().Trim() ), 4) );
 
						}
						catch
						{

							fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, j + 1] = arg_result_dt.Rows[i].ItemArray[j].ToString().Trim();
						}
						

					}
					else
					{
						fgrid_Upload[new_row_count + fgrid_Upload.Rows.Fixed, j + 1] = arg_result_dt.Rows[i].ItemArray[j].ToString().Trim();
					}


					
 

				} // end for j


				new_row_count++; 



			} // end for i

			
			 


			fgrid_Upload.Tree.Column = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL;
			fgrid_Upload.Tree.Style = TreeStyleFlags.Complete;
			fgrid_Upload.Tree.Show(1);  

		}


 

		#endregion 




		#endregion 

		#region Upload - Drag and Drop


		private int _SoruceCol = 0;



		private void fgrid_Upload_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{

			if(! chk_CheckInOut.Checked) return;

		
			// select the row
			HitTestInfo hti = fgrid_Upload.HitTest(e.X, e.Y);
			int index = hti.Row;

			if(index < fgrid_Upload.Rows.Fixed) return;

			// Only Dragging Material
			C1.Win.C1FlexGrid.Node node = fgrid_Upload.Rows[index].Node;
			
			if(!_NeomicsYN)
			{
				if(node.Level != _LevelMaterial) 
				{
					fgrid_Upload.ContextMenu = null;
					return;
				}
 
				
			}
			else
			{
				if(node.Level != _LevelMaterial_Neomics) 
				{
					fgrid_Upload.ContextMenu = null;
					return;
				}


			}



			if(e.Button.Equals(MouseButtons.Left) )
			{
				
				fgrid_Upload.ContextMenu = null;



				fgrid_Upload.DragMode = DragModeEnum.Manual;
				fgrid_Upload.DropMode = DropModeEnum.Manual; 
				

				fgrid_Upload.Select(index, 0, index, fgrid_Upload.Cols.Count - 1, false);
 
				// do drag drop
				DragDropEffects dd = fgrid_Upload.DoDragDrop(fgrid_Upload.Clip, DragDropEffects.Move);


			}
			else
			{
				fgrid_Upload.ContextMenu = cmenu_Upload;



				fgrid_Upload.DragMode = DragModeEnum.Automatic;
				fgrid_Upload.DropMode = DropModeEnum.Automatic;

			}


			
			_SoruceCol = hti.Column;
 

		}



		


		private void fgrid_Upload_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
		
			

			//if(! chk_CheckInOut.Checked) return;


			// select the row
			HitTestInfo hti = fgrid_Upload.HitTest(e.X, e.Y);
			int index = hti.Row; 
			if(index < fgrid_Upload.Rows.Fixed) return;


			// Only Dragging Material
			C1.Win.C1FlexGrid.Node node = fgrid_Upload.Rows[index].Node;
			
			if(!_NeomicsYN)
			{
				if(node.Level != _LevelMaterial) return;
			}
			else
			{
				if(node.Level != _LevelMaterial_Neomics) return;  

			}
			


			// check that we have the type of data we want
			if (e.Data.GetDataPresent(typeof(string)) )
			{
				e.Effect = DragDropEffects.Move;
			}



			
			//_SoruceCol = hti.Column; 




		}

		private void fgrid_Yield_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{

			//if(! chk_CheckInOut.Checked) return;

			// check that we have the type of data we want
			if (e.Data.GetDataPresent(typeof(string)) )
			{
				e.Effect = DragDropEffects.Move;
			}

		}

		private void fgrid_Yield_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
		

			//if(! chk_CheckInOut.Checked) return;


			// find the drop position 
			Point pt = fgrid_Yield.PointToClient(new Point(e.X, e.Y));
			HitTestInfo hti = fgrid_Yield.HitTest(pt.X, pt.Y);
			int index = hti.Row;
			//if (index < 0) index = fgrid_Yield.Rows.Count; // append
			//if (index < 1) index = 1;               // after fixed row

			if (index <= 1) index = fgrid_Yield.Rows.Count; // append


			// Only Drop Material Row
			C1.Win.C1FlexGrid.Node node = fgrid_Yield.Rows[index].Node;
			if(node.Level <= _CmpLevel) return;

  


			int source_row = fgrid_Upload.Selection.r1; 
			int source_col = _SoruceCol;

 
			// 채산값 세팅
			// 대표값, 사이즈별 값일 경우  dy

			// 우선순위 : 1. 대표값, 2. 사이즈별 값
			// -> 우선순위 변경(2007-09-03) : 1. 사이즈별 값, 2. 대표값
 

			if(fgrid_Yield[index, 0] != null && fgrid_Yield[index, 0].ToString() != "I")
			{
				fgrid_Yield[index, 0] = "U";
			}



           

			// 1. 채산 수정할 행 초기화 처리 
				
			for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
			{ 

				fgrid_Yield[index, i] = "-1"; 

			} // end for i




			 

			// 2. 사이즈 별 채산값 세팅
			string common_yield_value = "";
			int cs_size_start = 0;


			if(!_NeomicsYN)
			{
				common_yield_value = fgrid_Upload[source_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMMON_YIELD_VALUE].ToString().Trim();
				cs_size_start = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START;
			}
			else
			{
				common_yield_value = "";
				cs_size_start = (int)ClassLib.TBSBC_YIELD_NEOMICS.IxCS_SIZE_START;
			}  // end if(!_NeomicsYN)

			

			string cs_size = "";
			string now_cs_size = "";  
//			double temp_value = 0;



			#region 우선순위 변경 전 : 1. 대표값, 2. 사이즈별 값

//			try
//			{
//				temp_value = Convert.ToSingle(common_yield_value); 
//			}
//			catch
//			{
//				common_yield_value = "";
//			}
//
//
//
//			if(common_yield_value.Equals("") )
//			{
//
//				for(int i = cs_size_start; i < fgrid_Upload.Cols.Count; i++)
//				{
//
//					
//
//					cs_size = fgrid_Upload[1, i].ToString().Trim();
//
//
//
//					for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < fgrid_Yield.Cols.Count; j++)
//					{
//
//						now_cs_size = fgrid_Yield[1, j].ToString().Trim();
//
//						if(cs_size == now_cs_size)
//						{
//
//							fgrid_Yield[index, j] = (fgrid_Upload[source_row, i] == null) ? "-1" : fgrid_Upload[source_row, i].ToString().Trim();
//							break;
//						} 
//
//					}
//
// 
//
//
//				} // end for i
//
//
//			 
// 
//
//
//				// 3. 중간 미할당된 사이즈 채산값 세팅 (바로 전 사이즈 채산값으로 할당) 
//				// 4. 네오믹스에 사이즈 런 없는 경우 0 으로 세팅
//				if(_NeomicsYN) 
//				{
//
//					for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
//					{ 
//	
//						if(fgrid_Yield[index, i].ToString().Equals("-1") )
//						{
//							fgrid_Yield[index, i] = "0";
//						}  
//
//					} // end for i
//
// 
//
//
//				}
//				else
//				{
// 
//
//					int copy_col = 0;
//					
//
//					for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
//					{ 
//
//						if(fgrid_Yield[index, i].ToString().Equals("-1") )
//						{
//
//							
//							// 사이즈 첫 문대부터 채산서에 값이 없는 경우
//							if(i == (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START)  
//							{
//
//								for(int a = i; a < fgrid_Yield.Cols.Count; a++)
//								{
//									if(fgrid_Yield[index, a].ToString().Equals("-1") ) continue;
//
//									copy_col = a;
//									break;
//									
//								} // end for a
//
//
//								for(int a = i; a < copy_col; a++)
//								{
//									fgrid_Yield[index, a] = fgrid_Yield[index, copy_col].ToString();
//								}
//
//
//							} // end if 첫 문대 
//							else
//							{
//								fgrid_Yield[index, i] = fgrid_Yield[index, i - 1].ToString();
//
//							} // end if
//							
//
//						} // end for i 
//
//						
//	 
//
//					} // end for i
//
//
//
//
//				}
//
// 
//
//			}
//			else
//			{  
//
//
//				float set_yield_value = -1;
//				
//
//				try
//				{
//					set_yield_value = Convert.ToSingle( fgrid_Upload[source_row, source_col].ToString() ); 
//				}
//				catch
//				{
//					set_yield_value = Convert.ToSingle(common_yield_value);
//				}
//
//
//				for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < fgrid_Yield.Cols.Count; j++)
//				{ 
//
//					fgrid_Yield[index, j] = set_yield_value.ToString();
//				}
//
//
//
//			} // end if(common_yield_value.Equals("") )


			#endregion


			 

			for(int i = cs_size_start; i < fgrid_Upload.Cols.Count; i++)
			{

				

				cs_size = fgrid_Upload[1, i].ToString().Trim();



				for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < fgrid_Yield.Cols.Count; j++)
				{

					now_cs_size = fgrid_Yield[1, j].ToString().Trim();

					if(cs_size == now_cs_size)
					{

						fgrid_Yield[index, j] = (fgrid_Upload[source_row, i] == null) ? "-1" : fgrid_Upload[source_row, i].ToString().Trim();
						break;
					} 

				}




			} // end for i


			 
 


			// 3. 중간 미할당된 사이즈 채산값 세팅 (바로 전 사이즈 채산값으로 할당) 
			// 4. 네오믹스에 사이즈 런 없는 경우 0 으로 세팅
			if(_NeomicsYN) 
			{

				for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
				{ 

					if(fgrid_Yield[index, i].ToString().Equals("-1") )
					{
						fgrid_Yield[index, i] = "0";
					}  

				} // end for i 

			}
			else
			{


				int copy_col = 0;
				

				for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
				{ 

					if(fgrid_Yield[index, i].ToString().Equals("-1") )
					{

						
						// 사이즈 첫 문대부터 채산서에 값이 없는 경우
						if(i == (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START)  
						{

							for(int a = i; a < fgrid_Yield.Cols.Count; a++)
							{
								if(fgrid_Yield[index, a].ToString().Equals("-1") ) continue;

								copy_col = a;
								break;
								
							} // end for a


							for(int a = i; a < copy_col; a++)
							{
								fgrid_Yield[index, a] = fgrid_Yield[index, copy_col].ToString();
							}


						} // end if 첫 문대 
						else
						{
							fgrid_Yield[index, i] = fgrid_Yield[index, i - 1].ToString();

						} // end if
						

					} // end for i 

					
	

				} // end for i




			} // end if(_NeomicsYN) 

 
			int empty_count = 0;

			for(int i = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; i < fgrid_Yield.Cols.Count; i++)
			{ 

				if(fgrid_Yield[index, i].ToString().Equals("-1") )
				{
					empty_count++;		
				}
	

			} // end for i


			if(empty_count > 0)
			{


				float set_yield_value = -1;
				

				try
				{
					set_yield_value = Convert.ToSingle( fgrid_Upload[source_row, source_col].ToString() ); 
				}
				catch
				{
					set_yield_value = Convert.ToSingle(common_yield_value);
				}


				for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < fgrid_Yield.Cols.Count; j++)
				{ 

					fgrid_Yield[index, j] = set_yield_value.ToString();
				}


			}







		}

		#endregion 

		#region Upload - Popup menu
 

		private void cmenu_Upload_Popup(object sender, System.EventArgs e)
		{
			try
			{ 
				Set_Enable_Menuitem();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Upload_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}
 

		/// <summary>
		/// Set_Enable_Menuitem : 
		/// </summary>
		private void Set_Enable_Menuitem()
		{

			if(fgrid_Upload.Rows.Count < fgrid_Upload.Rows.Fixed) return;

			int sel_row = fgrid_Upload.Selection.r1;


			//-----------------------------------------------------------------------------------------------------------------------
			string comparison = fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMMON_YIELD_VALUE].ToString().Trim();

			double temp = 0;
			bool number_yn = true;

			try
			{
				temp = Convert.ToSingle(comparison);
				number_yn = true;
			}
			catch
			{
				number_yn = false;
			}


			if(number_yn)
			{
				menuItem_SetYield_Comparison.Enabled = true;
			}
			else
			{
				menuItem_SetYield_Comparison.Enabled = false;
			}
			//----------------------------------------------------------------------------------------------------------------------- 

 
 

		}



		private void menuItem_SetYield_Click(object sender, System.EventArgs e)
		{
			try
			{
				MenuItem src = sender as MenuItem;
				bool use_comparison = false;

				if(src.Equals(menuItem_SetYield_Comparison) )
				{
					use_comparison = true;
				}
				else if(src.Equals(menuItem_SetYield_Size) )
				{
					use_comparison = false;
				}


				Set_NewYield_FromExcel(use_comparison);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_SetYield_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}





		private void menuItem_SetJoint_Click(object sender, System.EventArgs e)
		{
			try
			{ 

				Set_JointMaterial_Symbol(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_SetJoint_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}




		private string _Upload_JointSymbol = "^";


		/// <summary>
		/// Set_JointMaterial_Symbol : 
		/// </summary>
		private void Set_JointMaterial_Symbol()
		{

			string upload_item = ""; 
			string upload_item_temp = ""; 

			if(fgrid_Upload.Rows.Count <= fgrid_Upload.Rows.Fixed) return;

			int sel_row = fgrid_Upload.Selection.r1;

			upload_item = fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString().Trim();  
			upload_item_temp = upload_item.Substring(0, 1).ToString().Trim();


			if(upload_item_temp != _Upload_JointSymbol)
			{
				upload_item = _Upload_JointSymbol + upload_item;
			}
			else
			{
				upload_item = upload_item.Substring(1).Trim();
			}


			fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL] = upload_item;


		}



 
		public string _Before_SGCd = "";
		



		/// <summary>
		/// Set_NewYield_FromExcel : 
		/// </summary>
		private void Set_NewYield_FromExcel(bool arg_use_comparison)
		{
			 
			int sel_row = fgrid_Upload.Selection.r1;

			if(sel_row < fgrid_Upload.Rows.Fixed) return; 

			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;

			//--------------------------------------------------------------------------------------------------
			//popup 창 파라미터 구성
			ClassLib.ComVar.Yield_CurrentDIV division = ClassLib.ComVar.Yield_CurrentDIV.AddExcel; 
			string factory = cmb_Factory.SelectedValue.ToString();

			//cmb_StyleCd
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string gender = cmb_StyleCd.Columns[2].Text;
			string model_name = cmb_StyleCd.Columns[4].Text; 
			
			string sg_cd_pop = _Before_SGCd.Trim();

			string template_tree_cd = _OnlyRawMat_TemplateCd;  
			string component_name = fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMPONENT].ToString();
			string item_name = fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString();
			string color_name = fgrid_Upload[sel_row, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOLOR].ToString(); 
			string yield_type = cmb_YieldType.SelectedValue.ToString();
			bool use_comparison = arg_use_comparison;
  

			string[] pop_parameter = new string[] { factory, style_cd, gender, model_name, sg_cd_pop, template_tree_cd, component_name, item_name, color_name, yield_type };

  
			//--------------------------------------------------------------------------------------------------
			  
//			Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter, use_comparison);
//			pop_form.ShowDialog();  
//
//			//------------------------------------------------------------------------- 
// 
//
//			if(pop_form._Cancel_Flag) return;
//
//			DataTable dt_yield = pop_form._DT_Return;
//			if(dt_yield == null || dt_yield.Rows.Count == 0) return;
//
//			pop_form.Dispose(); 


			//if(count == 0)

			if(pop_form == null)
			{

				pop_form = new Pop_Yield_Modify_withSRF(this, division, pop_parameter, use_comparison); 

				
			}
			else
			{
 

				pop_form._Parent_Form = this;
				pop_form._Division = division;

				pop_form._Factory = pop_parameter[0];
				pop_form._StyleCd = pop_parameter[1];
				pop_form._Gen = pop_parameter[2];
				pop_form._ModelName = pop_parameter[3]; 
				pop_form._SGCd = pop_parameter[4];
				pop_form._TemplateTreeCd = pop_parameter[5];
				pop_form._ComponentName = pop_parameter[6];
				pop_form._ItemName = pop_parameter[7];
				pop_form._ColorName = pop_parameter[8]; 
				pop_form._YieldType = pop_parameter[9];

				pop_form._UseComparison = arg_use_comparison;



				pop_form.Init_Form(); 


			}
			
			pop_form.Show();



//			// return table 모두 반제는 같으므로 0번행으로 반제 세팅
//			string sg_cd = dt_yield.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString().Trim();
//			string component_cd = dt_yield.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();
//
//			int insert_row = -1;
//
//			//sg
//			int findrow = fgrid_Yield.FindRow(sg_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD, false, true, false);
//			_Before_SGCd = sg_cd;
//
//			if(findrow == -1) return; 
//
//			insert_row = findrow;
//
//			C1.Win.C1FlexGrid.Node node = fgrid_Yield.Rows[findrow].Node;
//			if(node.Children != 0)  // component 있는 경우
//			{
//				//comonent
//				findrow = fgrid_Yield.FindRow(component_cd, fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD, false, true, false); 
//				
//				//해당 component 없으면 상위에 추가
//				insert_row = (findrow == -1) ? insert_row : findrow;
//			}

//			// 그리드에 추가된 행 표시
//			Apply_Grid(dt_yield, insert_row); 

		}



		#endregion 
 

		#endregion

		#region Neomics




		private void fgrid_Upload_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.Insert:
					case Keys.C: // ** copy
						Clipboard.SetDataObject(fgrid_Upload.Clip);
						break;
					case Keys.X: // ** cut
						Clipboard.SetDataObject(fgrid_Upload.Clip);
						CellRange rg = fgrid_Upload.Selection;
						rg.Data = null;
						break;
					case Keys.V: // ** paste
						IDataObject data = Clipboard.GetDataObject();
						if (data.GetDataPresent(typeof(string)))
						{
							fgrid_Upload.Select(fgrid_Upload.Row, fgrid_Upload.Col, fgrid_Upload.Rows.Count-1, fgrid_Upload.Cols.Count-1, false);
							fgrid_Upload.Clip = (string)data.GetData(typeof(string));
							fgrid_Upload.Select(fgrid_Upload.Row, fgrid_Upload.Col, false);
						}
						break;

					case Keys.F: // ** find

						int find_col = 0;

						if(_NeomicsYN)
						{
							find_col = (int)ClassLib.TBSBC_YIELD_NEOMICS.IxTREE;
						}
						else
						{
							find_col = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL;
						}

						FlexBase.Yield.Pop_Finder pop_form = new Pop_Finder(fgrid_Upload, find_col, find_col);
						pop_form.Location = new Point(MousePosition.X, MousePosition.Y);
						pop_form.Show();

						break;


				}
			}
		}
 




		private bool _NeomicsYN = false;

		private void btn_Neomics_Click(object sender, System.EventArgs e)
		{
			try
			{
 
			  
				this.Cursor = Cursors.WaitCursor;


				_NeomicsYN = true;


				fgrid_Upload.Set_Grid("SBC_YIELD_UPLOAD", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Upload.AllowDragging = AllowDraggingEnum.None; 
				fgrid_Upload.DragMode = DragModeEnum.Manual;
				fgrid_Upload.DropMode = DropModeEnum.Manual;
				fgrid_Upload.Styles.Alternate.BackColor = Color.Empty;
				fgrid_Upload.Cols.Frozen = (int)ClassLib.TBSBC_YIELD_NEOMICS.IxCS_SIZE_START;



				//size 세팅
				fgrid_Upload.Display_Size_ColHead(cmb_Factory.SelectedValue.ToString(), 
					cmb_StyleCd.SelectedValue.ToString().Replace("-", ""), 
					60,
					(int)ClassLib.TBSBC_YIELD_NEOMICS.IxCS_SIZE_START);


 

 
				DataTable dt_ret = Select_Neomics_Yield(); 

				  
				fgrid_Upload.Display_CrossTab(dt_ret, 
					(int)ClassLib.TBSBC_YIELD_NEOMICS.IxKEY1, 
					(int)ClassLib.TBSBC_YIELD_NEOMICS.IxKEY1, 
					(int)ClassLib.TBSBC_YIELD_NEOMICS.IxCOL_ORDER, 
					(int)ClassLib.TBSBC_YIELD_NEOMICS.IxYIELD_M, 
					true) ;


				
				fgrid_Upload.Tree.Column = (int)ClassLib.TBSBC_YIELD_NEOMICS.IxTREE;
				fgrid_Upload.Tree.Style = TreeStyleFlags.Complete;

				rad_Comp.Checked = true;
				fgrid_Upload.Tree.Show(_CmpLevel);



				int level = 0;

				for(int i = fgrid_Upload.Rows.Fixed; i < fgrid_Upload.Rows.Count; i++)
				{
					
					level = Convert.ToInt32(fgrid_Upload[i, (int)ClassLib.TBSBC_YIELD_NEOMICS.IxLEVEL].ToString() );

					switch(level)
					{ 		
						case 1:  
							fgrid_Upload.GetCellRange(i, 1, i, fgrid_Upload.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st; 
							break;

						case 2:  
							fgrid_Upload.GetCellRange(i, 1, i, fgrid_Upload.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd; 
							break;
 
				 
					} // end switch

				}




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Neomics_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}





		private DataTable Select_Neomics_Yield()
		{

			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_NEOMICS_YIELD";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_StyleCd.SelectedValue.ToString().Replace("-", ""); 
			MyOraDB.Parameter_Values[2] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}



		
		private void fgrid_Upload_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			int cs_size_start = 0;


			if(_NeomicsYN)
			{
				cs_size_start = (int)ClassLib.TBSBC_YIELD_NEOMICS.IxCS_SIZE_START;
			}
			else
			{
				cs_size_start = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START;
			}
		
			

			if(e.Col < cs_size_start) return;

			for(int i = cs_size_start; i < fgrid_Upload.Cols.Count; i++)
			{
				fgrid_Upload.Cols[i].Width = fgrid_Upload.Cols[e.Col].Width;
			}



		}
 



	
		#endregion  

		#region Check In/ Out

 

		private void chk_CheckInOut_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


				this.Cursor = Cursors.WaitCursor;


				if(chk_CheckInOut.Checked)
				{
					Run_Check_In(); 

				}
				else
				{ 
					Run_Check_Out();
				
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_CheckInOut_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		

		// 체크 아웃 실패 되었을때, 다시 체크 인 표시 해 주고, 이벤트 태우지 않기 위함
		//private bool _FromCheckOut = false;

		private bool _CheckInFail = false;
		private bool _CheckOutFail = false;

		private string _CheckInSeq = "1";


		private void Run_Check_In()
		{
			

			if( _CheckOutFail ) return;
 

			string division = "I"; // In
			string factory = cmb_Factory.SelectedValue.ToString();
			string stylecd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "main (yield register)";



			#region Check in 1)
			 
			// 1. check in
			// 로그인 이름 : 사용가능
			// 다른 이름 : 사용 불가능 
 

//			// 1) job factory Webservice 로 변경
//			// 2) job factory Checkin table insert 처리
//			// 3) user factory Webservice 로 변경
//			// 4) 2) 성공 시 user factory Checkin table insert 처리
//			// 5) 4) 성공 시 최종 Checkin 성공
//
//
//
//			// 1) job factory Webservice 로 변경  
//			string websvc_factory = "";
//
//			
//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
//			{
//				websvc_factory = factory;
//			}
//			else
//			{
//				websvc_factory = ClassLib.ComVar.DSFactory;
//			}
//
//			
//			
//
//			// 2) job factory Checkin table insert 처리
//			string checkin_user = Check_InOut_1(division, factory, stylecd, checkuser, websvc_factory);
//
//
//			// 3) user factory Webservice 로 변경 
//			websvc_factory = ClassLib.ComVar.This_Factory;
//
//
//			// 4) 2) 성공 시 user factory Checkin table insert 처리
//			if(checkin_user.Trim() != ClassLib.ComVar.This_User.Trim() )
//			{
//
//				Control_Enable(false); 
//	 
//				_CheckInFail = true;
//
//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user.Trim(); 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//
//				return;
//
//			}
//
//
//
//
//			// 5) 4) 성공 시 최종 Checkin 성공
//			checkin_user = Check_InOut_1(division, factory, stylecd, checkuser, websvc_factory);
//
//			if(checkin_user.Trim() == ClassLib.ComVar.This_User.Trim() )
//			{
//
//				Control_Enable(true); 
// 
//				_CheckInFail = false;
//				ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//
//
//
//			}
//			else
//			{
//
//				Control_Enable(false); 
//	 
//				_CheckInFail = true;
//
//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user.Trim(); 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//
//
//			}

 

			#endregion

			#region Check in 2)
 
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	
//			// 1) job factory Webservice 로 변경
//			string websvc_factory = ""; 
//			
//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
//			{
//				websvc_factory = factory;
//			}
//			else
//			{
//				websvc_factory = ClassLib.ComVar.DSFactory;
//			} 
//				
//			// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
//			// 3) user factory Webservice 로 변경
//			DataTable dt_job = Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
//			websvc_factory = ClassLib.ComVar.This_Factory;
//			
//
//			string job_checkin_seq = "";
//			string job_checkin_user = "";
//
//			if(dt_job == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//
//			}
//			else
//			{
//				job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
//				job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
//			} 
//			 
//
//			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
//			DataTable dt_user = Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
//
//			string user_checkin_seq = "";
//			string user_checkin_user = "";
//
//			if(dt_user == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//
//			}
//			else
//			{
//				user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
//				user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
//			}
//
//
//
//			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
//
//			//**********************************************//
//			//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
//			//**********************************************//
// 
//			if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
//			{ 
//				
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			} 
//
//
//			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
//			string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
//			_CheckInSeq = checkinseq;
//
//
//			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
//			{
//				websvc_factory = factory;
//			}
//			else
//			{
//				websvc_factory = ClassLib.ComVar.DSFactory;
//			} 
//
//			
//			// 8) job factory Checkin table insert 처리
//			// 9) user factory Webservice 로 변경
//			DataSet ds_job = Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
//			websvc_factory = ClassLib.ComVar.This_Factory; 
//
//
//			if(ds_job == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			}
//			
//
//			
//			// 10) 8) 성공 시 user factory Checkin table insert 처리 
//			DataSet ds_user = Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
//
//			if(ds_user == null)
//			{
//
//				Control_Enable(false); 
//			
//				_CheckInFail = true;
//	
//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
//				chk_CheckInOut.CheckState = CheckState.Unchecked; 
//	
//				return;
//
//			}
//
//
//			// 11) 10) 성공 시 최종 Checkin 성공
//			Control_Enable(true); 
//		
//			_CheckInFail = false;
//			ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
//
// 


			#endregion

			#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	 
			if(_Checkin_Cancel)   // local 만 체크
			{
				Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
			}
			else  // remote, local 모두 체크
			{
				Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
			}



			#endregion


			

			

		}

 
		/// <summary>
		/// Run_Check_In_RemoteLocal : 정상적인 Checkin (remote, local 모두 체크)
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_RemoteLocal(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
 
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	
			try
			{
				// 1) job factory Webservice 로 변경
				string websvc_factory = ""; 
			
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 
				
				// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				// 3) user factory Webservice 로 변경
				DataTable dt_job = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				} 
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}



				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패 
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + job_checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				} 


				if (!user_checkin_user.Trim().Equals("") && !user_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()))
				{
				
					Control_Enable(false); 
			
					_CheckInFail = true;

					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + user_checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

					
				}



				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;


				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 

			
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				DataSet ds_job = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}
			

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				Control_Enable(true); 
		
				_CheckInFail = false;
				ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
 
			}
			catch
			{
				return false;
			}



		}



		/// <summary>
		/// Run_Check_In_Local : Line 이상있는 경우, Checkin Local만 시도
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_Local(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{

			
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	 
				
			try
			{
				// 3) user factory Webservice 로 변경 
				string websvc_factory = ""; 
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "0";
				string job_checkin_user = ClassLib.ComVar.This_User.Trim();

			
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}




				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  

				job_checkin_user = user_checkin_user;
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				} 




				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

 
		 
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

					Control_Enable(false); 
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					chk_CheckInOut.CheckState = CheckState.Unchecked; 
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				Control_Enable(true); 
		
				_CheckInFail = false;
				ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;

			}
			catch
			{
				return false;
			}
  


		}


		
		private void Run_Check_Out()
		{
			

			if( _CheckInFail ) return;

			//-----------------------------------------------------------------------------------------------
			//저장되지 않은 데이터 있을 때 조회하면 경고 메시지 표시
			bool exist_modify = Check_NotSave_Data("Check Out");
			if(exist_modify) 
			{
				//_FromCheckOut = true;

				_CheckOutFail = true;

				chk_CheckInOut.CheckState = CheckState.Checked;

				return;
			}
			//-----------------------------------------------------------------------------------------------



			string division = "O"; // Out
			string factory = cmb_Factory.SelectedValue.ToString();
			string stylecd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "check out";
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Save_Check_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{
 
				Control_Enable(true);  

				_CheckOutFail = true;

				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{

				Control_Enable(false); 

				_CheckOutFail = false;

				ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}



		}


		#region Check in 1)


//		/// <summary>
//		/// Check_InOut : 
//		/// </summary>
//		/// <param name="arg_division"></param>
//		/// <param name="arg_factory"></param>
//		/// <param name="arg_style_cd"></param>
//		/// <param name="arg_checkuser"></param>
//		/// <param name="arg_job_factory"></param>
//		/// <returns>true : Check In 성공, false : Read Only 처리</returns>
//		public static bool Check_InOut(string arg_division, string arg_factory, string arg_style_cd, string arg_checkuser, string arg_job_factory)
//		{
//
//
//			try
//			{
//
//				DataSet ds_ret;  
//				COM.OraDB LMyOraDB = new COM.OraDB(); 
//
//
//				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory); 
//
// 
//				LMyOraDB.ReDim_Parameter(5); 
// 
//				if(arg_division == "I")
//				{
//					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_TEST.SELECT_SBC_YIELD_CHECKIN"; 
//					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN.SELECT_SBC_YIELD_CHECKIN"; 
//				}
//				else if(arg_division == "O")
//				{
//					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_TEST.SELECT_SBC_YIELD_CHECKOUT"; 
//					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN.SELECT_SBC_YIELD_CHECKOUT"; 
//				}
//
//  
//				LMyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
//				LMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
//				LMyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
//				LMyOraDB.Parameter_Name[3] = "ARG_CHECKIN_USER";
//				LMyOraDB.Parameter_Name[4] = "OUT_CURSOR";
// 
//				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
//			  
//				LMyOraDB.Parameter_Values[0] = arg_division;
//				LMyOraDB.Parameter_Values[1] = arg_factory;
//				LMyOraDB.Parameter_Values[2] = arg_style_cd; 
//				LMyOraDB.Parameter_Values[3] = arg_checkuser;
//				LMyOraDB.Parameter_Values[4] = ""; 
//
//
//				LMyOraDB.Add_Select_Parameter(true); 
//				ds_ret = LMyOraDB.Exe_Select_Procedure();
//
//
//
//				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
//
//
//				if(ds_ret == null) return false; 
//				
//				if(ds_ret.Tables[LMyOraDB.Process_Name].Rows[0].ItemArray[0].ToString() == "Y")
//				{
//					return true;
//				}
//				else
//				{
//					return false;
//				}
//
//			}
//			catch
//			{
//				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
//				return false;
//			}
//
//		}

 



		
//		/// <summary>
//		/// Check_InOut : 
//		/// </summary>
//		/// <param name="arg_division"></param>
//		/// <param name="arg_factory"></param>
//		/// <param name="arg_style_cd"></param>
//		/// <param name="arg_checkuser"></param>
//		/// <param name="arg_job_factory"></param>
//		/// <returns></returns>
//		public static string Check_InOut_1(string arg_division, 
//			string arg_factory, 
//			string arg_style_cd, 
//			string arg_checkuser, 
//			string arg_job_factory)
//		{
//
//
//			try
//			{
//
//				DataSet ds_ret;  
//				COM.OraDB LMyOraDB = new COM.OraDB();
//
//
//				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory); 
//
//
// 
//				LMyOraDB.ReDim_Parameter(5); 
// 
//				if(arg_division == "I")
//				{
//					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_TEST.SELECT_SBC_YIELD_CHECKIN_1"; 
//					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN.SELECT_SBC_YIELD_CHECKIN_1"; 
//				}
//				else if(arg_division == "O")
//				{
//					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_TEST.SELECT_SBC_YIELD_CHECKOUT_1"; 
//					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN.SELECT_SBC_YIELD_CHECKOUT_1"; 
//				}
//
//  
//				LMyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
//				LMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
//				LMyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
//				LMyOraDB.Parameter_Name[3] = "ARG_CHECKIN_USER";
//				LMyOraDB.Parameter_Name[4] = "OUT_CURSOR";
// 
//				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
//				LMyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
//			  
//				LMyOraDB.Parameter_Values[0] = arg_division;
//				LMyOraDB.Parameter_Values[1] = arg_factory;
//				LMyOraDB.Parameter_Values[2] = arg_style_cd; 
//				LMyOraDB.Parameter_Values[3] = arg_checkuser;
//				LMyOraDB.Parameter_Values[4] = ""; 
//
//
//				LMyOraDB.Add_Select_Parameter(true); 
//				ds_ret = LMyOraDB.Exe_Select_Procedure();
//
//
//
//				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
//
//
//
//				if(ds_ret == null) return ""; 
//				return ds_ret.Tables[LMyOraDB.Process_Name].Rows[0].ItemArray[0].ToString();
//
//
//				// 1. check in
//				// 로그인 이름 : 사용가능
//				// 다른 이름 : 사용 불가능
//
//				// 2. check out
//				// Y : 가능
//				// N : 불가능
//
//
//
//			}
//			catch
//			{
//				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
//				return ""; 
//			}
//
//		}

 


		#endregion 

		#region Check in 2)


		/// <summary>
		/// Scan_Check_InOut : 
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_checkuser"></param>
		/// <param name="arg_job_factory"></param>
		/// <returns></returns>
		public static DataTable Scan_Check_InOut(string arg_factory, 
			string arg_style_cd, 
			string arg_checkuser, 
			string arg_job_factory)
		{


			try
			{

				DataSet ds_ret;  
				COM.OraDB LMyOraDB = new COM.OraDB();


				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory); 


 
				LMyOraDB.ReDim_Parameter(4); 
 
				LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SELECT_SBC_YIELD_CHECKIN_MAIN";   
   
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				LMyOraDB.Parameter_Name[2] = "ARG_CHECKIN_USER";
				LMyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[3] = (int)OracleType.Cursor; 
			   
				LMyOraDB.Parameter_Values[0] = arg_factory;
				LMyOraDB.Parameter_Values[1] = arg_style_cd; 
				LMyOraDB.Parameter_Values[2] = arg_checkuser;
				LMyOraDB.Parameter_Values[3] = ""; 


				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure(); 


				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);



				if(ds_ret == null) return null; 
				return ds_ret.Tables[LMyOraDB.Process_Name];

				// 컬럼 0 : Next Checkin Sequence
				// 컬럼 1 : Checkin User
 

			}
			catch
			{
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
				return null; 
			}

		}



		/// <summary>
		/// Save_Check_InOut : 
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_checkinseq"></param>
		/// <param name="arg_checkinuser"></param>
		/// <param name="arg_remarks"></param>
		/// <param name="arg_job_factory"></param>
		/// <returns></returns>
		public static DataSet Save_Check_InOut(string arg_division, 
			string arg_factory, 
			string arg_style_cd, 
			string arg_checkinseq,
			string arg_checkinuser, 
	        string arg_remarks,
			string arg_job_factory)
		{


			try
			{

				DataSet ds_ret;  
				COM.OraDB LMyOraDB = new COM.OraDB();
 

				ClassLib.ComFunction.Change_WebService_URL(arg_job_factory);  

 
				LMyOraDB.ReDim_Parameter(6); 
 
				if(arg_division == "I")
				{
					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN_MAIN";  
					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKIN_MAIN_R";  
				}
				else if(arg_division == "O")
				{
					//LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT_MAIN";  
					LMyOraDB.Process_Name = "PKG_SBC_YIELD_CHECKIN_SEQ.SAVE_SBC_YIELD_CHECKOUT_MAIN_R";  
				}

  
				LMyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				LMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				LMyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				LMyOraDB.Parameter_Name[3] = "ARG_CHECKIN_SEQ";
				LMyOraDB.Parameter_Name[4] = "ARG_CHECKIN_USER";
				LMyOraDB.Parameter_Name[5] = "ARG_REMARKS";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			  
				LMyOraDB.Parameter_Values[0] = arg_division;
				LMyOraDB.Parameter_Values[1] = arg_factory;
				LMyOraDB.Parameter_Values[2] = arg_style_cd; 
				LMyOraDB.Parameter_Values[3] = arg_checkinseq;
				LMyOraDB.Parameter_Values[4] = arg_checkinuser; 
				LMyOraDB.Parameter_Values[5] = arg_remarks; 


				LMyOraDB.Add_Modify_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Modify_Procedure(); 


				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);



				if(ds_ret == null) return null; 
				return ds_ret;
 

			}
			catch
			{
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory); 
				return null; 
			}

		}


		#endregion  

		
		
	

		#endregion

		#region Backup/ Restore/ Status check


		#region Event


		private void btn_Backup_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;


				this.Cursor = Cursors.WaitCursor;


				Run_Backup(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		private void btn_Restore_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
				if(! chk_CheckInOut.Checked) return;

				this.Cursor = Cursors.WaitCursor;


				Run_Restore(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void btn_StatusCheck_Click(object sender, System.EventArgs e)
		{
		
			try
			{

//				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
//				if(! chk_CheckInOut.Checked) return;

				this.Cursor = Cursors.WaitCursor;


				Run_Status_Check(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Status Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		

		#endregion

		#region Backup



		private string _BackupDirectoryName = null;
		private string _BackupFileName = null;


		private void Run_Backup()
		{



			bool exist_modify = Check_NotSave_Data("Continue Backup"); 
			
			if(exist_modify) // No
			{
				return;
			}
			else // Yes :  backup 진행한다는 의미
			{


				Save_Yield(false);


				// 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
				string start_path = Application.StartupPath.ToString() +  "\\" + "Yield_Backup" + "\\";
				string directory_name = cmb_Factory.SelectedValue.ToString() + "_" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				string directory_full_name = start_path + directory_name;


				if( ! System.IO.Directory.Exists(directory_full_name) )
				{
					System.IO.Directory.CreateDirectory(directory_full_name); 
				}



				_BackupDirectoryName = directory_full_name;



				// xml 생성
				bool run_flag = Run_XML_Create();

				if(run_flag)
				{

					// zip 생성, xml 삭제
					run_flag = Run_Zip_Create();

					if(run_flag)
					{
						ClassLib.ComFunction.User_Message("Backup Complete.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						ClassLib.ComFunction.User_Message("ZIP Generate Failed.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


				}
				else
				{
					ClassLib.ComFunction.User_Message("XML Generate Failed.", "Run Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}



			} // end if backup 실행





		}



		/// <summary>
		/// Run_XML_Create : xml 생성
		/// </summary>
		/// <returns></returns>
		private bool Run_XML_Create()
		{


				
			try
			{

				
				System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
				string v_xmlfilename = null;
				string v_xmlfullname = null;


				System.Xml.XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "", "yes");
				doc.PrependChild(dec);

				System.IO.StringWriter writerString = new System.IO.StringWriter();
				System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(writerString);


				//XML 파일이름
				string factory = cmb_Factory.SelectedValue.ToString();
				string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");

				v_xmlfilename = factory + "_" + style_cd + System.DateTime.Now.ToString("_yyyyMMdd_HHmmss") + "_" + System.DateTime.Now.Millisecond.ToString("000") + ".XML";

		
				//XML 파일생성, Document Start
				v_xmlfullname = _BackupDirectoryName + "\\" + v_xmlfilename;

				_BackupFileName = v_xmlfullname;



							
				writer = new XmlTextWriter(v_xmlfullname, System.Text.Encoding.Unicode);
				writer.WriteStartDocument(true);

				//XML File 시작 루트명
				writer.WriteStartElement( "CSInc", "" );




				string table_name = "";
				string where = "";
				DataSet ds_ret = null;
				bool xml_create_flag = false;


				
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				table_name = "SBC_YIELD_INFO";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				where = @"FACTORY = '" + cmb_Factory.SelectedValue.ToString() + @"' AND STYLE_CD = '" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + @"' " + @" AND COMPONENT_CD LIKE 'C%' ";
				// DB 로 부터 실제 데이터 추출
				ds_ret= Get_Backup_Data(table_name, where);

				if(ds_ret == null)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false;

				}


				// 데이터 값들을 엘리먼트로 생성
				xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);

				if(! xml_create_flag)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false; 

				}
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				table_name = "SBC_YIELD_VALUE";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				// DB 로 부터 실제 데이터 추출
				ds_ret= Get_Backup_Data(table_name, where);

				if(ds_ret == null)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false;

				}



				// 데이터 값들을 엘리먼트로 생성
				xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);


				if(! xml_create_flag)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false; 

				}
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				table_name = "SBC_YIELD_HISTORY";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				// DB 로 부터 실제 데이터 추출
				ds_ret= Get_Backup_Data(table_name, where);

				if(ds_ret == null)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false;

				}



				// 데이터 값들을 엘리먼트로 생성
				xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);

				if(! xml_create_flag)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false; 

				}
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------


				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				table_name = "SBC_YIELD_STATUS";
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
				where = @"FACTORY = '" + cmb_Factory.SelectedValue.ToString() + @"' AND STYLE_CD = '" + cmb_StyleCd.SelectedValue.ToString().Replace("-", "") + @"' ";
				// DB 로 부터 실제 데이터 추출
				ds_ret= Get_Backup_Data(table_name, where);

				if(ds_ret == null)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false;

				}



				// 데이터 값들을 엘리먼트로 생성
				xml_create_flag = Set_Backup_Data_XML_Element(writer, ds_ret, table_name, where);
				
				if(! xml_create_flag)
				{

					writer.Close();

					// xml 삭제
					if(File.Exists(_BackupFileName) )
					{
						File.Delete(_BackupFileName);
					}

					return false; 

				}
				//-----------------------------------------------------------------------------------------------------------------------------------------------------------------




				writer.Close();




				return true;
			}
			catch
			{
				return false;
			}


		}

		

		/// <summary>
		/// Get_Backup_Data : DB 로 부터 실제 데이터 추출
		/// </summary>
		/// <param name="arg_table_name"></param>
		/// <param name="arg_where"></param>
		/// <returns></returns>
		private DataSet Get_Backup_Data(string arg_table_name, string arg_where)
		{

			
			try
			{
				
				string sql = "   SELECT * " 
								+ "    FROM "+ arg_table_name
								+ "  WHERE "+ arg_where;

				DataSet ds_ret = MyOraDB.Exe_Select_Query(sql);


				if(ds_ret == null)
				{
					return null;
				}
				else
				{
					return ds_ret;
				}

			}
			catch
			{
				return null;
			}


		}




		/// <summary>
		/// Set_Backup_Data_XML_Element : 데이터 값들을 엘리먼트로 생성
		/// </summary>
		/// <param name="arg_writer"></param>
		/// <param name="arg_ds_ret"></param>
		/// <param name="arg_table_name"></param>
		/// <param name="arg_where"></param>
		/// <returns></returns>
		private bool Set_Backup_Data_XML_Element(System.Xml.XmlTextWriter arg_writer, DataSet arg_ds_ret, string arg_table_name, string arg_where)
		{

			try
			{

				arg_writer.WriteStartElement(arg_table_name, "" );
				arg_writer.WriteAttributeString("WHERE",  arg_where);


				// 데이터 값들을 엘리먼트로 생성
				for(int i=0;i < arg_ds_ret.Tables[0].Rows.Count ; i++)
				{
								
					arg_ds_ret.Tables[0].TableName = arg_table_name.ToString();
	
					arg_writer.WriteStartElement(arg_table_name, "" );
			
					for(int j=0; j<arg_ds_ret.Tables[0].Columns.Count; j++)
					{
						
						string v_fieldName = arg_ds_ret.Tables[0].Columns[j].ColumnName.ToString();
						string v_fieldType = arg_ds_ret.Tables[0].Columns[j].DataType.ToString();
						string v_fieldData = arg_ds_ret.Tables[0].Rows[i].ItemArray[j].ToString() == null ? "null" : arg_ds_ret.Tables[0].Rows[i].ItemArray[j].ToString();
									
						arg_writer.WriteElementString(v_fieldName, v_fieldType, v_fieldData);
					}

					arg_writer.WriteEndElement();
					arg_writer.Flush();

				} // end for i


				
				arg_writer.WriteEndElement();
				arg_writer.Flush();

				return true;
			}
			catch
			{
				return false;
			}


		}





		/// <summary>
		/// Run_Zip_Create : zip 생성, xml 삭제
		/// </summary>
		/// <returns></returns>
		private bool Run_Zip_Create()
		{

			try
			{

				//  zip 생성
				C1.C1Zip.C1ZipFile zipFile  = new C1.C1Zip.C1ZipFile();
				zipFile.Create(_BackupFileName.Replace(".XML", "") + ".ZIP");
				zipFile.Entries.Add(_BackupFileName); 


				// xml 삭제
				if(File.Exists(_BackupFileName) )
				{
					File.Delete(_BackupFileName);
				}



				return true;

			}
			catch
			{
				return false;
			}


		}





		#endregion

		#region Restore


		private void Run_Restore()
		{

			string factory = cmb_Factory.SelectedValue.ToString();
			string style_cd = cmb_StyleCd.SelectedValue.ToString(); //.Replace("-", "");
			string style_name = cmb_StyleCd.Columns[1].Text;


			FlexBase.Yield.Pop_Yield_Backup_Restore pop_form = new Pop_Yield_Backup_Restore(factory, style_cd, style_name);
			pop_form.ShowDialog();


			//--------------------------------------------------------------------------
			// 복구 완료 후 xml 파일은 모두 삭제 처리
			//--------------------------------------------------------------------------
			// 실행 폴더 내에 "Factory_StyleCode" 형태의 폴더생성해서,  backup 파일보관
			string start_path = Application.StartupPath.ToString() +  "\\" + "Yield_Backup" + "\\";
			string directory_name = factory + "_" + style_cd.Replace("-", "");
			string directory_full_name = start_path + directory_name;


			if( ! System.IO.Directory.Exists(directory_full_name) )
			{
				System.IO.Directory.CreateDirectory(directory_full_name); 
			}

 

			
			if( Directory.Exists(directory_full_name) )
			{

				ArrayList extensions_array = new ArrayList(); 
				extensions_array.Add(".XML");
				RecursiveFileExplorer.FileExplorer file_explorer = new RecursiveFileExplorer.FileExplorer(directory_full_name, extensions_array, true); 
					
				if(file_explorer.FileList.Count > 0)
				{

					DirectoryInfo dir = new DirectoryInfo(directory_full_name);   

					foreach ( FileSystemInfo entry in dir.GetFileSystemInfos() )
					{

						if(entry.Extension == "" || entry.Extension != ".XML") continue;

						if (File.Exists(entry.FullName))
						{
							File.Delete(entry.FullName);
						}

							

					} // end foreach
 
				} // end if(file_explorer.FileList.Count > 0) 

			} // if( Directory.Exists(  ) )


			//--------------------------------------------------------------------------






			if(pop_form._Cancel_Flag) return;


//			string message = "Do you want to display restore data now ?"; 
//			DialogResult result = ClassLib.ComFunction.User_Message(message, "Run Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
//
//			if(result == DialogResult.Yes)
//			{
//				Search_Yield();
//			}
//			else
//			{
//				return;
//			}



			Search_Yield();




			
		}



		#endregion

		#region Status check


		/// <summary>
		/// Run_Status_Check : 
		/// </summary>
		private void Run_Status_Check()
		{


			FlexBase.Yield.Pop_Yield_Check_Status pop_form = new Pop_Yield_Check_Status();
			pop_form.Show();


		}

		



		#endregion


		#endregion
		
		
		
		

	}
}

