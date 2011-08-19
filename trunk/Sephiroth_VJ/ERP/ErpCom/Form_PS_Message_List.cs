using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.ErpCom
{
	public class Form_PS_Message_List : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Semlpe;
		public C1.Win.C1List.C1Combo cmb_search;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Label lbl_search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public COM.FSP fgrid_msg;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수
		private int _RowFixed;
		private COM.OraDB oraDB = null;
		#endregion

		public Form_PS_Message_List()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PS_Message_List));
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.cmb_search = new C1.Win.C1List.C1Combo();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.lbl_search = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.fgrid_msg = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_search)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_msg)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.cmb_search);
			this.pnl_Semlpe.Controls.Add(this.txt_search);
			this.pnl_Semlpe.Controls.Add(this.lbl_search);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.DockPadding.All = 8;
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(0, 64);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Semlpe.TabIndex = 36;
			// 
			// cmb_search
			// 
			this.cmb_search.AddItemCols = 0;
			this.cmb_search.AddItemSeparator = ';';
			this.cmb_search.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_search.Caption = "";
			this.cmb_search.CaptionHeight = 17;
			this.cmb_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_search.ColumnCaptionHeight = 18;
			this.cmb_search.ColumnFooterHeight = 18;
			this.cmb_search.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_search.ContentHeight = 17;
			this.cmb_search.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_search.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_search.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_search.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_search.EditorHeight = 17;
			this.cmb_search.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_search.GapHeight = 2;
			this.cmb_search.ItemHeight = 15;
			this.cmb_search.Location = new System.Drawing.Point(119, 36);
			this.cmb_search.MatchEntryTimeout = ((long)(2000));
			this.cmb_search.MaxDropDownItems = ((short)(5));
			this.cmb_search.MaxLength = 32767;
			this.cmb_search.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_search.Name = "cmb_search";
			this.cmb_search.PartialRightColumn = false;
			this.cmb_search.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_search.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_search.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_search.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_search.Size = new System.Drawing.Size(200, 21);
			this.cmb_search.TabIndex = 85;
			// 
			// txt_search
			// 
			this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search.Location = new System.Drawing.Point(320, 36);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(210, 21);
			this.txt_search.TabIndex = 72;
			this.txt_search.Text = "";
			// 
			// lbl_search
			// 
			this.lbl_search.ImageIndex = 0;
			this.lbl_search.ImageList = this.img_Label;
			this.lbl_search.Location = new System.Drawing.Point(18, 36);
			this.lbl_search.Name = "lbl_search";
			this.lbl_search.Size = new System.Drawing.Size(100, 21);
			this.lbl_search.TabIndex = 70;
			this.lbl_search.Text = "검색조건";
			this.lbl_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 56);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 16);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
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
			this.lbl_SubTitle1.Text = "      Message Box List";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 40);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 38);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 36);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 16);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 16);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// fgrid_msg
			// 
			this.fgrid_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_msg.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_msg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_msg.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_msg.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_msg.Location = new System.Drawing.Point(8, 136);
			this.fgrid_msg.Name = "fgrid_msg";
			this.fgrid_msg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_msg.Size = new System.Drawing.Size(1000, 504);
			this.fgrid_msg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_msg.TabIndex = 101;
			this.fgrid_msg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_msg_AfterEdit);
			// 
			// Form_PS_Message_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_msg);
			this.Controls.Add(this.pnl_Semlpe);
			this.Name = "Form_PS_Message_List";
			this.Text = "Message Box List";
			this.Load += new System.EventHandler(this.Form_PC_Message_List_Load);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			this.Controls.SetChildIndex(this.fgrid_msg, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_search)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_msg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PC_Message_List_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{

			this.Text = "Message Box List";
			this.lbl_MainTitle.Text = "Message Box List";
			ClassLib.ComFunction.SetLangDic(this);



			#region 버튼 권한

			try
			{
                //COM.OraDB btn_control = new COM.OraDB();
                //DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
                //tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
                //tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
                //tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
                //btn_control = null;
			}
			catch
			{
			}

			#endregion


			tbtn_Insert.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false;

			oraDB = new COM.OraDB();

			//검색 조건 설정
			cmb_list_mgs_button(cmb_search);
			cmb_search.SelectedIndex = 0;

			//그리드 설정
			fgrid_msg.Set_Grid_Comm("SPC_MESSAGE","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, true);
			fgrid_msg.Set_Action_Image(img_Action);
			_RowFixed = fgrid_msg.Rows.Fixed;
			Get_Grid_List("U", "");
			fgrid_msg.AutoSizeCols();
		}

		private void cmb_list_mgs_button(C1.Win.C1List.C1Combo arg_cmb)
		{
			DataTable temp_datatable= new DataTable("Combo List"); 
			DataRow newrow; 
			temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
			temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "U";
			newrow["Name"] = "ALL";
			temp_datatable.Rows.Add(newrow);


			newrow = temp_datatable.NewRow();
			newrow["Code"] = "C";
			newrow["Name"] = "CODE";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "MK";
			newrow["Name"] = "MESSAGE_KO";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "ME";
			newrow["Name"] = "MESSAGE_EN";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "B";
			newrow["Name"] = "BUTTON TYPE";
			temp_datatable.Rows.Add(newrow);


			newrow = temp_datatable.NewRow();
			newrow["Code"] = "I";
			newrow["Name"] = "ICON TYPE";
			temp_datatable.Rows.Add(newrow);

			newrow = temp_datatable.NewRow();
			newrow["Code"] = "US";
			newrow["Name"] = "UPD USER";
			temp_datatable.Rows.Add(newrow);



			arg_cmb.DataSource = null; 
			arg_cmb.DataSource = temp_datatable;
			
			arg_cmb.ValueMember = "Code";
			arg_cmb.DisplayMember = "Name"; 

			arg_cmb.SelectedIndex = -1;
			arg_cmb.MaxDropDownItems = 10;
			arg_cmb.Splits[0].DisplayColumns["Code"].Width = 50;
			arg_cmb.Splits[0].DisplayColumns["Name"].Width = 150;
			arg_cmb.ExtendRightColumn = true; 
		}

		public void Get_Grid_List(string arg_division, string arg_value)
		{
			fgrid_msg.Rows.Count = _RowFixed;

			DataTable dt = Select_SPC_Message(arg_division, arg_value);
			
			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];
				ArrayItem[0] = "";

				for(int j=0; j<colcount; j++)
				{
					ArrayItem[j+1] = dt.Rows[i].ItemArray[j].ToString();
				}

				fgrid_msg.AddItem(ArrayItem, fgrid_msg.Rows.Count, 0);
			}
		}


		#region 이벤트
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_search.SelectedIndex = 0;
			txt_search.Text = "";
			fgrid_msg.Rows.Count = _RowFixed;
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string type = cmb_search.SelectedValue.ToString();
			string values = txt_search.Text;

			if(values.Length == 0)
				values = "";

			Get_Grid_List(type,values);
		}
		
		private void fgrid_msg_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_msg.Update_Row();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_msg.Delete_Row();
		}
		
		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Form_PS_Message_Regist regist = new Form_PS_Message_Regist(this);
			regist.Show();
			//Get_Grid_List("U", "");
		}
		
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_msg.Select(fgrid_msg.Selection.r1, 0, fgrid_msg.Selection.r1, fgrid_msg.Cols.Count - 1, false);
			
			int rowcount = fgrid_msg.Rows.Count;
			int colcount = fgrid_msg.Cols.Count;

			for(int i=_RowFixed; i<rowcount; i++)
			{
				if(fgrid_msg[i,0].ToString() != "")
				{
					string[] ArrayItem =new string[colcount-1];
					
					for(int j=0; j<colcount-1; j++)
					{
						ArrayItem[j] = fgrid_msg[i,j].ToString();
					}
					
					Save_SPC_Message(ArrayItem);
				}
			}

			Get_Grid_List("U", "");
		}


		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_msg.Add_Row(fgrid_msg.Selection.r1); 
		}
		#endregion


		#region DB접속

		/// <summary>
		/// Select_SPC_Message : 저장된 메시지를 가져온다.
		/// </summary>
		/// <param name="arg_division">검색 구분</param>
		/// <param name="arg_value">검색 값</param>
		/// <returns>정상:DataTable, 오류:null</returns>
		private DataTable Select_SPC_Message(string arg_division, string arg_value)
		{
			string Proc_Name = "PKG_SPC_MESSAGE.SELECT_SPC_MESSAGE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_VALUE";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = arg_value;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}


		private void Save_SPC_Message(string[] arg_arrayitem)
		{
			string Proc_Name = "PKG_SPC_MESSAGE.SAVE_SPC_MESSAGE";

			oraDB.ReDim_Parameter(arg_arrayitem.Length);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_MSG_CODE";
			oraDB.Parameter_Name[2] = "ARG_MSG_K_CAPTION";
			oraDB.Parameter_Name[3] = "ARG_MSG_K_STRING";
			oraDB.Parameter_Name[4] = "ARG_MSG_E_CAPTION";
			oraDB.Parameter_Name[5] = "ARG_MSG_E_STRING";
			oraDB.Parameter_Name[6] = "ARG_MSG_BUTTON";
			oraDB.Parameter_Name[7] = "ARG_MSG_ICON";
			oraDB.Parameter_Name[8] = "ARG_UPD_USER";

			for(int i=0; i<arg_arrayitem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}

			for(int i=0; i<arg_arrayitem.Length-1; i++)
			{
				oraDB.Parameter_Values[i] = arg_arrayitem[i];
			}

			oraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();

		}
		#endregion
	}
}

