using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_Work_Info_List : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_jobcd;
		private C1.Win.C1List.C1Combo cmb_jobcd;
		private System.Windows.Forms.Label label1;
		public COM.FSP fgrid_Notice;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_search;
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ImageList img_Action;


		private COM.OraDB oraDB = null;
		private System.Windows.Forms.TextBox txt_event_id;
		private System.Windows.Forms.GroupBox groupBox1;
		private int _RowFixed;

		public Pop_Work_Info_List()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Work_Info_List));
			this.lbl_jobcd = new System.Windows.Forms.Label();
			this.cmb_jobcd = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_event_id = new System.Windows.Forms.TextBox();
			this.fgrid_Notice = new COM.FSP();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobcd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).BeginInit();
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
			// lbl_jobcd
			// 
			this.lbl_jobcd.ImageIndex = 0;
			this.lbl_jobcd.ImageList = this.img_Label;
			this.lbl_jobcd.Location = new System.Drawing.Point(5, 14);
			this.lbl_jobcd.Name = "lbl_jobcd";
			this.lbl_jobcd.Size = new System.Drawing.Size(100, 21);
			this.lbl_jobcd.TabIndex = 107;
			this.lbl_jobcd.Text = "Job Code";
			this.lbl_jobcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_jobcd
			// 
			this.cmb_jobcd.AddItemCols = 0;
			this.cmb_jobcd.AddItemSeparator = ';';
			this.cmb_jobcd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_jobcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_jobcd.Caption = "";
			this.cmb_jobcd.CaptionHeight = 17;
			this.cmb_jobcd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_jobcd.ColumnCaptionHeight = 18;
			this.cmb_jobcd.ColumnFooterHeight = 18;
			this.cmb_jobcd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_jobcd.ContentHeight = 17;
			this.cmb_jobcd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_jobcd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_jobcd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobcd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_jobcd.EditorHeight = 17;
			this.cmb_jobcd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_jobcd.GapHeight = 2;
			this.cmb_jobcd.ItemHeight = 15;
			this.cmb_jobcd.Location = new System.Drawing.Point(105, 14);
			this.cmb_jobcd.MatchEntryTimeout = ((long)(2000));
			this.cmb_jobcd.MaxDropDownItems = ((short)(5));
			this.cmb_jobcd.MaxLength = 32767;
			this.cmb_jobcd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_jobcd.Name = "cmb_jobcd";
			this.cmb_jobcd.PartialRightColumn = false;
			this.cmb_jobcd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_jobcd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_jobcd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_jobcd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_jobcd.Size = new System.Drawing.Size(185, 21);
			this.cmb_jobcd.TabIndex = 108;
			// 
			// label1
			// 
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(304, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 109;
			this.label1.Text = "Event ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_event_id
			// 
			this.txt_event_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_event_id.Location = new System.Drawing.Point(405, 14);
			this.txt_event_id.Name = "txt_event_id";
			this.txt_event_id.Size = new System.Drawing.Size(185, 21);
			this.txt_event_id.TabIndex = 110;
			this.txt_event_id.Text = "";
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
			this.fgrid_Notice.TabIndex = 111;
			this.fgrid_Notice.DoubleClick += new System.EventHandler(this.fgrid_Notice_Click);
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
			this.btn_save.Location = new System.Drawing.Point(610, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 115;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(529, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 114;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.ImageIndex = 4;
			this.btn_insert.ImageList = this.imgs_new_btn;
			this.btn_insert.Location = new System.Drawing.Point(448, 416);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(80, 23);
			this.btn_insert.TabIndex = 113;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.imgs_new_btn;
			this.btn_search.Location = new System.Drawing.Point(597, 13);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(80, 23);
			this.btn_search.TabIndex = 112;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_jobcd);
			this.groupBox1.Controls.Add(this.cmb_jobcd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_event_id);
			this.groupBox1.Controls.Add(this.btn_search);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 43);
			this.groupBox1.TabIndex = 116;
			this.groupBox1.TabStop = false;
			// 
			// Pop_Work_Info_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.fgrid_Notice);
			this.Name = "Pop_Work_Info_List";
			this.Load += new System.EventHandler(this.Pop_Work_Info_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Notice, 0);
			this.Controls.SetChildIndex(this.btn_insert, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_jobcd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Notice)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Work_Info_List_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.Text = "Event List";
			this.lbl_MainTitle.Text = "Event List";
			ClassLib.ComFunction.SetLangDic(this);
			oraDB = new COM.OraDB();


			DataTable dt = Show_JobCD_CD();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_jobcd, 0, 1, true, false);
			cmb_jobcd.SelectedIndex = 0;

			//그리드 설정
			fgrid_Notice.Set_Grid("SPS_WORKINFO_LIST","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Notice.Set_Action_Image(img_Action);
			//fgrid_Notice.ExtendLastCol = false;
			_RowFixed = fgrid_Notice.Rows.Fixed;
			Search();
		}

		private DataTable Show_JobCD_CD()
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_JOB_CD";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_SPS_WorkInfo_List()
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_WORKINFO_LIST";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name;

			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_JOB_CD";
			oraDB.Parameter_Name[2] = "ARG_DIVISION";
			oraDB.Parameter_Name[3] = "ARG_EVENT_ID";
			oraDB.Parameter_Name[4] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;

			string job_cd = cmb_jobcd.SelectedValue.ToString();

			if(cmb_jobcd.SelectedIndex == 0)
			{
				job_cd = "ALL";
			}

			string event_id = txt_event_id.Text;

			oraDB.Parameter_Values[1] = job_cd;
			oraDB.Parameter_Values[2] = (txt_event_id.Text.Trim().Length == 0) ? "EVENT_ID" : "NO_EVENT_ID";
			oraDB.Parameter_Values[3] = event_id.Trim();
			oraDB.Parameter_Values[4] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		public void Search()
		{
			fgrid_Notice.Rows.Count = _RowFixed;

			DataTable dt = Select_SPS_WorkInfo_List();
			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;


			for(int i=0; i<dt_row; i++)
			{
				fgrid_Notice.Rows.Add();
				for(int j=0; j<dt_col; j++)
				{
					if(j == (int)ClassLib.SPS_WORKINFO.IxDBUSE_YN || j == (int)ClassLib.SPS_WORKINFO.IxDBOPEN_YN)
					{
						fgrid_Notice[fgrid_Notice.Rows.Count-1, 1+j] = (dt.Rows[i].ItemArray[j].ToString() == "Y") ? "true" : "false";
					}
					else
					{
						fgrid_Notice[fgrid_Notice.Rows.Count-1, 1+j] = dt.Rows[i].ItemArray[j].ToString();
					}
				}
			}

			fgrid_Notice.AutoSizeCols();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			Pop_Work_Info workinfo = new Pop_Work_Info(this, true, "");
			workinfo.ShowDialog();
		}

		private void fgrid_Notice_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_Notice.Selection.r1;
			int sct_col = fgrid_Notice.Selection.c1;

			if(sct_row < _RowFixed) return;


			string event_id = fgrid_Notice[sct_row, (int)ClassLib.SPS_WORKINFO.IxGREVENT_ID].ToString();

			Pop_Work_Info workinfo = new Pop_Work_Info(this, false, event_id);
			workinfo.ShowDialog();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			fgrid_Notice.Delete_Row();
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				bool delete_ok = Delete_Event();

				if(delete_ok)
				{
					Search();
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete, this);
					return;
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}





		/// <summary>
		/// Delete_Event : 일괄 삭제
		/// </summary>
		private bool Delete_Event()
		{

			try
			{
 
				int col_ct = 14;
				 

				string Proc_Name = "PKG_SPS_HOME.SAVE_WORKINFO";

				oraDB.ReDim_Parameter(col_ct);
				oraDB.Process_Name = Proc_Name;

				oraDB.Parameter_Name[0] = "ARG_DIVISION";
				oraDB.Parameter_Name[1] = "ARG_FACTORY";
				oraDB.Parameter_Name[2] = "ARG_EVENT_ID";
				oraDB.Parameter_Name[3] = "ARG_EVENT_DESC";
				oraDB.Parameter_Name[4] = "ARG_TITLE";
				oraDB.Parameter_Name[5] = "ARG_CONTENTS";
				oraDB.Parameter_Name[6] = "ARG_REGIST_ID";
				oraDB.Parameter_Name[7] = "ARG_JOB_CD";
				oraDB.Parameter_Name[8] = "ARG_EMAIL_YN";
				oraDB.Parameter_Name[9] = "ARG_USE_YN";
				oraDB.Parameter_Name[10] = "ARG_OPEN_YN";
				oraDB.Parameter_Name[11] = "ARG_COMM_YN";
				oraDB.Parameter_Name[12] = "ARG_UPD_USER";
				oraDB.Parameter_Name[13] = "OUT_CURSOR"; 


				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[9] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[12] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[13] = (int)OracleType.Cursor;

  

				for(int i = fgrid_Notice.Rows.Fixed ; i < fgrid_Notice.Rows.Count; i++)
				{ 
					if(fgrid_Notice[i, 0] != null && fgrid_Notice[i, 0].ToString() == "D" )
					{ 	 
						oraDB.Parameter_Values[0]  = "D";
						oraDB.Parameter_Values[1]  = ClassLib.ComVar.This_Factory;
						oraDB.Parameter_Values[2]  = fgrid_Notice[i,  (int)ClassLib.SPS_WORKINFO.IxGREVENT_ID].ToString();
						oraDB.Parameter_Values[3]  = "";
						oraDB.Parameter_Values[4]  = "";
						oraDB.Parameter_Values[5]  = "";
						oraDB.Parameter_Values[6]  = "";
						oraDB.Parameter_Values[7]  = "";
						oraDB.Parameter_Values[8]  = "";
						oraDB.Parameter_Values[9]  = "";
						oraDB.Parameter_Values[10] = "";
						oraDB.Parameter_Values[11] = "";
						oraDB.Parameter_Values[12] = ClassLib.ComVar.This_User;
						oraDB.Parameter_Values[13] = ""; 


						oraDB.Add_Select_Parameter(true);
						DataSet DS_Ret = oraDB.Exe_Select_Procedure();
 


					}

				} // end for i 

			


//				oraDB.Add_Select_Parameter(true);
//				DataSet DS_Ret = oraDB.Exe_Select_Procedure();

				// return  bool.Parse(DS_Ret.Tables[Proc_Name].Rows[0].ItemArray[0].ToString());

				return true;
			
			}
			catch
			{
				return false;
			}



		}





		 
	}
}

