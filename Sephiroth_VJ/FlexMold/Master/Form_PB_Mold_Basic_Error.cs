using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Master
{
	public class Form_PB_Mold_Basic_Error : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_comp;
		private COM.FSP fgrid_main;
		//private C1.Win.C1List.C1Combo cmb_factory;
		//private C1.Win.C1List.C1Combo cmb_parttype;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_fac;
		private C1.Win.C1List.C1Combo cmb_parttyp;
		
		private COM.OraDB OraDB = new COM.OraDB();

		public Form_PB_Mold_Basic_Error()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_Basic_Error));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmb_parttyp = new C1.Win.C1List.C1Combo();
			this.cmb_fac = new C1.Win.C1List.C1Combo();
			this.lbl_comp = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttyp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_fac)).BeginInit();
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cmb_parttyp);
			this.panel1.Controls.Add(this.cmb_fac);
			this.panel1.Controls.Add(this.lbl_comp);
			this.panel1.Controls.Add(this.lbl_factory);
			this.panel1.Location = new System.Drawing.Point(0, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 40);
			this.panel1.TabIndex = 28;
			// 
			// cmb_parttyp
			// 
			this.cmb_parttyp.AddItemCols = 0;
			this.cmb_parttyp.AddItemSeparator = ';';
			this.cmb_parttyp.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_parttyp.Caption = "";
			this.cmb_parttyp.CaptionHeight = 17;
			this.cmb_parttyp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_parttyp.ColumnCaptionHeight = 17;
			this.cmb_parttyp.ColumnFooterHeight = 17;
			this.cmb_parttyp.ContentHeight = 17;
			this.cmb_parttyp.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_parttyp.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_parttyp.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_parttyp.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_parttyp.EditorHeight = 17;
			this.cmb_parttyp.GapHeight = 2;
			this.cmb_parttyp.ItemHeight = 15;
			this.cmb_parttyp.Location = new System.Drawing.Point(328, 8);
			this.cmb_parttyp.MatchEntryTimeout = ((long)(2000));
			this.cmb_parttyp.MaxDropDownItems = ((short)(5));
			this.cmb_parttyp.MaxLength = 32767;
			this.cmb_parttyp.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_parttyp.Name = "cmb_parttyp";
			this.cmb_parttyp.PartialRightColumn = false;
			this.cmb_parttyp.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_parttyp.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_parttyp.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_parttyp.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_parttyp.Size = new System.Drawing.Size(152, 23);
			this.cmb_parttyp.TabIndex = 3;
			// 
			// cmb_fac
			// 
			this.cmb_fac.AddItemCols = 0;
			this.cmb_fac.AddItemSeparator = ';';
			this.cmb_fac.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_fac.Caption = "";
			this.cmb_fac.CaptionHeight = 17;
			this.cmb_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_fac.ColumnCaptionHeight = 17;
			this.cmb_fac.ColumnFooterHeight = 17;
			this.cmb_fac.ContentHeight = 17;
			this.cmb_fac.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_fac.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_fac.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_fac.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_fac.EditorHeight = 17;
			this.cmb_fac.Enabled = false;
			this.cmb_fac.GapHeight = 2;
			this.cmb_fac.ItemHeight = 15;
			this.cmb_fac.Location = new System.Drawing.Point(96, 8);
			this.cmb_fac.MatchEntryTimeout = ((long)(2000));
			this.cmb_fac.MaxDropDownItems = ((short)(5));
			this.cmb_fac.MaxLength = 32767;
			this.cmb_fac.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_fac.Name = "cmb_fac";
			this.cmb_fac.PartialRightColumn = false;
			this.cmb_fac.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_fac.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_fac.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_fac.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_fac.Size = new System.Drawing.Size(104, 23);
			this.cmb_fac.TabIndex = 2;
			// 
			// lbl_comp
			// 
			this.lbl_comp.Location = new System.Drawing.Point(240, 11);
			this.lbl_comp.Name = "lbl_comp";
			this.lbl_comp.Size = new System.Drawing.Size(80, 16);
			this.lbl_comp.TabIndex = 1;
			this.lbl_comp.Text = "Part Type";
			// 
			// lbl_factory
			// 
			this.lbl_factory.Location = new System.Drawing.Point(32, 12);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(56, 16);
			this.lbl_factory.TabIndex = 0;
			this.lbl_factory.Text = "Factory";
			// 
			// fgrid_main
			// 
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.Color.Transparent;
			this.fgrid_main.ColumnInfo = "7,1,0,0,0,100,Columns:0{Width:23;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(0, 96);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.Size = new System.Drawing.Size(1016, 544);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{BackColor:Transparent;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 29;
			// 
			// Form_PB_Mold_Basic_Error
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.panel1);
			this.Name = "Form_PB_Mold_Basic_Error";
			this.Load += new System.EventHandler(this.Form_PB_Mold_Basic_Error_Load);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttyp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_fac)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PB_Mold_Basic_Error_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			FlexMold.ClassLib.ComVar.This_Win_ID = lbl_MainTitle.Text;
			FlexMold.ClassLib.ComVar.This_Computer = Environment.MachineName;
			if((ClassLib.ComVar.This_Dept.ToString() =="360200")||(ClassLib.ComVar.This_Dept.ToString() =="110200")||(FlexMold.ClassLib.ComVar.This_Dept.ToString() =="0000"))
				tbtn_Save.Enabled = true ;
			else
			{
				tbtn_Save.Enabled = false ;
			}
			tbtn_Print.Enabled = false;
			tbtn_Insert.Enabled = false;
