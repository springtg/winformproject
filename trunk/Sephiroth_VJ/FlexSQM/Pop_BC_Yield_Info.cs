using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using FlexSQM.ClassLib;

namespace FlexSQM
{
	public class Pop_BC_Yield_Info : COM.SQMWinForm.Pop_Medium
	{
		#region �����̳ʿ��� ������ ����

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private COM.FSP fgrid_yield;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.GroupBox groupBox2;
		private C1.Win.C1List.C1Combo cmb_style_cd;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		private System.Windows.Forms.TextBox txt_style_cd;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem mnu_allSelect;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region ����� ���� ����

		public string _style = "";
		public string _component = "";

		private int _fixedRow = 0;
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.SSP spd_main;
		private COM.FSP fgrid_Material_Out;
		private int[] _checkCols;
		private string _mode;

		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		private bool _select				= true;
		private int _InputSize				= 0;

		private int _level1Col				= (int)TBSBC_YIELD_INFO_POP.IxLEVEL;
		private int _key1Col				= (int)TBSBC_YIELD_INFO_POP.IxKEY;
		private int _typeDivisionCol		= (int)TBSBC_YIELD_INFO_POP.IxTYPE_DIVISION;
		private int _chkApplyCol			= (int)TBSBC_YIELD_INFO_POP.IxCHECK_APPLY;
		private int _treeCol				= (int)TBSBC_YIELD_INFO_POP.IxTREE;
		private int _specNameCol			= (int)TBSBC_YIELD_INFO_POP.IxSPEC_NAME;
		private int _colorNameCol			= (int)TBSBC_YIELD_INFO_POP.IxCOLOR_NAME;
		private int _unitCol				= (int)TBSBC_YIELD_INFO_POP.IxUNIT;
		private int _checkYnCol				= (int)TBSBC_YIELD_INFO_POP.IxCHECK_YN;
		private int _factoryCol				= (int)TBSBC_YIELD_INFO_POP.IxFACTORY;
		private int _styleCdCol				= (int)TBSBC_YIELD_INFO_POP.IxSTYLE_CD;
		private int _componentCdCol			= (int)TBSBC_YIELD_INFO_POP.IxCOMPONENT_CD;
		private int _itemCdCol				= (int)TBSBC_YIELD_INFO_POP.IxITEM_CD;
		private int _specCdCol				= (int)TBSBC_YIELD_INFO_POP.IxSPEC_CD;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label btn_search;
        private System.Windows.Forms.TextBox txt_item;
		private int _colorCdCol				= (int)TBSBC_YIELD_INFO_POP.IxCOLOR_CD;

		#endregion
        private Label label1;
        private TextBox txtComponent;
        private C1.Win.C1List.C1Combo cmbComponent;

