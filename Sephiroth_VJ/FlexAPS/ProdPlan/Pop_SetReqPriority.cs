using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Pop_SetReqPriority : COM.APSWinForm.Pop_Large
	{
		
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ImageList img_LongButton;
		public System.Windows.Forms.Label btn_Apply;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Panel pnl_Info;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.TextBox txt_ObsID;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Factory;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LBL;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.PictureBox picb_LML;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Pop_SetReqPriority()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

 


 
		string _Factory; 
		string _LOTNo;
		string _LOTSeq; 


		public Pop_SetReqPriority(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			_Factory = arg_factory;
			_LOTNo = arg_lot_no;
			_LOTSeq = arg_lot_seq;


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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetReqPriority));
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.fgrid_Main = new COM.FSP();
			this.pnl_Info = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_ObsID = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Info.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
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
			this.lbl_MainTitle.Text = "Set Destination Priority";
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(104, 208);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(72, 23);
			this.btn_Apply.TabIndex = 202;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(176, 208);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(253, 46);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(432, 186);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 242;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// pnl_Info
			// 
			this.pnl_Info.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Info.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_Info.DockPadding.Bottom = 5;
			this.pnl_Info.Location = new System.Drawing.Point(6, 46);
			this.pnl_Info.Name = "pnl_Info";
			this.pnl_Info.Size = new System.Drawing.Size(240, 156);
			this.pnl_Info.TabIndex = 243;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsID);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(240, 151);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(111, 124);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(117, 21);
			this.txt_LOT.TabIndex = 253;
			this.txt_LOT.Text = "";
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(10, 124);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 122;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(111, 80);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.Size = new System.Drawing.Size(117, 21);
			this.txt_Model.TabIndex = 251;
			this.txt_Model.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 102);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 247;
			this.txt_StyleCd.Text = "";
			// 
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(192, 58);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(36, 21);
			this.txt_ObsType.TabIndex = 246;
			this.txt_ObsType.Text = "";
			// 
			// txt_ObsID
			// 
			this.txt_ObsID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsID.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsID.Location = new System.Drawing.Point(111, 58);
			this.txt_ObsID.MaxLength = 60;
			this.txt_ObsID.Name = "txt_ObsID";
			this.txt_ObsID.ReadOnly = true;
			this.txt_ObsID.Size = new System.Drawing.Size(80, 21);
			this.txt_ObsID.TabIndex = 254;
			this.txt_ObsID.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(192, 102);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 248;
			this.txt_Gen.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(10, 80);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 233;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 102);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 224;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_Label;
			this.lbl_DPO.Location = new System.Drawing.Point(10, 58);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPO.TabIndex = 229;
			this.lbl_DPO.Text = "DPO / Type";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 226;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(111, 36);
			this.txt_Factory.MaxLength = 60;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(117, 21);
			this.txt_Factory.TabIndex = 252;
			this.txt_Factory.Text = "";
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(224, 135);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(16, 16);
			this.picb_LBR.TabIndex = 23;
			this.picb_LBR.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 131);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(225, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(15, 151);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(224, 0);
			this.picb_LTR.Name = "picb_LTR";
			this.picb_LTR.Size = new System.Drawing.Size(16, 32);
			this.picb_LTR.TabIndex = 21;
			this.picb_LTR.TabStop = false;
			// 
			// picb_LTM
			// 
			this.picb_LTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTM.Image")));
			this.picb_LTM.Location = new System.Drawing.Point(224, 0);
			this.picb_LTM.Name = "picb_LTM";
			this.picb_LTM.Size = new System.Drawing.Size(40, 32);
			this.picb_LTM.TabIndex = 0;
			this.picb_LTM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 20;
			this.lbl_SubTitle1.Text = "       Seleted Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 133);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(93, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
			// 
			// picb_LMM
			// 
			this.picb_LMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMM.Image")));
			this.picb_LMM.Location = new System.Drawing.Point(160, 24);
			this.picb_LMM.Name = "picb_LMM";
			this.picb_LMM.Size = new System.Drawing.Size(72, 151);
			this.picb_LMM.TabIndex = 27;
			this.picb_LMM.TabStop = false;
			// 
			// picb_LML
			// 
			this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
			this.picb_LML.Location = new System.Drawing.Point(0, 24);
			this.picb_LML.Name = "picb_LML";
			this.picb_LML.Size = new System.Drawing.Size(168, 151);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// Pop_SetReqPriority
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(694, 247);
			this.Controls.Add(this.pnl_Info);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.fgrid_Main);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_SetReqPriority";
			this.Text = "Set Destination Priority";
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Info, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Info.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		public bool _CloseSave = false;  


		#endregion 

		#region 멤버 메서드
 

		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			try
			{
 			
				//Title  
				this.Text = "Set Destination Priority";
				lbl_MainTitle.Text = "Set Destination Priority"; 
 
 
  
			    //grid setting
			    fgrid_Main.Set_Grid("SPO_RECV_LOT_PRIORITY", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true);
				fgrid_Main.ExtendLastCol = false; 
				fgrid_Main.Font = new Font("Verdana", 7); 
  


				//search
				Display_Recv_LOT();
 
 
				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			 
		}

 



		#endregion

		#region 조회


		/// <summary>
		/// Display_Recv_LOT : 
		/// </summary>
		private void Display_Recv_LOT()
		{
   
			DataTable dt_ret = Select_SPO_RECV_LOT_PRIORITY(_Factory, _LOTNo, _LOTSeq); 

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

//			for(int i = 0; i < dt_ret.Rows.Count; i++)
//			{
//				fgrid_Main.AddItem(dt_ret.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
//				fgrid_Main[i + fgrid_Main.Rows.Fixed, 0] = ""; 
// 
//
//			}
			

			fgrid_Main.Display_Grid(dt_ret, true);

	
			txt_Factory.Text = _Factory;
			txt_ObsID.Text = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxOBS_ID].ToString();
			txt_ObsType.Text = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxOBS_TYPE].ToString();
			txt_Model.Text = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxMODEL_NAME].ToString();
			txt_StyleCd.Text = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxSTYLE].ToString();
			txt_Gen.Text = fgrid_Main[fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxGEN].ToString(); 
			txt_LOT.Text = _LOTNo + "-" + _LOTSeq;
 


			dt_ret.Dispose();


		}



		#region 컬럼 자동 소트 클래스
 
		/// <summary>
		/// MyComparer
		/// compares two grid rows using all columns
		/// </summary>
		public class MyComparer : IComparer
		{
			C1FlexGrid _flex;
			public MyComparer(C1FlexGrid flex)
			{
				_flex = flex;
			}
			int IComparer.Compare(object x, object y)
			{
				// get row indices
				int r1 = ((Row)x).Index;
				int r2 = ((Row)y).Index;

				// scan all columns looking for differences
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// get display values
					string s1 = _flex.GetDataDisplay(r1, c);
					string s2 = _flex.GetDataDisplay(r2, c);

					// compare, done when a difference is found
					int cmp = string.Compare(s1, s2);
					if (cmp != 0) return cmp;
				}

				// all values are the same, use row indices
				// to keep sort stable
				return r1 - r2;
			}
		}


		#endregion 

 



		#endregion

		#region 버튼 및 기타 이벤트 메서드

		private void Event_Click_Apply()
		{
  
 
			bool save_flag = Update_SPO_RECV_LOT_PRIORITY();


			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this); 
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				_CloseSave = true;
				this.Close();
			}

 
 
		}

 

		#endregion



		#endregion 

		#region 이벤트 처리


		#region 툴바 이벤트

		#endregion

		#region 그리드 이벤트

		
		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				// 컬럼 자동 소트
				fgrid_Main.Sort(new MyComparer(fgrid_Main)); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{

			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion 
		
 

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_Apply();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				if(!_CloseSave) 
				{
					_CloseSave = false;
				}

				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}



		#endregion

		


		#endregion  
 
		#region 디비 연결
  

		
		/// <summary>
		/// Select_SPO_RECV_LOT_PRIORITY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataTable Select_SPO_RECV_LOT_PRIORITY(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			try
			{ 
				
				DataSet ds_ret;  

			

				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPO_RECV_LOT_PRIORITY";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no; 
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[0];  
			}
			catch
			{
				return null;
			}

		} 
		 
 


		/// <summary>
		/// Update_SPO_RECV_LOT_PRIORITY : 
		/// </summary>
		/// <returns></returns>
		private bool Update_SPO_RECV_LOT_PRIORITY()
		{

			try
			{ 

				
				int col_ct = 6;  	 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.UPDATE_SPO_RECV_LOT_PRIORITY";


				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_PRIORITY";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				  


				// 파라미터 값에 저장할 배열
				ArrayList vList = new ArrayList(); 

  
				for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
				{

					if(fgrid_Main[i, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxREQ_NO_PRIORITY] == null 
						|| fgrid_Main[i, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxREQ_NO_PRIORITY].ToString().Trim().Equals("") )
					{
						fgrid_Main[i, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxREQ_NO_PRIORITY] = "0";
					}
 
					  
					vList.Add(_Factory); 
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxREQ_NO].ToString() ); 
					vList.Add(_LOTNo);  
					vList.Add(_LOTSeq); 
					vList.Add(fgrid_Main[i, (int)ClassLib.TBSPO_RECV_LOT_PRIORITY.IxREQ_NO_PRIORITY].ToString() );  
					vList.Add(ClassLib.ComVar.This_User);  


				} // end for i

  
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{ 
				MessageBox.Show(ex.ToString() );
				return false;
			} 


		}




		#endregion 

 
	}
}

