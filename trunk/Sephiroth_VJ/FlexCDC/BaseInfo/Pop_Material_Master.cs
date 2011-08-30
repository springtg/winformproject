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
using System.IO;


namespace FlexCDC.BaseInfo
{
	public class Pop_Material_Master : COM.PCHWinForm.Pop_Large_B
	{
		#region 컨트롤정의 및 리소스정의 
        
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TabPage tab_Part;
		private System.Windows.Forms.TabPage tab_Material;
		private System.Windows.Forms.TabPage tab_Color;
		private System.Windows.Forms.TabPage tab_Mcs;
		private System.Windows.Forms.Panel pnl_Tab;
		public COM.FSP fgrid_Part;
		private System.Windows.Forms.Label lbl_ColorDesc;
		private System.Windows.Forms.Label lbl_ColorCode;
		private System.Windows.Forms.Splitter splitter1;
		public COM.FSP fgrid_Material;
		public COM.FSP fgrid_Color;
		public COM.FSP fgrid_Unit;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabControl tab_Body;
		public COM.FSP fgrid_Mcs;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Panel pnl_Body;
		public System.Windows.Forms.Panel pnl_Low;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_Part_Seq;
		private System.Windows.Forms.Label lbl_Part_Seq;
		private System.Windows.Forms.TextBox txt_Part_Desc;
		private System.Windows.Forms.Label lbl_Part_Desc;
		private System.Windows.Forms.TextBox txt_Part_Type;
		private System.Windows.Forms.Label lbl_Part_Type;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_Color_Comment;
		private System.Windows.Forms.Label lbl_Color_Comment;
		private System.Windows.Forms.TextBox txt_Color_Desc;
		private System.Windows.Forms.Label lbl_Color_Desc;
		private System.Windows.Forms.TextBox txt_Color_Cd;
		private System.Windows.Forms.Label lbl_Color_Cd;
		private System.Windows.Forms.TabPage tab_UnitSpec;
		private C1.Win.C1List.C1Combo cmb_spec;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Button btn_Search;
		private System.Windows.Forms.TextBox txt_Spec_Name;
		private System.Windows.Forms.TextBox txt_Spec_Cd;
		private System.Windows.Forms.TextBox txt_Unit;
		private System.Windows.Forms.Label lbl_Unit;
		private System.Windows.Forms.TextBox txt_MCS;
		private System.Windows.Forms.Label lbl_MCS;
		private System.Windows.Forms.TextBox txt_Mat_Comment;
		private System.Windows.Forms.Label lbl_Mat_Comment;
		private System.Windows.Forms.TextBox txt_Mat_Desc;
		private System.Windows.Forms.Label lbl_Mat_Desc;
		private System.Windows.Forms.TextBox txt_Mat_Name;
		private System.Windows.Forms.Label lbl_Mat_Name;
		private System.Windows.Forms.TextBox txt_Mat_Cd;
		private System.Windows.Forms.Label lbl_Mat_Cd;
		private System.ComponentModel.IContainer components = null;
        

		#region   Loading 
        
        public string _jobtype = "";
        public string _out_no = "";
        public Outgoing.Form_Outgoing outgoing_manager = null;
        private Label lbl_part_qty;
        private TextBox txt_part_qty;
        private bool _multi_flg = false;
        private int _tab_index;
		public Pop_Material_Master()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}
		
		public Pop_Material_Master(string arg_type )
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			_jobtype = arg_type;

