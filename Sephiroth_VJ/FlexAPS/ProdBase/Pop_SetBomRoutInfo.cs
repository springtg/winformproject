using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using Lassalle.Flow;

namespace FlexAPS.ProdBase
{
	public class Pop_SetBomRoutInfo : COM.APSWinForm.Pop_Large
	{ 

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Commit;
		private Lassalle.Flow.AddFlow addflow_Rout;
		public COM.FSP fgrid_LinkRout;
		public COM.FSP fgrid_NodeRout;
		public COM.FSP fgrid_LinkDef;
		public COM.FSP fgrid_NodeDef;
		public COM.FSP fgrid_Rout;
		private System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.ContextMenu cmenu_Rout;
		private System.Windows.Forms.MenuItem menuItem_Add;
		private System.Windows.Forms.MenuItem menuItem_Update;
		private System.Windows.Forms.MenuItem menuItem_Delete;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_NodeProp;
		private System.Windows.Forms.MenuItem menuItem_LinkProp;
		private System.Windows.Forms.Label btn_Refresh;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetBomRoutInfo()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetBomRoutInfo));
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.addflow_Rout = new Lassalle.Flow.AddFlow();
			this.cmenu_Rout = new System.Windows.Forms.ContextMenu();
			this.menuItem_Add = new System.Windows.Forms.MenuItem();
			this.menuItem_Update = new System.Windows.Forms.MenuItem();
			this.menuItem_Delete = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem_NodeProp = new System.Windows.Forms.MenuItem();
			this.menuItem_LinkProp = new System.Windows.Forms.MenuItem();
			this.fgrid_LinkRout = new COM.FSP();
			this.fgrid_NodeRout = new COM.FSP();
			this.fgrid_LinkDef = new COM.FSP();
			this.fgrid_NodeDef = new COM.FSP();
			this.fgrid_Rout = new COM.FSP();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.btn_Refresh = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Rout)).BeginInit();
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
			this.lbl_MainTitle.Text = "";
			// 
			// btn_Commit
			// 
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(545, 432);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(70, 23);
			this.btn_Commit.TabIndex = 48;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(616, 432);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 49;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// addflow_Rout
			// 
			this.addflow_Rout.AutoScroll = true;
			this.addflow_Rout.AutoScrollMinSize = new System.Drawing.Size(603, 506);
			this.addflow_Rout.BackColor = System.Drawing.SystemColors.Window;
			this.addflow_Rout.CanDrawNode = false;
			this.addflow_Rout.ContextMenu = this.cmenu_Rout;
			this.addflow_Rout.Location = new System.Drawing.Point(239, 46);
			this.addflow_Rout.Name = "addflow_Rout";
			this.addflow_Rout.Size = new System.Drawing.Size(447, 376);
			this.addflow_Rout.TabIndex = 50;
			this.addflow_Rout.AfterResize += new Lassalle.Flow.AddFlow.AfterResizeEventHandler(this.addflow_Rout_AfterResize);
			this.addflow_Rout.AfterAddLink += new Lassalle.Flow.AddFlow.AfterAddLinkEventHandler(this.addflow_Rout_AfterAddLink);
			this.addflow_Rout.AfterMove += new Lassalle.Flow.AddFlow.AfterMoveEventHandler(this.addflow_Rout_AfterMove);
			// 
			// cmenu_Rout
			// 
			this.cmenu_Rout.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem_Add,
																					   this.menuItem_Update,
																					   this.menuItem_Delete,
																					   this.menuItem1,
																					   this.menuItem_NodeProp,
																					   this.menuItem_LinkProp});
			// 
			// menuItem_Add
			// 
			this.menuItem_Add.Index = 0;
			this.menuItem_Add.Text = "Add";
			this.menuItem_Add.Click += new System.EventHandler(this.menuItem_Add_Click);
			// 
			// menuItem_Update
			// 
			this.menuItem_Update.Index = 1;
			this.menuItem_Update.Text = "Update ";
			this.menuItem_Update.Click += new System.EventHandler(this.menuItem_Update_Click);
			// 
			// menuItem_Delete
			// 
			this.menuItem_Delete.Index = 2;
			this.menuItem_Delete.Text = "Delete";
			this.menuItem_Delete.Click += new System.EventHandler(this.menuItem_Delete_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 3;
			this.menuItem1.Text = "-";
			// 
			// menuItem_NodeProp
			// 
			this.menuItem_NodeProp.Index = 4;
			this.menuItem_NodeProp.Text = "Node Property";
			this.menuItem_NodeProp.Click += new System.EventHandler(this.menuItem_NodeProp_Click);
			// 
			// menuItem_LinkProp
			// 
			this.menuItem_LinkProp.Index = 5;
			this.menuItem_LinkProp.Text = "Link Property";
			this.menuItem_LinkProp.Click += new System.EventHandler(this.menuItem_LinkProp_Click);
			// 
			// fgrid_LinkRout
			// 
			this.fgrid_LinkRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LinkRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LinkRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link rout\";}\t";
			this.fgrid_LinkRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LinkRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LinkRout.Location = new System.Drawing.Point(520, 336);
			this.fgrid_LinkRout.Name = "fgrid_LinkRout";
			this.fgrid_LinkRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LinkRout.Size = new System.Drawing.Size(144, 56);
			this.fgrid_LinkRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LinkRout.TabIndex = 52;
			this.fgrid_LinkRout.Visible = false;
			// 
			// fgrid_NodeRout
			// 
			this.fgrid_NodeRout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_NodeRout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_NodeRout.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node rout\";}\t";
			this.fgrid_NodeRout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_NodeRout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_NodeRout.Location = new System.Drawing.Point(376, 336);
			this.fgrid_NodeRout.Name = "fgrid_NodeRout";
			this.fgrid_NodeRout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_NodeRout.Size = new System.Drawing.Size(144, 56);
			this.fgrid_NodeRout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_NodeRout.TabIndex = 51;
			this.fgrid_NodeRout.Visible = false;
			// 
			// fgrid_LinkDef
			// 
			this.fgrid_LinkDef.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_LinkDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_LinkDef.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"link def\";}\t";
			this.fgrid_LinkDef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_LinkDef.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_LinkDef.Location = new System.Drawing.Point(520, 280);
			this.fgrid_LinkDef.Name = "fgrid_LinkDef";
			this.fgrid_LinkDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_LinkDef.Size = new System.Drawing.Size(144, 56);
			this.fgrid_LinkDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_LinkDef.TabIndex = 55;
			this.fgrid_LinkDef.Visible = false;
			// 
			// fgrid_NodeDef
			// 
			this.fgrid_NodeDef.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_NodeDef.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_NodeDef.ColumnInfo = "10,1,0,0,0,95,Columns:0{Caption:\"node def\";}\t";
			this.fgrid_NodeDef.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_NodeDef.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_NodeDef.Location = new System.Drawing.Point(376, 280);
			this.fgrid_NodeDef.Name = "fgrid_NodeDef";
			this.fgrid_NodeDef.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_NodeDef.Size = new System.Drawing.Size(144, 56);
			this.fgrid_NodeDef.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_NodeDef.TabIndex = 54;
			this.fgrid_NodeDef.Visible = false;
			// 
			// fgrid_Rout
			// 
			this.fgrid_Rout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_Rout.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Rout.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Rout.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Rout.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Rout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Rout.Location = new System.Drawing.Point(6, 46);
			this.fgrid_Rout.Name = "fgrid_Rout";
			this.fgrid_Rout.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Rout.Size = new System.Drawing.Size(232, 376);
			this.fgrid_Rout.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:122, 160, 200;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Rout.TabIndex = 56;
			this.fgrid_Rout.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Rout_AfterEdit);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Refresh.ImageIndex = 0;
			this.btn_Refresh.ImageList = this.img_Button;
			this.btn_Refresh.Location = new System.Drawing.Point(474, 432);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(70, 23);
			this.btn_Refresh.TabIndex = 58;
			this.btn_Refresh.Text = "Refresh";
			this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_SetBomRoutInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.fgrid_Rout);
			this.Controls.Add(this.fgrid_LinkDef);
			this.Controls.Add(this.fgrid_NodeDef);
			this.Controls.Add(this.fgrid_LinkRout);
			this.Controls.Add(this.fgrid_NodeRout);
			this.Controls.Add(this.addflow_Rout);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Commit);
			this.Name = "Pop_SetBomRoutInfo";
			this.Text = "Update BOM Routing Information";
			this.Load += new System.EventHandler(this.Pop_SetBomRoutInfo_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Commit, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.addflow_Rout, 0);
			this.Controls.SetChildIndex(this.fgrid_NodeRout, 0);
			this.Controls.SetChildIndex(this.fgrid_LinkRout, 0);
			this.Controls.SetChildIndex(this.fgrid_NodeDef, 0);
			this.Controls.SetChildIndex(this.fgrid_LinkDef, 0);
			this.Controls.SetChildIndex(this.fgrid_Rout, 0);
			this.Controls.SetChildIndex(this.btn_Refresh, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkRout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeRout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_LinkDef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_NodeDef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Rout)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의  

		private COM.OraDB MyOraDB = new COM.OraDB();

		//파라미터로 넘어온 데이터 저장
		private string _Factory, _BomCd, _CmpCd, _RoutType; 
		private int _Rowfixed;
		private Lassalle.Flow.Node _AddNode;
		//새로 생기는 노드, 링크 순번, 중복 없애기 위함 
		private int _Node_Index = 0;
		private int _Link_Index = 0;
		//링크 삭제 처리를 저장에서 하지 않고 바로 하기 위해서 플래그 저장
		private bool _Link_Delete; 
		private string _Link_Delete_Org, _Link_Delete_Dst;

		#endregion 

		#region 멤버 메서드


		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{  
			DataSet ds_ret;
			DataTable dt_node, dt_link;

			_Factory = ClassLib.ComVar.Parameter_PopUp[0]; 
			_BomCd = ClassLib.ComVar.Parameter_PopUp[1]; 
			_CmpCd = ClassLib.ComVar.Parameter_PopUp[2]; 
			_RoutType = ClassLib.ComVar.Parameter_PopUp[3];

			//Title
			this.Text = "Update BOM Routing Information";
			this.lbl_MainTitle.Size = new Size(630, 23);
			this.lbl_MainTitle.Font = new Font("Verdana", 9, FontStyle.Bold);
			this.lbl_MainTitle.Text = "Factory : " + _Factory + ",  BOM Code : " + _BomCd 
									+ ",  Component : " + _CmpCd + ",  Routing Type : " + _RoutType;

			ClassLib.ComFunction.SetLangDic(this);

			


			fgrid_Rout.Set_Grid("BOM_ROUT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Rout.Set_Action_Image(img_Action);
			
			fgrid_NodeRout.Set_Grid("NODE_ROUT", "1", 1, ClassLib.ComVar.This_Lang, true); 
			fgrid_LinkRout.Set_Grid("LINK_ROUT", "1", 1, ClassLib.ComVar.This_Lang, true); 
			_Rowfixed = fgrid_Rout.Rows.Fixed; 

			//Default Node, Link 속성 세팅
			ds_ret = Select_Default_NodeLinkProp();
			dt_node = ds_ret.Tables["PKG_SPB_OPCD.SELECT_OPTYPE_LIST"];
			dt_link = ds_ret.Tables["PKG_SPB_BOM.SELECT_LINKPROP_LIST"];
			Display_Grid(dt_node, fgrid_NodeDef);
			Display_Grid(dt_link, fgrid_LinkDef);

			//Routing 데이터(노드, 링크 표시)
			Display_Rout_Info();
			
		}

		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 
				} 
 
				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
		} 

		
	  
		/// <summary>
		/// Display_Rout_Info : Rout 데이터 표시
		/// </summary>
		private void Display_Rout_Info()
		{
			
			DataSet ds_ret;
			DataTable dt_ret, dt_node, dt_link;

			try
			{ 
				dt_ret = Select_SPB_ROUT_BOM();
				Display_Grid(dt_ret, fgrid_Rout);
				ClassLib.ComFunction.Clear_AddFlow(addflow_Rout);

				ds_ret = Select_SPB_ROUT_BOM_NodeLink();
				dt_node = ds_ret.Tables["PKG_SPB_ROUT.SELECT_BOMROUT_NODE"];
				dt_link = ds_ret.Tables["PKG_SPB_ROUT.SELECT_BOMROUT_LINK"];
				Display_Grid(dt_node, fgrid_NodeRout);
				Display_Node();
				Display_Grid(dt_link, fgrid_LinkRout);
				Display_Link();

			}
			catch
			{
			}
		}


		/// <summary>
		/// Display_Node : Addflow에 노드 표시
		/// </summary>
		private void Display_Node()
		{
			Lassalle.Flow.Node node;
			_Node_Index = 0;

			for(int i = _Rowfixed; i < fgrid_NodeRout.Rows.Count; i++)
			{ 
				node = new Lassalle.Flow.Node();

				node = addflow_Rout.Nodes.Add(Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxLEFT].ToString()), 
					Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOP].ToString()), 
					Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH].ToString()), 
					Convert.ToSingle(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxHEIGHT].ToString()), "");
				node.Text =  fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTEXT].ToString();
				node.Tooltip = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxTOOLTIP].ToString();
				node.Tag = fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString(); 
 				
				ClassLib.ComFunction.Set_NodeProp(fgrid_NodeRout, node, i);

				for(int j = _Rowfixed; j < fgrid_Rout.Rows.Count; j++)
				{
					if(fgrid_NodeRout[i, (int)ClassLib.TBSPB_NODE_ROUT.IxROUT_SEQ].ToString() == fgrid_Rout[j, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString())
					{
						fgrid_Rout[j, (int)ClassLib.TBSPB_ROUT_BOM.IxNODE_NO] = _Node_Index;
						break;
					}
				}

				_Node_Index++;
  
			} //end for 
		}

		/// <summary>
		/// Display_Link : Addflow에 링크 표시
		/// </summary>
		private void Display_Link()
		{
			Lassalle.Flow.Link link;
			int max_index = _Link_Index;

			for(int i = _Rowfixed; i < fgrid_LinkRout.Rows.Count; i++)
			{ 
				link = new Lassalle.Flow.Link(); 
	  
				link = addflow_Rout.Nodes[ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxORG_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed)]
					.OutLinks.Add(addflow_Rout.Nodes[ClassLib.ComFunction.Get_Index(fgrid_NodeRout, fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxDST_NODE].ToString(), (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD, _Rowfixed)]);
				
				link.Tag = fgrid_LinkRout[i, (int)ClassLib.TBSPB_LINK_ROUT.IxTAG].ToString(); 
 
				ClassLib.ComFunction.Set_LinkProp(fgrid_LinkRout, link, i);


				if(max_index <= Convert.ToInt32(link.Tag))  max_index = Convert.ToInt32(link.Tag); 
				 
				
			} // end for

			_Link_Index = max_index + 1;
   
		}
  

		#endregion 

		#region 이벤트 처리 

		 
 
		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			Display_Rout_Info();
		}

		
		private void btn_Commit_Click(object sender, System.EventArgs e)
		{ 
			Save_BOMRout(); 
			Display_Rout_Info();
		}

	
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void fgrid_Rout_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			bool digit_flag = false;

			try
			{
				digit_flag = ClassLib.ComFunction.Check_Digit(fgrid_Rout[e.Row, e.Col].ToString());
				if(digit_flag == false) return;

				fgrid_Rout[e.Row, e.Col] = fgrid_Rout[e.Row, e.Col].ToString().PadLeft(3, '0');
				fgrid_Rout.Update_Row(e.Row); 
				fgrid_Rout.AutoSizeCols(); 
			}
			catch
			{
			}
		}


		private void addflow_Rout_AfterAddLink(object sender, Lassalle.Flow.AfterAddLinkEventArgs e)
		{
			for(int i = fgrid_LinkDef.Rows.Fixed; i < fgrid_LinkDef.Rows.Count; i++)
			{
				if(fgrid_LinkDef[i, (int)ClassLib.TBSPB_LINK_DEF.IxLINK_TYPE].ToString() == ClassLib.ComVar.RoutLinkType)
				{ 
					ClassLib.ComFunction.Set_LinkProp(fgrid_LinkDef, e.Link, i);

					if(_Link_Index == -1) _Link_Index = 0;
			 
					e.Link.Tag = _Link_Index;
					_Link_Index++;

					break;
				}
			}
		}
 

		private void addflow_Rout_AfterMove(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(addflow_Rout.SelectedItem.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U";
					}
				}
			}
			catch
			{
			}
		}

		private void addflow_Rout_AfterResize(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(addflow_Rout.SelectedItem.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U";
					}
				}
			}
			catch
			{
			}
		}

		  
	
		#region 저장 관련

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

		/// <summary>
		/// Save_StdRout : SPB_ROUT, SPB_NODE_ROUT, SPB_LINK_ROUT 저장
		/// </summary>
		/// <returns></returns>
		private bool Save_BOMRout()
		{
			try
			{
				//행 수정 상태 해제
				fgrid_Rout.Select(fgrid_Rout.Selection.r1, 0, fgrid_Rout.Selection.r1, fgrid_Rout.Cols.Count-1, false);
 
				fgrid_Rout.Sort(new MyComparer(fgrid_Rout)); 

				Make_SAVE_SPB_ROUT_BOM();
				Make_SAVE_SPB_NODE_ROUT_BOM();
				Make_SAVE_SPB_LINK_ROUT_BOM();

				MyOraDB.Exe_Modify_Procedure(); 
				return true;
			}
			catch
			{
				return false;
			}
		}


		/// <summary>
		/// Make_SAVE_SPB_ROUT_BOM : SPB_ROUT_BOM 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_ROUT_BOM()
		{
			int col_ct = fgrid_Rout.Cols.Count - 3;		// 칼럼의 수 
			int save_ct =0 ;							// 저장 행 수 
			int para_ct =0;								// 파라미터 값의 저장 배열의 수 
			int count = 0;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_ROUT_BOM";
 
				MyOraDB.Parameter_Name[count] = "ARG_DIVISION";
				count++;

				for(int i = 1; i < col_ct + 1; i++)
				{
					if(i == (int)ClassLib.TBSPB_ROUT_BOM.IxUPD_YMD) continue;
					MyOraDB.Parameter_Name[count] = "ARG_" + fgrid_Rout[0, i].ToString(); 
					count++;
				}
 
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				for(int i = _Rowfixed ; i < fgrid_Rout.Rows.Count; i++)
				{
					if(fgrid_Rout[i, 0].ToString() != "") save_ct += 1; 
				}
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ]; 
  
				for(int row = fgrid_Rout.Rows.Count - 1; row >= _Rowfixed; row--)
				{
					if(fgrid_Rout[row, 0].ToString() != "")
					{ 
						for(int col = 0; col < col_ct + 1; col++)	// 각 열의 값 Setting
						{  
							if(col == (int)ClassLib.TBSPB_ROUT_BOM.IxUPD_YMD) continue;

							// 데이터값 설정 
							if(fgrid_Rout.Cols[col].Style.DataType != null
								&& fgrid_Rout.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								fgrid_Rout[row, col] = (fgrid_Rout[row, col] == null) ? "False" : fgrid_Rout[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							} 
							else if(col == (int)ClassLib.TBSPB_ROUT_BOM.IxUPD_USER) 
							{
								MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;
								para_ct ++;
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[row, col] == null) ? "" : fgrid_Rout[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가  
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_ROUT_BOM",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		
		/// <summary>
		/// Make_SAVE_SPB_NODE_ROUT_BOM : SPB_NODE_ROUT_BOM 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_NODE_ROUT_BOM()
		{
			int col_ct = 28;		 
			int save_ct =0 ;							 
			int para_ct =0;	 
			int index = 0;
			Lassalle.Flow.Node node;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_NODE_ROUTBOM";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[3] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[5] = "ARG_ROUT_SEQ";
				for(int i = (int)ClassLib.TBSPB_NODE_ROUT.IxNODE_CD; i <= (int)ClassLib.TBSPB_NODE_ROUT.IxWIDTH; i++)
				{
					MyOraDB.Parameter_Name[i + 4] = "ARG_" + fgrid_NodeRout[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[26] = "ARG_UPD_USER";
				MyOraDB.Parameter_Name[27] = "ARG_H_ROUT_SEQ"; 

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				for(int i = _Rowfixed ; i < fgrid_Rout.Rows.Count; i++) save_ct += 1;  
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ]; 

				for(int i = fgrid_Rout.Rows.Count - 1; i >= _Rowfixed; i--)
				{ 
					foreach(Item item in addflow_Rout.Items)
					{
						if(item is Lassalle.Flow.Node)
						{
							node = (Lassalle.Flow.Node)item;
 
							//저장 대상 품목 코드와 일치하는 노드
							if((node.Tag).ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxH_ROUT_SEQ].ToString())
							{
								index = Convert.ToInt32(fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxNODE_NO].ToString());  //node.Index;
								RectangleF rc = node.Rect; 

								MyOraDB.Parameter_Values[para_ct] = (fgrid_Rout[i, 0].ToString() == "") ? "U" : fgrid_Rout[i, 0].ToString();
								MyOraDB.Parameter_Values[para_ct + 1] = _Factory;  
								MyOraDB.Parameter_Values[para_ct + 2] = _BomCd;  
								MyOraDB.Parameter_Values[para_ct + 3] = _CmpCd;
								MyOraDB.Parameter_Values[para_ct + 4] = _RoutType;
								MyOraDB.Parameter_Values[para_ct + 5] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString();  
								MyOraDB.Parameter_Values[para_ct + 6] = string.Format("{0:0000}", index); //cmb_RFactory.SelectedValue.ToString() + cmb_RCmpCd.SelectedValue.ToString() + string.Format("{0:0000}", index);
								MyOraDB.Parameter_Values[para_ct + 7] = rc.Left.ToString();
								MyOraDB.Parameter_Values[para_ct + 8] = rc.Top.ToString();
								MyOraDB.Parameter_Values[para_ct + 9] = node.Alignment.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 10] = node.DashStyle.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 11] = node.DrawColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 12] = node.DrawWidth.ToString();
								MyOraDB.Parameter_Values[para_ct + 13] = node.FillColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 14] = node.Font.Name + "/"
									+ node.Font.Size + "/"
									+ node.Font.Bold + "/"
									+ (node.Font.Italic ? true : false) + "/"
									+ (node.Font.Strikeout ? true : false) + "/"
									+ (node.Font.Underline ? true : false);  

								MyOraDB.Parameter_Values[para_ct + 15] = (node.Gradient ? "Y" : "N");
								MyOraDB.Parameter_Values[para_ct + 16] = node.GradientColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 17] = node.GradientMode.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 18] = rc.Height.ToString();
								MyOraDB.Parameter_Values[para_ct + 19] = node.Shadow.Style.GetHashCode().ToString() + "/"
									+ node.Shadow.Color.ToArgb().ToString() + "/"
									+ node.Shadow.Size.Width.ToString() + "/"
									+ node.Shadow.Size.Height.ToString();
								MyOraDB.Parameter_Values[para_ct + 20] = node.Shape.Style.GetHashCode().ToString();
								MyOraDB.Parameter_Values[para_ct + 21] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString();
								MyOraDB.Parameter_Values[para_ct + 22] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxOP_CD].ToString();
								MyOraDB.Parameter_Values[para_ct + 23] = node.TextColor.ToArgb().ToString();
								MyOraDB.Parameter_Values[para_ct + 24] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxOP_CD].ToString() 
									+ "(" + fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ].ToString() + ")";
								MyOraDB.Parameter_Values[para_ct + 25] = rc.Width.ToString(); 
								MyOraDB.Parameter_Values[para_ct + 26] = ClassLib.ComVar.This_User;
								MyOraDB.Parameter_Values[para_ct + 27] = fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxH_ROUT_SEQ].ToString();
		
								para_ct += col_ct;  
							} 

						}//end if 
					}//end foreach  
				}// end for

				MyOraDB.Add_Modify_Parameter(false);		   
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_NODE_ROUT_BOM",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}

		}

		/// <summary>
		/// Make_SAVE_SPB_LINK_ROUT_BOM : SPB_LINK_ROUT_BOM 저장 테이블 구성
		/// </summary>
		private void Make_SAVE_SPB_LINK_ROUT_BOM()
		{
			int col_ct = 24;		 
			int save_ct =0 ;							 
			int para_ct =0;	 
			int index = 0;
			Lassalle.Flow.Link link;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct); 
				MyOraDB.Process_Name = "PKG_SPB_ROUT.SAVE_SPB_LINK_ROUTBOM";
  
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[3] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[5] = "ARG_LINK_SEQ";
				MyOraDB.Parameter_Name[6] = "ARG_ORG_NODE";
				MyOraDB.Parameter_Name[7] = "ARG_DST_NODE";
				MyOraDB.Parameter_Name[8] = "ARG_POINT";
				for(int i = (int)ClassLib.TBSPB_LINK_ROUT.IxARROW_DST; i <= (int)ClassLib.TBSPB_LINK_ROUT.IxTOOLTIP; i++)
				{
					MyOraDB.Parameter_Name[i + 6] = "ARG_" + fgrid_LinkRout[0, i].ToString(); 
				} 
				MyOraDB.Parameter_Name[23] = "ARG_UPD_USER"; 

				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
	 
				foreach(Item item in addflow_Rout.Items)
				{
					if(item is Lassalle.Flow.Link) save_ct += 1;
				} 
 
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct ];  

				foreach(Item item in addflow_Rout.Items)
				{
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;
 
						index = Convert.ToInt32(link.Tag.ToString());
  
						if(_Link_Delete_Org == link.Org.Index.ToString() && _Link_Delete_Dst == link.Dst.Index.ToString())
						{
							if(_Link_Delete)
							{
								MyOraDB.Parameter_Values[para_ct] = "D"; 
								_Link_Delete = false;
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = "I"; 
							}
							
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct] = "I"; 
						}
   
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory;  
						MyOraDB.Parameter_Values[para_ct + 2] = _BomCd;
						MyOraDB.Parameter_Values[para_ct + 3] = _CmpCd;  
						MyOraDB.Parameter_Values[para_ct + 4] =_RoutType;  
						MyOraDB.Parameter_Values[para_ct + 5] = string.Format("{0:000000}", index);
						MyOraDB.Parameter_Values[para_ct + 6] = link.Org.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 7] = link.Dst.Index.ToString();
						MyOraDB.Parameter_Values[para_ct + 8] = "";  //point
						MyOraDB.Parameter_Values[para_ct + 9] = link.ArrowDst.Style.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Size.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowDst.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 10] = link.ArrowMid.Style.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Size.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowMid.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 11] = link.ArrowOrg.Style.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Size.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Angle.GetHashCode().ToString() + "/"
							+ link.ArrowOrg.Filled.ToString();
						MyOraDB.Parameter_Values[para_ct + 12] = link.DashStyle.GetHashCode().ToString();
						MyOraDB.Parameter_Values[para_ct + 13] = link.DrawColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 14] = link.DrawWidth.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 15] = link.Font.Name + "/"
							+ link.Font.Size + "/"
							+ link.Font.Bold + "/"
							+ (link.Font.Italic ? true : false) + "/"
							+ (link.Font.Strikeout ? true : false) + "/"
							+ (link.Font.Underline ? true : false) ;
						MyOraDB.Parameter_Values[para_ct + 16] = link.Jump.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 17] = link.Line.Style.GetHashCode().ToString(); 
						MyOraDB.Parameter_Values[para_ct + 18] = link.Line.RoundedCorner.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 19] = link.Tag.ToString();
						MyOraDB.Parameter_Values[para_ct + 20] = "";     //link.Text.ToString();
						MyOraDB.Parameter_Values[para_ct + 21] = "";     //link.TextColor.ToArgb().ToString();
						MyOraDB.Parameter_Values[para_ct + 22] = "";     //link.Tooltip.ToString(); 
						MyOraDB.Parameter_Values[para_ct + 23] = ClassLib.ComVar.This_User; 
 
						para_ct += col_ct;   
					}  
				} 
 

				MyOraDB.Add_Modify_Parameter(false);		   
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Make_SAVE_SPB_LINK_ROUT_BOM",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		#endregion



		private void menuItem_Add_Click(object sender, System.EventArgs e)
		{ 
			try
			{ 
				Pop_SetRoutInfo pop_form = new Pop_SetRoutInfo();

				//factory, rout_seq, op_cd
				ClassLib.ComVar.Parameter_PopUp = new string[] {_Factory, "", ""};
				pop_form.ShowDialog(); 

				if(!pop_form._CloseSave) return;

				//routseq, opcd, optype
				//---------------------------------------------------------------
				//Add Node
				_AddNode = addflow_Rout.Nodes.Add(200, 50, 70, 20); 
				_AddNode.Tag = ClassLib.ComVar.Parameter_PopUp[0];
				_AddNode.Text = ClassLib.ComVar.Parameter_PopUp[1];
             
				for(int i = fgrid_NodeDef.Rows.Fixed; i < fgrid_NodeDef.Rows.Count; i++)
				{
					if(ClassLib.ComVar.Parameter_PopUp[2] == fgrid_NodeDef[i, (int)ClassLib.TBSPB_NODE_OPDEF.IxOP_TYPE].ToString())
					{
						ClassLib.ComFunction.Set_NodeProp(fgrid_NodeDef, _AddNode,  i);
						break;
					}
					else
					{
						ClassLib.ComFunction.Set_DefNodeProp(addflow_Rout);
					}
				}

				fgrid_Rout.Add_Row(fgrid_Rout.Rows.Count - 1);  

				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxFACTORY] = _Factory;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxBOM_CD] = _BomCd;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxCMP_CD] = _CmpCd;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_TYPE] = _RoutType;

