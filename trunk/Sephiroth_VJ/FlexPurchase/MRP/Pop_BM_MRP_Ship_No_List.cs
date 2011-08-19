using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;


namespace FlexMRP.MRP
{
	public class Pop_BM_MRP_Ship_No_List : COM.PCHWinForm.Pop_Medium
	{
		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;

		public Pop_BM_MRP_Ship_No_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			Init_Form();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BM_MRP_Ship_No_List));
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
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
            this.lbl_MainTitle.Location = new System.Drawing.Point(34, 7);
            this.lbl_MainTitle.Size = new System.Drawing.Size(357, 22);
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
            // spd_main
            // 
            this.spd_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spd_main.Location = new System.Drawing.Point(8, 32);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(428, 256);
            this.spd_main.TabIndex = 27;
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BM_MRP_Ship_No_List
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(442, 295);
            this.Controls.Add(this.spd_main);
            this.Name = "Pop_BM_MRP_Ship_No_List";
            this.Closed += new System.EventHandler(this.Pop_BM_MRP_Ship_No_List_Closed);
            this.Controls.SetChildIndex(this.spd_main, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		public System.Windows.Forms.ImageList imageList1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion 

		#region 멤버 메서드

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			int vAreaCodeCol = (int)ClassLib.TBSBM_MRP_SHIP_NO_LIST.IxAREA_CD;
			if (spd_main.ActiveSheet.Rows[e.Row].ForeColor.ToArgb() == Color.Red.ToArgb() || 
				spd_main.ActiveSheet.Cells[e.Row, vAreaCodeCol].Text.Equals("40") || 
				spd_main.ActiveSheet.Cells[e.Row, vAreaCodeCol].Text.Equals("50"))
			{
				return;
			}

			COM.ComVar.Parameter_PopUp = new string[]{spd_main.ActiveSheet.Cells[e.Row, 1].Text};
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Init_Form()
		{
			try
			{
				this.Text = "MRP Ship No List";
				this.lbl_MainTitle.Text = "MRP Ship No List";

                ClassLib.ComFunction.SetLangDic(this);


				spd_main.Set_Spread_Comm("SBM_MRP_SHIP_NO_LIST", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);

				Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void Pop_BM_MRP_Ship_No_List_Closed(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		#endregion 

		#region 이벤트 처리

		private void Search()
		{
            DataTable vDt = SELECT_MRP_SHIP_NO_LIST();

			if (vDt.Rows.Count > 0)
			{
				spd_main.Display_Grid(vDt);
				Grid_SetColor();
			}
			else
			{
				spd_main.ClearAll();
			}
		}

		private void Grid_SetColor()
		{
			for (int i = 0 ; i < spd_main.ActiveSheet.RowCount ; i++)
			{
				if (!ClassLib.ComFunction.NullToBlank(spd_main.ActiveSheet.Cells[i, 5].Value).Equals(""))
				{
					spd_main.ActiveSheet.Rows[i].Locked = true;
					spd_main.ActiveSheet.Rows[i].ForeColor = Color.Red;
				}

				string vColorStr = ClassLib.ComFunction.NullToBlank(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBM_MRP_SHIP_NO_LIST.IxBACK_COLOR].Text);
				Color vBackColor;
				if (vColorStr.Equals(""))
					vBackColor = Color.White;
				else
					vBackColor = Color.FromArgb(Convert.ToInt32(vColorStr));
					
				spd_main.ActiveSheet.Cells[i, 1, i, spd_main.ActiveSheet.ColumnCount - 1].BackColor = vBackColor;
			}
		}

		#endregion
		
		#region DB Connect

		/// <summary>
		/// PKG_SBM_SHIPPING_MASTER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_SHIP_NO_LIST()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_CURRENT_ADJUST.SELECT_MRP_SHIP_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_PLAN_YMD_FROM";
			MyOraDB.Parameter_Name[6] = "ARG_PLAN_YMD_TO";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[4] = COM.ComVar.Parameter_PopUp[4].Replace("-", "");
			MyOraDB.Parameter_Values[5] = COM.ComVar.Parameter_PopUp[5];
			MyOraDB.Parameter_Values[6] = COM.ComVar.Parameter_PopUp[6];
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


	}
}