		#region ������ / �Ҹ���
        private string p_style_cd = "";
        private string p_comp_cd = "";
		public Pop_BC_Yield_Info(Control arg_grid, int[] arg_checks,string l_style_cd,string l_comp_cd)
		{
			InitializeComponent();

            p_style_cd = l_style_cd;
            p_comp_cd = l_comp_cd;
			if (arg_grid is COM.SSP)
			{
				spd_main = (COM.SSP)arg_grid;
			}
			else
			{
				fgrid_Material_Out = (COM.FSP)arg_grid;
			}

			_checkCols = arg_checks;
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BC_Yield_Info));
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
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Label();
            this.fgrid_yield = new COM.FSP();
            this.ctx_main = new System.Windows.Forms.ContextMenu();
            this.mnu_allSelect = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.cmbComponent = new C1.Win.C1List.C1Combo();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_style_cd = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_style = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_All = new System.Windows.Forms.RadioButton();
            this.rad_Comp = new System.Windows.Forms.RadioButton();
            this.rad_SG = new System.Windows.Forms.RadioButton();
            this.txt_style_cd = new System.Windows.Forms.TextBox();
            this.img_Type = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_yield)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style_cd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.c1Sizer1.GridDefinition = "20.5607476635514:False:False;67.5233644859813:False:False;8.17757009345794:False:" +
                "True;0.934579439252336:False:True;\t0.576368876080692:False:True;98.2708933717579" +
                ":False:False;0:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 86);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Location = new System.Drawing.Point(8, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 35);
            this.panel2.TabIndex = 169;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(611, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 358;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_Button;
            this.btn_Return.Location = new System.Drawing.Point(540, 5);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(70, 23);
            this.btn_Return.TabIndex = 357;
            this.btn_Return.Text = "Apply";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // fgrid_yield
            // 
            this.fgrid_yield.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_yield.ContextMenu = this.ctx_main;
            this.fgrid_yield.Location = new System.Drawing.Point(8, 92);
            this.fgrid_yield.Name = "fgrid_yield";
            this.fgrid_yield.Rows.DefaultSize = 18;
            this.fgrid_yield.Size = new System.Drawing.Size(686, 289);
            this.fgrid_yield.StyleInfo = resources.GetString("fgrid_yield.StyleInfo");
            this.fgrid_yield.TabIndex = 168;
            this.fgrid_yield.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_yield_AfterEdit);
            this.fgrid_yield.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_yield_BeforeEdit);
            // 
            // ctx_main
            // 
            this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_allSelect});
            // 
            // mnu_allSelect
            // 
            this.mnu_allSelect.Index = 0;
            this.mnu_allSelect.Text = "All Select";
            this.mnu_allSelect.Click += new System.EventHandler(this.mnu_allSelect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 88);
            this.panel1.TabIndex = 167;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtComponent);
            this.groupBox2.Controls.Add(this.cmbComponent);
            this.groupBox2.Controls.Add(this.txt_item);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.lbl_item);
            this.groupBox2.Controls.Add(this.cmb_style_cd);
            this.groupBox2.Controls.Add(this.lbl_factory);
            this.groupBox2.Controls.Add(this.cmb_factory);
            this.groupBox2.Controls.Add(this.lbl_style);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txt_style_cd);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 85);
            this.groupBox2.TabIndex = 536;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 593;
            this.label1.Text = "Component";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.White;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComponent.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtComponent.Location = new System.Drawing.Point(109, 60);
            this.txtComponent.MaxLength = 100;
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(115, 21);
            this.txtComponent.TabIndex = 592;
            this.txtComponent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComponent_KeyUp);
            // 
            // cmbComponent
            // 
            this.cmbComponent.AccessibleDescription = "";
            this.cmbComponent.AccessibleName = "";
            this.cmbComponent.AddItemSeparator = ';';
            this.cmbComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbComponent.Caption = "";
            this.cmbComponent.CaptionHeight = 17;
            this.cmbComponent.CaptionStyle = style1;
            this.cmbComponent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbComponent.ColumnCaptionHeight = 18;
            this.cmbComponent.ColumnFooterHeight = 18;
            this.cmbComponent.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbComponent.ContentHeight = 17;
            this.cmbComponent.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbComponent.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbComponent.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbComponent.EditorHeight = 17;
            this.cmbComponent.EvenRowStyle = style2;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FooterStyle = style3;
            this.cmbComponent.HeadingStyle = style4;
            this.cmbComponent.HighLightRowStyle = style5;
            this.cmbComponent.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbComponent.Images"))));
            this.cmbComponent.ItemHeight = 15;
            this.cmbComponent.Location = new System.Drawing.Point(225, 60);
            this.cmbComponent.MatchEntryTimeout = ((long)(2000));
            this.cmbComponent.MaxDropDownItems = ((short)(5));
            this.cmbComponent.MaxLength = 32767;
            this.cmbComponent.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.OddRowStyle = style6;
            this.cmbComponent.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbComponent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbComponent.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbComponent.SelectedStyle = style7;
            this.cmbComponent.Size = new System.Drawing.Size(138, 21);
            this.cmbComponent.Style = style8;
            this.cmbComponent.TabIndex = 590;
            this.cmbComponent.PropBag = resources.GetString("cmbComponent.PropBag");
            // 
            // txt_item
            // 
            this.txt_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(484, 60);
            this.txt_item.MaxLength = 10;
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(164, 21);
            this.txt_item.TabIndex = 550;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Window;
            this.btn_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(651, 60);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 547;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(383, 60);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 545;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_style_cd
            // 
            this.cmb_style_cd.AccessibleDescription = "";
            this.cmb_style_cd.AccessibleName = "";
            this.cmb_style_cd.AddItemSeparator = ';';
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
            this.cmb_style_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style_cd.FooterStyle = style11;
            this.cmb_style_cd.HeadingStyle = style12;
            this.cmb_style_cd.HighLightRowStyle = style13;
            this.cmb_style_cd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_style_cd.Images"))));
            this.cmb_style_cd.ItemHeight = 15;
            this.cmb_style_cd.Location = new System.Drawing.Point(225, 36);
            this.cmb_style_cd.MatchEntryTimeout = ((long)(2000));
            this.cmb_style_cd.MaxDropDownItems = ((short)(5));
            this.cmb_style_cd.MaxLength = 32767;
            this.cmb_style_cd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style_cd.Name = "cmb_style_cd";
            this.cmb_style_cd.OddRowStyle = style14;
            this.cmb_style_cd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style_cd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style_cd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style_cd.SelectedStyle = style15;
            this.cmb_style_cd.Size = new System.Drawing.Size(138, 21);
            this.cmb_style_cd.Style = style16;
            this.cmb_style_cd.TabIndex = 542;
            this.cmb_style_cd.SelectedValueChanged += new System.EventHandler(this.cmb_style_cd_SelectedValueChanged);
            this.cmb_style_cd.PropBag = resources.GetString("cmb_style_cd.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 14);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 539;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AccessibleDescription = "";
            this.cmb_factory.AccessibleName = "";
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style17;
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
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 14);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(254, 21);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 537;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_style
            // 
            this.lbl_style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(8, 36);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 538;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rad_All);
            this.groupBox1.Controls.Add(this.rad_Comp);
            this.groupBox1.Controls.Add(this.rad_SG);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(516, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 48);
            this.groupBox1.TabIndex = 543;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Tree View Option ";
            // 
            // rad_All
            // 
            this.rad_All.Checked = true;
            this.rad_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_All.Location = new System.Drawing.Point(115, 23);
            this.rad_All.Name = "rad_All";
            this.rad_All.Size = new System.Drawing.Size(38, 16);
            this.rad_All.TabIndex = 39;
            this.rad_All.TabStop = true;
            this.rad_All.Tag = "50";
            this.rad_All.Text = "All";
            this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Comp
            // 
            this.rad_Comp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rad_Comp.Location = new System.Drawing.Point(56, 23);
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
            this.rad_SG.Location = new System.Drawing.Point(4, 23);
            this.rad_SG.Name = "rad_SG";
            this.rad_SG.Size = new System.Drawing.Size(64, 16);
            this.rad_SG.TabIndex = 37;
            this.rad_SG.Tag = "1";
            this.rad_SG.Text = "Semi";
            this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // txt_style_cd
            // 
            this.txt_style_cd.BackColor = System.Drawing.Color.White;
            this.txt_style_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_style_cd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_style_cd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_style_cd.Location = new System.Drawing.Point(109, 36);
            this.txt_style_cd.MaxLength = 100;
            this.txt_style_cd.Name = "txt_style_cd";
            this.txt_style_cd.Size = new System.Drawing.Size(115, 21);
            this.txt_style_cd.TabIndex = 540;
            this.txt_style_cd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_style_cd_KeyUp);
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
            // Pop_BC_Yield_Info
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 510);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BC_Yield_Info";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_yield)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style_cd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region ���� ����

		//public string arg_datamode;
		//private int _Rowfixed = 3;
		//private int _drag_row; 
		//private string _shp_yn;
		//private FTPClient m_FtpClient;


		#endregion

		#region ��Ʈ�� �̺�Ʈ

		private void Form_Load(object sender, System.EventArgs e)
		{
            
			Init_Form();
            Init_Control();

            Init_Comp();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
            if (cmb_style_cd.SelectedIndex >= 0)
            {
                txt_style_cd.Text = cmb_style_cd.SelectedValue.ToString();
                Yield_Search();
            }
		}
        
		private void cmb_style_cd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				//��Ÿ�� ���ý� �ٷ� ��ȸ
				txt_style_cd.Text = cmb_style_cd.SelectedValue.ToString();
				Yield_Search();
			}
			catch{}
		}

 

		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			Return_Item_Data();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUpTable.Reset();
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 26;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 27;
		}

		#region Return Process

		/// <summary>
		/// Return_Item_Data : Return Data
		/// </summary>
        private void Return_Item_Data()
        {
            try
            {
                if (fgrid_yield.Rows.Count <= 3) return;

                int vFlag = 0;

                ClassLib.ComVar.Parameter_PopUpTable = new DataTable();
                DataColumn[] dc = new DataColumn[10];

                dc[0] = new DataColumn("item_cd", Type.GetType("System.String"));
                dc[1] = new DataColumn("item_nm", Type.GetType("System.String"));
                dc[2] = new DataColumn("spec_cd", Type.GetType("System.String"));
                dc[3] = new DataColumn("spec_nm", Type.GetType("System.String"));
                dc[4] = new DataColumn("color_cd", Type.GetType("System.String"));
                dc[5] = new DataColumn("color_nm", Type.GetType("System.String"));
                dc[6] = new DataColumn("unit", Type.GetType("System.String"));
                dc[7] = new DataColumn("factory", Type.GetType("System.String"));
                dc[8] = new DataColumn("style_cd", Type.GetType("System.String"));
                dc[9] = new DataColumn("component_cd", Type.GetType("System.String"));

                ClassLib.ComVar.Parameter_PopUpTable.Columns.AddRange(dc);

                for (int vRow = fgrid_yield.Rows.Fixed; vRow < fgrid_yield.Rows.Count; vRow++)
                {
                    if ((bool)fgrid_yield[vRow, _chkApplyCol])
                    {
                        if (spd_main != null)
                            vFlag = Etc_DataDuplicateCheck_SSP(vRow);
                        else
                        {
                            if (_mode.Equals("S"))	// ���� ���� ( ���ռ� üũ�� ������ �˷��ֱ⸸ �� )
                                vFlag = Etc_DataDuplicateCheck_Shipping(vRow);
                            else						// ��Ÿ
                                vFlag = Etc_DataDuplicateCheck_FSP(vRow);
                        }

                        if (vFlag == 0)
                        {
                            DataRow newRow = ClassLib.ComVar.Parameter_PopUpTable.NewRow();
                            newRow[0] = fgrid_yield[vRow, _itemCdCol].ToString();					// item_cd
                            newRow[1] = fgrid_yield[vRow, _treeCol].ToString();					// item_nm
                            newRow[2] = fgrid_yield[vRow, _specCdCol].ToString();					// spec_cd
                            newRow[3] = fgrid_yield[vRow, _specNameCol].ToString();				// spec_nm
                            newRow[4] = fgrid_yield[vRow, _colorCdCol].ToString();					// color_cd
                            newRow[5] = fgrid_yield[vRow, _colorNameCol].ToString();				// color_nm
                            newRow[6] = fgrid_yield[vRow, _unitCol].ToString();					// unit
                            newRow[7] = fgrid_yield[vRow, _factoryCol].ToString();					// factory
                            newRow[8] = fgrid_yield[vRow, _styleCdCol].ToString().Replace("-", "");	// style_cd
                            newRow[9] = fgrid_yield[vRow, _componentCdCol].ToString();				// component

                            ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow);
                        }
                        else if (vFlag == -1)
                        {
                            fgrid_yield.Rows[vRow].Selected = true;
                            break;
                        }
                    }
                }

                if (vFlag != -1)
                {
                    this.DialogResult = DialogResult.OK;
                    this._style = COM.ComFunction.Empty_Combo(cmb_style_cd, "");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Pop_Request_Tree_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private int Etc_DataDuplicateCheck_SSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++ )
			{
				if( spd_main.ActiveSheet.Cells[vRow, _checkCols[0]].Text.Replace("-", "").Equals(fgrid_yield[arg_row, _styleCdCol].ToString()) &&
					spd_main.ActiveSheet.Cells[vRow, _checkCols[1]].Text.Equals(fgrid_yield[arg_row, _itemCdCol].ToString()) &&
					spd_main.ActiveSheet.Cells[vRow, _checkCols[2]].Text.Equals(fgrid_yield[arg_row, _specCdCol].ToString()) &&
					spd_main.ActiveSheet.Cells[vRow, _checkCols[3]].Text.Equals(fgrid_yield[arg_row, _colorCdCol].ToString())) 
				{
					string vMessage = "The selected item is already exists \r\n" +
						"Choose process.. \r\n\r\n" +
						"[Yes] : overwrite the existing data \r\n" +
						"[No] : deselect current item \r\n" +
						"[Cancel] : process abort \r\n\r\n" +
						"Row Number : " + arg_row + "\r\n" + 
						"Item : " + fgrid_yield[arg_row, _treeCol]  + 
						"  Spec : " + fgrid_yield[arg_row, _specNameCol] +
						"  Color : "+ fgrid_yield[arg_row, _colorNameCol] + "\t";

					fgrid_yield.Select(arg_row, _chkApplyCol);
					spd_main.ActiveSheet.ClearSelection();
					spd_main.ActiveSheet.AddSelection(vRow, 1, 1, 1);

					switch (MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							string vTag = (spd_main.Sheets[0].Cells[vRow, 0].Tag == null) ? "" : spd_main.Sheets[0].Cells[vRow, 0].Tag.ToString();
							if (vTag.Equals(ClassLib.ComVar.Insert))
								spd_main.ActiveSheet.Rows[vRow].Remove();
							else
								spd_main.Delete_Row(vRow, img_Action);
							vReturn = 0;
							break;

						case DialogResult.No:
							fgrid_yield[arg_row, _chkApplyCol] = false;
							vReturn = 1;
							break;

						case DialogResult.Cancel:
							vReturn = -1;
							break;
					}

					break;
				}
			}

			return vReturn;
		}

		private int Etc_DataDuplicateCheck_FSP(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = fgrid_Material_Out.Rows.Fixed ; vRow < fgrid_Material_Out.Rows.Count ; vRow++ )
			{
				if( fgrid_Material_Out[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(fgrid_yield[arg_row, _styleCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[1]].ToString().Equals(fgrid_yield[arg_row, _itemCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[2]].ToString().Equals(fgrid_yield[arg_row, _specCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[3]].ToString().Equals(fgrid_yield[arg_row, _colorCdCol].ToString())) 
				{
					string vMessage = "The selected item is already exists \r\n" +
						"Choose process.. \r\n\r\n" +
						"[Yes] : overwrite the existing data \r\n" +
						"[No] : deselect current item \r\n" +
						"[Cancel] : process abort \r\n\r\n" +
						"Row Number : " + arg_row + "\r\n" + 
						"Item : " + fgrid_yield[arg_row, _treeCol]  + 
						"  Spec : " + fgrid_yield[arg_row, _specNameCol] +
						"  Color : "+ fgrid_yield[arg_row, _colorNameCol] + "\t";

					fgrid_yield.Select(arg_row, _chkApplyCol);
					fgrid_Material_Out.Select(vRow, 1);

					switch (MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							string vTag = (fgrid_Material_Out[vRow, 0] == null) ? "" : fgrid_Material_Out[vRow, 0].ToString();
							if (vTag.Equals(ClassLib.ComVar.Insert))
								fgrid_Material_Out.RemoveItem(vRow);
							else
								fgrid_Material_Out.Delete_Row(vRow);
							vReturn = 0;
							break;

						case DialogResult.No:
							fgrid_yield[arg_row, _chkApplyCol] = false;
							vReturn = 1;
							break;

						case DialogResult.Cancel:
							vReturn = -1;
							break;
					}

					break;
				}				
			}

			return vReturn;
		}

		private int Etc_DataDuplicateCheck_Shipping(int arg_row)
		{
			int vReturn = 0;

			for ( int vRow = fgrid_Material_Out.Rows.Fixed ; vRow < fgrid_Material_Out.Rows.Count ; vRow++ )
			{
				if( fgrid_Material_Out[vRow, _checkCols[0]].ToString().Replace("-", "").Equals(fgrid_yield[arg_row, _styleCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[1]].ToString().Equals(fgrid_yield[arg_row, _itemCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[2]].ToString().Equals(fgrid_yield[arg_row, _specCdCol].ToString()) &&
					fgrid_Material_Out[vRow, _checkCols[3]].ToString().Equals(fgrid_yield[arg_row, _colorCdCol].ToString())) 
				{
					string vMessage = "The selected item is already exists!!";

					fgrid_yield.Select(arg_row, _chkApplyCol);
					fgrid_Material_Out.Select(vRow, 1);

					MessageBox.Show(this, vMessage, "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			return vReturn;
		}

		#endregion

		#endregion

		#region �׸��� �̺�Ʈ

		private void fgrid_yield_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

		}
		

		private void fgrid_yield_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int vCol = e.Col;
		
			if (vCol == _chkApplyCol)
			{
				Grid_CheckBoxClick();
			}

			e.Cancel = true;		
		}

		#endregion

		#region �̺�Ʈ ó���� ���Ǵ� �޼���

		#region �ʱ�ȭ

		private void Init_Form()
		{
			DataTable dt_ret;
			DataTable vDt;

            //Title
			this.Text			= "Yield Information";
            lbl_MainTitle.Text = "Yield Information";
            ClassLib.ComFunction.SetLangDic(this);

			// �׸��� ����
			fgrid_yield.Set_Grid("SBC_YIELD_INFO_POP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_yield.Set_Action_Image(img_Action);

			// �����ڵ�
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false);
			if (ClassLib.ComVar.Parameter_PopUp == null)
			{
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				_mode = "";
			}
			else
			{
				cmb_factory.SelectedValue = ClassLib.ComFunction.NullCheck(ClassLib.ComVar.Parameter_PopUp[0], COM.ComVar.This_Factory);
				_mode = ClassLib.ComVar.Parameter_PopUp[1];
			}

            

			ClassLib.ComVar.Parameter_PopUp = null;

			dt_ret.Dispose();

			//this.txt_style_cd.Text = _style;
			//if (!_style.Equals(""))
			//	txt_style_cd_KeyUp(null, new KeyEventArgs(Keys.Enter));

			//vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP09");
			//vDt.Dispose();

			


            
		}
        private void Init_Control()
        {
            txt_style_cd.Text = p_style_cd;

            DataTable dt_ret;

            dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_style_cd, " "));

            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
            ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style_cd, 0, 1, 2, 3, 4, false, 80, 140);

            if (dt_ret.Rows.Count == 1)
                cmb_style_cd.SelectedIndex = 0;
            else if (dt_ret.Rows.Count == 0)
                fgrid_yield.ClearAll();

            dt_ret.Dispose();

            txt_style_cd.Enabled = false;
            cmb_style_cd.Enabled = false;



            
            //dt_ret = Search_Component();
            //if (dt_ret.Rows.Count == 1)
            //    cmbComponent.SelectedIndex = 0;
            //else if (dt_ret.Rows.Count == 0)
            //    fgrid_yield.ClearAll();

            //dt_ret.Dispose();
            

        }
        private void Init_Comp()
        {
            txtComponent.Text = p_comp_cd;
            txtComponent_KeyUp(null, new KeyEventArgs(Keys.Enter));
            if (txtComponent.Text != "")
            {
                cmbComponent.SelectedIndex = 0;
            }
            btn_search_Click(null, new EventArgs());

            txtComponent.Enabled = false;
            cmbComponent.Enabled = false;
        }
        private DataTable Search_Component()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_component";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_style_cd";
                MyOraDB.Parameter_Name[1] = "arg_comp_nm";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_style_cd.SelectedValue);
                MyOraDB.Parameter_Values[1] = Convert.ToString(txtComponent.Text);
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }
		#endregion

		#region ��Ʈ�� �̺�Ʈ ó�� �޼���

		private void mnu_allSelect_Click(object sender, System.EventArgs e)
		{
            fgrid_yield.SelectAll();
		}

		private void txt_style_cd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_style_cd, " "));

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style_cd, 0, 1, 2, 3, 4, false, 80, 140); 

				if (dt_ret.Rows.Count == 1 )
					cmb_style_cd.SelectedIndex = 0;
				else if ( dt_ret.Rows.Count == 0)
					fgrid_yield.ClearAll();
				 
				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_style_cd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Yield_Searc : ��ȸ
		/// </summary>
		public void Yield_Search()
		{
			//��ȸ���� ����üũ......
			if(cmb_factory.SelectedValue == null || cmb_style_cd.SelectedValue == null ) return;
										
			Select_Yield_List();
		}

		/// <summary>
		/// Select_Yield_List : ��ȸ�ο� �´� ������ �׸��忡 ǥ��
		/// </summary>
		private void Select_Yield_List()
		{
			try
			{
				_fixedRow = fgrid_yield.Rows.Fixed;

				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
				DataTable dt_ret;

				string vFactory		= COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vStyleCode	= COM.ComFunction.Empty_Combo(cmb_style_cd, "").Replace("-", "");
				string vFlag		= "50";
				string vItem        = COM.ComFunction.Empty_TextBox(txt_item, " ");
                string vComp        = COM.ComFunction.Empty_Combo(cmbComponent, "");


                dt_ret = Select_YieldList(vFactory, vStyleCode, vFlag, vItem, vComp);

				if (dt_ret.Rows.Count > 0)
				{
					fgrid_yield.ClearAll();
					fgrid_yield.Tree.Column = (int)ClassLib.TBSBC_YIELD_INFO_POP.IxTREE;
					fgrid_yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO_POP.IxTREE].ImageAndText = true; 
					fgrid_yield.Cols[(int)ClassLib.TBSBC_YIELD_INFO_POP.IxTREE].ImageMap = _Imgmap; 

					for(int i = 0, idx = 0 ; i < dt_ret.Rows.Count ; i++)
					{
						int vRow = idx + _fixedRow;
						
						if (i != 0)
						{
							string vKey = fgrid_yield[vRow - 1, _key1Col].ToString();
							if (vKey.Equals(dt_ret.Rows[i].ItemArray[_key1Col - 1].ToString()))
								continue;
						}

						fgrid_yield.Rows.InsertNode(vRow, Convert.ToInt32(dt_ret.Rows[i].ItemArray[0].ToString().Length ));
						Grid_InsertData(vRow, dt_ret.Rows[i].ItemArray);
						//fgrid_yield.Rows[vRow].AllowEditing = (bool)fgrid_yield[vRow, _checkYnCol];
						
						/***************************** ������ ǥ�� *********************************/
						
						switch ( fgrid_yield[vRow, _level1Col].ToString().Length.ToString() )
						{
							
							case "1":   // semi_good_cd
 
								fgrid_yield.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
								if(_Imgmap.ContainsKey(fgrid_yield[vRow, _treeCol].ToString())) break;
								_Imgmap.Add(fgrid_yield[vRow, _treeCol].ToString(), img_Type.Images[0]);

								fgrid_yield.Rows[vRow].AllowEditing = false;
							
								break;

							case "2":  // component_cd
								
								fgrid_yield.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
								if(_Imgmap.ContainsKey(fgrid_yield[vRow, _treeCol].ToString())) break;
								_Imgmap.Add(fgrid_yield[vRow, _treeCol].ToString(), img_Type.Images[2]); 

								fgrid_yield.Rows[vRow].AllowEditing = false;
							
								break;
					
							default:   // raw_material, joint

								fgrid_yield.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
								if(_Imgmap.ContainsKey(fgrid_yield[vRow, _treeCol].ToString() ) ) break;

								switch(fgrid_yield[vRow, _typeDivisionCol].ToString() )
								{ 
									case "J":
										_Imgmap.Add(fgrid_yield[vRow, _treeCol].ToString(), img_Type.Images[4]);
										break;

									case "M":
										_Imgmap.Add(fgrid_yield[vRow, _treeCol].ToString(), img_Type.Images[3]);
										break;
								}
								break;
						}

						idx++;
					}
				}
				else
				{
					fgrid_yield.ClearAll();
				}
 
				dt_ret.Dispose();

				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Yield_List", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Grid_InsertData(int arg_row, object[] arg_items)
		{
			int vRow = arg_row;
			int vCol = 1;

			while (vCol < fgrid_yield.Cols.Count)
			{
				fgrid_yield[vRow, vCol] = arg_items[vCol - 1];
				vCol++;
			}
		}

		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton;

				if(src.Name.Equals("rad_All"))
				{
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

		#endregion

		#region �׸��� �̺�Ʈ ó�� �޼���

		private void Grid_CheckBoxClick()
		{
			int[] vSel = fgrid_yield.Selections;

			if (vSel.Length > 1)
			{
				GridCheckBoxBlockSelect(vSel);
			}
			else
			{
				GridCheckBoxCorrection();
			}
		}

		private void GridCheckBoxBlockSelect(int[] arg_sel)
		{
			bool vFlag = (bool)fgrid_yield[fgrid_yield.Row, _chkApplyCol];

			foreach (int vRow in arg_sel)
			{
				if ((bool)fgrid_yield[vRow, _checkYnCol])
				{
					fgrid_yield[vRow, _chkApplyCol] = vFlag;
				}
				else
				{
					fgrid_yield[vRow, _chkApplyCol] = false;
				}
			}

			_select = !_select;
		}

		private void GridCheckBoxCorrection()
		{
			int vRow = fgrid_yield.Row;

			//if (!(bool)fgrid_yield[vRow, _checkYnCol])
			//{
				//fgrid_yield[vRow, _chkApplyCol] = false;
				//return;
			//}

			Node vNode = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
			if (vNode != null)
			{
				int vLevel = fgrid_yield.Rows[vRow].Node.Level;				
				int vTempRow = vRow + 1;

				while(fgrid_yield.Rows[vTempRow].Node.Level > vLevel)
				{
					fgrid_yield[vTempRow, _chkApplyCol] = false;
					vTempRow++;

					if (vTempRow >= fgrid_yield.Rows.Count)
						break;
				}
			}
			else
			{
				vNode = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent);
				int vParentRow = fgrid_yield.Rows[vRow].Node.GetNode(NodeTypeEnum.Parent).Row.Index;

				while (vNode.Level >= 3)
				{
					fgrid_yield[vNode.Row.Index, _chkApplyCol] = false;
					vNode = fgrid_yield.Rows[vNode.Row.Index].Node.GetNode(NodeTypeEnum.Parent);
				}
			}
		}

		#endregion

		#endregion

		#region DB Connect

		/// <summary>
		/// Select_StyleList : ��Ÿ�� ��ȸ
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
		///  Yield_Tree ��ȸ
		/// </summary>
		/// <param name="arg_factory">�����ڵ�</param>
		/// <param name="arg_stylecode">��Ÿ���ڵ�</param>
		/// <param name="arg_flag">��ȸ �÷��� ( 10:SHIP_YN, 20:PUR_SHIP_YN, 30:PUR_IMPORT_YN, 40:PUR_LOCAL_YN, PROD_YN ) </param>
		/// <returns></returns>
		public DataTable Select_YieldList(string arg_factory, string arg_stylecode, string arg_flag)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SBC_YIELD_INFO_REQ.SELECT_SBC_YIELD_INFO_POP";
 
			//02.ARGURMENT��
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_FLAG";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecode;
			MyOraDB.Parameter_Values[2] = arg_flag;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		/// <summary>
		///  Yield_Tree ��ȸ
		/// </summary>
		/// <param name="arg_factory">�����ڵ�</param>
		/// <param name="arg_stylecode">��Ÿ���ڵ�</param>
		/// <param name="arg_flag">��ȸ �÷��� ( 10:SHIP_YN, 20:PUR_SHIP_YN, 30:PUR_IMPORT_YN, 40:PUR_LOCAL_YN, PROD_YN ) </param>
		/// <param name="arg_item"></param>
		/// <returns></returns>
		public DataTable Select_YieldList(string arg_factory, string arg_stylecode, string arg_flag, string arg_item,string arg_comp)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE��
            MyOraDB.Process_Name = "pkg_sqm_cust.SELECT_SBC_YIELD_INFO_POP_LIKE";
 
			//02.ARGURMENT��
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_FLAG";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM";
            MyOraDB.Parameter_Name[4] = "ARG_COMP";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
			//04.DATA ����  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecode;
			MyOraDB.Parameter_Values[2] = arg_flag;
			MyOraDB.Parameter_Values[3] = arg_item;
            MyOraDB.Parameter_Values[4] = arg_comp;
			MyOraDB.Parameter_Values[5] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		/// <summary>
		/// PKG_SBP_REQUEST_HEAD : ��� ���� ã��
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

			//01.PROCEDURE��
			MyOraDB.Process_Name = "PKG_SBC_YIELD_VALUE.SELECT_SBC_SPEC_LIST";

			//02.ARGURMENT ��
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "ARG_TEMPLATE_SEQ";
			MyOraDB.Parameter_Name[5] = "ARG_TEMPLATE_LEVEL";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE ����
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA ����
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

        private void txtComponent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                DataTable dt_ret = Search_Component();
                COM.ComCtl.Set_ComboList(dt_ret, cmbComponent, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
	}
}