//				if(fgrid_Rout.Rows.Count <= fgrid_Rout.Rows.Fixed)
//				{  
//					for(int i = (int)ClassLib.TBSPB_ROUT_BOM.IxCMP_NAME; i <= (int)ClassLib.TBSPB_ROUT_BOM.IxAVAIL_YMD; i++)
//					{
//						fgrid_Rout[fgrid_Rout.Rows.Count - 1, i] = "";
//					}
//				}
//				else
//				{
//					for(int i = (int)ClassLib.TBSPB_ROUT_BOM.IxCMP_NAME; i <= (int)ClassLib.TBSPB_ROUT_BOM.IxAVAIL_YMD; i++)
//					{
//						fgrid_Rout[fgrid_Rout.Rows.Count - 1, i] = fgrid_Rout[fgrid_Rout.Rows.Count - 2, i].ToString();
//					}
//				} 
 

				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0];
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxOP_LEVEL] = "";
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxOP_CD] = ClassLib.ComVar.Parameter_PopUp[1];
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxNODE_NO] = _Node_Index;
				fgrid_Rout[fgrid_Rout.Rows.Count - 1, (int)ClassLib.TBSPB_ROUT_BOM.IxH_ROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0];

				_Node_Index++; 

			}
			catch
			{
			}
		}

		private void menuItem_Update_Click(object sender, System.EventArgs e)
		{
			Item item; 
			Lassalle.Flow.Node node = new Lassalle.Flow.Node();  
			 
			try
			{ 
				item = addflow_Rout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item; 
					
					//factory, rout_seq, op_cd
					ClassLib.ComVar.Parameter_PopUp = new string[] {_Factory, node.Tag.ToString(), node.Text.ToString()}; 
				}


				Pop_SetRoutInfo pop_form = new Pop_SetRoutInfo(); 
				pop_form.ShowDialog(); 

				if(!pop_form._CloseSave) return;

				//-----------------------------------------------

				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					//저장 대상 품목 코드와 일치하는 노드
					if((node.Tag).ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxH_ROUT_SEQ].ToString())
					{
						if(fgrid_Rout[i, 0].ToString() != "I") fgrid_Rout[i, 0] = "U"; 
 
						fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxROUT_SEQ] = ClassLib.ComVar.Parameter_PopUp[0]; 
						fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxOP_CD] = ClassLib.ComVar.Parameter_PopUp[1]; 
					}
				}

				node.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
			}
			catch
			{
			}

		}

		private void menuItem_Delete_Click(object sender, System.EventArgs e)
		{
			Item item; 
			Lassalle.Flow.Link link;

			try
			{ 
				item = addflow_Rout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					Delete_Node((Lassalle.Flow.Node)item);
				}
			
				if (item is Lassalle.Flow.Link)
				{ 
					link = (Lassalle.Flow.Link)item;

					_Link_Delete = true; 
					_Link_Delete_Org = link.Org.Index.ToString();
					_Link_Delete_Dst = link.Dst.Index.ToString();
  
					Save_BOMRout();
					Display_Rout_Info();
				} 
			}
			catch
			{
			}
		}

		 
		/// <summary>
		/// Delete_Node : 노드 및 링크 삭제
		/// </summary>
		private void Delete_Node(Lassalle.Flow.Node arg_node)
		{
			
			//품목코드 삭제, 노드삭제, 링크삭제
			int sel_row = 0;   
 
			Lassalle.Flow.Link link = new Lassalle.Flow.Link();
			Lassalle.Flow.Node current_node = new Lassalle.Flow.Node(); 
			Lassalle.Flow.Link current_link = new Lassalle.Flow.Link();
      
			bool link_exist = false;

			try
			{
				current_node = arg_node;

				for(int i = _Rowfixed; i < fgrid_Rout.Rows.Count; i++)
				{
					if(current_node.Tag.ToString() == fgrid_Rout[i, (int)ClassLib.TBSPB_ROUT_BOM.IxH_ROUT_SEQ].ToString())
					{
						sel_row = i;
						break;
					}
				}

				foreach(Item item in addflow_Rout.Items)
				{ 
					if(item is Lassalle.Flow.Link)
					{
						link = (Lassalle.Flow.Link)item;

						if(link.Dst.Index.ToString() == current_node.Index.ToString() )
						{
							link_exist = true;
							current_link = link;  
							break;
						} 

					}// end if(link) 
				}// end foreach 

				switch(fgrid_Rout[sel_row, 0].ToString())
				{
					case "I": 
 				
						//delete node
						
						if(link_exist) addflow_Rout.Nodes[current_node.Index].Links.Remove(current_link);  
						addflow_Rout.Nodes.Remove(current_node);  

						//delete fgrid_BOM
						fgrid_Rout.Rows.Remove(sel_row); 

						break;

					default:
 
						fgrid_Rout.Delete_Row(sel_row);

						//delete node
						if(link_exist) 
						{
							_Link_Delete = true;
							_Link_Delete_Org = current_link.Org.Index.ToString();
							_Link_Delete_Dst = current_link.Dst.Index.ToString(); 
						}
						else
						{
							_Link_Delete = false;
						}
 
						Save_BOMRout();
						Display_Rout_Info();

						break;
					
				} //end if
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Delete_Node",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}

		private void menuItem_NodeProp_Click(object sender, System.EventArgs e)
		{
			try
			{
				Item item;
				Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
				Lassalle.Flow.Node node = new Lassalle.Flow.Node();  
			 
				item = addflow_Rout.PointedItem;

				if (item is Lassalle.Flow.Node)
				{
					node = (Lassalle.Flow.Node)item;
					dlgflow.NodePropertyPage(addflow_Rout, node); 
				}

				//바로 저장
				Save_BOMRout(); 

			}
			catch
			{
			}

		}

		private void menuItem_LinkProp_Click(object sender, System.EventArgs e)
		{
			Item item;
			Lassalle.DlgFlow.DlgFlow dlgflow = new Lassalle.DlgFlow.DlgFlow();
			Lassalle.Flow.Link link = new Lassalle.Flow.Link(); 
			
			try
			{
				item = addflow_Rout.PointedItem;

				if (item is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item;
					dlgflow.LinkPropertyPage(addflow_Rout, link); 
				}

				//바로 저장
				Save_BOMRout();
			}
			catch
			{
			}

		}

		
		#endregion 

		#region DB Connect

		/// <summary>
		/// Select_Default_NodeLinkProp :Default Node, Link 속성
		/// </summary>
		private DataSet Select_Default_NodeLinkProp()
		{
			DataSet ds_ret; 

			try
			{ 
				//Default Node 속성
				string process_name = "PKG_SPB_OPCD.SELECT_OPTYPE_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				//Default Link 속성
				process_name = "PKG_SPB_BOM.SELECT_LINKPROP_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(false);

				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null; 
				return ds_ret; 
			}
			catch
			{ 
				return null; 
			}  
 
		} 
  
		/// <summary>
		/// Select_SPB_ROUT_BOM : BOM 라우팅 리스트 
		/// </summary>
		private DataTable Select_SPB_ROUT_BOM()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_LIST";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _BomCd; 
				MyOraDB.Parameter_Values[2] = _CmpCd; 
				MyOraDB.Parameter_Values[3] = _RoutType; 
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			}  
		}

		/// <summary>
		/// Select_SPB_ROUT_BOM_NodeLink : BOM 라우팅 Node, Link 속성
		/// </summary>
		private DataSet Select_SPB_ROUT_BOM_NodeLink()
		{
			DataSet ds_ret; 

			try
			{ 
				//Node Rout
				string process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_NODE";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _BomCd; 
				MyOraDB.Parameter_Values[2] = _CmpCd; 
				MyOraDB.Parameter_Values[3] = _RoutType; 
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(true); 

				//Link Rout
				process_name = "PKG_SPB_ROUT.SELECT_BOMROUT_LINK";

				MyOraDB.ReDim_Parameter(5); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_BOM_CD";
				MyOraDB.Parameter_Name[2] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[3] = "ARG_ROUT_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _BomCd; 
				MyOraDB.Parameter_Values[2] = _CmpCd; 
				MyOraDB.Parameter_Values[3] = _RoutType; 
				MyOraDB.Parameter_Values[4] = "";  

				MyOraDB.Add_Select_Parameter(false);

				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null; 
				return ds_ret; 

			}
			catch
			{ 
				return null; 
			}  
		}

 
	 

		#endregion


		private void Pop_SetBomRoutInfo_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
	

	}
}

