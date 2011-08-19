using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.MaterialBase
{
	public class Pop_GroupInfo : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Group_S;
		private System.Windows.Forms.Label lbl_Group_M;
		private System.Windows.Forms.Label lbl_Group_L;
		private System.Windows.Forms.Label lbl_Group_Type;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_Group_Name;
		private System.Windows.Forms.Label lbl_Group_CD;
		private System.Windows.Forms.TextBox txt_Group_M;
		private System.Windows.Forms.TextBox txt_Group_Type;
		private System.Windows.Forms.TextBox txt_Group_L;
		private System.Windows.Forms.TextBox txt_Group_S;
		private System.Windows.Forms.TextBox txt_Group_Name;
		private System.Windows.Forms.TextBox txt_Group_CD;
		private System.Windows.Forms.TextBox txt_Group_TName;
		private System.Windows.Forms.TextBox txt_Group_LName;
		private System.Windows.Forms.TextBox txt_Group_MName;
		private System.Windows.Forms.TextBox txt_Group_SName;
		private System.Windows.Forms.TextBox txt_Level;
		private System.Windows.Forms.Label lbl_level;
		private C1.Win.C1List.C1Combo cmb_UseYN;
		private System.Windows.Forms.Label lbl_UseYN;
		private System.Windows.Forms.Label lbl_Attribute;
		private System.Windows.Forms.CheckBox chk_Model;
		private System.Windows.Forms.CheckBox chk_Style;
		private System.Windows.Forms.CheckBox chk_Cmp;
		private System.Windows.Forms.CheckBox chk_Gen;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txt_Man_Charge_DS;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_DS;
		private System.Windows.Forms.TextBox txt_Man_Charge_QD;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_QD;
		private System.Windows.Forms.TextBox txt_Man_Charge_VJ;
		private C1.Win.C1List.C1Combo cmb_Man_Charge_VJ;
		private System.Windows.Forms.Label lbl_Man_Charge_DS;
		private System.Windows.Forms.Label lbl_Man_Charge_QD;
		private System.Windows.Forms.Label lbl_Man_Charge_VJ;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lbl_Price;
		private System.Windows.Forms.Label lbl_Currency;
		private System.Windows.Forms.TextBox txt_Price;
		private C1.Win.C1List.C1Combo cmb_Currency;
        private TextBox txt_Man_Charge_JJ;
        private C1.Win.C1List.C1Combo cmb_Man_Charge_JJ;
        private Label lbl_Man_Charge_JJ;
		private System.ComponentModel.IContainer components = null;

		public Pop_GroupInfo()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_GroupInfo));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Group_SName = new System.Windows.Forms.TextBox();
            this.txt_Group_MName = new System.Windows.Forms.TextBox();
            this.txt_Group_LName = new System.Windows.Forms.TextBox();
            this.txt_Group_TName = new System.Windows.Forms.TextBox();
            this.txt_Group_S = new System.Windows.Forms.TextBox();
            this.txt_Group_L = new System.Windows.Forms.TextBox();
            this.txt_Group_Type = new System.Windows.Forms.TextBox();
            this.txt_Group_M = new System.Windows.Forms.TextBox();
            this.lbl_Group_S = new System.Windows.Forms.Label();
            this.lbl_Group_M = new System.Windows.Forms.Label();
            this.lbl_Group_L = new System.Windows.Forms.Label();
            this.lbl_Group_Type = new System.Windows.Forms.Label();
            this.lbl_Group_CD = new System.Windows.Forms.Label();
            this.txt_Level = new System.Windows.Forms.TextBox();
            this.lbl_level = new System.Windows.Forms.Label();
            this.txt_Group_CD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_Gen = new System.Windows.Forms.CheckBox();
            this.chk_Cmp = new System.Windows.Forms.CheckBox();
            this.chk_Style = new System.Windows.Forms.CheckBox();
            this.lbl_Attribute = new System.Windows.Forms.Label();
            this.chk_Model = new System.Windows.Forms.CheckBox();
            this.cmb_UseYN = new C1.Win.C1List.C1Combo();
            this.lbl_UseYN = new System.Windows.Forms.Label();
            this.txt_Group_Name = new System.Windows.Forms.TextBox();
            this.lbl_Group_Name = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Man_Charge_JJ = new System.Windows.Forms.TextBox();
            this.cmb_Man_Charge_JJ = new C1.Win.C1List.C1Combo();
            this.lbl_Man_Charge_JJ = new System.Windows.Forms.Label();
            this.txt_Man_Charge_VJ = new System.Windows.Forms.TextBox();
            this.cmb_Man_Charge_VJ = new C1.Win.C1List.C1Combo();
            this.txt_Man_Charge_QD = new System.Windows.Forms.TextBox();
            this.cmb_Man_Charge_QD = new C1.Win.C1List.C1Combo();
            this.txt_Man_Charge_DS = new System.Windows.Forms.TextBox();
            this.cmb_Man_Charge_DS = new C1.Win.C1List.C1Combo();
            this.lbl_Man_Charge_QD = new System.Windows.Forms.Label();
            this.lbl_Man_Charge_VJ = new System.Windows.Forms.Label();
            this.lbl_Man_Charge_DS = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cmb_Currency = new C1.Win.C1List.C1Combo();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_JJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_VJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_QD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_DS)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Currency)).BeginInit();
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
            this.lbl_MainTitle.Location = new System.Drawing.Point(34, 7);
            this.lbl_MainTitle.Size = new System.Drawing.Size(358, 22);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Group_SName);
            this.groupBox1.Controls.Add(this.txt_Group_MName);
            this.groupBox1.Controls.Add(this.txt_Group_LName);
            this.groupBox1.Controls.Add(this.txt_Group_TName);
            this.groupBox1.Controls.Add(this.txt_Group_S);
            this.groupBox1.Controls.Add(this.txt_Group_L);
            this.groupBox1.Controls.Add(this.txt_Group_Type);
            this.groupBox1.Controls.Add(this.txt_Group_M);
            this.groupBox1.Controls.Add(this.lbl_Group_S);
            this.groupBox1.Controls.Add(this.lbl_Group_M);
            this.groupBox1.Controls.Add(this.lbl_Group_L);
            this.groupBox1.Controls.Add(this.lbl_Group_Type);
            this.groupBox1.Controls.Add(this.lbl_Group_CD);
            this.groupBox1.Controls.Add(this.txt_Level);
            this.groupBox1.Controls.Add(this.lbl_level);
            this.groupBox1.Controls.Add(this.txt_Group_CD);
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 127);
            this.groupBox1.TabIndex = 591;
            this.groupBox1.TabStop = false;
            // 
            // txt_Group_SName
            // 
            this.txt_Group_SName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_SName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_SName.Location = new System.Drawing.Point(141, 78);
            this.txt_Group_SName.MaxLength = 50;
            this.txt_Group_SName.Name = "txt_Group_SName";
            this.txt_Group_SName.ReadOnly = true;
            this.txt_Group_SName.Size = new System.Drawing.Size(235, 21);
            this.txt_Group_SName.TabIndex = 8;
            this.txt_Group_SName.TabStop = false;
            // 
            // txt_Group_MName
            // 
            this.txt_Group_MName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_MName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_MName.Location = new System.Drawing.Point(141, 56);
            this.txt_Group_MName.MaxLength = 50;
            this.txt_Group_MName.Name = "txt_Group_MName";
            this.txt_Group_MName.ReadOnly = true;
            this.txt_Group_MName.Size = new System.Drawing.Size(235, 21);
            this.txt_Group_MName.TabIndex = 6;
            this.txt_Group_MName.TabStop = false;
            // 
            // txt_Group_LName
            // 
            this.txt_Group_LName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_LName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_LName.Location = new System.Drawing.Point(141, 34);
            this.txt_Group_LName.MaxLength = 50;
            this.txt_Group_LName.Name = "txt_Group_LName";
            this.txt_Group_LName.ReadOnly = true;
            this.txt_Group_LName.Size = new System.Drawing.Size(235, 21);
            this.txt_Group_LName.TabIndex = 4;
            this.txt_Group_LName.TabStop = false;
            // 
            // txt_Group_TName
            // 
            this.txt_Group_TName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_TName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_TName.Location = new System.Drawing.Point(141, 12);
            this.txt_Group_TName.MaxLength = 50;
            this.txt_Group_TName.Name = "txt_Group_TName";
            this.txt_Group_TName.ReadOnly = true;
            this.txt_Group_TName.Size = new System.Drawing.Size(235, 21);
            this.txt_Group_TName.TabIndex = 2;
            this.txt_Group_TName.TabStop = false;
            // 
            // txt_Group_S
            // 
            this.txt_Group_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_S.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_S.Location = new System.Drawing.Point(108, 78);
            this.txt_Group_S.MaxLength = 3;
            this.txt_Group_S.Name = "txt_Group_S";
            this.txt_Group_S.ReadOnly = true;
            this.txt_Group_S.Size = new System.Drawing.Size(32, 21);
            this.txt_Group_S.TabIndex = 7;
            this.txt_Group_S.TabStop = false;
            // 
            // txt_Group_L
            // 
            this.txt_Group_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_L.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_L.Location = new System.Drawing.Point(108, 34);
            this.txt_Group_L.MaxLength = 1;
            this.txt_Group_L.Name = "txt_Group_L";
            this.txt_Group_L.ReadOnly = true;
            this.txt_Group_L.Size = new System.Drawing.Size(32, 21);
            this.txt_Group_L.TabIndex = 3;
            this.txt_Group_L.TabStop = false;
            // 
            // txt_Group_Type
            // 
            this.txt_Group_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_Type.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_Type.Location = new System.Drawing.Point(108, 12);
            this.txt_Group_Type.MaxLength = 2;
            this.txt_Group_Type.Name = "txt_Group_Type";
            this.txt_Group_Type.ReadOnly = true;
            this.txt_Group_Type.Size = new System.Drawing.Size(32, 21);
            this.txt_Group_Type.TabIndex = 1;
            this.txt_Group_Type.TabStop = false;
            // 
            // txt_Group_M
            // 
            this.txt_Group_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_M.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_M.Location = new System.Drawing.Point(108, 56);
            this.txt_Group_M.MaxLength = 2;
            this.txt_Group_M.Name = "txt_Group_M";
            this.txt_Group_M.ReadOnly = true;
            this.txt_Group_M.Size = new System.Drawing.Size(32, 21);
            this.txt_Group_M.TabIndex = 5;
            this.txt_Group_M.TabStop = false;
            // 
            // lbl_Group_S
            // 
            this.lbl_Group_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_S.ImageIndex = 0;
            this.lbl_Group_S.ImageList = this.img_Label;
            this.lbl_Group_S.Location = new System.Drawing.Point(7, 78);
            this.lbl_Group_S.Name = "lbl_Group_S";
            this.lbl_Group_S.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_S.TabIndex = 603;
            this.lbl_Group_S.Text = "Class (Third)";
            this.lbl_Group_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_M
            // 
            this.lbl_Group_M.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_M.ImageIndex = 0;
            this.lbl_Group_M.ImageList = this.img_Label;
            this.lbl_Group_M.Location = new System.Drawing.Point(7, 56);
            this.lbl_Group_M.Name = "lbl_Group_M";
            this.lbl_Group_M.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_M.TabIndex = 602;
            this.lbl_Group_M.Text = "Class (Second)";
            this.lbl_Group_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_L
            // 
            this.lbl_Group_L.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_L.ImageIndex = 0;
            this.lbl_Group_L.ImageList = this.img_Label;
            this.lbl_Group_L.Location = new System.Drawing.Point(7, 34);
            this.lbl_Group_L.Name = "lbl_Group_L";
            this.lbl_Group_L.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_L.TabIndex = 601;
            this.lbl_Group_L.Text = "Class (First)";
            this.lbl_Group_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_Type
            // 
            this.lbl_Group_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Group_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_Type.ImageIndex = 0;
            this.lbl_Group_Type.ImageList = this.img_Label;
            this.lbl_Group_Type.Location = new System.Drawing.Point(7, 12);
            this.lbl_Group_Type.Name = "lbl_Group_Type";
            this.lbl_Group_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_Type.TabIndex = 600;
            this.lbl_Group_Type.Text = "Type";
            this.lbl_Group_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_CD
            // 
            this.lbl_Group_CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Group_CD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_CD.ImageIndex = 0;
            this.lbl_Group_CD.ImageList = this.img_Label;
            this.lbl_Group_CD.Location = new System.Drawing.Point(7, 100);
            this.lbl_Group_CD.Name = "lbl_Group_CD";
            this.lbl_Group_CD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_CD.TabIndex = 600;
            this.lbl_Group_CD.Text = "Code";
            this.lbl_Group_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Level
            // 
            this.txt_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Level.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Level.Location = new System.Drawing.Point(345, 100);
            this.txt_Level.MaxLength = 3;
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.ReadOnly = true;
            this.txt_Level.Size = new System.Drawing.Size(31, 21);
            this.txt_Level.TabIndex = 10;
            this.txt_Level.TabStop = false;
            // 
            // lbl_level
            // 
            this.lbl_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_level.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level.ImageIndex = 0;
            this.lbl_level.ImageList = this.img_Label;
            this.lbl_level.Location = new System.Drawing.Point(244, 100);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(100, 21);
            this.lbl_level.TabIndex = 615;
            this.lbl_level.Text = "Level";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Group_CD
            // 
            this.txt_Group_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_CD.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_CD.Location = new System.Drawing.Point(108, 100);
            this.txt_Group_CD.MaxLength = 10;
            this.txt_Group_CD.Name = "txt_Group_CD";
            this.txt_Group_CD.ReadOnly = true;
            this.txt_Group_CD.Size = new System.Drawing.Size(111, 21);
            this.txt_Group_CD.TabIndex = 9;
            this.txt_Group_CD.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chk_Gen);
            this.groupBox2.Controls.Add(this.chk_Cmp);
            this.groupBox2.Controls.Add(this.chk_Style);
            this.groupBox2.Controls.Add(this.lbl_Attribute);
            this.groupBox2.Controls.Add(this.chk_Model);
            this.groupBox2.Controls.Add(this.cmb_UseYN);
            this.groupBox2.Controls.Add(this.lbl_UseYN);
            this.groupBox2.Controls.Add(this.txt_Group_Name);
            this.groupBox2.Controls.Add(this.lbl_Group_Name);
            this.groupBox2.Location = new System.Drawing.Point(5, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 83);
            this.groupBox2.TabIndex = 592;
            this.groupBox2.TabStop = false;
            // 
            // chk_Gen
            // 
            this.chk_Gen.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.chk_Gen.Location = new System.Drawing.Point(315, 34);
            this.chk_Gen.Name = "chk_Gen";
            this.chk_Gen.Size = new System.Drawing.Size(64, 21);
            this.chk_Gen.TabIndex = 622;
            this.chk_Gen.Text = "Gender";
            this.chk_Gen.UseVisualStyleBackColor = false;
            // 
            // chk_Cmp
            // 
            this.chk_Cmp.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Cmp.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.chk_Cmp.Location = new System.Drawing.Point(224, 34);
            this.chk_Cmp.Name = "chk_Cmp";
            this.chk_Cmp.Size = new System.Drawing.Size(92, 21);
            this.chk_Cmp.TabIndex = 621;
            this.chk_Cmp.Text = "Component";
            this.chk_Cmp.UseVisualStyleBackColor = false;
            // 
            // chk_Style
            // 
            this.chk_Style.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.chk_Style.Location = new System.Drawing.Point(168, 34);
            this.chk_Style.Name = "chk_Style";
            this.chk_Style.Size = new System.Drawing.Size(56, 21);
            this.chk_Style.TabIndex = 620;
            this.chk_Style.Text = "Style";
            this.chk_Style.UseVisualStyleBackColor = false;
            // 
            // lbl_Attribute
            // 
            this.lbl_Attribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Attribute.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Attribute.ImageIndex = 0;
            this.lbl_Attribute.ImageList = this.img_Label;
            this.lbl_Attribute.Location = new System.Drawing.Point(7, 34);
            this.lbl_Attribute.Name = "lbl_Attribute";
            this.lbl_Attribute.Size = new System.Drawing.Size(100, 21);
            this.lbl_Attribute.TabIndex = 619;
            this.lbl_Attribute.Text = "Attribute";
            this.lbl_Attribute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_Model
            // 
            this.chk_Model.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.chk_Model.Location = new System.Drawing.Point(108, 34);
            this.chk_Model.Name = "chk_Model";
            this.chk_Model.Size = new System.Drawing.Size(60, 21);
            this.chk_Model.TabIndex = 618;
            this.chk_Model.Text = "Model";
            this.chk_Model.UseVisualStyleBackColor = false;
            // 
            // cmb_UseYN
            // 
            this.cmb_UseYN.AddItemCols = 0;
            this.cmb_UseYN.AddItemSeparator = ';';
            this.cmb_UseYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UseYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UseYN.Caption = "";
            this.cmb_UseYN.CaptionHeight = 17;
            this.cmb_UseYN.CaptionStyle = style1;
            this.cmb_UseYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UseYN.ColumnCaptionHeight = 18;
            this.cmb_UseYN.ColumnFooterHeight = 18;
            this.cmb_UseYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UseYN.ContentHeight = 17;
            this.cmb_UseYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UseYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UseYN.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UseYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UseYN.EditorHeight = 17;
            this.cmb_UseYN.EvenRowStyle = style2;
            this.cmb_UseYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_UseYN.FooterStyle = style3;
            this.cmb_UseYN.GapHeight = 2;
            this.cmb_UseYN.HeadingStyle = style4;
            this.cmb_UseYN.HighLightRowStyle = style5;
            this.cmb_UseYN.ItemHeight = 15;
            this.cmb_UseYN.Location = new System.Drawing.Point(108, 56);
            this.cmb_UseYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_UseYN.MaxDropDownItems = ((short)(5));
            this.cmb_UseYN.MaxLength = 1;
            this.cmb_UseYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UseYN.Name = "cmb_UseYN";
            this.cmb_UseYN.OddRowStyle = style6;
            this.cmb_UseYN.PartialRightColumn = false;
            this.cmb_UseYN.PropBag = resources.GetString("cmb_UseYN.PropBag");
            this.cmb_UseYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UseYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UseYN.SelectedStyle = style7;
            this.cmb_UseYN.Size = new System.Drawing.Size(268, 21);
            this.cmb_UseYN.Style = style8;
            this.cmb_UseYN.TabIndex = 617;
            // 
            // lbl_UseYN
            // 
            this.lbl_UseYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_UseYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UseYN.ImageIndex = 0;
            this.lbl_UseYN.ImageList = this.img_Label;
            this.lbl_UseYN.Location = new System.Drawing.Point(7, 56);
            this.lbl_UseYN.Name = "lbl_UseYN";
            this.lbl_UseYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_UseYN.TabIndex = 616;
            this.lbl_UseYN.Text = "Use";
            this.lbl_UseYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Group_Name
            // 
            this.txt_Group_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Group_Name.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Group_Name.Location = new System.Drawing.Point(108, 11);
            this.txt_Group_Name.MaxLength = 500;
            this.txt_Group_Name.Name = "txt_Group_Name";
            this.txt_Group_Name.Size = new System.Drawing.Size(268, 21);
            this.txt_Group_Name.TabIndex = 0;
            // 
            // lbl_Group_Name
            // 
            this.lbl_Group_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Group_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group_Name.ImageIndex = 0;
            this.lbl_Group_Name.ImageList = this.img_Label;
            this.lbl_Group_Name.Location = new System.Drawing.Point(7, 12);
            this.lbl_Group_Name.Name = "lbl_Group_Name";
            this.lbl_Group_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_Name.TabIndex = 601;
            this.lbl_Group_Name.Text = "Name";
            this.lbl_Group_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txt_Man_Charge_JJ);
            this.groupBox3.Controls.Add(this.cmb_Man_Charge_JJ);
            this.groupBox3.Controls.Add(this.lbl_Man_Charge_JJ);
            this.groupBox3.Controls.Add(this.txt_Man_Charge_VJ);
            this.groupBox3.Controls.Add(this.cmb_Man_Charge_VJ);
            this.groupBox3.Controls.Add(this.txt_Man_Charge_QD);
            this.groupBox3.Controls.Add(this.cmb_Man_Charge_QD);
            this.groupBox3.Controls.Add(this.txt_Man_Charge_DS);
            this.groupBox3.Controls.Add(this.cmb_Man_Charge_DS);
            this.groupBox3.Controls.Add(this.lbl_Man_Charge_QD);
            this.groupBox3.Controls.Add(this.lbl_Man_Charge_VJ);
            this.groupBox3.Controls.Add(this.lbl_Man_Charge_DS);
            this.groupBox3.Location = new System.Drawing.Point(5, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 108);
            this.groupBox3.TabIndex = 595;
            this.groupBox3.TabStop = false;
            // 
            // txt_Man_Charge_JJ
            // 
            this.txt_Man_Charge_JJ.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_JJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_JJ.Location = new System.Drawing.Point(108, 78);
            this.txt_Man_Charge_JJ.MaxLength = 10;
            this.txt_Man_Charge_JJ.Name = "txt_Man_Charge_JJ";
            this.txt_Man_Charge_JJ.Size = new System.Drawing.Size(111, 21);
            this.txt_Man_Charge_JJ.TabIndex = 627;
            this.txt_Man_Charge_JJ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Man_Charge_JJ
            // 
            this.cmb_Man_Charge_JJ.AddItemCols = 0;
            this.cmb_Man_Charge_JJ.AddItemSeparator = ';';
            this.cmb_Man_Charge_JJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_JJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_JJ.Caption = "";
            this.cmb_Man_Charge_JJ.CaptionHeight = 17;
            this.cmb_Man_Charge_JJ.CaptionStyle = style9;
            this.cmb_Man_Charge_JJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_JJ.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_JJ.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_JJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_JJ.ContentHeight = 17;
            this.cmb_Man_Charge_JJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_JJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_JJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_JJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_JJ.EditorHeight = 17;
            this.cmb_Man_Charge_JJ.EvenRowStyle = style10;
            this.cmb_Man_Charge_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_JJ.FooterStyle = style11;
            this.cmb_Man_Charge_JJ.GapHeight = 2;
            this.cmb_Man_Charge_JJ.HeadingStyle = style12;
            this.cmb_Man_Charge_JJ.HighLightRowStyle = style13;
            this.cmb_Man_Charge_JJ.ItemHeight = 15;
            this.cmb_Man_Charge_JJ.Location = new System.Drawing.Point(220, 78);
            this.cmb_Man_Charge_JJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_JJ.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_JJ.MaxLength = 32767;
            this.cmb_Man_Charge_JJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_JJ.Name = "cmb_Man_Charge_JJ";
            this.cmb_Man_Charge_JJ.OddRowStyle = style14;
            this.cmb_Man_Charge_JJ.PartialRightColumn = false;
            this.cmb_Man_Charge_JJ.PropBag = resources.GetString("cmb_Man_Charge_JJ.PropBag");
            this.cmb_Man_Charge_JJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_JJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_JJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_JJ.SelectedStyle = style15;
            this.cmb_Man_Charge_JJ.Size = new System.Drawing.Size(156, 21);
            this.cmb_Man_Charge_JJ.Style = style16;
            this.cmb_Man_Charge_JJ.TabIndex = 628;
            this.cmb_Man_Charge_JJ.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // lbl_Man_Charge_JJ
            // 
            this.lbl_Man_Charge_JJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Man_Charge_JJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Man_Charge_JJ.ImageIndex = 0;
            this.lbl_Man_Charge_JJ.ImageList = this.img_Label;
            this.lbl_Man_Charge_JJ.Location = new System.Drawing.Point(7, 78);
            this.lbl_Man_Charge_JJ.Name = "lbl_Man_Charge_JJ";
            this.lbl_Man_Charge_JJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_JJ.TabIndex = 626;
            this.lbl_Man_Charge_JJ.Text = "Charge (JJ)";
            this.lbl_Man_Charge_JJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Man_Charge_VJ
            // 
            this.txt_Man_Charge_VJ.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_VJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_VJ.Location = new System.Drawing.Point(108, 56);
            this.txt_Man_Charge_VJ.MaxLength = 10;
            this.txt_Man_Charge_VJ.Name = "txt_Man_Charge_VJ";
            this.txt_Man_Charge_VJ.Size = new System.Drawing.Size(111, 21);
            this.txt_Man_Charge_VJ.TabIndex = 624;
            this.txt_Man_Charge_VJ.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Man_Charge_VJ
            // 
            this.cmb_Man_Charge_VJ.AddItemCols = 0;
            this.cmb_Man_Charge_VJ.AddItemSeparator = ';';
            this.cmb_Man_Charge_VJ.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_VJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_VJ.Caption = "";
            this.cmb_Man_Charge_VJ.CaptionHeight = 17;
            this.cmb_Man_Charge_VJ.CaptionStyle = style17;
            this.cmb_Man_Charge_VJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_VJ.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_VJ.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_VJ.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_VJ.ContentHeight = 17;
            this.cmb_Man_Charge_VJ.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_VJ.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_VJ.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_VJ.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_VJ.EditorHeight = 17;
            this.cmb_Man_Charge_VJ.EvenRowStyle = style18;
            this.cmb_Man_Charge_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_VJ.FooterStyle = style19;
            this.cmb_Man_Charge_VJ.GapHeight = 2;
            this.cmb_Man_Charge_VJ.HeadingStyle = style20;
            this.cmb_Man_Charge_VJ.HighLightRowStyle = style21;
            this.cmb_Man_Charge_VJ.ItemHeight = 15;
            this.cmb_Man_Charge_VJ.Location = new System.Drawing.Point(220, 56);
            this.cmb_Man_Charge_VJ.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_VJ.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_VJ.MaxLength = 32767;
            this.cmb_Man_Charge_VJ.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_VJ.Name = "cmb_Man_Charge_VJ";
            this.cmb_Man_Charge_VJ.OddRowStyle = style22;
            this.cmb_Man_Charge_VJ.PartialRightColumn = false;
            this.cmb_Man_Charge_VJ.PropBag = resources.GetString("cmb_Man_Charge_VJ.PropBag");
            this.cmb_Man_Charge_VJ.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_VJ.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_VJ.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_VJ.SelectedStyle = style23;
            this.cmb_Man_Charge_VJ.Size = new System.Drawing.Size(156, 21);
            this.cmb_Man_Charge_VJ.Style = style24;
            this.cmb_Man_Charge_VJ.TabIndex = 625;
            this.cmb_Man_Charge_VJ.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // txt_Man_Charge_QD
            // 
            this.txt_Man_Charge_QD.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_QD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_QD.Location = new System.Drawing.Point(108, 34);
            this.txt_Man_Charge_QD.MaxLength = 10;
            this.txt_Man_Charge_QD.Name = "txt_Man_Charge_QD";
            this.txt_Man_Charge_QD.Size = new System.Drawing.Size(111, 21);
            this.txt_Man_Charge_QD.TabIndex = 622;
            this.txt_Man_Charge_QD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Man_Charge_QD
            // 
            this.cmb_Man_Charge_QD.AddItemCols = 0;
            this.cmb_Man_Charge_QD.AddItemSeparator = ';';
            this.cmb_Man_Charge_QD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_QD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_QD.Caption = "";
            this.cmb_Man_Charge_QD.CaptionHeight = 17;
            this.cmb_Man_Charge_QD.CaptionStyle = style25;
            this.cmb_Man_Charge_QD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_QD.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_QD.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_QD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_QD.ContentHeight = 17;
            this.cmb_Man_Charge_QD.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_QD.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_QD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_QD.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_QD.EditorHeight = 17;
            this.cmb_Man_Charge_QD.EvenRowStyle = style26;
            this.cmb_Man_Charge_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_QD.FooterStyle = style27;
            this.cmb_Man_Charge_QD.GapHeight = 2;
            this.cmb_Man_Charge_QD.HeadingStyle = style28;
            this.cmb_Man_Charge_QD.HighLightRowStyle = style29;
            this.cmb_Man_Charge_QD.ItemHeight = 15;
            this.cmb_Man_Charge_QD.Location = new System.Drawing.Point(220, 34);
            this.cmb_Man_Charge_QD.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_QD.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_QD.MaxLength = 32767;
            this.cmb_Man_Charge_QD.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_QD.Name = "cmb_Man_Charge_QD";
            this.cmb_Man_Charge_QD.OddRowStyle = style30;
            this.cmb_Man_Charge_QD.PartialRightColumn = false;
            this.cmb_Man_Charge_QD.PropBag = resources.GetString("cmb_Man_Charge_QD.PropBag");
            this.cmb_Man_Charge_QD.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_QD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_QD.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_QD.SelectedStyle = style31;
            this.cmb_Man_Charge_QD.Size = new System.Drawing.Size(156, 21);
            this.cmb_Man_Charge_QD.Style = style32;
            this.cmb_Man_Charge_QD.TabIndex = 623;
            this.cmb_Man_Charge_QD.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // txt_Man_Charge_DS
            // 
            this.txt_Man_Charge_DS.BackColor = System.Drawing.Color.White;
            this.txt_Man_Charge_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Man_Charge_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Man_Charge_DS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Man_Charge_DS.Location = new System.Drawing.Point(108, 12);
            this.txt_Man_Charge_DS.MaxLength = 10;
            this.txt_Man_Charge_DS.Name = "txt_Man_Charge_DS";
            this.txt_Man_Charge_DS.Size = new System.Drawing.Size(111, 21);
            this.txt_Man_Charge_DS.TabIndex = 620;
            this.txt_Man_Charge_DS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeyUp);
            // 
            // cmb_Man_Charge_DS
            // 
            this.cmb_Man_Charge_DS.AddItemCols = 0;
            this.cmb_Man_Charge_DS.AddItemSeparator = ';';
            this.cmb_Man_Charge_DS.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Man_Charge_DS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Man_Charge_DS.Caption = "";
            this.cmb_Man_Charge_DS.CaptionHeight = 17;
            this.cmb_Man_Charge_DS.CaptionStyle = style33;
            this.cmb_Man_Charge_DS.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Man_Charge_DS.ColumnCaptionHeight = 18;
            this.cmb_Man_Charge_DS.ColumnFooterHeight = 18;
            this.cmb_Man_Charge_DS.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Man_Charge_DS.ContentHeight = 17;
            this.cmb_Man_Charge_DS.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Man_Charge_DS.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Man_Charge_DS.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Man_Charge_DS.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Man_Charge_DS.EditorHeight = 17;
            this.cmb_Man_Charge_DS.EvenRowStyle = style34;
            this.cmb_Man_Charge_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Man_Charge_DS.FooterStyle = style35;
            this.cmb_Man_Charge_DS.GapHeight = 2;
            this.cmb_Man_Charge_DS.HeadingStyle = style36;
            this.cmb_Man_Charge_DS.HighLightRowStyle = style37;
            this.cmb_Man_Charge_DS.ItemHeight = 15;
            this.cmb_Man_Charge_DS.Location = new System.Drawing.Point(220, 12);
            this.cmb_Man_Charge_DS.MatchEntryTimeout = ((long)(2000));
            this.cmb_Man_Charge_DS.MaxDropDownItems = ((short)(5));
            this.cmb_Man_Charge_DS.MaxLength = 32767;
            this.cmb_Man_Charge_DS.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Man_Charge_DS.Name = "cmb_Man_Charge_DS";
            this.cmb_Man_Charge_DS.OddRowStyle = style38;
            this.cmb_Man_Charge_DS.PartialRightColumn = false;
            this.cmb_Man_Charge_DS.PropBag = resources.GetString("cmb_Man_Charge_DS.PropBag");
            this.cmb_Man_Charge_DS.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_DS.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Man_Charge_DS.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Man_Charge_DS.SelectedStyle = style39;
            this.cmb_Man_Charge_DS.Size = new System.Drawing.Size(156, 21);
            this.cmb_Man_Charge_DS.Style = style40;
            this.cmb_Man_Charge_DS.TabIndex = 621;
            this.cmb_Man_Charge_DS.SelectedValueChanged += new System.EventHandler(this.cmb_Man_Charge_SelectedValueChanged);
            // 
            // lbl_Man_Charge_QD
            // 
            this.lbl_Man_Charge_QD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Man_Charge_QD.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Man_Charge_QD.ImageIndex = 0;
            this.lbl_Man_Charge_QD.ImageList = this.img_Label;
            this.lbl_Man_Charge_QD.Location = new System.Drawing.Point(7, 34);
            this.lbl_Man_Charge_QD.Name = "lbl_Man_Charge_QD";
            this.lbl_Man_Charge_QD.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_QD.TabIndex = 619;
            this.lbl_Man_Charge_QD.Text = "Charge (QD)";
            this.lbl_Man_Charge_QD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Man_Charge_VJ
            // 
            this.lbl_Man_Charge_VJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Man_Charge_VJ.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Man_Charge_VJ.ImageIndex = 0;
            this.lbl_Man_Charge_VJ.ImageList = this.img_Label;
            this.lbl_Man_Charge_VJ.Location = new System.Drawing.Point(7, 56);
            this.lbl_Man_Charge_VJ.Name = "lbl_Man_Charge_VJ";
            this.lbl_Man_Charge_VJ.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_VJ.TabIndex = 616;
            this.lbl_Man_Charge_VJ.Text = "Charge (VJ)";
            this.lbl_Man_Charge_VJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Man_Charge_DS
            // 
            this.lbl_Man_Charge_DS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Man_Charge_DS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Man_Charge_DS.ImageIndex = 0;
            this.lbl_Man_Charge_DS.ImageList = this.img_Label;
            this.lbl_Man_Charge_DS.Location = new System.Drawing.Point(7, 12);
            this.lbl_Man_Charge_DS.Name = "lbl_Man_Charge_DS";
            this.lbl_Man_Charge_DS.Size = new System.Drawing.Size(100, 21);
            this.lbl_Man_Charge_DS.TabIndex = 601;
            this.lbl_Man_Charge_DS.Text = "Charge (DS)";
            this.lbl_Man_Charge_DS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 438);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 668;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Save.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Save.ImageIndex = 0;
            this.btn_Save.ImageList = this.img_Button;
            this.btn_Save.Location = new System.Drawing.Point(248, 438);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(70, 23);
            this.btn_Save.TabIndex = 667;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Save.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txt_Price);
            this.groupBox4.Controls.Add(this.cmb_Currency);
            this.groupBox4.Controls.Add(this.lbl_Price);
            this.groupBox4.Controls.Add(this.lbl_Currency);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(5, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 74);
            this.groupBox4.TabIndex = 669;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Purchase CBD Validation Value";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.White;
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Price.Location = new System.Drawing.Point(108, 41);
            this.txt_Price.MaxLength = 10;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(268, 21);
            this.txt_Price.TabIndex = 622;
            // 
            // cmb_Currency
            // 
            this.cmb_Currency.AddItemCols = 0;
            this.cmb_Currency.AddItemSeparator = ';';
            this.cmb_Currency.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Currency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Currency.Caption = "";
            this.cmb_Currency.CaptionHeight = 17;
            this.cmb_Currency.CaptionStyle = style41;
            this.cmb_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Currency.ColumnCaptionHeight = 18;
            this.cmb_Currency.ColumnFooterHeight = 18;
            this.cmb_Currency.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Currency.ContentHeight = 17;
            this.cmb_Currency.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Currency.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Currency.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Currency.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Currency.EditorHeight = 17;
            this.cmb_Currency.EvenRowStyle = style42;
            this.cmb_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_Currency.FooterStyle = style43;
            this.cmb_Currency.GapHeight = 2;
            this.cmb_Currency.HeadingStyle = style44;
            this.cmb_Currency.HighLightRowStyle = style45;
            this.cmb_Currency.ItemHeight = 15;
            this.cmb_Currency.Location = new System.Drawing.Point(108, 19);
            this.cmb_Currency.MatchEntryTimeout = ((long)(2000));
            this.cmb_Currency.MaxDropDownItems = ((short)(5));
            this.cmb_Currency.MaxLength = 32767;
            this.cmb_Currency.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Currency.Name = "cmb_Currency";
            this.cmb_Currency.OddRowStyle = style46;
            this.cmb_Currency.PartialRightColumn = false;
            this.cmb_Currency.PropBag = resources.GetString("cmb_Currency.PropBag");
            this.cmb_Currency.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Currency.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Currency.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Currency.SelectedStyle = style47;
            this.cmb_Currency.Size = new System.Drawing.Size(268, 21);
            this.cmb_Currency.Style = style48;
            this.cmb_Currency.TabIndex = 621;
            // 
            // lbl_Price
            // 
            this.lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Price.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ImageIndex = 0;
            this.lbl_Price.ImageList = this.img_Label;
            this.lbl_Price.Location = new System.Drawing.Point(7, 41);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(100, 21);
            this.lbl_Price.TabIndex = 619;
            this.lbl_Price.Text = "Price";
            this.lbl_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Currency.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency.ImageIndex = 0;
            this.lbl_Currency.ImageList = this.img_Label;
            this.lbl_Currency.Location = new System.Drawing.Point(7, 19);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(100, 21);
            this.lbl_Currency.TabIndex = 601;
            this.lbl_Currency.Text = "Currency";
            this.lbl_Currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_GroupInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 468);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_GroupInfo";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btn_Save, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UseYN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_JJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_VJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_QD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Man_Charge_DS)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Currency)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		
		string  _GroupTcd, _GroupLcd, _GroupMcd, _GroupScd; 
		private string arg_datamode;
		private string _Group_Type, _Group_L, _Group_M, _Group_S;
		private string _Group_Level, _Group_cd, _Group_name;
		private string _Attribute, _UseYN;

			public bool _Close_Save = false;


		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				DataTable dt_ret;

				this.Text = "Item Group";
				this.lbl_MainTitle.Text = "Item Group";

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);

				//사용여부 콤보
				dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "");
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_UseYN, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);

				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxUseYN);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_UseYN, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  

				// currency 콤보
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxMonetaryUnit);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Currency, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code);  



				dt_ret.Dispose();


				arg_datamode = ClassLib.ComVar.Parameter_PopUp[0];
				_Group_name  = ClassLib.ComVar.Parameter_PopUp[1];
				_Group_cd    = ClassLib.ComVar.Parameter_PopUp[2];
				_Group_Level = ClassLib.ComVar.Parameter_PopUp[3];
				_Group_Type	 = ClassLib.ComVar.Parameter_PopUp[4];
				_Group_L	 = ClassLib.ComVar.Parameter_PopUp[5];
				_Group_M	 = ClassLib.ComVar.Parameter_PopUp[6];
				_Group_S	 = ClassLib.ComVar.Parameter_PopUp[7];
				_Attribute   = ClassLib.ComVar.Parameter_PopUp[8];
				_UseYN		 = ClassLib.ComVar.Parameter_PopUp[9];  
				

				cmb_UseYN.SelectedValue = Check_True_False(_UseYN);

				Set_Attribute(_Attribute);

				_GroupTcd	= _Group_Type + "0" + "00" + "000";
				_GroupLcd	= _Group_Type + _Group_L + "00" + "000";
				_GroupMcd	= _Group_Type + _Group_L + _Group_M + "000";
				_GroupScd	= _Group_Type + _Group_L + _Group_M + _Group_S;


				// 담당자 --------------------------------------------------------------------------
				txt_Man_Charge_DS.Text = ClassLib.ComVar.Parameter_PopUp[10];
				txt_Man_Charge_QD.Text = ClassLib.ComVar.Parameter_PopUp[11];
                txt_Man_Charge_VJ.Text = ClassLib.ComVar.Parameter_PopUp[12];
                txt_Man_Charge_JJ.Text = ClassLib.ComVar.Parameter_PopUp[13];

				//담당자 콤보 세팅
				Set_Cust_User_Combo(txt_Man_Charge_DS);
				Set_Cust_User_Combo(txt_Man_Charge_QD);
                Set_Cust_User_Combo(txt_Man_Charge_VJ);
                Set_Cust_User_Combo(txt_Man_Charge_JJ);

				cmb_Man_Charge_DS.SelectedValue = ClassLib.ComVar.Parameter_PopUp[10];
				cmb_Man_Charge_QD.SelectedValue = ClassLib.ComVar.Parameter_PopUp[11];
                cmb_Man_Charge_VJ.SelectedValue = ClassLib.ComVar.Parameter_PopUp[12];
                cmb_Man_Charge_JJ.SelectedValue = ClassLib.ComVar.Parameter_PopUp[13]; 

				cmb_Currency.SelectedValue = ClassLib.ComVar.Parameter_PopUp[13];
				txt_Price.Text = ClassLib.ComVar.Parameter_PopUp[14];
				//---------------------------------------------------------------------------------





				// 그룹명 세팅
				Get_GroupName();  

				if(arg_datamode == "I")
				{
					Group_Add();
				}

				else if(arg_datamode == "U")
				{
					Group_Modify();
				} 
			 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}

		}

		public string Check_True_False(string arg_TrueFalse)
		{
			string ResultYN = null;
		
			if(arg_TrueFalse == "True")
			{
				ResultYN = "Y";
			}
			else
			{
				ResultYN = "N";
			}

			return ResultYN;
		}



		/// <summary>
		/// 속성 상태 체크
		/// </summary>
		/// <param name="arg_attribute"></param>
		private void Set_Attribute(string arg_attribute)
		{
			arg_attribute = (arg_attribute == null) ? "" : arg_attribute;

			if(arg_attribute.Trim().Length != 4)
			{
				chk_Model.Checked = false;
				chk_Style.Checked = false;
				chk_Cmp.Checked = false;
				chk_Gen.Checked = false;

			}
			else
			{

				chk_Model.Checked = (arg_attribute.Substring(0, 1) == "1") ? true : false;
				chk_Style.Checked = (arg_attribute.Substring(1, 1) == "1") ? true : false;
				chk_Cmp.Checked = (arg_attribute.Substring(2, 1) == "1") ? true : false;
				chk_Gen.Checked = (arg_attribute.Substring(3, 1) == "1") ? true : false;

			} 
			

		}



		/// <summary>
		/// 그룹 수정
		/// </summary>
		private void Group_Modify()
		{

			txt_Group_Type.Text = _Group_Type;
			txt_Group_L.Text = _Group_L;
			txt_Group_M.Text = _Group_M;
			txt_Group_S.Text = _Group_S;
	
			txt_Group_CD.Text = _Group_cd;
			txt_Level.Text = _Group_Level;
			txt_Group_Name.Text = _Group_name; 
		}

		
		/// <summary>
		/// Get_GroupName : 그룹명 세팅
		/// </summary>
		private void Get_GroupName()
		{
			
			DataTable dt_ret = null;

			switch(_Group_Level)
			{ 
				case "1":  

					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupTcd);
					txt_Group_TName.Text = dt_ret.Rows[0].ItemArray[0].ToString(); 

					break;

				case "2": 

					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupTcd);
					txt_Group_TName.Text = dt_ret.Rows[0].ItemArray[0].ToString(); 
					
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupLcd);
					txt_Group_LName.Text = dt_ret.Rows[0].ItemArray[0].ToString(); 

					break;

				case "3":

					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupTcd);
					txt_Group_TName.Text = dt_ret.Rows[0].ItemArray[0].ToString();
	
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupLcd);
					txt_Group_LName.Text = dt_ret.Rows[0].ItemArray[0].ToString();
	
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupMcd);
					txt_Group_MName.Text = dt_ret.Rows[0].ItemArray[0].ToString(); 

					break;
                    
				case "4":
					
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupTcd);
					txt_Group_TName.Text = dt_ret.Rows[0].ItemArray[0].ToString();
	
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupLcd);
					txt_Group_LName.Text = dt_ret.Rows[0].ItemArray[0].ToString();
	
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupMcd);
					txt_Group_MName.Text = dt_ret.Rows[0].ItemArray[0].ToString();
	
					dt_ret = ClassLib.ComFunction.Select_Group_Name(_GroupScd);
					txt_Group_SName.Text = dt_ret.Rows[0].ItemArray[0].ToString(); 

					break;

			} 
			
			if(dt_ret != null) dt_ret.Dispose();

		}



		/// <summary>
		/// 그룹추가
		/// </summary>
		private void Group_Add()
		{
			string next_level = "";
			string next_cd = "";

			next_level = Convert.ToString( Convert.ToInt32(_Group_Level) + 1 );

			switch(_Group_Level)
			{
				// group type
				case "0": 
					
					txt_Group_L.Text = "0";
					txt_Group_M.Text = "00";
					txt_Group_S.Text = "000"; 

					next_cd = ClassLib.ComFunction.Get_Next_Group_Cd(next_level, "", "", "");
					txt_Group_Type.Text = next_cd; 

					break;

				// first class
				case "1":

					txt_Group_Type.Text = _Group_Type;
					txt_Group_TName.Text = _Group_name;
					txt_Group_M.Text = "00";
					txt_Group_S.Text = "000";

					next_cd = ClassLib.ComFunction.Get_Next_Group_Cd(next_level, _Group_Type, "", ""); 
					txt_Group_L.Text = next_cd; 

					txt_Group_L.ReadOnly = false;
					txt_Group_L.BackColor = Color.Empty;
					txt_Group_L.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

					break;

				// second class
				case "2":

					txt_Group_Type.Text = _Group_Type;
					txt_Group_TName.Text = _Group_name;
					txt_Group_L.Text = _Group_L;
					txt_Group_S.Text = "000";

					next_cd = ClassLib.ComFunction.Get_Next_Group_Cd(next_level, _Group_Type, _Group_L, ""); 
					txt_Group_M.Text = next_cd; 

					break;

				// third class
				case "3":

					txt_Group_Type.Text = _Group_Type;
					txt_Group_TName.Text = _Group_name;
					txt_Group_L.Text = _Group_L;
					txt_Group_M.Text = _Group_M;

					next_cd = ClassLib.ComFunction.Get_Next_Group_Cd(next_level, _Group_Type, _Group_L, _Group_M); 
					txt_Group_S.Text = next_cd; 

					break;
			}


			
			txt_Level.Text = next_level;
			txt_Group_CD.Text = txt_Group_Type.Text + txt_Group_L.Text + txt_Group_M.Text + txt_Group_S.Text;
 

		}

		#endregion  

		#region 이벤트 처리

		#region 이벤트_버튼클릭

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[]
						{ 
							"", //txt_Group_Type.Text,
							"", //txt_Group_L.Text,
							"", //txt_Group_M.Text,
							"", //txt_Group_S.Text,
							"", //txt_Group_Name.Text,
							"", //txt_Group_CD.Text,
							"", //txt_Level.Text,
							"",
							"",
							"",	
							"",	
							"0000", //attribute,
							"False"  //cmb_UseYN.SelectedValue.ToString() 

						}; 


			_Close_Save = false;
			this.Close();
		}


		/// <summary>
		/// 저장
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			try
			{
				Save(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			} 
		}



		/// <summary>
		/// Save : 
		/// </summary>
		private void Save()
		{
			bool save_flag = false;

			save_flag = Save_Check();

			if(save_flag)
			{
				Save_Code(arg_datamode); 
				_Close_Save = true;
				this.Close();
			}
			else
			{
				txt_Group_Name.Focus();
				//ClassLib.ComFunction.Data_Message("[Group Name]", ClassLib.ComVar.MgsWrongInput, this);
			}

		}



		/// <summary>
		/// Save_Check : 
		/// </summary>
		/// <returns></returns>
		private bool Save_Check()
		{
			if(txt_Group_Name.Text.Trim().Length == 0) 
			{
				ClassLib.ComFunction.User_Message("Input Group Name", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			else
			{


				bool save_check = true;

				if(arg_datamode == "U" )
				{
					if(_Group_name.ToUpper().Trim() == txt_Group_Name.Text.ToUpper().Trim() )
					{
						save_check = false;
					}
				}


				if(save_check)
				{

					// 그룹명 중복체크
					DataTable dt_ret;
 
					dt_ret = Check_Duplicate_DB();

					// 중복 아님, 저장 가능
					if(Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]) )  
					{
						dt_ret.Dispose(); 

						return true;

					} // end if
					else
					{
						ClassLib.ComFunction.User_Message("Duplicate Group Name : [" 
							+ dt_ret.Rows[0].ItemArray[0].ToString().Trim() + "]", 
							"Save", MessageBoxButtons.OK, MessageBoxIcon.Error);

						dt_ret.Dispose(); 

						return false;

					} // end if

				}
				else
				{
					return true;

				}
 
				

				
			} // end if(txt_Group_Name.Text.Trim().Length == 0) 




		}




		#endregion 

		#region 버튼클릭시 이미지변경
 

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
		 
		#region 이벤트_담당자 등록

		private void txt_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{ 
			try
			{
				//if(e.KeyValue != (char)13) return;
				if(e.KeyCode != Keys.Enter) return; 

				TextBox src = sender as TextBox;

				Set_Cust_User_Combo(src); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void cmb_Man_Charge_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				C1.Win.C1List.C1Combo src = sender as C1.Win.C1List.C1Combo;

				if(src.Equals(cmb_Man_Charge_DS) )
				{
					txt_Man_Charge_DS.Text = ClassLib.ComFunction.Empty_Combo(src, "");
				}
				else if(src.Equals(cmb_Man_Charge_QD) )
				{
					txt_Man_Charge_QD.Text = ClassLib.ComFunction.Empty_Combo(src, "");
				}
				else if(src.Equals(cmb_Man_Charge_VJ) )
				{
					txt_Man_Charge_VJ.Text = ClassLib.ComFunction.Empty_Combo(src, "");
                }
                else if (src.Equals(cmb_Man_Charge_JJ))
                {
                    txt_Man_Charge_JJ.Text = ClassLib.ComFunction.Empty_Combo(src, "");
                }


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Man_Charge_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// Set_Cust_User_Combo : 
		/// </summary>
		/// <param name="arg_control"></param>
		private void Set_Cust_User_Combo(System.Windows.Forms.TextBox arg_control)
		{
			try
			{
				DataTable dt;
 
				switch(arg_control.Name)
				{ 
					case "txt_Man_Charge_DS": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("DS", arg_control.Text);
						//ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_DS, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code);  
						
						ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_Man_Charge_DS, 1, 2);
						cmb_Man_Charge_DS.Splits[0].DisplayColumns[0].Width = 210;
						cmb_Man_Charge_DS.Splits[0].DisplayColumns[1].Width = 0;
						cmb_Man_Charge_DS.DropDownWidth = 210;


						break;

					case "txt_Man_Charge_QD": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("QD", arg_control.Text);
						//ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_QD, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code);   
						
						ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_Man_Charge_QD, 1, 2);
						cmb_Man_Charge_QD.Splits[0].DisplayColumns[0].Width = 210;
						cmb_Man_Charge_QD.Splits[0].DisplayColumns[1].Width = 0;
						cmb_Man_Charge_QD.DropDownWidth = 210;


						break;

					case "txt_Man_Charge_VJ": 
						
						dt = ClassLib.ComFunction.Select_Man_Charge("VJ", arg_control.Text);
						//ClassLib.ComCtl.Set_ComboList(dt,cmb_Man_Charge_VJ, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code);  
 
						ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_Man_Charge_VJ, 1, 2);
						cmb_Man_Charge_VJ.Splits[0].DisplayColumns[0].Width = 210;
						cmb_Man_Charge_VJ.Splits[0].DisplayColumns[1].Width = 0;
						cmb_Man_Charge_VJ.DropDownWidth = 210;


                        break;

                    case "txt_Man_Charge_JJ":

                        dt = ClassLib.ComFunction.Select_Man_Charge("JJ", arg_control.Text); 

                        ClassLib.ComCtl.Set_ComboList_AddItem(dt, cmb_Man_Charge_JJ, 1, 2);
                        cmb_Man_Charge_JJ.Splits[0].DisplayColumns[0].Width = 210;
                        cmb_Man_Charge_JJ.Splits[0].DisplayColumns[1].Width = 0;
                        cmb_Man_Charge_JJ.DropDownWidth = 210;


                        break;
				} 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Cust_User_Combo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		#endregion


		#endregion  
		
		#region DB Connect


		
		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB()
		{  
			try
			{
				DataSet ds_ret; 
				string group_name = "";
				string group_level = "";


				MyOraDB.ReDim_Parameter(3);
				MyOraDB.Process_Name = "PKG_SBC_ITEM_GROUP.CHECK_GROUP_NAME_EXIST_1"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_GROUP_NAME"; 
				MyOraDB.Parameter_Name[1] = "ARG_GROUP_LEVEL";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 
  

				group_name = txt_Group_Name.Text.ToUpper().Trim();
				group_level = txt_Level.Text.Trim();

				MyOraDB.Parameter_Values[0] = group_name;
				MyOraDB.Parameter_Values[1] = group_level; 
				MyOraDB.Parameter_Values[2] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}




		/// <summary>
		/// Save_Code : 저장
		/// </summary>
		private void Save_Code(string arg_division)
		{
			try
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(17); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBC_ITEM_GROUP.SAVE_SBC_ITEM_GROUP";

				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_GROUP_TYPE";
				MyOraDB.Parameter_Name[2]  = "ARG_GROUP_L"; 
				MyOraDB.Parameter_Name[3]  = "ARG_GROUP_M";
				MyOraDB.Parameter_Name[4]  = "ARG_GROUP_S";
				MyOraDB.Parameter_Name[5]  = "ARG_GROUP_NAME";
				MyOraDB.Parameter_Name[6]  = "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[7]  = "ARG_GROUP_LEVEL";
				MyOraDB.Parameter_Name[8]  = "ARG_MAN_CHARGE_DS";
				MyOraDB.Parameter_Name[9]  = "ARG_MAN_CHARGE_QD";
                MyOraDB.Parameter_Name[10] = "ARG_MAN_CHARGE_VJ";
                MyOraDB.Parameter_Name[11] = "ARG_MAN_CHARGE_JJ";
				MyOraDB.Parameter_Name[12]  = "ARG_ATTRIBUTE";
				MyOraDB.Parameter_Name[13]  = "ARG_USE_YN";
				MyOraDB.Parameter_Name[14]  = "ARG_VALIDATION_KEY_01";
				MyOraDB.Parameter_Name[15]  = "ARG_VALIDATION_VALUE_01";
				MyOraDB.Parameter_Name[16]  = "ARG_UPD_USER";

				//03.DATA TYPE
				for (int i = 0; i < 16; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

				//04.DATA 정의 
				MyOraDB.Parameter_Values[0]   = arg_division;
				MyOraDB.Parameter_Values[1]   = txt_Group_Type.Text;
				MyOraDB.Parameter_Values[2]   = txt_Group_L.Text;
				MyOraDB.Parameter_Values[3]   = txt_Group_M.Text;
				MyOraDB.Parameter_Values[4]   = txt_Group_S.Text;
				MyOraDB.Parameter_Values[5]   = txt_Group_Name.Text.ToUpper();
				MyOraDB.Parameter_Values[6]   = txt_Group_CD.Text;
				MyOraDB.Parameter_Values[7]   = txt_Level.Text;
				MyOraDB.Parameter_Values[8]   = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_DS, "");
				MyOraDB.Parameter_Values[9]   = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_QD, "");
                MyOraDB.Parameter_Values[10]  = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_VJ, "");
                MyOraDB.Parameter_Values[11]  = ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_JJ, "");

				//속성 : Y -> 1, N -> 0
				string attribute = ""; 

				attribute = (chk_Model.Checked) ? "1" : "0";
				attribute += (chk_Style.Checked) ? "1" : "0";
				attribute += (chk_Cmp.Checked) ? "1" : "0";
				attribute += (chk_Gen.Checked) ? "1" : "0"; 

				MyOraDB.Parameter_Values[12]  = attribute;

				MyOraDB.Parameter_Values[13]  = cmb_UseYN.SelectedValue.ToString();

				MyOraDB.Parameter_Values[14]  = ClassLib.ComFunction.Empty_Combo(cmb_Currency, "");
				MyOraDB.Parameter_Values[15]  = ClassLib.ComFunction.Empty_TextBox(txt_Price, "");

				MyOraDB.Parameter_Values[16]  = COM.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		
			
				//Error 처리
				if(ds_ret == null) 
				{
					ClassLib.ComFunction.Data_Message("Save", ClassLib.ComVar.MgsDoNotSave, this);
				}



				COM.ComVar.Parameter_PopUp = new string[]
						{ 
							txt_Group_Name.Text.ToUpper(),
							txt_Group_CD.Text,
							txt_Level.Text, 
							txt_Group_Type.Text,
							txt_Group_L.Text,
							txt_Group_M.Text,
							txt_Group_S.Text,
							attribute, 
							(cmb_UseYN.SelectedValue.ToString() == "Y") ? "True" : "False",
							ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_DS, ""),
							ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_QD, ""),
							ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_VJ, ""),
							ClassLib.ComFunction.Empty_Combo(cmb_Man_Charge_JJ, ""),
							ClassLib.ComFunction.Empty_Combo(cmb_Currency, ""),
					        ClassLib.ComFunction.Empty_TextBox(txt_Price, ""),
						}; 


				ds_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message ,"Save_Code", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}

		#endregion 

       
		

	}
}

