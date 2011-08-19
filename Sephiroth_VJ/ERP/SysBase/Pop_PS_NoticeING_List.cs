using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace ERP.SysBase
{
	public class Pop_PS_NoticeING_List : COM.APSWinForm.Pop_Large
	{
		public COM.FSP fgrid_ingwork;
		public System.Windows.Forms.ImageList img_Action;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수
		private int _RowFixed;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_search;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_delete;
		private C1.Win.C1Command.C1Command tbtn_write;
		
		private COM.OraDB oraDB = null;
		private Form_Home frm = null;
		private System.Windows.Forms.TextBox txt_Search;
		private C1.Win.C1List.C1Combo cmb_Seach;
		private System.Windows.Forms.Label lbl_Search;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.GroupBox groupBox1;
		private bool home_load = false;
		#endregion

		public Pop_PS_NoticeING_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		public Pop_PS_NoticeING_List(Form_Home arg_frm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeING_List));
			this.fgrid_ingwork = new COM.FSP();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_delete = new C1.Win.C1Command.C1Command();
			this.tbtn_write = new C1.Win.C1Command.C1Command();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.cmb_Seach = new C1.Win.C1List.C1Combo();
			this.lbl_Search = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_search = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			// fgrid_ingwork
			// 
			this.fgrid_ingwork.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ingwork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_ingwork.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ingwork.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ingwork.Location = new System.Drawing.Point(5, 88);
			this.fgrid_ingwork.Name = "fgrid_ingwork";
			this.fgrid_ingwork.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_ingwork.Size = new System.Drawing.Size(685, 320);
			this.fgrid_ingwork.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ingwork.TabIndex = 100;
			this.fgrid_ingwork.DoubleClick += new System.EventHandler(this.fgrid_ingwork_DoubleClick);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_delete);
			this.c1CommandHolder1.Commands.Add(this.tbtn_write);
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
			// tbtn_write
			// 
			this.tbtn_write.ImageIndex = 12;
			this.tbtn_write.Name = "tbtn_write";
			this.tbtn_write.Text = "Write";
			this.tbtn_write.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_write_Click);
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Location = new System.Drawing.Point(319, 14);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(273, 21);
			this.txt_Search.TabIndex = 103;
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
			this.cmb_Seach.Location = new System.Drawing.Point(108, 14);
			this.cmb_Seach.MatchEntryTimeout = ((long)(2000));
			this.cmb_Seach.MaxDropDownItems = ((short)(5));
			this.cmb_Seach.MaxLength = 32767;
			this.cmb_Seach.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Seach.Name = "cmb_Seach";
			this.cmb_Seach.PartialRightColumn = false;
			this.cmb_Seach.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Seach.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Seach.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Seach.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Seach.Size = new System.Drawing.Size(210, 21);
			this.cmb_Seach.TabIndex = 102;
			// 
			// lbl_Search
			// 
			this.lbl_Search.ImageIndex = 0;
			this.lbl_Search.ImageList = this.img_Label;
			this.lbl_Search.Location = new System.Drawing.Point(7, 14);
			this.lbl_Search.Name = "lbl_Search";
			this.lbl_Search.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search.TabIndex = 101;
			this.lbl_Search.Text = "Search Option";
			this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.imgs_new_btn;
			this.btn_search.Location = new System.Drawing.Point(597, 12);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(80, 23);
			this.btn_search.TabIndex = 104;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(610, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 107;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(529, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 106;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.ImageIndex = 4;
			this.btn_insert.ImageList = this.imgs_new_btn;
			this.btn_insert.Location = new System.Drawing.Point(448, 416);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 23);
			this.btn_insert.TabIndex = 105;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Controls.Add(this.txt_Search);
			this.groupBox1.Controls.Add(this.lbl_Search);
			this.groupBox1.Controls.Add(this.cmb_Seach);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 43);
			this.groupBox1.TabIndex = 110;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeING_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.fgrid_ingwork);
			this.Name = "Pop_PS_NoticeING_List";
			this.Text = "Work List";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PS_NoticeING_List_Closing);
			this.Load += new System.EventHandler(this.Form_PC_NoticeING_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_ingwork, 0);
			this.Controls.SetChildIndex(this.btn_insert, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PC_NoticeING_List_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		public void init_Form()
		{

			this.Text = "Job Message List";
			this.lbl_MainTitle.Text = "Job Message List";
			ClassLib.ComFunction.SetLangDic(this);
			
			oraDB = new COM.OraDB();


			if(ClassLib.ComVar.This_Admin_YN != "Y")
			{

				btn_insert.Visible = false;
				btn_save.Visible = false;
				btn_delete.Visible = false;
			}


			
			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, "PS12");
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			cmb_Seach.SelectedIndex = 0;

			//그리드 설정
			fgrid_ingwork.Set_Grid_Comm("SPS_NOTICE_INGWORK","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, true);
			fgrid_ingwork.Set_Action_Image(img_Action);
			_RowFixed = fgrid_ingwork.Rows.Fixed;
			Get_Grid_List("U", "");
			fgrid_ingwork.AutoSizeCols();
		}


		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_division">검색 구분자</param>
		/// <param name="arg_value">검색 값</param>
		private void Get_Grid_List(string arg_division, string arg_value)
		{
			fgrid_ingwork.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice_IngWork(arg_division, arg_value);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];
				ArrayItem[0] = "";
				for(int j=0; j<colcount; j++)
				{
					if(j == 1)
					{
						ArrayItem[j+1] = Set_Type(dt.Rows[i].ItemArray[j].ToString());
					}
					else if(j == 4)
					{
						ArrayItem[j+1] = Get_JobCD_Name(dt.Rows[i].ItemArray[j].ToString());
					}
					else
					{
						ArrayItem[j+1] = dt.Rows[i].ItemArray[j].ToString();
					}
				}

				fgrid_ingwork.AddItem(ArrayItem,fgrid_ingwork.Rows.Count,0);
			}
		}



		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_division">검색 구분자</param>
		/// <param name="arg_value">검색 값</param>
		public void Get_Grid_List_Ref(string arg_division, string arg_value, bool arg_home_load)
		{

			home_load = arg_home_load;
			fgrid_ingwork.Rows.Count = _RowFixed;
			DataTable dt = Select_SPS_Notice_IngWork(arg_division, arg_value);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];
				ArrayItem[0] = "";
				for(int j=0; j<colcount; j++)
				{
					if(j == 1)
					{
						ArrayItem[j+1] = Set_Type(dt.Rows[i].ItemArray[j].ToString());
					}
					else if(j == 4)
					{
						ArrayItem[j+1] = Get_JobCD_Name(dt.Rows[i].ItemArray[j].ToString());
					}
					else
					{
						ArrayItem[j+1] = dt.Rows[i].ItemArray[j].ToString();
					}
				}

				fgrid_ingwork.AddItem(ArrayItem,fgrid_ingwork.Rows.Count,0);
			}


			fgrid_ingwork.AutoSizeCols();
		}

		private string Set_Type(string arg_AE)
		{
			if(arg_AE == "A")
				return "Group";
			else
				return "Unit";
		}

		/// <summary>
		/// Delete_Grid_Item : 그리드 저장
		/// </summary>
		private void Delete_Grid_Item()
		{
			int rowcount =fgrid_ingwork.Rows.Count;

			for(int i=_RowFixed; i<rowcount; i++)
			{
				string arg_seq = fgrid_ingwork[i,(int)ClassLib.TBSPS_NOTICE_INGWORK.IxSEQ].ToString();
				
				if(fgrid_ingwork[i,(int)ClassLib.TBSPS_NOTICE_INGWORK.IxDIVISION].ToString() == "D")
				{
					
					Delete_SPS_Notice_INGWork(arg_seq);
				}
			}
		}

		#region 이벤트

		private void fgrid_ingwork_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_ingwork.Selection.r1;

			string arg_factory = fgrid_ingwork[rownum, (int)ClassLib.TBSPS_NOTICE_INGWORK.IxFACTORY].ToString();
			string arg_seq	   = fgrid_ingwork[rownum, (int)ClassLib.TBSPS_NOTICE_INGWORK.IxSEQ].ToString();
	
			SysBase.Pop_PS_NoticeING_View view = new Pop_PS_NoticeING_View(arg_factory, arg_seq);
			view.Show();
		
		}

		#endregion

		#region DB접속


		/// <summary>
		/// Select_SPS_Notice_IngWork : 진행중인 업무 메시지 리스트 가져오기
		/// </summary>
		/// <param name="arg_division">검색 구분자</param>
		/// <param name="arg_value">검색 값</param>
		/// <returns>정상DataTable, 오류:null</returns>
		private DataTable Select_SPS_Notice_IngWork(string arg_division, string arg_value)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_NOTICE_INGWORK";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_RUSER_ID";
			oraDB.Parameter_Name[3] = "ARG_VALUE";
			oraDB.Parameter_Name[4] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_value;
			oraDB.Parameter_Values[4] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}


		private void Delete_SPS_Notice_INGWork(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_SPS_NOTICE_INGWORK";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}


		/// <summary>
		/// Get_JobCD_Name : 업무 코드로 업무 이름 가져오기
		/// </summary>
		/// <param name="arg_com_value1">업무코드</param>
		/// <returns>정상:업무이름 , 오류:null</returns>
		private string Get_JobCD_Name(string arg_com_value1)
		{
			string Proc_Name = "PKG_SPS_HOME.GET_JOBCD_NAME";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM_CD";
			oraDB.Parameter_Name[2] = "ARG_COM_VALUE1";
			oraDB.Parameter_Name[3] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "CM01";
			oraDB.Parameter_Values[2] = arg_com_value1;
			oraDB.Parameter_Values[3] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[3].ToString();
		}

		#endregion

		private void tbtn_write_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Pop_PS_NoticeING_Write wriet = new Pop_PS_NoticeING_Write(this);
			wriet.MdiParent = ClassLib.ComVar.arg_form;
			ClassLib.ComVar.MenuClick_Flag = true;
			wriet.Show();
		}

		private void Form_PS_NoticeING_List_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if(frm != null)
				{
					
					frm.Get_ing();

					if(home_load)
					{
						frm.Get_Notice();
					}
				}
			}
			catch
			{
			}
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			string arg_value = txt_Search.Text;

			if(cmb_Seach.SelectedIndex == 0)
				Get_Grid_List("U", "");
			else if(cmb_Seach.SelectedValue.ToString() == "T")
				Get_Grid_List("T", arg_value);
			else if(cmb_Seach.SelectedValue.ToString() == "C")
				Get_Grid_List("C", arg_value);
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeING_Write wriet = new Pop_PS_NoticeING_Write(this);
			wriet.ShowDialog();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_ingwork.Selection.r1;
			string type = fgrid_ingwork[rownum, (int)ClassLib.TBSPS_NOTICE_INGWORK.IxDiV].ToString();
			string user = fgrid_ingwork[rownum, (int)ClassLib.TBSPS_NOTICE_INGWORK.IxSUSER_ID].ToString();

			if(rownum >= _RowFixed)
				fgrid_ingwork.Delete_Row(rownum);
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			Delete_Grid_Item();

			cmb_Seach.SelectedIndex = 0;
			txt_Search.Text = "";
			Get_Grid_List("U", "");
		}


		
	}
}

