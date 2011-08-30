namespace FlexCosting.Basic.Frm
{
    partial class Form_Nike_Standard_Defective_Rate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nike_Standard_Defective_Rate));
            this.sizer_Main = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_head = new COM.FSP();
            this.fgrid_tail = new COM.FSP();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.btn_New = new System.Windows.Forms.Label();
            this.dpick_appDate = new System.Windows.Forms.DateTimePicker();
            this.txt_contents = new System.Windows.Forms.TextBox();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_appDate = new System.Windows.Forms.Label();
            this.searchPanel1 = new FlexCosting.Basic.Ctl.SearchPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).BeginInit();
            this.sizer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).BeginInit();
            this.pnl_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
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
            // sizer_Main
            // 
            this.sizer_Main.Controls.Add(this.fgrid_head);
            this.sizer_Main.Controls.Add(this.fgrid_tail);
            this.sizer_Main.Controls.Add(this.pnl_search);
            this.sizer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizer_Main.GridDefinition = "17.7304964539007:False:False;12.0567375886525:False:True;66.6666666666667:False:F" +
                "alse;0:False:True;\t0:False:True;98.4251968503937:False:False;0:False:True;";
            this.sizer_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sizer_Main.Location = new System.Drawing.Point(0, 80);
            this.sizer_Main.Name = "sizer_Main";
            this.sizer_Main.Size = new System.Drawing.Size(1016, 564);
            this.sizer_Main.TabIndex = 31;
            this.sizer_Main.TabStop = false;
            // 
            // fgrid_head
            // 
            this.fgrid_head.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_head.Location = new System.Drawing.Point(8, 4);
            this.fgrid_head.Name = "fgrid_head";
            this.fgrid_head.Rows.DefaultSize = 19;
            this.fgrid_head.Size = new System.Drawing.Size(1000, 100);
            this.fgrid_head.StyleInfo = resources.GetString("fgrid_head.StyleInfo");
            this.fgrid_head.TabIndex = 3;
            this.fgrid_head.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_head_MouseUp);
            // 
            // fgrid_tail
            // 
            this.fgrid_tail.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_tail.Location = new System.Drawing.Point(8, 180);
            this.fgrid_tail.Name = "fgrid_tail";
            this.fgrid_tail.Rows.DefaultSize = 19;
            this.fgrid_tail.Size = new System.Drawing.Size(1000, 376);
            this.fgrid_tail.StyleInfo = resources.GetString("fgrid_tail.StyleInfo");
            this.fgrid_tail.TabIndex = 1;
            this.fgrid_tail.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_tail_AfterEdit);
            this.fgrid_tail.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_tail_BeforeEdit);
            // 
            // pnl_search
            // 
            this.pnl_search.Controls.Add(this.btn_New);
            this.pnl_search.Controls.Add(this.dpick_appDate);
            this.pnl_search.Controls.Add(this.txt_contents);
            this.pnl_search.Controls.Add(this.lbl_contents);
            this.pnl_search.Controls.Add(this.lbl_title);
            this.pnl_search.Controls.Add(this.lbl_appDate);
            this.pnl_search.Controls.Add(this.searchPanel1);
            this.pnl_search.Location = new System.Drawing.Point(8, 108);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(1000, 68);
            this.pnl_search.TabIndex = 2;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.ImageIndex = 0;
            this.btn_New.ImageList = this.img_Button;
            this.btn_New.Location = new System.Drawing.Point(904, 36);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(80, 23);
            this.btn_New.TabIndex = 642;
            this.btn_New.Text = "New";
            this.btn_New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // dpick_appDate
            // 
            this.dpick_appDate.Location = new System.Drawing.Point(109, 36);
            this.dpick_appDate.Name = "dpick_appDate";
            this.dpick_appDate.Size = new System.Drawing.Size(210, 22);
            this.dpick_appDate.TabIndex = 602;
            this.dpick_appDate.CloseUp += new System.EventHandler(this.dpick_appDate_CloseUp);
            // 
            // txt_contents
            // 
            this.txt_contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contents.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_contents.Location = new System.Drawing.Point(437, 36);
            this.txt_contents.MaxLength = 40;
            this.txt_contents.Name = "txt_contents";
            this.txt_contents.Size = new System.Drawing.Size(210, 21);
            this.txt_contents.TabIndex = 601;
            // 
            // lbl_contents
            // 
            this.lbl_contents.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contents.ImageIndex = 0;
            this.lbl_contents.ImageList = this.img_Label;
            this.lbl_contents.Location = new System.Drawing.Point(336, 36);
            this.lbl_contents.Name = "lbl_contents";
            this.lbl_contents.Size = new System.Drawing.Size(100, 21);
            this.lbl_contents.TabIndex = 600;
            this.lbl_contents.Tag = "0";
            this.lbl_contents.Text = "Contents";
            this.lbl_contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 595;
            this.lbl_title.Text = "      Search Condition";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_appDate
            // 
            this.lbl_appDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appDate.ImageIndex = 1;
            this.lbl_appDate.ImageList = this.img_Label;
            this.lbl_appDate.Location = new System.Drawing.Point(8, 36);
            this.lbl_appDate.Name = "lbl_appDate";
            this.lbl_appDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_appDate.TabIndex = 353;
            this.lbl_appDate.Tag = "0";
            this.lbl_appDate.Text = "App date";
            this.lbl_appDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.Transparent;
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(1000, 68);
            this.searchPanel1.TabIndex = 0;
            // 
            // Form_Nike_Standard_Defective_Rate
            // 
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.sizer_Main);
            this.Name = "Form_Nike_Standard_Defective_Rate";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.sizer_Main, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizer_Main)).EndInit();
            this.sizer_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_tail)).EndInit();
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer sizer_Main;
        private COM.FSP fgrid_tail;
        private System.Windows.Forms.Panel pnl_search;
        public System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_appDate;
        private FlexCosting.Basic.Ctl.SearchPanel searchPanel1;
        private System.Windows.Forms.TextBox txt_contents;
        private System.Windows.Forms.Label lbl_contents;
        private COM.FSP fgrid_head;
        private System.Windows.Forms.DateTimePicker dpick_appDate;
        private System.Windows.Forms.Label btn_New;
    }
}
