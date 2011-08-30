using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_Daily_Report : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker cmb_workday;
		private System.Windows.Forms.Label lbl_work_ymd;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_repairarea1;
		private System.Windows.Forms.Label lbl_repairarea;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo CboLine_CD;
		private System.Windows.Forms.Label lbl15;

		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Daily_Report()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Daily_Report));
			this.panel1 = new System.Windows.Forms.Panel();
			this.CboLine_CD = new C1.Win.C1List.C1Combo();
			this.lbl15 = new System.Windows.Forms.Label();
			this.cmb_repairarea1 = new C1.Win.C1List.C1Combo();
			this.lbl_repairarea = new System.Windows.Forms.Label();
			this.cmb_workday = new System.Windows.Forms.DateTimePicker();
			this.lbl_work_ymd = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CboLine_CD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
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
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			this.panel1.Controls.Add(this.CboLine_CD);
			this.panel1.Controls.Add(this.lbl15);
			this.panel1.Controls.Add(this.cmb_repairarea1);
			this.panel1.Controls.Add(this.lbl_repairarea);
			this.panel1.Controls.Add(this.cmb_workday);
			this.panel1.Controls.Add(this.lbl_work_ymd);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 48);
			this.panel1.TabIndex = 28;
			// 
			// CboLine_CD
			// 
			this.CboLine_CD.AddItemCols = 0;
			this.CboLine_CD.AddItemSeparator = ';';
			this.CboLine_CD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.CboLine_CD.Caption = "";
			this.CboLine_CD.CaptionHeight = 17;
			this.CboLine_CD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.CboLine_CD.ColumnCaptionHeight = 17;
			this.CboLine_CD.ColumnFooterHeight = 17;
			this.CboLine_CD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.CboLine_CD.ContentHeight = 18;
			this.CboLine_CD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.CboLine_CD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.CboLine_CD.EditorFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.CboLine_CD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.CboLine_CD.EditorHeight = 18;
			this.CboLine_CD.GapHeight = 2;
			this.CboLine_CD.ItemHeight = 15;
			this.CboLine_CD.Location = new System.Drawing.Point(768, 10);
			this.CboLine_CD.MatchEntryTimeout = ((long)(2000));
			this.CboLine_CD.MaxDropDownItems = ((short)(5));
			this.CboLine_CD.MaxLength = 32767;
			this.CboLine_CD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.CboLine_CD.Name = "CboLine_CD";
			this.CboLine_CD.PartialRightColumn = false;
			this.CboLine_CD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.CboLine_CD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.CboLine_CD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.CboLine_CD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.CboLine_CD.Size = new System.Drawing.Size(104, 24);
			this.CboLine_CD.TabIndex = 30;
			// 
			// lbl15
			// 
			this.lbl15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl15.ForeColor = System.Drawing.Color.Blue;
			this.lbl15.Location = new System.Drawing.Point(696, 15);
			this.lbl15.Name = "lbl15";
			this.lbl15.Size = new System.Drawing.Size(64, 16);
			this.lbl15.TabIndex = 29;
			this.lbl15.Text = "Factory";
			// 
			// cmb_repairarea1
			// 
			this.cmb_repairarea1.AddItemCols = 0;
			this.cmb_repairarea1.AddItemSeparator = ';';
			this.cmb_repairarea1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_repairarea1.Caption = "";
			this.cmb_repairarea1.CaptionHeight = 17;
			this.cmb_repairarea1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_repairarea1.ColumnCaptionHeight = 17;
			this.cmb_repairarea1.ColumnFooterHeight = 17;
			this.cmb_repairarea1.ContentHeight = 17;
			this.cmb_repairarea1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_repairarea1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_repairarea1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_repairarea1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_repairarea1.EditorHeight = 17;
			this.cmb_repairarea1.GapHeight = 2;
			this.cmb_repairarea1.ItemHeight = 15;
			this.cmb_repairarea1.Location = new System.Drawing.Point(504, 10);
			this.cmb_repairarea1.MatchEntryTimeout = ((long)(2000));
			this.cmb_repairarea1.MaxDropDownItems = ((short)(5));
			this.cmb_repairarea1.MaxLength = 32767;
			this.cmb_repairarea1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_repairarea1.Name = "cmb_repairarea1";
			this.cmb_repairarea1.PartialRightColumn = false;
			this.cmb_repairarea1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_repairarea1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_repairarea1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_repairarea1.Size = new System.Drawing.Size(179, 23);
			this.cmb_repairarea1.TabIndex = 26;
			// 
			// lbl_repairarea
			// 
			this.lbl_repairarea.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_repairarea.ForeColor = System.Drawing.Color.Blue;
			this.lbl_repairarea.Location = new System.Drawing.Point(385, 14);
			this.lbl_repairarea.Name = "lbl_repairarea";
			this.lbl_repairarea.Size = new System.Drawing.Size(108, 16);
			this.lbl_repairarea.TabIndex = 25;
			this.lbl_repairarea.Text = "Repairing Area";
			// 
			// cmb_workday
			// 
			this.cmb_workday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.cmb_workday.Location = new System.Drawing.Point(224, 9);
			this.cmb_workday.Name = "cmb_workday";
			this.cmb_workday.Size = new System.Drawing.Size(104, 22);
			this.cmb_workday.TabIndex = 23;
			// 
			// lbl_work_ymd
			// 
			this.lbl_work_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_work_ymd.ForeColor = System.Drawing.Color.Blue;
			this.lbl_work_ymd.Location = new System.Drawing.Point(168, 14);
			this.lbl_work_ymd.Name = "lbl_work_ymd";
			this.lbl_work_ymd.Size = new System.Drawing.Size(48, 16);
			this.lbl_work_ymd.TabIndex = 22;
			this.lbl_work_ymd.Text = "Date";
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
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(80, 10);
			this.cbo_factory.MatchEntryTimeout = ((long)(2000));
			this.cbo_factory.MaxDropDownItems = ((short)(5));
			this.cbo_factory.MaxLength = 32767;
			this.cbo_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_factory.Name = "cbo_factory";
			this.cbo_factory.PartialRightColumn = false;
			this.cbo_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_factory.Size = new System.Drawing.Size(64, 23);
			this.cbo_factory.TabIndex = 21;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ForeColor = System.Drawing.Color.Blue;
			this.lbl_factory.Location = new System.Drawing.Point(8, 12);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 20;
			this.lbl_factory.Text = "Factory";
			// 
			// Form_PB_Mold_Daily_Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Daily_Report";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Daily_Report_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CboLine_CD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_repairarea1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Daily_Report_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			this.tbtn_New.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
			this.tbtn_Search.Enabled = false;
		}
		private void Init_Form()
		{
			cbo_factory.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Repairing Daily Report";
			ClassLib.ComFunction.SetLangDic(this);
			
//			fgrid_mold.Set_Grid("SDT_MOLD_LOCATE_MANAGER1", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			
//			fgrid_mold.Set_Action_Image(img_Action);
//			fgrid_mold.ExtendLastCol = false;
//			fgrid_mold.AutoSizeCols();

//			DataTable dt_ret = Select_com_filter_code_List("SDV15");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

//			dt_ret = Select_com_filter_code_List("MD03");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_parttype, 0, 1, false, false);

			DataTable dt_ret = Select_com_filter_code_List("SDV40");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_repairarea1, 0, 1, false, false);
			cmb_repairarea1.SelectedIndex = 0;
			
			DataTable dt_list = SELECT_LINE();
			FlexMold.ClassLib.ComCtl.Set_ComboList(dt_list, CboLine_CD, 0, 1, true);  						
			
		}
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

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename;
//			if ((cbo_wh.Text.ToString() == "")||(cbo_wh.Columns[0].Text =="ALL"))
			if (CboLine_CD.Columns[0].Text == "105")
				mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Form_Mold_Daily_By_Fty3");
			else if (CboLine_CD.Columns[0].Text == "107")
			{	
				mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Form_Mold_Daily_By_Fty4");
			}
			else if (CboLine_CD.Columns[0].Text == "099")
			{	
				mrd_Filename = FlexMold.ClassLib.ComFunction.Set_RD_Directory("Form_Mold_Daily_By_NITC");
			}

			else 
			{
				MessageBox.Show("Please choose Factory. ");
				return;
			}


			string Para         = " ";

			#region 출력조건

			int  iCnt  = 4;
			string [] aHead =  new string[iCnt];	
			
			string[] vProviso = GetSearchProviso();
			

			if (cbo_factory.Text == "")
				aHead[0]    = "VJ";
			else
				aHead[0]    = cbo_factory.Text.Trim();
//			aHead[1]    = cmb_workday.Text.Replace("-","").Replace("/","");
			aHead[1]    = cmb_workday.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","");
			
			if((cmb_repairarea1.Text == "")||(cmb_repairarea1.Columns[0].Text == "ALL"))
			{
				aHead[2]	 = "";
				aHead[3]	 = "";
			}
			else
			{
				aHead[2] = cmb_repairarea1.Columns[0].Text;			
				aHead[3] = cmb_repairarea1.Text ;
			}

			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			FlexMold.Report.Form_RdViewer report = new FlexMold.Report.Form_RdViewer(mrd_Filename, Para);
			report.Show();	
		}
		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[30];
			return vProviso;
		}
		public System.Data.DataTable SELECT_LINE()
		{
			//			DataTable dt;
			System.Data.DataSet retDS;

			OraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SELECT_FAC";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FAC";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}
	}
}

