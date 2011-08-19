using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 
using C1.Win.C1FlexGrid;

namespace FlexBase.Yield
{
	public class Pop_Yield_Replace_Item : COM.PCHWinForm.Pop_Large_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		private COM.FSP fgrid_YieldValue;
		private System.Windows.Forms.Panel pnl_BB1;
		private System.Windows.Forms.Panel pnl_BB2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_SG;
		private System.Windows.Forms.Label lbl_Item;
		public System.Windows.Forms.TextBox txt_StyleName;
		public System.Windows.Forms.TextBox txt_ModelName;
		public System.Windows.Forms.TextBox txt_Gender;
		public System.Windows.Forms.TextBox txt_Presto;
		public System.Windows.Forms.TextBox txt_SG;
		public System.Windows.Forms.TextBox txt_StyleCd;
		public System.Windows.Forms.TextBox txt_ModelCd;
		public System.Windows.Forms.TextBox txt_Cmp;
		public System.Windows.Forms.TextBox txt_ItemName;
		private COM.FSP fgrid_Target;
		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Label btn_SearchItem;
		private System.Windows.Forms.CheckBox chk_WithValue;
		private System.Windows.Forms.TabControl tab_Main;
		private System.Windows.Forms.TabPage tabpg_ID;
		private System.Windows.Forms.TabPage tabpg_U;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbl_Model_ID;
		private System.Windows.Forms.Label lbl_Gender_ID;
		private System.Windows.Forms.Label lbl_Style_ID;
		private System.Windows.Forms.Label lbl_SG_ID;
		private System.Windows.Forms.Label lbl_Cmp_ID;
		private System.Windows.Forms.Label lbl_Item_ID;
		private System.Windows.Forms.Label lbl_Spec_ID;
		private System.Windows.Forms.Label lbl_Color_ID;
		public System.Windows.Forms.TextBox txt_SG_ID;
		public System.Windows.Forms.TextBox txt_Presto_ID;
		public System.Windows.Forms.TextBox txt_Gender_ID;
		public System.Windows.Forms.TextBox txt_ModelName_ID;
		public System.Windows.Forms.TextBox txt_ModelCd_ID;
		public System.Windows.Forms.TextBox txt_StyleCd_ID;
		public System.Windows.Forms.TextBox txt_Cmp_ID;
		public System.Windows.Forms.TextBox txt_ItemCd_ID;
		public System.Windows.Forms.TextBox txt_SpecCd_ID;
		public System.Windows.Forms.TextBox txt_ColorCd_ID;
		public C1.Win.C1List.C1Combo cmb_Cmp_ID;
		public System.Windows.Forms.TextBox txt_ItemName_ID;
		public System.Windows.Forms.TextBox txt_SpecName_ID;
		public System.Windows.Forms.TextBox txt_ColorName_ID;
		private System.Windows.Forms.Label btn_SearchItem_ID;
		public System.Windows.Forms.TextBox txt_Unit_ID;
		private System.Windows.Forms.CheckBox chk_Size_ID;
		public System.Windows.Forms.TextBox txt_StyleName_ID;
		private System.Windows.Forms.GroupBox groupBox_Value;
		private System.Windows.Forms.GroupBox groupBox_Target;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label lbl_YieldValue;
		private System.Windows.Forms.TextBox txt_YieldValue;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		public System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label lbl_Item1;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.Label lbl_Spec;
		public System.Windows.Forms.TextBox txt_Unit;
		public System.Windows.Forms.TextBox txt_ColorName;
		public System.Windows.Forms.TextBox txt_SpecName;
		public System.Windows.Forms.TextBox txt_ItemName1;
		public System.Windows.Forms.TextBox txt_Color;
		public System.Windows.Forms.TextBox txt_Spec;
		public System.Windows.Forms.TextBox txt_ItemCd;
		private System.Windows.Forms.CheckBox chk_Size;
		private System.ComponentModel.IContainer components = null;

