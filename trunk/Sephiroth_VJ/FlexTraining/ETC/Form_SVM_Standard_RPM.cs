using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;

namespace FlexTraining.ETC
{
	public class Form_SVM_Standard_RPM : COM.TrainingWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox picb_BR;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.TextBox txt_PFC_Page;
		private System.Windows.Forms.Label lbl_PFC_Page;
		private System.Windows.Forms.TextBox txt_PFC;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_PFC;
		public System.Windows.Forms.Panel pnl_BottomImage;
		public System.Windows.Forms.PictureBox picb_DTR;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.PictureBox picb_DMR;
		public System.Windows.Forms.PictureBox picb_DMM;
		public System.Windows.Forms.PictureBox picb_DBR;
		public System.Windows.Forms.PictureBox picb_DBM;
		public System.Windows.Forms.PictureBox picb_DBL;
		public System.Windows.Forms.PictureBox picb_DML;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		public System.Windows.Forms.PictureBox picb_DTM;
		private C1.Win.C1List.C1Combo cmb_Layer;
		private C1.Win.C1List.C1Combo cmb_1Material;
		private C1.Win.C1List.C1Combo cmb_2Material;
		private C1.Win.C1List.C1Combo cmb_Machine;
		private C1.Win.C1List.C1Combo cmb_Radius;
		private C1.Win.C1List.C1Combo cmb_Curve;
		private C1.Win.C1List.C1Combo cmb_Stitch;
		private C1.Win.C1List.C1Combo cmb_Edge;
		private C1.Win.C1List.C1Combo cmb_Angle;
		private System.Windows.Forms.TextBox txt_Adjusting;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txt_Remark;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private C1.Win.C1List.C1Combo cmb_PFC_Page;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_PFC;
		private System.Windows.Forms.TextBox txt_Cycle_Time;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox1;
		private C1.Win.C1List.C1Combo cmb_WorkerClass;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_Operation;
		private System.Windows.Forms.TextBox txt_StitchingMC_No;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public Form_SVM_Standard_RPM()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();

