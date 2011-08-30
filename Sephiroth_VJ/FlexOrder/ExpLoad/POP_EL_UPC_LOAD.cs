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
	public class POP_EL_UPC_LOAD : COM.OrderWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.TextBox txt_Msg;
		private System.Windows.Forms.Label btn_Cancel;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label btn_UPC_Load;
		private System.ComponentModel.IContainer components = null;

		public POP_EL_UPC_LOAD()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_UPC_LOAD));
			this.btn_UPC_Load = new System.Windows.Forms.Label();
			this.txt_Msg = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
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
			// btn_UPC_Load
			// 
			this.btn_UPC_Load.ImageIndex = 0;
			this.btn_UPC_Load.ImageList = this.img_Button;
			this.btn_UPC_Load.Location = new System.Drawing.Point(8, 403);
			this.btn_UPC_Load.Name = "btn_UPC_Load";
			this.btn_UPC_Load.Size = new System.Drawing.Size(70, 23);
			this.btn_UPC_Load.TabIndex = 238;
			this.btn_UPC_Load.Text = "UPC Load";
			this.btn_UPC_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_UPC_Load.Click += new System.EventHandler(this.btn_UPC_Load_Click);
			// 
			// txt_Msg
			// 
			this.txt_Msg.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Msg.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Msg.Location = new System.Drawing.Point(8, 352);
			this.txt_Msg.MaxLength = 10;
			this.txt_Msg.Multiline = true;
			this.txt_Msg.Name = "txt_Msg";
			this.txt_Msg.ReadOnly = true;
			this.txt_Msg.Size = new System.Drawing.Size(326, 48);
			this.txt_Msg.TabIndex = 237;
			this.txt_Msg.Text = "";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(264, 403);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 236;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(8, 104);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(326, 248);
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
			this.fgrid_Main.Size = new System.Drawing.Size(322, 244);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 80);
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
			this.txt_OBS_ID.Location = new System.Drawing.Point(112, 56);
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
			this.txt_OBS_Type.Location = new System.Drawing.Point(112, 80);
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
			this.txt_Factory.Location = new System.Drawing.Point(112, 32);
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
			this.label7.Location = new System.Drawing.Point(8, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 230;
			this.label7.Text = "OBS ID";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 2;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 239;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// POP_EL_UPC_LOAD
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(338, 432);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.btn_UPC_Load);
			this.Controls.Add(this.txt_Msg);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_OBS_ID);
			this.Controls.Add(this.txt_OBS_Type);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.label7);
			this.Name = "POP_EL_UPC_LOAD";
			this.Load += new System.EventHandler(this.POP_EL_UPC_LOAD_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_OBS_Type, 0);
			this.Controls.SetChildIndex(this.txt_OBS_ID, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.txt_Msg, 0);
			this.Controls.SetChildIndex(this.btn_UPC_Load, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
		int  _Rowfixed = 2;
		private OleDbDataReader reader_EKET;
		private COM.OraDB MyOraDB = new COM.OraDB();
		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{ 
			//Title
			this.Text = "UPC Loading";
			this.lbl_MainTitle.Text = "UPC Loading"; 
			ClassLib.ComFunction.SetLangDic(this);
		
			// 그리드 설정(TBSEM_POP_CLS)
			fgrid_Main.Set_Grid( "SEM_UPC", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.Font  = new Font("Verdana",8);

			Sb_Set();
			
		}

		
		private void Sb_Set()
		{ 
			txt_Factory.Text   = COM.ComVar.Parameter_PopUp[0];
			txt_OBS_ID.Text    = COM.ComVar.Parameter_PopUp[1];
			txt_OBS_Type.Text  = COM.ComVar.Parameter_PopUp[2];

			Select_No_UCC();

			

		}



		private bool Apply_Sem_UCC(int  arg_cnt)
		{
            //DataTable  dt_list ;

			string sOBS_Seq_Nu  = fgrid_Main[arg_cnt,(int)ClassLib.TBSEM_UPC.IxOBS_SEQ_NU].ToString();
			int iStart = 0;

			for (int i  = 0; i< sOBS_Seq_Nu.Length   ;i++)
			{
				//MessageBox.Show(sOBS_Seq_Nu.Substring(i,1).ToString());

				if (sOBS_Seq_Nu.Substring(i,1) != "0")
				{
					iStart  =i;  sOBS_Seq_Nu  = sOBS_Seq_Nu.Substring(iStart,sOBS_Seq_Nu.Length-iStart);
					break;
				}

			}

		    reader_EKET  = Select_UPC(fgrid_Main[arg_cnt,(int)ClassLib.TBSEM_UPC.IxFACTORY].ToString(),
				                  fgrid_Main[arg_cnt,(int)ClassLib.TBSEM_UPC.IxOBS_NU].ToString(),
								  sOBS_Seq_Nu);

			if (reader_EKET  == null) 
			{
				return false;
			}
			else
			{
				if (Save_Sem_UCC(reader_EKET) == false)
				 { 
					return false;
				 }
			}


			return true;

			
		

		}



		private bool Save_Sem_UCC(OleDbDataReader arg_list)
		{

			try
			{
				
				int intParm = 7 ;

				MyOraDB.ReDim_Parameter(intParm); 

				MyOraDB.Process_Name = "PKG_SEM_GPO.SAVE_SEM_OBS_SIZE_UPC";

				for(int i = 0; i < intParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				
				MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";  
				MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU"; 
				MyOraDB.Parameter_Name[3]  = "ARG_NIKE_SIZE";  
				MyOraDB.Parameter_Name[4]  = "ARG_UPC_NU";   
				MyOraDB.Parameter_Name[5]  = "ARG_UPD_USER";	  
				MyOraDB.Parameter_Name[6]  = "ARG_UPD_YMD";  

				while (arg_list.Read())
				{
					for(int i=0; i<arg_list.FieldCount; i++)				
					{
						MyOraDB.Parameter_Values[i]  =  arg_list[i].ToString();

						if (i == 2) 
							MyOraDB.Parameter_Values[i]  = arg_list[i].ToString().PadLeft(10, '0').ToString();

					}

					MyOraDB.Add_Modify_Parameter(true);										
					MyOraDB.Exe_Modify_Procedure();
									
				}			          		
					


				return true;
			}
			catch
			{
					              
				return false;
			}
		
			



		}




		
		private OleDbDataReader  Select_UPC(string arg_factory, string arg_obs_seq, string arg_obs_seq_nu)
		{

		
			string strSql_EKET ="select '" +   arg_factory+ "' as factory," + 
				"       ebeln as obs_nu," +
				"       ebelp as obs_seq_nu," +
				"       j_3asize as nike_size," +
				"       ean11 as upc_nu," +
				"'" +   ClassLib.ComVar.This_User+ "',"+
				"'" +   System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"'"+
				"  from eket " +
				" where ebeln = '" +  arg_obs_seq    + "'" +                                                                
				"   and ebelp = '" +  arg_obs_seq_nu + "'";				


			DataTable dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSQL);
 
			reader_EKET = ClassLib.ComFunction.Read_MSSQL(strSql_EKET, 
							dt_list.Rows[0].ItemArray[1].ToString(), 
							dt_list.Rows[0].ItemArray[3].ToString(), 
							dt_list.Rows[0].ItemArray[5].ToString() );	     


			return reader_EKET;



		}
		
		

	



		#endregion

		#region DB 컨넥트

		/// <summary>
		/// Select_MNT : Monitoring찾기
		/// </summary>
		private void Select_No_UCC()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_GPO.SELECT_SEM_NOFOUNDUPC";

			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";



			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = txt_Factory.Text;
			MyOraDB.Parameter_Values[1]  = txt_OBS_ID.Text;
			MyOraDB.Parameter_Values[2]  = txt_OBS_Type.Text;
			MyOraDB.Parameter_Values[3]  = ClassLib.ComVar.This_User.Trim();
			MyOraDB.Parameter_Values[4]  = "";

			MyOraDB.Add_Select_Parameter(true); 

			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null)  return ;

			DataTable dt_list  =  ds_ret.Tables[process_name];


			for(int i=0; i < dt_list.Rows.Count; i++)
			{	
				fgrid_Main.AddItem(dt_list.Rows[i].ItemArray,fgrid_Main.Rows.Count, 1);
				fgrid_Main[i + _Rowfixed, 0] = " "; 

			} 


		}

		#endregion

		#region 이벤트 처리

		
		private void btn_UPC_Load_Click(object sender, System.EventArgs e)
		{
			//Save_UPC();
			for (int i  = _Rowfixed ; i< fgrid_Main.Rows.Count   ; i++)
			{
				if (Apply_Sem_UCC(i) == false)
				{
					fgrid_Main[i,(int)ClassLib.TBSEM_UPC.IxJOB_FLAG]  = ClassLib.ComVar.ConsReal_N;
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					break;
				}
				else
				{
					fgrid_Main[i,(int)ClassLib.TBSEM_UPC.IxJOB_FLAG]  = ClassLib.ComVar.ConsReal_Y;
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
				}
			}
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}




		#endregion


		private void POP_EL_UPC_LOAD_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

