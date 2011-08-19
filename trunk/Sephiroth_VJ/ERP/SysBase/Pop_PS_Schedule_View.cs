using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_Schedule_View : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.TextBox txt_contents;
		private System.Windows.Forms.Label lbl_contents;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_date;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink2;
		private C1.Win.C1Command.C1Command tbtn_modify;
		private C1.Win.C1Command.C1CommandLink c1CommandLink3;
		private C1.Win.C1Command.C1Command tbtn_delete;


		#region 사용자 변수

		private string date;
		private COM.ComFunction comfunc = null;
		private Class_PS_Schedule schedul = null;
		private COM.OraDB oraDB = null;
		private bool modify_mode = false;
		#endregion

		public Pop_PS_Schedule_View(string arg_date)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			date = arg_date;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Schedule_View));
			this.lbl_date = new System.Windows.Forms.Label();
			this.txt_date = new System.Windows.Forms.TextBox();
			this.txt_contents = new System.Windows.Forms.TextBox();
			this.lbl_contents = new System.Windows.Forms.Label();
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_modify = new C1.Win.C1Command.C1Command();
			this.tbtn_delete = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
			// lbl_date
			// 
			this.lbl_date.ImageIndex = 0;
			this.lbl_date.ImageList = this.img_Label;
			this.lbl_date.Location = new System.Drawing.Point(8, 64);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(100, 21);
			this.lbl_date.TabIndex = 225;
			this.lbl_date.Text = "선택날짜";
			this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_date
			// 
			this.txt_date.BackColor = System.Drawing.Color.White;
			this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_date.Location = new System.Drawing.Point(109, 64);
			this.txt_date.Name = "txt_date";
			this.txt_date.ReadOnly = true;
			this.txt_date.Size = new System.Drawing.Size(210, 21);
			this.txt_date.TabIndex = 228;
			this.txt_date.Text = "";
			// 
			// txt_contents
			// 
			this.txt_contents.BackColor = System.Drawing.Color.White;
			this.txt_contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_contents.Location = new System.Drawing.Point(109, 86);
			this.txt_contents.Multiline = true;
			this.txt_contents.Name = "txt_contents";
			this.txt_contents.ReadOnly = true;
			this.txt_contents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_contents.Size = new System.Drawing.Size(580, 370);
			this.txt_contents.TabIndex = 229;
			this.txt_contents.Text = "";
			// 
			// lbl_contents
			// 
			this.lbl_contents.ImageIndex = 0;
			this.lbl_contents.ImageList = this.img_Label;
			this.lbl_contents.Location = new System.Drawing.Point(8, 86);
			this.lbl_contents.Name = "lbl_contents";
			this.lbl_contents.Size = new System.Drawing.Size(100, 21);
			this.lbl_contents.TabIndex = 230;
			this.lbl_contents.Text = "일정";
			this.lbl_contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink3);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(599, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(90, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_modify);
			this.c1CommandHolder1.Commands.Add(this.tbtn_delete);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_save
			// 
			this.tbtn_save.ImageIndex = 6;
			this.tbtn_save.Name = "tbtn_save";
			this.tbtn_save.Text = "Save";
			this.tbtn_save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_save_Click);
			// 
			// tbtn_modify
			// 
			this.tbtn_modify.ImageIndex = 4;
			this.tbtn_modify.Name = "tbtn_modify";
			this.tbtn_modify.Text = "Modify";
			this.tbtn_modify.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_modify_Click);
			// 
			// tbtn_delete
			// 
			this.tbtn_delete.ImageIndex = 12;
			this.tbtn_delete.Name = "tbtn_delete";
			this.tbtn_delete.Text = "Delete";
			this.tbtn_delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_delete_Click);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.Command = this.tbtn_save;
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.Command = this.tbtn_modify;
			// 
			// c1CommandLink3
			// 
			this.c1CommandLink3.Command = this.tbtn_delete;
			// 
			// Pop_PS_Schedule_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.lbl_contents);
			this.Controls.Add(this.txt_contents);
			this.Controls.Add(this.txt_date);
			this.Controls.Add(this.lbl_date);
			this.Name = "Pop_PS_Schedule_View";
			this.Text = "User Schedule";
			this.Load += new System.EventHandler(this.Form_PS_Schedule_View_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_date, 0);
			this.Controls.SetChildIndex(this.txt_date, 0);
			this.Controls.SetChildIndex(this.txt_contents, 0);
			this.Controls.SetChildIndex(this.lbl_contents, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_Schedule_View_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.lbl_MainTitle.Text = "Schedule Check";

			comfunc = new COM.ComFunction();
			schedul = new Class_PS_Schedule();
			oraDB = new COM.OraDB();

			txt_date.Text = comfunc.ConvertDate2Type(date);
			txt_contents.Text = schedul.Date_Schedule(date);

			if(ClassLib.ComVar.This_Admin_YN == "N")
			{
				tbtn_save.Visible = false;
				tbtn_modify.Visible = false;
				tbtn_delete.Visible = false;

				c1ToolBar1.Visible = false;
			}
		}

		#region 이벤트		
		private void tbtn_modify_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			modify_mode = true;
			txt_contents.ReadOnly = false;
		}

		private void tbtn_save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(modify_mode)
			{
				if(txt_contents.Text.Length == 0)
				{
					MessageBox.Show("일정을 입력 하세요.");
					txt_contents.Focus();
					return;
				}

				Update_SPS_Schd_Date(date, txt_contents.Text);
				txt_contents.ReadOnly = true;
				modify_mode = false;
			}
		}

		private void tbtn_delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete);
			if(result == DialogResult.Yes)
			{
				schedul.Delete_SPS_Schd_Date(date);
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete);
				Close();
			}
		}

		#endregion

		#region DB접속

		private void Update_SPS_Schd_Date(string arg_date, string arg_content)
		{
			string Proc_Name = "PKG_SPS_HOME.UPDATE_SPS_SCHD_DATE";

		
			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_DATE";
			oraDB.Parameter_Name[3] = "ARG_CONTENT";
			oraDB.Parameter_Name[4] = "ARG_UPD_USER";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_date;
			oraDB.Parameter_Values[3] = arg_content;
			oraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}
		#endregion

		
	}
}

