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
	public class Pop_Mold_List : COM.MoldWinForm.Pop_Large
	{
		private System.Windows.Forms.TextBox txt_moldcd;
		private System.Windows.Forms.Label lbl_moldcd;
		private System.Windows.Forms.TextBox txt_nikespeccd;
		private System.Windows.Forms.Label lbl_nikespeccd;
		public COM.FSP fgrid_main;
		private C1.Win.C1List.C1Combo cmb_parttype;
		private System.Windows.Forms.Label lbl_parttype;
		private System.Windows.Forms.Button btn_apply;
		private System.Windows.Forms.Button btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_moldlist;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1Command c1Command1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink2;
		private C1.Win.C1Command.C1Command c1Command2;
		private C1.Win.C1Command.C1ContextMenu cmenu_diagram;
		private COM.OraDB OraDB = new COM.OraDB();

		public Pop_Mold_List()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Mold_List));
			this.txt_moldcd = new System.Windows.Forms.TextBox();
			this.lbl_moldcd = new System.Windows.Forms.Label();
			this.txt_nikespeccd = new System.Windows.Forms.TextBox();
			this.lbl_nikespeccd = new System.Windows.Forms.Label();
			this.fgrid_main = new COM.FSP();
			this.cmb_parttype = new C1.Win.C1List.C1Combo();
			this.lbl_parttype = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_moldlist = new System.Windows.Forms.Button();
			this.cmenu_diagram = new C1.Win.C1Command.C1ContextMenu();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
			this.c1Command2 = new C1.Win.C1Command.C1Command();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
			// txt_moldcd
			// 
			this.txt_moldcd.Location = new System.Drawing.Point(528, 40);
			this.txt_moldcd.Name = "txt_moldcd";
			this.txt_moldcd.Size = new System.Drawing.Size(112, 21);
			this.txt_moldcd.TabIndex = 55;
			this.txt_moldcd.Text = "";
			// 
			// lbl_moldcd
			// 
			this.lbl_moldcd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_moldcd.Location = new System.Drawing.Point(456, 46);
			this.lbl_moldcd.Name = "lbl_moldcd";
			this.lbl_moldcd.Size = new System.Drawing.Size(96, 16);
			this.lbl_moldcd.TabIndex = 54;
			this.lbl_moldcd.Text = "Mold Code";
			// 
			// txt_nikespeccd
			// 
			this.txt_nikespeccd.Location = new System.Drawing.Point(344, 40);
			this.txt_nikespeccd.Name = "txt_nikespeccd";
			this.txt_nikespeccd.Size = new System.Drawing.Size(104, 21);
			this.txt_nikespeccd.TabIndex = 53;
			this.txt_nikespeccd.Text = "";
			// 
			// lbl_nikespeccd
			// 
			this.lbl_nikespeccd.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nikespeccd.Location = new System.Drawing.Point(240, 48);
			this.lbl_nikespeccd.Name = "lbl_nikespeccd";
			this.lbl_nikespeccd.Size = new System.Drawing.Size(112, 16);
			this.lbl_nikespeccd.TabIndex = 52;
			this.lbl_nikespeccd.Text = "Nike Spec Code";
			// 
			// fgrid_main
			// 
			this.fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:0{TextAlign:RightCenter;ImageAlign:CenterCenter;}\t1{TextAli" +
				"gn:RightCenter;ImageAlign:CenterCenter;}\t";
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 6.75F);
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 72);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_main.Size = new System.Drawing.Size(688, 368);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 56;
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
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
			this.cmb_parttype.Location = new System.Drawing.Point(88, 40);
			this.cmb_parttype.MatchEntryTimeout = ((long)(2000));
			this.cmb_parttype.MaxDropDownItems = ((short)(5));
			this.cmb_parttype.MaxLength = 32767;
			this.cmb_parttype.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_parttype.Name = "cmb_parttype";
			this.cmb_parttype.PartialRightColumn = false;
			this.cmb_parttype.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" +
				"ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}OddRow{}Re" +
				"cordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Border:Raise" +
				"d,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{}Style11{}" +
				"Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" +
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
			this.cmb_parttype.Size = new System.Drawing.Size(136, 23);
			this.cmb_parttype.TabIndex = 51;
			// 
			// lbl_parttype
			// 
			this.lbl_parttype.BackColor = System.Drawing.Color.Transparent;
			this.lbl_parttype.Location = new System.Drawing.Point(8, 48);
			this.lbl_parttype.Name = "lbl_parttype";
			this.lbl_parttype.Size = new System.Drawing.Size(96, 16);
			this.lbl_parttype.TabIndex = 50;
			this.lbl_parttype.Text = "Part Type";
			// 
			// btn_apply
			// 
			this.btn_apply.Location = new System.Drawing.Point(504, 442);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.TabIndex = 27;
			this.btn_apply.Text = "Apply";
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(600, 442);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 26;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_moldlist
			// 
			this.btn_moldlist.Image = ((System.Drawing.Image)(resources.GetObject("btn_moldlist.Image")));
			this.btn_moldlist.Location = new System.Drawing.Point(656, 32);
			this.btn_moldlist.Name = "btn_moldlist";
			this.btn_moldlist.Size = new System.Drawing.Size(32, 32);
			this.btn_moldlist.TabIndex = 57;
			this.btn_moldlist.Click += new System.EventHandler(this.btn_moldlist_Click);
			// 
			// cmenu_diagram
			// 
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink1);
			this.cmenu_diagram.CommandLinks.Add(this.c1CommandLink2);
			this.cmenu_diagram.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.cmenu_diagram.Name = "cmenu_diagram";
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.c1Command1;
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "Select";
			this.c1Command1.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command1_Click);
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.Command = this.c1Command2;
			this.c1CommandLink2.Text = "Unselect";
			// 
			// c1Command2
			// 
			this.c1Command2.Name = "c1Command2";
			this.c1Command2.Text = "Unselect";
			this.c1Command2.Click += new C1.Win.C1Command.ClickEventHandler(this.c1Command2_Click);
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.cmenu_diagram);
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
			this.c1CommandHolder1.Commands.Add(this.c1Command2);
			this.c1CommandHolder1.Owner = this;
			// 
			// Pop_Mold_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(698, 468);
			this.Controls.Add(this.btn_moldlist);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.txt_moldcd);
			this.Controls.Add(this.lbl_moldcd);
			this.Controls.Add(this.txt_nikespeccd);
			this.Controls.Add(this.lbl_nikespeccd);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.cmb_parttype);
			this.Controls.Add(this.lbl_parttype);
			this.Name = "Pop_Mold_List";
			this.Load += new System.EventHandler(this.Pop_Mold_List_Load);
			this.Controls.SetChildIndex(this.lbl_parttype, 0);
			this.Controls.SetChildIndex(this.cmb_parttype, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			this.Controls.SetChildIndex(this.lbl_nikespeccd, 0);
			this.Controls.SetChildIndex(this.txt_nikespeccd, 0);
			this.Controls.SetChildIndex(this.lbl_moldcd, 0);
			this.Controls.SetChildIndex(this.txt_moldcd, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.Controls.SetChildIndex(this.btn_cancel, 0);
			this.Controls.SetChildIndex(this.btn_moldlist, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_parttype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Mold_List_Load(object sender, System.EventArgs e)
		{
			//gdfg
			Init_Form();
		}
		private void Init_Form()
		{


			this.Text = "MMS_Mold Information";
			this.lbl_MainTitle.Text = "MMS_Mold Information";
			ClassLib.ComFunction.SetLangDic(this); 
			ClassLib.ComVar._mold_cd = "";
			//Type_Working(_Form_Type);

			DataTable dt_ret = Select_com_filter_code_List("MD03");  //Select_com_filter_code_List("MD03");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_parttype, 0, 1, false, false);
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

		private void btn_moldlist_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				mold_master_list();
				
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
			//fgrid_main.Set_Action_Image(img_Action);
			//_RowFixed_desc = fgrid_main.Rows.Fixed;
			fgrid_main.ExtendLastCol = false;
			//this.Cursor = Cursors.WaitCursor;
			fgrid_main.Rows.Count = 2;
			dt = Select_mold_master_list();

			if(dt.Rows.Count == 0) return false;

			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

            
			for (int i = 0; i < dt_rows; i++)
			{

				//string Mold_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_MOLD_CD.IxTOOL_CD].ToString();
				fgrid_main.AddItem(dt.Rows[i].ItemArray,fgrid_main.Rows.Count,1);
				//fgrid_main[i,0] = false;
				//show_info_text(2);

			}

			fgrid_main.Tree.Show(1);
			return true;
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			select_mold_list();
			//select_mold_master();

		}
		private void select_mold_list()
		{
			int cnt =0;
			int k =0;
			for (int i =0; i < fgrid_main.Rows.Count; i++)
			{
				if (fgrid_main[i,0] == "S")
				{
					cnt = cnt+1;
				}
			}
			ClassLib.ComVar._mold_code = new string[cnt];
			for (int i =0; i < cnt; i++)
			{
				if (fgrid_main[i+2,0] == "S")
				{
					ClassLib.ComVar._mold_code[k] = fgrid_main[i+2,1].ToString();
					k++;
				}
			}
		}
		private void select_mold_master()
		{
			//ok
		}
		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
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

		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
		
				ClassLib.ComVar._startmouse = fgrid_main.RowSel;   
					

			}
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
			
				ClassLib.ComVar._endmouse = fgrid_main.RowSel;

			}
			else if(e.Button == MouseButtons.Right)
			{
				cmenu_diagram.ShowContextMenu(fgrid_main, new Point(e.X, e.Y)); 

			}
		}

		private void c1Command1_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for (int i=ClassLib.ComVar._startmouse;i<= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i,0]="S";
			}
			fgrid_main.AutoSizeCols();
				//init_sizelist();
		}

		private void c1Command2_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			for (int i=ClassLib.ComVar._startmouse;i<= ClassLib.ComVar._endmouse; i++)
			{
				fgrid_main[i,0]="";
				//fgrid_size.ColSel=_startmouse;
								
			}
			fgrid_main.AutoSizeCols();
				//init_sizelist();
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{

			ClassLib.ComVar._mold_cd = fgrid_main[fgrid_main.RowSel,1].ToString();
			
			this.Close();
		}
	
	}
}

