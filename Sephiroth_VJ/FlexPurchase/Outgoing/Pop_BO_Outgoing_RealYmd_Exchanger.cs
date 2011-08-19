using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Outgoing
{
	public class Pop_BO_Outgoing_RealYmd_Exchanger : COM.PCHWinForm.Pop_Small
	{
		

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DateTimePicker dpick_Ymd;
		private System.Windows.Forms.Label lbl_OutYmd;
		private System.Windows.Forms.Label lbl_WH;
		private C1.Win.C1List.C1Combo cmb_wareHouse;


		public Pop_BO_Outgoing_RealYmd_Exchanger()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BO_Outgoing_RealYmd_Exchanger));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_OutYmd = new System.Windows.Forms.Label();
            this.dpick_Ymd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_wareHouse = new C1.Win.C1List.C1Combo();
            this.lbl_WH = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "61.2068965517241:False:False;28.448275862069:False:False;\t1.01010101010101:False:" +
                "True;93.9393939393939:False:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(396, 116);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_OutYmd);
            this.panel1.Controls.Add(this.dpick_Ymd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 71);
            this.panel1.TabIndex = 184;
            // 
            // lbl_OutYmd
            // 
            this.lbl_OutYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutYmd.ImageIndex = 0;
            this.lbl_OutYmd.ImageList = this.img_Label;
            this.lbl_OutYmd.Location = new System.Drawing.Point(14, 16);
            this.lbl_OutYmd.Name = "lbl_OutYmd";
            this.lbl_OutYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutYmd.TabIndex = 394;
            this.lbl_OutYmd.Text = "Outgoing Date";
            this.lbl_OutYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_Ymd
            // 
            this.dpick_Ymd.CustomFormat = "";
            this.dpick_Ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_Ymd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_Ymd.Location = new System.Drawing.Point(115, 16);
            this.dpick_Ymd.Name = "dpick_Ymd";
            this.dpick_Ymd.Size = new System.Drawing.Size(219, 21);
            this.dpick_Ymd.TabIndex = 395;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_wareHouse);
            this.groupBox1.Controls.Add(this.lbl_WH);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 166);
            this.groupBox1.TabIndex = 403;
            this.groupBox1.TabStop = false;
            // 
            // cmb_wareHouse
            // 
            this.cmb_wareHouse.AddItemCols = 0;
            this.cmb_wareHouse.AddItemSeparator = ';';
            this.cmb_wareHouse.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_wareHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_wareHouse.Caption = "";
            this.cmb_wareHouse.CaptionHeight = 17;
            this.cmb_wareHouse.CaptionStyle = style1;
            this.cmb_wareHouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_wareHouse.ColumnCaptionHeight = 18;
            this.cmb_wareHouse.ColumnFooterHeight = 18;
            this.cmb_wareHouse.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_wareHouse.ContentHeight = 16;
            this.cmb_wareHouse.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_wareHouse.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_wareHouse.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_wareHouse.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_wareHouse.EditorHeight = 16;
            this.cmb_wareHouse.EvenRowStyle = style2;
            this.cmb_wareHouse.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_wareHouse.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_wareHouse.FooterStyle = style3;
            this.cmb_wareHouse.GapHeight = 2;
            this.cmb_wareHouse.HeadingStyle = style4;
            this.cmb_wareHouse.HighLightRowStyle = style5;
            this.cmb_wareHouse.ItemHeight = 15;
            this.cmb_wareHouse.Location = new System.Drawing.Point(115, 38);
            this.cmb_wareHouse.MatchEntryTimeout = ((long)(2000));
            this.cmb_wareHouse.MaxDropDownItems = ((short)(5));
            this.cmb_wareHouse.MaxLength = 32767;
            this.cmb_wareHouse.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_wareHouse.Name = "cmb_wareHouse";
            this.cmb_wareHouse.OddRowStyle = style6;
            this.cmb_wareHouse.PartialRightColumn = false;
            this.cmb_wareHouse.PropBag = resources.GetString("cmb_wareHouse.PropBag");
            this.cmb_wareHouse.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_wareHouse.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_wareHouse.SelectedStyle = style7;
            this.cmb_wareHouse.Size = new System.Drawing.Size(218, 20);
            this.cmb_wareHouse.Style = style8;
            this.cmb_wareHouse.TabIndex = 424;
            this.cmb_wareHouse.Visible = false;
            // 
            // lbl_WH
            // 
            this.lbl_WH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_WH.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WH.ImageIndex = 0;
            this.lbl_WH.ImageList = this.img_Label;
            this.lbl_WH.Location = new System.Drawing.Point(14, 38);
            this.lbl_WH.Name = "lbl_WH";
            this.lbl_WH.Size = new System.Drawing.Size(100, 21);
            this.lbl_WH.TabIndex = 395;
            this.lbl_WH.Text = "Warehouse";
            this.lbl_WH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_WH.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_apply);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 33);
            this.panel2.TabIndex = 181;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(293, 6);
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
            this.btn_apply.Location = new System.Drawing.Point(221, 6);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 237;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // Pop_BO_Outgoing_RealYmd_Exchanger
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 176);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BO_Outgoing_RealYmd_Exchanger";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_wareHouse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp		= new string[2];
			COM.ComVar.Parameter_PopUp[0]	= dpick_Ymd.Text.Replace("-","");
			COM.ComVar.Parameter_PopUp[1]	= cmb_wareHouse.SelectedValue.ToString();
			 
			this.Dispose();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
//			COM.ComVar.Parameter_PopUp		= new string[1];
//			COM.ComVar.Parameter_PopUp[0]	= "";

			ClassLib.ComVar.Parameter_PopUp = null;

			this.Dispose();
		}

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

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{
            // Form Setting
            ClassLib.ComFunction.SetLangDic(this);

			if ( COM.ComVar.Parameter_PopUp != null )
			{


				lbl_MainTitle.Text	= COM.ComVar.Parameter_PopUp[0].ToString();
				this.Text			= lbl_MainTitle.Text; 
				 
			}



			// WareHouse Combobox Setting
			DataTable vDt = null;

			if(COM.ComVar.Parameter_PopUp.Length == 3)
			{
				vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(COM.ComVar.Parameter_PopUp[2]);
			}
			else
			{
				vDt = FlexPurchase.ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(ClassLib.ComVar.This_Factory);
			}
			
			
			COM.ComCtl.Set_ComboList(vDt, cmb_wareHouse, 1, 2, false, COM.ComVar.ComboList_Visible.Name); 



			if(COM.ComVar.Parameter_PopUp.Length == 4)
			{
				cmb_wareHouse.SelectedValue = COM.ComVar.Parameter_PopUp[3];

				lbl_WH.Visible = false;
				cmb_wareHouse.Visible = false;
			}
			else
			{
				cmb_wareHouse.SelectedIndex = 0;
			}

			


			vDt.Dispose();


			COM.ComVar.Parameter_PopUp = null;

		}

		#endregion

		#region DB Connect
 		
		#endregion

	}
}

