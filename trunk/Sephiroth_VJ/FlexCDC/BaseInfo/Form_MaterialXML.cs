using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Text;
using System.Threading;
using System.Net;
using System.Web;

namespace FlexCDC.BaseInfo
{
    public class Form_MaterialXML : COM.CDCWinForm.Form_Top
    {
        #region  컨트롤 정의 및 리소스정의
        public System.Windows.Forms.Panel pnl_Top;
        private C1.Win.C1List.C1Combo cmb_UpdateDate;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_factory;
        public System.Windows.Forms.Panel pnl_SearchImage;
        private C1.Win.C1List.C1Combo cmb_Vender;
        private System.Windows.Forms.Label lbl_Vender;
        private System.Windows.Forms.Label lbl_MatCd;
        private System.Windows.Forms.TextBox txt_MatName;
        private System.Windows.Forms.Label lbl_MatName;
        private System.Windows.Forms.Label btn_openfile;
        public System.Windows.Forms.PictureBox picb_MR;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel pnl_Body;
        public COM.FSP fgrid_Main;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label btn_Open_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private C1.Win.C1List.C1Combo cmb_Type;
        private TextBox txt_mat_code;
        private Label lbl_code;
        private System.ComponentModel.IContainer components = null;

        public Form_MaterialXML()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        #endregion