		public Pop_Yield_Replace_Item()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}




		private string _Division;
		private string _Factory;
		private string _StyleCd;
		private string _StyleName;
		private string _ModelName;
		private string _SgCd;
		private string _ComponentCd;
		private string _ItemCd;
		private string _TemplateSeq;
		private string _YieldType;
		private string _Unit;
		private string _SizeYN; 
		private string _SpecCd;
		private string _ColorCd;
		private string _ItemName;
		private string _SpecName;
		private string _ColorName;
	
		
		//private string _ItemCd_T;



		public Pop_Yield_Replace_Item(string[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Division = arg_parameter[0];
			_Factory = arg_parameter[1];
			_StyleCd = arg_parameter[2];
			_StyleName = arg_parameter[3];
			_ModelName = arg_parameter[4];
			_SgCd = arg_parameter[5];
			_ComponentCd = arg_parameter[6];
			_ItemCd = arg_parameter[7]; 
			_TemplateSeq = arg_parameter[8]; 
			_YieldType = arg_parameter[9]; 
			_Unit = arg_parameter[10]; 
			_SizeYN = arg_parameter[11]; 
			_SpecCd = arg_parameter[12]; 
			_ColorCd = arg_parameter[13]; 
			_ItemName = arg_parameter[14]; 
			_SpecName = arg_parameter[15]; 
			_ColorName = arg_parameter[16]; 



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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Yield_Replace_Item));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.groupBox_Target = new System.Windows.Forms.GroupBox();
			this.fgrid_Target = new COM.FSP();
			this.tab_Main = new System.Windows.Forms.TabControl();
			this.tabpg_ID = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txt_Unit_ID = new System.Windows.Forms.TextBox();
			this.btn_SearchItem_ID = new System.Windows.Forms.Label();
			this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_ColorName_ID = new System.Windows.Forms.TextBox();
			this.txt_SpecName_ID = new System.Windows.Forms.TextBox();
			this.txt_ItemName_ID = new System.Windows.Forms.TextBox();
			this.cmb_Cmp_ID = new C1.Win.C1List.C1Combo();
			this.txt_ColorCd_ID = new System.Windows.Forms.TextBox();
			this.lbl_Color_ID = new System.Windows.Forms.Label();
			this.txt_SpecCd_ID = new System.Windows.Forms.TextBox();
			this.lbl_Spec_ID = new System.Windows.Forms.Label();
			this.txt_ItemCd_ID = new System.Windows.Forms.TextBox();
			this.lbl_Item_ID = new System.Windows.Forms.Label();
			this.txt_Cmp_ID = new System.Windows.Forms.TextBox();
			this.lbl_Cmp_ID = new System.Windows.Forms.Label();
			this.txt_SG_ID = new System.Windows.Forms.TextBox();
			this.txt_Presto_ID = new System.Windows.Forms.TextBox();
			this.txt_Gender_ID = new System.Windows.Forms.TextBox();
			this.txt_ModelName_ID = new System.Windows.Forms.TextBox();
			this.txt_StyleName_ID = new System.Windows.Forms.TextBox();
			this.txt_ModelCd_ID = new System.Windows.Forms.TextBox();
			this.lbl_Model_ID = new System.Windows.Forms.Label();
			this.lbl_Gender_ID = new System.Windows.Forms.Label();
			this.lbl_Style_ID = new System.Windows.Forms.Label();
			this.txt_StyleCd_ID = new System.Windows.Forms.TextBox();
			this.lbl_SG_ID = new System.Windows.Forms.Label();
			this.chk_Size_ID = new System.Windows.Forms.CheckBox();
			this.tabpg_U = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_SearchItem = new System.Windows.Forms.Label();
			this.txt_ItemName = new System.Windows.Forms.TextBox();
			this.txt_Cmp = new System.Windows.Forms.TextBox();
			this.txt_SG = new System.Windows.Forms.TextBox();
			this.txt_Presto = new System.Windows.Forms.TextBox();
			this.txt_Gender = new System.Windows.Forms.TextBox();
			this.txt_ModelName = new System.Windows.Forms.TextBox();
			this.txt_StyleName = new System.Windows.Forms.TextBox();
			this.txt_ModelCd = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Gender = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_SG = new System.Windows.Forms.Label();
			this.lbl_Item = new System.Windows.Forms.Label();
			this.lbl_Item1 = new System.Windows.Forms.Label();
			this.lbl_Spec = new System.Windows.Forms.Label();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.chk_Size = new System.Windows.Forms.CheckBox();
			this.txt_ItemCd = new System.Windows.Forms.TextBox();
			this.txt_Spec = new System.Windows.Forms.TextBox();
			this.txt_Color = new System.Windows.Forms.TextBox();
			this.txt_ItemName1 = new System.Windows.Forms.TextBox();
			this.txt_SpecName = new System.Windows.Forms.TextBox();
			this.txt_ColorName = new System.Windows.Forms.TextBox();
			this.txt_Unit = new System.Windows.Forms.TextBox();
			this.pnl_BB2 = new System.Windows.Forms.Panel();
			this.groupBox_Value = new System.Windows.Forms.GroupBox();
			this.fgrid_YieldValue = new COM.FSP();
			this.pnl_BB1 = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_Apply = new System.Windows.Forms.Label();
			this.chk_WithValue = new System.Windows.Forms.CheckBox();
			this.lbl_YieldValue = new System.Windows.Forms.Label();
			this.txt_YieldValue = new System.Windows.Forms.TextBox();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.groupBox_Target.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Target)).BeginInit();
			this.tab_Main.SuspendLayout();
			this.tabpg_ID.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Cmp_ID)).BeginInit();
			this.tabpg_U.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl_BB2.SuspendLayout();
			this.groupBox_Value.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).BeginInit();
			this.pnl_BB1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.SuspendLayout();
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
			this.c1ToolBar1.Visible = false;
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Text = "Replace Item";
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.groupBox_Target);
			this.pnl_B.Controls.Add(this.tab_Main);
			this.pnl_B.Controls.Add(this.pnl_BB2);
			this.pnl_B.Controls.Add(this.pnl_BB1);
			this.pnl_B.DockPadding.Bottom = 5;
			this.pnl_B.DockPadding.Left = 5;
			this.pnl_B.DockPadding.Right = 5;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(792, 480);
			this.pnl_B.TabIndex = 26;
			// 
			// groupBox_Target
			// 
			this.groupBox_Target.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_Target.Controls.Add(this.fgrid_Target);
			this.groupBox_Target.Location = new System.Drawing.Point(5, 139);
			this.groupBox_Target.Name = "groupBox_Target";
			this.groupBox_Target.Size = new System.Drawing.Size(782, 205);
			this.groupBox_Target.TabIndex = 542;
			this.groupBox_Target.TabStop = false;
			this.groupBox_Target.Text = "Target";
			// 
			// fgrid_Target
			// 
			this.fgrid_Target.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Target.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Target.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Target.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Target.Location = new System.Drawing.Point(3, 17);
			this.fgrid_Target.Name = "fgrid_Target";
			this.fgrid_Target.Size = new System.Drawing.Size(776, 185);
			this.fgrid_Target.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Target.TabIndex = 1;
			this.fgrid_Target.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Target_AfterEdit);
			// 
			// tab_Main
			// 
			this.tab_Main.Controls.Add(this.tabpg_ID);
			this.tab_Main.Controls.Add(this.tabpg_U);
			this.tab_Main.Dock = System.Windows.Forms.DockStyle.Top;
			this.tab_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tab_Main.Location = new System.Drawing.Point(5, 0);
			this.tab_Main.Multiline = true;
			this.tab_Main.Name = "tab_Main";
			this.tab_Main.Padding = new System.Drawing.Point(0, 0);
			this.tab_Main.SelectedIndex = 0;
			this.tab_Main.Size = new System.Drawing.Size(782, 136);
			this.tab_Main.TabIndex = 543;
			// 
			// tabpg_ID
			// 
			this.tabpg_ID.BackColor = System.Drawing.SystemColors.Window;
			this.tabpg_ID.Controls.Add(this.groupBox4);
			this.tabpg_ID.Location = new System.Drawing.Point(4, 23);
			this.tabpg_ID.Name = "tabpg_ID";
			this.tabpg_ID.Size = new System.Drawing.Size(774, 109);
			this.tabpg_ID.TabIndex = 0;
			this.tabpg_ID.Text = "Insert/ Delete";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.txt_Unit_ID);
			this.groupBox4.Controls.Add(this.btn_SearchItem_ID);
			this.groupBox4.Controls.Add(this.txt_ColorName_ID);
			this.groupBox4.Controls.Add(this.txt_SpecName_ID);
			this.groupBox4.Controls.Add(this.txt_ItemName_ID);
			this.groupBox4.Controls.Add(this.cmb_Cmp_ID);
			this.groupBox4.Controls.Add(this.txt_ColorCd_ID);
			this.groupBox4.Controls.Add(this.lbl_Color_ID);
			this.groupBox4.Controls.Add(this.txt_SpecCd_ID);
			this.groupBox4.Controls.Add(this.lbl_Spec_ID);
			this.groupBox4.Controls.Add(this.txt_ItemCd_ID);
			this.groupBox4.Controls.Add(this.lbl_Item_ID);
			this.groupBox4.Controls.Add(this.txt_Cmp_ID);
			this.groupBox4.Controls.Add(this.lbl_Cmp_ID);
			this.groupBox4.Controls.Add(this.txt_SG_ID);
			this.groupBox4.Controls.Add(this.txt_Presto_ID);
			this.groupBox4.Controls.Add(this.txt_Gender_ID);
			this.groupBox4.Controls.Add(this.txt_ModelName_ID);
			this.groupBox4.Controls.Add(this.txt_StyleName_ID);
			this.groupBox4.Controls.Add(this.txt_ModelCd_ID);
			this.groupBox4.Controls.Add(this.lbl_Model_ID);
			this.groupBox4.Controls.Add(this.lbl_Gender_ID);
			this.groupBox4.Controls.Add(this.lbl_Style_ID);
			this.groupBox4.Controls.Add(this.txt_StyleCd_ID);
			this.groupBox4.Controls.Add(this.lbl_SG_ID);
			this.groupBox4.Controls.Add(this.chk_Size_ID);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(774, 109);
			this.groupBox4.TabIndex = 542;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Source";
			// 
			// txt_Unit_ID
			// 
			this.txt_Unit_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Unit_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Unit_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Unit_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Unit_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Unit_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Unit_ID.Location = new System.Drawing.Point(710, 39);
			this.txt_Unit_ID.MaxLength = 10;
			this.txt_Unit_ID.Name = "txt_Unit_ID";
			this.txt_Unit_ID.ReadOnly = true;
			this.txt_Unit_ID.Size = new System.Drawing.Size(43, 21);
			this.txt_Unit_ID.TabIndex = 685;
			this.txt_Unit_ID.Text = "";
			// 
			// btn_SearchItem_ID
			// 
			this.btn_SearchItem_ID.ImageIndex = 0;
			this.btn_SearchItem_ID.ImageList = this.img_SmallButton;
			this.btn_SearchItem_ID.Location = new System.Drawing.Point(745, 83);
			this.btn_SearchItem_ID.Name = "btn_SearchItem_ID";
			this.btn_SearchItem_ID.Size = new System.Drawing.Size(21, 21);
			this.btn_SearchItem_ID.TabIndex = 684;
			this.btn_SearchItem_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_SearchItem_ID.Click += new System.EventHandler(this.btn_SearchItem_ID_Click);
			this.btn_SearchItem_ID.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_SearchItem_ID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_SearchItem_ID.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_SearchItem_ID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_ColorName_ID
			// 
			this.txt_ColorName_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ColorName_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorName_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ColorName_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ColorName_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ColorName_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ColorName_ID.Location = new System.Drawing.Point(529, 83);
			this.txt_ColorName_ID.MaxLength = 10;
			this.txt_ColorName_ID.Name = "txt_ColorName_ID";
			this.txt_ColorName_ID.ReadOnly = true;
			this.txt_ColorName_ID.Size = new System.Drawing.Size(215, 21);
			this.txt_ColorName_ID.TabIndex = 683;
			this.txt_ColorName_ID.Text = "";
			// 
			// txt_SpecName_ID
			// 
			this.txt_SpecName_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SpecName_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SpecName_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SpecName_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SpecName_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SpecName_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SpecName_ID.Location = new System.Drawing.Point(529, 61);
			this.txt_SpecName_ID.MaxLength = 10;
			this.txt_SpecName_ID.Name = "txt_SpecName_ID";
			this.txt_SpecName_ID.ReadOnly = true;
			this.txt_SpecName_ID.Size = new System.Drawing.Size(237, 21);
			this.txt_SpecName_ID.TabIndex = 682;
			this.txt_SpecName_ID.Text = "";
			// 
			// txt_ItemName_ID
			// 
			this.txt_ItemName_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemName_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemName_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemName_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ItemName_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ItemName_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ItemName_ID.Location = new System.Drawing.Point(529, 39);
			this.txt_ItemName_ID.MaxLength = 10;
			this.txt_ItemName_ID.Name = "txt_ItemName_ID";
			this.txt_ItemName_ID.ReadOnly = true;
			this.txt_ItemName_ID.Size = new System.Drawing.Size(180, 21);
			this.txt_ItemName_ID.TabIndex = 681;
			this.txt_ItemName_ID.Text = "";
			// 
			// cmb_Cmp_ID
			// 
			this.cmb_Cmp_ID.AccessibleDescription = "";
			this.cmb_Cmp_ID.AccessibleName = "";
			this.cmb_Cmp_ID.AddItemCols = 0;
			this.cmb_Cmp_ID.AddItemSeparator = ';';
			this.cmb_Cmp_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_Cmp_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Cmp_ID.Caption = "";
			this.cmb_Cmp_ID.CaptionHeight = 17;
			this.cmb_Cmp_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Cmp_ID.ColumnCaptionHeight = 18;
			this.cmb_Cmp_ID.ColumnFooterHeight = 18;
			this.cmb_Cmp_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Cmp_ID.ContentHeight = 17;
			this.cmb_Cmp_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Cmp_ID.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Cmp_ID.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Cmp_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Cmp_ID.EditorHeight = 17;
			this.cmb_Cmp_ID.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Cmp_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.cmb_Cmp_ID.GapHeight = 2;
			this.cmb_Cmp_ID.ItemHeight = 15;
			this.cmb_Cmp_ID.Location = new System.Drawing.Point(586, 17);
			this.cmb_Cmp_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_Cmp_ID.MaxDropDownItems = ((short)(5));
			this.cmb_Cmp_ID.MaxLength = 32767;
			this.cmb_Cmp_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Cmp_ID.Name = "cmb_Cmp_ID";
			this.cmb_Cmp_ID.PartialRightColumn = false;
			this.cmb_Cmp_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Cmp_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Cmp_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Cmp_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Cmp_ID.Size = new System.Drawing.Size(182, 21);
			this.cmb_Cmp_ID.TabIndex = 680;
			this.cmb_Cmp_ID.SelectedValueChanged += new System.EventHandler(this.cmb_Cmp_ID_SelectedValueChanged);
			// 
			// txt_ColorCd_ID
			// 
			this.txt_ColorCd_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ColorCd_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorCd_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ColorCd_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ColorCd_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ColorCd_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ColorCd_ID.Location = new System.Drawing.Point(485, 83);
			this.txt_ColorCd_ID.MaxLength = 10;
			this.txt_ColorCd_ID.Name = "txt_ColorCd_ID";
			this.txt_ColorCd_ID.ReadOnly = true;
			this.txt_ColorCd_ID.Size = new System.Drawing.Size(43, 21);
			this.txt_ColorCd_ID.TabIndex = 679;
			this.txt_ColorCd_ID.Text = "";
			// 
			// lbl_Color_ID
			// 
			this.lbl_Color_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Color_ID.ImageIndex = 1;
			this.lbl_Color_ID.ImageList = this.img_Label;
			this.lbl_Color_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Color_ID.Location = new System.Drawing.Point(384, 83);
			this.lbl_Color_ID.Name = "lbl_Color_ID";
			this.lbl_Color_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color_ID.TabIndex = 678;
			this.lbl_Color_ID.Text = "Color";
			this.lbl_Color_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_SpecCd_ID
			// 
			this.txt_SpecCd_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SpecCd_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SpecCd_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SpecCd_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SpecCd_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SpecCd_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SpecCd_ID.Location = new System.Drawing.Point(485, 61);
			this.txt_SpecCd_ID.MaxLength = 10;
			this.txt_SpecCd_ID.Name = "txt_SpecCd_ID";
			this.txt_SpecCd_ID.ReadOnly = true;
			this.txt_SpecCd_ID.Size = new System.Drawing.Size(43, 21);
			this.txt_SpecCd_ID.TabIndex = 677;
			this.txt_SpecCd_ID.Text = "";
			// 
			// lbl_Spec_ID
			// 
			this.lbl_Spec_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Spec_ID.ImageIndex = 1;
			this.lbl_Spec_ID.ImageList = this.img_Label;
			this.lbl_Spec_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Spec_ID.Location = new System.Drawing.Point(384, 61);
			this.lbl_Spec_ID.Name = "lbl_Spec_ID";
			this.lbl_Spec_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec_ID.TabIndex = 676;
			this.lbl_Spec_ID.Text = "Specification";
			this.lbl_Spec_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ItemCd_ID
			// 
			this.txt_ItemCd_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemCd_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemCd_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemCd_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ItemCd_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ItemCd_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ItemCd_ID.Location = new System.Drawing.Point(485, 39);
			this.txt_ItemCd_ID.MaxLength = 10;
			this.txt_ItemCd_ID.Name = "txt_ItemCd_ID";
			this.txt_ItemCd_ID.ReadOnly = true;
			this.txt_ItemCd_ID.Size = new System.Drawing.Size(43, 21);
			this.txt_ItemCd_ID.TabIndex = 675;
			this.txt_ItemCd_ID.Text = "";
			// 
			// lbl_Item_ID
			// 
			this.lbl_Item_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Item_ID.ImageIndex = 1;
			this.lbl_Item_ID.ImageList = this.img_Label;
			this.lbl_Item_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Item_ID.Location = new System.Drawing.Point(384, 39);
			this.lbl_Item_ID.Name = "lbl_Item_ID";
			this.lbl_Item_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Item_ID.TabIndex = 674;
			this.lbl_Item_ID.Text = "Item/ Unit/ Size";
			this.lbl_Item_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Cmp_ID
			// 
			this.txt_Cmp_ID.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Cmp_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Cmp_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Cmp_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Cmp_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Cmp_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Cmp_ID.Location = new System.Drawing.Point(485, 17);
			this.txt_Cmp_ID.MaxLength = 200;
			this.txt_Cmp_ID.Name = "txt_Cmp_ID";
			this.txt_Cmp_ID.TabIndex = 673;
			this.txt_Cmp_ID.Text = "";
			this.txt_Cmp_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cmp_ID_KeyUp);
			// 
			// lbl_Cmp_ID
			// 
			this.lbl_Cmp_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Cmp_ID.ImageIndex = 1;
			this.lbl_Cmp_ID.ImageList = this.img_Label;
			this.lbl_Cmp_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Cmp_ID.Location = new System.Drawing.Point(384, 17);
			this.lbl_Cmp_ID.Name = "lbl_Cmp_ID";
			this.lbl_Cmp_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Cmp_ID.TabIndex = 672;
			this.lbl_Cmp_ID.Text = "Component";
			this.lbl_Cmp_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_SG_ID
			// 
			this.txt_SG_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SG_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SG_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SG_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SG_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SG_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SG_ID.Location = new System.Drawing.Point(108, 83);
			this.txt_SG_ID.MaxLength = 10;
			this.txt_SG_ID.Name = "txt_SG_ID";
			this.txt_SG_ID.ReadOnly = true;
			this.txt_SG_ID.Size = new System.Drawing.Size(261, 21);
			this.txt_SG_ID.TabIndex = 671;
			this.txt_SG_ID.Text = "";
			// 
			// txt_Presto_ID
			// 
			this.txt_Presto_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Presto_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Presto_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Presto_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Presto_ID.Location = new System.Drawing.Point(239, 39);
			this.txt_Presto_ID.MaxLength = 10;
			this.txt_Presto_ID.Name = "txt_Presto_ID";
			this.txt_Presto_ID.ReadOnly = true;
			this.txt_Presto_ID.Size = new System.Drawing.Size(130, 21);
			this.txt_Presto_ID.TabIndex = 670;
			this.txt_Presto_ID.Text = "";
			// 
			// txt_Gender_ID
			// 
			this.txt_Gender_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gender_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gender_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Gender_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Gender_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Gender_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Gender_ID.Location = new System.Drawing.Point(108, 39);
			this.txt_Gender_ID.MaxLength = 10;
			this.txt_Gender_ID.Name = "txt_Gender_ID";
			this.txt_Gender_ID.ReadOnly = true;
			this.txt_Gender_ID.Size = new System.Drawing.Size(130, 21);
			this.txt_Gender_ID.TabIndex = 669;
			this.txt_Gender_ID.Text = "";
			// 
			// txt_ModelName_ID
			// 
			this.txt_ModelName_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelName_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelName_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ModelName_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ModelName_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ModelName_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ModelName_ID.Location = new System.Drawing.Point(189, 61);
			this.txt_ModelName_ID.MaxLength = 10;
			this.txt_ModelName_ID.Name = "txt_ModelName_ID";
			this.txt_ModelName_ID.ReadOnly = true;
			this.txt_ModelName_ID.Size = new System.Drawing.Size(180, 21);
			this.txt_ModelName_ID.TabIndex = 668;
			this.txt_ModelName_ID.Text = "";
			// 
			// txt_StyleName_ID
			// 
			this.txt_StyleName_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleName_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleName_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleName_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_StyleName_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_StyleName_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleName_ID.Location = new System.Drawing.Point(189, 17);
			this.txt_StyleName_ID.MaxLength = 10;
			this.txt_StyleName_ID.Name = "txt_StyleName_ID";
			this.txt_StyleName_ID.ReadOnly = true;
			this.txt_StyleName_ID.Size = new System.Drawing.Size(180, 21);
			this.txt_StyleName_ID.TabIndex = 667;
			this.txt_StyleName_ID.Text = "";
			// 
			// txt_ModelCd_ID
			// 
			this.txt_ModelCd_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelCd_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCd_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ModelCd_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ModelCd_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ModelCd_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ModelCd_ID.Location = new System.Drawing.Point(108, 61);
			this.txt_ModelCd_ID.MaxLength = 10;
			this.txt_ModelCd_ID.Name = "txt_ModelCd_ID";
			this.txt_ModelCd_ID.ReadOnly = true;
			this.txt_ModelCd_ID.Size = new System.Drawing.Size(80, 21);
			this.txt_ModelCd_ID.TabIndex = 666;
			this.txt_ModelCd_ID.Text = "";
			// 
			// lbl_Model_ID
			// 
			this.lbl_Model_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Model_ID.ImageIndex = 0;
			this.lbl_Model_ID.ImageList = this.img_Label;
			this.lbl_Model_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Model_ID.Location = new System.Drawing.Point(7, 61);
			this.lbl_Model_ID.Name = "lbl_Model_ID";
			this.lbl_Model_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model_ID.TabIndex = 662;
			this.lbl_Model_ID.Text = "Model";
			this.lbl_Model_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Gender_ID
			// 
			this.lbl_Gender_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Gender_ID.ImageIndex = 0;
			this.lbl_Gender_ID.ImageList = this.img_Label;
			this.lbl_Gender_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Gender_ID.Location = new System.Drawing.Point(7, 39);
			this.lbl_Gender_ID.Name = "lbl_Gender_ID";
			this.lbl_Gender_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender_ID.TabIndex = 661;
			this.lbl_Gender_ID.Text = "Gender/ Presto";
			this.lbl_Gender_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style_ID
			// 
			this.lbl_Style_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Style_ID.ImageIndex = 0;
			this.lbl_Style_ID.ImageList = this.img_Label;
			this.lbl_Style_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Style_ID.Location = new System.Drawing.Point(7, 17);
			this.lbl_Style_ID.Name = "lbl_Style_ID";
			this.lbl_Style_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_ID.TabIndex = 660;
			this.lbl_Style_ID.Text = "Style";
			this.lbl_Style_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_StyleCd_ID
			// 
			this.txt_StyleCd_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleCd_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_StyleCd_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_StyleCd_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd_ID.Location = new System.Drawing.Point(108, 17);
			this.txt_StyleCd_ID.MaxLength = 10;
			this.txt_StyleCd_ID.Name = "txt_StyleCd_ID";
			this.txt_StyleCd_ID.ReadOnly = true;
			this.txt_StyleCd_ID.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd_ID.TabIndex = 659;
			this.txt_StyleCd_ID.Text = "";
			// 
			// lbl_SG_ID
			// 
			this.lbl_SG_ID.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_SG_ID.ImageIndex = 0;
			this.lbl_SG_ID.ImageList = this.img_Label;
			this.lbl_SG_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_SG_ID.Location = new System.Drawing.Point(7, 83);
			this.lbl_SG_ID.Name = "lbl_SG_ID";
			this.lbl_SG_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_SG_ID.TabIndex = 663;
			this.lbl_SG_ID.Text = "Semigood";
			this.lbl_SG_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_Size_ID
			// 
			this.chk_Size_ID.Enabled = false;
			this.chk_Size_ID.Location = new System.Drawing.Point(754, 39);
			this.chk_Size_ID.Name = "chk_Size_ID";
			this.chk_Size_ID.Size = new System.Drawing.Size(18, 21);
			this.chk_Size_ID.TabIndex = 2;
			// 
			// tabpg_U
			// 
			this.tabpg_U.BackColor = System.Drawing.SystemColors.Window;
			this.tabpg_U.Controls.Add(this.groupBox1);
			this.tabpg_U.Location = new System.Drawing.Point(4, 23);
			this.tabpg_U.Name = "tabpg_U";
			this.tabpg_U.Size = new System.Drawing.Size(774, 109);
			this.tabpg_U.TabIndex = 1;
			this.tabpg_U.Text = "Modify";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btn_SearchItem);
			this.groupBox1.Controls.Add(this.txt_ItemName);
			this.groupBox1.Controls.Add(this.txt_Cmp);
			this.groupBox1.Controls.Add(this.txt_SG);
			this.groupBox1.Controls.Add(this.txt_Presto);
			this.groupBox1.Controls.Add(this.txt_Gender);
			this.groupBox1.Controls.Add(this.txt_ModelName);
			this.groupBox1.Controls.Add(this.txt_StyleName);
			this.groupBox1.Controls.Add(this.txt_ModelCd);
			this.groupBox1.Controls.Add(this.lbl_Model);
			this.groupBox1.Controls.Add(this.lbl_Gender);
			this.groupBox1.Controls.Add(this.lbl_Style);
			this.groupBox1.Controls.Add(this.txt_StyleCd);
			this.groupBox1.Controls.Add(this.lbl_SG);
			this.groupBox1.Controls.Add(this.lbl_Item);
			this.groupBox1.Controls.Add(this.lbl_Item1);
			this.groupBox1.Controls.Add(this.lbl_Spec);
			this.groupBox1.Controls.Add(this.lbl_Color);
			this.groupBox1.Controls.Add(this.chk_Size);
			this.groupBox1.Controls.Add(this.txt_ItemCd);
			this.groupBox1.Controls.Add(this.txt_Spec);
			this.groupBox1.Controls.Add(this.txt_Color);
			this.groupBox1.Controls.Add(this.txt_ItemName1);
			this.groupBox1.Controls.Add(this.txt_SpecName);
			this.groupBox1.Controls.Add(this.txt_ColorName);
			this.groupBox1.Controls.Add(this.txt_Unit);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 109);
			this.groupBox1.TabIndex = 541;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// btn_SearchItem
			// 
			this.btn_SearchItem.ImageIndex = 0;
			this.btn_SearchItem.ImageList = this.img_SmallButton;
			this.btn_SearchItem.Location = new System.Drawing.Point(745, 83);
			this.btn_SearchItem.Name = "btn_SearchItem";
			this.btn_SearchItem.Size = new System.Drawing.Size(21, 21);
			this.btn_SearchItem.TabIndex = 679;
			this.btn_SearchItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_SearchItem.Click += new System.EventHandler(this.btn_SearchItem_Click);
			this.btn_SearchItem.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_SearchItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_SearchItem.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_SearchItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_ItemName
			// 
			this.txt_ItemName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ItemName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ItemName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ItemName.Location = new System.Drawing.Point(485, 17);
			this.txt_ItemName.MaxLength = 10;
			this.txt_ItemName.Name = "txt_ItemName";
			this.txt_ItemName.ReadOnly = true;
			this.txt_ItemName.Size = new System.Drawing.Size(282, 21);
			this.txt_ItemName.TabIndex = 674;
			this.txt_ItemName.Text = "";
			// 
			// txt_Cmp
			// 
			this.txt_Cmp.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Cmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Cmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Cmp.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Cmp.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Cmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Cmp.Location = new System.Drawing.Point(239, 83);
			this.txt_Cmp.MaxLength = 10;
			this.txt_Cmp.Name = "txt_Cmp";
			this.txt_Cmp.ReadOnly = true;
			this.txt_Cmp.Size = new System.Drawing.Size(130, 21);
			this.txt_Cmp.TabIndex = 673;
			this.txt_Cmp.Text = "";
			// 
			// txt_SG
			// 
			this.txt_SG.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SG.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SG.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SG.Location = new System.Drawing.Point(108, 83);
			this.txt_SG.MaxLength = 10;
			this.txt_SG.Name = "txt_SG";
			this.txt_SG.ReadOnly = true;
			this.txt_SG.Size = new System.Drawing.Size(130, 21);
			this.txt_SG.TabIndex = 671;
			this.txt_SG.Text = "";
			// 
			// txt_Presto
			// 
			this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Presto.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Presto.Location = new System.Drawing.Point(239, 39);
			this.txt_Presto.MaxLength = 10;
			this.txt_Presto.Name = "txt_Presto";
			this.txt_Presto.ReadOnly = true;
			this.txt_Presto.Size = new System.Drawing.Size(130, 21);
			this.txt_Presto.TabIndex = 670;
			this.txt_Presto.Text = "";
			// 
			// txt_Gender
			// 
			this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Gender.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Gender.Location = new System.Drawing.Point(108, 39);
			this.txt_Gender.MaxLength = 10;
			this.txt_Gender.Name = "txt_Gender";
			this.txt_Gender.ReadOnly = true;
			this.txt_Gender.Size = new System.Drawing.Size(130, 21);
			this.txt_Gender.TabIndex = 669;
			this.txt_Gender.Text = "";
			// 
			// txt_ModelName
			// 
			this.txt_ModelName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ModelName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ModelName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ModelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ModelName.Location = new System.Drawing.Point(189, 61);
			this.txt_ModelName.MaxLength = 10;
			this.txt_ModelName.Name = "txt_ModelName";
			this.txt_ModelName.ReadOnly = true;
			this.txt_ModelName.Size = new System.Drawing.Size(180, 21);
			this.txt_ModelName.TabIndex = 668;
			this.txt_ModelName.Text = "";
			// 
			// txt_StyleName
			// 
			this.txt_StyleName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_StyleName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_StyleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleName.Location = new System.Drawing.Point(189, 17);
			this.txt_StyleName.MaxLength = 10;
			this.txt_StyleName.Name = "txt_StyleName";
			this.txt_StyleName.ReadOnly = true;
			this.txt_StyleName.Size = new System.Drawing.Size(180, 21);
			this.txt_StyleName.TabIndex = 667;
			this.txt_StyleName.Text = "";
			// 
			// txt_ModelCd
			// 
			this.txt_ModelCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ModelCd.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ModelCd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ModelCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ModelCd.Location = new System.Drawing.Point(108, 61);
			this.txt_ModelCd.MaxLength = 10;
			this.txt_ModelCd.Name = "txt_ModelCd";
			this.txt_ModelCd.ReadOnly = true;
			this.txt_ModelCd.Size = new System.Drawing.Size(80, 21);
			this.txt_ModelCd.TabIndex = 666;
			this.txt_ModelCd.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Model.Location = new System.Drawing.Point(7, 61);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 662;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Gender
			// 
			this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Gender.ImageIndex = 0;
			this.lbl_Gender.ImageList = this.img_Label;
			this.lbl_Gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Gender.Location = new System.Drawing.Point(7, 39);
			this.lbl_Gender.Name = "lbl_Gender";
			this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender.TabIndex = 661;
			this.lbl_Gender.Text = "Gender/ Presto";
			this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Style.Location = new System.Drawing.Point(7, 17);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 660;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleCd.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(108, 17);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 659;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_SG
			// 
			this.lbl_SG.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_SG.ImageIndex = 0;
			this.lbl_SG.ImageList = this.img_Label;
			this.lbl_SG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_SG.Location = new System.Drawing.Point(7, 83);
			this.lbl_SG.Name = "lbl_SG";
			this.lbl_SG.Size = new System.Drawing.Size(100, 21);
			this.lbl_SG.TabIndex = 663;
			this.lbl_SG.Text = "SG/ Component";
			this.lbl_SG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Item
			// 
			this.lbl_Item.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Item.ImageIndex = 0;
			this.lbl_Item.ImageList = this.img_Label;
			this.lbl_Item.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Item.Location = new System.Drawing.Point(384, 17);
			this.lbl_Item.Name = "lbl_Item";
			this.lbl_Item.Size = new System.Drawing.Size(100, 21);
			this.lbl_Item.TabIndex = 665;
			this.lbl_Item.Text = "Item (Source)";
			this.lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Item1
			// 
			this.lbl_Item1.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Item1.ImageIndex = 1;
			this.lbl_Item1.ImageList = this.img_Label;
			this.lbl_Item1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Item1.Location = new System.Drawing.Point(384, 39);
			this.lbl_Item1.Name = "lbl_Item1";
			this.lbl_Item1.Size = new System.Drawing.Size(100, 21);
			this.lbl_Item1.TabIndex = 687;
			this.lbl_Item1.Text = "Item/ Unit/ Size";
			this.lbl_Item1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Spec
			// 
			this.lbl_Spec.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Spec.ImageIndex = 1;
			this.lbl_Spec.ImageList = this.img_Label;
			this.lbl_Spec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Spec.Location = new System.Drawing.Point(384, 61);
			this.lbl_Spec.Name = "lbl_Spec";
			this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec.TabIndex = 689;
			this.lbl_Spec.Text = "Specification";
			this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Color
			// 
			this.lbl_Color.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Color.ImageIndex = 1;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Color.Location = new System.Drawing.Point(384, 83);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 691;
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_Size
			// 
			this.chk_Size.Enabled = false;
			this.chk_Size.Location = new System.Drawing.Point(754, 39);
			this.chk_Size.Name = "chk_Size";
			this.chk_Size.Size = new System.Drawing.Size(18, 21);
			this.chk_Size.TabIndex = 686;
			// 
			// txt_ItemCd
			// 
			this.txt_ItemCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemCd.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ItemCd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ItemCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ItemCd.Location = new System.Drawing.Point(485, 39);
			this.txt_ItemCd.MaxLength = 10;
			this.txt_ItemCd.Name = "txt_ItemCd";
			this.txt_ItemCd.ReadOnly = true;
			this.txt_ItemCd.Size = new System.Drawing.Size(43, 21);
			this.txt_ItemCd.TabIndex = 688;
			this.txt_ItemCd.Text = "";
			// 
			// txt_Spec
			// 
			this.txt_Spec.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Spec.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Spec.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Spec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Spec.Location = new System.Drawing.Point(485, 61);
			this.txt_Spec.MaxLength = 10;
			this.txt_Spec.Name = "txt_Spec";
			this.txt_Spec.ReadOnly = true;
			this.txt_Spec.Size = new System.Drawing.Size(43, 21);
			this.txt_Spec.TabIndex = 690;
			this.txt_Spec.Text = "";
			// 
			// txt_Color
			// 
			this.txt_Color.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Color.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Color.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Color.Location = new System.Drawing.Point(485, 83);
			this.txt_Color.MaxLength = 10;
			this.txt_Color.Name = "txt_Color";
			this.txt_Color.ReadOnly = true;
			this.txt_Color.Size = new System.Drawing.Size(43, 21);
			this.txt_Color.TabIndex = 692;
			this.txt_Color.Text = "";
			// 
			// txt_ItemName1
			// 
			this.txt_ItemName1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemName1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemName1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ItemName1.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ItemName1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ItemName1.Location = new System.Drawing.Point(529, 39);
			this.txt_ItemName1.MaxLength = 10;
			this.txt_ItemName1.Name = "txt_ItemName1";
			this.txt_ItemName1.ReadOnly = true;
			this.txt_ItemName1.Size = new System.Drawing.Size(180, 21);
			this.txt_ItemName1.TabIndex = 693;
			this.txt_ItemName1.Text = "";
			// 
			// txt_SpecName
			// 
			this.txt_SpecName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SpecName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_SpecName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SpecName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SpecName.Location = new System.Drawing.Point(529, 61);
			this.txt_SpecName.MaxLength = 10;
			this.txt_SpecName.Name = "txt_SpecName";
			this.txt_SpecName.ReadOnly = true;
			this.txt_SpecName.Size = new System.Drawing.Size(237, 21);
			this.txt_SpecName.TabIndex = 694;
			this.txt_SpecName.Text = "";
			// 
			// txt_ColorName
			// 
			this.txt_ColorName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ColorName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_ColorName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_ColorName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_ColorName.Location = new System.Drawing.Point(529, 83);
			this.txt_ColorName.MaxLength = 10;
			this.txt_ColorName.Name = "txt_ColorName";
			this.txt_ColorName.ReadOnly = true;
			this.txt_ColorName.Size = new System.Drawing.Size(215, 21);
			this.txt_ColorName.TabIndex = 695;
			this.txt_ColorName.Text = "";
			// 
			// txt_Unit
			// 
			this.txt_Unit.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Unit.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Unit.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Unit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Unit.Location = new System.Drawing.Point(710, 39);
			this.txt_Unit.MaxLength = 10;
			this.txt_Unit.Name = "txt_Unit";
			this.txt_Unit.ReadOnly = true;
			this.txt_Unit.Size = new System.Drawing.Size(43, 21);
			this.txt_Unit.TabIndex = 696;
			this.txt_Unit.Text = "";
			// 
			// pnl_BB2
			// 
			this.pnl_BB2.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BB2.Controls.Add(this.groupBox_Value);
			this.pnl_BB2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB2.DockPadding.Top = 5;
			this.pnl_BB2.Font = new System.Drawing.Font("굴림", 9F);
			this.pnl_BB2.Location = new System.Drawing.Point(5, 343);
			this.pnl_BB2.Name = "pnl_BB2";
			this.pnl_BB2.Size = new System.Drawing.Size(782, 104);
			this.pnl_BB2.TabIndex = 1;
			// 
			// groupBox_Value
			// 
			this.groupBox_Value.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_Value.Controls.Add(this.fgrid_YieldValue);
			this.groupBox_Value.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_Value.Location = new System.Drawing.Point(0, 5);
			this.groupBox_Value.Name = "groupBox_Value";
			this.groupBox_Value.Size = new System.Drawing.Size(782, 99);
			this.groupBox_Value.TabIndex = 540;
			this.groupBox_Value.TabStop = false;
			this.groupBox_Value.Text = "Yield Value";
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
			this.fgrid_YieldValue.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_YieldValue.TabIndex = 0;
			this.fgrid_YieldValue.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_YieldValue_AfterResizeColumn);
			this.fgrid_YieldValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_YieldValue_MouseUp);
			this.fgrid_YieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_YieldValue_KeyDown);
			// 
			// pnl_BB1
			// 
			this.pnl_BB1.Controls.Add(this.btn_Cancel);
			this.pnl_BB1.Controls.Add(this.btn_Apply);
			this.pnl_BB1.Controls.Add(this.chk_WithValue);
			this.pnl_BB1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB1.DockPadding.Top = 5;
			this.pnl_BB1.Location = new System.Drawing.Point(5, 447);
			this.pnl_BB1.Name = "pnl_BB1";
			this.pnl_BB1.Size = new System.Drawing.Size(782, 28);
			this.pnl_BB1.TabIndex = 0;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(699, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_Cancel.TabIndex = 635;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(618, 3);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 634;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// chk_WithValue
			// 
			this.chk_WithValue.Font = new System.Drawing.Font("Verdana", 9F);
			this.chk_WithValue.Location = new System.Drawing.Point(488, 5);
			this.chk_WithValue.Name = "chk_WithValue";
			this.chk_WithValue.Size = new System.Drawing.Size(128, 21);
			this.chk_WithValue.TabIndex = 1;
			this.chk_WithValue.Text = "With Yield Value";
			// 
			// lbl_YieldValue
			// 
			this.lbl_YieldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_YieldValue.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_YieldValue.ImageIndex = 0;
			this.lbl_YieldValue.ImageList = this.img_Label;
			this.lbl_YieldValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_YieldValue.Location = new System.Drawing.Point(553, 408);
			this.lbl_YieldValue.Name = "lbl_YieldValue";
			this.lbl_YieldValue.Size = new System.Drawing.Size(100, 21);
			this.lbl_YieldValue.TabIndex = 661;
			this.lbl_YieldValue.Text = "All Size Value";
			this.lbl_YieldValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_YieldValue
			// 
			this.txt_YieldValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_YieldValue.BackColor = System.Drawing.SystemColors.Window;
			this.txt_YieldValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_YieldValue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_YieldValue.Location = new System.Drawing.Point(654, 408);
			this.txt_YieldValue.MaxLength = 18;
			this.txt_YieldValue.Name = "txt_YieldValue";
			this.txt_YieldValue.Size = new System.Drawing.Size(128, 21);
			this.txt_YieldValue.TabIndex = 660;
			this.txt_YieldValue.Text = "";
			this.txt_YieldValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_YieldValue_KeyUp);
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
			this.stbar.TabIndex = 46;
			// 
			// Pop_Yield_Replace_Item
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.lbl_YieldValue);
			this.Controls.Add(this.txt_YieldValue);
			this.Controls.Add(this.stbar);
			this.Controls.Add(this.pnl_B);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Pop_Yield_Replace_Item";
			this.Text = "Replace Item";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.txt_YieldValue, 0);
			this.Controls.SetChildIndex(this.lbl_YieldValue, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.groupBox_Target.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Target)).EndInit();
			this.tab_Main.ResumeLayout(false);
			this.tabpg_ID.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Cmp_ID)).EndInit();
			this.tabpg_U.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl_BB2.ResumeLayout(false);
			this.groupBox_Value.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).EndInit();
			this.pnl_BB1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  



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
 

		// 사이즈 자재인 경우 Specification Code 별 색깔 구분
		private Color _SizeColor1 = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2 = ClassLib.ComVar.ClrSel_Yellow;
		private Color _CurrentColor;


		
		//BOM template 중 raw material 만 있는 구조 코드
		private string _OnlyRawMat_TemplateCd = "00005";

		//Raw Material Code Value
		private string _RawMatCd = "02J13000"; 


		//specification division 중 사이즈 specification 구분자
		private string _SizeSpecDiv = "1"; 
		// 사이즈 자재인 경우 Specification 처리
		private string _SizeSpecCd = "00000";


		private bool _Checkin_Cancel = false;
		
		// checkin/out
		public static bool _CheckInFail = false;
		public static bool _CheckOutFail = false;
		public static string _CheckInSeq = "1";



		#endregion	   

		#region 멤버 메서드

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{

			try
			{ 

				switch(_Division)
				{
					case "I":
						this.Text = "Insert Item";
						lbl_MainTitle.Text = "Insert Item"; 

						tab_Main.SelectedTab = tabpg_ID; 

						fgrid_Target.Set_Grid("SBC_YIELD_ADD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);   

				
						break;

					case "D":
						this.Text = "Delete Item";
						lbl_MainTitle.Text = "Delete Item"; 

						tab_Main.SelectedTab = tabpg_ID; 

						fgrid_Target.Set_Grid("SBC_YIELD_REPLACE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);    

				
						break;

					case "U":
						this.Text = "Replace Item";
						lbl_MainTitle.Text = "Replace Item"; 

						tab_Main.SelectedTab = tabpg_U; 

						fgrid_Target.Set_Grid("SBC_YIELD_REPLACE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);   

				
						break;
				}

				
 


				//---------------------------------------------------------------------------------------------------------------------
				// 그리드 설정
				//---------------------------------------------------------------------------------------------------------------------
				 
				fgrid_YieldValue.Set_Grid("SBC_YIELD_VALUE", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_YieldValue.SelectionMode = SelectionModeEnum.CellRange; 
				//---------------------------------------------------------------------------------------------------------------------


				//---------------------------------------------------------------------------------------------------------------------
				// 사이즈 컬럼 표시
				//---------------------------------------------------------------------------------------------------------------------
				fgrid_YieldValue.Display_Size_ColHead(_Factory, _StyleCd, 60, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START); 
				//---------------------------------------------------------------------------------------------------------------------


				//---------------------------------------------------------------------------------------------------------------------
				// 채산값 입력 그리드 기본 행 추가 (E 채산, M 채산, Sepcification 행)
				Add_fgrid_YieldValue_Default_Row();
				//---------------------------------------------------------------------------------------------------------------------
  

				//--------------------------------------------------------------------------------------------------------------------- 
				// 데이터 표시 
				switch(_Division)
				{
					case "I": 
						Display_Source_Target_I(); 

						chk_WithValue.Visible = false;

						break;

					case "D": 
						txt_Cmp_ID.ReadOnly = true;
						txt_Cmp_ID.BackColor = ClassLib.ComVar.ClrReadOnly;
						cmb_Cmp_ID.Enabled = false;
						btn_SearchItem_ID.Enabled = false;

						groupBox_Target.Size = new Size(782, 309);
						groupBox_Value.Visible = false;

						lbl_YieldValue.Visible = false;
						txt_YieldValue.Visible = false;

						chk_WithValue.Visible = false;

						
						Display_Source_Target_D();

						break;

					case "U":
						Display_Source_Target_U();
						Display_Yield_Value();

						chk_WithValue.Visible = true;

						break;
				} 
				//---------------------------------------------------------------------------------------------------------------------


				//--------------------------------------------------------------------------------------------------------------------- 
				c1ToolBar1.Visible = false; 

				 

				// check in/out cancel 
				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(_Factory, ClassLib.ComVar.CxYieldCheckinCancel);

				if(dt_ret != null && dt_ret.Rows.Count > 0)
				{
					_Checkin_Cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
				}
				else
				{
					_Checkin_Cancel = false;
				}

				dt_ret.Dispose();

				//---------------------------------------------------------------------------------------------------------------------

				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
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




		#region Display_Source_Target_U


		/// <summary>
		/// Display_Source_Target_U : 데이터 표시
		/// </summary>
		private void Display_Source_Target_U()
		{


			DataSet ds_ret;
			DataTable dt_head;
			DataTable dt_tail;
			//DataTable dt_value;
 

			ds_ret = Select_SBC_YIELD_REPLACE_ITEM(_Factory, _StyleCd, _SgCd, _ComponentCd, _TemplateSeq, _ItemCd, _SpecCd, _ColorCd, _YieldType);

			dt_head = ds_ret.Tables[0];
			dt_tail = ds_ret.Tables[1];
			//dt_value = ds_ret.Tables[2];

			Display_Head(dt_head);
			Display_Tail(dt_tail);
			//Display_Value(dt_value);


		}

 
		private void Display_Head(DataTable arg_dt)
		{
			 

			// header
			txt_StyleCd.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxSTYLE_CD].ToString();
			txt_StyleName.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxSTYLE_NAME].ToString();
			txt_Gender.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxGENDER].ToString();
			txt_Presto.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxPRESTO_YN].ToString();
			txt_ModelCd.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxMODEL_CD].ToString();
			txt_ModelName.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxMODEL_NAME].ToString();
			txt_SG.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxSEMI_GOOD_CD].ToString(); 
			txt_Cmp.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxCOMPONENT_NAME].ToString();
			txt_ItemName.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxITEM_NAME1].ToString();
			 


		}


		private void Display_Tail(DataTable arg_dt)
		{
 

			// tail
			fgrid_Target.Rows.Count = fgrid_Target.Rows.Fixed; 
			fgrid_Target.Cols.Count = arg_dt.Columns.Count + 1;
  
			//All Select Row
			fgrid_Target.Rows.Add(); 
			fgrid_Target.Rows[fgrid_Target.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;


			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Target.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Target.Rows.Count, 1);
				fgrid_Target[i + fgrid_Target.Rows.Fixed + 1, 0] = ""; 
 
			}  
				 
			fgrid_Target.AutoSizeCols(); 


		}


		private void Display_Value(DataTable arg_dt)
		{

//			for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
//			{
//				fgrid_Target.Cols.Add();
//
//				fgrid_Target[1, fgrid_Target.Cols.Count - 1] = fgrid_YieldValue[1, i].ToString();
//
//				//fgrid_Target.Cols[fgrid_Target.Cols.Count - 1].Visible = false;
//			}
//
//
//
//
//			for(int i = fgrid_Target.Rows.Fixed + 1; i < fgrid_Target.Rows.Count; i++)
//			{
//				 
//
//				// 채산값, Soec 표시
//
//				string style_cd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString();
//				string item_cd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxITEM_CD + 1].ToString();
//				string spec_cd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSPEC_CD + 1].ToString();
//				string color_cd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCOLOR_CD + 1].ToString(); 
//
//
//				string condition = "";
//
//				condition = "STYLE_CD = '" + style_cd + "' "
//					+ "AND ITEM_CD = '" + item_cd + "' ";  
//
//				if(_SizeYN == "N")
//				{
//					condition += "AND SPEC_CD = '" + spec_cd + "' ";
//
//				} 
//
//				condition +=  "AND COLOR_CD = '" + color_cd + "' ";
//
//
//				DataRow[] findrow = arg_dt.Select(condition);  
//
//
//				CellRange cr;
//
//				for(int j = 0; j < findrow.Length; j++)
//				{
//					
//					fgrid_Target[i, j + (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCS_SIZE_START + 1] 
//						= findrow[j].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_VALUE.IxYIELD_VALUE].ToString();
//
//
//					cr = fgrid_Target.GetCellRange(i, j + (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCS_SIZE_START + 1);
//					cr.UserData = findrow[j].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_VALUE.IxSPEC_CD].ToString();
//
//				} // end for j 
//
//
//			} // end for i


		}


		/// <summary>
		/// Display_Yield_Value : 
		/// </summary>
		private void Display_Yield_Value()
		{
 

			string[] parameter = new string[] { _Factory, _StyleCd, _SgCd, _ComponentCd, _TemplateSeq, _YieldType}; 
			
			Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF();
			
			DataTable dt_ret = pop_form.Select_Yield_Value(parameter);
 

			int cs_size_start = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; 

			for(int i = cs_size_start; i < fgrid_YieldValue.Cols.Count; i++)
			{
				fgrid_YieldValue[_Row_YieldValue, i] = dt_ret.Rows[i - cs_size_start].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxYIELD_VALUE].ToString(); 
				fgrid_YieldValue[_Row_SpecCd, i] = dt_ret.Rows[i - cs_size_start].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxSPEC_CD].ToString(); 
				fgrid_YieldValue[_Row_SpecName, i] = dt_ret.Rows[i - cs_size_start].ItemArray[(int)ClassLib.TBSBC_YIELD_VALUE.IxSPEC_NAME].ToString();  

			} // end for i  



			//SPEC CODE 별 색깔 표시 
			Disaply_Yield_Color();




		}

		#endregion

		#region Display_Source_Target_I

		/// <summary>
		/// Display_Source_Target_I : 데이터 표시
		/// </summary>
		private void Display_Source_Target_I()
		{


			DataSet ds_ret;
			DataTable dt_head;
			DataTable dt_tail; 
 

			ds_ret = Select_SBC_YIELD_ADD_ITEM(_Factory, _StyleCd);

			dt_head = ds_ret.Tables[0];
			dt_tail = ds_ret.Tables[1]; 

			Display_Head_I(dt_head);
			Display_Tail_I(dt_tail); 

		}

 
		private void Display_Head_I(DataTable arg_dt)
		{
			 

			// header
			txt_StyleCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxSTYLE_CD].ToString();
			txt_StyleName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxSTYLE_NAME].ToString();
			txt_Gender_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxGENDER].ToString();
			txt_Presto_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxPRESTO_YN].ToString();
			txt_ModelCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxMODEL_CD].ToString();
			txt_ModelName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_HEAD.IxMODEL_NAME].ToString();
			txt_SG_ID.Text = _SgCd;  
			 


		}


		private void Display_Tail_I(DataTable arg_dt)
		{
 

			// tail
			fgrid_Target.Rows.Count = fgrid_Target.Rows.Fixed; 
			fgrid_Target.Cols.Count = arg_dt.Columns.Count + 1;
  
			//All Select Row
			fgrid_Target.Rows.Add(); 
			fgrid_Target.Rows[fgrid_Target.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;


			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Target.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Target.Rows.Count, 1);
				fgrid_Target[i + fgrid_Target.Rows.Fixed + 1, 0] = ""; 
 
			}  
				 
			fgrid_Target.AutoSizeCols(); 


		}

		#endregion 

		#region Display_Source_Target_D


		private void Display_Source_Target_D()
		{
			DataSet ds_ret;
			DataTable dt_head;
			DataTable dt_tail; 
 

			ds_ret = Select_SBC_YIELD_DELETE_ITEM(_Factory, 
				_StyleCd, 
				_SgCd, 
				_ComponentCd, 
				_TemplateSeq,
				_ItemCd,
				_SpecCd,
				_ColorCd);

			dt_head = ds_ret.Tables[0];
			dt_tail = ds_ret.Tables[1]; 

			Display_Head_D(dt_head);
			Display_Tail_I(dt_tail); 

		}

 
		private void Display_Head_D(DataTable arg_dt)
		{
			 

			// header
			txt_StyleCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxSTYLE_CD].ToString();
			txt_StyleName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxSTYLE_NAME].ToString();
			txt_Gender_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxGENDER].ToString();
			txt_Presto_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxPRESTO_YN].ToString();
			txt_ModelCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxMODEL_CD].ToString();
			txt_ModelName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxMODEL_NAME].ToString();
			txt_SG_ID.Text = _SgCd;  
			txt_Cmp_ID.Text = _ComponentCd;

			//component combo list
			Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF();
			DataTable dt_ret = pop_form.Select_SBC_COMPONENT_COMBO(txt_Cmp_ID.Text.Trim() );

			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Cmp_ID, 0, 1, false, 0, 210);
			dt_ret.Dispose();

			cmb_Cmp_ID.SelectedValue = _ComponentCd;
			txt_ItemCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxITEM_CD].ToString();
			txt_ItemName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxITEM_NAME1].ToString();
			txt_Unit_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxMNG_UNIT].ToString();
			chk_Size_ID.Checked = Convert.ToBoolean(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxSIZE_YN].ToString());
			txt_SpecCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxSPEC_CD].ToString();
			txt_SpecName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxSPEC_NAME].ToString();
			txt_ColorCd_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxCOLOR_CD].ToString();
			txt_ColorName_ID.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBC_YIELD_DELETE_ITEM_HEAD.IxCOLOR_NAME].ToString();
 

		}

 


		#endregion


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

 

		#region Apply_I

		/// <summary>
		/// Apply_U : 
		/// </summary>
		private void Apply_I()
		{
 
			DialogResult dr; 
			dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);  
			if(dr == DialogResult.No) return;   



			//-------------------------------------------------------------------------------------------------------------------------
			// 필수 항목 체크
			//-------------------------------------------------------------------------------------------------------------------------
			if(cmb_Cmp_ID.SelectedIndex == -1) 
			{
				ClassLib.ComFunction.User_Message("Select Component", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if(txt_ItemCd_ID.Text.Trim().Equals("") || txt_SpecCd_ID.Text.Trim().Equals("") || txt_ColorCd_ID.Text.Trim().Equals("") )  
			{
				ClassLib.ComFunction.User_Message("Select Item/ Specification/ Color", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			bool check_flag = Check_All_Setting_YieldValue();
			if(! check_flag) return;
			//-------------------------------------------------------------------------------------------------------------------------
 

			string division = "";
			string factory = "";
			string stylecd = "";
			string checkuser = ""; 
			string remarks = "";


			// 한 Row 씩 처리
			for(int i = fgrid_Target.Rows.Fixed + 1; i < fgrid_Target.Rows.Count; i++)
			{  
					 
				if(Convert.ToBoolean(fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxCHECK_FLAG + 1].ToString() ) )
				{ 
 
					
					try
					{

						//------------------------------------------------------------------------------------------------------------------------
						// style의 check in/out 상태 조회
						//------------------------------------------------------------------------------------------------------------------------
						division = "I"; // In
						factory = _Factory;
						stylecd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
						checkuser = ClassLib.ComVar.This_User; 
						remarks = "material all insert";

						#region Check in 1)
 

						//					// 1) job factory Webservice 로 변경
						//					// 2) job factory Checkin table insert 처리
						//					// 3) user factory Webservice 로 변경
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//
						//
						//					// 1) job factory Webservice 로 변경  
						//					string websvc_factory = "";
						//
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					}
						//
						//			
						//			
						//
						//					// 2) job factory Checkin table insert 처리
						//					bool checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//
						//					// 3) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//
						//
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
						//					
						//					 
						//
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//					checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
					

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
	
	
						//					// 1) job factory Webservice 로 변경
						//					string websvc_factory = ""; 
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//				
						//					// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					// 3) user factory Webservice 로 변경
						//					DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "";
						//					string job_checkin_user = "";
						//
						//					if(dt_job == null)
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					}
						//					else
						//					{
						//						job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
						//						job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//			
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{ 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
						//
						//					//**********************************************//
						//					//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
						//					//**********************************************//
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//		 
						//
						//					// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//
						//			
						//					// 8) job factory Checkin table insert 처리
						//					// 9) user factory Webservice 로 변경
						//					DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory; 
						//
						//
						//					if(ds_job == null)
						//					{
						//  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//			
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공  


						#endregion

						#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	
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
	
	 
				
			
						//					// 3) user factory Webservice 로 변경 
						//					string websvc_factory = ""; 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "0";
						//					string job_checkin_user = ClassLib.ComVar.This_User.Trim();
						//
						//			
						//			 
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;  
						//
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  
						//
						//					job_checkin_user = user_checkin_user;
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{ 
						//				
						//						
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//					 
						//		 
						//					// 9) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;  
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						//
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//						
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공 
 


						#endregion


						bool checkin_ok = false;

						if(_Checkin_Cancel)   // local 만 체크
						{
							checkin_ok = Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
						}
						else  // remote, local 모두 체크
						{
							checkin_ok = Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
						}


						if(! checkin_ok) 
						{

							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
							continue;
						}


						//------------------------------------------------------------------------------------------------------------------------

 


						bool make_flag = Make_SBC_YIELD_ADD_ITEM(i); 
		
						if(!make_flag)
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Error (Make)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}

							continue;
						}



						DataSet ds_ret;
	
						ds_ret = MyOraDB.Exe_Modify_Procedure();
	
						if(ds_ret == null)  // error
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Error (Apply)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}


							continue;
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] = "Complate"; 
	
	
						} // end if MyOraDB.Exe_Modify_Procedure()


						fgrid_Target.TopRow = i;


					}
					catch
					{

						// checkout
						if( Run_Check_Out(factory, stylecd) )
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
						}


					}



				}// end if

			} // end for i
			

			

		}



		/// <summary>
		/// Check_All_Setting_YieldValue : all setting yield value check
		/// </summary>
		/// <returns></returns>
		private bool Check_All_Setting_YieldValue()
		{ 
  

			bool empty_value = false;

			for(int i = fgrid_YieldValue.Rows.Fixed; i < fgrid_YieldValue.Rows.Count; i++)
			{
				if(i != _Row_YieldValue && i != _Row_SpecCd && i != _Row_SpecName) continue;

				for(int j = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; j < fgrid_YieldValue.Cols.Count; j++)
				{
					fgrid_YieldValue[i, j] = (fgrid_YieldValue[i, j] == null) ? "" : fgrid_YieldValue[i, j].ToString();

					if(fgrid_YieldValue[i, j].ToString() == "" || fgrid_YieldValue[i, j].ToString() == "0" )
					{
						ClassLib.ComFunction.User_Message("Input Yield Value", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
						empty_value = true;
						break;
					} // end if


				} // end for j

				if(empty_value) break; 

			} // end for i 


			if(empty_value)
			{
				return false; 
			}
			else
			{
				return true; 
			}
			
			
		}


		/// <summary>
		/// Make_SBC_YIELD_ADD_ITEM : 
		/// </summary>
		/// <param name="arg_clear_flag"></param>
		/// <returns></returns>
		private bool Make_SBC_YIELD_ADD_ITEM(int arg_row)
		{
			try
			{
				 
				int col_ct = 25; 
				int save_value_ct = 0, save_info_ct = 0;  
				int para_ct = 0; 
 
				
				// from, to cs_size 선택하기 위한 비교 변수
				string before_yield = "", now_yield = "";
				int size_f = -1, size_t = -1; 
				
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.RUN_ADD_ITEM";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[2] = "ARG_YIELD_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COMPONENT_CD";
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
				MyOraDB.Parameter_Name[20] = "ARG_TEMPLATE_TREE_CD";
				MyOraDB.Parameter_Name[21] = "ARG_TEMPLATE_CD";
				MyOraDB.Parameter_Name[22] = "ARG_TEMPLATE_NAME";
				MyOraDB.Parameter_Name[23] = "ARG_SORUCE_FLAG";   // main 화면 선택 style_cd 체크 : check out 처리 하지 않기 위함
				MyOraDB.Parameter_Name[24] = "ARG_STYLE_CD_CHECKINSEQ";
 
  

				
				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}

				
				#region 저장 행 수 구하기

				 
				save_info_ct++; 


				before_yield = "";
				now_yield = "";
			
				size_f = -1;
				size_t = -1;


					
				size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; 


				if(chk_Size_ID.Checked)
				{ 

					while(true)
					{ 
					
						before_yield = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();

						for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
						{   
							now_yield = fgrid_YieldValue[_Row_SpecCd, k].ToString();

							if(before_yield == now_yield)
							{
								size_t = k;
							}
							else
							{
								break;
							} 

						} 


						save_value_ct++;



						size_f = size_t + 1;

						if(size_f == fgrid_YieldValue.Cols.Count) break;

					} // end while

					
				}
				else
				{
					

					while(true)
					{   

						before_yield = fgrid_YieldValue[_Row_YieldValue, size_f].ToString(); 

						for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
						{   
							now_yield = fgrid_YieldValue[_Row_YieldValue, k].ToString();

							if(before_yield == now_yield)
							{
								size_t = k;
							}
							else
							{
								break;
							}

						}


						save_value_ct++;



						size_f = size_t + 1;

						if(size_f == fgrid_YieldValue.Cols.Count) break;

					} // end while 

					

				} // end if(_SizeYN == "Y") 
						 
						  
		

				#endregion


				// 파라미터 값에 저장할 배열 
				// (save_info_ct * 2) : Delete 쿼리 추가
				MyOraDB.Parameter_Values  = new string[col_ct * (save_value_ct + (save_info_ct * 2) )]; 
				 
 
				

				// 각 행의 변경값 Setting  

				#region division = 'D'  (delete) 

				MyOraDB.Parameter_Values[para_ct++] = "D";
				MyOraDB.Parameter_Values[para_ct++] = txt_ModelCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = _YieldType;
				MyOraDB.Parameter_Values[para_ct++] = _Factory;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_SG_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = cmb_Cmp_ID.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = "1";   //"ARG_TEMPLATE_LEVEL"; 
				MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_ColorCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = (chk_Size_ID.Checked) ? _SizeSpecCd : txt_SpecCd_ID.Text;  // "ARG_SPEC_CD";
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
				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 

				#endregion


				before_yield = "";
				now_yield = "";
			
				size_f = -1;
				size_t = -1;


				#region division = 'V'  (value) 
					

				// 사이즈 자재일 경우에는 스펙으로 From, To 나눔
				// 사이즈 자재가 아닐 경우에는 채산값으로 From, To 나눔

				size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

				if(chk_Size_ID.Checked)
				{ 

				

					while(true)
					{
					
						before_yield = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();

						for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
						{   
							now_yield = fgrid_YieldValue[_Row_SpecCd, k].ToString();

							if(before_yield == now_yield)
							{
								size_t = k;
							}
							else
							{
								break;
							} 

						} 

					
						MyOraDB.Parameter_Values[para_ct++] = "V";
						MyOraDB.Parameter_Values[para_ct++] = txt_ModelCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = _YieldType;
						MyOraDB.Parameter_Values[para_ct++] = _Factory;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_SG_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = cmb_Cmp_ID.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = "1";   //"ARG_TEMPLATE_LEVEL"; 
						MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_ColorCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_t].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_YieldValue, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = txt_Gender_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_ID.Text; 
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = ""; 
						MyOraDB.Parameter_Values[para_ct++] = "";  
						MyOraDB.Parameter_Values[para_ct++] = "";  
						MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 


						size_f = size_t + 1;

						if(size_f == fgrid_YieldValue.Cols.Count) break;

					} // end while

					
				}
				else
				{
					

					while(true)
					{  

						before_yield = fgrid_YieldValue[_Row_YieldValue, size_f].ToString(); 

						for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
						{   
							now_yield = fgrid_YieldValue[_Row_YieldValue, k].ToString();

							if(before_yield == now_yield)
							{
								size_t = k;
							}
							else
							{
								break;
							}

						}


						
						MyOraDB.Parameter_Values[para_ct++] = "V";
						MyOraDB.Parameter_Values[para_ct++] = txt_ModelCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = _YieldType;
						MyOraDB.Parameter_Values[para_ct++] = _Factory;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_SG_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = cmb_Cmp_ID.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = "1";   //"ARG_TEMPLATE_LEVEL"; 
						MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_ColorCd_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_t].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_YieldValue, size_f].ToString();
						MyOraDB.Parameter_Values[para_ct++] = txt_Gender_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_ID.Text;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";  
						MyOraDB.Parameter_Values[para_ct++] = "";  
						MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 


						size_f = size_t + 1;

						if(size_f == fgrid_YieldValue.Cols.Count) break;

					} // end while 

					

				} // end if(chk_Size_ID.Checked)) 
			

				
				#endregion

				#region division = 'I'  (history, info) 
				

				MyOraDB.Parameter_Values[para_ct++] = "I";
				MyOraDB.Parameter_Values[para_ct++] = txt_ModelCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = _YieldType;
				MyOraDB.Parameter_Values[para_ct++] = _Factory;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_SG_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = cmb_Cmp_ID.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = "1";   //"ARG_TEMPLATE_LEVEL"; 
				MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_ColorCd_ID.Text;
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = (chk_Size_ID.Checked) ? _SizeSpecCd : txt_SpecCd_ID.Text;  // "ARG_SPEC_CD";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[para_ct++] = "I"; 
				MyOraDB.Parameter_Values[para_ct++] = "";

				MyOraDB.Parameter_Values[para_ct++] = _OnlyRawMat_TemplateCd;
				MyOraDB.Parameter_Values[para_ct++] = _RawMatCd;
				MyOraDB.Parameter_Values[para_ct++] = "";  


				if(_StyleCd.Replace("-", "")
					== fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_ADD_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "") )
				{
					MyOraDB.Parameter_Values[para_ct++] = "Y";  
				}
				else
				{
					MyOraDB.Parameter_Values[para_ct++] = "N"; 
				}


				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 


				#endregion
						 
				 
				 


				MyOraDB.Add_Modify_Parameter(true); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_ADD_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

 




		#endregion

		#region Apply_D

		/// <summary>
		/// Apply_D : 
		/// </summary>
		private void Apply_D()
		{

 
			DialogResult dr; 
			dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);  
			if(dr == DialogResult.No) return;   
 
 
			string division = "";
			string factory = "";
			string stylecd = "";
			string checkuser = ""; 
			string remarks = "";


			// 한 Row 씩 처리
			for(int i = fgrid_Target.Rows.Fixed + 1; i < fgrid_Target.Rows.Count; i++)
			{  
					 
				if(Convert.ToBoolean(fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCHECK_FLAG + 1].ToString() ) )
				{ 


					try
					{

						//------------------------------------------------------------------------------------------------------------------------
						// style의 check in/out 상태 조회
						//------------------------------------------------------------------------------------------------------------------------
 
						division = "I"; // In
						factory = _Factory;
						stylecd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
						checkuser = ClassLib.ComVar.This_User; 
						remarks = "material all delete";
 

						#region Check in 1)

					
						//					// 1) job factory Webservice 로 변경
						//					// 2) job factory Checkin table insert 처리
						//					// 3) user factory Webservice 로 변경
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//
						//
						//					// 1) job factory Webservice 로 변경  
						//					string websvc_factory = "";
						//
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					}
						//
						//			
						//			
						//
						//					// 2) job factory Checkin table insert 처리
						//					bool checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//
						//					// 3) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//
						//
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
						//					 
						//
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//					checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
 
 
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
	
	
						//					// 1) job factory Webservice 로 변경
						//					string websvc_factory = ""; 
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//				
						//					// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					// 3) user factory Webservice 로 변경
						//					DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "";
						//					string job_checkin_user = "";
						//
						//					if(dt_job == null)
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					}
						//					else
						//					{
						//						job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
						//						job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//			
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{ 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
						//
						//					//**********************************************//
						//					//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
						//					//**********************************************//
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//		 
						//
						//					// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//
						//			
						//					// 8) job factory Checkin table insert 처리
						//					// 9) user factory Webservice 로 변경
						//					DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory; 
						//
						//
						//					if(ds_job == null)
						//					{
						//  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//			
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공  


						#endregion

						#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	
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
	
	 
				
			
						//					// 3) user factory Webservice 로 변경 
						//					string websvc_factory = ""; 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "0";
						//					string job_checkin_user = ClassLib.ComVar.This_User.Trim();
						//
						//			
						//			 
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;  
						//
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  
						//
						//					job_checkin_user = user_checkin_user;
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{ 
						//				
						//						
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//					 
						//		 
						//					// 9) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;  
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						//
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//						
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공 
 


						#endregion


						bool checkin_ok = false;

						if(_Checkin_Cancel)   // local 만 체크
						{
							checkin_ok = Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
						}
						else  // remote, local 모두 체크
						{
							checkin_ok = Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
						}


						if(! checkin_ok) 
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
							continue;
						} 


						//------------------------------------------------------------------------------------------------------------------------

  

						bool make_flag = Make_SBC_YIELD_DELETE_ITEM(i); 
		
						if(!make_flag)
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Error (Make)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}

							continue;
						}



						DataSet ds_ret;
	
						ds_ret = MyOraDB.Exe_Modify_Procedure();
	
						if(ds_ret == null)  // error
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Error (Apply)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}

							continue;
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Complate"; 
	
	
						} // end if MyOraDB.Exe_Modify_Procedure()


						fgrid_Target.TopRow = i;


					}
					catch
					{

						// checkout
						if( Run_Check_Out(factory, stylecd) )
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
						}

					}


				}// end if

			} // end for i
			


 


		}




		/// <summary>
		/// Make_SBC_YIELD_DELETE_ITEM : 
		/// </summary>
		/// <returns></returns>
		private bool Make_SBC_YIELD_DELETE_ITEM(int arg_row)
		{

			try
			{
				 
				int col_ct = 12; 
				int save_row_ct = 0;    
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.RUN_DELETE_ITEM";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
				MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_FACTORY";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";   
				MyOraDB.Parameter_Name[8] = "ARG_ACTION_FLAG"; 
				MyOraDB.Parameter_Name[9] = "ARG_HISTORY_REMARKS"; 
				MyOraDB.Parameter_Name[10] = "ARG_SORUCE_FLAG";
				MyOraDB.Parameter_Name[11] = "ARG_STYLE_CD_CHECKINSEQ";
 
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}

				// 저장 행 수 구하기
				save_row_ct++; 

				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct * save_row_ct];  
				 

				// 각 행의 변경값 Setting 
				  
 
				MyOraDB.Parameter_Values[para_ct++] = _Factory;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _SgCd;
				MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString(); 
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "D";
 
				//"ARG_HISTORY_REMARKS"; -> before data
				// semigood + component + template_seq + template_level 
				MyOraDB.Parameter_Values[para_ct++] = _SgCd
					+ _ComponentCd
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString()
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();

				
				if(_StyleCd.Replace("-", "")
					== fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "") )
				{
					MyOraDB.Parameter_Values[para_ct++] = "Y";  
				}
				else
				{
					MyOraDB.Parameter_Values[para_ct++] = "N"; 
				}


				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 



				MyOraDB.Add_Modify_Parameter(true); 
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_DELETE_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}

 


		#endregion

		#region Apply_U


		/// <summary>
		/// Apply_U : 
		/// </summary>
		private void Apply_U()
		{



			//1. get next template_seq , sbc_yield_value 
			//2. sbc_yield_info

			
			DialogResult dr; 
			dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);  
			if(dr == DialogResult.No) return;   


			//-------------------------------------------------------------------------------------------------------------------------
			// 필수 항목 체크
			//-------------------------------------------------------------------------------------------------------------------------
			if(txt_ItemCd.Text.Trim().Equals("") && txt_ItemName1.Text.Trim().Equals("") )
			{
				ClassLib.ComFunction.User_Message("Select Item", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			int select_count = 0;
			
			for(int i = fgrid_Target.Rows.Fixed + 1; i < fgrid_Target.Rows.Count; i++)
			{

				if(Convert.ToBoolean(fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCHECK_FLAG + 1].ToString() ) )
				{
					select_count++;
				}

			} 

			if(select_count == 0)
			{
				ClassLib.ComFunction.User_Message("Select Target Data", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//-------------------------------------------------------------------------------------------------------------------------
 

			string division = "";
			string factory = "";
			string stylecd = "";
			string checkuser = ""; 
			string remarks = "";


			// 한 Row 씩 처리
			for(int i = fgrid_Target.Rows.Fixed + 1; i < fgrid_Target.Rows.Count; i++)
			{  
					 
				if(Convert.ToBoolean(fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCHECK_FLAG + 1].ToString() ) )
				{ 
 


					try
					{

						//------------------------------------------------------------------------------------------------------------------------
						// style의 check in/out 상태 조회
						//------------------------------------------------------------------------------------------------------------------------
						division = "I"; // In
						factory = _Factory;
						stylecd = fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
						checkuser = ClassLib.ComVar.This_User; 
						remarks = "material all modify (replace)";


						#region Check in 1) 

						//					// 1) job factory Webservice 로 변경
						//					// 2) job factory Checkin table insert 처리
						//					// 3) user factory Webservice 로 변경
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//
						//
						//					// 1) job factory Webservice 로 변경  
						//					string websvc_factory = "";
						//
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					}
						//
						//			
						//			
						//
						//					// 2) job factory Checkin table insert 처리
						//					bool checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//
						//					// 3) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//
						//
						//					// 4) 2) 성공 시 user factory Checkin table insert 처리
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					} 
						//					
						//					 
						//
						//					// 5) 4) 성공 시 최종 Checkin 성공
						//					checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser, websvc_factory);
						//
						//					if(! checkin_yn) 
						//					{
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}


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
	
	
						//					// 1) job factory Webservice 로 변경
						//					string websvc_factory = ""; 
						//			
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//				
						//					// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					// 3) user factory Webservice 로 변경
						//					DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "";
						//					string job_checkin_user = "";
						//
						//					if(dt_job == null)
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					}
						//					else
						//					{
						//						job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
						//						job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//			
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{ 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
						//
						//					//**********************************************//
						//					//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
						//					//**********************************************//
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//		 
						//
						//					// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
						//					if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
						//					{
						//						websvc_factory = factory;
						//					}
						//					else
						//					{
						//						websvc_factory = ClassLib.ComVar.DSFactory;
						//					} 
						//
						//			
						//					// 8) job factory Checkin table insert 처리
						//					// 9) user factory Webservice 로 변경
						//					DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//					websvc_factory = ClassLib.ComVar.This_Factory; 
						//
						//
						//					if(ds_job == null)
						//					{
						//  
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//			
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공  


						#endregion

						#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	
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
	
	 
				
			
						//					// 3) user factory Webservice 로 변경 
						//					string websvc_factory = ""; 
						//					websvc_factory = ClassLib.ComVar.This_Factory;
						//			
						//
						//					string job_checkin_seq = "0";
						//					string job_checkin_user = ClassLib.ComVar.This_User.Trim();
						//
						//			
						//			 
						//
						//					// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
						//					DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
						//
						//					string user_checkin_seq = "";
						//					string user_checkin_user = "";
						//
						//					if(dt_user == null)
						//					{
						// 
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue;  
						//
						//					}
						//					else
						//					{
						//						user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
						//						user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
						//					}
						//
						//
						//
						//
						//					// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  
						//
						//					job_checkin_user = user_checkin_user;
						// 
						//					if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
						//					{ 
						//				
						//						
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//
						//
						//					} 
						//
						//
						//					// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
						//					string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
						//					 
						//		 
						//					// 9) user factory Webservice 로 변경 
						//					websvc_factory = ClassLib.ComVar.This_Factory;  
						//
						//			
						//					// 10) 8) 성공 시 user factory Checkin table insert 처리 
						//					DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
						//
						//					if(ds_user == null)
						//					{
						//
						//						fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
						//						continue; 
						//						
						//
						//					}
						//
						//
						//					// 11) 10) 성공 시 최종 Checkin 성공 
 


						#endregion


						bool checkin_ok = false;

						if(_Checkin_Cancel)   // local 만 체크
						{
							checkin_ok = Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
						}
						else  // remote, local 모두 체크
						{
							checkin_ok = Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
						}


						if(! checkin_ok) 
						{

							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
							continue;
						}

						//------------------------------------------------------------------------------------------------------------------------

 



						bool make_flag = Make_SBC_YIELD_REPLACE_ITEM(i); 
		
						if(!make_flag)
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Error (Make)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}


							continue;
						}



						DataSet ds_ret;
	
						ds_ret = MyOraDB.Exe_Modify_Procedure();
	
						if(ds_ret == null)  // error
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Error (Apply)";

							// checkout
							if( Run_Check_Out(factory, stylecd) )
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
							}
							else
							{
								fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
							}

							continue;
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Complate"; 
	
	
						} // end if MyOraDB.Exe_Modify_Procedure()


						fgrid_Target.TopRow = i;


					}
					catch
					{

						// checkout
						if( Run_Check_Out(factory, stylecd) )
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out";
						}
						else
						{
							fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] += " / Check Out Fail";
						}

					}


				}// end if 

			} // end for i 
			
 

		}



		/// <summary>
		/// Make_SBC_YIELD_REPLACE_ITEM : 
		/// </summary>
		/// <returns></returns>
		private bool Make_SBC_YIELD_REPLACE_ITEM(int arg_row)
		{

			try
			{
				 
				int col_ct = 23; 
				int save_row_ct = 0;  
				int save_history_ct = 0;
				int save_delete_ct = 0;
				int para_ct = 0; 
 
				 
				// from, to cs_size 선택하기 위한 비교 변수
				string before_yield = "", now_yield = "";
				int size_f = -1, size_t = -1;

				
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.RUN_MODIFY_ITEM";

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
				MyOraDB.Parameter_Name[20] = "ARG_WORK_DIVISION";  
				MyOraDB.Parameter_Name[21] = "ARG_SORUCE_FLAG";   // main 화면 선택 style_cd 체크 : check out 처리 하지 않기 위함 
				MyOraDB.Parameter_Name[22] = "ARG_STYLE_CD_CHECKINSEQ";
 
  

				
				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}

				 

				#region 저장 행 수 구하기

				 
						
				save_history_ct++;


				if(! chk_WithValue.Checked)
				{
					save_row_ct++; 
				}
				else
				{

					save_delete_ct++;


					// 사이즈 자재일 경우에는 스펙으로 From, To 나눔
					// 사이즈 자재가 아닐 경우에는 채산값으로 From, To 나눔

					size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

					if(chk_Size.Checked)
					{ 

						while(true)
						{

							before_yield = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();

							for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
							{   
								now_yield = fgrid_YieldValue[_Row_SpecCd, k].ToString();

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

							if(size_f == fgrid_YieldValue.Cols.Count) break;

						} // end while


					}
					else
					{


						while(true)
						{  


							before_yield = fgrid_YieldValue[_Row_YieldValue, size_f].ToString();

							for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
							{   
								now_yield = fgrid_YieldValue[_Row_YieldValue, k].ToString();

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

							if(size_f == fgrid_YieldValue.Cols.Count) break;

						} // end while 



					} // end if chk_size checked



				} // end if chk_withvalue checked 
 


				#endregion


				// 파라미터 값에 저장할 배열 
				// + 1 : Delete 쿼리 추가
				MyOraDB.Parameter_Values  = new string[col_ct * (save_row_ct + save_history_ct + save_delete_ct) ];  
 
				

				#region 각 행의 변경값 Setting 
 
				if(! chk_WithValue.Checked)
				{

					MyOraDB.Parameter_Values[para_ct++] = "N";
					MyOraDB.Parameter_Values[para_ct++] = _YieldType;
					MyOraDB.Parameter_Values[para_ct++] = _Factory;
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
					MyOraDB.Parameter_Values[para_ct++] = _SgCd;
					MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();
					MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd.Text.Trim(); //"ARG_ITEM_CD";
					MyOraDB.Parameter_Values[para_ct++] = txt_Color.Text.Trim(); //"ARG_COLOR_CD"; 
					
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_FROM";
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_TO"; 
					MyOraDB.Parameter_Values[para_ct++] = txt_Spec.Text.Trim(); //"ARG_SPEC_CD"; 
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_YIELD_VALUE";
					
					MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text.Trim(); //"ARG_GENDER";
					MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text.Trim(); //"ARG_PRESTO_YN";
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory; //"ARG_UPD_FACTORY";
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; // "ARG_UPD_USER";
					MyOraDB.Parameter_Values[para_ct++] = ""; // "ARG_ACTION_FLAG"; 
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_HISTORY_REMARKS";
					MyOraDB.Parameter_Values[para_ct++] = "I"; //"ARG_WORK_DIVISION";
					MyOraDB.Parameter_Values[para_ct++] = "";
					MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 

					
				} 
				else
				{



					MyOraDB.Parameter_Values[para_ct++] = "Y";
					MyOraDB.Parameter_Values[para_ct++] = _YieldType;
					MyOraDB.Parameter_Values[para_ct++] = _Factory;
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
					MyOraDB.Parameter_Values[para_ct++] = _SgCd;
					MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
					MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();
					MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd.Text.Trim(); //"ARG_ITEM_CD";
					MyOraDB.Parameter_Values[para_ct++] = txt_Color.Text.Trim(); //"ARG_COLOR_CD"; 


					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_FROM";
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_TO"; 
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_SPEC_CD"; 
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_YIELD_VALUE";


					MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text.Trim(); //"ARG_GENDER";
					MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text.Trim(); //"ARG_PRESTO_YN";
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory; //"ARG_UPD_FACTORY";
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; // "ARG_UPD_USER";
					MyOraDB.Parameter_Values[para_ct++] = ""; // "ARG_ACTION_FLAG"; 
					MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_HISTORY_REMARKS";
					MyOraDB.Parameter_Values[para_ct++] = "D"; //"ARG_WORK_DIVISION";
					MyOraDB.Parameter_Values[para_ct++] = "";
					MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 


					// 사이즈 자재일 경우에는 스펙으로 From, To 나눔
					// 사이즈 자재가 아닐 경우에는 채산값으로 From, To 나눔

					size_f = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START;

					if(chk_Size.Checked)
					{ 

						while(true)
						{

							before_yield = fgrid_YieldValue[_Row_SpecCd, size_f].ToString();

							for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
							{   
								now_yield = fgrid_YieldValue[_Row_SpecCd, k].ToString();

								if(before_yield == now_yield)
								{
									size_t = k;
								}
								else
								{
									break;
								} 

							} 


							
							MyOraDB.Parameter_Values[para_ct++] = "Y";
							MyOraDB.Parameter_Values[para_ct++] = _YieldType;
							MyOraDB.Parameter_Values[para_ct++] = _Factory;
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
							MyOraDB.Parameter_Values[para_ct++] = _SgCd;
							MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();
							MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd.Text.Trim(); //"ARG_ITEM_CD";
							MyOraDB.Parameter_Values[para_ct++] = txt_Color.Text.Trim(); //"ARG_COLOR_CD"; 


							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_f].ToString(); //"ARG_CS_SIZE_FROM";
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_t].ToString(); //"ARG_CS_SIZE_TO"; 
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_SpecCd, size_f].ToString(); //"ARG_SPEC_CD"; 
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_YieldValue, size_f].ToString(); //"ARG_YIELD_VALUE";


							MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text.Trim(); //"ARG_GENDER";
							MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text.Trim(); //"ARG_PRESTO_YN";
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory; //"ARG_UPD_FACTORY";
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; // "ARG_UPD_USER";
							MyOraDB.Parameter_Values[para_ct++] = ""; // "ARG_ACTION_FLAG"; 
							MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_HISTORY_REMARKS";
							MyOraDB.Parameter_Values[para_ct++] = "I"; //"ARG_WORK_DIVISION";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 



							size_f = size_t + 1;

							if(size_f == fgrid_YieldValue.Cols.Count) break;

						} // end while


					}
					else
					{


						while(true)
						{  


							before_yield = fgrid_YieldValue[_Row_YieldValue, size_f].ToString();

							for(int k = size_f; k < fgrid_YieldValue.Cols.Count; k++)
							{   
								now_yield = fgrid_YieldValue[_Row_YieldValue, k].ToString();

								if(before_yield == now_yield)
								{
									size_t = k;
								}
								else
								{
									break;
								}

							}


							
							MyOraDB.Parameter_Values[para_ct++] = "Y";
							MyOraDB.Parameter_Values[para_ct++] = _YieldType;
							MyOraDB.Parameter_Values[para_ct++] = _Factory;
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
							MyOraDB.Parameter_Values[para_ct++] = _SgCd;
							MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();
							MyOraDB.Parameter_Values[para_ct++] = txt_ItemCd.Text.Trim(); //"ARG_ITEM_CD";
							MyOraDB.Parameter_Values[para_ct++] = txt_Color.Text.Trim(); //"ARG_COLOR_CD"; 


							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_f].ToString(); //"ARG_CS_SIZE_FROM";
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[1, size_t].ToString(); //"ARG_CS_SIZE_TO"; 
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_SpecCd, size_f].ToString(); //"ARG_SPEC_CD"; 
							MyOraDB.Parameter_Values[para_ct++] = fgrid_YieldValue[_Row_YieldValue, size_f].ToString(); //"ARG_YIELD_VALUE";


							MyOraDB.Parameter_Values[para_ct++] = txt_Gender.Text.Trim(); //"ARG_GENDER";
							MyOraDB.Parameter_Values[para_ct++] = txt_Presto.Text.Trim(); //"ARG_PRESTO_YN";
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory; //"ARG_UPD_FACTORY";
							MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; // "ARG_UPD_USER";
							MyOraDB.Parameter_Values[para_ct++] = ""; // "ARG_ACTION_FLAG"; 
							MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_HISTORY_REMARKS"; 
							MyOraDB.Parameter_Values[para_ct++] = "I"; //"ARG_WORK_DIVISION";
							MyOraDB.Parameter_Values[para_ct++] = "";
							MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 





							size_f = size_t + 1;

							if(size_f == fgrid_YieldValue.Cols.Count) break;

						} // end while 



					} // end if chk_size checked 


				} // end if chk_withvalue checked 




				MyOraDB.Parameter_Values[para_ct++] = "H";
				MyOraDB.Parameter_Values[para_ct++] = _YieldType;
				MyOraDB.Parameter_Values[para_ct++] = _Factory;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _SgCd;
				MyOraDB.Parameter_Values[para_ct++] = _ComponentCd;
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString();
				MyOraDB.Parameter_Values[para_ct++] = fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString();
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_ITEM_CD";
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_COLOR_CD"; 
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_FROM";
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_CS_SIZE_TO"; 
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_SPEC_CD"; 
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_YIELD_VALUE";
					
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_GENDER";
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_PRESTO_YN";
				MyOraDB.Parameter_Values[para_ct++] = ""; //"ARG_UPD_FACTORY";
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; //"ARG_UPD_USER";
				MyOraDB.Parameter_Values[para_ct++] = "U"; // "ARG_ACTION_FLAG";
					
				//"ARG_HISTORY_REMARKS"; -> before data
				// semigood + component + template_seq + template_level + item + spec + color 
				MyOraDB.Parameter_Values[para_ct++] = _SgCd + "/"
					+ _ComponentCd + "/"
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_SEQ + 1].ToString() + "/"
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxTEMPLATE_LEVEL + 1].ToString() + "/"
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxITEM_CD + 1].ToString() + "/"
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSPEC_CD + 1].ToString() + "/"
					+ fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCOLOR_CD + 1].ToString();

				MyOraDB.Parameter_Values[para_ct++] = "I"; //"ARG_WORK_DIVISION";
				

				if(_StyleCd.Replace("-", "")
					== fgrid_Target[arg_row, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTYLE_CD + 1].ToString().Replace("-", "") )
				{
					MyOraDB.Parameter_Values[para_ct++] = "Y";  
				}
				else
				{
					MyOraDB.Parameter_Values[para_ct++] = "N"; 
				}


				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq; 

 
    
				#endregion


				MyOraDB.Add_Modify_Parameter(true); 
				return true;

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Make_SBC_YIELD_REPLACE_ITEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}




		}




		#endregion 



		/// <summary>
		/// Run_Check_Out : 
		/// </summary>
		private bool Run_Check_Out(string arg_factory, string arg_style_cd)
		{
			 

			string division = "O"; // Out 
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "check out";
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Form_BC_Yield_withExcel. Save_Check_InOut(division, arg_factory, arg_style_cd, _CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{ 
				//ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;

			}
			else
			{ 
				//ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				return true;
			}



		}


		/// <summary>
		/// Run_Check_In_RemoteLocal : 정상적인 Checkin (remote, local 모두 체크)
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		public static bool Run_Check_In_RemoteLocal(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
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
				DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
		

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{  
					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue; 
					return false;
				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				}

		

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{ 
					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue;
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
					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue; 
					return false;
				} 

				if( ! user_checkin_user.Trim().Equals("") &&  ! user_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{  
					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue; 
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
				DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{

					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue; 
					return false;

				}
		

		
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

					//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
					//					continue; 
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공  
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
		public static bool Run_Check_In_Local(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
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
				DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
//					continue;  
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
			
					
//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
//					continue; 

					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

		
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

		
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

//					fgrid_Target[i, (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxSTATUS + 1] = "Check In Fail";
//					continue; 

					return false;
					

				}


				// 11) 10) 성공 시 최종 Checkin 성공 
				return true;

			}
			catch
			{
				return false;
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
				  


				int c1 = fgrid_YieldValue.Selection.c1;
				int c2 = fgrid_YieldValue.Selection.c2;

				c1 = (c1 < c2) ? c1 : c2;
				c2 = (c1 < c2) ? c2 : c1;

				if(arg_mousebutton.Equals(MouseButtons.Left) )
				{
					//if(c1 == c2) return;
				}

				if(c1 != c2)
				{


					string yield_type = _YieldType;
					string cs_size_f = fgrid_YieldValue[1, c1].ToString();
					string cs_size_t = fgrid_YieldValue[1, c2].ToString();
					string yield_value = (fgrid_YieldValue[_Row_YieldValue, c1] == null) ? "0" : fgrid_YieldValue[_Row_YieldValue, c1].ToString();
 
					//string size_yn = (_Division == "U") ? (Convert.ToBoolean(_SizeYN)) ? "Y" : "N" : (chk_Size_ID.Checked) ? "Y" : "N"; 

					string size_yn = (_Division == "U") ? _SizeYN : (chk_Size_ID.Checked) ? "Y" : "N"; 

					string yield_spec = fgrid_YieldValue[_Row_SpecCd, c1].ToString(); 

					string spec_div = "";


					if(yield_spec.Trim() == "")
					{
						spec_div = (size_yn == "Y") ? _SizeSpecDiv : txt_SpecCd_ID.Text.Substring(0, 1);
					}
					else
					{
						spec_div = yield_spec.Substring(0, 1);
					}



//					if(yield_spec.Trim() == "")
//					{
//						spec_div = (size_yn == "Y") ? _SizeSpecDiv : txt_SpecCd_ID.Text.Substring(0, 1);
//					}
//					else
//					{
//						spec_div = (size_yn == "Y") ? _SizeSpecDiv : yield_spec.Substring(0, 1);
//					}



					string spec_cd = (fgrid_YieldValue[_Row_SpecCd, c1] == null) ? "" : fgrid_YieldValue[_Row_SpecCd, c1].ToString();
 
					string[] pop_parameter = new string[] { yield_type, cs_size_f, cs_size_t, yield_value, size_yn, spec_div, spec_cd };
					//string spec_name = cs_size_f + "-" + cs_size_t;

					//FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter, spec_name);

					FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter);
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
				 

					//SPEC CODE 별 색깔 표시
					Disaply_Yield_Color();


				} 
   


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Input_YieldValue_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}





		#endregion
 
		#region 이벤트 처리

		private void fgrid_Target_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if(e.Col != (int)ClassLib.TBSBC_YIELD_REPLACE_ITEM_TAIL.IxCHECK_FLAG + 1) return;
 
				if(e.Row != fgrid_Target.Rows.Fixed) return;
 
				for(int i = e.Row + 1; i < fgrid_Target.Rows.Count; i++) 
				{ 
					fgrid_Target[i, e.Col] = fgrid_Target[e.Row, e.Col].ToString();
				}
			 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Target_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btn_Apply_Click(object sender, System.EventArgs e)
		{

			try
			{

				this.Cursor = Cursors.WaitCursor; 


				switch(_Division)
				{
					case "I": 
						Apply_I();
						break;

					case "D":
						Apply_D();
						break;

					case "U":
						Apply_U();
						break;

				}

				  
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
		
			try
			{  

				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		private void btn_SearchItem_Click(object sender, System.EventArgs e)
		{ 

			try
			{
 

				string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_ItemCd, _ItemCd);
				string item_name = ClassLib.ComFunction.Empty_TextBox(txt_ItemName1, _ItemName);  
				string spec_cd = ClassLib.ComFunction.Empty_TextBox(txt_Spec, _SpecCd);   
				string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, _SpecName);  
				string color_cd = ClassLib.ComFunction.Empty_TextBox(txt_Color, _ColorCd);  
				string color_name = ClassLib.ComFunction.Empty_TextBox(txt_ColorName, _ColorName);  
				string unit = ClassLib.ComFunction.Empty_TextBox(txt_Unit, _Unit);   
				string size_yn = (txt_ItemCd.Text.Trim() == "") ? _SizeYN : ( (chk_Size.Checked) ? "Y" : "N" );


				FlexBase.MaterialBase.Pop_Item_List pop_form 
					= new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);
				pop_form.ShowDialog();

				txt_ItemCd.Text = ClassLib.ComVar.Parameter_PopUp[0];
				txt_ItemName1.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
				txt_Spec.Text = ClassLib.ComVar.Parameter_PopUp[2];
				txt_SpecName.Text = ClassLib.ComVar.Parameter_PopUp[3]; 
				txt_Color.Text = ClassLib.ComVar.Parameter_PopUp[4];
				txt_ColorName.Text = ClassLib.ComVar.Parameter_PopUp[5]; 
				txt_Unit.Text = ClassLib.ComVar.Parameter_PopUp[6]; 
				chk_Size.Checked = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7]);


				// 신규 선택 아이템이 사이즈 아이템이 아닐 때, Spec 다시 세팅
				if( ! chk_Size.Checked )
				{
					for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
					{
						fgrid_YieldValue[_Row_SpecCd, i] = txt_Spec.Text.Trim();
						fgrid_YieldValue[_Row_SpecName, i] = txt_SpecName.Text.Trim();

					} // end for i

				} // end if



				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SearchItem_ID_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			 	
				Show_Input_YieldValue_Popup(e.Button);

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

			try
			{
			 	
				for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
				{
					fgrid_YieldValue.Cols[i].Width = fgrid_YieldValue.Cols[e.Col].Width;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_YieldValue_AfterResizeColumn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			
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
						}
						break;
				}
			}
		}


		


		private void txt_Cmp_ID_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//component combo list
				Pop_Yield_Modify_withSRF pop_form = new Pop_Yield_Modify_withSRF();
				DataTable dt_ret = pop_form.Select_SBC_COMPONENT_COMBO(txt_Cmp_ID.Text.Trim() );

				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Cmp_ID, 0, 1, false, 0, 210);
				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Cmp_ID_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		} 


		private void cmb_Cmp_ID_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				if(cmb_Cmp_ID.SelectedIndex == -1) return;  
				txt_Cmp_ID.Text = cmb_Cmp_ID.SelectedValue.ToString(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Cmp_ID_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}

		
		 

		private void btn_SearchItem_ID_Click(object sender, System.EventArgs e)
		{

			try
			{
 

				string item_cd = txt_ItemCd_ID.Text;
				string item_name = txt_ItemName_ID.Text;
				string spec_cd = txt_SpecCd_ID.Text;
				string spec_name = txt_SpecName_ID.Text;
				string color_cd = txt_ColorCd_ID.Text;
				string color_name = txt_ColorName_ID.Text;
				string unit = txt_Unit_ID.Text;
				string size_yn = (chk_Size_ID.Checked) ? "Y" : "N";


				FlexBase.MaterialBase.Pop_Item_List pop_form 
					= new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn);
				pop_form.ShowDialog();

				txt_ItemCd_ID.Text = ClassLib.ComVar.Parameter_PopUp[0];
				txt_ItemName_ID.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
				txt_SpecCd_ID.Text = ClassLib.ComVar.Parameter_PopUp[2];
				txt_SpecName_ID.Text = ClassLib.ComVar.Parameter_PopUp[3]; 
				txt_ColorCd_ID.Text = ClassLib.ComVar.Parameter_PopUp[4];
				txt_ColorName_ID.Text = ClassLib.ComVar.Parameter_PopUp[5]; 
				txt_Unit_ID.Text = ClassLib.ComVar.Parameter_PopUp[6]; 
				chk_Size_ID.Checked = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7]);


 
				for(int i = (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START; i < fgrid_YieldValue.Cols.Count; i++)
				{
					 
					// 사이즈 자재이면 spec row 초기화
					if(chk_Size_ID.Checked)
					{ 
					 
						fgrid_YieldValue[_Row_SpecCd, i] = "";
						fgrid_YieldValue[_Row_SpecName, i] = "";  

					}	
					else
					{
						fgrid_YieldValue[_Row_SpecCd, i] = txt_SpecCd_ID.Text;
						fgrid_YieldValue[_Row_SpecName, i] = txt_SpecName_ID.Text; 
					} 


				} // end for i  


 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SearchItem_ID_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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

				}  // end for i 


				//SPEC CODE 별 색깔 표시
				Disaply_Yield_Color();
 

				txt_YieldValue.Text = ""; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_YieldValue_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
		/// Select_SBC_YIELD_REPLACE_ITEM : 
		/// </summary> 
		private DataSet Select_SBC_YIELD_REPLACE_ITEM(string arg_factory, 
			string arg_style_cd,
			string arg_semi_good_cd,
			string arg_component_cd,
			string arg_template_seq,
			string arg_item_cd,
			string arg_spec_cd,
			string arg_color_cd,
			string arg_yield_type)
		{
			DataSet ds_ret;


			MyOraDB.ReDim_Parameter(6); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_REPLACE_ITEM_HEAD";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD"; 
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd;  
			MyOraDB.Parameter_Values[4] = arg_item_cd;  
			MyOraDB.Parameter_Values[5] = "";
 

			MyOraDB.Add_Select_Parameter(true); 




			MyOraDB.ReDim_Parameter(9); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_REPLACE_ITEM_TAIL";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[6] = "ARG_SPEC_CD"; 
			MyOraDB.Parameter_Name[7] = "ARG_COLOR_CD"; 
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd; 
			MyOraDB.Parameter_Values[4] = arg_template_seq;  
			MyOraDB.Parameter_Values[5] = arg_item_cd;  
			MyOraDB.Parameter_Values[6] = arg_spec_cd;
			MyOraDB.Parameter_Values[7] = arg_color_cd;
			MyOraDB.Parameter_Values[8] = "";


			MyOraDB.Add_Select_Parameter(false); 



			MyOraDB.ReDim_Parameter(8); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_REPLACE_ITEM_VALUE";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[6] = "ARG_YIELD_TYPE";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd; 
			MyOraDB.Parameter_Values[4] = arg_template_seq;  
			MyOraDB.Parameter_Values[5] = arg_item_cd;  
			MyOraDB.Parameter_Values[6] = arg_yield_type;
			MyOraDB.Parameter_Values[7] = "";


			MyOraDB.Add_Select_Parameter(false); 



			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret; 


		}

	
		/// <summary>
		/// Select_SBC_YIELD_ADD_ITEM : 
		/// </summary> 
		private DataSet Select_SBC_YIELD_ADD_ITEM(string arg_factory, string arg_style_cd)
		{
			DataSet ds_ret;


			MyOraDB.ReDim_Parameter(6); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_REPLACE_ITEM_HEAD";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD"; 
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = " ";
			MyOraDB.Parameter_Values[3] = " ";  
			MyOraDB.Parameter_Values[4] = " ";  
			MyOraDB.Parameter_Values[5] = "";
 

			MyOraDB.Add_Select_Parameter(true); 




			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_ADD_ITEM_TAIL";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;   
			MyOraDB.Parameter_Values[2] = "";
 
			MyOraDB.Add_Select_Parameter(false); 



			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret; 


		} 



		/// <summary>
		/// Select_SBC_YIELD_DELETE_ITEM : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_semi_good_cd"></param>
		/// <param name="arg_component_cd"></param>
		/// <param name="arg_template_seq"></param>
		/// <returns></returns>
		private DataSet Select_SBC_YIELD_DELETE_ITEM(string arg_factory, 
			string arg_style_cd,
			string arg_semi_good_cd,
			string arg_component_cd,
			string arg_template_seq,
			string arg_item_cd,
			string arg_spec_cd,
			string arg_color_cd)
		{

			DataSet ds_ret;


			MyOraDB.ReDim_Parameter(6); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_DELETE_ITEM_HEAD";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD"; 
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ"; 
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd;  
			MyOraDB.Parameter_Values[4] = arg_template_seq;  
			MyOraDB.Parameter_Values[5] = "";
 

			MyOraDB.Add_Select_Parameter(true); 




			MyOraDB.ReDim_Parameter(9); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_REPLACE_ITEM_TAIL";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[6] = "ARG_SPEC_CD"; 
			MyOraDB.Parameter_Name[7] = "ARG_COLOR_CD"; 
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";
   

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
   

			MyOraDB.Parameter_Values[0] = arg_factory;  
			MyOraDB.Parameter_Values[1] = arg_style_cd;  
			MyOraDB.Parameter_Values[2] = arg_semi_good_cd;
			MyOraDB.Parameter_Values[3] = arg_component_cd; 
			MyOraDB.Parameter_Values[4] = arg_template_seq;  
			MyOraDB.Parameter_Values[5] = arg_item_cd;  
			MyOraDB.Parameter_Values[6] = arg_spec_cd;
			MyOraDB.Parameter_Values[7] = arg_color_cd;
			MyOraDB.Parameter_Values[8] = "";
 
			MyOraDB.Add_Select_Parameter(false); 



			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret; 



		}

		#endregion  

		

	 


	 
	}
}

