using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdOrder
{
	public class Pop_ChangeVtoRLot : COM.APSWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Label btn_Apply;
		public System.Windows.Forms.Label btn_Cancel;
		public COM.FSP fgrid_LOT;
		private System.ComponentModel.IContainer components = null;

		public Pop_ChangeVtoRLot()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_ChangeVtoRLot));
			this.fgrid_LOT = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(320, 23);
			this.lbl_MainTitle.Text = "Change Virtual LOT into Real LOT";
			// 
			// fgrid_LOT
			// 
			this.fgrid_LOT.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LOT.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LOT.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_LOT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LOT.Location = new System.Drawing.Point(8, 40);
			this.fgrid_LOT.Name = "fgrid_LOT";
			this.fgrid_LOT.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LOT.Size = new System.Drawing.Size(376, 240);
			this.fgrid_LOT.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LOT.TabIndex = 279;
			this.fgrid_LOT.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_LOT_AfterEdit);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(243, 288);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 282;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(314, 288);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 283;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_ChangeVtoRLot
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 320);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.fgrid_LOT);
			this.Name = "Pop_ChangeVtoRLot";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Virtual LOT into Real LOT";
			this.Load += new System.EventHandler(this.Pop_ChangeVtoRLot_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_LOT, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LOT)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
  
		public DataTable _DtLOT;

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{   
			try
			{

				//Title 
				this.Text = "Change Virtual LOT into Real LOT";
				lbl_MainTitle.Text = "Change Virtual LOT into Real LOT";
  
				ClassLib.ComFunction.SetLangDic(this);  
 
				fgrid_LOT.Set_Grid("SPO_LOT_CHANGE", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true); 
				Display_Grid(_DtLOT, fgrid_LOT);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			try
			{
				arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
				arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
  
				//All Select Row
				arg_fgrid.Rows.Add(); 
				arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;
				arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_CHANGE.IxCHECK_FLAG] = "TRUE";


				// Set List
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed + 1, 0] = "";  
				}  
				  
				arg_fgrid.AutoSizeCols(); 
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion 

		#region 이벤트 처리

		private void fgrid_LOT_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				if(e.Col != (int)ClassLib.TBSPO_LOT_CHANGE.IxCHECK_FLAG) return;
 
				if(e.Row != fgrid_LOT.Rows.Fixed) return;
 
				for(int i = e.Row + 1; i < fgrid_LOT.Rows.Count; i++) 
				{ 
					fgrid_LOT[i, e.Col] = fgrid_LOT[e.Row, e.Col].ToString();
				}
			 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_LOT_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(fgrid_LOT.Rows.Count <= fgrid_LOT.Rows.Fixed) return;

				Change_VLOTtoRLOT();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// Change_VLOTtoRLOT : 
		/// </summary>
		private void Change_VLOTtoRLOT()
		{ 
			string factory = "", lotno = "", lotseq = "";
			bool run_flag = false;

			try
			{
				for(int i = fgrid_LOT.Rows.Fixed + 1; i < fgrid_LOT.Rows.Count; i++)
				{
					if(fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_CHANGE.IxCHECK_FLAG] == null) continue;

					if(!Convert.ToBoolean(fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_CHANGE.IxCHECK_FLAG].ToString()) ) continue;

					factory = fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_CHANGE.IxFACTORY].ToString(); 
					string[] token = fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_CHANGE.IxLOT].ToString().Split('-');
					lotno = token[0];
					lotseq = token[1];

					this.Cursor = Cursors.WaitCursor;
 
					ProdPlan.Form_PO_LOTDaily p_form = new ProdPlan.Form_PO_LOTDaily();
					run_flag = p_form.Update_ChangeLOT(factory, lotno, lotseq);

					this.Cursor = Cursors.Default;

					if(run_flag)
					{
						fgrid_LOT[i, (int)ClassLib.TBSPO_LOT_CHANGE.IxSTATUS] = "Completed";
					} 

					fgrid_LOT.TopRow = i;
					System.Windows.Forms.Application.DoEvents();

				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Change_VLOTtoRLOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion 

		#region DB Connect

		#endregion 
 
		
		private void Pop_ChangeVtoRLot_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

 


	}
}

