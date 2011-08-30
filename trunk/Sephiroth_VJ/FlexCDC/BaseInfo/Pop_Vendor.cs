using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.BaseInfo
{
	public class Pop_Vendor : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.TextBox txt_Ven_Seq;
		private C1.Win.C1List.C1Combo cmb_Vendor;
		private System.Windows.Forms.Label lbl_Vendor;
		private System.ComponentModel.IContainer components = null;
		public BaseInfo.Form_SRF_Item arg_request = null;
		public BaseInfo.Form_SRF_Price arg_request2 = null;

		public Pop_Vendor(BaseInfo.Form_SRF_Item arg_request1)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			arg_request = arg_request1;
		}

		public Pop_Vendor(BaseInfo.Form_SRF_Price arg_request1)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			arg_request2 = arg_request1;
		}

		public Pop_Vendor()
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
		#endregion
        
		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Vendor));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_Ven_Seq = new System.Windows.Forms.TextBox();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(358, 23);
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
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(0, 32);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pnl_Search.Size = new System.Drawing.Size(390, 70);
            this.pnl_Search.TabIndex = 79;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_Ven_Seq);
            this.pnl_SearchImage.Controls.Add(this.cmb_Vendor);
            this.pnl_SearchImage.Controls.Add(this.lbl_Vendor);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(1, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(388, 70);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_Ven_Seq
            // 
            this.txt_Ven_Seq.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Ven_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ven_Seq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ven_Seq.Location = new System.Drawing.Point(90, 36);
            this.txt_Ven_Seq.MaxLength = 10;
            this.txt_Ven_Seq.Name = "txt_Ven_Seq";
            this.txt_Ven_Seq.Size = new System.Drawing.Size(100, 21);
            this.txt_Ven_Seq.TabIndex = 252;
            this.txt_Ven_Seq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Ven_Seq_KeyUp);
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemCols = 0;
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style1;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 17;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 17;
            this.cmb_Vendor.EvenRowStyle = style2;
            this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style3;
            this.cmb_Vendor.GapHeight = 2;
            this.cmb_Vendor.HeadingStyle = style4;
            this.cmb_Vendor.HighLightRowStyle = style5;
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(191, 36);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style6;
            this.cmb_Vendor.PartialRightColumn = false;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style7;
            this.cmb_Vendor.Size = new System.Drawing.Size(192, 21);
            this.cmb_Vendor.Style = style8;
            this.cmb_Vendor.TabIndex = 248;
            this.cmb_Vendor.SelectedValueChanged += new System.EventHandler(this.cmb_Vendor_SelectedValueChanged);
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
            this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.Location = new System.Drawing.Point(8, 36);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(80, 21);
            this.lbl_Vendor.TabIndex = 251;
            this.lbl_Vendor.Text = "Vendor";
            this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(372, 55);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 54);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(228, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 55);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 37);
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
            this.picb_MM.Size = new System.Drawing.Size(220, 30);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(371, 28);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 28);
            this.picb_MR.TabIndex = 253;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(372, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(164, 32);
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
            this.lbl_SubTitle1.Text = "      Vendor";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ImageIndex = 1;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(3, 109);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 250;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 1;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(319, 109);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 251;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Pop_Vendor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(392, 136);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Pop_Vendor";
            this.Load += new System.EventHandler(this.Pop_Vendor_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private COM.OraDB MyOraDB = new COM.OraDB();
		public int r1 = 0;
		public int r2 = 0;
		public string div;
		#endregion
		
		#region 공통 메서드
		private void Init_Form()
		{
			this.Text = "Vendor";
			this.lbl_MainTitle.Text = "Vendor";			

			//CDC Vendor Setting 
			DataTable dt_ret = Select_Vendor_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, 50, 200);			
			cmb_Vendor.SelectedIndex = 0;

			dt_ret.Dispose();		

			txt_Ven_Seq.CharacterCasing = CharacterCasing.Upper;
			txt_Ven_Seq.Focus();
		}
		#endregion

		#region 이벤트 처리
		private void txt_Ven_Seq_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(txt_Ven_Seq != null && e.KeyData == Keys.Enter)
			{								
				//CDC Vendor Setting 
				DataTable dt_ret = Select_Vendor_List();
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, 0, 192);			
				cmb_Vendor.SelectedIndex = 0;
			
				dt_ret.Dispose();								
			}		
		
		}

		private void cmb_Vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Vendor.SelectedValue != null)
				txt_Ven_Seq.Text = cmb_Vendor.SelectedValue.ToString().Trim();		
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
            int[] selectRow = arg_request.fgrid_Main.Selections;

			if(div == "M")
			{
                for (int i = 0; i < arg_request.fgrid_Main.Selections.Length; i++)
				{
                    arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_MAT.IxVEN_SEQ] = ClassLib.ComFunction.Empty_TextBox(txt_Ven_Seq, "");
                    arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_MAT.IxVENDOR_DESC] = (cmb_Vendor.Text == "ALL") ? "" : cmb_Vendor.Text;
                    arg_request.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_MAT.IxDIVISION] = "U";
				}
			}
			if(div == "P")
			{
                for (int i = 0; i < arg_request.fgrid_Main.Selections.Length; i++)
				{
                    arg_request2.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_CBD.IxVEN_SEQ] = ClassLib.ComFunction.Empty_TextBox(txt_Ven_Seq, "");
                    arg_request2.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_CBD.IxVENDOR_DESC] = (cmb_Vendor.Text == "ALL") ? "" : cmb_Vendor.Text;
                    arg_request2.fgrid_Main[selectRow[i], (int)ClassLib.TBSXD_SRF_M_CBD.IxDIVISION] = "U";
				}
			}

			this.Close();		
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}
		#endregion

		#region DB Connect

		private DataTable Select_Vendor_List()
		{		
			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_VENDOR";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	
			MyOraDB.Parameter_Name[1] = "ARG_VENDOR";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;		
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.This_CDC_Factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_Ven_Seq, "");
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];
		}
		#endregion

		private void Pop_Vendor_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
		}


	}
}

