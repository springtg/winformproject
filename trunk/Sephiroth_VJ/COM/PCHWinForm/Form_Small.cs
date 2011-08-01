using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace COM.PCHWinForm
{
	/// <summary>
	/// Form1�� ���� ��� �����Դϴ�.
	/// </summary>
	public class Form_Small : System.Windows.Forms.Form
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
		public C1.Win.C1Command.C1Command tbtn_Append;
		public C1.Win.C1Command.C1CommandLink c1CommandLink5;
		public C1.Win.C1Command.C1Command tbtn_Insert;
		public C1.Win.C1Command.C1Command tbtn_Delete;
		public System.Windows.Forms.StatusBar stbar;
		public System.Windows.Forms.Label lbl_MainTitle;
		public C1.Win.C1Command.C1Command tbtn_Create;
		public C1.Win.C1Command.C1Command tbtn_Color;
		public C1.Win.C1Command.C1CommandLink c1CommandLink6;
		public C1.Win.C1Command.C1CommandLink c1CommandLink7;
		public C1.Win.C1Command.C1Command tbtn_Print;
		private C1.Win.C1Command.C1CommandLink c1CommandLink9;
		private System.Windows.Forms.Panel pnl_BackImage;
		private System.ComponentModel.IContainer components;

		public Form_Small()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Small));
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
			this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
			this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
			this.stbar = new System.Windows.Forms.StatusBar();
			this.pnl_BackImage = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
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
			this.lbl_MainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_MainTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(240)), ((System.Byte)(247)), ((System.Byte)(255)));
			this.lbl_MainTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MainTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_MainTitle.Location = new System.Drawing.Point(64, 26);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(728, 23);
			this.lbl_MainTitle.TabIndex = 24;
			this.lbl_MainTitle.Text = "title";
			this.lbl_MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.c1ToolBar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(206)), ((System.Byte)(240)));
			this.c1ToolBar1.ButtonLookVert = C1.Win.C1Command.ButtonLookFlags.Text;
			this.c1ToolBar1.ButtonWidth = 30;
			this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink1);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink2);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink3);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink5);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink6);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink7);
			this.c1ToolBar1.CommandLinks.Add(this.c1CommandLink9);
			this.c1ToolBar1.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar1.Location = new System.Drawing.Point(576, 5);
			this.c1ToolBar1.MinButtonSize = 38;
			this.c1ToolBar1.Movable = false;
			this.c1ToolBar1.Name = "c1ToolBar1";
			this.c1ToolBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.c1ToolBar1.Size = new System.Drawing.Size(210, 38);
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
			this.tbtn_New.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_New.Image")));
			this.tbtn_New.Name = "tbtn_New";
			this.tbtn_New.Text = "Clear";
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Search.Image")));
			this.tbtn_Search.Name = "tbtn_Search";
			this.tbtn_Search.Text = "Search";
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Save.Image")));
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
			this.tbtn_Insert.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Insert.Image")));
			this.tbtn_Insert.Name = "tbtn_Insert";
			this.tbtn_Insert.Text = "Insert Item";
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Delete.Image")));
			this.tbtn_Delete.Name = "tbtn_Delete";
			this.tbtn_Delete.Text = "Delete Item";
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Create.Image")));
			this.tbtn_Create.Name = "tbtn_Create";
			this.tbtn_Create.Text = "SOS";
			this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
			// 
			// tbtn_Color
			// 
			this.tbtn_Color.ImageIndex = 7;
			this.tbtn_Color.Name = "tbtn_Color";
			this.tbtn_Color.Text = "Set Color";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_Print.Image")));
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
			// c1CommandLink7
			// 
			this.c1CommandLink7.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink7.Command = this.tbtn_Print;
			// 
			// c1CommandLink9
			// 
			this.c1CommandLink9.ButtonLook = C1.Win.C1Command.ButtonLookFlags.Image;
			this.c1CommandLink9.Command = this.tbtn_Create;
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 544);
			this.stbar.Name = "stbar";
			this.stbar.ShowPanels = true;
			this.stbar.Size = new System.Drawing.Size(792, 22);
			this.stbar.TabIndex = 26;
			// 
			// pnl_BackImage
			// 
			this.pnl_BackImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BackImage.BackgroundImage")));
			this.pnl_BackImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BackImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_BackImage.Name = "pnl_BackImage";
			this.pnl_BackImage.Size = new System.Drawing.Size(792, 80);
			this.pnl_BackImage.TabIndex = 28;
			// 
			// Form_Small
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.stbar);
			this.Controls.Add(this.c1ToolBar1);
			this.Controls.Add(this.lbl_MainTitle);
			this.Controls.Add(this.pnl_BackImage);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_Small";
			this.Text = "Form_Small"; 
			this.Closed += new System.EventHandler(this.Form_Small_Closed);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
////			Pop_Menu_SOS pop_form = new Pop_Menu_SOS();
////			COM.ComVar.Parameter_PopUp = new string[] {COM.ComVar.This_Factory.ToString(),
////														  this.Name.ToString()
////													  };
////			pop_form.ShowDialog();




//            string factory = COM.ComVar.This_Factory;
//            string lang_cd = COM.ComVar.This_Lang;
//            string user_id = COM.ComVar.This_User;
//            string menu_pg = this.GetType().ToString();

//            COM.ComFunction.Save_SPC_MENU_BOOKMARK(factory, lang_cd, user_id, menu_pg);




		}
 

		private void Form_Small_Closed(object sender, System.EventArgs e)
		{
			//this.Dispose(true);
		}

		




	}
}
