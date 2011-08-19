using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexMRP.MRP
{
	public class Pop_BM_Silhouette : COM.PCHWinForm.Pop_Medium
	{
		
		#region 사용자 정의 변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label btn_calculation;
		private System.Windows.Forms.Label lbl_cancel;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null;

		#endregion

		
		#region 생성자 / 소멸자

		public Pop_BM_Silhouette()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BM_Silhouette));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_calculation = new System.Windows.Forms.Label();
            this.lbl_cancel = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(660, 23);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_calculation);
            this.panel3.Controls.Add(this.lbl_cancel);
            this.panel3.Location = new System.Drawing.Point(8, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 29);
            this.panel3.TabIndex = 168;
            // 
            // btn_calculation
            // 
            this.btn_calculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_calculation.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_calculation.ImageIndex = 0;
            this.btn_calculation.ImageList = this.img_Button;
            this.btn_calculation.Location = new System.Drawing.Point(536, 3);
            this.btn_calculation.Name = "btn_calculation";
            this.btn_calculation.Size = new System.Drawing.Size(71, 23);
            this.btn_calculation.TabIndex = 353;
            this.btn_calculation.Text = "Apply";
            this.btn_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_calculation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseDown);
            this.btn_calculation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseUp);
            // 
            // lbl_cancel
            // 
            this.lbl_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_cancel.ImageIndex = 0;
            this.lbl_cancel.ImageList = this.img_Button;
            this.lbl_cancel.Location = new System.Drawing.Point(608, 3);
            this.lbl_cancel.Name = "lbl_cancel";
            this.lbl_cancel.Size = new System.Drawing.Size(71, 23);
            this.lbl_cancel.TabIndex = 353;
            this.lbl_cancel.Text = "Cancel";
            this.lbl_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cancel.Click += new System.EventHandler(this.lbl_cancel_Click);
            this.lbl_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseDown);
            this.lbl_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Basic_MouseUp);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 7);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(678, 380);
            this.pnl_main.TabIndex = 166;
            // 
            // spd_main
            // 
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(678, 380);
            this.spd_main.TabIndex = 0;
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BM_Silhouette
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BM_Silhouette";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		
		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// Form Setting
			lbl_MainTitle.Text = "Silhouette List";
			this.Text = "Silhouette List";


            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBM_SILHOUETTE", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Farpoint Spread Header Merge
			Mearge_GridHead();

			// 호출
			Btn_SearchClickProcess();


		}

		
		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		
		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_SBM_SILHOUETTE();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);


					for(int i = 0; i < spd_main.ActiveSheet.RowCount; i++)
					{

                        if (spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_SILHOUETTE.IxGAP].Text == "") continue;
						
						if(Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_SILHOUETTE.IxGAP].Text) >= 7 )
						{
							spd_main.ActiveSheet.Rows[i].ForeColor= ClassLib.ComVar.Clr_Text_Blue;
							
						} 

						if(Convert.ToInt32(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_SILHOUETTE.IxGAP].Text) >= 10 )
						{
							spd_main.ActiveSheet.Rows[i].ForeColor= ClassLib.ComVar.Clr_Text_Red; 
							
						} 

					}

					vDt.Dispose();
				}
				else
				{
					spd_main.ClearAll();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
 


		private void lbl_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btn_Basic_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_Basic_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		#endregion

		


		#region DB Connect

		/// <summary>
		/// SELECT_SBM_SILHOUETTE : forecast 대상 리스트 찾기
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable SELECT_SBM_SILHOUETTE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_EXPEND.SELECT_SBM_SILHOUETTE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE"; 
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_YMD"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComVar.Parameter_PopUp[0].ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComVar.Parameter_PopUp[1].ToString();
			MyOraDB.Parameter_Values[2] = ClassLib.ComVar.Parameter_PopUp[2].ToString();
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		
		#endregion


	}
}

