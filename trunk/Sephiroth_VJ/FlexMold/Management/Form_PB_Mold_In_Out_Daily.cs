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
	public class Form_PB_Mold_In_Out_Daily : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dtp_In;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo cbo_wh;
		private System.Windows.Forms.Label label12;
		private C1.Win.C1List.C1Combo cbo_factory;
		private System.Windows.Forms.Label label1;
		public COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
//		private System.Data.DataTable dt_list;

		public Form_PB_Mold_In_Out_Daily()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_In_Out_Daily));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtp_In = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cbo_wh = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.cbo_factory = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.dtp_In);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.cbo_wh);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cbo_factory);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 32;
			// 
			// dtp_In
			// 
			this.dtp_In.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_In.Location = new System.Drawing.Point(344, 8);
			this.dtp_In.Name = "dtp_In";
			this.dtp_In.Size = new System.Drawing.Size(112, 22);
			this.dtp_In.TabIndex = 73;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(280, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 21);
			this.label5.TabIndex = 72;
			this.label5.Text = "Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbo_wh
			// 
			this.cbo_wh.AddItemCols = 0;
			this.cbo_wh.AddItemSeparator = ';';
			this.cbo_wh.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cbo_wh.Caption = "";
			this.cbo_wh.CaptionHeight = 17;
			this.cbo_wh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cbo_wh.ColumnCaptionHeight = 17;
			this.cbo_wh.ColumnFooterHeight = 17;
			this.cbo_wh.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_wh.ContentHeight = 17;
			this.cbo_wh.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_wh.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cbo_wh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_wh.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_wh.EditorHeight = 17;
			this.cbo_wh.GapHeight = 2;
			this.cbo_wh.ItemHeight = 15;
			this.cbo_wh.Location = new System.Drawing.Point(560, 6);
			this.cbo_wh.MatchEntryTimeout = ((long)(2000));
			this.cbo_wh.MaxDropDownItems = ((short)(5));
			this.cbo_wh.MaxLength = 32767;
			this.cbo_wh.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cbo_wh.Name = "cbo_wh";
			this.cbo_wh.PartialRightColumn = false;
			this.cbo_wh.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cbo_wh.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cbo_wh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cbo_wh.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cbo_wh.Size = new System.Drawing.Size(136, 23);
			this.cbo_wh.TabIndex = 63;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(464, 10);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(96, 18);
			this.label12.TabIndex = 62;
			this.label12.Text = "Warehouse";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cbo_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cbo_factory.ContentHeight = 17;
			this.cbo_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cbo_factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cbo_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbo_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cbo_factory.EditorHeight = 17;
			this.cbo_factory.Enabled = false;
			this.cbo_factory.GapHeight = 2;
			this.cbo_factory.ItemHeight = 15;
			this.cbo_factory.Location = new System.Drawing.Point(80, 8);
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
			this.cbo_factory.Size = new System.Drawing.Size(184, 23);
			this.cbo_factory.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(15, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Factory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "8,1,0,0,0,95,Columns:0{Width:29;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 104);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 3;
			this.fgrid_main.Rows.Fixed = 3;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 544);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{TextAlign:LeftCenter;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{Font:Verdana, 9pt, style=Bold;BackColor:128, 255, 128;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 53;
			// 
			// Form_PB_Mold_In_Out_Daily
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_In_Out_Daily";
			this.Load += new System.EventHandler(this.Form_PB_Mold_In_Out_Daily_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cbo_wh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbo_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_In_Out_Daily_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			this.tbtn_New.Enabled = false;
			this.tbtn_Save.Enabled = false;
			this.tbtn_Append.Enabled = false;
			this.tbtn_Color.Enabled = false;
			this.tbtn_Delete.Enabled = false;
			this.tbtn_Insert.Enabled = false;
		}
		private void Init_Form()	
		{
			this.lbl_MainTitle.Text = "Mold Input && Output Daily Report";
			ClassLib.ComFunction.SetLangDic(this);

			fgrid_main.Set_Grid("SDT_MOLD_IN_OUT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.ExtendLastCol = false;

			DataTable dt_ret = Select_com_filter_code_List("SBC21");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_factory, 0, 1, false, false);
			cbo_factory.SelectedValue = "VJ";			

			dt_ret = Select_com_filter_code_List("SDV15");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

			// set up Subtotal
			fgrid_main.Tree.Column = 2;
			CellStyle s = fgrid_main.Styles[CellStyleEnum.GrandTotal];
			s.BackColor = Color.YellowGreen;
			s.ForeColor = Color.White;
			s.Font = new Font(fgrid_main.Font, FontStyle.Bold);
			//
			//			fgrid_main.Rows[1].AllowMerging = true;
			//			fgrid_main.Cols[1].AllowMerging = true; 
			//			fgrid_main.Cols[2].AllowMerging = true; 
			//			fgrid_main.Cols[3].AllowMerging = true; 
			//			fgrid_main.Cols[4].AllowMerging = true; 

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

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Search_Main();			
		}
		private void Search_Main()
		{
			DataTable vDt1 = null;		
				
			try
			{
				vDt1 = SELECT_MOLD_MAIN();    
				fgrid_main.Clear();
				fgrid_main.Set_Grid("SDT_MOLD_IN_OUT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);
						fgrid_main.ExtendLastCol = false;
						fgrid_main.AutoSizeCols();
					}
//					SubTotalGrid();
					GrandTotal();
				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
//				for(int i =2; i<fgrid_main.Rows.Count;i++)
//					fgrid_main[i,0] = "  ";
			}
			catch
			{
			}
		}
		private System.Data.DataTable SELECT_MOLD_MAIN()
		{
			System.Data.DataSet retDS;                  
			OraDB.ReDim_Parameter(4); 

			//01.PROCEDURE¢¬i

			OraDB.Process_Name = "PKG_SDT_MOLD.SELECT_MOLD_IN_OUT";

			//02.ARGURMENT ¢¬i

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_WORK_YMD";
			OraDB.Parameter_Name[2] = "ARG_WH_CD";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE A¢´AC

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = cbo_factory.SelectedValue.ToString()  ;
//			OraDB.Parameter_Values[1] = dtp_In.Text.ToString().Replace("-","").Replace("/","");
			OraDB.Parameter_Values[1] = dtp_In.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = cbo_wh.SelectedValue.ToString();

			OraDB.Parameter_Values[3] = "" ;

			OraDB.Add_Select_Parameter(true);

			retDS = OraDB.Exe_Select_Procedure();

			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
//			if(fgrid_Mold.Rows.Count < _Ix_gen_e+1) return;

//			fgrid_main.Rows.Remove(fgrid_main.Rows.Count-2 );

			string filename = this.Name + ".txt";
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;

            //fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma, false);
            fgrid_main.SaveGrid(filename, FileFormatEnum.TextComma);

			string mold_type = cbo_factory.Text;

			string mold_status = cbo_wh.Text;

			//Form_Report_Mold report = new Form_Report_Mold(filename, mold_type, mold_status);
			//report.ShowDialog();

			string para = "/rfn [" + Application.StartupPath + @"\" + this.Name + ".txt] /rv V_MTYPE[" +mold_type
				+ "] V_MSTATUS[" + mold_status + "]";
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MOLD IN && OUT", this.Name +".mrd", para);
			report.ShowDialog();
		}

		private void SubTotalGrid()
		{
			
			fgrid_main.Subtotal(AggregateEnum.Clear);
			fgrid_main.SubtotalPosition = SubtotalPositionEnum.BelowData;
			fgrid_main.Subtotal(AggregateEnum.Count, -1,-1, 6, "GTotal");
			fgrid_main.Subtotal(AggregateEnum.Count, -1,-1, 12, "GTotal");
//			fgrid_main.Subtotal(AggregateEnum.Sum, 0, 2, 4, "STotal");			 
		}
		private void GrandTotal()
		{
			int sl_in = 0 ;
			int sl_out = 0 ;
			for (int j = 3 ; j < fgrid_main.Rows.Count ; j ++)			
			{
				if ( fgrid_main[j,6] != "" )
				{
					sl_out = sl_out + 1 ;
				}
				
				if (fgrid_main[j,12] != "" )	
				{
					sl_in = sl_in + 1 ;
				}
			}
			fgrid_main.Rows.Add();
			fgrid_main[fgrid_main.Rows.Count - 1,2] = "GTotal";
			fgrid_main[fgrid_main.Rows.Count - 1,6] = sl_out;
			fgrid_main[fgrid_main.Rows.Count - 1,12] = sl_in;
			fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1,0,fgrid_main.Rows.Count - 1,fgrid_main.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;
			fgrid_main.Rows[fgrid_main.Rows.Count-1].StyleNew.BackColor = Color.GreenYellow;
			fgrid_main.GetCellRange(fgrid_main.Rows.Count - 1,0,fgrid_main.Rows.Count - 1,fgrid_main.Cols.Count - 1).StyleNew.Font = new Font("Verdana", 10, FontStyle.Bold);
			fgrid_main.AutoSizeRows();
		}		

	}
}

