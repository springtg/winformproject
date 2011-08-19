using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeAuto_User : COM.APSWinForm.Pop_Large
	{
		public COM.FSP fgrid_Notice;
		public System.Windows.Forms.ImageList img_Action;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_search;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_delete;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 변수
		private int _RowFixed;
		private System.Windows.Forms.TextBox txt_Search;
		private C1.Win.C1List.C1Combo cmb_Seach;
		private System.Windows.Forms.Label lbl_Search;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private COM.OraDB oraDB = null;
		private Form_Home frm = null;
		#endregion

		public Pop_PS_NoticeAuto_User()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Pop_PS_NoticeAuto_User(Form_Home arg_frm)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			frm = arg_frm;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeAuto_User));
			this.fgrid_Notice = new COM.FSP();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_delete = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.cmb_Seach = new C1.Win.C1List.C1Combo();
			this.lbl_Search = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).BeginInit();
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
			// fgrid_Notice
			// 
			this.fgrid_Notice.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Notice.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Notice.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Notice.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Notice.Location = new System.Drawing.Point(8, 64);
			this.fgrid_Notice.Name = "fgrid_Notice";
			this.fgrid_Notice.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Notice.Size = new System.Drawing.Size(680, 344);
			this.fgrid_Notice.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Notice.TabIndex = 97;
			this.fgrid_Notice.DoubleClick += new System.EventHandler(this.fgrid_Notice_DoubleClick);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_delete);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.LookAndFeel = C1.Win.C1Command.LookAndFeelEnum.Classic;
			this.c1CommandHolder1.Owner = this;
			// 
			// tbtn_search
			// 
			this.tbtn_search.Name = "tbtn_search";
			// 
			// tbtn_save
			// 
			this.tbtn_save.Name = "tbtn_save";
			// 
			// tbtn_delete
			// 
			this.tbtn_delete.Name = "tbtn_delete";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Location = new System.Drawing.Point(320, 40);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(368, 21);
			this.txt_Search.TabIndex = 101;
			this.txt_Search.Text = "";
			// 
			// cmb_Seach
			// 
			this.cmb_Seach.AddItemCols = 0;
			this.cmb_Seach.AddItemSeparator = ';';
			this.cmb_Seach.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Seach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Seach.Caption = "";
			this.cmb_Seach.CaptionHeight = 17;
			this.cmb_Seach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Seach.ColumnCaptionHeight = 18;
			this.cmb_Seach.ColumnFooterHeight = 18;
			this.cmb_Seach.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Seach.ContentHeight = 17;
			this.cmb_Seach.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Seach.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Seach.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Seach.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Seach.EditorHeight = 17;
			this.cmb_Seach.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Seach.GapHeight = 2;
			this.cmb_Seach.ItemHeight = 15;
			this.cmb_Seach.Location = new System.Drawing.Point(109, 40);
			this.cmb_Seach.MatchEntryTimeout = ((long)(2000));
			this.cmb_Seach.MaxDropDownItems = ((short)(5));
			this.cmb_Seach.MaxLength = 32767;
			this.cmb_Seach.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Seach.Name = "cmb_Seach";
			this.cmb_Seach.PartialRightColumn = false;
			this.cmb_Seach.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
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
			this.cmb_Seach.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Seach.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Seach.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Seach.Size = new System.Drawing.Size(210, 21);
			this.cmb_Seach.TabIndex = 100;
			// 
			// lbl_Search
			// 
			this.lbl_Search.ImageIndex = 0;
			this.lbl_Search.ImageList = this.img_Label;
			this.lbl_Search.Location = new System.Drawing.Point(8, 40);
			this.lbl_Search.Name = "lbl_Search";
			this.lbl_Search.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search.TabIndex = 99;
			this.lbl_Search.Text = " 검색 조건";
			this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(96, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 108;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(8, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 107;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.imgs_new_btn;
			this.btn_search.Location = new System.Drawing.Point(608, 416);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(80, 23);
			this.btn_search.TabIndex = 110;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// Pop_PS_NoticeAuto_User
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.txt_Search);
			this.Controls.Add(this.cmb_Seach);
			this.Controls.Add(this.lbl_Search);
			this.Controls.Add(this.fgrid_Notice);
			this.Name = "Pop_PS_NoticeAuto_User";
			this.Text = "Auto Work Message List";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PS_NoticeAuto_User_Closing);
			this.Load += new System.EventHandler(this.Form_PS_NoticeAuto_User_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Notice, 0);
			this.Controls.SetChildIndex(this.lbl_Search, 0);
			this.Controls.SetChildIndex(this.cmb_Seach, 0);
			this.Controls.SetChildIndex(this.txt_Search, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.btn_search, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_NoticeAuto_User_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{

			this.Text = "Auto Message for Job";
			this.lbl_MainTitle.Text = "Auto Message List";

			ClassLib.ComFunction.SetLangDic(this);
			
			oraDB = new COM.OraDB();


			//
			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, "PS12");
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			cmb_Seach.SelectedIndex = 0;

			//그리드 설정
			fgrid_Notice.Set_Grid_Comm("SPS_NOTICE_USER","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Notice.Set_Action_Image(img_Action);
			_RowFixed = fgrid_Notice.Rows.Fixed;
			Get_Grid_List(fgrid_Notice,"A", "U", "");
			fgrid_Notice.AutoSizeCols();
		}

		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_grid">입력될 그리드</param>
		/// <param name="arg_div">보냄/받음 구분자</param>
		private void Get_Grid_List(C1.Win.C1FlexGrid.C1FlexGrid arg_grid, string arg_div, string arg_division, string arg_value)
		{
			arg_grid.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice_User(arg_div, arg_division, arg_value);

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

				arg_grid.AddItem(ArrayItem,_RowFixed,0);
			}
		}


		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_grid">입력될 그리드</param>
		/// <param name="arg_div">보냄/받음 구분자</param>
		public void Get_Grid_List(string arg_div, string arg_division, string arg_value)
		{
			fgrid_Notice.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice_User(arg_div, arg_division, arg_value);

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

				fgrid_Notice.AddItem(ArrayItem,_RowFixed,0);
			}
		}


		/// <summary>
		/// Select_SPS_Notice_User : 개인 업무 메시지 가져오기
		/// </summary>
		/// <param name="arg_div">받은/보낸 메시지 구분</param>
		/// <returns>정상:DataTable  오류:null</returns>
		private DataTable Select_SPS_Notice_User(string arg_div, string arg_division, string arg_value)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_USER_SEARCH";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIV";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_DIVISION";
			oraDB.Parameter_Name[4] = "ARG_VALUE";
			oraDB.Parameter_Name[5] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_division;
			oraDB.Parameter_Values[4] = arg_value;
			oraDB.Parameter_Values[5] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}



		/// <summary>
		/// Return_TrueFalse : Y, N을 bool형 으로
		/// </summary>
		/// <param name="arg_yn">Y/N</param>
		/// <returns>Y:true, N:false</returns>
		private bool Return_TrueFalse(string arg_yn)
		{
			bool TrueFalse;

			if(arg_yn == "Y")
				TrueFalse = true;
			else
				TrueFalse = false;

			return TrueFalse;
		}

		/// <summary>
		/// ViweNotice : 자동 업무 알림 상세 보기
		/// </summary>
		/// <param name="arg_rownum">선택 ROW수</param>
		private void ViweNotice(int arg_rownum)
		{
			int rownum = arg_rownum;
			string arg_factory = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxFACTORY].ToString();
			string arg_seq     = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE_USER.IxSEQ].ToString();
          
			Pop_PS_NoticeUser_Receiver receiver = new Pop_PS_NoticeUser_Receiver(this, arg_factory, "A", arg_seq);
			receiver.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			receiver.Show();
		}


		#region 이벤트


		

		private void fgrid_Notice_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;
			ViweNotice(rownum);
		}


		private void btn_search_Click(object sender, System.EventArgs e)
		{
			string cmb_search;
			string txt_search;
			if(cmb_Seach.SelectedIndex == 0)
			{
				cmb_search = "U";
				txt_search = "";
			}
			else
			{
				cmb_search = cmb_Seach.SelectedValue.ToString();
				txt_search = txt_Search.Text;
			}
			Get_Grid_List(fgrid_Notice,"A", cmb_search, txt_search);
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			Delete_Grid_Item(fgrid_Notice);
			Get_Grid_List(fgrid_Notice, "A", "U", "");
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;
			if(rownum >= _RowFixed)
				fgrid_Notice.Delete_Row(rownum);
		}

		#endregion

		#region 메소드

		private void Delete_Grid_Item(C1.Win.C1FlexGrid.C1FlexGrid arg_fgrid)
		{
			int rowcount = arg_fgrid.Rows.Count;

			for(int i=_RowFixed; i<rowcount; i++)
			{
				if(arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxDIVISION].ToString() == "D")
				{
					string arg_factory = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxFACTORY].ToString();
					string arg_div     = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxDIV].ToString();
					string arg_seq	   = arg_fgrid[i,(int)ClassLib.TBSPS_NOTICE_USER.IxSEQ].ToString();

					Delete_SPS_Notice_User(arg_factory, arg_div,arg_seq);
				}
			}
		}

		#endregion

		#region DB접속

		private void Delete_SPS_Notice_User(string arg_factory, string arg_div, string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_SPS_NOTICE";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIV";
			oraDB.Parameter_Name[2] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		#endregion

		private void Form_PS_NoticeAuto_User_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(frm != null)
			{
				frm.Get_AutoMess();
			}
		}
	}
}

