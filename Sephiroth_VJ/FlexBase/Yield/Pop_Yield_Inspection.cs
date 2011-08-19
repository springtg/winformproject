using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class Pop_Yield_Inspection : COM.PCHWinForm.Pop_Small_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Qty;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label btn_Print;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.TextBox txt_Qty;
		private System.Windows.Forms.Label btn_Cancel;

		public Pop_Yield_Inspection()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
		}

 
		private string _Factory; 
		private string _StyleCd = "";


		public Pop_Yield_Inspection(string arg_factory, string arg_style_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_Factory = arg_factory;
			_StyleCd = arg_style_cd; 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Inspection));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Presto = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txt_Presto);
            this.groupBox1.Controls.Add(this.txt_Gender);
            this.groupBox1.Controls.Add(this.lbl_Gender);
            this.groupBox1.Controls.Add(this.cmb_StyleCd);
            this.groupBox1.Controls.Add(this.txt_StyleCd);
            this.groupBox1.Controls.Add(this.cmb_Factory);
            this.groupBox1.Controls.Add(this.txt_Qty);
            this.groupBox1.Controls.Add(this.lbl_Style);
            this.groupBox1.Controls.Add(this.lbl_Qty);
            this.groupBox1.Controls.Add(this.lbl_Factory);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 113);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txt_Presto
            // 
            this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Presto.Location = new System.Drawing.Point(205, 58);
            this.txt_Presto.MaxLength = 100;
            this.txt_Presto.Name = "txt_Presto";
            this.txt_Presto.ReadOnly = true;
            this.txt_Presto.Size = new System.Drawing.Size(171, 21);
            this.txt_Presto.TabIndex = 548;
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Gender.Location = new System.Drawing.Point(108, 58);
            this.txt_Gender.MaxLength = 100;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.Size = new System.Drawing.Size(96, 21);
            this.txt_Gender.TabIndex = 546;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(7, 58);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 547;
            this.lbl_Gender.Text = "Gender/ Presto";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style17;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style18;
            this.cmb_StyleCd.FooterStyle = style19;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style20;
            this.cmb_StyleCd.HighLightRowStyle = style21;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(205, 36);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style22;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style23;
            this.cmb_StyleCd.Size = new System.Drawing.Size(171, 21);
            this.cmb_StyleCd.Style = style24;
            this.cmb_StyleCd.TabIndex = 544;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(108, 36);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(96, 21);
            this.txt_StyleCd.TabIndex = 545;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(108, 14);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(268, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 543;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // txt_Qty
            // 
            this.txt_Qty.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Qty.Location = new System.Drawing.Point(108, 80);
            this.txt_Qty.MaxLength = 18;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(268, 21);
            this.txt_Qty.TabIndex = 1;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(7, 36);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 542;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Qty.ImageIndex = 0;
            this.lbl_Qty.ImageList = this.img_Label;
            this.lbl_Qty.Location = new System.Drawing.Point(7, 80);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_Qty.TabIndex = 541;
            this.lbl_Qty.Text = "Quantity";
            this.lbl_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 14);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 540;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_Cancel.Location = new System.Drawing.Point(319, 160);
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
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Print.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Print.ImageIndex = 0;
            this.btn_Print.ImageList = this.img_Button;
            this.btn_Print.Location = new System.Drawing.Point(248, 160);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(70, 23);
            this.btn_Print.TabIndex = 667;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            this.btn_Print.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Print.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Print.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_Inspection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 191);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Yield_Inspection";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.btn_Print, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의
 	 

		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				//Title 
				this.Text = "Yield Inspection";
				lbl_MainTitle.Text = "Yield Inspection";


                ClassLib.ComFunction.SetLangDic(this);

				//컨트롤 세팅
				Init_Control();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
  
		}


		/// <summary>
		/// Init_Control : 컨트롤 세팅
		/// </summary>
		private void Init_Control()
		{
			 

			DataTable dt_ret;

			/// 공장코드
			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = _Factory;
			
			
			// Style Code
			if(_StyleCd != "")
			{
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_String(_StyleCd, " ") );  
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200);  
				cmb_StyleCd.SelectedValue = _StyleCd;
				txt_StyleCd.Text = _StyleCd; 
			}


			dt_ret.Dispose();


			 
			
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

  


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1) return; 

				txt_StyleCd.Text = "";
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = ""; 
				txt_Presto.Text = "";  
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 


		}



		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

 

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleCd.SelectedIndex = -1;
				txt_Gender.Text = ""; 
				txt_Presto.Text = ""; 
				//-------------------------------------------------------------------------

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 

				string stylecd = "";
				int exist_index = -1;

				stylecd = txt_StyleCd.Text.Trim();

				exist_index = txt_StyleCd.Text.IndexOf("-", 0);

				if(exist_index == -1 && stylecd.Length == 9)
				{
					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
				}
 
				cmb_StyleCd.SelectedValue = stylecd;

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
 


				//---------------------------------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				txt_Gender.Text = ""; 
				txt_Presto.Text = ""; 
				//---------------------------------------------------------------------------------------------------

				

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
				txt_Gender.Text = cmb_StyleCd.Columns[2].Text; 
				txt_Presto.Text = cmb_StyleCd.Columns[3].Text;  


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 

		private void btn_Print_Click(object sender, System.EventArgs e)
		{
			
			try
			{

				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
 
				bool check_flag = ClassLib.ComFunction.Check_Decimal(txt_Qty.Text.Trim() );  
				if(! check_flag) return; 
 

				string sDir = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Yield_Expend");
				
				string sPara  = " /rp ";


				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Factory, " ") + "' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "") + "' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_Qty, " ") + "' "; 

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Yield Inspection";
				MyReport.Show();




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{ 
			this.Close();
		}

		 


		#endregion      

		#region DB Connect
 

		#endregion 

 

	}
}

