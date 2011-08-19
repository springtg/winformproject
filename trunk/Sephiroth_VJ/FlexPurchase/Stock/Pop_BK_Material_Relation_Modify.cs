using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using System.Threading;

namespace FlexPurchase.Stock
{
	public class Pop_BK_Material_Relation_Modify : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.MenuItem menuItem_MovingWH;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_CBD;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_In;
		private System.Windows.Forms.MenuItem menuItem_Out;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB	= new COM.OraDB();

		 
		private Hashtable _cellTypes = null; 
		private Hashtable _cellData  = null; 

		private bool _SaveClickFlag = false;

		#endregion

		#region 생성자 / 소멸자
		public Pop_BK_Material_Relation_Modify()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		private DataTable _DTRet;
		private string _TableHeadPgId;

 
		public Pop_BK_Material_Relation_Modify(DataTable arg_dt, string arg_tablehead_pgid)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_DTRet = arg_dt;
			_TableHeadPgId = arg_tablehead_pgid;



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_Material_Relation_Modify));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_MovingWH = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_CBD = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_In = new System.Windows.Forms.MenuItem();
            this.menuItem_Out = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 311);
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
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pic_head4);
            this.c1Sizer1.GridDefinition = "81.3765182186235:False:False;13.7651821862348:False:True;\t0.393700787401575:False" +
                ":False;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 247);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Apply);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Location = new System.Drawing.Point(12, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 34);
            this.panel2.TabIndex = 173;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.img_Button;
            this.btn_Delete.Location = new System.Drawing.Point(750, 8);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 358;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Delete.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(831, 8);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(80, 23);
            this.btn_Apply.TabIndex = 357;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(912, 8);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 356;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_grid;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(12, 4);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 201);
            this.spd_main.TabIndex = 172;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellClick);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ValueChange,
            this.menuItem_MovingWH,
            this.menuItem1,
            this.menuItem_CBD,
            this.menuItem2,
            this.menuItem_In,
            this.menuItem_Out});
            this.cmenu_grid.Popup += new System.EventHandler(this.cmenu_grid_Popup);
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 0;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_MovingWH
            // 
            this.menuItem_MovingWH.Index = 1;
            this.menuItem_MovingWH.Text = "Moving Warehouse";
            this.menuItem_MovingWH.Click += new System.EventHandler(this.menuItem_MovingWH_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuItem_CBD
            // 
            this.menuItem_CBD.Index = 3;
            this.menuItem_CBD.Text = "CBD Information";
            this.menuItem_CBD.Click += new System.EventHandler(this.menuItem_CBD_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // menuItem_In
            // 
            this.menuItem_In.Index = 5;
            this.menuItem_In.Text = "Incoming Infomation";
            this.menuItem_In.Click += new System.EventHandler(this.menuItem_InOut_Click);
            // 
            // menuItem_Out
            // 
            this.menuItem_Out.Index = 6;
            this.menuItem_Out.Text = "Outgoing Infomation";
            this.menuItem_Out.Click += new System.EventHandler(this.menuItem_InOut_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(12, 4);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(1000, 201);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // Pop_BK_Material_Relation_Modify
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 333);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BK_Material_Relation_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_BK_Material_Relation_Modify_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
	
		#region 그리드 이벤트 처리

		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			
//			if(e.Button != MouseButtons.Right) return;
//			 
//			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;
//
//			if (spd_main.ActiveSheet.OperationMode != OperationMode.ReadOnly && !spd_main.ActiveSheet.Columns[vCol].Locked)
//			{ 
//				ValueExchangeProcessing(vCol); 
//			}


		}

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}
 
		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{

			if(_TableHeadPgId == "SBK_STOCK_CLOSE")
			{

				int vRow = spd_main.ActiveSheet.ActiveRowIndex;
				int vCol = spd_main.ActiveSheet.ActiveColumnIndex; 

				// adjust 수량 수정 시 stock 수량 재 계산
				if(vCol != (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY) return;
				 
				Update_StockQty(vRow, vCol); 
			}


			

			 
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" || vTemp == "SSPComboBoxCellType"  )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.ActiveSheet.ColumnHeader.Cells[2,vCol].Text;  
				
					if (_cellTypes.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellTypes[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								spd_main.ActiveSheet.Cells[j, vCol].Value		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text

								if (COM.ComVar.Parameter_PopUp.Length > 1)
									spd_main.ActiveSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
								
								spd_main.Update_Row(j, img_Action);
							}
						}		  

					pop_changer.Dispose();
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		private void Update_StockQty(int arg_row, int arg_col)
		{

			// 수정 가능한 컬럼은 double 로 타입 수정됨. 따라서, double 를 다시 decimal 로 타입 변환 
			decimal adjust_qty = Convert.ToDecimal( spd_main.ActiveSheet.Cells[arg_row, arg_col].Value ) ;
				 
			decimal base_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxBAES_QTY].Value;
			decimal in_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxIN_QTY].Value;
			decimal out_qty = (decimal)spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUT_QTY].Value;
 
			spd_main.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value = base_qty + in_qty - out_qty + adjust_qty;


		}


		#endregion 
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Pop_BK_Material_Relation_Modify_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Return_Data();
		}

 
		#region 버튼 롤오버 이미지 처리

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}


		#endregion
 

		#endregion 

		#region 이벤트 처리 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{


            //Title
			this.Text = "Stock Modify";
            lbl_MainTitle.Text = "Stock Modify";
            ClassLib.ComFunction.SetLangDic(this); 

 
 
			// Grid Setting
			spd_main.Set_Spread_Comm(_TableHeadPgId, "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			// Farpoint Spread Header Merge
			Mearge_GridHead(); 


			c1ToolBar1.Visible = false;
 

			// grid set
			_cellTypes = new Hashtable();
			_cellData  = new Hashtable();

			for (int vCount = 1 ; vCount < spd_main.ActiveSheet.Columns.Count ; vCount++)
			{
				if (spd_main.ActiveSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)spd_main.ActiveSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataDisplay);
					_cellData.Add( vCount, sspBox.DataValue);
				}
			}



			Search_Data();



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


		private void Search_Data()
		{

			try
			{		
		
				this.Cursor = Cursors.WaitCursor; 
				 

				DataTable dt_ret = _DTRet;

				if(dt_ret.Rows.Count == 0) 
				{
					spd_main.ClearAll();  
					return;
				}


				spd_main.Display_Grid(dt_ret);

				if(_TableHeadPgId == "SBK_STOCK_DAILY")
				{

					ClassLib.ComFunction.MergeCell(spd_main, 
						new int[]{ (int)ClassLib.TBSBK_STOCK_DAILY.IxITEM_NAME, 
									 (int)ClassLib.TBSBK_STOCK_DAILY.IxSPEC_NAME, 
									 (int)ClassLib.TBSBK_STOCK_DAILY.IxCOLOR_NAME } );

				}
				else if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
				}
				else if(_TableHeadPgId == "SBK_STOCK_BASE")
				{
				}

 
 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		/// <summary>
		/// DataTable 로 구성해서 메인 화면에 그대로 적용
		/// </summary>
		private void Return_Data()
		{
 

			if(! _SaveClickFlag) return;



			if(ClassLib.ComVar.Parameter_PopUpTable == null)
			{
				ClassLib.ComVar.Parameter_PopUpTable = new DataTable(); 
			}

			ClassLib.ComVar.Parameter_PopUpTable.Reset();

			DataColumn[] dc= new DataColumn[spd_main.ActiveSheet.Columns.Count];

			for(int i = 0 ; i < spd_main.ActiveSheet.Columns.Count ; i++)
			{
				dc[i] = new DataColumn("",Type.GetType("System.String"));
			}
				
			ClassLib.ComVar.Parameter_PopUpTable.Columns.AddRange(dc);
 			
			DataRow newRow   =  ClassLib.ComVar.Parameter_PopUpTable.NewRow();  


			// cell type = number 이면 sum, 아니면 max 처리 

			newRow[0] = "";

			for(int i = 1 ; i < spd_main.ActiveSheet.Columns.Count ; i++)
			{
				newRow[i] = spd_main.ActiveSheet.Cells[0, i].Text; 


				if(spd_main.ActiveSheet.Columns[i].Locked) continue; 
				if(spd_main.ActiveSheet.Columns[i].CellType == null) continue; 



				if(spd_main.ActiveSheet.Columns[i].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell) )
				{
					string max_value = "";

					for(int j = 0; j < spd_main.ActiveSheet.RowCount; j++)
					{
						if(Convert.IsDBNull(spd_main.ActiveSheet.Cells[j, i].Value) )
						{
							spd_main.ActiveSheet.Cells[j, i].Value = "";
						}

						max_value = (max_value.CompareTo(spd_main.ActiveSheet.Cells[j, i].Value.ToString() ) > 0) 
							? max_value :  spd_main.ActiveSheet.Cells[j, i].Value.ToString() ;
					} // end for j

					newRow[i] = max_value;

				}
				else if(spd_main.ActiveSheet.Columns[i].CellType.ToString().Equals("NumberCellType" ) )
				{  


					bool price_col_flag = false;

					if(_TableHeadPgId == "SBK_STOCK_DAILY")
					{

						if(i == (int)ClassLib.TBSBK_STOCK_DAILY.IxPUR_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_DAILY.IxOUTSIDE_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_DAILY.IxCBD_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_DAILY.IxSHIP_PRICE )
						{
							price_col_flag = true;
						}
						 

					}
					else if(_TableHeadPgId == "SBK_STOCK_CLOSE")
					{

						if(i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxOUTSIDE_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxCBD_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_CLOSE.IxSHIP_PRICE )
						{
							price_col_flag = true;
						} 

					}
					else if(_TableHeadPgId == "SBK_STOCK_BASE")
					{

						if(i == (int)ClassLib.TBSBK_STOCK_BASE.IxPUR_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_BASE.IxOUTSIDE_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_BASE.IxCBD_PRICE
							|| i == (int)ClassLib.TBSBK_STOCK_BASE.IxSHIP_PRICE )
						{
							price_col_flag = true;
						}


					}

					
					
					if(price_col_flag)
					{

						string max_value = "";

						for(int j = 0; j < spd_main.ActiveSheet.RowCount; j++)
						{
							if(Convert.IsDBNull(spd_main.ActiveSheet.Cells[j, i].Value) )
							{
								spd_main.ActiveSheet.Cells[j, i].Value = "";
							}

							max_value = (max_value.CompareTo(spd_main.ActiveSheet.Cells[j, i].Value.ToString() ) > 0) 
								? max_value :  spd_main.ActiveSheet.Cells[j, i].Value.ToString() ;
						} // end for j

						newRow[i] = max_value;


					}
					else
					{
					
						decimal sum_qty = 0; 

						for(int j = 0; j < spd_main.ActiveSheet.RowCount; j++)
						{
							// 수정 가능한 컬럼은 double 로 타입 수정됨. 따라서, double 를 다시 decimal 로 타입 변환
							if (! spd_main.ActiveSheet.Columns[i].Locked)
							{
								if(Convert.IsDBNull(spd_main.ActiveSheet.Cells[j, i].Value)
									|| spd_main.ActiveSheet.Cells[j, i].Value.ToString() == "" ) 
								{
									spd_main.ActiveSheet.Cells[j, i].Value = 0;
								}

								sum_qty += Convert.ToDecimal(spd_main.ActiveSheet.Cells[j, i].Value);
							}
							else
							{
								sum_qty += (decimal)spd_main.ActiveSheet.Cells[j, i].Value;
							} 

						} // end for j

						newRow[i] = sum_qty.ToString();

					} // end if(price_col_flag)

				}


			}


			ClassLib.ComVar.Parameter_PopUpTable.Rows.Add(newRow); 
	 

		}


		   
		#endregion  

		#region 툴바 관련

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_NewProcess();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SaveProcess();
		} 

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_DeleteProcess();
		}

	  

		private void Tbtn_NewProcess()
		{
			try
			{
				spd_main.ClearAll(); 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		private void Tbtn_SearchProcess()
		{
			Search_Data();
		}		

 
		

		private void Tbtn_SaveProcess()
		{
			try
			{			
	
				this.Cursor = Cursors.WaitCursor;
 
				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if (result == DialogResult.No) return;
 

				string process_name = "";

				if(_TableHeadPgId == "SBK_STOCK_DAILY")
				{
					process_name = "PKG_SBK_STOCK_DAILY.SAVE_SBK_STOCK";
				}
				else if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
					process_name = "PKG_SBK_STOCK_CLOSE.SAVE_SBK_STOCK_CLOSE";
				}
				else if(_TableHeadPgId == "SBK_STOCK_BASE")
				{
					process_name = "PKG_SBK_STOCK_BASE.SAVE_SBK_STOCK_BASE";
				}


				bool save_flag = MyOraDB.Save_Spread(process_name, spd_main);
			    if(! save_flag) return;
	
			  
				spd_main.Refresh_Division();

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				
				_SaveClickFlag = true;
				this.Close();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void Tbtn_DeleteProcess()
		{
			spd_main.Delete_Row(img_Action);
		}




		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			Tbtn_DeleteProcess();
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			Tbtn_SaveProcess();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_SaveClickFlag = false;
			this.Close();
		}

		



		#endregion

		#region 팝업 메뉴 이벤트


		private void cmenu_grid_Popup(object sender, System.EventArgs e)
		{
			
			if(_TableHeadPgId == "SBK_STOCK_DAILY")
			{ 
				menuItem_ValueChange.Enabled = true;
				menuItem_MovingWH.Enabled = false;
				menuItem_CBD.Enabled = false;
				menuItem_In.Enabled = false;
				menuItem_Out.Enabled = false; 

			}
			else if(_TableHeadPgId == "SBK_STOCK_CLOSE")
			{
				menuItem_ValueChange.Enabled = true;
				menuItem_MovingWH.Enabled = true;
				menuItem_CBD.Enabled = true;
				menuItem_In.Enabled = true;
				menuItem_Out.Enabled = true;
			}
			else if(_TableHeadPgId == "SBK_STOCK_BASE")
			{
				menuItem_ValueChange.Enabled = true;
				menuItem_MovingWH.Enabled = true;
				menuItem_CBD.Enabled = true;
				menuItem_In.Enabled = false;
				menuItem_Out.Enabled = false;
			}

		}

		
		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
		
			if(spd_main.ActiveSheet.RowCount == 0) return;

			int vRow = spd_main.ActiveSheet.ActiveRowIndex;
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex;

			if (spd_main.ActiveSheet.OperationMode != OperationMode.ReadOnly && !spd_main.ActiveSheet.Columns[vCol].Locked)
			{
				ValueExchangeProcessing(vCol);


				if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
					// adjust 수량 수정 시 stock 수량 재 계산
					if(vCol != (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY) return;
				 
					Update_StockQty(vRow, vCol); 
				}
 

			}

		}

		
		private void menuItem_MovingWH_Click(object sender, System.EventArgs e)
		{

		
			try
			{ 

				if(spd_main.ActiveSheet.RowCount == 0) return;


				int vRow = spd_main.ActiveSheet.ActiveRowIndex; 

			 
				string factory = "";
				string warehouse_old = "";
				string base_qty_old = "";

				

				if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
					factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value.ToString();
					warehouse_old = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_CD].Value.ToString();
					base_qty_old = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_QTY].Value.ToString();

				}
				else if(_TableHeadPgId == "SBK_STOCK_BASE")
				{
					factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxFACTORY].Value.ToString();
					warehouse_old = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxWH_CD].Value.ToString();
					base_qty_old = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxBAES_QTY].Value.ToString();

				}


				// PopUp -- Incoming WareHouse Select
				COM.ComVar.Parameter_PopUp = new string[3];
				COM.ComVar.Parameter_PopUp[0] = factory;
				COM.ComVar.Parameter_PopUp[1] = warehouse_old;
				COM.ComVar.Parameter_PopUp[2] = base_qty_old;
				

				Pop_BK_Moving_WareHouse pop_changer = new Pop_BK_Moving_WareHouse();
				pop_changer.ShowDialog(); 


				if (COM.ComVar.Parameter_PopUp == null) return;
  

				string wh_cd = COM.ComVar.Parameter_PopUp[0];
				string moving_qty = COM.ComVar.Parameter_PopUp[1];  

 
				string warehouse_new = "";
				string stock_ym = "";
				string item_cd = "";
				string spec_cd = "";
				string color_cd = "";
				string base_qty_new = "";
  
 
				

				if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
					stock_ym = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value.ToString();
					item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
					spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
					color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString();
				}
				else if(_TableHeadPgId == "SBK_STOCK_BASE")
				{  
					stock_ym = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxSTOCK_YMD].Value.ToString();
					item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxITEM_CD].Value.ToString();
					spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxSPEC_CD].Value.ToString();
					color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxCOLOR_CD].Value.ToString(); 

				}

				warehouse_new = wh_cd;
				base_qty_new = moving_qty; 


				string[] parameter = new string[] { factory,
													  warehouse_old,
													  warehouse_new,
													  stock_ym,
													  item_cd,
													  spec_cd,
													  color_cd,
													  base_qty_new };

				bool save_flag = FlexPurchase.Stock.Form_BK_Stock_Base.Update_SBK_STOCK_BASE_WH(parameter);

    
				if(! save_flag)
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;

				}
				else
				{ 

					// 기존 데이터 수량 변경  

					decimal adjust_qty_new = decimal.Parse(moving_qty); // Moving Qty		
	
					decimal adjust_qty_old = 0;

					if(_TableHeadPgId == "SBK_STOCK_CLOSE")
					{
						adjust_qty_old = decimal.Parse(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value.ToString() ); 

					}
					else if(_TableHeadPgId == "SBK_STOCK_BASE")
					{
						adjust_qty_old  = decimal.Parse(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxBAES_QTY].Value.ToString() ); 
					} 

					 
					decimal remain_qty = adjust_qty_old - adjust_qty_new; 

