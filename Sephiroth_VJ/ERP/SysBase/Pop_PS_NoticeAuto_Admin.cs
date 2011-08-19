using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace ERP.SysBase
{
	public class Pop_PS_NoticeAuto_Admin : COM.APSWinForm.Pop_Small
	{
		private System.Windows.Forms.ImageList img_MiniButton;
		public System.Windows.Forms.ImageList img_Action;
		private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
		private C1.Win.C1Command.C1Command tbtn_save;
		private C1.Win.C1Command.C1Command tbtn_search;
		private C1.Win.C1Command.C1Command tbtn_insert;
		private C1.Win.C1Command.C1Command tbtn_delete;
		public COM.FSP fgrid_event;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수

		private COM.OraDB oraDB = null;
		private int _RowFixed;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label btn_add_pgid;
		private C1.Win.C1List.C1Combo cmb_pg_id;
		private System.Windows.Forms.Label lbl_pg_id;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_search;
		private string User_id = "system";

		#endregion

		public Pop_PS_NoticeAuto_Admin()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeAuto_Admin));
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.fgrid_event = new COM.FSP();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
			this.tbtn_save = new C1.Win.C1Command.C1Command();
			this.tbtn_search = new C1.Win.C1Command.C1Command();
			this.tbtn_insert = new C1.Win.C1Command.C1Command();
			this.tbtn_delete = new C1.Win.C1Command.C1Command();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.btn_add_pgid = new System.Windows.Forms.Label();
			this.cmb_pg_id = new C1.Win.C1List.C1Combo();
			this.lbl_pg_id = new System.Windows.Forms.Label();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_event)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).BeginInit();
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
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// fgrid_event
			// 
			this.fgrid_event.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_event.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_event.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_event.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_event.Location = new System.Drawing.Point(8, 88);
			this.fgrid_event.Name = "fgrid_event";
			this.fgrid_event.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_event.Size = new System.Drawing.Size(376, 280);
			this.fgrid_event.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_event.TabIndex = 97;
			this.fgrid_event.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_event_AfterEdit);
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
			this.c1CommandHolder1.Commands.Add(this.tbtn_save);
			this.c1CommandHolder1.Commands.Add(this.tbtn_search);
			this.c1CommandHolder1.Commands.Add(this.tbtn_insert);
			this.c1CommandHolder1.Commands.Add(this.tbtn_delete);
			this.c1CommandHolder1.ImageList = this.img_MiniButton;
			this.c1CommandHolder1.ImageTransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			this.c1CommandHolder1.Owner = this;
			// 
			// lbl_factory
			// 
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 98;
			this.lbl_factory.Text = "공장";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(108, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 21);
			this.cmb_factory.TabIndex = 99;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// btn_add_pgid
			// 
			this.btn_add_pgid.BackColor = System.Drawing.SystemColors.Window;
			this.btn_add_pgid.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_add_pgid.ImageIndex = 6;
			this.btn_add_pgid.ImageList = this.img_MiniButton;
			this.btn_add_pgid.Location = new System.Drawing.Point(319, 62);
			this.btn_add_pgid.Name = "btn_add_pgid";
			this.btn_add_pgid.Size = new System.Drawing.Size(21, 21);
			this.btn_add_pgid.TabIndex = 232;
			this.btn_add_pgid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_add_pgid.Click += new System.EventHandler(this.btn_add_pgid_Click);
			// 
			// cmb_pg_id
			// 
			this.cmb_pg_id.AddItemCols = 0;
			this.cmb_pg_id.AddItemSeparator = ';';
			this.cmb_pg_id.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_pg_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_pg_id.Caption = "";
			this.cmb_pg_id.CaptionHeight = 17;
			this.cmb_pg_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_pg_id.ColumnCaptionHeight = 18;
			this.cmb_pg_id.ColumnFooterHeight = 18;
			this.cmb_pg_id.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_pg_id.ContentHeight = 17;
			this.cmb_pg_id.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_pg_id.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_pg_id.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pg_id.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_pg_id.EditorHeight = 17;
			this.cmb_pg_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_pg_id.GapHeight = 2;
			this.cmb_pg_id.ItemHeight = 15;
			this.cmb_pg_id.Location = new System.Drawing.Point(108, 62);
			this.cmb_pg_id.MatchEntryTimeout = ((long)(2000));
			this.cmb_pg_id.MaxDropDownItems = ((short)(5));
			this.cmb_pg_id.MaxLength = 32767;
			this.cmb_pg_id.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_pg_id.Name = "cmb_pg_id";
			this.cmb_pg_id.PartialRightColumn = false;
			this.cmb_pg_id.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_pg_id.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_pg_id.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_pg_id.Size = new System.Drawing.Size(210, 21);
			this.cmb_pg_id.TabIndex = 231;
			// 
			// lbl_pg_id
			// 
			this.lbl_pg_id.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_pg_id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_pg_id.ImageIndex = 0;
			this.lbl_pg_id.ImageList = this.img_Label;
			this.lbl_pg_id.Location = new System.Drawing.Point(8, 62);
			this.lbl_pg_id.Name = "lbl_pg_id";
			this.lbl_pg_id.Size = new System.Drawing.Size(100, 21);
			this.lbl_pg_id.TabIndex = 230;
			this.lbl_pg_id.Text = "적용 Program";
			this.lbl_pg_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(184, 376);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 235;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(96, 376);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 234;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.ImageIndex = 4;
			this.btn_insert.ImageList = this.imgs_new_btn;
			this.btn_insert.Location = new System.Drawing.Point(8, 376);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 23);
			this.btn_insert.TabIndex = 233;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.imgs_new_btn;
			this.btn_search.Location = new System.Drawing.Point(304, 376);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(80, 23);
			this.btn_search.TabIndex = 236;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// Pop_PS_NoticeAuto_Admin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 408);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.btn_add_pgid);
			this.Controls.Add(this.cmb_pg_id);
			this.Controls.Add(this.lbl_pg_id);
			this.Controls.Add(this.cmb_factory);
			this.Controls.Add(this.lbl_factory);
			this.Controls.Add(this.fgrid_event);
			this.Name = "Pop_PS_NoticeAuto_Admin";
			this.Load += new System.EventHandler(this.Pop_NoticeAuto_Admin_Load);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_event)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_pg_id)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 메소드

		private void Pop_NoticeAuto_Admin_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.Text = "Auto Message For Job";
			this.lbl_MainTitle.Text = "Event Setting";

			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();

			//Factory 설정
			DataTable dt = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;


			//PG_ID 설정
			dt = Select_PG_ID(cmb_factory.SelectedValue.ToString(), User_id);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_pg_id, 0, 0, true);
			cmb_pg_id.SelectedIndex = 0;

			//그리드 설정

			fgrid_event.Set_Grid_Comm("SPS_NOTICE_WORK","1",1,ClassLib.ComVar.This_Lang,ClassLib.ComVar.Grid_Type.ForModify ,false);
			fgrid_event.Set_Action_Image(img_Action);
			_RowFixed = fgrid_event.Rows.Fixed;
			
		}

		/// <summary>
		/// New_PG_ID : Pop_PS_NoticeAuto_PG에서 넘어온 값 설정 하기
		/// </summary>
		/// <param name="arg_selectitem">저장된 PG_ID</param>
		public void New_PG_ID(string arg_selectitem)
		{
			//PG_ID 설정
			DataTable dt = Select_PG_ID(cmb_factory.SelectedValue.ToString(), User_id);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_pg_id, 0, 0, true);
			cmb_pg_id.SelectedValue = arg_selectitem;

			Get_Grid_List(arg_selectitem);

			fgrid_event[fgrid_event.Rows.Count-1,0] = "U";
		}

		/// <summary>
		/// Get_Grid_List : 그리드에 데이터 넣기
		/// </summary>
		/// <param name="arg_pg_id">PG_ID</param>
		private void Get_Grid_List(string arg_pg_id)
		{
			fgrid_event.Rows.Count = _RowFixed;

			DataTable dt = Select_Notoce_work_List(cmb_factory.SelectedValue.ToString(), User_id, arg_pg_id);
			
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

				fgrid_event.AddItem(ArrayItem, _RowFixed,0);
			}

			fgrid_event.AutoSizeCols();
		}

		#endregion

		#region 이벤트

		private void btn_add_pgid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_add_pgid.ImageIndex = 7;
		}

		private void btn_add_pgid_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_add_pgid.ImageIndex = 6;
		}

		private void btn_add_pgid_Click(object sender, System.EventArgs e)
		{
			Pop_PS_NoticeAuto_PG ad = new Pop_PS_NoticeAuto_PG(this, cmb_factory.SelectedValue.ToString());
			ad.Show();
		}

		private void fgrid_event_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_event.Update_Row();
			fgrid_event.AutoSizeCols();
		}

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//PG_ID 설정
			DataTable dt = Select_PG_ID(cmb_factory.SelectedValue.ToString(), User_id);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_pg_id, 0, 0, true);
			cmb_pg_id.SelectedIndex = 0;
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			if(cmb_pg_id.SelectedIndex != 0)
				Get_Grid_List(cmb_pg_id.SelectedValue.ToString());
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if(cmb_pg_id.SelectedIndex != 0)
			{
				fgrid_event.Select(fgrid_event.Selection.r1, 0, fgrid_event.Selection.r1, fgrid_event.Cols.Count-1, false);

				int rowcount = fgrid_event.Rows.Count;
				int colcount = fgrid_event.Cols.Count;

				for(int i=_RowFixed; i<rowcount; i++)
				{
					if(fgrid_event[i,(int)ClassLib.TBSPS_NOTICE_WORK1.IxDIVISION].ToString() != "")
					{
						string[] ArrayItem = new string[colcount];
						for(int j=0; j<colcount; j++)
						{
							ArrayItem[j] = fgrid_event[i,j].ToString();
						}

						Save_Notice_Work(ArrayItem);
					}
				}


				Get_Grid_List(cmb_pg_id.SelectedValue.ToString());
			}
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			if(cmb_pg_id.SelectedIndex != 0)
			{
				int rownum = fgrid_event.Selection.r1;

				if(rownum >= _RowFixed)
					fgrid_event.Delete_Row(rownum);
			}
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			if(cmb_pg_id.SelectedIndex != 0)
			{
				fgrid_event.Add_Row(fgrid_event.Rows.Count-1);

				fgrid_event[fgrid_event.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_WORK1.IxFACTORY] = ClassLib.ComVar.This_Factory;
				fgrid_event[fgrid_event.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_WORK1.IxUSER_ID] = User_id;
				fgrid_event[fgrid_event.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_WORK1.IxPG_ID]   = cmb_pg_id.SelectedValue.ToString();
			}
		}

		#endregion

		#region DB접속

		/// <summary>
		/// Select_PG_ID : 적용될 프로그램 폼 가져오기
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자 아이디('admin' 으로 고정)</param>
		/// <returns>정상 : DataTable, 오류 : null</returns>
		private DataTable Select_PG_ID(string arg_factory, string arg_user_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_PG_ID";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		/// <summary>
		/// Select_Notoce_work_List : 조건에 맞는 이벤트 리스트
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_user_id">사용자 아이디('admin'으로 고정)</param>
		/// <param name="arg_pg_id">PG_ID</param>
		/// <returns></returns>
		private DataTable Select_Notoce_work_List(string arg_factory, string arg_user_id, string arg_pg_id)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_WORK_LIST";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_PG_ID";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_user_id;
			oraDB.Parameter_Values[2] = arg_pg_id;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Save_Notice_Work : DB저장
		/// </summary>
		/// <param name="arg_ArrayItem">저장될 데이터 배열</param>
		private void Save_Notice_Work(string[] arg_ArrayItem)
		{
			string Proc_Name = "PKG_SPS_HOME.SAVE_SPS_NOTICE_WORK1";

			oraDB.ReDim_Parameter(8);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_PG_ID";
			oraDB.Parameter_Name[4] = "ARG_SEQ";
			oraDB.Parameter_Name[5] = "ARG_WORK_EVENT";
			oraDB.Parameter_Name[6] = "ARG_WORK_DESC";
			oraDB.Parameter_Name[7] = "ARG_UPD_USER";

			for(int i=0; i<arg_ArrayItem.Length; i++)
			{
				oraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			oraDB.Parameter_Type[7] = (int)OracleType.VarChar;

			for(int i=0; i<arg_ArrayItem.Length; i++)
			{
				oraDB.Parameter_Values[i] = arg_ArrayItem[i];
			}

			oraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		#endregion		
	}
}

