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
	public class Pop_Formula_Register : COM.PCHWinForm.Pop_Medium
	{   
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private COM.FSP fgrid_YieldValue;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.Label lbl_Style;
		private COM.FSP fgrid_Formula;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.ContextMenu cmenu_Pop;
		private System.Windows.Forms.TextBox txt_Style_Nm;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.TextBox txt_Season;
		private System.Windows.Forms.TextBox txt_Year;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_Season;
		private System.Windows.Forms.Label lbl_Year;
		private System.Windows.Forms.Label lbl_Mcs;
		private System.Windows.Forms.TextBox txt_SemiGood;
		private System.Windows.Forms.Label lbl_SemiGood;
		private System.Windows.Forms.TextBox txt_Mcs_Cd;
		private System.Windows.Forms.TextBox txt_Mcs_Name;
		private System.Windows.Forms.TextBox txt_Mcs_Color_Name;
		private System.Windows.Forms.Label lbl_Formula;
		private System.Windows.Forms.Label btn_Mcs;
		private System.Windows.Forms.Label btn_Color;
		private C1.Win.C1List.C1Combo cmb_Formula_Type;
		private System.Windows.Forms.TextBox txt_Mcs_Color_Cd;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.MenuItem menu_Item_ins;
		private System.Windows.Forms.MenuItem menu_Item_del;
		private System.Windows.Forms.Button btn_StyleMcs;
		private System.Windows.Forms.Button btn_BaseMcs;
		private System.Windows.Forms.CheckBox chkKeep;
		private System.ComponentModel.IContainer components = null;

		public Pop_Formula_Register()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Formula_Register));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkKeep = new System.Windows.Forms.CheckBox();
			this.btn_StyleMcs = new System.Windows.Forms.Button();
			this.btn_BaseMcs = new System.Windows.Forms.Button();
			this.txt_Mcs_Color_Cd = new System.Windows.Forms.TextBox();
			this.cmb_Formula_Type = new C1.Win.C1List.C1Combo();
			this.lbl_Formula = new System.Windows.Forms.Label();
			this.txt_Mcs_Color_Name = new System.Windows.Forms.TextBox();
			this.txt_Mcs_Name = new System.Windows.Forms.TextBox();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.fgrid_Formula = new COM.FSP();
			this.cmenu_Pop = new System.Windows.Forms.ContextMenu();
			this.menu_Item_ins = new System.Windows.Forms.MenuItem();
			this.menu_Item_del = new System.Windows.Forms.MenuItem();
			this.txt_Mcs_Cd = new System.Windows.Forms.TextBox();
			this.lbl_Mcs = new System.Windows.Forms.Label();
			this.btn_Mcs = new System.Windows.Forms.Label();
			this.btn_Color = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_Style_Nm = new System.Windows.Forms.TextBox();
			this.txt_SemiGood = new System.Windows.Forms.TextBox();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.lbl_Season = new System.Windows.Forms.Label();
			this.lbl_SemiGood = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.txt_Season = new System.Windows.Forms.TextBox();
			this.txt_Year = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.lbl_Year = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.fgrid_YieldValue = new COM.FSP();
			this.btn_close = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.chkKeep);
			this.groupBox2.Controls.Add(this.btn_StyleMcs);
			this.groupBox2.Controls.Add(this.btn_BaseMcs);
			this.groupBox2.Controls.Add(this.txt_Mcs_Color_Cd);
			this.groupBox2.Controls.Add(this.cmb_Formula_Type);
			this.groupBox2.Controls.Add(this.lbl_Formula);
			this.groupBox2.Controls.Add(this.txt_Mcs_Color_Name);
			this.groupBox2.Controls.Add(this.txt_Mcs_Name);
			this.groupBox2.Controls.Add(this.lbl_Color);
			this.groupBox2.Controls.Add(this.fgrid_Formula);
			this.groupBox2.Controls.Add(this.txt_Mcs_Cd);
			this.groupBox2.Controls.Add(this.lbl_Mcs);
			this.groupBox2.Controls.Add(this.btn_Mcs);
			this.groupBox2.Controls.Add(this.btn_Color);
			this.groupBox2.Location = new System.Drawing.Point(5, 95);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 321);
			this.groupBox2.TabIndex = 541;
			this.groupBox2.TabStop = false;
			// 
			// chkKeep
			// 
			this.chkKeep.Location = new System.Drawing.Point(666, 39);
			this.chkKeep.Name = "chkKeep";
			this.chkKeep.Size = new System.Drawing.Size(16, 24);
			this.chkKeep.TabIndex = 681;
			// 
			// btn_StyleMcs
			// 
			this.btn_StyleMcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_StyleMcs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_StyleMcs.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_StyleMcs.Location = new System.Drawing.Point(461, 37);
			this.btn_StyleMcs.Name = "btn_StyleMcs";
			this.btn_StyleMcs.Size = new System.Drawing.Size(100, 23);
			this.btn_StyleMcs.TabIndex = 679;
			this.btn_StyleMcs.Text = "Style Formula";
			this.btn_StyleMcs.Click += new System.EventHandler(this.btn_StyleMcs_Click);
			// 
			// btn_BaseMcs
			// 
			this.btn_BaseMcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_BaseMcs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_BaseMcs.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_BaseMcs.Location = new System.Drawing.Point(563, 37);
			this.btn_BaseMcs.Name = "btn_BaseMcs";
			this.btn_BaseMcs.Size = new System.Drawing.Size(100, 23);
			this.btn_BaseMcs.TabIndex = 678;
			this.btn_BaseMcs.Text = "Base Formula";
			this.btn_BaseMcs.Click += new System.EventHandler(this.btn_BaseMcs_Click);
			// 
			// txt_Mcs_Color_Cd
			// 
			this.txt_Mcs_Color_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Mcs_Color_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Color_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Mcs_Color_Cd.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Mcs_Color_Cd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Color_Cd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Mcs_Color_Cd.Location = new System.Drawing.Point(107, 35);
			this.txt_Mcs_Color_Cd.MaxLength = 10;
			this.txt_Mcs_Color_Cd.Name = "txt_Mcs_Color_Cd";
			this.txt_Mcs_Color_Cd.Size = new System.Drawing.Size(120, 21);
			this.txt_Mcs_Color_Cd.TabIndex = 677;
			this.txt_Mcs_Color_Cd.Text = "";
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
			this.cmb_Formula_Type.Location = new System.Drawing.Point(560, 14);
			this.cmb_Formula_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_Formula_Type.MaxDropDownItems = ((short)(5));
			this.cmb_Formula_Type.MaxLength = 32767;
			this.cmb_Formula_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Formula_Type.Name = "cmb_Formula_Type";
			this.cmb_Formula_Type.PartialRightColumn = false;
			this.cmb_Formula_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
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
			this.cmb_Formula_Type.Size = new System.Drawing.Size(120, 21);
			this.cmb_Formula_Type.TabIndex = 675;
			this.cmb_Formula_Type.TextChanged += new System.EventHandler(this.cmb_Formula_TextChanged);
			// 
			// lbl_Formula
			// 
			this.lbl_Formula.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Formula.ImageIndex = 1;
			this.lbl_Formula.ImageList = this.img_Label;
			this.lbl_Formula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Formula.Location = new System.Drawing.Point(460, 14);
			this.lbl_Formula.Name = "lbl_Formula";
			this.lbl_Formula.Size = new System.Drawing.Size(100, 21);
			this.lbl_Formula.TabIndex = 674;
			this.lbl_Formula.Text = "Formula Div.";
			this.lbl_Formula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Mcs_Color_Name
			// 
			this.txt_Mcs_Color_Name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mcs_Color_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Color_Name.Enabled = false;
			this.txt_Mcs_Color_Name.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Color_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Mcs_Color_Name.Location = new System.Drawing.Point(228, 35);
			this.txt_Mcs_Color_Name.MaxLength = 10;
			this.txt_Mcs_Color_Name.Name = "txt_Mcs_Color_Name";
			this.txt_Mcs_Color_Name.ReadOnly = true;
			this.txt_Mcs_Color_Name.Size = new System.Drawing.Size(200, 21);
			this.txt_Mcs_Color_Name.TabIndex = 671;
			this.txt_Mcs_Color_Name.Text = "";
			// 
			// txt_Mcs_Name
			// 
			this.txt_Mcs_Name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mcs_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Name.Enabled = false;
			this.txt_Mcs_Name.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Mcs_Name.Location = new System.Drawing.Point(228, 13);
			this.txt_Mcs_Name.MaxLength = 10;
			this.txt_Mcs_Name.Name = "txt_Mcs_Name";
			this.txt_Mcs_Name.ReadOnly = true;
			this.txt_Mcs_Name.Size = new System.Drawing.Size(200, 21);
			this.txt_Mcs_Name.TabIndex = 670;
			this.txt_Mcs_Name.Text = "";
			// 
			// lbl_Color
			// 
			this.lbl_Color.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Color.ImageIndex = 1;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Color.Location = new System.Drawing.Point(7, 35);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 666;
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Formula
			// 
			this.fgrid_Formula.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Formula.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Formula.ContextMenu = this.cmenu_Pop;
			this.fgrid_Formula.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Formula.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Formula.Location = new System.Drawing.Point(8, 64);
			this.fgrid_Formula.Name = "fgrid_Formula";
			this.fgrid_Formula.Size = new System.Drawing.Size(672, 248);
			this.fgrid_Formula.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Formula.TabIndex = 660;
			this.fgrid_Formula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgrid_Formula_KeyUp);
			// 
			// cmenu_Pop
			// 
			this.cmenu_Pop.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menu_Item_ins,
																					  this.menu_Item_del});
			// 
			// menu_Item_ins
			// 
			this.menu_Item_ins.Index = 0;
			this.menu_Item_ins.Text = "Item Register";
			this.menu_Item_ins.Click += new System.EventHandler(this.menu_Item_Click);
			// 
			// menu_Item_del
			// 
			this.menu_Item_del.Index = 1;
			this.menu_Item_del.Text = "Item Delete";
			this.menu_Item_del.Click += new System.EventHandler(this.menu_Item_del_Click);
			// 
			// txt_Mcs_Cd
			// 
			this.txt_Mcs_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Mcs_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Cd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Mcs_Cd.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_Mcs_Cd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Mcs_Cd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Mcs_Cd.Location = new System.Drawing.Point(107, 13);
			this.txt_Mcs_Cd.MaxLength = 10;
			this.txt_Mcs_Cd.Name = "txt_Mcs_Cd";
			this.txt_Mcs_Cd.Size = new System.Drawing.Size(120, 21);
			this.txt_Mcs_Cd.TabIndex = 655;
			this.txt_Mcs_Cd.Text = "";
			// 
			// lbl_Mcs
			// 
			this.lbl_Mcs.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Mcs.ImageIndex = 1;
			this.lbl_Mcs.ImageList = this.img_Label;
			this.lbl_Mcs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Mcs.Location = new System.Drawing.Point(7, 13);
			this.lbl_Mcs.Name = "lbl_Mcs";
			this.lbl_Mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs.TabIndex = 658;
			this.lbl_Mcs.Text = "Mcs  ";
			this.lbl_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Mcs
			// 
			this.btn_Mcs.ImageIndex = 27;
			this.btn_Mcs.ImageList = this.img_SmallButton;
			this.btn_Mcs.Location = new System.Drawing.Point(428, 13);
			this.btn_Mcs.Name = "btn_Mcs";
			this.btn_Mcs.Size = new System.Drawing.Size(21, 21);
			this.btn_Mcs.TabIndex = 668;
			this.btn_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Mcs.Click += new System.EventHandler(this.btn_Mcs_Click);
			// 
			// btn_Color
			// 
			this.btn_Color.ImageIndex = 27;
			this.btn_Color.ImageList = this.img_SmallButton;
			this.btn_Color.Location = new System.Drawing.Point(428, 35);
			this.btn_Color.Name = "btn_Color";
			this.btn_Color.Size = new System.Drawing.Size(21, 21);
			this.btn_Color.TabIndex = 669;
			this.btn_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txt_Style_Nm);
			this.groupBox1.Controls.Add(this.txt_SemiGood);
			this.groupBox1.Controls.Add(this.txt_Style_Cd);
			this.groupBox1.Controls.Add(this.lbl_Season);
			this.groupBox1.Controls.Add(this.lbl_SemiGood);
			this.groupBox1.Controls.Add(this.lbl_Style);
			this.groupBox1.Controls.Add(this.txt_Season);
			this.groupBox1.Controls.Add(this.txt_Year);
			this.groupBox1.Controls.Add(this.lbl_Factory);
			this.groupBox1.Controls.Add(this.txt_Factory);
			this.groupBox1.Controls.Add(this.lbl_Year);
			this.groupBox1.Location = new System.Drawing.Point(5, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 64);
			this.groupBox1.TabIndex = 540;
			this.groupBox1.TabStop = false;
			// 
			// txt_Style_Nm
			// 
			this.txt_Style_Nm.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Style_Nm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Nm.Enabled = false;
			this.txt_Style_Nm.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style_Nm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Style_Nm.Location = new System.Drawing.Point(228, 36);
			this.txt_Style_Nm.MaxLength = 10;
			this.txt_Style_Nm.Name = "txt_Style_Nm";
			this.txt_Style_Nm.ReadOnly = true;
			this.txt_Style_Nm.Size = new System.Drawing.Size(224, 21);
			this.txt_Style_Nm.TabIndex = 546;
			this.txt_Style_Nm.Text = "";
			// 
			// txt_SemiGood
			// 
			this.txt_SemiGood.BackColor = System.Drawing.SystemColors.Window;
			this.txt_SemiGood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SemiGood.Enabled = false;
			this.txt_SemiGood.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_SemiGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_SemiGood.Location = new System.Drawing.Point(560, 36);
			this.txt_SemiGood.MaxLength = 10;
			this.txt_SemiGood.Name = "txt_SemiGood";
			this.txt_SemiGood.ReadOnly = true;
			this.txt_SemiGood.Size = new System.Drawing.Size(120, 21);
			this.txt_SemiGood.TabIndex = 545;
			this.txt_SemiGood.Text = "";
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Enabled = false;
			this.txt_Style_Cd.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Style_Cd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Style_Cd.Location = new System.Drawing.Point(107, 36);
			this.txt_Style_Cd.MaxLength = 10;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.ReadOnly = true;
			this.txt_Style_Cd.Size = new System.Drawing.Size(120, 21);
			this.txt_Style_Cd.TabIndex = 544;
			this.txt_Style_Cd.Text = "";
			// 
			// lbl_Season
			// 
			this.lbl_Season.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Season.ImageIndex = 0;
			this.lbl_Season.ImageList = this.img_Label;
			this.lbl_Season.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Season.Location = new System.Drawing.Point(460, 14);
			this.lbl_Season.Name = "lbl_Season";
			this.lbl_Season.Size = new System.Drawing.Size(100, 21);
			this.lbl_Season.TabIndex = 543;
			this.lbl_Season.Text = "Season";
			this.lbl_Season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SemiGood
			// 
			this.lbl_SemiGood.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_SemiGood.ImageIndex = 0;
			this.lbl_SemiGood.ImageList = this.img_Label;
			this.lbl_SemiGood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_SemiGood.Location = new System.Drawing.Point(460, 36);
			this.lbl_SemiGood.Name = "lbl_SemiGood";
			this.lbl_SemiGood.Size = new System.Drawing.Size(100, 21);
			this.lbl_SemiGood.TabIndex = 542;
			this.lbl_SemiGood.Text = "SemiGood";
			this.lbl_SemiGood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Style.Location = new System.Drawing.Point(8, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 541;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Season
			// 
			this.txt_Season.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Season.Enabled = false;
			this.txt_Season.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Season.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Season.Location = new System.Drawing.Point(560, 14);
			this.txt_Season.MaxLength = 10;
			this.txt_Season.Name = "txt_Season";
			this.txt_Season.ReadOnly = true;
			this.txt_Season.Size = new System.Drawing.Size(120, 21);
			this.txt_Season.TabIndex = 540;
			this.txt_Season.Text = "";
			// 
			// txt_Year
			// 
			this.txt_Year.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Year.Enabled = false;
			this.txt_Year.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Year.Location = new System.Drawing.Point(332, 14);
			this.txt_Year.MaxLength = 10;
			this.txt_Year.Name = "txt_Year";
			this.txt_Year.ReadOnly = true;
			this.txt_Year.Size = new System.Drawing.Size(120, 21);
			this.txt_Year.TabIndex = 539;
			this.txt_Year.Text = "";
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Factory.Location = new System.Drawing.Point(7, 14);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 537;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_Factory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Factory.Location = new System.Drawing.Point(107, 14);
			this.txt_Factory.MaxLength = 10;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(120, 21);
			this.txt_Factory.TabIndex = 534;
			this.txt_Factory.Text = "";
			// 
			// lbl_Year
			// 
			this.lbl_Year.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_Year.ImageIndex = 0;
			this.lbl_Year.ImageList = this.img_Label;
			this.lbl_Year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbl_Year.Location = new System.Drawing.Point(232, 14);
			this.lbl_Year.Name = "lbl_Year";
			this.lbl_Year.Size = new System.Drawing.Size(100, 21);
			this.lbl_Year.TabIndex = 538;
			this.lbl_Year.Text = "Year";
			this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.fgrid_YieldValue);
			this.groupBox3.Location = new System.Drawing.Point(8, 424);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(685, 80);
			this.groupBox3.TabIndex = 542;
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
			this.fgrid_YieldValue.Size = new System.Drawing.Size(672, 58);
			this.fgrid_YieldValue.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_YieldValue.TabIndex = 0;
			this.fgrid_YieldValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_YieldValue_MouseUp);
			this.fgrid_YieldValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_YieldValue_KeyDown);
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_close.ImageIndex = 0;
			this.btn_close.ImageList = this.img_Button;
			this.btn_close.Location = new System.Drawing.Point(617, 512);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(70, 24);
			this.btn_close.TabIndex = 544;
			this.btn_close.Text = "Cancel";
			this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(539, 512);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 543;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_Formula_Register
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 544);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Name = "Pop_Formula_Register";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.Controls.SetChildIndex(this.btn_close, 0);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Formula)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldValue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의 

		#region 기본 변수
		int _Rowfixed = 2;
		private COM.OraDB _MyOraDB = new COM.OraDB();
		#endregion
		
		#region 초기 설정
		string _CompLevel = "2",     _MatLevel ="3",       _Blank ="None",     _BlankText=" ", 
			   _MateialType  = "M",  _CompType ="C",       _Formula="B", 	   _Flag  ="True" ,
			   _InitValue = "0",     _Seq="0",             _StyleCd="",        _CheckNo ="N";

		#endregion
				
		#region 사이즈별 채산값 기본 설정
		int _Row_EYield, _Row_MYield, _Row_SpecCd, _Row_SpecName , _Row_YieldValue ;
		int _ColFixed = 2;

		string _YieldTypeE_Desc = "Yield (E)";
		string _YieldTypeM_Desc = "Yield (M)";
		string _SpecCd_Desc = "Spec. Cd";
		string _Spec_Desc = "Spec.";	
		string _YieldType  = "E";
		string _YieldTypeE = "E";
		string _YieldTypeM = "M";
		string _Size_YN    = "N";
		DataTable _Dt_Size_Range; 
		#endregion

		#region 리턴 Data를 위한 변수
		public DataTable _Dt_Formula,  _Dt_Formula_Weight;
		#endregion

		#region 칼라 설정
		private Color _Base_Color    = ClassLib.ComVar.ClrSel_Green;
		private Color _Pigment_Color = ClassLib.ComVar.ClrSel_Yellow;
		private Color _SizeColor1    = ClassLib.ComVar.ClrSel_Green;
		private Color _SizeColor2    = ClassLib.ComVar.ClrSel_Yellow;

	
		#endregion

		#region  행 이미지 저장
		private Hashtable _Imgmap = new Hashtable();
		private Hashtable _ImgmapAction = new Hashtable();

		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";

		private int _IxImage_SG = 1, _IxImage_Cmp = 2, _IxImage_Mat = 3, _IxImage_Joint = 4;
		//private int _IxImage_Move = 5; 
 

		#endregion
		
		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{

			
			//Title
			this.Text = "Formula Register";
			lbl_MainTitle.Text = "   Formula Register";
			ClassLib.ComFunction.SetLangDic(this);

			#region 그리드 설정(TBSBC_FORMULAN_COPY)
			fgrid_Formula.Set_Grid_Comm("SBC_FOMULAN_COPY", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			fgrid_Formula.Set_Action_Image(img_Action);
			fgrid_Formula.Cols[0].AllowEditing = false;

			fgrid_YieldValue.Set_Grid("SBC_YIELD_VALUE", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_YieldValue.SelectionMode = SelectionModeEnum.CellRange;

			fgrid_Formula.Rows.Count = _Rowfixed;
			fgrid_Formula.Tree.Column = (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME;


			#endregion

			
			//속성, 사이즈칼럼, 채산값입력 기본 Setting
			SetProperty();	

			fgrid_YieldValue.Display_Size_ColHead(txt_Factory.Text, txt_Style_Cd.Text , 60, (int)ClassLib.TBSBC_YIELD_VALUE_POPUP.IxCS_SIZE_START);
			Add_fgrid_YieldValue_Default_Row();
			//YieldValue
			SetFormulaWeight();

			//Return Datatable설정
			Set_Return_DataTable();

			chkKeep.Checked  = true;


		}


		/// <summary>
		/// Set_Return_DataTable : 메인창으로 리턴될 데이터 테이블 Setting
		/// </summary>
		public void Set_Return_DataTable()
		{
			_Dt_Formula = new DataTable("_Dt_Formula");
			_Dt_Formula_Weight  = new DataTable("_Dt_Formula_Weight");

			// 메인 데이터 
			for(int i =(int)ClassLib.TBSBC_FORMULAN_YIELD.lxLEVEL  ; i <= (int)ClassLib.TBSBC_FORMULAN_YIELD.lxPROD_LOSS_RATE ; i++)
			{
				_Dt_Formula.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}

			
			// 사이즈 데이터
			// 키 값이 되는 컬럼
			//			_Dt_Formula.Columns.Add(new DataColumn("TEMPLATE_LEVEL", typeof(string)));
			//			_Dt_Formula_Weight .Columns.Add(new DataColumn("ITEM_CD", typeof(string)));

			for(int i =_ColFixed; i <= fgrid_YieldValue.Cols.Count-1; i++)
			{
				_Dt_Formula_Weight.Columns.Add(new DataColumn(i.ToString(), typeof(string)));
			}
			

		}


		/// <summary>
		/// SetProperty: Formula Head Setting
		/// </summary>
		private void  SetProperty()
		{
			try
			{ 
				//Formula..
				DataTable dt_list;
				dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,ClassLib.ComVar.CxFormulaDiv);
				ClassLib.ComCtl.Set_ComboList(dt_list,cmb_Formula_Type , 1, 2, false, false);
				cmb_Formula_Type.SelectedValue  = _Formula;
				dt_list.Dispose();

				txt_Factory.Text  = COM.ComVar.Parameter_PopUp[0];
				txt_Year.Text     = COM.ComVar.Parameter_PopUp[1];
				txt_Season.Text   = COM.ComVar.Parameter_PopUp[2];
				txt_Style_Cd.Text = COM.ComVar.Parameter_PopUp[3];
				txt_Style_Nm.Text = COM.ComVar.Parameter_PopUp[4];
				txt_SemiGood.Text = COM.ComVar.Parameter_PopUp[5];
				txt_Mcs_Cd.Text          = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[6],_BlankText);
				txt_Mcs_Color_Cd.Text    = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[7],_BlankText);
				txt_Mcs_Name.Text        = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[8],_BlankText);
				txt_Mcs_Color_Name.Text  = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[9],_BlankText);
				_Seq			         = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[10],_BlankText);
				_Formula 		         = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[11],_BlankText);
				_YieldType               = COM.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[12],_BlankText);

				//Formula 자료 조회
				_StyleCd  = txt_Style_Cd.Text;
				SetFormula();		


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetInit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		/// Display_Type_Image : 이미지 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Type_Image(int arg_row) 
		{

			if(_Imgmap.ContainsKey(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString() ) ) return;

			switch(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString() )
					//switch(fgrid_Yield[arg_row, (int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ToString() )
			{ 		
				case _TypeSG:  
					fgrid_Formula.GetCellRange(arg_row, 1, arg_row, fgrid_Formula.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_SG]); 
					break;

				case _TypeCmp:  
					fgrid_Formula.GetCellRange(arg_row, 1, arg_row, fgrid_Formula.Cols.Count - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Cmp]); 
					break;

				case _TypeMat:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Mat]);
					break;
				
				case _TypeJoint:
					_Imgmap.Add(fgrid_Formula[arg_row, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString(), img_Type.Images[_IxImage_Joint]);
					break;
 
			} // end switch
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

		/// <summary>
		///  SetFormula: Formula Setting
		/// </summary>
		/// <returns></returns>
		private void SetFormula()
		{
			try
			{

				DataTable dt_ret;

				//if CheckSelectFormula()
				dt_ret = SelectFormula();

				if ((dt_ret == null)||(dt_ret.Rows.Count  == 0)  ) 
				{// ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch); 
						
					
					return;
				}

				DisPlayFormula(dt_ret);

				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		// <summary>
		/// CheckItemList() : Item Return값의 정합성 검증
		/// </summary>
		/// <returns>bool</returns>
		private bool CheckItemList()
		{
			try
			{

				if (COM.ComVar.Parameter_PopUp[0].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Item Shoulb be selected..");
					return false; 
				}
				

				if (COM.ComVar.Parameter_PopUp[2].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Spec Shoulb be selected..");
					return false; 				
				}


				if (COM.ComVar.Parameter_PopUp[4].ToString().Length == 0) 
				{
					ClassLib.ComFunction.User_Message("Color Shoulb be selected..");
					return false; 
				}
				
				//Formula별 동일 자재가 존재시 중복 검증
				for (int i  = _Rowfixed   ;  i< fgrid_Formula.Rows.Count  ;i++)
				{
					
					string  sOldItem = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString() +
									   fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString() +
									   fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString() +
									   fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString() ;

					
					
					string  sNewItem = COM.ComVar.Parameter_PopUp[0]+
									   COM.ComVar.Parameter_PopUp[2]+
									   COM.ComVar.Parameter_PopUp[4]+
									   cmb_Formula_Type.SelectedValue.ToString();


					if (sOldItem  == sNewItem )
					{
						ClassLib.ComFunction.User_Message("Duplication Check");
						return false;
					}

				}

				return true;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckItemList", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false; 
			}
		}


		
		/// <summary>
		///  DisPlayItem() : Item  Setting
		/// </summary>
		/// <returns></returns>
		private void DisPlayItem()
		{
			try
			{
				

				if (CheckItemList() != true) return;

				int iR1  = fgrid_Formula.Selection.r1;

				fgrid_Formula.Rows.InsertNode(iR1+1,Convert.ToInt32(_MatLevel));
				
				fgrid_Formula.Select(fgrid_Formula.Selection.r1, 0, fgrid_Formula.Selection.r1, fgrid_Formula.Cols.Count-1,false);
				fgrid_Formula.Select(fgrid_Formula.Selection.r1+1, 0, fgrid_Formula.Selection.r1+1, fgrid_Formula.Cols.Count-1,true);

				int iR2  = fgrid_Formula.Selection.r1;
				_Seq = ( (fgrid_Formula.Selection.r1>fgrid_Formula.Rows.Fixed  + 2)?
					fgrid_Formula[fgrid_Formula.Rows.Fixed  + 1,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEQ].ToString():" ");

				#region  칼럼값
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL]          = _MatLevel;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]    = txt_Mcs_Cd.Text+txt_Mcs_Color_Cd.Text
					+ _Formula + COM.ComVar.Parameter_PopUp[0]
					+ COM.ComVar.Parameter_PopUp[4];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION]  = _MateialType ; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV]    = cmb_Formula_Type.SelectedValue.ToString() ;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxJOB_FLAG]       = _Flag; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME]      = COM.ComVar.Parameter_PopUp[1];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME]      = COM.ComVar.Parameter_PopUp[3];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME]	  = COM.ComVar.Parameter_PopUp[5];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxUNIT]			  = COM.ComVar.Parameter_PopUp[6];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD]		  = COM.ComVar.Parameter_PopUp[0];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD]		  = COM.ComVar.Parameter_PopUp[2];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD]		  = COM.ComVar.Parameter_PopUp[4];
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA]		  = _InitValue;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX]			  = _InitValue;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFACTORY]		  = txt_Factory.Text;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEQ]			  = _Seq; 
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_YEAR]   = txt_Year.Text;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEASON_CD]      = txt_Season.Text;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSTYLE_CD]       = txt_Style_Cd.Text;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_CD]         = txt_Mcs_Cd.Text;
				fgrid_Formula[iR2,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_COLOR_CD]   = txt_Mcs_Color_Cd.Text;			
				#endregion

				MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);
			
				#region 그림이미지
				_Imgmap.Clear();

				for(int i = _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
				{
					Display_Type_Image(i);

				}
  
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
				fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  

				#endregion

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "CheckItemList", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

				COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComFunction.Empty_TextBox(txt_Factory ," ");


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
		/// SetMcs: Mcs Setting
		/// </summary>
		private void  SetMcs()
		{
			try
			{   
				FlexBase.MaterialBase.Pop_Mcs pop_Form = new  FlexBase.MaterialBase.Pop_Mcs();
		
				COM.ComVar.Parameter_PopUp = new string[] 
					{};
						
				pop_Form.ShowDialog();

				txt_Mcs_Cd.Text   = COM.ComVar.Parameter_PopUp[0]; 
				txt_Mcs_Name.Text = COM.ComVar.Parameter_PopUp[1]; 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}



		
		/// <summary>
		/// SetMcsColor :McsColor Setting
		/// </summary>
		private void  SetMcsColor()
		{
			try
			{   

					FlexBase.MaterialBase.Pop_Mcs_Color Pop_Mcs_Color = new  FlexBase.MaterialBase.Pop_Mcs_Color();
		
					COM.ComVar.Parameter_PopUp = new string[] 
					{};
						
					Pop_Mcs_Color.ShowDialog();
	
					txt_Mcs_Color_Cd.Text   = COM.ComVar.Parameter_PopUp[0]; 
					txt_Mcs_Color_Name.Text = COM.ComVar.Parameter_PopUp[1]; 
	
	
					SetFormula();	
					SetFormulaWeight();

                    if (chkKeep.Checked  != true) 
					{
						 
						//Formula 자재 구성 재설정
						fgrid_Formula.Rows.Count = _Rowfixed;
						if (fgrid_Formula.Rows.Count == _Rowfixed )   //반제기본 설정
						{
							int vLevel = Convert.ToInt32(_CompLevel);
			
							fgrid_Formula.Rows.InsertNode(_Rowfixed, vLevel);
								
							for (int i=(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL; i< fgrid_Formula.Cols.Count  ;i++)
							{
								fgrid_Formula[fgrid_Formula.Rows.Count-1, i] =_BlankText;
							}
			
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL] = _CompLevel;
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]   = txt_Mcs_Cd.Text  + txt_Mcs_Color_Cd.Text;
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION]  = _CompType;
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD]   = _BlankText;
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD]  = _BlankText;
							fgrid_Formula[fgrid_Formula.Rows.Count-1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME]     
								=  txt_Mcs_Name.Text  +"-" + txt_Mcs_Color_Name.Text;
						}
					}
					else
					{
                        //기존의 자재 구성 유지
						fgrid_Formula[_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME] = txt_Mcs_Name.Text +"-"+ txt_Mcs_Color_Name.Text;

						for (int i = _Rowfixed+1 ;i<fgrid_Formula.Rows.Count ; i++)
						{  					
							string sOldMcs = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ToString().Substring(0,10);
							string sNewMcs = txt_Mcs_Cd.Text +txt_Mcs_Color_Cd.Text ;
							string sInfoKey = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY].ToString().Replace(sOldMcs,sNewMcs);;
							fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCSINFO_KEY]    = sInfoKey;
							fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_CD]         = txt_Mcs_Cd.Text;
							fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMCS_COLOR_CD]   = txt_Mcs_Color_Cd.Text;		

							return;
						}

						#region 그림이미지
						_Imgmap.Clear();

						for(int i = _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
						{
							Display_Type_Image(i);

						}
	  
						fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
						fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  

						#endregion


					}


			}
			catch(Exception )
			{
				ClassLib.ComFunction.User_Message("No Color Code", "SetMcsColor", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}






		
		/// <summary>
		/// SetStyleMcs :Style별 McsColor Setting
		/// </summary>
		private void  SetStyleMcs(string arg_Base)
		{
			try
			{   //arguemnt를 넘겨서 Color Tab으로 바로 Setting하기..
				string  vStyle_Cd = (arg_Base == ClassLib.ComVar.ConsTrue)?ClassLib.ComVar.ConsBaseStyle:txt_Style_Cd.Text;

				COM.ComVar.Parameter_PopUp = new string[] 
						{
							txt_Factory.Text,
							txt_Year.Text,
							txt_Season.Text ,
							vStyle_Cd
						};
						 
				FlexBase.Yield.Pop_Style_Mcs Pop_Style_Mcs = new  FlexBase.Yield.Pop_Style_Mcs();
				Pop_Style_Mcs.ShowDialog();

				txt_Mcs_Cd.Text         = COM.ComVar.Parameter_PopUp[0]; 
				txt_Mcs_Name.Text       = COM.ComVar.Parameter_PopUp[1]; 
				txt_Mcs_Color_Cd.Text   = COM.ComVar.Parameter_PopUp[2]; 
				txt_Mcs_Color_Name.Text = COM.ComVar.Parameter_PopUp[3]; 

				if (arg_Base == ClassLib.ComVar.ConsTrue) 
                 _StyleCd  = ClassLib.ComVar.ConsBaseStyle;
				else
				 _StyleCd  = COM.ComVar.Parameter_PopUp[4];

                
				if ( COM.ComVar.Parameter_PopUp[5] == ClassLib.ComVar.ConsTrue) 
				{   
					fgrid_Formula.Rows.Count  = fgrid_Formula.Rows.Fixed;
					SetFormula();	
					SetFormulaWeight();

					fgrid_Formula.Select(fgrid_Formula.Rows.Fixed + 1, 0, fgrid_Formula.Rows.Fixed + 1, fgrid_Formula.Cols.Count - 1, false);
					
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetStyleMcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


	



		/// <summary>
		///  DisPlayFormula: Formula 뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayFormula(DataTable arg_dt)
		{
			fgrid_Formula.Rows.Count = _Rowfixed;
			fgrid_Formula.Tree.Column = (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME;

			for (int i =0; i < arg_dt.Rows.Count ; i++)
			{
				
				int vLevel = Convert.ToInt32(arg_dt.Rows[i].ItemArray[0].ToString());

				fgrid_Formula.Rows.InsertNode(i+ _Rowfixed, vLevel);
                
				
				//그리드수와 데이타셋의 칼럼수가 틀림
				for (int  j=0 ;j<arg_dt.Columns.Count ;j++)
				{  					
					if (arg_dt.Rows[i].ItemArray[j] == null)  break;
					fgrid_Formula[i+ _Rowfixed,j+1] =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[j].ToString()," ");
				}
			}

			
			#region 그림이미지
			_Imgmap.Clear();

			for(int i = _Rowfixed; i < fgrid_Formula.Rows.Count; i++)
			{
				Display_Type_Image(i);

			}
  
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageAndText = true; 
			fgrid_Formula.Cols[(int)ClassLib.TBSBC_FORMULAN_YIELD.lxTREE].ImageMap     = _Imgmap;  

			#endregion
					
	        fgrid_Formula.Select(fgrid_Formula.Rows.Fixed + 2, 0, fgrid_Formula.Rows.Fixed + 2, fgrid_Formula.Cols.Count-1,false);

			//Subtotal
			MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);

		}


		/// <summary>
		///  SetFormulaWeight: FormulaWeigt 뿌리기
		/// </summary>
		/// <returns></returns>
		private void SetFormulaWeight()
		{
			try
			{

				if((txt_Mcs_Cd.Text == _BlankText) ||(txt_Mcs_Cd.Text == _BlankText)) return;

				DataTable dt_ret;
				dt_ret = SelectFormulaWeight();
				DisPlayFormulaWeight(dt_ret);

				if (dt_ret.Rows.Count  == 0) 
				{
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch);
					//DisPlayFormulaWeight(dt_ret);
					return;
				}

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		///  DisPlayFormulaWeight: FormulaWeigt 뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayFormulaWeight(DataTable arg_dt)
		{
			if (txt_Style_Cd.Text  != _StyleCd) return;

			for (int  i=0 ;i<arg_dt.Rows.Count ;i++)
			{  					
				
				fgrid_YieldValue[_Row_EYield,_ColFixed+i]     =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[1].ToString(),Convert.ToString(_InitValue));
				fgrid_YieldValue[_Row_MYield,_ColFixed+i]     =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[2].ToString(),Convert.ToString(_InitValue));
				fgrid_YieldValue[_Row_SpecCd,_ColFixed+i]     =  _Blank;
				fgrid_YieldValue[_Row_SpecName,_ColFixed+i]   =  _Blank;	
			}

			SetValueColor();
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
		///  MakeSubTotal: Mix/Weight Subtotal 만들기
		/// </summary>
		/// <returns></returns>
		private void MakeSubTotal(int arg_set_row, int arg_formula_col, int arg_mix_col)
		{
			
			double  iTotalFormula  =  0;
			double  iTotalMix      =100;
			double  iRemMix        =  0; 
			

			
			for (int i =_Rowfixed+1; i < fgrid_Formula.Rows.Count ; i++)
			{
				if (fgrid_Formula[i, arg_formula_col]== null)  break;

				iTotalFormula = iTotalFormula +  Convert.ToDouble(fgrid_Formula[i,arg_formula_col].ToString());
			}

			fgrid_Formula[arg_set_row , arg_formula_col] = iTotalFormula;
			fgrid_Formula[arg_set_row , arg_mix_col]     = iTotalMix;
			
			
			for (int i =_Rowfixed+1; i < fgrid_Formula.Rows.Count ; i++)
			{
				if (fgrid_Formula[i, arg_mix_col]== null)  break;

				// Row별  Mix 값Setting
			    iTotalFormula = (iTotalFormula == 0)?1: iTotalFormula;
				fgrid_Formula[i , arg_mix_col] = Math.Round(Convert.ToDouble(fgrid_Formula[i, arg_formula_col].ToString()) /iTotalFormula*100,3);


				//마지막 Row의  Mix값 Setting 				
				iRemMix  =iRemMix + Math.Round(((i<fgrid_Formula.Rows.Count -1)?Convert.ToDouble(fgrid_Formula[i , arg_mix_col].ToString()):0),3);
				fgrid_Formula[fgrid_Formula.Rows.Count -1 , arg_mix_col]  = Math.Round(iTotalMix - iRemMix,3);
				
				//칼라 Setting
				fgrid_Formula.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV).StyleNew.BackColor = 
					(fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString() == _Formula)?_Base_Color:_Pigment_Color;

								
				//칼라 Setting
				fgrid_Formula.GetCellRange(i, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA).StyleNew.ForeColor  = ClassLib.ComVar.ClrFormulaEdit;
					


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

				//-------------------------------------------------------------------------------------------------------------------
				//필수 항목 체크
				if(fgrid_Formula[fgrid_Formula.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Item", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if(fgrid_Formula[fgrid_Formula.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Sepcification", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if(fgrid_Formula[fgrid_Formula.Selection.r1, (int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString() == "")
				{
					ClassLib.ComFunction.User_Message("Select Color", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				string yield_type = _YieldType;
				string cs_size_f = fgrid_YieldValue[1, c1].ToString();
				string cs_size_t = fgrid_YieldValue[1, c2].ToString();
				string yield_value = (fgrid_YieldValue[_Row_YieldValue, c1] == null) ? "0" : fgrid_YieldValue[_Row_YieldValue, c1].ToString();

				string size_yn = _Size_YN;
				string item_speccd = fgrid_Formula[fgrid_Formula.Selection.r1, (int)ClassLib.TBSBC_YIELD_VALUE_TREE.IxSPEC_CD].ToString();
				string spec_div = fgrid_Formula[fgrid_Formula.Selection.r1,  (int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString().Substring(0,1);

				string spec_cd = fgrid_Formula[fgrid_Formula.Selection.r1,  (int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString();
 
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


		private void Return_Data()
		{

			try
			{


				if (Convert.ToString(fgrid_Formula[_Rowfixed, (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA]) == _InitValue )
				{
					ClassLib.ComFunction.User_Message("Fomula Weight Input ", "Fomula Weight Input ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				
				for (int j = _ColFixed  ; j < fgrid_YieldValue.Cols.Count ;  j++)
				{
					if (fgrid_YieldValue[_Row_YieldValue,j] == null) 
					{
						ClassLib.ComFunction.User_Message("Yield Value ", "MakeReturnFormulaWeight", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}

				if (fgrid_YieldValue.Cols.Count <= _Rowfixed+2) 
				{

					ClassLib.ComFunction.User_Message("No formula Data" , "Formula Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;

				}


				 MakeReturnFormula();

				MakeReturnFormulaWeight();

				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Return_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		/// <summary>
		///  MakeReturnFormula:  Return할 Formula Data만들기
		/// </summary>
		private void  MakeReturnFormula()
		{

			try
			{ 
				_Dt_Formula.Clear();

			    DataRow datarow = null;
 
				for (int i = _Rowfixed  ; i < fgrid_Formula.Rows.Count  ;  i++)
				{
					int j=0;

					datarow = _Dt_Formula.NewRow();

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxLEVEL].ToString();
					datarow[j++] = txt_SemiGood.Text + txt_Factory.Text +
								   txt_Year.Text.ToString().Substring(2,2) + 
								   txt_Season.Text.ToString()  + 
								   txt_Mcs_Cd.Text.ToString()  + 
								   txt_Mcs_Color_Cd.Text.ToString()	+
						           fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString()  +
						           fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString() + 
								   fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString() +
						           fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString();      //Key..

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxTYPE_DIVISION].ToString(); //Materia /Component
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString();
                    datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA_DIV].ToString();   //Formula div,Templete Level

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFACTORY].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSTYLE_CD].ToString();
					datarow[j++] = txt_SemiGood.Text;
					datarow[j++] = txt_Factory.Text + txt_Year.Text.ToString().Substring(2,2) + txt_Season.Text  + 
								   txt_Mcs_Cd.Text.ToString()  + 
								   txt_Mcs_Color_Cd.Text.ToString();											 //component code
					datarow[j++] = txt_Mcs_Name.Text  +" - "+ txt_Mcs_Color_Name.Text ;							 //component name

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSEQ].ToString();          //Templete seq
					datarow[j++] = txt_Mcs_Cd.Text;
					datarow[j++] = txt_Mcs_Name.Text;
					datarow[j++] = txt_Mcs_Color_Cd.Text;
					datarow[j++] = txt_Mcs_Color_Name.Text;

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_CD].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxITEM_NAME].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_CD].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSPEC_NAME].ToString();
					//datarow[j++] = txt_Mcs_Color_Cd.Text.ToString();
					//datarow[j++] = txt_Mcs_Color_Name.Text.ToString();

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_CD].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOLOR_NAME].ToString();

					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxUNIT].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA].ToString();
					datarow[j++] = fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX].ToString();

					
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSTYLE_ITEM_DIV   ] == null)? _BlankText:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOMMON_YN        ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOMMON_YN        ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxCOMMON_YN        ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSHIP_Y           ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSHIP_Y           ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_SHIP_YN      ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_SHIP_YN      ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_IMPORT_YN    ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_IMPORT_YN    ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_LOCAL_YN     ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_LOCAL_YN     ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_YN          ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_YN          ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_OP_CD       ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_OP_CD       ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_SEMI_GOOD_CD] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_SEMI_GOOD_CD].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxOUISIDE_IN_YN    ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxOUISIDE_IN_YN    ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxOUTSIDE_OUT_YN   ] == null)? _CheckNo:fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxOUTSIDE_OUT_YN   ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSHIP_LOSS_RATE   ] == null)? "0":fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxSHIP_LOSS_RATE   ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_LOSS_RATE    ] == null)? "0":fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPUR_LOSS_RATE    ].ToString();
					datarow[j++] =  (fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_LOSS_RATE   ] == null)? "0":fgrid_Formula[i,(int)ClassLib.TBSBC_FORMULAN_COPY.lxPROD_LOSS_RATE   ].ToString();
					

				    _Dt_Formula.Rows.Add(datarow);

				}				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MakeReturnFormula", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}


		/// <summary>
		///  MakeReturnFormulaWeight:  Return할 Formula Weight Data만들기
		/// </summary>		
		private void  MakeReturnFormulaWeight()
		{

			try
			{
				_Dt_Formula_Weight.Clear();

				DataRow datarow = null;
				
				for (int  i = _Rowfixed; i< fgrid_YieldValue.Rows.Count  ;i++)
				{
					datarow = _Dt_Formula_Weight.NewRow();
					
					for (int j = _ColFixed  ; j < fgrid_YieldValue.Cols.Count ;  j++)
					{
//						if (fgrid_YieldValue[_Row_YieldValue,j] == null) 
//						{
//							ClassLib.ComFunction.User_Message("Yield Value ", "MakeReturnFormulaWeight", MessageBoxButtons.OK, MessageBoxIcon.Error);
//							return;
//						}

						if( (i== _Row_EYield )  || (i== _Row_MYield ))
						{   //M,E동시 설정..
							
							datarow[j-_ColFixed] = fgrid_YieldValue[_Row_YieldValue,j].ToString();
						}
						else
						datarow[j-_ColFixed] = fgrid_YieldValue[i,j].ToString();
					}

					_Dt_Formula_Weight.Rows.Add(datarow);
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MakeReturnFormulaWeight", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}




		#endregion

		#region DB 컨넥트
		/// <summary>
		/// SelectFormula: Formula  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectFormula()
		{
		
			if ( (txt_Mcs_Cd.Text   == _BlankText ) ||  (txt_Mcs_Color_Cd.Text   == _BlankText ) ) return null;

			DataSet ds_ret; int iCnt;
			
			iCnt  =  7;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			if (_StyleCd == "000000000")
				_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA";
			else
				_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA_INFO";

 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_FORMULA_YEAR";
			_MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			_MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			_MyOraDB.Parameter_Name[4] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[5] = "ARG_MCS_COLOR_CD";
			_MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = txt_Factory.Text.ToString();
			_MyOraDB.Parameter_Values[1] = txt_Year.Text.ToString();
			_MyOraDB.Parameter_Values[2] = txt_Season.Text.ToString();
			_MyOraDB.Parameter_Values[3] = _StyleCd;
			_MyOraDB.Parameter_Values[4] = txt_Mcs_Cd.Text.ToString();
			_MyOraDB.Parameter_Values[5] = txt_Mcs_Color_Cd.Text.ToString();
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}


		
		/// <summary>
		/// SelectFormulaWeight: FormulaWeigt 조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectFormulaWeight()
		{

			DataSet ds_ret; int iCnt;
		
			iCnt  =  7;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_FORMULA.SELECT_SBC_FORMULA_WEIGHT";

			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			_MyOraDB.Parameter_Name[1] = "ARG_FORMULA_YEAR";
			_MyOraDB.Parameter_Name[2] = "ARG_SEASON_CD";
			_MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			_MyOraDB.Parameter_Name[4] = "ARG_MCS_CD";
			_MyOraDB.Parameter_Name[5] = "ARG_MCS_COLOR_CD";
			_MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = txt_Factory.Text.ToString();
			_MyOraDB.Parameter_Values[1] = txt_Year.Text.ToString();
			_MyOraDB.Parameter_Values[2] = txt_Season.Text.ToString();
			_MyOraDB.Parameter_Values[3] = _StyleCd;
			_MyOraDB.Parameter_Values[4] = txt_Mcs_Cd.Text.ToString();
			_MyOraDB.Parameter_Values[5] = txt_Mcs_Color_Cd.Text.ToString();
			_MyOraDB.Parameter_Values[6] = ""; 

			_MyOraDB.Add_Select_Parameter(true);

			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
		
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}



		#endregion

		#region 이벤트처리
		
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

		
		private void fgrid_Formula_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if((e.KeyCode  !=Keys.Enter)  ||  (fgrid_Formula.Selection.c1 != (int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA)) return;
			MakeSubTotal(_Rowfixed,(int)ClassLib.TBSBC_FORMULAN_COPY.lxFORMULA, (int)ClassLib.TBSBC_FORMULAN_COPY.lxMIX);
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


		private void cmb_Formula_TextChanged(object sender, System.EventArgs e)
		{
			_Formula = cmb_Formula_Type.SelectedValue.ToString();
		}


		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			Return_Data() ;
			
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Mcs_Click(object sender, System.EventArgs e)
		{
			
				SetMcs();

		}

		private void btn_Color_Click(object sender, System.EventArgs e)
		{
			SetMcsColor();
		}

		private void btn_BaseMcs_Click(object sender, System.EventArgs e)
		{
			_StyleCd  = ClassLib.ComVar.ConsBaseStyle;
			SetStyleMcs(ClassLib.ComVar.ConsTrue);
			
		}

		private void btn_StyleMcs_Click(object sender, System.EventArgs e)
		{
			_StyleCd  = txt_Style_Cd.Text;
			SetStyleMcs(ClassLib.ComVar.ConsFalse);
			
		}


		#endregion

		#region 콘텍스트 메뉴
		private void menu_Item_Click(object sender, System.EventArgs e)
		{ 
			SetItem();

			DisPlayItem();
		}


		private void menu_Item_del_Click(object sender, System.EventArgs e)
		{
			
			fgrid_Formula.Rows.Remove(fgrid_Formula.Selection.r1);

		}




		#endregion

	


	}
}

