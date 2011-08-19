using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;  

namespace ERP.ErpCom
{
	public class Pop_SetCols : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label btn_Save;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label lbl_TableNM;
		private System.Windows.Forms.TextBox txt_TableNM;
		private System.Windows.Forms.Label btn_Cancel;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetCols()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetCols));
			this.btn_Save = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
			this.btn_Search = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_TableNM = new System.Windows.Forms.TextBox();
			this.lbl_TableNM = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(541, 432);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 47;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 72);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(672, 352);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 48;
			// 
			// btn_Search
			// 
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(322, 46);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 34;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Search_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txt_TableNM
			// 
			this.txt_TableNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_TableNM.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_TableNM.Location = new System.Drawing.Point(111, 46);
			this.txt_TableNM.MaxLength = 20;
			this.txt_TableNM.Name = "txt_TableNM";
			this.txt_TableNM.Size = new System.Drawing.Size(210, 21);
			this.txt_TableNM.TabIndex = 59;
			this.txt_TableNM.Text = "";
			this.txt_TableNM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TableNM_KeyPress);
			// 
			// lbl_TableNM
			// 
			this.lbl_TableNM.ImageIndex = 0;
			this.lbl_TableNM.ImageList = this.img_Label;
			this.lbl_TableNM.Location = new System.Drawing.Point(10, 46);
			this.lbl_TableNM.Name = "lbl_TableNM";
			this.lbl_TableNM.Size = new System.Drawing.Size(100, 21);
			this.lbl_TableNM.TabIndex = 32;
			this.lbl_TableNM.Text = "테이블명";
			this.lbl_TableNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(612, 432);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 60;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// Pop_SetCols
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.fgrid_Main);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.lbl_TableNM);
			this.Controls.Add(this.txt_TableNM);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_SetCols";
			this.Text = "Set Default Columns Property";
			this.Load += new System.EventHandler(this.Pop_SetCols_Load);
			this.Controls.SetChildIndex(this.txt_TableNM, 0);
			this.Controls.SetChildIndex(this.lbl_TableNM, 0);
			this.Controls.SetChildIndex(this.btn_Search, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		private string _PgId, _PgSeq; 

		#endregion


		#region 멤버 메서드
     

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			//Title
			this.Text = "Set Default Columns Property";
			this.lbl_MainTitle.Text = "Table List";
			ClassLib.ComFunction.SetLangDic(this);


			DataTable dt_ret;

			

			_PgId = COM.ComVar.Parameter_PopUp[0];
			_PgSeq = COM.ComVar.Parameter_PopUp[1];

			// 그리드 설정
			fgrid_Main.Set_Grid_Comm("TABLE_MANAGER", "51", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);  
 
			txt_TableNM.Text = "SP";

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, fgrid_Main);

		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{ 
			this.Close();
		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

			} 

			arg_fgrid.AutoSizeCols();
		} 



		#endregion


		#region 이벤트 처리 
  

		
		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			txt_TableNM.Text = txt_TableNM.Text.ToUpper();

			dt_ret = Select_Data_List();
			Display_Grid(dt_ret, fgrid_Main);
		}

		private void btn_Search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 1;
		}

		private void btn_Search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Search.ImageIndex = 0;
		}



		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			Save_Col_Default();
			Close_Form();
		}

		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 1;
		}

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 0;
		} 

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			Close_Form();
		}

		private void btn_Cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 1;
		}

		private void btn_Cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 0;
		}


		private void txt_TableNM_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//13 : enter
			if(e.KeyChar == (char)13) 
			{
				btn_Search_Click(null, null);
			}
			 
		}



		#endregion
 

		#region DB Connect

  

		/// <summary>
		/// Select_Data_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private DataTable Select_Data_List()
		{
			DataSet ds_ret;
			string process_name = "PKG_SCM_TABLE.SELECT_TABLE_DESC_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_TABLE_TYPE";
			MyOraDB.Parameter_Name[1] = "ARG_TABLE_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = "TABLE"; 
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_TableNM, " ");
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
  

		}

 
		/// <summary>
		/// Save_Col_Default : Table Columns Default Insert
		/// </summary>
		private void Save_Col_Default()
		{
		 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_TABLE.INSERT_COL_DEFAULT";
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
			MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ";
			MyOraDB.Parameter_Name[2] = "ARG_TABLE_NAME"; 
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";  


			//03.DATA TYPE
			for (int i = 0; i <= 3; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}			

			
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = _PgId; 
			MyOraDB.Parameter_Values[1] = _PgSeq;
			MyOraDB.Parameter_Values[2] = fgrid_Main[fgrid_Main.Selection.r1, 1].ToString();
			MyOraDB.Parameter_Values[3] = COM.ComVar.This_User; 

			MyOraDB.Add_Modify_Parameter(true); 

			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
			//Error 처리
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}


		}


		#endregion



		private void Pop_SetCols_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

		




	}
}

