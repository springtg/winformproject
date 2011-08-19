using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeAdmin : COM.APSWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리

		public COM.FSP fgrid_Notice;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenu cMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1Command tbtn_search;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_write;
		private C1.Win.C1Command.C1Command tbtn_clear;
		private C1.Win.C1Command.C1Command c1Command1;
		public System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_modify;
		private System.Windows.Forms.TextBox txt_Search;
		private C1.Win.C1List.C1Combo cmb_Seach;
		private System.Windows.Forms.Label lbl_Search;
		private System.Windows.Forms.GroupBox groupBox1;


		public Pop_PS_NoticeAdmin()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_PS_NoticeAdmin(Form_Home arg_frm)
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeAdmin));
			this.fgrid_Notice = new COM.FSP();
			this.cMenu = new System.Windows.Forms.ContextMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_write = new C1.Win.C1Command.C1Command();
			this.tbtn_clear = new C1.Win.C1Command.C1Command();
			this.c1Command1 = new C1.Win.C1Command.C1Command();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_search = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_modify = new System.Windows.Forms.Label();
			this.txt_Search = new System.Windows.Forms.TextBox();
			this.cmb_Seach = new C1.Win.C1List.C1Combo();
			this.lbl_Search = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).BeginInit();
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
			// fgrid_Notice
			// 
			this.fgrid_Notice.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Notice.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Notice.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Notice.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Notice.Location = new System.Drawing.Point(5, 88);
			this.fgrid_Notice.Name = "fgrid_Notice";
			this.fgrid_Notice.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Notice.Size = new System.Drawing.Size(685, 320);
			this.fgrid_Notice.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Notice.TabIndex = 97;
			this.fgrid_Notice.DoubleClick += new System.EventHandler(this.fgrid_Notice_DoubleClick);
			this.fgrid_Notice.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Notice_AfterEdit);
			// 
			// cMenu
			// 
			this.cMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem4,
																				  this.menuItem5,
																				  this.menuItem2,
																				  this.menuItem3,
																				  this.menuItem6,
																				  this.menuItem1});
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "View Notice";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "Modify Notice";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "Delete Notice";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "-";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 5;
			this.menuItem1.Text = "Write Notice";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_write);
			this.c1CommandHolder1.Commands.Add(this.tbtn_clear);
			this.c1CommandHolder1.Commands.Add(this.c1Command1);
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
			// tbtn_write
			// 
			this.tbtn_write.Name = "tbtn_write";
			// 
			// tbtn_clear
			// 
			this.tbtn_clear.Name = "tbtn_clear";
			// 
			// c1Command1
			// 
			this.c1Command1.Name = "c1Command1";
			this.c1Command1.Text = "New Command";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
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
			this.btn_search.TabIndex = 101;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.ImageIndex = 4;
			this.btn_insert.ImageList = this.imgs_new_btn;
			this.btn_insert.Location = new System.Drawing.Point(367, 416);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 23);
			this.btn_insert.TabIndex = 102;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(529, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 103;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(610, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 104;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_modify
			// 
			this.btn_modify.ImageIndex = 8;
			this.btn_modify.ImageList = this.imgs_new_btn;
			this.btn_modify.Location = new System.Drawing.Point(448, 416);
			this.btn_modify.Name = "btn_modify";
			this.btn_modify.Size = new System.Drawing.Size(80, 23);
			this.btn_modify.TabIndex = 105;
			this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
			// 
			// txt_Search
			// 
			this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Search.Location = new System.Drawing.Point(319, 14);
			this.txt_Search.Name = "txt_Search";
			this.txt_Search.Size = new System.Drawing.Size(273, 21);
			this.txt_Search.TabIndex = 108;
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Seach.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Seach.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Seach.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Seach.Size = new System.Drawing.Size(210, 21);
			this.cmb_Seach.TabIndex = 107;
			// 
			// lbl_Search
			// 
			this.lbl_Search.ImageIndex = 0;
			this.lbl_Search.ImageList = this.img_Label;
			this.lbl_Search.Location = new System.Drawing.Point(7, 14);
			this.lbl_Search.Name = "lbl_Search";
			this.lbl_Search.Size = new System.Drawing.Size(100, 21);
			this.lbl_Search.TabIndex = 106;
			this.lbl_Search.Text = "Search Option";
			this.lbl_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Controls.Add(this.lbl_Search);
			this.groupBox1.Controls.Add(this.cmb_Seach);
			this.groupBox1.Controls.Add(this.txt_Search);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 43);
			this.groupBox1.TabIndex = 109;
			this.groupBox1.TabStop = false;
			// 
			// Pop_PS_NoticeAdmin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.fgrid_Notice);
			this.Controls.Add(this.btn_modify);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Name = "Pop_PS_NoticeAdmin";
			this.Text = "Notice";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PS_NoticeAdmin_Closing);
			this.Load += new System.EventHandler(this.Form_PS_NoticeAdmin_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_insert, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.btn_modify, 0);
			this.Controls.SetChildIndex(this.fgrid_Notice, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Seach)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion 
		
		#region 사용자 변수

		private int _RowFixed; 
		private COM.OraDB oraDB = null; 
		private Form_Home frm = null;


		#endregion


		private void Form_PS_NoticeAdmin_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{

			this.Text = "Sephiroth News";
			this.lbl_MainTitle.Text = "Notice List";
			ClassLib.ComFunction.SetLangDic(this);
			oraDB = new COM.OraDB();



//			if(ClassLib.ComVar.This_Admin_YN != "Y")
//			{
//				//btn_save.Visible = false;
//				btn_insert.Enabled = false;
//				//btn_delete.Visible = false;
//				//btn_modify.Visible = false;
//			}

			


			DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSearchHome);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			cmb_Seach.SelectedIndex = 0;

			//그리드 설정
			fgrid_Notice.Set_Grid("SPS_NOTICE","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Notice.Set_Action_Image(img_Action);
			_RowFixed = fgrid_Notice.Rows.Fixed;
			Get_Notice_List("U", "");
		}

		public void Get_Notice_List(string arg_div, string arg_value)
		{
			fgrid_Notice.Rows.Count = _RowFixed;

			DataTable dt = Select_SPS_Notice(arg_div, arg_value);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;
			string data  = null;

			COM.ComFunction comfunc = new COM.ComFunction();

			for(int i=0; i<rowcount; i++)
			{
				string[] ArrayItem = new string[colcount+1];

				ArrayItem[0] = "";

				for(int j=0; j<colcount; j++)
				{
					if(j == 4 || j == 5)
					{
						data = comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString());//DateType 변환
					}
					else if(j == 6)
					{
						data = Return_TrueFalse(dt.Rows[i].ItemArray[j].ToString()).ToString(); //Show_YN
					}
					else
					{
						data = dt.Rows[i].ItemArray[j].ToString();
					}


					ArrayItem[j+1] = data;



				}

				fgrid_Notice.AddItem(ArrayItem, _RowFixed, 0);


			}

			string yyyy = DateTime.Now.Year.ToString();
			string MM   = DateTime.Now.Month.ToString();
			string dd   = DateTime.Now.Day.ToString();

			if(MM.Length == 1)
				MM = "0" + MM;

			if(dd.Length == 1)
				dd = "0" + dd;

			string nowdate = yyyy + MM + dd;

