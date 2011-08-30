using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.Threading;
using C1.Win.C1FlexGrid;

namespace FlexMold.Tooling
{
	public class Form_ST_Purchase_Code : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_Com_Group;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private C1.Win.C1List.C1Combo c1Combo1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1List.C1Combo c1Combo2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox3;
		private C1.Win.C1List.C1Combo c1Combo3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private C1.Win.C1List.C1Combo c1Combo4;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.Panel pnl_main;
		private COM.FSP fgrid_Comp;
		private System.Windows.Forms.Panel panel4;		
		private COM.FSP fgrid_Item;
		private C1.Win.C1List.C1Combo cmb_fac;
		private C1.Win.C1List.C1Combo cmb_Comp_Group;
		private C1.Win.C1List.C1Combo cmb_Item_Group;
		private System.ComponentModel.IContainer components = null;

		private int _Rowfixed;
		private int _Rowfixed1;
		private System.Windows.Forms.Label btn_New;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label btn_New1;
		private System.Windows.Forms.Label btn_Save1;		
		private bool _firstLoad    = true;
		private System.Windows.Forms.ContextMenu ctx_main;
		private System.Windows.Forms.MenuItem menuItem1;

		private COM.OraDB MyOraDB = new COM.OraDB();

		public Form_ST_Purchase_Code()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_ST_Purchase_Code));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_New = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.c1Combo1 = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.c1Combo2 = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.cmb_Comp_Group = new C1.Win.C1List.C1Combo();
			this.lbl_Com_Group = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_Save1 = new System.Windows.Forms.Label();
			this.cmb_fac = new C1.Win.C1List.C1Combo();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.c1Combo3 = new C1.Win.C1List.C1Combo();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.c1Combo4 = new C1.Win.C1List.C1Combo();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.cmb_Item_Group = new C1.Win.C1List.C1Combo();
			this.label15 = new System.Windows.Forms.Label();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.btn_New1 = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.label18 = new System.Windows.Forms.Label();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.fgrid_Comp = new COM.FSP();
			this.panel4 = new System.Windows.Forms.Panel();
			this.fgrid_Item = new COM.FSP();
			this.ctx_main = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Comp_Group)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_fac)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item_Group)).BeginInit();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).BeginInit();
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
			this.c1ToolBar1.Visible = false;
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_Save);
			this.pnl_head.Controls.Add(this.btn_New);
			this.pnl_head.Controls.Add(this.panel1);
			this.pnl_head.Controls.Add(this.cmb_Comp_Group);
			this.pnl_head.Controls.Add(this.lbl_Com_Group);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(0, 64);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(496, 96);
			this.pnl_head.TabIndex = 5;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Save.ForeColor = System.Drawing.Color.Red;
			this.btn_Save.ImageIndex = 1;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(408, 24);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Save.Size = new System.Drawing.Size(80, 24);
			this.btn_Save.TabIndex = 551;
			this.btn_Save.Text = "Save";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_New
			// 
			this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_New.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_New.ForeColor = System.Drawing.Color.Red;
			this.btn_New.ImageIndex = 1;
			this.btn_New.ImageList = this.img_Button;
			this.btn_New.Location = new System.Drawing.Point(328, 24);
			this.btn_New.Name = "btn_New";
			this.btn_New.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_New.Size = new System.Drawing.Size(80, 24);
			this.btn_New.TabIndex = 550;
			this.btn_New.Text = "New";
			this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.c1Combo1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.c1Combo2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Location = new System.Drawing.Point(392, 256);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(496, 115);
			this.panel1.TabIndex = 548;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textBox1.Location = new System.Drawing.Point(112, 88);
			this.textBox1.MaxLength = 500;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(75, 21);
			this.textBox1.TabIndex = 547;
			this.textBox1.Text = "";
			// 
			// c1Combo1
			// 
			this.c1Combo1.AddItemCols = 0;
			this.c1Combo1.AddItemSeparator = ';';
			this.c1Combo1.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo1.AutoSize = false;
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
			this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo1.EditorHeight = 17;
			this.c1Combo1.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.c1Combo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo1.GapHeight = 2;
			this.c1Combo1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.c1Combo1.ItemHeight = 15;
			this.c1Combo1.Location = new System.Drawing.Point(109, 64);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo1.Size = new System.Drawing.Size(200, 21);
			this.c1Combo1.TabIndex = 545;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(8, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 543;
			this.label3.Text = "Exchange Rate";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textBox2.Location = new System.Drawing.Point(208, 88);
			this.textBox2.MaxLength = 500;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 21);
			this.textBox2.TabIndex = 542;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ImageIndex = 0;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(312, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 382;
			this.label4.Text = "Status";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ImageIndex = 1;
			this.label5.ImageList = this.img_Label;
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 366;
			this.label5.Text = "P.O #";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Combo2
			// 
			this.c1Combo2.AddItemCols = 0;
			this.c1Combo2.AddItemSeparator = ';';
			this.c1Combo2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo2.AutoSize = false;
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
			this.c1Combo2.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 17;
			this.c1Combo2.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.c1Combo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(109, 40);
			this.c1Combo2.MatchEntryTimeout = ((long)(2000));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.PartialRightColumn = false;
			this.c1Combo2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.Size = new System.Drawing.Size(200, 21);
			this.c1Combo2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(480, 99);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(136, 98);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(456, 18);
			this.pictureBox2.TabIndex = 40;
			this.pictureBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ImageIndex = 1;
			this.label6.ImageList = this.img_Label;
			this.label6.Location = new System.Drawing.Point(8, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 50;
			this.label6.Text = "Factory";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(395, 30);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(101, 74);
			this.pictureBox3.TabIndex = 46;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(480, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 32);
			this.pictureBox4.TabIndex = 44;
			this.pictureBox4.TabStop = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Window;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(231, 30);
			this.label7.TabIndex = 42;
			this.label7.Text = "       Search";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(208, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(456, 32);
			this.pictureBox5.TabIndex = 39;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 99);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 43;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 16);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 88);
			this.pictureBox7.TabIndex = 41;
			this.pictureBox7.TabStop = false;
			// 
			// cmb_Comp_Group
			// 
			this.cmb_Comp_Group.AddItemCols = 0;
			this.cmb_Comp_Group.AddItemSeparator = ';';
			this.cmb_Comp_Group.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Comp_Group.AutoSize = false;
			this.cmb_Comp_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Comp_Group.Caption = "";
			this.cmb_Comp_Group.CaptionHeight = 17;
			this.cmb_Comp_Group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Comp_Group.ColumnCaptionHeight = 18;
			this.cmb_Comp_Group.ColumnFooterHeight = 18;
			this.cmb_Comp_Group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Comp_Group.ContentHeight = 17;
			this.cmb_Comp_Group.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Comp_Group.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Comp_Group.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Comp_Group.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Comp_Group.EditorHeight = 17;
			this.cmb_Comp_Group.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Comp_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Comp_Group.GapHeight = 2;
			this.cmb_Comp_Group.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_Comp_Group.ItemHeight = 15;
			this.cmb_Comp_Group.Location = new System.Drawing.Point(89, 64);
			this.cmb_Comp_Group.MatchEntryTimeout = ((long)(2000));
			this.cmb_Comp_Group.MaxDropDownItems = ((short)(5));
			this.cmb_Comp_Group.MaxLength = 32767;
			this.cmb_Comp_Group.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Comp_Group.Name = "cmb_Comp_Group";
			this.cmb_Comp_Group.PartialRightColumn = false;
			this.cmb_Comp_Group.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Comp_Group.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Comp_Group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Comp_Group.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Comp_Group.Size = new System.Drawing.Size(176, 21);
			this.cmb_Comp_Group.TabIndex = 545;
			this.cmb_Comp_Group.SelectedValueChanged += new System.EventHandler(this.cmb_Comp_Group_SelectedValueChanged);
			// 
			// lbl_Com_Group
			// 
			this.lbl_Com_Group.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Com_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Com_Group.ImageIndex = 1;
			this.lbl_Com_Group.ImageList = this.img_Label;
			this.lbl_Com_Group.Location = new System.Drawing.Point(8, 64);
			this.lbl_Com_Group.Name = "lbl_Com_Group";
			this.lbl_Com_Group.Size = new System.Drawing.Size(80, 21);
			this.lbl_Com_Group.TabIndex = 366;
			this.lbl_Com_Group.Text = "Comp Group";
			this.lbl_Com_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(89, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(176, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(480, 80);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 79);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(456, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(80, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(395, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 55);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(480, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 42;
			this.label2.Text = "       Component";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(208, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(456, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 80);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 16);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 69);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.btn_Save1);
			this.panel2.Controls.Add(this.cmb_fac);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.cmb_Item_Group);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.pictureBox15);
			this.panel2.Controls.Add(this.pictureBox16);
			this.panel2.Controls.Add(this.label16);
			this.panel2.Controls.Add(this.pictureBox18);
			this.panel2.Controls.Add(this.label17);
			this.panel2.Controls.Add(this.pictureBox20);
			this.panel2.Controls.Add(this.pictureBox21);
			this.panel2.Controls.Add(this.btn_New1);
			this.panel2.Controls.Add(this.pictureBox17);
			this.panel2.Controls.Add(this.pictureBox19);
			this.panel2.Location = new System.Drawing.Point(512, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(496, 96);
			this.panel2.TabIndex = 549;
			// 
			// btn_Save1
			// 
			this.btn_Save1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_Save1.ForeColor = System.Drawing.Color.Blue;
			this.btn_Save1.ImageIndex = 1;
			this.btn_Save1.ImageList = this.img_Button;
			this.btn_Save1.Location = new System.Drawing.Point(399, 24);
			this.btn_Save1.Name = "btn_Save1";
			this.btn_Save1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Save1.Size = new System.Drawing.Size(80, 24);
			this.btn_Save1.TabIndex = 553;
			this.btn_Save1.Text = "Save";
			this.btn_Save1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save1.Click += new System.EventHandler(this.btn_Save1_Click);
			// 
			// cmb_fac
			// 
			this.cmb_fac.AddItemCols = 0;
			this.cmb_fac.AddItemSeparator = ';';
			this.cmb_fac.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_fac.AutoSize = false;
			this.cmb_fac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_fac.Caption = "";
			this.cmb_fac.CaptionHeight = 17;
			this.cmb_fac.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_fac.ColumnCaptionHeight = 18;
			this.cmb_fac.ColumnFooterHeight = 18;
			this.cmb_fac.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_fac.ContentHeight = 17;
			this.cmb_fac.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_fac.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_fac.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_fac.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_fac.EditorHeight = 17;
			this.cmb_fac.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_fac.GapHeight = 2;
			this.cmb_fac.ItemHeight = 15;
			this.cmb_fac.Location = new System.Drawing.Point(88, 40);
			this.cmb_fac.MatchEntryTimeout = ((long)(2000));
			this.cmb_fac.MaxDropDownItems = ((short)(5));
			this.cmb_fac.MaxLength = 32767;
			this.cmb_fac.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_fac.Name = "cmb_fac";
			this.cmb_fac.PartialRightColumn = false;
			this.cmb_fac.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_fac.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_fac.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_fac.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_fac.Size = new System.Drawing.Size(171, 21);
			this.cmb_fac.TabIndex = 549;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.c1Combo3);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.textBox4);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.c1Combo4);
			this.panel3.Controls.Add(this.pictureBox8);
			this.panel3.Controls.Add(this.pictureBox9);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.pictureBox10);
			this.panel3.Controls.Add(this.pictureBox11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.pictureBox12);
			this.panel3.Controls.Add(this.pictureBox13);
			this.panel3.Controls.Add(this.pictureBox14);
			this.panel3.Location = new System.Drawing.Point(392, 256);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(496, 115);
			this.panel3.TabIndex = 548;
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textBox3.Location = new System.Drawing.Point(112, 88);
			this.textBox3.MaxLength = 500;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(75, 21);
			this.textBox3.TabIndex = 547;
			this.textBox3.Text = "";
			// 
			// c1Combo3
			// 
			this.c1Combo3.AddItemCols = 0;
			this.c1Combo3.AddItemSeparator = ';';
			this.c1Combo3.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo3.AutoSize = false;
			this.c1Combo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo3.Caption = "";
			this.c1Combo3.CaptionHeight = 17;
			this.c1Combo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo3.ColumnCaptionHeight = 18;
			this.c1Combo3.ColumnFooterHeight = 18;
			this.c1Combo3.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo3.ContentHeight = 17;
			this.c1Combo3.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo3.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo3.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.c1Combo3.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo3.EditorHeight = 17;
			this.c1Combo3.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.c1Combo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo3.GapHeight = 2;
			this.c1Combo3.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.c1Combo3.ItemHeight = 15;
			this.c1Combo3.Location = new System.Drawing.Point(109, 64);
			this.c1Combo3.MatchEntryTimeout = ((long)(2000));
			this.c1Combo3.MaxDropDownItems = ((short)(5));
			this.c1Combo3.MaxLength = 32767;
			this.c1Combo3.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo3.Name = "c1Combo3";
			this.c1Combo3.PartialRightColumn = false;
			this.c1Combo3.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}He" +
				"ading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText" +
				";BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.c1Combo3.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo3.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo3.Size = new System.Drawing.Size(200, 21);
			this.c1Combo3.TabIndex = 545;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ImageIndex = 0;
			this.label8.ImageList = this.img_Label;
			this.label8.Location = new System.Drawing.Point(8, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 21);
			this.label8.TabIndex = 543;
			this.label8.Text = "Exchange Rate";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.textBox4.Location = new System.Drawing.Point(208, 88);
			this.textBox4.MaxLength = 500;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 21);
			this.textBox4.TabIndex = 542;
			this.textBox4.Text = "";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ImageIndex = 0;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(312, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 382;
			this.label9.Text = "Status";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ImageIndex = 1;
			this.label10.ImageList = this.img_Label;
			this.label10.Location = new System.Drawing.Point(8, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 21);
			this.label10.TabIndex = 366;
			this.label10.Text = "P.O #";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Combo4
			// 
			this.c1Combo4.AddItemCols = 0;
			this.c1Combo4.AddItemSeparator = ';';
			this.c1Combo4.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo4.AutoSize = false;
			this.c1Combo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo4.Caption = "";
			this.c1Combo4.CaptionHeight = 17;
			this.c1Combo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo4.ColumnCaptionHeight = 18;
			this.c1Combo4.ColumnFooterHeight = 18;
			this.c1Combo4.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo4.ContentHeight = 17;
			this.c1Combo4.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo4.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo4.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.c1Combo4.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo4.EditorHeight = 17;
			this.c1Combo4.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.c1Combo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo4.GapHeight = 2;
			this.c1Combo4.ItemHeight = 15;
			this.c1Combo4.Location = new System.Drawing.Point(109, 40);
			this.c1Combo4.MatchEntryTimeout = ((long)(2000));
			this.c1Combo4.MaxDropDownItems = ((short)(5));
			this.c1Combo4.MaxLength = 32767;
			this.c1Combo4.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo4.Name = "c1Combo4";
			this.c1Combo4.PartialRightColumn = false;
			this.c1Combo4.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.c1Combo4.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo4.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo4.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo4.Size = new System.Drawing.Size(200, 21);
			this.c1Combo4.TabIndex = 1;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(480, 99);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(16, 16);
			this.pictureBox8.TabIndex = 45;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(136, 98);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(456, 18);
			this.pictureBox9.TabIndex = 40;
			this.pictureBox9.TabStop = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ImageIndex = 1;
			this.label11.ImageList = this.img_Label;
			this.label11.Location = new System.Drawing.Point(8, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 21);
			this.label11.TabIndex = 50;
			this.label11.Text = "Factory";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(395, 30);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(101, 74);
			this.pictureBox10.TabIndex = 46;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(480, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(16, 32);
			this.pictureBox11.TabIndex = 44;
			this.pictureBox11.TabStop = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Window;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.Color.Navy;
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(231, 30);
			this.label12.TabIndex = 42;
			this.label12.Text = "       Search";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(208, 0);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(456, 32);
			this.pictureBox12.TabIndex = 39;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 99);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(168, 20);
			this.pictureBox13.TabIndex = 43;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 16);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(168, 88);
			this.pictureBox14.TabIndex = 41;
			this.pictureBox14.TabStop = false;
			// 
			// cmb_Item_Group
			// 
			this.cmb_Item_Group.AddItemCols = 0;
			this.cmb_Item_Group.AddItemSeparator = ';';
			this.cmb_Item_Group.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Item_Group.AutoSize = false;
			this.cmb_Item_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Item_Group.Caption = "";
			this.cmb_Item_Group.CaptionHeight = 17;
			this.cmb_Item_Group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Item_Group.ColumnCaptionHeight = 18;
			this.cmb_Item_Group.ColumnFooterHeight = 18;
			this.cmb_Item_Group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Item_Group.ContentHeight = 17;
			this.cmb_Item_Group.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Item_Group.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Item_Group.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.cmb_Item_Group.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Item_Group.EditorHeight = 17;
			this.cmb_Item_Group.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_Item_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Item_Group.GapHeight = 2;
			this.cmb_Item_Group.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.cmb_Item_Group.ItemHeight = 15;
			this.cmb_Item_Group.Location = new System.Drawing.Point(88, 64);
			this.cmb_Item_Group.MatchEntryTimeout = ((long)(2000));
			this.cmb_Item_Group.MaxDropDownItems = ((short)(5));
			this.cmb_Item_Group.MaxLength = 32767;
			this.cmb_Item_Group.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Item_Group.Name = "cmb_Item_Group";
			this.cmb_Item_Group.PartialRightColumn = false;
			this.cmb_Item_Group.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Microsoft" +
				" Sans Serif, 9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColo" +
				"r:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Cen" +
				"ter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C" +
				"1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Colum" +
				"nCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalSc" +
				"rollGroup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Widt" +
				"h></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=" +
				"\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle" +
				" parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Headin" +
				"gStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" m" +
				"e=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=" +
				"\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\"" +
				" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Sty" +
				"le1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"No" +
				"rmal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer" +
				"\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\"" +
				" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRo" +
				"w\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" />" +
				"<Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\"" +
				" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Mod" +
				"ified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Item_Group.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Item_Group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Item_Group.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Item_Group.Size = new System.Drawing.Size(171, 21);
			this.cmb_Item_Group.TabIndex = 545;
			this.cmb_Item_Group.SelectedValueChanged += new System.EventHandler(this.cmb_Item_Group_SelectedValueChanged);
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.ImageIndex = 1;
			this.label15.ImageList = this.img_Label;
			this.label15.Location = new System.Drawing.Point(8, 64);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 21);
			this.label15.TabIndex = 366;
			this.label15.Text = "Item Group";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(480, 80);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(16, 16);
			this.pictureBox15.TabIndex = 45;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(136, 79);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(456, 18);
			this.pictureBox16.TabIndex = 40;
			this.pictureBox16.TabStop = false;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.ImageIndex = 1;
			this.label16.ImageList = this.img_Label;
			this.label16.Location = new System.Drawing.Point(8, 40);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 21);
			this.label16.TabIndex = 50;
			this.label16.Text = "Factory";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(480, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(16, 32);
			this.pictureBox18.TabIndex = 44;
			this.pictureBox18.TabStop = false;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.SystemColors.Window;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.label17.ForeColor = System.Drawing.Color.Navy;
			this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
			this.label17.Location = new System.Drawing.Point(0, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(231, 30);
			this.label17.TabIndex = 42;
			this.label17.Text = "       Item";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(0, 80);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(168, 20);
			this.pictureBox20.TabIndex = 43;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(0, 16);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(168, 69);
			this.pictureBox21.TabIndex = 41;
			this.pictureBox21.TabStop = false;
			// 
			// btn_New1
			// 
			this.btn_New1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_New1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_New1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.btn_New1.ForeColor = System.Drawing.Color.Blue;
			this.btn_New1.ImageIndex = 1;
			this.btn_New1.ImageList = this.img_Button;
			this.btn_New1.Location = new System.Drawing.Point(320, 24);
			this.btn_New1.Name = "btn_New1";
			this.btn_New1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_New1.Size = new System.Drawing.Size(80, 24);
			this.btn_New1.TabIndex = 552;
			this.btn_New1.Text = "New";
			this.btn_New1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_New1.Click += new System.EventHandler(this.btn_New1_Click);
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(395, 30);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(101, 55);
			this.pictureBox17.TabIndex = 46;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(208, 0);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(456, 32);
			this.pictureBox19.TabIndex = 39;
			this.pictureBox19.TabStop = false;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(0, 0);
			this.label18.Name = "label18";
			this.label18.TabIndex = 0;
			// 
			// pnl_main
			// 
			this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pnl_main.BackColor = System.Drawing.Color.White;
			this.pnl_main.Controls.Add(this.fgrid_Comp);
			this.pnl_main.Location = new System.Drawing.Point(8, 160);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(488, 472);
			this.pnl_main.TabIndex = 550;
			// 
			// fgrid_Comp
			// 
			this.fgrid_Comp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_Comp.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Comp.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Comp.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Comp.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Comp.Name = "fgrid_Comp";
			this.fgrid_Comp.Size = new System.Drawing.Size(488, 472);
			this.fgrid_Comp.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Comp.TabIndex = 0;
			this.fgrid_Comp.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Comp_BeforeEdit);
			this.fgrid_Comp.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Comp_AfterEdit);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.fgrid_Item);
			this.panel4.Location = new System.Drawing.Point(512, 160);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(496, 472);
			this.panel4.TabIndex = 551;
			// 
			// fgrid_Item
			// 
			this.fgrid_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.fgrid_Item.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Item.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Item.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Item.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Item.Name = "fgrid_Item";
			this.fgrid_Item.Size = new System.Drawing.Size(496, 472);
			this.fgrid_Item.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Item.TabIndex = 1;
			this.fgrid_Item.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Item_BeforeEdit);
			this.fgrid_Item.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Item_AfterEdit);
			// 
			// ctx_main
			// 
			this.ctx_main.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "New";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// Form_ST_Purchase_Code
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnl_main);
			this.Controls.Add(this.pnl_head);
			this.Controls.Add(this.panel2);
			this.Name = "Form_ST_Purchase_Code";
			this.Load += new System.EventHandler(this.Form_ST_Purchase_Code_Load);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.pnl_main, 0);
			this.Controls.SetChildIndex(this.panel4, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Comp_Group)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_fac)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1Combo3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Item_Group)).EndInit();
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Item)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_ST_Purchase_Code_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		private void Init_Form()
		{						
			// form initialize
			ClassLib.ComFunction.Init_Form_Control(this);
			ClassLib.ComFunction.SetLangDic(this);

			this.Text		   = "Small Tooling";
			lbl_MainTitle.Text = "Main/Sub Component && Item Master";		

			// grid_Comp set
			fgrid_Comp.Set_Grid("SVM_SM_COMPONENT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Comp.Set_Action_Image(img_Action);

			_Rowfixed = fgrid_Comp.Rows.Fixed;		

			// grid_Item  set
			fgrid_Item.Set_Grid("SVM_SM_ITEM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Item.Set_Action_Image(img_Action);
			_Rowfixed1 = fgrid_Item.Rows.Fixed;		

			//입력부 setup
			Init_Combo();
			
			_firstLoad = false;

		}
		
		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				COM.ComCtl.Set_ComboList(vDt, cmb_fac, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;	
				cmb_fac.SelectedValue    = ClassLib.ComVar.This_Factory;				

				vDt.Dispose();
				
				//	cmb_Comp_Group
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SVM15");
				COM.ComCtl.Set_ComboList(vDt, cmb_Comp_Group, 1, 2, true, 80, 140);
				cmb_Comp_Group.SelectedIndex = 0;
				vDt.Dispose();

				//	cmb_Item_Group
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SVM13");
				COM.ComCtl.Set_ComboList(vDt, cmb_Item_Group, 1, 2, true, 80, 140);
				cmb_Item_Group.SelectedIndex = 0;
				vDt.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}

		private void cmb_Comp_Group_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Comp_Group.SelectedIndex > 0)		
			{
				Seach_Comp();			
				btn_New.Visible = true;
				btn_Save.Visible = true;
			}
			else
			{
				btn_New.Visible = false;
				btn_Save.Visible = false;
				fgrid_Comp.Clear();			
				fgrid_Comp.Set_Grid("SVM_SM_COMPONENT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				return;
			}
		 
		}
		private void Seach_Comp()
		{
			DataTable vDt1 = null;
			fgrid_Comp.Clear();
			

			fgrid_Comp.Set_Grid("SVM_SM_COMPONENT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Comp.Set_Action_Image(img_Action);
			fgrid_Comp.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_COMP_GROUP();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_Comp.AddItem(vDt1.Rows[i].ItemArray, fgrid_Comp.Rows.Count, 1);						
					}

				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
			}
						
			catch
			{

			}
		}

		private void Seach_Item()
		{
			DataTable vDt1 = null;
			fgrid_Item.Clear();
			

			fgrid_Item.Set_Grid("SVM_SM_ITEM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Item.Set_Action_Image(img_Action);
			fgrid_Item.ExtendLastCol = false;
			try
			{
				vDt1 = SELECT_ITEM_GROUP();    

				if(vDt1.Rows.Count > 0)
				{
					for(int i = 0; i < vDt1.Rows.Count; i++)
					{
						fgrid_Item.AddItem(vDt1.Rows[i].ItemArray, fgrid_Item.Rows.Count, 1);						
					}

				}
				else            
				{
					MessageBox.Show("No Data !!");
					return;
				}
			}
						
			catch
			{

			}
		}
		private System.Data.DataTable SELECT_COMP_GROUP()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SVM_SM_COMP";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COMP_GROUP";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Comp_Group.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
			
		}

		private System.Data.DataTable SELECT_ITEM_GROUP()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SELECT_SVM_SM_ITEM";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_Item_Group.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
			
		}

		private void cmb_Item_Group_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Item_Group.SelectedIndex > 0)
			{
				Seach_Item();
				btn_New1.Visible = true;
				btn_Save1.Visible = true;
			}
			else
			{
				btn_New1.Visible = false;
				btn_Save1.Visible = false;
				fgrid_Item.Clear();			
				fgrid_Item.Set_Grid("SVM_SM_ITEM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				return;
			}
		}

		private void btn_New_Click(object sender, System.EventArgs e)
		{
			fgrid_Comp.Rows.Add();
			fgrid_Comp[fgrid_Comp.Rows.Count-1 , 0]       = "I";
//			fgrid_Comp[fgrid_Comp.Rows.Count-1 , 1]       = Convert.ToInt16(fgrid_Comp[fgrid_Comp.Rows.Count - 2 , 1].ToString()) + 1 ;
			fgrid_Comp.TopRow = fgrid_Comp.Rows.Count-1;

		}

		private void fgrid_Comp_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess();
		}

		private void fgrid_Comp_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess();
		}
		
		private void Grid_BeforeEditProcess()
		{
			if ((fgrid_Comp.Rows.Fixed > 0) && (fgrid_Comp.Row >= fgrid_Comp.Rows.Fixed))
				fgrid_Comp.Buffer_CellData = (fgrid_Comp[fgrid_Comp.Row, fgrid_Comp.Col] == null) ? "" : fgrid_Comp[fgrid_Comp.Row, fgrid_Comp.Col].ToString();
		}
		private void Grid_AfterEditProcess()
		{

			try
			{
				int iCol = fgrid_Comp.Selection.c1;
				int iRow = fgrid_Comp.Selection.r1;
			
			    fgrid_Comp.Update_Row();

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			int sel_row = fgrid_Comp.Selection.r1;
			add_row(sel_row);
		}
		private void add_row(int arg_sel_row)
		{
			try
			{
				C1.Win.C1FlexGrid.Node node = fgrid_Comp.Rows[arg_sel_row].Node;
	
				node.AddNode(NodeTypeEnum.LastChild, "");

				int current_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index; 

				// Set Default Value //
				fgrid_Comp[current_row, 0]              = "I";
//				fgrid_main[current_row, _colT_LEVEL]	= "2";
//				fgrid_main[current_row, _colFACTORY]	= ClassLib.ComFunction.Empty_Combo(cmb_factory, "");
//				fgrid_main[current_row, _colPUR_NO]  	= (fgrid_main[current_row-1, _colPUR_NO] == null) ? "" : fgrid_main[current_row-1, _colPUR_NO].ToString();
//				fgrid_main[current_row, _colMODEL_CD]	= fgrid_main[current_row-1, _colMODEL_CD].ToString();
//
//				fgrid_main[current_row, _colCOMPONENT_M_NM]	= fgrid_main[current_row-1, _colCOMPONENT_M_NM].ToString();
//				fgrid_main[current_row, _colCOMPONENT_S_NM]	= fgrid_main[current_row-1, _colCOMPONENT_S_NM].ToString();
//				//				fgrid_main[current_row, _colRE_QTY]    = fgrid_main[current_row-1, _colRE_QTY].ToString();    				
//				fgrid_main[current_row, _colSIZE_DESC] = fgrid_main[current_row-1, _colSIZE_DESC].ToString();
//				fgrid_main[current_row, _colCURRENCY]  = fgrid_main[current_row-1, _colCURRENCY].ToString();
			}
			catch(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_New1_Click(object sender, System.EventArgs e)
		{
			fgrid_Item.Rows.Add();
			fgrid_Item[fgrid_Item.Rows.Count-1 , 0]       = "I";
//			fgrid_Item[fgrid_Item.Rows.Count-1 , 1]       = Convert.ToInt16(fgrid_Item[fgrid_Item.Rows.Count - 2 , 1].ToString()) + 1 ;
			fgrid_Item.TopRow = fgrid_Item.Rows.Count-1;
		}

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			Tbtn_SaveProcess();
		}
		private void Tbtn_SaveProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_SM_COMP(true))
				{
					fgrid_Comp.Refresh_Division();					
					MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				    Seach_Comp();	
				}
			}
			catch (Exception ex)
			{
				//
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_SM_COMP(bool doExecute)
		{			
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 6;
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SAVE_SVM_SM_COMP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";				
				MyOraDB.Parameter_Name[1] = "ARG_LEVEL_CD";
				MyOraDB.Parameter_Name[2] = "ARG_COMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMP_NAME";
				MyOraDB.Parameter_Name[4] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;

//				MyOraDB.Parameter_Values  = new string[6];

				for(int iRow = fgrid_Comp.Rows.Fixed ; iRow < fgrid_Comp.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_Comp[iRow, 0]).Equals("") )
						save_ct += 1;

				save_ct += 1; // HEAD RECORD

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_Comp.Rows.Fixed ; iRow < fgrid_Comp.Rows.Count ; iRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_Comp[iRow, 0]).Equals("") )
					{

						MyOraDB.Parameter_Values[para_ct+ 0] = (fgrid_Comp[iRow,0] == null) ? ""  : fgrid_Comp[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = cmb_Comp_Group.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = (fgrid_Comp[iRow,1] == null) ? ""  : fgrid_Comp[iRow, 1].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = (fgrid_Comp[iRow,2] == null) ? ""  : fgrid_Comp[iRow, 2].ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = (fgrid_Comp[iRow,3] == null) ? ""  : fgrid_Comp[iRow, 3].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = COM.ComVar.This_User;

						para_ct += iCount;
					}	
					
				}

				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}

		}

		private void btn_Save1_Click(object sender, System.EventArgs e)
		{
			Tbtn_SaveProcess1();
		}
		private void Tbtn_SaveProcess1()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (SAVE_SVM_SM_ITEM(true))
				{
					fgrid_Comp.Refresh_Division();					
					MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
					Seach_Item();	
				}
			}
			catch (Exception ex)
			{
				//
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		public bool SAVE_SVM_SM_ITEM(bool doExecute)
		{			
			try
			{
				int save_ct = 0;   
				int para_ct = 0; 
				int iCount  = 8;
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SVM_SM_PURCHASE_ORDER.SAVE_SVM_SM_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";				
				MyOraDB.Parameter_Name[1] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[3] = "ARG_GROUP_CD";
				MyOraDB.Parameter_Name[4] = "ARG_CBD_YN";
				MyOraDB.Parameter_Name[5] = "ARG_USE_YN";
				MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				

				for(int iRow = fgrid_Item.Rows.Fixed ; iRow < fgrid_Item.Rows.Count; iRow++)
					if (!ClassLib.ComFunction.NullToBlank(fgrid_Item[iRow, 0]).Equals("") )
						save_ct += 1;

				save_ct += 1; // HEAD RECORD

				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[iCount * save_ct ];

				for (int iRow = fgrid_Item.Rows.Fixed ; iRow < fgrid_Item.Rows.Count ; iRow++)
				{
					if (!ClassLib.ComFunction.NullToBlank(fgrid_Item[iRow, 0]).Equals("") )
					{

						MyOraDB.Parameter_Values[para_ct+ 0] = (fgrid_Item[iRow,0] == null) ? ""  : fgrid_Item[iRow, 0].ToString();
						MyOraDB.Parameter_Values[para_ct+ 1] = (fgrid_Item[iRow,1] == null) ? ""  : fgrid_Item[iRow, 1].ToString();
						MyOraDB.Parameter_Values[para_ct+ 2] = (fgrid_Item[iRow,2] == null) ? ""  : fgrid_Item[iRow, 2].ToString();
						MyOraDB.Parameter_Values[para_ct+ 3] = cmb_Item_Group.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct+ 4] = (fgrid_Item[iRow,3] == null) ? ""  : fgrid_Item[iRow, 3].ToString();
						MyOraDB.Parameter_Values[para_ct+ 5] = (fgrid_Item[iRow,4] == null) ? ""  : fgrid_Item[iRow, 4].ToString();
						MyOraDB.Parameter_Values[para_ct+ 6] = "";
						MyOraDB.Parameter_Values[para_ct+ 7] = COM.ComVar.This_User;

						para_ct += iCount;
					}	
					
				}

				MyOraDB.Add_Modify_Parameter(true);	// 파라미터 데이터를 DataSet에 추가
				
				if (doExecute)
				{
					if (MyOraDB.Exe_Modify_Procedure() == null)
						return false;
					else
						return true;
				}

				return true;

			}
			catch
			{
				return false;
			}

		}

		private void fgrid_Item_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_AfterEditProcess1();
		}

		private void Grid_AfterEditProcess1()
		{

			try
			{
				int iCol = fgrid_Item.Selection.c1;
				int iRow = fgrid_Item.Selection.r1;
			
				fgrid_Item.Update_Row();

			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void fgrid_Item_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			this.Grid_BeforeEditProcess1();
		}
		private void Grid_BeforeEditProcess1()
		{
			if ((fgrid_Item.Rows.Fixed > 0) && (fgrid_Item.Row >= fgrid_Item.Rows.Fixed))
				fgrid_Item.Buffer_CellData = (fgrid_Item[fgrid_Item.Row, fgrid_Item.Col] == null) ? "" : fgrid_Item[fgrid_Item.Row, fgrid_Item.Col].ToString();
		}

	
	}
}

