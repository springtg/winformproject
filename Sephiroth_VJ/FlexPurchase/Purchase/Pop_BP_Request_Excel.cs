using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Request_Excel : COM.PCHWinForm.Pop_Medium
	{
        private Form_BP_Request _parent = null;
		private COM.FSP fgrid_main;
        private Label btn_search;
        private Label btn_Insert;
		private System.ComponentModel.IContainer components = null;

		public Pop_BP_Request_Excel()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();
		}

        public Pop_BP_Request_Excel(Form_BP_Request arg_parent)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
            Init_Form();

            _parent = arg_parent;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Request_Excel));
            this.fgrid_main = new COM.FSP();
            this.btn_search = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_main.Location = new System.Drawing.Point(0, 80);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 18;
            this.fgrid_main.Size = new System.Drawing.Size(694, 388);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 27;
            this.fgrid_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_main_KeyDown);
            this.fgrid_main.DoubleClick += new System.EventHandler(this.fgrid_main_DoubleClick);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageIndex = 13;
            this.btn_search.ImageList = this.image_List;
            this.btn_search.Location = new System.Drawing.Point(530, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 24);
            this.btn_search.TabIndex = 366;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(611, 54);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 24);
            this.btn_Insert.TabIndex = 365;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // Pop_BP_Request_Excel
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.fgrid_main);
            this.Name = "Pop_BP_Request_Excel";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.fgrid_main, 0);
            this.Controls.SetChildIndex(this.btn_Insert, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 전역 변수 선언 및 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private object[][] _copyRange;

		#endregion

		#region 이벤트 핸들러

        #region 버튼 및 기타 이벤트

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCode();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                AppliedData();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 그리드 이벤트

        private void fgrid_main_DoubleClick(object sender, System.EventArgs e)
		{

		}

		private void fgrid_main_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if ((sender as COM.FSP).AllowEditing)
				{
					if (e.Control && e.KeyCode == Keys.V)
					{
						DataPaste(sender as COM.FSP);
					}
					else if (e.Control && e.KeyCode == Keys.C)
					{
						DataCopy(sender as COM.FSP);
					}
				}
			}
			catch (Exception ex) 
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		#endregion

		#endregion

		#region 이벤트 처리

		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			try
			{
				//Title
				this.Text = "Excel Uploader";
				this.lbl_MainTitle.Text = "Excel Uploader";
				ClassLib.ComFunction.Init_Form_Control(this);
				ClassLib.ComFunction.SetLangDic(this);

				Init_Grid();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Init_Grid()
		{
			fgrid_main.Set_Grid("SBP_REQUEST_EXCEL_UPLOAD", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_main.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			fgrid_main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;

			fgrid_main.Rows.Count = 500;
		}

		#endregion

		#region 툴바 이벤트

		private void ClearAll()
		{
			fgrid_main.ClearAll();
		}

		#endregion

		#region 버튼 및 기타 이벤트

		private void SearchCode()
		{
			for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
			{
				string sItemName = NullToBlank(fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_NAME]);
				string sSpecName = NullToBlank(fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_NAME]);
				string sColorName = NullToBlank(fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_NAME]);

				if (!sItemName.Equals("") && !sSpecName.Equals("") && !sColorName.Equals(""))
				{
					DataTable vDT = SELECT_SBC_ITEM_CD(sItemName, sSpecName, sColorName);

					// Item
					DataRow[] vDR = vDT.Select("GRP = '" + "ITEM" + "'");

                    if (vDR.Length > 0)
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_CD] = vDR[0]["ITEM_CD"];
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_NAME] = vDR[0]["ITEM_NAME"];
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxUNIT] = vDR[0]["UNIT"];
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxPK_QTY] = vDR[0]["PK_QTY"];
                    }
                    else
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_CD] = "";
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxUNIT] = "";
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxPK_QTY] = null;
                        fgrid_main.Rows[iRow].StyleNew.BackColor = Color.Red;
                    }

					// Spec
					vDR = vDT.Select("GRP = '" + "SPEC" + "'");

                    if (vDR.Length > 0)
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_CD] = vDR[0]["ITEM_CD"];
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_NAME] = vDR[0]["ITEM_NAME"];
                    }
                    else
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_CD] = "";
                        fgrid_main.Rows[iRow].StyleNew.BackColor = Color.Red;
                    }

					// Color
                    vDR = vDT.Select("GRP = '" + "COLOR" + "'");

                    if (vDR.Length > 0)
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_CD] = vDR[0]["ITEM_CD"];
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_NAME] = vDR[0]["ITEM_NAME"];
                    }
                    else
                    {
                        fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_CD] = "";
                        fgrid_main.Rows[iRow].StyleNew.BackColor = Color.Red;
                    }
				}
			}
		}

		private void AppliedData()
		{
            for (int iRow = fgrid_main.Rows.Fixed; iRow < fgrid_main.Rows.Count; iRow++)
            {
                if (IsDataValid(iRow))
                {
                    ClassLib.ComVar.Parameter_PopUp = new string[10];

                    ClassLib.ComVar.Parameter_PopUp[0] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_CD].ToString();
                    ClassLib.ComVar.Parameter_PopUp[1] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_NAME].ToString();
                    ClassLib.ComVar.Parameter_PopUp[2] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_CD].ToString();
                    ClassLib.ComVar.Parameter_PopUp[3] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_NAME].ToString();
                    ClassLib.ComVar.Parameter_PopUp[4] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_CD].ToString();
                    ClassLib.ComVar.Parameter_PopUp[5] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_NAME].ToString();
                    ClassLib.ComVar.Parameter_PopUp[6] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxUNIT].ToString();
                    ClassLib.ComVar.Parameter_PopUp[9] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxREQ_QTY].ToString();
                    ClassLib.ComVar.Parameter_PopUp[8] = fgrid_main[iRow, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxPK_QTY].ToString();

                    _parent.Show_Excel_Popup();
                }
            }
		}

        private bool IsDataValid(int arg_row)
        {
            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_CD]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxITEM_NAME]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_CD]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxSPEC_NAME]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_CD]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxCOLOR_NAME]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxUNIT]).Equals(""))
                return false;

            if (NullToBlank(fgrid_main[arg_row, (int)ClassLib.TBSBP_REQUEST_EXCEL_UPLOAD.IxPK_QTY]).Equals(""))
                return false;

            return true;
        }

		private string NullToBlank(object oData)
		{
			string sResult = "";

			if (oData != null)
			{
				sResult = oData.ToString();
			}

			return sResult;
		}

		#endregion

		#region 그리드 이벤트 

		private void DataCopy(COM.FSP arg_grid)
		{
			int rIdx = (arg_grid.Selection.r2 - arg_grid.Selection.r1) + 1;
			int cIdx = (arg_grid.Selection.c2 - arg_grid.Selection.c1) + 1;

			string copyData = "";
			_copyRange = new object[rIdx][];

			for (int idx = 0; idx < _copyRange.Length; idx++)
			{
				_copyRange[idx] = new object[cIdx];
			}

			for (int nRow = arg_grid.Selection.r1, oRow = 0; nRow <= arg_grid.Selection.r2; nRow++, oRow++)
			{
				for (int nCol = arg_grid.Selection.c1, oCol = 0; nCol <= arg_grid.Selection.c2; nCol++, oCol++)
				{
					_copyRange[oRow][oCol] = arg_grid[nRow, nCol];
					copyData += arg_grid[nRow, nCol] + (nCol == arg_grid.Selection.c2 ? "\n" : "\t");
				}
			}

			Clipboard.SetDataObject(copyData, true);
		}

		private void DataPaste(COM.FSP arg_grid)
		{
			object oClip = Clipboard.GetDataObject().GetData("System.String");

			string sClip = oClip == null ? "" : oClip.ToString();
			sClip = sClip.Replace("\r\n", "\n");
            
			string[] sRowClip = sClip.Split('\n');
			_copyRange = new object[sRowClip.Length - 1][];

			for (int idx = 0; idx < sRowClip.Length - 1; idx++)
			{
				_copyRange[idx] = sRowClip[idx].Split('\t');
			}

			if (_copyRange != null && _copyRange.Length > 0)
			{
				int row = arg_grid.Row, col = arg_grid.Col;
				int rowCount = _copyRange.Length;
				int colCount = _copyRange[0].Length;

				for (int nRow = row, oRow = 0; oRow < rowCount; nRow++, oRow++)
				{
					for (int nCol = col, oCol = 0; oCol < colCount; nCol++, oCol++)
					{
						if (nRow < arg_grid.Rows.Count && nCol < arg_grid.Cols.Count && arg_grid.Cols[nCol].AllowEditing)
						{
							arg_grid[nRow, nCol] = _copyRange[oRow][oCol];
						}
					}
				}
			}
		}

		#endregion

		#endregion

		#region 디비 연결

		#region 조회

		/// <summary>
		/// PKG_SBP_REQUEST_TAIL.SELECT_SBC_ITEM_CD : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_ITEM_CD(string arg_item_name, string arg_spec_name, string arg_color_name)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBP_REQUEST_TAIL.SELECT_SBC_ITEM_CD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[1] = "ARG_SPEC_NAME";
				MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_item_name;
				MyOraDB.Parameter_Values[1] = arg_spec_name;
				MyOraDB.Parameter_Values[2] = arg_color_name;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		#endregion

		#endregion

	}
}