//					if(remain_qty == 0)
//					{
//						spd_main.ActiveSheet.RemoveRows(vRow,1); 
//					}
//					else
//					{

						if(_TableHeadPgId == "SBK_STOCK_CLOSE")
						{
							spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY].Value = remain_qty; 
							Update_StockQty(vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxADJUST_QTY);  
						}
						else if(_TableHeadPgId == "SBK_STOCK_BASE")
						{
							spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_BASE.IxBAES_QTY].Value = remain_qty; 
						} 

						
//					}


					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);


				} 


				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_MovingWH_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		} 



		private void menuItem_CBD_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				/*****************************************
				0 : FACTORY,	  		1 : PUR_USER,
				2 : CUST_CD,			3 : CUST_NAME,
				4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
				6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
				8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
				10 : CBD_CURRENCY,		11 : SHIP_PRICE,
				12 : SHIP_CURRENCY, 	13 : CBM,
				14 : WEIGHT
				*****************************************/

				if(spd_main.ActiveSheet.RowCount == 0) return;

				int[] keys = null;
				int[] values = null;


				if(_TableHeadPgId == "SBK_STOCK_CLOSE")
				{
					keys = new int[]{ (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY,
											  -1,
											  (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD,
											  (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD,
											  (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD };

					values = new int[]{ 
												-1,												
												-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_USER,
												-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxCUST_CD,	
												-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxVENDOR,
												-1, //(int)ClassLib.TBSBK_STOCK_CLOSE.IxPK_UNIT_QTY,
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_PRICE,	
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxPUR_CURRENCY,
												-1,												
												-1,
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxCBD_PRICE,
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxCBD_CURRENCY,
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxSHIP_PRICE,	
												(int)ClassLib.TBSBK_STOCK_CLOSE.IxSHIP_CURRENCY,
												-1,												
												-1
											};

				}
				else if(_TableHeadPgId == "SBK_STOCK_BASE")
				{
					keys = new int[]{ (int)ClassLib.TBSBK_STOCK_BASE.IxFACTORY,
											  -1,
											  (int)ClassLib.TBSBK_STOCK_BASE.IxITEM_CD,
											  (int)ClassLib.TBSBK_STOCK_BASE.IxSPEC_CD,
											  (int)ClassLib.TBSBK_STOCK_BASE.IxCOLOR_CD };

					values = new int[]{ 
												-1,												
												-1, //(int)ClassLib.TBSBK_STOCK_BASE.IxPUR_USER,
												-1, //(int)ClassLib.TBSBK_STOCK_BASE.IxCUST_CD,	
												-1, //(int)ClassLib.TBSBK_STOCK_BASE.IxVENDOR,
												-1, //(int)ClassLib.TBSBK_STOCK_BASE.IxPK_UNIT_QTY,
												(int)ClassLib.TBSBK_STOCK_BASE.IxPUR_PRICE,	
												(int)ClassLib.TBSBK_STOCK_BASE.IxPUR_CURRENCY,
												-1,												
												-1,
												(int)ClassLib.TBSBK_STOCK_BASE.IxCBD_PRICE,
												(int)ClassLib.TBSBK_STOCK_BASE.IxCBD_CURRENCY,
												(int)ClassLib.TBSBK_STOCK_BASE.IxSHIP_PRICE,	
												(int)ClassLib.TBSBK_STOCK_BASE.IxSHIP_CURRENCY,
												-1,												
												-1
											};
				} 


				

				FlexPurchase.Shipping.Pop_BC_CBD_Information vPop = new FlexPurchase.Shipping.Pop_BC_CBD_Information(spd_main, keys, values);
				vPop._style = "";
				vPop.ShowDialog(this);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_CBD_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

     	}


		private void menuItem_InOut_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				
				if(_TableHeadPgId != "SBK_STOCK_CLOSE") return;

 
				if(spd_main.ActiveSheet.RowCount == 0) return;


				MenuItem src = sender as MenuItem;
				string division = "";
				if(src.Equals(menuItem_In) )
				{
					division = "I";
				}
				else if(src.Equals(menuItem_Out) )
				{
					division = "O";
				}
 
				 
				int vRow = spd_main.ActiveSheet.ActiveRowIndex;

				string factory = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxFACTORY].Value.ToString();
				string stock_ym = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSTOCK_YMD].Value.ToString();
				string warehouse = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxWH_CD].Value.ToString(); 
				
				string item_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_CD].Value.ToString();
				string spec_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_CD].Value.ToString();
				string color_cd = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_CD].Value.ToString(); 
				string item_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxITEM_NAME].Value.ToString();
				string spec_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxSPEC_NAME].Value.ToString();
				string color_name = spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBK_STOCK_CLOSE.IxCOLOR_NAME].Value.ToString(); 
 

				string[] pop_parameter = new string[] { division, 
														  factory, 
														  stock_ym, 
														  warehouse,
														  item_cd, 
														  spec_cd, 
														  color_cd, 
														  item_name, 
														  spec_name, 
														  color_name };

				Pop_BK_InOut_Infomation pop_form = new Pop_BK_InOut_Infomation(pop_parameter);
				pop_form.ShowDialog();




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuItem_InOut_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


 
		#endregion    
		 
		#region DB Connect 

		#endregion																								

	

			

		

		


	}

		
}

		
