using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{
	public class Pop_BM_Shipping_Schedule_Size : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.FSP fgrid_size;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_lotNo;
		private System.Windows.Forms.Label lbl_lotSeq;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_line;
		private System.Windows.Forms.TextBox txt_lotNo;
		private System.Windows.Forms.TextBox txt_lotSeq;
		private System.Windows.Forms.TextBox txt_styleName;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.TextBox txt_factory;
		private System.Windows.Forms.TextBox txt_shipType;
		private System.Windows.Forms.TextBox txt_line;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_gender;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();

		private ArrayList _columnIndex = new ArrayList();
		int _backCol		= (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxBACK_COLOR;
		int _foreCol		= (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxFORE_COLOR;
		private System.Windows.Forms.TextBox txt_gender;
		int _totalQtyCol	= (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxTOTAL_QTY;

		#endregion

		#region 생성자 / 소멸자
        
		public Pop_BM_Shipping_Schedule_Size()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Shipping_Schedule_Size));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.lbl_gender = new System.Windows.Forms.Label();
			this.txt_gender = new System.Windows.Forms.TextBox();
			this.txt_line = new System.Windows.Forms.TextBox();
			this.txt_shipType = new System.Windows.Forms.TextBox();
			this.txt_factory = new System.Windows.Forms.TextBox();
			this.lbl_line = new System.Windows.Forms.Label();
			this.txt_styleName = new System.Windows.Forms.TextBox();
			this.lbl_style = new System.Windows.Forms.Label();
			this.txt_styleCd = new System.Windows.Forms.TextBox();
			this.txt_lotSeq = new System.Windows.Forms.TextBox();
			this.txt_lotNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_shipType = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_lotNo = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.lbl_lotSeq = new System.Windows.Forms.Label();
			this.fgrid_size = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
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
			this.c1Sizer1.Controls.Add(this.panel1);
			this.c1Sizer1.Controls.Add(this.pnl_head);
			this.c1Sizer1.Controls.Add(this.fgrid_size);
			this.c1Sizer1.GridDefinition = "31.712962962963:False:False;55.787037037037:False:False;6.94444444444444:False:Fa" +
				"lse;0.925925925925926:False:True;\t0.574712643678161:False:True;96.551724137931:F" +
				"alse:False;0.574712643678161:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(696, 432);
			this.c1Sizer1.TabIndex = 26;
			this.c1Sizer1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_cancel);
			this.panel1.Controls.Add(this.btn_apply);
			this.panel1.Location = new System.Drawing.Point(12, 390);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(672, 30);
			this.panel1.TabIndex = 4;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_cancel.ImageIndex = 0;
			this.btn_cancel.ImageList = this.img_Button;
			this.btn_cancel.Location = new System.Drawing.Point(602, 2);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 376;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
			this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(531, 2);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 23);
			this.btn_apply.TabIndex = 376;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
			this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.lbl_gender);
			this.pnl_head.Controls.Add(this.txt_gender);
			this.pnl_head.Controls.Add(this.txt_line);
			this.pnl_head.Controls.Add(this.txt_shipType);
			this.pnl_head.Controls.Add(this.txt_factory);
			this.pnl_head.Controls.Add(this.lbl_line);
			this.pnl_head.Controls.Add(this.txt_styleName);
			this.pnl_head.Controls.Add(this.lbl_style);
			this.pnl_head.Controls.Add(this.txt_styleCd);
			this.pnl_head.Controls.Add(this.txt_lotSeq);
			this.pnl_head.Controls.Add(this.txt_lotNo);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.lbl_shipType);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_lotNo);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.lbl_lotSeq);
			this.pnl_head.Location = new System.Drawing.Point(12, 4);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(672, 137);
			this.pnl_head.TabIndex = 3;
			// 
			// lbl_gender
			// 
			this.lbl_gender.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_gender.ImageIndex = 0;
			this.lbl_gender.ImageList = this.img_Label;
			this.lbl_gender.Location = new System.Drawing.Point(8, 106);
			this.lbl_gender.Name = "lbl_gender";
			this.lbl_gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_gender.TabIndex = 50;
			this.lbl_gender.Text = "Gender";
			this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_gender
			// 
			this.txt_gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_gender.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_gender.Location = new System.Drawing.Point(109, 106);
			this.txt_gender.Name = "txt_gender";
			this.txt_gender.ReadOnly = true;
			this.txt_gender.Size = new System.Drawing.Size(210, 21);
			this.txt_gender.TabIndex = 397;
			this.txt_gender.Text = "";
			// 
			// txt_line
			// 
			this.txt_line.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_line.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_line.Location = new System.Drawing.Point(431, 106);
			this.txt_line.Name = "txt_line";
			this.txt_line.ReadOnly = true;
			this.txt_line.Size = new System.Drawing.Size(210, 21);
			this.txt_line.TabIndex = 397;
			this.txt_line.Text = "";
			// 
			// txt_shipType
			// 
			this.txt_shipType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_shipType.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_shipType.Location = new System.Drawing.Point(431, 40);
			this.txt_shipType.Name = "txt_shipType";
			this.txt_shipType.ReadOnly = true;
			this.txt_shipType.Size = new System.Drawing.Size(210, 21);
			this.txt_shipType.TabIndex = 397;
			this.txt_shipType.Text = "";
			// 
			// txt_factory
			// 
			this.txt_factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_factory.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_factory.Location = new System.Drawing.Point(109, 40);
			this.txt_factory.Name = "txt_factory";
			this.txt_factory.ReadOnly = true;
			this.txt_factory.Size = new System.Drawing.Size(210, 21);
			this.txt_factory.TabIndex = 397;
			this.txt_factory.Text = "";
			// 
			// lbl_line
			// 
			this.lbl_line.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_line.ImageIndex = 0;
			this.lbl_line.ImageList = this.img_Label;
			this.lbl_line.Location = new System.Drawing.Point(330, 106);
			this.lbl_line.Name = "lbl_line";
			this.lbl_line.Size = new System.Drawing.Size(100, 21);
			this.lbl_line.TabIndex = 50;
			this.lbl_line.Text = "Line";
			this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_styleName
			// 
			this.txt_styleName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_styleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_styleName.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_styleName.Location = new System.Drawing.Point(330, 84);
			this.txt_styleName.Name = "txt_styleName";
			this.txt_styleName.ReadOnly = true;
			this.txt_styleName.Size = new System.Drawing.Size(311, 21);
			this.txt_styleName.TabIndex = 397;
			this.txt_styleName.Text = "";
			// 
			// lbl_style
			// 
			this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_style.ImageIndex = 0;
			this.lbl_style.ImageList = this.img_Label;
			this.lbl_style.Location = new System.Drawing.Point(8, 84);
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
			this.txt_styleCd.Location = new System.Drawing.Point(109, 84);
			this.txt_styleCd.Name = "txt_styleCd";
			this.txt_styleCd.ReadOnly = true;
			this.txt_styleCd.Size = new System.Drawing.Size(210, 21);
			this.txt_styleCd.TabIndex = 397;
			this.txt_styleCd.Text = "";
			// 
			// txt_lotSeq
			// 
			this.txt_lotSeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_lotSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_lotSeq.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_lotSeq.Location = new System.Drawing.Point(431, 62);
			this.txt_lotSeq.Name = "txt_lotSeq";
			this.txt_lotSeq.ReadOnly = true;
			this.txt_lotSeq.Size = new System.Drawing.Size(210, 21);
			this.txt_lotSeq.TabIndex = 397;
			this.txt_lotSeq.Text = "";
			// 
			// txt_lotNo
			// 
			this.txt_lotNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_lotNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_lotNo.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_lotNo.Location = new System.Drawing.Point(109, 62);
			this.txt_lotNo.Name = "txt_lotNo";
			this.txt_lotNo.ReadOnly = true;
			this.txt_lotNo.Size = new System.Drawing.Size(210, 21);
			this.txt_lotNo.TabIndex = 397;
			this.txt_lotNo.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Shipping Schedule Info";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_shipType
			// 
			this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipType.ImageIndex = 0;
			this.lbl_shipType.ImageList = this.img_Label;
			this.lbl_shipType.Location = new System.Drawing.Point(330, 40);
			this.lbl_shipType.Name = "lbl_shipType";
			this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipType.TabIndex = 50;
			this.lbl_shipType.Text = "Ship Type";
			this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(656, 121);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_lotNo
			// 
			this.lbl_lotNo.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_lotNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_lotNo.ImageIndex = 0;
			this.lbl_lotNo.ImageList = this.img_Label;
			this.lbl_lotNo.Location = new System.Drawing.Point(8, 62);
			this.lbl_lotNo.Name = "lbl_lotNo";
			this.lbl_lotNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_lotNo.TabIndex = 50;
			this.lbl_lotNo.Text = "Lot No";
			this.lbl_lotNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 120);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(632, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
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
			this.pic_head7.Location = new System.Drawing.Point(571, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 96);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(656, 0);
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
			this.pic_head5.Location = new System.Drawing.Point(0, 121);
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
			this.pic_head6.Size = new System.Drawing.Size(168, 119);
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
			this.pic_head1.Size = new System.Drawing.Size(592, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// lbl_lotSeq
			// 
			this.lbl_lotSeq.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_lotSeq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_lotSeq.ImageIndex = 0;
			this.lbl_lotSeq.ImageList = this.img_Label;
			this.lbl_lotSeq.Location = new System.Drawing.Point(330, 62);
			this.lbl_lotSeq.Name = "lbl_lotSeq";
			this.lbl_lotSeq.Size = new System.Drawing.Size(100, 21);
			this.lbl_lotSeq.TabIndex = 50;
			this.lbl_lotSeq.Text = "Lot Seq";
			this.lbl_lotSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_size
			// 
			this.fgrid_size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_size.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_size.Location = new System.Drawing.Point(12, 145);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Size = new System.Drawing.Size(672, 241);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 0;
			this.fgrid_size.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
			this.fgrid_size.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_size_MouseUp);
			this.fgrid_size.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
			// 
			// Pop_BM_Shipping_Schedule_Size
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_BM_Shipping_Schedule_Size";
			this.Load += new System.EventHandler(this.Pop_BM_Shipping_Schedule_Size_Load);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Pop_BM_Shipping_Schedule_Size_Load(object sender, System.EventArgs e)
		{
			this.Init_Form();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			Apply_Process();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		#region 버튼효과

		private void btn_click_Effect_Up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 27;
		}

		private void btn_click_Effect_Down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 26;
		}

		#endregion

		#endregion

		#region 그리드 이벤트 처리

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}

		private void fgrid_size_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Grid_MoveToFirstDataSection();
		}

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
		{
			this.Text = "Size Information";
			lbl_MainTitle.Text = "Size Information";

			// grid set
			fgrid_size.Set_Grid("SBM_SHIP_SIZE_INFO", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_size.Set_Action_Image(img_Action);			

			// shipping schedule data set
			txt_factory.Text	= COM.ComVar.Parameter_PopUp[0];
			txt_shipType.Text	= COM.ComVar.Parameter_PopUp[2];
			txt_lotNo.Text		= COM.ComVar.Parameter_PopUp[3];
			txt_lotSeq.Text		= COM.ComVar.Parameter_PopUp[4];
			txt_styleCd.Text	= COM.ComVar.Parameter_PopUp[5];
			txt_styleName.Text	= COM.ComVar.Parameter_PopUp[6];
			txt_line.Text		= COM.ComVar.Parameter_PopUp[7];
			txt_gender.Text		= COM.ComVar.Parameter_PopUp[10];

			// size header set
			fgrid_size.Display_Size_ColHead(COM.ComVar.Parameter_PopUp[0], COM.ComVar.Parameter_PopUp[5].Replace("-", ""), 50, fgrid_size.Cols.Frozen);

			// size data set
			Search_Process();
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void Apply_Process()
		{

		}

		private void Search_Process()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable vDt = SELECT_SHIPPING_SCHEDULE_SIZE();

				if (vDt.Rows.Count > 0)
				{
					for (int i = fgrid_size.Cols.Frozen ; i < fgrid_size.Cols.Count ; i++)
						_columnIndex.Add(fgrid_size[1, i]);

					Display_FlexGrid_Tree(vDt, 0);
					fgrid_size.Tree.Column = (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxKIND;

					Grid_SetColor();
				}
				else
				{
					fgrid_size.ClearAll();
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

		#region 그리드 이벤트 처리 메서드

		private void Grid_AfterEditProcess()
		{
			int vOldData = fgrid_size.Buffer_CellData.Equals("") ? 0 : Convert.ToInt32(fgrid_size.Buffer_CellData);
			int vSurplus = Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_size[fgrid_size.Row, fgrid_size.Col], "0")) - vOldData;

			fgrid_size[fgrid_size.Row, _totalQtyCol] = Convert.ToInt32(ClassLib.ComFunction.NullCheck(fgrid_size[fgrid_size.Row, _totalQtyCol], "0")) + vSurplus;

			fgrid_size.Update_Row();
		}

		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_size.Rows.Fixed > 0) && (fgrid_size.Row >= fgrid_size.Rows.Fixed))
				fgrid_size.Buffer_CellData = (fgrid_size[fgrid_size.Row, fgrid_size.Col] == null) ? "" : fgrid_size[fgrid_size.Row, fgrid_size.Col].ToString();
		}

		private void Grid_MoveToFirstDataSection()
		{
			int vRow = fgrid_size.Row;

			for (int vCol = fgrid_size.Cols.Frozen ; vCol < fgrid_size.Cols.Count ; vCol++)
			{
				if (fgrid_size[vRow, vCol] != null)
				{
					fgrid_size.LeftCol = vCol;
					break;
				}
			}
		}

		#endregion

		#region 이벤트 처리시 사용되는 메서드

		// display grid
		private void Display_FlexGrid_Tree(DataTable arg_dt, int arg_tree)
		{
			try
			{
				ArrayList vRowIndex = new ArrayList();
				int vStartCol	= fgrid_size.Cols.Frozen;
				int vCSSize		= fgrid_size.Cols.Frozen - 2;
				int vQty		= fgrid_size.Cols.Frozen - 1;
				int vKey		= (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxKEY - 1;

				fgrid_size.ClearAll();

				int vFixed = fgrid_size.Rows.Fixed;
				int vRow = 0;
				int vCol = 0;
				int vCount = 1;

				for (int vIdx = 0 ; vIdx < arg_dt.Rows.Count ; vIdx++)
				{
					// row, column index 구하기
					vCol = _columnIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vCSSize]);
					vRow = vRowIndex.IndexOf(arg_dt.Rows[vIdx].ItemArray[vKey]);

					if (vRow != -1 && vCol != -1)
					{
						fgrid_size[vRow + vFixed, vCol + vStartCol] = arg_dt.Rows[vIdx].ItemArray[vQty];
					}
					else
					{
						//C1.Win.C1FlexGrid.Row vNewRow = arg_grid.AddItem(arg_dt.Rows[vIdx].ItemArray);
						C1.Win.C1FlexGrid.Row vNewRow = fgrid_size.Rows.Add();
						while (vCount < vStartCol)
						{
							vNewRow[vCount++] = arg_dt.Rows[vIdx].ItemArray[vCount - 2];
						}
						
						if (vCol != -1)
						{
							vNewRow[vCol + vStartCol] = arg_dt.Rows[vIdx].ItemArray[vQty];
						}

						vCount = 1;

						vNewRow.IsNode = true;
						vNewRow.Node.Level = int.Parse(arg_dt.Rows[vIdx].ItemArray[arg_tree].ToString());
						
						vRowIndex.Add(arg_dt.Rows[vIdx].ItemArray[vKey]);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}


		// grid color set
		private void Grid_SetColor()
		{
			int vQtyCol = (int)ClassLib.TBSBM_SHIP_SIZE_INFO.IxTOTAL_QTY;

			for (int vRow = fgrid_size.Rows.Fixed ; vRow < fgrid_size.Rows.Count ; vRow++)
			{
				CellRange vFullRange = fgrid_size.GetCellRange(vRow, 1, vRow, fgrid_size.Cols.Count - 1);
				CellRange vHeadRange = fgrid_size.GetCellRange(vRow, 1, vRow, fgrid_size.Cols.Frozen - 1);

				switch (fgrid_size.Rows[vRow].Node.Level)
				{
					case 1:
						vFullRange.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						fgrid_size.Rows[vRow].AllowEditing = true;
						fgrid_size[vRow, vQtyCol] = RowTotal(vRow);
						Gird_DataAreaSetColor(vRow);
						break;
					case 2:
						vHeadRange.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
						fgrid_size.Rows[vRow].AllowEditing = false;
						fgrid_size[vRow, vQtyCol] = RowTotal(vRow);
						break;
				}
			}
		}

		private void Gird_DataAreaSetColor(int arg_row)
		{
			int vEndRow = fgrid_size.Rows.Count - 1;

			Node vNextNode = fgrid_size.Rows[arg_row].Node.GetNode(NodeTypeEnum.NextSibling);

			if (vNextNode != null)
				vEndRow = vNextNode.Row.Index - 1;

			if (arg_row + 1 >= fgrid_size.Rows.Count)
				return;

			CellRange vTempRange = fgrid_size.GetCellRange(arg_row + 1, fgrid_size.Cols.Frozen, vEndRow, fgrid_size.Cols.Count - 1);

			if (!fgrid_size[arg_row, _foreCol].ToString().Equals(""))
				vTempRange.StyleNew.ForeColor = Color.FromArgb(Convert.ToInt32(fgrid_size[arg_row, _foreCol]));

			if (!fgrid_size[arg_row, _backCol].ToString().Equals(""))
				vTempRange.StyleNew.BackColor = Color.FromArgb(Convert.ToInt32(fgrid_size[arg_row, _backCol]));
			else
				vTempRange.StyleNew.BackColor = Color.White;
		}

		private double RowTotal(int arg_row)
		{
			return fgrid_size.Aggregate(AggregateEnum.Sum, arg_row, fgrid_size.Cols.Frozen, arg_row, fgrid_size.Cols.Count - 1);
		}

		#endregion

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBM_SHIPPING_ADVICE : Shipping Schedule Size 정보 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SHIPPING_SCHEDULE_SIZE()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = COM.ComVar.Parameter_PopUp[11];

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[6] = "ARG_SHIP_YMD_FROM";
			MyOraDB.Parameter_Name[7] = "ARG_SHIP_YMD_TO";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[4];
			MyOraDB.Parameter_Values[4] = COM.ComVar.Parameter_PopUp[5].Replace("-", "");
			MyOraDB.Parameter_Values[5] = COM.ComVar.Parameter_PopUp[7];
			MyOraDB.Parameter_Values[6] = COM.ComVar.Parameter_PopUp[8];
			MyOraDB.Parameter_Values[7] = COM.ComVar.Parameter_PopUp[9];
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion

	}
}

