using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Exchange_Rate : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label lbl_season;
		private System.Windows.Forms.Label lbl_date;
		private C1.Win.C1List.C1Combo cmb_season;
		private System.Windows.Forms.DateTimePicker dpick_ymd;
		private System.Windows.Forms.TextBox txt_rate;
		private System.Windows.Forms.Label btn_rate;
		private C1.Win.C1List.C1Combo cmb_curType;
		private System.Windows.Forms.Label lbl_curType;
		private System.Windows.Forms.Label lbl_rate;
		private System.ComponentModel.IContainer components = null;

		private Point _txtOP, _txtNP;
		private Point _lblOP, _lblNP;
		private Point _btnOP, _btnNP;

		public Pop_BP_Exchange_Rate()
		{
			InitializeComponent();
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Exchange_Rate));
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
            this.lbl_season = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.cmb_season = new C1.Win.C1List.C1Combo();
            this.dpick_ymd = new System.Windows.Forms.DateTimePicker();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.btn_rate = new System.Windows.Forms.Label();
            this.cmb_curType = new C1.Win.C1List.C1Combo();
            this.lbl_curType = new System.Windows.Forms.Label();
            this.lbl_rate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curType)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(328, 23);
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
            // lbl_season
            // 
            this.lbl_season.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_season.ImageIndex = 0;
            this.lbl_season.ImageList = this.img_Label;
            this.lbl_season.Location = new System.Drawing.Point(24, 70);
            this.lbl_season.Name = "lbl_season";
            this.lbl_season.Size = new System.Drawing.Size(100, 21);
            this.lbl_season.TabIndex = 406;
            this.lbl_season.Text = "Season";
            this.lbl_season.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_date
            // 
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ImageIndex = 0;
            this.lbl_date.ImageList = this.img_Label;
            this.lbl_date.Location = new System.Drawing.Point(24, 64);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(100, 21);
            this.lbl_date.TabIndex = 405;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_season
            // 
            this.cmb_season.AddItemCols = 0;
            this.cmb_season.AddItemSeparator = ';';
            this.cmb_season.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_season.Caption = "";
            this.cmb_season.CaptionHeight = 17;
            this.cmb_season.CaptionStyle = style1;
            this.cmb_season.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_season.ColumnCaptionHeight = 18;
            this.cmb_season.ColumnFooterHeight = 18;
            this.cmb_season.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_season.ContentHeight = 16;
            this.cmb_season.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_season.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_season.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_season.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_season.EditorHeight = 16;
            this.cmb_season.EvenRowStyle = style2;
            this.cmb_season.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_season.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_season.FooterStyle = style3;
            this.cmb_season.GapHeight = 2;
            this.cmb_season.HeadingStyle = style4;
            this.cmb_season.HighLightRowStyle = style5;
            this.cmb_season.ItemHeight = 15;
            this.cmb_season.Location = new System.Drawing.Point(125, 70);
            this.cmb_season.MatchEntryTimeout = ((long)(2000));
            this.cmb_season.MaxDropDownItems = ((short)(5));
            this.cmb_season.MaxLength = 32767;
            this.cmb_season.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_season.Name = "cmb_season";
            this.cmb_season.OddRowStyle = style6;
            this.cmb_season.PartialRightColumn = false;
            this.cmb_season.PropBag = resources.GetString("cmb_season.PropBag");
            this.cmb_season.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_season.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_season.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_season.SelectedStyle = style7;
            this.cmb_season.Size = new System.Drawing.Size(200, 20);
            this.cmb_season.Style = style8;
            this.cmb_season.TabIndex = 404;
            this.cmb_season.SelectedValueChanged += new System.EventHandler(this.cmb_season_SelectedValueChanged);
            // 
            // dpick_ymd
            // 
            this.dpick_ymd.CustomFormat = "";
            this.dpick_ymd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ymd.Location = new System.Drawing.Point(125, 70);
            this.dpick_ymd.Name = "dpick_ymd";
            this.dpick_ymd.Size = new System.Drawing.Size(201, 21);
            this.dpick_ymd.TabIndex = 403;
            this.dpick_ymd.CloseUp += new System.EventHandler(this.dpick_ymd_CloseUp);
            // 
            // txt_rate
            // 
            this.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_rate.Location = new System.Drawing.Point(125, 92);
            this.txt_rate.MaxLength = 10;
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(200, 21);
            this.txt_rate.TabIndex = 402;
            this.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_rate
            // 
            this.btn_rate.ImageIndex = 3;
            this.btn_rate.ImageList = this.img_SmallButton;
            this.btn_rate.Location = new System.Drawing.Point(326, 92);
            this.btn_rate.Name = "btn_rate";
            this.btn_rate.Size = new System.Drawing.Size(21, 21);
            this.btn_rate.TabIndex = 401;
            this.btn_rate.Tag = "Search";
            this.btn_rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_rate.Click += new System.EventHandler(this.btn_rate_Click);
            // 
            // cmb_curType
            // 
            this.cmb_curType.AddItemCols = 0;
            this.cmb_curType.AddItemSeparator = ';';
            this.cmb_curType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_curType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_curType.Caption = "";
            this.cmb_curType.CaptionHeight = 17;
            this.cmb_curType.CaptionStyle = style9;
            this.cmb_curType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_curType.ColumnCaptionHeight = 18;
            this.cmb_curType.ColumnFooterHeight = 18;
            this.cmb_curType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_curType.ContentHeight = 16;
            this.cmb_curType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_curType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_curType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_curType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_curType.EditorHeight = 16;
            this.cmb_curType.EvenRowStyle = style10;
            this.cmb_curType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_curType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_curType.FooterStyle = style11;
            this.cmb_curType.GapHeight = 2;
            this.cmb_curType.HeadingStyle = style12;
            this.cmb_curType.HighLightRowStyle = style13;
            this.cmb_curType.ItemHeight = 15;
            this.cmb_curType.Location = new System.Drawing.Point(125, 48);
            this.cmb_curType.MatchEntryTimeout = ((long)(2000));
            this.cmb_curType.MaxDropDownItems = ((short)(5));
            this.cmb_curType.MaxLength = 32767;
            this.cmb_curType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_curType.Name = "cmb_curType";
            this.cmb_curType.OddRowStyle = style14;
            this.cmb_curType.PartialRightColumn = false;
            this.cmb_curType.PropBag = resources.GetString("cmb_curType.PropBag");
            this.cmb_curType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_curType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_curType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_curType.SelectedStyle = style15;
            this.cmb_curType.Size = new System.Drawing.Size(200, 20);
            this.cmb_curType.Style = style16;
            this.cmb_curType.TabIndex = 399;
            this.cmb_curType.SelectedValueChanged += new System.EventHandler(this.cmb_curType_SelectedValueChanged);
            // 
            // lbl_curType
            // 
            this.lbl_curType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_curType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curType.ImageIndex = 0;
            this.lbl_curType.ImageList = this.img_Label;
            this.lbl_curType.Location = new System.Drawing.Point(24, 48);
            this.lbl_curType.Name = "lbl_curType";
            this.lbl_curType.Size = new System.Drawing.Size(100, 21);
            this.lbl_curType.TabIndex = 400;
            this.lbl_curType.Text = "Rate Type";
            this.lbl_curType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rate
            // 
            this.lbl_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rate.ImageIndex = 0;
            this.lbl_rate.ImageList = this.img_Label;
            this.lbl_rate.Location = new System.Drawing.Point(24, 92);
            this.lbl_rate.Name = "lbl_rate";
            this.lbl_rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_rate.TabIndex = 407;
            this.lbl_rate.Text = "Exchange Rate";
            this.lbl_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BP_Exchange_Rate
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(362, 135);
            this.Controls.Add(this.lbl_rate);
            this.Controls.Add(this.lbl_season);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.cmb_season);
            this.Controls.Add(this.dpick_ymd);
            this.Controls.Add(this.txt_rate);
            this.Controls.Add(this.btn_rate);
            this.Controls.Add(this.cmb_curType);
            this.Controls.Add(this.lbl_curType);
            this.Name = "Pop_BP_Exchange_Rate";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.lbl_curType, 0);
            this.Controls.SetChildIndex(this.cmb_curType, 0);
            this.Controls.SetChildIndex(this.btn_rate, 0);
            this.Controls.SetChildIndex(this.txt_rate, 0);
            this.Controls.SetChildIndex(this.dpick_ymd, 0);
            this.Controls.SetChildIndex(this.cmb_season, 0);
            this.Controls.SetChildIndex(this.lbl_date, 0);
            this.Controls.SetChildIndex(this.lbl_season, 0);
            this.Controls.SetChildIndex(this.lbl_rate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_season)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_curType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Init_Form()
		{

			this.Text = "Exchange Rate";
            lbl_MainTitle.Text = "Exchange Rate";
            ClassLib.ComFunction.SetLangDic(this);

			_txtOP = txt_rate.Location;
			_lblOP = lbl_rate.Location;
			_btnOP = btn_rate.Location;
			_txtNP = new Point(_txtOP.X, _txtOP.Y - 22);
			_lblNP = new Point(_lblOP.X, _lblOP.Y - 22);
			_btnNP = new Point(_btnOP.X, _btnOP.Y - 22);

			DataTable vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBP08");
			COM.ComCtl.Set_ComboList(vDt, cmb_curType, 1, 2, false);
			cmb_curType.SelectedIndex = 2;
			vDt.Dispose();

			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP14");
			COM.ComCtl.Set_ComboList(vDt, cmb_season, 1, 2, false);
			cmb_season.SelectedIndex = cmb_season.ListCount - 1;
			vDt.Dispose();
			
		}


		private void cmb_curType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			curTypeChanged();
		}

		private void dpick_ymd_CloseUp(object sender, System.EventArgs e)
		{
			string vDate = dpick_ymd.Value.ToString("yyyyMMdd");
			string vRate = getRate(vDate);
			txt_rate.Text = vRate;
		}

		private void cmb_season_SelectedValueChanged(object sender, System.EventArgs e)
		{
			txt_rate.Text = cmb_season.GetItemText(cmb_season.SelectedIndex, 1);
		}

		private void btn_rate_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		#endregion



		#region 이벤트 처리 메서드

		private void curTypeChanged()
		{
			string vRate = "";
			bool vSeason = false;
			bool vYmd = false;

			switch (cmb_curType.SelectedIndex)
			{
				case 0:	// 현재 환률
					dpick_ymd.Value = DateTime.Now;
					string vCurDate = DateTime.Now.ToString("yyyyMMdd");
					vRate = getRate(vCurDate);
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vSeason = false;
					vYmd = true;
					break;
				case 1: // 지난달 환률
					DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(-1);
					dpick_ymd.Value = dt;
					string vLastMonth = dt.ToString("yyyyMMdd");
					vRate = getRate(vLastMonth);
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vSeason = false;
					vYmd = true;
					break;
				case 2: // 시즌
					txt_rate.ReadOnly = true;
					txt_rate.BackColor = Color.WhiteSmoke;
					vRate = cmb_season.SelectedValue == null ? "1" : cmb_season.GetItemText(cmb_season.SelectedIndex, 1);
					vSeason = true;
					vYmd = false;
					break;
				case 3: // 사용자 정의
					txt_rate.ReadOnly = false;
					txt_rate.BackColor = Color.White;
					vRate = "1";
					break;
			}

			if (!vSeason && !vYmd)
			{
				txt_rate.Location = _txtNP;
				lbl_rate.Location = _lblNP;
				btn_rate.Location = _btnNP;
			} 
			else
			{
				txt_rate.Location = _txtOP;
				lbl_rate.Location = _lblOP;
				btn_rate.Location = _btnOP;
			}

			cmb_season.Enabled = vSeason;
			cmb_season.Visible = vSeason;
			lbl_season.Visible = vSeason;
			dpick_ymd.Enabled = vYmd;
			dpick_ymd.Visible = vYmd;
			lbl_date.Visible =  vYmd;

			txt_rate.Text = vRate;
		}

		private string getRate(string arg_date)
		{
			string vLastMonth = arg_date;
			DataTable vDt = ClassLib.ComFunction.Select_Ymd_Rate(vLastMonth);
			string vRate = vDt.Rows[0][0].ToString();
			return vRate;
		}

		#endregion

		#region getter / setter

		public double getResultRate()
		{
			try
			{
				return Convert.ToDouble(txt_rate.Text);
			}
			catch
			{
				return 0;
			}
		}

		#endregion

	}
}

