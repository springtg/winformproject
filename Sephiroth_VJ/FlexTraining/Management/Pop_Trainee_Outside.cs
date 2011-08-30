using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;

namespace FlexTraining.Management
{
	public class Pop_Trainee_Outside : COM.TrainingWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.FSP fgrid_main;
		private COM.SSP sgrid_Image;		
		private string div;
		private System.Windows.Forms.Panel pnl_Menu;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.OpenFileDialog Open_dialog;
		private FarPoint.Win.Spread.SheetView sgrid_Image_Sheet1;
		private System.ComponentModel.IContainer components = null;

		public Pop_Trainee_Outside()
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

		

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		string _EmpName;
		string _EmpNo;
		
		private int _colPIC=4;
		private int _Rowfixed;
		private int _colFACTORY= 1;
		private int _colTRAINEE_ID=2;
		private int _colTRAINEE_NAME=3;
		private int _colEMP_No=1;
		private int _colMALE=5;
		private int _colCPOSITION=6;
		private int _colCOME_FROM=7;
		private int _colADDRESS=8;
		private int _colRESIDENT_NO=9;
		private int _colJOINTED_DATE=10;
		private int _colREMARK=11;
		private int _temp_row=0;
		private int _temp_col=0;
		#endregion
				
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Trainee_Outside));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel2 = new System.Windows.Forms.Panel();
			this.fgrid_main = new COM.FSP();
			this.pnl_Menu = new System.Windows.Forms.Panel();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.btn_Insert = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.Open_dialog = new System.Windows.Forms.OpenFileDialog();
			this.sgrid_Image_Sheet1 = new FarPoint.Win.Spread.SheetView();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sgrid_Image_Sheet1)).BeginInit();
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
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.pnl_Menu);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "86.3095238095238:False:False;9.32539682539683:False:True;4.36507936507936:False:T" +
				"rue;\t1:False:True;97.875:False:False;1.125:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(-4, 80);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(800, 504);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 33;
			this.c1Sizer1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.fgrid_main);
			this.panel2.Location = new System.Drawing.Point(8, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(783, 435);
			this.panel2.TabIndex = 46;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(783, 435);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 32;
			this.fgrid_main.Click += new System.EventHandler(this.fgrid_main_Click);
			this.fgrid_main.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_StartEdit);
			// 
			// pnl_Menu
			// 
			this.pnl_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Menu.Controls.Add(this.btn_Delete);
			this.pnl_Menu.Controls.Add(this.btn_Insert);
			this.pnl_Menu.Location = new System.Drawing.Point(8, 435);
			this.pnl_Menu.Name = "pnl_Menu";
			this.pnl_Menu.Size = new System.Drawing.Size(783, 47);
			this.pnl_Menu.TabIndex = 44;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Delete.ImageIndex = 5;
			this.btn_Delete.ImageList = this.image_List;
			this.btn_Delete.Location = new System.Drawing.Point(644, 8);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(80, 23);
			this.btn_Delete.TabIndex = 351;
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Insert
			// 
			this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Insert.ImageIndex = 9;
			this.btn_Insert.ImageList = this.image_List;
			this.btn_Insert.Location = new System.Drawing.Point(563, 8);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.Size = new System.Drawing.Size(80, 23);
			this.btn_Insert.TabIndex = 350;
			this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 435);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(800, 69);
			this.statusBar1.TabIndex = 43;
			// 
			// sgrid_Image_Sheet1
			// 
			this.sgrid_Image_Sheet1.SheetName = "Sheet1";
			// 
			// Pop_Trainee_Outside
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_Trainee_Outside";
			this.Load += new System.EventHandler(this.Pop_Trainee_Outside_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_Menu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sgrid_Image_Sheet1)).EndInit();
			this.ResumeLayout(false);

		}
		

		private void Pop_Trainee_Outside_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
		}
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Trainee Outside List";
			this.Text		   = "Trainee Outside";

			// grid set
			fgrid_main.Set_Grid("SIM_TRAINEE_OUTSIDE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;
			//			DataTable vDt;
			// factory set
			Tbtn_SearchProcess();
		}
		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_TRAINEE.SELECT_SIM_TRAINEE_OUTSIDE";

				DataTable vDt = SELECT_SIM_TRAINEE_OUTSIDE(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}
		
		public DataTable SELECT_SIM_TRAINEE_OUTSIDE(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(1);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
			}
		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Delete_Row(fgrid_main.Selection.r1);
		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{
			try
			{				
				int iRow = fgrid_main.Rows.Count;

				fgrid_main.Add_Row(iRow-1);
			
				fgrid_main[iRow, _colFACTORY] = COM.ComVar.This_Factory.ToString();
				fgrid_main[iRow, _colTRAINEE_ID] = "________";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}	
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}		
		}
		private bool Validate_Check()
		{
			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
			{
				if ((fgrid_main[iRow, _colTRAINEE_NAME].ToString().Replace(" ", "").Trim().Length == 0) )
				{
					fgrid_main[iRow, 0] = "";					
				}
			}			

			return true;
		}
		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SIM_TRAINEE_OUTSIDE(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
		public bool SAVE_SIM_TRAINEE_OUTSIDE(bool doExecute)
		{
			try
			{
				/*
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 13;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_TRAINEE.SAVE_SIM_TRAINEE_OUTSIDE";

				//02.ARGURMENT NAME

				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY"      ;
				MyOraDB.Parameter_Name[ 2] = "ARG_TRAINEE_ID"   ;
				MyOraDB.Parameter_Name[ 3] = "ARG_TRAINEE_NAME" ;
				MyOraDB.Parameter_Name[ 4] = "ARG_PIC"          ;
				MyOraDB.Parameter_Name[ 5] = "ARG_MALE"         ;
				MyOraDB.Parameter_Name[ 6] = "ARG_POSITION"     ;
				MyOraDB.Parameter_Name[ 7] = "ARG_COME_FROM"    ;
				MyOraDB.Parameter_Name[ 8] = "ARG_ADDRESS"      ;
				MyOraDB.Parameter_Name[ 9] = "ARG_RESIDENT_NO"  ;
				MyOraDB.Parameter_Name[ 10] = "ARG_JOINTED_DATE" ;
				MyOraDB.Parameter_Name[ 11] = "ARG_REMARK"       ;
				MyOraDB.Parameter_Name[ 12] = "ARG_UPDATE_USER"  ;

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;		
					MyOraDB.Parameter_Type[_colPIC] = (int)OracleType.Blob;		
					
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount*save_ct];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colFACTORY]);
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colTRAINEE_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colTRAINEE_NAME].ToString();							
						MyOraDB.Parameter_Values[para_ct+ 4] = " ";	
						MyOraDB.Parameter_Values[para_ct+ 5] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colMALE]);
						MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colCPOSITION]);
						MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colCOME_FROM]);
						MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colADDRESS]);
						MyOraDB.Parameter_Values[para_ct+ 9] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colRESIDENT_NO]);	
						MyOraDB.Parameter_Values[para_ct+ 10] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colJOINTED_DATE]).Substring(0,10);
						MyOraDB.Parameter_Values[para_ct+ 11] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colREMARK]);
						MyOraDB.Parameter_Values[para_ct+ 12] = COM.ComVar.This_User;	
						byte[] photo = null;
						photo = GetPhoto(fgrid_main[iRow, _colPIC].ToString());
						MyOraDB.Exe_Modify_Procedure_Blob(photo);						
						para_ct += iCount;	
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;
				*/

				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 12;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SIM_TRAINEE.SAVE_SIM_TRAINEE_OUTSIDE";

				//02.ARGURMENT NAME

				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY"      ;
				MyOraDB.Parameter_Name[ 2] = "ARG_TRAINEE_ID"   ;
				MyOraDB.Parameter_Name[ 3] = "ARG_TRAINEE_NAME" ;
				MyOraDB.Parameter_Name[ 4] = "ARG_MALE"         ;
				MyOraDB.Parameter_Name[ 5] = "ARG_POSITION"     ;
				MyOraDB.Parameter_Name[ 6] = "ARG_COME_FROM"    ;
				MyOraDB.Parameter_Name[ 7] = "ARG_ADDRESS"      ;
				MyOraDB.Parameter_Name[ 8] = "ARG_RESIDENT_NO"  ;
				MyOraDB.Parameter_Name[ 9] = "ARG_JOINTED_DATE" ;
				MyOraDB.Parameter_Name[ 10] = "ARG_REMARK"       ;
				MyOraDB.Parameter_Name[ 11] = "ARG_UPDATE_USER"  ;

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;		
					
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount*save_ct];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colFACTORY]);
						MyOraDB.Parameter_Values[para_ct+ 2] = fgrid_main[iRow, _colTRAINEE_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = fgrid_main[iRow, _colTRAINEE_NAME].ToString();	
						MyOraDB.Parameter_Values[para_ct+ 4] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colMALE]);
						MyOraDB.Parameter_Values[para_ct+ 5] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colCPOSITION]);
						MyOraDB.Parameter_Values[para_ct+ 6] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colCOME_FROM]);
						MyOraDB.Parameter_Values[para_ct+ 7] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colADDRESS]);
						MyOraDB.Parameter_Values[para_ct+ 8] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colRESIDENT_NO]);	
						MyOraDB.Parameter_Values[para_ct+ 9] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colJOINTED_DATE]).Substring(0,10);
						MyOraDB.Parameter_Values[para_ct+ 10] = ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, _colREMARK]);
						MyOraDB.Parameter_Values[para_ct+ 11] = COM.ComVar.This_User;
						para_ct += iCount;	
					}				
				}

				MyOraDB.Add_Modify_Parameter(true);		
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
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
	
		private byte[] GetPhoto(string arg_filename)
		{
			System.IO.FileStream fs = new System.IO.FileStream(arg_filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
			System.IO.BinaryReader br = new System.IO.BinaryReader(fs);

			byte[] photo = br.ReadBytes((int)fs.Length);   
			
			br.Close();
			fs.Close();

			return photo;

		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SearchProcess();
		}
		private void fgrid_main_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_main.Update_Row(fgrid_main.Selection.r1);
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.Delete_Row(fgrid_main.Selection.r1);
		}

		private void fgrid_main_Click(object sender, System.EventArgs e)
		{
			int    iRow   = fgrid_main.Selection.r1;
			int    iCol   = fgrid_main.Selection.c1;

			if ((iCol == _colPIC)&&(iRow >= _Rowfixed)&&(fgrid_main.Cols[iCol].ComboList == "...")&&(_temp_row==iRow)&&(_temp_col==iCol))
			{					
				fgrid_main[iRow,iCol]=Get_Add_File();
				fgrid_main.Cols[iCol].ComboList = "";				
			}
			else
			{
				if (iCol == _colPIC)
				{
					fgrid_main.Cols[iCol].Style.DataType = typeof(string);
					fgrid_main.Cols[iCol].ComboList = "...";

					_temp_row = iRow;
					_temp_col = iCol;
				}				
				
			}
		}

		private string Get_Add_File()
		{
			string File_Path;
			Open_dialog.ShowDialog();
			File_Path=Open_dialog.FileName.ToString();
			return File_Path;	
		}

	}
}

