using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread.Model;

namespace FlexVJ_Common.Purchase
{
	public class Pop_BM_InOut_Infomation : COM.VJ_CommonWinForm.Pop_Medium
	{
		
		#region 디자이너에서 생성한 변수


		private System.Windows.Forms.Label lbl_Item;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.TextBox txt_ItemName;
		private System.Windows.Forms.TextBox txt_ItemCd;
		private System.Windows.Forms.TextBox txt_ColorName;
		private System.Windows.Forms.TextBox txt_ColorCd;
		private System.Windows.Forms.TextBox txt_SpecName;
		private System.Windows.Forms.TextBox txt_SpecCd;
		private System.Windows.Forms.Label lbl_TotQty;
		private System.Windows.Forms.TextBox txt_TotQty;
		private System.Windows.Forms.Label btn_Cancel;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.TextBox txt_DPO;
		private System.ComponentModel.IContainer components = null;

		#endregion 

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_InOut_Infomation));
			this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.pnl_main = new System.Windows.Forms.Panel();
			this.spd_main = new COM.SSP();
			this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.lbl_Spec = new System.Windows.Forms.Label();
			this.txt_TotQty = new System.Windows.Forms.TextBox();
			this.txt_SpecName = new System.Windows.Forms.TextBox();
			this.txt_SpecCd = new System.Windows.Forms.TextBox();
			this.txt_ColorName = new System.Windows.Forms.TextBox();
			this.txt_ColorCd = new System.Windows.Forms.TextBox();
			this.txt_ItemName = new System.Windows.Forms.TextBox();
			this.txt_ItemCd = new System.Windows.Forms.TextBox();
			this.lbl_TotQty = new System.Windows.Forms.Label();
			this.lbl_Item = new System.Windows.Forms.Label();
			this.ctx_grid = new System.Windows.Forms.ContextMenu();
			this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
			this.mnu_allDeselect = new System.Windows.Forms.MenuItem();
			this.txt_DPO = new System.Windows.Forms.TextBox();
			this.lbl_DPO = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.c1Sizer1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.c1Sizer1.GridDefinition = "20.5607476635514:False:True;68.9252336448598:False:False;6.77570093457944:False:T" +
				"rue;0.934579439252336:False:True;\t0.576368876080692:False:True;97.6945244956772:" +
				"False:False;0.576368876080692:False:True;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
			this.c1Sizer1.TabIndex = 27;
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
			this.btn_Cancel.Location = new System.Drawing.Point(608, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(71, 23);
			this.btn_Cancel.TabIndex = 353;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// pnl_main
			// 
			this.pnl_main.Controls.Add(this.spd_main);
			this.pnl_main.Location = new System.Drawing.Point(8, 92);
			this.pnl_main.Name = "pnl_main";
			this.pnl_main.Size = new System.Drawing.Size(678, 295);
			this.pnl_main.TabIndex = 166;
			// 
			// spd_main
			// 
			this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spd_main.Location = new System.Drawing.Point(0, 0);
			this.spd_main.Name = "spd_main";
			this.spd_main.Sheets.Add(this.spd_main_Sheet1);
			this.spd_main.Size = new System.Drawing.Size(678, 295);
			this.spd_main.TabIndex = 0;
			// 
			// spd_main_Sheet1
			// 
			this.spd_main_Sheet1.SheetName = "Sheet1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_DPO);
			this.groupBox1.Controls.Add(this.lbl_DPO);
			this.groupBox1.Controls.Add(this.lbl_Color);
			this.groupBox1.Controls.Add(this.lbl_Spec);
			this.groupBox1.Controls.Add(this.txt_TotQty);
			this.groupBox1.Controls.Add(this.txt_SpecName);
			this.groupBox1.Controls.Add(this.txt_SpecCd);
			this.groupBox1.Controls.Add(this.txt_ColorName);
			this.groupBox1.Controls.Add(this.txt_ColorCd);
			this.groupBox1.Controls.Add(this.txt_ItemName);
			this.groupBox1.Controls.Add(this.txt_ItemCd);
			this.groupBox1.Controls.Add(this.lbl_TotQty);
			this.groupBox1.Controls.Add(this.lbl_Item);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 88);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			// 
			// lbl_Color
			// 
			this.lbl_Color.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Color.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Color.ImageIndex = 0;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.Location = new System.Drawing.Point(8, 60);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 580;
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Spec
			// 
			this.lbl_Spec.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Spec.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Spec.ImageIndex = 0;
			this.lbl_Spec.ImageList = this.img_Label;
			this.lbl_Spec.Location = new System.Drawing.Point(8, 38);
			this.lbl_Spec.Name = "lbl_Spec";
			this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec.TabIndex = 579;
			this.lbl_Spec.Text = "Specification";
			this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.txt_TotQty.Text = "";
			// 
			// txt_SpecName
			// 
			this.txt_SpecName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SpecName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SpecName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SpecName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_SpecName.Location = new System.Drawing.Point(180, 38);
			this.txt_SpecName.MaxLength = 100;
			this.txt_SpecName.Name = "txt_SpecName";
			this.txt_SpecName.ReadOnly = true;
			this.txt_SpecName.Size = new System.Drawing.Size(168, 21);
			this.txt_SpecName.TabIndex = 577;
			this.txt_SpecName.Text = "";
			// 
			// txt_SpecCd
			// 
			this.txt_SpecCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SpecCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SpecCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_SpecCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_SpecCd.Location = new System.Drawing.Point(109, 38);
			this.txt_SpecCd.MaxLength = 10;
			this.txt_SpecCd.Name = "txt_SpecCd";
			this.txt_SpecCd.ReadOnly = true;
			this.txt_SpecCd.Size = new System.Drawing.Size(70, 21);
			this.txt_SpecCd.TabIndex = 576;
			this.txt_SpecCd.Text = "";
			// 
			// txt_ColorName
			// 
			this.txt_ColorName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ColorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ColorName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ColorName.Location = new System.Drawing.Point(180, 60);
			this.txt_ColorName.MaxLength = 100;
			this.txt_ColorName.Name = "txt_ColorName";
			this.txt_ColorName.ReadOnly = true;
			this.txt_ColorName.Size = new System.Drawing.Size(168, 21);
			this.txt_ColorName.TabIndex = 575;
			this.txt_ColorName.Text = "";
			// 
			// txt_ColorCd
			// 
			this.txt_ColorCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ColorCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ColorCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ColorCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ColorCd.Location = new System.Drawing.Point(109, 60);
			this.txt_ColorCd.MaxLength = 10;
			this.txt_ColorCd.Name = "txt_ColorCd";
			this.txt_ColorCd.ReadOnly = true;
			this.txt_ColorCd.Size = new System.Drawing.Size(70, 21);
			this.txt_ColorCd.TabIndex = 574;
			this.txt_ColorCd.Text = "";
			// 
			// txt_ItemName
			// 
			this.txt_ItemName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ItemName.Location = new System.Drawing.Point(180, 16);
			this.txt_ItemName.MaxLength = 100;
			this.txt_ItemName.Name = "txt_ItemName";
			this.txt_ItemName.ReadOnly = true;
			this.txt_ItemName.Size = new System.Drawing.Size(168, 21);
			this.txt_ItemName.TabIndex = 573;
			this.txt_ItemName.Text = "";
			// 
			// txt_ItemCd
			// 
			this.txt_ItemCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ItemCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ItemCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_ItemCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ItemCd.Location = new System.Drawing.Point(109, 16);
			this.txt_ItemCd.MaxLength = 10;
			this.txt_ItemCd.Name = "txt_ItemCd";
			this.txt_ItemCd.ReadOnly = true;
			this.txt_ItemCd.Size = new System.Drawing.Size(70, 21);
			this.txt_ItemCd.TabIndex = 572;
			this.txt_ItemCd.Text = "";
			// 
			// lbl_TotQty
			// 
			this.lbl_TotQty.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_TotQty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_TotQty.ImageIndex = 2;
			this.lbl_TotQty.ImageList = this.img_Label;
			this.lbl_TotQty.Location = new System.Drawing.Point(376, 60);
			this.lbl_TotQty.Name = "lbl_TotQty";
			this.lbl_TotQty.Size = new System.Drawing.Size(100, 21);
			this.lbl_TotQty.TabIndex = 183;
			this.lbl_TotQty.Text = "Total Quantity";
			this.lbl_TotQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Item
			// 
			this.lbl_Item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Item.ImageIndex = 0;
			this.lbl_Item.ImageList = this.img_Label;
			this.lbl_Item.Location = new System.Drawing.Point(8, 16);
			this.lbl_Item.Name = "lbl_Item";
			this.lbl_Item.Size = new System.Drawing.Size(100, 21);
			this.lbl_Item.TabIndex = 180;
			this.lbl_Item.Text = "Item";
			this.lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// txt_DPO
			// 
			this.txt_DPO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_DPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_DPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_DPO.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_DPO.Location = new System.Drawing.Point(477, 16);
			this.txt_DPO.MaxLength = 10;
			this.txt_DPO.Name = "txt_DPO";
			this.txt_DPO.ReadOnly = true;
			this.txt_DPO.Size = new System.Drawing.Size(195, 21);
			this.txt_DPO.TabIndex = 582;
			this.txt_DPO.Text = "";
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_Label;
			this.lbl_DPO.Location = new System.Drawing.Point(376, 16);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPO.TabIndex = 581;
			this.lbl_DPO.Text = "DPO";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_BM_InOut_Infomation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 471);
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Pop_BM_InOut_Infomation";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1Sizer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.c1Sizer1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnl_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		#region 생성자 / 소멸자

		public Pop_BM_InOut_Infomation()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
		private string _Factory;
		private string _OBS_TYPE;

		#endregion 

		#region 컨트롤 이벤트 처리 

		#region 버튼클릭시 이미지변경
 

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


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}



		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			// Form Setting
			lbl_MainTitle.Text = "Purchase Information";
			this.Text = "Purchase Information";

			// Grid Setting
			spd_main.Set_Spread_Comm("SBM_PURCHASE_INFORMATION", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			
			Mearge_GridHead();

			_Factory           = COM.ComVar.Parameter_PopUp[0];
			txt_DPO.Text       = COM.ComVar.Parameter_PopUp[1];
			_OBS_TYPE          = COM.ComVar.Parameter_PopUp[2];
			txt_ItemCd.Text    = COM.ComVar.Parameter_PopUp[3];
			txt_SpecCd.Text    = COM.ComVar.Parameter_PopUp[4];
			txt_ColorCd.Text   = COM.ComVar.Parameter_PopUp[5];
			txt_ItemName.Text  = COM.ComVar.Parameter_PopUp[6];
			txt_SpecName.Text  = COM.ComVar.Parameter_PopUp[7];
			txt_ColorName.Text = COM.ComVar.Parameter_PopUp[8];

			Search();

 
		}



		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		 
		private void Search()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				DataTable dt_ret = SELECT_SBM_PURCHASE(); 

				if (dt_ret == null || dt_ret.Rows.Count == 0) 
				{
					spd_main.ClearAll(); 
				}
				else
				{
					spd_main.Display_Grid(dt_ret);
				}

				dt_ret.Dispose();
				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
 
 

		#endregion

		#region DB Connect
 
		/// <summary>
		/// SELECT_SB_INOUT : 
		/// </summary>
		/// <returns>DataTable</returns>
		private DataTable SELECT_SBM_PURCHASE()
		{
			
			
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING_LOCAL.SELECT_PURCHASE_INFORMATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";  
			MyOraDB.Parameter_Name[2] = "ARG_OBS_TYPE";  
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComVar.Parameter_PopUp[0];
			MyOraDB.Parameter_Values[1] = COM.ComVar.Parameter_PopUp[1];
			MyOraDB.Parameter_Values[2] = COM.ComVar.Parameter_PopUp[2];
			MyOraDB.Parameter_Values[3] = COM.ComVar.Parameter_PopUp[3];
			MyOraDB.Parameter_Values[4] = COM.ComVar.Parameter_PopUp[4];
			MyOraDB.Parameter_Values[5] = COM.ComVar.Parameter_PopUp[5]; 
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		 

		#endregion

	
		
		

	}
}

