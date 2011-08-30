using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Data.SqlClient; 
using System.Data.OleDb;


namespace FlexOrder.ExpLoad
{
	public class POP_EL_GAC_LOAD : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT2;
		private System.Windows.Forms.DateTimePicker dpick_BEDAT1;
		private System.Windows.Forms.Label lbl_BEDAT;
		private System.Windows.Forms.Label btn_UPC_Load;
		private System.Windows.Forms.TextBox txt_Msg;
		private System.Windows.Forms.Label btn_Cancel;
		public COM.FSP fgrid_Gac;
		private System.ComponentModel.IContainer components = null;

		public POP_EL_GAC_LOAD()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_GAC_LOAD));
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Gac = new COM.FSP();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_BEDAT2 = new System.Windows.Forms.DateTimePicker();
			this.dpick_BEDAT1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_BEDAT = new System.Windows.Forms.Label();
			this.btn_UPC_Load = new System.Windows.Forms.Label();
			this.txt_Msg = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Gac)).BeginInit();
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
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 2;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(6, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 246;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Gac);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(6, 80);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(326, 260);
			this.pnl_Body.TabIndex = 245;
			// 
			// fgrid_Gac
			// 
			this.fgrid_Gac.AutoResize = false;
			this.fgrid_Gac.BackColor = System.Drawing.Color.White;
			this.fgrid_Gac.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Gac.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_Gac.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Gac.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Gac.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Gac.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Gac.Location = new System.Drawing.Point(2, 2);
			this.fgrid_Gac.Name = "fgrid_Gac";
			this.fgrid_Gac.Rows.Count = 2;
			this.fgrid_Gac.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Gac.Size = new System.Drawing.Size(322, 256);
			this.fgrid_Gac.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Gac.TabIndex = 38;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(110, 32);
			this.txt_Factory.MaxLength = 6;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(220, 20);
			this.txt_Factory.TabIndex = 241;
			this.txt_Factory.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(214, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 12);
			this.label1.TabIndex = 250;
			this.label1.Text = "~";
			// 
			// dpick_BEDAT2
			// 
			this.dpick_BEDAT2.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_BEDAT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT2.Location = new System.Drawing.Point(233, 54);
			this.dpick_BEDAT2.Name = "dpick_BEDAT2";
			this.dpick_BEDAT2.Size = new System.Drawing.Size(97, 21);
			this.dpick_BEDAT2.TabIndex = 249;
			this.dpick_BEDAT2.Value = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
			// 
			// dpick_BEDAT1
			// 
			this.dpick_BEDAT1.CustomFormat = "yyyy-MM-dd";
			this.dpick_BEDAT1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_BEDAT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_BEDAT1.Location = new System.Drawing.Point(110, 54);
			this.dpick_BEDAT1.MaxDate = new System.DateTime(9998, 12, 19, 0, 0, 0, 0);
			this.dpick_BEDAT1.Name = "dpick_BEDAT1";
			this.dpick_BEDAT1.Size = new System.Drawing.Size(97, 21);
			this.dpick_BEDAT1.TabIndex = 248;
			this.dpick_BEDAT1.Value = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
			// 
			// lbl_BEDAT
			// 
			this.lbl_BEDAT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BEDAT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_BEDAT.ImageIndex = 1;
			this.lbl_BEDAT.ImageList = this.img_Label;
			this.lbl_BEDAT.Location = new System.Drawing.Point(6, 54);
			this.lbl_BEDAT.Name = "lbl_BEDAT";
			this.lbl_BEDAT.Size = new System.Drawing.Size(100, 21);
			this.lbl_BEDAT.TabIndex = 247;
			this.lbl_BEDAT.Text = "Doc Date";
			this.lbl_BEDAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_UPC_Load
			// 
			this.btn_UPC_Load.ImageIndex = 0;
			this.btn_UPC_Load.ImageList = this.img_Button;
			this.btn_UPC_Load.Location = new System.Drawing.Point(8, 401);
			this.btn_UPC_Load.Name = "btn_UPC_Load";
			this.btn_UPC_Load.Size = new System.Drawing.Size(70, 23);
			this.btn_UPC_Load.TabIndex = 253;
			this.btn_UPC_Load.Text = "GPO Load";
			this.btn_UPC_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_Msg
			// 
			this.txt_Msg.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Msg.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Msg.Location = new System.Drawing.Point(8, 345);
			this.txt_Msg.MaxLength = 10;
			this.txt_Msg.Multiline = true;
			this.txt_Msg.Name = "txt_Msg";
			this.txt_Msg.ReadOnly = true;
			this.txt_Msg.Size = new System.Drawing.Size(326, 48);
			this.txt_Msg.TabIndex = 252;
			this.txt_Msg.Text = "";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(264, 401);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 251;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// POP_EL_GAC_LOAD
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(338, 432);
			this.Controls.Add(this.btn_UPC_Load);
			this.Controls.Add(this.txt_Msg);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.dpick_BEDAT1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dpick_BEDAT2);
			this.Controls.Add(this.lbl_BEDAT);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.txt_Factory);
			this.Name = "POP_EL_GAC_LOAD";
			this.Load += new System.EventHandler(this.POP_EL_GAC_LOAD_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.lbl_BEDAT, 0);
			this.Controls.SetChildIndex(this.dpick_BEDAT2, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.dpick_BEDAT1, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.txt_Msg, 0);
			this.Controls.SetChildIndex(this.btn_UPC_Load, 0);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Gac)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의

		int  _Rowfixed = 2;
		private OleDbDataReader reader_GAC;
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 멤버메쏘드

		private void Init_Form()
		{ 
			//Title
			this.Text = "GAC Loading";
			this.lbl_MainTitle.Text = "GAC Loading"; 
			ClassLib.ComFunction.SetLangDic(this);
		
			// 그리드 설정(TBSEM_POP_CLS)
			fgrid_Gac.Set_Grid( "SEM_GAC", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Gac.Font  = new Font("Verdana",8);

			txt_Factory.Text    = COM.ComVar.Parameter_PopUp[0];
			dpick_BEDAT1.Text   = COM.ComVar.Parameter_PopUp[1];
			dpick_BEDAT2.Text   = COM.ComVar.Parameter_PopUp[2];

			dpick_BEDAT1.Enabled  = false;
			dpick_BEDAT2.Enabled  = false;


			Select_GAC_List();	
			
		}



		#endregion

		#region  DB컨넥트

		/// <summary>
		/// Select_MCR_GAC : GAC찾기
		/// </summary>
		private void Select_GAC_List()
		{
			
			
			fgrid_Gac.Rows.Count = _Rowfixed;

			
			string strSql_GAC = "SELECT  '" + txt_Factory.Text   + "' AS FACTORY, " +
								"EBELN  AS OBS_NU,     " +
								"EBELP  AS OBS_SEQ_NU, " +
								"REPLACE(CONVERT(VARCHAR(10),RGAC_DT_DTTM,120),'-','') AS RGAC, " +
								"REPLACE(CONVERT(VARCHAR(10),J_3AEXFCP,120),'-','')    AS OGAC,    " +
								"REPLACE(CONVERT(VARCHAR(10),ZZ_GAC_DT,120),'-','')    AS CGAC,    " +   
								"FFS_CHNG_DTTM  AS CHANGE_DATE,  " +
								"'Y',"+
								"'"       +  ClassLib.ComVar.This_User+ "',"+
								"'"       + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
								"      FROM EKPO ";


			fgrid_Gac.Rows.Count = _Rowfixed;  
			
			DataTable dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSQL);

			reader_GAC = ClassLib.ComFunction.Read_MSSQL(strSql_GAC, 
				dt_list.Rows[0].ItemArray[1].ToString(), 
				dt_list.Rows[0].ItemArray[3].ToString(), 
				dt_list.Rows[0].ItemArray[5].ToString() );	       

				     
			

			string[] str_d = new string[reader_GAC.FieldCount];			
			while (reader_GAC.Read())
			{
				for(int i=0; i<reader_GAC.FieldCount; i++)				
					str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_GAC[i].GetType().Name.ToString(), reader_GAC[i].ToString());

				for(int i=0; i<reader_GAC.FieldCount; i++)				
				{
					if (i==2)
						str_d[i] = reader_GAC[i].ToString().PadLeft(6, '0').ToString();
					else
						str_d[i] = ClassLib.ComFunction.Convert_dtType(reader_GAC[i].GetType().Name.ToString(), reader_GAC[i].ToString());
				}
			
				fgrid_Gac.AddItem(str_d, fgrid_Gac.Rows.Count, 1);

				str_d.Initialize();							
			}			          		
			fgrid_Gac.AutoSizeCols();
			fgrid_Gac.Cols[0].Width = 20;


		}


		#endregion

		#region 이벤트처리


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();			
		}




		#endregion

		private void POP_EL_GAC_LOAD_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

