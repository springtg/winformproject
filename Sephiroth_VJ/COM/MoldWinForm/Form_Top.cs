using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace COM.MoldWinForm
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>
	public class Form_Top : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ImageList img_Action;
		public System.Windows.Forms.ImageList img_Label;
		public System.Windows.Forms.ImageList img_Menu;
		public System.Windows.Forms.ImageList img_Button;
		public C1.Win.C1Command.C1ToolBar c1ToolBar1;
		public C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		public C1.Win.C1Command.C1CommandLink c1CommandLink1;
		public C1.Win.C1Command.C1Command tbtn_New;
		public C1.Win.C1Command.C1CommandLink c1CommandLink2;
		public C1.Win.C1Command.C1Command tbtn_Search;
		public C1.Win.C1Command.C1CommandLink c1CommandLink3;
		public C1.Win.C1Command.C1Command tbtn_Save;
		public C1.Win.C1Command.C1CommandLink c1CommandLink4;
		public C1.Win.C1Command.C1Command tbtn_Append;
		public C1.Win.C1Command.C1CommandLink c1CommandLink5;
		public C1.Win.C1Command.C1Command tbtn_Insert;
		public C1.Win.C1Command.C1Command tbtn_Delete;
		public System.Windows.Forms.StatusBar stbar;
		public System.Windows.Forms.Label lbl_MainTitle;
		public C1.Win.C1Command.C1Command tbtn_Create;
		public C1.Win.C1Command.C1CommandLink c1CommandLink8;
		public C1.Win.C1Command.C1Command tbtn_Color;
		public C1.Win.C1Command.C1CommandLink c1CommandLink6;
		public C1.Win.C1Command.C1CommandLink c1CommandLink7;
		public C1.Win.C1Command.C1Command tbtn_Print;
		private System.Windows.Forms.StatusBarPanel info_bar;
		private System.Windows.Forms.StatusBarPanel formname_bar;
		public System.Windows.Forms.ImageList image_List;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.ComponentModel.IContainer components;

		public Form_Top()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Top));
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.img_Label = new System.Windows.Forms.ImageList(this.components);
			this.img_Menu = new System.Windows.Forms.ImageList(this.components);
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.lbl_MainTitle = new System.Windows.Forms.Label();
			this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_New = new C1.Win.C1Command.C1Command();
			this.tbtn_Search = new C1.Win.C1Command.C1Command();
			this.tbtn_Save = new C1.Win.C1Command.C1Command();
			this.tbtn_Append = new C1.Win.C1Command.C1Command();
			this.tbtn_Insert = new C1.Win.C1Command.C1Command();
			this.tbtn_Delete = new C1.Win.C1Command.C1Command();
			this.tbtn_Create = new C1.Win.C1Command.C1Command();
			this.tbtn_Color = new C1.Win.C1Command.C1Command();
			this.tbtn_Print = new C1.Win.C1Command.C1Command();
			this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.info_bar = new System.Windows.Forms.StatusBarPanel();
			this.formname_bar = new System.Windows.Forms.StatusBarPanel();
			this.image_List = new System.Windows.Forms.ImageList(this.components);
			this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Label
			// 
			this.img_Label.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Label.ImageSize = new System.Drawing.Size(100, 21);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			this.img_Label.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Menu
			// 
			this.img_Menu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Menu.ImageSize = new System.Drawing.Size(38, 38);
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			this.img_Menu.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(206)), ((System.Byte)(240)));
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.BackColor = System.Drawing.Color.Transparent;
			this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_MainTitle.Location = new System.Drawing.Point(64, 26);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(312, 23);
			this.lbl_MainTitle.TabIndex = 24;
			this.lbl_MainTitle.Text = "title";
			this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.c1ToolBar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(206)), ((System.Byte)(240)));
			this.c1ToolBar1.ButtonWidth = 40;
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink3);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink4);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink5);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink6);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink8);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink7);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(690, 3);
			this.c1ToolBar1.MinButtonSize = 38;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.c1ToolBar1.Size = new System.Drawing.Size(320, 38);
			this.c1ToolBar1.Text = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_New);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
			this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
			this.c1CommandHolder1.ImageList = this.img_Menu;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(206)), ((System.Byte)(240)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_New
			// 
			this.tbtn_New.ImageIndex = 0;
			this.tbtn_New.Name = "tbtn_New";
			this.tbtn_New.Text = "Clear";
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.ImageIndex = 1;
			this.tbtn_Search.Name = "tbtn_Search";
			this.tbtn_Search.Text = "Search";
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.ImageIndex = 2;
			this.tbtn_Save.Name = "tbtn_Save";
			this.tbtn_Save.Text = "Save";
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.ImageIndex = 4;
			this.tbtn_Append.Name = "tbtn_Append";
			this.tbtn_Append.Text = "Append Item";
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.ImageIndex = 5;
			this.tbtn_Insert.Name = "tbtn_Insert";
			this.tbtn_Insert.Text = "Insert Item";
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.ImageIndex = 6;
			this.tbtn_Delete.Name = "tbtn_Delete";
			this.tbtn_Delete.Text = "Delete Item";
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.ImageIndex = 3;
			this.tbtn_Create.Name = "tbtn_Create";
			this.tbtn_Create.Text = "Create Default Columns List";
			// 
			// tbtn_Color
			// 
			this.tbtn_Color.ImageIndex = 7;
			this.tbtn_Color.Name = "tbtn_Color";
			this.tbtn_Color.Text = "Set Color";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.ImageIndex = 8;
			this.tbtn_Print.Name = "tbtn_Print";
			this.tbtn_Print.Text = "Print";
			// 
			// c1CommandLink1
			// 
			this.c1CommandLink1.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink1.Command = this.tbtn_New;
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink2.Command = this.tbtn_Search;
			// 
			// c1CommandLink3
			// 
			this.c1CommandLink3.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink3.Command = this.tbtn_Save;
			// 
			// c1CommandLink4
			// 
			this.c1CommandLink4.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink4.Command = this.tbtn_Append;
			// 
			// c1CommandLink5
			// 
			this.c1CommandLink5.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink5.Command = this.tbtn_Insert;
			// 
			// c1CommandLink6
			// 
			this.c1CommandLink6.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink6.Command = this.tbtn_Delete;
			// 
			// c1CommandLink8
			// 
			this.c1CommandLink8.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink8.Command = this.tbtn_Color;
			// 
			// c1CommandLink7
			// 
			this.c1CommandLink7.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink7.Command = this.tbtn_Print;
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 644);
			this.stbar.Name = "stbar";
			this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					 this.info_bar,
																					 this.formname_bar});
			this.stbar.ShowPanels = true;
			this.stbar.Size = new System.Drawing.Size(1016, 22);
			this.stbar.TabIndex = 26;
			// 
			// image_List
			// 
			this.image_List.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.image_List.ImageSize = new System.Drawing.Size(80, 23);
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			this.image_List.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_Top
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.stbar);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.lbl_MainTitle);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_Top";
			this.Text = "Form_Top";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_Top_Load);
			this.Closed += new System.EventHandler(this.Form_Top_Closed);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.info_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.formname_bar)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


