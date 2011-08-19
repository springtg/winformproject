using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread.Model;

namespace FlexPurchase.Stock
{
	public class Pop_BK_Stock_Close_DS : COM.PCHWinForm.Pop_Medium
	{
		
		#region 디자이너에서 생성한 변수

		private System.Windows.Forms.Label lbl_TotQty;
		private System.Windows.Forms.TextBox txt_TotQty;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private C1.Win.C1List.C1Combo cmb_stockMM;
		private C1.Win.C1List.C1Combo cmb_stockYY;
		private System.Windows.Forms.Label lbl_StockYm;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_MakeStock;
		private System.Windows.Forms.Button btn_AdjustStock;
		private System.ComponentModel.IContainer components = null;

		#endregion 

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_Stock_Close_DS));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_MakeStock = new System.Windows.Forms.Button();
            this.btn_AdjustStock = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_stockMM = new C1.Win.C1List.C1Combo();
            this.cmb_stockYY = new C1.Win.C1List.C1Combo();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.txt_TotQty = new System.Windows.Forms.TextBox();
            this.lbl_TotQty = new System.Windows.Forms.Label();
            this.ctx_grid = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_allDeselect = new System.Windows.Forms.MenuItem();
            this.btn_cancel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(308, 23);
            this.lbl_MainTitle.Text = "Make Stock";
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.GridDefinition = "37.5:False:True;62.5:False:True;\t0.576368876080692:False:True;47.5504322766571:Fa" +
                "lse:True;0.576368876080692:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 160);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(8, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 100);
            this.panel3.TabIndex = 168;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_MakeStock);
            this.groupBox2.Controls.Add(this.btn_AdjustStock);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btn_MakeStock
            // 
            this.btn_MakeStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_MakeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MakeStock.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MakeStock.Location = new System.Drawing.Point(6, 9);
            this.btn_MakeStock.Name = "btn_MakeStock";
            this.btn_MakeStock.Size = new System.Drawing.Size(312, 32);
            this.btn_MakeStock.TabIndex = 4;
            this.btn_MakeStock.Text = "Make Stock";
            this.btn_MakeStock.UseVisualStyleBackColor = false;
            this.btn_MakeStock.Click += new System.EventHandler(this.btn_MakeStock_Click);
            // 
            // btn_AdjustStock
            // 
            this.btn_AdjustStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_AdjustStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdjustStock.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AdjustStock.Location = new System.Drawing.Point(6, 49);
            this.btn_AdjustStock.Name = "btn_AdjustStock";
            this.btn_AdjustStock.Size = new System.Drawing.Size(312, 32);
            this.btn_AdjustStock.TabIndex = 5;
            this.btn_AdjustStock.Text = "Adjust Stock";
            this.btn_AdjustStock.UseVisualStyleBackColor = false;
            this.btn_AdjustStock.Click += new System.EventHandler(this.btn_AdjustStock_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(8, 64);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(330, 100);
            this.pnl_main.TabIndex = 166;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_stockMM);
            this.groupBox1.Controls.Add(this.cmb_stockYY);
            this.groupBox1.Controls.Add(this.lbl_StockYm);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.txt_TotQty);
            this.groupBox1.Controls.Add(this.lbl_TotQty);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 60);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cmb_stockMM
            // 
            this.cmb_stockMM.AddItemSeparator = ';';
            this.cmb_stockMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockMM.Caption = "";
            this.cmb_stockMM.CaptionHeight = 17;
            this.cmb_stockMM.CaptionStyle = style25;
            this.cmb_stockMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockMM.ColumnCaptionHeight = 18;
            this.cmb_stockMM.ColumnFooterHeight = 18;
            this.cmb_stockMM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockMM.ContentHeight = 16;
            this.cmb_stockMM.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_stockMM.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockMM.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockMM.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockMM.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockMM.EditorHeight = 16;
            this.cmb_stockMM.EvenRowStyle = style26;
            this.cmb_stockMM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockMM.FooterStyle = style27;
            this.cmb_stockMM.HeadingStyle = style28;
            this.cmb_stockMM.HighLightRowStyle = style29;
            this.cmb_stockMM.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockMM.Images"))));
            this.cmb_stockMM.ItemHeight = 15;
            this.cmb_stockMM.Location = new System.Drawing.Point(216, 33);
            this.cmb_stockMM.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockMM.MaxDropDownItems = ((short)(12));
            this.cmb_stockMM.MaxLength = 32767;
            this.cmb_stockMM.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockMM.Name = "cmb_stockMM";
            this.cmb_stockMM.OddRowStyle = style30;
            this.cmb_stockMM.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockMM.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.SelectedStyle = style31;
            this.cmb_stockMM.Size = new System.Drawing.Size(104, 20);
            this.cmb_stockMM.Style = style32;
            this.cmb_stockMM.TabIndex = 583;
            this.cmb_stockMM.PropBag = resources.GetString("cmb_stockMM.PropBag");
            // 
            // cmb_stockYY
            // 
            this.cmb_stockYY.AddItemSeparator = ';';
            this.cmb_stockYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockYY.Caption = "";
            this.cmb_stockYY.CaptionHeight = 17;
            this.cmb_stockYY.CaptionStyle = style33;
            this.cmb_stockYY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockYY.ColumnCaptionHeight = 18;
            this.cmb_stockYY.ColumnFooterHeight = 18;
            this.cmb_stockYY.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockYY.ContentHeight = 16;
            this.cmb_stockYY.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_stockYY.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockYY.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockYY.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockYY.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockYY.EditorHeight = 16;
            this.cmb_stockYY.EvenRowStyle = style34;
            this.cmb_stockYY.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockYY.FooterStyle = style35;
            this.cmb_stockYY.HeadingStyle = style36;
            this.cmb_stockYY.HighLightRowStyle = style37;
            this.cmb_stockYY.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockYY.Images"))));
            this.cmb_stockYY.ItemHeight = 15;
            this.cmb_stockYY.Location = new System.Drawing.Point(110, 33);
            this.cmb_stockYY.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockYY.MaxDropDownItems = ((short)(5));
            this.cmb_stockYY.MaxLength = 32767;
            this.cmb_stockYY.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockYY.Name = "cmb_stockYY";
            this.cmb_stockYY.OddRowStyle = style38;
            this.cmb_stockYY.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockYY.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.SelectedStyle = style39;
            this.cmb_stockYY.Size = new System.Drawing.Size(105, 20);
            this.cmb_stockYY.Style = style40;
            this.cmb_stockYY.TabIndex = 582;
            this.cmb_stockYY.PropBag = resources.GetString("cmb_stockYY.PropBag");
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(8, 33);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 581;
            this.lbl_StockYm.Text = "Stock Date";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(110, 11);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 579;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 11);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 580;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TotQty
            // 
            this.txt_TotQty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TotQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_TotQty.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_TotQty.Location = new System.Drawing.Point(477, 60);
            this.txt_TotQty.MaxLength = 100;
            this.txt_TotQty.Name = "txt_TotQty";
            this.txt_TotQty.ReadOnly = true;
            this.txt_TotQty.Size = new System.Drawing.Size(195, 21);
            this.txt_TotQty.TabIndex = 578;
            // 
            // lbl_TotQty
            // 
            this.lbl_TotQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_TotQty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotQty.ImageIndex = 0;
            this.lbl_TotQty.ImageList = this.img_Label;
            this.lbl_TotQty.Location = new System.Drawing.Point(376, 60);
            this.lbl_TotQty.Name = "lbl_TotQty";
            this.lbl_TotQty.Size = new System.Drawing.Size(100, 21);
            this.lbl_TotQty.TabIndex = 183;
            this.lbl_TotQty.Text = "Total Quantity";
            this.lbl_TotQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctx_grid
            // 
            this.ctx_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_AllSelect,
            this.mnu_allDeselect});
            // 
            // mnu_AllSelect
            // 
            this.mnu_AllSelect.Index = 0;
            this.mnu_AllSelect.Text = "All Select";
            // 
            // mnu_allDeselect
            // 
            this.mnu_allDeselect.Index = 1;
            this.mnu_allDeselect.Text = "All Deselect";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(270, 206);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 239;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Pop_BK_Stock_Close_DS
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(346, 239);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BK_Stock_Close_DS";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		#region 생성자 / 소멸자

		public Pop_BK_Stock_Close_DS()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();
		} 

 

		
		private string _Factory  = "";
		private string _Stock_YY  = "";
		private string _Stock_MM  = "";
		private string _Upd_user  = "";

		public Pop_BK_Stock_Close_DS(string arg_factory, string arg_stock_yy, string arg_stock_mm, string arg_upd_user)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory  = arg_factory;
			_Stock_YY  = arg_stock_yy;
			_Stock_MM  = arg_stock_mm;
			_Upd_user  = arg_upd_user;

			Init_Form();
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

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();   

		#endregion 

		#region 메써드 
		private void Init_Form()
		{


			DataTable vDt = null;


			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_factory.SelectedValue = _Factory;



          
			vDt = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxYear);
			ClassLib.ComCtl.Set_ComboList_AddItem(vDt,cmb_stockYY, false, 2, 2,0,150 );
            cmb_stockYY.SelectedValue = _Stock_YY;
			


			// StockMM add Items
			cmb_stockMM.AddItemTitles("Code");
			cmb_stockMM.ValueMember = "Code"; 

			for (int i = 1; i <= 12; i++)
			{
				cmb_stockMM.AddItem(i.ToString().PadLeft(2,'0'));
			}

			cmb_stockMM.MaxDropDownItems = 10;
			cmb_stockMM.SelectedValue = _Stock_MM;
            

		}


		#endregion 

		#region 버튼이벤트
		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_MakeStock_Click(object sender, System.EventArgs e)
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;

                if (Convert.ToInt32((cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString())) < 201000)
                { ClassLib.ComFunction.User_Message("Stock Month is wrong ", "btn_MakeStock_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }


				if (RUN_STOCK_MAKE(cmb_factory.SelectedValue.ToString(), cmb_stockYY.SelectedValue.ToString(), cmb_stockMM.SelectedValue.ToString(),_Upd_user, "C") ==true)

                    ClassLib.ComFunction.User_Message("Job Finish..");
                else
                    ClassLib.ComFunction.User_Message("Error");
                 
                 

                

               
 			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_MakeStock_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}

		}


		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		


		private void btn_AdjustStock_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				this.Cursor = Cursors.WaitCursor;

                if (Convert.ToInt32((cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString())) < 201000)
                {ClassLib.ComFunction.User_Message("Stock Month is wrong ", "btn_AdjustStock_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;}


                if (RUN_STOCK_MAKE(cmb_factory.SelectedValue.ToString(), cmb_stockYY.SelectedValue.ToString(), cmb_stockMM.SelectedValue.ToString(), _Upd_user, "A") == true)

                    ClassLib.ComFunction.User_Message("Job Finish..");
                else
                    ClassLib.ComFunction.User_Message("Error");
                 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_AdjustStock_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}

		}

		

		

		



		#endregion 

		#region 데이타

		private bool RUN_STOCK_MAKE(string arg_factory, 
			string arg_stock_yy, 
			string arg_stock_mm, 
			string arg_upd_user,
			string arg_flag)
		{

			try
			{
	 
				DataSet ds_ret; 

				int col_ct = 5;    
					 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBK_STOCK.RUN_STOCK_MAKE";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_STOCK_YY"; 
				MyOraDB.Parameter_Name[2] = "ARG_STOCK_MM"; 
				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[4] = "ARG_JOB_DIV"; 


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

					 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_stock_yy;
				MyOraDB.Parameter_Values[2] = arg_stock_mm;
				MyOraDB.Parameter_Values[3] = arg_upd_user; 
				MyOraDB.Parameter_Values[4] = arg_flag; 
	 
				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}


			}
			catch
			{
				return false;
			}


		}



		#endregion 

	

	
		
		

	}
}

