namespace ERP.Menu
{
    partial class Pop_PC_Menu_Role
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_PC_Menu_Role));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.cmenu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.memuitem_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.cmb_LangCd = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_LangCd = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.img_Action = new System.Windows.Forms.ImageList(this.components);
            this.fgrid_Main = new COM.FSP();
            this.cmenu_Main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LangCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Text = "Menu Role";
            // 
            // cmenu_Main
            // 
            this.cmenu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memuitem_Insert,
            this.menuitem_Delete});
            this.cmenu_Main.Name = "cmenu_Main";
            this.cmenu_Main.Size = new System.Drawing.Size(111, 48);
            // 
            // memuitem_Insert
            // 
            this.memuitem_Insert.Name = "memuitem_Insert";
            this.memuitem_Insert.Size = new System.Drawing.Size(110, 22);
            this.memuitem_Insert.Text = "Insert";
            this.memuitem_Insert.Click += new System.EventHandler(this.memuitem_Insert_Click);
            // 
            // menuitem_Delete
            // 
            this.menuitem_Delete.Name = "menuitem_Delete";
            this.menuitem_Delete.Size = new System.Drawing.Size(110, 22);
            this.menuitem_Delete.Text = "Delete";
            this.menuitem_Delete.Click += new System.EventHandler(this.menuitem_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(318, 342);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 576;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(247, 342);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 23);
            this.btn_Apply.TabIndex = 575;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.cmb_LangCd);
            this.groupBox2.Controls.Add(this.cmb_Factory);
            this.groupBox2.Controls.Add(this.lbl_LangCd);
            this.groupBox2.Controls.Add(this.lbl_Factory);
            this.groupBox2.Location = new System.Drawing.Point(5, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 68);
            this.groupBox2.TabIndex = 574;
            this.groupBox2.TabStop = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.ImageList = this.img_Button;
            this.btn_Search.Location = new System.Drawing.Point(308, 37);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 23);
            this.btn_Search.TabIndex = 566;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Search.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_LangCd
            // 
            this.cmb_LangCd.AccessibleDescription = "";
            this.cmb_LangCd.AccessibleName = "";
            this.cmb_LangCd.AddItemCols = 0;
            this.cmb_LangCd.AddItemSeparator = ';';
            this.cmb_LangCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_LangCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LangCd.Caption = "";
            this.cmb_LangCd.CaptionHeight = 17;
            this.cmb_LangCd.CaptionStyle = style1;
            this.cmb_LangCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LangCd.ColumnCaptionHeight = 18;
            this.cmb_LangCd.ColumnFooterHeight = 18;
            this.cmb_LangCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LangCd.ContentHeight = 17;
            this.cmb_LangCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LangCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LangCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LangCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LangCd.EditorHeight = 17;
            this.cmb_LangCd.EvenRowStyle = style2;
            this.cmb_LangCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LangCd.FooterStyle = style3;
            this.cmb_LangCd.GapHeight = 2;
            this.cmb_LangCd.HeadingStyle = style4;
            this.cmb_LangCd.HighLightRowStyle = style5;
            this.cmb_LangCd.ItemHeight = 15;
            this.cmb_LangCd.Location = new System.Drawing.Point(108, 39);
            this.cmb_LangCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_LangCd.MaxDropDownItems = ((short)(5));
            this.cmb_LangCd.MaxLength = 32767;
            this.cmb_LangCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LangCd.Name = "cmb_LangCd";
            this.cmb_LangCd.OddRowStyle = style6;
            this.cmb_LangCd.PartialRightColumn = false;
            this.cmb_LangCd.PropBag = resources.GetString("cmb_LangCd.PropBag");
            this.cmb_LangCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LangCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LangCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LangCd.SelectedStyle = style7;
            this.cmb_LangCd.Size = new System.Drawing.Size(180, 21);
            this.cmb_LangCd.Style = style8;
            this.cmb_LangCd.TabIndex = 544;
            this.cmb_LangCd.SelectedValueChanged += new System.EventHandler(this.cmb_LangCd_SelectedValueChanged);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AccessibleDescription = "";
            this.cmb_Factory.AccessibleName = "";
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style9;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style10;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style11;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style12;
            this.cmb_Factory.HighLightRowStyle = style13;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(108, 17);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style14;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style15;
            this.cmb_Factory.Size = new System.Drawing.Size(180, 21);
            this.cmb_Factory.Style = style16;
            this.cmb_Factory.TabIndex = 543;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_LangCd
            // 
            this.lbl_LangCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_LangCd.ImageIndex = 0;
            this.lbl_LangCd.ImageList = this.img_Label;
            this.lbl_LangCd.Location = new System.Drawing.Point(7, 39);
            this.lbl_LangCd.Name = "lbl_LangCd";
            this.lbl_LangCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_LangCd.TabIndex = 542;
            this.lbl_LangCd.Text = "Language";
            this.lbl_LangCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 17);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 540;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Main.ContextMenuStrip = this.cmenu_Main;
            this.fgrid_Main.Location = new System.Drawing.Point(5, 110);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Size = new System.Drawing.Size(385, 225);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 578;
            this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
            this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
            // 
            // Pop_PC_Menu_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 375);
            this.Controls.Add(this.fgrid_Main);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox2);
            this.Name = "Pop_PC_Menu_Role";
            this.Text = "Menu Role";
            this.Load += new System.EventHandler(this.Pop_PC_Menu_Role_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.fgrid_Main, 0);
            this.cmenu_Main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LangCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btn_Cancel;
        private System.Windows.Forms.Label btn_Apply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label btn_Search;
        private C1.Win.C1List.C1Combo cmb_LangCd;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.Label lbl_LangCd;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.ContextMenuStrip cmenu_Main;
        private System.Windows.Forms.ToolStripMenuItem memuitem_Insert;
        private System.Windows.Forms.ToolStripMenuItem menuitem_Delete;
        public System.Windows.Forms.ImageList img_Action;
        private COM.FSP fgrid_Main;
    }
}