using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Stock
{
	public class Pop_BK_Stock_Remake_InOut_Qty : COM.PCHWinForm.Pop_Small
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.Label lbl_ToDate;
		private System.Windows.Forms.Label lbl_FromDate;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		

		private bool button_action = false;

		#endregion

		#region 생성자 / 소멸자
		
		
		public Pop_BK_Stock_Remake_InOut_Qty()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Stock_Year, _Stock_Month;


		public Pop_BK_Stock_Remake_InOut_Qty(string arg_stock_year, string arg_stock_month)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Stock_Year = arg_stock_year;
			_Stock_Month = arg_stock_month;

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

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		#endregion
		
		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_Stock_Remake_InOut_Qty));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.GridDefinition = "30.1724137931034:False:True;15.5172413793103:False:True;\t1.01010101010101:False:T" +
                "rue;93.9393939393939:False:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 37);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(396, 232);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_ToDate);
            this.panel1.Controls.Add(this.lbl_FromDate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 70);
            this.panel1.TabIndex = 184;
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDate.ImageIndex = 0;
            this.lbl_ToDate.ImageList = this.img_Label;
            this.lbl_ToDate.Location = new System.Drawing.Point(14, 38);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_ToDate.TabIndex = 400;
            this.lbl_ToDate.Text = "To Date";
            this.lbl_ToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDate.ImageIndex = 0;
            this.lbl_FromDate.ImageList = this.img_Label;
            this.lbl_FromDate.Location = new System.Drawing.Point(14, 16);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_FromDate.TabIndex = 394;
            this.lbl_FromDate.Text = "From Date";
            this.lbl_FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpick_to);
            this.groupBox1.Controls.Add(this.dpick_from);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 70);
            this.groupBox1.TabIndex = 403;
            this.groupBox1.TabStop = false;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(115, 38);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(248, 21);
            this.dpick_to.TabIndex = 425;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(115, 16);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(248, 21);
            this.dpick_from.TabIndex = 424;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_apply);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 36);
            this.panel2.TabIndex = 181;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(301, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 238;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(230, 6);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 237;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // Pop_BK_Stock_Remake_InOut_Qty
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 159);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BK_Stock_Remake_InOut_Qty";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_BK_Stock_Remake_InOut_Qty_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
   
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= MyComFunction.ConvertDate2DbType(dpick_from.Text);
			COM.ComVar.Parameter_PopUp[1]	= MyComFunction.ConvertDate2DbType(dpick_to.Text);

			button_action = true; 
			this.Dispose();

		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = null; 
			button_action = true; 
			this.Dispose();
		}


		private void Pop_BK_Stock_Remake_InOut_Qty_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			if(!button_action)
			{
				COM.ComVar.Parameter_PopUp = null;
				this.Dispose();
			}

		}

		#endregion

		#region 롤오버 이미지 처리
		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 1;
		}

		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 0;
		}

		private void btn_close_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_cancel.ImageIndex = 1;
		}

		private void btn_close_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_cancel.ImageIndex = 0;
		}
		#endregion

		#region 이벤트 처리 메서드
 

        private void Init_Form()
		{
            // Form Setting
			lbl_MainTitle.Text = "Remake Stock Date";
            this.Text = "Remake Stock Date";
            ClassLib.ComFunction.SetLangDic(this);

			string stock_year = _Stock_Year;
			string stock_month = _Stock_Month;

			string last_day = System.DateTime.DaysInMonth( Convert.ToInt32(stock_year), Convert.ToInt32(stock_month) ).ToString();

			dpick_from.Text = MyComFunction.ConvertDate2Type(stock_year + stock_month + "01");
			dpick_to.Text = MyComFunction.ConvertDate2Type(stock_year + stock_month + last_day); 
			
			 
		}

		#endregion

		


	}
}

