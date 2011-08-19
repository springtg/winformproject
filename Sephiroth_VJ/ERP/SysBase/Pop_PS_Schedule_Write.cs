using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_Schedule_Write : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.Label lbl_contents;
		private System.Windows.Forms.TextBox txt_contents;
		private System.Windows.Forms.DateTimePicker dpick_Start;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dpick_Etart;
		private C1.Win.C1Command.C1ToolBar c1ToolBar1;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1CommandLink c1CommandLink1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_modify;
		private C1.Win.C1Command.C1CommandLink c1CommandLink2;
		private C1.Win.C1Command.C1Command tbtn_clear;


		#region 사용자 변수

		private string date = null;
		private COM.ComFunction comfunc = null;
		private Class_PS_Schedule schedule = new Class_PS_Schedule();
		private COM.OraDB oraDB = null;

		#endregion

		public Pop_PS_Schedule_Write(string arg_date)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			date = arg_date;
		}

		public Pop_PS_Schedule_Write()
		{
			InitializeComponent();

			string yyyy = DateTime.Now.Year.ToString();
			string MM =  schedule.Add_Zero(DateTime.Now.Month.ToString());
			string dd =  schedule.Add_Zero(DateTime.Now.Day.ToString());

			date = yyyy+MM+dd;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Schedule_Write));
			this.lbl_date = new System.Windows.Forms.Label();
			this.lbl_contents = new System.Windows.Forms.Label();
			this.txt_contents = new System.Windows.Forms.TextBox();
			this.dpick_Start = new System.Windows.Forms.DateTimePicker();
			this.dpick_Etart = new System.Windows.Forms.DateTimePicker();
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_modify = new C1.Win.C1Command.C1Command();
			this.tbtn_clear = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
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
			this.lbl_date.TabIndex = 71;
			this.lbl_date.Text = "선택날짜";
			this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_contents
			// 
			this.lbl_contents.ImageIndex = 0;
			this.lbl_contents.ImageList = this.img_Label;
			this.lbl_contents.Location = new System.Drawing.Point(8, 86);
			this.lbl_contents.Name = "lbl_contents";
			this.lbl_contents.Size = new System.Drawing.Size(100, 21);
			this.lbl_contents.TabIndex = 72;
			this.lbl_contents.Text = "일정";
			this.lbl_contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_contents
			// 
			this.txt_contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_contents.Location = new System.Drawing.Point(109, 86);
			this.txt_contents.Multiline = true;
			this.txt_contents.Name = "txt_contents";
			this.txt_contents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_contents.Size = new System.Drawing.Size(580, 370);
			this.txt_contents.TabIndex = 99;
			this.txt_contents.Text = "";
			// 
			// dpick_Start
			// 
			this.dpick_Start.CustomFormat = "";
			this.dpick_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Start.Location = new System.Drawing.Point(109, 64);
			this.dpick_Start.Name = "dpick_Start";
			this.dpick_Start.Size = new System.Drawing.Size(130, 21);
			this.dpick_Start.TabIndex = 100;
			// 
			// dpick_Etart
			// 
			this.dpick_Etart.CustomFormat = "";
			this.dpick_Etart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Etart.Location = new System.Drawing.Point(264, 64);
			this.dpick_Etart.Name = "dpick_Etart";
			this.dpick_Etart.Size = new System.Drawing.Size(130, 21);
			this.dpick_Etart.TabIndex = 101;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(629, 8);
			this.c1ToolBar1.MinButtonSize = 30;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.Size = new System.Drawing.Size(60, 30);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_modify);
			this.c1CommandHolder1.Commands.Add(this.tbtn_clear);
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
			// 
			// tbtn_clear
			// 
			this.tbtn_clear.ImageIndex = 12;
			this.tbtn_clear.Name = "tbtn_clear";
			this.tbtn_clear.Text = "Clear";
			this.tbtn_clear.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_clear_Click);
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
			this.c1CommandLink2.Command = this.tbtn_clear;
			// 
			// Pop_PS_Schedule_Write
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.dpick_Etart);
			this.Controls.Add(this.dpick_Start);
			this.Controls.Add(this.txt_contents);
			this.Controls.Add(this.lbl_contents);
			this.Controls.Add(this.lbl_date);
			this.Name = "Pop_PS_Schedule_Write";
			this.Text = "User Schedule";
			this.Load += new System.EventHandler(this.FormPC_Schedule_Write_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_date, 0);
			this.Controls.SetChildIndex(this.lbl_contents, 0);
			this.Controls.SetChildIndex(this.txt_contents, 0);
			this.Controls.SetChildIndex(this.dpick_Start, 0);
			this.Controls.SetChildIndex(this.dpick_Etart, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FormPC_Schedule_Write_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.lbl_MainTitle.Text = "Schedule Write";

			comfunc = new COM.ComFunction();
			oraDB = new COM.OraDB();
				
			dpick_Start.Text = comfunc.ConvertDate2Type(date);
			dpick_Etart.Text = comfunc.ConvertDate2Type(date);
		}

		private int DateCount()
		{
			if(dpick_Start.Text != dpick_Etart.Text)
			{
				string s1 = comfunc.ConvertDate2DbType(dpick_Start.Text);
				string s2 = comfunc.ConvertDate2DbType(dpick_Etart.Text);

				DateTime t1 = DateTime.ParseExact(s1, "yyyyMMdd",null);
				DateTime t2 = DateTime.ParseExact(s2, "yyyyMMdd", null);

 


				TimeSpan span = t2.Subtract(t1);

				string div = ".";
				string[] forlong = span.ToString().Split(div.ToCharArray());
				int aa = int.Parse(forlong[0]) + 1;
				return aa;
			}
			else
				return 1;
		}






		#region 이벤트
		private void tbtn_save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(txt_contents.Text.Length == 0)
			{
				MessageBox.Show("내용이 입력 되지 않았습니다.");
				txt_contents.Focus();
				return;
			}
			if(DateCount()<1)
			{
				MessageBox.Show("날짜 설정이 적절 하지 않습니다.");
				return;
			}

			string content = txt_contents.Text;

			DateTime target_date = DateTime.ParseExact(date, "yyyyMMdd",null);

			for(int i=0; i<DateCount(); i++)
			{

				string arg_date = comfunc.ConvertDate2DbType(target_date.AddDays(i).ToString());
				 
				string[] ArrayItem = new string[5];
				ArrayItem[0] = ClassLib.ComVar.This_Factory;
				ArrayItem[1] = ClassLib.ComVar.This_User;
				ArrayItem[2] = arg_date.Substring(0,8);
				ArrayItem[3] = content;
				ArrayItem[4] = ClassLib.ComVar.This_User;

				Insert_SPS_Schd(ArrayItem);

			}
			
			ClassLib.ComFunction.Data_Message("일정", ClassLib.ComVar.MgsEndSave);
		}
		
		private void tbtn_clear_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			dpick_Start.Text = comfunc.ConvertDate2Type(date);
			dpick_Etart.Text = comfunc.ConvertDate2Type(date);

			txt_contents.Text = "";
		}
		#endregion
		
		#region DB접속
		private void Insert_SPS_Schd(string[] arg_arrayitem)
		{
			string Proc_Name = "PKG_SPS_HOME.INSERT_SPS_SCHD";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_DATE";
			oraDB.Parameter_Name[3] = "ARG_CONTENT";
			oraDB.Parameter_Name[4] = "ARG_UPD_USER";

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Values[i] = arg_arrayitem[i];
			}

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}
		#endregion

		

	}
}

