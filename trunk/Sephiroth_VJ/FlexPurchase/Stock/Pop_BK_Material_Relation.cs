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
	public class Pop_BK_Material_Relation : COM.PCHWinForm.Pop_Medium
	{
		
		#region 디자이너에서 생성한 변수

		private System.Windows.Forms.Label btn_Cancel;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ContextMenu ctx_grid;
		private System.Windows.Forms.MenuItem mnu_AllSelect;
		private System.Windows.Forms.MenuItem mnu_allDeselect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Old;
		private System.Windows.Forms.TextBox txt_OldName;
		private System.Windows.Forms.TextBox txt_OldCode;
		private System.Windows.Forms.Panel pnl_Main;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_New;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.TextBox txt_NewName;
		private System.Windows.Forms.TextBox txt_NewCode;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_ShowPop;
		private System.Windows.Forms.Label btn_Search;
		private System.ComponentModel.IContainer components = null;

		#endregion 

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BK_Material_Relation));
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.lbl_Remarks = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            this.lbl_New = new System.Windows.Forms.Label();
            this.txt_NewName = new System.Windows.Forms.TextBox();
            this.txt_NewCode = new System.Windows.Forms.TextBox();
            this.btn_ShowPop = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Old = new System.Windows.Forms.Label();
            this.txt_OldName = new System.Windows.Forms.TextBox();
            this.txt_OldCode = new System.Windows.Forms.TextBox();
            this.ctx_grid = new System.Windows.Forms.ContextMenu();
            this.mnu_AllSelect = new System.Windows.Forms.MenuItem();
            this.mnu_allDeselect = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.c1Sizer1.Controls.Add(this.pnl_Main);
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 27;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.groupBox2);
            this.pnl_Main.Location = new System.Drawing.Point(8, 58);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(678, 329);
            this.pnl_Main.TabIndex = 169;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.txt_Remarks);
            this.groupBox2.Controls.Add(this.lbl_Remarks);
            this.groupBox2.Controls.Add(this.spd_main);
            this.groupBox2.Controls.Add(this.lbl_New);
            this.groupBox2.Controls.Add(this.txt_NewName);
            this.groupBox2.Controls.Add(this.txt_NewCode);
            this.groupBox2.Controls.Add(this.btn_ShowPop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 329);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Data";
            // 
            // btn_Search
            // 
            this.btn_Search.ImageIndex = 27;
            this.btn_Search.ImageList = this.img_SmallButton;
            this.btn_Search.Location = new System.Drawing.Point(371, 19);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(23, 23);
            this.btn_Search.TabIndex = 676;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Search.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_Search.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Remarks.Location = new System.Drawing.Point(109, 42);
            this.txt_Remarks.MaxLength = 100;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(563, 21);
            this.txt_Remarks.TabIndex = 675;
            this.txt_Remarks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Remarks_KeyUp);
            // 
            // lbl_Remarks
            // 
            this.lbl_Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remarks.ImageIndex = 0;
            this.lbl_Remarks.ImageList = this.img_Label;
            this.lbl_Remarks.Location = new System.Drawing.Point(8, 42);
            this.lbl_Remarks.Name = "lbl_Remarks";
            this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remarks.TabIndex = 674;
            this.lbl_Remarks.Text = "Remarks";
            this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(8, 72);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(664, 248);
            this.spd_main.TabIndex = 673;
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // lbl_New
            // 
            this.lbl_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_New.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New.ImageIndex = 0;
            this.lbl_New.ImageList = this.img_Label;
            this.lbl_New.Location = new System.Drawing.Point(8, 20);
            this.lbl_New.Name = "lbl_New";
            this.lbl_New.Size = new System.Drawing.Size(100, 21);
            this.lbl_New.TabIndex = 583;
            this.lbl_New.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NewName
            // 
            this.txt_NewName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NewName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NewName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_NewName.Location = new System.Drawing.Point(180, 20);
            this.txt_NewName.MaxLength = 100;
            this.txt_NewName.Name = "txt_NewName";
            this.txt_NewName.ReadOnly = true;
            this.txt_NewName.Size = new System.Drawing.Size(168, 21);
            this.txt_NewName.TabIndex = 582;
            // 
            // txt_NewCode
            // 
            this.txt_NewCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NewCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NewCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NewCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_NewCode.Location = new System.Drawing.Point(109, 20);
            this.txt_NewCode.MaxLength = 10;
            this.txt_NewCode.Name = "txt_NewCode";
            this.txt_NewCode.ReadOnly = true;
            this.txt_NewCode.Size = new System.Drawing.Size(70, 21);
            this.txt_NewCode.TabIndex = 581;
            // 
            // btn_ShowPop
            // 
            this.btn_ShowPop.ImageIndex = 7;
            this.btn_ShowPop.ImageList = this.img_SmallButton;
            this.btn_ShowPop.Location = new System.Drawing.Point(348, 19);
            this.btn_ShowPop.Name = "btn_ShowPop";
            this.btn_ShowPop.Size = new System.Drawing.Size(23, 23);
            this.btn_ShowPop.TabIndex = 672;
            this.btn_ShowPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ShowPop.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_ShowPop.Click += new System.EventHandler(this.btn_ShowPop_Click);
            this.btn_ShowPop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_ShowPop.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_ShowPop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Apply);
            this.panel3.Controls.Add(this.btn_Cancel);
            this.panel3.Location = new System.Drawing.Point(8, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 29);
            this.panel3.TabIndex = 168;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.img_Button;
            this.btn_Delete.Location = new System.Drawing.Point(466, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 23);
            this.btn_Delete.TabIndex = 355;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Delete.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(537, 3);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(71, 23);
            this.btn_Apply.TabIndex = 354;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(608, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(71, 23);
            this.btn_Cancel.TabIndex = 353;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Old);
            this.groupBox1.Controls.Add(this.txt_OldName);
            this.groupBox1.Controls.Add(this.txt_OldCode);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 54);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Data";
            // 
            // lbl_Old
            // 
            this.lbl_Old.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Old.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Old.ImageIndex = 0;
            this.lbl_Old.ImageList = this.img_Label;
            this.lbl_Old.Location = new System.Drawing.Point(8, 24);
            this.lbl_Old.Name = "lbl_Old";
            this.lbl_Old.Size = new System.Drawing.Size(100, 21);
            this.lbl_Old.TabIndex = 580;
            this.lbl_Old.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_OldName
            // 
            this.txt_OldName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_OldName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OldName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_OldName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_OldName.Location = new System.Drawing.Point(180, 24);
            this.txt_OldName.MaxLength = 100;
            this.txt_OldName.Name = "txt_OldName";
            this.txt_OldName.ReadOnly = true;
            this.txt_OldName.Size = new System.Drawing.Size(168, 21);
            this.txt_OldName.TabIndex = 575;
            // 
            // txt_OldCode
            // 
            this.txt_OldCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_OldCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OldCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_OldCode.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_OldCode.Location = new System.Drawing.Point(109, 24);
            this.txt_OldCode.MaxLength = 10;
            this.txt_OldCode.Name = "txt_OldCode";
            this.txt_OldCode.ReadOnly = true;
            this.txt_OldCode.Size = new System.Drawing.Size(70, 21);
            this.txt_OldCode.TabIndex = 574;
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
            // Pop_BK_Material_Relation
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BK_Material_Relation";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		
		#region 생성자 / 소멸자

		public Pop_BK_Material_Relation()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		} 

 

		private string _Factory = "";
		private string _Division = ""; 
		private string _ItemCd = "";
		private string _SpecCd = "";
		private string _ColorCd = "";
		private string _ItemName = "";
		private string _SpecName = "";
		private string _ColorName = "";
		private string _Unit = "";

        //factory, division, item_cd, spec_cd, color_cd, item_name, spec_name, color_name, unit

		public Pop_BK_Material_Relation(string[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_parameter[0];
			_Division = arg_parameter[1]; 
			_ItemCd = arg_parameter[2];
			_SpecCd = arg_parameter[3];
			_ColorCd = arg_parameter[4];
			_ItemName = arg_parameter[5];
			_SpecName = arg_parameter[6];
			_ColorName = arg_parameter[7];
			_Unit = arg_parameter[8];


			Init_Form();



		}  






		DataTable _DtRet = null;

		public Pop_BK_Material_Relation(string arg_factory, string arg_division, DataTable arg_dt)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_Division = arg_division; 
			_DtRet = arg_dt;


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


		private void btn_ShowPop_Click(object sender, System.EventArgs e)
		{
			Show_Item_Popup();
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Display_Relation(_Factory, _Division, ClassLib.ComFunction.Empty_TextBox(txt_NewCode, ""), false);
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			spd_main.Delete_Row(img_Action);
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			Apply();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void txt_Remarks_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if(spd_main.ActiveSheet.RowCount == 0) return;
				if(spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, 0].Tag == null || 
					spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, 0].Tag.ToString() != "I") return;


				if(e.KeyCode != Keys.Enter) return;

				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxREMARKS].Text = txt_Remarks.Text;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Remarks_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // Form Setting
            ClassLib.ComFunction.SetLangDic(this); 

			string title = "";

			if(_Division == "1")
			{
				title = "Make Item Relation";

				lbl_Old.Text = "Item";
				lbl_New.Text = "Item";

				txt_OldCode.Text = _ItemCd;
				txt_OldName.Text = _ItemName;

			}
			else if(_Division == "2")
			{
				title = "Make Specification Relation";

				lbl_Old.Text = "Specification";
				lbl_New.Text = "Specification";

				txt_OldCode.Text = _SpecCd;
				txt_OldName.Text = _SpecName;

			}
			else if(_Division == "3")
			{
				title = "Make Color Relation";

				lbl_Old.Text = "Color";
				lbl_New.Text = "Specification";

				txt_OldCode.Text = _ColorCd;
				txt_OldName.Text = _ColorName;

			}

			lbl_MainTitle.Text = title;
			this.Text = title;

			// Grid Setting
			spd_main.Set_Spread_Comm("SBC_RELATION", "51", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			Mearge_GridHead();
   
			 
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


		/// <summary>
		/// Show_Item_Popup : Item 기타 데이터 입력하는 팝업 실행 : Item/ Specification/ Color
		/// </summary>
		private void Show_Item_Popup()
		{
			try
			{
				 
				string item_cd = _ItemCd; 
				string item_name = _ItemName; 
				string spec_cd = _SpecCd; 
				string spec_name = _SpecName; 
				string color_cd = _ColorCd; 
				string color_name = _ColorName; 
				string unit = _Unit;  
				string size_yn = "N"; 
				bool default_view = false;
 

				ClassLib.ComVar.Parameter_PopUp = null; 

				//----------------------------------------------------------------------------------------------------------------------------
				// 선택 항목 바로 설정할 수 있도록 팝업 창 페이지 초기 설정
				//----------------------------------------------------------------------------------------------------------------------------
				string select = "";
				
				if(_Division == "1")
				{
					select = "Item";
				}
				else if(_Division == "2")
				{
					select = "Spec";
				}
				else if(_Division == "3")
				{
					select = "Color";
				} 

				COM.ComVar.Parameter_PopUp = new string[] { select };
				//----------------------------------------------------------------------------------------------------------------------------


				FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List(item_cd, item_name, spec_cd, spec_name, color_cd, color_name, unit, size_yn, default_view);
				pop_form.ShowDialog();


				//----------------------------------------------------------------------------------------------------------------------------
				// New Data Setting
				//---------------------------------------------------------------------------------------------------------------------------- 
				bool same_flag = false;

				if(_Division == "1")
				{

					same_flag = (txt_OldCode.Text == ClassLib.ComVar.Parameter_PopUp[0]) ? true : false;
  
					txt_NewCode.Text = ClassLib.ComVar.Parameter_PopUp[0];
					txt_NewName.Text = ClassLib.ComVar.Parameter_PopUp[1];
 
				}
				else if(_Division == "2")
				{
					
					same_flag = (txt_OldCode.Text == ClassLib.ComVar.Parameter_PopUp[2]) ? true : false; 
					 
					txt_NewCode.Text = ClassLib.ComVar.Parameter_PopUp[2];
					txt_NewName.Text = ClassLib.ComVar.Parameter_PopUp[3];


				}
				else if(_Division == "3")
				{

					same_flag = (txt_OldCode.Text == ClassLib.ComVar.Parameter_PopUp[4]) ? true : false;
 
					txt_NewCode.Text = ClassLib.ComVar.Parameter_PopUp[4];
					txt_NewName.Text = ClassLib.ComVar.Parameter_PopUp[5];


				} 

 


				if(same_flag)
				{ 
					Display_Relation(_Factory, _Division, ClassLib.ComFunction.Empty_TextBox(txt_NewCode, ""), false);
				}
				else
				{
					Display_Relation(_Factory, _Division, ClassLib.ComFunction.Empty_TextBox(txt_NewCode, ""), true);
				}

				 

				//----------------------------------------------------------------------------------------------------------------------------
 

				pop_form.Dispose(); 
 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 
 
		/// <summary>
		/// Display_Relation : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_division"></param>
		/// <param name="arg_new_code"></param>
		private void Display_Relation(string arg_factory, string arg_division, string arg_new_code, bool arg_new_visible)
		{
			try
			{
				
				this.Cursor = Cursors.WaitCursor;
  
			 
 				bool exist_flag = false;

				DataTable dt_ret = SELECT_SBC_RELATION(arg_factory, arg_division, arg_new_code); 

				if (dt_ret == null || dt_ret.Rows.Count == 0) 
				{

					spd_main.ClearAll();  

					if(arg_new_visible) 
					{
						spd_main.Add_Row(img_Action);
					}


				}
				else
				{
					spd_main.Display_Grid(dt_ret); 


					if(arg_new_visible) 
					{

						// 파라미터로 넘어온 데이터 테이블의 리스트와 비교해서
						// 기존에 있는 데이터면 표시하지 않고 pass 

						if(spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, 0].Tag == null || 
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, 0].Tag.ToString() != "I")
						{


							if(_Division == "1")
							{ 
							}
							else
							{
								spd_main.Add_Row(img_Action);
							}

							
						}

					} // end if(arg_new_visible) 



				}
				  
				
				if(arg_new_visible) 
				{

					if(_Division == "1")
					{

						for(int i = 0; i < _DtRet.Rows.Count; i++)
						{
							exist_flag = false;

							for(int j = 0; j < spd_main.ActiveSheet.Rows.Count; j++)
							{
								if(spd_main.ActiveSheet.Cells[j, 0].Tag != null && 
									spd_main.ActiveSheet.Cells[j, 0].Tag.ToString() == "I") continue;

								if(_DtRet.Rows[i].ItemArray[0].ToString() == spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_RELATION.IxOLD_CODE].Text)
								{ 
									exist_flag = true;
									break;
								} 

							} // end for j

							if(exist_flag) continue;
									 
							spd_main.Add_Row(img_Action);

							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxFACTORY].Text = arg_factory;
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxDIVISION].Text = arg_division;
							
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxOLD_CODE].Text 
								= _DtRet.Rows[i].ItemArray[0].ToString();
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxOLD_NAME].Text 
								= _DtRet.Rows[i].ItemArray[1].ToString();
							
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxNEW_CODE].Text = txt_NewCode.Text;
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxNEW_NAME].Text = txt_NewName.Text;
							spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxREMARKS].Text = txt_Remarks.Text;



						} // end for i

 

					}
					else
					{
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxFACTORY].Text = arg_factory;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxDIVISION].Text = arg_division;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxOLD_CODE].Text = txt_OldCode.Text;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxOLD_NAME].Text = txt_OldName.Text;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxNEW_CODE].Text = txt_NewCode.Text;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxNEW_NAME].Text = txt_NewName.Text;
						spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.Rows.Count - 1, (int)ClassLib.TBSBC_RELATION.IxREMARKS].Text = txt_Remarks.Text;
					}

					
				}

  
				dt_ret.Dispose();
				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Relation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}
 
 
		private void Apply()
		{

			bool save_flag = SAVE_SBC_RELATION();

			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			else
			{ 
				Display_Relation(_Factory, _Division, ClassLib.ComFunction.Empty_TextBox(txt_NewCode, ""), false ); 
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 
			}


		}

		

		#endregion

		#region DB Connect
 
		/// <summary>
		/// SELECT_SBC_RELATION : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_division"></param>
		/// <param name="arg_new_code"></param>
		/// <returns></returns>
		private DataTable SELECT_SBC_RELATION(string arg_factory, string arg_division, string arg_new_code)
		{
			
			
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.SELECT_SBC_RELATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DIVISION"; 
			MyOraDB.Parameter_Name[2] = "ARG_NEW_CODE"; 
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_division; 
			MyOraDB.Parameter_Values[2] = arg_new_code; 
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		 
		/// <summary>
		/// SAVE_SBC_RELATION : 
		/// </summary>
		/// <returns></returns>
		private bool SAVE_SBC_RELATION()
		{
 
			try
			{

				  
				MyOraDB.ReDim_Parameter(7);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBK_STOCK_CLOSE.SAVE_SBC_RELATION";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FLAG";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[3] = "ARG_OLD_CODE";
				MyOraDB.Parameter_Name[4] = "ARG_NEW_CODE"; 
				MyOraDB.Parameter_Name[5] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;

				//04.DATA 정의
				ArrayList vList = new ArrayList(); 

				for (int vRow = 0 ; vRow < spd_main.ActiveSheet.RowCount ; vRow++)
				{

					if(spd_main.ActiveSheet.Cells[vRow, 0].Tag == null || 
						spd_main.ActiveSheet.Cells[vRow, 0].Tag.ToString() == "") continue;

					vList.Add(spd_main.ActiveSheet.Cells[vRow, 0].Tag);
					vList.Add(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBC_RELATION.IxFACTORY].Text);
					vList.Add(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBC_RELATION.IxDIVISION].Text);
					vList.Add(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBC_RELATION.IxOLD_CODE].Text);
					vList.Add(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBC_RELATION.IxNEW_CODE].Text);
					vList.Add(spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBC_RELATION.IxREMARKS].Text); 
					vList.Add(COM.ComVar.This_User);


				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);
				MyOraDB.Exe_Modify_Procedure();

				return true;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SAVE_SBC_RELATION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}




		}


		#endregion

		
 
		

	}
}