			switch(_jobtype)
			{

				case "P":
				{
					tab_Body.SelectedIndex = 0;

					return;
				}
				case  "M":  //Material
				{
				
					tab_Body.SelectedIndex = 1;


					return;
				}
				case "MC": //MCS
				{
				
					tab_Body.SelectedIndex = 2;


					return;
				}
				case "C": //Color
				{
				
					tab_Body.SelectedIndex =3;

					return;
				}
				case "U": //UnitSpec
				{
				
					tab_Body.SelectedIndex =4;

					return;
				}                
				default:
				{

					tab_Body.SelectedIndex = 0;
					return;
				}
			}		
		}

        public Pop_Material_Master(string arg_type, string arg_out_no, Outgoing.Form_Outgoing arg_request)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            _jobtype = arg_type;
            _out_no  = arg_out_no;
            outgoing_manager = arg_request;

            tab_Body.SelectedIndex = 1;
        }

        public Pop_Material_Master(string arg_type, bool arg_multi_flg)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.            
            _jobtype   = arg_type;
            _multi_flg = arg_multi_flg;

            Set_Multi_Update(_jobtype);
            switch (_jobtype)
            {

                case "P":
                    {
                        tab_Body.SelectedIndex = 0;
                        _tab_index = 0;                        
                        return;
                    }
                case "M":  //Material
                    {

                        tab_Body.SelectedIndex = 1;
                        _tab_index = 1;

                        return;
                    }
                case "MC": //MCS
                    {

                        tab_Body.SelectedIndex = 2;
                        _tab_index = 2;

                        return;
                    }
                case "C": //Color
                    {

                        tab_Body.SelectedIndex = 3;
                        _tab_index = 3;
                        return;
                    }
                case "U": //UnitSpec
                    {

                        tab_Body.SelectedIndex = 4;
                        _tab_index = 4;

                        return;
                    }
                default:
                    {

                        tab_Body.SelectedIndex = 0;
                        _tab_index = 0;
                        return;
                    }
            }
            
        }

		#endregion 
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Material_Master));
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
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.cmb_spec = new C1.Win.C1List.C1Combo();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_ColorDesc = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_ColorCode = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Low = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Spec_Name = new System.Windows.Forms.TextBox();
            this.txt_Spec_Cd = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.txt_MCS = new System.Windows.Forms.TextBox();
            this.lbl_MCS = new System.Windows.Forms.Label();
            this.txt_Color_Comment = new System.Windows.Forms.TextBox();
            this.lbl_Color_Comment = new System.Windows.Forms.Label();
            this.txt_Color_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Color_Desc = new System.Windows.Forms.Label();
            this.txt_Color_Cd = new System.Windows.Forms.TextBox();
            this.lbl_Color_Cd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_part_qty = new System.Windows.Forms.TextBox();
            this.lbl_part_qty = new System.Windows.Forms.Label();
            this.txt_Mat_Comment = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Comment = new System.Windows.Forms.Label();
            this.txt_Mat_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Desc = new System.Windows.Forms.Label();
            this.txt_Mat_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Name = new System.Windows.Forms.Label();
            this.txt_Mat_Cd = new System.Windows.Forms.TextBox();
            this.lbl_Mat_Cd = new System.Windows.Forms.Label();
            this.txt_Part_Seq = new System.Windows.Forms.TextBox();
            this.lbl_Part_Seq = new System.Windows.Forms.Label();
            this.txt_Part_Desc = new System.Windows.Forms.TextBox();
            this.lbl_Part_Desc = new System.Windows.Forms.Label();
            this.txt_Part_Type = new System.Windows.Forms.TextBox();
            this.lbl_Part_Type = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_Tab = new System.Windows.Forms.Panel();
            this.tab_Body = new System.Windows.Forms.TabControl();
            this.tab_Part = new System.Windows.Forms.TabPage();
            this.fgrid_Part = new COM.FSP();
            this.tab_Material = new System.Windows.Forms.TabPage();
            this.fgrid_Material = new COM.FSP();
            this.tab_Mcs = new System.Windows.Forms.TabPage();
            this.fgrid_Mcs = new COM.FSP();
            this.tab_Color = new System.Windows.Forms.TabPage();
            this.fgrid_Color = new COM.FSP();
            this.tab_UnitSpec = new System.Windows.Forms.TabPage();
            this.fgrid_Unit = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_spec)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_Body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Low.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_Tab.SuspendLayout();
            this.tab_Body.SuspendLayout();
            this.tab_Part.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Part)).BeginInit();
            this.tab_Material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Material)).BeginInit();
            this.tab_Mcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).BeginInit();
            this.tab_Color.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).BeginInit();
            this.tab_UnitSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Unit)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.Location = new System.Drawing.Point(521, 4);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(168, 23);
            this.lbl_MainTitle.Text = "Code Information";
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
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.cmb_spec);
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 65);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(920, 96);
            this.pnl_Search.TabIndex = 37;
            // 
            // cmb_spec
            // 
            this.cmb_spec.AddItemCols = 0;
            this.cmb_spec.AddItemSeparator = ';';
            //this.cmb_spec.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_spec.Caption = "";
            this.cmb_spec.CaptionHeight = 17;
            this.cmb_spec.CaptionStyle = style1;
            this.cmb_spec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_spec.ColumnCaptionHeight = 18;
            this.cmb_spec.ColumnFooterHeight = 18;
            this.cmb_spec.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_spec.ContentHeight = 17;
            this.cmb_spec.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_spec.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_spec.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spec.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_spec.EditorHeight = 17;
            this.cmb_spec.EvenRowStyle = style2;
            this.cmb_spec.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_spec.FooterStyle = style3;
            this.cmb_spec.GapHeight = 2;
            this.cmb_spec.HeadingStyle = style4;
            this.cmb_spec.HighLightRowStyle = style5;
            this.cmb_spec.ItemHeight = 15;
            this.cmb_spec.Location = new System.Drawing.Point(117, 57);
            this.cmb_spec.MatchEntryTimeout = ((long)(2000));
            this.cmb_spec.MaxDropDownItems = ((short)(5));
            this.cmb_spec.MaxLength = 32767;
            this.cmb_spec.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_spec.Name = "cmb_spec";
            this.cmb_spec.OddRowStyle = style6;
            //this.cmb_spec.PartialRightColumn = false;
            this.cmb_spec.PropBag = resources.GetString("cmb_spec.PropBag");
            this.cmb_spec.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_spec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_spec.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_spec.SelectedStyle = style7;
            this.cmb_spec.Size = new System.Drawing.Size(260, 21);
            this.cmb_spec.Style = style8;
            this.cmb_spec.TabIndex = 548;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.btn_Search);
            this.pnl_SearchImage.Controls.Add(this.lbl_ColorDesc);
            this.pnl_SearchImage.Controls.Add(this.txt_Code);
            this.pnl_SearchImage.Controls.Add(this.txt_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_ColorCode);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(904, 80);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(802, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(95, 23);
            this.btn_Search.TabIndex = 550;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_ColorDesc
            // 
            this.lbl_ColorDesc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ColorDesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorDesc.ImageIndex = 0;
            this.lbl_ColorDesc.ImageList = this.img_Label;
            this.lbl_ColorDesc.Location = new System.Drawing.Point(374, 50);
            this.lbl_ColorDesc.Name = "lbl_ColorDesc";
            this.lbl_ColorDesc.Size = new System.Drawing.Size(99, 21);
            this.lbl_ColorDesc.TabIndex = 547;
            this.lbl_ColorDesc.Tag = "1";
            this.lbl_ColorDesc.Text = "Name";
            this.lbl_ColorDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.Location = new System.Drawing.Point(109, 49);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(260, 22);
            this.txt_Code.TabIndex = 548;
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(475, 50);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 22);
            this.txt_Name.TabIndex = 0;
            // 
            // lbl_ColorCode
            // 
            this.lbl_ColorCode.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ColorCode.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ColorCode.ImageIndex = 0;
            this.lbl_ColorCode.ImageList = this.img_Label;
            this.lbl_ColorCode.Location = new System.Drawing.Point(8, 50);
            this.lbl_ColorCode.Name = "lbl_ColorCode";
            this.lbl_ColorCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_ColorCode.TabIndex = 546;
            this.lbl_ColorCode.Tag = "1";
            this.lbl_ColorCode.Text = "Code";
            this.lbl_ColorCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            //this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style9;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style10;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style11;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style12;
            this.cmb_Factory.HighLightRowStyle = style13;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 26);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style14;
            //this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style15;
            this.cmb_Factory.Size = new System.Drawing.Size(260, 21);
            this.cmb_Factory.Style = style16;
            this.cmb_Factory.TabIndex = 35;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 26);
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
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(803, 25);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 40);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(888, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(680, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Tag = "";
            this.lbl_title.Text = "      Code Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(888, 65);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 64);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(744, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 65);
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
            this.picb_ML.Size = new System.Drawing.Size(211, 47);
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
            this.picb_MM.Size = new System.Drawing.Size(736, 40);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.Color.White;
            this.pnl_Body.Controls.Add(this.panel2);
            this.pnl_Body.Controls.Add(this.splitter1);
            this.pnl_Body.Controls.Add(this.pnl_Tab);
            this.pnl_Body.Location = new System.Drawing.Point(-3, 166);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(4);
            this.pnl_Body.Size = new System.Drawing.Size(920, 496);
            this.pnl_Body.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_Low);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 245);
            this.panel2.TabIndex = 4;
            // 
            // pnl_Low
            // 
            this.pnl_Low.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Low.Controls.Add(this.groupBox2);
            this.pnl_Low.Controls.Add(this.groupBox1);
            this.pnl_Low.Controls.Add(this.splitter2);
            this.pnl_Low.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Low.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Low.Location = new System.Drawing.Point(0, 0);
            this.pnl_Low.Name = "pnl_Low";
            this.pnl_Low.Size = new System.Drawing.Size(912, 232);
            this.pnl_Low.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Spec_Name);
            this.groupBox2.Controls.Add(this.txt_Spec_Cd);
            this.groupBox2.Controls.Add(this.txt_Unit);
            this.groupBox2.Controls.Add(this.lbl_Unit);
            this.groupBox2.Controls.Add(this.txt_MCS);
            this.groupBox2.Controls.Add(this.lbl_MCS);
            this.groupBox2.Controls.Add(this.txt_Color_Comment);
            this.groupBox2.Controls.Add(this.lbl_Color_Comment);
            this.groupBox2.Controls.Add(this.txt_Color_Desc);
            this.groupBox2.Controls.Add(this.lbl_Color_Desc);
            this.groupBox2.Controls.Add(this.txt_Color_Cd);
            this.groupBox2.Controls.Add(this.lbl_Color_Cd);
            this.groupBox2.Location = new System.Drawing.Point(458, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 230);
            this.groupBox2.TabIndex = 597;
            this.groupBox2.TabStop = false;
            // 
            // txt_Spec_Name
            // 
            this.txt_Spec_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Spec_Name.Enabled = false;
            this.txt_Spec_Name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Spec_Name.Location = new System.Drawing.Point(218, 155);
            this.txt_Spec_Name.Name = "txt_Spec_Name";
            this.txt_Spec_Name.Size = new System.Drawing.Size(228, 22);
            this.txt_Spec_Name.TabIndex = 634;
            // 
            // txt_Spec_Cd
            // 
            this.txt_Spec_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Spec_Cd.Enabled = false;
            this.txt_Spec_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Spec_Cd.Location = new System.Drawing.Point(336, 11);
            this.txt_Spec_Cd.Name = "txt_Spec_Cd";
            this.txt_Spec_Cd.Size = new System.Drawing.Size(110, 22);
            this.txt_Spec_Cd.TabIndex = 633;
            this.txt_Spec_Cd.Visible = false;
            // 
            // txt_Unit
            // 
            this.txt_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Unit.Enabled = false;
            this.txt_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit.Location = new System.Drawing.Point(107, 155);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(110, 22);
            this.txt_Unit.TabIndex = 631;
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.ImageIndex = 0;
            this.lbl_Unit.ImageList = this.img_Label;
            this.lbl_Unit.Location = new System.Drawing.Point(5, 155);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_Unit.TabIndex = 630;
            this.lbl_Unit.Tag = "1";
            this.lbl_Unit.Text = "Unit/Spec";
            this.lbl_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MCS
            // 
            this.txt_MCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MCS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MCS.Location = new System.Drawing.Point(106, 11);
            this.txt_MCS.Name = "txt_MCS";
            this.txt_MCS.Size = new System.Drawing.Size(110, 22);
            this.txt_MCS.TabIndex = 629;
            // 
            // lbl_MCS
            // 
            this.lbl_MCS.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_MCS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MCS.ImageIndex = 0;
            this.lbl_MCS.ImageList = this.img_Label;
            this.lbl_MCS.Location = new System.Drawing.Point(5, 11);
            this.lbl_MCS.Name = "lbl_MCS";
            this.lbl_MCS.Size = new System.Drawing.Size(100, 21);
            this.lbl_MCS.TabIndex = 628;
            this.lbl_MCS.Tag = "1";
            this.lbl_MCS.Text = "MCS";
            this.lbl_MCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Color_Comment
            // 
            this.txt_Color_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Comment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Comment.Location = new System.Drawing.Point(106, 104);
            this.txt_Color_Comment.Name = "txt_Color_Comment";
            this.txt_Color_Comment.Size = new System.Drawing.Size(340, 22);
            this.txt_Color_Comment.TabIndex = 609;
            // 
            // lbl_Color_Comment
            // 
            this.lbl_Color_Comment.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Color_Comment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color_Comment.ImageIndex = 0;
            this.lbl_Color_Comment.ImageList = this.img_Label;
            this.lbl_Color_Comment.Location = new System.Drawing.Point(5, 104);
            this.lbl_Color_Comment.Name = "lbl_Color_Comment";
            this.lbl_Color_Comment.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color_Comment.TabIndex = 608;
            this.lbl_Color_Comment.Tag = "1";
            this.lbl_Color_Comment.Text = "Color Cmt.";
            this.lbl_Color_Comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Color_Desc
            // 
            this.txt_Color_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Desc.Enabled = false;
            this.txt_Color_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Desc.Location = new System.Drawing.Point(106, 81);
            this.txt_Color_Desc.Name = "txt_Color_Desc";
            this.txt_Color_Desc.Size = new System.Drawing.Size(340, 22);
            this.txt_Color_Desc.TabIndex = 607;
            // 
            // lbl_Color_Desc
            // 
            this.lbl_Color_Desc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Color_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color_Desc.ImageIndex = 0;
            this.lbl_Color_Desc.ImageList = this.img_Label;
            this.lbl_Color_Desc.Location = new System.Drawing.Point(5, 81);
            this.lbl_Color_Desc.Name = "lbl_Color_Desc";
            this.lbl_Color_Desc.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color_Desc.TabIndex = 606;
            this.lbl_Color_Desc.Tag = "1";
            this.lbl_Color_Desc.Text = "Color Name";
            this.lbl_Color_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Color_Cd
            // 
            this.txt_Color_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Cd.Enabled = false;
            this.txt_Color_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Cd.Location = new System.Drawing.Point(106, 58);
            this.txt_Color_Cd.Name = "txt_Color_Cd";
            this.txt_Color_Cd.Size = new System.Drawing.Size(110, 22);
            this.txt_Color_Cd.TabIndex = 603;
            // 
            // lbl_Color_Cd
            // 
            this.lbl_Color_Cd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Color_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Color_Cd.ImageIndex = 0;
            this.lbl_Color_Cd.ImageList = this.img_Label;
            this.lbl_Color_Cd.Location = new System.Drawing.Point(5, 58);
            this.lbl_Color_Cd.Name = "lbl_Color_Cd";
            this.lbl_Color_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color_Cd.TabIndex = 602;
            this.lbl_Color_Cd.Tag = "1";
            this.lbl_Color_Cd.Text = "Color Code";
            this.lbl_Color_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_part_qty);
            this.groupBox1.Controls.Add(this.lbl_part_qty);
            this.groupBox1.Controls.Add(this.txt_Mat_Comment);
            this.groupBox1.Controls.Add(this.lbl_Mat_Comment);
            this.groupBox1.Controls.Add(this.txt_Mat_Desc);
            this.groupBox1.Controls.Add(this.lbl_Mat_Desc);
            this.groupBox1.Controls.Add(this.txt_Mat_Name);
            this.groupBox1.Controls.Add(this.lbl_Mat_Name);
            this.groupBox1.Controls.Add(this.txt_Mat_Cd);
            this.groupBox1.Controls.Add(this.lbl_Mat_Cd);
            this.groupBox1.Controls.Add(this.txt_Part_Seq);
            this.groupBox1.Controls.Add(this.lbl_Part_Seq);
            this.groupBox1.Controls.Add(this.txt_Part_Desc);
            this.groupBox1.Controls.Add(this.lbl_Part_Desc);
            this.groupBox1.Controls.Add(this.txt_Part_Type);
            this.groupBox1.Controls.Add(this.lbl_Part_Type);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 230);
            this.groupBox1.TabIndex = 596;
            this.groupBox1.TabStop = false;
            // 
            // txt_part_qty
            // 
            this.txt_part_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_part_qty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_part_qty.Location = new System.Drawing.Point(105, 80);
            this.txt_part_qty.Multiline = true;
            this.txt_part_qty.Name = "txt_part_qty";
            this.txt_part_qty.Size = new System.Drawing.Size(110, 22);
            this.txt_part_qty.TabIndex = 636;
            this.txt_part_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_part_qty
            // 
            this.lbl_part_qty.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_part_qty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_part_qty.ImageIndex = 0;
            this.lbl_part_qty.ImageList = this.img_Label;
            this.lbl_part_qty.Location = new System.Drawing.Point(4, 80);
            this.lbl_part_qty.Name = "lbl_part_qty";
            this.lbl_part_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_part_qty.TabIndex = 635;
            this.lbl_part_qty.Tag = "1";
            this.lbl_part_qty.Text = "Part Qty";
            this.lbl_part_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mat_Comment
            // 
            this.txt_Mat_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Comment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Comment.Location = new System.Drawing.Point(105, 155);
            this.txt_Mat_Comment.Name = "txt_Mat_Comment";
            this.txt_Mat_Comment.Size = new System.Drawing.Size(340, 22);
            this.txt_Mat_Comment.TabIndex = 634;
            // 
            // lbl_Mat_Comment
            // 
            this.lbl_Mat_Comment.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mat_Comment.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Comment.ImageIndex = 0;
            this.lbl_Mat_Comment.ImageList = this.img_Label;
            this.lbl_Mat_Comment.Location = new System.Drawing.Point(4, 155);
            this.lbl_Mat_Comment.Name = "lbl_Mat_Comment";
            this.lbl_Mat_Comment.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mat_Comment.TabIndex = 633;
            this.lbl_Mat_Comment.Tag = "1";
            this.lbl_Mat_Comment.Text = "Mat. Cmt";
            this.lbl_Mat_Comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mat_Desc
            // 
            this.txt_Mat_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Desc.Enabled = false;
            this.txt_Mat_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Desc.Location = new System.Drawing.Point(105, 178);
            this.txt_Mat_Desc.Multiline = true;
            this.txt_Mat_Desc.Name = "txt_Mat_Desc";
            this.txt_Mat_Desc.Size = new System.Drawing.Size(340, 48);
            this.txt_Mat_Desc.TabIndex = 632;
            // 
            // lbl_Mat_Desc
            // 
            this.lbl_Mat_Desc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mat_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Desc.ImageIndex = 0;
            this.lbl_Mat_Desc.ImageList = this.img_Label;
            this.lbl_Mat_Desc.Location = new System.Drawing.Point(4, 178);
            this.lbl_Mat_Desc.Name = "lbl_Mat_Desc";
            this.lbl_Mat_Desc.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mat_Desc.TabIndex = 631;
            this.lbl_Mat_Desc.Tag = "1";
            this.lbl_Mat_Desc.Text = "Mat. Desc";
            this.lbl_Mat_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mat_Name
            // 
            this.txt_Mat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Name.Location = new System.Drawing.Point(105, 132);
            this.txt_Mat_Name.Name = "txt_Mat_Name";
            this.txt_Mat_Name.Size = new System.Drawing.Size(340, 22);
            this.txt_Mat_Name.TabIndex = 630;
            // 
            // lbl_Mat_Name
            // 
            this.lbl_Mat_Name.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mat_Name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Name.ImageIndex = 0;
            this.lbl_Mat_Name.ImageList = this.img_Label;
            this.lbl_Mat_Name.Location = new System.Drawing.Point(4, 132);
            this.lbl_Mat_Name.Name = "lbl_Mat_Name";
            this.lbl_Mat_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mat_Name.TabIndex = 629;
            this.lbl_Mat_Name.Tag = "1";
            this.lbl_Mat_Name.Text = "Mat. Name";
            this.lbl_Mat_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Mat_Cd
            // 
            this.txt_Mat_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mat_Cd.Enabled = false;
            this.txt_Mat_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Cd.Location = new System.Drawing.Point(105, 109);
            this.txt_Mat_Cd.Name = "txt_Mat_Cd";
            this.txt_Mat_Cd.Size = new System.Drawing.Size(110, 22);
            this.txt_Mat_Cd.TabIndex = 628;
            // 
            // lbl_Mat_Cd
            // 
            this.lbl_Mat_Cd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Mat_Cd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mat_Cd.ImageIndex = 0;
            this.lbl_Mat_Cd.ImageList = this.img_Label;
            this.lbl_Mat_Cd.Location = new System.Drawing.Point(4, 109);
            this.lbl_Mat_Cd.Name = "lbl_Mat_Cd";
            this.lbl_Mat_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mat_Cd.TabIndex = 627;
            this.lbl_Mat_Cd.Tag = "1";
            this.lbl_Mat_Cd.Text = "Mat. Code";
            this.lbl_Mat_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Part_Seq
            // 
            this.txt_Part_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Part_Seq.Enabled = false;
            this.txt_Part_Seq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Part_Seq.Location = new System.Drawing.Point(105, 11);
            this.txt_Part_Seq.Name = "txt_Part_Seq";
            this.txt_Part_Seq.Size = new System.Drawing.Size(110, 22);
            this.txt_Part_Seq.TabIndex = 626;
            // 
            // lbl_Part_Seq
            // 
            this.lbl_Part_Seq.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Part_Seq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Part_Seq.ImageIndex = 0;
            this.lbl_Part_Seq.ImageList = this.img_Label;
            this.lbl_Part_Seq.Location = new System.Drawing.Point(4, 11);
            this.lbl_Part_Seq.Name = "lbl_Part_Seq";
            this.lbl_Part_Seq.Size = new System.Drawing.Size(100, 21);
            this.lbl_Part_Seq.TabIndex = 625;
            this.lbl_Part_Seq.Tag = "1";
            this.lbl_Part_Seq.Text = "Part No";
            this.lbl_Part_Seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Part_Desc
            // 
            this.txt_Part_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Part_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Part_Desc.Location = new System.Drawing.Point(105, 57);
            this.txt_Part_Desc.Multiline = true;
            this.txt_Part_Desc.Name = "txt_Part_Desc";
            this.txt_Part_Desc.Size = new System.Drawing.Size(340, 22);
            this.txt_Part_Desc.TabIndex = 622;
            // 
            // lbl_Part_Desc
            // 
            this.lbl_Part_Desc.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Part_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Part_Desc.ImageIndex = 0;
            this.lbl_Part_Desc.ImageList = this.img_Label;
            this.lbl_Part_Desc.Location = new System.Drawing.Point(4, 57);
            this.lbl_Part_Desc.Name = "lbl_Part_Desc";
            this.lbl_Part_Desc.Size = new System.Drawing.Size(100, 21);
            this.lbl_Part_Desc.TabIndex = 621;
            this.lbl_Part_Desc.Tag = "1";
            this.lbl_Part_Desc.Text = "Part Name";
            this.lbl_Part_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Part_Type
            // 
            this.txt_Part_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Part_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Part_Type.Location = new System.Drawing.Point(105, 34);
            this.txt_Part_Type.Name = "txt_Part_Type";
            this.txt_Part_Type.Size = new System.Drawing.Size(340, 22);
            this.txt_Part_Type.TabIndex = 620;
            // 
            // lbl_Part_Type
            // 
            this.lbl_Part_Type.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Part_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Part_Type.ImageIndex = 0;
            this.lbl_Part_Type.ImageList = this.img_Label;
            this.lbl_Part_Type.Location = new System.Drawing.Point(4, 34);
            this.lbl_Part_Type.Name = "lbl_Part_Type";
            this.lbl_Part_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Part_Type.TabIndex = 619;
            this.lbl_Part_Type.Tag = "1";
            this.lbl_Part_Type.Text = "Part Type";
            this.lbl_Part_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 232);
            this.splitter2.TabIndex = 25;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(4, 244);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnl_Tab
            // 
            this.pnl_Tab.Controls.Add(this.tab_Body);
            this.pnl_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tab.Location = new System.Drawing.Point(4, 4);
            this.pnl_Tab.Name = "pnl_Tab";
            this.pnl_Tab.Size = new System.Drawing.Size(912, 240);
            this.pnl_Tab.TabIndex = 0;
            // 
            // tab_Body
            // 
            this.tab_Body.Controls.Add(this.tab_Part);
            this.tab_Body.Controls.Add(this.tab_Material);
            this.tab_Body.Controls.Add(this.tab_Mcs);
            this.tab_Body.Controls.Add(this.tab_Color);
            this.tab_Body.Controls.Add(this.tab_UnitSpec);
            this.tab_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Body.Location = new System.Drawing.Point(0, 0);
            this.tab_Body.Name = "tab_Body";
            this.tab_Body.SelectedIndex = 0;
            this.tab_Body.Size = new System.Drawing.Size(912, 240);
            this.tab_Body.TabIndex = 0;
            this.tab_Body.SelectedIndexChanged += new System.EventHandler(this.tab_Body_SelectedIndexChanged);
            // 
            // tab_Part
            // 
            this.tab_Part.Controls.Add(this.fgrid_Part);
            this.tab_Part.Location = new System.Drawing.Point(4, 21);
            this.tab_Part.Name = "tab_Part";
            this.tab_Part.Size = new System.Drawing.Size(904, 215);
            this.tab_Part.TabIndex = 0;
            this.tab_Part.Text = "Part";
            // 
            // fgrid_Part
            // 
            this.fgrid_Part.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Part.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Part.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Part.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Part.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Part.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Part.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Part.Name = "fgrid_Part";
            this.fgrid_Part.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Part.Size = new System.Drawing.Size(904, 215);            
            this.fgrid_Part.TabIndex = 107;
            this.fgrid_Part.DoubleClick += new System.EventHandler(this.fgrid_Part_DoubleClick);
            // 
            // tab_Material
            // 
            this.tab_Material.Controls.Add(this.fgrid_Material);
            this.tab_Material.Location = new System.Drawing.Point(4, 21);
            this.tab_Material.Name = "tab_Material";
            this.tab_Material.Size = new System.Drawing.Size(904, 215);
            this.tab_Material.TabIndex = 1;
            this.tab_Material.Text = "Material";
            // 
            // fgrid_Material
            // 
            this.fgrid_Material.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Material.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Material.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Material.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Material.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Material.Name = "fgrid_Material";
            this.fgrid_Material.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Material.Size = new System.Drawing.Size(904, 215);            
            this.fgrid_Material.TabIndex = 107;
            this.fgrid_Material.DoubleClick += new System.EventHandler(this.fgrid_Material_DoubleClick);
            // 
            // tab_Mcs
            // 
            this.tab_Mcs.Controls.Add(this.fgrid_Mcs);
            this.tab_Mcs.Location = new System.Drawing.Point(4, 21);
            this.tab_Mcs.Name = "tab_Mcs";
            this.tab_Mcs.Size = new System.Drawing.Size(904, 215);
            this.tab_Mcs.TabIndex = 3;
            this.tab_Mcs.Text = "MCS";
            // 
            // fgrid_Mcs
            // 
            this.fgrid_Mcs.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Mcs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Mcs.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Mcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Mcs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Mcs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Mcs.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Mcs.Name = "fgrid_Mcs";
            this.fgrid_Mcs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Mcs.Size = new System.Drawing.Size(904, 215);            
            this.fgrid_Mcs.TabIndex = 107;
            this.fgrid_Mcs.DoubleClick += new System.EventHandler(this.fgrid_Mcs_DoubleClick);
            // 
            // tab_Color
            // 
            this.tab_Color.Controls.Add(this.fgrid_Color);
            this.tab_Color.Location = new System.Drawing.Point(4, 21);
            this.tab_Color.Name = "tab_Color";
            this.tab_Color.Size = new System.Drawing.Size(904, 215);
            this.tab_Color.TabIndex = 2;
            this.tab_Color.Text = "Color";
            // 
            // fgrid_Color
            // 
            this.fgrid_Color.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Color.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Color.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Color.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Color.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Color.Name = "fgrid_Color";
            this.fgrid_Color.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Color.Size = new System.Drawing.Size(904, 215);            
            this.fgrid_Color.TabIndex = 107;
            this.fgrid_Color.DoubleClick += new System.EventHandler(this.fgrid_Color_DoubleClick);
            // 
            // tab_UnitSpec
            // 
            this.tab_UnitSpec.Controls.Add(this.fgrid_Unit);
            this.tab_UnitSpec.Location = new System.Drawing.Point(4, 21);
            this.tab_UnitSpec.Name = "tab_UnitSpec";
            this.tab_UnitSpec.Size = new System.Drawing.Size(904, 215);
            this.tab_UnitSpec.TabIndex = 5;
            this.tab_UnitSpec.Text = "Unit/Spec";
            // 
            // fgrid_Unit
            // 
            this.fgrid_Unit.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Unit.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Unit.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Unit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Unit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Unit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Unit.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Unit.Name = "fgrid_Unit";
            this.fgrid_Unit.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Unit.Size = new System.Drawing.Size(904, 215);            
            this.fgrid_Unit.TabIndex = 107;
            this.fgrid_Unit.DoubleClick += new System.EventHandler(this.fgrid_Unit_DoubleClick);
            // 
            // Pop_Material_Master
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(916, 646);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Search);
            this.Location = new System.Drawing.Point(0, 64);
            this.Name = "Pop_Material_Master";
            this.Load += new System.EventHandler(this.Pop_Material_Master_Load);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_spec)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Low.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Tab.ResumeLayout(false);
            this.tab_Body.ResumeLayout(false);
            this.tab_Part.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Part)).EndInit();
            this.tab_Material.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Material)).EndInit();
            this.tab_Mcs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).EndInit();
            this.tab_Color.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).EndInit();
            this.tab_UnitSpec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Unit)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private COM.OraDB MyOraDB = new COM.OraDB();
		private  string _tabname ="";
        public bool save_flg = false;
		#endregion

		#region 공통메쏘드
		private void Init_Form()
		{
			try
			{
				this.Text = "Code Information";
				this.lbl_MainTitle.Text = "Code Information";
				this.lbl_title.Text = "      Code Information";

				//ClassLib.ComFunction.SetLangDic(this); 


			    tbtn_Append.Enabled  = false;
			    tbtn_Color.Enabled   = false;
			    tbtn_Conform.Enabled = false;
				tbtn_Create.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_New.Enabled	 = false;
				tbtn_Print.Enabled   = false;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = false;
                if (ClassLib.ComVar.This_User == "pttra.develop")
                {
                    txt_Mat_Name.Enabled = true;
                }
                else
                {
                    txt_Mat_Name.Enabled = false;
                }


			
				DataTable  dt_list;		
				// Factory Combobox Add Items
				dt_list = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
				cmb_Factory.Enabled  = false;

                
                dt_list = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), "SXC07");
                ClassLib.ComCtl.Set_ComboList(dt_list, cmb_spec, 1, 1, true, COM.ComVar.ComboList_Visible.Name);
                cmb_spec.SelectedIndex = 0;

                if (_jobtype == "O")//Outgoing Manager
                {
                    tab_Part.Dispose();
                    tab_Mcs.Dispose();

                    Set_Grid();
                    Set_ImageIndex();
                    Set_Property();

                    txt_Color_Cd.ReadOnly = true;
                    txt_Color_Comment.ReadOnly = true;
                    txt_Color_Desc.ReadOnly = true;

                    txt_Mat_Cd.ReadOnly = true;
                    txt_Mat_Name.ReadOnly = true;
                    txt_Mat_Comment.ReadOnly = true;
                    txt_Mat_Desc.ReadOnly = true;

                    lbl_Part_Desc.Visible = false;
                    lbl_Part_Seq.Visible = false;
                    lbl_Part_Type.Visible = false;
                    lbl_part_qty.Visible = false;
                    txt_Part_Seq.Visible = false;
                    txt_Part_Type.Visible = false;
                    txt_Part_Desc.Visible = false;
                    txt_part_qty.Visible = false;

                    txt_Spec_Cd.ReadOnly = true;
                    txt_Spec_Name.ReadOnly = true;
                    txt_Unit.ReadOnly = true;

                    lbl_MCS.Visible = false;
                    txt_MCS.Visible = false;


                    txt_Name.Focus();

                    //tab위치잡기..
                    tab_Body_SelectedIndexChanged(null, null);
                    
                }
                else if (_jobtype == "MB")
                {
                    lbl_ColorCode.Text = "Part Type";
                    lbl_ColorDesc.Text = "Part Name";

                    cmb_spec.Visible = false;

                    Set_Grid();
                    Set_ImageIndex();
                    Set_Property();

                    txt_Name.Focus();

                    //tab위치잡기..
                    tab_Body_SelectedIndexChanged(null, null);
                    
                }
                else //Update BOM
                {
                    lbl_ColorCode.Text = "Part Type";
                    lbl_ColorDesc.Text = "Part Name";

                    txt_Name.Focus();

                    cmb_spec.Visible = false;
                    if (COM.ComVar.This_Factory == "QD")
                    {
                        lbl_part_qty.Visible = true;
                        txt_part_qty.Visible = true;

                    }
                    else
                    {
                        lbl_part_qty.Visible = false;
                        txt_part_qty.Visible = false;
                        //txt_part_qty.Text = "1"; 
                    }
                    


                    Set_Grid();

                    //Main Form에서 Setting자료 가져오기..
                    Set_Property();


                    Set_ImageIndex();

                    //tab위치잡기..
                    tab_Body_SelectedIndexChanged(null, null);

                }

			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}


		}
        private void Set_Grid()
        {
            
                if (_jobtype != "O") // Update BOM 
                {
                    fgrid_Part.Rows.Count = fgrid_Part.Rows.Fixed;
                    fgrid_Material.Rows.Count = fgrid_Material.Rows.Fixed;
                    fgrid_Color.Rows.Count = fgrid_Color.Rows.Fixed;
                    fgrid_Mcs.Rows.Count = fgrid_Mcs.Rows.Fixed;
                    //fgrid_Spec.Rows.Count =fgrid_Spec.Rows.Fixed;
                    fgrid_Unit.Rows.Count = fgrid_Unit.Rows.Fixed;

                    fgrid_Part.Set_Grid_CDC("SXD_SRF_M_PART", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Part.ExtendLastCol = false;
                    fgrid_Part.Font = new Font("Verdana", 8);

                    fgrid_Material.Set_Grid_CDC("SXD_SRF_M_MAT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Material.ExtendLastCol = false;
                    fgrid_Material.Font = new Font("Verdana", 8);

                    fgrid_Color.Set_Grid_CDC("SXD_SRF_M_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Color.ExtendLastCol = false;
                    fgrid_Color.Font = new Font("Verdana", 8);

                    fgrid_Mcs.Set_Grid_CDC("SXD_SRF_M_MCS", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Mcs.ExtendLastCol = false;
                    fgrid_Mcs.Font = new Font("Verdana", 8);

                    fgrid_Unit.Set_Grid_CDC("SXD_SRF_M_UNIT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Unit.ExtendLastCol = false;
                    fgrid_Unit.Font = new Font("Verdana", 8);
                }
                else //Outgoing Manager
                {
                    fgrid_Material.Rows.Count = fgrid_Material.Rows.Fixed;
                    fgrid_Color.Rows.Count = fgrid_Color.Rows.Fixed;
                    fgrid_Unit.Rows.Count = fgrid_Unit.Rows.Fixed;

                    fgrid_Material.Set_Grid_CDC("SXD_SRF_M_MAT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Material.ExtendLastCol = false;
                    fgrid_Material.Font = new Font("Verdana", 8);

                    fgrid_Color.Set_Grid_CDC("SXD_SRF_M_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Color.ExtendLastCol = false;
                    fgrid_Color.Font = new Font("Verdana", 8);

                    fgrid_Unit.Set_Grid_CDC("SXD_SRF_M_UNIT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                    fgrid_Unit.ExtendLastCol = false;
                    fgrid_Unit.Font = new Font("Verdana", 8);
                }
            
        }	
		private void Set_ImageIndex()
		{
			lbl_Part_Seq.ImageIndex = 2;
			lbl_Part_Desc.ImageIndex = 2;
			lbl_Part_Type.ImageIndex = 2;
            lbl_part_qty.ImageIndex = 2;


			lbl_Mat_Cd.ImageIndex =  2;
			lbl_Mat_Comment.ImageIndex = 2;
			lbl_Mat_Desc.ImageIndex = 2;
			lbl_Mat_Name.ImageIndex = 2;


			lbl_MCS.ImageIndex = 2;


			lbl_Color_Cd.ImageIndex = 2;
			lbl_Color_Comment.ImageIndex = 2;
			lbl_Color_Desc.ImageIndex = 2;

			lbl_Unit.ImageIndex = 2;

		}
		private void Set_Property()
		{
			//Factory
			//cmb_Factory.SelectedValue  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY-1];           
            
            if (_jobtype != "O" && _jobtype != "MB") // Update BOM 
            {
                //Part 
                txt_Part_Seq.Text  = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1];
                txt_Part_Type.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1];
                txt_Part_Desc.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1];
                txt_part_qty.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1].Trim();
                
                //Material
                txt_Mat_Cd.Text      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1];
                txt_Mat_Comment.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1];
                txt_Mat_Name.Text    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1];
                txt_Mat_Desc.Text    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1];
                //txt_Yield_Value.Text= COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_YIELD-1];

                //Color
                txt_Color_Cd.Text      = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1];
                txt_Color_Desc.Text    = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1];
                txt_Color_Comment.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1];

                //Spec
                txt_Spec_Cd.Text   = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1];
                txt_Spec_Name.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1];

                //Mcs
                txt_MCS.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1];

                //Unit
                txt_Unit.Text = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1];
            }
            
		}        
		private void Select_Data_List()
		{
			DataTable dt_list ;
            
            if (_jobtype != "O") // Update BOM 
            {
                fgrid_Part.Rows.Count = fgrid_Part.Rows.Fixed;
                fgrid_Material.Rows.Count = fgrid_Material.Rows.Fixed;
                fgrid_Color.Rows.Count = fgrid_Color.Rows.Fixed;
                fgrid_Mcs.Rows.Count = fgrid_Mcs.Rows.Fixed;
                //fgrid_Spec.Rows.Count =fgrid_Spec.Rows.Fixed;
                fgrid_Unit.Rows.Count = fgrid_Unit.Rows.Fixed;




                switch (_tabname)
                {

                    case "tab_Part":
                        {

                            dt_list = Select_SRF_M_Part();
                            Display_Grid(dt_list, fgrid_Part);

                            return;
                        }
                    case "tab_Material":
                        {

                            if ((txt_Code.Text.Length == 0) && (txt_Name.Text.Length == 0))
                            {
                                ClassLib.ComFunction.User_Message("Please register material information", "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                return;

                            }



                            dt_list = Select_SRF_M_Material();
                            Display_Grid(dt_list, fgrid_Material);

                            return;
                        }
                    case "tab_Color":
                        {

                            dt_list = Select_SRF_M_Color();
                            Display_Grid(dt_list, fgrid_Color);

                            return;
                        }
                    case "tab_Mcs":
                        {

                            dt_list = Select_SRF_M_Mcs();
                            Display_Grid(dt_list, fgrid_Mcs);

                            return;
                        }
                    case "tab_UnitSpec":
                        {

                            dt_list = Select_SRF_M_Unit();
                            Display_Grid(dt_list, fgrid_Unit);

                            return;
                        }
                    default:
                        {


                            return;
                        }

                }
            }
            else
            {
                fgrid_Material.Rows.Count = fgrid_Material.Rows.Fixed;
                fgrid_Color.Rows.Count = fgrid_Color.Rows.Fixed;
                fgrid_Unit.Rows.Count = fgrid_Unit.Rows.Fixed;

                switch (_tabname)
                {                    
                    case "tab_Material":
                        {
                            if ((txt_Code.Text.Length == 0) && (txt_Name.Text.Length == 0))
                            {
                                ClassLib.ComFunction.User_Message("Please register material information", "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;

                            }

                            dt_list = Select_SRF_M_Material();
                            Display_Grid(dt_list, fgrid_Material);

                            return;
                        }
                    case "tab_Color":
                        {
                            dt_list = Select_SRF_M_Color();
                            Display_Grid(dt_list, fgrid_Color);

                            return;
                        }                    
                    case "tab_UnitSpec":
                        {
                            dt_list = Select_SRF_M_Unit();
                            Display_Grid(dt_list, fgrid_Unit);

                            return;
                        }
                    default:
                        {
                            return;
                        }

                }
 
            }
		

		}        
        private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			//arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 0);
				//arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";                

			}

            
            
            if (arg_fgrid.Name == "fgrid_Part")
            {
                for (int j = arg_fgrid.Rows.Fixed; j < arg_fgrid.Rows.Count; j++)
                {
                    arg_fgrid[j, 5] = "2";
                }
            }

			//arg_fgrid.AutoSizeCols(false);
		}
        private void Set_Tab_Clear()
		{
			txt_Code.Clear();
			txt_Name.Clear();

			tab_Body.SelectedIndex = tab_Body.SelectedIndex +1;
		}
        private void Set_Multi_Update(string arg_type)
        {
            switch (arg_type)
            {

                case "P":
                    {
                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = true;
                        txt_Part_Desc.Enabled = true;

                        if (COM.ComVar.This_Factory == "QD")
                        {
                            txt_part_qty.Enabled = true;
                        }
                        else
                        {
                            txt_part_qty.Visible = false;
                        }
                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = false;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = false;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = false;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = false;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;
                        return;
                    }
                case "M":  //Material
                    {

                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = false;
                        txt_Part_Desc.Enabled = false;
                        txt_part_qty.Enabled = false;

                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = true;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = true;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = false;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = false;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;

                        return;
                    }
                case "MC": //MCS
                    {
                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = false;
                        txt_Part_Desc.Enabled = false;
                        txt_part_qty.Enabled = false;

                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = false;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = false;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = false;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = true;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;

                        return;
                    }
                case "C": //Color
                    {
                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = false;
                        txt_Part_Desc.Enabled = false;
                        txt_part_qty.Enabled = false;

                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = false;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = false;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = true;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = false;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;
                        return;
                    }
                case "U": //UnitSpec
                    {
                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = false;
                        txt_Part_Desc.Enabled = false;
                        txt_part_qty.Enabled = false;

                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = false;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = false;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = false;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = false;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;
                        return;
                    }
                default:
                    {
                        txt_Part_Seq.Enabled = false;
                        txt_Part_Type.Enabled = true;
                        txt_Part_Desc.Enabled = true;
                        txt_part_qty.Enabled = true;

                        txt_Mat_Cd.Enabled = false;
                        txt_Mat_Comment.Enabled = false;
                        txt_Mat_Desc.Enabled = false;
                        txt_Mat_Name.Enabled = false;

                        txt_Color_Cd.Enabled = false;
                        txt_Color_Comment.Enabled = false;
                        txt_Color_Desc.Enabled = false;

                        txt_MCS.Enabled = false;

                        txt_Spec_Cd.Enabled = false;
                        txt_Spec_Name.Enabled = false;

                        txt_Unit.Enabled = false;
                        return;                        
                    }
            }		 
        }
		#endregion

		#region 이벤트처리
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

        }	
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			try
			{
				Select_Data_List();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "btn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
            if (ClassLib.ComVar.This_User == "pttra.develop")
            {
                txt_Mat_Name.Enabled = true;
            }
            else
            {
                txt_Mat_Name.Enabled = false;
            }

		}
		private void tab_Body_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			_tabname = tab_Body.TabPages[tab_Body.SelectedIndex].Name.ToString();            

			Set_ImageIndex();


            if (_multi_flg)            
                tab_Body.SelectedIndex = _tab_index;



			if(_tabname.Equals("tab_Part"))
			{
				lbl_ColorCode.Text = "No";
				lbl_ColorDesc.Text = "Name";
				cmb_spec.Visible = false;
				txt_Code.Visible = true;
                txt_Code.Enabled = false;

				lbl_Part_Seq.ImageIndex = 1;
				lbl_Part_Desc.ImageIndex = 1;
				lbl_Part_Type.ImageIndex =1;
                lbl_part_qty.ImageIndex = 1;
			}
			else if(_tabname.Equals("tab_Material"))
			{
				lbl_ColorCode.Text = "Code";
				lbl_ColorDesc.Text = "Name";
				cmb_spec.Visible = false;
				txt_Code.Visible = true;
                txt_Code.Enabled = true;
				
				lbl_Mat_Cd.ImageIndex = 1;
				lbl_Mat_Comment.ImageIndex =1;
				lbl_Mat_Desc.ImageIndex =1;
				lbl_Mat_Name.ImageIndex =1;
			}
			else if(_tabname.Equals("tab_Mcs"))
			{
				lbl_ColorCode.Text = "Code";
				lbl_ColorDesc.Text = "Name";
				cmb_spec.Visible = false;
				txt_Code.Visible = true;
                txt_Code.Enabled = true;

				lbl_MCS.ImageIndex =1;
			}
			else if(_tabname.Equals("tab_UnitSpec"))
			{
				lbl_ColorCode.Text = "Unit";
				lbl_ColorDesc.Text = "Spec";
				cmb_spec.Visible = true;
				txt_Code.Visible = false;
                txt_Code.Enabled = true;

				lbl_Unit.ImageIndex =1;
			}			
			else   //color
			{
				lbl_ColorCode.Text = "Code";
				lbl_ColorDesc.Text = "Name";
				cmb_spec.Visible = false;
				txt_Code.Visible = true;
                txt_Code.Enabled = true;

				lbl_Color_Cd.ImageIndex =1;
				lbl_Color_Comment.ImageIndex =1;
				lbl_Color_Desc.ImageIndex =1;
			}			 
			txt_Name.Focus();
		}
		private void fgrid_Part_DoubleClick(object sender, System.EventArgs e)
		{
            if (fgrid_Part.Rows.Count == fgrid_Part.Rows.Fixed)
                return;

			txt_Part_Seq.Text = fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_SEQ].ToString();
			txt_Part_Type.Text = fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_TYPE].ToString();
			txt_Part_Desc.Text =  fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_DESC].ToString();            
            txt_part_qty.Text = fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.IxPART_QTY].ToString();
           

			txt_Part_Seq.Tag =  txt_Part_Seq.Text;
			txt_Part_Type.Tag = txt_Part_Type.Text;
			txt_Part_Desc.Tag = txt_Part_Desc.Text;
            txt_part_qty.Tag = txt_part_qty.Text;

			Set_Tab_Clear();

			txt_Name.Focus();		
		}
		private void fgrid_Material_DoubleClick(object sender, System.EventArgs e)
		{
            if (fgrid_Material.Rows.Count == fgrid_Material.Rows.Fixed)
                return;

			txt_Mat_Cd.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_CD].ToString();
            txt_Mat_Comment.Text = " ";
			txt_Mat_Name.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_NAME].ToString();
            txt_Mat_Desc.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_NAME].ToString();	

			txt_Part_Seq.Tag =  txt_Part_Seq.Text;
			//txt_Mat_Comment.Tag =  txt_Mat_Comment.Text;
			txt_Mat_Name.Tag =  txt_Mat_Name.Text;			
			//txt_Mat_Desc.Tag =  txt_Mat_Desc.Text;

            txt_Mat_Comment.Tag = " ";
            txt_Mat_Desc.Tag = txt_Mat_Name.Text;
            txt_Mat_Name.Enabled = false;

			Set_Tab_Clear();

		}
		private void fgrid_Color_DoubleClick(object sender, System.EventArgs e)
		{
            if (fgrid_Color.Rows.Count == fgrid_Color.Rows.Fixed)
                return;

			txt_Color_Cd.Text  = fgrid_Color[fgrid_Color.Selection.r1, (int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_CD].ToString();
			txt_Color_Desc.Text  = fgrid_Color[fgrid_Color.Selection.r1, (int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_DESC].ToString();
            txt_Color_Comment.Text = " ";

			txt_Color_Cd.Tag =  txt_Color_Cd.Text;
			txt_Color_Desc.Tag =  txt_Color_Desc.Text;
			//txt_Color_Comment.Tag =  txt_Color_Comment.Text;
            txt_Color_Comment.Tag = " ";

			Set_Tab_Clear();
		}
		private void fgrid_Spec_DoubleClick(object sender, System.EventArgs e)
		{          

			txt_Spec_Cd.Tag =  txt_Spec_Cd.Text;
			txt_Spec_Name.Tag =  txt_Spec_Name.Text;

			Set_Tab_Clear();
		}
		private void fgrid_Mcs_DoubleClick(object sender, System.EventArgs e)
		{
            if (fgrid_Mcs.Rows.Count == fgrid_Mcs.Rows.Fixed)
                return;

			txt_MCS.Text  = fgrid_Mcs[fgrid_Mcs.Selection.r1, (int)ClassLib.SXD_SRF_M_MCS_POP.lxMCS_CD].ToString();							
			txt_MCS.Tag =  txt_MCS.Text;		

			Set_Tab_Clear();		
		}
		private void fgrid_Unit_DoubleClick (object sender, System.EventArgs e)
		{
            if (fgrid_Unit.Rows.Count == fgrid_Unit.Rows.Fixed)
                return;

			txt_Unit.Text = fgrid_Unit[fgrid_Unit.Selection.r1, (int)ClassLib.SXD_SRF_M_UNIT_POP.lxUNIT_CD].ToString();
			txt_Spec_Cd.Text  = fgrid_Unit[fgrid_Unit.Selection.r1, (int)ClassLib.SXD_SRF_M_UNIT_POP.lxSPEC_CD].ToString();
			txt_Spec_Name.Text  = fgrid_Unit[fgrid_Unit.Selection.r1, (int)ClassLib.SXD_SRF_M_UNIT_POP.lxSPEC_DESC].ToString();
			
			txt_Unit.Tag =  txt_Unit.Text;			

			Set_Tab_Clear();
		}		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            if (_jobtype != "O") //Update BOM
            {
                DataTable dt = Modify_sdd_srf_m_code();
                //int dt = 0;

                if (dt.Rows.Count > 0)
                {
                    int vCount = 17;
                    COM.ComVar.Parameter_PopUp = new string[vCount];

                    //Factory
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = cmb_Factory.SelectedValue.ToString();

                    //Part 
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxPART_SEQ - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxPART_TYPE - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxPART_DESC - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1].ToString();

                    //Material
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1].ToString();


                    //Color
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1].ToString();

                    //Spec
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1].ToString();
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1].ToString();

                    //Mcs
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxMCS_CD - 1].ToString();

                    //Unit
                    COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = dt.Rows[0].ItemArray[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1].ToString();


                    //Main Grid Setting시 없애기 
                    //COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT - 1] = " ";
                    //COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_DESC - 1] = " ";
                    //COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_COMMENT - 1] = " ";

                }

                this.Close();
            }
            else //Outgoing Manager
            {

                DataTable dt_ret;

                if (_out_no == "")
                {
                    dt_ret = get_out_no();
                    _out_no = dt_ret.Rows[0].ItemArray[0].ToString().Trim();
                }
                
                string factory     = cmb_Factory.SelectedValue.ToString();
                string mat_cd      = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Cd, "");
                string mat_name    = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name, "");
                string mat_comment = ClassLib.ComFunction.Empty_TextBox(txt_Mat_Comment, "");

                string spec_cd    = ClassLib.ComFunction.Empty_TextBox(txt_Spec_Cd, "");
                string spec_name  = ClassLib.ComFunction.Empty_TextBox(txt_Spec_Name, "");
                string color_cd   = ClassLib.ComFunction.Empty_TextBox(txt_Color_Cd, "");
                string color_name = ClassLib.ComFunction.Empty_TextBox(txt_Color_Desc, "");
                
                #region Save Check
                if (mat_cd == "")
                {
                    MessageBox.Show("Select Material");
                    return;
                }
                if (color_cd == "")
                {
                    MessageBox.Show("Select Color");
                    return;
                }
                if (spec_cd == "")
                { 
                    MessageBox.Show("Select Spec");
                    return;
                }                
                #endregion

                #region Grid Add
                //Tree Level 1
                outgoing_manager.flg_out.Rows.InsertNode(outgoing_manager.flg_out.Rows.Count, 1);
                
                int insert_row = outgoing_manager.flg_out.Rows.Count - 1;
                outgoing_manager.flg_out.Rows[outgoing_manager.flg_out.Rows.Count - 1].AllowEditing = true;                        
                outgoing_manager.flg_out.Rows[outgoing_manager.flg_out.Rows.Count - 1].StyleNew.BackColor = Color.White;  


                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxDIVISION]    = "I";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxLEVEL]       = "1";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxFACTORY]     = factory; 
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxMAT_CD]      = mat_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxPCC_SPEC_CD] = spec_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxCOLOR_CD]    = color_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxSTATUS]      = "Ready";                
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_NO]      = _out_no;                
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_DIV]     = "Request";                
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_01]     = mat_name;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_02]     = mat_comment;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_03]     = spec_name;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_04]     = color_name;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxPROD_YIELD]  = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_VALUE]   = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxIN_VALUE]    = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxREAL_VALUE]  = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxREMARKS]     = "";              


                //Tree Level 2
                outgoing_manager.flg_out.Rows.InsertNode(outgoing_manager.flg_out.Rows.Count, 2);

                insert_row = outgoing_manager.flg_out.Rows.Count - 1;
                outgoing_manager.flg_out.Rows[outgoing_manager.flg_out.Rows.Count - 1].AllowEditing = false;
                outgoing_manager.flg_out.Rows[outgoing_manager.flg_out.Rows.Count - 1].StyleNew.BackColor = Color.Beige;

                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxDIVISION]    = "";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxLEVEL]       = "1";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxFACTORY] = factory; 
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxMAT_CD]      = mat_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxPCC_SPEC_CD] = spec_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxCOLOR_CD]    = color_cd;
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxSTATUS]      = "";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_NO]      = "";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_DIV]     = "";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_01]     = "__________________________________";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_02]     = "____________________";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_03]     = "__________";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxITEM_04]     = "__________";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxPROD_YIELD]  = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxOUT_VALUE]   = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxIN_VALUE]    = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxREAL_VALUE]  = "0";
                outgoing_manager.flg_out[insert_row, (int)ClassLib.TBSXO_OUT_LIST.IxREMARKS]     = "";
                #endregion
            }

            save_flg = true;
					
		}
        #endregion

		#region DB컨넥트

        // Update BOM 
        private DataTable Modify_sdd_srf_m_code()
        {
            string Proc_Name = "PKG_SXD_SRF_03.modify_sxd_srf_tail";

            MyOraDB.ReDim_Parameter(18);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_part_seq";
            MyOraDB.Parameter_Name[2] = "arg_part_tyep";
            MyOraDB.Parameter_Name[3] = "arg_part_desc";
            MyOraDB.Parameter_Name[4] = "arg_part_qty";

            MyOraDB.Parameter_Name[5] = "arg_mat_cd";
            MyOraDB.Parameter_Name[6] = "arg_mat_comment";
            MyOraDB.Parameter_Name[7] = "arg_mat_name";
            MyOraDB.Parameter_Name[8] = "arg_mat_desc";
            MyOraDB.Parameter_Name[9] = "arg_color_cd";
            MyOraDB.Parameter_Name[10] = "arg_color_comment";
            MyOraDB.Parameter_Name[11] = "arg_color_desc";
            MyOraDB.Parameter_Name[12] = "arg_mcs_cd";
            MyOraDB.Parameter_Name[13] = "arg_pcc_spec_cd";
            MyOraDB.Parameter_Name[14] = "arg_pcc_spec_name";
            MyOraDB.Parameter_Name[15] = "arg_pcc_unit_cd";
            MyOraDB.Parameter_Name[16] = "arg_upd_user";
            MyOraDB.Parameter_Name[17] = "out_cursor";

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
            MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[17] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = txt_Part_Seq.Text.ToUpper();
            MyOraDB.Parameter_Values[2] = txt_Part_Type.Text.ToUpper();
            MyOraDB.Parameter_Values[3] = txt_Part_Desc.Text.ToUpper();
            MyOraDB.Parameter_Values[4] = txt_part_qty.Text.Trim();


            MyOraDB.Parameter_Values[5] = txt_Mat_Cd.Text.ToUpper();
            MyOraDB.Parameter_Values[6] = txt_Mat_Comment.Text.ToUpper();
            MyOraDB.Parameter_Values[7] = txt_Mat_Name.Text.ToUpper();
            MyOraDB.Parameter_Values[8] = txt_Mat_Desc.Text.ToUpper();
            MyOraDB.Parameter_Values[9] = txt_Color_Cd.Text.ToUpper();
            MyOraDB.Parameter_Values[10] = txt_Color_Comment.Text.ToUpper();
            MyOraDB.Parameter_Values[11] = txt_Color_Desc.Text.ToUpper();
            MyOraDB.Parameter_Values[12] = txt_MCS.Text.ToUpper();
            MyOraDB.Parameter_Values[13] = txt_Spec_Cd.Text;
            MyOraDB.Parameter_Values[14] = txt_Spec_Name.Text;
            MyOraDB.Parameter_Values[15] = txt_Unit.Text;
            MyOraDB.Parameter_Values[16] = ClassLib.ComVar.This_User;
            MyOraDB.Parameter_Values[17] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        
        // Outgoing Manager 
        private DataTable get_out_no()
        {
            string proc_Name = "pkg_sxo_out_01_select.get_out_no";

            MyOraDB.ReDim_Parameter(2);
            MyOraDB.Process_Name = proc_Name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;            

            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            return DS_Ret.Tables[proc_Name];
        }

		private DataTable  Select_SRF_M_Part()
		{
			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.select_sxd_srf_m_part_code";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "arg_part_type";
			MyOraDB.Parameter_Name[a++] = "arg_part_desc";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  txt_Code.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] =  txt_Name.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
		
		private DataTable  Select_SRF_M_Material()
		{
			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MAT_CODE";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "arg_mat_code";
			MyOraDB.Parameter_Name[a++] = "arg_mat_name";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  txt_Code.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] =  txt_Name.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}
		
		private DataTable  Select_SRF_M_Spec()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_SPEC";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_SPEC_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}

		private DataTable  Select_SRF_M_Unit()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.select_sxd_srf_m_spec";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "arg_pcc_unit_cd";
			MyOraDB.Parameter_Name[a++] = "arg_pcc_spec_name";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  cmb_spec.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}
		
		private DataTable  Select_SRF_M_Color()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.select_sxd_srf_m_color_code";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_COLOR_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  txt_Code.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] =  txt_Name.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}

		private DataTable  Select_SRF_M_Mcs()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MCS_CODE";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_MCS_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_MCS_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  txt_Code.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] =  txt_Name.Text.Trim().ToUpper();
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

        }
        

        
        #endregion


        private void Pop_Material_Master_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}       

	}
}

