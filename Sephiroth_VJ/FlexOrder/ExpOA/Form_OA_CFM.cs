using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;

namespace FlexOrder.ExpOA
{
	public class Form_OA_CFM : COM.OrderWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		public COM.FSP fsp_Req;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1List.C1Combo c1Combo1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gb_OA;
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
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_STYLE;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label lbl_PO_ID;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.TextBox txt_OBS_Id;
		public COM.FSP fsp_OA_Rel;
		private System.Windows.Forms.Label lbl_CFM;
		private System.Windows.Forms.TextBox txt_OA_Nu;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_CFM;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox12;


		public Form_OA_CFM()
		{

			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_OA_CFM));
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fsp_Req = new COM.FSP();
			this.label1 = new System.Windows.Forms.Label();
			this.c1Combo1 = new C1.Win.C1List.C1Combo();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_CFM = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_OA_Nu = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_OBS_Id = new System.Windows.Forms.TextBox();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.lbl_STYLE = new System.Windows.Forms.Label();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.lbl_PO_ID = new System.Windows.Forms.Label();
			this.gb_OA = new System.Windows.Forms.GroupBox();
			this.fsp_OA_Rel = new COM.FSP();
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
			this.lbl_CFM = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsp_Req)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			this.panel2.SuspendLayout();
			this.gb_OA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsp_OA_Rel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
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
			this.lbl_MainTitle.Text = "OA Confirm";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RosyBrown;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.c1Combo1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox9);
			this.panel1.Controls.Add(this.pictureBox13);
			this.panel1.Controls.Add(this.pictureBox14);
			this.panel1.Controls.Add(this.pictureBox15);
			this.panel1.Controls.Add(this.pictureBox16);
			this.panel1.Location = new System.Drawing.Point(8, 296);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(688, 200);
			this.panel1.TabIndex = 49;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.fsp_Req);
			this.groupBox1.Location = new System.Drawing.Point(8, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(672, 178);
			this.groupBox1.TabIndex = 175;
			this.groupBox1.TabStop = false;
			// 
			// fsp_Req
			// 
			this.fsp_Req.AutoResize = false;
			this.fsp_Req.BackColor = System.Drawing.Color.White;
			this.fsp_Req.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fsp_Req.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp_Req.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fsp_Req.ForeColor = System.Drawing.Color.Black;
			this.fsp_Req.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fsp_Req.Location = new System.Drawing.Point(8, 14);
			this.fsp_Req.Name = "fsp_Req";
			this.fsp_Req.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fsp_Req.Size = new System.Drawing.Size(656, 155);
			this.fsp_Req.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp_Req.TabIndex = 57;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(768, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 173;
			this.label1.Text = "Style Code";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemCols = 0;
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo1.Caption = "";
			this.c1Combo1.CaptionHeight = 17;
			this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo1.ColumnCaptionHeight = 18;
			this.c1Combo1.ColumnFooterHeight = 18;
			this.c1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo1.ContentHeight = 17;
			this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo1.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 17;
			this.c1Combo1.Font = new System.Drawing.Font("Verdana", 8F);
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(868, 29);
			this.c1Combo1.MatchEntryTimeout = ((long)(2000));
			this.c1Combo1.MaxDropDownItems = ((short)(5));
			this.c1Combo1.MaxLength = 32767;
			this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo1.Name = "c1Combo1";
			this.c1Combo1.PartialRightColumn = false;
			this.c1Combo1.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.Size = new System.Drawing.Size(124, 21);
			this.c1Combo1.TabIndex = 172;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(666, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(22, 32);
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(168, -1);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(504, 32);
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Highlight;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "      Request info By Style";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(669, 32);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(19, 168);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.Blue;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(598, 186);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(90, 14);
			this.pictureBox9.TabIndex = 8;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 24);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 168);
			this.pictureBox13.TabIndex = 3;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox14.BackColor = System.Drawing.Color.Navy;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(32, 24);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(640, 168);
			this.pictureBox14.TabIndex = 4;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 186);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(80, 14);
			this.pictureBox15.TabIndex = 6;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Blue;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(72, 186);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(600, 14);
			this.pictureBox16.TabIndex = 9;
			this.pictureBox16.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RosyBrown;
			this.panel2.Controls.Add(this.txt_CFM);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.txt_OA_Nu);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txt_OBS_Id);
			this.panel2.Controls.Add(this.txt_Style_Cd);
			this.panel2.Controls.Add(this.txt_OBS_Type);
			this.panel2.Controls.Add(this.lbl_STYLE);
			this.panel2.Controls.Add(this.lbl_OBS_Type);
			this.panel2.Controls.Add(this.lbl_PO_ID);
			this.panel2.Controls.Add(this.gb_OA);
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
			this.panel2.Location = new System.Drawing.Point(5, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(691, 248);
			this.panel2.TabIndex = 50;
			// 
			// txt_CFM
			// 
			this.txt_CFM.BackColor = System.Drawing.Color.LightYellow;
			this.txt_CFM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CFM.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_CFM.ForeColor = System.Drawing.Color.Red;
			this.txt_CFM.Location = new System.Drawing.Point(333, 52);
			this.txt_CFM.MaxLength = 100;
			this.txt_CFM.Name = "txt_CFM";
			this.txt_CFM.ReadOnly = true;
			this.txt_CFM.Size = new System.Drawing.Size(120, 20);
			this.txt_CFM.TabIndex = 188;
			this.txt_CFM.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 0;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(231, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 187;
			this.label7.Text = "OA Confirm";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OA_Nu
			// 
			this.txt_OA_Nu.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OA_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OA_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OA_Nu.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_OA_Nu.Location = new System.Drawing.Point(107, 52);
			this.txt_OA_Nu.MaxLength = 100;
			this.txt_OA_Nu.Name = "txt_OA_Nu";
			this.txt_OA_Nu.ReadOnly = true;
			this.txt_OA_Nu.Size = new System.Drawing.Size(120, 20);
			this.txt_OA_Nu.TabIndex = 186;
			this.txt_OA_Nu.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8F);
			this.label5.ImageIndex = 0;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 52);
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
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.LightYellow;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Style_Cd.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txt_Style_Cd.Location = new System.Drawing.Point(562, 30);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.ReadOnly = true;
			this.txt_Style_Cd.Size = new System.Drawing.Size(120, 20);
			this.txt_Style_Cd.TabIndex = 183;
			this.txt_Style_Cd.Text = "";
			// 
			// txt_OBS_Type
			// 
			this.txt_OBS_Type.BackColor = System.Drawing.Color.LightYellow;
			this.txt_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type.Location = new System.Drawing.Point(107, 30);
			this.txt_OBS_Type.MaxLength = 100;
			this.txt_OBS_Type.Name = "txt_OBS_Type";
			this.txt_OBS_Type.ReadOnly = true;
			this.txt_OBS_Type.Size = new System.Drawing.Size(120, 20);
			this.txt_OBS_Type.TabIndex = 182;
			this.txt_OBS_Type.Text = "";
			// 
			// lbl_STYLE
			// 
			this.lbl_STYLE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_STYLE.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_STYLE.ImageIndex = 0;
			this.lbl_STYLE.ImageList = this.img_Label;
			this.lbl_STYLE.Location = new System.Drawing.Point(462, 30);
			this.lbl_STYLE.Name = "lbl_STYLE";
			this.lbl_STYLE.Size = new System.Drawing.Size(100, 21);
			this.lbl_STYLE.TabIndex = 180;
			this.lbl_STYLE.Text = "Style Code";
			this.lbl_STYLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.lbl_OBS_Type.Text = "OBS_TYPE";
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
			// gb_OA
			// 
			this.gb_OA.BackColor = System.Drawing.SystemColors.Window;
			this.gb_OA.Controls.Add(this.fsp_OA_Rel);
			this.gb_OA.Location = new System.Drawing.Point(8, 72);
			this.gb_OA.Name = "gb_OA";
			this.gb_OA.Size = new System.Drawing.Size(675, 175);
			this.gb_OA.TabIndex = 174;
			this.gb_OA.TabStop = false;
			// 
			// fsp_OA_Rel
			// 
			this.fsp_OA_Rel.AutoResize = false;
			this.fsp_OA_Rel.BackColor = System.Drawing.Color.White;
			this.fsp_OA_Rel.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fsp_OA_Rel.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fsp_OA_Rel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fsp_OA_Rel.ForeColor = System.Drawing.Color.Black;
			this.fsp_OA_Rel.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fsp_OA_Rel.Location = new System.Drawing.Point(8, 12);
			this.fsp_OA_Rel.Name = "fsp_OA_Rel";
			this.fsp_OA_Rel.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fsp_OA_Rel.Size = new System.Drawing.Size(656, 155);
			this.fsp_OA_Rel.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fsp_OA_Rel.TabIndex = 57;
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
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
			this.pictureBox1.Location = new System.Drawing.Point(669, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(507, 32);
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
			this.pictureBox5.Location = new System.Drawing.Point(672, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 225);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.Color.Blue;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(601, 243);
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
			this.pictureBox8.Size = new System.Drawing.Size(32, 225);
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
			this.pictureBox10.Size = new System.Drawing.Size(643, 225);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 243);
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
			this.pictureBox12.Location = new System.Drawing.Point(72, 243);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(603, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// lbl_CFM
			// 
			this.lbl_CFM.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_CFM.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_CFM.ImageIndex = 2;
			this.lbl_CFM.ImageList = this.img_Label;
			this.lbl_CFM.Location = new System.Drawing.Point(112, 502);
			this.lbl_CFM.Name = "lbl_CFM";
			this.lbl_CFM.Size = new System.Drawing.Size(100, 21);
			this.lbl_CFM.TabIndex = 178;
			this.lbl_CFM.Text = "Confirm";
			this.lbl_CFM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_CFM.Click += new System.EventHandler(this.lbl_CFM_Click);
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label16.Font = new System.Drawing.Font("Verdana", 8F);
			this.label16.ImageIndex = 2;
			this.label16.ImageList = this.img_Label;
			this.label16.Location = new System.Drawing.Point(8, 502);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 21);
			this.label16.TabIndex = 177;
			this.label16.Text = "Cancel";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Verdana", 8F);
			this.label6.ImageIndex = 2;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(587, 502);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 179;
			this.label6.Text = "Close";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form_OA_CFM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(706, 525);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lbl_CFM);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.DockPadding.All = 5;
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_OA_CFM";
			this.Load += new System.EventHandler(this.Form_OA_CFM_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.label16, 0);
			this.Controls.SetChildIndex(this.lbl_CFM, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fsp_Req)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.gb_OA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fsp_OA_Rel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
		int _Rowfixed  = 2;

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB(); 

		#endregion

		#region 멤버 메서드 
		private void Init_Form()
		{ 
		//	DataTable dt_list;

			//Setting  Title
			this.Text = "OA Confirm";
			this.lbl_MainTitle.Text = "OA Confirm"; 
			ClassLib.ComFunction.SetLangDic(this);

			//Setting Grid(TBSEM_OA07/TBSEM_OA08)
			fsp_OA_Rel.Set_Grid( "SEM_OA", "7", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fsp_OA_Rel.Font = new Font("Verdana",8);

			fsp_Req.Set_Grid("SEM_OA", "8", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			fsp_Req.Font = new Font("Verdana",8);


			//Size Run
			int colfixed = (int)ClassLib.TBSEM_OA07.lxCS_SIZE; Sb_Set_Size(fsp_OA_Rel,colfixed);
			    colfixed = (int)ClassLib.TBSEM_OA08.lxCS_SIZE; Sb_Set_Size(fsp_Req,colfixed);
			
			
			Set_Init();

		}


		private void Set_Init()
		{  
			try
			{   
				txt_OBS_Id.Text    = COM.ComVar.Parameter_PopUp[1];
				txt_OBS_Type.Text  = COM.ComVar.Parameter_PopUp[2];
				txt_Style_Cd.Text  = COM.ComVar.Parameter_PopUp[3];
				txt_OA_Nu.Text	   = COM.ComVar.Parameter_PopUp[7];

				Select_OA_Rel(); 

				Select_Request(); 

				//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch,this);	
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch ,this);	
			}

			

		}


		private void Sb_Set_Size(C1FlexGrid arg_fgrid, int arg_colfixed)
		{  
			DataTable dt_list;

			string  sFact= COM.ComVar.Parameter_PopUp[0];
			string  sGen= COM.ComVar.Parameter_PopUp[5];
			string  sPst= COM.ComVar.Parameter_PopUp[6];

			//16,7
			arg_fgrid.Cols.Count  = arg_colfixed;

			dt_list = MyClassLib.Select_Gen_Size( sFact,sGen,sPst);

			if (dt_list == null) return;

			arg_fgrid.Cols.Count   =  arg_fgrid.Cols.Count + dt_list.Rows.Count;

			for (int i = 0; i < dt_list.Rows.Count; i++)
			{
				arg_fgrid[1,arg_colfixed+i] =dt_list.Rows[i].ItemArray[0];
				arg_fgrid.Cols[arg_colfixed+i].Width = 50;
				
			}

			arg_fgrid.GetCellRange(1,arg_colfixed,1,arg_fgrid.Cols.Count-1).StyleNew.BackColor
				= ClassLib.ComVar.Clr_Head_RYellow;           

		}


		private  void Display_OA_Rel(DataTable arg_dt)
		{
			fsp_OA_Rel.Rows.Count = _Rowfixed;
  
			
			//Size Run Setting
			int colfixed = (int)ClassLib.TBSEM_OA07.lxCS_SIZE; Sb_Set_Size(fsp_OA_Rel,colfixed);
			colfixed = (int)ClassLib.TBSEM_OA08.lxCS_SIZE; Sb_Set_Size(fsp_Req , colfixed);
			

			//Size 별 수량 Setting
			int iOBS_NU     = (int)ClassLib.TBSEM_OA07.lxOBS_NU;
			int iOBS_SEQ_NU = (int)ClassLib.TBSEM_OA07.lxOBS_SEQ_NU;
			int iCHG_NU     = (int)ClassLib.TBSEM_OA07.lxCHG_NU;
			int iGEN        = (int)ClassLib.TBSEM_OA07.lxGEN;
			int iCS_SIZE    = (int)ClassLib.TBSEM_OA07.lxCS_SIZE;
			int iQTY        = (int)ClassLib.TBSEM_OA07.lxORD_QTY;

			//merge
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				//merge
				fsp_OA_Rel.AllowMerging = AllowMergingEnum.Free;
				if (i <= (int)ClassLib.TBSEM_OA07.lxGEN)
					fsp_OA_Rel.Cols[i].AllowMerging = true;

				string sOBS_NU     = arg_dt.Rows[i].ItemArray[iOBS_NU-1].ToString();
				string sOBS_SEQ_NU = arg_dt.Rows[i].ItemArray[iOBS_SEQ_NU-1].ToString();
				string sCHG_NU     = arg_dt.Rows[i].ItemArray[iCHG_NU-1].ToString();					
				string sSIZE       = arg_dt.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fsp_OA_Rel.Rows.Count == _Rowfixed ) ||
					( sOBS_NU     != fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, iOBS_NU].ToString()     ) || 
					( sOBS_SEQ_NU != fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, iOBS_SEQ_NU].ToString() ) || 
					( sCHG_NU     != fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, iCHG_NU].ToString()     )  )
				{
					fsp_OA_Rel.AddItem(arg_dt.Rows[i].ItemArray, fsp_OA_Rel.Rows.Count, 1);
					fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, iCS_SIZE] = " ";
					fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, iQTY ] = " ";
					fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1,0 ] = " ";

											
				}

				for(int j=iGEN; j<fsp_OA_Rel.Cols.Count; j++)
				{
					if (fsp_OA_Rel[1, j].ToString() == sSIZE)
					{
						fsp_OA_Rel[fsp_OA_Rel.Rows.Count-1, j] = sQTY;
						fsp_OA_Rel.LeftCol = Convert.ToInt32(fsp_OA_Rel.Cols.Count/2);
						txt_CFM.Text = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSEM_OA07.lxOA_CFM-1].ToString();
						break;
					}
				}

			} 

			
			Sub_Total_Bal();
			
		}


		private void  Sub_Total_Bal()
		{  
			//Subtotal
			fsp_OA_Rel.SubtotalPosition = SubtotalPositionEnum.AboveData;
			fsp_OA_Rel.Tree.Column = (int)ClassLib.TBSEM_OA07.lxJOB;

			fsp_OA_Rel.Cols[(int)ClassLib.TBSEM_OA07.lxTOT_QTY].TextAlign = TextAlignEnum.RightCenter;
			fsp_OA_Rel.Cols[(int)ClassLib.TBSEM_OA07.lxTOT_QTY].Format     =  "###,###,###";

			//int iJOB = (int)ClassLib.TBSEM_OA07.lxJOB;
			for (int c = (int)ClassLib.TBSEM_OA07.lxTOT_QTY; c <fsp_OA_Rel.Cols.Count; c++)
			{                      
				fsp_OA_Rel.Subtotal(AggregateEnum.Sum, 0,0, c, "+/- ");
				fsp_OA_Rel.Styles[CellStyleEnum.Subtotal0].BackColor  = ClassLib.ComVar.ClrTransparent;
				fsp_OA_Rel.Styles[CellStyleEnum.Subtotal0].ForeColor  = ClassLib.ComVar.Clr_Text_Red;
				fsp_OA_Rel.GetCellRange(_Rowfixed,0,_Rowfixed,fsp_OA_Rel.Cols.Count -1).StyleNew.Font
					= new Font(fsp_OA_Rel.Font , FontStyle.Bold);

			}

			int iOA_CFM = (int)ClassLib.TBSEM_OA07.lxOA_CFM;
			fsp_OA_Rel.GetCellRange(_Rowfixed,iOA_CFM,fsp_OA_Rel.Rows.Count -1 ,iOA_CFM).StyleNew.ForeColor 
				 = ClassLib.ComVar.Clr_Text_Red;
		}



		private  void Display_Request(DataTable arg_dt)
		{
			fsp_Req.Rows.Count = _Rowfixed;
 

			//Size 별 수량 Setting
			int iREQ     = (int)ClassLib.TBSEM_OA08.IxREQ_NU;
			int iGEN     = (int)ClassLib.TBSEM_OA08.lxGEN;
			int iCS_SIZE = (int)ClassLib.TBSEM_OA08.lxCS_SIZE;
			int iQTY     = (int)ClassLib.TBSEM_OA08.lxORD_QTY;


			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				//merge
				fsp_Req.AllowMerging = AllowMergingEnum.Free;
				if (i <= (int)ClassLib.TBSEM_OA08.lxGEN)
					fsp_Req.Cols[i].AllowMerging = true;

				string sREQ		   = arg_dt.Rows[i].ItemArray[iREQ-1].ToString();
				string sGen        = arg_dt.Rows[i].ItemArray[iGEN-1].ToString();
				string sSIZE       = arg_dt.Rows[i].ItemArray[iCS_SIZE-1].ToString();
				string sQTY        = arg_dt.Rows[i].ItemArray[iQTY-1].ToString();

				if (( fsp_Req.Rows.Count == _Rowfixed ) ||
					( sREQ	 != fsp_Req[fsp_Req.Rows.Count-1, iREQ].ToString()))
				{
					fsp_Req.AddItem(arg_dt.Rows[i].ItemArray, fsp_Req.Rows.Count, 1);
					fsp_Req[fsp_Req.Rows.Count-1, iCS_SIZE] = " ";
					fsp_Req[fsp_Req.Rows.Count-1, iQTY ] = " ";
					fsp_Req[fsp_Req.Rows.Count-1,0 ] = " ";					
				}

				for(int j=iGEN; j<fsp_Req.Cols.Count; j++)
				{
					if (fsp_Req[1, j].ToString() == sSIZE)
					{
						fsp_Req[fsp_Req.Rows.Count-1, j] = sQTY;
						fsp_Req.LeftCol = Convert.ToInt32(fsp_Req.Cols.Count/2);
						break;
					}
				}

			} 
			
			int iTOT_QTY = (int)ClassLib.TBSEM_OA08.lxTOT_QTY;
			fsp_Req.GetCellRange(_Rowfixed,iTOT_QTY,fsp_Req.Rows.Count -1 ,iTOT_QTY).StyleNew.ForeColor 
				= ClassLib.ComVar.Clr_Text_Red;
		}



		#endregion

		#region DB 컨트롤
		private void Select_OA_Rel()
		{
			string strJob;
 
			DataSet ret;  DataTable  dt_list;

			int iCnt = 5;
			MyOraDB.ReDim_Parameter(iCnt); 
            
			strJob  = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_OAREL";
			MyOraDB.Process_Name =strJob;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_OA_NU";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
			
            for(int i = 0; i<iCnt; i++)
			{MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;}
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[4];
			MyOraDB.Parameter_Values[4] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();





			
			//setting grid
			if(ret == null) 
			{
				//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
			}
			else
			{
				dt_list =  ret.Tables[strJob];
				Display_OA_Rel(dt_list);
				
			}
			
		}


		private void Select_Request()
		{
			string strJob;
 
			DataSet ret;  DataTable  dt_list;

			int iCnt = 5;
			MyOraDB.ReDim_Parameter(iCnt); 
            
			strJob  = "PKG_SEM_OA_CRT01.SELECT_SEM_OBS_REQUEST";
			MyOraDB.Process_Name =strJob;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
			
			for(int i = 0; i<iCnt; i++)
			{MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;}
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
	
			MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[4] = "";
				
			MyOraDB.Add_Select_Parameter(true); 
			ret = MyOraDB.Exe_Select_Procedure();
			
			//setting grid
			if(ret == null) 
			{
				//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
			}
			else
			{
				dt_list =  ret.Tables[strJob];
				Display_Request(dt_list);
				
			}
			
		}


		private void Save_OA_Req()
		{
			int iParm, iCnt;			

			DataSet ret;
									    
			iParm = 9;
			MyOraDB.ReDim_Parameter(iParm); 

			//Package Name
			MyOraDB.Process_Name= "PKG_SEM_OA_CRT01.CFM_SEM_OBS_OA";
			
			//Parameter Name
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_JOB_FLAG";
			MyOraDB.Parameter_Name[3] = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[4] = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[5] = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[6] = "ARG_OA_NU";
			MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[8] = "ARG_UPD_YMD";
 
			//Parameter Type
			MyOraDB.Parameter_Values  = new string[(fsp_OA_Rel.Rows.Count-_Rowfixed-1)*iParm];


			iCnt = 0;
			for (int i =_Rowfixed+1 ; i< fsp_OA_Rel.Rows.Count; i++)
			{
					MyOraDB.Parameter_Values[iCnt] = COM.ComVar.Parameter_PopUp[0];
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = ClassLib.ComFunction.Empty_String(
						     fsp_OA_Rel[i,(int)ClassLib.TBSEM_OA07.lxREQ_NO].ToString()," "); 
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = fsp_OA_Rel[i,(int)ClassLib.TBSEM_OA07.lxJOB].ToString(); 
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = fsp_OA_Rel[i,(int)ClassLib.TBSEM_OA07.lxOBS_NU].ToString(); 
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = fsp_OA_Rel[i,(int)ClassLib.TBSEM_OA07.lxOBS_SEQ_NU].ToString(); 
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = fsp_OA_Rel[i,(int)ClassLib.TBSEM_OA07.lxCHG_NU].ToString();
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = COM.ComVar.Parameter_PopUp[4];
					iCnt +=1;	
					MyOraDB.Parameter_Values[iCnt] = ClassLib.ComVar.This_User;
					iCnt +=1;
					MyOraDB.Parameter_Values[iCnt] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					iCnt +=1;
			}
 
			MyOraDB.Add_Modify_Parameter(true);	
			
			ret =  MyOraDB.Exe_Modify_Procedure();	
		
			//Error 처리
			if(ret == null) 
			{
				//ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
					
			}
			else 
			{   
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
					
			}


		}



		#endregion

		#region 이벤트처리

		private void lbl_CFM_Click(object sender, System.EventArgs e)
		{
			try
			{   
				Save_OA_Req();

				Select_OA_Rel(); 

				Select_Request(); 

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave,this);	
			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}
		}


		#endregion


		private void Form_OA_CFM_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}

	}


