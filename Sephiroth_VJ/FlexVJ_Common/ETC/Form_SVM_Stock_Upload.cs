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


namespace FlexVJ_Common.ETC
{
	public class Form_SVM_Stock_Upload : COM.VJ_CommonWinForm.Form_Top
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		public COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_inYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Label lbl_Training;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dpick_Out_YMD;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private System.Windows.Forms.TextBox txt_Line;
		private System.Windows.Forms.TextBox txt_Item;
		private System.Windows.Forms.TextBox txt_Spec;
		private System.Windows.Forms.TextBox txt_Color;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_ColorCD;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.Label btn_Upload;
		private System.ComponentModel.IContainer components = null;

		public Form_SVM_Stock_Upload()
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		/// 

		#region User Define Variable

		private COM.OraDB MyOraDB  = new COM.OraDB();
		private int _Rowfixed;
       
		private int	_colFACTORY			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxFACTORY;		
		private int	_colOUT_YMD			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IXOUT_YMD;		
		private int	_colOBS_ID			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxOBS_ID;		
		private int	_colSTYLE_CD		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSTYLE_CD;    
		private int	_colSTYLE_NAME		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSTYLE_NAME;  
		private int	_colPROD_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxPROD_QTY;		
		private int	_colOUT_PROCESS		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxOUT_PROCESS; 
		private int	_colLINE_NAME		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxLINE_NAME;
		private int	_colITEM_GROUP		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxITEM_GROUP;  
		private int	_colITEM_NAME		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxITEM_NAME;	
		private int	_colSPEC_NAME		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSPEC_NAME; 
		private int	_colCOLOR_NAME		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxCOLOR_NAME;  
		private int	_colUNIT			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxUNIT;	
		private int	_colYIELD			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxYIELD;			
		private int	_colUSAGE_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxUSAGE_QTY;   
		private int	_colSYS_BASE_QTY	= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSYS_BASE_QTY;
		private int	_colSYS_IN_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSYS_IN_QTY;  
		private int	_colSYS_OUT_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSYS_OUT_QTY; 
		private int	_colSYS_STOCK_QTY	= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSYS_STOCK_QTY;
		private int	_colACT_BASE_QTY	= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxACT_BASE_QTY;
		private int	_colACT_IN_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxACT_IN_QTY;  
		private int	_colACT_OUT_QTY		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxACT_OUT_QTY; 
		private int	_colACT_STOCK_QTY	= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxACT_STOCK_QTY;
		private int	_colLOT_NO			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxLOT_NO;      
		private int	_colLOT_SEQ			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxLOT_SEQ;		
		private int	_colOUT_LINE		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxOUT_LINE;    
		private int	_colITEM_CD			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxITEM_CD;    
		private int	_colSPEC_CD			= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxSPEC_CD;    
		private int	_colCOLOR_CD		= (int)ClassLib.TBSVM_STOCK_UPLOAD.IxCOLOR_CD;  
			

