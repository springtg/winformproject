using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Usage_Check : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너가 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_usageOrignal;
		private System.Windows.Forms.TextBox txt_usageCeil;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_color;
		private System.Windows.Forms.TextBox txt_confirmQty;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_spec;
		private System.Windows.Forms.TextBox txt_factory;
		private System.Windows.Forms.TextBox txt_styleName;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.TextBox txt_item;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자

		public Pop_BS_Usage_Check()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Usage_Check));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.txt_spec = new System.Windows.Forms.TextBox();
            this.txt_confirmQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_styleName = new System.Windows.Forms.TextBox();
            this.txt_usageOrignal = new System.Windows.Forms.TextBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.txt_usageCeil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.pnl_head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "21.0648148148148:False:False;74.3055555555556:False:False;0.925925925925926:False" +
                ":True;\t0.574712643678161:False:True;96.551724137931:False:False;0.57471264367816" +
                "1:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(-1, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(696, 432);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 99);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(672, 321);
            this.spd_main.TabIndex = 5;
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(672, 91);
            this.pnl_head.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_color);
            this.groupBox1.Controls.Add(this.txt_item);
            this.groupBox1.Controls.Add(this.txt_factory);
            this.groupBox1.Controls.Add(this.lbl_item);
            this.groupBox1.Controls.Add(this.pic_head7);
            this.groupBox1.Controls.Add(this.txt_spec);
            this.groupBox1.Controls.Add(this.txt_confirmQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_styleName);
            this.groupBox1.Controls.Add(this.txt_usageOrignal);
            this.groupBox1.Controls.Add(this.lbl_style);
            this.groupBox1.Controls.Add(this.txt_styleCd);
            this.groupBox1.Controls.Add(this.txt_usageCeil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 90);
            this.groupBox1.TabIndex = 398;
            this.groupBox1.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_color
            // 
            this.txt_color.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_color.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_color.Location = new System.Drawing.Point(109, 60);
            this.txt_color.Name = "txt_color";
            this.txt_color.ReadOnly = true;
            this.txt_color.Size = new System.Drawing.Size(210, 21);
            this.txt_color.TabIndex = 397;
            // 
            // txt_item
            // 
            this.txt_item.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_item.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_item.Location = new System.Drawing.Point(109, 38);
            this.txt_item.Name = "txt_item";
            this.txt_item.ReadOnly = true;
            this.txt_item.Size = new System.Drawing.Size(210, 21);
            this.txt_item.TabIndex = 397;
            // 
            // txt_factory
            // 
            this.txt_factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_factory.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_factory.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_factory.Location = new System.Drawing.Point(109, 16);
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.ReadOnly = true;
            this.txt_factory.Size = new System.Drawing.Size(210, 21);
            this.txt_factory.TabIndex = 397;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(8, 38);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 50;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(968, 0);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 61);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // txt_spec
            // 
            this.txt_spec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_spec.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_spec.Location = new System.Drawing.Point(428, 38);
            this.txt_spec.Name = "txt_spec";
            this.txt_spec.ReadOnly = true;
            this.txt_spec.Size = new System.Drawing.Size(210, 21);
            this.txt_spec.TabIndex = 397;
            // 
            // txt_confirmQty
            // 
            this.txt_confirmQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_confirmQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmQty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_confirmQty.Location = new System.Drawing.Point(428, 60);
            this.txt_confirmQty.Name = "txt_confirmQty";
            this.txt_confirmQty.ReadOnly = true;
            this.txt_confirmQty.Size = new System.Drawing.Size(69, 21);
            this.txt_confirmQty.TabIndex = 397;
            this.txt_confirmQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(327, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Confirm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleName
            // 
            this.txt_styleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleName.Location = new System.Drawing.Point(499, 16);
            this.txt_styleName.Name = "txt_styleName";
            this.txt_styleName.ReadOnly = true;
            this.txt_styleName.Size = new System.Drawing.Size(139, 21);
            this.txt_styleName.TabIndex = 397;
            // 
            // txt_usageOrignal
            // 
            this.txt_usageOrignal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usageOrignal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usageOrignal.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_usageOrignal.Location = new System.Drawing.Point(568, 60);
            this.txt_usageOrignal.Name = "txt_usageOrignal";
            this.txt_usageOrignal.ReadOnly = true;
            this.txt_usageOrignal.Size = new System.Drawing.Size(70, 21);
            this.txt_usageOrignal.TabIndex = 397;
            this.txt_usageOrignal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(327, 16);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 50;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(428, 16);
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.ReadOnly = true;
            this.txt_styleCd.Size = new System.Drawing.Size(70, 21);
            this.txt_styleCd.TabIndex = 397;
            // 
            // txt_usageCeil
            // 
            this.txt_usageCeil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_usageCeil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usageCeil.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_usageCeil.Location = new System.Drawing.Point(498, 60);
            this.txt_usageCeil.Name = "txt_usageCeil";
            this.txt_usageCeil.ReadOnly = true;
            this.txt_usageCeil.Size = new System.Drawing.Size(69, 21);
            this.txt_usageCeil.TabIndex = 397;
            this.txt_usageCeil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(327, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Spec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head6
            // 
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(100, 50);
            this.pic_head6.TabIndex = 0;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Location = new System.Drawing.Point(0, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(100, 50);
            this.pic_head1.TabIndex = 0;
            this.pic_head1.TabStop = false;
            // 
            // Pop_BS_Usage_Check
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BS_Usage_Check";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
        {
			this.Text = "MRP Usage Information";
            lbl_MainTitle.Text = "MRP Usage Information";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBM_MRP_VALID_CHECK", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// shipping schedule data set
			txt_factory.Text	= COM.ComVar.Parameter_PopUp[0];
			txt_styleCd.Text	= COM.ComVar.Parameter_PopUp[1];
			txt_styleName.Text	= COM.ComVar.Parameter_PopUp[2];
			txt_item.Text		= COM.ComVar.Parameter_PopUp[3];
			txt_spec.Text		= COM.ComVar.Parameter_PopUp[4];
			txt_color.Text		= COM.ComVar.Parameter_PopUp[5];
			txt_confirmQty.Text	= COM.ComVar.Parameter_PopUp[6];

			// size data set
			Search_Process();
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void Search_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_MRP_ADVICE_VALID_CHECK();

				if (vDt.Rows.Count > 0)
				{
					spd_main.Display_Grid(vDt);
					ClassLib.ComFunction.MergeCell(spd_main, new int[]{1});

					double vOrignal = 0.0;
					
					for (int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++)
					{
						vOrignal += Convert.ToDouble(spd_main.ActiveSheet.Cells[vRow, (int)FlexMRP.ClassLib.TBSBM_MRP_VALID_CHECK.IxUSAGE_QTY].Value);
					}
					
					txt_usageCeil.Text = Math.Ceiling(vOrignal).ToString();
					txt_usageOrignal.Text = vOrignal.ToString();
				}
				else
				{
					spd_main.ClearAll();
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

		#endregion

		#endregion

		#region DBConnect

        public DataTable SELECT_MRP_ADVICE_VALID_CHECK()
        {
            DataSet vds_ret;

            MyOraDB.ReDim_Parameter(13);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_MRP_ADVICE_VALID_CHECK";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
            MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
            MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";
            MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
            MyOraDB.Parameter_Name[7] = "ARG_SPEC_CD";
            MyOraDB.Parameter_Name[8] = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[9] = "ARG_OBS_TYPE";
            MyOraDB.Parameter_Name[10] = "ARG_OUTSIDE_YN";
            MyOraDB.Parameter_Name[11] = "ARG_SHIP_SEQ";
            MyOraDB.Parameter_Name[12] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[12] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
            MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[7];
            MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[8];
            MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[9];
            MyOraDB.Parameter_Values[4] = COM.ComVar.Parameter_PopUp[10];
            MyOraDB.Parameter_Values[5] = COM.ComVar.Parameter_PopUp[1].Replace("-", "");
            MyOraDB.Parameter_Values[6] = COM.ComVar.Parameter_PopUp[11];
            MyOraDB.Parameter_Values[7] = COM.ComVar.Parameter_PopUp[12];
            MyOraDB.Parameter_Values[8] = COM.ComVar.Parameter_PopUp[13];
            MyOraDB.Parameter_Values[9] = COM.ComVar.Parameter_PopUp[14];
            MyOraDB.Parameter_Values[10] = COM.ComVar.Parameter_PopUp[15];
            MyOraDB.Parameter_Values[11] = COM.ComVar.Parameter_PopUp[16];
            MyOraDB.Parameter_Values[12] = "";

            MyOraDB.Add_Select_Parameter(true);
            vds_ret = MyOraDB.Exe_Select_Procedure();
            if (vds_ret == null) return null;

            return vds_ret.Tables[MyOraDB.Process_Name];
        }


		#endregion

	}
}

