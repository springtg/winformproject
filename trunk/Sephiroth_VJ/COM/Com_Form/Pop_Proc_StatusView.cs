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
	public class Pop_Proc_StatusView : COM.APSWinForm.Pop_Large
	{
		private COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_desc;




		#region 변수
		private COM.OraDB oraDB = null;
		private string proc_name;
		private string proc_desc;
		private string[] names;
		private string[] values;
		private string[] statusvalue;
		private System.Windows.Forms.Label btn_Run;
		private int _RowFixed;
		private System.Windows.Forms.Label lbl_close;
		private bool error_check = false;
		private System.Windows.Forms.Label lbl_mps;
		private System.Windows.Forms.Label btn_mpsop;
		private string mps_control = "SP_SPO_ASSIGN_LOT";

		#endregion

		public Pop_Proc_StatusView()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}
		
		public Pop_Proc_StatusView(string arg_proc_name, string arg_proc_desc, string[] arg_names ,string[] arg_values, string[] arg_statusvalue)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			proc_name = arg_proc_name.ToUpper();
			proc_desc = arg_proc_desc;
			names     = arg_names;
			values    = arg_values;
			statusvalue = arg_statusvalue;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Proc_StatusView));
			this.fgrid_Main = new COM.FSP();
			this.txt_desc = new System.Windows.Forms.TextBox();
			this.btn_Run = new System.Windows.Forms.Label();
			this.lbl_close = new System.Windows.Forms.Label();
			this.lbl_mps = new System.Windows.Forms.Label();
			this.btn_mpsop = new System.Windows.Forms.Label();
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
			this.fgrid_Main.Location = new System.Drawing.Point(8, 40);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(576, 304);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 37;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// txt_desc
			// 
			this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_desc.Location = new System.Drawing.Point(8, 352);
			this.txt_desc.Multiline = true;
			this.txt_desc.Name = "txt_desc";
			this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_desc.Size = new System.Drawing.Size(576, 72);
			this.txt_desc.TabIndex = 38;
			this.txt_desc.Text = "";
			// 
			// btn_Run
			// 
			this.btn_Run.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Run.ImageIndex = 0;
			this.btn_Run.ImageList = this.img_Button;
			this.btn_Run.Location = new System.Drawing.Point(368, 432);
			this.btn_Run.Name = "btn_Run";
			this.btn_Run.Size = new System.Drawing.Size(72, 23);
			this.btn_Run.TabIndex = 102;
			this.btn_Run.Text = "Run Proc";
			this.btn_Run.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
			// 
			// lbl_close
			// 
			this.lbl_close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_close.ImageIndex = 0;
			this.lbl_close.ImageList = this.img_Button;
			this.lbl_close.Location = new System.Drawing.Point(8, 432);
			this.lbl_close.Name = "lbl_close";
			this.lbl_close.Size = new System.Drawing.Size(70, 23);
			this.lbl_close.TabIndex = 103;
			this.lbl_close.Text = "Close";
			this.lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
			// 
			// lbl_mps
			// 
			this.lbl_mps.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_mps.Enabled = false;
			this.lbl_mps.ImageIndex = 0;
			this.lbl_mps.ImageList = this.img_Button;
			this.lbl_mps.Location = new System.Drawing.Point(440, 432);
			this.lbl_mps.Name = "lbl_mps";
			this.lbl_mps.Size = new System.Drawing.Size(72, 23);
			this.lbl_mps.TabIndex = 104;
			this.lbl_mps.Text = "Open MPS";
			this.lbl_mps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_mps.Click += new System.EventHandler(this.lbl_mps_Click);
			// 
			// btn_mpsop
			// 
			this.btn_mpsop.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_mpsop.Enabled = false;
			this.btn_mpsop.ImageIndex = 0;
			this.btn_mpsop.ImageList = this.img_Button;
			this.btn_mpsop.Location = new System.Drawing.Point(512, 432);
			this.btn_mpsop.Name = "btn_mpsop";
			this.btn_mpsop.Size = new System.Drawing.Size(72, 23);
			this.btn_mpsop.TabIndex = 105;
			this.btn_mpsop.Text = "MPS By OP";
			this.btn_mpsop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_mpsop.Click += new System.EventHandler(this.btn_mpsop_Click);
			// 
			// Pop_Proc_StatusView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(594, 464);
			this.Controls.Add(this.btn_mpsop);
			this.Controls.Add(this.lbl_mps);
			this.Controls.Add(this.lbl_close);
			this.Controls.Add(this.btn_Run);
			this.Controls.Add(this.txt_desc);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_Proc_StatusView";
			this.Load += new System.EventHandler(this.Pop_Proc_StatusView_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.txt_desc, 0);
			this.Controls.SetChildIndex(this.btn_Run, 0);
			this.Controls.SetChildIndex(this.lbl_close, 0);
			this.Controls.SetChildIndex(this.lbl_mps, 0);
			this.Controls.SetChildIndex(this.btn_mpsop, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		#region 이벤트
		private void Pop_Proc_StatusView_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_Run_Click(object sender, System.EventArgs e)
		{

			string yyyy = DateTime.Now.Year.ToString();
			string MM = DateTime.Now.Month.ToString();
			if(MM.Length == 1)
			{
				MM = "0" + MM;
			}
			string dd = DateTime.Now.Day.ToString();
			if(dd.Length == 1)
			{
				dd = "0" + dd;
			}


			string date = yyyy + MM + dd;

			for(int i=_RowFixed; i<fgrid_Main.Rows.Count; i++)
			{

				this.Cursor  = Cursors.WaitCursor;

				if(bool.Parse(fgrid_Main[i,(int)COM.TBSPC_PROC_PROG.IxRUN].ToString()))
				{
					
					string div = "/";
					string[] proc_values = fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxPROC_VALUE].ToString().Split(div.ToCharArray());
					
					if(Run_Proc(proc_name, names, proc_values))
					{

						if(RPM_Error_Count(date))
						{
							//txt_desc.Text += statusvalue[i-_RowFixed] + " : Run Complete\r\n";
							View_Desc(statusvalue[i-_RowFixed] + " : Run Complete\r\n");
							fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxSTATUS] = "Complete";
							fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxRUN] = "false";
						}
						else
						{
							//txt_desc.Text += statusvalue[i-_RowFixed] + " : Run Incomplete\r\n";
							View_Desc(statusvalue[i-_RowFixed] + " : Run Incomplete\r\n");
							fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxSTATUS] = "Incomplete";

							this.Cursor  = Cursors.Default;



							string proc_name1 = "";
							if(proc_name == "SP_SPO_Assign_LOT0")
							{
								proc_name1 = "SP_SPO_ASSIGN_LOT";
							}
							else
							{
								proc_name1 = proc_name;
							}

							Com_Form.Form_Proc_Error proc_err = new Form_Proc_Error("RPM", true, date, proc_name1, ComVar.CxErrorCheck_Error);
							proc_err.ShowDialog();
							return;
						}

					}
					else
					{
						//txt_desc.Text += statusvalue[i-_RowFixed] + " : Procedure Error\r\n";
						View_Desc(statusvalue[i-_RowFixed] + " : Procedure Error\r\n");
						fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxSTATUS] = "Procedure Error";
						fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxRUN] = "false";
						error_check = true;
						break;
					}

					fgrid_Main.TopRow = i;
					System.Windows.Forms.Application.DoEvents();

				}
			}


			if(error_check)
			{
				View_Desc("Procedure have some error!!");
				this.Cursor  = Cursors.Default;
			}
			else
			{

				View_Desc("All Procedure run!!");
				this.Cursor  = Cursors.Default;

				
				if(proc_name == mps_control)
				{
					//ComVar.mps_check = true;
					lbl_mps.Enabled = true;
					btn_mpsop.Enabled = true;
					btn_Run.Enabled = false;
				}
				
				
				//this.Close();
			}
			
			
			if(!RPM_Warning_Count(date))
			{
				DialogResult dr = ComFunction.User_Message("Do want to show Warning Data ??", "Warning", MessageBoxButtons.YesNo);

				if(DialogResult.Yes == dr)
				{
					Com_Form.Form_Proc_Error proc_err = new Form_Proc_Error("RPM", true, date, proc_name, ComVar.CxErrorCheck_Warning);
					proc_err.ShowDialog();
					return;
				}
				
			}
		}


		private void Init_Form()
		{
			this.Text = "Procedure Progress Viewer";
			this.lbl_MainTitle.Text = "Procedure Status";


			oraDB = new COM.OraDB();

			// 그리드 설정
			fgrid_Main.Set_Grid_Comm("SPC_PROC_PROG", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Cols[(int)COM.TBSPC_PROC_PROG.IxDIVISION].Visible = false;

			fgrid_Main.Rows.Add();
			fgrid_Main[fgrid_Main.Rows.Count-1, (int)COM.TBSPC_PROC_PROG.IxRUN] = "true";
			fgrid_Main.Rows[fgrid_Main.Rows.Count-1].StyleNew.BackColor = ComVar.ClrDarkSel;
			_RowFixed = fgrid_Main.Rows.Count;



			Set_Grid();
			fgrid_Main.AutoSizeCols();
		}


		private void Set_Grid()
		{
			View_Desc(proc_desc);

			for(int i=0; i<values.Length; i++)
			{
				string div = "|";
				string[] string_div = statusvalue[i].Split(div.ToCharArray());


				string[] arraylist = new string[(int)COM.TBSPC_PROC_PROG.IxMaxCt];
				arraylist[0] = "";
				arraylist[1] = "true";
				arraylist[2] = proc_name;
				arraylist[3] = values[i];
				arraylist[4] = string_div[0];
				arraylist[5] = string_div[1];
				arraylist[6] = string_div[2];
				arraylist[7] = string_div[3];
				arraylist[8] = string_div[4];
				arraylist[9] = "Ready";

				fgrid_Main.AddItem(arraylist, fgrid_Main.Rows.Count, 0);
			}
		}


		private void View_Desc(string arg_desc)
		{
			txt_desc.AppendText(arg_desc + "\r\n");
			txt_desc.Focus();
			txt_desc.ScrollToCaret();
		}


		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			int select_row = fgrid_Main.Selection.r1;
			int select_col = fgrid_Main.Selection.c1;

			if(select_row == _RowFixed-1 && select_col == (int)COM.TBSPC_PROC_PROG.IxRUN)
			{
				string check = fgrid_Main[_RowFixed-1, (int)COM.TBSPC_PROC_PROG.IxRUN].ToString();

				for(int i=_RowFixed; i<fgrid_Main.Rows.Count; i++)
				{
					fgrid_Main[i, (int)COM.TBSPC_PROC_PROG.IxRUN] = check;
				}
			}
		}

		#endregion

		#region DB접속

		private bool Run_Proc(string arg_proc_name, string[] arg_names, string[] arg_values)
		{

			string Proc_Name = arg_proc_name;

			oraDB.ReDim_Parameter(arg_names.Length);
			oraDB.Process_Name = Proc_Name ;


			for(int i=0; i<arg_names.Length; i++)
			{
				oraDB.Parameter_Name[i] = arg_names[i];
			}

			for(int j=0; j<arg_names.Length; j++)
			{
				oraDB.Parameter_Type[j] = (int)OracleType.VarChar;
			}

			for(int k=0; k<arg_values.Length; k++)
			{
				oraDB.Parameter_Values[k] = arg_values[k];
			}

			oraDB.Add_Run_Parameter(true);
			DataSet ds = oraDB.Exe_Run_Procedure();

			if(ds == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}


		private bool Error_Count(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR_COUNT";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_SP_NAME";
			oraDB.Parameter_Name[4] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;

			oraDB.Parameter_Values[3] = proc_name.ToUpper();
			oraDB.Parameter_Values[4] = "E";
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			

			int count = int.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());


			if(count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}


		private bool RPM_Error_Count(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_RPM_ERR_COUNT";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_SP_NAME";
			oraDB.Parameter_Name[4] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;

			oraDB.Parameter_Values[3] = proc_name.ToUpper();
			oraDB.Parameter_Values[4] = "E";
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			

			int count = int.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());


			if(count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}


		private string Error_Count1(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR_COUNT1";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = "E";
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null)
			{
				return null ;
			}
			else
			{
			
				try
				{
					return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
				}
				catch
				{
					return null;
				}
			}
		}



		private string Warning_Count1(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR_COUNT2";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = "W";
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null)
			{
				return null ;
			}
			else
			{
			
				try
				{
					return DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString();
				}
				catch
				{
					return null;
				}
			}
		}


		private bool Warning_Count(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_PROC_ERR_COUNT";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_SP_NAME";
			oraDB.Parameter_Name[4] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = proc_name.ToUpper();
			oraDB.Parameter_Values[4] = "W";
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			

			int count = int.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());


			if(count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}



		private bool RPM_Warning_Count(string arg_date)
		{
			string Proc_Name = "PKG_SPS_LOG_HIST.SELECT_RPM_ERR_COUNT";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_UPD_USER";
			oraDB.Parameter_Name[2] = "ARG_ERR_YMD";
			oraDB.Parameter_Name[3] = "ARG_SP_NAME";
			oraDB.Parameter_Name[4] = "ARG_ERR_DIV";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = proc_name.ToUpper();
			oraDB.Parameter_Values[4] = "W";
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();
			

			int count = int.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());


			if(count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		#endregion

		private void lbl_close_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void lbl_mps_Click(object sender, System.EventArgs e)
		{
			ComVar.mps_check = true;
			this.Close();
		}

		private void btn_mpsop_Click(object sender, System.EventArgs e)
		{
			ComVar.mpsop_check = true;
			this.Close();
		}

	}
}