//		/// <summary>
//		/// 해당 응용 프로그램의 주 진입점입니다.
//		/// </summary>
//		[STAThread]
//		static void Main() 
//		{
//			Application.Run(new Form_Top());
//		}




		private void Form_Top_Load(object sender, System.EventArgs e)
		{
		
			try
			{
 

				string factory = COM.ComVar.This_Factory;
				string lang_cd = COM.ComVar.This_Lang;
				string user_id = COM.ComVar.This_User_AD;
				string menu_pg = this.GetType().ToString();   
 

  
				DataTable dt_ret = COM.ComFunction.Select_SPC_MENU_TBTN(factory, lang_cd, user_id, menu_pg);

				if(dt_ret.Rows.Count == 0) return;

				bool tb_none_yn = Convert.ToBoolean( dt_ret.Rows[0].ItemArray[(int)COM.ComVar.Btn_Control.IxTB_NONE_YN].ToString() );
				bool tb_all_yn = Convert.ToBoolean( dt_ret.Rows[0].ItemArray[(int)COM.ComVar.Btn_Control.IxTB_ALL_YN].ToString() );
				bool tb_search_yn = Convert.ToBoolean( dt_ret.Rows[0].ItemArray[(int)COM.ComVar.Btn_Control.IxTB_SEARCH_YN].ToString() );
				bool tb_save_yn = Convert.ToBoolean( dt_ret.Rows[0].ItemArray[(int)COM.ComVar.Btn_Control.IxTB_SAVE_YN].ToString() );
				bool tb_print_yn = Convert.ToBoolean( dt_ret.Rows[0].ItemArray[(int)COM.ComVar.Btn_Control.IxTB_PRINT_YN].ToString() );

				
				
				if(tb_none_yn)
				{
					tbtn_New.Enabled     = false;
					tbtn_Search.Enabled  = false;
					tbtn_Save.Enabled    = false;
					tbtn_Append.Enabled  = false;
					tbtn_Insert.Enabled  = false;
					tbtn_Delete.Enabled  = false;
					tbtn_Color.Enabled   = false; 
					tbtn_Print.Enabled   = false;
				}
				else
				{
					tbtn_New.Enabled     = true;
					tbtn_Search.Enabled  = (tbtn_Search.Enabled  == false) ? false : tb_search_yn;
					tbtn_Save.Enabled    = (tbtn_Save.Enabled    == false) ? false : tb_save_yn;
					tbtn_Append.Enabled  = (tbtn_Delete.Enabled  == false) ? false : tb_save_yn;
					tbtn_Insert.Enabled  = (tbtn_Delete.Enabled  == false) ? false : tb_save_yn;
					tbtn_Delete.Enabled  = (tbtn_Delete.Enabled  == false) ? false : tb_save_yn;
					tbtn_Color.Enabled   = (tbtn_Color.Enabled == false) ? false : tb_save_yn;
					tbtn_Print.Enabled   = (tbtn_Print.Enabled   == false) ? false : tb_print_yn;

				}
			    

			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Form Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}


		

		
		private void Form_Top_Closed(object sender, System.EventArgs e)
		{
			 
			try
			{
				string menu_pg = this.GetType().ToString(); 
				COM.ComFunction.Delete_Window_Menu(this.ParentForm, menu_pg);
				
				//this.Dispose(true);

			}
			catch(Exception ex)
			{
				COM.ComFunction.User_Message(ex.Message, "Form Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}








	}
}
