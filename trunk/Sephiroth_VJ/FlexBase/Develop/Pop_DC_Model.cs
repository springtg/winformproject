using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexBase.Develop
{
	public class Pop_DC_Model : COM.PCHWinForm.Pop_Normal
	{
		#region 컨트롤정의 및 리소스 정의 
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_btn;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.TextBox txt_ModelCd;
		private C1.Win.C1List.C1Combo cmb_SetHpuSpu;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_SetSpu;
		private C1.Win.C1List.C1Combo cmb_SetHpu;
		private C1.Win.C1List.C1Combo cmb_PhType;
		private C1.Win.C1List.C1Combo cmb_SetPhSpu;
		private C1.Win.C1List.C1Combo cmb_SetPh;
		private C1.Win.C1List.C1Combo cmb_ToolCd;
		private System.Windows.Forms.TextBox txt_Remark;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_Category;
		private C1.Win.C1List.C1Combo cmb_Season;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Year;
		private System.Windows.Forms.TextBox txt_Pattern;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label lbl_Webcountcd;
		private System.Windows.Forms.Label lbl_Tradecust;
		private System.Windows.Forms.Label lbl_Baryn;
		private System.ComponentModel.IContainer components = null;

	

		public Pop_DC_Model()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_DC_Model));
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style105 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style106 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style107 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style108 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style109 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style110 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style111 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style112 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style113 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style114 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style115 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style116 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style117 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style118 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style119 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style120 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style121 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style122 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style123 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style124 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style125 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style126 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style127 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style128 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style129 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style130 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style131 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style132 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style133 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style134 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style135 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style136 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style137 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style138 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style139 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style140 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style141 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style142 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style143 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style144 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style145 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style146 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style147 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style148 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style149 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style150 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style151 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style152 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style153 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style154 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style155 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style156 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style157 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style158 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style159 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style160 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.txt_ModelCd = new System.Windows.Forms.TextBox();
            this.cmb_Year = new C1.Win.C1List.C1Combo();
            this.lbl_Webcountcd = new System.Windows.Forms.Label();
            this.cmb_Season = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Pattern = new System.Windows.Forms.TextBox();
            this.cmb_Category = new C1.Win.C1List.C1Combo();
            this.lbl_Tradecust = new System.Windows.Forms.Label();
            this.lbl_Baryn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SetPhSpu = new C1.Win.C1List.C1Combo();
            this.cmb_ToolCd = new C1.Win.C1List.C1Combo();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_SetPh = new C1.Win.C1List.C1Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_PhType = new C1.Win.C1List.C1Combo();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_SetHpu = new C1.Win.C1List.C1Combo();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_SetSpu = new C1.Win.C1List.C1Combo();
            this.cmb_SetHpuSpu = new C1.Win.C1List.C1Combo();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetPhSpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ToolCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetPh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PhType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetHpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetSpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetHpuSpu)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_btn);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "84.4594594594595:False:True;13.1756756756757:False:True;\t0.809716599190283:False:" +
                "True;96.9635627530364:False:False;0.607287449392713:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(494, 296);
            this.c1Sizer1.TabIndex = 216;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_btn
            // 
            this.pnl_btn.BackColor = System.Drawing.Color.Transparent;
            this.pnl_btn.Controls.Add(this.btn_apply);
            this.pnl_btn.Controls.Add(this.btn_cancel);
            this.pnl_btn.Location = new System.Drawing.Point(8, 254);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(479, 39);
            this.pnl_btn.TabIndex = 1;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(323, 6);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 12;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(395, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_main.Controls.Add(this.groupBox1);
            this.pnl_main.Location = new System.Drawing.Point(8, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(479, 250);
            this.pnl_main.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_Factory);
            this.groupBox1.Controls.Add(this.txt_ModelCd);
            this.groupBox1.Controls.Add(this.cmb_Year);
            this.groupBox1.Controls.Add(this.lbl_Webcountcd);
            this.groupBox1.Controls.Add(this.cmb_Season);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Pattern);
            this.groupBox1.Controls.Add(this.cmb_Category);
            this.groupBox1.Controls.Add(this.lbl_Tradecust);
            this.groupBox1.Controls.Add(this.lbl_Baryn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_SetPhSpu);
            this.groupBox1.Controls.Add(this.cmb_ToolCd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_SetPh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_PhType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_SetHpu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_SetSpu);
            this.groupBox1.Controls.Add(this.cmb_SetHpuSpu);
            this.groupBox1.Controls.Add(this.txt_Remark);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 249);
            this.groupBox1.TabIndex = 476;
            this.groupBox1.TabStop = false;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(12, 22);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 457;
            this.lbl_Factory.Text = "Model";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ModelCd
            // 
            this.txt_ModelCd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ModelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ModelCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_ModelCd.Location = new System.Drawing.Point(113, 22);
            this.txt_ModelCd.MaxLength = 6;
            this.txt_ModelCd.Name = "txt_ModelCd";
            this.txt_ModelCd.Size = new System.Drawing.Size(120, 21);
            this.txt_ModelCd.TabIndex = 460;
            // 
            // cmb_Year
            // 
            this.cmb_Year.AddItemCols = 0;
            this.cmb_Year.AddItemSeparator = ';';
            this.cmb_Year.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Year.Caption = "";
            this.cmb_Year.CaptionHeight = 17;
            this.cmb_Year.CaptionStyle = style81;
            this.cmb_Year.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Year.ColumnCaptionHeight = 18;
            this.cmb_Year.ColumnFooterHeight = 18;
            this.cmb_Year.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Year.ContentHeight = 17;
            this.cmb_Year.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Year.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Year.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Year.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Year.EditorHeight = 17;
            this.cmb_Year.EvenRowStyle = style82;
            this.cmb_Year.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Year.FooterStyle = style83;
            this.cmb_Year.GapHeight = 2;
            this.cmb_Year.HeadingStyle = style84;
            this.cmb_Year.HighLightRowStyle = style85;
            this.cmb_Year.ItemHeight = 15;
            this.cmb_Year.Location = new System.Drawing.Point(113, 56);
            this.cmb_Year.MatchEntryTimeout = ((long)(2000));
            this.cmb_Year.MaxDropDownItems = ((short)(5));
            this.cmb_Year.MaxLength = 1;
            this.cmb_Year.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.OddRowStyle = style86;
            this.cmb_Year.PartialRightColumn = false;
            this.cmb_Year.PropBag = resources.GetString("cmb_Year.PropBag");
            this.cmb_Year.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Year.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Year.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Year.SelectedStyle = style87;
            this.cmb_Year.Size = new System.Drawing.Size(120, 21);
            this.cmb_Year.Style = style88;
            this.cmb_Year.TabIndex = 1;
            // 
            // lbl_Webcountcd
            // 
            this.lbl_Webcountcd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Webcountcd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Webcountcd.ImageIndex = 0;
            this.lbl_Webcountcd.ImageList = this.img_Label;
            this.lbl_Webcountcd.Location = new System.Drawing.Point(12, 56);
            this.lbl_Webcountcd.Name = "lbl_Webcountcd";
            this.lbl_Webcountcd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Webcountcd.TabIndex = 461;
            this.lbl_Webcountcd.Text = "Year";
            this.lbl_Webcountcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Season
            // 
            this.cmb_Season.AddItemCols = 0;
            this.cmb_Season.AddItemSeparator = ';';
            this.cmb_Season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Season.Caption = "";
            this.cmb_Season.CaptionHeight = 17;
            this.cmb_Season.CaptionStyle = style89;
            this.cmb_Season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Season.ColumnCaptionHeight = 18;
            this.cmb_Season.ColumnFooterHeight = 18;
            this.cmb_Season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Season.ContentHeight = 17;
            this.cmb_Season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Season.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Season.EditorHeight = 17;
            this.cmb_Season.EvenRowStyle = style90;
            this.cmb_Season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Season.FooterStyle = style91;
            this.cmb_Season.GapHeight = 2;
            this.cmb_Season.HeadingStyle = style92;
            this.cmb_Season.HighLightRowStyle = style93;
            this.cmb_Season.ItemHeight = 15;
            this.cmb_Season.Location = new System.Drawing.Point(349, 56);
            this.cmb_Season.MatchEntryTimeout = ((long)(2000));
            this.cmb_Season.MaxDropDownItems = ((short)(5));
            this.cmb_Season.MaxLength = 1;
            this.cmb_Season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Season.Name = "cmb_Season";
            this.cmb_Season.OddRowStyle = style94;
            this.cmb_Season.PartialRightColumn = false;
            this.cmb_Season.PropBag = resources.GetString("cmb_Season.PropBag");
            this.cmb_Season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Season.SelectedStyle = style95;
            this.cmb_Season.Size = new System.Drawing.Size(120, 21);
            this.cmb_Season.Style = style96;
            this.cmb_Season.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(248, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 465;
            this.label2.Text = "Season";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Name.Location = new System.Drawing.Point(113, 78);
            this.txt_Name.MaxLength = 30;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(356, 21);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Pattern
            // 
            this.txt_Pattern.BackColor = System.Drawing.Color.White;
            this.txt_Pattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pattern.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Pattern.Location = new System.Drawing.Point(349, 100);
            this.txt_Pattern.MaxLength = 30;
            this.txt_Pattern.Name = "txt_Pattern";
            this.txt_Pattern.Size = new System.Drawing.Size(120, 21);
            this.txt_Pattern.TabIndex = 5;
            // 
            // cmb_Category
            // 
            this.cmb_Category.AddItemCols = 0;
            this.cmb_Category.AddItemSeparator = ';';
            this.cmb_Category.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Category.Caption = "";
            this.cmb_Category.CaptionHeight = 17;
            this.cmb_Category.CaptionStyle = style97;
            this.cmb_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Category.ColumnCaptionHeight = 18;
            this.cmb_Category.ColumnFooterHeight = 18;
            this.cmb_Category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Category.ContentHeight = 17;
            this.cmb_Category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Category.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Category.EditorHeight = 17;
            this.cmb_Category.EvenRowStyle = style98;
            this.cmb_Category.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Category.FooterStyle = style99;
            this.cmb_Category.GapHeight = 2;
            this.cmb_Category.HeadingStyle = style100;
            this.cmb_Category.HighLightRowStyle = style101;
            this.cmb_Category.ItemHeight = 15;
            this.cmb_Category.Location = new System.Drawing.Point(113, 100);
            this.cmb_Category.MatchEntryTimeout = ((long)(2000));
            this.cmb_Category.MaxDropDownItems = ((short)(5));
            this.cmb_Category.MaxLength = 1;
            this.cmb_Category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.OddRowStyle = style102;
            this.cmb_Category.PartialRightColumn = false;
            this.cmb_Category.PropBag = resources.GetString("cmb_Category.PropBag");
            this.cmb_Category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Category.SelectedStyle = style103;
            this.cmb_Category.Size = new System.Drawing.Size(120, 21);
            this.cmb_Category.Style = style104;
            this.cmb_Category.TabIndex = 4;
            // 
            // lbl_Tradecust
            // 
            this.lbl_Tradecust.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Tradecust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Tradecust.ImageIndex = 0;
            this.lbl_Tradecust.ImageList = this.img_Label;
            this.lbl_Tradecust.Location = new System.Drawing.Point(12, 100);
            this.lbl_Tradecust.Name = "lbl_Tradecust";
            this.lbl_Tradecust.Size = new System.Drawing.Size(100, 21);
            this.lbl_Tradecust.TabIndex = 459;
            this.lbl_Tradecust.Text = "Category";
            this.lbl_Tradecust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Baryn
            // 
            this.lbl_Baryn.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Baryn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Baryn.ImageIndex = 0;
            this.lbl_Baryn.ImageList = this.img_Label;
            this.lbl_Baryn.Location = new System.Drawing.Point(12, 78);
            this.lbl_Baryn.Name = "lbl_Baryn";
            this.lbl_Baryn.Size = new System.Drawing.Size(100, 21);
            this.lbl_Baryn.TabIndex = 458;
            this.lbl_Baryn.Text = "Name";
            this.lbl_Baryn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(248, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 463;
            this.label1.Text = "Pattern";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SetPhSpu
            // 
            this.cmb_SetPhSpu.AddItemCols = 0;
            this.cmb_SetPhSpu.AddItemSeparator = ';';
            this.cmb_SetPhSpu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SetPhSpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SetPhSpu.Caption = "";
            this.cmb_SetPhSpu.CaptionHeight = 17;
            this.cmb_SetPhSpu.CaptionStyle = style105;
            this.cmb_SetPhSpu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SetPhSpu.ColumnCaptionHeight = 18;
            this.cmb_SetPhSpu.ColumnFooterHeight = 18;
            this.cmb_SetPhSpu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SetPhSpu.ContentHeight = 17;
            this.cmb_SetPhSpu.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SetPhSpu.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SetPhSpu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SetPhSpu.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SetPhSpu.EditorHeight = 17;
            this.cmb_SetPhSpu.EvenRowStyle = style106;
            this.cmb_SetPhSpu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_SetPhSpu.FooterStyle = style107;
            this.cmb_SetPhSpu.GapHeight = 2;
            this.cmb_SetPhSpu.HeadingStyle = style108;
            this.cmb_SetPhSpu.HighLightRowStyle = style109;
            this.cmb_SetPhSpu.ItemHeight = 15;
            this.cmb_SetPhSpu.Location = new System.Drawing.Point(113, 144);
            this.cmb_SetPhSpu.MatchEntryTimeout = ((long)(2000));
            this.cmb_SetPhSpu.MaxDropDownItems = ((short)(5));
            this.cmb_SetPhSpu.MaxLength = 1;
            this.cmb_SetPhSpu.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SetPhSpu.Name = "cmb_SetPhSpu";
            this.cmb_SetPhSpu.OddRowStyle = style110;
            this.cmb_SetPhSpu.PartialRightColumn = false;
            this.cmb_SetPhSpu.PropBag = resources.GetString("cmb_SetPhSpu.PropBag");
            this.cmb_SetPhSpu.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SetPhSpu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SetPhSpu.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SetPhSpu.SelectedStyle = style111;
            this.cmb_SetPhSpu.Size = new System.Drawing.Size(120, 21);
            this.cmb_SetPhSpu.Style = style112;
            this.cmb_SetPhSpu.TabIndex = 8;
            // 
            // cmb_ToolCd
            // 
            this.cmb_ToolCd.AddItemCols = 0;
            this.cmb_ToolCd.AddItemSeparator = ';';
            this.cmb_ToolCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ToolCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ToolCd.Caption = "";
            this.cmb_ToolCd.CaptionHeight = 17;
            this.cmb_ToolCd.CaptionStyle = style113;
            this.cmb_ToolCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ToolCd.ColumnCaptionHeight = 18;
            this.cmb_ToolCd.ColumnFooterHeight = 18;
            this.cmb_ToolCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ToolCd.ContentHeight = 17;
            this.cmb_ToolCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ToolCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ToolCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ToolCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ToolCd.EditorHeight = 17;
            this.cmb_ToolCd.EvenRowStyle = style114;
            this.cmb_ToolCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_ToolCd.FooterStyle = style115;
            this.cmb_ToolCd.GapHeight = 2;
            this.cmb_ToolCd.HeadingStyle = style116;
            this.cmb_ToolCd.HighLightRowStyle = style117;
            this.cmb_ToolCd.ItemHeight = 15;
            this.cmb_ToolCd.Location = new System.Drawing.Point(113, 122);
            this.cmb_ToolCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_ToolCd.MaxDropDownItems = ((short)(5));
            this.cmb_ToolCd.MaxLength = 1;
            this.cmb_ToolCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ToolCd.Name = "cmb_ToolCd";
            this.cmb_ToolCd.OddRowStyle = style118;
            this.cmb_ToolCd.PartialRightColumn = false;
            this.cmb_ToolCd.PropBag = resources.GetString("cmb_ToolCd.PropBag");
            this.cmb_ToolCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ToolCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ToolCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ToolCd.SelectedStyle = style119;
            this.cmb_ToolCd.Size = new System.Drawing.Size(120, 21);
            this.cmb_ToolCd.Style = style120;
            this.cmb_ToolCd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(248, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 471;
            this.label5.Text = "Phylon Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SetPh
            // 
            this.cmb_SetPh.AddItemCols = 0;
            this.cmb_SetPh.AddItemSeparator = ';';
            this.cmb_SetPh.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SetPh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SetPh.Caption = "";
            this.cmb_SetPh.CaptionHeight = 17;
            this.cmb_SetPh.CaptionStyle = style121;
            this.cmb_SetPh.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SetPh.ColumnCaptionHeight = 18;
            this.cmb_SetPh.ColumnFooterHeight = 18;
            this.cmb_SetPh.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SetPh.ContentHeight = 17;
            this.cmb_SetPh.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SetPh.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SetPh.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SetPh.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SetPh.EditorHeight = 17;
            this.cmb_SetPh.EvenRowStyle = style122;
            this.cmb_SetPh.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_SetPh.FooterStyle = style123;
            this.cmb_SetPh.GapHeight = 2;
            this.cmb_SetPh.HeadingStyle = style124;
            this.cmb_SetPh.HighLightRowStyle = style125;
            this.cmb_SetPh.ItemHeight = 15;
            this.cmb_SetPh.Location = new System.Drawing.Point(349, 122);
            this.cmb_SetPh.MatchEntryTimeout = ((long)(2000));
            this.cmb_SetPh.MaxDropDownItems = ((short)(5));
            this.cmb_SetPh.MaxLength = 1;
            this.cmb_SetPh.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SetPh.Name = "cmb_SetPh";
            this.cmb_SetPh.OddRowStyle = style126;
            this.cmb_SetPh.PartialRightColumn = false;
            this.cmb_SetPh.PropBag = resources.GetString("cmb_SetPh.PropBag");
            this.cmb_SetPh.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SetPh.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SetPh.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SetPh.SelectedStyle = style127;
            this.cmb_SetPh.Size = new System.Drawing.Size(120, 21);
            this.cmb_SetPh.Style = style128;
            this.cmb_SetPh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ImageIndex = 0;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 468;
            this.label4.Text = "OutSole";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(248, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 469;
            this.label3.Text = "Phylon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ImageIndex = 0;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 470;
            this.label6.Text = "Ph Soft Pu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_PhType
            // 
            this.cmb_PhType.AddItemCols = 0;
            this.cmb_PhType.AddItemSeparator = ';';
            this.cmb_PhType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_PhType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PhType.Caption = "";
            this.cmb_PhType.CaptionHeight = 17;
            this.cmb_PhType.CaptionStyle = style129;
            this.cmb_PhType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PhType.ColumnCaptionHeight = 18;
            this.cmb_PhType.ColumnFooterHeight = 18;
            this.cmb_PhType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PhType.ContentHeight = 17;
            this.cmb_PhType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PhType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PhType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PhType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PhType.EditorHeight = 17;
            this.cmb_PhType.EvenRowStyle = style130;
            this.cmb_PhType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_PhType.FooterStyle = style131;
            this.cmb_PhType.GapHeight = 2;
            this.cmb_PhType.HeadingStyle = style132;
            this.cmb_PhType.HighLightRowStyle = style133;
            this.cmb_PhType.ItemHeight = 15;
            this.cmb_PhType.Location = new System.Drawing.Point(349, 144);
            this.cmb_PhType.MatchEntryTimeout = ((long)(2000));
            this.cmb_PhType.MaxDropDownItems = ((short)(5));
            this.cmb_PhType.MaxLength = 1;
            this.cmb_PhType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PhType.Name = "cmb_PhType";
            this.cmb_PhType.OddRowStyle = style134;
            this.cmb_PhType.PartialRightColumn = false;
            this.cmb_PhType.PropBag = resources.GetString("cmb_PhType.PropBag");
            this.cmb_PhType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PhType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PhType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PhType.SelectedStyle = style135;
            this.cmb_PhType.Size = new System.Drawing.Size(120, 21);
            this.cmb_PhType.Style = style136;
            this.cmb_PhType.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ImageIndex = 0;
            this.label10.ImageList = this.img_Label;
            this.label10.Location = new System.Drawing.Point(12, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 474;
            this.label10.Text = "Soft PU";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(248, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 473;
            this.label7.Text = "PU Soft PU";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SetHpu
            // 
            this.cmb_SetHpu.AddItemCols = 0;
            this.cmb_SetHpu.AddItemSeparator = ';';
            this.cmb_SetHpu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SetHpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SetHpu.Caption = "";
            this.cmb_SetHpu.CaptionHeight = 17;
            this.cmb_SetHpu.CaptionStyle = style137;
            this.cmb_SetHpu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SetHpu.ColumnCaptionHeight = 18;
            this.cmb_SetHpu.ColumnFooterHeight = 18;
            this.cmb_SetHpu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SetHpu.ContentHeight = 17;
            this.cmb_SetHpu.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SetHpu.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SetHpu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SetHpu.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SetHpu.EditorHeight = 17;
            this.cmb_SetHpu.EvenRowStyle = style138;
            this.cmb_SetHpu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_SetHpu.FooterStyle = style139;
            this.cmb_SetHpu.GapHeight = 2;
            this.cmb_SetHpu.HeadingStyle = style140;
            this.cmb_SetHpu.HighLightRowStyle = style141;
            this.cmb_SetHpu.ItemHeight = 15;
            this.cmb_SetHpu.Location = new System.Drawing.Point(113, 166);
            this.cmb_SetHpu.MatchEntryTimeout = ((long)(2000));
            this.cmb_SetHpu.MaxDropDownItems = ((short)(5));
            this.cmb_SetHpu.MaxLength = 1;
            this.cmb_SetHpu.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SetHpu.Name = "cmb_SetHpu";
            this.cmb_SetHpu.OddRowStyle = style142;
            this.cmb_SetHpu.PartialRightColumn = false;
            this.cmb_SetHpu.PropBag = resources.GetString("cmb_SetHpu.PropBag");
            this.cmb_SetHpu.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SetHpu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SetHpu.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SetHpu.SelectedStyle = style143;
            this.cmb_SetHpu.Size = new System.Drawing.Size(120, 21);
            this.cmb_SetHpu.Style = style144;
            this.cmb_SetHpu.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ImageIndex = 0;
            this.label8.ImageList = this.img_Label;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 472;
            this.label8.Text = "PU";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SetSpu
            // 
            this.cmb_SetSpu.AddItemCols = 0;
            this.cmb_SetSpu.AddItemSeparator = ';';
            this.cmb_SetSpu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SetSpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SetSpu.Caption = "";
            this.cmb_SetSpu.CaptionHeight = 17;
            this.cmb_SetSpu.CaptionStyle = style145;
            this.cmb_SetSpu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SetSpu.ColumnCaptionHeight = 18;
            this.cmb_SetSpu.ColumnFooterHeight = 18;
            this.cmb_SetSpu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SetSpu.ContentHeight = 17;
            this.cmb_SetSpu.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SetSpu.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SetSpu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SetSpu.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SetSpu.EditorHeight = 17;
            this.cmb_SetSpu.EvenRowStyle = style146;
            this.cmb_SetSpu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_SetSpu.FooterStyle = style147;
            this.cmb_SetSpu.GapHeight = 2;
            this.cmb_SetSpu.HeadingStyle = style148;
            this.cmb_SetSpu.HighLightRowStyle = style149;
            this.cmb_SetSpu.ItemHeight = 15;
            this.cmb_SetSpu.Location = new System.Drawing.Point(113, 188);
            this.cmb_SetSpu.MatchEntryTimeout = ((long)(2000));
            this.cmb_SetSpu.MaxDropDownItems = ((short)(5));
            this.cmb_SetSpu.MaxLength = 1;
            this.cmb_SetSpu.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SetSpu.Name = "cmb_SetSpu";
            this.cmb_SetSpu.OddRowStyle = style150;
            this.cmb_SetSpu.PartialRightColumn = false;
            this.cmb_SetSpu.PropBag = resources.GetString("cmb_SetSpu.PropBag");
            this.cmb_SetSpu.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SetSpu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SetSpu.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SetSpu.SelectedStyle = style151;
            this.cmb_SetSpu.Size = new System.Drawing.Size(120, 21);
            this.cmb_SetSpu.Style = style152;
            this.cmb_SetSpu.TabIndex = 12;
            // 
            // cmb_SetHpuSpu
            // 
            this.cmb_SetHpuSpu.AddItemCols = 0;
            this.cmb_SetHpuSpu.AddItemSeparator = ';';
            this.cmb_SetHpuSpu.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SetHpuSpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SetHpuSpu.Caption = "";
            this.cmb_SetHpuSpu.CaptionHeight = 17;
            this.cmb_SetHpuSpu.CaptionStyle = style153;
            this.cmb_SetHpuSpu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SetHpuSpu.ColumnCaptionHeight = 18;
            this.cmb_SetHpuSpu.ColumnFooterHeight = 18;
            this.cmb_SetHpuSpu.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SetHpuSpu.ContentHeight = 17;
            this.cmb_SetHpuSpu.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SetHpuSpu.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SetHpuSpu.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SetHpuSpu.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SetHpuSpu.EditorHeight = 17;
            this.cmb_SetHpuSpu.EvenRowStyle = style154;
            this.cmb_SetHpuSpu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_SetHpuSpu.FooterStyle = style155;
            this.cmb_SetHpuSpu.GapHeight = 2;
            this.cmb_SetHpuSpu.HeadingStyle = style156;
            this.cmb_SetHpuSpu.HighLightRowStyle = style157;
            this.cmb_SetHpuSpu.ItemHeight = 15;
            this.cmb_SetHpuSpu.Location = new System.Drawing.Point(349, 166);
            this.cmb_SetHpuSpu.MatchEntryTimeout = ((long)(2000));
            this.cmb_SetHpuSpu.MaxDropDownItems = ((short)(5));
            this.cmb_SetHpuSpu.MaxLength = 1;
            this.cmb_SetHpuSpu.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SetHpuSpu.Name = "cmb_SetHpuSpu";
            this.cmb_SetHpuSpu.OddRowStyle = style158;
            this.cmb_SetHpuSpu.PartialRightColumn = false;
            this.cmb_SetHpuSpu.PropBag = resources.GetString("cmb_SetHpuSpu.PropBag");
            this.cmb_SetHpuSpu.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SetHpuSpu.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SetHpuSpu.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SetHpuSpu.SelectedStyle = style159;
            this.cmb_SetHpuSpu.Size = new System.Drawing.Size(120, 21);
            this.cmb_SetHpuSpu.Style = style160;
            this.cmb_SetHpuSpu.TabIndex = 11;
            // 
            // txt_Remark
            // 
            this.txt_Remark.BackColor = System.Drawing.Color.White;
            this.txt_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Remark.Location = new System.Drawing.Point(113, 210);
            this.txt_Remark.MaxLength = 30;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(356, 21);
            this.txt_Remark.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.img_Label;
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 475;
            this.label9.Text = "Remark";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_DC_Model
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(494, 344);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_DC_Model";
            this.Load += new System.EventHandler(this.Pop_DC_Model_Load);
            this.Closed += new System.EventHandler(this.Pop_DC_Model_Closed);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetPhSpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ToolCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetPh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PhType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetHpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetSpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SetHpuSpu)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.GroupBox groupBox1;
		private string[] _data = new string[(int)ClassLib.TBSDC_MODEL.IxMaxCt + 1];
		//		private System.EventHandler _txtContNoEvent = null;
		//		private System.EventHandler _cmbContNoEvent = null;

		#endregion

		#region 컨트롤 이벤트 처리

		private void Pop_DC_Model_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);		
		}

		private void txt_contNo_TextChanged(object sender, System.EventArgs e)
		{
			this.Txt_ContNoTextChangedProcess();
		}

		private void cmb_contNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ContNoSelectedValueChangedProcess();
		}

		private void btn_virtual_Click(object sender, System.EventArgs e)
		{
			this.Btn_VirtualContainerClickProcess();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region 공통 메서드

		// Get data from control
		private string[] GetData(string arg_div)
		{
			string TempModel = COM.ComFunction.Empty_Combo(this.cmb_Year, "") + COM.ComFunction.Empty_Combo(this.cmb_Season, "") + COM.ComFunction.Empty_Combo(this.cmb_Category, "");
			
			_data[0]									   = arg_div;
			_data[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD]    = this.txt_ModelCd.Text==""? TempModel:this.txt_ModelCd.Text; 
			_data[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME]  = this.txt_Name.Text;
			_data[(int)ClassLib.TBSDC_MODEL.IxCATEGORY]    = COM.ComFunction.Empty_Combo(this.cmb_Category, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxPATTERN]     = this.txt_Pattern.Text;
			_data[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD]     = COM.ComFunction.Empty_Combo(this.cmb_ToolCd, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxSET_PH]      = COM.ComFunction.Empty_Combo(this.cmb_SetPh, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU]  = COM.ComFunction.Empty_Combo(this.cmb_SetPhSpu, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE]     = COM.ComFunction.Empty_Combo(this.cmb_PhType, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxSET_HPU]     = COM.ComFunction.Empty_Combo(this.cmb_SetHpu, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU] = COM.ComFunction.Empty_Combo(this.cmb_SetHpuSpu, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxSET_SPU]     = COM.ComFunction.Empty_Combo(this.cmb_SetSpu, "");
			_data[(int)ClassLib.TBSDC_MODEL.IxREMARKS]	   = this.txt_Remark.Text;
			_data[(int)ClassLib.TBSDC_MODEL.IxUPD_YMD]     = "";
			_data[(int)ClassLib.TBSDC_MODEL.IxUPD_USR]     = COM.ComVar.This_User;

			return _data;
		}

		// Set data to control from datatable
		private void SetDataFromDataTable(DataTable arg_dt)
		{
			try
			{
				if (arg_dt.Rows.Count > 0)
				{
					this.txt_ModelCd.Text			 = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD - 1].ToString();
					this.txt_Name.Text				 = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME - 1].ToString();
					this.cmb_Category.SelectedValue  = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxCATEGORY - 1].ToString();
					this.txt_Pattern.Text			 = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxPATTERN - 1].ToString();
					this.cmb_ToolCd.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD - 1].ToString();
					this.cmb_SetPh.SelectedValue     = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxSET_PH - 1].ToString();
					this.cmb_SetPhSpu.SelectedValue  = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU - 1].ToString();
					this.cmb_PhType.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE - 1].ToString();
					this.cmb_SetHpu.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxSET_HPU - 1].ToString();
					this.cmb_SetHpuSpu.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU - 1].ToString();
					this.cmb_SetSpu.SelectedValue    = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxSET_SPU - 1].ToString();
					this.txt_Remark.Text			 = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSDC_MODEL.IxREMARKS - 1].ToString();

					this.cmb_Year.SelectedValue      = txt_ModelCd.Text.Substring(0,2).ToString();
					this.cmb_Season.SelectedValue    = txt_ModelCd.Text.Substring(2,2).ToString();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Set data to control from parameter_popup
		private void SetDataFromParameter()
		{
			try
			{
				
				this.txt_ModelCd.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_CD];
				this.txt_Name.Text				 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxMODEL_NAME];
				this.cmb_Category.SelectedValue  = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxCATEGORY];
				this.txt_Pattern.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPATTERN];
				this.cmb_ToolCd.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxTOOL_CD];
				this.cmb_SetPh.SelectedValue     = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH];
				this.cmb_SetPhSpu.SelectedValue  = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_PH_SPU];
				this.cmb_PhType.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxPH_TYPE];
				this.cmb_SetHpu.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU];
				this.cmb_SetHpuSpu.SelectedValue = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_HPU_SPU];
				this.cmb_SetSpu.SelectedValue    = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxSET_SPU];
				this.txt_Remark.Text			 = COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSDC_MODEL.IxREMARKS];

				this.cmb_Year.SelectedValue      = txt_ModelCd.Text.ToString().Substring(0,2);
				this.cmb_Season.SelectedValue    = txt_ModelCd.Text.ToString().Substring(2,2);
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

