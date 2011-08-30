using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;
using C1.Win.C1Chart;

namespace FlexMold.Management
{
	public class Form_Sys_PGM_Monitor_By_Date : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtpdate_to;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		public COM.FSP fgrid_main;
		private C1.Win.C1Chart.C1Chart Chart_Main;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1Chart.C1Chart Chart_Main_tot;
		public COM.FSP fgrid_main1;
		public COM.FSP fgrid_view;
		private C1.Win.C1Chart.ChartDataSeries series0 = null;
		private C1.Win.C1Chart.C1Chart Chart_view;
		public COM.FSP fgrid_main2;
		private C1.Win.C1Chart.C1Chart Chart3;
		public COM.FSP fgrid_Report;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_Sys_PGM_Monitor_By_Date()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Sys_PGM_Monitor_By_Date));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpdate_to = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			this.Chart_Main = new C1.Win.C1Chart.C1Chart();
			this.Chart_Main_tot = new C1.Win.C1Chart.C1Chart();
			this.fgrid_main1 = new COM.FSP();
			this.fgrid_view = new COM.FSP();
			this.Chart_view = new C1.Win.C1Chart.C1Chart();
			this.fgrid_main2 = new COM.FSP();
			this.Chart3 = new C1.Win.C1Chart.C1Chart();
			this.fgrid_Report = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main_tot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_view)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_view)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Report)).BeginInit();
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
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dtpdate_to);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_work_ymd);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Location = new System.Drawing.Point(0, 57);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(12, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 16);
			this.label2.TabIndex = 33;
			this.label2.Text = "Factory";
			// 
			// dtpdate_to
			// 
			this.dtpdate_to.CustomFormat = "yyyy/MM/dd";
			this.dtpdate_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpdate_to.Location = new System.Drawing.Point(488, 8);
			this.dtpdate_to.Name = "dtpdate_to";
			this.dtpdate_to.Size = new System.Drawing.Size(104, 22);
			this.dtpdate_to.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(464, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = "To";
			// 
			// cmb_workday
			// 
			this.cmb_workday.CustomFormat = "yyyy/MM/dd";
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.cmb_workday.Location = new System.Drawing.Point(352, 8);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 23;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(304, 11);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(49, 16);
			this.lbl_work_ymd.TabIndex = 22;
			this.lbl_work_ymd.Text = "From";
			// 
			// cbo_factory
			// 
			this.cbo_factory.AddItemCols = 0;
			this.cbo_factory.AddItemSeparator = ';';
			this.cbo_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_factory.Caption = "";
			this.cbo_factory.CaptionHeight = 17;
			this.cbo_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_factory.ColumnCaptionHeight = 17;
			this.cbo_factory.ColumnFooterHeight = 17;
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(72, 10);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(208, 23);
			this.cbo_factory.TabIndex = 21;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Location = new System.Drawing.Point(0, 0);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.TabIndex = 0;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 98);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.Size = new System.Drawing.Size(536, 160);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:Wheat;ForeColor:Black;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 56;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			// 
			// Chart_Main
			// 
			this.Chart_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Chart_Main.DataSource = null;
			this.Chart_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart_Main.Location = new System.Drawing.Point(544, 100);
			this.Chart_Main.Name = "Chart_Main";
			this.Chart_Main.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData>Font=Verdana, 9pt;</StyleD" +
				"ata></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><Sty" +
				"leData>Font=Verdana, 7pt, style=Italic;AlignVert=Bottom;AlignHorz=Center;Rotatio" +
				"n=Rotate0;Border=None,Transparent,1;Opaque=False;BackColor=Transparent;</StyleDa" +
				"ta></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><Styl" +
				"eData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Tran" +
				"sparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name" +
				">LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Styl" +
				"eData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control<" +
				"/ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contr" +
				"ol</ParentName><StyleData>Border=None,Black,1;BackColor=Transparent;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><Sty" +
				"leData>Rotation=Rotate0;Border=None,Black,1;AlignHorz=General;Opaque=True;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><Parent" +
				"Name /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</" +
				"StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNa" +
				"me><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColo" +
				"r=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.d" +
				"efault</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Alig" +
				"nVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Cha" +
				"rtGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSer" +
				"iesCollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenro" +
				"d\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Dot\" /><S" +
				"eriesLabel>series 0</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;3.402823" +
				"4663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E" +
				"+38;3.4028234663852886E+38</X><Y>20;22;19;24;25;27;29;31;33;35;37;39;41;43;45;3." +
				"4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.40282346638" +
				"52886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;D" +
				"ouble;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesS" +
				"erializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>Tr" +
				"ue</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>Cl" +
				"usterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=T" +
				"rue,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMetho" +
				"d=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnot" +
				"ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3" +
				"D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGrou" +
				"p><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name" +
				"><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0" +
				"</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,Fill" +
				"Transparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>" +
				"EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True" +
				",PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0" +
				"</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup></Cha" +
				"rtGroupsCollection><Header Compass=\"North\"><Text /></Header><Footer Compass=\"Sou" +
				"th\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><Ch" +
				"artArea /><Axes><Axis Max=\"15\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"" +
				"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\">" +
				"<Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Das" +
				"h\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" " +
				"/></Axis><Axis Max=\"50\" Min=\"10\" UnitMajor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\" A" +
				"utoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text />" +
				"<GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Gr" +
				"idMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis" +
				"><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"T" +
				"rue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor " +
				"AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor Aut" +
				"oSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></C" +
				"hart2DPropBag>";
			this.Chart_Main.Size = new System.Drawing.Size(464, 164);
			this.Chart_Main.TabIndex = 64;
			// 
			// Chart_Main_tot
			// 
			this.Chart_Main_tot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Chart_Main_tot.DataSource = null;
			this.Chart_Main_tot.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart_Main_tot.Location = new System.Drawing.Point(544, 101);
			this.Chart_Main_tot.Name = "Chart_Main_tot";
			this.Chart_Main_tot.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData>Font=Verdana, 9pt;</StyleD" +
				"ata></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><Sty" +
				"leData>Font=Verdana, 7pt, style=Italic;AlignVert=Bottom;AlignHorz=Center;Rotatio" +
				"n=Rotate0;Border=None,Transparent,1;Opaque=False;BackColor=Transparent;</StyleDa" +
				"ta></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><Styl" +
				"eData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Tran" +
				"sparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name" +
				">LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Styl" +
				"eData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control<" +
				"/ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contr" +
				"ol</ParentName><StyleData>Border=None,Black,1;BackColor=Transparent;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><Sty" +
				"leData>Rotation=Rotate0;Border=None,Black,1;AlignHorz=General;Opaque=True;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><Parent" +
				"Name /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</" +
				"StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNa" +
				"me><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColo" +
				"r=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.d" +
				"efault</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Alig" +
				"nVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Cha" +
				"rtGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSer" +
				"iesCollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenro" +
				"d\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Dot\" /><S" +
				"eriesLabel>series 0</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;3.402823" +
				"4663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E" +
				"+38;3.4028234663852886E+38</X><Y>20;22;19;24;25;27;29;31;33;35;37;39;41;43;45;3." +
				"4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.40282346638" +
				"52886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;D" +
				"ouble;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesS" +
				"erializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>Fa" +
				"lse</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>C" +
				"lusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=" +
				"True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMeth" +
				"od=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnno" +
				"tations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use" +
				"3D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGro" +
				"up><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Nam" +
				"e><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=" +
				"0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,Fil" +
				"lTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble" +
				">EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=Tru" +
				"e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" +
				"0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup></Ch" +
				"artGroupsCollection><Header Compass=\"North\"><Text /></Header><Footer Compass=\"So" +
				"uth\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><C" +
				"hartArea Depth=\"20\" Rotation=\"45\" Elevation=\"45\" /><Axes><Axis Max=\"15\" Min=\"1\" " +
				"UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" A" +
				"utoMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Thi" +
				"ckness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickn" +
				"ess=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"50\" Min=\"10\" UnitMa" +
				"jor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=" +
				"\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"" +
				"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" " +
				"Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" Un" +
				"itMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onT" +
				"op=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"L" +
				"ightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"Ligh" +
				"tGray\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.Chart_Main_tot.Size = new System.Drawing.Size(448, 151);
			this.Chart_Main_tot.TabIndex = 65;
			// 
			// fgrid_main1
			// 
			this.fgrid_main1.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main1.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main1.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main1.Name = "fgrid_main1";
			this.fgrid_main1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main1.TabIndex = 28;
			// 
			// fgrid_view
			// 
			this.fgrid_view.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_view.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_view.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_view.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_view.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_view.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_view.Location = new System.Drawing.Point(0, 271);
			this.fgrid_view.Name = "fgrid_view";
			this.fgrid_view.Rows.Count = 2;
			this.fgrid_view.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_view.Size = new System.Drawing.Size(416, 185);
			this.fgrid_view.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_view.TabIndex = 67;
			this.fgrid_view.Click += new System.EventHandler(this.fgrid_view_Click);
			// 
			// Chart_view
			// 
			this.Chart_view.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.Chart_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.Chart_view.DataSource = null;
			this.Chart_view.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart_view.Location = new System.Drawing.Point(424, 264);
			this.Chart_view.Name = "Chart_view";
			this.Chart_view.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle" +
				"><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Bord" +
				"er=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;AlignV" +
				"ert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Ar" +
				"ea</ParentName><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz" +
				"=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedSty" +
				"le><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.defau" +
				"lt</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name>" +
				"<ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Na" +
				"me><ParentName>Control</ParentName><StyleData>Border=None,Black,1;BackColor=Tran" +
				"sparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Cont" +
				"rol</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedSt" +
				"yle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=ControlText;B" +
				"order=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>" +
				"AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=No" +
				"ne,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleDat" +
				"a></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Control</ParentN" +
				"ame><StyleData>Border=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></Styl" +
				"eCollection><ChartGroupsCollection><ChartGroup><DataSerializer Hole=\"3.402823466" +
				"3852886E+38\" DefaultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Line" +
				"Style Thickness=\"1\" Color=\"Blue\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" Ou" +
				"tlineColor=\"\" Shape=\"Box\" /><SeriesLabel>Delete</SeriesLabel><X>1;2;3;4;5;6;7;8;" +
				"9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30</X><Y>20;22;19;" +
				"24;25;26;27;29;30;35;37;40;42;45;47;3.4028234663852886E+38;3.4028234663852886E+3" +
				"8;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234" +
				"663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+" +
				"38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.402823" +
				"4663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 " +
				"/><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Dat" +
				"aFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness" +
				"=\"1\" Color=\"Magenta\" Pattern=\"Solid\" /><SymbolStyle Color=\"CornflowerBlue\" Outli" +
				"neColor=\"\" Shape=\"Dot\" /><SeriesLabel>Insert</SeriesLabel><X>1;2;3;4;5;6;7;8;9;1" +
				"0;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30</X><Y>8;12;10;12;1" +
				"5;16;17;19;21;23;25;27;29;31;33;3.4028234663852886E+38;3.4028234663852886E+38;3." +
				"4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.40282346638" +
				"52886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3" +
				".4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663" +
				"852886E+38;3.4028234663852886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\"" +
				" Color=\"Yellow\" Pattern=\"Solid\" /><SymbolStyle Color=\"Cornsilk\" OutlineColor=\"\" " +
				"Shape=\"Tri\" /><SeriesLabel>Search</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;" +
				"14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30</X><Y>10;16;17;15;23;24;25;26" +
				";27;29;31;35;37;41;44;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663" +
				"852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;" +
				"3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.402823466" +
				"3852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38" +
				";3.4028234663852886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>S" +
				"ingle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /" +
				"></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"Li" +
				"me\" Pattern=\"Solid\" /><SymbolStyle Color=\"Crimson\" OutlineColor=\"\" Shape=\"Diamon" +
				"d\" /><SeriesLabel>Update</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;" +
				"17;18;19;20;21;22;23;24;25;26;27;28;29;30</X><Y>16;19;15;22;18;19;20;21;23;25;29" +
				";34;38;39;42;46;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886" +
				"E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028" +
				"234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.402823466385288" +
				"6E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.402" +
				"8234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Do" +
				"uble</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer></Dat" +
				"aSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>False</Stacked><C" +
				"hartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,Cl" +
				"usterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=Fal" +
				"se,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,Maximu" +
				"mSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start" +
				"=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3D>False</Use3D><V" +
				"isible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup><ChartGroup><Da" +
				"taSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name><Stacked>False</" +
				"Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>Cluste" +
				"rOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True," +
				"FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Di" +
				"ameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotatio" +
				"ns=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>" +
				"True</Visible><ShowOutline>True</ShowOutline></ChartGroup></ChartGroupsCollectio" +
				"n><Header Compass=\"North\"><Text /></Header><Footer Compass=\"South\"><Text /></Foo" +
				"ter><Legend Compass=\"East\" Visible=\"True\"><Text /></Legend><ChartArea /><Axes><A" +
				"xis Max=\"30.625\" Min=\"-0.625\" UnitMajor=\"5\" UnitMinor=\"2.5\" AutoMajor=\"True\" Aut" +
				"oMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><" +
				"GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Gri" +
				"dMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis>" +
				"<Axis Max=\"50\" Min=\"5\" UnitMajor=\"5\" UnitMinor=\"2.5\" AutoMajor=\"True\" AutoMinor=" +
				"\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajo" +
				"r AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor A" +
				"utoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Ma" +
				"x=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" Auto" +
				"Max=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor AutoSpace" +
				"=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"T" +
				"rue\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPro" +
				"pBag>";
			this.Chart_view.Size = new System.Drawing.Size(592, 200);
			this.Chart_view.TabIndex = 68;
			this.Chart_view.Load += new System.EventHandler(this.Chart_view_Load);
			// 
			// fgrid_main2
			// 
			this.fgrid_main2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_main2.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main2.ColumnInfo = "5,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main2.Location = new System.Drawing.Point(0, 480);
			this.fgrid_main2.Name = "fgrid_main2";
			this.fgrid_main2.Rows.Count = 2;
			this.fgrid_main2.Size = new System.Drawing.Size(264, 160);
			this.fgrid_main2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main2.TabIndex = 69;
			this.fgrid_main2.Click += new System.EventHandler(this.fgrid_main2_Click);
			// 
			// Chart3
			// 
			this.Chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Chart3.DataSource = null;
			this.Chart3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Chart3.Location = new System.Drawing.Point(272, 464);
			this.Chart3.Name = "Chart3";
			this.Chart3.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData>Font=Verdana, 9pt;</StyleD" +
				"ata></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><Sty" +
				"leData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Tra" +
				"nsparent;Opaque=False;Font=Verdana, 7pt, style=Italic;AlignVert=Bottom;</StyleDa" +
				"ta></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><Styl" +
				"eData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor=Tran" +
				"sparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name" +
				">LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Styl" +
				"eData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control<" +
				"/ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contr" +
				"ol</ParentName><StyleData>Border=None,Black,1;BackColor=Transparent;</StyleData>" +
				"</NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><Sty" +
				"leData>Rotation=Rotate0;Border=None,Black,1;AlignHorz=General;Opaque=True;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><Parent" +
				"Name /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</" +
				"StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNa" +
				"me><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColo" +
				"r=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.d" +
				"efault</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Alig" +
				"nVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Cha" +
				"rtGroup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSer" +
				"iesCollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenro" +
				"d\" Pattern=\"Solid\" /><SymbolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Dot\" /><S" +
				"eriesLabel>series 0</SeriesLabel><X>1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;3.402823" +
				"4663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E" +
				"+38;3.4028234663852886E+38</X><Y>20;22;19;24;25;27;29;31;33;35;37;39;41;43;45;3." +
				"4028234663852886E+38;3.4028234663852886E+38;3.4028234663852886E+38;3.40282346638" +
				"52886E+38;3.4028234663852886E+38</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;D" +
				"ouble;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesS" +
				"erializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>Tr" +
				"ue</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>Cl" +
				"usterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=T" +
				"rue,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMetho" +
				"d=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnot" +
				"ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Use3" +
				"D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGrou" +
				"p><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Group2</Name" +
				"><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0" +
				"</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,Fill" +
				"Transparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>" +
				"EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True" +
				",PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0" +
				"</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGroup></Cha" +
				"rtGroupsCollection><Header Compass=\"North\"><Text /></Header><Footer Compass=\"Sou" +
				"th\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><Ch" +
				"artArea /><Axes><Axis Max=\"15\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"" +
				"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"South\">" +
				"<Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Das" +
				"h\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" " +
				"/></Axis><Axis Max=\"50\" Min=\"10\" UnitMajor=\"10\" UnitMinor=\"5\" AutoMajor=\"True\" A" +
				"utoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text />" +
				"<GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><Gr" +
				"idMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis" +
				"><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"T" +
				"rue\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compass=\"East\"><Text /><GridMajor " +
				"AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor Aut" +
				"oSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></C" +
				"hart2DPropBag>";
			this.Chart3.Size = new System.Drawing.Size(744, 168);
			this.Chart3.TabIndex = 70;
			// 
			// fgrid_Report
			// 
			this.fgrid_Report.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_Report.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Report.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Report.ColumnInfo = "6,1,0,0,0,90,Columns:0{Width:29;}\t";
			this.fgrid_Report.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Report.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Report.Location = new System.Drawing.Point(32, 208);
			this.fgrid_Report.Name = "fgrid_Report";
			this.fgrid_Report.Rows.Count = 2;
			this.fgrid_Report.Size = new System.Drawing.Size(648, 200);
			this.fgrid_Report.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Report.TabIndex = 71;
			this.fgrid_Report.Visible = false;
			 
			// 
			// Form_Sys_PGM_Monitor_By_Date
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_Report);
			this.Controls.Add(this.Chart3);
			this.Controls.Add(this.fgrid_main2);
			this.Controls.Add(this.Chart_view);
			this.Controls.Add(this.fgrid_view);
			this.Controls.Add(this.fgrid_main1);
			this.Controls.Add(this.Chart_Main_tot);
			this.Controls.Add(this.Chart_Main);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_Sys_PGM_Monitor_By_Date";
			this.Load += new System.EventHandler(this.Form_Sys_PGM_Monitor_By_Date_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.Chart_Main, 0);
			this.Controls.SetChildIndex(this.Chart_Main_tot, 0);
			this.Controls.SetChildIndex(this.fgrid_main1, 0);
			this.Controls.SetChildIndex(this.fgrid_view, 0);
			this.Controls.SetChildIndex(this.Chart_view, 0);
			this.Controls.SetChildIndex(this.fgrid_main2, 0);
			this.Controls.SetChildIndex(this.Chart3, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.fgrid_Report, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Main_tot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_view)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_view)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Report)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_Sys_PGM_Monitor_By_Date_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			fgrid_view.Visible  = false;
			Chart_view.Visible  = false;
			fgrid_main2.Visible = false;
			Chart3.Visible = false;

			this.tbtn_New.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Insert.Enabled = false;
			this.tbtn_Print.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Delete.Enabled = false; 
		}
		private void Init_Form()
		{
			this.Text = "System PGM ";
			cbo_factory.Text = "Chanhshin Viet Nam";
			this.lbl_MainTitle.Text = "System PGM Monitoring By Date";
			ClassLib.ComFunction.SetLangDic(this);
		
			fgrid_main.Set_Grid("SYS_PGM_MANAGER_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
				
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			FlexMold.ClassLib.ComVar.div = "4";
			Search_PGM();
			Search_no();
			SubTotalGrid();
			fgrid_main.TopRow = fgrid_main.Rows.Count -1;
			fgrid_main.Cols[2].StyleNew.BackColor = Color.YellowGreen ;
			//			Chart_PGM2();
			fgrid_main2.Visible = false;
			Chart3.Visible = false;
		}
		private void Search_PGM()
		{
			System.Data.DataTable vDt1 = null;
			if(FlexMold.ClassLib.ComVar.div == "1")
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SYS_PGM_MANAGER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else if(FlexMold.ClassLib.ComVar.div == "5")
			{
				fgrid_view.Clear();
				fgrid_view.Set_Grid("SYS_PGM_MANAGER_NEW1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else if(FlexMold.ClassLib.ComVar.div == "4")
			{
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SYS_PGM_MANAGER_NEW", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else if(FlexMold.ClassLib.ComVar.div == "6")
			{
				fgrid_Report.Clear();
				fgrid_Report.Set_Grid("SYS_PGM_REPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);			
			}
			else
			{
				fgrid_main2.Clear();
				fgrid_main2.Set_Grid("SYS_PGM_MANAGER2", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			try
			{
				vDt1 = SELECT_SYS_PGM();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						if(FlexMold.ClassLib.ComVar.div == "1")
						{
							fgrid_main.AddItem( vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						}
						else if(FlexMold.ClassLib.ComVar.div == "5")
						{
							fgrid_view.AddItem( vDt1.Rows[i].ItemArray, fgrid_view.Rows.Count, 1);
							fgrid_view.Cols[1].AllowMerging = true ;
						}
						else if(FlexMold.ClassLib.ComVar.div == "4")
						{
							fgrid_main.AddItem( vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						} 
						else if(FlexMold.ClassLib.ComVar.div == "6")
						{
							fgrid_Report.AddItem( vDt1.Rows[i].ItemArray, fgrid_Report.Rows.Count, 1);
							 
						} 
						else
						{
							fgrid_main2.AddItem( vDt1.Rows[i].ItemArray, fgrid_main2.Rows.Count, 1);
						}
						
					}
					fgrid_main.AutoSizeCols();
					fgrid_Report.AutoSizeCols(); 
					//					SubTotalGrid();
				}
				else
				{
					MessageBox.Show("No Data !!");
					return;
				}
			}
			

			catch
			{

			}
		}

		private System.Data.DataTable SELECT_SYS_PGM()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SYS_PGM_MON.SEARCH_PGM";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_YMD_FROM";
			OraDB.Parameter_Name[2] = "ARG_YMD_TO";
			OraDB.Parameter_Name[3] = "ARG_DIV";
			OraDB.Parameter_Name[4] = "ARG_PGM";
			OraDB.Parameter_Name[5] = "ARG_ACTION";
			OraDB.Parameter_Name[6] = "ARG_USER";
			OraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			
			OraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ" ;
			OraDB.Parameter_Values[1] = cmb_workday.Value.ToString("yyyyMMdd");
			OraDB.Parameter_Values[2] = dtpdate_to.Value.ToString("yyyyMMdd");
			if(FlexMold.ClassLib.ComVar.div == "1")
			{
				OraDB.Parameter_Values[3] = "1";
				OraDB.Parameter_Values[4] = "";
				OraDB.Parameter_Values[5] = "";
				OraDB.Parameter_Values[6] = "";
			}
			else if(FlexMold.ClassLib.ComVar.div == "5")
			{
				OraDB.Parameter_Values[3] = "5";
				OraDB.Parameter_Values[4] = fgrid_main[0 ,fgrid_main.ColSel].ToString();
				OraDB.Parameter_Values[5] = "";
				OraDB.Parameter_Values[6] = "";

			}
			else if(FlexMold.ClassLib.ComVar.div == "4")
			{
				OraDB.Parameter_Values[3] = "4";
				OraDB.Parameter_Values[4] = "";
				OraDB.Parameter_Values[5] = "";
				OraDB.Parameter_Values[6] = "";
			}
			else if(FlexMold.ClassLib.ComVar.div == "6")
			{
				OraDB.Parameter_Values[3] = "6";
				OraDB.Parameter_Values[4] = FlexMold.ClassLib.ComVar.pgm.ToString();
				OraDB.Parameter_Values[5] = FlexMold.ClassLib.ComVar.act ;
				OraDB.Parameter_Values[6] = fgrid_main2[fgrid_main2.RowSel,1].ToString(); 
			}
			else 
			{
				OraDB.Parameter_Values[3] = "3";
				OraDB.Parameter_Values[4] = FlexMold.ClassLib.ComVar.pgm.ToString();  
				OraDB.Parameter_Values[5] = fgrid_view[0,fgrid_view.ColSel].ToString().Substring(0,1);
				OraDB.Parameter_Values[6] = "";

			}
			
			OraDB.Parameter_Values[7] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}
		private void Search_no()
		{
			for ( int k = 1 ; k < fgrid_main.Rows.Count -1 ; k++ )
			{				
				fgrid_main[k+1,0] = k ;
			}
			//			for ( int m = 2 ; m < fgrid_main.Rows.Count; m++)
			//			{
			//				fgrid_main[m,0] = fgrid_main[m,1].ToString().Substring(6,2).Trim() ;
			//			}

		}
		private void Chart_PGM2()
		{
			setupChart2();
			setupData2();
		}
		private void Chart_PGM_TOT()
		{
			setupChart_tot();
			setupData_tot();
		}
		void setupChart2()
		{
			//			Chart_Main.ChartGroups.Group0.ChartData.SeriesList.Clear();   
			 
			//setup the chart style
			Chart_Main.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart_Main.Header.Text="PGM By Date";
			Chart_Main.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart_Main.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart_Main.ChartArea.Style.BackColor = Color.LightYellow;
			Chart_Main.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart_Main.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart_Main.ChartArea.AxisX.ForeColor = Color.Red;
			Chart_Main.ChartArea.AxisX.Min = 0;
			Chart_Main.ChartArea.AxisX.Max = fgrid_main.Rows.Count-3;

			Chart_Main.ChartArea.AxisY.ForeColor = Color.Blue;
			Chart_Main.ChartArea.AxisX.Text = "Date"; 
			Chart_Main.ChartArea.AxisY.Text = "Qty";   
		}	

		void setupData2()
		{			
			ArrayList arrQty	= new ArrayList();
			ArrayList arrUser   = new ArrayList();
			
			Chart_Main.ChartGroups[0].ChartData[0].Y.Length =  fgrid_main.Rows.Count-1;
			int col = fgrid_main.ColSel ;
			for ( int i = 2 ; i < fgrid_main.Rows.Count-1; i++)
			{
				arrUser.Add(double.Parse(Convert.ToString(fgrid_main[(short)i,0])));
				if (fgrid_main[(short)i,col] == "" )
				{
					arrQty.Add(0);
				}
				else
				{
					arrQty.Add(double.Parse(Convert.ToString(fgrid_main[(short)i,col])));
				}
			}

			Chart_Main.ChartGroups[0].ChartData[0].X.CopyDataIn((double[])arrUser.ToArray(typeof(double)));
			Chart_Main.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty.ToArray(typeof(double)));
			
			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = Chart_Main.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;
	
			ax.ValueLabels.Clear();
			for( int j = 2 ; j <= fgrid_main.Rows.Count-2 ; j++) 
			{
				string temp = fgrid_main[j,1].ToString().Substring(6,2);
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j-1;
				vlbl.Text = temp ;
					
			}
		}
		void setupData_tot()
		{			
			ArrayList arrQty1	= new ArrayList();
			ArrayList arrUser1   = new ArrayList();
			
			Chart_Main_tot.ChartGroups[0].ChartData[0].Y.Length =  fgrid_main.Cols.Count-2;

			int row = fgrid_main.RowSel;
			for ( int i = 3 ; i < fgrid_main.Cols.Count; i++)
			{
				//				arrUser.Add((short)i);
				//				arrUser.Add(double.Parse(Convert.ToString(fgrid_main[(short)i,1].ToString().Substring(7,2))));
				if (fgrid_main[row,(short)i] == "" )
				{
					arrQty1.Add(0);
				}
				else
				{
					arrQty1.Add(double.Parse(Convert.ToString(fgrid_main[row,(short)i])));
				}
			}

			//			Chart_Main.ChartGroups[0].ChartData[0].X.CopyDataIn((long[])arrUser.ToArray(typeof(long)));
			Chart_Main_tot.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty1.ToArray(typeof(double)));
			
			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = Chart_Main_tot.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;
	
			ax.ValueLabels.Clear();
			for( int j = 3 ; j <= fgrid_main.Cols.Count-1 ; j++) 
			{
				string temp = fgrid_main[0,j].ToString();
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j-2;
				vlbl.Text = temp ;
					
			}
		}
		void setupChart_tot()
		{
			// clear data
			//			Chart1.ChartGroups[0].ChartData.SeriesList.Clear();
			
			//			Chart_Main.ChartGroups.Group0.ChartData.SeriesList.Clear();    
			//setup the chart style
			Chart_Main_tot.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart_Main_tot.Header.Text="PGM";
			Chart_Main_tot.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart_Main_tot.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart_Main_tot.ChartArea.Style.BackColor = Color.LightYellow;
			Chart_Main_tot.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart_Main_tot.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart_Main_tot.ChartArea.AxisX.ForeColor = Color.Red;
			Chart_Main_tot.ChartArea.AxisX.Min = 0;
			Chart_Main_tot.ChartArea.AxisX.Max = fgrid_main.Cols.Count-3;

			Chart_Main_tot.ChartArea.AxisY.ForeColor = Color.Blue;
			Chart_Main_tot.ChartArea.AxisX.Text = "PGM"; 
			Chart_Main_tot.ChartArea.AxisY.Text = "Qty";   
		}


		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			FlexMold.ClassLib.ComVar.pgm = fgrid_main[0,fgrid_main.ColSel].ToString(); 
			this.tbtn_Print.Enabled = false;
			for(int j = 2 ; j <fgrid_main.Cols.Count ; j++)
			{
				fgrid_main.Cols[j].StyleNew.ForeColor = System.Drawing.SystemColors.WindowText; 
			}
		    if ((fgrid_main.Col >= 2)&& (fgrid_main.RowSel  < fgrid_main.Rows.Count-1))	
			{				
				Chart_PGM2();
				Chart_Main_tot.Visible = false;
				Chart_Main.Visible = true;

				if (fgrid_main.Col > 2)
				{
					fgrid_view.Visible  = true;
					Chart_view.Visible  = true;
					fgrid_main2.Visible = false;
					Chart3.Visible = false;
					fgrid_view.Clear();
					fgrid_view.Set_Grid("SYS_PGM_MANAGER_NEW1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					FlexMold.ClassLib.ComVar.div = "5";
					Search_PGM();
					Chart_PGM1();
					SubTotalGrid1();
					fgrid_view.TopRow = fgrid_view.Rows.Count-1; 
				}
				else
				{
					fgrid_view.Visible  = false;
					Chart_view.Visible  = false;
					fgrid_main2.Visible = false;
					Chart3.Visible = false;
				}
			
				fgrid_main.Cols[fgrid_main.ColSel].StyleNew.ForeColor = Color.Red;
			}
			else 
			{
				if (fgrid_main.RowSel  == fgrid_main.Rows.Count-1) 
				{
					Chart_PGM_TOT();				
					Chart_Main_tot.Visible = true;
					Chart_Main.Visible = false;			
//					fgrid_main..Rows[fgrid_main.RowSel].StyleNew.ForeColor = Color.Yellow;
				}
				else
					MessageBox.Show("Please choose From Col 2.");					
			fgrid_view.Visible  = false;
			Chart_view.Visible  = false;
			fgrid_main2.Visible = false;
			Chart3.Visible = false;			
			}	

		}
		private void SubTotalGrid()
		{
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			for ( int k = 3 ; k<=11; k++)
			{
				fgrid_main.Subtotal(AggregateEnum.Sum, -1,-1, k, "GTotal");
			}

			fgrid_main.AutoSizeCols(); 
		}
		private void SubTotalGrid1()
		{
			fgrid_view.Subtotal(AggregateEnum.Clear);
			fgrid_view.SubtotalPosition = SubtotalPositionEnum.BelowData;
			for ( int k = 2 ; k <=5; k++)
			{
				fgrid_view.Subtotal(AggregateEnum.Sum, -1,-1, k, "GTotal");
			}

//			fgrid_view.AutoSizeCols(); 
		}
		
		private void Chart_PGM1()
		{
			setupChart1();
			setupData1();
		}
		void setupChart1()
		{	
			//setup the chart style
			Chart_view.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart_view.Header.Text="PGM Action";
			Chart_view.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart_view.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart_view.ChartArea.Style.BackColor = Color.LightYellow;
			Chart_view.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart_view.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart_view.ChartArea.AxisX.ForeColor = Color.Red;
			Chart_view.ChartArea.AxisX.Min = 0;
			Chart_view.ChartArea.AxisX.Max = fgrid_view.Rows.Count-1;
			  
			Chart_view.ChartArea.AxisY.ForeColor = Color.Blue;
			Chart_view.ChartArea.AxisX.Text = "Date"; 
			Chart_view.ChartArea.AxisY.Text = "Qty";   
		}

		void setupData1()
		{			
			Chart_view.ChartGroups[0].ChartData[0].Y.Length =  fgrid_view.Rows.Count-1;
//			Chart_view.ChartGroups[0].ChartData[0].X.Length =  fgrid_view.Rows.Count-1;
			Chart_view.ChartGroups[0].ChartData[1].Y.Length =  fgrid_view.Rows.Count-1;
			Chart_view.ChartGroups[0].ChartData[2].Y.Length =  fgrid_view.Rows.Count-1;
			Chart_view.ChartGroups[0].ChartData[3].Y.Length =  fgrid_view.Rows.Count-1;

			int a = Chart_view.ChartGroups.ChartGroupsCollection[0].ChartData.SeriesList.Count;
			if (a  < 4)
				series0 = Chart_view.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
					
			// Setup the Axis X
			C1.Win.C1Chart.Axis ax = Chart_view.ChartArea.AxisX;
			ax.Font = new Font("Arial", 8);
			ax.Thickness = 2;
			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
			ax.GridMajor.Color = Color.DarkGray;
			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
			ax.GridMajor.Thickness = 2;
			ax.GridMajor.Visible = true;

			ax.ValueLabels.Clear();
			for( int j = 2 ; j <= fgrid_view.Rows.Count-1 ; j++) 
			{					
				string temp = fgrid_view[j,1].ToString().Substring(6,2);
				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
				vlbl.NumericValue = j-1;
				vlbl.Text = temp;
			}
			
			ArrayList arrPgm	= new ArrayList();
			ArrayList arrDelete	= new ArrayList();
			ArrayList arrInsert	= new ArrayList();
			ArrayList arrSearch	= new ArrayList();
			ArrayList arrUpdate	= new ArrayList();

			for(int k = 2 ; k < fgrid_view.Rows.Count; k++)
			{
				arrPgm.Add(fgrid_view[(short)k,1]);
				arrDelete.Add(double.Parse(Convert.ToString(fgrid_view[(short)k,2])));
				arrInsert.Add(double.Parse(Convert.ToString(fgrid_view[(short)k,3])));
				arrSearch.Add(double.Parse(Convert.ToString(fgrid_view[(short)k,4])));
				arrUpdate.Add(double.Parse(Convert.ToString(fgrid_view[(short)k,5])));
			}

			// setup group0 data
			Chart_view.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrDelete.ToArray(typeof(double)));
			Chart_view.ChartGroups[0].ChartData[1].Y.CopyDataIn((double[])arrInsert.ToArray(typeof(double)));
			Chart_view.ChartGroups[0].ChartData[2].Y.CopyDataIn((double[])arrSearch.ToArray(typeof(double)));
			Chart_view.ChartGroups[0].ChartData[3].Y.CopyDataIn((double[])arrUpdate.ToArray(typeof(double)));		

		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		private void Chart_view_Load(object sender, System.EventArgs e)
		{
		
		}

		private void fgrid_view_Click(object sender, System.EventArgs e)
		{
			FlexMold.ClassLib.ComVar.act = fgrid_view[0,fgrid_view.ColSel].ToString().Substring(0,1); 
			this.tbtn_Print.Enabled = false;
			for(int j = 2 ; j <fgrid_view.Cols.Count; j++)
			{
				fgrid_view.Cols[j].StyleNew.ForeColor = System.Drawing.SystemColors.WindowText; 
			}
			if (fgrid_view.ColSel > 1)
			{	
				fgrid_main2.Visible = true;
				Chart3.Visible = true;
				FlexMold.ClassLib.ComVar.div = "3";
				Search_PGM();
				Search_no1();
				Chart_PGM3();
				fgrid_view.Cols[fgrid_view.ColSel].StyleNew.ForeColor = Color.Red;
			}
			else
			{
				MessageBox.Show("Please choose From Col 2.");
				fgrid_main2.Visible = false;
				Chart3.Visible = false;
//				return;				
			}
		}
		private void Chart_PGM3()
		{
			setupChart3();
			setupData3();
		}
		void setupChart3()
		{			
			//setup the chart style
			Chart3.Style.BackColor = Color.LightBlue;

			//setup the chart header
			Chart3.Header.Text="PGM By User";
			Chart3.Header.Style.Border.BorderStyle=C1.Win.C1Chart.BorderStyleEnum.Raised;
			Chart3.Header.Style.Font = new Font( "Arial", 12);

			//setup the chart area
			Chart3.ChartArea.Style.BackColor = Color.LightYellow;
			Chart3.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel;
			Chart3.ChartArea.Style.Border.Thickness = 4;

			//setup axes
			Chart3.ChartArea.AxisX.ForeColor = Color.Red;
			Chart3.ChartArea.AxisX.Min = 0;
			Chart3.ChartArea.AxisX.Max = fgrid_main2.Rows.Count-1;

			Chart3.ChartArea.AxisY.ForeColor = Color.Blue;
			Chart3.ChartArea.AxisX.Text = "User"; 
			Chart3.ChartArea.AxisY.Text = "Qty";   

		}

		void setupData3()
		{	
			string [] _use = null;
			char [] _determid =".".ToCharArray();

			ArrayList arrQty	= new ArrayList();
			ArrayList arrUser   = new ArrayList();
			
			Chart3.ChartGroups[0].ChartData[0].Y.Length =  fgrid_main2.Rows.Count-2;

			for ( int i = 2 ; i < fgrid_main2.Rows.Count; i++)
			{
				arrUser.Add(double.Parse(Convert.ToString(fgrid_main2[(short)i,0])));
				arrQty.Add(double.Parse(Convert.ToString(fgrid_main2[(short)i,2])));
			}

			Chart3.ChartGroups[0].ChartData[0].X.CopyDataIn((double[])arrUser.ToArray(typeof(double)));
			Chart3.ChartGroups[0].ChartData[0].Y.CopyDataIn((double[])arrQty.ToArray(typeof(double)));
			
			// Setup the Axis X
//			C1.Win.C1Chart.Axis ax = Chart3.ChartArea.AxisX;
//			ax.Font = new Font("Arial", 8);
//			ax.Thickness = 2;
//			ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels; 
//			ax.GridMajor.Color = Color.DarkGray;
//			ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
//			ax.GridMajor.Thickness = 2;
//			ax.GridMajor.Visible = true;
//	
//			ax.ValueLabels.Clear();
//			for( int j = 2 ; j <= fgrid_main2.Rows.Count-2 ; j++) 
//			{				
//				string temp = fgrid_main2[j,1].ToString() ;
//				_use = temp.ToString().Split(_determid);
//				C1.Win.C1Chart.ValueLabel vlbl = ax.ValueLabels.AddNewLabel();
//				vlbl.NumericValue = j-1;
//				vlbl.Text = _use[0] ;
//					
//			}
		}
		private void Search_no1()
		{
			for ( int k = 1 ; k < fgrid_main2.Rows.Count -1 ; k++ )
			{				
				fgrid_main2[k+1,0] = k ;
			}

		}

		private void fgrid_main2_Click(object sender, System.EventArgs e)
		{
			if (fgrid_main2.Row >= 2)
			{
				FlexMold.ClassLib.ComVar.Click_use = fgrid_main2[fgrid_main2.RowSel,1].ToString();     
				FlexMold.ClassLib.ComVar.div = "6";
				Search_PGM();
				this.tbtn_Print.Enabled = true;
			}
			else
				this.tbtn_Print.Enabled = false;
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Report.AddItem("",0);
			for (int i = 1 ; i < fgrid_Report.Cols.Count ; i ++)
				fgrid_Report[0,i]= "USER REPORT " ;
			fgrid_Report.Rows[0].AllowMerging = true ;
			fgrid_Report.Rows[0].Height = 50 ;
			fgrid_Report.Rows[0].TextAlign = TextAlignEnum.CenterCenter ;
			fgrid_Report.Rows[0].StyleNew.ForeColor = Color.Red ;
			fgrid_Report.GetCellRange(0,0,0,fgrid_Report.Cols.Count-1).StyleNew.Font = new Font("Verdana", 16, FontStyle.Bold);
			
			//			arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			//			fgrid_Multi.GetCellRange(row_mold_qty,0, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.BackColor = Color.FromArgb(251, 248, 185);
			//			fgrid_Multi.GetCellRange(row_mold_qty,10, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.Font = new Font("Verdana", 7, FontStyle.Bold);
			//			fgrid_Multi.GetCellRange(row_mold_qty,10, row_mold_qty, fgrid_Multi.Cols.Count-1).StyleNew.ForeColor = Color.FromArgb(203, 73, 203);
			     
			fgrid_Report.PrintGrid("",PrintGridFlags.ShowPageSetupDialog);
			fgrid_Report.RemoveItem(0);			  			 		
			 
		}

	}
}

