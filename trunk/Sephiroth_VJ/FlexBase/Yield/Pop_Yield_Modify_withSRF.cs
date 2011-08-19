using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
 

namespace FlexBase.Yield
{
	public class Pop_Yield_Modify_withSRF : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.Panel pnl_BB1;
		private System.Windows.Forms.GroupBox groupBox3;
		public COM.FSP fgrid_YieldValue;
		private System.Windows.Forms.Panel pnl_BB2;
		private System.Windows.Forms.Panel pnl_BL;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.TabPage tabPage_SRF;
		private COM.FSP fgrid_SRF;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbl_Part;
		private System.Windows.Forms.Label lbl_SRF;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_BOMTemp;
		private System.Windows.Forms.Panel pnl_BR;
		private System.Windows.Forms.Label lbl_SG;
		private System.Windows.Forms.Label lbl_Component;
		private System.Windows.Forms.TextBox txt_YieldValue;
		private System.Windows.Forms.ContextMenu cmenu_BOMTemp;
		private System.Windows.Forms.MenuItem menuItem_ItemList;
		private System.Windows.Forms.MenuItem menuItem_Separator;
		private System.Windows.Forms.MenuItem menuItem_DeleteRawMat;
		private System.Windows.Forms.Panel pnl_Tab_B;
		private System.Windows.Forms.ContextMenu cmenu_SRF;
		private System.Windows.Forms.MenuItem menuItem_AllSelect;
		private System.Windows.Forms.MenuItem menuItem_AllDeselect;
		private System.Windows.Forms.MenuItem menuItem_SaveComp;
		private System.Windows.Forms.MenuItem menuItem_Separator1;
		private System.Windows.Forms.Label lbl_YieldValue;
		public System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.Label lbl_BOM;
		public System.Windows.Forms.TextBox txt_SRF;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.MenuItem menuItem_SetSizeYN;
		private System.Windows.Forms.Label btn_FindComp;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.Label btn_AddNew_Comp;
		private System.Windows.Forms.TextBox txt_Component;
		private System.Windows.Forms.TextBox txt_BOMTemp;
		private C1.Win.C1List.C1Combo cmb_SRFNo;
		private C1.Win.C1List.C1Combo cmb_BOMID;
		private C1.Win.C1List.C1Combo cmb_Part;
		private C1.Win.C1List.C1Combo cmb_SGCd;
		private C1.Win.C1List.C1Combo cmb_Component;
		private C1.Win.C1List.C1Combo cmb_BOMTemp;
		public System.Windows.Forms.ImageList img_Button;
		public System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_SearchTemp;
		private System.Windows.Forms.Label btn_CopyTemp;
		private System.Windows.Forms.Label btn_AddRawMat;
		public System.Windows.Forms.Label btn_CreateProcCd;
		private System.Windows.Forms.Label btn_SRF_Batch;
		private System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label btn_SRF_Move;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.CheckBox chk_CreateSizeByValue;
		private System.Windows.Forms.CheckBox chk_CreateSizeBySize;
		private System.Windows.Forms.CheckBox chk_CreateSizeByDB;
		public COM.FSP fgrid_BOMTemp;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_Yield_Modify_withSRF()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}




		//internal struct _DT_Return_Key
		public struct _DT_Return_Key
		{
			public string _RowID;
			public string _Templatekey;
			public string _ItemCd;
			public string _SpecCd;
			public string _ColorCd;

		}

 
		//private FlexBase.Yield.Form_BC_Yield_withExcel _Parent_Form; // = new Form_BC_Yield_withExcel(); 



//		private ClassLib.ComVar.Yield_CurrentDIV _Division;
//		private string _Factory = "";
//		private string _StyleCd = "", _Gen = "", _ModelName = "";
//		private string _SGCd = "", _ComponentCd = "";
//		private string _TemplateSeq = "", _TemplateTreeCd = "";
//		private string _YieldType = "";

//		private string _ComponentName = "";
//		private string _ItemName = "";
//		private string _ColorName = "";
//		private bool _UseComparison;


		public FlexBase.Yield.Form_BC_Yield_withExcel _Parent_Form; 
		public ClassLib.ComVar.Yield_CurrentDIV _Division = ClassLib.ComVar.Yield_CurrentDIV.AddCmp;
		public string _Factory = "";
		public string _StyleCd = "", _Gen = "", _ModelName = "";
		public string _SGCd = "", _ComponentCd = "";
		public string _TemplateSeq = "", _TemplateTreeCd = "";
		public string _YieldType = "";
		public string _ComponentName = "";
		public string _ItemName = "";
		public string _ColorName = "";
		public bool _UseComparison;



		public Pop_Yield_Modify_withSRF(FlexBase.Yield.Form_BC_Yield_withExcel arg_parent_form, 
										ClassLib.ComVar.Yield_CurrentDIV arg_div, 
										string[] arg_parameter) 
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Parent_Form = arg_parent_form;
			_Division = arg_div;
			_Factory = arg_parameter[0];
			_StyleCd = arg_parameter[1];
			_Gen = arg_parameter[2];
			_ModelName = arg_parameter[3];
			_SGCd = arg_parameter[4];
			_ComponentCd = arg_parameter[5];
			_TemplateSeq = arg_parameter[6];
			_TemplateTreeCd = arg_parameter[7];
			_YieldType = arg_parameter[8];


			Init_Form(); 

		}



