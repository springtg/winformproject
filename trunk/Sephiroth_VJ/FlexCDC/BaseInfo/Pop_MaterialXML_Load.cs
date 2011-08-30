using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Threading;
using System.Data;
using System.Net;
using System.Web;
using System.Data.OracleClient;



namespace FlexCDC.BaseInfo
{
    public class Pop_MaterialXML_Load : COM.CDCWinForm.Pop_Small
    {
        #region  컨트롤 정의 및 리소스정의
        private System.Windows.Forms.ImageList img_MiniButton;
        private System.Windows.Forms.ProgressBar pgb_LoadingStatus;
        private System.Windows.Forms.TextBox txt_Err;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_body;
        private System.Windows.Forms.GroupBox grb_LoadingStatus;
        private C1.Win.C1List.C1Combo cmb_Factory;
        public System.Windows.Forms.PictureBox pictureBox46;
        private C1.Win.C1List.C1Combo cmb_UpdateDate;
        public System.Windows.Forms.PictureBox pictureBox45;
        public System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.Label lbl_factory;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Data;
        public System.Windows.Forms.PictureBox pictureBox50;
        public System.Windows.Forms.PictureBox pictureBox49;
        public System.Windows.Forms.PictureBox pictureBox51;
        public System.Windows.Forms.PictureBox pictureBox47;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.Label btn_apply;
        private System.Windows.Forms.Label lbl_Cancel;
        private System.ComponentModel.IContainer components = null;

