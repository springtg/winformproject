using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class Pop_Yield_Value : COM.PCHWinForm.Pop_Small_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_YieldValue;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.Label lbl_Size;
		private System.Windows.Forms.TextBox txt_SizeF;
		private System.Windows.Forms.TextBox txt_SizeT;
		internal System.Windows.Forms.Label lbl_FromTo;
		private System.Windows.Forms.Label btn_SearchSpec;
		private System.Windows.Forms.TextBox txt_YieldValue;
		private C1.Win.C1List.C1Combo cmb_SpecDiv;
		private System.Windows.Forms.TextBox txt_SpecName;
		public System.Windows.Forms.ImageList img_SmallButton;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		private C1.Win.C1List.C1Combo cmb_Spec;

		public Pop_Yield_Value()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
		}


		//string[] pop_parameter = new string[] { yield_type, cs_size_f, cs_size_t, yield_value, size_yn, spec_div, spec_cd };

		private string _YieldType;
		private string _Cs_SizeF, _Cs_SizeT;
		private string _YieldValue;
		private string _SizeYN, _SpecDiv, _SpecCd;
		private string _SpecName = "";


		public Pop_Yield_Value(string[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_YieldType = arg_parameter[0];
			_Cs_SizeF = arg_parameter[1];
			_Cs_SizeT = arg_parameter[2];
			_YieldValue = arg_parameter[3];
			_SizeYN = arg_parameter[4];
			_SpecDiv = arg_parameter[5];
			_SpecCd = arg_parameter[6];
 

			Init_Form(); 



		}



		public Pop_Yield_Value(string[] arg_parameter, string arg_specname)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_YieldType = arg_parameter[0];
			_Cs_SizeF = arg_parameter[1];
			_Cs_SizeT = arg_parameter[2];
			_YieldValue = arg_parameter[3];
			_SizeYN = arg_parameter[4];
			_SpecDiv = arg_parameter[5];
			_SpecCd = arg_parameter[6];

			_SpecName = arg_specname;
 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Value));
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
            this.cmb_SpecDiv = new C1.Win.C1List.C1Combo();
            this.txt_YieldValue = new System.Windows.Forms.TextBox();
            this.btn_SearchSpec = new System.Windows.Forms.Label();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.cmb_Spec = new C1.Win.C1List.C1Combo();
            this.lbl_FromTo = new System.Windows.Forms.Label();
            this.txt_SizeT = new System.Windows.Forms.TextBox();
            this.txt_SizeF = new System.Windows.Forms.TextBox();
            this.lbl_YieldValue = new System.Windows.Forms.Label();
            this.lbl_Spec = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.txt_SpecName = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cmb_SpecDiv);
            this.groupBox1.Controls.Add(this.txt_YieldValue);
            this.groupBox1.Controls.Add(this.btn_SearchSpec);
            this.groupBox1.Controls.Add(this.cmb_Spec);
            this.groupBox1.Controls.Add(this.lbl_FromTo);
            this.groupBox1.Controls.Add(this.txt_SizeT);
            this.groupBox1.Controls.Add(this.txt_SizeF);
            this.groupBox1.Controls.Add(this.lbl_YieldValue);
            this.groupBox1.Controls.Add(this.lbl_Spec);
            this.groupBox1.Controls.Add(this.lbl_Size);
            this.groupBox1.Controls.Add(this.txt_SpecName);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 108);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // cmb_SpecDiv
            // 
            this.cmb_SpecDiv.AccessibleDescription = "";
            this.cmb_SpecDiv.AccessibleName = "";
            this.cmb_SpecDiv.AddItemCols = 0;
            this.cmb_SpecDiv.AddItemSeparator = ';';
            this.cmb_SpecDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_SpecDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SpecDiv.Caption = "";
            this.cmb_SpecDiv.CaptionHeight = 17;
            this.cmb_SpecDiv.CaptionStyle = style33;
            this.cmb_SpecDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SpecDiv.ColumnCaptionHeight = 18;
            this.cmb_SpecDiv.ColumnFooterHeight = 18;
            this.cmb_SpecDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SpecDiv.ContentHeight = 17;
            this.cmb_SpecDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SpecDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SpecDiv.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SpecDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SpecDiv.EditorHeight = 17;
            this.cmb_SpecDiv.EvenRowStyle = style34;
            this.cmb_SpecDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SpecDiv.FooterStyle = style35;
            this.cmb_SpecDiv.GapHeight = 2;
            this.cmb_SpecDiv.HeadingStyle = style36;
            this.cmb_SpecDiv.HighLightRowStyle = style37;
            this.cmb_SpecDiv.ItemHeight = 15;
            this.cmb_SpecDiv.Location = new System.Drawing.Point(108, 58);
            this.cmb_SpecDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_SpecDiv.MaxDropDownItems = ((short)(5));
            this.cmb_SpecDiv.MaxLength = 32767;
            this.cmb_SpecDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SpecDiv.Name = "cmb_SpecDiv";
            this.cmb_SpecDiv.OddRowStyle = style38;
            this.cmb_SpecDiv.PartialRightColumn = false;
            this.cmb_SpecDiv.PropBag = resources.GetString("cmb_SpecDiv.PropBag");
            this.cmb_SpecDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SpecDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SpecDiv.SelectedStyle = style39;
            this.cmb_SpecDiv.Size = new System.Drawing.Size(268, 21);
            this.cmb_SpecDiv.Style = style40;
            this.cmb_SpecDiv.TabIndex = 548;
            this.cmb_SpecDiv.SelectedValueChanged += new System.EventHandler(this.cmb_SpecDiv_SelectedValueChanged);
            // 
            // txt_YieldValue
            // 
            this.txt_YieldValue.BackColor = System.Drawing.SystemColors.Window;
            this.txt_YieldValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_YieldValue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_YieldValue.Location = new System.Drawing.Point(108, 36);
            this.txt_YieldValue.MaxLength = 18;
            this.txt_YieldValue.Name = "txt_YieldValue";
            this.txt_YieldValue.Size = new System.Drawing.Size(268, 21);
            this.txt_YieldValue.TabIndex = 1;
            this.txt_YieldValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_YieldValue_KeyUp);
            // 
            // btn_SearchSpec
            // 
            this.btn_SearchSpec.ImageIndex = 0;
            this.btn_SearchSpec.ImageList = this.img_SmallButton;
            this.btn_SearchSpec.Location = new System.Drawing.Point(355, 80);
            this.btn_SearchSpec.Name = "btn_SearchSpec";
            this.btn_SearchSpec.Size = new System.Drawing.Size(21, 21);
            this.btn_SearchSpec.TabIndex = 50;
            this.btn_SearchSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchSpec.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchSpec.Click += new System.EventHandler(this.btn_SearchSpec_Click);
            this.btn_SearchSpec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchSpec.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchSpec.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            // 
            // cmb_Spec
            // 
            this.cmb_Spec.AccessibleDescription = "";
            this.cmb_Spec.AccessibleName = "";
            this.cmb_Spec.AddItemCols = 0;
            this.cmb_Spec.AddItemSeparator = ';';
            this.cmb_Spec.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Spec.Caption = "";
            this.cmb_Spec.CaptionHeight = 17;
            this.cmb_Spec.CaptionStyle = style41;
            this.cmb_Spec.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Spec.ColumnCaptionHeight = 18;
            this.cmb_Spec.ColumnFooterHeight = 18;
            this.cmb_Spec.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Spec.ContentHeight = 17;
            this.cmb_Spec.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Spec.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Spec.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spec.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Spec.EditorHeight = 17;
            this.cmb_Spec.EvenRowStyle = style42;
            this.cmb_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Spec.FooterStyle = style43;
            this.cmb_Spec.GapHeight = 2;
            this.cmb_Spec.HeadingStyle = style44;
            this.cmb_Spec.HighLightRowStyle = style45;
            this.cmb_Spec.ItemHeight = 15;
            this.cmb_Spec.Location = new System.Drawing.Point(232, 80);
            this.cmb_Spec.MatchEntryTimeout = ((long)(2000));
            this.cmb_Spec.MaxDropDownItems = ((short)(5));
            this.cmb_Spec.MaxLength = 32767;
            this.cmb_Spec.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Spec.Name = "cmb_Spec";
            this.cmb_Spec.OddRowStyle = style46;
            this.cmb_Spec.PartialRightColumn = false;
            this.cmb_Spec.PropBag = resources.GetString("cmb_Spec.PropBag");
            this.cmb_Spec.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Spec.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Spec.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Spec.SelectedStyle = style47;
            this.cmb_Spec.Size = new System.Drawing.Size(122, 21);
            this.cmb_Spec.Style = style48;
            this.cmb_Spec.TabIndex = 40;
            // 
            // lbl_FromTo
            // 
            this.lbl_FromTo.Location = new System.Drawing.Point(231, 15);
            this.lbl_FromTo.Name = "lbl_FromTo";
            this.lbl_FromTo.Size = new System.Drawing.Size(21, 21);
            this.lbl_FromTo.TabIndex = 546;
            this.lbl_FromTo.Text = "~";
            this.lbl_FromTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SizeT
            // 
            this.txt_SizeT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SizeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_SizeT.Location = new System.Drawing.Point(253, 14);
            this.txt_SizeT.MaxLength = 100;
            this.txt_SizeT.Name = "txt_SizeT";
            this.txt_SizeT.ReadOnly = true;
            this.txt_SizeT.Size = new System.Drawing.Size(123, 21);
            this.txt_SizeT.TabIndex = 547;
            this.txt_SizeT.TabStop = false;
            // 
            // txt_SizeF
            // 
            this.txt_SizeF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SizeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeF.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_SizeF.Location = new System.Drawing.Point(108, 14);
            this.txt_SizeF.MaxLength = 100;
            this.txt_SizeF.Name = "txt_SizeF";
            this.txt_SizeF.ReadOnly = true;
            this.txt_SizeF.Size = new System.Drawing.Size(123, 21);
            this.txt_SizeF.TabIndex = 545;
            this.txt_SizeF.TabStop = false;
            // 
            // lbl_YieldValue
            // 
            this.lbl_YieldValue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_YieldValue.ImageIndex = 0;
            this.lbl_YieldValue.ImageList = this.img_Label;
            this.lbl_YieldValue.Location = new System.Drawing.Point(7, 36);
            this.lbl_YieldValue.Name = "lbl_YieldValue";
            this.lbl_YieldValue.Size = new System.Drawing.Size(100, 21);
            this.lbl_YieldValue.TabIndex = 542;
            this.lbl_YieldValue.Text = "Yield Value";
            this.lbl_YieldValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Spec
            // 
            this.lbl_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Spec.ImageIndex = 0;
            this.lbl_Spec.ImageList = this.img_Label;
            this.lbl_Spec.Location = new System.Drawing.Point(7, 58);
            this.lbl_Spec.Name = "lbl_Spec";
            this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec.TabIndex = 541;
            this.lbl_Spec.Text = "Specification";
            this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Size
            // 
            this.lbl_Size.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Size.ImageIndex = 0;
            this.lbl_Size.ImageList = this.img_Label;
            this.lbl_Size.Location = new System.Drawing.Point(7, 14);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(100, 21);
            this.lbl_Size.TabIndex = 540;
            this.lbl_Size.Text = "Size";
            this.lbl_Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SpecName
            // 
            this.txt_SpecName.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_SpecName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SpecName.Location = new System.Drawing.Point(108, 80);
            this.txt_SpecName.MaxLength = 100;
            this.txt_SpecName.Name = "txt_SpecName";
            this.txt_SpecName.Size = new System.Drawing.Size(123, 21);
            this.txt_SpecName.TabIndex = 568;
            this.txt_SpecName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SpecName_KeyUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 152);
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
            this.btn_Apply.Location = new System.Drawing.Point(248, 152);
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
            // Pop_Yield_Value
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 183);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Yield_Value";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Yield_Value_Closing);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SpecDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Spec)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		//채산 타입 
		private string _YieldTypeE = "E";
		private string _YieldTypeM = "M";

		//Apply 버튼 클릭 여부
		private bool _Close_Apply = false;


		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{

                ClassLib.ComFunction.SetLangDic(this);

				//Title
				string title = "";

				if(_YieldType == _YieldTypeE)
				{ 
					title = "Yield (E) Value";
				}
				else if(_YieldType == _YieldTypeM)
				{
					title = "Yield (M) Value";
				}

				this.Text = title;
				lbl_MainTitle.Text = title;


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
			txt_SizeF.Text = _Cs_SizeF;
			txt_SizeT.Text = _Cs_SizeT;
			txt_YieldValue.Text = _YieldValue;


			DataTable dt_ret;

			// Specification Division Combo List
			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SpecDiv, 1, 4, true, ClassLib.ComVar.ComboList_Visible.Name); 

			cmb_SpecDiv.SelectedValue = _SpecDiv;

			dt_ret.Dispose();


			
			if(_SizeYN == "Y")
			{
				cmb_SpecDiv.Enabled = true;
				cmb_Spec.Enabled = true;

				txt_SpecName.Enabled = true;
				txt_SpecName.BackColor = Color.FromKnownColor(KnownColor.Window);

				if(! _SpecName.Equals("") && _SpecDiv == "1")
				{ 
					txt_SpecName.Text = _SpecName; 
					Set_Spec_Combo();  
					//cmb_Spec.SelectedText = _SpecName; 

					for(int i = 0; i < cmb_Spec.ListCount; i++)
					{
						if(_SpecName == cmb_Spec.GetItemText(i, 1).ToString() )
						{
							cmb_Spec.SelectedIndex = i;
							break;
						}

					} // end for i


				}



				
			}