//		public Pop_Yield_Modify_withSRF() 
//		{
//			// 이 호출은 Windows Form 디자이너에 필요합니다.
//			InitializeComponent();
//
//			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
//
//			//			_Parent_Form = arg_parent_form;
//			//			_Division = arg_div;
//			//			_Factory = arg_parameter[0];
//			//			_StyleCd = arg_parameter[1];
//			//			_Gen = arg_parameter[2];
//			//			_ModelName = arg_parameter[3];
//			//			_SGCd = arg_parameter[4];
//			//			_ComponentCd = arg_parameter[5];
//			//			_TemplateSeq = arg_parameter[6];
//			//			_TemplateTreeCd = arg_parameter[7];
//			//			_YieldType = arg_parameter[8];
//
//
//			//Init_Form(); 
//
//		}





		// 엑셀에 의한 채산 입력
		public Pop_Yield_Modify_withSRF(FlexBase.Yield.Form_BC_Yield_withExcel arg_parent_form, 
										ClassLib.ComVar.Yield_CurrentDIV arg_div, 
										string[] arg_parameter,
			                            bool arg_use_comparison)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Parent_Form = arg_parent_form;
			_Division = arg_div;

			_Factory = arg_parameter[0];
			_StyleCd = arg_parameter[1];
			_Gen = arg_parameter[2];
			_ModelName = arg_parameter[3]; 
			_SGCd = arg_parameter[4];
			_TemplateTreeCd = arg_parameter[5];
			_ComponentName = arg_parameter[6];
			_ItemName = arg_parameter[7];
			_ColorName = arg_parameter[8]; 
			_YieldType = arg_parameter[9];

			_UseComparison = arg_use_comparison;



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Modify_withSRF));
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.pnl_BR = new System.Windows.Forms.Panel();
            this.fgrid_BOMTemp = new COM.FSP();
            this.cmenu_BOMTemp = new System.Windows.Forms.ContextMenu();
            this.menuItem_ItemList = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator = new System.Windows.Forms.MenuItem();
            this.menuItem_DeleteRawMat = new System.Windows.Forms.MenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_BOMTemp = new C1.Win.C1List.C1Combo();
            this.cmb_Component = new C1.Win.C1List.C1Combo();
            this.cmb_SGCd = new C1.Win.C1List.C1Combo();
            this.txt_BOMTemp = new System.Windows.Forms.TextBox();
            this.txt_Component = new System.Windows.Forms.TextBox();
            this.btn_AddNew_Comp = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Refresh = new System.Windows.Forms.Label();
            this.lbl_Component = new System.Windows.Forms.Label();
            this.lbl_SG = new System.Windows.Forms.Label();
            this.lbl_BOMTemp = new System.Windows.Forms.Label();
            this.btn_SearchTemp = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_CopyTemp = new System.Windows.Forms.Label();
            this.btn_AddRawMat = new System.Windows.Forms.Label();
            this.btn_CreateProcCd = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_BL = new System.Windows.Forms.Panel();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tabPage_SRF = new System.Windows.Forms.TabPage();
            this.pnl_Tab_B = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Comp = new System.Windows.Forms.RadioButton();
            this.btn_SRF_Batch = new System.Windows.Forms.Label();
            this.btn_SRF_Move = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_Part = new C1.Win.C1List.C1Combo();
            this.cmb_BOMID = new C1.Win.C1List.C1Combo();
            this.cmb_SRFNo = new C1.Win.C1List.C1Combo();
            this.txt_SRF = new System.Windows.Forms.TextBox();
            this.lbl_BOM = new System.Windows.Forms.Label();
            this.lbl_Part = new System.Windows.Forms.Label();
            this.lbl_SRF = new System.Windows.Forms.Label();
            this.btn_FindComp = new System.Windows.Forms.Label();
            this.fgrid_SRF = new COM.FSP();
            this.cmenu_SRF = new System.Windows.Forms.ContextMenu();
            this.menuItem_AllSelect = new System.Windows.Forms.MenuItem();
            this.menuItem_AllDeselect = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.menuItem_SaveComp = new System.Windows.Forms.MenuItem();
            this.menuItem_SetSizeYN = new System.Windows.Forms.MenuItem();
            this.pnl_BB2 = new System.Windows.Forms.Panel();
            this.lbl_YieldValue = new System.Windows.Forms.Label();
            this.txt_YieldValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fgrid_YieldValue = new COM.FSP();
            this.pnl_BB1 = new System.Windows.Forms.Panel();
            this.chk_CreateSizeByDB = new System.Windows.Forms.CheckBox();
            this.chk_CreateSizeBySize = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.img_Button = new System.Windows.Forms.ImageList(this.components);
            this.btn_Apply = new System.Windows.Forms.Label();
            this.chk_CreateSizeByValue = new System.Windows.Forms.CheckBox();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.img_Action = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            this.pnl_BR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOMTemp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SGCd)).BeginInit();
            this.pnl_BL.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.tabPage_SRF.SuspendLayout();
            this.pnl_Tab_B.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Part)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SRFNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_SRF)).BeginInit();
            this.pnl_BB2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).BeginInit();
            this.pnl_BB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.pnl_BR);
            this.pnl_B.Controls.Add(this.splitter1);
            this.pnl_B.Controls.Add(this.pnl_BL);
            this.pnl_B.Controls.Add(this.pnl_BB2);
            this.pnl_B.Controls.Add(this.pnl_BB1);
            this.pnl_B.Location = new System.Drawing.Point(0, 64);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(792, 480);
            this.pnl_B.TabIndex = 25;
            // 
            // pnl_BR
            // 
            this.pnl_BR.Controls.Add(this.fgrid_BOMTemp);
            this.pnl_BR.Controls.Add(this.groupBox2);
            this.pnl_BR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BR.Location = new System.Drawing.Point(305, 0);
            this.pnl_BR.Name = "pnl_BR";
            this.pnl_BR.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pnl_BR.Size = new System.Drawing.Size(482, 343);
            this.pnl_BR.TabIndex = 4;
            // 
            // fgrid_BOMTemp
            // 
            this.fgrid_BOMTemp.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_BOMTemp.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_BOMTemp.ContextMenu = this.cmenu_BOMTemp;
            this.fgrid_BOMTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_BOMTemp.Font = new System.Drawing.Font("굴림", 9F);
            this.fgrid_BOMTemp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_BOMTemp.Location = new System.Drawing.Point(2, 125);
            this.fgrid_BOMTemp.Name = "fgrid_BOMTemp";
            this.fgrid_BOMTemp.Size = new System.Drawing.Size(480, 218);
            this.fgrid_BOMTemp.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_BOMTemp.Styles"));
            this.fgrid_BOMTemp.TabIndex = 661;
            this.fgrid_BOMTemp.Click += new System.EventHandler(this.fgrid_BOMTemp_Click);
            this.fgrid_BOMTemp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgrid_BOMTemp_MouseMove);
            this.fgrid_BOMTemp.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_BOMTemp_DragOver);
            this.fgrid_BOMTemp.DragDrop += new System.Windows.Forms.DragEventHandler(this.fgrid_BOMTemp_DragDrop);
            this.fgrid_BOMTemp.DoubleClick += new System.EventHandler(this.fgrid_BOMTemp_DoubleClick);
            // 
            // cmenu_BOMTemp
            // 
            this.cmenu_BOMTemp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ItemList,
            this.menuItem_Separator,
            this.menuItem_DeleteRawMat});
            // 
            // menuItem_ItemList
            // 
            this.menuItem_ItemList.Index = 0;
            this.menuItem_ItemList.Text = "Item/ Specification/ Color";
            this.menuItem_ItemList.Click += new System.EventHandler(this.menuItem_ItemList_Click);
            // 
            // menuItem_Separator
            // 
            this.menuItem_Separator.Index = 1;
            this.menuItem_Separator.Text = "-";
            // 
            // menuItem_DeleteRawMat
            // 
            this.menuItem_DeleteRawMat.Index = 2;
            this.menuItem_DeleteRawMat.Text = "Delete Raw Material";
            this.menuItem_DeleteRawMat.Click += new System.EventHandler(this.menuItem_DeleteRawMat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmb_BOMTemp);
            this.groupBox2.Controls.Add(this.cmb_Component);
            this.groupBox2.Controls.Add(this.cmb_SGCd);
            this.groupBox2.Controls.Add(this.txt_BOMTemp);
            this.groupBox2.Controls.Add(this.txt_Component);
            this.groupBox2.Controls.Add(this.btn_AddNew_Comp);
            this.groupBox2.Controls.Add(this.btn_Refresh);
            this.groupBox2.Controls.Add(this.lbl_Component);
            this.groupBox2.Controls.Add(this.lbl_SG);
            this.groupBox2.Controls.Add(this.lbl_BOMTemp);
            this.groupBox2.Controls.Add(this.btn_SearchTemp);
            this.groupBox2.Controls.Add(this.btn_CopyTemp);
            this.groupBox2.Controls.Add(this.btn_AddRawMat);
            this.groupBox2.Controls.Add(this.btn_CreateProcCd);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 125);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // cmb_BOMTemp
            // 
            this.cmb_BOMTemp.AddItemCols = 0;
            this.cmb_BOMTemp.AddItemSeparator = ';';
            this.cmb_BOMTemp.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_BOMTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BOMTemp.Caption = "";
            this.cmb_BOMTemp.CaptionHeight = 17;
            this.cmb_BOMTemp.CaptionStyle = style49;
            this.cmb_BOMTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BOMTemp.ColumnCaptionHeight = 18;
            this.cmb_BOMTemp.ColumnFooterHeight = 18;
            this.cmb_BOMTemp.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BOMTemp.ContentHeight = 17;
            this.cmb_BOMTemp.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BOMTemp.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BOMTemp.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BOMTemp.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BOMTemp.EditorHeight = 17;
            this.cmb_BOMTemp.EvenRowStyle = style50;
            this.cmb_BOMTemp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BOMTemp.FooterStyle = style51;
            this.cmb_BOMTemp.GapHeight = 2;
            this.cmb_BOMTemp.HeadingStyle = style52;
            this.cmb_BOMTemp.HighLightRowStyle = style53;
            this.cmb_BOMTemp.ItemHeight = 17;
            this.cmb_BOMTemp.Location = new System.Drawing.Point(212, 70);
            this.cmb_BOMTemp.MatchEntryTimeout = ((long)(2000));
            this.cmb_BOMTemp.MaxDropDownItems = ((short)(5));
            this.cmb_BOMTemp.MaxLength = 32767;
            this.cmb_BOMTemp.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BOMTemp.Name = "cmb_BOMTemp";
            this.cmb_BOMTemp.OddRowStyle = style54;
            this.cmb_BOMTemp.PartialRightColumn = false;
            this.cmb_BOMTemp.PropBag = resources.GetString("cmb_BOMTemp.PropBag");
            this.cmb_BOMTemp.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BOMTemp.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BOMTemp.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BOMTemp.SelectedStyle = style55;
            this.cmb_BOMTemp.Size = new System.Drawing.Size(240, 21);
            this.cmb_BOMTemp.Style = style56;
            this.cmb_BOMTemp.TabIndex = 677;
            this.cmb_BOMTemp.SelectedValueChanged += new System.EventHandler(this.cmb_BOMTemp_SelectedValueChanged);
            // 
            // cmb_Component
            // 
            this.cmb_Component.AddItemCols = 0;
            this.cmb_Component.AddItemSeparator = ';';
            this.cmb_Component.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Component.Caption = "";
            this.cmb_Component.CaptionHeight = 17;
            this.cmb_Component.CaptionStyle = style57;
            this.cmb_Component.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Component.ColumnCaptionHeight = 18;
            this.cmb_Component.ColumnFooterHeight = 18;
            this.cmb_Component.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Component.ContentHeight = 17;
            this.cmb_Component.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Component.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Component.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Component.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Component.EditorHeight = 17;
            this.cmb_Component.EvenRowStyle = style58;
            this.cmb_Component.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Component.FooterStyle = style59;
            this.cmb_Component.GapHeight = 2;
            this.cmb_Component.HeadingStyle = style60;
            this.cmb_Component.HighLightRowStyle = style61;
            this.cmb_Component.ItemHeight = 17;
            this.cmb_Component.Location = new System.Drawing.Point(212, 36);
            this.cmb_Component.MatchEntryTimeout = ((long)(2000));
            this.cmb_Component.MaxDropDownItems = ((short)(5));
            this.cmb_Component.MaxLength = 32767;
            this.cmb_Component.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Component.Name = "cmb_Component";
            this.cmb_Component.OddRowStyle = style62;
            this.cmb_Component.PartialRightColumn = false;
            this.cmb_Component.PropBag = resources.GetString("cmb_Component.PropBag");
            this.cmb_Component.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Component.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Component.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Component.SelectedStyle = style63;
            this.cmb_Component.Size = new System.Drawing.Size(240, 21);
            this.cmb_Component.Style = style64;
            this.cmb_Component.TabIndex = 676;
            this.cmb_Component.SelectedValueChanged += new System.EventHandler(this.cmb_Component_SelectedValueChanged);
            // 
            // cmb_SGCd
            // 
            this.cmb_SGCd.AddItemCols = 0;
            this.cmb_SGCd.AddItemSeparator = ';';
            this.cmb_SGCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_SGCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SGCd.Caption = "";
            this.cmb_SGCd.CaptionHeight = 17;
            this.cmb_SGCd.CaptionStyle = style65;
            this.cmb_SGCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SGCd.ColumnCaptionHeight = 18;
            this.cmb_SGCd.ColumnFooterHeight = 18;
            this.cmb_SGCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SGCd.ContentHeight = 17;
            this.cmb_SGCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SGCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SGCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SGCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SGCd.EditorHeight = 17;
            this.cmb_SGCd.EvenRowStyle = style66;
            this.cmb_SGCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SGCd.FooterStyle = style67;
            this.cmb_SGCd.GapHeight = 2;
            this.cmb_SGCd.HeadingStyle = style68;
            this.cmb_SGCd.HighLightRowStyle = style69;
            this.cmb_SGCd.ItemHeight = 17;
            this.cmb_SGCd.Location = new System.Drawing.Point(108, 14);
            this.cmb_SGCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_SGCd.MaxDropDownItems = ((short)(5));
            this.cmb_SGCd.MaxLength = 32767;
            this.cmb_SGCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SGCd.Name = "cmb_SGCd";
            this.cmb_SGCd.OddRowStyle = style70;
            this.cmb_SGCd.PartialRightColumn = false;
            this.cmb_SGCd.PropBag = resources.GetString("cmb_SGCd.PropBag");
            this.cmb_SGCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SGCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SGCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SGCd.SelectedStyle = style71;
            this.cmb_SGCd.Size = new System.Drawing.Size(103, 21);
            this.cmb_SGCd.Style = style72;
            this.cmb_SGCd.TabIndex = 675;
            this.cmb_SGCd.SelectedValueChanged += new System.EventHandler(this.cmb_SGCd_SelectedValueChanged);
            // 
            // txt_BOMTemp
            // 
            this.txt_BOMTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BOMTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_BOMTemp.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BOMTemp.Location = new System.Drawing.Point(108, 70);
            this.txt_BOMTemp.Name = "txt_BOMTemp";
            this.txt_BOMTemp.Size = new System.Drawing.Size(103, 21);
            this.txt_BOMTemp.TabIndex = 674;
            this.txt_BOMTemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_BOMTemp_KeyUp);
            // 
            // txt_Component
            // 
            this.txt_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Component.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Component.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Component.Location = new System.Drawing.Point(108, 36);
            this.txt_Component.Name = "txt_Component";
            this.txt_Component.Size = new System.Drawing.Size(103, 21);
            this.txt_Component.TabIndex = 673;
            this.txt_Component.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Component_KeyUp);
            // 
            // btn_AddNew_Comp
            // 
            this.btn_AddNew_Comp.ImageIndex = 2;
            this.btn_AddNew_Comp.ImageList = this.img_SmallButton;
            this.btn_AddNew_Comp.Location = new System.Drawing.Point(453, 35);
            this.btn_AddNew_Comp.Name = "btn_AddNew_Comp";
            this.btn_AddNew_Comp.Size = new System.Drawing.Size(23, 23);
            this.btn_AddNew_Comp.TabIndex = 672;
            this.btn_AddNew_Comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddNew_Comp.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_AddNew_Comp.Click += new System.EventHandler(this.btn_AddNew_Comp_Click);
            this.btn_AddNew_Comp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_AddNew_Comp.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_AddNew_Comp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.ImageIndex = 0;
            this.btn_Refresh.ImageList = this.img_SmallButton;
            this.btn_Refresh.Location = new System.Drawing.Point(453, 69);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(23, 23);
            this.btn_Refresh.TabIndex = 671;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_Component
            // 
            this.lbl_Component.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_Component.ImageIndex = 1;
            this.lbl_Component.ImageList = this.img_Label;
            this.lbl_Component.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Component.Location = new System.Drawing.Point(7, 36);
            this.lbl_Component.Name = "lbl_Component";
            this.lbl_Component.Size = new System.Drawing.Size(100, 21);
            this.lbl_Component.TabIndex = 669;
            this.lbl_Component.Text = "Component";
            this.lbl_Component.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SG
            // 
            this.lbl_SG.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_SG.ImageIndex = 1;
            this.lbl_SG.ImageList = this.img_Label;
            this.lbl_SG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_SG.Location = new System.Drawing.Point(7, 14);
            this.lbl_SG.Name = "lbl_SG";
            this.lbl_SG.Size = new System.Drawing.Size(100, 21);
            this.lbl_SG.TabIndex = 666;
            this.lbl_SG.Text = "Semigood";
            this.lbl_SG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BOMTemp
            // 
            this.lbl_BOMTemp.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_BOMTemp.ImageIndex = 0;
            this.lbl_BOMTemp.ImageList = this.img_Label;
            this.lbl_BOMTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_BOMTemp.Location = new System.Drawing.Point(7, 70);
            this.lbl_BOMTemp.Name = "lbl_BOMTemp";
            this.lbl_BOMTemp.Size = new System.Drawing.Size(100, 21);
            this.lbl_BOMTemp.TabIndex = 658;
            this.lbl_BOMTemp.Text = "BOM Template";
            this.lbl_BOMTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SearchTemp
            // 
            this.btn_SearchTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_SearchTemp.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_SearchTemp.ImageIndex = 0;
            this.btn_SearchTemp.ImageList = this.img_LongButton;
            this.btn_SearchTemp.Location = new System.Drawing.Point(5, 92);
            this.btn_SearchTemp.Name = "btn_SearchTemp";
            this.btn_SearchTemp.Size = new System.Drawing.Size(117, 23);
            this.btn_SearchTemp.TabIndex = 668;
            this.btn_SearchTemp.Text = "Search Template";
            this.btn_SearchTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchTemp.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchTemp.Click += new System.EventHandler(this.btn_SearchTemp_Click);
            this.btn_SearchTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchTemp.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // btn_CopyTemp
            // 
            this.btn_CopyTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CopyTemp.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_CopyTemp.ImageIndex = 0;
            this.btn_CopyTemp.ImageList = this.img_LongButton;
            this.btn_CopyTemp.Location = new System.Drawing.Point(123, 92);
            this.btn_CopyTemp.Name = "btn_CopyTemp";
            this.btn_CopyTemp.Size = new System.Drawing.Size(117, 23);
            this.btn_CopyTemp.TabIndex = 669;
            this.btn_CopyTemp.Text = "Copy Template";
            this.btn_CopyTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CopyTemp.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_CopyTemp.Click += new System.EventHandler(this.btn_CopyTemp_Click);
            this.btn_CopyTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_CopyTemp.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_CopyTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_AddRawMat
            // 
            this.btn_AddRawMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_AddRawMat.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_AddRawMat.ImageIndex = 0;
            this.btn_AddRawMat.ImageList = this.img_LongButton;
            this.btn_AddRawMat.Location = new System.Drawing.Point(241, 92);
            this.btn_AddRawMat.Name = "btn_AddRawMat";
            this.btn_AddRawMat.Size = new System.Drawing.Size(117, 23);
            this.btn_AddRawMat.TabIndex = 670;
            this.btn_AddRawMat.Text = "Add Raw Material";
            this.btn_AddRawMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddRawMat.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_AddRawMat.Click += new System.EventHandler(this.btn_AddRawMat_Click);
            this.btn_AddRawMat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_AddRawMat.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_AddRawMat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_CreateProcCd
            // 
            this.btn_CreateProcCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CreateProcCd.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_CreateProcCd.ImageIndex = 0;
            this.btn_CreateProcCd.ImageList = this.img_LongButton;
            this.btn_CreateProcCd.Location = new System.Drawing.Point(359, 92);
            this.btn_CreateProcCd.Name = "btn_CreateProcCd";
            this.btn_CreateProcCd.Size = new System.Drawing.Size(117, 23);
            this.btn_CreateProcCd.TabIndex = 671;
            this.btn_CreateProcCd.Text = "Create Process";
            this.btn_CreateProcCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateProcCd.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_CreateProcCd.Click += new System.EventHandler(this.btn_CreateProcCd_Click);
            this.btn_CreateProcCd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_CreateProcCd.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_CreateProcCd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(302, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 343);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pnl_BL
            // 
            this.pnl_BL.Controls.Add(this.tab_Main);
            this.pnl_BL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_BL.Location = new System.Drawing.Point(5, 0);
            this.pnl_BL.Name = "pnl_BL";
            this.pnl_BL.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.pnl_BL.Size = new System.Drawing.Size(297, 343);
            this.pnl_BL.TabIndex = 2;
            // 
            // tab_Main
            // 
            this.tab_Main.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tab_Main.Controls.Add(this.tabPage_SRF);
            this.tab_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Main.ItemSize = new System.Drawing.Size(21, 18);
            this.tab_Main.Location = new System.Drawing.Point(0, 0);
            this.tab_Main.Multiline = true;
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(295, 343);
            this.tab_Main.TabIndex = 1;
            this.tab_Main.Click += new System.EventHandler(this.tab_Main_Click);
            // 
            // tabPage_SRF
            // 
            this.tabPage_SRF.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage_SRF.Controls.Add(this.pnl_Tab_B);
            this.tabPage_SRF.Controls.Add(this.groupBox4);
            this.tabPage_SRF.Controls.Add(this.fgrid_SRF);
            this.tabPage_SRF.ForeColor = System.Drawing.Color.Black;
            this.tabPage_SRF.Location = new System.Drawing.Point(4, 4);
            this.tabPage_SRF.Name = "tabPage_SRF";
            this.tabPage_SRF.Size = new System.Drawing.Size(269, 335);
            this.tabPage_SRF.TabIndex = 0;
            this.tabPage_SRF.Text = "SRF";
            // 
            // pnl_Tab_B
            // 
            this.pnl_Tab_B.Controls.Add(this.groupBox1);
            this.pnl_Tab_B.Controls.Add(this.btn_SRF_Batch);
            this.pnl_Tab_B.Controls.Add(this.btn_SRF_Move);
            this.pnl_Tab_B.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Tab_B.Location = new System.Drawing.Point(0, 307);
            this.pnl_Tab_B.Name = "pnl_Tab_B";
            this.pnl_Tab_B.Size = new System.Drawing.Size(269, 28);
            this.pnl_Tab_B.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_All);
            this.groupBox1.Controls.Add(this.rad_Comp);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.Location = new System.Drawing.Point(0, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 28);
            this.groupBox1.TabIndex = 661;
            this.groupBox1.TabStop = false;
            // 
            // rad_All
            // 
            this.rad_All.Location = new System.Drawing.Point(64, 11);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(35, 14);
            this.rad_All.TabIndex = 36;
            this.rad_All.Tag = "-1";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Comp
            // 
            this.rad_Comp.Checked = true;
            this.rad_Comp.Location = new System.Drawing.Point(8, 11);
            this.rad_Comp.Name = "rad_Comp";
            this.rad_Comp.Size = new System.Drawing.Size(57, 14);
            this.rad_Comp.TabIndex = 35;
            this.rad_Comp.TabStop = true;
            this.rad_Comp.Tag = "1";
            this.rad_Comp.Text = "Comp";
            this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // btn_SRF_Batch
            // 
            this.btn_SRF_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SRF_Batch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_SRF_Batch.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_SRF_Batch.ImageIndex = 0;
            this.btn_SRF_Batch.ImageList = this.img_LongButton;
            this.btn_SRF_Batch.Location = new System.Drawing.Point(152, 3);
            this.btn_SRF_Batch.Name = "btn_SRF_Batch";
            this.btn_SRF_Batch.Size = new System.Drawing.Size(117, 23);
            this.btn_SRF_Batch.TabIndex = 672;
            this.btn_SRF_Batch.Text = "Batch Run SRF";
            this.btn_SRF_Batch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SRF_Batch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SRF_Batch.Click += new System.EventHandler(this.btn_SRF_Batch_Click);
            this.btn_SRF_Batch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SRF_Batch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SRF_Batch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_SRF_Move
            // 
            this.btn_SRF_Move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SRF_Move.ImageIndex = 4;
            this.btn_SRF_Move.ImageList = this.img_SmallButton;
            this.btn_SRF_Move.Location = new System.Drawing.Point(129, 3);
            this.btn_SRF_Move.Name = "btn_SRF_Move";
            this.btn_SRF_Move.Size = new System.Drawing.Size(23, 23);
            this.btn_SRF_Move.TabIndex = 664;
            this.btn_SRF_Move.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SRF_Move.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SRF_Move.Click += new System.EventHandler(this.btn_SRF_Move_Click);
            this.btn_SRF_Move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SRF_Move.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SRF_Move.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cmb_Part);
            this.groupBox4.Controls.Add(this.cmb_BOMID);
            this.groupBox4.Controls.Add(this.cmb_SRFNo);
            this.groupBox4.Controls.Add(this.txt_SRF);
            this.groupBox4.Controls.Add(this.lbl_BOM);
            this.groupBox4.Controls.Add(this.lbl_Part);
            this.groupBox4.Controls.Add(this.lbl_SRF);
            this.groupBox4.Controls.Add(this.btn_FindComp);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 82);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // cmb_Part
            // 
            this.cmb_Part.AddItemCols = 0;
            this.cmb_Part.AddItemSeparator = ';';
            this.cmb_Part.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Part.Caption = "";
            this.cmb_Part.CaptionHeight = 17;
            this.cmb_Part.CaptionStyle = style73;
            this.cmb_Part.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Part.ColumnCaptionHeight = 18;
            this.cmb_Part.ColumnFooterHeight = 18;
            this.cmb_Part.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Part.ContentHeight = 17;
            this.cmb_Part.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Part.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Part.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Part.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Part.EditorHeight = 17;
            this.cmb_Part.EvenRowStyle = style74;
            this.cmb_Part.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Part.FooterStyle = style75;
            this.cmb_Part.GapHeight = 2;
            this.cmb_Part.HeadingStyle = style76;
            this.cmb_Part.HighLightRowStyle = style77;
            this.cmb_Part.ItemHeight = 17;
            this.cmb_Part.Location = new System.Drawing.Point(104, 55);
            this.cmb_Part.MatchEntryTimeout = ((long)(2000));
            this.cmb_Part.MaxDropDownItems = ((short)(5));
            this.cmb_Part.MaxLength = 32767;
            this.cmb_Part.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Part.Name = "cmb_Part";
            this.cmb_Part.OddRowStyle = style78;
            this.cmb_Part.PartialRightColumn = false;
            this.cmb_Part.PropBag = resources.GetString("cmb_Part.PropBag");
            this.cmb_Part.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Part.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Part.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Part.SelectedStyle = style79;
            this.cmb_Part.Size = new System.Drawing.Size(137, 21);
            this.cmb_Part.Style = style80;
            this.cmb_Part.TabIndex = 668;
            this.cmb_Part.SelectedValueChanged += new System.EventHandler(this.cmb_Part_SelectedValueChanged);
            // 
            // cmb_BOMID
            // 
            this.cmb_BOMID.AddItemCols = 0;
            this.cmb_BOMID.AddItemSeparator = ';';
            this.cmb_BOMID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_BOMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BOMID.Caption = "";
            this.cmb_BOMID.CaptionHeight = 17;
            this.cmb_BOMID.CaptionStyle = style81;
            this.cmb_BOMID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BOMID.ColumnCaptionHeight = 18;
            this.cmb_BOMID.ColumnFooterHeight = 18;
            this.cmb_BOMID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BOMID.ContentHeight = 17;
            this.cmb_BOMID.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BOMID.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BOMID.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BOMID.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BOMID.EditorHeight = 17;
            this.cmb_BOMID.EvenRowStyle = style82;
            this.cmb_BOMID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BOMID.FooterStyle = style83;
            this.cmb_BOMID.GapHeight = 2;
            this.cmb_BOMID.HeadingStyle = style84;
            this.cmb_BOMID.HighLightRowStyle = style85;
            this.cmb_BOMID.ItemHeight = 17;
            this.cmb_BOMID.Location = new System.Drawing.Point(104, 33);
            this.cmb_BOMID.MatchEntryTimeout = ((long)(2000));
            this.cmb_BOMID.MaxDropDownItems = ((short)(5));
            this.cmb_BOMID.MaxLength = 32767;
            this.cmb_BOMID.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BOMID.Name = "cmb_BOMID";
            this.cmb_BOMID.OddRowStyle = style86;
            this.cmb_BOMID.PartialRightColumn = false;
            this.cmb_BOMID.PropBag = resources.GetString("cmb_BOMID.PropBag");
            this.cmb_BOMID.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BOMID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BOMID.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BOMID.SelectedStyle = style87;
            this.cmb_BOMID.Size = new System.Drawing.Size(160, 21);
            this.cmb_BOMID.Style = style88;
            this.cmb_BOMID.TabIndex = 667;
            this.cmb_BOMID.SelectedValueChanged += new System.EventHandler(this.cmb_BOMID_SelectedValueChanged);
            // 
            // cmb_SRFNo
            // 
            this.cmb_SRFNo.AddItemCols = 0;
            this.cmb_SRFNo.AddItemSeparator = ';';
            this.cmb_SRFNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_SRFNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SRFNo.Caption = "";
            this.cmb_SRFNo.CaptionHeight = 17;
            this.cmb_SRFNo.CaptionStyle = style89;
            this.cmb_SRFNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SRFNo.ColumnCaptionHeight = 18;
            this.cmb_SRFNo.ColumnFooterHeight = 18;
            this.cmb_SRFNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SRFNo.ContentHeight = 17;
            this.cmb_SRFNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SRFNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SRFNo.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SRFNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SRFNo.EditorHeight = 17;
            this.cmb_SRFNo.EvenRowStyle = style90;
            this.cmb_SRFNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SRFNo.FooterStyle = style91;
            this.cmb_SRFNo.GapHeight = 2;
            this.cmb_SRFNo.HeadingStyle = style92;
            this.cmb_SRFNo.HighLightRowStyle = style93;
            this.cmb_SRFNo.ItemHeight = 17;
            this.cmb_SRFNo.Location = new System.Drawing.Point(175, 11);
            this.cmb_SRFNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_SRFNo.MaxDropDownItems = ((short)(5));
            this.cmb_SRFNo.MaxLength = 32767;
            this.cmb_SRFNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SRFNo.Name = "cmb_SRFNo";
            this.cmb_SRFNo.OddRowStyle = style94;
            this.cmb_SRFNo.PartialRightColumn = false;
            this.cmb_SRFNo.PropBag = resources.GetString("cmb_SRFNo.PropBag");
            this.cmb_SRFNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SRFNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SRFNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SRFNo.SelectedStyle = style95;
            this.cmb_SRFNo.Size = new System.Drawing.Size(89, 21);
            this.cmb_SRFNo.Style = style96;
            this.cmb_SRFNo.TabIndex = 666;
            this.cmb_SRFNo.SelectedValueChanged += new System.EventHandler(this.cmb_SRFNo_SelectedValueChanged);
            // 
            // txt_SRF
            // 
            this.txt_SRF.BackColor = System.Drawing.Color.White;
            this.txt_SRF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SRF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SRF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SRF.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_SRF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SRF.Location = new System.Drawing.Point(104, 11);
            this.txt_SRF.MaxLength = 10;
            this.txt_SRF.Name = "txt_SRF";
            this.txt_SRF.Size = new System.Drawing.Size(70, 21);
            this.txt_SRF.TabIndex = 665;
            this.txt_SRF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SRF_KeyUp);
            // 
            // lbl_BOM
            // 
            this.lbl_BOM.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_BOM.ImageIndex = 0;
            this.lbl_BOM.ImageList = this.img_Label;
            this.lbl_BOM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_BOM.Location = new System.Drawing.Point(3, 33);
            this.lbl_BOM.Name = "lbl_BOM";
            this.lbl_BOM.Size = new System.Drawing.Size(100, 21);
            this.lbl_BOM.TabIndex = 664;
            this.lbl_BOM.Text = "BOM ID";
            this.lbl_BOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Part
            // 
            this.lbl_Part.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_Part.ImageIndex = 0;
            this.lbl_Part.ImageList = this.img_Label;
            this.lbl_Part.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Part.Location = new System.Drawing.Point(3, 55);
            this.lbl_Part.Name = "lbl_Part";
            this.lbl_Part.Size = new System.Drawing.Size(100, 21);
            this.lbl_Part.TabIndex = 662;
            this.lbl_Part.Text = "Component Part";
            this.lbl_Part.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SRF
            // 
            this.lbl_SRF.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_SRF.ImageIndex = 0;
            this.lbl_SRF.ImageList = this.img_Label;
            this.lbl_SRF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_SRF.Location = new System.Drawing.Point(3, 11);
            this.lbl_SRF.Name = "lbl_SRF";
            this.lbl_SRF.Size = new System.Drawing.Size(100, 21);
            this.lbl_SRF.TabIndex = 660;
            this.lbl_SRF.Text = "SRF";
            this.lbl_SRF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_FindComp
            // 
            this.btn_FindComp.ImageIndex = 0;
            this.btn_FindComp.ImageList = this.img_SmallButton;
            this.btn_FindComp.Location = new System.Drawing.Point(242, 54);
            this.btn_FindComp.Name = "btn_FindComp";
            this.btn_FindComp.Size = new System.Drawing.Size(23, 23);
            this.btn_FindComp.TabIndex = 663;
            this.btn_FindComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_FindComp.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_FindComp.Click += new System.EventHandler(this.btn_FindComp_Click);
            this.btn_FindComp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_FindComp.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_FindComp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // fgrid_SRF
            // 
            this.fgrid_SRF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgrid_SRF.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_SRF.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_SRF.ContextMenu = this.cmenu_SRF;
            this.fgrid_SRF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_SRF.Location = new System.Drawing.Point(0, 77);
            this.fgrid_SRF.Name = "fgrid_SRF";
            this.fgrid_SRF.Size = new System.Drawing.Size(269, 230);
            this.fgrid_SRF.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_SRF.Styles"));
            this.fgrid_SRF.TabIndex = 661;
            this.fgrid_SRF.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.fgrid_SRF_BeforeMouseDown);
            this.fgrid_SRF.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_SRF_AfterEdit);
            this.fgrid_SRF.DragOver += new System.Windows.Forms.DragEventHandler(this.fgrid_SRF_DragOver);
            // 
            // cmenu_SRF
            // 
            this.cmenu_SRF.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_AllSelect,
            this.menuItem_AllDeselect,
            this.menuItem_Separator1,
            this.menuItem_SaveComp,
            this.menuItem_SetSizeYN});
            this.cmenu_SRF.Popup += new System.EventHandler(this.cmenu_SRF_Popup);
            // 
            // menuItem_AllSelect
            // 
            this.menuItem_AllSelect.Index = 0;
            this.menuItem_AllSelect.Text = "All select";
            this.menuItem_AllSelect.Click += new System.EventHandler(this.menuItem_AllSelect_Click);
            // 
            // menuItem_AllDeselect
            // 
            this.menuItem_AllDeselect.Index = 1;
            this.menuItem_AllDeselect.Text = "All deselect";
            this.menuItem_AllDeselect.Click += new System.EventHandler(this.menuItem_AllDeselect_Click);
            // 
            // menuItem_Separator1
            // 
            this.menuItem_Separator1.Index = 2;
            this.menuItem_Separator1.Text = "-";
            // 
            // menuItem_SaveComp
            // 
            this.menuItem_SaveComp.Index = 3;
            this.menuItem_SaveComp.Text = "Save new component";
            this.menuItem_SaveComp.Visible = false;
            this.menuItem_SaveComp.Click += new System.EventHandler(this.menuItem_SaveComp_Click);
            // 
            // menuItem_SetSizeYN
            // 
            this.menuItem_SetSizeYN.Index = 4;
            this.menuItem_SetSizeYN.Text = "Set Size Material";
            this.menuItem_SetSizeYN.Click += new System.EventHandler(this.menuItem_SetSizeYN_Click);
            // 
            // pnl_BB2
            // 
            this.pnl_BB2.Controls.Add(this.lbl_YieldValue);
            this.pnl_BB2.Controls.Add(this.txt_YieldValue);
            this.pnl_BB2.Controls.Add(this.groupBox3);
            this.pnl_BB2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BB2.Location = new System.Drawing.Point(5, 343);
            this.pnl_BB2.Name = "pnl_BB2";
            this.pnl_BB2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB2.Size = new System.Drawing.Size(782, 104);
            this.pnl_BB2.TabIndex = 1;
            // 
            // lbl_YieldValue
            // 
            this.lbl_YieldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_YieldValue.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_YieldValue.ImageIndex = 0;
            this.lbl_YieldValue.ImageList = this.img_Label;
            this.lbl_YieldValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_YieldValue.Location = new System.Drawing.Point(547, 0);
            this.lbl_YieldValue.Name = "lbl_YieldValue";
            this.lbl_YieldValue.Size = new System.Drawing.Size(100, 21);
            this.lbl_YieldValue.TabIndex = 659;
            this.lbl_YieldValue.Text = "All Size Value";
            this.lbl_YieldValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_YieldValue
            // 
            this.txt_YieldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_YieldValue.BackColor = System.Drawing.SystemColors.Window;
            this.txt_YieldValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_YieldValue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_YieldValue.Location = new System.Drawing.Point(648, 0);
            this.txt_YieldValue.MaxLength = 18;
            this.txt_YieldValue.Name = "txt_YieldValue";
            this.txt_YieldValue.Size = new System.Drawing.Size(128, 21);
            this.txt_YieldValue.TabIndex = 543;
            this.txt_YieldValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_YieldValue_KeyUp);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.fgrid_YieldValue);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 99);
            this.groupBox3.TabIndex = 540;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yield Value";
            // 
            // fgrid_YieldValue
            // 
            this.fgrid_YieldValue.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_YieldValue.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_YieldValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_YieldValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_YieldValue.Location = new System.Drawing.Point(3, 17);
            this.fgrid_YieldValue.Name = "fgrid_YieldValue";
            this.fgrid_YieldValue.Size = new System.Drawing.Size(776, 79);
            this.fgrid_YieldValue.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_YieldValue.Styles"));
            this.fgrid_YieldValue.TabIndex = 0;
            this.fgrid_YieldValue.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_YieldValue_AfterEdit);
            this.fgrid_YieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_YieldValue_KeyDown);
            this.fgrid_YieldValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_YieldValue_MouseUp);
            this.fgrid_YieldValue.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_YieldValue_AfterResizeColumn);
            // 
            // pnl_BB1
            // 
            this.pnl_BB1.Controls.Add(this.chk_CreateSizeByDB);
            this.pnl_BB1.Controls.Add(this.chk_CreateSizeBySize);
            this.pnl_BB1.Controls.Add(this.btn_Cancel);
            this.pnl_BB1.Controls.Add(this.btn_Apply);
            this.pnl_BB1.Controls.Add(this.chk_CreateSizeByValue);
            this.pnl_BB1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BB1.Location = new System.Drawing.Point(5, 447);
            this.pnl_BB1.Name = "pnl_BB1";
            this.pnl_BB1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB1.Size = new System.Drawing.Size(782, 28);
            this.pnl_BB1.TabIndex = 0;
            // 
            // chk_CreateSizeByDB
            // 
            this.chk_CreateSizeByDB.BackColor = System.Drawing.SystemColors.Window;
            this.chk_CreateSizeByDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_CreateSizeByDB.Font = new System.Drawing.Font("Verdana", 9F);
            this.chk_CreateSizeByDB.Location = new System.Drawing.Point(400, 8);
            this.chk_CreateSizeByDB.Name = "chk_CreateSizeByDB";
            this.chk_CreateSizeByDB.Size = new System.Drawing.Size(120, 17);
            this.chk_CreateSizeByDB.TabIndex = 664;
            this.chk_CreateSizeByDB.Text = "Get Size Group";
            this.chk_CreateSizeByDB.UseVisualStyleBackColor = false;
            this.chk_CreateSizeByDB.CheckedChanged += new System.EventHandler(this.chk_CreateSizeByDB_CheckedChanged);
            // 
            // chk_CreateSizeBySize
            // 
            this.chk_CreateSizeBySize.BackColor = System.Drawing.SystemColors.Window;
            this.chk_CreateSizeBySize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_CreateSizeBySize.Font = new System.Drawing.Font("Verdana", 9F);
            this.chk_CreateSizeBySize.Location = new System.Drawing.Point(208, 8);
            this.chk_CreateSizeBySize.Name = "chk_CreateSizeBySize";
            this.chk_CreateSizeBySize.Size = new System.Drawing.Size(192, 17);
            this.chk_CreateSizeBySize.TabIndex = 663;
            this.chk_CreateSizeBySize.Text = "size spec. creation by size";
            this.chk_CreateSizeBySize.UseVisualStyleBackColor = false;
            this.chk_CreateSizeBySize.CheckedChanged += new System.EventHandler(this.chk_CreateSize_CheckedChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(700, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 633;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(619, 3);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(80, 23);
            this.btn_Apply.TabIndex = 632;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // chk_CreateSizeByValue
            // 
            this.chk_CreateSizeByValue.BackColor = System.Drawing.SystemColors.Window;
            this.chk_CreateSizeByValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_CreateSizeByValue.Font = new System.Drawing.Font("Verdana", 9F);
            this.chk_CreateSizeByValue.Location = new System.Drawing.Point(8, 8);
            this.chk_CreateSizeByValue.Name = "chk_CreateSizeByValue";
            this.chk_CreateSizeByValue.Size = new System.Drawing.Size(200, 17);
            this.chk_CreateSizeByValue.TabIndex = 662;
            this.chk_CreateSizeByValue.Text = "size spec. creation by value ";
            this.chk_CreateSizeByValue.UseVisualStyleBackColor = false;
            this.chk_CreateSizeByValue.CheckedChanged += new System.EventHandler(this.chk_CreateSize_CheckedChanged);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 546);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.ShowPanels = true;
            this.stbar.Size = new System.Drawing.Size(792, 20);
            this.stbar.TabIndex = 45;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // Pop_Yield_Modify_withSRF
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.MaximizeBox = true;
            this.Name = "Pop_Yield_Modify_withSRF";
            this.Load += new System.EventHandler(this.Pop_Yield_Modify_withSRF_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Yield_Modify_withSRF_Closing);
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            this.pnl_BR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_BOMTemp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Component)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SGCd)).EndInit();
            this.pnl_BL.ResumeLayout(false);
            this.tab_Main.ResumeLayout(false);
            this.tabPage_SRF.ResumeLayout(false);
            this.pnl_Tab_B.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Part)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SRFNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_SRF)).EndInit();
            this.pnl_BB2.ResumeLayout(false);
            this.pnl_BB2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).EndInit();
            this.pnl_BB1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 
		//Raw Material Code Value
		public string _RawMatCd = "02J13000";
		private string _RawMatCd_Desc = "RAW MATERIAL"; 


		//채산 타입 
		private string _YieldTypeE = "E";
		private string _YieldTypeM = "M";


		//채산 입력 그리드 행 설명
		private string _YieldTypeE_Desc = "Yield (E)";
		private string _YieldTypeM_Desc = "Yield (M)";
		private string _SpecCd_Desc = "Spec. Cd";
		private string _Spec_Desc = "Spec.";


		//채산 입력 그리드 컬럼 고정 수
		private int _ColFixed = 2;

		//채산 입력 그리드 행 번호
		private int _Row_EYield, _Row_MYield, _Row_SpecCd, _Row_SpecName;
		//채산 타입에 의해서 결정된 해당 행
		private int _Row_YieldValue;


		
		//메인창으로 리턴될 데이터 테이블
			
		public bool _Cancel_Flag = true;
		public DataTable _DT_Return;
 

		private int _IxTEMPLATE_LEVEL = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL;
		private int _IxITEM_CD = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD;
		private int _IxSPEC_CD = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD;
		private int _IxSPEC_NAME = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME; 
		private int _IxCOLOR_CD = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD; 
		private int _IxSIZE_YN = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN; 

		private int _IxCS_SIZE_START = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; 
		private int _IxHEAD_COL_END = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START - 2;



		//type Division
		private string _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";
 

		//already upper level (component cd level)
		private int _CmpLevel = 2; 


		//specification division 중 사이즈 specification 구분자
		private string _SizeSpecDiv = "1";

		//yield template 중복 여부
		private bool _Exist_Template = false;



		//BOM template 중 raw material 만 있는 template 선택했을 경우
		public bool _OnlyRawMat = false;

		//BOM template 중 raw material 만 있는 구조 코드
		public string _OnlyRawMat_TemplateCd = "00005";
		

		// 사이즈 자재인 경우 Specification Code 별 색깔 구분
		private Color _SizeColor1 = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2 = ClassLib.ComVar.ClrSel_Yellow;
		private Color _CurrentColor;