        #region 디자이너에서 생성한 코드
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MaterialXML));
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
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.cmb_Type = new C1.Win.C1List.C1Combo();
            this.cmb_UpdateDate = new C1.Win.C1List.C1Combo();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txt_mat_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.btn_Open_File = new System.Windows.Forms.Label();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Vender = new C1.Win.C1List.C1Combo();
            this.lbl_Vender = new System.Windows.Forms.Label();
            this.lbl_MatCd = new System.Windows.Forms.Label();
            this.txt_MatName = new System.Windows.Forms.TextBox();
            this.lbl_MatName = new System.Windows.Forms.Label();
            this.btn_openfile = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.FSP();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UpdateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
            // tbtn_New
            // 
            this.tbtn_New.Text = "";
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Text = "";
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click_1);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Text = "";
            // 
            // tbtn_Append
            // 
            this.tbtn_Append.Text = "";
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Text = "";
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Text = "";
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(64, 24);
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Text = "Confirm";
            // 
            // tbtn_Color
            // 
            this.tbtn_Color.Text = "";
            this.tbtn_Color.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Color_Click);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Text = "";
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.cmb_Type);
            this.pnl_Top.Controls.Add(this.cmb_UpdateDate);
            this.pnl_Top.Controls.Add(this.lbl_Data);
            this.pnl_Top.Controls.Add(this.cmb_Factory);
            this.pnl_Top.Controls.Add(this.lbl_factory);
            this.pnl_Top.Controls.Add(this.pnl_SearchImage);
            this.pnl_Top.Location = new System.Drawing.Point(0, 64);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.pnl_Top.Size = new System.Drawing.Size(1016, 120);
            this.pnl_Top.TabIndex = 135;
            // 
            // cmb_Type
            // 
            this.cmb_Type.AddItemCols = 0;
            this.cmb_Type.AddItemSeparator = ';';
            this.cmb_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Type.Caption = "";
            this.cmb_Type.CaptionHeight = 17;
            this.cmb_Type.CaptionStyle = style1;
            this.cmb_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Type.ColumnCaptionHeight = 18;
            this.cmb_Type.ColumnFooterHeight = 18;
            this.cmb_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Type.ContentHeight = 16;
            this.cmb_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Type.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Type.EditorHeight = 16;
            this.cmb_Type.EvenRowStyle = style2;
            this.cmb_Type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FooterStyle = style3;
            this.cmb_Type.GapHeight = 2;
            this.cmb_Type.HeadingStyle = style4;
            this.cmb_Type.HighLightRowStyle = style5;
            this.cmb_Type.ItemHeight = 15;
            this.cmb_Type.Location = new System.Drawing.Point(117, 58);
            this.cmb_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Type.MaxLength = 32767;
            this.cmb_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.OddRowStyle = style6;
            this.cmb_Type.PartialRightColumn = false;
            this.cmb_Type.PropBag = resources.GetString("cmb_Type.PropBag");
            this.cmb_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Type.SelectedStyle = style7;
            this.cmb_Type.Size = new System.Drawing.Size(200, 20);
            this.cmb_Type.Style = style8;
            this.cmb_Type.TabIndex = 346;
            // 
            // cmb_UpdateDate
            // 
            this.cmb_UpdateDate.AddItemCols = 0;
            this.cmb_UpdateDate.AddItemSeparator = ';';
            this.cmb_UpdateDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UpdateDate.Caption = "";
            this.cmb_UpdateDate.CaptionHeight = 17;
            this.cmb_UpdateDate.CaptionStyle = style9;
            this.cmb_UpdateDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UpdateDate.ColumnCaptionHeight = 18;
            this.cmb_UpdateDate.ColumnFooterHeight = 18;
            this.cmb_UpdateDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UpdateDate.ContentHeight = 16;
            this.cmb_UpdateDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UpdateDate.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UpdateDate.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UpdateDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UpdateDate.EditorHeight = 16;
            this.cmb_UpdateDate.EvenRowStyle = style10;
            this.cmb_UpdateDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_UpdateDate.FooterStyle = style11;
            this.cmb_UpdateDate.GapHeight = 2;
            this.cmb_UpdateDate.HeadingStyle = style12;
            this.cmb_UpdateDate.HighLightRowStyle = style13;
            this.cmb_UpdateDate.ItemHeight = 15;
            this.cmb_UpdateDate.Location = new System.Drawing.Point(453, 36);
            this.cmb_UpdateDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_UpdateDate.MaxDropDownItems = ((short)(5));
            this.cmb_UpdateDate.MaxLength = 32767;
            this.cmb_UpdateDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UpdateDate.Name = "cmb_UpdateDate";
            this.cmb_UpdateDate.OddRowStyle = style14;
            this.cmb_UpdateDate.PartialRightColumn = false;
            this.cmb_UpdateDate.PropBag = resources.GetString("cmb_UpdateDate.PropBag");
            this.cmb_UpdateDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UpdateDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UpdateDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UpdateDate.SelectedStyle = style15;
            this.cmb_UpdateDate.Size = new System.Drawing.Size(200, 20);
            this.cmb_UpdateDate.Style = style16;
            this.cmb_UpdateDate.TabIndex = 345;
            this.cmb_UpdateDate.SelectedValueChanged += new System.EventHandler(this.cmb_UpdateDate_SelectedValueChanged);
            // 
            // lbl_Data
            // 
            this.lbl_Data.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ImageIndex = 0;
            this.lbl_Data.ImageList = this.img_Label;
            this.lbl_Data.Location = new System.Drawing.Point(352, 36);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(100, 21);
            this.lbl_Data.TabIndex = 344;
            this.lbl_Data.Tag = "1";
            this.lbl_Data.Text = "Update";
            this.lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.Enabled = false;
            this.cmb_Factory.EvenRowStyle = style18;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style19;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style20;
            this.cmb_Factory.HighLightRowStyle = style21;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style22;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style23;
            this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_Factory.Style = style24;
            this.cmb_Factory.TabIndex = 272;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(16, 36);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 271;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txt_mat_code);
            this.pnl_SearchImage.Controls.Add(this.lbl_code);
            this.pnl_SearchImage.Controls.Add(this.btn_Open_File);
            this.pnl_SearchImage.Controls.Add(this.txt_Path);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.cmb_Vender);
            this.pnl_SearchImage.Controls.Add(this.lbl_Vender);
            this.pnl_SearchImage.Controls.Add(this.lbl_MatCd);
            this.pnl_SearchImage.Controls.Add(this.txt_MatName);
            this.pnl_SearchImage.Controls.Add(this.lbl_MatName);
            this.pnl_SearchImage.Controls.Add(this.btn_openfile);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.pictureBox2);
            this.pnl_SearchImage.Controls.Add(this.pictureBox3);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.pictureBox4);
            this.pnl_SearchImage.Controls.Add(this.pictureBox5);
            this.pnl_SearchImage.Controls.Add(this.pictureBox6);
            this.pnl_SearchImage.Controls.Add(this.pictureBox7);
            this.pnl_SearchImage.Controls.Add(this.pictureBox8);
            this.pnl_SearchImage.Controls.Add(this.pictureBox9);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 112);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txt_mat_code
            // 
            this.txt_mat_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mat_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_code.Location = new System.Drawing.Point(445, 58);
            this.txt_mat_code.Name = "txt_mat_code";
            this.txt_mat_code.Size = new System.Drawing.Size(200, 21);
            this.txt_mat_code.TabIndex = 548;
            // 
            // lbl_code
            // 
            this.lbl_code.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ImageIndex = 0;
            this.lbl_code.ImageList = this.img_Label;
            this.lbl_code.Location = new System.Drawing.Point(344, 58);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(100, 21);
            this.lbl_code.TabIndex = 547;
            this.lbl_code.Text = "Code";
            this.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Open_File
            // 
            this.btn_Open_File.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Open_File.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_File.Image = ((System.Drawing.Image)(resources.GetObject("btn_Open_File.Image")));
            this.btn_Open_File.Location = new System.Drawing.Point(288, 80);
            this.btn_Open_File.Name = "btn_Open_File";
            this.btn_Open_File.Size = new System.Drawing.Size(21, 21);
            this.btn_Open_File.TabIndex = 546;
            this.btn_Open_File.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Open_File.Click += new System.EventHandler(this.btn_Open_File_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Path.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_Path.ForeColor = System.Drawing.Color.Black;
            this.txt_Path.Location = new System.Drawing.Point(109, 80);
            this.txt_Path.MaxLength = 100;
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.ReadOnly = true;
            this.txt_Path.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Path.Size = new System.Drawing.Size(178, 20);
            this.txt_Path.TabIndex = 545;
            this.txt_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 544;
            this.label1.Text = "Path";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Vender
            // 
            this.cmb_Vender.AddItemCols = 0;
            this.cmb_Vender.AddItemSeparator = ';';
            this.cmb_Vender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vender.Caption = "";
            this.cmb_Vender.CaptionHeight = 17;
            this.cmb_Vender.CaptionStyle = style25;
            this.cmb_Vender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vender.ColumnCaptionHeight = 18;
            this.cmb_Vender.ColumnFooterHeight = 18;
            this.cmb_Vender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vender.ContentHeight = 16;
            this.cmb_Vender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vender.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vender.EditorHeight = 16;
            this.cmb_Vender.EvenRowStyle = style26;
            this.cmb_Vender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vender.FooterStyle = style27;
            this.cmb_Vender.GapHeight = 2;
            this.cmb_Vender.HeadingStyle = style28;
            this.cmb_Vender.HighLightRowStyle = style29;
            this.cmb_Vender.ItemHeight = 15;
            this.cmb_Vender.Location = new System.Drawing.Point(781, 36);
            this.cmb_Vender.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vender.MaxDropDownItems = ((short)(5));
            this.cmb_Vender.MaxLength = 32767;
            this.cmb_Vender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vender.Name = "cmb_Vender";
            this.cmb_Vender.OddRowStyle = style30;
            this.cmb_Vender.PartialRightColumn = false;
            this.cmb_Vender.PropBag = resources.GetString("cmb_Vender.PropBag");
            this.cmb_Vender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vender.SelectedStyle = style31;
            this.cmb_Vender.Size = new System.Drawing.Size(200, 20);
            this.cmb_Vender.Style = style32;
            this.cmb_Vender.TabIndex = 543;
            this.cmb_Vender.SelectedValueChanged += new System.EventHandler(this.cmb_Vender_SelectedValueChanged);
            // 
            // lbl_Vender
            // 
            this.lbl_Vender.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Vender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vender.ImageIndex = 0;
            this.lbl_Vender.ImageList = this.img_Label;
            this.lbl_Vender.Location = new System.Drawing.Point(680, 36);
            this.lbl_Vender.Name = "lbl_Vender";
            this.lbl_Vender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Vender.TabIndex = 542;
            this.lbl_Vender.Tag = "1";
            this.lbl_Vender.Text = "Vender";
            this.lbl_Vender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_MatCd
            // 
            this.lbl_MatCd.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_MatCd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatCd.ImageIndex = 0;
            this.lbl_MatCd.ImageList = this.img_Label;
            this.lbl_MatCd.Location = new System.Drawing.Point(8, 58);
            this.lbl_MatCd.Name = "lbl_MatCd";
            this.lbl_MatCd.Size = new System.Drawing.Size(100, 21);
            this.lbl_MatCd.TabIndex = 540;
            this.lbl_MatCd.Text = "Type";
            this.lbl_MatCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MatName
            // 
            this.txt_MatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatName.Location = new System.Drawing.Point(781, 58);
            this.txt_MatName.Name = "txt_MatName";
            this.txt_MatName.Size = new System.Drawing.Size(200, 21);
            this.txt_MatName.TabIndex = 539;
            this.txt_MatName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_MatName_KeyUp);
            // 
            // lbl_MatName
            // 
            this.lbl_MatName.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatName.ImageIndex = 0;
            this.lbl_MatName.ImageList = this.img_Label;
            this.lbl_MatName.Location = new System.Drawing.Point(680, 58);
            this.lbl_MatName.Name = "lbl_MatName";
            this.lbl_MatName.Size = new System.Drawing.Size(100, 21);
            this.lbl_MatName.TabIndex = 538;
            this.lbl_MatName.Text = "Name";
            this.lbl_MatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_openfile
            // 
            this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
            this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfile.Location = new System.Drawing.Point(426, 36);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(21, 21);
            this.btn_openfile.TabIndex = 112;
            this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(983, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(24, 69);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 32);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
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
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "       Material Information";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(984, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(136, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 97);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(168, 20);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 79);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(152, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(472, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1000, 72);
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Body.Controls.Add(this.fgrid_Main);
            this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Body.Location = new System.Drawing.Point(0, 183);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1016, 461);
            this.pnl_Body.TabIndex = 136;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fgrid_Main.AutoResize = false;
            this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
            this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Rows.Fixed = 0;
            this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Main.Size = new System.Drawing.Size(1016, 461);
            this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_Main.Styles"));
            this.fgrid_Main.TabIndex = 318;
            // 
            // Form_MaterialXML
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Form_MaterialXML";
            this.Load += new System.EventHandler(this.Form_MaterialXML_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UpdateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region  사용자 정의 변수

        private COM.OraDB MyOraDB = new COM.OraDB();
        private Pop_BS_Shipping_List_Wait _pop = null;
        DataSet _newDataSet;

        #endregion

        #region 공통 메서드
        private void Init_Form()
        {
            this.Text = "PCC_Nike Mat. Upload";
            this.lbl_MainTitle.Text = "PCC_Nike Mat. Upload";
            this.lbl_title.Text = "      Mat. Information";

            COM.ComFunction.SetLangDic(this);

            #region Button Setting
            tbtn_Append.Enabled = false;
            tbtn_Delete.Enabled = false;
            tbtn_Insert.Enabled = false;
            tbtn_Save.Enabled = false;
            tbtn_Create.Enabled = false;
            tbtn_Print.Enabled = false;
            tbtn_Color.Enabled = false;
            #endregion

            #region ComboBox Setting
            //modifyed date			
            DataTable dt_list = Select_Modify_Date(cmb_Factory.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(dt_list, cmb_UpdateDate, 0, 0, true, 0, 200);
            cmb_UpdateDate.SelectedIndex = 1;

            //Vendor 
            dt_list = Select_Mat_Vender(cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_Combo(cmb_UpdateDate, ""));
            COM.ComCtl.Set_ComboList(dt_list, cmb_Vender, 0, 1, true, 0, 200);
            cmb_Vender.SelectedIndex = 0;

            //MAT TYPE Setting
            dt_list = Select_Mat_Type_List();
            COM.ComCtl.Set_ComboList(dt_list, cmb_Type, 0, 0, true, 0, 200);
            cmb_Type.SelectedIndex = 0;

            dt_list.Dispose();
            #endregion

            #region Grid Setting

            fgrid_Main.Set_Grid_CDC("SXB_SRF_MAT_TAIL", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Main.Set_Action_Image(img_Action);
            fgrid_Main.Font = new Font("Verdana", 8);
            fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

            #endregion

            #region TextBox Setting
            txt_MatName.CharacterCasing = CharacterCasing.Upper;
            txt_MatName.Focus();
            #endregion


            if (ClassLib.ComVar.This_CDCPower_Level.ToString().Substring(0, 1) != "P" && ClassLib.ComVar.This_CDCPower_Level != "S00")
            {
                tbtn_Color.Enabled = false;
                btn_Open_File.Enabled = false;

            }
             
        }
        private void Display_FlexGrid(COM.FSP arg_grid, DataTable arg_dt)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                int vFixed = arg_grid.Rows.Fixed;
                arg_grid.Rows.Count = vFixed;


                for (int vRow = 0; vRow < arg_dt.Rows.Count; vRow++)
                {
                    arg_grid.AddItem(arg_dt.Rows[vRow].ItemArray, arg_grid.Rows.Fixed + vRow, 1);
                    arg_grid[arg_grid.Rows.Fixed + vRow, 0] = "";
                }

            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }


        }
        private void Set_Merge_Col()
        {

            fgrid_Main.AllowMerging = AllowMergingEnum.Free;
            fgrid_Main.Rows[1].AllowMerging = true;

            for (int i = (int)FlexCDC.ClassLib.TBSXB_SRF_MAT_TAIL.IxFACTORY; i < (int)FlexCDC.ClassLib.TBSXB_SRF_MAT_TAIL.IxMAT_DESCRIPTION; i++)
                fgrid_Main.Cols[i].AllowMerging = true;

        }
        private void OpenFile_Threading()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Read the XML document back in. 
                // Create new FileStream to read schema with. //
                System.IO.FileStream fsReadXml = new System.IO.FileStream(txt_Path.Text, System.IO.FileMode.Open);

                // Create an XmlTextReader to read the file. //
                System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

                // Read the XML document into the DataSet. //
                _newDataSet.ReadXml(myXmlReader);               

                // Close the XmlTextReader //
                myXmlReader.Close();

            }
            catch (Exception ex)
            {

                // this.Cursor = Cursors.Default;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //this.Cursor = Cursors.Default;
                _pop.Close();
            }

        }
        #endregion

        #region 이벤트 처리

        #region Control Event
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Factory.SelectedIndex == -1)
                    return;

                COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

                Init_Form();
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void cmb_UpdateDate_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_UpdateDate.SelectedValue != null || cmb_UpdateDate.SelectedIndex != -1)
                {
                    //Vendor 
                    DataTable dt_list = Select_Mat_Vender(cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_Combo(cmb_UpdateDate, ""));
                    COM.ComCtl.Set_ComboList(dt_list, cmb_Vender, 0, 1, true, 0, 200);
                    cmb_Vender.SelectedIndex = 0;
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void cmb_Vender_SelectedValueChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_Vender.SelectedValue != null || cmb_Vender.SelectedIndex != -1)
                {
                    //MAT TYPE Setting
                    DataTable dt_ret = Select_Mat_Type_List();
                    COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
                    cmb_Type.SelectedIndex = 0;
                }

            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void txt_MatName_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyData == Keys.Enter)
                {
                    //MAT TYPE Setting
                    DataTable dt_ret = Select_Mat_Type_List();
                    COM.ComCtl.Set_ComboList(dt_ret, cmb_Type, 0, 0, true, 0, 200);
                    cmb_Type.SelectedIndex = 0;
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }
        private void btn_Open_File_Click(object sender, System.EventArgs e)
        {
            try
            {
                _newDataSet = new DataSet("New DataSet");
                txt_Path.Clear();

                openFileDialog1.InitialDirectory = "";

                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    txt_Path.Text = "";
                    return;
                }
                txt_Path.Text = openFileDialog1.FileName;

                // Threading //
                _pop = new Pop_BS_Shipping_List_Wait();
                Thread vCreate = new Thread(new ThreadStart(OpenFile_Threading));

                vCreate.Start();
                _pop.Start();

                _pop.Close();

                if (cmb_UpdateDate.Text.Trim() != "ALL")
                {
                    COM.ComVar.ConsCDC_MaterialXML_Factory = cmb_Factory.SelectedValue.ToString();
                    COM.ComVar.ConsCDC_MaterialXML_UpdDate = cmb_UpdateDate.SelectedValue.ToString();

                    Pop_MaterialXML_Load Pop_Save = new Pop_MaterialXML_Load();
                    Pop_Save._newDataSet = _newDataSet;
                    Pop_Save.ShowDialog();
                }
                else
                {
                    COM.ComFunction.User_Message(" Modify Date ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //modifyed date			
                DataTable dt_list = Select_Modify_Date(cmb_Factory.SelectedValue.ToString());
                COM.ComCtl.Set_ComboList(dt_list, cmb_UpdateDate, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
                cmb_UpdateDate.SelectedIndex = 1;
            }
            catch
            {

            }
        }
        #endregion

        #region tbtn Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            cmb_UpdateDate.SelectedIndex = 1;
            txt_MatName.Clear();
            Init_Form();
        }
        private void tbtn_Search_Click_1(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataSet dt_ret = Select_Material_List();

                fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

                if (dt_ret.Tables[0].Rows.Count != 0)
                    Display_FlexGrid(fgrid_Main, dt_ret.Tables[0]);

                Set_Merge_Col();
                dt_ret.Dispose();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }

        }
        private void tbtn_Color_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (cmb_UpdateDate.Text.Trim() != "ALL")
                {

                    COM.ComVar.ConsCDC_MaterialXML_Factory = cmb_Factory.SelectedValue.ToString();
                    COM.ComVar.ConsCDC_MaterialXML_UpdDate = cmb_UpdateDate.SelectedValue.ToString();

                    FlexCDC.BaseInfo.Pop_MaterialXML_Load XML_Load = new FlexCDC.BaseInfo.Pop_MaterialXML_Load();
                    XML_Load.ShowDialog();
                    Init_Form();

                }
                else
                {
                    COM.ComFunction.User_Message(" Modify Date ", "tbtn_Color_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
            }

        }
        #endregion

        #endregion

        #region DB 컨트롤
        private DataTable Select_Modify_Date(string arg_factory)
        {

            MyOraDB.ReDim_Parameter(2);

            MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_MAT_DATE";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_Mat_Vender(string arg_factory, string arg_modify_date)
        {

            MyOraDB.ReDim_Parameter(3);

            MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_MAT_VENDER";

            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODIFY_DATE";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_modify_date;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

            if (ds_ret == null) return null;
            return ds_ret.Tables[MyOraDB.Process_Name];
        }

        private DataTable Select_Mat_Type_List()
        {
            MyOraDB.ReDim_Parameter(5);

            //01.PROCEDURE명
            MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_MAT_TYPE";

            //02.ARGURMENT 명
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_MODIFY_DATE";
            MyOraDB.Parameter_Name[2] = "ARG_VENDOR";
            MyOraDB.Parameter_Name[3] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

            //03.DATA TYPE 정의
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

            //04.DATA 정의
            MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_Combo(cmb_UpdateDate, "");
            MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_Vender, "");
            MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_MatName, "");
            MyOraDB.Parameter_Values[4] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet ds_list = MyOraDB.Exe_Select_Procedure();

            return ds_list.Tables[MyOraDB.Process_Name];
        }

        private DataSet Select_Material_List()
        {

            try
            {

                DataSet ds_ret;

                string process_name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_MAT_LOAD";

                MyOraDB.ReDim_Parameter(7);

                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODIFY_YMD";
                MyOraDB.Parameter_Name[2] = "ARG_VENDER";
                MyOraDB.Parameter_Name[3] = "ARG_MAT_TYPE";
                MyOraDB.Parameter_Name[4] = "ARG_MAT_CODE";
                MyOraDB.Parameter_Name[5] = "ARG_MAT_NAME";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_UpdateDate, "");
                MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Vender, "");
                MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_Type, " ");
                MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_mat_code, "");
                MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_MatName, "");                
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;

                return ds_ret;

            }
            catch
            {
                return null;
            }


        }


        #endregion

        private void Form_MaterialXML_Load(object sender, System.EventArgs e)
        {
            try
            {
                //factory 
                DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
                cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
                cmb_Factory.Enabled = true;
            }
            catch
            {

            }
        }

    }

}

