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
	public class Pop_Color : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리 
		
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_SCode;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label btn_Search;
		private FarPoint.Win.Spread.SheetView fgrid_Main_Sheet1;
		private COM.SSP fgrid_Main;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label lbl_SFactory;
		private System.Windows.Forms.TextBox txt_Color_Name;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_Clear;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txt_Code;



		private bool _ExistCheckFlag = true;


		public Pop_Color()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form(); 


		}


		public Pop_Color(bool arg_exist_check_flag)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_ExistCheckFlag = arg_exist_check_flag;


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Color));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.lbl_SCode = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Clear = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Label();
            this.fgrid_Main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.fgrid_Main = new COM.SSP();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_SFactory = new System.Windows.Forms.Label();
            this.txt_Color_Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(34, 7);
            this.lbl_MainTitle.Size = new System.Drawing.Size(358, 22);
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
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.lbl_SCode);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 36);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txt_Code
            // 
            this.txt_Code.BackColor = System.Drawing.Color.White;
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Code.Location = new System.Drawing.Point(105, 10);
            this.txt_Code.MaxLength = 10;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(67, 21);
            this.txt_Code.TabIndex = 571;
            this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
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
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Name.Location = new System.Drawing.Point(173, 10);
            this.txt_Name.MaxLength = 120;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(182, 21);
            this.txt_Name.TabIndex = 160;
            this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.ImageIndex = 4;
            this.btn_Search.ImageList = this.img_MiniButton;
            this.btn_Search.Location = new System.Drawing.Point(356, 10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(21, 21);
            this.btn_Search.TabIndex = 158;
            this.btn_Search.Tag = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btn_Search, "Search");
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            this.img_MiniButton.Images.SetKeyName(2, "");
            this.img_MiniButton.Images.SetKeyName(3, "");
            this.img_MiniButton.Images.SetKeyName(4, "");
            this.img_MiniButton.Images.SetKeyName(5, "");
            // 
            // btn_Clear
            // 
            this.btn_Clear.ImageIndex = 2;
            this.btn_Clear.ImageList = this.img_MiniButton;
            this.btn_Clear.Location = new System.Drawing.Point(334, 10);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(21, 21);
            this.btn_Clear.TabIndex = 160;
            this.btn_Clear.Tag = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btn_Clear, "Clear");
            this.btn_Clear.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btn_Return
            // 
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_MiniButton;
            this.btn_Return.Location = new System.Drawing.Point(356, 10);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(21, 21);
            this.btn_Return.TabIndex = 159;
            this.btn_Return.Tag = "Return";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btn_Return, "Return");
            this.btn_Return.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // fgrid_Main_Sheet1
            // 
            this.fgrid_Main_Sheet1.SheetName = "Sheet1";
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.Location = new System.Drawing.Point(5, 71);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Sheets.Add(this.fgrid_Main_Sheet1);
            this.fgrid_Main.Size = new System.Drawing.Size(383, 226);
            this.fgrid_Main.TabIndex = 161;
            this.fgrid_Main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fgrid_Main_CellDoubleClick);
            // 
            // lbl_SFactory
            // 
            this.lbl_SFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SFactory.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_SFactory.ImageIndex = 0;
            this.lbl_SFactory.ImageList = this.img_Label;
            this.lbl_SFactory.Location = new System.Drawing.Point(4, 10);
            this.lbl_SFactory.Name = "lbl_SFactory";
            this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_SFactory.TabIndex = 38;
            this.lbl_SFactory.Text = "Result Color";
            this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Color_Name
            // 
            this.txt_Color_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Color_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Color_Name.Location = new System.Drawing.Point(105, 10);
            this.txt_Color_Name.Name = "txt_Color_Name";
            this.txt_Color_Name.Size = new System.Drawing.Size(227, 21);
            this.txt_Color_Name.TabIndex = 161;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_SFactory);
            this.groupBox2.Controls.Add(this.txt_Color_Name);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Return);
            this.groupBox2.Location = new System.Drawing.Point(5, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 36);
            this.groupBox2.TabIndex = 163;
            this.groupBox2.TabStop = false;
            // 
            // Pop_Color
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fgrid_Main);
            this.Name = "Pop_Color";
            this.Controls.SetChildIndex(this.fgrid_Main, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 변수

		public string _ColorName = "";

		#endregion

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Color Master";
				lbl_MainTitle.Text = "Color Master";
				ClassLib.ComFunction.SetLangDic(this);
			

				// 그리드 설정
				fgrid_Main.Set_Spread_Comm("SBC_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			 
		}

		/// <summary>
		/// Search_Color : 데이터 조회
		/// </summary>
		/// <param name="arg_code"></param>
		/// <param name="arg_name"></param>
		private void Search_Color(string arg_code,string arg_name)
		{
			DataTable dt_ret;

			try
			{
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor; 
				
				dt_ret = Form_BC_Color.Select_SBC_COLOR(arg_code, arg_name);
				Display_Grid(dt_ret,fgrid_Main);
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


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.SSP arg_fgrid)
		{
			arg_fgrid.Display_Grid(arg_dt) ;
		}
 


		#endregion

		#region 이벤트 처리

		#region 그리드 이벤트 처리

		private void fgrid_Main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{
				string sel_colname = "";

				if(e.ColumnHeader) return;
				 
				sel_colname = fgrid_Main.ActiveSheet.Cells[fgrid_Main.ActiveSheet.ActiveRowIndex, (int)ClassLib.TBSBC_COLOR.IxCOLOR_NAME].Value.ToString().Trim();

				if(txt_Color_Name.Text.Equals("") )
				{
					txt_Color_Name.Text = sel_colname;
				}
				else
				{
					txt_Color_Name.Text += "/" +  sel_colname;
				}
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion

		#region 컨트롤 이벤트 처리 

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

		private void txt_Color_Name_TextChanged(object sender, System.EventArgs e)
		{
			string vcode = " ";
			string vname = ClassLib.ComFunction.Empty_TextBox(txt_Color_Name, " ");
			Search_Color(vcode, vname);
		}


		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			try
			{
				bool check_exist = false;

				if(!txt_Color_Name.Text.Equals(""))
				{
					_ColorName = txt_Color_Name.Text; 
				

					// 중복 체크 처리 여부 설정
					// 채산에서 컬러코드 조합할때는 중복 체크 하지 않음
					if(_ExistCheckFlag)
					{
						// null : 신규 처리 가능, not null : 중복
						DataTable dt_ret = CHECK_COLOR_EXIST(_ColorName);

						if(dt_ret == null || dt_ret.Rows[0].ItemArray[0] == null || dt_ret.Rows[0].ItemArray[0].ToString().Trim().Equals(""))
						{
							this.Close(); 
						}
						else
						{
							txt_Color_Name.Text = "";
							_ColorName = "";

							string color_cd = dt_ret.Rows[0].ItemArray[0].ToString();
							string color_name = dt_ret.Rows[0].ItemArray[1].ToString();
							string message = "Duplicate color." + "\r\n\r\n" + "code : " + color_cd + "\r\n" + "name : " + color_name;
							ClassLib.ComFunction.User_Message(message);	
						}

					}
					else
					{
						this.Close(); 
					}




					
				}
				else
				{
					ClassLib.ComFunction.User_Message("Select Color Code"); 
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Return_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
		}

		private void btn_Clear_Click(object sender, System.EventArgs e)
		{
			txt_Color_Name.Text = "";
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{

			txt_Code.Text = txt_Code.Text.Trim();
			txt_Name.Text = txt_Name.Text.Trim();

			string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ");
			string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
			Search_Color(vcode, vname); 

		}


		private void txt_Color_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
			ClassLib.ComFunction.KeyEnter_Tab(e);

			if(e.KeyChar == (char)13)
			{

				txt_Code.Text = txt_Code.Text.Trim();
				txt_Name.Text = txt_Name.Text.Trim(); 

				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ");
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
				Search_Color(vcode, vname); 
			}

		}

		private void txt_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{

				txt_Code.Text = txt_Code.Text.Trim();
				txt_Name.Text = txt_Name.Text.Trim(); 

				string vcode = ClassLib.ComFunction.Empty_TextBox(txt_Code, " ");
				string vname = ClassLib.ComFunction.Empty_TextBox(txt_Name, " ");
				Search_Color(vcode, vname); 
			}
		}


		#endregion

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// CHECK_COLOR_EXIST : 컬러명 중복 체크
		/// </summary>
		private DataTable CHECK_COLOR_EXIST(string arg_colorname)
		{ 

			try
			{

				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;
				string exist_yn = "";
 
				MyOraDB.ReDim_Parameter(2);  

				MyOraDB.Process_Name = "PKG_SBC_COLOR.CHECK_COLOR_EXIST_RETURN";
  
				MyOraDB.Parameter_Name[0] = "ARG_COLOR_NAME"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
			 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 
			    
				MyOraDB.Parameter_Values[0] = arg_colorname; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) 
				{
					return null; 
				}
				else
				{
					return ds_ret.Tables[MyOraDB.Process_Name];
				}

			}
			catch
			{
				return null;
			}

		}
		
		#endregion																									
 
 

	}
}

