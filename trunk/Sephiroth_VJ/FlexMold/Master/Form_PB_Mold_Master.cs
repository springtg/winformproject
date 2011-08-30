using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;


namespace FlexMold.Master
{
	public class Form_PB_Mold_Master : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Label lbl_parttype;
		private C1.Win.C1List.C1Combo cmb_parttype;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Label lbl_nikespeccd;
		private System.Windows.Forms.TextBox txt_nikespeccd;
		private System.Windows.Forms.Label lbl_moldcd;
		private System.Windows.Forms.TextBox txt_moldcd;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbl_cost_new;
		private System.Windows.Forms.Label lbl_currency_new;
		private System.Windows.Forms.Label lbl_moldmaterial_new;
		private System.Windows.Forms.TextBox txt_cost_new;
		private C1.Win.C1List.C1Combo cmb_currency_new;
		private C1.Win.C1List.C1Combo cmb_moldmaterial_new;
		private C1.Win.C1List.C1Combo cmb_gender_new;
		private System.Windows.Forms.Label lbl_gender_new;
		private C1.Win.C1List.C1Combo cmb_part_new;
		private System.Windows.Forms.Label lbl_part_new;
		private System.Windows.Forms.TextBox txt_remark_new;
		private System.Windows.Forms.Label lbl_remark_new;
		private System.Windows.Forms.TextBox txt_packing_new;
		private System.Windows.Forms.Label lbl_packing_new;
		private System.Windows.Forms.Label lbl_moldshop_new;
		private C1.Win.C1List.C1Combo cmb_moldshop_new;
		private C1.Win.C1List.C1Combo cmb_partmaterial_new;
		private System.Windows.Forms.Label lbl_partmaterial_new;
		private System.Windows.Forms.TextBox txt_developcd_new;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_lastcd_new;
		private System.Windows.Forms.Label lbl_lastcd_new;
		private C1.Win.C1List.C1Combo cmb_model_new;
		private System.Windows.Forms.Label lbl_model_new;
		private System.Windows.Forms.TextBox txt_nikespeccd_new;
		private System.Windows.Forms.Label lbl_nikespeccd_new;
		private System.Windows.Forms.TextBox txt_moldcd_new;
		private System.Windows.Forms.Label lbl_moldcd_new;
		private System.Windows.Forms.Label lbl_size_new;
		private C1.Win.C1List.C1Combo cmb_sizefrom_new;
		private C1.Win.C1List.C1Combo cmb_sizeto_new;
		private COM.FSP fgrid_size;
		private System.Windows.Forms.Label lbl_prs_new;
		private System.Windows.Forms.TextBox txt_prs_new;
		private System.Windows.Forms.Button btn_insert;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB OraDB = new COM.OraDB();
		private string _sizefrom;
		private string _sizeto;
		private string _prs;
		private int _cols =0;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private C1.Win.C1Command.C1CommandLink c1CommandLink10;
		private C1.Win.C1Command.C1ContextMenu cmenu_diagram;
		//private NETRONIC.XGantt.VcGantt vcGantt;
		private C1.Win.C1Command.C1Command c1Command1;
		private System.Windows.Forms.TextBox txt_style;
		private string [,] _sizelist;
		public Form_PB_Mold_Master()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Master));
			this.lbl_parttype = new System.Windows.Forms.Label();
			this.cmb_parttype = new C1.Win.C1List.C1Combo();
			this.fgrid_main = new COM.FSP();
			this.lbl_nikespeccd = new System.Windows.Forms.Label();
			this.txt_nikespeccd = new System.Windows.Forms.TextBox();
			this.lbl_moldcd = new System.Windows.Forms.Label();
			this.txt_moldcd = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbl_cost_new = new System.Windows.Forms.Label();
			this.lbl_currency_new = new System.Windows.Forms.Label();
			this.lbl_moldmaterial_new = new System.Windows.Forms.Label();
			this.txt_cost_new = new System.Windows.Forms.TextBox();
			this.cmb_currency_new = new C1.Win.C1List.C1Combo();
			this.cmb_moldmaterial_new = new C1.Win.C1List.C1Combo();
			this.cmb_gender_new = new C1.Win.C1List.C1Combo();
			this.lbl_gender_new = new System.Windows.Forms.Label();
			this.cmb_part_new = new C1.Win.C1List.C1Combo();
			this.lbl_part_new = new System.Windows.Forms.Label();
			this.txt_remark_new = new System.Windows.Forms.TextBox();
			this.lbl_remark_new = new System.Windows.Forms.Label();
			this.txt_packing_new = new System.Windows.Forms.TextBox();
			this.lbl_packing_new = new System.Windows.Forms.Label();
			this.lbl_moldshop_new = new System.Windows.Forms.Label();
			this.cmb_moldshop_new = new C1.Win.C1List.C1Combo();
			this.cmb_partmaterial_new = new C1.Win.C1List.C1Combo();
			this.lbl_partmaterial_new = new System.Windows.Forms.Label();
			this.txt_developcd_new = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_lastcd_new = new System.Windows.Forms.TextBox();
			this.lbl_lastcd_new = new System.Windows.Forms.Label();
			this.cmb_model_new = new C1.Win.C1List.C1Combo();
			this.lbl_model_new = new System.Windows.Forms.Label();
			this.txt_nikespeccd_new = new System.Windows.Forms.TextBox();
			this.lbl_nikespeccd_new = new System.Windows.Forms.Label();
			this.txt_moldcd_new = new System.Windows.Forms.TextBox();
			this.lbl_moldcd_new = new System.Windows.Forms.Label();
			this.lbl_size_new = new System.Windows.Forms.Label();
			this.cmb_sizefrom_new = new C1.Win.C1List.C1Combo();
			this.cmb_sizeto_new = new C1.Win.C1List.C1Combo();
			this.fgrid_size = new COM.FSP();
			this.lbl_prs_new = new System.Windows.Forms.Label();
			this.txt_prs_new = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.cmenu_diagram = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
			this.txt_style = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_currency_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldmaterial_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_gender_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_part_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldshop_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_partmaterial_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_model_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sizefrom_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sizeto_new)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.cmenu_diagram);
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			// lbl_parttype
			// 
			this.lbl_parttype.BackColor = System.Drawing.Color.Transparent;
			this.lbl_parttype.Location = new System.Drawing.Point(48, 70);
			this.lbl_parttype.Name = "lbl_parttype";
			this.lbl_parttype.Size = new System.Drawing.Size(96, 16);
			this.lbl_parttype.TabIndex = 28;
			this.lbl_parttype.Text = "Part Type";
			// 
			// cmb_parttype
			// 
			this.cmb_parttype.AddItemCols = 0;
			this.cmb_parttype.AddItemSeparator = ';';
			this.cmb_parttype.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_parttype.Caption = "";
			this.cmb_parttype.CaptionHeight = 17;
			this.cmb_parttype.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_parttype.ColumnCaptionHeight = 18;
			this.cmb_parttype.ColumnFooterHeight = 18;
			this.cmb_parttype.ContentHeight = 17;
			this.cmb_parttype.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_parttype.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_parttype.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_parttype.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_parttype.EditorHeight = 17;
			this.cmb_parttype.GapHeight = 2;
			this.cmb_parttype.ItemHeight = 15;
			this.cmb_parttype.Location = new System.Drawing.Point(152, 64);
			this.cmb_parttype.MatchEntryTimeout = ((long)(2000));
			this.cmb_parttype.MaxDropDownItems = ((short)(5));
			this.cmb_parttype.MaxLength = 32767;
			this.cmb_parttype.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_parttype.Name = "cmb_parttype";
			this.cmb_parttype.PartialRightColumn = false;
			this.cmb_parttype.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_parttype.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_parttype.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_parttype.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_parttype.Size = new System.Drawing.Size(176, 23);
			this.cmb_parttype.TabIndex = 29;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 6.75F);
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 96);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_main.Size = new System.Drawing.Size(998, 200);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 49;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			// 
			// lbl_nikespeccd
			// 
			this.lbl_nikespeccd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nikespeccd.Location = new System.Drawing.Point(344, 69);
			this.lbl_nikespeccd.Name = "lbl_nikespeccd";
			this.lbl_nikespeccd.Size = new System.Drawing.Size(112, 16);
			this.lbl_nikespeccd.TabIndex = 31;
			this.lbl_nikespeccd.Text = "Nike Spec Code";
			// 
			// txt_nikespeccd
			// 
			this.txt_nikespeccd.Location = new System.Drawing.Point(472, 64);
			this.txt_nikespeccd.Name = "txt_nikespeccd";
			this.txt_nikespeccd.Size = new System.Drawing.Size(168, 22);
			this.txt_nikespeccd.TabIndex = 32;
			this.txt_nikespeccd.Text = "";
			// 
			// lbl_moldcd
			// 
			this.lbl_moldcd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldcd.Location = new System.Drawing.Point(656, 67);
			this.lbl_moldcd.Name = "lbl_moldcd";
			this.lbl_moldcd.Size = new System.Drawing.Size(96, 16);
			this.lbl_moldcd.TabIndex = 33;
			this.lbl_moldcd.Text = "Mold Code";
			// 
			// txt_moldcd
			// 
			this.txt_moldcd.Location = new System.Drawing.Point(768, 64);
			this.txt_moldcd.Name = "txt_moldcd";
			this.txt_moldcd.Size = new System.Drawing.Size(144, 22);
			this.txt_moldcd.TabIndex = 34;
			this.txt_moldcd.Text = "";
			this.txt_moldcd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_moldcd_KeyDown);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// lbl_cost_new
			// 
			this.lbl_cost_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_cost_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_cost_new.Location = new System.Drawing.Point(732, 477);
			this.lbl_cost_new.Name = "lbl_cost_new";
			this.lbl_cost_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_cost_new.TabIndex = 90;
			this.lbl_cost_new.Text = "Cost";
			this.lbl_cost_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_currency_new
			// 
			this.lbl_currency_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_currency_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_currency_new.Location = new System.Drawing.Point(732, 453);
			this.lbl_currency_new.Name = "lbl_currency_new";
			this.lbl_currency_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_currency_new.TabIndex = 89;
			this.lbl_currency_new.Text = "Currency";
			this.lbl_currency_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_moldmaterial_new
			// 
			this.lbl_moldmaterial_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_moldmaterial_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldmaterial_new.Location = new System.Drawing.Point(732, 429);
			this.lbl_moldmaterial_new.Name = "lbl_moldmaterial_new";
			this.lbl_moldmaterial_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_moldmaterial_new.TabIndex = 88;
			this.lbl_moldmaterial_new.Text = "Mold Material";
			this.lbl_moldmaterial_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_cost_new
			// 
			this.txt_cost_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txt_cost_new.Location = new System.Drawing.Point(852, 477);
			this.txt_cost_new.Name = "txt_cost_new";
			this.txt_cost_new.Size = new System.Drawing.Size(152, 22);
			this.txt_cost_new.TabIndex = 87;
			this.txt_cost_new.Text = "";
			// 
			// cmb_currency_new
			// 
			this.cmb_currency_new.AddItemCols = 0;
			this.cmb_currency_new.AddItemSeparator = ';';
			this.cmb_currency_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_currency_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cmb_currency_new.Caption = "";
			this.cmb_currency_new.CaptionHeight = 17;
			this.cmb_currency_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_currency_new.ColumnCaptionHeight = 18;
			this.cmb_currency_new.ColumnFooterHeight = 18;
			this.cmb_currency_new.ContentHeight = 17;
			this.cmb_currency_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_currency_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_currency_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_currency_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_currency_new.EditorHeight = 17;
			this.cmb_currency_new.GapHeight = 2;
			this.cmb_currency_new.ItemHeight = 15;
			this.cmb_currency_new.Location = new System.Drawing.Point(852, 453);
			this.cmb_currency_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_currency_new.MaxDropDownItems = ((short)(5));
			this.cmb_currency_new.MaxLength = 32767;
			this.cmb_currency_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_currency_new.Name = "cmb_currency_new";
			this.cmb_currency_new.PartialRightColumn = false;
			this.cmb_currency_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_currency_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_currency_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_currency_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_currency_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_currency_new.TabIndex = 86;
			// 
			// cmb_moldmaterial_new
			// 
			this.cmb_moldmaterial_new.AddItemCols = 0;
			this.cmb_moldmaterial_new.AddItemSeparator = ';';
			this.cmb_moldmaterial_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_moldmaterial_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cmb_moldmaterial_new.Caption = "";
			this.cmb_moldmaterial_new.CaptionHeight = 17;
			this.cmb_moldmaterial_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_moldmaterial_new.ColumnCaptionHeight = 18;
			this.cmb_moldmaterial_new.ColumnFooterHeight = 18;
			this.cmb_moldmaterial_new.ContentHeight = 17;
			this.cmb_moldmaterial_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_moldmaterial_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_moldmaterial_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_moldmaterial_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_moldmaterial_new.EditorHeight = 17;
			this.cmb_moldmaterial_new.GapHeight = 2;
			this.cmb_moldmaterial_new.ItemHeight = 15;
			this.cmb_moldmaterial_new.Location = new System.Drawing.Point(852, 429);
			this.cmb_moldmaterial_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_moldmaterial_new.MaxDropDownItems = ((short)(5));
			this.cmb_moldmaterial_new.MaxLength = 32767;
			this.cmb_moldmaterial_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_moldmaterial_new.Name = "cmb_moldmaterial_new";
			this.cmb_moldmaterial_new.PartialRightColumn = false;
			this.cmb_moldmaterial_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_moldmaterial_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_moldmaterial_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_moldmaterial_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_moldmaterial_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_moldmaterial_new.TabIndex = 85;
			// 
			// cmb_gender_new
			// 
			this.cmb_gender_new.AddItemCols = 0;
			this.cmb_gender_new.AddItemSeparator = ';';
			this.cmb_gender_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_gender_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cmb_gender_new.Caption = "";
			this.cmb_gender_new.CaptionHeight = 17;
			this.cmb_gender_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_gender_new.ColumnCaptionHeight = 18;
			this.cmb_gender_new.ColumnFooterHeight = 18;
			this.cmb_gender_new.ContentHeight = 17;
			this.cmb_gender_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_gender_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_gender_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_gender_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_gender_new.EditorHeight = 17;
			this.cmb_gender_new.GapHeight = 2;
			this.cmb_gender_new.ItemHeight = 15;
			this.cmb_gender_new.Location = new System.Drawing.Point(852, 405);
			this.cmb_gender_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_gender_new.MaxDropDownItems = ((short)(5));
			this.cmb_gender_new.MaxLength = 32767;
			this.cmb_gender_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_gender_new.Name = "cmb_gender_new";
			this.cmb_gender_new.PartialRightColumn = false;
			this.cmb_gender_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_gender_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_gender_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_gender_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_gender_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_gender_new.TabIndex = 84;
			// 
			// lbl_gender_new
			// 
			this.lbl_gender_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_gender_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_gender_new.Location = new System.Drawing.Point(732, 405);
			this.lbl_gender_new.Name = "lbl_gender_new";
			this.lbl_gender_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_gender_new.TabIndex = 83;
			this.lbl_gender_new.Text = "Gender";
			this.lbl_gender_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_part_new
			// 
			this.cmb_part_new.AddItemCols = 0;
			this.cmb_part_new.AddItemSeparator = ';';
			this.cmb_part_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_part_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.cmb_part_new.Caption = "";
			this.cmb_part_new.CaptionHeight = 17;
			this.cmb_part_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_part_new.ColumnCaptionHeight = 18;
			this.cmb_part_new.ColumnFooterHeight = 18;
			this.cmb_part_new.ContentHeight = 17;
			this.cmb_part_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_part_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_part_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_part_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_part_new.EditorHeight = 17;
			this.cmb_part_new.GapHeight = 2;
			this.cmb_part_new.ItemHeight = 15;
			this.cmb_part_new.Location = new System.Drawing.Point(852, 381);
			this.cmb_part_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_part_new.MaxDropDownItems = ((short)(5));
			this.cmb_part_new.MaxLength = 32767;
			this.cmb_part_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_part_new.Name = "cmb_part_new";
			this.cmb_part_new.PartialRightColumn = false;
			this.cmb_part_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_part_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_part_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_part_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_part_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_part_new.TabIndex = 82;
			// 
			// lbl_part_new
			// 
			this.lbl_part_new.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lbl_part_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_part_new.Location = new System.Drawing.Point(732, 381);
			this.lbl_part_new.Name = "lbl_part_new";
			this.lbl_part_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_part_new.TabIndex = 81;
			this.lbl_part_new.Text = "Part";
			this.lbl_part_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_remark_new
			// 
			this.txt_remark_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_remark_new.Location = new System.Drawing.Point(132, 504);
			this.txt_remark_new.Name = "txt_remark_new";
			this.txt_remark_new.Size = new System.Drawing.Size(872, 22);
			this.txt_remark_new.TabIndex = 80;
			this.txt_remark_new.Text = "";
			// 
			// lbl_remark_new
			// 
			this.lbl_remark_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_remark_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_remark_new.Location = new System.Drawing.Point(12, 504);
			this.lbl_remark_new.Name = "lbl_remark_new";
			this.lbl_remark_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_remark_new.TabIndex = 79;
			this.lbl_remark_new.Text = "Remark";
			this.lbl_remark_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_packing_new
			// 
			this.txt_packing_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_packing_new.Location = new System.Drawing.Point(132, 480);
			this.txt_packing_new.Name = "txt_packing_new";
			this.txt_packing_new.Size = new System.Drawing.Size(152, 22);
			this.txt_packing_new.TabIndex = 78;
			this.txt_packing_new.Text = "";
			// 
			// lbl_packing_new
			// 
			this.lbl_packing_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_packing_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_packing_new.Location = new System.Drawing.Point(12, 480);
			this.lbl_packing_new.Name = "lbl_packing_new";
			this.lbl_packing_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_packing_new.TabIndex = 77;
			this.lbl_packing_new.Text = "Packing";
			this.lbl_packing_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_moldshop_new
			// 
			this.lbl_moldshop_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_moldshop_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldshop_new.Location = new System.Drawing.Point(12, 456);
			this.lbl_moldshop_new.Name = "lbl_moldshop_new";
			this.lbl_moldshop_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_moldshop_new.TabIndex = 76;
			this.lbl_moldshop_new.Text = "Mold Shop";
			this.lbl_moldshop_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_moldshop_new
			// 
			this.cmb_moldshop_new.AddItemCols = 0;
			this.cmb_moldshop_new.AddItemSeparator = ';';
			this.cmb_moldshop_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_moldshop_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmb_moldshop_new.Caption = "";
			this.cmb_moldshop_new.CaptionHeight = 17;
			this.cmb_moldshop_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_moldshop_new.ColumnCaptionHeight = 18;
			this.cmb_moldshop_new.ColumnFooterHeight = 18;
			this.cmb_moldshop_new.ContentHeight = 17;
			this.cmb_moldshop_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_moldshop_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_moldshop_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_moldshop_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_moldshop_new.EditorHeight = 17;
			this.cmb_moldshop_new.GapHeight = 2;
			this.cmb_moldshop_new.ItemHeight = 15;
			this.cmb_moldshop_new.Location = new System.Drawing.Point(132, 456);
			this.cmb_moldshop_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_moldshop_new.MaxDropDownItems = ((short)(5));
			this.cmb_moldshop_new.MaxLength = 32767;
			this.cmb_moldshop_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_moldshop_new.Name = "cmb_moldshop_new";
			this.cmb_moldshop_new.PartialRightColumn = false;
			this.cmb_moldshop_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_moldshop_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_moldshop_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_moldshop_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_moldshop_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_moldshop_new.TabIndex = 75;
			// 
			// cmb_partmaterial_new
			// 
			this.cmb_partmaterial_new.AddItemCols = 0;
			this.cmb_partmaterial_new.AddItemSeparator = ';';
			this.cmb_partmaterial_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_partmaterial_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmb_partmaterial_new.Caption = "";
			this.cmb_partmaterial_new.CaptionHeight = 17;
			this.cmb_partmaterial_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_partmaterial_new.ColumnCaptionHeight = 18;
			this.cmb_partmaterial_new.ColumnFooterHeight = 18;
			this.cmb_partmaterial_new.ContentHeight = 17;
			this.cmb_partmaterial_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_partmaterial_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_partmaterial_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_partmaterial_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_partmaterial_new.EditorHeight = 17;
			this.cmb_partmaterial_new.GapHeight = 2;
			this.cmb_partmaterial_new.ItemHeight = 15;
			this.cmb_partmaterial_new.Location = new System.Drawing.Point(132, 432);
			this.cmb_partmaterial_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_partmaterial_new.MaxDropDownItems = ((short)(5));
			this.cmb_partmaterial_new.MaxLength = 32767;
			this.cmb_partmaterial_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_partmaterial_new.Name = "cmb_partmaterial_new";
			this.cmb_partmaterial_new.PartialRightColumn = false;
			this.cmb_partmaterial_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_partmaterial_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_partmaterial_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_partmaterial_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_partmaterial_new.Size = new System.Drawing.Size(152, 23);
			this.cmb_partmaterial_new.TabIndex = 74;
			// 
			// lbl_partmaterial_new
			// 
			this.lbl_partmaterial_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_partmaterial_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_partmaterial_new.Location = new System.Drawing.Point(12, 432);
			this.lbl_partmaterial_new.Name = "lbl_partmaterial_new";
			this.lbl_partmaterial_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_partmaterial_new.TabIndex = 73;
			this.lbl_partmaterial_new.Text = "Part Material";
			this.lbl_partmaterial_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_developcd_new
			// 
			this.txt_developcd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_developcd_new.Location = new System.Drawing.Point(132, 408);
			this.txt_developcd_new.Name = "txt_developcd_new";
			this.txt_developcd_new.Size = new System.Drawing.Size(152, 22);
			this.txt_developcd_new.TabIndex = 72;
			this.txt_developcd_new.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(12, 408);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 22);
			this.label1.TabIndex = 71;
			this.label1.Text = "Develop Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_lastcd_new
			// 
			this.txt_lastcd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_lastcd_new.Location = new System.Drawing.Point(132, 384);
			this.txt_lastcd_new.Name = "txt_lastcd_new";
			this.txt_lastcd_new.Size = new System.Drawing.Size(152, 22);
			this.txt_lastcd_new.TabIndex = 70;
			this.txt_lastcd_new.Text = "";
			// 
			// lbl_lastcd_new
			// 
			this.lbl_lastcd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_lastcd_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_lastcd_new.Location = new System.Drawing.Point(12, 384);
			this.lbl_lastcd_new.Name = "lbl_lastcd_new";
			this.lbl_lastcd_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_lastcd_new.TabIndex = 69;
			this.lbl_lastcd_new.Text = "Last Code";
			this.lbl_lastcd_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_model_new
			// 
			this.cmb_model_new.AddItemCols = 0;
			this.cmb_model_new.AddItemSeparator = ';';
			this.cmb_model_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_model_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmb_model_new.Caption = "";
			this.cmb_model_new.CaptionHeight = 17;
			this.cmb_model_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_model_new.ColumnCaptionHeight = 18;
			this.cmb_model_new.ColumnFooterHeight = 18;
			this.cmb_model_new.ContentHeight = 17;
			this.cmb_model_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_model_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_model_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_model_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_model_new.EditorHeight = 17;
			this.cmb_model_new.GapHeight = 2;
			this.cmb_model_new.ItemHeight = 15;
			this.cmb_model_new.Location = new System.Drawing.Point(288, 360);
			this.cmb_model_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_model_new.MaxDropDownItems = ((short)(5));
			this.cmb_model_new.MaxLength = 32767;
			this.cmb_model_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_model_new.Name = "cmb_model_new";
			this.cmb_model_new.PartialRightColumn = false;
			this.cmb_model_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" +
				"ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" +
				"r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" +
				"le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
				"olSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18\" ColumnFoote" +
				"rHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><ClientRect>0, 0," +
				" 116, 156</ClientRect><VScrollBar><Width>16</Width></VScrollBar><HScrollBar><Hei" +
				"ght>16</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style9\" /><EvenRow" +
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
			this.cmb_model_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_model_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_model_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_model_new.Size = new System.Drawing.Size(376, 23);
			this.cmb_model_new.TabIndex = 68;
			// 
			// lbl_model_new
			// 
			this.lbl_model_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_model_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_model_new.Location = new System.Drawing.Point(12, 360);
			this.lbl_model_new.Name = "lbl_model_new";
			this.lbl_model_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_model_new.TabIndex = 67;
			this.lbl_model_new.Text = "Model ";
			this.lbl_model_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_nikespeccd_new
			// 
			this.txt_nikespeccd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_nikespeccd_new.Location = new System.Drawing.Point(132, 336);
			this.txt_nikespeccd_new.Name = "txt_nikespeccd_new";
			this.txt_nikespeccd_new.Size = new System.Drawing.Size(152, 22);
			this.txt_nikespeccd_new.TabIndex = 66;
			this.txt_nikespeccd_new.Text = "";
			// 
			// lbl_nikespeccd_new
			// 
			this.lbl_nikespeccd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_nikespeccd_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nikespeccd_new.Location = new System.Drawing.Point(12, 336);
			this.lbl_nikespeccd_new.Name = "lbl_nikespeccd_new";
			this.lbl_nikespeccd_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_nikespeccd_new.TabIndex = 65;
			this.lbl_nikespeccd_new.Text = "Nike Spec Code";
			this.lbl_nikespeccd_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_moldcd_new
			// 
			this.txt_moldcd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_moldcd_new.Location = new System.Drawing.Point(132, 312);
			this.txt_moldcd_new.Name = "txt_moldcd_new";
			this.txt_moldcd_new.Size = new System.Drawing.Size(152, 22);
			this.txt_moldcd_new.TabIndex = 64;
			this.txt_moldcd_new.Text = "";
			// 
			// lbl_moldcd_new
			// 
			this.lbl_moldcd_new.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_moldcd_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldcd_new.Location = new System.Drawing.Point(12, 312);
			this.lbl_moldcd_new.Name = "lbl_moldcd_new";
			this.lbl_moldcd_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_moldcd_new.TabIndex = 63;
			this.lbl_moldcd_new.Text = "Mold Code";
			this.lbl_moldcd_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_size_new
			// 
			this.lbl_size_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_size_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_size_new.Location = new System.Drawing.Point(12, 528);
			this.lbl_size_new.Name = "lbl_size_new";
			this.lbl_size_new.Size = new System.Drawing.Size(112, 22);
			this.lbl_size_new.TabIndex = 91;
			this.lbl_size_new.Text = "Size";
			this.lbl_size_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_sizefrom_new
			// 
			this.cmb_sizefrom_new.AddItemCols = 0;
			this.cmb_sizefrom_new.AddItemSeparator = ';';
			this.cmb_sizefrom_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_sizefrom_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmb_sizefrom_new.Caption = "";
			this.cmb_sizefrom_new.CaptionHeight = 17;
			this.cmb_sizefrom_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_sizefrom_new.ColumnCaptionHeight = 17;
			this.cmb_sizefrom_new.ColumnFooterHeight = 17;
			this.cmb_sizefrom_new.ContentHeight = 17;
			this.cmb_sizefrom_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_sizefrom_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_sizefrom_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sizefrom_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_sizefrom_new.EditorHeight = 17;
			this.cmb_sizefrom_new.GapHeight = 2;
			this.cmb_sizefrom_new.ItemHeight = 15;
			this.cmb_sizefrom_new.Location = new System.Drawing.Point(132, 528);
			this.cmb_sizefrom_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_sizefrom_new.MaxDropDownItems = ((short)(5));
			this.cmb_sizefrom_new.MaxLength = 32767;
			this.cmb_sizefrom_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_sizefrom_new.Name = "cmb_sizefrom_new";
			this.cmb_sizefrom_new.PartialRightColumn = false;
			this.cmb_sizefrom_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_sizefrom_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_sizefrom_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_sizefrom_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_sizefrom_new.Size = new System.Drawing.Size(136, 23);
			this.cmb_sizefrom_new.TabIndex = 92;
			// 
			// cmb_sizeto_new
			// 
			this.cmb_sizeto_new.AddItemCols = 0;
			this.cmb_sizeto_new.AddItemSeparator = ';';
			this.cmb_sizeto_new.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_sizeto_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmb_sizeto_new.Caption = "";
			this.cmb_sizeto_new.CaptionHeight = 17;
			this.cmb_sizeto_new.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_sizeto_new.ColumnCaptionHeight = 17;
			this.cmb_sizeto_new.ColumnFooterHeight = 17;
			this.cmb_sizeto_new.ContentHeight = 17;
			this.cmb_sizeto_new.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_sizeto_new.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_sizeto_new.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sizeto_new.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_sizeto_new.EditorHeight = 17;
			this.cmb_sizeto_new.GapHeight = 2;
			this.cmb_sizeto_new.ItemHeight = 15;
			this.cmb_sizeto_new.Location = new System.Drawing.Point(304, 528);
			this.cmb_sizeto_new.MatchEntryTimeout = ((long)(2000));
			this.cmb_sizeto_new.MaxDropDownItems = ((short)(5));
			this.cmb_sizeto_new.MaxLength = 32767;
			this.cmb_sizeto_new.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_sizeto_new.Name = "cmb_sizeto_new";
			this.cmb_sizeto_new.PartialRightColumn = false;
			this.cmb_sizeto_new.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_sizeto_new.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_sizeto_new.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_sizeto_new.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_sizeto_new.Size = new System.Drawing.Size(144, 23);
			this.cmb_sizeto_new.TabIndex = 93;
			// 
			// fgrid_size
			// 
			this.fgrid_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_size.Font = new System.Drawing.Font("Verdana", 9F);
			this.fgrid_size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_size.Location = new System.Drawing.Point(11, 556);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 2;
			this.fgrid_size.Size = new System.Drawing.Size(997, 84);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 94;
			this.fgrid_size.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseDown);
			this.fgrid_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseUp);
			this.fgrid_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgrid_size_KeyPress);
			// 
			// lbl_prs_new
			// 
			this.lbl_prs_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_prs_new.BackColor = System.Drawing.Color.Transparent;
			this.lbl_prs_new.Location = new System.Drawing.Point(504, 528);
			this.lbl_prs_new.Name = "lbl_prs_new";
			this.lbl_prs_new.Size = new System.Drawing.Size(88, 22);
			this.lbl_prs_new.TabIndex = 95;
			this.lbl_prs_new.Text = "Pairs";
			this.lbl_prs_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_prs_new
			// 
			this.txt_prs_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_prs_new.Location = new System.Drawing.Point(600, 528);
			this.txt_prs_new.Name = "txt_prs_new";
			this.txt_prs_new.Size = new System.Drawing.Size(128, 22);
			this.txt_prs_new.TabIndex = 96;
			this.txt_prs_new.Text = "";
			this.txt_prs_new.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prs_new_KeyDown);
			// 
			// btn_insert
			// 
			this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btn_insert.BackColor = System.Drawing.Color.Transparent;
			this.btn_insert.Location = new System.Drawing.Point(792, 528);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(112, 24);
			this.btn_insert.TabIndex = 97;
			this.btn_insert.Text = "Insert";
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// cmenu_diagram
			// 
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink9);
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink10);
			this.cmenu_diagram.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.cmenu_diagram.Name = "cmenu_diagram";
			// 
			// c1CommandLink9
			// 
			this.c1CommandLink9.Command = this.c1Command1;
			this.c1CommandLink9.Text = "Divide";
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "Divide";
			this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
			// 
			// c1CommandLink10
			// 
			this.c1CommandLink10.Text = "-";
			// 
			// txt_style
			// 
			this.txt_style.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txt_style.Location = new System.Drawing.Point(132, 360);
			this.txt_style.Name = "txt_style";
			this.txt_style.Size = new System.Drawing.Size(152, 22);
			this.txt_style.TabIndex = 98;
			this.txt_style.Text = "";
			this.txt_style.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_style_KeyDown);
			// 
			// Form_PB_Mold_Master
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.txt_style);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.txt_prs_new);
			this.Controls.Add(this.lbl_prs_new);
			this.Controls.Add(this.fgrid_size);
			this.Controls.Add(this.cmb_sizeto_new);
			this.Controls.Add(this.cmb_sizefrom_new);
			this.Controls.Add(this.lbl_size_new);
			this.Controls.Add(this.lbl_cost_new);
			this.Controls.Add(this.lbl_currency_new);
			this.Controls.Add(this.lbl_moldmaterial_new);
			this.Controls.Add(this.txt_cost_new);
			this.Controls.Add(this.cmb_currency_new);
			this.Controls.Add(this.cmb_moldmaterial_new);
			this.Controls.Add(this.cmb_gender_new);
			this.Controls.Add(this.lbl_gender_new);
			this.Controls.Add(this.cmb_part_new);
			this.Controls.Add(this.lbl_part_new);
			this.Controls.Add(this.txt_remark_new);
			this.Controls.Add(this.lbl_remark_new);
			this.Controls.Add(this.txt_packing_new);
			this.Controls.Add(this.lbl_packing_new);
			this.Controls.Add(this.lbl_moldshop_new);
			this.Controls.Add(this.cmb_moldshop_new);
			this.Controls.Add(this.cmb_partmaterial_new);
			this.Controls.Add(this.lbl_partmaterial_new);
			this.Controls.Add(this.txt_developcd_new);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_lastcd_new);
			this.Controls.Add(this.lbl_lastcd_new);
			this.Controls.Add(this.cmb_model_new);
			this.Controls.Add(this.lbl_model_new);
			this.Controls.Add(this.txt_nikespeccd_new);
			this.Controls.Add(this.lbl_nikespeccd_new);
			this.Controls.Add(this.txt_moldcd_new);
			this.Controls.Add(this.lbl_moldcd_new);
			this.Controls.Add(this.txt_moldcd);
			this.Controls.Add(this.lbl_moldcd);
			this.Controls.Add(this.txt_nikespeccd);
			this.Controls.Add(this.lbl_nikespeccd);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.cmb_parttype);
			this.Controls.Add(this.lbl_parttype);
			this.Name = "Form_PB_Mold_Master";
			this.Text = "Form_Mold_Master";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Master_Load);
			this.Controls.SetChildIndex(this.lbl_parttype, 0);
			this.Controls.SetChildIndex(this.cmb_parttype, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.lbl_nikespeccd, 0);
			this.Controls.SetChildIndex(this.txt_nikespeccd, 0);
			this.Controls.SetChildIndex(this.lbl_moldcd, 0);
			this.Controls.SetChildIndex(this.txt_moldcd, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_moldcd_new, 0);
			this.Controls.SetChildIndex(this.txt_moldcd_new, 0);
			this.Controls.SetChildIndex(this.lbl_nikespeccd_new, 0);
			this.Controls.SetChildIndex(this.txt_nikespeccd_new, 0);
			this.Controls.SetChildIndex(this.lbl_model_new, 0);
			this.Controls.SetChildIndex(this.cmb_model_new, 0);
			this.Controls.SetChildIndex(this.lbl_lastcd_new, 0);
			this.Controls.SetChildIndex(this.txt_lastcd_new, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt_developcd_new, 0);
			this.Controls.SetChildIndex(this.lbl_partmaterial_new, 0);
			this.Controls.SetChildIndex(this.cmb_partmaterial_new, 0);
			this.Controls.SetChildIndex(this.cmb_moldshop_new, 0);
			this.Controls.SetChildIndex(this.lbl_moldshop_new, 0);
			this.Controls.SetChildIndex(this.lbl_packing_new, 0);
			this.Controls.SetChildIndex(this.txt_packing_new, 0);
			this.Controls.SetChildIndex(this.lbl_remark_new, 0);
			this.Controls.SetChildIndex(this.txt_remark_new, 0);
			this.Controls.SetChildIndex(this.lbl_part_new, 0);
			this.Controls.SetChildIndex(this.cmb_part_new, 0);
			this.Controls.SetChildIndex(this.lbl_gender_new, 0);
			this.Controls.SetChildIndex(this.cmb_gender_new, 0);
			this.Controls.SetChildIndex(this.cmb_moldmaterial_new, 0);
			this.Controls.SetChildIndex(this.cmb_currency_new, 0);
			this.Controls.SetChildIndex(this.txt_cost_new, 0);
			this.Controls.SetChildIndex(this.lbl_moldmaterial_new, 0);
			this.Controls.SetChildIndex(this.lbl_currency_new, 0);
			this.Controls.SetChildIndex(this.lbl_cost_new, 0);
			this.Controls.SetChildIndex(this.lbl_size_new, 0);
			this.Controls.SetChildIndex(this.cmb_sizefrom_new, 0);
			this.Controls.SetChildIndex(this.cmb_sizeto_new, 0);
			this.Controls.SetChildIndex(this.fgrid_size, 0);
			this.Controls.SetChildIndex(this.lbl_prs_new, 0);
			this.Controls.SetChildIndex(this.txt_prs_new, 0);
			this.Controls.SetChildIndex(this.btn_insert, 0);
			this.Controls.SetChildIndex(this.txt_style, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_currency_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldmaterial_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_gender_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_part_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_moldshop_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_partmaterial_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_model_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sizefrom_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sizeto_new)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		#region Init object

		private void Init_Form()
		{


			this.Text = "MMS_Mold Master";
			this.lbl_MainTitle.Text = "MMS_Mold Master";
			ClassLib.ComFunction.SetLangDic(this); 

			//Type_Working(_Form_Type);

			DataTable dt_ret = Select_com_filter_code_List("MD03");  //Select_com_filter_code_List("MD03");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_parttype, 0, 1, false, false);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_part_new, 0, 1, false, false);
			////       cmb_sampletypes.SelectedIndex= -1;

			fgrid_main.Set_Grid("SDT_MOLD_MASTER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrid_main.Rows.Fixed;
			fgrid_main.ExtendLastCol = false;
			//fgrid_main.AutoSizeCols();


			dt_ret = Select_Model_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model_new, 0, 1, false, false);
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model_new, 1, 0, false, false);
	
			dt_ret = Select_com_filter_code_List("SEM01");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender_new, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV05");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_partmaterial_new, 0, 1, false, false);

