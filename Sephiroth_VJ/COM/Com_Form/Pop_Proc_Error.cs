using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Text;

namespace COM.Com_Form
{
	public class Pop_Proc_Error : COM.APSWinForm.Pop_Large
	{
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.TextBox txt_err_mgs;
		private System.Windows.Forms.TextBox txt_mgs_user;
		private System.Windows.Forms.Label lbl_err_mgs;
		private System.Windows.Forms.Label lbl_title;
		private System.ComponentModel.IContainer components = null;

		#region 변수 지정

		private COM.OraDB oraDB = null;
		private int _RowFixed = 2;
		private string arg_divsion;
		private string arg_sp_name;
		private string arg_err_div;

		#endregion

		#region 기본 코드

		public Pop_Proc_Error(string division, string sp_name, string err_div)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			
			arg_divsion = division;
			arg_sp_name = sp_name;
			arg_err_div = err_div;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Proc_Error));
			this.fgrid_Main = new COM.FSP();
			this.txt_err_mgs = new System.Windows.Forms.TextBox();
			this.txt_mgs_user = new System.Windows.Forms.TextBox();
			this.lbl_err_mgs = new System.Windows.Forms.Label();
			this.lbl_title = new System.Windows.Forms.Label();
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
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(22, 40);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(650, 192);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 36;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// txt_err_mgs
			// 
			this.txt_err_mgs.BackColor = System.Drawing.Color.White;
			this.txt_err_mgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_err_mgs.ForeColor = System.Drawing.Color.Black;
			this.txt_err_mgs.Location = new System.Drawing.Point(22, 263);
			this.txt_err_mgs.Multiline = true;
			this.txt_err_mgs.Name = "txt_err_mgs";
			this.txt_err_mgs.ReadOnly = true;
			this.txt_err_mgs.Size = new System.Drawing.Size(650, 81);
			this.txt_err_mgs.TabIndex = 37;
			this.txt_err_mgs.Text = "";
			// 
			// txt_mgs_user
			// 
			this.txt_mgs_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mgs_user.Location = new System.Drawing.Point(22, 375);
			this.txt_mgs_user.Multiline = true;
			this.txt_mgs_user.Name = "txt_mgs_user";
			this.txt_mgs_user.Size = new System.Drawing.Size(650, 81);
			this.txt_mgs_user.TabIndex = 38;
			this.txt_mgs_user.Text = "";
			// 
			// lbl_err_mgs
			// 
			this.lbl_err_mgs.BackColor = System.Drawing.Color.Transparent;
			this.lbl_err_mgs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_err_mgs.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_err_mgs.Location = new System.Drawing.Point(22, 240);
			this.lbl_err_mgs.Name = "lbl_err_mgs";
			this.lbl_err_mgs.Size = new System.Drawing.Size(200, 23);
			this.lbl_err_mgs.TabIndex = 39;
			this.lbl_err_mgs.Text = "<< Data Base Error Message >>";
			this.lbl_err_mgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_title
			// 
			this.lbl_title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_title.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbl_title.Location = new System.Drawing.Point(22, 352);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(200, 23);
			this.lbl_title.TabIndex = 26;
			this.lbl_title.Text = "<< User Error Message >>";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_Proc_Error
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 472);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.lbl_err_mgs);
			this.Controls.Add(this.txt_mgs_user);
			this.Controls.Add(this.txt_err_mgs);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_Proc_Error";
			this.Text = "Procedure Error";
			this.Load += new System.EventHandler(this.Pop_Proc_Error_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.txt_err_mgs, 0);
			this.Controls.SetChildIndex(this.txt_mgs_user, 0);
			this.Controls.SetChildIndex(this.lbl_err_mgs, 0);
			this.Controls.SetChildIndex(this.lbl_title, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#endregion

		#region 이벤트

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Pop_Proc_Error_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}


		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			txt_err_mgs.Text = "";
			txt_mgs_user.Text = "";

			int sct_row = fgrid_Main.Selection.r1;

			if(sct_row < _RowFixed)
				return;

			txt_err_mgs.Text =  fgrid_Main[sct_row, (int)COM.TBSPM_ERR.IxTemp].ToString().Replace("\n", "\r\n");
			txt_mgs_user.Text = fgrid_Main[sct_row, (int)COM.TBSPM_ERR.IxTemp_User].ToString();

		}

		#endregion

		#region 메소드

		private void Init_Form()
		{
			this.lbl_MainTitle.Text = "Procedure Error List";


			oraDB = new COM.OraDB();

			// 그리드 설정
			fgrid_Main.Set_Grid_Comm("SPM_ERR", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Cols[(int)COM.TBSPM_ERR.IxDIVISION].Visible = false;
			Set_Grid();
			fgrid_Main.AutoSizeCols();
		}


		private void Set_Grid()
		{
			DataTable dt = Select_SPM_ERR();
			int RowCount = dt.Rows.Count;
			int ColCount = dt.Columns.Count;

			for(int i=0; i<RowCount; i++)
			{

				string[] ArrayItem = new string[13];
				ArrayItem[0]  = dt.Rows[i].ItemArray[0].ToString();
				ArrayItem[1]  = dt.Rows[i].ItemArray[1].ToString();
				ArrayItem[2]  = dt.Rows[i].ItemArray[2].ToString();

				string Job_cd = dt.Rows[i].ItemArray[3].ToString();
				string Div    = ":";
				string[] Split= Job_cd.Split(Div.ToCharArray());

				try
				{
					ArrayItem[3]  = Split[1];
				}
				catch
				{
					ArrayItem[3]  = "";
				}

				ArrayItem[4]  = dt.Rows[i].ItemArray[4].ToString();
				ArrayItem[5]  = dt.Rows[i].ItemArray[5].ToString();
				ArrayItem[6]  = dt.Rows[i].ItemArray[6].ToString();

				string Err_mgs= dt.Rows[i].ItemArray[7].ToString();
				if(Err_mgs.Length > 20)
				{
					Err_mgs = Err_mgs.Substring(0,18) + "..";
				}
				ArrayItem[7]  = Err_mgs;

				string Usr_mgs= dt.Rows[i].ItemArray[8].ToString();
				if(Usr_mgs.Length > 20)
				{
					Usr_mgs = Usr_mgs.Substring(0,20) + "..";
				}
				ArrayItem[8]  = Usr_mgs;

				ArrayItem[9]  = dt.Rows[i].ItemArray[9].ToString();
				ArrayItem[10] = dt.Rows[i].ItemArray[10].ToString();
				ArrayItem[11] = dt.Rows[i].ItemArray[7].ToString();
				ArrayItem[12] = dt.Rows[i].ItemArray[8].ToString();

 				fgrid_Main.AddItem(ArrayItem, fgrid_Main.Rows.Count, 1);
			}



			for(int i = _RowFixed; i<fgrid_Main.Rows.Count; i++)
			{
				if(fgrid_Main[i,(int)COM.TBSPM_ERR.IxERR_DIV].ToString() == "E : Error")
				{
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxERR_DIV).StyleNew.ForeColor = Color.Red;
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxERR_MSG).StyleNew.ForeColor = Color.Red;
					fgrid_Main.GetCellRange(i,(int)COM.TBSPM_ERR.IxUSR_MSG).StyleNew.ForeColor = Color.Red;
				}
			}
			
		}

		#endregion

		#region DB접속


		/// <summary>
		/// Select_Proc_Error_Check : 프로시져 ERROR를 첵크 합니다.
		/// </summary>
		/// <param name="arg_division">업무 구분</param>
		/// <param name="arg_err_div">에러 타입</param>
		/// <returns></returns>
		public DataTable Select_SPM_ERR()
		{

			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_SP_NAME";
			oraDB.Parameter_Name[3] = "ARG_UPD_USER";
			oraDB.Parameter_Name[4] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_divsion;
			oraDB.Parameter_Values[1] = COM.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = "SP_SPO_ASSIGN_LOT1";//;
			oraDB.Parameter_Values[3] = COM.ComVar.This_User;
			oraDB.Parameter_Values[4] = arg_err_div;
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_SPM_ERR_Detail(string arg_factory, string arg_upd_user, string arg_upd_ymd)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_SPM_ERR_DETAIL";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_UPD_YMD";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_upd_user;
			oraDB.Parameter_Values[2] = arg_upd_ymd;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		#endregion	
	}
}

