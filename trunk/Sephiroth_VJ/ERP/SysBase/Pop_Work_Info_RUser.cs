using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace ERP.SysBase
{
	public class Pop_Work_Info_RUser : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_Clear;
		private System.Windows.Forms.Label btn_Return;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.ImageList img_MiniButton;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label lbl_User;
		private System.Windows.Forms.Label lbl_RtnUser;
		private System.Windows.Forms.TextBox txt_RtnUser;
		private System.Windows.Forms.TextBox txt_User;
		private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.ImageList img_Action;




		private string _UserList;

		public Pop_Work_Info_RUser(string arg_user_list)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_UserList = arg_user_list;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Work_Info_RUser));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_RtnUser = new System.Windows.Forms.Label();
            this.txt_RtnUser = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Label();
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Return = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.fgrid_Main = new COM.FSP();
            this.img_Action = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_RtnUser);
            this.groupBox2.Controls.Add(this.txt_RtnUser);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Return);
            this.groupBox2.Location = new System.Drawing.Point(6, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 36);
            this.groupBox2.TabIndex = 165;
            this.groupBox2.TabStop = false;
            // 
            // lbl_RtnUser
            // 
            this.lbl_RtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_RtnUser.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_RtnUser.ImageIndex = 0;
            this.lbl_RtnUser.ImageList = this.img_Label;
            this.lbl_RtnUser.Location = new System.Drawing.Point(4, 10);
            this.lbl_RtnUser.Name = "lbl_RtnUser";
            this.lbl_RtnUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_RtnUser.TabIndex = 38;
            this.lbl_RtnUser.Text = "Result User";
            this.lbl_RtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_RtnUser
            // 
            this.txt_RtnUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RtnUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RtnUser.Location = new System.Drawing.Point(105, 10);
            this.txt_RtnUser.Name = "txt_RtnUser";
            this.txt_RtnUser.ReadOnly = true;
            this.txt_RtnUser.Size = new System.Drawing.Size(227, 21);
            this.txt_RtnUser.TabIndex = 161;
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
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
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
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_User);
            this.groupBox1.Controls.Add(this.txt_User);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 36);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_User.ImageIndex = 0;
            this.lbl_User.ImageList = this.img_Label;
            this.lbl_User.Location = new System.Drawing.Point(4, 10);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(100, 21);
            this.lbl_User.TabIndex = 37;
            this.lbl_User.Text = "User";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_User
            // 
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_User.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_User.Location = new System.Drawing.Point(105, 10);
            this.txt_User.MaxLength = 10;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(250, 21);
            this.txt_User.TabIndex = 159;
            this.txt_User.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_User_KeyUp);
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.Location = new System.Drawing.Point(5, 72);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.DefaultSize = 18;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(383, 248);
            this.fgrid_Main.StyleInfo = resources.GetString("fgrid_Main.StyleInfo");
            this.fgrid_Main.TabIndex = 166;
            this.fgrid_Main.DoubleClick += new System.EventHandler(this.fgrid_Main_DoubleClick);
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // Pop_Work_Info_RUser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 360);
            this.Controls.Add(this.fgrid_Main);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Work_Info_RUser";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Work_Info_RUser_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.fgrid_Main, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Select Receive User";
				lbl_MainTitle.Text = "Select Receive User";
				ClassLib.ComFunction.SetLangDic(this);
			

				// 그리드 설정
				fgrid_Main.Set_Grid("SPS_WORK_INFO_RUSER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				fgrid_Main.Set_Action_Image(img_Action);

				txt_RtnUser.Text = _UserList; 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			 
		}



		/// <summary>
		/// Search_UserList : 
		/// </summary>
		private void Search_UserList()
		{

			DataTable dt_ret = ClassLib.ComFunction.Select_SPS_USER_ALL(txt_User.Text.Trim() );
			
			fgrid_Main.Display_Grid(dt_ret, false); 
			
			dt_ret.Dispose();





			//-------------------------------------------------------------------------
			// 선택되어져 있던 사용자 중복 체크
			//-------------------------------------------------------------------------
			if(fgrid_Main.Rows.Count < fgrid_Main.Rows.Fixed) return;


			string[] token = txt_RtnUser.Text.Trim().Split(',');
			int findrow = -1;

			for(int i = 0; i < token.Length; i++)
			{
				if(token[i].Equals("") ) continue;

				findrow = -1;
				findrow = fgrid_Main.FindRow(token[i], fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPS_WORKINFO_RUSER.IxUSER_ID, false, true, false);
				
				if(findrow == -1) continue;

				fgrid_Main[findrow, 0] = "Y";

			}
			//-------------------------------------------------------------------------



		}


		/// <summary>
		/// Select_UserList : 
		/// </summary>
		private void Select_UserList()
		{
			string sel_name = "";

			if(fgrid_Main.Rows.Count < fgrid_Main.Rows.Fixed) return;
				 

			//-------------------------------------------------------------------------------------------------------------
			// 사용자 선택 중복 체크
			//-------------------------------------------------------------------------------------------------------------
			if(fgrid_Main[fgrid_Main.Selection.r1, 0] != null && fgrid_Main[fgrid_Main.Selection.r1, 0].ToString() == "Y")
			{
				ClassLib.ComFunction.User_Message("Duplicate User", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
				return;
			}
			//-------------------------------------------------------------------------------------------------------------



			sel_name = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSPS_WORKINFO_RUSER.IxUSER_ID].ToString().Trim();

			if(txt_RtnUser.Text.Equals("") )
			{
				txt_RtnUser.Text = sel_name;
			}
			else
			{
				txt_RtnUser.Text += "," +  sel_name;
			}


			fgrid_Main[fgrid_Main.Selection.r1, 0] = "Y";

		}


		/// <summary>
		/// Clear_Return_User : 
		/// </summary>
		private void Clear_Return_User()
		{

			txt_RtnUser.Text = "";

			// 중복 체크 플래그 초기화
			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{
				fgrid_Main[i, 0] = "";
			}


		}


		/// <summary>
		/// Return_User : 
		/// </summary>
		private void Return_User()
		{ 
			 
			if(! txt_RtnUser.Text.Equals(""))
			{
				
				_UserList = txt_RtnUser.Text.Trim();

				this.Close();  
			}
			else
			{
				ClassLib.ComFunction.User_Message("Select User"); 
			}

		}
 

		#endregion

		#region 이벤트 처리

		private void txt_User_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{

			try
			{ 
				if(e.KeyCode != Keys.Enter) return;  
				
				Search_UserList();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_User_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{

			try
			{  

				Search_UserList(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_User_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void fgrid_Main_DoubleClick(object sender, System.EventArgs e)
		{
			try
			{
				Select_UserList(); 
				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_DoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void btn_Clear_Click(object sender, System.EventArgs e)
		{

			try
			{
				Clear_Return_User();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Return_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			try
			{
				Return_User();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Return_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void Pop_Work_Info_RUser_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] { _UserList };
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Work_Info_RUser_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
 

		}
		

		#endregion

		
 



	}
}