//		// 사이즈 자재인 경우 Specification 처리
//		private string _SizeSpecCd = "00000", _SizeSpecName = "Size";

		// 사이즈 자재인 경우 채산값에서의 Specification 처리
		private string _SizeSpecCd_Value = "00000", _SizeSpecName_Value = "NOTHING";


		// 중복 component
		private string _DuplicateComp = "";


		// SRF display level
		private const int _LevelPart = 1, _LevelMatCd = 2;

		// SRF 에 의한 등록인지를 나타내는 플래그
		private bool _SRF_YN = false;
		 

		#endregion	  

		#region 멤버 메서드

		public void Init_Form()
		{
			try
			{



                // 영문변환 사용
                ClassLib.ComFunction.SetLangDic(this);


				//---------------------------------------------------------------------------------------------------------------------
				//Title
				//---------------------------------------------------------------------------------------------------------------------
				#region title

				switch(_Division)
				{
					case ClassLib.ComVar.Yield_CurrentDIV.AddCmp :

						this.Text = "Add Component and Yield Template";
						lbl_MainTitle.Text = "Add Component and Yield Template";

						cmb_SGCd.Enabled = false;

						txt_Component.ReadOnly = false;
						txt_Component.BackColor = ClassLib.ComVar.ClrReadOnlyN;
						cmb_Component.Enabled = true;
 
						txt_BOMTemp.Enabled = true;
						cmb_BOMTemp.Enabled = true;

						btn_Refresh.Enabled = true;
						btn_SearchTemp.Enabled = true;
						btn_CopyTemp.Enabled = true;
						btn_AddRawMat.Enabled = true;
						btn_CreateProcCd.Enabled = true; 


						btn_AddNew_Comp.Enabled = true;

						pnl_BL.Size = new Size(25, 343);
						//pnl_BL.Enabled = false;
 

						break;

					case ClassLib.ComVar.Yield_CurrentDIV.AddTemplate:

						this.Text = "Add Yield Template";
						lbl_MainTitle.Text = "Add Yield Template";

						cmb_SGCd.Enabled = false;

						txt_Component.ReadOnly = true;
						txt_Component.BackColor = ClassLib.ComVar.ClrReadOnly;
						cmb_Component.Enabled = false;

						txt_BOMTemp.Enabled = true;
						cmb_BOMTemp.Enabled = true;

						btn_Refresh.Enabled = true;
						btn_SearchTemp.Enabled = true;
						btn_CopyTemp.Enabled = true;
						btn_AddRawMat.Enabled = true;
						btn_CreateProcCd.Enabled = true; 


						btn_AddNew_Comp.Enabled = false;

						pnl_BL.Size = new Size(25, 343);
						//pnl_BL.Enabled = false;

						break;  

					case ClassLib.ComVar.Yield_CurrentDIV.Modify:

						this.Text = "Modify Template";
						lbl_MainTitle.Text = "Modify Template"; 
						

						cmb_SGCd.Enabled = false;


						//----------------------------------
						//수정 가능 버튼 비활성화
						txt_Component.ReadOnly = true;
						txt_Component.BackColor = ClassLib.ComVar.ClrReadOnly;
						cmb_Component.Enabled = false;

						txt_BOMTemp.Enabled = false;
						cmb_BOMTemp.Enabled = false;

						btn_Refresh.Enabled = false;
						btn_SearchTemp.Enabled = false;
						btn_CopyTemp.Enabled = false;
						btn_AddRawMat.Enabled = false;
						btn_CreateProcCd.Enabled = true; 

						btn_AddNew_Comp.Enabled = false;
						//----------------------------------

						pnl_BL.Size = new Size(25, 343);
						//pnl_BL.Enabled = false;

						break; 


					case ClassLib.ComVar.Yield_CurrentDIV.AddExcel:


						this.Text = "Add Template From Excel";
						lbl_MainTitle.Text = "Add Template From Excel"; 


						cmb_SGCd.Enabled = true; 

						txt_Component.ReadOnly = false;
						txt_Component.BackColor = ClassLib.ComVar.ClrReadOnlyN;
						cmb_Component.Enabled = true;

						txt_BOMTemp.Enabled = true;
						cmb_BOMTemp.Enabled = true;

						btn_Refresh.Enabled = true;
						btn_SearchTemp.Enabled = true;
						btn_CopyTemp.Enabled = true;
						btn_AddRawMat.Enabled = true; 
						btn_CreateProcCd.Enabled = true; 

						btn_AddNew_Comp.Enabled = true;


						pnl_BL.Size = new Size(25, 343); 
						//pnl_BL.Enabled = false;


						break;

					default:

						this.Text = "";
						lbl_MainTitle.Text = ""; 


						cmb_SGCd.Enabled = false;

						txt_Component.ReadOnly = false;
						txt_Component.BackColor = ClassLib.ComVar.ClrReadOnlyN;
						cmb_Component.Enabled = true;
 
						txt_BOMTemp.Enabled = true;
						cmb_BOMTemp.Enabled = true;

						btn_Refresh.Enabled = true;
						btn_SearchTemp.Enabled = true;
						btn_CopyTemp.Enabled = true;
						btn_AddRawMat.Enabled = true;
						btn_CreateProcCd.Enabled = true; 


						btn_AddNew_Comp.Enabled = true;

						pnl_BL.Size = new Size(25, 343);


						break;


				}
				//---------------------------------------------------------------------------------------------------------------------

				#endregion

 

 


				//---------------------------------------------------------------------------------------------------------------------
				// 그리드 설정
				//---------------------------------------------------------------------------------------------------------------------
				fgrid_BOMTemp.Set_Grid("SBC_YIELD", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);  
				fgrid_BOMTemp.Set_Action_Image(img_Action); 
				fgrid_BOMTemp.LeftCol = 0;

				 
				fgrid_YieldValue.Set_Grid("SBC_YIELD_VALUE", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_YieldValue.Set_Action_Image(img_Action); 
				fgrid_YieldValue.SelectionMode = SelectionModeEnum.CellRange;
				fgrid_YieldValue.LeftCol = 0;


				fgrid_SRF.Set_Grid("SBC_YIELD_VALUE_SRF", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_SRF.Set_Action_Image(img_Action);
				fgrid_SRF.LeftCol = 0;
				//---------------------------------------------------------------------------------------------------------------------


				//---------------------------------------------------------------------------------------------------------------------
				// 사이즈 컬럼 표시
				//---------------------------------------------------------------------------------------------------------------------
				fgrid_YieldValue.Display_Size_ColHead(_Factory, _StyleCd, 60, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START); 
				//---------------------------------------------------------------------------------------------------------------------


				//---------------------------------------------------------------------------------------------------------------------
				// 채산값 입력 그리드 기본 행 추가 (E 채산, M 채산, Sepcification 행)
				Add_fgrid_YieldValue_Default_Row();
 

				
				// 메인창으로 리턴될 데이터 테이블 Setting
				Set_Return_DataTable();
				//---------------------------------------------------------------------------------------------------------------------
  

				//---------------------------------------------------------------------------------------------------------------------
				// control setting
				Init_Control();
				//---------------------------------------------------------------------------------------------------------------------


				//---------------------------------------------------------------------------------------------------------------------
				fgrid_BOMTemp.DropMode = DropModeEnum.Manual;

				fgrid_SRF.DragMode = DragModeEnum.Manual;
				fgrid_SRF.DropMode = DropModeEnum.Manual;




				c1ToolBar1.Visible = false; 


				if(ClassLib.ComVar.This_Factory != ClassLib.ComVar.DSFactory)
				{
					pnl_BL.Enabled = false; 
				}


				//---------------------------------------------------------------------------------------------------------------------



				//---------------------------------------------------------------------------------------------------------------------
				// srf
				txt_SRF.Text = _Parent_Form._SRFNo;
				Set_SRFNo_Combo();
				
				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}



		/// <summary>
		/// Set_Return_DataTable : 메인창으로 리턴될 데이터 테이블 Setting
		/// </summary>
		public void Set_Return_DataTable()
		{
			_DT_Return = new DataTable(); 

			int ix_cs_size_start = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;

			// 메인 데이터 
			for(int i = 0; i < ix_cs_size_start; i++)
			{
				_DT_Return.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}

			
			// 사이즈 데이터 
			for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{
				_DT_Return.Columns.Add(new DataColumn(Convert.ToString((i + (ix_cs_size_start - 1) ) ), typeof(string)));
			} 


			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION].ColumnName = "DIVISION";   // row id
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ColumnName = "TEMPLATE_LEVEL";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ColumnName = "ITEM_CD";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD].ColumnName = "SPEC_CD";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD].ColumnName = "COLOR_CD";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ColumnName = "SIZE_YN";

			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD].ColumnName = "TEMPLATE_CD";

			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO].ColumnName = "SRF_NO";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID].ColumnName = "BOM_ID";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX].ColumnName = "SRF_SEQ_MAX";
			_DT_Return.Columns[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV].ColumnName = "SRF_CDC_DEV";



		}


		/// <summary>
		/// 채산값 입력 그리드 기본 행 추가 (E 채산, M 채산, Sepcification 행)
		/// </summary>
		private void Add_fgrid_YieldValue_Default_Row()
		{
			fgrid_YieldValue.Rows.InsertRange(fgrid_YieldValue.Rows.Fixed, 4);
 

			_Row_EYield = fgrid_YieldValue.Rows.Fixed;
			_Row_MYield = fgrid_YieldValue.Rows.Fixed + 1;
			_Row_SpecCd = fgrid_YieldValue.Rows.Fixed + 2;
			_Row_SpecName = fgrid_YieldValue.Rows.Fixed + 3;


			fgrid_YieldValue[_Row_EYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeE_Desc;
			fgrid_YieldValue[_Row_MYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeM_Desc;
			fgrid_YieldValue[_Row_SpecCd, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _SpecCd_Desc;
			fgrid_YieldValue[_Row_SpecName, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _Spec_Desc;


			fgrid_YieldValue.Cols[0].Visible = false;  
			fgrid_YieldValue.Cols.Fixed = _ColFixed;

			fgrid_YieldValue.Rows[_Row_SpecCd].Visible = false;
			
			
			if(_YieldType == _YieldTypeE)
			{
				fgrid_YieldValue.Rows[_Row_EYield].Visible = true;
				fgrid_YieldValue.Rows[_Row_MYield].Visible = false;

				_Row_YieldValue = _Row_EYield;

			}
			else if(_YieldType == _YieldTypeM)
			{
				fgrid_YieldValue.Rows[_Row_EYield].Visible = false;
				fgrid_YieldValue.Rows[_Row_MYield].Visible = true;

				_Row_YieldValue = _Row_MYield;
			}


			fgrid_YieldValue.Rows[_Row_EYield].TextAlign = TextAlignEnum.RightCenter;
			fgrid_YieldValue.Rows[_Row_MYield].TextAlign = TextAlignEnum.RightCenter;
			fgrid_YieldValue.Rows[_Row_SpecCd].TextAlign = TextAlignEnum.RightCenter;
			fgrid_YieldValue.Rows[_Row_SpecName].TextAlign = TextAlignEnum.RightCenter;

		}




		/// <summary>
		/// Init_Control : textbox, combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;


			//component combo list 

		    if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
			{
				dt_ret = Select_SBC_COMPONENT_COMBO(_ComponentName.Trim() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);

//				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Component, 0, 1);
//				cmb_Component.Splits[0].DisplayColumns[0].Width = 0;
//				cmb_Component.Splits[0].DisplayColumns[1].Width = 210; 
//				cmb_Component.DropDownWidth = 210;


				txt_Component.Text = _ComponentName.Trim();
				cmb_Component.SelectedText = _ComponentName.Trim();

			}
			else
			{
				dt_ret = Select_SBC_COMPONENT_COMBO(" ");
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);

				txt_Component.Text = _ComponentCd;
				cmb_Component.SelectedValue = _ComponentCd;


			}

			




			//template bom code combo list 
			dt_ret = FlexBase.Yield.Form_BC_BOMTemplate.Select_TemplateTree_Code(" ");
			//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOMTemp, 0, 1, false, 0, 210);

			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_BOMTemp, 0, 1, 2);
			cmb_BOMTemp.Splits[0].DisplayColumns[0].Width = 0;
			cmb_BOMTemp.Splits[0].DisplayColumns[1].Width = 210;
			cmb_BOMTemp.Splits[0].DisplayColumns[2].Width = 100;
			cmb_BOMTemp.DropDownWidth = 210;




//			//srf no combo list 
//			dt_ret = Select_SDD_SRF_HEAD_SRFNO(ClassLib.ComVar.DSFactory);
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SRFNo, 0, 0, false, 0, 210);



			//Style 별 반제 코드 리스트
			string factory = _Factory;
			string stylecd = _StyleCd.Replace("-", "");

			dt_ret = ClassLib.ComFunction.Select_SBC_YIELD_SEMIGOOD(factory, stylecd); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SGCd, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 




			dt_ret.Dispose();


			
			cmb_SGCd.SelectedValue = _SGCd; 
//			txt_Component.Text = _ComponentCd;
//			cmb_Component.SelectedValue = _ComponentCd;

			if(_TemplateTreeCd.Trim().Equals("") )
			{
				_TemplateTreeCd = _OnlyRawMat_TemplateCd;
				_OnlyRawMat = true;
			}

			txt_BOMTemp.Text = _TemplateTreeCd;
			cmb_BOMTemp.SelectedValue = _TemplateTreeCd;


			chk_CreateSizeByValue.Checked = false;
			chk_CreateSizeBySize.Checked = false;



		}



		#region 그리드 트리 관련 메서드


		

		private string _Upload_JointSymbol = "^";




		public void Display_GridTree(DataTable dt_ret)
		{ 
			fgrid_BOMTemp.Rows.Count = fgrid_BOMTemp.Rows.Fixed; 
			
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_BOMTemp.Rows.InsertNode(i + fgrid_BOMTemp.Rows.Fixed, dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL - 1].ToString().Length - 1);			
				insertcell(i, dt_ret.Rows[i].ItemArray);
			}



			if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
			{ 
				if(cmb_BOMTemp.SelectedValue.ToString().Trim() == _OnlyRawMat_TemplateCd)
				{

					string upload_item = _ItemName.Trim();
					string upload_item_temp = upload_item.Substring(0, 1).ToString().Trim();

					if(upload_item_temp == _Upload_JointSymbol) 
					{
						upload_item = upload_item.Substring(1).Trim();
					}  


					fgrid_BOMTemp[fgrid_BOMTemp.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = upload_item;
					fgrid_BOMTemp[fgrid_BOMTemp.Rows.Count - 1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = _ColorName; 

				}
				else   // 임가공 구조일때
				{
					
					Set_RawMat_Joint_FromExcel(_Parent_Form.fgrid_Upload);


				}
  
			}



			SetCols();

			//Raw Material 만 있는 BOM Template 선택했을 경우만 [Add Raw Mateiral] 버튼 활성화
			Set_AddRawMat_Status(); 

			dt_ret.Dispose();  

		} 



		/// <summary>
		/// insertcell : 그리드에 값 넣기
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_incell"></param>
		private void insertcell(int arg_row, object[] arg_incell)
		{
			int rowfixed = fgrid_BOMTemp.Rows.Fixed; 
			 
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxDIVISION] = arg_row + rowfixed;


			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxFACTORY] = arg_incell[0].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSTYLE_CD] = arg_incell[1].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSEMI_GOOD_CD] = arg_incell[2].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD] = arg_incell[3].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = arg_incell[4].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL] = arg_incell[5].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_TREE_CD] = arg_incell[6].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD] = arg_incell[7].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME] = arg_incell[8].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = (arg_incell[9] == null) ? "" : arg_incell[9].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = (arg_incell[10] == null) ? "" : arg_incell[10].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = (arg_incell[11] == null) ? "" : arg_incell[11].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = (arg_incell[12] == null) ? "" : arg_incell[12].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = (arg_incell[13] == null) ? "" : arg_incell[13].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = (arg_incell[14] == null) ? "" : arg_incell[14].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT] = arg_incell[15].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = arg_incell[16].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxATTRIBUTE] = arg_incell[17].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxPROPERTY5] = arg_incell[18].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = arg_incell[19].ToString();
			fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_KEY] = arg_incell[20].ToString();


			
