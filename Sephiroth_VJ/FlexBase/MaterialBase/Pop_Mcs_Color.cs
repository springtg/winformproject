using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
namespace FlexBase.MaterialBase
{
	public class Pop_Mcs_Color : COM.PCHWinForm.Pop_Small
	{
		
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_SCode;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label btn_close;
        private System.Windows.Forms.Label btn_apply;
        private System.ComponentModel.IContainer components = null;
        public COM.FSP fgrid_Color;
        private Label btn_Search;
		private COM.OraDB MyOraDB = new COM.OraDB();

		public Pop_Mcs_Color()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Mcs_Color));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_SCode = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.fgrid_Color = new COM.FSP();
            this.btn_Search = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lbl_SCode);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(5, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 36);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lbl_SCode
            // 
            this.lbl_SCode.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_SCode.ImageIndex = 0;
            this.lbl_SCode.ImageList = this.img_Label;
            this.lbl_SCode.Location = new System.Drawing.Point(4, 10);
            this.lbl_SCode.Name = "lbl_SCode";
            this.lbl_SCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_SCode.TabIndex = 37;
            this.lbl_SCode.Text = "Search Color";
            this.lbl_SCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Code.Location = new System.Drawing.Point(105, 10);
            this.txt_Code.MaxLength = 10;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(67, 21);
            this.txt_Code.TabIndex = 159;
            this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Name.Location = new System.Drawing.Point(173, 10);
            this.txt_Name.MaxLength = 120;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 21);
            this.txt_Name.TabIndex = 160;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(320, 291);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 24);
            this.btn_close.TabIndex = 548;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(248, 291);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 547;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // fgrid_Color
            // 
            this.fgrid_Color.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Color.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fgrid_Color.Location = new System.Drawing.Point(5, 65);
            this.fgrid_Color.Name = "fgrid_Color";
            this.fgrid_Color.Rows.DefaultSize = 18;
            this.fgrid_Color.Size = new System.Drawing.Size(380, 220);
            this.fgrid_Color.StyleInfo = resources.GetString("fgrid_Color.StyleInfo");
            this.fgrid_Color.TabIndex = 549;
            this.fgrid_Color.DoubleClick += new System.EventHandler(this.fgrid_Color_DoubleClick);
            // 
            // btn_Search
            // 
            this.btn_Search.ImageIndex = 27;
            this.btn_Search.ImageList = this.img_SmallButton;
            this.btn_Search.Location = new System.Drawing.Point(355, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(21, 21);
            this.btn_Search.TabIndex = 571;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Pop_Mcs_Color
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.fgrid_Color);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Mcs_Color";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Mcs_Color_Closing);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.fgrid_Color, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 변수

		public int _Rowfixed = 2;

		#endregion

		#region 멤버 메쏘드

		private void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Color Master";
                lbl_MainTitle.Text = "Color Master";
				ClassLib.ComFunction.SetLangDic(this);
			

				// 그리드 설정
				fgrid_Color.Set_Grid("SBC_MCS_COLOR", "1", 1,  COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			 
		}




		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{

            arg_fgrid.Display_Grid(arg_dt, false);
            
		}
 


		/// <summary>
		/// Search_Color : 데이터 조회
		/// </summary>
		/// <param name="arg_code"></param>
		/// <param name="arg_name"></param>
		private void Search_Color(string arg_factory, string arg_code,string arg_name)
		{
			DataTable dt_ret;

			try
			{
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor; 
				
				//dt_ret = Form_BC_Color.Select_SBC_COLOR(arg_code, arg_name);
				dt_ret  = this.Select_Sbc_Mcs_Color(arg_factory, arg_code,arg_name);
				Display_Grid(dt_ret,fgrid_Color);
				dt_ret.Dispose();
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Color", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}




		

		#endregion

		#region  DB Connect

		/// <summary>
		///Select_SBC_MCS_COLOR : MCS Color 조회
		/// </summary>
		/// <returns></returns>
		public  DataTable Select_Sbc_Mcs_Color(string arg_factory, string arg_code,string arg_name)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_MCS_COLOR.SELECT_SBC_COLOR";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[2] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
			
			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_code;
			MyOraDB.Parameter_Values[2] = arg_name;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		#endregion  

		#region 그리드 이벤트 처리



		#endregion 

		#region 컨트롤 이벤트 처리 

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
            fgrid_Color_DoubleClick(null, null);
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			string vfactory =ClassLib.ComVar.This_Factory;
			string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ").ToUpper();
			string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ").ToUpper();
			Search_Color(vfactory,vcode, vname); 

		}

//
//		private void btnSave_Click(object sender, System.EventArgs e)
//		{
//			if(MyOraDB.Save_Spread("PKG_SBC_COLOR.SAVE_SBC_COLOR", fgrid_Main) )
//			{
//				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ");
//				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
//				Search_Color(vcode, vname); 
//				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//			}
//		}

	

		private void txt_Color_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.numeric_Type(e);
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13)
			{
				string vfactory = ClassLib.ComVar.This_Factory;
				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ").ToUpper();
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ").ToUpper();
				Search_Color(vfactory, vcode, vname); 
			}

		}

		private void txt_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				string vfactory = ClassLib.ComVar.This_Factory;
				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ").ToUpper();
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ").ToUpper();
				Search_Color(vfactory, vcode, vname); 
			}
		}





         private void fgrid_Color_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //if (fgrid_Main.ActiveSheet.ActiveRowIndex<= _Rowfixed) return;

                int ir = fgrid_Color.Selection.r1;

                COM.ComVar.Parameter_PopUp = new string[2];

                COM.ComVar.Parameter_PopUp[0] = fgrid_Color[ir, (int)ClassLib.TBSBC_COLOR.IxCOLOR_CD].ToString();
                COM.ComVar.Parameter_PopUp[1] = fgrid_Color[ir, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].ToString();


                this.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Pop_Mcs_Color_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
		}
       

      

		private void Pop_Mcs_Color_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{

            this.Dispose();


            //try
            //{   
            //    //if (fgrid_Main.ActiveSheet.ActiveRowIndex<= _Rowfixed) return;

            //    int ir = fgrid_Color.Selection.r1;
				
            //    COM.ComVar.Parameter_PopUp = new string[2];

            //    COM.ComVar.Parameter_PopUp[0] = fgrid_Color[ir,(int)ClassLib.TBSBC_COLOR.IxCOLOR_CD].ToString();
            //    COM.ComVar.Parameter_PopUp[1] = fgrid_Color[ir, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].ToString();


            //    this.Dispose();
            //}
            //catch(Exception ex)
            //{
            //    ClassLib.ComFunction.User_Message(ex.Message, "Pop_Mcs_Color_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //} 
		}


		
		
		#endregion

  


	}
}

