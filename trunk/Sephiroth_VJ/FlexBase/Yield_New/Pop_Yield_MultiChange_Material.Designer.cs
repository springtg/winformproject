namespace FlexBase.Yield_New
{
    partial class Pop_Yield_MultiChange_Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_MultiChange_Material));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.fgrid_Style = new COM.FSP();
            this.panel_SearchOption = new System.Windows.Forms.Panel();
            this.groupBox_SearchOption = new System.Windows.Forms.GroupBox();
            this.chk_ChangeOnlyYield = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_StyleOption = new System.Windows.Forms.Label();
            this.chk_Color = new System.Windows.Forms.CheckBox();
            this.chk_Component = new System.Windows.Forms.CheckBox();
            this.chk_Spec = new System.Windows.Forms.CheckBox();
            this.chk_Item = new System.Windows.Forms.CheckBox();
            this.panel_Value = new System.Windows.Forms.Panel();
            this.fgrid_Value = new COM.FSP();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.groupBox_Select = new System.Windows.Forms.GroupBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Spec = new System.Windows.Forms.TextBox();
            this.lbl_Spec = new System.Windows.Forms.Label();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.txt_Component = new System.Windows.Forms.TextBox();
            this.lbl_Component = new System.Windows.Forms.Label();
            this.txt_SG = new System.Windows.Forms.TextBox();
            this.lbl_SG = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.lbl_AllSizeValue = new System.Windows.Forms.Label();
            this.txt_AllSizeValue = new System.Windows.Forms.TextBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.img_SmallButton = new System.Windows.Forms.ImageList(this.components);
            this.btn_GetSizeGroup_Item = new System.Windows.Forms.Button();
            this.btn_GetSpecGroup = new System.Windows.Forms.Button();
            this.btn_GetSizeGroup = new System.Windows.Forms.Button();
            this.btn_GetSpecBySize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
            this.panel_SearchOption.SuspendLayout();
            this.groupBox_SearchOption.SuspendLayout();
            this.panel_Value.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Value)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.groupBox_Select.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.SuspendLayout();
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
            this.c1ToolBar1.Location = new System.Drawing.Point(972, 4);
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(900, 23);
            this.lbl_MainTitle.Text = "Change Material";
            // 
            // panel_Body
            // 
            this.panel_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Body.Controls.Add(this.fgrid_Style);
            this.panel_Body.Controls.Add(this.panel_SearchOption);
            this.panel_Body.Controls.Add(this.panel_Value);
            this.panel_Body.Controls.Add(this.panel_Top);
            this.panel_Body.Controls.Add(this.panel_Button);
            this.panel_Body.Location = new System.Drawing.Point(0, 56);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(792, 510);
            this.panel_Body.TabIndex = 26;
            // 
            // fgrid_Style
            // 
            this.fgrid_Style.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Style.Location = new System.Drawing.Point(0, 128);
            this.fgrid_Style.Name = "fgrid_Style";
            this.fgrid_Style.Rows.DefaultSize = 19;
            this.fgrid_Style.Size = new System.Drawing.Size(792, 277);
            this.fgrid_Style.StyleInfo = resources.GetString("fgrid_Style.StyleInfo");
            this.fgrid_Style.TabIndex = 7;
            // 
            // panel_SearchOption
            // 
            this.panel_SearchOption.Controls.Add(this.groupBox_SearchOption);
            this.panel_SearchOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchOption.Location = new System.Drawing.Point(0, 85);
            this.panel_SearchOption.Name = "panel_SearchOption";
            this.panel_SearchOption.Size = new System.Drawing.Size(792, 43);
            this.panel_SearchOption.TabIndex = 6;
            // 
            // groupBox_SearchOption
            // 
            this.groupBox_SearchOption.Controls.Add(this.chk_ChangeOnlyYield);
            this.groupBox_SearchOption.Controls.Add(this.btn_Search);
            this.groupBox_SearchOption.Controls.Add(this.lbl_StyleOption);
            this.groupBox_SearchOption.Controls.Add(this.chk_Color);
            this.groupBox_SearchOption.Controls.Add(this.chk_Component);
            this.groupBox_SearchOption.Controls.Add(this.chk_Spec);
            this.groupBox_SearchOption.Controls.Add(this.chk_Item);
            this.groupBox_SearchOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SearchOption.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox_SearchOption.Location = new System.Drawing.Point(0, 0);
            this.groupBox_SearchOption.Name = "groupBox_SearchOption";
            this.groupBox_SearchOption.Size = new System.Drawing.Size(792, 43);
            this.groupBox_SearchOption.TabIndex = 2;
            this.groupBox_SearchOption.TabStop = false;
            // 
            // chk_ChangeOnlyYield
            // 
            this.chk_ChangeOnlyYield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_ChangeOnlyYield.AutoSize = true;
            this.chk_ChangeOnlyYield.BackColor = System.Drawing.SystemColors.Window;
            this.chk_ChangeOnlyYield.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_ChangeOnlyYield.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_ChangeOnlyYield.ForeColor = System.Drawing.Color.Blue;
            this.chk_ChangeOnlyYield.Location = new System.Drawing.Point(627, 17);
            this.chk_ChangeOnlyYield.Name = "chk_ChangeOnlyYield";
            this.chk_ChangeOnlyYield.Size = new System.Drawing.Size(161, 17);
            this.chk_ChangeOnlyYield.TabIndex = 1583;
            this.chk_ChangeOnlyYield.Text = "Change only yield value";
            this.chk_ChangeOnlyYield.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Search.ImageIndex = 0;
            this.btn_Search.Location = new System.Drawing.Point(368, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(70, 21);
            this.btn_Search.TabIndex = 1582;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_StyleOption
            // 
            this.lbl_StyleOption.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_StyleOption.ImageIndex = 1;
            this.lbl_StyleOption.ImageList = this.img_Label;
            this.lbl_StyleOption.Location = new System.Drawing.Point(7, 14);
            this.lbl_StyleOption.Name = "lbl_StyleOption";
            this.lbl_StyleOption.Size = new System.Drawing.Size(100, 21);
            this.lbl_StyleOption.TabIndex = 1577;
            this.lbl_StyleOption.Text = "Style Option";
            this.lbl_StyleOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_Color
            // 
            this.chk_Color.AutoSize = true;
            this.chk_Color.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Color.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_Color.Location = new System.Drawing.Point(313, 16);
            this.chk_Color.Name = "chk_Color";
            this.chk_Color.Size = new System.Drawing.Size(54, 17);
            this.chk_Color.TabIndex = 1581;
            this.chk_Color.Text = "Color";
            this.chk_Color.UseVisualStyleBackColor = false;
            // 
            // chk_Component
            // 
            this.chk_Component.AutoSize = true;
            this.chk_Component.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Component.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Component.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_Component.Location = new System.Drawing.Point(110, 16);
            this.chk_Component.Name = "chk_Component";
            this.chk_Component.Size = new System.Drawing.Size(89, 17);
            this.chk_Component.TabIndex = 1578;
            this.chk_Component.Text = "Component";
            this.chk_Component.UseVisualStyleBackColor = false;
            // 
            // chk_Spec
            // 
            this.chk_Spec.AutoSize = true;
            this.chk_Spec.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Spec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Spec.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_Spec.Location = new System.Drawing.Point(255, 16);
            this.chk_Spec.Name = "chk_Spec";
            this.chk_Spec.Size = new System.Drawing.Size(55, 17);
            this.chk_Spec.TabIndex = 1580;
            this.chk_Spec.Text = "Spec.";
            this.chk_Spec.UseVisualStyleBackColor = false;
            // 
            // chk_Item
            // 
            this.chk_Item.AutoSize = true;
            this.chk_Item.BackColor = System.Drawing.SystemColors.Window;
            this.chk_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Item.Font = new System.Drawing.Font("Verdana", 8F);
            this.chk_Item.Location = new System.Drawing.Point(202, 16);
            this.chk_Item.Name = "chk_Item";
            this.chk_Item.Size = new System.Drawing.Size(50, 17);
            this.chk_Item.TabIndex = 1579;
            this.chk_Item.Text = "Item";
            this.chk_Item.UseVisualStyleBackColor = false;
            // 
            // panel_Value
            // 
            this.panel_Value.Controls.Add(this.fgrid_Value);
            this.panel_Value.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Value.Location = new System.Drawing.Point(0, 405);
            this.panel_Value.Name = "panel_Value";
            this.panel_Value.Size = new System.Drawing.Size(792, 75);
            this.panel_Value.TabIndex = 5;
            // 
            // fgrid_Value
            // 
            this.fgrid_Value.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Value.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Value.Name = "fgrid_Value";
            this.fgrid_Value.Rows.DefaultSize = 19;
            this.fgrid_Value.Size = new System.Drawing.Size(792, 75);
            this.fgrid_Value.StyleInfo = resources.GetString("fgrid_Value.StyleInfo");
            this.fgrid_Value.TabIndex = 7;
            this.fgrid_Value.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Value_StartEdit);
            this.fgrid_Value.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Value_AfterEdit);
            this.fgrid_Value.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_Value_MouseUp);
            this.fgrid_Value.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Value_AfterResizeColumn);
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.groupBox_Select);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(792, 85);
            this.panel_Top.TabIndex = 4;
            // 
            // groupBox_Select
            // 
            this.groupBox_Select.Controls.Add(this.lbl_Color);
            this.groupBox_Select.Controls.Add(this.txt_Color);
            this.groupBox_Select.Controls.Add(this.txt_Spec);
            this.groupBox_Select.Controls.Add(this.lbl_Spec);
            this.groupBox_Select.Controls.Add(this.txt_Size);
            this.groupBox_Select.Controls.Add(this.txt_Unit);
            this.groupBox_Select.Controls.Add(this.txt_Item);
            this.groupBox_Select.Controls.Add(this.lbl_Item);
            this.groupBox_Select.Controls.Add(this.txt_Component);
            this.groupBox_Select.Controls.Add(this.lbl_Component);
            this.groupBox_Select.Controls.Add(this.txt_SG);
            this.groupBox_Select.Controls.Add(this.lbl_SG);
            this.groupBox_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Select.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBox_Select.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Select.Name = "groupBox_Select";
            this.groupBox_Select.Size = new System.Drawing.Size(792, 85);
            this.groupBox_Select.TabIndex = 1;
            this.groupBox_Select.TabStop = false;
            // 
            // lbl_Color
            // 
            this.lbl_Color.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Color.ImageIndex = 0;
            this.lbl_Color.ImageList = this.img_Label;
            this.lbl_Color.Location = new System.Drawing.Point(405, 58);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(100, 21);
            this.lbl_Color.TabIndex = 1570;
            this.lbl_Color.Text = "Color";
            this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Color
            // 
            this.txt_Color.BackColor = System.Drawing.Color.White;
            this.txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Color.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Color.Location = new System.Drawing.Point(506, 58);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(275, 19);
            this.txt_Color.TabIndex = 5;
            this.txt_Color.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Color_KeyUp);
            // 
            // txt_Spec
            // 
            this.txt_Spec.BackColor = System.Drawing.Color.White;
            this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Spec.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Spec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Spec.Location = new System.Drawing.Point(108, 58);
            this.txt_Spec.Name = "txt_Spec";
            this.txt_Spec.Size = new System.Drawing.Size(275, 19);
            this.txt_Spec.TabIndex = 4;
            this.txt_Spec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Spec_KeyUp);
            // 
            // lbl_Spec
            // 
            this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Spec.ImageIndex = 0;
            this.lbl_Spec.ImageList = this.img_Label;
            this.lbl_Spec.Location = new System.Drawing.Point(7, 58);
            this.lbl_Spec.Name = "lbl_Spec";
            this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
            this.lbl_Spec.TabIndex = 1567;
            this.lbl_Spec.Text = "Spec";
            this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Size
            // 
            this.txt_Size.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Size.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Size.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Size.Location = new System.Drawing.Point(723, 37);
            this.txt_Size.MaxLength = 100;
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.ReadOnly = true;
            this.txt_Size.Size = new System.Drawing.Size(58, 19);
            this.txt_Size.TabIndex = 1566;
            // 
            // txt_Unit
            // 
            this.txt_Unit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Unit.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Unit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Unit.Location = new System.Drawing.Point(664, 37);
            this.txt_Unit.MaxLength = 100;
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.ReadOnly = true;
            this.txt_Unit.Size = new System.Drawing.Size(58, 19);
            this.txt_Unit.TabIndex = 1565;
            // 
            // txt_Item
            // 
            this.txt_Item.BackColor = System.Drawing.Color.White;
            this.txt_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Item.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Item.Location = new System.Drawing.Point(108, 37);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(555, 19);
            this.txt_Item.TabIndex = 3;
            this.txt_Item.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Item_KeyUp);
            // 
            // lbl_Item
            // 
            this.lbl_Item.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Item.ImageIndex = 0;
            this.lbl_Item.ImageList = this.img_Label;
            this.lbl_Item.Location = new System.Drawing.Point(7, 36);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item.TabIndex = 1563;
            this.lbl_Item.Text = "Item/ Unit/ Size";
            this.lbl_Item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Component
            // 
            this.txt_Component.BackColor = System.Drawing.Color.White;
            this.txt_Component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Component.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_Component.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Component.Location = new System.Drawing.Point(293, 16);
            this.txt_Component.Name = "txt_Component";
            this.txt_Component.Size = new System.Drawing.Size(488, 19);
            this.txt_Component.TabIndex = 2;
            this.txt_Component.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Component_KeyUp);
            // 
            // lbl_Component
            // 
            this.lbl_Component.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_Component.ImageIndex = 0;
            this.lbl_Component.ImageList = this.img_Label;
            this.lbl_Component.Location = new System.Drawing.Point(192, 14);
            this.lbl_Component.Name = "lbl_Component";
            this.lbl_Component.Size = new System.Drawing.Size(100, 21);
            this.lbl_Component.TabIndex = 1561;
            this.lbl_Component.Text = "Component";
            this.lbl_Component.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SG
            // 
            this.txt_SG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SG.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_SG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SG.Location = new System.Drawing.Point(108, 16);
            this.txt_SG.Name = "txt_SG";
            this.txt_SG.ReadOnly = true;
            this.txt_SG.Size = new System.Drawing.Size(58, 19);
            this.txt_SG.TabIndex = 1;
            // 
            // lbl_SG
            // 
            this.lbl_SG.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_SG.ImageIndex = 0;
            this.lbl_SG.ImageList = this.img_Label;
            this.lbl_SG.Location = new System.Drawing.Point(7, 14);
            this.lbl_SG.Name = "lbl_SG";
            this.lbl_SG.Size = new System.Drawing.Size(100, 21);
            this.lbl_SG.TabIndex = 1557;
            this.lbl_SG.Text = "SG";
            this.lbl_SG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.btn_GetSizeGroup_Item);
            this.panel_Button.Controls.Add(this.btn_GetSpecGroup);
            this.panel_Button.Controls.Add(this.btn_GetSizeGroup);
            this.panel_Button.Controls.Add(this.btn_GetSpecBySize);
            this.panel_Button.Controls.Add(this.lbl_AllSizeValue);
            this.panel_Button.Controls.Add(this.txt_AllSizeValue);
            this.panel_Button.Controls.Add(this.btn_Apply);
            this.panel_Button.Controls.Add(this.btn_Cancel);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(0, 480);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(792, 30);
            this.panel_Button.TabIndex = 3;
            // 
            // lbl_AllSizeValue
            // 
            this.lbl_AllSizeValue.Font = new System.Drawing.Font("Verdana", 8F);
            this.lbl_AllSizeValue.Location = new System.Drawing.Point(3, 3);
            this.lbl_AllSizeValue.Name = "lbl_AllSizeValue";
            this.lbl_AllSizeValue.Size = new System.Drawing.Size(100, 19);
            this.lbl_AllSizeValue.TabIndex = 699;
            this.lbl_AllSizeValue.Text = "* All Size Value";
            this.lbl_AllSizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_AllSizeValue
            // 
            this.txt_AllSizeValue.BackColor = System.Drawing.Color.White;
            this.txt_AllSizeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AllSizeValue.Font = new System.Drawing.Font("Verdana", 7F);
            this.txt_AllSizeValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_AllSizeValue.Location = new System.Drawing.Point(104, 3);
            this.txt_AllSizeValue.MaxLength = 10;
            this.txt_AllSizeValue.Name = "txt_AllSizeValue";
            this.txt_AllSizeValue.Size = new System.Drawing.Size(79, 19);
            this.txt_AllSizeValue.TabIndex = 698;
            this.txt_AllSizeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_AllSizeValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_AllSizeValue_KeyUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Apply.ImageIndex = 0;
            this.btn_Apply.Location = new System.Drawing.Point(648, 2);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(70, 21);
            this.btn_Apply.TabIndex = 8;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.Location = new System.Drawing.Point(720, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 21);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.TransparentColor = System.Drawing.Color.Transparent;
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
            // 
            // btn_GetSizeGroup_Item
            // 
            this.btn_GetSizeGroup_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetSizeGroup_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetSizeGroup_Item.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_GetSizeGroup_Item.ImageIndex = 0;
            this.btn_GetSizeGroup_Item.Location = new System.Drawing.Point(413, 2);
            this.btn_GetSizeGroup_Item.Name = "btn_GetSizeGroup_Item";
            this.btn_GetSizeGroup_Item.Size = new System.Drawing.Size(100, 21);
            this.btn_GetSizeGroup_Item.TabIndex = 703;
            this.btn_GetSizeGroup_Item.Text = "Group: Item";
            this.btn_GetSizeGroup_Item.Click += new System.EventHandler(this.btn_GetSizeGroup_Item_Click);
            // 
            // btn_GetSpecGroup
            // 
            this.btn_GetSpecGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetSpecGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetSpecGroup.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_GetSpecGroup.ImageIndex = 0;
            this.btn_GetSpecGroup.Location = new System.Drawing.Point(514, 2);
            this.btn_GetSpecGroup.Name = "btn_GetSpecGroup";
            this.btn_GetSpecGroup.Size = new System.Drawing.Size(100, 21);
            this.btn_GetSpecGroup.TabIndex = 702;
            this.btn_GetSpecGroup.Text = "Spec Group";
            this.btn_GetSpecGroup.Click += new System.EventHandler(this.btn_GetSpecGroup_Click);
            // 
            // btn_GetSizeGroup
            // 
            this.btn_GetSizeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetSizeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetSizeGroup.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_GetSizeGroup.ImageIndex = 0;
            this.btn_GetSizeGroup.Location = new System.Drawing.Point(287, 2);
            this.btn_GetSizeGroup.Name = "btn_GetSizeGroup";
            this.btn_GetSizeGroup.Size = new System.Drawing.Size(125, 21);
            this.btn_GetSizeGroup.TabIndex = 701;
            this.btn_GetSizeGroup.Text = "Group: Style, Item";
            this.btn_GetSizeGroup.Click += new System.EventHandler(this.btn_GetSizeGroup_Click);
            // 
            // btn_GetSpecBySize
            // 
            this.btn_GetSpecBySize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetSpecBySize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetSpecBySize.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_GetSpecBySize.ImageIndex = 0;
            this.btn_GetSpecBySize.Location = new System.Drawing.Point(186, 2);
            this.btn_GetSpecBySize.Name = "btn_GetSpecBySize";
            this.btn_GetSpecBySize.Size = new System.Drawing.Size(100, 21);
            this.btn_GetSpecBySize.TabIndex = 700;
            this.btn_GetSpecBySize.Text = "Spec by Size";
            this.btn_GetSpecBySize.Click += new System.EventHandler(this.btn_GetSpecBySize_Click);
            // 
            // Pop_Yield_MultiChange_Material
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Verdana", 9F);
            this.Name = "Pop_Yield_MultiChange_Material";
            this.Text = "Change Material";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.panel_Body, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
            this.panel_SearchOption.ResumeLayout(false);
            this.groupBox_SearchOption.ResumeLayout(false);
            this.groupBox_SearchOption.PerformLayout();
            this.panel_Value.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Value)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.groupBox_Select.ResumeLayout(false);
            this.groupBox_Select.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.panel_Button.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.ImageList img_SmallButton;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Value;
        public COM.FSP fgrid_Value;
        private System.Windows.Forms.GroupBox groupBox_Select;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Spec;
        private System.Windows.Forms.Label lbl_Spec;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.TextBox txt_Component;
        private System.Windows.Forms.Label lbl_Component;
        private System.Windows.Forms.TextBox txt_SG;
        private System.Windows.Forms.Label lbl_SG;
        private System.Windows.Forms.Label lbl_AllSizeValue;
        private System.Windows.Forms.TextBox txt_AllSizeValue;
        private System.Windows.Forms.Panel panel_SearchOption;
        private System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.CheckBox chk_Color;
        public System.Windows.Forms.CheckBox chk_Spec;
        public System.Windows.Forms.CheckBox chk_Item;
        public System.Windows.Forms.CheckBox chk_Component;
        private System.Windows.Forms.Label lbl_StyleOption;
        private System.Windows.Forms.GroupBox groupBox_SearchOption;
        private COM.FSP fgrid_Style;
        public System.Windows.Forms.CheckBox chk_ChangeOnlyYield;
        private System.Windows.Forms.Button btn_GetSizeGroup_Item;
        private System.Windows.Forms.Button btn_GetSpecGroup;
        private System.Windows.Forms.Button btn_GetSizeGroup;
        private System.Windows.Forms.Button btn_GetSpecBySize;
    }
}