//			// 사이즈 자재 일때 Spec 처리
//			if(Convert.ToBoolean(fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) )
//			{
//				fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = _SizeSpecCd_Value;
//				fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = _SizeSpecName_Value; 
//			}


			// raw material 일때는 unit, size 임의로 변경 불가 처리
			if(fgrid_BOMTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd)
			{
				fgrid_BOMTemp.Rows[arg_row + rowfixed].AllowEditing = false; 
				
				// raw material 글자색 변경
				fgrid_BOMTemp.Rows[arg_row + rowfixed].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;
			}
 

			 



		}



		/// <summary>
		/// Set_RawMat_Joint_FromExcel : 
		/// </summary>
		/// <param name="arg_grid"></param> 
		private void Set_RawMat_Joint_FromExcel(COM.FSP arg_grid)
		{
			// 엑셀 업로드에 의해서 임가공 구조를 바로 입력하려고 할때
			// 엑셀 문서에서 임가공 구조 중 원자재 표시 심볼을 가지고 있는 Material를
			// 1. 선택한 구조의 Raw Material 행에 자동 할당.
			// (엑셀 문서상의 원자재 역순으로 시스템 Raw Material에 할당) 

 
			int upload_row = _Parent_Form.fgrid_Upload.Selection.r1;

			C1.Win.C1FlexGrid.Node parent_node = arg_grid.Rows[upload_row].Node.GetNode(NodeTypeEnum.Parent);

			if(parent_node.Children == 0) return;

			int start_row = parent_node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int end_row = parent_node.GetNode(NodeTypeEnum.LastChild).Row.Index;



			string template_cd = "";

			int upload_item_row = end_row;
			
			string upload_item = ""; 
			string upload_item_temp = "";
			string upload_color = "";


			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{
				template_cd = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim();

				if(template_cd != _RawMatCd) continue;


				if(cmb_BOMTemp.Columns[2].Text.Trim() == "B")
				{

					for(int j = end_row; j >= start_row; j--)
					{

						// spec 이 2개 이상일 때, material 있는 row 만 설정에 적용
						if(arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString().Trim().Equals("") ) continue;


						upload_item = arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString().Trim();
						upload_color = arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOLOR].ToString().Trim();


						upload_item_temp = upload_item.Substring(0, 1).ToString().Trim();

						if(upload_item_temp != _Upload_JointSymbol) continue;
					
						upload_item_row = j;
						upload_item = upload_item.Substring(1).Trim();
					

						fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = upload_item;
						fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = upload_color; 

						end_row = upload_item_row - 1;


						break; 

					} // end for j 

				}
				else if(cmb_BOMTemp.Columns[2].Text.Trim() == "U")
				{

					
					for(int j = start_row; j <= end_row; j++)
					{

						// spec 이 2개 이상일 때, material 있는 row 만 설정에 적용
						if(arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString().Trim().Equals("") ) continue;


						upload_item = arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxMATERIAL].ToString().Trim();
						upload_color = arg_grid[j, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOLOR].ToString().Trim();


						upload_item_temp = upload_item.Substring(0, 1).ToString().Trim();

						if(upload_item_temp != _Upload_JointSymbol) continue;
					
						upload_item_row = j;
						upload_item = upload_item.Substring(1).Trim();
					

						fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = upload_item;
						fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = upload_color; 

						//start_row = start_row + 1;
						start_row = j + 1;


						break; 

					} // end for j 


				}




			} // end for i 




		}





		/// <summary>
		/// setCols : 그리드를 트리 형식으로 표시
		/// </summary>
		private void SetCols()
		{
			fgrid_BOMTemp.Tree.Column = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME;
			fgrid_BOMTemp.Tree.Style = TreeStyleFlags.Complete;
			fgrid_BOMTemp.Tree.Show(-1);
		}
 

		/// <summary>
		/// Set_AddRawMat_Status : Raw Material 만 있는 BOM Template 선택했을 경우만 [Add Raw Mateiral] 버튼 활성화
		/// </summary>
		/// <returns>true : only raw material</returns>
		private bool Set_AddRawMat_Status()
		{
			
			if(_Division == ClassLib.ComVar.Yield_CurrentDIV.Modify) 
			{
				btn_CreateProcCd.Enabled = true;
				return false;
			}


			int findrow = fgrid_BOMTemp.FindRow(_RawMatCd, fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD, false, true, false);
 
			//Raw Material 가 처음에 나올 경우는 트리구조에서 없으므로 raw material만 존재하는 경우가 된다
			if(findrow == fgrid_BOMTemp.Rows.Fixed) 
			{
				_OnlyRawMat = true;
				btn_AddRawMat.Enabled = true;
				btn_CreateProcCd.Enabled = false;
				return true;
			}
			else
			{
				_OnlyRawMat = false;
				btn_AddRawMat.Enabled = false; 
				btn_CreateProcCd.Enabled = true;
				return false;
			}

			


		}


		
		/// <summary>
		/// Set_YieldValue_Spec : 
		/// </summary>
		private void Set_YieldValue_Spec()
		{
			try
			{
				int sel_row = fgrid_BOMTemp.Selection.r1;  
				if(fgrid_BOMTemp.Rows.Count <= fgrid_BOMTemp.Rows.Fixed) return;
				
				// 채산 그리드 왼쪽 포커스 정리
				fgrid_YieldValue.LeftCol = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

				//--------------------------------------------------------------------------------------------------------
				// 사이즈 자재이면 all 사이즈 채산 입력 활성화
				//--------------------------------------------------------------------------------------------------------
				string size_yn = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] == null) 
					             ? "FALSE" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString();

				if(Convert.ToBoolean( size_yn ) )
				{
					lbl_YieldValue.Enabled = false;
					txt_YieldValue.Enabled = false;

					
					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
					{  
						chk_CreateSizeByValue.Enabled = true;
						chk_CreateSizeBySize.Enabled = true;
					}
					else
					{ 
						chk_CreateSizeByValue.Enabled = false;
						chk_CreateSizeBySize.Enabled = false;
					}

					

				}
				else
				{
					lbl_YieldValue.Enabled = true;
					txt_YieldValue.Enabled = true;

					chk_CreateSizeByValue.Enabled = false;
					chk_CreateSizeBySize.Enabled = false;

				}
				//--------------------------------------------------------------------------------------------------------


				//--------------------------------------------------------------------------------------------------------
				// 채산 Setting
				//--------------------------------------------------------------------------------------------------------
				Display_YieldValue(sel_row); 
				//--------------------------------------------------------------------------------------------------------
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_YieldValue_Spec", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		

		/// <summary>
		/// Show_Input_YieldValue_Popup : 채산값 입력 팝업 실행 
		/// 마우스 오른쪽 버튼 클릭 : 한 컬럼 선택해도 팝업 실행 가능
		/// 마우스 왼쪽 버튼 클릭 : 두개 이상의 컬럼 선택 시 팝업 실행 가능
		/// </summary>
		/// <param name="arg_mousebutton"></param>
		private void Show_Input_YieldValue_Popup(MouseButtons arg_mousebutton)
		{
			try
			{ 
				if(fgrid_BOMTemp.Rows.Count <= fgrid_BOMTemp.Rows.Fixed) return;

				int c1 = fgrid_YieldValue.Selection.c1;
				int c2 = fgrid_YieldValue.Selection.c2;

				c1 = (c1 < c2) ? c1 : c2;
				c2 = (c1 < c2) ? c2 : c1;

				if(arg_mousebutton.Equals(MouseButtons.Left) )
				{
					if(c1 == c2) return;
				}


				//-------------------------------------------------------------------------------------------------------------------
				//필수 항목 체크
				if(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				//사이즈 자재일때는 Sepc 필수 항목 제외
				if(! Convert.ToBoolean(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() )
					&& fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				//-------------------------------------------------------------------------------------------------------------------


				string yield_type = _YieldType;
				string cs_size_f = fgrid_YieldValue[1, c1].ToString();
				string cs_size_t = fgrid_YieldValue[1, c2].ToString();
				string yield_value = (fgrid_YieldValue[_Row_YieldValue, c1] == null) ? "0" : fgrid_YieldValue[_Row_YieldValue, c1].ToString();

				string item_sizeyn = fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString();
				string size_yn = Convert.ToBoolean(item_sizeyn) ? "Y" : "N";

				string yield_spec = fgrid_YieldValue[_Row_SpecCd, c1].ToString();

				string item_speccd = (fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null)
					? "" : fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
 


				string spec_div = "";

				if(yield_spec.Trim() == "")
				{
					spec_div = (size_yn == "Y") ? _SizeSpecDiv : item_speccd.Substring(0, 1);
				}
				else
				{
					spec_div = yield_spec.Substring(0, 1);
				}
 


				string spec_cd = (fgrid_YieldValue[_Row_SpecCd, c1] == null) ? "" : fgrid_YieldValue[_Row_SpecCd, c1].ToString();
 


//				string spec_cd = "";
//				string spec_div = "";



//				if(size_yn == "Y")
//				{
//					spec_div = (yield_spec.Trim() == "") ? _SizeSpecDiv : yield_spec.Substring(0, 1);
//					spec_cd = yield_spec;
//
//				}
//				else
//				{
//
//					spec_div = item_speccd.Substring(0, 1);
//					spec_cd = item_speccd;
//
//				}




				string[] pop_parameter = new string[] { yield_type, cs_size_f, cs_size_t, yield_value, size_yn, spec_div, spec_cd }; 
				string spec_name = cs_size_f + "-" + cs_size_t;
 

				//FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter);

				FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter, spec_name);
				pop_form.ShowDialog();


				pop_form.Dispose(); 


				//-----------------------------------------------------------------------------------
				//ClassLib.ComVar.Parameter_PopUp -> 0 : yield value, 1 : spec_cd, 2 : spec_name

				string pop_yield_value = ClassLib.ComVar.Parameter_PopUp[0];
				string pop_spec_cd = ClassLib.ComVar.Parameter_PopUp[1];
				string pop_spec_name = ClassLib.ComVar.Parameter_PopUp[2];

				//cancel 했을 경우
				if(pop_yield_value == "") return;

				//apply 했을 경우
				for(int i = c1; i <= c2; i++)
				{
					fgrid_YieldValue[_Row_YieldValue, i] = pop_yield_value;
					fgrid_YieldValue[_Row_SpecCd, i] = pop_spec_cd;
					fgrid_YieldValue[_Row_SpecName, i] = pop_spec_name; 
				}
				//----------------------------------------------------------------------------------- 
				 
				//채산값 할당
				Make_DT_YieldTail(); 


				//SPEC CODE 별 색깔 표시
				Disaply_Yield_Color();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Input_YieldValue_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		#endregion 

		#region 버튼 이벤트 관련 메서드


		/// <summary>
		/// Search_TemplateTree_List : yield template tree list display
		/// </summary>
		private void Search_TemplateTree_List()
		{ 
			try
			{

				DataTable dt_ret = null;
 

				if(cmb_BOMTemp.SelectedIndex == -1) return;

				string component_cd = "";
				string template_treecd = "";
 
 
				txt_BOMTemp.Text = cmb_BOMTemp.SelectedValue.ToString();

				if(cmb_Component.SelectedIndex != -1)
				{
					component_cd = cmb_Component.SelectedValue.ToString();
				}

 

				//if(_SRF_YN) return;

				
				template_treecd = cmb_BOMTemp.SelectedValue.ToString();

				dt_ret = Select_TemplateTree_List(_Factory, _StyleCd, _SGCd, component_cd, _TemplateSeq, template_treecd);
				Display_GridTree(dt_ret);  


				// Clear yield value return data table 
				_DT_Return.Rows.Clear(); 



				// 채산값 리턴 테이블 생성
				if(_Division == ClassLib.ComVar.Yield_CurrentDIV.Modify)
				{ 
					string[] parameter = new string[] { _Factory, _StyleCd, _SGCd, _ComponentCd, _TemplateSeq, _YieldType}; 

					dt_ret = Select_Yield_Value(parameter);

					Make_DT_YieldTail(dt_ret);
				}  
					 



				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_TemplateTree_List", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}


		/// <summary>
		/// Show_BOMTemplate : 
		/// </summary>
		private void Show_BOMTemplate()
		{
			try
			{
				FlexBase.Yield.Form_BC_BOMTemplate pop_form = new Form_BC_BOMTemplate();
				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal;

				pop_form.ShowDialog();


				// combobox refresh
				// template bom code combo list 
				txt_BOMTemp.Text = "";
				fgrid_BOMTemp.Rows.Count = fgrid_BOMTemp.Rows.Fixed;

				DataTable dt_ret = FlexBase.Yield.Form_BC_BOMTemplate.Select_TemplateTree_Code(txt_BOMTemp.Text.Trim() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOMTemp, 0, 1, false, 0, 210);
				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// Copy_BOMTemplate : 
		/// </summary>
		private void Copy_BOMTemplate()
		{
			try
			{   
				string bom_tempcd = txt_BOMTemp.Text;
 
				FlexBase.Yield.Pop_Yield_Template pop_form = new FlexBase.Yield.Pop_Yield_Template(bom_tempcd); 
				pop_form.ShowDialog(); 

				// 0 : yield_temp_cd, 1 : template_tree_cd

				if(pop_form._CancelFlag) return;

				string yield_temp_cd = ClassLib.ComVar.Parameter_PopUp[0];
				string template_tree_cd = ClassLib.ComVar.Parameter_PopUp[1];
				
				txt_BOMTemp.Text = template_tree_cd;
				cmb_BOMTemp.SelectedValue = template_tree_cd; 



				string component_cd = cmb_Component.SelectedValue.ToString();
				string template_seq = ""; 
				string[] parameter = new string[] { _Factory, _StyleCd, _SGCd, component_cd, template_seq, yield_temp_cd, template_tree_cd };

				DataTable dt_ret = Select_SBC_YIELD_TEMPLATE_COPY(parameter);
				Display_GridTree(dt_ret);
				dt_ret.Dispose();


				// 채산값 리턴 테이블 행 생성

				_DT_Return.Rows.Clear();
				
				_DT_Return_Key old_return_key, new_return_key;

				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{
					old_return_key._RowID = i.ToString();
					old_return_key._Templatekey = (fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL] == null) ? "" : fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString();
					old_return_key._ItemCd = (fgrid_BOMTemp[i, _IxITEM_CD] == null) ? "" :fgrid_BOMTemp[i, _IxITEM_CD].ToString();
					old_return_key._SpecCd = (fgrid_BOMTemp[i, _IxSPEC_CD] == null) ? "" : fgrid_BOMTemp[i, _IxSPEC_CD].ToString();
					old_return_key._ColorCd = (fgrid_BOMTemp[i, _IxCOLOR_CD] == null) ? "" : fgrid_BOMTemp[i, _IxCOLOR_CD].ToString();
					
					new_return_key = old_return_key;


					Add_Row_DT_YieldValue(old_return_key, new_return_key);
				} // end for i




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Copy_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		
 

		/// <summary>
		/// Add_RawMaterial : 
		/// </summary>
		private void Add_RawMaterial()
		{
			try
			{
				if(cmb_BOMTemp.SelectedIndex == -1) return;


				int org_row = fgrid_BOMTemp.Rows.Count - 1; 

				fgrid_BOMTemp.Add_Row(org_row); 
				
				int add_row = fgrid_BOMTemp.Rows.Count - 1; 


				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxFACTORY]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxFACTORY].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSTYLE_CD]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSTYLE_CD].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSEMI_GOOD_CD]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSEMI_GOOD_CD].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "";
				
				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_TREE_CD]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_TREE_CD].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString();

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME]
					= fgrid_BOMTemp[org_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME].ToString(); 

				fgrid_BOMTemp[add_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = "False";
				

				// raw material 글자색 변경
				fgrid_BOMTemp.Rows[add_row].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;


				SetCols();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Add_RawMaterial", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private bool _Apply_CreateProcess = false;



		/// <summary>
		/// Create_Process_Code : process code 자동 할당
		/// </summary>
		private void Create_Process_Code()
		{
			try
			{
				if(fgrid_BOMTemp.Rows.Count <= fgrid_BOMTemp.Rows.Fixed) return;

				//already item/ spec/ color setting
				bool check_ok = Check_Create_Condition(false);

				if(!check_ok) return;



				if(_Division == ClassLib.ComVar.Yield_CurrentDIV.Modify) _Apply_CreateProcess = true;

				


				// item_name2 자동 할당 여부 체크, 자동 할당
				// template_key 구성
				Set_Process_Code(); 

				// item_name1 자동 할당 여부 체크, 자동 할당
				Set_ItemName1(); 
 

				// sbc_color, sbc_item, sbc_yield_template 저장
				Save_Template(); 

				
				// 채산값 리턴 테이블 행 생성  
				_DT_Return_Key old_return_key, new_return_key;

				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{
					old_return_key._RowID = i.ToString();
					old_return_key._Templatekey = (fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL] == null) ? "" : fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString();
					old_return_key._ItemCd = (fgrid_BOMTemp[i, _IxITEM_CD] == null) ? "" :fgrid_BOMTemp[i, _IxITEM_CD].ToString();
					old_return_key._SpecCd = (fgrid_BOMTemp[i, _IxSPEC_CD] == null) ? "" : fgrid_BOMTemp[i, _IxSPEC_CD].ToString();
					old_return_key._ColorCd = (fgrid_BOMTemp[i, _IxCOLOR_CD] == null) ? "" : fgrid_BOMTemp[i, _IxCOLOR_CD].ToString();
					
					new_return_key = old_return_key;


					Add_Row_DT_YieldValue(old_return_key, new_return_key);
				} // end for i

 
				

				if(! _Apply_CreateProcess) _Apply_CreateProcess = true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create_Process_Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

 

		#region Create_Process_Code() 관련 메서드

		/// <summary>
		/// Check_Create_Condition : already item/ spec/ color setting
		/// </summary>
		/// <param name="arg_flag">true : 임가공까지 체크, false : 임가공 제외 체크</param>
		/// <returns></returns>
		private bool Check_Create_Condition(bool arg_flag)
		{

			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{
				// process name 만들때는 임가공 행은 필수 검사 안하기 위함
				if(! arg_flag)
				{
					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() != _RawMatCd) continue;
				}

				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Trim().Equals("") ) 
				{
					ClassLib.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					fgrid_BOMTemp.Select(i, 0, i, fgrid_BOMTemp.Cols.Count - 1, false);

					return false;
				}

			} // end for i


			return true; 
		}


		/// <summary>
		/// Set_Process_Code : item_name2 자동 할당 여부 체크, 자동 할당 
		/// </summary>
		private void Set_Process_Code()
		{ 
 		
			DataTable dt_ret = Check_Exist_Equal_Template();

			// 중복 아님 - new process name setting 
			if(dt_ret.Rows.Count == 0) 
			{ 
				_Exist_Template = false;

				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{
					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue; 

					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = "";
					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = "";
					 
				} // end for i
  
			} 
			else // proess name setting - search
			{
				_Exist_Template = true;

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_BOMTemp[i + fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_CD].ToString();

					fgrid_BOMTemp[i + fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_NAME].ToString(); 



					if(fgrid_BOMTemp[i + fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue;

					fgrid_BOMTemp[i + fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_NAME1].ToString(); 


				} // end for i


				// Clear Division Flag 
				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{
					fgrid_BOMTemp[i, 0] = "";
				}

			}
		




			// item name 2 자동 할당
			Auto_Create_ItemName2();





			dt_ret.Dispose(); 

 
		}

 


		/// <summary>
		/// Check_Exist_Equal_Template : 
		/// </summary>
		/// <returns></returns>
		private DataTable Check_Exist_Equal_Template()
		{
			
//			string template_tree_cd = "";
//			string template_level = "", item_cd = "", template_string = "";
//			int raw_mat_count = 0;
//
//			template_tree_cd = cmb_BOMTemp.SelectedValue.ToString();
//			
//			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
//			{
//				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() != _RawMatCd) continue;
//
//				raw_mat_count++;
//
//				template_level = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
//				item_cd = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
//
//				if(template_string.Equals("") )
//				{
//					template_string = @"'" + template_level + item_cd + @"'";
//				}
//				else
//				{
//					template_string += @", '" + template_level + item_cd + @"'";
//				} 
//
//			} // end for i
//
//			
//			// db connect
//			DataTable dt_ret = Check_Exist_Equal_Template(template_tree_cd, template_string, raw_mat_count.ToString() );	
//
//			return dt_ret;



			string template_tree_cd = ""; 
			string template_string = "";
			int raw_mat_count = 0;
			string template_level = "";
			string item_cd = "";
			string item_name = "";

			template_tree_cd = cmb_BOMTemp.SelectedValue.ToString();
			
			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{ 

//				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] != null
//					&& ! fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Equals("") )
//				{
//					raw_mat_count++;
//				}


				raw_mat_count++;



				template_level = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
				item_cd = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
				item_name = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME].ToString();

				
				// template_level || '':'' ||  item_name in (' || TRIM(ARG_TEMPLATE) || ') '


				if(template_string.Equals("") )
				{
					//template_string = @"'" + item_name + @"'";

					template_string = @"'" + template_level + @":" + item_name.Replace("'", "''") + @"'";

				}
				else
				{
					//template_string += @", '" + item_name + @"'";

					template_string += @", '" + template_level + @":" + item_name.Replace("'", "''") + @"'";

				} 





			} // end for i

			
			// db connect
			DataTable dt_ret = Check_Exist_Equal_Template(template_tree_cd, template_string, raw_mat_count.ToString() );	

			return dt_ret;


		}


 
		private string _Symbol_PropertyName = "@";



		
			  
 
		//라미네이션, 스티커, 핫멜트, 라바 라미네이션, DOT HOT MELT, BALL HOT MELT, NO SEW, FUSE
		private string _Lamination = "02J06000";
		private string _Stiker = "02J11000";
		private string _HotMelt = "02J04000";
		private string _RubberLamination = "02J10000";
		private string _BallHotMelt = "02J20000";
		private string _DotHotMelt = "02J21000";
		private string _NoSew = "02J27000";
		private string _Fuse = "02J28000";


		//컬러 코드 자동 할당
		private string _SubLimation = "02J12000";
		private string _SubLimationPaper = "01D11000";
		//private string _SubLimationInsole = "02J18000";
		private string _Printing = "02J14000";
		private string _Painting = "02J08000";
        private string _ShieldGraphic = "02J26000";
        private string _HeatTransfer = "02J24000";
        private string _PuffScreen = "02J25000";





		/// <summary>
		/// Auto_Create_ItemName2 : item name 2 자동 할당
		/// </summary>
		private void Auto_Create_ItemName2()
		{
  

			int col_template_level = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL; 
			int col_template_cd = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD;
			int col_template_name = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME;
			int col_item_name = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME;
			int col_template_key = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_KEY;
			//int col_color_cd = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD;
			int col_color_name = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME;
			int col_attribute = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxATTRIBUTE;


			string name2_string = "";
			string template_key_temp = "", template_key = "";
			string color_string = "";

 
			// 임가공 처음 구분자
			// 처음일때는 대괄호 포함하지 않기 위해서
			bool first_j = true;

			int start_row = -1, end_row = -1;
			int parent_row = -1;

			


			int max_template_level_length = 0;
			int now_template_level_length = 0;

			 
			string before_parent_level = "", now_parent_level = "";



			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{

				now_template_level_length = fgrid_BOMTemp[i, col_template_level].ToString().Length;

				max_template_level_length = (max_template_level_length < now_template_level_length) 
					? now_template_level_length : max_template_level_length;

 

				fgrid_BOMTemp[i, col_template_key] = fgrid_BOMTemp[i, col_template_cd].ToString().Substring(3, 2);

			}




			now_template_level_length = 0; 


			// max level length ~ 2 level : 상위 레벨까지 계산 되므로 1 레벨은 포함하지 않음
			for(int a = max_template_level_length; a >= 2; a--)
			{

				C1.Win.C1FlexGrid.Node node; 


				for(int b = fgrid_BOMTemp.Rows.Fixed;  b < fgrid_BOMTemp.Rows.Count; b++)
				{


					now_template_level_length = fgrid_BOMTemp[b, col_template_level].ToString().Length;
					if(now_template_level_length != a) continue;


					now_parent_level = fgrid_BOMTemp[b, col_template_level].ToString().Substring(0, now_template_level_length - 1); 
					if(before_parent_level == now_parent_level) continue;


					name2_string = "";
					color_string = "";
					template_key = "";


					node = fgrid_BOMTemp.Rows[b].Node; 

					start_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.FirstChild).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.Parent).GetNode(NodeTypeEnum.LastChild).Row.Index; 
					parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;
 



					//raw material string
					for(int j = start_row; j <= end_row; j++)
					{ 
					
						// child 중에 임가공 공정이 하나라도 있을때
						if(fgrid_BOMTemp[j, col_template_cd].ToString() != _RawMatCd) 
						{ 
							first_j = false;
							break;

						}
						else
						{
							first_j = true;
						}
					} // end for j
 


					string[] token = null;
					string item_name = "";

					//raw material string
					for(int j = start_row; j <= end_row; j++)
					{  
						 
						now_template_level_length = fgrid_BOMTemp[j, col_template_level].ToString().Length;
						if(now_template_level_length != a) continue;


						//---------------------------------------------------------------------------------------------
						token = fgrid_BOMTemp[j, col_item_name].ToString().Split(_Symbol_PropertyName.ToCharArray() ); 
						item_name = token[0];
						//---------------------------------------------------------------------------------------------


						if(name2_string.Equals("") )
						{
							//name2_string = fgrid_BOMTemp[j, col_item_name].ToString(); 
							name2_string = item_name;

							color_string = fgrid_BOMTemp[j, col_color_name].ToString();  
						}
						else
						{
							//name2_string += "+" + fgrid_BOMTemp[j, col_item_name].ToString(); 
							name2_string += "+" +  item_name;

							color_string += "/" + fgrid_BOMTemp[j, col_color_name].ToString(); 
						}
  

						

						//template_key string : 02Jxx000 구조에서 xx 가 template key 구성 요소  
						template_key_temp = fgrid_BOMTemp[j, col_template_key].ToString();   
						template_key = template_key + template_key_temp; 

					} // end for j 
			


					//임가공 string 조합 
					if(first_j == false)
					{  
						name2_string = "[" + name2_string + "]" + "<" + fgrid_BOMTemp[parent_row, col_template_name].ToString() + ">"; 
					}
					else
					{ 	 
						name2_string += "<" + fgrid_BOMTemp[parent_row, col_template_name].ToString() + ">"; 
					} 




					//-------------------------------------------------------------------------------------------------------------------
					// model, style, component, gender 종속 여부 item_name2 에 추가
					// 조합 순서 : [model name][style code][gender][component code]
					//-------------------------------------------------------------------------------------------------------------------
					

					// 종속 이름 연결할때 구분자 이용
					if(fgrid_BOMTemp[parent_row, col_attribute] != null
						&& fgrid_BOMTemp[parent_row, col_attribute].ToString() != "0000" )
					{
						name2_string += _Symbol_PropertyName;
					}

					

					// model
					if(fgrid_BOMTemp[parent_row, col_attribute] != null
						&& fgrid_BOMTemp[parent_row, col_attribute].ToString().Substring(0, 1) == "1" )
					{
						name2_string += "[" + _ModelName + "]";
					}

					// style
					if(fgrid_BOMTemp[parent_row, col_attribute] != null
						&& fgrid_BOMTemp[parent_row, col_attribute].ToString().Substring(1, 1) == "1" )
					{
						name2_string += "[" + _StyleCd.Replace("-", "").Substring(0, 6) + "-" + _StyleCd.Replace("-", "").Substring(6) + "]";
					}

					// gender
					if(fgrid_BOMTemp[parent_row, col_attribute] != null
						&& fgrid_BOMTemp[parent_row, col_attribute].ToString().Substring(3, 1) == "1" )
					{
						name2_string += "[" + _Gen + "]";
					}

					// component
					if(fgrid_BOMTemp[parent_row, col_attribute] != null
						&& fgrid_BOMTemp[parent_row, col_attribute].ToString().Substring(2, 1) == "1" )
					{
						name2_string += "[" + cmb_Component.Columns[1].Text + "]";
					}

					

					//-------------------------------------------------------------------------------------------------------------------




					//template_key string : 02Jxx000 구조에서 xx 가 template key 구성 요소  
					template_key_temp = fgrid_BOMTemp[parent_row, col_template_key].ToString(); 
					template_key = template_key_temp + template_key;
  

					fgrid_BOMTemp[parent_row, col_item_name] = name2_string;  

 

					
					if(_Apply_CreateProcess)
					{ 


						// color code 자동 할당 제외
						if(fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _SubLimation
							|| fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _SubLimationPaper
							//|| fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _SubLimationInsole
							|| fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _Printing
							|| fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _Painting
                            || fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _ShieldGraphic
                            || fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _HeatTransfer
                            || fgrid_BOMTemp[parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _PuffScreen)
						{
						
						}
                        // color code 자동 할당
						else
						{

							fgrid_BOMTemp[parent_row, col_color_name] = color_string;  

						}


					}
					else
					{
						fgrid_BOMTemp[parent_row, col_color_name] = color_string;  
					}


					
					fgrid_BOMTemp[parent_row, col_template_key] = template_key; 

					if(first_j == true) first_j = false;  

					before_parent_level = now_parent_level;


				} // end for b



			} // end for a
 

 

		}




		/// <summary>
		/// Set_ItemName1 : 
		/// </summary>
		private void Set_ItemName1()
		{ 
			
//			// 중복 아님 : 새로 생성
//			if(! _Exist_Template)
//			{
				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{ 

					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue;

					// item name 1 자동 할당
					Auto_Create_ItemName1(i); 



				} // end for i
//			} 


		}



		/// <summary>
		/// Auto_Create_ItemName1 : item name 1 자동 할당
		/// </summary>
		/// <param name="arg_row"></param>
		private void Auto_Create_ItemName1(int arg_row)
		{ 
			int col_attribute = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxATTRIBUTE;
			int col_property5 = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxPROPERTY5;
			int col_item_name1 = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1; 
			int col_process_name = (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME;

			string item_name1 = "";

			//-------------------------------------------------------------------------------------------------------------------
			// model, style, component, gender 종속 여부
			// 조합 순서 : [model name][style code][gender][component code]
			//------------------------------------------------------------------------------------------------------------------- 

			// property
			if(fgrid_BOMTemp[arg_row, col_property5] != null)
			{
				item_name1 = fgrid_BOMTemp[arg_row, col_property5].ToString();
			}

			// model
			if(fgrid_BOMTemp[arg_row, col_attribute] != null
				&& fgrid_BOMTemp[arg_row, col_attribute].ToString().Substring(0, 1) == "1" )
			{
				item_name1 += "[" + _ModelName + "]";
			}

			// style
			if(fgrid_BOMTemp[arg_row, col_attribute] != null
				&& fgrid_BOMTemp[arg_row, col_attribute].ToString().Substring(1, 1) == "1" )
			{
				item_name1 += "[" + _StyleCd.Replace("-", "").Substring(0, 6) + "-" + _StyleCd.Replace("-", "").Substring(6) + "]";
			}

			// gender
			if(fgrid_BOMTemp[arg_row, col_attribute] != null
				&& fgrid_BOMTemp[arg_row, col_attribute].ToString().Substring(3, 1) == "1" )
			{
				item_name1 += "[" + _Gen + "]";
			}

			// component
			if(fgrid_BOMTemp[arg_row, col_attribute] != null
				&& fgrid_BOMTemp[arg_row, col_attribute].ToString().Substring(2, 1) == "1" )
			{
				item_name1 += "[" + cmb_Component.Columns[1].Text + "]";
			}

			



			// 마지막에 임가공 프로세스 이름 추가
			item_name1 += "[" + fgrid_BOMTemp[arg_row, col_process_name].ToString() + "]"; 

			fgrid_BOMTemp[arg_row, col_item_name1] = item_name1;


		}



		/// <summary>
		/// Check_Exist_Item : 
		/// </summary>
		/// <param name="arg_row"></param>
		/// <returns></returns>
		private DataTable Check_Exist_Item(int arg_row)
		{
			string now_template_key = "";
			string now_item_name = "";
			string now_level = "";

			string template_cd = "";
			string template_level = "", template_level_no = "";
			string item_cd = "";
			string template_string = "";

			int raw_mat_count = 0;
 

			now_template_key = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_KEY].ToString();
			now_item_name = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME].ToString().Replace("'", "''"); 
			now_level = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString(); 

			  
			// 현재 임가공 프로세스 이하 레벨 구조 중복 체크하기 위함
			for(int i = arg_row + 1; i < fgrid_BOMTemp.Rows.Count; i++)
			{ 
				template_cd = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString();
				template_level = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
				template_level_no = template_level.Substring(template_level.Length - 1, 1);
				item_cd = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();


				//  현재 임가공 프로세스 이하 자식 레벨만 구조 중복 체크
				if(now_level.Length > template_level.Length) continue;
				if(now_level != template_level.Substring(0, now_level.Length) ) continue;


				raw_mat_count++;

				if(template_string.Equals("") )
				{
					template_string = @"'" + template_cd + template_level_no + item_cd + @"'";
					//template_string = @"'" + template_cd + template_level + item_cd + @"'";
				}
				else
				{
					template_string += @", '" + template_cd + template_level_no + item_cd + @"'";
					//template_string += @", '" + template_cd + template_level + item_cd + @"'";
				} 

			} // end for i

			
			// db connect
			DataTable dt_ret = Check_Exist_Item(now_template_key, now_item_name, template_string, raw_mat_count.ToString() );	

			return dt_ret;
		}





		/// <summary>
		/// Check_Exist_Item : 
		/// </summary>
		/// <param name="arg_templatekey"></param>
		/// <param name="arg_template_string"></param>
		/// <returns>not null : 중복
		///          null     : 중복 아님</returns>
		private DataTable Check_Exist_Item(string arg_templatekey, string arg_item_name, string arg_template, string arg_raw_mat_count)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(5); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.CHECK_EXIST_EQUAL_ITEM";
  
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_KEY";
			MyOraDB.Parameter_Name[1] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[2] = "ARG_TEMPLATE"; 
			MyOraDB.Parameter_Name[3] = "ARG_RAW_MAT_COUNT"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_templatekey, " ");  
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_item_name, " ");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_template, " ");  
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(arg_raw_mat_count, " ");   
			MyOraDB.Parameter_Values[4] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


 


		

		/// <summary>
		/// Check_Exist_Color : 
		/// </summary>
		/// <param name="arg_row"></param>
		/// <returns></returns>
		private DataTable Check_Exist_Color(int arg_row)
		{
			string color_name = "";
 

			color_name = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME].ToString(); 
			
			// db connect
			DataTable dt_ret = Check_Exist_Color(color_name);	

			return dt_ret;
		}


		/// <summary>
		/// Check_Exist_Color : 
		/// </summary> 
		private DataTable Check_Exist_Color(string arg_colorname)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.CHECK_EXIST_EQUAL_COLOR";
  
			MyOraDB.Parameter_Name[0] = "ARG_COLOR_NAME"; 
			MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_colorname, " ");  
			MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[2] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}




		/// <summary>
		/// Save_Template : 
		/// </summary>
		private void Save_Template()
		{
  

			DataTable dt_ret = null; 

			for(int i = fgrid_BOMTemp.Rows.Count - 1; i >= fgrid_BOMTemp.Rows.Fixed; i--)
			{
				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue;

				dt_ret = Check_Exist_Item(i); 
				
				if(dt_ret.Rows.Count != 0)
				{ 
					// 기존 아이템 코드 적용
					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = dt_ret.Rows[0].ItemArray[0].ToString();
				} 
				else
				{
					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = "";
				}
   

			} // end for i 

 

			 

			bool color_ok = true;
			int ct_new_color = 0;


			//필수 항목 체크
			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{
				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() != _RawMatCd) continue;

				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					color_ok = false;
					break;
				}
			}


			if(color_ok)
			{
				for(int i = fgrid_BOMTemp.Rows.Count - 1; i >= fgrid_BOMTemp.Rows.Fixed; i--)
				{
					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue; 
				 

					dt_ret = Check_Exist_Color(i); 
				
					if(dt_ret.Rows.Count != 0)
					{ 
						// 기존 Color 코드 적용
						fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = dt_ret.Rows[0].ItemArray[0].ToString();
					}  
 

//					// spec : default : "nothing" 처리
//					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = _SizeSpecCd_Value;
//					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = _SizeSpecName_Value;

 

					
					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null 
						|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString() == "")
					{

						// 임가공 공정이 stiker, hotmelt, rubber lamination, ball hotmelt, dot hotmelt 일때, 하위 원자재 스펙 그대로 적용처리
						if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _Stiker
							|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _HotMelt
							|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RubberLamination
							|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _BallHotMelt
							|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _DotHotMelt) 
						{
							
							int child_row = fgrid_BOMTemp.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;

							fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD]
								= fgrid_BOMTemp[child_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString(); 

							fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME]
								= fgrid_BOMTemp[child_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();  


						}
						else
						{ 
 


//							fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = _SizeSpecCd_Value;
//							fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = _SizeSpecName_Value;


							// 임가공 공정 조합 (Lamination)  
							if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _Lamination)
							{

								// 1. 원자재 모두 spec 이 동일한 경우 -> 원자재 spec 할당
								int row_child_first = fgrid_BOMTemp.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
								int row_child_last = fgrid_BOMTemp.Rows[i].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

								int count_not_equal_spec = 0;
								string before_spec = fgrid_BOMTemp[row_child_first, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
								string now_spec = "";


								for(int aa = row_child_first; aa <= row_child_last; aa++)
								{
									
									if(fgrid_BOMTemp.Rows[aa].Node.GetNode(NodeTypeEnum.Parent).Row.Index != i) continue;  // parnet 가 lamination 일때만 계산

									now_spec = fgrid_BOMTemp[aa, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();

									if(before_spec != now_spec)
									{
										count_not_equal_spec++;
									}


									before_spec = now_spec;


								} // end for aa
  

								if(count_not_equal_spec == 0)  // 하위 공정 spec 모두 동일한 경우
								{

									fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] 
										= fgrid_BOMTemp[row_child_first, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();

									fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] 
										= fgrid_BOMTemp[row_child_first, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();

								}
								else
								{
									fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = _SizeSpecCd_Value;
									fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = _SizeSpecName_Value;
								}





								// 2. 같은 구조 ( 00 mm * 00 " ) 인 경우 -> 합계 처리 spec 할당
								// ex) 1.2mm * 44 " + 44 " + 1.0mm * 44" = 2.2mm * 44"





							}
							else  // lamination 아닌 경우
							{

								fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = _SizeSpecCd_Value;
								fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = _SizeSpecName_Value;

							}






						
						}

					}  // spec 이 공백일 때, 


					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString() == "") 
					{ 
						ct_new_color++;
					} // end if

	 
				} // end for i 


				

				if(ct_new_color > 0)  //1)
				{
					//ClassLib.ComFunction.User_Message("New Color", "Color", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					string message = "아래 임가공 코드는 컬러를 먼저 선택해야 합니다."
						+ "\r\n"
						+ "\r\n" + "SubLimation"
						+ "\r\n" + "SubLimationPaper"
						+ "\r\n" + "SubLimationInsole"
						+ "\r\n" + "Printing"
						+ "\r\n" + "Painting"
						+ "\r\n" + "ShieldGraphic";



					ClassLib.ComFunction.User_Message(message, "Select Color", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					return;
				}




			} // end if(color_ok) 


			dt_ret.Dispose();
 

			//------------------------------------------------------------------------------------ 


			// 신규 저장 처리 
			// item_cd 가 없는것만 신규로 sbc_item 에 저장 처리
			Save_New_ITem_YieldTemplate();


		}


		/// <summary>
		/// Save_New_ITem_YieldTemplate : 신규 아이템 코드 일때 저장
		/// </summary>
		private void Save_New_ITem_YieldTemplate()
		{
			//  save 후 search 
			bool save_ok = false; 

			save_ok = Save_Item_YieldTemplate();

			if(!save_ok)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				return;
			}
			else
			{  
				 
				//임가공 아이템 코드 재조회
				DataTable dt_ret = Check_Exist_Equal_Template();

				if(dt_ret.Rows.Count != 0)
				{
					for(int i = 0; i < dt_ret.Rows.Count; i++)
					{


						int findrow = -1;
						string template_level = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxTEMPLATE_LEVEL].ToString().Trim();
 
						findrow = fgrid_BOMTemp.FindRow(template_level, fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL, false, true, false);

						if(findrow == -1) continue;


						// 2009-02-11
						// item 공백 있으면 다시 조회
						if(fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null
							|| fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Trim().Equals(""))
						{
						
							fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] 
								= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_CD].ToString();

							fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] 
								= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_NAME1].ToString();

							fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] 
								= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_TREE_PROCNAME.IxITEM_NAME].ToString();

						}


						//--------------------------------------------------------------------------------------------------------------------- 
						// 임가공 이고, item/spec/color 모두 세팅 되었을 경우,
						// 리턴 테이블에 채산값 자동 할당 
						//--------------------------------------------------------------------------------------------------------------------- 
						
					    if(fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _RawMatCd) continue;

						if(fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Trim().Equals("") 
							|| fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString().Trim().Equals("") 
							|| fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString().Trim().Equals("")  ) continue;


						// 채산값 리턴 테이블 행 생성
						// modify 일때는 채산값 그대로 처리 
						string dt_template_level = fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
						string dt_item = fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
						string dt_spec = fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
						string dt_color = fgrid_BOMTemp[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();
  
 
						_DT_Return_Key old_return_key, new_return_key;
 
						old_return_key._RowID = findrow.ToString();
						old_return_key._Templatekey = dt_template_level;
						old_return_key._ItemCd = dt_item;
						old_return_key._SpecCd = dt_spec;
						old_return_key._ColorCd = dt_color;
				

						new_return_key._RowID = findrow.ToString();
						new_return_key._Templatekey = dt_template_level;
						new_return_key._ItemCd = dt_item;
						new_return_key._SpecCd = dt_spec;
						new_return_key._ColorCd = dt_color; 

						Add_Row_DT_YieldValue(old_return_key, new_return_key);  



						string condition = "DIVISION = '" + findrow.ToString() + "'";
						DataRow[] findrow_1 = _DT_Return.Select(condition); 
						Disaply_Already_YieldValue(findrow, findrow_1);
						//--------------------------------------------------------------------------------------------------------------------- 






					} // end for i

 


				} // end if(dt_ret.Rows.Count != 0)
				dt_ret.Dispose(); 
				  

			} // end if (save_yield_template) 
			

		}
 


		

		/// <summary>
		/// Save_Item_YieldTemplate : 동일한 yield template가 없을때 저장 처리
		/// </summary>
		/// <returns></returns>
		private bool Save_Item_YieldTemplate()
		{ 
			try
			{
  
				DataSet ds_ret;

				int col_ct = 15;	 						 
				int para_ct =0; 


 		 
				//---------------------------------------------------------------------------------------------
				// get next yield template code
				string sql = "SELECT LPAD(NVL(MAX(SUBSTR(YIELD_TEMP_CD,1,5)),0)+1,5,'0') AS YIELD_TEMP_CD" 
					+ "  FROM SBC_YIELD_TEMPLATE" ;

				ds_ret = MyOraDB.Exe_Select_Query(sql);
				string yield_temp_cd = ds_ret.Tables[0].Rows[0].ItemArray[0].ToString(); 
				//---------------------------------------------------------------------------------------------


				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.INSERT_SBC_YIELD_TEMPLATE";
  
				MyOraDB.Parameter_Name[0] = "ARG_MAT_TYPE";
				MyOraDB.Parameter_Name[1] = "ARG_YIELD_TEMP_CD";
				MyOraDB.Parameter_Name[2] = "ARG_TEMPLATE_TREE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_TEMPLATE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_LEVEL";
				MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_STAGE";
				MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[7] = "ARG_ITEM_NAME2";
				MyOraDB.Parameter_Name[8] = "ARG_TEMPLATE_KEY"; 
				MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[10]= "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[11] = "ARG_ITEM_NAME1";
				MyOraDB.Parameter_Name[12] = "ARG_SIZE_YN";
				MyOraDB.Parameter_Name[13] = "ARG_USE_YN";
				MyOraDB.Parameter_Name[14] = "ARG_MNG_UNIT";
				 
 
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	  
			 

			
				MyOraDB.Parameter_Values  = new string[ col_ct * (fgrid_BOMTemp.Rows.Count - fgrid_BOMTemp.Rows.Fixed) ]; 



				//---------------------------------------------------------------------------------------------------------------
				// template 구조 신규 처리 위함
				//---------------------------------------------------------------------------------------------------------------
				bool new_template = false;

				for(int row = fgrid_BOMTemp.Rows.Fixed; row < fgrid_BOMTemp.Rows.Count; row++)
				{
					if(fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd) continue; 

					if(fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Trim() != "") continue;

					if(! new_template)
					{
						new_template = true;
					}

				}
				//--------------------------------------------------------------------------------------------------------------- 





				for(int row = fgrid_BOMTemp.Rows.Count - 1; row >= fgrid_BOMTemp.Rows.Fixed; row--)
				{
//					if(fgrid_BOMTemp[row, 0].ToString() != "")
//					{  

						if(fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd)
						{
							MyOraDB.Parameter_Values[para_ct] = _TypeMat;
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct] = _TypeJoint;
						}
 

						//if(fgrid_BOMTemp[row, 0].ToString().Trim() == "")
					    if(! new_template)
						{
							// 임가공 구조는 저장되어 있지만, 임가공 아이템에 대한 size_yn, mng_unit 수정
							MyOraDB.Parameter_Values[para_ct + 1] = "-1";  
							
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct + 1] = yield_temp_cd;
						}
						
						

						MyOraDB.Parameter_Values[para_ct + 2] = cmb_BOMTemp.SelectedValue.ToString(); //"ARG_TEMPLATE_TREE_CD";
						MyOraDB.Parameter_Values[para_ct + 3] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString(); //"ARG_TEMPLATE_CD";
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString(); //"ARG_TEMPLATE_LEVEL";
						MyOraDB.Parameter_Values[para_ct + 5] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString().Length.ToString(); //"ARG_TEMPLATE_STAGE";
						
//						MyOraDB.Parameter_Values[para_ct + 6] = (fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null) 
//							? "" : fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString(); // "ARG_ITEM_CD";

						if(fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null 
							|| fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Equals("") )
						{

							MyOraDB.Parameter_Values[para_ct + 6] = "-1";

						}
						else
						{

							MyOraDB.Parameter_Values[para_ct + 6] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();

						}

						MyOraDB.Parameter_Values[para_ct + 7] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME].ToString(); //"ARG_ITEM_NAME2";
						MyOraDB.Parameter_Values[para_ct + 8] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_KEY].ToString(); //"ARG_TEMPLATE_KEY"
						MyOraDB.Parameter_Values[para_ct + 9] = ClassLib.ComVar.This_User;									 // "ARG_UPD_USER";
						MyOraDB.Parameter_Values[para_ct + 10]= fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString(); //  "ARG_GROUP_CD";
						MyOraDB.Parameter_Values[para_ct + 11] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1].ToString(); //  "ARG_ITEM_NAME1";
						MyOraDB.Parameter_Values[para_ct + 12] = (Convert.ToBoolean(fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) ) ? "Y" : "N"; // "ARG_SIZE_YN";
						MyOraDB.Parameter_Values[para_ct + 13] = "Y";								 //  "ARG_USE_YN";
						MyOraDB.Parameter_Values[para_ct + 14] = fgrid_BOMTemp[row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString(); //  "ARG_MNG_UNIT";

				
						para_ct += col_ct;

 
//					}
				}

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
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_Item_YieldTemplate",MessageBoxButtons.OK,MessageBoxIcon.Error); 
				return false;
			}
		}




		#endregion 

		#region Return DataTable 관련 메서드

		
		/// <summary>
		/// Select Item Data and Yield Value Data Return
		/// </summary>
		private void Return_Data()
		{
			try
			{
				if(cmb_SGCd.SelectedIndex == -1 || cmb_BOMTemp.SelectedIndex == -1 || cmb_Component.SelectedIndex == -1) return;
				
				// component 중복 체크 한번 더
				if(_DuplicateComp == cmb_Component.SelectedValue.ToString())
				{
					string message = "Duplicate Component : [" + cmb_Component.Columns[1].Text + "]";
					ClassLib.ComFunction.User_Message(message, "Check_Duplicate_Component", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						
					txt_Component.Text = "";
					cmb_Component.SelectedIndex = -1;
					
					_Cancel_Flag = true;
					return;
				}


				bool check_ok = false;

				// already item/ spec/ color setting
				check_ok = Check_Create_Condition(true);

				if(!check_ok) 
				{
					_Cancel_Flag = true;
					return;  
				}

				 
				// all setting yield value check
				check_ok = Check_All_Setting_YieldValue();

				if(!check_ok) 
				{
					_Cancel_Flag = true;
					return;  
				}
 
				 

				ClassLib.ComVar.Yield_CurrentDIV before_division = _Division;

				if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
				{
  
					string current_type = "", current_sg = "", current_component = "";

					for(int i = _Parent_Form.fgrid_Yield.Rows.Fixed; i < _Parent_Form.fgrid_Yield.Rows.Count; i++)
					{

						current_type = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString(); 
						current_sg = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						current_component = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
 

						if(current_type == _TypeCmp)
						{
							if(current_sg == _SGCd && current_component == cmb_Component.SelectedValue.ToString() )
							{  
								_Division = ClassLib.ComVar.Yield_CurrentDIV.AddTemplate;

								break;
							}
							else
							{
								_Division = ClassLib.ComVar.Yield_CurrentDIV.AddCmp;
							}


						} // end if 

					} // end for i 


					// default : add component
					if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
					{
						_Division = ClassLib.ComVar.Yield_CurrentDIV.AddCmp;
					}


				} // end if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)




				switch(_Division)
				{
					case ClassLib.ComVar.Yield_CurrentDIV.AddCmp:

						// Make component row
						Make_DT_YieldHead_Component(); 
						break;  

				} 

				fgrid_YieldValue.Select(fgrid_YieldValue.Selection.r1, fgrid_YieldValue.Selection.c1, false);

				// Make head data
				Make_DT_YieldHead();
				 


				//--------------------------------------------------------------------------------------
				// excel upload 일때만 처리.
				//--------------------------------------------------------------------------------------
				if(before_division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
				{

					// return table 모두 반제는 같으므로 0번행으로 반제 세팅
					string sg_cd = _DT_Return.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString().Trim();
					string component_cd = _DT_Return.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();

					int insert_row = -1;

					//sg
					int findrow = _Parent_Form.fgrid_Yield.FindRow(sg_cd, _Parent_Form.fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD, false, true, false);
					_Parent_Form._Before_SGCd = sg_cd;

					if(findrow == -1) return; 

					insert_row = findrow;

					C1.Win.C1FlexGrid.Node node = _Parent_Form.fgrid_Yield.Rows[findrow].Node;
					if(node.Children != 0)  // component 있는 경우
					{
						//comonent
						findrow = _Parent_Form.fgrid_Yield.FindRow(component_cd, _Parent_Form.fgrid_Yield.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD, false, true, false); 
				
						//해당 component 없으면 상위에 추가
						insert_row = (findrow == -1) ? insert_row : findrow;
					}

					if(_DT_Return != null && _DT_Return.Rows.Count != 0) 
					{
						_Parent_Form.Apply_Grid(_DT_Return, insert_row);
					} 

				}
					//--------------------------------------------------------------------------------------
				else if(before_division == ClassLib.ComVar.Yield_CurrentDIV.Modify)
				{
					if(_DT_Return != null && _DT_Return.Rows.Count != 0) 
					{
						_Parent_Form.Modify_Grid(_DT_Return, _Parent_Form.fgrid_Yield.Selection.r1);
					} 
 
				}
				else
				{

					if(_DT_Return != null && _DT_Return.Rows.Count != 0) 
					{
						_Parent_Form.Apply_Grid(_DT_Return, _Parent_Form.fgrid_Yield.Selection.r1);
					} 
 

				}


				//---------------------------
				// 전역변수 초기화
				//---------------------------
				Clear_StaticVal();
				//---------------------------

				this.Hide();
  
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		
		/// <summary>
		/// Check_All_Setting_YieldValue : all setting yield value check
		/// </summary>
		/// <returns></returns>
		private bool Check_All_Setting_YieldValue()
		{ 
  

			for(int i = 0; i < _DT_Return.Rows.Count; i++)
			{
				for(int j = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START; j < _DT_Return.Columns.Count; j++)
				{
					_DT_Return.Rows[i].ItemArray[j] = (_DT_Return.Rows[i].ItemArray[j] == null) ? "" : _DT_Return.Rows[i].ItemArray[j].ToString();

					if(_DT_Return.Rows[i].ItemArray[j].ToString() == "") // || _DT_Return.Rows[i].ItemArray[j].ToString() == "0" )
					{
						ClassLib.ComFunction.User_Message("Input Yield Value", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						
						string template_level = _DT_Return.Rows[i].ItemArray[_IxTEMPLATE_LEVEL].ToString();
						int findrow = fgrid_BOMTemp.FindRow(template_level, fgrid_BOMTemp.Rows.Fixed, _IxTEMPLATE_LEVEL, false, true, false);
						
						if(findrow != -1)
						{
							fgrid_BOMTemp.Select(findrow, 0, findrow, fgrid_BOMTemp.Cols.Count - 1, false);
						}

						return false;
 
					} // end if


				} // end for j
			} // end for i 




			return true; 
		}
 



		/// <summary>
		/// Make_DT_YieldHead_Component : 
		/// </summary>
		private void Make_DT_YieldHead_Component()
		{
			
			DataRow datarow = null;


			datarow = _DT_Return.NewRow();
 


			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "0";

			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1] = _CmpLevel;

			// semi good cd + component cd
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1] = _SGCd + cmb_Component.SelectedValue.ToString(); 
			
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeCmp; 

			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE] = cmb_Component.Columns[1].Text;
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY] = _Factory;
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD] = _StyleCd;
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = _SGCd;
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD] = cmb_Component.SelectedValue.ToString();
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_NAME] = cmb_Component.Columns[1].Text;
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL] = "0";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_NAME] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN] = "N";   

			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV] = "";

			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO] = "";
			datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO] = "";

			
			for(int i = _IxHEAD_COL_END + 1; i < datarow.ItemArray.Length; i++) datarow[i] = ""; 


			_DT_Return.Rows.InsertAt(datarow, 0);



		}


		/// <summary>
		/// Make_DT_YieldHead : 
		/// </summary>
		private void Make_DT_YieldHead()
		{ 

			string current_templatelevel = ""; 
			string condition = "";
 
			DataRow[] findrow = null; 
			

			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{ 

				current_templatelevel = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
 

				condition = "DIVISION = '" + i.ToString() + "'";

				findrow = _DT_Return.Select(condition);


				for(int j = 0; j < findrow.Length; j++)
				{ 

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = i.ToString();

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1] = Convert.ToString(current_templatelevel.Length + _CmpLevel);

					// semi good cd + component cd + template seq + template level
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1] 
						= _SGCd + cmb_Component.SelectedValue.ToString() + current_templatelevel;

					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd)
					{
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeMat;
					}
					else
					{
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeJoint;
					}

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTREE] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY] = _Factory;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD] = _StyleCd;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = _SGCd;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD] = cmb_Component.SelectedValue.ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_NAME] = cmb_Component.Columns[1].Text;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = "";  
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD] = cmb_BOMTemp.SelectedValue.ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_NAME] = cmb_BOMTemp.Columns[1].Text;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1].ToString();
				
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
						? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
				
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN]  
						= (Convert.ToBoolean(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) ) ? "Y" : "N"; 


					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO] = "";
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID] = "";
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX] = "";
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV] = "";

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO] = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
						? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO] =  fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();




				} // end for j 

			} // end for i
 

		}

	

		// 임가공 선택 후 unit 이 같은 원자재에 일괄 채산값 할당해 주기 위한 설정값
		private bool _OutProcess_Inheritance = false;



		/// <summary>
		/// Make_DT_YieldTail : 
		/// </summary>
		private void Make_DT_YieldTail()
		{   


//			string condition = "DIVISION = '" + fgrid_BOMTemp.Selection.r1.ToString() + "'";
//
//			DataRow[] findrow = _DT_Return.Select(condition);  
//
//				
//			DataRow datarow_yieldvalue = findrow[0];
//			DataRow datarow_speccd = findrow[1];
//			DataRow datarow_specname = findrow[2];  
//			 
//
//			for(int j = _IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
//			{
//				datarow_yieldvalue[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_YieldValue, j] == null) ? "" : fgrid_YieldValue[_Row_YieldValue, j].ToString();
//				datarow_speccd[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_SpecCd, j] == null) ? "" : fgrid_YieldValue[_Row_SpecCd, j].ToString();
//				datarow_specname[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_SpecName, j] == null) ? "" : fgrid_YieldValue[_Row_SpecName, j].ToString();
//			}  
   



			Make_DT_YieldTail(fgrid_BOMTemp.Selection.r1); 


			//---------------------------------------------------------------------------------------------------------------------------------------
			// 선택 임가공이 Lamination, Stiker, Hot Melt, Rubber Lamination, ball hotmelt, dot hotmelt, no sew, fuse 이면, 하위 원자재 모두 채산값 변경
			// (unit 이 같은 원자재에만 적용)  
			//--------------------------------------------------------------------------------------------------------------------------------------- 
			if(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Lamination
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Stiker
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _HotMelt
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _RubberLamination
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _BallHotMelt
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _DotHotMelt
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _NoSew
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Fuse)
			{


				_OutProcess_Inheritance = true;

				Set_Make_DT_YieldTail(fgrid_BOMTemp.Selection.r1);
 

 
			} 



			//---------------------------------------------------------------------------------------------------------------------------------------





 
		}


 

		/// <summary>
		/// Set_Make_DT_YieldTail : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Set_Make_DT_YieldTail(int arg_row)
		{


			C1.Win.C1FlexGrid.Node node = fgrid_BOMTemp.Rows[arg_row].Node;

			int parent_level = node.Level;
			int start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
			string parent_unit = fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString().Trim();


			C1.Win.C1FlexGrid.Node node_child;

			for(int i = start_row; i <= end_row; i++)
			{

				node_child = fgrid_BOMTemp.Rows[i].Node;

				if(parent_level + 1 != node_child.Level) continue;
					
				if(parent_unit != fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString().Trim() ) continue;


				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _RawMatCd)
				{
					_OutProcess_Inheritance = true;
				}
					

				Make_DT_YieldTail(i);   


				if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Lamination
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Stiker
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _HotMelt
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _RubberLamination
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _BallHotMelt
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _DotHotMelt
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _NoSew
					|| fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString().Trim() == _Fuse)
				{

					_OutProcess_Inheritance = true;

					Set_Make_DT_YieldTail(i);
 


				} 

			} // end for i
 


		}





		/// <summary>
		/// Make_DT_YieldTail : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Make_DT_YieldTail(int arg_row)
		{


			string condition = "DIVISION = '" + arg_row.ToString() + "'";

			DataRow[] findrow = _DT_Return.Select(condition);  

			if(findrow.Length ==0) return;


			DataRow datarow_yieldvalue = findrow[0];
			DataRow datarow_speccd = findrow[1];
			DataRow datarow_specname = findrow[2];  
				

			for(int j = _IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
			{ 

				datarow_yieldvalue[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_YieldValue, j] == null) ? "" : fgrid_YieldValue[_Row_YieldValue, j].ToString();

				
				if(! _OutProcess_Inheritance)
				{
					datarow_speccd[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_SpecCd, j] == null) ? "" : fgrid_YieldValue[_Row_SpecCd, j].ToString();
					datarow_specname[j + _IxHEAD_COL_END] = (fgrid_YieldValue[_Row_SpecName, j] == null) ? "" : fgrid_YieldValue[_Row_SpecName, j].ToString();
				} // end if 임가공 하위 상속처리 일때, spec 은 기존 그대로 고정


			}  
 

			if(_OutProcess_Inheritance) _OutProcess_Inheritance = false;


		}




		/// <summary>
		/// Make_DT_YieldTail : modify 시 채산값 세팅
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Make_DT_YieldTail(DataTable arg_dt)
		{
			  

			DataRow datarow_yieldvalue = null;
			DataRow datarow_speccd = null;
			DataRow datarow_specname = null;  

			string templatelevel = ""; 

			string condition = "";
			DataRow[] findrow = null;


			
			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{
			 
				

				datarow_yieldvalue = _DT_Return.NewRow();
				datarow_speccd = _DT_Return.NewRow();
				datarow_specname = _DT_Return.NewRow();  
 

				datarow_yieldvalue["DIVISION"] = i.ToString();
				datarow_yieldvalue["TEMPLATE_LEVEL"] = fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString();
				datarow_yieldvalue["ITEM_CD"] = fgrid_BOMTemp[i, _IxITEM_CD].ToString();
				datarow_yieldvalue["SPEC_CD"] = fgrid_BOMTemp[i, _IxSPEC_CD].ToString();
				datarow_yieldvalue["COLOR_CD"] = fgrid_BOMTemp[i, _IxCOLOR_CD].ToString();

				datarow_speccd["DIVISION"] = i.ToString();
				datarow_speccd["TEMPLATE_LEVEL"] = fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString();
				datarow_speccd["ITEM_CD"] = fgrid_BOMTemp[i, _IxITEM_CD].ToString();
				datarow_speccd["SPEC_CD"] = fgrid_BOMTemp[i, _IxSPEC_CD].ToString();
				datarow_speccd["COLOR_CD"] = fgrid_BOMTemp[i, _IxCOLOR_CD].ToString();

				datarow_specname["DIVISION"] = i.ToString();
				datarow_specname["TEMPLATE_LEVEL"] = fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString();
				datarow_specname["ITEM_CD"] = fgrid_BOMTemp[i, _IxITEM_CD].ToString();
				datarow_specname["SPEC_CD"] = fgrid_BOMTemp[i, _IxSPEC_CD].ToString();
				datarow_specname["COLOR_CD"] = fgrid_BOMTemp[i, _IxCOLOR_CD].ToString();

				
				
				
				templatelevel = fgrid_BOMTemp[i, _IxTEMPLATE_LEVEL].ToString(); 
				condition = "TEMPLATE_LEVEL = '" + templatelevel + "'" ; 

				findrow = arg_dt.Select(condition);  


 
				for(int j = 0; j < findrow.Length; j++)
				{  
					datarow_yieldvalue[j + (_IxHEAD_COL_END + 2)] = findrow[j].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxYIELD_VALUE].ToString();
					datarow_speccd[j + (_IxHEAD_COL_END + 2)] = findrow[j].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxSPEC_CD].ToString();
					datarow_specname[j + (_IxHEAD_COL_END + 2)] = findrow[j].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxSPEC_NAME].ToString();
				}


				_DT_Return.Rows.Add(datarow_yieldvalue);
				_DT_Return.Rows.Add(datarow_speccd);
				_DT_Return.Rows.Add(datarow_specname);	



			} // end for i

		}
 


		/// <summary>
		/// Display_YieldValue : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_YieldValue(int arg_row)
		{
			  

			string condition = "DIVISION = '" + arg_row.ToString() + "'";

			DataRow[] findrow = _DT_Return.Select(condition);
 

			if(findrow.Length == 0) 
			{
				// 채산 행 초기화
				fgrid_YieldValue.GetCellRange(_Row_YieldValue, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START,
					_Row_SpecName, fgrid_YieldValue.Cols.Count - 1).Clear(ClearFlags.Content);
			
				return;
			}

			DataRow datarow_yieldvalue = findrow[0];
			DataRow datarow_speccd = findrow[1];
			DataRow datarow_specname = findrow[2];  
			 

			// 채산 행 초기화
			fgrid_YieldValue.GetCellRange(_Row_YieldValue, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START,
				_Row_SpecName, fgrid_YieldValue.Cols.Count - 1).Clear(ClearFlags.Content);
				
 

			 
			 
			//already input -> display
			Disaply_Already_YieldValue(arg_row, findrow); 
 


			// bom template 구조에 대한 size group 세팅
			Display_Spec_SizeGroup(arg_row);


				
		}



		/// <summary>
		/// Disaply_Already_YieldValue : 
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_cs_size"></param>
		public void Disaply_Already_YieldValue(int arg_row, DataRow[] arg_findrow)
		{

			int set_count = 0;

			for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{
				fgrid_YieldValue[_Row_YieldValue, i] = arg_findrow[0][i + _IxHEAD_COL_END].ToString();
 
				if(! fgrid_YieldValue[_Row_YieldValue, i].ToString().Trim().Equals("") ) set_count++;
				
//				// 사이즈 자재이면 spec row 초기화
//				if( Convert.ToBoolean(fgrid_BOMTemp[arg_row, _IxSIZE_YN].ToString() ) )
//				{ 
//					 
//					fgrid_YieldValue[_Row_SpecCd, i] = arg_findrow[1][i + _IxHEAD_COL_END].ToString();
//					fgrid_YieldValue[_Row_SpecName, i] = arg_findrow[2][i + _IxHEAD_COL_END].ToString();  
//
//				}	
//				else
//				{
//					fgrid_YieldValue[_Row_SpecCd, i] = (fgrid_BOMTemp[arg_row, _IxSPEC_CD] == null) ? "" : fgrid_BOMTemp[arg_row, _IxSPEC_CD].ToString();
//					fgrid_YieldValue[_Row_SpecName, i] = (fgrid_BOMTemp[arg_row, _IxSPEC_NAME] == null) ? "" : fgrid_BOMTemp[arg_row, _IxSPEC_NAME].ToString(); 
//				} 


				if(arg_findrow[1][i + _IxHEAD_COL_END].ToString() == "")
				{

					fgrid_YieldValue[_Row_SpecCd, i] = (fgrid_BOMTemp[arg_row, _IxSPEC_CD] == null) ? "" : fgrid_BOMTemp[arg_row, _IxSPEC_CD].ToString();
					fgrid_YieldValue[_Row_SpecName, i] = (fgrid_BOMTemp[arg_row, _IxSPEC_NAME] == null) ? "" : fgrid_BOMTemp[arg_row, _IxSPEC_NAME].ToString();

				}
				else
				{

					fgrid_YieldValue[_Row_SpecCd, i] = arg_findrow[1][i + _IxHEAD_COL_END].ToString();
					fgrid_YieldValue[_Row_SpecName, i] = arg_findrow[2][i + _IxHEAD_COL_END].ToString();  

				}
				



			} // end for i  



			// 채산 all setting 된 경우 이후 사이즈 그룹 세팅 하지 않기 위함
			if(set_count == (fgrid_YieldValue.Cols.Count - _IxCS_SIZE_START) )
			{
				fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "Y";
			}
			else
			{
				fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "N";
			}


			 
			//-----------------------------------------------------------------------------------------------------------------------
			// SRF으로부터 채산값 입력할 때, all setting 되지 않은 경우 default 채산값으로 설정 
			//-----------------------------------------------------------------------------------------------------------------------
			if(cmb_SRFNo.SelectedIndex != -1 
				&& cmb_BOMID.SelectedIndex != -1 
				&& cmb_Part.SelectedIndex != -1 
				&& fgrid_SRF.Rows.Count > fgrid_SRF.Rows.Fixed)
			{

				if(fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ].ToString() != "Y")
				{

					string item_cd = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString(); 
					int findrow = fgrid_SRF.FindRow(item_cd , fgrid_SRF.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD, false, true, false);
				 
					if(findrow != -1)
					{
						string yield_value = fgrid_SRF[findrow, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxYIELD_VALUE].ToString();

						for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
						{
							fgrid_YieldValue[_Row_YieldValue, i] = yield_value; 
						}

						fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "Y";
					
						//채산값 할당
						Make_DT_YieldTail(); 

					} // end if(findrow != -1)

				} // end if

			} // end if (SRF 데이터 있을 경우)
			//-----------------------------------------------------------------------------------------------------------------------



			//-----------------------------------------------------------------------------------------------------------------------
			// Excel로부터 채산값 입력할 때, all setting 되지 않은 경우 default 채산값으로 설정 
			//-----------------------------------------------------------------------------------------------------------------------
			if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
			{

				if(fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ].ToString() != "Y")
				{

					int findrow = -1;
					findrow = _Parent_Form.fgrid_Upload.Selection.r1; 

					if(findrow != -1)
					{

						string yield_value = "";

						if(_UseComparison) // 공통 채산값으로 전 사이즈 채산값 할당
						{

							yield_value = _Parent_Form.fgrid_Upload[findrow, (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCOMMON_YIELD_VALUE].ToString().Trim();

							for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
							{
								fgrid_YieldValue[_Row_YieldValue, i] = yield_value; 
							}


						}
						else // 사이즈별 채산값 할당
						{

							Set_SizeYieldValue_FromExcel(_Parent_Form.fgrid_Upload, findrow);
						}


						

						

						fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "Y";
					
						//채산값 할당
						Make_DT_YieldTail(arg_row); 

					} // end if(findrow != -1)

				} // end if

			} // end if (SRF 데이터 있을 경우)
			//-----------------------------------------------------------------------------------------------------------------------



			//-----------------------------------------------------------------------------------------------------------------------
			// 임가공 공정일 경우, 채산값이 all setting 되지 않은 경우 아래 레벨 채산값 설정
			// (unit 이 같은 아래 레벨 채산값으로 설정됨)
			//-----------------------------------------------------------------------------------------------------------------------
			if(fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() != _RawMatCd)
			{

				if(fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ].ToString() != "Y")
				{
				
					string unit = (fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT] == null)
						? "" : fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString();
	 

						 
					C1.Win.C1FlexGrid.Node node = fgrid_BOMTemp.Rows[arg_row].Node;
					
					int start_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
					int end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					int copy_row = -1;

					for(int i = start_row; i <= end_row; i++)
					{

						if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString() != unit) continue;

						copy_row = i;
						break; 
							
					} // end for i


					if(copy_row != -1)
					{
						string condition = "DIVISION = '" + copy_row.ToString() + "'"; 
						DataRow[] findrow = _DT_Return.Select(condition);  

						string condition_1 = "DIVISION = '" + arg_row.ToString() + "'"; 
						DataRow[] findrow_1 = _DT_Return.Select(condition_1);  



						if(findrow.Length > 0)  
						{
							for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
							{
								fgrid_YieldValue[_Row_YieldValue, i] = findrow[0][i + _IxHEAD_COL_END].ToString(); 
								fgrid_YieldValue[_Row_SpecCd, i] = findrow_1[1][i + _IxHEAD_COL_END].ToString(); 
								fgrid_YieldValue[_Row_SpecName, i] = findrow_1[2][i + _IxHEAD_COL_END].ToString(); 

							} // end for i   
						} 


//					
//						//채산값 할당
//						Make_DT_YieldTail();  
//
//						fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "Y";



					} // end if(copy_row != -1)

					 

					//채산값 할당
					fgrid_BOMTemp.Select(arg_row, _IxCS_SIZE_START, true);
					Make_DT_YieldTail();  

					fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "Y";


				} // if(! unit.Equals("") )
				 
			}  // end if (임가공 공정일 경우) 
			//-----------------------------------------------------------------------------------------------------------------------



			//SPEC CODE 별 색깔 표시 
			Disaply_Yield_Color();



		}




		/// <summary>
		/// Set_SizeYieldValue_FromExcel : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <param name="arg_selrow"></param>
		private void Set_SizeYieldValue_FromExcel(COM.FSP arg_grid, int arg_selrow)
		{

			string cs_size = "";
			string now_cs_size = ""; 
			int input_col = 0;  
 

			//arg_grid : 업로드 그리드

			// 1. 채산 수정할 행 초기화 처리 
			for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{  	
				fgrid_YieldValue[_Row_YieldValue, i] = "-1"; 

			} // end for i


			 
			// 2. 사이즈 별 채산값 세팅 
			for(int i = (int)ClassLib.TBSBC_YIELD_EXCEL_UPLOAD.IxCS_SIZE_START; i < arg_grid.Cols.Count; i++)
			{

				cs_size = arg_grid[1, i].ToString().Trim();


				for(int j = _IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
				{
					now_cs_size = fgrid_YieldValue[1, j].ToString().Trim();

					if(cs_size == now_cs_size)
					{
						input_col = j;
						break;
					}


				}  // end for j
  


				fgrid_YieldValue[_Row_YieldValue, input_col] = arg_grid[arg_selrow, i].ToString().Trim();
  


			} // end for i

   

			// 3. 중간 미할당된 사이즈 채산값 세팅 (바로 전 사이즈 채산값으로 할당) 
			int copy_col = 0;
					

			for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{ 

				if(fgrid_YieldValue[_Row_YieldValue, i].ToString().Equals("-1") )
				{

							
					// 사이즈 첫 문대부터 채산서에 값이 없는 경우
					if(i == _IxCS_SIZE_START)  
					{

						for(int a = i; a < fgrid_YieldValue.Cols.Count; a++)
						{
							if(fgrid_YieldValue[_Row_YieldValue, a].ToString().Equals("-1") ) continue;

							copy_col = a;
							break;
									
						} // end for a


						for(int a = i; a < copy_col; a++)
						{
							fgrid_YieldValue[_Row_YieldValue, a] = fgrid_YieldValue[_Row_YieldValue, copy_col].ToString();
						}


					} // end if 첫 문대 
					else
					{
						fgrid_YieldValue[_Row_YieldValue, i] = fgrid_YieldValue[_Row_YieldValue, i - 1].ToString();

					} // end if
							

				} // end if (-1)

						
	 

			} // end for i





		}



		/// <summary>
		/// Disaply_Yield_Color : SPEC CODE 별 색깔 표시 
		/// </summary> 
		private void Disaply_Yield_Color()
		{
			int size_f = -1, size_t = -1;
			string before_spec = "", now_spec = "";
			_CurrentColor = _SizeColor2;

			size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

			while(true)
			{
				before_spec = fgrid_YieldValue[_Row_SpecCd, size_f].ToString(); 

				for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
				{   
					now_spec = fgrid_YieldValue[_Row_SpecCd, k].ToString(); 

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
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}


				for(int i = size_f; i <= size_t; i++)
				{
					fgrid_YieldValue.GetCellRange(fgrid_YieldValue.Rows.Fixed, i, fgrid_YieldValue.Rows.Count - 1, i).StyleNew.BackColor = _CurrentColor;
				}
 


				size_f = size_t + 1;

				if(size_f == fgrid_YieldValue.Cols.Count) break;

			} // end while
		}




		private string _Default_SizeGroup = "0-22";


		/// <summary>
		/// Display_Spec_SizeGroup : bom template 구조에 대한 size group 세팅
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Spec_SizeGroup(int arg_row)
		{

			
			bool size_yn = Convert.ToBoolean(fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ); 
			if(!size_yn) return;


			string all_division = (fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] == null) 
				? "N" : fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ].ToString();

			if(all_division == "Y") return;


			DataTable dt_ret;


			string template_tree_cd = cmb_BOMTemp.SelectedValue.ToString();
			string template_level = fgrid_BOMTemp[arg_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();

			dt_ret = Select_BOM_TEMPLATE_TAIL(template_tree_cd, template_level);


			string cs_size_from = "";
			string cs_size_to = "";
			string now_size = "";
 


			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				if(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SIZE_GROUP.IxSPEC_NAME].ToString() == _Default_SizeGroup) continue;


				cs_size_from = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SIZE_GROUP.IxCS_SIZE_FROM].ToString().Replace("T", ".5");
				cs_size_to = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SIZE_GROUP.IxCS_SIZE_TO].ToString().Replace("T", ".5");


				for(int j = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
				{
					now_size = fgrid_YieldValue[1, j].ToString().Replace("T", ".5");

					if(Convert.ToDouble(now_size) >= Convert.ToDouble(cs_size_from)
						&& Convert.ToDouble(now_size) <= Convert.ToDouble(cs_size_to) )
					{
						fgrid_YieldValue[_Row_SpecCd, j] = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SIZE_GROUP.IxSPEC_CD].ToString();
						fgrid_YieldValue[_Row_SpecName, j] = dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SIZE_GROUP.IxSPEC_NAME].ToString();

					} // end if

				} // end for j


			} // end for i




			dt_ret.Dispose();
 


			//SPEC CODE 별 색깔 표시 
			Disaply_Yield_Color();


		}





		/// <summary>
		/// Select_BOM_TEMPLATE_TAIL : 사이즈 그룹 조회
		/// </summary>
		/// <param name="arg_template_treecd"></param>
		/// <param name="arg_template_level"></param>
		/// <returns></returns>
		private DataTable Select_BOM_TEMPLATE_TAIL(string arg_template_treecd, string arg_template_level)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_BOM_TEMPLATE_TAIL";
  
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE_LEVEL"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;   
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_template_treecd, " ");  
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_template_level, " ");  
			MyOraDB.Parameter_Values[2] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}




		#endregion
 
		#endregion

		#region Context Menu 관련 메서드


		Pop_Item_List pop_form = null;


		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{
				int sel_row = fgrid_BOMTemp.Selection.r1;
				int sel_col = fgrid_BOMTemp.Selection.c1;

				if(sel_row < fgrid_BOMTemp.Rows.Fixed) return;

				string item_cd = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();

				string item_name = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1].ToString();
				
				string spec_cd = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
				
				string spec_name = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
				
				string color_cd = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();
				
				string color_name = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] == null) 
					? "" :  fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME].ToString();
				
				string unit = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT] == null) 
					? "" : fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString();
				
				string size_yn = (fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] == null 
					|| Convert.ToBoolean(fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) == false)
					? "N" : "Y";
				
				bool default_view = false;

				if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel || _SRF_YN )
				{
					default_view = true;
				} 


				//ClassLib.ComVar.Parameter_PopUp = null; 

				//----------------------------------------------------------------------------------------------------------------------------
				// 선택 항목 바로 설정할 수 있도록 팝업 창 페이지 초기 설정
				//----------------------------------------------------------------------------------------------------------------------------
				string select = "";
				
				if(sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD || sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1)
				{
					select = "Item";
				}
				else if(sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD || sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME)
				{
					select = "Spec";
				}
				else if(sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD || sel_col == (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME)
				{
					select = "Color";
				} 

				COM.ComVar.Parameter_PopUp = new string[] { select };
				//----------------------------------------------------------------------------------------------------------------------------

				
//				FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn, default_view);
//				pop_form.ShowDialog();
//
//				pop_form.Dispose(); 
//
//

				if(pop_form == null)
				{

					pop_form = new Pop_Item_List(this, item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn, default_view);  
				 
				}
				else
				{
 

					pop_form._Parent_Form = this;

					pop_form._ItemCd = item_cd;
					pop_form._ItemName = item_name;
					pop_form._SpecCd = spec_cd;
					pop_form._SpecName = spec_name; 
					pop_form._ColorCd = color_cd;
					pop_form._ColorName = color_name;
					pop_form._Unit = unit;
					pop_form._SizeYN = size_yn; 
					pop_form._DefaultView = default_view; 

					pop_form.Init_Form();
 
 

				}
			
				if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel || _SRF_YN )
				{
					pop_form.obar_Main.SelectedPage = pop_form.obarpg_Item;
				}


				pop_form.Show();



