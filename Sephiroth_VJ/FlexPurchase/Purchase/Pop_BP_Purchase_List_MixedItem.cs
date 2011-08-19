using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FlexPurchase.Purchase
{
	/// <summary>
	/// Pop_BS_Purchase_List_CItem에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_BP_Purchase_List_MixedItem : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_titleHead;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_item;
		private System.ComponentModel.IContainer components;
		private C1.Win.C1List.C1Combo cmb_value;
		private System.Windows.Forms.TextBox txt_code;


		#region 사용자 정의 변수

        private string _title = null;		
		private System.EventHandler txt_codeEventHandler = null;
		private System.EventHandler cmb_valueEventHandler = null;

		#endregion

		public Pop_BP_Purchase_List_MixedItem()
		{
			// 이 호출은 Windows.Forms Form 디자이너에 필요합니다.
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
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BP_Purchase_List_MixedItem));
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_apply = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.cmb_value = new C1.Win.C1List.C1Combo();
			this.lbl_item = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_titleHead = new System.Windows.Forms.Label();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.txt_code = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(70, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_apply
			// 
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.ImageIndex = 1;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(203, 64);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 235;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ImageIndex = 1;
			this.btn_cancel.ImageList = this.img_Button;
			this.btn_cancel.Location = new System.Drawing.Point(275, 64);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 236;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// cmb_value
			// 
			this.cmb_value.AddItemCols = 0;
			this.cmb_value.AddItemSeparator = ';';
			this.cmb_value.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_value.AutoSize = false;
			this.cmb_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_value.Caption = "";
			this.cmb_value.CaptionHeight = 17;
			this.cmb_value.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_value.ColumnCaptionHeight = 18;
			this.cmb_value.ColumnFooterHeight = 18;
			this.cmb_value.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_value.ContentHeight = 17;
			this.cmb_value.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_value.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_value.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_value.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_value.EditorHeight = 17;
			this.cmb_value.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_value.GapHeight = 2;
			this.cmb_value.ItemHeight = 15;
			this.cmb_value.Location = new System.Drawing.Point(206, 40);
			this.cmb_value.MatchEntryTimeout = ((long)(2000));
			this.cmb_value.MaxDropDownItems = ((short)(5));
			this.cmb_value.MaxLength = 32767;
			this.cmb_value.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_value.Name = "cmb_value";
			this.cmb_value.PartialRightColumn = false;
			this.cmb_value.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"18" +
				"\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cli" +
				"entRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HS" +
				"crollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Style" +
				"9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" m" +
				"e=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"Hea" +
				"ding\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Inac" +
				"tiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Style" +
				"8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle " +
				"parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C1" +
				"List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style par" +
				"ent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent=" +
				"\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=\"" +
				"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style parent" +
				"=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"Hea" +
				"ding\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles><" +
				"vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Def" +
				"aultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_value.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_value.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_value.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_value.Size = new System.Drawing.Size(139, 21);
			this.cmb_value.TabIndex = 233;
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(248)), ((System.Byte)(218)));
			this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.Location = new System.Drawing.Point(24, 40);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 246;
			this.lbl_item.Text = "Vendor";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(352, 85);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 244;
			this.pic_head3.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 85);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 243;
			this.pic_head5.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 84);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(224, 24);
			this.pic_head4.TabIndex = 242;
			this.pic_head4.TabStop = false;
			// 
			// lbl_titleHead
			// 
			this.lbl_titleHead.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_titleHead.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_titleHead.ForeColor = System.Drawing.Color.Navy;
			this.lbl_titleHead.Image = ((System.Drawing.Image)(resources.GetObject("lbl_titleHead.Image")));
			this.lbl_titleHead.Location = new System.Drawing.Point(0, 0);
			this.lbl_titleHead.Name = "lbl_titleHead";
			this.lbl_titleHead.Size = new System.Drawing.Size(231, 30);
			this.lbl_titleHead.TabIndex = 238;
			this.lbl_titleHead.Text = "      Information Change";
			this.lbl_titleHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 24);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(344, 72);
			this.pic_head6.TabIndex = 241;
			this.pic_head6.TabStop = false;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(267, 29);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 67);
			this.pic_head7.TabIndex = 240;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(351, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 239;
			this.pic_head2.TabStop = false;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(200, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(160, 32);
			this.pic_head1.TabIndex = 237;
			this.pic_head1.TabStop = false;
			// 
			// txt_code
			// 
			this.txt_code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_code.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_code.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_code.Location = new System.Drawing.Point(125, 40);
			this.txt_code.MaxLength = 10;
			this.txt_code.Name = "txt_code";
			this.txt_code.Size = new System.Drawing.Size(80, 21);
			this.txt_code.TabIndex = 247;
			this.txt_code.Text = "";
			this.txt_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_code_KeyUp);
			// 
			// Pop_BP_Purchase_List_MixedItem
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.txt_code);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.cmb_value);
			this.Controls.Add(this.lbl_item);
			this.Controls.Add(this.pic_head3);
			this.Controls.Add(this.pic_head5);
			this.Controls.Add(this.pic_head4);
			this.Controls.Add(this.lbl_titleHead);
			this.Controls.Add(this.pic_head6);
			this.Controls.Add(this.pic_head7);
			this.Controls.Add(this.pic_head2);
			this.Controls.Add(this.pic_head1);
			this.Name = "Pop_BP_Purchase_List_MixedItem";
			this.Size = new System.Drawing.Size(368, 104);
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			if (_title.Equals(ClassLib.ComVar.Vendor))
			{
				COM.ComVar.Parameter_PopUp		= new string[2];
				COM.ComVar.Parameter_PopUp[0]	= (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");
			}
			else if(_title.Equals(ClassLib.ComVar.Dept))
			{
				COM.ComVar.Parameter_PopUp		= new string[2];
				COM.ComVar.Parameter_PopUp[0]	= (cmb_value.SelectedIndex == -1) ? "" : cmb_value.GetItemText(cmb_value.SelectedIndex, 1);
				COM.ComVar.Parameter_PopUp[1]	= COM.ComFunction.Empty_Combo(cmb_value, "");
			}
			else
			{
				COM.ComVar.Parameter_PopUp		= new string[1];
				COM.ComVar.Parameter_PopUp[0]	= COM.ComFunction.Empty_Combo(cmb_value, "");
			}

			this.Dispose();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void txt_code_TextChanged(object sender, System.EventArgs e)
		{
//			this.Txt_CodeTextChangedProcess();
		}

		private void cmb_value_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ValueSelectedValueChangedProcess();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{
			lbl_item.Text = COM.ComVar.Parameter_PopUp[1];
			_title		  = COM.ComVar.Parameter_PopUp[1];

			txt_codeEventHandler	   = new System.EventHandler(txt_code_TextChanged);
			cmb_valueEventHandler	   = new System.EventHandler(cmb_value_SelectedValueChanged);
			this.txt_code.TextChanged += txt_codeEventHandler;

			txt_code.Focus();
		}

		private void Txt_CodeTextChangedProcess()
		{
			this.cmb_value.SelectedValueChanged -= cmb_valueEventHandler;

			try
			{
				DataTable vDt = new DataTable();
				if (_title.Equals(ClassLib.ComVar.Vendor))
					vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_code.Text);
				else
					vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory, txt_code.Text);

				if(vDt.Rows.Count == 0)
				{
					cmb_value.ClearItems();
					return;
				}

				ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 80, 140);

				if(vDt.Rows.Count == 1 )
					cmb_value.SelectedIndex = 0;

				vDt.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			this.cmb_value.SelectedValueChanged += cmb_valueEventHandler;
		}

		private void Txt_CodeKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				if (_title.Equals(ClassLib.ComVar.Vendor))
					vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_code.Text);
				else if(_title.Equals(ClassLib.ComVar.User))
					vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory, txt_code.Text);
				else
					vDt = ClassLib.ComFunction.SELECT_SCM_DEPT_LIST(COM.ComVar.This_Factory, txt_code.Text);
				ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 80, 140);
			}
			catch (Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}

		private void Cmb_ValueSelectedValueChangedProcess()
		{
			this.txt_code.TextChanged -= txt_codeEventHandler;

			try
			{
				txt_code.Text = cmb_value.SelectedValue.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			this.txt_code.TextChanged += txt_codeEventHandler;
		}

		#endregion

		private void txt_code_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				Txt_CodeKeyUpProcess();
		}


	}
}