//			for(int i=_RowFixed; i<fgrid_Notice.Rows.Count; i++)
//			{
//				if(fgrid_Notice[i,3].ToString() == ClassLib.ComVar.This_User)
//					fgrid_Notice.Rows[i].StyleNew.BackColor = Color.FromArgb(181, 230, 202);
//			
//				else if(fgrid_Notice[i,7].ToString() == "False")
//					fgrid_Notice.Rows[i].StyleNew.BackColor = Color.FromArgb(220, 220, 220);
//
//				else if(int.Parse(comfunc.ConvertDate2DbType(fgrid_Notice[i,6].ToString())) < int.Parse(nowdate))
//					fgrid_Notice.Rows[i].StyleNew.BackColor = Color.FromArgb(220, 220, 220);
//			}


			fgrid_Notice.AutoSizeCols();
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
		/// ViweNotice : 공지 사항 상세 보기
		/// </summary>
		/// <param name="arg_rownum">선택 ROW수</param>
		private void ViweNotice(int arg_rownum)
		{
			int rownum = arg_rownum;
			string arg_factory = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxFACTORY].ToString();
			string arg_seq     = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
			Pop_PS_NoticeView psNoticeView = new Pop_PS_NoticeView(arg_factory, arg_seq);
			//psNoticeView.MdiParent = ClassLib.ComVar.arg_form;
			//ClassLib.ComVar.MenuClick_Flag = true;
			psNoticeView.ShowDialog();
		}


		/// <summary>
		/// Delete_Grid_Item : 그리드 저장
		/// </summary>
		private void Delete_Grid_Item()
		{
			int rowcount =fgrid_Notice.Rows.Count;

			for(int i=_RowFixed; i<rowcount; i++)
			{
				
				if(fgrid_Notice[i,(int)ClassLib.TBSPS_NOTICE_INGWORK.IxDIVISION].ToString() == "D")
				{
					string arg_factory = fgrid_Notice[i,(int)ClassLib.TBSPS_NOTICE.IxFACTORY].ToString();
					string arg_seq = fgrid_Notice[i,(int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
					Delete_Notice(arg_factory, arg_seq);
				}
			}
		}


		#region 이벤트


		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;

			string arg_factory = fgrid_Notice[rownum, 1].ToString();
			string arg_seq	   = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
			string arg_user_id = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxUSER_ID].ToString();

			if(ClassLib.ComVar.This_User == arg_user_id)
			{
				Pop_PS_NoticeModify psNoticeModify = new Pop_PS_NoticeModify(this, arg_factory, arg_seq );
				psNoticeModify.Show();
			}
			else
			{
				MessageBox.Show("수정 할 권한 이 없습니다.");
			}

		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;
			int rownum_end = fgrid_Notice.Selection.r2+1;

			for(int i=rownum; i<rownum_end; i++)
			{
				string arg_factory = fgrid_Notice[i, (int)ClassLib.TBSPS_NOTICE.IxFACTORY].ToString();
				string arg_seq     = fgrid_Notice[i, (int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
				string arg_user_id = fgrid_Notice[i, (int)ClassLib.TBSPS_NOTICE.IxUSER_ID].ToString();

				if(ClassLib.ComVar.This_Admin_YN == "Y" || arg_user_id == ClassLib.ComVar.This_User)
				{
					fgrid_Notice[i, (int)ClassLib.TBSPS_NOTICE.IxDIVISION] = "D";
				}
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeWrite psNoticeWrite = new Pop_PS_NoticeWrite(this);
			psNoticeWrite.Show();
		}

		private void fgrid_Notice_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;

			if(rownum < _RowFixed) return;

			ViweNotice(rownum);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;
			ViweNotice(rownum);
		}

		private void fgrid_Notice_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Notice.Update_Row();
			fgrid_Notice.AutoSizeCols();
		}

		#endregion

		#region DB 접속



		/// <summary>
		/// Select_SPS_Notice : 공지사항 리스트 가져오기
		/// </summary>
		/// <param name="arg_div"></param>
		/// <param name="arg_value"></param>
		/// <returns>정상:DATETABLE 오류:NULL</returns>
		private DataTable Select_SPS_Notice(string arg_div, string arg_value)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_ADMIN";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_DIVISION";
			oraDB.Parameter_Name[2] = "ARG_VALUE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_div;
			oraDB.Parameter_Values[2] = arg_value;
			oraDB.Parameter_Values[3] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		///  Delete_Notic : 공지사항 삭제
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_seq">SEQ</param>
		private void Delete_Notice(string arg_factory, string arg_seq)
		{

			string Proc_Name = "PKG_SPS_HOME.Delete_SPS_NOTICE";

		
			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		#endregion

		private void Form_PS_NoticeAdmin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if(frm != null)
				{
					frm.Get_Notice();
				}
			}
			catch
			{
			}
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			Delete_Grid_Item();

			cmb_Seach.SelectedIndex = 0;
			txt_Search.Text = "";
			Get_Notice_List("U", "");
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			menuItem3_Click(null, null);
		}

		private void btn_modify_Click(object sender, System.EventArgs e)
		{
			int rownum = fgrid_Notice.Selection.r1;

			if(rownum < _RowFixed) return;
			
			
			string arg_factory = fgrid_Notice[rownum, 1].ToString();
			string arg_seq	   = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxSEQ].ToString();
			string arg_user_id = fgrid_Notice[rownum, (int)ClassLib.TBSPS_NOTICE.IxUSER_ID].ToString();

			if(ClassLib.ComVar.This_Admin_YN == "Y" || arg_user_id == ClassLib.ComVar.This_User )
			{
				Pop_PS_NoticeModify psNoticeModify = new Pop_PS_NoticeModify(this, arg_factory, arg_seq );
				psNoticeModify.Show();
			}
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeWrite psNoticeWrite = new Pop_PS_NoticeWrite(this);
			psNoticeWrite.ShowDialog();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			if(cmb_Seach.SelectedIndex == -1) return;

			if(cmb_Seach.SelectedIndex == 0)
			{
				Get_Notice_List("U", "");
			}
			else// if(cmb_Seach.SelectedIndex == 2 || cmb_Seach.SelectedIndex == 3)
 			{
				string div = cmb_Seach.SelectedValue.ToString();
				string values = txt_Search.Text.Trim();
				Get_Notice_List(div, values);
			}
		}

		

		

		

		

		

		

		
	}
}