//		// string(yyyy-mm-dd) to DateTime
//		private DateTime StringToDateTime(string strDate)
//		{
//			if (strDate != null || !strDate.Equals(""))
//				return new DateTime(Convert.ToInt32(strDate.Substring(0, 4)), Convert.ToInt32(strDate.Substring(5, 2)), Convert.ToInt32(strDate.Substring(8, 2)));
//			else
//				return System.DateTime.Now;
//		}

//		// create combo
//		public void CreateComboBox(C1.Win.C1List.C1Combo arg_cmb, string[] code, string[] name)
//		{
//			int i;
//			
//			try
//			{
//				arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
//				arg_cmb.ClearItems(); 
//
//				arg_cmb.AddItemTitles("Unit;Code"); 
//			
//				arg_cmb.ValueMember = "Unit";
//				arg_cmb.DisplayMember = "Code";
//			
//				for(i = 0 ; i < code.Length ; i++) 
//					arg_cmb.AddItem(code[i] + ";" + name[i]);
//		
//				arg_cmb.SelectedIndex = -1;  
//
//				arg_cmb.MaxDropDownItems = 10;
//				arg_cmb.Splits[0].DisplayColumns[0].Width = 50;
//				arg_cmb.Splits[0].DisplayColumns[1].Width = 150;
//				arg_cmb.Splits[0].DisplayColumns[0].Visible = false;
//
//				arg_cmb.ExtendRightColumn = true;
//				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
//			}
//		}

		#endregion
		
		#region 이벤트 처리 메서드

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			this.Text = "Model Master";
            lbl_MainTitle.Text = "Model Master";
            ClassLib.ComFunction.SetLangDic(this);
			
			
			DataTable vDt = null;