//			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;		
			tbtn_Delete.Enabled = false;
		}
		private void Init_Form()
		{
			cmb_fac.Text = "VJ";
			this.lbl_MainTitle.Text = "Mold Basic Error";
			ClassLib.ComFunction.SetLangDic(this);

			DataTable dt_ret = Select_com_filter_code_List("MD03");  //Select_com_filter_code_List("MD03");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_parttyp, 0, 1, false, false);
		
			fgrid_main.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.ExtendLastCol = false;
// 
//			DataTable dt_ret = Select_com_filter_code_List("SDV15");
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cbo_wh, 0, 1, false, false);

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

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//fgrid_main.Rows.Add();
			insert_new_row();
		}

		private void insert_new_row()
		{
			fgrid_main.Rows.Add();
			fgrid_main[fgrid_main.Rows.Count - 1,0] = "I";
			fgrid_main[fgrid_main.Rows.Count - 1,1] = "";
			fgrid_main[fgrid_main.Rows.Count - 1,2] = "";
			fgrid_main[fgrid_main.Rows.Count - 1,3] = "";
			fgrid_main[fgrid_main.Rows.Count - 1,4] = "VN";
			fgrid_main[fgrid_main.Rows.Count - 1,5] = "";
			fgrid_main[fgrid_main.Rows.Count - 1,6] = "";
			fgrid_main[fgrid_main.Rows.Count - 1,7] = ClassLib.ComVar.This_User;
			fgrid_main[fgrid_main.Rows.Count - 1,8] = "";
             
		}
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Mold_Err_Info();
			FlexMold.ClassLib.ComVar.This_Action ="I" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);	
			Seach_err();
		}
		private void Save_Mold_Err_Info()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (SAVE_ERR(true))
				{
					//fgrid_main.Refresh_Division();
					MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		public bool SAVE_ERR(bool doExecute)
		{
			try
			{
				int vArrayLength = 0;

				OraDB.ReDim_Parameter(10);
				
				OraDB.Process_Name = "PKG_SDT_MOLD_WH.SAVE_MOLD_BASIC_ERR";
				
				int vTempIndex = 0;
								
				OraDB.Parameter_Name[vTempIndex] = "ARG_FACTORY" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_PART_CD" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;				

				OraDB.Parameter_Name[vTempIndex] = "ARG_ERR_GRP_CD" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;
				
				OraDB.Parameter_Name[vTempIndex] = "ARG_ERR_CD" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_ERR_NAME" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_UNIT" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_ERR_COST" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_REMARK" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_UPD_USER" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				OraDB.Parameter_Name[vTempIndex] = "ARG_UPD_YMD" ;
				OraDB.Parameter_Type[vTempIndex] = (int)OracleType.VarChar;
				vTempIndex++;

				ArrayList vValues = new ArrayList();
				
				for (int vRow =1; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (fgrid_main[vRow,0] == "I")
					{
						vValues.Add(cmb_fac.Text);
						vValues.Add(cmb_parttyp.SelectedValue.ToString()) ;  // def_ymd
						for (int vCol = 1 ; vCol < fgrid_main.Cols.Count-2 ; vCol++)
						{
							vValues.Add(fgrid_main[vRow, vCol]);
													
						}					
						vValues.Add(COM.ComVar.This_User);
						vValues.Add("");
					}
				}
				
				OraDB.Parameter_Values = (string[])vValues.ToArray(Type.GetType("System.String"));

				OraDB.Add_Modify_Parameter(true);
				
				if (doExecute)
				{
					if (OraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;
			}
			catch
			{
				return false;
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Seach_err();
			FlexMold.ClassLib.ComVar.This_Action ="S" ;
			FlexMold.ClassLib.ComVar.This_Packages = OraDB.Process_Name ;
			FlexMold.ClassLib.ComFunction.SAVE_SYS_PGM_MON(true);	
		}

		private void Seach_err()
		{
			DataTable vDt1 = null;
			fgrid_main.Clear();
			//fgrid_main.Set_Grid("SDT_MOLD_BASIC_ERR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			fgrid_main.Set_Grid("SDT_MOLD_BASIC_ERROR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_MOLD_ERR();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_main.AddItem(vDt1.Rows[i].ItemArray, fgrid_main.Rows.Count, 1);						
					}

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

		private System.Data.DataTable SELECT_MOLD_ERR()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD_WH.SEARCH_MOLD_BASIC_ERR";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PART_CD";			
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ"  ;
			OraDB.Parameter_Values[1] = cmb_parttyp.SelectedValue.ToString();
			OraDB.Parameter_Values[2] = "" ;

			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;

			return retDS.Tables[OraDB.Process_Name];
			
		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main[fgrid_main.RowSel,0] = "I" ;
		}
	}
}

