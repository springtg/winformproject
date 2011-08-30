using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace FlexCDC.BaseInfo
{
	public class Pop_Common_Combo : COM.CDCWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TextBox txt_code;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private C1.Win.C1List.C1Combo cmb_value;
		private System.Windows.Forms.Label lbl_item;
		public System.Windows.Forms.PictureBox picb_MR;
		private System.ComponentModel.IContainer components = null;

		public Pop_Common_Combo()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Common_Combo));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_code = new System.Windows.Forms.TextBox();
			this.cmb_value = new C1.Win.C1List.C1Combo();
			this.lbl_item = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Left = 1;
			this.pnl_Search.DockPadding.Right = 1;
			this.pnl_Search.Location = new System.Drawing.Point(0, 32);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(392, 70);
			this.pnl_Search.TabIndex = 78;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_code);
			this.pnl_SearchImage.Controls.Add(this.cmb_value);
			this.pnl_SearchImage.Controls.Add(this.lbl_item);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(1, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(390, 70);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_code
			// 
			this.txt_code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_code.ImeMode = System.Windows.Forms.ImeMode.On;
			this.txt_code.Location = new System.Drawing.Point(90, 36);
			this.txt_code.MaxLength = 10;
			this.txt_code.Name = "txt_code";
			this.txt_code.TabIndex = 252;
			this.txt_code.Text = "";
			this.txt_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_code_KeyUp);
			// 
			// cmb_value
			// 
			this.cmb_value.AddItemCols = 0;
			this.cmb_value.AddItemSeparator = ';';
			this.cmb_value.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_value.AutoSize = false;
			this.cmb_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_value.Caption = "";
			this.cmb_value.CaptionHeight = 17;
			this.cmb_value.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_value.ColumnCaptionHeight = 18;
			this.cmb_value.ColumnFooterHeight = 18;
			this.cmb_value.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_value.ContentHeight = 17;
			this.cmb_value.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_value.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_value.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_value.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_value.EditorHeight = 17;
			this.cmb_value.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_value.GapHeight = 2;
			this.cmb_value.ItemHeight = 15;
			this.cmb_value.Location = new System.Drawing.Point(191, 36);
			this.cmb_value.MatchEntryTimeout = ((long)(2000));
			this.cmb_value.MaxDropDownItems = ((short)(5));
			this.cmb_value.MaxLength = 32767;
			this.cmb_value.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_value.Name = "cmb_value";
			this.cmb_value.PartialRightColumn = false;
			this.cmb_value.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_value.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_value.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_value.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_value.Size = new System.Drawing.Size(192, 21);
			this.cmb_value.TabIndex = 248;
			this.cmb_value.SelectedValueChanged += new System.EventHandler(this.cmb_value_SelectedValueChanged);
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(248)), ((System.Byte)(218)));
			this.lbl_item.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.Location = new System.Drawing.Point(8, 36);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(80, 21);
			this.lbl_item.TabIndex = 251;
			this.lbl_item.Text = "Vendor";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(374, 55);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 54);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(230, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 55);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 37);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(222, 30);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(373, 28);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 28);
			this.picb_MR.TabIndex = 253;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(374, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(166, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Vendor Name";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_apply
			// 
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_apply.ImageIndex = 1;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(3, 109);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 249;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_cancel.ImageIndex = 1;
			this.btn_cancel.ImageList = this.img_Button;
			this.btn_cancel.Location = new System.Drawing.Point(319, 108);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 250;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// Pop_Common_Combo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(392, 136);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.btn_cancel);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_Common_Combo";
			this.Load += new System.EventHandler(this.Pop_Common_Combo_Load);
			this.Closed += new System.EventHandler(this.Pop_Common_Combo_Closed);
			this.Controls.SetChildIndex(this.btn_cancel, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private string _title = null;
		private string _factory  ="";

		#endregion

		#region 공통메서드

		private void Init_Form()
		{

			this.Text          = COM.ComVar.Parameter_PopUp[0];
			lbl_MainTitle.Text =  COM.ComVar.Parameter_PopUp[0];
			lbl_SubTitle1.Text  = "      " +COM.ComVar.Parameter_PopUp[0];
			lbl_item.Text  = COM.ComVar.Parameter_PopUp[0];


			_title		  = COM.ComVar.Parameter_PopUp[0];
			_factory      = COM.ComVar.Parameter_PopUp[1];

			#region TextBox Setting
			txt_code.Focus();
			//txt_code.CharacterCasing = CharacterCasing.Upper;

			Txt_CodeKeyUpProcess();

			#endregion

		}

		private void Txt_CodeKeyUpProcess()
		{

			DataTable vDt = null;

			try
			{	
				if((txt_code.Text != null) || (txt_code.Text==""))
				{	
					
					if(_title.Equals(ClassLib.ComVar.ConsCDC_Vendor))
					{						
						vDt = ClassLib.ComFunction.Select_Cust_List(COM.ComVar.Parameter_PopUp[1], txt_code.Text);
						ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 100, 193);						
					}	

					if(_title.Equals(ClassLib.ComVar.ConsCDC_TransType))
					{						
						vDt = ClassLib.ComFunction.Select_TransPort(COM.ComVar.Parameter_PopUp[1], txt_code.Text);
						ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 0, 193);						
					}	

					if(_title.Equals(ClassLib.ComVar.ConsCDC_Season))
					{						
						vDt = ClassLib.ComFunction.Select_Season(COM.ComVar.Parameter_PopUp[1], txt_code.Text);
						ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 0, 193);						
					}	

					if(_title.Equals(ClassLib.ComVar.ConsCDC_User))
					{						
						vDt = ClassLib.ComFunction.Select_User(COM.ComVar.Parameter_PopUp[1], txt_code.Text);
						ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 0, 193);						
					}	


					if(_title.Equals(ClassLib.ComVar.ConsCDC_M_Vendor))
					{						
						vDt = ClassLib.ComFunction.Select_CDC_Cust_List(COM.ComVar.This_CDC_Factory, txt_code.Text);
						ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 100, 193);						
					}	



					
				}


				
					
			}
			catch 
			{
				
			}
			

		}
		
		private void Cmb_ValueSelectedValueChangedProcess()
		{

			try
			{
				txt_code.Text = cmb_value.SelectedValue.ToString();
			}
			catch 
			{
				
			}	
		
		}

		
		#endregion

		#region 이벤트 처리 

		private void btn_apply_Click(object sender, System.EventArgs e)
		{

			if(_title.Equals(ClassLib.ComVar.ConsCDC_Vendor))	
			{
				COM.ComVar.Parameter_PopUp		= new string[3];
				COM.ComVar.Parameter_PopUp[0]	= _factory;
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");	
				COM.ComVar.Parameter_PopUp[2]	= (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);			
			}	
			if(_title.Equals(ClassLib.ComVar.ConsCDC_Season))	
			{
				COM.ComVar.Parameter_PopUp		= new string[3];
				COM.ComVar.Parameter_PopUp[0]	= _factory;
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");				    //CODE
				COM.ComVar.Parameter_PopUp[2]	= (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);   //이름
				
			}	
			if (_title.Equals(ClassLib.ComVar.ConsCDC_TransType))	
			{
				COM.ComVar.Parameter_PopUp[0]	= _factory;
				COM.ComVar.This_Return  = cmb_value.Columns[0].Text + "-"+ cmb_value.Columns[1].Text;
			}	
			
			if(_title.Equals(ClassLib.ComVar.ConsCDC_User))	
			{
				COM.ComVar.Parameter_PopUp		= new string[3];
				COM.ComVar.Parameter_PopUp[0]	= _factory;
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");
				COM.ComVar.Parameter_PopUp[2]	=  (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);				
			}				
			if(_title.Equals(ClassLib.ComVar.ConsCDC_M_Vendor))	
			{
				COM.ComVar.Parameter_PopUp		= new string[3];
				COM.ComVar.Parameter_PopUp[0]	= _factory;
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");	
				COM.ComVar.Parameter_PopUp[2]	= (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);			
			}	
//			else
//			{
//				COM.ComVar.Parameter_PopUp		= new string[1];
//				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_value, "");				
//			}
			

			this.Dispose();
		
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = null;
			this.Dispose();
		}

		private void txt_code_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				Txt_CodeKeyUpProcess();		
		}

		private void cmb_value_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Cmb_ValueSelectedValueChangedProcess();
		}

		private void Pop_Common_Combo_Closed(object sender, System.EventArgs e)
		{
			if(cmb_value.SelectedIndex == -1)
				COM.ComVar.Parameter_PopUp = null;
			
		}

		#endregion

		private void Pop_Common_Combo_Load(object sender, System.EventArgs e)
		{		
			Init_Form();
		}

		
		

		

		

		

	}
}

