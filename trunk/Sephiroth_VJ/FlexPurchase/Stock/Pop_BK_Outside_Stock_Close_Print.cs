using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Stock
{
	public class Pop_BK_Outside_Stock_Close_Print : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_obsType;
		private C1.Win.C1List.C1Combo cmb_printType;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 멤버 변수

		#endregion

		#region 생성자 / 소멸자

		public Pop_BK_Outside_Stock_Close_Print()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_Outside_Stock_Close_Print));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_printType = new C1.Win.C1List.C1Combo();
            this.lbl_obsType = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(336, 23);
            this.lbl_MainTitle.Text = "Print";
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_printType);
            this.groupBox1.Controls.Add(this.lbl_obsType);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 64);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Print Information ";
            // 
            // cmb_printType
            // 
            this.cmb_printType.AddItemCols = 0;
            this.cmb_printType.AddItemSeparator = ';';
            this.cmb_printType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_printType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_printType.Caption = "";
            this.cmb_printType.CaptionHeight = 17;
            this.cmb_printType.CaptionStyle = style1;
            this.cmb_printType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_printType.ColumnCaptionHeight = 18;
            this.cmb_printType.ColumnFooterHeight = 18;
            this.cmb_printType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_printType.ContentHeight = 17;
            this.cmb_printType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_printType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_printType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_printType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_printType.EditorHeight = 17;
            this.cmb_printType.EvenRowStyle = style2;
            this.cmb_printType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_printType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_printType.FooterStyle = style3;
            this.cmb_printType.GapHeight = 2;
            this.cmb_printType.HeadingStyle = style4;
            this.cmb_printType.HighLightRowStyle = style5;
            this.cmb_printType.ItemHeight = 15;
            this.cmb_printType.Location = new System.Drawing.Point(117, 24);
            this.cmb_printType.MatchEntryTimeout = ((long)(2000));
            this.cmb_printType.MaxDropDownItems = ((short)(5));
            this.cmb_printType.MaxLength = 32767;
            this.cmb_printType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_printType.Name = "cmb_printType";
            this.cmb_printType.OddRowStyle = style6;
            this.cmb_printType.PartialRightColumn = false;
            this.cmb_printType.PropBag = resources.GetString("cmb_printType.PropBag");
            this.cmb_printType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_printType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_printType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_printType.SelectedStyle = style7;
            this.cmb_printType.Size = new System.Drawing.Size(220, 21);
            this.cmb_printType.Style = style8;
            this.cmb_printType.TabIndex = 418;
            // 
            // lbl_obsType
            // 
            this.lbl_obsType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_obsType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obsType.ImageIndex = 0;
            this.lbl_obsType.ImageList = this.img_Label;
            this.lbl_obsType.Location = new System.Drawing.Point(16, 24);
            this.lbl_obsType.Name = "lbl_obsType";
            this.lbl_obsType.Size = new System.Drawing.Size(100, 21);
            this.lbl_obsType.TabIndex = 414;
            this.lbl_obsType.Text = "Print Type";
            this.lbl_obsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(292, 104);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 356;
            this.btn_apply.Text = "Print";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // Pop_BK_Outside_Stock_Close_Print
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(370, 135);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_BK_Outside_Stock_Close_Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Pop_BK_Stock_Report_Print_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_printType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Pop_BK_Stock_Report_Print_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		#endregion

		#region 버튼 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				string printType = cmb_printType.GetItemText(cmb_printType.SelectedIndex, 1);

				if (printType.Equals(""))
					return;

				string mrd_Filename = "";
				if (cmb_printType.SelectedValue.ToString().Equals("10"))
					mrd_Filename = Application.StartupPath + @"\" + @"Report\Material\Form_Outside_Stock_Close_P1.mrd";
				else
					mrd_Filename = Application.StartupPath + @"\" + @"Report\Material\Form_Outside_Stock_Close_P2.mrd";

				string Para         = " ";

				#region 출력조건

				int  iCnt  = 8;
				string [] aHead =  new string[iCnt];	

				string factory		= ClassLib.ComVar.Parameter_PopUp[0];
				string ship_type	= ClassLib.ComVar.Parameter_PopUp[1];
				string cust_cd		= ClassLib.ComVar.Parameter_PopUp[2];
				string stock_ymd_from = ClassLib.ComVar.Parameter_PopUp[3];
				string stock_ymd_to = ClassLib.ComVar.Parameter_PopUp[4];
				string group_cd		= ClassLib.ComVar.Parameter_PopUp[5];
				string item_cd		= ClassLib.ComVar.Parameter_PopUp[6];
				string item_name	= ClassLib.ComVar.Parameter_PopUp[7];

				aHead[0]    = factory;
				aHead[1]    = ship_type;
				aHead[2]    = cust_cd;
				aHead[3]    = stock_ymd_from;
				aHead[4]    = stock_ymd_to;
				aHead[5]    = group_cd;
				aHead[6]    = item_cd;
				aHead[7]    = item_name;
			 			
				#endregion
			
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
			
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
				report.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_apply.ImageIndex = 1;
		}

		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_apply.ImageIndex = 0;
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{
			try
			{
				// print type
				DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBK13");
				COM.ComCtl.Set_ComboList(vDt, cmb_printType, 1, 2, false, 80, 140);
				cmb_printType.SelectedIndex = 0;
				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

	}
}