//			Category Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxCategory);
			COM.ComCtl.Set_ComboList(vDt, cmb_Category, 1, 2, false);
			vDt.Dispose();

//			ToolCd Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_ToolCd, 1, 2, false);
			vDt.Dispose();

//			SetPh Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_SetPh, 1, 2, false);
			vDt.Dispose();

//			SetPhSpu Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_SetPhSpu, 1, 2, false);
			vDt.Dispose();

//			PhType Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxPhType);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_PhType, 1, 2, false);
			vDt.Dispose();

//			SetHpu Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_SetHpu, 1, 2, false);
			vDt.Dispose();

//			SetHpuSpu Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_SetHpuSpu, 1, 2, false);
			vDt.Dispose();

//			SetSpu Setting Y/N
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxUseYN);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_SetSpu, 1, 2, false);
			vDt.Dispose();

//			Year Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxYear);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Year, 1, 2, false);
			vDt.Dispose();

//			Season Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxSeason);
			COM.ComCtl.Set_ComboList(vDt, this.cmb_Season, 1, 2, false);
			vDt.Dispose();

		    cmb_SetHpuSpu.Enabled  = false;
			cmb_SetPhSpu.Enabled   = false;

			
			
//			_txtContNoEvent = new System.EventHandler(this.txt_contNo_TextChanged);
//			this.txt_contNo.TextChanged += _txtContNoEvent;
//			_cmbContNoEvent = new System.EventHandler(this.cmb_contNo_SelectedValueChanged);

			if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Update))
			{
				SetDataFromDataTable( SELECT_SDC_MODEL(COM.ComVar.Parameter_PopUp[1]));
				this.txt_ModelCd.Enabled = false;
				//this.txt_ModelCd.Enabled = true; 
				this.cmb_Year.Enabled    = false;
				this.cmb_Season.Enabled  = false;
				this.txt_Name.Enabled    = false;
			}
			else if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Insert))
			{
				SetDataFromParameter();
			}
			else
			{
				this.txt_ModelCd.Enabled		 = true;
				//				cmb_shipFactory.ReadOnly = false;
			}
		}

		private void Txt_ContNoTextChangedProcess()
		{
			//			this.cmb_contNo.SelectedValueChanged -= _cmbContNoEvent;
			//
			//			DataTable vDt = this.SELECT_SBC_CONTAINER_LIST(txt_contNo.Text, "", "Y");
			//			COM.ComCtl.Set_ComboList(vDt, cmb_contNo, 1, 0, "Unit", "Code", false);
			//			cmb_contNo.Splits[0].DisplayColumns[0].Visible = false;
			//			vDt.Dispose();
			//
			//			this.cmb_contNo.SelectedValueChanged += _cmbContNoEvent;
		}

		private void Cmb_ContNoSelectedValueChangedProcess()
		{
			//			this.txt_contNo.TextChanged -= _txtContNoEvent;
			//
			//			txt_contNo.Text				= cmb_contNo.GetItemText(cmb_contNo.SelectedIndex, 1);
			//			cmb_contUnit.SelectedValue	= cmb_contNo.GetItemText(cmb_contNo.SelectedIndex, 0);
			//
			//			this.txt_contNo.TextChanged += _txtContNoEvent;
		}

		private void Btn_VirtualContainerClickProcess()
		{
			//			this.cmb_contNo.SelectedValueChanged -= _cmbContNoEvent;
			//			this.txt_contNo.TextChanged -= _txtContNoEvent;
			//			txt_contNo.Text = "";
			//			CreateComboBox(cmb_contNo, new string[]{"40FT", "40FT", "40FT", "40FT", "40FT"}, new string[]{"Virtual001", "Virtual002", "Virtual003", "Virtual004", "Virtual005"});
			//			this.txt_contNo.TextChanged += _txtContNoEvent;
			//			this.cmb_contNo.SelectedValueChanged += _cmbContNoEvent;
		}

		private void Btn_ApplyClickProcess()
		{
//			if(this.txt_ModelCd.Text == "" )
//			{
				if(this.txt_ModelCd.Text != "" || this.cmb_Year.SelectedIndex != -1 || this.cmb_Season.SelectedIndex != -1 || this.cmb_Category.SelectedIndex != -1 || this.txt_Name.Text != "")
				{
					bool check_exist = false;
					string vCodeCd   = "";
					string vCodeNm   = "";

					// true : 중복 발생, false : 신규 처리 가능
					//vCodeCd = COM.ComFunction.Empty_Combo(this.cmb_Year, "") + COM.ComFunction.Empty_Combo(this.cmb_Season, "") + COM.ComFunction.Empty_Combo(this.cmb_Category, "");
					vCodeCd = this.txt_ModelCd.Text;
					vCodeNm = this.txt_Name.Text;

					check_exist = CHECK_MODEL_EXIST(vCodeCd, vCodeNm);

					if(!check_exist)
					{
						COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Insert);
						this.DialogResult = DialogResult.OK;
						Close(); 
					}
					else
					{
						ClassLib.ComFunction.User_Message("Duplicate Model");
					}
				}
				else
				{
					if(this.txt_ModelCd.Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Model Code");     
						return;
					}

					if(this.cmb_Year.SelectedIndex     == -1)   
					{
						ClassLib.ComFunction.User_Message("Select Year");     
						return;
					}

					if(this.cmb_Season.SelectedIndex   == -1)   ClassLib.ComFunction.User_Message("Select Season");   
					if(this.cmb_Category.SelectedIndex == -1)   ClassLib.ComFunction.User_Message("Select Category"); 
					if(this.txt_Name.Text              == "")   ClassLib.ComFunction.User_Message("Select Name");	 
				}
