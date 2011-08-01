using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdOrder
{
	public class Form_PO_Lot_OA : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_T;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_OaNu;
		private System.Windows.Forms.Label lbl_OaNu;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo cmb_ToDate;
		private C1.Win.C1List.C1Combo cmb_FromDate;
		private System.Windows.Forms.Label lbl_Date;
		private System.Windows.Forms.Label btn_PopPgId;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label lbl_StyleCd;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Commit;
		private System.Windows.Forms.Label lbl_Model;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_Head;
		private System.Windows.Forms.Panel pnl_Detail;
		public System.Windows.Forms.Panel pnl_HeadTop;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle2;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.Label lbl_SubTitle3;
		private COM.FSP fgrid_Head;
		private COM.FSP fgrid_Detail;
		private System.Windows.Forms.ContextMenu cmenu_LOT_List;
		private System.Windows.Forms.Label lbl_OADivision;
		private System.Windows.Forms.RadioButton rad_Commit;
		private System.Windows.Forms.RadioButton rad_Cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_StyleInput;
		private System.Windows.Forms.TextBox txt_StyleInput; 
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Form_PO_Lot_OA()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PO_Lot_OA));
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            this.pnl_T = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_StyleInput = new System.Windows.Forms.TextBox();
            this.lbl_StyleInput = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Commit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ToDate = new C1.Win.C1List.C1Combo();
            this.cmb_FromDate = new C1.Win.C1List.C1Combo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Commit = new System.Windows.Forms.RadioButton();
            this.rad_Cancel = new System.Windows.Forms.RadioButton();
            this.lbl_OADivision = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.txt_Gen = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.lbl_StyleCd = new System.Windows.Forms.Label();
            this.cmb_OaNu = new C1.Win.C1List.C1Combo();
            this.lbl_OaNu = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_PopPgId = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.fgrid_Detail = new COM.FSP();
            this.cmenu_LOT_List = new System.Windows.Forms.ContextMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.fgrid_Head = new COM.FSP();
            this.pnl_HeadTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_T.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OaNu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).BeginInit();
            this.pnl_HeadTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink8,
            this.c1CommandLink7});
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // pnl_T
            // 
            this.pnl_T.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_T.Controls.Add(this.pnl_SearchImage);
            this.pnl_T.Location = new System.Drawing.Point(8, 4);
            this.pnl_T.Name = "pnl_T";
            this.pnl_T.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnl_T.Size = new System.Drawing.Size(342, 226);
            this.pnl_T.TabIndex = 43;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_StyleInput);
            this.pnl_SearchImage.Controls.Add(this.lbl_StyleInput);
            this.pnl_SearchImage.Controls.Add(this.btn_Cancel);
            this.pnl_SearchImage.Controls.Add(this.btn_Commit);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.cmb_ToDate);
            this.pnl_SearchImage.Controls.Add(this.cmb_FromDate);
            this.pnl_SearchImage.Controls.Add(this.groupBox1);
            this.pnl_SearchImage.Controls.Add(this.lbl_OADivision);
            this.pnl_SearchImage.Controls.Add(this.lbl_Model);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Gen);
            this.pnl_SearchImage.Controls.Add(this.txt_Model);
            this.pnl_SearchImage.Controls.Add(this.lbl_StyleCd);
            this.pnl_SearchImage.Controls.Add(this.cmb_OaNu);
            this.pnl_SearchImage.Controls.Add(this.lbl_OaNu);
            this.pnl_SearchImage.Controls.Add(this.lbl_Date);
            this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(342, 224);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_StyleInput
            // 
            this.txt_StyleInput.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StyleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleInput.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_StyleInput.Location = new System.Drawing.Point(111, 102);
            this.txt_StyleInput.MaxLength = 60;
            this.txt_StyleInput.Name = "txt_StyleInput";
            this.txt_StyleInput.Size = new System.Drawing.Size(223, 21);
            this.txt_StyleInput.TabIndex = 130;
            this.txt_StyleInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleInput_KeyUp);
            // 
            // lbl_StyleInput
            // 
            this.lbl_StyleInput.ImageIndex = 0;
            this.lbl_StyleInput.ImageList = this.img_Label;
            this.lbl_StyleInput.Location = new System.Drawing.Point(10, 102);
            this.lbl_StyleInput.Name = "lbl_StyleInput";
            this.lbl_StyleInput.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleInput.TabIndex = 129;
            this.lbl_StyleInput.Text = "Style";
            this.lbl_StyleInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(254, 195);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 124;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Commit
            // 
            this.btn_Commit.ImageIndex = 0;
            this.btn_Commit.ImageList = this.img_Button;
            this.btn_Commit.Location = new System.Drawing.Point(173, 195);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(80, 23);
            this.btn_Commit.TabIndex = 125;
            this.btn_Commit.Text = "Commit";
            this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Commit.Visible = false;
            this.btn_Commit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Commit.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "~";
            // 
            // cmb_ToDate
            // 
            this.cmb_ToDate.AddItemSeparator = ';';
            this.cmb_ToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ToDate.Caption = "";
            this.cmb_ToDate.CaptionHeight = 17;
            this.cmb_ToDate.CaptionStyle = style33;
            this.cmb_ToDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ToDate.ColumnCaptionHeight = 18;
            this.cmb_ToDate.ColumnFooterHeight = 18;
            this.cmb_ToDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ToDate.ContentHeight = 17;
            this.cmb_ToDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ToDate.EditorBackColor = System.Drawing.Color.White;
            this.cmb_ToDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ToDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ToDate.EditorHeight = 17;
            this.cmb_ToDate.EvenRowStyle = style34;
            this.cmb_ToDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ToDate.FooterStyle = style35;
            this.cmb_ToDate.HeadingStyle = style36;
            this.cmb_ToDate.HighLightRowStyle = style37;
            this.cmb_ToDate.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ToDate.Images"))));
            this.cmb_ToDate.ItemHeight = 15;
            this.cmb_ToDate.Location = new System.Drawing.Point(234, 58);
            this.cmb_ToDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_ToDate.MaxDropDownItems = ((short)(5));
            this.cmb_ToDate.MaxLength = 32767;
            this.cmb_ToDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ToDate.Name = "cmb_ToDate";
            this.cmb_ToDate.OddRowStyle = style38;
            this.cmb_ToDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ToDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ToDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ToDate.SelectedStyle = style39;
            this.cmb_ToDate.Size = new System.Drawing.Size(100, 21);
            this.cmb_ToDate.Style = style40;
            this.cmb_ToDate.TabIndex = 43;
            this.cmb_ToDate.SelectedValueChanged += new System.EventHandler(this.cmb_ToDate_SelectedValueChanged);
            this.cmb_ToDate.PropBag = resources.GetString("cmb_ToDate.PropBag");
            // 
            // cmb_FromDate
            // 
            this.cmb_FromDate.AddItemSeparator = ';';
            this.cmb_FromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_FromDate.Caption = "";
            this.cmb_FromDate.CaptionHeight = 17;
            this.cmb_FromDate.CaptionStyle = style41;
            this.cmb_FromDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_FromDate.ColumnCaptionHeight = 18;
            this.cmb_FromDate.ColumnFooterHeight = 18;
            this.cmb_FromDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_FromDate.ContentHeight = 17;
            this.cmb_FromDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_FromDate.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_FromDate.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FromDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_FromDate.EditorHeight = 17;
            this.cmb_FromDate.EvenRowStyle = style42;
            this.cmb_FromDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FromDate.FooterStyle = style43;
            this.cmb_FromDate.HeadingStyle = style44;
            this.cmb_FromDate.HighLightRowStyle = style45;
            this.cmb_FromDate.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_FromDate.Images"))));
            this.cmb_FromDate.ItemHeight = 15;
            this.cmb_FromDate.Location = new System.Drawing.Point(111, 58);
            this.cmb_FromDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_FromDate.MaxDropDownItems = ((short)(5));
            this.cmb_FromDate.MaxLength = 32767;
            this.cmb_FromDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_FromDate.Name = "cmb_FromDate";
            this.cmb_FromDate.OddRowStyle = style46;
            this.cmb_FromDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_FromDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_FromDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_FromDate.SelectedStyle = style47;
            this.cmb_FromDate.Size = new System.Drawing.Size(100, 21);
            this.cmb_FromDate.Style = style48;
            this.cmb_FromDate.TabIndex = 36;
            this.cmb_FromDate.SelectedValueChanged += new System.EventHandler(this.cmb_FromDate_SelectedValueChanged);
            this.cmb_FromDate.PropBag = resources.GetString("cmb_FromDate.PropBag");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Commit);
            this.groupBox1.Controls.Add(this.rad_Cancel);
            this.groupBox1.Location = new System.Drawing.Point(111, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 27);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            // 
            // rad_Commit
            // 
            this.rad_Commit.Checked = true;
            this.rad_Commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Commit.Location = new System.Drawing.Point(8, 8);
            this.rad_Commit.Name = "rad_Commit";
            this.rad_Commit.Size = new System.Drawing.Size(96, 16);
            this.rad_Commit.TabIndex = 128;
            this.rad_Commit.TabStop = true;
            this.rad_Commit.Text = "OA Commit";
            this.rad_Commit.Click += new System.EventHandler(this.rad_Click);
            this.rad_Commit.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Cancel
            // 
            this.rad_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Cancel.Location = new System.Drawing.Point(128, 8);
            this.rad_Cancel.Name = "rad_Cancel";
            this.rad_Cancel.Size = new System.Drawing.Size(90, 16);
            this.rad_Cancel.TabIndex = 129;
            this.rad_Cancel.Text = "OA Cancel";
            this.rad_Cancel.Click += new System.EventHandler(this.rad_Click);
            this.rad_Cancel.CursorChanged += new System.EventHandler(this.rad_CheckedChanged);
            this.rad_Cancel.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // lbl_OADivision
            // 
            this.lbl_OADivision.ImageIndex = 0;
            this.lbl_OADivision.ImageList = this.img_Label;
            this.lbl_OADivision.Location = new System.Drawing.Point(10, 80);
            this.lbl_OADivision.Name = "lbl_OADivision";
            this.lbl_OADivision.Size = new System.Drawing.Size(100, 21);
            this.lbl_OADivision.TabIndex = 127;
            this.lbl_OADivision.Text = "Job Division";
            this.lbl_OADivision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Model
            // 
            this.lbl_Model.ImageIndex = 0;
            this.lbl_Model.ImageList = this.img_Label;
            this.lbl_Model.Location = new System.Drawing.Point(10, 146);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(100, 21);
            this.lbl_Model.TabIndex = 126;
            this.lbl_Model.Text = "Model";
            this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Style.Location = new System.Drawing.Point(111, 168);
            this.txt_Style.MaxLength = 60;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.ReadOnly = true;
            this.txt_Style.Size = new System.Drawing.Size(100, 21);
            this.txt_Style.TabIndex = 112;
            // 
            // txt_Gen
            // 
            this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Gen.Location = new System.Drawing.Point(212, 168);
            this.txt_Gen.MaxLength = 60;
            this.txt_Gen.Name = "txt_Gen";
            this.txt_Gen.ReadOnly = true;
            this.txt_Gen.Size = new System.Drawing.Size(36, 21);
            this.txt_Gen.TabIndex = 111;
            // 
            // txt_Model
            // 
            this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Model.Location = new System.Drawing.Point(111, 146);
            this.txt_Model.MaxLength = 60;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.ReadOnly = true;
            this.txt_Model.Size = new System.Drawing.Size(223, 21);
            this.txt_Model.TabIndex = 110;
            // 
            // lbl_StyleCd
            // 
            this.lbl_StyleCd.ImageIndex = 0;
            this.lbl_StyleCd.ImageList = this.img_Label;
            this.lbl_StyleCd.Location = new System.Drawing.Point(10, 168);
            this.lbl_StyleCd.Name = "lbl_StyleCd";
            this.lbl_StyleCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleCd.TabIndex = 63;
            this.lbl_StyleCd.Text = "Style (Select)";
            this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OaNu
            // 
            this.cmb_OaNu.AddItemSeparator = ';';
            this.cmb_OaNu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OaNu.Caption = "";
            this.cmb_OaNu.CaptionHeight = 17;
            this.cmb_OaNu.CaptionStyle = style49;
            this.cmb_OaNu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OaNu.ColumnCaptionHeight = 18;
            this.cmb_OaNu.ColumnFooterHeight = 18;
            this.cmb_OaNu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OaNu.ContentHeight = 17;
            this.cmb_OaNu.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OaNu.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OaNu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OaNu.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OaNu.EditorHeight = 17;
            this.cmb_OaNu.EvenRowStyle = style50;
            this.cmb_OaNu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OaNu.FooterStyle = style51;
            this.cmb_OaNu.HeadingStyle = style52;
            this.cmb_OaNu.HighLightRowStyle = style53;
            this.cmb_OaNu.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OaNu.Images"))));
            this.cmb_OaNu.ItemHeight = 15;
            this.cmb_OaNu.Location = new System.Drawing.Point(111, 124);
            this.cmb_OaNu.MatchEntryTimeout = ((long)(2000));
            this.cmb_OaNu.MaxDropDownItems = ((short)(5));
            this.cmb_OaNu.MaxLength = 32767;
            this.cmb_OaNu.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OaNu.Name = "cmb_OaNu";
            this.cmb_OaNu.OddRowStyle = style54;
            this.cmb_OaNu.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OaNu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OaNu.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OaNu.SelectedStyle = style55;
            this.cmb_OaNu.Size = new System.Drawing.Size(223, 21);
            this.cmb_OaNu.Style = style56;
            this.cmb_OaNu.TabIndex = 46;
            this.cmb_OaNu.SelectedValueChanged += new System.EventHandler(this.cmb_OaNu_SelectedValueChanged);
            this.cmb_OaNu.PropBag = resources.GetString("cmb_OaNu.PropBag");
            // 
            // lbl_OaNu
            // 
            this.lbl_OaNu.ImageIndex = 0;
            this.lbl_OaNu.ImageList = this.img_Label;
            this.lbl_OaNu.Location = new System.Drawing.Point(10, 124);
            this.lbl_OaNu.Name = "lbl_OaNu";
            this.lbl_OaNu.Size = new System.Drawing.Size(100, 21);
            this.lbl_OaNu.TabIndex = 45;
            this.lbl_OaNu.Text = "OA";
            this.lbl_OaNu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Date
            // 
            this.lbl_Date.ImageIndex = 0;
            this.lbl_Date.ImageList = this.img_Label;
            this.lbl_Date.Location = new System.Drawing.Point(10, 58);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(100, 21);
            this.lbl_Date.TabIndex = 35;
            this.lbl_Date.Text = "DPO";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_PopPgId
            // 
            this.btn_PopPgId.Location = new System.Drawing.Point(412, 36);
            this.btn_PopPgId.Name = "btn_PopPgId";
            this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
            this.btn_PopPgId.TabIndex = 34;
            this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style57;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style58;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style59;
            this.cmb_Factory.HeadingStyle = style60;
            this.cmb_Factory.HighLightRowStyle = style61;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style62;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style63;
            this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
            this.cmb_Factory.Style = style64;
            this.cmb_Factory.TabIndex = 33;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 32;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(327, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(15, 184);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(326, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 32);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(118, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      OA Information";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(326, 208);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(144, 206);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(182, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 204);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 184);
            this.picb_ML.TabIndex = 25;
            this.picb_ML.TabStop = false;
            // 
            // picb_MM
            // 
            this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
            this.picb_MM.Location = new System.Drawing.Point(160, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(174, 184);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Sizer1.Controls.Add(this.pnl_Detail);
            this.c1Sizer1.Controls.Add(this.pnl_Head);
            this.c1Sizer1.Controls.Add(this.pnl_T);
            this.c1Sizer1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Sizer1.GridDefinition = "14.9305555555556:False:True;23.6111111111111:False:True;58.6805555555556:False:Fa" +
                "lse;\t0:False:False;33.6614173228346:False:True;64.3700787401575:False:False;0:Fa" +
                "lse:False;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.Controls.Add(this.fgrid_Detail);
            this.pnl_Detail.Controls.Add(this.panel1);
            this.pnl_Detail.Location = new System.Drawing.Point(8, 234);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(1004, 338);
            this.pnl_Detail.TabIndex = 45;
            // 
            // fgrid_Detail
            // 
            this.fgrid_Detail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Detail.ContextMenu = this.cmenu_LOT_List;
            this.fgrid_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Detail.Location = new System.Drawing.Point(0, 32);
            this.fgrid_Detail.Name = "fgrid_Detail";
            this.fgrid_Detail.Rows.DefaultSize = 19;
            this.fgrid_Detail.Size = new System.Drawing.Size(1004, 306);
            this.fgrid_Detail.StyleInfo = resources.GetString("fgrid_Detail.StyleInfo");
            this.fgrid_Detail.TabIndex = 21;
            // 
            // cmenu_LOT_List
            // 
            this.cmenu_LOT_List.Popup += new System.EventHandler(this.cmenu_LOT_List_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lbl_SubTitle3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 32);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(988, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 32);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(224, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(780, 32);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_SubTitle3
            // 
            this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
            this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle3.Name = "lbl_SubTitle3";
            this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle3.TabIndex = 28;
            this.lbl_SubTitle3.Text = "      Size Quantity Information";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Head
            // 
            this.pnl_Head.Controls.Add(this.fgrid_Head);
            this.pnl_Head.Controls.Add(this.pnl_HeadTop);
            this.pnl_Head.Location = new System.Drawing.Point(354, 4);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(654, 226);
            this.pnl_Head.TabIndex = 44;
            // 
            // fgrid_Head
            // 
            this.fgrid_Head.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Head.Location = new System.Drawing.Point(0, 32);
            this.fgrid_Head.Name = "fgrid_Head";
            this.fgrid_Head.Rows.DefaultSize = 19;
            this.fgrid_Head.Size = new System.Drawing.Size(654, 194);
            this.fgrid_Head.StyleInfo = resources.GetString("fgrid_Head.StyleInfo");
            this.fgrid_Head.TabIndex = 43;
            // 
            // pnl_HeadTop
            // 
            this.pnl_HeadTop.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_HeadTop.Controls.Add(this.pictureBox2);
            this.pnl_HeadTop.Controls.Add(this.pictureBox3);
            this.pnl_HeadTop.Controls.Add(this.lbl_SubTitle2);
            this.pnl_HeadTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_HeadTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_HeadTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_HeadTop.Name = "pnl_HeadTop";
            this.pnl_HeadTop.Size = new System.Drawing.Size(654, 32);
            this.pnl_HeadTop.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(638, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(430, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_SubTitle2
            // 
            this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
            this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle2.Name = "lbl_SubTitle2";
            this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle2.TabIndex = 28;
            this.lbl_SubTitle2.Text = "      Total Quantity";
            this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_PO_Lot_OA
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_PO_Lot_OA";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_T.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_FromDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OaNu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Detail)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Head)).EndInit();
            this.pnl_HeadTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의


		private COM.OraDB MyOraDB = new COM.OraDB();  


		// request 표시 행
		private string _ViewLevel_SizeBefore = "1";
		private string _ViewLevel_SizeBeforeLoss = "2";
		private string _ViewLevel_Released = "3";
		//private string _ViewLevel_SizeAfter = "4";
		private string _ViewLevel_Balance = "5";
 
		// LOT 번호 할당 되어 있지 않은 경우
		private string _SignLOTNull = "_";

		// 대표 LOT (맨 처음 할당되는 LOT) 기억
		private string _DefaultLOT = "";
 


		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			try
			{

                // Title 
                this.Text = "Order Adjustment to LOT";
                this.lbl_MainTitle.Text = "Order Adjustment to LOT";
                ClassLib.ComFunction.SetLangDic(this);


				  
				fgrid_Head.Set_Grid("SPO_LOT_OA_HEAD", "1", 2, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, true); 
				fgrid_Head.Styles.Alternate.BackColor = Color.White; 
				fgrid_Head.Font = new Font("Verdana", 7);
				fgrid_Head.ExtendLastCol = false;
				fgrid_Head.AllowEditing = false;

				fgrid_Detail.Set_Grid("SPO_LOT_OA_DETAIL", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForSearch, false);  
				fgrid_Detail.Styles.Alternate.BackColor = Color.White; 
				fgrid_Detail.Font = new Font("Verdana", 7);
				fgrid_Detail.ExtendLastCol = false;
				fgrid_Detail.AllowEditing = false;


				Init_Control();



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			 
		}



		/// <summary>
		/// 
		/// </summary>
		private void Init_Control()
		{

//			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false; 
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false; 
			 
			cmenu_LOT_List.MenuItems.Clear();

//			btn_Commit.Enabled = false;
//			btn_Cancel.Enabled = false;


            //rad_Commit.Checked = true;





			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			dt_ret.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;   


		} 
		
 

		/// <summary>
		/// Set_ContextMenu_LOT_List : set contextmenu - lot list
		/// </summary>
		private void Set_ContextMenu_LOT_List()
		{

			cmenu_LOT_List.MenuItems.Clear();



			string factory = cmb_Factory.SelectedValue.ToString();
			//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
			string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
			string oa_nu = cmb_OaNu.Columns[4].Text;

			DataTable dt_ret = Select_SPO_LOT_OA_LOT_LIST(factory, style_cd, oa_nu);


			if(dt_ret.Rows.Count == 0) return;

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				cmenu_LOT_List.MenuItems.Add(dt_ret.Rows[i].ItemArray[0].ToString()); 
				cmenu_LOT_List.MenuItems[cmenu_LOT_List.MenuItems.Count - 1].Click += new EventHandler(ContextMenu_Click);

			} // end for i

		}


		


		#endregion 

		#region 조회
 
 


		#endregion 

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			if(cmb_FromDate.ListCount != 0) cmb_FromDate.SelectedIndex = 0;
			if(cmb_ToDate.ListCount != 0) cmb_ToDate.SelectedIndex = 0;
			cmb_OaNu.SelectedIndex = -1;
			txt_Model.Text = "";
			txt_Style.Text = "";
			txt_Gen.Text = "";

			fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
			fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;  

		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{ 
			

			try
			{

				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1 || cmb_OaNu.SelectedIndex == -1) return;



				_DefaultLOT = "";


				//-----------------------------------------------------------------------------------------------
				//set contextmenu - lot list
				//-----------------------------------------------------------------------------------------------
				Set_ContextMenu_LOT_List();
				//----------------------------------------------------------------------------------------------- 



				//-----------------------------------------------------------------------------------------------
				// head 조회
				//-----------------------------------------------------------------------------------------------
				string factory = cmb_Factory.SelectedValue.ToString();
				//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
				string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
				string oa_nu = cmb_OaNu.Columns[4].Text;

				DataTable dt_ret = Select_SPO_LOT_OA_HEAD(factory, style_cd, oa_nu);

				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed; 

				if(dt_ret.Rows.Count == 0) return;

				Display_Head(dt_ret);
				//-----------------------------------------------------------------------------------------------

			

				//-----------------------------------------------------------------------------------------------
				// detail 표시
				//-----------------------------------------------------------------------------------------------
				// 사이즈 헤더 할당 
				fgrid_Detail.Rows.Count = 2;
				ClassLib.ComFunction.Set_DefaultSize_Head(fgrid_Detail, 
															factory, 
															txt_Gen.Text.Trim(), 
															fgrid_Detail.Rows.Fixed,
															(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN,
															(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE_START);


				dt_ret = Select_SPO_LOT_OA_DETAIL(factory, style_cd, oa_nu);
 
				if(dt_ret.Rows.Count == 0) return;

				Display_Detail(dt_ret);
				Display_Detail_Other();
				//-----------------------------------------------------------------------------------------------



				//-----------------------------------------------------------------------------------------------
				// balance 표시
				//-----------------------------------------------------------------------------------------------
				Display_Balance();
				//-----------------------------------------------------------------------------------------------

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}



		#region 조회

		/// <summary>
		/// Display_Head : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Head(DataTable arg_dt)
		{


			fgrid_Head.Display_Grid(arg_dt, true);

			//--------------------------------------------------------------
			// subtotal 
			fgrid_Head.Subtotal(AggregateEnum.Clear);
			fgrid_Head.SubtotalPosition = SubtotalPositionEnum.BelowData;
			fgrid_Head.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_Head.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
 

			fgrid_Head.Subtotal(AggregateEnum.Sum, 1, -1, (int)ClassLib.TBSPO_LOT_OA_HEAD.IxTOT_QTY_B, "");
			fgrid_Head.Subtotal(AggregateEnum.Sum, 1, -1, (int)ClassLib.TBSPO_LOT_OA_HEAD.IxTOT_QTY_A, "");
			//-----------------------------------------------------------------------------------------------
			 


		}


		/// <summary>
		/// Display_Detail :
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Detail(DataTable arg_dt)
		{

			string before_item = "", now_item = ""; 
			int gen_row = 0;   
			string sel_gen = "";
			int insert_row = 0;
			int min_size_col = fgrid_Detail.Cols.Count + 1;   
			int size_qty = 0, sum_size_qty = 0;
 
  

			fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;

			if(arg_dt.Rows.Count == 0) return;  
			

			

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG - 1].ToString()
							+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION - 1].ToString();
				  

					 

				if(before_item != now_item)
				{ 


					fgrid_Detail.Rows.Add();
					fgrid_Detail.Rows.Add();
					fgrid_Detail.Rows.Add();
					fgrid_Detail.Rows.Add();
					fgrid_Detail.Rows.Add();

								
					//default data setting
					for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN; j++)
					{
						fgrid_Detail[fgrid_Detail.Rows.Count - 5, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
						fgrid_Detail[fgrid_Detail.Rows.Count - 4, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
						fgrid_Detail[fgrid_Detail.Rows.Count - 3, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
						fgrid_Detail[fgrid_Detail.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
						fgrid_Detail[fgrid_Detail.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
					}
 					 

//					string factory = cmb_Factory.SelectedValue.ToString();
//					//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
//					string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
//					string oa_nu = cmb_OaNu.Columns[4].Text;



					// 조회된 OA 만 처리되도록
					if(fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString().Trim()
						!= cmb_OaNu.Columns[4].Text.Trim() )
					{
						fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
						fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
						fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
						fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
						fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
					}




					// 대표 LOT 설정
					if(_DefaultLOT.Trim().Equals("") )
					{
						if(fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString() != _SignLOTNull)
						{
							_DefaultLOT = fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString();
						}
					} // end if



					fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_SizeBefore;
					fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "size (before)";
					fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
					fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
					//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 5].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;


					fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_SizeBeforeLoss;
					fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "loss (before)";
					fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
					fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
					//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 4].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;


					fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_Released;
					fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "released";
					fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
					fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
					//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 3].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd; 


					fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 2].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;


					fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_Balance;
					fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "balance";
					fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
					fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
					fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant; 
					fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
					
 					  

					insert_row = fgrid_Detail.Rows.Count - 2;

 
					//--------------------------------------------------------------------------------------------------------
					//gen
					for(int j = 1; j <= fgrid_Detail.Rows.Fixed; j++)
					{
						if(fgrid_Detail[j, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Detail[gen_row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN].ToString();

							break;
						} 
					}
					//-------------------------------------------------------------------------------------------------------- 


					before_item = now_item; 

					sum_size_qty = 0;
					

				}



				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE_START; j < fgrid_Detail.Cols.Count; j++)
				{
					if(fgrid_Detail[gen_row, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxSIZE_QTY - 1].ToString()); 
						fgrid_Detail[insert_row, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_Detail[insert_row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = sum_size_qty.ToString();




			} // end for i 
			



			//--------------------------------------------------------------
			//Merge 속성 
			fgrid_Detail.AllowMerging = AllowMergingEnum.Free; 
			
			for(int i = 0; i < fgrid_Detail.Cols.Count; i++) 
			{
				fgrid_Detail.Cols[i].AllowMerging = false; 
			}
 
			for(int i = 1; i < (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION; i++)
			{ 
                fgrid_Detail.Cols[i].AllowMerging = true;
			}

			 

			//--------------------------------------------------------------
			//기타 속성 
			fgrid_Detail.LeftCol = min_size_col;



		}



		/// <summary>
		/// Display_Detail_Other : 
		/// </summary>
		private void Display_Detail_Other()
		{


			string factory = cmb_Factory.SelectedValue.ToString();
			//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
			string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
			string oa_nu = cmb_OaNu.Columns[4].Text; 

			DataSet ds_ret = Select_SPO_LOT_OA_DETAIL_OTHER(factory, style_cd, oa_nu);

			DataTable dt_ret_b = ds_ret.Tables[0];
			DataTable dt_ret_bl = ds_ret.Tables[1];
			DataTable dt_ret_r = ds_ret.Tables[2];
			
			Display_Detail_Other(dt_ret_b, _ViewLevel_SizeBefore); 
			Display_Detail_Other(dt_ret_bl, _ViewLevel_SizeBeforeLoss); 
			Display_Detail_Other(dt_ret_r, _ViewLevel_Released);


		}



		/// <summary>
		/// Display_Detail_Other : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_viewlevel"></param>
		private void Display_Detail_Other(DataTable arg_dt, string arg_viewlevel)
		{

			int gen_row = 0;   
			string sel_gen = "";

			string before_item = "", now_item = ""; 
			string req_no = "";

			int findrow_req = -1;
			int findrow_view = -1;
			int insert_row = 0; 
			int min_size_col = fgrid_Detail.Cols.Count + 1;   
			int size_qty = 0, sum_size_qty = 0;


			if(arg_dt.Rows.Count == 0) return;   
			

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				now_item = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT - 1].ToString()
					+ arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO - 1].ToString();
				  

				if(before_item != now_item)
				{

					req_no = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO - 1].ToString();

					// find req_no
					findrow_req = fgrid_Detail.FindRow(req_no, fgrid_Detail.Rows.Fixed, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO, false, true, false);


					// after req_no 가 before req_no 갯수보다 같거나 많기 때문에 
					// after 을 먼저 표시하므로 before 의 req_no 가 없을 가능성은 없음
					#region if(findrow_req == -1)


//					if(findrow_req == -1)
//					{
//
//
//						fgrid_Detail.Rows.Add();
//					    fgrid_Detail.Rows.Add();
//						fgrid_Detail.Rows.Add();
//						fgrid_Detail.Rows.Add();
//						fgrid_Detail.Rows.Add();
//
//								
//						//default data setting
//						for(int j = 1; j <= (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN; j++)
//						{
//							fgrid_Detail[fgrid_Detail.Rows.Count - 5, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
//							fgrid_Detail[fgrid_Detail.Rows.Count - 4, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
//							fgrid_Detail[fgrid_Detail.Rows.Count - 3, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
//							fgrid_Detail[fgrid_Detail.Rows.Count - 2, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
//							fgrid_Detail[fgrid_Detail.Rows.Count - 1, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
//						}
// 					 
//
////					string factory = cmb_Factory.SelectedValue.ToString();
////					//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
////					string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
////					string oa_nu = cmb_OaNu.Columns[4].Text;
//
//
//
//						// 조회된 OA 만 처리되도록
//						if(fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString().Trim()
//							!= cmb_OaNu.Columns[4].Text.Trim() )
//						{
//							fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
//							fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
//							fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
//							fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
//							fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] = "_";
//						}
//
//
//
//
//						// 대표 LOT 설정
//						if(_DefaultLOT.Trim().Equals("") )
//						{
//							if(fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString() != _SignLOTNull)
//							{
//								_DefaultLOT = fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString();
//							}
//						} // end if
//
//
//
//						fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_SizeBefore;
//						fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "size (before)";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 5, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
//						//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 5].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
//
//
//						fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_SizeBeforeLoss;
//						fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "loss (before)";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 4, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
//						//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 4].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
//
//
//						fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_Released;
//						fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "released";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
//						//fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 3].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd; 
//
//						fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_SizeBefore;
//						fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "size (after)";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 2, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = ""; 
//						fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 2].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
//
//
//						fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL] = _ViewLevel_Balance;
//						fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxDESCRIPTION] = "balance";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] = "";
//						fgrid_Detail[fgrid_Detail.Rows.Count - 1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = "";
//						fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrImportant; 
//						fgrid_Detail.Rows[fgrid_Detail.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
//					
// 					  
//
//						findrow_req = fgrid_Detail.Rows.Count - 4;
//
//
//
//					} // end if(findrow_req == -1)
//

					#endregion

					if(findrow_req == -1) continue;

					// find view level
					findrow_view = fgrid_Detail.FindRow(arg_viewlevel, findrow_req, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL, false, true, false);
					

					insert_row = findrow_view;

					fgrid_Detail[insert_row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU]
						= arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU - 1].ToString();




					//-------------------------------------------------------------------------------------------------------- 
					//gen
					for(int j = 1; j <= fgrid_Detail.Rows.Fixed; j++)
					{
						if(fgrid_Detail[j, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN - 1].ToString())
						{
							gen_row = j;
							sel_gen = sel_gen + "/" + fgrid_Detail[gen_row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxGEN].ToString();

							break;
						} 
					}
					//-------------------------------------------------------------------------------------------------------- 


					
					before_item = now_item; 


					sum_size_qty = 0;

					

				}



				//--------------------------------------------------------------

				for(int j = (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE_START; j < fgrid_Detail.Cols.Count; j++)
				{
					if(fgrid_Detail[gen_row, j].ToString() == arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE - 1].ToString())
					{
						min_size_col = (min_size_col > j) ? j : min_size_col;

						size_qty = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_LOT_OA_DETAIL.IxSIZE_QTY - 1].ToString()); 
						fgrid_Detail[insert_row, j] = (size_qty.ToString() == "0") ? "" : size_qty.ToString();

						sum_size_qty += size_qty;
						

						break; 
					} 
				}
  


				fgrid_Detail[insert_row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = sum_size_qty.ToString();

 

			} // end for i






		}



		/// <summary>
		/// Display_Balance : 
		/// </summary>
		private void Display_Balance()
		{

			if(fgrid_Detail.Rows.Count <= fgrid_Detail.Rows.Fixed) return;



			string view_level = "";
			int row_released = 0;
			int row_after = 0;
			int qty_released = 0;
			int qty_after = 0;
			int sum_qty = 0;


			for(int i = fgrid_Detail.Rows.Fixed; i < fgrid_Detail.Rows.Count; i++)
			{
				
				view_level = fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL].ToString();

				if(view_level != _ViewLevel_Balance) continue;


				row_released = i - 2;
				row_after = i - 1;


				for(int j = (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE_START; j < fgrid_Detail.Cols.Count; j++)
				{
					
					// releaed quantity
					if(fgrid_Detail[row_released, j] == null || fgrid_Detail[row_released, j].ToString() == "")
					{
						qty_released = 0;
					}
					else
					{
						qty_released = Convert.ToInt32(fgrid_Detail[row_released, j].ToString() );
					}


					// after size quantity
					if(fgrid_Detail[row_after, j] == null || fgrid_Detail[row_after, j].ToString() == "")
					{
						qty_after = 0;
					}
					else
					{
						qty_after = Convert.ToInt32(fgrid_Detail[row_after, j].ToString() );
					}


					//
					if(qty_after >= qty_released) continue;

					fgrid_Detail[i, j] = Convert.ToString( Math.Abs(qty_released - qty_after) ); // 양수화

					sum_qty += Math.Abs(qty_released - qty_after);


				} // end for j


				fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxORDER_QTY] = sum_qty.ToString();
				
				sum_qty = 0;


			} // end for i


		}



		#endregion


 
		private void Event_Tbtn_Save()
		{

			if(rad_Commit.Checked)
			{
				Event_Click_btn_Commit();
			}
			else if(rad_Cancel.Checked)
			{
				Event_Click_btn_Cancel();
			}


		}





		#endregion

		#region 그리드 이벤트 메서드

 

		#endregion

		#region 버튼 및 기타 이벤트 메서드
 

		/// <summary>
		/// Event_Click_btn_Commit : 
		/// </summary>
		private void Event_Click_btn_Commit()
		{


			//---------------------------------------------------------------------------------
			// check condition oa commit
			//---------------------------------------------------------------------------------
			string factory = cmb_Factory.SelectedValue.ToString(); 
			//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu 
			string obs_id = cmb_OaNu.Columns[0].Text;
			string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
			string oa_nu = cmb_OaNu.Columns[4].Text;

			bool create_ok_yn = Check_CONDITION_OA_COMMIT(factory, obs_id, style_cd, oa_nu);

			if(! create_ok_yn)
			{
				string message = "Style : " + cmb_OaNu.Columns[2].Text + "\r\n\r\n" + "Is possible though all move OAs are confirmed." + "\r\n" + "so can't oa commit.";
				ClassLib.ComFunction.User_Message(message, "Check condition oa commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			//---------------------------------------------------------------------------------




			DialogResult result = ClassLib.ComFunction.Data_Message("Commit", ClassLib.ComVar.MgsChooseRun, this);

			if(result == DialogResult.No) return;


			// 계산값에 의해서 balance를 할당하고, 사용자 입력 부분이 없으므로 수량 검증 생략
			bool run_flag = Run_SPO_LOT_OA_COMMIT();

			if(! run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
  
 
				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = ""; 

				Set_cmb_OaNu();
				Event_Tbtn_Search(); 


			}



		} 



		/// <summary>
		/// Event_Click_btn_Cancel : 
		/// </summary>
		private void Event_Click_btn_Cancel()
		{
 

			//---------------------------------------------------------------------------------
			// check condition oa cancel
			//---------------------------------------------------------------------------------
			string factory = cmb_Factory.SelectedValue.ToString(); 
			//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu 
			string obs_id = cmb_OaNu.Columns[0].Text;
			string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
			string oa_nu = cmb_OaNu.Columns[4].Text;

			bool del_ok_yn = Check_CONDITION_OA_CANCEL(factory, obs_id, style_cd, oa_nu);

			if(! del_ok_yn)
			{
				string message = "Style : " + cmb_OaNu.Columns[2].Text + "\r\n\r\n" + "Is possible though all after this OAs are canceled." + "\r\n" + "so can't oa cancel.";
				ClassLib.ComFunction.User_Message(message, "Check condition oa cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			//---------------------------------------------------------------------------------

			DialogResult result = ClassLib.ComFunction.Data_Message("Cancel", ClassLib.ComVar.MgsChooseRun, this);

			if(result == DialogResult.No) return;




			bool run_flag = Run_SPO_LOT_OA_CANCEL();

			if(! run_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
  

				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = ""; 

				Set_cmb_OaNu();
				Event_Tbtn_Search(); 


			}



		}


		/// <summary>
		/// Set_cmb_OaNu :  
		/// </summary>
		private void Set_cmb_OaNu()
		{


			if(cmb_Factory.SelectedIndex == -1 || cmb_FromDate.SelectedIndex == -1 || cmb_ToDate.SelectedIndex == -1) return;
 

			cmb_OaNu.ClearItems();
			cmb_OaNu.SelectedIndex = -1;


			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id_from = cmb_FromDate.SelectedValue.ToString();
			string obs_id_to = cmb_ToDate.SelectedValue.ToString();
			string style_cd = txt_StyleInput.Text.Replace("-", "");
			string oa_job_div = (rad_Commit.Checked) ? "C" : "X";  // C : Conmmit, X : Cancel

			DataTable dt_ret = Select_SPO_RECV_OANU_COMBO(factory, obs_id_from, obs_id_to, style_cd, oa_job_div);
			//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
			//ClassLib.ComCtl.Set_ComboList_Multi(dt_ret, cmb_OaNu, new int[]{0, 1, 2, 3, 4}, false); 

			ClassLib.ComCtl.Set_ComboList_AddItem_Multi(dt_ret, cmb_OaNu, new int[]{0, 1, 2, 3, 4}, false);
			string[] cmb_titles = new string[] {"DPO", "Model", "Style", "Gen", "OA"};
			int[] cmb_width = new int[] {60, 80, 90, 32, 92};
			bool[] cmb_visible = new bool[] {false, true, true, true, true}; 

			ClassLib.ComCtl.SetComboStyle(cmb_OaNu, cmb_titles, cmb_width, cmb_visible, "OA"); 


			dt_ret.Dispose();


		}



		#endregion
 
		#region 컨텍스트 메뉴 이벤트 메서드
 

		#endregion

		#endregion 

		#region 이벤트 처리
 

		#region 툴바 이벤트


		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
 

		#endregion

		#region 그리드 이벤트
		 


		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

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

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
  
				if (cmb_Factory.SelectedIndex == -1) return;

				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed; 

				DataTable dt_ret = ClassLib.ComFunction.Select_DPO(cmb_Factory.SelectedValue.ToString(), "P");  
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_FromDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code); 
				//ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ToDate, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  
				
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_FromDate, 0, 0);
				cmb_FromDate.Splits[0].DisplayColumns[0].Width = cmb_FromDate.Width;
				cmb_FromDate.Splits[0].DisplayColumns[1].Width = 0;
				
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_ToDate, 0, 0);
				cmb_ToDate.Splits[0].DisplayColumns[0].Width = cmb_ToDate.Width;
				cmb_ToDate.Splits[0].DisplayColumns[1].Width = 0;


				dt_ret.Dispose();

				if(cmb_FromDate.ListCount != 0) cmb_FromDate.SelectedIndex = 0;



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_FromDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = ""; 
 
				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed; 
 
				if(cmb_FromDate.SelectedIndex == -1) return;
				cmb_ToDate.SelectedValue = cmb_FromDate.SelectedValue.ToString(); 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_FromDate_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_ToDate_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
			 
				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = "";

				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;  

				
				Set_cmb_OaNu();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ToDate_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



        private void rad_CheckedChanged(object sender, System.EventArgs e)
        {

            //try
            //{

            //    txt_Model.Text = "";
            //    txt_Style.Text = "";
            //    txt_Gen.Text = "";

            //    fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
            //    fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;


            //    Set_cmb_OaNu();

            //}
            //catch (Exception ex)
            //{
            //    ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        private void rad_Click(object sender, System.EventArgs e)
        {

            try
            {

                RadioButton src = sender as RadioButton;
                src.Checked = true;


                txt_Model.Text = "";
                txt_Style.Text = "";
                txt_Gen.Text = "";

                fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
                fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;


                Set_cmb_OaNu();

            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        } 

		private void txt_StyleInput_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{ 

				if(e.KeyCode != Keys.Enter) return;

				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = "";

				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed;  

				
				Set_cmb_OaNu();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleInput_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		private void cmb_OaNu_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
			 
				txt_Model.Text = "";
				txt_Style.Text = "";
				txt_Gen.Text = "";

				fgrid_Head.Rows.Count = fgrid_Head.Rows.Fixed;
				fgrid_Detail.Rows.Count = fgrid_Detail.Rows.Fixed; 

				if(cmb_Factory.SelectedIndex == -1 
					|| cmb_FromDate.SelectedIndex == -1 
					|| cmb_ToDate.SelectedIndex == -1
					|| cmb_OaNu.SelectedIndex == -1) return;
 
				
				//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu
				txt_Model.Text = cmb_OaNu.Columns[1].Text;
				txt_Style.Text = cmb_OaNu.Columns[2].Text;
				txt_Gen.Text = cmb_OaNu.Columns[3].Text;



				//display grid
				Event_Tbtn_Search();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OaNu_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void btn_Commit_Click(object sender, System.EventArgs e)
		{

			try
			{
				Event_Click_btn_Commit();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Commit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_Click_btn_Cancel();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion  

		#region 컨텍스트 메뉴 이벤트
 


		private void cmenu_LOT_List_Popup(object sender, System.EventArgs e)
		{
		
			if(fgrid_Detail.Rows.Count <= fgrid_Detail.Rows.Fixed
				|| fgrid_Detail.Selection.c1 != (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO)
			{
				
				for(int i = 0; i < cmenu_LOT_List.MenuItems.Count; i++)
				{
					cmenu_LOT_List.MenuItems[i].Visible = false;
				} // end for i

			}
			else
			{

				string lot = fgrid_Detail[fgrid_Detail.Selection.r1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT_OLD].ToString();

				if(lot.Trim().Equals(_SignLOTNull) )  // LOT 선택할 수 있음
				{

					for(int i = 0; i < cmenu_LOT_List.MenuItems.Count; i++)
					{
						cmenu_LOT_List.MenuItems[i].Visible = true;
					} // end for i

				}
				else
				{

					for(int i = 0; i < cmenu_LOT_List.MenuItems.Count; i++)
					{
						cmenu_LOT_List.MenuItems[i].Visible = false;
					} // end for i

				}

			} // end if

		}



		

			

		/// <summary>
		/// ContextMenu_Click : 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ContextMenu_Click(object sender , EventArgs e)
		{ 


			MenuItem src = sender as MenuItem;



			string req_no = fgrid_Detail[fgrid_Detail.Selection.r1, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString();
 


			for(int i = fgrid_Detail.Selection.r1; i >= fgrid_Detail.Rows.Fixed; i--)
			{
				if(req_no != fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString())
				{
					break;
				}

				fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT] = src.Text; 

			} // end for i

			for(int i = fgrid_Detail.Selection.r1 + 1; i < fgrid_Detail.Rows.Count; i++)
			{
				if(req_no != fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString())
				{
					break;
				}

				fgrid_Detail[i, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT] = src.Text;
 

			} // end for i


			 
			

		}






		#endregion 


		#endregion 

		#region 디비 연결

		#region 콤보

 
		/// <summary>
		/// Select_SPO_RECV_OANU_COMBO : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id_from"></param>
		/// <param name="arg_obs_id_to"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_job_div"></param>
		/// <returns></returns>
		private DataTable Select_SPO_RECV_OANU_COMBO(string arg_factory, 
			string arg_obs_id_from, 
			string arg_obs_id_to,
			string arg_style_cd,
			string arg_oa_job_div)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_RECV_OANU_COMBO";

				MyOraDB.ReDim_Parameter(6); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
				MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[4] = "ARG_OA_JOB_DIV";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_obs_id_from;  
				MyOraDB.Parameter_Values[2] = arg_obs_id_to;  
				MyOraDB.Parameter_Values[3] = arg_style_cd; 
				MyOraDB.Parameter_Values[4] = arg_oa_job_div; 
				MyOraDB.Parameter_Values[5] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}


		#endregion

		#region 조회

	  	 

		/// <summary>
		/// Select_SPO_LOT_OA_HEAD : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_OA_HEAD(string arg_factory, string arg_style_cd, string arg_oa_nu)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_HEAD";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}




		/// <summary>
		/// Select_SPO_LOT_OA_DETAIL : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_OA_DETAIL(string arg_factory, string arg_style_cd, string arg_oa_nu)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_DETAIL";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}


		/// <summary>
		/// Select_SPO_LOT_OA_DETAIL_OTHER : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private DataSet Select_SPO_LOT_OA_DETAIL_OTHER(string arg_factory, string arg_style_cd, string arg_oa_nu)
		{
			
			try
			{

				DataSet ds_ret;


				string process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_DETAIL_B";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 




				process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_DETAIL_BL";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(false); 




				process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_DETAIL_R";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(false); 





				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret; 
				
			}
			catch
			{
				return null;
			}

		}




		#endregion

		#region 컨텍스트 메뉴


		/// <summary>
		/// Select_SPO_LOT_OA_LOT_LIST : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_OA_LOT_LIST(string arg_factory, string arg_style_cd, string arg_oa_nu)
		{

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_OA_BSC.SELECT_SPO_LOT_OA_LOT_LIST";

				MyOraDB.ReDim_Parameter(4); 
  
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OA_NU";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;  
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_style_cd;  
				MyOraDB.Parameter_Values[2] = arg_oa_nu;  
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
				
			}
			catch
			{
				return null;
			}

		}


 

		#endregion  

		#region 저장
		

		#region commit
		
		/// <summary>
		/// Get_LotNo : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_date"></param>
		/// <param name="arg_prefix"></param>
		/// <param name="arg_lot_no"></param>
		/// <returns></returns>
		private string Get_LotNo(string arg_factory, string arg_date, string arg_prefix, string arg_lot_no)
		{  

			DataSet ds_ret;

			try
			{
				string process_name = "PKG_SPO_LOT_OA_BSC.GET_NEXT_LOTNO";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DATE"; 
				MyOraDB.Parameter_Name[2] = "ARG_PREFIX"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_date; 
				MyOraDB.Parameter_Values[2] = arg_prefix; 
				MyOraDB.Parameter_Values[3] = arg_lot_no;   
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString();
			}
			catch
			{
				return null;
			}



		}



		/// <summary>
		/// Get_NEXT_HIS_SEQ : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private string Get_NEXT_HIS_SEQ(string arg_factory, string arg_oa_nu)
		{
			
			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPO_LOT_OA_BSC.GET_NEXT_HIS_SEQ";


				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OA_NU";  
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;   
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_oa_nu;  
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
			
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 
			}
			catch
			{
				return null;
			}
		}

 

		/// <summary>
		/// Check_CONDITION_OA_COMMIT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns>create_ok_yn</returns>
		private bool Check_CONDITION_OA_COMMIT(string arg_factory, string arg_obs_id, string arg_style_cd, string arg_oa_nu)
		{
			
			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPO_LOT_OA_BSC.CHECK_CONDITION_OA_COMMIT";


				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_OA_NU";  
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;   
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_obs_id;  
				MyOraDB.Parameter_Values[2] = arg_style_cd; 
				MyOraDB.Parameter_Values[3] = arg_oa_nu;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false;
			
				// create_ok_yn
				// y : create ok
				// n : can not create
				if(ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString().Trim() == "Y")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
		}




		/// <summary>
		/// Run_SPO_LOT_OA_COMMIT : 
		/// </summary>
		/// <returns></returns>
		private bool Run_SPO_LOT_OA_COMMIT()
		{

			try
			{ 


				COM.OraDB lMyOraDB = new COM.OraDB();  

				
				int col_ct = 13;  						 
				int row = 0, col = 0;
				


				lMyOraDB.ReDim_Parameter(col_ct);
				lMyOraDB.Process_Name = "PKG_SPO_LOT_OA_BSC.RUN_SPO_LOT_OA_COMMIT";

				// 파라미터 이름 설정
				lMyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				lMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				lMyOraDB.Parameter_Name[2] = "ARG_OA_NU"; 
				lMyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				lMyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				lMyOraDB.Parameter_Name[5] = "ARG_REQ_NO";
				lMyOraDB.Parameter_Name[6] = "ARG_REQ_SEQ_NU"; 
				lMyOraDB.Parameter_Name[7] = "ARG_CS_SIZE";
				lMyOraDB.Parameter_Name[8] = "ARG_SIZE_QTY"; 
				lMyOraDB.Parameter_Name[9] = "ARG_LOSS_QTY"; 
				lMyOraDB.Parameter_Name[10] = "ARG_OA_HIS_SEQ"; 
				lMyOraDB.Parameter_Name[11] = "ARG_STYLE_CD"; 
				lMyOraDB.Parameter_Name[12] = "ARG_UPD_USER"; 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					lMyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString(); 
				//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu 
				string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
				string oa_nu = cmb_OaNu.Columns[4].Text;
				string oa_his_seq = Get_NEXT_HIS_SEQ(factory, oa_nu);

				string[] token = null;
				string lot_no = "";
				string lot_seq = "";
				string req_no = "";
				string req_seq_nu = "";
				string size_qty = "";
				string loss_qty = "";
				string loss_balance_qty = "";
				string loss_before_qty = "";


				for(row = fgrid_Detail.Rows.Fixed; row <= fgrid_Detail.Rows.Count - 1; row++)
				{

					if(fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxVIEW_LEVEL].ToString() != _ViewLevel_SizeBefore) continue;


					if(fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU] == null
						|| fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString().Replace("_", "").Trim().Equals("")
						|| fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG] == null
						|| fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_FLAG].ToString().Replace("_", "").Trim().Equals("") )
					{
						continue;
					}


					// lot divide
					if(fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString().Replace("_", "").Trim().Equals("") )
					{
						
						string date = System.DateTime.Now.ToString("yyMM");
						string prefix = "LT";

						if(_DefaultLOT.Trim().Equals("") ) //신규 LOT 생성
						{ 
							token = Get_LotNo(factory, date, prefix, _SignLOTNull).Split('-'); 
						}
						else // 기존 LOT_NO + 신규 LOT_SEQ
						{
							string[] token_1 = _DefaultLOT.Trim().Split('-'); 
							token = Get_LotNo(factory, date, prefix, token_1[0]).Split('-'); 
						}

					}
					// lot merge
					else
					{
						token = fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxLOT].ToString().Split('-');
						
					}


					lot_no = token[0];
					lot_seq = token[1];
 
					// row : size (before)
					// row + 1 : loss (before)
					// row + 2 : released
					// row + 3 : size (after) 
					// row + 4: balance

					//oa_nu = fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString(); 
					req_no = fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString();
					req_seq_nu = (fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] == null) ? "" : fgrid_Detail[row, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU].ToString();


					if(! _DefaultLOT.Trim().Equals("") ) 
					{

						vList.Add("B"); // before 데이터
						vList.Add(factory); 
						vList.Add(oa_nu); 
						vList.Add(lot_no); 
						vList.Add(lot_seq); 
						vList.Add(req_no); 
						vList.Add(req_seq_nu); 
						vList.Add(""); 
						vList.Add(""); 
						vList.Add(""); 
						vList.Add(oa_his_seq); 
						vList.Add(style_cd); 
						vList.Add(ClassLib.ComVar.This_User); 

					}



					//oa_nu = fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString(); 
					req_no = fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString();
					req_seq_nu = (fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] == null) ? "" : fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU].ToString();

					vList.Add("A"); // after 데이터
					vList.Add(factory);
					vList.Add(oa_nu); 
					vList.Add(lot_no); 
					vList.Add(lot_seq); 
					vList.Add(req_no); 
					vList.Add(req_seq_nu); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(""); 
					vList.Add(oa_his_seq); 
					vList.Add(style_cd); 
					vList.Add(ClassLib.ComVar.This_User); 




					for(col = (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxCS_SIZE_START; col < fgrid_Detail.Cols.Count; col++)
					{  
						  

						//oa_nu = fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxOA_NU].ToString();  
						req_no = fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_NO].ToString();
						req_seq_nu = (fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU] == null) ? "" : fgrid_Detail[row + 3, (int)ClassLib.TBSPO_LOT_OA_DETAIL.IxREQ_SEQ_NU].ToString();


						size_qty = (fgrid_Detail[row + 3, col] == null || fgrid_Detail[row + 3, col].ToString() == "") ? "0" : fgrid_Detail[row + 3, col].ToString();
						loss_balance_qty = (fgrid_Detail[row + 4, col] == null || fgrid_Detail[row + 4, col].ToString() == "") ? "0" : fgrid_Detail[row + 4, col].ToString();
						loss_before_qty = (fgrid_Detail[row + 1, col] == null || fgrid_Detail[row + 1, col].ToString() == "") ? "0" : fgrid_Detail[row + 1, col].ToString(); 
						loss_qty = Convert.ToString(Convert.ToInt32(loss_balance_qty) + Convert.ToInt32(loss_before_qty) );

						vList.Add("S"); // after size 데이터
						vList.Add(factory);
						vList.Add(oa_nu); 
						vList.Add(lot_no); 
						vList.Add(lot_seq); 
						vList.Add(req_no); 
						vList.Add(req_seq_nu); 
						vList.Add(fgrid_Detail[2, col].ToString() );  //cs_size
						vList.Add(size_qty); 
						vList.Add(loss_qty);  
						vList.Add(oa_his_seq); 
						vList.Add(style_cd); 
						vList.Add(ClassLib.ComVar.This_User);  
   

					} // end for col   


				} // end for row
  


				vList.Add("U"); 
				vList.Add(factory);
				vList.Add(oa_nu); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(""); 
				vList.Add(oa_his_seq);
				vList.Add(style_cd); 
				vList.Add(ClassLib.ComVar.This_User); 



				lMyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				lMyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = lMyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 

		}



		
		#endregion 

		#region cancel


		/// <summary>
		/// Check_CONDITION_OA_CANCEL : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_oa_nu"></param>
		/// <returns></returns>
		private bool Check_CONDITION_OA_CANCEL(string arg_factory, string arg_obs_id, string arg_style_cd, string arg_oa_nu)
		{
			
			try
			{

				DataSet ds_ret;
				string process_name = "PKG_SPO_LOT_OA_BSC.CHECK_CONDITION_OA_CANCEL";


				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_OA_NU";  
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;   
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_obs_id;  
				MyOraDB.Parameter_Values[2] = arg_style_cd; 
				MyOraDB.Parameter_Values[3] = arg_oa_nu;  
				MyOraDB.Parameter_Values[4] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return false;
			
				// del_ok_yn
				// y : cancel ok
				// n : can not cancel
				if(ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString().Trim() == "Y")
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
		}

		
		private bool Run_SPO_LOT_OA_CANCEL()
		{

			try
			{ 


				COM.OraDB lMyOraDB = new COM.OraDB();  

				
				int col_ct = 6;    


				lMyOraDB.ReDim_Parameter(col_ct);
				lMyOraDB.Process_Name = "PKG_SPO_LOT_OA_BSC.RUN_SPO_LOT_OA_CANCEL";

				// 파라미터 이름 설정
				lMyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				lMyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				lMyOraDB.Parameter_Name[2] = "ARG_OA_NU";  
				lMyOraDB.Parameter_Name[3] = "ARG_OA_HIS_SEQ";  
				lMyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";  
				lMyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 
 

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					lMyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 



				string factory = cmb_Factory.SelectedValue.ToString(); 
				//0 : obs id, 1 : model name, 2 : style cd, 3 : gen, 4 : oa nu  
				string style_cd = cmb_OaNu.Columns[2].Text.Replace("-", "");
				string oa_nu = cmb_OaNu.Columns[4].Text;
				string oa_his_seq = Get_NEXT_HIS_SEQ(factory, oa_nu);
 


				// a_oa_flag = 'X' 인 히스토리 데이터 저장 
				vList.Add("A"); // after 데이터
				vList.Add(factory);
				vList.Add(oa_nu);  
				vList.Add(oa_his_seq);  
				vList.Add(style_cd); 
				vList.Add(ClassLib.ComVar.This_User); 
 

				// 기타 데이터 처리
				vList.Add("U");
				vList.Add(factory);
				vList.Add(oa_nu);  
				vList.Add(oa_his_seq);  
				vList.Add(style_cd); 
				vList.Add(ClassLib.ComVar.This_User); 



				lMyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				lMyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = lMyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 



		}


		#endregion   

		
		#endregion


		#endregion

		 
	}
}

