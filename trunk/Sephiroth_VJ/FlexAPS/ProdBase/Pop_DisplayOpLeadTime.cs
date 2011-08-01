using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdBase
{
	public class Pop_DisplayOpLeadTime : COM.APSWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리 

		public COM.FSP fgrid_OpLT;
		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.ImageList img_Action;
		private System.ComponentModel.IContainer components = null;

		public Pop_DisplayOpLeadTime()
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_DisplayOpLeadTime));
			this.fgrid_OpLT = new COM.FSP();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.btn_Refresh = new System.Windows.Forms.Label();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OpLT)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(528, 23);
			this.lbl_MainTitle.Text = "Production Operation Leadtime";
			// 
			// fgrid_OpLT
			// 
			this.fgrid_OpLT.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_OpLT.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_OpLT.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_OpLT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_OpLT.Location = new System.Drawing.Point(8, 40);
			this.fgrid_OpLT.Name = "fgrid_OpLT";
			this.fgrid_OpLT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.fgrid_OpLT.Size = new System.Drawing.Size(680, 392);
			this.fgrid_OpLT.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_OpLT.TabIndex = 243;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(616, 439);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 282;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(545, 439);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
			this.btn_Refresh.TabIndex = 283;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_DisplayOpLeadTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.fgrid_OpLT);
			this.Name = "Pop_DisplayOpLeadTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Production Operation Leadtime";
			this.Load += new System.EventHandler(this.Pop_DisplayOpLeadTime_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_OpLT, 0);
			this.Controls.SetChildIndex(this.btn_Refresh, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_OpLT)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의
  

		private COM.OraDB MyOraDB = new COM.OraDB();
 
		private string _ApplyYMD, _Factory, _LineCd, _LeadtimeCd;
  
		#endregion 

		#region 멤버 메서드
 
		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_ret;
				
			//Title
			this.Text = "Production Operation Leadtime";
			this.lbl_MainTitle.Text = "Production Operation Leadtime"; 

			ClassLib.ComFunction.SetLangDic(this); 

			fgrid_OpLT.Set_Grid("SPB_LINEOP_LEADTIME", "2", 2, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false); 
			fgrid_OpLT.Set_Action_Image(img_Action);
			fgrid_OpLT.ExtendLastCol = false;
			fgrid_OpLT.Font = new Font("Verdana", 7);
			fgrid_OpLT.SelectionMode = SelectionModeEnum.Default; 
			fgrid_OpLT.AllowSorting = AllowSortingEnum.None;
			fgrid_OpLT.AllowDragging = AllowDraggingEnum.None;
			fgrid_OpLT.Styles.Normal.Border.Color = Color.Empty;


			_ApplyYMD = ClassLib.ComVar.Parameter_PopUp[0];
			_Factory = ClassLib.ComVar.Parameter_PopUp[1];  
			_LineCd = ClassLib.ComVar.Parameter_PopUp[2];
			_LeadtimeCd = ClassLib.ComVar.Parameter_PopUp[3];
 
			//공정 리드타임 표시
			dt_ret = Select_LEADTIME_DIAGRAM();
			Display_LeadTime(dt_ret);

		}


		#region 공정 리드타임 표시

		/// <summary>
		/// Display_LeadTime : 공정 리드타임 표시 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_LeadTime(DataTable arg_dt)
		{
			try
			{ 
				// 키 값이 되는 반제/공정 표시
				Display_OpCd(arg_dt);
				// 리드타임 표시
				Display_LT(arg_dt); 
			}
			catch
			{
			}
		}



		/// <summary>
		/// Display_OpCd : 키 값이 되는 반제/공정 표시
		/// </summary>
		private void Display_OpCd(DataTable arg_dt)
		{
			try
			{ 
				int h_day = Convert.ToInt32(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxH_DAY].ToString() );
				int hour_count = 0, dday_count = 0; 

				fgrid_OpLT.Rows.Count = fgrid_OpLT.Rows.Fixed;  
				fgrid_OpLT.Cols.Count = (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGRLT_START
					+ Convert.ToInt32(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxMAX_LT_TIME].ToString() );  

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
					fgrid_OpLT.Rows.Add(); 

					fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGRCMP_CD]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxCMP_CD].ToString();

					fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGROP_CD]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_CD].ToString(); 

				} // end for i

				 
				for(int i = fgrid_OpLT.Cols.Count - 1; i >= (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGRLT_START; i--)
				{
					fgrid_OpLT.Cols[i].Width = 15;  
					
					// hour, d-day 표시 
					if(hour_count == 0)
					{
						fgrid_OpLT.Cols[i].StyleNew.Border.Direction = BorderDirEnum.Vertical;
						fgrid_OpLT.Cols[i].StyleNew.Border.Color = ClassLib.ComVar.ClrBorder;
						fgrid_OpLT.Cols[i].StyleNew.Border.Width = 1;

					}

					hour_count++;
					fgrid_OpLT[2, i] = hour_count; 

					if(dday_count == 0) 
						fgrid_OpLT[1, i] = "D-Day"; 
					else 
						fgrid_OpLT[1, i] = "D-" + dday_count; 


					if(hour_count == h_day) 
					{
						hour_count = 0;  
						dday_count++;  
					} 

				} // end for i 
 
				fgrid_OpLT.Rows[1].AllowMerging = true;

			}
			catch
			{

			}
		}




		/// <summary>
		/// Display_LT : 리드타임 표시
		/// </summary>
		private void Display_LT(DataTable arg_dt)
		{
			int start_col = 0;
			int lead_time = 0, process_time = 0, during_time = 0;
			string std_item = "", now_item = "";
			string cmp_cd = "", op_cd = "";


			try
			{ 
				fgrid_OpLT.AllowMerging = AllowMergingEnum.Free;


				// 제일 처음 기준 공정 리드타임 표시
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxLEAD_TIME].ToString() == "0")
					{
						start_col = fgrid_OpLT.Cols.Count - 1;

						lead_time = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxLEAD_TIME].ToString() );
						process_time = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxPROCESS_TIME].ToString() );
						during_time = process_time - 1;  

						start_col = start_col - lead_time;

						// description 표시
						cmp_cd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxCMP_CD].ToString();
						op_cd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_CD].ToString();
						for(int a = start_col - during_time; a <= start_col; a++)
						{
							//fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, a] = op_cd + " (" + cmp_cd + ")";
							fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, a] = op_cd;
						}

					 
						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_COLOR].ToString() != "")
						{
							fgrid_OpLT.GetCellRange(i + fgrid_OpLT.Rows.Fixed, start_col - during_time, i + fgrid_OpLT.Rows.Fixed,  start_col).StyleNew.BackColor
								= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_COLOR].ToString()) );
						}
						else
						{
							fgrid_OpLT.GetCellRange(i + fgrid_OpLT.Rows.Fixed, start_col - during_time, i + fgrid_OpLT.Rows.Fixed,  start_col).StyleNew.BackColor = Color.Empty;
						} 
				
						fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, 0] = Convert.ToString(start_col); 
					
						fgrid_OpLT.Rows[i + fgrid_OpLT.Rows.Fixed].AllowMerging = true;


						break;

					} 
					
				} // end for i



				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{ 
 
					//if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxLEAD_TIME].ToString() == "0") continue;

					std_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxSTD_CMP].ToString()
						+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxSTD_OPCD].ToString();

					for(int a = fgrid_OpLT.Rows.Fixed; a < fgrid_OpLT.Rows.Count; a++)
					{
						now_item = fgrid_OpLT[a, (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGRCMP_CD].ToString()
							+ fgrid_OpLT[a, (int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxGROP_CD].ToString();

						if(std_item == now_item)
						{
							start_col = Convert.ToInt32(fgrid_OpLT[a, 0].ToString() );
							break;
						} 

					} // end for a 
 
				
					

					lead_time = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxLEAD_TIME].ToString() );
					process_time = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxPROCESS_TIME].ToString() );
					during_time = process_time - 1;  

					start_col = start_col - lead_time;

					// description 표시
					cmp_cd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxCMP_CD].ToString();
					op_cd = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_CD].ToString();
					for(int a = start_col - during_time; a <= start_col; a++)
					{
						//fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, a] = op_cd + " (" + cmp_cd + ")";
						fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, a] = op_cd;
					}

					 
					if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_COLOR].ToString() != "")
					{
						fgrid_OpLT.GetCellRange(i + fgrid_OpLT.Rows.Fixed, start_col - during_time, i + fgrid_OpLT.Rows.Fixed,  start_col).StyleNew.BackColor
							= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPB_LEADTIME_DIAGRAM.IxOP_COLOR].ToString()) );
					}
					else
					{
						fgrid_OpLT.GetCellRange(i + fgrid_OpLT.Rows.Fixed, start_col - during_time, i + fgrid_OpLT.Rows.Fixed,  start_col).StyleNew.BackColor = Color.Empty;
					} 
				
					fgrid_OpLT[i + fgrid_OpLT.Rows.Fixed, 0] = Convert.ToString(start_col); 
					
					fgrid_OpLT.Rows[i + fgrid_OpLT.Rows.Fixed].AllowMerging = true;

				} // end for i


			}
			catch
			{ 
			}

		}


		#endregion

		#endregion

		#region 이벤트 처리 
 
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{ 
				dt_ret = Select_LEADTIME_DIAGRAM();
				Display_LeadTime(dt_ret);
			}
			catch
			{
			}
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		#endregion
 
		#region DB Connect

		  

		/// <summary>
		/// Select_LEADTIME_DIAGRAM :  공정도 그리기 위한 리스트 찾기 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_LEADTIME_DIAGRAM()
		{
			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPB_LINE.SELECT_LEADTIME_DIAGRAM";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_APPLY_YMD"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_LEADTIME_CD"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = _ApplyYMD; 
				MyOraDB.Parameter_Values[1] = _Factory; 
				MyOraDB.Parameter_Values[2] = _LineCd; 
				MyOraDB.Parameter_Values[3] = _LeadtimeCd;  
				MyOraDB.Parameter_Values[4] = "";  
 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}

		}



		#endregion 


		private void Pop_DisplayOpLeadTime_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}






	}
}

