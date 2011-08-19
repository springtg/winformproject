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
	public class Pop_FormulaMuti_Change :COM.PCHWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_Year_From;
		private System.Windows.Forms.Label lbl_Factory_From;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Label lbl_Mcs;
		private System.Windows.Forms.Label lbl_Color;
		private C1.Win.C1List.C1Combo cmb_Mcs;
		private System.Windows.Forms.TextBox txt_Mcs;
		private System.Windows.Forms.GroupBox grp_JobType;
		private System.Windows.Forms.GroupBox grp_Title;
		private System.Windows.Forms.GroupBox grp_Item;
		private C1.Win.C1List.C1Combo cmb_Season;
		private C1.Win.C1List.C1Combo cmb_Year;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.RadioButton rdo_Delete;
		private System.Windows.Forms.RadioButton rdo_Add;
		private System.Windows.Forms.RadioButton rdo_Change;
		private System.Windows.Forms.RadioButton rdo_Weight;
		private System.Windows.Forms.TextBox txt_Color_To;
		private System.Windows.Forms.TextBox txt_Spec_To;
		private System.Windows.Forms.TextBox txt_Material_To;
		private System.Windows.Forms.Label lbl_SpecColor_To;
		private System.Windows.Forms.Label lbl_Material_To;
		private System.Windows.Forms.TextBox txt_Color_From;
		private System.Windows.Forms.TextBox txt_Spec_From;
		private System.Windows.Forms.TextBox txt_Material_From;
		private System.Windows.Forms.Label lbl_SpecColor_From;
		private System.Windows.Forms.Label lbl_Material_From;
		private System.Windows.Forms.TextBox txt_Mcs_Color;
		private C1.Win.C1List.C1Combo cmb_Mcs_Color;
		private System.Windows.Forms.Label btn_Material_From;
		private System.Windows.Forms.Label btn_Material_To;
		private System.Windows.Forms.ContextMenu cmd_popmenu;
		private System.Windows.Forms.MenuItem menu_AllSelect;
		private System.Windows.Forms.MenuItem menu_AllCancel;
		private C1.Win.C1List.C1Combo cmb_Formula_Type;
		private System.Windows.Forms.Label lbl_Formula;
		private System.Windows.Forms.GroupBox groupBox3;
		public COM.FSP fgrid_Formula;
		private COM.FSP fgrid_YieldValue;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.RadioButton rdo_Yield_Weight;
		private System.ComponentModel.IContainer components = null;

		public Pop_FormulaMuti_Change()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_FormulaMuti_Change));
			this.panel2 = new System.Windows.Forms.Panel();
			this.grp_Item = new System.Windows.Forms.GroupBox();
			this.btn_Material_To = new System.Windows.Forms.Label();
			this.txt_Color_To = new System.Windows.Forms.TextBox();
			this.txt_Spec_To = new System.Windows.Forms.TextBox();
			this.txt_Material_To = new System.Windows.Forms.TextBox();
			this.lbl_SpecColor_To = new System.Windows.Forms.Label();
			this.lbl_Material_To = new System.Windows.Forms.Label();
			this.txt_Color_From = new System.Windows.Forms.TextBox();
			this.txt_Spec_From = new System.Windows.Forms.TextBox();
			this.txt_Material_From = new System.Windows.Forms.TextBox();
			this.lbl_SpecColor_From = new System.Windows.Forms.Label();
			this.lbl_Material_From = new System.Windows.Forms.Label();
			this.btn_Material_From = new System.Windows.Forms.Label();
			this.grp_JobType = new System.Windows.Forms.GroupBox();
			this.rdo_Yield_Weight = new System.Windows.Forms.RadioButton();
			this.rdo_Weight = new System.Windows.Forms.RadioButton();
			this.rdo_Delete = new System.Windows.Forms.RadioButton();
			this.rdo_Add = new System.Windows.Forms.RadioButton();
			this.rdo_Change = new System.Windows.Forms.RadioButton();
			this.grp_Title = new System.Windows.Forms.GroupBox();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.cmb_Formula_Type = new C1.Win.C1List.C1Combo();
			this.lbl_Formula = new System.Windows.Forms.Label();
			this.cmb_Mcs = new C1.Win.C1List.C1Combo();
			this.cmb_Mcs_Color = new C1.Win.C1List.C1Combo();
			this.txt_Mcs_Color = new System.Windows.Forms.TextBox();
			this.txt_Mcs = new System.Windows.Forms.TextBox();
			this.cmb_Season = new C1.Win.C1List.C1Combo();
			this.cmb_Year = new C1.Win.C1List.C1Combo();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.lbl_Mcs = new System.Windows.Forms.Label();
			this.lbl_Year_From = new System.Windows.Forms.Label();
			this.lbl_Factory_From = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.cmd_popmenu = new System.Windows.Forms.ContextMenu();
			this.menu_AllSelect = new System.Windows.Forms.MenuItem();
			this.menu_AllCancel = new System.Windows.Forms.MenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.fgrid_YieldValue = new COM.FSP();
			this.fgrid_Formula = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel2.SuspendLayout();
			this.grp_Item.SuspendLayout();
			this.grp_JobType.SuspendLayout();
			this.grp_Title.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).BeginInit();
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
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(758, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.grp_Item);
			this.panel2.Controls.Add(this.grp_JobType);
			this.panel2.Controls.Add(this.grp_Title);
			this.panel2.Controls.Add(this.pictureBox9);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Controls.Add(this.pictureBox13);
			this.panel2.Controls.Add(this.pictureBox14);
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.pictureBox16);
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(4, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(782, 169);
			this.panel2.TabIndex = 168;
			// 
			// grp_Item
			// 
			this.grp_Item.Controls.Add(this.btn_Material_To);
			this.grp_Item.Controls.Add(this.txt_Color_To);
			this.grp_Item.Controls.Add(this.txt_Spec_To);
			this.grp_Item.Controls.Add(this.txt_Material_To);
			this.grp_Item.Controls.Add(this.lbl_SpecColor_To);
			this.grp_Item.Controls.Add(this.lbl_Material_To);
			this.grp_Item.Controls.Add(this.txt_Color_From);
			this.grp_Item.Controls.Add(this.txt_Spec_From);
			this.grp_Item.Controls.Add(this.txt_Material_From);
			this.grp_Item.Controls.Add(this.lbl_SpecColor_From);
			this.grp_Item.Controls.Add(this.lbl_Material_From);
			this.grp_Item.Controls.Add(this.btn_Material_From);
			this.grp_Item.Location = new System.Drawing.Point(392, 26);
			this.grp_Item.Name = "grp_Item";
			this.grp_Item.Size = new System.Drawing.Size(380, 111);
			this.grp_Item.TabIndex = 32;
			this.grp_Item.TabStop = false;
			this.grp_Item.Text = "Item Info";
			// 
			// btn_Material_To
			// 
			this.btn_Material_To.ImageIndex = 27;
			this.btn_Material_To.ImageList = this.img_SmallButton;
			this.btn_Material_To.Location = new System.Drawing.Point(352, 85);
			this.btn_Material_To.Name = "btn_Material_To";
			this.btn_Material_To.Size = new System.Drawing.Size(21, 21);
			this.btn_Material_To.TabIndex = 670;
			this.btn_Material_To.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Material_To.Click += new System.EventHandler(this.btn_Material_To_Click);
			// 
			// txt_Color_To
			// 
			this.txt_Color_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color_To.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Color_To.Location = new System.Drawing.Point(231, 85);
			this.txt_Color_To.Name = "txt_Color_To";
			this.txt_Color_To.Size = new System.Drawing.Size(121, 21);
			this.txt_Color_To.TabIndex = 184;
			this.txt_Color_To.Text = "";
			// 
			// txt_Spec_To
			// 
			this.txt_Spec_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec_To.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Spec_To.Location = new System.Drawing.Point(109, 85);
			this.txt_Spec_To.Name = "txt_Spec_To";
			this.txt_Spec_To.Size = new System.Drawing.Size(121, 21);
			this.txt_Spec_To.TabIndex = 183;
			this.txt_Spec_To.Text = "";
			// 
			// txt_Material_To
			// 
			this.txt_Material_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Material_To.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Material_To.Location = new System.Drawing.Point(109, 61);
			this.txt_Material_To.Name = "txt_Material_To";
			this.txt_Material_To.Size = new System.Drawing.Size(265, 21);
			this.txt_Material_To.TabIndex = 182;
			this.txt_Material_To.Text = "";
			// 
			// lbl_SpecColor_To
			// 
			this.lbl_SpecColor_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SpecColor_To.ImageIndex = 2;
			this.lbl_SpecColor_To.ImageList = this.img_Label;
			this.lbl_SpecColor_To.Location = new System.Drawing.Point(7, 85);
			this.lbl_SpecColor_To.Name = "lbl_SpecColor_To";
			this.lbl_SpecColor_To.Size = new System.Drawing.Size(100, 21);
			this.lbl_SpecColor_To.TabIndex = 181;
			this.lbl_SpecColor_To.Text = "Spec/Color";
			this.lbl_SpecColor_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Material_To
			// 
			this.lbl_Material_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Material_To.ImageIndex = 2;
			this.lbl_Material_To.ImageList = this.img_Label;
			this.lbl_Material_To.Location = new System.Drawing.Point(7, 61);
			this.lbl_Material_To.Name = "lbl_Material_To";
			this.lbl_Material_To.Size = new System.Drawing.Size(100, 21);
			this.lbl_Material_To.TabIndex = 180;
			this.lbl_Material_To.Text = "Material";
			this.lbl_Material_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Color_From
			// 
			this.txt_Color_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color_From.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Color_From.Location = new System.Drawing.Point(232, 37);
			this.txt_Color_From.Name = "txt_Color_From";
			this.txt_Color_From.Size = new System.Drawing.Size(121, 21);
			this.txt_Color_From.TabIndex = 179;
			this.txt_Color_From.Text = "";
			// 
			// txt_Spec_From
			// 
			this.txt_Spec_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec_From.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Spec_From.Location = new System.Drawing.Point(110, 37);
			this.txt_Spec_From.Name = "txt_Spec_From";
			this.txt_Spec_From.Size = new System.Drawing.Size(121, 21);
			this.txt_Spec_From.TabIndex = 178;
			this.txt_Spec_From.Text = "";
			// 
			// txt_Material_From
			// 
			this.txt_Material_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Material_From.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Material_From.Location = new System.Drawing.Point(110, 14);
			this.txt_Material_From.Name = "txt_Material_From";
			this.txt_Material_From.Size = new System.Drawing.Size(265, 21);
			this.txt_Material_From.TabIndex = 177;
			this.txt_Material_From.Text = "";
			// 
			// lbl_SpecColor_From
			// 
			this.lbl_SpecColor_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SpecColor_From.ImageIndex = 1;
			this.lbl_SpecColor_From.ImageList = this.img_Label;
			this.lbl_SpecColor_From.Location = new System.Drawing.Point(8, 37);
			this.lbl_SpecColor_From.Name = "lbl_SpecColor_From";
			this.lbl_SpecColor_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_SpecColor_From.TabIndex = 172;
			this.lbl_SpecColor_From.Text = "Spec/Color";
			this.lbl_SpecColor_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Material_From
			// 
			this.lbl_Material_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Material_From.ImageIndex = 1;
			this.lbl_Material_From.ImageList = this.img_Label;
			this.lbl_Material_From.Location = new System.Drawing.Point(8, 13);
			this.lbl_Material_From.Name = "lbl_Material_From";
			this.lbl_Material_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Material_From.TabIndex = 171;
			this.lbl_Material_From.Text = "Material";
			this.lbl_Material_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Material_From
			// 
			this.btn_Material_From.ImageIndex = 27;
			this.btn_Material_From.ImageList = this.img_SmallButton;
			this.btn_Material_From.Location = new System.Drawing.Point(354, 37);
			this.btn_Material_From.Name = "btn_Material_From";
			this.btn_Material_From.Size = new System.Drawing.Size(21, 21);
			this.btn_Material_From.TabIndex = 669;
			this.btn_Material_From.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Material_From.Click += new System.EventHandler(this.btn_Material_From_Click);
			// 
			// grp_JobType
			// 
			this.grp_JobType.Controls.Add(this.rdo_Yield_Weight);
			this.grp_JobType.Controls.Add(this.rdo_Weight);
			this.grp_JobType.Controls.Add(this.rdo_Delete);
			this.grp_JobType.Controls.Add(this.rdo_Add);
			this.grp_JobType.Controls.Add(this.rdo_Change);
			this.grp_JobType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_JobType.Location = new System.Drawing.Point(392, 131);
			this.grp_JobType.Name = "grp_JobType";
			this.grp_JobType.Size = new System.Drawing.Size(380, 28);
			this.grp_JobType.TabIndex = 31;
			this.grp_JobType.TabStop = false;
			// 
			// rdo_Yield_Weight
			// 
			this.rdo_Yield_Weight.Location = new System.Drawing.Point(309, 8);
			this.rdo_Yield_Weight.Name = "rdo_Yield_Weight";
			this.rdo_Yield_Weight.Size = new System.Drawing.Size(56, 15);
			this.rdo_Yield_Weight.TabIndex = 4;
			this.rdo_Yield_Weight.Text = "Yield";
			this.rdo_Yield_Weight.Click += new System.EventHandler(this.rdo_Yield_Weight_Click);
			// 
			// rdo_Weight
			// 
			this.rdo_Weight.Location = new System.Drawing.Point(224, 9);
			this.rdo_Weight.Name = "rdo_Weight";
			this.rdo_Weight.Size = new System.Drawing.Size(72, 15);
			this.rdo_Weight.TabIndex = 3;
			this.rdo_Weight.Text = "Weight";
			this.rdo_Weight.CheckedChanged += new System.EventHandler(this.rdo_Weight_CheckedChanged);
			// 
			// rdo_Delete
			// 
			this.rdo_Delete.Location = new System.Drawing.Point(96, 9);
			this.rdo_Delete.Name = "rdo_Delete";
			this.rdo_Delete.Size = new System.Drawing.Size(70, 15);
			this.rdo_Delete.TabIndex = 2;
			this.rdo_Delete.Text = "Delete";
			this.rdo_Delete.Click += new System.EventHandler(this.rdo_Delete_Click);
			// 
			// rdo_Add
			// 
			this.rdo_Add.Location = new System.Drawing.Point(168, 9);
			this.rdo_Add.Name = "rdo_Add";
			this.rdo_Add.Size = new System.Drawing.Size(70, 15);
			this.rdo_Add.TabIndex = 1;
			this.rdo_Add.Text = "Add";
			this.rdo_Add.Click += new System.EventHandler(this.rdo_Add_Click);
			// 
			// rdo_Change
			// 
			this.rdo_Change.Location = new System.Drawing.Point(16, 9);
			this.rdo_Change.Name = "rdo_Change";
			this.rdo_Change.Size = new System.Drawing.Size(70, 15);
			this.rdo_Change.TabIndex = 0;
			this.rdo_Change.Text = "Change";
			this.rdo_Change.Click += new System.EventHandler(this.rdo_Change_Click);
			// 
			// grp_Title
			// 
			this.grp_Title.Controls.Add(this.txt_Style_Cd);
			this.grp_Title.Controls.Add(this.cmb_Formula_Type);
			this.grp_Title.Controls.Add(this.lbl_Formula);
			this.grp_Title.Controls.Add(this.cmb_Mcs);
			this.grp_Title.Controls.Add(this.cmb_Mcs_Color);
			this.grp_Title.Controls.Add(this.txt_Mcs_Color);
			this.grp_Title.Controls.Add(this.txt_Mcs);
			this.grp_Title.Controls.Add(this.cmb_Season);
			this.grp_Title.Controls.Add(this.cmb_Year);
			this.grp_Title.Controls.Add(this.cmb_Factory);
			this.grp_Title.Controls.Add(this.lbl_Color);
			this.grp_Title.Controls.Add(this.lbl_Mcs);
			this.grp_Title.Controls.Add(this.lbl_Year_From);
			this.grp_Title.Controls.Add(this.lbl_Factory_From);
			this.grp_Title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.grp_Title.Location = new System.Drawing.Point(7, 26);
			this.grp_Title.Name = "grp_Title";
			this.grp_Title.Size = new System.Drawing.Size(380, 133);
			this.grp_Title.TabIndex = 29;
			this.grp_Title.TabStop = false;
			this.grp_Title.Text = "Formula info";
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style_Cd.Location = new System.Drawing.Point(242, 14);
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.Size = new System.Drawing.Size(132, 21);
			this.txt_Style_Cd.TabIndex = 678;
			this.txt_Style_Cd.Text = "";
			// 
			// cmb_Formula_Type
			// 
			this.cmb_Formula_Type.AccessibleDescription = "";
			this.cmb_Formula_Type.AccessibleName = "";
			this.cmb_Formula_Type.AddItemCols = 0;
			this.cmb_Formula_Type.AddItemSeparator = ';';
			this.cmb_Formula_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_Formula_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Formula_Type.Caption = "";
			this.cmb_Formula_Type.CaptionHeight = 17;
			this.cmb_Formula_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Formula_Type.ColumnCaptionHeight = 18;
			this.cmb_Formula_Type.ColumnFooterHeight = 18;
			this.cmb_Formula_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Formula_Type.ContentHeight = 17;
			this.cmb_Formula_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Formula_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Formula_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Formula_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Formula_Type.EditorHeight = 17;
			this.cmb_Formula_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Formula_Type.GapHeight = 2;
			this.cmb_Formula_Type.ItemHeight = 15;
			this.cmb_Formula_Type.Location = new System.Drawing.Point(110, 105);
			this.cmb_Formula_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_Formula_Type.MaxDropDownItems = ((short)(5));
			this.cmb_Formula_Type.MaxLength = 32767;
			this.cmb_Formula_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Formula_Type.Name = "cmb_Formula_Type";
			this.cmb_Formula_Type.PartialRightColumn = false;
			this.cmb_Formula_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Formula_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Formula_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Formula_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Formula_Type.Size = new System.Drawing.Size(264, 21);
			this.cmb_Formula_Type.TabIndex = 677;
			// 
			// lbl_Formula
			// 
			this.lbl_Formula.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Formula.ImageIndex = 1;
			this.lbl_Formula.ImageList = this.img_Label;
			this.lbl_Formula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Formula.Location = new System.Drawing.Point(8, 105);
			this.lbl_Formula.Name = "lbl_Formula";
			this.lbl_Formula.Size = new System.Drawing.Size(100, 21);
			this.lbl_Formula.TabIndex = 676;
			this.lbl_Formula.Text = "Formula Div.";
			this.lbl_Formula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Mcs
			// 
			this.cmb_Mcs.AddItemCols = 0;
			this.cmb_Mcs.AddItemSeparator = ';';
			this.cmb_Mcs.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs.Caption = "";
			this.cmb_Mcs.CaptionHeight = 17;
			this.cmb_Mcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs.ColumnCaptionHeight = 18;
			this.cmb_Mcs.ColumnFooterHeight = 18;
			this.cmb_Mcs.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs.ContentHeight = 18;
			this.cmb_Mcs.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs.EditorFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs.EditorHeight = 18;
			this.cmb_Mcs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs.GapHeight = 2;
			this.cmb_Mcs.ItemHeight = 15;
			this.cmb_Mcs.Location = new System.Drawing.Point(242, 58);
			this.cmb_Mcs.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs.MaxLength = 32767;
			this.cmb_Mcs.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs.Name = "cmb_Mcs";
			this.cmb_Mcs.PartialRightColumn = false;
			this.cmb_Mcs.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9.75pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Mcs.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs.Size = new System.Drawing.Size(132, 22);
			this.cmb_Mcs.TabIndex = 178;
			this.cmb_Mcs.TextChanged += new System.EventHandler(this.cmb_Mcs_TextChanged);
			// 
			// cmb_Mcs_Color
			// 
			this.cmb_Mcs_Color.AddItemCols = 0;
			this.cmb_Mcs_Color.AddItemSeparator = ';';
			this.cmb_Mcs_Color.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Mcs_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Mcs_Color.Caption = "";
			this.cmb_Mcs_Color.CaptionHeight = 17;
			this.cmb_Mcs_Color.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Mcs_Color.ColumnCaptionHeight = 18;
			this.cmb_Mcs_Color.ColumnFooterHeight = 18;
			this.cmb_Mcs_Color.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Mcs_Color.ContentHeight = 18;
			this.cmb_Mcs_Color.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Mcs_Color.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Mcs_Color.EditorFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Mcs_Color.EditorHeight = 18;
			this.cmb_Mcs_Color.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Mcs_Color.GapHeight = 2;
			this.cmb_Mcs_Color.ItemHeight = 15;
			this.cmb_Mcs_Color.Location = new System.Drawing.Point(242, 81);
			this.cmb_Mcs_Color.MatchEntryTimeout = ((long)(2000));
			this.cmb_Mcs_Color.MaxDropDownItems = ((short)(5));
			this.cmb_Mcs_Color.MaxLength = 32767;
			this.cmb_Mcs_Color.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Mcs_Color.Name = "cmb_Mcs_Color";
			this.cmb_Mcs_Color.PartialRightColumn = false;
			this.cmb_Mcs_Color.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9.75pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Mcs_Color.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Mcs_Color.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Mcs_Color.Size = new System.Drawing.Size(132, 22);
			this.cmb_Mcs_Color.TabIndex = 181;
			this.cmb_Mcs_Color.TextChanged += new System.EventHandler(this.cmb_Mcs_Color_TextChanged);
			// 
			// txt_Mcs_Color
			// 
			this.txt_Mcs_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Color.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mcs_Color.Location = new System.Drawing.Point(110, 81);
			this.txt_Mcs_Color.Name = "txt_Mcs_Color";
			this.txt_Mcs_Color.Size = new System.Drawing.Size(131, 22);
			this.txt_Mcs_Color.TabIndex = 180;
			this.txt_Mcs_Color.Text = "";
			this.txt_Mcs_Color.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Mcs_Color_KeyUp);
			// 
			// txt_Mcs
			// 
			this.txt_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mcs.Location = new System.Drawing.Point(110, 58);
			this.txt_Mcs.Name = "txt_Mcs";
			this.txt_Mcs.Size = new System.Drawing.Size(131, 22);
			this.txt_Mcs.TabIndex = 177;
			this.txt_Mcs.Text = "";
			this.txt_Mcs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Mcs_KeyUp);
			// 
			// cmb_Season
			// 
			this.cmb_Season.AddItemCols = 0;
			this.cmb_Season.AddItemSeparator = ';';
			this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Season.Caption = "";
			this.cmb_Season.CaptionHeight = 17;
			this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Season.ColumnCaptionHeight = 18;
			this.cmb_Season.ColumnFooterHeight = 18;
			this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Season.ContentHeight = 17;
			this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Season.EditorHeight = 17;
			this.cmb_Season.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Season.GapHeight = 2;
			this.cmb_Season.ItemHeight = 15;
			this.cmb_Season.Location = new System.Drawing.Point(242, 36);
			this.cmb_Season.MatchEntryTimeout = ((long)(2000));
			this.cmb_Season.MaxDropDownItems = ((short)(5));
			this.cmb_Season.MaxLength = 32767;
			this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Season.Name = "cmb_Season";
			this.cmb_Season.PartialRightColumn = false;
			this.cmb_Season.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Season.Size = new System.Drawing.Size(132, 21);
			this.cmb_Season.TabIndex = 176;
			// 
			// cmb_Year
			// 
			this.cmb_Year.AddItemCols = 0;
			this.cmb_Year.AddItemSeparator = ';';
			this.cmb_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Year.Caption = "";
			this.cmb_Year.CaptionHeight = 17;
			this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Year.ColumnCaptionHeight = 18;
			this.cmb_Year.ColumnFooterHeight = 18;
			this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Year.ContentHeight = 17;
			this.cmb_Year.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Year.EditorHeight = 17;
			this.cmb_Year.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Year.GapHeight = 2;
			this.cmb_Year.ItemHeight = 15;
			this.cmb_Year.Location = new System.Drawing.Point(110, 36);
			this.cmb_Year.MatchEntryTimeout = ((long)(2000));
			this.cmb_Year.MaxDropDownItems = ((short)(5));
			this.cmb_Year.MaxLength = 32767;
			this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Year.Name = "cmb_Year";
			this.cmb_Year.PartialRightColumn = false;
			this.cmb_Year.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Year.Size = new System.Drawing.Size(132, 21);
			this.cmb_Year.TabIndex = 175;
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
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(110, 14);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(132, 21);
			this.cmb_Factory.TabIndex = 174;
			// 
			// lbl_Color
			// 
			this.lbl_Color.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Color.ImageIndex = 1;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.Location = new System.Drawing.Point(8, 81);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 179;
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Mcs
			// 
			this.lbl_Mcs.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs.ImageIndex = 1;
			this.lbl_Mcs.ImageList = this.img_Label;
			this.lbl_Mcs.Location = new System.Drawing.Point(8, 59);
			this.lbl_Mcs.Name = "lbl_Mcs";
			this.lbl_Mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs.TabIndex = 173;
			this.lbl_Mcs.Text = "Mcs";
			this.lbl_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Year_From
			// 
			this.lbl_Year_From.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Year_From.ImageIndex = 1;
			this.lbl_Year_From.ImageList = this.img_Label;
			this.lbl_Year_From.Location = new System.Drawing.Point(8, 36);
			this.lbl_Year_From.Name = "lbl_Year_From";
			this.lbl_Year_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year_From.TabIndex = 172;
			this.lbl_Year_From.Text = "Year/Season";
			this.lbl_Year_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory_From
			// 
			this.lbl_Factory_From.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory_From.ImageIndex = 1;
			this.lbl_Factory_From.ImageList = this.img_Label;
			this.lbl_Factory_From.Location = new System.Drawing.Point(8, 13);
			this.lbl_Factory_From.Name = "lbl_Factory_From";
			this.lbl_Factory_From.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_From.TabIndex = 171;
			this.lbl_Factory_From.Text = "Factory";
			this.lbl_Factory_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(681, 30);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(101, 131);
			this.pictureBox9.TabIndex = 26;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(766, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 32);
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(224, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(734, 32);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
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
			this.label2.TabIndex = 28;
			this.label2.Text = "      Formula";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(766, 154);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 16);
			this.pictureBox12.TabIndex = 23;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(144, 153);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(734, 18);
			this.pictureBox13.TabIndex = 24;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 154);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(168, 20);
			this.pictureBox14.TabIndex = 22;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(168, 136);
			this.pictureBox15.TabIndex = 25;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(160, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(734, 129);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// cmd_popmenu
			// 
			this.cmd_popmenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menu_AllSelect,
																						this.menu_AllCancel});
			// 
			// menu_AllSelect
			// 
			this.menu_AllSelect.Index = 0;
			this.menu_AllSelect.Text = "All Select";
			this.menu_AllSelect.Click += new System.EventHandler(this.menu_AllSelect_Click);
			// 
			// menu_AllCancel
			// 
			this.menu_AllCancel.Index = 1;
			this.menu_AllCancel.Text = "All Cancel";
			this.menu_AllCancel.Click += new System.EventHandler(this.menu_AllCancel_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.fgrid_YieldValue);
			this.groupBox3.Location = new System.Drawing.Point(8, 448);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(776, 80);
			this.groupBox3.TabIndex = 543;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Yield Value";
			// 
			// fgrid_YieldValue
			// 
			this.fgrid_YieldValue.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_YieldValue.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_YieldValue.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_YieldValue.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_YieldValue.Location = new System.Drawing.Point(8, 17);
			this.fgrid_YieldValue.Name = "fgrid_YieldValue";
			this.fgrid_YieldValue.Rows.Count = 2;
			this.fgrid_YieldValue.Size = new System.Drawing.Size(760, 58);
			this.fgrid_YieldValue.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_YieldValue.TabIndex = 0;
			this.fgrid_YieldValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_YieldValue_MouseUp);
			this.fgrid_YieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_YieldValue_KeyDown);
			// 
			// fgrid_Formula
			// 
			this.fgrid_Formula.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Formula.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Formula.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Formula.ContextMenu = this.cmd_popmenu;
			this.fgrid_Formula.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Formula.ImeMode = System.Windows.Forms.ImeMode.On;
			this.fgrid_Formula.Location = new System.Drawing.Point(6, 230);
			this.fgrid_Formula.Name = "fgrid_Formula";
			this.fgrid_Formula.Size = new System.Drawing.Size(780, 210);
			this.fgrid_Formula.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Formula.TabIndex = 544;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Apply.Location = new System.Drawing.Point(578, 536);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(100, 23);
			this.btn_Apply.TabIndex = 681;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Close.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Close.Location = new System.Drawing.Point(678, 536);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(100, 23);
			this.btn_Close.TabIndex = 680;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// Pop_FormulaMuti_Change
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.fgrid_Formula);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panel2);
			this.Name = "Pop_FormulaMuti_Change";
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.fgrid_Formula, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.grp_Item.ResumeLayout(false);
			this.grp_JobType.ResumeLayout(false);
			this.grp_Title.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs_Color)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의 

		 private COM.OraDB _MyOraDB = new COM.OraDB();

		 string  _JobFlag ="" , _JobHead          = "H", _JobTail  ="T", _JobDir="",
			     _JobFrom     = "F" ,  _JobTo = "T",
		         _ColorOldCode  = "",  _MaterialOldCode  = "", _SpecOldCode = "",
		         _ColorNewCode  = "",  _MaterialNewCode  = "", _SpecNewCode = "",
			     _SpecBase    ="00000", _BlankText="None";

		string _YieldTypeE_Desc = "Yield (E)";
		string _YieldTypeM_Desc = "Yield (M)";
		string _SpecCd_Desc = "Spec. Cd";
		string _Spec_Desc = "Spec.";	
		string _YieldType  = "E";
		string _YieldTypeE = "E";
		string _YieldTypeM = "M";
		string _Size_YN    = "N";
				
		int _Rowfixed       = 2,_ColFixed = 2;
		
		int _Row_EYield  ,  _Row_MYield    ,_Row_SpecCd   ,_Row_SpecName , _Row_YieldValue;

		bool _Checkin_Cancel = false;

		string  _remark ="Formula Muti Change";

		#region 칼라 설정

		private Color _SizeColor1    = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2    = ClassLib.ComVar.ClrSel_Yellow;
	
		#endregion

		#region 송수신 관련		
		// 체크 아웃 실패 되었을때, 다시 체크 인 표시 해 주고, 이벤트 태우지 않기 위함
		//private bool _FromCheckOut = false;

		private bool _CheckInFail = false;
		private bool _CheckOutFail = false;
		private string _CheckInSeq  ="0";
		
		
		#endregion 


		DataTable _Dt_Size_Range; 


		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{
			
			DataTable dt_list;

			//Title
			this.Text = "Formula Multi Change";
			lbl_MainTitle.Text = "   Formula Multi Change";
			ClassLib.ComFunction.SetLangDic(this);

			// 그리드 설정(TBSBC_FORMULAN_YIELD )
			fgrid_Formula.Set_Grid("SBC_FOMULAN_MUTI", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_Formula.Set_Action_Image(img_Action);
			fgrid_Formula.Cols[0].AllowEditing = false;


			
			fgrid_YieldValue.Set_Grid("SBC_YIELD_VALUE", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_YieldValue.SelectionMode = SelectionModeEnum.CellRange;


			fgrid_Formula.DragMode = DragModeEnum.Manual;//Automatic;
			fgrid_Formula.DropMode = DropModeEnum.Manual; 

			// 공장코드
			dt_list = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
			cmb_Factory.SelectedValue   =  COM.ComVar.Parameter_PopUp[0];


			
			//Year
			ClassLib.ComFunction.Set_Year(cmb_Year ,ClassLib.ComVar.ConsAll);
			cmb_Year.SelectedValue      =  COM.ComVar.Parameter_PopUp[1];
			
			// Season 
			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Season  , 1, 2,  true,64,178);
			cmb_Season.SelectedValue    =  COM.ComVar.Parameter_PopUp[2];


			// Mcs 
			dt_list =  ClassLib.ComFunction.Select_Mcs_List("","");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Mcs   , 0, 1,  true,64,178);
			cmb_Mcs.SelectedIndex  = -1;



			// Color
			dt_list = Pop_Formula_Base_Register.SelectMcsColorCode(cmb_Factory.SelectedValue.ToString(), " "," ");
			COM.ComCtl.Set_ComboList(dt_list, cmb_Mcs_Color   , 0, 1,  true,64,178);
			cmb_Mcs_Color.SelectedIndex  = -1;

			//Formula..
			dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,ClassLib.ComVar.CxFormulaDiv);
			ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Formula_Type , 1, 2, false, true);
			cmb_Formula_Type.SelectedIndex  = 0;




			txt_Style_Cd.Text   = ClassLib.ComVar.Parameter_PopUp[3];

			fgrid_YieldValue.Cols.Fixed =0;
			fgrid_YieldValue.Display_Size_ColHead(cmb_Factory.SelectedValue.ToString(), txt_Style_Cd.Text , 60, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START);
			Add_fgrid_YieldValue_Default_Row();
			//미리 0으로 설정
			for (int i  =_ColFixed;  i< fgrid_YieldValue.Cols.Count   ;i ++)
			{
				fgrid_YieldValue[_Row_YieldValue,i ] = 0;
			}
			
			cmb_Factory.Enabled  = false;
			cmb_Season.Enabled   = false;
			cmb_Year.Enabled     = false;
			txt_Style_Cd.Enabled = false;
			fgrid_YieldValue.Enabled  = false;


			rdo_Change.Checked   = false;
			rdo_Delete.Checked   = false;
			rdo_Add.Checked      = false;
			rdo_Weight.Checked   = false;
		    rdo_Yield_Weight.Checked  = false;


			_JobFlag ="";
				 
		    
			c1ToolBar1.Visible = false; 

			dt_list.Dispose();
		}


		//Check : Job Flag별 Text Box Setting 
		private void SetJobFlag()
		{
			  
			switch (_JobFlag)
			{
				case "C" :
					lbl_Factory_From.Enabled    = true;
					lbl_SpecColor_From.Enabled  = true;
					lbl_Material_To.Enabled     = true;
					lbl_SpecColor_To.Enabled    = true;
					btn_Material_From.Enabled   = true;
					btn_Material_To.Enabled     = true;

					txt_Material_From.Enabled   = true;
					txt_Spec_From.Enabled		= true;
					txt_Color_From.Enabled		= true;

					txt_Material_To.Enabled     = true;
					txt_Color_To.Enabled		= true;
					txt_Spec_To.Enabled			= true;

					lbl_Material_From.Text  ="Material";
					lbl_SpecColor_From.Text ="Spec/Color";

					lbl_Material_To.Text ="Material";
					lbl_SpecColor_To.Text  ="Spec/Color";

					fgrid_YieldValue.Enabled  = false;
					
					break;

				case "D" :
					lbl_Factory_From.Enabled    = true;
					lbl_SpecColor_From.Enabled  = true;
					lbl_Material_To.Enabled     = false;
					lbl_SpecColor_To.Enabled    = false;
					btn_Material_From.Enabled   = true;
					btn_Material_To.Enabled     = false;

					txt_Material_From.Enabled   = true;
					txt_Spec_From.Enabled		= true;
					txt_Color_From.Enabled		= true;

					txt_Material_To.Enabled     = false;
					txt_Color_To.Enabled		= false;
					txt_Spec_To.Enabled			= false;

					lbl_Material_From.Text  ="Material";
					lbl_SpecColor_From.Text ="Spec/Color";

					lbl_Material_To.Text ="";
					lbl_SpecColor_To.Text  ="Spec/Color";
					
					fgrid_YieldValue.Enabled  = false;

					break;

				case "A" :
					lbl_Factory_From.Enabled    = true;
					lbl_SpecColor_From.Enabled  = true;
					lbl_Material_To.Enabled     = true;
					lbl_SpecColor_To.Enabled    = false;
					btn_Material_From.Enabled   = true;
					btn_Material_To.Enabled     = false;

					txt_Material_From.Enabled   = true;
					txt_Spec_From.Enabled		= true;
					txt_Color_From.Enabled		= true;

					txt_Material_To.Enabled     = true;
					txt_Color_To.Enabled		= false;
					txt_Spec_To.Enabled			= false;

					lbl_Material_From.Text  ="Material";
					lbl_SpecColor_From.Text ="Spec/Color";

					lbl_Material_To.Text ="Weight";
					lbl_SpecColor_To.Text  ="Spec/Color";
					
					fgrid_YieldValue.Enabled  = false;

					break;

				case "W" :
					lbl_Factory_From.Enabled    = true;
					lbl_SpecColor_From.Enabled  = true;
					lbl_Material_To.Enabled     = true;
					lbl_SpecColor_To.Enabled    = false;
					btn_Material_From.Enabled   = true;
					btn_Material_To.Enabled     = false;

					txt_Material_From.Enabled   = true;
					txt_Spec_From.Enabled		= true;
					txt_Color_From.Enabled		= true;

					txt_Material_To.Enabled     = true;
					txt_Color_To.Enabled		= false;
					txt_Spec_To.Enabled			= false;

					lbl_Material_From.Text  ="Material";
					lbl_SpecColor_From.Text ="Spec/Color";

					lbl_Material_To.Text ="Weight";
					lbl_SpecColor_To.Text  ="Spec/Color";
					
					fgrid_YieldValue.Enabled  = false;

					break;


				case "V" :
					lbl_Factory_From.Enabled    = true;
					lbl_SpecColor_From.Enabled  = true;
					lbl_Material_To.Enabled     = true;
					lbl_SpecColor_To.Enabled    = false;
					btn_Material_From.Enabled   = true;
					btn_Material_To.Enabled     = false;

					txt_Material_From.Enabled   = false;
					txt_Spec_From.Enabled		= false;
					txt_Color_From.Enabled		= false;

					txt_Material_To.Enabled     = false;
					txt_Color_To.Enabled		= false;
					txt_Spec_To.Enabled			= false;

					lbl_Material_From.Text  ="Material";
					lbl_SpecColor_From.Text ="Spec/Color";

					lbl_Material_To.Text ="Weight";
					lbl_SpecColor_To.Text  ="Spec/Color";

					fgrid_YieldValue.Enabled  = true;

					break;

			}

			fgrid_Formula.Rows.Count    = _Rowfixed;

		}



		/// <summary>
		/// SetItem: Item Register Pop
		/// </summary>
		private void  SetItem()
		{
			try
			{   


				FlexBase.MaterialBase.Pop_Item_List  pop_Form = new  FlexBase.MaterialBase.Pop_Item_List();


				COM.ComVar.Parameter_PopUp		= new string[1];

				COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");


				//			
				//				COM.ComVar.Parameter_PopUp = new string[] 
				//						{};
							
				pop_Form.ShowDialog();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}





		/// <summary>
		/// SetValueColor:ValueColor 뿌리기
		/// </summary>
		/// <returns></returns>
		private void SetValueColor()
		{
			MakeSizeRange();

			Color _CurrentColor = ClassLib.ComVar.ClrSel_Green;
	
			//fgrid_YieldValue.Select(fgrid_YieldValue.Selection.r1, 0, fgrid_YieldValue.Selection.r1, fgrid_YieldValue.Cols.Count-1,false);

			int iStart=_ColFixed , iEnd  =fgrid_YieldValue.Cols.Count ;


			for (int i  =0 ;  i< _Dt_Size_Range.Rows.Count  ;i++)
			{
				if(_CurrentColor.Equals(_SizeColor1) )
				{
					_CurrentColor = _SizeColor2;
				}
				else
				{
					_CurrentColor = _SizeColor1;
				}

				iStart= (i==0)?_ColFixed:Convert.ToInt16(_Dt_Size_Range.Rows[i-1].ItemArray[3])+_ColFixed+1;
				iEnd  = Convert.ToInt16(_Dt_Size_Range.Rows[i].ItemArray[3])+_ColFixed;
				fgrid_YieldValue.GetCellRange(_Row_YieldValue,iStart,  _Row_YieldValue, iEnd).StyleNew.BackColor = _CurrentColor;

				//MessageBox.Show("aaa");
								
			} 
		}
		


		
		/// <summary>
		/// 채산값별 사이즈의 위치 잡기
		/// </summary>
		private void MakeSizeRange()
		{
			int iCnt  = 3, iPos = 0;  string sOldValue ="";

			_Dt_Size_Range = new DataTable("Size");  
			//DataRow datarow;

			_Dt_Size_Range.Clear();

			for(int i = 0; i <= iCnt; i++)
				_Dt_Size_Range.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

			DataRow datarow = null;

			for (int i=_ColFixed; i< fgrid_YieldValue.Cols.Count; i++)
			{ 

				if (fgrid_YieldValue[_Row_YieldValue, i] == null) return;

				if  (fgrid_YieldValue[_Row_YieldValue, i].ToString() != sOldValue)   //이전값이랑 다르면 신규 Row추가..
				{    
					datarow = _Dt_Size_Range.NewRow();

					datarow[0] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //From Size
					datarow[1] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //To Size
					datarow[2] = fgrid_YieldValue[_Row_YieldValue,i].ToString();    //Value
					datarow[3] = iPos;    //ColOrder

					sOldValue = fgrid_YieldValue[_Row_YieldValue,i].ToString();			 

					_Dt_Size_Range.Rows.Add(datarow);
				}	
				else
				{
					datarow[1] = fgrid_YieldValue[_Rowfixed-1,i].ToString();        //To Size
					datarow[3] = iPos;        //ColOrder
				}

				iPos++ ;	

			}

		}


		
		///향후 UPPER랑 분리해서 간단하게 Pop창 만들기
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
					if(c1 == c2) return;
				}

				string yield_type = _YieldType;
				string cs_size_f = fgrid_YieldValue[1, c1].ToString();
				string cs_size_t = fgrid_YieldValue[1, c2].ToString();
				string yield_value = (fgrid_YieldValue[_Row_YieldValue, c1] == null) ? "0" : fgrid_YieldValue[_Row_YieldValue, c1].ToString();

				string size_yn = _Size_YN;
				string spec_div    = _SpecBase.ToString().Substring(0,1);
				string spec_cd     = _SpecBase;
 

				string[] pop_parameter = new string[] { yield_type, cs_size_f, cs_size_t, yield_value, _Size_YN, spec_div, spec_cd };
				

				FlexBase.Yield.Pop_Yield_Value pop_form = new Pop_Yield_Value(pop_parameter);
				pop_form.ShowDialog();

				string pop_yield_value = ClassLib.ComVar.Parameter_PopUp[0];
				string pop_spec_cd = ClassLib.ComVar.Parameter_PopUp[1];
				string pop_spec_name = ClassLib.ComVar.Parameter_PopUp[2];

				//cancel 했을 경우
				if(pop_yield_value == "") return;

				//apply 했을 경우
				for(int i = c1; i <= c2; i++)
				{
					fgrid_YieldValue[_Row_EYield, i] = pop_yield_value;
					fgrid_YieldValue[_Row_MYield, i] = pop_yield_value;
					fgrid_YieldValue[_Row_SpecCd, i] = pop_spec_cd;
					fgrid_YieldValue[_Row_SpecName, i] = pop_spec_name; 
				}

				SetValueColor();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Input_YieldValue_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Check_Job: check
		/// </summary>
		private bool  Check_Job()
		{
			try
			{   

				if (fgrid_Formula.Rows.Count  <= _Rowfixed) 
				{
					ClassLib.ComFunction.User_Message("Error", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				    return false;
				}

				if (cmb_Formula_Type.SelectedIndex   == -1) 
				{
					ClassLib.ComFunction.User_Message("Error", "Formula Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}


				
				if (cmb_Mcs.SelectedIndex    == -1) 
				{
					ClassLib.ComFunction.User_Message("Error", "No Mcs ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}


				
				if (cmb_Mcs_Color.SelectedIndex    == -1) 
				{
					ClassLib.ComFunction.User_Message("Error", "No Mcs Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}


				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}		


		}


		
		/// <summary>
		/// 채산값 입력 그리드 기본 행 추가 (E 채산, M 채산, Sepcification 행)
		/// </summary>
		private void Add_fgrid_YieldValue_Default_Row()
		{
			fgrid_YieldValue.Rows.InsertRange(fgrid_YieldValue.Rows.Fixed, 4);



			_Row_EYield =fgrid_YieldValue.Rows.Fixed;
			_Row_MYield =fgrid_YieldValue.Rows.Fixed+1;
			_Row_SpecCd = fgrid_YieldValue.Rows.Fixed + 2;  
			_Row_SpecName = fgrid_YieldValue.Rows.Fixed + 3; 

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

			fgrid_YieldValue.Rows[_Row_SpecCd].Visible = false;
			fgrid_YieldValue.Rows[_Row_SpecName ].Visible = false;
		   
			fgrid_YieldValue[_Row_EYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeE_Desc;
			fgrid_YieldValue[_Row_MYield, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _YieldTypeM_Desc;
			fgrid_YieldValue[_Row_SpecCd, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _SpecCd_Desc;
			fgrid_YieldValue[_Row_SpecName, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxDESCRIPTION] = _Spec_Desc;

			fgrid_YieldValue.Cols.Fixed = _ColFixed;
		}

		
		/// <summary>
		///  DisPlayItem() : Item  Setting
		/// </summary>
		/// <returns></returns>
		private void DisPlayItem(string arg_job)
		{
			try
			{

				if (arg_job  == _JobFrom )
				{

					_ColorOldCode		   = COM.ComVar.Parameter_PopUp[4];
					_MaterialOldCode      = COM.ComVar.Parameter_PopUp[0]; 
					_SpecOldCode		   = COM.ComVar.Parameter_PopUp[2];
					txt_Material_From.Text = COM.ComVar.Parameter_PopUp[1];
					txt_Color_From.Text    = COM.ComVar.Parameter_PopUp[5];
					txt_Spec_From.Text     = COM.ComVar.Parameter_PopUp[3];
				

				}
				else
				{
					_ColorNewCode         = COM.ComVar.Parameter_PopUp[4];
					_MaterialNewCode      = COM.ComVar.Parameter_PopUp[0];
					_SpecNewCode		     = COM.ComVar.Parameter_PopUp[2];
					txt_Material_To.Text = COM.ComVar.Parameter_PopUp[1];
					txt_Color_To.Text    = COM.ComVar.Parameter_PopUp[5];
					txt_Spec_To.Text     = COM.ComVar.Parameter_PopUp[3];
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "DisPlayItem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	
		/// <summary>
		///  DisPlayGrid() : Formula Display
		/// </summary>
		/// <returns></returns>
		private void DisPlayGrid(DataTable arg_dt)
		{

			fgrid_Formula.Rows.Count = fgrid_Formula.Rows.Fixed;  
  
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_Formula.AddItem(arg_dt.Rows[i].ItemArray,fgrid_Formula.Rows.Count, 1);
				fgrid_Formula[fgrid_Formula.Rows.Count - 1, 0] = ""; 

				fgrid_Formula.GetCellRange(i+fgrid_Formula.Rows.Fixed, (int)ClassLib.TBSBC_FOMULAN_MUTI.IxMODEL_CD).StyleNew.BackColor =  ClassLib.ComVar.ClrSel_Green;
				fgrid_Formula.GetCellRange(i+fgrid_Formula.Rows.Fixed, (int)ClassLib.TBSBC_FOMULAN_MUTI.IxSTYLE_CD).StyleNew.BackColor =  ClassLib.ComVar.ClrSel_Yellow;

			} 


			fgrid_Formula.AllowMerging = AllowMergingEnum.Free;
			fgrid_Formula.Cols[ (int)ClassLib.TBSBC_FOMULAN_MUTI.IxFLAG].AllowMerging = false;
			fgrid_Formula.Cols[ (int)ClassLib.TBSBC_FOMULAN_MUTI.IxJOB_YN].AllowMerging = false;
			

			//fgrid_Formula.AutoSizeCols();

		}


		/// <summary>
		///  Delete_Material() : Delete_Material
		/// </summary>
		/// <returns></returns>
//		private void Delete_Material()
//		{
//
//
//
//		}


		
		
		





		#endregion
		
		#region 이벤트

		#region 버튼이벤트

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			
		}


		private void btn_Material_From_Click(object sender, System.EventArgs e)
		{
			
			SetItem();   //miyoung.kim 

			DisPlayItem(_JobFrom);

		}

		private void btn_Material_To_Click(object sender, System.EventArgs e)
		{
			SetItem();

			DisPlayItem(_JobTo);
		}



		private void Run_Check_In(string arg_division , string arg_factory, string arg_style,  string arg_user, string arg_remarks)
		{
			

			
			if( _CheckOutFail ) return;
 




			
			#region Check in 3)


			if(_Checkin_Cancel)   // local 만 체크
			{
				Run_Check_In_Local(arg_division, arg_factory, arg_style, arg_user, arg_remarks);
			}
			else  // remote, local 모두 체크
			{
				Run_Check_In_RemoteLocal(arg_division, arg_factory, arg_style, arg_user,arg_remarks);
			}

			

			#endregion 



		}

 

		
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
				DataTable dt_job = Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{

					
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					
					return false;


				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				} 
			 

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user =  Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					
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
				
				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
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
				DataSet ds_job = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{

			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
					return false;

				}
			

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

		
				if(ds_user == null)
				{

					
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 

					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				
		
				_CheckInFail = false;
				//ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;
 
			}
			catch
			{
				return false;
			}



		}


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
				DataTable dt_user = Form_BC_FormulaN.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{

				
			
					_CheckInFail = true;
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					 
	
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
				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

 
		 
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_FormulaN.Save_Check_Formula_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{

				
			
					_CheckInFail = true;
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공
				
		
				_CheckInFail = false;
				//ClassLib.ComFunction.User_Message("Check In Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

				return true;

			}
			catch
			{
				return false;
			}
  


		}



 
		private void Run_Check_Out(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
			

			if( _CheckInFail ) return;

			


			string division =arg_division;
			string factory = arg_factory;
			string stylecd =arg_stylecd;
			string checkuser = arg_checkuser;
			string remarks = arg_remarks;
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Form_BC_FormulaN.Save_Check_Formula_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{
 

				_CheckOutFail = true;

				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{


				_CheckOutFail = false;

				//ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}



		}

		
		



        public string  _vFactory="", _Stylecd="" , _Checkuser="",_Remarks="";
		private void btn_apply_Click(object sender, System.EventArgs e)
		{
	

			try
			{
				_vFactory = cmb_Factory.SelectedValue.ToString();
				_Checkuser= ClassLib.ComVar.This_User;
				_Remarks ="Formula Mutichange"  + _Checkuser;

				if (Check_Job() != true ) return;

				for (int i =_Rowfixed  ; i<fgrid_Formula.Rows.Count  ; i++)
				{
					  
					if (fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxFLAG].ToString()=="True")
					{
						_Stylecd   = fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxSTYLE_CD].ToString();

						Run_Check_In( "I", _vFactory, _Stylecd , _Checkuser,_Remarks );

						if (_CheckInFail)   //채산 lock  ..No
							//ClassLib.ComFunction.User_Message("Check In Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                            fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxJOB_YN]  = "Check In Fail";
						else                //채산 lock  ..Yes            
						{
							if (Apply_MitiJob(i) == true)
								fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxJOB_YN]  = ClassLib.ComVar.ConsReal_Y;

							else
								fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxJOB_YN]  = ClassLib.ComVar.ConsReal_N;
						}


                       Run_Check_Out ( "O", _vFactory, _Stylecd , _Checkuser,_Remarks );

						
					}
					else
					{

						fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxJOB_YN]  = ClassLib.ComVar.ConsReal_N;

						continue;
						
					}

					fgrid_Formula.TopRow  = i;

				}

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

			}
			catch(Exception ex)
			{  
				Run_Check_Out ( "O", _vFactory, _Stylecd , _Checkuser,_Remarks );
				ClassLib.ComFunction.User_Message(ex.Message, "btn_apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}

		}



		#endregion



		#region 기타이벤트

		private void rdo_Change_Click(object sender, System.EventArgs e)
		{
			_JobFlag = "C";
			SetJobFlag();
		}

		private void rdo_Delete_Click(object sender, System.EventArgs e)
		{
			_JobFlag = "D";
			SetJobFlag();
		}

		private void rdo_Add_Click(object sender, System.EventArgs e)
		{
			_JobFlag = "A";
			SetJobFlag();		
		}

		private void rdo_Weight_CheckedChanged(object sender, System.EventArgs e)
		{
			_JobFlag = "W";
			SetJobFlag();		
		}


		private void rdo_Yield_Weight_Click(object sender, System.EventArgs e)
		{
			_JobFlag = "V";
			SetJobFlag();	
		}




		
		private void cmb_Mcs_TextChanged(object sender, System.EventArgs e)
		{

			if ( _JobFlag  == "" )
			{
				ClassLib.ComFunction.User_Message("Check Job Division" , "DisPlayItem", MessageBoxButtons.OK, MessageBoxIcon.Error);

			    return;

			}



			if (cmb_Mcs.SelectedIndex  == -1) return;

			txt_Mcs.Text  = cmb_Mcs.SelectedValue.ToString();

			DataTable  dt_ret =  Select_Formula();

			DisPlayGrid(dt_ret);

			// Color
			dt_ret = SelectMcsColorCode(cmb_Factory.SelectedValue.ToString(), " "," ", cmb_Mcs.SelectedValue.ToString());
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Mcs_Color   , 0, 1,  true, 64, 178);
			cmb_Mcs_Color.SelectedIndex  = -1;


		}




		private void cmb_Mcs_Color_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				//if (cmb_Mcs_Color.SelectedIndex  == -1) return;


				txt_Mcs_Color.Text  = cmb_Mcs_Color.SelectedValue.ToString();

				DataTable  dt_ret =  Select_Formula();

				DisPlayGrid(dt_ret);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Mcs_Color_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}


		private void txt_Mcs_Color_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				if(e.KeyCode != Keys.Enter) return;
				  
				DataTable dt_list;

				dt_list =  Pop_Formula_Base_Register.SelectMcsColorCode(cmb_Factory.SelectedValue.ToString(), " ",
					                                 ClassLib.ComFunction.Empty_TextBox(txt_Mcs_Color," "));
				COM.ComCtl.Set_ComboList(dt_list, cmb_Mcs_Color  , 0,1,true, false,true);
				cmb_Mcs_Color.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Mcs_Color.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

			}
			catch(Exception)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
			} 

		}

		private void txt_Mcs_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{

				
				if(e.KeyCode != Keys.Enter) return;
				  
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_Mcs_List(" ",ClassLib.ComFunction.Empty_TextBox(txt_Mcs," ").ToUpper());
				COM.ComCtl.Set_ComboList(dt_list, cmb_Mcs, 0, 1,true, false, true);
				cmb_Mcs.Splits[0].DisplayColumns["Code"].Width = 70;
				cmb_Mcs.Splits[0].DisplayColumns["Name"].Width = 150;
				dt_list.Dispose();

				

			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Mcs_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}

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



		#endregion 

		


		#endregion 

		#region 콘텍스트 메뉴


		private void menu_AllSelect_Click(object sender, System.EventArgs e)
		{
			for (int i = fgrid_Formula.Rows.Fixed ; i < fgrid_Formula.Rows.Count ; i++)
			{
				fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxFLAG] = "True";

			}
		}


		private void menu_AllCancel_Click(object sender, System.EventArgs e)
		{
		
			for (int i = fgrid_Formula.Rows.Fixed ; i < fgrid_Formula.Rows.Count  ; i++)
			{
				fgrid_Formula[i,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxFLAG]  = "False";

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




		#endregion
	
		#region DB 컨넥트

		
		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		/// 
		public static DataTable SelectMcsColorCode(string  arg_factory ,string arg_color, string arg_color_name, string arg_mcs_cd)
		{

			COM.OraDB _LMyOraDB = new COM.OraDB();

			DataSet ds_ret; int iCnt;
			
			iCnt  =  5;
			_LMyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_LMyOraDB.Process_Name = "PKG_SBC_MCS_COLOR.SELECT_SBC_COLOR_BY_MCS";
 
			//02.ARGURMENT명
			_LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_LMyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			_LMyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			_LMyOraDB.Parameter_Name[3] = "ARG_MCS_CD";
			_LMyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			_LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_LMyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_LMyOraDB.Parameter_Values[0] =arg_factory;
			_LMyOraDB.Parameter_Values[1] =arg_color.ToUpper();
			_LMyOraDB.Parameter_Values[2] =arg_color_name.ToUpper();
			_LMyOraDB.Parameter_Values[3] =arg_mcs_cd.ToUpper();
			_LMyOraDB.Parameter_Values[4] = ""; 

			_LMyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _LMyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_LMyOraDB.Process_Name]; 
		}


		/// <summary>
		/// SelectFormula: Formula  조회
		/// </summary>
		/// <returns></returns>
		public DataTable Select_Formula()
		{
		
			DataSet ds_ret; int iCnt;
			
			iCnt  =  8;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA_MUTI";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FLAG";
			_MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			_MyOraDB.Parameter_Name[3] = "ARG_FORMULA_YEAR";
			_MyOraDB.Parameter_Name[4] = "ARG_SEASON_CD";
			_MyOraDB.Parameter_Name[5] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[6] = "ARG_MCS_COLOR_CD";
			_MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = _JobFlag;
			_MyOraDB.Parameter_Values[1] = cmb_Factory.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[2] = txt_Style_Cd.Text;
			_MyOraDB.Parameter_Values[3] = cmb_Year.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[4] = cmb_Season.SelectedValue.ToString();
			_MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_String(txt_Mcs.Text.ToString()," ");
			_MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_String(txt_Mcs_Color.Text.ToString()," ");
			_MyOraDB.Parameter_Values[7] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		
		/// <summary>
		/// Apply : Apply_MitiJob
		/// </summary>
		public bool  Apply_MitiJob(int arg_row)
		{
			try
			{
				DataSet ds_ret;


				//Size범위 설정하기
				MakeSizeRange();

									    
				int  vCol =20;

				_MyOraDB.ReDim_Parameter(vCol); 

				_MyOraDB.Process_Name=  "PKG_SBC_FORMULA.SAVE_SBC_FORMULA_MUTI";
			
				int i=0;
				_MyOraDB.Parameter_Name[i++] = "ARG_FLAG"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_HEAD"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_FACTORY";   		       
				_MyOraDB.Parameter_Name[i++] = "ARG_STYLE_CD";  		 
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_YEAR";  
				_MyOraDB.Parameter_Name[i++] = "ARG_SEASON_CD";     
				_MyOraDB.Parameter_Name[i++] = "ARG_FORMULA_DIV";   
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_CD";      	 
				_MyOraDB.Parameter_Name[i++] = "ARG_MCS_COLOR_CD";  
				_MyOraDB.Parameter_Name[i++] = "ARG_NEW_ITEM_CD";   
				_MyOraDB.Parameter_Name[i++] = "ARG_NEW_SPEC_CD";   
				_MyOraDB.Parameter_Name[i++] = "ARG_NEW_COLOR_CD";  
				_MyOraDB.Parameter_Name[i++] = "ARG_OLD_ITEM_CD";   
				_MyOraDB.Parameter_Name[i++] = "ARG_OLD_SPEC_CD";   
				_MyOraDB.Parameter_Name[i++] = "ARG_OLD_COLOR_CD";  
				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_FROM"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_CS_SIZE_TO"; 
				_MyOraDB.Parameter_Name[i++] = "ARG_WEIGHT";        
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";  		 
				_MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";      


			

				for (int k=0 ; k< vCol; k++)
					_MyOraDB.Parameter_Type[k] = 1; 						


				#region Value 

				int vCnt   = 1;           
				_MyOraDB.Parameter_Values = new string[vCnt*vCol*_Dt_Size_Range.Rows.Count] ;


					int vCntJob  = 0;
                

					for (int j=0 ; j<_Dt_Size_Range.Rows.Count; j++)   
					{		                
					
						if (vCntJob==0) 
							_JobDir  = _JobHead ;
						else
							_JobDir  = _JobTail;


						_MyOraDB.Parameter_Values[vCntJob++] =  _JobFlag;
						_MyOraDB.Parameter_Values[vCntJob++] =  _JobDir;
						_MyOraDB.Parameter_Values[vCntJob++] =  cmb_Factory.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  fgrid_Formula[arg_row,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxSTYLE_CD].ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  cmb_Year.Text;
						_MyOraDB.Parameter_Values[vCntJob++] =  cmb_Season.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  cmb_Formula_Type.SelectedValue.ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  fgrid_Formula[arg_row,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxMCS_CD].ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  fgrid_Formula[arg_row,(int)ClassLib.TBSBC_FOMULAN_MUTI.IxMCS_COLOR_CD].ToString();
						_MyOraDB.Parameter_Values[vCntJob++] =  _MaterialNewCode;
						_MyOraDB.Parameter_Values[vCntJob++] =  _SpecNewCode;
						_MyOraDB.Parameter_Values[vCntJob++] =  _ColorNewCode ;
						_MyOraDB.Parameter_Values[vCntJob++] =  _MaterialOldCode;
						_MyOraDB.Parameter_Values[vCntJob++] =  _SpecOldCode;
						_MyOraDB.Parameter_Values[vCntJob++] =  _ColorOldCode;

						//사이즈 처리하기.....

						_MyOraDB.Parameter_Values[vCntJob++] = _Dt_Size_Range.Rows[j].ItemArray[0].ToString();
						_MyOraDB.Parameter_Values[vCntJob++] = _Dt_Size_Range.Rows[j].ItemArray[1].ToString();


						if (_JobFlag == "V")
							_MyOraDB.Parameter_Values[vCntJob++] =  fgrid_YieldValue[_Row_MYield,_ColFixed + Convert.ToInt16(_Dt_Size_Range.Rows[j].ItemArray[3])].ToString(); // option에 따라 weight로 사용
						else
							_MyOraDB.Parameter_Values[vCntJob++] = (txt_Material_To.Text  == null)? "0":txt_Material_To.Text;

						_MyOraDB.Parameter_Values[vCntJob++] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						_MyOraDB.Parameter_Values[vCntJob++] =  ClassLib.ComVar.This_User;	

					}	
			
			
				#endregion

				_MyOraDB.Add_Modify_Parameter(true);
				ds_ret  =  _MyOraDB.Exe_Modify_Procedure();	
 
				return true;


			}
			catch
			{

			  return false;

			}




		}



		#endregion



	}
}