//			else
//			{
//				cmb_SpecDiv.Enabled = false;
//				cmb_Spec.Enabled = false;
//
//				txt_SpecName.Enabled = false;
//				txt_SpecName.BackColor = Color.FromKnownColor(KnownColor.Control);
//			}



			
		}



		/// <summary>
		/// Show_Spec_Popup : Specification Master 폼을 팝업으로 표시
		/// </summary>
		private void Show_Spec_Popup()
		{
			try
			{
				FlexBase.MaterialBase.Form_BC_Spec pop_form = new FlexBase.MaterialBase.Form_BC_Spec();
				pop_form.ShowDialog();

				DataTable dt_ret;

				//Select_SBC_SPEC_COMMON(spec div, spec name, ues_yn)
				dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_SPEC_COMMON(_SpecDiv, " ", "Y");
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Spec, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 
				dt_ret.Dispose();

				cmb_Spec.SelectedValue = _SpecCd;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Spec_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// Apply : [Apply] 버튼 이벤트
		/// </summary>
		private void Apply()
		{
			// 숫자형만 입력되도록 처리
			//bool check_flag = ClassLib.ComFunction.Set_NumberTextBox(txt_YieldValue, 18, ""); 
			
			bool check_flag = ClassLib.ComFunction.Check_Decimal(txt_YieldValue.Text.Trim() ); 

			if(! check_flag) return; 

			// specification 필수 조건 처리
			if(cmb_Spec.SelectedIndex == -1)
			{
				check_flag = false;
			}

			if(! check_flag)
			{
				ClassLib.ComFunction.User_Message("Select Specification", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_Close_Apply = true;
			this.Close();
		}



		/// <summary>
		/// Set_Return_Parameter : 리턴 파라미터 설정
		/// </summary>
		private void Set_Return_Parameter()
		{
			try
			{

				if(_Close_Apply)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[] { txt_YieldValue.Text, 
																	   cmb_Spec.SelectedValue.ToString(), 
																	   cmb_Spec.Columns[1].Text };
				}
				else
				{
					ClassLib.ComVar.Parameter_PopUp = new string[] { "", "", ""};
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Return_Parameter", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

  


		private void cmb_SpecDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				if(cmb_SpecDiv.SelectedIndex == -1) return;

				DataTable dt_ret;
	
				//Select_SBC_SPEC_COMMON(spec div, spec name, ues_yn)

				string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
				string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
				string use_yn = "Y"; 


				dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_SPEC_COMMON(spec_div, spec_name, use_yn);
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Spec, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 
				dt_ret.Dispose();
	
				if(! _SpecCd.Equals("") )
				{
					cmb_Spec.SelectedValue = _SpecCd; 
				} 



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SpecDiv_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		
		private void txt_YieldValue_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;
  
				 Apply();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_SpecName_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txt_SpecName_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;
  
				Set_Spec_Combo();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_SpecName_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void Set_Spec_Combo()
		{

			DataTable dt_ret;
	
			string spec_div = ClassLib.ComFunction.Empty_Combo(cmb_SpecDiv, " ");
			string spec_name = ClassLib.ComFunction.Empty_TextBox(txt_SpecName, " ");
			string use_yn = "Y";


			//Select_SBC_SPEC_COMMON(spec div, spec name, ues_yn)
			dt_ret = FlexBase.MaterialBase.Pop_Item_List.Select_SBC_SPEC_COMMON(spec_div, spec_name, use_yn);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Spec, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Name); 
			dt_ret.Dispose();
	
			cmb_Spec.SelectedValue = txt_SpecName.Text.Trim(); 

		}



		private void btn_SearchSpec_Click(object sender, System.EventArgs e)
		{
			Show_Spec_Popup();
		}



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

		private void Pop_Yield_Value_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Set_Return_Parameter();
		}

		


		#endregion     

		#region DB Connect
 

		#endregion 

 

	}
}