//			}

		}

		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SDC_MODEL : 
		/// </summary>
		/// <param name="arg_model_cd"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SDC_MODEL(string arg_model_cd)
		{
			try
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(5);


				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);


				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SDC_MODEL.SELECT_SDC_MODEL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD";
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_NAME";
				MyOraDB.Parameter_Name[2] = "ARG_YEAR";
				MyOraDB.Parameter_Name[3] = "ARG_SEASON_CODE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_model_cd;
				MyOraDB.Parameter_Values[1] = "";
				MyOraDB.Parameter_Values[2] = "";
				MyOraDB.Parameter_Values[3] = "";
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();

				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return null;


			}
		}


		/// <summary>
		/// CHECK_MODEL_EXIST : 모델명 중복 체크
		/// </summary>
		/// <param name="arg_model_cd">  model cd</param>
		/// <param name="arg_model_name">model name</param>
		/// <returns>true : 중복 발생, false : 신규 처리 가능</returns>
		private bool CHECK_MODEL_EXIST(string arg_model_cd, string arg_model_name)
		{ 
			try
			{

				COM.OraDB MyOraDB = new COM.OraDB(); 
				DataSet ds_ret;
				string exist_yn = "";
 
				MyOraDB.ReDim_Parameter(3);  

				//Webservice Change - DS 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);
			
				MyOraDB.Process_Name = "PKG_SDC_MODEL.CHECK_MODEL_EXIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_MODEL_CD"; 
				MyOraDB.Parameter_Name[1] = "ARG_MODEL_NAME"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
			 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 
			    
				MyOraDB.Parameter_Values[0] = arg_model_cd; 
				MyOraDB.Parameter_Values[1] = arg_model_name; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();


				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);


				if(ds_ret == null) return false; 
				exist_yn = ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 


				if(exist_yn == "Y")
					return true;
				else
					return false;

			}
			catch
			{
				//Webservice Change - This Factory  
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);
				return false;

			}

		}

		#endregion

		#region 정합성 체크


		#endregion


		
		private void Pop_DC_Model_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
	}
}

