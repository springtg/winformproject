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
	public class Pop_Emp_List : COM.TrainingWinForm.Pop_Normal
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.FSP fgrid_main;
		private System.ComponentModel.IContainer components = null;

		public Pop_Emp_List()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		public Pop_Emp_List(string _Emp_No,string _Emp_Name)
		{
			// This call is required by the Windows Form Designer.
			
			_EmpNo=_Emp_No;		
            _EmpName=_Emp_Name;			
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		string _EmpName;
		string _EmpNo;
		private int _Rowfixed;
		
		private int _colEMP_No=1;
		#endregion


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Emp_List));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.GridDefinition = "98.0676328502416:False:False;\t98.8455988455988:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(4, 82);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(693, 414);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
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
			this.fgrid_main.Size = new System.Drawing.Size(693, 414);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 33;
			this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
			// 
			// Pop_Emp_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(698, 496);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_Emp_List";
			this.Load += new System.EventHandler(this.Pop_Emp_List_Load);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Emp_List_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Employee List";
			this.Text		   = "Training";


			// grid set
			fgrid_main.Set_Grid("SIM_TRAINEE_LIST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
		
			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;
			Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_MASTER.SELECT_EMP_LIST";

				DataTable vDt = SELECT_EMP_LIST(vProcedure);

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

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol < arg_dt.Columns.Count ; iCol++)
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

		public DataTable SELECT_EMP_LIST(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_EMP_NO";
			MyOraDB.Parameter_Name[ 1]  = "ARG_EMP_NAME";
			MyOraDB.Parameter_Name[ 2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]	= (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_String(_EmpNo  , "________");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_String(_EmpName , "");
			MyOraDB.Parameter_Values[ 2]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{
			btn_ApplyProcess();
		}

		private void btn_ApplyProcess()
		{
			int _PopupPara =1;
			COM.ComVar.Parameter_PopUp		= new string[_PopupPara];
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_String(fgrid_main[fgrid_main.RowSel, _colEMP_No].ToString(),"");	
			this.Dispose();			
		}
	}
}

