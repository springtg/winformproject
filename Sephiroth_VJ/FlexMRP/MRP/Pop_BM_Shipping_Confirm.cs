using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;



namespace FlexMRP.MRP
{
    public  class Pop_BM_Shipping_Confirm : COM.PCHWinForm.Pop_Medium
    {


		#region 디자이너가 생성한 코드

		private DataTable _DT = null;


		public Pop_BM_Shipping_Confirm( DataTable arg_DT)
		{

			InitializeComponent();

			_DT = arg_DT;
			


		}

	


		private COM.FSP fgrid_ship;




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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Shipping_Confirm));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.fgrid_ship = new COM.FSP();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.txt_MRP_Ship_No = new System.Windows.Forms.TextBox();
			this.lbl_MRP_Ship_No = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ship)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
			this.lbl_MainTitle.Text = "Shipping Confirm Check";
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
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
			this.c1Sizer1.BorderWidth = 0;
			this.c1Sizer1.Controls.Add(this.panel3);
			this.c1Sizer1.Controls.Add(this.pnl_main);
			this.c1Sizer1.Controls.Add(this.groupBox1);
			this.c1Sizer1.GridDefinition = "9.34579439252336:False:True;80.1401869158879:False:False;6.77570093457944:False:T" +
				"rue;0.934579439252336:False:True;\t0.576368876080692:False:True;97.6945244956772:" +
				"False:False;0.576368876080692:False:True;";
			this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
			this.c1Sizer1.TabIndex = 28;
			this.c1Sizer1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btn_Cancel);
			this.panel3.Location = new System.Drawing.Point(8, 391);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(678, 29);
			this.panel3.TabIndex = 168;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(600, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(71, 23);
			this.btn_Cancel.TabIndex = 353;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// pnl_main
			// 
			this.pnl_main.Controls.Add(this.fgrid_ship);
			this.pnl_main.Location = new System.Drawing.Point(8, 44);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(678, 343);
			this.pnl_main.TabIndex = 166;
			// 
			// fgrid_ship
			// 
			this.fgrid_ship.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ship.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ship.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_ship.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_ship.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ship.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fgrid_ship.Location = new System.Drawing.Point(0, 0);
			this.fgrid_ship.Name = "fgrid_ship";
			this.fgrid_ship.Size = new System.Drawing.Size(678, 343);
			this.fgrid_ship.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ship.TabIndex = 34;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmb_factory);
			this.groupBox1.Controls.Add(this.txt_MRP_Ship_No);
			this.groupBox1.Controls.Add(this.lbl_MRP_Ship_No);
			this.groupBox1.Controls.Add(this.lbl_Factory);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 40);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
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
			this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(106, 10);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCaption" +
				"Height=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGrou" +
				"p=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScr" +
				"ollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\"" +
				" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=" +
				"\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle p" +
				"arent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style" +
				"6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\"" +
				" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Sele" +
				"ctedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /><" +
				"/C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" />" +
				"<Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Sty" +
				"le parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Styl" +
				"e parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><St" +
				"yle parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style p" +
				"arent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Nam" +
				"edStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</L" +
				"ayout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(210, 20);
			this.cmb_factory.TabIndex = 583;
			// 
			// txt_MRP_Ship_No
			// 
			this.txt_MRP_Ship_No.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_MRP_Ship_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MRP_Ship_No.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_MRP_Ship_No.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MRP_Ship_No.Location = new System.Drawing.Point(477, 10);
			this.txt_MRP_Ship_No.MaxLength = 10;
			this.txt_MRP_Ship_No.Name = "txt_MRP_Ship_No";
			this.txt_MRP_Ship_No.ReadOnly = true;
			this.txt_MRP_Ship_No.Size = new System.Drawing.Size(195, 21);
			this.txt_MRP_Ship_No.TabIndex = 582;
			this.txt_MRP_Ship_No.Text = "";
			// 
			// lbl_MRP_Ship_No
			// 
			this.lbl_MRP_Ship_No.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MRP_Ship_No.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MRP_Ship_No.ImageIndex = 2;
			this.lbl_MRP_Ship_No.ImageList = this.img_Label;
			this.lbl_MRP_Ship_No.Location = new System.Drawing.Point(376, 10);
			this.lbl_MRP_Ship_No.Name = "lbl_MRP_Ship_No";
			this.lbl_MRP_Ship_No.Size = new System.Drawing.Size(100, 21);
			this.lbl_MRP_Ship_No.TabIndex = 581;
			this.lbl_MRP_Ship_No.Text = "MRP Ship No";
			this.lbl_MRP_Ship_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 2;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 10);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 180;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_BM_Shipping_Confirm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_BM_Shipping_Confirm";
			this.Load += new System.EventHandler(this.Pop_BM_Shipping_Confirm_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ship)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnl_main;
		//private COM.SSP spd_main;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_MRP_Ship_No;
		private System.Windows.Forms.Label lbl_MRP_Ship_No;
		private System.Windows.Forms.Label lbl_Factory;
		//private COM.FSP fgrid_ship;
		private System.Windows.Forms.Label btn_Cancel;
		private C1.Win.C1List.C1Combo cmb_factory;

		#endregion 


        #region 멤버메쏘드
        private void Init_Form()
        {


			try
			{
				//Title
				this.Text = "Shipping Confirm Check";
				lbl_MainTitle.Text = "Shipping Confirm Check";
				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정(TBSBC_FORMULAN_YIELD )
				fgrid_ship.Set_Grid("SBM_SHIP_CONFIRM_2", "4", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_ship.Set_Action_Image(img_Action);


				// factory set
				DataTable vDt;
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
				cmb_factory.SelectedValue = _DT.Rows[0].ItemArray[0].ToString();            
				vDt.Dispose();

				txt_MRP_Ship_No.Text = _DT.Rows[0].ItemArray[1].ToString();            
            
				
				DisplayGrid();
			

			}
			catch(Exception ex)
			{

                 MessageBox.Show(ex.ToString());
			}

        }


        private void DisplayGrid()
        {

            fgrid_ship.Rows.Count = fgrid_ship.Rows.Fixed;

            for (int i = 0; i < _DT.Rows.Count; i++)
            {

                fgrid_ship.AddItem(_DT.Rows[i].ItemArray, fgrid_ship.Rows.Count, 1);

            }

        }




        #endregion 



        #region 버튼이벤트

        private void Pop_BM_Shipping_Confirm_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


	

    }
}

