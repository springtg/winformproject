using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_Finder : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.TextBox txt_key;
		private C1.Win.C1List.C1Combo cmb_item;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		private COM.FSP arg_fgrid;
		private int _startcol, _endcol;
		private System.Windows.Forms.RadioButton rad_first;
		private System.Windows.Forms.RadioButton rad_current;

		public Pop_Finder(COM.FSP arg_fgrid, int startcol, int endcol)
		{
			InitializeComponent();

			this.arg_fgrid = arg_fgrid;
			_startcol = startcol;
			_endcol = endcol;

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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Finder));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.cmb_item = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_first = new System.Windows.Forms.RadioButton();
            this.rad_current = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_item)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_shipType);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.cmb_item);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 80);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Data";
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(16, 23);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 193;
            this.lbl_shipType.Text = "Item";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(293, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 190;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_key
            // 
            this.txt_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_key.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_key.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_key.Location = new System.Drawing.Point(116, 45);
            this.txt_key.MaxLength = 20;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(177, 21);
            this.txt_key.TabIndex = 189;
            this.txt_key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_key_KeyPress);
            // 
            // cmb_item
            // 
            this.cmb_item.AddItemCols = 0;
            this.cmb_item.AddItemSeparator = ';';
            this.cmb_item.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_item.Caption = "";
            this.cmb_item.CaptionHeight = 17;
            this.cmb_item.CaptionStyle = style1;
            this.cmb_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_item.ColumnCaptionHeight = 18;
            this.cmb_item.ColumnFooterHeight = 18;
            this.cmb_item.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_item.ContentHeight = 16;
            this.cmb_item.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_item.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_item.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_item.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_item.EditorHeight = 16;
            this.cmb_item.EvenRowStyle = style2;
            this.cmb_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_item.FooterStyle = style3;
            this.cmb_item.GapHeight = 2;
            this.cmb_item.HeadingStyle = style4;
            this.cmb_item.HighLightRowStyle = style5;
            this.cmb_item.ItemHeight = 15;
            this.cmb_item.Location = new System.Drawing.Point(116, 23);
            this.cmb_item.MatchEntryTimeout = ((long)(2000));
            this.cmb_item.MaxDropDownItems = ((short)(5));
            this.cmb_item.MaxLength = 32767;
            this.cmb_item.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.OddRowStyle = style6;
            this.cmb_item.PartialRightColumn = false;
            this.cmb_item.PropBag = resources.GetString("cmb_item.PropBag");
            this.cmb_item.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_item.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_item.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_item.SelectedStyle = style7;
            this.cmb_item.Size = new System.Drawing.Size(200, 20);
            this.cmb_item.Style = style8;
            this.cmb_item.TabIndex = 191;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 192;
            this.label1.Text = "Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad_first
            // 
            this.rad_first.BackColor = System.Drawing.Color.Transparent;
            this.rad_first.Checked = true;
            this.rad_first.Location = new System.Drawing.Point(216, 24);
            this.rad_first.Name = "rad_first";
            this.rad_first.Size = new System.Drawing.Size(56, 24);
            this.rad_first.TabIndex = 29;
            this.rad_first.TabStop = true;
            this.rad_first.Text = "First";
            this.rad_first.UseVisualStyleBackColor = false;
            // 
            // rad_current
            // 
            this.rad_current.BackColor = System.Drawing.Color.Transparent;
            this.rad_current.Location = new System.Drawing.Point(272, 24);
            this.rad_current.Name = "rad_current";
            this.rad_current.Size = new System.Drawing.Size(80, 24);
            this.rad_current.TabIndex = 29;
            this.rad_current.Text = "Current";
            this.rad_current.UseVisualStyleBackColor = false;
            // 
            // Pop_Finder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(346, 127);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rad_current);
            this.Controls.Add(this.rad_first);
            this.Name = "Pop_Finder";
            this.TopMost = true;
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.rad_first, 0);
            this.Controls.SetChildIndex(this.rad_current, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_item)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 멤버 메서드		

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			this.Text = "Find";
            lbl_MainTitle.Text = "Find";
            ClassLib.ComFunction.SetLangDic(this);

			int vInitRow = 0;
			int size = _endcol - _startcol + 1;

			string[] codes = new string[size];
			string[] names = new string[size];

			for (int cnt = 0 ; cnt < size ; cnt++)
			{
				codes[cnt] = _startcol + "";
				names[cnt] = arg_fgrid[1, _startcol++].ToString();

				if (names[cnt].IndexOf("Style") > -1 && vInitRow == 0)
                    vInitRow = cnt;
			}

			COM.ComCtl.Set_ComboList(makeDataTable(codes, names), cmb_item, 0, 1, false);
			cmb_item.SelectedIndex = vInitRow;

			this.Location = new Point(arg_fgrid.Right - this.Size.Width, arg_fgrid.Top + this.Size.Height);
			arg_fgrid.Disposed += new EventHandler(arg_fgrid_Disposed);

		}
	
		private DataTable makeDataTable(string[] codes, string[] names)
		{
			DataTable temp_datatable = new DataTable(); 
			DataRow newrow;
 
			try
			{
				temp_datatable.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				temp_datatable.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

				for(int i = 0 ; i < codes.Length ; i++)
				{
					newrow = temp_datatable.NewRow();
					newrow["Code"] = codes[i];
					newrow["Name"] = names[i];
					temp_datatable.Rows.Add(newrow);
				} 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			return temp_datatable;
		}

		#endregion

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			string vkey = txt_key.Text;
			if (cmb_item.SelectedIndex == -1)
			{
				MessageBox.Show("Select item", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int vitemcol = int.Parse(cmb_item.SelectedValue.ToString());
			int vstartrow = arg_fgrid.Rows.Fixed;

			if (rad_first.Checked)
			{
				vstartrow = arg_fgrid.Rows.Fixed;
			}
			else
			{
				vstartrow = (arg_fgrid.Selection.r1 < arg_fgrid.Rows.Fixed) ? arg_fgrid.Rows.Fixed : arg_fgrid.Selection.r1 + 1;
			}

			int cnt = arg_fgrid.Rows.Fixed;
			
			for (cnt = vstartrow ; cnt < arg_fgrid.Rows.Count ; cnt++)
			{
				string vdataForGrid = (arg_fgrid[cnt, vitemcol] == null) ? "" : arg_fgrid[cnt, vitemcol].ToString();

				if (vdataForGrid.IndexOf(vkey) > -1)
				{
					arg_fgrid.Select(cnt, vitemcol);
					break;
				}
			}

			if (cnt == arg_fgrid.Rows.Count)
			{
				for (cnt = arg_fgrid.Rows.Fixed ; cnt <= vstartrow ; cnt++)
				{
					string vdataForGrid = (arg_fgrid[cnt, vitemcol] == null) ? "" : arg_fgrid[cnt, vitemcol].ToString();

					if (vdataForGrid.IndexOf(vkey) > -1)
					{
						arg_fgrid.Select(cnt, vitemcol);
						break;
					}
				}
			}
		}

		private void txt_key_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
				btn_search_Click(null, null);
		}

		private void cmb_item_SelectedValueChanged(object sender, System.EventArgs e)
		{
			int vitemcol = int.Parse(cmb_item.SelectedValue.ToString());
			arg_fgrid.Select(arg_fgrid.Rows.Fixed, vitemcol);
		}

		private void arg_fgrid_Disposed(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}

