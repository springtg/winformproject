using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{
	public class Pop_BM_Print_Type : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_apply;
		private C1.Win.C1List.C1Combo cmb_print;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		#endregion

		#region 생성자 / 소멸자

		public Pop_BM_Print_Type(string com_cd)
		{
			InitializeComponent();

			// print type
			DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, com_cd);
			COM.ComCtl.Set_ComboList(vDt, cmb_print, 1, 2, false, 80, 140);
			cmb_print.SelectedIndex = 0;
			vDt.Dispose();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_BM_Print_Type));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_apply = new System.Windows.Forms.Label();
			this.cmb_print = new C1.Win.C1List.C1Combo();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_print)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(240, 23);
			this.lbl_MainTitle.Text = "Print";
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
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.cmb_print);
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 56);
			this.groupBox1.TabIndex = 27;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Print Type";
			// 
			// btn_apply
			// 
			this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_apply.ImageIndex = 0;
			this.btn_apply.ImageList = this.img_Button;
			this.btn_apply.Location = new System.Drawing.Point(196, 96);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(72, 23);
			this.btn_apply.TabIndex = 356;
			this.btn_apply.Text = "Print";
			this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// cmb_print
			// 
			this.cmb_print.AddItemCols = 0;
			this.cmb_print.AddItemSeparator = ';';
			this.cmb_print.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_print.AutoSize = false;
			this.cmb_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_print.Caption = "";
			this.cmb_print.CaptionHeight = 17;
			this.cmb_print.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_print.ColumnCaptionHeight = 18;
			this.cmb_print.ColumnFooterHeight = 18;
			this.cmb_print.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_print.ContentHeight = 17;
			this.cmb_print.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_print.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_print.EditorFont = new System.Drawing.Font("굴림", 9F);
			this.cmb_print.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_print.EditorHeight = 17;
			this.cmb_print.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_print.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_print.GapHeight = 2;
			this.cmb_print.ItemHeight = 15;
			this.cmb_print.Location = new System.Drawing.Point(20, 22);
			this.cmb_print.MatchEntryTimeout = ((long)(2000));
			this.cmb_print.MaxDropDownItems = ((short)(5));
			this.cmb_print.MaxLength = 32767;
			this.cmb_print.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_print.Name = "cmb_print";
			this.cmb_print.PartialRightColumn = false;
			this.cmb_print.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
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
				"aultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_print.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_print.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_print.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_print.Size = new System.Drawing.Size(220, 21);
			this.cmb_print.TabIndex = 14;
			// 
			// Pop_BM_Print_Type
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(274, 127);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.groupBox1);
			this.Name = "Pop_BM_Print_Type";
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_apply, 0);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_print)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 버튼 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
                string vPrint = COM.ComFunction.Empty_Combo(cmb_print, "");

				ClassLib.ComVar.Parameter_PopUp = new string[]{vPrint};

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

	}
}

