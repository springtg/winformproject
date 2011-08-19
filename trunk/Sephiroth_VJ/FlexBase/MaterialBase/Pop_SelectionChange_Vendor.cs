using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FlexBase.MaterialBase
{
	/// <summary>
	/// Pop_BS_Shipping_List_CItem에 대한 요약 설명입니다.
	/// </summary>
	public class Pop_SelectionChange_Vendor : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components;
		private C1.Win.C1List.C1Combo cmb_value;
		private System.Windows.Forms.TextBox txt_code;


		#region 사용자 정의 변수

        private string _title = null;
		private System.Windows.Forms.Label lbl_item;		
		//private System.EventHandler txt_codeEventHandler = null;
		private System.Windows.Forms.GroupBox groupBox1;
		//private System.EventHandler cmb_valueEventHandler = null;

		#endregion

		public Pop_SelectionChange_Vendor()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SelectionChange_Vendor));
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_apply = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Label();
			this.cmb_value = new C1.Win.C1List.C1Combo();
			this.txt_code = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_item = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.btn_apply.Location = new System.Drawing.Point(233, 41);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(70, 24);
			this.btn_apply.TabIndex = 235;
			this.btn_apply.Text = "Apply";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			this.btn_apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_cancel
			// 
			this.btn_cancel.ImageIndex = 1;
			this.btn_cancel.ImageList = this.img_Button;
			this.btn_cancel.Location = new System.Drawing.Point(304, 41);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_cancel.TabIndex = 236;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			this.btn_cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
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
			this.cmb_value.EditorFont = new System.Drawing.Font("굴림체", 9F);
			this.cmb_value.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_value.EditorHeight = 17;
			this.cmb_value.Font = new System.Drawing.Font("굴림체", 9F);
			this.cmb_value.GapHeight = 2;
			this.cmb_value.ItemHeight = 15;
			this.cmb_value.Location = new System.Drawing.Point(190, 14);
			this.cmb_value.MatchEntryTimeout = ((long)(2000));
			this.cmb_value.MaxDropDownItems = ((short)(5));
			this.cmb_value.MaxLength = 32767;
			this.cmb_value.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_value.Name = "cmb_value";
			this.cmb_value.PartialRightColumn = false;
			this.cmb_value.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림체, 9pt;" +
				"BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Styl" +
				"e1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Contro" +
				"l;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Styl" +
				"e10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.List" +
				"BoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight=\"1" +
				"8\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"><Cl" +
				"ientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><H" +
				"ScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"Styl" +
				"e9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Footer\" " +
				"me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=\"He" +
				"ading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><Ina" +
				"ctiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"Styl" +
				"e8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedStyle" +
				" parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Win.C" +
				"1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style pa" +
				"rent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style parent" +
				"=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style parent=" +
				"\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style paren" +
				"t=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=\"He" +
				"ading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyles>" +
				"<vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><De" +
				"faultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_value.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_value.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_value.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_value.Size = new System.Drawing.Size(184, 21);
			this.cmb_value.TabIndex = 233;
			this.cmb_value.SelectedValueChanged += new System.EventHandler(this.cmb_value_SelectedValueChanged);
			// 
			// txt_code
			// 
			this.txt_code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_code.Font = new System.Drawing.Font("굴림", 9F);
			this.txt_code.Location = new System.Drawing.Point(109, 14);
			this.txt_code.MaxLength = 100;
			this.txt_code.Name = "txt_code";
			this.txt_code.Size = new System.Drawing.Size(80, 21);
			this.txt_code.TabIndex = 247;
			this.txt_code.Text = "";
			this.txt_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_code_KeyUp);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_item);
			this.groupBox1.Controls.Add(this.btn_apply);
			this.groupBox1.Controls.Add(this.txt_code);
			this.groupBox1.Controls.Add(this.btn_cancel);
			this.groupBox1.Controls.Add(this.cmb_value);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(381, 72);
			this.groupBox1.TabIndex = 248;
			this.groupBox1.TabStop = false;
			// 
			// lbl_item
			// 
			this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(248)), ((System.Byte)(218)));
			this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_item.Location = new System.Drawing.Point(8, 14);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(100, 21);
			this.lbl_item.TabIndex = 248;
			this.lbl_item.Text = "Vendor";
			this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_SelectionChange_Vendor
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox1);
			this.Name = "Pop_SelectionChange_Vendor";
			this.Size = new System.Drawing.Size(381, 72);
			((System.ComponentModel.ISupportInitialize)(this.cmb_value)).EndInit();
			this.groupBox1.ResumeLayout(false);
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

		private void txt_code_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				Txt_CodeKeyUpProcess();
		}

		private void cmb_value_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ValueSelectedValueChangedProcess();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
		{ 
			_title		  = COM.ComVar.Parameter_PopUp[0];
		}

		private void Txt_CodeKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_code.Text);


				cmb_value.SelectedValue = txt_code.Text;

				ClassLib.ComCtl.Set_ComboList(vDt, cmb_value, 0, 1, false, 50, 250);


			}
			catch //(Exception ex)
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
			try
			{
				txt_code.Text = cmb_value.SelectedValue.ToString();
			}
			catch // (Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}



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



		#endregion

	}
}