//			dt_ret = Select_com_filter_code_List("SDV15");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_moldshop_new, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List1("SDV15",ClassLib.ComVar.This_Dept);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_moldshop_new, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("SDV04");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_moldmaterial_new, 0, 1, false, false);

			dt_ret = Select_com_filter_code_List("STM11");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_currency_new, 0, 1, false, false);

			dt_ret = Select_mold_size_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sizefrom_new, 0, 1, false, false);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sizeto_new, 0, 1, false, false);

			//Model_List();
		}
		#endregion
		private DataTable Select_com_filter_code_List(string com_cd)
		{
			string Proc_Name = "pkg_scm_code.select_com_filter_code_list";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_com_filter_code_List1(string com_cd,string dept_cd)
		{
			string Proc_Name = "PKG_SDT_MOLD_WH.select_com_filter_code_list";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "ARG_DEPT_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = dept_cd;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_Model_List()
		{
			
			//DataSet DS_Ret;
			OraDB.ReDim_Parameter(2);

			string Proc_Name = "pkg_sbc_model.select_sdc_mstyle_list2";

			
			OraDB.Process_Name = Proc_Name;

            OraDB.Parameter_Name[0] = "ARG_STYLE_NAME";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = txt_style.Text.Trim().ToUpper();//  "VJ";
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];


		}
		private DataTable Select_mold_size_List()
		{
			
			//DataSet DS_Ret;
			OraDB.ReDim_Parameter(1);
			string Proc_Name = "pkg_sdt_mold.select_mold_size";

			
			OraDB.Process_Name = Proc_Name;


			OraDB.Parameter_Name[0] = "OUT_CURSOR";


			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;


			OraDB.Parameter_Values[0] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];


		}
		
		private void Form_PB_Mold_Master_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			if((ClassLib.ComVar.This_Dept.ToString() =="110000")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="0000")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="150000"))
			{
				tbtn_Save.Enabled = true ;
			}
			else
			{
				tbtn_Save.Enabled = false ;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				mold_master_list();
//				FlexMold.ClassLib.ComVar.This_Action ="S" ;
//				FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
//				FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);			
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private bool mold_master_list()
		{
			DataTable dt = null;
			fgrid_main.Clear();
			fgrid_main.Set_Grid("SDT_MOLD_MASTER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrid_main.Rows.Fixed;
			fgrid_main.ExtendLastCol = false;
			//this.Cursor = Cursors.WaitCursor;
			fgrid_main.Rows.Count = 2;
			dt = Select_mold_master_list();			
			
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);	

			if(dt.Rows.Count == 0) return false;

			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for (int i = 0; i < dt_rows; i++)
			{
				//string Mold_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_CD.IxTOOL_CD].ToString();
				fgrid_main.AddItem(dt.Rows[i].ItemArray,fgrid_main.Rows.Count,1);
				show_info_text(2);
			}

			fgrid_main.Tree.Show(1);
			return true;
		}
        
		private DataTable Select_mold_master_list()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_MASTER";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_NIKE_SPEC";
			OraDB.Parameter_Name[1] = "ARG_PART_TYPE";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CODE";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = txt_nikespeccd.Text.Trim();//cmb_factory.SelectedValue.ToString();
			if(cmb_parttype.Text.Trim() != "")
				OraDB.Parameter_Values[1] = cmb_parttype.SelectedValue.ToString();
			else 
				OraDB.Parameter_Values[1] = "";

			OraDB.Parameter_Values[2] = txt_moldcd.Text.Trim();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private DataTable Select_mold_size_by_tool(string arg_mold)
		{
//			string Proc_Name = "PKG_SDT_MOLD.";
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_SIZE_BY_TOOL";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_MOLD_CODE";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_mold;
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		//private void Model_List()
		//{
		//    DataTable dt_ret = Select_Model_List();
		//    ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model_new, 0, 1, false, false);
		//}
		private void show_info_text(int sct_rows)
		{
			try
			{
				
				DataTable dt = null;
				//DataTable dt_cov = null;
				string temp="";
				string temp1="";
				txt_moldcd_new.Text = fgrid_main[sct_rows, 1].ToString();
				txt_nikespeccd_new.Text = fgrid_main[sct_rows, 2].ToString();
				txt_lastcd_new.Text = fgrid_main[sct_rows, 9].ToString();
				txt_developcd_new.Text = fgrid_main[sct_rows, 10].ToString();
				txt_packing_new.Text = fgrid_main[sct_rows, 17].ToString();
				txt_remark_new.Text = fgrid_main[sct_rows, 12].ToString();
				txt_cost_new.Text = fgrid_main[sct_rows, 22].ToString();
				cmb_part_new.SelectedValue = fgrid_main[sct_rows, 3].ToString();
				cmb_model_new.SelectedValue = fgrid_main[sct_rows, 5].ToString();
				cmb_partmaterial_new.SelectedValue = fgrid_main[sct_rows, 13].ToString();
				cmb_moldshop_new.SelectedValue = fgrid_main[sct_rows ,15].ToString();
				cmb_gender_new.SelectedValue = fgrid_main[sct_rows ,7].ToString();
				cmb_moldmaterial_new.SelectedValue = fgrid_main[sct_rows ,18].ToString();
				cmb_currency_new.SelectedValue = fgrid_main[sct_rows ,20].ToString();
				if(fgrid_main[sct_rows,0] =="I")
				{
					fgrid_size.Cols.Count = _cols;
					fgrid_size.Rows.Count = 2;
					cmb_sizefrom_new.SelectedValue = _sizefrom;
					cmb_sizeto_new.SelectedValue = _sizeto;
					txt_prs_new.Text = _prs;
					fgrid_size.Clear();
					for (int i = 0; i < 2 ; i++)
					{
						for (int j = 0; j < _cols - 1 ; j++)
						{

							fgrid_size[i, j+1] = _sizelist[i, j];
	     
						}
	                    
	                   

					}

				}
				else 
				{
					dt = Select_mold_size_by_tool(fgrid_main[sct_rows,1].ToString());
               

					int dt_rows = dt.Rows.Count;
					int dt_cols = dt.Columns.Count;
					int k =0;
					int l =0;
					int n =1;
					string  qty ="";
					string [,] arr = new string[dt_cols,dt_rows];
					fgrid_size.Clear();
					fgrid_size.ExtendLastCol = false;
					this.Cursor = Cursors.WaitCursor;
					fgrid_size.Rows.Count = 2;
					for (int j = 0; j < dt_rows; j++)
					{
						if(k<dt_rows)
						{
							temp1 = dt.Rows[k].ItemArray[0].ToString();
							temp= dt.Rows[k].ItemArray[2].ToString();
							qty = dt.Rows[k].ItemArray[1].ToString();
							for (int i=k;i<dt_rows;i++)
							{
								if ( temp == dt.Rows[i].ItemArray[2].ToString() && temp != dt.Rows[i].ItemArray[0].ToString())
								{
								    
									temp1 = temp1 +"/"+ dt.Rows[i].ItemArray[0].ToString() ;
									k++;
									l++;
								}
							}
							if (temp !="")
							{
								arr[0,j] =temp1;
								arr[1,j] =qty;
								temp="";
								k=k+1;
								l=0;
								n++;
							}
							
						}
						
							
					}
					
					fgrid_size.Cols.Count = n;
					for (int i = 0; i <n -1 ; i++)
					{
						fgrid_size[0, i+1] = arr[0,i];
						fgrid_size[1, i+1] = arr[1,i];
					}
				}
				fgrid_size[0, 0] = "Size";
				fgrid_size[1, 0] = "Pairs";
				fgrid_size.AutoSizeCols();
				temp =fgrid_size[0, 1].ToString().Substring(1,1).Trim();
				if(temp.Length==0)
					temp = fgrid_size[0, 1].ToString().Substring(1,1);
				else
					temp = fgrid_size[0, 1].ToString().Substring(0,2);
				cmb_sizefrom_new.SelectedValue = temp;
				cmb_sizeto_new.SelectedValue = fgrid_size[0, fgrid_size.Cols.Count -1].ToString();
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void txt_pairs_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					SELECT_MOLD_SIZE_NEW_LIST();
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		private void SELECT_MOLD_SIZE_NEW_LIST()
		{
			try
			{
				DataTable dt = null;
				dt = Select_mold_size_new(cmb_sizefrom_new.SelectedValue.ToString(), cmb_sizeto_new.SelectedValue.ToString(), txt_prs_new.Text);

				int dt_rows = dt.Rows.Count;
				int dt_cols = dt.Columns.Count;

				string[,] arr = new string[dt_cols, dt_rows];
				fgrid_size.Clear();
				fgrid_size.ExtendLastCol = false;
				this.Cursor = Cursors.WaitCursor;
				fgrid_size.Rows.Count = 2;
				fgrid_size.Cols.Count = dt.Rows.Count + 1;
				for (int i = 0; i < dt_cols - 1; i++)
				{
					for (int j = 0; j < dt_rows; j++)
					{
						arr[i, j] = dt.Rows[j].ItemArray[i].ToString();
					}
				}
				for (int i = 0; i < dt.Columns.Count - 1; i++)
				{
					for (int j = 0; j < dt.Rows.Count; j++)
					{
						fgrid_size[i, j + 1] = arr[i, j];
					}
				}
				fgrid_size[0, 0] = "Size";
				fgrid_size[1, 0] = "Qty";
				fgrid_size.AutoSizeCols();
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
                 
		}
		private DataTable Select_mold_size_new(string sizefr, string sizeto, string prs)
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_SIZE_NEW";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_SIZE_FR";
			OraDB.Parameter_Name[1] = "ARG_SIZE_TO";
			OraDB.Parameter_Name[2] = "ARG_SIZE_PRS";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = sizefr;
			OraDB.Parameter_Values[1] = sizeto ;
			OraDB.Parameter_Values[2] = prs;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void btn_pairsave_Click(object sender, EventArgs e)
		{
			//
			Insert_new_mold();
		}
		private void Insert_new_mold()
		{
			_sizelist = new string[fgrid_size.Rows.Count,fgrid_size.Cols.Count];
			try
			{
				int extendrow = fgrid_main.Rows.Count;
				fgrid_main.Rows.Count = extendrow + 1;
				fgrid_main[fgrid_main.Rows.Count - 1, 0] = "I";
				fgrid_main[fgrid_main.Rows.Count - 1, 1] = txt_moldcd_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 2] = txt_nikespeccd_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 3] = cmb_part_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 4] = cmb_part_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 5] = cmb_model_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 6] = cmb_model_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 7] = cmb_gender_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 8] = cmb_gender_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 9] = txt_lastcd_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 10] = txt_developcd_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 11] = "Y";
				fgrid_main[fgrid_main.Rows.Count - 1, 12] = txt_remark_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 13] = cmb_partmaterial_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 14] = cmb_partmaterial_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 15] = cmb_moldshop_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 16] = cmb_moldshop_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 17] = txt_packing_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 18] = cmb_moldmaterial_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 19] = cmb_moldmaterial_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 20] = cmb_currency_new.SelectedValue.ToString();
				fgrid_main[fgrid_main.Rows.Count - 1, 21] = cmb_currency_new.Text;
				fgrid_main[fgrid_main.Rows.Count - 1, 22] = txt_cost_new.Text;
				_sizefrom = cmb_sizefrom_new.SelectedValue.ToString();
				_sizeto= cmb_sizeto_new.SelectedValue.ToString();
				_prs=txt_prs_new.Text;
				_cols = fgrid_size.Cols.Count;
				for (int i = 0; i < fgrid_size.Rows.Count; i++)
				{
					for (int j = 1; j < fgrid_size.Cols.Count; j++)
					{

						_sizelist[i, j-1] = fgrid_size[i, j].ToString();

					}

				}


			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		
		private void fgrid_main_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ClassLib.ComVar._startmouse = fgrid_main.RowSel;     
			}
		}

		private void fgrid_main_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ClassLib.ComVar._endmouse = fgrid_main.RowSel;
			}
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main.Selection.r1 <= fgrid_main.Rows.Fixed - 1) return;

			int sct_row = fgrid_main.Selection.r1;
			int sct_col = fgrid_main.Selection.c1;
			show_info_text(sct_row);
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			Insert_new_mold();
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt = null;
				//DataTable dt_cov = null;
				txt_moldcd_new.Text = "";
				txt_nikespeccd_new.Text = "";
				txt_lastcd_new.Text = ""; ;
				txt_developcd_new.Text = "";
				txt_packing_new.Text = "";
				txt_remark_new.Text = "";
				txt_cost_new.Text = "";
				cmb_part_new.SelectedValue = "";
				cmb_model_new.SelectedValue = "";
				cmb_partmaterial_new.SelectedValue = "";
				cmb_moldshop_new.SelectedValue = "";
				cmb_gender_new.SelectedValue = "";
				cmb_moldmaterial_new.SelectedValue = "";
				cmb_currency_new.SelectedValue = "";

				fgrid_size.Clear();
				fgrid_size[0, 0] = "Size";
				fgrid_size[1, 0] = "Qty";
				//fgrid_size.AutoSizeCols();
				cmb_sizefrom_new.SelectedValue = "";
				cmb_sizeto_new.SelectedValue = "";
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for (int i = ClassLib.ComVar._startmouse; i <= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i, 0] = "D";
			}
		}

		private void txt_prs_new_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					SELECT_MOLD_SIZE_NEW_LIST();
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void fgrid_size_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
		
				ClassLib.ComVar._startmouse = fgrid_size.ColSel;   
					

			}
			else if(e.Button == MouseButtons.Right)
			{
				//e.ReturnStatus = VcReturnStatus.vcRetStatNoPopup;  
				cmenu_diagram.ShowContextMenu(fgrid_size, new Point(e.X, e.Y)); 
				//cmenu_Grid.Show(
	
				//_SelNode = e.Node;
			}
		}

		private void fgrid_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
			
				ClassLib.ComVar._endmouse = fgrid_size.ColSel;
				if(ClassLib.ComVar._endmouse > ClassLib.ComVar._startmouse)
				{
					int j = ClassLib.ComVar._endmouse - ClassLib.ComVar._startmouse;
					for (int i=ClassLib.ComVar._startmouse+1;i<= ClassLib.ComVar._endmouse; i++)
					{
						fgrid_size[0,ClassLib.ComVar._startmouse]=fgrid_size[0,ClassLib.ComVar._startmouse] +"/"+fgrid_size[0,i];
						//fgrid_size.ColSel=_startmouse;
					
					}
					for (int i=ClassLib.ComVar._startmouse+1;i< fgrid_size.Cols.Count-j; i++)
					{
						fgrid_size[0,i]= fgrid_size[0,i+j];
						fgrid_size[1,i]= fgrid_size[1,i+j];
					}
					fgrid_size.Cols.Count  = fgrid_size.Cols.Count  - j;
					fgrid_size.AutoSizeCols();
					init_sizelist();
					if(fgrid_main.Rows.Count > 2)
					{
						if(txt_moldcd_new.Text.ToString().Trim()== fgrid_main[fgrid_main.RowSel,1].ToString().Trim())
							fgrid_main[fgrid_main.RowSel,0] = "U";
					}

				}
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				for (int i = 2; i < fgrid_main.Rows.Count; i++)
				{
					if(fgrid_main[i, 0]!= null)
					{
						if (fgrid_main[i, 0]== "I") 
						{
							string[] arr_save = new string[fgrid_main.Cols.Count];
							for(int j=0;j< fgrid_main.Cols.Count;j++)
							{
								if(fgrid_main[i,j] != null)
									arr_save[j] = fgrid_main[i,j].ToString();
								else 
									arr_save[j] = "";
							}
							save_mold_list(arr_save);  //used
							//save_mold_size(fgrid_main[i,1]);          //no used
							mold_group_size(fgrid_main[i,1].ToString());
							FlexMold.ClassLib.ComVar.This_Action ="I" ;
							FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
							FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
	
							mold_master_list();
							FlexMold.ClassLib.ComVar.This_Action ="I" ;
							FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
							FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
						}
						else if(fgrid_main[i, 0]== "U")
						{
							string[] arr_save = new string[fgrid_main.Cols.Count];
							for(int j=0;j< fgrid_main.Cols.Count;j++)
							{
								if(fgrid_main[i,j] != null)
									arr_save[j] = fgrid_main[i,j].ToString();
								else 
									arr_save[j] = "";
							}
							save_mold_list(arr_save);  //used
							//save_mold_size(fgrid_main[i,1]);          //no used
							mold_group_size(fgrid_main[i,1].ToString());
							mold_master_list();
						}
						else if(fgrid_main[i, 0]== "D")
						{
							string[] arr_upgrade = new string[fgrid_main.Cols.Count];
							for(int j=0;j< fgrid_main.Cols.Count;j++)
							{
								arr_upgrade[j] = fgrid_main[i,j].ToString();
							}
							save_mold_list(arr_upgrade);
							mold_master_list();
							FlexMold.ClassLib.ComVar.This_Action ="D" ;
							FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
							FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
			}
		}
		private void save_mold_list(string[] arg_array)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_MASTER";
			int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(arg_len); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_DIVISION";
			OraDB.Parameter_Name[1]  = "ARG_FACTORY";
			OraDB.Parameter_Name[2]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3]  = "ARG_PART_CD"; //ARG_SPEC_CD
			OraDB.Parameter_Name[4]  = "ARG_SPEC_CD";
			OraDB.Parameter_Name[5]  = "ARG_GEN";
			OraDB.Parameter_Name[6]  = "ARG_MNT_CHK";
			OraDB.Parameter_Name[7]  = "ARG_MOLD_NM";
			OraDB.Parameter_Name[8]  = "ARG_GUAGE";
			OraDB.Parameter_Name[9]  = "ARG_UNIT";
			OraDB.Parameter_Name[10]  = "ARG_CUS";

			OraDB.Parameter_Name[11] = "ARG_MOLD_MT";
			OraDB.Parameter_Name[12] = "ARG_MODEL_CD";
			OraDB.Parameter_Name[13] = "ARG_MOLD_PART";
			OraDB.Parameter_Name[14] = "ARG_MOLD_SHOP";

			OraDB.Parameter_Name[15] = "ARG_LAST_CD";
			OraDB.Parameter_Name[16] = "ARG_DEV_CD";
			OraDB.Parameter_Name[17] = "ARG_PRS";
			OraDB.Parameter_Name[18] = "ARG_START_PO";
			OraDB.Parameter_Name[19] = "ARG_USE_YN";

			OraDB.Parameter_Name[20] = "ARG_DSTY_DT";
			OraDB.Parameter_Name[21] = "ARG_PK_QTY";
			OraDB.Parameter_Name[22] = "ARG_VR_LINE";
			OraDB.Parameter_Name[23] = "ARG_COINAGE";
			OraDB.Parameter_Name[24] = "ARG_COST";

			OraDB.Parameter_Name[25] = "ARG_US_COST";
			OraDB.Parameter_Name[26] = "ARG_CYCLE";
			OraDB.Parameter_Name[27] = "ARG_REMARK";
			OraDB.Parameter_Name[28] = "ARG_UPD_YMD";
			OraDB.Parameter_Name[29] = "ARG_UPD_USER";

			

			for(int i=0; i< arg_len; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			 
			OraDB.Parameter_Values[0] = arg_array[0].ToString(); 
			OraDB.Parameter_Values[1] = "VJ"; 
			OraDB.Parameter_Values[2] = arg_array[1].ToString(); 
			OraDB.Parameter_Values[3] = arg_array[3].ToString(); 
			OraDB.Parameter_Values[4] = arg_array[2].ToString(); 
			OraDB.Parameter_Values[5] = arg_array[7].ToString(); 
			OraDB.Parameter_Values[6] = ""; 
			OraDB.Parameter_Values[7] = ""; 
			OraDB.Parameter_Values[8] = "";
			OraDB.Parameter_Values[9] = "";
			OraDB.Parameter_Values[10] = "";
			OraDB.Parameter_Values[11] = arg_array[18].ToString();
			OraDB.Parameter_Values[12] = arg_array[5].ToString(); 
			OraDB.Parameter_Values[13] = arg_array[13].ToString();
			OraDB.Parameter_Values[14] = arg_array[15].ToString(); 
			OraDB.Parameter_Values[15] = arg_array[9].ToString();
			OraDB.Parameter_Values[16] = arg_array[10].ToString(); 
			OraDB.Parameter_Values[17] = "";
			OraDB.Parameter_Values[18] = "";
			OraDB.Parameter_Values[19] = arg_array[11].ToString();
			OraDB.Parameter_Values[20] = ""; 
			OraDB.Parameter_Values[21] = arg_array[17].ToString(); 
			OraDB.Parameter_Values[22] = "";
			OraDB.Parameter_Values[23] = arg_array[21].ToString(); 
			OraDB.Parameter_Values[24] = arg_array[22].ToString();
			OraDB.Parameter_Values[25] = arg_array[22].ToString(); 
			OraDB.Parameter_Values[26] = "";
			OraDB.Parameter_Values[27] = arg_array[12].ToString(); 
			OraDB.Parameter_Values[28] = ""; // arg_array[1].ToString();
			OraDB.Parameter_Values[29] = COM.ComVar.This_User;

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}
		private void save_mold_size(string grp_size,string no_size, string prs, string mold_cd)
		{
			
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_SIZE";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(8); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_DIVISION";
			OraDB.Parameter_Name[1]  = "ARG_MOLD_CD";
			OraDB.Parameter_Name[2]  = "ARG_USE_SIZE";
			OraDB.Parameter_Name[3]  = "ARG_CS_SIZE";
			OraDB.Parameter_Name[4]  = "ARG_PRS";
			OraDB.Parameter_Name[5]  = "ARG_REMARK"; //ARG_SPEC_CD
			OraDB.Parameter_Name[6]  = "ARG_UPD_YMD";
			OraDB.Parameter_Name[7]  = "ARG_UPD_USER";

			OraDB.Parameter_Values[0] = "I";
			OraDB.Parameter_Values[1] = mold_cd.ToString(); 
			OraDB.Parameter_Values[2] = grp_size.ToString();
			OraDB.Parameter_Values[3] = no_size.ToString();  
			OraDB.Parameter_Values[4] = prs.ToString(); 
			OraDB.Parameter_Values[5] = "";
			OraDB.Parameter_Values[6] = ""; 
			OraDB.Parameter_Values[7] = COM.ComVar.This_User; 

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}
		private void mold_group_size(string mold_code)
		{
			string [] no_size = null;
			char[] delimiter = "/".ToCharArray();
			//no_size = _sizelist[0,0].ToString().Split(delimiter);
			for(int i=0;i< (_sizelist.Length-2)/2;i++)
			{
				no_size = _sizelist[0,i].ToString().Split(delimiter);
				for(int j=0;j<no_size.Length;j++)
				{
					save_mold_size(no_size[0].ToString(),no_size[j].ToString(),fgrid_size[1,i+1].ToString(), mold_code);
				}

			}
		}

		private void fgrid_size_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				init_sizelist();
				fgrid_main[fgrid_main.RowSel,0]="U";
