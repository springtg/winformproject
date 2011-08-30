using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Data.SqlClient; 
using System.Data.OleDb;

namespace FlexOrder.ExpLoad
{
	public class POP_EL_RPM : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private System.Windows.Forms.TextBox txt_OBS_Type;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_EKET;
		public COM.FSP fgrid_EKKO;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox txt_Inform;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Seq_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_Style_CD;
		private System.Windows.Forms.Label btn_Search;
		private System.ComponentModel.IContainer components = null;

		public POP_EL_RPM()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EL_RPM));
			this.label1 = new System.Windows.Forms.Label();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.txt_OBS_Type = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_EKET = new COM.FSP();
			this.fgrid_EKKO = new COM.FSP();
			this.fgrid_Main = new COM.FSP();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.txt_Inform = new System.Windows.Forms.TextBox();
			this.txt_Seq_Nu = new System.Windows.Forms.TextBox();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Style_CD = new System.Windows.Forms.TextBox();
			this.btn_Search = new System.Windows.Forms.Label();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 2;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(6, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 217;
			this.label1.Text = "PO Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_ID
			// 
			this.txt_OBS_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID.Enabled = false;
			this.txt_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID.Location = new System.Drawing.Point(107, 54);
			this.txt_OBS_ID.MaxLength = 10;
			this.txt_OBS_ID.Name = "txt_OBS_ID";
			this.txt_OBS_ID.Size = new System.Drawing.Size(220, 20);
			this.txt_OBS_ID.TabIndex = 216;
			this.txt_OBS_ID.Text = "";
			// 
			// txt_OBS_Type
			// 
			this.txt_OBS_Type.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Type.Enabled = false;
			this.txt_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Type.Location = new System.Drawing.Point(107, 75);
			this.txt_OBS_Type.MaxLength = 10;
			this.txt_OBS_Type.Name = "txt_OBS_Type";
			this.txt_OBS_Type.ReadOnly = true;
			this.txt_OBS_Type.Size = new System.Drawing.Size(220, 20);
			this.txt_OBS_Type.TabIndex = 215;
			this.txt_OBS_Type.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(107, 33);
			this.txt_Factory.MaxLength = 6;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(220, 20);
			this.txt_Factory.TabIndex = 214;
			this.txt_Factory.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8F);
			this.label7.ImageIndex = 2;
			this.label7.ImageList = this.img_Label;
			this.label7.Location = new System.Drawing.Point(6, 53);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 213;
			this.label7.Text = "OBS ID";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8F);
			this.label9.ImageIndex = 2;
			this.label9.ImageList = this.img_Label;
			this.label9.Location = new System.Drawing.Point(6, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 212;
			this.label9.Text = "Factory";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_EKET);
			this.pnl_Body.Controls.Add(this.fgrid_EKKO);
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.All = 2;
			this.pnl_Body.Location = new System.Drawing.Point(0, 194);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(326, 62);
			this.pnl_Body.TabIndex = 220;
			// 
			// fgrid_EKET
			// 
			this.fgrid_EKET.AutoResize = false;
			this.fgrid_EKET.BackColor = System.Drawing.Color.White;
			this.fgrid_EKET.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKET.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_EKET.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKET.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKET.Location = new System.Drawing.Point(736, 208);
			this.fgrid_EKET.Name = "fgrid_EKET";
			this.fgrid_EKET.Rows.Count = 2;
			this.fgrid_EKET.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKET.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKET.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKET.TabIndex = 45;
			// 
			// fgrid_EKKO
			// 
			this.fgrid_EKKO.AutoResize = false;
			this.fgrid_EKKO.BackColor = System.Drawing.Color.White;
			this.fgrid_EKKO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_EKKO.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_EKKO.ForeColor = System.Drawing.Color.Black;
			this.fgrid_EKKO.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_EKKO.Location = new System.Drawing.Point(736, 16);
			this.fgrid_EKKO.Name = "fgrid_EKKO";
			this.fgrid_EKKO.Rows.Count = 2;
			this.fgrid_EKKO.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_EKKO.Size = new System.Drawing.Size(200, 176);
			this.fgrid_EKKO.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_EKKO.TabIndex = 44;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "2,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(2, 2);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Count = 2;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(322, 58);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// btn_Delete
			// 
			this.btn_Delete.ImageIndex = 0;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(256, 165);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(70, 23);
			this.btn_Delete.TabIndex = 222;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(256, 260);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 221;
			this.btn_Cancel.Text = "OK";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// txt_Inform
			// 
			this.txt_Inform.BackColor = System.Drawing.Color.White;
			this.txt_Inform.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_Inform.Enabled = false;
			this.txt_Inform.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Inform.ForeColor = System.Drawing.Color.Red;
			this.txt_Inform.Location = new System.Drawing.Point(6, 166);
			this.txt_Inform.MaxLength = 6;
			this.txt_Inform.Name = "txt_Inform";
			this.txt_Inform.Size = new System.Drawing.Size(170, 14);
			this.txt_Inform.TabIndex = 226;
			this.txt_Inform.Text = "★ OBS total quantity Info.";
			// 
			// txt_Seq_Nu
			// 
			this.txt_Seq_Nu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Seq_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Seq_Nu.Location = new System.Drawing.Point(107, 139);
			this.txt_Seq_Nu.MaxLength = 10;
			this.txt_Seq_Nu.Name = "txt_Seq_Nu";
			this.txt_Seq_Nu.Size = new System.Drawing.Size(220, 20);
			this.txt_Seq_Nu.TabIndex = 237;
			this.txt_Seq_Nu.Text = "";
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(107, 118);
			this.txt_OBS_Nu.MaxLength = 6;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.Size = new System.Drawing.Size(220, 20);
			this.txt_OBS_Nu.TabIndex = 235;
			this.txt_OBS_Nu.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 2;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(5, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 234;
			this.label3.Text = "Seq Nu";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8F);
			this.label4.ImageIndex = 2;
			this.label4.ImageList = this.img_Label;
			this.label4.Location = new System.Drawing.Point(5, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 233;
			this.label4.Text = "OBS Nu";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 2;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(6, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 240;
			this.label2.Text = "Style CD";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style_CD
			// 
			this.txt_Style_CD.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style_CD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_CD.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style_CD.Location = new System.Drawing.Point(107, 96);
			this.txt_Style_CD.MaxLength = 10;
			this.txt_Style_CD.Name = "txt_Style_CD";
			this.txt_Style_CD.Size = new System.Drawing.Size(220, 20);
			this.txt_Style_CD.TabIndex = 239;
			this.txt_Style_CD.Text = "";
			// 
			// btn_Search
			// 
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_Button;
			this.btn_Search.Location = new System.Drawing.Point(184, 165);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(70, 23);
			this.btn_Search.TabIndex = 242;
			this.btn_Search.Text = "Search";
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.lbl_Search_Click);
			// 
			// POP_EL_RPM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(330, 287);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_Style_CD);
			this.Controls.Add(this.txt_Seq_Nu);
			this.Controls.Add(this.txt_OBS_Nu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_Inform);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_OBS_ID);
			this.Controls.Add(this.txt_OBS_Type);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.DockPadding.All = 2;
			this.Name = "POP_EL_RPM";
			this.Load += new System.EventHandler(this.POP_EL_RPM_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_OBS_Type, 0);
			this.Controls.SetChildIndex(this.txt_OBS_ID, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Delete, 0);
			this.Controls.SetChildIndex(this.txt_Inform, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.txt_OBS_Nu, 0);
			this.Controls.SetChildIndex(this.txt_Seq_Nu, 0);
			this.Controls.SetChildIndex(this.txt_Style_CD, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.btn_Search, 0);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKET)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_EKKO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의

		private int _Rowfixed=3;   

		private COM.OraDB MyOraDB = new COM.OraDB();
		private ClassLib.OraDB  MyClassLib = new ClassLib.OraDB(); 

		#endregion

		#region 멤버 메서드
		private void Init_Form()
		{ 
			//Title
			this.Text = "RPM Loading Verificationn";
			this.lbl_MainTitle.Text = "RPM Loading Verificationn"; 
			ClassLib.ComFunction.SetLangDic(this);
		
			// 그리드 설정
			fgrid_Main.Set_Grid( "SEM_POP_RPM", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
			fgrid_Main.GetCellRange(_Rowfixed-1, 1 ,_Rowfixed-1, fgrid_Main.Cols.Count - 1).StyleNew.BackColor
				= ClassLib.ComVar.Clr_Head_Crimson;
			fgrid_Main.Font  = new Font("Verdana",8);
			fgrid_Main.AllowMerging = AllowMergingEnum.Free;
			fgrid_Main.Rows[1].AllowMerging = true;

			//	DataTable dt_list;
			txt_Factory.Text   = COM.ComVar.Parameter_PopUp[0];
			txt_OBS_ID.Text    = COM.ComVar.Parameter_PopUp[1];
			txt_OBS_Type.Text  = COM.ComVar.Parameter_PopUp[2];
			txt_Style_CD.Text  = COM.ComVar.Parameter_PopUp[3];
			txt_OBS_Nu.Text	   = COM.ComVar.Parameter_PopUp[4];
			txt_Seq_Nu.Text    = COM.ComVar.Parameter_PopUp[5];
				


			Sb_Select();
		}


		private void Sb_Select()
		{
			try
			{
				Select_OBS_Qty();
				
			}
			catch
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch,this);
			}	
		}



		#endregion

		#region DB 컨트롤
		private void  Select_OBS_Qty()
		{			
			DataSet ds_ret;

			string process_name = "PKG_SEM_GPO.SELECT_SEM_RPM_POP";

			int iCnt  = 7;

			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[5]  = "ARG_OBS_SEQ_NU";  
			MyOraDB.Parameter_Name[6]  = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i=0 ; i<iCnt-1;i++)
			{
				MyOraDB.Parameter_Type[i]  = (int)OracleType.VarChar;
			}
			MyOraDB.Parameter_Type[iCnt -1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1]  = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2]  = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_String(txt_Style_CD.Text," ");
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_String(txt_OBS_Nu.Text," ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_String(txt_Seq_Nu.Text," ");
			MyOraDB.Parameter_Values[6]  = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if (ds_ret == null)  return  ;

			DataTable dt_list;

			dt_list  =  ds_ret.Tables[process_name];

			fgrid_Main.Rows.Count = _Rowfixed;  
	 
			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				fgrid_Main.AddItem(dt_list.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
				fgrid_Main.Cols[0].Width =0;
			} 

		}

		private void  Delete_OBS()
		{			
			DataSet ds_ret;

			string process_name = "PKG_SEM_GPO.DELETE_SEM_OBS";

			int iCnt  = 7;

			MyOraDB.ReDim_Parameter(7); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_TYPE";
			MyOraDB.Parameter_Name[3]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[5]  = "ARG_OBS_SEQ_NU";  
			MyOraDB.Parameter_Name[6]  = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i=0 ; i<iCnt-1;i++)
			{
				MyOraDB.Parameter_Type[i]  = (int)OracleType.VarChar;
			}
			MyOraDB.Parameter_Type[iCnt -1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1]  = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2]  = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[3]," ");
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[4]," ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_String(COM.ComVar.Parameter_PopUp[5]," ");
			MyOraDB.Parameter_Values[6]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if (ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString() =="Y")  
				 ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete , this); 
			else
				 ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotDelete , this); 

		}


		#endregion

		#region 이벤트처리
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			Delete_OBS();
			Sb_Select();
		}

		private void lbl_Search_Click(object sender, System.EventArgs e)
		{
			Sb_Select();

			ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this);
		}


		#endregion


		private void POP_EL_RPM_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