//				bool exist_yn = Check_Duplicate_ItemSpecColor(sel_row, 
//					ClassLib.ComVar.Parameter_PopUp[0],  // item_cd
//					ClassLib.ComVar.Parameter_PopUp[2],  // spec_cd
//					ClassLib.ComVar.Parameter_PopUp[4] );// color_cd
//
//
//				if(_OnlyRawMat && exist_yn)
//				{
//					ClassLib.ComFunction.User_Message("Duplicate Item", "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//					return;
//				}
//				else
//				{
//
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = ClassLib.ComVar.Parameter_PopUp[0];
//					
//					if(fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd)
//					{
//						fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = ClassLib.ComVar.Parameter_PopUp[1]; // nick name
//					}
//
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = ClassLib.ComVar.Parameter_PopUp[1];  // item name
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] = ClassLib.ComVar.Parameter_PopUp[2];
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME] = ClassLib.ComVar.Parameter_PopUp[3];
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = ClassLib.ComVar.Parameter_PopUp[4];   
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = ClassLib.ComVar.Parameter_PopUp[5];  
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT] = ClassLib.ComVar.Parameter_PopUp[6];
//					fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7] );
//
//					// 채산값 리턴 테이블 행 생성
//					// modify 일때는 채산값 그대로 처리 
//					string dt_template_level = fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
//					string dt_item = fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
//					string dt_spec = fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
//					string dt_color = fgrid_BOMTemp[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();
//  
// 
//					_DT_Return_Key old_return_key, new_return_key;
// 
//					old_return_key._RowID = sel_row.ToString();
//					old_return_key._Templatekey = dt_template_level;
//					old_return_key._ItemCd = item_cd;
//					old_return_key._SpecCd = spec_cd;
//					old_return_key._ColorCd = color_cd;
//				
//
//					new_return_key._RowID = sel_row.ToString();
//					new_return_key._Templatekey = dt_template_level;
//					new_return_key._ItemCd = dt_item;
//					new_return_key._SpecCd = dt_spec;
//					new_return_key._ColorCd = dt_color; 
//
//					Add_Row_DT_YieldValue(old_return_key, new_return_key);  
//
//
//
//
//					string condition = "DIVISION = '" + sel_row.ToString() + "'";
//					DataRow[] findrow = _DT_Return.Select(condition);
//
//					Disaply_Already_YieldValue(sel_row, findrow);
//
//				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// Add_Row_DT_YieldValue : Add row yield value return data table
		/// </summary>
		/// <param name="arg_old_key"></param>
		/// <param name="arg_new_key"></param>
		public void Add_Row_DT_YieldValue(_DT_Return_Key arg_old_key, _DT_Return_Key arg_new_key)
		{
			DataRow datarow_yieldvalue = null;
			DataRow datarow_speccd = null;
			DataRow datarow_specname = null; 
  

			string condition = "DIVISION = '" + arg_old_key._RowID + "'"; 
			DataRow[] findrow = _DT_Return.Select(condition); 
			 


			if(findrow.Length == 0) 
			{
				datarow_yieldvalue = _DT_Return.NewRow();
				datarow_speccd = _DT_Return.NewRow();
				datarow_specname = _DT_Return.NewRow();



				datarow_yieldvalue["DIVISION"]       = arg_old_key._RowID; 
				datarow_yieldvalue["TEMPLATE_LEVEL"] = arg_new_key._Templatekey; 
				datarow_yieldvalue["ITEM_CD"]        = arg_new_key._ItemCd; 
				datarow_yieldvalue["SPEC_CD"]		 = arg_new_key._SpecCd; 
				datarow_yieldvalue["COLOR_CD"]		 = arg_new_key._ColorCd; 

				datarow_speccd["DIVISION"]       = arg_old_key._RowID; 
				datarow_speccd["TEMPLATE_LEVEL"] = arg_new_key._Templatekey; 
				datarow_speccd["ITEM_CD"]        = arg_new_key._ItemCd; 
				datarow_speccd["SPEC_CD"]		 = arg_new_key._SpecCd; 
				datarow_speccd["COLOR_CD"]		 = arg_new_key._ColorCd; 

				datarow_specname["DIVISION"]       = arg_old_key._RowID; 
				datarow_specname["TEMPLATE_LEVEL"] = arg_new_key._Templatekey; 
				datarow_specname["ITEM_CD"]        = arg_new_key._ItemCd; 
				datarow_specname["SPEC_CD"]		   = arg_new_key._SpecCd; 
				datarow_specname["COLOR_CD"]	   = arg_new_key._ColorCd; 
 
				
				int new_level_length = arg_new_key._Templatekey.Length;
				DataRow dr;
				int newrow = -1;


				if(cmb_BOMTemp.SelectedValue.ToString().Trim() == _OnlyRawMat_TemplateCd)
				{
					newrow = -1;
				}
				else
				{ 

					for(int i = 0; i < _DT_Return.Rows.Count; i++)
					{
						dr = _DT_Return.Rows[i];

                        if (dr["TEMPLATE_LEVEL"].ToString().Length < new_level_length)
                        {
                            continue;
                        }
                            // 같은 레벨일 때, 작업순서에 따라 행이 만들어지는데, division 구분에 따라 Sort 해서 처리
                        else if (dr["TEMPLATE_LEVEL"].ToString().Length == new_level_length)
                        {
                            if (Convert.ToInt32(dr["DIVISION"].ToString()) > Convert.ToInt32(arg_new_key._RowID))
                            {
                                newrow = i;
                                break;
                            }
                        }
                        else
                        {

                            //if (dr["TEMPLATE_LEVEL"].ToString().Substring(0, new_level_length) == arg_new_key._Templatekey)
                            //{
                            //    newrow = i;
                            //    break;
                            //}

                            if (Convert.ToInt32(dr["TEMPLATE_LEVEL"].ToString().Substring(0, new_level_length)) > Convert.ToInt32(arg_new_key._Templatekey))
                            {
                                newrow = i;
                                break;
                            }
                            else if (dr["TEMPLATE_LEVEL"].ToString().Substring(0, new_level_length) == arg_new_key._Templatekey)
                            {
                                if (Convert.ToInt32(dr["DIVISION"].ToString()) > Convert.ToInt32(arg_new_key._RowID))
                                {
                                    newrow = i;
                                    break;
                                }
                            }



                        } // end if template_level length


					} // end for i

				} // end if(cmb_BOMTemp.SelectedValue.ToString().Trim() == _OnlyRawMat_TemplateCd)

				
				if(newrow == -1)
				{

					_DT_Return.Rows.Add(datarow_yieldvalue);
					_DT_Return.Rows.Add(datarow_speccd);
					_DT_Return.Rows.Add(datarow_specname);	

				}
				else
				{
					_DT_Return.Rows.InsertAt(datarow_yieldvalue, newrow);
					_DT_Return.Rows.InsertAt(datarow_speccd, newrow + 1);
					_DT_Return.Rows.InsertAt(datarow_specname, newrow + 2);
				}





				// spec 할당 
				string condition_new = "DIVISION = '" + arg_old_key._RowID + "'"; 
				DataRow[] findrow_new = _DT_Return.Select(condition_new); 
			 
				for(int j = _IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
				{
					findrow_new[1][j + _IxHEAD_COL_END] = fgrid_BOMTemp[Convert.ToInt32(arg_old_key._RowID), (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
					findrow_new[2][j + _IxHEAD_COL_END] = fgrid_BOMTemp[Convert.ToInt32(arg_old_key._RowID), (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
					
				} // end for i





			}
			else
			{   
				findrow[0]["TEMPLATE_LEVEL"] = arg_new_key._Templatekey;
				findrow[0]["ITEM_CD"]        = arg_new_key._ItemCd; 
				findrow[0]["SPEC_CD"]        = arg_new_key._SpecCd; 
				findrow[0]["COLOR_CD"]       = arg_new_key._ColorCd; 

				findrow[1]["TEMPLATE_LEVEL"] = arg_new_key._Templatekey;
				findrow[1]["ITEM_CD"]        = arg_new_key._ItemCd; 
				findrow[1]["SPEC_CD"]        = arg_new_key._SpecCd; 
				findrow[1]["COLOR_CD"]       = arg_new_key._ColorCd; 

				findrow[2]["TEMPLATE_LEVEL"] = arg_new_key._Templatekey;
				findrow[2]["ITEM_CD"]        = arg_new_key._ItemCd; 
				findrow[2]["SPEC_CD"]        = arg_new_key._SpecCd; 
				findrow[2]["COLOR_CD"]       = arg_new_key._ColorCd; 

 

				// 기존 데이터 있고, 사이즈 자재 아닌 경우 spec 수정 사항 재 반영
				if(! Convert.ToBoolean( fgrid_BOMTemp[Convert.ToInt32(arg_old_key._RowID), (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString()) )
				{
					for(int j = _IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
					{
						findrow[1][j + _IxHEAD_COL_END] = fgrid_BOMTemp[Convert.ToInt32(arg_old_key._RowID), (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
						findrow[2][j + _IxHEAD_COL_END] = fgrid_BOMTemp[Convert.ToInt32(arg_old_key._RowID), (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
					
					} // end for i

				} // end if (size_yn = "N")





			} // end if(findrow.Length == 0) 
 
			
 
		}



		/// <summary>
		/// Delete_AddRawMat : 추가했던 Raw Material 취소 처리
		/// </summary>
		private void Delete_AddRawMat()
		{
			try
			{
				int sel_r1 = fgrid_BOMTemp.Selection.r1;
				int sel_r2 = fgrid_BOMTemp.Selection.r2;
			
				int start_row, end_row; 

				string condition = "";
				DataRow[] findrow = null;
 
				 
				start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
				end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

				for(int i = end_row; i >= start_row; i--)
				{
					if(i == fgrid_BOMTemp.Rows.Fixed)
					{
						continue;
					}



					//---------------------------------------------------------------------------------------------------------
					//return datatable delete
 
					condition = "DIVISION = '" + i.ToString() + "'" ; 
					findrow = _DT_Return.Select(condition);  


					if(findrow.Length != 0)  
					{   
						findrow[0].Delete(); 
						findrow[1].Delete();
						findrow[2].Delete(); 
					}  
					//---------------------------------------------------------------------------------------------------------



					if (fgrid_BOMTemp[i, 0].ToString() == "I")
					{
						fgrid_BOMTemp.Rows.Remove(i);
					}
					else
					{
						fgrid_BOMTemp.Delete_Row(i);
					}
 


				} 
 
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Delete_AddRawMat", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion




		#endregion 
		
		#region SRF

		#region tab control

		private bool _SRF_ON_Flag = false;

		private void tab_Main_Click(object sender, System.EventArgs e)
		{
			try
			{
				_SRF_ON_Flag = !_SRF_ON_Flag;

				if(_SRF_ON_Flag)
				{
					pnl_BL.Size = new Size(297, 343);
				}
				else
				{
					pnl_BL.Size = new Size(25, 343);
				}

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tab_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion

		#region combo setting


		private void txt_SRF_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				this.Cursor = Cursors.WaitCursor;


				Set_SRFNo_Combo();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_SRF_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		/// <summary>
		/// Set_SRFNo_Combo : 
		/// </summary>
		private void Set_SRFNo_Combo()
		{

			//srf no combo list 
			DataTable dt_ret = Select_SDD_SRF_HEAD_SRFNO(ClassLib.ComVar.DSFactory, txt_SRF.Text);

			//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SRFNo, 0, 0, false, 0, 210); 

			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_SRFNo, 0, 0);
			cmb_SRFNo.Splits[0].DisplayColumns[0].Width = 0;
			cmb_SRFNo.Splits[0].DisplayColumns[1].Width = 210;
			cmb_SRFNo.DropDownWidth = 210;

			dt_ret.Dispose();


			if(! _Parent_Form._SRFNo.Trim().Equals("") )
			{
				cmb_SRFNo.SelectedValue = _Parent_Form._SRFNo;
			}

		}



		private void cmb_SRFNo_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				if(cmb_SRFNo.SelectedIndex == -1) return;

				cmb_BOMID.SelectedIndex = -1;
				cmb_Part.SelectedIndex = -1;
				fgrid_SRF.Rows.Count = fgrid_SRF.Rows.Fixed;

				DataTable dt_ret;

				string factory = ClassLib.ComVar.DSFactory;
				string srfno = cmb_SRFNo.SelectedValue.ToString();
 
				dt_ret = Select_SDD_SRF_HEAD_BOMID(factory, srfno);
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOMID, 0, 0, false, 0, 210);

				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_BOMID, 0, 0);
				cmb_BOMID.Splits[0].DisplayColumns[0].Width = 0;
				cmb_BOMID.Splits[0].DisplayColumns[1].Width = 210;
				cmb_BOMID.DropDownWidth = 210; 

				dt_ret.Dispose();


				if(! _Parent_Form._BOMID.Trim().Equals("") )
				{
					cmb_BOMID.SelectedValue = _Parent_Form._BOMID;
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SRFNo_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			 
			
		}

		private void cmb_BOMID_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_SRFNo.SelectedIndex == -1 || cmb_BOMID.SelectedIndex == -1) return;

				cmb_Part.SelectedIndex = -1;
				fgrid_SRF.Rows.Count = fgrid_SRF.Rows.Fixed;

				DataTable dt_ret;

				string factory = ClassLib.ComVar.DSFactory;
				string srfno = cmb_SRFNo.SelectedValue.ToString();
				string bomid = cmb_BOMID.SelectedValue.ToString();

				dt_ret = Select_SDD_SRF_TAIL_PART(factory, srfno, bomid);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Part, 0, 1, true, 0, 210); 

				dt_ret.Dispose();


				if(! _Parent_Form._SRFNo.Trim().Equals("") && ! _Parent_Form._BOMID.Trim().Equals("") )
				{
					cmb_Part.SelectedIndex = 0;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_BOMID_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_Part_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_SRFNo.SelectedIndex == -1 || cmb_BOMID.SelectedIndex == -1 || cmb_Part.SelectedIndex == -1) return;

				this.Cursor = Cursors.WaitCursor;



				fgrid_SRF.Rows.Count = fgrid_SRF.Rows.Fixed;

				DataTable dt_ret;

				string factory = _Factory;
				string srf_factory = ClassLib.ComVar.DSFactory;
				string srfno = cmb_SRFNo.SelectedValue.ToString();
				string bomid = cmb_BOMID.SelectedValue.ToString();
				string partno = ClassLib.ComFunction.Empty_Combo(cmb_Part, " ");

				dt_ret = Select_SDD_SRF_TAIL_MATCD(factory, srf_factory, srfno, bomid, partno); 

				Display_Tree(dt_ret); 

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Part_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}






		/// <summary>
		/// Display_Tree : SRF 트리 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Tree(DataTable arg_dt)
		{
			int rowfixed = fgrid_SRF.Rows.Fixed;

			fgrid_SRF.Rows.Count = rowfixed;
			fgrid_SRF.Tree.Column = (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC;



			int level = 0;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBSRF_LEVEL].ToString());

				fgrid_SRF.Rows.InsertNode(i + rowfixed, level);


				//---------------------------------------------------------------------------------------------------
				fgrid_SRF[i + rowfixed, 0] = "";


				if(level == _LevelPart)
				{ 
					fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBPART_DESC].ToString(); 

				}
				else if(level == _LevelMatCd)
				{
					fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBITEM_NAME1].ToString();

				}

				
				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBSRF_LEVEL].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_NO]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBPART_NO].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBPART_DESC].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBITEM_CD].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_NAME1]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBITEM_NAME1].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxLAMINATION_YN]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBLAMINATION_YN].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBCOLOR_CD].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBCOLOR_DESC].ToString(); 

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBCOMPONENT_CD].ToString(); 


				if(level == _LevelPart)
				{ 
					fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxYIELD_VALUE] = "";

				}
				else if(level == _LevelMatCd)
				{
					fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxYIELD_VALUE]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBYIELD_VALUE].ToString();

				}

				

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxLOAD_UPD_USER]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBLOAD_UPD_USER].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_SEQ_MAX]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBSRF_SEQ_MAX].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxGROUP_DIVIDE_YN]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBGROUP_DIVIDE_YN].ToString();

				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxEXIST_YN]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBEXIST_YN].ToString();


				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSIZE_YN]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBSIZE_YN].ToString();


				fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxMNG_UNIT]
					= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTBMNG_UNIT].ToString();



				//---------------------------------------------------------------------------------------------------




				//---------------------------------------------------------------------------------------------------
				// Warning, Size YN 표시 
				if(level == _LevelPart)  // sbc_component 에 없을 경우
				{ 

					fgrid_SRF.Rows[i + rowfixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;


					if(fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString().Trim() == "")
					{
						fgrid_SRF.GetCellRange(i + rowfixed, 1, i + rowfixed, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}  
 
				}
				else
				{
					if(fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSIZE_YN].ToString().Trim() == "Y")
					{
						fgrid_SRF.GetCellRange(i + rowfixed, 1, i + rowfixed, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
					}  
 

				}


				// item group warning cancel
//				else if(level == _LevelMatCd)  // sbc_item group_cd = '07000xxx' 인 경우
//				{ 
//					if(fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxGROUP_DIVIDE_YN].ToString().Trim() != "Y")
//					{
//						fgrid_SRF.GetCellRange(i + rowfixed, 1, i + rowfixed, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
//					}  
//
//				}
				//---------------------------------------------------------------------------------------------------

			
				fgrid_SRF.SetCellCheck(i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Unchecked);


			
 
				//---------------------------------------------------------------------------------------------------
//				if(fgrid_SRF[i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxEXIST_YN].ToString() == "Y")
//				{
//					fgrid_SRF.SetCellCheck(i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Checked);
//
//					// 상위 component도 표시
//					C1.Win.C1FlexGrid.Node parent_node = fgrid_SRF.Rows[i + rowfixed].Node.GetNode(NodeTypeEnum.Parent);
//					fgrid_SRF.SetCellCheck(parent_node.Row.Index, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Checked);
//
//
//
//					fgrid_SRF.GetCellRange(i + rowfixed, 1, i + rowfixed, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrReadOnly;
//					fgrid_SRF.Rows[i + rowfixed].AllowEditing = false;
//
//					C1.Win.C1FlexGrid.Node node = fgrid_SRF.Rows[i + rowfixed].Node; 
//					int parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index; 
//					fgrid_SRF.GetCellRange(parent_row, 1, parent_row, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrReadOnly;
//					fgrid_SRF.Rows[parent_row].AllowEditing = false;
//
//
//
//				}
//				else
//				{ 
//					fgrid_SRF.SetCellCheck(i + rowfixed, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Unchecked);
//				}
 
 
				//---------------------------------------------------------------------------------------------------
 

			} // end for i






			//---------------------------------------------------------------------------------------------------
			// exist component/item/color
			//---------------------------------------------------------------------------------------------------
			COM.FSP main_grid =  _Parent_Form.fgrid_Yield;
			string srf_no = "";
			string component_cd = "", item_cd = "", color_name = "";

			for(int i = main_grid.Rows.Fixed; i < main_grid.Rows.Count; i++)
			{
				
				srf_no = (main_grid[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO] == null) 
							? "" : main_grid[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO].ToString().Trim();
	
				if(srf_no.Equals("") ) continue;


				component_cd = main_grid[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString().Trim();
				item_cd = main_grid[i, (int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD].ToString().Trim();
				color_name = main_grid[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME].ToString().Trim();



				for(int j = fgrid_SRF.Rows.Fixed; j < fgrid_SRF.Rows.Count; j++)
				{


					if(Convert.ToInt32(fgrid_SRF[j, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ) == _LevelPart) continue;

					if(component_cd == fgrid_SRF[j, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString().Trim()
						&& item_cd == fgrid_SRF[j, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD].ToString().Trim()
						&& color_name == fgrid_SRF[j, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString().Trim() )
					{



						fgrid_SRF.SetCellCheck(j, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Checked);

						// 상위 component도 표시
						C1.Win.C1FlexGrid.Node parent_node = fgrid_SRF.Rows[j].Node.GetNode(NodeTypeEnum.Parent);
						fgrid_SRF.SetCellCheck(parent_node.Row.Index, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Checked);



						fgrid_SRF.GetCellRange(j, 1, j, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = Color.LightGray;
						fgrid_SRF.Rows[j].AllowEditing = false;

						C1.Win.C1FlexGrid.Node node = fgrid_SRF.Rows[j].Node; 

						int parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index; 
						fgrid_SRF.GetCellRange(parent_row, 1, parent_row, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = Color.LightGray;
						fgrid_SRF.Rows[parent_row].AllowEditing = false;


						break;


					} // end if


				} // end for j


				
			} // end for i
			//---------------------------------------------------------------------------------------------------



			rad_Comp.Checked = true; 
			fgrid_SRF.Tree.Show(_LevelPart);

  
		}




		



		private void btn_FindComp_Click(object sender, System.EventArgs e)
		{

			try
			{ 
				FlexBase.Yield.Pop_Finder pop_form = new Pop_Finder(fgrid_SRF, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC);
				pop_form.Location = new Point(MousePosition.X, MousePosition.Y);
				pop_form.Show();
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_FindComp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}




		#endregion

		#region contextmenu

		private void cmenu_SRF_Popup(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_SRF.Selection.r1; 
				int level = Convert.ToInt32(fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() );

//				if(level != _LevelPart) return;
//
//				string component_cd = fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString().Trim();
				
//				if(component_cd.Equals("") )
//				{
//					menuItem_SaveComp.Enabled = true;
//				}
//				else
//				{
//					menuItem_SaveComp.Enabled = false;
//				}


				if(level == _LevelPart)
				{
					menuItem_Separator1.Visible = false;
					menuItem_SetSizeYN.Visible = false;
				}
				else
				{
					menuItem_Separator1.Visible = true;
					menuItem_SetSizeYN.Visible = true;
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_SRF_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void menuItem_AllSelect_Click(object sender, System.EventArgs e)
		{
			try
			{
				Check_AllSelect(true); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AllSelect_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void menuItem_AllDeselect_Click(object sender, System.EventArgs e)
		{
			try
			{
				Check_AllSelect(false); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_AllDeselect_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void menuItem_SaveComp_Click(object sender, System.EventArgs e)
		{
			try
			{
				Save_NewComponent(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_SaveComp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void menuItem_SetSizeYN_Click(object sender, System.EventArgs e)
		{
			try
			{
				Set_SizeYN(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_SetSizeYN_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// Check_AllSelect : 전체 선택 설정, 선택 해제 처리
		/// </summary>
		/// <param name="arg_select_flag"></param>
		private void Check_AllSelect(bool arg_select_flag)
		{ 
			C1.Win.C1FlexGrid.CheckEnum check_flag = (arg_select_flag) ? CheckEnum.Checked : CheckEnum.Unchecked;

			for(int i = fgrid_SRF.Rows.Fixed; i < fgrid_SRF.Rows.Count; i++)
			{
				fgrid_SRF.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, check_flag);

				if(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxEXIST_YN].ToString() == "Y") continue;

				if(arg_select_flag)
				{
					fgrid_SRF[i, 0] = "Y";
					//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrReadOnly;
				}
				else
				{
					fgrid_SRF[i, 0] = "N";
					//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = Color.Empty;
				}


			}


		}


		/// <summary>
		/// Save_NewComponent : 신규 Component 로 등록 처리
		/// </summary>
		private void Save_NewComponent()
		{

			int sel_row = fgrid_SRF.Selection.r1; 
			string part_desc = fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
			string color_cd = fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
			string color_name = fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString();
			string component_cd = "";

			FlexBase.MaterialBase.Pop_SaveName pop_form = new FlexBase.MaterialBase.Pop_SaveName(this.Name.ToString(), part_desc);
			pop_form.ShowDialog();

			if(!pop_form._Close_Save || ClassLib.ComVar.Parameter_PopUp[0] == "") return;

			

			part_desc = ClassLib.ComVar.Parameter_PopUp[0];

			DataRow dr = Get_CS_Component_Color(ClassLib.ComVar.DSFactory, part_desc, color_cd, color_name); 
			
			component_cd = dr.ItemArray[0].ToString();  
			color_cd = dr.ItemArray[1].ToString(); 

			fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD] = component_cd; 
			fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD] = color_cd; 

			fgrid_SRF.GetCellRange(sel_row, 1, sel_row, fgrid_SRF.Cols.Count - 1).Style.Clear();



			// component combo refresh 
			DataTable dt_ret = Select_SBC_COMPONENT_COMBO(" ");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);
			dt_ret.Dispose();

			


		}




		/// <summary>
		/// Set_SizeYN : 신규 Material 에 대해서 size 자재 여부 체크
		/// </summary>
		private void Set_SizeYN()
		{

			if(fgrid_SRF.Rows.Count <= fgrid_SRF.Rows.Fixed) return;



			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 

			if(message_result == DialogResult.No) return;  


			int sel_row = fgrid_SRF.Selection.r1;

			string item_cd = fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD].ToString();
			bool save_flag = Set_SBC_ITEM_SIZEYN(item_cd);

			if(! save_flag)
			{

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				return;

			}
			else
			{

				string size_yn = (fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSIZE_YN].ToString() == "N") ? "Y" : "N"; 

				fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSIZE_YN] = size_yn; 

				if(size_yn == "Y")
				{
					fgrid_SRF.GetCellRange(sel_row, 1, sel_row, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
				}
				else
				{
					fgrid_SRF.GetCellRange(sel_row, 1, sel_row, fgrid_SRF.Cols.Count - 1).StyleNew.Clear();
				}


			} // end if(! save_flag)


		}




		#endregion 

		#region drag and drop

		private void fgrid_SRF_BeforeMouseDown(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
 
			// select the row
			HitTestInfo hti = fgrid_SRF.HitTest(e.X, e.Y);
			int index = hti.Row;
			int index_col = hti.Column;


			if(index <= fgrid_SRF.Rows.Fixed) return;
			if(index_col != (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) return;

			// Only Dragging Material
			if(Convert.ToInt32(fgrid_SRF[index, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ) == _LevelPart) return;

			
			if(fgrid_SRF[index, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxEXIST_YN].ToString() == "Y") return;


			fgrid_SRF.Select(index, 0, index, fgrid_SRF.Cols.Count - 1, false);
 
			// do drag drop
			DragDropEffects dd = fgrid_SRF.DoDragDrop(fgrid_SRF.Clip, DragDropEffects.Move);
 

		}

		 
		private void fgrid_SRF_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{

			// select the row
			HitTestInfo hti = fgrid_SRF.HitTest(e.X, e.Y);
			int index = hti.Row;

			if(index <= fgrid_SRF.Rows.Fixed) return;

			// Only Dragging Material
			if(Convert.ToInt32(fgrid_SRF[index, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ) == _LevelPart) return;


			// check that we have the type of data we want
			if (e.Data.GetDataPresent(typeof(string)) )
			{
				e.Effect = DragDropEffects.Move;
			}
		}
 

		private void fgrid_BOMTemp_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
 
			// check that we have the type of data we want
			if (e.Data.GetDataPresent(typeof(string)) )
			{
				e.Effect = DragDropEffects.Move;
			}




		}

		private void fgrid_BOMTemp_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{


			_SRF_YN = true;



			// find the drop position 
			Point pt = fgrid_BOMTemp.PointToClient(new Point(e.X, e.Y));
			HitTestInfo hti = fgrid_BOMTemp.HitTest(pt.X, pt.Y);
			int index = hti.Row;
			if (index < 0) index = fgrid_BOMTemp.Rows.Count; // append
			if (index < 1) index = 1;               // after fixed row

 

			if(fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() != _RawMatCd)
			{
				ClassLib.ComFunction.User_Message("Select [Raw Material]", "Select SRF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
  
 




			int source_row = fgrid_SRF.Selection.r1;

		 


			if(cmb_Component.SelectedIndex == -1)
			{
				string nike_part_desc = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
                string component_cd = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString();;
				 

				txt_Component.Text = nike_part_desc;
				cmb_Component.SelectedValue = component_cd;
			}



			
			string source_item_cd = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD].ToString();
			string source_item_name = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_NAME1].ToString();
			string source_color_cd = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
			string source_color_name = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString();

			string source_sizeyn = (fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSIZE_YN].ToString() == "Y") ? "TRUE" : "FALSE";
			string source_unit = fgrid_SRF[source_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxMNG_UNIT].ToString();


			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = source_item_cd;  
			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = source_item_name;
			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = source_item_name;
			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = source_color_cd;
			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = source_color_name;

			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = source_sizeyn;
			fgrid_BOMTemp[index, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT] = source_unit;



			 

		}

		#endregion 

		#region check node


		private void fgrid_SRF_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				
				Check_Node();
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_SRF_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}



		/// <summary>
		/// Check_Node : 
		/// </summary>
		private void Check_Node()
		{

			int sel_row = fgrid_SRF.Selection.r1;

			int level = Convert.ToInt32(fgrid_SRF[sel_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() );

			C1.Win.C1FlexGrid.Node parent_node = null;


			switch(level)
			{
				case _LevelPart:

					parent_node = fgrid_SRF.Rows[sel_row].Node;

					break;

				case _LevelMatCd:

					parent_node = fgrid_SRF.Rows[sel_row].Node.GetNode(NodeTypeEnum.Parent);

					break;
			} // end switch


			if(parent_node.GetNode(NodeTypeEnum.FirstChild) == null) return;

			int parent_row = parent_node.Row.Index;
			int start_row = parent_node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int end_row = parent_node.GetNode(NodeTypeEnum.LastChild).Row.Index;

			bool parent_check = (fgrid_SRF.GetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Checked) ? true : false;
 
			int child_check_count = 0;


			switch(level)
			{
				case _LevelPart:

					for(int i = start_row; i <= end_row; i++)
					{
						fgrid_SRF.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, (parent_check) ? CheckEnum.Checked : CheckEnum.Unchecked);

						if(parent_check)
						{
							fgrid_SRF[i, 0] = "Y";
							//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrReadOnly;

						}
						else
						{
							fgrid_SRF[i, 0] = "N";
							//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = Color.Empty;
						}



					}

					break;

					
				case _LevelMatCd: // 하위 노드 중 하나라도 체크 되어 있을 경우, 상위도 체크 처리

					for(int i = start_row; i <= end_row; i++)
					{
						if(fgrid_SRF.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Checked)
						{
							child_check_count++;

							fgrid_SRF[i, 0] = "Y";
							//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrReadOnly;

						} 
						else
						{
							fgrid_SRF[i, 0] = "N";
							//fgrid_SRF.GetCellRange(i, 1, i, fgrid_SRF.Cols.Count - 1).StyleNew.ForeColor = Color.Empty;
						}


					}

					if(child_check_count == 0)
					{
						fgrid_SRF.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Unchecked);
					}
					else
					{
						fgrid_SRF.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC, CheckEnum.Checked);
						break;
					}

					break;
			} // end switch


			


		}


		#endregion

		#region batch



		private void btn_SRF_Move_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;


				int start_row = 0, end_row = 0;

				int srf_level = Convert.ToInt32(fgrid_SRF[fgrid_SRF.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() );

				if(srf_level == _LevelPart)
				{
					start_row = fgrid_SRF.Selection.r1;

					C1.Win.C1FlexGrid.Node node = fgrid_SRF.Rows[fgrid_SRF.Selection.r1].Node; 
					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

				}
				else
				{
					C1.Win.C1FlexGrid.Node node = fgrid_SRF.Rows[fgrid_SRF.Selection.r1].Node; 
					
					start_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;
					end_row = node.GetNode(NodeTypeEnum.LastSibling).Row.Index;

				}

				Batch_SRF(start_row, end_row); 


 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SRF_Move_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		



		private void btn_SRF_Batch_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;


				//Batch_SRF(); 

				Batch_SRF(fgrid_SRF.Rows.Fixed, fgrid_SRF.Rows.Count - 1); 
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SRF_Batch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}





		/// <summary>
		/// Batch_SRF : 
		/// </summary>
		private void Batch_SRF()
		{


			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 

			if(message_result == DialogResult.No) return;  
 


			int check_count = 0;


			string component_cd = "";
			string nike_part_desc = "";
			string color_cd = "";
			string color_name = "";
			string item_cd = "";
			string item_name = "";

 

			int level = 0; 





			_SRF_YN = true;


			// 기본적으로 '00005 : RAW' 형으로 설정 해 주기 때문에 행 삭제
			if(fgrid_BOMTemp.Rows.Count > fgrid_BOMTemp.Rows.Fixed)
			{
				fgrid_BOMTemp.Rows.Remove(fgrid_BOMTemp.Rows.Count - 1);
			}


			txt_Component.Text = "";
			cmb_Component.SelectedIndex = -1;


			
			DataRow dr;

			//------------------------------------------------------------------------------------------------------------------
			// component, color 새로 생성
			//------------------------------------------------------------------------------------------------------------------
			for(int i = fgrid_SRF.Rows.Fixed; i < fgrid_SRF.Rows.Count; i++)
			{

				level = Convert.ToInt32(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ); 
				if(level != _LevelMatCd) continue;

				
				if(fgrid_SRF.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Unchecked
			        || fgrid_SRF[i, 0].ToString() != "Y") continue; 

				check_count++; 



				
				if(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString().Trim() != "") continue;
				nike_part_desc = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
				color_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
				color_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString(); 

				dr = Get_CS_Component_Color(ClassLib.ComVar.DSFactory, nike_part_desc, color_cd, color_name);

				component_cd = dr.ItemArray[0].ToString();
				color_cd = dr.ItemArray[1].ToString();

				fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD] = component_cd;
				fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD] = color_cd;
 




			} // end for i
			//------------------------------------------------------------------------------------------------------------------


			//------------------------------------------------------------------------------------------------------------------
			// 그리드에 표시
			//------------------------------------------------------------------------------------------------------------------
 
			if(check_count == 0) return;


			int new_row_start = fgrid_BOMTemp.Rows.Count;
			int new_count = 0;

			fgrid_BOMTemp.Rows.InsertRange(fgrid_BOMTemp.Rows.Count, check_count);


			

			for(int i = fgrid_SRF.Rows.Fixed; i < fgrid_SRF.Rows.Count; i++)
			{

				level = Convert.ToInt32(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ); 
				if(level != _LevelMatCd) continue;




				fgrid_SRF[i, 0] = (fgrid_SRF[i, 0] == null) ? "N" : fgrid_SRF[i, 0].ToString();

				if(fgrid_SRF.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Unchecked
					|| fgrid_SRF[i, 0].ToString() != "Y") continue;
				
				 

				if(cmb_BOMTemp.SelectedIndex == -1)
				{
					cmb_BOMTemp.SelectedValue = _OnlyRawMat_TemplateCd;
				}

				if(cmb_BOMTemp.SelectedValue.ToString() != _OnlyRawMat_TemplateCd) // [Raw] bom template 으로 계속 추가
				{  
					fgrid_BOMTemp.Rows.Count = fgrid_BOMTemp.Rows.Fixed;  

					new_row_start = fgrid_BOMTemp.Rows.Count;
					fgrid_BOMTemp.Rows.InsertRange(fgrid_BOMTemp.Rows.Count, check_count);

				}
 


				component_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString();
				item_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD].ToString();
				item_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_NAME1].ToString();
				color_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
				color_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString(); 
 

				fgrid_BOMTemp[new_row_start + new_count, 0] = "I"; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxFACTORY] = _Factory;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSTYLE_CD] = _StyleCd.Replace("-", "");
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSEMI_GOOD_CD] = _SGCd; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "";
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL] = "1";
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_TREE_CD] = cmb_BOMTemp.SelectedValue.ToString();
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD] = _RawMatCd;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME] = _RawMatCd_Desc;



				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD] = component_cd; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = item_cd;  
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = item_name;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = item_name;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = color_cd;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = color_name;

				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = "FALSE";


				// raw material 글자색 변경
				fgrid_BOMTemp.Rows[new_row_start + new_count].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;

				new_count++;




				// batch 대상에서 제외
				fgrid_SRF[i, 0] = "";

 

			}  
			//------------------------------------------------------------------------------------------------------------------


			// component combo refresh 
			DataTable dt_ret = Select_SBC_COMPONENT_COMBO(" ");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);
			dt_ret.Dispose();



		}

 

		/// <summary>
		/// Batch_SRF : 
		/// </summary>
		private void Batch_SRF(int arg_start_row, int arg_end_row)
		{


//			DialogResult message_result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 
//
//			if(message_result == DialogResult.No) return;  
 


			int check_count = 0;


			string component_cd = "";
			string nike_part_desc = "";
			string color_cd = "";
			string color_name = "";
			string item_cd = "";
			string item_name = "";

 

			int level = 0; 





			_SRF_YN = true;


			// 기본적으로 '00005 : RAW' 형으로 설정 해 주기 때문에 행 삭제
			//if(fgrid_BOMTemp.Rows.Count > fgrid_BOMTemp.Rows.Fixed) 
			if(fgrid_BOMTemp[fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD] == null 
				|| fgrid_BOMTemp[fgrid_BOMTemp.Rows.Fixed, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString() == "") 
			{
				fgrid_BOMTemp.Rows.Remove(fgrid_BOMTemp.Rows.Count - 1);
			}


			txt_Component.Text = "";
			cmb_Component.SelectedIndex = -1;


			
			DataRow dr;

			//------------------------------------------------------------------------------------------------------------------
			// component, color 새로 생성
			//------------------------------------------------------------------------------------------------------------------
			for(int i = arg_start_row; i <= arg_end_row; i++)
			{

				level = Convert.ToInt32(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ); 
				if(level != _LevelMatCd) continue;

				
				if(fgrid_SRF.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Unchecked
					|| fgrid_SRF[i, 0].ToString() != "Y") continue; 

				check_count++; 



				
				if(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString().Trim() != "") continue;
				nike_part_desc = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
				color_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
				color_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString(); 

				dr = Get_CS_Component_Color(ClassLib.ComVar.DSFactory, nike_part_desc, color_cd, color_name);

				component_cd = dr.ItemArray[0].ToString();
				color_cd = dr.ItemArray[1].ToString();

				fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD] = component_cd;
				fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD] = color_cd;
 




			} // end for i
			//------------------------------------------------------------------------------------------------------------------


			//------------------------------------------------------------------------------------------------------------------
			// 그리드에 표시
			//------------------------------------------------------------------------------------------------------------------
 
			if(check_count == 0) return;


			int new_row_start = fgrid_BOMTemp.Rows.Count;
			int new_count = 0;

			fgrid_BOMTemp.Rows.InsertRange(fgrid_BOMTemp.Rows.Count, check_count);


			

			for(int i = arg_start_row; i <= arg_end_row; i++)
			{

				level = Convert.ToInt32(fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_LEVEL].ToString() ); 
				if(level != _LevelMatCd) continue;




				fgrid_SRF[i, 0] = (fgrid_SRF[i, 0] == null) ? "N" : fgrid_SRF[i, 0].ToString();

				if(fgrid_SRF.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxTREE_DESC) == CheckEnum.Unchecked
					|| fgrid_SRF[i, 0].ToString() != "Y") continue;
				
				 

				if(cmb_BOMTemp.SelectedIndex == -1)
				{
					cmb_BOMTemp.SelectedValue = _OnlyRawMat_TemplateCd;
				}

				if(cmb_BOMTemp.SelectedValue.ToString() != _OnlyRawMat_TemplateCd) // [Raw] bom template 으로 계속 추가
				{  
					fgrid_BOMTemp.Rows.Count = fgrid_BOMTemp.Rows.Fixed;  

					new_row_start = fgrid_BOMTemp.Rows.Count;
					fgrid_BOMTemp.Rows.InsertRange(fgrid_BOMTemp.Rows.Count, check_count);

				}
 


				component_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD].ToString();
				item_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD].ToString();
				item_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_NAME1].ToString();
				color_cd = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_CD].ToString();
				color_name = fgrid_SRF[i, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOLOR_DESC].ToString(); 
 

				fgrid_BOMTemp[new_row_start + new_count, 0] = "I"; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxFACTORY] = _Factory;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSTYLE_CD] = _StyleCd.Replace("-", "");
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSEMI_GOOD_CD] = _SGCd; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_SEQ] = "";
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL] = "1";
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_TREE_CD] = cmb_BOMTemp.SelectedValue.ToString();
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD] = _RawMatCd;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_NAME] = _RawMatCd_Desc;



				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD] = component_cd; 
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] = item_cd;  
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1] = item_name;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME] = item_name;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] = color_cd;
				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME] = color_name;

				fgrid_BOMTemp[new_row_start + new_count, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN] = "FALSE";


				// raw material 글자색 변경
				fgrid_BOMTemp.Rows[new_row_start + new_count].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant;

				new_count++;




				// batch 대상에서 제외
				fgrid_SRF[i, 0] = "";

 

			}  
			//------------------------------------------------------------------------------------------------------------------


			// component combo refresh 
			DataTable dt_ret = Select_SBC_COMPONENT_COMBO(" ");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);
			dt_ret.Dispose();



		}

 


		/// <summary>
		/// Get_CS_Component_Color : SRF Part 를 CS Component 로 등록
		/// Nike Color Code 가 CS에 없을 경우 신규로 등록
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_nike_part_desc"></param>
		/// <param name="arg_color_cd"></param>
		/// <param name="arg_color_desc"></param>
		/// <returns></returns>
		private DataRow Get_CS_Component_Color(string arg_factory, string arg_nike_part_desc, string arg_color_cd, string arg_color_desc)
		{

			string Proc_Name = "PKG_SBC_YIELD_SRF.GET_CS_COMPONENT_COLOR";

			MyOraDB.ReDim_Parameter(5);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_PART_DESC";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_nike_part_desc;
			MyOraDB.Parameter_Values[1] = arg_color_cd;
			MyOraDB.Parameter_Values[2] = arg_color_desc;
			MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[4] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name].Rows[0];

 

		}




		/// <summary>
		/// Set_SBC_ITEM_SIZEYN : 
		/// </summary>
		/// <param name="arg_item_cd"></param>
		/// <returns></returns>
		private bool Set_SBC_ITEM_SIZEYN(string arg_item_cd)
		{

			try
			{

				string Proc_Name = "PKG_SBC_ITEM.SAVE_SBC_ITEM_SIZEYN";

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = Proc_Name ;

				MyOraDB.Parameter_Name[0] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[1] = "ARG_UPD_USER"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  

				MyOraDB.Parameter_Values[0] = arg_item_cd;
				MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User; 


				MyOraDB.Add_Modify_Parameter(true);
				DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

				if(DS_Ret == null) return false;
				return true;


			}
			catch
			{
				return false;
			}

		}




		#endregion

		#region return data

		/// <summary>
		/// Select Item Data and Yield Value Data Return
		/// </summary>
		private void Return_Data_SRF()
		{
			try
			{ 
				 

				bool check_ok = false;

				// already item/ spec/ color setting
				check_ok = Check_Create_Condition(true);

				if(!check_ok) 
				{
					_Cancel_Flag = true;
					return;  
				}

				 
				// all setting yield value check
				check_ok = Check_All_Setting_YieldValue();

				if(!check_ok) 
				{
					_Cancel_Flag = true;
					return;   
				}
				  

				// Make head data
				Make_DT_YieldHead_SRF(); 

				 

 
				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void Make_DT_YieldHead_SRF()
		{
			string current_templatelevel = ""; 
			string condition = "";
 
			DataRow[] findrow = null; 
			DataRow datarow = null;

			int find_component_desc_row = -1;
			int find_item_row = -1;


			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{ 
  
				//-----------------------------------------------------------------------------------------------------------
				// material value row 구성
				//-----------------------------------------------------------------------------------------------------------

				current_templatelevel = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
 

				condition = "DIVISION = '" + i.ToString() + "'";

				findrow = _DT_Return.Select(condition);


				for(int j = 0; j < findrow.Length; j++)
				{ 

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = i.ToString();

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1] = Convert.ToString(current_templatelevel.Length + _CmpLevel);

					// semi good cd + component cd + template seq + template level
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1] 
						= _SGCd 
						+ fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString() 
						+ current_templatelevel;

					if(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString() == _RawMatCd)
					{
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeMat;
					}
					else
					{
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeJoint;
					}

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTREE] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY] = _Factory;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD] = _StyleCd;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = _SGCd;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString();

					find_component_desc_row = fgrid_SRF.FindRow(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString(),
						                                            fgrid_SRF.Rows.Fixed,
						                                            (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxCOMPONENT_CD,
						                                            false, true, false);

					if(find_component_desc_row != -1)
					{ 
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_NAME] 
							= fgrid_SRF[find_component_desc_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
					}

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = "";  
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD] = cmb_BOMTemp.SelectedValue.ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_NAME] = cmb_BOMTemp.Columns[1].Text;
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_NAME1].ToString();
				
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
						? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
				
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_NAME].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxUNIT].ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN]  
						= (Convert.ToBoolean(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) ) ? "Y" : "N"; 


					
					//---------------------------------------------------------------------------------------------
					// srf 정보
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO] = cmb_SRFNo.SelectedValue.ToString();
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID] = cmb_BOMID.SelectedValue.ToString();

					find_item_row = fgrid_SRF.FindRow(fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString(),
						                              fgrid_SRF.Rows.Fixed,
													  (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxITEM_CD,
						                              false, true, false);

					if(find_item_row != -1)
					{ 
						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX] 
							= fgrid_SRF[find_item_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxSRF_SEQ_MAX].ToString();

						findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV]
							= fgrid_SRF[find_item_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxLOAD_UPD_USER].ToString();
					}
					//---------------------------------------------------------------------------------------------
 

					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO] = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
						? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
				
					findrow[j][(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_NAME].ToString();
					



					

				} // end for j 


				//-----------------------------------------------------------------------------------------------------------
				// component row 구성
				// Template Level = 1인 구조마다 component 행 강제 추가
				// Main 화면에 트리로 구성 해 주기 위함
				//-----------------------------------------------------------------------------------------------------------
				

				if (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxTEMPLATE_LEVEL].ToString() != "1") continue;

				datarow = _DT_Return.NewRow(); 


				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION] = "0";

				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1] = _CmpLevel;

				// semi good cd + component cd
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxKEY1] = _SGCd + fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString(); 
			
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION] = _TypeCmp; 


				//datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString();
				if(find_component_desc_row != -1)
				{ 
					datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTREE]
						= fgrid_SRF[find_component_desc_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
 
				} 

				
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxFACTORY] = _Factory;
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSTYLE_CD] = _StyleCd;
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD] = _SGCd;

				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString();
 
				 
				if(find_component_desc_row != -1)
				{ 
					datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_NAME] 
						= fgrid_SRF[find_component_desc_row, (int)ClassLib.TBSBC_YIELD_VALUE_SRF.IxPART_DESC].ToString();
 
				} 


				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL] = "0";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_CD] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_TREE_NAME] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_CD] = "";

				// key 조합을 위해서
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_CD] = fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD].ToString();
				
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxITEM_NAME] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_CD] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxCOLOR_NAME] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxUNIT] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN] = "N";  
 
			    datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_NO] = "";
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxBOM_ID] = ""; 
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_SEQ_MAX] = ""; 
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSRF_CDC_DEV] = "";  

				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD_INFO] = ""; 
				datarow[(int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME_INFO] = "";  
			
				for(int j = _IxHEAD_COL_END + 1; j < datarow.ItemArray.Length; j++) datarow[j] = ""; 


				//int rowID = (int)_DT_Return.GetType().GetField("rowID", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(datarow);

				// Template Level = 1인 구조마다 component 행 강제 추가
				// 전체 DataTable 에서의 행 위치 검색 
				int rowID = -1;
				string division = "";

				for(int a = 0; a < _DT_Return.Rows.Count; a++)
				{
					
					division = _DT_Return.Rows[a].ItemArray[(int)ClassLib.TBSBC_YIELD_INFO.IxDIVISION].ToString();

					if(division == i.ToString() )
					{
						rowID = a;
						break;
					}
				}


				_DT_Return.Rows.InsertAt(datarow, rowID); 
 
 

			} // end for i

		}


		 

	


		#endregion
 

		#endregion

		#region 이벤트 처리

		private void cmb_Component_SelectedValueChanged(object sender, System.EventArgs e)
		{
			 
			try
			{
				
				if(cmb_Component.SelectedIndex == -1 || cmb_Component.SelectedValue.ToString() == "") return; 
 
				txt_Component.Text = cmb_Component.SelectedValue.ToString(); 
				 
				// [Add Component] 실행 시 선택 component 중복 체크
				Check_Duplicate_Component(); 

				if(fgrid_BOMTemp.Rows.Count <= fgrid_BOMTemp.Rows.Fixed) return;

				if(cmb_Component.SelectedValue == null) return;

				
				
			
				// component 변화 반영
				for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
				{
					fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOMPONENT_CD] = cmb_Component.SelectedValue.ToString();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Component_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 

			
		}
  
 
 

		private void btn_AddNew_Comp_Click(object sender, System.EventArgs e)
		{
			
			try
			{

				ClassLib.ComVar.Parameter_PopUp = null;
				FlexBase.MaterialBase.Form_BC_Component pop_form = new FlexBase.MaterialBase.Form_BC_Component(true);
				pop_form.ShowDialog();


				if(ClassLib.ComVar.Parameter_PopUp == null) return;

				txt_Component.Text = ClassLib.ComVar.Parameter_PopUp[0];  // name
				Set_Component_Combo();
				cmb_Component.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_AddNew_Comp_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

	 



 
		/// <summary>
		/// Check_Duplicate_ItemSpecColor : 
		/// </summary>
		/// <param name="arg_row">new row</param>
		/// <param name="arg_itemcd">new item code</param>
		/// <param name="arg_speccd">new specificatoin code</param>
		/// <param name="arg_colorcd">new color code</param>
		/// <remarks>true : duplicate, false : new </remarks>
		public bool Check_Duplicate_ItemSpecColor(int arg_row, string arg_itemcd, string arg_speccd, string arg_colorcd)
		{ 

			string itemcd = "", speccd = "", colorcd = "";
			string new_item = "", now_item = "";
			int count = 0;


			new_item = arg_itemcd + arg_speccd + arg_colorcd;

			if(new_item == "") return false;




			for(int i = fgrid_BOMTemp.Rows.Fixed; i < fgrid_BOMTemp.Rows.Count; i++)
			{
				if(i == arg_row) continue;

				itemcd = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null)
					? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString();

				speccd = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD] == null) 
					? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();

				colorcd = (fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD] == null) 
					? "" : fgrid_BOMTemp[i, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxCOLOR_CD].ToString();


				now_item = itemcd + speccd + colorcd;

				if(new_item == now_item)
				{
					count++;
				}

			} // end for i


			if(count == 0)
			{
				return false;
			}
			else
			{ 
				return true;
			}

			

		}




		/// <summary>
		/// Check_Duplicate_Component : [Add Component] 실행 시 선택 component 중복 체크
		/// </summary>
		/// <returns></returns>
		private void Check_Duplicate_Component()
		{ 

			if(_Division != ClassLib.ComVar.Yield_CurrentDIV.AddCmp) return;

			int parent_sel_row = _Parent_Form.fgrid_Yield.Selection.r1;
			string current_type = "", current_sg = "", current_component = "";

			for(int i = parent_sel_row; i < _Parent_Form.fgrid_Yield.Rows.Count; i++)
			{

				current_type = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTYPE_DIVISION].ToString(); 
				current_sg = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
				current_component = _Parent_Form.fgrid_Yield[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();

				if(current_type == _TypeCmp)
				{
					//if(current_sg == _SGCd && current_component == cmb_Component.SelectedValue.ToString() )
					if(current_component == cmb_Component.SelectedValue.ToString() )
					{  
						_DuplicateComp = current_component; 

						txt_Component.Text = "";  
						cmb_Component.SelectedIndex = -1;   
						
						//string message = "Duplicate Component : [" + cmb_Component.Columns[1].Text + "]"; 
						string message = "Duplicate Component";
						ClassLib.ComFunction.User_Message(message, "Check_Duplicate_Component", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						

						break;
					}

				} // end if 

			} // end for i
 

		}



		private void cmb_BOMTemp_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
			Search_TemplateTree_List(); 
		} 
		

		private void txt_Component_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				Set_Component_Combo();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void Set_Component_Combo()
		{

			this.Cursor = Cursors.WaitCursor;


			//component combo list
			DataTable dt_ret = Select_SBC_COMPONENT_COMBO(txt_Component.Text.Trim() );
				
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Component, 0, 1, false, 0, 210);

