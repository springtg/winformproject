using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
//using System.Data.SqlClient; 

namespace FlexOrder.ExpLoad
{
	public class POP_EL_BP : COM.OrderWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_EKET;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Button btn_desc;
		private System.ComponentModel.IContainer components = null;

		public POP_EL_BP()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_BP));
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.btn_desc = new System.Windows.Forms.Button();
			this.fgrid_EKET = new COM.FSP();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).BeginInit();
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
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.btn_desc);
			this.pnl_Body.Controls.Add(this.fgrid_EKET);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(2, 57);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(400, 30);
			this.pnl_Body.TabIndex = 224;
			// 
			// btn_desc
			// 
			this.btn_desc.BackColor = System.Drawing.Color.Transparent;
			this.btn_desc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_desc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_desc.Location = new System.Drawing.Point(2, 2);
			this.btn_desc.Name = "btn_desc";
			this.btn_desc.Size = new System.Drawing.Size(396, 26);
			this.btn_desc.TabIndex = 46;
			// 
			// fgrid_EKET
			// 
			this.fgrid_EKET.AutoResize = false;
			this.fgrid_EKET.BackColor = System.Drawing.Color.White;
			this.fgrid_EKET.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKET.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_EKET.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKET.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKET.Location = new System.Drawing.Point(736, 208);
			this.fgrid_EKET.Name = "fgrid_EKET";
			this.fgrid_EKET.Rows.Count = 2;
			this.fgrid_EKET.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKET.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKET.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKET.TabIndex = 45;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(109, 33);
			this.txt_Factory.MaxLength = 6;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(67, 20);
			this.txt_Factory.TabIndex = 223;
			this.txt_Factory.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(8, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 222;
			this.label9.Text = "Factory";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Enabled = false;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(290, 33);
			this.txt_Style.MaxLength = 6;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(110, 20);
			this.txt_Style.TabIndex = 228;
			this.txt_Style.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(188, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 227;
			this.label1.Text = "Style CD";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(328, 88);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 229;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// POP_EL_BP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(402, 111);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.txt_Style);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.label9);
			this.DockPadding.All = 2;
			this.Name = "POP_EL_BP";
			this.Load += new System.EventHandler(this.POP_EL_BP_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt_Style, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
		private int _Rowfixed=2;  
		private COM.OraDB MyOraDB = new COM.OraDB();
		#endregion

		#region 멤버 메서드
		private void Init_Form()
		{ 
			//Title
			this.Text = "BP Loading Verificationn";
			this.lbl_MainTitle.Text = "BP Loading Verificationn"; 
			ClassLib.ComFunction.SetLangDic(this);
		

			Sb_Select();
		}


		private void Sb_Select()
		{
			try
			{
				txt_Factory.Text   = COM.ComVar.Parameter_PopUp[0];				
				txt_Style.Text   = COM.ComVar.Parameter_PopUp[3];				
			
				Select_PO_Qty();
				

			}
			catch
			{
				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}	
		}



		#endregion

		#region DB 컨트롤
		private void  Select_PO_Qty()
		{			
			DataSet ds_ret;

			string process_name = "PKG_SEM_BP.SELECT_SEM_BP_POP";

			int iCnt  = 5;

			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_PONO_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_PONO_TO";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i=0 ; i<iCnt-1;i++)
			{
				MyOraDB.Parameter_Type[i]  = (int)OracleType.VarChar;
			}
			MyOraDB.Parameter_Type[iCnt -1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1]  = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2]  = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3]  = COM.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if (ds_ret == null)  return  ;

			DataTable dt_list;

			dt_list  =  ds_ret.Tables[process_name];

				
		     btn_desc.Text  = "Current Quantity:"  + dt_list.Rows[0].ItemArray[1].ToString();
				

		}

		#endregion

		#region 이벤트처리
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}



		#endregion

		
		private void POP_EL_BP_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

	}
}

