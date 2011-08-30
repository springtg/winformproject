using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using System.Data.OleDb;



namespace FlexOrder.ExpLoad
{
	public class POP_EL_GAC : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Label btn_Gac_Save;
		private System.Windows.Forms.TextBox txt_Msg;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Path;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Sheet;
		private System.ComponentModel.IContainer components = null;
		
		public POP_EL_GAC()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_GAC));
			this.btn_Gac_Save = new System.Windows.Forms.Label();
			this.txt_Msg = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Path = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Sheet = new System.Windows.Forms.TextBox();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			// btn_Gac_Save
			// 
			this.btn_Gac_Save.ImageIndex = 0;
			this.btn_Gac_Save.ImageList = this.img_Button;
			this.btn_Gac_Save.Location = new System.Drawing.Point(6, 449);
			this.btn_Gac_Save.Name = "btn_Gac_Save";
			this.btn_Gac_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Gac_Save.TabIndex = 238;
			this.btn_Gac_Save.Text = "Save";
			this.btn_Gac_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Gac_Save.Click += new System.EventHandler(this.btn_Gac_Save_Click);
			// 
			// txt_Msg
			// 
			this.txt_Msg.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Msg.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Msg.Location = new System.Drawing.Point(7, 408);
			this.txt_Msg.MaxLength = 10;
			this.txt_Msg.Multiline = true;
			this.txt_Msg.Name = "txt_Msg";
			this.txt_Msg.ReadOnly = true;
			this.txt_Msg.Size = new System.Drawing.Size(326, 40);
			this.txt_Msg.TabIndex = 237;
			this.txt_Msg.Text = "";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(258, 449);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 236;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(7, 152);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(326, 256);
			this.pnl_Body.TabIndex = 235;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(2, 2);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Count = 2;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(322, 252);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(10, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 234;
			this.label1.Text = "OBS Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_ID
			// 
			this.txt_OBS_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID.Enabled = false;
			this.txt_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID.Location = new System.Drawing.Point(111, 55);
			this.txt_OBS_ID.MaxLength = 10;
			this.txt_OBS_ID.Name = "txt_OBS_ID";
			this.txt_OBS_ID.Size = new System.Drawing.Size(220, 20);
			this.txt_OBS_ID.TabIndex = 233;
			this.txt_OBS_ID.Text = "";
			// 
			// txt_OBS_Type
			// 
			this.txt_OBS_Type.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type.Enabled = false;
			this.txt_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type.Location = new System.Drawing.Point(111, 78);
			this.txt_OBS_Type.MaxLength = 10;
			this.txt_OBS_Type.Name = "txt_OBS_Type";
			this.txt_OBS_Type.ReadOnly = true;
			this.txt_OBS_Type.Size = new System.Drawing.Size(220, 20);
			this.txt_OBS_Type.TabIndex = 232;
			this.txt_OBS_Type.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(111, 32);
			this.txt_Factory.MaxLength = 6;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(220, 20);
			this.txt_Factory.TabIndex = 231;
			this.txt_Factory.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 2;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(10, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 230;
			this.label7.Text = "OBS ID";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(10, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 229;
			this.label9.Text = "Factory";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(10, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 240;
			this.label2.Text = "File Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Path
			// 
			this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Path.Enabled = false;
			this.txt_Path.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Path.Location = new System.Drawing.Point(111, 101);
			this.txt_Path.MaxLength = 10;
			this.txt_Path.Name = "txt_Path";
			this.txt_Path.ReadOnly = true;
			this.txt_Path.Size = new System.Drawing.Size(220, 20);
			this.txt_Path.TabIndex = 239;
			this.txt_Path.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 2;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(10, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 242;
			this.label3.Text = "Sheet Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Sheet
			// 
			this.txt_Sheet.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Sheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Sheet.Enabled = false;
			this.txt_Sheet.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Sheet.Location = new System.Drawing.Point(111, 123);
			this.txt_Sheet.MaxLength = 10;
			this.txt_Sheet.Name = "txt_Sheet";
			this.txt_Sheet.ReadOnly = true;
			this.txt_Sheet.Size = new System.Drawing.Size(220, 20);
			this.txt_Sheet.TabIndex = 241;
			this.txt_Sheet.Text = "";
			// 
			// POP_EL_GAC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(338, 479);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_Sheet);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Path);
			this.Controls.Add(this.btn_Gac_Save);
			this.Controls.Add(this.txt_Msg);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_OBS_ID);
			this.Controls.Add(this.txt_OBS_Type);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Name = "POP_EL_GAC";
			this.Load += new System.EventHandler(this.POP_EL_GAC_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_OBS_Type, 0);
			this.Controls.SetChildIndex(this.txt_OBS_ID, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.txt_Msg, 0);
			this.Controls.SetChildIndex(this.btn_Gac_Save, 0);
			this.Controls.SetChildIndex(this.txt_Path, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.txt_Sheet, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region 속성정의
		int _Rowfixed = 2;
		private COM.OraDB MyOraDB = new COM.OraDB();

		private OleDbDataReader reader_gac;

		#endregion

		#region 멤버 메서드
		private void Init_Form()
		{ 
			//Title
			this.Text = "OGAC/RGAC Loading";
			this.lbl_MainTitle.Text = "OGAC/RGAC Loading"; 
			ClassLib.ComFunction.SetLangDic(this);
		
			// 그리드 설정(TBSEM_OBS_GAC)
			fgrid_Main.Set_Grid( "SEM_GAC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Font  = new Font("Verdana",8);


			Sb_List();
			
		}

		private void Sb_List()
		{ 
			try
			{		
				txt_Factory.Text   = COM.ComVar.Parameter_PopUp[0];
				txt_OBS_ID.Text    = COM.ComVar.Parameter_PopUp[1];
				txt_OBS_Type.Text  = COM.ComVar.Parameter_PopUp[2];
				txt_Path.Text      = COM.ComVar.Parameter_PopUp[3];
				txt_Sheet.Text     = COM.ComVar.Parameter_PopUp[4];


				Select_GAC_List();		
		
				if (fgrid_Main.Rows.Count == _Rowfixed) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
				}
		 
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}

		}

		#endregion

		#region DB 컨트롤
		private void Select_GAC_List()
		{
			string strSrc = txt_Path.Text;
			fgrid_Main.Rows.Count = _Rowfixed;

			string strSql_GAC = " SELECT * "+ 
				"   FROM [" + txt_Sheet.Text+ "$]  "; 


			fgrid_Main.Rows.Count = _Rowfixed;
			reader_gac = ClassLib.ComFunction.Read_Excel(strSrc, strSql_GAC); 
			string[] str_k = new string[reader_gac.FieldCount];			 //검증 추가 칼럼
			while (reader_gac.Read())
			{
			
				for(int i=0; i<=(int)ClassLib.TBSEM_OBS_GAC.lxJOB_DIV; i++)				
				{  
					str_k[i] = reader_gac[i].ToString();

					if (i <(int)ClassLib.TBSEM_OBS_GAC.lxDOC_YMD-1 )
						str_k[i] = reader_gac[i].ToString().PadLeft(10, '0').ToString();
					
					if ((i==(int)ClassLib.TBSEM_OBS_GAC.lxDOC_YMD-1) ||
						(i==(int)ClassLib.TBSEM_OBS_GAC.lxOGAC_YMD-1) ||
						(i==(int)ClassLib.TBSEM_OBS_GAC.lxRTS_YMD-1))
						str_k[i] = Convert.ToDateTime(reader_gac[i]).ToString("yyyyMMdd");

					
					if (i == (int)ClassLib.TBSEM_OBS_GAC.lxJOB_DIV-1)
						str_k[i] = "N";

				}

				fgrid_Main.AddItem(str_k, fgrid_Main.Rows.Count, 1);
				
				str_k.Initialize();	
			}

		}

		private DataSet Save_Gac( int arg_row, C1FlexGrid arg_fgrid)
		{
			DataSet ds_ret;


			int col_ct = 7;

			MyOraDB.ReDim_Parameter(col_ct); 

			MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_OBS_GAC";

			for(int i = 0; i < col_ct; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";   
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";       
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU";   
			MyOraDB.Parameter_Name[3]  = "ARG_OGAC_YMD";     
			MyOraDB.Parameter_Name[4]  = "ARG_RTS_YMD";      
			MyOraDB.Parameter_Name[5]  = "ARG_UPD_USER";   	
			MyOraDB.Parameter_Name[6]  = "ARG_UPD_YMD"; 
     
			MyOraDB.Parameter_Values[0] = txt_Factory.Text; 
			MyOraDB.Parameter_Values[1] = arg_fgrid[arg_row,(int)ClassLib.TBSEM_OBS_GAC.lxOBS_NU].ToString();
			MyOraDB.Parameter_Values[2] = arg_fgrid[arg_row,(int)ClassLib.TBSEM_OBS_GAC.lxOBS_SEQ_NU].ToString();
			MyOraDB.Parameter_Values[3] = arg_fgrid[arg_row,(int)ClassLib.TBSEM_OBS_GAC.lxOGAC_YMD].ToString();
			MyOraDB.Parameter_Values[4] = arg_fgrid[arg_row,(int)ClassLib.TBSEM_OBS_GAC.lxRTS_YMD].ToString();
			MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[6] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");	
			
			MyOraDB.Add_Modify_Parameter(true);
			ds_ret  =  MyOraDB.Exe_Modify_Procedure();
			
			return ds_ret;


		}

		#endregion

		#region 이벤트처리

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Gac_Save_Click(object sender, System.EventArgs e)
		{
			try
			{
				DataSet ds_ret;

				
				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;


				for (int i =_Rowfixed ; i<fgrid_Main.Rows.Count; i++) 
				{ 
					ds_ret = Save_Gac(i,fgrid_Main);

					if (ds_ret == null) 
					{
						fgrid_Main[i,(int)ClassLib.TBSEM_OBS_GAC.lxJOB_DIV] ="E";
						fgrid_Main.GetCellRange(i,fgrid_Main.Rows.Count -1,i,fgrid_Main.Rows.Count -1).StyleNew.ForeColor 
							=  ClassLib.ComVar.Clr_Text_Red;
					
						txt_Msg.Text = txt_Msg.Text + fgrid_Main[i,(int)ClassLib.TBSEM_OBS_GAC.lxOBS_NU].ToString()+ "-"+
							fgrid_Main[i,(int)ClassLib.TBSEM_OBS_GAC.lxOBS_SEQ_NU].ToString();

					}
					else
					{
						fgrid_Main[i,(int)ClassLib.TBSEM_OBS_GAC.lxJOB_DIV] ="Y";	
					}

					fgrid_Main.TopRow = i;
					System.Windows.Forms.Application.DoEvents();
				}
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
		}

		#endregion

		private void POP_EL_GAC_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
	}
}