		#endregion

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SVM_Standard_RPM));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_StitchingMC_No = new System.Windows.Forms.TextBox();
			this.txt_Operation = new System.Windows.Forms.TextBox();
			this.txt_Cycle_Time = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txt_Remark = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txt_Adjusting = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_BottomImage = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.cmb_Angle = new C1.Win.C1List.C1Combo();
			this.label19 = new System.Windows.Forms.Label();
			this.cmb_Stitch = new C1.Win.C1List.C1Combo();
			this.label16 = new System.Windows.Forms.Label();
			this.cmb_Edge = new C1.Win.C1List.C1Combo();
			this.label17 = new System.Windows.Forms.Label();
			this.cmb_Radius = new C1.Win.C1List.C1Combo();
			this.label14 = new System.Windows.Forms.Label();
			this.cmb_Curve = new C1.Win.C1List.C1Combo();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmb_2Material = new C1.Win.C1List.C1Combo();
			this.label13 = new System.Windows.Forms.Label();
			this.cmb_1Material = new C1.Win.C1List.C1Combo();
			this.label12 = new System.Windows.Forms.Label();
			this.cmb_Layer = new C1.Win.C1List.C1Combo();
			this.label11 = new System.Windows.Forms.Label();
			this.cmb_Machine = new C1.Win.C1List.C1Combo();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.picb_DTR = new System.Windows.Forms.PictureBox();
			this.picb_DTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.picb_DMR = new System.Windows.Forms.PictureBox();
			this.picb_DBR = new System.Windows.Forms.PictureBox();
			this.picb_DBM = new System.Windows.Forms.PictureBox();
			this.picb_DBL = new System.Windows.Forms.PictureBox();
			this.picb_DML = new System.Windows.Forms.PictureBox();
			this.picb_DMM = new System.Windows.Forms.PictureBox();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.cmb_WorkerClass = new C1.Win.C1List.C1Combo();
			this.cmb_PFC_Page = new C1.Win.C1List.C1Combo();
			this.cmb_PFC = new C1.Win.C1List.C1Combo();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_PFC_Page = new System.Windows.Forms.TextBox();
			this.lbl_PFC_Page = new System.Windows.Forms.Label();
			this.txt_PFC = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.lbl_PFC = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_BottomImage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Angle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Stitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Edge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Radius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Curve)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_2Material)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_1Material)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Layer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Machine)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_WorkerClass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PFC_Page)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PFC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel4);
			this.c1Sizer1.Controls.Add(this.panel2);
			this.c1Sizer1.Controls.Add(this.pnl_Search);
			this.c1Sizer1.Controls.Add(this.statusBar1);
			this.c1Sizer1.GridDefinition = "19.7368421052632:False:True;62.5:False:False;13.3223684210526:False:False;0.82236" +
				"8421052632:False:True;3.61842105263158:False:True;\t0.784313725490196:False:True;" +
				"98.1372549019608:False:False;1.07843137254902:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1020, 608);
			this.c1Sizer1.SplitterWidth = 0;
			this.c1Sizer1.TabIndex = 34;
			this.c1Sizer1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.txt_StitchingMC_No);
			this.panel4.Controls.Add(this.txt_Operation);
			this.panel4.Controls.Add(this.txt_Cycle_Time);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.txt_Remark);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt_Adjusting);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Location = new System.Drawing.Point(8, 500);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1001, 81);
			this.panel4.TabIndex = 47;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(373, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 21);
			this.label3.TabIndex = 619;
			this.label3.Text = "Stitching MC #";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 21);
			this.label1.TabIndex = 618;
			this.label1.Text = "Operation";
			// 
			// txt_StitchingMC_No
			// 
			this.txt_StitchingMC_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StitchingMC_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StitchingMC_No.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_StitchingMC_No.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_StitchingMC_No.Location = new System.Drawing.Point(505, 20);
			this.txt_StitchingMC_No.MaxLength = 20;
			this.txt_StitchingMC_No.Name = "txt_StitchingMC_No";
			this.txt_StitchingMC_No.Size = new System.Drawing.Size(132, 22);
			this.txt_StitchingMC_No.TabIndex = 606;
			this.txt_StitchingMC_No.Text = "";
			// 
			// txt_Operation
			// 
			this.txt_Operation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Operation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Operation.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Operation.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Operation.Location = new System.Drawing.Point(104, 20);
			this.txt_Operation.MaxLength = 20;
			this.txt_Operation.Name = "txt_Operation";
			this.txt_Operation.Size = new System.Drawing.Size(216, 22);
			this.txt_Operation.TabIndex = 605;
			this.txt_Operation.Text = "";
			// 
			// txt_Cycle_Time
			// 
			this.txt_Cycle_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Cycle_Time.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Cycle_Time.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Cycle_Time.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Cycle_Time.Location = new System.Drawing.Point(505, 44);
			this.txt_Cycle_Time.MaxLength = 20;
			this.txt_Cycle_Time.Name = "txt_Cycle_Time";
			this.txt_Cycle_Time.Size = new System.Drawing.Size(132, 22);
			this.txt_Cycle_Time.TabIndex = 608;
			this.txt_Cycle_Time.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(373, 44);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(72, 21);
			this.label22.TabIndex = 609;
			this.label22.Text = "Cycle Time";
			// 
			// txt_Remark
			// 
			this.txt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remark.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Remark.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Remark.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Remark.Location = new System.Drawing.Point(104, 44);
			this.txt_Remark.MaxLength = 20;
			this.txt_Remark.Name = "txt_Remark";
			this.txt_Remark.Size = new System.Drawing.Size(216, 22);
			this.txt_Remark.TabIndex = 607;
			this.txt_Remark.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(24, 44);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(72, 21);
			this.label21.TabIndex = 607;
			this.label21.Text = "Remark";
			// 
			// txt_Adjusting
			// 
			this.txt_Adjusting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Adjusting.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_Adjusting.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Adjusting.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_Adjusting.Location = new System.Drawing.Point(808, 20);
			this.txt_Adjusting.MaxLength = 20;
			this.txt_Adjusting.Name = "txt_Adjusting";
			this.txt_Adjusting.Size = new System.Drawing.Size(152, 22);
			this.txt_Adjusting.TabIndex = 609;
			this.txt_Adjusting.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(656, 20);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(152, 21);
			this.label20.TabIndex = 35;
			this.label20.Text = "==>> Adjusting RPM";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_BottomImage);
			this.panel2.Location = new System.Drawing.Point(8, 120);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1001, 380);
			this.panel2.TabIndex = 46;
			// 
			// pnl_BottomImage
			// 
			this.pnl_BottomImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BottomImage.Controls.Add(this.pictureBox1);
			this.pnl_BottomImage.Controls.Add(this.pictureBox14);
			this.pnl_BottomImage.Controls.Add(this.pictureBox13);
			this.pnl_BottomImage.Controls.Add(this.pictureBox12);
			this.pnl_BottomImage.Controls.Add(this.pictureBox5);
			this.pnl_BottomImage.Controls.Add(this.pictureBox10);
			this.pnl_BottomImage.Controls.Add(this.pictureBox9);
			this.pnl_BottomImage.Controls.Add(this.pictureBox8);
			this.pnl_BottomImage.Controls.Add(this.groupBox2);
			this.pnl_BottomImage.Controls.Add(this.cmb_Angle);
			this.pnl_BottomImage.Controls.Add(this.label19);
			this.pnl_BottomImage.Controls.Add(this.cmb_Stitch);
			this.pnl_BottomImage.Controls.Add(this.label16);
			this.pnl_BottomImage.Controls.Add(this.cmb_Edge);
			this.pnl_BottomImage.Controls.Add(this.label17);
			this.pnl_BottomImage.Controls.Add(this.cmb_Radius);
			this.pnl_BottomImage.Controls.Add(this.label14);
			this.pnl_BottomImage.Controls.Add(this.cmb_Curve);
			this.pnl_BottomImage.Controls.Add(this.label15);
			this.pnl_BottomImage.Controls.Add(this.groupBox7);
			this.pnl_BottomImage.Controls.Add(this.groupBox5);
			this.pnl_BottomImage.Controls.Add(this.groupBox4);
			this.pnl_BottomImage.Controls.Add(this.groupBox1);
			this.pnl_BottomImage.Controls.Add(this.cmb_2Material);
			this.pnl_BottomImage.Controls.Add(this.label13);
			this.pnl_BottomImage.Controls.Add(this.cmb_1Material);
			this.pnl_BottomImage.Controls.Add(this.label12);
			this.pnl_BottomImage.Controls.Add(this.cmb_Layer);
			this.pnl_BottomImage.Controls.Add(this.label11);
			this.pnl_BottomImage.Controls.Add(this.cmb_Machine);
			this.pnl_BottomImage.Controls.Add(this.label10);
			this.pnl_BottomImage.Controls.Add(this.label4);
			this.pnl_BottomImage.Controls.Add(this.label8);
			this.pnl_BottomImage.Controls.Add(this.label7);
			this.pnl_BottomImage.Controls.Add(this.label6);
			this.pnl_BottomImage.Controls.Add(this.label5);
			this.pnl_BottomImage.Controls.Add(this.picb_DTR);
			this.pnl_BottomImage.Controls.Add(this.picb_DTM);
			this.pnl_BottomImage.Controls.Add(this.lbl_SubTitle2);
			this.pnl_BottomImage.Controls.Add(this.picb_DMR);
			this.pnl_BottomImage.Controls.Add(this.picb_DBR);
			this.pnl_BottomImage.Controls.Add(this.picb_DBM);
			this.pnl_BottomImage.Controls.Add(this.picb_DBL);
			this.pnl_BottomImage.Controls.Add(this.picb_DML);
			this.pnl_BottomImage.Controls.Add(this.picb_DMM);
			this.pnl_BottomImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_BottomImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_BottomImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_BottomImage.Name = "pnl_BottomImage";
			this.pnl_BottomImage.Size = new System.Drawing.Size(1001, 380);
			this.pnl_BottomImage.TabIndex = 36;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(384, 310);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 614;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(504, 248);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(72, 48);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 613;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(424, 142);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(72, 39);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox13.TabIndex = 612;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(416, 81);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(80, 40);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 611;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(424, 23);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(80, 50);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 610;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(456, 328);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(64, 40);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 608;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(424, 224);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(72, 48);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 607;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(328, 200);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(88, 48);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 606;
			this.pictureBox8.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.pictureBox7);
			this.groupBox2.Location = new System.Drawing.Point(16, 72);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1048, 8);
			this.groupBox2.TabIndex = 160;
			this.groupBox2.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Location = new System.Drawing.Point(432, 18);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(72, 8);
			this.pictureBox7.TabIndex = 0;
			this.pictureBox7.TabStop = false;
			// 
			// cmb_Angle
			// 
			this.cmb_Angle.AddItemCols = 0;
			this.cmb_Angle.AddItemSeparator = ';';
			this.cmb_Angle.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Angle.AutoSize = false;
			this.cmb_Angle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Angle.Caption = "";
			this.cmb_Angle.CaptionHeight = 17;
			this.cmb_Angle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Angle.ColumnCaptionHeight = 18;
			this.cmb_Angle.ColumnFooterHeight = 18;
			this.cmb_Angle.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Angle.ContentHeight = 17;
			this.cmb_Angle.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Angle.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Angle.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Angle.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Angle.EditorHeight = 17;
			this.cmb_Angle.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Angle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Angle.GapHeight = 2;
			this.cmb_Angle.ItemHeight = 15;
			this.cmb_Angle.Location = new System.Drawing.Point(808, 270);
			this.cmb_Angle.MatchEntryTimeout = ((long)(2000));
			this.cmb_Angle.MaxDropDownItems = ((short)(5));
			this.cmb_Angle.MaxLength = 32767;
			this.cmb_Angle.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Angle.Name = "cmb_Angle";
			this.cmb_Angle.PartialRightColumn = false;
			this.cmb_Angle.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Angle.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Angle.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Angle.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Angle.Size = new System.Drawing.Size(152, 21);
			this.cmb_Angle.TabIndex = 602;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(528, 270);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(176, 24);
			this.label19.TabIndex = 175;
			this.label19.Text = "Minimum ANGLE";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Stitch
			// 
			this.cmb_Stitch.AddItemCols = 0;
			this.cmb_Stitch.AddItemSeparator = ';';
			this.cmb_Stitch.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Stitch.AutoSize = false;
			this.cmb_Stitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Stitch.Caption = "";
			this.cmb_Stitch.CaptionHeight = 17;
			this.cmb_Stitch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Stitch.ColumnCaptionHeight = 18;
			this.cmb_Stitch.ColumnFooterHeight = 18;
			this.cmb_Stitch.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Stitch.ContentHeight = 17;
			this.cmb_Stitch.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Stitch.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Stitch.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Stitch.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Stitch.EditorHeight = 17;
			this.cmb_Stitch.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Stitch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Stitch.GapHeight = 2;
			this.cmb_Stitch.ItemHeight = 15;
			this.cmb_Stitch.Location = new System.Drawing.Point(808, 342);
			this.cmb_Stitch.MatchEntryTimeout = ((long)(2000));
			this.cmb_Stitch.MaxDropDownItems = ((short)(5));
			this.cmb_Stitch.MaxLength = 32767;
			this.cmb_Stitch.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Stitch.Name = "cmb_Stitch";
			this.cmb_Stitch.PartialRightColumn = false;
			this.cmb_Stitch.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Stitch.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Stitch.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Stitch.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Stitch.Size = new System.Drawing.Size(152, 21);
			this.cmb_Stitch.TabIndex = 604;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(528, 342);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(176, 24);
			this.label16.TabIndex = 171;
			this.label16.Text = "Minimum STITCH";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Edge
			// 
			this.cmb_Edge.AddItemCols = 0;
			this.cmb_Edge.AddItemSeparator = ';';
			this.cmb_Edge.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Edge.AutoSize = false;
			this.cmb_Edge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Edge.Caption = "";
			this.cmb_Edge.CaptionHeight = 17;
			this.cmb_Edge.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Edge.ColumnCaptionHeight = 18;
			this.cmb_Edge.ColumnFooterHeight = 18;
			this.cmb_Edge.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Edge.ContentHeight = 17;
			this.cmb_Edge.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Edge.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Edge.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Edge.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Edge.EditorHeight = 17;
			this.cmb_Edge.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Edge.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Edge.GapHeight = 2;
			this.cmb_Edge.ItemHeight = 15;
			this.cmb_Edge.Location = new System.Drawing.Point(808, 312);
			this.cmb_Edge.MatchEntryTimeout = ((long)(2000));
			this.cmb_Edge.MaxDropDownItems = ((short)(5));
			this.cmb_Edge.MaxLength = 32767;
			this.cmb_Edge.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Edge.Name = "cmb_Edge";
			this.cmb_Edge.PartialRightColumn = false;
			this.cmb_Edge.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Edge.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Edge.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Edge.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Edge.Size = new System.Drawing.Size(152, 21);
			this.cmb_Edge.TabIndex = 603;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(528, 312);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(176, 24);
			this.label17.TabIndex = 169;
			this.label17.Text = "The number of EDGE";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Radius
			// 
			this.cmb_Radius.AddItemCols = 0;
			this.cmb_Radius.AddItemSeparator = ';';
			this.cmb_Radius.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Radius.AutoSize = false;
			this.cmb_Radius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Radius.Caption = "";
			this.cmb_Radius.CaptionHeight = 17;
			this.cmb_Radius.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Radius.ColumnCaptionHeight = 18;
			this.cmb_Radius.ColumnFooterHeight = 18;
			this.cmb_Radius.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Radius.ContentHeight = 17;
			this.cmb_Radius.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Radius.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Radius.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Radius.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Radius.EditorHeight = 17;
			this.cmb_Radius.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Radius.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Radius.GapHeight = 2;
			this.cmb_Radius.ItemHeight = 15;
			this.cmb_Radius.Location = new System.Drawing.Point(808, 238);
			this.cmb_Radius.MatchEntryTimeout = ((long)(2000));
			this.cmb_Radius.MaxDropDownItems = ((short)(5));
			this.cmb_Radius.MaxLength = 32767;
			this.cmb_Radius.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Radius.Name = "cmb_Radius";
			this.cmb_Radius.PartialRightColumn = false;
			this.cmb_Radius.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Radius.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Radius.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Radius.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Radius.Size = new System.Drawing.Size(152, 21);
			this.cmb_Radius.TabIndex = 601;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(536, 238);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(168, 24);
			this.label14.TabIndex = 167;
			this.label14.Text = "Minimum RADIUS";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Curve
			// 
			this.cmb_Curve.AddItemCols = 0;
			this.cmb_Curve.AddItemSeparator = ';';
			this.cmb_Curve.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Curve.AutoSize = false;
			this.cmb_Curve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Curve.Caption = "";
			this.cmb_Curve.CaptionHeight = 17;
			this.cmb_Curve.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Curve.ColumnCaptionHeight = 18;
			this.cmb_Curve.ColumnFooterHeight = 18;
			this.cmb_Curve.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Curve.ContentHeight = 17;
			this.cmb_Curve.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Curve.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Curve.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Curve.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Curve.EditorHeight = 17;
			this.cmb_Curve.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Curve.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Curve.GapHeight = 2;
			this.cmb_Curve.ItemHeight = 15;
			this.cmb_Curve.Location = new System.Drawing.Point(808, 206);
			this.cmb_Curve.MatchEntryTimeout = ((long)(2000));
			this.cmb_Curve.MaxDropDownItems = ((short)(5));
			this.cmb_Curve.MaxLength = 32767;
			this.cmb_Curve.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Curve.Name = "cmb_Curve";
			this.cmb_Curve.PartialRightColumn = false;
			this.cmb_Curve.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Curve.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Curve.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Curve.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Curve.Size = new System.Drawing.Size(152, 21);
			this.cmb_Curve.TabIndex = 600;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(536, 206);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(168, 24);
			this.label15.TabIndex = 165;
			this.label15.Text = "The number of CURVE";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Location = new System.Drawing.Point(16, 296);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(984, 8);
			this.groupBox7.TabIndex = 163;
			this.groupBox7.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox5.Controls.Add(this.groupBox6);
			this.groupBox5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.groupBox5.Location = new System.Drawing.Point(16, 188);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(976, 8);
			this.groupBox5.TabIndex = 162;
			this.groupBox5.TabStop = false;
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(792, 8);
			this.groupBox6.TabIndex = 163;
			this.groupBox6.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Location = new System.Drawing.Point(16, 120);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(984, 8);
			this.groupBox4.TabIndex = 161;
			this.groupBox4.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(16, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 8);
			this.groupBox1.TabIndex = 159;
			this.groupBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(784, 8);
			this.groupBox3.TabIndex = 160;
			this.groupBox3.TabStop = false;
			// 
			// cmb_2Material
			// 
			this.cmb_2Material.AddItemCols = 0;
			this.cmb_2Material.AddItemSeparator = ';';
			this.cmb_2Material.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_2Material.AutoSize = false;
			this.cmb_2Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_2Material.Caption = "";
			this.cmb_2Material.CaptionHeight = 17;
			this.cmb_2Material.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_2Material.ColumnCaptionHeight = 18;
			this.cmb_2Material.ColumnFooterHeight = 18;
			this.cmb_2Material.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_2Material.ContentHeight = 17;
			this.cmb_2Material.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_2Material.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_2Material.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_2Material.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_2Material.EditorHeight = 17;
			this.cmb_2Material.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_2Material.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_2Material.GapHeight = 2;
			this.cmb_2Material.ItemHeight = 15;
			this.cmb_2Material.Location = new System.Drawing.Point(808, 164);
			this.cmb_2Material.MatchEntryTimeout = ((long)(2000));
			this.cmb_2Material.MaxDropDownItems = ((short)(5));
			this.cmb_2Material.MaxLength = 32767;
			this.cmb_2Material.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_2Material.Name = "cmb_2Material";
			this.cmb_2Material.PartialRightColumn = false;
			this.cmb_2Material.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_2Material.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_2Material.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_2Material.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_2Material.Size = new System.Drawing.Size(152, 21);
			this.cmb_2Material.TabIndex = 509;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(584, 164);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(120, 24);
			this.label13.TabIndex = 157;
			this.label13.Text = "2nd - Material";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_1Material
			// 
			this.cmb_1Material.AddItemCols = 0;
			this.cmb_1Material.AddItemSeparator = ';';
			this.cmb_1Material.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_1Material.AutoSize = false;
			this.cmb_1Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_1Material.Caption = "";
			this.cmb_1Material.CaptionHeight = 17;
			this.cmb_1Material.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_1Material.ColumnCaptionHeight = 18;
			this.cmb_1Material.ColumnFooterHeight = 18;
			this.cmb_1Material.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_1Material.ContentHeight = 17;
			this.cmb_1Material.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_1Material.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_1Material.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_1Material.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_1Material.EditorHeight = 17;
			this.cmb_1Material.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_1Material.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_1Material.GapHeight = 2;
			this.cmb_1Material.ItemHeight = 15;
			this.cmb_1Material.Location = new System.Drawing.Point(808, 136);
			this.cmb_1Material.MatchEntryTimeout = ((long)(2000));
			this.cmb_1Material.MaxDropDownItems = ((short)(5));
			this.cmb_1Material.MaxLength = 32767;
			this.cmb_1Material.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_1Material.Name = "cmb_1Material";
			this.cmb_1Material.PartialRightColumn = false;
			this.cmb_1Material.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_1Material.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_1Material.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_1Material.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_1Material.Size = new System.Drawing.Size(152, 21);
			this.cmb_1Material.TabIndex = 508;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(584, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(120, 24);
			this.label12.TabIndex = 155;
			this.label12.Text = "1st - Material";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Layer
			// 
			this.cmb_Layer.AddItemCols = 0;
			this.cmb_Layer.AddItemSeparator = ';';
			this.cmb_Layer.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Layer.AutoSize = false;
			this.cmb_Layer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Layer.Caption = "";
			this.cmb_Layer.CaptionHeight = 17;
			this.cmb_Layer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Layer.ColumnCaptionHeight = 18;
			this.cmb_Layer.ColumnFooterHeight = 18;
			this.cmb_Layer.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Layer.ContentHeight = 17;
			this.cmb_Layer.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Layer.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Layer.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Layer.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Layer.EditorHeight = 17;
			this.cmb_Layer.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Layer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Layer.GapHeight = 2;
			this.cmb_Layer.ItemHeight = 15;
			this.cmb_Layer.Location = new System.Drawing.Point(808, 88);
			this.cmb_Layer.MatchEntryTimeout = ((long)(2000));
			this.cmb_Layer.MaxDropDownItems = ((short)(5));
			this.cmb_Layer.MaxLength = 32767;
			this.cmb_Layer.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Layer.Name = "cmb_Layer";
			this.cmb_Layer.PartialRightColumn = false;
			this.cmb_Layer.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Layer.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Layer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Layer.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Layer.Size = new System.Drawing.Size(152, 21);
			this.cmb_Layer.TabIndex = 507;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(528, 88);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(176, 24);
			this.label11.TabIndex = 153;
			this.label11.Text = "The number of LAYER";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_Machine
			// 
			this.cmb_Machine.AddItemCols = 0;
			this.cmb_Machine.AddItemSeparator = ';';
			this.cmb_Machine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Machine.AutoSize = false;
			this.cmb_Machine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Machine.Caption = "";
			this.cmb_Machine.CaptionHeight = 17;
			this.cmb_Machine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Machine.ColumnCaptionHeight = 18;
			this.cmb_Machine.ColumnFooterHeight = 18;
			this.cmb_Machine.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Machine.ContentHeight = 17;
			this.cmb_Machine.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Machine.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Machine.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Machine.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Machine.EditorHeight = 17;
			this.cmb_Machine.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Machine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Machine.GapHeight = 2;
			this.cmb_Machine.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_Machine.ItemHeight = 15;
			this.cmb_Machine.Location = new System.Drawing.Point(808, 48);
			this.cmb_Machine.MatchEntryTimeout = ((long)(2000));
			this.cmb_Machine.MaxDropDownItems = ((short)(5));
			this.cmb_Machine.MaxLength = 32767;
			this.cmb_Machine.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Machine.Name = "cmb_Machine";
			this.cmb_Machine.PartialRightColumn = false;
			this.cmb_Machine.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Machine.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Machine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Machine.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Machine.Size = new System.Drawing.Size(152, 21);
			this.cmb_Machine.TabIndex = 506;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Window;
			this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(648, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 24);
			this.label10.TabIndex = 42;
			this.label10.Text = "Machine";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 24);
			this.label4.TabIndex = 35;
			this.label4.Text = "* Kind of Machine";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(32, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 24);
			this.label8.TabIndex = 33;
			this.label8.Text = "* Straight Stitch";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(32, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 24);
			this.label7.TabIndex = 32;
			this.label7.Text = "* Curve Information";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 24);
			this.label6.TabIndex = 31;
			this.label6.Text = "* Material Specification";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(32, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 24);
			this.label5.TabIndex = 30;
			this.label5.Text = "* Layer";
			// 
			// picb_DTR
			// 
			this.picb_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTR.Image")));
			this.picb_DTR.Location = new System.Drawing.Point(985, 0);
			this.picb_DTR.Name = "picb_DTR";
			this.picb_DTR.Size = new System.Drawing.Size(16, 32);
			this.picb_DTR.TabIndex = 21;
			this.picb_DTR.TabStop = false;
			// 
			// picb_DTM
			// 
			this.picb_DTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DTM.Image")));
			this.picb_DTM.Location = new System.Drawing.Point(224, 0);
			this.picb_DTM.Name = "picb_DTM";
			this.picb_DTM.Size = new System.Drawing.Size(768, 39);
			this.picb_DTM.TabIndex = 0;
			this.picb_DTM.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "       Detail Selection";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_DMR
			// 
			this.picb_DMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMR.Image")));
			this.picb_DMR.Location = new System.Drawing.Point(985, 24);
			this.picb_DMR.Name = "picb_DMR";
			this.picb_DMR.Size = new System.Drawing.Size(15, 336);
			this.picb_DMR.TabIndex = 26;
			this.picb_DMR.TabStop = false;
			// 
			// picb_DBR
			// 
			this.picb_DBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBR.Image")));
			this.picb_DBR.Location = new System.Drawing.Point(985, 364);
			this.picb_DBR.Name = "picb_DBR";
			this.picb_DBR.Size = new System.Drawing.Size(16, 16);
			this.picb_DBR.TabIndex = 23;
			this.picb_DBR.TabStop = false;
			// 
			// picb_DBM
			// 
			this.picb_DBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBM.Image")));
			this.picb_DBM.Location = new System.Drawing.Point(144, 362);
			this.picb_DBM.Name = "picb_DBM";
			this.picb_DBM.Size = new System.Drawing.Size(841, 18);
			this.picb_DBM.TabIndex = 24;
			this.picb_DBM.TabStop = false;
			// 
			// picb_DBL
			// 
			this.picb_DBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_DBL.Image")));
			this.picb_DBL.Location = new System.Drawing.Point(0, 360);
			this.picb_DBL.Name = "picb_DBL";
			this.picb_DBL.Size = new System.Drawing.Size(168, 20);
			this.picb_DBL.TabIndex = 22;
			this.picb_DBL.TabStop = false;
			// 
			// picb_DML
			// 
			this.picb_DML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_DML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DML.Image = ((System.Drawing.Image)(resources.GetObject("picb_DML.Image")));
			this.picb_DML.Location = new System.Drawing.Point(0, 24);
			this.picb_DML.Name = "picb_DML";
			this.picb_DML.Size = new System.Drawing.Size(168, 340);
			this.picb_DML.TabIndex = 25;
			this.picb_DML.TabStop = false;
			// 
			// picb_DMM
			// 
			this.picb_DMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_DMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_DMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_DMM.Image")));
			this.picb_DMM.Location = new System.Drawing.Point(160, 24);
			this.picb_DMM.Name = "picb_DMM";
			this.picb_DMM.Size = new System.Drawing.Size(840, 340);
			this.picb_DMM.TabIndex = 27;
			this.picb_DMM.TabStop = false;
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.panel3);
			this.pnl_Search.DockPadding.All = 7;
			this.pnl_Search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Search.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.pnl_Search.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1020, 120);
			this.pnl_Search.TabIndex = 45;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.cmb_WorkerClass);
			this.panel3.Controls.Add(this.cmb_PFC_Page);
			this.panel3.Controls.Add(this.cmb_PFC);
			this.panel3.Controls.Add(this.cmb_StyleCd);
			this.panel3.Controls.Add(this.txt_StyleCd);
			this.panel3.Controls.Add(this.txt_PFC_Page);
			this.panel3.Controls.Add(this.lbl_PFC_Page);
			this.panel3.Controls.Add(this.txt_PFC);
			this.panel3.Controls.Add(this.lbl_Style);
			this.panel3.Controls.Add(this.picb_BR);
			this.panel3.Controls.Add(this.lbl_PFC);
			this.panel3.Controls.Add(this.cmb_Factory);
			this.panel3.Controls.Add(this.lbl_factory);
			this.panel3.Controls.Add(this.picb_MR);
			this.panel3.Controls.Add(this.picb_TM);
			this.panel3.Controls.Add(this.lbl_SubTitle1);
			this.panel3.Controls.Add(this.picb_TR);
			this.panel3.Controls.Add(this.picb_BM);
			this.panel3.Controls.Add(this.picb_BL);
			this.panel3.Controls.Add(this.picb_ML);
			this.panel3.Controls.Add(this.pictureBox6);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(7, 7);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1006, 106);
			this.panel3.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ImageIndex = 0;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(752, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 614;
			this.label9.Text = "Worker Class";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_WorkerClass
			// 
			this.cmb_WorkerClass.AddItemCols = 0;
			this.cmb_WorkerClass.AddItemSeparator = ';';
			this.cmb_WorkerClass.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_WorkerClass.AutoSize = false;
			this.cmb_WorkerClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_WorkerClass.Caption = "";
			this.cmb_WorkerClass.CaptionHeight = 17;
			this.cmb_WorkerClass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_WorkerClass.ColumnCaptionHeight = 18;
			this.cmb_WorkerClass.ColumnFooterHeight = 18;
			this.cmb_WorkerClass.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_WorkerClass.ContentHeight = 17;
			this.cmb_WorkerClass.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_WorkerClass.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_WorkerClass.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_WorkerClass.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_WorkerClass.EditorHeight = 17;
			this.cmb_WorkerClass.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_WorkerClass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_WorkerClass.GapHeight = 2;
			this.cmb_WorkerClass.ItemHeight = 15;
			this.cmb_WorkerClass.Location = new System.Drawing.Point(853, 40);
			this.cmb_WorkerClass.MatchEntryTimeout = ((long)(2000));
			this.cmb_WorkerClass.MaxDropDownItems = ((short)(5));
			this.cmb_WorkerClass.MaxLength = 32767;
			this.cmb_WorkerClass.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_WorkerClass.Name = "cmb_WorkerClass";
			this.cmb_WorkerClass.PartialRightColumn = false;
			this.cmb_WorkerClass.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_WorkerClass.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_WorkerClass.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_WorkerClass.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_WorkerClass.Size = new System.Drawing.Size(131, 21);
			this.cmb_WorkerClass.TabIndex = 505;
			// 
			// cmb_PFC_Page
			// 
			this.cmb_PFC_Page.AddItemCols = 0;
			this.cmb_PFC_Page.AddItemSeparator = ';';
			this.cmb_PFC_Page.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_PFC_Page.AutoSize = false;
			this.cmb_PFC_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_PFC_Page.Caption = "";
			this.cmb_PFC_Page.CaptionHeight = 17;
			this.cmb_PFC_Page.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_PFC_Page.ColumnCaptionHeight = 18;
			this.cmb_PFC_Page.ColumnFooterHeight = 18;
			this.cmb_PFC_Page.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_PFC_Page.ContentHeight = 18;
			this.cmb_PFC_Page.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_PFC_Page.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_PFC_Page.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PFC_Page.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_PFC_Page.EditorHeight = 18;
			this.cmb_PFC_Page.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_PFC_Page.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PFC_Page.GapHeight = 2;
			this.cmb_PFC_Page.ItemHeight = 15;
			this.cmb_PFC_Page.Location = new System.Drawing.Point(590, 40);
			this.cmb_PFC_Page.MatchEntryTimeout = ((long)(2000));
			this.cmb_PFC_Page.MaxDropDownItems = ((short)(5));
			this.cmb_PFC_Page.MaxLength = 32767;
			this.cmb_PFC_Page.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_PFC_Page.Name = "cmb_PFC_Page";
			this.cmb_PFC_Page.PartialRightColumn = false;
			this.cmb_PFC_Page.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_PFC_Page.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_PFC_Page.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_PFC_Page.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_PFC_Page.Size = new System.Drawing.Size(130, 22);
			this.cmb_PFC_Page.TabIndex = 611;
			this.cmb_PFC_Page.SelectedValueChanged += new System.EventHandler(this.cmb_PFC_Page_SelectedValueChanged);
			// 
			// cmb_PFC
			// 
			this.cmb_PFC.AddItemCols = 0;
			this.cmb_PFC.AddItemSeparator = ';';
			this.cmb_PFC.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_PFC.AutoSize = false;
			this.cmb_PFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_PFC.Caption = "";
			this.cmb_PFC.CaptionHeight = 17;
			this.cmb_PFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_PFC.ColumnCaptionHeight = 18;
			this.cmb_PFC.ColumnFooterHeight = 18;
			this.cmb_PFC.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_PFC.ContentHeight = 18;
			this.cmb_PFC.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_PFC.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_PFC.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PFC.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_PFC.EditorHeight = 18;
			this.cmb_PFC.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_PFC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PFC.GapHeight = 2;
			this.cmb_PFC.ItemHeight = 15;
			this.cmb_PFC.Location = new System.Drawing.Point(590, 63);
			this.cmb_PFC.MatchEntryTimeout = ((long)(2000));
			this.cmb_PFC.MaxDropDownItems = ((short)(5));
			this.cmb_PFC.MaxLength = 32767;
			this.cmb_PFC.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_PFC.Name = "cmb_PFC";
			this.cmb_PFC.PartialRightColumn = false;
			this.cmb_PFC.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_PFC.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_PFC.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_PFC.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_PFC.Size = new System.Drawing.Size(130, 22);
			this.cmb_PFC.TabIndex = 610;
			this.cmb_PFC.TextChanged += new System.EventHandler(this.cmb_PFC_TextChanged);
			this.cmb_PFC.SelectedValueChanged += new System.EventHandler(this.cmb_PFC_SelectedValueChanged);
			// 
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_StyleCd.AutoSize = false;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 18;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 18;
			this.cmb_StyleCd.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(209, 62);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(183, 22);
			this.cmb_StyleCd.TabIndex = 502;
			this.cmb_StyleCd.TextChanged += new System.EventHandler(this.cmb_StyleCd_TextChanged);
			this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_StyleCd.Location = new System.Drawing.Point(109, 62);
			this.txt_StyleCd.MaxLength = 9;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(99, 22);
			this.txt_StyleCd.TabIndex = 501;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// txt_PFC_Page
			// 
			this.txt_PFC_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PFC_Page.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_PFC_Page.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_PFC_Page.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_PFC_Page.Location = new System.Drawing.Point(525, 40);
			this.txt_PFC_Page.MaxLength = 20;
			this.txt_PFC_Page.Name = "txt_PFC_Page";
			this.txt_PFC_Page.Size = new System.Drawing.Size(64, 22);
			this.txt_PFC_Page.TabIndex = 503;
			this.txt_PFC_Page.Text = "";
			this.txt_PFC_Page.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PFC_Page_KeyUp);
			// 
			// lbl_PFC_Page
			// 
			this.lbl_PFC_Page.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PFC_Page.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PFC_Page.ImageIndex = 0;
			this.lbl_PFC_Page.ImageList = this.img_Label;
			this.lbl_PFC_Page.Location = new System.Drawing.Point(424, 40);
			this.lbl_PFC_Page.Name = "lbl_PFC_Page";
			this.lbl_PFC_Page.Size = new System.Drawing.Size(100, 21);
			this.lbl_PFC_Page.TabIndex = 596;
			this.lbl_PFC_Page.Text = "PFC Page #";
			this.lbl_PFC_Page.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_PFC
			// 
			this.txt_PFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_PFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_PFC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_PFC.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_PFC.Location = new System.Drawing.Point(525, 63);
			this.txt_PFC.MaxLength = 20;
			this.txt_PFC.Name = "txt_PFC";
			this.txt_PFC.Size = new System.Drawing.Size(64, 22);
			this.txt_PFC.TabIndex = 504;
			this.txt_PFC.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(8, 63);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 592;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 91);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(13, 15);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// lbl_PFC
			// 
			this.lbl_PFC.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PFC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PFC.ImageIndex = 0;
			this.lbl_PFC.ImageList = this.img_Label;
			this.lbl_PFC.Location = new System.Drawing.Point(424, 63);
			this.lbl_PFC.Name = "lbl_PFC";
			this.lbl_PFC.Size = new System.Drawing.Size(100, 21);
			this.lbl_PFC.TabIndex = 160;
			this.lbl_PFC.Text = "PFC#";
			this.lbl_PFC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.AutoSize = false;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(283, 21);
			this.cmb_Factory.TabIndex = 500;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 152;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(905, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 68);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(771, 28);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "         Search ";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(990, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(24, 67);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(123, 90);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(870, 17);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 91);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(144, 19);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 22);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(144, 75);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(137, 22);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(904, 68);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(137, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 22);
			this.textBox1.TabIndex = 145;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(392, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 21);
			this.label2.TabIndex = 155;
			this.label2.Text = "Training";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.statusBar1.Location = new System.Drawing.Point(0, 120);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.statusBarPanel1,
																						  this.statusBarPanel2});
			this.statusBar1.Size = new System.Drawing.Size(1020, 488);
			this.statusBar1.TabIndex = 43;
			// 
			// Form_SVM_Standard_RPM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_SVM_Standard_RPM";
			this.Load += new System.EventHandler(this.Form_SVM_Standard_RPM_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_BottomImage.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Angle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Stitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Edge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Radius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Curve)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_2Material)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_1Material)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Layer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Machine)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_WorkerClass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PFC_Page)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PFC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_SVM_Standard_RPM_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Standard RPM Computation ";
			this.Text		   = "Standard RPM Computation ";
			
			DataTable vDt;
			
			//=========== Set Combobox: Begin =================================

			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue    = ClassLib.ComVar.This_Factory;	

			// cmb_com_code Set
			vDt = Select_COM_Code("SVM02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Machine, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Machine.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM03");
			COM.ComCtl.Set_ComboList(vDt, cmb_Layer, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Layer.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM04");
			COM.ComCtl.Set_ComboList(vDt, cmb_1Material, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_1Material.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM05");
			COM.ComCtl.Set_ComboList(vDt, cmb_2Material, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_2Material.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM06");
			COM.ComCtl.Set_ComboList(vDt, cmb_Curve, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Curve.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM07");
			COM.ComCtl.Set_ComboList(vDt, cmb_Radius, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Radius.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM08");
			COM.ComCtl.Set_ComboList(vDt, cmb_Angle, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Angle.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM09");
			COM.ComCtl.Set_ComboList(vDt, cmb_Edge, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Edge.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM10");
			COM.ComCtl.Set_ComboList(vDt, cmb_Stitch, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_Stitch.SelectedIndex = 0;

			vDt = Select_COM_Code("SVM11");
			COM.ComCtl.Set_ComboList(vDt, cmb_WorkerClass, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name);
			cmb_WorkerClass.SelectedIndex = 0;

			//=========== Set Combobox: End =================================

		}

		private DataTable Select_COM_Code(string arg_com_code)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SCM_CODE.SELECT_COM_FILTER_CODE_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[1] = arg_com_code;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SVM_STITCHING_RPM.SELECT_SVM_STITCHING_RPM";

				DataTable vDt = SELECT_SVM_STITCHING_RPM(vProcedure);

				Clear_Fields();
				if (vDt.Rows.Count > 0)
				{
					Display_Fields(vDt);

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
				{
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_SVM_STITCHING_RPM(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 2]  = "ARG_PFC_PAGE";
			MyOraDB.Parameter_Name[ 3]  = "ARG_PFC";
			MyOraDB.Parameter_Name[ 4]  = "ARG_WORKER_CLASS";
			MyOraDB.Parameter_Name[ 5]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_TextBox(txt_PFC_Page, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txt_PFC, "");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_Combo(cmb_WorkerClass, "");
			MyOraDB.Parameter_Values[ 5]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Clear_Fields()
		{
			//txt_PFC.Text = "";
			//txt_PFC_Page.Text = "";
			
			txt_Operation.Text = "";
			txt_StitchingMC_No.Text = "";
			cmb_Machine.SelectedIndex = 0;
			cmb_Layer.SelectedIndex = 0;
			cmb_1Material.SelectedIndex = 0;
			cmb_2Material.SelectedIndex = 0;
			cmb_Curve.SelectedIndex = 0;
			cmb_Radius.SelectedIndex = 0;
			cmb_Angle.SelectedIndex = 0;
			cmb_Edge.SelectedIndex = 0;
			cmb_Stitch.SelectedIndex = 0;
			cmb_WorkerClass.SelectedIndex = 0;
			txt_Adjusting.Text = "";
			txt_Remark.Text = "";
			txt_Cycle_Time.Text  = "";

		}

		private void Display_Fields(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;
			string [] arg_Return = new string[19];;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				for (int iCol = 0 ; iCol < arg_dt.Columns.Count ; iCol++)
				{
					arg_Return[iCol] = arg_dt.Rows[iRow].ItemArray[iCol].ToString() ;
				}
			}

//			FACTORY, STYLE_CD, PFC, PFC_PAGE, OPERATION, STITCH_MC, RPM_MC_KIND_CD, 
//            RPM_LAYER_NO_CD, RPM_ITEM_KIND1_CD, RPM_ITEM_KIND2_CD, RPM_CURVE_NO_CD, 
//            RPM_RADIUS_MIN_CD, RPM_ANGLE_MIN_CD, RPM_EDGE_NO_CD, RPM_STITCH_MIN_CD, 
//            RPM_WORKER_CLASS_CD, RPM_ADJUSTING, REMARK1 

			txt_PFC_Page.Text = arg_Return[2];
			txt_PFC.Text = arg_Return[3];
			txt_Operation.Text = arg_Return[4];
			txt_StitchingMC_No.Text = arg_Return[5];
			cmb_Machine.SelectedValue  = arg_Return[6];
			cmb_Layer.SelectedValue = arg_Return[7];
			cmb_1Material.SelectedValue = arg_Return[8];
			cmb_2Material.SelectedValue = arg_Return[9];
			cmb_Curve.SelectedValue = arg_Return[10];
			cmb_Radius.SelectedValue = arg_Return[11];
			cmb_Angle.SelectedValue = arg_Return[12];
			cmb_Edge.SelectedValue = arg_Return[13];
			cmb_Stitch.SelectedValue = arg_Return[14];
			cmb_WorkerClass.SelectedValue = arg_Return[15];
			txt_Adjusting.Text = arg_Return[16];
			txt_Remark.Text = arg_Return[17];
			txt_Cycle_Time.Text = arg_Return[18];
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save the changes you made?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess("");
					
				}
			}		
		}

		private bool Validate_Check()
		{
			bool b = true;
			
			if (cmb_Factory.SelectedValue.ToString() == "" ||
				txt_StyleCd.Text.ToString () == "" ||
				cmb_Machine.SelectedValue.ToString () == "" ||
				cmb_Layer.SelectedValue.ToString () == "" ||
				cmb_1Material.SelectedValue.ToString () == "" ||
				cmb_2Material.SelectedValue.ToString() == "" ||
				cmb_Curve.SelectedValue.ToString() == "" ||
				cmb_Radius.SelectedValue.ToString() == "" ||
				cmb_Angle.SelectedValue.ToString() == "" ||
				cmb_Edge.SelectedValue.ToString() == "" ||
				cmb_Stitch.SelectedValue.ToString() == "" ||
				cmb_WorkerClass.SelectedValue.ToString () == ""
				)	
			{
				b = false;
			}

			return b;
		}

		private void Tbtn_SaveProcess(string arg_Division)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_STITCHING_RPM(true, arg_Division))
				{
					DataTable dt_ret = Select_PFC_NUMBER (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , ""), ClassLib.ComFunction.Empty_TextBox(txt_PFC_Page , "") );
					COM.ComCtl.Set_ComboList(dt_ret, cmb_PFC, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
					cmb_PFC.SelectedValue = txt_PFC.Text;
					cmb_PFC_Page.SelectedValue = txt_PFC_Page.Text;
					this.Tbtn_SearchProcess();
					MessageBox.Show("Save Completed","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_STITCHING_RPM(bool doExecute, string arg_Division)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 20;

				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SVM_STITCHING_RPM.SAVE_SVM_STITCHING_RPM";

				// FACTORY, OBS_ID, STYLE_CD, LINE_CD, CHECK_ITEM, 
				// SEASON, TD_CODE, FSR_DATE, D_DATE, FINISH_DATE, 
				// ACTUAL_DATE, PIC1, PIC2, PIC3, PIC4, REMARK1, REMARK2, REMARK3, UPD_USER, UPD_YMD

				//02.ARGURMENT NAME

				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";             
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";              
				MyOraDB.Parameter_Name[ 2] = "ARG_STYLE_CD";             
				MyOraDB.Parameter_Name[ 3] = "ARG_PFC_PAGE";             
				MyOraDB.Parameter_Name[ 4] = "ARG_PFC";                  
				MyOraDB.Parameter_Name[ 5] = "ARG_OPERATION";            
				MyOraDB.Parameter_Name[ 6] = "ARG_STITCH_MC";            
				MyOraDB.Parameter_Name[ 7] = "ARG_RPM_MC_KIND_CD";       
				MyOraDB.Parameter_Name[ 8] = "ARG_RPM_LAYER_NO_CD";      
				MyOraDB.Parameter_Name[ 9] = "ARG_RPM_ITEM_KIND1_CD";    
				MyOraDB.Parameter_Name[ 10] = "ARG_RPM_ITEM_KIND2_CD";    
				MyOraDB.Parameter_Name[ 11] = "ARG_RPM_CURVE_NO_CD";      
				MyOraDB.Parameter_Name[ 12] = "ARG_RPM_RADIUS_MIN_CD";    
				MyOraDB.Parameter_Name[ 13] = "ARG_RPM_ANGLE_MIN_CD";     
				MyOraDB.Parameter_Name[ 14] = "ARG_RPM_EDGE_NO_CD";       
				MyOraDB.Parameter_Name[ 15] = "ARG_RPM_STITCH_MIN_CD";    
				MyOraDB.Parameter_Name[ 16] = "ARG_RPM_WORKER_CLASS_CD";  
				MyOraDB.Parameter_Name[ 17] = "ARG_REMARK1";              
				MyOraDB.Parameter_Name[ 18] = "ARG_CYCLE";              
				MyOraDB.Parameter_Name[ 19] = "ARG_UPD_USER";             

				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				MyOraDB.Parameter_Values  = new string[iCount];

				MyOraDB.Parameter_Values[para_ct+0 ]  = arg_Division;
				MyOraDB.Parameter_Values[para_ct+1 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				MyOraDB.Parameter_Values[para_ct+2 ]  = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , "");
				MyOraDB.Parameter_Values[para_ct+3 ]  = ClassLib.ComFunction.Empty_TextBox(txt_PFC_Page, "");
				MyOraDB.Parameter_Values[para_ct+4 ]  = ClassLib.ComFunction.Empty_TextBox(txt_PFC, "");
				MyOraDB.Parameter_Values[para_ct+5 ]  = ClassLib.ComFunction.Empty_TextBox(txt_Operation, "");
				MyOraDB.Parameter_Values[para_ct+6 ]  = ClassLib.ComFunction.Empty_TextBox(txt_StitchingMC_No, "");
				MyOraDB.Parameter_Values[para_ct+7 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Machine, "");
				MyOraDB.Parameter_Values[para_ct+8 ]  = ClassLib.ComFunction.Empty_Combo(cmb_Layer, "");
				MyOraDB.Parameter_Values[para_ct+9 ]  = ClassLib.ComFunction.Empty_Combo(cmb_1Material, "");
				MyOraDB.Parameter_Values[para_ct+10]  = ClassLib.ComFunction.Empty_Combo(cmb_2Material, "");
				MyOraDB.Parameter_Values[para_ct+11]  = ClassLib.ComFunction.Empty_Combo(cmb_Curve, "");
				MyOraDB.Parameter_Values[para_ct+12]  = ClassLib.ComFunction.Empty_Combo(cmb_Radius, "");
				MyOraDB.Parameter_Values[para_ct+13]  = ClassLib.ComFunction.Empty_Combo(cmb_Angle, "");
				MyOraDB.Parameter_Values[para_ct+14]  = ClassLib.ComFunction.Empty_Combo(cmb_Edge, "");
				MyOraDB.Parameter_Values[para_ct+ 15]  = ClassLib.ComFunction.Empty_Combo(cmb_Stitch, "");
				MyOraDB.Parameter_Values[para_ct+ 16]  = ClassLib.ComFunction.Empty_Combo(cmb_WorkerClass, "");
				MyOraDB.Parameter_Values[para_ct+ 17]  = ClassLib.ComFunction.Empty_TextBox(txt_Remark, "");
				MyOraDB.Parameter_Values[para_ct+ 18]  = ClassLib.ComFunction.Empty_TextBox(txt_Cycle_Time, "");
				MyOraDB.Parameter_Values[para_ct+ 19]  = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);		
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if(ClassLib.ComFunction.User_Message("Do you want to delete this data?","Delete", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
			{
				this.Tbtn_SaveProcess("D");		
				cmb_PFC.ClearFields();
				cmb_PFC.Text = "";
				cmb_PFC_Page.ClearFields();
				cmb_PFC_Page.Text = "";
			}
		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Clear_Fields();
		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if(e.KeyCode != Keys.Enter) return;

 
				DataTable dt_ret = Select_SDC_STYLE (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , "") );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);

				
//				//-------------------------------------------------------------------------
//				// 기타 콘트롤 초기화 
//				cmb_StyleCd.SelectedIndex = -1;
////				txt_Gender.Text = ""; 
////				txt_Presto.Text = "";
//
////				fgrid_Yield.Rows.Count = fgrid_Yield.Rows.Fixed;
////				fgrid_Yield.Cols.Count = (int)ClassLib.TBSBC_YIELD_INFO.IxCS_SIZE_START;
//				//-------------------------------------------------------------------------
//
//				DataTable dt_ret;
//				
//				dt_ret = Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
//				 
//				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
//				//ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 
//				COM.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, false);
//
//				string stylecd = "";
//				int exist_index = -1;
//
//				stylecd = txt_StyleCd.Text.Trim();
//
//				exist_index = txt_StyleCd.Text.IndexOf("-", 0);
//
//				if(exist_index == -1 && stylecd.Length == 9)
//				{
//					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
//				}
// 
//				cmb_StyleCd.SelectedValue = stylecd;
				cmb_StyleCd.ExtendRightColumn = true; 
				cmb_StyleCd.Splits[0].DisplayColumns["Code"].Width = 90;
				cmb_StyleCd.Splits[0].DisplayColumns["Name"].Width = 200;

//				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public DataTable Select_SDC_STYLE(string arg_stylecd)
		{
			//COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(2); 

			MyOraDB.Process_Name = "PKG_SVM_STITCHING_RPM.SELECT_SDC_STYLE";

			MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = arg_stylecd;
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Clear_Fields();
			cmb_PFC.ClearFields();
			cmb_PFC_Page.ClearFields();
			cmb_PFC.Text = "";
			if(cmb_StyleCd.SelectedIndex == -1) return;
			txt_StyleCd.Text = cmb_StyleCd.Columns[0].Text;

			DataTable dt_ret = Select_PFC_PAGE (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PFC_Page, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
		}

		public DataTable Select_PFC_PAGE(string arg_stylecd)
		{
			//COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(3); 

			MyOraDB.Process_Name = "PKG_SVM_STITCHING_RPM.SELECT_PFC_PAGE";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}

		
		private void cmb_StyleCd_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void cmb_PFC_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_PFC.SelectedIndex == -1) return;
			txt_PFC.Text = cmb_PFC.Columns[0].Text;
		}

		

		private void cmb_PFC_Page_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_PFC_Page.SelectedIndex == -1) return;
			txt_PFC_Page.Text = cmb_PFC_Page.Columns[0].Text;

			DataTable dt_ret = Select_PFC_NUMBER (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , ""), ClassLib.ComFunction.Empty_TextBox(txt_PFC_Page , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PFC, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
		}

		public DataTable Select_PFC_NUMBER(string arg_stylecd, string arg_pfc_page)
		{
			//COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(4); 

			MyOraDB.Process_Name = "PKG_SVM_STITCHING_RPM.SELECT_PFC_NUMBER";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_PFC_PAGE";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = arg_pfc_page;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 

		}

		private void txt_PFC_Page_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode != Keys.Enter) return;
 
			DataTable dt_ret = Select_PFC_PAGE (ClassLib.ComFunction.Empty_TextBox(txt_StyleCd , "") );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PFC_Page, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void cmb_PFC_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}


}