//			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_Component, 0, 1);
//			cmb_Component.Splits[0].DisplayColumns[0].Width = 0;
//			cmb_Component.Splits[0].DisplayColumns[1].Width = 210;
//			cmb_Component.DropDownWidth = 210;

			dt_ret.Dispose();
 

			this.Cursor = Cursors.Default;



		}

		private void txt_BOMTemp_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;

				this.Cursor = Cursors.WaitCursor;

				//template bom code combo list 
				DataTable dt_ret = FlexBase.Yield.Form_BC_BOMTemplate.Select_TemplateTree_Code(txt_BOMTemp.Text.Trim() );
				
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOMTemp, 0, 1, false, 0, 210);
				
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_BOMTemp, 0, 1, 2);
				cmb_BOMTemp.Splits[0].DisplayColumns[0].Width = 0;
				cmb_BOMTemp.Splits[0].DisplayColumns[1].Width = 210;
				cmb_BOMTemp.Splits[0].DisplayColumns[2].Width = 100;
				cmb_BOMTemp.DropDownWidth = 210;

				dt_ret.Dispose();

				fgrid_BOMTemp.Rows.Count = fgrid_BOMTemp.Rows.Fixed;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_BOMTemp_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			Search_TemplateTree_List();
		}


		private void btn_SearchTemp_Click(object sender, System.EventArgs e)
		{
			Show_BOMTemplate();
		}


		private void btn_CopyTemp_Click(object sender, System.EventArgs e)
		{
			Copy_BOMTemplate();
		}


		private void btn_AddRawMat_Click(object sender, System.EventArgs e)
		{
			Add_RawMaterial();
		}


		private void btn_CreateProcCd_Click(object sender, System.EventArgs e)
		{
			Create_Process_Code();
		}


		/// <summary>
		/// raw material 일때만 context menu(popup menu) 보여지도록 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_BOMTemp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				if(e.Button != MouseButtons.Right) return;

				int sel_row = fgrid_BOMTemp.Selection.r1;
 
				fgrid_BOMTemp.ContextMenu = cmenu_BOMTemp;

				if( Set_AddRawMat_Status() )
				{
					menuItem_Separator.Visible = true;
					menuItem_DeleteRawMat.Visible = true;
				}
				else
				{
					menuItem_Separator.Visible = false;
					menuItem_DeleteRawMat.Visible = false;
				}
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_BOMTemp_MouseDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				int row = fgrid_BOMTemp.MouseRow;
				int col = fgrid_BOMTemp.MouseCol;

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
					text = fgrid_BOMTemp.GetDataDisplay(row, col);

					// get display rectangle
					Rectangle rc = fgrid_BOMTemp.GetCellRect(row, col, false);
					rc.Intersect(fgrid_BOMTemp.ClientRectangle);

					// measure text
					using (Graphics g = fgrid_BOMTemp.CreateGraphics())
					{
						CellStyle s = fgrid_BOMTemp.GetCellStyleDisplay(row, col);
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
			if (_ttip != null && _ttip.GetToolTip(fgrid_BOMTemp) != text)
				_ttip.SetToolTip(fgrid_BOMTemp, text);


		}


		#endregion

		private void fgrid_BOMTemp_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			try
			{

				//---------------------------------------------------------------------------
				// show tooltip
				//---------------------------------------------------------------------------
				_flex_MouseMoveTooltip(sender, e); 
				//---------------------------------------------------------------------------  
 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_BOMTemp_MouseMove", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}




		/// <summary>
		/// 채산값 입력 팝업 실행
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_YieldValue_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
			 	
				//if(! chk_YieldValuePaste.Checked)
				//{
					Show_Input_YieldValue_Popup(e.Button);
				//}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_YieldValue_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 



		/// <summary>
		/// 사이즈 컬럼 너비 조정 시 일괄적으로 전체 컬럼 너비 반영
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_YieldValue_AfterResizeColumn(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{
				fgrid_YieldValue.Cols[i].Width = fgrid_YieldValue.Cols[e.Col].Width;
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_YieldValue_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			try
			{
				
				//채산값 할당
				Make_DT_YieldTail(); 


				//SPEC CODE 별 색깔 표시
				Disaply_Yield_Color();

			}
			catch//(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "fgrid_YieldValue_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			
		}


		/// <summary>
		/// Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem_ItemList_Click(object sender, System.EventArgs e)
		{
			Show_Item_Popup();	
		} 
 

		/// <summary>
		/// 추가했던 Raw Material 취소 처리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void menuItem_DeleteRawMat_Click(object sender, System.EventArgs e)
		{
			Delete_AddRawMat();
		}
  
		


		
		private void fgrid_BOMTemp_Click(object sender, System.EventArgs e)
		{
			Set_YieldValue_Spec();
		}



		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			_Cancel_Flag = false;


			// check yield value
			// min, max 채산값 벗어나는 사이즈런 있을 경우 선택 메세지 표시
			// yes : 계속 진행 (저장)
			// no : 저장하지 않고, 벗어난 사이즈 문대로 포커스 이동
			bool check_flag = Check_Yield_Value();
 

			bool run_flag = false;

			// 메시지 표시
			if(! check_flag)
			{
				string message = "Unsuitable yield value." + "\r\n" + "Do you continue work ?"; 
				DialogResult result = ClassLib.ComFunction.User_Message(message, "Validation Check", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if(result == DialogResult.Yes)
				{
					run_flag = true;
				}
				else
				{
					run_flag = false;
				}


			}
			else
			{
				run_flag = true;
			}



			if(run_flag)
			{
				if(_SRF_YN)
				{
					Return_Data_SRF();
				}
				else
				{
					Return_Data();
				}
			} // end if(run_flag)



		}
 


		private bool Check_Yield_Value()
		{

			try
			{

				double min_value = 9999999999;
				double max_value = -9999999999;
				double now_value = 0;

				
//				for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
//				{
//					now_value = Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue, i].ToString() );
//					min_value = (min_value < now_value) ? min_value : now_value;
//					max_value = (max_value > now_value) ? max_value : now_value; 
//				} // end for i

				min_value = Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue, _IxCS_SIZE_START].ToString() );
				max_value = Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue, fgrid_YieldValue.Cols.Count - 1].ToString() );


				for(int i = _IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
				{
					now_value = Convert.ToDouble(fgrid_YieldValue[_Row_YieldValue, i].ToString() );

					if(now_value < min_value || now_value > max_value)
					{
						fgrid_YieldValue.LeftCol = i - 1;
						fgrid_YieldValue.Select(_Row_YieldValue, i, true);

						return false;
					}
				} // end for i


				return true;


			}
			catch
			{
				return false;
			}

		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{ 

			_Cancel_Flag = true; 

			//---------------------------
			// 전역변수 초기화
			//---------------------------
			Clear_StaticVal();
			//--------------------------- 

			this.Hide();
		}



		private void Pop_Yield_Modify_withSRF_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_Cancel_Flag = true;
			

			//---------------------------
			// 전역변수 초기화
			//---------------------------
			Clear_StaticVal();
			//--------------------------- 

			this.Hide();
			e.Cancel = true;
		}


		/// <summary>
		///  전역변수 초기화
		/// </summary>
		private void Clear_StaticVal()
		{

			_Apply_CreateProcess = false;  
			_SRF_ON_Flag = false;
			_Cancel_Flag = false;
			_SRF_YN = false;

			_DT_Return = null;
			_DuplicateComp = "";

			_OnlyRawMat = false;
			btn_AddRawMat.Enabled = true;
			btn_CreateProcCd.Enabled = true;

			btn_Apply.Enabled = true; 
			fgrid_BOMTemp.AllowEditing = true;
			fgrid_BOMTemp.ContextMenu = cmenu_BOMTemp;


			_Division = ClassLib.ComVar.Yield_CurrentDIV.AddCmp;


		}


		private void txt_YieldValue_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				// 전 문대 채산값 입력
				for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
				{
					fgrid_YieldValue[_Row_YieldValue, i] = txt_YieldValue.Text;
 

//					// 사이즈 자재일때 기본 "nothing" 처리
//					if(Convert.ToBoolean(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSIZE_YN].ToString() ) )
//					{
//						fgrid_YieldValue[_Row_SpecCd, i] = _SizeSpecCd_Value; 
//						fgrid_YieldValue[_Row_SpecName, i] = _SizeSpecName_Value; 
//					} 

				}  // end for i



				//채산값 할당
				Make_DT_YieldTail(); 


				//SPEC CODE 별 색깔 표시
				Disaply_Yield_Color();




				txt_YieldValue.Text = "";


				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_YieldValue_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		private void fgrid_BOMTemp_DoubleClick(object sender, System.EventArgs e)
		{
			Show_Item_Popup();	
		}



		private void cmb_SGCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_SGCd.SelectedIndex == -1)
				{
					//_SGCd = "";
				}
				else
				{ 
					_SGCd = cmb_SGCd.SelectedValue.ToString();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SGCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void Pop_Yield_Modify_withSRF_Load(object sender, System.EventArgs e)
		{

//			if(_Division == ClassLib.ComVar.Yield_CurrentDIV.AddExcel)
//			{
//				// 임의 선택작업 후 (팝업에서는 선택된 행에 대해서 이벤트를 실행하므로) 팝업창 자동 호출
//				fgrid_BOMTemp.Select(fgrid_BOMTemp.Rows.Count - 1, 0, fgrid_BOMTemp.Rows.Count - 1, fgrid_BOMTemp.Cols.Count - 1, false); 
//				Show_Item_Popup(); 
//			}

		}


		private void fgrid_YieldValue_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.Insert:
					case Keys.C: // ** copy
						Clipboard.SetDataObject(fgrid_YieldValue.Clip);
						break;
					case Keys.X: // ** cut
						Clipboard.SetDataObject(fgrid_YieldValue.Clip);
						CellRange rg = fgrid_YieldValue.Selection;
						rg.Data = null;
						break;
					case Keys.V: // ** paste
						IDataObject data = Clipboard.GetDataObject();
						if (data.GetDataPresent(typeof(string)))
						{
							//fgrid_YieldValue.Select(fgrid_YieldValue.Row, fgrid_YieldValue.Col, fgrid_YieldValue.Rows.Count-1, fgrid_YieldValue.Cols.Count-1, false);

							fgrid_YieldValue.Select(_Row_YieldValue, fgrid_YieldValue.Col, _Row_YieldValue, fgrid_YieldValue.Cols.Count-1, false);
							fgrid_YieldValue.Clip = (string)data.GetData(typeof(string));
							fgrid_YieldValue.Select(_Row_YieldValue, fgrid_YieldValue.Col, false);



							//채산값 할당
							Make_DT_YieldTail(); 


							//SPEC CODE 별 색깔 표시
							Disaply_Yield_Color();




						}
						break;
				}
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
				//rad_cmp.tag = '1' 
				//rad_all.tag = '-1'

				fgrid_SRF.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 




		private void chk_CreateSize_CheckedChanged(object sender, System.EventArgs e)
		{

			try
			{
				
				CheckBox src = sender as CheckBox;
				string division = "";


				if(! src.Checked) return;

				
				if(src == chk_CreateSizeByValue)
				{
					// 채산값 범위로 사이즈 Spec, Group 구성
					division = "Value";
					chk_CreateSizeBySize.Checked = false;

				}
				else if(src == chk_CreateSizeBySize)
				{
					// 사이즈 문대마다 사이즈 Spec, Group 구성
					division = "Size";
					chk_CreateSizeByValue.Checked = false;

				}

				
				Create_Size_Group(division); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_CreateSize_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Create_Size_Group : 채산값 범위 또는 사이즈문대로 사이즈 Spec, Group 구성
		/// </summary>
		/// <param name="arg_division"></param>
		private void Create_Size_Group(string arg_division)
		{

			

			int size_f = -1, size_t = -1;
			string before_value = "", now_value = "";
			_CurrentColor = _SizeColor2;

			size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

			while(true)
			{


				if(arg_division == "Value")
				{ 
					// 채산값 범위에 따른 spec grouping 
					before_value = fgrid_YieldValue[_Row_YieldValue, size_f].ToString(); 

					for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
					{   
						now_value = fgrid_YieldValue[_Row_YieldValue, k].ToString(); 

						if(before_value == now_value)
						{
							size_t = k;
						}
						else
						{
							break;
						}

					} // end for k
					//-------------------------------------------------------------------------------------

				}
				else if(arg_division == "Size")
				{ 
					// 사이즈 문대마다 sepc grouping  
					size_t = size_f; 
				} // end if arg_division



				string spec_string = fgrid_YieldValue[1, size_f].ToString().Trim() + "-" + fgrid_YieldValue[1, size_t].ToString().Trim(); 
				string spec_cd = Check_EXIST_EQUAL_SPEC(spec_string); 




				//SPEC CODE 별 색깔 표시
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}


				for(int i = size_f; i <= size_t; i++)
				{
					fgrid_YieldValue.GetCellRange(fgrid_YieldValue.Rows.Fixed, i, fgrid_YieldValue.Rows.Count - 1, i).StyleNew.BackColor = _CurrentColor;

					fgrid_YieldValue[_Row_SpecCd, i] = spec_cd;
					fgrid_YieldValue[_Row_SpecName, i] = spec_string;

				}
 




				size_f = size_t + 1;

				if(size_f == fgrid_YieldValue.Cols.Count) break;

			} // end while



			//채산값 할당
			Make_DT_YieldTail(); 
			


		}




		private void chk_CreateSizeByDB_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				
				if(! chk_CreateSizeByDB.Checked) return; 

				Get_Size_Group(); 

				chk_CreateSizeByDB.Checked = false;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "chk_CreateSizeByDB_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Get_Size_Group : sbc_yield_size_group 에서 size group 리스트 조회
		/// </summary>
		private void Get_Size_Group()
		{

			if(fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD] == null
				|| fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString().Trim().Equals("") ) return;


			string factory = _Factory;
			string item_cd = fgrid_BOMTemp[fgrid_BOMTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxITEM_CD].ToString(); 
			string style_cd = _StyleCd;

			DataTable dt_ret = Select_SBC_YIELD_SIZE_GROUP(factory, item_cd, style_cd);

			if(dt_ret == null || dt_ret.Rows.Count == 0) return;


			for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
			{

				for(int j = 0; j < dt_ret.Rows.Count; j++)
				{
					if(fgrid_YieldValue[1, i].ToString().Trim() == dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP_IN_YIELD.IxCS_SIZE].ToString().Trim() )
					{
						fgrid_YieldValue[_Row_SpecCd, i] = dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP_IN_YIELD.IxSPEC_CD].ToString();
						fgrid_YieldValue[_Row_SpecName, i] = dt_ret.Rows[j].ItemArray[(int)ClassLib.TBSBC_YIELD_SIZE_GROUP_IN_YIELD.IxSPEC_NAME].ToString();

						break;
					}
				} // end for j

			} // end for i




			//SPEC CODE 별 색깔 표시 
			Disaply_Yield_Color(); 


			//채산값 할당
			Make_DT_YieldTail();  
			


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

		#region DB Connect


		/// <summary>
		/// Select_SBC_COMPONENT_COMBO : Component Combo List
		/// </summary>
		/// <param name="arg_component"></param>
		/// <returns></returns>
		public DataTable Select_SBC_COMPONENT_COMBO(string arg_component)
		{  
			string Proc_Name = "PKG_SBC_COMPONENT.SELECT_SBC_COMPONENT_COMBO";

			MyOraDB.ReDim_Parameter(2);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_COMPONENT";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_component;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name];
		}





		/// <summary>
		/// Select_SDD_SRF_HEAD_SRFNO : SRF List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_srf_no"></param>
		/// <returns></returns>
		private DataTable Select_SDD_SRF_HEAD_SRFNO(string arg_factory, string arg_srf_no)
		{  
			string Proc_Name = "PKG_SBC_YIELD_SRF.SELECT_SDD_SRF_HEAD_SRFNO";

			MyOraDB.ReDim_Parameter(3);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_srf_no, " ");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name];
		}





		/// <summary>
		/// Select_SDD_SRF_HEAD_BOMID : SRF BOM ID List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_srfno"></param>
		/// <returns></returns>
		private DataTable Select_SDD_SRF_HEAD_BOMID(string arg_factory, string arg_srfno)
		{  
			string Proc_Name = "PKG_SBC_YIELD_SRF.SELECT_SDD_SRF_HEAD_BOMID";

			MyOraDB.ReDim_Parameter(3);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_srfno;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name];
		}



		/// <summary>
		/// Select_SDD_SRF_TAIL_PART : SRF PART List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_srfno"></param>
		/// <param name="arg_bomid"></param>
		/// <returns></returns>
		private DataTable Select_SDD_SRF_TAIL_PART(string arg_factory, string arg_srfno, string arg_bomid)
		{  
			string Proc_Name = "PKG_SBC_YIELD_SRF.SELECT_SDD_SRF_TAIL_PART";

			MyOraDB.ReDim_Parameter(4);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "ARG_BOM_ID";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_srfno;
			MyOraDB.Parameter_Values[2] = arg_bomid;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name];
		}




		/// <summary>
		/// Select_SDD_SRF_TAIL_MATCD : SRF Material List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_srf_factory"></param>
		/// <param name="arg_srfno"></param>
		/// <param name="arg_bomid"></param>
		/// <param name="arg_partno"></param>
		/// <returns></returns>
		private DataTable Select_SDD_SRF_TAIL_MATCD(string arg_factory,    
			                                        string arg_srf_factory, 
			                                        string arg_srfno, 
			                                        string arg_bomid, 
			                                        string arg_partno)
		{  
			string Proc_Name = "PKG_SBC_YIELD_SRF.SELECT_SDD_SRF_TAIL_MATCD";

			MyOraDB.ReDim_Parameter(7);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[3] = "ARG_BOM_ID";
			MyOraDB.Parameter_Name[4] = "ARG_PART_NO";
			MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_srf_factory;
			MyOraDB.Parameter_Values[2] = arg_srfno;
			MyOraDB.Parameter_Values[3] = arg_bomid;
			MyOraDB.Parameter_Values[4] = arg_partno;
			MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			return  DS_Ret.Tables[Proc_Name];
		}






		/// <summary>
		/// Select_TemplateTree_List : Template Tree의 구조 List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_sgcd"></param>
		/// <param name="arg_componentcd"></param>
		/// <param name="arg_template_seq"></param>
		/// <param name="template_treecd"></param>
		/// <returns></returns>
		private DataTable Select_TemplateTree_List(string arg_factory, 
			string arg_stylecd, 
			string arg_sgcd, 
			string arg_componentcd, 
			string arg_template_seq, 
			string arg_template_treecd)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_TEMPLATE_TREE_LIST";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = arg_stylecd; 
			MyOraDB.Parameter_Values[2] = arg_sgcd; 
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(arg_componentcd, " "); 
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_String(arg_template_seq, " ");
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_String(arg_template_treecd, " ");  
			MyOraDB.Parameter_Values[6] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		
		/// <summary>
		/// Check_Exist_Equal_Template : 동일한 템플릿 구조, 동일한 아이템 순서로 구성된 템플릿 존재 여부 체크
		/// </summary>
		/// <param name="arg_template_treecd"></param>
		/// <param name="arg_template"></param>
		/// <param name="arg_rawmat_count"></param>
		/// <returns>not null : 기존 프로세스 Name (Nick Name) 존재
		///          null     : 동일명 없으므로 신규로 생성</returns>
		private DataTable Check_Exist_Equal_Template(string arg_template_treecd, string arg_template, string arg_rawmat_count)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.CHECK_EXIST_EQUAL_TEMPLATE";
  
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "ARG_TEMPLATE";
			MyOraDB.Parameter_Name[2] = "ARG_RAW_MAT_COUNT"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_template_treecd, " ");  
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_template, " "); 
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_rawmat_count, " "); 
			MyOraDB.Parameter_Values[3] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}


		/// <summary>
		/// Select_SBC_YIELD_TEMPLATE_COPY : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_TEMPLATE_COPY(string[] arg_parameter)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(8); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_TEMPLATE_COPY";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_YIELD_TEMP_CD";
			MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR"; 


			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = arg_parameter[0]; 
			MyOraDB.Parameter_Values[1] = arg_parameter[1]; 
			MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
			MyOraDB.Parameter_Values[3] = arg_parameter[3]; 
			MyOraDB.Parameter_Values[4] = arg_parameter[4];
			MyOraDB.Parameter_Values[5] = arg_parameter[5];  
			MyOraDB.Parameter_Values[6] = arg_parameter[6];  
			MyOraDB.Parameter_Values[7] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}




		/// <summary>
		/// Select_Yield_Value : Modify 시 채산값 조회
		/// </summary>
		/// <returns></returns>
		public DataTable Select_Yield_Value(string[] arg_parameter)
		{ 

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_VALUE";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_YIELD_TYPE"; 
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR"; 


			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			   

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




		
		/// <summary>
		/// Check_EXIST_EQUAL_SPEC : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private string Check_EXIST_EQUAL_SPEC(string arg_spec_name)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.CHECK_EXIST_EQUAL_SPEC";
  
			MyOraDB.Parameter_Name[0] = "ARG_SPEC_NAME";
			MyOraDB.Parameter_Name[1] = "ARG_UPD_USER"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR"; 


			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = arg_spec_name; 
			MyOraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;  
			MyOraDB.Parameter_Values[2] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 
		}





		/// <summary>
		/// Select_SBC_YIELD_SIZE_GROUP : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_item_cd"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_SIZE_GROUP(string arg_factory, string arg_item_cd, string arg_style_cd)
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_SIZE_GROUP";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   

			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory, " ");  
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_item_cd, " "); 
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_style_cd, " "); 
			MyOraDB.Parameter_Values[3] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}



		#endregion   

	



	}
}

