using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Test : COM.VJ_CommonWinForm.Form_Top
	{
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private COM.FSP fsp1;
		private System.Windows.Forms.Label lbl_seq;
		private System.Windows.Forms.TextBox txt_Seq;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB oraDB = new COM.OraDB(); 
		public Form_Test()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			Init_Control();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Test));
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.fsp1 = new COM.FSP();
			this.lbl_seq = new System.Windows.Forms.Label();
			this.txt_Seq = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp1)).BeginInit();
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
			// tbtn_New
			// 
			this.tbtn_New.Text = "New";
			this.tbtn_New.ToolTipText = "New";
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
			this.lbl_MainTitle.Click += new System.EventHandler(this.lbl_MainTitle_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(104, 96);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=" +
				"\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><" +
				"ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar>" +
				"<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"St" +
				"yle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer" +
				"\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"" +
				"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><I" +
				"nactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"St" +
				"yle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSty" +
				"le parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win" +
				".C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style " +
				"parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pare" +
				"nt=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style paren" +
				"t=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style par" +
				"ent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"" +
				"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyle" +
				"s><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><" +
				"DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(179, 21);
			this.cmb_Factory.TabIndex = 51;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 96);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 52;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fsp1
			// 
			this.fsp1.BackColor = System.Drawing.SystemColors.Window;
			this.fsp1.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fsp1.Location = new System.Drawing.Point(0, 144);
			this.fsp1.Name = "fsp1";
			this.fsp1.Size = new System.Drawing.Size(1016, 256);
			this.fsp1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp1.TabIndex = 53;
			this.fsp1.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Growth_Plan_BeforeEdit);
			this.fsp1.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Growth_Plan_AfterEdit);
			// 
			// lbl_seq
			// 
			this.lbl_seq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_seq.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_seq.ImageIndex = 1;
			this.lbl_seq.ImageList = this.img_Label;
			this.lbl_seq.Location = new System.Drawing.Point(296, 96);
			this.lbl_seq.Name = "lbl_seq";
			this.lbl_seq.Size = new System.Drawing.Size(40, 21);
			this.lbl_seq.TabIndex = 54;
			this.lbl_seq.Text = "Seq";
			this.lbl_seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Seq
			// 
			this.txt_Seq.Location = new System.Drawing.Point(352, 96);
			this.txt_Seq.Name = "txt_Seq";
			this.txt_Seq.Size = new System.Drawing.Size(104, 22);
			this.txt_Seq.TabIndex = 55;
			this.txt_Seq.Text = "";
			// 
			// Form_Test
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.txt_Seq);
			this.Controls.Add(this.lbl_seq);
			this.Controls.Add(this.fsp1);
			this.Controls.Add(this.cmb_Factory);
			this.Controls.Add(this.lbl_Factory);
			this.Name = "Form_Test";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.cmb_Factory, 0);
			this.Controls.SetChildIndex(this.fsp1, 0);
			this.Controls.SetChildIndex(this.lbl_seq, 0);
			this.Controls.SetChildIndex(this.txt_Seq, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fsp1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		private void Init_Control()
		{
			fsp1.Set_Grid("TB_TEST","1",1,COM.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify,false);
			fsp1.Set_Action_Image(img_Action);
			
			DataTable dt_ret;

			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = " ";
		}
		private void Clear_FlexGrid()
		{
			if (fsp1.Rows.Fixed != fsp1.Rows.Count)
			{				
				fsp1.Clear(ClearFlags.UserData, fsp1.Rows.Fixed, 1, fsp1.Rows.Count - 1, fsp1.Cols.Count - 1);

				fsp1.Rows.Count = fsp1.Rows.Fixed;
					
			}
		}
		private void lbl_MainTitle_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fsp1.Rows.Add();
			fsp1[fsp1.Rows.Count-1,0]="I";
			fsp1[fsp1.Rows.Count-1,1]=cmb_Factory.SelectedValue;
		}
		private DataTable SearchData(string p_factory, string p_seq)
		{
			DataSet ds_ret;
			//para count
			oraDB.ReDim_Parameter(3); 
			//para store name
			oraDB.Process_Name = "pkg_svm_form_test.sp_sel_svm_form_test";
			//para name
			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "arg_seq";
			oraDB.Parameter_Name[2] = "out_cursor";
			//para type
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			//para values
			oraDB.Parameter_Values[0] = p_factory;
			oraDB.Parameter_Values[1] = p_seq; 
			oraDB.Parameter_Values[2] = ""; 
			//use para select
			oraDB.Add_Select_Parameter(true); 
			//exec prod
			ds_ret = oraDB.Exe_Select_Procedure();
			//return object data
			if(ds_ret == null) return null; 
			return ds_ret.Tables[oraDB.Process_Name]; 
		}
		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;
			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{								
				C1.Win.C1FlexGrid.Node newRow = fsp1.Rows.InsertNode(fsp1.Rows.Fixed + iRow, 1);

				fsp1[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					fsp1[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;		
				Clear_FlexGrid();
				DataTable l_DataTable = SearchData(cmb_Factory.SelectedValue.ToString(),txt_Seq.Text);					
				Display_FlexGrid(l_DataTable);
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
		private void fgrid_Growth_Plan_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_Tmp=(COM.FSP)sender;
			if ((l_Tmp.Rows.Fixed > 0) && (l_Tmp.Row >= l_Tmp.Rows.Fixed))
				l_Tmp.Buffer_CellData = (l_Tmp[l_Tmp.Row, l_Tmp.Col] == null) ? "" : l_Tmp[l_Tmp.Row, l_Tmp.Col].ToString();
		}

		
		private void fgrid_Growth_Plan_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP l_Tmp=(COM.FSP)sender;
			l_Tmp.Update_Row();
		}

		private bool Save_Data(bool doExecute)
		{
			try
			{				
				int para_ct = 0; 
				int iCount  = 11;
				oraDB.ReDim_Parameter(iCount);
				//01.PROCEDURE NAME
				oraDB.Process_Name = "pkg_svm_form_test.sp_upd_svm_form_test";
				//02.ARGURMENT OF PROC

				oraDB.Parameter_Name[0] = "arg_division";
				oraDB.Parameter_Name[1] = "arg_factory";
				oraDB.Parameter_Name[2] = "arg_seq";
				oraDB.Parameter_Name[3] = "arg_code";
				oraDB.Parameter_Name[4] = "arg_name";
				oraDB.Parameter_Name[5] = "arg_mid_sole";
				oraDB.Parameter_Name[6] = "arg_line_cd";
				oraDB.Parameter_Name[7] = "arg_qty";
				oraDB.Parameter_Name[8] = "arg_unit";
				oraDB.Parameter_Name[9] = "arg_style";
				oraDB.Parameter_Name[10] = "arg_user";
				//03. Type of Argurment
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.Number;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[7] = (int)OracleType.Number;
				oraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[10]= (int)OracleType.VarChar;

				//oraDB.Parameter_Values  = new string[iCount * (fsp1.Rows.Count - fsp1.Rows.Fixed)];
				ArrayList vModifyList	= new ArrayList();

				for (int iRow = fsp1.Rows.Fixed; iRow < fsp1.Rows.Count ; iRow++)
				{		
					string l_Tmp = ClassLib.ComFunction.NullCheck(fsp1[iRow, 0], "").ToString();
					
					if (l_Tmp.Equals("U"))
					{
						
							vModifyList.Add("U");
							vModifyList.Add(fsp1[iRow,1]);
							vModifyList.Add(fsp1[iRow,2]);
							vModifyList.Add(fsp1[iRow,3]);
							vModifyList.Add(fsp1[iRow,4]);
							vModifyList.Add(fsp1[iRow,5]);
							vModifyList.Add(fsp1[iRow,6]);
							vModifyList.Add(fsp1[iRow,7]);
							vModifyList.Add(fsp1[iRow,8]);
							vModifyList.Add(fsp1[iRow,9]);
							vModifyList.Add(COM.ComVar.This_User);

					}				
					if (l_Tmp.Equals("I"))
					{
					
							vModifyList.Add("I");
							vModifyList.Add(fsp1[iRow,1]);
							vModifyList.Add(Convert.ToString( fsp1[iRow,2]));
							vModifyList.Add(fsp1[iRow,3]);
							vModifyList.Add(fsp1[iRow,4]);
							vModifyList.Add(fsp1[iRow,5]);
							vModifyList.Add(fsp1[iRow,6]);
							vModifyList.Add(fsp1[iRow,7]);
							vModifyList.Add(fsp1[iRow,8]);
							vModifyList.Add(fsp1[iRow,9]);
							vModifyList.Add(COM.ComVar.This_User);

						
					}			
					if (l_Tmp.Equals("D"))
					{
						vModifyList.Add("D");
						vModifyList.Add(fsp1[iRow,1]);
						vModifyList.Add(fsp1[iRow,2]);
						vModifyList.Add(fsp1[iRow,3]);
						vModifyList.Add(fsp1[iRow,4]);
						vModifyList.Add(fsp1[iRow,5]);
						vModifyList.Add(fsp1[iRow,6]);
						vModifyList.Add(fsp1[iRow,7]);
						vModifyList.Add(fsp1[iRow,8]);
						vModifyList.Add(fsp1[iRow,9]);
						vModifyList.Add(COM.ComVar.This_User);
					}
					para_ct += iCount;	
				}

				oraDB.Parameter_Values = new string[vModifyList.Count];
				for (int j=0; j<vModifyList.Count;j++)
				{
					oraDB.Parameter_Values[j] = vModifyList[j].ToString();
				}
				oraDB.Add_Modify_Parameter(true);
				
				if (doExecute)
				{
					if (oraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}
				return true;

			}
			catch(System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				for (int i=0 ; i< fsp1.Selections.Length; i++)
				{
					fsp1.Delete_Row(fsp1.Selections[i]);
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"tbtn_Delete_Click", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(Save_Data(true))
				{
					tbtn_Search_Click(tbtn_Search, null);
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				}
			}
			catch (System.Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message,"tbtn_Save_Click", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
	}
}

