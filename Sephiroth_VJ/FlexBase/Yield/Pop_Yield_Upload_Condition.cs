using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class  Pop_Yield_Upload_Condition : COM.PCHWinForm.Pop_Small_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_Component;
		private System.Windows.Forms.Label lbl_Component_Desc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl_SizeStart;
		private System.Windows.Forms.Label lbl_Material1;
		private System.Windows.Forms.Label lbl_SpecUnit;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.Label lbl_Material2;
		private System.Windows.Forms.Label lbl_CommonYield;
		private System.Windows.Forms.NumericUpDown numeric_SizeStart;
		private System.Windows.Forms.NumericUpDown numeric_Material1;
		private System.Windows.Forms.NumericUpDown numeric_Material2;
		private System.Windows.Forms.NumericUpDown numeric_SpecUnit;
		private System.Windows.Forms.NumericUpDown numeric_Color;
		private System.Windows.Forms.NumericUpDown numeric_CommonYield;
		private System.Windows.Forms.NumericUpDown numeric_Component;
        private Label btn_Reset;
		private System.Windows.Forms.Label btn_Apply;

		public  Pop_Yield_Upload_Condition()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
		}


		 
		//int[] pop_parameter = new int[] { _Ix_Component, _Ix_ExcelSizeStart, _Ix_Material, _Ix_Material_1, _Ix_SpecUnit, _Ix_Color, _Ix_CommonYieldValue };


		public int _Ix_Component = 0;          //F1
		public int _Ix_ExcelSizeStart = 1;     //F2
		public int _Ix_Material = 5;			//F6
		public int _Ix_Material_1 = 6;			//F7
		public int _Ix_SpecUnit = 15;			//F16
		public int _Ix_Color = 17;				//F18
		public int _Ix_CommonYieldValue = 23;	//F24



		public  Pop_Yield_Upload_Condition(int[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_Ix_Component = arg_parameter[0];
			_Ix_ExcelSizeStart = arg_parameter[1];
			_Ix_Material = arg_parameter[2]; 
			_Ix_Material_1 = arg_parameter[3]; 
			_Ix_SpecUnit = arg_parameter[4]; 
			_Ix_Color = arg_parameter[5]; 
			_Ix_CommonYieldValue = arg_parameter[6]; 
 

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Upload_Condition));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_CommonYield = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numeric_Color = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numeric_SpecUnit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric_Material2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_Material1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_SizeStart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CommonYield = new System.Windows.Forms.Label();
            this.lbl_SpecUnit = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.lbl_Material2 = new System.Windows.Forms.Label();
            this.lbl_SizeStart = new System.Windows.Forms.Label();
            this.lbl_Material1 = new System.Windows.Forms.Label();
            this.lbl_Component = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.lbl_Component_Desc = new System.Windows.Forms.Label();
            this.numeric_Component = new System.Windows.Forms.NumericUpDown();
            this.btn_Reset = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_CommonYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SpecUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Material2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Material1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SizeStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Component)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numeric_CommonYield);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numeric_Color);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numeric_SpecUnit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numeric_Material2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numeric_Material1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numeric_SizeStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_CommonYield);
            this.groupBox1.Controls.Add(this.lbl_SpecUnit);
            this.groupBox1.Controls.Add(this.lbl_Color);
            this.groupBox1.Controls.Add(this.lbl_Material2);
            this.groupBox1.Controls.Add(this.lbl_SizeStart);
            this.groupBox1.Controls.Add(this.lbl_Material1);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 153);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // numeric_CommonYield
            // 
            this.numeric_CommonYield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_CommonYield.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_CommonYield.Location = new System.Drawing.Point(108, 124);
            this.numeric_CommonYield.Name = "numeric_CommonYield";
            this.numeric_CommonYield.Size = new System.Drawing.Size(50, 21);
            this.numeric_CommonYield.TabIndex = 563;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(160, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 21);
            this.label10.TabIndex = 564;
            this.label10.Text = "공통 적용 채산 표시 컬럼";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_Color
            // 
            this.numeric_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Color.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_Color.Location = new System.Drawing.Point(108, 102);
            this.numeric_Color.Name = "numeric_Color";
            this.numeric_Color.Size = new System.Drawing.Size(50, 21);
            this.numeric_Color.TabIndex = 561;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 21);
            this.label9.TabIndex = 562;
            this.label9.Text = "Color 표시 컬럼";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_SpecUnit
            // 
            this.numeric_SpecUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_SpecUnit.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_SpecUnit.Location = new System.Drawing.Point(108, 80);
            this.numeric_SpecUnit.Name = "numeric_SpecUnit";
            this.numeric_SpecUnit.Size = new System.Drawing.Size(50, 21);
            this.numeric_SpecUnit.TabIndex = 559;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 21);
            this.label8.TabIndex = 560;
            this.label8.Text = "Sepc Unit 표시 컬럼";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_Material2
            // 
            this.numeric_Material2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Material2.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_Material2.Location = new System.Drawing.Point(108, 58);
            this.numeric_Material2.Name = "numeric_Material2";
            this.numeric_Material2.Size = new System.Drawing.Size(50, 21);
            this.numeric_Material2.TabIndex = 557;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 21);
            this.label7.TabIndex = 558;
            this.label7.Text = "(윗실/아랫실 일 때) 자재명 표시 컬럼";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_Material1
            // 
            this.numeric_Material1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Material1.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_Material1.Location = new System.Drawing.Point(108, 36);
            this.numeric_Material1.Name = "numeric_Material1";
            this.numeric_Material1.Size = new System.Drawing.Size(50, 21);
            this.numeric_Material1.TabIndex = 555;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 21);
            this.label6.TabIndex = 556;
            this.label6.Text = "자재명(윗실/아랫실) 표시 컬럼";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeric_SizeStart
            // 
            this.numeric_SizeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_SizeStart.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_SizeStart.Location = new System.Drawing.Point(108, 14);
            this.numeric_SizeStart.Name = "numeric_SizeStart";
            this.numeric_SizeStart.Size = new System.Drawing.Size(50, 21);
            this.numeric_SizeStart.TabIndex = 553;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 21);
            this.label5.TabIndex = 554;
            this.label5.Text = "사이즈 시작 컬럼";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CommonYield
            // 
            this.lbl_CommonYield.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_CommonYield.ImageIndex = 0;
            this.lbl_CommonYield.ImageList = this.img_Label;
            this.lbl_CommonYield.Location = new System.Drawing.Point(7, 124);
            this.lbl_CommonYield.Name = "lbl_CommonYield";
            this.lbl_CommonYield.Size = new System.Drawing.Size(100, 21);
            this.lbl_CommonYield.TabIndex = 550;
            this.lbl_CommonYield.Text = "Common Yield";
            this.lbl_CommonYield.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SpecUnit
            // 
            this.lbl_SpecUnit.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SpecUnit.ImageIndex = 0;
            this.lbl_SpecUnit.ImageList = this.img_Label;
            this.lbl_SpecUnit.Location = new System.Drawing.Point(7, 80);
            this.lbl_SpecUnit.Name = "lbl_SpecUnit";
            this.lbl_SpecUnit.Size = new System.Drawing.Size(100, 21);
            this.lbl_SpecUnit.TabIndex = 549;
            this.lbl_SpecUnit.Text = "Spec Unit";
            this.lbl_SpecUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Color
            // 
            this.lbl_Color.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Color.ImageIndex = 0;
            this.lbl_Color.ImageList = this.img_Label;
            this.lbl_Color.Location = new System.Drawing.Point(7, 102);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color.TabIndex = 548;
            this.lbl_Color.Text = "Color";
            this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Material2
            // 
            this.lbl_Material2.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Material2.ImageIndex = 0;
            this.lbl_Material2.ImageList = this.img_Label;
            this.lbl_Material2.Location = new System.Drawing.Point(7, 58);
            this.lbl_Material2.Name = "lbl_Material2";
            this.lbl_Material2.Size = new System.Drawing.Size(100, 21);
            this.lbl_Material2.TabIndex = 547;
            this.lbl_Material2.Text = "Material 2";
            this.lbl_Material2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SizeStart
            // 
            this.lbl_SizeStart.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SizeStart.ImageIndex = 0;
            this.lbl_SizeStart.ImageList = this.img_Label;
            this.lbl_SizeStart.Location = new System.Drawing.Point(7, 14);
            this.lbl_SizeStart.Name = "lbl_SizeStart";
            this.lbl_SizeStart.Size = new System.Drawing.Size(100, 21);
            this.lbl_SizeStart.TabIndex = 542;
            this.lbl_SizeStart.Text = "Size Start";
            this.lbl_SizeStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Material1
            // 
            this.lbl_Material1.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Material1.ImageIndex = 0;
            this.lbl_Material1.ImageList = this.img_Label;
            this.lbl_Material1.Location = new System.Drawing.Point(7, 36);
            this.lbl_Material1.Name = "lbl_Material1";
            this.lbl_Material1.Size = new System.Drawing.Size(100, 21);
            this.lbl_Material1.TabIndex = 541;
            this.lbl_Material1.Text = "Material 1";
            this.lbl_Material1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Component
            // 
            this.lbl_Component.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_Component.ImageIndex = 0;
            this.lbl_Component.ImageList = this.img_Label;
            this.lbl_Component.Location = new System.Drawing.Point(16, 194);
            this.lbl_Component.Name = "lbl_Component";
            this.lbl_Component.Size = new System.Drawing.Size(100, 21);
            this.lbl_Component.TabIndex = 540;
            this.lbl_Component.Text = "Component";
            this.lbl_Component.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Component.Visible = false;
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 200);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 666;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(248, 200);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 23);
            this.btn_Apply.TabIndex = 665;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_Component_Desc
            // 
            this.lbl_Component_Desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Component_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Component_Desc.Location = new System.Drawing.Point(168, 194);
            this.lbl_Component_Desc.Name = "lbl_Component_Desc";
            this.lbl_Component_Desc.Size = new System.Drawing.Size(216, 21);
            this.lbl_Component_Desc.TabIndex = 552;
            this.lbl_Component_Desc.Text = "\"component\" 표시 시작 컬럼";
            this.lbl_Component_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Component_Desc.Visible = false;
            // 
            // numeric_Component
            // 
            this.numeric_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Component.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.numeric_Component.Location = new System.Drawing.Point(112, 194);
            this.numeric_Component.Name = "numeric_Component";
            this.numeric_Component.Size = new System.Drawing.Size(50, 21);
            this.numeric_Component.TabIndex = 667;
            this.numeric_Component.Visible = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Reset.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Reset.ImageIndex = 0;
            this.btn_Reset.ImageList = this.img_Button;
            this.btn_Reset.Location = new System.Drawing.Point(5, 200);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(70, 23);
            this.btn_Reset.TabIndex = 668;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reset.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            this.btn_Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Reset.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_Upload_Condition
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.numeric_Component);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Component_Desc);
            this.Controls.Add(this.lbl_Component);
            this.Name = "Pop_Yield_Upload_Condition";
            this.Controls.SetChildIndex(this.lbl_Component, 0);
            this.Controls.SetChildIndex(this.lbl_Component_Desc, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.numeric_Component, 0);
            this.Controls.SetChildIndex(this.btn_Reset, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_CommonYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SpecUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Material2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Material1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SizeStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Component)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 

		//Apply 버튼 클릭 여부
		public bool _Close_Apply = false;



		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{

				//Title 
				this.Text = "Yield Upload Condition";  
				lbl_MainTitle.Text = "Yield Upload Condition";


                ClassLib.ComFunction.SetLangDic(this);


				numeric_Component.Value = _Ix_Component;
				numeric_SizeStart.Value = _Ix_ExcelSizeStart;
				numeric_Material1.Value = _Ix_Material;
				numeric_Material2.Value = _Ix_Material_1;
				numeric_SpecUnit.Value = _Ix_SpecUnit;
				numeric_Color.Value = _Ix_Color;
				numeric_CommonYield.Value = _Ix_CommonYieldValue;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
  
		}


		 


		/// <summary>
		/// Apply : [Apply] 버튼 이벤트
		/// </summary>
		private void Apply()
		{ 
 
			
			_Ix_Component = Convert.ToInt32(numeric_Component.Value);
			_Ix_ExcelSizeStart = Convert.ToInt32(numeric_SizeStart.Value);
			_Ix_Material = Convert.ToInt32(numeric_Material1.Value);
			_Ix_Material_1 = Convert.ToInt32(numeric_Material2.Value);
			_Ix_SpecUnit = Convert.ToInt32(numeric_SpecUnit.Value);
			_Ix_Color = Convert.ToInt32(numeric_Color.Value);
			_Ix_CommonYieldValue = Convert.ToInt32(numeric_CommonYield.Value);


			_Close_Apply = true;
			this.Close();
 

			
		}



        /// <summary>
        /// Reset : [Reset] 버튼 이벤트
        /// </summary>
        private void Reset()
        {

            _Ix_Component = 0;          //F1
            _Ix_ExcelSizeStart = 1;     //F2
            _Ix_Material = 5;			//F6
            _Ix_Material_1 = 6;			//F7
            _Ix_SpecUnit = 15;			//F16
            _Ix_Color = 17;				//F18
            _Ix_CommonYieldValue = 23;	//F24


            numeric_Component.Value = _Ix_Component;
            numeric_SizeStart.Value = _Ix_ExcelSizeStart;
            numeric_Material1.Value = _Ix_Material;
            numeric_Material2.Value = _Ix_Material_1;
            numeric_SpecUnit.Value = _Ix_SpecUnit;
            numeric_Color.Value = _Ix_Color;
            numeric_CommonYield.Value = _Ix_CommonYieldValue;

        }



		#endregion 

		#region 이벤트 처리
		
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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{  
				Apply();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_Close_Apply = false;
			this.Close();
		}


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Reset_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		#endregion       

		#region DB Connect
 


		#endregion 

 

	}
}