//				for (int i = 0; i < fgrid_size.Rows.Count; i++)
//				{
//					for (int j = 1; j < fgrid_size.Cols.Count; j++)
//					{
//
//						_sizelist[i, j-1] = fgrid_size[i, j].ToString();
//
//					}
//
//				}
			}
		}

		private void init_sizelist()
		{
			_sizelist = new string[fgrid_size.Rows.Count,fgrid_size.Cols.Count];
			
			for (int i = 0; i < fgrid_size.Rows.Count; i++)
			{
				for (int j = 1; j < fgrid_size.Cols.Count; j++)
				{

					_sizelist[i, j-1] = fgrid_size[i, j].ToString();

				}

			}
		}

		private void txt_moldcd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				mold_master_list();
			}
		}

		private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string [] no_size = null;
			char[] delimiter = "/".ToCharArray();
			int k=0;
			int m =0;
			no_size = fgrid_size[0,fgrid_size.ColSel].ToString().Split(delimiter);
			_sizelist = new string[fgrid_size.Rows.Count,fgrid_size.Cols.Count + no_size.Length -2];
			
			//for(int i =0;i < fgrid_size.Cols.Count - 1; i++)
			//{
				for (int i =0;i< fgrid_size.Cols.Count -1 ;i++)
				{
					if (i + 1 == fgrid_size.ColSel)
					{
						no_size = fgrid_size[0,fgrid_size.ColSel].ToString().Split(delimiter);
						if(no_size.Length > 1)
						{
							
							for(int j = 0; j< no_size.Length;j++)
							{
								//temp = no_size[j].ToString();
								_sizelist[0,j+i] =no_size[j].ToString();
								_sizelist[1,j+i] = fgrid_size[1,i+1].ToString();
								
								k++;
							}
							m=k-1;
							k=0;
						}
						else
						{
							_sizelist[0,i] = fgrid_size[0,i].ToString();
							_sizelist[1,i] = fgrid_size[1,i].ToString();
						}
						//i=fgrid_size.ColSel;
					}
					else
					{
						  
						_sizelist[0,i+m] = fgrid_size[0,i+1].ToString();
						_sizelist[1,i+m] = fgrid_size[1,i+1].ToString();

					}
				}
//			}
			fgrid_size.Cols.Count = (_sizelist.Length/2) + 1;
			fgrid_size.Rows.Count = 2;
			for (int i = 0; i < 2 ; i++)
			{
				for (int j = 0; j < (_sizelist.Length/2); j++)
				{

					fgrid_size[i, j+1] = _sizelist[i, j];
	     
				}
	                    
			}
			fgrid_size.AutoSizeCols();
			init_sizelist();
			fgrid_main[fgrid_main.RowSel,0] = "U";

		}

		private void txt_style_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					//SELECT_MOLD_SIZE_NEW_LIST();
					DataTable dt_ret = Select_Model_List();
					ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_model_new, 0, 1, false, false);
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


	}
}