		#endregion

		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SVM_Stock_Upload));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.fgrid_main = new COM.FSP();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_Upload = new System.Windows.Forms.Label();
			this.txt_ColorCD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Spec = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Item = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Line = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dpick_Out_YMD = new System.Windows.Forms.DateTimePicker();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_inYmd = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pnl_menu = new System.Windows.Forms.Panel();
			this.btn_recover = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.btn_purchase = new System.Windows.Forms.Label();
			this.txt_Color = new System.Windows.Forms.TextBox();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_menu.SuspendLayout();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
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
			this.c1Sizer1.Controls.Add(this.fgrid_main);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.pnl_menu);
			this.c1Sizer1.GridDefinition = "18.8356164383562:False:True;73.2876712328767:False:False;5.13698630136986:False:T" +
				"rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
				":False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
			this.c1Sizer1.TabIndex = 30;
			this.c1Sizer1.TabStop = false;
			// 
			// fgrid_main
			// 
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(12, 118);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Size = new System.Drawing.Size(992, 428);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 171;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_Upload);
			this.pnl_head.Controls.Add(this.txt_ColorCD);
			this.pnl_head.Controls.Add(this.label6);
			this.pnl_head.Controls.Add(this.txt_Spec);
			this.pnl_head.Controls.Add(this.label5);
			this.pnl_head.Controls.Add(this.txt_Item);
			this.pnl_head.Controls.Add(this.label4);
			this.pnl_head.Controls.Add(this.txt_Line);
			this.pnl_head.Controls.Add(this.label3);
			this.pnl_head.Controls.Add(this.txt_OBS_ID);
			this.pnl_head.Controls.Add(this.label1);
			this.pnl_head.Controls.Add(this.txt_Style);
			this.pnl_head.Controls.Add(this.lbl_Training);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.dpick_Out_YMD);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_inYmd);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.cmb_Factory);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Location = new System.Drawing.Point(12, 4);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(992, 110);
			this.pnl_head.TabIndex = 1;
			// 
			// btn_Upload
			// 
			this.btn_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Upload.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Upload.ImageIndex = 0;
			this.btn_Upload.ImageList = this.img_Button;
			this.btn_Upload.Location = new System.Drawing.Point(868, 80);
			this.btn_Upload.Name = "btn_Upload";
			this.btn_Upload.Size = new System.Drawing.Size(80, 23);
			this.btn_Upload.TabIndex = 550;
			this.btn_Upload.Text = "Upload";
			this.btn_Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
			// 
			// txt_ColorCD
			// 
			this.txt_ColorCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorCD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ColorCD.Location = new System.Drawing.Point(749, 55);
			this.txt_ColorCD.MaxLength = 20;
			this.txt_ColorCD.Name = "txt_ColorCD";
			this.txt_ColorCD.Size = new System.Drawing.Size(200, 21);
			this.txt_ColorCD.TabIndex = 405;
			this.txt_ColorCD.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 0;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(648, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 404;
			this.label6.Text = "Color";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Spec
			// 
			this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Spec.Location = new System.Drawing.Point(749, 33);
			this.txt_Spec.MaxLength = 20;
			this.txt_Spec.Name = "txt_Spec";
			this.txt_Spec.Size = new System.Drawing.Size(200, 21);
			this.txt_Spec.TabIndex = 403;
			this.txt_Spec.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(648, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 402;
			this.label5.Text = "Spec";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Item
			// 
			this.txt_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Item.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Item.Location = new System.Drawing.Point(428, 77);
			this.txt_Item.MaxLength = 20;
			this.txt_Item.Name = "txt_Item";
			this.txt_Item.Size = new System.Drawing.Size(200, 21);
			this.txt_Item.TabIndex = 401;
			this.txt_Item.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(328, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 400;
			this.label4.Text = "Item";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Line
			// 
			this.txt_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Line.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Line.Location = new System.Drawing.Point(428, 55);
			this.txt_Line.MaxLength = 20;
			this.txt_Line.Name = "txt_Line";
			this.txt_Line.Size = new System.Drawing.Size(200, 21);
			this.txt_Line.TabIndex = 399;
			this.txt_Line.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(328, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 398;
			this.label3.Text = "Line";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_ID
			// 
			this.txt_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OBS_ID.Location = new System.Drawing.Point(109, 77);
			this.txt_OBS_ID.MaxLength = 20;
			this.txt_OBS_ID.Name = "txt_OBS_ID";
			this.txt_OBS_ID.Size = new System.Drawing.Size(200, 21);
			this.txt_OBS_ID.TabIndex = 397;
			this.txt_OBS_ID.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 396;
			this.label1.Text = "OBS ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style
			// 
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style.Location = new System.Drawing.Point(428, 33);
			this.txt_Style.MaxLength = 20;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(200, 21);
			this.txt_Style.TabIndex = 395;
			this.txt_Style.Text = "";
			// 
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(328, 33);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 394;
			this.lbl_Training.Text = "Style";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Incoming Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Out_YMD
			// 
			this.dpick_Out_YMD.CustomFormat = "";
			this.dpick_Out_YMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dpick_Out_YMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Out_YMD.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.dpick_Out_YMD.Location = new System.Drawing.Point(109, 55);
			this.dpick_Out_YMD.Name = "dpick_Out_YMD";
			this.dpick_Out_YMD.TabIndex = 381;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(976, 94);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_inYmd
			// 
			this.lbl_inYmd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_inYmd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_inYmd.ImageIndex = 0;
			this.lbl_inYmd.ImageList = this.img_Label;
			this.lbl_inYmd.Location = new System.Drawing.Point(8, 55);
			this.lbl_inYmd.Name = "lbl_inYmd";
			this.lbl_inYmd.Size = new System.Drawing.Size(100, 21);
			this.lbl_inYmd.TabIndex = 50;
			this.lbl_inYmd.Text = "Out Date";
			this.lbl_inYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 93);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(952, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
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
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 33);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(200, 21);
			this.cmb_Factory.TabIndex = 1;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 33);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(891, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 69);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(976, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 94);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 0);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 92);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(160, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(912, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pnl_menu
			// 
			this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
			this.pnl_menu.Controls.Add(this.btn_recover);
			this.pnl_menu.Controls.Add(this.btn_insert);
			this.pnl_menu.Controls.Add(this.btn_cancel);
			this.pnl_menu.Location = new System.Drawing.Point(12, 550);
			this.pnl_menu.Name = "pnl_menu";
			this.pnl_menu.Size = new System.Drawing.Size(992, 30);
			this.pnl_menu.TabIndex = 170;
			// 
			// btn_recover
			// 
			this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_recover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_recover.ImageIndex = 1;
			this.btn_recover.ImageList = this.image_List;
			this.btn_recover.Location = new System.Drawing.Point(907, 4);
			this.btn_recover.Name = "btn_recover";
			this.btn_recover.Size = new System.Drawing.Size(80, 24);
			this.btn_recover.TabIndex = 367;
			this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_insert
			// 
			this.btn_insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_insert.ImageIndex = 9;
			this.btn_insert.ImageList = this.image_List;
			this.btn_insert.Location = new System.Drawing.Point(745, 3);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 26);
			this.btn_insert.TabIndex = 360;
			this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_cancel.ImageIndex = 5;
			this.btn_cancel.ImageList = this.image_List;
			this.btn_cancel.Location = new System.Drawing.Point(826, 4);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_cancel.TabIndex = 359;
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_purchase
			// 
			this.btn_purchase.Location = new System.Drawing.Point(0, 0);
			this.btn_purchase.Name = "btn_purchase";
			this.btn_purchase.TabIndex = 0;
			// 
			// txt_Color
			// 
			this.txt_Color.Location = new System.Drawing.Point(0, 0);
			this.txt_Color.Name = "txt_Color";
			this.txt_Color.TabIndex = 0;
			this.txt_Color.Text = "";
			// 
			// Form_SVM_Stock_Upload
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form_SVM_Stock_Upload";
			this.Load += new System.EventHandler(this.Form_SVM_Stock_Upload_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_menu.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_SVM_Stock_Upload_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Stock Upload";
			this.Text		   = "Stock Upload";


			// grid set
			fgrid_main.Set_Grid("SVM_STOCK_UPLOAD", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);

			_Rowfixed = fgrid_main.Rows.Fixed;
			fgrid_main[_Rowfixed-2, 0] = " ";
			fgrid_main[_Rowfixed-1, 0] = " ";

			fgrid_main.Set_Action_Image(img_Action);
			fgrid_main.Rows[1].AllowMerging = true;

			fgrid_main.Styles.Frozen.BackColor = Color.Lavender; 			
			fgrid_main.KeyActionEnter = KeyActionEnum.MoveAcross;
			fgrid_main.KeyActionTab = KeyActionEnum.MoveAcross;  
			fgrid_main.SelectionMode = SelectionModeEnum.Cell;

			DataTable vDt;
				
			// factory set
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue    = ClassLib.ComVar.This_Factory;
			
		}

		private void btn_Upload_Click(object sender, System.EventArgs e)
		{
			string File_Path;
			openFile.ShowDialog();
			File_Path=openFile.FileName.ToString();
			Data_Load(File_Path);
		
		}

		private void Data_Load(string _Path)
		{
			string path =_Path.Trim(); 
			string strConn=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path+";Excel 8.0;Imex=1;HDR=YES";                  
			
			try
			{
				OleDbConnection AdoConn = null;
				AdoConn = new OleDbConnection(strConn);
				AdoConn.Close();
				AdoConn.Open();

				OleDbCommand myCommand = new OleDbCommand("Select * from [Sheet1$];");
				myCommand.Connection = AdoConn;
				OleDbDataReader myReader = myCommand.ExecuteReader();
			
				int iRow = 0;
				Clear_FlexGrid();
				while (myReader.Read())
				{

					C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

					fgrid_main[newRow.Row.Index, 0] = "";

					for (int iField = 1; iField <= myReader.FieldCount; iField++)
					{
						fgrid_main[newRow.Row.Index, iField] = myReader.GetValue(iField-1).ToString();
					}
					iRow ++;
				}
				AdoConn.Close();
				Check_Exist_Data();
			}
			catch (Exception Ex)
			{
			}
		}

		private void Check_Exist_Data()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SVM_STOCK_UPLOAD.SELECT_SVM_STOCK_UPLOAD";
				
				for (int iRow = _Rowfixed; iRow < fgrid_main.Rows.Count; iRow ++)
				{
					DataTable vDt = SELECT_SVM_STOCK_UPLOAD(vProcedure, iRow);
					if (vDt.Rows.Count == 0)
					{
						fgrid_main[iRow, 0] = "I";
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
					}
					else
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
					}
				}
				dpick_Out_YMD.Value = Convert.ToDateTime(fgrid_main[_Rowfixed, 2]);
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

		public DataTable SELECT_SVM_STOCK_UPLOAD(string arg_procedure, int iRow)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[ 2]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[ 3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[ 5]  = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[ 6]  = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[ 7]  = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[ 8]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 8]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = fgrid_main[iRow, _colFACTORY].ToString();
			MyOraDB.Parameter_Values[ 1]   = (fgrid_main[iRow, _colOUT_YMD] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colOUT_YMD]).ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = fgrid_main[iRow, _colOBS_ID].ToString();
			MyOraDB.Parameter_Values[ 3]   = fgrid_main[iRow, _colSTYLE_CD].ToString();
			MyOraDB.Parameter_Values[ 4]   = fgrid_main[iRow, _colOUT_LINE].ToString();
			MyOraDB.Parameter_Values[ 5]   = fgrid_main[iRow, _colITEM_CD].ToString();
			MyOraDB.Parameter_Values[ 6]   = fgrid_main[iRow, _colSPEC_CD].ToString();
			MyOraDB.Parameter_Values[ 7]   = fgrid_main[iRow, _colCOLOR_CD].ToString();
			MyOraDB.Parameter_Values[ 8]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void Display_FlexGrid(DataTable arg_dt)
		{
			int iCount = arg_dt.Rows.Count;

			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(_Rowfixed + iRow, 1);

				fgrid_main[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
					fgrid_main[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];

			}

		}

		private void Clear_FlexGrid()
		{
			if (fgrid_main.Rows.Fixed != fgrid_main.Rows.Count)
			{				
				fgrid_main.Clear(ClearFlags.UserData, fgrid_main.Rows.Fixed, 1, fgrid_main.Rows.Count - 1, fgrid_main.Cols.Count - 1);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
			}
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
                
				string vProcedure     = "PKG_SVM_STOCK_UPLOAD.SELECT_SVM_STOCK_UPLOAD";
				
				DataTable vDt = SELECT_SVM_STOCK_UPLOAD(vProcedure);

				Clear_FlexGrid();
				if (vDt.Rows.Count > 0)
				{
					Display_FlexGrid(vDt);

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

		public DataTable SELECT_SVM_STOCK_UPLOAD(string arg_procedure)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_OUT_YMD";
			MyOraDB.Parameter_Name[ 2]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[ 3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[ 4]  = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[ 5]  = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[ 6]  = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[ 7]  = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[ 8]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 8]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			MyOraDB.Parameter_Values[ 1]   = dpick_Out_YMD.Value.ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_TextBox(txt_OBS_ID, "");
			MyOraDB.Parameter_Values[ 3]   = ClassLib.ComFunction.Empty_TextBox(txt_Style, "");
			MyOraDB.Parameter_Values[ 4]   = ClassLib.ComFunction.Empty_TextBox(txt_Line, "");
			MyOraDB.Parameter_Values[ 5]   = ClassLib.ComFunction.Empty_TextBox(txt_Item, "");
			MyOraDB.Parameter_Values[ 6]   = ClassLib.ComFunction.Empty_TextBox(txt_Spec, "");
			MyOraDB.Parameter_Values[ 7]   = ClassLib.ComFunction.Empty_TextBox(txt_ColorCD, "");
			MyOraDB.Parameter_Values[ 8]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Validate_Check())
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save the data you have been changed?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )					
				{
					this.Tbtn_SaveProcess();					
				}
			}	
		
		}	

		private bool Validate_Check()
		{
//			for (int iRow = _Rowfixed ; iRow < fgrid_main.Rows.Count ; iRow++)
//			{
//				if ((fgrid_main[iRow, _colT_NAME].ToString().Replace(" ", "").Trim().Length == 0) )
//				{
//					fgrid_main[iRow, 0] = "";					
//				}
//			}			

			return true;
		}

		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_STOCK_UPLOAD(true))
				{
					fgrid_main.Refresh_Division();
					this.Tbtn_SearchProcess();
					MessageBox.Show("Create Complete","Create", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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

		public bool SAVE_SVM_STOCK_UPLOAD(bool doExecute)
		{
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 31;


				MyOraDB.ReDim_Parameter(iCount);

				//01.PROCEDURE NAME
				MyOraDB.Process_Name = "PKG_SVM_STOCK_UPLOAD.SAVE_SVM_STOCK_UPLOAD";

				//02.ARGURMENT NAME
				MyOraDB.Parameter_Name[ 0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[ 1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[ 2] = "ARG_OUT_YMD";
				MyOraDB.Parameter_Name[ 3] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[ 4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[ 5] = "ARG_STYLE_NAME";
				MyOraDB.Parameter_Name[ 6] = "ARG_PROD_QTY";
				MyOraDB.Parameter_Name[ 7] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[ 8] = "ARG_LINE_NAME";
				MyOraDB.Parameter_Name[ 9] = "ARG_ITEM_GROUP";
				MyOraDB.Parameter_Name[ 10] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[ 11] = "ARG_SPEC_NAME";
				MyOraDB.Parameter_Name[ 12] = "ARG_COLOR_NAME";
				MyOraDB.Parameter_Name[ 13] = "ARG_UNIT";
				MyOraDB.Parameter_Name[ 14] = "ARG_YIELD";
				MyOraDB.Parameter_Name[ 15] = "ARG_USAGE_QTY";
				MyOraDB.Parameter_Name[ 16] = "ARG_SYS_BASE_QTY";
				MyOraDB.Parameter_Name[ 17] = "ARG_SYS_IN_QTY";
				MyOraDB.Parameter_Name[ 18] = "ARG_SYS_OUT_QTY";
				MyOraDB.Parameter_Name[ 19] = "ARG_SYS_STOCK_QTY";
				MyOraDB.Parameter_Name[ 20] = "ARG_ACT_BASE_QTY";
				MyOraDB.Parameter_Name[ 21] = "ARG_ACT_IN_QTY";
				MyOraDB.Parameter_Name[ 22] = "ARG_ACT_OUT_QTY";
				MyOraDB.Parameter_Name[ 23] = "ARG_ACT_STOCK_QTY";
				MyOraDB.Parameter_Name[ 24] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[ 25] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[ 26] = "ARG_OUT_LINE";
				MyOraDB.Parameter_Name[ 27] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[ 28] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[ 29] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[ 30] = "ARG_UPDATE_USER";   


				for (int iCol = 0 ; iCol < iCount ; iCol++)
					MyOraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
				
				for(int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_main[iRow, 0]).Equals("") )
						save_ct += 1;
				
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_main.Rows.Fixed ; iRow < fgrid_main.Rows.Count ; iRow++)
				{
					if(fgrid_main[iRow, 0].ToString() != "")
					{
						MyOraDB.Parameter_Values[para_ct+ 0] = fgrid_main[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] =fgrid_main[iRow, _colFACTORY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] =(fgrid_main[iRow, _colOUT_YMD] == null) ? "" : Convert.ToDateTime(fgrid_main[iRow, _colOUT_YMD]).ToString("yyyyMMdd");
						MyOraDB.Parameter_Values[para_ct+ 3] =fgrid_main[iRow, _colOBS_ID].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] =fgrid_main[iRow, _colSTYLE_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] =fgrid_main[iRow, _colSTYLE_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] =fgrid_main[iRow, _colPROD_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 7] =fgrid_main[iRow, _colOUT_PROCESS].ToString();
						MyOraDB.Parameter_Values[para_ct+ 8] =fgrid_main[iRow, _colLINE_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+ 9] =fgrid_main[iRow, _colITEM_GROUP].ToString();
						MyOraDB.Parameter_Values[para_ct+ 10] =fgrid_main[iRow, _colITEM_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+ 11] =fgrid_main[iRow, _colSPEC_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+ 12] =fgrid_main[iRow, _colCOLOR_NAME].ToString();
						MyOraDB.Parameter_Values[para_ct+ 13] =fgrid_main[iRow, _colUNIT].ToString();
						MyOraDB.Parameter_Values[para_ct+ 14] =fgrid_main[iRow, _colYIELD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 15] =fgrid_main[iRow, _colUSAGE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 16] =fgrid_main[iRow, _colSYS_BASE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 17] =fgrid_main[iRow, _colSYS_IN_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 18] =fgrid_main[iRow, _colSYS_OUT_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 19] =fgrid_main[iRow, _colSYS_STOCK_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 20] =fgrid_main[iRow, _colACT_BASE_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 21] =fgrid_main[iRow, _colACT_IN_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 22] =fgrid_main[iRow, _colACT_OUT_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 23] =fgrid_main[iRow, _colACT_STOCK_QTY].ToString();
						MyOraDB.Parameter_Values[para_ct+ 24] =fgrid_main[iRow, _colLOT_NO].ToString();
						MyOraDB.Parameter_Values[para_ct+ 25] =fgrid_main[iRow, _colLOT_SEQ].ToString();
						MyOraDB.Parameter_Values[para_ct+ 26] =fgrid_main[iRow, _colOUT_LINE].ToString();
						MyOraDB.Parameter_Values[para_ct+ 27] =fgrid_main[iRow, _colITEM_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 28] =fgrid_main[iRow, _colSPEC_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 29] =fgrid_main[iRow, _colCOLOR_CD].ToString();
						MyOraDB.Parameter_Values[para_ct+ 30] = COM.ComVar.This_User;

						para_ct += iCount;	
					}				
				}

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

		
			


		
		
	}
}

