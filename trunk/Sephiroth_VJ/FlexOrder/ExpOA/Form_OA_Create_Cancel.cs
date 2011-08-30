using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;
using Lassalle.Flow; 

namespace FlexOrder.ExpOA
{
	public class Form_OA_Create_Cancel : COM.OrderWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정의
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_Confirm;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.TextBox txt_OA_Nu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_OBS_Id;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label lbl_PO_ID;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo c1Combo2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.GroupBox groupBox1;
		private Lassalle.Flow.AddFlow AddFlow;
		private System.Windows.Forms.Button btn_Cancel;
		private System.ComponentModel.IContainer components = null;

		public Form_OA_Create_Cancel()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_OA_Create_Cancel));
			this.btn_Close = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_Confirm = new System.Windows.Forms.TextBox();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.txt_OA_Nu = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_OBS_Id = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.lbl_PO_ID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.c1Combo2 = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AddFlow = new Lassalle.Flow.AddFlow();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
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
			this.lbl_MainTitle.Text = "Order Adjust Cancel";
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(360, 187);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(100, 25);
			this.btn_Close.TabIndex = 56;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RosyBrown;
			this.panel2.Controls.Add(this.txt_Confirm);
			this.panel2.Controls.Add(this.txt_Style_Cd);
			this.panel2.Controls.Add(this.lbl_STYLE);
			this.panel2.Controls.Add(this.txt_OA_Nu);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txt_OBS_Id);
			this.panel2.Controls.Add(this.txt_OBS_Type);
			this.panel2.Controls.Add(this.lbl_OBS_Type);
			this.panel2.Controls.Add(this.lbl_PO_ID);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.c1Combo2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Location = new System.Drawing.Point(2, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(462, 80);
			this.panel2.TabIndex = 58;
			// 
			// txt_Confirm
			// 
			this.txt_Confirm.BackColor = System.Drawing.Color.LightYellow;
			this.txt_Confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Confirm.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Confirm.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Confirm.Location = new System.Drawing.Point(433, 52);
			this.txt_Confirm.MaxLength = 100;
			this.txt_Confirm.Name = "txt_Confirm";
			this.txt_Confirm.ReadOnly = true;
			this.txt_Confirm.Size = new System.Drawing.Size(20, 20);
			this.txt_Confirm.TabIndex = 187;
			this.txt_Confirm.Text = "";
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.LightYellow;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Style_Cd.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Style_Cd.Location = new System.Drawing.Point(108, 52);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.ReadOnly = true;
			this.txt_Style_Cd.Size = new System.Drawing.Size(120, 20);
			this.txt_Style_Cd.TabIndex = 183;
			this.txt_Style_Cd.Text = "";
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(7, 52);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 180;
			this.lbl_STYLE.Text = "Style Code";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OA_Nu
			// 
			this.txt_OA_Nu.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OA_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OA_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OA_Nu.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_OA_Nu.Location = new System.Drawing.Point(333, 52);
			this.txt_OA_Nu.MaxLength = 100;
			this.txt_OA_Nu.Name = "txt_OA_Nu";
			this.txt_OA_Nu.ReadOnly = true;
			this.txt_OA_Nu.Size = new System.Drawing.Size(98, 20);
			this.txt_OA_Nu.TabIndex = 186;
			this.txt_OA_Nu.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8F);
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(232, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 185;
			this.label5.Text = "OA Nu";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_Id
			// 
			this.txt_OBS_Id.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OBS_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Id.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Id.Location = new System.Drawing.Point(333, 30);
			this.txt_OBS_Id.MaxLength = 100;
			this.txt_OBS_Id.Name = "txt_OBS_Id";
			this.txt_OBS_Id.ReadOnly = true;
			this.txt_OBS_Id.Size = new System.Drawing.Size(120, 20);
			this.txt_OBS_Id.TabIndex = 184;
			this.txt_OBS_Id.Text = "";
			// 
			// txt_OBS_Type
			// 
			this.txt_OBS_Type.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type.Location = new System.Drawing.Point(108, 30);
			this.txt_OBS_Type.MaxLength = 100;
			this.txt_OBS_Type.Name = "txt_OBS_Type";
			this.txt_OBS_Type.ReadOnly = true;
			this.txt_OBS_Type.Size = new System.Drawing.Size(120, 20);
			this.txt_OBS_Type.TabIndex = 182;
			this.txt_OBS_Type.Text = "";
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(8, 26);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(98, 27);
			this.lbl_OBS_Type.TabIndex = 175;
			this.lbl_OBS_Type.Text = "OBS type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PO_ID
			// 
			this.lbl_PO_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_PO_ID.ImageIndex = 1;
			this.lbl_PO_ID.ImageList = this.img_Label;
			this.lbl_PO_ID.Location = new System.Drawing.Point(232, 29);
			this.lbl_PO_ID.Name = "lbl_PO_ID";
			this.lbl_PO_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_ID.TabIndex = 177;
			this.lbl_PO_ID.Text = "OBS ID";
			this.lbl_PO_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(768, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 173;
			this.label3.Text = "Style Code";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Combo2
			// 
			this.c1Combo2.AddItemCols = 0;
			this.c1Combo2.AddItemSeparator = ';';
			this.c1Combo2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo2.Caption = "";
			this.c1Combo2.CaptionHeight = 17;
			this.c1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo2.ColumnCaptionHeight = 18;
			this.c1Combo2.ColumnFooterHeight = 18;
			this.c1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo2.ContentHeight = 17;
			this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo2.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 17;
			this.c1Combo2.Font = new System.Drawing.Font("Verdana", 8F);
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(868, 29);
			this.c1Combo2.MatchEntryTimeout = ((long)(2000));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.PartialRightColumn = false;
			this.c1Combo2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.Size = new System.Drawing.Size(124, 21);
			this.c1Combo2.TabIndex = 172;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(440, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(278, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Highlight;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 30);
			this.label4.TabIndex = 0;
			this.label4.Text = "      OA Balance.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(443, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 57);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.Color.Blue;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(372, 75);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(90, 14);
			this.pictureBox7.TabIndex = 8;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(32, 57);
			this.pictureBox8.TabIndex = 3;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.Color.Navy;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(32, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(414, 57);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 75);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(80, 14);
			this.pictureBox11.TabIndex = 6;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 75);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(374, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.AddFlow);
			this.groupBox1.Location = new System.Drawing.Point(1, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(463, 72);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			// 
			// AddFlow
			// 
			this.AddFlow.BackColor = System.Drawing.SystemColors.Window;
			this.AddFlow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AddFlow.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.AddFlow.Location = new System.Drawing.Point(3, 17);
			this.AddFlow.Name = "AddFlow";
			this.AddFlow.Size = new System.Drawing.Size(457, 52);
			this.AddFlow.TabIndex = 58;
			this.AddFlow.Click += new System.EventHandler(this.AddFlow_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(2, 187);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(100, 25);
			this.btn_Cancel.TabIndex = 60;
			this.btn_Cancel.Text = "OA Cancel";
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// Form_OA_Create_Cancel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(474, 224);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_Close);
			this.Name = "Form_OA_Create_Cancel";
			this.Load += new System.EventHandler(this.Form_OA_Create_Cancel_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 상용자 정의 
		string _Factory="";		
		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();

		#endregion 

		#region 공통메쏘드
		private void Init_Form()
		{
			try
			{
				_Factory           = ClassLib.ComVar.Parameter_PopUp[0];
				txt_OBS_Id.Text    = ClassLib.ComVar.Parameter_PopUp[1];
				txt_OBS_Type.Text  = ClassLib.ComVar.Parameter_PopUp[2];
				txt_Style_Cd.Text  = ClassLib.ComVar.Parameter_PopUp[3];
				txt_OA_Nu.Text     = ClassLib.ComVar.Parameter_PopUp[5];
				txt_Confirm.Text   = ClassLib.ComVar.Parameter_PopUp[4];


		    
				Drow_Job();


				AddFlow_Selected(true);
				AddFlow_Click(null,null);
				AddFlow_Selected(false);


			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(),  "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error );
				this.Close();
				
			}


		}


		private void AddFlow_Selected(bool arg_bool)
		{
			Lassalle.Flow.Node   node;

			foreach(Item item in AddFlow.Items)
			{


				if(item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;

					int index = node.Index;

					AddFlow.Items[index].Selected = arg_bool;

				}


			}



		}


		private void Drow_Job()
		{

			//Lassalle.Flow.Node NodeTitle      = new Lassalle.Flow.Node(arg_left,  arg_top, arg_width *3,  arg_height,vJobDesc);  vLeft*(Width*1) +(vGap*1)

			int vLeft = 5, vTop = 5 , vWidth = 70, vHeight = 20, vGap=16;

			Lassalle.Flow.Node PlanReceiveTitle       = new Lassalle.Flow.Node(vLeft,  vTop,  vWidth,  vHeight, "Plan Receive");
			Lassalle.Flow.Node OrderRequestTitle      = new Lassalle.Flow.Node(vLeft+(vWidth*1) +(vGap*1),  vTop, vWidth,  vHeight, "Order Request");
			Lassalle.Flow.Node OrderTitle             = new Lassalle.Flow.Node(vLeft+(vWidth*2) +(vGap*2),  vTop, vWidth,  vHeight, "Order" );
			Lassalle.Flow.Node OrderAdjustTiel        = new Lassalle.Flow.Node(vLeft+(vWidth*3) +(vGap*3),  vTop, vWidth,  vHeight, "Order Adjust");
		
			string vTag  = _Factory + txt_OA_Nu.Text;
			Set_Node_Property(PlanReceiveTitle,ClassLib.ComVar.ConsCFM_C,vTag);
			Set_Node_Property(OrderRequestTitle,ClassLib.ComVar.ConsCFM_C,vTag);
			Set_Node_Property(OrderTitle,ClassLib.ComVar.ConsCFM_C,vTag);
			Set_Node_Property(OrderAdjustTiel,ClassLib.ComVar.ConsCFM_C,vTag);	
			
			
			AddFlow.Nodes.Add(PlanReceiveTitle);
			AddFlow.Nodes.Add(OrderRequestTitle);
			AddFlow.Nodes.Add(OrderTitle);
			AddFlow.Nodes.Add(OrderAdjustTiel);		
	
			AddFlow.Enabled = false;


		

			

			
			
	

		}




		private void  Set_Node_Property( Lassalle.Flow.Node  arg_node, string  arg_type , string arg_tag )
		{

			AddFlow.LinkCreationMode  =  LinkCreationMode .AllNodeArea;

			switch(arg_type)
			{
				case "C":     //Ready
					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(128, 255, 128); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 		
					arg_node.XMoveable  = false;
					arg_node.YMoveable  = false;
					arg_node.YSizeable  = false;

					arg_node.Tag       = arg_tag;					
					break;

				case "R":  //Confirm
					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(223, 223, 223); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black;
					arg_node.XMoveable  = false;
					arg_node.YMoveable  = false;
					arg_node.YSizeable  = false; 
					arg_node.Tag       = arg_tag;
					break;
		       
			}



		}



		#endregion 
	
		#region 이벤트처리

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		
		private void AddFlow_Click(object sender, System.EventArgs e)
		{

			
			Lassalle.Flow.Node node;
			DataTable   vDt;
			string vStatus ="";


			vDt  = Select_Confirm_Status();

			foreach(Item item in AddFlow.Items)
			{

				

				if(item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;

					int index = node.Index;

					if (AddFlow.Items[index].Selected != true) continue;

					switch ( AddFlow.Nodes[index].Text ) 
					{

						case  "Plan Receive":
						{
							vStatus = (vDt.Rows[0].ItemArray[1] == null)?ClassLib.ComVar.ConsCFM_R: vDt.Rows[0].ItemArray[1].ToString();
							if  (vStatus  == ClassLib.ComVar.ConsCFM_C ) return;
							node.GradientColor     =Color.FromArgb(223, 223, 223); 
							node.Selected = false;
							break;

						}
						case  "Order Request":
						{
							vStatus = (vDt.Rows[0].ItemArray[1] == null)?ClassLib.ComVar.ConsCFM_R: vDt.Rows[0].ItemArray[1].ToString();
							if  (vStatus  == ClassLib.ComVar.ConsCFM_C ) return;
							node.GradientColor     =Color.FromArgb(223, 223, 223); 
							node.Selected = false;
							break;

						}

						case  "Order":
						{
							vStatus = (vDt.Rows[0].ItemArray[1] == null)?ClassLib.ComVar.ConsCFM_R: vDt.Rows[0].ItemArray[1].ToString();
							if  (vStatus  == ClassLib.ComVar.ConsCFM_C ) return;
							node.GradientColor     =Color.FromArgb(223, 223, 223);
							node.Selected = false;
							break;

						}

						case  "Order Adjust":
						{
							vStatus = (vDt.Rows[0].ItemArray[1] == null)?ClassLib.ComVar.ConsCFM_R: vDt.Rows[0].ItemArray[1].ToString();
							if  (vStatus  == ClassLib.ComVar.ConsCFM_C ) return;
							node.GradientColor     =Color.FromArgb(223, 223, 223); 
							node.Selected = false;
							break;

						}

					}
				}

			}
		}


		#endregion 

		#region DB 컨넥트

		private DataTable  Select_Confirm_Status()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_OA_PROCESS";
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OA_NU";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = _Factory;
			MyOraDB.Parameter_Values[1]  = txt_OA_Nu.Text;
			MyOraDB.Parameter_Values[2]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}



		private bool Save_Confirm_OA()
		{

			try
			{
				int vCnt  =5 ;

				MyOraDB.ReDim_Parameter(vCnt);
				MyOraDB.Process_Name = "PKG_SEM_OA_CREATE.CONFIRM_SEM_OBS_OA"; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";	      
				MyOraDB.Parameter_Name[1] = "ARG_OA_NU";  		 
				MyOraDB.Parameter_Name[2] = "ARG_OA_CFM";        
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";    
				MyOraDB.Parameter_Name[4] = "ARG_UPD_YMD";
  
 
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = txt_OA_Nu.Text;
				MyOraDB.Parameter_Values[2] = ClassLib.ComVar.ConsCFM_R;
				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;
				MyOraDB.Parameter_Values[4] =  System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  



				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Save_Confirm_OA()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;

			}


		}


		#endregion 



		private void Form_OA_Create_Cancel_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			
			try
			{
				DialogResult vDR  = ClassLib.ComFunction.User_Message("Do you want to cancel order adjust?", "Order Adjust Cancel", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (vDR !=DialogResult.Yes ) return;

				
			

				if (Save_Confirm_OA() != true)
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun , this);
					return;


				}

				txt_Confirm.Text =  ClassLib.ComVar.ConsCFM_R;
				btn_Cancel.Enabled = false;


					    
				Drow_Job();


				AddFlow_Selected(true);
				AddFlow_Click(null,null);
				AddFlow_Selected(false);

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun , this);



			}
			catch(Exception ex)
			{
				
				ClassLib.ComFunction.User_Message (ex.ToString(), "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);


			}
			finally
			{

				this.Cursor = Cursors.Default;

			}
		}


	}
}

