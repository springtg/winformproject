using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdSchedule
{
	public class Pop_CFM_History : COM.APSWinForm.Pop_Small
	{
		private System.ComponentModel.IContainer components = null;
		//private Form_SD_Mrp_Item arg_frm = null;
//		private string arg_Factory;
//		private string arg_DPO;
//		private string arg_StyleNo;
//		private string arg_Model;
//		private string arg_Gender;
//		private string arg_Category;
//		private string arg_Qty;
//		private string arg_Developer;
		//private int _RowFixed;
		private System.Windows.Forms.TextBox txtStyleNo;
		private System.Windows.Forms.TextBox txtDPO;
		private System.Windows.Forms.Label lblDPO;
		private System.Windows.Forms.TextBox txtFactory;
		private System.Windows.Forms.Label lblFactory;
		private System.Windows.Forms.Label lblStyleNo;
		private COM.FSP grdCFMHis;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.TextBox txtGender;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.TextBox txtDeveloper;
		private System.Windows.Forms.Label lblDeveloper;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtHisItem;
		private System.Windows.Forms.Label lblListTitle;
		private System.Windows.Forms.Button btnClose;
		private COM.OraDB OraDB = new COM.OraDB();

		public Pop_CFM_History(string Factory, string DPO, string StyleNo, string Model, string Gender, string Category, string Qty, string Developer, string Item)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			txtFactory.Text   = Factory;
			txtDPO.Text       = DPO;
			txtStyleNo.Text   = StyleNo;
			txtModel.Text     = Model;
			txtGender.Text    = Gender;
			txtCategory.Text  = Category;
			txtQty.Text       = Qty;
			txtDeveloper.Text = Developer;
			txtHisItem.Text   = Item;
		}

		public Pop_CFM_History()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CFM_History));
			this.txtStyleNo = new System.Windows.Forms.TextBox();
			this.txtDPO = new System.Windows.Forms.TextBox();
			this.lblDPO = new System.Windows.Forms.Label();
			this.txtFactory = new System.Windows.Forms.TextBox();
			this.lblFactory = new System.Windows.Forms.Label();
			this.lblStyleNo = new System.Windows.Forms.Label();
			this.grdCFMHis = new COM.FSP();
			this.lblCategory = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.txtGender = new System.Windows.Forms.TextBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.lblModel = new System.Windows.Forms.Label();
			this.txtDeveloper = new System.Windows.Forms.TextBox();
			this.lblDeveloper = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtHisItem = new System.Windows.Forms.TextBox();
			this.lblListTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdCFMHis)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageSize = new System.Drawing.Size(85, 23);
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(272, 23);
			this.lbl_MainTitle.Text = "CFM Shoe History";
			// 
			// txtStyleNo
			// 
			this.txtStyleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStyleNo.Enabled = false;
			this.txtStyleNo.Location = new System.Drawing.Point(112, 88);
			this.txtStyleNo.Name = "txtStyleNo";
			this.txtStyleNo.ReadOnly = true;
			this.txtStyleNo.Size = new System.Drawing.Size(264, 21);
			this.txtStyleNo.TabIndex = 309;
			this.txtStyleNo.Text = "";
			// 
			// txtDPO
			// 
			this.txtDPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDPO.Enabled = false;
			this.txtDPO.Location = new System.Drawing.Point(112, 64);
			this.txtDPO.Name = "txtDPO";
			this.txtDPO.ReadOnly = true;
			this.txtDPO.Size = new System.Drawing.Size(264, 21);
			this.txtDPO.TabIndex = 308;
			this.txtDPO.Text = "";
			// 
			// lblDPO
			// 
			this.lblDPO.ImageIndex = 0;
			this.lblDPO.ImageList = this.img_Label;
			this.lblDPO.Location = new System.Drawing.Point(24, 64);
			this.lblDPO.Name = "lblDPO";
			this.lblDPO.Size = new System.Drawing.Size(85, 23);
			this.lblDPO.TabIndex = 307;
			this.lblDPO.Text = "DPO ID :";
			this.lblDPO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFactory
			// 
			this.txtFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFactory.Enabled = false;
			this.txtFactory.Location = new System.Drawing.Point(112, 40);
			this.txtFactory.Name = "txtFactory";
			this.txtFactory.ReadOnly = true;
			this.txtFactory.Size = new System.Drawing.Size(264, 21);
			this.txtFactory.TabIndex = 306;
			this.txtFactory.Text = "";
			// 
			// lblFactory
			// 
			this.lblFactory.ImageIndex = 0;
			this.lblFactory.ImageList = this.img_Label;
			this.lblFactory.Location = new System.Drawing.Point(24, 40);
			this.lblFactory.Name = "lblFactory";
			this.lblFactory.Size = new System.Drawing.Size(85, 23);
			this.lblFactory.TabIndex = 305;
			this.lblFactory.Text = "Factory :";
			this.lblFactory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblStyleNo
			// 
			this.lblStyleNo.ImageIndex = 0;
			this.lblStyleNo.ImageList = this.img_Label;
			this.lblStyleNo.Location = new System.Drawing.Point(24, 88);
			this.lblStyleNo.Name = "lblStyleNo";
			this.lblStyleNo.Size = new System.Drawing.Size(85, 23);
			this.lblStyleNo.TabIndex = 310;
			this.lblStyleNo.Text = "Style No :";
			this.lblStyleNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grdCFMHis
			// 
			this.grdCFMHis.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.grdCFMHis.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.grdCFMHis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grdCFMHis.AutoResize = false;
			this.grdCFMHis.BackColor = System.Drawing.SystemColors.Window;
			this.grdCFMHis.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.grdCFMHis.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.grdCFMHis.ForeColor = System.Drawing.SystemColors.WindowText;
			this.grdCFMHis.Location = new System.Drawing.Point(8, 272);
			this.grdCFMHis.Name = "grdCFMHis";
			this.grdCFMHis.Rows.Fixed = 0;
			this.grdCFMHis.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.grdCFMHis.Size = new System.Drawing.Size(388, 208);
			this.grdCFMHis.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.grdCFMHis.TabIndex = 311;
			// 
			// lblCategory
			// 
			this.lblCategory.ImageIndex = 0;
			this.lblCategory.ImageList = this.img_Label;
			this.lblCategory.Location = new System.Drawing.Point(24, 160);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(85, 23);
			this.lblCategory.TabIndex = 317;
			this.lblCategory.Text = "Category :";
			this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCategory
			// 
			this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCategory.Enabled = false;
			this.txtCategory.Location = new System.Drawing.Point(112, 160);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.ReadOnly = true;
			this.txtCategory.Size = new System.Drawing.Size(264, 21);
			this.txtCategory.TabIndex = 316;
			this.txtCategory.Text = "";
			// 
			// txtGender
			// 
			this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGender.Enabled = false;
			this.txtGender.Location = new System.Drawing.Point(112, 136);
			this.txtGender.Name = "txtGender";
			this.txtGender.ReadOnly = true;
			this.txtGender.Size = new System.Drawing.Size(264, 21);
			this.txtGender.TabIndex = 315;
			this.txtGender.Text = "";
			// 
			// lblGender
			// 
			this.lblGender.ImageIndex = 0;
			this.lblGender.ImageList = this.img_Label;
			this.lblGender.Location = new System.Drawing.Point(24, 136);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(85, 23);
			this.lblGender.TabIndex = 314;
			this.lblGender.Text = "Gender :";
			this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModel
			// 
			this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtModel.Enabled = false;
			this.txtModel.Location = new System.Drawing.Point(112, 112);
			this.txtModel.Name = "txtModel";
			this.txtModel.ReadOnly = true;
			this.txtModel.Size = new System.Drawing.Size(264, 21);
			this.txtModel.TabIndex = 313;
			this.txtModel.Text = "";
			// 
			// lblModel
			// 
			this.lblModel.ImageIndex = 0;
			this.lblModel.ImageList = this.img_Label;
			this.lblModel.Location = new System.Drawing.Point(24, 112);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(85, 23);
			this.lblModel.TabIndex = 312;
			this.lblModel.Text = "Model :";
			this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDeveloper
			// 
			this.txtDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDeveloper.Enabled = false;
			this.txtDeveloper.Location = new System.Drawing.Point(112, 208);
			this.txtDeveloper.Name = "txtDeveloper";
			this.txtDeveloper.ReadOnly = true;
			this.txtDeveloper.Size = new System.Drawing.Size(264, 21);
			this.txtDeveloper.TabIndex = 321;
			this.txtDeveloper.Text = "";
			// 
			// lblDeveloper
			// 
			this.lblDeveloper.ImageIndex = 0;
			this.lblDeveloper.ImageList = this.img_Label;
			this.lblDeveloper.Location = new System.Drawing.Point(24, 208);
			this.lblDeveloper.Name = "lblDeveloper";
			this.lblDeveloper.Size = new System.Drawing.Size(85, 23);
			this.lblDeveloper.TabIndex = 320;
			this.lblDeveloper.Text = "Developer :";
			this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtQty
			// 
			this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtQty.Enabled = false;
			this.txtQty.Location = new System.Drawing.Point(112, 184);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(264, 21);
			this.txtQty.TabIndex = 319;
			this.txtQty.Text = "";
			// 
			// lblQty
			// 
			this.lblQty.ImageIndex = 0;
			this.lblQty.ImageList = this.img_Label;
			this.lblQty.Location = new System.Drawing.Point(24, 184);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(85, 23);
			this.lblQty.TabIndex = 318;
			this.lblQty.Text = "Qty :";
			this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtHisItem
			// 
			this.txtHisItem.Location = new System.Drawing.Point(352, 8);
			this.txtHisItem.Name = "txtHisItem";
			this.txtHisItem.Size = new System.Drawing.Size(0, 21);
			this.txtHisItem.TabIndex = 322;
			this.txtHisItem.Text = "";
			// 
			// lblListTitle
			// 
			this.lblListTitle.AutoSize = true;
			this.lblListTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.lblListTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblListTitle.Location = new System.Drawing.Point(8, 248);
			this.lblListTitle.Name = "lblListTitle";
			this.lblListTitle.Size = new System.Drawing.Size(0, 21);
			this.lblListTitle.TabIndex = 323;
			this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(312, 240);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 24);
			this.btnClose.TabIndex = 324;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Pop_CFM_History
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(402, 488);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblListTitle);
			this.Controls.Add(this.txtHisItem);
			this.Controls.Add(this.txtDeveloper);
			this.Controls.Add(this.lblDeveloper);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.lblQty);
			this.Controls.Add(this.lblCategory);
			this.Controls.Add(this.txtCategory);
			this.Controls.Add(this.txtGender);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.grdCFMHis);
			this.Controls.Add(this.lblStyleNo);
			this.Controls.Add(this.txtStyleNo);
			this.Controls.Add(this.txtDPO);
			this.Controls.Add(this.lblDPO);
			this.Controls.Add(this.txtFactory);
			this.Controls.Add(this.lblFactory);
			this.Name = "Pop_CFM_History";
			this.Text = "Pop CFM Shoe History";
			this.Load += new System.EventHandler(this.Pop_CFM_History_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lblFactory, 0);
			this.Controls.SetChildIndex(this.txtFactory, 0);
			this.Controls.SetChildIndex(this.lblDPO, 0);
			this.Controls.SetChildIndex(this.txtDPO, 0);
			this.Controls.SetChildIndex(this.txtStyleNo, 0);
			this.Controls.SetChildIndex(this.lblStyleNo, 0);
			this.Controls.SetChildIndex(this.grdCFMHis, 0);
			this.Controls.SetChildIndex(this.lblModel, 0);
			this.Controls.SetChildIndex(this.txtModel, 0);
			this.Controls.SetChildIndex(this.lblGender, 0);
			this.Controls.SetChildIndex(this.txtGender, 0);
			this.Controls.SetChildIndex(this.txtCategory, 0);
			this.Controls.SetChildIndex(this.lblCategory, 0);
			this.Controls.SetChildIndex(this.lblQty, 0);
			this.Controls.SetChildIndex(this.txtQty, 0);
			this.Controls.SetChildIndex(this.lblDeveloper, 0);
			this.Controls.SetChildIndex(this.txtDeveloper, 0);
			this.Controls.SetChildIndex(this.txtHisItem, 0);
			this.Controls.SetChildIndex(this.lblListTitle, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			((System.ComponentModel.ISupportInitialize)(this.grdCFMHis)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_CFM_History_Load(object sender, System.EventArgs e)
		{
			Init_Form();

			CFM_History_View();
		}

		private void Init_Form()
		{
			/*--------------------------------------------------*/ 
			/* SDC_CFM_SCH_HIS 관리 항목(14) : (Code) Item Name */ 
			/*--------------------------------------------------*/ 
			/*  (2):(SHIP_DATE)Ship Date,  (8):(CATEGORY)Category CD,       (10):(DEVELOPER)Developer,       (11):(SEPC_DATE)Spec Date, 
			/* 	(12):(SPEC_OK)Spec CFM,    (14):(SBOOK_DATE)SBook Date,     (15):(SBOOK_OK)SBook CFM,        (17):(CFM_DATE)CFMShoe Date, 
			/*	(18):(CFM_OK)CFMShoe CFM,  (19):(ASSY_DATE1)Assembly Date1, (20):(ASSY_DATE2)Assembly Date2, (21):(CFM_REMARK)CFM Remark 
			/*  (22):(CFM_REMARK_F)Factory Remark 
			/* - */
			/* INSERT SDC_CFM_SCH_HIS to changed Items */
			/* HISTORY ITEM:(VJ/QD)UPDATE->SHIP,ASSEMBLY/(DS)UPDATE->CATE,DEV,SPEC,SBOOK,CFM,REMARK,CLOSE(CFM) */
			/* - */  
			switch(txtHisItem.Text.ToString())
			{
				case "2":
					lbl_MainTitle.Text = "Shipping Date : CFM Shoe History";
					lblListTitle.Text  = "Shipping Date History List";
					txtHisItem.Text = "SHIP_DATE";
 					break;

				case "8": 
					lbl_MainTitle.Text = "Category : CFM Shoe History";
					lblListTitle.Text  = "Category History List";
					txtHisItem.Text = "CATEGORY";
 					break;

				case "10":
					lbl_MainTitle.Text = "Developer : CFM Shoe History";
					lblListTitle.Text  = "Developer History List";
					txtHisItem.Text = "DEVELOPER";
 					break;

				case "11": 
					lbl_MainTitle.Text = "Spec Date : CFM Shoe History";
					lblListTitle.Text  = "Spec Date History List";
					txtHisItem.Text = "SEPC_DATE";
 					break;

				case "12": 
					lbl_MainTitle.Text = "Spec Confirm : CFM Shoe History";
					lblListTitle.Text  = "Spec Confirm History List";
					txtHisItem.Text = "SPEC_OK";
 					break;

				case "14": 
					lbl_MainTitle.Text = "S/Book Date : CFM Shoe History";
					lblListTitle.Text  = "S/Book Date History List";
					txtHisItem.Text = "SBOOK_DATE";
 					break;
			
				case "15": 
					lbl_MainTitle.Text = "S/Book Confirm : CFM Shoe History";
					lblListTitle.Text  = "S/Book Confirm History List";
					txtHisItem.Text = "SBOOK_OK";
 					break;

				case "17": 
					lbl_MainTitle.Text = "CFM Shoe Date : CFM Shoe History";
					lblListTitle.Text  = "CFM Shoe Date History List";
					txtHisItem.Text = "CFM_DATE";
 					break;
			
				case "18": 
					lbl_MainTitle.Text = "CFM Shoe Confirm : CFM Shoe History";
					lblListTitle.Text  = "CFM Shoe Confirm History List";
					txtHisItem.Text = "CFM_OK";
 					break;
			
				case "19": 
					lbl_MainTitle.Text = "Assambly Date : CFM Shoe History";
					lblListTitle.Text  = "Assambly Date History List";
					txtHisItem.Text = "ASSY_DATE1";
 					break;

				case "20": 
					lbl_MainTitle.Text = "Assambly Date : CFM Shoe History";
					lblListTitle.Text  = "Assambly Date History List";
					txtHisItem.Text = "ASSY_DATE2";
 					break;

				case "21": 
					lbl_MainTitle.Text = "CDC Remark : CFM Shoe History";
					lblListTitle.Text  = "CDC Remark History List";
					txtHisItem.Text = "CFM_REMARK";
 					break;

				case "22": 
					lbl_MainTitle.Text = "Factory Remark : CFM Shoe History";
					lblListTitle.Text  = "Factory Remark History List";
					txtHisItem.Text = "CFM_REMARK_F";
					break;
			}

			//Set Grid grdCFM Head Title
			grdCFMHis.Set_Grid("SDC_CFM_SCH_HIS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			grdCFMHis.AutoSizeCols();
		}

		private void CFM_History_View()
		{
			DataTable vDT = Select_CFM_History();

			for(int i=0; i<vDT.Rows.Count; i++)
			{
				grdCFMHis.AddItem(vDT.Rows[i].ItemArray, grdCFMHis.Rows.Count, 1);
			}
		}

		private DataTable Select_CFM_History()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_HISTORY";

			OraDB.ReDim_Parameter(5);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_DPO_ID";
			OraDB.Parameter_Name[2] = "ARG_STYLE_NO";
			OraDB.Parameter_Name[3] = "ARG_ITEM";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = txtFactory.Text.ToString();
			OraDB.Parameter_Values[1] = txtDPO.Text.ToString();
			OraDB.Parameter_Values[2] = txtStyleNo.Text.ToString();
			OraDB.Parameter_Values[3] = txtHisItem.Text.ToString();
			OraDB.Parameter_Values[4] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}

