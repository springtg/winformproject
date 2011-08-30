using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using FlexTraining.Master; 

namespace FlexTraining.Form_Report
{
	public class Frm_Daily_Report : COM.TrainingWinForm.Pop_Small
	{
		private C1.Win.C1List.C1Combo cmb_Training;
		private System.Windows.Forms.Label lbl_Training;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo cmb_Group;
		private C1.Win.C1List.C1Combo cmb_Type;
		private C1.Win.C1List.C1Combo cmb_Wave;
		private System.Windows.Forms.DateTimePicker dpick_date_from;
		private System.Windows.Forms.DateTimePicker dpick_date_to;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chk_Date;
		private System.ComponentModel.IContainer components = null;

		public Frm_Daily_Report()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Frm_Daily_Report));
			this.cmb_Training = new C1.Win.C1List.C1Combo();
			this.lbl_Training = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_Group = new C1.Win.C1List.C1Combo();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_Type = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb_Wave = new C1.Win.C1List.C1Combo();
			this.dpick_date_from = new System.Windows.Forms.DateTimePicker();
			this.dpick_date_to = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.chk_Date = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Wave)).BeginInit();
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
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// cmb_Training
			// 
			this.cmb_Training.AddItemCols = 0;
			this.cmb_Training.AddItemSeparator = ';';
			this.cmb_Training.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Training.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Training.Caption = "";
			this.cmb_Training.CaptionHeight = 17;
			this.cmb_Training.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Training.ColumnCaptionHeight = 18;
			this.cmb_Training.ColumnFooterHeight = 18;
			this.cmb_Training.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Training.ContentHeight = 17;
			this.cmb_Training.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Training.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Training.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Training.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Training.EditorHeight = 17;
			this.cmb_Training.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Training.GapHeight = 2;
			this.cmb_Training.ItemHeight = 15;
			this.cmb_Training.Location = new System.Drawing.Point(112, 72);
			this.cmb_Training.MatchEntryTimeout = ((long)(2000));
			this.cmb_Training.MaxDropDownItems = ((short)(5));
			this.cmb_Training.MaxLength = 32767;
			this.cmb_Training.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Training.Name = "cmb_Training";
			this.cmb_Training.PartialRightColumn = false;
			this.cmb_Training.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Training.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Training.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Training.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Training.Size = new System.Drawing.Size(272, 21);
			this.cmb_Training.TabIndex = 155;
			this.cmb_Training.TextChanged += new System.EventHandler(this.cmb_Training_TextChanged);
			// 
			// lbl_Training
			// 
			this.lbl_Training.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Training.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Training.ImageIndex = 0;
			this.lbl_Training.ImageList = this.img_Label;
			this.lbl_Training.Location = new System.Drawing.Point(8, 72);
			this.lbl_Training.Name = "lbl_Training";
			this.lbl_Training.Size = new System.Drawing.Size(100, 21);
			this.lbl_Training.TabIndex = 154;
			this.lbl_Training.Text = "Programs";
			this.lbl_Training.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(8, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 156;
			this.label1.Text = "Objectives";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Group
			// 
			this.cmb_Group.AddItemCols = 0;
			this.cmb_Group.AddItemSeparator = ';';
			this.cmb_Group.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Group.Caption = "";
			this.cmb_Group.CaptionHeight = 17;
			this.cmb_Group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Group.ColumnCaptionHeight = 18;
			this.cmb_Group.ColumnFooterHeight = 18;
			this.cmb_Group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Group.ContentHeight = 17;
			this.cmb_Group.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Group.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Group.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Group.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Group.EditorHeight = 17;
			this.cmb_Group.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Group.GapHeight = 2;
			this.cmb_Group.ItemHeight = 15;
			this.cmb_Group.Location = new System.Drawing.Point(112, 96);
			this.cmb_Group.MatchEntryTimeout = ((long)(2000));
			this.cmb_Group.MaxDropDownItems = ((short)(5));
			this.cmb_Group.MaxLength = 32767;
			this.cmb_Group.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Group.Name = "cmb_Group";
			this.cmb_Group.PartialRightColumn = false;
			this.cmb_Group.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Group.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Group.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Group.Size = new System.Drawing.Size(272, 21);
			this.cmb_Group.TabIndex = 157;
			this.cmb_Group.TextChanged += new System.EventHandler(this.cmb_Group_TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImageIndex = 0;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(8, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 559;
			this.label2.Text = "Trained Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Type
			// 
			this.cmb_Type.AddItemCols = 0;
			this.cmb_Type.AddItemSeparator = ';';
			this.cmb_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Type.Caption = "";
			this.cmb_Type.CaptionHeight = 17;
			this.cmb_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Type.ColumnCaptionHeight = 18;
			this.cmb_Type.ColumnFooterHeight = 18;
			this.cmb_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Type.ContentHeight = 17;
			this.cmb_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Type.EditorHeight = 17;
			this.cmb_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Type.GapHeight = 2;
			this.cmb_Type.ItemHeight = 15;
			this.cmb_Type.Location = new System.Drawing.Point(112, 48);
			this.cmb_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_Type.MaxDropDownItems = ((short)(5));
			this.cmb_Type.MaxLength = 32767;
			this.cmb_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Type.Name = "cmb_Type";
			this.cmb_Type.PartialRightColumn = false;
			this.cmb_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Type.Size = new System.Drawing.Size(272, 21);
			this.cmb_Type.TabIndex = 561;
			this.cmb_Type.TextChanged += new System.EventHandler(this.cmb_Type_TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 560;
			this.label3.Text = "Report";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Apply.ImageIndex = 1;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(232, 171);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 567;
			this.btn_Apply.Text = "Print";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Button;
			this.label4.Location = new System.Drawing.Point(312, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 568;
			this.label4.Text = "Cancel";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label4_MouseUp);
			this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 569;
			this.label5.Text = "Wave";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Wave
			// 
			this.cmb_Wave.AddItemCols = 0;
			this.cmb_Wave.AddItemSeparator = ';';
			this.cmb_Wave.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Wave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Wave.Caption = "";
			this.cmb_Wave.CaptionHeight = 17;
			this.cmb_Wave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Wave.ColumnCaptionHeight = 18;
			this.cmb_Wave.ColumnFooterHeight = 18;
			this.cmb_Wave.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Wave.ContentHeight = 17;
			this.cmb_Wave.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Wave.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Wave.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Wave.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Wave.EditorHeight = 17;
			this.cmb_Wave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Wave.GapHeight = 2;
			this.cmb_Wave.ItemHeight = 15;
			this.cmb_Wave.Location = new System.Drawing.Point(112, 120);
			this.cmb_Wave.MatchEntryTimeout = ((long)(2000));
			this.cmb_Wave.MaxDropDownItems = ((short)(5));
			this.cmb_Wave.MaxLength = 32767;
			this.cmb_Wave.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Wave.Name = "cmb_Wave";
			this.cmb_Wave.PartialRightColumn = false;
			this.cmb_Wave.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Wave.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Wave.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Wave.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Wave.Size = new System.Drawing.Size(272, 21);
			this.cmb_Wave.TabIndex = 570;
			this.cmb_Wave.TextChanged += new System.EventHandler(this.cmb_Wave_TextChanged);
			// 
			// dpick_date_from
			// 
			this.dpick_date_from.CustomFormat = "";
			this.dpick_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_from.Location = new System.Drawing.Point(128, 144);
			this.dpick_date_from.Name = "dpick_date_from";
			this.dpick_date_from.Size = new System.Drawing.Size(90, 21);
			this.dpick_date_from.TabIndex = 571;
			// 
			// dpick_date_to
			// 
			this.dpick_date_to.CustomFormat = "";
			this.dpick_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_date_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_date_to.Location = new System.Drawing.Point(248, 144);
			this.dpick_date_to.Name = "dpick_date_to";
			this.dpick_date_to.Size = new System.Drawing.Size(91, 21);
			this.dpick_date_to.TabIndex = 572;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(232, 144);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(8, 16);
			this.label6.TabIndex = 573;
			this.label6.Text = "~";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_Date
			// 
			this.chk_Date.Location = new System.Drawing.Point(112, 147);
			this.chk_Date.Name = "chk_Date";
			this.chk_Date.Size = new System.Drawing.Size(16, 16);
			this.chk_Date.TabIndex = 574;
			this.chk_Date.CheckedChanged += new System.EventHandler(this.chk_Date_CheckedChanged);
			// 
			// Frm_Daily_Report
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 200);
			this.Controls.Add(this.chk_Date);
			this.Controls.Add(this.dpick_date_from);
			this.Controls.Add(this.dpick_date_to);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmb_Wave);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.cmb_Type);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmb_Group);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmb_Training);
			this.Controls.Add(this.lbl_Training);
			this.Name = "Frm_Daily_Report";
			this.Load += new System.EventHandler(this.Frm_Daily_Report_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_Training, 0);
			this.Controls.SetChildIndex(this.cmb_Training, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.cmb_Group, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.cmb_Type, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.cmb_Wave, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.dpick_date_to, 0);
			this.Controls.SetChildIndex(this.dpick_date_from, 0);
			this.Controls.SetChildIndex(this.chk_Date, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Training)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Wave)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Frm_Daily_Report_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{						

			// Form Setting
			lbl_MainTitle.Text = "Report";
			this.Text		   = "Report";

			dpick_date_from.Enabled = false;
			dpick_date_to.Enabled = false;
			
			DataTable vDt;
				
			// factory set
			vDt = Select_TrainingList("");
			COM.ComCtl.Set_ComboList(vDt, cmb_Training, 0, 1, true);
            
			vDt = Select_Group("SIM02");
			COM.ComCtl.Set_ComboList(vDt, cmb_Group , 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Group.SelectedValue    = ClassLib.ComVar.This_Factory;
			vDt = Select_Group("SIM05");
			COM.ComCtl.Set_ComboList(vDt,cmb_Type, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);

			cmb_Training .Splits[0].DisplayColumns["Code"].Width = 0;
			cmb_Group .Splits[0].DisplayColumns["Code"].Width = 0;
			cmb_Type.Splits[0].DisplayColumns["Code"].Width = 0;

		}

		private DataTable Select_Group(string com_cd)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB(); 
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SCM_CODE.SELECT_COM_FILTER_CODE_LIST1";

				MyOraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = process_name;
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_COM_CD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


				//03.DATA TYPE 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				//04.DATA 정의   
				MyOraDB.Parameter_Values[0] ="VJ";
				MyOraDB.Parameter_Values[1] = com_cd;
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
		}

		private DataTable Select_TrainingList(string arg_t_name)
		{	
			COM.OraDB MyOraDB = new COM.OraDB(); 
			 
			DataSet ds_ret;
			string process_name = "PKG_SIM_MASTER.SELECT_SIM_TRAINING_LIST";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_T_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";


			//03.DATA TYPE 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의   
			MyOraDB.Parameter_Values[0] = "VJ";
			MyOraDB.Parameter_Values[1] = arg_t_name;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private void cmb_Training_TextChanged(object sender, System.EventArgs e)
		{
			if(cmb_Training.SelectedIndex == -1) return;			
		}

		private void cmb_Group_TextChanged(object sender, System.EventArgs e)
		{
			this.Tbtn_SearchProcess();
		}

		private void Tbtn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure     = "PKG_SIM_TRAINING_MGNT.SELECT_SIM_TRAINING_MGNT";

				DataTable vDt = SELECT_SIM_TRAINING_MGNT(vProcedure);

				COM.ComCtl.Set_ComboList(vDt, cmb_Wave , 3, 5, true, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Wave.Splits[0].DisplayColumns["Code"].Width = 0;
			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_SIM_TRAINING_MGNT(string arg_procedure)
		{
			DataSet vDt;
			COM.OraDB MyOraDB = new COM.OraDB(); 

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_GRP_CODE";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "VJ";
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Group, "");
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void cmb_Wave_TextChanged(object sender, System.EventArgs e)
		{
			this.Get_Date();
		}

		private void Get_Date()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
                
				string vProcedure  = "PKG_SIM_REPORT.SELECT_DATE_TRAINING";

				DataTable vDt = SELECT_SIM_DATE_TRAINING(vProcedure);

				int iCount = vDt.Rows.Count;

				if (vDt.Rows.Count > 0) 
				{
					dpick_date_from.Value = Convert.ToDateTime(vDt.Rows[0].ItemArray[1]);
					dpick_date_to.Value = Convert.ToDateTime(vDt.Rows[iCount-1].ItemArray[1]);
				}

				//COM.ComCtl.Set_ComboList(vDt, cmb_Date ,0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);
				//COM.ComCtl.Set_ComboList(vDt, cmb_To_Date ,0, 1, true, COM.ComVar.ComboList_Visible.Code_Name);			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		public DataTable SELECT_SIM_DATE_TRAINING(string arg_procedure)
		{
			DataSet vDt;
			COM.OraDB MyOraDB = new COM.OraDB(); 

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE NAME
			MyOraDB.Process_Name = arg_procedure;

			//02.ARGURMENT NAME
			MyOraDB.Parameter_Name[ 0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[ 1]  = "ARG_T_CODE";
			MyOraDB.Parameter_Name[ 2]  = "ARG_SEQ";
			MyOraDB.Parameter_Name[ 3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[ 0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[ 3]  = (int)OracleType.Cursor;

			//04.DATA VALUE
			MyOraDB.Parameter_Values[ 0]   = "VJ";
			MyOraDB.Parameter_Values[ 1]   = ClassLib.ComFunction.Empty_Combo(cmb_Training, "");
			MyOraDB.Parameter_Values[ 2]   = ClassLib.ComFunction.Empty_Combo(cmb_Wave,"");
			MyOraDB.Parameter_Values[ 3]   = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{			
			this.Tbtn_PrintProcess();
		}

		private void Tbtn_PrintProcess()
		{
			try
			{
				PRINT_REPORT();
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void PRINT_REPORT()
		{
			string sDir, sPara, sReport_File, vStart_Date, vEnd_Date;

			sReport_File = "";

			sReport_File = cmb_Type.Columns[0].Text ;
			
//			switch (ClassLib.ComFunction.Empty_Combo(cmb_Type, "").ToString())
//			{
//				case "RE001":
//					sReport_File = "Form_Training_Management";
//					break;
//				case "RE002":
//					sReport_File = "Form_Trainee_List";
//					break;
//				case "RE003":
//					sReport_File = "Form_PGM_Schedule";
//					break;
//				case "RE004":
//					break;
//				case "RE005":
//					break;
//			}

			
			sDir = FlexTraining.ClassLib.ComFunction.Set_RD_Directory(sReport_File);
			vStart_Date = (chk_Date.Checked == true) ? dpick_date_from.Value.ToString("yyyyMMdd"): "";
			vEnd_Date   = (chk_Date.Checked == true) ? dpick_date_to.Value.ToString("yyyyMMdd") : "";

			sPara  = " /rp ";
			sPara += "'" + ClassLib.ComVar.This_Factory +	"' ";                      //Parm1: Factory
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Training, "") +	"' ";  //Parm2: Training Group
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Group, "") +	"' ";  //Parm3: Objectives
			sPara += "'" + ClassLib.ComFunction.Empty_Combo(cmb_Wave, "")  +	"' ";  //Parm4: Wave
			sPara += "'" +  vStart_Date +	"' ";                                      //Parm5: Start date
			sPara += "'" +  vEnd_Date   +	"' ";                                      //Parm6: End Date

			FlexTraining.Report.Form_RdViewer MyReport = new FlexTraining.Report.Form_RdViewer(sDir, sPara);

			MyReport.Text = cmb_Training.Columns[1].Text;
			MyReport.Show();
		}

		private void btn_Apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Apply.ImageIndex=1;
		}

		private void btn_Apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Apply.ImageIndex=0;
		}

		private void label4_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label4.ImageIndex=0;
		}

		private void label4_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			label4.ImageIndex=1;
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void cmb_Type_TextChanged(object sender, System.EventArgs e)
		{	
//			switch (ClassLib.ComFunction.Empty_Combo(cmb_Type, "").ToString())
//			{
//				case "RE005":
//					//cmb_To_Date.Enabled=true;
//					break;
//				case "RE004":
//					//cmb_To_Date.Enabled=true;
//					break;
//				default:
//					//cmb_To_Date.Enabled=false;
//					break;
//			}			

			cmb_Training.SelectedValue = "";
			cmb_Group.SelectedValue = "";
			cmb_Wave.SelectedValue = "";

		}

		private void chk_Date_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_Date.Checked == true)
			{
				dpick_date_from.Enabled = true;
				dpick_date_to.Enabled = true;
			}
			else
			{
				dpick_date_from.Enabled = false;
				dpick_date_to.Enabled = false;

			}
		}
	}
}