        public Pop_MaterialXML_Load()
        {
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
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_MaterialXML_Load));
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Count = new System.Windows.Forms.Label();
            this.pgb_LoadingStatus = new System.Windows.Forms.ProgressBar();
            this.txt_Err = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_UpdateDate = new C1.Win.C1List.C1Combo();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.grb_LoadingStatus = new System.Windows.Forms.GroupBox();
            this.btn_apply = new System.Windows.Forms.Label();
            this.lbl_Cancel = new System.Windows.Forms.Label();
            this.pnl_Top.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UpdateDate)).BeginInit();
            this.pnl_body.SuspendLayout();
            this.grb_LoadingStatus.SuspendLayout();
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
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_Count
            // 
            this.lbl_Count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(6, 20);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(363, 18);
            this.lbl_Count.TabIndex = 353;
            this.lbl_Count.Text = "0/0";
            this.lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgb_LoadingStatus
            // 
            this.pgb_LoadingStatus.Location = new System.Drawing.Point(6, 41);
            this.pgb_LoadingStatus.Name = "pgb_LoadingStatus";
            this.pgb_LoadingStatus.Size = new System.Drawing.Size(363, 8);
            this.pgb_LoadingStatus.TabIndex = 355;
            // 
            // txt_Err
            // 
            this.txt_Err.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txt_Err.Location = new System.Drawing.Point(6, 56);
            this.txt_Err.Multiline = true;
            this.txt_Err.Name = "txt_Err";
            this.txt_Err.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Err.Size = new System.Drawing.Size(362, 233);
            this.txt_Err.TabIndex = 356;
            this.txt_Err.Text = "";
            // 
            // pnl_Top
            // 
            this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Top.Controls.Add(this.panel2);
            this.pnl_Top.DockPadding.Bottom = 5;
            this.pnl_Top.Location = new System.Drawing.Point(2, 48);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(370, 92);
            this.pnl_Top.TabIndex = 360;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.pictureBox44);
            this.panel2.Controls.Add(this.pictureBox45);
            this.panel2.Controls.Add(this.cmb_Factory);
            this.panel2.Controls.Add(this.cmb_UpdateDate);
            this.panel2.Controls.Add(this.pictureBox48);
            this.panel2.Controls.Add(this.lbl_factory);
            this.panel2.Controls.Add(this.lbl_Data);
            this.panel2.Controls.Add(this.pictureBox50);
            this.panel2.Controls.Add(this.pictureBox51);
            this.panel2.Controls.Add(this.pictureBox49);
            this.panel2.Controls.Add(this.pictureBox46);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox47);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 87);
            this.panel2.TabIndex = 20;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox44.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox44.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
            this.pictureBox44.Location = new System.Drawing.Point(355, 24);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(16, 55);
            this.pictureBox44.TabIndex = 26;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox45.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(354, 0);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(16, 32);
            this.pictureBox45.TabIndex = 21;
            this.pictureBox45.TabStop = false;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.Enabled = false;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(110, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
                "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
                "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
                "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
                "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
                "8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
                "lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
                "Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
                "xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
                "<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
                "umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
                "ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
                "dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
                "t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
                "le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
                "ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
                " me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
                "t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
                "0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
                "tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
                "Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
                "er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
                "e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
                "Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
                "/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
                "p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
                "odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.Size = new System.Drawing.Size(243, 20);
            this.cmb_Factory.TabIndex = 347;
            // 
            // cmb_UpdateDate
            // 
            this.cmb_UpdateDate.AddItemCols = 0;
            this.cmb_UpdateDate.AddItemSeparator = ';';
            this.cmb_UpdateDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_UpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_UpdateDate.Caption = "";
            this.cmb_UpdateDate.CaptionHeight = 17;
            this.cmb_UpdateDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_UpdateDate.ColumnCaptionHeight = 18;
            this.cmb_UpdateDate.ColumnFooterHeight = 18;
            this.cmb_UpdateDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_UpdateDate.ContentHeight = 16;
            this.cmb_UpdateDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_UpdateDate.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_UpdateDate.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmb_UpdateDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_UpdateDate.EditorHeight = 16;
            this.cmb_UpdateDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.cmb_UpdateDate.GapHeight = 2;
            this.cmb_UpdateDate.ItemHeight = 15;
            this.cmb_UpdateDate.Location = new System.Drawing.Point(110, 54);
            this.cmb_UpdateDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_UpdateDate.MaxDropDownItems = ((short)(5));
            this.cmb_UpdateDate.MaxLength = 32767;
            this.cmb_UpdateDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_UpdateDate.Name = "cmb_UpdateDate";
            this.cmb_UpdateDate.PartialRightColumn = false;
            this.cmb_UpdateDate.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
                "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
                "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
                "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
                "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
                "8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
                "lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
                "Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
                "xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
                "<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
                "umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
                "ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
                "dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
                "t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
                "le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
                "ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
                " me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
                "t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
                "0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
                "tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
                "Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
                "er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
                "e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
                "Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
                "/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
                "p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
                "odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
            this.cmb_UpdateDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_UpdateDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_UpdateDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_UpdateDate.Size = new System.Drawing.Size(243, 20);
            this.cmb_UpdateDate.TabIndex = 349;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox48.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
            this.pictureBox48.Location = new System.Drawing.Point(354, 71);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(16, 16);
            this.pictureBox48.TabIndex = 23;
            this.pictureBox48.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 32);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 20);
            this.lbl_factory.TabIndex = 346;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Data
            // 
            this.lbl_Data.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Data.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lbl_Data.ImageIndex = 2;
            this.lbl_Data.ImageList = this.img_Label;
            this.lbl_Data.Location = new System.Drawing.Point(8, 54);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(100, 20);
            this.lbl_Data.TabIndex = 348;
            this.lbl_Data.Tag = "1";
            this.lbl_Data.Text = "Update Date";
            this.lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox50.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
            this.pictureBox50.Location = new System.Drawing.Point(0, 67);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(168, 20);
            this.pictureBox50.TabIndex = 22;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox51.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
            this.pictureBox51.Location = new System.Drawing.Point(0, 24);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(168, 47);
            this.pictureBox51.TabIndex = 25;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox49.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox49.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
            this.pictureBox49.Location = new System.Drawing.Point(144, 69);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(210, 18);
            this.pictureBox49.TabIndex = 24;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox46.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
            this.pictureBox46.Location = new System.Drawing.Point(217, 0);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(138, 39);
            this.pictureBox46.TabIndex = 0;
            this.pictureBox46.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "       Material XML Load";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox47.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox47.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
            this.pictureBox47.Location = new System.Drawing.Point(2, 24);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(366, 47);
            this.pictureBox47.TabIndex = 27;
            this.pictureBox47.TabStop = false;
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_body.Controls.Add(this.grb_LoadingStatus);
            this.pnl_body.Location = new System.Drawing.Point(0, 141);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(376, 296);
            this.pnl_body.TabIndex = 361;
            // 
            // grb_LoadingStatus
            // 
            this.grb_LoadingStatus.BackColor = System.Drawing.SystemColors.Window;
            this.grb_LoadingStatus.Controls.Add(this.lbl_Count);
            this.grb_LoadingStatus.Controls.Add(this.pgb_LoadingStatus);
            this.grb_LoadingStatus.Controls.Add(this.txt_Err);
            this.grb_LoadingStatus.Location = new System.Drawing.Point(2, 0);
            this.grb_LoadingStatus.Name = "grb_LoadingStatus";
            this.grb_LoadingStatus.Size = new System.Drawing.Size(374, 296);
            this.grb_LoadingStatus.TabIndex = 357;
            this.grb_LoadingStatus.TabStop = false;
            this.grb_LoadingStatus.Text = "Loading Status";
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
            this.btn_apply.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.btn_apply.ImageIndex = 1;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(232, 438);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 362;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_Cancel
            // 
            this.lbl_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
            this.lbl_Cancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lbl_Cancel.ImageIndex = 1;
            this.lbl_Cancel.ImageList = this.img_Button;
            this.lbl_Cancel.Location = new System.Drawing.Point(305, 438);
            this.lbl_Cancel.Name = "lbl_Cancel";
            this.lbl_Cancel.Size = new System.Drawing.Size(70, 24);
            this.lbl_Cancel.TabIndex = 363;
            this.lbl_Cancel.Text = "Cancel";
            this.lbl_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Cancel.Click += new System.EventHandler(this.lbl_Cancel_Click);
            // 
            // Pop_MaterialXML_Load
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(376, 462);
            this.Controls.Add(this.lbl_Cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "Pop_MaterialXML_Load";
            this.Load += new System.EventHandler(this.Pop_MaterialXML_Load_Load);
            this.Controls.SetChildIndex(this.pnl_Top, 0);
            this.Controls.SetChildIndex(this.pnl_body, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.lbl_Cancel, 0);
            this.pnl_Top.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_UpdateDate)).EndInit();
            this.pnl_body.ResumeLayout(false);
            this.grb_LoadingStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region 사용자 정의 변수

        private COM.OraDB MyOraDB = new COM.OraDB();
        public DataSet _newDataSet;
        private Pop_BS_Shipping_List_Wait _pop = null;
        // Save_MAT_Tail_Load()
        int _StartRow;
        int vSaveCount;

        #endregion

        #region 공통메서드

        private void Init_Form()
        {

            this.Text = "Material XML Loading";
            lbl_MainTitle.Text = "Material XML Loading";

            #region TextBox Setting
            // XML Format Display --> txt_Err.Text //
            txt_Err.ReadOnly = true;
            txt_Err.BackColor = Color.White;
            txt_Err.Text = "[ XML FORMAT ] " + "\r\n"
                         + "< nike_materials > " + "\r\n"
                         + "1. First Table : nike_material" + "\r\n"
                         + "   Column Name :" + "\r\n"
                         + "                 nike_material_number " + "\r\n"
                         + "                 nike_material_name " + "\r\n"
                         + "                 nike_material_state " + "\r\n"
                         + "                 nike_material_type " + "\r\n"
                         + "                 nike_material_subType " + "\r\n"
                         + "                 nike_material_variation " + "\r\n"
                         + "                 nike_material_subVariation " + "\r\n"
                         + "                 nike_material_description " + "\r\n" + "\r\n"
                         + "2. Second Table : nike_suppliermaterial " + "\r\n"
                         + "   Column Name  :" + "\r\n"
                         + "                 nike_MxS_number " + "\r\n"
                         + "                 nike_MxS_name " + "\r\n"
                         + "                 nike_MxS_state " + "\r\n"
                         + "                 nike_MxS_MCS " + "\r\n"
                         + "                 nike_MxS_quotedPrice " + "\r\n"
                         + "                 nike_MxS_quotedCurrency " + "\r\n"
                         + "                 nike_MxS_quotedUOM " + "\r\n"
                         + "                 nike_MxS_deliveryTerm " + "\r\n"
                         + "                 nike_MxS_width " + "\r\n"
                         + "                 nike_MxS_widthUOM " + "\r\n"
                         + "                 nike_MxS_length " + "\r\n"
                         + "                 nike_MxS_lengthUOM " + "\r\n"
                         + "                 nike_MxS_thickness " + "\r\n"
                         + "                 nike_MxS_thicknessUOM " + "\r\n"
                         + "                 nike_MxS_locationCode " + "\r\n"
                         + "                 nike_MxS_locationName " + "\r\n"
                         + "                 nike_supplier_code " + "\r\n";
            #endregion

            #region ComboBox Setting
            // Factory Setting //
            DataTable dt_list = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = COM.ComVar.ConsCDC_MaterialXML_Factory;
            cmb_Factory.Enabled = false;

            // Modifyed Date Setting //	
            dt_list = Select_Modify_Date(cmb_Factory.SelectedValue.ToString());
            COM.ComCtl.Set_ComboList(dt_list, cmb_UpdateDate, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
            cmb_UpdateDate.SelectedValue = COM.ComVar.ConsCDC_MaterialXML_UpdDate;
            cmb_UpdateDate.Enabled = false;

            dt_list.Dispose();
            #endregion

            if (_newDataSet == null)
                this.Close();

            lbl_Count.Text = " 0 / " + _newDataSet.Tables[0].Rows.Count.ToString();

            lbl_Cancel.Focus();

        }

        public void XML_Save()
        {
            if (Save_Data())
            {
                //Confirm_Data();			
            }
        }

        private bool Save_Data()
        {
            try
            {
                _StartRow = 0;
                vSaveCount = 0;

                // Progress Bar Setting //
                pgb_LoadingStatus.Minimum = 0;
                pgb_LoadingStatus.Maximum = _newDataSet.Tables[0].Rows.Count;

                #region Data Check
                // 100단위로 Check & Save 
                if (Check_Save_Header())
                {
                    int vCutRowCount = 100, vRowCount = 1;
                    txt_Err.Text += "[ Column Check ]" + "\r\n";
                    Clear_Data();

                    for (int i = 0; i < _newDataSet.Tables[0].Rows.Count; i++)
                    {
                        if ((vRowCount == vCutRowCount) || (_newDataSet.Tables[0].Rows.Count - 1 == i))
                        {
                            int vEndRow = i;
                            int vStartRow = vEndRow - (vRowCount - 1);

                            if (!Check_Save_Column(vStartRow, vEndRow))
                            {
                                txt_Err.Text += "\r\n" + " * Save failed.. *" + "\r\n";
                                return false;
                            }
                            if (!Save_Material(vStartRow, vEndRow))
                            {
                                txt_Err.Text += "\r\n" + " * Save failed.. *" + "\r\n";
                                return false;
                            }

                            // Loading Status //
                            lbl_Count.Text = Convert.ToString(i + 1) + "/" + _newDataSet.Tables[0].Rows.Count.ToString();
                            pgb_LoadingStatus.Value = i + 1;

                            vRowCount = 0;
                        }
                        vRowCount++;
                    }

                    txt_Err.Text += " * Column Check Passed.. *" + "\r\n";
                    txt_Err.Text += "\r\n" + " * Save Complete.. *" + "\r\n";
                }
                #endregion

                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
                return true;
            }
            catch (Exception ex)
            {
                txt_Err.Text += "\r\n" + " * Save failed.. *" + "\r\n";
                MessageBox.Show(ex.ToString());
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return false;
            }

        }

        private bool Check_Save_Header()
        {

            txt_Err.Text = "[ Header Check ]" + "\r\n";

            #region DataSet Name Check
            if (_newDataSet.DataSetName != ClassLib.ComFunction.Select_Code_List_ComSeq(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_XML_Sheet, "1"))
            {
                txt_Err.Text += " * DataSet Name is wrong *" + "\r\n" + "\r\n";
                return false;
            }
            #endregion

            #region Table Name Check
            for (int i = 0; i < _newDataSet.Tables.Count; i++)
            {

                if (_newDataSet.Tables[i].TableName != ClassLib.ComFunction.Select_Code_List_ComSeq(cmb_Factory.SelectedValue.ToString(), COM.ComVar.CxCDC_XML_Sheet, Convert.ToString(i + 2)))
                {
                    txt_Err.Text += " * Table[" + i + "] :  Name is wrong *" + "\r\n" + "\r\n";

                    return false;
                }

            }
            #endregion

            txt_Err.Text += " * Header Check Passed.. *" + "\r\n" + "\r\n";

            return true;
        }
        private bool Check_Save_Column(int arg_startrow, int arg_endrow)
        {
            DataTable dt_list_h = Select_Data_Length("SXB_SRF_MAT_H", "1"); // Head Data 
            DataTable dt_list_t = Select_Data_Length("SXB_SRF_MAT_T", "1"); // Tail Data 			

            #region Head Data Check
            for (int i = arg_startrow; i <= arg_endrow; i++)
            {

                for (int j = 0; j < _newDataSet.Tables[0].Columns.Count - 1; j++)
                {

                    // Length Check 
                    //if( _newDataSet.Tables[0].Rows[i].ItemArray[j].ToString().Trim().Length > int.Parse(dt_list_h.Rows[j+1].ItemArray[0].ToString()) )
                    //{
                    //    txt_Err.Text += "- Line "+ i +" : "									 
                    //                  + "["+ _newDataSet.Tables[0].Rows[i].ItemArray[0].ToString() +"]"
                    //                  + "["+ _newDataSet.Tables[0].Rows[i].ItemArray[1].ToString() +"]"+"\r\n"
                    //                  + "-Column["+ _newDataSet.Tables[0].Columns[j].ColumnName +"] has wrong data length "+"\r\n";						
                    //    return false;												
                    //}	

                    // Column Name Check
                    if (_newDataSet.Tables[0].Columns[j].ColumnName != dt_list_h.Rows[j + 1].ItemArray[1].ToString())
                    {
                        txt_Err.Text += "- Line " + i + " : "
                                      + "[" + _newDataSet.Tables[0].Rows[i].ItemArray[0].ToString() + "]"
                                      + "[" + _newDataSet.Tables[0].Rows[i].ItemArray[1].ToString() + "]" + "\r\n"
                                      + "-Column[" + _newDataSet.Tables[0].Columns[j].ColumnName + "] has wrong Column Name " + "\r\n";
                        return false;
                    }
                }

            }
            #endregion

            #region Tail Data Check
            int vCount = 99;
            if (_newDataSet.Tables[1].Rows.Count - _StartRow < 100)
                vCount = _newDataSet.Tables[1].Rows.Count - _StartRow;


            for (int i = _StartRow; i < _StartRow + vCount; i++)
            {
                for (int j = 0; j < _newDataSet.Tables[1].Columns.Count - 1; j++)
                {

                    //Length Check
                    //if( _newDataSet.Tables[1].Rows[i].ItemArray[j].ToString().Trim().Length > int.Parse(dt_list_t.Rows[j].ItemArray[0].ToString()) )
                    //{
                    //    txt_Err.Text += "- Line "+ i +" : "									  
                    //                  + "["+ _newDataSet.Tables[1].Rows[i].ItemArray[0].ToString() +"]" 
                    //                  + "["+ _newDataSet.Tables[1].Rows[i].ItemArray[1].ToString() +"]" +"\r\n"
                    //                  + "-Column["+ _newDataSet.Tables[1].Columns[j].ColumnName +"] has wrong data length "+"\r\n";
                    //    return false;						
                    //}	

                    // Column Name Check
                    if (_newDataSet.Tables[1].Columns[j].ColumnName != dt_list_t.Rows[j].ItemArray[1].ToString())
                    {
                        txt_Err.Text += "- Line " + i + " : "
                                      + "[" + _newDataSet.Tables[1].Rows[i].ItemArray[0].ToString() + "]"
                                      + "[" + _newDataSet.Tables[1].Rows[i].ItemArray[1].ToString() + "]" + "\r\n"
                                      + "-Column[" + _newDataSet.Tables[1].Columns[j].ColumnName + "] has wrong Column Name " + "\r\n";
                        return false;
                    }
                }

            }
            #endregion

            return true;
        }
        private void Clear_Data()
        {

            // Header Clear
            for (int i = 0; i < _newDataSet.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < _newDataSet.Tables[0].Columns.Count; j++)
                {
                    _newDataSet.Tables[0].Rows[i].ItemArray[j] = (_newDataSet.Tables[0].Rows[i].ItemArray[j] == null) ? "" :
                                                                  _newDataSet.Tables[0].Rows[i].ItemArray[j].ToString();
                }
            }

            // Tail Clear
            for (int i = 0; i < _newDataSet.Tables[1].Rows.Count; i++)
            {
                for (int j = 0; j < _newDataSet.Tables[1].Columns.Count; j++)
                {
                    _newDataSet.Tables[1].Rows[i].ItemArray[j] = (_newDataSet.Tables[1].Rows[i].ItemArray[j] == null) ? "" :
                                                                 _newDataSet.Tables[1].Rows[i].ItemArray[j].ToString();
                }
            }

        }

        private bool Save_Material(int arg_startrow, int arg_endrow)
        {
            try
            {
                DataSet ds_ret;
                bool vSaveFlag = false;

                vSaveFlag = Save_MAT_Head_Load(_newDataSet.Tables[0], arg_startrow, arg_endrow);

                if (!vSaveFlag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                    return false;
                }
                else
                {
                    vSaveFlag = Save_MAT_Tail_Load(_newDataSet.Tables[1], _newDataSet.Tables[0], arg_startrow, arg_endrow);

                    if (!vSaveFlag)
                    {
                        ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                        return false;
                    }
                    else
                    {
                        ds_ret = MyOraDB.Exe_Modify_Procedure();

                        if (ds_ret == null)
                        {
                            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                            return false;
                        }
                        else
                            return true;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        private void Confirm_Data()
        {
            txt_Err.Text = "";
            lbl_Count.Text = "0/0";
            pgb_LoadingStatus.Value = 0;

            // Threading //
            _pop = new Pop_BS_Shipping_List_Wait();

            Thread vCreate = new Thread(new ThreadStart(Confirm_Threading));
            vCreate.Start();
            _pop.Start();
        }
        private void Confirm_Threading()
        {
            try
            {
                if (!Update_Data(cmb_Factory.SelectedValue.ToString(), COM.ComVar.This_User))
                {
                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
                    return;
                }

            }
            catch
            {
                COM.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
            }
            finally
            {
                _pop.Close();
                COM.ComFunction.Data_Message(COM.ComVar.MgsEndRun, this);
            }

        }
        #endregion

        #region 이벤트처리
        private void btn_apply_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                XML_Save();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);

            }
            finally
            {
                this.Cursor = Cursors.Default;
                //this.Close();
            }
        }

        private void lbl_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region DB Connect
        private DataTable Select_Modify_Date(string arg_factory)
        {
            try
            {
                DataSet ds_ret;


                MyOraDB.ReDim_Parameter(2);

                // 01.PROCEDURE명 //
                MyOraDB.Process_Name = "PKG_SXB_BASE_01.SELECT_SXD_SRF_MAT_DATE";

                // 02.ARGURMENT 명 //
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                // 03.DATA TYPE 정의 //
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                // 04.DATA 정의 //
                MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_String(arg_factory, " ");
                MyOraDB.Parameter_Values[1] = "";



                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }


        }

        private DataTable Select_Data_Length(string arg_pg_id, string arg_pg_seq)
        {

            DataSet ds_list;

            MyOraDB.ReDim_Parameter(3);

            // 01.PROCEDURE명 //
            MyOraDB.Process_Name = "PKG_SXC_COMMON.SELECT_DATA_LENGTH";

            // 02.ARGURMENT 명 //
            MyOraDB.Parameter_Name[0] = "ARG_PG_ID";
            MyOraDB.Parameter_Name[1] = "ARG_PG_SEQ";
            MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

            // 03.DATA TYPE 정의 //
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            // 04.DATA 정의 //
            MyOraDB.Parameter_Values[0] = arg_pg_id;
            MyOraDB.Parameter_Values[1] = arg_pg_seq;
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_list = MyOraDB.Exe_Select_Procedure();


            return ds_list.Tables[MyOraDB.Process_Name];

        }

        private bool Save_MAT_Head_Load(DataTable arg_dt_list, int arg_startrow, int arg_endrow)
        {
            try
            {
                int vCount = 10, vSaveCount = 100, a = 0, b = 0;
                MyOraDB.ReDim_Parameter(vCount);


                // 01.PROCEDURE명 //
                MyOraDB.Process_Name = "PKG_SXB_BASE_01.SAVE_SXB_SRF_MAT_HEAD_LOAD";

                // 02.ARGURMENT명 // 		
                MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[a++] = "ARG_MAT_NUMBER";
                MyOraDB.Parameter_Name[a++] = "ARG_MAT_NAME";
                MyOraDB.Parameter_Name[a++] = "ARG_STATE";
                MyOraDB.Parameter_Name[a++] = "ARG_TYPE";
                MyOraDB.Parameter_Name[a++] = "ARG_SUBTYPE";
                MyOraDB.Parameter_Name[a++] = "ARG_VARIATION";
                MyOraDB.Parameter_Name[a++] = "ARG_SUBVARIATION";
                MyOraDB.Parameter_Name[a++] = "ARG_DESCRIPTION";
                MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";


                // 03.DATA TYPE 정의 //
                for (int j = 0; j < vCount; j++)
                    MyOraDB.Parameter_Type[j] = (int)OracleType.VarChar;


                // 04.DATA 정의 //
                MyOraDB.Parameter_Values = new string[vCount * vSaveCount];
                for (int j = arg_startrow; j <= arg_endrow; j++)
                {
                    int c = 0;
                    MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = arg_dt_list.Rows[j].ItemArray[c++].ToString();
                    MyOraDB.Parameter_Values[b++] = COM.ComVar.This_User;

                    //txt_Err.Text =arg_dt_list.Rows[j].ItemArray[c++].ToString() +"--"+ arg_dt_list.Rows[j].ItemArray[c++].ToString();
                }

                MyOraDB.Add_Modify_Parameter(true);

                return true;

            }
            catch
            {
                return false;
            }


        }
        private bool Save_MAT_Tail_Load(DataTable arg_dt_list, DataTable arg_mat_num, int arg_startrow, int arg_endrow)
        {

            try
            {

                int vCount = 18, vCntRow = 0, z = 0, x = 0;
                MyOraDB.ReDim_Parameter(vCount);

                // 01.PROCEDURE명 //
                MyOraDB.Process_Name = "PKG_SXB_BASE_01.SAVE_SXB_SRF_MAT_TAIL_LOAD";

                // 02.ARGURMENT 명 //			
                MyOraDB.Parameter_Name[z++] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[z++] = "ARG_MAT_NUMBER";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_NUMBER";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_NAME";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_STATE";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_MCS_CD";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_QUOTEDPRICE";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_QUOTEDCURRENCY";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_QUOTEDUOM";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_DELIVERYTERM";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_WIDTH";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_WIDTHUOM";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_LENGTH";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_LENGTHUOM";
                //MyOraDB.Parameter_Name[z++]  = "ARG_MXS_THICKNESS";
                //MyOraDB.Parameter_Name[z++]  = "ARG_MXS_THICKNESSUOM";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_LOCATIONCODE";
                MyOraDB.Parameter_Name[z++] = "ARG_MXS_LOCATIONNAME";
                MyOraDB.Parameter_Name[z++] = "ARG_NIKE_SUPPLIER_CODE";
                MyOraDB.Parameter_Name[z++] = "ARG_UPD_USER";


                // 03.DATA TYPE 정의 //
                for (int j = 0; j < vCount; j++)
                    MyOraDB.Parameter_Type[j] = (int)OracleType.VarChar;

                // 04.DATA 정의 //
                for (int i = arg_startrow; i <= arg_endrow; i++)
                {
                    for (int j = vSaveCount; j < arg_dt_list.Rows.Count; j++)
                    {
                        if (arg_mat_num.Rows[i].ItemArray[0].ToString()
                            == arg_dt_list.Rows[vSaveCount].ItemArray[0].ToString().Substring(0, arg_dt_list.Rows[vSaveCount].ItemArray[0].ToString().IndexOf(".")))
                        {
                            vCntRow++;
                            vSaveCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                }

                MyOraDB.Parameter_Values = new string[vCount * vCntRow];



                for (int i = arg_startrow; i <= arg_endrow; i++)
                {


                    for (int j = _StartRow; j < arg_dt_list.Rows.Count; j++)
                    {

                        if (arg_mat_num.Rows[i].ItemArray[0].ToString()
                            == arg_dt_list.Rows[_StartRow].ItemArray[0].ToString().Substring(0, arg_dt_list.Rows[_StartRow].ItemArray[0].ToString().IndexOf(".")))
                        {

                            int y = 0;

                            MyOraDB.Parameter_Values[x++] = cmb_Factory.SelectedValue.ToString();
                            MyOraDB.Parameter_Values[x++] = arg_mat_num.Rows[i].ItemArray[0].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            //MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            //MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = arg_dt_list.Rows[j].ItemArray[y++].ToString();
                            MyOraDB.Parameter_Values[x++] = COM.ComVar.This_User;


                            _StartRow++;
                        }
                        else
                        {
                            break;
                        }
                    }


                }

                MyOraDB.Add_Modify_Parameter(false);


                return true;

            }
            catch
            {
                return false;
            }


        }

        private bool Update_Data(string arg_factory, string arg_upd_user)
        {

            MyOraDB.ReDim_Parameter(2);

            // 01.PROCEDURE명 //			
            MyOraDB.Process_Name = "PKG_SXB_BASE_01.SAVE_SXD_SRF_M_MAT";


            // 02.ARGURMENT 명 //
            MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[1] = "ARG_UPD_USER";


            // 03.DATA TYPE 정의 //
            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;


            // 04.DATA 정의 //
            MyOraDB.Parameter_Values[0] = arg_factory;
            MyOraDB.Parameter_Values[1] = arg_upd_user;


            MyOraDB.Add_Modify_Parameter(true);
            DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();



            if (ds_Set == null)
                return false;
            else
                return true;
        }

        #endregion

        private void Pop_MaterialXML_Load_Load(object sender, System.EventArgs e)
        {
            Init_Form();
        }
    }
}

